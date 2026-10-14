using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000044 RID: 68
	internal class CoreWebView2TrySuspendCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2TrySuspendCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00011418 File Offset: 0x0000F618
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00011420 File Offset: 0x0000F620
		public bool isSuccessful { get; private set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00011429 File Offset: 0x0000F629
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00011431 File Offset: 0x0000F631
		public int errCode { get; private set; }

		// Token: 0x0600028A RID: 650 RVA: 0x0001143A File Offset: 0x0000F63A
		public CoreWebView2TrySuspendCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001144C File Offset: 0x0000F64C
		public void Invoke(int errCode, int isSuccessful)
		{
			this.isSuccessful = (isSuccessful != 0);
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00011494 File Offset: 0x0000F694
		public global::Microsoft.Web.WebView2.Core.CoreWebView2TrySuspendCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000114A7 File Offset: 0x0000F6A7
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000114AF File Offset: 0x0000F6AF
		public bool IsCompleted { get; private set; }

		// Token: 0x0600028F RID: 655 RVA: 0x000114B8 File Offset: 0x0000F6B8
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public bool GetResult()
		{
			return this.isSuccessful;
		}

		// Token: 0x04000169 RID: 361
		private global::System.Action continuation;
	}
}
