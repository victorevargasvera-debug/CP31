using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D5 RID: 469
	internal class ExceptionListener : global::System.IDisposable
	{
		// Token: 0x06001660 RID: 5728 RVA: 0x00044F30 File Offset: 0x00043130
		private ExceptionListener()
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00044F38 File Offset: 0x00043138
		public static global::Gibraltar.Monitor.Net.ExceptionListener GetExceptionListener()
		{
			object obj = global::Gibraltar.Monitor.Net.ExceptionListener.g_Lock;
			global::Gibraltar.Monitor.Net.ExceptionListener result;
			lock (obj)
			{
				if (global::Gibraltar.Monitor.Net.ExceptionListener.g_SingletonListener == null)
				{
					global::Gibraltar.Monitor.Net.ExceptionListener.g_SingletonListener = new global::Gibraltar.Monitor.Net.ExceptionListener();
				}
				result = global::Gibraltar.Monitor.Net.ExceptionListener.g_SingletonListener;
			}
			return result;
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00044F88 File Offset: 0x00043188
		public static bool FatalExceptionHasOccurred
		{
			get
			{
				return global::Gibraltar.Monitor.Net.ExceptionListener.s_FatalException;
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00044F94 File Offset: 0x00043194
		public void Initialize(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			object obj = global::Gibraltar.Monitor.Net.ExceptionListener.g_Lock;
			lock (obj)
			{
				global::Gibraltar.Monitor.ListenerConfiguration configuration2 = this.m_Configuration;
				this.m_Configuration = configuration;
				if (!this.m_Initialized)
				{
					this.m_Initialized = true;
					if (!global::Gibraltar.Monitor.Log.IsMonoRuntime && global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows && this.m_Configuration.CatchApplicationExceptions)
					{
						try
						{
							if (!global::System.Diagnostics.Debugger.IsAttached || !global::Gibraltar.Monitor.Net.ExceptionListener.AnyWindowHandleCreated())
							{
								global::System.Windows.Forms.Application.SetUnhandledExceptionMode(global::System.Windows.Forms.UnhandledExceptionMode.CatchException, false);
							}
						}
						catch (global::System.Exception exception)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent", "Gibraltar Agent was unable to set default unhandled exception mode", "The Gibraltar Agent's call to Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, false) threw an exception.  This may not usually be a problem but could affect the default way that uncaught exceptions on UI threads are handled by the runtime.  When the Agent is configured to catch application exceptions it attempts to set this default to help ensure that any UI threads which enter Application.Run() will be set up to CatchException rather than let exceptions be unhandled and fatal.\r\n\r\nThis message can usually be avoided by ensuring that the Gibraltar Agent is initialized early by issuing a log message In your Program.Main method before creating the first Form or other Control and before starting any other threads.  The Agent can also be configured not to change the UnhandledExceptionMode by setting catchApplicationExceptions=\"false\" in the listener section of the gibraltar group in your App.config.\r\n", new object[0]);
						}
					}
					global::System.AppDomain.CurrentDomain.ProcessExit += this.CurrentDomain_ProcessExit;
					global::System.AppDomain.CurrentDomain.DomainUnload += this.CurrentDomain_DomainUnload;
					global::System.AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
					global::System.Windows.Forms.Application.ThreadExit += this.Application_ThreadExit;
				}
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000450B8 File Offset: 0x000432B8
		internal void RegisterThreadEvents(bool ignoreConfig)
		{
			if (global::Gibraltar.Monitor.Log.SessionSummary.AgentAppType != global::Loupe.Extensibility.Data.ApplicationType.Windows)
			{
				return;
			}
			object obj = global::Gibraltar.Monitor.Net.ExceptionListener.g_Lock;
			lock (obj)
			{
				if (!ignoreConfig && !this.m_Configuration.CatchApplicationExceptions)
				{
					return;
				}
			}
			if (global::System.Diagnostics.Debugger.IsAttached && !global::Gibraltar.Monitor.Net.ExceptionListener.AnyWindowHandleCreatedOnThisThread())
			{
				try
				{
					global::System.Windows.Forms.Application.SetUnhandledExceptionMode(global::System.Windows.Forms.UnhandledExceptionMode.CatchException);
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent", "Gibraltar Agent was unable to set thread's unhandled exception mode", "The Gibraltar Agent's call to Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException) threw an exception.  When a debugger is attached it may interfere with the Agent's ability to set the default UnhandledExceptionMode, so when the Agent is configured to catch application exceptions and it sees a debugger attached it will instead try to set the UnhandledExceptionMode on specific threads which register for thread events--which is attempted for the main thread by default.\r\n", new object[0]);
				}
			}
			global::Gibraltar.Monitor.Listener.ThreadExceptionSubscribed();
			global::System.Windows.Forms.Application.ThreadException += this.Application_ThreadException;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00045180 File Offset: 0x00043380
		private void UnregisterThreadEvents()
		{
			global::System.Windows.Forms.Application.ThreadException -= this.Application_ThreadException;
			global::Gibraltar.Monitor.Listener.ThreadExceptionUnsubscribed();
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00045198 File Offset: 0x00043398
		private void UnregisterDomainEvents()
		{
			global::System.Windows.Forms.Application.ThreadExit -= this.Application_ThreadExit;
			global::System.AppDomain.CurrentDomain.UnhandledException -= this.CurrentDomain_UnhandledException;
			global::System.AppDomain.CurrentDomain.DomainUnload -= this.CurrentDomain_DomainUnload;
			global::System.AppDomain.CurrentDomain.ProcessExit -= this.CurrentDomain_ProcessExit;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000451FC File Offset: 0x000433FC
		private void Application_ThreadExit(object sender, global::System.EventArgs e)
		{
			global::Gibraltar.Monitor.Listener.ThreadExitedMessageLoop();
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00045204 File Offset: 0x00043404
		private void CurrentDomain_ProcessExit(object sender, global::System.EventArgs e)
		{
			this.UnregisterDomainEvents();
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0004520C File Offset: 0x0004340C
		private void CurrentDomain_DomainUnload(object sender, global::System.EventArgs e)
		{
			this.UnregisterDomainEvents();
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00045214 File Offset: 0x00043414
		private void CurrentDomain_UnhandledException(object sender, global::System.UnhandledExceptionEventArgs e)
		{
			object obj = global::Gibraltar.Monitor.Net.ExceptionListener.g_Lock;
			global::Gibraltar.Monitor.ListenerConfiguration configuration;
			lock (obj)
			{
				configuration = this.m_Configuration;
			}
			bool flag = !e.IsTerminating;
			if (!flag)
			{
				global::Gibraltar.Monitor.Net.ExceptionListener.s_FatalException = true;
			}
			if (!configuration.CatchUnhandledExceptions)
			{
				return;
			}
			if (this.m_UnhandledExceptionSourceProvider == null)
			{
				this.m_UnhandledExceptionSourceProvider = new global::Gibraltar.Monitor.MessageSourceProvider("System.AppDomain", "UnhandledException");
			}
			global::System.Exception exception = (e.ExceptionObject as global::System.Exception) ?? new global::System.Exception("Unwrapped Exception: " + e.ExceptionObject);
			if (configuration.ReportErrorsToUser)
			{
				if (global::Gibraltar.Monitor.Log.ReportException(this.m_UnhandledExceptionSourceProvider, exception, null, "System.Exception", flag, true) == global::System.Windows.Forms.DialogResult.Abort)
				{
				}
			}
			else
			{
				global::Gibraltar.Monitor.Log.RecordException(this.m_UnhandledExceptionSourceProvider, exception, null, "System.Exception", flag);
			}
			if (!flag)
			{
				global::Gibraltar.Monitor.IMessageSourceProvider messageSourceProvider = new global::Gibraltar.ExceptionSourceProvider(exception);
				if (messageSourceProvider.ClassName == null)
				{
					messageSourceProvider = this.m_UnhandledExceptionSourceProvider;
				}
				global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Crashed, messageSourceProvider, "Unhandled exception.");
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00045328 File Offset: 0x00043528
		private void Application_ThreadException(object sender, global::System.Threading.ThreadExceptionEventArgs e)
		{
			object obj = global::Gibraltar.Monitor.Net.ExceptionListener.g_Lock;
			global::Gibraltar.Monitor.ListenerConfiguration configuration;
			lock (obj)
			{
				configuration = this.m_Configuration;
			}
			if (this.m_ThreadExceptionSourceProvider == null)
			{
				this.m_ThreadExceptionSourceProvider = new global::Gibraltar.Monitor.MessageSourceProvider("System.Windows.Forms.Application", "ThreadException");
			}
			global::System.Exception exception = e.Exception;
			if (exception != null)
			{
				if (configuration.CatchApplicationExceptions && configuration.ReportErrorsToUser)
				{
					global::Gibraltar.Monitor.Log.ReportException(this.m_ThreadExceptionSourceProvider, exception, null, "System.Exception", true, false);
					return;
				}
				global::Gibraltar.Monitor.Log.RecordException(this.m_ThreadExceptionSourceProvider, exception, null, "System.Exception", true);
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000453D0 File Offset: 0x000435D0
		private static bool AnyWindowHandleCreated()
		{
			if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
			{
				return false;
			}
			bool result;
			try
			{
				result = (bool)typeof(global::System.Windows.Forms.NativeWindow).InvokeMember("anyHandleCreatedInApp", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.GetField, null, null, null);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0004542C File Offset: 0x0004362C
		private static bool AnyWindowHandleCreatedOnThisThread()
		{
			bool result;
			try
			{
				result = (bool)typeof(global::System.Windows.Forms.NativeWindow).InvokeMember("anyHandleCreated", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.GetField, null, null, null);
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0004547C File Offset: 0x0004367C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0004548C File Offset: 0x0004368C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				this.UnregisterDomainEvents();
				this.UnregisterThreadEvents();
			}
		}

		// Token: 0x0400073A RID: 1850
		private const string LogSystem = "Gibraltar";

		// Token: 0x0400073B RID: 1851
		private const string Category = "System.Exception";

		// Token: 0x0400073C RID: 1852
		private static global::Gibraltar.Monitor.Net.ExceptionListener g_SingletonListener;

		// Token: 0x0400073D RID: 1853
		private static readonly object g_Lock = new object();

		// Token: 0x0400073E RID: 1854
		private global::Gibraltar.Monitor.ListenerConfiguration m_Configuration;

		// Token: 0x0400073F RID: 1855
		private bool m_Initialized;

		// Token: 0x04000740 RID: 1856
		private static volatile bool s_FatalException;

		// Token: 0x04000741 RID: 1857
		[global::System.ThreadStatic]
		private static bool t_PriorUIActivation;

		// Token: 0x04000742 RID: 1858
		private global::Gibraltar.Monitor.MessageSourceProvider m_UnhandledExceptionSourceProvider;

		// Token: 0x04000743 RID: 1859
		private global::Gibraltar.Monitor.MessageSourceProvider m_ThreadExceptionSourceProvider;
	}
}
