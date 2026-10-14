using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x0200027E RID: 638
	public class IndexedDBClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001371 RID: 4977 RVA: 0x00015605 File Offset: 0x00013805
		public IndexedDBClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00015614 File Offset: 0x00013814
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearObjectStoreAsync(string databaseName, string objectStoreName, string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			dictionary.Add("objectStoreName", objectStoreName);
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IndexedDB.clearObjectStore", dictionary);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0001567C File Offset: 0x0001387C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteDatabaseAsync(string databaseName, string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IndexedDB.deleteDatabase", dictionary);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000156D4 File Offset: 0x000138D4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteObjectStoreEntriesAsync(string databaseName, string objectStoreName, global::CefSharp.DevTools.IndexedDB.KeyRange keyRange, string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			dictionary.Add("objectStoreName", objectStoreName);
			dictionary.Add("keyRange", keyRange.ToDictionary());
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IndexedDB.deleteObjectStoreEntries", dictionary);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00015750 File Offset: 0x00013950
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IndexedDB.disable", parameters);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00015770 File Offset: 0x00013970
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IndexedDB.enable", parameters);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00015790 File Offset: 0x00013990
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IndexedDB.RequestDataResponse> RequestDataAsync(string databaseName, string objectStoreName, string indexName, int skipCount, int pageSize, string securityOrigin = null, string storageKey = null, global::CefSharp.DevTools.IndexedDB.KeyRange keyRange = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			dictionary.Add("objectStoreName", objectStoreName);
			dictionary.Add("indexName", indexName);
			dictionary.Add("skipCount", skipCount);
			dictionary.Add("pageSize", pageSize);
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			if (keyRange != null)
			{
				dictionary.Add("keyRange", keyRange.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IndexedDB.RequestDataResponse>("IndexedDB.requestData", dictionary);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00015840 File Offset: 0x00013A40
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IndexedDB.GetMetadataResponse> GetMetadataAsync(string databaseName, string objectStoreName, string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			dictionary.Add("objectStoreName", objectStoreName);
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IndexedDB.GetMetadataResponse>("IndexedDB.getMetadata", dictionary);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000158A8 File Offset: 0x00013AA8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IndexedDB.RequestDatabaseResponse> RequestDatabaseAsync(string databaseName, string securityOrigin = null, string storageKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseName", databaseName);
			if (!string.IsNullOrEmpty(securityOrigin))
			{
				dictionary.Add("securityOrigin", securityOrigin);
			}
			if (!string.IsNullOrEmpty(storageKey))
			{
				dictionary.Add("storageKey", storageKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IndexedDB.RequestDatabaseResponse>("IndexedDB.requestDatabase", dictionary);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00015900 File Offset: 0x00013B00
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IndexedDB.RequestDatabaseNamesResponse> RequestDatabaseNamesAsync(string securityOrigin = null, string storageKey = null)
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
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IndexedDB.RequestDatabaseNamesResponse>("IndexedDB.requestDatabaseNames", dictionary);
		}

		// Token: 0x04000A7F RID: 2687
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
