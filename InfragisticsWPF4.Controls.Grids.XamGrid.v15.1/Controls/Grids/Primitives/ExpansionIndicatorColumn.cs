using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200024C RID: 588
	public class ExpansionIndicatorColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x00045B4D File Offset: 0x00043D4D
		public ExpansionIndicatorColumn()
		{
			this.MinimumWidth = 30.0;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00045B64 File Offset: 0x00043D64
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.AddNewRowExpansionIndicatorCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.FilterRowExpansionIndicatorCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.SummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.SummaryRowExpansionIndicatorCell(row, this);
			}
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell(row, this);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00045BA1 File Offset: 0x00043DA1
		protected override global::Infragistics.Controls.Grids.CellBase GenerateHeaderCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorHeaderCell(row, this);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00045BAA File Offset: 0x00043DAA
		protected override global::Infragistics.Controls.Grids.CellBase GenerateFooterCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorFooterCell(row, this);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00045BB3 File Offset: 0x00043DB3
		public override bool IsSortable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00045BB6 File Offset: 0x00043DB6
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00045BB9 File Offset: 0x00043DB9
		public override bool IsMovable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00045BBC File Offset: 0x00043DBC
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00045BBF File Offset: 0x00043DBF
		protected internal override bool SupportsHeaderFooterContent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00045BC2 File Offset: 0x00043DC2
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00045BC8 File Offset: 0x00043DC8
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				if (this.Width == null)
				{
					return global::Infragistics.Controls.Grids.ColumnWidth.Auto;
				}
				return this.Width.Value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00045BF9 File Offset: 0x00043DF9
		public override bool IsSummable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00045BFC File Offset: 0x00043DFC
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x00045BFF File Offset: 0x00043DFF
		public override bool IsGroupable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsGroupable = value;
			}
		}
	}
}
