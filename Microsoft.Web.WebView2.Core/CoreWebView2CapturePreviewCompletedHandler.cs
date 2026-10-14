using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004A RID: 74
	internal class CoreWebView2CapturePreviewCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CapturePreviewCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001195C File Offset: 0x0000FB5C
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00011964 File Offset: 0x0000FB64
		public int errCode { get; private set; }

		// Token: 0x060002CA RID: 714 RVA: 0x0001196D File Offset: 0x0000FB6D
		public CoreWebView2CapturePreviewCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00011980 File Offset: 0x0000FB80
		public void Invoke(int errCode)
		{
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000119BC File Offset: 0x0000FBBC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000119CF File Offset: 0x0000FBCF
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000119D7 File Offset: 0x0000FBD7
		public bool IsCompleted { get; private set; }

		// Token: 0x060002CF RID: 719 RVA: 0x000119E0 File Offset: 0x0000FBE0
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00005F13 File Offset: 0x00004113
		public void GetResult()
		{
		}

		// Token: 0x04000180 RID: 384
		private global::System.Action continuation;
	}
}
