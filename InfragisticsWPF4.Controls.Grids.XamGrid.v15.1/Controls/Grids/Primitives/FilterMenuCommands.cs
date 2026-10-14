using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C2 RID: 194
	public class FilterMenuCommands : global::Infragistics.CommandBase
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x0001DA2E File Offset: 0x0001BC2E
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001DA34 File Offset: 0x0001BC34
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.XamGridFilterMenuCommandSource xamGridFilterMenuCommandSource = base.CommandSource as global::Infragistics.Controls.Grids.XamGridFilterMenuCommandSource;
			if (xamGridFilterMenuCommandSource.CommandType != null && xamGridFilterMenuCommandSource.CommandType.Count > 0)
			{
				this.ExcecuteCommand(xamGridFilterMenuCommandSource.CommandType, parameter as global::Infragistics.Controls.Grids.CellBase);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001DA78 File Offset: 0x0001BC78
		protected virtual void ExcecuteCommand(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> filterOperand, global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (filterOperand != null && cell != null && filterOperand.Count == 1 && !filterOperand[0].RequiresFilteringInput)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)cell.Row.Manager;
				cell.Row.ColumnLayout.BuildFilters(rowsManager.RowFiltersCollectionResolved, null, cell.Column, filterOperand[0], false, true);
				cell.Row.ColumnLayout.Grid.OnFiltered(rowsManager.RowFiltersCollectionResolved);
			}
		}
	}
}
