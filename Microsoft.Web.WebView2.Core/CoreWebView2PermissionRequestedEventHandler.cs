using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000057 RID: 87
	internal class CoreWebView2PermissionRequestedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventHandler
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00011D38 File Offset: 0x0000FF38
		public CoreWebView2PermissionRequestedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00011D49 File Offset: 0x0000FF49
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs(args));
		}

		// Token: 0x04000194 RID: 404
		private global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventHandler.CallbackType _callback;

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000535 RID: 1333
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs args);
	}
}
