using System;
using System.Collections;
using System.Collections.Generic;

namespace NLog.Internal
{
	// Token: 0x020000FC RID: 252
	internal class DictionaryAdapter<TKey, TValue> : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x0001F310 File Offset: 0x0001D510
		public DictionaryAdapter(global::System.Collections.Generic.IDictionary<TKey, TValue> implementation)
		{
			this._implementation = implementation;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0001F31F File Offset: 0x0001D51F
		public global::System.Collections.ICollection Values
		{
			get
			{
				return new global::System.Collections.Generic.List<TValue>(this._implementation.Values);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0001F331 File Offset: 0x0001D531
		public int Count
		{
			get
			{
				return this._implementation.Count;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0001F33E File Offset: 0x0001D53E
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0001F341 File Offset: 0x0001D541
		public object SyncRoot
		{
			get
			{
				return this._implementation;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0001F349 File Offset: 0x0001D549
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0001F34C File Offset: 0x0001D54C
		public bool IsReadOnly
		{
			get
			{
				return this._implementation.IsReadOnly;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0001F359 File Offset: 0x0001D559
		public global::System.Collections.ICollection Keys
		{
			get
			{
				return new global::System.Collections.Generic.List<TKey>(this._implementation.Keys);
			}
		}

		// Token: 0x17000270 RID: 624
		public object this[object key]
		{
			get
			{
				TValue tvalue;
				if (this._implementation.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				this._implementation[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0001F3AF File Offset: 0x0001D5AF
		public void Add(object key, object value)
		{
			this._implementation.Add((TKey)((object)key), (TValue)((object)value));
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		public void Clear()
		{
			this._implementation.Clear();
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0001F3D5 File Offset: 0x0001D5D5
		public bool Contains(object key)
		{
			return this._implementation.ContainsKey((TKey)((object)key));
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
		public global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return new global::NLog.Internal.DictionaryAdapter<TKey, TValue>.MyEnumerator(this._implementation.GetEnumerator());
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0001F3FA File Offset: 0x0001D5FA
		public void Remove(object key)
		{
			this._implementation.Remove((TKey)((object)key));
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0001F40E File Offset: 0x0001D60E
		public void CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0001F415 File Offset: 0x0001D615
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000386 RID: 902
		private readonly global::System.Collections.Generic.IDictionary<TKey, TValue> _implementation;

		// Token: 0x02000208 RID: 520
		private class MyEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
		{
			// Token: 0x060012C8 RID: 4808 RVA: 0x00030C3C File Offset: 0x0002EE3C
			public MyEnumerator(global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> wrapped)
			{
				this._wrapped = wrapped;
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00030C4C File Offset: 0x0002EE4C
			public global::System.Collections.DictionaryEntry Entry
			{
				get
				{
					global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair = this._wrapped.Current;
					object key = keyValuePair.Key;
					keyValuePair = this._wrapped.Current;
					return new global::System.Collections.DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x060012CA RID: 4810 RVA: 0x00030C90 File Offset: 0x0002EE90
			public object Key
			{
				get
				{
					global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair = this._wrapped.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00030CB8 File Offset: 0x0002EEB8
			public object Value
			{
				get
				{
					global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair = this._wrapped.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x060012CC RID: 4812 RVA: 0x00030CDD File Offset: 0x0002EEDD
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x00030CEA File Offset: 0x0002EEEA
			public bool MoveNext()
			{
				return this._wrapped.MoveNext();
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x00030CF7 File Offset: 0x0002EEF7
			public void Reset()
			{
				this._wrapped.Reset();
			}

			// Token: 0x040005D0 RID: 1488
			private readonly global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> _wrapped;
		}
	}
}
