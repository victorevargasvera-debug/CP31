using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Converters;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000023 RID: 35
	public abstract class ScheduleJobBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0001905C File Offset: 0x0001725C
		public ScheduleJobBatchOp(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			this.a = context;
			this.supportedConnections = 0;
			base.SelectedItems = context.Radios.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			this.StartDate = context.UtcStartDate;
			this.EndDate = context.UtcEndDate;
			this.Transport = context.ConnectionMethod;
			this.ReadWriteJobName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(context.Name);
			this.JobType = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterUiJobTypeToServerJobType(context.Type, context.TypeWriteNoSwitchover);
			this.ReadyJobtOption = global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterUIReadyJobtOptionToServerReadyJobtOption(context.TypeReadGenerateConfigurationOrTemplate, context.TypeReadGenerateConfigurationOrTemplateApplyToRadio);
			this.IsWriteProtected = context.IsWriteProtected;
			if (context is global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext)
			{
				this.b = true;
				this.c = (context as global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext).RestoreJob;
			}
			this.UEFileContent = context.UEFileContent;
			this.DefermentNumber = context.UserDefersAllowed;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0001913C File Offset: 0x0001733C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1133853913;
				short num2 = num;
				num = (short)1291599065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2070151168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973537281;
				if (num != 0)
				{
				}
				num = (short)272302080;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ScheduleJob;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000191E4 File Offset: 0x000173E4
		public override string JobName
		{
			get
			{
				short num = (short)670171137;
				if (num != 0)
				{
				}
				num = (short)1779957760;
				short num2 = num;
				num = (short)523357043;
				short num3 = num;
				num = (short)1717291891;
				switch (num3 == num)
				{
				}
				num = (short)1473970176;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ScheduleJobName;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00019290 File Offset: 0x00017490
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00019340 File Offset: 0x00017540
		public global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference Transport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1923415004;
				short num2 = num;
				num = (short)2024799196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574109184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847197697;
				if (num != 0)
				{
				}
				num = (short)53215232;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)304702723;
				short num2 = num;
				num = (short)1124689155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597229568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1664155649;
				if (num != 0)
				{
				}
				num = (short)1435893760;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000193F4 File Offset: 0x000175F4
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000194A0 File Offset: 0x000176A0
		public global::System.DateTime? StartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1458728563;
				short num2 = num;
				num = (short)1059679859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141361152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299120129;
				if (num != 0)
				{
				}
				num = (short)423624704;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1477441857;
				short num2 = num;
				num = (short)591919425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002780160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023541248;
				if (num != 0)
				{
				}
				num = (short)237961217;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00019554 File Offset: 0x00017754
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00019604 File Offset: 0x00017804
		public global::System.DateTime? EndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)131596289;
				if (num != 0)
				{
				}
				num = (short)1157890048;
				short num2 = num;
				num = (short)1156301565;
				short num3 = num;
				num = (short)337298173;
				switch (num3 == num)
				{
				}
				num = (short)1253834752;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1387649379;
				short num2 = num;
				num = (short)117692771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488636416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)249954304;
				if (num != 0)
				{
				}
				num = (short)559022081;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000196B4 File Offset: 0x000178B4
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00019768 File Offset: 0x00017968
		public string ReadWriteJobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)11968337;
				short num2 = num;
				num = (short)1331994449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1405747200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963510272;
				if (num != 0)
				{
				}
				num = (short)2049310721;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1817203899;
				short num2 = num;
				num = (short)854676667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)394854400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742995456;
				if (num != 0)
				{
				}
				num = (short)1700790273;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00019818 File Offset: 0x00017A18
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000198C8 File Offset: 0x00017AC8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)658767873;
				if (num != 0)
				{
				}
				num = (short)112656384;
				short num2 = num;
				num = (short)65810307;
				short num3 = num;
				num = (short)1855008643;
				switch (num3 == num)
				{
				}
				num = (short)218759168;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)532402944;
				short num2 = num;
				num = (short)102028032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783810560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847249408;
				if (num != 0)
				{
				}
				num = (short)1566441473;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00019978 File Offset: 0x00017B78
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00019A28 File Offset: 0x00017C28
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption ReadyJobtOption
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)584798858;
				short num2 = num;
				num = (short)1538544266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)344260608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276234241;
				if (num != 0)
				{
				}
				num = (short)1058930688;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)644455373;
				short num2 = num;
				num = (short)2063965133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970864128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771765761;
				if (num != 0)
				{
				}
				num = (short)1675296768;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00019ADC File Offset: 0x00017CDC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00019B88 File Offset: 0x00017D88
		public bool IsWriteProtected
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)284181424;
				short num2 = num;
				num = (short)1077167024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927727616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276758529;
				if (num != 0)
				{
				}
				num = (short)874512384;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)69695663;
				short num2 = num;
				num = (short)1006925999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066205184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)490930177;
				if (num != 0)
				{
				}
				num = (short)1758461952;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00019C38 File Offset: 0x00017E38
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00019CE8 File Offset: 0x00017EE8
		public bool IsRRPDMR3
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1141102557;
				short num2 = num;
				num = (short)1608570845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1294598144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066074113;
				if (num != 0)
				{
				}
				num = (short)1869086720;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)336758844;
				short num2 = num;
				num = (short)2040105020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72744960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642383873;
				if (num != 0)
				{
				}
				num = (short)1420427264;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00019D9C File Offset: 0x00017F9C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00019E48 File Offset: 0x00018048
		public byte[] UEFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1640240542;
				short num2 = num;
				num = (short)798758302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578500096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364328449;
				if (num != 0)
				{
				}
				num = (short)1352925184;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)102269596;
				short num2 = num;
				num = (short)1501332124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851312640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457048065;
				if (num != 0)
				{
				}
				num = (short)1717501952;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00019EFC File Offset: 0x000180FC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00019FAC File Offset: 0x000181AC
		private int DefermentNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)20217052;
				short num2 = num;
				num = (short)1200782556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155072000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694892033;
				if (num != 0)
				{
				}
				num = (short)197918720;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1912321520;
				short num2 = num;
				num = (short)1849144816;
				switch (num2 == num)
				{
				}
				num = (short)1723006976;
				if (num != 0)
				{
				}
				num = (short)1313079297;
				if (num != 0)
				{
				}
				num = (short)1972830208;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001A05C File Offset: 0x0001825C
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer DoWork()
		{
			short num = (short)649727447;
			short num2 = num;
			num = (short)1908149719;
			switch (num2 == num)
			{
			}
			num = (short)1766129664;
			if (num != 0)
			{
			}
			num = (short)1279000577;
			if (num != 0)
			{
			}
			num = (short)1755840512;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer result = base.AddBatchJobContainer();
			this.OnDoWork(null);
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001A114 File Offset: 0x00018314
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 6;
			short num = (short)1937375232;
			switch (num)
			{
			default:
			{
				num = (short)610861057;
				if (num != 0)
				{
				}
				int num2 = 0;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService radioDetailService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioDetailService;
				global::System.Guid? readWriteJobContainerUuid = null;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊껌꟎듐럒ꃔ믖볘ﯚ럜냞菠쏢蟤苦軨苪菬쇮", a_), null, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Info);
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)815988743;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
						switch (num3)
						{
						case 0:
							if (base.CancellationPending)
							{
								num = (short)574881796;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2085552129;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
							if (measurer == null)
							{
								num = (short)696582153;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							automaticPerformanceMeasurer = measurer.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊껌꟎듐럒ꃔ믖볘ﯚ韜냞菠", a_), this.a.Type.ToString()).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊꣌뷎룐닒맔韘껚냜뷞蓠釢", a_), radioBase.SerialNumber));
							goto IL_215;
						}
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1459945475;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)2032271360;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_668;
						case 4:
							num = (short)79495173;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_24A;
						case 6:
							goto IL_680;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_FD;
							}
							continue;
						case 8:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_290;
								}
								global::Motorola.CommonCPS.Server.EntityModel.JobRequest jobRq;
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet;
								global::Motorola.CommonCPS.Server.EntityModel.Radio a_2;
								for (;;)
								{
									IL_259:
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
									global::Motorola.CommonCPS.Server.EntityModel.Job job;
									global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
									switch (num3)
									{
									case 0:
										goto IL_5D3;
									case 1:
										automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊껌꟎듐럒ꃔ믖볘ﯚ韜냞菠쏢諤触짨룪裬鷮蟰髲雴鋶", a_));
										goto IL_370;
									case 2:
										if (automaticPerformanceMeasurer3 == null)
										{
											num = (short)1950875654;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1420034049;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										automaticPerformanceMeasurer2 = null;
										goto IL_370;
									case 4:
										try
										{
											job = radioService.ScheduleJob(base.JobContainerGuid, readWriteJobContainerUuid, jobRq, entitySet);
											goto IL_4C0;
										}
										finally
										{
											num = (short)629538816;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_576;
													}
													continue;
												case 1:
													goto IL_5AE;
												case 2:
													automaticPerformanceMeasurer4.Dispose();
													num = (short)984088577;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_576:
												if (automaticPerformanceMeasurer4 == null)
												{
													break;
												}
												num = (short)1760165890;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_5AE:;
										}
										goto IL_5B1;
									case 5:
										if (job != null)
										{
											num = (short)1921122315;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5D3;
									case 6:
										num = (short)1713897475;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										num = (short)1582497797;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_5F6;
									case 9:
										try
										{
											switch (0)
											{
											case 0:
												goto IL_3B5;
											}
											for (;;)
											{
												IL_39A:
												switch (num3)
												{
												case 0:
													goto IL_466;
												case 1:
													jobRq = this.a(automaticPerformanceMeasurer3, radioDetailService, a_2, radioService, out entitySet);
													num = (short)1984888836;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													if (this.b)
													{
														num = (short)1471283201;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													jobRq = this.a(radioBase, automaticPerformanceMeasurer3, a_2, radioService, out entitySet);
													num = (short)1198325763;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_44C;
												case 4:
													goto IL_44C;
												}
												goto IL_3B5;
												IL_44C:
												num = (short)729088000;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_466:
											goto IL_2CE;
											IL_3B5:
											a_2 = global::Motorola.CommonCPS.RadioManagement.BatchOp.ScheduleJobBatchOp.a(radioBase, automaticPerformanceMeasurer3, radioService);
											num = (short)1605304322;
											num3 = (int)((global::System.IntPtr)num);
											goto IL_39A;
										}
										catch (global::Motorola.Common.CustomException.CommonException a_3)
										{
											global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job2 = this.a(radioBase.SerialNumber, a_3);
											radioService.AddBatchOperationJob(job2);
											num2++;
											base.ReportProgress(num2);
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(radioBase.SerialNumber + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鿌苎鋐ꛔ듖뇘뻚맜꫞跠蛢臤쟦菨蓪迬쿮韰鋲鳴鯶헸\udbfa鏼郾甀⌂瘄搆愈渊椌税紐瘒焔㜖瘘甚㴜氞䐠儢匤䈦嬨", a_));
											goto IL_1D4;
										}
										goto IL_4C0;
										IL_2CE:
										num = (short)1130233858;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										if (readWriteJobContainerUuid == null)
										{
											num = (short)1667563527;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5D3;
									case 11:
										goto IL_5B1;
									}
									goto IL_290;
									IL_370:
									automaticPerformanceMeasurer4 = automaticPerformanceMeasurer2;
									num = (short)761528324;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_4C0:
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(radioBase.SerialNumber + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("ꗌ껎ꋐꛔ듖뇘뻚맜꫞跠蛢臤쟦菨蓪迬", a_));
									num = (short)1197473802;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_5B1:
									readWriteJobContainerUuid = job.JobContainerUuid;
									num = (short)882900992;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_5D3:
									num2++;
									base.ReportProgress(num2);
									num = (short)802619400;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_5F6:
								break;
								IL_290:
								entitySet = null;
								jobRq = null;
								a_2 = null;
								num = (short)1907818505;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_259;
							}
							finally
							{
								num = (short)1415315456;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_62E;
										}
										continue;
									case 1:
										goto IL_665;
									case 2:
										automaticPerformanceMeasurer3.Dispose();
										num = (short)1558839297;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_62E:
									if (automaticPerformanceMeasurer3 == null)
									{
										break;
									}
									num = (short)1876688898;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_665:;
							}
							goto IL_668;
						case 9:
							automaticPerformanceMeasurer = null;
							goto IL_215;
						}
						IL_1D4:
						num = (short)389152770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FD:
						goto IL_1D4;
						IL_215:
						automaticPerformanceMeasurer3 = automaticPerformanceMeasurer;
						num = (short)36569096;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_668:
						num = (short)1187184646;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_24A:
					goto IL_73C;
					IL_680:
					goto IL_95;
				}
				finally
				{
					num = (short)636878848;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)729876388;
							short num4 = num;
							num = (short)1694500772;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1806893056;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_700;
								}
								continue;
							}
							break;
						}
						case 1:
							goto IL_739;
						case 2:
							enumerator.Dispose();
							num = (short)441450497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_700:
						if (enumerator == null)
						{
							break;
						}
						num = (short)139132930;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_739:;
				}
				goto IL_73C;
				IL_95:
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("飊껌꟎듐럒ꃔ믖볘ﯚ럜냞菠쏢胤触跨엪", a_), null, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Info);
				IL_73C:
				num = (short)1732050944;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001A8EC File Offset: 0x00018AEC
		private global::Motorola.CommonCPS.Server.EntityModel.JobRequest a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_1, global::Motorola.CommonCPS.Server.EntityModel.Radio A_2, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService A_3, out global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet A_4)
		{
			int a_ = 11;
			short num = (short)1579614224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
				switch (num2)
				{
				case 0:
					automaticPerformanceMeasurer = A_1.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鏏ꃑ뇓럕곗뿙ﳛ铝迟胡쓣듥跧鯩駫语華蛱", a_));
					goto IL_25A;
				case 1:
					num = (short)1959854081;
					if (num != 0)
					{
					}
					try
					{
						global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP;
						return this.CreateJobRequest(A_2, updatedCP);
					}
					finally
					{
						num = (short)211812352;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1D5;
								}
								continue;
							case 1:
								goto IL_20A;
							case 2:
								automaticPerformanceMeasurer2.Dispose();
								num = (short)900661249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1D5:
							if (automaticPerformanceMeasurer2 == null)
							{
								break;
							}
							num = (short)2137522178;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_20A:;
					}
					goto IL_20D;
				case 2:
					if (A_1 == null)
					{
						num = (short)620888078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)954990602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_1 == null)
					{
						num = (short)190054406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1542979584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					automaticPerformanceMeasurer3 = A_1.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("胏ꃑ뇓뗕냗뿙뿛뗝샟쓡쓣郥觧蛩藫諭釯蛱釳훵鳷鿹諻韽揿朁", a_));
					goto IL_302;
				case 5:
					goto IL_300;
				case 6:
					num = (short)163708939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)885522441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					automaticPerformanceMeasurer3 = null;
					goto IL_302;
				case 9:
					if (this.JobType != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read)
					{
						num = (short)1934426112;
						short num3 = num;
						num = (short)1518206981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
				case 10:
					automaticPerformanceMeasurer4 = A_1.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蛏돑룓뿕볗믙꣛믝샟뇡臣鋥", a_));
					goto IL_4C2;
				case 11:
					automaticPerformanceMeasurer = null;
					goto IL_25A;
				case 12:
					try
					{
						A_4 = A_3.BuildValidateSetForScheduleJob(A_2, A_2.CurrentCodeplug, A_2.WorkingCodeplug);
						goto IL_9D;
					}
					finally
					{
						num = (short)1213202432;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3D0;
								}
								continue;
							case 1:
								goto IL_403;
							case 2:
								automaticPerformanceMeasurer2.Dispose();
								num = (short)1080164353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3D0:
							if (automaticPerformanceMeasurer2 == null)
							{
								break;
							}
							num = (short)1420558338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_403:;
					}
					goto Block_8;
					IL_9D:
					num = (short)1704132611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (A_1 == null)
					{
						num = (short)880803858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)632356868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_20D;
				case 15:
					automaticPerformanceMeasurer4 = null;
					goto IL_4C2;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 17:
					goto IL_406;
				case 18:
					num = (short)1925447688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				if (A_0.MismatchFlags)
				{
					num = (short)606339079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_155:
				this.ValidateJob(A_2);
				num = (short)1044643853;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				num = (short)1001521167;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25A:
				automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
				num = (short)199360513;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_302:
				automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3;
				num = (short)997457937;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				Block_8:
				try
				{
					IL_406:
					global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP = this.a(A_2);
					goto IL_32B;
				}
				finally
				{
					num = (short)1925775360;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1140621788;
							short num4 = num;
							num = (short)731677148;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)902823936;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_48C;
								}
								continue;
							}
							break;
						}
						case 1:
							goto IL_4BF;
						case 2:
							automaticPerformanceMeasurer2.Dispose();
							num = (short)1797783553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_48C:
						if (automaticPerformanceMeasurer2 == null)
						{
							break;
						}
						num = (short)427032578;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4BF:;
				}
				goto IL_4C2;
				IL_32B:
				num = (short)79429634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C2:
				automaticPerformanceMeasurer2 = automaticPerformanceMeasurer4;
				num = (short)180289548;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_300:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Radio_Feature_Mismatched);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001AE04 File Offset: 0x00019004
		internal void ValidateJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)577110016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				int? productFamily;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadio a_;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (productFamily.GetValueOrDefault() == num3 & productFamily != null)
						{
							num = (short)1200881669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType;
						if (jobType == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset)
						{
							this.a(a_);
							num = (short)1284374530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)13745040;
						short num4 = num;
						num = (short)1423686544;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F6;
						default:
							num = (short)1164312576;
							if (num != 0)
							{
							}
							num = (short)1517813764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_159;
					case 3:
						num = (short)1896873985;
						if (num != 0)
						{
						}
						num = (short)1812856833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1E0;
					case 5:
					{
						a_ = (radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType = this.JobType;
						num = (short)1871970310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType;
						if (jobType != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read)
						{
							goto IL_F6;
						}
						goto IL_9B;
					}
					}
					goto IL_4A;
					IL_F6:
					num = (short)1806958595;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9B:
				this.b(a_);
				return;
				IL_159:
				return;
				IL_1E0:
				num = (short)554958848;
				short num5 = num;
				return;
				IL_4A:
				productFamily = radio.ProductFamily;
				num3 = 4096;
				num = (short)533987328;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001AFF8 File Offset: 0x000191F8
		private void b(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0)
		{
			short num = (short)2024407044;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14D;
				case 1:
					goto IL_10A;
				case 2:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsMaintenanceMode)
					{
						num = (short)1623326721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)4915202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1982267393;
					if (num != 0)
					{
					}
					num = (short)566520762;
					short num3 = num;
					num = (short)1440508858;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num = (short)1321992192;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					break;
				}
				case 5:
				{
					num = (short)1045495808;
					short num4 = num;
					num = (short)208994304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_B3:
				if (A_0 != null)
				{
					num = (short)24576005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_14D:
				if (!A_0.Provisioned)
				{
					return;
				}
				num = (short)1031733251;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Schedule_Read_For_Provisioned_Radio_Failed);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001B178 File Offset: 0x00019378
		private void a(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0)
		{
			short num = (short)115658859;
			short num2 = num;
			num = (short)717869163;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E6:
				if (A_0.Provisioned)
				{
					return;
				}
				num = (short)2104033281;
				if (num != 0)
				{
				}
				num = (short)1131741184;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1800470528;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num3)
				{
				case 0:
					goto IL_12C;
				case 1:
					goto IL_E6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 3:
					num = (short)1654063105;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				if (A_0 == null)
				{
					return;
				}
				num = (short)2084241411;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Schedule_Factory_Reset_For_Unprovisioned_Radio_Failed);
			IL_5E:
			num = (short)1608056832;
			if (num != 0)
			{
			}
			num = (short)535494658;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001B2B4 File Offset: 0x000194B4
		private global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			short num = (short)2043543553;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest securityFieldRequest;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return securityFieldRequest;
				case 1:
					num = (short)850526209;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				case 2:
					this.a.ScheduleJobPreChecking(A_0);
					this.IsWriteProtected = this.a.IsWriteProtected;
					num = (short)1169817603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_FF;
				case 4:
					return securityFieldRequest;
				case 5:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType;
					this.ValidateDevice(A_0, this.JobType, false, false, this.Transport, this.IsWriteProtected, this.ReadyJobtOption > global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.RadioOnly, out securityFieldRequest, out this.supportedConnections, out jobType);
					this.JobType = jobType;
					num = (short)1106116608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (this.a.ScheduleJobPreChecking != null)
					{
						num = (short)721354754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				case 7:
					if (!this.a.IsFirmwareRecoverJob)
					{
						num = (short)144506885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					securityFieldRequest = new global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest();
					base.ValidationServiceFactory.RadioValidationService.RefreshLastProgrammedDate(securityFieldRequest);
					this.supportedConnections = 1;
					num = (short)875626505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)892207110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return securityFieldRequest;
				}
				IL_73:
				num = (short)1912995840;
				short num3 = num;
				if (this.JobType != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read)
				{
					num = (short)1340407816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.ValidateDevice(A_0, this.JobType, false, false, this.Transport, this.IsWriteProtected, this.ReadyJobtOption > global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.RadioOnly, out securityFieldRequest, out this.supportedConnections);
				num = (short)47120388;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FF:
				num = (short)409201282;
				short num4 = num;
				num = (short)642706050;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)40173568;
					if (num != 0)
					{
					}
					num = (short)552665095;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return securityFieldRequest;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001B568 File Offset: 0x00019768
		private global::Motorola.CommonCPS.Server.EntityModel.JobRequest a(global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_0, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService A_1, global::Motorola.CommonCPS.Server.EntityModel.Radio A_2, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService A_3, out global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet A_4)
		{
			int a_ = 1;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobRequest result;
			try
			{
				num = (short)1736966144;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					global::Motorola.Common.Communication.Pba.PbaObject historical_PbaObject;
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo historical_DeviceInfo;
					global::Motorola.Common.Communication.Pba.PbaObject current_PbaObject;
					byte[] a_2;
					for (;;)
					{
						IL_30:
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer4;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer5;
						switch (num2)
						{
						case 0:
							automaticPerformanceMeasurer = A_0.StartAutomaticSubMeasurer(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("郅꧇ꛉꗋ꫍뇏ꛑ뇓诗뿙꣛", a_), global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("铅귇막룋ꇍꋏ럑", a_)));
							goto IL_513;
						case 1:
							num = (short)229834772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP;
								global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
								result = this.CreateRestoreJobRequest(A_2, updatedCP, codeplug);
								goto IL_602;
							}
							finally
							{
								for (;;)
								{
									num = (short)1491795970;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											automaticPerformanceMeasurer2.Dispose();
											num = (short)1088094209;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_400;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_3C9;
											}
											continue;
										}
										IL_3C9:
										if (automaticPerformanceMeasurer2 == null)
										{
											break;
										}
										num = (short)570490880;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_402:
									num = (short)449058297;
									short num3 = num;
									num = (short)495851001;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_438;
									}
									IL_400:
									goto IL_402;
								}
								IL_438:
								num = (short)1265238016;
								if (num != 0)
								{
								}
							}
							goto IL_44F;
						case 3:
							automaticPerformanceMeasurer3 = null;
							goto IL_2B6;
						case 4:
							automaticPerformanceMeasurer4 = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("郅꧇ꛉꗋ꫍뇏ꛑ뇓뇗볙ﳛ賝藟釡郣觥髧迩쳫迭鳯黱鯳臵鷷黹", a_));
							goto IL_4B2;
						case 5:
							try
							{
								A_4 = A_3.BuildValidateSetForScheduleJob(A_2, A_2.CurrentCodeplug, A_2.WorkingCodeplug);
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> collection;
								A_4.ValidateEntityList.AddRange(collection);
								goto IL_52F;
							}
							finally
							{
								num = (short)863698946;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)348192769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_5FF;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5C8;
										}
										continue;
									}
									IL_5C8:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)1813315584;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5FF:;
							}
							goto IL_602;
							IL_52F:
							num = (short)1243152399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (A_0 == null)
							{
								num = (short)921632787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_44F;
						case 7:
							if (A_0 == null)
							{
								num = (short)1783431169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_356;
						case 8:
							if (A_0 == null)
							{
								num = (short)1575223309;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)338821120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							try
							{
								A_1.PacSpecial_Validate_AllowRestore(A_2, historical_PbaObject, historical_DeviceInfo, current_PbaObject);
								goto IL_DD;
							}
							finally
							{
								num = (short)1420689410;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)966787073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_353;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_31B;
										}
										continue;
									}
									IL_31B:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)680591360;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_353:;
							}
							goto IL_356;
							IL_DD:
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> collection;
							bool restoreJob_PbaCanNotBeDirectlyModified;
							global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug = this.a(A_0, A_1, a_2, out collection, out restoreJob_PbaCanNotBeDirectlyModified);
							num = (short)126091270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_61C;
						case 11:
							automaticPerformanceMeasurer5 = null;
							goto IL_1BE;
						case 12:
							num = (short)208863235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)925171726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							automaticPerformanceMeasurer = null;
							goto IL_513;
						case 15:
							if (A_0 == null)
							{
								num = (short)1316683788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)439681041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							automaticPerformanceMeasurer5 = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("郅꧇ꛉꗋ꫍뇏ꛑ뇓볗뿙ꫛ럝菟蟡", a_));
							goto IL_1BE;
						case 17:
							automaticPerformanceMeasurer3 = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("藅뫇꿉귋뫍뗏蛓돕ꯗ껙돛곝藟싡껣觥諧쫩黫语臯蟱釳藵賷", a_));
							goto IL_2B6;
						case 18:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
							try
							{
								A_2.WorkingCodeplug = codeplug;
								A_2.WorkingCodeplugUuid = new global::System.Guid?(codeplug.Uuid);
								global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP;
								bool restoreJob_PbaCanNotBeDirectlyModified;
								this.ValidateDevice(A_2, this.JobType, this.b, restoreJob_PbaCanNotBeDirectlyModified, this.Transport, this.IsWriteProtected, this.ReadyJobtOption > global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.RadioOnly, out updatedCP, out this.supportedConnections);
								goto IL_17D;
							}
							finally
							{
								num = (short)1153826818;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)1106903041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2B3;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_27B;
										}
										continue;
									}
									IL_27B:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)1866924032;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2B3:;
							}
							goto IL_2B6;
							IL_17D:
							global::Motorola.CommonCPS.RadioManagement.BatchOp.ScheduleJobBatchOp.a(codeplug);
							num = (short)1189478408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							num = (short)715980811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							automaticPerformanceMeasurer4 = null;
							goto IL_4B2;
						}
						goto IL_8B;
						IL_1BE:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer5;
						num = (short)640548882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B6:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer3;
						num = (short)1947795458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_356:
						num = (short)605880324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_44F:
						num = (short)1787887632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4B2:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer4;
						num = (short)657129481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_513:
						automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
						num = (short)1230700549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_602:
						num = (short)457375754;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_61C:
					break;
					IL_8B:
					historical_PbaObject = this.a(A_0, out historical_DeviceInfo, out a_2);
					current_PbaObject = this.a(A_0);
					num = (short)1725366279;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RestoreJob_GenericError, systemException);
			}
			num = (short)1359675393;
			if (num != 0)
			{
			}
			num = (short)479330304;
			short num4 = num;
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001BC8C File Offset: 0x00019E8C
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_0)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					A_0.Template.Name = text;
					A_0.Template.TemplateBaseName = text;
					num2 = (short)1869479938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0.Template != null)
					{
						goto IL_131;
					}
					return;
				case 2:
					return;
				case 3:
					goto IL_10F;
				case 4:
					if (A_0.Configuration != null)
					{
						num2 = (short)1177681925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10F;
				case 5:
				{
					num2 = (short)172752897;
					if (num2 != 0)
					{
					}
					A_0.Configuration.Name = text;
					A_0.Configuration.ConfigurationBaseName = text;
					num2 = (short)63020135;
					short num3 = num2;
					num2 = (short)1355914343;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
					{
						num2 = (short)1268121600;
						if (num2 != 0)
						{
						}
						num2 = (short)935788544;
						short num4 = num2;
						num2 = (short)1112670211;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_31;
				IL_10F:
				num2 = (short)286654465;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_131:
				num2 = (short)177602560;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_31:
			global::System.DateTime dateTime = global::System.TimeZoneInfo.ConvertTimeToUtc(global::System.DateTime.Now);
			text = global::Motorola.CommonCPS.ResourceRepository.Resources.JobName_Restore + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + dateTime.ToString(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("诋", a_), global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鯍蓏金﷓", a_);
			num2 = (short)1531641860;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001BE90 File Offset: 0x0001A090
		private global::Motorola.CommonCPS.Server.EntityModel.Codeplug a(global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_0, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService A_1, byte[] A_2, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> A_3, out bool A_4)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_56;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)1080885248;
				short num2 = num;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
				switch (num3)
				{
				case 0:
					automaticPerformanceMeasurer = null;
					goto IL_1DE;
				case 1:
					num = (short)1148518401;
					if (num != 0)
					{
					}
					automaticPerformanceMeasurer = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鏏뷑ꛓꓕ뷗맙꣛ﻝ裟诡韣鋥蟧飩藫跭釯黱퓳뗵韷黹駻軽泿省挃", a_));
					goto IL_1DE;
				case 2:
					try
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(A_3, this.c);
						return A_1.FixIncorrectData_OfHistoricalCodeplug(this.c.Codeplug, A_3, A_2, out A_4);
					}
					finally
					{
						for (;;)
						{
							num = (short)61210626;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									automaticPerformanceMeasurer2.Dispose();
									num = (short)826605569;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_122;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_ED;
									}
									continue;
								}
								IL_ED:
								if (automaticPerformanceMeasurer2 == null)
								{
									break;
								}
								num = (short)2039283712;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_124:
							num = (short)164997837;
							short num4 = num;
							num = (short)1918413517;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_15A;
							}
							IL_122:
							goto IL_124;
						}
						IL_15A:
						num = (short)1059586048;
						if (num != 0)
						{
						}
					}
					goto IL_171;
				case 3:
					if (A_0 == null)
					{
						num = (short)1898119172;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_171;
				case 4:
					num = (short)1840185344;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_56;
				IL_171:
				num = (short)555352065;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DE:
				automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
				num = (short)1991966722;
				num3 = (int)((global::System.IntPtr)num);
			}
			global::Motorola.CommonCPS.Server.EntityModel.Codeplug result;
			return result;
			IL_56:
			A_3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			num = (short)727187459;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_0)
		{
			int a_ = 3;
			short num = (short)590544896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_55;
				}
				global::System.Guid? fileUuid;
				for (;;)
				{
					IL_32:
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
					switch (num2)
					{
					case 0:
					{
						num = (short)653787136;
						short num3 = num;
						if (fileUuid == null)
						{
							num = (short)1093402629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1526071302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						automaticPerformanceMeasurer = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("过꿉룋돏ꟑꛓꓕ뷗듙꣛ﻝ냟ꃡꗣ", a_));
						goto IL_263;
					case 2:
						automaticPerformanceMeasurer = null;
						goto IL_263;
					case 3:
						num = (short)2125135874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							global::Motorola.Common.Communication.Pba.PbaObject result;
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
							byte[] array;
							this.GetPbaObjectFromServer(this.c.Radio.CurrentCodeplug.FileUuid, out result, out deviceInfo, out array);
							return result;
						}
						finally
						{
							for (;;)
							{
								num = (short)1164247042;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										automaticPerformanceMeasurer2.Dispose();
										num = (short)180092929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1DB;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_1A4;
										}
										continue;
									}
									IL_1A4:
									if (automaticPerformanceMeasurer2 == null)
									{
										break;
									}
									num = (short)1593966592;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1DD:
								num = (short)1322610979;
								short num4 = num;
								num = (short)1645048099;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_212;
								}
								IL_1DB:
								goto IL_1DD;
							}
							IL_212:
							num = (short)1095499776;
							if (num != 0)
							{
							}
						}
						goto IL_229;
					case 5:
						goto IL_F0;
					case 6:
						if (A_0 == null)
						{
							num = (short)46465027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_229;
					}
					goto IL_55;
					IL_229:
					num = (short)53280769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
					num = (short)1289289732;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RestoreJob_CrntCPHasNoXPBA);
				IL_55:
				num = (short)575471617;
				if (num != 0)
				{
				}
				fileUuid = this.c.Radio.CurrentCodeplug.FileUuid;
				num = (short)2121531392;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001C34C File Offset: 0x0001A54C
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_0, out global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1, out byte[] A_2)
		{
			int a_ = 8;
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)538050562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
					switch (num2)
					{
					case 0:
						num = (short)988086277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)34572646;
						short num3 = num;
						num = (short)768641382;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
							goto IL_1A2;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 3:
						automaticPerformanceMeasurer = A_0.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("諌꫎ꗐ뷔뻖꫘꿚닜귞裠胢蓤详짨믪꿬껮", a_));
						goto IL_136;
					case 4:
						try
						{
							this.GetPbaObjectFromServer(this.c.Codeplug.FileUuid, out result, out A_1, out A_2);
							goto IL_155;
						}
						finally
						{
							num = (short)1124925440;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_B7;
									}
									continue;
								case 1:
									goto IL_EB;
								case 2:
									automaticPerformanceMeasurer2.Dispose();
									num = (short)574423041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B7:
								if (automaticPerformanceMeasurer2 == null)
								{
									break;
								}
								num = (short)1031667714;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EB:;
						}
						goto IL_EE;
						IL_155:
						num = (short)1898708993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						automaticPerformanceMeasurer = null;
						goto IL_136;
					}
					IL_46:
					if (A_0 == null)
					{
						num = (short)1805058048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_EE:
					num = (short)163840003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_137:
					num = (short)503382020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_136:
					automaticPerformanceMeasurer2 = automaticPerformanceMeasurer;
					goto IL_137;
				}
				IL_1A2:
				num = (short)1292369920;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Restore_HistoryPbaNotExist, systemException);
			}
			num = (short)2098987008;
			short num4 = num;
			num = (short)923664385;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		private static global::Motorola.CommonCPS.Server.EntityModel.Radio a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer A_1, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService A_2)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			for (;;)
			{
				IL_13:
				num = (short)512425984;
				short num2 = num;
				int num3;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
				switch (num3)
				{
				case 0:
					num = (short)226230276;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radio.Timestamp, A_0.RadioTimestamp))
					{
						num = (short)1151139848;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return radio;
				}
				case 2:
					if (A_1 == null)
					{
						num = (short)2117402624;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				case 3:
					try
					{
						global::System.Guid? id = A_0.ID;
						global::Motorola.CommonCPS.Server.EntityModel.Radio radio = A_2.GetRadio(id.Value, true);
						goto IL_243;
					}
					finally
					{
						num = (short)1891762176;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_14A;
								}
								continue;
							case 1:
								goto IL_17D;
							case 2:
								automaticPerformanceMeasurer.Dispose();
								num = (short)1551433729;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_14A:
							if (automaticPerformanceMeasurer == null)
							{
								break;
							}
							num = (short)1964638210;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_17D:;
					}
					goto IL_180;
					IL_243:
					num = (short)656408586;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					automaticPerformanceMeasurer2 = null;
					goto IL_1D5;
				case 5:
					automaticPerformanceMeasurer2 = A_1.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("跉꧋뫍胑뗓닕뇗뗙", a_));
					goto IL_1D5;
				case 6:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num = (short)1132265479;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1948385282;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_FA;
				case 8:
					goto IL_241;
				case 9:
					goto IL_2A1;
				case 10:
				{
					num = (short)677969921;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
					if (radio == null)
					{
						num = (short)1692598281;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)501350401;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6E;
				IL_1D5:
				automaticPerformanceMeasurer = automaticPerformanceMeasurer2;
				num = (short)1447493635;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			IL_180:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error);
			IL_241:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_2A1:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
			IL_6E:
			num = (short)1774718681;
			short num4 = num;
			num = (short)435490521;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A7:
				num = (short)663224325;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)389414912;
				if (num != 0)
				{
				}
				global::System.Guid? id = A_0.ID;
				num = (short)1427767302;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
		protected void GetPbaObjectFromServer(global::System.Guid? PbaFileUuid, out global::Motorola.Common.Communication.Pba.PbaObject pbaObj, out global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, out byte[] xpbaByteArray)
		{
			short num = (short)1257508120;
			short num2 = num;
			num = (short)871435544;
			switch (num2 == num)
			{
			default:
			{
				num = (short)506462208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1189740544;
			if (num != 0)
			{
			}
			num = (short)1319829505;
			if (num != 0)
			{
			}
			xpbaByteArray = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetFileContent(PbaFileUuid.Value);
			global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(xpbaByteArray);
			deviceInfo = (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]);
			pbaObj = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001C99C File Offset: 0x0001AB9C
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.JobRequest CreateJobRequest(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			short num = (short)2103836673;
			if (num != 0)
			{
			}
			num = (short)25821184;
			short num2 = num;
			num = (short)482077584;
			short num3 = num;
			num = (short)1852042128;
			switch (num3 == num)
			{
			}
			num = (short)1095237632;
			if (num != 0)
			{
			}
			return this.PrepareJobRequest(radio, updatedCP).Build();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001CA54 File Offset: 0x0001AC54
		protected virtual global::Motorola.CommonCPS.Server.EntityModel.JobRequest CreateRestoreJobRequest(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, global::Motorola.CommonCPS.Server.EntityModel.Codeplug restoreCodeplug)
		{
			short num = (short)615311418;
			short num2 = num;
			num = (short)1993926714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1539833856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)138084352;
			if (num != 0)
			{
			}
			num = (short)1591148545;
			if (num != 0)
			{
			}
			return this.PrepareJobRequest(radio, updatedCP).SetRestoreJob(restoreCodeplug).Build();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001CB10 File Offset: 0x0001AD10
		protected global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder PrepareJobRequest(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			string name;
			for (;;)
			{
				IL_13:
				global::System.DateTime dateTime;
				switch (num)
				{
				case 0:
					if (this.b)
					{
						num2 = (short)132513797;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					name = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Converters.JobTypeConverter(new global::Motorola.CommonCPS.ResourceRepository.ResourceWrapper()).ConvertJobTypeToString(this.JobType) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + dateTime.ToString(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("苄", a_), global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鋆鷈裊", a_);
					num2 = (short)1034747906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_CD;
				case 2:
					goto IL_268;
				case 3:
					if (this.ReadWriteJobName != null)
					{
						num2 = (short)101449732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 4:
					num2 = (short)216530945;
					if (num2 != 0)
					{
					}
					num2 = (short)55377927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					name = global::Motorola.CommonCPS.ResourceRepository.Resources.JobName_Restore + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + dateTime.ToString(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("苄", a_), global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鋆鷈裊", a_);
					num2 = (short)765853697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_D2;
				case 7:
					if (string.IsNullOrEmpty(this.ReadWriteJobName.Trim()))
					{
						num2 = (short)556531718;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_26A;
				}
				goto IL_39;
				IL_D2:
				dateTime = global::System.TimeZoneInfo.ConvertTimeToUtc(global::System.DateTime.Now);
				num2 = (short)193426488;
				short num3 = num2;
				num2 = (short)702772280;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1734279168;
					if (num2 != 0)
					{
					}
					num2 = (short)358875136;
					short num4 = num2;
					num2 = (short)20840448;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			IL_CD:
			IL_268:
			IL_26A:
			return global::Motorola.CommonCPS.Server.EntityModel.JobRequestBuilder.CreateBuilder(name, this.DefermentNumber, radio, this.JobType, (global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod)this.supportedConnections, this.ReadyJobtOption).SetSecurityField(updatedCP).SetScheduleDate(this.StartDate, this.EndDate).SetUEFileContent(this.UEFileContent).SetSysCert(this.a.IsUserCertUninstallAllChecked, this.a.IsSysCertDisableAllChecked, this.a.IsSysCertEnableAllChcked).SetFirmwareRecoverJob(this.a.IsFirmwareRecoverJob).SetSingleRadio(false).SetPasswordResetFileContent(this.a.ResetPasswordFileContent);
			IL_39:
			name = this.ReadWriteJobName;
			num2 = (short)2016411651;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001CE14 File Offset: 0x0001B014
		protected virtual void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections, out global::Motorola.CommonCPS.Server.CommonDBConstants.JobType correctedJobType)
		{
			short num = (short)1767008468;
			short num2 = num;
			num = (short)1868916948;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1770782720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)115605505;
			if (num != 0)
			{
			}
			num = (short)738918400;
			if (num != 0)
			{
			}
			base.ValidationServiceFactory.RadioValidationService.ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections, out correctedJobType);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
		protected virtual void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections)
		{
			short num = (short)1081367037;
			short num2 = num;
			num = (short)847010301;
			switch (num2 == num)
			{
			default:
			{
				num = (short)918618112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2138963969;
			if (num != 0)
			{
			}
			num = (short)273285120;
			if (num != 0)
			{
			}
			base.ValidationServiceFactory.RadioValidationService.ValidateDevice(d, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out fieldsModifyRequest, out supportedConnections);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001CFAC File Offset: 0x0001B1AC
		private global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob a(string A_0, global::Motorola.Common.CustomException.CommonException A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_1.CommonExceptionData != null)
					{
						goto IL_80;
					}
					goto IL_F0;
				case 1:
					num2 = (short)619642881;
					if (num2 != 0)
					{
					}
					goto IL_F0;
				case 2:
					batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(A_1.CommonExceptionData.Paramters);
					num2 = (short)841351169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_80:
				num2 = (short)23527426;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F0:
				num2 = (short)1728859182;
				short num3 = num2;
				num2 = (short)1447644206;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_80;
				default:
					goto IL_124;
				}
			}
			IL_124:
			num2 = (short)1374617600;
			if (num2 != 0)
			{
			}
			batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
			batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
			batchOperationJob.ErrorMessage = A_1.Message;
			return batchOperationJob;
			IL_1C:
			batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
			batchOperationJob.JobDescription = A_0;
			batchOperationJob.ErrorCode = new int?((int)A_1.ErrorCode);
			num2 = (short)513277952;
			short num4 = num2;
			num2 = (short)124911616;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000042 RID: 66
		protected int supportedConnections;

		// Token: 0x04000043 RID: 67
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext a;

		// Token: 0x04000044 RID: 68
		private bool b;

		// Token: 0x04000045 RID: 69
		private global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob c;

		// Token: 0x04000046 RID: 70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference d;

		// Token: 0x04000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.DateTime? e;

		// Token: 0x04000048 RID: 72
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.DateTime? f;

		// Token: 0x04000049 RID: 73
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;

		// Token: 0x0400004A RID: 74
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.JobType h;

		// Token: 0x0400004B RID: 75
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption i;

		// Token: 0x0400004C RID: 76
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x0400004D RID: 77
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x0400004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] l;

		// Token: 0x0400004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int m;
	}
}
