using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.DefineAttributes;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200005E RID: 94
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixCodeplug : global::Motorola.CommonCPS.Server.EntityModel.Codeplug
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x0004F598 File Offset: 0x0004D798
		public MatrixCodeplug()
		{
			this.PCRLanguagePacks = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack>();
			this.PCRVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement>();
			this.PCRTextToSpeechs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeech>();
			this.PCRRadioSystems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem>();
			this.PCRSiteSelections = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection>();
			this.PCRDeviceCertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificate>();
			this.PasswordPolicy = global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.None;
			base.CodeplugPassword = "";
			base.PasswordPerDevice = false;
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0004F608 File Offset: 0x0004D808
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		[global::System.Runtime.Serialization.DataMember]
		public int? RadioId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)867659626;
				short num2 = num;
				num = (short)78671722;
				switch (num2 == num)
				{
				}
				num = (short)1459486720;
				if (num != 0)
				{
				}
				num = (short)270204928;
				short num3 = num;
				num = (short)1677918209;
				if (num != 0)
				{
				}
				return this.<RadioId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)735117313;
				if (num != 0)
				{
				}
				num = (short)1608730466;
				short num2 = num;
				num = (short)1581729634;
				switch (num2 == num)
				{
				}
				num = (short)629866496;
				short num3 = num;
				num = (short)1207697408;
				if (num != 0)
				{
				}
				this.<RadioId>k__BackingField = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0004F768 File Offset: 0x0004D968
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0004F81C File Offset: 0x0004DA1C
		[global::System.Runtime.Serialization.DataMember]
		public int? CAI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)564428523;
				short num2 = num;
				num = (short)1251311339;
				switch (num2 == num)
				{
				}
				num = (short)1156972545;
				if (num != 0)
				{
				}
				num = (short)440336384;
				short num3 = num;
				num = (short)481165312;
				if (num != 0)
				{
				}
				return this.<CAI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1610806906;
				short num2 = num;
				num = (short)1466300026;
				switch (num2 == num)
				{
				}
				num = (short)89980928;
				if (num != 0)
				{
				}
				num = (short)1336082432;
				short num3 = num;
				num = (short)1405943809;
				if (num != 0)
				{
				}
				this.<CAI>k__BackingField = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0004F980 File Offset: 0x0004DB80
		[global::System.Runtime.Serialization.DataMember]
		public string FiveToneId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1348011016;
				short num2 = num;
				num = (short)846857224;
				switch (num2 == num)
				{
				}
				num = (short)734396416;
				if (num != 0)
				{
				}
				num = (short)1675952128;
				short num3 = num;
				num = (short)192020481;
				if (num != 0)
				{
				}
				return this.<FiveToneId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1420504952;
				short num2 = num;
				num = (short)836054904;
				switch (num2 == num)
				{
				}
				num = (short)448004097;
				if (num != 0)
				{
				}
				num = (short)1470365696;
				short num3 = num;
				num = (short)164626432;
				if (num != 0)
				{
				}
				this.<FiveToneId>k__BackingField = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0004FA34 File Offset: 0x0004DC34
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0004FAE4 File Offset: 0x0004DCE4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)931511502;
				short num2 = num;
				num = (short)1284619470;
				switch (num2 == num)
				{
				}
				num = (short)1330577409;
				if (num != 0)
				{
				}
				num = (short)717094912;
				short num3 = num;
				num = (short)372506624;
				if (num != 0)
				{
				}
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)504953355;
				short num2 = num;
				num = (short)1348729355;
				switch (num2 == num)
				{
				}
				num = (short)1042219009;
				if (num != 0)
				{
				}
				num = (short)1299251200;
				short num3 = num;
				num = (short)693960704;
				if (num != 0)
				{
				}
				this.<PasswordPolicy>k__BackingField = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0004FB98 File Offset: 0x0004DD98
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0004FC4C File Offset: 0x0004DE4C
		[global::System.Runtime.Serialization.DataMember]
		public int? MaxAttempts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)312060335;
				short num2 = num;
				num = (short)2065082799;
				switch (num2 == num)
				{
				}
				num = (short)1642332160;
				if (num != 0)
				{
				}
				num = (short)1668546560;
				short num3 = num;
				num = (short)1101463553;
				if (num != 0)
				{
				}
				return this.<MaxAttempts>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)419452370;
				short num2 = num;
				num = (short)27219410;
				switch (num2 == num)
				{
				}
				num = (short)389808129;
				if (num != 0)
				{
				}
				num = (short)2063400960;
				short num3 = num;
				num = (short)737148928;
				if (num != 0)
				{
				}
				this.<MaxAttempts>k__BackingField = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0004FCFC File Offset: 0x0004DEFC
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)74480654;
				short num2 = num;
				num = (short)1617460238;
				switch (num2 == num)
				{
				}
				num = (short)1935474689;
				if (num != 0)
				{
				}
				num = (short)1489043456;
				short num3 = num;
				num = (short)2110652416;
				if (num != 0)
				{
				}
				return this.<SubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1098496857;
				short num2 = num;
				num = (short)1159510873;
				switch (num2 == num)
				{
				}
				num = (short)939655169;
				if (num != 0)
				{
				}
				num = (short)319881216;
				short num3 = num;
				num = (short)421396480;
				if (num != 0)
				{
				}
				this.<SubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0004FE5C File Offset: 0x0004E05C
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0004FF08 File Offset: 0x0004E108
		[global::System.Runtime.Serialization.DataMember]
		public int? SubscriberPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)397303225;
				short num2 = num;
				num = (short)2083675577;
				switch (num2 == num)
				{
				}
				num = (short)28901376;
				if (num != 0)
				{
				}
				num = (short)1750663168;
				short num3 = num;
				num = (short)1016659969;
				if (num != 0)
				{
				}
				return this.<SubscriberPort>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)644677632;
				short num2 = num;
				num = (short)1274881339;
				short num3 = num;
				num = (short)822551867;
				switch (num3 == num)
				{
				}
				num = (short)1475084289;
				if (num != 0)
				{
				}
				num = (short)506462208;
				if (num != 0)
				{
				}
				this.<SubscriberPort>k__BackingField = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00050068 File Offset: 0x0004E268
		[global::System.Runtime.Serialization.DataMember]
		public string AccessoryIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)779681792;
				short num2 = num;
				num = (short)127808415;
				short num3 = num;
				num = (short)1354642335;
				switch (num3 == num)
				{
				}
				num = (short)1471676416;
				if (num != 0)
				{
				}
				num = (short)1697775617;
				if (num != 0)
				{
				}
				return this.<AccessoryIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1508638720;
				short num2 = num;
				num = (short)461712023;
				short num3 = num;
				num = (short)1355950743;
				switch (num3 == num)
				{
				}
				num = (short)2027618305;
				if (num != 0)
				{
				}
				num = (short)433192960;
				if (num != 0)
				{
				}
				this.<AccessoryIP>k__BackingField = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00050118 File Offset: 0x0004E318
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x000501C4 File Offset: 0x0004E3C4
		[global::System.Runtime.Serialization.DataMember]
		public bool? BluetoothEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)918224896;
				short num2 = num;
				num = (short)1335772725;
				short num3 = num;
				num = (short)985679413;
				switch (num3 == num)
				{
				}
				num = (short)1344274433;
				if (num != 0)
				{
				}
				num = (short)1107755008;
				if (num != 0)
				{
				}
				return this.<BluetoothEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1008336896;
				short num2 = num;
				num = (short)615691405;
				short num3 = num;
				num = (short)798143629;
				switch (num3 == num)
				{
				}
				num = (short)1420492801;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				if (num != 0)
				{
				}
				this.<BluetoothEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00050274 File Offset: 0x0004E474
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00050328 File Offset: 0x0004E528
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FirmwareCodeplugPairUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1783365632;
				short num2 = num;
				num = (short)64263049;
				short num3 = num;
				num = (short)1704956809;
				switch (num3 == num)
				{
				}
				num = (short)187236352;
				if (num != 0)
				{
				}
				num = (short)229179393;
				if (num != 0)
				{
				}
				return this.<FirmwareCodeplugPairUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1565523968;
				short num2 = num;
				num = (short)1193047230;
				short num3 = num;
				num = (short)2022798526;
				switch (num3 == num)
				{
				}
				num = (short)436011009;
				if (num != 0)
				{
				}
				num = (short)2102067200;
				if (num != 0)
				{
				}
				this.<FirmwareCodeplugPairUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000503D8 File Offset: 0x0004E5D8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0005048C File Offset: 0x0004E68C
		[global::System.Runtime.Serialization.DataMember]
		public int? LanguagePackFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)733609984;
				short num2 = num;
				num = (short)186587763;
				short num3 = num;
				num = (short)676797043;
				switch (num3 == num)
				{
				}
				num = (short)1899102209;
				if (num != 0)
				{
				}
				num = (short)2024144896;
				if (num != 0)
				{
				}
				return this.<LanguagePackFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1805189120;
				short num2 = num;
				num = (short)365578032;
				short num3 = num;
				num = (short)398477104;
				switch (num3 == num)
				{
				}
				num = (short)1902182400;
				if (num != 0)
				{
				}
				num = (short)238354433;
				if (num != 0)
				{
				}
				this.<LanguagePackFamily>k__BackingField = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0005053C File Offset: 0x0004E73C
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000505EC File Offset: 0x0004E7EC
		[global::System.Runtime.Serialization.DataMember]
		public bool? RadioIdCAIEanble
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)487129088;
				short num2 = num;
				num = (short)1678245889;
				if (num != 0)
				{
				}
				num = (short)1096155515;
				short num3 = num;
				num = (short)876675451;
				switch (num3 == num)
				{
				}
				num = (short)215678976;
				if (num != 0)
				{
				}
				return this.<RadioIdCAIEanble>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)818282496;
				short num2 = num;
				num = (short)1265742644;
				short num3 = num;
				num = (short)1901769524;
				switch (num3 == num)
				{
				}
				num = (short)740425728;
				if (num != 0)
				{
				}
				num = (short)910229505;
				if (num != 0)
				{
				}
				this.<RadioIdCAIEanble>k__BackingField = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00050698 File Offset: 0x0004E898
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00050748 File Offset: 0x0004E948
		[global::System.Runtime.Serialization.DataMember]
		public string WAVEUSERID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1969291264;
				short num2 = num;
				num = (short)477928507;
				short num3 = num;
				num = (short)1259052091;
				switch (num3 == num)
				{
				}
				num = (short)722337792;
				if (num != 0)
				{
				}
				num = (short)1177026561;
				if (num != 0)
				{
				}
				return this.<WAVEUSERID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1987706880;
				short num2 = num;
				num = (short)1132657738;
				short num3 = num;
				num = (short)39976010;
				switch (num3 == num)
				{
				}
				num = (short)2083192832;
				if (num != 0)
				{
				}
				num = (short)415629313;
				if (num != 0)
				{
				}
				this.<WAVEUSERID>k__BackingField = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000507FC File Offset: 0x0004E9FC
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x000508AC File Offset: 0x0004EAAC
		[global::System.Runtime.Serialization.DataMember]
		public string WAVEACTIVATIONCODE
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1284374528;
				short num2 = num;
				num = (short)1284354047;
				short num3 = num;
				num = (short)1250406399;
				switch (num3 == num)
				{
				}
				num = (short)893976577;
				if (num != 0)
				{
				}
				num = (short)33357824;
				if (num != 0)
				{
				}
				return this.<WAVEACTIVATIONCODE>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)801243136;
				short num2 = num;
				num = (short)914460924;
				short num3 = num;
				num = (short)1693225212;
				switch (num3 == num)
				{
				}
				num = (short)2019360769;
				if (num != 0)
				{
				}
				num = (short)1336934400;
				if (num != 0)
				{
				}
				this.<WAVEACTIVATIONCODE>k__BackingField = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0005095C File Offset: 0x0004EB5C
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00050A08 File Offset: 0x0004EC08
		[global::System.Runtime.Serialization.DataMember]
		public string WAVEUSERPASSWORD
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1409482752;
				short num2 = num;
				num = (short)992335301;
				short num3 = num;
				num = (short)760272325;
				switch (num3 == num)
				{
				}
				num = (short)1651900416;
				if (num != 0)
				{
				}
				num = (short)2048458753;
				if (num != 0)
				{
				}
				return this.<WAVEUSERPASSWORD>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2061303808;
				short num2 = num;
				num = (short)460212034;
				short num3 = num;
				num = (short)1877624642;
				switch (num3 == num)
				{
				}
				num = (short)842924033;
				if (num != 0)
				{
				}
				num = (short)888471552;
				if (num != 0)
				{
				}
				this.<WAVEUSERPASSWORD>k__BackingField = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00050B6C File Offset: 0x0004ED6C
		[global::System.Runtime.Serialization.DataMember]
		public bool? WAVEUSEREditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1441071104;
				short num2 = num;
				num = (short)452811318;
				short num3 = num;
				num = (short)765942326;
				switch (num3 == num)
				{
				}
				num = (short)1648033793;
				if (num != 0)
				{
				}
				num = (short)557711360;
				if (num != 0)
				{
				}
				return this.<WAVEUSEREditable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)324730880;
				short num2 = num;
				num = (short)789925720;
				short num3 = num;
				num = (short)1062752088;
				switch (num3 == num)
				{
				}
				num = (short)2093547521;
				if (num != 0)
				{
				}
				num = (short)2128347136;
				if (num != 0)
				{
				}
				this.<WAVEUSEREditable>k__BackingField = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00050C1C File Offset: 0x0004EE1C
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00050CC8 File Offset: 0x0004EEC8
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1992556544;
				short num2 = num;
				num = (short)1061193155;
				short num3 = num;
				num = (short)706119107;
				switch (num3 == num)
				{
				}
				num = (short)801964032;
				if (num != 0)
				{
				}
				num = (short)1747845121;
				if (num != 0)
				{
				}
				return this.<FirmwareType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)466878464;
				short num2 = num;
				num = (short)526319617;
				if (num != 0)
				{
				}
				num = (short)1463368235;
				short num3 = num;
				num = (short)583940651;
				switch (num3 == num)
				{
				}
				num = (short)355467264;
				if (num != 0)
				{
				}
				this.<FirmwareType>k__BackingField = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00050D78 File Offset: 0x0004EF78
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00050E24 File Offset: 0x0004F024
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareDTPEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)441974784;
				short num2 = num;
				num = (short)206308762;
				short num3 = num;
				num = (short)876545434;
				switch (num3 == num)
				{
				}
				num = (short)1843789825;
				if (num != 0)
				{
				}
				num = (short)1779499008;
				if (num != 0)
				{
				}
				return this.<FirmwareDTPEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1600258048;
				short num2 = num;
				num = (short)239673324;
				short num3 = num;
				num = (short)1477844972;
				switch (num3 == num)
				{
				}
				num = (short)1292763136;
				if (num != 0)
				{
				}
				num = (short)674365441;
				if (num != 0)
				{
				}
				this.<FirmwareDTPEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00050ED4 File Offset: 0x0004F0D4
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00050F84 File Offset: 0x0004F184
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceInfoFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)236453888;
				short num2 = num;
				num = (short)169569269;
				short num3 = num;
				num = (short)1592290293;
				switch (num3 == num)
				{
				}
				num = (short)932446208;
				if (num != 0)
				{
				}
				num = (short)1297678337;
				if (num != 0)
				{
				}
				return this.<DeviceInfoFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1760755712;
				short num2 = num;
				num = (short)26992546;
				short num3 = num;
				num = (short)1027465122;
				switch (num3 == num)
				{
				}
				num = (short)30212097;
				if (num != 0)
				{
				}
				num = (short)1449066496;
				if (num != 0)
				{
				}
				this.<DeviceInfoFields>k__BackingField = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00051034 File Offset: 0x0004F234
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000510E4 File Offset: 0x0004F2E4
		[global::System.Runtime.Serialization.DataMember]
		public string ExtendedFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1311899648;
				short num2 = num;
				num = (short)1584282112;
				short num3 = num;
				num = (short)852179456;
				switch (num3 == num)
				{
				}
				num = (short)1714552833;
				if (num != 0)
				{
				}
				num = (short)1986330624;
				if (num != 0)
				{
				}
				return this.<ExtendedFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247281152;
				short num2 = num;
				num = (short)2029022623;
				short num3 = num;
				num = (short)103771551;
				switch (num3 == num)
				{
				}
				num = (short)1463091201;
				if (num != 0)
				{
				}
				num = (short)1511325696;
				if (num != 0)
				{
				}
				this.<ExtendedFields>k__BackingField = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00051194 File Offset: 0x0004F394
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00051244 File Offset: 0x0004F444
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		public string LanguageSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)305725440;
				short num2 = num;
				num = (short)447544537;
				short num3 = num;
				num = (short)1544879321;
				switch (num3 == num)
				{
				}
				num = (short)310837249;
				if (num != 0)
				{
				}
				num = (short)831062016;
				if (num != 0)
				{
				}
				return this.<LanguageSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1945174016;
				short num2 = num;
				num = (short)1590951937;
				if (num != 0)
				{
				}
				num = (short)85195108;
				short num3 = num;
				num = (short)951581028;
				switch (num3 == num)
				{
				}
				num = (short)1925447680;
				if (num != 0)
				{
				}
				this.<LanguageSetting>k__BackingField = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000512F4 File Offset: 0x0004F4F4
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x000513A8 File Offset: 0x0004F5A8
		[global::System.Runtime.Serialization.DataMember]
		public string VAPackageNameLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1877737472;
				short num2 = num;
				num = (short)1680728830;
				short num3 = num;
				num = (short)871162622;
				switch (num3 == num)
				{
				}
				num = (short)124780545;
				if (num != 0)
				{
				}
				num = (short)198311936;
				if (num != 0)
				{
				}
				return this.<VAPackageNameLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1203437568;
				short num2 = num;
				num = (short)486992420;
				short num3 = num;
				num = (short)714467876;
				switch (num3 == num)
				{
				}
				num = (short)1753808897;
				if (num != 0)
				{
				}
				num = (short)457506816;
				if (num != 0)
				{
				}
				this.<VAPackageNameLst>k__BackingField = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00051458 File Offset: 0x0004F658
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00051508 File Offset: 0x0004F708
		[global::System.Runtime.Serialization.DataMember]
		public string LanguagePackageLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)678690816;
				short num2 = num;
				num = (short)1659303648;
				short num3 = num;
				num = (short)148764384;
				switch (num3 == num)
				{
				}
				num = (short)2077425665;
				if (num != 0)
				{
				}
				num = (short)1162477568;
				if (num != 0)
				{
				}
				return this.<LanguagePackageLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)253493248;
				short num2 = num;
				num = (short)474642007;
				short num3 = num;
				num = (short)450000471;
				switch (num3 == num)
				{
				}
				num = (short)1590034432;
				if (num != 0)
				{
				}
				num = (short)2133327873;
				if (num != 0)
				{
				}
				this.<LanguagePackageLst>k__BackingField = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000515B8 File Offset: 0x0004F7B8
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00051668 File Offset: 0x0004F868
		[global::System.Runtime.Serialization.DataMember]
		public string VASetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1847721984;
				short num2 = num;
				num = (short)1653660938;
				short num3 = num;
				num = (short)1641667850;
				switch (num3 == num)
				{
				}
				num = (short)871432192;
				if (num != 0)
				{
				}
				num = (short)949551105;
				if (num != 0)
				{
				}
				return this.<VASetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)982515712;
				short num2 = num;
				num = (short)341980224;
				short num3 = num;
				num = (short)1577399360;
				switch (num3 == num)
				{
				}
				num = (short)701300737;
				if (num != 0)
				{
				}
				num = (short)1358364672;
				if (num != 0)
				{
				}
				this.<VASetting>k__BackingField = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0005171C File Offset: 0x0004F91C
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000517CC File Offset: 0x0004F9CC
		[global::System.Runtime.Serialization.DataMember]
		public string TTSSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)776208384;
				short num2 = num;
				num = (short)1824568170;
				short num3 = num;
				num = (short)1316860778;
				switch (num3 == num)
				{
				}
				num = (short)500760576;
				if (num != 0)
				{
				}
				num = (short)220266497;
				if (num != 0)
				{
				}
				return this.<TTSSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1518010368;
				short num2 = num;
				num = (short)841159907;
				short num3 = num;
				num = (short)1604261091;
				switch (num3 == num)
				{
				}
				num = (short)466288640;
				if (num != 0)
				{
				}
				num = (short)740360193;
				if (num != 0)
				{
				}
				this.<TTSSetting>k__BackingField = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0005187C File Offset: 0x0004FA7C
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0005192C File Offset: 0x0004FB2C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsNA25KhzModel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2080768000;
				short num2 = num;
				num = (short)321847297;
				if (num != 0)
				{
				}
				num = (short)1828834994;
				short num3 = num;
				num = (short)1505218226;
				switch (num3 == num)
				{
				}
				num = (short)304021504;
				if (num != 0)
				{
				}
				return this.<IsNA25KhzModel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)725352448;
				short num2 = num;
				num = (short)713338928;
				short num3 = num;
				num = (short)2083631152;
				switch (num3 == num)
				{
				}
				num = (short)1553203201;
				if (num != 0)
				{
				}
				num = (short)84606976;
				if (num != 0)
				{
				}
				this.<IsNA25KhzModel>k__BackingField = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000519DC File Offset: 0x0004FBDC
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00051A8C File Offset: 0x0004FC8C
		[global::System.Runtime.Serialization.DataMember]
		public int PCRDeviceCertificatesCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)439877632;
				short num2 = num;
				num = (short)607846401;
				if (num != 0)
				{
				}
				num = (short)2053129686;
				short num3 = num;
				num = (short)905659862;
				switch (num3 == num)
				{
				}
				num = (short)249823232;
				if (num != 0)
				{
				}
				return this.<PCRDeviceCertificatesCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)726204416;
				short num2 = num;
				num = (short)1461119731;
				short num3 = num;
				num = (short)1527573235;
				switch (num3 == num)
				{
				}
				num = (short)201457665;
				if (num != 0)
				{
				}
				num = (short)807075840;
				if (num != 0)
				{
				}
				this.<PCRDeviceCertificatesCount>k__BackingField = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00051B3C File Offset: 0x0004FD3C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00051BEC File Offset: 0x0004FDEC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.LinkType? LinkType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1231749120;
				short num2 = num;
				num = (short)933133505;
				short num3 = num;
				num = (short)1829534913;
				switch (num3 == num)
				{
				}
				num = (short)304414721;
				if (num != 0)
				{
				}
				num = (short)1685061632;
				if (num != 0)
				{
				}
				return this.<LinkType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1072365568;
				short num2 = num;
				num = (short)1711865857;
				if (num != 0)
				{
				}
				num = (short)897329210;
				short num3 = num;
				num = (short)1478895674;
				switch (num3 == num)
				{
				}
				num = (short)1680474112;
				if (num != 0)
				{
				}
				this.<LinkType>k__BackingField = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00051CA0 File Offset: 0x0004FEA0
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00051D50 File Offset: 0x0004FF50
		[global::System.Runtime.Serialization.DataMember]
		public string MasterIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)555810816;
				short num2 = num;
				num = (short)1998276071;
				short num3 = num;
				num = (short)1269188071;
				switch (num3 == num)
				{
				}
				num = (short)374407168;
				if (num != 0)
				{
				}
				num = (short)854589441;
				if (num != 0)
				{
				}
				return this.<MasterIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1196032000;
				short num2 = num;
				num = (short)505269175;
				short num3 = num;
				num = (short)1709951927;
				switch (num3 == num)
				{
				}
				num = (short)1120862208;
				if (num != 0)
				{
				}
				num = (short)635437057;
				if (num != 0)
				{
				}
				this.<MasterIP>k__BackingField = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00051E00 File Offset: 0x00050000
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00051EB0 File Offset: 0x000500B0
		[global::System.Runtime.Serialization.DataMember]
		public string MasterUDPPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)518586368;
				short num2 = num;
				num = (short)959601214;
				short num3 = num;
				num = (short)1861900862;
				switch (num3 == num)
				{
				}
				num = (short)449642496;
				if (num != 0)
				{
				}
				num = (short)1574371329;
				if (num != 0)
				{
				}
				return this.<MasterUDPPort>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)194052096;
				short num2 = num;
				num = (short)859375550;
				short num3 = num;
				num = (short)538118078;
				switch (num3 == num)
				{
				}
				num = (short)1358757889;
				if (num != 0)
				{
				}
				num = (short)1484652544;
				if (num != 0)
				{
				}
				this.<MasterUDPPort>k__BackingField = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00051F64 File Offset: 0x00050164
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00052014 File Offset: 0x00050214
		[global::System.Runtime.Serialization.DataMember]
		public string AuthenticationKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1224278016;
				short num2 = num;
				num = (short)1019379576;
				short num3 = num;
				num = (short)2038136696;
				switch (num3 == num)
				{
				}
				num = (short)496107521;
				if (num != 0)
				{
				}
				num = (short)1814560768;
				if (num != 0)
				{
				}
				return this.<AuthenticationKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2140274688;
				short num2 = num;
				num = (short)1316498386;
				short num3 = num;
				num = (short)1683303378;
				switch (num3 == num)
				{
				}
				num = (short)1749680128;
				if (num != 0)
				{
				}
				num = (short)1862729729;
				if (num != 0)
				{
				}
				this.<AuthenticationKey>k__BackingField = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000520C4 File Offset: 0x000502C4
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00052170 File Offset: 0x00050370
		[global::System.Runtime.Serialization.DataMember]
		public string DMR3ControllerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1845624832;
				short num2 = num;
				num = (short)1678648390;
				short num3 = num;
				num = (short)1917789254;
				switch (num3 == num)
				{
				}
				num = (short)2091778049;
				if (num != 0)
				{
				}
				num = (short)1806761984;
				if (num != 0)
				{
				}
				return this.<DMR3ControllerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1408499712;
				short num2 = num;
				num = (short)999842412;
				short num3 = num;
				num = (short)1992319596;
				switch (num3 == num)
				{
				}
				num = (short)1580597248;
				if (num != 0)
				{
				}
				num = (short)1678508033;
				if (num != 0)
				{
				}
				this.<DMR3ControllerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00052220 File Offset: 0x00050420
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000522D0 File Offset: 0x000504D0
		[global::System.Runtime.Serialization.DataMember]
		public string DMR3ControllerUDPPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)397147035;
				short num2 = num;
				num = (short)575404955;
				switch (num2 == num)
				{
				}
				num = (short)1214644224;
				short num3 = num;
				num = (short)1623851008;
				if (num != 0)
				{
				}
				num = (short)503513089;
				if (num != 0)
				{
				}
				return this.<DMR3ControllerUDPPort>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1359740929;
				if (num != 0)
				{
				}
				num = (short)316943541;
				short num2 = num;
				num = (short)101461173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)242679808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120417280;
				if (num != 0)
				{
				}
				this.<DMR3ControllerUDPPort>k__BackingField = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00052380 File Offset: 0x00050580
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00052430 File Offset: 0x00050630
		[global::System.Runtime.Serialization.DataMember]
		public string DMR3NetworkID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1269839254;
				short num2 = num;
				num = (short)1623274902;
				switch (num2 == num)
				{
				}
				num = (short)678232064;
				short num3 = num;
				num = (short)967639041;
				if (num != 0)
				{
				}
				num = (short)90177536;
				if (num != 0)
				{
				}
				return this.<DMR3NetworkID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)93266830;
				short num2 = num;
				num = (short)815735694;
				switch (num2 == num)
				{
				}
				num = (short)1583153152;
				short num3 = num;
				num = (short)467337216;
				if (num != 0)
				{
				}
				num = (short)2103181313;
				if (num != 0)
				{
				}
				this.<DMR3NetworkID>k__BackingField = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000524E0 File Offset: 0x000506E0
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00052590 File Offset: 0x00050790
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair PCRFirmwareCodeplugPair
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1269309345;
				short num2 = num;
				num = (short)1453465505;
				switch (num2 == num)
				{
				}
				num = (short)1507852288;
				short num3 = num;
				num = (short)601423873;
				if (num != 0)
				{
				}
				num = (short)2070675456;
				if (num != 0)
				{
				}
				return this.<PCRFirmwareCodeplugPair>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1355153409;
				if (num != 0)
				{
				}
				num = (short)2025591731;
				short num2 = num;
				num = (short)1268913075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600178688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)413925376;
				if (num != 0)
				{
				}
				this.<PCRFirmwareCodeplugPair>k__BackingField = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0005263C File Offset: 0x0005083C
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000526F0 File Offset: 0x000508F0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack> PCRLanguagePacks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)605535905;
				short num2 = num;
				num = (short)59031201;
				switch (num2 == num)
				{
				}
				num = (short)1231945728;
				short num3 = num;
				num = (short)1344864256;
				if (num != 0)
				{
				}
				num = (short)1201537025;
				if (num != 0)
				{
				}
				return this.<PCRLanguagePacks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1757767315;
				short num2 = num;
				num = (short)365979283;
				switch (num2 == num)
				{
				}
				num = (short)1845559296;
				short num3 = num;
				num = (short)1528299520;
				if (num != 0)
				{
				}
				num = (short)1261305857;
				if (num != 0)
				{
				}
				this.<PCRLanguagePacks>k__BackingField = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000527A4 File Offset: 0x000509A4
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00052854 File Offset: 0x00050A54
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificate> PCRDeviceCertificates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1460928513;
				if (num != 0)
				{
				}
				num = (short)2141944461;
				short num2 = num;
				num = (short)873888397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)317128704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632553472;
				if (num != 0)
				{
				}
				return this.<PCRDeviceCertificates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1936926185;
				short num2 = num;
				num = (short)2100766185;
				switch (num2 == num)
				{
				}
				num = (short)299106304;
				short num3 = num;
				num = (short)1703018496;
				if (num != 0)
				{
				}
				num = (short)1576992769;
				if (num != 0)
				{
				}
				this.<PCRDeviceCertificates>k__BackingField = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00052904 File Offset: 0x00050B04
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x000529B4 File Offset: 0x00050BB4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncement> PCRVoiceAnnouncements
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1409513444;
				short num2 = num;
				num = (short)693663716;
				switch (num2 == num)
				{
				}
				num = (short)81002496;
				short num3 = num;
				num = (short)375259136;
				if (num != 0)
				{
				}
				num = (short)135266305;
				if (num != 0)
				{
				}
				return this.<PCRVoiceAnnouncements>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)862920974;
				short num2 = num;
				num = (short)1783046414;
				switch (num2 == num)
				{
				}
				num = (short)1293484032;
				short num3 = num;
				num = (short)875954177;
				if (num != 0)
				{
				}
				num = (short)1299709952;
				if (num != 0)
				{
				}
				this.<PCRVoiceAnnouncements>k__BackingField = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00052A68 File Offset: 0x00050C68
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00052B18 File Offset: 0x00050D18
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeech> PCRTextToSpeechs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)518218801;
				short num2 = num;
				num = (short)540763185;
				switch (num2 == num)
				{
				}
				num = (short)1241186304;
				short num3 = num;
				num = (short)784269313;
				if (num != 0)
				{
				}
				num = (short)622002176;
				if (num != 0)
				{
				}
				return this.<PCRTextToSpeechs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1192236886;
				short num2 = num;
				num = (short)1435375446;
				switch (num2 == num)
				{
				}
				num = (short)991952896;
				short num3 = num;
				num = (short)1563230209;
				if (num != 0)
				{
				}
				num = (short)855506944;
				if (num != 0)
				{
				}
				this.<PCRTextToSpeechs>k__BackingField = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00052BC8 File Offset: 0x00050DC8
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00052C78 File Offset: 0x00050E78
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem> PCRRadioSystems
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)729463891;
				short num2 = num;
				num = (short)1723120723;
				switch (num2 == num)
				{
				}
				num = (short)742391808;
				short num3 = num;
				num = (short)1150681089;
				if (num != 0)
				{
				}
				num = (short)250609664;
				if (num != 0)
				{
				}
				return this.<PCRRadioSystems>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1026696675;
				short num2 = num;
				num = (short)205137379;
				switch (num2 == num)
				{
				}
				num = (short)1140981760;
				short num3 = num;
				num = (short)833683456;
				if (num != 0)
				{
				}
				num = (short)1410596865;
				if (num != 0)
				{
				}
				this.<PCRRadioSystems>k__BackingField = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00052D28 File Offset: 0x00050F28
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00052DD8 File Offset: 0x00050FD8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection> PCRSiteSelections
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2103713599;
				short num2 = num;
				num = (short)207036223;
				switch (num2 == num)
				{
				}
				num = (short)1241186304;
				short num3 = num;
				num = (short)1878786048;
				if (num != 0)
				{
				}
				num = (short)1935998977;
				if (num != 0)
				{
				}
				return this.<PCRSiteSelections>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1063549886;
				short num2 = num;
				num = (short)959609790;
				switch (num2 == num)
				{
				}
				num = (short)100270080;
				short num3 = num;
				num = (short)114360320;
				if (num != 0)
				{
				}
				num = (short)468844545;
				if (num != 0)
				{
				}
				this.<PCRSiteSelections>k__BackingField = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00052E88 File Offset: 0x00051088
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00052F38 File Offset: 0x00051138
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		public byte? SMADate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2145312145;
				short num2 = num;
				num = (short)1194974609;
				switch (num2 == num)
				{
				}
				num = (short)1795751936;
				short num3 = num;
				num = (short)1554644992;
				if (num != 0)
				{
				}
				num = (short)1058930689;
				if (num != 0)
				{
				}
				return this.<SMADate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1879375873;
				if (num != 0)
				{
				}
				num = (short)1967505633;
				short num2 = num;
				num = (short)347324641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)820969472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1757216768;
				if (num != 0)
				{
				}
				this.<SMADate>k__BackingField = value;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00052FE8 File Offset: 0x000511E8
		[global::System.Runtime.Serialization.OnDeserializing]
		private void a(global::System.Runtime.Serialization.StreamingContext A_0)
		{
			short num = (short)1526464513;
			if (num != 0)
			{
			}
			num = (short)1202388992;
			short num2 = num;
			num = (short)693860496;
			short num3 = num;
			num = (short)1960081552;
			switch (num3 == num)
			{
			}
			num = (short)900857856;
			if (num != 0)
			{
			}
			this.PCRRadioSystems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem>();
			this.PCRSiteSelections = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelection>();
			this.PCRDeviceCertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificate>();
		}
	}
}
