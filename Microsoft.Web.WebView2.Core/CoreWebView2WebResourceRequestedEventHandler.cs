using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000050 RID: 80
	internal class CoreWebView2WebResourceRequestedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventHandler
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00011C30 File Offset: 0x0000FE30
		public CoreWebView2WebResourceRequestedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00011C41 File Offset: 0x0000FE41
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs(args));
		}

		// Token: 0x0400018D RID: 397
		private global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventHandler.CallbackType _callback;

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x06000519 RID: 1305
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs args);
	}
}
