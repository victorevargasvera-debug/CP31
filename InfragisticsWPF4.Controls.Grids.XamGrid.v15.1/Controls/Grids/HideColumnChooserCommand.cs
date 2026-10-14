using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200029C RID: 668
	public class HideColumnChooserCommand : global::Infragistics.Controls.Grids.XamGridCommandBase
	{
		// Token: 0x0600180A RID: 6154 RVA: 0x0005E6AE File Offset: 0x0005C8AE
		protected override void Execute(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			grid.HideColumnChooser();
		}
	}
}
