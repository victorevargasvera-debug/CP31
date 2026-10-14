using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000022 RID: 34
	internal class CollectionViewProxy : global::System.ComponentModel.ICollectionView, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000281 RID: 641 RVA: 0x0000A1B0 File Offset: 0x000083B0
		public CollectionViewProxy(global::System.Windows.Data.CollectionView collectionView)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull(collectionView);
			this._cv = collectionView;
			this._cv.CurrentChanged += this.OnSourceCurrentChanged;
			this._cv.CurrentChanging += this.OnSourceCurrentChanging;
			((global::System.Collections.Specialized.INotifyCollectionChanged)this._cv).CollectionChanged += this.OnSourceCollectionChanged;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000282 RID: 642 RVA: 0x0000A218 File Offset: 0x00008418
		// (remove) Token: 0x06000283 RID: 643 RVA: 0x0000A250 File Offset: 0x00008450
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000284 RID: 644 RVA: 0x0000A288 File Offset: 0x00008488
		// (remove) Token: 0x06000285 RID: 645 RVA: 0x0000A2C0 File Offset: 0x000084C0
		public event global::System.EventHandler CurrentChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000286 RID: 646 RVA: 0x0000A2F8 File Offset: 0x000084F8
		// (remove) Token: 0x06000287 RID: 647 RVA: 0x0000A330 File Offset: 0x00008530
		public event global::System.ComponentModel.CurrentChangingEventHandler CurrentChanging;

		// Token: 0x06000288 RID: 648 RVA: 0x0000A365 File Offset: 0x00008565
		protected virtual void OnSourceCurrentChanging(object sender, global::System.ComponentModel.CurrentChangingEventArgs e)
		{
			if (this.CurrentChanging != null)
			{
				this.CurrentChanging(this, e);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A37C File Offset: 0x0000857C
		protected virtual void OnSourceCurrentChanged(object sender, global::System.EventArgs e)
		{
			if (this.CurrentChanged != null)
			{
				this.CurrentChanged(this, e);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A393 File Offset: 0x00008593
		protected virtual void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaiseCollectionChanged(e);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A39C File Offset: 0x0000859C
		private void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, e);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A3B4 File Offset: 0x000085B4
		private void ResumeRefresh()
		{
			if (this._suspendRefreshCount > 0)
			{
				this._suspendRefreshCount--;
				if (this._suspendRefreshCount == 0)
				{
					if (this._cvDeferRefreshObject != null)
					{
						this._cvDeferRefreshObject.Dispose();
						this._cvDeferRefreshObject = null;
					}
					this.RaiseCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A406 File Offset: 0x00008606
		private void SuspendRefresh()
		{
			if (this._suspendRefreshCount == 0)
			{
				this._cvDeferRefreshObject = this._cv.DeferRefresh();
			}
			this._suspendRefreshCount++;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000A42F File Offset: 0x0000862F
		public bool CanFilter
		{
			get
			{
				return this._cv.CanFilter;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000A43C File Offset: 0x0000863C
		public bool CanGroup
		{
			get
			{
				return this._cv.CanGroup;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000A449 File Offset: 0x00008649
		public bool CanSort
		{
			get
			{
				return this._cv.CanSort;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000A456 File Offset: 0x00008656
		public bool Contains(object item)
		{
			return this._cv.Contains(item);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000A464 File Offset: 0x00008664
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000A471 File Offset: 0x00008671
		public global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return this._cv.Culture;
			}
			set
			{
				this._cv.Culture = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000A47F File Offset: 0x0000867F
		public object CurrentItem
		{
			get
			{
				return this._cv.CurrentItem;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A48C File Offset: 0x0000868C
		public int CurrentPosition
		{
			get
			{
				return this._cv.CurrentPosition;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000A499 File Offset: 0x00008699
		public global::System.IDisposable DeferRefresh()
		{
			this.SuspendRefresh();
			return new global::Infragistics.Windows.Editors.CollectionViewProxy.DeferRefreshObject(this);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000A4A7 File Offset: 0x000086A7
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000A4B4 File Offset: 0x000086B4
		public global::System.Predicate<object> Filter
		{
			get
			{
				return this._cv.Filter;
			}
			set
			{
				this._cv.Filter = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000A4C2 File Offset: 0x000086C2
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> GroupDescriptions
		{
			get
			{
				return this._cv.GroupDescriptions;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000A4CF File Offset: 0x000086CF
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> Groups
		{
			get
			{
				return this._cv.Groups;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000A4DC File Offset: 0x000086DC
		public bool IsCurrentAfterLast
		{
			get
			{
				return this._cv.IsCurrentAfterLast;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000A4E9 File Offset: 0x000086E9
		public bool IsCurrentBeforeFirst
		{
			get
			{
				return this._cv.IsCurrentBeforeFirst;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000A4F6 File Offset: 0x000086F6
		public bool IsEmpty
		{
			get
			{
				return this._cv.IsEmpty;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A503 File Offset: 0x00008703
		public bool MoveCurrentTo(object item)
		{
			return this._cv.MoveCurrentTo(item);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000A511 File Offset: 0x00008711
		public bool MoveCurrentToFirst()
		{
			return this._cv.MoveCurrentToFirst();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A51E File Offset: 0x0000871E
		public bool MoveCurrentToLast()
		{
			return this._cv.MoveCurrentToLast();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A52B File Offset: 0x0000872B
		public bool MoveCurrentToNext()
		{
			return this._cv.MoveCurrentToNext();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000A538 File Offset: 0x00008738
		public bool MoveCurrentToPosition(int position)
		{
			return this._cv.MoveCurrentToPosition(position);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000A546 File Offset: 0x00008746
		public bool MoveCurrentToPrevious()
		{
			return this._cv.MoveCurrentToPrevious();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000A553 File Offset: 0x00008753
		public void Refresh()
		{
			this._cv.Refresh();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000A560 File Offset: 0x00008760
		public global::System.ComponentModel.SortDescriptionCollection SortDescriptions
		{
			get
			{
				return this._cv.SortDescriptions;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000A56D File Offset: 0x0000876D
		public global::System.Collections.IEnumerable SourceCollection
		{
			get
			{
				return this._cv.SourceCollection;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000A57A File Offset: 0x0000877A
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.IEnumerable)this._cv).GetEnumerator();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000A587 File Offset: 0x00008787
		public int Add(object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				return ((global::System.Collections.IList)this._cv).Add(value);
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A5AD File Offset: 0x000087AD
		public void Clear()
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Clear();
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000A5D2 File Offset: 0x000087D2
		public int IndexOf(object value)
		{
			return this._cv.IndexOf(value);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public void Insert(int index, object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Insert(index, value);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000A607 File Offset: 0x00008807
		public bool IsFixedSize
		{
			get
			{
				return !(this._cv is global::System.Collections.IList) || ((global::System.Collections.IList)this._cv).IsFixedSize;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000A628 File Offset: 0x00008828
		public bool IsReadOnly
		{
			get
			{
				return !(this._cv is global::System.Collections.IList) || ((global::System.Collections.IList)this._cv).IsReadOnly;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A649 File Offset: 0x00008849
		public void Remove(object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Remove(value);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A66F File Offset: 0x0000886F
		public void RemoveAt(int index)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).RemoveAt(index);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700008C RID: 140
		public object this[int index]
		{
			get
			{
				return this._cv.GetItemAt(index);
			}
			set
			{
				if (this._cv is global::System.Collections.IList)
				{
					((global::System.Collections.IList)this._cv)[index] = value;
					return;
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000A6CC File Offset: 0x000088CC
		public void CopyTo(global::System.Array array, int index)
		{
			foreach (object value in this)
			{
				array.SetValue(value, index++);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000A724 File Offset: 0x00008924
		public int Count
		{
			get
			{
				return this._cv.Count;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000A731 File Offset: 0x00008931
		public bool IsSynchronized
		{
			get
			{
				return this._cv is global::System.Collections.ICollection && ((global::System.Collections.ICollection)this._cv).IsSynchronized;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000A752 File Offset: 0x00008952
		public object SyncRoot
		{
			get
			{
				if (this._cv is global::System.Collections.ICollection)
				{
					return ((global::System.Collections.ICollection)this._cv).SyncRoot;
				}
				return this._cv;
			}
		}

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Data.CollectionView _cv;

		// Token: 0x040000B4 RID: 180
		private int _suspendRefreshCount;

		// Token: 0x040000B5 RID: 181
		private global::System.IDisposable _cvDeferRefreshObject;

		// Token: 0x02000023 RID: 35
		private class DeferRefreshObject : global::System.IDisposable
		{
			// Token: 0x060002B6 RID: 694 RVA: 0x0000A778 File Offset: 0x00008978
			internal DeferRefreshObject(global::Infragistics.Windows.Editors.CollectionViewProxy cvp)
			{
				this._cvp = cvp;
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000A787 File Offset: 0x00008987
			public void Dispose()
			{
				this._cvp.ResumeRefresh();
			}

			// Token: 0x040000B9 RID: 185
			private global::Infragistics.Windows.Editors.CollectionViewProxy _cvp;
		}
	}
}
