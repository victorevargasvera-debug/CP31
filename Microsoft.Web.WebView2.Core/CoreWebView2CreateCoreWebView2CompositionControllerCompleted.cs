using System;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000049 RID: 73
	internal class CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler, global::System.Runtime.CompilerServices.INotifyCompletion
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0001187C File Offset: 0x0000FA7C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00011884 File Offset: 0x0000FA84
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController webView { get; private set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0001188D File Offset: 0x0000FA8D
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00011895 File Offset: 0x0000FA95
		public int errCode { get; private set; }

		// Token: 0x060002C1 RID: 705 RVA: 0x0001189E File Offset: 0x0000FA9E
		public CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler()
		{
			this.IsCompleted = false;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000118B0 File Offset: 0x0000FAB0
		public void Invoke(int errCode, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController webView)
		{
			this.webView = new global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController(webView);
			this.errCode = errCode;
			this.IsCompleted = true;
			bool flag = this.continuation != null;
			if (flag)
			{
				this.continuation();
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000118F8 File Offset: 0x0000FAF8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler GetAwaiter()
		{
			return this;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001190B File Offset: 0x0000FB0B
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00011913 File Offset: 0x0000FB13
		public bool IsCompleted { get; private set; }

		// Token: 0x060002C6 RID: 710 RVA: 0x0001191C File Offset: 0x0000FB1C
		public void OnCompleted(global::System.Action continuation)
		{
			this.continuation = continuation;
			bool isCompleted = this.IsCompleted;
			if (isCompleted)
			{
				continuation();
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00011944 File Offset: 0x0000FB44
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CompositionController GetResult()
		{
			return this.webView;
		}

		// Token: 0x0400017D RID: 381
		private global::System.Action continuation;
	}
}
