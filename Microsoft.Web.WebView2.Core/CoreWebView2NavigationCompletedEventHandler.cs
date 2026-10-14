using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005B RID: 91
	internal class CoreWebView2NavigationCompletedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventHandler
	{
		// Token: 0x06000303 RID: 771 RVA: 0x00011DCF File Offset: 0x0000FFCF
		public CoreWebView2NavigationCompletedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs(args));
		}

		// Token: 0x04000198 RID: 408
		private global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler.CallbackType _callback;

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x06000545 RID: 1349
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs args);
	}
}
