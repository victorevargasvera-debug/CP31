using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000130 RID: 304
	public class SortDescendingCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A0E RID: 2574 RVA: 0x00026D9B File Offset: 0x00024F9B
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper(global::Infragistics.Controls.Grids.SortDirection.Descending, col);
		}
	}
}
