using System;
using System.Collections;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000193 RID: 403
	public class HashSet : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000D77 RID: 3447 RVA: 0x0002C4BB File Offset: 0x0002A6BB
		public HashSet()
		{
			this._table = new global::System.Collections.Hashtable();
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0002C4CE File Offset: 0x0002A6CE
		public HashSet(int initialCapacity)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0002C4E2 File Offset: 0x0002A6E2
		public HashSet(int initialCapacity, float loadFactor)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity, loadFactor);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0002C4F7 File Offset: 0x0002A6F7
		public HashSet(int initialCapacity, float loadFactor, global::System.Collections.IEqualityComparer equalityComparer)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity, loadFactor, equalityComparer);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0002C50D File Offset: 0x0002A70D
		public void Add(object item)
		{
			this._table[item] = item;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0002C51C File Offset: 0x0002A71C
		public void AddItems(global::System.Collections.IEnumerable items)
		{
			foreach (object item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0002C56C File Offset: 0x0002A76C
		public void AddItems(global::Infragistics.Windows.Helpers.HashSet source)
		{
			foreach (object item in source)
			{
				this.Add(item);
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0002C5BC File Offset: 0x0002A7BC
		public static bool AreEqual(global::Infragistics.Windows.Helpers.HashSet x, global::Infragistics.Windows.Helpers.HashSet y)
		{
			return x.Count == y.Count && x.IsSubsetOf(y);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0002C5D5 File Offset: 0x0002A7D5
		public void Clear()
		{
			this._table.Clear();
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0002C5E2 File Offset: 0x0002A7E2
		internal bool Contains(object item)
		{
			return this.Exists(item);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0002C5EB File Offset: 0x0002A7EB
		public void CopyTo(global::System.Array array, int arrayIndex)
		{
			this._table.Keys.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0002C600 File Offset: 0x0002A800
		public bool DoesIntersect(global::Infragistics.Windows.Helpers.HashSet s)
		{
			if (this.Count > s.Count)
			{
				return s.DoesIntersect(this);
			}
			foreach (object item in this)
			{
				if (s.Exists(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0002C670 File Offset: 0x0002A870
		public bool Exists(object item)
		{
			return this._table.ContainsKey(item);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0002C67E File Offset: 0x0002A87E
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._table.Keys.GetEnumerator();
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0002C690 File Offset: 0x0002A890
		public object GetEquivalentItem(object item)
		{
			return this._table[item];
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		public static global::Infragistics.Windows.Helpers.HashSet GetIntersection(global::Infragistics.Windows.Helpers.HashSet set1, global::Infragistics.Windows.Helpers.HashSet set2)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			if (set1.Count > set2.Count)
			{
				return global::Infragistics.Windows.Helpers.HashSet.GetIntersection(set2, set1);
			}
			foreach (object item in set1)
			{
				if (set2.Exists(item))
				{
					hashSet.Add(item);
				}
			}
			return hashSet;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002C718 File Offset: 0x0002A918
		public static global::Infragistics.Windows.Helpers.HashSet GetUnion(global::Infragistics.Windows.Helpers.HashSet set1, global::Infragistics.Windows.Helpers.HashSet set2)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(set1);
			hashSet.AddItems(set2);
			return hashSet;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002C73C File Offset: 0x0002A93C
		public bool IsSubsetOf(global::Infragistics.Windows.Helpers.HashSet s)
		{
			if (this.Count > s.Count)
			{
				return false;
			}
			foreach (object item in this)
			{
				if (!s.Exists(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		public void Remove(object item)
		{
			this._table.Remove(item);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
		public T[] ToArray<T>()
		{
			T[] array = new T[this.Count];
			int num = 0;
			foreach (object obj in this)
			{
				T t = (T)((object)obj);
				array[num++] = t;
			}
			return array;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x0002C820 File Offset: 0x0002AA20
		public int Count
		{
			get
			{
				return this._table.Count;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0002C82D File Offset: 0x0002AA2D
		public bool IsEmpty
		{
			get
			{
				return 0 == this.Count;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0002C838 File Offset: 0x0002AA38
		public bool IsSynchronized
		{
			get
			{
				return this._table.IsSynchronized;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0002C845 File Offset: 0x0002AA45
		public object SyncRoot
		{
			get
			{
				return this._table.SyncRoot;
			}
		}

		// Token: 0x04000672 RID: 1650
		private global::System.Collections.Hashtable _table;
	}
}
