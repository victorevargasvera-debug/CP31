using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200006A RID: 106
	internal class CoreWebView2BytesReceivedChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BytesReceivedChangedEventHandler
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00012001 File Offset: 0x00010201
		public CoreWebView2BytesReceivedChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2BytesReceivedChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00012012 File Offset: 0x00010212
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x040001A7 RID: 423
		private global::Microsoft.Web.WebView2.Core.CoreWebView2BytesReceivedChangedEventHandler.CallbackType _callback;

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000581 RID: 1409
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
