using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000F3 RID: 243
	public class FixColumnLeftCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x000208E1 File Offset: 0x0001EAE1
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsFixed = global::Infragistics.Controls.Grids.FixedState.Left;
		}
	}
}
