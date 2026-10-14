using System;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C4 RID: 196
	public class FilterMenuFilterTextBoxFilterTextCommand : global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxCommand
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x0001DB50 File Offset: 0x0001BD50
		protected override void ExecuteCommand(object parameter)
		{
			global::System.Windows.Controls.TextBox textBox = (global::System.Windows.Controls.TextBox)parameter;
			base.FilterSelectionControl.FilterUniqueValue(textBox.Text);
		}
	}
}
