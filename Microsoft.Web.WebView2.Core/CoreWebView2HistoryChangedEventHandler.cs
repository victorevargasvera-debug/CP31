using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005D RID: 93
	internal class CoreWebView2HistoryChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HistoryChangedEventHandler
	{
		// Token: 0x06000307 RID: 775 RVA: 0x00011E1B File Offset: 0x0001001B
		public CoreWebView2HistoryChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2HistoryChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00011E2C File Offset: 0x0001002C
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400019A RID: 410
		private global::Microsoft.Web.WebView2.Core.CoreWebView2HistoryChangedEventHandler.CallbackType _callback;

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x0600054D RID: 1357
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
