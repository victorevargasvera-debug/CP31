using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021F RID: 543
	public class GroupHeaderCell : global::Infragistics.Controls.Grids.Primitives.HeaderCell
	{
		// Token: 0x06000F60 RID: 3936 RVA: 0x0003AA6B File Offset: 0x00038C6B
		public GroupHeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0003AA75 File Offset: 0x00038C75
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupHeaderCellControl();
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0003AA7C File Offset: 0x00038C7C
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
