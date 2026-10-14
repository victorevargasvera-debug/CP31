using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A3 RID: 163
	public class TextToSpeech : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x000562A8 File Offset: 0x000544A8
		public TextToSpeech() : base(new global::Motorola.CommonCPS.Server.EntityModel.PackageSummary())
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000562C0 File Offset: 0x000544C0
		public TextToSpeech(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary) : base(summary)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x000562D4 File Offset: 0x000544D4
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x000563B4 File Offset: 0x000545B4
		public int Size
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)95485952;
					short num2 = num;
					if (base.SummaryEntity.FileSize != null)
					{
						goto IL_B4;
					}
					num = (short)207486977;
					if (num != 0)
					{
					}
					num = (short)1541087855;
					short num3 = num;
					num = (short)1421222511;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9B;
					}
				}
				IL_9B:
				num = (short)290324480;
				if (num != 0)
				{
				}
				return 0;
				IL_B4:
				return (base.SummaryEntity.FileSize.Value + 1023) / 1024;
			}
			set
			{
				short num = (short)769965306;
				short num2 = num;
				num = (short)413711610;
				switch (num2 == num)
				{
				}
				num = (short)2087583744;
				if (num != 0)
				{
				}
				num = (short)321650689;
				if (num != 0)
				{
				}
				num = (short)994902016;
				short num3 = num;
				base.SummaryEntity.FileSize = new int?(value * 1024 - 1023);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0005647C File Offset: 0x0005467C
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00056538 File Offset: 0x00054738
		public string LanguageID
		{
			get
			{
				short num = (short)831469535;
				short num2 = num;
				num = (short)1132476383;
				switch (num2 == num)
				{
				}
				num = (short)1829765120;
				if (num != 0)
				{
				}
				num = (short)176750593;
				if (num != 0)
				{
				}
				num = (short)1462370304;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				return pcrtextToSpeechSummary.LanguageID;
			}
			set
			{
				short num = (short)503924611;
				short num2 = num;
				num = (short)1745438595;
				switch (num2 == num)
				{
				}
				num = (short)1028718593;
				if (num != 0)
				{
				}
				num = (short)536281088;
				if (num != 0)
				{
				}
				num = (short)1351483392;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				pcrtextToSpeechSummary.LanguageID = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x000565F4 File Offset: 0x000547F4
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x000566B0 File Offset: 0x000548B0
		public string SpeakerName
		{
			get
			{
				short num = (short)408780187;
				short num2 = num;
				num = (short)1359838619;
				switch (num2 == num)
				{
				}
				num = (short)32440321;
				if (num != 0)
				{
				}
				num = (short)937426944;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				return pcrtextToSpeechSummary.SpeakerName;
			}
			set
			{
				short num = (short)1455183698;
				short num2 = num;
				num = (short)640898898;
				switch (num2 == num)
				{
				}
				num = (short)429129729;
				if (num != 0)
				{
				}
				num = (short)791347200;
				if (num != 0)
				{
				}
				num = (short)182386688;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				pcrtextToSpeechSummary.SpeakerName = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0005676C File Offset: 0x0005496C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00056828 File Offset: 0x00054A28
		public byte VoiceGender
		{
			get
			{
				short num = (short)1959613583;
				short num2 = num;
				num = (short)683824271;
				switch (num2 == num)
				{
				}
				num = (short)1675558912;
				if (num != 0)
				{
				}
				num = (short)833355777;
				if (num != 0)
				{
				}
				num = (short)1309671424;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				return pcrtextToSpeechSummary.VoiceGender;
			}
			set
			{
				short num = (short)1077354920;
				short num2 = num;
				num = (short)1682973096;
				switch (num2 == num)
				{
				}
				num = (short)693043200;
				if (num != 0)
				{
				}
				num = (short)1620901889;
				if (num != 0)
				{
				}
				num = (short)322961408;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				pcrtextToSpeechSummary.VoiceGender = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000568E4 File Offset: 0x00054AE4
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x000569A0 File Offset: 0x00054BA0
		public string PackageName
		{
			get
			{
				short num = (short)507844373;
				short num2 = num;
				num = (short)1817646869;
				switch (num2 == num)
				{
				}
				num = (short)2083586049;
				if (num != 0)
				{
				}
				num = (short)1151533056;
				if (num != 0)
				{
				}
				num = (short)38993920;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				return pcrtextToSpeechSummary.PackageName;
			}
			set
			{
				short num = (short)157197851;
				short num2 = num;
				num = (short)1666688539;
				switch (num2 == num)
				{
				}
				num = (short)76939265;
				if (num != 0)
				{
				}
				num = (short)1764163584;
				if (num != 0)
				{
				}
				num = (short)545718272;
				short num3 = num;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary = base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary;
				pcrtextToSpeechSummary.PackageName = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00056A58 File Offset: 0x00054C58
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00056B7C File Offset: 0x00054D7C
		public int ReferencesInConfigurationRadios
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				int result;
				for (;;)
				{
					IL_0A:
					num = (short)1832910848;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)2124677122;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
					{
						num = (short)892372413;
						short num4 = num;
						num = (short)1345881533;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)994967553;
							if (num != 0)
							{
							}
							num = (short)956694528;
							if (num != 0)
							{
							}
							result = pcrtextToSpeechSummary.ReferenceCountInConfigurationRadios;
							num = (short)1439563777;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_44;
				}
				return result;
				IL_44:
				result = 0;
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)28508160;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				short num;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				for (;;)
				{
					IL_0A:
					num = (short)936312832;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)1288568834;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						num = (short)1624252602;
						short num4 = num;
						num = (short)684531898;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1360592897;
							if (num != 0)
							{
							}
							num = (short)782434304;
							if (num != 0)
							{
							}
							pcrtextToSpeechSummary.ReferenceCountInConfigurationRadios = value;
							num = (short)2105606145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_47;
				}
				return;
				IL_47:
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)70254592;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00056CA0 File Offset: 0x00054EA0
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00056DC8 File Offset: 0x00054FC8
		public int ReferencesInTemplateRadios
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				int result;
				for (;;)
				{
					IL_0A:
					num = (short)1859518464;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)1669267458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 1:
						goto IL_EE;
					case 2:
					{
						num = (short)1654436355;
						short num4 = num;
						num = (short)1201320451;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
							num = (short)1843396608;
							if (num != 0)
							{
							}
							result = pcrtextToSpeechSummary.ReferenceCountInTemplateRadios;
							num = (short)223084545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_45;
				}
				IL_EE:
				IL_F0:
				num = (short)689766401;
				if (num != 0)
				{
				}
				return result;
				IL_45:
				result = 0;
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)1025638400;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				for (;;)
				{
					IL_0A:
					num = (short)849281024;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)2056454146;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						num = (short)1729044568;
						short num4 = num;
						num = (short)106635352;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)697565184;
							if (num != 0)
							{
							}
							num = (short)326696961;
							if (num != 0)
							{
							}
							pcrtextToSpeechSummary.ReferenceCountInTemplateRadios = value;
							num = (short)885850113;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_46;
				}
				return;
				IL_46:
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)1632763904;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00056EE8 File Offset: 0x000550E8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0005700C File Offset: 0x0005520C
		public int ReferencesInTemplate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				int result;
				for (;;)
				{
					IL_0A:
					num = (short)647495680;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)264437762;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_EE;
					case 2:
					{
						num = (short)1720858439;
						short num4 = num;
						num = (short)709637959;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)1244987392;
							if (num != 0)
							{
							}
							result = pcrtextToSpeechSummary.ReferenceCountInTemplate;
							num = (short)412942337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_46;
				}
				IL_EE:
				num = (short)1899626497;
				if (num != 0)
				{
				}
				return result;
				IL_46:
				result = 0;
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)1547960320;
				num3 = (int)((global::System.IntPtr)num);
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
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary pcrtextToSpeechSummary;
				for (;;)
				{
					IL_0A:
					num = (short)2003304448;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (pcrtextToSpeechSummary != null)
						{
							num = (short)2052128770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						num = (short)1814143777;
						short num4 = num;
						num = (short)1173267233;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)2045968384;
							if (num != 0)
							{
							}
							pcrtextToSpeechSummary.ReferenceCountInTemplate = value;
							num = (short)1373569025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_45;
				}
				return;
				IL_45:
				pcrtextToSpeechSummary = (base.SummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary);
				num = (short)1660944385;
				if (num != 0)
				{
				}
				num = (short)1123418112;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00057130 File Offset: 0x00055330
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000571E0 File Offset: 0x000553E0
		public string PAC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)22216705;
				if (num != 0)
				{
				}
				num = (short)1050753383;
				short num2 = num;
				num = (short)688535911;
				switch (num2 == num)
				{
				}
				num = (short)1771438080;
				if (num != 0)
				{
				}
				num = (short)1255211008;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)410374431;
				short num2 = num;
				num = (short)333566239;
				switch (num2 == num)
				{
				}
				num = (short)1510080513;
				if (num != 0)
				{
				}
				num = (short)1469906944;
				if (num != 0)
				{
				}
				num = (short)673120256;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x040002AC RID: 684
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
