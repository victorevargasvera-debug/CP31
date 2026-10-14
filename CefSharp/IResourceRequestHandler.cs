using System;

namespace CefSharp
{
	// Token: 0x02000066 RID: 102
	public interface IResourceRequestHandler : global::System.IDisposable
	{
		// Token: 0x0600017B RID: 379
		global::CefSharp.ICookieAccessFilter GetCookieAccessFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request);

		// Token: 0x0600017C RID: 380
		global::CefSharp.CefReturnValue OnBeforeResourceLoad(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IRequestCallback callback);

		// Token: 0x0600017D RID: 381
		global::CefSharp.IResourceHandler GetResourceHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request);

		// Token: 0x0600017E RID: 382
		void OnResourceRedirect(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, ref string newUrl);

		// Token: 0x0600017F RID: 383
		bool OnResourceResponse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response);

		// Token: 0x06000180 RID: 384
		global::CefSharp.IResponseFilter GetResourceResponseFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response);

		// Token: 0x06000181 RID: 385
		void OnResourceLoadComplete(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.UrlRequestStatus status, long receivedContentLength);

		// Token: 0x06000182 RID: 386
		bool OnProtocolExecution(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request);
	}
}
