using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x02000089 RID: 137
	public class WeakDictionary<TKey, TValue> : global::System.Collections.Generic.IDictionary<TKey, TValue>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00014A19 File Offset: 0x00012C19
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, 11)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00014A25 File Offset: 0x00012C25
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, int initialCapacity) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, initialCapacity, null)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00014A31 File Offset: 0x00012C31
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, 11, keyComparer)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00014A3E File Offset: 0x00012C3E
		public WeakDictionary(bool manageKeysAsWeakReferences, bool manageValuesAsWeakReferences, int initialCapacity, global::System.Collections.Generic.IEqualityComparer<TKey> keyComparer) : this(manageKeysAsWeakReferences, manageValuesAsWeakReferences, initialCapacity, 0.9f, keyComparer)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00014A50 File Offset: 0x00012C50
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

		// Token: 0x06000554 RID: 1364 RVA: 0x00014AF0 File Offset: 0x00012CF0
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

		// Token: 0x06000555 RID: 1365 RVA: 0x00014BCC File Offset: 0x00012DCC
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

		// Token: 0x06000556 RID: 1366 RVA: 0x00014C24 File Offset: 0x00012E24
		private global::System.WeakReference CreateKeyWeakReference(TKey key)
		{
			if (key == null)
			{
				return null;
			}
			return new global::System.WeakReference(key);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00014C3B File Offset: 0x00012E3B
		private global::System.WeakReference CreateValueWeakReference(TValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new global::System.WeakReference(value);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00014C54 File Offset: 0x00012E54
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

		// Token: 0x06000559 RID: 1369 RVA: 0x00014C90 File Offset: 0x00012E90
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

		// Token: 0x0600055A RID: 1370 RVA: 0x00014DAC File Offset: 0x00012FAC
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

		// Token: 0x0600055B RID: 1371 RVA: 0x00014DD8 File Offset: 0x00012FD8
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

		// Token: 0x0600055C RID: 1372 RVA: 0x00014E00 File Offset: 0x00013000
		private int GetHashCode(TKey key)
		{
			return this._keyComparer.GetHashCode(key);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00014E0E File Offset: 0x0001300E
		private int GetIndex(TKey key)
		{
			return this.GetIndex(this.GetHashCode(key));
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00014E1D File Offset: 0x0001301D
		private int GetIndex(int hash)
		{
			return global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetIndexHelper(hash, this._arr.Length);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00014E2D File Offset: 0x0001302D
		private static int GetIndexHelper(int hash, int arrLen)
		{
			if (hash < 0)
			{
				hash = -hash;
			}
			return hash % arrLen;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00014E3C File Offset: 0x0001303C
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

		// Token: 0x06000561 RID: 1377 RVA: 0x00014E88 File Offset: 0x00013088
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

		// Token: 0x06000562 RID: 1378 RVA: 0x00014EB8 File Offset: 0x000130B8
		public void Add(TKey key, TValue value)
		{
			this.AddHelper(key, value, false);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00014EC3 File Offset: 0x000130C3
		public void Clear()
		{
			global::System.Array.Clear(this._arr, 0, this._arr.Length);
			this._count = 0;
			this._version++;
			this.ExpandCollapseHelper(false);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00014EF8 File Offset: 0x000130F8
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

		// Token: 0x06000565 RID: 1381 RVA: 0x00014FAC File Offset: 0x000131AC
		public bool ContainsKey(TKey key)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(key);
			return entry != null && (!this._valuesAsWeakReferences || entry.HasValue(this));
		}

		// Token: 0x170000DF RID: 223
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

		// Token: 0x06000568 RID: 1384 RVA: 0x00015004 File Offset: 0x00013204
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

		// Token: 0x06000569 RID: 1385 RVA: 0x00015081 File Offset: 0x00013281
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.TryGetValueHelper(key, out value, false);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001508C File Offset: 0x0001328C
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00015094 File Offset: 0x00013294
		public global::System.Collections.Generic.IEnumerable<TKey> Keys
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.EnumerableWrapper<TKey>(new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection(this));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000150A1 File Offset: 0x000132A1
		public global::System.Collections.Generic.IEnumerable<TValue> Values
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.EnumerableWrapper<TValue>(new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection(this));
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000150AE File Offset: 0x000132AE
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.Add(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000150C4 File Offset: 0x000132C4
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.Contains(global::System.Collections.Generic.KeyValuePair<TKey, TValue> item)
		{
			global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry entry = this.FindExistingEntry(item.Key);
			return entry != null && entry.IsSameKey(this, item.Key) && entry.IsSameValue(this, item.Value) && (!this._valuesAsWeakReferences || null != item.Value);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00015120 File Offset: 0x00013320
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.CopyTo(global::System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this))
			{
				array[arrayIndex++] = keyValuePair;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00015174 File Offset: 0x00013374
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00015178 File Offset: 0x00013378
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x000151B7 File Offset: 0x000133B7
		global::System.Collections.Generic.ICollection<TKey> global::System.Collections.Generic.IDictionary<!0, !1>.Keys
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection(this);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000151BF File Offset: 0x000133BF
		global::System.Collections.Generic.ICollection<TValue> global::System.Collections.Generic.IDictionary<!0, !1>.Values
		{
			get
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection(this);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000151C7 File Offset: 0x000133C7
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyValuePairEnumerator(this);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000151CF File Offset: 0x000133CF
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x04000293 RID: 659
		private const int DEFAULT_CAPACITY = 11;

		// Token: 0x04000294 RID: 660
		private const float DEFAULT_LOAD_FACTOR = 0.9f;

		// Token: 0x04000295 RID: 661
		private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] _arr;

		// Token: 0x04000296 RID: 662
		private int _count;

		// Token: 0x04000297 RID: 663
		private int _version;

		// Token: 0x04000298 RID: 664
		private global::System.Collections.Generic.IEqualityComparer<TKey> _keyComparer;

		// Token: 0x04000299 RID: 665
		private float _loadFactor;

		// Token: 0x0400029A RID: 666
		private bool _keysAsWeakReferences = true;

		// Token: 0x0400029B RID: 667
		private bool _valuesAsWeakReferences = true;

		// Token: 0x0200008A RID: 138
		private class Entry
		{
			// Token: 0x06000576 RID: 1398 RVA: 0x000151D7 File Offset: 0x000133D7
			public Entry(int hash, object key, object value)
			{
				this._hash = hash;
				this._key = key;
				this._value = value;
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x000151F4 File Offset: 0x000133F4
			internal TKey GetKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				object obj = this._key;
				if (wd._keysAsWeakReferences)
				{
					obj = global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetWeakReferenceTargetSafe((global::System.WeakReference)obj);
				}
				return (TKey)((object)obj);
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00015224 File Offset: 0x00013424
			internal TValue GetValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				object obj = this._value;
				if (wd._valuesAsWeakReferences)
				{
					obj = global::Infragistics.Collections.WeakDictionary<TKey, TValue>.GetWeakReferenceTargetSafe((global::System.WeakReference)obj);
				}
				return (TValue)((object)obj);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00015252 File Offset: 0x00013452
			internal void SetValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TValue value)
			{
				this._value = (wd._valuesAsWeakReferences ? wd.CreateValueWeakReference(value) : value);
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00015271 File Offset: 0x00013471
			internal bool HasKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				return null != this.GetKey(wd);
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00015285 File Offset: 0x00013485
			internal bool HasValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				return null != this.GetValue(wd);
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0001529C File Offset: 0x0001349C
			internal bool IsSameKey(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TKey key)
			{
				TKey key2 = this.GetKey(wd);
				return wd._keyComparer.Equals(key, key2);
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x000152C0 File Offset: 0x000134C0
			internal bool IsSameValue(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd, TValue value)
			{
				TValue value2 = this.GetValue(wd);
				return object.Equals(value, value2);
			}

			// Token: 0x0400029C RID: 668
			private object _key;

			// Token: 0x0400029D RID: 669
			private object _value;

			// Token: 0x0400029E RID: 670
			internal int _hash;

			// Token: 0x0400029F RID: 671
			internal global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x0200008B RID: 139
		private class EntryEnumerable : global::System.Collections.Generic.IEnumerable<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600057E RID: 1406 RVA: 0x000152E6 File Offset: 0x000134E6
			internal EntryEnumerable(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
			{
				this._wd = wd;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x000152F5 File Offset: 0x000134F5
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry> GetEnumerator()
			{
				return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x00015302 File Offset: 0x00013502
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040002A0 RID: 672
			private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

			// Token: 0x0200008C RID: 140
			internal abstract class CollectionBase
			{
				// Token: 0x06000581 RID: 1409 RVA: 0x0001530A File Offset: 0x0001350A
				internal CollectionBase(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
				}

				// Token: 0x06000582 RID: 1410 RVA: 0x00015319 File Offset: 0x00013519
				protected void NotSupported()
				{
					throw new global::System.NotSupportedException();
				}

				// Token: 0x170000E6 RID: 230
				// (get) Token: 0x06000583 RID: 1411 RVA: 0x00015320 File Offset: 0x00013520
				public int Count
				{
					get
					{
						return this._wd.Count;
					}
				}

				// Token: 0x170000E7 RID: 231
				// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001532D File Offset: 0x0001352D
				public bool IsSynchronized
				{
					get
					{
						return false;
					}
				}

				// Token: 0x170000E8 RID: 232
				// (get) Token: 0x06000585 RID: 1413 RVA: 0x00015330 File Offset: 0x00013530
				public object SyncRoot
				{
					get
					{
						return this._wd;
					}
				}

				// Token: 0x040002A1 RID: 673
				protected global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;
			}

			// Token: 0x0200008D RID: 141
			internal class KeyCollection : global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.CollectionBase, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
			{
				// Token: 0x06000586 RID: 1414 RVA: 0x00015338 File Offset: 0x00013538
				internal KeyCollection(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd) : base(wd)
				{
				}

				// Token: 0x06000587 RID: 1415 RVA: 0x00015341 File Offset: 0x00013541
				public void Add(TKey item)
				{
					base.NotSupported();
				}

				// Token: 0x06000588 RID: 1416 RVA: 0x00015349 File Offset: 0x00013549
				public void Clear()
				{
					base.NotSupported();
				}

				// Token: 0x06000589 RID: 1417 RVA: 0x00015351 File Offset: 0x00013551
				public bool Contains(TKey item)
				{
					return this._wd.ContainsKey(item);
				}

				// Token: 0x0600058A RID: 1418 RVA: 0x00015360 File Offset: 0x00013560
				public void CopyTo(TKey[] array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array[arrayIndex++] = keyValuePair.Key;
					}
				}

				// Token: 0x0600058B RID: 1419 RVA: 0x000153BC File Offset: 0x000135BC
				public void CopyTo(global::System.Array array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array.SetValue(keyValuePair.Key, arrayIndex++);
					}
				}

				// Token: 0x170000E9 RID: 233
				// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001541C File Offset: 0x0001361C
				public bool IsReadOnly
				{
					get
					{
						return true;
					}
				}

				// Token: 0x0600058D RID: 1421 RVA: 0x0001541F File Offset: 0x0001361F
				public bool Remove(TKey item)
				{
					base.NotSupported();
					return false;
				}

				// Token: 0x0600058E RID: 1422 RVA: 0x00015428 File Offset: 0x00013628
				public global::System.Collections.Generic.IEnumerator<TKey> GetEnumerator()
				{
					return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.KeyCollection.Enumerator(this._wd);
				}

				// Token: 0x0600058F RID: 1423 RVA: 0x00015435 File Offset: 0x00013635
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x0200008E RID: 142
				internal class Enumerator : global::System.Collections.Generic.IEnumerator<TKey>, global::System.IDisposable, global::System.Collections.IEnumerator
				{
					// Token: 0x06000590 RID: 1424 RVA: 0x0001543D File Offset: 0x0001363D
					internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
					{
						this._wd = wd;
						this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
					}

					// Token: 0x170000EA RID: 234
					// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001545D File Offset: 0x0001365D
					public TKey Current
					{
						get
						{
							return this._e.CurrentKey;
						}
					}

					// Token: 0x06000592 RID: 1426 RVA: 0x0001546A File Offset: 0x0001366A
					public void Dispose()
					{
						this._e.Dispose();
					}

					// Token: 0x170000EB RID: 235
					// (get) Token: 0x06000593 RID: 1427 RVA: 0x00015477 File Offset: 0x00013677
					object global::System.Collections.IEnumerator.Current
					{
						get
						{
							return this.Current;
						}
					}

					// Token: 0x06000594 RID: 1428 RVA: 0x00015484 File Offset: 0x00013684
					public bool MoveNext()
					{
						return this._e.MoveNext();
					}

					// Token: 0x06000595 RID: 1429 RVA: 0x00015491 File Offset: 0x00013691
					public void Reset()
					{
						this._e.Reset();
					}

					// Token: 0x040002A2 RID: 674
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

					// Token: 0x040002A3 RID: 675
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
				}
			}

			// Token: 0x0200008F RID: 143
			internal class ValueCollection : global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.CollectionBase, global::System.Collections.Generic.ICollection<TValue>, global::System.Collections.Generic.IEnumerable<TValue>, global::System.Collections.IEnumerable
			{
				// Token: 0x06000596 RID: 1430 RVA: 0x0001549E File Offset: 0x0001369E
				internal ValueCollection(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd) : base(wd)
				{
				}

				// Token: 0x06000597 RID: 1431 RVA: 0x000154A7 File Offset: 0x000136A7
				public void Add(TValue item)
				{
					base.NotSupported();
				}

				// Token: 0x06000598 RID: 1432 RVA: 0x000154AF File Offset: 0x000136AF
				public void Clear()
				{
					base.NotSupported();
				}

				// Token: 0x06000599 RID: 1433 RVA: 0x000154B7 File Offset: 0x000136B7
				public bool Contains(TValue item)
				{
					return this._wd.ContainsValue(item);
				}

				// Token: 0x0600059A RID: 1434 RVA: 0x000154C8 File Offset: 0x000136C8
				public void CopyTo(TValue[] array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array[arrayIndex++] = keyValuePair.Value;
					}
				}

				// Token: 0x0600059B RID: 1435 RVA: 0x00015524 File Offset: 0x00013724
				public void CopyTo(global::System.Array array, int arrayIndex)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<!0, !1>>)this._wd))
					{
						array.SetValue(keyValuePair.Value, arrayIndex++);
					}
				}

				// Token: 0x170000EC RID: 236
				// (get) Token: 0x0600059C RID: 1436 RVA: 0x00015584 File Offset: 0x00013784
				public bool IsReadOnly
				{
					get
					{
						return true;
					}
				}

				// Token: 0x0600059D RID: 1437 RVA: 0x00015587 File Offset: 0x00013787
				public bool Remove(TValue item)
				{
					base.NotSupported();
					return false;
				}

				// Token: 0x0600059E RID: 1438 RVA: 0x00015590 File Offset: 0x00013790
				public global::System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
				{
					return new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.ValueCollection.Enumerator(this._wd);
				}

				// Token: 0x0600059F RID: 1439 RVA: 0x0001559D File Offset: 0x0001379D
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x02000090 RID: 144
				internal class Enumerator : global::System.Collections.Generic.IEnumerator<TValue>, global::System.IDisposable, global::System.Collections.IEnumerator
				{
					// Token: 0x060005A0 RID: 1440 RVA: 0x000155A5 File Offset: 0x000137A5
					internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
					{
						this._wd = wd;
						this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
					}

					// Token: 0x170000ED RID: 237
					// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000155C5 File Offset: 0x000137C5
					public TValue Current
					{
						get
						{
							return this._e.CurrentValue;
						}
					}

					// Token: 0x060005A2 RID: 1442 RVA: 0x000155D2 File Offset: 0x000137D2
					public void Dispose()
					{
						this._e.Dispose();
					}

					// Token: 0x170000EE RID: 238
					// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000155DF File Offset: 0x000137DF
					object global::System.Collections.IEnumerator.Current
					{
						get
						{
							return this.Current;
						}
					}

					// Token: 0x060005A4 RID: 1444 RVA: 0x000155EC File Offset: 0x000137EC
					public bool MoveNext()
					{
						return this._e.MoveNext();
					}

					// Token: 0x060005A5 RID: 1445 RVA: 0x000155F9 File Offset: 0x000137F9
					public void Reset()
					{
						this._e.Reset();
					}

					// Token: 0x040002A4 RID: 676
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

					// Token: 0x040002A5 RID: 677
					private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
				}
			}

			// Token: 0x02000091 RID: 145
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060005A6 RID: 1446 RVA: 0x00015606 File Offset: 0x00013806
				internal Enumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
					this._arr = this._wd._arr;
					this.Reset();
				}

				// Token: 0x170000EF RID: 239
				// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001562C File Offset: 0x0001382C
				public global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x170000F0 RID: 240
				// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00015634 File Offset: 0x00013834
				public TKey CurrentKey
				{
					get
					{
						return this._currentKey;
					}
				}

				// Token: 0x170000F1 RID: 241
				// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001563C File Offset: 0x0001383C
				public TValue CurrentValue
				{
					get
					{
						return this._currentValue;
					}
				}

				// Token: 0x060005AA RID: 1450 RVA: 0x00015644 File Offset: 0x00013844
				public void Dispose()
				{
				}

				// Token: 0x170000F2 RID: 242
				// (get) Token: 0x060005AB RID: 1451 RVA: 0x00015646 File Offset: 0x00013846
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x060005AC RID: 1452 RVA: 0x00015650 File Offset: 0x00013850
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

				// Token: 0x060005AD RID: 1453 RVA: 0x00015714 File Offset: 0x00013914
				public void Reset()
				{
					this._i = -1;
					this._current = null;
				}

				// Token: 0x040002A6 RID: 678
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

				// Token: 0x040002A7 RID: 679
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry[] _arr;

				// Token: 0x040002A8 RID: 680
				private int _i;

				// Token: 0x040002A9 RID: 681
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.Entry _current;

				// Token: 0x040002AA RID: 682
				private TKey _currentKey;

				// Token: 0x040002AB RID: 683
				private TValue _currentValue;
			}

			// Token: 0x02000092 RID: 146
			internal class KeyValuePairEnumerator : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060005AE RID: 1454 RVA: 0x00015724 File Offset: 0x00013924
				internal KeyValuePairEnumerator(global::Infragistics.Collections.WeakDictionary<TKey, TValue> wd)
				{
					this._wd = wd;
					this._e = new global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator(this._wd);
				}

				// Token: 0x170000F3 RID: 243
				// (get) Token: 0x060005AF RID: 1455 RVA: 0x00015744 File Offset: 0x00013944
				public global::System.Collections.Generic.KeyValuePair<TKey, TValue> Current
				{
					get
					{
						return new global::System.Collections.Generic.KeyValuePair<TKey, TValue>(this._e.CurrentKey, this._e.CurrentValue);
					}
				}

				// Token: 0x060005B0 RID: 1456 RVA: 0x00015761 File Offset: 0x00013961
				public void Dispose()
				{
					this._e.Dispose();
				}

				// Token: 0x170000F4 RID: 244
				// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001576E File Offset: 0x0001396E
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x060005B2 RID: 1458 RVA: 0x0001577B File Offset: 0x0001397B
				public bool MoveNext()
				{
					return this._e.MoveNext();
				}

				// Token: 0x060005B3 RID: 1459 RVA: 0x00015788 File Offset: 0x00013988
				public void Reset()
				{
					this._e.Reset();
				}

				// Token: 0x040002AC RID: 684
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue> _wd;

				// Token: 0x040002AD RID: 685
				private global::Infragistics.Collections.WeakDictionary<TKey, TValue>.EntryEnumerable.Enumerator _e;
			}

			// Token: 0x02000093 RID: 147
			internal class EnumerableWrapper<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
			{
				// Token: 0x060005B4 RID: 1460 RVA: 0x00015795 File Offset: 0x00013995
				internal EnumerableWrapper(global::System.Collections.Generic.IEnumerable<T> e)
				{
					this._e = e;
				}

				// Token: 0x060005B5 RID: 1461 RVA: 0x000157A4 File Offset: 0x000139A4
				public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
				{
					return this._e.GetEnumerator();
				}

				// Token: 0x060005B6 RID: 1462 RVA: 0x000157B1 File Offset: 0x000139B1
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x040002AE RID: 686
				private global::System.Collections.Generic.IEnumerable<T> _e;
			}
		}
	}
}
