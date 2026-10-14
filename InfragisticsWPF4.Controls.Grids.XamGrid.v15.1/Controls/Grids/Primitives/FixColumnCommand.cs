using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000F2 RID: 242
	public class FixColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x000208B7 File Offset: 0x0001EAB7
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			if (col.FixedIndicatorDirectionResolved == global::Infragistics.Controls.Grids.FixedIndicatorDirection.Left)
			{
				col.IsFixed = global::Infragistics.Controls.Grids.FixedState.Left;
				return;
			}
			if (col.FixedIndicatorDirectionResolved == global::Infragistics.Controls.Grids.FixedIndicatorDirection.Right)
			{
				col.IsFixed = global::Infragistics.Controls.Grids.FixedState.Right;
			}
		}
	}
}
