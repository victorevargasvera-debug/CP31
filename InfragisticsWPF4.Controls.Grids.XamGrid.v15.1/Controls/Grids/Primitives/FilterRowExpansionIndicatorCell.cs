using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000204 RID: 516
	public class FilterRowExpansionIndicatorCell : global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x0003882C File Offset: 0x00036A2C
		protected internal FilterRowExpansionIndicatorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00038836 File Offset: 0x00036A36
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.FilteringSettings.ExpansionIndicatorStyleResolved;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0003885C File Offset: 0x00036A5C
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.FilterRowExpansionIndicatorCell._recyclingElementType;
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00038863 File Offset: 0x00036A63
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterRowExpansionIndicatorCellControl();
		}

		// Token: 0x040004C8 RID: 1224
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.FilterRowExpansionIndicatorCellControl);
	}
}
