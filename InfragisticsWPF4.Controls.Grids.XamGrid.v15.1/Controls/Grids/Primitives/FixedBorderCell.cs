using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000208 RID: 520
	public class FixedBorderCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x000388FC File Offset: 0x00036AFC
		protected internal FixedBorderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00038906 File Offset: 0x00036B06
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				return base.Row.ColumnLayout.FixedColumnSettings.FixedBorderStyleResolved;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0003892C File Offset: 0x00036B2C
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.FixedBorderCell._recyclingElementType;
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00038933 File Offset: 0x00036B33
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FixedBorderCellControl();
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0003893A File Offset: 0x00036B3A
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
		}

		// Token: 0x040004CA RID: 1226
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.FixedBorderCellControl);
	}
}
