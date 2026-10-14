using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000077 RID: 119
	public class CloseCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x000133B4 File Offset: 0x000115B4
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000133B8 File Offset: 0x000115B8
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.Hide();
				global::System.Windows.VisualStateManager.GoToState(compoundFilterDialogControl.Cell.Row.ColumnLayout.Grid, "Active", false);
				compoundFilterDialogControl.Cell = null;
			}
			base.Execute(parameter);
		}
	}
}
