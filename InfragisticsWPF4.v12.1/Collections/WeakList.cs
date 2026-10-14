using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x02000096 RID: 150
	public class WeakList<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable where T : class
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000158DF File Offset: 0x00013ADF
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x170000F8 RID: 248
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001590F File Offset: 0x00013B0F
		public object SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).SyncRoot;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001591C File Offset: 0x00013B1C
		public int Add(T item)
		{
			this._list.Add(this.CreateWeakReference(item));
			return this._list.Count - 1;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00015944 File Offset: 0x00013B44
		public void AddRange(global::System.Collections.Generic.IEnumerable<T> items)
		{
			foreach (T item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00015990 File Offset: 0x00013B90
		public void Clear()
		{
			this._list.Clear();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x000159A0 File Offset: 0x00013BA0
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

		// Token: 0x060005C8 RID: 1480 RVA: 0x000159D9 File Offset: 0x00013BD9
		public bool Contains(T value)
		{
			return this.IndexOf(value) >= 0;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000159E8 File Offset: 0x00013BE8
		public void CopyTo(T[] array, int index)
		{
			((global::System.Collections.ICollection)this).CopyTo(array, index);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000159F2 File Offset: 0x00013BF2
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakList<T>.Enumerator(this);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000159FC File Offset: 0x00013BFC
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

		// Token: 0x060005CC RID: 1484 RVA: 0x00015A38 File Offset: 0x00013C38
		public void Insert(int index, T item)
		{
			this._list.Insert(index, this.CreateWeakReference(item));
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00015A54 File Offset: 0x00013C54
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

		// Token: 0x060005CE RID: 1486 RVA: 0x00015A77 File Offset: 0x00013C77
		public void RemoveAt(int index)
		{
			this._list.RemoveAt(index);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00015A85 File Offset: 0x00013C85
		public void RemoveRange(int index, int count)
		{
			this._list.RemoveRange(index, count);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00015A94 File Offset: 0x00013C94
		private global::System.WeakReference CreateWeakReference(object item)
		{
			return new global::System.WeakReference(item);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00015A9C File Offset: 0x00013C9C
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

		// Token: 0x060005D2 RID: 1490 RVA: 0x00015AE3 File Offset: 0x00013CE3
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::Infragistics.Collections.WeakList<T>.Enumerator(this);
		}

		// Token: 0x170000FA RID: 250
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x00015B08 File Offset: 0x00013D08
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00015B12 File Offset: 0x00013D12
		bool global::System.Collections.Generic.ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00015B15 File Offset: 0x00013D15
		int global::System.Collections.IList.Add(object item)
		{
			return this.Add((T)((object)item));
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00015B23 File Offset: 0x00013D23
		bool global::System.Collections.IList.Contains(object item)
		{
			return item is T && this.Contains((T)((object)item));
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00015B3C File Offset: 0x00013D3C
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

		// Token: 0x060005DA RID: 1498 RVA: 0x00015B79 File Offset: 0x00013D79
		int global::System.Collections.IList.IndexOf(object item)
		{
			if (!(item is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)item));
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00015B91 File Offset: 0x00013D91
		void global::System.Collections.IList.Insert(int index, object item)
		{
			this.Insert(index, (T)((object)item));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00015BA0 File Offset: 0x00013DA0
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00015BA3 File Offset: 0x00013DA3
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00015BA6 File Offset: 0x00013DA6
		void global::System.Collections.IList.Remove(object item)
		{
			if (item is T)
			{
				this.Remove((T)((object)item));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00015BBD File Offset: 0x00013DBD
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).IsSynchronized;
			}
		}

		// Token: 0x040002B4 RID: 692
		private global::System.Collections.Generic.List<global::System.WeakReference> _list = new global::System.Collections.Generic.List<global::System.WeakReference>();

		// Token: 0x02000097 RID: 151
		private class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060005E1 RID: 1505 RVA: 0x00015BDD File Offset: 0x00013DDD
			public Enumerator(global::Infragistics.Collections.WeakList<T> list)
			{
				this._list = list;
				this.Reset();
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00015BF2 File Offset: 0x00013DF2
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x00015BFC File Offset: 0x00013DFC
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

			// Token: 0x060005E4 RID: 1508 RVA: 0x00015C6A File Offset: 0x00013E6A
			public void Reset()
			{
				this._index = -1;
				this._current = default(T);
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00015C7F File Offset: 0x00013E7F
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x00015C8C File Offset: 0x00013E8C
			void global::System.IDisposable.Dispose()
			{
			}

			// Token: 0x040002B5 RID: 693
			private global::Infragistics.Collections.WeakList<T> _list;

			// Token: 0x040002B6 RID: 694
			private T _current;

			// Token: 0x040002B7 RID: 695
			private int _index;
		}
	}
}
