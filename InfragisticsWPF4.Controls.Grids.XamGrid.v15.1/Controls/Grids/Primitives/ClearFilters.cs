using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C1 RID: 193
	public class ClearFilters : global::Infragistics.Controls.Grids.Primitives.RowFilteringCommandBase
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x0001D9F5 File Offset: 0x0001BBF5
		public override bool CanExecute(object parameter)
		{
			return parameter is global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001DA00 File Offset: 0x0001BC00
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell)
		{
			if (filterRowCell != null)
			{
				global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = filterRowCell.Row as global::Infragistics.Controls.Grids.Primitives.FilterRow;
				if (filterRow != null)
				{
					filterRow.RemoveFilters(filterRowCell);
				}
			}
		}
	}
}
