using System;

namespace CefSharp.Fluent
{
	// Token: 0x0200001E RID: 30
	public class UrlRequestClientBuilder
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00003B4F File Offset: 0x00001D4F
		public global::CefSharp.Fluent.UrlRequestClientBuilder GetAuthCredentials(global::CefSharp.Fluent.GetAuthCredentialsDelegate func)
		{
			this.client.SetGetAuthCredentials(func);
			return this;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003B5E File Offset: 0x00001D5E
		public global::CefSharp.Fluent.UrlRequestClientBuilder OnDownloadData(global::CefSharp.Fluent.OnDownloadDataDelegate action)
		{
			this.client.SetOnDownloadData(action);
			return this;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003B6D File Offset: 0x00001D6D
		public global::CefSharp.Fluent.UrlRequestClientBuilder OnDownloadProgress(global::CefSharp.Fluent.OnDownloadProgressDelegate action)
		{
			this.client.SetOnDownloadProgress(action);
			return this;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003B7C File Offset: 0x00001D7C
		public global::CefSharp.Fluent.UrlRequestClientBuilder OnRequestComplete(global::CefSharp.Fluent.OnRequestCompleteDelegate action)
		{
			this.client.SetOnRequestComplete(action);
			return this;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003B8B File Offset: 0x00001D8B
		public global::CefSharp.Fluent.UrlRequestClientBuilder OnUploadProgress(global::CefSharp.Fluent.OnUploadProgressDelegate action)
		{
			this.client.SetOnUploadProgress(action);
			return this;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003B9A File Offset: 0x00001D9A
		public global::CefSharp.IUrlRequestClient Build()
		{
			return this.client;
		}

		// Token: 0x0400001A RID: 26
		private global::CefSharp.Fluent.UrlRequestClient client = new global::CefSharp.Fluent.UrlRequestClient();
	}
}
