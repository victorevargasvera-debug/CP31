using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x02000082 RID: 130
	public class ReadOnlyNotifyCollection<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0001428E File Offset: 0x0001248E
		public ReadOnlyNotifyCollection(global::System.Collections.Generic.IList<T> source)
		{
			this.SetSourceCollection(source);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060004F7 RID: 1271 RVA: 0x0001429D File Offset: 0x0001249D
		// (remove) Token: 0x060004F8 RID: 1272 RVA: 0x000142B6 File Offset: 0x000124B6
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

		// Token: 0x170000AF RID: 175
		public T this[int index]
		{
			get
			{
				return this._source[index];
			}
			set
			{
				global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000142E4 File Offset: 0x000124E4
		public bool Contains(T item)
		{
			return this._source.Contains(item);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000142F2 File Offset: 0x000124F2
		public void CopyTo(T[] array, int arrayIndex)
		{
			global::Infragistics.CoreUtilities.CopyTo<T>(this._source, array, arrayIndex);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00014301 File Offset: 0x00012501
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this._source.GetEnumerator();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001430E File Offset: 0x0001250E
		public int IndexOf(T item)
		{
			return this._source.IndexOf(item);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001431C File Offset: 0x0001251C
		private void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaiseCollectionChanged(e, true);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00014326 File Offset: 0x00012526
		private void OnSourcePropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.RaisePropertyChanged(e, true);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00014330 File Offset: 0x00012530
		internal void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs, bool notifyListeners)
		{
			if (this._collectionChanged != null)
			{
				this._collectionChanged(this, eventArgs);
			}
			if (notifyListeners && this._propChangeListeners != null)
			{
				this._propChangeListeners.OnCollectionChanged(this, eventArgs);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001435F File Offset: 0x0001255F
		internal void RaiseCollectionReset()
		{
			this.RaisePropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"), true);
			this.RaisePropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"), true);
			this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset), true);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00014390 File Offset: 0x00012590
		internal void RaisePropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs eventArgs, bool notifyListeners)
		{
			if (this._propertyChanged != null)
			{
				this._propertyChanged(this, eventArgs);
			}
			if (notifyListeners && this._propChangeListeners != null)
			{
				this._propChangeListeners.OnPropertyValueChanged(this, eventArgs.PropertyName, eventArgs);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000143C5 File Offset: 0x000125C5
		internal virtual void SetSourceCollection(global::System.Collections.Generic.IList<T> source)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(source);
			if (this._source != source)
			{
				this.HookUnhook(this._source, false);
				this._source = source;
				this.HookUnhook(this._source, true);
				this.RaiseCollectionReset();
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00014400 File Offset: 0x00012600
		private void HookUnhook(object source, bool hook)
		{
			if (source != null)
			{
				global::Infragistics.ISupportPropertyChangeNotifications supportPropertyChangeNotifications = source as global::Infragistics.ISupportPropertyChangeNotifications;
				if (supportPropertyChangeNotifications != null)
				{
					if (hook)
					{
						supportPropertyChangeNotifications.AddListener(this.PropChangeListeners, false);
						return;
					}
					supportPropertyChangeNotifications.RemoveListener(this.PropChangeListeners);
					return;
				}
				else
				{
					global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this._source as global::System.Collections.Specialized.INotifyCollectionChanged;
					if (notifyCollectionChanged != null)
					{
						if (hook)
						{
							notifyCollectionChanged.CollectionChanged += this.OnSourceCollectionChanged;
						}
						else
						{
							notifyCollectionChanged.CollectionChanged -= this.OnSourceCollectionChanged;
						}
					}
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this._source as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						if (hook)
						{
							notifyPropertyChanged.PropertyChanged += this.OnSourcePropertyChanged;
							return;
						}
						notifyPropertyChanged.PropertyChanged -= this.OnSourcePropertyChanged;
					}
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000144AA File Offset: 0x000126AA
		public int Count
		{
			get
			{
				return this._source.Count;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000144B7 File Offset: 0x000126B7
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000144BA File Offset: 0x000126BA
		protected global::System.Collections.Generic.IList<T> Source
		{
			get
			{
				return this._source;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000144C2 File Offset: 0x000126C2
		private global::Infragistics.PropertyChangeListenerList PropChangeListeners
		{
			get
			{
				if (this._propChangeListeners == null)
				{
					this._propChangeListeners = new global::Infragistics.PropertyChangeListenerList();
					this._propChangeListeners.Add(new global::Infragistics.PropertyChangeListener<global::Infragistics.Collections.ReadOnlyNotifyCollection<T>>(this, new global::System.Action<global::Infragistics.Collections.ReadOnlyNotifyCollection<T>, object, string, object>(this.OnListenersSubObjectPropertyChanged), true), false);
				}
				return this._propChangeListeners;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000144FC File Offset: 0x000126FC
		private void OnListenersSubObjectPropertyChanged(global::Infragistics.Collections.ReadOnlyNotifyCollection<T> owner, object sender, string property, object extraInfo)
		{
			if (sender == this._source)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = extraInfo as global::System.Collections.Specialized.NotifyCollectionChangedEventArgs;
				if (notifyCollectionChangedEventArgs != null)
				{
					this.RaiseCollectionChanged(notifyCollectionChangedEventArgs, true);
					return;
				}
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = extraInfo as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					this.RaisePropertyChanged(propertyChangedEventArgs, true);
				}
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00014539 File Offset: 0x00012739
		void global::System.Collections.Generic.IList<!0>.Insert(int index, T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00014540 File Offset: 0x00012740
		void global::System.Collections.Generic.IList<!0>.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00014547 File Offset: 0x00012747
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001454E File Offset: 0x0001274E
		void global::System.Collections.Generic.ICollection<!0>.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00014555 File Offset: 0x00012755
		bool global::System.Collections.Generic.ICollection<!0>.Remove(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return false;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001455D File Offset: 0x0001275D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00014565 File Offset: 0x00012765
		int global::System.Collections.IList.Add(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return -1;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001456D File Offset: 0x0001276D
		void global::System.Collections.IList.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00014574 File Offset: 0x00012774
		bool global::System.Collections.IList.Contains(object value)
		{
			return (value == null || value is T) && this.Contains((T)((object)value));
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001458F File Offset: 0x0001278F
		int global::System.Collections.IList.IndexOf(object value)
		{
			if (value != null && !(value is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)value));
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000145AA File Offset: 0x000127AA
		void global::System.Collections.IList.Insert(int index, object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000145B1 File Offset: 0x000127B1
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000145B4 File Offset: 0x000127B4
		void global::System.Collections.IList.Remove(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000145BB File Offset: 0x000127BB
		void global::System.Collections.IList.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x170000B5 RID: 181
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this._source[index];
			}
			set
			{
				global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000145DC File Offset: 0x000127DC
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			global::Infragistics.CoreUtilities.CopyTo(this._source, array, index);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000145EC File Offset: 0x000127EC
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				global::System.Collections.ICollection collection = this._source as global::System.Collections.ICollection;
				return collection != null && collection.IsSynchronized;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00014610 File Offset: 0x00012810
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				global::System.Collections.ICollection collection = this._source as global::System.Collections.ICollection;
				if (collection == null)
				{
					return this._source;
				}
				return collection.SyncRoot;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00014639 File Offset: 0x00012839
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.PropChangeListeners.Add(listener, useWeakReference);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00014648 File Offset: 0x00012848
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.PropChangeListeners.Remove(listener);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000520 RID: 1312 RVA: 0x00014656 File Offset: 0x00012856
		// (remove) Token: 0x06000521 RID: 1313 RVA: 0x0001466F File Offset: 0x0001286F
		event global::System.ComponentModel.PropertyChangedEventHandler global::System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		{
			add
			{
				this._propertyChanged = (global::System.Delegate.Combine(this._propertyChanged, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
			remove
			{
				this._propertyChanged = (global::System.Delegate.Remove(this._propertyChanged, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
		}

		// Token: 0x040001E1 RID: 481
		private global::System.Collections.Generic.IList<T> _source;

		// Token: 0x040001E2 RID: 482
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x040001E3 RID: 483
		private global::Infragistics.PropertyChangeListenerList _propChangeListeners;

		// Token: 0x040001E4 RID: 484
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChanged;
	}
}
