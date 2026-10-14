using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000134 RID: 308
	public class SortDescendingToggleCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x00026E00 File Offset: 0x00025000
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper((col.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Descending) ? global::Infragistics.Controls.Grids.SortDirection.None : global::Infragistics.Controls.Grids.SortDirection.Descending, col);
		}
	}
}
