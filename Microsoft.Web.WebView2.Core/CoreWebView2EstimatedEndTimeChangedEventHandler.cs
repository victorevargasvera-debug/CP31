using System;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000062 RID: 98
	internal class CoreWebView2EstimatedEndTimeChangedEventHandler : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EstimatedEndTimeChangedEventHandler
	{
		// Token: 0x06000311 RID: 785 RVA: 0x00011ED5 File Offset: 0x000100D5
		public CoreWebView2EstimatedEndTimeChangedEventHandler(global::Microsoft.Web.WebView2.Core.CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType callback)
		{
			this._callback = callback;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00011EE6 File Offset: 0x000100E6
		public void Invoke(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation source, object args)
		{
			this._callback(global::System.EventArgs.Empty);
		}

		// Token: 0x0400019F RID: 415
		private global::Microsoft.Web.WebView2.Core.CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType _callback;

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x06000561 RID: 1377
		public delegate void CallbackType(global::System.EventArgs args);
	}
}
