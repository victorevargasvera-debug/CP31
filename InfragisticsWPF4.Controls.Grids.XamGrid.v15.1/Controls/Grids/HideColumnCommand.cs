using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000019 RID: 25
	public class HideColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00008405 File Offset: 0x00006605
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.Visibility = global::System.Windows.Visibility.Collapsed;
		}
	}
}
