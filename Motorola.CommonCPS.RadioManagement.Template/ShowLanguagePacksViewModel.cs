using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000010 RID: 16
	public class ShowLanguagePacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0000AD64 File Offset: 0x00008F64
		public ShowLanguagePacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext showTemplateLanguagePacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowTemplateLanguagePacksContext = showTemplateLanguagePacksContext;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000AD80 File Offset: 0x00008F80
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000AE2C File Offset: 0x0000902C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext ShowTemplateLanguagePacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)204224580;
				short num2 = num;
				num = (short)264976452;
				switch (num2 == num)
				{
				}
				num = (short)2133393408;
				short num3 = num;
				num = (short)1892810752;
				if (num != 0)
				{
				}
				num = (short)1319174145;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)696370898;
				short num2 = num;
				num = (short)878102226;
				switch (num2 == num)
				{
				}
				num = (short)1044840448;
				short num3 = num;
				num = (short)1475608577;
				if (num != 0)
				{
				}
				num = (short)134283264;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext a;
	}
}
