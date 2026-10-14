using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005C RID: 92
	internal class CoreWebView2MoveFocusRequestedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventHandler
	{
		// Token: 0x06000305 RID: 773 RVA: 0x00011DF5 File Offset: 0x0000FFF5
		public CoreWebView2MoveFocusRequestedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00011E06 File Offset: 0x00010006
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs(args));
		}

		// Token: 0x04000199 RID: 409
		private global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventHandler.CallbackType _callback;

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x06000549 RID: 1353
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs args);
	}
}
