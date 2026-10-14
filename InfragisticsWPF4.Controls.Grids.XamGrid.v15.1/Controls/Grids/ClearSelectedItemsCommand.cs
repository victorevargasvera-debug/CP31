using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D8 RID: 216
	public class ClearSelectedItemsCommand : global::Infragistics.CommandBase
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x0001E284 File Offset: 0x0001C484
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.SelectionControl selectionControl = parameter as global::Infragistics.Controls.Grids.Primitives.SelectionControl;
			if (selectionControl != null && selectionControl.Cell != null)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)selectionControl.Cell.Row.Manager;
				global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowsManager.RowFiltersCollectionResolved[selectionControl.Cell.Column.Key];
				return rowsFilter != null && rowsFilter.Conditions.Count > 0;
			}
			return false;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0001E2EC File Offset: 0x0001C4EC
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = parameter as global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl;
			if (filterSelectionControl != null)
			{
				filterSelectionControl.ClearExistingFilters();
			}
		}
	}
}
