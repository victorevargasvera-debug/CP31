using System;

namespace CefSharp
{
	// Token: 0x0200005F RID: 95
	public interface ILifeSpanHandler
	{
		// Token: 0x0600015A RID: 346
		bool OnBeforePopup(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, string targetFrameName, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture, global::CefSharp.IPopupFeatures popupFeatures, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings browserSettings, ref bool noJavascriptAccess, out global::CefSharp.IWebBrowser newBrowser);

		// Token: 0x0600015B RID: 347
		void OnAfterCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x0600015C RID: 348
		bool DoClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x0600015D RID: 349
		void OnBeforeClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);
	}
}
