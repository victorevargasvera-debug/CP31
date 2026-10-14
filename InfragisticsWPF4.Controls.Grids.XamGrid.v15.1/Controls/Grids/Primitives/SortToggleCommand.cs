using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000131 RID: 305
	public class SortToggleCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00026DAC File Offset: 0x00024FAC
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper(col.NextSortDirection, col);
		}
	}
}
