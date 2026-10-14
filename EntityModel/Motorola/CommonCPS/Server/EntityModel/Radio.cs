using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBRadio))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.APXRadio))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio))]
	[global::System.Serializable]
	public class Radio : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00023554 File Offset: 0x00021754
		public Radio()
		{
			this.RadioFeatures = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
			this.Jobs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob>();
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00023580 File Offset: 0x00021780
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0002362C File Offset: 0x0002182C
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)167493151;
				short num2 = num;
				num = (short)848739871;
				switch (num2 == num)
				{
				}
				num = (short)1654718464;
				short num3 = num;
				num = (short)1993211904;
				if (num != 0)
				{
				}
				num = (short)86048769;
				if (num != 0)
				{
				}
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)994805207;
				short num2 = num;
				num = (short)1152746967;
				switch (num2 == num)
				{
				}
				num = (short)1195245568;
				short num3 = num;
				num = (short)2031812608;
				if (num != 0)
				{
				}
				num = (short)662765569;
				if (num != 0)
				{
				}
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000303 RID: 771 RVA: 0x000236DC File Offset: 0x000218DC
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0002378C File Offset: 0x0002198C
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)4013801;
				short num2 = num;
				num = (short)1726562025;
				switch (num2 == num)
				{
				}
				num = (short)1946550272;
				short num3 = num;
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)1245708288;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1055132236;
				short num2 = num;
				num = (short)1203964492;
				switch (num2 == num)
				{
				}
				num = (short)1505492992;
				short num3 = num;
				num = (short)130744320;
				if (num != 0)
				{
				}
				num = (short)1219297281;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0002383C File Offset: 0x00021A3C
		// (set) Token: 0x06000306 RID: 774 RVA: 0x000238EC File Offset: 0x00021AEC
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)287688203;
				short num2 = num;
				num = (short)560186891;
				switch (num2 == num)
				{
				}
				num = (short)2049966080;
				short num3 = num;
				num = (short)898105344;
				if (num != 0)
				{
				}
				num = (short)1918304257;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1449156314;
				short num2 = num;
				num = (short)893804250;
				switch (num2 == num)
				{
				}
				num = (short)897581056;
				short num3 = num;
				num = (short)231997441;
				if (num != 0)
				{
				}
				num = (short)1944911872;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0002399C File Offset: 0x00021B9C
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00023A48 File Offset: 0x00021C48
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2078490944;
				short num2 = num;
				num = (short)1086079296;
				switch (num2 == num)
				{
				}
				num = (short)1370357760;
				short num3 = num;
				num = (short)1992359937;
				if (num != 0)
				{
				}
				num = (short)1514078208;
				if (num != 0)
				{
				}
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)19307588;
				short num2 = num;
				num = (short)616602692;
				switch (num2 == num)
				{
				}
				num = (short)1635188736;
				short num3 = num;
				num = (short)97517569;
				if (num != 0)
				{
				}
				num = (short)522715136;
				if (num != 0)
				{
				}
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00023AFC File Offset: 0x00021CFC
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00023BAC File Offset: 0x00021DAC
		[global::System.Runtime.Serialization.DataMember]
		public int RadioStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)984481793;
				if (num != 0)
				{
				}
				num = (short)302500955;
				short num2 = num;
				num = (short)2097204315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095892992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140771328;
				if (num != 0)
				{
				}
				return this.<RadioStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)685933661;
				short num2 = num;
				num = (short)1986561117;
				switch (num2 == num)
				{
				}
				num = (short)1681260544;
				short num3 = num;
				num = (short)408551425;
				if (num != 0)
				{
				}
				num = (short)1391788032;
				if (num != 0)
				{
				}
				this.<RadioStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00023C60 File Offset: 0x00021E60
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00023D10 File Offset: 0x00021F10
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? LastJobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1264163776;
				short num2 = num;
				num = (short)5413824;
				switch (num2 == num)
				{
				}
				num = (short)624361472;
				short num3 = num;
				num = (short)1564147712;
				if (num != 0)
				{
				}
				num = (short)103809025;
				if (num != 0)
				{
				}
				return this.<LastJobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1269608286;
				short num2 = num;
				num = (short)1761652574;
				switch (num2 == num)
				{
				}
				num = (short)1372717056;
				short num3 = num;
				num = (short)746192897;
				if (num != 0)
				{
				}
				num = (short)1369047040;
				if (num != 0)
				{
				}
				this.<LastJobUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00023DC0 File Offset: 0x00021FC0
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00023E70 File Offset: 0x00022070
		[global::System.Runtime.Serialization.DataMember]
		public string Comments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2005183757;
				short num2 = num;
				num = (short)1983753485;
				switch (num2 == num)
				{
				}
				num = (short)1235877888;
				short num3 = num;
				num = (short)1327300609;
				if (num != 0)
				{
				}
				num = (short)569180160;
				if (num != 0)
				{
				}
				return this.<Comments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1893368011;
				short num2 = num;
				num = (short)1689485515;
				switch (num2 == num)
				{
				}
				num = (short)1440874496;
				short num3 = num;
				num = (short)1679818753;
				if (num != 0)
				{
				}
				num = (short)696975360;
				if (num != 0)
				{
				}
				this.<Comments>k__BackingField = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00023F20 File Offset: 0x00022120
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00023FD0 File Offset: 0x000221D0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? WorkingCodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)475854793;
				short num2 = num;
				num = (short)227801033;
				switch (num2 == num)
				{
				}
				num = (short)185270272;
				short num3 = num;
				num = (short)677511168;
				if (num != 0)
				{
				}
				num = (short)950468609;
				if (num != 0)
				{
				}
				return this.<WorkingCodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)192097677;
				short num2 = num;
				num = (short)821243277;
				switch (num2 == num)
				{
				}
				num = (short)201261056;
				short num3 = num;
				num = (short)1321795585;
				if (num != 0)
				{
				}
				num = (short)296157184;
				if (num != 0)
				{
				}
				this.<WorkingCodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00024084 File Offset: 0x00022284
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00024134 File Offset: 0x00022334
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CurrentCodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)741989899;
				short num2 = num;
				num = (short)1278205451;
				switch (num2 == num)
				{
				}
				num = (short)1325006848;
				short num3 = num;
				num = (short)368115712;
				if (num != 0)
				{
				}
				num = (short)1408696321;
				if (num != 0)
				{
				}
				return this.<CurrentCodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1947074561;
				if (num != 0)
				{
				}
				num = (short)1643479564;
				short num2 = num;
				num = (short)789807628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1059782656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)106233856;
				if (num != 0)
				{
				}
				this.<CurrentCodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000241E4 File Offset: 0x000223E4
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00024294 File Offset: 0x00022494
		[global::System.Runtime.Serialization.DataMember]
		public int? ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)410873161;
				short num2 = num;
				num = (short)353332553;
				switch (num2 == num)
				{
				}
				num = (short)1324941312;
				short num3 = num;
				num = (short)988938241;
				if (num != 0)
				{
				}
				num = (short)658178048;
				if (num != 0)
				{
				}
				return this.<ProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)964624385;
				if (num != 0)
				{
				}
				num = (short)1468839492;
				short num2 = num;
				num = (short)1525659204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)468058112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534459904;
				if (num != 0)
				{
				}
				this.<ProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00024344 File Offset: 0x00022544
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000243F8 File Offset: 0x000225F8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? RegionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)738851721;
				short num2 = num;
				num = (short)2124741513;
				switch (num2 == num)
				{
				}
				num = (short)1893859328;
				short num3 = num;
				num = (short)1418133505;
				if (num != 0)
				{
				}
				num = (short)987430912;
				if (num != 0)
				{
				}
				return this.<RegionName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1969790330;
				short num2 = num;
				num = (short)615357818;
				switch (num2 == num)
				{
				}
				num = (short)1728249856;
				short num3 = num;
				num = (short)1141702657;
				if (num != 0)
				{
				}
				num = (short)2102919168;
				if (num != 0)
				{
				}
				this.<RegionName>k__BackingField = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000244A8 File Offset: 0x000226A8
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00024558 File Offset: 0x00022758
		[global::System.Runtime.Serialization.DataMember]
		public string HardwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734014043;
				short num2 = num;
				num = (short)481424475;
				switch (num2 == num)
				{
				}
				num = (short)1671888896;
				short num3 = num;
				num = (short)1238630401;
				if (num != 0)
				{
				}
				num = (short)1074987008;
				if (num != 0)
				{
				}
				return this.<HardwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1958692016;
				short num2 = num;
				num = (short)311706800;
				switch (num2 == num)
				{
				}
				num = (short)1489567744;
				short num3 = num;
				num = (short)423034881;
				if (num != 0)
				{
				}
				num = (short)559874048;
				if (num != 0)
				{
				}
				this.<HardwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00024608 File Offset: 0x00022808
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000246B8 File Offset: 0x000228B8
		[global::System.Runtime.Serialization.DataMember]
		public long ReservedStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)575532616;
				short num2 = num;
				num = (short)154660424;
				switch (num2 == num)
				{
				}
				num = (short)1150418944;
				short num3 = num;
				num = (short)2092433408;
				if (num != 0)
				{
				}
				num = (short)676003841;
				if (num != 0)
				{
				}
				return this.<ReservedStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1525129171;
				short num2 = num;
				num = (short)1388617683;
				switch (num2 == num)
				{
				}
				num = (short)1095041024;
				short num3 = num;
				num = (short)1815805952;
				if (num != 0)
				{
				}
				num = (short)1556152321;
				if (num != 0)
				{
				}
				this.<ReservedStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00024768 File Offset: 0x00022968
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00024818 File Offset: 0x00022A18
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)523173889;
				if (num != 0)
				{
				}
				num = (short)1254765401;
				short num2 = num;
				num = (short)269038425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725759488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)364904448;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1772272781;
				short num2 = num;
				num = (short)1363524749;
				switch (num2 == num)
				{
				}
				num = (short)31326208;
				short num3 = num;
				num = (short)101122048;
				if (num != 0)
				{
				}
				num = (short)1255735297;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000248CC File Offset: 0x00022ACC
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00024978 File Offset: 0x00022B78
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? IPProgramSystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)361761877;
				short num2 = num;
				num = (short)307825749;
				switch (num2 == num)
				{
				}
				num = (short)433520640;
				short num3 = num;
				num = (short)1938227200;
				if (num != 0)
				{
				}
				num = (short)1809907713;
				if (num != 0)
				{
				}
				return this.<IPProgramSystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1371953553;
				short num2 = num;
				num = (short)105994641;
				switch (num2 == num)
				{
				}
				num = (short)2071920640;
				short num3 = num;
				num = (short)1151074304;
				if (num != 0)
				{
				}
				num = (short)857866241;
				if (num != 0)
				{
				}
				this.<IPProgramSystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00024A28 File Offset: 0x00022C28
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00024AD4 File Offset: 0x00022CD4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob> Jobs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2132138564;
				short num2 = num;
				num = (short)558094916;
				switch (num2 == num)
				{
				}
				num = (short)724238337;
				if (num != 0)
				{
				}
				num = (short)632684544;
				if (num != 0)
				{
				}
				num = (short)1777926144;
				short num3 = num;
				return this.<Jobs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1109903310;
				short num2 = num;
				num = (short)1875560398;
				switch (num2 == num)
				{
				}
				num = (short)248053761;
				if (num != 0)
				{
				}
				num = (short)1838088192;
				if (num != 0)
				{
				}
				num = (short)18022400;
				short num3 = num;
				this.<Jobs>k__BackingField = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00024B84 File Offset: 0x00022D84
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00024C34 File Offset: 0x00022E34
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> RadioFeatures
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2027380585;
				short num2 = num;
				num = (short)255876969;
				switch (num2 == num)
				{
				}
				num = (short)1712259073;
				if (num != 0)
				{
				}
				num = (short)257228800;
				if (num != 0)
				{
				}
				num = (short)697106432;
				short num3 = num;
				return this.<RadioFeatures>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)803405825;
				if (num != 0)
				{
				}
				num = (short)132106127;
				short num2 = num;
				num = (short)1423493007;
				switch (num2 == num)
				{
				}
				num = (short)2070675456;
				if (num != 0)
				{
				}
				num = (short)2011430912;
				short num3 = num;
				this.<RadioFeatures>k__BackingField = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00024CE4 File Offset: 0x00022EE4
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00024D90 File Offset: 0x00022F90
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Codeplug CurrentCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1862461527;
				short num2 = num;
				num = (short)442951767;
				switch (num2 == num)
				{
				}
				num = (short)1424818176;
				if (num != 0)
				{
				}
				num = (short)2110390273;
				if (num != 0)
				{
				}
				num = (short)946536448;
				short num3 = num;
				return this.<CurrentCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)176013166;
				short num2 = num;
				num = (short)1649524590;
				switch (num2 == num)
				{
				}
				num = (short)1965752321;
				if (num != 0)
				{
				}
				num = (short)1840709632;
				if (num != 0)
				{
				}
				num = (short)1314717696;
				short num3 = num;
				this.<CurrentCodeplug>k__BackingField = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00024E44 File Offset: 0x00023044
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00024EF8 File Offset: 0x000230F8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Codeplug WorkingCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)390379799;
				short num2 = num;
				num = (short)1872804119;
				switch (num2 == num)
				{
				}
				num = (short)1674182657;
				if (num != 0)
				{
				}
				num = (short)229703680;
				if (num != 0)
				{
				}
				num = (short)868679680;
				short num3 = num;
				return this.<WorkingCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1719333349;
				short num2 = num;
				num = (short)1954083301;
				switch (num2 == num)
				{
				}
				num = (short)1637154817;
				if (num != 0)
				{
				}
				num = (short)15073280;
				if (num != 0)
				{
				}
				num = (short)1691090944;
				short num3 = num;
				this.<WorkingCodeplug>k__BackingField = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00024FA8 File Offset: 0x000231A8
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00025058 File Offset: 0x00023258
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Group Group
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)652457565;
				short num2 = num;
				num = (short)1821292125;
				switch (num2 == num)
				{
				}
				num = (short)435814401;
				if (num != 0)
				{
				}
				num = (short)1151074304;
				if (num != 0)
				{
				}
				num = (short)908001280;
				short num3 = num;
				return this.<Group>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1746350930;
				short num2 = num;
				num = (short)790901586;
				switch (num2 == num)
				{
				}
				num = (short)250544128;
				if (num != 0)
				{
				}
				num = (short)1706426369;
				if (num != 0)
				{
				}
				num = (short)1817903104;
				short num3 = num;
				this.<Group>k__BackingField = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00025104 File Offset: 0x00023304
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000251B8 File Offset: 0x000233B8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob LastJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1690525427;
				short num2 = num;
				num = (short)812474099;
				switch (num2 == num)
				{
				}
				num = (short)825360384;
				if (num != 0)
				{
				}
				num = (short)986578945;
				if (num != 0)
				{
				}
				num = (short)1627193344;
				short num3 = num;
				return this.<LastJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)725554797;
				short num2 = num;
				num = (short)956765805;
				switch (num2 == num)
				{
				}
				num = (short)1855193089;
				if (num != 0)
				{
				}
				num = (short)2043543552;
				if (num != 0)
				{
				}
				num = (short)785317888;
				short num3 = num;
				this.<LastJob>k__BackingField = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00025268 File Offset: 0x00023468
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00025318 File Offset: 0x00023518
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem IPProgramSystem
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)673637658;
				short num2 = num;
				num = (short)1631514;
				switch (num2 == num)
				{
				}
				num = (short)856031233;
				if (num != 0)
				{
				}
				num = (short)587399168;
				if (num != 0)
				{
				}
				num = (short)1738473472;
				short num3 = num;
				return this.<IPProgramSystem>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)134186621;
				short num2 = num;
				num = (short)1402242685;
				switch (num2 == num)
				{
				}
				num = (short)1151598593;
				if (num != 0)
				{
				}
				num = (short)1793982464;
				if (num != 0)
				{
				}
				num = (short)999292928;
				short num3 = num;
				this.<IPProgramSystem>k__BackingField = value;
			}
		}
	}
}
