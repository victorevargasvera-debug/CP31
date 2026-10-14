using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Collections
{
	// Token: 0x020000C5 RID: 197
	public class CollectionBase<T> : global::Infragistics.ICollectionBase<T>, global::Infragistics.ICollectionBase, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x0001AB44 File Offset: 0x00018D44
		public CollectionBase()
		{
			this._items = new global::System.Collections.ObjectModel.Collection<T>();
			this._unIndexedItems = new global::System.Collections.Generic.Dictionary<int, T>();
			this._unIndexedItemsReverse = new global::System.Collections.Generic.Dictionary<T, int>();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001AB70 File Offset: 0x00018D70
		protected virtual void OnNotifyCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.OnPropertyChanged("Count");
				break;
			}
			this.OnPropertyChanged("Item[]");
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, args);
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001ABCB File Offset: 0x00018DCB
		protected virtual T GetItem(int index)
		{
			return this.ResolveItem(index);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001ABD4 File Offset: 0x00018DD4
		protected virtual void AddItem(int index, T item)
		{
			this.AddItemSilently(index, item);
			this.OnItemAdded(index, item);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001ABE6 File Offset: 0x00018DE6
		protected virtual void InsertItem(int index, T item)
		{
			this.AddItemSilently(index, item);
			this.OnItemAdded(index, item);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		protected virtual void AddItemSilently(int index, T item)
		{
			if (index > this._items.Count)
			{
				this._unIndexedItems.Add(index, item);
				this._unIndexedItemsReverse.Add(item, index);
				return;
			}
			this._items.Insert(index, item);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001AC30 File Offset: 0x00018E30
		protected virtual void OnItemAdded(int index, T item)
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001AC48 File Offset: 0x00018E48
		protected virtual bool RemoveItem(int index)
		{
			T item = this[index];
			bool flag = this.RemoveItemSilently(index);
			if (flag)
			{
				this.OnItemRemoved(index, item);
			}
			return flag;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001AC74 File Offset: 0x00018E74
		protected virtual bool RemoveItemSilently(int index)
		{
			bool result = false;
			T t = default(T);
			if (this._unIndexedItems.TryGetValue(index, out t))
			{
				result = true;
				this._unIndexedItems.Remove(index);
				this._unIndexedItemsReverse.Remove(t);
			}
			else if (index >= 0 && index < this._items.Count)
			{
				t = this._items[index];
				result = this._items.Remove(t);
			}
			return result;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001ACE6 File Offset: 0x00018EE6
		protected virtual void OnItemRemoved(int index, T item)
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, item, index));
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001ACFB File Offset: 0x00018EFB
		protected virtual void ResetItems()
		{
			this.ResetItemsSilently();
			this.OnResetItems();
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001AD09 File Offset: 0x00018F09
		protected virtual void ResetItemsSilently()
		{
			this._items.Clear();
			this._unIndexedItems.Clear();
			this._unIndexedItemsReverse.Clear();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001AD2C File Offset: 0x00018F2C
		protected virtual void OnResetItems()
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001AD3C File Offset: 0x00018F3C
		protected virtual void ReplaceItem(int index, T newItem)
		{
			T t = this.ResolveItem(index);
			if (this._unIndexedItems.ContainsKey(index))
			{
				this._unIndexedItems[index] = newItem;
				this._unIndexedItemsReverse.Remove(t);
				this._unIndexedItemsReverse.Add(newItem, index);
			}
			else if (index < this._items.Count)
			{
				this._items[index] = newItem;
			}
			else
			{
				this.AddItemSilently(index, newItem);
			}
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, newItem, t, index));
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001ADC6 File Offset: 0x00018FC6
		protected virtual int GetCount()
		{
			return this._items.Count;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		private T ResolveItem(int index)
		{
			if (index > -1 && index < this._items.Count)
			{
				return this._items[index];
			}
			T result;
			if (this._unIndexedItems.TryGetValue(index, out result))
			{
				return result;
			}
			return default(T);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001AE3F File Offset: 0x0001903F
		protected virtual global::System.Collections.ObjectModel.Collection<T> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000747 RID: 1863 RVA: 0x0001AE48 File Offset: 0x00019048
		// (remove) Token: 0x06000748 RID: 1864 RVA: 0x0001AE80 File Offset: 0x00019080
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x06000749 RID: 1865 RVA: 0x0001AEB8 File Offset: 0x000190B8
		public virtual int IndexOf(T item)
		{
			if (item == null)
			{
				return -1;
			}
			int result = -1;
			if (this._unIndexedItemsReverse.TryGetValue(item, out result))
			{
				return result;
			}
			return this._items.IndexOf(item);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001AEEF File Offset: 0x000190EF
		public virtual void Insert(int index, T item)
		{
			this.InsertItem(index, item);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001AEF9 File Offset: 0x000190F9
		public void RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x1700011D RID: 285
		public T this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				this.ReplaceItem(index, value);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001AF16 File Offset: 0x00019116
		public virtual void Add(T item)
		{
			this.AddItem(this.Count, item);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001AF25 File Offset: 0x00019125
		public virtual void Clear()
		{
			this.ResetItems();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001AF2D File Offset: 0x0001912D
		public bool Contains(T item)
		{
			return (item != null && this._unIndexedItemsReverse.ContainsKey(item)) || this._items.Contains(item);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001AF54 File Offset: 0x00019154
		void global::System.Collections.Generic.ICollection<!0>.CopyTo(T[] array, int arrayIndex)
		{
			for (int i = arrayIndex; i < array.Length; i++)
			{
				array[i] = this.GetItem(i);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001AF7D File Offset: 0x0001917D
		public int Count
		{
			get
			{
				return this.GetCount();
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0001AF85 File Offset: 0x00019185
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001AF88 File Offset: 0x00019188
		public bool Remove(T item)
		{
			return this.RemoveItem(this.IndexOf(item));
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001AF97 File Offset: 0x00019197
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.CollectionBaseEnumerator<T>(this);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001AF9F File Offset: 0x0001919F
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001AFA7 File Offset: 0x000191A7
		int global::System.Collections.IList.Add(object value)
		{
			if (value is T)
			{
				this.Add((T)((object)value));
				return this.Count;
			}
			return -1;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001AFC5 File Offset: 0x000191C5
		bool global::System.Collections.IList.Contains(object value)
		{
			return value is T && this.Contains((T)((object)value));
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001AFDD File Offset: 0x000191DD
		int global::System.Collections.IList.IndexOf(object value)
		{
			if (value is T)
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001AFF5 File Offset: 0x000191F5
		void global::System.Collections.IList.Insert(int index, object value)
		{
			if (value is T)
			{
				this.Insert(index, (T)((object)value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0001B00C File Offset: 0x0001920C
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				global::System.Collections.IList items = this._items;
				return items != null && items.IsFixedSize;
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001B02B File Offset: 0x0001922B
		void global::System.Collections.IList.Remove(object value)
		{
			if (value is T)
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x17000121 RID: 289
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

		// Token: 0x0600075F RID: 1887 RVA: 0x0001B060 File Offset: 0x00019260
		public void CopyTo(global::System.Array array, int index)
		{
			int count = this.GetCount();
			for (int i = index; i < count; i++)
			{
				array.SetValue(this.GetItem(i), i);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0001B093 File Offset: 0x00019293
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0001B098 File Offset: 0x00019298
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					global::System.Collections.ICollection items = this._items;
					if (items != null)
					{
						this._syncRoot = items.SyncRoot;
					}
					else
					{
						global::System.Threading.Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
					}
				}
				return this._syncRoot;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001B0DD File Offset: 0x000192DD
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001B0DF File Offset: 0x000192DF
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001B0EE File Offset: 0x000192EE
		void global::Infragistics.ICollectionBase<!0>.AddItemSilently(int index, T item)
		{
			this.AddItemSilently(index, item);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001B0F8 File Offset: 0x000192F8
		void global::Infragistics.ICollectionBase.AddItemSilently(int index, object item)
		{
			this.AddItemSilently(index, (T)((object)item));
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001B107 File Offset: 0x00019307
		bool global::Infragistics.ICollectionBase.RemoveItemSilently(int index)
		{
			return this.RemoveItemSilently(index);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001B110 File Offset: 0x00019310
		void global::Infragistics.ICollectionBase.ResetItemsSilently()
		{
			this.ResetItemsSilently();
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000768 RID: 1896 RVA: 0x0001B118 File Offset: 0x00019318
		// (remove) Token: 0x06000769 RID: 1897 RVA: 0x0001B150 File Offset: 0x00019350
		private event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600076A RID: 1898 RVA: 0x0001B185 File Offset: 0x00019385
		// (remove) Token: 0x0600076B RID: 1899 RVA: 0x0001B18E File Offset: 0x0001938E
		event global::System.ComponentModel.PropertyChangedEventHandler global::System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		{
			add
			{
				this.PropertyChanged += value;
			}
			remove
			{
				this.PropertyChanged -= value;
			}
		}

		// Token: 0x040003A8 RID: 936
		private global::System.Collections.ObjectModel.Collection<T> _items;

		// Token: 0x040003A9 RID: 937
		private object _syncRoot;

		// Token: 0x040003AA RID: 938
		private global::System.Collections.Generic.Dictionary<int, T> _unIndexedItems;

		// Token: 0x040003AB RID: 939
		private global::System.Collections.Generic.Dictionary<T, int> _unIndexedItemsReverse;
	}
}
