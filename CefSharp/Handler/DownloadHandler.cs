using System;

namespace CefSharp.Handler
{
	// Token: 0x02000106 RID: 262
	public class DownloadHandler : global::CefSharp.IDownloadHandler
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x0000C852 File Offset: 0x0000AA52
		bool global::CefSharp.IDownloadHandler.CanDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string url, string requestMethod)
		{
			return this.CanDownload(chromiumWebBrowser, browser, url, requestMethod);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0000C85F File Offset: 0x0000AA5F
		protected virtual bool CanDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string url, string requestMethod)
		{
			return true;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0000C862 File Offset: 0x0000AA62
		void global::CefSharp.IDownloadHandler.OnBeforeDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IBeforeDownloadCallback callback)
		{
			this.OnBeforeDownload(chromiumWebBrowser, browser, downloadItem, callback);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000C86F File Offset: 0x0000AA6F
		protected virtual void OnBeforeDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IBeforeDownloadCallback callback)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0000C871 File Offset: 0x0000AA71
		void global::CefSharp.IDownloadHandler.OnDownloadUpdated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IDownloadItemCallback callback)
		{
			this.OnDownloadUpdated(chromiumWebBrowser, browser, downloadItem, callback);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0000C87E File Offset: 0x0000AA7E
		protected virtual void OnDownloadUpdated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IDownloadItemCallback callback)
		{
		}
	}
}
