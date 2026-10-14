using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016E RID: 366
	internal class ItemLayoutInfoLayoutItem : global::Infragistics.Windows.DataPresenter.CellLayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x00061AFC File Offset: 0x0005FCFC
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00061BF7 File Offset: 0x0005FDF7
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this._layoutInfo.Column;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00061C04 File Offset: 0x0005FE04
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this._layoutInfo.ColumnSpan;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00061C11 File Offset: 0x0005FE11
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this._fieldConstraint.ColumnWeight;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00061C1E File Offset: 0x0005FE1E
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this._fieldConstraint.HorizontalAlignment;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00061C2C File Offset: 0x0005FE2C
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x00061C5C File Offset: 0x0005FE5C
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this._layoutInfo.Row;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00061C69 File Offset: 0x0005FE69
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this._layoutInfo.RowSpan;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00061C76 File Offset: 0x0005FE76
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this._fieldConstraint.RowWeight;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00061C83 File Offset: 0x0005FE83
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this._fieldConstraint.VerticalAlignment;
			}
		}

		// Token: 0x04000883 RID: 2179
		private global::Infragistics.Windows.DataPresenter.ItemLayoutInfo _layoutInfo;

		// Token: 0x04000884 RID: 2180
		private global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint _fieldConstraint;

		// Token: 0x04000885 RID: 2181
		private global::System.Windows.Thickness? _margin;
	}
}
