using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x0200000A RID: 10
	public class JobRadioDetailsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public JobRadioDetailsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails detail) : base(eventAggregator, commandHandler)
		{
			this.Details = detail;
			this.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(detail.HistoricalJobs);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003CF4 File Offset: 0x00001EF4
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003DA4 File Offset: 0x00001FA4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails Details
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1881710132;
				short num2 = num;
				num = (short)909418036;
				switch (num2 == num)
				{
				}
				num = (short)2055340032;
				short num3 = num;
				num = (short)147324928;
				if (num != 0)
				{
				}
				num = (short)1588920321;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1253015872;
				short num2 = num;
				num = (short)1929806144;
				switch (num2 == num)
				{
				}
				num = (short)1026686976;
				short num3 = num;
				num = (short)1659043840;
				if (num != 0)
				{
				}
				num = (short)1973813249;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003E54 File Offset: 0x00002054
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00003F00 File Offset: 0x00002100
		public global::System.ComponentModel.ICollectionView Items
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1072968313;
				short num2 = num;
				num = (short)1798451833;
				switch (num2 == num)
				{
				}
				num = (short)917176320;
				short num3 = num;
				num = (short)1760952321;
				if (num != 0)
				{
				}
				num = (short)1782513664;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2114518073;
				short num2 = num;
				num = (short)1488845881;
				switch (num2 == num)
				{
				}
				num = (short)1549139968;
				short num3 = num;
				num = (short)458489856;
				if (num != 0)
				{
				}
				num = (short)2069430273;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ICollectionView b;
	}
}
