using System;
using System.Threading.Tasks;
using CefSharp.Handler;

namespace CefSharp.Internals
{
	// Token: 0x020000DA RID: 218
	public class InitializeAsyncBrowserProcessHandler : global::CefSharp.Handler.BrowserProcessHandler
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x0000A088 File Offset: 0x00008288
		public InitializeAsyncBrowserProcessHandler(global::System.Threading.Tasks.TaskCompletionSource<bool> tcs)
		{
			this.taskCompletionSource = tcs;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000A097 File Offset: 0x00008297
		protected override void OnContextInitialized()
		{
			base.OnContextInitialized();
			this.taskCompletionSource.TrySetResult(true);
		}

		// Token: 0x04000380 RID: 896
		private global::System.Threading.Tasks.TaskCompletionSource<bool> taskCompletionSource;
	}
}
