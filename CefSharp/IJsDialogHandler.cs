using System;

namespace CefSharp
{
	// Token: 0x0200005D RID: 93
	public interface IJsDialogHandler
	{
		// Token: 0x06000154 RID: 340
		bool OnJSDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, global::CefSharp.CefJsDialogType dialogType, string messageText, string defaultPromptText, global::CefSharp.IJsDialogCallback callback, ref bool suppressMessage);

		// Token: 0x06000155 RID: 341
		bool OnBeforeUnloadDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string messageText, bool isReload, global::CefSharp.IJsDialogCallback callback);

		// Token: 0x06000156 RID: 342
		void OnResetDialogState(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x06000157 RID: 343
		void OnDialogClosed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);
	}
}
