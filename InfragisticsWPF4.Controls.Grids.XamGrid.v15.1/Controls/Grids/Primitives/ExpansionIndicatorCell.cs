using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001E9 RID: 489
	public class ExpansionIndicatorCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000DDD RID: 3549 RVA: 0x00034166 File Offset: 0x00032366
		protected internal ExpansionIndicatorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00034170 File Offset: 0x00032370
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.ExpansionIndicatorSettings.StyleResolved;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00034196 File Offset: 0x00032396
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell._recyclingElementType;
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0003419D File Offset: 0x0003239D
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCellControl();
		}

		// Token: 0x0400048C RID: 1164
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCellControl);
	}
}
