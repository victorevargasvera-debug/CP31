using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200022D RID: 557
	public class SummaryRowExpansionIndicatorCell : global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x0003B36B File Offset: 0x0003956B
		protected internal SummaryRowExpansionIndicatorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0003B375 File Offset: 0x00039575
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				return base.Row.ColumnLayout.SummaryRowSettings.ExpansionIndicatorStyleResolved;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0003B38C File Offset: 0x0003958C
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.SummaryRowExpansionIndicatorCellControl);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0003B398 File Offset: 0x00039598
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.SummaryRowExpansionIndicatorCellControl();
		}
	}
}
