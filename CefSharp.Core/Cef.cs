using System;
using System.Threading.Tasks;
using CefSharp.Core;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000003 RID: 3
	public static class Cef
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600003B RID: 59 RVA: 0x0000235C File Offset: 0x0000055C
		// (remove) Token: 0x0600003C RID: 60 RVA: 0x00002390 File Offset: 0x00000590
		public static event global::System.EventHandler ShutdownStarted;

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000023C3 File Offset: 0x000005C3
		public static global::System.Threading.Tasks.TaskFactory UIThreadTaskFactory
		{
			get
			{
				return global::CefSharp.Core.Cef.UIThreadTaskFactory;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000023CA File Offset: 0x000005CA
		public static global::System.Threading.Tasks.TaskFactory IOThreadTaskFactory
		{
			get
			{
				return global::CefSharp.Core.Cef.IOThreadTaskFactory;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000023D1 File Offset: 0x000005D1
		public static global::System.Threading.Tasks.TaskFactory FileThreadTaskFactory
		{
			get
			{
				return global::CefSharp.Core.Cef.FileThreadTaskFactory;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000023D8 File Offset: 0x000005D8
		public static void AddDisposable(global::System.IDisposable item)
		{
			global::CefSharp.Core.Cef.AddDisposable(item);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000023E0 File Offset: 0x000005E0
		public static void RemoveDisposable(global::System.IDisposable item)
		{
			global::CefSharp.Core.Cef.RemoveDisposable(item);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000023E8 File Offset: 0x000005E8
		public static bool IsInitialized
		{
			get
			{
				return global::CefSharp.Core.Cef.IsInitialized;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000023EF File Offset: 0x000005EF
		public static bool IsShutdown
		{
			get
			{
				return global::CefSharp.Core.Cef.IsShutdown;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000023F6 File Offset: 0x000005F6
		public static string CefSharpVersion
		{
			get
			{
				return global::CefSharp.Core.Cef.CefSharpVersion;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000023FD File Offset: 0x000005FD
		public static string CefVersion
		{
			get
			{
				return global::CefSharp.Core.Cef.CefVersion;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002404 File Offset: 0x00000604
		public static string ChromiumVersion
		{
			get
			{
				return global::CefSharp.Core.Cef.ChromiumVersion;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000240B File Offset: 0x0000060B
		public static string CefCommitHash
		{
			get
			{
				return global::CefSharp.Core.Cef.CefCommitHash;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002412 File Offset: 0x00000612
		public static global::CefSharp.UrlParts ParseUrl(string url)
		{
			return global::CefSharp.Core.Cef.ParseUrl(url);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000241C File Offset: 0x0000061C
		public static bool Initialize(global::CefSharp.CefSettingsBase settings)
		{
			bool result;
			try
			{
				result = global::CefSharp.Core.Cef.Initialize(settings.settings);
			}
			finally
			{
				if (settings != null)
				{
					((global::System.IDisposable)settings).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002454 File Offset: 0x00000654
		public static bool Initialize(global::CefSharp.CefSettingsBase settings, bool performDependencyCheck)
		{
			bool result;
			try
			{
				result = global::CefSharp.Core.Cef.Initialize(settings.settings, performDependencyCheck);
			}
			finally
			{
				if (settings != null)
				{
					((global::System.IDisposable)settings).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002490 File Offset: 0x00000690
		public static bool Initialize(global::CefSharp.CefSettingsBase settings, bool performDependencyCheck, global::CefSharp.IBrowserProcessHandler browserProcessHandler)
		{
			bool result;
			try
			{
				result = global::CefSharp.Core.Cef.Initialize(settings.settings, performDependencyCheck, browserProcessHandler);
			}
			finally
			{
				if (settings != null)
				{
					((global::System.IDisposable)settings).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000024CC File Offset: 0x000006CC
		public static bool Initialize(global::CefSharp.CefSettingsBase settings, bool performDependencyCheck, global::CefSharp.IApp cefApp)
		{
			bool result;
			try
			{
				result = global::CefSharp.Core.Cef.Initialize(settings.settings, performDependencyCheck, cefApp);
			}
			finally
			{
				if (settings != null)
				{
					((global::System.IDisposable)settings).Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002508 File Offset: 0x00000708
		public static global::System.Threading.Tasks.Task<bool> InitializeAsync(global::CefSharp.CefSettingsBase settings, bool performDependencyCheck = true, global::CefSharp.IBrowserProcessHandler browserProcessHandler = null)
		{
			try
			{
				global::CefSharp.Core.Cef.Initialize(settings.settings, performDependencyCheck, browserProcessHandler);
			}
			catch (global::System.Exception exception)
			{
				global::CefSharp.Internals.GlobalContextInitialized.SetException(exception);
			}
			finally
			{
				if (settings != null)
				{
					((global::System.IDisposable)settings).Dispose();
				}
			}
			return global::CefSharp.Internals.GlobalContextInitialized.Task;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000255C File Offset: 0x0000075C
		public static void RunMessageLoop()
		{
			global::CefSharp.Core.Cef.RunMessageLoop();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002563 File Offset: 0x00000763
		public static void QuitMessageLoop()
		{
			global::CefSharp.Core.Cef.QuitMessageLoop();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000256A File Offset: 0x0000076A
		public static void DoMessageLoopWork()
		{
			global::CefSharp.Core.Cef.DoMessageLoopWork();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002571 File Offset: 0x00000771
		public static int ExecuteProcess()
		{
			return global::CefSharp.Core.Cef.ExecuteProcess();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002578 File Offset: 0x00000778
		public static bool AddCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains)
		{
			return global::CefSharp.Core.Cef.AddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allowTargetSubdomains);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002583 File Offset: 0x00000783
		public static bool RemoveCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains)
		{
			return global::CefSharp.Core.Cef.RemoveCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allowTargetSubdomains);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000258E File Offset: 0x0000078E
		public static bool ClearCrossOriginWhitelist()
		{
			return global::CefSharp.Core.Cef.ClearCrossOriginWhitelist();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002595 File Offset: 0x00000795
		public static global::CefSharp.ICookieManager GetGlobalCookieManager(global::CefSharp.ICompletionCallback callback = null)
		{
			return global::CefSharp.Core.Cef.GetGlobalCookieManager(callback);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000259D File Offset: 0x0000079D
		public static void PreShutdown()
		{
			global::CefSharp.Core.Cef.PreShutdown();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000025A4 File Offset: 0x000007A4
		public static void Shutdown()
		{
			global::System.EventHandler shutdownStarted = global::CefSharp.Cef.ShutdownStarted;
			if (shutdownStarted != null)
			{
				shutdownStarted(null, global::System.EventArgs.Empty);
			}
			global::CefSharp.Cef.ShutdownStarted = null;
			global::CefSharp.Core.Cef.Shutdown();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000025C7 File Offset: 0x000007C7
		public static void ShutdownWithoutChecks()
		{
			global::System.EventHandler shutdownStarted = global::CefSharp.Cef.ShutdownStarted;
			if (shutdownStarted != null)
			{
				shutdownStarted(null, global::System.EventArgs.Empty);
			}
			global::CefSharp.Cef.ShutdownStarted = null;
			global::CefSharp.Core.Cef.ShutdownWithoutChecks();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000025EA File Offset: 0x000007EA
		public static bool ClearSchemeHandlerFactories()
		{
			return global::CefSharp.Core.Cef.ClearSchemeHandlerFactories();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000025F1 File Offset: 0x000007F1
		public static bool CurrentlyOnThread(global::CefSharp.CefThreadIds threadId)
		{
			return global::CefSharp.Core.Cef.CurrentlyOnThread(threadId);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000025F9 File Offset: 0x000007F9
		public static global::CefSharp.IRequestContext GetGlobalRequestContext()
		{
			return global::CefSharp.Core.Cef.GetGlobalRequestContext();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002600 File Offset: 0x00000800
		public static uint ColorSetARGB(uint a, uint r, uint g, uint b)
		{
			return global::CefSharp.Core.Cef.ColorSetARGB(a, r, g, b);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000260B File Offset: 0x0000080B
		public static bool CrashReportingEnabled
		{
			get
			{
				return global::CefSharp.Core.Cef.CrashReportingEnabled;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002612 File Offset: 0x00000812
		public static void SetCrashKeyValue(string key, string value)
		{
			global::CefSharp.Core.Cef.SetCrashKeyValue(key, value);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000261C File Offset: 0x0000081C
		public static global::CefSharp.LogSeverity GetMinLogLevel()
		{
			int minLogLevel = global::CefSharp.Core.Cef.GetMinLogLevel();
			if (minLogLevel == -1)
			{
				return global::CefSharp.LogSeverity.Verbose;
			}
			if (minLogLevel == 0)
			{
				return global::CefSharp.LogSeverity.Info;
			}
			if (minLogLevel == 1)
			{
				return global::CefSharp.LogSeverity.Warning;
			}
			if (minLogLevel == 2)
			{
				return global::CefSharp.LogSeverity.Error;
			}
			if (minLogLevel == 3)
			{
				return global::CefSharp.LogSeverity.Fatal;
			}
			return (global::CefSharp.LogSeverity)minLogLevel;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000264D File Offset: 0x0000084D
		public static string GetMimeType(string extension)
		{
			return global::CefSharp.Core.Cef.GetMimeType(extension);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002655 File Offset: 0x00000855
		public static void EnableWaitForBrowsersToClose()
		{
			global::CefSharp.Core.Cef.EnableWaitForBrowsersToClose();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000265C File Offset: 0x0000085C
		public static void WaitForBrowsersToClose()
		{
			global::CefSharp.Core.Cef.WaitForBrowsersToClose();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002663 File Offset: 0x00000863
		public static void WaitForBrowsersToClose(int timeoutInMiliseconds)
		{
			global::CefSharp.Core.Cef.WaitForBrowsersToClose(timeoutInMiliseconds);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000266B File Offset: 0x0000086B
		public static bool PostDelayedAction(global::CefSharp.CefThreadIds threadId, global::System.Action action, int delayInMs)
		{
			return global::CefSharp.Core.Cef.PostDelayedAction(threadId, action, delayInMs);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002675 File Offset: 0x00000875
		public static bool PostAction(global::CefSharp.CefThreadIds threadId, global::System.Action action)
		{
			return global::CefSharp.Core.Cef.PostAction(threadId, action);
		}
	}
}
