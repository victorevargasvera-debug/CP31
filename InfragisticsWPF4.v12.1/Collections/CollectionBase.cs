using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Collections
{
	// Token: 0x020000AB RID: 171
	public class CollectionBase<T> : global::Infragistics.ICollectionBase<T>, global::Infragistics.ICollectionBase, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x00017424 File Offset: 0x00015624
		public CollectionBase()
		{
			this._items = new global::System.Collections.ObjectModel.Collection<T>();
			this._unIndexedItems = new global::System.Collections.Generic.Dictionary<int, T>();
			this._unIndexedItemsReverse = new global::System.Collections.Generic.Dictionary<T, int>();
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00017450 File Offset: 0x00015650
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

		// Token: 0x06000653 RID: 1619 RVA: 0x000174AB File Offset: 0x000156AB
		protected virtual T GetItem(int index)
		{
			return this.ResolveItem(index);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000174B4 File Offset: 0x000156B4
		protected virtual void AddItem(int index, T item)
		{
			this.AddItemSilently(index, item);
			this.OnItemAdded(index, item);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000174C6 File Offset: 0x000156C6
		protected virtual void InsertItem(int index, T item)
		{
			this.AddItemSilently(index, item);
			this.OnItemAdded(index, item);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000174D8 File Offset: 0x000156D8
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

		// Token: 0x06000657 RID: 1623 RVA: 0x00017510 File Offset: 0x00015710
		protected virtual void OnItemAdded(int index, T item)
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00017528 File Offset: 0x00015728
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

		// Token: 0x06000659 RID: 1625 RVA: 0x00017554 File Offset: 0x00015754
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

		// Token: 0x0600065A RID: 1626 RVA: 0x000175C6 File Offset: 0x000157C6
		protected virtual void OnItemRemoved(int index, T item)
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, item, index));
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000175DB File Offset: 0x000157DB
		protected virtual void ResetItems()
		{
			this.ResetItemsSilently();
			this.OnResetItems();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000175E9 File Offset: 0x000157E9
		protected virtual void ResetItemsSilently()
		{
			this._items.Clear();
			this._unIndexedItems.Clear();
			this._unIndexedItemsReverse.Clear();
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001760C File Offset: 0x0001580C
		protected virtual void OnResetItems()
		{
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001761C File Offset: 0x0001581C
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

		// Token: 0x0600065F RID: 1631 RVA: 0x000176A6 File Offset: 0x000158A6
		protected virtual int GetCount()
		{
			return this._items.Count;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000176B4 File Offset: 0x000158B4
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000176D8 File Offset: 0x000158D8
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001771F File Offset: 0x0001591F
		protected virtual global::System.Collections.ObjectModel.Collection<T> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000663 RID: 1635 RVA: 0x00017728 File Offset: 0x00015928
		// (remove) Token: 0x06000664 RID: 1636 RVA: 0x00017760 File Offset: 0x00015960
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x06000665 RID: 1637 RVA: 0x00017798 File Offset: 0x00015998
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

		// Token: 0x06000666 RID: 1638 RVA: 0x000177CF File Offset: 0x000159CF
		public virtual void Insert(int index, T item)
		{
			this.InsertItem(index, item);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000177D9 File Offset: 0x000159D9
		public void RemoveAt(int index)
		{
			this.RemoveItem(index);
		}

		// Token: 0x17000109 RID: 265
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

		// Token: 0x0600066A RID: 1642 RVA: 0x000177F6 File Offset: 0x000159F6
		public virtual void Add(T item)
		{
			this.AddItem(this.Count, item);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00017805 File Offset: 0x00015A05
		public virtual void Clear()
		{
			this.ResetItems();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001780D File Offset: 0x00015A0D
		public bool Contains(T item)
		{
			return (item != null && this._unIndexedItemsReverse.ContainsKey(item)) || this._items.Contains(item);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00017834 File Offset: 0x00015A34
		void global::System.Collections.Generic.ICollection<!0>.CopyTo(T[] array, int arrayIndex)
		{
			for (int i = arrayIndex; i < array.Length; i++)
			{
				array[i] = this.GetItem(i);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001785D File Offset: 0x00015A5D
		public int Count
		{
			get
			{
				return this.GetCount();
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00017865 File Offset: 0x00015A65
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00017868 File Offset: 0x00015A68
		public bool Remove(T item)
		{
			return this.RemoveItem(this.IndexOf(item));
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00017877 File Offset: 0x00015A77
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.Collections.CollectionBaseEnumerator<T>(this);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001787F File Offset: 0x00015A7F
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00017887 File Offset: 0x00015A87
		int global::System.Collections.IList.Add(object value)
		{
			if (value is T)
			{
				this.Add((T)((object)value));
				return this.Count;
			}
			return -1;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000178A5 File Offset: 0x00015AA5
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.Contains((T)((object)value));
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000178B3 File Offset: 0x00015AB3
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOf((T)((object)value));
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000178C1 File Offset: 0x00015AC1
		void global::System.Collections.IList.Insert(int index, object value)
		{
			this.Insert(index, (T)((object)value));
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000178D0 File Offset: 0x00015AD0
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				global::System.Collections.IList items = this._items;
				return items != null && items.IsFixedSize;
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000178EF File Offset: 0x00015AEF
		void global::System.Collections.IList.Remove(object value)
		{
			this.Remove((T)((object)value));
		}

		// Token: 0x1700010D RID: 269
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

		// Token: 0x0600067B RID: 1659 RVA: 0x0001791C File Offset: 0x00015B1C
		public void CopyTo(global::System.Array array, int index)
		{
			int count = this.GetCount();
			for (int i = index; i < count; i++)
			{
				array.SetValue(this.GetItem(i), i);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001794F File Offset: 0x00015B4F
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00017954 File Offset: 0x00015B54
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

		// Token: 0x0600067E RID: 1662 RVA: 0x00017999 File Offset: 0x00015B99
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001799B File Offset: 0x00015B9B
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000179AA File Offset: 0x00015BAA
		void global::Infragistics.ICollectionBase<!0>.AddItemSilently(int index, T item)
		{
			this.AddItemSilently(index, item);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000179B4 File Offset: 0x00015BB4
		void global::Infragistics.ICollectionBase.AddItemSilently(int index, object item)
		{
			this.AddItemSilently(index, (T)((object)item));
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000179C3 File Offset: 0x00015BC3
		bool global::Infragistics.ICollectionBase.RemoveItemSilently(int index)
		{
			return this.RemoveItemSilently(index);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000179CC File Offset: 0x00015BCC
		void global::Infragistics.ICollectionBase.ResetItemsSilently()
		{
			this.ResetItemsSilently();
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000684 RID: 1668 RVA: 0x000179D4 File Offset: 0x00015BD4
		// (remove) Token: 0x06000685 RID: 1669 RVA: 0x00017A0C File Offset: 0x00015C0C
		private event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000686 RID: 1670 RVA: 0x00017A41 File Offset: 0x00015C41
		// (remove) Token: 0x06000687 RID: 1671 RVA: 0x00017A4A File Offset: 0x00015C4A
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

		// Token: 0x04000306 RID: 774
		private global::System.Collections.ObjectModel.Collection<T> _items;

		// Token: 0x04000307 RID: 775
		private object _syncRoot;

		// Token: 0x04000308 RID: 776
		private global::System.Collections.Generic.Dictionary<int, T> _unIndexedItems;

		// Token: 0x04000309 RID: 777
		private global::System.Collections.Generic.Dictionary<T, int> _unIndexedItemsReverse;
	}
}
