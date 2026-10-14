using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200001A RID: 26
	public class ShowColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00008416 File Offset: 0x00006616
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.Visibility = global::System.Windows.Visibility.Visible;
		}
	}
}
