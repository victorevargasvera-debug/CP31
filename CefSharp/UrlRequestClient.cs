using System;
using System.IO;

namespace CefSharp
{
	// Token: 0x0200009D RID: 157
	public class UrlRequestClient : global::CefSharp.IUrlRequestClient
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00006D33 File Offset: 0x00004F33
		bool global::CefSharp.IUrlRequestClient.GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback)
		{
			return this.GetAuthCredentials(isProxy, host, port, realm, scheme, callback);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00006D44 File Offset: 0x00004F44
		protected virtual bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback)
		{
			return false;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00006D47 File Offset: 0x00004F47
		void global::CefSharp.IUrlRequestClient.OnDownloadData(global::CefSharp.IUrlRequest request, global::System.IO.Stream data)
		{
			this.OnDownloadData(request, data);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00006D51 File Offset: 0x00004F51
		protected virtual void OnDownloadData(global::CefSharp.IUrlRequest request, global::System.IO.Stream data)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00006D53 File Offset: 0x00004F53
		void global::CefSharp.IUrlRequestClient.OnDownloadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
			this.OnDownloadProgress(request, current, total);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00006D5E File Offset: 0x00004F5E
		protected virtual void OnDownloadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00006D60 File Offset: 0x00004F60
		void global::CefSharp.IUrlRequestClient.OnRequestComplete(global::CefSharp.IUrlRequest request)
		{
			this.OnRequestComplete(request);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00006D69 File Offset: 0x00004F69
		protected virtual void OnRequestComplete(global::CefSharp.IUrlRequest request)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00006D6B File Offset: 0x00004F6B
		void global::CefSharp.IUrlRequestClient.OnUploadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
			this.OnUploadProgress(request, current, total);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00006D76 File Offset: 0x00004F76
		protected virtual void OnUploadProgress(global::CefSharp.IUrlRequest request, long current, long total)
		{
		}
	}
}
