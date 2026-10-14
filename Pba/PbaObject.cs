using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000020 RID: 32
	[global::System.Serializable]
	public class PbaObject
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000A1D4 File Offset: 0x000083D4
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000A284 File Offset: 0x00008484
		[global::System.Xml.Serialization.XmlElement("Codeplug")]
		public global::Motorola.Common.Communication.Pba.PackedRadioData CodeplugData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1314785386;
				short num2 = num;
				num = (short)1308428394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817233920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)796393472;
				if (num != 0)
				{
				}
				num = (short)2079588353;
				if (num != 0)
				{
				}
				return this.<CodeplugData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)66060289;
				if (num != 0)
				{
				}
				num = (short)1898708992;
				short num2 = num;
				num = (short)1682763466;
				short num3 = num;
				num = (short)1452273354;
				switch (num3 == num)
				{
				}
				num = (short)1292500992;
				if (num != 0)
				{
				}
				this.<CodeplugData>k__BackingField = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000A334 File Offset: 0x00008534
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000A3E4 File Offset: 0x000085E4
		[global::System.Xml.Serialization.XmlElement("DifferetialCodeplug")]
		public global::Motorola.Common.Communication.Pba.PackedRadioData DifferetialCodeplugData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)495070313;
				short num2 = num;
				num = (short)250817641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429785088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264241152;
				if (num != 0)
				{
				}
				num = (short)233504769;
				if (num != 0)
				{
				}
				return this.<DifferetialCodeplugData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)390644929;
				short num2 = num;
				num = (short)1558299841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675165696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)823656449;
				if (num != 0)
				{
				}
				num = (short)1796210688;
				if (num != 0)
				{
				}
				this.<DifferetialCodeplugData>k__BackingField = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000A494 File Offset: 0x00008694
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000A544 File Offset: 0x00008744
		[global::System.Xml.Serialization.XmlElement("InterestTypes")]
		public global::System.Collections.Generic.List<ushort> InterestTypes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1873215489;
				if (num != 0)
				{
				}
				num = (short)70516736;
				short num2 = num;
				num = (short)1964589551;
				short num3 = num;
				num = (short)510476783;
				switch (num3 == num)
				{
				}
				num = (short)1100152832;
				if (num != 0)
				{
				}
				return this.<InterestTypes>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1515477313;
				short num2 = num;
				num = (short)1995790657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845559296;
				if (num != 0)
				{
				}
				num = (short)702742529;
				if (num != 0)
				{
				}
				this.<InterestTypes>k__BackingField = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000A5F4 File Offset: 0x000087F4
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> DeletableTypes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)114829329;
				short num2 = num;
				num = (short)1341335569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669332992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1591083009;
				if (num != 0)
				{
				}
				num = (short)1511718912;
				if (num != 0)
				{
				}
				return this.<DeletableTypes>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1240868971;
				short num2 = num;
				num = (short)43591787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50855936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)491716609;
				if (num != 0)
				{
				}
				num = (short)1284636672;
				if (num != 0)
				{
				}
				this.<DeletableTypes>k__BackingField = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000A754 File Offset: 0x00008954
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000A804 File Offset: 0x00008A04
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> IDDeletableTypes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1327170383;
				short num2 = num;
				num = (short)306250575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329842688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1467809792;
				if (num != 0)
				{
				}
				num = (short)301858817;
				if (num != 0)
				{
				}
				return this.<IDDeletableTypes>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)498038559;
				short num2 = num;
				num = (short)1422358303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215954944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113311745;
				if (num != 0)
				{
				}
				num = (short)1636892672;
				if (num != 0)
				{
				}
				this.<IDDeletableTypes>k__BackingField = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000A960 File Offset: 0x00008B60
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> ValidationFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1690155036;
				short num2 = num;
				num = (short)1654634524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584201728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909719041;
				if (num != 0)
				{
				}
				num = (short)239009792;
				if (num != 0)
				{
				}
				return this.<ValidationFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)555876987;
				short num2 = num;
				num = (short)1280443003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100363264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)232783873;
				if (num != 0)
				{
				}
				num = (short)969211904;
				if (num != 0)
				{
				}
				this.<ValidationFields>k__BackingField = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000AA10 File Offset: 0x00008C10
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> ValidationInfos
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)571822523;
				short num2 = num;
				num = (short)1188188603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443744256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716832769;
				if (num != 0)
				{
				}
				num = (short)1491468288;
				if (num != 0)
				{
				}
				return this.<ValidationInfos>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)728150493;
				short num2 = num;
				num = (short)1496166877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1466564608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)196739072;
				if (num != 0)
				{
				}
				num = (short)1010892801;
				if (num != 0)
				{
				}
				this.<ValidationInfos>k__BackingField = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000AB74 File Offset: 0x00008D74
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000AC28 File Offset: 0x00008E28
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> PerserveMasks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2010033597;
				short num2 = num;
				num = (short)887795133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196359680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136473600;
				if (num != 0)
				{
				}
				num = (short)1849229313;
				if (num != 0)
				{
				}
				return this.<PerserveMasks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)590479361;
				if (num != 0)
				{
				}
				num = (short)675479552;
				short num2 = num;
				num = (short)243595487;
				short num3 = num;
				num = (short)1885075679;
				switch (num3 == num)
				{
				}
				num = (short)1440415744;
				if (num != 0)
				{
				}
				this.<PerserveMasks>k__BackingField = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000AD88 File Offset: 0x00008F88
		public global::Motorola.Common.Communication.Pba.LocalLanguagaePack LocalLangaugePack
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1104225641;
				short num2 = num;
				num = (short)115221865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1909129216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757596161;
				if (num != 0)
				{
				}
				num = (short)27787264;
				if (num != 0)
				{
				}
				return this.<LocalLangaugePack>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)578191957;
				short num2 = num;
				num = (short)1223197269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974337536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2068971521;
				if (num != 0)
				{
				}
				num = (short)1331101696;
				if (num != 0)
				{
				}
				this.<LocalLangaugePack>k__BackingField = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000AE38 File Offset: 0x00009038
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000AEE8 File Offset: 0x000090E8
		public global::Motorola.Common.Communication.Pba.LanguagePackData LanguagePackData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)550241406;
				short num2 = num;
				num = (short)28443774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675282944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55967745;
				if (num != 0)
				{
				}
				num = (short)559874048;
				if (num != 0)
				{
				}
				return this.<LanguagePackData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1753677825;
				if (num != 0)
				{
				}
				num = (short)2030960640;
				short num2 = num;
				num = (short)1107739709;
				short num3 = num;
				num = (short)1481622589;
				switch (num3 == num)
				{
				}
				num = (short)797769728;
				if (num != 0)
				{
				}
				this.<LanguagePackData>k__BackingField = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000AF98 File Offset: 0x00009198
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000B048 File Offset: 0x00009248
		public global::Motorola.Common.Communication.Pba.LanguagePackData PreservedLanguagePackInfos
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1501167552;
				short num2 = num;
				num = (short)982187968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380108800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909391361;
				if (num != 0)
				{
				}
				num = (short)829358080;
				if (num != 0)
				{
				}
				return this.<PreservedLanguagePackInfos>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1947271169;
				if (num != 0)
				{
				}
				num = (short)740098048;
				short num2 = num;
				num = (short)2082070067;
				short num3 = num;
				num = (short)1090903603;
				switch (num3 == num)
				{
				}
				num = (short)1142751232;
				if (num != 0)
				{
				}
				this.<PreservedLanguagePackInfos>k__BackingField = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000B0F8 File Offset: 0x000092F8
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public global::Motorola.Common.Communication.Pba.LanguagePackData TTSLanguagePackData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1093858148;
				short num2 = num;
				num = (short)706081636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848246272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779826689;
				if (num != 0)
				{
				}
				num = (short)1096548352;
				if (num != 0)
				{
				}
				return this.<TTSLanguagePackData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)492352783;
				short num2 = num;
				num = (short)377468175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802764288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306460161;
				if (num != 0)
				{
				}
				num = (short)1181024256;
				if (num != 0)
				{
				}
				this.<TTSLanguagePackData>k__BackingField = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000B254 File Offset: 0x00009454
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000B304 File Offset: 0x00009504
		public byte[] GeneralInputBuffer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1980936870;
				short num2 = num;
				num = (short)842576550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356777984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975437825;
				if (num != 0)
				{
				}
				num = (short)999686144;
				if (num != 0)
				{
				}
				return this.<GeneralInputBuffer>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)279977034;
				short num2 = num;
				num = (short)535370826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980039168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074673152;
				if (num != 0)
				{
				}
				num = (short)39976961;
				if (num != 0)
				{
				}
				this.<GeneralInputBuffer>k__BackingField = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000B3B4 File Offset: 0x000095B4
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000B468 File Offset: 0x00009668
		public byte[] GeneralOutputBuffer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1289158657;
				if (num != 0)
				{
				}
				num = (short)614596608;
				short num2 = num;
				num = (short)1040144736;
				short num3 = num;
				num = (short)1374181728;
				switch (num3 == num)
				{
				}
				num = (short)1645150208;
				if (num != 0)
				{
				}
				return this.<GeneralOutputBuffer>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)920125441;
				if (num != 0)
				{
				}
				num = (short)1896742912;
				short num2 = num;
				num = (short)1527324149;
				short num3 = num;
				num = (short)1857887733;
				switch (num3 == num)
				{
				}
				num = (short)10420224;
				if (num != 0)
				{
				}
				this.<GeneralOutputBuffer>k__BackingField = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000B51C File Offset: 0x0000971C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000B5CC File Offset: 0x000097CC
		public global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode GeneralCommandCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1128032661;
				short num2 = num;
				num = (short)933325205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435369472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958267393;
				if (num != 0)
				{
				}
				num = (short)905641984;
				if (num != 0)
				{
				}
				return this.<GeneralCommandCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1598986795;
				short num2 = num;
				num = (short)1957730859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326762496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)223805441;
				if (num != 0)
				{
				}
				num = (short)977928192;
				if (num != 0)
				{
				}
				this.<GeneralCommandCode>k__BackingField = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000B67C File Offset: 0x0000987C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000B72C File Offset: 0x0000992C
		public byte[] PasswordResetData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)726899;
				short num2 = num;
				num = (short)1830950771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301938176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1244463104;
				if (num != 0)
				{
				}
				num = (short)522715137;
				if (num != 0)
				{
				}
				return this.<PasswordResetData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1161851137;
				short num2 = num;
				num = (short)1796763905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750845952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686110208;
				if (num != 0)
				{
				}
				num = (short)590282753;
				if (num != 0)
				{
				}
				this.<PasswordResetData>k__BackingField = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000B890 File Offset: 0x00009A90
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData UpdateData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2107846027;
				short num2 = num;
				num = (short)165817739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928776192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113442817;
				if (num != 0)
				{
				}
				num = (short)1866792960;
				if (num != 0)
				{
				}
				return this.<UpdateData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)663027712;
				short num2 = num;
				num = (short)358881225;
				short num3 = num;
				num = (short)561059785;
				switch (num3 == num)
				{
				}
				num = (short)99811328;
				if (num != 0)
				{
				}
				num = (short)1914568705;
				if (num != 0)
				{
				}
				this.<UpdateData>k__BackingField = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public global::Motorola.Common.Communication.Pba.ValidationField TimeStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1918894080;
				short num2 = num;
				num = (short)328964296;
				short num3 = num;
				num = (short)670931144;
				switch (num3 == num)
				{
				}
				num = (short)720175105;
				if (num != 0)
				{
				}
				num = (short)1178206208;
				if (num != 0)
				{
				}
				return this.<TimeStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)281673728;
				short num2 = num;
				num = (short)1285228323;
				short num3 = num;
				num = (short)2074281763;
				switch (num3 == num)
				{
				}
				num = (short)1859649537;
				if (num != 0)
				{
				}
				num = (short)1373437952;
				if (num != 0)
				{
				}
				this.<TimeStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000BB50 File Offset: 0x00009D50
		public string FWpath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1016594432;
				short num2 = num;
				num = (short)994508801;
				if (num != 0)
				{
				}
				num = (short)1019316907;
				short num3 = num;
				num = (short)743738027;
				switch (num3 == num)
				{
				}
				num = (short)949223424;
				if (num != 0)
				{
				}
				return this.<FWpath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1033306112;
				short num2 = num;
				num = (short)2113967695;
				short num3 = num;
				num = (short)17798735;
				switch (num3 == num)
				{
				}
				num = (short)906035201;
				if (num != 0)
				{
				}
				num = (short)1137442816;
				if (num != 0)
				{
				}
				this.<FWpath>k__BackingField = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000BC00 File Offset: 0x00009E00
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000BCAC File Offset: 0x00009EAC
		public string FlashStrapPath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1215758336;
				short num2 = num;
				num = (short)2084486699;
				short num3 = num;
				num = (short)133152299;
				switch (num3 == num)
				{
				}
				num = (short)1192361985;
				if (num != 0)
				{
				}
				num = (short)1221853184;
				if (num != 0)
				{
				}
				return this.<FlashStrapPath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1137967104;
				short num2 = num;
				num = (short)751650914;
				short num3 = num;
				num = (short)131418210;
				switch (num3 == num)
				{
				}
				num = (short)1179320321;
				if (num != 0)
				{
				}
				num = (short)1366818816;
				if (num != 0)
				{
				}
				this.<FlashStrapPath>k__BackingField = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000BD5C File Offset: 0x00009F5C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000BE10 File Offset: 0x0000A010
		public bool IsRetoreJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)876019712;
				short num2 = num;
				num = (short)1926857427;
				short num3 = num;
				num = (short)117277395;
				switch (num3 == num)
				{
				}
				num = (short)612892672;
				if (num != 0)
				{
				}
				num = (short)1987772417;
				if (num != 0)
				{
				}
				return this.<IsRetoreJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)841678848;
				short num2 = num;
				num = (short)1260710530;
				short num3 = num;
				num = (short)1848765058;
				switch (num3 == num)
				{
				}
				num = (short)376373248;
				if (num != 0)
				{
				}
				num = (short)1186201601;
				if (num != 0)
				{
				}
				this.<IsRetoreJob>k__BackingField = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000BF78 File Offset: 0x0000A178
		public bool IsFactoryResetOp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)88539136;
				short num2 = num;
				num = (short)842412231;
				short num3 = num;
				num = (short)1970614471;
				switch (num3 == num)
				{
				}
				num = (short)2018705408;
				if (num != 0)
				{
				}
				num = (short)1653407745;
				if (num != 0)
				{
				}
				return this.<IsFactoryResetOp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1973223424;
				short num2 = num;
				num = (short)1382162959;
				short num3 = num;
				num = (short)1350115855;
				switch (num3 == num)
				{
				}
				num = (short)761069569;
				if (num != 0)
				{
				}
				num = (short)1886453760;
				if (num != 0)
				{
				}
				this.<IsFactoryResetOp>k__BackingField = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000C028 File Offset: 0x0000A228
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		public bool IsStaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2048786432;
				short num2 = num;
				num = (short)597295105;
				if (num != 0)
				{
				}
				num = (short)2140029799;
				short num3 = num;
				num = (short)813253479;
				switch (num3 == num)
				{
				}
				num = (short)972947456;
				if (num != 0)
				{
				}
				return this.<IsStaged>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)452001792;
				short num2 = num;
				num = (short)1731908171;
				short num3 = num;
				num = (short)386257483;
				switch (num3 == num)
				{
				}
				num = (short)2133393409;
				if (num != 0)
				{
				}
				num = (short)773259264;
				if (num != 0)
				{
				}
				this.<IsStaged>k__BackingField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000C188 File Offset: 0x0000A388
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000C23C File Offset: 0x0000A43C
		public int RebootCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1218707456;
				short num2 = num;
				num = (short)1316703874;
				short num3 = num;
				num = (short)191188610;
				switch (num3 == num)
				{
				}
				num = (short)852361216;
				if (num != 0)
				{
				}
				num = (short)1937965057;
				if (num != 0)
				{
				}
				return this.<RebootCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)409796608;
				short num2 = num;
				num = (short)974917173;
				short num3 = num;
				num = (short)1819807285;
				switch (num3 == num)
				{
				}
				num = (short)1841102849;
				if (num != 0)
				{
				}
				num = (short)35782656;
				if (num != 0)
				{
				}
				this.<RebootCount>k__BackingField = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000C398 File Offset: 0x0000A598
		public string RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)661716992;
				short num2 = num;
				num = (short)318756038;
				short num3 = num;
				num = (short)1792595142;
				switch (num3 == num)
				{
				}
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)1024917504;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1846935552;
				short num2 = num;
				num = (short)180948821;
				short num3 = num;
				num = (short)2131365717;
				switch (num3 == num)
				{
				}
				num = (short)310312961;
				if (num != 0)
				{
				}
				num = (short)1920794624;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000C444 File Offset: 0x0000A644
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		public global::Motorola.Common.Communication.Pba.PBBReadData PbbReadData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)152764416;
				short num2 = num;
				num = (short)1702904577;
				short num3 = num;
				num = (short)1892565761;
				switch (num3 == num)
				{
				}
				num = (short)856948737;
				if (num != 0)
				{
				}
				num = (short)941752320;
				if (num != 0)
				{
				}
				return this.<PbbReadData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)683606016;
				short num2 = num;
				num = (short)1322402583;
				short num3 = num;
				num = (short)900678423;
				switch (num3 == num)
				{
				}
				num = (short)2069757953;
				if (num != 0)
				{
				}
				num = (short)1529282560;
				if (num != 0)
				{
				}
				this.<PbbReadData>k__BackingField = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000C5A4 File Offset: 0x0000A7A4
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000C654 File Offset: 0x0000A854
		public global::Motorola.Common.Communication.Pba.CSAReadData CSAReadData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)861536256;
				short num2 = num;
				num = (short)1457500637;
				short num3 = num;
				num = (short)106410461;
				switch (num3 == num)
				{
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				num = (short)1613103104;
				if (num != 0)
				{
				}
				return this.<CSAReadData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1450639360;
				short num2 = num;
				num = (short)1733099521;
				if (num != 0)
				{
				}
				num = (short)1064026503;
				short num3 = num;
				num = (short)664977799;
				switch (num3 == num)
				{
				}
				num = (short)588251136;
				if (num != 0)
				{
				}
				this.<CSAReadData>k__BackingField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000C708 File Offset: 0x0000A908
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField> ValidationSpecialFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1821048832;
				short num2 = num;
				num = (short)450101249;
				if (num != 0)
				{
				}
				num = (short)861277131;
				short num3 = num;
				num = (short)720047051;
				switch (num3 == num)
				{
				}
				num = (short)911605760;
				if (num != 0)
				{
				}
				return this.<ValidationSpecialFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)226164736;
				short num2 = num;
				num = (short)826288694;
				short num3 = num;
				num = (short)430451254;
				switch (num3 == num)
				{
				}
				num = (short)1579286528;
				if (num != 0)
				{
				}
				num = (short)463011841;
				if (num != 0)
				{
				}
				this.<ValidationSpecialFields>k__BackingField = value;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000C870 File Offset: 0x0000AA70
		public PbaObject()
		{
			this.CodeplugData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			this.InterestTypes = null;
			this.DifferetialCodeplugData = null;
			this.DeletableTypes = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
			this.IDDeletableTypes = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
			this.PerserveMasks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			this.ValidationFields = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			this.ValidationInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
			this.LocalLangaugePack = new global::Motorola.Common.Communication.Pba.LocalLanguagaePack();
			this.LanguagePackData = null;
			this.TTSLanguagePackData = null;
			this.FileSetList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>();
			this.UpdateData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.PreUpdateData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.TimeStamp = null;
			this.IsStaged = false;
			this.RebootCount = 0;
			this.RadioUuid = null;
			this.PbbReadData = null;
			this.TTSLanguagePackData = null;
			this.ValidationSpecialFields = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField>();
			this.GeneralInputBuffer = null;
			this.GeneralOutputBuffer = null;
			this.GeneralCommandCode = global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.Undefined;
			this.IsRetoreJob = false;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000C960 File Offset: 0x0000AB60
		public void SetCodeplug(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection)
		{
			short num = (short)1041235968;
			short num2 = num;
			num = (short)512031589;
			short num3 = num;
			num = (short)607386469;
			switch (num3 == num)
			{
			}
			num = (short)498597888;
			if (num != 0)
			{
			}
			num = (short)1382678529;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(ishItemCollection, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(ishItemCollection);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000CA1C File Offset: 0x0000AC1C
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCodeplugInIshItemCollection()
		{
			short num = (short)1840936793;
			short num2 = num;
			num = (short)1383954265;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B8;
			case 1:
				break;
			default:
			{
				num = (short)459079680;
				short num3 = num;
				break;
			}
			}
			num = (short)500236289;
			if (num != 0)
			{
			}
			num = (short)1160839168;
			if (num != 0)
			{
			}
			num = (short)1683947520;
			switch (num)
			{
			default:
			{
				IL_B8:
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = this.CodeplugData.DataPartitions.GetEnumerator())
				{
					num = (short)1157496832;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_10B;
							}
							continue;
						case 1:
							goto IL_292;
						case 2:
							try
							{
								num = (short)454426624;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1B0;
										}
										continue;
									case 1:
										goto IL_267;
									case 2:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1851916291;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(dataPartition.PartitionID, dataBlock.BlockType, dataBlock.BlockID);
										global::Motorola.Common.Communication.CommonUtil.IshItem item = new global::Motorola.Common.Communication.CommonUtil.IshItem(dataBlock.LegthInBits / 8, dataBlock.PacketValue, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined);
										ishItemCollection.Add(headers, item);
										num = (short)1210908676;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)300351489;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1B2:
									num = (short)1116078082;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B0:
									goto IL_1B2;
								}
								IL_267:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_27A;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)273743876;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator.Current;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = dataPartition.DataBlocks.GetEnumerator();
							num = (short)256704514;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_27A;
						}
						IL_139:
						num = (short)1168441347;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_10B:
						goto IL_139;
						IL_27A:
						num = (short)380829697;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_292:;
				}
				return ishItemCollection;
			}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000CD00 File Offset: 0x0000AF00
		public void SetCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			short num = (short)1612185600;
			short num2 = num;
			num = (short)1560416794;
			short num3 = num;
			num = (short)2083918362;
			switch (num3 == num)
			{
			}
			num = (short)1528889345;
			if (num != 0)
			{
			}
			num = (short)1898381312;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(fdiBlockList, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(fdiBlockList);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> GetCodeplugInFbiBlockList()
		{
			short num = (short)192554405;
			short num2 = num;
			num = (short)1555047845;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BA;
			case 1:
				break;
			default:
			{
				num = (short)1326448640;
				short num3 = num;
				break;
			}
			}
			num = (short)1687814145;
			if (num != 0)
			{
			}
			num = (short)1617035264;
			if (num != 0)
			{
			}
			num = (short)1442316288;
			switch (num)
			{
			default:
			{
				IL_BA:
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = this.CodeplugData.DataPartitions.GetEnumerator())
				{
					num = (short)1974665216;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_113;
							}
							continue;
						case 1:
							goto IL_28E;
						case 2:
							try
							{
								num = (short)242483200;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1B3;
										}
										continue;
									case 1:
										goto IL_263;
									case 2:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)545390595;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
										ushort blockID = dataBlock.BlockID;
										byte[] array = new byte[dataBlock.PacketValue.Length];
										global::System.Array.Copy(dataBlock.PacketValue, array, dataBlock.PacketValue.Length);
										list.Add(new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(blockID, array));
										num = (short)498532356;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)355401729;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1B5:
									num = (short)1233977346;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B3:
									goto IL_1B5;
								}
								IL_263:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_276;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)809238532;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = enumerator.Current.DataBlocks.GetEnumerator();
							num = (short)1000013826;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_276;
						}
						IL_140:
						num = (short)687210499;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_113:
						goto IL_140;
						IL_276:
						num = (short)682295297;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_28E:;
				}
				return list;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		public void SetCodeplug(byte[] cpImage)
		{
			short num = (short)1563361248;
			short num2 = num;
			num = (short)1960902624;
			switch (num2 == num)
			{
			default:
			{
				num = (short)123928576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1725759488;
			if (num != 0)
			{
			}
			num = (short)1744633857;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(cpImage, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(cpImage);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000D160 File Offset: 0x0000B360
		public byte[] GetCodeplugInImage()
		{
			short num = (short)744947712;
			switch (num)
			{
			default:
			{
				num = (short)1919680513;
				if (num != 0)
				{
				}
				byte[] array = null;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = this.CodeplugData.DataPartitions.GetEnumerator())
				{
					num = (short)253558787;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)502661123;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)49020930;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
										array = new byte[dataBlock.PacketValue.Length];
										global::System.Array.Copy(dataBlock.PacketValue, array, dataBlock.PacketValue.Length);
										num = (short)652083204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_21B;
									case 2:
										goto IL_16A;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_133;
										}
										continue;
									case 4:
									{
										num = (short)1765607964;
										short num3 = num;
										num = (short)1151076892;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_16A;
										default:
											num = (short)531824640;
											if (num != 0)
											{
											}
											break;
										}
										break;
									}
									}
									IL_135:
									num = (short)969211904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_133:
									goto IL_135;
									IL_16A:
									num = (short)672858113;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_21B:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_22E;
						case 1:
							goto IL_246;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)306053124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = enumerator.Current.DataBlocks.GetEnumerator();
							num = (short)913833984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						case 4:
							goto IL_22E;
						}
						IL_C0:
						num = (short)1097990146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_95:
						goto IL_C0;
						IL_22E:
						num = (short)99221505;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_246:;
				}
				num = (short)1244659712;
				short num4 = num;
				return array;
			}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000D420 File Offset: 0x0000B620
		public void SetLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)1522073600;
				short num2 = num;
				int num3;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>.Enumerator enumerator;
				switch (num3)
				{
				case 0:
					goto IL_1D5;
				case 1:
					goto IL_FC;
				case 2:
					if (this.LanguagePackData == null)
					{
						num = (short)1219559425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				case 3:
					try
					{
						num = (short)1477902339;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								goto IL_1C5;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1351483396;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.PackHeader pack = enumerator.Current;
								global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = new global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo();
								tetraLanguagePackInfo.Initialize(pack);
								this.LanguagePackData.LanguagePacks.Add(tetraLanguagePackInfo);
								num = (short)10092544;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_139;
								}
								continue;
							case 4:
								num = (short)1440350209;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_177:
							num = (short)506658818;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_139:
							goto IL_177;
						}
						IL_1C5:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D5;
				}
				goto IL_4A;
				IL_1D5:
				this.LanguagePackData.LanguagePacks.Clear();
				enumerator = packs.GetEnumerator();
				num = (short)551878659;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			goto IL_213;
			IL_4A:
			num = (short)2039742465;
			if (num != 0)
			{
			}
			num = (short)1687076566;
			short num4 = num;
			num = (short)97173206;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_213:
				num = (short)219545600;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)229834752;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				num = (short)923074562;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000D66C File Offset: 0x0000B86C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> GetLPInfoToTetraLPInfo()
		{
			short num = (short)1764491264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list;
				for (;;)
				{
					IL_1D:
					num = (short)1551171585;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					for (;;)
					{
						IL_4F:
						switch (num2)
						{
						case 0:
							goto IL_210;
						case 1:
							this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
							num = (short)163708928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (this.LanguagePackData == null)
							{
								num = (short)86573057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_210;
						case 3:
							try
							{
								num = (short)1324417029;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo;
										if (tetraLanguagePackInfo != null)
										{
											num = (short)278396930;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)158924806;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = (global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo)enumerator.Current;
										num = (short)1245904896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo;
										list.Add(new global::Motorola.Common.Communication.CommonUtil.PackHeader
										{
											compareID = (uint)global::System.Convert.ToInt32(tetraLanguagePackInfo.PackID, global::System.Globalization.CultureInfo.InvariantCulture),
											type = tetraLanguagePackInfo.PackType,
											imageName = tetraLanguagePackInfo.PackFilePath
										});
										num = (short)1574764547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1FD;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_114;
										}
										continue;
									case 6:
										num = (short)1316618244;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_153:
									num = (short)682622977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_114:
									goto IL_153;
								}
								IL_1FD:
								return list;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_210;
						}
						break;
						IL_210:
						num = (short)1740073252;
						short num3 = num;
						num = (short)2106550564;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
						{
							num = (short)1608187904;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = this.LanguagePackData.LanguagePacks.GetEnumerator();
							num = (short)282132483;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_66:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
					num = (short)1190723584;
					short num4 = num;
					num = (short)188350466;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4F;
				}
				return list;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000D94C File Offset: 0x0000BB4C
		public void SetLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> packs)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)125698048;
				short num2 = num;
				int num3;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>.Enumerator enumerator;
				switch (num3)
				{
				case 0:
					goto IL_1C6;
				case 1:
					goto IL_FB;
				case 2:
					if (this.LanguagePackData == null)
					{
						num = (short)1034158081;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 3:
					try
					{
						num = (short)239730691;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								goto IL_1B6;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1981546500;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo item = enumerator.Current;
								this.LanguagePackData.LanguagePacks.Add(item);
								num = (short)154337280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_139;
								}
								continue;
							case 4:
								num = (short)708444161;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_16A:
							num = (short)2142175234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_139:
							goto IL_16A;
						}
						IL_1B6:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1C6;
				}
				goto IL_4A;
				IL_1C6:
				this.LanguagePackData.LanguagePacks.Clear();
				enumerator = packs.GetEnumerator();
				num = (short)2056781827;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			goto IL_205;
			IL_4A:
			num = (short)222060460;
			short num4 = num;
			num = (short)1299275692;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_205:
				num = (short)102236160;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)1904869377;
				if (num != 0)
				{
				}
				num = (short)289013760;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				num = (short)122945538;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000DB88 File Offset: 0x0000BD88
		public void SetTTSLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> packs)
		{
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)1346502656;
				short num2 = num;
				int num3;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>.Enumerator enumerator;
				switch (num3)
				{
				case 0:
					goto IL_1A5;
				case 1:
					goto IL_D6;
				case 2:
					if (this.TTSLanguagePackData == null)
					{
						num = (short)710410241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A5;
				case 3:
					try
					{
						num = (short)258408451;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								goto IL_192;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1455685636;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo item = enumerator.Current;
								this.TTSLanguagePackData.LanguagePacks.Add(item);
								num = (short)374603776;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_114;
								}
								continue;
							case 4:
								num = (short)560922625;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_145:
							num = (short)182124546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_114:
							goto IL_145;
						}
						IL_192:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1A5;
				}
				goto IL_4B;
				IL_1A5:
				num = (short)1354563585;
				if (num != 0)
				{
				}
				this.TTSLanguagePackData.LanguagePacks.Clear();
				enumerator = packs.GetEnumerator();
				num = (short)1638531075;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			this.TTSLanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			goto IL_20B;
			IL_4B:
			num = (short)2125416218;
			short num4 = num;
			num = (short)330843930;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20B:
				num = (short)273612800;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)1700659200;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				num = (short)1324679170;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> GetLPInfoToPCRLPInfo()
		{
			short num = (short)1805647874;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list;
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
				global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo item;
				switch (num2)
				{
				case 0:
					goto IL_158;
				case 1:
				{
					this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					num = (short)1055249648;
					short num3 = num;
					num = (short)1934546160;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_175;
					default:
						num = (short)708771840;
						if (num != 0)
						{
						}
						num = (short)1945239553;
						if (num != 0)
						{
						}
						num = (short)656539648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					try
					{
						num = (short)520224773;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if ((item = (enumerator.Current as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)) != null)
								{
									num = (short)663945218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)421068806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)761331712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								list.Add(item);
								num = (short)300220419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_145;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								continue;
							case 6:
								num = (short)1150418948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D5:
							num = (short)1084555265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_98:
							goto IL_D5;
						}
						IL_145:
						return list;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_158;
				}
				IL_34:
				if (this.LanguagePackData == null)
				{
					num = (short)930807809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_158;
				IL_175:
				num = (short)1118175232;
				short num4 = num;
				num = (short)521601027;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_158:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>();
				item = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
				enumerator = this.LanguagePackData.LanguagePacks.GetEnumerator();
				goto IL_175;
			}
			return list;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E03C File Offset: 0x0000C23C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> GetTTSLPInfo()
		{
			short num = (short)125239298;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list;
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
				global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo item;
				switch (num2)
				{
				case 0:
					goto IL_15B;
				case 1:
				{
					this.TTSLanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					num = (short)103823858;
					short num3 = num;
					num = (short)1126840818;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_178;
					default:
						num = (short)2141192192;
						if (num != 0)
						{
						}
						num = (short)767492097;
						if (num != 0)
						{
						}
						num = (short)126418944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					try
					{
						num = (short)2132410373;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if ((item = (enumerator.Current as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)) != null)
								{
									num = (short)2101346306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)960299014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1981349888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								list.Add(item);
								num = (short)2069168131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_148;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_9B;
								}
								continue;
							case 6:
								num = (short)912916484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D8:
							num = (short)757268481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9B:
							goto IL_D8;
						}
						IL_148:
						return list;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_15B;
				}
				IL_35:
				if (this.TTSLanguagePackData == null)
				{
					num = (short)1801715713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15B;
				IL_178:
				num = (short)135593984;
				short num4 = num;
				num = (short)1062010883;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15B:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
				item = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
				enumerator = this.TTSLanguagePackData.LanguagePacks.GetEnumerator();
				goto IL_178;
			}
			return list;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		public void SetLlp(byte[] llpData)
		{
			short num = (short)789256469;
			short num2 = num;
			num = (short)531044629;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1970667520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1065353217;
			if (num != 0)
			{
			}
			num = (short)707919872;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(llpData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.LocalLangaugePack.Initialize(llpData);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E374 File Offset: 0x0000C574
		public byte[] GetLlpData()
		{
			short num = (short)479110810;
			short num2 = num;
			num = (short)1950131866;
			switch (num2 == num)
			{
			default:
			{
				num = (short)444858368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1141833729;
			if (num != 0)
			{
			}
			num = (short)1113980928;
			if (num != 0)
			{
			}
			return this.LocalLangaugePack.LlpValue;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E428 File Offset: 0x0000C628
		public long Serialize(string pbaXmlFilePath)
		{
			global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaXmlFilePath, global::System.IO.FileAccess.Write);
			long position;
			short num;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.ProxyStream proxyStream = new global::Motorola.Common.Communication.CommonUtil.ProxyStream(stream, false);
				try
				{
					this.Serialize(proxyStream);
					position = proxyStream.Position;
				}
				finally
				{
					num = (short)514523137;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_90;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5C;
							}
							continue;
						case 2:
							((global::System.IDisposable)proxyStream).Dispose();
							num = (short)1706033152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5C:
						if (proxyStream == null)
						{
							break;
						}
						num = (short)3407874;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_90:;
				}
			}
			finally
			{
				num = (short)1777467393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_C4;
						}
						continue;
					case 2:
						((global::System.IDisposable)stream).Dispose();
						num = (short)1543634944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C4:
					if (stream != null)
					{
						num = (short)245694466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FB:
					num = (short)579169843;
					short num3 = num;
					num = (short)273706547;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_131;
					}
				}
				IL_131:
				num = (short)862257152;
				if (num != 0)
				{
				}
			}
			num = (short)1751646209;
			if (num != 0)
			{
			}
			num = (short)63635456;
			short num4 = num;
			return position;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		public void Serialize(global::System.IO.Stream stream)
		{
			short num = (short)1242926873;
			short num2 = num;
			num = (short)1700630297;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1666908160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)964952065;
			if (num != 0)
			{
			}
			num = (short)2050097152;
			if (num != 0)
			{
			}
			new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject)).Serialize(stream, this);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000E6AC File Offset: 0x0000C8AC
		public byte[] Serialize()
		{
			short num = (short)1345585153;
			if (num != 0)
			{
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			byte[] result;
			try
			{
				global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(memoryStream, false);
				try
				{
					this.Serialize(stream);
				}
				finally
				{
					num = (short)1212022785;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_AC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_77;
							}
							continue;
						case 2:
							((global::System.IDisposable)stream).Dispose();
							num = (short)904396800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_77:
						if (stream == null)
						{
							break;
						}
						num = (short)2039283714;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_AC:;
				}
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)1001717761;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_121;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_EC;
						}
						continue;
					case 2:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)242548736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_EC:
					if (memoryStream != null)
					{
						num = (short)994246658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_121:
					num = (short)2089993257;
					short num3 = num;
					num = (short)574276649;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_155;
					}
				}
				IL_155:
				num = (short)708771840;
				if (num != 0)
				{
				}
			}
			num = (short)646053888;
			short num4 = num;
			return result;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000E86C File Offset: 0x0000CA6C
		public byte[] SerializeToBytes()
		{
			short num = (short)1078788096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::Motorola.Common.Communication.Pba.PackedRadioData codeplugData;
				global::System.Xml.Serialization.XmlSerializer xmlSerializer;
				byte[] buffer;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> validationFields;
					switch (num2)
					{
					case 0:
					{
						num = (short)649706523;
						short num3 = num;
						num = (short)1608891419;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11D;
						default:
						{
							num = (short)379256832;
							short num4 = num;
							num = (short)1974730752;
							if (num != 0)
							{
							}
							goto IL_FD;
						}
						}
						break;
					}
					case 1:
						if (validationFields != null)
						{
							num = (short)1743847429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD;
					case 2:
						if (codeplugData.DataPartitions != null)
						{
							num = (short)2041511946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 3:
					{
						codeplugData.DataPartitions.Sort(new global::System.Comparison<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a));
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = codeplugData.DataPartitions.GetEnumerator();
						num = (short)1488125961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						validationFields.Sort(new global::System.Comparison<global::Motorola.Common.Communication.Pba.ValidationField>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a));
						num = (short)885194752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1121845252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_41E;
					case 7:
						goto IL_11D;
					case 8:
						if (codeplugData != null)
						{
							num = (short)337444870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 9:
						try
						{
							num = (short)300351491;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)515178501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator;
									enumerator.Current.DataBlocks.Sort(new global::System.Comparison<global::Motorola.Common.Communication.Pba.DataBlock>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a));
									num = (short)1745747968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_18C;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)918814721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)408027138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_247;
								}
								IL_1EF:
								num = (short)681115652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18C:
								goto IL_1EF;
							}
							IL_247:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_257;
					case 10:
						num = (short)794624003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A;
					IL_FD:
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					num = (short)1521287175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_257:
					validationFields = this.ValidationFields;
					num = (short)694943745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41E:
					num = (short)1547304962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11D:
					try
					{
						memoryStream.SetLength(0L);
						xmlSerializer.Serialize(memoryStream, this);
						buffer = memoryStream.GetBuffer();
						break;
					}
					finally
					{
						num = (short)1559035904;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3E2;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)2025586690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_41B;
							}
							IL_3E2:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)807993345;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_41B:;
					}
					goto IL_41E;
				}
				return buffer;
				IL_5A:
				num = (short)102760449;
				if (num != 0)
				{
				}
				xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
				codeplugData = this.CodeplugData;
				num = (short)1536163848;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFrom(string pbaXmlFilePath)
		{
			short num = (short)1757167978;
			short num2 = num;
			num = (short)510017898;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)633077760;
				short num3 = num;
				num = (short)129236993;
				if (num != 0)
				{
				}
				num = (short)1352269824;
				if (num != 0)
				{
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
				global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaXmlFilePath, global::System.IO.FileAccess.Read);
				try
				{
					result = (global::Motorola.Common.Communication.Pba.PbaObject)xmlSerializer.Deserialize(stream);
				}
				finally
				{
					num = (short)1666646016;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_FC;
							}
							continue;
						case 1:
							((global::System.IDisposable)stream).Dispose();
							num = (short)182845442;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_130;
						}
						IL_FC:
						if (stream == null)
						{
							break;
						}
						num = (short)1632108545;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_130:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000EE4C File Offset: 0x0000D04C
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFrom(byte[] fileContent, bool xpba = false)
		{
			short num = (short)411041792;
			switch (num)
			{
			default:
			{
				num = (short)1395326976;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 1:
						goto IL_6F;
					case 2:
					{
						num = (short)1615200257;
						if (num != 0)
						{
						}
						num = (short)1628443965;
						short num3 = num;
						num = (short)1428428093;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F;
						default:
						{
							num = (short)1696595968;
							if (num != 0)
							{
							}
							num = (short)1896022016;
							short num4 = num;
							try
							{
								global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
								global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(memoryStream, true);
								try
								{
									return (global::Motorola.Common.Communication.Pba.PbaObject)xmlSerializer.Deserialize(stream);
								}
								finally
								{
									num = (short)1965293568;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_D7;
											}
											continue;
										case 1:
											((global::System.IDisposable)stream).Dispose();
											num = (short)1364328450;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_10C;
										}
										IL_D7:
										if (stream == null)
										{
											break;
										}
										num = (short)1816788993;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_10C:;
								}
							}
							finally
							{
								num = (short)1053753344;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_141;
										}
										continue;
									case 1:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1623064578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_178;
									}
									IL_141:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)172359681;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_178:;
							}
							goto IL_17B;
						}
						}
						break;
					}
					}
					IL_52:
					if (xpba)
					{
						num = (short)408354817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_17B:
					memoryStream = new global::System.IO.MemoryStream(fileContent);
					num = (short)1555562498;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6F:
				return global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(fileContent, xpba);
			}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFromBytes(byte[] buffer, bool xpba = false)
		{
			int a_ = 4;
			short num = (short)1399521284;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::a<byte, int> a = buffer.Select(new global::System.Func<byte, int, global::a<byte, int>>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a)).LastOrDefault(new global::System.Func<global::a<byte, int>, bool>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a));
					num = (short)1272315909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_E3;
				case 2:
					goto IL_1C8;
				case 3:
					buffer = global::Motorola.Common.CommonLib.CombineTool.Decode(buffer)[0];
					num = (short)2029715457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 5:
				{
					IL_1AE:
					global::a<byte, int> a;
					if (a == null)
					{
						num = (short)84803586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer.Take(a.Index + 1).ToArray<byte>());
					num = (short)911015942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_20E;
				}
				IL_4B:
				num = (short)1469054977;
				if (num != 0)
				{
				}
				if (xpba)
				{
					num = (short)1060175872;
					short num3 = num;
					num = (short)334233603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E3:
				num = (short)1307618668;
				short num4 = num;
				num = (short)1213705580;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1AE;
				default:
					num = (short)226033664;
					if (num != 0)
					{
					}
					num = (short)1366032384;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1C8:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("证꫃냅꧇ꛉꗋ꫍ꋑ뛓럕룙꧛룝蛟蟡難", a_));
			IL_20E:
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				global::System.IO.MemoryStream memoryStream;
				result = (global::Motorola.Common.Communication.Pba.PbaObject)new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject)).Deserialize(memoryStream);
			}
			finally
			{
				num = (short)1927282688;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_25D;
						}
						continue;
					case 1:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)1903034370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_291;
					}
					IL_25D:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)1633026049;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_291:;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000F370 File Offset: 0x0000D570
		public void GenerateDifferetialCodeplug(global::Motorola.Common.Communication.Pba.PbaObject basePba)
		{
			short num = (short)1284702208;
			switch (num)
			{
			default:
			{
				num = (short)473104384;
				short num2 = num;
				num = (short)1474428936;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_61E;
					case 1:
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
						pbaObject.SetCodeplug(ishItemCollection);
						this.DifferetialCodeplugData = pbaObject.CodeplugData;
						num = (short)241106944;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)261816327;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
									if (!ishItemCollection.ContainsHeader(ishHeader))
									{
										num = (short)86900738;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.Result != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
									{
										num = (short)262799368;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
									ishItemCollection.Add(ishHeader, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
									num = (short)2103967747;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1752694789;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									if (this.a(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair.Key.PartitionNumber, keyValuePair.Key.IshType)))
									{
										num = (short)593559567;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									if (this.a(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair.Key.PartitionNumber, keyValuePair.Key.IshType)))
									{
										num = (short)1029439500;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								case 8:
									num = (short)193593357;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_32C;
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1361707017;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
									num = (short)315949057;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									ishItemCollection.Add(keyValuePair.Key, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
									num = (short)1978597393;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::System.Collections.Generic.HashSet<ushort> hashSet;
									if (hashSet.Contains(keyValuePair.Key.IshType))
									{
										num = (short)1251803140;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)140967952;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(keyValuePair.Key.PartitionNumber, keyValuePair.Key.IshType, ushort.MaxValue);
									num = (short)1021247488;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									ishItemCollection.Add(keyValuePair.Key, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
									num = (short)539426827;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									if (this.b(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair.Key.PartitionNumber, keyValuePair.Key.IshType)))
									{
										num = (short)1635844110;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1194328070;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									num = (short)177721685;
									short num4 = num;
									num = (short)821219669;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_32C;
									default:
										num = (short)47513600;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 18:
									goto IL_4B7;
								}
								IL_2F0:
								num = (short)1212612618;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								goto IL_2F0;
								IL_32C:
								num = (short)1093074962;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_4B7:
							goto IL_56A;
						}
						finally
						{
							num = (short)703135744;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4EE;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1677197314;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_525;
								}
								IL_4EE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)45285377;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_525:;
						}
						goto IL_528;
						IL_56A:
						num = (short)1851785220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (this.CodeplugData == null)
						{
							num = (short)475070471;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = this.GetCodeplugInIshItemCollection();
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection2 = basePba.GetCodeplugInIshItemCollection();
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
						global::System.Collections.Generic.HashSet<ushort> hashSet = new global::System.Collections.Generic.HashSet<ushort>();
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = codeplugInIshItemCollection.GetEnumerator();
						num = (short)1316028426;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
						if (ishItemCollection.Count > 0)
						{
							num = (short)1926758401;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_905;
					}
					case 5:
						if (basePba.CodeplugData != null)
						{
							num = (short)1199702025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89D;
					case 6:
						num = (short)1370226693;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_565;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_99;
						}
						continue;
					case 9:
						goto IL_528;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection2;
						try
						{
							num = (short)1207500808;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2;
								global::Motorola.Common.Communication.CommonUtil.IshItem item;
								switch (num3)
								{
								case 1:
									num = (short)1506869258;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									ishItemCollection.Add(keyValuePair2.Key, keyValuePair2.Value);
									num = (short)1408237575;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1069154305;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair2 = enumerator.Current;
									global::System.Collections.Generic.HashSet<ushort> hashSet;
									hashSet.Add(keyValuePair2.Key.IshType);
									num = (short)232587269;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (codeplugInIshItemCollection2.ContainsHeader(keyValuePair2.Key))
									{
										num = (short)1967587337;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
									ishItemCollection.Add(keyValuePair2.Key, keyValuePair2.Value);
									num = (short)1291059202;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (!value.Data.SequenceEqual(item.Data))
									{
										num = (short)794558467;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7B0;
								}
								case 7:
									goto IL_7B0;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_675;
									}
									continue;
								case 9:
								{
									item = codeplugInIshItemCollection2[keyValuePair2.Key];
									global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair2.Value;
									num = (short)554041350;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_82F;
								}
								IL_70A:
								num = (short)910950404;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_675:
								goto IL_70A;
								IL_7B0:
								item.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success;
								codeplugInIshItemCollection2.Update(keyValuePair2.Key, item);
								num = (short)1773928448;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_82F:
							goto IL_8A4;
						}
						finally
						{
							num = (short)421462016;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_864;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)386269186;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_89A;
								}
								IL_864:
								if (enumerator == null)
								{
									break;
								}
								num = (short)64421889;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_89A:;
						}
						goto IL_89D;
						IL_8A4:
						enumerator = codeplugInIshItemCollection2.GetEnumerator();
						num = (short)1500381186;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_99:
					if (basePba != null)
					{
						num = (short)1917845510;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_528:
					num = (short)296026115;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_565:
				goto IL_89D;
				IL_61E:
				goto IL_905;
				IL_89D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_905:
				num = (short)1700528129;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		private bool b(global::Motorola.Common.Communication.Pba.DataBlockType A_0)
		{
			short num = (short)1343422465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)545849345;
					if (num != 0)
					{
					}
					num = (short)584384514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
				{
					if (this.DeletableTypes.Count == 0)
					{
						return true;
					}
					num = (short)33255847;
					short num3 = num;
					num = (short)868643239;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
					{
						num = (short)371064832;
						if (num != 0)
						{
						}
						num = (short)1548615680;
						short num4 = num;
						num = (short)359596035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_13B;
				}
				IL_34:
				if (this.DeletableTypes == null)
				{
					return true;
				}
				num = (short)589889536;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_55:
			return this.DeletableTypes.Contains(A_0);
			IL_13B:
			goto IL_55;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000FE30 File Offset: 0x0000E030
		private bool a(global::Motorola.Common.Communication.Pba.DataBlockType A_0)
		{
			short num = (short)603258881;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.IDDeletableTypes.Count == 0)
					{
						return true;
					}
					num = (short)1362288731;
					short num3 = num;
					num = (short)918413403;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						num = (short)1110507520;
						if (num != 0)
						{
						}
						num = (short)4718594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_117;
				case 3:
					goto IL_53;
				}
				IL_34:
				if (this.IDDeletableTypes != null)
				{
					num = (short)551813123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_53:
				num = (short)321257472;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_117:
			num = (short)897974273;
			if (num != 0)
			{
			}
			num = (short)120717312;
			short num4 = num;
			return this.IDDeletableTypes.Contains(A_0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000FF84 File Offset: 0x0000E184
		public global::System.Collections.Generic.Dictionary<string, string> FindFiles()
		{
			int a_ = 18;
			short num = (short)66060288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				global::Motorola.Common.Communication.Pba.FileSet fileSet;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator3;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1180237829;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (!string.IsNullOrEmpty(fileItem.URI))
									{
										num = (short)500826114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_EA1;
								case 2:
									num = (short)523239428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1064632328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem = enumerator.Current;
									num = (short)639434752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (!dictionary.ContainsKey(fileItem.URI))
									{
										num = (short)1839398918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_D84;
									}
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									dictionary.Add(fileItem.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("胏郑雓韕꣗꫙냛럝菟菡郣迥蟧蓩ꗫ胭華蛱闳髵铷", a_));
									num = (short)167641095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)553779201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DCA:
								num = (short)1043857411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D84:
								goto IL_DCA;
							}
							IL_EA1:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_EB1;
					case 1:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.a));
						num = (short)1998651405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.LanguagePackData != null)
						{
							num = (short)863371281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DD;
					case 3:
						if (fileSet != null)
						{
							num = (short)1675755555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7A;
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)885325850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.e));
						num = (short)1081344015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.b));
						num = (short)743702531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.g));
						num = (short)965804056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)70778886;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)509345795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem2 = enumerator.Current;
									num = (short)1882193927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									dictionary.Add(fileItem2.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("雏돑럓ꋕ럗꣙ꗛ賝藟釡臣鋥", a_));
									num = (short)373424132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									if (!dictionary.ContainsKey(fileItem2.URI))
									{
										num = (short)813236225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1793327112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)418119682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_13E0;
									}
									continue;
								case 7:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									if (!string.IsNullOrEmpty(fileItem2.URI))
									{
										num = (short)292028421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_14F8;
								}
								IL_145D:
								num = (short)187170816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13E0:
								goto IL_145D;
							}
							IL_14F8:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1508;
					case 9:
						if (fileSet != null)
						{
							num = (short)91160580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C90;
					case 10:
						if (fileSet != null)
						{
							num = (short)205455371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB1;
					case 11:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)234487808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							num = (short)1409613827;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									dictionary.Add(languagePackBase.sourceFilePath, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("鳏돑뫓뇕귗믙믛믝냟菡蟣跥믧迩飫", a_));
									num = (short)1269563403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1056505868;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase = enumerator2.Current;
									num = (short)797048834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (languagePackBase is global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)
									{
										num = (short)245235720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2120876038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_19F;
									}
									continue;
								case 4:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									dictionary.Add(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("鳏돑뫓뇕귗믙믛믝냟菡蟣跥믧迩飫", a_));
									num = (short)1205338125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1387397135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!string.IsNullOrEmpty(languagePackBase.sourceFilePath))
									{
										num = (short)1361707013;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!dictionary.ContainsKey(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
									{
										num = (short)521273348;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)602472457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!string.IsNullOrEmpty(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
									{
										num = (short)145555466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)686489607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)141295630;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_3CD;
								case 15:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!dictionary.ContainsKey(languagePackBase.sourceFilePath))
									{
										num = (short)849084416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2EA:
								num = (short)215351297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19F:
								goto IL_2EA;
							}
							IL_3CD:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_3DD;
					case 13:
						if (fileSet != null)
						{
							num = (short)38600729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E3;
					case 14:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)21954568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (fileSet != null)
						{
							num = (short)250413072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10CA;
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)194576411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.LanguagePackData.LanguagePacks.GetEnumerator();
						num = (short)926416908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1721630743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.f));
						num = (short)386662432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.c));
						num = (short)762642441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_179C;
					case 22:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.TTSLanguagePackData.LanguagePacks.GetEnumerator();
						num = (short)1769209886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						try
						{
							num = (short)243728390;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									if (!string.IsNullOrEmpty(fileItem3.URI))
									{
										num = (short)1696858115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									dictionary.Add(fileItem3.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("胏郑雓蛕꫗뗙ꫛ럝鏟诡诣裥臧蓩诫뻭釯釱鿳韵鿷鿹", a_));
									num = (short)1711013892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									if (!dictionary.ContainsKey(fileItem3.URI))
									{
										num = (short)692846593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1280049154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1845493768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_11BE;
									}
									continue;
								case 7:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1663107077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem3 = enumerator.Current;
									num = (short)1589444608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_12DC;
								}
								IL_11F3:
								num = (short)1246232583;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11BE:
								goto IL_11F3;
							}
							IL_12DC:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_12EC;
					case 24:
						if (fileSet != null)
						{
							num = (short)331284494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1508;
					case 25:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)303235105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						try
						{
							num = (short)986054661;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_C80;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									if (!string.IsNullOrEmpty(fileItem4.URI))
									{
										num = (short)235077635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)680984580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									if (!dictionary.ContainsKey(fileItem4.URI))
									{
										num = (short)630259718;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_B6E;
									}
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									dictionary.Add(fileItem4.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("铏蓑蛓藕黗동냛믝鏟뇡臣鋥", a_));
									num = (short)1361182720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1846804481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1490419719;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem4 = enumerator.Current;
									num = (short)133955586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_BE9:
								num = (short)573243400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B6E:
								goto IL_BE9;
							}
							IL_C80:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_C90;
					case 27:
						try
						{
							num = (short)1369899014;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)955318275;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem5 = enumerator.Current;
									num = (short)448200706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1858928647;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									if (!string.IsNullOrEmpty(fileItem5.URI))
									{
										num = (short)592183297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1078001672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									dictionary.Add(fileItem5.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("胏郑雓闕뷗꣙꣛럝蛟诡蟣蟥鳧迩", a_));
									num = (short)1021050884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_FA6;
									}
									continue;
								case 7:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									if (!dictionary.ContainsKey(fileItem5.URI))
									{
										num = (short)1131806725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_10BA;
								}
								IL_1019:
								num = (short)1032257536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA6:
								goto IL_1019;
							}
							IL_10BA:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_10CA;
					case 28:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.d));
						num = (short)377356298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (this.TTSLanguagePackData != null)
						{
							num = (short)1690632214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CC;
					case 30:
						try
						{
							num = (short)2085224451;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									dictionary.Add(ttslanguagePackInfo.PackFilePath, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("蓏蛑蟓髕맗듙믛ꯝ臟藡臣뛥觧觩蟫뷭闯蛱", a_));
									num = (short)286851080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									if (!string.IsNullOrEmpty(ttslanguagePackInfo.PackFilePath))
									{
										num = (short)472973314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)718274565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_492;
									}
									continue;
								case 4:
									num = (short)1702428679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									if (!dictionary.ContainsKey(ttslanguagePackInfo.PackFilePath))
									{
										num = (short)694616064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1970143236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)enumerator2.Current;
									num = (short)738590721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_5BC;
								}
								IL_494:
								num = (short)33685510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_492:
								goto IL_494;
							}
							IL_5BC:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_5CC;
					case 31:
						num = (short)1732968449;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1020788746;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.RadioImage radioImage;
								switch (num2)
								{
								case 0:
									num = (short)825753609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!dictionary.ContainsKey(radioImage.FilePath))
									{
										num = (short)1453588480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_1762;
								case 3:
									if (radioImage.fileData.Count<byte>() == 0)
									{
										num = (short)51576843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator3.MoveNext())
									{
										num = (short)244056072;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioImage = enumerator3.Current;
									num = (short)1402339334;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!string.IsNullOrEmpty(radioImage.FilePath))
									{
										num = (short)222494732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)1054015491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1587216386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (radioImage.fileData != null)
									{
										num = (short)1246298119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1670;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_15B5;
									}
									continue;
								case 11:
									goto IL_1670;
								case 12:
									num = (short)390987777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15B7:
								num = (short)1811152900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15B5:
								goto IL_15B7;
								IL_1670:
								dictionary.Add(radioImage.FilePath, radioImage.FileType.ToString());
								num = (short)225902597;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1762:;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						enumerator3 = this.PreUpdateData.MemoryImages.GetEnumerator();
						num = (short)59441173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (fileSet != null)
						{
							num = (short)748093458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EC;
					case 33:
						try
						{
							num = (short)1594818565;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_7D3;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									if (!dictionary.ContainsKey(fileItem6.URI))
									{
										num = (short)1464139779;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									dictionary.Add(fileItem6.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("蛏뷑뷓뗕뷗鯙닛냝迟韡諣藥跧蟩觫胭蓯", a_));
									num = (short)1097072640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									if (!string.IsNullOrEmpty(fileItem6.URI))
									{
										num = (short)2032599046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_6C0;
									}
									continue;
								case 6:
									num = (short)393740290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1871904769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1461256199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem6 = enumerator.Current;
									num = (short)839712772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_733:
								num = (short)979173384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6C0:
								goto IL_733;
							}
							IL_7D3:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_7E3;
					case 34:
						try
						{
							num = (short)889978885;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									if (!string.IsNullOrEmpty(fileItem7.URI))
									{
										num = (short)840302594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_A6A;
								case 2:
									num = (short)1629224968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1405681670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem7 = enumerator.Current;
									num = (short)1089994752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_903;
									}
									continue;
								case 6:
								{
									num = (short)1939393991;
									short num3 = num;
									num = (short)1667812807;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1138556928;
										if (num != 0)
										{
										}
										num = (short)720175105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									dictionary.Add(fileItem7.URI, global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("鏏鏑韓돕꫗껙뗛룝觟臡藣鋥跧駩", a_));
									num = (short)269942787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									if (!dictionary.ContainsKey(fileItem7.URI))
									{
										num = (short)425721863;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_9C9:
								num = (short)332201988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_903:
								goto IL_9C9;
							}
							IL_A6A:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_A7A;
					case 35:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1765408802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C8;
					IL_3DD:
					num = (short)1288372253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CC:
					num = (short)2069430273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E3:
					num = (short)175505408;
					short num4 = num;
					num = (short)955711494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7A:
					num = (short)1380646932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C90:
					num = (short)1627652124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EB1:
					num = (short)1515192325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10CA:
					num = (short)457768979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12EC:
					num = (short)1541210119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1508:
					enumerator3 = this.UpdateData.MemoryImages.GetEnumerator();
					num = (short)792002591;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179C:
				try
				{
					num = (short)1871577098;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.RadioImage radioImage2;
						switch (num2)
						{
						case 0:
							num = (short)340262914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!enumerator3.MoveNext())
							{
								num = (short)1807155200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							radioImage2 = enumerator3.Current;
							num = (short)1540096004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19A7;
						case 3:
							if (!dictionary.ContainsKey(radioImage2.FilePath))
							{
								num = (short)852361227;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							if (!string.IsNullOrEmpty(radioImage2.FilePath))
							{
								num = (short)2114781192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							if (radioImage2.fileData.Count<byte>() == 0)
							{
								num = (short)1450246156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							num = (short)1492844550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1633878019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (radioImage2.fileData != null)
							{
								num = (short)125239303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18CA;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_17F9;
							}
							continue;
						case 11:
							num = (short)849936393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_18CA;
						}
						goto IL_17F9;
						IL_18CA:
						dictionary.Add(radioImage2.FilePath, radioImage2.FileType.ToString());
						num = (short)159580165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1908:
						num = (short)878444545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17F9:
						goto IL_1908;
					}
					IL_19A7:;
				}
				finally
				{
					((global::System.IDisposable)enumerator3).Dispose();
				}
				return dictionary;
				IL_C8:
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				fileSet = null;
				num = (short)1635385346;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00011A58 File Offset: 0x0000FC58
		public void ReplaceFilesPath(global::System.Collections.Generic.Dictionary<string, string> files)
		{
			short num = (short)1103495168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BF;
				}
				global::Motorola.Common.Communication.Pba.FileSet fileSet;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.j));
						num = (short)1271857186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1826553867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.l));
						num = (short)857407496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.LanguagePackData.LanguagePacks.GetEnumerator();
						num = (short)410451990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)1572667394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_7A9;
								case 1:
									num = (short)688259076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_699;
									}
									continue;
								case 3:
									num = (short)226754560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (files.ContainsKey(fileItem.URI))
									{
										num = (short)1583022085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									fileItem.URI = files[fileItem.URI];
									num = (short)692453383;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (!string.IsNullOrEmpty(fileItem.URI))
									{
										num = (short)811139073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1784676355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem = enumerator.Current;
									num = (short)636944390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_705:
								num = (short)633405448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_699:
								goto IL_705;
							}
							IL_7A9:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_7B9;
					case 5:
						try
						{
							num = (short)1610088449;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_14FF;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									if (!string.IsNullOrEmpty(radioImage.FilePath))
									{
										num = (short)30015493;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									if (files.ContainsKey(radioImage.FilePath))
									{
										num = (short)1290076167;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)934936584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator3.Current;
									num = (short)1779040258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)428867587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1617;
								case 7:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									radioImage.FilePath = files[radioImage.FilePath];
									num = (short)1859780608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)586022918;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1501:
								num = (short)474873860;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14FF:
								goto IL_1501;
							}
							IL_1617:;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						enumerator3 = this.PreUpdateData.MemoryImages.GetEnumerator();
						num = (short)1620836372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)607911937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1040318466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1126;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									if (files.ContainsKey(fileItem2.URI))
									{
										num = (short)878837765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1355350022;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									fileItem2.URI = files[fileItem2.URI];
									num = (short)1142423556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1239;
								case 7:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem2;
									if (!string.IsNullOrEmpty(fileItem2.URI))
									{
										num = (short)1927413760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)710017027;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem2 = enumerator.Current;
									num = (short)480837639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1153:
								num = (short)2115960840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1126:
								goto IL_1153;
							}
							IL_1239:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1249;
					case 7:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.n));
						num = (short)980549642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (fileSet != null)
						{
							num = (short)1641807905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1007;
					case 9:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1057292292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (fileSet != null)
						{
							num = (short)2065235995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1488;
					case 11:
						try
						{
							num = (short)1826160641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									fileItem3.URI = files[fileItem3.URI];
									num = (short)1200750595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8AE;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1050083333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem3 = enumerator.Current;
									num = (short)885129220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									if (!string.IsNullOrEmpty(fileItem3.URI))
									{
										num = (short)708509704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1167392774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_9C2;
								case 7:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem3;
									if (files.ContainsKey(fileItem3.URI))
									{
										num = (short)1291452416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)926482439;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_96B:
								num = (short)800456706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8AE:
								goto IL_96B;
							}
							IL_9C2:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_9D2;
					case 12:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)118161421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						try
						{
							num = (short)1152057345;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CD9;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									if (files.ContainsKey(fileItem4.URI))
									{
										num = (short)1156710405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1086390279;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem4 = enumerator.Current;
									num = (short)1066008580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									if (!string.IsNullOrEmpty(fileItem4.URI))
									{
										num = (short)2105933832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem4;
									fileItem4.URI = files[fileItem4.URI];
									num = (short)1717043200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_DE7;
								case 7:
									num = (short)366804998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1710817282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_D1F:
								num = (short)1448607747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CD9:
								goto IL_D1F;
							}
							IL_DE7:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_DF7;
					case 14:
						try
						{
							num = (short)757006337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1395982342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1368;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									if (files.ContainsKey(fileItem5.URI))
									{
										num = (short)615972869;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)194052098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									fileItem5.URI = files[fileItem5.URI];
									num = (short)1671495684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1478;
								case 7:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1323302912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem5 = enumerator.Current;
									num = (short)483393544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem5;
									if (!string.IsNullOrEmpty(fileItem5.URI))
									{
										num = (short)443940867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_13DE:
								num = (short)1174667271;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1368:
								goto IL_13DE;
							}
							IL_1478:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1488;
					case 15:
					{
						num = (short)1137311744;
						short num3 = num;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1087635462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.h));
						num = (short)1503264799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (fileSet != null)
						{
							num = (short)979632143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1249;
					case 18:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.i));
						num = (short)911736858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (fileSet != null)
						{
							num = (short)305856524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF7;
					case 20:
						goto IL_1652;
					case 21:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.k));
						num = (short)437452819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)1429602305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_190;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (languagePackBase is global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)
									{
										num = (short)1117323270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1591738376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									languagePackBase.sourceFilePath = files[languagePackBase.sourceFilePath];
									num = (short)1208418304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath = files[((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath];
									num = (short)218497028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)932380681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)630194188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!string.IsNullOrEmpty(languagePackBase.sourceFilePath))
									{
										num = (short)1660682253;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (!string.IsNullOrEmpty(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
									{
										num = (short)771817486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)897908743;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase = enumerator2.Current;
									num = (short)503250946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (files.ContainsKey(languagePackBase.sourceFilePath))
									{
										num = (short)1260191747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									goto IL_3BA;
								case 13:
									num = (short)1578631179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)1294794767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase;
									if (files.ContainsKey(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
									{
										num = (short)1227423749;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2D4:
								num = (short)467861514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_190:
								goto IL_2D4;
							}
							IL_3BA:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_3CA;
					case 23:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)819855388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						try
						{
							num = (short)656670721;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)462290950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EEA;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									if (!string.IsNullOrEmpty(fileItem6.URI))
									{
										num = (short)1122959365;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									fileItem6.URI = files[fileItem6.URI];
									num = (short)580845572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1993408520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_FF7;
								case 7:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1911029760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem6 = enumerator.Current;
									num = (short)787611650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem6;
									if (files.ContainsKey(fileItem6.URI))
									{
										num = (short)1411186691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F55:
								num = (short)128778247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EEA:
								goto IL_F55;
							}
							IL_FF7:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1007;
					case 25:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.TTSLanguagePackData.LanguagePacks.GetEnumerator();
						num = (short)722665504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (fileSet != null)
						{
							num = (short)1055981569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D2;
					case 27:
					{
						num = (short)2025848833;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)944701454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						try
						{
							num = (short)1636827137;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1137049606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_AC8;
									}
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									if (files.ContainsKey(fileItem7.URI))
									{
										num = (short)677773317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1320288258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									fileItem7.URI = files[fileItem7.URI];
									num = (short)305463300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_BD4;
								case 7:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)726335488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem7 = enumerator.Current;
									num = (short)191102984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem7;
									if (!string.IsNullOrEmpty(fileItem7.URI))
									{
										num = (short)939982851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_B3B:
								num = (short)432996359;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AC8:
								goto IL_B3B;
							}
							IL_BD4:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_BE4;
					case 29:
						if (this.LanguagePackData != null)
						{
							num = (short)1369243651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CA;
					case 30:
						fileSet = this.FileSetList.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.m));
						num = (short)1210581009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (fileSet != null)
						{
							num = (short)1006960649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B9;
					case 32:
						try
						{
							num = (short)136445954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_596;
								case 1:
									num = (short)2088173576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_47C;
									}
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									ttslanguagePackInfo.PackFilePath = files[ttslanguagePackInfo.PackFilePath];
									num = (short)265945093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1397030912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									if (!string.IsNullOrEmpty(ttslanguagePackInfo.PackFilePath))
									{
										num = (short)82706433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)977403908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)enumerator2.Current;
									num = (short)701366278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
									if (files.ContainsKey(ttslanguagePackInfo.PackFilePath))
									{
										num = (short)1389690883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_47E:
								num = (short)617414663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_47C:
								goto IL_47E;
							}
							IL_596:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_5A6;
					case 33:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = fileSet.FileItemsList.GetEnumerator();
						num = (short)1480851480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (fileSet != null)
						{
							num = (short)2021261335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE4;
					case 35:
						if (this.TTSLanguagePackData != null)
						{
							num = (short)1031602201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A6;
					}
					goto IL_BF;
					IL_3CA:
					num = (short)832700451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A6:
					num = (short)2018902032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B9:
					num = (short)1929904146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D2:
					num = (short)1909850112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE4:
					num = (short)1924071445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF7:
					num = (short)956891138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1007:
					num = (short)1247346718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1249:
					num = (short)1265827847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1488:
					enumerator3 = this.UpdateData.MemoryImages.GetEnumerator();
					num = (short)685244421;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1652:
				try
				{
					num = (short)940769282;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1805;
						case 1:
						{
							global::Motorola.Common.Communication.Pba.RadioImage radioImage2;
							radioImage2.FilePath = files[radioImage2.FilePath];
							num = (short)624099333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_169F;
							}
							continue;
						case 3:
							num = (short)1331822598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_16D6;
						case 6:
						{
							global::Motorola.Common.Communication.Pba.RadioImage radioImage2;
							if (files.ContainsKey(radioImage2.FilePath))
							{
								num = (short)1371275265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							if (!enumerator3.MoveNext())
							{
								num = (short)1533542404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.RadioImage radioImage2 = enumerator3.Current;
							num = (short)2133412651;
							short num4 = num;
							num = (short)1000885035;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_16D6;
							default:
								num = (short)1088880640;
								if (num != 0)
								{
								}
								num = (short)2013003784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::Motorola.Common.Communication.Pba.RadioImage radioImage2;
							if (!string.IsNullOrEmpty(radioImage2.FilePath))
							{
								num = (short)43057155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_16A1:
						num = (short)1808728071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_169F:
						goto IL_16A1;
						IL_16D6:
						num = (short)232914944;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1805:;
				}
				finally
				{
					((global::System.IDisposable)enumerator3).Dispose();
				}
				return;
				IL_BF:
				fileSet = null;
				num = (short)549191709;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00013388 File Offset: 0x00011588
		public void AddBBFFilesPath(global::System.Collections.Generic.Dictionary<string, string> files)
		{
			short num;
			using (global::System.Collections.Generic.Dictionary<string, string>.KeyCollection.Enumerator enumerator = files.Keys.GetEnumerator())
			{
				num = (short)320471042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)77201409;
						if (num != 0)
						{
						}
						break;
					case 1:
					{
						num = (short)1019496751;
						short num3 = num;
						num = (short)1753303343;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)820379648;
							if (num != 0)
							{
							}
							num = (short)442302467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
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
						goto IL_14E;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1508507649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string key = enumerator.Current;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM, files[key]);
						this.UpdateData.MemoryImages.Add(item);
						num = (short)920780800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_B0:
					num = (short)1462829060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					goto IL_B0;
				}
				IL_14E:;
			}
			num = (short)1354563584;
			short num4 = num;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00013538 File Offset: 0x00011738
		public void ReplaceFilesPathWithMemoryImages(global::System.Collections.Generic.Dictionary<string, string> files)
		{
			short num;
			using (global::System.Collections.Generic.Dictionary<string, string>.KeyCollection.Enumerator enumerator = files.Keys.GetEnumerator())
			{
				num = (short)1150156802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DD;
					case 1:
					{
						num = (short)2098420287;
						short num3 = num;
						num = (short)534338111;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)884604928;
							if (num != 0)
							{
							}
							num = (short)720502787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
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
						goto IL_17D;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1198850049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.PbaObject.a a = new global::Motorola.Common.Communication.Pba.PbaObject.a();
						a.a = enumerator.Current;
						this.UpdateData.MemoryImages.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage>(a.b));
						global::Motorola.Common.Communication.Pba.AstroMemoryImage item = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM, files[a.a]);
						this.UpdateData.MemoryImages.Add(item);
						num = (short)1636761600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_46;
					IL_DD:
					num = (short)2021720068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					num = (short)974520321;
					if (num != 0)
					{
					}
					goto IL_DD;
				}
				IL_17D:;
			}
			num = (short)779223040;
			short num4 = num;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00013718 File Offset: 0x00011918
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> GetFileListBySetName(string setName)
		{
			short num = (short)1378615298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_211;
				case 1:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator = this.FileSetList.GetEnumerator();
					num = (short)105185283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					try
					{
						num = (short)1824129028;
						num2 = (int)((global::System.IntPtr)num);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> fileItemsList;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.FileSet fileSet;
								fileItemsList = fileSet.FileItemsList;
								num = (short)2039021574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1EA;
							case 2:
							{
								global::Motorola.Common.Communication.Pba.FileSet fileSet;
								if (fileSet.Name == setName)
								{
									num = (short)1953038336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)125960193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.FileSet fileSet = enumerator.Current;
								num = (short)1481900034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_F2;
								}
								continue;
							case 5:
								goto IL_201;
							case 6:
								goto IL_199;
							}
							IL_F4:
							num = (short)1202935594;
							short num3 = num;
							num = (short)702306090;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_1EA:
								num = (short)1329135621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)702218240;
								if (num != 0)
								{
								}
								num = (short)1862074371;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F2:
							goto IL_F4;
						}
						IL_199:
						return fileItemsList;
						IL_201:
						goto IL_24F;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_211;
				case 4:
					if (this.FileSetList.Count > 0)
					{
						num = (short)2019557377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				}
				IL_38:
				if (this.FileSetList != null)
				{
					num = (short)629669888;
					short num4 = num;
					num = (short)1455947777;
					if (num != 0)
					{
					}
					num = (short)1154613248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_211:
				num = (short)2072379396;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_24F:
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000139BC File Offset: 0x00011BBC
		public global::Motorola.Common.Communication.Pba.FileSet GetFileSetBySet(string setName)
		{
			short num = (short)841351170;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_20A;
				case 1:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator = this.FileSetList.GetEnumerator();
					num = (short)1082064899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					try
					{
						num = (short)140902404;
						num2 = (int)((global::System.IntPtr)num);
						global::Motorola.Common.Communication.Pba.FileSet result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.FileSet fileSet;
								result = fileSet;
								num = (short)1577517062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1E1;
							case 2:
							{
								global::Motorola.Common.Communication.Pba.FileSet fileSet;
								if (fileSet.Name == setName)
								{
									num = (short)1694760960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1356398593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.FileSet fileSet = enumerator.Current;
								num = (short)262144002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_F1;
								}
								continue;
							case 5:
								goto IL_1FA;
							case 6:
								goto IL_192;
							}
							IL_F3:
							num = (short)400807003;
							short num3 = num;
							num = (short)1232983131;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_1E1:
								num = (short)63963141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)81330176;
								if (num != 0)
								{
								}
								num = (short)1850867715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F1:
							goto IL_F3;
						}
						IL_192:
						return result;
						IL_1FA:
						goto IL_249;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_20A;
				case 4:
					if (this.FileSetList.Count > 0)
					{
						num = (short)2043936769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_249;
				}
				IL_39:
				num = (short)1333067777;
				if (num != 0)
				{
				}
				num = (short)1952448512;
				short num4 = num;
				if (this.FileSetList != null)
				{
					num = (short)1307639808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_20A:
				num = (short)1180499972;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_249:
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00013C5C File Offset: 0x00011E5C
		public bool GenerateFileFromMemory(string fileFolder)
		{
			int a_ = 8;
			short num = (short)2094268416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				bool result;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)882573319;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2E6;
								case 1:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									try
									{
										global::System.IO.Stream stream;
										stream.Write(radioImage.fileData, 0, radioImage.fileData.Length);
										goto IL_140;
									}
									finally
									{
										num = (short)464322560;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.IO.Stream stream;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1FC;
												}
												continue;
											case 1:
												goto IL_235;
											case 2:
												((global::System.IDisposable)stream).Dispose();
												num = (short)1294008321;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1FC:
											if (stream == null)
											{
												break;
											}
											num = (short)121372674;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_235:;
									}
									goto IL_238;
									IL_140:
									radioImage.fileData = null;
									string text;
									radioImage.FilePath = text;
									result = true;
									num = (short)686030851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									if (radioImage.fileData.Count<byte>() > 0)
									{
										num = (short)770965508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									string text = global::System.IO.Path.Combine(fileFolder, global::System.Guid.NewGuid().ToString(global::Motorola.Common.Communication.Pba.SpecialFieldsConstant.b("苅", a_)));
									global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(text, global::System.IO.FileAccess.Write);
									num = (short)851378177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.Common.Communication.Pba.RadioImage radioImage;
									if (radioImage.fileData != null)
									{
										num = (short)1680801798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_238;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_FE;
									}
									continue;
								case 8:
									num = (short)1701380096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1196294152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator.Current;
									num = (short)612958213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_16B:
								num = (short)362872841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FE:
								goto IL_16B;
								IL_238:
								num = (short)417988610;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E6:
							return result;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2F9;
					case 1:
					{
						num = (short)1664286720;
						short num3 = num;
						if (!global::System.IO.Directory.Exists(fileFolder))
						{
							num = (short)1874460675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F9;
					}
					case 2:
					{
						num = (short)1085980452;
						short num4 = num;
						num = (short)1633926948;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2125856768;
							if (num != 0)
							{
							}
							goto IL_2F9;
						}
						break;
					}
					case 3:
						global::System.IO.Directory.CreateDirectory(fileFolder);
						num = (short)1544290305;
						if (num != 0)
						{
						}
						num = (short)1326907394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47;
					IL_2F9:
					enumerator = this.UpdateData.MemoryImages.GetEnumerator();
					num = (short)1358430208;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_47:
				result = false;
				num = (short)2014773249;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001405C File Offset: 0x0001225C
		public void ResetPBBJobRebootCount()
		{
			short num = (short)1572667398;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F1;
				case 1:
					goto IL_22E;
				case 2:
					goto IL_20B;
				case 3:
				{
					if (this.UpdateData.MemoryImages.Count != 0)
					{
						num = (short)695468040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1143434243;
					short num3 = num;
					num = (short)1566731267;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20B;
					default:
						num = (short)656736257;
						if (num != 0)
						{
						}
						num = (short)2109734912;
						if (num != 0)
						{
						}
						num = (short)1886715906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)556007427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)654442496;
					short num4 = num;
					if (this.FileSetList.Count == this.FileSetList.Count(new global::System.Func<global::Motorola.Common.Communication.Pba.FileSet, bool>(global::Motorola.Common.Communication.Pba.PbaObject.<>c.<>9.o)))
					{
						num = (short)908722177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
					this.RebootCount = 0;
					num = (short)231211008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.FileSetList.Count == 0)
					{
						num = (short)1073807367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_49:
				if (this.RebootCount > 0)
				{
					num = (short)1910964228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_20B:
				num = (short)1605042181;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			return;
			IL_22E:
			this.RebootCount = 0;
		}

		// Token: 0x04000058 RID: 88
		[global::System.Runtime.Serialization.OptionalField]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> FileItemsList;

		// Token: 0x04000059 RID: 89
		[global::System.Runtime.Serialization.OptionalField]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet> FileSetList;

		// Token: 0x0400005C RID: 92
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData PreUpdateData;

		// Token: 0x04000067 RID: 103
		public byte[] CodeplugBBFBuffer;

		// Token: 0x04000068 RID: 104
		public string AstroPurchasedFlashCode;

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600011B RID: 283 RVA: 0x00015414 File Offset: 0x00013614
			internal bool b(global::Motorola.Common.Communication.Pba.RadioImage A_0)
			{
				short num = (short)11466381;
				short num2 = num;
				num = (short)1867118221;
				switch (num2 == num)
				{
				}
				num = (short)1732247552;
				short num3 = num;
				num = (short)616300544;
				if (num != 0)
				{
				}
				num = (short)877330433;
				if (num != 0)
				{
				}
				return A_0.FilePath == this.a;
			}

			// Token: 0x0400007F RID: 127
			public string a;
		}
	}
}
