using System;
using System.ComponentModel;
using DevAge.ComponentModel;
using SourceGrid.Cells.Controllers;

namespace SourceGrid
{
	// Token: 0x02000403 RID: 1027
	internal class DataGridCellController : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x06002D54 RID: 11604 RVA: 0x00098A74 File Offset: 0x00096C74
		public override void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e)
		{
			base.OnValueChanging(sender, e);
			if (!((global::SourceGrid.DataGrid)sender.Grid).BeginEditRow(sender.Position.Row))
			{
				throw new global::SourceGrid.SourceGridException("Failed to editing row " + sender.Position.Row.ToString());
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00098AD8 File Offset: 0x00096CD8
		public override void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnEditStarting(sender, e);
			bool flag = ((global::SourceGrid.DataGrid)sender.Grid).BeginEditRow(sender.Position.Row);
			e.Cancel = !flag;
		}
	}
}
