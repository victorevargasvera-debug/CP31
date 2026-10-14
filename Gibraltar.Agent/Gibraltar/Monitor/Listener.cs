using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Messaging;
using Gibraltar.Monitor.Net;
using Gibraltar.Monitor.Windows;
using Gibraltar.Monitor.Windows.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000191 RID: 401
	internal static class Listener
	{
		// Token: 0x14000062 RID: 98
		// (add) Token: 0x060010BE RID: 4286 RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		// (remove) Token: 0x060010BF RID: 4287 RVA: 0x0002E830 File Offset: 0x0002CA30
		private static event global::Gibraltar.Monitor.Listener.MessageFilterEventHandler g_MessageFilterEvent;

		// Token: 0x060010C0 RID: 4288 RVA: 0x0002E868 File Offset: 0x0002CA68
		static Listener()
		{
			global::Gibraltar.Monitor.Listener.CreateMonitorThread();
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		public static void Initialize(global::Gibraltar.Monitor.AgentConfiguration agentConfiguration, bool suppressTraceInitialize, bool async)
		{
			global::Gibraltar.Monitor.ListenerConfiguration listener = agentConfiguration.Listener;
			object configLock = global::Gibraltar.Monitor.Listener.m_ConfigLock;
			lock (configLock)
			{
				global::Gibraltar.Monitor.Listener.m_SuppressTraceInitialize = suppressTraceInitialize;
				global::Gibraltar.Monitor.Listener.m_AgentConfiguration = agentConfiguration;
				global::Gibraltar.Monitor.Listener.m_Configuration = listener;
				global::Gibraltar.Monitor.Listener.m_PendingConfigChange = true;
				while (!global::Gibraltar.Monitor.Listener.m_EventsInitialized)
				{
					global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ConfigLock, 16);
				}
				while (!async && global::Gibraltar.Monitor.Listener.m_PendingConfigChange)
				{
					global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ConfigLock, 16);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
			}
			if (global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows)
			{
				global::Gibraltar.Monitor.Listener.ConfigureHotKeyFilter(agentConfiguration);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0002E980 File Offset: 0x0002CB80
		public static bool Initialized
		{
			get
			{
				return global::Gibraltar.Monitor.Listener.m_Initialized;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0002E988 File Offset: 0x0002CB88
		public static void OnManagerExit()
		{
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				global::Gibraltar.Monitor.Listener.m_Exiting = true;
				if (global::Gibraltar.Monitor.Listener.m_AppContext != null)
				{
					global::Gibraltar.Monitor.Listener.m_AppContext.CloseAll();
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x0002E9EC File Offset: 0x0002CBEC
		public static global::Loupe.Extensibility.Data.MetricSampleInterval SamplingInterval
		{
			get
			{
				return global::Gibraltar.Monitor.Listener.m_SamplingInterval;
			}
			set
			{
				global::Gibraltar.Monitor.Listener.m_SamplingInterval = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		public static bool SuppressAlerts
		{
			get
			{
				object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
				bool suppressAlerts;
				lock (managerThreadLock)
				{
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
					suppressAlerts = global::Gibraltar.Monitor.Listener.m_SuppressAlerts;
				}
				return suppressAlerts;
			}
			set
			{
				object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
				lock (managerThreadLock)
				{
					global::Gibraltar.Monitor.Listener.m_SuppressAlerts = value;
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060010C8 RID: 4296 RVA: 0x0002EA84 File Offset: 0x0002CC84
		// (remove) Token: 0x060010C9 RID: 4297 RVA: 0x0002EAF0 File Offset: 0x0002CCF0
		public static event global::Gibraltar.Monitor.Listener.MessageFilterEventHandler LiveViewerMessageFilter
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Monitor.Listener.g_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Monitor.Listener.g_MessageFilterEvent == null && global::Gibraltar.Monitor.Listener.m_LiveViewer != null)
					{
						global::Gibraltar.Monitor.Listener.m_LiveViewer.MessageFilter += global::Gibraltar.Monitor.Listener.LiveViewer_MessageFilter;
					}
					global::Gibraltar.Monitor.Listener.g_MessageFilterEvent += value;
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object obj = global::Gibraltar.Monitor.Listener.g_MessageEventLock;
				lock (obj)
				{
					if (global::Gibraltar.Monitor.Listener.g_MessageFilterEvent != null)
					{
						global::Gibraltar.Monitor.Listener.g_MessageFilterEvent -= value;
						if (global::Gibraltar.Monitor.Listener.g_MessageFilterEvent == null && global::Gibraltar.Monitor.Listener.m_LiveViewer != null)
						{
							global::Gibraltar.Monitor.Listener.m_LiveViewer.MessageFilter -= global::Gibraltar.Monitor.Listener.LiveViewer_MessageFilter;
						}
					}
				}
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002EB6C File Offset: 0x0002CD6C
		private static void LiveViewer_MessageFilter(object sender, global::Gibraltar.Monitor.MessageFilterEventArgs e)
		{
			global::Gibraltar.Monitor.Listener.MessageFilterEventHandler messageFilterEventHandler = global::Gibraltar.Monitor.Listener.g_MessageFilterEvent;
			if (messageFilterEventHandler != null)
			{
				messageFilterEventHandler(sender, e);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0002EB94 File Offset: 0x0002CD94
		public static bool GibraltarWindowForm(object form)
		{
			if (form == null)
			{
				throw new global::System.ArgumentNullException("form");
			}
			string text = form.GetType().FullName;
			if (text.StartsWith("Gibraltar.Monitor.Windows."))
			{
				text = text.Substring(26);
				if (text == "Internal.LiveViewerForm" || text == "UIPackagerDialog")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0002EC00 File Offset: 0x0002CE00
		public static global::System.Windows.Forms.Form ClientFormsActive()
		{
			global::System.Windows.Forms.Form result = null;
			try
			{
				global::System.Windows.Forms.FormCollection openForms = global::System.Windows.Forms.Application.OpenForms;
				if (openForms != null)
				{
					foreach (object obj in openForms)
					{
						global::System.Windows.Forms.Form form = (global::System.Windows.Forms.Form)obj;
						if (form != null && form.IsHandleCreated && !global::Gibraltar.Monitor.Listener.GibraltarWindowForm(form))
						{
							result = form;
							break;
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.Threading.ThreadAbortException)
				{
					throw;
				}
			}
			return result;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		public static bool ClientWindowsActive()
		{
			return false;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0002ECB4 File Offset: 0x0002CEB4
		internal static void InitializeThreadListening(global::Loupe.Extensibility.Data.ApplicationType appType, bool ignoreConfig)
		{
			if (appType != global::Loupe.Extensibility.Data.ApplicationType.Windows)
			{
				return;
			}
			if (!global::Gibraltar.Monitor.Listener.t_ThreadExceptionSubscribed)
			{
				object exceptionListenerLock = global::Gibraltar.Monitor.Listener.m_ExceptionListenerLock;
				lock (exceptionListenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_ExceptionListener != null)
					{
						global::Gibraltar.Monitor.Listener.m_ExceptionListener.RegisterThreadEvents(ignoreConfig);
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ExceptionListenerLock);
				}
			}
			global::Gibraltar.Monitor.Listener.ActivateHotKeyFilter();
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0002ED20 File Offset: 0x0002CF20
		internal static void ShowAlertDialog(global::Gibraltar.Monitor.ExceptionDisplayRequest newRequest)
		{
			if (newRequest == null)
			{
				return;
			}
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				if (global::Gibraltar.Monitor.Listener.m_SuppressAlerts || global::Gibraltar.Monitor.Log.IsMonoRuntime)
				{
					newRequest.Result = global::System.Windows.Forms.DialogResult.OK;
				}
				else
				{
					global::Gibraltar.Monitor.Listener.m_AlertQueue.Enqueue(newRequest);
					global::Gibraltar.Monitor.Listener.m_ShowAlertForm = true;
					if (global::Gibraltar.Monitor.Listener.m_ManagerThread == null)
					{
						global::Gibraltar.Monitor.Listener.CreateManagerThread();
					}
					else
					{
						global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
						if (global::Gibraltar.Monitor.Listener.m_AppContext == null && !global::Gibraltar.Monitor.Listener.m_Exiting)
						{
							global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock, 2000);
						}
						if (global::Gibraltar.Monitor.Listener.m_AppContext != null && !global::Gibraltar.Monitor.Listener.m_Exiting)
						{
							global::Gibraltar.Monitor.Listener.m_AppContext.DoInvoke(new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.RaiseAlertDialog));
						}
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002EE04 File Offset: 0x0002D004
		internal static void ShowViewerForm()
		{
			if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar.Agent.Live Viewer", "Gibraltar Live Viewer is not supported on Mono", "The Gibraltar Live Viewer is designed to run in a separate UI thread, but the Mono runtime does not support multiple UI threads as of version 2.6, so the GLV is disabled when running under Mono.\r\nYou can achieve Live Viewer functionality under Mono by placing the Gibraltar.Agent.Windows.LiveLogViewer control on one of your own forms and displaying it in your main UI thread.", new object[0]);
				return;
			}
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm = true;
				if (global::Gibraltar.Monitor.Listener.m_ManagerThread == null)
				{
					global::Gibraltar.Monitor.Listener.CreateManagerThread();
				}
				else
				{
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
					while (global::Gibraltar.Monitor.Listener.m_AppContext == null && !global::Gibraltar.Monitor.Listener.m_Exiting)
					{
						global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock, 2000);
					}
					if (global::Gibraltar.Monitor.Listener.m_AppContext != null && !global::Gibraltar.Monitor.Listener.m_Exiting)
					{
						global::Gibraltar.Monitor.Listener.m_AppContext.DoInvoke(new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.RaiseViewerForm));
					}
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		internal static void ClearViewerForm()
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		internal static void ThreadExitedMessageLoop()
		{
			global::Gibraltar.Monitor.Listener.ThreadExceptionUnsubscribed();
			global::Gibraltar.Monitor.Listener.DeactivateHotKeyFilter();
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		internal static void ThreadExceptionUnsubscribed()
		{
			global::Gibraltar.Monitor.Listener.t_ThreadExceptionSubscribed = false;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0002EEF8 File Offset: 0x0002D0F8
		internal static void ThreadExceptionSubscribed()
		{
			global::Gibraltar.Monitor.Listener.t_ThreadExceptionSubscribed = true;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0002EF00 File Offset: 0x0002D100
		private static bool IsHotKeyConfigDisabled(string hotKeyConfig)
		{
			if (string.IsNullOrEmpty(hotKeyConfig))
			{
				return true;
			}
			string a = hotKeyConfig.ToUpperInvariant();
			return a == "DISABLE" || a == "DISABLED" || a == "DIS" || a == "NONE";
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0002EF68 File Offset: 0x0002D168
		private static void ConfigureHotKeyFilter(global::Gibraltar.Monitor.AgentConfiguration agentConfiguration)
		{
			global::Gibraltar.Messaging.ViewerMessengerConfiguration viewer = agentConfiguration.Viewer;
			global::Gibraltar.Monitor.PackagerConfiguration packager = agentConfiguration.Packager;
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				string hotKey = viewer.HotKey;
				global::System.Windows.Forms.Keys keys;
				if (!global::Gibraltar.Monitor.Listener.IsHotKeyConfigDisabled(hotKey) && !global::Gibraltar.Monitor.Log.IsMonoRuntime)
				{
					keys = global::Gibraltar.Monitor.Windows.Internal.MessageFilter.ParseHotKeyString(hotKey);
				}
				else
				{
					keys = global::System.Windows.Forms.Keys.None;
				}
				string hotKey2 = packager.HotKey;
				global::System.Windows.Forms.Keys keys2;
				if (!global::Gibraltar.Monitor.Listener.IsHotKeyConfigDisabled(hotKey2))
				{
					keys2 = global::Gibraltar.Monitor.Windows.Internal.MessageFilter.ParseHotKeyString(hotKey2);
				}
				else
				{
					keys2 = global::System.Windows.Forms.Keys.None;
				}
				if (global::Gibraltar.Monitor.Listener.m_KeyFilter != null)
				{
					global::Gibraltar.Monitor.Listener.m_KeyFilter.Disable = true;
				}
				global::Gibraltar.Monitor.Listener.m_HotKeyMap.Clear();
				if (keys == keys2)
				{
					if (keys != global::System.Windows.Forms.Keys.None)
					{
						global::Gibraltar.Monitor.Listener.m_HotKeyMap[keys] = new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.OnShowViewerAndPackagerHotKeyPressed);
					}
				}
				else
				{
					if (keys != global::System.Windows.Forms.Keys.None)
					{
						global::Gibraltar.Monitor.Listener.m_HotKeyMap[keys] = new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.OnShowViewerHotKeyPressed);
					}
					if (keys2 != global::System.Windows.Forms.Keys.None)
					{
						global::Gibraltar.Monitor.Listener.m_HotKeyMap[keys2] = new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.OnShowPackagerHotKeyPressed);
					}
				}
				if (global::Gibraltar.Monitor.Listener.m_KeyFilter != null)
				{
					global::Gibraltar.Monitor.Listener.m_KeyFilter.Disable = false;
				}
				else if (global::Gibraltar.Monitor.Listener.m_HotKeyMap.Count > 0)
				{
					global::Gibraltar.Monitor.Listener.m_KeyFilter = new global::Gibraltar.Monitor.Windows.Internal.MessageFilter(global::Gibraltar.Monitor.Listener.m_HotKeyMap);
					global::Gibraltar.Monitor.Listener.m_NewHotKeyFilter = true;
					global::Gibraltar.Monitor.Listener.InitializeHotKeyFilter();
					if (global::Gibraltar.Monitor.Listener.m_AppContext != null)
					{
						global::Gibraltar.Monitor.Listener.m_AppContext.DoInvoke(new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.ActivateHotKeyFilter));
					}
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0002F10C File Offset: 0x0002D30C
		private static void CheckClientActive(bool subscribed)
		{
			if (global::Gibraltar.Monitor.Listener.m_KeyFilter == null)
			{
				return;
			}
			global::System.Windows.Forms.Form form = global::Gibraltar.Monitor.Listener.ClientFormsActive();
			if (form != null)
			{
				global::Gibraltar.Messaging.Publisher.MessageDispatching -= global::Gibraltar.Monitor.Listener.Publisher_MessageDispatching;
				form.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.ActivateHotKeyFilter));
				return;
			}
			if (global::Gibraltar.Monitor.Listener.ClientWindowsActive())
			{
				global::Gibraltar.Messaging.Publisher.MessageDispatching -= global::Gibraltar.Monitor.Listener.Publisher_MessageDispatching;
				return;
			}
			if (!subscribed)
			{
				global::Gibraltar.Messaging.Publisher.MessageDispatching += global::Gibraltar.Monitor.Listener.Publisher_MessageDispatching;
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002F190 File Offset: 0x0002D390
		private static void ActivateHotKeyFilter()
		{
			global::Gibraltar.Monitor.Windows.Internal.MessageFilter keyFilter = global::Gibraltar.Monitor.Listener.m_KeyFilter;
			if (keyFilter != null)
			{
				keyFilter.Activate();
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		private static void DeactivateHotKeyFilter()
		{
			global::Gibraltar.Monitor.Windows.Internal.MessageFilter keyFilter = global::Gibraltar.Monitor.Listener.m_KeyFilter;
			if (keyFilter != null)
			{
				keyFilter.Deactivate();
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		private static void InitializeHotKeyFilter()
		{
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				if (global::Gibraltar.Monitor.Listener.m_NewHotKeyFilter)
				{
					global::Gibraltar.Monitor.Listener.m_NewHotKeyFilter = false;
					global::Gibraltar.Monitor.Listener.CheckClientActive(false);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0002F238 File Offset: 0x0002D438
		private static void OnShowViewerHotKeyPressed()
		{
			global::Gibraltar.Monitor.Listener.ShowViewerForm();
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0002F240 File Offset: 0x0002D440
		private static void OnShowPackagerHotKeyPressed()
		{
			global::System.Windows.Forms.Form activeForm = global::System.Windows.Forms.Form.ActiveForm;
			global::System.Windows.Forms.Form form = null;
			if (activeForm == null || global::Gibraltar.Monitor.Listener.GibraltarWindowForm(activeForm))
			{
				form = global::Gibraltar.Monitor.Listener.ClientFormsActive();
			}
			if (form != null)
			{
				form.BeginInvoke(new global::Gibraltar.Monitor.Listener.MethodInvokerWithForm(global::Gibraltar.Monitor.Listener.ShowPackagerDialog), new object[]
				{
					form
				});
				return;
			}
			if (activeForm != null)
			{
				activeForm.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(global::Gibraltar.Monitor.Listener.ShowPackagerDialog));
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		private static void OnShowViewerAndPackagerHotKeyPressed()
		{
			global::Gibraltar.Monitor.Listener.ShowViewerForm();
			global::Gibraltar.Monitor.Listener.OnShowPackagerHotKeyPressed();
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0002F2BC File Offset: 0x0002D4BC
		private static void CreateManagerThread()
		{
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				if (global::Gibraltar.Monitor.Listener.m_ManagerThread == null)
				{
					global::Gibraltar.Monitor.Listener.m_Exiting = false;
					global::Gibraltar.Monitor.Listener.m_ManagerThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(global::Gibraltar.Monitor.Listener.ManagerThreadMain));
					global::Gibraltar.Monitor.Listener.m_ManagerThread.IsBackground = true;
					global::Gibraltar.Monitor.Listener.m_ManagerThread.Name = "Loupe Agent Manager";
					global::Gibraltar.Monitor.Listener.m_ManagerThread.TrySetApartmentState(global::System.Threading.ApartmentState.STA);
					global::Gibraltar.Monitor.Listener.m_ManagerThread.Start();
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0002F358 File Offset: 0x0002D558
		private static void ManagerThreadMain()
		{
			bool flag = false;
			global::Gibraltar.Monitor.Listener.ManagerApplicationContext managerApplicationContext = null;
			global::Gibraltar.Messaging.Publisher.ThreadMustNotBlock();
			global::System.Windows.Forms.Application.SetUnhandledExceptionMode(global::System.Windows.Forms.UnhandledExceptionMode.CatchException);
			object obj = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (obj)
			{
				try
				{
					global::Gibraltar.Monitor.Windows.LiveLogViewer liveLogViewer = new global::Gibraltar.Monitor.Windows.LiveLogViewer(true, true);
					liveLogViewer.GetPriorMessages = true;
					object obj2 = global::Gibraltar.Monitor.Listener.g_MessageEventLock;
					lock (obj2)
					{
						global::Gibraltar.Monitor.Listener.m_LiveViewer = liveLogViewer;
						if (global::Gibraltar.Monitor.Listener.g_MessageFilterEvent != null)
						{
							global::Gibraltar.Monitor.Listener.m_LiveViewer.MessageFilter += global::Gibraltar.Monitor.Listener.LiveViewer_MessageFilter;
						}
					}
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.Monitor.Listener.m_Exiting = true;
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent.Manager", "Gibraltar Agent Manager thread exited", "The thread managing the Gibraltar Live Viewer and Gibraltar Error Manager caught an unexpected exception and must exit.", new object[0]);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				goto IL_287;
			}
			IL_B1:
			try
			{
				obj = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
				lock (obj)
				{
					while (!global::Gibraltar.Monitor.Listener.m_Exiting && !global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm && !global::Gibraltar.Monitor.Listener.m_ShowPackagerForm && !global::Gibraltar.Monitor.Listener.m_ShowAlertForm && global::Gibraltar.Monitor.Listener.m_AlertQueue.Count <= 0)
					{
						global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
					}
					flag = global::Gibraltar.Monitor.Listener.m_Exiting;
					if (!flag)
					{
						managerApplicationContext = new global::Gibraltar.Monitor.Listener.ManagerApplicationContext(global::Gibraltar.Monitor.Listener.m_LiveViewer);
						if (global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm)
						{
							global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm = false;
							managerApplicationContext.ShowLiveViewer();
						}
						if (global::Gibraltar.Monitor.Listener.m_ShowPackagerForm)
						{
							global::Gibraltar.Monitor.Listener.m_ShowPackagerForm = false;
							managerApplicationContext.ShowPackager();
						}
						if (global::Gibraltar.Monitor.Listener.m_ShowAlertForm || global::Gibraltar.Monitor.Listener.m_AlertQueue.Count > 0)
						{
							global::Gibraltar.Monitor.Listener.m_ShowAlertForm = false;
							global::Gibraltar.Monitor.ExceptionDisplayRequest[] newRequests = global::Gibraltar.Monitor.Listener.m_AlertQueue.ToArray();
							global::Gibraltar.Monitor.Listener.m_AlertQueue.Clear();
							managerApplicationContext.ShowAlertForm(newRequests);
						}
						if (global::Gibraltar.Monitor.Listener.m_KeyFilter != null)
						{
							global::Gibraltar.Monitor.Listener.ActivateHotKeyFilter();
						}
					}
					global::Gibraltar.Monitor.Listener.m_AppContext = managerApplicationContext;
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
				if (managerApplicationContext != null)
				{
					obj = global::Gibraltar.Monitor.Listener.m_ListenerLock;
					lock (obj)
					{
						if (global::Gibraltar.Monitor.Listener.m_ExceptionListener != null)
						{
							global::Gibraltar.Monitor.Listener.m_ExceptionListener.RegisterThreadEvents(true);
						}
						global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
					}
					global::System.Windows.Forms.Application.Run(managerApplicationContext);
				}
			}
			catch (global::System.Threading.ThreadAbortException)
			{
				global::Gibraltar.Monitor.Listener.m_Exiting = true;
			}
			catch (global::System.Exception exception2)
			{
				global::Gibraltar.Monitor.Listener.m_Exiting = true;
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception2, "Gibraltar.Agent.Manager", "Gibraltar Agent Manager thread exited", "The thread managing the Gibraltar Live Viewer and Gibraltar Error Manager caught an unexpected exception and must exit.", new object[0]);
			}
			finally
			{
				obj = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
				lock (obj)
				{
					if (managerApplicationContext != null)
					{
						try
						{
							managerApplicationContext.Dispose();
						}
						catch (global::System.Exception ex)
						{
							if (ex is global::System.Threading.ThreadAbortException)
							{
								global::Gibraltar.Monitor.Listener.m_Exiting = true;
							}
						}
					}
					global::Gibraltar.Monitor.Listener.m_AppContext = null;
					managerApplicationContext = null;
					flag = global::Gibraltar.Monitor.Listener.m_Exiting;
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
			}
			IL_287:
			if (flag)
			{
				obj = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
				lock (obj)
				{
					if (global::Gibraltar.Monitor.Listener.m_LiveViewer != null)
					{
						try
						{
							global::Gibraltar.Monitor.Listener.m_LiveViewer.Dispose();
						}
						catch (global::System.Exception exception3)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception3, "Gibraltar.Agent.Live Viewer", "Error disposing Live Viewer control", "An exception was thrown when disposing the Live Viewer control as the Manager thread exits.", new object[0]);
							}
						}
						object obj2 = global::Gibraltar.Monitor.Listener.g_MessageEventLock;
						lock (obj2)
						{
							global::Gibraltar.Monitor.Listener.m_LiveViewer.MessageFilter -= global::Gibraltar.Monitor.Listener.LiveViewer_MessageFilter;
							global::Gibraltar.Monitor.Listener.m_LiveViewer = null;
						}
					}
					global::Gibraltar.Monitor.Listener.m_ManagerThread = null;
					while (global::Gibraltar.Monitor.Listener.m_AlertQueue.Count > 0)
					{
						global::Gibraltar.Monitor.Listener.m_AlertQueue.Dequeue().Result = global::System.Windows.Forms.DialogResult.No;
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
				}
				return;
			}
			goto IL_B1;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002F7F8 File Offset: 0x0002D9F8
		private static void RaiseViewerForm()
		{
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm = true;
				if (global::Gibraltar.Monitor.Listener.m_AppContext != null)
				{
					global::Gibraltar.Monitor.Listener.m_ShowLiveViewerForm = false;
					global::Gibraltar.Monitor.Listener.m_AppContext.ShowLiveViewer();
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002F858 File Offset: 0x0002DA58
		private static void ShowPackagerDialog()
		{
			global::Gibraltar.Monitor.Listener.ShowPackagerDialog(null);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0002F860 File Offset: 0x0002DA60
		private static void ShowPackagerDialog(global::System.Windows.Forms.Form owner)
		{
			if (!global::Gibraltar.Monitor.Windows.UIPackagerDialog.RaisePendingToFront())
			{
				using (global::Gibraltar.Monitor.Windows.UIPackagerDialog uipackagerDialog = new global::Gibraltar.Monitor.Windows.UIPackagerDialog())
				{
					if (owner != null)
					{
						owner.Focus();
						uipackagerDialog.Owner = owner;
					}
					uipackagerDialog.Send();
				}
			}
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0002F8BC File Offset: 0x0002DABC
		private static void RaiseAlertDialog()
		{
			object managerThreadLock = global::Gibraltar.Monitor.Listener.m_ManagerThreadLock;
			lock (managerThreadLock)
			{
				global::Gibraltar.Monitor.Listener.m_ShowAlertForm = true;
				if (global::Gibraltar.Monitor.Listener.m_AppContext != null)
				{
					global::Gibraltar.Monitor.ExceptionDisplayRequest[] newRequests;
					if (global::Gibraltar.Monitor.Listener.m_AlertQueue.Count > 0)
					{
						newRequests = global::Gibraltar.Monitor.Listener.m_AlertQueue.ToArray();
						global::Gibraltar.Monitor.Listener.m_AlertQueue.Clear();
					}
					else
					{
						newRequests = null;
					}
					global::Gibraltar.Monitor.Listener.m_ShowAlertForm = false;
					global::Gibraltar.Monitor.Listener.m_AppContext.ShowAlertForm(newRequests);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ManagerThreadLock);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0002F948 File Offset: 0x0002DB48
		private static void CreateMonitorThread()
		{
			object monitorThreadLock = global::Gibraltar.Monitor.Listener.m_MonitorThreadLock;
			lock (monitorThreadLock)
			{
				global::Gibraltar.Monitor.Listener.m_MonitorThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(global::Gibraltar.Monitor.Listener.MonitorThreadMain));
				global::Gibraltar.Monitor.Listener.m_MonitorThread.IsBackground = true;
				global::Gibraltar.Monitor.Listener.m_MonitorThread.Name = "Loupe Agent Monitor";
				global::Gibraltar.Monitor.Listener.m_MonitorThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				global::Gibraltar.Monitor.Listener.m_MonitorThread.Start();
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_MonitorThreadLock);
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
		private static void MonitorThreadMain()
		{
			try
			{
				try
				{
					global::System.Globalization.CultureInfo cultureInfo = global::System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
					global::System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
					global::System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				object obj2 = global::Gibraltar.Monitor.Listener.m_ConfigLock;
				lock (obj2)
				{
					while (global::Gibraltar.Monitor.Listener.m_Configuration == null)
					{
						global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ConfigLock, 1000);
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
				}
				global::Gibraltar.Monitor.Listener.UpdateMonitorConfiguration();
				global::Gibraltar.Monitor.Listener.m_PollingStarted = global::System.DateTimeOffset.Now;
				while (!global::Gibraltar.Monitor.Log.IsSessionEnding)
				{
					global::System.DateTimeOffset utcNow = global::System.DateTimeOffset.UtcNow;
					global::Gibraltar.Monitor.Listener.PerformPoll();
					global::System.DateTimeOffset left;
					do
					{
						obj2 = global::Gibraltar.Monitor.Listener.m_ListenerLock;
						long timerInterval;
						lock (obj2)
						{
							timerInterval = global::Gibraltar.Monitor.Listener.GetTimerInterval(global::Gibraltar.Monitor.Listener.m_SamplingInterval);
							global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
						}
						bool flag;
						if (timerInterval > 15000L)
						{
							left = utcNow.AddMilliseconds((double)timerInterval);
							flag = global::Gibraltar.Monitor.Listener.WaitOnConfigUpdate(15000);
						}
						else
						{
							int num = (int)(utcNow.AddMilliseconds((double)timerInterval) - global::System.DateTimeOffset.Now).TotalMilliseconds;
							if (num < 1000)
							{
								num = 1000;
							}
							left = utcNow.AddMilliseconds((double)num);
							flag = global::Gibraltar.Monitor.Listener.WaitOnConfigUpdate(num);
						}
						if (flag)
						{
							global::Gibraltar.Monitor.Listener.UpdateMonitorConfiguration();
						}
					}
					while (left > global::System.DateTimeOffset.UtcNow && !global::Gibraltar.Monitor.Log.IsSessionEnding);
				}
			}
			catch (global::System.Exception obj3)
			{
				global::System.GC.KeepAlive(obj3);
			}
			finally
			{
				global::Gibraltar.Monitor.Listener.m_MonitorThread = null;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0002FBCC File Offset: 0x0002DDCC
		private static bool WaitOnConfigUpdate(int maxWaitInterval)
		{
			global::System.DateTimeOffset left = global::System.DateTimeOffset.UtcNow.AddMilliseconds((double)maxWaitInterval);
			object configLock = global::Gibraltar.Monitor.Listener.m_ConfigLock;
			bool result;
			lock (configLock)
			{
				while (left > global::System.DateTimeOffset.UtcNow && (!global::Gibraltar.Monitor.Listener.m_PendingConfigChange || global::Gibraltar.Monitor.Listener.m_Configuration == null))
				{
					global::System.Threading.Monitor.Wait(global::Gibraltar.Monitor.Listener.m_ConfigLock, maxWaitInterval);
				}
				result = (global::Gibraltar.Monitor.Listener.m_PendingConfigChange && global::Gibraltar.Monitor.Listener.m_Configuration != null);
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
			}
			return result;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0002FC64 File Offset: 0x0002DE64
		private static void UpdateMonitorConfiguration()
		{
			global::Gibraltar.Monitor.Log.ThreadIsInitializer = true;
			object configLock = global::Gibraltar.Monitor.Listener.m_ConfigLock;
			global::Gibraltar.Monitor.ListenerConfiguration configuration;
			lock (configLock)
			{
				configuration = global::Gibraltar.Monitor.Listener.m_Configuration;
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
			}
			global::Gibraltar.Monitor.Listener.InitializeConsoleListener(configuration);
			global::Gibraltar.Monitor.Listener.InitializeExceptionListener(configuration);
			if (!global::Gibraltar.Monitor.Listener.m_SuppressTraceInitialize)
			{
				global::Gibraltar.Monitor.Listener.InitializeTraceListener(configuration);
			}
			global::Gibraltar.Monitor.Listener.InitializeCLRListener(configuration);
			configLock = global::Gibraltar.Monitor.Listener.m_ConfigLock;
			lock (configLock)
			{
				global::Gibraltar.Monitor.Listener.m_EventsInitialized = true;
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
			}
			global::Gibraltar.Monitor.Listener.InitializeProcessMonitor(configuration);
			global::Gibraltar.Monitor.Listener.InitializePerformanceMonitor(configuration);
			configLock = global::Gibraltar.Monitor.Listener.m_ConfigLock;
			lock (configLock)
			{
				global::Gibraltar.Monitor.Listener.m_PendingConfigChange = false;
				global::Gibraltar.Monitor.Listener.m_SuppressTraceInitialize = false;
				global::Gibraltar.Monitor.Listener.m_Initialized = true;
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ConfigLock);
			}
			global::Gibraltar.Monitor.Log.ThreadIsInitializer = false;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0002FD58 File Offset: 0x0002DF58
		private static void InitializeConsoleListener(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object listenerLock = global::Gibraltar.Monitor.Listener.m_ListenerLock;
				lock (listenerLock)
				{
					if (!global::Gibraltar.Monitor.Listener.m_ConsoleListenerRegistered && configuration.EnableConsole)
					{
						global::Gibraltar.Monitor.Net.ConsoleListener.RegisterConsoleIntercepter();
						global::Gibraltar.Monitor.Listener.m_ConsoleListenerRegistered = true;
					}
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		private static void InitializeCLRListener(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object listenerLock = global::Gibraltar.Monitor.Listener.m_ListenerLock;
				lock (listenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_CLRListener == null)
					{
						global::Gibraltar.Monitor.Listener.m_CLRListener = new global::Gibraltar.Monitor.Net.CLRListener();
					}
					global::Gibraltar.Monitor.Listener.m_CLRListener.Initialize(configuration);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0002FE44 File Offset: 0x0002E044
		private static void InitializeExceptionListener(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object exceptionListenerLock = global::Gibraltar.Monitor.Listener.m_ExceptionListenerLock;
				lock (exceptionListenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_ExceptionListener == null)
					{
						global::Gibraltar.Monitor.Listener.m_ExceptionListener = global::Gibraltar.Monitor.Net.ExceptionListener.GetExceptionListener();
					}
					global::Gibraltar.Monitor.Listener.m_ExceptionListener.Initialize(configuration);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ExceptionListenerLock);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0002FEC0 File Offset: 0x0002E0C0
		private static void InitializeTraceListener(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object listenerLock = global::Gibraltar.Monitor.Listener.m_ListenerLock;
				lock (listenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_TraceListener == null)
					{
						global::Gibraltar.Monitor.Listener.m_TraceListener = new global::Gibraltar.Monitor.Net.LogListener();
					}
					global::Gibraltar.Monitor.Listener.m_TraceListener.Initialize(configuration);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0002FF3C File Offset: 0x0002E13C
		private static void InitializePerformanceMonitor(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object listenerLock = global::Gibraltar.Monitor.Listener.m_ListenerLock;
				lock (listenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_PerformanceMonitor == null)
					{
						global::Gibraltar.Monitor.Listener.m_PerformanceMonitor = new global::Gibraltar.Monitor.Net.PerformanceMonitor();
					}
					global::Gibraltar.Monitor.Listener.m_PerformanceMonitor.Initialize(configuration);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		private static void InitializeProcessMonitor(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			try
			{
				object listenerLock = global::Gibraltar.Monitor.Listener.m_ListenerLock;
				lock (listenerLock)
				{
					if (global::Gibraltar.Monitor.Listener.m_ProcessMonitor == null && configuration.EnableProcessPerformance)
					{
						global::Gibraltar.Monitor.Listener.m_ProcessMonitor = new global::Gibraltar.Monitor.Net.ProcessMonitor(false);
					}
					else if (global::Gibraltar.Monitor.Listener.m_ProcessMonitor != null && !configuration.EnableProcessPerformance)
					{
						global::Gibraltar.Monitor.Net.ProcessMonitor processMonitor = global::Gibraltar.Monitor.Listener.m_ProcessMonitor;
						global::Gibraltar.Monitor.Listener.m_ProcessMonitor = null;
						processMonitor.Dispose();
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Monitor.Listener.m_ListenerLock);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0003005C File Offset: 0x0002E25C
		private static void PerformPoll()
		{
			if (global::Gibraltar.Monitor.Listener.m_PerformanceMonitor != null)
			{
				try
				{
					global::Gibraltar.Monitor.Listener.m_PerformanceMonitor.Poll();
				}
				catch (global::System.Exception ex)
				{
					if (ex is global::System.Threading.ThreadAbortException)
					{
						throw;
					}
				}
			}
			if (global::Gibraltar.Monitor.Listener.m_ProcessMonitor != null)
			{
				try
				{
					global::Gibraltar.Monitor.Listener.m_ProcessMonitor.Poll();
				}
				catch (global::System.Exception ex2)
				{
					if (ex2 is global::System.Threading.ThreadAbortException)
					{
						throw;
					}
				}
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000300DC File Offset: 0x0002E2DC
		private static long GetTimerInterval(global::Loupe.Extensibility.Data.MetricSampleInterval referenceInterval)
		{
			long num = -1L;
			switch (referenceInterval)
			{
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Default:
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest:
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond:
				num = 1000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Second:
				num = 1000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Minute:
				num = 60000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Hour:
				num = 3600000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Day:
				num = 86400000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Week:
				num = 604800000L;
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Month:
				num = (long)(global::System.DateTime.DaysInMonth(global::System.DateTimeOffset.UtcNow.Year, global::System.DateTimeOffset.UtcNow.Month) * 86400000);
				break;
			}
			long num2 = (long)(global::System.DateTimeOffset.Now - global::Gibraltar.Monitor.Listener.m_PollingStarted).TotalSeconds;
			if (num > 5000L && num2 < 120L)
			{
				num = 5000L;
			}
			else if (num > 15000L && num2 < 3600L)
			{
				num = 15000L;
			}
			return num;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000301E8 File Offset: 0x0002E3E8
		private static void Publisher_MessageDispatching(object sender, global::Gibraltar.Messaging.PacketEventArgs e)
		{
			global::Gibraltar.Monitor.Listener.CheckClientActive(true);
		}

		// Token: 0x040005A1 RID: 1441
		private static readonly object m_MonitorThreadLock = new object();

		// Token: 0x040005A2 RID: 1442
		private static readonly object m_ManagerThreadLock = new object();

		// Token: 0x040005A3 RID: 1443
		private static readonly object m_ListenerLock = new object();

		// Token: 0x040005A4 RID: 1444
		private static readonly object m_ExceptionListenerLock = new object();

		// Token: 0x040005A5 RID: 1445
		private static readonly object m_ConfigLock = new object();

		// Token: 0x040005A6 RID: 1446
		private static global::Gibraltar.Monitor.AgentConfiguration m_AgentConfiguration;

		// Token: 0x040005A7 RID: 1447
		private static global::Gibraltar.Monitor.ListenerConfiguration m_Configuration;

		// Token: 0x040005A8 RID: 1448
		private static bool m_PendingConfigChange;

		// Token: 0x040005A9 RID: 1449
		private static bool m_Initialized;

		// Token: 0x040005AA RID: 1450
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker> m_HotKeyMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.Forms.Keys, global::System.Windows.Forms.MethodInvoker>();

		// Token: 0x040005AB RID: 1451
		private static global::System.Threading.Thread m_MonitorThread;

		// Token: 0x040005AC RID: 1452
		private static global::System.Threading.Thread m_ManagerThread;

		// Token: 0x040005AD RID: 1453
		private static bool m_ConsoleListenerRegistered;

		// Token: 0x040005AE RID: 1454
		private static global::Gibraltar.Monitor.Net.LogListener m_TraceListener;

		// Token: 0x040005AF RID: 1455
		private static global::Gibraltar.Monitor.Net.ExceptionListener m_ExceptionListener;

		// Token: 0x040005B0 RID: 1456
		private static global::Gibraltar.Monitor.Net.PerformanceMonitor m_PerformanceMonitor;

		// Token: 0x040005B1 RID: 1457
		private static global::Gibraltar.Monitor.Net.ProcessMonitor m_ProcessMonitor;

		// Token: 0x040005B2 RID: 1458
		private static global::Gibraltar.Monitor.Net.CLRListener m_CLRListener;

		// Token: 0x040005B3 RID: 1459
		private static global::Loupe.Extensibility.Data.MetricSampleInterval m_SamplingInterval = global::Loupe.Extensibility.Data.MetricSampleInterval.Minute;

		// Token: 0x040005B4 RID: 1460
		private static global::System.DateTimeOffset m_PollingStarted;

		// Token: 0x040005B5 RID: 1461
		private static bool m_EventsInitialized;

		// Token: 0x040005B6 RID: 1462
		private static bool m_SuppressTraceInitialize;

		// Token: 0x040005B7 RID: 1463
		private static bool m_SuppressAlerts;

		// Token: 0x040005B8 RID: 1464
		[global::System.ThreadStatic]
		private static bool t_ThreadExceptionSubscribed;

		// Token: 0x040005B9 RID: 1465
		private static global::Gibraltar.Monitor.Listener.ManagerApplicationContext m_AppContext;

		// Token: 0x040005BA RID: 1466
		private static global::Gibraltar.Monitor.Windows.LiveLogViewer m_LiveViewer;

		// Token: 0x040005BC RID: 1468
		private static readonly object g_MessageEventLock = new object();

		// Token: 0x040005BD RID: 1469
		private static bool m_Exiting;

		// Token: 0x040005BE RID: 1470
		private static bool m_NewHotKeyFilter;

		// Token: 0x040005BF RID: 1471
		private static bool m_ShowLiveViewerForm;

		// Token: 0x040005C0 RID: 1472
		private static bool m_ShowPackagerForm;

		// Token: 0x040005C1 RID: 1473
		private static bool m_ShowAlertForm;

		// Token: 0x040005C2 RID: 1474
		private static volatile global::Gibraltar.Monitor.Windows.Internal.MessageFilter m_KeyFilter;

		// Token: 0x040005C3 RID: 1475
		private static global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.ExceptionDisplayRequest> m_AlertQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.ExceptionDisplayRequest>();

		// Token: 0x020004A0 RID: 1184
		// (Invoke) Token: 0x0600334A RID: 13130
		public delegate void MessageFilterEventHandler(object sender, global::Gibraltar.Monitor.MessageFilterEventArgs e);

		// Token: 0x020004A1 RID: 1185
		// (Invoke) Token: 0x0600334E RID: 13134
		private delegate void MethodInvokerWithForm(global::System.Windows.Forms.Form owner);

		// Token: 0x020004A2 RID: 1186
		// (Invoke) Token: 0x06003352 RID: 13138
		private delegate void ExceptionDisplayRequestInvoker(global::Gibraltar.Monitor.ExceptionDisplayRequest[] newRequests);

		// Token: 0x020004A3 RID: 1187
		private class ManagerApplicationContext : global::System.Windows.Forms.ApplicationContext
		{
			// Token: 0x06003355 RID: 13141 RVA: 0x000BA090 File Offset: 0x000B8290
			public ManagerApplicationContext(global::Gibraltar.Monitor.Windows.LiveLogViewer liveLogViewer)
			{
				this.m_LiveLogViewer = liveLogViewer;
				this.m_OpenCount = 0;
				this.m_ThreadId = global::System.Threading.Thread.CurrentThread.ManagedThreadId;
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x06003356 RID: 13142 RVA: 0x000BA0C4 File Offset: 0x000B82C4
			public bool InvokeRequired
			{
				get
				{
					return global::System.Threading.Thread.CurrentThread.ManagedThreadId != this.m_ThreadId;
				}
			}

			// Token: 0x06003357 RID: 13143 RVA: 0x000BA0DC File Offset: 0x000B82DC
			public void DoInvoke(global::System.Windows.Forms.MethodInvoker invoker)
			{
				if (!this.InvokeRequired)
				{
					invoker();
					return;
				}
				object @lock = this.m_Lock;
				lock (@lock)
				{
					global::System.Windows.Forms.Form form = null;
					if (this.m_LiveViewerForm != null && !this.m_LiveViewerClosing)
					{
						form = this.m_LiveViewerForm;
					}
					else if (this.m_AlertForm != null && !this.m_AlertFormClosing)
					{
						form = this.m_AlertForm;
					}
					else if (this.m_PackagerForm != null && !this.m_PackagerFormClosing)
					{
						form = this.m_PackagerForm;
					}
					if (form != null)
					{
						form.BeginInvoke(invoker);
					}
				}
			}

			// Token: 0x06003358 RID: 13144 RVA: 0x000BA198 File Offset: 0x000B8398
			public bool DoAlertInvoke(global::Gibraltar.Monitor.Listener.ExceptionDisplayRequestInvoker invoker, global::Gibraltar.Monitor.ExceptionDisplayRequest[] newRequests)
			{
				if (!this.InvokeRequired)
				{
					invoker(newRequests);
					return true;
				}
				object @lock = this.m_Lock;
				bool result;
				lock (@lock)
				{
					global::System.Windows.Forms.Form form = null;
					if (this.m_AlertForm != null && !this.m_AlertFormClosing)
					{
						form = this.m_AlertForm;
					}
					else if (this.m_LiveViewerForm != null && !this.m_LiveViewerClosing)
					{
						form = this.m_LiveViewerForm;
					}
					else if (this.m_PackagerForm != null && !this.m_PackagerFormClosing)
					{
						form = this.m_PackagerForm;
					}
					if (form != null)
					{
						form.BeginInvoke(invoker, newRequests);
						result = true;
					}
					else
					{
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06003359 RID: 13145 RVA: 0x000BA260 File Offset: 0x000B8460
			public void ShowLiveViewer()
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LiveViewerForm == null)
					{
						this.m_OpenCount++;
						this.m_LiveViewerClosing = false;
						this.m_LiveViewerForm = new global::Gibraltar.Monitor.Windows.Internal.LiveViewerForm(this.m_LiveLogViewer);
						this.m_LiveViewerForm.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						this.m_LiveViewerForm.Show();
					}
					else
					{
						this.m_LiveViewerForm.RestoreToFront();
					}
				}
			}

			// Token: 0x0600335A RID: 13146 RVA: 0x000BA2FC File Offset: 0x000B84FC
			public void ShowAlertForm()
			{
				this.ShowAlertForm(null);
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x000BA308 File Offset: 0x000B8508
			public void ShowAlertForm(global::Gibraltar.Monitor.ExceptionDisplayRequest[] newRequests)
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_AlertForm == null)
					{
						this.m_OpenCount++;
						this.m_AlertFormClosing = false;
						this.m_AlertForm = new global::Gibraltar.Monitor.Windows.Internal.AlertDialog();
						this.m_AlertForm.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						this.m_AlertForm.Show();
					}
					else
					{
						this.m_AlertForm.RestoreToFront();
					}
					if (newRequests != null)
					{
						foreach (global::Gibraltar.Monitor.ExceptionDisplayRequest newRequest in newRequests)
						{
							this.m_AlertForm.DisplayException(newRequest);
						}
					}
				}
			}

			// Token: 0x0600335C RID: 13148 RVA: 0x000BA3C8 File Offset: 0x000B85C8
			public void ShowPackager()
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Windows.UIPackagerDialog uipackagerDialog;
				lock (@lock)
				{
					if (this.m_PackagerForm == null)
					{
						this.m_OpenCount++;
						this.m_PackagerFormClosing = false;
						this.m_PackagerForm = new global::Gibraltar.Monitor.Windows.UIPackagerDialog();
						this.m_PackagerForm.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						uipackagerDialog = this.m_PackagerForm;
					}
					else
					{
						this.m_PackagerForm.RestoreToFront();
						uipackagerDialog = null;
					}
				}
				if (uipackagerDialog != null)
				{
					using (uipackagerDialog)
					{
						uipackagerDialog.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
						uipackagerDialog.Send();
					}
				}
			}

			// Token: 0x0600335D RID: 13149 RVA: 0x000BA490 File Offset: 0x000B8690
			public void CloseAll()
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LiveViewerForm != null && !this.m_LiveViewerClosing)
					{
						this.m_LiveViewerClosing = true;
						this.m_LiveViewerForm.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.m_LiveViewerForm.Close));
					}
					if (this.m_PackagerForm != null && !this.m_PackagerFormClosing)
					{
						this.m_PackagerFormClosing = true;
						this.m_PackagerForm.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.m_PackagerForm.Close));
					}
					if (this.m_AlertForm != null && !this.m_AlertFormClosing)
					{
						this.m_AlertFormClosing = true;
						this.m_AlertForm.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.m_AlertForm.Close));
					}
				}
			}

			// Token: 0x0600335E RID: 13150 RVA: 0x000BA574 File Offset: 0x000B8774
			private void Form_FormClosed(object sender, global::System.EventArgs e)
			{
				if (sender == null)
				{
					return;
				}
				bool flag = false;
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (sender == this.m_LiveViewerForm)
					{
						this.m_LiveViewerForm.FormClosed -= new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						this.m_LiveViewerForm = null;
						this.m_LiveViewerClosing = false;
						this.m_OpenCount--;
					}
					else if (sender == this.m_PackagerForm)
					{
						this.m_PackagerForm.FormClosed -= new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						this.m_PackagerForm = null;
						this.m_PackagerFormClosing = false;
						this.m_OpenCount--;
					}
					else if (sender == this.m_AlertForm)
					{
						this.m_AlertForm.FormClosed -= new global::System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
						this.m_AlertForm = null;
						this.m_AlertFormClosing = false;
						this.m_OpenCount--;
					}
					else
					{
						int num = 0;
						if (this.m_LiveViewerForm != null)
						{
							num++;
						}
						if (this.m_PackagerForm != null)
						{
							num++;
						}
						if (this.m_AlertForm != null)
						{
							num++;
						}
						this.m_OpenCount = num;
					}
					if (this.m_OpenCount <= 0)
					{
						flag = true;
					}
				}
				if (flag)
				{
					base.ExitThread();
				}
			}

			// Token: 0x0400137F RID: 4991
			private readonly int m_ThreadId;

			// Token: 0x04001380 RID: 4992
			private readonly global::Gibraltar.Monitor.Windows.LiveLogViewer m_LiveLogViewer;

			// Token: 0x04001381 RID: 4993
			private global::Gibraltar.Monitor.Windows.Internal.LiveViewerForm m_LiveViewerForm;

			// Token: 0x04001382 RID: 4994
			private global::Gibraltar.Monitor.Windows.Internal.AlertDialog m_AlertForm;

			// Token: 0x04001383 RID: 4995
			private global::Gibraltar.Monitor.Windows.UIPackagerDialog m_PackagerForm;

			// Token: 0x04001384 RID: 4996
			private int m_OpenCount;

			// Token: 0x04001385 RID: 4997
			private bool m_LiveViewerClosing;

			// Token: 0x04001386 RID: 4998
			private bool m_AlertFormClosing;

			// Token: 0x04001387 RID: 4999
			private bool m_PackagerFormClosing;

			// Token: 0x04001388 RID: 5000
			private readonly object m_Lock = new object();
		}
	}
}
