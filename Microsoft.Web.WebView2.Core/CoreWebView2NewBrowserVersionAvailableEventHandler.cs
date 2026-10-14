using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000059 RID: 89
	internal class CoreWebView2NewBrowserVersionAvailableEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewBrowserVersionAvailableEventHandler
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00011D84 File Offset: 0x0000FF84
		public CoreWebView2NewBrowserVersionAvailableEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00011D95 File Offset: 0x0000FF95
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x04000196 RID: 406
		private global::Microsoft.Web.WebView2.Core.CoreWebView2NewBrowserVersionAvailableEventHandler.CallbackType _callback;

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x0600053D RID: 1341
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
