using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000287 RID: 647
	public class RowCollapseCommand : global::Infragistics.Controls.Grids.RowCommandBase
	{
		// Token: 0x0600155F RID: 5471 RVA: 0x0004DF4A File Offset: 0x0004C14A
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Row row)
		{
			row.IsExpanded = false;
		}
	}
}
