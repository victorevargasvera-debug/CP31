using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001A9 RID: 425
	public class ItemInfoBase : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Collections.ISparseArrayMultiItem, global::Infragistics.Collections.ISparseArrayItem
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x000301C7 File Offset: 0x0002E3C7
		protected internal ItemInfoBase(global::Infragistics.Windows.Internal.TileManager manager, object item, int index)
		{
			this._manager = manager;
			this._item = item;
			this._index = index;
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000301E4 File Offset: 0x0002E3E4
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public int Index
		{
			get
			{
				global::System.Collections.IList items = this._manager.Items;
				if (this._index < 0 || this._index >= items.Count || !object.Equals(this._item, items[this._index]))
				{
					this._index = items.IndexOf(this._item);
				}
				return this._index;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00030245 File Offset: 0x0002E445
		[global::System.ComponentModel.ReadOnly(true)]
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0003024D File Offset: 0x0002E44D
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public int LogicalIndex
		{
			get
			{
				return this._manager.GetLogicalIndexOfItem(this._item, false);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00030261 File Offset: 0x0002E461
		public bool OccupiesScrollPosition
		{
			get
			{
				return !this.GetIsClosed() && !this.GetIsMaximized();
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00030276 File Offset: 0x0002E476
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int ScrollPosition
		{
			get
			{
				return this._manager.GetLogicalIndexOfItem(this._item, true);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0003028A File Offset: 0x0002E48A
		internal bool IsInSparseArray
		{
			get
			{
				return this._sparseArrayOwnerData != null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00030298 File Offset: 0x0002E498
		protected global::Infragistics.Windows.Internal.TileManager Manager
		{
			get
			{
				return this._manager;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000302A0 File Offset: 0x0002E4A0
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x000302A8 File Offset: 0x0002E4A8
		protected internal global::System.Windows.Size? PreferredSizeOverride
		{
			get
			{
				return this._preferredSizeOverride;
			}
			set
			{
				this._preferredSizeOverride = value;
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000302B4 File Offset: 0x0002E4B4
		public void BringIntoView()
		{
			int index = this.Index;
			if (index >= 0)
			{
				this._manager.BringIndexIntoView(index);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000302D8 File Offset: 0x0002E4D8
		public void ClearSizeCustomization()
		{
			this.PreferredSizeOverride = null;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000302F4 File Offset: 0x0002E4F4
		public int GetCurrentColumn()
		{
			return this._manager.GetCurrentColumn(this);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00030304 File Offset: 0x0002E504
		public global::Infragistics.Windows.Tiles.ITileConstraints GetCurrentConstraints()
		{
			if (!this._manager.IsItemInView(this))
			{
				return null;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this._manager.GetLayoutItem(this);
			if (layoutItem == null)
			{
				return null;
			}
			return layoutItem;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00030334 File Offset: 0x0002E534
		public int GetCurrentRow()
		{
			return this._manager.GetCurrentRow(this);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00030344 File Offset: 0x0002E544
		public global::System.Windows.Rect GetCurrentTargetRect()
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase panel = this._manager.Panel;
			if (panel != null)
			{
				return panel.GetTargetRectOfItem(this.Item);
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00030372 File Offset: 0x0002E572
		protected internal virtual bool GetIsClosed()
		{
			return false;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00030375 File Offset: 0x0002E575
		protected internal virtual bool GetIsMaximized()
		{
			return false;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00030378 File Offset: 0x0002E578
		protected void GetResizeRange(out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
		{
			this._manager.GetResizeRange(this, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0003038B File Offset: 0x0002E58B
		protected void OnResize(double deltaX, double deltaY)
		{
			this._manager.OnItemResized(this, deltaX, deltaY);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0003039B File Offset: 0x0002E59B
		protected void InvalidateScrollPosition()
		{
			if (this.IsInSparseArray)
			{
				this._manager.SparseArray.InvalidateItem(this);
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000303B6 File Offset: 0x0002E5B6
		object global::Infragistics.Collections.ISparseArrayMultiItem.GetItemAtScrollIndex(int scrollIndex)
		{
			return this;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000303B9 File Offset: 0x0002E5B9
		int global::Infragistics.Collections.ISparseArrayMultiItem.ScrollCount
		{
			get
			{
				if (!this.OccupiesScrollPosition)
				{
					return 0;
				}
				return 1;
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000303C6 File Offset: 0x0002E5C6
		object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
		{
			return this._sparseArrayOwnerData;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000303CE File Offset: 0x0002E5CE
		void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
		{
			this._sparseArrayOwnerData = ownerData;
		}

		// Token: 0x0400076C RID: 1900
		private global::Infragistics.Windows.Internal.TileManager _manager;

		// Token: 0x0400076D RID: 1901
		private object _item;

		// Token: 0x0400076E RID: 1902
		private int _index;

		// Token: 0x0400076F RID: 1903
		private object _sparseArrayOwnerData;

		// Token: 0x04000770 RID: 1904
		private global::System.Windows.Size? _preferredSizeOverride;
	}
}
