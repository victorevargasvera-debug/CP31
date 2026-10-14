using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000215 RID: 533
	public class GroupByHeaderCell : global::Infragistics.Controls.Grids.Primitives.HeaderCell
	{
		// Token: 0x06000F24 RID: 3876 RVA: 0x0003A172 File Offset: 0x00038372
		public GroupByHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0003A17C File Offset: 0x0003837C
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl);
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0003A188 File Offset: 0x00038388
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl();
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0003A190 File Offset: 0x00038390
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				global::Infragistics.Controls.Grids.Column resolveColumn = this.ResolveColumn;
				if (resolveColumn != null && resolveColumn.GroupByHeaderStyle != null)
				{
					return resolveColumn.GroupByHeaderStyle;
				}
				return base.Row.ColumnLayout.GroupBySettings.GroupByHeaderStyleResolved;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0003A1CB File Offset: 0x000383CB
		protected internal virtual global::Infragistics.Controls.Grids.Column ResolveColumn
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)base.Row.Manager).GroupedColumn;
			}
		}
	}
}
