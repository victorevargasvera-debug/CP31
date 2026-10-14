using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000222 RID: 546
	public class MergedSummaryCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000F6B RID: 3947 RVA: 0x0003AB94 File Offset: 0x00038D94
		protected internal MergedSummaryCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0003AB9E File Offset: 0x00038D9E
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.MergedSummaryCellControl();
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x0003ABA5 File Offset: 0x00038DA5
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.SummaryRowSettings.StyleResolved;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0003ABCB File Offset: 0x00038DCB
		protected internal override bool SupportsActivation
		{
			get
			{
				return false;
			}
		}
	}
}
