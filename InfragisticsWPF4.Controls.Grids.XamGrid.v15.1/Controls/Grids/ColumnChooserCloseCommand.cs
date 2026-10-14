using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000015 RID: 21
	public class ColumnChooserCloseCommand : global::Infragistics.Controls.Grids.ColumnChooserCommandBase
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00008328 File Offset: 0x00006528
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.ColumnLayout col)
		{
			col.Grid.HideColumnChooser();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008335 File Offset: 0x00006535
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.ColumnLayout.Grid.HideColumnChooser();
		}
	}
}
