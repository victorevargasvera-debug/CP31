using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000063 RID: 99
	internal class CoreWebView2DownloadStartingEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventHandler
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00011EFA File Offset: 0x000100FA
		public CoreWebView2DownloadStartingEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00011F0B File Offset: 0x0001010B
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs(args));
		}

		// Token: 0x040001A0 RID: 416
		private global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventHandler.CallbackType _callback;

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x06000565 RID: 1381
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs args);
	}
}
