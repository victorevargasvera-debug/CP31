using System;

namespace CefSharp
{
	// Token: 0x0200006D RID: 109
	public interface ICookieManager : global::System.IDisposable
	{
		// Token: 0x0600023A RID: 570
		bool DeleteCookies(string url = null, string name = null, global::CefSharp.IDeleteCookiesCallback callback = null);

		// Token: 0x0600023B RID: 571
		bool SetCookie(string url, global::CefSharp.Cookie cookie, global::CefSharp.ISetCookieCallback callback = null);

		// Token: 0x0600023C RID: 572
		bool VisitAllCookies(global::CefSharp.ICookieVisitor visitor);

		// Token: 0x0600023D RID: 573
		bool VisitUrlCookies(string url, bool includeHttpOnly, global::CefSharp.ICookieVisitor visitor);

		// Token: 0x0600023E RID: 574
		bool FlushStore(global::CefSharp.ICompletionCallback callback);

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600023F RID: 575
		bool IsDisposed { get; }
	}
}
