using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000030 RID: 48
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXRadioSystem : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x0002EA10 File Offset: 0x0002CC10
		public APXRadioSystem()
		{
			this.ShuffeledBandPlan = new bool?(false);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0002EA30 File Offset: 0x0002CC30
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0002EADC File Offset: 0x0002CCDC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)715718656;
				short num2 = num;
				num = (short)2076485164;
				short num3 = num;
				num = (short)1580312108;
				switch (num3 == num)
				{
				}
				num = (short)491257857;
				if (num != 0)
				{
				}
				num = (short)1521025024;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)636026880;
				short num2 = num;
				num = (short)1283719487;
				short num3 = num;
				num = (short)545980735;
				switch (num3 == num)
				{
				}
				num = (short)1718943745;
				if (num != 0)
				{
				}
				num = (short)1427963904;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0002EB90 File Offset: 0x0002CD90
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0002EC44 File Offset: 0x0002CE44
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1793261568;
				short num2 = num;
				num = (short)91017439;
				short num3 = num;
				num = (short)89051359;
				switch (num3 == num)
				{
				}
				num = (short)1359085569;
				if (num != 0)
				{
				}
				num = (short)1153826816;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1424621568;
				short num2 = num;
				num = (short)1792594995;
				short num3 = num;
				num = (short)1131664435;
				switch (num3 == num)
				{
				}
				num = (short)642908160;
				if (num != 0)
				{
				}
				num = (short)17760257;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0002ECF4 File Offset: 0x0002CEF4
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0002EDA4 File Offset: 0x0002CFA4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2033188864;
				short num2 = num;
				num = (short)1999113157;
				short num3 = num;
				num = (short)118492101;
				switch (num3 == num)
				{
				}
				num = (short)1054539777;
				if (num != 0)
				{
				}
				num = (short)764084224;
				if (num != 0)
				{
				}
				return this.<SystemType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)390004736;
				short num2 = num;
				num = (short)2010628097;
				short num3 = num;
				num = (short)1349500929;
				switch (num3 == num)
				{
				}
				num = (short)1842872320;
				if (num != 0)
				{
				}
				num = (short)49872897;
				if (num != 0)
				{
				}
				this.<SystemType>k__BackingField = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0002EE54 File Offset: 0x0002D054
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0002EF08 File Offset: 0x0002D108
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? SystemSubType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)907608064;
				short num2 = num;
				num = (short)1223040825;
				short num3 = num;
				num = (short)847191865;
				switch (num3 == num)
				{
				}
				num = (short)802947073;
				if (num != 0)
				{
				}
				num = (short)1319174144;
				if (num != 0)
				{
				}
				return this.<SystemSubType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)762576896;
				short num2 = num;
				num = (short)523562922;
				short num3 = num;
				num = (short)1212542890;
				switch (num3 == num)
				{
				}
				num = (short)657522689;
				if (num != 0)
				{
				}
				num = (short)1813905408;
				if (num != 0)
				{
				}
				this.<SystemSubType>k__BackingField = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0002EFB8 File Offset: 0x0002D1B8
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0002F068 File Offset: 0x0002D268
		[global::System.Runtime.Serialization.DataMember]
		public int? RadioId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1956446208;
				short num2 = num;
				num = (short)1879525902;
				short num3 = num;
				num = (short)362564110;
				switch (num3 == num)
				{
				}
				num = (short)1142620161;
				if (num != 0)
				{
				}
				num = (short)1021509632;
				if (num != 0)
				{
				}
				return this.<RadioId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)416546816;
				short num2 = num;
				num = (short)1792438584;
				short num3 = num;
				num = (short)1999860024;
				switch (num3 == num)
				{
				}
				num = (short)2005598208;
				if (num != 0)
				{
				}
				num = (short)1512308737;
				if (num != 0)
				{
				}
				this.<RadioId>k__BackingField = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0002F118 File Offset: 0x0002D318
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0002F1C8 File Offset: 0x0002D3C8
		[global::System.Runtime.Serialization.DataMember]
		public int? SystemId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)281870336;
				short num2 = num;
				num = (short)1217134593;
				if (num != 0)
				{
				}
				num = (short)1307456203;
				short num3 = num;
				num = (short)165491403;
				switch (num3 == num)
				{
				}
				num = (short)1730936832;
				if (num != 0)
				{
				}
				return this.<SystemId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)867041280;
				short num2 = num;
				num = (short)1927965131;
				short num3 = num;
				num = (short)1771530699;
				switch (num3 == num)
				{
				}
				num = (short)514981889;
				if (num != 0)
				{
				}
				num = (short)1886257152;
				if (num != 0)
				{
				}
				this.<SystemId>k__BackingField = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0002F27C File Offset: 0x0002D47C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0002F32C File Offset: 0x0002D52C
		[global::System.Runtime.Serialization.DataMember]
		public string SystemName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1950482432;
				short num2 = num;
				num = (short)2103252783;
				short num3 = num;
				num = (short)1829050159;
				switch (num3 == num)
				{
				}
				num = (short)674824192;
				if (num != 0)
				{
				}
				num = (short)1755512833;
				if (num != 0)
				{
				}
				return this.<SystemName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)812515328;
				short num2 = num;
				num = (short)732898869;
				short num3 = num;
				num = (short)138749493;
				switch (num3 == num)
				{
				}
				num = (short)168165376;
				if (num != 0)
				{
				}
				num = (short)322502657;
				if (num != 0)
				{
				}
				this.<SystemName>k__BackingField = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0002F3DC File Offset: 0x0002D5DC
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0002F48C File Offset: 0x0002D68C
		[global::System.Runtime.Serialization.DataMember]
		public bool? ShuffeledBandPlan
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1370292224;
				short num2 = num;
				num = (short)984750343;
				short num3 = num;
				num = (short)862722311;
				switch (num3 == num)
				{
				}
				num = (short)1670316033;
				if (num != 0)
				{
				}
				num = (short)1614938112;
				if (num != 0)
				{
				}
				return this.<ShuffeledBandPlan>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1957101568;
				short num2 = num;
				num = (short)1479976670;
				short num3 = num;
				num = (short)167945950;
				switch (num3 == num)
				{
				}
				num = (short)641794049;
				if (num != 0)
				{
				}
				num = (short)532021248;
				if (num != 0)
				{
				}
				this.<ShuffeledBandPlan>k__BackingField = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0002F53C File Offset: 0x0002D73C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0002F5EC File Offset: 0x0002D7EC
		[global::System.Runtime.Serialization.DataMember]
		public int? CoverageType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)623968256;
				short num2 = num;
				num = (short)1165543158;
				short num3 = num;
				num = (short)200263414;
				switch (num3 == num)
				{
				}
				num = (short)707919873;
				if (num != 0)
				{
				}
				num = (short)1608843264;
				if (num != 0)
				{
				}
				return this.<CoverageType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1965359104;
				short num2 = num;
				num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)574441233;
				short num3 = num;
				num = (short)1498629905;
				switch (num3 == num)
				{
				}
				num = (short)1623195648;
				if (num != 0)
				{
				}
				this.<CoverageType>k__BackingField = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0002F69C File Offset: 0x0002D89C
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0002F74C File Offset: 0x0002D94C
		[global::System.Runtime.Serialization.DataMember]
		public int? WacnId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1984364544;
				short num2 = num;
				num = (short)135973328;
				short num3 = num;
				num = (short)1964493264;
				switch (num3 == num)
				{
				}
				num = (short)131661825;
				if (num != 0)
				{
				}
				num = (short)2106261504;
				if (num != 0)
				{
				}
				return this.<WacnId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1595473920;
				short num2 = num;
				num = (short)2052865569;
				short num3 = num;
				num = (short)1623473697;
				switch (num3 == num)
				{
				}
				num = (short)955973633;
				if (num != 0)
				{
				}
				num = (short)936574976;
				if (num != 0)
				{
				}
				this.<WacnId>k__BackingField = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0002F7FC File Offset: 0x0002D9FC
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0002F8AC File Offset: 0x0002DAAC
		[global::System.Runtime.Serialization.DataMember]
		public int? CnvGroupNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1753088000;
				short num2 = num;
				num = (short)1792750237;
				short num3 = num;
				num = (short)2064659101;
				switch (num3 == num)
				{
				}
				num = (short)1679949825;
				if (num != 0)
				{
				}
				num = (short)77529088;
				if (num != 0)
				{
				}
				return this.<CnvGroupNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)329449472;
				short num2 = num;
				num = (short)1274294578;
				short num3 = num;
				num = (short)1641558322;
				switch (num3 == num)
				{
				}
				num = (short)1619197953;
				if (num != 0)
				{
				}
				num = (short)634585088;
				if (num != 0)
				{
				}
				this.<CnvGroupNumber>k__BackingField = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0002F95C File Offset: 0x0002DB5C
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		[global::System.Runtime.Serialization.DataMember]
		public int? OrderId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1904345088;
				short num2 = num;
				num = (short)374586603;
				short num3 = num;
				num = (short)577223915;
				switch (num3 == num)
				{
				}
				num = (short)1590558721;
				if (num != 0)
				{
				}
				num = (short)1610416128;
				if (num != 0)
				{
				}
				return this.<OrderId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1893728256;
				short num2 = num;
				num = (short)1489258310;
				short num3 = num;
				num = (short)417154886;
				switch (num3 == num)
				{
				}
				num = (short)452984832;
				if (num != 0)
				{
				}
				num = (short)2086535169;
				if (num != 0)
				{
				}
				this.<OrderId>k__BackingField = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0002FABC File Offset: 0x0002DCBC
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		[global::System.Runtime.Serialization.DataMember]
		public string SelectedDataProfileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)490864640;
				short num2 = num;
				num = (short)1397426317;
				short num3 = num;
				num = (short)481495181;
				switch (num3 == num)
				{
				}
				num = (short)359071744;
				if (num != 0)
				{
				}
				num = (short)1741553665;
				if (num != 0)
				{
				}
				return this.<SelectedDataProfileName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)111607808;
				short num2 = num;
				num = (short)2048327681;
				if (num != 0)
				{
				}
				num = (short)376725287;
				short num3 = num;
				num = (short)1106992935;
				switch (num3 == num)
				{
				}
				num = (short)1863712768;
				if (num != 0)
				{
				}
				this.<SelectedDataProfileName>k__BackingField = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0002FC1C File Offset: 0x0002DE1C
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0002FCCC File Offset: 0x0002DECC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug APXCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2004221952;
				short num2 = num;
				num = (short)854449275;
				short num3 = num;
				num = (short)854121595;
				switch (num3 == num)
				{
				}
				num = (short)1606942721;
				if (num != 0)
				{
				}
				num = (short)28508160;
				if (num != 0)
				{
				}
				return this.<APXCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1672478720;
				short num2 = num;
				num = (short)2065956865;
				if (num != 0)
				{
				}
				num = (short)1092155963;
				short num3 = num;
				num = (short)1184365115;
				switch (num3 == num)
				{
				}
				num = (short)185597952;
				if (num != 0)
				{
				}
				this.<APXCodeplug>k__BackingField = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0002FD7C File Offset: 0x0002DF7C
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0002FE2C File Offset: 0x0002E02C
		[global::System.Runtime.Serialization.DataMember]
		public string RefTrueRecordUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)573636608;
				short num2 = num;
				num = (short)449921148;
				short num3 = num;
				num = (short)705052796;
				switch (num3 == num)
				{
				}
				num = (short)1698627585;
				if (num != 0)
				{
				}
				num = (short)295436288;
				if (num != 0)
				{
				}
				return this.<RefTrueRecordUUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1710948352;
				short num2 = num;
				num = (short)1608049910;
				short num3 = num;
				num = (short)1494410486;
				switch (num3 == num)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				num = (short)1959985152;
				if (num != 0)
				{
				}
				this.<RefTrueRecordUUID>k__BackingField = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0002FF88 File Offset: 0x0002E188
		[global::System.Runtime.Serialization.DataMember]
		public string RefTrueRecordUUID_FNE
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)694026240;
				short num2 = num;
				num = (short)392920383;
				short num3 = num;
				num = (short)1546222911;
				switch (num3 == num)
				{
				}
				num = (short)339607553;
				if (num != 0)
				{
				}
				num = (short)606601216;
				if (num != 0)
				{
				}
				return this.<RefTrueRecordUUID_FNE>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1872691200;
				short num2 = num;
				num = (short)1075317393;
				short num3 = num;
				num = (short)1022102161;
				switch (num3 == num)
				{
				}
				num = (short)357695488;
				if (num != 0)
				{
				}
				num = (short)714997761;
				if (num != 0)
				{
				}
				this.<RefTrueRecordUUID_FNE>k__BackingField = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00030038 File Offset: 0x0002E238
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000300E8 File Offset: 0x0002E2E8
		[global::System.Runtime.Serialization.DataMember]
		public bool ExpandedMDCIDRange
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)435290112;
				short num2 = num;
				num = (short)1780855003;
				short num3 = num;
				num = (short)1506259163;
				switch (num3 == num)
				{
				}
				num = (short)507445248;
				if (num != 0)
				{
				}
				num = (short)1429340161;
				if (num != 0)
				{
				}
				return this.<ExpandedMDCIDRange>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1234894848;
				short num2 = num;
				num = (short)1314403770;
				short num3 = num;
				num = (short)329856442;
				switch (num3 == num)
				{
				}
				num = (short)1064960000;
				if (num != 0)
				{
				}
				num = (short)1051918337;
				if (num != 0)
				{
				}
				this.<ExpandedMDCIDRange>k__BackingField = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00030198 File Offset: 0x0002E398
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0003024C File Offset: 0x0002E44C
		[global::System.Runtime.Serialization.DataMember]
		public bool? TrkSysFeaturesRadioInhibit_A8833
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)744226816;
				short num2 = num;
				num = (short)925106177;
				if (num != 0)
				{
				}
				num = (short)742083680;
				short num3 = num;
				num = (short)1521437792;
				switch (num3 == num)
				{
				}
				num = (short)1445462016;
				if (num != 0)
				{
				}
				return this.<TrkSysFeaturesRadioInhibit_A8833>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)355598336;
				short num2 = num;
				num = (short)1828330849;
				short num3 = num;
				num = (short)1557208417;
				switch (num3 == num)
				{
				}
				num = (short)706740224;
				if (num != 0)
				{
				}
				num = (short)2138963969;
				if (num != 0)
				{
				}
				this.<TrkSysFeaturesRadioInhibit_A8833>k__BackingField = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000302FC File Offset: 0x0002E4FC
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x000303A8 File Offset: 0x0002E5A8
		[global::System.Runtime.Serialization.DataMember]
		public bool? FNE_AllowLegacySoftwareKey_RMOnlyField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1233584128;
				short num2 = num;
				num = (short)1165152426;
				short num3 = num;
				num = (short)1192612010;
				switch (num3 == num)
				{
				}
				num = (short)1512177664;
				if (num != 0)
				{
				}
				num = (short)267714561;
				if (num != 0)
				{
				}
				return this.<FNE_AllowLegacySoftwareKey_RMOnlyField>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)551288832;
				short num2 = num;
				num = (short)1163979106;
				short num3 = num;
				num = (short)38005090;
				switch (num3 == num)
				{
				}
				num = (short)212598785;
				if (num != 0)
				{
				}
				num = (short)552665088;
				if (num != 0)
				{
				}
				this.<FNE_AllowLegacySoftwareKey_RMOnlyField>k__BackingField = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00030458 File Offset: 0x0002E658
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00030508 File Offset: 0x0002E708
		[global::System.Runtime.Serialization.DataMember]
		public bool? AskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)493420544;
				short num2 = num;
				num = (short)822506058;
				short num3 = num;
				num = (short)154301002;
				switch (num3 == num)
				{
				}
				num = (short)816119809;
				if (num != 0)
				{
				}
				num = (short)826867712;
				if (num != 0)
				{
				}
				return this.<AskRequired>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1844051968;
				short num2 = num;
				num = (short)1941427924;
				short num3 = num;
				num = (short)1598805716;
				switch (num3 == num)
				{
				}
				num = (short)493486081;
				if (num != 0)
				{
				}
				num = (short)466157568;
				if (num != 0)
				{
				}
				this.<AskRequired>k__BackingField = value;
			}
		}
	}
}
