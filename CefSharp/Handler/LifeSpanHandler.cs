using System;

namespace CefSharp.Handler
{
	// Token: 0x0200010E RID: 270
	public class LifeSpanHandler : global::CefSharp.ILifeSpanHandler
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x0000CB15 File Offset: 0x0000AD15
		bool global::CefSharp.ILifeSpanHandler.DoClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			return this.DoClose(chromiumWebBrowser, browser);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000CB1F File Offset: 0x0000AD1F
		protected virtual bool DoClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			return !browser.IsPopup;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		void global::CefSharp.ILifeSpanHandler.OnAfterCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnAfterCreated(chromiumWebBrowser, browser);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000CB36 File Offset: 0x0000AD36
		protected virtual void OnAfterCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000CB38 File Offset: 0x0000AD38
		void global::CefSharp.ILifeSpanHandler.OnBeforeClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnBeforeClose(chromiumWebBrowser, browser);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000CB42 File Offset: 0x0000AD42
		protected virtual void OnBeforeClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000CB44 File Offset: 0x0000AD44
		bool global::CefSharp.ILifeSpanHandler.OnBeforePopup(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, string targetFrameName, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture, global::CefSharp.IPopupFeatures popupFeatures, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings browserSettings, ref bool noJavascriptAccess, out global::CefSharp.IWebBrowser newBrowser)
		{
			return this.OnBeforePopup(chromiumWebBrowser, browser, frame, targetUrl, targetFrameName, targetDisposition, userGesture, popupFeatures, windowInfo, browserSettings, ref noJavascriptAccess, out newBrowser);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		protected virtual bool OnBeforePopup(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, string targetFrameName, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture, global::CefSharp.IPopupFeatures popupFeatures, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings browserSettings, ref bool noJavascriptAccess, out global::CefSharp.IWebBrowser newBrowser)
		{
			newBrowser = null;
			return false;
		}
	}
}
