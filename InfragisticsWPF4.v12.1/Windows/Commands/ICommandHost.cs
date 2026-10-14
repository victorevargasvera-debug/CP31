using System;
using System.ComponentModel;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200010B RID: 267
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public interface ICommandHost
	{
		// Token: 0x06000A19 RID: 2585
		bool Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo);

		// Token: 0x06000A1A RID: 2586
		long GetCurrentState(long statesToQuery);

		// Token: 0x06000A1B RID: 2587
		bool CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo);
	}
}
