using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001FC RID: 508
	public class ExpansionIndicatorFooterCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x00035C8E File Offset: 0x00033E8E
		protected internal ExpansionIndicatorFooterCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00035C98 File Offset: 0x00033E98
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.ExpansionIndicatorSettings.FooterStyleResolved;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00035CBE File Offset: 0x00033EBE
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorFooterCell._recyclingElementType;
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00035CC5 File Offset: 0x00033EC5
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorFooterCellControl();
		}

		// Token: 0x040004A6 RID: 1190
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorFooterCellControl);
	}
}
