using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000046 RID: 70
	public class DVRSFiles : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00019188 File Offset: 0x00017388
		public DVRSFiles() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000191A0 File Offset: 0x000173A0
		public DVRSFiles(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000191B4 File Offset: 0x000173B4
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00019298 File Offset: 0x00017498
		public int Size
		{
			get
			{
				while (base.SummaryEntity.FileSize != null)
				{
					short num = (short)2083041994;
					short num2 = num;
					num = (short)131969738;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1580466176;
						short num3 = num;
						num = (short)1153892353;
						if (num != 0)
						{
						}
						num = (short)825556992;
						if (num != 0)
						{
						}
						return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
					}
					}
				}
				return 0;
			}
			set
			{
				short num = (short)1590596004;
				short num2 = num;
				num = (short)1960939940;
				switch (num2 == num)
				{
				}
				num = (short)504627200;
				short num3 = num;
				num = (short)258998273;
				if (num != 0)
				{
				}
				num = (short)406126592;
				if (num != 0)
				{
				}
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00019360 File Offset: 0x00017560
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00019494 File Offset: 0x00017694
		public int ReferencesInConfigurationRadios
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				int result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_F7;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)1554710528;
						short num3 = num2;
						num2 = (short)1061767000;
						short num4 = num2;
						num2 = (short)1470449496;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							num2 = (short)1856831488;
							if (num2 != 0)
							{
							}
							num2 = (short)1957101569;
							if (num2 != 0)
							{
							}
							num2 = (short)1204289537;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_F7:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios;
					num2 = (short)235929600;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				result = 0;
				num2 = (short)324861954;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_100;
					case 1:
						goto IL_D5;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num2 = (short)869466112;
						short num3 = num2;
						num2 = (short)1747629236;
						short num4 = num2;
						num2 = (short)561493172;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D5;
						default:
							num2 = (short)109838336;
							if (num2 != 0)
							{
							}
							num2 = (short)660537345;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_D5:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios = value;
					num2 = (short)678690816;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_100:
				num2 = (short)416219137;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num2 = (short)688390146;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000195CC File Offset: 0x000177CC
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00019700 File Offset: 0x00017900
		public int ReferencesInTemplateRadios
		{
			get
			{
				short num = (short)2134835201;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				int result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						goto IL_F6;
					case 2:
					{
						num = (short)1090846720;
						short num3 = num;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num = (short)2033898680;
						short num4 = num;
						num = (short)823252152;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F6;
						default:
							num = (short)929955840;
							if (num != 0)
							{
							}
							num = (short)1397358593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_42;
					IL_F6:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInTemplateRadios;
					num = (short)1908670464;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_42:
				result = 0;
				num = (short)1430454274;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_105;
					case 2:
					{
						num2 = (short)377159681;
						if (num2 != 0)
						{
						}
						num2 = (short)526123008;
						short num3 = num2;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num2 = (short)1705336600;
						short num4 = num2;
						num2 = (short)592535320;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_105;
						default:
							num2 = (short)93585408;
							if (num2 != 0)
							{
							}
							num2 = (short)1503723521;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_105:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInTemplateRadios = value;
					num2 = (short)1569456128;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num2 = (short)831455234;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00019840 File Offset: 0x00017A40
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00019974 File Offset: 0x00017B74
		public int ReferencesInTemplate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				int result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_F7;
					case 2:
					{
						num2 = (short)818282496;
						short num3 = num2;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)1253667509;
						short num4 = num2;
						num2 = (short)2124509877;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							num2 = (short)1039073280;
							if (num2 != 0)
							{
							}
							num2 = (short)1635713025;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_F7:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInTemplate;
					num2 = (short)10616832;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				num2 = (short)1290797057;
				if (num2 != 0)
				{
				}
				result = 0;
				num2 = (short)156762114;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_105;
					case 1:
						goto IL_DA;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							goto IL_107;
						}
						num2 = (short)1308098560;
						short num3 = num2;
						num2 = (short)278191717;
						short num4 = num2;
						num2 = (short)1307434597;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DA;
						default:
							num2 = (short)282787840;
							if (num2 != 0)
							{
							}
							num2 = (short)986382337;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_DA:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ReferenceCountInTemplate = value;
					num2 = (short)1154220032;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_105:
				IL_107:
				num2 = (short)1780875265;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num2 = (short)85983234;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00019AB0 File Offset: 0x00017CB0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00019C28 File Offset: 0x00017E28
		public string DVRSFileHash
		{
			get
			{
				int a_ = 12;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				string result;
				short num2;
				long? dvrsfileHash;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_109;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)260833280;
						short num3 = num2;
						num2 = (short)1629814785;
						if (num2 != 0)
						{
						}
						num2 = (short)1492574303;
						short num4 = num2;
						num2 = (short)154198111;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_109;
						default:
							num2 = (short)1672151040;
							if (num2 != 0)
							{
							}
							num2 = (short)764084225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_25;
					IL_109:
					dvrsfileHash = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRSFileHash;
					result = global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("睆ㅈ", a_) + dvrsfileHash.Value.ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("὆", a_));
					num2 = (short)1083703296;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_25:
				dvrsfileHash = new long?(0L);
				result = string.Empty;
				num2 = (short)1503920130;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_D7;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num2 = (short)2072117248;
						short num3 = num2;
						num2 = (short)591253767;
						short num4 = num2;
						num2 = (short)80990471;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D7;
						default:
							num2 = (short)186712064;
							if (num2 != 0)
							{
							}
							num2 = (short)1538457601;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_D7:
					num2 = (short)1666777089;
					if (num2 != 0)
					{
					}
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRSFileHash = new long?(global::System.Convert.ToInt64(value));
					num2 = (short)66191360;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num2 = (short)908984322;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00019D6C File Offset: 0x00017F6C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00019EB4 File Offset: 0x000180B4
		public string DVRSTimestamp
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_D5;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)1014824960;
						short num3 = num2;
						num2 = (short)708317073;
						short num4 = num2;
						num2 = (short)390074257;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D5;
						default:
							num2 = (short)1208614912;
							if (num2 != 0)
							{
							}
							num2 = (short)104529921;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_D5:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRSTimestamp.Value.ToString();
					num2 = (short)1617166337;
					if (num2 != 0)
					{
					}
					num2 = (short)568393728;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				result = string.Empty;
				num2 = (short)767885314;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				for (;;)
				{
					IL_0A:
					num = (short)2088501249;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_FE;
					case 2:
					{
						num = (short)312672256;
						short num3 = num;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num = (short)1384906552;
						short num4 = num;
						num = (short)2040069944;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FE;
						default:
							num = (short)2077097984;
							if (num != 0)
							{
							}
							num = (short)242941953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_43;
					IL_FE:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRSTimestamp = new global::System.DateTime?(global::System.DateTime.Parse(value));
					num = (short)707592192;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num = (short)874905602;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00019FF8 File Offset: 0x000181F8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0001A134 File Offset: 0x00018334
		public string ConfigDataName
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_FA;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)505413632;
						short num3 = num2;
						num2 = (short)1675601571;
						short num4 = num2;
						num2 = (short)1466541731;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FA;
						default:
							num2 = (short)1842151425;
							if (num2 != 0)
							{
							}
							num2 = (short)539099136;
							if (num2 != 0)
							{
							}
							num2 = (short)105644033;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_FA:
					string configDataName = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ConfigDataName;
					result = configDataName.ToString();
					num2 = (short)209059840;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				result = string.Empty;
				num2 = (short)720437250;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_100;
					case 2:
					{
						num2 = (short)1848049664;
						short num3 = num2;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num2 = (short)1655720120;
						short num4 = num2;
						num2 = (short)1724532920;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_100;
						default:
							num2 = (short)455409664;
							if (num2 != 0)
							{
							}
							num2 = (short)722993153;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_100:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).ConfigDataName = value;
					num2 = (short)1061814272;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num2 = (short)495321089;
				if (num2 != 0)
				{
				}
				num2 = (short)136183810;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001A270 File Offset: 0x00018470
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001A3A8 File Offset: 0x000185A8
		public string DVRType
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_F7;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return result;
						}
						num2 = (short)1326120960;
						short num3 = num2;
						num2 = (short)479292279;
						short num4 = num2;
						num2 = (short)163801975;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							num2 = (short)991297537;
							if (num2 != 0)
							{
							}
							num2 = (short)595066880;
							if (num2 != 0)
							{
							}
							num2 = (short)841089025;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_F7:
					string dvrtype = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRType;
					result = dvrtype.ToString();
					num2 = (short)1845821440;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				result = string.Empty;
				num2 = (short)1787363330;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				for (;;)
				{
					IL_0A:
					num = (short)96337921;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_FF;
					case 2:
					{
						num = (short)1017905152;
						short num3 = num;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))
						{
							return;
						}
						num = (short)1625447232;
						short num4 = num;
						num = (short)808934208;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FF;
						default:
							num = (short)2138636288;
							if (num != 0)
							{
							}
							num = (short)62849025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_43;
					IL_FF:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).DVRType = value;
					num = (short)1839005696;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
				num = (short)1655046146;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001A4E4 File Offset: 0x000186E4
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0001A69C File Offset: 0x0001889C
		public string DVRSFileVersion
		{
			get
			{
				int a_ = 3;
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						goto IL_BE;
					case 2:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)
						{
							num2 = (short)1694957573;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
					{
						num2 = (short)658997622;
						short num3 = num2;
						num2 = (short)5013878;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A6;
						default:
							num2 = (short)1388707840;
							if (num2 != 0)
							{
							}
							result = global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("༽", a_);
							num2 = (short)900726784;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
					{
						string packageVersion;
						if (packageVersion == null)
						{
							num2 = (short)1961885699;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = packageVersion.ToString();
						goto IL_A6;
					}
					case 5:
					{
						string packageVersion = ((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).PackageVersion;
						num2 = (short)231931908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_31;
					IL_A6:
					num2 = (short)737148929;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_BE:
				num2 = (short)798162944;
				short num4 = num2;
				return result;
				IL_31:
				result = string.Empty;
				num2 = (short)419168257;
				if (num2 != 0)
				{
				}
				num2 = (short)2104098818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1978007552;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					int num3;
					for (;;)
					{
						IL_33:
						switch (num3)
						{
						case 0:
							if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)
							{
								num = (short)1630666753;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
						{
							((global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary)base.SummaryEntity).PackageVersion = value;
							num = (short)1560323699;
							short num4 = num;
							num = (short)825599603;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)131596288;
								if (num != 0)
								{
								}
								num = (short)944111618;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						break;
					}
					IL_45:
					global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary astrodvrsfilesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary;
					num = (short)1015087105;
					if (num != 0)
					{
					}
					num = (short)1192165376;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0001A7D4 File Offset: 0x000189D4
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0001A884 File Offset: 0x00018A84
		public string PAC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1139736577;
				if (num != 0)
				{
				}
				num = (short)777571438;
				short num2 = num;
				num = (short)1949224046;
				switch (num2 == num)
				{
				}
				num = (short)619380736;
				if (num != 0)
				{
				}
				num = (short)1122631680;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1637089281;
				if (num != 0)
				{
				}
				num = (short)1655251459;
				short num2 = num;
				num = (short)1430462979;
				switch (num2 == num)
				{
				}
				num = (short)2108817408;
				if (num != 0)
				{
				}
				num = (short)1458896896;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x040000BD RID: 189
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
