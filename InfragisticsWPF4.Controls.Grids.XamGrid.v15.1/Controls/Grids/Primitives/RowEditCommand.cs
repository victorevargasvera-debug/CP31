using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000289 RID: 649
	public class RowEditCommand : global::Infragistics.Controls.Grids.RowCommandBase
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x0004DF7B File Offset: 0x0004C17B
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Row row)
		{
			if (row.ColumnLayout != null && row.ColumnLayout.Grid != null)
			{
				row.ColumnLayout.Grid.EnterEditMode(row);
			}
		}
	}
}
