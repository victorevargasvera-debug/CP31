using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Collections
{
	// Token: 0x0200005F RID: 95
	[global::System.Serializable]
	public class ObservableCollectionExtended<T> : global::System.Collections.ObjectModel.ObservableCollection<T>, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x000103E8 File Offset: 0x0000E5E8
		public ObservableCollectionExtended() : this(true, false)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000103F2 File Offset: 0x0000E5F2
		public ObservableCollectionExtended(global::System.Collections.Generic.List<T> list) : base(list)
		{
			this.Initialize(true, false);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00010403 File Offset: 0x0000E603
		internal ObservableCollectionExtended(bool hookItemPropertyChanged, bool hookItemListeners)
		{
			this.Initialize(hookItemPropertyChanged, hookItemListeners);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00010413 File Offset: 0x0000E613
		public bool IsUpdating
		{
			get
			{
				return this._suspendCount != 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00010421 File Offset: 0x0000E621
		protected virtual bool NotifyItemsChanged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00010424 File Offset: 0x0000E624
		internal global::Infragistics.PropertyChangeListenerList PropChangeListeners
		{
			get
			{
				if (this._propChangeListeners == null)
				{
					this._propChangeListeners = new global::Infragistics.PropertyChangeListenerList();
				}
				return this._propChangeListeners;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001043F File Offset: 0x0000E63F
		public void AddRange(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			this.InsertRange(base.Count, collection);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00010450 File Offset: 0x0000E650
		public void BeginUpdate()
		{
			int num = global::System.Threading.Interlocked.Increment(ref this._suspendCount);
			if (num == 1)
			{
				this.OnBeginUpdate();
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00010473 File Offset: 0x0000E673
		public int BinarySearch(T item)
		{
			return this.BinarySearch(item, null);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00010480 File Offset: 0x0000E680
		public int BinarySearch(T item, global::System.Collections.Generic.IComparer<T> comparer)
		{
			global::System.Collections.Generic.List<T> list = base.Items as global::System.Collections.Generic.List<T>;
			if (list == null)
			{
				T[] array = new T[base.Count];
				base.CopyTo(array, 0);
				return global::System.Array.BinarySearch<T>(array, item, comparer);
			}
			return list.BinarySearch(item, comparer);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000104C4 File Offset: 0x0000E6C4
		public void EndUpdate()
		{
			if (global::System.Threading.Interlocked.Decrement(ref this._suspendCount) == 0)
			{
				if (this._hasChanged)
				{
					this._hasChanged = false;
					this.OnPropertyChanged("Count");
					this.OnPropertyChanged("Item[]");
					this.OnResetCollection();
				}
				this.OnEndUpdate();
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00010514 File Offset: 0x0000E714
		public virtual void InsertRange(int index, global::System.Collections.Generic.IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			if (notifyItemsChanged)
			{
				foreach (T itemAdded in collection)
				{
					this.OnItemAdding(itemAdded);
				}
			}
			foreach (T t in collection)
			{
				this.HookSubObject(t);
				base.Items.Insert(index++, t);
				if (notifyItemsChanged)
				{
					this.OnItemAdded(t);
				}
			}
			if (!this.IsUpdating)
			{
				this.OnPropertyChanged("Count");
				this.OnPropertyChanged("Item[]");
				this.OnResetCollection();
				return;
			}
			this._hasChanged = true;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00010600 File Offset: 0x0000E800
		public void ReInitialize(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			this.BeginUpdate();
			base.Clear();
			this.AddRange(collection);
			this.EndUpdate();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0001062C File Offset: 0x0000E82C
		public virtual void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			for (int i = index + count - 1; i >= index; i--)
			{
				T t = base[i];
				this.UnhookSubObject(t);
				base.Items.RemoveAt(i);
				if (notifyItemsChanged)
				{
					this.OnItemRemoved(t);
				}
			}
			if (!this.IsUpdating)
			{
				this.OnPropertyChanged("Count");
				this.OnPropertyChanged("Item[]");
				this.OnResetCollection();
				return;
			}
			this._hasChanged = true;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000106C5 File Offset: 0x0000E8C5
		protected virtual void OnBeginUpdate()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000106C7 File Offset: 0x0000E8C7
		protected virtual void OnEndUpdate()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000106C9 File Offset: 0x0000E8C9
		protected virtual void OnItemAdded(T itemAdded)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000106CB File Offset: 0x0000E8CB
		protected virtual void OnItemAdding(T itemAdded)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000106CD File Offset: 0x0000E8CD
		protected virtual void OnItemRemoved(T itemRemoved)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000106D0 File Offset: 0x0000E8D0
		private void HookSubObject(T item)
		{
			if (this._hookSubObjectsListeners)
			{
				global::Infragistics.ISupportPropertyChangeNotifications supportPropertyChangeNotifications = item as global::Infragistics.ISupportPropertyChangeNotifications;
				if (supportPropertyChangeNotifications != null)
				{
					supportPropertyChangeNotifications.AddListener(this.PropChangeListeners, false);
				}
			}
			if (this._hookSubObjects)
			{
				global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = item as global::System.ComponentModel.INotifyPropertyChanged;
				if (notifyPropertyChanged != null)
				{
					notifyPropertyChanged.PropertyChanged += this._propChangeHandler;
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00010724 File Offset: 0x0000E924
		private void Initialize(bool hookItemPropertyChanged, bool hookItemListeners)
		{
			this._hookSubObjects = (hookItemPropertyChanged && typeof(global::System.ComponentModel.INotifyPropertyChanged).IsAssignableFrom(typeof(T)));
			this._hookSubObjectsListeners = (hookItemListeners && typeof(global::Infragistics.ISupportPropertyChangeNotifications).IsAssignableFrom(typeof(T)));
			if (this._hookSubObjects || this._hookSubObjectsListeners)
			{
				if (this._hookSubObjects)
				{
					this._propChangeHandler = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnSubObjectChanged);
				}
				foreach (T item in base.Items)
				{
					this.HookSubObject(item);
				}
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000107E8 File Offset: 0x0000E9E8
		private void OnPropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000107F6 File Offset: 0x0000E9F6
		private void OnResetCollection()
		{
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00010804 File Offset: 0x0000EA04
		private void OnSubObjectChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnItemPropertyChanged(new global::Infragistics.Collections.ItemPropertyChangedEventArgs(sender, e.PropertyName));
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00010818 File Offset: 0x0000EA18
		private void UnhookSubObject(T item)
		{
			if (this._hookSubObjectsListeners)
			{
				global::Infragistics.ISupportPropertyChangeNotifications supportPropertyChangeNotifications = item as global::Infragistics.ISupportPropertyChangeNotifications;
				if (supportPropertyChangeNotifications != null)
				{
					supportPropertyChangeNotifications.RemoveListener(this.PropChangeListeners);
				}
			}
			if (this._hookSubObjects)
			{
				global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = item as global::System.ComponentModel.INotifyPropertyChanged;
				if (notifyPropertyChanged != null)
				{
					notifyPropertyChanged.PropertyChanged -= this._propChangeHandler;
				}
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0001086B File Offset: 0x0000EA6B
		protected virtual void OnItemPropertyChanged(global::Infragistics.Collections.ItemPropertyChangedEventArgs e)
		{
			if (this.ItemPropertyChanged != null)
			{
				this.ItemPropertyChanged(this, e);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060003CE RID: 974 RVA: 0x00010884 File Offset: 0x0000EA84
		// (remove) Token: 0x060003CF RID: 975 RVA: 0x000108BC File Offset: 0x0000EABC
		public event global::System.EventHandler<global::Infragistics.Collections.ItemPropertyChangedEventArgs> ItemPropertyChanged;

		// Token: 0x060003D0 RID: 976 RVA: 0x000108F4 File Offset: 0x0000EAF4
		protected override void ClearItems()
		{
			base.CheckReentrancy();
			if (this._hookSubObjects || this._hookSubObjectsListeners)
			{
				global::System.Collections.Generic.IList<T> items = base.Items;
				int i = 0;
				int count = items.Count;
				while (i < count)
				{
					this.UnhookSubObject(items[i]);
					i++;
				}
			}
			T[] array = this.NotifyItemsChanged ? new T[base.Items.Count] : null;
			if (array != null)
			{
				base.Items.CopyTo(array, 0);
			}
			base.Items.Clear();
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					this.OnItemRemoved(array[j]);
				}
			}
			if (this.IsUpdating)
			{
				this._hasChanged = true;
				return;
			}
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			this.OnResetCollection();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000109CC File Offset: 0x0000EBCC
		protected override void InsertItem(int index, T item)
		{
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			if (notifyItemsChanged)
			{
				this.OnItemAdding(item);
			}
			base.Items.Insert(index, item);
			this.HookSubObject(item);
			if (notifyItemsChanged)
			{
				this.OnItemAdded(item);
			}
			if (this.IsUpdating)
			{
				this._hasChanged = true;
				return;
			}
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00010A48 File Offset: 0x0000EC48
		protected override void MoveItem(int oldIndex, int newIndex)
		{
			base.CheckReentrancy();
			T t = base.Items[oldIndex];
			base.Items.RemoveAt(oldIndex);
			base.Items.Insert(newIndex, t);
			if (this.IsUpdating)
			{
				this._hasChanged = true;
				return;
			}
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, t, newIndex, oldIndex));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnCollectionChanged(e);
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.OnCollectionChanged(this, e);
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00010ACE File Offset: 0x0000ECCE
		protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.OnPropertyValueChanged(this, e.PropertyName, null);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		protected override void RemoveItem(int index)
		{
			base.CheckReentrancy();
			T t = base.Items[index];
			this.UnhookSubObject(t);
			base.Items.RemoveAt(index);
			if (this.NotifyItemsChanged)
			{
				this.OnItemRemoved(t);
			}
			if (this.IsUpdating)
			{
				this._hasChanged = true;
				return;
			}
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, t, index));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00010B70 File Offset: 0x0000ED70
		protected override void SetItem(int index, T item)
		{
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			if (notifyItemsChanged)
			{
				this.OnItemAdding(item);
			}
			T t = base.Items[index];
			this.UnhookSubObject(t);
			this.HookSubObject(item);
			base.Items[index] = item;
			if (notifyItemsChanged)
			{
				this.OnItemRemoved(t);
				this.OnItemAdded(item);
			}
			if (this.IsUpdating)
			{
				this._hasChanged = true;
				return;
			}
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, item, t, index));
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00010C01 File Offset: 0x0000EE01
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.PropChangeListeners.Add(listener, useWeakReference);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00010C10 File Offset: 0x0000EE10
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.PropChangeListeners.Remove(listener);
		}

		// Token: 0x04000147 RID: 327
		private int _suspendCount;

		// Token: 0x04000148 RID: 328
		private bool _hasChanged;

		// Token: 0x04000149 RID: 329
		private bool _hookSubObjects;

		// Token: 0x0400014A RID: 330
		private global::System.ComponentModel.PropertyChangedEventHandler _propChangeHandler;

		// Token: 0x0400014B RID: 331
		private global::Infragistics.PropertyChangeListenerList _propChangeListeners;

		// Token: 0x0400014C RID: 332
		private bool _hookSubObjectsListeners;
	}
}
