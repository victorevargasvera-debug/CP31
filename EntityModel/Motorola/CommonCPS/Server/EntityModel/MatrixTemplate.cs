using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000068 RID: 104
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixTemplate : global::Motorola.CommonCPS.Server.EntityModel.Template
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x00058C70 File Offset: 0x00056E70
		public MatrixTemplate()
		{
			this.PCRLanguagePacks = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack>();
			this.PCRVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement>();
			this.PCRTextToSpeechs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeech>();
			this.MatrixPrivacyKeys = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>();
			this.MatrixRASKeys = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>();
			this.MatrixSymmetricKeys = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>();
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00058CC8 File Offset: 0x00056EC8
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00058D7C File Offset: 0x00056F7C
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string CFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)447978195;
				short num2 = num;
				num = (short)534747859;
				switch (num2 == num)
				{
				}
				num = (short)880476161;
				if (num != 0)
				{
				}
				num = (short)1722613760;
				if (num != 0)
				{
				}
				num = (short)1536622592;
				short num3 = num;
				return this.<CFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)455256091;
				short num2 = num;
				num = (short)1969924123;
				switch (num2 == num)
				{
				}
				num = (short)258932737;
				if (num != 0)
				{
				}
				num = (short)1483014144;
				if (num != 0)
				{
				}
				num = (short)527171584;
				short num3 = num;
				this.<CFS>k__BackingField = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00058E2C File Offset: 0x0005702C
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00058EDC File Offset: 0x000570DC
		[global::System.Runtime.Serialization.DataMember]
		public string CFSEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1319384458;
				short num2 = num;
				num = (short)51983754;
				switch (num2 == num)
				{
				}
				num = (short)2076835840;
				if (num != 0)
				{
				}
				num = (short)2070282241;
				if (num != 0)
				{
				}
				num = (short)1987510272;
				short num3 = num;
				return this.<CFSEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)505189247;
				short num2 = num;
				num = (short)1391104895;
				switch (num2 == num)
				{
				}
				num = (short)1570766849;
				if (num != 0)
				{
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				num = (short)1646854144;
				short num3 = num;
				this.<CFSEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00058F8C File Offset: 0x0005718C
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x0005903C File Offset: 0x0005723C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? MatrixOTAPKeyUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1034844649;
				short num2 = num;
				num = (short)1754036713;
				switch (num2 == num)
				{
				}
				num = (short)1771110401;
				if (num != 0)
				{
				}
				num = (short)585498624;
				if (num != 0)
				{
				}
				num = (short)570753024;
				short num3 = num;
				return this.<MatrixOTAPKeyUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1513684993;
				if (num != 0)
				{
				}
				num = (short)1994183181;
				short num2 = num;
				num = (short)31642125;
				switch (num2 == num)
				{
				}
				num = (short)958726144;
				if (num != 0)
				{
				}
				num = (short)851312640;
				short num3 = num;
				this.<MatrixOTAPKeyUuid>k__BackingField = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000590EC File Offset: 0x000572EC
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0005919C File Offset: 0x0005739C
		[global::System.Runtime.Serialization.DataMember]
		public bool? BluetoothEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)879300625;
				short num2 = num;
				num = (short)1562644497;
				switch (num2 == num)
				{
				}
				num = (short)1879834625;
				if (num != 0)
				{
				}
				num = (short)685834240;
				if (num != 0)
				{
				}
				num = (short)1943928832;
				short num3 = num;
				return this.<BluetoothEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)436564048;
				short num2 = num;
				num = (short)1233809488;
				switch (num2 == num)
				{
				}
				num = (short)559022080;
				if (num != 0)
				{
				}
				num = (short)1023606785;
				if (num != 0)
				{
				}
				num = (short)114622464;
				short num3 = num;
				this.<BluetoothEnable>k__BackingField = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0005924C File Offset: 0x0005744C
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000592FC File Offset: 0x000574FC
		[global::System.Runtime.Serialization.DataMember]
		public string TanapaNo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)730138583;
				short num2 = num;
				num = (short)1365510103;
				switch (num2 == num)
				{
				}
				num = (short)1889861632;
				if (num != 0)
				{
				}
				num = (short)238092289;
				if (num != 0)
				{
				}
				num = (short)332529664;
				short num3 = num;
				return this.<TanapaNo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)164313235;
				short num2 = num;
				num = (short)1932671123;
				switch (num2 == num)
				{
				}
				num = (short)1662124033;
				if (num != 0)
				{
				}
				num = (short)1801912320;
				if (num != 0)
				{
				}
				num = (short)2020605952;
				short num3 = num;
				this.<TanapaNo>k__BackingField = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000593B0 File Offset: 0x000575B0
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x0005945C File Offset: 0x0005765C
		[global::System.Runtime.Serialization.DataMember]
		public int? LanguagePackFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)311150081;
				short num2 = num;
				num = (short)1870251521;
				switch (num2 == num)
				{
				}
				num = (short)603521025;
				if (num != 0)
				{
				}
				num = (short)659226624;
				if (num != 0)
				{
				}
				num = (short)1571880960;
				short num3 = num;
				return this.<LanguagePackFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1427787754;
				short num2 = num;
				num = (short)1600147434;
				switch (num2 == num)
				{
				}
				num = (short)547618816;
				if (num != 0)
				{
				}
				num = (short)2062680065;
				if (num != 0)
				{
				}
				num = (short)15532032;
				short num3 = num;
				this.<LanguagePackFamily>k__BackingField = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00059510 File Offset: 0x00057710
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000595C0 File Offset: 0x000577C0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? RegionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)114316837;
				short num2 = num;
				num = (short)762205733;
				switch (num2 == num)
				{
				}
				num = (short)1889075201;
				if (num != 0)
				{
				}
				num = (short)2000945152;
				if (num != 0)
				{
				}
				num = (short)44957696;
				short num3 = num;
				return this.<RegionName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1238448175;
				short num2 = num;
				num = (short)44120111;
				switch (num2 == num)
				{
				}
				num = (short)1104740352;
				if (num != 0)
				{
				}
				num = (short)783220737;
				if (num != 0)
				{
				}
				num = (short)1320419328;
				short num3 = num;
				this.<RegionName>k__BackingField = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00059670 File Offset: 0x00057870
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00059724 File Offset: 0x00057924
		[global::System.Runtime.Serialization.DataMember]
		public string CFSApplicationInformation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1198856055;
				short num2 = num;
				num = (short)170530679;
				switch (num2 == num)
				{
				}
				num = (short)1107755008;
				if (num != 0)
				{
				}
				num = (short)119668737;
				if (num != 0)
				{
				}
				num = (short)1086783488;
				short num3 = num;
				return this.<CFSApplicationInformation>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)846836344;
				short num2 = num;
				num = (short)497595000;
				switch (num2 == num)
				{
				}
				num = (short)685244417;
				if (num != 0)
				{
				}
				num = (short)1618411520;
				if (num != 0)
				{
				}
				num = (short)1666449408;
				short num3 = num;
				this.<CFSApplicationInformation>k__BackingField = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000597D0 File Offset: 0x000579D0
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00059880 File Offset: 0x00057A80
		[global::System.Runtime.Serialization.DataMember]
		public int FirmwareType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1920593914;
				short num2 = num;
				num = (short)314830842;
				switch (num2 == num)
				{
				}
				num = (short)857800704;
				if (num != 0)
				{
				}
				num = (short)1259929601;
				if (num != 0)
				{
				}
				num = (short)696385536;
				short num3 = num;
				return this.<FirmwareType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2142300295;
				short num2 = num;
				num = (short)1335945351;
				switch (num2 == num)
				{
				}
				num = (short)1181483009;
				if (num != 0)
				{
				}
				num = (short)1045168128;
				if (num != 0)
				{
				}
				num = (short)1052835840;
				short num3 = num;
				this.<FirmwareType>k__BackingField = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00059930 File Offset: 0x00057B30
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000599E0 File Offset: 0x00057BE0
		[global::System.Runtime.Serialization.DataMember]
		public bool? RadioIdCAIEanble
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1827084778;
				short num2 = num;
				num = (short)1160845802;
				switch (num2 == num)
				{
				}
				num = (short)829358080;
				if (num != 0)
				{
				}
				num = (short)2084765697;
				if (num != 0)
				{
				}
				num = (short)1970798592;
				short num3 = num;
				return this.<RadioIdCAIEanble>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1859780609;
				if (num != 0)
				{
				}
				num = (short)545099349;
				short num2 = num;
				num = (short)997494357;
				switch (num2 == num)
				{
				}
				num = (short)506134528;
				if (num != 0)
				{
				}
				num = (short)1940652032;
				short num3 = num;
				this.<RadioIdCAIEanble>k__BackingField = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00059A90 File Offset: 0x00057C90
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00059B40 File Offset: 0x00057D40
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey MatrixOTAPKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)613824386;
				short num2 = num;
				num = (short)1367553922;
				switch (num2 == num)
				{
				}
				num = (short)1872822273;
				if (num != 0)
				{
				}
				num = (short)1319043072;
				if (num != 0)
				{
				}
				num = (short)1104084992;
				short num3 = num;
				return this.<MatrixOTAPKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)153812867;
				short num2 = num;
				num = (short)1380122499;
				switch (num2 == num)
				{
				}
				num = (short)755433473;
				if (num != 0)
				{
				}
				num = (short)57933824;
				if (num != 0)
				{
				}
				num = (short)806748160;
				short num3 = num;
				this.<MatrixOTAPKey>k__BackingField = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00059BF0 File Offset: 0x00057DF0
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00059CA0 File Offset: 0x00057EA0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack> PCRLanguagePacks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)386445749;
				short num2 = num;
				num = (short)132362677;
				switch (num2 == num)
				{
				}
				num = (short)584187905;
				if (num != 0)
				{
				}
				num = (short)1770520576;
				if (num != 0)
				{
				}
				num = (short)462422016;
				short num3 = num;
				return this.<PCRLanguagePacks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)306274626;
				short num2 = num;
				num = (short)1421238594;
				switch (num2 == num)
				{
				}
				num = (short)1051394049;
				if (num != 0)
				{
				}
				num = (short)459866112;
				if (num != 0)
				{
				}
				num = (short)286588928;
				short num3 = num;
				this.<PCRLanguagePacks>k__BackingField = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00059D50 File Offset: 0x00057F50
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00059E04 File Offset: 0x00058004
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement> PCRVoiceAnnouncements
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)854626206;
				short num2 = num;
				num = (short)1033670558;
				switch (num2 == num)
				{
				}
				num = (short)1999372289;
				if (num != 0)
				{
				}
				num = (short)1318191104;
				if (num != 0)
				{
				}
				num = (short)450363392;
				short num3 = num;
				return this.<PCRVoiceAnnouncements>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)875416599;
				short num2 = num;
				num = (short)1007995927;
				switch (num2 == num)
				{
				}
				num = (short)462618625;
				if (num != 0)
				{
				}
				num = (short)1205403648;
				if (num != 0)
				{
				}
				num = (short)779550720;
				short num3 = num;
				this.<PCRVoiceAnnouncements>k__BackingField = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00059EB4 File Offset: 0x000580B4
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00059F60 File Offset: 0x00058160
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeech> PCRTextToSpeechs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1277877713;
				short num2 = num;
				num = (short)1481432529;
				switch (num2 == num)
				{
				}
				num = (short)1386020865;
				if (num != 0)
				{
				}
				num = (short)676724736;
				if (num != 0)
				{
				}
				num = (short)579469312;
				short num3 = num;
				return this.<PCRTextToSpeechs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)330107952;
				short num2 = num;
				num = (short)1611729968;
				switch (num2 == num)
				{
				}
				num = (short)1092091905;
				if (num != 0)
				{
				}
				num = (short)1646657536;
				if (num != 0)
				{
				}
				num = (short)200409088;
				short num3 = num;
				this.<PCRTextToSpeechs>k__BackingField = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0005A00C File Offset: 0x0005820C
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x0005A0BC File Offset: 0x000582BC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> MatrixPrivacyKeys
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1567817728;
				short num2 = num;
				num = (short)262718337;
				short num3 = num;
				num = (short)2121122689;
				switch (num3 == num)
				{
				}
				num = (short)349831169;
				if (num != 0)
				{
				}
				num = (short)990445568;
				if (num != 0)
				{
				}
				return this.<MatrixPrivacyKeys>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1440481280;
				short num2 = num;
				num = (short)899022849;
				if (num != 0)
				{
				}
				num = (short)1097001806;
				short num3 = num;
				num = (short)1745152846;
				switch (num3 == num)
				{
				}
				num = (short)74973184;
				if (num != 0)
				{
				}
				this.<MatrixPrivacyKeys>k__BackingField = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0005A170 File Offset: 0x00058370
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x0005A220 File Offset: 0x00058420
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> MatrixRASKeys
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1195966464;
				short num2 = num;
				num = (short)1583284226;
				short num3 = num;
				num = (short)225705986;
				switch (num3 == num)
				{
				}
				num = (short)785055744;
				if (num != 0)
				{
				}
				num = (short)29360129;
				if (num != 0)
				{
				}
				return this.<MatrixRASKeys>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)211288064;
				short num2 = num;
				num = (short)951158894;
				short num3 = num;
				num = (short)1128302702;
				switch (num3 == num)
				{
				}
				num = (short)1495269377;
				if (num != 0)
				{
				}
				num = (short)1170145280;
				if (num != 0)
				{
				}
				this.<MatrixRASKeys>k__BackingField = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0005A2D0 File Offset: 0x000584D0
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x0005A384 File Offset: 0x00058584
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> MatrixSymmetricKeys
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)788856832;
				short num2 = num;
				num = (short)1028100790;
				short num3 = num;
				num = (short)1324847798;
				switch (num3 == num)
				{
				}
				num = (short)1164050433;
				if (num != 0)
				{
				}
				num = (short)1636106240;
				if (num != 0)
				{
				}
				return this.<MatrixSymmetricKeys>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)995098624;
				short num2 = num;
				num = (short)1971034174;
				short num3 = num;
				num = (short)268933182;
				switch (num3 == num)
				{
				}
				num = (short)1253507073;
				if (num != 0)
				{
				}
				num = (short)462487552;
				if (num != 0)
				{
				}
				this.<MatrixSymmetricKeys>k__BackingField = value;
			}
		}
	}
}
