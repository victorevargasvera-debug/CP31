using System;
using System.Threading;
using Gibraltar.Messaging;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000264 RID: 612
	internal class RepositoryPublishEngine
	{
		// Token: 0x06001F34 RID: 7988 RVA: 0x000712C8 File Offset: 0x0006F4C8
		public RepositoryPublishEngine(global::Gibraltar.Messaging.Publisher publisher, global::Gibraltar.Monitor.AgentConfiguration configuration)
		{
			this.m_Publisher = publisher;
			this.m_Configuration = configuration;
			this.m_SessionPublishThreadFailed = true;
			this.m_RepositoryFolder = global::Gibraltar.Monitor.LocalRepository.CalculateRepositoryPath(this.m_Publisher.SessionSummary.Product, configuration.SessionFile.Folder);
			global::Gibraltar.Messaging.ServerConfiguration server = this.m_Configuration.Server;
			this.m_MultiprocessLockName = "repositoryPublish~" + this.m_Publisher.SessionSummary.Product + (server.SendAllApplications ? string.Empty : ("~" + this.m_Publisher.SessionSummary.Application));
			this.m_MultiprocessLockName = global::Gibraltar.FileSystemTools.SanitizeFileName(this.m_MultiprocessLockName);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000713BC File Offset: 0x0006F5BC
		public bool IsActive
		{
			get
			{
				return this.m_Initialized && !this.m_SessionPublishThreadFailed;
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x000713D8 File Offset: 0x0006F5D8
		public void Start()
		{
			this.EnsureSessionPublishThreadIsValid();
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x000713E0 File Offset: 0x0006F5E0
		public void Stop(bool waitForStop)
		{
			if (this.IsActive)
			{
				this.m_StopRequested = true;
				if (waitForStop)
				{
					object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
					lock (sessionPublishThreadLock)
					{
						while (this.IsActive)
						{
							global::System.Threading.Monitor.Wait(this.m_SessionPublishThreadLock, 16);
						}
						global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
					}
				}
			}
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00071458 File Offset: 0x0006F658
		private void CreateMessageDispatchThread()
		{
			object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
			lock (sessionPublishThreadLock)
			{
				this.m_SessionPublishThreadFailed = false;
				this.m_SessionPublishThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.RepositoryPublishMain));
				this.m_SessionPublishThread.Name = "Loupe Session Publisher";
				this.m_SessionPublishThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				this.m_SessionPublishThread.IsBackground = true;
				this.m_SessionPublishThread.Priority = global::System.Threading.ThreadPriority.BelowNormal;
				this.m_SessionPublishThread.Start();
				this.m_ForceCheck = true;
				global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
			}
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00071500 File Offset: 0x0006F700
		private void RepositoryPublishMain()
		{
			global::System.Threading.Thread.Sleep(5000);
			global::Gibraltar.Data.InterprocessLock interprocessLock = null;
			try
			{
				if (!global::Gibraltar.Monitor.Log.AutoSendConsentGranted)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Publish", "User has not consented to automatically send sessions", "The repository publish engine will shut down because the user has not consented to automatically send sessions.", new object[0]);
					}
				}
				else
				{
					interprocessLock = this.GetLock(0);
					while (interprocessLock == null && !this.m_StopRequested)
					{
						this.SleepUntilNextCheck(this.m_MultiprocessLockCheckInterval);
						interprocessLock = this.GetLock(0);
					}
					if (interprocessLock != null)
					{
						this.RepositoryPublishLoop();
						interprocessLock.Dispose();
						interprocessLock = null;
					}
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			finally
			{
				if (interprocessLock != null)
				{
					interprocessLock.Dispose();
				}
				object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
				lock (sessionPublishThreadLock)
				{
					this.m_SessionPublishThread = null;
					this.m_SessionPublishThreadFailed = true;
					global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
				}
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0007160C File Offset: 0x0006F80C
		private void RepositoryPublishLoop()
		{
			object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
			lock (sessionPublishThreadLock)
			{
				this.EnsureInitialized();
				global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
			}
			if (this.m_Initialized)
			{
				while (!this.m_StopRequested)
				{
					global::Gibraltar.Server.Client.HubStatus hubStatus;
					string text;
					if (this.m_Client.CanConnect(out hubStatus, out text))
					{
						string empty = string.Empty;
						if (!global::Gibraltar.Monitor.Log.SendSessionsOnExit && global::Gibraltar.Monitor.Log.CanSendSessionsOnExit(ref empty))
						{
							global::Gibraltar.Monitor.Log.SendSessionsOnExit = true;
						}
						this.m_CheckInterval = new global::System.TimeSpan(0, 0, 60);
						this.m_FailedAttempts = 0;
						this.m_Client.PublishSessions(false, this.m_Configuration.Server.PurgeSentSessions);
					}
					else if (hubStatus == global::Gibraltar.Server.Client.HubStatus.Expired)
					{
						this.m_CheckInterval = new global::System.TimeSpan(0, 0, 3600);
					}
					else if (this.m_FailedAttempts > 5)
					{
						this.m_CheckInterval = new global::System.TimeSpan(0, 0, 1800);
						this.m_FailedAttempts++;
					}
					else
					{
						this.m_CheckInterval = new global::System.TimeSpan(0, 0, 60);
						this.m_FailedAttempts++;
					}
					this.SleepUntilNextCheck(this.m_CheckInterval);
				}
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00071758 File Offset: 0x0006F958
		private void EnsureInitialized()
		{
			if (!this.m_Initialized)
			{
				object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
				lock (sessionPublishThreadLock)
				{
					try
					{
						global::Gibraltar.Monitor.LocalRepository repository = global::Gibraltar.Monitor.Log.Repository;
						global::Gibraltar.Messaging.ServerConfiguration server = this.m_Configuration.Server;
						if (server != null && server.Enabled)
						{
							this.m_Client = new global::Gibraltar.Data.Internal.RepositoryPublishClient(repository, this.m_Publisher.SessionSummary.Product, server.SendAllApplications ? null : this.m_Publisher.SessionSummary.Application, server);
						}
						this.m_Initialized = true;
					}
					catch (global::System.Exception obj)
					{
						global::System.GC.KeepAlive(obj);
					}
					global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
				}
			}
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0007182C File Offset: 0x0006FA2C
		private void EnsureSessionPublishThreadIsValid()
		{
			if (this.m_SessionPublishThreadFailed)
			{
				object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
				lock (sessionPublishThreadLock)
				{
					if (this.m_SessionPublishThreadFailed)
					{
						this.CreateMessageDispatchThread();
					}
					global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
				}
			}
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00071890 File Offset: 0x0006FA90
		private global::Gibraltar.Data.InterprocessLock GetLock(int timeout)
		{
			return global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_RepositoryFolder, this.m_MultiprocessLockName, timeout);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x000718A8 File Offset: 0x0006FAA8
		private void SleepUntilNextCheck(global::System.TimeSpan checkInterval)
		{
			object sessionPublishThreadLock = this.m_SessionPublishThreadLock;
			lock (sessionPublishThreadLock)
			{
				global::System.DateTimeOffset left = this.m_LastCheck + checkInterval;
				while (!this.m_ForceCheck && left > global::System.DateTimeOffset.Now)
				{
					global::System.Threading.Monitor.Wait(this.m_SessionPublishThreadLock, 1000);
				}
				this.m_LastCheck = global::System.DateTimeOffset.Now;
				this.m_ForceCheck = false;
				global::System.Threading.Monitor.PulseAll(this.m_SessionPublishThreadLock);
			}
		}

		// Token: 0x04000BCA RID: 3018
		private const string LogCategory = "Loupe.Repository.Publish";

		// Token: 0x04000BCB RID: 3019
		private const string BaseMultiprocessLockName = "repositoryPublish";

		// Token: 0x04000BCC RID: 3020
		private const string RepositoryPublishVersionName = "Repository Publish Version";

		// Token: 0x04000BCD RID: 3021
		private const int BackgroundStartupDelay = 5000;

		// Token: 0x04000BCE RID: 3022
		private const int ShortCheckIntervalSeconds = 60;

		// Token: 0x04000BCF RID: 3023
		private const int LongCheckIntervalSeconds = 1800;

		// Token: 0x04000BD0 RID: 3024
		private const int ExpiredCheckIntervalSeconds = 3600;

		// Token: 0x04000BD1 RID: 3025
		private readonly object m_SessionPublishThreadLock = new object();

		// Token: 0x04000BD2 RID: 3026
		private readonly global::Gibraltar.Messaging.Publisher m_Publisher;

		// Token: 0x04000BD3 RID: 3027
		private readonly global::Gibraltar.Monitor.AgentConfiguration m_Configuration;

		// Token: 0x04000BD4 RID: 3028
		private readonly string m_RepositoryFolder;

		// Token: 0x04000BD5 RID: 3029
		private readonly string m_MultiprocessLockName;

		// Token: 0x04000BD6 RID: 3030
		private volatile bool m_Initialized;

		// Token: 0x04000BD7 RID: 3031
		private volatile bool m_StopRequested;

		// Token: 0x04000BD8 RID: 3032
		private volatile bool m_SessionPublishThreadFailed;

		// Token: 0x04000BD9 RID: 3033
		private global::System.Threading.Thread m_SessionPublishThread;

		// Token: 0x04000BDA RID: 3034
		private global::Gibraltar.Data.Internal.RepositoryPublishClient m_Client;

		// Token: 0x04000BDB RID: 3035
		private bool m_ForceCheck;

		// Token: 0x04000BDC RID: 3036
		private global::System.DateTimeOffset m_LastCheck = global::System.DateTimeOffset.MinValue;

		// Token: 0x04000BDD RID: 3037
		private global::System.TimeSpan m_CheckInterval = new global::System.TimeSpan(0, 1, 0);

		// Token: 0x04000BDE RID: 3038
		private global::System.TimeSpan m_MultiprocessLockCheckInterval = new global::System.TimeSpan(0, 5, 0);

		// Token: 0x04000BDF RID: 3039
		private int m_FailedAttempts;
	}
}
