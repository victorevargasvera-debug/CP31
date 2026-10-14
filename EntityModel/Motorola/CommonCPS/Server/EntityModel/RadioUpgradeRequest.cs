using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200016C RID: 364
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRRadioUpgradeRequest))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadioUpgradeRequest))]
	[global::System.Serializable]
	public abstract class RadioUpgradeRequest
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000D3938 File Offset: 0x000D1B38
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x000D39E8 File Offset: 0x000D1BE8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)539887925;
				short num2 = num;
				num = (short)1802307893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169555456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925906433;
				if (num != 0)
				{
				}
				num = (short)522715136;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2022256146;
				short num2 = num;
				num = (short)1131425298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046806528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018902016;
				if (num != 0)
				{
				}
				num = (short)631046145;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x000D3A9C File Offset: 0x000D1C9C
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x000D3B4C File Offset: 0x000D1D4C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)193458292;
				short num2 = num;
				num = (short)141619316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602669056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963851777;
				if (num != 0)
				{
				}
				num = (short)1241382912;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1755741358;
				short num2 = num;
				num = (short)564624558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)78381056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296695297;
				if (num != 0)
				{
				}
				num = (short)1637154816;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000D3C00 File Offset: 0x000D1E00
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x000D3CB4 File Offset: 0x000D1EB4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FWUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1719771782;
				short num2 = num;
				num = (short)320774790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689714688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004549632;
				if (num != 0)
				{
				}
				num = (short)110166017;
				if (num != 0)
				{
				}
				return this.<FWUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)617835367;
				short num2 = num;
				num = (short)1635543911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862270976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451215360;
				if (num != 0)
				{
				}
				num = (short)319160321;
				if (num != 0)
				{
				}
				this.<FWUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x000D3D68 File Offset: 0x000D1F68
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x000D3E1C File Offset: 0x000D201C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1236882450;
				short num2 = num;
				num = (short)1307202578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197080576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1661861889;
				if (num != 0)
				{
				}
				num = (short)1905917952;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)176477944;
				short num2 = num;
				num = (short)283498232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248053760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71565312;
				if (num != 0)
				{
				}
				num = (short)618135553;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000D3ECC File Offset: 0x000D20CC
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x000D3F7C File Offset: 0x000D217C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> Features
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1939919359;
				short num2 = num;
				num = (short)1892864511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1191510016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227147777;
				if (num != 0)
				{
				}
				num = (short)2095513600;
				if (num != 0)
				{
				}
				return this.<Features>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)482933087;
				short num2 = num;
				num = (short)1042151775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436483584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631780864;
				if (num != 0)
				{
				}
				num = (short)1464598529;
				if (num != 0)
				{
				}
				this.<Features>k__BackingField = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000D4030 File Offset: 0x000D2230
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x000D40E0 File Offset: 0x000D22E0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom? LicenseFrom
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)376832001;
				if (num != 0)
				{
				}
				num = (short)238944256;
				short num2 = num;
				num = (short)1836343003;
				short num3 = num;
				num = (short)1781685979;
				switch (num3 == num)
				{
				}
				num = (short)2040856576;
				if (num != 0)
				{
				}
				return this.<LicenseFrom>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1337012190;
				short num2 = num;
				num = (short)1798909918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1542520832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)408551425;
				if (num != 0)
				{
				}
				num = (short)1083703296;
				if (num != 0)
				{
				}
				this.<LicenseFrom>k__BackingField = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000D4190 File Offset: 0x000D2390
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x000D4240 File Offset: 0x000D2440
		[global::System.Runtime.Serialization.DataMember]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1338966017;
				if (num != 0)
				{
				}
				num = (short)1095237632;
				short num2 = num;
				num = (short)2045282759;
				short num3 = num;
				num = (short)2018871751;
				switch (num3 == num)
				{
				}
				num = (short)1230766080;
				if (num != 0)
				{
				}
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1821114369;
				if (num != 0)
				{
				}
				num = (short)425066496;
				short num2 = num;
				num = (short)1914921190;
				short num3 = num;
				num = (short)1185571046;
				switch (num3 == num)
				{
				}
				num = (short)1587871744;
				if (num != 0)
				{
				}
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000D42F0 File Offset: 0x000D24F0
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x000D43A0 File Offset: 0x000D25A0
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)82928299;
				short num2 = num;
				num = (short)541024939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581252608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261043712;
				if (num != 0)
				{
				}
				num = (short)600375297;
				if (num != 0)
				{
				}
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)825301616;
				short num2 = num;
				num = (short)28449392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244973568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1275854849;
				if (num != 0)
				{
				}
				num = (short)1747255296;
				if (num != 0)
				{
				}
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000D4450 File Offset: 0x000D2650
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x000D44FC File Offset: 0x000D26FC
		[global::System.Runtime.Serialization.DataMember]
		public string BBFBundleVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1089165615;
				short num2 = num;
				num = (short)1877760303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683292160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1524498433;
				if (num != 0)
				{
				}
				num = (short)2062614528;
				if (num != 0)
				{
				}
				return this.<BBFBundleVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)621852785;
				short num2 = num;
				num = (short)1689434225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965869568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385744897;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				if (num != 0)
				{
				}
				this.<BBFBundleVersion>k__BackingField = value;
			}
		}
	}
}
