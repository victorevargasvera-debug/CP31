using System;
using System.IO;

namespace CefSharp
{
	// Token: 0x02000083 RID: 131
	public interface IUrlRequestClient
	{
		// Token: 0x06000344 RID: 836
		bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, global::CefSharp.IAuthCallback callback);

		// Token: 0x06000345 RID: 837
		void OnDownloadData(global::CefSharp.IUrlRequest request, global::System.IO.Stream data);

		// Token: 0x06000346 RID: 838
		void OnDownloadProgress(global::CefSharp.IUrlRequest request, long current, long total);

		// Token: 0x06000347 RID: 839
		void OnRequestComplete(global::CefSharp.IUrlRequest request);

		// Token: 0x06000348 RID: 840
		void OnUploadProgress(global::CefSharp.IUrlRequest request, long current, long total);
	}
}
