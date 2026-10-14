using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200029A RID: 666
	public class DeleteCommand : global::Infragistics.Controls.Grids.XamGridCommandBase
	{
		// Token: 0x06001806 RID: 6150 RVA: 0x0005E68E File Offset: 0x0005C88E
		protected override void Execute(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			grid.DeleteKey();
		}
	}
}
