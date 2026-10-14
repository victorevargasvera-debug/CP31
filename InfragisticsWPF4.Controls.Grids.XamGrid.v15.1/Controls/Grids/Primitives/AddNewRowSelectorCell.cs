using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001EE RID: 494
	public class AddNewRowSelectorCell : global::Infragistics.Controls.Grids.Primitives.RowSelectorCell
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x000345A5 File Offset: 0x000327A5
		protected internal AddNewRowSelectorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x000345AF File Offset: 0x000327AF
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.AddNewRowSettings.RowSelectorStyleResolved;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000345D5 File Offset: 0x000327D5
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.AddNewRowSelectorCellControl);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000345E1 File Offset: 0x000327E1
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.AddNewRowSelectorCellControl();
		}
	}
}
