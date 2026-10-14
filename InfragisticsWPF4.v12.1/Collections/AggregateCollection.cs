using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Infragistics.Collections
{
	// Token: 0x02000007 RID: 7
	internal class AggregateCollection<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000025E4 File Offset: 0x000007E4
		internal AggregateCollection() : this(null)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025ED File Offset: 0x000007ED
		internal AggregateCollection(global::System.Collections.Generic.IList<global::System.Collections.IEnumerable> lists)
		{
			this._listener = new global::Infragistics.PropertyChangeListener<global::Infragistics.Collections.AggregateCollection<T>>(this, new global::System.Action<global::Infragistics.Collections.AggregateCollection<T>, object, string, object>(global::Infragistics.Collections.AggregateCollection<T>.OnContainedCollectionNotification), true);
			this._nccHandler = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.OnContainedCollectionChanged);
			this.SetCollections(lists);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001B RID: 27 RVA: 0x00002627 File Offset: 0x00000827
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x00002640 File Offset: 0x00000840
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				this._collectionChanged = (global::System.Delegate.Combine(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
			remove
			{
				this._collectionChanged = (global::System.Delegate.Remove(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000265C File Offset: 0x0000085C
		private void HookUnhook(global::System.Collections.Generic.IList<global::System.Collections.IEnumerable> lists, bool hook, bool hookUnhookFromSubLists)
		{
			if (lists != null)
			{
				global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = lists as global::System.Collections.Specialized.INotifyCollectionChanged;
				if (notifyCollectionChanged != null)
				{
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.OnCollectionListChanged);
					if (hook)
					{
						notifyCollectionChanged.CollectionChanged += value;
					}
					else
					{
						notifyCollectionChanged.CollectionChanged -= value;
					}
				}
				if (hookUnhookFromSubLists)
				{
					int i = 0;
					int count = lists.Count;
					while (i < count)
					{
						this.HookUnhookSubList(lists[i], hook);
						i++;
					}
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000026BC File Offset: 0x000008BC
		private void HookUnhookSubList(global::System.Collections.IEnumerable ii, bool hook)
		{
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = ii as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				if (hook)
				{
					notifyCollectionChanged.CollectionChanged += this._nccHandler;
				}
				else
				{
					notifyCollectionChanged.CollectionChanged -= this._nccHandler;
				}
			}
			global::Infragistics.ISupportPropertyChangeNotifications supportPropertyChangeNotifications = ii as global::Infragistics.ISupportPropertyChangeNotifications;
			if (supportPropertyChangeNotifications != null)
			{
				if (hook)
				{
					supportPropertyChangeNotifications.AddListener(this._listener, false);
					return;
				}
				supportPropertyChangeNotifications.RemoveListener(this._listener);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002718 File Offset: 0x00000918
		private void InsertMultiItemHelper(int i, bool raiseReset)
		{
			global::System.Collections.IEnumerable enumerable = this._lists[i];
			global::System.Collections.Generic.IEnumerable<T> enumerable2 = enumerable as global::System.Collections.Generic.IEnumerable<T>;
			if (enumerable2 == null)
			{
				if (enumerable is global::System.Collections.IList)
				{
					enumerable2 = new global::Infragistics.CoreUtilities.TypedList<T>(enumerable as global::System.Collections.IList);
				}
				else
				{
					enumerable2 = new global::Infragistics.Collections.TypedEnumerable<T>(enumerable);
				}
			}
			this._sparseArr.Insert(i, new global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem(enumerable, enumerable2));
			this.HookUnhookSubList(enumerable, true);
			if (raiseReset)
			{
				this.RaiseCollectionReset();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002780 File Offset: 0x00000980
		private void OnCollectionListChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (e.NewItems != null)
				{
					int i = 0;
					int count = e.NewItems.Count;
					while (i < count)
					{
						this.InsertMultiItemHelper(e.NewStartingIndex + i, true);
						i++;
					}
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (e.OldItems != null)
				{
					int j = 0;
					int count2 = e.OldItems.Count;
					while (j < count2)
					{
						this.RemoveMultiItemHelper(e.OldStartingIndex + j, e.OldItems[j] as global::System.Collections.IEnumerable, true);
						j++;
					}
					return;
				}
				break;
			}
			this.SetCollections(this._lists);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002824 File Offset: 0x00000A24
		private void OnContainedCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = null;
			global::System.Collections.IEnumerable list = sender as global::System.Collections.IEnumerable;
			global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem correspondingMultiItem = this._sparseArr.GetCorrespondingMultiItem(list);
			if (correspondingMultiItem != null)
			{
				notifyCollectionChangedEventArgs = correspondingMultiItem.ProcessHelper(this._sparseArr, e);
			}
			if (notifyCollectionChangedEventArgs == null)
			{
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
			}
			this.RaiseCollectionChanged(notifyCollectionChangedEventArgs);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000286C File Offset: 0x00000A6C
		private static void OnContainedCollectionNotification(global::Infragistics.Collections.AggregateCollection<T> owner, object sender, string propName, object extraInfo)
		{
			global::System.Collections.IEnumerable enumerable = sender as global::System.Collections.IEnumerable;
			if (enumerable != null)
			{
				global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem correspondingMultiItem = owner._sparseArr.GetCorrespondingMultiItem(enumerable);
				if (correspondingMultiItem != null)
				{
					return;
				}
			}
			if (owner._propChangeListeners != null)
			{
				owner._propChangeListeners.OnPropertyValueChanged(sender, propName, extraInfo);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000028AC File Offset: 0x00000AAC
		private void RemoveMultiItemHelper(int i, global::System.Collections.IEnumerable item, bool raiseReset)
		{
			global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem multiItem = (global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem)this._sparseArr[i];
			if (multiItem != null)
			{
				this.HookUnhookSubList(item, false);
				this._sparseArr.RemoveAt(i);
				if (raiseReset)
				{
					this.RaiseCollectionReset();
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028EC File Offset: 0x00000AEC
		private void SetCollections(global::System.Collections.Generic.IList<global::System.Collections.IEnumerable> lists)
		{
			this.HookUnhook(this._lists, false, true);
			this._lists = lists;
			int num = (lists != null) ? lists.Count : 0;
			this._sparseArr = new global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray();
			for (int i = 0; i < num; i++)
			{
				this.InsertMultiItemHelper(i, false);
			}
			this.HookUnhook(this._lists, true, false);
			this.RaiseCollectionReset();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000294E File Offset: 0x00000B4E
		internal void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
		{
			if (this._collectionChanged != null)
			{
				this._collectionChanged(this, eventArgs);
			}
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.OnCollectionChanged(this, eventArgs);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000297A File Offset: 0x00000B7A
		internal void RaiseCollectionReset()
		{
			this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002990 File Offset: 0x00000B90
		public global::System.Collections.Generic.IList<global::System.Collections.IEnumerable> Collections
		{
			get
			{
				return this._lists;
			}
			set
			{
				if (this._lists != value)
				{
					this.SetCollections(value);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000029A2 File Offset: 0x00000BA2
		public int Count
		{
			get
			{
				return this._sparseArr.GetAggregateCount();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000029AF File Offset: 0x00000BAF
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029B2 File Offset: 0x00000BB2
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000029BA File Offset: 0x00000BBA
		int global::System.Collections.IList.Add(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return -1;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029C2 File Offset: 0x00000BC2
		void global::System.Collections.IList.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029C9 File Offset: 0x00000BC9
		bool global::System.Collections.IList.Contains(object value)
		{
			return value is T && this.Contains((T)((object)value));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029E1 File Offset: 0x00000BE1
		int global::System.Collections.IList.IndexOf(object value)
		{
			if (!(value is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)value));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029F9 File Offset: 0x00000BF9
		void global::System.Collections.IList.Insert(int index, object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002A00 File Offset: 0x00000C00
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A03 File Offset: 0x00000C03
		void global::System.Collections.IList.Remove(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002A0A File Offset: 0x00000C0A
		void global::System.Collections.IList.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x1700000C RID: 12
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A26 File Offset: 0x00000C26
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			global::Infragistics.CoreUtilities.CopyTo(this, array, index);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002A30 File Offset: 0x00000C30
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002A33 File Offset: 0x00000C33
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A36 File Offset: 0x00000C36
		public int IndexOf(T item)
		{
			return this._sparseArr.GetAggregateIndex(item);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A44 File Offset: 0x00000C44
		public void Insert(int index, T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A4B File Offset: 0x00000C4B
		void global::System.Collections.Generic.IList<!0>.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x1700000F RID: 15
		public T this[int index]
		{
			get
			{
				T result;
				if (this._sparseArr.GetItemAtAggregateIndex(index, out result))
				{
					return result;
				}
				throw new global::System.IndexOutOfRangeException();
			}
			set
			{
				global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A7F File Offset: 0x00000C7F
		public void Add(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002A86 File Offset: 0x00000C86
		void global::System.Collections.Generic.ICollection<!0>.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002A8D File Offset: 0x00000C8D
		public bool Contains(T item)
		{
			return this._sparseArr.GetAggregateIndex(item) >= 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public void CopyTo(T[] array, int arrayIndex)
		{
			global::Infragistics.CoreUtilities.CopyTo<T>(this, array, arrayIndex);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002AAB File Offset: 0x00000CAB
		public bool Remove(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return false;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002ACA File Offset: 0x00000CCA
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>.Enumerator(this._lists.Select(delegate(global::System.Collections.IEnumerable ii)
			{
				if (!(ii is global::System.Collections.Generic.IEnumerable<T>))
				{
					return new global::Infragistics.Collections.TypedEnumerable<T>(ii);
				}
				return (global::System.Collections.Generic.IEnumerable<T>)ii;
			}));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002AF9 File Offset: 0x00000CF9
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			if (this._propChangeListeners == null)
			{
				this._propChangeListeners = new global::Infragistics.PropertyChangeListenerList();
			}
			this._propChangeListeners.Add(listener, useWeakReference);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002B1B File Offset: 0x00000D1B
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.Remove(listener);
			}
		}

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.IList<global::System.Collections.IEnumerable> _lists;

		// Token: 0x0400000E RID: 14
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x0400000F RID: 15
		private global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray _sparseArr;

		// Token: 0x04000010 RID: 16
		private global::Infragistics.PropertyChangeListenerList _propChangeListeners;

		// Token: 0x04000011 RID: 17
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _nccHandler;

		// Token: 0x04000012 RID: 18
		private global::Infragistics.PropertyChangeListener<global::Infragistics.Collections.AggregateCollection<T>> _listener;

		// Token: 0x02000012 RID: 18
		private class AggregateSparseArray : global::Infragistics.Collections.SparseArray
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x00005DAA File Offset: 0x00003FAA
			internal AggregateSparseArray() : base(true, 2, 1f)
			{
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00005DB9 File Offset: 0x00003FB9
			internal void DirtyItemScrollCount(global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem item)
			{
				base.NotifyItemScrollCountChanged(item);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00005DC2 File Offset: 0x00003FC2
			internal int GetAggregateCount()
			{
				return base.GetScrollCount();
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00005DCA File Offset: 0x00003FCA
			internal int GetAggregateIndex(global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem multiItem)
			{
				return base.GetScrollIndexOf(multiItem, true);
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00005DD4 File Offset: 0x00003FD4
			internal int GetAggregateIndex(T item)
			{
				int i = 0;
				int count = base.Count;
				while (i < count)
				{
					global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem multiItem = (global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem)base[i];
					int indexOf = global::Infragistics.CoreUtilities.GetIndexOf<T>(multiItem._list, item);
					if (indexOf >= 0)
					{
						int aggregateIndex = this.GetAggregateIndex(multiItem);
						if (aggregateIndex >= 0)
						{
							return aggregateIndex + indexOf;
						}
					}
					i++;
				}
				return -1;
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00005E28 File Offset: 0x00004028
			internal global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem GetCorrespondingMultiItem(global::System.Collections.IEnumerable list)
			{
				int i = 0;
				int count = base.Count;
				while (i < count)
				{
					global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem multiItem = (global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray.MultiItem)base[i];
					if (multiItem._originalList == list || multiItem._list == list)
					{
						return multiItem;
					}
					i++;
				}
				return null;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00005E6C File Offset: 0x0000406C
			internal bool GetItemAtAggregateIndex(int index, out T item)
			{
				object itemAtScrollIndex = base.GetItemAtScrollIndex(index, null);
				if (itemAtScrollIndex is T)
				{
					item = (T)((object)itemAtScrollIndex);
					return true;
				}
				item = default(T);
				return false;
			}

			// Token: 0x02000015 RID: 21
			internal class MultiItem : global::Infragistics.Collections.ISparseArrayMultiItem, global::Infragistics.Collections.ISparseArrayItem
			{
				// Token: 0x060000F1 RID: 241 RVA: 0x00005EA0 File Offset: 0x000040A0
				internal MultiItem(global::System.Collections.IEnumerable originalList, global::System.Collections.Generic.IEnumerable<T> list)
				{
					this._originalList = originalList;
					this._list = list;
				}

				// Token: 0x060000F2 RID: 242 RVA: 0x00005EB8 File Offset: 0x000040B8
				internal global::System.Collections.Specialized.NotifyCollectionChangedEventArgs ProcessHelper(global::Infragistics.Collections.AggregateCollection<T>.AggregateSparseArray sparseArr, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
				{
					global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = null;
					int aggregateIndex = sparseArr.GetAggregateIndex(this);
					if (aggregateIndex >= 0)
					{
						switch (args.Action)
						{
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
							notifyCollectionChangedEventArgs = global::Infragistics.CoreUtilities.CreateAddRemoveNCCArgs(true, args.NewItems, aggregateIndex + args.NewStartingIndex);
							break;
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
							notifyCollectionChangedEventArgs = global::Infragistics.CoreUtilities.CreateAddRemoveNCCArgs(false, args.OldItems, aggregateIndex + args.OldStartingIndex);
							break;
						case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
							notifyCollectionChangedEventArgs = global::Infragistics.CoreUtilities.CreateReplaceNCCArgs(args.OldItems, args.NewItems, aggregateIndex + args.NewStartingIndex);
							break;
						}
					}
					if (notifyCollectionChangedEventArgs != null)
					{
						sparseArr.DirtyItemScrollCount(this);
					}
					else
					{
						sparseArr.DirtyScrollCountInfo();
					}
					return notifyCollectionChangedEventArgs;
				}

				// Token: 0x17000024 RID: 36
				// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005F4B File Offset: 0x0000414B
				public int ScrollCount
				{
					get
					{
						return global::Infragistics.CoreUtilities.GetCount(this._list);
					}
				}

				// Token: 0x060000F4 RID: 244 RVA: 0x00005F58 File Offset: 0x00004158
				public object GetItemAtScrollIndex(int scrollIndex)
				{
					T t;
					if (global::Infragistics.CoreUtilities.GetItemAt<T>(this._list, scrollIndex, out t))
					{
						return t;
					}
					return null;
				}

				// Token: 0x060000F5 RID: 245 RVA: 0x00005F7D File Offset: 0x0000417D
				public object GetOwnerData(global::Infragistics.Collections.SparseArray context)
				{
					return this._ownerData;
				}

				// Token: 0x060000F6 RID: 246 RVA: 0x00005F85 File Offset: 0x00004185
				public void SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
				{
					this._ownerData = ownerData;
				}

				// Token: 0x04000043 RID: 67
				internal global::System.Collections.IEnumerable _originalList;

				// Token: 0x04000044 RID: 68
				internal global::System.Collections.Generic.IEnumerable<T> _list;

				// Token: 0x04000045 RID: 69
				private object _ownerData;
			}
		}
	}
}
