using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000211 RID: 529
	public class GroupByCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000F0B RID: 3851 RVA: 0x000391F4 File Offset: 0x000373F4
		protected internal GroupByCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000391FE File Offset: 0x000373FE
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByCellControl);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0003920A File Offset: 0x0003740A
		protected internal override string NormalState
		{
			get
			{
				return "Normal";
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00039211 File Offset: 0x00037411
		protected internal override global::Infragistics.Controls.Grids.Column ResolveColumn
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)base.Row.Manager).GroupedColumn;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00039228 File Offset: 0x00037428
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				global::Infragistics.Controls.Grids.Column resolveColumn = this.ResolveColumn;
				if (resolveColumn != null && resolveColumn.GroupByRowStyle != null)
				{
					return resolveColumn.GroupByRowStyle;
				}
				return base.Row.ColumnLayout.GroupBySettings.GroupByRowStyleResolved;
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00039272 File Offset: 0x00037472
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByCellControl();
		}
	}
}
