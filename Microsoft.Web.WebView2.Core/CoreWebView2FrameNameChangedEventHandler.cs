using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005E RID: 94
	internal class CoreWebView2FrameNameChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameNameChangedEventHandler
	{
		// Token: 0x06000309 RID: 777 RVA: 0x00011E40 File Offset: 0x00010040
		public CoreWebView2FrameNameChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2FrameNameChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00011E51 File Offset: 0x00010051
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400019B RID: 411
		private global::Microsoft.Web.WebView2.Core.CoreWebView2FrameNameChangedEventHandler.CallbackType _callback;

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x06000551 RID: 1361
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
