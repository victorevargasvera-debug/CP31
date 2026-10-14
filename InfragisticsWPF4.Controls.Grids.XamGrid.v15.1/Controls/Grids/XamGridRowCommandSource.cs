using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000285 RID: 645
	public class XamGridRowCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0004DED1 File Offset: 0x0004C0D1
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x0004DED9 File Offset: 0x0004C0D9
		public global::Infragistics.Controls.Grids.XamGridRowCommand CommandType { get; set; }

		// Token: 0x0600155B RID: 5467 RVA: 0x0004DEE4 File Offset: 0x0004C0E4
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridRowCommand.Delete:
				result = new global::Infragistics.Controls.Grids.Primitives.RowDeleteCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridRowCommand.Expand:
				result = new global::Infragistics.Controls.Grids.Primitives.RowExpandCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridRowCommand.Collapse:
				result = new global::Infragistics.Controls.Grids.Primitives.RowCollapseCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridRowCommand.Edit:
				result = new global::Infragistics.Controls.Grids.Primitives.RowEditCommand();
				break;
			}
			return result;
		}
	}
}
