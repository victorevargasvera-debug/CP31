using System;

namespace CefSharp
{
	// Token: 0x02000062 RID: 98
	public interface IRenderProcessMessageHandler
	{
		// Token: 0x06000165 RID: 357
		void OnContextCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame);

		// Token: 0x06000166 RID: 358
		void OnContextReleased(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame);

		// Token: 0x06000167 RID: 359
		void OnFocusedNodeChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IDomNode node);

		// Token: 0x06000168 RID: 360
		void OnUncaughtException(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.JavascriptException exception);
	}
}
