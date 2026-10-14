using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000127 RID: 295
	public class UnselectColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x00025D9B File Offset: 0x00023F9B
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.ColumnLayout.Grid.UnselectColumn(col);
		}
	}
}
