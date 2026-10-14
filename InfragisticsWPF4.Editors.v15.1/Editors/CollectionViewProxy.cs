using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000023 RID: 35
	internal class CollectionViewProxy : global::System.ComponentModel.ICollectionView, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000A664 File Offset: 0x00008864
		public CollectionViewProxy(global::System.Windows.Data.CollectionView collectionView)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull(collectionView);
			this._cv = collectionView;
			this._cv.CurrentChanged += this.OnSourceCurrentChanged;
			this._cv.CurrentChanging += this.OnSourceCurrentChanging;
			((global::System.Collections.Specialized.INotifyCollectionChanged)this._cv).CollectionChanged += this.OnSourceCollectionChanged;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000292 RID: 658 RVA: 0x0000A6CC File Offset: 0x000088CC
		// (remove) Token: 0x06000293 RID: 659 RVA: 0x0000A704 File Offset: 0x00008904
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000294 RID: 660 RVA: 0x0000A73C File Offset: 0x0000893C
		// (remove) Token: 0x06000295 RID: 661 RVA: 0x0000A774 File Offset: 0x00008974
		public event global::System.EventHandler CurrentChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000296 RID: 662 RVA: 0x0000A7AC File Offset: 0x000089AC
		// (remove) Token: 0x06000297 RID: 663 RVA: 0x0000A7E4 File Offset: 0x000089E4
		public event global::System.ComponentModel.CurrentChangingEventHandler CurrentChanging;

		// Token: 0x06000298 RID: 664 RVA: 0x0000A819 File Offset: 0x00008A19
		protected virtual void OnSourceCurrentChanging(object sender, global::System.ComponentModel.CurrentChangingEventArgs e)
		{
			if (this.CurrentChanging != null)
			{
				this.CurrentChanging(this, e);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000A830 File Offset: 0x00008A30
		protected virtual void OnSourceCurrentChanged(object sender, global::System.EventArgs e)
		{
			if (this.CurrentChanged != null)
			{
				this.CurrentChanged(this, e);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000A847 File Offset: 0x00008A47
		protected virtual void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaiseCollectionChanged(e);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A850 File Offset: 0x00008A50
		protected virtual void RaiseCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, e);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000A868 File Offset: 0x00008A68
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

		// Token: 0x0600029D RID: 669 RVA: 0x0000A8BA File Offset: 0x00008ABA
		private void SuspendRefresh()
		{
			if (this._suspendRefreshCount == 0)
			{
				this._cvDeferRefreshObject = this._cv.DeferRefresh();
			}
			this._suspendRefreshCount++;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000A8E3 File Offset: 0x00008AE3
		public bool CanFilter
		{
			get
			{
				return this._cv.CanFilter;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		public bool CanGroup
		{
			get
			{
				return this._cv.CanGroup;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000A8FD File Offset: 0x00008AFD
		public bool CanSort
		{
			get
			{
				return this._cv.CanSort;
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A90A File Offset: 0x00008B0A
		public bool Contains(object item)
		{
			return this._cv.Contains(item);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000A918 File Offset: 0x00008B18
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000A925 File Offset: 0x00008B25
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000A933 File Offset: 0x00008B33
		public object CurrentItem
		{
			get
			{
				return this._cv.CurrentItem;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000A940 File Offset: 0x00008B40
		public int CurrentPosition
		{
			get
			{
				return this._cv.CurrentPosition;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000A94D File Offset: 0x00008B4D
		public global::System.IDisposable DeferRefresh()
		{
			this.SuspendRefresh();
			return new global::Infragistics.Windows.Editors.CollectionViewProxy.DeferRefreshObject(this);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000A95B File Offset: 0x00008B5B
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000A968 File Offset: 0x00008B68
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000A976 File Offset: 0x00008B76
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.ComponentModel.GroupDescription> GroupDescriptions
		{
			get
			{
				return this._cv.GroupDescriptions;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000A983 File Offset: 0x00008B83
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<object> Groups
		{
			get
			{
				return this._cv.Groups;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000A990 File Offset: 0x00008B90
		public bool IsCurrentAfterLast
		{
			get
			{
				return this._cv.IsCurrentAfterLast;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000A99D File Offset: 0x00008B9D
		public bool IsCurrentBeforeFirst
		{
			get
			{
				return this._cv.IsCurrentBeforeFirst;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000A9AA File Offset: 0x00008BAA
		public bool IsEmpty
		{
			get
			{
				return this._cv.IsEmpty;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A9B7 File Offset: 0x00008BB7
		public bool MoveCurrentTo(object item)
		{
			return this._cv.MoveCurrentTo(item);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A9C5 File Offset: 0x00008BC5
		public bool MoveCurrentToFirst()
		{
			return this._cv.MoveCurrentToFirst();
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000A9D2 File Offset: 0x00008BD2
		public bool MoveCurrentToLast()
		{
			return this._cv.MoveCurrentToLast();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000A9DF File Offset: 0x00008BDF
		public bool MoveCurrentToNext()
		{
			return this._cv.MoveCurrentToNext();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000A9EC File Offset: 0x00008BEC
		public bool MoveCurrentToPosition(int position)
		{
			return this._cv.MoveCurrentToPosition(position);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000A9FA File Offset: 0x00008BFA
		public bool MoveCurrentToPrevious()
		{
			return this._cv.MoveCurrentToPrevious();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000AA07 File Offset: 0x00008C07
		public void Refresh()
		{
			this._cv.Refresh();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000AA14 File Offset: 0x00008C14
		public global::System.ComponentModel.SortDescriptionCollection SortDescriptions
		{
			get
			{
				return this._cv.SortDescriptions;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000AA21 File Offset: 0x00008C21
		public global::System.Collections.IEnumerable SourceCollection
		{
			get
			{
				return this._cv.SourceCollection;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000AA2E File Offset: 0x00008C2E
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.IEnumerable)this._cv).GetEnumerator();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000AA3B File Offset: 0x00008C3B
		public int Add(object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				return ((global::System.Collections.IList)this._cv).Add(value);
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000AA61 File Offset: 0x00008C61
		public void Clear()
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Clear();
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000AA86 File Offset: 0x00008C86
		public int IndexOf(object value)
		{
			return this._cv.IndexOf(value);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000AA94 File Offset: 0x00008C94
		public void Insert(int index, object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Insert(index, value);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000AABB File Offset: 0x00008CBB
		public bool IsFixedSize
		{
			get
			{
				return !(this._cv is global::System.Collections.IList) || ((global::System.Collections.IList)this._cv).IsFixedSize;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000AADC File Offset: 0x00008CDC
		public bool IsReadOnly
		{
			get
			{
				return !(this._cv is global::System.Collections.IList) || ((global::System.Collections.IList)this._cv).IsReadOnly;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000AAFD File Offset: 0x00008CFD
		public void Remove(object value)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).Remove(value);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000AB23 File Offset: 0x00008D23
		public void RemoveAt(int index)
		{
			if (this._cv is global::System.Collections.IList)
			{
				((global::System.Collections.IList)this._cv).RemoveAt(index);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700008F RID: 143
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

		// Token: 0x060002C2 RID: 706 RVA: 0x0000AB80 File Offset: 0x00008D80
		public void CopyTo(global::System.Array array, int index)
		{
			foreach (object value in this)
			{
				array.SetValue(value, index++);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		public int Count
		{
			get
			{
				return this._cv.Count;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		public bool IsSynchronized
		{
			get
			{
				return this._cv is global::System.Collections.ICollection && ((global::System.Collections.ICollection)this._cv).IsSynchronized;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000AC06 File Offset: 0x00008E06
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

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Data.CollectionView _cv;

		// Token: 0x040000BE RID: 190
		private int _suspendRefreshCount;

		// Token: 0x040000BF RID: 191
		private global::System.IDisposable _cvDeferRefreshObject;

		// Token: 0x02000024 RID: 36
		private class DeferRefreshObject : global::System.IDisposable
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x0000AC2C File Offset: 0x00008E2C
			internal DeferRefreshObject(global::Infragistics.Windows.Editors.CollectionViewProxy cvp)
			{
				this._cvp = cvp;
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0000AC3B File Offset: 0x00008E3B
			public void Dispose()
			{
				this._cvp.ResumeRefresh();
			}

			// Token: 0x040000C3 RID: 195
			private global::Infragistics.Windows.Editors.CollectionViewProxy _cvp;
		}
	}
}
