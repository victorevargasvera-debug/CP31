using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200004F RID: 79
	internal class CoreWebView2WebResourceResponseReceivedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventHandler
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00011C0A File Offset: 0x0000FE0A
		public CoreWebView2WebResourceResponseReceivedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs(args));
		}

		// Token: 0x0400018C RID: 396
		private global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType _callback;

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x06000515 RID: 1301
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs args);
	}
}
