using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200022C RID: 556
	public class SummaryRowCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000FA0 RID: 4000 RVA: 0x0003B2F8 File Offset: 0x000394F8
		protected internal SummaryRowCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0003B302 File Offset: 0x00039502
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl();
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0003B30C File Offset: 0x0003950C
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				if (base.Column != null && base.Column.SummaryColumnSettings.SummaryRowCellStyle != null)
				{
					return base.Column.SummaryColumnSettings.SummaryRowCellStyle;
				}
				return base.Row.ColumnLayout.SummaryRowSettings.StyleResolved;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0003B368 File Offset: 0x00039568
		public override bool IsEditable
		{
			get
			{
				return false;
			}
		}
	}
}
