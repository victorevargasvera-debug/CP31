using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200024E RID: 590
	public class FixedBorderColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00045CBC File Offset: 0x00043EBC
		internal FixedBorderColumn()
		{
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00045CC4 File Offset: 0x00043EC4
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderCell(row, this);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00045CCD File Offset: 0x00043ECD
		protected override global::Infragistics.Controls.Grids.CellBase GenerateHeaderCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderHeaderCell(row, this);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00045CD6 File Offset: 0x00043ED6
		protected override global::Infragistics.Controls.Grids.CellBase GenerateFooterCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCell(row, this);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00045CDF File Offset: 0x00043EDF
		public override bool IsSortable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00045CE2 File Offset: 0x00043EE2
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00045CE5 File Offset: 0x00043EE5
		public override bool IsGroupable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00045CE8 File Offset: 0x00043EE8
		public override bool IsMovable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00045CEB File Offset: 0x00043EEB
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00045CEE File Offset: 0x00043EEE
		public override double MinimumWidth
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00045CF9 File Offset: 0x00043EF9
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00045CFC File Offset: 0x00043EFC
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
	}
}
