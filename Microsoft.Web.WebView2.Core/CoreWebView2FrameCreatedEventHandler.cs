using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000060 RID: 96
	internal class CoreWebView2FrameCreatedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventHandler
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00011E8A File Offset: 0x0001008A
		public CoreWebView2FrameCreatedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00011E9B File Offset: 0x0001009B
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs(args));
		}

		// Token: 0x0400019D RID: 413
		private global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventHandler.CallbackType _callback;

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x06000559 RID: 1369
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs args);
	}
}
