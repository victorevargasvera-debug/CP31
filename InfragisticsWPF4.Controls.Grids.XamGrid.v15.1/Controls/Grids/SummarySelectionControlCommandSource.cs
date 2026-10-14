using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000156 RID: 342
	public class SummarySelectionControlCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00029E77 File Offset: 0x00028077
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00029E7F File Offset: 0x0002807F
		public global::Infragistics.Controls.Grids.SummarySelectionControlCommand CommandType { get; set; }

		// Token: 0x06000B1F RID: 2847 RVA: 0x00029E88 File Offset: 0x00028088
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.SummarySelectionControlCommand commandType = this.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.SummarySelectionControlCommand.AcceptChanges)
			{
				result = new global::Infragistics.Controls.Grids.AcceptChangesCommand();
			}
			return result;
		}
	}
}
