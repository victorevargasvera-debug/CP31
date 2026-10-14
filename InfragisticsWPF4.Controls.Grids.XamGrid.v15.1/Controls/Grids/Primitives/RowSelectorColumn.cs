using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000263 RID: 611
	public class RowSelectorColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x06001392 RID: 5010 RVA: 0x00049B54 File Offset: 0x00047D54
		public RowSelectorColumn()
		{
			this.MinimumWidth = 30.0;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00049B6B File Offset: 0x00047D6B
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.AddNewRowSelectorCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.FilterRowSelectorCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.SummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.SummaryRowSelectorCell(row, this);
			}
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorCell(row, this);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00049BA8 File Offset: 0x00047DA8
		protected override global::Infragistics.Controls.Grids.CellBase GenerateHeaderCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCell(row, this);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00049BB1 File Offset: 0x00047DB1
		protected override global::Infragistics.Controls.Grids.CellBase GenerateFooterCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCell(row, this);
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00049BBA File Offset: 0x00047DBA
		public override bool IsSortable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00049BBD File Offset: 0x00047DBD
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00049BC0 File Offset: 0x00047DC0
		public override bool IsMovable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00049BC3 File Offset: 0x00047DC3
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00049BC6 File Offset: 0x00047DC6
		protected internal override bool SupportsHeaderFooterContent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00049BC9 File Offset: 0x00047DC9
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00049BCC File Offset: 0x00047DCC
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

		// Token: 0x0600139D RID: 5021 RVA: 0x00049BFD File Offset: 0x00047DFD
		protected internal override void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00049BFF File Offset: 0x00047DFF
		public override bool IsSummable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00049C02 File Offset: 0x00047E02
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00049C05 File Offset: 0x00047E05
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
