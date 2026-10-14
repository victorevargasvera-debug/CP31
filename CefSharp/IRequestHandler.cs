using System;
using System.Security.Cryptography.X509Certificates;

namespace CefSharp
{
	// Token: 0x02000064 RID: 100
	public interface IRequestHandler
	{
		// Token: 0x0600016B RID: 363
		bool OnBeforeBrowse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool userGesture, bool isRedirect);

		// Token: 0x0600016C RID: 364
		void OnDocumentAvailableInMainFrame(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x0600016D RID: 365
		bool OnOpenUrlFromTab(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture);

		// Token: 0x0600016E RID: 366
		global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling);

		// Token: 0x0600016F RID: 367
		bool GetAuthCredentials(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback);

		// Token: 0x06000170 RID: 368
		bool OnCertificateError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefErrorCode errorCode, string requestUrl, global::CefSharp.ISslInfo sslInfo, global::CefSharp.IRequestCallback callback);

		// Token: 0x06000171 RID: 369
		bool OnSelectClientCertificate(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool isProxy, string host, int port, global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, global::CefSharp.ISelectClientCertificateCallback callback);

		// Token: 0x06000172 RID: 370
		void OnRenderViewReady(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x06000173 RID: 371
		void OnRenderProcessTerminated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefTerminationStatus status);
	}
}
