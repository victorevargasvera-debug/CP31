using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000055 RID: 85
	internal class CoreWebView2RasterizationScaleChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2RasterizationScaleChangedEventHandler
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00011CED File Offset: 0x0000FEED
		public CoreWebView2RasterizationScaleChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2RasterizationScaleChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00011CFE File Offset: 0x0000FEFE
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x04000192 RID: 402
		private global::Microsoft.Web.WebView2.Core.CoreWebView2RasterizationScaleChangedEventHandler.CallbackType _callback;

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x0600052D RID: 1325
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
