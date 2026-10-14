using System;
using CefSharp.Core;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000007 RID: 7
	public static class ManagedCefBrowserAdapter
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002C9E File Offset: 0x00000E9E
		public static global::CefSharp.Internals.IBrowserAdapter Create(global::CefSharp.Internals.IWebBrowserInternal webBrowserInternal, bool offScreenRendering)
		{
			return new global::CefSharp.Core.ManagedCefBrowserAdapter(webBrowserInternal, offScreenRendering);
		}
	}
}
