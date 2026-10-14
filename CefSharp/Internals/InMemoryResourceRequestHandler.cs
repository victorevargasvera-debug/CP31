using System;

namespace CefSharp.Internals
{
	// Token: 0x020000DB RID: 219
	public sealed class InMemoryResourceRequestHandler : global::CefSharp.IResourceRequestHandler, global::System.IDisposable
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x0000A0AC File Offset: 0x000082AC
		public InMemoryResourceRequestHandler(byte[] data, string mimeType)
		{
			this.data = data;
			this.mimeType = mimeType;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000A0C2 File Offset: 0x000082C2
		public void Dispose()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000A0C4 File Offset: 0x000082C4
		global::CefSharp.ICookieAccessFilter global::CefSharp.IResourceRequestHandler.GetCookieAccessFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000A0C7 File Offset: 0x000082C7
		global::CefSharp.IResourceHandler global::CefSharp.IResourceRequestHandler.GetResourceHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return global::CefSharp.ResourceHandler.FromByteArray(this.data, this.mimeType, null);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000A0DB File Offset: 0x000082DB
		global::CefSharp.IResponseFilter global::CefSharp.IResourceRequestHandler.GetResourceResponseFilter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000A0DE File Offset: 0x000082DE
		global::CefSharp.CefReturnValue global::CefSharp.IResourceRequestHandler.OnBeforeResourceLoad(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IRequestCallback callback)
		{
			return global::CefSharp.CefReturnValue.Continue;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000A0E1 File Offset: 0x000082E1
		bool global::CefSharp.IResourceRequestHandler.OnProtocolExecution(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request)
		{
			return false;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000A0E4 File Offset: 0x000082E4
		void global::CefSharp.IResourceRequestHandler.OnResourceLoadComplete(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, global::CefSharp.UrlRequestStatus status, long receivedContentLength)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000A0E6 File Offset: 0x000082E6
		void global::CefSharp.IResourceRequestHandler.OnResourceRedirect(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response, ref string newUrl)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000A0E8 File Offset: 0x000082E8
		bool global::CefSharp.IResourceRequestHandler.OnResourceResponse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, global::CefSharp.IResponse response)
		{
			return false;
		}

		// Token: 0x04000381 RID: 897
		private readonly byte[] data;

		// Token: 0x04000382 RID: 898
		private readonly string mimeType;
	}
}
