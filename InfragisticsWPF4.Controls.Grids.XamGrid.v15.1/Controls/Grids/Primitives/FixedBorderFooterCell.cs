using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200020A RID: 522
	public class FixedBorderFooterCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000EE4 RID: 3812 RVA: 0x000389AA File Offset: 0x00036BAA
		protected internal FixedBorderFooterCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000389B4 File Offset: 0x00036BB4
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.FixedColumnSettings.FixedBorderFooterStyleResolved;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000389DA File Offset: 0x00036BDA
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCell._recyclingElementType;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000389E1 File Offset: 0x00036BE1
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl();
		}

		// Token: 0x040004CB RID: 1227
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderFooterCellControl);
	}
}
