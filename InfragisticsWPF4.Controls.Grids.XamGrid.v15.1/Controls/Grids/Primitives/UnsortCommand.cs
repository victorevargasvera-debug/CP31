using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000132 RID: 306
	public class UnsortCommand : global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00026DC2 File Offset: 0x00024FC2
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.Primitives.SortingBaseCommand.ExecuteCommandHelper(global::Infragistics.Controls.Grids.SortDirection.None, col);
		}
	}
}
