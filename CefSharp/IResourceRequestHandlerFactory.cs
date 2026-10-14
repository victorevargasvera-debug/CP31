using System;

namespace CefSharp
{
	// Token: 0x0200007D RID: 125
	public interface IResourceRequestHandlerFactory
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600032B RID: 811
		bool HasHandlers { get; }

		// Token: 0x0600032C RID: 812
		global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling);
	}
}
