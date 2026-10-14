using System;

namespace CefSharp
{
	// Token: 0x02000063 RID: 99
	public interface IRequestContextHandler
	{
		// Token: 0x06000169 RID: 361
		void OnRequestContextInitialized(global::CefSharp.IRequestContext requestContext);

		// Token: 0x0600016A RID: 362
		global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling);
	}
}
