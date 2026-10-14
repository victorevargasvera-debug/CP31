using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200000F RID: 15
	public class ClearDataViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004D78 File Offset: 0x00002F78
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004E28 File Offset: 0x00003028
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext ClearOldDBContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1739295115;
				short num2 = num;
				num = (short)640780683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498401280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983578113;
				if (num != 0)
				{
				}
				num = (short)1155465216;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1518016890;
				short num2 = num;
				num = (short)113121658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482031104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623378433;
				if (num != 0)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004ED4 File Offset: 0x000030D4
		public ClearDataViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext context) : base(eventAggregator, commandHandler)
		{
			global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel.a a = new global::Motorola.CommonCPS.RadioManagement.Common.ClearDataViewModel.a();
			this.a = localService;
			this.ClearOldDBContext = context;
			this.ClearDataCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			a.a = new global::System.ComponentModel.BackgroundWorker
			{
				WorkerSupportsCancellation = true,
				WorkerReportsProgress = true
			};
			a.a.DoWork += this.a;
			a.a.ProgressChanged += this.a;
			a.a.RunWorkerCompleted += a.b;
			a.a.RunWorkerAsync();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00005044 File Offset: 0x00003244
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ClearDataCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1962290308;
				short num2 = num;
				num = (short)1247816836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1083506688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)426835968;
				if (num != 0)
				{
				}
				num = (short)1627521025;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1101184925;
				short num2 = num;
				num = (short)1560788893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1374355456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1453260801;
				if (num != 0)
				{
				}
				num = (short)1573388288;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000050F4 File Offset: 0x000032F4
		private void b()
		{
			short num = (short)1881928659;
			short num2 = num;
			num = (short)1464333267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1647640576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1044578304;
			if (num != 0)
			{
			}
			num = (short)1288372225;
			if (num != 0)
			{
			}
			this.a.ClearLegacyData();
			this.ClearOldDBContext.DisplayClearDataConfirmBox = false;
			this.ClearOldDBContext.DisplayClearDataProgress = true;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000051C0 File Offset: 0x000033C0
		private void a(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport clearDataProgressReport;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2143027200;
					short num3 = num2;
					num2 = (short)1057424413;
					short num4 = num2;
					num2 = (short)184288285;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1774321664;
						if (num2 != 0)
						{
						}
						this.ClearOldDBContext.UpdateProgress(clearDataProgressReport);
						num2 = (short)977403906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (clearDataProgressReport != null)
					{
						num2 = (short)2133065729;
						if (num2 != 0)
						{
						}
						num2 = (short)1483538432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			clearDataProgressReport = (A_1.UserState as global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport);
			num2 = (short)756482049;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000052E8 File Offset: 0x000034E8
		private void a(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.ComponentModel.BackgroundWorker backgroundWorker;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport clearDataProgressReport;
					if (clearDataProgressReport.CurrentStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.COMPLETED)
					{
						num2 = (short)2100822021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					goto IL_45;
				case 2:
				{
					if (this.d)
					{
						num2 = (short)873136128;
						short num3 = num2;
						num2 = (short)1639251971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport clearDataProgressReport = this.a.GetClearDataProgressReport();
					backgroundWorker.ReportProgress(0, clearDataProgressReport);
					num2 = (short)1570373632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_45;
				case 5:
				{
					num2 = (short)1681980572;
					short num4 = num2;
					num2 = (short)1281162396;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)619577345;
						if (num2 != 0)
						{
						}
						num2 = (short)885129216;
						if (num2 != 0)
						{
						}
						global::System.Threading.Thread.Sleep(this.c * 1000);
						num2 = (short)1899692033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
				IL_45:
				num2 = (short)1147469826;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			backgroundWorker = (A_0 as global::System.ComponentModel.BackgroundWorker);
			num2 = (short)298909700;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005490 File Offset: 0x00003690
		private bool a()
		{
			short num = (short)825819136;
			short num2 = num;
			num = (short)700675361;
			short num3 = num;
			num = (short)535328033;
			switch (num3 == num)
			{
			}
			num = (short)849281024;
			if (num != 0)
			{
			}
			num = (short)334233601;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000553C File Offset: 0x0000373C
		protected override void Close()
		{
			short num = (short)1196490752;
			short num2 = num;
			num = (short)1050880003;
			short num3 = num;
			num = (short)587409411;
			switch (num3 == num)
			{
			}
			num = (short)588840960;
			if (num != 0)
			{
			}
			num = (short)527695873;
			if (num != 0)
			{
			}
			this.d = true;
			base.Close();
		}

		// Token: 0x04000038 RID: 56
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService a;

		// Token: 0x04000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext b;

		// Token: 0x0400003A RID: 58
		private int c = 3;

		// Token: 0x0400003B RID: 59
		private bool d;

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000038 RID: 56 RVA: 0x00005608 File Offset: 0x00003808
			internal void b(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
			{
				short num = (short)11665408;
				short num2 = num;
				num = (short)93457836;
				short num3 = num;
				num = (short)2083458476;
				switch (num3 == num)
				{
				}
				num = (short)1761804289;
				if (num != 0)
				{
				}
				num = (short)1211891712;
				if (num != 0)
				{
				}
				this.a.Dispose();
			}

			// Token: 0x0400003D RID: 61
			public global::System.ComponentModel.BackgroundWorker a;
		}
	}
}
