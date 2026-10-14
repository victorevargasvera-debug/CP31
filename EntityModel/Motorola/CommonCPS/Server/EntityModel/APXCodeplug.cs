using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.DefineAttributes;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXCodeplug : global::Motorola.CommonCPS.Server.EntityModel.Codeplug
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000F46C File Offset: 0x0000D66C
		public APXCodeplug()
		{
			this.APXDataProfiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
			this.APXRadioSystems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
			this.ASTROVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>();
			this.ASTROTTSVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROTTSVoiceAnnouncement>();
			this.ASTROCACertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>();
			this.ASTRODVRSFiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>();
			this.APXOtarProfiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
			base.CodeplugPassword = string.Empty;
			this.PasswordPolicy = global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
			base.PasswordPerDevice = false;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000F598 File Offset: 0x0000D798
		[global::System.Runtime.Serialization.DataMember]
		public bool? AskRequired
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1016989088;
				short num2 = num;
				num = (short)853018016;
				switch (num2 == num)
				{
				}
				num = (short)1916665856;
				short num3 = num;
				num = (short)1451229185;
				if (num != 0)
				{
				}
				num = (short)157024256;
				if (num != 0)
				{
				}
				return this.<AskRequired>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)447827200;
				short num2 = num;
				num = (short)1758743808;
				switch (num2 == num)
				{
				}
				num = (short)940376064;
				short num3 = num;
				num = (short)386138112;
				if (num != 0)
				{
				}
				num = (short)1016463361;
				if (num != 0)
				{
				}
				this.<AskRequired>k__BackingField = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000F648 File Offset: 0x0000D848
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		[global::System.Runtime.Serialization.DataMember]
		public string AskRequiredEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)450015065;
				short num2 = num;
				num = (short)589082457;
				switch (num2 == num)
				{
				}
				num = (short)1526071296;
				short num3 = num;
				num = (short)314834945;
				if (num != 0)
				{
				}
				num = (short)1103953920;
				if (num != 0)
				{
				}
				return this.<AskRequiredEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1890023448;
				short num2 = num;
				num = (short)82475032;
				switch (num2 == num)
				{
				}
				num = (short)2053767168;
				short num3 = num;
				num = (short)214368257;
				if (num != 0)
				{
				}
				num = (short)1109065728;
				if (num != 0)
				{
				}
				this.<AskRequiredEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000F858 File Offset: 0x0000DA58
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothDUNSubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1483734403;
				short num2 = num;
				num = (short)577633667;
				switch (num2 == num)
				{
				}
				num = (short)1128792064;
				short num3 = num;
				num = (short)764346369;
				if (num != 0)
				{
				}
				num = (short)483393536;
				if (num != 0)
				{
				}
				return this.<BluetoothDUNSubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1309010374;
				short num2 = num;
				num = (short)575531462;
				switch (num2 == num)
				{
				}
				num = (short)2003238912;
				short num3 = num;
				num = (short)38010881;
				if (num != 0)
				{
				}
				num = (short)1073807360;
				if (num != 0)
				{
				}
				this.<BluetoothDUNSubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000F908 File Offset: 0x0000DB08
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothDUNPeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)819633180;
				short num2 = num;
				num = (short)1472240668;
				switch (num2 == num)
				{
				}
				num = (short)153616384;
				short num3 = num;
				num = (short)1968766977;
				if (num != 0)
				{
				}
				num = (short)164888576;
				if (num != 0)
				{
				}
				return this.<BluetoothDUNPeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)938597907;
				short num2 = num;
				num = (short)1370021395;
				switch (num2 == num)
				{
				}
				num = (short)929628160;
				short num3 = num;
				num = (short)1589182464;
				if (num != 0)
				{
				}
				num = (short)1117716481;
				if (num != 0)
				{
				}
				this.<BluetoothDUNPeerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000FA68 File Offset: 0x0000DC68
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000FB18 File Offset: 0x0000DD18
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothFriendlyName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)433049769;
				short num2 = num;
				num = (short)976015529;
				switch (num2 == num)
				{
				}
				num = (short)1310523392;
				short num3 = num;
				num = (short)376504321;
				if (num != 0)
				{
				}
				num = (short)618659840;
				if (num != 0)
				{
				}
				return this.<BluetoothFriendlyName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1960154884;
				short num2 = num;
				num = (short)1033475844;
				switch (num2 == num)
				{
				}
				num = (short)921960448;
				short num3 = num;
				num = (short)396165120;
				if (num != 0)
				{
				}
				num = (short)2047541249;
				if (num != 0)
				{
				}
				this.<BluetoothFriendlyName>k__BackingField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		[global::System.Runtime.Serialization.DataMember]
		public int? OtarID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)27948392;
				short num2 = num;
				num = (short)883520872;
				switch (num2 == num)
				{
				}
				num = (short)26476544;
				short num3 = num;
				num = (short)307822593;
				if (num != 0)
				{
				}
				num = (short)1981415424;
				if (num != 0)
				{
				}
				return this.<OtarID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2029467385;
				short num2 = num;
				num = (short)1936406265;
				switch (num2 == num)
				{
				}
				num = (short)1245380608;
				short num3 = num;
				num = (short)1419706368;
				if (num != 0)
				{
				}
				num = (short)156762113;
				if (num != 0)
				{
				}
				this.<OtarID>k__BackingField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		[global::System.Runtime.Serialization.DataMember]
		public string PeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1973677974;
				short num2 = num;
				num = (short)1464135574;
				switch (num2 == num)
				{
				}
				num = (short)49807360;
				short num3 = num;
				num = (short)2128150529;
				if (num != 0)
				{
				}
				num = (short)305135616;
				if (num != 0)
				{
				}
				return this.<PeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)940203344;
				short num2 = num;
				num = (short)796745040;
				switch (num2 == num)
				{
				}
				num = (short)1368195072;
				short num3 = num;
				num = (short)1972633601;
				if (num != 0)
				{
				}
				num = (short)105185280;
				if (num != 0)
				{
				}
				this.<PeerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000FE88 File Offset: 0x0000E088
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000FF38 File Offset: 0x0000E138
		[global::System.Runtime.Serialization.DataMember]
		public string PeerIP_A41818
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)931374999;
				short num2 = num;
				num = (short)2136844183;
				switch (num2 == num)
				{
				}
				num = (short)1107623936;
				short num3 = num;
				num = (short)425263104;
				if (num != 0)
				{
				}
				num = (short)874512385;
				if (num != 0)
				{
				}
				return this.<PeerIP_A41818>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)560388267;
				short num2 = num;
				num = (short)438491307;
				switch (num2 == num)
				{
				}
				num = (short)348258304;
				short num3 = num;
				num = (short)1670316032;
				if (num != 0)
				{
				}
				num = (short)1205731329;
				if (num != 0)
				{
				}
				this.<PeerIP_A41818>k__BackingField = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0001009C File Offset: 0x0000E29C
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)294646889;
				short num2 = num;
				num = (short)1806169193;
				switch (num2 == num)
				{
				}
				num = (short)644415488;
				short num3 = num;
				num = (short)1180172289;
				if (num != 0)
				{
				}
				num = (short)1652752384;
				if (num != 0)
				{
				}
				return this.<SubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1984201344;
				short num2 = num;
				num = (short)1978630784;
				switch (num2 == num)
				{
				}
				num = (short)1761607680;
				short num3 = num;
				num = (short)1856962561;
				if (num != 0)
				{
				}
				num = (short)572915712;
				if (num != 0)
				{
				}
				this.<SubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0001014C File Offset: 0x0000E34C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000101FC File Offset: 0x0000E3FC
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriberIP_A41819
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)332112399;
				short num2 = num;
				num = (short)1579131407;
				switch (num2 == num)
				{
				}
				num = (short)1334706176;
				short num3 = num;
				num = (short)139460608;
				if (num != 0)
				{
				}
				num = (short)2017591297;
				if (num != 0)
				{
				}
				return this.<SubscriberIP_A41819>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1436549121;
				if (num != 0)
				{
				}
				num = (short)2124280846;
				short num2 = num;
				num = (short)1929638926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594018304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)613089280;
				if (num != 0)
				{
				}
				this.<SubscriberIP_A41819>k__BackingField = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000102AC File Offset: 0x0000E4AC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0001035C File Offset: 0x0000E55C
		[global::System.Runtime.Serialization.DataMember]
		public string UserLoginUnitID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737274152;
				short num2 = num;
				num = (short)508605224;
				switch (num2 == num)
				{
				}
				num = (short)2047868928;
				short num3 = num;
				num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)544079872;
				if (num != 0)
				{
				}
				return this.<UserLoginUnitID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1864100500;
				short num2 = num;
				num = (short)52030100;
				switch (num2 == num)
				{
				}
				num = (short)1087963136;
				short num3 = num;
				num = (short)1935147009;
				if (num != 0)
				{
				}
				num = (short)532021248;
				if (num != 0)
				{
				}
				this.<UserLoginUnitID>k__BackingField = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000104C0 File Offset: 0x0000E6C0
		[global::System.Runtime.Serialization.DataMember]
		public string UserName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1072765668;
				short num2 = num;
				num = (short)1402346212;
				switch (num2 == num)
				{
				}
				num = (short)459931648;
				short num3 = num;
				num = (short)162398209;
				if (num != 0)
				{
				}
				num = (short)880410624;
				if (num != 0)
				{
				}
				return this.<UserName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)993814463;
				short num2 = num;
				num = (short)531916735;
				switch (num2 == num)
				{
				}
				num = (short)778895360;
				short num3 = num;
				num = (short)185466881;
				if (num != 0)
				{
				}
				num = (short)1261961216;
				if (num != 0)
				{
				}
				this.<UserName>k__BackingField = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00010570 File Offset: 0x0000E770
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0001061C File Offset: 0x0000E81C
		[global::System.Runtime.Serialization.DataMember]
		public string UserPIN
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1026484512;
				short num2 = num;
				num = (short)1757604128;
				switch (num2 == num)
				{
				}
				num = (short)924385280;
				short num3 = num;
				num = (short)1845821441;
				if (num != 0)
				{
				}
				num = (short)643039232;
				if (num != 0)
				{
				}
				return this.<UserPIN>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)529417125;
				short num2 = num;
				num = (short)1294353317;
				switch (num2 == num)
				{
				}
				num = (short)326828032;
				short num3 = num;
				num = (short)2086862849;
				if (num != 0)
				{
				}
				num = (short)1879638016;
				if (num != 0)
				{
				}
				this.<UserPIN>k__BackingField = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000106CC File Offset: 0x0000E8CC
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0001077C File Offset: 0x0000E97C
		[global::System.Runtime.Serialization.DataMember]
		public string UserPINEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709927424;
				short num2 = num;
				num = (short)1008954368;
				switch (num2 == num)
				{
				}
				num = (short)1344536576;
				short num3 = num;
				num = (short)961019905;
				if (num != 0)
				{
				}
				num = (short)1432092672;
				if (num != 0)
				{
				}
				return this.<UserPINEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)498135816;
				short num2 = num;
				num = (short)126415624;
				switch (num2 == num)
				{
				}
				num = (short)1371930624;
				short num3 = num;
				num = (short)1808334848;
				if (num != 0)
				{
				}
				num = (short)1786576897;
				if (num != 0)
				{
				}
				this.<UserPINEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0001082C File Offset: 0x0000EA2C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000108DC File Offset: 0x0000EADC
		[global::System.Runtime.Serialization.DataMember]
		public bool? BluetoothEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)263728371;
				short num2 = num;
				num = (short)1711549683;
				switch (num2 == num)
				{
				}
				num = (short)75890688;
				short num3 = num;
				num = (short)1996292097;
				if (num != 0)
				{
				}
				num = (short)1498021888;
				if (num != 0)
				{
				}
				return this.<BluetoothEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1764971243;
				short num2 = num;
				num = (short)809456363;
				switch (num2 == num)
				{
				}
				num = (short)1188626432;
				short num3 = num;
				num = (short)42663936;
				if (num != 0)
				{
				}
				num = (short)1654390785;
				if (num != 0)
				{
				}
				this.<BluetoothEnable>k__BackingField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0001098C File Offset: 0x0000EB8C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00010A3C File Offset: 0x0000EC3C
		[global::System.Runtime.Serialization.DataMember]
		public bool? LocationEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1252589569;
				if (num != 0)
				{
				}
				num = (short)1560329197;
				short num2 = num;
				num = (short)1074838509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203830784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084306944;
				if (num != 0)
				{
				}
				return this.<LocationEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)828747272;
				short num2 = num;
				num = (short)2117381640;
				switch (num2 == num)
				{
				}
				num = (short)226361344;
				short num3 = num;
				num = (short)842989569;
				if (num != 0)
				{
				}
				num = (short)1782775808;
				if (num != 0)
				{
				}
				this.<LocationEnable>k__BackingField = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00010AEC File Offset: 0x0000ECEC
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00010B98 File Offset: 0x0000ED98
		[global::System.Runtime.Serialization.DataMember]
		public bool? P25LocationReporting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1554165277;
				short num2 = num;
				num = (short)2143596061;
				switch (num2 == num)
				{
				}
				num = (short)829358080;
				short num3 = num;
				num = (short)1930756096;
				if (num != 0)
				{
				}
				num = (short)1915748353;
				if (num != 0)
				{
				}
				return this.<P25LocationReporting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1088162922;
				short num2 = num;
				num = (short)1371868266;
				switch (num2 == num)
				{
				}
				num = (short)555614208;
				short num3 = num;
				num = (short)790757377;
				if (num != 0)
				{
				}
				num = (short)2094137344;
				if (num != 0)
				{
				}
				this.<P25LocationReporting>k__BackingField = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00010C48 File Offset: 0x0000EE48
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		[global::System.Runtime.Serialization.DataMember]
		public string LocationServerIPAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1423794600;
				short num2 = num;
				num = (short)1382310312;
				switch (num2 == num)
				{
				}
				num = (short)755957760;
				short num3 = num;
				num = (short)816250880;
				if (num != 0)
				{
				}
				num = (short)1432879105;
				if (num != 0)
				{
				}
				return this.<LocationServerIPAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1976303790;
				short num2 = num;
				num = (short)1798766766;
				switch (num2 == num)
				{
				}
				num = (short)1220870144;
				short num3 = num;
				num = (short)1507131393;
				if (num != 0)
				{
				}
				num = (short)40501248;
				if (num != 0)
				{
				}
				this.<LocationServerIPAddress>k__BackingField = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00010E54 File Offset: 0x0000F054
		[global::System.Runtime.Serialization.DataMember]
		public bool? DirectLocationRegistration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734492359;
				short num2 = num;
				num = (short)22102215;
				switch (num2 == num)
				{
				}
				num = (short)1855455232;
				short num3 = num;
				num = (short)237240320;
				if (num != 0)
				{
				}
				num = (short)1627455489;
				if (num != 0)
				{
				}
				return this.<DirectLocationRegistration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1414062426;
				short num2 = num;
				num = (short)199549274;
				switch (num2 == num)
				{
				}
				num = (short)1886060544;
				short num3 = num;
				num = (short)408813569;
				if (num != 0)
				{
				}
				num = (short)1265762304;
				if (num != 0)
				{
				}
				this.<DirectLocationRegistration>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00010F04 File Offset: 0x0000F104
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[global::System.Runtime.Serialization.DataMember]
		public int? ArsMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1857945600;
				short num2 = num;
				num = (short)440925102;
				short num3 = num;
				num = (short)2145713070;
				switch (num3 == num)
				{
				}
				num = (short)1710686208;
				if (num != 0)
				{
				}
				num = (short)1553334273;
				if (num != 0)
				{
				}
				return this.<ArsMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)965869568;
				short num2 = num;
				num = (short)1519462561;
				short num3 = num;
				num = (short)712911009;
				switch (num3 == num)
				{
				}
				num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)1886781440;
				if (num != 0)
				{
				}
				this.<ArsMode>k__BackingField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00011060 File Offset: 0x0000F260
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00011110 File Offset: 0x0000F310
		[global::System.Runtime.Serialization.DataMember]
		public bool? RadioAliasEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)180617216;
				short num2 = num;
				num = (short)1206922677;
				short num3 = num;
				num = (short)654192053;
				switch (num3 == num)
				{
				}
				num = (short)1280442368;
				if (num != 0)
				{
				}
				num = (short)384434177;
				if (num != 0)
				{
				}
				return this.<RadioAliasEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1159135232;
				short num2 = num;
				num = (short)1536129414;
				short num3 = num;
				num = (short)1551923590;
				switch (num3 == num)
				{
				}
				num = (short)843186177;
				if (num != 0)
				{
				}
				num = (short)643366912;
				if (num != 0)
				{
				}
				this.<RadioAliasEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000111C0 File Offset: 0x0000F3C0
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00011270 File Offset: 0x0000F470
		[global::System.Runtime.Serialization.DataMember]
		public bool? OtarEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1850277888;
				short num2 = num;
				num = (short)1170785327;
				short num3 = num;
				num = (short)462537775;
				switch (num3 == num)
				{
				}
				num = (short)1529282561;
				if (num != 0)
				{
				}
				num = (short)10027008;
				if (num != 0)
				{
				}
				return this.<OtarEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1519714304;
				short num2 = num;
				num = (short)1178864433;
				short num3 = num;
				num = (short)1435765553;
				switch (num3 == num)
				{
				}
				num = (short)1090650113;
				if (num != 0)
				{
				}
				num = (short)321781760;
				if (num != 0)
				{
				}
				this.<OtarEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0001131C File Offset: 0x0000F51C
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000113CC File Offset: 0x0000F5CC
		[global::System.Runtime.Serialization.DataMember]
		public bool? AstroOtarEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)865927168;
				short num2 = num;
				num = (short)1364077761;
				short num3 = num;
				num = (short)223816897;
				switch (num3 == num)
				{
				}
				num = (short)1182531585;
				if (num != 0)
				{
				}
				num = (short)446365696;
				if (num != 0)
				{
				}
				return this.<AstroOtarEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2083454976;
				short num2 = num;
				num = (short)957896633;
				short num3 = num;
				num = (short)1801672633;
				switch (num3 == num)
				{
				}
				num = (short)1108017152;
				if (num != 0)
				{
				}
				num = (short)12255233;
				if (num != 0)
				{
				}
				this.<AstroOtarEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0001147C File Offset: 0x0000F67C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00011530 File Offset: 0x0000F730
		[global::System.Runtime.Serialization.DataMember]
		public int? SecureOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1843068928;
				short num2 = num;
				num = (short)2116986157;
				short num3 = num;
				num = (short)1712104749;
				switch (num3 == num)
				{
				}
				num = (short)1836711936;
				if (num != 0)
				{
				}
				num = (short)93388801;
				if (num != 0)
				{
				}
				return this.<SecureOperation>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1796472832;
				short num2 = num;
				num = (short)1892350102;
				short num3 = num;
				num = (short)1583216790;
				switch (num3 == num)
				{
				}
				num = (short)795148289;
				if (num != 0)
				{
				}
				num = (short)1147273216;
				if (num != 0)
				{
				}
				this.<SecureOperation>k__BackingField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000115E4 File Offset: 0x0000F7E4
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00011698 File Offset: 0x0000F898
		[global::System.Runtime.Serialization.DataMember]
		public bool? AESEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1812267008;
				short num2 = num;
				num = (short)579095658;
				short num3 = num;
				num = (short)1166232682;
				switch (num3 == num)
				{
				}
				num = (short)2012151808;
				if (num != 0)
				{
				}
				num = (short)2064121857;
				if (num != 0)
				{
				}
				return this.<AESEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1612972032;
				short num2 = num;
				num = (short)964665746;
				short num3 = num;
				num = (short)777757074;
				switch (num3 == num)
				{
				}
				num = (short)1455620097;
				if (num != 0)
				{
				}
				num = (short)304021504;
				if (num != 0)
				{
				}
				this.<AESEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00011748 File Offset: 0x0000F948
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000117F4 File Offset: 0x0000F9F4
		[global::System.Runtime.Serialization.DataMember]
		public int? BluetoothDunPeerIpAssignmentType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1933443072;
				short num2 = num;
				num = (short)830685594;
				short num3 = num;
				num = (short)250429850;
				switch (num3 == num)
				{
				}
				num = (short)50790400;
				if (num != 0)
				{
				}
				num = (short)351600641;
				if (num != 0)
				{
				}
				return this.<BluetoothDunPeerIpAssignmentType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1045757952;
				short num2 = num;
				num = (short)477975188;
				short num3 = num;
				num = (short)734483092;
				switch (num3 == num)
				{
				}
				num = (short)363397121;
				if (num != 0)
				{
				}
				num = (short)2067988480;
				if (num != 0)
				{
				}
				this.<BluetoothDunPeerIpAssignmentType>k__BackingField = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000118A8 File Offset: 0x0000FAA8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0001195C File Offset: 0x0000FB5C
		[global::System.Runtime.Serialization.DataMember]
		public int? UserNameDisplayTextSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1458831360;
				short num2 = num;
				num = (short)291567727;
				short num3 = num;
				num = (short)1853421679;
				switch (num3 == num)
				{
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)1575223296;
				if (num != 0)
				{
				}
				return this.<UserNameDisplayTextSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1918238720;
				short num2 = num;
				num = (short)1884118991;
				short num3 = num;
				num = (short)1525571535;
				switch (num3 == num)
				{
				}
				num = (short)259850241;
				if (num != 0)
				{
				}
				num = (short)1445003264;
				if (num != 0)
				{
				}
				this.<UserNameDisplayTextSize>k__BackingField = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00011A0C File Offset: 0x0000FC0C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00011ABC File Offset: 0x0000FCBC
		[global::System.Runtime.Serialization.DataMember]
		public int? UserLoginUnitIDTextSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1372454912;
				short num2 = num;
				num = (short)1095792323;
				short num3 = num;
				num = (short)1149269699;
				switch (num3 == num)
				{
				}
				num = (short)1913061376;
				if (num != 0)
				{
				}
				num = (short)2007826433;
				if (num != 0)
				{
				}
				return this.<UserLoginUnitIDTextSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1865678848;
				short num2 = num;
				num = (short)1615600396;
				short num3 = num;
				num = (short)1497963276;
				switch (num3 == num)
				{
				}
				num = (short)1090650113;
				if (num != 0)
				{
				}
				num = (short)211877888;
				if (num != 0)
				{
				}
				this.<UserLoginUnitIDTextSize>k__BackingField = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00011B6C File Offset: 0x0000FD6C
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00011C1C File Offset: 0x0000FE1C
		[global::System.Runtime.Serialization.DataMember]
		public bool? UserLoginUnitIDEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2032533504;
				short num2 = num;
				num = (short)1244803611;
				short num3 = num;
				num = (short)558051867;
				switch (num3 == num)
				{
				}
				num = (short)1200422913;
				if (num != 0)
				{
				}
				num = (short)451805184;
				if (num != 0)
				{
				}
				return this.<UserLoginUnitIDEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)121700352;
				short num2 = num;
				num = (short)1454851994;
				short num3 = num;
				num = (short)441272218;
				switch (num3 == num)
				{
				}
				num = (short)221970433;
				if (num != 0)
				{
				}
				num = (short)465633280;
				if (num != 0)
				{
				}
				this.<UserLoginUnitIDEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00011CCC File Offset: 0x0000FECC
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00011D7C File Offset: 0x0000FF7C
		[global::System.Runtime.Serialization.DataMember]
		public string AutomaticRegistrationServerAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1026359296;
				short num2 = num;
				num = (short)907316983;
				short num3 = num;
				num = (short)1490063095;
				switch (num3 == num)
				{
				}
				num = (short)948174849;
				if (num != 0)
				{
				}
				num = (short)2015821824;
				if (num != 0)
				{
				}
				return this.<AutomaticRegistrationServerAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1952055296;
				short num2 = num;
				num = (short)843561437;
				short num3 = num;
				num = (short)1083685341;
				switch (num3 == num)
				{
				}
				num = (short)2118254592;
				if (num != 0)
				{
				}
				num = (short)974389249;
				if (num != 0)
				{
				}
				this.<AutomaticRegistrationServerAddress>k__BackingField = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00011E30 File Offset: 0x00010030
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00011EE0 File Offset: 0x000100E0
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothPANNetworkBaseAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1020657664;
				short num2 = num;
				num = (short)182222278;
				short num3 = num;
				num = (short)1328643526;
				switch (num3 == num)
				{
				}
				num = (short)325451777;
				if (num != 0)
				{
				}
				num = (short)218890240;
				if (num != 0)
				{
				}
				return this.<BluetoothPANNetworkBaseAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1702952960;
				short num2 = num;
				num = (short)172861716;
				short num3 = num;
				num = (short)169453844;
				switch (num3 == num)
				{
				}
				num = (short)1834942465;
				if (num != 0)
				{
				}
				num = (short)1027407872;
				if (num != 0)
				{
				}
				this.<BluetoothPANNetworkBaseAddress>k__BackingField = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00011F90 File Offset: 0x00010190
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0001203C File Offset: 0x0001023C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] AstroEnableFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1387986944;
				short num2 = num;
				num = (short)350859552;
				short num3 = num;
				num = (short)45986080;
				switch (num3 == num)
				{
				}
				num = (short)1347682305;
				if (num != 0)
				{
				}
				num = (short)1777467392;
				if (num != 0)
				{
				}
				return this.<AstroEnableFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)54591488;
				short num2 = num;
				num = (short)796229054;
				short num3 = num;
				num = (short)1955823038;
				switch (num3 == num)
				{
				}
				num = (short)473235457;
				if (num != 0)
				{
				}
				num = (short)518389760;
				if (num != 0)
				{
				}
				this.<AstroEnableFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000120F0 File Offset: 0x000102F0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000121A0 File Offset: 0x000103A0
		[global::System.Runtime.Serialization.DataMember]
		public string AstroEnableFlashCodeEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1573978112;
				short num2 = num;
				num = (short)198564631;
				short num3 = num;
				num = (short)1836178199;
				switch (num3 == num)
				{
				}
				num = (short)1444347904;
				if (num != 0)
				{
				}
				num = (short)1397358593;
				if (num != 0)
				{
				}
				return this.<AstroEnableFlashCodeEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1934491648;
				short num2 = num;
				num = (short)2030618464;
				short num3 = num;
				num = (short)955434848;
				switch (num3 == num)
				{
				}
				num = (short)589889537;
				if (num != 0)
				{
				}
				num = (short)1652883456;
				if (num != 0)
				{
				}
				this.<AstroEnableFlashCodeEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00012254 File Offset: 0x00010454
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00012308 File Offset: 0x00010508
		[global::System.Runtime.Serialization.DataMember]
		public byte[] AstroPurchasedFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)270401536;
				short num2 = num;
				num = (short)890276060;
				short num3 = num;
				num = (short)885623004;
				switch (num3 == num)
				{
				}
				num = (short)691863552;
				if (num != 0)
				{
				}
				num = (short)427622401;
				if (num != 0)
				{
				}
				return this.<AstroPurchasedFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1985544192;
				short num2 = num;
				num = (short)392880939;
				short num3 = num;
				num = (short)884663083;
				switch (num3 == num)
				{
				}
				num = (short)1916928001;
				if (num != 0)
				{
				}
				num = (short)443088896;
				if (num != 0)
				{
				}
				this.<AstroPurchasedFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000123B8 File Offset: 0x000105B8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00012468 File Offset: 0x00010668
		[global::System.Runtime.Serialization.DataMember]
		public string AstroPurchasedFlashCodeEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1798832128;
				short num2 = num;
				num = (short)226425767;
				short num3 = num;
				num = (short)280296359;
				switch (num3 == num)
				{
				}
				num = (short)1739522049;
				if (num != 0)
				{
				}
				num = (short)192872448;
				if (num != 0)
				{
				}
				return this.<AstroPurchasedFlashCodeEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)406716416;
				short num2 = num;
				num = (short)942843624;
				short num3 = num;
				num = (short)1072801512;
				switch (num3 == num)
				{
				}
				num = (short)782041089;
				if (num != 0)
				{
				}
				num = (short)75890688;
				if (num != 0)
				{
				}
				this.<AstroPurchasedFlashCodeEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0001251C File Offset: 0x0001071C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000125CC File Offset: 0x000107CC
		[global::System.Runtime.Serialization.DataMember]
		public string AstroSysKeyLog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)150601728;
				short num2 = num;
				num = (short)296550401;
				if (num != 0)
				{
				}
				num = (short)1699780579;
				short num3 = num;
				num = (short)1931909091;
				switch (num3 == num)
				{
				}
				num = (short)907018240;
				if (num != 0)
				{
				}
				return this.<AstroSysKeyLog>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1096417280;
				short num2 = num;
				num = (short)2035880719;
				short num3 = num;
				num = (short)1386156815;
				switch (num3 == num)
				{
				}
				num = (short)100532224;
				if (num != 0)
				{
				}
				num = (short)1677852673;
				if (num != 0)
				{
				}
				this.<AstroSysKeyLog>k__BackingField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00012680 File Offset: 0x00010880
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0001272C File Offset: 0x0001092C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1864105984;
				short num2 = num;
				num = (short)1453688529;
				short num3 = num;
				num = (short)413238993;
				switch (num3 == num)
				{
				}
				num = (short)1331691521;
				if (num != 0)
				{
				}
				num = (short)1050083328;
				if (num != 0)
				{
				}
				return this.<FirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1650655232;
				short num2 = num;
				num = (short)1077280769;
				if (num != 0)
				{
				}
				num = (short)1839626605;
				short num3 = num;
				num = (short)379418989;
				switch (num3 == num)
				{
				}
				num = (short)177668096;
				if (num != 0)
				{
				}
				this.<FirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000127DC File Offset: 0x000109DC
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00012888 File Offset: 0x00010A88
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? LanguagePackUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1536294912;
				short num2 = num;
				num = (short)4653057;
				if (num != 0)
				{
				}
				num = (short)381994585;
				short num3 = num;
				num = (short)435865177;
				switch (num3 == num)
				{
				}
				num = (short)1842020352;
				if (num != 0)
				{
				}
				return this.<LanguagePackUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)694747136;
				short num2 = num;
				num = (short)1062091169;
				short num3 = num;
				num = (short)721303969;
				switch (num3 == num)
				{
				}
				num = (short)1023934465;
				if (num != 0)
				{
				}
				num = (short)1915682816;
				if (num != 0)
				{
				}
				this.<LanguagePackUuid>k__BackingField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00012938 File Offset: 0x00010B38
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000129E8 File Offset: 0x00010BE8
		[global::System.Runtime.Serialization.DataMember]
		public int? HomeSystemId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)904986624;
				short num2 = num;
				num = (short)1447700068;
				short num3 = num;
				num = (short)754722404;
				switch (num3 == num)
				{
				}
				num = (short)831586305;
				if (num != 0)
				{
				}
				num = (short)2113011712;
				if (num != 0)
				{
				}
				return this.<HomeSystemId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)970588160;
				short num2 = num;
				num = (short)1560350642;
				short num3 = num;
				num = (short)1539444658;
				switch (num3 == num)
				{
				}
				num = (short)869662720;
				if (num != 0)
				{
				}
				num = (short)1142292481;
				if (num != 0)
				{
				}
				this.<HomeSystemId>k__BackingField = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00012A9C File Offset: 0x00010C9C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00012B50 File Offset: 0x00010D50
		[global::System.Runtime.Serialization.DataMember]
		public string HomeSystemIdEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)737083392;
				short num2 = num;
				num = (short)1198406397;
				short num3 = num;
				num = (short)2125150973;
				switch (num3 == num)
				{
				}
				num = (short)1238695936;
				if (num != 0)
				{
				}
				num = (short)1938751489;
				if (num != 0)
				{
				}
				return this.<HomeSystemIdEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1050738688;
				short num2 = num;
				num = (short)1376883047;
				short num3 = num;
				num = (short)213553511;
				switch (num3 == num)
				{
				}
				num = (short)212664321;
				if (num != 0)
				{
				}
				num = (short)1739718656;
				if (num != 0)
				{
				}
				this.<HomeSystemIdEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00012BFC File Offset: 0x00010DFC
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[global::System.Runtime.Serialization.DataMember]
		public bool? DisableWriteProtect
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1792606208;
				short num2 = num;
				num = (short)251174520;
				short num3 = num;
				num = (short)1867488888;
				switch (num3 == num)
				{
				}
				num = (short)1511129088;
				if (num != 0)
				{
				}
				num = (short)1640497153;
				if (num != 0)
				{
				}
				return this.<DisableWriteProtect>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)870121472;
				short num2 = num;
				num = (short)2028339201;
				if (num != 0)
				{
				}
				num = (short)1592030058;
				short num3 = num;
				num = (short)133264234;
				switch (num3 == num)
				{
				}
				num = (short)848297984;
				if (num != 0)
				{
				}
				this.<DisableWriteProtect>k__BackingField = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00012D58 File Offset: 0x00010F58
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00012E08 File Offset: 0x00011008
		[global::System.Runtime.Serialization.DataMember]
		public string DisableWriteProtectEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2065956864;
				short num2 = num;
				num = (short)954312349;
				short num3 = num;
				num = (short)1952097949;
				switch (num3 == num)
				{
				}
				num = (short)1248264192;
				if (num != 0)
				{
				}
				num = (short)1683226625;
				if (num != 0)
				{
				}
				return this.<DisableWriteProtectEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1292894208;
				short num2 = num;
				num = (short)695110496;
				short num3 = num;
				num = (short)535923552;
				switch (num3 == num)
				{
				}
				num = (short)480968705;
				if (num != 0)
				{
				}
				num = (short)612106240;
				if (num != 0)
				{
				}
				this.<DisableWriteProtectEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00012EB8 File Offset: 0x000110B8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00012F68 File Offset: 0x00011168
		[global::System.Runtime.Serialization.DataMember]
		public bool? RadioInhibitedTrunking
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)970260480;
				short num2 = num;
				num = (short)2067529729;
				if (num != 0)
				{
				}
				num = (short)1411846480;
				short num3 = num;
				num = (short)967643472;
				switch (num3 == num)
				{
				}
				num = (short)1504706560;
				if (num != 0)
				{
				}
				return this.<RadioInhibitedTrunking>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2000289792;
				short num2 = num;
				num = (short)1589864792;
				short num3 = num;
				num = (short)185231704;
				switch (num3 == num)
				{
				}
				num = (short)458358784;
				if (num != 0)
				{
				}
				num = (short)1075773441;
				if (num != 0)
				{
				}
				this.<RadioInhibitedTrunking>k__BackingField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001301C File Offset: 0x0001121C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000130CC File Offset: 0x000112CC
		[global::System.Runtime.Serialization.DataMember]
		public int? OwnerAdvKeyType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)943259648;
				short num2 = num;
				num = (short)65582488;
				short num3 = num;
				num = (short)1966126488;
				switch (num3 == num)
				{
				}
				num = (short)967704577;
				if (num != 0)
				{
				}
				num = (short)1963065344;
				if (num != 0)
				{
				}
				return this.<OwnerAdvKeyType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)191627264;
				short num2 = num;
				num = (short)1445023309;
				short num3 = num;
				num = (short)137514573;
				switch (num3 == num)
				{
				}
				num = (short)112525313;
				if (num != 0)
				{
				}
				num = (short)1251016704;
				if (num != 0)
				{
				}
				this.<OwnerAdvKeyType>k__BackingField = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001317C File Offset: 0x0001137C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0001322C File Offset: 0x0001142C
		[global::System.Runtime.Serialization.DataMember]
		public string OwnerAdvKeyTypeEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1259339776;
				short num2 = num;
				num = (short)1595774375;
				short num3 = num;
				num = (short)765957543;
				switch (num3 == num)
				{
				}
				num = (short)198639617;
				if (num != 0)
				{
				}
				num = (short)868810752;
				if (num != 0)
				{
				}
				return this.<OwnerAdvKeyTypeEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1252261888;
				short num2 = num;
				num = (short)574441116;
				short num3 = num;
				num = (short)1351960220;
				switch (num3 == num)
				{
				}
				num = (short)1890910209;
				if (num != 0)
				{
				}
				num = (short)124190720;
				if (num != 0)
				{
				}
				this.<OwnerAdvKeyTypeEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000132DC File Offset: 0x000114DC
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0001338C File Offset: 0x0001158C
		[global::System.Runtime.Serialization.DataMember]
		public int? OwnerWacnId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)26542080;
				short num2 = num;
				num = (short)154533889;
				if (num != 0)
				{
				}
				num = (short)1287310995;
				short num3 = num;
				num = (short)1960955539;
				switch (num3 == num)
				{
				}
				num = (short)249692160;
				if (num != 0)
				{
				}
				return this.<OwnerWacnId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1321664512;
				short num2 = num;
				num = (short)2030958893;
				short num3 = num;
				num = (short)1293023533;
				switch (num3 == num)
				{
				}
				num = (short)1217921025;
				if (num != 0)
				{
				}
				num = (short)609484800;
				if (num != 0)
				{
				}
				this.<OwnerWacnId>k__BackingField = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001343C File Offset: 0x0001163C
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000134EC File Offset: 0x000116EC
		[global::System.Runtime.Serialization.DataMember]
		public string OwnerWacnIdEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)274071552;
				short num2 = num;
				num = (short)884036194;
				short num3 = num;
				num = (short)537612898;
				switch (num3 == num)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				num = (short)275447809;
				if (num != 0)
				{
				}
				return this.<OwnerWacnIdEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1266876417;
				if (num != 0)
				{
				}
				num = (short)883966416;
				short num2 = num;
				num = (short)1353990608;
				switch (num2 == num)
				{
				}
				num = (short)408944640;
				short num3 = num;
				num = (short)13500416;
				if (num != 0)
				{
				}
				this.<OwnerWacnIdEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001359C File Offset: 0x0001179C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0001364C File Offset: 0x0001184C
		[global::System.Runtime.Serialization.DataMember]
		public bool? AllowInvalidFrequency
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2120985307;
				short num2 = num;
				num = (short)184396507;
				switch (num2 == num)
				{
				}
				num = (short)606994432;
				if (num != 0)
				{
				}
				num = (short)1465057280;
				short num3 = num;
				num = (short)1574109185;
				if (num != 0)
				{
				}
				return this.<AllowInvalidFrequency>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)338396320;
				short num2 = num;
				num = (short)1981056160;
				switch (num2 == num)
				{
				}
				num = (short)280297473;
				if (num != 0)
				{
				}
				num = (short)835059712;
				short num3 = num;
				num = (short)1251868672;
				if (num != 0)
				{
				}
				this.<AllowInvalidFrequency>k__BackingField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000136FC File Offset: 0x000118FC
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000137AC File Offset: 0x000119AC
		[global::System.Runtime.Serialization.DataMember]
		public string RecSetCounts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)543017062;
				short num2 = num;
				num = (short)1743505510;
				switch (num2 == num)
				{
				}
				num = (short)1041891329;
				if (num != 0)
				{
				}
				num = (short)1552154624;
				short num3 = num;
				num = (short)1068761088;
				if (num != 0)
				{
				}
				return this.<RecSetCounts>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1590034432;
				short num2 = num;
				num = (short)1619263489;
				if (num != 0)
				{
				}
				num = (short)1321748080;
				short num3 = num;
				num = (short)980174448;
				switch (num3 == num)
				{
				}
				num = (short)247726080;
				if (num != 0)
				{
				}
				this.<RecSetCounts>k__BackingField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001385C File Offset: 0x00011A5C
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0001390C File Offset: 0x00011B0C
		[global::System.Runtime.Serialization.DataMember]
		public int? DisplayTextSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2103967744;
				short num2 = num;
				num = (short)925249562;
				short num3 = num;
				num = (short)1043476506;
				switch (num3 == num)
				{
				}
				num = (short)1559560193;
				if (num != 0)
				{
				}
				num = (short)1584005120;
				if (num != 0)
				{
				}
				return this.<DisplayTextSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)64946176;
				short num2 = num;
				num = (short)1319724385;
				short num3 = num;
				num = (short)2003461473;
				switch (num3 == num)
				{
				}
				num = (short)590348289;
				if (num != 0)
				{
				}
				num = (short)2010382336;
				if (num != 0)
				{
				}
				this.<DisplayTextSize>k__BackingField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000139BC File Offset: 0x00011BBC
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00013A6C File Offset: 0x00011C6C
		[global::System.Runtime.Serialization.DataMember]
		public string iButtonSerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1216151552;
				short num2 = num;
				num = (short)794755073;
				if (num != 0)
				{
				}
				num = (short)498847452;
				short num3 = num;
				num = (short)1056820956;
				switch (num3 == num)
				{
				}
				num = (short)1693122560;
				if (num != 0)
				{
				}
				return this.<iButtonSerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)336592896;
				short num2 = num;
				num = (short)238141953;
				short num3 = num;
				num = (short)2019934721;
				switch (num3 == num)
				{
				}
				num = (short)1250099201;
				if (num != 0)
				{
				}
				num = (short)1753481216;
				if (num != 0)
				{
				}
				this.<iButtonSerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00013B1C File Offset: 0x00011D1C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00013BCC File Offset: 0x00011DCC
		[global::System.Runtime.Serialization.DataMember]
		public int ExtendedFlags
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1496580096;
				short num2 = num;
				num = (short)286129390;
				short num3 = num;
				num = (short)516357358;
				switch (num3 == num)
				{
				}
				num = (short)458752000;
				if (num != 0)
				{
				}
				num = (short)76087297;
				if (num != 0)
				{
				}
				return this.<ExtendedFlags>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1965686784;
				short num2 = num;
				num = (short)442148226;
				short num3 = num;
				num = (short)1964483970;
				switch (num3 == num)
				{
				}
				num = (short)1452998657;
				if (num != 0)
				{
				}
				num = (short)1273954304;
				if (num != 0)
				{
				}
				this.<ExtendedFlags>k__BackingField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00013C7C File Offset: 0x00011E7C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00013D2C File Offset: 0x00011F2C
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceInfoFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)823721984;
				short num2 = num;
				num = (short)862652846;
				short num3 = num;
				num = (short)736496046;
				switch (num3 == num)
				{
				}
				num = (short)545914881;
				if (num != 0)
				{
				}
				num = (short)1700528128;
				if (num != 0)
				{
				}
				return this.<DeviceInfoFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)187564032;
				short num2 = num;
				num = (short)1632906891;
				short num3 = num;
				num = (short)1934634635;
				switch (num3 == num)
				{
				}
				num = (short)1737555968;
				if (num != 0)
				{
				}
				num = (short)449052673;
				if (num != 0)
				{
				}
				this.<DeviceInfoFields>k__BackingField = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00013DE0 File Offset: 0x00011FE0
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00013E90 File Offset: 0x00012090
		[global::System.Runtime.Serialization.DataMember]
		public string ExtendedFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1095827456;
				short num2 = num;
				num = (short)1742064578;
				short num3 = num;
				num = (short)366267330;
				switch (num3 == num)
				{
				}
				num = (short)1589313537;
				if (num != 0)
				{
				}
				num = (short)455802880;
				if (num != 0)
				{
				}
				return this.<ExtendedFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)940703744;
				short num2 = num;
				num = (short)376536834;
				short num3 = num;
				num = (short)1822785282;
				switch (num3 == num)
				{
				}
				num = (short)1943797761;
				if (num != 0)
				{
				}
				num = (short)96141312;
				if (num != 0)
				{
				}
				this.<ExtendedFields>k__BackingField = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00013F44 File Offset: 0x00012144
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00013FF4 File Offset: 0x000121F4
		[global::System.Runtime.Serialization.DataMember]
		public string PCIOptionFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1724645376;
				short num2 = num;
				num = (short)1245616502;
				short num3 = num;
				num = (short)361339254;
				switch (num3 == num)
				{
				}
				num = (short)1823997953;
				if (num != 0)
				{
				}
				num = (short)448462848;
				if (num != 0)
				{
				}
				return this.<PCIOptionFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1856503808;
				short num2 = num;
				num = (short)1835613473;
				short num3 = num;
				num = (short)995573025;
				switch (num3 == num)
				{
				}
				num = (short)1823342593;
				if (num != 0)
				{
				}
				num = (short)2097086464;
				if (num != 0)
				{
				}
				this.<PCIOptionFields>k__BackingField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000140A4 File Offset: 0x000122A4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00014154 File Offset: 0x00012354
		[global::System.Runtime.Serialization.DataMember]
		public string HOptionFields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1073676288;
				short num2 = num;
				num = (short)337573031;
				short num3 = num;
				num = (short)1283060903;
				switch (num3 == num)
				{
				}
				num = (short)212008960;
				if (num != 0)
				{
				}
				num = (short)1045430273;
				if (num != 0)
				{
				}
				return this.<HOptionFields>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1788346368;
				short num2 = num;
				num = (short)1640047208;
				short num3 = num;
				num = (short)346628712;
				switch (num3 == num)
				{
				}
				num = (short)1431961601;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				if (num != 0)
				{
				}
				this.<HOptionFields>k__BackingField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00014204 File Offset: 0x00012404
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000142B8 File Offset: 0x000124B8
		[global::System.Runtime.Serialization.DataMember]
		public int? RadInfoLabtoolProductModelIdentifier_A37178
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1470300160;
				short num2 = num;
				num = (short)847580316;
				short num3 = num;
				num = (short)712248476;
				switch (num3 == num)
				{
				}
				num = (short)30277633;
				if (num != 0)
				{
				}
				num = (short)1466368000;
				if (num != 0)
				{
				}
				return this.<RadInfoLabtoolProductModelIdentifier_A37178>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)513605632;
				short num2 = num;
				num = (short)1475214735;
				short num3 = num;
				num = (short)370474383;
				switch (num3 == num)
				{
				}
				num = (short)1474232320;
				if (num != 0)
				{
				}
				num = (short)1938751489;
				if (num != 0)
				{
				}
				this.<RadInfoLabtoolProductModelIdentifier_A37178>k__BackingField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0001436C File Offset: 0x0001256C
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0001441C File Offset: 0x0001261C
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsConventionalOnlyRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1018757120;
				short num2 = num;
				num = (short)161094501;
				short num3 = num;
				num = (short)1842355045;
				switch (num3 == num)
				{
				}
				num = (short)1507721216;
				if (num != 0)
				{
				}
				num = (short)797966337;
				if (num != 0)
				{
				}
				return this.<IsConventionalOnlyRadio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1797128192;
				short num2 = num;
				num = (short)786762331;
				short num3 = num;
				num = (short)417925723;
				switch (num3 == num)
				{
				}
				num = (short)648019969;
				if (num != 0)
				{
				}
				num = (short)853934080;
				if (num != 0)
				{
				}
				this.<IsConventionalOnlyRadio>k__BackingField = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000144CC File Offset: 0x000126CC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0001457C File Offset: 0x0001277C
		[global::System.Runtime.Serialization.DataMember]
		public string LanguageSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)258408448;
				short num2 = num;
				num = (short)1349911159;
				short num3 = num;
				num = (short)1778319991;
				switch (num3 == num)
				{
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				num = (short)219283457;
				if (num != 0)
				{
				}
				return this.<LanguageSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)684654592;
				short num2 = num;
				num = (short)202974655;
				short num3 = num;
				num = (short)2084119999;
				switch (num3 == num)
				{
				}
				num = (short)398589953;
				if (num != 0)
				{
				}
				num = (short)981532672;
				if (num != 0)
				{
				}
				this.<LanguageSetting>k__BackingField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00014630 File Offset: 0x00012830
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000146E0 File Offset: 0x000128E0
		[global::System.Runtime.Serialization.DataMember]
		public string VASetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1768357888;
				short num2 = num;
				num = (short)1768385645;
				short num3 = num;
				num = (short)987589741;
				switch (num3 == num)
				{
				}
				num = (short)1188757505;
				if (num != 0)
				{
				}
				num = (short)1219035136;
				if (num != 0)
				{
				}
				return this.<VASetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1907425280;
				short num2 = num;
				num = (short)51380225;
				if (num != 0)
				{
				}
				num = (short)918254014;
				short num3 = num;
				num = (short)611479998;
				switch (num3 == num)
				{
				}
				num = (short)223608832;
				if (num != 0)
				{
				}
				this.<VASetting>k__BackingField = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00014790 File Offset: 0x00012990
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00014840 File Offset: 0x00012A40
		[global::System.Runtime.Serialization.DataMember]
		public string CACertificatesSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1233125376;
				short num2 = num;
				num = (short)672993736;
				short num3 = num;
				num = (short)1024594376;
				switch (num3 == num)
				{
				}
				num = (short)1662517249;
				if (num != 0)
				{
				}
				num = (short)1227227136;
				if (num != 0)
				{
				}
				return this.<CACertificatesSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)376569856;
				short num2 = num;
				num = (short)954677902;
				short num3 = num;
				num = (short)542128782;
				switch (num3 == num)
				{
				}
				num = (short)138674177;
				if (num != 0)
				{
				}
				num = (short)290062336;
				if (num != 0)
				{
				}
				this.<CACertificatesSetting>k__BackingField = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000148F0 File Offset: 0x00012AF0
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000149A0 File Offset: 0x00012BA0
		[global::System.Runtime.Serialization.DataMember]
		public string DVRSFilesSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1667170304;
				short num2 = num;
				num = (short)217206147;
				short num3 = num;
				num = (short)508775811;
				switch (num3 == num)
				{
				}
				num = (short)172425216;
				if (num != 0)
				{
				}
				num = (short)876609537;
				if (num != 0)
				{
				}
				return this.<DVRSFilesSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)297861120;
				short num2 = num;
				num = (short)2075637003;
				short num3 = num;
				num = (short)2046866699;
				switch (num3 == num)
				{
				}
				num = (short)994705409;
				if (num != 0)
				{
				}
				num = (short)122486784;
				if (num != 0)
				{
				}
				this.<DVRSFilesSetting>k__BackingField = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00014A50 File Offset: 0x00012C50
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00014B00 File Offset: 0x00012D00
		[global::System.Runtime.Serialization.DataMember]
		public string VAPackageNameLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1841758208;
				short num2 = num;
				num = (short)1459411028;
				short num3 = num;
				num = (short)1140840532;
				switch (num3 == num)
				{
				}
				num = (short)1027801089;
				if (num != 0)
				{
				}
				num = (short)622526464;
				if (num != 0)
				{
				}
				return this.<VAPackageNameLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1011417088;
				short num2 = num;
				num = (short)2065866421;
				short num3 = num;
				num = (short)2003082933;
				switch (num3 == num)
				{
				}
				num = (short)1998389249;
				if (num != 0)
				{
				}
				num = (short)119472128;
				if (num != 0)
				{
				}
				this.<VAPackageNameLst>k__BackingField = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00014BB0 File Offset: 0x00012DB0
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00014C60 File Offset: 0x00012E60
		[global::System.Runtime.Serialization.DataMember]
		public string CACertificatesPackageNameLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1336737792;
				short num2 = num;
				num = (short)411091116;
				short num3 = num;
				num = (short)924500140;
				switch (num3 == num)
				{
				}
				num = (short)1624571904;
				if (num != 0)
				{
				}
				num = (short)1777205249;
				if (num != 0)
				{
				}
				return this.<CACertificatesPackageNameLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1302331392;
				short num2 = num;
				num = (short)341787905;
				short num3 = num;
				num = (short)1340884225;
				switch (num3 == num)
				{
				}
				num = (short)2017525761;
				if (num != 0)
				{
				}
				num = (short)823263232;
				if (num != 0)
				{
				}
				this.<CACertificatesPackageNameLst>k__BackingField = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00014D10 File Offset: 0x00012F10
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00014DBC File Offset: 0x00012FBC
		[global::System.Runtime.Serialization.DataMember]
		public string DVRSFilesPackageNameLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1863057408;
				short num2 = num;
				num = (short)575143937;
				if (num != 0)
				{
				}
				num = (short)596627089;
				short num3 = num;
				num = (short)722456209;
				switch (num3 == num)
				{
				}
				num = (short)945291264;
				if (num != 0)
				{
				}
				return this.<DVRSFilesPackageNameLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)16711680;
				short num2 = num;
				num = (short)1158889912;
				short num3 = num;
				num = (short)1850884536;
				switch (num3 == num)
				{
				}
				num = (short)1003552769;
				if (num != 0)
				{
				}
				num = (short)1515651072;
				if (num != 0)
				{
				}
				this.<DVRSFilesPackageNameLst>k__BackingField = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00014E6C File Offset: 0x0001306C
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00014F1C File Offset: 0x0001311C
		[global::System.Runtime.Serialization.DataMember]
		public string LanguagePackageLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2005663744;
				short num2 = num;
				num = (short)875917626;
				short num3 = num;
				num = (short)1152020794;
				switch (num3 == num)
				{
				}
				num = (short)2059993088;
				if (num != 0)
				{
				}
				num = (short)1963065345;
				if (num != 0)
				{
				}
				return this.<LanguagePackageLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2114387968;
				short num2 = num;
				num = (short)635428851;
				short num3 = num;
				num = (short)661053427;
				switch (num3 == num)
				{
				}
				num = (short)1088684033;
				if (num != 0)
				{
				}
				num = (short)1392902144;
				if (num != 0)
				{
				}
				this.<LanguagePackageLst>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00014FCC File Offset: 0x000131CC
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0001507C File Offset: 0x0001327C
		[global::System.Runtime.Serialization.DataMember]
		public string LPWarningCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)882302871;
				short num2 = num;
				num = (short)402710423;
				switch (num2 == num)
				{
				}
				num = (short)904790017;
				if (num != 0)
				{
				}
				num = (short)122421248;
				if (num != 0)
				{
				}
				num = (short)1702035456;
				short num3 = num;
				return this.<LPWarningCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1468126620;
				short num2 = num;
				num = (short)940430748;
				switch (num2 == num)
				{
				}
				num = (short)927793153;
				if (num != 0)
				{
				}
				num = (short)397148160;
				if (num != 0)
				{
				}
				num = (short)256180224;
				short num3 = num;
				this.<LPWarningCode>k__BackingField = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0001512C File Offset: 0x0001332C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000151DC File Offset: 0x000133DC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy PasswordPolicy
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2074329738;
				short num2 = num;
				num = (short)545571466;
				switch (num2 == num)
				{
				}
				num = (short)404291585;
				if (num != 0)
				{
				}
				num = (short)1893728256;
				if (num != 0)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				return this.<PasswordPolicy>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)712236150;
				short num2 = num;
				num = (short)2134957174;
				switch (num2 == num)
				{
				}
				num = (short)87490561;
				if (num != 0)
				{
				}
				num = (short)997982208;
				if (num != 0)
				{
				}
				num = (short)2100559872;
				short num3 = num;
				this.<PasswordPolicy>k__BackingField = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001528C File Offset: 0x0001348C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0001533C File Offset: 0x0001353C
		[global::System.Runtime.Serialization.DataMember]
		public string ConfiguraitonUsedPCIs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)636581500;
				short num2 = num;
				num = (short)1675589244;
				switch (num2 == num)
				{
				}
				num = (short)498466817;
				if (num != 0)
				{
				}
				num = (short)1649475584;
				if (num != 0)
				{
				}
				num = (short)1677524992;
				short num3 = num;
				return this.<ConfiguraitonUsedPCIs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1212809499;
				short num2 = num;
				num = (short)1045496091;
				switch (num2 == num)
				{
				}
				num = (short)1706688513;
				if (num != 0)
				{
				}
				num = (short)1745420288;
				if (num != 0)
				{
				}
				num = (short)864026624;
				short num3 = num;
				this.<ConfiguraitonUsedPCIs>k__BackingField = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000153EC File Offset: 0x000135EC
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0001549C File Offset: 0x0001369C
		[global::System.Runtime.Serialization.DataMember]
		public string AvailablePCIs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1701544369;
				short num2 = num;
				num = (short)153649585;
				switch (num2 == num)
				{
				}
				num = (short)1474625536;
				if (num != 0)
				{
				}
				num = (short)231342081;
				if (num != 0)
				{
				}
				num = (short)964952064;
				short num3 = num;
				return this.<AvailablePCIs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1334575105;
				if (num != 0)
				{
				}
				num = (short)2035868357;
				short num2 = num;
				num = (short)1557062341;
				switch (num2 == num)
				{
				}
				num = (short)1857028096;
				if (num != 0)
				{
				}
				num = (short)1514864640;
				short num3 = num;
				this.<AvailablePCIs>k__BackingField = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00015550 File Offset: 0x00013750
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00015600 File Offset: 0x00013800
		[global::System.Runtime.Serialization.DataMember]
		public string VisiblePCIs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1033346454;
				short num2 = num;
				num = (short)977837462;
				switch (num2 == num)
				{
				}
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)447741952;
				if (num != 0)
				{
				}
				num = (short)1156907008;
				short num3 = num;
				return this.<VisiblePCIs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)299827201;
				if (num != 0)
				{
				}
				num = (short)367474326;
				short num2 = num;
				num = (short)1970419350;
				switch (num2 == num)
				{
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)2146304000;
				short num3 = num;
				this.<VisiblePCIs>k__BackingField = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000156B4 File Offset: 0x000138B4
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00015760 File Offset: 0x00013960
		[global::System.Runtime.Serialization.DataMember]
		public byte[] PSK
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2070262999;
				short num2 = num;
				num = (short)423539927;
				switch (num2 == num)
				{
				}
				num = (short)1839988736;
				if (num != 0)
				{
				}
				num = (short)997982209;
				if (num != 0)
				{
				}
				num = (short)46399488;
				short num3 = num;
				return this.<PSK>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)951343238;
				short num2 = num;
				num = (short)1130846342;
				switch (num2 == num)
				{
				}
				num = (short)1555234816;
				if (num != 0)
				{
				}
				num = (short)1749024769;
				if (num != 0)
				{
				}
				num = (short)546570240;
				short num3 = num;
				this.<PSK>k__BackingField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0001580C File Offset: 0x00013A0C
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000158BC File Offset: 0x00013ABC
		[global::System.Runtime.Serialization.DataMember]
		public short PSK_ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1398559220;
				short num2 = num;
				num = (short)1632391668;
				switch (num2 == num)
				{
				}
				num = (short)1060634625;
				if (num != 0)
				{
				}
				num = (short)1522860032;
				if (num != 0)
				{
				}
				num = (short)511639552;
				short num3 = num;
				return this.<PSK_ID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2071637034;
				short num2 = num;
				num = (short)2013113386;
				switch (num2 == num)
				{
				}
				num = (short)183500800;
				if (num != 0)
				{
				}
				num = (short)1391656961;
				if (num != 0)
				{
				}
				num = (short)888668160;
				short num3 = num;
				this.<PSK_ID>k__BackingField = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001596C File Offset: 0x00013B6C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00015A1C File Offset: 0x00013C1C
		[global::System.Runtime.Serialization.DataMember]
		public int? VRID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)328002705;
				short num2 = num;
				num = (short)617016465;
				switch (num2 == num)
				{
				}
				num = (short)1952120833;
				if (num != 0)
				{
				}
				num = (short)1732509696;
				if (num != 0)
				{
				}
				num = (short)1446707200;
				short num3 = num;
				return this.<VRID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1679185106;
				short num2 = num;
				num = (short)952587474;
				switch (num2 == num)
				{
				}
				num = (short)1812922368;
				if (num != 0)
				{
				}
				num = (short)612958209;
				if (num != 0)
				{
				}
				num = (short)1756561408;
				short num3 = num;
				this.<VRID>k__BackingField = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00015AC8 File Offset: 0x00013CC8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00015B78 File Offset: 0x00013D78
		[global::System.Runtime.Serialization.DataMember]
		public bool? DVRSHardwareEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)851574785;
				if (num != 0)
				{
				}
				num = (short)1657939562;
				short num2 = num;
				num = (short)1753687658;
				switch (num2 == num)
				{
				}
				num = (short)1798963200;
				if (num != 0)
				{
				}
				num = (short)1745158144;
				short num3 = num;
				return this.<DVRSHardwareEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)215392383;
				short num2 = num;
				num = (short)1772396671;
				switch (num2 == num)
				{
				}
				num = (short)639696897;
				if (num != 0)
				{
				}
				num = (short)2045313024;
				if (num != 0)
				{
				}
				num = (short)2117730304;
				short num3 = num;
				this.<DVRSHardwareEnable>k__BackingField = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00015C28 File Offset: 0x00013E28
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00015CD4 File Offset: 0x00013ED4
		[global::System.Runtime.Serialization.DataMember]
		public string DVRSFile
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1004765737;
				short num2 = num;
				num = (short)1292075561;
				switch (num2 == num)
				{
				}
				num = (short)1320353793;
				if (num != 0)
				{
				}
				num = (short)1509031936;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				short num3 = num;
				return this.<DVRSFile>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1874764455;
				short num2 = num;
				num = (short)1044947623;
				switch (num2 == num)
				{
				}
				num = (short)818872320;
				if (num != 0)
				{
				}
				num = (short)149815297;
				if (num != 0)
				{
				}
				num = (short)301989888;
				short num3 = num;
				this.<DVRSFile>k__BackingField = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00015D8C File Offset: 0x00013F8C
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00015E3C File Offset: 0x0001403C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware ASTROFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1721424387;
				short num2 = num;
				num = (short)1348983299;
				switch (num2 == num)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				num = (short)224002049;
				if (num != 0)
				{
				}
				num = (short)93913088;
				short num3 = num;
				return this.<ASTROFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)181517916;
				short num2 = num;
				num = (short)14466652;
				switch (num2 == num)
				{
				}
				num = (short)1536425985;
				if (num != 0)
				{
				}
				num = (short)1575026688;
				if (num != 0)
				{
				}
				num = (short)1785528320;
				short num3 = num;
				this.<ASTROFirmware>k__BackingField = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00015EEC File Offset: 0x000140EC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00015F9C File Offset: 0x0001419C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> APXDataProfiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)731534233;
				short num2 = num;
				num = (short)1246385049;
				switch (num2 == num)
				{
				}
				num = (short)1468792833;
				if (num != 0)
				{
				}
				num = (short)1268908032;
				if (num != 0)
				{
				}
				num = (short)1590296576;
				short num3 = num;
				return this.<APXDataProfiles>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1338086478;
				short num2 = num;
				num = (short)593269838;
				switch (num2 == num)
				{
				}
				num = (short)689045505;
				if (num != 0)
				{
				}
				num = (short)754253824;
				if (num != 0)
				{
				}
				num = (short)1364393984;
				short num3 = num;
				this.<APXDataProfiles>k__BackingField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00016050 File Offset: 0x00014250
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00016100 File Offset: 0x00014300
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> APXRadioSystems
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1140487293;
				short num2 = num;
				num = (short)1149531261;
				switch (num2 == num)
				{
				}
				num = (short)92798976;
				if (num != 0)
				{
				}
				num = (short)1580072961;
				if (num != 0)
				{
				}
				num = (short)884801536;
				short num3 = num;
				return this.<APXRadioSystems>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)75581410;
				short num2 = num;
				num = (short)1333020642;
				switch (num2 == num)
				{
				}
				num = (short)1819344897;
				if (num != 0)
				{
				}
				num = (short)347602944;
				if (num != 0)
				{
				}
				num = (short)25886720;
				short num3 = num;
				this.<APXRadioSystems>k__BackingField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000161B0 File Offset: 0x000143B0
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00016260 File Offset: 0x00014460
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack ASTROLanguagePack
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)794545453;
				short num2 = num;
				num = (short)1093455149;
				switch (num2 == num)
				{
				}
				num = (short)852688897;
				if (num != 0)
				{
				}
				num = (short)307363840;
				if (num != 0)
				{
				}
				num = (short)1850408960;
				short num3 = num;
				return this.<ASTROLanguagePack>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)851602169;
				short num2 = num;
				num = (short)1326541561;
				switch (num2 == num)
				{
				}
				num = (short)1907228672;
				if (num != 0)
				{
				}
				num = (short)152698881;
				if (num != 0)
				{
				}
				num = (short)666238976;
				short num3 = num;
				this.<ASTROLanguagePack>k__BackingField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00016310 File Offset: 0x00014510
		// (set) Token: 0x060001CA RID: 458 RVA: 0x000163BC File Offset: 0x000145BC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> ASTROVoiceAnnouncements
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1169518046;
				short num2 = num;
				num = (short)2037345758;
				switch (num2 == num)
				{
				}
				num = (short)1508179968;
				if (num != 0)
				{
				}
				num = (short)1552482305;
				if (num != 0)
				{
				}
				num = (short)1269760000;
				short num3 = num;
				return this.<ASTROVoiceAnnouncements>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1338738369;
				short num2 = num;
				num = (short)67274433;
				switch (num2 == num)
				{
				}
				num = (short)1206583296;
				if (num != 0)
				{
				}
				num = (short)1205207041;
				if (num != 0)
				{
				}
				num = (short)145293312;
				short num3 = num;
				this.<ASTROVoiceAnnouncements>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00016470 File Offset: 0x00014670
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00016520 File Offset: 0x00014720
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROTTSVoiceAnnouncement> ASTROTTSVoiceAnnouncements
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)361869424;
				short num2 = num;
				num = (short)286109808;
				switch (num2 == num)
				{
				}
				num = (short)138543105;
				if (num != 0)
				{
				}
				num = (short)2091974656;
				if (num != 0)
				{
				}
				num = (short)1990590464;
				short num3 = num;
				return this.<ASTROTTSVoiceAnnouncements>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)680548285;
				short num2 = num;
				num = (short)680482749;
				switch (num2 == num)
				{
				}
				num = (short)149422080;
				if (num != 0)
				{
				}
				num = (short)649789441;
				if (num != 0)
				{
				}
				num = (short)700186624;
				short num3 = num;
				this.<ASTROTTSVoiceAnnouncements>k__BackingField = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000165D0 File Offset: 0x000147D0
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00016680 File Offset: 0x00014880
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> ASTROCACertificates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)936758246;
				short num2 = num;
				num = (short)1492634598;
				switch (num2 == num)
				{
				}
				num = (short)706674688;
				if (num != 0)
				{
				}
				num = (short)1640693761;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				short num3 = num;
				return this.<ASTROCACertificates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)737023156;
				short num2 = num;
				num = (short)1991447732;
				switch (num2 == num)
				{
				}
				num = (short)221118465;
				if (num != 0)
				{
				}
				num = (short)393740288;
				if (num != 0)
				{
				}
				num = (short)373620736;
				short num3 = num;
				this.<ASTROCACertificates>k__BackingField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00016730 File Offset: 0x00014930
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000167DC File Offset: 0x000149DC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> ASTRODVRSFiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1017922256;
				short num2 = num;
				num = (short)232604368;
				switch (num2 == num)
				{
				}
				num = (short)2123694081;
				if (num != 0)
				{
				}
				num = (short)778633216;
				if (num != 0)
				{
				}
				num = (short)1080950784;
				short num3 = num;
				return this.<ASTRODVRSFiles>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1122580224;
				short num2 = num;
				num = (short)1958229760;
				switch (num2 == num)
				{
				}
				num = (short)562757633;
				if (num != 0)
				{
				}
				num = (short)714080256;
				if (num != 0)
				{
				}
				num = (short)302907392;
				short num3 = num;
				this.<ASTRODVRSFiles>k__BackingField = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001688C File Offset: 0x00014A8C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0001693C File Offset: 0x00014B3C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> APXOtarProfiles
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)439958277;
				short num2 = num;
				num = (short)199244549;
				switch (num2 == num)
				{
				}
				num = (short)618463233;
				if (num != 0)
				{
				}
				num = (short)1075249152;
				if (num != 0)
				{
				}
				num = (short)264962048;
				short num3 = num;
				return this.<APXOtarProfiles>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1420574446;
				short num2 = num;
				num = (short)1138048750;
				switch (num2 == num)
				{
				}
				num = (short)1197146113;
				if (num != 0)
				{
				}
				num = (short)11206656;
				short num3 = num;
				num = (short)50462720;
				if (num != 0)
				{
				}
				this.<APXOtarProfiles>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000169EC File Offset: 0x00014BEC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00016A9C File Offset: 0x00014C9C
		[global::System.Runtime.Serialization.DataMember]
		public string VAAstroTtsPackageNameLst
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1889702879;
				short num2 = num;
				num = (short)577278943;
				switch (num2 == num)
				{
				}
				num = (short)2130182145;
				if (num != 0)
				{
				}
				num = (short)2069102592;
				short num3 = num;
				num = (short)1147076608;
				if (num != 0)
				{
				}
				return this.<VAAstroTtsPackageNameLst>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)199950683;
				short num2 = num;
				num = (short)743309659;
				switch (num2 == num)
				{
				}
				num = (short)512163841;
				if (num != 0)
				{
				}
				num = (short)2027356160;
				short num3 = num;
				num = (short)272891904;
				if (num != 0)
				{
				}
				this.<VAAstroTtsPackageNameLst>k__BackingField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00016B4C File Offset: 0x00014D4C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00016BF8 File Offset: 0x00014DF8
		[global::System.Runtime.Serialization.DataMember]
		public string VAAstroTtsSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1629987853;
				short num2 = num;
				num = (short)593077261;
				switch (num2 == num)
				{
				}
				num = (short)833945601;
				if (num != 0)
				{
				}
				num = (short)902823936;
				short num3 = num;
				num = (short)1856897024;
				if (num != 0)
				{
				}
				return this.<VAAstroTtsSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1580698023;
				short num2 = num;
				num = (short)532253095;
				switch (num2 == num)
				{
				}
				num = (short)72155137;
				if (num != 0)
				{
				}
				num = (short)470220800;
				short num3 = num;
				num = (short)796327936;
				if (num != 0)
				{
				}
				this.<VAAstroTtsSetting>k__BackingField = value;
			}
		}
	}
}
