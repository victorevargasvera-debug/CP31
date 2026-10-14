using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000037 RID: 55
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public sealed class ASTROFirmware : global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00038DB8 File Offset: 0x00036FB8
		public ASTROFirmware()
		{
			this.<IsCompatible>k__BackingField = true;
			base..ctor();
			this.APXCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug>();
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00038DE0 File Offset: 0x00036FE0
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00038E90 File Offset: 0x00037090
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1376257631;
				short num2 = num;
				num = (short)1230636639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1664024576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443889153;
				if (num != 0)
				{
				}
				num = (short)512557056;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1276294981;
				short num2 = num;
				num = (short)1093515077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)580714496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093402625;
				if (num != 0)
				{
				}
				num = (short)103022592;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00038F40 File Offset: 0x00037140
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00038FF4 File Offset: 0x000371F4
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1072955393;
				if (num != 0)
				{
				}
				num = (short)1846673408;
				short num2 = num;
				num = (short)1068556902;
				short num3 = num;
				num = (short)246669926;
				switch (num3 == num)
				{
				}
				num = (short)1904607232;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1312220702;
				short num2 = num;
				num = (short)2067785246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)723517440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309343745;
				if (num != 0)
				{
				}
				num = (short)248643584;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000390A4 File Offset: 0x000372A4
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00039154 File Offset: 0x00037354
		[global::System.Runtime.Serialization.DataMember]
		public int? HfwsFlag
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1413618663;
				short num2 = num;
				num = (short)1928731623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455344128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428867585;
				if (num != 0)
				{
				}
				num = (short)1425408000;
				if (num != 0)
				{
				}
				return this.<HfwsFlag>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1749374878;
				short num2 = num;
				num = (short)1156011934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550188544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925827073;
				if (num != 0)
				{
				}
				num = (short)355205120;
				if (num != 0)
				{
				}
				this.<HfwsFlag>k__BackingField = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00039204 File Offset: 0x00037404
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x000392B4 File Offset: 0x000374B4
		[global::System.Runtime.Serialization.DataMember]
		public string DspVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1248326322;
				short num2 = num;
				num = (short)1378480818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620625920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416298497;
				if (num != 0)
				{
				}
				num = (short)795475968;
				if (num != 0)
				{
				}
				return this.<DspVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1530902694;
				short num2 = num;
				num = (short)718846118;
				switch (num2 == num)
				{
				}
				num = (short)588316673;
				if (num != 0)
				{
				}
				num = (short)1534656512;
				if (num != 0)
				{
				}
				num = (short)350289920;
				short num3 = num;
				this.<DspVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00039364 File Offset: 0x00037564
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00039414 File Offset: 0x00037614
		[global::System.Runtime.Serialization.DataMember]
		public string SoftwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1383006209;
				if (num != 0)
				{
				}
				num = (short)606381538;
				short num2 = num;
				num = (short)1649976802;
				switch (num2 == num)
				{
				}
				num = (short)1405878272;
				if (num != 0)
				{
				}
				num = (short)823590912;
				short num3 = num;
				return this.<SoftwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1476932020;
				short num2 = num;
				num = (short)309604788;
				switch (num2 == num)
				{
				}
				num = (short)632946688;
				if (num != 0)
				{
				}
				num = (short)1746796545;
				if (num != 0)
				{
				}
				num = (short)458358784;
				short num3 = num;
				this.<SoftwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000394C8 File Offset: 0x000376C8
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00039578 File Offset: 0x00037778
		[global::System.Runtime.Serialization.DataMember]
		public string BPSoftwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1564682802;
				short num2 = num;
				num = (short)456010290;
				switch (num2 == num)
				{
				}
				num = (short)640221185;
				if (num != 0)
				{
				}
				num = (short)518455296;
				if (num != 0)
				{
				}
				num = (short)296615936;
				short num3 = num;
				return this.<BPSoftwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)28393801;
				short num2 = num;
				num = (short)947339593;
				switch (num2 == num)
				{
				}
				num = (short)748486657;
				if (num != 0)
				{
				}
				num = (short)320995328;
				if (num != 0)
				{
				}
				num = (short)1687552000;
				short num3 = num;
				this.<BPSoftwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00039628 File Offset: 0x00037828
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x000396D8 File Offset: 0x000378D8
		[global::System.Runtime.Serialization.DataMember]
		public string BaseSoftwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)776098054;
				short num2 = num;
				num = (short)1562398982;
				switch (num2 == num)
				{
				}
				num = (short)1109458945;
				if (num != 0)
				{
				}
				num = (short)29032448;
				if (num != 0)
				{
				}
				num = (short)1352400896;
				short num3 = num;
				return this.<BaseSoftwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)34801198;
				short num2 = num;
				num = (short)1777141294;
				switch (num2 == num)
				{
				}
				num = (short)373161985;
				if (num != 0)
				{
				}
				num = (short)2125791232;
				if (num != 0)
				{
				}
				num = (short)1177616384;
				short num3 = num;
				this.<BaseSoftwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00039788 File Offset: 0x00037988
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00039838 File Offset: 0x00037A38
		[global::System.Runtime.Serialization.DataMember]
		public long? BuildTimestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)658356938;
				short num2 = num;
				num = (short)1935915722;
				switch (num2 == num)
				{
				}
				num = (short)1672609793;
				if (num != 0)
				{
				}
				num = (short)1806237696;
				if (num != 0)
				{
				}
				num = (short)1626341376;
				short num3 = num;
				return this.<BuildTimestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)398647177;
				short num2 = num;
				num = (short)1334108041;
				switch (num2 == num)
				{
				}
				num = (short)252051457;
				if (num != 0)
				{
				}
				num = (short)828833792;
				if (num != 0)
				{
				}
				num = (short)1554251776;
				short num3 = num;
				this.<BuildTimestamp>k__BackingField = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000398E8 File Offset: 0x00037AE8
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00039998 File Offset: 0x00037B98
		[global::System.Runtime.Serialization.DataMember]
		public string MaceFlashVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)978465029;
				short num2 = num;
				num = (short)875704581;
				switch (num2 == num)
				{
				}
				num = (short)1360658433;
				if (num != 0)
				{
				}
				num = (short)1347813376;
				if (num != 0)
				{
				}
				num = (short)1568079872;
				short num3 = num;
				return this.<MaceFlashVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)942614517;
				short num2 = num;
				num = (short)482158581;
				switch (num2 == num)
				{
				}
				num = (short)1794637825;
				if (num != 0)
				{
				}
				num = (short)1935147008;
				if (num != 0)
				{
				}
				num = (short)1765146624;
				short num3 = num;
				this.<MaceFlashVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00039A4C File Offset: 0x00037C4C
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00039AFC File Offset: 0x00037CFC
		[global::System.Runtime.Serialization.DataMember]
		public string PsdtVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)200721139;
				short num2 = num;
				num = (short)1290978035;
				switch (num2 == num)
				{
				}
				num = (short)1203568641;
				if (num != 0)
				{
				}
				num = (short)561643520;
				if (num != 0)
				{
				}
				num = (short)135200768;
				short num3 = num;
				return this.<PsdtVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1305124651;
				short num2 = num;
				num = (short)579313451;
				switch (num2 == num)
				{
				}
				num = (short)910426112;
				if (num != 0)
				{
				}
				num = (short)218955777;
				if (num != 0)
				{
				}
				num = (short)148897792;
				short num3 = num;
				this.<PsdtVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00039BAC File Offset: 0x00037DAC
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00039C5C File Offset: 0x00037E5C
		[global::System.Runtime.Serialization.DataMember]
		public string OptBrdHwHostVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2139265973;
				short num2 = num;
				num = (short)1992334261;
				switch (num2 == num)
				{
				}
				num = (short)1047199745;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				if (num != 0)
				{
				}
				num = (short)1830486016;
				short num3 = num;
				return this.<OptBrdHwHostVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1963982849;
				if (num != 0)
				{
				}
				num = (short)550772195;
				short num2 = num;
				num = (short)1086135779;
				switch (num2 == num)
				{
				}
				num = (short)74842112;
				if (num != 0)
				{
				}
				num = (short)1494482944;
				short num3 = num;
				this.<OptBrdHwHostVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00039D0C File Offset: 0x00037F0C
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00039DBC File Offset: 0x00037FBC
		[global::System.Runtime.Serialization.DataMember]
		public string ConBrdHwHostVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1311919291;
				short num2 = num;
				num = (short)391531707;
				switch (num2 == num)
				{
				}
				num = (short)23724033;
				if (num != 0)
				{
				}
				num = (short)394526720;
				if (num != 0)
				{
				}
				num = (short)2108030976;
				short num3 = num;
				return this.<ConBrdHwHostVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1816497815;
				short num2 = num;
				num = (short)1496157847;
				switch (num2 == num)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				num = (short)1534984193;
				if (num != 0)
				{
				}
				num = (short)1599143936;
				short num3 = num;
				this.<ConBrdHwHostVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00039E6C File Offset: 0x0003806C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00039F1C File Offset: 0x0003811C
		[global::System.Runtime.Serialization.DataMember]
		public string TargetModel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1566244865;
				if (num != 0)
				{
				}
				num = (short)1425653428;
				short num2 = num;
				num = (short)124108468;
				switch (num2 == num)
				{
				}
				num = (short)1813053440;
				if (num != 0)
				{
				}
				num = (short)1005912064;
				short num3 = num;
				return this.<TargetModel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)838780791;
				short num2 = num;
				num = (short)1683212151;
				switch (num2 == num)
				{
				}
				num = (short)1851129857;
				if (num != 0)
				{
				}
				num = (short)1288896512;
				if (num != 0)
				{
				}
				num = (short)802881536;
				short num3 = num;
				this.<TargetModel>k__BackingField = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00039FCC File Offset: 0x000381CC
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x0003A07C File Offset: 0x0003827C
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsFreonFirmwareUpgradeFile
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1446304062;
				short num2 = num;
				num = (short)1576982846;
				switch (num2 == num)
				{
				}
				num = (short)355008513;
				if (num != 0)
				{
				}
				num = (short)240648192;
				if (num != 0)
				{
				}
				num = (short)1900412928;
				short num3 = num;
				return this.<IsFreonFirmwareUpgradeFile>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1692205057;
				if (num != 0)
				{
				}
				num = (short)873567662;
				short num2 = num;
				num = (short)931173806;
				switch (num2 == num)
				{
				}
				num = (short)640745472;
				if (num != 0)
				{
				}
				num = (short)49020928;
				short num3 = num;
				this.<IsFreonFirmwareUpgradeFile>k__BackingField = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0003A12C File Offset: 0x0003832C
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0003A1DC File Offset: 0x000383DC
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCompatible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1035665409;
				if (num != 0)
				{
				}
				num = (short)615322369;
				short num2 = num;
				num = (short)492114689;
				switch (num2 == num)
				{
				}
				num = (short)1575223296;
				if (num != 0)
				{
				}
				num = (short)1837891584;
				short num3 = num;
				return this.<IsCompatible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)138792517;
				short num2 = num;
				num = (short)1148898885;
				switch (num2 == num)
				{
				}
				num = (short)587857921;
				if (num != 0)
				{
				}
				num = (short)1554579456;
				if (num != 0)
				{
				}
				num = (short)1121058816;
				short num3 = num;
				this.<IsCompatible>k__BackingField = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0003A290 File Offset: 0x00038490
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0003A340 File Offset: 0x00038540
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsOMAPFirmwareUpgradeFile
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)309275452;
				short num2 = num;
				num = (short)240200508;
				switch (num2 == num)
				{
				}
				num = (short)787677185;
				if (num != 0)
				{
				}
				num = (short)127270912;
				if (num != 0)
				{
				}
				num = (short)673579008;
				short num3 = num;
				return this.<IsOMAPFirmwareUpgradeFile>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)211479472;
				short num2 = num;
				num = (short)1639377840;
				switch (num2 == num)
				{
				}
				num = (short)809762817;
				if (num != 0)
				{
				}
				num = (short)695140352;
				if (num != 0)
				{
				}
				num = (short)1727397888;
				short num3 = num;
				this.<IsOMAPFirmwareUpgradeFile>k__BackingField = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0003A3F4 File Offset: 0x000385F4
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0003A4A4 File Offset: 0x000386A4
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1357012697;
				short num2 = num;
				num = (short)332095193;
				switch (num2 == num)
				{
				}
				num = (short)538574848;
				if (num != 0)
				{
				}
				num = (short)722272257;
				if (num != 0)
				{
				}
				num = (short)1408696320;
				short num3 = num;
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2142638028;
				short num2 = num;
				num = (short)2021199820;
				switch (num2 == num)
				{
				}
				num = (short)194183168;
				if (num != 0)
				{
				}
				num = (short)2014445569;
				if (num != 0)
				{
				}
				num = (short)2013724672;
				short num3 = num;
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0003A554 File Offset: 0x00038754
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x0003A604 File Offset: 0x00038804
		[global::System.Runtime.Serialization.DataMember]
		public string LTEOptBrdHwHostVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)841744385;
				if (num != 0)
				{
				}
				num = (short)272462422;
				short num2 = num;
				num = (short)779055702;
				switch (num2 == num)
				{
				}
				num = (short)773521408;
				if (num != 0)
				{
				}
				num = (short)995164160;
				short num3 = num;
				return this.<LTEOptBrdHwHostVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1981915628;
				short num2 = num;
				num = (short)674865644;
				switch (num2 == num)
				{
				}
				num = (short)1719664641;
				if (num != 0)
				{
				}
				num = (short)613613568;
				if (num != 0)
				{
				}
				num = (short)1336999936;
				short num3 = num;
				this.<LTEOptBrdHwHostVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0003A6B8 File Offset: 0x000388B8
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x0003A768 File Offset: 0x00038968
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug> APXCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1299991801;
				short num2 = num;
				num = (short)1761299705;
				switch (num2 == num)
				{
				}
				num = (short)212860929;
				if (num != 0)
				{
				}
				num = (short)1990590464;
				if (num != 0)
				{
				}
				num = (short)1611005952;
				short num3 = num;
				return this.<APXCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1657470977;
				if (num != 0)
				{
				}
				num = (short)763032396;
				short num2 = num;
				num = (short)1037955916;
				switch (num2 == num)
				{
				}
				num = (short)527433728;
				if (num != 0)
				{
				}
				num = (short)956301312;
				short num3 = num;
				this.<APXCodeplugs>k__BackingField = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0003A818 File Offset: 0x00038A18
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0003A8C4 File Offset: 0x00038AC4
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsSubFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)530269668;
				short num2 = num;
				num = (short)1331578340;
				switch (num2 == num)
				{
				}
				num = (short)1973551105;
				if (num != 0)
				{
				}
				num = (short)1952055296;
				if (num != 0)
				{
				}
				num = (short)1204944896;
				short num3 = num;
				return this.<IsSubFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1210074057;
				short num2 = num;
				num = (short)1279083465;
				switch (num2 == num)
				{
				}
				num = (short)749469697;
				if (num != 0)
				{
				}
				num = (short)73728000;
				if (num != 0)
				{
				}
				num = (short)379256832;
				short num3 = num;
				this.<IsSubFirmware>k__BackingField = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0003A974 File Offset: 0x00038B74
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0003AA24 File Offset: 0x00038C24
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsVirtualSummaryFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)295818381;
				short num2 = num;
				num = (short)839242893;
				switch (num2 == num)
				{
				}
				num = (short)362938368;
				if (num != 0)
				{
				}
				num = (short)741539841;
				if (num != 0)
				{
				}
				num = (short)2030960640;
				short num3 = num;
				return this.<IsVirtualSummaryFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1767260532;
				short num2 = num;
				num = (short)1340359028;
				switch (num2 == num)
				{
				}
				num = (short)1415774209;
				if (num != 0)
				{
				}
				num = (short)1461125120;
				if (num != 0)
				{
				}
				num = (short)408748032;
				short num3 = num;
				this.<IsVirtualSummaryFirmware>k__BackingField = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0003AAD4 File Offset: 0x00038CD4
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x0003AB84 File Offset: 0x00038D84
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> SubFirmwares
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)797359315;
				short num2 = num;
				num = (short)1261288659;
				switch (num2 == num)
				{
				}
				num = (short)1747582977;
				if (num != 0)
				{
				}
				num = (short)85721088;
				if (num != 0)
				{
				}
				num = (short)282198016;
				short num3 = num;
				return this.<SubFirmwares>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2137967726;
				short num2 = num;
				num = (short)624282734;
				switch (num2 == num)
				{
				}
				num = (short)1640103937;
				if (num != 0)
				{
				}
				num = (short)629080064;
				if (num != 0)
				{
				}
				num = (short)1279524864;
				short num3 = num;
				this.<SubFirmwares>k__BackingField = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0003AC38 File Offset: 0x00038E38
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0003ACE4 File Offset: 0x00038EE4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware SummaryFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)503150725;
				short num2 = num;
				num = (short)1064401029;
				switch (num2 == num)
				{
				}
				num = (short)1606811648;
				if (num != 0)
				{
				}
				num = (short)678297601;
				if (num != 0)
				{
				}
				num = (short)122355712;
				short num3 = num;
				return this.<SummaryFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)750190593;
				if (num != 0)
				{
				}
				num = (short)418770466;
				short num2 = num;
				num = (short)1359670818;
				switch (num2 == num)
				{
				}
				num = (short)270598144;
				if (num != 0)
				{
				}
				num = (short)317915136;
				short num3 = num;
				this.<SummaryFirmware>k__BackingField = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0003AD94 File Offset: 0x00038F94
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0003AE44 File Offset: 0x00039044
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? SummaryFirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)251590794;
				short num2 = num;
				num = (short)25360522;
				switch (num2 == num)
				{
				}
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)2050162688;
				if (num != 0)
				{
				}
				num = (short)236060672;
				short num3 = num;
				return this.<SummaryFirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1228668929;
				if (num != 0)
				{
				}
				num = (short)106206555;
				short num2 = num;
				num = (short)1814599003;
				switch (num2 == num)
				{
				}
				num = (short)643694592;
				if (num != 0)
				{
				}
				num = (short)1343160320;
				short num3 = num;
				this.<SummaryFirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0003AEF4 File Offset: 0x000390F4
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0003AFA4 File Offset: 0x000391A4
		[global::System.Runtime.Serialization.DataMember]
		public string Metadata
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)409389361;
				short num2 = num;
				num = (short)1574553905;
				switch (num2 == num)
				{
				}
				num = (short)1534984192;
				if (num != 0)
				{
				}
				num = (short)1399521281;
				if (num != 0)
				{
				}
				num = (short)1869021184;
				short num3 = num;
				return this.<Metadata>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1027883009;
				short num2 = num;
				num = (short)1530281985;
				switch (num2 == num)
				{
				}
				num = (short)712179713;
				if (num != 0)
				{
				}
				num = (short)1246887936;
				if (num != 0)
				{
				}
				num = (short)1393229824;
				short num3 = num;
				this.<Metadata>k__BackingField = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0003B054 File Offset: 0x00039254
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0003B104 File Offset: 0x00039304
		[global::System.Runtime.Serialization.DataMember]
		public string TargetRelease
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1148117976;
				short num2 = num;
				num = (short)1057285080;
				switch (num2 == num)
				{
				}
				num = (short)392429568;
				if (num != 0)
				{
				}
				num = (short)1016987649;
				if (num != 0)
				{
				}
				num = (short)1078919168;
				short num3 = num;
				return this.<TargetRelease>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)967249624;
				short num2 = num;
				num = (short)1654591192;
				switch (num2 == num)
				{
				}
				num = (short)517996544;
				if (num != 0)
				{
				}
				num = (short)1554251777;
				if (num != 0)
				{
				}
				num = (short)886374400;
				short num3 = num;
				this.<TargetRelease>k__BackingField = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0003B1B4 File Offset: 0x000393B4
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0003B264 File Offset: 0x00039464
		[global::System.Runtime.Serialization.DataMember]
		public string MaxCodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1862533121;
				if (num != 0)
				{
				}
				num = (short)1256546200;
				short num2 = num;
				num = (short)1085693848;
				switch (num2 == num)
				{
				}
				num = (short)1419706368;
				if (num != 0)
				{
				}
				num = (short)503382016;
				short num3 = num;
				return this.<MaxCodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1726406173;
				short num2 = num;
				num = (short)20307485;
				switch (num2 == num)
				{
				}
				num = (short)1004666881;
				if (num != 0)
				{
				}
				num = (short)1652424704;
				if (num != 0)
				{
				}
				num = (short)609943552;
				short num3 = num;
				this.<MaxCodeplugVersion>k__BackingField = value;
			}
		}
	}
}
