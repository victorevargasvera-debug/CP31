using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000061 RID: 97
	internal class CoreWebView2FocusChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FocusChangedEventHandler
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00011EB0 File Offset: 0x000100B0
		public CoreWebView2FocusChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00011EC1 File Offset: 0x000100C1
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400019E RID: 414
		private global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler.CallbackType _callback;

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x0600055D RID: 1373
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
