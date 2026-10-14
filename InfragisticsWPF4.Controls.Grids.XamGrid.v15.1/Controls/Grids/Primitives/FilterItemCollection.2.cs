using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000E6 RID: 230
	public class FilterItemCollection<T> : global::Infragistics.Controls.Grids.Primitives.FilterItemCollection, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x0001F554 File Offset: 0x0001D754
		public override int AddSilently(object value)
		{
			if (value is T)
			{
				int count = this._list.Count;
				this._list.Add((T)((object)value));
				return count;
			}
			return -1;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001F589 File Offset: 0x0001D789
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001F59B File Offset: 0x0001D79B
		public override void CopyTo(global::System.Array array, int index)
		{
			this._list.CopyTo(array.Cast<T>().ToArray<T>(), index);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
		public override int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x0001F5C1 File Offset: 0x0001D7C1
		public override bool IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).IsSynchronized;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001F5CE File Offset: 0x0001D7CE
		public override object SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).SyncRoot;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		public override int Add(object value)
		{
			int num = this.AddSilently(value);
			if (num != -1)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, value, num));
			}
			return num;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001F604 File Offset: 0x0001D804
		public override void Clear()
		{
			this._list.Clear();
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001F61D File Offset: 0x0001D81D
		public override bool Contains(object value)
		{
			return value is T && this._list.Contains((T)((object)value));
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001F63A File Offset: 0x0001D83A
		public override int IndexOf(object value)
		{
			if (value is T)
			{
				return this._list.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001F657 File Offset: 0x0001D857
		public override void Insert(int index, object value)
		{
			this._list.Insert(index, (T)((object)value));
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, value, index));
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001F67C File Offset: 0x0001D87C
		public override void Remove(object value)
		{
			if (value is T)
			{
				T item = (T)((object)value);
				int num = this._list.IndexOf(item);
				if (num != -1 && this._list.Remove(item))
				{
					this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, value, num));
				}
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
		public override void RemoveAt(int index)
		{
			if (index >= 0 && index < this._list.Count)
			{
				T t = this._list[index];
				this._list.RemoveAt(index);
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, t, index));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0001F713 File Offset: 0x0001D913
		public override bool IsFixedSize
		{
			get
			{
				return ((global::System.Collections.IList)this._list).IsFixedSize;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001F720 File Offset: 0x0001D920
		public override bool IsReadOnly
		{
			get
			{
				return ((global::System.Collections.IList)this._list).IsReadOnly;
			}
		}

		// Token: 0x1700024F RID: 591
		public override object this[int index]
		{
			get
			{
				return this._list[index];
			}
			set
			{
				this._list[index] = (T)((object)value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001F754 File Offset: 0x0001D954
		protected global::System.Collections.Generic.List<T> List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001F75C File Offset: 0x0001D95C
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x040001DD RID: 477
		private readonly global::System.Collections.Generic.List<T> _list = new global::System.Collections.Generic.List<T>();
	}
}
