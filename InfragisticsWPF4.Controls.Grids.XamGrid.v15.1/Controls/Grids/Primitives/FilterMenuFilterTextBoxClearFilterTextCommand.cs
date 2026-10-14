using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C5 RID: 197
	public class FilterMenuFilterTextBoxClearFilterTextCommand : global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxCommand
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x0001DB7D File Offset: 0x0001BD7D
		protected override void ExecuteCommand(object parameter)
		{
			base.FilterSelectionControl.FilterText = string.Empty;
			base.FilterSelectionControl.FilterUniqueValue(string.Empty);
		}
	}
}
