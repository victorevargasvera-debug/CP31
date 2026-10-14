using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000F4 RID: 244
	public class FixColumnRightCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x000208F2 File Offset: 0x0001EAF2
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsFixed = global::Infragistics.Controls.Grids.FixedState.Right;
		}
	}
}
