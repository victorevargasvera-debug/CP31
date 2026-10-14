using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000133 RID: 307
	public class SortAscendingToggleCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A14 RID: 2580 RVA: 0x00026DD4 File Offset: 0x00024FD4
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper((col.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending) ? global::Infragistics.Controls.Grids.SortDirection.None : global::Infragistics.Controls.Grids.SortDirection.Ascending, col);
		}
	}
}
