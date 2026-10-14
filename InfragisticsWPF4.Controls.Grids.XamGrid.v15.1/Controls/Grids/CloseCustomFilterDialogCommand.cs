using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000DC RID: 220
	public class CloseCustomFilterDialogCommand : global::Infragistics.CommandBase
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x0001E37C File Offset: 0x0001C57C
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001E380 File Offset: 0x0001C580
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl;
			if (columnFilterDialogControl != null)
			{
				columnFilterDialogControl.Hide();
				global::System.Windows.VisualStateManager.GoToState(columnFilterDialogControl.Cell.Row.ColumnLayout.Grid, "Active", false);
				columnFilterDialogControl.Cell = null;
			}
			base.Execute(parameter);
		}
	}
}
