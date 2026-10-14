using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000286 RID: 646
	public class RowExpandCommand : global::Infragistics.Controls.Grids.RowCommandBase
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x0004DF39 File Offset: 0x0004C139
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Row row)
		{
			row.IsExpanded = true;
		}
	}
}
