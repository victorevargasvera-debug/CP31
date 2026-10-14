using System;
using System.Security.Cryptography.X509Certificates;

namespace CefSharp.Handler
{
	// Token: 0x02000112 RID: 274
	public class RequestHandler : global::CefSharp.IRequestHandler
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x0000CD79 File Offset: 0x0000AF79
		bool global::CefSharp.IRequestHandler.OnBeforeBrowse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool userGesture, bool isRedirect)
		{
			return this.OnBeforeBrowse(chromiumWebBrowser, browser, frame, request, userGesture, isRedirect);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0000CD8A File Offset: 0x0000AF8A
		protected virtual bool OnBeforeBrowse(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool userGesture, bool isRedirect)
		{
			return false;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0000CD8D File Offset: 0x0000AF8D
		bool global::CefSharp.IRequestHandler.OnOpenUrlFromTab(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture)
		{
			return this.OnOpenUrlFromTab(chromiumWebBrowser, browser, frame, targetUrl, targetDisposition, userGesture);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0000CD9E File Offset: 0x0000AF9E
		protected virtual bool OnOpenUrlFromTab(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture)
		{
			return false;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		global::CefSharp.IResourceRequestHandler global::CefSharp.IRequestHandler.GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			return this.GetResourceRequestHandler(chromiumWebBrowser, browser, frame, request, isNavigation, isDownload, requestInitiator, ref disableDefaultHandling);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		protected virtual global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			return null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		bool global::CefSharp.IRequestHandler.GetAuthCredentials(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback)
		{
			return this.GetAuthCredentials(chromiumWebBrowser, browser, originUrl, isProxy, host, port, realm, scheme, callback);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0000CDEA File Offset: 0x0000AFEA
		protected virtual bool GetAuthCredentials(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback)
		{
			callback.Dispose();
			return false;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		bool global::CefSharp.IRequestHandler.OnCertificateError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefErrorCode errorCode, string requestUrl, global::CefSharp.ISslInfo sslInfo, global::CefSharp.IRequestCallback callback)
		{
			return this.OnCertificateError(chromiumWebBrowser, browser, errorCode, requestUrl, sslInfo, callback);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000CE05 File Offset: 0x0000B005
		protected virtual bool OnCertificateError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefErrorCode errorCode, string requestUrl, global::CefSharp.ISslInfo sslInfo, global::CefSharp.IRequestCallback callback)
		{
			callback.Dispose();
			return false;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0000CE0F File Offset: 0x0000B00F
		bool global::CefSharp.IRequestHandler.OnSelectClientCertificate(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool isProxy, string host, int port, global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, global::CefSharp.ISelectClientCertificateCallback callback)
		{
			return this.OnSelectClientCertificate(chromiumWebBrowser, browser, isProxy, host, port, certificates, callback);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0000CE22 File Offset: 0x0000B022
		protected virtual bool OnSelectClientCertificate(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool isProxy, string host, int port, global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, global::CefSharp.ISelectClientCertificateCallback callback)
		{
			callback.Dispose();
			return false;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0000CE2C File Offset: 0x0000B02C
		void global::CefSharp.IRequestHandler.OnRenderViewReady(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnRenderViewReady(chromiumWebBrowser, browser);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0000CE36 File Offset: 0x0000B036
		protected virtual void OnRenderViewReady(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000CE38 File Offset: 0x0000B038
		void global::CefSharp.IRequestHandler.OnRenderProcessTerminated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefTerminationStatus status)
		{
			this.OnRenderProcessTerminated(chromiumWebBrowser, browser, status);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000CE43 File Offset: 0x0000B043
		protected virtual void OnRenderProcessTerminated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefTerminationStatus status)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000CE45 File Offset: 0x0000B045
		void global::CefSharp.IRequestHandler.OnDocumentAvailableInMainFrame(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnDocumentAvailableInMainFrame(chromiumWebBrowser, browser);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0000CE4F File Offset: 0x0000B04F
		protected virtual void OnDocumentAvailableInMainFrame(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}
	}
}
