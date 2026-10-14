using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200022F RID: 559
	public class SummaryRowSelectorCell : global::Infragistics.Controls.Grids.Primitives.RowSelectorCell
	{
		// Token: 0x06000FA9 RID: 4009 RVA: 0x0003B3B7 File Offset: 0x000395B7
		protected internal SummaryRowSelectorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0003B3C1 File Offset: 0x000395C1
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				return base.Row.ColumnLayout.SummaryRowSettings.RowSelectorStyleResolved;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0003B3D8 File Offset: 0x000395D8
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.SummaryRowSelectorCellControl);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0003B3E4 File Offset: 0x000395E4
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.SummaryRowSelectorCellControl();
		}
	}
}
