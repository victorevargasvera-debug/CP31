using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000017 RID: 23
	public class XamGridColumnChooserCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00008378 File Offset: 0x00006578
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00008380 File Offset: 0x00006580
		public global::Infragistics.Controls.Grids.XamGridColumnChooserCommand CommandType { get; set; }

		// Token: 0x06000114 RID: 276 RVA: 0x0000838C File Offset: 0x0000658C
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridColumnChooserCommand.Close:
				result = new global::Infragistics.Controls.Grids.ColumnChooserCloseCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGridColumnChooserCommand.Open:
				result = new global::Infragistics.Controls.Grids.ColumnChooserOpenCommand();
				break;
			}
			return result;
		}
	}
}
