using System;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000D2 RID: 210
	public static class GlobalContextInitialized
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0000A007 File Offset: 0x00008207
		public static global::System.Threading.Tasks.Task<bool> Task
		{
			get
			{
				return global::CefSharp.Internals.GlobalContextInitialized.TaskCompletionSource.Task;
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000A013 File Offset: 0x00008213
		public static void SetResult(bool success)
		{
			global::CefSharp.Internals.GlobalContextInitialized.TaskCompletionSource.TrySetResult(success);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000A021 File Offset: 0x00008221
		public static void SetException(global::System.Exception ex)
		{
			global::CefSharp.Internals.GlobalContextInitialized.TaskCompletionSource.TrySetException(ex);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000A030 File Offset: 0x00008230
		public static void ExecuteOrEnqueue(global::System.Action<bool> action)
		{
			global::CefSharp.Internals.GlobalContextInitialized.TaskCompletionSource.Task.ContinueWith(delegate(global::System.Threading.Tasks.Task<bool> t)
			{
				action(t.Result);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
		}

		// Token: 0x0400037F RID: 895
		private static global::System.Threading.Tasks.TaskCompletionSource<bool> TaskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<bool>();
	}
}
