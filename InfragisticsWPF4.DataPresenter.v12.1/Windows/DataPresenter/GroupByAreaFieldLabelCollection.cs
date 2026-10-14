using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D9 RID: 729
	public class GroupByAreaFieldLabelCollection : global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel>, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060022E5 RID: 8933 RVA: 0x00098890 File Offset: 0x00096A90
		internal static global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection Create()
		{
			return new global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection(new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel>());
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0009889C File Offset: 0x00096A9C
		internal GroupByAreaFieldLabelCollection(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000988AC File Offset: 0x00096AAC
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> InternalList
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x000988B4 File Offset: 0x00096AB4
		protected internal virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index)
		{
			if (this._collectionChangedHandler != null)
			{
				if (item is global::System.Collections.IList)
				{
					this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, (global::System.Collections.IList)item, index));
					return;
				}
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, index));
			}
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000988F4 File Offset: 0x00096AF4
		protected internal virtual void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00098910 File Offset: 0x00096B10
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			int result = this.InternalAdd(groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
			return result;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0009892F File Offset: 0x00096B2F
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			return this.InternalInsert(this._list.Count, groupByAreaLabel);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00098943 File Offset: 0x00096B43
		internal void InternalClear(bool notifyCollectionChanged)
		{
			this._list.Clear();
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00098959 File Offset: 0x00096B59
		internal void InternalClear()
		{
			this._list.Clear();
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00098966 File Offset: 0x00096B66
		internal int InternalInsert(int index, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			this.InternalInsert(index, groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
			return index;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0009897B File Offset: 0x00096B7B
		internal int InternalInsert(int index, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			this._list.Insert(index, groupByAreaLabel);
			return index;
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0009898B File Offset: 0x00096B8B
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			this.InternalRemove(groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0009899D File Offset: 0x00096B9D
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			this._list.Remove(groupByAreaLabel);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000989AC File Offset: 0x00096BAC
		internal void InternalReset()
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x060022F3 RID: 8947 RVA: 0x000989CD File Offset: 0x00096BCD
		// (remove) Token: 0x060022F4 RID: 8948 RVA: 0x000989E6 File Offset: 0x00096BE6
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._collectionChangedHandler = (global::System.Delegate.Combine(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._collectionChangedHandler = (global::System.Delegate.Remove(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
		}

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060022F5 RID: 8949 RVA: 0x000989FF File Offset: 0x00096BFF
		// (remove) Token: 0x060022F6 RID: 8950 RVA: 0x00098A18 File Offset: 0x00096C18
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
		}

		// Token: 0x040010F7 RID: 4343
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> _list;

		// Token: 0x040010F8 RID: 4344
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x040010F9 RID: 4345
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
