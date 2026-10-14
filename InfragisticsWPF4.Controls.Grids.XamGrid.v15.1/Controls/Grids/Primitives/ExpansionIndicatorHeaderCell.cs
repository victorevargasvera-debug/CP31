using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001FF RID: 511
	public class ExpansionIndicatorHeaderCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x00035E52 File Offset: 0x00034052
		protected internal ExpansionIndicatorHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00035E5C File Offset: 0x0003405C
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.ExpansionIndicatorSettings.HeaderStyleResolved;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00035E82 File Offset: 0x00034082
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorHeaderCell._recyclingElementType;
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00035E89 File Offset: 0x00034089
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorHeaderCellControl();
		}

		// Token: 0x040004A9 RID: 1193
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorHeaderCellControl);
	}
}
