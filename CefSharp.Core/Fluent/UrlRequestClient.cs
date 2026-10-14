using System;
using System.IO;

namespace CefSharp.Fluent
{
	// Token: 0x0200001D RID: 29
	public class UrlRequestClient : global::CefSharp.UrlRequestClient
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00003AA6 File Offset: 0x00001CA6
		public static global::CefSharp.Fluent.UrlRequestClientBuilder Create()
		{
			return new global::CefSharp.Fluent.UrlRequestClientBuilder();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003AAD File Offset: 0x00001CAD
		internal UrlRequestClient()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003AB5 File Offset: 0x00001CB5
		internal void SetGetAuthCredentials(global::CefSharp.Fluent.GetAuthCredentialsDelegate func)
		{
			this.getAuthCredentials = func;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003ABE File Offset: 0x00001CBE
		internal void SetOnDownloadData(global::CefSharp.Fluent.OnDownloadDataDelegate action)
		{
			this.onDownloadData = action;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003AC7 File Offset: 0x00001CC7
		internal void SetOnDownloadProgress(global::CefSharp.Fluent.OnDownloadProgressDelegate action)
		{
			this.onDownloadProgress = action;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003AD0 File Offset: 0x00001CD0
		internal void SetOnRequestComplete(global::CefSharp.Fluent.OnRequestCompleteDelegate action)
		{
			this.onRequestComplete = action;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00003AD9 File Offset: 0x00001CD9
		internal void SetOnUploadProgress(global::CefSharp.Fluent.OnUploadProgressDelegate action)
		{
			this.onUploadProgress = action;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00003AE2 File Offset: 0x00001CE2
		protected override bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback)
		{
			global::CefSharp.Fluent.GetAuthCredentialsDelegate getAuthCredentialsDelegate = this.getAuthCredentials;
			return getAuthCredentialsDelegate != null && getAuthCredentialsDelegate(isProxy, host, port, realm, scheme, callback);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00003AFE File Offset: 0x00001CFE
		protected override void OnDownloadData(global::CefSharp.IUrlRequest request, global::System.IO.Stream data)
		{
			global::CefSharp.Fluent.OnDownloadDataDelegate onDownloadDataDelegate = this.onDownloadData;
			if (onDownloadDataDelegate == null)
			{
				return;
			}
			onDownloadDataDelegate(request, data);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003B12 File Offset: 0x00001D12
		protected override void OnDownloadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
			global::CefSharp.Fluent.OnDownloadProgressDelegate onDownloadProgressDelegate = this.onDownloadProgress;
			if (onDownloadProgressDelegate == null)
			{
				return;
			}
			onDownloadProgressDelegate(request, current, total);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003B27 File Offset: 0x00001D27
		protected override void OnRequestComplete(global::CefSharp.IUrlRequest request)
		{
			global::CefSharp.Fluent.OnRequestCompleteDelegate onRequestCompleteDelegate = this.onRequestComplete;
			if (onRequestCompleteDelegate == null)
			{
				return;
			}
			onRequestCompleteDelegate(request);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003B3A File Offset: 0x00001D3A
		protected override void OnUploadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
			global::CefSharp.Fluent.OnUploadProgressDelegate onUploadProgressDelegate = this.onUploadProgress;
			if (onUploadProgressDelegate == null)
			{
				return;
			}
			onUploadProgressDelegate(request, current, total);
		}

		// Token: 0x04000015 RID: 21
		private global::CefSharp.Fluent.GetAuthCredentialsDelegate getAuthCredentials;

		// Token: 0x04000016 RID: 22
		private global::CefSharp.Fluent.OnDownloadDataDelegate onDownloadData;

		// Token: 0x04000017 RID: 23
		private global::CefSharp.Fluent.OnDownloadProgressDelegate onDownloadProgress;

		// Token: 0x04000018 RID: 24
		private global::CefSharp.Fluent.OnRequestCompleteDelegate onRequestComplete;

		// Token: 0x04000019 RID: 25
		private global::CefSharp.Fluent.OnUploadProgressDelegate onUploadProgress;
	}
}
