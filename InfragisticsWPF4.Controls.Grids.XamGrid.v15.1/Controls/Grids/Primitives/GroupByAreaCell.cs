using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200020F RID: 527
	public class GroupByAreaCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x00038CA9 File Offset: 0x00036EA9
		public GroupByAreaCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00038CB3 File Offset: 0x00036EB3
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl);
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00038CBF File Offset: 0x00036EBF
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl();
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00038CC6 File Offset: 0x00036EC6
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.Grid.GroupBySettings.GroupByAreaStyle;
			}
		}
	}
}
