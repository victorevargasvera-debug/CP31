using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000011 RID: 17
	public class ShowCACertificatesPacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000078BC File Offset: 0x00005ABC
		public ShowCACertificatesPacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowCACertificatesPacksContext showCACertificatesPacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowCACertificatesPacksContext = showCACertificatesPacksContext;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000078D8 File Offset: 0x00005AD8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00007988 File Offset: 0x00005B88
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowCACertificatesPacksContext ShowCACertificatesPacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1145941860;
				short num2 = num;
				num = (short)640003940;
				switch (num2 == num)
				{
				}
				num = (short)1520435201;
				if (num != 0)
				{
				}
				num = (short)1426849792;
				short num3 = num;
				num = (short)1744044032;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1493268380;
				short num2 = num;
				num = (short)1358985116;
				switch (num2 == num)
				{
				}
				num = (short)617218048;
				if (num != 0)
				{
				}
				num = (short)927531008;
				short num3 = num;
				num = (short)891092993;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowCACertificatesPacksContext a;
	}
}
