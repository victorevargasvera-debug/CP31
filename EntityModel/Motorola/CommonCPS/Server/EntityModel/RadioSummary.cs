using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200002E RID: 46
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.CommonRadioSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTRORadioSummary))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RadioSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0002AB64 File Offset: 0x00028D64
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DeviceID", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)67904665;
				short num2 = num;
				num = (short)1955144857;
				switch (num2 == num)
				{
				}
				num = (short)1877344256;
				if (num != 0)
				{
				}
				num = (short)1663696896;
				short num3 = num;
				num = (short)1381957633;
				if (num != 0)
				{
				}
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1226113025;
				if (num != 0)
				{
				}
				num = (short)848814179;
				short num2 = num;
				num = (short)923656291;
				switch (num2 == num)
				{
				}
				num = (short)2029780992;
				short num3 = num;
				num = (short)2027683840;
				if (num != 0)
				{
				}
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0002AC14 File Offset: 0x00028E14
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SerialNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1403515266;
				short num2 = num;
				num = (short)1113387394;
				switch (num2 == num)
				{
				}
				num = (short)717750273;
				if (num != 0)
				{
				}
				num = (short)1596588032;
				short num3 = num;
				num = (short)1239547904;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1959940172;
				short num2 = num;
				num = (short)1167741004;
				switch (num2 == num)
				{
				}
				num = (short)1067646976;
				if (num != 0)
				{
				}
				num = (short)2145386496;
				short num3 = num;
				num = (short)412418049;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0002AD78 File Offset: 0x00028F78
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0002AE28 File Offset: 0x00029028
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ModelNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2003455957;
				short num2 = num;
				num = (short)535908309;
				switch (num2 == num)
				{
				}
				num = (short)1352859649;
				if (num != 0)
				{
				}
				num = (short)1303773184;
				short num3 = num;
				num = (short)1088421888;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)380345377;
				short num2 = num;
				num = (short)791780385;
				switch (num2 == num)
				{
				}
				num = (short)70057985;
				if (num != 0)
				{
				}
				num = (short)411828224;
				short num3 = num;
				num = (short)2099576832;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0002AED8 File Offset: 0x000290D8
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0002AF88 File Offset: 0x00029188
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PasswordPerDevice", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public bool PasswordPerDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)482313910;
				short num2 = num;
				num = (short)632981174;
				switch (num2 == num)
				{
				}
				num = (short)152895489;
				if (num != 0)
				{
				}
				num = (short)678887424;
				short num3 = num;
				num = (short)1990459392;
				if (num != 0)
				{
				}
				return this.<PasswordPerDevice>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1683419736;
				short num2 = num;
				num = (short)453177944;
				switch (num2 == num)
				{
				}
				num = (short)1876688897;
				if (num != 0)
				{
				}
				num = (short)270729216;
				short num3 = num;
				num = (short)1960706048;
				if (num != 0)
				{
				}
				this.<PasswordPerDevice>k__BackingField = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0002B038 File Offset: 0x00029238
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0002B0E8 File Offset: 0x000292E8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)810221569;
				if (num != 0)
				{
				}
				num = (short)2112558947;
				short num2 = num;
				num = (short)1082398563;
				switch (num2 == num)
				{
				}
				num = (short)1882652672;
				short num3 = num;
				num = (short)1417019392;
				if (num != 0)
				{
				}
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)828530261;
				short num2 = num;
				num = (short)1656905301;
				switch (num2 == num)
				{
				}
				num = (short)1516306433;
				if (num != 0)
				{
				}
				num = (short)115343360;
				short num3 = num;
				num = (short)1234829312;
				if (num != 0)
				{
				}
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0002B198 File Offset: 0x00029398
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0002B248 File Offset: 0x00029448
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("TemplateUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)479923683;
				short num2 = num;
				num = (short)1144262115;
				switch (num2 == num)
				{
				}
				num = (short)169279488;
				if (num != 0)
				{
				}
				num = (short)1904934912;
				short num3 = num;
				num = (short)1378680833;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)758448129;
				if (num != 0)
				{
				}
				num = (short)360102732;
				short num2 = num;
				num = (short)1741798220;
				switch (num2 == num)
				{
				}
				num = (short)921174016;
				short num3 = num;
				num = (short)1492779008;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0002B2F8 File Offset: 0x000294F8
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0002B3A8 File Offset: 0x000295A8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)187158950;
				short num2 = num;
				num = (short)993710502;
				switch (num2 == num)
				{
				}
				num = (short)2059403265;
				if (num != 0)
				{
				}
				num = (short)415760384;
				short num3 = num;
				num = (short)41418752;
				if (num != 0)
				{
				}
				return this.<TemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)787137126;
				short num2 = num;
				num = (short)1634910822;
				switch (num2 == num)
				{
				}
				num = (short)318767105;
				if (num != 0)
				{
				}
				num = (short)571867136;
				short num3 = num;
				num = (short)887619584;
				if (num != 0)
				{
				}
				this.<TemplateName>k__BackingField = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0002B458 File Offset: 0x00029658
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0002B508 File Offset: 0x00029708
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)710567089;
				short num2 = num;
				num = (short)1435657393;
				switch (num2 == num)
				{
				}
				num = (short)1757216769;
				if (num != 0)
				{
				}
				num = (short)1007026176;
				short num3 = num;
				num = (short)293601280;
				if (num != 0)
				{
				}
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1174017673;
				short num2 = num;
				num = (short)446764681;
				switch (num2 == num)
				{
				}
				num = (short)356253697;
				if (num != 0)
				{
				}
				num = (short)764018688;
				short num3 = num;
				num = (short)1047068672;
				if (num != 0)
				{
				}
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0002B5BC File Offset: 0x000297BC
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0002B66C File Offset: 0x0002986C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
		public string ConfigurationName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)18917692;
				short num2 = num;
				num = (short)2063837500;
				switch (num2 == num)
				{
				}
				num = (short)143458305;
				if (num != 0)
				{
				}
				num = (short)462290944;
				short num3 = num;
				num = (short)670302208;
				if (num != 0)
				{
				}
				return this.<ConfigurationName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1838913619;
				short num2 = num;
				num = (short)1193252947;
				switch (num2 == num)
				{
				}
				num = (short)1790836736;
				if (num != 0)
				{
				}
				num = (short)1402273792;
				short num3 = num;
				num = (short)1355546625;
				if (num != 0)
				{
				}
				this.<ConfigurationName>k__BackingField = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0002B720 File Offset: 0x00029920
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0002B7D0 File Offset: 0x000299D0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationOptionsList", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ConfigurationOptionsList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2008285185;
				if (num != 0)
				{
				}
				num = (short)364102329;
				short num2 = num;
				num = (short)656130745;
				switch (num2 == num)
				{
				}
				num = (short)1365704704;
				short num3 = num;
				num = (short)343015424;
				if (num != 0)
				{
				}
				return this.<ConfigurationOptionsList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)441274324;
				short num2 = num;
				num = (short)899698644;
				switch (num2 == num)
				{
				}
				num = (short)1484521473;
				if (num != 0)
				{
				}
				num = (short)226689024;
				short num3 = num;
				num = (short)625344512;
				if (num != 0)
				{
				}
				this.<ConfigurationOptionsList>k__BackingField = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0002B880 File Offset: 0x00029A80
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0002B92C File Offset: 0x00029B2C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Timestamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
		[global::System.Runtime.Serialization.DataMember]
		public byte[] TemplateTimestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)592073476;
				short num2 = num;
				num = (short)1463833348;
				switch (num2 == num)
				{
				}
				num = (short)573243392;
				if (num != 0)
				{
				}
				num = (short)32899072;
				short num3 = num;
				num = (short)1812660225;
				if (num != 0)
				{
				}
				return this.<TemplateTimestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1600421876;
				short num2 = num;
				num = (short)211845108;
				switch (num2 == num)
				{
				}
				num = (short)1138950145;
				if (num != 0)
				{
				}
				num = (short)1049886720;
				short num3 = num;
				num = (short)1093337088;
				if (num != 0)
				{
				}
				this.<TemplateTimestamp>k__BackingField = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0002BA90 File Offset: 0x00029C90
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CodeplugVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)943312521;
				short num2 = num;
				num = (short)170184329;
				switch (num2 == num)
				{
				}
				num = (short)840695808;
				short num3 = num;
				num = (short)376766464;
				if (num != 0)
				{
				}
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)744467064;
				short num2 = num;
				num = (short)588819064;
				switch (num2 == num)
				{
				}
				num = (short)1618542593;
				if (num != 0)
				{
				}
				num = (short)1714487296;
				short num3 = num;
				num = (short)83755008;
				if (num != 0)
				{
				}
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0002BB3C File Offset: 0x00029D3C
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0002BBEC File Offset: 0x00029DEC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("FirmwareVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1336977170;
				short num2 = num;
				num = (short)2047059730;
				switch (num2 == num)
				{
				}
				num = (short)1454702592;
				if (num != 0)
				{
				}
				num = (short)2092564480;
				short num3 = num;
				num = (short)1468923905;
				if (num != 0)
				{
				}
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)300489156;
				short num2 = num;
				num = (short)1237522884;
				switch (num2 == num)
				{
				}
				num = (short)1172111361;
				if (num != 0)
				{
				}
				num = (short)1465712640;
				short num3 = num;
				num = (short)1811283968;
				if (num != 0)
				{
				}
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0002BC9C File Offset: 0x00029E9C
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0002BD50 File Offset: 0x00029F50
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BBFBundleVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string BBFBundleVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)283294740;
				short num2 = num;
				num = (short)1445116948;
				switch (num2 == num)
				{
				}
				num = (short)172752897;
				if (num != 0)
				{
				}
				num = (short)1343619072;
				short num3 = num;
				num = (short)1303511040;
				if (num != 0)
				{
				}
				return this.<BBFBundleVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)327497713;
				short num2 = num;
				num = (short)1137194993;
				switch (num2 == num)
				{
				}
				num = (short)1984954368;
				if (num != 0)
				{
				}
				num = (short)1709965312;
				short num3 = num;
				num = (short)703725569;
				if (num != 0)
				{
				}
				this.<BBFBundleVersion>k__BackingField = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0002BE00 File Offset: 0x0002A000
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkingCodeplugUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? WorkingCodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1927549865;
				short num2 = num;
				num = (short)101192617;
				switch (num2 == num)
				{
				}
				num = (short)1380450305;
				if (num != 0)
				{
				}
				num = (short)593952768;
				short num3 = num;
				num = (short)770113536;
				if (num != 0)
				{
				}
				return this.<WorkingCodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1718920053;
				short num2 = num;
				num = (short)1819190133;
				switch (num2 == num)
				{
				}
				num = (short)610992128;
				if (num != 0)
				{
				}
				num = (short)1315831808;
				short num3 = num;
				num = (short)49938433;
				if (num != 0)
				{
				}
				this.<WorkingCodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0002BF60 File Offset: 0x0002A160
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0002C014 File Offset: 0x0002A214
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Timestamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public byte[] WorkingCodeplugTimestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737396327;
				short num2 = num;
				num = (short)1763217511;
				switch (num2 == num)
				{
				}
				num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)189857792;
				short num3 = num;
				num = (short)301662208;
				if (num != 0)
				{
				}
				return this.<WorkingCodeplugTimestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)330908082;
				short num2 = num;
				num = (short)1762542002;
				switch (num2 == num)
				{
				}
				num = (short)518914049;
				if (num != 0)
				{
				}
				num = (short)1083834368;
				short num3 = num;
				num = (short)1147994112;
				if (num != 0)
				{
				}
				this.<WorkingCodeplugTimestamp>k__BackingField = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0002C0C0 File Offset: 0x0002A2C0
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0002C16C File Offset: 0x0002A36C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public int? RadioStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)322317669;
				short num2 = num;
				num = (short)1707486565;
				switch (num2 == num)
				{
				}
				num = (short)995360768;
				if (num != 0)
				{
				}
				num = (short)1329070080;
				short num3 = num;
				num = (short)435945473;
				if (num != 0)
				{
				}
				return this.<RadioStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)154619732;
				short num2 = num;
				num = (short)1120489300;
				switch (num2 == num)
				{
				}
				num = (short)1632436225;
				if (num != 0)
				{
				}
				num = (short)2107965440;
				short num3 = num;
				num = (short)1913978880;
				if (num != 0)
				{
				}
				this.<RadioStatus>k__BackingField = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0002C220 File Offset: 0x0002A420
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LastJobUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? LastJobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2065409238;
				short num2 = num;
				num = (short)449291478;
				switch (num2 == num)
				{
				}
				num = (short)1012989953;
				if (num != 0)
				{
				}
				num = (short)955777024;
				short num3 = num;
				num = (short)1455751168;
				if (num != 0)
				{
				}
				return this.<LastJobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)90544726;
				short num2 = num;
				num = (short)1395497558;
				switch (num2 == num)
				{
				}
				num = (short)1760690177;
				if (num != 0)
				{
				}
				num = (short)19333120;
				short num3 = num;
				num = (short)93978624;
				if (num != 0)
				{
				}
				this.<LastJobUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0002C380 File Offset: 0x0002A580
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0002C434 File Offset: 0x0002A634
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobName", typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob))]
		[global::System.Runtime.Serialization.DataMember]
		public string LastJobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)649118710;
				short num2 = num;
				num = (short)54445046;
				switch (num2 == num)
				{
				}
				num = (short)174784512;
				if (num != 0)
				{
				}
				num = (short)894369792;
				short num3 = num;
				num = (short)1729822721;
				if (num != 0)
				{
				}
				return this.<LastJobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1892463214;
				short num2 = num;
				num = (short)394244718;
				switch (num2 == num)
				{
				}
				num = (short)971571201;
				if (num != 0)
				{
				}
				num = (short)369688576;
				short num3 = num;
				num = (short)1137639424;
				if (num != 0)
				{
				}
				this.<LastJobName>k__BackingField = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0002C598 File Offset: 0x0002A798
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Timestamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob))]
		public byte[] LastJobTimestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)932078626;
				short num2 = num;
				num = (short)64119842;
				switch (num2 == num)
				{
				}
				num = (short)876085248;
				if (num != 0)
				{
				}
				num = (short)360251392;
				short num3 = num;
				num = (short)1478623233;
				if (num != 0)
				{
				}
				return this.<LastJobTimestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)894488706;
				short num2 = num;
				num = (short)633196674;
				switch (num2 == num)
				{
				}
				num = (short)532676609;
				if (num != 0)
				{
				}
				num = (short)186384384;
				short num3 = num;
				num = (short)1644560384;
				if (num != 0)
				{
				}
				this.<LastJobTimestamp>k__BackingField = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0002C64C File Offset: 0x0002A84C
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1911147378;
				short num2 = num;
				num = (short)589613938;
				switch (num2 == num)
				{
				}
				num = (short)601554945;
				if (num != 0)
				{
				}
				num = (short)20447232;
				short num3 = num;
				num = (short)274726912;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1839333377;
				if (num != 0)
				{
				}
				num = (short)622559541;
				short num2 = num;
				num = (short)904233269;
				switch (num2 == num)
				{
				}
				num = (short)12124160;
				short num3 = num;
				num = (short)405143552;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0002C858 File Offset: 0x0002AA58
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobType", typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)692322305;
				if (num != 0)
				{
				}
				num = (short)957407062;
				short num2 = num;
				num = (short)1006427990;
				switch (num2 == num)
				{
				}
				num = (short)260374528;
				short num3 = num;
				num = (short)984350720;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1127817728;
				short num2 = num;
				num = (short)664805888;
				switch (num2 == num)
				{
				}
				num = (short)726663169;
				if (num != 0)
				{
				}
				num = (short)2057175040;
				short num3 = num;
				num = (short)66519040;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0002C908 File Offset: 0x0002AB08
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CruncherStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? CruncherStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1398013953;
				if (num != 0)
				{
				}
				num = (short)701866793;
				short num2 = num;
				num = (short)1967825705;
				switch (num2 == num)
				{
				}
				num = (short)2028404736;
				short num3 = num;
				num = (short)835911680;
				if (num != 0)
				{
				}
				return this.<CruncherStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2104254438;
				short num2 = num;
				num = (short)1716477926;
				switch (num2 == num)
				{
				}
				num = (short)8912897;
				if (num != 0)
				{
				}
				num = (short)1966080;
				short num3 = num;
				num = (short)679673856;
				if (num != 0)
				{
				}
				this.<CruncherStatus>k__BackingField = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0002CB1C File Offset: 0x0002AD1C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ProductFamily", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public int? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2135915441;
				short num2 = num;
				num = (short)382827441;
				switch (num2 == num)
				{
				}
				num = (short)1460404225;
				if (num != 0)
				{
				}
				num = (short)1585840128;
				short num3 = num;
				num = (short)136511488;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)286424170;
				short num2 = num;
				num = (short)1443789930;
				switch (num2 == num)
				{
				}
				num = (short)2018770944;
				if (num != 0)
				{
				}
				num = (short)983695360;
				short num3 = num;
				num = (short)988282881;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0002CBCC File Offset: 0x0002ADCC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0002CC7C File Offset: 0x0002AE7C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ChangeIndicator", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public int? ChangeIndicator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)194902586;
				short num2 = num;
				num = (short)150403642;
				switch (num2 == num)
				{
				}
				num = (short)2040397825;
				if (num != 0)
				{
				}
				num = (short)184221696;
				short num3 = num;
				num = (short)1514405888;
				if (num != 0)
				{
				}
				return this.<ChangeIndicator>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)84335706;
				short num2 = num;
				num = (short)651418714;
				switch (num2 == num)
				{
				}
				num = (short)383320065;
				if (num != 0)
				{
				}
				num = (short)36306944;
				if (num != 0)
				{
				}
				num = (short)192675840;
				short num3 = num;
				this.<ChangeIndicator>k__BackingField = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0002CDDC File Offset: 0x0002AFDC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Comments", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public string Comments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)853039028;
				short num2 = num;
				num = (short)1604474804;
				switch (num2 == num)
				{
				}
				num = (short)1758724097;
				if (num != 0)
				{
				}
				num = (short)79757312;
				if (num != 0)
				{
				}
				num = (short)607846400;
				short num3 = num;
				return this.<Comments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)912037596;
				short num2 = num;
				num = (short)1396217564;
				switch (num2 == num)
				{
				}
				num = (short)250740736;
				if (num != 0)
				{
				}
				num = (short)757923841;
				if (num != 0)
				{
				}
				num = (short)1992032256;
				short num3 = num;
				this.<Comments>k__BackingField = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0002CE8C File Offset: 0x0002B08C
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0002CF38 File Offset: 0x0002B138
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Group))]
		[global::System.Runtime.Serialization.DataMember]
		public string GroupName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1911164071;
				short num2 = num;
				num = (short)1028328615;
				switch (num2 == num)
				{
				}
				num = (short)2031157249;
				if (num != 0)
				{
				}
				num = (short)1462370304;
				if (num != 0)
				{
				}
				num = (short)1024851968;
				short num3 = num;
				return this.<GroupName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)58514833;
				short num2 = num;
				num = (short)1860623761;
				switch (num2 == num)
				{
				}
				num = (short)398000129;
				if (num != 0)
				{
				}
				num = (short)729874432;
				if (num != 0)
				{
				}
				num = (short)727056384;
				short num3 = num;
				this.<GroupName>k__BackingField = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0002D09C File Offset: 0x0002B29C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("GroupUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1313507904;
				short num2 = num;
				num = (short)1997310528;
				switch (num2 == num)
				{
				}
				num = (short)1279066113;
				if (num != 0)
				{
				}
				num = (short)308019200;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				short num3 = num;
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1065985188;
				short num2 = num;
				num = (short)881763492;
				switch (num2 == num)
				{
				}
				num = (short)1275199489;
				if (num != 0)
				{
				}
				num = (short)1303642112;
				if (num != 0)
				{
				}
				num = (short)1718550528;
				short num3 = num;
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0002D14C File Offset: 0x0002B34C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("UpgradeAbility", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? UpgradeAbility
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)783417345;
				if (num != 0)
				{
				}
				num = (short)1502351833;
				short num2 = num;
				num = (short)2143490521;
				switch (num2 == num)
				{
				}
				num = (short)1446445056;
				if (num != 0)
				{
				}
				num = (short)556924928;
				short num3 = num;
				return this.<UpgradeAbility>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1823819529;
				short num2 = num;
				num = (short)854017801;
				switch (num2 == num)
				{
				}
				num = (short)686555136;
				if (num != 0)
				{
				}
				num = (short)1296302081;
				if (num != 0)
				{
				}
				num = (short)782237696;
				short num3 = num;
				this.<UpgradeAbility>k__BackingField = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0002D2AC File Offset: 0x0002B4AC
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0002D35C File Offset: 0x0002B55C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CFS", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[global::System.Runtime.Serialization.DataMember]
		public string CFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)856358913;
				if (num != 0)
				{
				}
				num = (short)1701226809;
				short num2 = num;
				num = (short)1666754873;
				switch (num2 == num)
				{
				}
				num = (short)1650130944;
				if (num != 0)
				{
				}
				num = (short)698548224;
				short num3 = num;
				return this.<CFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1711734785;
				if (num != 0)
				{
				}
				num = (short)1896953360;
				short num2 = num;
				num = (short)207762960;
				switch (num2 == num)
				{
				}
				num = (short)1192951808;
				if (num != 0)
				{
				}
				num = (short)767229952;
				short num3 = num;
				this.<CFS>k__BackingField = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0002D40C File Offset: 0x0002B60C
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		[global::System.Runtime.Serialization.IgnoreDataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CFSEncrypt", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string CFSEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1299701773;
				short num2 = num;
				num = (short)43835405;
				switch (num2 == num)
				{
				}
				num = (short)940703744;
				if (num != 0)
				{
				}
				num = (short)453115905;
				if (num != 0)
				{
				}
				num = (short)1608712192;
				short num3 = num;
				return this.<CFSEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1473924804;
				short num2 = num;
				num = (short)1724403396;
				switch (num2 == num)
				{
				}
				num = (short)42074113;
				if (num != 0)
				{
				}
				num = (short)1027407872;
				if (num != 0)
				{
				}
				num = (short)464191488;
				short num3 = num;
				this.<CFSEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0002D56C File Offset: 0x0002B76C
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0002D61C File Offset: 0x0002B81C
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsHasPba
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1587797678;
				short num2 = num;
				num = (short)1323032238;
				switch (num2 == num)
				{
				}
				num = (short)1134493697;
				if (num != 0)
				{
				}
				num = (short)248643584;
				if (num != 0)
				{
				}
				num = (short)562167808;
				short num3 = num;
				return this.<IsHasPba>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)944600046;
				short num2 = num;
				num = (short)1749971950;
				switch (num2 == num)
				{
				}
				num = (short)428670977;
				if (num != 0)
				{
				}
				num = (short)1263861760;
				if (num != 0)
				{
				}
				num = (short)2115502080;
				short num3 = num;
				this.<IsHasPba>k__BackingField = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0002D780 File Offset: 0x0002B980
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationVersionStamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public long? OriginalConfigurationVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)844562433;
				if (num != 0)
				{
				}
				num = (short)1303301613;
				short num2 = num;
				num = (short)1921175021;
				switch (num2 == num)
				{
				}
				num = (short)1316356096;
				if (num != 0)
				{
				}
				num = (short)1978335232;
				short num3 = num;
				return this.<OriginalConfigurationVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1911409713;
				short num2 = num;
				num = (short)683199537;
				switch (num2 == num)
				{
				}
				num = (short)1647509505;
				if (num != 0)
				{
				}
				num = (short)1792016384;
				if (num != 0)
				{
				}
				num = (short)460914688;
				short num3 = num;
				this.<OriginalConfigurationVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0002D830 File Offset: 0x0002BA30
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0002D8DC File Offset: 0x0002BADC
		[global::System.Runtime.Serialization.DataMember]
		public long? CurrentConfigurationVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)539135462;
				short num2 = num;
				num = (short)710249958;
				switch (num2 == num)
				{
				}
				num = (short)657915905;
				if (num != 0)
				{
				}
				num = (short)295174144;
				if (num != 0)
				{
				}
				num = (short)666566656;
				short num3 = num;
				return this.<CurrentConfigurationVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)180191826;
				short num2 = num;
				num = (short)1656783442;
				switch (num2 == num)
				{
				}
				num = (short)2079260673;
				if (num != 0)
				{
				}
				num = (short)1388969984;
				if (num != 0)
				{
				}
				num = (short)2114322432;
				short num3 = num;
				this.<CurrentConfigurationVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0002D988 File Offset: 0x0002BB88
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0002DA34 File Offset: 0x0002BC34
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("HOptionVersionStamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public long HOptionVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1109663119;
				short num2 = num;
				num = (short)1339956623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256704512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304873473;
				if (num != 0)
				{
				}
				num = (short)388694016;
				if (num != 0)
				{
				}
				return this.<HOptionVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)31378011;
				short num2 = num;
				num = (short)173132379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444137472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115567617;
				if (num != 0)
				{
				}
				num = (short)1435369472;
				if (num != 0)
				{
				}
				this.<HOptionVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0002DB90 File Offset: 0x0002BD90
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BLLSyncDataVersionStamp", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public long BLLSyncDataVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2128302738;
				short num2 = num;
				num = (short)1034048146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)869007360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2119892993;
				if (num != 0)
				{
				}
				num = (short)982712320;
				if (num != 0)
				{
				}
				return this.<BLLSyncDataVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1525479117;
				short num2 = num;
				num = (short)916321997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)445186048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273692161;
				if (num != 0)
				{
				}
				num = (short)1737687040;
				if (num != 0)
				{
				}
				this.<BLLSyncDataVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002DC40 File Offset: 0x0002BE40
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsOutOfSync
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1807299633;
				short num2 = num;
				num = (short)2008364081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774125056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1615986688;
				if (num != 0)
				{
				}
				num = (short)2018181121;
				if (num != 0)
				{
				}
				return this.<IsOutOfSync>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)939717174;
				short num2 = num;
				num = (short)2085155382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993722368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2015690752;
				if (num != 0)
				{
				}
				num = (short)1789788161;
				if (num != 0)
				{
				}
				this.<IsOutOfSync>k__BackingField = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0002DE4C File Offset: 0x0002C04C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode? SyncErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1689355361;
				short num2 = num;
				num = (short)528254049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)778960896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887488512;
				if (num != 0)
				{
				}
				num = (short)1187119105;
				if (num != 0)
				{
				}
				return this.<SyncErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)367710670;
				short num2 = num;
				num = (short)892850638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1512374272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518927872;
				if (num != 0)
				{
				}
				num = (short)843579393;
				if (num != 0)
				{
				}
				this.<SyncErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0002DFAC File Offset: 0x0002C1AC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1510908061;
				short num2 = num;
				num = (short)1326358685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304821760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)798097409;
				if (num != 0)
				{
				}
				num = (short)1648230400;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1103342729;
				short num2 = num;
				num = (short)1988209801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055274496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2057502721;
				if (num != 0)
				{
				}
				num = (short)63963136;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0002E05C File Offset: 0x0002C25C
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0002E10C File Offset: 0x0002C30C
		[global::System.Runtime.Serialization.DataMember]
		public long? CurrentChangeIndicatorVersionStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)925368321;
				if (num != 0)
				{
				}
				num = (short)1056768000;
				short num2 = num;
				num = (short)1221003087;
				short num3 = num;
				num = (short)2052327247;
				switch (num3 == num)
				{
				}
				num = (short)1456406528;
				if (num != 0)
				{
				}
				return this.<CurrentChangeIndicatorVersionStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1681260545;
				if (num != 0)
				{
				}
				num = (short)1790312448;
				short num2 = num;
				num = (short)1531135788;
				short num3 = num;
				num = (short)1433356076;
				switch (num3 == num)
				{
				}
				num = (short)583008256;
				if (num != 0)
				{
				}
				this.<CurrentChangeIndicatorVersionStamp>k__BackingField = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0002E26C File Offset: 0x0002C46C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Alias", typeof(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public string IPProgramSystemAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)701799954;
				short num2 = num;
				num = (short)249798162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)475660288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713700864;
				if (num != 0)
				{
				}
				num = (short)2105933825;
				if (num != 0)
				{
				}
				return this.<IPProgramSystemAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1366114217;
				short num2 = num;
				num = (short)1739997097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3801088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2094268416;
				if (num != 0)
				{
				}
				num = (short)1560412161;
				if (num != 0)
				{
				}
				this.<IPProgramSystemAlias>k__BackingField = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0002E320 File Offset: 0x0002C520
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType? IPProgramSystemType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1351564727;
				short num2 = num;
				num = (short)742079927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110821376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082458113;
				if (num != 0)
				{
				}
				num = (short)1199570944;
				if (num != 0)
				{
				}
				return this.<IPProgramSystemType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)677918543;
				short num2 = num;
				num = (short)557987663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1152319488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1249705984;
				if (num != 0)
				{
				}
				num = (short)1483472897;
				if (num != 0)
				{
				}
				this.<IPProgramSystemType>k__BackingField = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0002E480 File Offset: 0x0002C680
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0002E530 File Offset: 0x0002C730
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("IPProgramSystemUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? IPProgramSystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)745753536;
				short num2 = num;
				num = (short)1946241984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)344522752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135818241;
				if (num != 0)
				{
				}
				num = (short)1980563456;
				if (num != 0)
				{
				}
				return this.<IPProgramSystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1922169226;
				short num2 = num;
				num = (short)1920399754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652279808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559822337;
				if (num != 0)
				{
				}
				num = (short)1321336832;
				if (num != 0)
				{
				}
				this.<IPProgramSystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x0002E690 File Offset: 0x0002C890
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LastProgrammedDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.DateTime? LastProgrammedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1688876298;
				short num2 = num;
				num = (short)179320074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177026560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151795200;
				if (num != 0)
				{
				}
				num = (short)345112577;
				if (num != 0)
				{
				}
				return this.<LastProgrammedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1792364500;
				short num2 = num;
				num = (short)39604180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1125580800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467009536;
				if (num != 0)
				{
				}
				num = (short)1536425985;
				if (num != 0)
				{
				}
				this.<LastProgrammedDate>k__BackingField = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0002E740 File Offset: 0x0002C940
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0002E7EC File Offset: 0x0002C9EC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ProvisioningUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ProvisioningUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1768423425;
				if (num != 0)
				{
				}
				num = (short)1631846400;
				short num2 = num;
				num = (short)203474195;
				short num3 = num;
				num = (short)34391315;
				switch (num3 == num)
				{
				}
				num = (short)1842544640;
				if (num != 0)
				{
				}
				return this.<ProvisioningUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1633746994;
				short num2 = num;
				num = (short)1871511602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114505216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938948097;
				if (num != 0)
				{
				}
				num = (short)435879936;
				if (num != 0)
				{
				}
				this.<ProvisioningUuid>k__BackingField = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0002E89C File Offset: 0x0002CA9C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ProvisioningName", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public string ProvisioningName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)862029949;
				short num2 = num;
				num = (short)1517324413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108920832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)534380544;
				if (num != 0)
				{
				}
				return this.<ProvisioningName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)748715244;
				short num2 = num;
				num = (short)658734316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1939472384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537343488;
				if (num != 0)
				{
				}
				num = (short)1369964545;
				if (num != 0)
				{
				}
				this.<ProvisioningName>k__BackingField = value;
			}
		}
	}
}
