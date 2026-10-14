using System;
using System.Collections;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000171 RID: 369
	public class HashSet : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x00028333 File Offset: 0x00026533
		public HashSet()
		{
			this._table = new global::System.Collections.Hashtable();
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00028346 File Offset: 0x00026546
		public HashSet(int initialCapacity)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002835A File Offset: 0x0002655A
		public HashSet(int initialCapacity, float loadFactor)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity, loadFactor);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002836F File Offset: 0x0002656F
		public HashSet(int initialCapacity, float loadFactor, global::System.Collections.IEqualityComparer equalityComparer)
		{
			this._table = new global::System.Collections.Hashtable(initialCapacity, loadFactor, equalityComparer);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00028385 File Offset: 0x00026585
		public void Add(object item)
		{
			this._table[item] = item;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00028394 File Offset: 0x00026594
		public void AddItems(global::System.Collections.IEnumerable items)
		{
			foreach (object item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000283E4 File Offset: 0x000265E4
		public void AddItems(global::Infragistics.Windows.Helpers.HashSet source)
		{
			foreach (object item in source)
			{
				this.Add(item);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00028434 File Offset: 0x00026634
		public static bool AreEqual(global::Infragistics.Windows.Helpers.HashSet x, global::Infragistics.Windows.Helpers.HashSet y)
		{
			return x.Count == y.Count && x.IsSubsetOf(y);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0002844D File Offset: 0x0002664D
		public void Clear()
		{
			this._table.Clear();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0002845A File Offset: 0x0002665A
		internal bool Contains(object item)
		{
			return this.Exists(item);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00028463 File Offset: 0x00026663
		public void CopyTo(global::System.Array array, int arrayIndex)
		{
			this._table.Keys.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00028478 File Offset: 0x00026678
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

		// Token: 0x06000C6E RID: 3182 RVA: 0x000284E8 File Offset: 0x000266E8
		public bool Exists(object item)
		{
			return this._table.ContainsKey(item);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000284F6 File Offset: 0x000266F6
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._table.Keys.GetEnumerator();
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00028508 File Offset: 0x00026708
		public object GetEquivalentItem(object item)
		{
			return this._table[item];
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00028518 File Offset: 0x00026718
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

		// Token: 0x06000C72 RID: 3186 RVA: 0x00028590 File Offset: 0x00026790
		public static global::Infragistics.Windows.Helpers.HashSet GetUnion(global::Infragistics.Windows.Helpers.HashSet set1, global::Infragistics.Windows.Helpers.HashSet set2)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(set1);
			hashSet.AddItems(set2);
			return hashSet;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000285B4 File Offset: 0x000267B4
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

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002861C File Offset: 0x0002681C
		public void Remove(object item)
		{
			this._table.Remove(item);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0002862C File Offset: 0x0002682C
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

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00028698 File Offset: 0x00026898
		public int Count
		{
			get
			{
				return this._table.Count;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000286A5 File Offset: 0x000268A5
		public bool IsEmpty
		{
			get
			{
				return 0 == this.Count;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000286B0 File Offset: 0x000268B0
		public bool IsSynchronized
		{
			get
			{
				return this._table.IsSynchronized;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000286BD File Offset: 0x000268BD
		public object SyncRoot
		{
			get
			{
				return this._table.SyncRoot;
			}
		}

		// Token: 0x040005AD RID: 1453
		private global::System.Collections.Hashtable _table;
	}
}
