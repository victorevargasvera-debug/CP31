using System;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000CB RID: 203
	public static class CefThread
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0000992F File Offset: 0x00007B2F
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00009936 File Offset: 0x00007B36
		public static global::System.Threading.Tasks.TaskFactory UiThreadTaskFactory { get; private set; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000605 RID: 1541 RVA: 0x00009940 File Offset: 0x00007B40
		// (remove) Token: 0x06000606 RID: 1542 RVA: 0x00009974 File Offset: 0x00007B74
		public static event global::System.EventHandler Initialized;

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000099A7 File Offset: 0x00007BA7
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000099AE File Offset: 0x00007BAE
		public static global::System.Func<bool> CurrentOnUiThreadDelegate { get; private set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000099B6 File Offset: 0x00007BB6
		public static bool CanExecuteOnUiThread
		{
			get
			{
				return global::CefSharp.Internals.CefThread.UiThreadTaskFactory != null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000099C0 File Offset: 0x00007BC0
		public static bool CurrentlyOnUiThread
		{
			get
			{
				global::System.Func<bool> currentOnUiThreadDelegate = global::CefSharp.Internals.CefThread.CurrentOnUiThreadDelegate;
				return currentOnUiThreadDelegate != null && currentOnUiThreadDelegate();
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000099DE File Offset: 0x00007BDE
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000099E5 File Offset: 0x00007BE5
		public static bool HasShutdown { get; private set; }

		// Token: 0x0600060D RID: 1549 RVA: 0x000099F0 File Offset: 0x00007BF0
		public static global::System.Threading.Tasks.Task<TResult> ExecuteOnUiThread<TResult>(global::System.Func<TResult> function)
		{
			object lockObj = global::CefSharp.Internals.CefThread.LockObj;
			global::System.Threading.Tasks.Task<TResult> result;
			lock (lockObj)
			{
				if (global::CefSharp.Internals.CefThread.HasShutdown)
				{
					throw new global::System.Exception("Cef.Shutdown has already been called, it's no longer possible to execute on the CEF UI Thread. Check CefThread.HasShutdown to guard against this execption");
				}
				global::System.Threading.Tasks.TaskFactory uiThreadTaskFactory = global::CefSharp.Internals.CefThread.UiThreadTaskFactory;
				if (uiThreadTaskFactory == null)
				{
					result = global::CefSharp.Internals.CefThread.QueueForExcutionWhenUiThreadCreated<TResult>(function);
				}
				else
				{
					result = uiThreadTaskFactory.StartNew<TResult>(function);
				}
			}
			return result;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00009A58 File Offset: 0x00007C58
		public static global::System.Threading.Tasks.Task ExecuteOnUiThread(global::System.Action action)
		{
			object lockObj = global::CefSharp.Internals.CefThread.LockObj;
			global::System.Threading.Tasks.Task result;
			lock (lockObj)
			{
				if (global::CefSharp.Internals.CefThread.HasShutdown)
				{
					throw new global::System.Exception("Cef.Shutdown has already been called, it's no longer possible to execute on the CEF UI Thread. Check CefThread.HasShutdown to guard against this execption");
				}
				global::System.Threading.Tasks.TaskFactory uiThreadTaskFactory = global::CefSharp.Internals.CefThread.UiThreadTaskFactory;
				if (uiThreadTaskFactory == null)
				{
					result = global::CefSharp.Internals.CefThread.QueueForExcutionWhenUiThreadCreated(action);
				}
				else
				{
					result = uiThreadTaskFactory.StartNew(action);
				}
			}
			return result;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00009AC0 File Offset: 0x00007CC0
		private static global::System.Threading.Tasks.Task QueueForExcutionWhenUiThreadCreated(global::System.Action action)
		{
			global::System.Threading.Tasks.TaskCompletionSource<bool> tcs = new global::System.Threading.Tasks.TaskCompletionSource<bool>();
			global::System.EventHandler handler = null;
			handler = delegate(object s, global::System.EventArgs args)
			{
				global::CefSharp.Internals.CefThread.Initialized -= handler;
				try
				{
					action();
					tcs.TrySetResult(true);
				}
				catch (global::System.Exception exception)
				{
					tcs.TrySetException(exception);
				}
			};
			global::CefSharp.Internals.CefThread.Initialized += handler;
			return tcs.Task;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00009B14 File Offset: 0x00007D14
		private static global::System.Threading.Tasks.Task<T> QueueForExcutionWhenUiThreadCreated<T>(global::System.Func<T> func)
		{
			global::System.Threading.Tasks.TaskCompletionSource<T> tcs = new global::System.Threading.Tasks.TaskCompletionSource<T>();
			global::System.EventHandler handler = null;
			handler = delegate(object s, global::System.EventArgs args)
			{
				global::CefSharp.Internals.CefThread.Initialized -= handler;
				try
				{
					T result = func();
					tcs.TrySetResult(result);
				}
				catch (global::System.Exception exception)
				{
					tcs.TrySetException(exception);
				}
			};
			global::CefSharp.Internals.CefThread.Initialized += handler;
			return tcs.Task;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00009B68 File Offset: 0x00007D68
		public static void Initialize(global::System.Threading.Tasks.TaskFactory uiThreadTaskFactory, global::System.Func<bool> currentOnUiThreadDelegate)
		{
			object lockObj = global::CefSharp.Internals.CefThread.LockObj;
			lock (lockObj)
			{
				global::System.EventHandler initialized = global::CefSharp.Internals.CefThread.Initialized;
				if (initialized != null)
				{
					initialized(null, global::System.EventArgs.Empty);
				}
				global::CefSharp.Internals.CefThread.UiThreadTaskFactory = uiThreadTaskFactory;
				global::CefSharp.Internals.CefThread.CurrentOnUiThreadDelegate = currentOnUiThreadDelegate;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00009BC4 File Offset: 0x00007DC4
		public static void Shutdown()
		{
			object lockObj = global::CefSharp.Internals.CefThread.LockObj;
			lock (lockObj)
			{
				global::CefSharp.Internals.CefThread.CurrentOnUiThreadDelegate = null;
				global::CefSharp.Internals.CefThread.Initialized = null;
				global::CefSharp.Internals.CefThread.UiThreadTaskFactory = null;
				global::CefSharp.Internals.CefThread.HasShutdown = true;
			}
		}

		// Token: 0x04000371 RID: 881
		private static readonly object LockObj = new object();
	}
}
