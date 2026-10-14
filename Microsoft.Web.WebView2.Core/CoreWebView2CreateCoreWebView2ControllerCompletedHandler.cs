using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000048 RID: 72
	internal class CoreWebView2CreateCoreWebView2ControllerCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2ControllerCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001179C File Offset: 0x0000F99C
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000117A4 File Offset: 0x0000F9A4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Controller createdController { get; private set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000117AD File Offset: 0x0000F9AD
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000117B5 File Offset: 0x0000F9B5
		public int errCode { get; private set; }

		// Token: 0x060002B6 RID: 694 RVA: 0x000117BE File Offset: 0x0000F9BE
		public CoreWebView2CreateCoreWebView2ControllerCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000117D0 File Offset: 0x0000F9D0
		public void Invoke(int errCode, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller createdController)
		{
			this.createdController = new global::Microsoft.Web.WebView2.Core.CoreWebView2Controller(createdController);
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00011818 File Offset: 0x0000FA18
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CreateCoreWebView2ControllerCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0001182B File Offset: 0x0000FA2B
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00011833 File Offset: 0x0000FA33
		public bool IsCompleted { get; private set; }

		// Token: 0x060002BB RID: 699 RVA: 0x0001183C File Offset: 0x0000FA3C
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00011864 File Offset: 0x0000FA64
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Controller GetResult()
		{
			return this.createdController;
		}

		// Token: 0x04000179 RID: 377
		private global::System.Action continuation;
	}
}
