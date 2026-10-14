using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000DA RID: 218
	public class CustomFilteringDialogCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001E311 File Offset: 0x0001C511
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x0001E319 File Offset: 0x0001C519
		public global::Infragistics.Controls.Grids.CustomFilteringDialogCommand CommandType { get; set; }

		// Token: 0x06000729 RID: 1833 RVA: 0x0001E324 File Offset: 0x0001C524
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.CustomFilteringDialogCommand commandType = this.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.CustomFilteringDialogCommand.ShowCustomFilterDialog)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ShowCustomFilterDialogCommand();
			}
			return result;
		}
	}
}
