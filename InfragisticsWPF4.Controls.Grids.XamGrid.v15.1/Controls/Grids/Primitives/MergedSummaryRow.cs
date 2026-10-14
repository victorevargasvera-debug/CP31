using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027E RID: 638
	public class MergedSummaryRow : global::Infragistics.Controls.Grids.Primitives.SummaryRow
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x0004DB18 File Offset: 0x0004BD18
		protected internal MergedSummaryRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(manager)
		{
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x0004DB21 File Offset: 0x0004BD21
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.MergedSummaryRow;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0004DB25 File Offset: 0x0004BD25
		protected internal override bool RequiresFixedRowSeparator
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0004DB28 File Offset: 0x0004BD28
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0004DB2F File Offset: 0x0004BD2F
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x0004DB37 File Offset: 0x0004BD37
		public global::Infragistics.MergedColumnInfo MergedColumnInfo { get; protected internal set; }
	}
}
