using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x0200006B RID: 107
	public class ReadOnlyNotifyCollection<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00011A76 File Offset: 0x0000FC76
		public ReadOnlyNotifyCollection(global::System.Collections.Generic.IList<T> source)
		{
			this.SetSourceCollection(source);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000436 RID: 1078 RVA: 0x00011A85 File Offset: 0x0000FC85
		// (remove) Token: 0x06000437 RID: 1079 RVA: 0x00011A9E File Offset: 0x0000FC9E
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

		// Token: 0x170000A0 RID: 160
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

		// Token: 0x0600043A RID: 1082 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public bool Contains(T item)
		{
			return this._source.Contains(item);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00011ADA File Offset: 0x0000FCDA
		public void CopyTo(T[] array, int arrayIndex)
		{
			global::Infragistics.CoreUtilities.CopyTo<T>(this._source, array, arrayIndex);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00011AE9 File Offset: 0x0000FCE9
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this._source.GetEnumerator();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00011AF6 File Offset: 0x0000FCF6
		public int IndexOf(T item)
		{
			return this._source.IndexOf(item);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00011B04 File Offset: 0x0000FD04
		private void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaiseCollectionChanged(e, true);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00011B0E File Offset: 0x0000FD0E
		private void OnSourcePropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.RaisePropertyChanged(e, true);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00011B18 File Offset: 0x0000FD18
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

		// Token: 0x06000441 RID: 1089 RVA: 0x00011B47 File Offset: 0x0000FD47
		internal void RaiseCollectionReset()
		{
			this.RaisePropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Count"), true);
			this.RaisePropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Item[]"), true);
			this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset), true);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00011B78 File Offset: 0x0000FD78
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

		// Token: 0x06000443 RID: 1091 RVA: 0x00011BAD File Offset: 0x0000FDAD
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

		// Token: 0x06000444 RID: 1092 RVA: 0x00011BE8 File Offset: 0x0000FDE8
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00011C92 File Offset: 0x0000FE92
		public int Count
		{
			get
			{
				return this._source.Count;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00011C9F File Offset: 0x0000FE9F
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00011CA2 File Offset: 0x0000FEA2
		protected global::System.Collections.Generic.IList<T> Source
		{
			get
			{
				return this._source;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00011CAA File Offset: 0x0000FEAA
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

		// Token: 0x06000449 RID: 1097 RVA: 0x00011CE4 File Offset: 0x0000FEE4
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

		// Token: 0x0600044A RID: 1098 RVA: 0x00011D21 File Offset: 0x0000FF21
		void global::System.Collections.Generic.IList<!0>.Insert(int index, T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00011D28 File Offset: 0x0000FF28
		void global::System.Collections.Generic.IList<!0>.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00011D2F File Offset: 0x0000FF2F
		void global::System.Collections.Generic.ICollection<!0>.Add(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00011D36 File Offset: 0x0000FF36
		void global::System.Collections.Generic.ICollection<!0>.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00011D3D File Offset: 0x0000FF3D
		bool global::System.Collections.Generic.ICollection<!0>.Remove(T item)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return false;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00011D45 File Offset: 0x0000FF45
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00011D4D File Offset: 0x0000FF4D
		int global::System.Collections.IList.Add(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
			return -1;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00011D55 File Offset: 0x0000FF55
		void global::System.Collections.IList.Clear()
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00011D5C File Offset: 0x0000FF5C
		bool global::System.Collections.IList.Contains(object value)
		{
			return (value == null || value is T) && this.Contains((T)((object)value));
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00011D77 File Offset: 0x0000FF77
		int global::System.Collections.IList.IndexOf(object value)
		{
			if (value != null && !(value is T))
			{
				return -1;
			}
			return this.IndexOf((T)((object)value));
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00011D92 File Offset: 0x0000FF92
		void global::System.Collections.IList.Insert(int index, object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00011D99 File Offset: 0x0000FF99
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00011D9C File Offset: 0x0000FF9C
		void global::System.Collections.IList.Remove(object value)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00011DA3 File Offset: 0x0000FFA3
		void global::System.Collections.IList.RemoveAt(int index)
		{
			global::Infragistics.CoreUtilities.RaiseReadOnlyCollectionException();
		}

		// Token: 0x170000A6 RID: 166
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

		// Token: 0x0600045A RID: 1114 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			global::Infragistics.CoreUtilities.CopyTo(this._source, array, index);
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				global::System.Collections.ICollection collection = this._source as global::System.Collections.ICollection;
				return collection != null && collection.IsSynchronized;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00011DF8 File Offset: 0x0000FFF8
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

		// Token: 0x0600045D RID: 1117 RVA: 0x00011E21 File Offset: 0x00010021
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			this.PropChangeListeners.Add(listener, useWeakReference);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00011E30 File Offset: 0x00010030
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			this.PropChangeListeners.Remove(listener);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600045F RID: 1119 RVA: 0x00011E3E File Offset: 0x0001003E
		// (remove) Token: 0x06000460 RID: 1120 RVA: 0x00011E57 File Offset: 0x00010057
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

		// Token: 0x04000170 RID: 368
		private global::System.Collections.Generic.IList<T> _source;

		// Token: 0x04000171 RID: 369
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x04000172 RID: 370
		private global::Infragistics.PropertyChangeListenerList _propChangeListeners;

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChanged;
	}
}
