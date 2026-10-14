using System;
using System.Windows.Input;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000CE RID: 206
	public interface ICommandTarget
	{
		// Token: 0x060007BE RID: 1982
		bool SupportsCommand(global::System.Windows.Input.ICommand command);

		// Token: 0x060007BF RID: 1983
		object GetParameter(global::Infragistics.Controls.CommandSource source);
	}
}
