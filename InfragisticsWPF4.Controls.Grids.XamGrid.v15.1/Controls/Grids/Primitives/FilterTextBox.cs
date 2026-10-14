using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200008C RID: 140
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FilterTextBox : global::System.Windows.Controls.TextBox, global::Infragistics.ICommandTarget
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x0001ADD5 File Offset: 0x00018FD5
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001ADDE File Offset: 0x00018FDE
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001ADE7 File Offset: 0x00018FE7
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxCommand;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001ADF2 File Offset: 0x00018FF2
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}
	}
}
