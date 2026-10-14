using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000114 RID: 276
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportConvergeRadioFromCSVRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportPBBRadioFromCSVRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ImportMatrixRadioFromCSVRequest))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public abstract class ImportRadioFromCSVRequest
	{
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000AA478 File Offset: 0x000A8678
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x000AA528 File Offset: 0x000A8728
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)365028466;
				short num2 = num;
				num = (short)1903551602;
				switch (num2 == num)
				{
				}
				num = (short)1064960001;
				if (num != 0)
				{
				}
				num = (short)1634205696;
				short num3 = num;
				num = (short)1733492736;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)392248961;
				short num2 = num;
				num = (short)301678209;
				switch (num2 == num)
				{
				}
				num = (short)1113915393;
				if (num != 0)
				{
				}
				num = (short)1838022656;
				short num3 = num;
				num = (short)1162084352;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000AA5D8 File Offset: 0x000A87D8
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000AA688 File Offset: 0x000A8888
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1301997749;
				short num2 = num;
				num = (short)423094453;
				switch (num2 == num)
				{
				}
				num = (short)435159041;
				if (num != 0)
				{
				}
				num = (short)646447104;
				short num3 = num;
				num = (short)1663434752;
				if (num != 0)
				{
				}
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)885853667;
				short num2 = num;
				num = (short)1551437283;
				switch (num2 == num)
				{
				}
				num = (short)239730688;
				if (num != 0)
				{
				}
				num = (short)1491009536;
				short num3 = num;
				num = (short)564002817;
				if (num != 0)
				{
				}
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x000AA738 File Offset: 0x000A8938
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000AA7E8 File Offset: 0x000A89E8
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1315700737;
				if (num != 0)
				{
				}
				num = (short)449800899;
				short num2 = num;
				num = (short)1302358723;
				switch (num2 == num)
				{
				}
				num = (short)164691968;
				short num3 = num;
				num = (short)221577216;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1481940247;
				short num2 = num;
				num = (short)405118231;
				switch (num2 == num)
				{
				}
				num = (short)1310523393;
				if (num != 0)
				{
				}
				num = (short)2127953920;
				short num3 = num;
				num = (short)993722368;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000AA898 File Offset: 0x000A8A98
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x000AA94C File Offset: 0x000A8B4C
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string Comments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1420813091;
				short num2 = num;
				num = (short)441049891;
				switch (num2 == num)
				{
				}
				num = (short)1982267393;
				if (num != 0)
				{
				}
				num = (short)959447040;
				short num3 = num;
				num = (short)1882128384;
				if (num != 0)
				{
				}
				return this.<Comments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1689884687;
				short num2 = num;
				num = (short)1757583375;
				switch (num2 == num)
				{
				}
				num = (short)1264910337;
				if (num != 0)
				{
				}
				num = (short)1691025408;
				short num3 = num;
				num = (short)2130575360;
				if (num != 0)
				{
				}
				this.<Comments>k__BackingField = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000AA9FC File Offset: 0x000A8BFC
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000AAAAC File Offset: 0x000A8CAC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)929728326;
				short num2 = num;
				num = (short)121472838;
				switch (num2 == num)
				{
				}
				num = (short)698417152;
				if (num != 0)
				{
				}
				num = (short)305070080;
				short num3 = num;
				num = (short)747175937;
				if (num != 0)
				{
				}
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)803177557;
				short num2 = num;
				num = (short)928875605;
				switch (num2 == num)
				{
				}
				num = (short)458948609;
				if (num != 0)
				{
				}
				num = (short)158990336;
				short num3 = num;
				num = (short)802488320;
				if (num != 0)
				{
				}
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000AAB5C File Offset: 0x000A8D5C
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000AAC0C File Offset: 0x000A8E0C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)548601857;
				if (num != 0)
				{
				}
				num = (short)200452972;
				short num2 = num;
				num = (short)956738412;
				switch (num2 == num)
				{
				}
				num = (short)911605760;
				short num3 = num;
				num = (short)885981184;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1399965747;
				short num2 = num;
				num = (short)2094057523;
				switch (num2 == num)
				{
				}
				num = (short)1804009473;
				if (num != 0)
				{
				}
				num = (short)397606912;
				short num3 = num;
				num = (short)1722417152;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000AACBC File Offset: 0x000A8EBC
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000AAD6C File Offset: 0x000A8F6C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ConfigUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)218308372;
				short num2 = num;
				num = (short)740237076;
				switch (num2 == num)
				{
				}
				num = (short)1928003584;
				if (num != 0)
				{
				}
				num = (short)2103967744;
				short num3 = num;
				num = (short)86441985;
				if (num != 0)
				{
				}
				return this.<ConfigUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)881351904;
				short num2 = num;
				num = (short)931618016;
				switch (num2 == num)
				{
				}
				num = (short)1481965569;
				if (num != 0)
				{
				}
				num = (short)417529856;
				short num3 = num;
				num = (short)1900412928;
				if (num != 0)
				{
				}
				this.<ConfigUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x000AAE1C File Offset: 0x000A901C
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000AAECC File Offset: 0x000A90CC
		[global::System.Runtime.Serialization.DataMember]
		public string GroupName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1194235296;
				short num2 = num;
				num = (short)1130796448;
				switch (num2 == num)
				{
				}
				num = (short)750256128;
				if (num != 0)
				{
				}
				num = (short)23527424;
				short num3 = num;
				num = (short)2076049409;
				if (num != 0)
				{
				}
				return this.<GroupName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1637264700;
				short num2 = num;
				num = (short)1862249788;
				switch (num2 == num)
				{
				}
				num = (short)327024641;
				if (num != 0)
				{
				}
				num = (short)224854016;
				short num3 = num;
				num = (short)1097138176;
				if (num != 0)
				{
				}
				this.<GroupName>k__BackingField = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x000AAF7C File Offset: 0x000A917C
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000AB02C File Offset: 0x000A922C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> FeaturesList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1669332993;
				if (num != 0)
				{
				}
				num = (short)267856309;
				short num2 = num;
				num = (short)916400565;
				switch (num2 == num)
				{
				}
				num = (short)355926016;
				short num3 = num;
				num = (short)2138963968;
				if (num != 0)
				{
				}
				return this.<FeaturesList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1376714753;
				if (num != 0)
				{
				}
				num = (short)1002987451;
				short num2 = num;
				num = (short)5922747;
				switch (num2 == num)
				{
				}
				num = (short)1428488192;
				short num3 = num;
				num = (short)1753415680;
				if (num != 0)
				{
				}
				this.<FeaturesList>k__BackingField = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000AB0DC File Offset: 0x000A92DC
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000AB188 File Offset: 0x000A9388
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMsg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1395656507;
				short num2 = num;
				num = (short)941819707;
				switch (num2 == num)
				{
				}
				num = (short)113704961;
				if (num != 0)
				{
				}
				num = (short)1347944448;
				short num3 = num;
				num = (short)84606976;
				if (num != 0)
				{
				}
				return this.<WarningMsg>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1981938125;
				short num2 = num;
				num = (short)285276621;
				switch (num2 == num)
				{
				}
				num = (short)211353600;
				if (num != 0)
				{
				}
				num = (short)1619984384;
				short num3 = num;
				num = (short)327548929;
				if (num != 0)
				{
				}
				this.<WarningMsg>k__BackingField = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x000AB23C File Offset: 0x000A943C
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000AB2E8 File Offset: 0x000A94E8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug>? CopiedRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)645660899;
				short num2 = num;
				num = (short)1774387427;
				switch (num2 == num)
				{
				}
				num = (short)1609564160;
				if (num != 0)
				{
				}
				num = (short)614400000;
				short num3 = num;
				num = (short)687931393;
				if (num != 0)
				{
				}
				return this.<CopiedRadio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)624642865;
				short num2 = num;
				num = (short)1865173809;
				switch (num2 == num)
				{
				}
				num = (short)1301676033;
				if (num != 0)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				num = (short)990314496;
				if (num != 0)
				{
				}
				this.<CopiedRadio>k__BackingField = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x000AB39C File Offset: 0x000A959C
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x000AB450 File Offset: 0x000A9650
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> MandatorySetsList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2064908289;
				if (num != 0)
				{
				}
				num = (short)1555257234;
				short num2 = num;
				num = (short)1717131154;
				switch (num2 == num)
				{
				}
				num = (short)1663762432;
				short num3 = num;
				num = (short)1768292352;
				if (num != 0)
				{
				}
				return this.<MandatorySetsList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)884925354;
				short num2 = num;
				num = (short)1181213610;
				switch (num2 == num)
				{
				}
				num = (short)754581505;
				if (num != 0)
				{
				}
				num = (short)980811776;
				short num3 = num;
				num = (short)1969422336;
				if (num != 0)
				{
				}
				this.<MandatorySetsList>k__BackingField = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000AB500 File Offset: 0x000A9700
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000AB5B0 File Offset: 0x000A97B0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public global::System.Guid? ProvisioningUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1507340945;
				short num2 = num;
				num = (short)1391932049;
				switch (num2 == num)
				{
				}
				num = (short)535101441;
				if (num != 0)
				{
				}
				num = (short)1759641600;
				short num3 = num;
				num = (short)564133888;
				if (num != 0)
				{
				}
				return this.<ProvisioningUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)939196417;
				if (num != 0)
				{
				}
				num = (short)1673674529;
				short num2 = num;
				num = (short)183779105;
				switch (num2 == num)
				{
				}
				num = (short)1514209280;
				short num3 = num;
				num = (short)1213399040;
				if (num != 0)
				{
				}
				this.<ProvisioningUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000AB664 File Offset: 0x000A9864
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000AB710 File Offset: 0x000A9910
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string ProvisioningName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1181386338;
				short num2 = num;
				num = (short)864323170;
				switch (num2 == num)
				{
				}
				num = (short)2042429441;
				if (num != 0)
				{
				}
				num = (short)1744633856;
				short num3 = num;
				num = (short)1902772224;
				if (num != 0)
				{
				}
				return this.<ProvisioningName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1594361375;
				short num2 = num;
				num = (short)87885343;
				switch (num2 == num)
				{
				}
				num = (short)1903230977;
				if (num != 0)
				{
				}
				num = (short)688783360;
				short num3 = num;
				num = (short)1355677696;
				if (num != 0)
				{
				}
				this.<ProvisioningName>k__BackingField = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x000AB7C0 File Offset: 0x000A99C0
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x000AB870 File Offset: 0x000A9A70
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PortableOrMobileEnum NeedPortableOrMobile
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1342694060;
				short num2 = num;
				num = (short)70771372;
				switch (num2 == num)
				{
				}
				num = (short)1485373441;
				if (num != 0)
				{
				}
				num = (short)1106968576;
				short num3 = num;
				num = (short)384106496;
				if (num != 0)
				{
				}
				return this.<NeedPortableOrMobile>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)371664468;
				short num2 = num;
				num = (short)1829643860;
				switch (num2 == num)
				{
				}
				num = (short)835518464;
				if (num != 0)
				{
				}
				num = (short)840761344;
				short num3 = num;
				num = (short)1115815937;
				if (num != 0)
				{
				}
				this.<NeedPortableOrMobile>k__BackingField = value;
			}
		}

		// Token: 0x0400077A RID: 1914
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> IgnoreColumns = new global::System.Collections.Generic.List<string>();
	}
}
