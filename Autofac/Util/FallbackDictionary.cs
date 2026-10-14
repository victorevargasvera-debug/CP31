using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Autofac.Util
{
	// Token: 0x0200001D RID: 29
	internal class FallbackDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00004846 File Offset: 0x00002A46
		public FallbackDictionary() : this(new global::System.Collections.Generic.Dictionary<TKey, TValue>())
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004853 File Offset: 0x00002A53
		public FallbackDictionary(global::System.Collections.Generic.IDictionary<TKey, TValue> parent)
		{
			if (parent == null)
			{
				throw new global::System.ArgumentNullException("parent");
			}
			this.Parent = parent;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000487B File Offset: 0x00002A7B
		public int Count
		{
			get
			{
				return this.Keys.Count;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00004888 File Offset: 0x00002A88
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000488B File Offset: 0x00002A8B
		public global::System.Collections.Generic.ICollection<TKey> Keys
		{
			get
			{
				return this.OrderedKeys().ToArray<TKey>();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004898 File Offset: 0x00002A98
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000048A0 File Offset: 0x00002AA0
		public global::System.Collections.Generic.IDictionary<TKey, TValue> Parent { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000048AC File Offset: 0x00002AAC
		public global::System.Collections.Generic.ICollection<TValue> Values
		{
			get
			{
				TKey[] array = this.Keys.ToArray<TKey>();
				TValue[] array2 = new TValue[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = this[array[i]];
				}
				return array2;
			}
		}

		// Token: 0x1700002D RID: 45
		public TValue this[TKey key]
		{
			get
			{
				TValue result;
				if (this._localValues.TryGetValue(key, out result))
				{
					return result;
				}
				return this.Parent[key];
			}
			set
			{
				this._localValues[key] = value;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000492E File Offset: 0x00002B2E
		public void Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004944 File Offset: 0x00002B44
		public void Add(TKey key, TValue value)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (this.Parent.ContainsKey(key))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Autofac.Util.FallbackDictionaryResources.DuplicateItem, new object[]
				{
					key
				}));
			}
			this._localValues.Add(key, value);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000049A3 File Offset: 0x00002BA3
		public void Clear()
		{
			this._localValues.Clear();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000049B0 File Offset: 0x00002BB0
		public bool Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			if (this._localValues.ContainsKey(item.Key))
			{
				return this._localValues.Contains(item);
			}
			return this.Parent.Contains(item);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000049DF File Offset: 0x00002BDF
		public bool ContainsKey(TKey key)
		{
			return this.Keys.Contains(key);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000049ED File Offset: 0x00002BED
		public void CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>)new global::System.Collections.Generic.Dictionary<TKey, TValue>(this)).CopyTo(array, arrayIndex);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000049FC File Offset: 0x00002BFC
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			foreach (TKey key in this.OrderedKeys())
			{
				yield return new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(key, this[key]);
			}
			global::System.Collections.Generic.IEnumerator<TKey> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004A0B File Offset: 0x00002C0B
		public bool Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			return this._localValues.Remove(item);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004A19 File Offset: 0x00002C19
		public bool Remove(TKey key)
		{
			return this._localValues.Remove(key);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004A27 File Offset: 0x00002C27
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this._localValues.TryGetValue(key, out value) || this.Parent.TryGetValue(key, out value);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004A47 File Offset: 0x00002C47
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004A50 File Offset: 0x00002C50
		private global::System.Collections.Generic.IEnumerable<TKey> OrderedKeys()
		{
			return from k in this._localValues.Keys.Union(this.Parent.Keys).Distinct<TKey>()
			orderby k
			select k;
		}

		// Token: 0x04000020 RID: 32
		private global::System.Collections.Generic.IDictionary<TKey, TValue> _localValues = new global::System.Collections.Generic.Dictionary<TKey, TValue>();
	}
}
