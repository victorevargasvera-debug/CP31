using System;
using System.Windows.Input;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000B3 RID: 179
	public interface ICommandTarget
	{
		// Token: 0x060006D4 RID: 1748
		bool SupportsCommand(global::System.Windows.Input.ICommand command);

		// Token: 0x060006D5 RID: 1749
		object GetParameter(global::Infragistics.Controls.CommandSource source);
	}
}
