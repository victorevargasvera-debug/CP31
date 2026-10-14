using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000079 RID: 121
	public class RemoveConditionsCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x0001343C File Offset: 0x0001163C
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			return compoundFilterDialogControl == null || compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows.Count > 0;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00013470 File Offset: 0x00011670
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.RemoveConditions();
			}
			base.Execute(parameter);
		}
	}
}
