using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200012F RID: 303
	public class SortAscendingCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A0C RID: 2572 RVA: 0x00026D8A File Offset: 0x00024F8A
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper(global::Infragistics.Controls.Grids.SortDirection.Ascending, col);
		}
	}
}
