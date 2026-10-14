using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000188 RID: 392
	internal class CellLayoutItem : global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase, global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x00073648 File Offset: 0x00071848
		internal CellLayoutItem(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem) : base(layoutItem.Field, layoutItem.IsLabel)
		{
			this._layoutItem = layoutItem;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00073663 File Offset: 0x00071863
		protected CellLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellLayoutItem source) : base(field, source)
		{
			this._layoutItem = source._layoutItem.Clone(field);
			this._preferredHeight = source._preferredHeight;
			this._preferredWidth = source._preferredWidth;
			this._forceUnfixed = source._forceUnfixed;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000736A3 File Offset: 0x000718A3
		internal override global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase Clone(global::Infragistics.Windows.DataPresenter.Field newField)
		{
			return new global::Infragistics.Windows.DataPresenter.CellLayoutItem(newField, this);
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000736AC File Offset: 0x000718AC
		public override global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation
		{
			get
			{
				if (this._forceUnfixed)
				{
					return global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
				}
				return base.FixedLocation;
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000736BE File Offset: 0x000718BE
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this._layoutItem).Visibility;
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000736CC File Offset: 0x000718CC
		public override double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			switch (size)
			{
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth:
				if (this._preferredWidth != null)
				{
					return this._preferredWidth.Value;
				}
				goto IL_D2;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight:
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight:
				if (this._manager != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = this._manager.Record;
					if (record != null && record.ShouldCollapseCell(this.Field))
					{
						return 0.0;
					}
				}
				return this._layoutItem.GetSize(size);
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight:
			{
				if (this._preferredHeight != null)
				{
					return this._preferredHeight.Value;
				}
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (this._manager != null) ? this._manager.CellPanel : null;
				double result;
				if (virtualizingDataRecordCellPanel != null && virtualizingDataRecordCellPanel.TryGetPreferredExtent(this, !this.IsLabel, false, out result))
				{
					return result;
				}
				goto IL_D2;
			}
			}
			return this._layoutItem.GetSize(size);
			IL_D2:
			return this._layoutItem.GetSize(size);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000737B7 File Offset: 0x000719B7
		public override global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode
		{
			get
			{
				if (this._manager != null)
				{
					return this._manager.RecordSizingMode;
				}
				return this.InnerLayoutItem.RecordSizingMode;
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x000737D8 File Offset: 0x000719D8
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Field.Owner;
			if (owner == null || owner.IsHorizontal || !global::Infragistics.Windows.DataPresenter.GridUtilities.IsVariableHeightRecordMode(this.RecordSizingMode))
			{
				this._layoutItem.SetPreferredHeight(value, type);
				return;
			}
			this._preferredHeight = new double?(value);
			base.OnHeightChanged();
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0007382C File Offset: 0x00071A2C
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Field.Owner;
			if (owner == null || !owner.IsHorizontal || !global::Infragistics.Windows.DataPresenter.GridUtilities.IsVariableHeightRecordMode(this.RecordSizingMode))
			{
				this._layoutItem.SetPreferredWidth(value, type);
				return;
			}
			this._preferredWidth = new double?(value);
			base.OnWidthChanged();
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0007387D File Offset: 0x00071A7D
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				return this._layoutItem.SizeTypeHeight;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0007388A File Offset: 0x00071A8A
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				return this._layoutItem.SizeTypeWidth;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00073897 File Offset: 0x00071A97
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0007389F File Offset: 0x00071A9F
		internal bool ForceUnfixed
		{
			get
			{
				return this._forceUnfixed;
			}
			set
			{
				this._forceUnfixed = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x000738A8 File Offset: 0x00071AA8
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x000738B0 File Offset: 0x00071AB0
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x000738B8 File Offset: 0x00071AB8
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager LayoutManager
		{
			get
			{
				return this._manager;
			}
			set
			{
				this._manager = value;
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000738C1 File Offset: 0x00071AC1
		internal void InitializeFrom(global::Infragistics.Windows.DataPresenter.CellLayoutItem srcItem)
		{
			this._preferredHeight = srcItem._preferredHeight;
			this._preferredWidth = srcItem._preferredWidth;
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060018D5 RID: 6357 RVA: 0x000738DB File Offset: 0x00071ADB
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x000738E3 File Offset: 0x00071AE3
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x000738EB File Offset: 0x00071AEB
		double? global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.ExplicitWidth
		{
			get
			{
				return this._preferredWidth;
			}
			set
			{
				if (!object.Equals(this._preferredWidth, value))
				{
					this._preferredWidth = value;
					base.OnWidthChanged();
				}
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00073912 File Offset: 0x00071B12
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0007391A File Offset: 0x00071B1A
		double? global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.ExplicitHeight
		{
			get
			{
				return this._preferredHeight;
			}
			set
			{
				if (!object.Equals(this._preferredHeight, value))
				{
					this._preferredHeight = value;
					base.OnWidthChanged();
				}
			}
		}

		// Token: 0x04000A2B RID: 2603
		private global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase _layoutItem;

		// Token: 0x04000A2C RID: 2604
		private double? _preferredWidth;

		// Token: 0x04000A2D RID: 2605
		private double? _preferredHeight;

		// Token: 0x04000A2E RID: 2606
		private bool _forceUnfixed;

		// Token: 0x04000A2F RID: 2607
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _manager;
	}
}
