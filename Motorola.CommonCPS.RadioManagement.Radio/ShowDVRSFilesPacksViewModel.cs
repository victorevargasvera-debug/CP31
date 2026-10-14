using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000013 RID: 19
	public class ShowDVRSFilesPacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public ShowDVRSFilesPacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowDVRSFilePacksContext showDVRSFilesPacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowDVRSFilePacksContext = showDVRSFilesPacksContext;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00007CC4 File Offset: 0x00005EC4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00007D74 File Offset: 0x00005F74
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowDVRSFilePacksContext ShowDVRSFilePacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1149908711;
				short num2 = num;
				num = (short)800077543;
				switch (num2 == num)
				{
				}
				num = (short)740950016;
				if (num != 0)
				{
				}
				num = (short)936247296;
				short num3 = num;
				num = (short)1648754689;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)120297429;
				short num2 = num;
				num = (short)1607571413;
				switch (num2 == num)
				{
				}
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)952762368;
				short num3 = num;
				num = (short)1118371840;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowDVRSFilePacksContext a;
	}
}
