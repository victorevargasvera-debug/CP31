using System;

namespace CefSharp.Handler
{
	// Token: 0x02000113 RID: 275
	public class ResourceRequestHandler : global::CefSharp.IResourceRequestHandler, global::System.IDisposable
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x0000CE59 File Offset: 0x0000B059
		global::CefSharp.ICookieAccessFilter global::CefSharp.IResourceRequestHandler.GetCookieAccessFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return this.GetCookieAccessFilter(chromiumWebBrowser, browser, frame, request);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0000CE66 File Offset: 0x0000B066
		protected virtual global::CefSharp.ICookieAccessFilter GetCookieAccessFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0000CE69 File Offset: 0x0000B069
		global::CefSharp.IResourceHandler global::CefSharp.IResourceRequestHandler.GetResourceHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return this.GetResourceHandler(chromiumWebBrowser, browser, frame, request);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0000CE76 File Offset: 0x0000B076
		protected virtual global::CefSharp.IResourceHandler GetResourceHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000CE79 File Offset: 0x0000B079
		global::CefSharp.IResponseFilter global::CefSharp.IResourceRequestHandler.GetResourceResponseFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return this.GetResourceResponseFilter(chromiumWebBrowser, browser, frame, request, response);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000CE88 File Offset: 0x0000B088
		protected virtual global::CefSharp.IResponseFilter GetResourceResponseFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000CE8B File Offset: 0x0000B08B
		global::CefSharp.CefReturnValue global::CefSharp.IResourceRequestHandler.OnBeforeResourceLoad(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IRequestCallback callback)
		{
			return this.OnBeforeResourceLoad(chromiumWebBrowser, browser, frame, request, callback);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0000CE9A File Offset: 0x0000B09A
		protected virtual global::CefSharp.CefReturnValue OnBeforeResourceLoad(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IRequestCallback callback)
		{
			return global::CefSharp.CefReturnValue.Continue;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000CE9D File Offset: 0x0000B09D
		bool global::CefSharp.IResourceRequestHandler.OnProtocolExecution(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return this.OnProtocolExecution(chromiumWebBrowser, browser, frame, request);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000CEAA File Offset: 0x0000B0AA
		protected virtual bool OnProtocolExecution(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return false;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000CEAD File Offset: 0x0000B0AD
		void global::CefSharp.IResourceRequestHandler.OnResourceLoadComplete(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.UrlRequestStatus status, long receivedContentLength)
		{
			this.OnResourceLoadComplete(chromiumWebBrowser, browser, frame, request, response, status, receivedContentLength);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		protected virtual void OnResourceLoadComplete(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.UrlRequestStatus status, long receivedContentLength)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0000CEC2 File Offset: 0x0000B0C2
		void global::CefSharp.IResourceRequestHandler.OnResourceRedirect(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, ref string newUrl)
		{
			this.OnResourceRedirect(chromiumWebBrowser, browser, frame, request, response, ref newUrl);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000CED3 File Offset: 0x0000B0D3
		protected virtual void OnResourceRedirect(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, ref string newUrl)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000CED5 File Offset: 0x0000B0D5
		bool global::CefSharp.IResourceRequestHandler.OnResourceResponse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return this.OnResourceResponse(chromiumWebBrowser, browser, frame, request, response);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		protected virtual bool OnResourceResponse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return false;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000CEE7 File Offset: 0x0000B0E7
		protected virtual void Dispose()
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000CEE9 File Offset: 0x0000B0E9
		void global::System.IDisposable.Dispose()
		{
			this.Dispose();
		}
	}
}
