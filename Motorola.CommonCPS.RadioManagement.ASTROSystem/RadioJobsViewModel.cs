using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200000C RID: 12
	public class RadioJobsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003354 File Offset: 0x00001554
		public RadioJobsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails detail) : base(eventAggregator, commandHandler)
		{
			this.Details = detail;
			this.Items = global::System.Windows.Data.CollectionViewSource.GetDefaultView(detail.HistoricalJobs);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003384 File Offset: 0x00001584
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003434 File Offset: 0x00001634
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails Details
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)710538630;
				short num2 = num;
				num = (short)1176958342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472842240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643053057;
				if (num != 0)
				{
				}
				num = (short)1941504000;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)676367895;
				short num2 = num;
				num = (short)963743255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916338176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220149248;
				if (num != 0)
				{
				}
				num = (short)588513281;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000034E0 File Offset: 0x000016E0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003594 File Offset: 0x00001794
		public global::System.ComponentModel.ICollectionView Items
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1962273265;
				short num2 = num;
				num = (short)411101681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1380909056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)667353089;
				if (num != 0)
				{
				}
				num = (short)662306816;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2147112723;
				short num2 = num;
				num = (short)1059411731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1341915136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265945089;
				if (num != 0)
				{
				}
				num = (short)966328320;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ICollectionView b;
	}
}
