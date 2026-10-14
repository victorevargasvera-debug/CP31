using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200007D RID: 125
	public class UngroupCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x000135A4 File Offset: 0x000117A4
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				bool result = false;
				foreach (global::Infragistics.Controls.Grids.Row row in compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
					if (compoundFilterDialogControl.MasterParentGroup != xamGridConditionInfo.Group)
					{
						result = true;
						break;
					}
				}
				return result;
			}
			return false;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00013628 File Offset: 0x00011828
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.Ungroup();
			}
			base.Execute(parameter);
		}
	}
}
