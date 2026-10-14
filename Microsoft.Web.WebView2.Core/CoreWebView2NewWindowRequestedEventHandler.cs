using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000058 RID: 88
	internal class CoreWebView2NewWindowRequestedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventHandler
	{
		// Token: 0x060002FD RID: 765 RVA: 0x00011D5E File Offset: 0x0000FF5E
		public CoreWebView2NewWindowRequestedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00011D6F File Offset: 0x0000FF6F
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs(args));
		}

		// Token: 0x04000195 RID: 405
		private global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventHandler.CallbackType _callback;

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x06000539 RID: 1337
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs args);
	}
}
