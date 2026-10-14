using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using Gibraltar.Data.Internal;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x0200025C RID: 604
	internal class Packager : global::System.IDisposable
	{
		// Token: 0x1400008C RID: 140
		// (add) Token: 0x06001ECB RID: 7883 RVA: 0x0006DE88 File Offset: 0x0006C088
		// (remove) Token: 0x06001ECC RID: 7884 RVA: 0x0006DEC4 File Offset: 0x0006C0C4
		public event global::System.EventHandler BeginSend;

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x06001ECD RID: 7885 RVA: 0x0006DF00 File Offset: 0x0006C100
		// (remove) Token: 0x06001ECE RID: 7886 RVA: 0x0006DF3C File Offset: 0x0006C13C
		public event global::Gibraltar.Data.PackageSendEventHandler EndSend;

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0006DFB4 File Offset: 0x0006C1B4
		public Packager() : this(global::Gibraltar.Monitor.Log.SessionSummary.Product, global::Gibraltar.Monitor.Log.SessionSummary.Application)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0006DFD0 File Offset: 0x0006C1D0
		public Packager(string productName) : this(productName, null)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0006DFDC File Offset: 0x0006C1DC
		public Packager(string productName, string applicationName) : this(productName, applicationName, global::Gibraltar.Monitor.Log.Configuration.SessionFile.Folder)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0006E004 File Offset: 0x0006C204
		public Packager(string productName, string applicationName, string repositoryFolder)
		{
			if (string.IsNullOrEmpty(productName))
			{
				throw new global::System.ArgumentNullException("productName");
			}
			this.ProductName = productName;
			this.ApplicationName = applicationName;
			this.Caption = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} Logs", new object[]
			{
				this.ProductName
			});
			this.m_Configuration = global::Gibraltar.Monitor.Log.Configuration;
			this.m_Repository = new global::Gibraltar.Monitor.LocalRepository(productName, repositoryFolder);
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x0006E09C File Offset: 0x0006C29C
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x0006E0A4 File Offset: 0x0006C2A4
		public string ProductName { get; private set; }

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		public string ApplicationName { get; private set; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		public string Caption { get; set; }

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x0006E0D8 File Offset: 0x0006C2D8
		// (set) Token: 0x06001EDB RID: 7899 RVA: 0x0006E0E0 File Offset: 0x0006C2E0
		public string Description { get; set; }

		// Token: 0x06001EDC RID: 7900 RVA: 0x0006E0EC File Offset: 0x0006C2EC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0006E0FC File Offset: 0x0006C2FC
		public global::Gibraltar.Data.PackageSendEventArgs SendEmail(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool? useSsl, string emailServerUser, string emailServerPassword, global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Success, "No sessions requested", null);
			}
			return this.ActionSendToEmail(new object[]
			{
				sessions,
				markAsRead,
				fromAddress,
				emailServer,
				serverPort,
				useSsl,
				emailServerUser,
				emailServerPassword,
				destinationAddress,
				emailSubject,
				progressMonitors
			});
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0006E17C File Offset: 0x0006C37C
		public void SendEmail(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool? useSsl, string emailServerUser, string emailServerPassword, bool asyncSend)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return;
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToEmail), "Emailing Sessions", new object[]
			{
				sessions,
				markAsRead,
				fromAddress,
				emailServer,
				serverPort,
				useSsl,
				emailServerUser,
				emailServerPassword,
				destinationAddress,
				emailSubject
			}, asyncSend);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0006E1F8 File Offset: 0x0006C3F8
		public void SendEmail(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool? useSsl, string emailServerUser, string emailServerPassword, bool asyncSend)
		{
			if (sessionMatchPredicate == null)
			{
				throw new global::System.ArgumentNullException("sessionMatchPredicate");
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToEmail), "Emailing Sessions", new object[]
			{
				sessionMatchPredicate,
				markAsRead,
				fromAddress,
				emailServer,
				serverPort,
				useSsl,
				emailServerUser,
				emailServerPassword,
				destinationAddress,
				emailSubject
			}, asyncSend);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0006E27C File Offset: 0x0006C47C
		public global::Gibraltar.Data.PackageSendEventArgs SendToFile(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, string fullFileNamePath, global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Success, "No sessions requested", null);
			}
			if (string.IsNullOrEmpty(fullFileNamePath))
			{
				throw new global::System.ArgumentNullException("fullFileNamePath");
			}
			if (!global::System.IO.Path.IsPathRooted(fullFileNamePath))
			{
				throw new global::System.ArgumentOutOfRangeException("fullFileNamePath", "The provided fullFileNamePath is not fully qualified");
			}
			if (progressMonitors == null)
			{
				throw new global::System.ArgumentNullException("progressMonitors");
			}
			return this.ActionSendToFile(new object[]
			{
				sessions,
				markAsRead,
				fullFileNamePath,
				progressMonitors
			});
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0006E30C File Offset: 0x0006C50C
		public void SendToFile(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, string fullFileNamePath, bool asyncSend)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return;
			}
			if (string.IsNullOrEmpty(fullFileNamePath))
			{
				throw new global::System.ArgumentNullException("fullFileNamePath");
			}
			if (!global::System.IO.Path.IsPathRooted(fullFileNamePath))
			{
				throw new global::System.ArgumentOutOfRangeException("fullFileNamePath", "The provided fullFileNamePath is not fully qualified");
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToFile), "Packaging Sessions", new object[]
			{
				sessions,
				markAsRead,
				fullFileNamePath
			}, asyncSend);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0006E38C File Offset: 0x0006C58C
		public void SendToFile(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionMatchPredicate, bool markAsRead, string fullFileNamePath, bool asyncSend)
		{
			if (sessionMatchPredicate == null)
			{
				throw new global::System.ArgumentNullException("sessionMatchPredicate");
			}
			if (string.IsNullOrEmpty(fullFileNamePath))
			{
				throw new global::System.ArgumentNullException("fullFileNamePath");
			}
			if (!global::System.IO.Path.IsPathRooted(fullFileNamePath))
			{
				throw new global::System.ArgumentOutOfRangeException("fullFileNamePath", "The provided fullFileNamePath is not fully qualified");
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToFile), "Packaging Sessions", new object[]
			{
				sessionMatchPredicate,
				markAsRead,
				fullFileNamePath
			}, asyncSend);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0006E410 File Offset: 0x0006C610
		public void SendToServer(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, bool overrideConfiguration, bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, bool asyncSend)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return;
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToServer), "Sending Sessions", new object[]
			{
				sessions,
				markAsRead,
				purgeSentSessions,
				overrideConfiguration,
				useGibraltarService,
				customerName,
				server,
				port,
				useSsl,
				applicationBaseDirectory,
				repository
			}, asyncSend);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0006E4A4 File Offset: 0x0006C6A4
		public void SendToServer(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions, bool overrideConfiguration, bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, bool asyncSend)
		{
			if (sessionMatchPredicate == null)
			{
				throw new global::System.ArgumentNullException("sessionMatchPredicate");
			}
			this.AsyncTaskExecute(new global::System.Threading.WaitCallback(this.AsyncSendToServer), "Sending Sessions", new object[]
			{
				sessionMatchPredicate,
				markAsRead,
				purgeSentSessions,
				overrideConfiguration,
				useGibraltarService,
				customerName,
				server,
				port,
				useSsl,
				applicationBaseDirectory,
				repository
			}, asyncSend);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0006E53C File Offset: 0x0006C73C
		public global::Gibraltar.Data.PackageSendEventArgs SendToServer(global::Gibraltar.Data.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, bool overrideConfiguration, bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			if (sessions == global::Gibraltar.Data.SessionCriteria.None)
			{
				return new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Success, "No sessions requested", null);
			}
			return this.ActionSendToServer(new object[]
			{
				sessions,
				markAsRead,
				purgeSentSessions,
				overrideConfiguration,
				useGibraltarService,
				customerName,
				server,
				port,
				useSsl,
				applicationBaseDirectory,
				repository,
				progressMonitors
			});
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
		public static bool CanSendToServer(bool overrideConfiguration, bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, out string message)
		{
			bool result;
			if (overrideConfiguration)
			{
				global::Gibraltar.Server.Client.HubStatus hubStatus;
				result = global::Gibraltar.Server.Client.HubConnection.CanConnect(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository, out hubStatus, out message);
			}
			else
			{
				global::Gibraltar.Server.Client.HubStatus hubStatus;
				result = global::Gibraltar.Server.Client.HubConnection.CanConnect(global::Gibraltar.Monitor.Log.Configuration.Server, out hubStatus, out message);
			}
			return result;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0006E618 File Offset: 0x0006C818
		public static bool CanSendToServer(out string message)
		{
			return global::Gibraltar.Data.Packager.CanSendToServer(false, false, null, null, 0, false, null, null, out message);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x0006E638 File Offset: 0x0006C838
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (releaseManaged)
				{
					if (this.m_TransportQueue.Count > 0)
					{
						global::Gibraltar.Data.Internal.TransportPackageBase[] array = this.m_TransportQueue.ToArray();
						for (int i = 0; i < array.Length; i++)
						{
							array[i].Dispose();
						}
						this.m_TransportQueue.Clear();
					}
					if (this.m_CleanupQueue.Count > 0)
					{
						global::Gibraltar.Data.Internal.TransportPackageBase[] array = this.m_CleanupQueue.ToArray();
						for (int i = 0; i < array.Length; i++)
						{
							array[i].Dispose();
						}
						this.m_CleanupQueue.Clear();
					}
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0006E6EC File Offset: 0x0006C8EC
		protected global::Loupe.Extensibility.Data.ISessionSummaryCollection FindPackageSessions(global::Gibraltar.Data.SessionCriteria sessionCriteria, global::Gibraltar.ProgressMonitorStack progressMonitors, out bool hasProblemSessions)
		{
			if (sessionCriteria == global::Gibraltar.Data.SessionCriteria.None)
			{
				hasProblemSessions = false;
				return null;
			}
			hasProblemSessions = false;
			int num = 0;
			global::Loupe.Extensibility.Data.ISessionSummaryCollection sessionSummaryCollection;
			using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitors.NewMonitor(this, "Finding Sessions to Report", 3))
			{
				if ((global::Gibraltar.Data.SessionCriteria.ActiveSession & sessionCriteria) == global::Gibraltar.Data.SessionCriteria.ActiveSession)
				{
					global::Gibraltar.Monitor.Log.EndFile("Creating Package including active session");
				}
				progressMonitor.Update("Updating Session List", num++);
				this.m_Repository.Refresh(false, true, sessionCriteria);
				progressMonitor.Update("Finding Sessions", num++);
				sessionSummaryCollection = this.m_Repository.Find(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(new global::Gibraltar.Data.Internal.SessionCriteriaPredicate(this.ProductName, this.ApplicationName, sessionCriteria).Predicate));
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Sessions list loaded", "There are {0} matching sessions in the collection repository.", new object[]
					{
						sessionSummaryCollection.Count
					});
				}
				progressMonitor.Update(string.Format("{0} matching sessions found", sessionSummaryCollection.Count), num++);
			}
			return sessionSummaryCollection;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0006E7FC File Offset: 0x0006C9FC
		protected global::Loupe.Extensibility.Data.ISessionSummaryCollection FindPackageSessions(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionPredicate, global::Gibraltar.ProgressMonitorStack progressMonitors, out bool hasProblemSessions)
		{
			if (sessionPredicate == null)
			{
				hasProblemSessions = false;
				return null;
			}
			hasProblemSessions = false;
			int num = 0;
			global::Loupe.Extensibility.Data.ISessionSummaryCollection sessionSummaryCollection;
			using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitors.NewMonitor(this, "Finding Sessions to Report", 3))
			{
				global::Gibraltar.Monitor.Log.EndFile("Creating Package including active session");
				progressMonitor.Update("Updating Session List", num++);
				this.m_Repository.Refresh(false, true);
				progressMonitor.Update("Finding Sessions", num++);
				sessionSummaryCollection = this.m_Repository.Find(sessionPredicate);
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Sessions list loaded", "There are {0} matching sessions in the collection repository.", new object[]
					{
						sessionSummaryCollection.Count
					});
				}
				progressMonitor.Update(string.Format("{0} matching sessions found", sessionSummaryCollection.Count), num++);
			}
			return sessionSummaryCollection;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
		protected virtual void OnBeginSend()
		{
			global::System.EventHandler beginSend = this.BeginSend;
			if (beginSend != null)
			{
				beginSend(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0006E910 File Offset: 0x0006CB10
		protected virtual void OnEndSend(global::Gibraltar.Data.PackageSendEventArgs e)
		{
			global::Gibraltar.Data.PackageSendEventHandler endSend = this.EndSend;
			if (endSend != null)
			{
				endSend(this, e);
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0006E938 File Offset: 0x0006CB38
		private void AsyncTaskExecute(global::System.Threading.WaitCallback asyncTask, string title, object state, bool processAsynchronously)
		{
			global::Gibraltar.AsynchronousTask asynchronousTask = new global::Gibraltar.AsynchronousTask();
			asynchronousTask.Execute(asyncTask, title, state);
			if (!processAsynchronously)
			{
				while (!asynchronousTask.Completed)
				{
					global::System.Threading.Thread.Sleep(16);
				}
				if (asynchronousTask.TaskResults != null && asynchronousTask.TaskResults.Result == global::Gibraltar.AsyncTaskResult.Error)
				{
					if (asynchronousTask.TaskResults.Exception != null)
					{
						throw asynchronousTask.TaskResults.Exception;
					}
					throw new global::Gibraltar.GibraltarException(asynchronousTask.TaskResults.Message, asynchronousTask.TaskResults.Exception);
				}
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0006E9C8 File Offset: 0x0006CBC8
		private global::Gibraltar.Data.PackageSendEventArgs ActionSendToEmail(object state)
		{
			this.OnBeginSend();
			if (state == null)
			{
				throw new global::System.ArgumentNullException("state");
			}
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Starting asynchronous send via email", null, new object[0]);
			}
			int num = 0;
			global::Gibraltar.AsyncTaskArguments asyncTaskArguments = state as global::Gibraltar.AsyncTaskArguments;
			object[] array;
			global::Gibraltar.ProgressMonitorStack progressMonitorStack;
			if (asyncTaskArguments != null)
			{
				array = (object[])asyncTaskArguments.State;
				if (array == null)
				{
					throw new global::System.ArgumentException("There are no arguments in the asynchronous task, indicating an internal error in Gibraltar.");
				}
				if (array.Length != 10)
				{
					throw new global::System.ArgumentException("There aren't enough arguments passed with the asynchronous task, indicating an internal error in Gibraltar.");
				}
				progressMonitorStack = asyncTaskArguments.ProgressMonitors;
			}
			else
			{
				array = (object[])state;
				if (array.Length != 11)
				{
					throw new global::System.ArgumentException("There aren't enough arguments passed with the asynchronous task, indicating an internal error in Gibraltar.");
				}
				progressMonitorStack = (global::Gibraltar.ProgressMonitorStack)array[10];
			}
			global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionPredicate = null;
			global::Gibraltar.Data.SessionCriteria? sessionCriteria = null;
			if (array[0] is global::Gibraltar.Data.SessionCriteria)
			{
				sessionCriteria = new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)array[0]);
			}
			else
			{
				sessionPredicate = (global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>)array[0];
			}
			bool flag = (bool)array[1];
			string text = (string)array[2];
			string text2 = (string)array[3];
			int emailServerPort = (int)array[4];
			bool? emailUseSsl = (bool?)array[5];
			string emailServerUser = (string)array[6];
			string text3 = (string)array[7];
			string text4 = (string)array[8];
			string text5 = (string)array[9];
			int num2 = this.m_Configuration.Email.MaxMessageSize * 1048576;
			global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Packaging session data to send via email", "From address: '{0}'\r\nTo address: '{1}'\r\nSubject Override: '{2}'\r\nServer Override: '{3}'\r\nMaximum Email Size (bytes): {4}\r\nA server user and password {5} provided.\r\nIf successful, sessions {6} be marked as read.", new object[]
			{
				text,
				text4,
				text5,
				string.IsNullOrEmpty(text2) ? "(Not specified)" : text2,
				num2,
				string.IsNullOrEmpty(text3) ? "was not" : "was",
				flag ? "will" : "will not"
			});
			if (emailUseSsl == null)
			{
				emailUseSsl = new bool?(this.m_Configuration.Email.UseSsl);
			}
			if (string.IsNullOrEmpty(text4))
			{
				text4 = this.m_Configuration.Packager.DestinationEmailAddress;
				if (string.IsNullOrEmpty(text4))
				{
					throw new global::System.ArgumentException("No destination email address was provided");
				}
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Using Default Email To Address", "Substituting default email address '{0}' from configuration because supplied address was null or empty.", new object[]
					{
						text4
					});
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				text = this.m_Configuration.Packager.FromEmailAddress;
				if (string.IsNullOrEmpty(text))
				{
					text = text4;
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Using Default Email From Address", "Substituting destination email address '{0}' as from address because specified value was null or empty.", new object[]
						{
							text
						});
					}
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				global::Gibraltar.Monitor.EmailConfiguration email = this.m_Configuration.Email;
				text2 = email.Server;
				emailServerPort = email.Port;
				emailServerUser = email.User;
				text3 = email.Password;
			}
			global::Gibraltar.Data.PackageSendEventArgs packageSendEventArgs;
			using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitorStack.NewMonitor(this, "Sending Sessions by Email", 3))
			{
				progressMonitor.Update("Finding sessions...", 0);
				int num3 = 0;
				bool hasProblemSessions;
				global::Loupe.Extensibility.Data.ISessionSummaryCollection sessionSummaryCollection = (sessionCriteria != null) ? this.FindPackageSessions(sessionCriteria.Value, progressMonitorStack, out hasProblemSessions) : this.FindPackageSessions(sessionPredicate, progressMonitorStack, out hasProblemSessions);
				if (sessionSummaryCollection != null && sessionSummaryCollection.Count > 0)
				{
					progressMonitor.Update("Packaging Sessions...", 1);
					using (global::Gibraltar.ProgressMonitor progressMonitor2 = progressMonitorStack.NewMonitor(this, "Packaging Sessions...", sessionSummaryCollection.Count))
					{
						global::Gibraltar.Data.Packager.PackagingState packagingState = new global::Gibraltar.Data.Packager.PackagingState();
						while (!packagingState.IsComplete)
						{
							global::Gibraltar.Data.SimplePackage simplePackage = this.CreateTransportablePackage(progressMonitorStack, progressMonitor2, sessionSummaryCollection, num2, out hasProblemSessions, packagingState);
							if (simplePackage != null)
							{
								this.TransportEnqueue(new global::Gibraltar.Data.Internal.EmailTransportPackage(this.ProductName, this.ApplicationName, simplePackage)
								{
									EmailFromAddress = text,
									EmailToAddress = text4,
									EmailServer = text2,
									EmailServerPort = emailServerPort,
									EmailServerUser = emailServerUser,
									EmailServerPassword = text3,
									EmailSubject = text5,
									EmailUseSsl = emailUseSsl,
									HasProblemSessions = hasProblemSessions
								});
								num3++;
							}
						}
					}
				}
				if (num3 == 0)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "No Sessions to Send", "The packager didn't find any sessions to send in the package based on the selection criteria.", new object[0]);
					progressMonitor.Update("No sessions were found to send.", 3);
					packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Information, "No sessions were found to send.", null);
				}
				else
				{
					string status = "Sending Email...";
					progressMonitor.Update(status, 2);
					global::System.Collections.Generic.List<global::Gibraltar.Data.PackageSendEventArgs> list = new global::System.Collections.Generic.List<global::Gibraltar.Data.PackageSendEventArgs>(num3);
					int num4 = this.TransportQueueLength + 1 + num3;
					using (global::Gibraltar.ProgressMonitor progressMonitor3 = progressMonitorStack.NewMonitor(this, status, num4))
					{
						int i = 0;
						while (i < num3)
						{
							int num5 = this.TransportQueueLength;
							int cleanupQueueLength = this.CleanupQueueLength;
							num5 += cleanupQueueLength;
							if (cleanupQueueLength + i < num3)
							{
								num5++;
							}
							else
							{
								status = "Cleaning up temporary data...";
							}
							progressMonitor3.Update(status, num4 - num5);
							for (global::Gibraltar.Data.Internal.TransportPackageBase transportPackageBase = this.CleanupDequeue(); transportPackageBase != null; transportPackageBase = this.CleanupDequeue())
							{
								if (flag)
								{
									transportPackageBase.MarkContentsAsRead(this.m_Repository);
								}
								list.Add(transportPackageBase.Status);
								transportPackageBase.Dispose();
								i++;
							}
							if (i < num3)
							{
								global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> cleanupQueue = this.m_CleanupQueue;
								lock (cleanupQueue)
								{
									if (this.m_CleanupQueue.Count == 0)
									{
										global::System.Threading.Monitor.Wait(this.m_CleanupQueue);
									}
									global::System.Threading.Monitor.PulseAll(this.m_CleanupQueue);
								}
							}
						}
					}
					packageSendEventArgs = null;
					global::Gibraltar.Data.PackageSendEventArgs packageSendEventArgs2 = null;
					foreach (global::Gibraltar.Data.PackageSendEventArgs packageSendEventArgs3 in list)
					{
						num += packageSendEventArgs3.FileSize;
						if (packageSendEventArgs2 == null || packageSendEventArgs3.Result < packageSendEventArgs2.Result)
						{
							packageSendEventArgs2 = packageSendEventArgs3;
						}
					}
					if (packageSendEventArgs2 != null)
					{
						packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(num, packageSendEventArgs2.Result, packageSendEventArgs2.Message, packageSendEventArgs2.Exception);
					}
				}
			}
			if (packageSendEventArgs == null)
			{
				packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Canceled, "There was no data to transport", null);
			}
			global::Gibraltar.AsyncTaskResult result = packageSendEventArgs.Result;
			switch (result)
			{
			case global::Gibraltar.AsyncTaskResult.Unknown:
			{
				string caption = "Completed asynchronous package transmission via email";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_6F0;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled:
			{
				string caption = "Canceled asynchronous package transmission via email";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_6F0;
			}
			case global::Gibraltar.AsyncTaskResult.Error:
			{
				string caption = "Completed asynchronous package transmission via email with errors";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Error;
				goto IL_6F0;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
				break;
			case global::Gibraltar.AsyncTaskResult.Warning:
			{
				string caption = "Completed asynchronous package transmission via email with warnings";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_6F0;
			}
			case global::Gibraltar.AsyncTaskResult.Information:
			{
				string caption = "Completed asynchronous package transmission via email";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Information;
				goto IL_6F0;
			}
			default:
				if (result == global::Gibraltar.AsyncTaskResult.Success)
				{
					string caption = "Completed asynchronous package transmission via email";
					global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
					goto IL_6F0;
				}
				break;
			}
			throw new global::System.ArgumentOutOfRangeException();
			IL_6F0:
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				string caption;
				global::Loupe.Extensibility.Data.LogMessageSeverity severity;
				global::Gibraltar.Monitor.Log.WriteMessage(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, 0, packageSendEventArgs.Exception, null, caption, packageSendEventArgs.Message, new object[0]);
			}
			if (asyncTaskArguments != null)
			{
				asyncTaskArguments.TaskResult = packageSendEventArgs;
			}
			this.OnEndSend(packageSendEventArgs);
			return packageSendEventArgs;
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0006F184 File Offset: 0x0006D384
		private int CleanupQueueLength
		{
			get
			{
				global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> cleanupQueue = this.m_CleanupQueue;
				int count;
				lock (cleanupQueue)
				{
					global::System.Threading.Monitor.PulseAll(this.m_CleanupQueue);
					count = this.m_CleanupQueue.Count;
				}
				return count;
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		private global::Gibraltar.Data.Internal.TransportPackageBase CleanupDequeue()
		{
			global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> cleanupQueue = this.m_CleanupQueue;
			global::Gibraltar.Data.Internal.TransportPackageBase result;
			lock (cleanupQueue)
			{
				global::System.Threading.Monitor.PulseAll(this.m_CleanupQueue);
				if (this.m_CleanupQueue.Count == 0)
				{
					result = null;
				}
				else
				{
					result = this.m_CleanupQueue.Dequeue();
				}
			}
			return result;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0006F23C File Offset: 0x0006D43C
		private void CleanupEnqueue(global::Gibraltar.Data.Internal.TransportPackageBase package)
		{
			global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> cleanupQueue = this.m_CleanupQueue;
			lock (cleanupQueue)
			{
				global::System.Threading.Monitor.PulseAll(this.m_CleanupQueue);
				this.m_CleanupQueue.Enqueue(package);
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0006F28C File Offset: 0x0006D48C
		private int TransportQueueLength
		{
			get
			{
				global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> transportQueue = this.m_TransportQueue;
				int count;
				lock (transportQueue)
				{
					global::System.Threading.Monitor.PulseAll(this.m_TransportQueue);
					count = this.m_TransportQueue.Count;
				}
				return count;
			}
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		private global::Gibraltar.Data.Internal.TransportPackageBase TransportDequeue()
		{
			global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> transportQueue = this.m_TransportQueue;
			global::Gibraltar.Data.Internal.TransportPackageBase result;
			lock (transportQueue)
			{
				global::System.Threading.Monitor.PulseAll(this.m_TransportQueue);
				if (this.m_TransportQueue.Count == 0)
				{
					result = null;
				}
				else
				{
					result = this.m_TransportQueue.Dequeue();
				}
			}
			return result;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0006F344 File Offset: 0x0006D544
		private void TransportEnqueue(global::Gibraltar.Data.Internal.TransportPackageBase package)
		{
			global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> transportQueue = this.m_TransportQueue;
			lock (transportQueue)
			{
				global::System.Threading.Monitor.PulseAll(this.m_TransportQueue);
				this.m_TransportQueue.Enqueue(package);
			}
			this.EnsureTransportThreadRunning();
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0006F398 File Offset: 0x0006D598
		private void EnsureTransportThreadRunning()
		{
			object transportThreadLock = this.m_TransportThreadLock;
			lock (transportThreadLock)
			{
				if (!this.m_TransportThreadDispatched)
				{
					global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncTransportPackage));
					this.m_TransportThreadDispatched = true;
				}
				global::System.Threading.Monitor.PulseAll(this.m_TransportThreadLock);
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0006F400 File Offset: 0x0006D600
		private global::Gibraltar.Data.SimplePackage CreateTransportablePackage(global::Gibraltar.ProgressMonitorStack progressMonitors, global::Gibraltar.ProgressMonitor ourMonitor, global::Loupe.Extensibility.Data.ISessionSummaryCollection selectedSessions, int maxPackageSizeBytes, out bool hasProblemSessions, global::Gibraltar.Data.Packager.PackagingState packagingState)
		{
			packagingState.IsComplete = true;
			hasProblemSessions = false;
			ourMonitor.Update("Opening New Package");
			global::Gibraltar.Data.SimplePackage simplePackage = new global::Gibraltar.Data.SimplePackage();
			string tempFileName = global::System.IO.Path.GetTempFileName();
			global::System.IO.File.Delete(tempFileName);
			int num = 0;
			int num2 = 0;
			bool flag = packagingState.LastSessionId == null;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>(global::Gibraltar.Data.Packager.UserListMaxCount);
			foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in selectedSessions)
			{
				if (!flag)
				{
					if (sessionSummary.Id == packagingState.LastSessionId.Value)
					{
						flag = true;
					}
				}
				else
				{
					if (num2 == 0)
					{
						ourMonitor.Update("Adding session to package...");
					}
					else
					{
						ourMonitor.Update("Adding session to package...", ourMonitor.CompletedSteps + 1);
					}
					try
					{
						global::System.IO.Stream stream = null;
						if (packagingState.NextSessionId != null)
						{
							global::System.Guid? nextSessionId = packagingState.NextSessionId;
							global::System.Guid id = sessionSummary.Id;
							if (nextSessionId != null && (nextSessionId == null || nextSessionId.GetValueOrDefault() == id) && packagingState.NextSessionStream != null)
							{
								stream = packagingState.NextSessionStream;
								packagingState.NextSessionId = null;
								packagingState.NextSessionStream = null;
								goto IL_1EC;
							}
						}
						if (packagingState.NextSessionStream != null)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Packager", "Packaging Session State is out of Sync", "We carried forward a package session state but the NextSessionId didn't match the next session, so we'll clean up the unused stream", new object[0]);
							}
							packagingState.NextSessionStream.Dispose();
							packagingState.NextSessionStream = null;
						}
						try
						{
							stream = this.m_Repository.LoadSessionStream(sessionSummary.Id);
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Packager", "Session to be packaged is not in the repository.", ex.Message, new object[0]);
							}
						}
						IL_1EC:
						if (stream == null)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Session was unexpectedly not available to be included in the package", "The repository wasn't able to load the session for inclusion into the package even though it should be available.  Session Id: {0}", new object[]
								{
									sessionSummary.Id
								});
							}
						}
						else
						{
							string text = null;
							long length = stream.Length;
							if (length + (long)num2 > (long)maxPackageSizeBytes)
							{
								simplePackage.Save(progressMonitors, tempFileName);
								num2 = (int)global::Gibraltar.FileSystemTools.GetFileSize(tempFileName);
							}
							if (length + (long)num2 > (long)maxPackageSizeBytes)
							{
								if (num != 0)
								{
									if (!global::Gibraltar.Monitor.Log.SilentMode)
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Package is projected to exceed max allowed size, no more sessions will be added.", "The current package size is {0} bytes of session data, this new package is {1} bytes which would exceed the max of {2} bytes.", new object[]
										{
											num2,
											length,
											maxPackageSizeBytes
										});
									}
									packagingState.IsComplete = false;
									packagingState.NextSessionId = new global::System.Guid?(sessionSummary.Id);
									packagingState.NextSessionStream = stream;
									break;
								}
								simplePackage.AddSession(stream);
								packagingState.LastSessionId = new global::System.Guid?(sessionSummary.Id);
								num++;
								simplePackage.Save(progressMonitors, tempFileName);
								num2 = (int)global::Gibraltar.FileSystemTools.GetFileSize(tempFileName);
								if (num2 > maxPackageSizeBytes)
								{
									if (!global::Gibraltar.Monitor.Log.SilentMode)
									{
										global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Packager", "Session is too large to fit in a package", "The current session has {0} bytes of session data, when packaged is {1} bytes which would exceed the max of {2} bytes.  This session will be skipped.", new object[]
										{
											length,
											num2,
											maxPackageSizeBytes
										});
									}
									simplePackage.Dispose();
									simplePackage = new global::Gibraltar.Data.SimplePackage();
									global::System.IO.File.Delete(tempFileName);
									num = 0;
									num2 = 0;
								}
								else
								{
									text = sessionSummary.UserName;
								}
							}
							else
							{
								simplePackage.AddSession(stream);
								packagingState.LastSessionId = new global::System.Guid?(sessionSummary.Id);
								num2 += (int)length;
								num++;
								text = sessionSummary.UserName;
							}
							if (list.Count < global::Gibraltar.Data.Packager.UserListMaxCount && !string.IsNullOrEmpty(text) && !list.Contains(text))
							{
								list.Add(text);
							}
						}
					}
					catch (global::System.Exception ex2)
					{
						packagingState.LastSessionId = new global::System.Guid?(sessionSummary.Id);
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Packager", "Unable to add selected session to transport package", "While attempting to add a session that was selected to the transport package an exception was thrown.  The session will be skipped.  Exception:\r\n{0}", new object[]
							{
								ex2.Message
							});
						}
					}
				}
			}
			if (num == 0)
			{
				simplePackage.Dispose();
				simplePackage = null;
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Suppressing empty working package", "No exportable sessions were identified in the last set of sessions to write out, so the package would have been empty.", new object[0]);
				}
			}
			if (simplePackage != null)
			{
				simplePackage.Save(progressMonitors, tempFileName);
				string text2 = string.IsNullOrEmpty(this.ApplicationName) ? this.ProductName : string.Format("{0} {1}", this.ProductName, this.ApplicationName);
				int num3 = global::System.Math.Min(list.Count, global::Gibraltar.Data.Packager.UserListMaxCount);
				string text3 = string.Format(global::Gibraltar.Data.Packager.UserListFormat[num3], list.ToArray());
				int num4;
				int num5;
				int num6;
				long num7;
				simplePackage.GetStats(out num4, out num5, out num6, out num7);
				string text4 = "s";
				string text5 = "a";
				if (num5 > 0)
				{
					if (num5 == 1)
					{
						text4 = string.Empty;
					}
					else
					{
						text5 = "Multiple";
					}
					hasProblemSessions = true;
					simplePackage.Caption = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "{0} Sessions from {1} ({2} Problem Session{3} of {4} Total)", new object[]
					{
						text2,
						text3,
						num5,
						text4,
						num4
					});
					simplePackage.Description = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "!!!This Package Contains {0} Problem Session{1}!!!\r\n\r\nProduct: {2}\r\nComputer: {3}\r\nUser:{4}\r\nTotal Sessions: {5}\r\nProblem Sessions: {6}.  A problem session has at least one error or has crashed.\r\nGenerated: {7}\r\n", new object[]
					{
						text5,
						text4,
						text2,
						global::Gibraltar.Monitor.Log.SessionSummary.HostName,
						global::Gibraltar.Monitor.Log.SessionSummary.FullyQualifiedUserName,
						num4,
						num5,
						global::System.DateTimeOffset.Now
					});
				}
				else
				{
					if (num4 == 1)
					{
						text4 = string.Empty;
					}
					simplePackage.Caption = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "{0} Sessions from {1} ({2} Session{3})", new object[]
					{
						text2,
						text3,
						num4,
						text4
					});
					simplePackage.Description = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Product: {0}\r\nComputer: {1}\r\nUser:{2}\r\nTotal Sessions: {3}\r\nGenerated: {4}\r\n", new object[]
					{
						text2,
						global::Gibraltar.Monitor.Log.SessionSummary.HostName,
						global::Gibraltar.Monitor.Log.SessionSummary.FullyQualifiedUserName,
						num4,
						global::System.DateTimeOffset.Now
					});
				}
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Completed creating working package", "Package is momentarily written to a temporary file.\r\nCaption: {0}\r\nDescription: {1}\r\nPackaging Complete: {2}", new object[]
					{
						simplePackage.Caption,
						simplePackage.Description,
						packagingState.IsComplete
					});
				}
			}
			return simplePackage;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		private static void LogSendToServer(bool overrideConfiguration, bool useGibraltarService, bool markAsRead, bool purgeSentSessions, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			string text;
			if (!overrideConfiguration)
			{
				stringBuilder.AppendLine("Sessions are being sent using application default Server settings.");
				text = string.Empty;
			}
			else if (useGibraltarService)
			{
				stringBuilder.AppendLine("Sessions are being sent to the Loupe Service.\r\n");
				text = "\r\nHub Customer: {0}";
			}
			else
			{
				stringBuilder.AppendLine("Sessions are being sent to a private Loupe Server.\r\n");
				text = "\r\nServer: {1}\r\nPort: {2}\r\nUse Ssl: {3}\r\nApplication Base Directory: {4}\r\nRepository: {5}";
			}
			if (markAsRead && purgeSentSessions)
			{
				stringBuilder.AppendLine("Sessions will be marked as read and removed from the local computer once confirmed by the server.");
			}
			else if (markAsRead)
			{
				stringBuilder.AppendLine("Sessions will be marked as read once confirmed by the server.");
			}
			else if (purgeSentSessions)
			{
				stringBuilder.AppendLine("Sessions will be removed from the local computer once confirmed by the server.");
			}
			if (!string.IsNullOrEmpty(text))
			{
				stringBuilder.AppendFormat(text, new object[]
				{
					customerName,
					server,
					port,
					useSsl,
					applicationBaseDirectory,
					repository
				});
			}
			global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Sending sessions to Server", stringBuilder.ToString(), new object[0]);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0006FC14 File Offset: 0x0006DE14
		private void AsyncTransportPackage(object state)
		{
			try
			{
				global::Gibraltar.Data.Internal.TransportPackageBase transportPackageBase = this.TransportDequeue();
				while (transportPackageBase != null)
				{
					try
					{
						transportPackageBase.Send(new global::Gibraltar.ProgressMonitorStack("Background Package Transport"));
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Packager", "Failed to transport package", "While attempting to transport a queued package an exception was thrown:\r\n{0)", new object[]
							{
								ex.Message
							});
						}
					}
					this.CleanupEnqueue(transportPackageBase);
					object transportThreadLock = this.m_TransportThreadLock;
					lock (transportThreadLock)
					{
						global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> transportQueue = this.m_TransportQueue;
						lock (transportQueue)
						{
							transportPackageBase = this.TransportDequeue();
							if (transportPackageBase == null)
							{
								this.m_TransportThreadDispatched = false;
							}
							global::System.Threading.Monitor.PulseAll(this.m_TransportQueue);
						}
						global::System.Threading.Monitor.PulseAll(this.m_TransportThreadLock);
					}
				}
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.Monitor.Log.RecordException(0, exception, null, "Loupe.Packager", true);
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0006FD34 File Offset: 0x0006DF34
		private global::Gibraltar.Data.PackageSendEventArgs ActionSendToFile(object state)
		{
			this.OnBeginSend();
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Starting asynchronous send to file", null, new object[0]);
			}
			global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionPredicate = null;
			global::Gibraltar.Data.SessionCriteria? sessionCriteria = null;
			global::Gibraltar.AsyncTaskArguments asyncTaskArguments = state as global::Gibraltar.AsyncTaskArguments;
			bool flag;
			string text;
			global::Gibraltar.ProgressMonitorStack progressMonitorStack;
			if (asyncTaskArguments != null)
			{
				object[] array = (object[])asyncTaskArguments.State;
				if (array[0] is global::Gibraltar.Data.SessionCriteria)
				{
					sessionCriteria = new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)array[0]);
				}
				else
				{
					sessionPredicate = (global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>)array[0];
				}
				flag = (bool)array[1];
				text = (string)array[2];
				progressMonitorStack = asyncTaskArguments.ProgressMonitors;
			}
			else
			{
				object[] array2 = (object[])state;
				if (array2[0] is global::Gibraltar.Data.SessionCriteria)
				{
					sessionCriteria = new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)array2[0]);
				}
				else
				{
					sessionPredicate = (global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>)array2[0];
				}
				flag = (bool)array2[1];
				text = (string)array2[2];
				progressMonitorStack = (global::Gibraltar.ProgressMonitorStack)array2[3];
			}
			global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Sending package to file", "When complete sessions will be in the file '{0}'.{1}", new object[]
			{
				text,
				flag ? "If successful, sessions will be marked as read and not sent again." : null
			});
			global::Gibraltar.Data.PackageSendEventArgs packageSendEventArgs;
			using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitorStack.NewMonitor(this, "Sending session information to file", 1))
			{
				string text2 = null;
				string text3 = ".glp";
				text = text.TrimEnd(new char[0]);
				try
				{
					text2 = global::System.IO.Path.GetExtension(text);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				if (string.IsNullOrEmpty(text2))
				{
					text = text.TrimEnd(new char[0]) + text3;
				}
				else if (!text2.Equals(text3, global::System.StringComparison.OrdinalIgnoreCase))
				{
					text = text.Substring(0, text.Length - text2.Length) + text3;
				}
				if (flag)
				{
					progressMonitor.Update("Finding sessions...", 0, 3);
				}
				else
				{
					progressMonitor.Update("Finding sessions...", 0, 2);
				}
				global::Gibraltar.Data.Internal.FileTransportPackage fileTransportPackage = null;
				try
				{
					bool flag2;
					global::Loupe.Extensibility.Data.ISessionSummaryCollection sessionSummaryCollection = (sessionCriteria != null) ? this.FindPackageSessions(sessionCriteria.Value, progressMonitorStack, out flag2) : this.FindPackageSessions(sessionPredicate, progressMonitorStack, out flag2);
					if (sessionSummaryCollection != null && sessionSummaryCollection.Count > 0)
					{
						progressMonitor.Update("Packaging Sessions...", 1);
						using (global::Gibraltar.ProgressMonitor progressMonitor2 = progressMonitorStack.NewMonitor(this, "Packaging Sessions...", sessionSummaryCollection.Count))
						{
							int maxPackageSizeBytes = (int)global::System.Math.Min(new global::System.IO.DriveInfo(global::System.IO.Path.GetPathRoot(text)).AvailableFreeSpace, 2147483647L);
							global::Gibraltar.Data.Packager.PackagingState packagingState = new global::Gibraltar.Data.Packager.PackagingState();
							global::Gibraltar.Data.SimplePackage simplePackage = this.CreateTransportablePackage(progressMonitorStack, progressMonitor2, sessionSummaryCollection, maxPackageSizeBytes, out flag2, packagingState);
							if (simplePackage != null)
							{
								fileTransportPackage = new global::Gibraltar.Data.Internal.FileTransportPackage(this.ProductName, this.ApplicationName, simplePackage, text);
							}
						}
					}
					if (fileTransportPackage == null)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "No Sessions to Send", "The packager process didn't find any sessions to send in the package based on the selection criteria.", new object[0]);
						}
						progressMonitor.Update("No sessions were found to send.", 3, 3);
						packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Information, "No sessions were found to send.", null);
					}
					else
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Writing file package to destination", "The final package is being written to '{0}'", new object[]
							{
								text
							});
						}
						progressMonitor.Update("Saving package to disk...", 2);
						fileTransportPackage.Send(progressMonitorStack);
						packageSendEventArgs = fileTransportPackage.Status;
						if (packageSendEventArgs.Result == global::Gibraltar.AsyncTaskResult.Success)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Package Written to Disk", "The packager was able to write a package to {0}", new object[]
								{
									text
								});
							}
							if (flag)
							{
								progressMonitor.Update("Cleaning up temporary data...", 3);
								fileTransportPackage.MarkContentsAsRead(this.m_Repository);
							}
							progressMonitor.Update("Packaging complete.");
						}
					}
				}
				finally
				{
					if (fileTransportPackage != null)
					{
						fileTransportPackage.Dispose();
					}
				}
			}
			global::Gibraltar.AsyncTaskResult result = packageSendEventArgs.Result;
			switch (result)
			{
			case global::Gibraltar.AsyncTaskResult.Unknown:
			{
				string caption = "Completed asynchronous package send to file";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_47A;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled:
			{
				string caption = "Canceled asynchronous package send to file";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_47A;
			}
			case global::Gibraltar.AsyncTaskResult.Error:
			{
				string caption = "Completed asynchronous package send to file with errors";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Error;
				goto IL_47A;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
				break;
			case global::Gibraltar.AsyncTaskResult.Warning:
			{
				string caption = "Completed asynchronous package send to file with warnings";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_47A;
			}
			case global::Gibraltar.AsyncTaskResult.Information:
			{
				string caption = "Completed asynchronous package send to file";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Information;
				goto IL_47A;
			}
			default:
				if (result == global::Gibraltar.AsyncTaskResult.Success)
				{
					string caption = "Completed asynchronous package send to file";
					global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
					goto IL_47A;
				}
				break;
			}
			throw new global::System.ArgumentOutOfRangeException();
			IL_47A:
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				string caption;
				global::Loupe.Extensibility.Data.LogMessageSeverity severity;
				global::Gibraltar.Monitor.Log.WriteMessage(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, 0, packageSendEventArgs.Exception, null, caption, packageSendEventArgs.Message, new object[0]);
			}
			if (asyncTaskArguments != null)
			{
				asyncTaskArguments.TaskResult = packageSendEventArgs;
			}
			this.OnEndSend(packageSendEventArgs);
			return packageSendEventArgs;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00070264 File Offset: 0x0006E464
		private global::Gibraltar.Data.PackageSendEventArgs ActionSendToServer(object state)
		{
			this.OnBeginSend();
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Starting asynchronous send to web", null, new object[0]);
			}
			global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionPredicate = null;
			global::Gibraltar.Data.SessionCriteria? sessionCriteria = null;
			global::Gibraltar.AsyncTaskArguments asyncTaskArguments = state as global::Gibraltar.AsyncTaskArguments;
			bool flag;
			bool flag2;
			bool flag3;
			bool useGibraltarService;
			string customerName;
			string server;
			int port;
			bool useSsl;
			string applicationBaseDirectory;
			string repository;
			global::Gibraltar.ProgressMonitorStack progressMonitorStack;
			if (asyncTaskArguments != null)
			{
				object[] array = (object[])asyncTaskArguments.State;
				if (array[0] is global::Gibraltar.Data.SessionCriteria)
				{
					sessionCriteria = new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)array[0]);
				}
				else
				{
					sessionPredicate = (global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>)array[0];
				}
				flag = (bool)array[1];
				flag2 = (bool)array[2];
				flag3 = (bool)array[3];
				useGibraltarService = (bool)array[4];
				customerName = (string)array[5];
				server = (string)array[6];
				port = (int)array[7];
				useSsl = (bool)array[8];
				applicationBaseDirectory = (string)array[9];
				repository = (string)array[10];
				progressMonitorStack = asyncTaskArguments.ProgressMonitors;
			}
			else
			{
				object[] array2 = (object[])state;
				if (array2[0] is global::Gibraltar.Data.SessionCriteria)
				{
					sessionCriteria = new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)array2[0]);
				}
				else
				{
					sessionPredicate = (global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>)array2[0];
				}
				flag = (bool)array2[1];
				flag2 = (bool)array2[2];
				flag3 = (bool)array2[3];
				useGibraltarService = (bool)array2[4];
				customerName = (string)array2[5];
				server = (string)array2[6];
				port = (int)array2[7];
				useSsl = (bool)array2[8];
				applicationBaseDirectory = (string)array2[9];
				repository = (string)array2[10];
				progressMonitorStack = (global::Gibraltar.ProgressMonitorStack)array2[11];
			}
			global::Gibraltar.Data.Packager.LogSendToServer(flag3, useGibraltarService, flag, flag2, customerName, server, port, useSsl, applicationBaseDirectory, repository);
			if (flag3)
			{
				try
				{
					global::Gibraltar.Server.Client.HubConnection.ValidateConfiguration(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory);
					goto IL_1EF;
				}
				catch (global::System.InvalidOperationException ex)
				{
					throw new global::System.ArgumentException(ex.Message, ex);
				}
			}
			global::Gibraltar.Monitor.Log.Configuration.Server.Validate();
			IL_1EF:
			global::Gibraltar.Data.PackageSendEventArgs packageSendEventArgs;
			using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitorStack.NewMonitor(this, "Sending session information...", 1))
			{
				progressMonitor.Update("Finding sessions...", 0);
				bool flag4;
				global::Loupe.Extensibility.Data.ISessionSummaryCollection sessionSummaryCollection = (sessionCriteria != null) ? this.FindPackageSessions(sessionCriteria.Value, progressMonitorStack, out flag4) : this.FindPackageSessions(sessionPredicate, progressMonitorStack, out flag4);
				if (sessionSummaryCollection != null && sessionSummaryCollection.Count > 0)
				{
					progressMonitor.Update("Sending Sessions...", 0);
					using (global::Gibraltar.ProgressMonitor progressMonitor2 = progressMonitorStack.NewMonitor(this, "Sending Sessions...", sessionSummaryCollection.Count))
					{
						progressMonitor2.Update("Connecting to server...");
						global::Gibraltar.Data.Internal.RepositoryPublishClient repositoryPublishClient;
						if (flag3)
						{
							repositoryPublishClient = new global::Gibraltar.Data.Internal.RepositoryPublishClient(this.m_Repository, useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository);
						}
						else
						{
							repositoryPublishClient = new global::Gibraltar.Data.Internal.RepositoryPublishClient(this.m_Repository);
						}
						int num = 0;
						int count = sessionSummaryCollection.Count;
						int fileSize = 0;
						global::System.Exception exception = null;
						global::Gibraltar.Server.Client.HubStatus hubStatus;
						string text;
						global::Gibraltar.AsyncTaskResult result;
						if (!repositoryPublishClient.CanConnect(out hubStatus, out text))
						{
							result = global::Gibraltar.AsyncTaskResult.Error;
							text = string.Format("Unable to send sessions to server.\r\n{0}\r\nIt's possible that your Internet connection is unavailable or that software on your computer is blocking network traffic.\r\n\r\nVerify that you have an active Internet connection and that you don't have software on your computer that will block applications communicating to the Internet.", text);
						}
						else
						{
							try
							{
								foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in sessionSummaryCollection)
								{
									global::System.DateTimeOffset endDateTime = sessionSummary.EndDateTime;
									progressMonitor2.Update(string.Format("Sending session {0} of {1}...", num + 1, count), num, count);
									repositoryPublishClient.UploadSession(sessionSummary.Id, 2, flag2);
									if (flag)
									{
										global::Gibraltar.Monitor.LocalRepository repository2 = repositoryPublishClient.Repository;
										try
										{
											repository2.SetSessionsNew(new global::System.Guid[]
											{
												sessionSummary.Id
											}, false);
										}
										catch (global::System.Exception ex2)
										{
											if (!global::Gibraltar.Monitor.Log.SilentMode)
											{
												global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Packager", "Error marking an included session as read", "Unable to mark a session we successfully uploaded as read.  This won't prevent sessions from being sent.  Exception:\r\n{0}", new object[]
												{
													ex2.Message
												});
											}
										}
									}
									num++;
								}
								result = global::Gibraltar.AsyncTaskResult.Success;
								text = string.Format("{0} Sessions Sent.", count);
								progressMonitor.Update(text, 1, 1);
							}
							catch (global::System.Exception ex3)
							{
								result = global::Gibraltar.AsyncTaskResult.Error;
								text = "Unable to send sessions to server.\r\n\r\nIt's possible that your Internet connection is unavailable or that software on your computer is blocking network traffic.\r\n\r\nVerify that you have an active Internet connection and that you don't have software on your computer that will block applications communicating to the Internet.";
								exception = ex3;
							}
						}
						packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(fileSize, result, text, exception);
						goto IL_46F;
					}
				}
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "No Sessions to Send", "The packager process didn't find any sessions to send in the package based on the selection criteria.", new object[0]);
				}
				progressMonitor.Update("No sessions were found to send.", 1, 1);
				packageSendEventArgs = new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Information, "No sessions were found to send.", null);
				IL_46F:
				if (asyncTaskArguments != null)
				{
					asyncTaskArguments.TaskResult = packageSendEventArgs;
				}
			}
			global::Gibraltar.AsyncTaskResult result2 = packageSendEventArgs.Result;
			switch (result2)
			{
			case global::Gibraltar.AsyncTaskResult.Unknown:
			{
				string caption = "Completed asynchronous session transmission to server";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_534;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled:
			{
				string caption = "Canceled asynchronous session transmission to server";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_534;
			}
			case global::Gibraltar.AsyncTaskResult.Error:
			{
				string caption = "Completed asynchronous session transmission to server with errors";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Error;
				goto IL_534;
			}
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
			case global::Gibraltar.AsyncTaskResult.Canceled | global::Gibraltar.AsyncTaskResult.Error | global::Gibraltar.AsyncTaskResult.Warning:
				break;
			case global::Gibraltar.AsyncTaskResult.Warning:
			{
				string caption = "Completed asynchronous session transmission to server with warnings";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Warning;
				goto IL_534;
			}
			case global::Gibraltar.AsyncTaskResult.Information:
			{
				string caption = "Completed asynchronous session transmission to server";
				global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Information;
				goto IL_534;
			}
			default:
				if (result2 == global::Gibraltar.AsyncTaskResult.Success)
				{
					string caption = "Completed asynchronous session transmission to server";
					global::Loupe.Extensibility.Data.LogMessageSeverity severity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
					goto IL_534;
				}
				break;
			}
			throw new global::System.ArgumentOutOfRangeException();
			IL_534:
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				string caption;
				global::Loupe.Extensibility.Data.LogMessageSeverity severity;
				global::Gibraltar.Monitor.Log.WriteMessage(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, 0, packageSendEventArgs.Exception, null, caption, packageSendEventArgs.Message, new object[0]);
			}
			if (asyncTaskArguments != null)
			{
				asyncTaskArguments.TaskResult = packageSendEventArgs;
			}
			this.OnEndSend(packageSendEventArgs);
			return packageSendEventArgs;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0007087C File Offset: 0x0006EA7C
		private void AsyncSendToEmail(object state)
		{
			try
			{
				this.ActionSendToEmail(state);
			}
			catch (global::System.Exception ex)
			{
				this.SafeHandleAsyncSendException(state, "Unable to create and send package", ex);
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000708BC File Offset: 0x0006EABC
		private void AsyncSendToFile(object state)
		{
			try
			{
				this.ActionSendToFile(state);
			}
			catch (global::System.Exception ex)
			{
				this.SafeHandleAsyncSendException(state, "Unable to create and write package to a file", ex);
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000708FC File Offset: 0x0006EAFC
		private void AsyncSendToServer(object state)
		{
			try
			{
				this.ActionSendToServer(state);
			}
			catch (global::System.Exception ex)
			{
				this.SafeHandleAsyncSendException(state, "Unable to create and send package", ex);
			}
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0007093C File Offset: 0x0006EB3C
		private void SafeHandleAsyncSendException(object state, string message, global::System.Exception ex)
		{
			global::Gibraltar.AsyncTaskArguments asyncTaskArguments = state as global::Gibraltar.AsyncTaskArguments;
			if (asyncTaskArguments != null)
			{
				asyncTaskArguments.TaskResult = new global::Gibraltar.AsyncTaskResultEventArgs(global::Gibraltar.AsyncTaskResult.Error, message, ex);
			}
			this.OnEndSend(new global::Gibraltar.Data.PackageSendEventArgs(0, global::Gibraltar.AsyncTaskResult.Error, message, ex));
		}

		// Token: 0x04000B95 RID: 2965
		public const string LogCategory = "Loupe.Packager";

		// Token: 0x04000B96 RID: 2966
		private readonly global::Gibraltar.Monitor.LocalRepository m_Repository;

		// Token: 0x04000B97 RID: 2967
		private readonly global::Gibraltar.Monitor.AgentConfiguration m_Configuration;

		// Token: 0x04000B98 RID: 2968
		private readonly object m_TransportThreadLock = new object();

		// Token: 0x04000B99 RID: 2969
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> m_TransportQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase>();

		// Token: 0x04000B9A RID: 2970
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase> m_CleanupQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Data.Internal.TransportPackageBase>();

		// Token: 0x04000B9B RID: 2971
		private static readonly string[] UserListFormat = new string[]
		{
			"Anonymous",
			"{0}",
			"{0} and {1}",
			"{0}, {1}, et al"
		};

		// Token: 0x04000B9C RID: 2972
		private static readonly int UserListMaxCount = global::Gibraltar.Data.Packager.UserListFormat.Length - 1;

		// Token: 0x04000B9D RID: 2973
		private bool m_TransportThreadDispatched;

		// Token: 0x04000B9E RID: 2974
		private bool m_Disposed;

		// Token: 0x020004B9 RID: 1209
		private class PackagingState
		{
			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000BB214 File Offset: 0x000B9414
			// (set) Token: 0x060033E8 RID: 13288 RVA: 0x000BB21C File Offset: 0x000B941C
			public global::System.Guid? LastSessionId { get; set; }

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x060033E9 RID: 13289 RVA: 0x000BB228 File Offset: 0x000B9428
			// (set) Token: 0x060033EA RID: 13290 RVA: 0x000BB230 File Offset: 0x000B9430
			public global::System.Guid? NextSessionId { get; set; }

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x060033EB RID: 13291 RVA: 0x000BB23C File Offset: 0x000B943C
			// (set) Token: 0x060033EC RID: 13292 RVA: 0x000BB244 File Offset: 0x000B9444
			public global::System.IO.Stream NextSessionStream { get; set; }

			// Token: 0x17000EFC RID: 3836
			// (get) Token: 0x060033ED RID: 13293 RVA: 0x000BB250 File Offset: 0x000B9450
			// (set) Token: 0x060033EE RID: 13294 RVA: 0x000BB258 File Offset: 0x000B9458
			public bool IsComplete { get; set; }
		}
	}
}
