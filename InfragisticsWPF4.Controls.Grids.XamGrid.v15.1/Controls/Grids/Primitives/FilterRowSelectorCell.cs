using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000206 RID: 518
	public class FilterRowSelectorCell : global::Infragistics.Controls.Grids.Primitives.RowSelectorCell
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x00038893 File Offset: 0x00036A93
		protected internal FilterRowSelectorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0003889D File Offset: 0x00036A9D
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.FilterRowSelectorCell._recyclingElementType;
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000388A4 File Offset: 0x00036AA4
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterRowSelectorCellControl();
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000388AB File Offset: 0x00036AAB
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.FilteringSettings.RowSelectorStyleResolved;
			}
		}

		// Token: 0x040004C9 RID: 1225
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.FilterRowSelectorCellControl);
	}
}
