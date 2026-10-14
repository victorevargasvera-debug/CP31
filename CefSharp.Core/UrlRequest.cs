using System;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x0200000F RID: 15
	public class UrlRequest : global::CefSharp.IUrlRequest, global::System.IDisposable
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000346B File Offset: 0x0000166B
		public UrlRequest(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient) : this(request, urlRequestClient, null)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003478 File Offset: 0x00001678
		public UrlRequest(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient, global::CefSharp.IRequestContext requestContext)
		{
			if (request == null)
			{
				throw new global::System.ArgumentNullException("request");
			}
			if (urlRequestClient == null)
			{
				throw new global::System.ArgumentNullException("urlRequestClient");
			}
			this.urlRequest = new global::CefSharp.Core.UrlRequest(request.UnWrap(), urlRequestClient, (requestContext != null) ? requestContext.UnWrap() : null);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000034C5 File Offset: 0x000016C5
		public bool ResponseWasCached
		{
			get
			{
				return this.urlRequest.ResponseWasCached;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000034D2 File Offset: 0x000016D2
		public global::CefSharp.IResponse Response
		{
			get
			{
				return this.urlRequest.Response;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000034DF File Offset: 0x000016DF
		public global::CefSharp.UrlRequestStatus RequestStatus
		{
			get
			{
				return this.urlRequest.RequestStatus;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000034EC File Offset: 0x000016EC
		public void Dispose()
		{
			this.urlRequest.Dispose();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000034F9 File Offset: 0x000016F9
		public global::CefSharp.IUrlRequest Create(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient)
		{
			return new global::CefSharp.Core.UrlRequest(request, urlRequestClient);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003502 File Offset: 0x00001702
		public global::CefSharp.IUrlRequest Create(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient, global::CefSharp.IRequestContext requestContext)
		{
			return new global::CefSharp.Core.UrlRequest(request, urlRequestClient, requestContext);
		}

		// Token: 0x0400000D RID: 13
		private global::CefSharp.Core.UrlRequest urlRequest;
	}
}
