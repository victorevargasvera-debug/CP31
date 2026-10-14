using System;
using System.IO;
using CefSharp.Handler;

namespace CefSharp.Fluent
{
	// Token: 0x02000016 RID: 22
	public class DownloadHandler : global::CefSharp.Handler.DownloadHandler
	{
		// Token: 0x06000162 RID: 354 RVA: 0x0000397D File Offset: 0x00001B7D
		public static global::CefSharp.Fluent.DownloadHandlerBuilder Create()
		{
			return new global::CefSharp.Fluent.DownloadHandlerBuilder();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003984 File Offset: 0x00001B84
		public static global::CefSharp.IDownloadHandler UseFolder(string folder, global::CefSharp.Fluent.OnDownloadUpdatedDelegate downloadUpdated = null)
		{
			return global::CefSharp.Fluent.DownloadHandler.Create().OnBeforeDownload(delegate(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem item, global::CefSharp.IBeforeDownloadCallback callback)
			{
				try
				{
					string downloadPath = global::System.IO.Path.Combine(folder, item.SuggestedFileName);
					callback.Continue(downloadPath, false);
				}
				finally
				{
					if (callback != null)
					{
						callback.Dispose();
					}
				}
			}).OnDownloadUpdated(downloadUpdated).Build();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000039BF File Offset: 0x00001BBF
		public static global::CefSharp.IDownloadHandler AskUser(global::CefSharp.Fluent.OnDownloadUpdatedDelegate downloadUpdated = null)
		{
			return global::CefSharp.Fluent.DownloadHandler.Create().OnBeforeDownload(delegate(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem item, global::CefSharp.IBeforeDownloadCallback callback)
			{
				try
				{
					callback.Continue("", true);
				}
				finally
				{
					if (callback != null)
					{
						callback.Dispose();
					}
				}
			}).OnDownloadUpdated(downloadUpdated).Build();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000039F5 File Offset: 0x00001BF5
		internal DownloadHandler()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000039FD File Offset: 0x00001BFD
		internal void SetCanDownload(global::CefSharp.Fluent.CanDownloadDelegate action)
		{
			this.canDownload = action;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003A06 File Offset: 0x00001C06
		internal void SetOnBeforeDownload(global::CefSharp.Fluent.OnBeforeDownloadDelegate action)
		{
			this.onBeforeDownload = action;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003A0F File Offset: 0x00001C0F
		internal void SetOnDownloadUpdated(global::CefSharp.Fluent.OnDownloadUpdatedDelegate action)
		{
			this.onDownloadUpdated = action;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00003A18 File Offset: 0x00001C18
		protected override bool CanDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string url, string requestMethod)
		{
			global::CefSharp.Fluent.CanDownloadDelegate canDownloadDelegate = this.canDownload;
			return canDownloadDelegate == null || canDownloadDelegate(chromiumWebBrowser, browser, url, requestMethod);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003A30 File Offset: 0x00001C30
		protected override void OnBeforeDownload(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IBeforeDownloadCallback callback)
		{
			global::CefSharp.Fluent.OnBeforeDownloadDelegate onBeforeDownloadDelegate = this.onBeforeDownload;
			if (onBeforeDownloadDelegate == null)
			{
				return;
			}
			onBeforeDownloadDelegate(chromiumWebBrowser, browser, downloadItem, callback);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00003A47 File Offset: 0x00001C47
		protected override void OnDownloadUpdated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.DownloadItem downloadItem, global::CefSharp.IDownloadItemCallback callback)
		{
			global::CefSharp.Fluent.OnDownloadUpdatedDelegate onDownloadUpdatedDelegate = this.onDownloadUpdated;
			if (onDownloadUpdatedDelegate == null)
			{
				return;
			}
			onDownloadUpdatedDelegate(chromiumWebBrowser, browser, downloadItem, callback);
		}

		// Token: 0x04000011 RID: 17
		private global::CefSharp.Fluent.CanDownloadDelegate canDownload;

		// Token: 0x04000012 RID: 18
		private global::CefSharp.Fluent.OnBeforeDownloadDelegate onBeforeDownload;

		// Token: 0x04000013 RID: 19
		private global::CefSharp.Fluent.OnDownloadUpdatedDelegate onDownloadUpdated;
	}
}
