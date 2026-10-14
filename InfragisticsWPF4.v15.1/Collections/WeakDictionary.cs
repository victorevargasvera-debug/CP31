using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x020000A2 RID: 162
	public class WeakDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600062C RID: 1580 RVA: 0x00018091 File Offset: 0x00016291
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, 11)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001809D File Offset: 0x0001629D
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, int initialCapacity) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, initialCapacity, null)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000180A9 File Offset: 0x000162A9
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, 11, keyComparer)
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000180B6 File Offset: 0x000162B6
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, int initialCapacity, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, initialCapacity, 0.9f, keyComparer)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000180C8 File Offset: 0x000162C8
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, int initialCapacity, float loadFactor, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer)
		{
			if (initialCapacity <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("initialCapacity", global::SR.GetString("LE_ArgumentOutOfRangeException_7"));
			}
			if (loadFactor <= 0f || loadFactor > 1f)
			{
				throw new global::System.ArgumentOutOfRangeException("loadFactor", global::SR.GetString("LE_ArgumentOutOfRangeException_8"));
			}
			this._keysAsWeakReferences = manageKeysAsWeakReferences;
			this._valuesAsWeakReferences = manageValuesAsWeakReferences;
			this._loadFactor = loadFactor;
			this._arr = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[(int)((float)initialCapacity / this._loadFactor)];
			this._keyComparer = ((keyComparer != null) ? keyComparer : global::System.Collections.Generic.EqualityComparer<TKey>.Default);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00018168 File Offset: 0x00016368
		private void AddHelper(TKey key, TValue value, bool replace)
		{
			int hashCode = this.GetHashCode(key);
			int index = this.GetIndex(hashCode);
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this._arr[index];
			if (entry != null)
			{
				global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry2 = this.FindInList(entry, key);
				if (entry2 != null)
				{
					if (!replace && (!this._valuesAsWeakReferences || entry2.HasValue(this)))
					{
						throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_7"));
					}
					entry2.SetValue(this, value);
					this._version++;
					return;
				}
			}
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry3 = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry(hashCode, this._keysAsWeakReferences ? this.CreateKeyWeakReference(key) : key, this._valuesAsWeakReferences ? this.CreateValueWeakReference(value) : value);
			entry3._next = entry;
			this._arr[index] = entry3;
			this._count++;
			this._version++;
			this.ExpandCollapseHelper(true);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00018244 File Offset: 0x00016444
		private bool ContainsValue(TValue value)
		{
			foreach (global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry in new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable(this))
			{
				if (entry.IsSameValue(this, value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001829C File Offset: 0x0001649C
		private global::System.WeakReference CreateKeyWeakReference(TKey key)
		{
			if (key == null)
			{
				return null;
			}
			return new global::System.WeakReference(key);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000182B3 File Offset: 0x000164B3
		private global::System.WeakReference CreateValueWeakReference(TValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new global::System.WeakReference(value);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000182CC File Offset: 0x000164CC
		private int CalcNewLengthHelper(int currLen, int requiredLen)
		{
			int i;
			if (currLen < requiredLen)
			{
				i = 2 * currLen;
			}
			else
			{
				int num;
				for (i = currLen; i > 4 * requiredLen; i = num)
				{
					num = i / 2;
					int num2 = (int)(11f / this._loadFactor);
					if (num < num2)
					{
						break;
					}
				}
			}
			return i;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00018308 File Offset: 0x00016508
		private void ExpandCollapseHelper(bool expandOnly)
		{
			int count = this._count;
			int num = (int)((float)count / this._loadFactor);
			int num2 = this._arr.Length;
			if (num2 < num || (!expandOnly && num2 > 4 * num))
			{
				int num3 = this.CalcNewLengthHelper(num2, num);
				if (num2 != num3 && num3 > 1)
				{
					global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] arr = this._arr;
					global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] array = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[num3];
					bool keysAsWeakReferences = this._keysAsWeakReferences;
					int num4 = 0;
					foreach (global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry in arr)
					{
						while (entry != null)
						{
							if ((keysAsWeakReferences && !entry.HasKey(this)) || (this._valuesAsWeakReferences && !entry.HasValue(this)))
							{
								entry = entry._next;
								num4++;
							}
							else
							{
								int indexHelper = global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetIndexHelper(entry._hash, num3);
								global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry next = array[indexHelper];
								array[indexHelper] = entry;
								global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry next2 = entry._next;
								entry._next = next;
								entry = next2;
							}
						}
					}
					this._arr = array;
					if (num4 > 0)
					{
						this._count -= num4;
						this._version++;
					}
				}
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00018424 File Offset: 0x00016624
		private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry FindExistingEntry(TKey key)
		{
			int index = this.GetIndex(key);
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this._arr[index];
			if (entry != null)
			{
				return this.FindInList(entry, key);
			}
			return null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00018450 File Offset: 0x00016650
		private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry FindInList(global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry list, TKey key)
		{
			for (global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = list; entry != null; entry = entry._next)
			{
				if (entry.IsSameKey(this, key))
				{
					return entry;
				}
			}
			return null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00018478 File Offset: 0x00016678
		private int GetHashCode(TKey key)
		{
			return this._keyComparer.GetHashCode(key);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00018486 File Offset: 0x00016686
		private int GetIndex(TKey key)
		{
			return this.GetIndex(this.GetHashCode(key));
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00018495 File Offset: 0x00016695
		private int GetIndex(int hash)
		{
			return global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetIndexHelper(hash, this._arr.Length);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000184A5 File Offset: 0x000166A5
		private static int GetIndexHelper(int hash, int arrLen)
		{
			if (hash < 0)
			{
				hash = -hash;
			}
			return hash % arrLen;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000184B4 File Offset: 0x000166B4
		private bool TryGetValueHelper(TKey key, out TValue value, bool includeEntriesWithNullValues)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(key);
			if (entry != null)
			{
				value = entry.GetValue(this);
				return includeEntriesWithNullValues || !this._valuesAsWeakReferences || null != value;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00018500 File Offset: 0x00016700
		internal static object GetWeakReferenceTargetSafe(global::System.WeakReference weakReference)
		{
			if (weakReference != null)
			{
				try
				{
					return weakReference.Target;
				}
				catch (global::System.Exception)
				{
				}
			}
			return null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00018530 File Offset: 0x00016730
		public void Add(TKey key, TValue value)
		{
			this.AddHelper(key, value, false);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001853B File Offset: 0x0001673B
		public void Clear()
		{
			global::System.Array.Clear(this._arr, 0, this._arr.Length);
			this._count = 0;
			this._version++;
			this.ExpandCollapseHelper(false);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00018570 File Offset: 0x00016770
		public void Compact(bool removeEntriesWithNullValues)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] arr = this._arr;
			bool keysAsWeakReferences = this._keysAsWeakReferences;
			int num = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = arr[i];
				global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry2 = null;
				while (entry != null)
				{
					if ((keysAsWeakReferences && !entry.HasKey(this)) || (removeEntriesWithNullValues && !entry.HasValue(this)))
					{
						if (entry2 != null)
						{
							entry2._next = entry._next;
						}
						else
						{
							arr[i] = entry._next;
						}
						entry = entry._next;
						num++;
					}
					else
					{
						entry2 = entry;
						entry = entry._next;
					}
				}
			}
			if (num > 0)
			{
				this._count -= num;
				this._version++;
				this.ExpandCollapseHelper(false);
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00018624 File Offset: 0x00016824
		public bool ContainsKey(TKey key)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(key);
			return entry != null && (!this._valuesAsWeakReferences || entry.HasValue(this));
		}

		// Token: 0x170000F1 RID: 241
		public TValue this[TKey key]
		{
			get
			{
				TValue result;
				if (!this.TryGetValueHelper(key, out result, true))
				{
					throw new global::System.Collections.Generic.KeyNotFoundException();
				}
				return result;
			}
			set
			{
				this.AddHelper(key, value, true);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001867C File Offset: 0x0001687C
		public bool Remove(TKey key)
		{
			int index = this.GetIndex(key);
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this._arr[index];
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry2 = null;
			while (entry != null)
			{
				if (entry.IsSameKey(this, key))
				{
					if (entry2 != null)
					{
						entry2._next = entry._next;
					}
					else
					{
						this._arr[index] = entry._next;
					}
					this._count--;
					this._version++;
					this.ExpandCollapseHelper(false);
					return true;
				}
				entry2 = entry;
				entry = entry._next;
			}
			return false;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000186F9 File Offset: 0x000168F9
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.TryGetValueHelper(key, out value, false);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00018704 File Offset: 0x00016904
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001870C File Offset: 0x0001690C
		public global::System.Collections.Generic.IEnumerable<TKey> Keys
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.EnumerableWrapper<TKey>(new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection(this));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00018719 File Offset: 0x00016919
		public global::System.Collections.Generic.IEnumerable<TValue> Values
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.EnumerableWrapper<TValue>(new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection(this));
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00018726 File Offset: 0x00016926
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001873C File Offset: 0x0001693C
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(item.Key);
			return entry != null && entry.IsSameKey(this, item.Key) && entry.IsSameValue(this, item.Value) && (!this._valuesAsWeakReferences || null != item.Value);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00018798 File Offset: 0x00016998
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this))
			{
				array[arrayIndex++] = keyValuePair;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000187EC File Offset: 0x000169EC
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000187F0 File Offset: 0x000169F0
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.Remove(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(item.Key);
			if (entry != null && entry.IsSameValue(this, item.Value))
			{
				this.Remove(item.Key);
				return true;
			}
			return false;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001882F File Offset: 0x00016A2F
		global::System.Collections.Generic.ICollection<TKey> global::System.Collections.Generic.IDictionary<!0, !1>.Keys
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection(this);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00018837 File Offset: 0x00016A37
		global::System.Collections.Generic.ICollection<TValue> global::System.Collections.Generic.IDictionary<!0, !1>.Values
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection(this);
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001883F File Offset: 0x00016A3F
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyValuePairEnumerator(this);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00018847 File Offset: 0x00016A47
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x04000316 RID: 790
		private const int DEFAULT_CAPACITY = 11;

		// Token: 0x04000317 RID: 791
		private const float DEFAULT_LOAD_FACTOR = 0.9f;

		// Token: 0x04000318 RID: 792
		private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] _arr;

		// Token: 0x04000319 RID: 793
		private int _count;

		// Token: 0x0400031A RID: 794
		private int _version;

		// Token: 0x0400031B RID: 795
		private global::System.Collections.Generic.IEqualityComparer<TKey> _keyComparer;

		// Token: 0x0400031C RID: 796
		private float _loadFactor;

		// Token: 0x0400031D RID: 797
		private bool _keysAsWeakReferences = true;

		// Token: 0x0400031E RID: 798
		private bool _valuesAsWeakReferences = true;

		// Token: 0x020000A3 RID: 163
		private class Entry
		{
			// Token: 0x06000653 RID: 1619 RVA: 0x0001884F File Offset: 0x00016A4F
			public Entry(int hash, object key, object value)
			{
				this._hash = hash;
				this._key = key;
				this._value = value;
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x0001886C File Offset: 0x00016A6C
			internal TKey GetKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				object obj = this._key;
				if (wd._keysAsWeakReferences)
				{
					obj = global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetWeakReferenceTargetSafe((global::System.WeakReference)obj);
				}
				return (TKey)((object)obj);
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x0001889C File Offset: 0x00016A9C
			internal TValue GetValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				object obj = this._value;
				if (wd._valuesAsWeakReferences)
				{
					obj = global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetWeakReferenceTargetSafe((global::System.WeakReference)obj);
				}
				return (TValue)((object)obj);
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x000188CA File Offset: 0x00016ACA
			internal void SetValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TValue value)
			{
				this._value = (wd._valuesAsWeakReferences ? wd.CreateValueWeakReference(value) : value);
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x000188E9 File Offset: 0x00016AE9
			internal bool HasKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				return null != this.GetKey(wd);
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x000188FD File Offset: 0x00016AFD
			internal bool HasValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				return null != this.GetValue(wd);
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00018914 File Offset: 0x00016B14
			internal bool IsSameKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TKey key)
			{
				TKey key2 = this.GetKey(wd);
				return wd._keyComparer.Equals(key, key2);
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00018938 File Offset: 0x00016B38
			internal bool IsSameValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TValue value)
			{
				TValue value2 = this.GetValue(wd);
				return object.Equals(value, value2);
			}

			// Token: 0x0400031F RID: 799
			private object _key;

			// Token: 0x04000320 RID: 800
			private object _value;

			// Token: 0x04000321 RID: 801
			internal int _hash;

			// Token: 0x04000322 RID: 802
			internal global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x020000A4 RID: 164
		private class EntryEnumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600065B RID: 1627 RVA: 0x0001895E File Offset: 0x00016B5E
			internal EntryEnumerable(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				this._wd = wd;
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x0001896D File Offset: 0x00016B6D
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry> GetEnumerator()
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x0001897A File Offset: 0x00016B7A
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000323 RID: 803
			private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

			// Token: 0x020000A5 RID: 165
			internal abstract class CollectionBase
			{
				// Token: 0x0600065E RID: 1630 RVA: 0x00018982 File Offset: 0x00016B82
				internal CollectionBase(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
				}

				// Token: 0x0600065F RID: 1631 RVA: 0x00018991 File Offset: 0x00016B91
				protected void NotSupported()
				{
					throw new global::System.NotSupportedException();
				}

				// Token: 0x170000F8 RID: 248
				// (get) Token: 0x06000660 RID: 1632 RVA: 0x00018998 File Offset: 0x00016B98
				public int Count
				{
					get
					{
						return this._wd.Count;
					}
				}

				// Token: 0x170000F9 RID: 249
				// (get) Token: 0x06000661 RID: 1633 RVA: 0x000189A5 File Offset: 0x00016BA5
				public bool IsSynchronized
				{
					get
					{
						return false;
					}
				}

				// Token: 0x170000FA RID: 250
				// (get) Token: 0x06000662 RID: 1634 RVA: 0x000189A8 File Offset: 0x00016BA8
				public object SyncRoot
				{
					get
					{
						return this._wd;
					}
				}

				// Token: 0x04000324 RID: 804
				protected global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;
			}

			// Token: 0x020000A6 RID: 166
			internal class KeyCollection : global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.CollectionBase, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
			{
				// Token: 0x06000663 RID: 1635 RVA: 0x000189B0 File Offset: 0x00016BB0
				internal KeyCollection(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd) : base(wd)
				{
				}

				// Token: 0x06000664 RID: 1636 RVA: 0x000189B9 File Offset: 0x00016BB9
				public void Add(TKey item)
				{
					base.NotSupported();
				}

				// Token: 0x06000665 RID: 1637 RVA: 0x000189C1 File Offset: 0x00016BC1
				public void Clear()
				{
					base.NotSupported();
				}

				// Token: 0x06000666 RID: 1638 RVA: 0x000189C9 File Offset: 0x00016BC9
				public bool Contains(TKey item)
				{
					return this._wd.ContainsKey(item);
				}

				// Token: 0x06000667 RID: 1639 RVA: 0x000189D8 File Offset: 0x00016BD8
				public void CopyTo(TKey[] array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array[arrayIndex++] = keyValuePair.Key;
					}
				}

				// Token: 0x06000668 RID: 1640 RVA: 0x00018A34 File Offset: 0x00016C34
				public void CopyTo(global::System.Array array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array.SetValue(keyValuePair.Key, arrayIndex++);
					}
				}

				// Token: 0x170000FB RID: 251
				// (get) Token: 0x06000669 RID: 1641 RVA: 0x00018A94 File Offset: 0x00016C94
				public bool IsReadOnly
				{
					get
					{
						return true;
					}
				}

				// Token: 0x0600066A RID: 1642 RVA: 0x00018A97 File Offset: 0x00016C97
				public bool Remove(TKey item)
				{
					base.NotSupported();
					return false;
				}

				// Token: 0x0600066B RID: 1643 RVA: 0x00018AA0 File Offset: 0x00016CA0
				public global::System.Collections.Generic.IEnumerator<TKey> GetEnumerator()
				{
					return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection.Enumerator(this._wd);
				}

				// Token: 0x0600066C RID: 1644 RVA: 0x00018AAD File Offset: 0x00016CAD
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x020000A7 RID: 167
				internal class Enumerator : global::System.Collections.Generic.IEnumerator<TKey>, global::System.IDisposable, global::System.Collections.IEnumerator
				{
					// Token: 0x0600066D RID: 1645 RVA: 0x00018AB5 File Offset: 0x00016CB5
					internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
					{
						this._wd = wd;
						this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
					}

					// Token: 0x170000FC RID: 252
					// (get) Token: 0x0600066E RID: 1646 RVA: 0x00018AD5 File Offset: 0x00016CD5
					public TKey Current
					{
						get
						{
							return this._e.CurrentKey;
						}
					}

					// Token: 0x0600066F RID: 1647 RVA: 0x00018AE2 File Offset: 0x00016CE2
					public void Dispose()
					{
						this._e.Dispose();
					}

					// Token: 0x170000FD RID: 253
					// (get) Token: 0x06000670 RID: 1648 RVA: 0x00018AEF File Offset: 0x00016CEF
					object global::System.Collections.IEnumerator.Current
					{
						get
						{
							return this.Current;
						}
					}

					// Token: 0x06000671 RID: 1649 RVA: 0x00018AFC File Offset: 0x00016CFC
					public bool MoveNext()
					{
						return this._e.MoveNext();
					}

					// Token: 0x06000672 RID: 1650 RVA: 0x00018B09 File Offset: 0x00016D09
					public void Reset()
					{
						this._e.Reset();
					}

					// Token: 0x04000325 RID: 805
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

					// Token: 0x04000326 RID: 806
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
				}
			}

			// Token: 0x020000A8 RID: 168
			internal class ValueCollection : global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.CollectionBase, global::System.Collections.Generic.ICollection<TValue>, global::System.Collections.Generic.IEnumerable<TValue>, global::System.Collections.IEnumerable
			{
				// Token: 0x06000673 RID: 1651 RVA: 0x00018B16 File Offset: 0x00016D16
				internal ValueCollection(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd) : base(wd)
				{
				}

				// Token: 0x06000674 RID: 1652 RVA: 0x00018B1F File Offset: 0x00016D1F
				public void Add(TValue item)
				{
					base.NotSupported();
				}

				// Token: 0x06000675 RID: 1653 RVA: 0x00018B27 File Offset: 0x00016D27
				public void Clear()
				{
					base.NotSupported();
				}

				// Token: 0x06000676 RID: 1654 RVA: 0x00018B2F File Offset: 0x00016D2F
				public bool Contains(TValue item)
				{
					return this._wd.ContainsValue(item);
				}

				// Token: 0x06000677 RID: 1655 RVA: 0x00018B40 File Offset: 0x00016D40
				public void CopyTo(TValue[] array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array[arrayIndex++] = keyValuePair.Value;
					}
				}

				// Token: 0x06000678 RID: 1656 RVA: 0x00018B9C File Offset: 0x00016D9C
				public void CopyTo(global::System.Array array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array.SetValue(keyValuePair.Value, arrayIndex++);
					}
				}

				// Token: 0x170000FE RID: 254
				// (get) Token: 0x06000679 RID: 1657 RVA: 0x00018BFC File Offset: 0x00016DFC
				public bool IsReadOnly
				{
					get
					{
						return true;
					}
				}

				// Token: 0x0600067A RID: 1658 RVA: 0x00018BFF File Offset: 0x00016DFF
				public bool Remove(TValue item)
				{
					base.NotSupported();
					return false;
				}

				// Token: 0x0600067B RID: 1659 RVA: 0x00018C08 File Offset: 0x00016E08
				public global::System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
				{
					return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection.Enumerator(this._wd);
				}

				// Token: 0x0600067C RID: 1660 RVA: 0x00018C15 File Offset: 0x00016E15
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x020000A9 RID: 169
				internal class Enumerator : global::System.Collections.Generic.IEnumerator<TValue>, global::System.IDisposable, global::System.Collections.IEnumerator
				{
					// Token: 0x0600067D RID: 1661 RVA: 0x00018C1D File Offset: 0x00016E1D
					internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
					{
						this._wd = wd;
						this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
					}

					// Token: 0x170000FF RID: 255
					// (get) Token: 0x0600067E RID: 1662 RVA: 0x00018C3D File Offset: 0x00016E3D
					public TValue Current
					{
						get
						{
							return this._e.CurrentValue;
						}
					}

					// Token: 0x0600067F RID: 1663 RVA: 0x00018C4A File Offset: 0x00016E4A
					public void Dispose()
					{
						this._e.Dispose();
					}

					// Token: 0x17000100 RID: 256
					// (get) Token: 0x06000680 RID: 1664 RVA: 0x00018C57 File Offset: 0x00016E57
					object global::System.Collections.IEnumerator.Current
					{
						get
						{
							return this.Current;
						}
					}

					// Token: 0x06000681 RID: 1665 RVA: 0x00018C64 File Offset: 0x00016E64
					public bool MoveNext()
					{
						return this._e.MoveNext();
					}

					// Token: 0x06000682 RID: 1666 RVA: 0x00018C71 File Offset: 0x00016E71
					public void Reset()
					{
						this._e.Reset();
					}

					// Token: 0x04000327 RID: 807
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

					// Token: 0x04000328 RID: 808
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
				}
			}

			// Token: 0x020000AA RID: 170
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000683 RID: 1667 RVA: 0x00018C7E File Offset: 0x00016E7E
				internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
					this._arr = this._wd._arr;
					this.Reset();
				}

				// Token: 0x17000101 RID: 257
				// (get) Token: 0x06000684 RID: 1668 RVA: 0x00018CA4 File Offset: 0x00016EA4
				public global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x17000102 RID: 258
				// (get) Token: 0x06000685 RID: 1669 RVA: 0x00018CAC File Offset: 0x00016EAC
				public TKey CurrentKey
				{
					get
					{
						return this._currentKey;
					}
				}

				// Token: 0x17000103 RID: 259
				// (get) Token: 0x06000686 RID: 1670 RVA: 0x00018CB4 File Offset: 0x00016EB4
				public TValue CurrentValue
				{
					get
					{
						return this._currentValue;
					}
				}

				// Token: 0x06000687 RID: 1671 RVA: 0x00018CBC File Offset: 0x00016EBC
				public void Dispose()
				{
				}

				// Token: 0x17000104 RID: 260
				// (get) Token: 0x06000688 RID: 1672 RVA: 0x00018CBE File Offset: 0x00016EBE
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x06000689 RID: 1673 RVA: 0x00018CC8 File Offset: 0x00016EC8
				public bool MoveNext()
				{
					for (;;)
					{
						if (this._current != null)
						{
							this._current = this._current._next;
						}
						while (this._current == null && ++this._i < this._arr.Length)
						{
							this._current = this._arr[this._i];
						}
						if (this._current == null)
						{
							break;
						}
						this._currentKey = this._current.GetKey(this._wd);
						this._currentValue = this._current.GetValue(this._wd);
						if (this._currentKey != null && (!this._wd._valuesAsWeakReferences || this._currentValue != null))
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x0600068A RID: 1674 RVA: 0x00018D8C File Offset: 0x00016F8C
				public void Reset()
				{
					this._i = -1;
					this._current = null;
				}

				// Token: 0x04000329 RID: 809
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

				// Token: 0x0400032A RID: 810
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] _arr;

				// Token: 0x0400032B RID: 811
				private int _i;

				// Token: 0x0400032C RID: 812
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry _current;

				// Token: 0x0400032D RID: 813
				private TKey _currentKey;

				// Token: 0x0400032E RID: 814
				private TValue _currentValue;
			}

			// Token: 0x020000AB RID: 171
			internal class KeyValuePairEnumerator : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x0600068B RID: 1675 RVA: 0x00018D9C File Offset: 0x00016F9C
				internal KeyValuePairEnumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
					this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
				}

				// Token: 0x17000105 RID: 261
				// (get) Token: 0x0600068C RID: 1676 RVA: 0x00018DBC File Offset: 0x00016FBC
				public global::System.Collections.Generic.KeyValuePair<TKey, TValue> Current
				{
					get
					{
						return new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(this._e.CurrentKey, this._e.CurrentValue);
					}
				}

				// Token: 0x0600068D RID: 1677 RVA: 0x00018DD9 File Offset: 0x00016FD9
				public void Dispose()
				{
					this._e.Dispose();
				}

				// Token: 0x17000106 RID: 262
				// (get) Token: 0x0600068E RID: 1678 RVA: 0x00018DE6 File Offset: 0x00016FE6
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x0600068F RID: 1679 RVA: 0x00018DF3 File Offset: 0x00016FF3
				public bool MoveNext()
				{
					return this._e.MoveNext();
				}

				// Token: 0x06000690 RID: 1680 RVA: 0x00018E00 File Offset: 0x00017000
				public void Reset()
				{
					this._e.Reset();
				}

				// Token: 0x0400032F RID: 815
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

				// Token: 0x04000330 RID: 816
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
			}

			// Token: 0x020000AC RID: 172
			internal class EnumerableWrapper<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
			{
				// Token: 0x06000691 RID: 1681 RVA: 0x00018E0D File Offset: 0x0001700D
				internal EnumerableWrapper(global::System.Collections.Generic.IEnumerable<T> e)
				{
					this._e = e;
				}

				// Token: 0x06000692 RID: 1682 RVA: 0x00018E1C File Offset: 0x0001701C
				public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
				{
					return this._e.GetEnumerator();
				}

				// Token: 0x06000693 RID: 1683 RVA: 0x00018E29 File Offset: 0x00017029
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x04000331 RID: 817
				private global::System.Collections.Generic.IEnumerable<T> _e;
			}
		}
	}
}
