using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000019 RID: 25
	public sealed class TaskResolveCallback : global::CefSharp.IResolveCallback, global::System.IDisposable
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002359 File Offset: 0x00000559
		public TaskResolveCallback()
		{
			this.taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.ResolveCallbackResult>();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000236C File Offset: 0x0000056C
		void global::CefSharp.IResolveCallback.OnResolveCompleted(global::CefSharp.CefErrorCode result, global::System.Collections.Generic.IList<string> resolvedIpAddresses)
		{
			this.onComplete = true;
			this.taskCompletionSource.TrySetResultAsync(new global::CefSharp.ResolveCallbackResult(result, resolvedIpAddresses));
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002387 File Offset: 0x00000587
		bool global::CefSharp.IResolveCallback.IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002391 File Offset: 0x00000591
		public global::System.Threading.Tasks.Task<global::CefSharp.ResolveCallbackResult> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000023A0 File Offset: 0x000005A0
		void global::System.IDisposable.Dispose()
		{
			global::System.Threading.Tasks.Task<global::CefSharp.ResolveCallbackResult> task = this.taskCompletionSource.Task;
			if (!this.onComplete && !task.IsCompleted)
			{
				this.taskCompletionSource.TrySetResultAsync(new global::CefSharp.ResolveCallbackResult(global::CefSharp.CefErrorCode.Unexpected, null));
			}
			this.isDisposed = true;
		}

		// Token: 0x0400000E RID: 14
		private readonly global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.ResolveCallbackResult> taskCompletionSource;

		// Token: 0x0400000F RID: 15
		private volatile bool isDisposed;

		// Token: 0x04000010 RID: 16
		private bool onComplete;
	}
}
