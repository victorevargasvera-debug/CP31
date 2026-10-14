using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000072 RID: 114
	public class ShowCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.CellBaseCommandBase
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x000132EC File Offset: 0x000114EC
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000132F0 File Offset: 0x000114F0
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.CellBase cell)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = cell.Row.ColumnLayout.Grid;
			grid.Panel.CompoundFilterDialogControl.Cell = cell;
			grid.Panel.CompoundFilterDialogControl.Show();
			base.CommandSource.Handled = false;
		}
	}
}
