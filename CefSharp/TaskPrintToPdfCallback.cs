using System;
using System.Threading.Tasks;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000018 RID: 24
	public sealed class TaskPrintToPdfCallback : global::CefSharp.IPrintToPdfCallback, global::System.IDisposable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000022DA File Offset: 0x000004DA
		public global::System.Threading.Tasks.Task<bool> Task
		{
			get
			{
				return this.taskCompletionSource.Task;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022E7 File Offset: 0x000004E7
		void global::CefSharp.IPrintToPdfCallback.OnPdfPrintFinished(string path, bool ok)
		{
			this.onComplete = true;
			this.taskCompletionSource.TrySetResultAsync(ok);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000022FC File Offset: 0x000004FC
		bool global::CefSharp.IPrintToPdfCallback.IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002308 File Offset: 0x00000508
		void global::System.IDisposable.Dispose()
		{
			global::System.Threading.Tasks.Task<bool> task = this.taskCompletionSource.Task;
			if (!this.onComplete && !task.IsCompleted)
			{
				this.taskCompletionSource.TrySetResultAsync(false);
			}
			this.isDisposed = true;
		}

		// Token: 0x0400000B RID: 11
		private readonly global::System.Threading.Tasks.TaskCompletionSource<bool> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<bool>();

		// Token: 0x0400000C RID: 12
		private volatile bool isDisposed;

		// Token: 0x0400000D RID: 13
		private bool onComplete;
	}
}
