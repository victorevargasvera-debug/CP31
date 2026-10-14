using System;

namespace CefSharp
{
	// Token: 0x02000057 RID: 87
	public interface IDownloadHandler
	{
		// Token: 0x0600013F RID: 319
		bool CanDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string url, string requestMethod);

		// Token: 0x06000140 RID: 320
		void OnBeforeDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IBeforeDownloadCallback callback);

		// Token: 0x06000141 RID: 321
		void OnDownloadUpdated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IDownloadItemCallback callback);
	}
}
