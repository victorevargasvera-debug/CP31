using System;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000016 RID: 22
	public sealed class TaskCompletionCallback : global::CefSharp.ICompletionCallback, global::System.IDisposable
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000021DB File Offset: 0x000003DB
		public TaskCompletionCallback()
		{
			this.taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<bool>();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021EE File Offset: 0x000003EE
		void global::CefSharp.ICompletionCallback.OnComplete()
		{
			this.onComplete = true;
			this.taskCompletionSource.TrySetResultAsync(true);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002203 File Offset: 0x00000403
		public global::System.Threading.Tasks.Task<bool> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002210 File Offset: 0x00000410
		bool global::CefSharp.ICompletionCallback.IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000221C File Offset: 0x0000041C
		void global::System.IDisposable.Dispose()
		{
			global::System.Threading.Tasks.Task<bool> task = this.taskCompletionSource.Task;
			if (!this.onComplete && !task.IsCompleted)
			{
				this.taskCompletionSource.TrySetResultAsync(false);
			}
			this.isDisposed = true;
		}

		// Token: 0x04000004 RID: 4
		private readonly global::System.Threading.Tasks.TaskCompletionSource<bool> taskCompletionSource;

		// Token: 0x04000005 RID: 5
		private volatile bool isDisposed;

		// Token: 0x04000006 RID: 6
		private bool onComplete;
	}
}
