using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005F RID: 95
	internal class CoreWebView2FrameDestroyedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameDestroyedEventHandler
	{
		// Token: 0x0600030B RID: 779 RVA: 0x00011E65 File Offset: 0x00010065
		public CoreWebView2FrameDestroyedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2FrameDestroyedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00011E76 File Offset: 0x00010076
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400019C RID: 412
		private global::Microsoft.Web.WebView2.Core.CoreWebView2FrameDestroyedEventHandler.CallbackType _callback;

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x06000555 RID: 1365
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
