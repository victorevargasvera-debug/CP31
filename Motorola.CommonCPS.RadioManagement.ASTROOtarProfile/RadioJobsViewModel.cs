using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000017 RID: 23
	public class RadioJobsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00008D80 File Offset: 0x00006F80
		public RadioJobsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails detail) : base(eventAggregator, commandHandler)
		{
			this.Details = detail;
			this.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(detail.HistoricalJobs);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00008DB0 File Offset: 0x00006FB0
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00008E60 File Offset: 0x00007060
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails Details
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)62062593;
				if (num != 0)
				{
				}
				num = (short)1509922507;
				short num2 = num;
				num = (short)1594660555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798752768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275513344;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2084696866;
				short num2 = num;
				num = (short)6222626;
				switch (num2 == num)
				{
				}
				num = (short)2145583104;
				short num3 = num;
				num = (short)941162496;
				if (num != 0)
				{
				}
				num = (short)1610547201;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00008FC0 File Offset: 0x000071C0
		public global::System.ComponentModel.ICollectionView Items
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1934108643;
				short num2 = num;
				num = (short)171648995;
				switch (num2 == num)
				{
				}
				num = (short)1603731456;
				short num3 = num;
				num = (short)694878208;
				if (num != 0)
				{
				}
				num = (short)1065353217;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1092304877;
				short num2 = num;
				num = (short)436944877;
				switch (num2 == num)
				{
				}
				num = (short)1969815552;
				short num3 = num;
				num = (short)1958019073;
				if (num != 0)
				{
				}
				num = (short)1624309760;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ICollectionView b;
	}
}
