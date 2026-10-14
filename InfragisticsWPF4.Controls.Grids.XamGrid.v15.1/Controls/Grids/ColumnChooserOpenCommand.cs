using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000016 RID: 22
	public class ColumnChooserOpenCommand : global::Infragistics.Controls.Grids.ColumnChooserCommandBase
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000834F File Offset: 0x0000654F
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.ColumnLayout col)
		{
			col.Grid.ShowColumnChooser(col);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000835D File Offset: 0x0000655D
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.ColumnLayout.Grid.ShowColumnChooser(col);
		}
	}
}
