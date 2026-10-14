using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001D6 RID: 470
	public class ItemInfoBase : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Collections.ISparseArrayMultiItem, global::Infragistics.Collections.ISparseArrayItem
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x0003562F File Offset: 0x0003382F
		protected internal ItemInfoBase(global::Infragistics.Windows.Internal.TileManager manager, object item, int index)
		{
			this._manager = manager;
			this._item = item;
			this._index = index;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0003564C File Offset: 0x0003384C
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x000356AD File Offset: 0x000338AD
		[global::System.ComponentModel.ReadOnly(true)]
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000356B5 File Offset: 0x000338B5
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int LogicalIndex
		{
			get
			{
				return this._manager.GetLogicalIndexOfItem(this._item, false);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x000356C9 File Offset: 0x000338C9
		public bool OccupiesScrollPosition
		{
			get
			{
				return !this.GetIsClosed() && !this.GetIsMaximized();
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000356DE File Offset: 0x000338DE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public int ScrollPosition
		{
			get
			{
				return this._manager.GetLogicalIndexOfItem(this._item, true);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000356F2 File Offset: 0x000338F2
		internal bool IsInSparseArray
		{
			get
			{
				return this._sparseArrayOwnerData != null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00035700 File Offset: 0x00033900
		protected global::Infragistics.Windows.Internal.TileManager Manager
		{
			get
			{
				return this._manager;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00035708 File Offset: 0x00033908
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00035710 File Offset: 0x00033910
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

		// Token: 0x0600102B RID: 4139 RVA: 0x0003571C File Offset: 0x0003391C
		public void BringIntoView()
		{
			int index = this.Index;
			if (index >= 0)
			{
				this._manager.BringIndexIntoView(index);
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00035740 File Offset: 0x00033940
		public void ClearSizeCustomization()
		{
			this.PreferredSizeOverride = null;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0003575C File Offset: 0x0003395C
		public int GetCurrentColumn()
		{
			return this._manager.GetCurrentColumn(this);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0003576C File Offset: 0x0003396C
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

		// Token: 0x0600102F RID: 4143 RVA: 0x0003579C File Offset: 0x0003399C
		public int GetCurrentRow()
		{
			return this._manager.GetCurrentRow(this);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000357AC File Offset: 0x000339AC
		public global::System.Windows.Rect GetCurrentTargetRect()
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase panel = this._manager.Panel;
			if (panel != null)
			{
				return panel.GetTargetRectOfItem(this.Item);
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000357DA File Offset: 0x000339DA
		protected internal virtual bool GetIsClosed()
		{
			return false;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000357DD File Offset: 0x000339DD
		protected internal virtual bool GetIsMaximized()
		{
			return false;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000357E0 File Offset: 0x000339E0
		protected void GetResizeRange(out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
		{
			this._manager.GetResizeRange(this, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000357F3 File Offset: 0x000339F3
		protected void OnResize(double deltaX, double deltaY)
		{
			this._manager.OnItemResized(this, deltaX, deltaY);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00035803 File Offset: 0x00033A03
		protected void InvalidateScrollPosition()
		{
			if (this.IsInSparseArray)
			{
				this._manager.SparseArray.InvalidateItem(this);
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0003581E File Offset: 0x00033A1E
		object global::Infragistics.Collections.ISparseArrayMultiItem.GetItemAtScrollIndex(int scrollIndex)
		{
			return this;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00035821 File Offset: 0x00033A21
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

		// Token: 0x06001038 RID: 4152 RVA: 0x0003582E File Offset: 0x00033A2E
		object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
		{
			return this._sparseArrayOwnerData;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00035836 File Offset: 0x00033A36
		void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
		{
			this._sparseArrayOwnerData = ownerData;
		}

		// Token: 0x040008A8 RID: 2216
		private global::Infragistics.Windows.Internal.TileManager _manager;

		// Token: 0x040008A9 RID: 2217
		private object _item;

		// Token: 0x040008AA RID: 2218
		private int _index;

		// Token: 0x040008AB RID: 2219
		private object _sparseArrayOwnerData;

		// Token: 0x040008AC RID: 2220
		private global::System.Windows.Size? _preferredSizeOverride;
	}
}
