using System;
using System.Collections.Generic;
using System.Data.Entity.Internal;
using System.Threading;

namespace System.Data.Entity.Core.Common.QueryCache
{
	// Token: 0x0200062F RID: 1583
	internal class QueryCacheManager : global::System.IDisposable
	{
		// Token: 0x06004C5E RID: 19550 RVA: 0x0010BD28 File Offset: 0x00109F28
		internal static global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager Create()
		{
			global::System.Data.Entity.Internal.QueryCacheConfig queryCache = global::System.Data.Entity.Internal.AppConfig.DefaultInstance.QueryCache;
			int queryCacheSize = queryCache.GetQueryCacheSize();
			int recycleMillis = queryCache.GetCleaningIntervalInSeconds() * 1000;
			return new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager(queryCacheSize, 0.8f, recycleMillis);
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x0010BD60 File Offset: 0x00109F60
		private QueryCacheManager(int maximumSize, float loadFactor, int recycleMillis)
		{
			this._maxNumberOfEntries = maximumSize;
			this._sweepingTriggerHighMark = (int)((float)this._maxNumberOfEntries * loadFactor);
			this._evictionTimer = new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager.EvictionTimer(this, recycleMillis);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		internal bool TryLookupAndAdd(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry inQueryCacheEntry, out global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry outQueryCacheEntry)
		{
			outQueryCacheEntry = null;
			object cacheDataLock = this._cacheDataLock;
			bool result;
			lock (cacheDataLock)
			{
				if (!this._cacheData.TryGetValue(inQueryCacheEntry.QueryCacheKey, out outQueryCacheEntry))
				{
					this._cacheData.Add(inQueryCacheEntry.QueryCacheKey, inQueryCacheEntry);
					if (this._cacheData.Count > this._sweepingTriggerHighMark)
					{
						this._evictionTimer.Start();
					}
					result = false;
				}
				else
				{
					outQueryCacheEntry.QueryCacheKey.UpdateHit();
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x0010BE44 File Offset: 0x0010A044
		internal bool TryCacheLookup<TK, TE>(TK key, out TE value) where TK : global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey
		{
			value = default(TE);
			global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry = null;
			bool flag = this.TryInternalCacheLookup(key, out queryCacheEntry);
			if (flag)
			{
				value = (TE)((object)queryCacheEntry.GetTarget());
			}
			return flag;
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x0010BE7C File Offset: 0x0010A07C
		internal void Clear()
		{
			object cacheDataLock = this._cacheDataLock;
			lock (cacheDataLock)
			{
				this._cacheData.Clear();
			}
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x0010BEC4 File Offset: 0x0010A0C4
		private bool TryInternalCacheLookup(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey queryCacheKey, out global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry)
		{
			queryCacheEntry = null;
			bool flag = false;
			object cacheDataLock = this._cacheDataLock;
			lock (cacheDataLock)
			{
				flag = this._cacheData.TryGetValue(queryCacheKey, out queryCacheEntry);
			}
			if (flag)
			{
				queryCacheEntry.QueryCacheKey.UpdateHit();
			}
			return flag;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x0010BF24 File Offset: 0x0010A124
		private static void CacheRecyclerHandler(object state)
		{
			((global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager)state).SweepCache();
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x0010BF34 File Offset: 0x0010A134
		private void SweepCache()
		{
			if (!this._evictionTimer.Suspend())
			{
				return;
			}
			bool flag = false;
			object cacheDataLock = this._cacheDataLock;
			lock (cacheDataLock)
			{
				if (this._cacheData.Count > this._sweepingTriggerHighMark)
				{
					uint num = 0U;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey>(this._cacheData.Count);
					list.AddRange(this._cacheData.Keys);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].HitCount == 0U)
						{
							this._cacheData.Remove(list[i]);
							num += 1U;
						}
						else
						{
							int num2 = list[i].AgingIndex + 1;
							if (num2 > global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager._agingMaxIndex)
							{
								num2 = global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager._agingMaxIndex;
							}
							list[i].AgingIndex = num2;
							list[i].HitCount = list[i].HitCount >> global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager._agingFactor[num2];
						}
					}
				}
				else
				{
					this._evictionTimer.Stop();
					flag = true;
				}
			}
			if (!flag)
			{
				this._evictionTimer.Resume();
			}
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x0010C07C File Offset: 0x0010A27C
		public void Dispose()
		{
			global::System.GC.SuppressFinalize(this);
			if (this._evictionTimer.Stop())
			{
				this.Clear();
			}
		}

		// Token: 0x04001AB5 RID: 6837
		private readonly object _cacheDataLock = new object();

		// Token: 0x04001AB6 RID: 6838
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey, global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry> _cacheData = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.QueryCache.QueryCacheKey, global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry>(32);

		// Token: 0x04001AB7 RID: 6839
		private readonly int _maxNumberOfEntries;

		// Token: 0x04001AB8 RID: 6840
		private readonly int _sweepingTriggerHighMark;

		// Token: 0x04001AB9 RID: 6841
		private readonly global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager.EvictionTimer _evictionTimer;

		// Token: 0x04001ABA RID: 6842
		private static readonly int[] _agingFactor = new int[]
		{
			1,
			1,
			2,
			4,
			8,
			16
		};

		// Token: 0x04001ABB RID: 6843
		private static readonly int _agingMaxIndex = global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager._agingFactor.Length - 1;

		// Token: 0x02000C5B RID: 3163
		private sealed class EvictionTimer
		{
			// Token: 0x06006AD2 RID: 27346 RVA: 0x0016BDF0 File Offset: 0x00169FF0
			internal EvictionTimer(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager cacheManager, int recyclePeriod)
			{
				this._cacheManager = cacheManager;
				this._period = recyclePeriod;
			}

			// Token: 0x06006AD3 RID: 27347 RVA: 0x0016BE14 File Offset: 0x0016A014
			internal void Start()
			{
				object sync = this._sync;
				lock (sync)
				{
					if (this._timer == null)
					{
						this._timer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager.CacheRecyclerHandler), this._cacheManager, this._period, this._period);
					}
				}
			}

			// Token: 0x06006AD4 RID: 27348 RVA: 0x0016BE80 File Offset: 0x0016A080
			internal bool Stop()
			{
				object sync = this._sync;
				bool result;
				lock (sync)
				{
					if (this._timer != null)
					{
						this._timer.Dispose();
						this._timer = null;
						result = true;
					}
					else
					{
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06006AD5 RID: 27349 RVA: 0x0016BEDC File Offset: 0x0016A0DC
			internal bool Suspend()
			{
				object sync = this._sync;
				bool result;
				lock (sync)
				{
					if (this._timer != null)
					{
						this._timer.Change(-1, -1);
						result = true;
					}
					else
					{
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06006AD6 RID: 27350 RVA: 0x0016BF34 File Offset: 0x0016A134
			internal void Resume()
			{
				object sync = this._sync;
				lock (sync)
				{
					if (this._timer != null)
					{
						this._timer.Change(this._period, this._period);
					}
				}
			}

			// Token: 0x040030E8 RID: 12520
			private readonly object _sync = new object();

			// Token: 0x040030E9 RID: 12521
			private readonly int _period;

			// Token: 0x040030EA RID: 12522
			private readonly global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager _cacheManager;

			// Token: 0x040030EB RID: 12523
			private global::System.Threading.Timer _timer;
		}
	}
}
