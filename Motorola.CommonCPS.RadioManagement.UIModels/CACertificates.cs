using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000045 RID: 69
	public class CACertificates : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0001870C File Offset: 0x0001690C
		public CACertificates() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00018724 File Offset: 0x00016924
		public CACertificates(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00018738 File Offset: 0x00016938
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0001881C File Offset: 0x00016A1C
		public int Size
		{
			get
			{
				if (base.SummaryEntity.FileSize == null)
				{
					short num = (short)1342361670;
					short num2 = num;
					num = (short)189124678;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return 0;
					case 1:
						break;
					default:
					{
						num = (short)1617887232;
						short num3 = num;
						break;
					}
					}
					num = (short)58982400;
					if (num != 0)
					{
					}
					num = (short)1430257665;
					if (num != 0)
					{
					}
					return 0;
				}
				return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
			}
			set
			{
				short num = (short)581941179;
				short num2 = num;
				num = (short)754300859;
				switch (num2 == num)
				{
				}
				num = (short)650182656;
				short num3 = num;
				num = (short)1308557312;
				if (num != 0)
				{
				}
				num = (short)334692353;
				if (num != 0)
				{
				}
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000188E4 File Offset: 0x00016AE4
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00018A14 File Offset: 0x00016C14
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
				short num2;
				int result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_F7;
					case 1:
						goto IL_CD;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							goto IL_F9;
						}
						num2 = (short)1750401024;
						short num3 = num2;
						num2 = (short)481048138;
						short num4 = num2;
						num2 = (short)1159673418;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CD;
						default:
							num2 = (short)878247936;
							if (num2 != 0)
							{
							}
							num2 = (short)115343361;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_CD:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios;
					num2 = (short)2094596096;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_F7:
				IL_F9:
				num2 = (short)138412033;
				if (num2 != 0)
				{
				}
				return result;
				IL_1C:
				result = 0;
				num2 = (short)1130692610;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				int num2;
				for (;;)
				{
					IL_0A:
					num = (short)486277121;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_102;
					case 2:
					{
						num = (short)1811152896;
						short num3 = num;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							return;
						}
						num = (short)313688308;
						short num4 = num;
						num = (short)1235452148;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_102;
						default:
							num = (short)604045312;
							if (num != 0)
							{
							}
							num = (short)1090060289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_45;
					IL_102:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios = value;
					num = (short)1350238208;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_45:
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary;
				num = (short)848953346;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00018B50 File Offset: 0x00016D50
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00018C80 File Offset: 0x00016E80
		public int ReferencesInTemplateRadios
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
						goto IL_F5;
					case 2:
					{
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							return result;
						}
						num2 = (short)1068171264;
						short num3 = num2;
						num2 = (short)532596821;
						short num4 = num2;
						num2 = (short)1938212949;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F5;
						default:
							num2 = (short)1337393152;
							if (num2 != 0)
							{
							}
							num2 = (short)519831553;
							if (num2 != 0)
							{
							}
							num2 = (short)942997505;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_F5:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInTemplateRadios;
					num2 = (short)1505361920;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_1C:
				result = 0;
				num2 = (short)1871446018;
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
						goto IL_FC;
					case 2:
					{
						num2 = (short)691208193;
						if (num2 != 0)
						{
						}
						num2 = (short)1642135552;
						short num3 = num2;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							return;
						}
						num2 = (short)1791487143;
						short num4 = num2;
						num2 = (short)1750264999;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC;
						default:
							num2 = (short)182190080;
							if (num2 != 0)
							{
							}
							num2 = (short)1515520001;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_FC:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInTemplateRadios = value;
					num2 = (short)351272960;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary;
				num2 = (short)364314626;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00018DB8 File Offset: 0x00016FB8
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00018EEC File Offset: 0x000170EC
		public int ReferencesInTemplate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num2;
				int result;
				for (;;)
				{
					IL_0A:
					num = (short)1610416129;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						goto IL_F7;
					case 2:
					{
						num = (short)1771241472;
						short num3 = num;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							return result;
						}
						num = (short)1109980135;
						short num4 = num;
						num = (short)2088367079;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							num = (short)1509031936;
							if (num != 0)
							{
							}
							num = (short)535691265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_44;
					IL_F7:
					result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInTemplate;
					num = (short)1546190848;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_44:
				result = 0;
				num = (short)698155010;
				num2 = (int)((global::System.IntPtr)num);
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
						num2 = (short)1948909569;
						if (num2 != 0)
						{
						}
						num2 = (short)1235419136;
						short num3 = num2;
						if (!(base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))
						{
							return;
						}
						num2 = (short)1912955574;
						short num4 = num2;
						num2 = (short)831152822;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_100;
						default:
							num2 = (short)432406528;
							if (num2 != 0)
							{
							}
							num2 = (short)1076559873;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_100:
					((global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary)base.SummaryEntity).ReferenceCountInTemplate = value;
					num2 = (short)1610612736;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary astrocacertificatesSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary;
				num2 = (short)862388226;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00019028 File Offset: 0x00017228
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x000190D8 File Offset: 0x000172D8
		public string PAC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1267737288;
				short num2 = num;
				num = (short)105456328;
				switch (num2 == num)
				{
				}
				num = (short)715784192;
				short num3 = num;
				num = (short)1882456065;
				if (num != 0)
				{
				}
				num = (short)40501248;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)511375708;
				short num2 = num;
				num = (short)1406663004;
				switch (num2 == num)
				{
				}
				num = (short)1634336768;
				short num3 = num;
				num = (short)2054356992;
				if (num != 0)
				{
				}
				num = (short)1032388609;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x040000BC RID: 188
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
