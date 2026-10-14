using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000297 RID: 663
	public class XamGridCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x0005E5E6 File Offset: 0x0005C7E6
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x0005E5EE File Offset: 0x0005C7EE
		public global::Infragistics.Controls.Grids.XamGridCommand CommandType { get; set; }

		// Token: 0x060017FE RID: 6142 RVA: 0x0005E5F8 File Offset: 0x0005C7F8
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGridCommand.Delete:
				return new global::Infragistics.Controls.Grids.DeleteCommand();
			case global::Infragistics.Controls.Grids.XamGridCommand.SelectAllRows:
				return new global::Infragistics.Controls.Grids.SelectAllRowsCommand();
			case global::Infragistics.Controls.Grids.XamGridCommand.ShowColumnChooser:
				return new global::Infragistics.Controls.Grids.ShowColumnChooserCommand();
			case global::Infragistics.Controls.Grids.XamGridCommand.HideColumnChooser:
				return new global::Infragistics.Controls.Grids.HideColumnChooserCommand();
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
		}
	}
}
