using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace Infragistics.Collections
{
	// Token: 0x02000076 RID: 118
	[global::System.Serializable]
	public class ObservableCollectionExtended<T> : global::System.Collections.ObjectModel.ObservableCollection<T>, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00012A20 File Offset: 0x00010C20
		public ObservableCollectionExtended() : this(true, false)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00012A2A File Offset: 0x00010C2A
		public ObservableCollectionExtended(global::System.Collections.Generic.List<T> list) : base(list)
		{
			this.Initialize(true, false);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00012A3B File Offset: 0x00010C3B
		internal ObservableCollectionExtended(bool hookItemPropertyChanged, bool hookItemListeners)
		{
			this.Initialize(hookItemPropertyChanged, hookItemListeners);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00012A4B File Offset: 0x00010C4B
		public bool IsUpdating
		{
			get
			{
				return this._suspendCount != 0;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00012A59 File Offset: 0x00010C59
		protected virtual bool NotifyItemsChanged
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00012A5C File Offset: 0x00010C5C
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

		// Token: 0x0600046E RID: 1134 RVA: 0x00012A77 File Offset: 0x00010C77
		public void AddRange(global::System.Collections.Generic.IEnumerable<T> collection)
		{
			this.InsertRange(base.Count, collection);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00012A88 File Offset: 0x00010C88
		public void BeginUpdate()
		{
			int num = global::System.Threading.Interlocked.Increment(ref this._suspendCount);
			if (num == 1)
			{
				this.OnBeginUpdate();
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00012AAB File Offset: 0x00010CAB
		public int BinarySearch(T item)
		{
			return this.BinarySearch(item, null);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00012AB8 File Offset: 0x00010CB8
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

		// Token: 0x06000472 RID: 1138 RVA: 0x00012AFC File Offset: 0x00010CFC
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

		// Token: 0x06000473 RID: 1139 RVA: 0x00012B4C File Offset: 0x00010D4C
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

		// Token: 0x06000474 RID: 1140 RVA: 0x00012C38 File Offset: 0x00010E38
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

		// Token: 0x06000475 RID: 1141 RVA: 0x00012C64 File Offset: 0x00010E64
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
				if (notifyItemsChanged)
				{
					this.OnItemRemoving(t);
				}
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

		// Token: 0x06000476 RID: 1142 RVA: 0x00012D07 File Offset: 0x00010F07
		protected virtual void OnBeginUpdate()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00012D09 File Offset: 0x00010F09
		protected virtual void OnEndUpdate()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00012D0B File Offset: 0x00010F0B
		protected virtual void OnItemAdded(T itemAdded)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00012D0D File Offset: 0x00010F0D
		protected virtual void OnItemAdding(T itemAdded)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00012D0F File Offset: 0x00010F0F
		protected virtual void OnItemRemoved(T itemRemoved)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00012D11 File Offset: 0x00010F11
		protected virtual void OnItemRemoving(T item)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00012D14 File Offset: 0x00010F14
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

		// Token: 0x0600047D RID: 1149 RVA: 0x00012D68 File Offset: 0x00010F68
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

		// Token: 0x0600047E RID: 1150 RVA: 0x00012E2C File Offset: 0x0001102C
		private void OnPropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00012E3A File Offset: 0x0001103A
		private void OnResetCollection()
		{
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00012E48 File Offset: 0x00011048
		private void OnSubObjectChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnItemPropertyChanged(new global::Infragistics.Collections.ItemPropertyChangedEventArgs(sender, e.PropertyName));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00012E5C File Offset: 0x0001105C
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

		// Token: 0x06000482 RID: 1154 RVA: 0x00012EAF File Offset: 0x000110AF
		protected virtual void OnItemPropertyChanged(global::Infragistics.Collections.ItemPropertyChangedEventArgs e)
		{
			if (this.ItemPropertyChanged != null)
			{
				this.ItemPropertyChanged(this, e);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000483 RID: 1155 RVA: 0x00012EC8 File Offset: 0x000110C8
		// (remove) Token: 0x06000484 RID: 1156 RVA: 0x00012F00 File Offset: 0x00011100
		public event global::System.EventHandler<global::Infragistics.Collections.ItemPropertyChangedEventArgs> ItemPropertyChanged;

		// Token: 0x06000485 RID: 1157 RVA: 0x00012F38 File Offset: 0x00011138
		protected override void ClearItems()
		{
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			T[] array = notifyItemsChanged ? new T[base.Items.Count] : null;
			if (array != null)
			{
				base.Items.CopyTo(array, 0);
			}
			if (notifyItemsChanged)
			{
				for (int i = 0; i < array.Length; i++)
				{
					this.OnItemRemoving(array[i]);
				}
			}
			if (this._hookSubObjects || this._hookSubObjectsListeners)
			{
				global::System.Collections.Generic.IList<T> items = base.Items;
				int j = 0;
				int count = items.Count;
				while (j < count)
				{
					this.UnhookSubObject(items[j]);
					j++;
				}
			}
			base.Items.Clear();
			if (array != null)
			{
				for (int k = 0; k < array.Length; k++)
				{
					this.OnItemRemoved(array[k]);
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

		// Token: 0x06000486 RID: 1158 RVA: 0x00013030 File Offset: 0x00011230
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

		// Token: 0x06000487 RID: 1159 RVA: 0x000130AC File Offset: 0x000112AC
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

		// Token: 0x06000488 RID: 1160 RVA: 0x00013114 File Offset: 0x00011314
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnCollectionChanged(e);
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.OnCollectionChanged(this, e);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00013132 File Offset: 0x00011332
		protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (this._propChangeListeners != null)
			{
				this._propChangeListeners.OnPropertyValueChanged(this, e.PropertyName, null);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00013158 File Offset: 0x00011358
		protected override void RemoveItem(int index)
		{
			base.CheckReentrancy();
			T t = base.Items[index];
			bool notifyItemsChanged = this.NotifyItemsChanged;
			if (notifyItemsChanged)
			{
				this.OnItemRemoving(t);
			}
			this.UnhookSubObject(t);
			base.Items.RemoveAt(index);
			if (notifyItemsChanged)
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

		// Token: 0x0600048B RID: 1163 RVA: 0x000131E0 File Offset: 0x000113E0
		protected override void SetItem(int index, T item)
		{
			base.CheckReentrancy();
			bool notifyItemsChanged = this.NotifyItemsChanged;
			if (notifyItemsChanged)
			{
				this.OnItemRemoving(base.Items[index]);
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

		// Token: 0x0600048C RID: 1164 RVA: 0x00013283 File Offset: 0x00011483
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.PropChangeListeners.Add(listener, useWeakReference);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00013292 File Offset: 0x00011492
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.PropChangeListeners.Remove(listener);
		}

		// Token: 0x040001B5 RID: 437
		private int _suspendCount;

		// Token: 0x040001B6 RID: 438
		private bool _hasChanged;

		// Token: 0x040001B7 RID: 439
		private bool _hookSubObjects;

		// Token: 0x040001B8 RID: 440
		private global::System.ComponentModel.PropertyChangedEventHandler _propChangeHandler;

		// Token: 0x040001B9 RID: 441
		private global::Infragistics.PropertyChangeListenerList _propChangeListeners;

		// Token: 0x040001BA RID: 442
		private bool _hookSubObjectsListeners;
	}
}
