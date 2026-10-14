using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000104 RID: 260
	public class RemoveGroupByColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x00021D0C File Offset: 0x0001FF0C
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsGroupBy = false;
		}
	}
}
