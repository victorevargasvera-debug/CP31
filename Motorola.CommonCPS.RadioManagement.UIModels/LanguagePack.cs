using System;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E1 RID: 225
	public class LanguagePack : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x06000AA3 RID: 2723 RVA: 0x000A0E48 File Offset: 0x0009F048
		public LanguagePack() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000A0E60 File Offset: 0x0009F060
		public LanguagePack(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000A0E74 File Offset: 0x0009F074
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000A10C0 File Offset: 0x0009F2C0
		public string Locale
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_38;
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
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary;
						result = astrolanguagePackSummary.LpID;
						num2 = (short)1958281218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary;
						if (!string.IsNullOrEmpty(astrolanguagePackSummary.LpID))
						{
							num2 = (short)129040384;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 2:
						goto IL_1F2;
					case 3:
						goto IL_213;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
						result = pcrlanguagePackSummary.LpID;
						num2 = (short)754778115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
					{
						num2 = (short)1556264636;
						short num3 = num2;
						num2 = (short)862500540;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BA;
						default:
						{
							num2 = (short)743768064;
							if (num2 != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary;
							num2 = (short)904921095;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 6:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary)
						{
							num2 = (short)346816517;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)504561672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
						if (!string.IsNullOrEmpty(pcrlanguagePackSummary.LpID))
						{
							goto IL_1BA;
						}
						return result;
					}
					case 8:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)596901897;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 9:
					{
						num2 = (short)488570880;
						short num4 = num2;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary;
						num2 = (short)1711996929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_38;
					IL_1BA:
					num2 = (short)691929092;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1F2:
				return result;
				IL_213:
				num2 = (short)1591017473;
				if (num2 != 0)
				{
				}
				return result;
				IL_38:
				result = string.Empty;
				num2 = (short)2051342342;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1173291009;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary;
						astrolanguagePackSummary.LpID = value;
						num = (short)1991300318;
						short num3 = num;
						num = (short)693490910;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13E;
						default:
						{
							num = (short)601948160;
							if (num != 0)
							{
							}
							num = (short)974716928;
							short num4 = num;
							num = (short)1205075972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_82;
					case 4:
						return;
					}
					IL_38:
					num = (short)987824129;
					if (num != 0)
					{
					}
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary)
					{
						num = (short)1373503491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)703397888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E:
					if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary))
					{
						return;
					}
					num = (short)2000683010;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_82:
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary;
				pcrlanguagePackSummary.LpID = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000A124C File Offset: 0x0009F44C
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x000A1490 File Offset: 0x0009F690
		public string Version
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_38;
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
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary;
						result = astrolanguagePackSummary.PackageVersion;
						num2 = (short)1473052674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary;
						if (!string.IsNullOrEmpty(astrolanguagePackSummary.PackageVersion))
						{
							num2 = (short)1836646400;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 2:
						return result;
					case 3:
						return result;
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
						result = pcrlanguagePackSummary.PackageVersion;
						num2 = (short)1999634435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
					{
						num2 = (short)792165437;
						short num3 = num2;
						num2 = (short)1758624829;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DC;
						default:
						{
							num2 = (short)1545928704;
							if (num2 != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary;
							num2 = (short)82116609;
							if (num2 != 0)
							{
							}
							num2 = (short)913375239;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 6:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary)
						{
							num2 = (short)1109786629;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)57409544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
						if (!string.IsNullOrEmpty(pcrlanguagePackSummary.PackageVersion))
						{
							goto IL_1DC;
						}
						return result;
					}
					case 8:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)969211913;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 9:
					{
						num2 = (short)587661312;
						short num4 = num2;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary;
						num2 = (short)1839857665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_38;
					IL_1DC:
					num2 = (short)902299652;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_38:
				result = string.Empty;
				num2 = (short)266928134;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)43515908;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)198639616;
						short num3 = num;
						value = string.Empty;
						num = (short)766836743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)2108882945;
						if (num != 0)
						{
						}
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							goto IL_D6;
						}
						return;
					case 2:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary)
						{
							num = (short)2002518019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1596784641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1DC;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 5:
						goto IL_19B;
					case 6:
					{
						num = (short)1148574782;
						short num4 = num;
						num = (short)1449188414;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6;
						default:
						{
							num = (short)105644032;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary astrolanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary;
							astrolanguagePackSummary.PackageVersion = value;
							num = (short)1789329413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						goto IL_19D;
					}
					IL_45:
					if (value == null)
					{
						num = (short)2018050048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19D;
					IL_D6:
					num = (short)1641611270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19D:
					num = (short)800980994;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19B:
				return;
				IL_1DC:
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary;
				pcrlanguagePackSummary.PackageVersion = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000A1680 File Offset: 0x0009F880
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x000A1764 File Offset: 0x0009F964
		public int Size
		{
			get
			{
				short num = (short)2004541792;
				short num2 = num;
				num = (short)1524752736;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B5;
				case 1:
					break;
				default:
				{
					num = (short)478543872;
					short num3 = num;
					break;
				}
				}
				num = (short)198967297;
				if (num != 0)
				{
				}
				num = (short)787415040;
				if (num != 0)
				{
				}
				if (base.SummaryEntity.FileSize == null)
				{
					return 0;
				}
				IL_B5:
				return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
			}
			set
			{
				short num = (short)356160129;
				short num2 = num;
				num = (short)1694339713;
				switch (num2 == num)
				{
				}
				num = (short)426573824;
				if (num != 0)
				{
				}
				num = (short)583008256;
				short num3 = num;
				num = (short)1660420097;
				if (num != 0)
				{
				}
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000A182C File Offset: 0x0009FA2C
		public string LanguageFamily
		{
			get
			{
				short num = (short)1108279297;
				if (num != 0)
				{
				}
				num = (short)640548864;
				short num2 = num;
				num = (short)102224253;
				short num3 = num;
				num = (short)1161286013;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)495845376;
					if (num != 0)
					{
					}
					if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary)
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary;
						return global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack.a(pcrlanguagePackSummary.LanguagePackFamily);
					}
					break;
				}
				return string.Empty;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x000A1904 File Offset: 0x0009FB04
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x000A19C8 File Offset: 0x0009FBC8
		public string PAC
		{
			get
			{
				short num = (short)1756853103;
				short num2 = num;
				num = (short)781284207;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8A;
				case 1:
					break;
				default:
				{
					num = (short)802816000;
					short num3 = num;
					break;
				}
				}
				num = (short)1693712384;
				if (num != 0)
				{
				}
				if (!string.IsNullOrEmpty(this.b))
				{
					return this.b;
				}
				IL_8A:
				num = (short)1342308353;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			set
			{
				short num = (short)993319172;
				short num2 = num;
				num = (short)587258116;
				switch (num2 == num)
				{
				}
				num = (short)615972864;
				if (num != 0)
				{
				}
				num = (short)709427200;
				short num3 = num;
				num = (short)264962049;
				if (num != 0)
				{
				}
				this.b = (value ?? string.Empty);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000A1A88 File Offset: 0x0009FC88
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x000A1B4C File Offset: 0x0009FD4C
		public string Language
		{
			get
			{
				short num = (short)701431809;
				if (num != 0)
				{
				}
				num = (short)417005568;
				short num2 = num;
				num = (short)1029733426;
				short num3 = num;
				num = (short)599358514;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1429012480;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(this.a))
					{
						return string.Empty;
					}
					break;
				}
				return this.a;
			}
			set
			{
				short num = (short)943194113;
				if (num != 0)
				{
				}
				num = (short)1136665185;
				short num2 = num;
				num = (short)745022049;
				switch (num2 == num)
				{
				}
				num = (short)125173760;
				short num3 = num;
				num = (short)1800667136;
				if (num != 0)
				{
				}
				this.a = (value ?? string.Empty);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000A1C08 File Offset: 0x0009FE08
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000A1DAC File Offset: 0x0009FFAC
		public int ReferencesInTemplateRadios
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				int result;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_62;
					case 1:
						result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInTemplateRadios;
						num2 = (short)2082799620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						if (pcrlanguagePackSummary != null)
						{
							num2 = (short)2069299200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)184104709;
						short num3 = num2;
						num2 = (short)1282815749;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
						{
							num2 = (short)860422145;
							if (num2 != 0)
							{
							}
							num2 = (short)2116812800;
							if (num2 != 0)
							{
							}
							num2 = (short)1830486016;
							short num4 = num2;
							num2 = (short)957284357;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						return result;
					case 4:
						return result;
					case 5:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)1482227713;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_28;
					IL_62:
					result = pcrlanguagePackSummary.ReferenceCountInTemplateRadios;
					num2 = (short)896139267;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_28:
				result = 0;
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)2068971522;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1889796097;
						if (num2 != 0)
						{
						}
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)494927872;
							short num3 = num2;
							num2 = (short)394854402;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						if (pcrlanguagePackSummary == null)
						{
							num2 = (short)61276160;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1126565692;
						short num4 = num2;
						num2 = (short)79103804;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)596705280;
							if (num2 != 0)
							{
							}
							num2 = (short)1443954691;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInTemplateRadios = value;
						num2 = (short)744161284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_AE;
					case 4:
						return;
					}
					goto IL_24;
				}
				IL_AE:
				pcrlanguagePackSummary.ReferenceCountInTemplateRadios = value;
				return;
				IL_24:
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)256114689;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000A1F34 File Offset: 0x000A0134
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000A20D8 File Offset: 0x000A02D8
		public int ReferencesInConfigurationRadios
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				int result;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_62;
					case 1:
						result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios;
						num2 = (short)1154809860;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						if (pcrlanguagePackSummary != null)
						{
							num2 = (short)2137587712;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)543650005;
						short num3 = num2;
						num2 = (short)1477341397;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
						{
							num2 = (short)2034302977;
							if (num2 != 0)
							{
							}
							num2 = (short)992346112;
							if (num2 != 0)
							{
							}
							num2 = (short)1075380224;
							short num4 = num2;
							num2 = (short)1836253189;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						return result;
					case 4:
						return result;
					case 5:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)35848193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_28;
					IL_62:
					result = pcrlanguagePackSummary.ReferenceCountInConfigurationRadios;
					num2 = (short)359530499;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_28:
				result = 0;
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)1343684610;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)912326656;
							short num3 = num2;
							num2 = (short)1833697282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						if (pcrlanguagePackSummary == null)
						{
							num2 = (short)1919942656;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1951399628;
						short num4 = num2;
						num2 = (short)1688403660;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)2127364096;
							if (num2 != 0)
							{
							}
							num2 = (short)1202257923;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios = value;
						num2 = (short)1434648577;
						if (num2 != 0)
						{
						}
						num2 = (short)2021261316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_AD;
					case 4:
						return;
					}
					goto IL_24;
				}
				IL_AD:
				pcrlanguagePackSummary.ReferenceCountInConfigurationRadios = value;
				return;
				IL_24:
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)1060962305;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000A2260 File Offset: 0x000A0460
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000A2404 File Offset: 0x000A0604
		public int ReferencesInTemplate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				int result;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_64;
					case 1:
						result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInTemplate;
						num2 = (short)1467875332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						if (pcrlanguagePackSummary != null)
						{
							num2 = (short)1317011456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)59990315;
						short num3 = num2;
						num2 = (short)1947033899;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_64;
						default:
							num2 = (short)323551232;
							if (num2 != 0)
							{
							}
							num2 = (short)1555562501;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return result;
					case 4:
						return result;
					case 5:
					{
						num2 = (short)739573760;
						short num4 = num2;
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)540803073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					goto IL_28;
					IL_64:
					num2 = (short)1887764481;
					if (num2 != 0)
					{
					}
					result = pcrlanguagePackSummary.ReferenceCountInTemplate;
					num2 = (short)479330307;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_28:
				result = 0;
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)1361051650;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary pcrlanguagePackSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)
						{
							num2 = (short)901775360;
							short num3 = num2;
							num2 = (short)983302146;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						if (pcrlanguagePackSummary == null)
						{
							num2 = (short)603979776;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1788715047;
						short num4 = num2;
						num2 = (short)298623015;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)640745472;
							if (num2 != 0)
							{
							}
							num2 = (short)440205315;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary)base.SummaryEntity).ReferenceCountInTemplate = value;
						num2 = (short)1297481732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_AC;
					case 4:
						return;
					}
					goto IL_24;
				}
				IL_AC:
				num2 = (short)2021982209;
				if (num2 != 0)
				{
				}
				pcrlanguagePackSummary.ReferenceCountInTemplate = value;
				return;
				IL_24:
				pcrlanguagePackSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary);
				num2 = (short)1971322881;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000A2588 File Offset: 0x000A0788
		private static string a(int? A_0)
		{
			short num = (short)1706557443;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B1;
				case 1:
				{
					int valueOrDefault;
					switch (valueOrDefault)
					{
					case 0:
						goto IL_114;
					case 1:
						goto IL_16C;
					case 2:
						goto IL_B3;
					default:
						num = (short)85721090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1599406085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 4:
				{
					int valueOrDefault = A_0.GetValueOrDefault();
					num = (short)603979777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_D0;
				case 6:
					if (A_0 != null)
					{
						num = (short)630652932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				}
				IL_40:
				num = (short)1223426049;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					num = (short)271712256;
					short num3 = num;
					num = (short)92340224;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1865744390;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B1:
			num = (short)778452029;
			short num4 = num;
			num = (short)146095165;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D0:
				goto IL_1C0;
			default:
				num = (short)227934208;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			IL_B3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Malta;
			IL_114:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Trbo;
			IL_16C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Paradise;
			IL_1C0:
			return string.Empty;
		}

		// Token: 0x040003E8 RID: 1000
		private string a;

		// Token: 0x040003E9 RID: 1001
		private string b;
	}
}
