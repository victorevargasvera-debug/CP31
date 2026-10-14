using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004D RID: 77
	internal class CoreWebView2ZoomFactorChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ZoomFactorChangedEventHandler
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		public CoreWebView2ZoomFactorChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2ZoomFactorChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00011BD1 File Offset: 0x0000FDD1
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400018A RID: 394
		private global::Microsoft.Web.WebView2.Core.CoreWebView2ZoomFactorChangedEventHandler.CallbackType _callback;

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x0600050D RID: 1293
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
