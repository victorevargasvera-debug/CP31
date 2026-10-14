using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000105 RID: 261
	public class GroupByToggleCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x00021D1D File Offset: 0x0001FF1D
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsGroupBy = !col.IsGroupBy;
		}
	}
}
