using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000039 RID: 57
	public class ShowVAPacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00027A14 File Offset: 0x00025C14
		public ShowVAPacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext showVAPacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowVAPacksContext = showVAPacksContext;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00027A30 File Offset: 0x00025C30
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00027AE0 File Offset: 0x00025CE0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext ShowVAPacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2097152;
				short num2 = num;
				num = (short)1562771457;
				if (num != 0)
				{
				}
				num = (short)500142501;
				short num3 = num;
				num = (short)878940581;
				switch (num3 == num)
				{
				}
				num = (short)959447040;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1302593536;
				short num2 = num;
				num = (short)737869825;
				if (num != 0)
				{
				}
				num = (short)101694194;
				short num3 = num;
				num = (short)470006514;
				switch (num3 == num)
				{
				}
				num = (short)579665920;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400012F RID: 303
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext a;
	}
}
