using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000229 RID: 553
	public class RowSelectorHeaderCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000F95 RID: 3989 RVA: 0x0003B240 File Offset: 0x00039440
		protected internal RowSelectorHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0003B24A File Offset: 0x0003944A
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.RowSelectorSettings.HeaderStyleResolved;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0003B270 File Offset: 0x00039470
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCell._recyclingElementType;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0003B277 File Offset: 0x00039477
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCellControl();
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0003B27E File Offset: 0x0003947E
		protected internal override void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.Row.ColumnLayout.Grid.OnRowSelectorClicked(base.Row);
		}

		// Token: 0x040004E7 RID: 1255
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCellControl);
	}
}
