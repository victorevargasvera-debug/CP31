using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001EA RID: 490
	public class AddNewRowExpansionIndicatorCell : global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x000341B5 File Offset: 0x000323B5
		protected internal AddNewRowExpansionIndicatorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000341BF File Offset: 0x000323BF
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.AddNewRowSettings.ExpansionIndicatorStyleResolved;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000341E5 File Offset: 0x000323E5
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.AddNewRowExpansionIndicatorCellControl);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000341F1 File Offset: 0x000323F1
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.AddNewRowExpansionIndicatorCellControl();
		}
	}
}
