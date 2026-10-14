using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200021F RID: 543
	internal class ListSynchronizer<TSource, TDest>
	{
		// Token: 0x0600204A RID: 8266 RVA: 0x0008C94D File Offset: 0x0008AB4D
		public ListSynchronizer(global::System.Collections.Generic.IList<TSource> source, global::System.Collections.Generic.IList<TDest> dest, global::Infragistics.Windows.DataPresenter.Disposable disposable)
		{
			this._source = source;
			this._dest = dest;
			this._disposable = disposable;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0008C96A File Offset: 0x0008AB6A
		internal void Initialize(global::System.Func<TSource, TDest> createItemDelegate, global::System.Action<TDest> initializeItemDelegate, global::System.Action<TDest> disposeItemDelegate, global::System.Func<TDest, TSource> getSourceFromDest)
		{
			this._createItem = createItemDelegate;
			this._initializeItem = initializeItemDelegate;
			this._disposeItem = disposeItemDelegate;
			this._getSourceFromDest = getSourceFromDest;
			this.HookUnhookSource(true);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0008C990 File Offset: 0x0008AB90
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

		// Token: 0x0600204D RID: 8269 RVA: 0x0008C9CC File Offset: 0x0008ABCC
		internal virtual void Dispose(bool disposeDestItems)
		{
			this.HookUnhookSource(false);
			if (disposeDestItems && this._disposeItem != null && this._dest != null && this._dest.Count > 0)
			{
				global::System.Collections.Generic.List<TDest> list = new global::System.Collections.Generic.List<TDest>(this._dest);
				this._dest.Clear();
				foreach (TDest obj in list)
				{
					this._disposeItem(obj);
				}
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0008CA60 File Offset: 0x0008AC60
		internal virtual void Synchronize()
		{
			global::System.Collections.Generic.Dictionary<TSource, TDest> dictionary = null;
			if (this._dest.Count > 0)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<TSource, TDest>();
				foreach (TDest tdest in this._dest)
				{
					TSource tsource = this._getSourceFromDest(tdest);
					if (tsource != null)
					{
						dictionary[tsource] = tdest;
					}
				}
			}
			this._dest.Clear();
			this.AddHelper(0, this._source, dictionary);
			if (this._disposeItem != null && dictionary != null)
			{
				foreach (TDest obj in dictionary.Values)
				{
					this._disposeItem(obj);
				}
			}
			this.RaiseDestCollectionEvent(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0008CB58 File Offset: 0x0008AD58
		private TDest CreateAndInitialize(TSource sourceItem)
		{
			TDest tdest = this._createItem(sourceItem);
			this._initializeItem(tdest);
			return tdest;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0008CB80 File Offset: 0x0008AD80
		private static void RemoveRange<T>(global::System.Collections.Generic.IList<T> list, int index, int count)
		{
			for (int i = 0; i < count; i++)
			{
				list.RemoveAt(index + i);
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0008CBA4 File Offset: 0x0008ADA4
		private static void InsertRange<T>(global::System.Collections.Generic.IList<T> list, int index, global::System.Collections.Generic.IEnumerable<T> itemsToAdd)
		{
			foreach (T item in itemsToAdd)
			{
				list.Insert(index++, item);
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0008CBF4 File Offset: 0x0008ADF4
		private void AddHelper(int index, global::System.Collections.IEnumerable addedSourceItems, global::System.Collections.Generic.Dictionary<TSource, TDest> itemsToRecycle)
		{
			foreach (object obj in addedSourceItems)
			{
				TSource tsource = (TSource)((object)obj);
				TDest item;
				if (itemsToRecycle != null && itemsToRecycle.TryGetValue(tsource, out item))
				{
					itemsToRecycle.Remove(tsource);
				}
				else
				{
					item = this.CreateAndInitialize(tsource);
				}
				this._dest.Insert(index++, item);
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0008CC74 File Offset: 0x0008AE74
		protected virtual void OnSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._disposable != null && this._disposable.IsDisposed)
			{
				this.Dispose(true);
				return;
			}
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

		// Token: 0x06002054 RID: 8276 RVA: 0x0008CDB7 File Offset: 0x0008AFB7
		protected virtual void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
		}

		// Token: 0x04000DA5 RID: 3493
		internal readonly global::System.Collections.Generic.IList<TSource> _source;

		// Token: 0x04000DA6 RID: 3494
		internal readonly global::System.Collections.Generic.IList<TDest> _dest;

		// Token: 0x04000DA7 RID: 3495
		private global::System.Func<TSource, TDest> _createItem;

		// Token: 0x04000DA8 RID: 3496
		private global::System.Action<TDest> _initializeItem;

		// Token: 0x04000DA9 RID: 3497
		private global::System.Action<TDest> _disposeItem;

		// Token: 0x04000DAA RID: 3498
		private global::System.Func<TDest, TSource> _getSourceFromDest;

		// Token: 0x04000DAB RID: 3499
		internal readonly global::Infragistics.Windows.DataPresenter.Disposable _disposable;
	}
}
