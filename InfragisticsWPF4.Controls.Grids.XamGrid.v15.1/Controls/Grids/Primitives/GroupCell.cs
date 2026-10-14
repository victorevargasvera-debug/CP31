using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000219 RID: 537
	public class GroupCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x0003A577 File Offset: 0x00038777
		public GroupCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0003A581 File Offset: 0x00038781
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupCellControl();
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0003A588 File Offset: 0x00038788
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				global::Infragistics.Controls.Grids.GroupColumn groupColumn = (global::Infragistics.Controls.Grids.GroupColumn)base.Column;
				foreach (global::Infragistics.Controls.Grids.Column column in groupColumn.Columns)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = base.Row.Cells[column];
					cellBase.EnsureCurrentState();
				}
			}
		}
	}
}
