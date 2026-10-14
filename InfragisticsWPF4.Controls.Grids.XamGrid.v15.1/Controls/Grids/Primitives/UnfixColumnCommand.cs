using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000F5 RID: 245
	public class UnfixColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x00020903 File Offset: 0x0001EB03
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.IsFixed = global::Infragistics.Controls.Grids.FixedState.NotFixed;
		}
	}
}
