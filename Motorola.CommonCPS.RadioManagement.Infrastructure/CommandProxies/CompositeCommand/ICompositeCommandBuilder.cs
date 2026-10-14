using System;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand
{
	// Token: 0x02000052 RID: 82
	public interface ICompositeCommandBuilder
	{
		// Token: 0x0600022D RID: 557
		global::Microsoft.Practices.Prism.Commands.DelegateCommand BuildDelegateCommand();

		// Token: 0x0600022E RID: 558
		global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder RegisterCommand(global::System.Windows.Input.ICommand command);

		// Token: 0x0600022F RID: 559
		global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder RegisterCommands(global::System.Collections.Generic.List<global::System.Windows.Input.ICommand> commandList);
	}
}
