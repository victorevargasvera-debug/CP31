using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002F3 RID: 755
	public class CacheStorageClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001701 RID: 5889 RVA: 0x00019492 File Offset: 0x00017692
		public CacheStorageClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000194A4 File Offset: 0x000176A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteCacheAsync(string cacheId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cacheId", cacheId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CacheStorage.deleteCache", dictionary);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000194D4 File Offset: 0x000176D4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteEntryAsync(string cacheId, string request)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cacheId", cacheId);
			dictionary.Add("request", request);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("CacheStorage.deleteEntry", dictionary);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00019510 File Offset: 0x00017710
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CacheStorage.RequestCacheNamesResponse> RequestCacheNamesAsync(string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CacheStorage.RequestCacheNamesResponse>("CacheStorage.requestCacheNames", dictionary);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0001955C File Offset: 0x0001775C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CacheStorage.RequestCachedResponseResponse> RequestCachedResponseAsync(string cacheId, string requestURL, global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.Header> requestHeaders)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cacheId", cacheId);
			dictionary.Add("requestURL", requestURL);
			dictionary.Add("requestHeaders", from x in requestHeaders
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CacheStorage.RequestCachedResponseResponse>("CacheStorage.requestCachedResponse", dictionary);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000195C8 File Offset: 0x000177C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.CacheStorage.RequestEntriesResponse> RequestEntriesAsync(string cacheId, int? skipCount = null, int? pageSize = null, string pathFilter = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cacheId", cacheId);
			if (skipCount != null)
			{
				dictionary.Add("skipCount", skipCount.Value);
			}
			if (pageSize != null)
			{
				dictionary.Add("pageSize", pageSize.Value);
			}
			if (!string.IsNullOrEmpty(pathFilter))
			{
				dictionary.Add("pathFilter", pathFilter);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.CacheStorage.RequestEntriesResponse>("CacheStorage.requestEntries", dictionary);
		}

		// Token: 0x04000C06 RID: 3078
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
