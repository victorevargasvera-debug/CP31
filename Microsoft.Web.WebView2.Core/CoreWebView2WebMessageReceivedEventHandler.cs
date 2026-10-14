using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000051 RID: 81
	internal class CoreWebView2WebMessageReceivedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventHandler
	{
		// Token: 0x060002EF RID: 751 RVA: 0x00011C56 File Offset: 0x0000FE56
		public CoreWebView2WebMessageReceivedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00011C67 File Offset: 0x0000FE67
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs(args));
		}

		// Token: 0x0400018E RID: 398
		private global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventHandler.CallbackType _callback;

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x0600051D RID: 1309
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs args);
	}
}
