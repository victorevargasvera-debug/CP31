using System;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000005 RID: 5
	public class AboutViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002C48 File Offset: 0x00000E48
		public AboutViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler) : base(eventAggregator, commandHandler)
		{
		}
	}
}
