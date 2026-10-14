using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000288 RID: 648
	public class RowDeleteCommand : global::Infragistics.Controls.Grids.RowCommandBase
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x0004DF5B File Offset: 0x0004C15B
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Row row)
		{
			row.Manager.Rows.ActualCollection.Remove(row);
		}
	}
}
