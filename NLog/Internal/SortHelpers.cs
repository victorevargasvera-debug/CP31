using System;
using System.Collections;
using System.Collections.Generic;

namespace NLog.Internal
{
	// Token: 0x02000124 RID: 292
	internal static class SortHelpers
	{
		// Token: 0x06000D9E RID: 3486 RVA: 0x00022330 File Offset: 0x00020530
		public static global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.List<TValue>> BucketSort<TValue, TKey>(this global::System.Collections.Generic.IEnumerable<TValue> inputs, global::NLog.Internal.SortHelpers.KeySelector<TValue, TKey> keySelector)
		{
			global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.List<TValue>> dictionary = new global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.List<TValue>>();
			foreach (TValue tvalue in inputs)
			{
				TKey key = keySelector(tvalue);
				global::System.Collections.Generic.List<TValue> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new global::System.Collections.Generic.List<TValue>();
					dictionary.Add(key, list);
				}
				list.Add(tvalue);
			}
			return dictionary;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000223A4 File Offset: 0x000205A4
		public static global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, global::System.Collections.Generic.IList<TValue>> BucketSort<TValue, TKey>(this global::System.Collections.Generic.IList<TValue> inputs, global::NLog.Internal.SortHelpers.KeySelector<TValue, TKey> keySelector)
		{
			return inputs.BucketSort(keySelector, global::System.Collections.Generic.EqualityComparer<TKey>.Default);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000223B4 File Offset: 0x000205B4
		public static global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, global::System.Collections.Generic.IList<TValue>> BucketSort<TValue, TKey>(this global::System.Collections.Generic.IList<TValue> inputs, global::NLog.Internal.SortHelpers.KeySelector<TValue, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer)
		{
			global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.IList<TValue>> dictionary = null;
			bool flag = false;
			TKey tkey = default(TKey);
			for (int i = 0; i < inputs.Count; i++)
			{
				TKey tkey2 = keySelector(inputs[i]);
				if (!flag)
				{
					flag = true;
					tkey = tkey2;
				}
				else if (dictionary == null)
				{
					if (!keyComparer.Equals(tkey, tkey2))
					{
						dictionary = new global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.IList<TValue>>(keyComparer);
						global::System.Collections.Generic.List<TValue> list = new global::System.Collections.Generic.List<TValue>(i);
						for (int j = 0; j < i; j++)
						{
							list.Add(inputs[j]);
						}
						dictionary[tkey] = list;
						dictionary[tkey2] = new global::System.Collections.Generic.List<TValue>
						{
							inputs[i]
						};
					}
				}
				else
				{
					global::System.Collections.Generic.IList<TValue> list2;
					if (!dictionary.TryGetValue(tkey2, out list2))
					{
						list2 = new global::System.Collections.Generic.List<TValue>();
						dictionary.Add(tkey2, list2);
					}
					list2.Add(inputs[i]);
				}
			}
			if (dictionary != null)
			{
				return new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, global::System.Collections.Generic.IList<TValue>>(dictionary, keyComparer);
			}
			return new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, global::System.Collections.Generic.IList<TValue>>(new global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>>(tkey, inputs), keyComparer);
		}

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x06001309 RID: 4873
		internal delegate TKey KeySelector<in TValue, out TKey>(TValue value);

		// Token: 0x02000219 RID: 537
		public struct ReadOnlySingleBucketDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000386 RID: 902
			// (get) Token: 0x0600130C RID: 4876 RVA: 0x0003144B File Offset: 0x0002F64B
			public global::System.Collections.Generic.IEqualityComparer<TKey> Comparer
			{
				get
				{
					return this._comparer;
				}
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x00031453 File Offset: 0x0002F653
			public ReadOnlySingleBucketDictionary(global::System.Collections.Generic.KeyValuePair<TKey, TValue> singleBucket)
			{
				this = new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>(singleBucket, global::System.Collections.Generic.EqualityComparer<TKey>.Default);
			}

			// Token: 0x0600130E RID: 4878 RVA: 0x00031461 File Offset: 0x0002F661
			public ReadOnlySingleBucketDictionary(global::System.Collections.Generic.Dictionary<TKey, TValue> multiBucket)
			{
				this = new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>(multiBucket, global::System.Collections.Generic.EqualityComparer<TKey>.Default);
			}

			// Token: 0x0600130F RID: 4879 RVA: 0x0003146F File Offset: 0x0002F66F
			public ReadOnlySingleBucketDictionary(global::System.Collections.Generic.KeyValuePair<TKey, TValue> singleBucket, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
			{
				this._comparer = comparer;
				this._multiBucket = null;
				this._singleBucket = new global::System.Collections.Generic.KeyValuePair<TKey, TValue>?(singleBucket);
			}

			// Token: 0x06001310 RID: 4880 RVA: 0x0003148C File Offset: 0x0002F68C
			public ReadOnlySingleBucketDictionary(global::System.Collections.Generic.Dictionary<TKey, TValue> multiBucket, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
			{
				this._comparer = comparer;
				this._multiBucket = multiBucket;
				this._singleBucket = new global::System.Collections.Generic.KeyValuePair<TKey, TValue>?(default(global::System.Collections.Generic.KeyValuePair<TKey, TValue>));
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06001311 RID: 4881 RVA: 0x000314BC File Offset: 0x0002F6BC
			public int Count
			{
				get
				{
					if (this._multiBucket != null)
					{
						return this._multiBucket.Count;
					}
					if (this._singleBucket != null)
					{
						return 1;
					}
					return 0;
				}
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06001312 RID: 4882 RVA: 0x000314F0 File Offset: 0x0002F6F0
			public global::System.Collections.Generic.ICollection<TKey> Keys
			{
				get
				{
					if (this._multiBucket != null)
					{
						return this._multiBucket.Keys;
					}
					if (this._singleBucket != null)
					{
						return new TKey[]
						{
							this._singleBucket.Value.Key
						};
					}
					return global::NLog.Internal.ArrayHelper.Empty<TKey>();
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06001313 RID: 4883 RVA: 0x0003154C File Offset: 0x0002F74C
			public global::System.Collections.Generic.ICollection<TValue> Values
			{
				get
				{
					if (this._multiBucket != null)
					{
						return this._multiBucket.Values;
					}
					if (this._singleBucket != null)
					{
						return new TValue[]
						{
							this._singleBucket.Value.Value
						};
					}
					return global::NLog.Internal.ArrayHelper.Empty<TValue>();
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06001314 RID: 4884 RVA: 0x000315A6 File Offset: 0x0002F7A6
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700038B RID: 907
			public TValue this[TKey key]
			{
				get
				{
					if (this._multiBucket != null)
					{
						return this._multiBucket[key];
					}
					if (this._singleBucket != null && this._comparer.Equals(this._singleBucket.Value.Key, key))
					{
						return this._singleBucket.Value.Value;
					}
					throw new global::System.Collections.Generic.KeyNotFoundException();
				}
				set
				{
					throw new global::System.NotSupportedException("Readonly");
				}
			}

			// Token: 0x06001317 RID: 4887 RVA: 0x0003162C File Offset: 0x0002F82C
			public global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>.Enumerator GetEnumerator()
			{
				if (this._multiBucket != null)
				{
					return new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>.Enumerator(this._multiBucket);
				}
				if (this._singleBucket != null)
				{
					return new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>.Enumerator(this._singleBucket.Value);
				}
				return new global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<TKey, TValue>.Enumerator(new global::System.Collections.Generic.Dictionary<TKey, TValue>());
			}

			// Token: 0x06001318 RID: 4888 RVA: 0x0003167B File Offset: 0x0002F87B
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06001319 RID: 4889 RVA: 0x00031688 File Offset: 0x0002F888
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0600131A RID: 4890 RVA: 0x00031698 File Offset: 0x0002F898
			public bool ContainsKey(TKey key)
			{
				if (this._multiBucket != null)
				{
					return this._multiBucket.ContainsKey(key);
				}
				return this._singleBucket != null && this._comparer.Equals(this._singleBucket.Value.Key, key);
			}

			// Token: 0x0600131B RID: 4891 RVA: 0x000316EE File Offset: 0x0002F8EE
			public void Add(TKey key, TValue value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600131C RID: 4892 RVA: 0x000316F5 File Offset: 0x0002F8F5
			public bool Remove(TKey key)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600131D RID: 4893 RVA: 0x000316FC File Offset: 0x0002F8FC
			public bool TryGetValue(TKey key, out TValue value)
			{
				if (this._multiBucket != null)
				{
					return this._multiBucket.TryGetValue(key, out value);
				}
				if (this._singleBucket != null && this._comparer.Equals(this._singleBucket.Value.Key, key))
				{
					value = this._singleBucket.Value.Value;
					return true;
				}
				value = default(TValue);
				return false;
			}

			// Token: 0x0600131E RID: 4894 RVA: 0x00031779 File Offset: 0x0002F979
			public void Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600131F RID: 4895 RVA: 0x00031780 File Offset: 0x0002F980
			public void Clear()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06001320 RID: 4896 RVA: 0x00031788 File Offset: 0x0002F988
			public bool Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
			{
				if (this._multiBucket != null)
				{
					return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>)this._multiBucket).Contains(item);
				}
				return this._singleBucket != null && this._comparer.Equals(this._singleBucket.Value.Key, item.Key) && global::System.Collections.Generic.EqualityComparer<TValue>.Default.Equals(this._singleBucket.Value.Value, item.Value);
			}

			// Token: 0x06001321 RID: 4897 RVA: 0x00031810 File Offset: 0x0002FA10
			public void CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				if (this._multiBucket != null)
				{
					((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>)this._multiBucket).CopyTo(array, arrayIndex);
					return;
				}
				if (this._singleBucket != null)
				{
					array[arrayIndex] = this._singleBucket.Value;
				}
			}

			// Token: 0x06001322 RID: 4898 RVA: 0x00031858 File Offset: 0x0002FA58
			public bool Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x040005EC RID: 1516
			private readonly global::System.Collections.Generic.KeyValuePair<TKey, TValue>? _singleBucket;

			// Token: 0x040005ED RID: 1517
			private readonly global::System.Collections.Generic.Dictionary<TKey, TValue> _multiBucket;

			// Token: 0x040005EE RID: 1518
			private readonly global::System.Collections.Generic.IEqualityComparer<TKey> _comparer;

			// Token: 0x02000253 RID: 595
			public struct Enumerator : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060013E6 RID: 5094 RVA: 0x000336BE File Offset: 0x000318BE
				internal Enumerator(global::System.Collections.Generic.Dictionary<TKey, TValue> multiBucket)
				{
					this._singleBucketFirstRead = false;
					this._singleBucket = default(global::System.Collections.Generic.KeyValuePair<TKey, TValue>);
					this._multiBuckets = multiBucket.GetEnumerator();
				}

				// Token: 0x060013E7 RID: 5095 RVA: 0x000336E4 File Offset: 0x000318E4
				internal Enumerator(global::System.Collections.Generic.KeyValuePair<TKey, TValue> singleBucket)
				{
					this._singleBucketFirstRead = false;
					this._singleBucket = singleBucket;
					this._multiBuckets = null;
				}

				// Token: 0x170003A4 RID: 932
				// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000336FC File Offset: 0x000318FC
				public global::System.Collections.Generic.KeyValuePair<TKey, TValue> Current
				{
					get
					{
						if (this._multiBuckets != null)
						{
							global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair = this._multiBuckets.Current;
							TKey key = keyValuePair.Key;
							keyValuePair = this._multiBuckets.Current;
							return new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(key, keyValuePair.Value);
						}
						return new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(this._singleBucket.Key, this._singleBucket.Value);
					}
				}

				// Token: 0x170003A5 RID: 933
				// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0003375E File Offset: 0x0003195E
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x060013EA RID: 5098 RVA: 0x0003376B File Offset: 0x0003196B
				public void Dispose()
				{
					if (this._multiBuckets != null)
					{
						this._multiBuckets.Dispose();
					}
				}

				// Token: 0x060013EB RID: 5099 RVA: 0x00033780 File Offset: 0x00031980
				public bool MoveNext()
				{
					if (this._multiBuckets != null)
					{
						return this._multiBuckets.MoveNext();
					}
					return !this._singleBucketFirstRead && (this._singleBucketFirstRead = true);
				}

				// Token: 0x060013EC RID: 5100 RVA: 0x000337B5 File Offset: 0x000319B5
				public void Reset()
				{
					if (this._multiBuckets != null)
					{
						this._multiBuckets.Reset();
						return;
					}
					this._singleBucketFirstRead = false;
				}

				// Token: 0x040006B0 RID: 1712
				private bool _singleBucketFirstRead;

				// Token: 0x040006B1 RID: 1713
				private readonly global::System.Collections.Generic.KeyValuePair<TKey, TValue> _singleBucket;

				// Token: 0x040006B2 RID: 1714
				private readonly global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _multiBuckets;
			}
		}
	}
}
