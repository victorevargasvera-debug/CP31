using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000067 RID: 103
	internal class CoreWebView2CursorChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CursorChangedEventHandler
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00011F91 File Offset: 0x00010191
		public CoreWebView2CursorChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2CursorChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011FA2 File Offset: 0x000101A2
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x040001A4 RID: 420
		private global::Microsoft.Web.WebView2.Core.CoreWebView2CursorChangedEventHandler.CallbackType _callback;

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x06000575 RID: 1397
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
