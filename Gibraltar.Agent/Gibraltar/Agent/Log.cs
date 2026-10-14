using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Agent.Configuration;
using Gibraltar.Agent.Internal;
using Gibraltar.Agent.Metrics.Internal;
using Gibraltar.Agent.Net;
using Gibraltar.Data;
using Gibraltar.Messaging;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x02000006 RID: 6
	public static class Log
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000009 RID: 9 RVA: 0x000020A4 File Offset: 0x000002A4
		// (remove) Token: 0x0600000A RID: 10 RVA: 0x000020DC File Offset: 0x000002DC
		private static event global::Gibraltar.Agent.Log.MessageAlertEventHandler s_MessageAlertEvent;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000B RID: 11 RVA: 0x00002114 File Offset: 0x00000314
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x0000214C File Offset: 0x0000034C
		private static event global::Gibraltar.Agent.Log.MessageFilterEventHandler s_MessageFilterEvent;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600000D RID: 13 RVA: 0x00002184 File Offset: 0x00000384
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x000021BC File Offset: 0x000003BC
		public static event global::Gibraltar.Agent.Log.InitializingEventHandler Initializing;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600000F RID: 15 RVA: 0x000021F4 File Offset: 0x000003F4
		// (remove) Token: 0x06000010 RID: 16 RVA: 0x00002254 File Offset: 0x00000454
		public static event global::Gibraltar.Agent.Log.MessageFilterEventHandler LiveViewerMessageFilter
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_MessageFilterEvent == null)
					{
						global::Gibraltar.Monitor.Listener.LiveViewerMessageFilter += global::Gibraltar.Agent.Log.LiveViewerOnMessageFilter;
					}
					global::Gibraltar.Agent.Log.s_MessageFilterEvent += value;
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_MessageFilterEvent != null)
					{
						global::Gibraltar.Agent.Log.s_MessageFilterEvent -= value;
						if (global::Gibraltar.Agent.Log.s_MessageFilterEvent == null)
						{
							global::Gibraltar.Monitor.Listener.LiveViewerMessageFilter -= global::Gibraltar.Agent.Log.LiveViewerOnMessageFilter;
						}
					}
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000011 RID: 17 RVA: 0x000022C0 File Offset: 0x000004C0
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x00002324 File Offset: 0x00000524
		public static event global::Gibraltar.Agent.Log.MessageAlertEventHandler MessageAlert
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_MessageAlertEvent == null)
					{
						global::Gibraltar.Monitor.Log.MessageAlertNotifier.NotificationEvent += global::Gibraltar.Agent.Log.MessageAlertNotifierOnNotificationEvent;
					}
					global::Gibraltar.Agent.Log.s_MessageAlertEvent += value;
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_MessageAlertEvent != null)
					{
						global::Gibraltar.Agent.Log.s_MessageAlertEvent -= value;
						if (global::Gibraltar.Agent.Log.s_MessageAlertEvent == null)
						{
							global::Gibraltar.Monitor.Log.MessageAlertNotifier.NotificationEvent -= global::Gibraltar.Agent.Log.MessageAlertNotifierOnNotificationEvent;
						}
					}
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000013 RID: 19 RVA: 0x00002398 File Offset: 0x00000598
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x0000240C File Offset: 0x0000060C
		public static event global::Gibraltar.Agent.Log.ResolveApplicationUserEventHandler ResolveApplicationUser
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_ResolveApplicationUserLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_ResolveUserEvent == null)
					{
						global::Gibraltar.Monitor.Log.UserResolutionNotifier.ResolveUser += global::Gibraltar.Agent.Log.LogOnResolveUser;
					}
					global::Gibraltar.Agent.Log.s_ResolveUserEvent = (global::Gibraltar.Agent.Log.ResolveApplicationUserEventHandler)global::System.Delegate.Combine(global::Gibraltar.Agent.Log.s_ResolveUserEvent, value);
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Agent.Log.s_ResolveApplicationUserLock;
				lock (obj)
				{
					if (global::Gibraltar.Agent.Log.s_ResolveUserEvent != null)
					{
						global::Gibraltar.Agent.Log.s_ResolveUserEvent = (global::Gibraltar.Agent.Log.ResolveApplicationUserEventHandler)global::System.Delegate.Remove(global::Gibraltar.Agent.Log.s_ResolveUserEvent, value);
						if (global::Gibraltar.Agent.Log.s_ResolveUserEvent == null)
						{
							global::Gibraltar.Monitor.Log.UserResolutionNotifier.ResolveUser -= global::Gibraltar.Agent.Log.LogOnResolveUser;
						}
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000248C File Offset: 0x0000068C
		static Log()
		{
			global::Gibraltar.Monitor.Log.Initializing += global::Gibraltar.Agent.Log.LogOnInitializing;
			global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialsRequired += global::Gibraltar.Agent.Log.CachedCredentialsManagerOnCredentialsRequired;
			global::Gibraltar.Monitor.Log.SilentMode = true;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000024F4 File Offset: 0x000006F4
		public static bool AutoSendConsentGranted
		{
			get
			{
				return global::Gibraltar.Monitor.Log.AutoSendConsentGranted;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024FC File Offset: 0x000006FC
		public static void ApplyConsent()
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			global::Gibraltar.Monitor.Log.ApplyConsent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002510 File Offset: 0x00000710
		public static void DisplayStartupConsentDialog()
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			global::Gibraltar.Monitor.Log.DisplayStartupConsentDialog();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002524 File Offset: 0x00000724
		public static void DisplayConsentDialog()
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			global::Gibraltar.Monitor.Log.DisplayConsentDialog();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002538 File Offset: 0x00000738
		public static global::Gibraltar.Agent.SessionSummary SessionSummary
		{
			get
			{
				global::Gibraltar.Agent.Log.EnsureSummaryIsAvailable();
				return global::Gibraltar.Agent.Log.s_SessionSummary;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000254C File Offset: 0x0000074C
		public static bool SendSessionsOnExit
		{
			get
			{
				return global::Gibraltar.Monitor.Log.SendSessionsOnExit;
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
				{
					return;
				}
				global::Gibraltar.Monitor.Log.SetSendSessionsOnExit(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002560 File Offset: 0x00000760
		public static global::System.Version AgentVersion
		{
			get
			{
				return global::Gibraltar.Monitor.Log.AgentVersion;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002568 File Offset: 0x00000768
		public static void Verbose(string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000258C File Offset: 0x0000078C
		public static void Verbose(global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025C4 File Offset: 0x000007C4
		public static void Verbose(global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025FC File Offset: 0x000007FC
		public static void Verbose(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002634 File Offset: 0x00000834
		public static void VerboseDetail(string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000266C File Offset: 0x0000086C
		public static void VerboseDetail(global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026A8 File Offset: 0x000008A8
		public static void VerboseDetail(global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026E0 File Offset: 0x000008E0
		public static void VerboseDetail(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000271C File Offset: 0x0000091C
		public static void Information(string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002740 File Offset: 0x00000940
		public static void Information(global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002778 File Offset: 0x00000978
		public static void Information(global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027AC File Offset: 0x000009AC
		public static void Information(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000027E4 File Offset: 0x000009E4
		public static void InformationDetail(string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002818 File Offset: 0x00000A18
		public static void InformationDetail(global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002850 File Offset: 0x00000A50
		public static void InformationDetail(global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002888 File Offset: 0x00000A88
		public static void InformationDetail(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028C4 File Offset: 0x00000AC4
		public static void Warning(string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000028E8 File Offset: 0x00000AE8
		public static void Warning(global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002920 File Offset: 0x00000B20
		public static void Warning(global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002954 File Offset: 0x00000B54
		public static void Warning(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000298C File Offset: 0x00000B8C
		public static void WarningDetail(string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029C0 File Offset: 0x00000BC0
		public static void WarningDetail(global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029F8 File Offset: 0x00000BF8
		public static void WarningDetail(global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A30 File Offset: 0x00000C30
		public static void WarningDetail(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A6C File Offset: 0x00000C6C
		public static void Error(string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A90 File Offset: 0x00000C90
		public static void Error(global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public static void Error(global::System.Exception exception, bool attributeToException, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, attributeToException, caption, description, args).PublishToLog();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002B00 File Offset: 0x00000D00
		public static void Error(global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B34 File Offset: 0x00000D34
		public static void Error(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B6C File Offset: 0x00000D6C
		public static void Error(global::System.Exception exception, bool attributeToException, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, attributeToException, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public static void ErrorDetail(string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public static void ErrorDetail(global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002C10 File Offset: 0x00000E10
		public static void ErrorDetail(global::System.Exception exception, bool attributeToException, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002C4C File Offset: 0x00000E4C
		public static void ErrorDetail(global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C84 File Offset: 0x00000E84
		public static void ErrorDetail(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public static void ErrorDetail(global::System.Exception exception, bool attributeToException, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static void Critical(string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D20 File Offset: 0x00000F20
		public static void Critical(global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002D58 File Offset: 0x00000F58
		public static void Critical(global::System.Exception exception, bool attributeToException, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, attributeToException, caption, description, args).PublishToLog();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002D90 File Offset: 0x00000F90
		public static void Critical(global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, caption, description, args).PublishToLog();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public static void Critical(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, caption, description, args).PublishToLog();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002DFC File Offset: 0x00000FFC
		public static void Critical(global::System.Exception exception, bool attributeToException, global::Gibraltar.Agent.LogWriteMode writeMode, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, attributeToException, caption, description, args).PublishToLog();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E34 File Offset: 0x00001034
		public static void CriticalDetail(string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E68 File Offset: 0x00001068
		public static void CriticalDetail(global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002EA0 File Offset: 0x000010A0
		public static void CriticalDetail(global::System.Exception exception, bool attributeToException, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", category, 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002EDC File Offset: 0x000010DC
		public static void CriticalDetail(global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002F14 File Offset: 0x00001114
		public static void CriticalDetail(global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002F50 File Offset: 0x00001150
		public static void CriticalDetail(global::System.Exception exception, bool attributeToException, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, (global::Gibraltar.Monitor.LogWriteMode)writeMode, "Gibraltar", category, 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F8C File Offset: 0x0000118C
		public static void Write(global::Gibraltar.Agent.LogMessageSeverity severity, string logSystem, int skipFrames, global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			new global::Gibraltar.Monitor.DetailLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)severity, (global::Gibraltar.Monitor.LogWriteMode)writeMode, logSystem, category, skipFrames + 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002FD0 File Offset: 0x000011D0
		public static void Write(global::Gibraltar.Agent.LogMessageSeverity severity, string logSystem, int skipFrames, global::System.Exception exception, bool attributeToException, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			new global::Gibraltar.Monitor.DetailLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)severity, (global::Gibraltar.Monitor.LogWriteMode)writeMode, logSystem, category, skipFrames + 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003018 File Offset: 0x00001218
		public static void Write(global::Gibraltar.Agent.LogMessageSeverity severity, string logSystem, global::Gibraltar.Agent.IMessageSourceProvider sourceProvider, string userName, global::System.Exception exception, global::Gibraltar.Agent.LogWriteMode writeMode, string detailsXml, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			global::Gibraltar.Monitor.Log.WriteMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)severity, (global::Gibraltar.Monitor.LogWriteMode)writeMode, logSystem, category, (sourceProvider == null) ? null : new global::Gibraltar.Agent.Internal.MessageSourceProvider(sourceProvider), userName, exception, detailsXml, caption, description, args);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003060 File Offset: 0x00001260
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void RecordException(global::System.Exception exception, string category, bool canContinue = true)
		{
			if (exception != null)
			{
				global::Gibraltar.Monitor.Log.RecordException(1, exception, null, category, canContinue);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003074 File Offset: 0x00001274
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static global::System.Windows.Forms.DialogResult ReportException(global::System.Exception exception, string category, bool canContinue = true, bool waitForResponse = true)
		{
			global::System.Windows.Forms.DialogResult result = global::System.Windows.Forms.DialogResult.None;
			if (exception != null)
			{
				result = global::Gibraltar.Monitor.Log.ReportException(1, exception, null, category, canContinue, waitForResponse);
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000309C File Offset: 0x0000129C
		public static void TraceVerbose(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Gibraltar", "Trace", 1, format, args).PublishToLog();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000030C4 File Offset: 0x000012C4
		public static void TraceVerbose(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, format, args).PublishToLog();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000030FC File Offset: 0x000012FC
		public static void TraceInformation(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar", "Trace", 1, format, args).PublishToLog();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003124 File Offset: 0x00001324
		public static void TraceInformation(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, format, args).PublishToLog();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000315C File Offset: 0x0000135C
		public static void TraceWarning(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar", "Trace", 1, format, args).PublishToLog();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003184 File Offset: 0x00001384
		public static void TraceWarning(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, format, args).PublishToLog();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000031BC File Offset: 0x000013BC
		public static void TraceError(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, "Gibraltar", "Trace", 1, format, args).PublishToLog();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000031E4 File Offset: 0x000013E4
		public static void TraceError(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, format, args).PublishToLog();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000321C File Offset: 0x0000141C
		public static void TraceCritical(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, "Gibraltar", "Trace", 1, format, args).PublishToLog();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003244 File Offset: 0x00001444
		public static void TraceCritical(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, format, args).PublishToLog();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000327C File Offset: 0x0000147C
		public static void RegisterUIThread()
		{
			global::Gibraltar.Monitor.Log.RegisterUIThread();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003284 File Offset: 0x00001484
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndFile()
		{
			global::Gibraltar.Monitor.Log.EndFile(1, string.Empty);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003294 File Offset: 0x00001494
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndFile(string reason)
		{
			global::Gibraltar.Monitor.Log.EndFile(1, reason);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000032A0 File Offset: 0x000014A0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndFile(int skipFrames, string reason)
		{
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			global::Gibraltar.Monitor.Log.EndFile(skipFrames + 1, reason);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000032B8 File Offset: 0x000014B8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession(global::Gibraltar.Agent.SessionStatus endingStatus, global::Gibraltar.Agent.IMessageSourceProvider sourceProvider, string reason)
		{
			global::Gibraltar.Monitor.Log.EndSession((global::Loupe.Extensibility.Data.SessionStatus)endingStatus, (sourceProvider == null) ? null : new global::Gibraltar.Agent.Internal.MessageSourceProvider(sourceProvider), reason);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000032D4 File Offset: 0x000014D4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession(global::Gibraltar.Agent.SessionStatus endingStatus, int skipFrames, string reason)
		{
			global::Gibraltar.Monitor.Log.EndSession((global::Loupe.Extensibility.Data.SessionStatus)endingStatus, skipFrames + 1, reason);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000032E0 File Offset: 0x000014E0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession(global::Gibraltar.Agent.SessionStatus endingStatus, string reason)
		{
			global::Gibraltar.Monitor.Log.EndSession((global::Loupe.Extensibility.Data.SessionStatus)endingStatus, 1, reason);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000032EC File Offset: 0x000014EC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession(string reason)
		{
			global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, 1, reason);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000032F8 File Offset: 0x000014F8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession()
		{
			global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, 1, null);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003304 File Offset: 0x00001504
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession()
		{
			global::Gibraltar.Monitor.Log.StartSession(null, 1, null);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003310 File Offset: 0x00001510
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(string reason)
		{
			global::Gibraltar.Monitor.Log.StartSession(null, 1, reason);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000331C File Offset: 0x0000151C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(int skipFrames, string reason)
		{
			global::Gibraltar.Monitor.Log.StartSession(null, skipFrames + 1, reason);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003328 File Offset: 0x00001528
		public static void StartSession(global::Gibraltar.Agent.IMessageSourceProvider sourceProvider, string reason)
		{
			global::Gibraltar.Monitor.Log.StartSession(null, (sourceProvider == null) ? null : new global::Gibraltar.Agent.Internal.MessageSourceProvider(sourceProvider), reason);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003344 File Offset: 0x00001544
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(global::Gibraltar.Agent.Configuration.AgentConfiguration configuration)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			global::Gibraltar.Monitor.Log.StartSession(configuration.WrappedObject, 1, null);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003364 File Offset: 0x00001564
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(global::Gibraltar.Agent.Configuration.AgentConfiguration configuration, string reason)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			global::Gibraltar.Monitor.Log.StartSession(configuration.WrappedObject, 1, reason);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003384 File Offset: 0x00001584
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(global::Gibraltar.Agent.Configuration.AgentConfiguration configuration, int skipFrames, string reason)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			global::Gibraltar.Monitor.Log.StartSession(configuration.WrappedObject, skipFrames + 1, reason);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000033A8 File Offset: 0x000015A8
		public static void StartSession(global::Gibraltar.Agent.Configuration.AgentConfiguration configuration, global::Gibraltar.Agent.IMessageSourceProvider sourceProvider, string reason)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			global::Gibraltar.Monitor.Log.StartSession(configuration.WrappedObject, (sourceProvider == null) ? null : new global::Gibraltar.Agent.Internal.MessageSourceProvider(sourceProvider), reason);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000033DC File Offset: 0x000015DC
		public static void ShowLiveViewer()
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return;
			}
			global::Gibraltar.Monitor.Log.ShowLiveViewer();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000033F0 File Offset: 0x000015F0
		public static void SendMessage(global::System.Net.Mail.MailMessage message)
		{
			global::Gibraltar.Monitor.EmailConfiguration email = global::Gibraltar.Monitor.Log.Configuration.Email;
			global::Gibraltar.Monitor.PackagerConfiguration packager = global::Gibraltar.Monitor.Log.Configuration.Packager;
			global::System.Net.Mail.SmtpClient smtpClient;
			if (string.IsNullOrEmpty(email.Server))
			{
				smtpClient = new global::System.Net.Mail.SmtpClient();
			}
			else if (email.Port == 0)
			{
				smtpClient = new global::System.Net.Mail.SmtpClient(email.Server);
			}
			else
			{
				smtpClient = new global::System.Net.Mail.SmtpClient(email.Server, email.Port);
			}
			smtpClient.Credentials = global::System.Net.CredentialCache.DefaultNetworkCredentials;
			if (!string.IsNullOrEmpty(email.User))
			{
				smtpClient.Credentials = new global::System.Net.NetworkCredential(email.User, email.Password);
			}
			smtpClient.EnableSsl = email.UseSsl;
			if (message.To.Count == 0 && !string.IsNullOrEmpty(packager.DestinationEmailAddress))
			{
				message.To.Add(packager.DestinationEmailAddress);
			}
			if ((message.From == null || string.IsNullOrEmpty(message.From.Address)) && !string.IsNullOrEmpty(packager.FromEmailAddress))
			{
				message.From = new global::System.Net.Mail.MailAddress(packager.FromEmailAddress);
			}
			smtpClient.Send(message);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003518 File Offset: 0x00001718
		public static bool SendSessions(global::Gibraltar.Agent.SessionCriteria criteria)
		{
			return global::Gibraltar.Monitor.Log.IsLoggingActive(false) && global::Gibraltar.Monitor.Log.SendSessions(new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)criteria), null, false);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003534 File Offset: 0x00001734
		public static bool SendSessions(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return false;
			}
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			return global::Gibraltar.Monitor.Log.SendSessions(null, new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), false);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003574 File Offset: 0x00001774
		public static bool SendSessionsAsync(global::Gibraltar.Agent.SessionCriteria criteria)
		{
			return global::Gibraltar.Monitor.Log.IsLoggingActive(false) && global::Gibraltar.Monitor.Log.SendSessions(new global::Gibraltar.Data.SessionCriteria?((global::Gibraltar.Data.SessionCriteria)criteria), null, true);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003590 File Offset: 0x00001790
		public static bool SendSessionsAsync(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionMatchPredicate)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(false))
			{
				return false;
			}
			global::Gibraltar.Agent.Internal.SessionSummaryPredicate @object = new global::Gibraltar.Agent.Internal.SessionSummaryPredicate(sessionMatchPredicate);
			return global::Gibraltar.Monitor.Log.SendSessions(null, new global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary>(@object.Predicate), true);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000035D0 File Offset: 0x000017D0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000035D8 File Offset: 0x000017D8
		public static global::Gibraltar.Agent.Net.IServerAuthenticationProvider ServerAuthenticationProvider
		{
			get
			{
				return global::Gibraltar.Agent.Log.s_ServerAuthenticationProvider;
			}
			set
			{
				global::Gibraltar.Agent.Log.s_ServerAuthenticationProvider = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000035E0 File Offset: 0x000017E0
		internal static global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection MetricDefinitions
		{
			get
			{
				return global::Gibraltar.Agent.Log.s_MetricDefinitions;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000035E8 File Offset: 0x000017E8
		private static void LogOnInitializing(object sender, global::Gibraltar.Monitor.LogInitializingEventArgs e)
		{
			global::Gibraltar.Agent.Log.InitializingEventHandler initializing = global::Gibraltar.Agent.Log.Initializing;
			if (initializing != null)
			{
				global::Gibraltar.Agent.LogInitializingEventArgs logInitializingEventArgs = new global::Gibraltar.Agent.LogInitializingEventArgs(new global::Gibraltar.Agent.Configuration.AgentConfiguration(e.Configuration));
				try
				{
					initializing(null, logInitializingEventArgs);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				e.Cancel = logInitializingEventArgs.Cancel;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003648 File Offset: 0x00001848
		private static void CachedCredentialsManagerOnCredentialsRequired(object source, global::Gibraltar.Server.Client.CredentialsRequiredEventArgs e)
		{
			global::Gibraltar.Agent.Net.IServerAuthenticationProvider serverAuthenticationProvider = global::Gibraltar.Agent.Log.s_ServerAuthenticationProvider;
			if (serverAuthenticationProvider == null)
			{
				return;
			}
			e.AuthenticationProvider = new global::Gibraltar.Agent.Internal.WebAuthenticationProvider(serverAuthenticationProvider);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003674 File Offset: 0x00001874
		private static void EnsureSummaryIsAvailable()
		{
			object obj = global::Gibraltar.Agent.Log.s_SyncLock;
			lock (obj)
			{
				if (global::Gibraltar.Agent.Log.s_SessionSummary == null)
				{
					global::Gibraltar.Agent.Log.s_SessionSummary = new global::Gibraltar.Agent.SessionSummary(global::Gibraltar.Monitor.Log.SessionSummary);
				}
				else
				{
					global::Gibraltar.Agent.Log.s_SessionSummary.SyncWrappedObject(global::Gibraltar.Monitor.Log.SessionSummary);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Agent.Log.s_SyncLock);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000036E0 File Offset: 0x000018E0
		private static void LogOnResolveUser(object sender, global::Gibraltar.Monitor.ResolveUserEventArgs e)
		{
			global::Gibraltar.Agent.Log.ResolveApplicationUserEventHandler resolveApplicationUserEventHandler = global::Gibraltar.Agent.Log.s_ResolveUserEvent;
			if (resolveApplicationUserEventHandler != null)
			{
				global::Gibraltar.Agent.ApplicationUserResolutionEventArgs e2 = new global::Gibraltar.Agent.ApplicationUserResolutionEventArgs(e);
				resolveApplicationUserEventHandler(null, e2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000370C File Offset: 0x0000190C
		private static void MessageAlertNotifierOnNotificationEvent(object sender, global::Gibraltar.Messaging.NotificationEventArgs e)
		{
			global::Gibraltar.Agent.Log.MessageAlertEventHandler messageAlertEventHandler = global::Gibraltar.Agent.Log.s_MessageAlertEvent;
			if (messageAlertEventHandler != null)
			{
				global::Gibraltar.Agent.LogMessageAlertEventArgs e2 = new global::Gibraltar.Agent.LogMessageAlertEventArgs(e);
				messageAlertEventHandler(null, e2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003738 File Offset: 0x00001938
		private static void LiveViewerOnMessageFilter(object sender, global::Gibraltar.Monitor.MessageFilterEventArgs e)
		{
			global::Gibraltar.Agent.Log.MessageFilterEventHandler messageFilterEventHandler = global::Gibraltar.Agent.Log.s_MessageFilterEvent;
			if (messageFilterEventHandler != null)
			{
				global::Gibraltar.Agent.LogMessageFilterEventArgs e2 = new global::Gibraltar.Agent.LogMessageFilterEventArgs(e);
				messageFilterEventHandler(sender, e2);
			}
		}

		// Token: 0x04000010 RID: 16
		public const string PackageExtension = "glp";

		// Token: 0x04000011 RID: 17
		private const string ThisLogSystem = "Gibraltar";

		// Token: 0x04000012 RID: 18
		private const string Category = "Trace";

		// Token: 0x04000013 RID: 19
		private const string ExceptionCategory = "System.Exception";

		// Token: 0x04000014 RID: 20
		private const global::Gibraltar.Monitor.LogWriteMode Queued = global::Gibraltar.Monitor.LogWriteMode.Queued;

		// Token: 0x04000015 RID: 21
		private static readonly object s_SyncLock = new object();

		// Token: 0x04000016 RID: 22
		private static global::Gibraltar.Agent.SessionSummary s_SessionSummary;

		// Token: 0x04000017 RID: 23
		private static readonly global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection s_MetricDefinitions = new global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection(global::Gibraltar.Monitor.Log.Metrics);

		// Token: 0x0400001A RID: 26
		private static readonly object s_MessageEventLock = new object();

		// Token: 0x0400001B RID: 27
		private static global::Gibraltar.Agent.Log.ResolveApplicationUserEventHandler s_ResolveUserEvent;

		// Token: 0x0400001C RID: 28
		private static readonly object s_ResolveApplicationUserLock = new object();

		// Token: 0x0400001D RID: 29
		private static bool s_InitializedComplete;

		// Token: 0x0400001E RID: 30
		private static global::Gibraltar.Agent.Net.IServerAuthenticationProvider s_ServerAuthenticationProvider;

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x060032C8 RID: 13000
		public delegate void InitializingEventHandler(object sender, global::Gibraltar.Agent.LogInitializingEventArgs e);

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x060032CC RID: 13004
		public delegate void MessageFilterEventHandler(object sender, global::Gibraltar.Agent.LogMessageFilterEventArgs e);

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x060032D0 RID: 13008
		public delegate void MessageAlertEventHandler(object sender, global::Gibraltar.Agent.LogMessageAlertEventArgs e);

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x060032D4 RID: 13012
		public delegate void ResolveApplicationUserEventHandler(object sender, global::Gibraltar.Agent.ApplicationUserResolutionEventArgs e);
	}
}
