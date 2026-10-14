using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E2 RID: 226
	public class VoiceAnnouncement : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x06000AB7 RID: 2743 RVA: 0x000A275C File Offset: 0x000A095C
		public VoiceAnnouncement() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000A2774 File Offset: 0x000A0974
		public VoiceAnnouncement(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000A2788 File Offset: 0x000A0988
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x000A2870 File Offset: 0x000A0A70
		public int Size
		{
			get
			{
				if (base.SummaryEntity.FileSize == null)
				{
					short num = (short)1757256117;
					short num2 = num;
					num = (short)324704693;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)796852225;
						if (num != 0)
						{
						}
						num = (short)2115960832;
						short num3 = num;
						num = (short)666828800;
						if (num != 0)
						{
						}
						break;
					}
					}
					return 0;
				}
				return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
			}
			set
			{
				short num = (short)706726604;
				short num2 = num;
				num = (short)2069547724;
				switch (num2 == num)
				{
				}
				num = (short)1823997952;
				short num3 = num;
				num = (short)533463040;
				if (num != 0)
				{
				}
				num = (short)1605894145;
				if (num != 0)
				{
				}
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000A2934 File Offset: 0x000A0B34
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000A2AD8 File Offset: 0x000A0CD8
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
				short num2;
				int result;
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num2 = (short)1361117188;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num2 = (short)290717701;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10E;
					case 4:
					{
						num2 = (short)1792200979;
						short num3 = num2;
						num2 = (short)140300563;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10E;
						default:
							num2 = (short)1668022272;
							if (num2 != 0)
							{
							}
							result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios;
							num2 = (short)1659174914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 5:
						result = pcrvoiceAnnouncementSummary.ReferenceCountInConfigurationRadios;
						num2 = (short)956301313;
						if (num2 != 0)
						{
						}
						num2 = (short)758775809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28;
					IL_10E:
					num2 = (short)1026293760;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_28:
				result = 0;
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num2 = (short)427687936;
				short num4 = num2;
				num2 = (short)1799684099;
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
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInConfigurationRadios = value;
						num2 = (short)446148520;
						short num3 = num2;
						num2 = (short)224374696;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1074593792;
							if (num2 != 0)
							{
							}
							num2 = (short)129499136;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num2 = (short)1645084673;
							if (num2 != 0)
							{
							}
							num2 = (short)433258496;
							short num4 = num2;
							num2 = (short)670040068;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1121976323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num2 = (short)1763704833;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						goto IL_B4;
					}
					goto IL_24;
				}
				IL_B4:
				pcrvoiceAnnouncementSummary.ReferenceCountInConfigurationRadios = value;
				return;
				IL_24:
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num2 = (short)238747650;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x000A2C5C File Offset: 0x000A0E5C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x000A2E04 File Offset: 0x000A1004
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
				short num2;
				int result;
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num2 = (short)530579460;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num2 = (short)1441529861;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10E;
					case 4:
					{
						num2 = (short)1817575425;
						if (num2 != 0)
						{
						}
						num2 = (short)1357260826;
						short num3 = num2;
						num2 = (short)1680091162;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10E;
						default:
							num2 = (short)1692860416;
							if (num2 != 0)
							{
							}
							result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInTemplateRadios;
							num2 = (short)1264517122;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 5:
						result = pcrvoiceAnnouncementSummary.ReferenceCountInTemplateRadios;
						num2 = (short)864944129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28;
					IL_10E:
					num2 = (short)2034958336;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
				IL_28:
				result = 0;
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num2 = (short)1612447744;
				short num4 = num2;
				num2 = (short)24051715;
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
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInTemplateRadios = value;
						num2 = (short)879189709;
						short num3 = num2;
						num2 = (short)2136497869;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)865992704;
							if (num2 != 0)
							{
							}
							num2 = (short)1598357504;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num2 = (short)473300993;
							if (num2 != 0)
							{
							}
							num2 = (short)378011648;
							short num4 = num2;
							num2 = (short)1999962116;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1320419331;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num2 = (short)1058799617;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						goto IL_B5;
					}
					goto IL_24;
				}
				IL_B5:
				pcrvoiceAnnouncementSummary.ReferenceCountInTemplateRadios = value;
				return;
				IL_24:
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num2 = (short)356974594;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x000A2F8C File Offset: 0x000A118C
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x000A3134 File Offset: 0x000A1334
		public int ReferencesInTemplate
		{
			get
			{
				short num = (short)2093350913;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				int num2;
				int result;
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num = (short)42139652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num = (short)1680146437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 4:
					{
						num = (short)1565667962;
						short num3 = num;
						num = (short)853095034;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
							num = (short)926416896;
							if (num != 0)
							{
							}
							result = ((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInTemplate;
							num = (short)1965096962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						result = pcrvoiceAnnouncementSummary.ReferenceCountInTemplate;
						num = (short)1468530689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4F;
					IL_137:
					num = (short)37027840;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_4F:
				num = (short)535756800;
				short num4 = num;
				result = 0;
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num = (short)214106115;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
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
				global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary pcrvoiceAnnouncementSummary;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						((global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)base.SummaryEntity).ReferenceCountInTemplate = value;
						num2 = (short)970847786;
						short num3 = num2;
						num2 = (short)286848554;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)756482049;
							if (num2 != 0)
							{
							}
							num2 = (short)1165950976;
							if (num2 != 0)
							{
							}
							num2 = (short)1320681472;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (pcrvoiceAnnouncementSummary != null)
						{
							num2 = (short)1969356804;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)369623043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (base.SummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary)
						{
							num2 = (short)2070085633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						goto IL_5F;
					}
					goto IL_24;
				}
				IL_5F:
				num2 = (short)1622278144;
				short num4 = num2;
				pcrvoiceAnnouncementSummary.ReferenceCountInTemplate = value;
				return;
				IL_24:
				pcrvoiceAnnouncementSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary);
				num2 = (short)1668087810;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000A32B4 File Offset: 0x000A14B4
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x000A3364 File Offset: 0x000A1564
		public string PAC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1746075649;
				if (num != 0)
				{
				}
				num = (short)1666533685;
				short num2 = num;
				num = (short)256461109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288896512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)490143744;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)613284078;
				short num2 = num;
				num = (short)1524431086;
				switch (num2 == num)
				{
				}
				num = (short)1745420288;
				short num3 = num;
				num = (short)402456577;
				if (num != 0)
				{
				}
				num = (short)350093312;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x040003EA RID: 1002
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
