using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000074 RID: 116
	public class CompoundFilteringDialogCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00013343 File Offset: 0x00011543
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0001334B File Offset: 0x0001154B
		public global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommand CommandType { get; set; }

		// Token: 0x0600042B RID: 1067 RVA: 0x00013354 File Offset: 0x00011554
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommand commandType = this.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommand.ShowCompoundFilterDialog)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ShowCompoundFilterDialogCommand();
			}
			return result;
		}
	}
}
