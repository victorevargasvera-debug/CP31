using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004E RID: 78
	internal class CoreWebView2WindowCloseRequestedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowCloseRequestedEventHandler
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00011BE5 File Offset: 0x0000FDE5
		public CoreWebView2WindowCloseRequestedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2WindowCloseRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00011BF6 File Offset: 0x0000FDF6
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400018B RID: 395
		private global::Microsoft.Web.WebView2.Core.CoreWebView2WindowCloseRequestedEventHandler.CallbackType _callback;

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x06000511 RID: 1297
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
