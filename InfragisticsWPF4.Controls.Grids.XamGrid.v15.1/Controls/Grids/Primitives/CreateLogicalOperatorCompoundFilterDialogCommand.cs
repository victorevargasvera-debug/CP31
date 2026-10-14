using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200007A RID: 122
	public abstract class CreateLogicalOperatorCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0001349C File Offset: 0x0001169C
		public override bool CanExecute(object parameter)
		{
			bool result = true;
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				if (compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows.Count > 1)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = null;
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.Row> enumerator = compoundFilterDialogControl.FilterGrid.SelectionSettings.SelectedRows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Controls.Grids.Row row = enumerator.Current;
							global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)row.Data;
							if (xamGridConditionInfoGroup == null)
							{
								xamGridConditionInfoGroup = xamGridConditionInfo.Group;
							}
							else if (xamGridConditionInfoGroup != xamGridConditionInfo.Group)
							{
								result = false;
								break;
							}
						}
						return result;
					}
				}
				result = false;
			}
			return result;
		}
	}
}
