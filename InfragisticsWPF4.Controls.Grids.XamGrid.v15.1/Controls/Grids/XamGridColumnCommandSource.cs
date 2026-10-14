using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200023C RID: 572
	public class XamGridColumnCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0003FB2B File Offset: 0x0003DD2B
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x0003FB33 File Offset: 0x0003DD33
		public global::Infragistics.Controls.Grids.XamGridColumnCommand CommandType { get; set; }

		// Token: 0x0600112C RID: 4396 RVA: 0x0003FB3C File Offset: 0x0003DD3C
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.SortAscending:
				result = new global::Infragistics.Controls.Grids.Primitives.SortAscendingCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.SortToggle:
				result = new global::Infragistics.Controls.Grids.Primitives.SortToggleCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.SortDescending:
				result = new global::Infragistics.Controls.Grids.Primitives.SortDescendingCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Unsort:
				result = new global::Infragistics.Controls.Grids.Primitives.UnsortCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.SortAscendingToggle:
				result = new global::Infragistics.Controls.Grids.Primitives.SortAscendingToggleCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.SortDescendingToggle:
				result = new global::Infragistics.Controls.Grids.Primitives.SortDescendingToggleCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Fix:
				result = new global::Infragistics.Controls.Grids.Primitives.FixColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.FixLeft:
				result = new global::Infragistics.Controls.Grids.Primitives.FixColumnLeftCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.FixRight:
				result = new global::Infragistics.Controls.Grids.Primitives.FixColumnRightCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Unfix:
				result = new global::Infragistics.Controls.Grids.Primitives.UnfixColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Select:
				result = new global::Infragistics.Controls.Grids.Primitives.SelectColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Unselect:
				result = new global::Infragistics.Controls.Grids.Primitives.UnselectColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.GroupBy:
				result = new global::Infragistics.Controls.Grids.Primitives.GroupByColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.RemoveGroupBy:
				result = new global::Infragistics.Controls.Grids.Primitives.RemoveGroupByColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Hide:
				result = new global::Infragistics.Controls.Grids.HideColumnCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnCommand.Show:
				result = new global::Infragistics.Controls.Grids.ShowColumnCommand();
				break;
			}
			return result;
		}
	}
}
