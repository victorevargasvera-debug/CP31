using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x0200029D RID: 669
	public class DOMStorageClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600142B RID: 5163 RVA: 0x00016806 File Offset: 0x00014A06
		public DOMStorageClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x0600142C RID: 5164 RVA: 0x00016815 File Offset: 0x00014A15
		// (remove) Token: 0x0600142D RID: 5165 RVA: 0x00016828 File Offset: 0x00014A28
		public event global::System.EventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemAddedEventArgs> DomStorageItemAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemAddedEventArgs>("DOMStorage.domStorageItemAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemAddedEventArgs>("DOMStorage.domStorageItemAdded", value);
			}
		}

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x0600142E RID: 5166 RVA: 0x0001683C File Offset: 0x00014A3C
		// (remove) Token: 0x0600142F RID: 5167 RVA: 0x0001684F File Offset: 0x00014A4F
		public event global::System.EventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemRemovedEventArgs> DomStorageItemRemoved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemRemovedEventArgs>("DOMStorage.domStorageItemRemoved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemRemovedEventArgs>("DOMStorage.domStorageItemRemoved", value);
			}
		}

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06001430 RID: 5168 RVA: 0x00016863 File Offset: 0x00014A63
		// (remove) Token: 0x06001431 RID: 5169 RVA: 0x00016876 File Offset: 0x00014A76
		public event global::System.EventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemUpdatedEventArgs> DomStorageItemUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemUpdatedEventArgs>("DOMStorage.domStorageItemUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemUpdatedEventArgs>("DOMStorage.domStorageItemUpdated", value);
			}
		}

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x06001432 RID: 5170 RVA: 0x0001688A File Offset: 0x00014A8A
		// (remove) Token: 0x06001433 RID: 5171 RVA: 0x0001689D File Offset: 0x00014A9D
		public event global::System.EventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemsClearedEventArgs> DomStorageItemsCleared
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemsClearedEventArgs>("DOMStorage.domStorageItemsCleared", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.DOMStorage.DomStorageItemsClearedEventArgs>("DOMStorage.domStorageItemsCleared", value);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000168B4 File Offset: 0x00014AB4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearAsync(global::CefSharp.DevTools.DOMStorage.StorageId storageId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageId", storageId.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMStorage.clear", dictionary);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000168EC File Offset: 0x00014AEC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMStorage.disable", parameters);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0001690C File Offset: 0x00014B0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMStorage.enable", parameters);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0001692C File Offset: 0x00014B2C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DOMStorage.GetDOMStorageItemsResponse> GetDOMStorageItemsAsync(global::CefSharp.DevTools.DOMStorage.StorageId storageId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageId", storageId.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DOMStorage.GetDOMStorageItemsResponse>("DOMStorage.getDOMStorageItems", dictionary);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00016964 File Offset: 0x00014B64
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveDOMStorageItemAsync(global::CefSharp.DevTools.DOMStorage.StorageId storageId, string key)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageId", storageId.ToDictionary());
			dictionary.Add("key", key);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMStorage.removeDOMStorageItem", dictionary);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x000169A8 File Offset: 0x00014BA8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDOMStorageItemAsync(global::CefSharp.DevTools.DOMStorage.StorageId storageId, string key, string value)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageId", storageId.ToDictionary());
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("DOMStorage.setDOMStorageItem", dictionary);
		}

		// Token: 0x04000AD4 RID: 2772
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
