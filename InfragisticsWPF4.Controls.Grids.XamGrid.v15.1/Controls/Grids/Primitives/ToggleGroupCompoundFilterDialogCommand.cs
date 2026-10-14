using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200007E RID: 126
	public class ToggleGroupCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x00013654 File Offset: 0x00011854
		public override bool CanExecute(object parameter)
		{
			bool result = false;
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null && compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows.Count > 0)
			{
				global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = null;
				bool flag = true;
				foreach (global::Infragistics.Controls.Grids.Row row in compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
					if (xamGridConditionInfoGroup == null)
					{
						xamGridConditionInfoGroup = xamGridConditionInfo.Group;
					}
					else if (xamGridConditionInfoGroup != xamGridConditionInfo.Group)
					{
						flag = false;
						break;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00013704 File Offset: 0x00011904
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.ToggleGroup();
			}
			base.Execute(parameter);
		}
	}
}
