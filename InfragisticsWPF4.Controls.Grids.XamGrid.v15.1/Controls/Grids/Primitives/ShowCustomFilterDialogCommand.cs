using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000E0 RID: 224
	public class ShowCustomFilterDialogCommand : global::Infragistics.Controls.Grids.CellBaseCommandBase
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x0001E430 File Offset: 0x0001C630
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001E434 File Offset: 0x0001C634
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.CellBase cell)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = cell.Row.ColumnLayout.Grid;
			grid.Panel.CustomFilterDialogControl.Cell = cell;
			grid.Panel.CustomFilterDialogControl.Show();
			base.CommandSource.Handled = false;
		}
	}
}
