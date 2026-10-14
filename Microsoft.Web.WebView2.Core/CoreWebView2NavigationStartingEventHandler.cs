using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200005A RID: 90
	internal class CoreWebView2NavigationStartingEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventHandler
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		public CoreWebView2NavigationStartingEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00011DBA File Offset: 0x0000FFBA
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs(args));
		}

		// Token: 0x04000197 RID: 407
		private global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler.CallbackType _callback;

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000541 RID: 1345
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs args);
	}
}
