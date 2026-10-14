using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021D RID: 541
	public class GroupFooterCell : global::Infragistics.Controls.Grids.Primitives.FooterCell
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x0003A965 File Offset: 0x00038B65
		public GroupFooterCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0003A96F File Offset: 0x00038B6F
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupFooterCellControl();
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0003A978 File Offset: 0x00038B78
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
