using System;
using System.Collections.Generic;

namespace NLog.Internal
{
	// Token: 0x0200010F RID: 271
	internal class MruCache<TKey, TValue>
	{
		// Token: 0x06000D0B RID: 3339 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
		public MruCache(int maxCapacity)
		{
			this._maxCapacity = maxCapacity;
			this._dictionary = new global::System.Collections.Generic.Dictionary<TKey, global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem>(this._maxCapacity);
			this._currentVersion = 1L;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0001FF08 File Offset: 0x0001E108
		public bool TryAddValue(TKey key, TValue value)
		{
			global::System.Collections.Generic.Dictionary<TKey, global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem> dictionary = this._dictionary;
			bool result;
			lock (dictionary)
			{
				global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem mruCacheItem;
				if (this._dictionary.TryGetValue(key, out mruCacheItem))
				{
					long currentVersion = this._currentVersion;
					if (mruCacheItem.Version != currentVersion || !global::System.Collections.Generic.EqualityComparer<TValue>.Default.Equals(value, mruCacheItem.Value))
					{
						this._dictionary[key] = new global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem(value, currentVersion, false);
					}
					result = false;
				}
				else
				{
					if (this._dictionary.Count >= this._maxCapacity)
					{
						this._currentVersion += 1L;
						this.PruneCache();
					}
					this._dictionary.Add(key, new global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem(value, this._currentVersion, true));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0001FFD8 File Offset: 0x0001E1D8
		private void PruneCache()
		{
			long num = this._currentVersion - 2L;
			long num2 = 1L;
			global::System.Collections.Generic.List<TKey> list = new global::System.Collections.Generic.List<TKey>((int)((double)this._dictionary.Count / 2.5));
			for (int i = 0; i < 3; i++)
			{
				long num3 = this._currentVersion - 5L;
				if (i != 0)
				{
					if (i == 1)
					{
						num3 = this._currentVersion - 10L;
					}
				}
				else
				{
					num3 = this._currentVersion - (long)((int)((double)this._maxCapacity / 1.5));
				}
				if (num3 < num2)
				{
					num3 = num2;
				}
				num2 = long.MaxValue;
				foreach (global::System.Collections.Generic.KeyValuePair<TKey, global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem> keyValuePair in this._dictionary)
				{
					long version = keyValuePair.Value.Version;
					if (version <= num3 || (keyValuePair.Value.Virgin && (i != 0 || version < num)))
					{
						list.Add(keyValuePair.Key);
						if ((double)(this._dictionary.Count - list.Count) < (double)this._maxCapacity / 1.5)
						{
							i = 3;
							break;
						}
					}
					else if (version < num2)
					{
						num2 = version;
					}
				}
			}
			foreach (TKey key in list)
			{
				this._dictionary.Remove(key);
			}
			if (this._dictionary.Count >= this._maxCapacity)
			{
				this._dictionary.Clear();
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00020190 File Offset: 0x0001E390
		public bool TryGetValue(TKey key, out TValue value)
		{
			global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem mruCacheItem;
			try
			{
				if (!this._dictionary.TryGetValue(key, out mruCacheItem))
				{
					value = default(TValue);
					return false;
				}
			}
			catch
			{
				mruCacheItem = default(global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem);
			}
			if (mruCacheItem.Version != this._currentVersion || mruCacheItem.Virgin)
			{
				global::System.Collections.Generic.Dictionary<TKey, global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem> dictionary = this._dictionary;
				lock (dictionary)
				{
					long num = this._currentVersion;
					if (!this._dictionary.TryGetValue(key, out mruCacheItem))
					{
						value = default(TValue);
						return false;
					}
					if (mruCacheItem.Version != num || mruCacheItem.Virgin)
					{
						if (mruCacheItem.Virgin)
						{
							long num2 = this._currentVersion + 1L;
							this._currentVersion = num2;
							num = num2;
						}
						this._dictionary[key] = new global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem(mruCacheItem.Value, num, false);
					}
				}
			}
			value = mruCacheItem.Value;
			return true;
		}

		// Token: 0x0400039E RID: 926
		private readonly global::System.Collections.Generic.Dictionary<TKey, global::NLog.Internal.MruCache<TKey, TValue>.MruCacheItem> _dictionary;

		// Token: 0x0400039F RID: 927
		private readonly int _maxCapacity;

		// Token: 0x040003A0 RID: 928
		private long _currentVersion;

		// Token: 0x02000209 RID: 521
		private struct MruCacheItem
		{
			// Token: 0x17000379 RID: 889
			// (get) Token: 0x060012CF RID: 4815 RVA: 0x00030D04 File Offset: 0x0002EF04
			public TValue Value { get; }

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00030D0C File Offset: 0x0002EF0C
			public long Version { get; }

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00030D14 File Offset: 0x0002EF14
			public bool Virgin { get; }

			// Token: 0x060012D2 RID: 4818 RVA: 0x00030D1C File Offset: 0x0002EF1C
			public MruCacheItem(TValue value, long version, bool virgin)
			{
				this.Value = value;
				this.Version = version;
				this.Virgin = virgin;
			}
		}
	}
}
