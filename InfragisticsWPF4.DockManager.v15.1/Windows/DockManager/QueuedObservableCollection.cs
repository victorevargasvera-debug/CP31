using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000090 RID: 144
	internal sealed class QueuedObservableCollection<T> : global::Infragistics.Collections.ObservableCollectionExtended<T>
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x0001D54C File Offset: 0x0001B74C
		public QueuedObservableCollection()
		{
			this._changedItems = new global::System.Collections.Generic.Dictionary<T, int>();
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001D55F File Offset: 0x0001B75F
		protected override bool NotifyItemsChanged
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001D562 File Offset: 0x0001B762
		protected override void OnItemAdded(T itemAdded)
		{
			this.AdjustChangeCount(itemAdded, 1);
			base.OnItemAdded(itemAdded);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001D573 File Offset: 0x0001B773
		protected override void OnItemRemoved(T itemRemoved)
		{
			this.AdjustChangeCount(itemRemoved, -1);
			base.OnItemRemoved(itemRemoved);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001D584 File Offset: 0x0001B784
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			e = new global::Infragistics.Windows.DockManager.QueuedObservableCollection<T>.QueuedNotifyCollectionChangedEventArgs(this.GetChangedItems(true), this.GetChangedItems(false));
			this._changedItems.Clear();
			base.OnCollectionChanged(e);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		private void AdjustChangeCount(T item, int offset)
		{
			if (item != null)
			{
				int num;
				if (this._changedItems.TryGetValue(item, out num))
				{
					num += offset;
				}
				else
				{
					num = offset;
				}
				this._changedItems[item] = num;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		private global::System.Collections.Generic.IList<T> GetChangedItems(bool added)
		{
			global::System.Collections.Generic.IList<T> list = new global::System.Collections.Generic.List<T>();
			foreach (global::System.Collections.Generic.KeyValuePair<T, int> keyValuePair in this._changedItems)
			{
				if ((added && keyValuePair.Value > 0) || (!added && keyValuePair.Value < 0))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x0400035A RID: 858
		private global::System.Collections.Generic.Dictionary<T, int> _changedItems;

		// Token: 0x02000091 RID: 145
		internal class QueuedNotifyCollectionChangedEventArgs : global::System.Collections.Specialized.NotifyCollectionChangedEventArgs
		{
			// Token: 0x06000573 RID: 1395 RVA: 0x0001D668 File Offset: 0x0001B868
			internal QueuedNotifyCollectionChangedEventArgs(global::System.Collections.Generic.IList<T> itemsAdded, global::System.Collections.Generic.IList<T> itemsRemoved) : base(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._itemsAdded = new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(itemsAdded);
				this._itemsRemoved = new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(itemsRemoved);
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001D689 File Offset: 0x0001B889
			public global::System.Collections.Generic.IList<T> ItemsAdded
			{
				get
				{
					return this._itemsAdded;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001D691 File Offset: 0x0001B891
			public global::System.Collections.Generic.IList<T> ItemsRemoved
			{
				get
				{
					return this._itemsRemoved;
				}
			}

			// Token: 0x0400035B RID: 859
			private global::System.Collections.Generic.IList<T> _itemsAdded;

			// Token: 0x0400035C RID: 860
			private global::System.Collections.Generic.IList<T> _itemsRemoved;
		}
	}
}
