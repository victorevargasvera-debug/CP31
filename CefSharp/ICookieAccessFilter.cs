using System;

namespace CefSharp
{
	// Token: 0x02000054 RID: 84
	public interface ICookieAccessFilter
	{
		// Token: 0x06000132 RID: 306
		bool CanSendCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.Cookie cookie);

		// Token: 0x06000133 RID: 307
		bool CanSaveCookie(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.Cookie cookie);
	}
}
