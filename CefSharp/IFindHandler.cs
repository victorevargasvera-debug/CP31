using System;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x0200005A RID: 90
	public interface IFindHandler
	{
		// Token: 0x0600014C RID: 332
		void OnFindResult(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, int identifier, int count, global::CefSharp.Structs.Rect selectionRect, int activeMatchOrdinal, bool finalUpdate);
	}
}
