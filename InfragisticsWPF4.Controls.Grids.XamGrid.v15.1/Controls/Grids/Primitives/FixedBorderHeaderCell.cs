using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200020C RID: 524
	public class FixedBorderHeaderCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000EEB RID: 3819 RVA: 0x00038A69 File Offset: 0x00036C69
		protected internal FixedBorderHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00038A73 File Offset: 0x00036C73
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.FixedColumnSettings.FixedBorderHeaderStyleResolved;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00038A99 File Offset: 0x00036C99
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.FixedBorderHeaderCell._recyclingElementType;
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00038AA0 File Offset: 0x00036CA0
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderHeaderCellControl();
		}

		// Token: 0x040004CC RID: 1228
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderHeaderCellControl);
	}
}
