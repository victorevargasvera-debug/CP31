using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000318 RID: 792
	public class GroupByAreaFieldLabelCollection : global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel>, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x000AC11C File Offset: 0x000AA31C
		internal static global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection Create()
		{
			return new global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabelCollection(new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel>());
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000AC128 File Offset: 0x000AA328
		internal GroupByAreaFieldLabelCollection(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000AC138 File Offset: 0x000AA338
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> InternalList
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000AC140 File Offset: 0x000AA340
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

		// Token: 0x06002688 RID: 9864 RVA: 0x000AC180 File Offset: 0x000AA380
		protected internal virtual void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000AC19C File Offset: 0x000AA39C
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			int result = this.InternalAdd(groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
			return result;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000AC1BB File Offset: 0x000AA3BB
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			return this.InternalInsert(this._list.Count, groupByAreaLabel);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000AC1CF File Offset: 0x000AA3CF
		internal void InternalClear(bool notifyCollectionChanged)
		{
			this._list.Clear();
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000AC1E5 File Offset: 0x000AA3E5
		internal void InternalClear()
		{
			this._list.Clear();
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000AC1F2 File Offset: 0x000AA3F2
		internal int InternalInsert(int index, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			this.InternalInsert(index, groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
			return index;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000AC207 File Offset: 0x000AA407
		internal int InternalInsert(int index, global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			this._list.Insert(index, groupByAreaLabel);
			return index;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000AC217 File Offset: 0x000AA417
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel, bool notifyCollectionChanged)
		{
			this.InternalRemove(groupByAreaLabel);
			if (notifyCollectionChanged)
			{
				this.InternalReset();
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000AC229 File Offset: 0x000AA429
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel groupByAreaLabel)
		{
			this._list.Remove(groupByAreaLabel);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000AC238 File Offset: 0x000AA438
		internal void InternalReset()
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
		}

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06002692 RID: 9874 RVA: 0x000AC259 File Offset: 0x000AA459
		// (remove) Token: 0x06002693 RID: 9875 RVA: 0x000AC272 File Offset: 0x000AA472
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

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06002694 RID: 9876 RVA: 0x000AC28B File Offset: 0x000AA48B
		// (remove) Token: 0x06002695 RID: 9877 RVA: 0x000AC2A4 File Offset: 0x000AA4A4
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

		// Token: 0x04001310 RID: 4880
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel> _list;

		// Token: 0x04001311 RID: 4881
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x04001312 RID: 4882
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;
	}
}
