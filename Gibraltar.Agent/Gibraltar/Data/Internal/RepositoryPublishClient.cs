using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Gibraltar.Messaging;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;
using Gibraltar.Server.Client.Data;
using Gibraltar.Server.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000266 RID: 614
	internal class RepositoryPublishClient : global::System.IDisposable
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x00072508 File Offset: 0x00070708
		public RepositoryPublishClient(global::Gibraltar.Monitor.LocalRepository source) : this(source, null, null, global::Gibraltar.Monitor.Log.Configuration.Server)
		{
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00072520 File Offset: 0x00070720
		public RepositoryPublishClient(global::Gibraltar.Monitor.LocalRepository source, string productName, string applicationName, global::Gibraltar.Messaging.ServerConfiguration configuration) : this(source, configuration.UseGibraltarService, configuration.CustomerName, configuration.Server, configuration.Port, configuration.UseSsl, configuration.ApplicationBaseDirectory, configuration.Repository)
		{
			this.m_ProductName = productName;
			this.m_ApplicationName = applicationName;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00072578 File Offset: 0x00070778
		public RepositoryPublishClient(global::Gibraltar.Monitor.LocalRepository source, bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			this.m_SourceRepository = source;
			this.m_HubConnection = new global::Gibraltar.Server.Client.HubConnection(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository);
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000725C0 File Offset: 0x000707C0
		public global::Gibraltar.Monitor.LocalRepository Repository
		{
			get
			{
				return this.m_SourceRepository;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000725C8 File Offset: 0x000707C8
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000725D4 File Offset: 0x000707D4
		public bool CanConnect(out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage)
		{
			return this.m_HubConnection.CanConnect(out status, out statusMessage);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000725E4 File Offset: 0x000707E4
		public void PublishSessions(bool async, bool purgeSentSessions)
		{
			if (this.m_IsActive)
			{
				return;
			}
			global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> sessions = this.GetSessions();
			if (sessions != null && sessions.Count > 0)
			{
				this.m_IsActive = true;
				object[] state = new object[]
				{
					sessions,
					-1,
					purgeSentSessions
				};
				if (async)
				{
					global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncPublishSessions), state);
					return;
				}
				this.AsyncPublishSessions(state);
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00072664 File Offset: 0x00070864
		public void UploadSession(global::System.Guid sessionId, int maxRetries, bool purgeSentSession)
		{
			this.PerformSessionDataUpload(sessionId, maxRetries, purgeSentSession);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00072670 File Offset: 0x00070870
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00072680 File Offset: 0x00070880
		private void Dispose(bool releaseManaged)
		{
			if (releaseManaged && !this.m_Disposed)
			{
				if (this.m_HubConnection != null)
				{
					this.m_HubConnection.Dispose();
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000726B4 File Offset: 0x000708B4
		private void AsyncPublishSessions(object state)
		{
			try
			{
				object[] array = (object[])state;
				global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> list = (global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary>)array[0];
				int num = (int)array[1];
				bool purgeSentSessions = (bool)array[2];
				if (list != null)
				{
					global::Gibraltar.Server.Client.HubStatus hubStatus;
					string text;
					if (this.m_HubConnection.CanConnect(out hubStatus, out text) || num < 0)
					{
						foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in list)
						{
							try
							{
								this.PerformSessionHeaderUpload(sessionSummary);
							}
							catch (global::System.Exception obj)
							{
								global::System.GC.KeepAlive(obj);
							}
						}
						foreach (global::System.Guid sessionId in this.GetRequestedSessions())
						{
							try
							{
								this.PerformSessionDataUpload(sessionId, num, purgeSentSessions);
							}
							catch (global::System.Exception obj2)
							{
								global::System.GC.KeepAlive(obj2);
							}
						}
					}
				}
			}
			catch (global::System.Exception obj3)
			{
				global::System.GC.KeepAlive(obj3);
			}
			finally
			{
				this.m_IsActive = false;
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00072808 File Offset: 0x00070A08
		private global::System.Collections.Generic.List<global::System.Guid> GetRequestedSessions()
		{
			global::Gibraltar.Server.Client.RequestedSessionsGetRequest requestedSessionsGetRequest = new global::Gibraltar.Server.Client.RequestedSessionsGetRequest(this.m_SourceRepository.Id);
			try
			{
				this.m_HubConnection.ExecuteRequest(requestedSessionsGetRequest, 1);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			global::System.Collections.Generic.List<global::System.Guid> list = new global::System.Collections.Generic.List<global::System.Guid>();
			if (requestedSessionsGetRequest.RequestedSessions != null && requestedSessionsGetRequest.RequestedSessions.sessions != null && requestedSessionsGetRequest.RequestedSessions.sessions.Length != 0)
			{
				foreach (global::Gibraltar.Server.Client.Data.SessionXml sessionXml in requestedSessionsGetRequest.RequestedSessions.sessions)
				{
					try
					{
						global::System.Guid guid = new global::System.Guid(sessionXml.id);
						if (this.m_SourceRepository.SessionDataExists(guid))
						{
							list.Add(guid);
						}
						else if (this.m_HubConnection.ProtocolVersion < global::Gibraltar.Server.Client.HubConnection.Hub30ProtocolVersion && !global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Publish", "Server requesting completed session that's no longer available", "There's no way for us to tell the server that it should stop asking for this session.\r\nSession Id: {0}", new object[]
							{
								guid
							});
						}
					}
					catch (global::System.Exception obj2)
					{
						global::System.GC.KeepAlive(obj2);
					}
				}
			}
			return list;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00072940 File Offset: 0x00070B40
		private global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> GetSessions()
		{
			global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> result = null;
			try
			{
				this.m_SourceRepository.Refresh();
				result = this.m_SourceRepository.Find(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(this.UnsentSessionsPredicate));
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00072994 File Offset: 0x00070B94
		private bool UnsentSessionsPredicate(global::Loupe.Extensibility.Data.ISessionSummary candidateSession)
		{
			bool flag = candidateSession.IsNew;
			if (flag)
			{
				flag = candidateSession.Product.Equals(this.m_ProductName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			if (flag && !string.IsNullOrEmpty(this.m_ApplicationName))
			{
				flag = candidateSession.Application.Equals(this.m_ApplicationName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return flag;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000729F0 File Offset: 0x00070BF0
		private void PerformSessionDataUpload(global::System.Guid sessionId, int maxRetries, bool purgeSentSessions)
		{
			this.m_SourceRepository.Refresh();
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Server.Client.Data.SessionFileXml> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Server.Client.Data.SessionFileXml>();
			bool flag;
			if (this.m_HubConnection.ProtocolVersion < global::Gibraltar.Server.Client.HubConnection.Hub30ProtocolVersion)
			{
				flag = true;
			}
			else
			{
				global::Gibraltar.Server.Client.SessionFilesGetRequest sessionFilesGetRequest = new global::Gibraltar.Server.Client.SessionFilesGetRequest(this.m_SourceRepository.Id, sessionId);
				this.m_HubConnection.ExecuteRequest(sessionFilesGetRequest, maxRetries);
				flag = sessionFilesGetRequest.Files.singleStreamOnly;
				if (!flag && sessionFilesGetRequest.Files.files != null)
				{
					foreach (global::Gibraltar.Server.Client.Data.SessionFileXml sessionFileXml in sessionFilesGetRequest.Files.files)
					{
						dictionary.Add(new global::System.Guid(sessionFileXml.id), sessionFileXml);
					}
				}
			}
			if (flag)
			{
				this.PerformSessionFileUpload(sessionId, null, maxRetries, purgeSentSessions);
				return;
			}
			global::Gibraltar.Data.SessionHeader sessionHeader;
			global::System.Collections.Generic.IList<global::System.IO.FileInfo> list;
			this.m_SourceRepository.LoadSessionFiles(sessionId, out sessionHeader, out list);
			foreach (global::System.IO.FileInfo fileInfo in list)
			{
				global::Gibraltar.Data.SessionHeader sessionHeader2 = global::Gibraltar.Monitor.LocalRepository.LoadSessionHeader(fileInfo.FullName);
				if (sessionHeader2 == null)
				{
					break;
				}
				if (dictionary.ContainsKey(sessionHeader2.FileId))
				{
					if (purgeSentSessions)
					{
						this.m_SourceRepository.Remove(sessionId, sessionHeader2.FileId);
					}
				}
				else
				{
					this.PerformSessionFileUpload(sessionId, new global::System.Guid?(sessionHeader2.FileId), maxRetries, purgeSentSessions);
				}
			}
			if (!this.m_SourceRepository.SessionIsRunning(sessionId))
			{
				this.PerformSessionMarkComplete(sessionId);
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00072B94 File Offset: 0x00070D94
		private void PerformSessionFileUpload(global::System.Guid sessionId, global::System.Guid? fileId, int maxRetries, bool purgeSentSessions)
		{
			using (global::Gibraltar.Server.Client.SessionUploadRequest sessionUploadRequest = new global::Gibraltar.Server.Client.SessionUploadRequest(this.m_SourceRepository.Id, this.m_SourceRepository, sessionId, fileId, purgeSentSessions))
			{
				if (!sessionUploadRequest.PrepareSession())
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Publish", "Skipping sending session to server because another process already is transferring it", "We weren't able to get a transport lock on the session '{0}' so we assume another process is currently sending it.", new object[]
						{
							sessionId
						});
					}
				}
				else
				{
					this.m_HubConnection.ExecuteRequest(sessionUploadRequest, maxRetries);
				}
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00072C2C File Offset: 0x00070E2C
		private void PerformSessionHeaderUpload(global::Loupe.Extensibility.Data.ISessionSummary sessionSummary)
		{
			global::Gibraltar.Server.Client.Data.SessionXml sessionSummary2 = global::Gibraltar.Server.Data.DataConverter.ToSessionXml(sessionSummary);
			this.PerformSessionHeaderUpload(sessionSummary2);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00072C4C File Offset: 0x00070E4C
		private void PerformSessionHeaderUpload(global::Gibraltar.Server.Client.Data.SessionXml sessionSummary)
		{
			global::System.Guid guid = new global::System.Guid(sessionSummary.id);
			sessionSummary.sessionDetail.isComplete = !this.m_SourceRepository.SessionDataExists(guid);
			global::Gibraltar.Server.Client.SessionHeaderUploadRequest newRequest = new global::Gibraltar.Server.Client.SessionHeaderUploadRequest(sessionSummary, this.m_SourceRepository.Id);
			this.m_HubConnection.ExecuteRequest(newRequest, -1);
			this.m_SourceRepository.SetSessionsNew(new global::System.Guid[]
			{
				guid
			}, false);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00072CC0 File Offset: 0x00070EC0
		private void PerformSessionMarkComplete(global::System.Guid sessionId)
		{
			global::Gibraltar.Server.Client.SessionMarkComplete newRequest = new global::Gibraltar.Server.Client.SessionMarkComplete(sessionId, this.m_SourceRepository.Id);
			this.m_HubConnection.ExecuteRequest(newRequest, -1);
		}

		// Token: 0x04000BEF RID: 3055
		internal const string LogCategory = "Loupe.Repository.Publish";

		// Token: 0x04000BF0 RID: 3056
		private readonly global::Gibraltar.Monitor.LocalRepository m_SourceRepository;

		// Token: 0x04000BF1 RID: 3057
		private readonly string m_ProductName;

		// Token: 0x04000BF2 RID: 3058
		private readonly string m_ApplicationName;

		// Token: 0x04000BF3 RID: 3059
		private readonly global::Gibraltar.Server.Client.HubConnection m_HubConnection;

		// Token: 0x04000BF4 RID: 3060
		private volatile bool m_IsActive;

		// Token: 0x04000BF5 RID: 3061
		private volatile bool m_Disposed;
	}
}
