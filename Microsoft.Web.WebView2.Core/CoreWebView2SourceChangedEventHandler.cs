using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000053 RID: 83
	internal class CoreWebView2SourceChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventHandler
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x00011CA1 File Offset: 0x0000FEA1
		public CoreWebView2SourceChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00011CB2 File Offset: 0x0000FEB2
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs(args));
		}

		// Token: 0x04000190 RID: 400
		private global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventHandler.CallbackType _callback;

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000525 RID: 1317
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs args);
	}
}
