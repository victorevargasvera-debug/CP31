using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000012 RID: 18
	public class DBMigrationViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000059A0 File Offset: 0x00003BA0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00005A50 File Offset: 0x00003C50
		public global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext DBMigrationContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1009451008;
				short num2 = num;
				num = (short)210467830;
				short num3 = num;
				num = (short)1805024246;
				switch (num3 == num)
				{
				}
				num = (short)1765801985;
				if (num != 0)
				{
				}
				num = (short)686948352;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)701693952;
				short num2 = num;
				num = (short)299899634;
				short num3 = num;
				num = (short)1373706994;
				switch (num3 == num)
				{
				}
				num = (short)58916865;
				if (num != 0)
				{
				}
				num = (short)146735104;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005B00 File Offset: 0x00003D00
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand MigrateRadioAndCommonResourceCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1969946624;
				short num2 = num;
				num = (short)875365860;
				short num3 = num;
				num = (short)1212941796;
				switch (num3 == num)
				{
				}
				num = (short)2116157440;
				if (num != 0)
				{
				}
				num = (short)494469121;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)544669696;
				short num2 = num;
				num = (short)3872725;
				short num3 = num;
				num = (short)459937749;
				switch (num3 == num)
				{
				}
				num = (short)763428865;
				if (num != 0)
				{
				}
				num = (short)213712896;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00005C68 File Offset: 0x00003E68
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005D18 File Offset: 0x00003F18
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand MigrationTemplateCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)799014912;
				short num2 = num;
				num = (short)874440093;
				short num3 = num;
				num = (short)2112480669;
				switch (num3 == num)
				{
				}
				num = (short)713097216;
				if (num != 0)
				{
				}
				num = (short)1180827649;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1477312512;
				short num2 = num;
				num = (short)1938017531;
				short num3 = num;
				num = (short)933612795;
				switch (num3 == num)
				{
				}
				num = (short)1433927681;
				if (num != 0)
				{
				}
				num = (short)1407909888;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005DCC File Offset: 0x00003FCC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005E78 File Offset: 0x00004078
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand TurnOffMigrationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1092943872;
				short num2 = num;
				num = (short)349219919;
				short num3 = num;
				num = (short)1585818703;
				switch (num3 == num)
				{
				}
				num = (short)553517057;
				if (num != 0)
				{
				}
				num = (short)1199964160;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1515454464;
				short num2 = num;
				num = (short)463930874;
				short num3 = num;
				num = (short)1535706618;
				switch (num3 == num)
				{
				}
				num = (short)267059200;
				if (num != 0)
				{
				}
				num = (short)761987073;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005FD4 File Offset: 0x000041D4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand NotNowCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1962999808;
				short num2 = num;
				num = (short)1971471336;
				short num3 = num;
				num = (short)898843624;
				switch (num3 == num)
				{
				}
				num = (short)2117140480;
				if (num != 0)
				{
				}
				num = (short)799539201;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2045181952;
				short num2 = num;
				num = (short)725811201;
				if (num != 0)
				{
				}
				num = (short)1453107067;
				short num3 = num;
				num = (short)579315579;
				switch (num3 == num)
				{
				}
				num = (short)1203568640;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006084 File Offset: 0x00004284
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00006134 File Offset: 0x00004334
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ResumeMigrationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)371392512;
				short num2 = num;
				num = (short)173755556;
				short num3 = num;
				num = (short)1586777252;
				switch (num3 == num)
				{
				}
				num = (short)504430592;
				if (num != 0)
				{
				}
				num = (short)537133057;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1164509184;
				short num2 = num;
				num = (short)1864826881;
				if (num != 0)
				{
				}
				num = (short)1646397138;
				short num3 = num;
				num = (short)890570450;
				switch (num3 == num)
				{
				}
				num = (short)2087321600;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000061E4 File Offset: 0x000043E4
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006290 File Offset: 0x00004490
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ClearDataCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)958726144;
				short num2 = num;
				num = (short)452057656;
				short num3 = num;
				num = (short)873978424;
				switch (num3 == num)
				{
				}
				num = (short)241893377;
				if (num != 0)
				{
				}
				num = (short)513867776;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)372572160;
				short num2 = num;
				num = (short)1178796033;
				if (num != 0)
				{
				}
				num = (short)1466708907;
				short num3 = num;
				num = (short)1191588779;
				switch (num3 == num)
				{
				}
				num = (short)2076639232;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006340 File Offset: 0x00004540
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000063EC File Offset: 0x000045EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CompleteCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)501088256;
				short num2 = num;
				num = (short)1790260365;
				short num3 = num;
				num = (short)1892758669;
				switch (num3 == num)
				{
				}
				num = (short)1520173057;
				if (num != 0)
				{
				}
				num = (short)1986592768;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)288489472;
				short num2 = num;
				num = (short)1922975856;
				short num3 = num;
				num = (short)174016624;
				switch (num3 == num)
				{
				}
				num = (short)861405185;
				if (num != 0)
				{
				}
				num = (short)89980928;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000649C File Offset: 0x0000469C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000654C File Offset: 0x0000474C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CloseAndRetryCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1508048896;
				short num2 = num;
				num = (short)1444973618;
				short num3 = num;
				num = (short)453676082;
				switch (num3 == num)
				{
				}
				num = (short)412418048;
				if (num != 0)
				{
				}
				num = (short)1696399361;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)364183552;
				short num2 = num;
				num = (short)1538757525;
				short num3 = num;
				num = (short)1370330005;
				switch (num3 == num)
				{
				}
				num = (short)137560064;
				if (num != 0)
				{
				}
				num = (short)983891969;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000066B0 File Offset: 0x000048B0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AbortMigrationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2114125824;
				short num2 = num;
				num = (short)167977067;
				short num3 = num;
				num = (short)1096425579;
				switch (num3 == num)
				{
				}
				num = (short)1611071488;
				if (num != 0)
				{
				}
				num = (short)90112001;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1960902656;
				short num2 = num;
				num = (short)498139137;
				if (num != 0)
				{
				}
				num = (short)756761233;
				short num3 = num;
				num = (short)150946449;
				switch (num3 == num)
				{
				}
				num = (short)84541440;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006760 File Offset: 0x00004960
		public DBMigrationViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext migrationContext) : base(eventAggregator, commandHandler)
		{
			this.a = localService;
			this.DBMigrationContext = migrationContext;
			this.MigrateRadioAndCommonResourceCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.v), new global::System.Func<bool>(this.k));
			this.MigrationTemplateCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.u), new global::System.Func<bool>(this.j));
			this.TurnOffMigrationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.t), new global::System.Func<bool>(this.i));
			this.NotNowCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.q), new global::System.Func<bool>(this.h));
			this.ResumeMigrationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.p), new global::System.Func<bool>(this.g));
			this.ClearDataCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.o), new global::System.Func<bool>(this.f));
			this.CompleteCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.n), new global::System.Func<bool>(this.e));
			this.CloseAndRetryCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.m), new global::System.Func<bool>(this.d));
			this.AbortMigrationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.l), new global::System.Func<bool>(this.c));
			global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext dbmigrationContext = this.DBMigrationContext;
			dbmigrationContext.MigrationStatusChangedEvent = (global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.MigrateStatusChangedDelegate)global::System.Delegate.Combine(dbmigrationContext.MigrationStatusChangedEvent, new global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext.MigrateStatusChangedDelegate(this.OnStatusChanged));
			this.a.RegisterMigrationProgressEvent(new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate(this.DBMigrationContext.MigrationEventHandler));
			if (migrationContext.MigrationStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.NOT_START)
			{
				global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel.a a = new global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel.a();
				a.b = this;
				a.a = new global::System.ComponentModel.BackgroundWorker();
				a.a.DoWork += this.a;
				a.a.RunWorkerCompleted += a.c;
				a.a.RunWorkerAsync();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006960 File Offset: 0x00004B60
		private void v()
		{
			short num = (short)310181888;
			short num2 = num;
			num = (short)780955577;
			short num3 = num;
			num = (short)1888055225;
			switch (num3 == num)
			{
			}
			num = (short)1560215552;
			if (num != 0)
			{
			}
			num = (short)28311553;
			if (num != 0)
			{
			}
			this.DBMigrationContext.DisplayMigrationConfirmBox = false;
			this.DBMigrationContext.DisplayMigrationProgress = true;
			this.OnStatusChanged(this.DBMigrationContext.MigrationStatus);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006A30 File Offset: 0x00004C30
		private void u()
		{
			short num = (short)1856962560;
			short num2 = num;
			num = (short)1187283680;
			short num3 = num;
			num = (short)873759456;
			switch (num3 == num)
			{
			}
			num = (short)1847721985;
			if (num != 0)
			{
			}
			num = (short)1895890944;
			if (num != 0)
			{
			}
			base.CommandHandler.MigrateTemplateCommand.Execute(new object[]
			{
				this.DBMigrationContext
			});
			this.DBMigrationContext.DisplayMigrationProgress = true;
			this.DBMigrationContext.DisplayTemplateSelection = false;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006B14 File Offset: 0x00004D14
		private void t()
		{
			short num = (short)1124073474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)2140823283;
					short num3 = num;
					num = (short)1875468019;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
					{
						num = (short)678690817;
						if (num != 0)
						{
						}
						num = (short)1300627456;
						short num4 = num;
						num = (short)1233715200;
						if (num != 0)
						{
						}
						this.a.TurnOffMigration(this.DBMigrationContext.MigrationInfo.Version);
						base.CloseCommand.Execute();
						num = (short)1619263488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				goto IL_30;
				IL_49:
				num = (short)1668808705;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_CONFIRM_NEVER, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration))
				{
					goto IL_49;
				}
				break;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006C60 File Offset: 0x00004E60
		private void s()
		{
			short num = (short)906690562;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)846746523;
					short num3 = num;
					num = (short)151147419;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
					{
						num = (short)1697513472;
						if (num != 0)
						{
						}
						num = (short)421330944;
						short num4 = num;
						num = (short)13631489;
						if (num != 0)
						{
						}
						this.DBMigrationContext.MigrationStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete;
						num = (short)153681920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				goto IL_30;
				IL_40:
				num = (short)1012531201;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (this.a.ScheduleMigrationJob() == 0)
				{
					goto IL_40;
				}
				break;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006D88 File Offset: 0x00004F88
		private void r()
		{
			short num = (short)1929904129;
			if (num != 0)
			{
			}
			num = (short)854523904;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> enumerator = this.DBMigrationContext.JobContainers.GetEnumerator();
				try
				{
					num = (short)845152261;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService = this.a;
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
							global::System.Guid? id = migrationJobContainer.ID;
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainers = localService.GetJobContainers(id.Value);
							num = (short)1844707335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_230;
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainers;
							migrationJobContainer.SetJobContainer(jobContainers);
							num = (short)1831731201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							int? totalCount;
							int? itemsCompleted;
							if (totalCount.GetValueOrDefault() > itemsCompleted.GetValueOrDefault() & (totalCount != null & itemsCompleted != null))
							{
								num = (short)735248394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1074135049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer = enumerator.Current;
							int? totalCount = migrationJobContainer.TotalCount;
							int? itemsCompleted = migrationJobContainer.ItemsCompleted;
							num = (short)910098436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainers;
							if (jobContainers != null)
							{
								num = (short)1203044355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Guid? id;
							if (id != null)
							{
								num = (short)1679097856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)68288514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer;
							global::System.Guid? id = migrationJobContainer.ID;
							num = (short)1006895112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_ED:
						num = (short)1050345478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AA:
						goto IL_ED;
					}
					IL_230:;
				}
				finally
				{
					num = (short)595132417;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_29F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_268;
							}
							continue;
						case 2:
							IL_280:
							enumerator.Dispose();
							num = (short)104988672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_268:
						if (enumerator != null)
						{
							num = (short)853737474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_29F:
						num = (short)1422750343;
						short num3 = num;
						num = (short)1915712135;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_280;
						default:
							goto IL_2D4;
						}
					}
					IL_2D4:
					num = (short)1482424320;
					if (num != 0)
					{
					}
				}
				num = (short)1390477312;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000070C4 File Offset: 0x000052C4
		private void q()
		{
			short num = (short)1113837364;
			short num2 = num;
			num = (short)78237492;
			switch (num2 == num)
			{
			}
			num = (short)270467072;
			if (num != 0)
			{
			}
			num = (short)494731265;
			if (num != 0)
			{
			}
			num = (short)1914109952;
			short num3 = num;
			this.DBMigrationContext.CanShowRMC = false;
			base.CloseCommand.Execute();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007184 File Offset: 0x00005384
		private void p()
		{
			short num = (short)1274588996;
			short num2 = num;
			num = (short)837660484;
			switch (num2 == num)
			{
			}
			num = (short)1174863872;
			if (num != 0)
			{
			}
			num = (short)685309953;
			if (num != 0)
			{
			}
			num = (short)1961951232;
			short num3 = num;
			this.DBMigrationContext.DisplayResumeDialog = false;
			this.DBMigrationContext.DisplayMigrationProgress = true;
			this.OnStatusChanged(this.DBMigrationContext.MigrationStatus);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007258 File Offset: 0x00005458
		private void o()
		{
			short num = (short)864842711;
			short num2 = num;
			num = (short)2146268119;
			switch (num2 == num)
			{
			}
			num = (short)593297409;
			if (num != 0)
			{
			}
			num = (short)1591017472;
			if (num != 0)
			{
			}
			num = (short)646381568;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext context = new global::Motorola.CommonCPS.RadioManagement.UIModels.ClearOldDBContext(this.a.GetClearDataProgressReport());
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowClearDataDialog(context);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000731C File Offset: 0x0000551C
		private void n()
		{
			short num = (short)935049889;
			short num2 = num;
			num = (short)1042397857;
			switch (num2 == num)
			{
			}
			num = (short)25427969;
			if (num != 0)
			{
			}
			num = (short)1727791104;
			if (num != 0)
			{
			}
			num = (short)978845696;
			short num3 = num;
			this.a(true);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000073D0 File Offset: 0x000055D0
		private void m()
		{
			short num = (short)2044458831;
			short num2 = num;
			num = (short)599390031;
			switch (num2 == num)
			{
			}
			num = (short)1214840833;
			if (num != 0)
			{
			}
			num = (short)660078592;
			if (num != 0)
			{
			}
			num = (short)2126839808;
			short num3 = num;
			this.a(false);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007480 File Offset: 0x00005680
		private void l()
		{
			short num = (short)1349779457;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					IL_85:
					this.DBMigrationContext.MigrationStatus = this.a.AbortMigration();
					this.a();
					num = (short)711589888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				num = (short)173998080;
				short num3 = num;
				if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_ABORT, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration))
				{
					num = (short)1394933762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BC:
				num = (short)35257112;
				short num4 = num;
				num = (short)2124938008;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_85;
				default:
					goto IL_F0;
				}
			}
			IL_F0:
			num = (short)1510801409;
			if (num != 0)
			{
			}
			num = (short)1288699904;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000075BC File Offset: 0x000057BC
		private bool k()
		{
			short num = (short)1438845526;
			short num2 = num;
			num = (short)1873807958;
			switch (num2 == num)
			{
			}
			num = (short)1735524352;
			if (num != 0)
			{
			}
			num = (short)353566721;
			if (num != 0)
			{
			}
			num = (short)1300103168;
			short num3 = num;
			return base.CommandHandler.QueryMigrationStatusCommand.CanExecute(new object[]
			{
				this.DBMigrationContext
			});
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007684 File Offset: 0x00005884
		private bool j()
		{
			short num = (short)276181384;
			short num2 = num;
			num = (short)518599048;
			switch (num2 == num)
			{
			}
			num = (short)1240727553;
			if (num != 0)
			{
			}
			num = (short)1703739392;
			if (num != 0)
			{
			}
			num = (short)1468661760;
			short num3 = num;
			return true;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007730 File Offset: 0x00005930
		private bool i()
		{
			short num = (short)950580905;
			short num2 = num;
			num = (short)621655721;
			switch (num2 == num)
			{
			}
			num = (short)115343361;
			if (num != 0)
			{
			}
			num = (short)345243648;
			if (num != 0)
			{
			}
			num = (short)2074738688;
			short num3 = num;
			return true;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000077D8 File Offset: 0x000059D8
		private bool h()
		{
			short num = (short)1497893589;
			short num2 = num;
			num = (short)770312917;
			switch (num2 == num)
			{
			}
			num = (short)310771713;
			if (num != 0)
			{
			}
			num = (short)1352138752;
			if (num != 0)
			{
			}
			num = (short)1934950400;
			short num3 = num;
			return true;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007880 File Offset: 0x00005A80
		private bool g()
		{
			short num = (short)1131932948;
			short num2 = num;
			num = (short)60878100;
			switch (num2 == num)
			{
			}
			num = (short)15269888;
			if (num != 0)
			{
			}
			num = (short)337444865;
			if (num != 0)
			{
			}
			num = (short)1952645120;
			short num3 = num;
			return true;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000792C File Offset: 0x00005B2C
		private bool f()
		{
			short num = (short)1026555560;
			short num2 = num;
			num = (short)1265696424;
			switch (num2 == num)
			{
			}
			num = (short)266338305;
			if (num != 0)
			{
			}
			num = (short)1574174720;
			if (num != 0)
			{
			}
			num = (short)10092544;
			short num3 = num;
			return true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000079D8 File Offset: 0x00005BD8
		private bool e()
		{
			short num = (short)1067713028;
			short num2 = num;
			num = (short)951714308;
			switch (num2 == num)
			{
			}
			num = (short)534118400;
			if (num != 0)
			{
			}
			num = (short)1902575617;
			if (num != 0)
			{
			}
			num = (short)1650655232;
			short num3 = num;
			return true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007A80 File Offset: 0x00005C80
		private bool d()
		{
			short num = (short)1491877650;
			short num2 = num;
			num = (short)1404976914;
			switch (num2 == num)
			{
			}
			num = (short)92733441;
			if (num != 0)
			{
			}
			num = (short)666632192;
			if (num != 0)
			{
			}
			num = (short)62062592;
			short num3 = num;
			return true;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007B28 File Offset: 0x00005D28
		private bool c()
		{
			short num = (short)996797071;
			short num2 = num;
			num = (short)835185295;
			switch (num2 == num)
			{
			}
			num = (short)1276510208;
			if (num != 0)
			{
			}
			num = (short)1232338945;
			if (num != 0)
			{
			}
			num = (short)2068316160;
			short num3 = num;
			return true;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007BD4 File Offset: 0x00005DD4
		public void OnStatusChanged(global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus status)
		{
			switch (status)
			{
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.NOT_START:
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.STARTED:
				break;
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.RADIO_AND_COMMON_COMPLETE:
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.TEMPLATE_SELECTION_SAVED:
			{
				short num = (short)171114496;
				short num2 = num;
				this.b();
				return;
			}
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.TEMPLATE_COMPLETE:
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.SCHEDULE_IN_PROGRESS:
			{
				short num = (short)1712447318;
				short num3 = num;
				num = (short)62906198;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1764687873;
					if (num != 0)
					{
					}
					num = (short)1813381120;
					if (num != 0)
					{
					}
					this.s();
					return;
				}
				break;
			}
			case global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete:
				this.r();
				return;
			default:
				return;
			}
			base.CommandHandler.MigrateRadioAndCommonResourceCommand.Execute(new object[]
			{
				this.DBMigrationContext
			});
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007CD8 File Offset: 0x00005ED8
		private void b()
		{
			short num = (short)693174272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> list;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)500563973;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo;
									this.DBMigrationContext.OrphanTemplates.Add(dbmigrationTemplateBasicInfo);
									this.DBMigrationContext.RegisterPropertyChanged(dbmigrationTemplateBasicInfo);
									num = (short)1689845766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)410976258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4D3;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1928003585;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo migrationTemplateInfo = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo
									{
										TemplateUuid = migrationTemplateInfo.TemplateUuid,
										ID = new global::System.Guid?(migrationTemplateInfo.TemplateUuid),
										ArchiveFileUuid = migrationTemplateInfo.ArchiveFileUuid,
										TemplateName = migrationTemplateInfo.TemplateName,
										IsTemplateExist = migrationTemplateInfo.IsTemplateExist
									};
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo>.Enumerator enumerator2 = migrationTemplateInfo.ReferencedRadioList.GetEnumerator();
									num = (short)1409351687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo;
									if (dbmigrationTemplateBasicInfo.ReferencedRadioList.Count == 0)
									{
										num = (short)885260288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1F8;
									}
									continue;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo dbmigrationTemplateBasicInfo;
									try
									{
										num = (short)2010185730;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_35B;
											case 1:
											{
												num = (short)1478324876;
												short num3 = num;
												num = (short)1028551308;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
												{
													num = (short)832700416;
													if (num != 0)
													{
													}
													global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo>.Enumerator enumerator2;
													if (enumerator2.MoveNext())
													{
														global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo radioBaseInfo = enumerator2.Current;
														global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo item = new global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo
														{
															RadioUuid = radioBaseInfo.RadioUuid,
															ID = new global::System.Guid?(radioBaseInfo.RadioUuid),
															DeviceID = radioBaseInfo.DeviceID,
															SerialNumber = radioBaseInfo.SerialNumber,
															HasPBA = radioBaseInfo.HasPBA
														};
														dbmigrationTemplateBasicInfo.ReferencedRadioList.Add(item);
														num = (short)983957507;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												}
												num = (short)1596588036;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_238;
												}
												continue;
											case 4:
												num = (short)1400242176;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2B7:
											num = (short)429654017;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_238:
											goto IL_2B7;
										}
										IL_35B:
										goto IL_464;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									break;
									IL_464:
									this.DBMigrationContext.AllTemplates.Add(dbmigrationTemplateBasicInfo);
									num = (short)1659568132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_36E:
								num = (short)953417731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F8:
								goto IL_36E;
							}
							IL_4D3:
							goto IL_90;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_4E6;
						IL_90:
						num = (short)707198980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (list.Count == 0)
						{
							num = (short)1413021704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E6;
					case 2:
						goto IL_1AB;
					case 3:
					{
						num = (short)219938816;
						short num4 = num;
						if (this.DBMigrationContext.OrphanTemplates.Count == 0)
						{
							num = (short)1352466434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50A;
					}
					case 4:
						if (this.DBMigrationContext.MigrationStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.TEMPLATE_SELECTION_SAVED)
						{
							num = (short)1433010183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 5:
						num = (short)890830849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (list != null)
						{
							num = (short)1117650949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						num = (short)697171969;
						if (num != 0)
						{
						}
						num = (short)260898819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_138;
					}
					goto IL_53;
					IL_4E6:
					enumerator = list.GetEnumerator();
					num = (short)1427505152;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_F5:
				this.u();
				return;
				IL_138:
				return;
				IL_1AB:
				goto IL_F5;
				IL_50A:
				this.DBMigrationContext.DisplayMigrationProgress = false;
				this.DBMigrationContext.DisplayTemplateSelection = true;
				return;
				IL_53:
				list = this.a.ListMigrationTemplateList();
				num = (short)745078790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000823C File Offset: 0x0000643C
		private void a(bool A_0)
		{
			short num = (short)1057883435;
			short num2 = num;
			num = (short)463340843;
			switch (num2 == num)
			{
			}
			num = (short)288096257;
			if (num != 0)
			{
			}
			num = (short)59834368;
			if (num != 0)
			{
			}
			num = (short)1919156224;
			short num3 = num;
			this.DBMigrationContext.CanShowRMC = A_0;
			this.Close();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000082F4 File Offset: 0x000064F4
		protected override void Close()
		{
			short num = (short)383705615;
			short num2 = num;
			num = (short)2017255951;
			switch (num2 == num)
			{
			}
			num = (short)1592131585;
			if (num != 0)
			{
			}
			num = (short)190578688;
			if (num != 0)
			{
			}
			num = (short)348258304;
			short num3 = num;
			this.a.UnRegisterMigrationProgressEvent(new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate(this.DBMigrationContext.MigrationEventHandler));
			this.a();
			base.Close();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000083C8 File Offset: 0x000065C8
		private void a()
		{
			short num = (short)443993301;
			short num2 = num;
			num = (short)1125305557;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)119341056;
				short num3 = num;
				break;
			}
			}
			num = (short)457965568;
			if (num != 0)
			{
			}
			num = (short)607977473;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer> jobContainers = this.DBMigrationContext.JobContainers;
			global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer, bool> predicate = new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer, bool>(global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel.<>c.<>9.a);
			for (;;)
			{
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer>.Enumerator enumerator = jobContainers.Where(predicate).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer>().GetEnumerator())
				{
					num = (short)1723269122;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_196;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)472121348;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.MigrationJobContainer migrationJobContainer = enumerator.Current;
							migrationJobContainer.RawData.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING;
							base.CommandHandler.CancelDBMigrationBacthOpCommand.Execute(new object[]
							{
								migrationJobContainer.ID
							});
							num = (short)880541699;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 4:
							num = (short)2084175872;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_143:
						num = (short)929628161;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_143;
					}
					IL_196:
					break;
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000085BC File Offset: 0x000067BC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)937633202;
				short num2 = num;
				num = (short)966796722;
				switch (num2 == num)
				{
				}
				num = (short)1496645632;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel.b b = new global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel.b();
				b.b = this;
				b.a = this.a.CalculateMigrationTimeAndSize();
				global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(b.c), global::System.Array.Empty<object>());
			}
			catch
			{
			}
			num = (short)623837184;
			short num3 = num;
			num = (short)912457729;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400004B RID: 75
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService a;

		// Token: 0x0400004C RID: 76
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext b;

		// Token: 0x0400004D RID: 77
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x0400004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x0400004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;

		// Token: 0x04000050 RID: 80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand g;

		// Token: 0x04000052 RID: 82
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand h;

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand i;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand j;

		// Token: 0x04000055 RID: 85
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand k;

		// Token: 0x02000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600006C RID: 108 RVA: 0x000086CC File Offset: 0x000068CC
			internal void c(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
			{
				short num = (short)659875172;
				short num2 = num;
				num = (short)2069816676;
				switch (num2 == num)
				{
				}
				num = (short)1302396929;
				if (num != 0)
				{
				}
				num = (short)1529217024;
				if (num != 0)
				{
				}
				num = (short)2022572032;
				short num3 = num;
				this.a.Dispose();
			}

			// Token: 0x04000056 RID: 86
			public global::System.ComponentModel.BackgroundWorker a;

			// Token: 0x04000057 RID: 87
			public global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel b;
		}

		// Token: 0x02000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600006E RID: 110 RVA: 0x00008790 File Offset: 0x00006990
			internal void c()
			{
				int a_ = 4;
				while (this.a == null)
				{
					short num = (short)1859502120;
					short num2 = num;
					num = (short)1183563816;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)579403777;
						if (num != 0)
						{
						}
						num = (short)1093402624;
						short num3 = num;
						num = (short)534511616;
						if (num != 0)
						{
						}
						this.b.DBMigrationContext.FreeDiskSpaceRequiresNoHistroyPBA = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Unknown;
						this.b.DBMigrationContext.FreeDiskSpaceRequiresWithHistroyPBA = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Unknown;
						this.b.DBMigrationContext.EstimatedTimeToCompleteNoHistroyPBA = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Unknown;
						this.b.DBMigrationContext.EstimatedTimeToCompleteWithHistroyPBA = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Unknown;
						return;
					}
					}
				}
				this.b.DBMigrationContext.FreeDiskSpaceRequiresNoHistroyPBA = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("귕ꟙﳛꗝ퇟鿡", a_), this.a.FreeDiskRequiresWithoutHistroyPBA.ToString(global::System.Globalization.CultureInfo.CurrentCulture), global::Motorola.CommonCPS.ResourceRepository.Resources.General_SizeOfMB);
				this.b.DBMigrationContext.FreeDiskSpaceRequiresWithHistroyPBA = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("귕ꟙﳛꗝ퇟鿡", a_), this.a.FreeDiskRequiresWithHistroyPBA.ToString(global::System.Globalization.CultureInfo.CurrentCulture), global::Motorola.CommonCPS.ResourceRepository.Resources.General_SizeOfMB);
				this.b.DBMigrationContext.EstimatedTimeToCompleteNoHistroyPBA = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("귕ꟙﳛꗝ퇟鿡쓣鷥\udae7韩쳫闭쏯迱", a_), new object[]
				{
					this.a.TotelSpentTimeJobHistoryWithoutPBA.Hours,
					global::Motorola.CommonCPS.ResourceRepository.Resources.General_Hour,
					this.a.TotelSpentTimeJobHistoryWithoutPBA.Minutes,
					global::Motorola.CommonCPS.ResourceRepository.Resources.General_Minute
				});
				this.b.DBMigrationContext.EstimatedTimeToCompleteWithHistroyPBA = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("귕ꟙﳛꗝ퇟鿡쓣鷥\udae7韩쳫闭쏯迱", a_), new object[]
				{
					this.a.TotelSpentTime.Hours,
					global::Motorola.CommonCPS.ResourceRepository.Resources.General_Hour,
					this.a.TotelSpentTime.Minutes,
					global::Motorola.CommonCPS.ResourceRepository.Resources.General_Minute
				});
			}

			// Token: 0x04000058 RID: 88
			public global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData a;

			// Token: 0x04000059 RID: 89
			public global::Motorola.CommonCPS.RadioManagement.Common.DBMigrationViewModel b;
		}
	}
}
