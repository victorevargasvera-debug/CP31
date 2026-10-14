using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000065 RID: 101
	internal class CoreWebView2DocumentTitleChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DocumentTitleChangedEventHandler
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00011F46 File Offset: 0x00010146
		public CoreWebView2DocumentTitleChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2DocumentTitleChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00011F57 File Offset: 0x00010157
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x040001A2 RID: 418
		private global::Microsoft.Web.WebView2.Core.CoreWebView2DocumentTitleChangedEventHandler.CallbackType _callback;

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x0600056D RID: 1389
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
