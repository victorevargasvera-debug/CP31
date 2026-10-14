using System;
using CefSharp.Structs;

namespace CefSharp.Handler
{
	// Token: 0x02000109 RID: 265
	public class FindHandler : global::CefSharp.IFindHandler
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x0000C959 File Offset: 0x0000AB59
		void global::CefSharp.IFindHandler.OnFindResult(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, int identifier, int count, global::CefSharp.Structs.Rect selectionRect, int activeMatchOrdinal, bool finalUpdate)
		{
			this.OnFindResult(chromiumWebBrowser, browser, identifier, count, selectionRect, activeMatchOrdinal, finalUpdate);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0000C96C File Offset: 0x0000AB6C
		protected virtual void OnFindResult(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, int identifier, int count, global::CefSharp.Structs.Rect selectionRect, int activeMatchOrdinal, bool finalUpdate)
		{
		}
	}
}
