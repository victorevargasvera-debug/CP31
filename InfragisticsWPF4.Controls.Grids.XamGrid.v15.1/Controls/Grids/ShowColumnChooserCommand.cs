using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200029B RID: 667
	public class ShowColumnChooserCommand : global::Infragistics.Controls.Grids.XamGridCommandBase
	{
		// Token: 0x06001808 RID: 6152 RVA: 0x0005E69E File Offset: 0x0005C89E
		protected override void Execute(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			grid.ShowColumnChooser();
		}
	}
}
