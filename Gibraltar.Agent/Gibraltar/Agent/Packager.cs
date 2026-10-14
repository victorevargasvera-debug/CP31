using System;
using Gibraltar.Agent.Internal;
using Gibraltar.Data;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x0200000D RID: 13
	public sealed class Packager : global::System.IDisposable
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000A0 RID: 160 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (remove) Token: 0x060000A1 RID: 161 RVA: 0x00003B34 File Offset: 0x00001D34
		public event global::System.EventHandler BeginSend;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000A2 RID: 162 RVA: 0x00003B70 File Offset: 0x00001D70
		// (remove) Token: 0x060000A3 RID: 163 RVA: 0x00003BAC File Offset: 0x00001DAC
		public event global::Gibraltar.Agent.PackageSendEventHandler EndSend;

		// Token: 0x060000A4 RID: 164 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public Packager()
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(false);
			this.m_Packager = new global::Gibraltar.Data.Packager();
			this.Initialize();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003C08 File Offset: 0x00001E08
		public Packager(string productName)
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(false);
			this.m_Packager = new global::Gibraltar.Data.Packager(productName);
			this.Initialize();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003C2C File Offset: 0x00001E2C
		public Packager(string productName, string applicationName)
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(false);
			this.m_Packager = new global::Gibraltar.Data.Packager(productName, applicationName);
			this.Initialize();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003C50 File Offset: 0x00001E50
		public Packager(string productName, string applicationName = null, string directory = null)
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(false);
			this.m_Packager = new global::Gibraltar.Data.Packager(productName, applicationName, directory);
			this.Initialize();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003C74 File Offset: 0x00001E74
		public string ProductName
		{
			get
			{
				return this.m_Packager.ProductName;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003C84 File Offset: 0x00001E84
		public string ApplicationName
		{
			get
			{
				return this.m_Packager.ApplicationName;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003C94 File Offset: 0x00001E94
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public string Caption
		{
			get
			{
				return this.m_Packager.Caption;
			}
			set
			{
				this.m_Packager.Caption = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003CB4 File Offset: 0x00001EB4
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public string Description
		{
			get
			{
				return this.m_Packager.Description;
			}
			set
			{
				this.m_Packager.Description = value;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public void SendEmail(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject)
		{
			this.SendEmail(sessions, markAsRead, emailSubject, string.Empty, string.Empty);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003CFC File Offset: 0x00001EFC
		public void SendEmail(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject)
		{
			this.SendEmail(sessionMatchPredicate, markAsRead, emailSubject, string.Empty, string.Empty);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003D14 File Offset: 0x00001F14
		public void SendEmail(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress)
		{
			this.m_Packager.SendEmail((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, emailSubject, fromAddress, destinationAddress, string.Empty, 0, null, string.Empty, string.Empty, false);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003D54 File Offset: 0x00001F54
		public void SendEmail(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendEmail(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, emailSubject, fromAddress, destinationAddress, string.Empty, 0, null, string.Empty, string.Empty, false);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public void SendEmail(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer)
		{
			this.SendEmail(sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, string.Empty, string.Empty);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public void SendEmail(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer)
		{
			this.SendEmail(sessionMatchPredicate, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, string.Empty, string.Empty);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003DFC File Offset: 0x00001FFC
		public void SendEmail(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, string emailServerUser, string emailServerPassword)
		{
			this.SendEmail(sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, 25, false, emailServerUser, emailServerPassword);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003E24 File Offset: 0x00002024
		public void SendEmail(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, string emailServerUser, string emailServerPassword)
		{
			this.SendEmail(sessionMatchPredicate, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, 25, false, emailServerUser, emailServerPassword);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003E4C File Offset: 0x0000204C
		public void SendEmail(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			this.m_Packager.SendEmail((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, serverPort, new bool?(useSsl), emailServerUser, emailServerPassword, false);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003E80 File Offset: 0x00002080
		public void SendEmail(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendEmail(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, serverPort, new bool?(useSsl), emailServerUser, emailServerPassword, false);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003EC8 File Offset: 0x000020C8
		public void SendEmailAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject)
		{
			this.m_Packager.SendEmail((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, emailSubject, string.Empty, string.Empty, string.Empty, 0, null, string.Empty, string.Empty, true);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003F0C File Offset: 0x0000210C
		public void SendEmailAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendEmail(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, emailSubject, string.Empty, string.Empty, string.Empty, 0, null, string.Empty, string.Empty, true);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003F64 File Offset: 0x00002164
		public void SendEmailAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer)
		{
			this.SendEmailAsync(sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, string.Empty, string.Empty);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003F90 File Offset: 0x00002190
		public void SendEmailAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer)
		{
			this.SendEmailAsync(sessionMatchPredicate, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, string.Empty, string.Empty);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003FBC File Offset: 0x000021BC
		public void SendEmailAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, string emailServerUser, string emailServerPassword)
		{
			this.SendEmailAsync(sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, 25, false, emailServerUser, emailServerPassword);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003FE4 File Offset: 0x000021E4
		public void SendEmailAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, string emailServerUser, string emailServerPassword)
		{
			this.SendEmailAsync(sessionMatchPredicate, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, 25, false, emailServerUser, emailServerPassword);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000400C File Offset: 0x0000220C
		public void SendEmailAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			this.m_Packager.SendEmail((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, serverPort, new bool?(useSsl), emailServerUser, emailServerPassword, true);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004040 File Offset: 0x00002240
		public void SendEmailAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string emailSubject, string fromAddress, string destinationAddress, string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendEmail(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, emailSubject, fromAddress, destinationAddress, emailServer, serverPort, new bool?(useSsl), emailServerUser, emailServerPassword, true);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004088 File Offset: 0x00002288
		public void SendToFile(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string fullFileNamePath)
		{
			this.m_Packager.SendToFile((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, fullFileNamePath, false);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000409C File Offset: 0x0000229C
		public void SendToFile(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string fullFileNamePath)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToFile(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, fullFileNamePath, false);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000040D0 File Offset: 0x000022D0
		public void SendToFileAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string fullFileNamePath)
		{
			this.m_Packager.SendToFile((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, fullFileNamePath, true);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000040E4 File Offset: 0x000022E4
		public void SendToFileAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string fullFileNamePath)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToFile(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, fullFileNamePath, true);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004118 File Offset: 0x00002318
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, false, false, null, null, 0, false, null, null, false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004140 File Offset: 0x00002340
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, false, false, null, null, 0, false, null, null, false);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000417C File Offset: 0x0000237C
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, false, false, null, null, 0, false, null, null, false);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000041A4 File Offset: 0x000023A4
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, false, false, null, null, 0, false, null, null, false);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000041E0 File Offset: 0x000023E0
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string customerName)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, true, true, customerName, null, 0, false, null, null, false);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004208 File Offset: 0x00002408
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string customerName)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, true, true, customerName, null, 0, false, null, null, false);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004244 File Offset: 0x00002444
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, string customerName)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, true, true, customerName, null, 0, false, null, null, false);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004270 File Offset: 0x00002470
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions, string customerName)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, true, true, customerName, null, 0, false, null, null, false);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000042AC File Offset: 0x000024AC
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, false);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000042D8 File Offset: 0x000024D8
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, false);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004318 File Offset: 0x00002518
		public void SendToServer(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, false);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004348 File Offset: 0x00002548
		public void SendToServer(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, false);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004388 File Offset: 0x00002588
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, false, false, null, null, 0, false, null, null, true);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000043B0 File Offset: 0x000025B0
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, false, false, null, null, 0, false, null, null, true);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000043EC File Offset: 0x000025EC
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, false, false, null, null, 0, false, null, null, true);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004414 File Offset: 0x00002614
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, false, false, null, null, 0, false, null, null, true);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004450 File Offset: 0x00002650
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string customerName)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, true, true, customerName, null, 0, false, null, null, true);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004478 File Offset: 0x00002678
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string customerName)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, true, true, customerName, null, 0, false, null, null, true);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000044B4 File Offset: 0x000026B4
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, string customerName)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, true, true, customerName, null, 0, false, null, null, true);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000044E0 File Offset: 0x000026E0
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions, string customerName)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, true, true, customerName, null, 0, false, null, null, true);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000451C File Offset: 0x0000271C
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, false, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, true);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004548 File Offset: 0x00002748
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, false, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, true);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004588 File Offset: 0x00002788
		public void SendToServerAsync(global::Gibraltar.Agent.SessionCriteria sessions, bool markAsRead, bool purgeSentSessions, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			this.m_Packager.SendToServer((global::Gibraltar.Data.SessionCriteria)sessions, markAsRead, purgeSentSessions, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, true);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000045B8 File Offset: 0x000027B8
		public void SendToServerAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate, bool markAsRead, bool purgeSentSessions, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			this.m_Packager.SendToServer(new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), markAsRead, purgeSentSessions, true, false, null, server, port, useSsl, applicationBaseDirectory, repository, true);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000045F8 File Offset: 0x000027F8
		private void Initialize()
		{
			this.m_Packager.BeginSend += this.m_Packager_BeginSend;
			this.m_Packager.EndSend += this.m_Packager_EndSend;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004628 File Offset: 0x00002828
		private void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (releaseManaged && this.m_Packager != null)
				{
					this.m_Packager.Dispose();
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004658 File Offset: 0x00002858
		private void OnBeginSend()
		{
			global::System.EventHandler beginSend = this.BeginSend;
			if (beginSend != null)
			{
				beginSend(this, new global::System.EventArgs());
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004684 File Offset: 0x00002884
		private void OnEndSend(global::Gibraltar.Agent.PackageSendEventArgs e)
		{
			global::Gibraltar.Agent.PackageSendEventHandler endSend = this.EndSend;
			if (endSend != null)
			{
				endSend(this, e);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000046AC File Offset: 0x000028AC
		private void m_Packager_EndSend(object sender, global::Gibraltar.Data.PackageSendEventArgs args)
		{
			global::Gibraltar.Agent.PackageSendEventArgs e = new global::Gibraltar.Agent.PackageSendEventArgs(args);
			this.OnEndSend(e);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000046CC File Offset: 0x000028CC
		private void m_Packager_BeginSend(object sender, global::System.EventArgs e)
		{
			this.OnBeginSend();
		}

		// Token: 0x04000031 RID: 49
		private readonly global::Gibraltar.Data.Packager m_Packager;

		// Token: 0x04000032 RID: 50
		private bool m_Disposed;
	}
}
