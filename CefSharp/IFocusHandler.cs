using System;

namespace CefSharp
{
	// Token: 0x0200005B RID: 91
	public interface IFocusHandler
	{
		// Token: 0x0600014D RID: 333
		void OnGotFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x0600014E RID: 334
		bool OnSetFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFocusSource source);

		// Token: 0x0600014F RID: 335
		void OnTakeFocus(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool next);
	}
}
