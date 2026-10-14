using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000068 RID: 104
	internal class CoreWebView2ContentLoadingEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventHandler
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00011FB6 File Offset: 0x000101B6
		public CoreWebView2ContentLoadingEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00011FC7 File Offset: 0x000101C7
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs(args));
		}

		// Token: 0x040001A5 RID: 421
		private global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventHandler.CallbackType _callback;

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x06000579 RID: 1401
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs args);
	}
}
