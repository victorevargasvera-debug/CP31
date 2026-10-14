using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000066 RID: 102
	internal class CoreWebView2DevToolsProtocolEventReceivedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventHandler
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00011F6B File Offset: 0x0001016B
		public CoreWebView2DevToolsProtocolEventReceivedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00011F7C File Offset: 0x0001017C
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs(args));
		}

		// Token: 0x040001A3 RID: 419
		private global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType _callback;

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x06000571 RID: 1393
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs args);
	}
}
