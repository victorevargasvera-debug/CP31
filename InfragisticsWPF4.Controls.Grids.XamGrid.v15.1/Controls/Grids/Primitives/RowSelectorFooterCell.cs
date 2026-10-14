using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000227 RID: 551
	public class RowSelectorFooterCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x0003B1BC File Offset: 0x000393BC
		protected internal RowSelectorFooterCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0003B1C6 File Offset: 0x000393C6
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.RowSelectorSettings.FooterStyleResolved;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0003B1EC File Offset: 0x000393EC
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCell._recyclingElementType;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0003B1F3 File Offset: 0x000393F3
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCellControl();
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0003B1FA File Offset: 0x000393FA
		protected internal override void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.Row.ColumnLayout.Grid.OnRowSelectorClicked(base.Row);
		}

		// Token: 0x040004E6 RID: 1254
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCellControl);
	}
}
