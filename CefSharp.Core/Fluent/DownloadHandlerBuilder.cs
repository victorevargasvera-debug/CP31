using System;

namespace CefSharp.Fluent
{
	// Token: 0x02000017 RID: 23
	public class DownloadHandlerBuilder
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00003A5E File Offset: 0x00001C5E
		public global::CefSharp.Fluent.DownloadHandlerBuilder CanDownload(global::CefSharp.Fluent.CanDownloadDelegate action)
		{
			this.handler.SetCanDownload(action);
			return this;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003A6D File Offset: 0x00001C6D
		public global::CefSharp.Fluent.DownloadHandlerBuilder OnBeforeDownload(global::CefSharp.Fluent.OnBeforeDownloadDelegate action)
		{
			this.handler.SetOnBeforeDownload(action);
			return this;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00003A7C File Offset: 0x00001C7C
		public global::CefSharp.Fluent.DownloadHandlerBuilder OnDownloadUpdated(global::CefSharp.Fluent.OnDownloadUpdatedDelegate action)
		{
			this.handler.SetOnDownloadUpdated(action);
			return this;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00003A8B File Offset: 0x00001C8B
		public global::CefSharp.IDownloadHandler Build()
		{
			return this.handler;
		}

		// Token: 0x04000014 RID: 20
		private readonly global::CefSharp.Fluent.DownloadHandler handler = new global::CefSharp.Fluent.DownloadHandler();
	}
}
