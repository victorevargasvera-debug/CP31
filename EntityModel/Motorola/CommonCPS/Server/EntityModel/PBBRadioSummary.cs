using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000076 RID: 118
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBRadioSummary : global::Motorola.CommonCPS.Server.EntityModel.RadioSummary
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00060728 File Offset: 0x0005E928
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000607DC File Offset: 0x0005E9DC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("IMEI", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)951978263;
				short num2 = num;
				num = (short)635046167;
				switch (num2 == num)
				{
				}
				num = (short)1640890368;
				if (num != 0)
				{
				}
				num = (short)1236467713;
				if (num != 0)
				{
				}
				num = (short)978255872;
				short num3 = num;
				return this.<IMEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2049332440;
				short num2 = num;
				num = (short)298734808;
				switch (num2 == num)
				{
				}
				num = (short)1188691969;
				if (num != 0)
				{
				}
				num = (short)258146304;
				if (num != 0)
				{
				}
				num = (short)1631649792;
				short num3 = num;
				this.<IMEI>k__BackingField = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00060890 File Offset: 0x0005EA90
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00060940 File Offset: 0x0005EB40
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ProductIdentifier", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1327228931;
				short num2 = num;
				num = (short)1132193795;
				switch (num2 == num)
				{
				}
				num = (short)597032960;
				if (num != 0)
				{
				}
				num = (short)310706177;
				if (num != 0)
				{
				}
				num = (short)1514602496;
				short num3 = num;
				return this.<ProductIdentifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)623634374;
				short num2 = num;
				num = (short)1459873734;
				switch (num2 == num)
				{
				}
				num = (short)942080001;
				if (num != 0)
				{
				}
				num = (short)1559166976;
				if (num != 0)
				{
				}
				num = (short)1659568128;
				short num3 = num;
				this.<ProductIdentifier>k__BackingField = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000609F4 File Offset: 0x0005EBF4
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00060AA4 File Offset: 0x0005ECA4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ManufacturerName", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
		public string ManufacturerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1431437313;
				if (num != 0)
				{
				}
				num = (short)1262954676;
				short num2 = num;
				num = (short)2050697396;
				switch (num2 == num)
				{
				}
				num = (short)2044723200;
				if (num != 0)
				{
				}
				num = (short)895811584;
				short num3 = num;
				return this.<ManufacturerName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)170879025;
				short num2 = num;
				num = (short)1571383345;
				switch (num2 == num)
				{
				}
				num = (short)374145025;
				if (num != 0)
				{
				}
				num = (short)1211039744;
				if (num != 0)
				{
				}
				num = (short)1689911296;
				short num3 = num;
				this.<ManufacturerName>k__BackingField = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00060B54 File Offset: 0x0005ED54
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00060C04 File Offset: 0x0005EE04
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PBBFirmwareUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PBBFirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1264319727;
				short num2 = num;
				num = (short)816119023;
				switch (num2 == num)
				{
				}
				num = (short)259915776;
				if (num != 0)
				{
				}
				num = (short)1882587137;
				if (num != 0)
				{
				}
				num = (short)1552416768;
				short num3 = num;
				return this.<PBBFirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)180611690;
				short num2 = num;
				num = (short)2117200490;
				switch (num2 == num)
				{
				}
				num = (short)253296641;
				if (num != 0)
				{
				}
				num = (short)1376714752;
				if (num != 0)
				{
				}
				num = (short)604962816;
				short num3 = num;
				this.<PBBFirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00060CB8 File Offset: 0x0005EEB8
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00060D68 File Offset: 0x0005EF68
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PBBFirmwareVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string PBBFirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)78090985;
				short num2 = num;
				num = (short)239440617;
				switch (num2 == num)
				{
				}
				num = (short)548274177;
				if (num != 0)
				{
				}
				num = (short)2129461248;
				if (num != 0)
				{
				}
				num = (short)493027328;
				short num3 = num;
				return this.<PBBFirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1609843006;
				short num2 = num;
				num = (short)1284522302;
				switch (num2 == num)
				{
				}
				num = (short)1595408385;
				if (num != 0)
				{
				}
				num = (short)1101594624;
				if (num != 0)
				{
				}
				num = (short)891027456;
				short num3 = num;
				this.<PBBFirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00060E18 File Offset: 0x0005F018
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PBBHomeSetUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public global::System.Guid? PBBHomeSetUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)110455507;
				short num2 = num;
				num = (short)395274963;
				switch (num2 == num)
				{
				}
				num = (short)1303183360;
				if (num != 0)
				{
				}
				num = (short)1238171649;
				if (num != 0)
				{
				}
				num = (short)1593180160;
				short num3 = num;
				return this.<PBBHomeSetUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1945475020;
				short num2 = num;
				num = (short)237606860;
				switch (num2 == num)
				{
				}
				num = (short)934674433;
				if (num != 0)
				{
				}
				num = (short)1075773440;
				if (num != 0)
				{
				}
				num = (short)911671296;
				short num3 = num;
				this.<PBBHomeSetUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00060F78 File Offset: 0x0005F178
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00061028 File Offset: 0x0005F228
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PackageName", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBHomeSet))]
		public string HomeSetPackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1412052669;
				short num2 = num;
				num = (short)620967613;
				switch (num2 == num)
				{
				}
				num = (short)933625856;
				if (num != 0)
				{
				}
				num = (short)1488060417;
				if (num != 0)
				{
				}
				num = (short)1330708480;
				short num3 = num;
				return this.<HomeSetPackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1975465243;
				short num2 = num;
				num = (short)564868379;
				switch (num2 == num)
				{
				}
				num = (short)191561729;
				if (num != 0)
				{
				}
				num = (short)2054356992;
				if (num != 0)
				{
				}
				num = (short)2122055680;
				short num3 = num;
				this.<HomeSetPackageName>k__BackingField = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000610DC File Offset: 0x0005F2DC
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0006118C File Offset: 0x0005F38C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("IsStaged", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public bool? IsStaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)647364609;
				if (num != 0)
				{
				}
				num = (short)869814365;
				short num2 = num;
				num = (short)286675037;
				switch (num2 == num)
				{
				}
				num = (short)1267204096;
				if (num != 0)
				{
				}
				num = (short)1695023104;
				short num3 = num;
				return this.<IsStaged>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1773706765;
				short num2 = num;
				num = (short)1779015181;
				switch (num2 == num)
				{
				}
				num = (short)1420099585;
				if (num != 0)
				{
				}
				num = (short)95354880;
				if (num != 0)
				{
				}
				num = (short)1366360064;
				short num3 = num;
				this.<IsStaged>k__BackingField = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0006123C File Offset: 0x0005F43C
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000612F0 File Offset: 0x0005F4F0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AppCFS", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string AppCFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734368054;
				short num2 = num;
				num = (short)2081577782;
				switch (num2 == num)
				{
				}
				num = (short)1959329793;
				if (num != 0)
				{
				}
				num = (short)759693312;
				if (num != 0)
				{
				}
				num = (short)1389035520;
				short num3 = num;
				return this.<AppCFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)626917559;
				short num2 = num;
				num = (short)1034944695;
				switch (num2 == num)
				{
				}
				num = (short)775159809;
				if (num != 0)
				{
				}
				num = (short)1013317632;
				if (num != 0)
				{
				}
				num = (short)975437824;
				short num3 = num;
				this.<AppCFS>k__BackingField = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x000613A0 File Offset: 0x0005F5A0
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00061450 File Offset: 0x0005F650
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AppCFSEncrypt", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public string AppCFSEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1790164761;
				short num2 = num;
				num = (short)365543193;
				switch (num2 == num)
				{
				}
				num = (short)246349825;
				if (num != 0)
				{
				}
				num = (short)1519845376;
				if (num != 0)
				{
				}
				num = (short)259063808;
				short num3 = num;
				return this.<AppCFSEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)886445804;
				short num2 = num;
				num = (short)203822828;
				switch (num2 == num)
				{
				}
				num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)1918763008;
				if (num != 0)
				{
				}
				num = (short)1042612224;
				short num3 = num;
				this.<AppCFSEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00061500 File Offset: 0x0005F700
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x000615B4 File Offset: 0x0005F7B4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AppSetting", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string AppSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)833523642;
				short num2 = num;
				num = (short)255168442;
				switch (num2 == num)
				{
				}
				num = (short)2023227392;
				short num3 = num;
				num = (short)1344798720;
				if (num != 0)
				{
				}
				num = (short)1365508097;
				if (num != 0)
				{
				}
				return this.<AppSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1387121213;
				short num2 = num;
				num = (short)422824509;
				switch (num2 == num)
				{
				}
				num = (short)1743192064;
				short num3 = num;
				num = (short)222232577;
				if (num != 0)
				{
				}
				num = (short)1161035776;
				if (num != 0)
				{
				}
				this.<AppSetting>k__BackingField = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00061664 File Offset: 0x0005F864
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00061714 File Offset: 0x0005F914
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CertificateSetting", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public string CertificateSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1475149825;
				if (num != 0)
				{
				}
				num = (short)151120044;
				short num2 = num;
				num = (short)823519404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)427753472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112290816;
				if (num != 0)
				{
				}
				return this.<CertificateSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)68025406;
				short num2 = num;
				num = (short)502922302;
				switch (num2 == num)
				{
				}
				num = (short)2045313024;
				short num3 = num;
				num = (short)1520107521;
				if (num != 0)
				{
				}
				num = (short)1610416128;
				if (num != 0)
				{
				}
				this.<CertificateSetting>k__BackingField = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000617C4 File Offset: 0x0005F9C4
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00061870 File Offset: 0x0005FA70
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("MCIFProfileName", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public string MCIFProfileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1654341751;
				short num2 = num;
				num = (short)1099972727;
				switch (num2 == num)
				{
				}
				num = (short)883490816;
				short num3 = num;
				num = (short)1079443456;
				if (num != 0)
				{
				}
				num = (short)1627127809;
				if (num != 0)
				{
				}
				return this.<MCIFProfileName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)21604378;
				short num2 = num;
				num = (short)276080666;
				switch (num2 == num)
				{
				}
				num = (short)298647552;
				short num3 = num;
				num = (short)1391656960;
				if (num != 0)
				{
				}
				num = (short)1085734913;
				if (num != 0)
				{
				}
				this.<MCIFProfileName>k__BackingField = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00061920 File Offset: 0x0005FB20
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000619D0 File Offset: 0x0005FBD0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("MCIFVersion", typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug))]
		public string MCIFVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)965053626;
				short num2 = num;
				num = (short)402885818;
				switch (num2 == num)
				{
				}
				num = (short)969474048;
				short num3 = num;
				num = (short)1368850433;
				if (num != 0)
				{
				}
				num = (short)275906560;
				if (num != 0)
				{
				}
				return this.<MCIFVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)301980903;
				short num2 = num;
				num = (short)1847778535;
				switch (num2 == num)
				{
				}
				num = (short)1495203840;
				short num3 = num;
				num = (short)631570433;
				if (num != 0)
				{
				}
				num = (short)548601856;
				if (num != 0)
				{
				}
				this.<MCIFVersion>k__BackingField = value;
			}
		}
	}
}
