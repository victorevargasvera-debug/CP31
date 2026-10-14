using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000017 RID: 23
	public class RadioJobsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00007A80 File Offset: 0x00005C80
		public RadioJobsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails detail) : base(eventAggregator, commandHandler)
		{
			this.Details = detail;
			this.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(detail.HistoricalJobs);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007AB0 File Offset: 0x00005CB0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00007B64 File Offset: 0x00005D64
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails Details
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1431764992;
				short num2 = num;
				num = (short)1071450900;
				short num3 = num;
				num = (short)300092180;
				switch (num3 == num)
				{
				}
				num = (short)1052573697;
				if (num != 0)
				{
				}
				num = (short)1331167232;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1868038144;
				short num2 = num;
				num = (short)1864047084;
				short num3 = num;
				num = (short)320870892;
				switch (num3 == num)
				{
				}
				num = (short)756547585;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00007C14 File Offset: 0x00005E14
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00007CC4 File Offset: 0x00005EC4
		public global::System.ComponentModel.ICollectionView Items
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)101908480;
				short num2 = num;
				num = (short)314260589;
				short num3 = num;
				num = (short)306592877;
				switch (num3 == num)
				{
				}
				num = (short)449642496;
				if (num != 0)
				{
				}
				num = (short)1283457025;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)915079168;
				short num2 = num;
				num = (short)8678576;
				short num3 = num;
				num = (short)859532464;
				switch (num3 == num)
				{
				}
				num = (short)292356096;
				if (num != 0)
				{
				}
				num = (short)1570111489;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ICollectionView b;
	}
}
