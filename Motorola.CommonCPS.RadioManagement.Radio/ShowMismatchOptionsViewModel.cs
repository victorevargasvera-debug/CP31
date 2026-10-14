using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000036 RID: 54
	public class ShowMismatchOptionsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000234 RID: 564 RVA: 0x000274A4 File Offset: 0x000256A4
		public ShowMismatchOptionsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext showMismatchOptionsContext) : base(eventAggregator, commandHandler)
		{
			this.ShowMismatchOptionsContext = showMismatchOptionsContext;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000274C0 File Offset: 0x000256C0
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00027574 File Offset: 0x00025774
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext ShowMismatchOptionsContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1358102528;
				short num2 = num;
				num = (short)977870792;
				short num3 = num;
				num = (short)1302077384;
				switch (num3 == num)
				{
				}
				num = (short)257884160;
				if (num != 0)
				{
				}
				num = (short)2074411009;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)562561024;
				short num2 = num;
				num = (short)116512199;
				short num3 = num;
				num = (short)716887495;
				switch (num3 == num)
				{
				}
				num = (short)1483735040;
				if (num != 0)
				{
				}
				num = (short)252575745;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400012A RID: 298
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowMismatchOptionsContext a;
	}
}
