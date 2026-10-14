using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000116 RID: 278
	public class XamGridPagingCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00025319 File Offset: 0x00023519
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00025321 File Offset: 0x00023521
		public global::Infragistics.Controls.Grids.XamGridPagingCommand CommandType { get; set; }

		// Token: 0x06000965 RID: 2405 RVA: 0x0002532C File Offset: 0x0002352C
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.FirstPage:
				result = new global::Infragistics.Controls.Grids.Primitives.FirstPageCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.PreviousPage:
				result = new global::Infragistics.Controls.Grids.Primitives.PreviousPageCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.NextPage:
				result = new global::Infragistics.Controls.Grids.Primitives.NextPageCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.LastPage:
				result = new global::Infragistics.Controls.Grids.Primitives.LastPageCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridPagingCommand.GoToPage:
				result = new global::Infragistics.Controls.Grids.Primitives.GoToPageCommand();
				break;
			}
			return result;
		}
	}
}
