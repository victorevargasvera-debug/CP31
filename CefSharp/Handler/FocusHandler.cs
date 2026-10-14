using System;

namespace CefSharp.Handler
{
	// Token: 0x0200010A RID: 266
	public class FocusHandler : global::CefSharp.IFocusHandler
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x0000C976 File Offset: 0x0000AB76
		void global::CefSharp.IFocusHandler.OnGotFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnGotFocus(chromiumWebBrowser, browser);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000C980 File Offset: 0x0000AB80
		protected virtual void OnGotFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0000C982 File Offset: 0x0000AB82
		bool global::CefSharp.IFocusHandler.OnSetFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFocusSource source)
		{
			return this.OnSetFocus(chromiumWebBrowser, browser, source);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000C98D File Offset: 0x0000AB8D
		protected virtual bool OnSetFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFocusSource source)
		{
			return false;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000C990 File Offset: 0x0000AB90
		void global::CefSharp.IFocusHandler.OnTakeFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool next)
		{
			this.OnTakeFocus(chromiumWebBrowser, browser, next);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000C99B File Offset: 0x0000AB9B
		protected virtual void OnTakeFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool next)
		{
		}
	}
}
