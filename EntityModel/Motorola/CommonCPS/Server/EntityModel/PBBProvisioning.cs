using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000073 RID: 115
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBProvisioning : global::Motorola.CommonCPS.Server.EntityModel.PBBPackage
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x0005F508 File Offset: 0x0005D708
		public PBBProvisioning()
		{
			this.Codeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug>();
			this.PBBCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug>();
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0005F534 File Offset: 0x0005D734
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)169037068;
				short num2 = num;
				num = (short)1310608652;
				switch (num2 == num)
				{
				}
				num = (short)1291321344;
				short num3 = num;
				num = (short)664010753;
				if (num != 0)
				{
				}
				num = (short)714211328;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1434524965;
				short num2 = num;
				num = (short)1541152037;
				switch (num2 == num)
				{
				}
				num = (short)1464598528;
				short num3 = num;
				num = (short)731185153;
				if (num != 0)
				{
				}
				num = (short)1318584320;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0005F698 File Offset: 0x0005D898
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x0005F748 File Offset: 0x0005D948
		[global::System.Runtime.Serialization.DataMember]
		public string PackageDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)959553437;
				short num2 = num;
				num = (short)1454415773;
				switch (num2 == num)
				{
				}
				num = (short)456327168;
				short num3 = num;
				num = (short)1505820672;
				if (num != 0)
				{
				}
				num = (short)71172097;
				if (num != 0)
				{
				}
				return this.<PackageDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1802588595;
				short num2 = num;
				num = (short)673730995;
				switch (num2 == num)
				{
				}
				num = (short)1765998592;
				short num3 = num;
				num = (short)1962934272;
				if (num != 0)
				{
				}
				num = (short)2131951617;
				if (num != 0)
				{
				}
				this.<PackageDescription>k__BackingField = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0005F7F8 File Offset: 0x0005D9F8
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0005F8A8 File Offset: 0x0005DAA8
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1678444497;
				short num2 = num;
				num = (short)2034829265;
				switch (num2 == num)
				{
				}
				num = (short)346816512;
				short num3 = num;
				num = (short)1068826624;
				if (num != 0)
				{
				}
				num = (short)1147600897;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)12315917;
				short num2 = num;
				num = (short)1526459661;
				switch (num2 == num)
				{
				}
				num = (short)840499200;
				short num3 = num;
				num = (short)1786904577;
				if (num != 0)
				{
				}
				num = (short)1435369472;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0005F954 File Offset: 0x0005DB54
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0005FA04 File Offset: 0x0005DC04
		[global::System.Runtime.Serialization.DataMember]
		public string ManifestRoot
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)255131649;
				if (num != 0)
				{
				}
				num = (short)1583116175;
				short num2 = num;
				num = (short)1448439695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259077632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1407385600;
				if (num != 0)
				{
				}
				return this.<ManifestRoot>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)438539410;
				short num2 = num;
				num = (short)1649054866;
				switch (num2 == num)
				{
				}
				num = (short)1332936704;
				short num3 = num;
				num = (short)1918697473;
				if (num != 0)
				{
				}
				num = (short)1550581760;
				if (num != 0)
				{
				}
				this.<ManifestRoot>k__BackingField = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0005FAB8 File Offset: 0x0005DCB8
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0005FB68 File Offset: 0x0005DD68
		[global::System.Runtime.Serialization.DataMember]
		public string ManifestVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)150406792;
				short num2 = num;
				num = (short)642516616;
				switch (num2 == num)
				{
				}
				num = (short)831520768;
				short num3 = num;
				num = (short)1340342273;
				if (num != 0)
				{
				}
				num = (short)1813053440;
				if (num != 0)
				{
				}
				return this.<ManifestVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2032458231;
				short num2 = num;
				num = (short)1216797175;
				switch (num2 == num)
				{
				}
				num = (short)1376780288;
				short num3 = num;
				num = (short)1948254209;
				if (num != 0)
				{
				}
				num = (short)404488192;
				if (num != 0)
				{
				}
				this.<ManifestVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0005FC18 File Offset: 0x0005DE18
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x0005FCC8 File Offset: 0x0005DEC8
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsContainStage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1216086017;
				if (num != 0)
				{
				}
				num = (short)315778321;
				short num2 = num;
				num = (short)578250001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875968000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286275072;
				if (num != 0)
				{
				}
				return this.<IsContainStage>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1956128720;
				short num2 = num;
				num = (short)419047376;
				switch (num2 == num)
				{
				}
				num = (short)511508480;
				short num3 = num;
				num = (short)1503592449;
				if (num != 0)
				{
				}
				num = (short)2040987648;
				if (num != 0)
				{
				}
				this.<IsContainStage>k__BackingField = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0005FD78 File Offset: 0x0005DF78
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x0005FE24 File Offset: 0x0005E024
		[global::System.Runtime.Serialization.DataMember]
		public int? RebootCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1428815873;
				if (num != 0)
				{
				}
				num = (short)1161841065;
				short num2 = num;
				num = (short)1082935721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1179779072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1828192256;
				if (num != 0)
				{
				}
				return this.<RebootCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)797533591;
				short num2 = num;
				num = (short)148333975;
				switch (num2 == num)
				{
				}
				num = (short)903151616;
				short num3 = num;
				num = (short)725090305;
				if (num != 0)
				{
				}
				num = (short)1628372992;
				if (num != 0)
				{
				}
				this.<RebootCount>k__BackingField = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0005FED4 File Offset: 0x0005E0D4
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x0005FF84 File Offset: 0x0005E184
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1431254157;
				short num2 = num;
				num = (short)92157069;
				switch (num2 == num)
				{
				}
				num = (short)636878848;
				short num3 = num;
				num = (short)1520893953;
				if (num != 0)
				{
				}
				num = (short)904724480;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)83165185;
				if (num != 0)
				{
				}
				num = (short)852939395;
				short num2 = num;
				num = (short)1515639427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683750912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749207552;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00060034 File Offset: 0x0005E234
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x000600E4 File Offset: 0x0005E2E4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Codeplug> Codeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1610292431;
				short num2 = num;
				num = (short)1526930639;
				switch (num2 == num)
				{
				}
				num = (short)211025920;
				short num3 = num;
				num = (short)850329601;
				if (num != 0)
				{
				}
				num = (short)2114256896;
				if (num != 0)
				{
				}
				return this.<Codeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)23265281;
				if (num != 0)
				{
				}
				num = (short)1932421224;
				short num2 = num;
				num = (short)1377790056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097793536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756102656;
				if (num != 0)
				{
				}
				this.<Codeplugs>k__BackingField = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00060194 File Offset: 0x0005E394
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00060240 File Offset: 0x0005E440
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug> PBBCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1036528576;
				short num2 = num;
				num = (short)240528320;
				switch (num2 == num)
				{
				}
				num = (short)246153216;
				short num3 = num;
				num = (short)1326448641;
				if (num != 0)
				{
				}
				num = (short)1117716480;
				if (num != 0)
				{
				}
				return this.<PBBCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1209657613;
				short num2 = num;
				num = (short)893446413;
				switch (num2 == num)
				{
				}
				num = (short)489291776;
				short num3 = num;
				num = (short)1660157953;
				if (num != 0)
				{
				}
				num = (short)36241408;
				if (num != 0)
				{
				}
				this.<PBBCodeplugs>k__BackingField = value;
			}
		}
	}
}
