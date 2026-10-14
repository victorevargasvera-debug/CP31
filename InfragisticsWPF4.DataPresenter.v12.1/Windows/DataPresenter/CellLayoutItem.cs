using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016C RID: 364
	internal class CellLayoutItem : global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase, global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x00061575 File Offset: 0x0005F775
		internal CellLayoutItem(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem) : base(layoutItem.Field, layoutItem.IsLabel)
		{
			this._layoutItem = layoutItem;
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00061590 File Offset: 0x0005F790
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

		// Token: 0x06001548 RID: 5448 RVA: 0x000615A2 File Offset: 0x0005F7A2
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this._layoutItem).Visibility;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000615B0 File Offset: 0x0005F7B0
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0006169B File Offset: 0x0005F89B
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

		// Token: 0x0600154B RID: 5451 RVA: 0x000616BC File Offset: 0x0005F8BC
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

		// Token: 0x0600154C RID: 5452 RVA: 0x00061710 File Offset: 0x0005F910
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00061761 File Offset: 0x0005F961
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeHeight
		{
			get
			{
				return this._layoutItem.SizeTypeHeight;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0006176E File Offset: 0x0005F96E
		public override global::Infragistics.Windows.DataPresenter.ItemSizeType SizeTypeWidth
		{
			get
			{
				return this._layoutItem.SizeTypeWidth;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0006177B File Offset: 0x0005F97B
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x00061783 File Offset: 0x0005F983
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0006178C File Offset: 0x0005F98C
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00061794 File Offset: 0x0005F994
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0006179C File Offset: 0x0005F99C
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

		// Token: 0x06001554 RID: 5460 RVA: 0x000617A5 File Offset: 0x0005F9A5
		internal void InitializeFrom(global::Infragistics.Windows.DataPresenter.CellLayoutItem srcItem)
		{
			this._preferredHeight = srcItem._preferredHeight;
			this._preferredWidth = srcItem._preferredWidth;
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000617BF File Offset: 0x0005F9BF
		global::Infragistics.Controls.Layouts.Primitives.ILayoutItem global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem.InnerLayoutItem
		{
			get
			{
				return this._layoutItem;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000617C7 File Offset: 0x0005F9C7
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x000617CF File Offset: 0x0005F9CF
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000617F6 File Offset: 0x0005F9F6
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x000617FE File Offset: 0x0005F9FE
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

		// Token: 0x04000875 RID: 2165
		private global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase _layoutItem;

		// Token: 0x04000876 RID: 2166
		private double? _preferredWidth;

		// Token: 0x04000877 RID: 2167
		private double? _preferredHeight;

		// Token: 0x04000878 RID: 2168
		private bool _forceUnfixed;

		// Token: 0x04000879 RID: 2169
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _manager;
	}
}
