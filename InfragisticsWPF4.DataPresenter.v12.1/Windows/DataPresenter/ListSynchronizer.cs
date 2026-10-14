using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EC RID: 492
	internal class ListSynchronizer<TSource, TDest>
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x00076A61 File Offset: 0x00074C61
		public ListSynchronizer(global::System.Collections.Generic.IList<TSource> source, global::System.Collections.Generic.IList<TDest> dest)
		{
			this._source = source;
			this._dest = dest;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00076A77 File Offset: 0x00074C77
		internal void Initialize(global::System.Func<TSource, TDest> createItemDelegate, global::System.Action<TDest> initializeItemDelegate, global::System.Func<TDest, TSource> getSourceFromDest)
		{
			this._createItem = createItemDelegate;
			this._initializeItem = initializeItemDelegate;
			this._getSourceFromDest = getSourceFromDest;
			this.HookUnhookSource(true);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00076A98 File Offset: 0x00074C98
		private void HookUnhookSource(bool hook)
		{
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this._source as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.OnSource_CollectionChanged);
				if (hook)
				{
					notifyCollectionChanged.CollectionChanged += value;
					return;
				}
				notifyCollectionChanged.CollectionChanged -= value;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00076AD3 File Offset: 0x00074CD3
		internal void Dispose()
		{
			this.HookUnhookSource(false);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00076ADC File Offset: 0x00074CDC
		internal void Synchronize()
		{
			global::System.Collections.Generic.Dictionary<TSource, TDest> dictionary = new global::System.Collections.Generic.Dictionary<TSource, TDest>();
			foreach (TDest tdest in this._dest)
			{
				TSource tsource = this._getSourceFromDest(tdest);
				if (tsource != null)
				{
					dictionary[tsource] = tdest;
				}
			}
			this._dest.Clear();
			this.AddHelper(0, this._source, dictionary);
			this.RaiseDestCollectionEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00076B6C File Offset: 0x00074D6C
		private TDest CreateAndInitialize(TSource sourceItem)
		{
			TDest tdest = this._createItem(sourceItem);
			this._initializeItem(tdest);
			return tdest;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00076B94 File Offset: 0x00074D94
		private static void RemoveRange<T>(global::System.Collections.Generic.IList<T> list, int index, int count)
		{
			for (int i = 0; i < count; i++)
			{
				list.RemoveAt(index + i);
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00076BB8 File Offset: 0x00074DB8
		private static void InsertRange<T>(global::System.Collections.Generic.IList<T> list, int index, global::System.Collections.Generic.IEnumerable<T> itemsToAdd)
		{
			foreach (T item in itemsToAdd)
			{
				list.Insert(index++, item);
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00076C08 File Offset: 0x00074E08
		private void AddHelper(int index, global::System.Collections.IEnumerable addedSourceItems, global::System.Collections.Generic.Dictionary<TSource, TDest> itemsToRecycle)
		{
			foreach (object obj in addedSourceItems)
			{
				TSource tsource = (TSource)((object)obj);
				TDest item;
				if (itemsToRecycle == null || !itemsToRecycle.TryGetValue(tsource, out item))
				{
					item = this.CreateAndInitialize(tsource);
				}
				this._dest.Insert(index++, item);
			}
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00076C80 File Offset: 0x00074E80
		private void OnSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			bool flag = false;
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				this.AddHelper(e.NewStartingIndex, e.NewItems, null);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			{
				int oldStartingIndex = e.OldStartingIndex;
				int count = e.OldItems.Count;
				global::Infragistics.Windows.DataPresenter.ListSynchronizer<TSource, TDest>.RemoveRange<TDest>(this._dest, e.OldStartingIndex, e.OldItems.Count);
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			{
				int newStartingIndex = e.NewStartingIndex;
				if (newStartingIndex >= 0)
				{
					int count2 = e.NewItems.Count;
					global::Infragistics.Windows.DataPresenter.ListSynchronizer<TSource, TDest>.RemoveRange<TDest>(this._dest, newStartingIndex, count2);
					this.AddHelper(newStartingIndex, e.NewItems, null);
				}
				else
				{
					flag = true;
				}
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			{
				global::System.Collections.Generic.List<TDest> list = new global::System.Collections.Generic.List<TDest>();
				int count3 = e.NewItems.Count;
				for (int i = 0; i < count3; i++)
				{
					list.Add(this._dest[e.OldStartingIndex + i]);
				}
				global::Infragistics.Windows.DataPresenter.ListSynchronizer<TSource, TDest>.RemoveRange<TDest>(this._dest, e.OldStartingIndex, count3);
				global::Infragistics.Windows.DataPresenter.ListSynchronizer<TSource, TDest>.InsertRange<TDest>(this._dest, e.NewStartingIndex, list);
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				flag = true;
				break;
			}
			if (flag)
			{
				this.Synchronize();
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00076DA6 File Offset: 0x00074FA6
		protected virtual void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
		}

		// Token: 0x04000B8F RID: 2959
		internal readonly global::System.Collections.Generic.IList<TSource> _source;

		// Token: 0x04000B90 RID: 2960
		internal readonly global::System.Collections.Generic.IList<TDest> _dest;

		// Token: 0x04000B91 RID: 2961
		private global::System.Func<TSource, TDest> _createItem;

		// Token: 0x04000B92 RID: 2962
		private global::System.Action<TDest> _initializeItem;

		// Token: 0x04000B93 RID: 2963
		private global::System.Func<TDest, TSource> _getSourceFromDest;
	}
}
