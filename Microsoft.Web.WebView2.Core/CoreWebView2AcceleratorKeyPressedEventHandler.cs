using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200006B RID: 107
	internal class CoreWebView2AcceleratorKeyPressedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventHandler
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00012026 File Offset: 0x00010226
		public CoreWebView2AcceleratorKeyPressedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00012037 File Offset: 0x00010237
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs(args));
		}

		// Token: 0x040001A8 RID: 424
		private global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType _callback;

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x06000585 RID: 1413
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs args);
	}
}
