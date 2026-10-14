using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000117 RID: 279
	public class XamGridPagingControlsCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0002538D File Offset: 0x0002358D
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00025395 File Offset: 0x00023595
		public global::Infragistics.Controls.Grids.XamGridPagingCommand CommandType { get; set; }

		// Token: 0x06000969 RID: 2409 RVA: 0x000253A0 File Offset: 0x000235A0
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.FirstPage:
				result = new global::Infragistics.Controls.Grids.Primitives.FirstPageControlCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.PreviousPage:
				result = new global::Infragistics.Controls.Grids.Primitives.PreviousPageControlCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.NextPage:
				result = new global::Infragistics.Controls.Grids.Primitives.NextPageControlCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.LastPage:
				result = new global::Infragistics.Controls.Grids.Primitives.LastPageControlCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.GoToPage:
				result = new global::Infragistics.Controls.Grids.Primitives.GoToPageControlCommand();
				break;
			}
			return result;
		}
	}
}
