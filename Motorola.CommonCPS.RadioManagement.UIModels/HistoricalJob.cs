using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000D2 RID: 210
	public class HistoricalJob : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x000952FC File Offset: 0x000934FC
		public HistoricalJob(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob rwJob)
		{
			this.RawData = rwJob;
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00095318 File Offset: 0x00093518
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000953C8 File Offset: 0x000935C8
		public global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob RawData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)924900099;
				short num2 = num;
				num = (short)1527438083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769996288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1175584769;
				if (num != 0)
				{
				}
				num = (short)717029376;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2041019057;
				short num2 = num;
				num = (short)536705713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124480512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300430849;
				if (num != 0)
				{
				}
				num = (short)1769340928;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0009547C File Offset: 0x0009367C
		public byte[] JobFlashCode
		{
			get
			{
				if (this.APXCodeplug == null)
				{
					short num;
					for (;;)
					{
						num = (short)1843144003;
						short num2 = num;
						num = (short)1322984771;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_6C;
						}
						break;
					}
					num = (short)1245708288;
					short num3 = num;
					IL_6C:
					num = (short)918028289;
					if (num != 0)
					{
					}
					num = (short)2125463552;
					if (num != 0)
					{
					}
					return null;
				}
				return this.APXCodeplug.AstroPurchasedFlashCode;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00095540 File Offset: 0x00093740
		public string JobCFS
		{
			get
			{
				if (this.MatrixCodeplug == null)
				{
					short num;
					for (;;)
					{
						num = (short)572981249;
						if (num != 0)
						{
						}
						num = (short)1600585728;
						short num2 = num;
						num = (short)1647488058;
						short num3 = num;
						num = (short)847752250;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_92;
						}
					}
					IL_92:
					num = (short)862978048;
					if (num != 0)
					{
					}
					return null;
				}
				return this.MatrixCodeplug.CFS;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00095604 File Offset: 0x00093804
		public string ModelNumber
		{
			get
			{
				short num = (short)748542086;
				short num2 = num;
				num = (short)1200019590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2056257536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632553473;
				if (num != 0)
				{
				}
				num = (short)449052672;
				if (num != 0)
				{
				}
				return this.RawData.Radio.ModelNumber;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x000956BC File Offset: 0x000938BC
		public global::System.Guid JobID
		{
			get
			{
				short num = (short)1987296173;
				short num2 = num;
				num = (short)1675017133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462894592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968097793;
				if (num != 0)
				{
				}
				num = (short)514850816;
				if (num != 0)
				{
				}
				return this.RawData.Uuid;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00095770 File Offset: 0x00093970
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)477932937;
				short num2 = num;
				num = (short)86093193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307639808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913389057;
				if (num != 0)
				{
				}
				num = (short)144179200;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.RawData.Uuid);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0009582C File Offset: 0x00093A2C
		public byte[] JobTimeStamp
		{
			get
			{
				short num = (short)1203434682;
				short num2 = num;
				num = (short)824702138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1714749440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1363935232;
				if (num != 0)
				{
				}
				num = (short)1218117633;
				if (num != 0)
				{
				}
				return this.RawData.Timestamp;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000958E4 File Offset: 0x00093AE4
		public string SuperJobName
		{
			get
			{
				short num = (short)1317984382;
				short num2 = num;
				num = (short)20961406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98107392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829175297;
				if (num != 0)
				{
				}
				num = (short)137232384;
				if (num != 0)
				{
				}
				return this.RawData.JobContainer.JobName;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x000959A0 File Offset: 0x00093BA0
		public global::System.DateTime? ExecutedDate
		{
			get
			{
				short num = (short)923780577;
				short num2 = num;
				num = (short)838780385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1903034368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630325248;
				if (num != 0)
				{
				}
				num = (short)43581441;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.RawData.ExecutedDate);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00095A5C File Offset: 0x00093C5C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00095B10 File Offset: 0x00093D10
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1817726731;
				short num2 = num;
				num = (short)1258639115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050555904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502478337;
				if (num != 0)
				{
				}
				num = (short)974061568;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2109368351;
				short num2 = num;
				num = (short)971794463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1048903680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658571264;
				if (num != 0)
				{
				}
				num = (short)609288193;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00095BC0 File Offset: 0x00093DC0
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? CruncherStatus
		{
			get
			{
				short num = (short)2122546949;
				short num2 = num;
				num = (short)1238007557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363869696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)594804737;
				if (num != 0)
				{
				}
				num = (short)2068905984;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(this.RawData.CruncherStatus);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00095C7C File Offset: 0x00093E7C
		public string JobCruncherStatus
		{
			get
			{
				int a_ = 17;
				short num = (short)737673216;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_9B;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType;
					global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? jobStatus;
					for (;;)
					{
						IL_31:
						num = (short)858578986;
						short num3 = num;
						num = (short)1325457450;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)612433920;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								cruncherStatus = this.CruncherStatus;
								num = (short)1008599042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								num = (short)1155923969;
								if (num != 0)
								{
								}
								if (jobType != null)
								{
									num = (short)733085699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_252;
							case 2:
								if (cruncherStatus != null)
								{
									num = (short)1167523845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_252;
							case 3:
								goto IL_204;
							case 4:
								goto IL_BC;
							case 5:
							{
								num = (short)1673920512;
								short num4 = num;
								jobType = this.JobType;
								num = (short)651886593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_9B;
						}
						IL_BC:
						if (jobStatus == null)
						{
							goto IL_252;
						}
						num = (short)526712832;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_204:
					string[] array = new string[5];
					int num5 = 0;
					jobStatus = this.JobStatus;
					array[num5] = ((int)jobStatus.Value).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					array[1] = global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恋", a_);
					int num6 = 2;
					cruncherStatus = this.CruncherStatus;
					array[num6] = ((int)cruncherStatus.Value).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					array[3] = global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恋", a_);
					int num7 = 4;
					jobType = this.JobType;
					array[num7] = ((int)jobType.Value).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					return string.Concat(array);
					IL_252:
					return null;
					IL_9B:
					jobStatus = this.JobStatus;
					num = (short)1217789956;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00095EDC File Offset: 0x000940DC
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? JobType
		{
			get
			{
				short num = (short)240510754;
				short num2 = num;
				num = (short)1213982498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319291392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562298881;
				if (num != 0)
				{
				}
				num = (short)1703673856;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?(this.RawData.JobContainer.JobType);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00095F98 File Offset: 0x00094198
		public bool IsMigrationJob
		{
			get
			{
				short num = (short)1871987432;
				short num2 = num;
				num = (short)1966031592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)836239360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)606928897;
				if (num != 0)
				{
				}
				num = (short)955383808;
				if (num != 0)
				{
				}
				return this.RawData.JobContainer.IsMigrationJob;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00096050 File Offset: 0x00094250
		public global::System.DateTime? CreateDate
		{
			get
			{
				short num = (short)1996624687;
				short num2 = num;
				num = (short)1455887151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1257046016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140443649;
				if (num != 0)
				{
				}
				num = (short)2139291648;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.RawData.CreatedDate);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00096108 File Offset: 0x00094308
		public string ErrorCode
		{
			get
			{
				if (this.RawData.ErrorCode == null)
				{
					short num;
					for (;;)
					{
						num = (short)674413548;
						short num2 = num;
						num = (short)1915861996;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_77;
						}
						break;
					}
					num = (short)2089156608;
					short num3 = num;
					IL_77:
					num = (short)283705345;
					if (num != 0)
					{
					}
					num = (short)947650560;
					if (num != 0)
					{
					}
					return string.Empty;
				}
				return this.RawData.ErrorCode.ToString();
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000961E8 File Offset: 0x000943E8
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00096298 File Offset: 0x00094498
		public string Reason
		{
			get
			{
				short num = (short)223563185;
				short num2 = num;
				num = (short)2028752305;
				switch (num2 == num)
				{
				}
				num = (short)1396965377;
				if (num != 0)
				{
				}
				num = (short)118620160;
				if (num != 0)
				{
				}
				num = (short)867565568;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)2066153473;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)88539136;
						short num3 = num;
						num = (short)7340033;
						if (num != 0)
						{
						}
						num = (short)483085571;
						short num4 = num;
						num = (short)1844464899;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AF;
						default:
							num = (short)471465984;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob.get_Reason())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1284243459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						return;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)886767616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_38:
					if (value == this.a)
					{
						num = (short)1985413122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AF:
					this.a = value;
					num = (short)1454112772;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00096434 File Offset: 0x00094634
		public global::System.DateTime? StartDateTime
		{
			get
			{
				short num = (short)1672455647;
				short num2 = num;
				num = (short)1558619615;
				switch (num2 == num)
				{
				}
				num = (short)1490681857;
				if (num != 0)
				{
				}
				num = (short)107413504;
				if (num != 0)
				{
				}
				num = (short)1488977920;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.RawData.JobContainer.ScheduleStartDate);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000964F0 File Offset: 0x000946F0
		public global::System.DateTime? EndDateTime
		{
			get
			{
				short num = (short)1171849217;
				if (num != 0)
				{
				}
				num = (short)7669248;
				short num2 = num;
				num = (short)1103300096;
				switch (num2 == num)
				{
				}
				num = (short)1472856064;
				if (num != 0)
				{
				}
				num = (short)1482227712;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.ServerDateTimeToUI(this.RawData.JobContainer.ScheduleEndDate);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000965B0 File Offset: 0x000947B0
		public string CodeplugFileName
		{
			get
			{
				short num = (short)397082625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)654518351;
					short num3 = num;
					num = (short)786311247;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1042087936;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (this.Configuration != null)
							{
								num = (short)1140129795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_142;
						case 1:
							goto IL_14;
						case 2:
							goto IL_C5;
						case 3:
							goto IL_134;
						}
						goto IL_80;
					}
					IL_14:
					switch (0)
					{
					case 0:
						IL_80:
						if (this.Template != null)
						{
							num = (short)1688403969;
							if (num != 0)
							{
							}
							num = (short)347209730;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)17039360;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_C5:
				return this.Template.Name;
				IL_134:
				num = (short)916914176;
				short num4 = num;
				return this.Configuration.Name;
				IL_142:
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00096700 File Offset: 0x00094900
		public string SoftwareVersion
		{
			get
			{
				int a_ = 17;
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				int num;
				int? productFamily;
				int num2;
				short num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						productFamily = this.RawData.Radio.ProductFamily;
						num2 = 512;
						num3 = (short)1477640196;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
						if (this.RawData.Codeplug == null)
						{
							num3 = (short)1758330889;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_F9;
					case 2:
						num3 = (short)726335489;
						if (num3 != 0)
						{
						}
						if (!(productFamily.GetValueOrDefault() == num2 & productFamily != null))
						{
							num3 = (short)1387724800;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_30C;
					case 3:
						goto IL_1FB;
					case 4:
						if (!(productFamily.GetValueOrDefault() == num2 & productFamily != null))
						{
							num3 = (short)1440874507;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_30C;
					case 5:
						num3 = (short)1624047617;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 6:
						if (productFamily.GetValueOrDefault() == num2 & productFamily != null)
						{
							num3 = (short)1789984773;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1485307914;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 7:
						goto IL_23F;
					case 8:
					{
						if (!(productFamily.GetValueOrDefault() == num2 & productFamily != null))
						{
							productFamily = this.RawData.Radio.ProductFamily;
							num2 = 256;
							num3 = (short)508100614;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)682438645;
						short num4 = num3;
						num3 = (short)1844129781;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F9;
						default:
							num3 = (short)552534016;
							if (num3 != 0)
							{
							}
							num3 = (short)1235353603;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						break;
					}
					case 9:
						goto IL_14C;
					case 10:
						if (this.RawData.Codeplug == null)
						{
							num3 = (short)674365447;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_31B;
					case 11:
						productFamily = this.RawData.Radio.ProductFamily;
						num2 = 2048;
						num3 = (short)1344012296;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_49;
				}
				IL_F9:
				return (this.RawData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug).PBBFirmwareVersion;
				IL_14C:
				return null;
				IL_1FB:
				goto IL_30C;
				IL_23F:
				return null;
				IL_30C:
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ɋ慍ᅏ", a_);
				IL_31B:
				return this.RawData.Codeplug.FirmwareVersion;
				IL_49:
				productFamily = this.RawData.Radio.ProductFamily;
				num2 = 1024;
				num3 = (short)483852288;
				short num5 = num3;
				num3 = (short)1276182530;
				num = (int)((global::System.IntPtr)num3);
				goto IL_13;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00096A38 File Offset: 0x00094C38
		public string CodeplugVersion
		{
			get
			{
				short num;
				string result;
				try
				{
					num = (short)113311745;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						switch (num2)
						{
						case 0:
							goto IL_FC;
						case 1:
						{
							num = (short)1161857492;
							short num3 = num;
							num = (short)596543956;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)795279360;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_81;
								}
								continue;
							}
							break;
						}
						case 2:
							num = (short)1510277124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							text = this.RawData.Codeplug.CodeplugVersion;
							goto IL_E4;
						case 4:
							text = null;
							goto IL_E4;
						}
						IL_81:
						if (this.RawData.Codeplug == null)
						{
							num = (short)95879170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1157562371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4:
						result = text;
						num = (short)1180893184;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_FC:;
				}
				catch
				{
					result = null;
				}
				num = (short)527106048;
				short num4 = num;
				num = (short)1662255105;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00096BA8 File Offset: 0x00094DA8
		private global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug APXCodeplug
		{
			get
			{
				short num = (short)1717113421;
				short num2 = num;
				num = (short)203821645;
				switch (num2 == num)
				{
				}
				num = (short)358744064;
				if (num != 0)
				{
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				num = (short)1092485120;
				short num3 = num;
				return this.RawData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00096C60 File Offset: 0x00094E60
		private global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug MatrixCodeplug
		{
			get
			{
				short num = (short)1154816501;
				short num2 = num;
				num = (short)1351358965;
				switch (num2 == num)
				{
				}
				num = (short)1530134529;
				if (num != 0)
				{
				}
				num = (short)2068578304;
				if (num != 0)
				{
				}
				num = (short)774832128;
				short num3 = num;
				return this.RawData.Codeplug as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00096D18 File Offset: 0x00094F18
		private global::Motorola.CommonCPS.Server.EntityModel.Template Template
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1317076992;
					short num2 = num;
					if (this.RawData.Codeplug == null)
					{
						goto IL_BE;
					}
					num = (short)625462534;
					short num3 = num;
					num = (short)47172870;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)806223873;
				if (num != 0)
				{
				}
				num = (short)1028849664;
				if (num != 0)
				{
				}
				return this.RawData.Codeplug.Template;
				IL_BE:
				return null;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00096DE4 File Offset: 0x00094FE4
		private global::Motorola.CommonCPS.Server.EntityModel.Configuration Configuration
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)650772480;
					short num2 = num;
					if (this.RawData.Codeplug == null)
					{
						goto IL_BE;
					}
					num = (short)1463789616;
					short num3 = num;
					num = (short)1134864432;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)1025114113;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				if (num != 0)
				{
				}
				return this.RawData.Codeplug.Configuration;
				IL_BE:
				return null;
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00096EB0 File Offset: 0x000950B0
		public void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 7;
			short num = (short)1531641856;
			short num2 = num;
			num = (short)1956578736;
			short num3 = num;
			num = (short)751961520;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1294532608;
				if (num != 0)
				{
				}
				num = (short)26476545;
				if (num != 0)
				{
				}
				num = (short)1361510400;
				switch (num)
				{
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historicalJob = (global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob)source;
			global::System.Collections.Generic.IList<string> list = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckObjectPublicPropertiesDifferent(historicalJob, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑁ╃⩅ⅇ⹉ⵋ㩍㽏⁑", a_));
			this.RawData = historicalJob.RawData;
			global::System.Collections.Generic.IEnumerator<string> enumerator = list.GetEnumerator();
			try
			{
				num = (short)22937601;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_19F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_12B;
						}
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1290928132;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						string propertyName = enumerator.Current;
						this.RaisePropertyChanged(propertyName);
						num = (short)156499970;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)122355712;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_153:
					num = (short)835125251;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_12B:
					goto IL_153;
				}
				IL_19F:;
			}
			finally
			{
				num = (short)915472384;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1D3;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)342360066;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_208;
					}
					IL_1D3:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1617690625;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_208:;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000970D8 File Offset: 0x000952D8
		public override string ToString()
		{
			short num = (short)921460598;
			short num2 = num;
			num = (short)1235705718;
			switch (num2 == num)
			{
			}
			num = (short)1220345857;
			if (num != 0)
			{
			}
			num = (short)760676352;
			if (num != 0)
			{
			}
			num = (short)1242693632;
			short num3 = num;
			return this.SuperJobName;
		}

		// Token: 0x04000394 RID: 916
		private string a;

		// Token: 0x04000395 RID: 917
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob b;

		// Token: 0x04000396 RID: 918
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? c;
	}
}
