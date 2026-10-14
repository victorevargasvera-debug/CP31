using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000084 RID: 132
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRRadioSystemSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0006BCD0 File Offset: 0x00069ED0
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0006BD7C File Offset: 0x00069F7C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SerialNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1342174832;
				short num2 = num;
				num = (short)1912206960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1152253952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348861953;
				if (num != 0)
				{
				}
				num = (short)675217408;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1655505272;
				short num2 = num;
				num = (short)909508984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1633746944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284295168;
				if (num != 0)
				{
				}
				num = (short)727449601;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0006BE2C File Offset: 0x0006A02C
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0006BED8 File Offset: 0x0006A0D8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
		public string ConfigurationName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2075676371;
				short num2 = num;
				num = (short)1689800403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846542336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610271233;
				if (num != 0)
				{
				}
				num = (short)53936128;
				if (num != 0)
				{
				}
				return this.<ConfigurationName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1896688018;
				short num2 = num;
				num = (short)1076177298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1787559936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602537985;
				if (num != 0)
				{
				}
				num = (short)1715601408;
				if (num != 0)
				{
				}
				this.<ConfigurationName>k__BackingField = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0006BF8C File Offset: 0x0006A18C
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0006C038 File Offset: 0x0006A238
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.Guid? ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1207516934;
				short num2 = num;
				num = (short)1994997510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678376960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039204352;
				if (num != 0)
				{
				}
				num = (short)1390411777;
				if (num != 0)
				{
				}
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1564437370;
				short num2 = num;
				num = (short)1442868090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)245628928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383464960;
				if (num != 0)
				{
				}
				num = (short)633208833;
				if (num != 0)
				{
				}
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0006C0E8 File Offset: 0x0006A2E8
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0006C198 File Offset: 0x0006A398
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)401211393;
				if (num != 0)
				{
				}
				num = (short)267255808;
				short num2 = num;
				num = (short)527341339;
				short num3 = num;
				num = (short)1810601755;
				switch (num3 == num)
				{
				}
				num = (short)111083520;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)255386843;
				short num2 = num;
				num = (short)817161435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)202506240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1903362049;
				if (num != 0)
				{
				}
				num = (short)1375469568;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0006C248 File Offset: 0x0006A448
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0006C2F8 File Offset: 0x0006A4F8
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("GroupUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1733206758;
				short num2 = num;
				num = (short)1905173222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738000896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396492801;
				if (num != 0)
				{
				}
				num = (short)1227751424;
				if (num != 0)
				{
				}
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)931820166;
				short num2 = num;
				num = (short)498233990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908853248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)481296384;
				if (num != 0)
				{
				}
				num = (short)145752065;
				if (num != 0)
				{
				}
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0006C458 File Offset: 0x0006A658
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Uuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)950075393;
				if (num != 0)
				{
				}
				num = (short)424083456;
				short num2 = num;
				num = (short)920227448;
				short num3 = num;
				num = (short)1268878968;
				switch (num3 == num)
				{
				}
				num = (short)1052835840;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1022379926;
				short num2 = num;
				num = (short)733955990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961492480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1140260865;
				if (num != 0)
				{
				}
				num = (short)876937216;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0006C50C File Offset: 0x0006A70C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0006C5BC File Offset: 0x0006A7BC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1728575567;
				short num2 = num;
				num = (short)27719759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198194688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127533057;
				if (num != 0)
				{
				}
				num = (short)183369728;
				if (num != 0)
				{
				}
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1741478602;
				short num2 = num;
				num = (short)412670666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545273344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053701632;
				if (num != 0)
				{
				}
				num = (short)2053111809;
				if (num != 0)
				{
				}
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0006C66C File Offset: 0x0006A86C
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0006C71C File Offset: 0x0006A91C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DMR3SystemUUID", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public string DMR3SystemUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2053048163;
				short num2 = num;
				num = (short)703727459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113522176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)38076416;
				if (num != 0)
				{
				}
				num = (short)2084438017;
				if (num != 0)
				{
				}
				return this.<DMR3SystemUUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)84058559;
				short num2 = num;
				num = (short)25928127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174142976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421265408;
				if (num != 0)
				{
				}
				num = (short)1457913857;
				if (num != 0)
				{
				}
				this.<DMR3SystemUUID>k__BackingField = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0006C7CC File Offset: 0x0006A9CC
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0006C878 File Offset: 0x0006AA78
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("NetworkId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public int? NetworkId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2089414202;
				short num2 = num;
				num = (short)710536762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211943424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121569281;
				if (num != 0)
				{
				}
				num = (short)1558315008;
				if (num != 0)
				{
				}
				return this.<NetworkId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)561462582;
				short num2 = num;
				num = (short)1385512246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767964672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380057089;
				if (num != 0)
				{
				}
				num = (short)2134245376;
				if (num != 0)
				{
				}
				this.<NetworkId>k__BackingField = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0006C928 File Offset: 0x0006AB28
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0006C9DC File Offset: 0x0006ABDC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DMR3SystemAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public string DMR3SystemAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)368922128;
				short num2 = num;
				num = (short)633294352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1050542080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532166145;
				if (num != 0)
				{
				}
				num = (short)1741881344;
				if (num != 0)
				{
				}
				return this.<DMR3SystemAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1158796385;
				short num2 = num;
				num = (short)1329648737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285160960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069430273;
				if (num != 0)
				{
				}
				num = (short)959578112;
				if (num != 0)
				{
				}
				this.<DMR3SystemAlias>k__BackingField = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0006CA8C File Offset: 0x0006AC8C
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConvPersAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public string ConvPersAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)59244545;
				if (num != 0)
				{
				}
				num = (short)547815424;
				short num2 = num;
				num = (short)1222074962;
				short num3 = num;
				num = (short)1025729106;
				switch (num3 == num)
				{
				}
				num = (short)2101673984;
				if (num != 0)
				{
				}
				return this.<ConvPersAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1342499169;
				short num2 = num;
				num = (short)701753697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108475904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190330368;
				if (num != 0)
				{
				}
				num = (short)178716673;
				if (num != 0)
				{
				}
				this.<ConvPersAlias>k__BackingField = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0006CBF0 File Offset: 0x0006ADF0
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SiteId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public int? SiteId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1315470442;
				short num2 = num;
				num = (short)2059172970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928317440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027356160;
				if (num != 0)
				{
				}
				num = (short)406781953;
				if (num != 0)
				{
				}
				return this.<SiteId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1596050082;
				short num2 = num;
				num = (short)2028849826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338900480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143799809;
				if (num != 0)
				{
				}
				num = (short)635699200;
				if (num != 0)
				{
				}
				this.<SiteId>k__BackingField = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0006CD54 File Offset: 0x0006AF54
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0006CE04 File Offset: 0x0006B004
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SiteAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public string SiteAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1024851969;
				if (num != 0)
				{
				}
				num = (short)234946560;
				short num2 = num;
				num = (short)1712853448;
				short num3 = num;
				num = (short)1145508296;
				switch (num3 == num)
				{
				}
				num = (short)1392574464;
				if (num != 0)
				{
				}
				return this.<SiteAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1125350574;
				short num2 = num;
				num = (short)1018002606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253100032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)501022721;
				if (num != 0)
				{
				}
				num = (short)1221853184;
				if (num != 0)
				{
				}
				this.<SiteAlias>k__BackingField = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0006CEB4 File Offset: 0x0006B0B4
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0006CF64 File Offset: 0x0006B164
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioId", typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug))]
		public int? SUId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1210167053;
				short num2 = num;
				num = (short)610971405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118685696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712966145;
				if (num != 0)
				{
				}
				num = (short)1223950336;
				if (num != 0)
				{
				}
				return this.<SUId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1703917927;
				short num2 = num;
				num = (short)1137686887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764950016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338231296;
				if (num != 0)
				{
				}
				num = (short)1200095233;
				if (num != 0)
				{
				}
				this.<SUId>k__BackingField = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0006D014 File Offset: 0x0006B214
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x0006D0C4 File Offset: 0x0006B2C4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DMR3AuthenticationKey", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public byte[] DMR3AuthenticationKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)933625856;
				short num2 = num;
				num = (short)1846666103;
				short num3 = num;
				num = (short)1616503671;
				switch (num3 == num)
				{
				}
				num = (short)2043281408;
				if (num != 0)
				{
				}
				return this.<DMR3AuthenticationKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)734837227;
				short num2 = num;
				num = (short)179812843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)540082176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251409920;
				if (num != 0)
				{
				}
				num = (short)1965555713;
				if (num != 0)
				{
				}
				this.<DMR3AuthenticationKey>k__BackingField = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0006D174 File Offset: 0x0006B374
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0006D224 File Offset: 0x0006B424
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("MasterKey", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public byte[] MasterKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1446314028;
				short num2 = num;
				num = (short)1901264940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465778176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624754689;
				if (num != 0)
				{
				}
				num = (short)1511129088;
				if (num != 0)
				{
				}
				return this.<MasterKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1684081074;
				short num2 = num;
				num = (short)1183386034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210108416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)410255361;
				if (num != 0)
				{
				}
				num = (short)2001600512;
				if (num != 0)
				{
				}
				this.<MasterKey>k__BackingField = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0006D384 File Offset: 0x0006B584
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DMR3FNEType", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public int? DMR3FNEType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)41902719;
				short num2 = num;
				num = (short)2079941247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70713344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6029313;
				if (num != 0)
				{
				}
				num = (short)648675328;
				if (num != 0)
				{
				}
				return this.<DMR3FNEType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)580375653;
				short num2 = num;
				num = (short)831050853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955252736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058275329;
				if (num != 0)
				{
				}
				num = (short)628490240;
				if (num != 0)
				{
				}
				this.<DMR3FNEType>k__BackingField = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0006D434 File Offset: 0x0006B634
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0006D4E4 File Offset: 0x0006B6E4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RepeaterId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public int? RepeaterId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)644985735;
				short num2 = num;
				num = (short)1963504519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1766457344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238092289;
				if (num != 0)
				{
				}
				num = (short)595656704;
				if (num != 0)
				{
				}
				return this.<RepeaterId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1245170259;
				short num2 = num;
				num = (short)1382402643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379729408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259063809;
				if (num != 0)
				{
				}
				num = (short)1701314560;
				if (num != 0)
				{
				}
				this.<RepeaterId>k__BackingField = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0006D594 File Offset: 0x0006B794
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x0006D644 File Offset: 0x0006B844
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RedundancyGroupId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public int? RedundancyGroupId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)606043185;
				short num2 = num;
				num = (short)1277721649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044985344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694302208;
				if (num != 0)
				{
				}
				num = (short)1611923457;
				if (num != 0)
				{
				}
				return this.<RedundancyGroupId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2130842620;
				short num2 = num;
				num = (short)151131132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881669632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286668289;
				if (num != 0)
				{
				}
				num = (short)1467613184;
				if (num != 0)
				{
				}
				this.<RedundancyGroupId>k__BackingField = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x0006D7AC File Offset: 0x0006B9AC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ControllerRedundancyGroupId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public int? ControllerRedundancyGroupId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2113289921;
				short num2 = num;
				num = (short)928399041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202323456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148846080;
				if (num != 0)
				{
				}
				num = (short)1946877953;
				if (num != 0)
				{
				}
				return this.<ControllerRedundancyGroupId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1652248217;
				short num2 = num;
				num = (short)1892961945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1937899520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702742528;
				if (num != 0)
				{
				}
				num = (short)1417412609;
				if (num != 0)
				{
				}
				this.<ControllerRedundancyGroupId>k__BackingField = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0006D860 File Offset: 0x0006BA60
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x0006D910 File Offset: 0x0006BB10
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ControllerId", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public int? ControllerId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)760708584;
				short num2 = num;
				num = (short)66289128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1280507904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063663105;
				if (num != 0)
				{
				}
				num = (short)127860736;
				if (num != 0)
				{
				}
				return this.<ControllerId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)335393813;
				short num2 = num;
				num = (short)1637331989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656946688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)713293825;
				if (num != 0)
				{
				}
				num = (short)1034944512;
				if (num != 0)
				{
				}
				this.<ControllerId>k__BackingField = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0006D9C0 File Offset: 0x0006BBC0
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0006DA70 File Offset: 0x0006BC70
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("NetWorkModel", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		public int? NetWorkModel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2038104065;
				if (num != 0)
				{
				}
				num = (short)1796866048;
				short num2 = num;
				num = (short)1841142384;
				short num3 = num;
				num = (short)1792842352;
				switch (num3 == num)
				{
				}
				num = (short)75366400;
				if (num != 0)
				{
				}
				return this.<NetWorkModel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)541752628;
				short num2 = num;
				num = (short)1656454452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862584832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1454374912;
				if (num != 0)
				{
				}
				num = (short)1103888385;
				if (num != 0)
				{
				}
				this.<NetWorkModel>k__BackingField = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0006DB20 File Offset: 0x0006BD20
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CodeplugUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)599033179;
				short num2 = num;
				num = (short)63210843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249364480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2041184257;
				if (num != 0)
				{
				}
				num = (short)231407616;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1690043467;
				short num2 = num;
				num = (short)125109323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050621440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402929153;
				if (num != 0)
				{
				}
				num = (short)404291584;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0006DC84 File Offset: 0x0006BE84
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0006DD30 File Offset: 0x0006BF30
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709539426;
				short num2 = num;
				num = (short)1684439138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121845248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704249856;
				if (num != 0)
				{
				}
				num = (short)1491599361;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)509759867;
				short num2 = num;
				num = (short)1743868283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1515585536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)357105665;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}
	}
}
