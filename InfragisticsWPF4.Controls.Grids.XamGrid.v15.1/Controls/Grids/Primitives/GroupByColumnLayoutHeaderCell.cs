using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000216 RID: 534
	public class GroupByColumnLayoutHeaderCell : global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCell
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0003A1E2 File Offset: 0x000383E2
		public GroupByColumnLayoutHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0003A1EC File Offset: 0x000383EC
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCellControl);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0003A1F8 File Offset: 0x000383F8
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByColumnLayoutHeaderCellControl();
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x0003A1FF File Offset: 0x000383FF
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.GroupBySettings.GroupByColumnLayoutHeaderStyleResolved;
			}
		}
	}
}
