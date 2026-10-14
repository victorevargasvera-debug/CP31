using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000054 RID: 84
	internal class CoreWebView2ScriptDialogOpeningEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventHandler
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00011CC7 File Offset: 0x0000FEC7
		public CoreWebView2ScriptDialogOpeningEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00011CD8 File Offset: 0x0000FED8
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 source, global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs args)
		{
			this._callback(new global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs(args));
		}

		// Token: 0x04000191 RID: 401
		private global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventHandler.CallbackType _callback;

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000529 RID: 1321
		public delegate void CallbackType(global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs args);
	}
}
