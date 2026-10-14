using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000115 RID: 277
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportAPXRadioFromCSVRequest : global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000AB940 File Offset: 0x000A9B40
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x000AB9EC File Offset: 0x000A9BEC
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string ForeignIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2146676941;
				short num2 = num;
				num = (short)1885384909;
				switch (num2 == num)
				{
				}
				num = (short)1237843969;
				if (num != 0)
				{
				}
				num = (short)1175322624;
				short num3 = num;
				num = (short)1768292352;
				if (num != 0)
				{
				}
				return this.<ForeignIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1753152113;
				short num2 = num;
				num = (short)1149106801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)163053568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2091974657;
				if (num != 0)
				{
				}
				num = (short)1763311616;
				if (num != 0)
				{
				}
				this.<ForeignIP>k__BackingField = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x000ABB50 File Offset: 0x000A9D50
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string BluetoothDUNSubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)659249181;
				short num2 = num;
				num = (short)1559123997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788018688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109210624;
				if (num != 0)
				{
				}
				num = (short)142278657;
				if (num != 0)
				{
				}
				return this.<BluetoothDUNSubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1663436326;
				short num2 = num;
				num = (short)2033780262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966931968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851705857;
				if (num != 0)
				{
				}
				num = (short)1521221632;
				if (num != 0)
				{
				}
				this.<BluetoothDUNSubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000ABC04 File Offset: 0x000A9E04
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x000ABCB0 File Offset: 0x000A9EB0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string BluetoothDUNPeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1748464459;
				short num2 = num;
				num = (short)1139110731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602355200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				num = (short)376307712;
				if (num != 0)
				{
				}
				return this.<BluetoothDUNPeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2027649665;
				short num2 = num;
				num = (short)1818524289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026686976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147797505;
				if (num != 0)
				{
				}
				num = (short)994508800;
				if (num != 0)
				{
				}
				this.<BluetoothDUNPeerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x000ABD60 File Offset: 0x000A9F60
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x000ABE10 File Offset: 0x000AA010
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothFriendlyName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)914030593;
				if (num != 0)
				{
				}
				num = (short)772931584;
				short num2 = num;
				num = (short)127511242;
				short num3 = num;
				num = (short)1713810122;
				switch (num3 == num)
				{
				}
				num = (short)878247936;
				if (num != 0)
				{
				}
				return this.<BluetoothFriendlyName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2074820490;
				short num2 = num;
				num = (short)325205898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469499904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89194496;
				if (num != 0)
				{
				}
				num = (short)1633419265;
				if (num != 0)
				{
				}
				this.<BluetoothFriendlyName>k__BackingField = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000ABEC0 File Offset: 0x000AA0C0
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x000ABF70 File Offset: 0x000AA170
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public int? OtarID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)971214782;
				short num2 = num;
				num = (short)808423358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947716096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959133185;
				if (num != 0)
				{
				}
				num = (short)746586112;
				if (num != 0)
				{
				}
				return this.<OtarID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1765801985;
				if (num != 0)
				{
				}
				num = (short)2016280576;
				short num2 = num;
				num = (short)1391263734;
				short num3 = num;
				num = (short)1430650870;
				switch (num3 == num)
				{
				}
				num = (short)213647360;
				if (num != 0)
				{
				}
				this.<OtarID>k__BackingField = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000AC024 File Offset: 0x000AA224
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x000AC0D4 File Offset: 0x000AA2D4
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public string PeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1671753462;
				short num2 = num;
				num = (short)693169910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1760952320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717501953;
				if (num != 0)
				{
				}
				num = (short)1249050624;
				if (num != 0)
				{
				}
				return this.<PeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1893203969;
				if (num != 0)
				{
				}
				num = (short)2014838784;
				short num2 = num;
				num = (short)1313617753;
				short num3 = num;
				num = (short)2054633305;
				switch (num3 == num)
				{
				}
				num = (short)1419771904;
				if (num != 0)
				{
				}
				this.<PeerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000AC188 File Offset: 0x000AA388
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x000AC238 File Offset: 0x000AA438
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string SubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)44498945;
				if (num != 0)
				{
				}
				num = (short)1997668352;
				short num2 = num;
				num = (short)1108218533;
				short num3 = num;
				num = (short)1113395877;
				switch (num3 == num)
				{
				}
				num = (short)2113470464;
				if (num != 0)
				{
				}
				return this.<SubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1080830589;
				short num2 = num;
				num = (short)2143365757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)826146816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624244224;
				if (num != 0)
				{
				}
				num = (short)152567809;
				if (num != 0)
				{
				}
				this.<SubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000AC2E8 File Offset: 0x000AA4E8
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x000AC39C File Offset: 0x000AA59C
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public string UserLoginUnitID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)118374693;
				short num2 = num;
				num = (short)2146582821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567293440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750204416;
				if (num != 0)
				{
				}
				num = (short)1072037889;
				if (num != 0)
				{
				}
				return this.<UserLoginUnitID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1440337384;
				short num2 = num;
				num = (short)410439144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286209536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361299969;
				if (num != 0)
				{
				}
				num = (short)1138491392;
				if (num != 0)
				{
				}
				this.<UserLoginUnitID>k__BackingField = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x000AC44C File Offset: 0x000AA64C
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x000AC4FC File Offset: 0x000AA6FC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string UserName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)285092258;
				short num2 = num;
				num = (short)981281186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217396736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089353216;
				if (num != 0)
				{
				}
				num = (short)1737031681;
				if (num != 0)
				{
				}
				return this.<UserName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1970887494;
				short num2 = num;
				num = (short)1121606470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977876480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)402128896;
				if (num != 0)
				{
				}
				num = (short)1920204801;
				if (num != 0)
				{
				}
				this.<UserName>k__BackingField = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x000AC5AC File Offset: 0x000AA7AC
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x000AC658 File Offset: 0x000AA858
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		public string ReadPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)423165953;
				if (num != 0)
				{
				}
				num = (short)1588461568;
				short num2 = num;
				num = (short)185476987;
				short num3 = num;
				num = (short)9512827;
				switch (num3 == num)
				{
				}
				num = (short)2006188032;
				if (num != 0)
				{
				}
				return this.<ReadPassword>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2097977556;
				short num2 = num;
				num = (short)295213268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484062720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1111818240;
				if (num != 0)
				{
				}
				num = (short)339476481;
				if (num != 0)
				{
				}
				this.<ReadPassword>k__BackingField = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000AC70C File Offset: 0x000AA90C
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x000AC7BC File Offset: 0x000AA9BC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public string CodeplugPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)235339777;
				if (num != 0)
				{
				}
				num = (short)815464448;
				short num2 = num;
				num = (short)882517320;
				short num3 = num;
				num = (short)1111434568;
				switch (num3 == num)
				{
				}
				num = (short)1996947456;
				if (num != 0)
				{
				}
				return this.<CodeplugPassword>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)599916545;
				if (num != 0)
				{
				}
				num = (short)922615808;
				short num2 = num;
				num = (short)1887747171;
				short num3 = num;
				num = (short)89373795;
				switch (num3 == num)
				{
				}
				num = (short)1962213376;
				if (num != 0)
				{
				}
				this.<CodeplugPassword>k__BackingField = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x000AC86C File Offset: 0x000AAA6C
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x000AC91C File Offset: 0x000AAB1C
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public bool PasswordPerDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)247580382;
				short num2 = num;
				num = (short)63817438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666632192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				num = (short)1928331264;
				if (num != 0)
				{
				}
				return this.<PasswordPerDevice>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1775964682;
				short num2 = num;
				num = (short)1543377418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291962880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923416065;
				if (num != 0)
				{
				}
				num = (short)1530986496;
				if (num != 0)
				{
				}
				this.<PasswordPerDevice>k__BackingField = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x000AC9CC File Offset: 0x000AABCC
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x000ACA7C File Offset: 0x000AAC7C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		public int PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1043791873;
				if (num != 0)
				{
				}
				num = (short)56164352;
				short num2 = num;
				num = (short)310517569;
				short num3 = num;
				num = (short)40443713;
				switch (num3 == num)
				{
				}
				num = (short)2061697024;
				if (num != 0)
				{
				}
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1893177665;
				short num2 = num;
				num = (short)2015074625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133038080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)587333633;
				if (num != 0)
				{
				}
				num = (short)719847424;
				if (num != 0)
				{
				}
				this.<PasswordPolicy>k__BackingField = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000ACB2C File Offset: 0x000AAD2C
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x000ACBE0 File Offset: 0x000AADE0
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Codeplug)]
		[global::System.Runtime.Serialization.DataMember]
		public int? VRID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)938010351;
				short num2 = num;
				num = (short)2023483119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912274944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234094593;
				if (num != 0)
				{
				}
				num = (short)49479680;
				if (num != 0)
				{
				}
				return this.<VRID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1464730890;
				short num2 = num;
				num = (short)1888158986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033109504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629093888;
				if (num != 0)
				{
				}
				num = (short)651755521;
				if (num != 0)
				{
				}
				this.<VRID>k__BackingField = value;
			}
		}
	}
}
