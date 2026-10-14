using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x020000B0 RID: 176
	public class WeakList<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable where T : class
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00018FBF File Offset: 0x000171BF
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x1700010C RID: 268
		public T this[int index]
		{
			get
			{
				return this.GetItemHelper(index);
			}
			set
			{
				this._list[index] = this.CreateWeakReference(value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00018FEF File Offset: 0x000171EF
		public object SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).SyncRoot;
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00018FFC File Offset: 0x000171FC
		public int Add(T item)
		{
			this._list.Add(this.CreateWeakReference(item));
			return this._list.Count - 1;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00019024 File Offset: 0x00017224
		public void AddRange(global::System.Collections.Generic.IEnumerable<T> items)
		{
			foreach (T item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00019070 File Offset: 0x00017270
		public void Clear()
		{
			this._list.Clear();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00019080 File Offset: 0x00017280
		public void Compact()
		{
			int i = 0;
			int count = this._list.Count;
			while (i < count)
			{
				this.GetItemHelper(i);
				i++;
			}
			global::Infragistics.CoreUtilities.RemoveAll<global::System.WeakReference>(this._list, null);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000190B9 File Offset: 0x000172B9
		public bool Contains(T value)
		{
			return this.IndexOf(value) >= 0;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000190C8 File Offset: 0x000172C8
		public void CopyTo(T[] array, int index)
		{
			((global::System.Collections.ICollection)this).CopyTo(array, index);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000190D2 File Offset: 0x000172D2
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakList<T>.Enumerator(this);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000190DC File Offset: 0x000172DC
		public int IndexOf(T value)
		{
			int i = 0;
			int count = this._list.Count;
			while (i < count)
			{
				if (value == this.GetItemHelper(i))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00019118 File Offset: 0x00017318
		public void Insert(int index, T item)
		{
			this._list.Insert(index, this.CreateWeakReference(item));
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00019134 File Offset: 0x00017334
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00019157 File Offset: 0x00017357
		public void RemoveAt(int index)
		{
			this._list.RemoveAt(index);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00019165 File Offset: 0x00017365
		public void RemoveRange(int index, int count)
		{
			this._list.RemoveRange(index, count);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00019174 File Offset: 0x00017374
		private global::System.WeakReference CreateWeakReference(object item)
		{
			return new global::System.WeakReference(item);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001917C File Offset: 0x0001737C
		private T GetItemHelper(int index)
		{
			global::System.WeakReference weakReference = this._list[index];
			T t = default(T);
			if (weakReference != null)
			{
				t = (T)((object)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference));
				if (t == null)
				{
					this._list[index] = null;
				}
			}
			return t;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000191C3 File Offset: 0x000173C3
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakList<T>.Enumerator(this);
		}

		// Token: 0x1700010E RID: 270
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (T)((object)value);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000191E8 File Offset: 0x000173E8
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000191F2 File Offset: 0x000173F2
		bool global::System.Collections.Generic.ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000191F5 File Offset: 0x000173F5
		int global::System.Collections.IList.Add(object item)
		{
			return this.Add((T)((object)item));
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00019203 File Offset: 0x00017403
		bool global::System.Collections.IList.Contains(object item)
		{
			return item is T && this.Contains((T)((object)item));
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001921C File Offset: 0x0001741C
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			int i = 0;
			int count = this._list.Count;
			while (i < count)
			{
				array.SetValue(this.GetItemHelper(i), index++);
				i++;
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00019259 File Offset: 0x00017459
		int global::System.Collections.IList.IndexOf(object item)
		{
			if (!(item is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)item));
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00019271 File Offset: 0x00017471
		void global::System.Collections.IList.Insert(int index, object item)
		{
			this.Insert(index, (T)((object)item));
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00019280 File Offset: 0x00017480
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00019283 File Offset: 0x00017483
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00019286 File Offset: 0x00017486
		void global::System.Collections.IList.Remove(object item)
		{
			if (item is T)
			{
				this.Remove((T)((object)item));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001929D File Offset: 0x0001749D
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).IsSynchronized;
			}
		}

		// Token: 0x04000338 RID: 824
		private global::System.Collections.Generic.List<global::System.WeakReference> _list = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x020000B1 RID: 177
		private class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060006C2 RID: 1730 RVA: 0x000192BD File Offset: 0x000174BD
			public Enumerator(global::Infragistics.Collections.WeakList<T> list)
			{
				this._list = list;
				this.Reset();
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000192D2 File Offset: 0x000174D2
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x000192DC File Offset: 0x000174DC
			public bool MoveNext()
			{
				this._current = default(T);
				while (++this._index < this._list.Count)
				{
					this._current = this._list[this._index];
					if (this._current != null)
					{
						break;
					}
				}
				return null != this._current;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x0001934A File Offset: 0x0001754A
			public void Reset()
			{
				this._index = -1;
				this._current = default(T);
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0001935F File Offset: 0x0001755F
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x0001936C File Offset: 0x0001756C
			void global::System.IDisposable.Dispose()
			{
			}

			// Token: 0x04000339 RID: 825
			private global::Infragistics.Collections.WeakList<T> _list;

			// Token: 0x0400033A RID: 826
			private T _current;

			// Token: 0x0400033B RID: 827
			private int _index;
		}
	}
}
