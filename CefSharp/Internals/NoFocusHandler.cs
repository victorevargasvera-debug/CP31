using System;

namespace CefSharp.Internals
{
	// Token: 0x020000EB RID: 235
	public class NoFocusHandler : global::CefSharp.IFocusHandler
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x0000B7E8 File Offset: 0x000099E8
		void global::CefSharp.IFocusHandler.OnGotFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000B7EA File Offset: 0x000099EA
		bool global::CefSharp.IFocusHandler.OnSetFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFocusSource source)
		{
			return !browser.IsPopup;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000B7F7 File Offset: 0x000099F7
		void global::CefSharp.IFocusHandler.OnTakeFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool next)
		{
		}
	}
}
