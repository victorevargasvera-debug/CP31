using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000031 RID: 49
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXRadioSystemSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000305BC File Offset: 0x0002E7BC
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00030670 File Offset: 0x0002E870
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SerialNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)777846784;
				short num2 = num;
				num = (short)359990244;
				short num3 = num;
				num = (short)382338020;
				switch (num3 == num)
				{
				}
				num = (short)1587478529;
				if (num != 0)
				{
				}
				num = (short)606273536;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2139684864;
				short num2 = num;
				num = (short)1959513946;
				short num3 = num;
				num = (short)4181850;
				switch (num3 == num)
				{
				}
				num = (short)567934977;
				if (num != 0)
				{
				}
				num = (short)1295253504;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00030720 File Offset: 0x0002E920
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000307CC File Offset: 0x0002E9CC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public int? RadioStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1275002880;
				short num2 = num;
				num = (short)2065921104;
				short num3 = num;
				num = (short)395932752;
				switch (num3 == num)
				{
				}
				num = (short)1148518401;
				if (num != 0)
				{
				}
				num = (short)2100953088;
				if (num != 0)
				{
				}
				return this.<RadioStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)872218624;
				short num2 = num;
				num = (short)1856475412;
				short num3 = num;
				num = (short)1109627156;
				switch (num3 == num)
				{
				}
				num = (short)1310130177;
				if (num != 0)
				{
				}
				num = (short)113967104;
				if (num != 0)
				{
				}
				this.<RadioStatus>k__BackingField = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0003087C File Offset: 0x0002EA7C
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0003092C File Offset: 0x0002EB2C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LastJobUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? JobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1224802304;
				short num2 = num;
				num = (short)1774814168;
				short num3 = num;
				num = (short)2132116440;
				switch (num3 == num)
				{
				}
				num = (short)1952972800;
				if (num != 0)
				{
				}
				num = (short)2124939265;
				if (num != 0)
				{
				}
				return this.<JobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1033437184;
				short num2 = num;
				num = (short)658470639;
				short num3 = num;
				num = (short)649819887;
				switch (num3 == num)
				{
				}
				num = (short)1652228097;
				if (num != 0)
				{
				}
				num = (short)1793064960;
				if (num != 0)
				{
				}
				this.<JobUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000309DC File Offset: 0x0002EBDC
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1453522944;
				short num2 = num;
				num = (short)560922625;
				if (num != 0)
				{
				}
				num = (short)2021272999;
				short num3 = num;
				num = (short)1093676455;
				switch (num3 == num)
				{
				}
				num = (short)1975713792;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1815740416;
				short num2 = num;
				num = (short)364930378;
				short num3 = num;
				num = (short)985359690;
				switch (num3 == num)
				{
				}
				num = (short)1145241601;
				if (num != 0)
				{
				}
				num = (short)210960384;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00030B3C File Offset: 0x0002ED3C
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1832714240;
				short num2 = num;
				num = (short)23507455;
				short num3 = num;
				num = (short)1759883775;
				switch (num3 == num)
				{
				}
				num = (short)277151745;
				if (num != 0)
				{
				}
				num = (short)52953088;
				if (num != 0)
				{
				}
				return this.<TemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1257046016;
				short num2 = num;
				num = (short)1070636485;
				short num3 = num;
				num = (short)1616944581;
				switch (num3 == num)
				{
				}
				num = (short)1871773697;
				if (num != 0)
				{
				}
				num = (short)1410924544;
				if (num != 0)
				{
				}
				this.<TemplateName>k__BackingField = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00030C9C File Offset: 0x0002EE9C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00030D50 File Offset: 0x0002EF50
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
		public string ConfigurationName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)181338112;
				short num2 = num;
				num = (short)1010481880;
				short num3 = num;
				num = (short)384088792;
				switch (num3 == num)
				{
				}
				num = (short)580976641;
				if (num != 0)
				{
				}
				num = (short)528351232;
				if (num != 0)
				{
				}
				return this.<ConfigurationName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1436942336;
				short num2 = num;
				num = (short)2074409329;
				short num3 = num;
				num = (short)1457715569;
				switch (num3 == num)
				{
				}
				num = (short)39845888;
				if (num != 0)
				{
				}
				num = (short)901906433;
				if (num != 0)
				{
				}
				this.<ConfigurationName>k__BackingField = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00030E00 File Offset: 0x0002F000
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00030EB0 File Offset: 0x0002F0B0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("TemplateUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.Guid? TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)671416320;
				short num2 = num;
				num = (short)1716547983;
				short num3 = num;
				num = (short)2136240527;
				switch (num3 == num)
				{
				}
				num = (short)1699741696;
				if (num != 0)
				{
				}
				num = (short)881917953;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1419378688;
				short num2 = num;
				num = (short)372091280;
				short num3 = num;
				num = (short)411281808;
				switch (num3 == num)
				{
				}
				num = (short)545193985;
				if (num != 0)
				{
				}
				num = (short)1140260864;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00030F60 File Offset: 0x0002F160
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00031010 File Offset: 0x0002F210
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.Guid? ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1705377792;
				short num2 = num;
				num = (short)594392388;
				short num3 = num;
				num = (short)1929033028;
				switch (num3 == num)
				{
				}
				num = (short)1537212416;
				if (num != 0)
				{
				}
				num = (short)1162215425;
				if (num != 0)
				{
				}
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1508769792;
				short num2 = num;
				num = (short)415724794;
				short num3 = num;
				num = (short)1980790010;
				switch (num3 == num)
				{
				}
				num = (short)370409472;
				if (num != 0)
				{
				}
				num = (short)1634729985;
				if (num != 0)
				{
				}
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000310C4 File Offset: 0x0002F2C4
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00031174 File Offset: 0x0002F374
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1121517568;
				short num2 = num;
				num = (short)479609940;
				short num3 = num;
				num = (short)2013545556;
				switch (num3 == num)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				num = (short)2048524289;
				if (num != 0)
				{
				}
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1964244992;
				short num2 = num;
				num = (short)1265797529;
				short num3 = num;
				num = (short)270371225;
				switch (num3 == num)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				num = (short)1245052929;
				if (num != 0)
				{
				}
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00031224 File Offset: 0x0002F424
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000312D4 File Offset: 0x0002F4D4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CodeplugVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)12517376;
				short num2 = num;
				num = (short)1392836609;
				if (num != 0)
				{
				}
				num = (short)376490917;
				short num3 = num;
				num = (short)811649957;
				switch (num3 == num)
				{
				}
				num = (short)1408106496;
				if (num != 0)
				{
				}
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1824587776;
				short num2 = num;
				num = (short)109489309;
				short num3 = num;
				num = (short)1481747613;
				switch (num3 == num)
				{
				}
				num = (short)1135411201;
				if (num != 0)
				{
				}
				num = (short)708837376;
				if (num != 0)
				{
				}
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00031388 File Offset: 0x0002F588
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0003143C File Offset: 0x0002F63C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SystemType", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1148452864;
				short num2 = num;
				num = (short)452125573;
				short num3 = num;
				num = (short)127001477;
				switch (num3 == num)
				{
				}
				num = (short)1221787649;
				if (num != 0)
				{
				}
				num = (short)1694695424;
				if (num != 0)
				{
				}
				return this.<SystemType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1622540288;
				short num2 = num;
				num = (short)1272053761;
				if (num != 0)
				{
				}
				num = (short)1701586173;
				short num3 = num;
				num = (short)1610228989;
				switch (num3 == num)
				{
				}
				num = (short)1204682752;
				if (num != 0)
				{
				}
				this.<SystemType>k__BackingField = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000314F0 File Offset: 0x0002F6F0
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000315A0 File Offset: 0x0002F7A0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SystemSubType", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? SystemSubType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1561526272;
				short num2 = num;
				num = (short)509214721;
				if (num != 0)
				{
				}
				num = (short)62369581;
				short num3 = num;
				num = (short)615427885;
				switch (num3 == num)
				{
				}
				num = (short)337248256;
				if (num != 0)
				{
				}
				return this.<SystemSubType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1076822016;
				short num2 = num;
				num = (short)14286849;
				if (num != 0)
				{
				}
				num = (short)1940808983;
				short num3 = num;
				num = (short)1941267735;
				switch (num3 == num)
				{
				}
				num = (short)1439432704;
				if (num != 0)
				{
				}
				this.<SystemSubType>k__BackingField = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00031650 File Offset: 0x0002F850
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00031700 File Offset: 0x0002F900
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SystemName", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		public string SystemName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1837170688;
				short num2 = num;
				num = (short)1403646968;
				short num3 = num;
				num = (short)1549923320;
				switch (num3 == num)
				{
				}
				num = (short)47251457;
				if (num != 0)
				{
				}
				num = (short)378535936;
				if (num != 0)
				{
				}
				return this.<SystemName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)470482944;
				short num2 = num;
				num = (short)1094527033;
				short num3 = num;
				num = (short)204089401;
				switch (num3 == num)
				{
				}
				num = (short)642252801;
				if (num != 0)
				{
				}
				num = (short)490602496;
				if (num != 0)
				{
				}
				this.<SystemName>k__BackingField = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000317B4 File Offset: 0x0002F9B4
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00031864 File Offset: 0x0002FA64
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SystemId", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		public int? SystemId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)398327808;
				short num2 = num;
				num = (short)488487151;
				short num3 = num;
				num = (short)358332655;
				switch (num3 == num)
				{
				}
				num = (short)49545217;
				if (num != 0)
				{
				}
				num = (short)128385024;
				if (num != 0)
				{
				}
				return this.<SystemId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1271726080;
				short num2 = num;
				num = (short)307560449;
				if (num != 0)
				{
				}
				num = (short)1703272821;
				short num3 = num;
				num = (short)1389027701;
				switch (num3 == num)
				{
				}
				num = (short)1838612480;
				if (num != 0)
				{
				}
				this.<SystemId>k__BackingField = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00031914 File Offset: 0x0002FB14
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000319C4 File Offset: 0x0002FBC4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioId", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		public int? RadioId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1506148352;
				short num2 = num;
				num = (short)937220565;
				short num3 = num;
				num = (short)1872091605;
				switch (num3 == num)
				{
				}
				num = (short)825688064;
				if (num != 0)
				{
				}
				num = (short)1961623553;
				if (num != 0)
				{
				}
				return this.<RadioId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1343488000;
				short num2 = num;
				num = (short)1412627366;
				short num3 = num;
				num = (short)554236838;
				switch (num3 == num)
				{
				}
				num = (short)116523008;
				if (num != 0)
				{
				}
				num = (short)837091329;
				if (num != 0)
				{
				}
				this.<RadioId>k__BackingField = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00031A70 File Offset: 0x0002FC70
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00031B20 File Offset: 0x0002FD20
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CnvGroupNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public int? CnvGroupNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1647247360;
				short num2 = num;
				num = (short)1277482548;
				short num3 = num;
				num = (short)1464653364;
				switch (num3 == num)
				{
				}
				num = (short)1685258241;
				if (num != 0)
				{
				}
				num = (short)1593966592;
				if (num != 0)
				{
				}
				return this.<CnvGroupNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1425932288;
				short num2 = num;
				num = (short)274989057;
				if (num != 0)
				{
				}
				num = (short)690544020;
				short num3 = num;
				num = (short)110943636;
				switch (num3 == num)
				{
				}
				num = (short)1543634944;
				if (num != 0)
				{
				}
				this.<CnvGroupNumber>k__BackingField = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00031BD0 File Offset: 0x0002FDD0
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x00031C7C File Offset: 0x0002FE7C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Uuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)124977152;
				short num2 = num;
				num = (short)202626246;
				short num3 = num;
				num = (short)1553585350;
				switch (num3 == num)
				{
				}
				num = (short)1198981121;
				if (num != 0)
				{
				}
				num = (short)1165164544;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)265224192;
				short num2 = num;
				num = (short)509145852;
				short num3 = num;
				num = (short)1915876092;
				switch (num3 == num)
				{
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				num = (short)928710656;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00031D30 File Offset: 0x0002FF30
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00031DE0 File Offset: 0x0002FFE0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CodeplugUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)349110272;
				short num2 = num;
				num = (short)1513306685;
				short num3 = num;
				num = (short)1462188605;
				switch (num3 == num)
				{
				}
				num = (short)877592577;
				if (num != 0)
				{
				}
				num = (short)1994588160;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1000407040;
				short num2 = num;
				num = (short)486211585;
				if (num != 0)
				{
				}
				num = (short)1808622403;
				short num3 = num;
				num = (short)1993040707;
				switch (num3 == num)
				{
				}
				num = (short)1603272704;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00031E90 File Offset: 0x00030090
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00031F40 File Offset: 0x00030140
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothEnable", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public bool? BluetoothEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1647575040;
				short num2 = num;
				num = (short)2069692417;
				if (num != 0)
				{
				}
				num = (short)1433058529;
				short num3 = num;
				num = (short)958774497;
				switch (num3 == num)
				{
				}
				num = (short)1773273088;
				if (num != 0)
				{
				}
				return this.<BluetoothEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)908328960;
				short num2 = num;
				num = (short)1214720983;
				short num3 = num;
				num = (short)812395479;
				switch (num3 == num)
				{
				}
				num = (short)564068352;
				if (num != 0)
				{
				}
				num = (short)439746561;
				if (num != 0)
				{
				}
				this.<BluetoothEnable>k__BackingField = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00031FF4 File Offset: 0x000301F4
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x000320A4 File Offset: 0x000302A4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LocationEnable", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? LocationEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)880934912;
				short num2 = num;
				num = (short)1800339457;
				if (num != 0)
				{
				}
				num = (short)1815790446;
				short num3 = num;
				num = (short)451724142;
				switch (num3 == num)
				{
				}
				num = (short)1456406528;
				if (num != 0)
				{
				}
				return this.<LocationEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)372178944;
				short num2 = num;
				num = (short)1331597725;
				short num3 = num;
				num = (short)762679709;
				switch (num3 == num)
				{
				}
				num = (short)801046529;
				if (num != 0)
				{
				}
				num = (short)1138556928;
				if (num != 0)
				{
				}
				this.<LocationEnable>k__BackingField = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00032158 File Offset: 0x00030358
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00032208 File Offset: 0x00030408
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("P25LocationReporting", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? P25LocationReporting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1177681920;
				short num2 = num;
				num = (short)1660301695;
				short num3 = num;
				num = (short)60699007;
				switch (num3 == num)
				{
				}
				num = (short)999555072;
				if (num != 0)
				{
				}
				num = (short)537591809;
				if (num != 0)
				{
				}
				return this.<P25LocationReporting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)251002880;
				short num2 = num;
				num = (short)49741825;
				if (num != 0)
				{
				}
				num = (short)726890288;
				short num3 = num;
				num = (short)1857976112;
				switch (num3 == num)
				{
				}
				num = (short)1159987200;
				if (num != 0)
				{
				}
				this.<P25LocationReporting>k__BackingField = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000322B8 File Offset: 0x000304B8
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00032364 File Offset: 0x00030564
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("GroupUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)633143296;
				short num2 = num;
				num = (short)1159678011;
				short num3 = num;
				num = (short)1521436731;
				switch (num3 == num)
				{
				}
				num = (short)53936129;
				if (num != 0)
				{
				}
				num = (short)79953920;
				if (num != 0)
				{
				}
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)510197760;
				short num2 = num;
				num = (short)860201655;
				short num3 = num;
				num = (short)922133175;
				switch (num3 == num)
				{
				}
				num = (short)1381629952;
				if (num != 0)
				{
				}
				num = (short)1568079873;
				if (num != 0)
				{
				}
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00032414 File Offset: 0x00030614
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x000324C4 File Offset: 0x000306C4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ExpandedMDCIDRange", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public bool ExpandedMDCIDRange
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)499646464;
				short num2 = num;
				num = (short)1811491357;
				short num3 = num;
				num = (short)1448618525;
				switch (num3 == num)
				{
				}
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)867106816;
				if (num != 0)
				{
				}
				return this.<ExpandedMDCIDRange>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1032650752;
				short num2 = num;
				num = (short)1663140813;
				short num3 = num;
				num = (short)1144751053;
				switch (num3 == num)
				{
				}
				num = (short)925564928;
				if (num != 0)
				{
				}
				num = (short)1215037441;
				if (num != 0)
				{
				}
				this.<ExpandedMDCIDRange>k__BackingField = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00032574 File Offset: 0x00030774
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00032628 File Offset: 0x00030828
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1538326528;
				short num2 = num;
				num = (short)1774098689;
				short num3 = num;
				num = (short)66361601;
				switch (num3 == num)
				{
				}
				num = (short)446496769;
				if (num != 0)
				{
				}
				num = (short)1781465088;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1818624000;
				short num2 = num;
				num = (short)231409483;
				short num3 = num;
				num = (short)953026379;
				switch (num3 == num)
				{
				}
				num = (short)1061748737;
				if (num != 0)
				{
				}
				num = (short)2102853632;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000326DC File Offset: 0x000308DC
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00032790 File Offset: 0x00030990
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)895614976;
				short num2 = num;
				num = (short)2130608245;
				short num3 = num;
				num = (short)92045429;
				switch (num3 == num)
				{
				}
				num = (short)1640890368;
				if (num != 0)
				{
				}
				num = (short)1994457089;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1143406592;
				short num2 = num;
				num = (short)1787887617;
				if (num != 0)
				{
				}
				num = (short)1764415333;
				short num3 = num;
				num = (short)839702373;
				switch (num3 == num)
				{
				}
				num = (short)1245184000;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00032840 File Offset: 0x00030A40
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000328F0 File Offset: 0x00030AF0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AskRequired", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? AskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1686765568;
				short num2 = num;
				num = (short)1401018636;
				short num3 = num;
				num = (short)1112529164;
				switch (num3 == num)
				{
				}
				num = (short)44236800;
				if (num != 0)
				{
				}
				num = (short)1144127489;
				if (num != 0)
				{
				}
				return this.<AskRequired>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)307036160;
				short num2 = num;
				num = (short)543704849;
				short num3 = num;
				num = (short)1610696465;
				switch (num3 == num)
				{
				}
				num = (short)499843072;
				if (num != 0)
				{
				}
				num = (short)797835265;
				if (num != 0)
				{
				}
				this.<AskRequired>k__BackingField = value;
			}
		}
	}
}
