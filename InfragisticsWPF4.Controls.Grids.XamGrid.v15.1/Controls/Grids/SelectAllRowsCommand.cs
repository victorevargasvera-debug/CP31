using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000299 RID: 665
	public class SelectAllRowsCommand : global::Infragistics.Controls.Grids.XamGridCommandBase
	{
		// Token: 0x06001804 RID: 6148 RVA: 0x0005E679 File Offset: 0x0005C879
		protected override void Execute(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			grid.Rows.SelectAll();
		}
	}
}
