using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000069 RID: 105
	internal class CoreWebView2ContainsFullScreenElementChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContainsFullScreenElementChangedEventHandler
	{
		// Token: 0x0600031F RID: 799 RVA: 0x00011FDC File Offset: 0x000101DC
		public CoreWebView2ContainsFullScreenElementChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00011FED File Offset: 0x000101ED
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x040001A6 RID: 422
		private global::Microsoft.Web.WebView2.Core.CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType _callback;

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x0600057D RID: 1405
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
