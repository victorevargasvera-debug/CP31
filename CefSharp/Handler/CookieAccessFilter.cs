using System;

namespace CefSharp.Handler
{
	// Token: 0x02000103 RID: 259
	public class CookieAccessFilter : global::CefSharp.ICookieAccessFilter
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x0000C781 File Offset: 0x0000A981
		bool global::CefSharp.ICookieAccessFilter.CanSendCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.Cookie cookie)
		{
			return this.CanSendCookie(chromiumWebBrowser, browser, frame, request, cookie);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000C790 File Offset: 0x0000A990
		protected virtual bool CanSendCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.Cookie cookie)
		{
			return false;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0000C793 File Offset: 0x0000A993
		bool global::CefSharp.ICookieAccessFilter.CanSaveCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.Cookie cookie)
		{
			return this.CanSaveCookie(chromiumWebBrowser, browser, frame, request, response, cookie);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		protected virtual bool CanSaveCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.Cookie cookie)
		{
			return false;
		}
	}
}
