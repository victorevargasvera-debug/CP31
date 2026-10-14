using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018A RID: 394
	internal class ItemLayoutInfoLayoutItem : global::Infragistics.Windows.DataPresenter.CellLayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x060018EF RID: 6383 RVA: 0x00073C18 File Offset: 0x00071E18
		internal ItemLayoutInfoLayoutItem(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint baseConstaint, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo layoutInfo) : base(layoutItem)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(layoutInfo);
			this._layoutInfo = layoutInfo.Clone();
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this.Field.Owner;
			if (owner != null && owner.UseCellPresenters)
			{
				int row = this._layoutInfo.Row;
				int column = this._layoutInfo.Column;
				int rowSpan = this._layoutInfo.RowSpan;
				int columnSpan = this._layoutInfo.ColumnSpan;
				global::System.Windows.Thickness cellPresenterMargin = owner.TemplateDataRecordCache.GetCellPresenterMargin(this.Field);
				global::Infragistics.Windows.DataPresenter.FieldLayoutItem.AdjustPositionForCellPresenter(this.Field.CellContentAlignmentResolved, this.IsLabel, ref column, ref row, ref rowSpan, ref columnSpan, ref cellPresenterMargin);
				this._layoutInfo.Row = row;
				this._layoutInfo.RowSpan = rowSpan;
				this._layoutInfo.Column = column;
				this._layoutInfo.ColumnSpan = columnSpan;
				this._margin = new global::System.Windows.Thickness?(cellPresenterMargin);
			}
			this._fieldConstraint = (baseConstaint ?? layoutItem.Field.LayoutConstraint);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00073D13 File Offset: 0x00071F13
		private ItemLayoutInfoLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.ItemLayoutInfoLayoutItem source) : base(field, source)
		{
			this._layoutInfo = source._layoutInfo;
			this._fieldConstraint = source._fieldConstraint;
			this._margin = source._margin;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00073D41 File Offset: 0x00071F41
		internal override global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase Clone(global::Infragistics.Windows.DataPresenter.Field newField)
		{
			return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfoLayoutItem(newField, this);
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00073D4A File Offset: 0x00071F4A
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this._layoutInfo.Column;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00073D57 File Offset: 0x00071F57
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this._layoutInfo.ColumnSpan;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00073D64 File Offset: 0x00071F64
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this._fieldConstraint.ColumnWeight;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00073D71 File Offset: 0x00071F71
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this._fieldConstraint.HorizontalAlignment;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00073D80 File Offset: 0x00071F80
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				global::System.Windows.Thickness? margin = this._margin;
				if (margin == null)
				{
					return this._fieldConstraint.Margin;
				}
				return margin.GetValueOrDefault();
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00073DB0 File Offset: 0x00071FB0
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this._layoutInfo.Row;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00073DBD File Offset: 0x00071FBD
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this._layoutInfo.RowSpan;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00073DCA File Offset: 0x00071FCA
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this._fieldConstraint.RowWeight;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00073DD7 File Offset: 0x00071FD7
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this._fieldConstraint.VerticalAlignment;
			}
		}

		// Token: 0x04000A39 RID: 2617
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _layoutInfo;

		// Token: 0x04000A3A RID: 2618
		private global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint _fieldConstraint;

		// Token: 0x04000A3B RID: 2619
		private global::System.Windows.Thickness? _margin;
	}
}
