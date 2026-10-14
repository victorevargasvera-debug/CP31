using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F4 RID: 500
	public class ColumnLayoutTemplateCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000E13 RID: 3603 RVA: 0x00034963 File Offset: 0x00032B63
		public ColumnLayoutTemplateCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0003496D File Offset: 0x00032B6D
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCellControl);
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00034979 File Offset: 0x00032B79
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCellControl();
		}
	}
}
