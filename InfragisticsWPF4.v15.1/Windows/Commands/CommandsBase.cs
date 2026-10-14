using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Infragistics.Windows.Commands
{
	// Token: 0x0200012A RID: 298
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class CommandsBase
	{
		// Token: 0x06000B1B RID: 2843
		public abstract bool ProcessKeyboardInput(global::System.Windows.Input.KeyEventArgs e, global::Infragistics.Windows.Commands.ICommandHost commandHost);
	}
}
