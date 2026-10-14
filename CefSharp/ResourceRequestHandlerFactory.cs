using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000094 RID: 148
	public class ResourceRequestHandlerFactory : global::CefSharp.IResourceRequestHandlerFactory
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000068F8 File Offset: 0x00004AF8
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00006900 File Offset: 0x00004B00
		public global::System.Collections.Concurrent.ConcurrentDictionary<string, global::CefSharp.ResourceRequestHandlerFactoryItem> Handlers { get; private set; }

		// Token: 0x06000439 RID: 1081 RVA: 0x00006909 File Offset: 0x00004B09
		public ResourceRequestHandlerFactory(global::System.Collections.Generic.IEqualityComparer<string> comparer = null)
		{
			this.Handlers = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::CefSharp.ResourceRequestHandlerFactoryItem>(comparer ?? global::System.StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00006928 File Offset: 0x00004B28
		public virtual bool RegisterHandler(string url, byte[] data, string mimeType = "text/html", bool oneTimeUse = false)
		{
			global::System.Uri uri;
			if (global::System.Uri.TryCreate(url, global::System.UriKind.Absolute, out uri))
			{
				global::CefSharp.ResourceRequestHandlerFactoryItem entry = new global::CefSharp.ResourceRequestHandlerFactoryItem(data, mimeType, oneTimeUse);
				this.Handlers.AddOrUpdate(uri.AbsoluteUri, entry, (string k, global::CefSharp.ResourceRequestHandlerFactoryItem v) => entry);
				return true;
			}
			return false;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000697C File Offset: 0x00004B7C
		public virtual bool UnregisterHandler(string url)
		{
			global::CefSharp.ResourceRequestHandlerFactoryItem resourceRequestHandlerFactoryItem;
			return this.Handlers.TryRemove(url, out resourceRequestHandlerFactoryItem);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00006997 File Offset: 0x00004B97
		bool global::CefSharp.IResourceRequestHandlerFactory.HasHandlers
		{
			get
			{
				return this.Handlers.Count > 0;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000069A8 File Offset: 0x00004BA8
		global::CefSharp.IResourceRequestHandler global::CefSharp.IResourceRequestHandlerFactory.GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			return this.GetResourceRequestHandler(chromiumWebBrowser, browser, frame, request, isNavigation, isDownload, requestInitiator, ref disableDefaultHandling);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000069C8 File Offset: 0x00004BC8
		protected virtual global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			global::CefSharp.IResourceRequestHandler result;
			try
			{
				global::CefSharp.ResourceRequestHandlerFactoryItem resourceRequestHandlerFactoryItem;
				if (this.Handlers.TryGetValue(request.Url, out resourceRequestHandlerFactoryItem))
				{
					if (resourceRequestHandlerFactoryItem.OneTimeUse)
					{
						this.Handlers.TryRemove(request.Url, out resourceRequestHandlerFactoryItem);
					}
					result = new global::CefSharp.Internals.InMemoryResourceRequestHandler(resourceRequestHandlerFactoryItem.Data, resourceRequestHandlerFactoryItem.MimeType);
				}
				else
				{
					result = null;
				}
			}
			finally
			{
				request.Dispose();
			}
			return result;
		}
	}
}
