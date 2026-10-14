using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013F RID: 319
	public class StorageClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public StorageClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060009D0 RID: 2512 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		// (remove) Token: 0x060009D1 RID: 2513 RVA: 0x0000C1DA File Offset: 0x0000A3DA
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.CacheStorageContentUpdatedEventArgs> CacheStorageContentUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.CacheStorageContentUpdatedEventArgs>("Storage.cacheStorageContentUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.CacheStorageContentUpdatedEventArgs>("Storage.cacheStorageContentUpdated", value);
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060009D2 RID: 2514 RVA: 0x0000C1EE File Offset: 0x0000A3EE
		// (remove) Token: 0x060009D3 RID: 2515 RVA: 0x0000C201 File Offset: 0x0000A401
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.CacheStorageListUpdatedEventArgs> CacheStorageListUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.CacheStorageListUpdatedEventArgs>("Storage.cacheStorageListUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.CacheStorageListUpdatedEventArgs>("Storage.cacheStorageListUpdated", value);
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060009D4 RID: 2516 RVA: 0x0000C215 File Offset: 0x0000A415
		// (remove) Token: 0x060009D5 RID: 2517 RVA: 0x0000C228 File Offset: 0x0000A428
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.IndexedDBContentUpdatedEventArgs> IndexedDBContentUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.IndexedDBContentUpdatedEventArgs>("Storage.indexedDBContentUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.IndexedDBContentUpdatedEventArgs>("Storage.indexedDBContentUpdated", value);
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060009D6 RID: 2518 RVA: 0x0000C23C File Offset: 0x0000A43C
		// (remove) Token: 0x060009D7 RID: 2519 RVA: 0x0000C24F File Offset: 0x0000A44F
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.IndexedDBListUpdatedEventArgs> IndexedDBListUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.IndexedDBListUpdatedEventArgs>("Storage.indexedDBListUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.IndexedDBListUpdatedEventArgs>("Storage.indexedDBListUpdated", value);
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060009D8 RID: 2520 RVA: 0x0000C263 File Offset: 0x0000A463
		// (remove) Token: 0x060009D9 RID: 2521 RVA: 0x0000C276 File Offset: 0x0000A476
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.InterestGroupAccessedEventArgs> InterestGroupAccessed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.InterestGroupAccessedEventArgs>("Storage.interestGroupAccessed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.InterestGroupAccessedEventArgs>("Storage.interestGroupAccessed", value);
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060009DA RID: 2522 RVA: 0x0000C28A File Offset: 0x0000A48A
		// (remove) Token: 0x060009DB RID: 2523 RVA: 0x0000C29D File Offset: 0x0000A49D
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.SharedStorageAccessedEventArgs> SharedStorageAccessed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.SharedStorageAccessedEventArgs>("Storage.sharedStorageAccessed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.SharedStorageAccessedEventArgs>("Storage.sharedStorageAccessed", value);
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060009DC RID: 2524 RVA: 0x0000C2B1 File Offset: 0x0000A4B1
		// (remove) Token: 0x060009DD RID: 2525 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.StorageBucketCreatedOrUpdatedEventArgs> StorageBucketCreatedOrUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.StorageBucketCreatedOrUpdatedEventArgs>("Storage.storageBucketCreatedOrUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.StorageBucketCreatedOrUpdatedEventArgs>("Storage.storageBucketCreatedOrUpdated", value);
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060009DE RID: 2526 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		// (remove) Token: 0x060009DF RID: 2527 RVA: 0x0000C2EB File Offset: 0x0000A4EB
		public event global::System.EventHandler<global::CefSharp.DevTools.Storage.StorageBucketDeletedEventArgs> StorageBucketDeleted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Storage.StorageBucketDeletedEventArgs>("Storage.storageBucketDeleted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Storage.StorageBucketDeletedEventArgs>("Storage.storageBucketDeleted", value);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0000C300 File Offset: 0x0000A500
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetStorageKeyForFrameResponse> GetStorageKeyForFrameAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetStorageKeyForFrameResponse>("Storage.getStorageKeyForFrame", dictionary);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000C330 File Offset: 0x0000A530
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearDataForOriginAsync(string origin, string storageTypes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			dictionary.Add("storageTypes", storageTypes);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.clearDataForOrigin", dictionary);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000C36C File Offset: 0x0000A56C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearDataForStorageKeyAsync(string storageKey, string storageTypes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			dictionary.Add("storageTypes", storageTypes);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.clearDataForStorageKey", dictionary);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetCookiesResponse> GetCookiesAsync(string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetCookiesResponse>("Storage.getCookies", dictionary);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetCookiesAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.CookieParam> cookies, string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cookies", from x in cookies
			select x.ToDictionary());
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.setCookies", dictionary);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000C448 File Offset: 0x0000A648
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearCookiesAsync(string browserContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(browserContextId))
			{
				dictionary.Add("browserContextId", browserContextId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.clearCookies", dictionary);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000C480 File Offset: 0x0000A680
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetUsageAndQuotaResponse> GetUsageAndQuotaAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetUsageAndQuotaResponse>("Storage.getUsageAndQuota", dictionary);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> OverrideQuotaForOriginAsync(string origin, double? quotaSize = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			if (quotaSize != null)
			{
				dictionary.Add("quotaSize", quotaSize.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.overrideQuotaForOrigin", dictionary);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0000C500 File Offset: 0x0000A700
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TrackCacheStorageForOriginAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.trackCacheStorageForOrigin", dictionary);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000C530 File Offset: 0x0000A730
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TrackCacheStorageForStorageKeyAsync(string storageKey)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.trackCacheStorageForStorageKey", dictionary);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0000C560 File Offset: 0x0000A760
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TrackIndexedDBForOriginAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.trackIndexedDBForOrigin", dictionary);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0000C590 File Offset: 0x0000A790
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TrackIndexedDBForStorageKeyAsync(string storageKey)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.trackIndexedDBForStorageKey", dictionary);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UntrackCacheStorageForOriginAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.untrackCacheStorageForOrigin", dictionary);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UntrackCacheStorageForStorageKeyAsync(string storageKey)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.untrackCacheStorageForStorageKey", dictionary);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000C620 File Offset: 0x0000A820
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UntrackIndexedDBForOriginAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.untrackIndexedDBForOrigin", dictionary);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0000C650 File Offset: 0x0000A850
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UntrackIndexedDBForStorageKeyAsync(string storageKey)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.untrackIndexedDBForStorageKey", dictionary);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000C680 File Offset: 0x0000A880
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetTrustTokensResponse> GetTrustTokensAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetTrustTokensResponse>("Storage.getTrustTokens", parameters);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.ClearTrustTokensResponse> ClearTrustTokensAsync(string issuerOrigin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("issuerOrigin", issuerOrigin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.ClearTrustTokensResponse>("Storage.clearTrustTokens", dictionary);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetInterestGroupDetailsResponse> GetInterestGroupDetailsAsync(string ownerOrigin, string name)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			dictionary.Add("name", name);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetInterestGroupDetailsResponse>("Storage.getInterestGroupDetails", dictionary);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0000C70C File Offset: 0x0000A90C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInterestGroupTrackingAsync(bool enable)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enable", enable);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.setInterestGroupTracking", dictionary);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0000C744 File Offset: 0x0000A944
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetSharedStorageMetadataResponse> GetSharedStorageMetadataAsync(string ownerOrigin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetSharedStorageMetadataResponse>("Storage.getSharedStorageMetadata", dictionary);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000C774 File Offset: 0x0000A974
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.GetSharedStorageEntriesResponse> GetSharedStorageEntriesAsync(string ownerOrigin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.GetSharedStorageEntriesResponse>("Storage.getSharedStorageEntries", dictionary);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSharedStorageEntryAsync(string ownerOrigin, string key, string value, bool? ignoreIfPresent = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			dictionary.Add("key", key);
			dictionary.Add("value", value);
			if (ignoreIfPresent != null)
			{
				dictionary.Add("ignoreIfPresent", ignoreIfPresent.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.setSharedStorageEntry", dictionary);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteSharedStorageEntryAsync(string ownerOrigin, string key)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			dictionary.Add("key", key);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.deleteSharedStorageEntry", dictionary);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0000C848 File Offset: 0x0000AA48
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearSharedStorageEntriesAsync(string ownerOrigin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.clearSharedStorageEntries", dictionary);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0000C878 File Offset: 0x0000AA78
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResetSharedStorageBudgetAsync(string ownerOrigin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ownerOrigin", ownerOrigin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.resetSharedStorageBudget", dictionary);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSharedStorageTrackingAsync(bool enable)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enable", enable);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.setSharedStorageTracking", dictionary);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetStorageBucketTrackingAsync(string storageKey, bool enable)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			dictionary.Add("enable", enable);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.setStorageBucketTracking", dictionary);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0000C924 File Offset: 0x0000AB24
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteStorageBucketAsync(string storageKey, string bucketName)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("storageKey", storageKey);
			dictionary.Add("bucketName", bucketName);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Storage.deleteStorageBucket", dictionary);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0000C960 File Offset: 0x0000AB60
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Storage.RunBounceTrackingMitigationsResponse> RunBounceTrackingMitigationsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Storage.RunBounceTrackingMitigationsResponse>("Storage.runBounceTrackingMitigations", parameters);
		}

		// Token: 0x04000474 RID: 1140
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
