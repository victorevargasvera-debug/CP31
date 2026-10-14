using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000064 RID: 100
	internal class CoreWebView2DOMContentLoadedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventHandler
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00011F20 File Offset: 0x00010120
		public CoreWebView2DOMContentLoadedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00011F31 File Offset: 0x00010131
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs(args));
		}

		// Token: 0x040001A1 RID: 417
		private global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventHandler.CallbackType _callback;

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x06000569 RID: 1385
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs args);
	}
}
