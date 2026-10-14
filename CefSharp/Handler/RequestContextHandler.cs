using System;
using System.Collections.Generic;

namespace CefSharp.Handler
{
	// Token: 0x02000111 RID: 273
	public class RequestContextHandler : global::CefSharp.IRequestContextHandler
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0000CC4F File Offset: 0x0000AE4F
		public global::CefSharp.Handler.RequestContextHandler OnInitialize(global::System.Action<global::CefSharp.IRequestContext> onContextInitialziedAction)
		{
			this.onContextInitialziedAction = onContextInitialziedAction;
			return this;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0000CC59 File Offset: 0x0000AE59
		public global::CefSharp.Handler.RequestContextHandler SetPreferenceOnContextInitialized(string name, object value)
		{
			if (this.requestContextInitialized)
			{
				throw new global::System.Exception("RequestContext has already been initialized, ");
			}
			this.preferences.Add(new global::System.Collections.Generic.KeyValuePair<string, object>(name, value));
			return this;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000CC81 File Offset: 0x0000AE81
		public global::CefSharp.Handler.RequestContextHandler SetProxyOnContextInitialized(string host, int? port = null)
		{
			return this.SetProxyOnContextInitialized(null, host, port);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		public global::CefSharp.Handler.RequestContextHandler SetProxyOnContextInitialized(string scheme, string host, int? port)
		{
			if (this.requestContextInitialized)
			{
				throw new global::System.Exception("RequestContext has already been initialized, ");
			}
			global::System.Collections.Generic.IDictionary<string, object> proxyDictionary = global::CefSharp.RequestContextExtensions.GetProxyDictionary(scheme, host, port);
			this.preferences.Add(new global::System.Collections.Generic.KeyValuePair<string, object>("proxy", proxyDictionary));
			return this;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000CCCC File Offset: 0x0000AECC
		global::CefSharp.IResourceRequestHandler global::CefSharp.IRequestContextHandler.GetResourceRequestHandler(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			return this.GetResourceRequestHandler(browser, frame, request, isNavigation, isDownload, requestInitiator, ref disableDefaultHandling);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0000CCDF File Offset: 0x0000AEDF
		protected virtual global::CefSharp.IResourceRequestHandler GetResourceRequestHandler(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
		{
			return null;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		void global::CefSharp.IRequestContextHandler.OnRequestContextInitialized(global::CefSharp.IRequestContext requestContext)
		{
			this.requestContextInitialized = true;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in this.preferences)
			{
				string text;
				requestContext.SetPreference(keyValuePair.Key, keyValuePair.Value, out text);
			}
			global::System.Action<global::CefSharp.IRequestContext> action = this.onContextInitialziedAction;
			if (action != null)
			{
				action(requestContext);
			}
			this.OnRequestContextInitialized(requestContext);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0000CD64 File Offset: 0x0000AF64
		protected virtual void OnRequestContextInitialized(global::CefSharp.IRequestContext requestContext)
		{
		}

		// Token: 0x040003DF RID: 991
		private readonly global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, object>> preferences = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, object>>();

		// Token: 0x040003E0 RID: 992
		private bool requestContextInitialized;

		// Token: 0x040003E1 RID: 993
		private global::System.Action<global::CefSharp.IRequestContext> onContextInitialziedAction;
	}
}
