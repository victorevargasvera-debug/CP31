using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBConfiguration))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXConfiguration))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixConfiguration))]
	[global::System.Serializable]
	public class Configuration : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		public Configuration()
		{
			this.Codeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug>();
			this.Name = string.Empty;
			this.Comment = string.Empty;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0001B994 File Offset: 0x00019B94
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)511967233;
				if (num != 0)
				{
				}
				num = (short)1061661976;
				short num2 = num;
				num = (short)221228312;
				switch (num2 == num)
				{
				}
				num = (short)1009647616;
				short num3 = num;
				num = (short)1881276416;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)245737696;
				short num2 = num;
				num = (short)250980576;
				switch (num2 == num)
				{
				}
				num = (short)2117795841;
				if (num != 0)
				{
				}
				num = (short)2113011712;
				short num3 = num;
				num = (short)1018363904;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0001BA44 File Offset: 0x00019C44
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[global::System.Runtime.Serialization.DataMember]
		public string ConfigurationBaseName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2030303863;
				short num2 = num;
				num = (short)305658487;
				switch (num2 == num)
				{
				}
				num = (short)236650497;
				if (num != 0)
				{
				}
				num = (short)781582336;
				short num3 = num;
				num = (short)2107899904;
				if (num != 0)
				{
				}
				return this.<ConfigurationBaseName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)280889023;
				short num2 = num;
				num = (short)1044645567;
				switch (num2 == num)
				{
				}
				num = (short)1814036481;
				if (num != 0)
				{
				}
				num = (short)1332477952;
				short num3 = num;
				num = (short)697171968;
				if (num != 0)
				{
				}
				this.<ConfigurationBaseName>k__BackingField = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0001BC54 File Offset: 0x00019E54
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1989148673;
				if (num != 0)
				{
				}
				num = (short)1290073206;
				short num2 = num;
				num = (short)848295030;
				switch (num2 == num)
				{
				}
				num = (short)368967680;
				short num3 = num;
				num = (short)1922629632;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1282937466;
				short num2 = num;
				num = (short)2009141882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)85000192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1478754305;
				if (num != 0)
				{
				}
				num = (short)2079326208;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001BD04 File Offset: 0x00019F04
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		[global::System.Runtime.Serialization.DataMember]
		public string Comment
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1354237838;
				short num2 = num;
				num = (short)85198734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014038528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796079617;
				if (num != 0)
				{
				}
				num = (short)1414660096;
				if (num != 0)
				{
				}
				return this.<Comment>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1776915543;
				short num2 = num;
				num = (short)170890327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418054144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)732364801;
				if (num != 0)
				{
				}
				num = (short)1139605504;
				if (num != 0)
				{
				}
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0001BE68 File Offset: 0x0001A068
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0001BF18 File Offset: 0x0001A118
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? DBNodeUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)875224568;
				short num2 = num;
				num = (short)880205304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423165952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278410753;
				if (num != 0)
				{
				}
				num = (short)1131544576;
				if (num != 0)
				{
				}
				return this.<DBNodeUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247804621;
				short num2 = num;
				num = (short)974912717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2032992256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				num = (short)33095681;
				if (num != 0)
				{
				}
				this.<DBNodeUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0001C078 File Offset: 0x0001A278
		[global::System.Runtime.Serialization.DataMember]
		public int RadioCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)753894569;
				short num2 = num;
				num = (short)791839913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991376896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146997248;
				if (num != 0)
				{
				}
				num = (short)47841281;
				if (num != 0)
				{
				}
				return this.<RadioCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1787440854;
				short num2 = num;
				num = (short)66596566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532152320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523370496;
				if (num != 0)
				{
				}
				num = (short)79888385;
				if (num != 0)
				{
				}
				this.<RadioCount>k__BackingField = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001C128 File Offset: 0x0001A328
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		[global::System.Runtime.Serialization.IgnoreDataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode DBNode
		{
			get
			{
				short num = (short)1108175890;
				short num2 = num;
				num = (short)927034386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597505536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718864385;
				if (num != 0)
				{
				}
				num = (short)344260608;
				if (num != 0)
				{
				}
				return this._decompressedNode;
			}
			set
			{
				short num = (short)577172810;
				short num2 = num;
				num = (short)1245508938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)748355584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950679041;
				if (num != 0)
				{
				}
				num = (short)662175744;
				if (num != 0)
				{
				}
				this._decompressedNode = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001C28C File Offset: 0x0001A48C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0001C33C File Offset: 0x0001A53C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug> Codeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1371440080;
				short num2 = num;
				num = (short)1155630032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)841220096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074987008;
				if (num != 0)
				{
				}
				num = (short)990707713;
				if (num != 0)
				{
				}
				return this.<Codeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2076171892;
				short num2 = num;
				num = (short)2059591284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1834024960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712048640;
				if (num != 0)
				{
				}
				num = (short)898826241;
				if (num != 0)
				{
				}
				this.<Codeplugs>k__BackingField = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1127175283;
				short num2 = num;
				num = (short)939742323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571749888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330170369;
				if (num != 0)
				{
				}
				num = (short)281346048;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1149967072;
				short num2 = num;
				num = (short)1146690272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)250937344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583415296;
				if (num != 0)
				{
				}
				num = (short)677773313;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001C550 File Offset: 0x0001A750
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0001C600 File Offset: 0x0001A800
		[global::System.Runtime.Serialization.DataMember]
		public string MinimalMVO
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1394868225;
				if (num != 0)
				{
				}
				num = (short)1145438208;
				short num2 = num;
				num = (short)1999284932;
				short num3 = num;
				num = (short)785296068;
				switch (num3 == num)
				{
				}
				num = (short)1077870592;
				if (num != 0)
				{
				}
				return this.<MinimalMVO>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)459098841;
				short num2 = num;
				num = (short)1555253977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1099169792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582563329;
				if (num != 0)
				{
				}
				num = (short)1904672768;
				if (num != 0)
				{
				}
				this.<MinimalMVO>k__BackingField = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0001C760 File Offset: 0x0001A960
		[global::System.Runtime.Serialization.DataMember]
		public string OrginalCPVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1158761811;
				short num2 = num;
				num = (short)1120292179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463549952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143354881;
				if (num != 0)
				{
				}
				num = (short)673054720;
				if (num != 0)
				{
				}
				return this.<OrginalCPVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1061884288;
				short num2 = num;
				num = (short)725488000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085407232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152436736;
				if (num != 0)
				{
				}
				num = (short)1661468673;
				if (num != 0)
				{
				}
				this.<OrginalCPVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0001C810 File Offset: 0x0001AA10
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[global::System.Runtime.Serialization.DataMember]
		public string Original_RadioSN
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1750142982;
				short num2 = num;
				num = (short)568791046;
				switch (num2 == num)
				{
				}
				num = (short)1213071361;
				if (num != 0)
				{
				}
				num = (short)1957101568;
				short num3 = num;
				num = (short)71892992;
				if (num != 0)
				{
				}
				return this.<Original_RadioSN>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)989508463;
				short num2 = num;
				num = (short)904049519;
				switch (num2 == num)
				{
				}
				num = (short)1437007872;
				if (num != 0)
				{
				}
				num = (short)726204416;
				short num3 = num;
				num = (short)1408696321;
				if (num != 0)
				{
				}
				this.<Original_RadioSN>k__BackingField = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001C974 File Offset: 0x0001AB74
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0001CA24 File Offset: 0x0001AC24
		[global::System.Runtime.Serialization.DataMember]
		public string Original_FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)417891580;
				short num2 = num;
				num = (short)1524991228;
				switch (num2 == num)
				{
				}
				num = (short)580321281;
				if (num != 0)
				{
				}
				num = (short)1800142848;
				short num3 = num;
				num = (short)1139736576;
				if (num != 0)
				{
				}
				return this.<Original_FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)645311700;
				short num2 = num;
				num = (short)1143581908;
				switch (num2 == num)
				{
				}
				num = (short)681639937;
				if (num != 0)
				{
				}
				num = (short)252313600;
				short num3 = num;
				num = (short)114753536;
				if (num != 0)
				{
				}
				this.<Original_FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0001CB88 File Offset: 0x0001AD88
		[global::System.Runtime.Serialization.DataMember]
		public string Original_OptionsWithPCI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1883453352;
				short num2 = num;
				num = (short)654718888;
				switch (num2 == num)
				{
				}
				num = (short)431226880;
				if (num != 0)
				{
				}
				num = (short)637206528;
				short num3 = num;
				num = (short)390791169;
				if (num != 0)
				{
				}
				return this.<Original_OptionsWithPCI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1059321563;
				short num2 = num;
				num = (short)457438939;
				switch (num2 == num)
				{
				}
				num = (short)1435697153;
				if (num != 0)
				{
				}
				num = (short)385155072;
				short num3 = num;
				num = (short)1694498816;
				if (num != 0)
				{
				}
				this.<Original_OptionsWithPCI>k__BackingField = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0001CC38 File Offset: 0x0001AE38
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention ConfigurationExt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)857152829;
				short num2 = num;
				num = (short)18881853;
				switch (num2 == num)
				{
				}
				num = (short)2055471105;
				if (num != 0)
				{
				}
				num = (short)2061434880;
				short num3 = num;
				num = (short)1917648896;
				if (num != 0)
				{
				}
				return this.<ConfigurationExt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1857182140;
				short num2 = num;
				num = (short)1032804796;
				switch (num2 == num)
				{
				}
				num = (short)307429377;
				if (num != 0)
				{
				}
				num = (short)1315176448;
				short num3 = num;
				num = (short)550043648;
				if (num != 0)
				{
				}
				this.<ConfigurationExt>k__BackingField = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0001CD98 File Offset: 0x0001AF98
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0001CE58 File Offset: 0x0001B058
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public byte[] DBNodeCmpBytes
		{
			get
			{
				if (this._decompressedNode != null)
				{
					short num = (short)787211023;
					short num2 = num;
					num = (short)1825170191;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)177274880;
						short num3 = num;
						num = (short)1021968384;
						if (num != 0)
						{
						}
						num = (short)601948161;
						if (num != 0)
						{
						}
						return this._decompressedNode.SerializeAndZip();
					}
					}
				}
				return null;
			}
			set
			{
				short num = (short)174456331;
				short num2 = num;
				num = (short)318832139;
				switch (num2 == num)
				{
				}
				num = (short)374407168;
				if (num != 0)
				{
				}
				num = (short)1179254784;
				short num3 = num;
				num = (short)899809281;
				if (num != 0)
				{
				}
				this._decompressedNode = global::Motorola.CommonCPS.Server.EntityModel.DBNode.DeserializeFromZip(value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001CF10 File Offset: 0x0001B110
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		[global::System.Runtime.Serialization.DataMember]
		public string BaseCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1507037900;
				short num2 = num;
				num = (short)76714700;
				switch (num2 == num)
				{
				}
				num = (short)1312030721;
				if (num != 0)
				{
				}
				num = (short)682950656;
				short num3 = num;
				num = (short)2092564480;
				if (num != 0)
				{
				}
				return this.<BaseCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)776303270;
				short num2 = num;
				num = (short)2034922150;
				switch (num2 == num)
				{
				}
				num = (short)1052508160;
				if (num != 0)
				{
				}
				num = (short)1016463360;
				short num3 = num;
				num = (short)1814167553;
				if (num != 0)
				{
				}
				this.<BaseCodeplug>k__BackingField = value;
			}
		}

		// Token: 0x0400013D RID: 317
		private global::Motorola.CommonCPS.Server.EntityModel.DBNode _decompressedNode;
	}
}
