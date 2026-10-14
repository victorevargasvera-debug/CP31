using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism
{
	// Token: 0x0200001D RID: 29
	public sealed class ListDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, global::System.Collections.Generic.IList<TValue>>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000037D3 File Offset: 0x000019D3
		public void Add(TKey key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			this.CreateNewList(key);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000037F0 File Offset: 0x000019F0
		public void Add(TKey key, TValue value)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (this.innerValues.ContainsKey(key))
			{
				this.innerValues[key].Add(value);
				return;
			}
			global::System.Collections.Generic.List<TValue> list = this.CreateNewList(key);
			list.Add(value);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003854 File Offset: 0x00001A54
		private global::System.Collections.Generic.List<TValue> CreateNewList(TKey key)
		{
			global::System.Collections.Generic.List<TValue> list = new global::System.Collections.Generic.List<TValue>();
			this.innerValues.Add(key, list);
			return list;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003875 File Offset: 0x00001A75
		public void Clear()
		{
			this.innerValues.Clear();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003884 File Offset: 0x00001A84
		public bool ContainsValue(TValue value)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> keyValuePair in this.innerValues)
			{
				if (keyValuePair.Value.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000038E8 File Offset: 0x00001AE8
		public bool ContainsKey(TKey key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			return this.innerValues.ContainsKey(key);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003B58 File Offset: 0x00001D58
		public global::System.Collections.Generic.IEnumerable<TValue> FindAllValuesByKey(global::System.Predicate<TKey> keyFilter)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> pair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this))
			{
				global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> keyValuePair = pair;
				if (keyFilter(keyValuePair.Key))
				{
					global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> keyValuePair2 = pair;
					foreach (TValue value in keyValuePair2.Value)
					{
						yield return value;
					}
				}
			}
			yield break;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public global::System.Collections.Generic.IEnumerable<TValue> FindAllValues(global::System.Predicate<TValue> valueFilter)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> pair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this))
			{
				global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> keyValuePair = pair;
				foreach (TValue value in keyValuePair.Value)
				{
					if (valueFilter(value))
					{
						yield return value;
					}
				}
			}
			yield break;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			return this.innerValues.Remove(key);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003E28 File Offset: 0x00002028
		public void Remove(TKey key, TValue value)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (this.innerValues.ContainsKey(key))
			{
				global::System.Collections.Generic.List<TValue> list = (global::System.Collections.Generic.List<TValue>)this.innerValues[key];
				list.RemoveAll((TValue item) => value.Equals(item));
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003EA8 File Offset: 0x000020A8
		public void Remove(TValue value)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> keyValuePair in this.innerValues)
			{
				this.Remove(keyValuePair.Key, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003F04 File Offset: 0x00002104
		public global::System.Collections.Generic.IList<TValue> Values
		{
			get
			{
				global::System.Collections.Generic.List<TValue> list = new global::System.Collections.Generic.List<TValue>();
				foreach (global::System.Collections.Generic.IEnumerable<TValue> collection in this.innerValues.Values)
				{
					list.AddRange(collection);
				}
				return list;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003F64 File Offset: 0x00002164
		public global::System.Collections.Generic.ICollection<TKey> Keys
		{
			get
			{
				return this.innerValues.Keys;
			}
		}

		// Token: 0x17000015 RID: 21
		public global::System.Collections.Generic.IList<TValue> this[TKey key]
		{
			get
			{
				if (!this.innerValues.ContainsKey(key))
				{
					this.innerValues.Add(key, new global::System.Collections.Generic.List<TValue>());
				}
				return this.innerValues[key];
			}
			set
			{
				this.innerValues[key] = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003FAD File Offset: 0x000021AD
		public int Count
		{
			get
			{
				return this.innerValues.Count;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003FBA File Offset: 0x000021BA
		void global::System.Collections.Generic.IDictionary<!0, global::System.Collections.Generic.IList<!1>>.Add(TKey key, global::System.Collections.Generic.IList<TValue> value)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			this.innerValues.Add(key, value);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003FEA File Offset: 0x000021EA
		bool global::System.Collections.Generic.IDictionary<!0, global::System.Collections.Generic.IList<!1>>.TryGetValue(TKey key, out global::System.Collections.Generic.IList<TValue> value)
		{
			value = this[key];
			return true;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003FF6 File Offset: 0x000021F6
		global::System.Collections.Generic.ICollection<global::System.Collections.Generic.IList<TValue>> global::System.Collections.Generic.IDictionary<!0, global::System.Collections.Generic.IList<!1>>.Values
		{
			get
			{
				return this.innerValues.Values;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004003 File Offset: 0x00002203
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.Add(global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> item)
		{
			((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this.innerValues).Add(item);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004011 File Offset: 0x00002211
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.Contains(global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> item)
		{
			return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this.innerValues).Contains(item);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000401F File Offset: 0x0000221F
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>>[] array, int arrayIndex)
		{
			((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this.innerValues).CopyTo(array, arrayIndex);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000402E File Offset: 0x0000222E
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.IsReadOnly
		{
			get
			{
				return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this.innerValues).IsReadOnly;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000403B File Offset: 0x0000223B
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.Remove(global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>> item)
		{
			return ((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>)this.innerValues).Remove(item);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004049 File Offset: 0x00002249
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, global::System.Collections.Generic.IList<TValue>>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, global::System.Collections.Generic.IList<!1>>>.GetEnumerator()
		{
			return this.innerValues.GetEnumerator();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000405B File Offset: 0x0000225B
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.innerValues.GetEnumerator();
		}

		// Token: 0x0400002E RID: 46
		private global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.IList<TValue>> innerValues = new global::System.Collections.Generic.Dictionary<TKey, global::System.Collections.Generic.IList<TValue>>();
	}
}
