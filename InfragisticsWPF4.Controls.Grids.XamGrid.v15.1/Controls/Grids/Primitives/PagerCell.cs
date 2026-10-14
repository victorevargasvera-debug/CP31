using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000225 RID: 549
	public class PagerCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000F7B RID: 3963 RVA: 0x0003AEC4 File Offset: 0x000390C4
		protected internal PagerCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0003AECE File Offset: 0x000390CE
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.PagerCell._recyclingElementType;
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0003AED5 File Offset: 0x000390D5
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.PagerCellControl();
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0003AEDC File Offset: 0x000390DC
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0003AEE4 File Offset: 0x000390E4
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.PagerSettings.StyleResolved;
			}
		}

		// Token: 0x040004E4 RID: 1252
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl);
	}
}
