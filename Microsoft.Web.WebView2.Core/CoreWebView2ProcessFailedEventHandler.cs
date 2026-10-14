using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000056 RID: 86
	internal class CoreWebView2ProcessFailedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventHandler
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00011D12 File Offset: 0x0000FF12
		public CoreWebView2ProcessFailedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00011D23 File Offset: 0x0000FF23
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs(args));
		}

		// Token: 0x04000193 RID: 403
		private global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventHandler.CallbackType _callback;

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x06000531 RID: 1329
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs args);
	}
}
