using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000052 RID: 82
	internal class CoreWebView2StateChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StateChangedEventHandler
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00011C7C File Offset: 0x0000FE7C
		public CoreWebView2StateChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2StateChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00011C8D File Offset: 0x0000FE8D
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400018F RID: 399
		private global::Microsoft.Web.WebView2.Core.CoreWebView2StateChangedEventHandler.CallbackType _callback;

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x06000521 RID: 1313
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
