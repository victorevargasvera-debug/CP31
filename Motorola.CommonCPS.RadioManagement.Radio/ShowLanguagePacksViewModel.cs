using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000037 RID: 55
	public class ShowLanguagePacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00027628 File Offset: 0x00025828
		public ShowLanguagePacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext showLanguagePacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowLanguagePacksContext = showLanguagePacksContext;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00027644 File Offset: 0x00025844
		// (set) Token: 0x06000239 RID: 569 RVA: 0x000276F4 File Offset: 0x000258F4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext ShowLanguagePacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)194969600;
				short num2 = num;
				num = (short)1101042553;
				short num3 = num;
				num = (short)1032295289;
				switch (num3 == num)
				{
				}
				num = (short)79298560;
				if (num != 0)
				{
				}
				num = (short)2062614529;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)498270208;
				short num2 = num;
				num = (short)1927675905;
				if (num != 0)
				{
				}
				num = (short)602723803;
				short num3 = num;
				num = (short)718132699;
				switch (num3 == num)
				{
				}
				num = (short)1961099264;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400012B RID: 299
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext a;
	}
}
