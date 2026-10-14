using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D6 RID: 214
	public class FilterSelectionControlCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0001E232 File Offset: 0x0001C432
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0001E23A File Offset: 0x0001C43A
		public global::Infragistics.Controls.Grids.FilterSelectionControlCommand CommandType { get; set; }

		// Token: 0x06000722 RID: 1826 RVA: 0x0001E244 File Offset: 0x0001C444
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.FilterSelectionControlCommand.AcceptChanges:
				result = new global::Infragistics.Controls.Grids.AcceptChangesCommand();
				break;
			case global::Infragistics.Controls.Grids.FilterSelectionControlCommand.ClearSelectedItems:
				result = new global::Infragistics.Controls.Grids.ClearSelectedItemsCommand();
				break;
			}
			return result;
		}
	}
}
