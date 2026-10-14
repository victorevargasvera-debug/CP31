using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXDataProfileSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0001EC00 File Offset: 0x0001CE00
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SerialNumber", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1145241601;
				if (num != 0)
				{
				}
				num = (short)465838938;
				short num2 = num;
				num = (short)1975722842;
				switch (num2 == num)
				{
				}
				num = (short)1173159936;
				if (num != 0)
				{
				}
				num = (short)1082523648;
				short num3 = num;
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)76742657;
				if (num != 0)
				{
				}
				num = (short)640804345;
				short num2 = num;
				num = (short)213116409;
				switch (num2 == num)
				{
				}
				num = (short)1925971968;
				if (num != 0)
				{
				}
				num = (short)1671036928;
				short num3 = num;
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0001ED60 File Offset: 0x0001CF60
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0001EE10 File Offset: 0x0001D010
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public int? RadioStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1140719617;
				if (num != 0)
				{
				}
				num = (short)1260394273;
				short num2 = num;
				num = (short)185472801;
				switch (num2 == num)
				{
				}
				num = (short)181796864;
				if (num != 0)
				{
				}
				num = (short)1425866752;
				short num3 = num;
				return this.<RadioStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1147977462;
				short num2 = num;
				num = (short)146783990;
				switch (num2 == num)
				{
				}
				num = (short)845021184;
				if (num != 0)
				{
				}
				num = (short)864223233;
				if (num != 0)
				{
				}
				num = (short)1975910400;
				short num3 = num;
				this.<RadioStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0001EF70 File Offset: 0x0001D170
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("TemplateUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.Guid? TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)501866035;
				short num2 = num;
				num = (short)785309235;
				switch (num2 == num)
				{
				}
				num = (short)804716544;
				if (num != 0)
				{
				}
				num = (short)933953537;
				if (num != 0)
				{
				}
				num = (short)1507000320;
				short num3 = num;
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)416922689;
				short num2 = num;
				num = (short)1028045889;
				switch (num2 == num)
				{
				}
				num = (short)1837432832;
				if (num != 0)
				{
				}
				num = (short)800915457;
				if (num != 0)
				{
				}
				num = (short)572129280;
				short num3 = num;
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0001F024 File Offset: 0x0001D224
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Template))]
		[global::System.Runtime.Serialization.DataMember]
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)685486072;
				short num2 = num;
				num = (short)2143268856;
				switch (num2 == num)
				{
				}
				num = (short)1053753345;
				if (num != 0)
				{
				}
				num = (short)827588608;
				if (num != 0)
				{
				}
				num = (short)1704919040;
				short num3 = num;
				return this.<TemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1946104081;
				short num2 = num;
				num = (short)1819422993;
				switch (num2 == num)
				{
				}
				num = (short)597622785;
				if (num != 0)
				{
				}
				num = (short)1228341248;
				if (num != 0)
				{
				}
				num = (short)2144927744;
				short num3 = num;
				this.<TemplateName>k__BackingField = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0001F180 File Offset: 0x0001D380
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0001F234 File Offset: 0x0001D434
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ConfigurationUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		public global::System.Guid? ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)854483180;
				short num2 = num;
				num = (short)1290952940;
				switch (num2 == num)
				{
				}
				num = (short)837943296;
				if (num != 0)
				{
				}
				num = (short)975372289;
				if (num != 0)
				{
				}
				num = (short)487194624;
				short num3 = num;
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)402194433;
				if (num != 0)
				{
				}
				num = (short)528701803;
				short num2 = num;
				num = (short)1391745387;
				switch (num2 == num)
				{
				}
				num = (short)1558642688;
				if (num != 0)
				{
				}
				num = (short)658046976;
				short num3 = num;
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0001F398 File Offset: 0x0001D598
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.Configuration))]
		[global::System.Runtime.Serialization.DataMember]
		public string ConfigurationName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1031220570;
				short num2 = num;
				num = (short)1607937370;
				switch (num2 == num)
				{
				}
				num = (short)609353729;
				if (num != 0)
				{
				}
				num = (short)517275648;
				if (num != 0)
				{
				}
				num = (short)2040791040;
				short num3 = num;
				return this.<ConfigurationName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1320573230;
				short num2 = num;
				num = (short)121526574;
				switch (num2 == num)
				{
				}
				num = (short)863633409;
				if (num != 0)
				{
				}
				num = (short)801308672;
				if (num != 0)
				{
				}
				num = (short)1246101504;
				short num3 = num;
				this.<ConfigurationName>k__BackingField = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0001F448 File Offset: 0x0001D648
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("RadioAlias", typeof(global::Motorola.CommonCPS.Server.EntityModel.Codeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string RadioAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)594406031;
				short num2 = num;
				num = (short)99609231;
				switch (num2 == num)
				{
				}
				num = (short)816906240;
				if (num != 0)
				{
				}
				num = (short)599261185;
				if (num != 0)
				{
				}
				num = (short)1655373824;
				short num3 = num;
				return this.<RadioAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)925739874;
				short num2 = num;
				num = (short)903719778;
				switch (num2 == num)
				{
				}
				num = (short)998309889;
				if (num != 0)
				{
				}
				num = (short)890634240;
				if (num != 0)
				{
				}
				num = (short)486342656;
				short num3 = num;
				this.<RadioAlias>k__BackingField = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0001F65C File Offset: 0x0001D85C
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SystemType", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		[global::System.Runtime.Serialization.DataMember]
		public int? SystemType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2056711459;
				short num2 = num;
				num = (short)123399459;
				switch (num2 == num)
				{
				}
				num = (short)1674706945;
				if (num != 0)
				{
				}
				num = (short)1871642624;
				if (num != 0)
				{
				}
				num = (short)529989632;
				short num3 = num;
				return this.<SystemType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1430711931;
				short num2 = num;
				num = (short)130084475;
				switch (num2 == num)
				{
				}
				num = (short)996540417;
				if (num != 0)
				{
				}
				num = (short)1162149888;
				if (num != 0)
				{
				}
				num = (short)1328283648;
				short num3 = num;
				this.<SystemType>k__BackingField = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001F710 File Offset: 0x0001D910
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Name", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		[global::System.Runtime.Serialization.DataMember]
		public string ProfileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1281825656;
				short num2 = num;
				num = (short)1475419000;
				switch (num2 == num)
				{
				}
				num = (short)1010171905;
				if (num != 0)
				{
				}
				num = (short)598409216;
				if (num != 0)
				{
				}
				num = (short)1639841792;
				short num3 = num;
				return this.<ProfileName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)343554691;
				short num2 = num;
				num = (short)2143107715;
				switch (num2 == num)
				{
				}
				num = (short)1892155393;
				if (num != 0)
				{
				}
				num = (short)464257024;
				if (num != 0)
				{
				}
				num = (short)1452474368;
				short num3 = num;
				this.<ProfileName>k__BackingField = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001F870 File Offset: 0x0001DA70
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0001F920 File Offset: 0x0001DB20
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("InheritFlag", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public bool? AutoGenerateIPs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1894645761;
				if (num != 0)
				{
				}
				num = (short)874131313;
				short num2 = num;
				num = (short)1421356913;
				switch (num2 == num)
				{
				}
				num = (short)799932416;
				if (num != 0)
				{
				}
				num = (short)726466560;
				short num3 = num;
				return this.<AutoGenerateIPs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)103457245;
				short num2 = num;
				num = (short)834642397;
				switch (num2 == num)
				{
				}
				num = (short)325386241;
				if (num != 0)
				{
				}
				num = (short)1974992896;
				if (num != 0)
				{
				}
				num = (short)1831927808;
				short num3 = num;
				this.<AutoGenerateIPs>k__BackingField = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0001FA80 File Offset: 0x0001DC80
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SubscriberIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)486608553;
				short num2 = num;
				num = (short)506597033;
				switch (num2 == num)
				{
				}
				num = (short)998113281;
				if (num != 0)
				{
				}
				num = (short)1987182592;
				if (num != 0)
				{
				}
				num = (short)1026949120;
				short num3 = num;
				return this.<SubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1999372289;
				if (num != 0)
				{
				}
				num = (short)1515737413;
				short num2 = num;
				num = (short)1923764549;
				switch (num2 == num)
				{
				}
				num = (short)1981677568;
				if (num != 0)
				{
				}
				num = (short)1426718720;
				short num3 = num;
				this.<SubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001FB30 File Offset: 0x0001DD30
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PeerIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public string PeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1962934273;
				if (num != 0)
				{
				}
				num = (short)817652657;
				short num2 = num;
				num = (short)63136689;
				switch (num2 == num)
				{
				}
				num = (short)1316159488;
				if (num != 0)
				{
				}
				num = (short)140443648;
				short num3 = num;
				return this.<PeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1542314258;
				short num2 = num;
				num = (short)1470028050;
				switch (num2 == num)
				{
				}
				num = (short)1674510337;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				if (num != 0)
				{
				}
				num = (short)249298944;
				short num3 = num;
				this.<PeerIP>k__BackingField = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0001FC90 File Offset: 0x0001DE90
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0001FD40 File Offset: 0x0001DF40
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AstroBluetoothDunSubscriberIp", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		[global::System.Runtime.Serialization.DataMember]
		public string BluetoothDUNSubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)317912920;
				short num2 = num;
				num = (short)2041378648;
				switch (num2 == num)
				{
				}
				num = (short)199622656;
				if (num != 0)
				{
				}
				num = (short)1873018881;
				if (num != 0)
				{
				}
				num = (short)1575419904;
				short num3 = num;
				return this.<BluetoothDUNSubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1796145153;
				if (num != 0)
				{
				}
				num = (short)2088370176;
				short num2 = num;
				num = (short)2023521035;
				short num3 = num;
				num = (short)675379979;
				switch (num3 == num)
				{
				}
				num = (short)1295908864;
				if (num != 0)
				{
				}
				this.<BluetoothDUNSubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AstroBluetoothDunPeerIp", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public string BluetoothDUNPeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1698364416;
				short num2 = num;
				num = (short)199949312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810300928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)486211585;
				if (num != 0)
				{
				}
				num = (short)1288503296;
				if (num != 0)
				{
				}
				return this.<BluetoothDUNPeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)668419335;
				short num2 = num;
				num = (short)1187923207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)689045504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260781568;
				if (num != 0)
				{
				}
				num = (short)1770520577;
				if (num != 0)
				{
				}
				this.<BluetoothDUNPeerIP>k__BackingField = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001FF50 File Offset: 0x0001E150
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00020000 File Offset: 0x0001E200
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AirInterfaceAddress", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public string AirInterfaceIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)487663250;
				short num2 = num;
				num = (short)43394706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165347328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134938625;
				if (num != 0)
				{
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				return this.<AirInterfaceIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)424442391;
				short num2 = num;
				num = (short)312703511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1178075136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023555072;
				if (num != 0)
				{
				}
				num = (short)1175322625;
				if (num != 0)
				{
				}
				this.<AirInterfaceIP>k__BackingField = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000200B0 File Offset: 0x0001E2B0
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00020160 File Offset: 0x0001E360
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LastJobUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? JobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737984867;
				short num2 = num;
				num = (short)1844546403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721813504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)990707712;
				if (num != 0)
				{
				}
				num = (short)789970945;
				if (num != 0)
				{
				}
				return this.<JobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1101422258;
				short num2 = num;
				num = (short)1074355890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248119296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)226754561;
				if (num != 0)
				{
				}
				num = (short)719060992;
				if (num != 0)
				{
				}
				this.<JobUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00020214 File Offset: 0x0001E414
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x000202C4 File Offset: 0x0001E4C4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.Job))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)590903802;
				short num2 = num;
				num = (short)69761530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458227712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129761281;
				if (num != 0)
				{
				}
				num = (short)2001862656;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1013320228;
				short num2 = num;
				num = (short)1732446756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124387328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46399489;
				if (num != 0)
				{
				}
				num = (short)783745024;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00020374 File Offset: 0x0001E574
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00020424 File Offset: 0x0001E624
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Uuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2081678912;
				short num2 = num;
				num = (short)677045824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170524672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1104740353;
				if (num != 0)
				{
				}
				num = (short)703725568;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1052522923;
				short num2 = num;
				num = (short)951400875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611726848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)820772865;
				if (num != 0)
				{
				}
				num = (short)960888832;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000204D4 File Offset: 0x0001E6D4
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00020580 File Offset: 0x0001E780
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CodeplugUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)340971864;
				short num2 = num;
				num = (short)835965272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118095872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804140545;
				if (num != 0)
				{
				}
				num = (short)154206208;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1156352726;
				short num2 = num;
				num = (short)489327318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131230720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107689472;
				if (num != 0)
				{
				}
				num = (short)1891827713;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00020630 File Offset: 0x0001E830
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000206E0 File Offset: 0x0001E8E0
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("NatEnable", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public bool? NatEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)210285751;
				short num2 = num;
				num = (short)1703982263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978518016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1280835585;
				if (num != 0)
				{
				}
				num = (short)1331953664;
				if (num != 0)
				{
				}
				return this.<NatEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)632594850;
				short num2 = num;
				num = (short)93561250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1954217984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046347777;
				if (num != 0)
				{
				}
				num = (short)944832512;
				if (num != 0)
				{
				}
				this.<NatEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00020794 File Offset: 0x0001E994
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00020840 File Offset: 0x0001EA40
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PacketDataMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public int? PacketDataMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1669055210;
				short num2 = num;
				num = (short)48808682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722665472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969605121;
				if (num != 0)
				{
				}
				num = (short)1913257984;
				if (num != 0)
				{
				}
				return this.<PacketDataMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1973124504;
				short num2 = num;
				num = (short)1218870680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239678976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264175617;
				if (num != 0)
				{
				}
				num = (short)1150025728;
				if (num != 0)
				{
				}
				this.<PacketDataMode>k__BackingField = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002BD RID: 701 RVA: 0x000208EC File Offset: 0x0001EAEC
		// (set) Token: 0x060002BE RID: 702 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothEnable", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? BluetoothEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1464860673;
				if (num != 0)
				{
				}
				num = (short)640286720;
				short num2 = num;
				num = (short)1702798042;
				short num3 = num;
				num = (short)522363610;
				switch (num3 == num)
				{
				}
				num = (short)1163853824;
				if (num != 0)
				{
				}
				return this.<BluetoothEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1644456832;
				short num2 = num;
				num = (short)525691776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624885760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190461441;
				if (num != 0)
				{
				}
				num = (short)611450880;
				if (num != 0)
				{
				}
				this.<BluetoothEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00020A54 File Offset: 0x0001EC54
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00020B04 File Offset: 0x0001ED04
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LocationEnable", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public bool? LocationEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2031575536;
				short num2 = num;
				num = (short)1834181104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050293760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715259904;
				if (num != 0)
				{
				}
				num = (short)1146159105;
				if (num != 0)
				{
				}
				return this.<LocationEnable>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)918803790;
				short num2 = num;
				num = (short)496883022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436745728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2007564288;
				if (num != 0)
				{
				}
				num = (short)1454571521;
				if (num != 0)
				{
				}
				this.<LocationEnable>k__BackingField = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00020C64 File Offset: 0x0001EE64
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("P25LocationReporting", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public bool? P25LocationReporting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)114908468;
				short num2 = num;
				num = (short)272850228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1648230400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685782528;
				if (num != 0)
				{
				}
				num = (short)1696727041;
				if (num != 0)
				{
				}
				return this.<P25LocationReporting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1921471792;
				short num2 = num;
				num = (short)1034114352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007826432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470614017;
				if (num != 0)
				{
				}
				num = (short)1592524800;
				if (num != 0)
				{
				}
				this.<P25LocationReporting>k__BackingField = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00020D14 File Offset: 0x0001EF14
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("LocationServerIPAddress", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		[global::System.Runtime.Serialization.DataMember]
		public string LocationServerIPAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1376853985;
				short num2 = num;
				num = (short)1393631201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)252837888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)911081473;
				if (num != 0)
				{
				}
				num = (short)549847040;
				if (num != 0)
				{
				}
				return this.<LocationServerIPAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1053368844;
				short num2 = num;
				num = (short)1750082060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628097024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519976448;
				if (num != 0)
				{
				}
				num = (short)2076180481;
				if (num != 0)
				{
				}
				this.<LocationServerIPAddress>k__BackingField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00020E78 File Offset: 0x0001F078
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00020F28 File Offset: 0x0001F128
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("DirectLocationRegistration", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public bool? DirectLocationRegistration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1139772385;
				short num2 = num;
				num = (short)874286049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749273088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958267393;
				if (num != 0)
				{
				}
				num = (short)2038300672;
				if (num != 0)
				{
				}
				return this.<DirectLocationRegistration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1302231259;
				short num2 = num;
				num = (short)1764522203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410976256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981794817;
				if (num != 0)
				{
				}
				num = (short)1055326208;
				if (num != 0)
				{
				}
				this.<DirectLocationRegistration>k__BackingField = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00021088 File Offset: 0x0001F288
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothDunPeerIpAssignmentType", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public int? BluetoothDunPeerIpAssignmentType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)274726913;
				if (num != 0)
				{
				}
				num = (short)1408696320;
				short num2 = num;
				num = (short)1296974292;
				short num3 = num;
				num = (short)1307853268;
				switch (num3 == num)
				{
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				return this.<BluetoothDunPeerIpAssignmentType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1350736317;
				short num2 = num;
				num = (short)370579901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870187008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762380288;
				if (num != 0)
				{
				}
				num = (short)1361510401;
				if (num != 0)
				{
				}
				this.<BluetoothDunPeerIpAssignmentType>k__BackingField = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00021138 File Offset: 0x0001F338
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000211E8 File Offset: 0x0001F3E8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("AutomaticRegistrationServerAddress", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public string AutomaticRegistrationServerAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)216473144;
				short num2 = num;
				num = (short)491134520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915800064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421593089;
				if (num != 0)
				{
				}
				num = (short)2031812608;
				if (num != 0)
				{
				}
				return this.<AutomaticRegistrationServerAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)50909717;
				short num2 = num;
				num = (short)328454677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399048704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979763200;
				if (num != 0)
				{
				}
				num = (short)508887041;
				if (num != 0)
				{
				}
				this.<AutomaticRegistrationServerAddress>k__BackingField = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00021298 File Offset: 0x0001F498
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00021348 File Offset: 0x0001F548
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ArsMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile))]
		public int? ArsMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1919844936;
				short num2 = num;
				num = (short)1605468744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111411200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053687808;
				if (num != 0)
				{
				}
				num = (short)1478295553;
				if (num != 0)
				{
				}
				return this.<ArsMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2022456846;
				short num2 = num;
				num = (short)2051161614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876412928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527433729;
				if (num != 0)
				{
				}
				num = (short)548929536;
				if (num != 0)
				{
				}
				this.<ArsMode>k__BackingField = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000213F8 File Offset: 0x0001F5F8
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000214AC File Offset: 0x0001F6AC
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("SubscriberIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		[global::System.Runtime.Serialization.DataMember]
		public string DataWideSubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)395233182;
				short num2 = num;
				num = (short)1124517790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139788288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059717120;
				if (num != 0)
				{
				}
				num = (short)64487425;
				if (num != 0)
				{
				}
				return this.<DataWideSubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1399022375;
				short num2 = num;
				num = (short)1590584103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1714618368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966000640;
				if (num != 0)
				{
				}
				num = (short)1026555905;
				if (num != 0)
				{
				}
				this.<DataWideSubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0002155C File Offset: 0x0001F75C
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0002160C File Offset: 0x0001F80C
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("PeerIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public string DataWidePeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)969392192;
				short num2 = num;
				num = (short)91996224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1940783104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1752301569;
				if (num != 0)
				{
				}
				num = (short)204668928;
				if (num != 0)
				{
				}
				return this.<DataWidePeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)536636145;
				short num2 = num;
				num = (short)619080433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970864128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497614849;
				if (num != 0)
				{
				}
				num = (short)182845440;
				if (num != 0)
				{
				}
				this.<DataWidePeerIP>k__BackingField = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000216C0 File Offset: 0x0001F8C0
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00021770 File Offset: 0x0001F970
		[global::System.Runtime.Serialization.DataMember]
		public string DataProfileType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1703283326;
				short num2 = num;
				num = (short)1008732798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494010368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1560936448;
				if (num != 0)
				{
				}
				num = (short)1675952129;
				if (num != 0)
				{
				}
				return this.<DataProfileType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)501868244;
				short num2 = num;
				num = (short)1818355412;
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
				num = (short)1975058432;
				if (num != 0)
				{
				}
				num = (short)60948481;
				if (num != 0)
				{
				}
				this.<DataProfileType>k__BackingField = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00021824 File Offset: 0x0001FA24
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x000218D4 File Offset: 0x0001FAD4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothDUNSubscriberIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public string DataWideBTDUNSubscriberIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)25611783;
				short num2 = num;
				num = (short)479383047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2058027008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564920321;
				if (num != 0)
				{
				}
				num = (short)178520064;
				if (num != 0)
				{
				}
				return this.<DataWideBTDUNSubscriberIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2019675815;
				short num2 = num;
				num = (short)2077675175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611399168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683540481;
				if (num != 0)
				{
				}
				num = (short)1542455296;
				if (num != 0)
				{
				}
				this.<DataWideBTDUNSubscriberIP>k__BackingField = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00021988 File Offset: 0x0001FB88
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00021A38 File Offset: 0x0001FC38
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothDUNPeerIP", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public string DataWideBTDUNPeerIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2101468980;
				short num2 = num;
				num = (short)1541267252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1734475776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121569280;
				if (num != 0)
				{
				}
				num = (short)1792344065;
				if (num != 0)
				{
				}
				return this.<DataWideBTDUNPeerIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1517019243;
				short num2 = num;
				num = (short)119464043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1349451776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558904833;
				if (num != 0)
				{
				}
				num = (short)1579089920;
				if (num != 0)
				{
				}
				this.<DataWideBTDUNPeerIP>k__BackingField = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00021AE8 File Offset: 0x0001FCE8
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00021B98 File Offset: 0x0001FD98
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("GroupUuid", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1540751361;
				if (num != 0)
				{
				}
				num = (short)621084672;
				short num2 = num;
				num = (short)290702625;
				short num3 = num;
				num = (short)2104870177;
				switch (num3 == num)
				{
				}
				num = (short)1935343616;
				if (num != 0)
				{
				}
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1057928056;
				short num2 = num;
				num = (short)1115861880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630390784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416691713;
				if (num != 0)
				{
				}
				num = (short)1484062720;
				if (num != 0)
				{
				}
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00021C48 File Offset: 0x0001FE48
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)490675490;
				short num2 = num;
				num = (short)789978402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452788224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1822883840;
				if (num != 0)
				{
				}
				num = (short)1242890241;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1060962304;
				short num2 = num;
				num = (short)177115298;
				short num3 = num;
				num = (short)295473314;
				switch (num3 == num)
				{
				}
				num = (short)671285249;
				if (num != 0)
				{
				}
				num = (short)1935212544;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00021E58 File Offset: 0x00020058
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.Radio))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1545863168;
				short num2 = num;
				num = (short)724927948;
				short num3 = num;
				num = (short)2051835340;
				switch (num3 == num)
				{
				}
				num = (short)620691457;
				if (num != 0)
				{
				}
				num = (short)1936064512;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574436864;
				short num2 = num;
				num = (short)1548783054;
				short num3 = num;
				num = (short)861769166;
				switch (num3 == num)
				{
				}
				num = (short)1100087297;
				if (num != 0)
				{
				}
				num = (short)218234880;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00021F08 File Offset: 0x00020108
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00021FBC File Offset: 0x000201BC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("BluetoothPANNetworkBaseAddress", typeof(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug))]
		public string BluetoothPANNetworkBaseAddress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)405798912;
				short num2 = num;
				num = (short)399433459;
				short num3 = num;
				num = (short)2045304563;
				switch (num3 == num)
				{
				}
				num = (short)1794572289;
				if (num != 0)
				{
				}
				num = (short)181469184;
				if (num != 0)
				{
				}
				return this.<BluetoothPANNetworkBaseAddress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1773207552;
				short num2 = num;
				num = (short)1205702928;
				short num3 = num;
				num = (short)1693159696;
				switch (num3 == num)
				{
				}
				num = (short)1509687297;
				if (num != 0)
				{
				}
				num = (short)247791616;
				if (num != 0)
				{
				}
				this.<BluetoothPANNetworkBaseAddress>k__BackingField = value;
			}
		}
	}
}
