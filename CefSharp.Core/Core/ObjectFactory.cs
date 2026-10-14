using System;

namespace CefSharp.Core
{
	// Token: 0x02000012 RID: 18
	public static class ObjectFactory
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00003918 File Offset: 0x00001B18
		public static global::CefSharp.IBrowserSettings CreateBrowserSettings(bool autoDispose)
		{
			return new global::CefSharp.Core.BrowserSettings(autoDispose);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003920 File Offset: 0x00001B20
		public static global::CefSharp.IWindowInfo CreateWindowInfo()
		{
			return new global::CefSharp.Core.WindowInfo();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003927 File Offset: 0x00001B27
		public static global::CefSharp.IPostData CreatePostData()
		{
			return new global::CefSharp.Core.PostData();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000392E File Offset: 0x00001B2E
		public static global::CefSharp.IPostDataElement CreatePostDataElement()
		{
			return new global::CefSharp.Core.PostDataElement();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003935 File Offset: 0x00001B35
		public static global::CefSharp.IRequest CreateRequest()
		{
			return new global::CefSharp.Core.Request();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000393C File Offset: 0x00001B3C
		public static global::CefSharp.IUrlRequest CreateUrlRequest(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient)
		{
			return new global::CefSharp.Core.UrlRequest(request, urlRequestClient);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003945 File Offset: 0x00001B45
		public static global::CefSharp.IUrlRequest CreateUrlRequest(global::CefSharp.IRequest request, global::CefSharp.IUrlRequestClient urlRequestClient, global::CefSharp.IRequestContext requestContext)
		{
			return new global::CefSharp.Core.UrlRequest(request, urlRequestClient, requestContext);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000394F File Offset: 0x00001B4F
		public static global::CefSharp.IDragData CreateDragData()
		{
			return global::CefSharp.Core.DragData.Create();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003956 File Offset: 0x00001B56
		public static global::CefSharp.RequestContextBuilder ConfigureRequestContext()
		{
			return new global::CefSharp.RequestContextBuilder();
		}

		// Token: 0x0400000F RID: 15
		public static readonly global::System.Type BrowserSetingsType = typeof(global::CefSharp.Core.BrowserSettings);

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Type RequestContextType = typeof(global::CefSharp.Core.RequestContext);
	}
}
