using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Data.Internal;
using Gibraltar.Messaging;
using Gibraltar.Monitor.Internal;
using Gibraltar.Monitor.Windows;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C4 RID: 452
	internal static class Log
	{
		// Token: 0x1400006F RID: 111
		// (add) Token: 0x0600153F RID: 5439 RVA: 0x0003EA84 File Offset: 0x0003CC84
		// (remove) Token: 0x06001540 RID: 5440 RVA: 0x0003EABC File Offset: 0x0003CCBC
		public static event global::Gibraltar.Monitor.Log.InitializingEventHandler Initializing;

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		public static bool BreakPointEnable
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.BreakPointEnable;
			}
			set
			{
				global::Gibraltar.CommonCentralLogic.BreakPointEnable = value;
			}
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0003EB04 File Offset: 0x0003CD04
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void DebugBreak()
		{
			if (global::Gibraltar.Monitor.Log.BreakPointEnable && global::System.Diagnostics.Debugger.IsAttached)
			{
				global::System.Diagnostics.Debugger.Break();
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0003EB20 File Offset: 0x0003CD20
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x0003EB28 File Offset: 0x0003CD28
		public static bool SilentMode
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.SilentMode;
			}
			set
			{
				global::Gibraltar.CommonCentralLogic.SilentMode = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0003EB30 File Offset: 0x0003CD30
		public static bool IsMonoRuntime
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.IsMonoRuntime;
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0003EB38 File Offset: 0x0003CD38
		public static bool IsLoggingActive(bool suppressTraceInitialize)
		{
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return true;
			}
			if (global::Gibraltar.Monitor.Log.s_InitializationNeverAttempted)
			{
				global::Gibraltar.Monitor.Log.Initialize(null, suppressTraceInitialize);
			}
			return global::Gibraltar.Monitor.Log.s_Initialized;
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0003EB64 File Offset: 0x0003CD64
		internal static bool Initialized
		{
			get
			{
				return global::Gibraltar.Monitor.Log.s_Initialized;
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0003EB70 File Offset: 0x0003CD70
		public static bool Initialize(global::Gibraltar.Monitor.AgentConfiguration configuration, bool suppressTraceInitialize)
		{
			if (global::Gibraltar.Monitor.Log.t_ThreadIsInitializer)
			{
				return false;
			}
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return true;
			}
			bool flag = false;
			object obj = global::Gibraltar.Monitor.Log.s_InitializingLock;
			lock (obj)
			{
				if (!global::Gibraltar.Monitor.Log.s_Initializing)
				{
					global::Gibraltar.Monitor.Log.s_Initializing = true;
					flag = true;
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_InitializingLock);
			}
			if (flag)
			{
				global::Gibraltar.Monitor.Log.t_ThreadIsInitializer = true;
				try
				{
					global::Gibraltar.Monitor.Log.s_Initialized = global::Gibraltar.Monitor.Log.OnInitialize(configuration, suppressTraceInitialize);
					goto IL_FF;
				}
				finally
				{
					global::Gibraltar.Monitor.Log.t_ThreadIsInitializer = false;
					global::Gibraltar.Monitor.Log.s_InitializationNeverAttempted = false;
					obj = global::Gibraltar.Monitor.Log.s_InitializingLock;
					lock (obj)
					{
						global::Gibraltar.Monitor.Log.s_Initializing = false;
						global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_InitializingLock);
					}
					global::Gibraltar.Server.Client.HubConnection.Logger = new global::Gibraltar.Server.Client.ClientLogger();
				}
			}
			if (!global::Gibraltar.Messaging.Publisher.QueryThreadMustNotBlock())
			{
				obj = global::Gibraltar.Monitor.Log.s_InitializingLock;
				lock (obj)
				{
					while (global::Gibraltar.Monitor.Log.s_Initializing)
					{
						global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Log.s_InitializingLock);
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_InitializingLock);
				}
			}
			IL_FF:
			return global::Gibraltar.Monitor.Log.s_Initialized;
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0003ECB8 File Offset: 0x0003CEB8
		public static global::Gibraltar.Monitor.AgentConfiguration Configuration
		{
			get
			{
				global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
				return global::Gibraltar.Monitor.Log.s_RunningConfiguration;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		public static global::Gibraltar.Monitor.SessionSummary SessionSummary
		{
			get
			{
				global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
				return global::Gibraltar.Monitor.Log.s_SessionStartInfo;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0003ECD0 File Offset: 0x0003CED0
		public static global::Gibraltar.Messaging.Notifier MessageAlertNotifier
		{
			get
			{
				if (global::Gibraltar.Monitor.Log.s_MessageAlertNotifier == null)
				{
					object obj = global::Gibraltar.Monitor.Log.s_NotifierLock;
					lock (obj)
					{
						if (global::Gibraltar.Monitor.Log.s_MessageAlertNotifier == null)
						{
							global::Gibraltar.Monitor.Log.s_MessageAlertNotifier = new global::Gibraltar.Messaging.Notifier(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Message Alert");
						}
					}
				}
				return global::Gibraltar.Monitor.Log.s_MessageAlertNotifier;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0003ED30 File Offset: 0x0003CF30
		public static global::Gibraltar.Monitor.UserResolutionNotifier UserResolutionNotifier
		{
			get
			{
				if (global::Gibraltar.Monitor.Log.s_UserResolutionNotifier == null)
				{
					object obj = global::Gibraltar.Monitor.Log.s_NotifierLock;
					lock (obj)
					{
						if (global::Gibraltar.Monitor.Log.s_UserResolutionNotifier == null)
						{
							global::Gibraltar.Monitor.Log.s_UserResolutionNotifier = new global::Gibraltar.Monitor.UserResolutionNotifier(global::Gibraltar.Monitor.Log.s_RunningConfiguration.Publisher.EnableAnonymousMode);
						}
					}
				}
				return global::Gibraltar.Monitor.Log.s_UserResolutionNotifier;
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0003ED98 File Offset: 0x0003CF98
		public static void ShowLiveViewer()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Listener.ShowViewerForm();
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0003EDAC File Offset: 0x0003CFAC
		public static void ClearLiveViewer()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Listener.ClearViewerForm();
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0003EDC0 File Offset: 0x0003CFC0
		public static global::Gibraltar.Monitor.LocalRepository Repository
		{
			get
			{
				return global::Gibraltar.Monitor.Log.s_Repository;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		public static bool AutoSendConsentGranted
		{
			get
			{
				if (!global::Gibraltar.Monitor.Log.s_Initialized)
				{
					return false;
				}
				if (!global::Gibraltar.Monitor.Log.Configuration.AutoSendConsent.Enabled)
				{
					return true;
				}
				bool result = false;
				object obj = global::Gibraltar.Monitor.Log.s_ConsentLock;
				lock (obj)
				{
					if (global::Gibraltar.Monitor.Log.s_AutoSendConsent == null)
					{
						try
						{
							string text;
							string application;
							global::Gibraltar.Monitor.Log.GetConsentScope(out text, out application);
							global::Gibraltar.Monitor.Log.s_AutoSendConsent = global::Gibraltar.Monitor.Log.Repository.GetAutoSendConsent(global::Gibraltar.Monitor.Log.SessionSummary.Product, application);
						}
						catch (global::System.Exception obj2)
						{
							global::System.GC.KeepAlive(obj2);
						}
					}
					if (global::Gibraltar.Monitor.Log.s_AutoSendConsent == null)
					{
						result = global::Gibraltar.Monitor.Log.Configuration.AutoSendConsent.ConsentDefault;
					}
					else
					{
						result = global::Gibraltar.Monitor.Log.s_AutoSendConsent.OptIn;
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_ConsentLock);
				}
				return result;
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0003EEA0 File Offset: 0x0003D0A0
		public static void ApplyConsent()
		{
			string product;
			string application;
			global::Gibraltar.Monitor.Log.GetConsentScope(out product, out application);
			global::Gibraltar.Data.AutoSendConsent autoSendConsent = global::Gibraltar.Monitor.Log.Repository.GetAutoSendConsent(product, application);
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Agent.Consent", "Applying current Auto-send Consent", "Current Consent Details:\r\n{0}", new object[]
				{
					autoSendConsent
				});
			}
			global::Gibraltar.Monitor.Log.ActionApplyConsent(autoSendConsent);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0003EEF8 File Offset: 0x0003D0F8
		public static void DisplayStartupConsentDialog()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Agent.Consent", "Display Startup Consent Dialog Requested", null, new object[0]);
			}
			if (global::Gibraltar.Monitor.Log.s_StartupConsentDisplayed)
			{
				return;
			}
			string product;
			string application;
			global::Gibraltar.Monitor.Log.GetConsentScope(out product, out application);
			global::Gibraltar.Data.AutoSendConsent autoSendConsent = global::Gibraltar.Monitor.Log.Repository.GetAutoSendConsent(global::Gibraltar.Monitor.Log.SessionSummary.Product, application);
			global::Gibraltar.Monitor.AutoSendConsentConfiguration autoSendConsent2 = global::Gibraltar.Monitor.Log.Configuration.AutoSendConsent;
			if (global::Gibraltar.Data.AutoSendConsent.IsNullOrNoSelection(autoSendConsent) && autoSendConsent2.PromptUserOnStartupLimit > 0 && (autoSendConsent == null || autoSendConsent.UserPrompts < autoSendConsent2.PromptUserOnStartupLimit || autoSendConsent.ApplicationVersion != global::Gibraltar.Monitor.Log.SessionSummary.ApplicationVersion))
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Agent.Consent", "User will be prompted to make a consent decision", "There is no consent decision on file and we are still allowed to prompt the user.\r\nConsent Detail: {0}\r\n", new object[]
					{
						autoSendConsent
					});
				}
				if (autoSendConsent == null)
				{
					autoSendConsent = global::Gibraltar.Monitor.Log.Repository.AddOrGetAutoSendConsent(product, application, global::Gibraltar.Monitor.Log.SessionSummary.ApplicationVersion);
				}
				else if (autoSendConsent.ApplicationVersion != global::Gibraltar.Monitor.Log.SessionSummary.ApplicationVersion)
				{
					autoSendConsent.UserPrompts = 0;
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Agent.Consent", "Resetting startup prompt count because application version has changed", "The user previously never made a decision under a different version so we'll start counting again.\r\nConsent Detail: {0}\r\n", new object[]
						{
							autoSendConsent
						});
					}
				}
				if (global::Gibraltar.Monitor.Log.ActionEditConsent(autoSendConsent) == global::System.Windows.Forms.DialogResult.Cancel)
				{
					autoSendConsent.UserPrompts++;
					autoSendConsent.SelectionMade = false;
					autoSendConsent.OptIn = false;
				}
				global::Gibraltar.Monitor.Log.Repository.SaveAutoSendConsent(autoSendConsent);
				autoSendConsent = global::Gibraltar.Monitor.Log.Repository.GetAutoSendConsent(product, application);
			}
			global::Gibraltar.Monitor.Log.ActionApplyConsent(autoSendConsent);
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Agent.Consent", "Best consent determined", "Consent Details:\r\n{0}", new object[]
				{
					autoSendConsent
				});
			}
			global::Gibraltar.Monitor.Log.s_StartupConsentDisplayed = true;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0003F0C0 File Offset: 0x0003D2C0
		public static void DisplayConsentDialog()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			string product;
			string application;
			global::Gibraltar.Monitor.Log.GetConsentScope(out product, out application);
			global::Gibraltar.Data.AutoSendConsent autoSendConsent = global::Gibraltar.Monitor.Log.Repository.AddOrGetAutoSendConsent(product, application, global::Gibraltar.Monitor.Log.SessionSummary.ApplicationVersion);
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Agent.Consent", "Display Consent Dialog Requested", "Current Consent Details:\r\n{0}", new object[]
				{
					autoSendConsent
				});
			}
			if (global::Gibraltar.Monitor.Log.ActionEditConsent(autoSendConsent) == global::System.Windows.Forms.DialogResult.OK)
			{
				global::Gibraltar.Monitor.Log.Repository.SaveAutoSendConsent(autoSendConsent);
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Agent.Consent", "User updated consent", "New Consent Details:\r\n{0}", new object[]
					{
						autoSendConsent
					});
				}
			}
			autoSendConsent = global::Gibraltar.Monitor.Log.Repository.GetAutoSendConsent(product, application);
			global::Gibraltar.Monitor.Log.ActionApplyConsent(autoSendConsent);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0003F17C File Offset: 0x0003D37C
		public static bool CanSendSessions(ref string message)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				message = "Gibraltar is not currently enabled";
				return false;
			}
			if (message == null)
			{
				message = string.Empty;
			}
			bool result = false;
			global::Gibraltar.Monitor.PackagerConfiguration packager = global::Gibraltar.Monitor.Log.s_RunningConfiguration.Packager;
			if (!packager.AllowServer && !packager.AllowEmail)
			{
				message = "Neither email or server packaging is allowed with the current packager configuration";
			}
			else if (packager.AllowEmail && global::Gibraltar.Monitor.Log.IsEmailSubmissionConfigured(ref message))
			{
				result = true;
			}
			else if (packager.AllowServer && global::Gibraltar.Monitor.Log.IsHubSubmissionConfigured(ref message))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0003F218 File Offset: 0x0003D418
		public static bool CanSendSessionsOnExit(ref string message)
		{
			bool flag = global::Gibraltar.Monitor.Log.CanSendSessions(ref message);
			if (flag)
			{
				flag = global::Gibraltar.Monitor.Log.CanFindPackager(ref message);
			}
			return flag;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0003F240 File Offset: 0x0003D440
		public static bool IsEmailSubmissionConfigured(ref string message)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				message = "Gibraltar is not currently enabled";
				return false;
			}
			bool result = true;
			if (message == null)
			{
				message = string.Empty;
			}
			if (string.IsNullOrEmpty(global::Gibraltar.Monitor.Log.s_RunningConfiguration.Packager.DestinationEmailAddress))
			{
				message += "No destination email address was provided for the packager.\r\n";
				result = false;
			}
			return result;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		public static bool IsHubSubmissionConfigured(ref string message)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				message = "Gibraltar is not currently enabled";
				return false;
			}
			bool result = true;
			if (message == null)
			{
				message = string.Empty;
			}
			global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server;
			if (!server.Enabled)
			{
				message += "Server configuration is missing or disabled.\r\n";
				result = false;
			}
			else if (server.UseGibraltarService)
			{
				if (string.IsNullOrEmpty(server.CustomerName))
				{
					message += "No customer name was provided for the Loupe Service.\r\n";
					result = false;
				}
			}
			else if (string.IsNullOrEmpty(server.Server))
			{
				message += "No server name was provided for the server.\r\n";
				result = false;
			}
			else if (server.Port < 0)
			{
				message += "An invalid server port was configured.\r\n";
				result = false;
			}
			return result;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0003F374 File Offset: 0x0003D574
		public static bool CanFindPackager(ref string message)
		{
			if (message == null)
			{
				message = string.Empty;
			}
			bool flag = global::System.IO.File.Exists(global::Gibraltar.Monitor.Log.GetPackagerFileNamePath());
			if (!flag)
			{
				message += "The packager utility could not be found in the same directory as the application.\r\n";
			}
			return flag;
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0003F3A4 File Offset: 0x0003D5A4
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0003F3EC File Offset: 0x0003D5EC
		public static bool SendSessionsOnExit
		{
			get
			{
				object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
				bool result;
				lock (obj)
				{
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
					result = global::Gibraltar.Monitor.Log.s_SendSessionsOnExit;
				}
				return result;
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			set
			{
				global::Gibraltar.Monitor.Log.SetSendSessionsOnExit(value);
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
		public static bool ExplicitStartSessionCalled
		{
			get
			{
				return global::Gibraltar.Monitor.Log.s_ExplicitStartSessionCalled;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0003F400 File Offset: 0x0003D600
		public static global::Gibraltar.Monitor.MetricDefinitionCollection Metrics
		{
			get
			{
				return global::Gibraltar.Monitor.Log.s_Metrics;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0003F408 File Offset: 0x0003D608
		public static bool IsSessionEnding
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.IsSessionEnding;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0003F410 File Offset: 0x0003D610
		public static bool IsSessionEnded
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.IsSessionEnded;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0003F418 File Offset: 0x0003D618
		public static void Write(global::System.Collections.Generic.List<global::Gibraltar.Monitor.MetricSample> samples)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (samples == null || samples.Count == 0)
			{
				return;
			}
			global::Gibraltar.Messaging.IMessengerPacket[] array = new global::Gibraltar.Messaging.IMessengerPacket[samples.Count];
			int num = 0;
			foreach (global::Gibraltar.Monitor.MetricSample metricSample in samples)
			{
				array[num] = metricSample.Packet;
				num++;
			}
			global::Gibraltar.Monitor.Log.s_Publisher.Publish(array, false);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
		public static void Write(global::Gibraltar.Monitor.MetricSample sample)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (sample == null)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.s_Publisher.Publish(new global::Gibraltar.Monitor.Internal.MetricSamplePacket[]
			{
				sample.Packet
			}, false);
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0003F4E8 File Offset: 0x0003D6E8
		public static global::System.Version AgentVersion
		{
			get
			{
				global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
				return global::Gibraltar.Monitor.Log.s_SessionStartInfo.AgentVersion;
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0003F4FC File Offset: 0x0003D6FC
		public static void RegisterUIThread()
		{
			global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
			global::Loupe.Extensibility.Data.ApplicationType agentAppType = global::Gibraltar.Monitor.Log.s_SessionStartInfo.AgentAppType;
			if (agentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows)
			{
				global::Gibraltar.Monitor.Listener.InitializeThreadListening(agentAppType, true);
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0003F52C File Offset: 0x0003D72C
		public static void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, "Gibraltar", category, 1, null, caption, description, args).PublishToLog();
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0003F564 File Offset: 0x0003D764
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, global::System.Exception exception, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, writeMode, "Gibraltar", category, 1, exception, false, null, caption, description, args).PublishToLog();
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, global::System.Exception exception, int skipFrames, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, writeMode, "Gibraltar", category, skipFrames + 1, exception, false, null, caption, description, args).PublishToLog();
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, global::System.Exception exception, bool attributeToException, string category, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, writeMode, "Gibraltar", category, 1, exception, attributeToException, null, caption, description, args).PublishToLog();
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0003F61C File Offset: 0x0003D81C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, int skipFrames, global::System.Exception exception, string detailsXml, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, writeMode, "Gibraltar", "Trace", skipFrames + 1, exception, false, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0003F668 File Offset: 0x0003D868
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, int skipFrames, global::System.Exception exception, bool attributeToException, string detailsXml, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(severity, writeMode, "Gibraltar", "Trace", skipFrames + 1, exception, attributeToException, detailsXml, caption, description, args).PublishToLog();
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0003F6B4 File Offset: 0x0003D8B4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void Trace(string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Gibraltar", "Trace", 1, null, null, format, args).PublishToLog();
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void Trace(global::System.Exception exception, string format, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			new global::Gibraltar.Monitor.LocalLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", 1, exception, false, null, null, format, args).PublishToLog();
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0003F72C File Offset: 0x0003D92C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void RecordException(int skipFrames, global::System.Exception exception, string detailsXml, string category, bool canContinue)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			global::Gibraltar.Monitor.Log.RecordException(new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, true), exception, detailsXml, category, canContinue, false, false);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0003F75C File Offset: 0x0003D95C
		public static void RecordException(global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, global::System.Exception exception, string detailsXml, string category, bool canContinue)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.RecordException(sourceProvider, exception, detailsXml, category, canContinue, false, false);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0003F778 File Offset: 0x0003D978
		private static void RecordException(global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, global::System.Exception exception, string detailsXml, string category, bool canContinue, bool reporting, bool blocking)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (exception == null)
			{
				return;
			}
			global::Loupe.Extensibility.Data.LogMessageSeverity severity = canContinue ? global::Loupe.Extensibility.Data.LogMessageSeverity.Error : global::Loupe.Extensibility.Data.LogMessageSeverity.Critical;
			global::Gibraltar.ExceptionSourceProvider exceptionSourceProvider = new global::Gibraltar.ExceptionSourceProvider(exception);
			string text = string.Empty;
			global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider2;
			string text2;
			if (exceptionSourceProvider.ClassName == null)
			{
				sourceProvider2 = sourceProvider;
				text2 = string.Empty;
			}
			else
			{
				sourceProvider2 = exceptionSourceProvider;
				text2 = string.Format("Reported by: {0}.{1}\r\n", sourceProvider.ClassName, sourceProvider.MethodName);
				if (sourceProvider.FileName != null)
				{
					text = string.Format("Location: Line {0} of file '{1}'\r\n", sourceProvider.LineNumber, sourceProvider.FileName);
				}
			}
			if (string.IsNullOrEmpty(category))
			{
				category = "System.Exception";
			}
			string text3 = (exception.Message ?? string.Empty).Trim();
			if (string.IsNullOrEmpty(text3))
			{
				text3 = exception.GetType().Name;
			}
			string text4 = canContinue ? "\r\nThis non-fatal error {0} be reported to the user{1}, then execution may continue.\r\n" : "\r\nThis fatal error {0} be reported to the user{1}, then the application will exit.\r\n";
			text4 = string.Format(text4, reporting ? "will" : "will not", reporting ? (blocking ? " and wait for their response" : " without waiting on their response") : string.Empty);
			global::Gibraltar.Monitor.Log.WriteMessage(severity, global::Gibraltar.Monitor.LogWriteMode.WaitForCommit, "Gibraltar", category, sourceProvider2, null, exception, detailsXml, null, "{0}\r\nException type: {1}\r\n{2}{3}{4}", new object[]
			{
				text3,
				exception.GetType().FullName,
				text2,
				text,
				text4
			});
			if (!canContinue)
			{
				global::Gibraltar.Monitor.Log.SessionSummary.Status = global::Loupe.Extensibility.Data.SessionStatus.Crashed;
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0003F900 File Offset: 0x0003DB00
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static global::System.Windows.Forms.DialogResult ReportException(int skipFrames, global::System.Exception exception, string detailsXml, string category, bool canContinue, bool waitForResponse)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return global::System.Windows.Forms.DialogResult.None;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			return global::Gibraltar.Monitor.Log.ReportException(new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, true), exception, detailsXml, category, canContinue, waitForResponse);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0003F930 File Offset: 0x0003DB30
		public static global::System.Windows.Forms.DialogResult ReportException(global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, global::System.Exception exception, string detailsXml, string category, bool canContinue, bool waitForResponse)
		{
			global::System.Windows.Forms.DialogResult result = global::System.Windows.Forms.DialogResult.None;
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return result;
			}
			if (exception == null)
			{
				return result;
			}
			bool flag = global::Gibraltar.Monitor.Log.s_SessionStartInfo.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows;
			if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
			{
				global::Gibraltar.Monitor.Log.RecordException(sourceProvider, exception, detailsXml, category, canContinue, false, false);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar.Agent.Error Manager", "Gibraltar Error Manager is not supported on Mono", "The Gibraltar Error Manager is designed to run in a separate UI thread, but the Mono runtime does not support multiple UI threads as of version 2.6, so the GEM is disabled when running under Mono with this version of the Agent.\r\n", new object[0]);
			}
			else
			{
				global::Gibraltar.Monitor.Log.RecordException(sourceProvider, exception, detailsXml, category, canContinue, flag, waitForResponse);
			}
			if (flag)
			{
				global::Gibraltar.Monitor.ExceptionDisplayRequest exceptionDisplayRequest = new global::Gibraltar.Monitor.ExceptionDisplayRequest(exception, waitForResponse, canContinue);
				global::Gibraltar.Monitor.Listener.ShowAlertDialog(exceptionDisplayRequest);
				if (waitForResponse)
				{
					result = exceptionDisplayRequest.WaitForResult();
				}
			}
			return result;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
		public static void WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, string userName, global::System.Exception exception, string detailsXml, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Messaging.IMessengerPacket messengerPacket = global::Gibraltar.Monitor.Log.MakeLogPacket(severity, logSystem, categoryName, sourceProvider, userName, exception, detailsXml, caption, description, args);
			global::Gibraltar.Monitor.Log.Write(new global::Gibraltar.Messaging.IMessengerPacket[]
			{
				messengerPacket
			}, writeMode);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0003FA1C File Offset: 0x0003DC1C
		public static string CalculateWebUrl(string pageFileName)
		{
			global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
			global::Gibraltar.Monitor.SessionSummary sessionSummary = global::Gibraltar.Monitor.Log.SessionSummary;
			return global::Gibraltar.CommonCentralLogic.CalculateWebUrl(pageFileName, sessionSummary.Product, sessionSummary.Application, sessionSummary.ApplicationVersion);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0003FA50 File Offset: 0x0003DC50
		public static void DisplayWebPage(string pageFileName)
		{
			global::Gibraltar.Monitor.Log.EnsureSummaryIsAvailable();
			global::Gibraltar.Monitor.SessionSummary sessionSummary = global::Gibraltar.Monitor.Log.SessionSummary;
			global::Gibraltar.CommonCentralLogic.DisplayWebPage(pageFileName, sessionSummary.Product, sessionSummary.Application, sessionSummary.ApplicationVersion);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0003FA84 File Offset: 0x0003DC84
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndFile()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.EndFile(1, string.Empty);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0003FAA0 File Offset: 0x0003DCA0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndFile(string reason)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.EndFile(1, reason);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0003FAB8 File Offset: 0x0003DCB8
		public static void EndFile(int skipFrames, string reason)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (skipFrames < 0)
			{
				skipFrames = 0;
			}
			global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider = new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, true);
			string arg;
			string arg2;
			if (string.IsNullOrEmpty(reason))
			{
				arg = ".";
				arg2 = string.Empty;
			}
			else
			{
				arg = ": ";
				arg2 = reason;
			}
			global::Gibraltar.Messaging.IMessengerPacket messengerPacket = global::Gibraltar.Monitor.Log.MakeLogPacket(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar", "Trace", sourceProvider, string.Empty, null, null, string.Format("Current log file ending by request{0}{1}", arg, arg2), null, new object[0]);
			global::Gibraltar.Messaging.IMessengerPacket messengerPacket2 = new global::Gibraltar.Messaging.CommandPacket(global::Gibraltar.Messaging.MessagingCommand.CloseFile);
			global::Gibraltar.Messaging.IMessengerPacket messengerPacket3 = global::Gibraltar.Monitor.Log.MakeLogPacket(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar", "Trace", sourceProvider, string.Empty, null, null, string.Format("New log file opened by request{0}{1}", arg, arg2), null, new object[0]);
			global::Gibraltar.Monitor.Log.Write(new global::Gibraltar.Messaging.IMessengerPacket[]
			{
				messengerPacket,
				messengerPacket2,
				messengerPacket3
			}, global::Gibraltar.Monitor.LogWriteMode.WaitForCommit);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0003FB8C File Offset: 0x0003DD8C
		public static void EndSession(global::Loupe.Extensibility.Data.SessionStatus endingStatus, global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, string reason)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			if (endingStatus < global::Loupe.Extensibility.Data.SessionStatus.Normal || global::Gibraltar.Monitor.Log.s_Publisher == null)
			{
				return;
			}
			global::Gibraltar.Messaging.IMessengerPacket messengerPacket = null;
			object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
			lock (obj)
			{
				if (!global::Gibraltar.Monitor.Log.IsSessionEnding)
				{
					if (global::Gibraltar.Monitor.Log.s_SendSessionsOnExit)
					{
						global::Gibraltar.Monitor.Log.SendSessionData();
					}
					global::Gibraltar.Monitor.Log.ShutdownPublishEngine();
				}
				global::Gibraltar.CommonCentralLogic.DeclareSessionIsEnding();
				global::Loupe.Extensibility.Data.SessionStatus status = global::Gibraltar.Monitor.Log.SessionSummary.Status;
				if (endingStatus > status)
				{
					global::Gibraltar.Monitor.Log.SessionSummary.Status = endingStatus;
					bool flag = endingStatus == global::Loupe.Extensibility.Data.SessionStatus.Normal;
					string arg;
					string arg2;
					if (string.IsNullOrEmpty(reason))
					{
						arg = ".";
						arg2 = string.Empty;
					}
					else
					{
						arg = ": ";
						arg2 = reason;
					}
					string arg3;
					string description;
					if (flag)
					{
						arg3 = "normally";
						description = "Session state changed from {0} to {1}.\r\nAny further EndSession calls will not be reported unless declaring the session crashed.";
					}
					else
					{
						arg3 = "as crashed";
						description = "Session state changed from {0} to {1}.\r\nAny further EndSession calls will not be reported since sessions declared crashed can not be set back to normal.";
					}
					messengerPacket = global::Gibraltar.Monitor.Log.MakeLogPacket(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Gibraltar", "Trace", sourceProvider, null, null, null, string.Format("Session ending {0}{1}{2}", arg3, arg, arg2), description, new object[]
					{
						status,
						endingStatus
					});
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
			}
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.IMessengerPacket> list = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.IMessengerPacket>();
			list.Add(new global::Gibraltar.Monitor.Internal.SessionClosePacket(global::Gibraltar.Monitor.Log.SessionSummary.Status));
			if (messengerPacket != null)
			{
				list.Add(messengerPacket);
			}
			list.Add(new global::Gibraltar.Messaging.CommandPacket(global::Gibraltar.Messaging.MessagingCommand.ExitMode, global::Gibraltar.Monitor.Log.SessionSummary.Status));
			global::Gibraltar.Monitor.Log.Write(list.ToArray(), global::Gibraltar.Monitor.LogWriteMode.WaitForCommit);
			global::Gibraltar.CommonCentralLogic.DeclareSessionHasEnded();
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0003FD14 File Offset: 0x0003DF14
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void EndSession(global::Loupe.Extensibility.Data.SessionStatus endingStatus, int skipFrames, string reason)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.EndSession(endingStatus, new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, true), reason);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0003FD34 File Offset: 0x0003DF34
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static void StartSession(global::Gibraltar.Monitor.AgentConfiguration configuration, int skipFrames, string reason)
		{
			global::Gibraltar.Monitor.Log.s_ExplicitStartSessionCalled = true;
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.StartSession(configuration, new global::Gibraltar.Monitor.MessageSourceProvider(skipFrames + 1, true), reason);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		public static void StartSession(global::Gibraltar.Monitor.AgentConfiguration configuration, global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, string reason)
		{
			global::Gibraltar.Monitor.Log.s_ExplicitStartSessionCalled = true;
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.Initialize(configuration, false);
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				if (string.IsNullOrEmpty(reason))
				{
					reason = "Session started";
				}
				global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, "Gibraltar", "Trace", sourceProvider, null, null, null, reason, null, new object[0]);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
		public static bool SendSessions(global::Gibraltar.Data.SessionCriteria? criteria, global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> sessionMatchPredicate, bool asyncSend)
		{
			if (criteria == null && sessionMatchPredicate == null)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Send session command ignored due to no criteria specified", "A session match predicate wasn't provided so nothing would be selected to send, skipping the send.", new object[0]);
				return false;
			}
			bool result = false;
			global::Gibraltar.Data.Packager packager = null;
			object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
			lock (obj)
			{
				if (global::Gibraltar.Monitor.Log.s_ActivePackager == null)
				{
					packager = new global::Gibraltar.Data.Packager();
					global::Gibraltar.Monitor.Log.s_ActivePackager = packager;
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
			}
			if (packager == null)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Send session command ignored due to ongoing send", "There is already a packager session send going on for the current application so this second request will be ignored to prevent interference.", new object[0]);
			}
			else
			{
				try
				{
					string text = null;
					if (global::Gibraltar.Monitor.Log.IsHubSubmissionConfigured(ref text) && global::Gibraltar.Data.Packager.CanSendToServer(out text))
					{
						global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server;
						packager.EndSend += global::Gibraltar.Monitor.Log.Packager_EndSend;
						if (criteria != null)
						{
							packager.SendToServer(criteria.Value, true, server.PurgeSentSessions, false, false, null, null, 0, false, null, null, asyncSend);
						}
						else
						{
							packager.SendToServer(sessionMatchPredicate, true, server.PurgeSentSessions, false, false, null, null, 0, false, null, null, asyncSend);
						}
						result = true;
					}
					else if (global::Gibraltar.Monitor.Log.IsEmailSubmissionConfigured(ref text))
					{
						packager.EndSend += global::Gibraltar.Monitor.Log.Packager_EndSend;
						if (criteria != null)
						{
							packager.SendEmail(criteria.Value, true, null, null, null, null, 0, null, null, null, asyncSend);
						}
						else
						{
							packager.SendEmail(sessionMatchPredicate, true, null, null, null, null, 0, null, null, null, asyncSend);
						}
						result = true;
					}
					else
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Packager", "Send session command ignored due to configuration", "Either the current configuration doesn't support server or email submission or the server is not available.", new object[0]);
						obj = global::Gibraltar.Monitor.Log.s_SyncObject;
						lock (obj)
						{
							packager.Dispose();
							global::Gibraltar.Monitor.Log.s_ActivePackager = null;
							global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
						}
					}
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00040000 File Offset: 0x0003E200
		public static void SetSendSessionsOnExit(bool value)
		{
			bool flag = false;
			bool flag2 = false;
			string empty = string.Empty;
			object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
			lock (obj)
			{
				if (value != global::Gibraltar.Monitor.Log.s_SendSessionsOnExit)
				{
					if (!value)
					{
						if (!global::Gibraltar.Monitor.Log.IsSessionEnding)
						{
							flag = true;
							global::Gibraltar.Monitor.Log.s_SendSessionsOnExit = false;
						}
					}
					else if (global::Gibraltar.Monitor.Log.CanSendSessionsOnExit(ref empty))
					{
						flag = true;
						global::Gibraltar.Monitor.Log.s_SendSessionsOnExit = true;
						if (global::Gibraltar.Monitor.Log.IsSessionEnding)
						{
							global::Gibraltar.Monitor.Log.SendSessionData();
						}
					}
					else
					{
						flag2 = true;
					}
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
			}
			if (flag)
			{
				string caption = value ? "Session Data will be sent on exit" : "Session Data will not be sent on exit";
				string description = value ? "Session data will be submitted after the session exits." : "Session data will no longer be submitted after the session exits because the option was cleared.";
				global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, caption, description, new object[0]);
			}
			if (flag2)
			{
				global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, "Unable to Send Session Data on Exit", "A request was made to send session data after the session exits, but the current configuration can't support it.\r\n{0}", new object[]
				{
					empty
				});
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00040108 File Offset: 0x0003E308
		internal static void Write(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			if (global::Gibraltar.Monitor.Log.s_Publisher == null)
			{
				return;
			}
			global::Gibraltar.Monitor.Log.Write(new global::Gibraltar.Messaging.IMessengerPacket[]
			{
				packet
			}, global::Gibraltar.Monitor.LogWriteMode.Queued);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00040128 File Offset: 0x0003E328
		internal static void Write(global::Gibraltar.Messaging.IMessengerPacket[] packetArray, global::Gibraltar.Monitor.LogWriteMode writeMode)
		{
			if (global::Gibraltar.Monitor.Log.s_Publisher == null)
			{
				return;
			}
			if (packetArray == null || packetArray.Length == 0)
			{
				return;
			}
			for (int i = 0; i < packetArray.Length; i++)
			{
				global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = packetArray[i] as global::Gibraltar.Monitor.Internal.LogMessagePacket;
				if (logMessagePacket != null)
				{
					global::Gibraltar.Monitor.Log.s_SessionStartInfo.UpdateMessageStatistics(logMessagePacket);
				}
			}
			if (writeMode == global::Gibraltar.Monitor.LogWriteMode.WaitForCommit)
			{
				global::Gibraltar.Monitor.Log.s_Publisher.Publish(packetArray, true);
				return;
			}
			global::Gibraltar.Monitor.Log.s_Publisher.Publish(packetArray, false);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000401A4 File Offset: 0x0003E3A4
		internal static global::Gibraltar.Messaging.IMessengerPacket MakeLogPacket(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string category, global::Gibraltar.Monitor.IMessageSourceProvider sourceProvider, string userName, global::System.Exception exception, string detailsXml, string caption, string description, params object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return null;
			}
			global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = new global::Gibraltar.Monitor.Internal.LogMessagePacket();
			global::Gibraltar.Monitor.ThreadInfo currentThreadInfo = global::Gibraltar.Monitor.Log.GetCurrentThreadInfo();
			logMessagePacket.ThreadInfoPacket = currentThreadInfo.Packet;
			logMessagePacket.ThreadIndex = currentThreadInfo.ThreadIndex;
			logMessagePacket.ThreadId = currentThreadInfo.ThreadId;
			if (string.IsNullOrEmpty(logSystem))
			{
				logSystem = "Unknown";
			}
			if (string.IsNullOrEmpty(category))
			{
				category = "General";
			}
			if (global::Gibraltar.Monitor.Log.s_RunningConfiguration.Publisher.EnableAnonymousMode)
			{
				userName = string.Empty;
			}
			else
			{
				global::System.Security.Principal.IPrincipal principal = global::System.Threading.Thread.CurrentPrincipal;
				if (string.IsNullOrEmpty(userName))
				{
					try
					{
						global::System.Security.Principal.IIdentity identity = (principal != null) ? principal.Identity : null;
						if (identity != null)
						{
							userName = identity.Name;
						}
						else
						{
							global::System.Security.Principal.WindowsIdentity windowsIdentity;
							try
							{
								windowsIdentity = global::System.Security.Principal.WindowsIdentity.GetCurrent(true);
							}
							catch
							{
								windowsIdentity = null;
							}
							if (windowsIdentity != null)
							{
								userName = windowsIdentity.Name;
							}
						}
					}
					catch (global::System.Security.SecurityException)
					{
						userName = null;
					}
				}
				if (string.IsNullOrEmpty(userName))
				{
					userName = global::Gibraltar.Monitor.Log.s_SessionStartInfo.FullyQualifiedUserName;
				}
				if (principal != null && principal.Identity != null)
				{
					principal = (string.Equals(userName, principal.Identity.Name, global::System.StringComparison.OrdinalIgnoreCase) ? principal : null);
				}
				logMessagePacket.UserPrincipal = principal;
			}
			string description2;
			if (args == null || args.Length == 0)
			{
				description2 = (description ?? string.Empty);
			}
			else
			{
				description2 = global::Gibraltar.ErrorNotifier.SafeFormat(global::System.Globalization.CultureInfo.CurrentCulture, description, args);
			}
			global::Gibraltar.Monitor.Log.NormalizeCaptionDescription(ref caption, ref description2);
			logMessagePacket.Severity = severity;
			logMessagePacket.LogSystem = logSystem;
			logMessagePacket.CategoryName = category;
			logMessagePacket.UserName = userName;
			logMessagePacket.Caption = caption;
			logMessagePacket.Description = description2;
			logMessagePacket.Details = detailsXml;
			logMessagePacket.SetException(exception);
			logMessagePacket.SetSourceInfo(sourceProvider);
			return logMessagePacket;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00040390 File Offset: 0x0003E590
		private static global::Gibraltar.Monitor.ThreadInfo GetCurrentThreadInfo()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return null;
			}
			if (global::Gibraltar.Monitor.Log.t_CurrentThreadInfo == null)
			{
				global::Gibraltar.Monitor.Log.t_CurrentThreadInfo = new global::Gibraltar.Monitor.ThreadInfo();
				if (!global::Gibraltar.Monitor.Log.IsSessionEnding && global::Gibraltar.Monitor.Log.s_SessionStartInfo.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows && global::System.Threading.Thread.CurrentThread.GetApartmentState() == global::System.Threading.ApartmentState.STA)
				{
					global::Gibraltar.Monitor.Listener.InitializeThreadListening(global::Gibraltar.Monitor.Log.s_SessionStartInfo.AgentAppType, false);
				}
			}
			return global::Gibraltar.Monitor.Log.t_CurrentThreadInfo;
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00040408 File Offset: 0x0003E608
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x00040410 File Offset: 0x0003E610
		internal static bool ThreadIsInitializer
		{
			get
			{
				return global::Gibraltar.Monitor.Log.t_ThreadIsInitializer;
			}
			set
			{
				global::Gibraltar.Monitor.Log.t_ThreadIsInitializer = value;
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00040418 File Offset: 0x0003E618
		private static global::System.Windows.Forms.DialogResult ActionEditConsent(global::Gibraltar.Data.AutoSendConsent consent)
		{
			global::System.Windows.Forms.DialogResult result = global::System.Windows.Forms.DialogResult.Cancel;
			global::Gibraltar.Monitor.AutoSendConsentConfiguration autoSendConsent = global::Gibraltar.Monitor.Log.Configuration.AutoSendConsent;
			if (autoSendConsent.Enabled && !string.IsNullOrEmpty(autoSendConsent.CompanyName) && !string.IsNullOrEmpty(autoSendConsent.ServiceName))
			{
				using (global::Gibraltar.Monitor.Windows.AutoSendConsentDialog autoSendConsentDialog = new global::Gibraltar.Monitor.Windows.AutoSendConsentDialog())
				{
					result = autoSendConsentDialog.UpdateConsent(consent, autoSendConsent.PrivacyPolicyUrl, autoSendConsent.ServiceName, autoSendConsent.CompanyName);
				}
			}
			return result;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000404A0 File Offset: 0x0003E6A0
		private static void ActionApplyConsent(global::Gibraltar.Data.AutoSendConsent newConstent)
		{
			if (newConstent == null)
			{
				return;
			}
			object obj = global::Gibraltar.Monitor.Log.s_ConsentLock;
			lock (obj)
			{
				global::Gibraltar.Monitor.Log.s_AutoSendConsent = newConstent;
				if (newConstent.OptIn)
				{
					global::Gibraltar.Monitor.Log.StartPublishEngine();
				}
				else
				{
					global::Gibraltar.Monitor.Log.ShutdownPublishEngine();
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_ConsentLock);
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00040508 File Offset: 0x0003E708
		private static string GetPackagerFileNamePath()
		{
			string text = global::System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
			if (text.StartsWith("file:", global::System.StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(5);
				text = text.TrimStart(new char[]
				{
					'\\',
					'/'
				});
			}
			text = global::System.IO.Path.GetDirectoryName(text);
			string path;
			if (global::Gibraltar.Monitor.Log.SessionSummary.RuntimeVersion.Major >= 4)
			{
				path = "Gibraltar.Packager.NET40.exe";
			}
			else
			{
				path = "Gibraltar.Packager.exe";
			}
			return global::System.IO.Path.Combine(text, path);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00040588 File Offset: 0x0003E788
		private static void SendSessionData()
		{
			try
			{
				string packagerFileNamePath = global::Gibraltar.Monitor.Log.GetPackagerFileNamePath();
				global::System.Diagnostics.ProcessStartInfo processStartInfo = new global::System.Diagnostics.ProcessStartInfo(packagerFileNamePath);
				processStartInfo.CreateNoWindow = true;
				processStartInfo.ErrorDialog = false;
				processStartInfo.UseShellExecute = false;
				processStartInfo.WorkingDirectory = global::System.IO.Path.GetDirectoryName(packagerFileNamePath);
				int id = global::System.Diagnostics.Process.GetCurrentProcess().Id;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(2048);
				string empty = string.Empty;
				if (global::Gibraltar.Monitor.Log.IsHubSubmissionConfigured(ref empty) && global::Gibraltar.Data.Packager.CanSendToServer(out empty))
				{
					stringBuilder.AppendFormat("/s /w \"{0}\" /m server /p \"{1}\" /a \"{2}\" ", id, global::Gibraltar.Monitor.Log.s_SessionStartInfo.Product, global::Gibraltar.Monitor.Log.s_SessionStartInfo.Application);
					global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server;
					if (server.UseGibraltarService)
					{
						stringBuilder.AppendFormat("/customer \"{0}\" ", server.CustomerName);
					}
					else
					{
						stringBuilder.AppendFormat("/server \"{0}\" ", server.Server);
						if (server.UseSsl)
						{
							stringBuilder.Append("/ssl \"true\" ");
						}
						if (server.Port != 0)
						{
							stringBuilder.AppendFormat("/port \"{0}\" ", server.Port);
						}
						if (!string.IsNullOrEmpty(server.ApplicationBaseDirectory))
						{
							stringBuilder.AppendFormat("/directory \"{0}\" ", server.ApplicationBaseDirectory);
						}
						if (!string.IsNullOrEmpty(server.Repository))
						{
							stringBuilder.AppendFormat("/repository \"{0}\" ", server.Repository);
						}
					}
					if (server.PurgeSentSessions)
					{
						stringBuilder.AppendFormat("/purgeSentSessions \"true\" ", new object[0]);
					}
				}
				else
				{
					stringBuilder.AppendFormat("/s /w \"{0}\" /m email /p \"{1}\" /a \"{2}\" /d \"{3}\" ", new object[]
					{
						id,
						global::Gibraltar.Monitor.Log.s_SessionStartInfo.Product,
						global::Gibraltar.Monitor.Log.s_SessionStartInfo.Application,
						global::Gibraltar.Monitor.Log.s_RunningConfiguration.Packager.DestinationEmailAddress
					});
					if (!string.IsNullOrEmpty(global::Gibraltar.Monitor.Log.s_RunningConfiguration.Packager.FromEmailAddress))
					{
						stringBuilder.AppendFormat(" /f \"{0}\" ", global::Gibraltar.Monitor.Log.s_RunningConfiguration.Packager.FromEmailAddress);
					}
					global::Gibraltar.Monitor.EmailConfiguration email = global::Gibraltar.Monitor.Log.s_RunningConfiguration.Email;
					if (!string.IsNullOrEmpty(email.Server))
					{
						stringBuilder.AppendFormat("/server \"{0}\" ", email.Server);
						if (!string.IsNullOrEmpty(email.User))
						{
							stringBuilder.AppendFormat("/user \"{0}\" /password \"{1}\" ", email.User, email.Password);
						}
						if (email.UseSsl)
						{
							stringBuilder.Append("/ssl \"true\" ");
						}
						if (email.Port != 0)
						{
							stringBuilder.AppendFormat("/port \"{0}\" ", email.Port);
						}
					}
				}
				if (!string.IsNullOrEmpty(global::Gibraltar.Monitor.Log.s_RunningConfiguration.SessionFile.Folder))
				{
					stringBuilder.AppendFormat("/folder \"{0}\" ", global::Gibraltar.Monitor.Log.s_RunningConfiguration.SessionFile.Folder);
				}
				processStartInfo.Arguments = stringBuilder.ToString();
				global::System.Diagnostics.Process.Start(processStartInfo);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0004088C File Offset: 0x0003EA8C
		private static void NormalizeCaptionDescription(ref string caption, ref string description)
		{
			if (description == null)
			{
				description = string.Empty;
			}
			if (description.Length > 0)
			{
				char c = description[description.Length - 1];
				if (c != '\n' && c != '\r')
				{
					description += "\r\n";
				}
			}
			string[] array = description.Split(global::Gibraltar.Monitor.Log.LineBreakTokens, global::System.StringSplitOptions.None);
			int num = array.Length;
			if (caption == null)
			{
				caption = ((num > 0) ? array[0].TrimEnd(new char[0]) : string.Empty);
				description = ((num > 1) ? string.Join("\r\n", array, 1, num - 1) : string.Empty);
				return;
			}
			caption = caption.TrimEnd(new char[0]);
			description = string.Join("\r\n", array);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00040964 File Offset: 0x0003EB64
		private static bool OnInitialize(global::Gibraltar.Monitor.AgentConfiguration configuration, bool suppressTraceInitialize)
		{
			if (global::Gibraltar.Monitor.Log.s_Initialized)
			{
				return true;
			}
			bool flag = false;
			global::Gibraltar.Monitor.Log.InitializingEventHandler initializing = global::Gibraltar.Monitor.Log.Initializing;
			global::Gibraltar.Monitor.AgentConfiguration agentConfiguration = configuration ?? new global::Gibraltar.Monitor.AgentConfiguration();
			if (initializing != null)
			{
				global::Gibraltar.Monitor.LogInitializingEventArgs logInitializingEventArgs = new global::Gibraltar.Monitor.LogInitializingEventArgs(agentConfiguration);
				try
				{
					initializing(null, logInitializingEventArgs);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					logInitializingEventArgs.Cancel = true;
				}
				flag = logInitializingEventArgs.Cancel;
			}
			if (flag)
			{
				return false;
			}
			try
			{
				agentConfiguration.Sanitize();
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
			}
			global::Gibraltar.Monitor.Log.s_RunningConfiguration = agentConfiguration;
			if (global::Gibraltar.Monitor.Log.s_RunningConfiguration.Publisher.EnableDebugMode)
			{
				global::Gibraltar.Monitor.Log.SilentMode = false;
			}
			global::Gibraltar.Monitor.Log.s_SessionStartInfo = new global::Gibraltar.Monitor.SessionSummary(global::Gibraltar.Monitor.Log.s_RunningConfiguration);
			if (global::Gibraltar.Monitor.Log.s_RunningConfiguration.SessionFile.Enabled)
			{
				global::Gibraltar.Monitor.Log.s_Repository = new global::Gibraltar.Monitor.LocalRepository(global::Gibraltar.Monitor.Log.s_SessionStartInfo.Product, global::Gibraltar.Monitor.Log.s_RunningConfiguration.SessionFile.Folder);
			}
			global::Gibraltar.Monitor.Log.s_Publisher = new global::Gibraltar.Messaging.Publisher(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1} {2} {3}", new object[]
			{
				global::Gibraltar.Monitor.Log.s_SessionStartInfo.Product,
				global::Gibraltar.Monitor.Log.s_SessionStartInfo.Application,
				global::Gibraltar.Monitor.Log.s_SessionStartInfo.ApplicationVersion,
				global::System.DateTimeOffset.UtcNow.ToString("yyyy-MM-dd HH-mm-ss", global::System.Globalization.CultureInfo.InvariantCulture)
			}), global::Gibraltar.Monitor.Log.s_RunningConfiguration, global::Gibraltar.Monitor.Log.s_SessionStartInfo);
			global::Gibraltar.Monitor.Log.Write(global::Gibraltar.Monitor.Log.s_SessionStartInfo.Packet);
			global::Gibraltar.Monitor.Listener.Initialize(global::Gibraltar.Monitor.Log.s_RunningConfiguration, suppressTraceInitialize, true);
			if (!global::Gibraltar.Monitor.Log.s_RunningConfiguration.AutoSendConsent.Enabled)
			{
				global::Gibraltar.Monitor.Log.StartPublishEngine();
			}
			return true;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00040B08 File Offset: 0x0003ED08
		private static void EnsureSummaryIsAvailable()
		{
			if (!global::Gibraltar.Monitor.Log.s_Initialized && (global::Gibraltar.Monitor.Log.s_RunningConfiguration == null || global::Gibraltar.Monitor.Log.s_SessionStartInfo == null))
			{
				object obj = global::Gibraltar.Monitor.Log.s_InitializingLock;
				lock (obj)
				{
					while (global::Gibraltar.Monitor.Log.s_Initializing)
					{
						global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Log.s_InitializingLock);
					}
					global::Gibraltar.Monitor.Log.s_RunningConfiguration = new global::Gibraltar.Monitor.AgentConfiguration();
					global::Gibraltar.Monitor.Log.s_SessionStartInfo = new global::Gibraltar.Monitor.SessionSummary(global::Gibraltar.Monitor.Log.s_RunningConfiguration);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_InitializingLock);
				}
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00040B9C File Offset: 0x0003ED9C
		private static void GetConsentScope(out string productName, out string applicationName)
		{
			bool flag = true;
			global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.Configuration.Server;
			if (server.Enabled && server.AutoSendSessions && server.SendAllApplications)
			{
				flag = false;
			}
			productName = global::Gibraltar.Monitor.Log.SessionSummary.Product;
			applicationName = (flag ? global::Gibraltar.Monitor.Log.SessionSummary.Application : null);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00040C04 File Offset: 0x0003EE04
		private static void StartPublishEngine()
		{
			try
			{
				global::Gibraltar.Data.Internal.RepositoryPublishEngine repositoryPublishEngine = null;
				object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
				lock (obj)
				{
					if (global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server.Enabled && global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server.AutoSendSessions)
					{
						if (global::Gibraltar.Monitor.Log.s_PublishEngine == null)
						{
							global::Gibraltar.Monitor.Log.s_PublishEngine = new global::Gibraltar.Data.Internal.RepositoryPublishEngine(global::Gibraltar.Monitor.Log.s_Publisher, global::Gibraltar.Monitor.Log.s_RunningConfiguration);
						}
						repositoryPublishEngine = global::Gibraltar.Monitor.Log.s_PublishEngine;
						if (global::Gibraltar.Monitor.Log.s_RunningConfiguration.Server.AutoSendOnError)
						{
							global::Gibraltar.Messaging.Notifier messageAlertNotifier = global::Gibraltar.Monitor.Log.MessageAlertNotifier;
						}
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
				}
				if (repositoryPublishEngine != null)
				{
					repositoryPublishEngine.Start();
				}
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00040CD4 File Offset: 0x0003EED4
		private static void ShutdownPublishEngine()
		{
			object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
			global::Gibraltar.Data.Internal.RepositoryPublishEngine repositoryPublishEngine;
			lock (obj)
			{
				repositoryPublishEngine = global::Gibraltar.Monitor.Log.s_PublishEngine;
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
			}
			if (repositoryPublishEngine != null)
			{
				try
				{
					repositoryPublishEngine.Stop(false);
				}
				catch (global::System.Exception obj2)
				{
					global::System.GC.KeepAlive(obj2);
				}
			}
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00040D44 File Offset: 0x0003EF44
		private static void Packager_EndSend(object sender, global::Gibraltar.Data.PackageSendEventArgs args)
		{
			object obj = global::Gibraltar.Monitor.Log.s_SyncObject;
			lock (obj)
			{
				if ((global::Gibraltar.Data.Packager)sender == global::Gibraltar.Monitor.Log.s_ActivePackager)
				{
					global::Gibraltar.Monitor.Log.s_ActivePackager.EndSend -= global::Gibraltar.Monitor.Log.Packager_EndSend;
					global::Gibraltar.Monitor.Log.s_ActivePackager = null;
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Log.s_SyncObject);
			}
		}

		// Token: 0x040006D8 RID: 1752
		public const string LogExtension = "glf";

		// Token: 0x040006D9 RID: 1753
		public const string PackageExtension = "glp";

		// Token: 0x040006DA RID: 1754
		public const string FileFilter = "Package File(*.glp)|*.glp|Log File (*.glf)|*.glf|All Files (*.*)|*.*";

		// Token: 0x040006DB RID: 1755
		public const string FileFilterLogsOnly = "Log File (*.glf)|*.glf|All Files (*.*)|*.*";

		// Token: 0x040006DC RID: 1756
		public const string FileFilterPackagesOnly = "Package File(*.glp)|*.glp|All Files (*.*)|*.*";

		// Token: 0x040006DD RID: 1757
		public const string ThisLogSystem = "Gibraltar";

		// Token: 0x040006DE RID: 1758
		public const string Category = "Trace";

		// Token: 0x040006DF RID: 1759
		private const string GeneralCategory = "General";

		// Token: 0x040006E0 RID: 1760
		public const string ExceptionCategory = "System.Exception";

		// Token: 0x040006E1 RID: 1761
		internal static readonly string[] LineBreakTokens = new string[]
		{
			"\r\n",
			"\n\r",
			"\n",
			"\r"
		};

		// Token: 0x040006E2 RID: 1762
		internal const string LineBreakString = "\r\n";

		// Token: 0x040006E3 RID: 1763
		private static global::Gibraltar.Monitor.SessionSummary s_SessionStartInfo;

		// Token: 0x040006E4 RID: 1764
		private static global::Gibraltar.Messaging.Publisher s_Publisher;

		// Token: 0x040006E5 RID: 1765
		private static global::Gibraltar.Data.Internal.RepositoryPublishEngine s_PublishEngine;

		// Token: 0x040006E6 RID: 1766
		private static global::Gibraltar.Data.Packager s_ActivePackager;

		// Token: 0x040006E7 RID: 1767
		private static global::Gibraltar.Monitor.LocalRepository s_Repository;

		// Token: 0x040006E8 RID: 1768
		private static readonly global::Gibraltar.Monitor.MetricDefinitionCollection s_Metrics = new global::Gibraltar.Monitor.MetricDefinitionCollection();

		// Token: 0x040006E9 RID: 1769
		[global::System.ThreadStatic]
		private static global::Gibraltar.Monitor.ThreadInfo t_CurrentThreadInfo;

		// Token: 0x040006EA RID: 1770
		private static bool s_SendSessionsOnExit;

		// Token: 0x040006EB RID: 1771
		private static global::Gibraltar.Monitor.AgentConfiguration s_RunningConfiguration;

		// Token: 0x040006EC RID: 1772
		private static global::Gibraltar.Data.AutoSendConsent s_AutoSendConsent;

		// Token: 0x040006ED RID: 1773
		private static readonly object s_SyncObject = new object();

		// Token: 0x040006EE RID: 1774
		private static readonly object s_InitializingLock = new object();

		// Token: 0x040006EF RID: 1775
		private static readonly object s_ConsentLock = new object();

		// Token: 0x040006F0 RID: 1776
		private static readonly object s_NotifierLock = new object();

		// Token: 0x040006F1 RID: 1777
		private static volatile bool s_Initialized;

		// Token: 0x040006F2 RID: 1778
		private static volatile bool s_InitializationNeverAttempted = true;

		// Token: 0x040006F3 RID: 1779
		private static volatile bool s_Initializing;

		// Token: 0x040006F4 RID: 1780
		private static volatile bool s_ExplicitStartSessionCalled;

		// Token: 0x040006F5 RID: 1781
		private static bool s_StartupConsentDisplayed;

		// Token: 0x040006F6 RID: 1782
		private static global::Gibraltar.Messaging.Notifier s_MessageAlertNotifier;

		// Token: 0x040006F7 RID: 1783
		private static global::Gibraltar.Monitor.UserResolutionNotifier s_UserResolutionNotifier;

		// Token: 0x040006F8 RID: 1784
		[global::System.ThreadStatic]
		private static bool t_ThreadIsInitializer;

		// Token: 0x020004A7 RID: 1191
		// (Invoke) Token: 0x0600336F RID: 13167
		public delegate void InitializingEventHandler(object sender, global::Gibraltar.Monitor.LogInitializingEventArgs e);
	}
}
