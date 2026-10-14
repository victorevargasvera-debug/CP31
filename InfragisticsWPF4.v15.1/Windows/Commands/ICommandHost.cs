using System;
using System.ComponentModel;

namespace Infragistics.Windows.Commands
{
	// Token: 0x02000129 RID: 297
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public interface ICommandHost
	{
		// Token: 0x06000B18 RID: 2840
		bool Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo);

		// Token: 0x06000B19 RID: 2841
		long GetCurrentState(long statesToQuery);

		// Token: 0x06000B1A RID: 2842
		bool CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo);
	}
}
