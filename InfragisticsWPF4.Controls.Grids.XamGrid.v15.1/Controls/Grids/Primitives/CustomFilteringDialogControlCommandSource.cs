using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000DE RID: 222
	public class CustomFilteringDialogControlCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x0001E3DC File Offset: 0x0001C5DC
		public global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogControlCommand CommandType { get; set; }

		// Token: 0x06000733 RID: 1843 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogControlCommand.Accept:
				result = new global::Infragistics.Controls.Grids.AcceptCustomFilterDialogChangesCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.CustomFilterDialogControlCommand.Close:
				result = new global::Infragistics.Controls.Grids.CloseCustomFilterDialogCommand();
				break;
			}
			return result;
		}
	}
}
