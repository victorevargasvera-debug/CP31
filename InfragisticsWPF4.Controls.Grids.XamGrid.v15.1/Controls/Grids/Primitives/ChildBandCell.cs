using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F2 RID: 498
	public class ChildBandCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x000347C0 File Offset: 0x000329C0
		protected internal ChildBandCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000347CA File Offset: 0x000329CA
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.ChildBandCell._recyclingElementType;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000347D1 File Offset: 0x000329D1
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style == null)
				{
					return base.Row.ColumnLayout.ChildBandHeaderStyleResolved;
				}
				return this.Style;
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000347F2 File Offset: 0x000329F2
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ChildBandCellControl();
		}

		// Token: 0x04000493 RID: 1171
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.ChildBandCellControl);
	}
}
