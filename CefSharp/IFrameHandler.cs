using System;

namespace CefSharp
{
	// Token: 0x0200005C RID: 92
	public interface IFrameHandler
	{
		// Token: 0x06000150 RID: 336
		void OnFrameAttached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, bool reattached);

		// Token: 0x06000151 RID: 337
		void OnFrameCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame);

		// Token: 0x06000152 RID: 338
		void OnFrameDetached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame);

		// Token: 0x06000153 RID: 339
		void OnMainFrameChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame oldFrame, global::CefSharp.IFrame newFrame);
	}
}
