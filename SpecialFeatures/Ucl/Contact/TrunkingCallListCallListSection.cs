using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.HotList;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200020B RID: 523
	[global::System.Serializable]
	public sealed class TrunkingCallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060019FE RID: 6654 RVA: 0x00003D5E File Offset: 0x00001F5E
		internal TrunkingCallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.uclAstro25Trk_HomeSystemID_A00012.PointedField = this.uclAstro25Trk_CustomizedHomeSystemID_A00016;
			this.uclAstro25Trk_WACNID_A00011.PointedField = this.uclAstro25Trk_CustomizedWACNID_A00015;
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0022138C File Offset: 0x0021F58C
		public bool HasDiffs
		{
			get
			{
				short num = (short)757802359;
				short num2 = num;
				num = (short)1198728567;
				switch (num2 == num)
				{
				}
				num = (short)2071330816;
				short num3 = num;
				num = (short)1550188545;
				if (num != 0)
				{
				}
				num = (short)1710555136;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00221440 File Offset: 0x0021F640
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x002214F4 File Offset: 0x0021F6F4
		public int UclAstro25Trk_SystemAlias_A00010Value
		{
			get
			{
				short num = (short)1352247248;
				short num2 = num;
				num = (short)1664919504;
				switch (num2 == num)
				{
				}
				num = (short)28508160;
				short num3 = num;
				num = (short)1681195009;
				if (num != 0)
				{
				}
				num = (short)2018967552;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.Value;
			}
			set
			{
				short num = (short)1223991015;
				short num2 = num;
				num = (short)161324775;
				switch (num2 == num)
				{
				}
				num = (short)1115160576;
				short num3 = num;
				num = (short)82509825;
				if (num != 0)
				{
				}
				num = (short)704315392;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.Value = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x002215AC File Offset: 0x0021F7AC
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0022165C File Offset: 0x0021F85C
		public global::AcpBusinessLayer.AcpRecRefField UclAstro25Trk_SystemAlias_A00010Object
		{
			get
			{
				short num = (short)37153428;
				short num2 = num;
				num = (short)1353509524;
				switch (num2 == num)
				{
				}
				num = (short)826605568;
				short num3 = num;
				num = (short)1442250753;
				if (num != 0)
				{
				}
				num = (short)10158080;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010;
			}
			set
			{
				short num = (short)1479703454;
				short num2 = num;
				num = (short)1955167134;
				switch (num2 == num)
				{
				}
				num = (short)1825701888;
				short num3 = num;
				num = (short)583270400;
				if (num != 0)
				{
				}
				num = (short)1788870657;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010 = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0022170C File Offset: 0x0021F90C
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x002217C0 File Offset: 0x0021F9C0
		public string UclAstro25Trk_SystemAlias_A00010_UIValue
		{
			get
			{
				short num = (short)1293357731;
				short num2 = num;
				num = (short)1880167075;
				switch (num2 == num)
				{
				}
				num = (short)875495424;
				short num3 = num;
				num = (short)1109262337;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.UIValue;
			}
			set
			{
				short num = (short)1413283841;
				if (num != 0)
				{
				}
				num = (short)1196132154;
				short num2 = num;
				num = (short)797214522;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892089856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545797632;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.UIValue = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00221874 File Offset: 0x0021FA74
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x00221928 File Offset: 0x0021FB28
		public bool UclAstro25Trk_SystemAlias_A00010_Applicable
		{
			get
			{
				short num = (short)1884515090;
				short num2 = num;
				num = (short)2037934866;
				switch (num2 == num)
				{
				}
				num = (short)1322516480;
				short num3 = num;
				num = (short)146014209;
				if (num != 0)
				{
				}
				num = (short)1880883200;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.Applicable;
			}
			set
			{
				short num = (short)1355676814;
				short num2 = num;
				num = (short)686816398;
				switch (num2 == num)
				{
				}
				num = (short)1950416896;
				short num3 = num;
				num = (short)562823169;
				if (num != 0)
				{
				}
				num = (short)739639296;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.Applicable = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x002219DC File Offset: 0x0021FBDC
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x00221A90 File Offset: 0x0021FC90
		public bool UclAstro25Trk_SystemAlias_A00010_Editable
		{
			get
			{
				short num = (short)1259898996;
				short num2 = num;
				num = (short)315197556;
				switch (num2 == num)
				{
				}
				num = (short)826212352;
				short num3 = num;
				num = (short)150667264;
				if (num != 0)
				{
				}
				num = (short)1464467457;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.Editable;
			}
			set
			{
				short num = (short)1168906563;
				short num2 = num;
				num = (short)1073158467;
				switch (num2 == num)
				{
				}
				num = (short)1696530432;
				short num3 = num;
				num = (short)701038593;
				if (num != 0)
				{
				}
				num = (short)539820032;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.Editable = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00221B44 File Offset: 0x0021FD44
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x00221BF8 File Offset: 0x0021FDF8
		public bool UclAstro25Trk_SystemAlias_A00010_Visible
		{
			get
			{
				short num = (short)1805626080;
				short num2 = num;
				num = (short)426486496;
				switch (num2 == num)
				{
				}
				num = (short)1517289472;
				short num3 = num;
				num = (short)740753408;
				if (num != 0)
				{
				}
				num = (short)1396441089;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.Visible;
			}
			set
			{
				short num = (short)312672257;
				if (num != 0)
				{
				}
				num = (short)1493099957;
				short num2 = num;
				num = (short)534177205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)25559040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1585774592;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.Visible = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00221CAC File Offset: 0x0021FEAC
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x00221D60 File Offset: 0x0021FF60
		public bool UclAstro25Trk_SystemAlias_A00010_Valid
		{
			get
			{
				short num = (short)38884957;
				short num2 = num;
				num = (short)716592733;
				switch (num2 == num)
				{
				}
				num = (short)2119892992;
				short num3 = num;
				num = (short)1192296448;
				if (num != 0)
				{
				}
				num = (short)188678145;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.Valid;
			}
			set
			{
				short num = (short)1832517180;
				short num2 = num;
				num = (short)1169358396;
				switch (num2 == num)
				{
				}
				num = (short)1928069120;
				short num3 = num;
				num = (short)1722417152;
				if (num != 0)
				{
				}
				num = (short)1313275905;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_SystemAlias_A00010.Valid = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00221E18 File Offset: 0x00220018
		public bool UclAstro25Trk_SystemAlias_A00010_HasDiffs
		{
			get
			{
				short num = (short)1972928279;
				short num2 = num;
				num = (short)2016902935;
				switch (num2 == num)
				{
				}
				num = (short)20447232;
				short num3 = num;
				num = (short)945881089;
				if (num != 0)
				{
				}
				num = (short)1645674496;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010._HasDiffs;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00221ECC File Offset: 0x002200CC
		public int UclAstro25Trk_HomeSystemID_A00012Value
		{
			get
			{
				short num = (short)244798531;
				short num2 = num;
				num = (short)352408643;
				switch (num2 == num)
				{
				}
				num = (short)1355022336;
				short num3 = num;
				num = (short)649068545;
				if (num != 0)
				{
				}
				num = (short)1700003840;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.Value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00221F84 File Offset: 0x00220184
		public global::AcpBusinessLayer.AcpPointerField<int> UclAstro25Trk_HomeSystemID_A00012Object
		{
			get
			{
				short num = (short)1034979389;
				short num2 = num;
				num = (short)995919933;
				switch (num2 == num)
				{
				}
				num = (short)908460032;
				short num3 = num;
				num = (short)18153473;
				if (num != 0)
				{
				}
				num = (short)723714048;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00222034 File Offset: 0x00220234
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x002220E8 File Offset: 0x002202E8
		public string UclAstro25Trk_HomeSystemID_A00012_UIValue
		{
			get
			{
				short num = (short)1436871693;
				short num2 = num;
				num = (short)1701571597;
				switch (num2 == num)
				{
				}
				num = (short)1150812160;
				short num3 = num;
				num = (short)845021185;
				if (num != 0)
				{
				}
				num = (short)1981677568;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.UIValue;
			}
			set
			{
				short num = (short)1247839061;
				short num2 = num;
				num = (short)1488487253;
				switch (num2 == num)
				{
				}
				num = (short)2076049408;
				short num3 = num;
				num = (short)1463287809;
				if (num != 0)
				{
				}
				num = (short)262995968;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_HomeSystemID_A00012.UIValue = value;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x002221A0 File Offset: 0x002203A0
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00222254 File Offset: 0x00220454
		public bool UclAstro25Trk_HomeSystemID_A00012_Applicable
		{
			get
			{
				short num = (short)389399352;
				short num2 = num;
				num = (short)159499064;
				switch (num2 == num)
				{
				}
				num = (short)759365632;
				short num3 = num;
				num = (short)3538945;
				if (num != 0)
				{
				}
				num = (short)1705771008;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.Applicable;
			}
			set
			{
				short num = (short)75626335;
				short num2 = num;
				num = (short)1004533599;
				switch (num2 == num)
				{
				}
				num = (short)1302659072;
				short num3 = num;
				num = (short)288096257;
				if (num != 0)
				{
				}
				num = (short)431554560;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_HomeSystemID_A00012.Applicable = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00222308 File Offset: 0x00220508
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x002223C0 File Offset: 0x002205C0
		public bool UclAstro25Trk_HomeSystemID_A00012_Editable
		{
			get
			{
				short num = (short)1820119107;
				short num2 = num;
				num = (short)1849872451;
				switch (num2 == num)
				{
				}
				num = (short)1500381184;
				short num3 = num;
				num = (short)1048182785;
				if (num != 0)
				{
				}
				num = (short)1463484416;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.Editable;
			}
			set
			{
				short num = (short)909380987;
				short num2 = num;
				num = (short)1417350523;
				switch (num2 == num)
				{
				}
				num = (short)1032323072;
				short num3 = num;
				num = (short)1255407616;
				if (num != 0)
				{
				}
				num = (short)435224577;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_HomeSystemID_A00012.Editable = value;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00222478 File Offset: 0x00220678
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0022252C File Offset: 0x0022072C
		public bool UclAstro25Trk_HomeSystemID_A00012_Visible
		{
			get
			{
				short num = (short)1387551409;
				short num2 = num;
				num = (short)93870769;
				switch (num2 == num)
				{
				}
				num = (short)1348861952;
				short num3 = num;
				num = (short)1068761089;
				if (num != 0)
				{
				}
				num = (short)131727360;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.Visible;
			}
			set
			{
				short num = (short)1906739657;
				short num2 = num;
				num = (short)195791305;
				switch (num2 == num)
				{
				}
				num = (short)114294784;
				short num3 = num;
				num = (short)229900288;
				if (num != 0)
				{
				}
				num = (short)1968439297;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_HomeSystemID_A00012.Visible = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x002225E4 File Offset: 0x002207E4
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00222698 File Offset: 0x00220898
		public bool UclAstro25Trk_HomeSystemID_A00012_Valid
		{
			get
			{
				short num = (short)1377739611;
				short num2 = num;
				num = (short)1539613531;
				switch (num2 == num)
				{
				}
				num = (short)710606848;
				short num3 = num;
				num = (short)750780416;
				if (num != 0)
				{
				}
				num = (short)602931201;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012.Valid;
			}
			set
			{
				short num = (short)1372145469;
				short num2 = num;
				num = (short)2021803837;
				switch (num2 == num)
				{
				}
				num = (short)92930048;
				short num3 = num;
				num = (short)1100480513;
				if (num != 0)
				{
				}
				num = (short)7929856;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_HomeSystemID_A00012.Valid = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0022274C File Offset: 0x0022094C
		public bool UclAstro25Trk_HomeSystemID_A00012_HasDiffs
		{
			get
			{
				short num = (short)1138633839;
				short num2 = num;
				num = (short)251931759;
				switch (num2 == num)
				{
				}
				num = (short)1456734208;
				short num3 = num;
				num = (short)1209794561;
				if (num != 0)
				{
				}
				num = (short)569638912;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_HomeSystemID_A00012._HasDiffs;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00222800 File Offset: 0x00220A00
		public int UclAstro25Trk_WACNID_A00011Value
		{
			get
			{
				short num = (short)137141668;
				short num2 = num;
				num = (short)823172516;
				switch (num2 == num)
				{
				}
				num = (short)435224576;
				short num3 = num;
				num = (short)264962048;
				if (num != 0)
				{
				}
				num = (short)161218561;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_WACNID_A00011.Value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x002228B4 File Offset: 0x00220AB4
		public global::AcpBusinessLayer.AcpPointerField<int> UclAstro25Trk_WACNID_A00011Object
		{
			get
			{
				short num = (short)1648932455;
				short num2 = num;
				num = (short)1126413927;
				switch (num2 == num)
				{
				}
				num = (short)1515192320;
				short num3 = num;
				num = (short)1845821441;
				if (num != 0)
				{
				}
				num = (short)629735424;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_WACNID_A00011;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00222964 File Offset: 0x00220B64
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00222A18 File Offset: 0x00220C18
		public string UclAstro25Trk_WACNID_A00011_UIValue
		{
			get
			{
				short num = (short)673579009;
				if (num != 0)
				{
				}
				num = (short)716138201;
				short num2 = num;
				num = (short)1903650521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074921472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881852416;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_WACNID_A00011.UIValue;
			}
			set
			{
				short num = (short)796380872;
				short num2 = num;
				num = (short)1155845832;
				switch (num2 == num)
				{
				}
				num = (short)1341194240;
				if (num != 0)
				{
				}
				num = (short)821755905;
				if (num != 0)
				{
				}
				num = (short)156499968;
				short num3 = num;
				this.uclAstro25Trk_WACNID_A00011.UIValue = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00222AD0 File Offset: 0x00220CD0
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x00222B84 File Offset: 0x00220D84
		public bool UclAstro25Trk_WACNID_A00011_Applicable
		{
			get
			{
				short num = (short)1308158628;
				short num2 = num;
				num = (short)922020516;
				switch (num2 == num)
				{
				}
				num = (short)1631125505;
				if (num != 0)
				{
				}
				num = (short)633667584;
				if (num != 0)
				{
				}
				num = (short)1651769344;
				short num3 = num;
				return this.uclAstro25Trk_WACNID_A00011.Applicable;
			}
			set
			{
				short num = (short)462000989;
				short num2 = num;
				num = (short)1100452701;
				switch (num2 == num)
				{
				}
				num = (short)1574895617;
				if (num != 0)
				{
				}
				num = (short)1446051840;
				if (num != 0)
				{
				}
				num = (short)1209597952;
				short num3 = num;
				this.uclAstro25Trk_WACNID_A00011.Applicable = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00222C38 File Offset: 0x00220E38
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x00222CEC File Offset: 0x00220EEC
		public bool UclAstro25Trk_WACNID_A00011_Editable
		{
			get
			{
				short num = (short)850788353;
				if (num != 0)
				{
				}
				num = (short)2133486028;
				short num2 = num;
				num = (short)2020436428;
				switch (num2 == num)
				{
				}
				num = (short)1503985664;
				if (num != 0)
				{
				}
				num = (short)641597440;
				short num3 = num;
				return this.uclAstro25Trk_WACNID_A00011.Editable;
			}
			set
			{
				short num = (short)1783992751;
				short num2 = num;
				num = (short)1072468399;
				switch (num2 == num)
				{
				}
				num = (short)1700397057;
				if (num != 0)
				{
				}
				num = (short)520159232;
				if (num != 0)
				{
				}
				num = (short)163315712;
				short num3 = num;
				this.uclAstro25Trk_WACNID_A00011.Editable = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00222DA0 File Offset: 0x00220FA0
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x00222E54 File Offset: 0x00221054
		public bool UclAstro25Trk_WACNID_A00011_Visible
		{
			get
			{
				short num = (short)401460188;
				short num2 = num;
				num = (short)859884508;
				switch (num2 == num)
				{
				}
				num = (short)195887105;
				if (num != 0)
				{
				}
				num = (short)1429929984;
				if (num != 0)
				{
				}
				num = (short)745668608;
				short num3 = num;
				return this.uclAstro25Trk_WACNID_A00011.Visible;
			}
			set
			{
				short num = (short)374210561;
				if (num != 0)
				{
				}
				num = (short)940594832;
				short num2 = num;
				num = (short)393369232;
				switch (num2 == num)
				{
				}
				num = (short)2104557568;
				if (num != 0)
				{
				}
				num = (short)1598488576;
				short num3 = num;
				this.uclAstro25Trk_WACNID_A00011.Visible = value;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00222F0C File Offset: 0x0022110C
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x00222FC4 File Offset: 0x002211C4
		public bool UclAstro25Trk_WACNID_A00011_Valid
		{
			get
			{
				short num = (short)656539649;
				if (num != 0)
				{
				}
				num = (short)1103105660;
				short num2 = num;
				num = (short)1171787388;
				switch (num2 == num)
				{
				}
				num = (short)1465384960;
				if (num != 0)
				{
				}
				num = (short)1695416320;
				short num3 = num;
				return this.uclAstro25Trk_WACNID_A00011.Valid;
			}
			set
			{
				short num = (short)1676811581;
				short num2 = num;
				num = (short)991894845;
				switch (num2 == num)
				{
				}
				num = (short)2042101761;
				if (num != 0)
				{
				}
				num = (short)1970339840;
				if (num != 0)
				{
				}
				num = (short)1896808448;
				short num3 = num;
				this.uclAstro25Trk_WACNID_A00011.Valid = value;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00223078 File Offset: 0x00221278
		internal bool UclAstro25Trk_WACNID_A00011_HasDiffs
		{
			get
			{
				short num = (short)828196219;
				short num2 = num;
				num = (short)1894073723;
				switch (num2 == num)
				{
				}
				num = (short)985006080;
				if (num != 0)
				{
				}
				num = (short)346292225;
				if (num != 0)
				{
				}
				num = (short)647626752;
				short num3 = num;
				return this.uclAstro25Trk_WACNID_A00011._HasDiffs;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0022312C File Offset: 0x0022132C
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x002231E4 File Offset: 0x002213E4
		public int UclAstro25Trk_IndividualID_A00013Value
		{
			get
			{
				short num = (short)1501330442;
				short num2 = num;
				num = (short)903707658;
				switch (num2 == num)
				{
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				num = (short)1329987584;
				if (num != 0)
				{
				}
				num = (short)931856384;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.Value;
			}
			set
			{
				short num = (short)1313922190;
				short num2 = num;
				num = (short)1930943630;
				switch (num2 == num)
				{
				}
				num = (short)549257216;
				if (num != 0)
				{
				}
				num = (short)736296961;
				if (num != 0)
				{
				}
				num = (short)718995456;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.Value = value;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00223298 File Offset: 0x00221498
		public global::AcpBusinessLayer.AcpCustomRangeField UclAstro25Trk_IndividualID_A00013Object
		{
			get
			{
				short num = (short)287693495;
				short num2 = num;
				num = (short)1620564663;
				switch (num2 == num)
				{
				}
				num = (short)1946746880;
				if (num != 0)
				{
				}
				num = (short)711262209;
				if (num != 0)
				{
				}
				num = (short)1691287552;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0022334C File Offset: 0x0022154C
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00223400 File Offset: 0x00221600
		public string UclAstro25Trk_IndividualID_A00013_UIValue
		{
			get
			{
				short num = (short)1396310017;
				if (num != 0)
				{
				}
				num = (short)1656836828;
				short num2 = num;
				num = (short)2105758428;
				switch (num2 == num)
				{
				}
				num = (short)344719360;
				if (num != 0)
				{
				}
				num = (short)1881669632;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.UIValue;
			}
			set
			{
				short num = (short)797531185;
				short num2 = num;
				num = (short)684481585;
				switch (num2 == num)
				{
				}
				num = (short)386007041;
				if (num != 0)
				{
				}
				num = (short)331743232;
				if (num != 0)
				{
				}
				num = (short)2099642368;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.UIValue = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x002234B4 File Offset: 0x002216B4
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00223568 File Offset: 0x00221768
		public bool UclAstro25Trk_IndividualID_A00013_Applicable
		{
			get
			{
				short num = (short)1425183327;
				short num2 = num;
				num = (short)1614123615;
				switch (num2 == num)
				{
				}
				num = (short)34078721;
				if (num != 0)
				{
				}
				num = (short)742260736;
				if (num != 0)
				{
				}
				num = (short)1627848704;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.Applicable;
			}
			set
			{
				short num = (short)851911285;
				short num2 = num;
				num = (short)412754549;
				switch (num2 == num)
				{
				}
				num = (short)1158610945;
				if (num != 0)
				{
				}
				num = (short)1640235008;
				if (num != 0)
				{
				}
				num = (short)1999306752;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.Applicable = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0022361C File Offset: 0x0022181C
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x002236D4 File Offset: 0x002218D4
		public bool UclAstro25Trk_IndividualID_A00013_Editable
		{
			get
			{
				short num = (short)900190117;
				short num2 = num;
				num = (short)1926156197;
				switch (num2 == num)
				{
				}
				num = (short)1646788608;
				if (num != 0)
				{
				}
				num = (short)1948385281;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.Editable;
			}
			set
			{
				short num = (short)434211670;
				short num2 = num;
				num = (short)1635289942;
				switch (num2 == num)
				{
				}
				num = (short)1707868160;
				if (num != 0)
				{
				}
				num = (short)1850867713;
				if (num != 0)
				{
				}
				num = (short)780730368;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.Editable = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00223788 File Offset: 0x00221988
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0022383C File Offset: 0x00221A3C
		public bool UclAstro25Trk_IndividualID_A00013_Visible
		{
			get
			{
				short num = (short)425187495;
				short num2 = num;
				num = (short)1968822439;
				switch (num2 == num)
				{
				}
				num = (short)443482113;
				if (num != 0)
				{
				}
				num = (short)1610874880;
				if (num != 0)
				{
				}
				num = (short)1123549184;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.Visible;
			}
			set
			{
				short num = (short)457766203;
				short num2 = num;
				num = (short)721155387;
				switch (num2 == num)
				{
				}
				num = (short)615776256;
				if (num != 0)
				{
				}
				num = (short)940900353;
				if (num != 0)
				{
				}
				num = (short)688455680;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.Visible = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x002238F4 File Offset: 0x00221AF4
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x002239AC File Offset: 0x00221BAC
		public bool UclAstro25Trk_IndividualID_A00013_Valid
		{
			get
			{
				short num = (short)1504732100;
				short num2 = num;
				num = (short)1505911748;
				switch (num2 == num)
				{
				}
				num = (short)137953281;
				if (num != 0)
				{
				}
				num = (short)148176896;
				if (num != 0)
				{
				}
				num = (short)1638465536;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.Valid;
			}
			set
			{
				short num = (short)658249042;
				short num2 = num;
				num = (short)2077431122;
				switch (num2 == num)
				{
				}
				num = (short)244449281;
				if (num != 0)
				{
				}
				num = (short)1569783808;
				if (num != 0)
				{
				}
				num = (short)1027211264;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.Valid = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x00223A64 File Offset: 0x00221C64
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x00223B18 File Offset: 0x00221D18
		internal bool UclAstro25Trk_IndividualID_A00013_HiddenStatic
		{
			get
			{
				short num = (short)1511915521;
				if (num != 0)
				{
				}
				num = (short)105393688;
				short num2 = num;
				num = (short)713305624;
				switch (num2 == num)
				{
				}
				num = (short)1608384512;
				if (num != 0)
				{
				}
				num = (short)1168769024;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013.HiddenStatic;
			}
			set
			{
				short num = (short)1823070093;
				short num2 = num;
				num = (short)1335613325;
				switch (num2 == num)
				{
				}
				num = (short)1866792961;
				if (num != 0)
				{
				}
				num = (short)411500544;
				if (num != 0)
				{
				}
				num = (short)1976434688;
				short num3 = num;
				this.uclAstro25Trk_IndividualID_A00013.HiddenStatic = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00223BCC File Offset: 0x00221DCC
		public bool UclAstro25Trk_IndividualID_A00013_HasDiffs
		{
			get
			{
				short num = (short)8687979;
				short num2 = num;
				num = (short)572821867;
				switch (num2 == num)
				{
				}
				num = (short)177012736;
				if (num != 0)
				{
				}
				num = (short)1082654721;
				if (num != 0)
				{
				}
				num = (short)1563688960;
				short num3 = num;
				return this.uclAstro25Trk_IndividualID_A00013._HasDiffs;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00223C80 File Offset: 0x00221E80
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x00223D34 File Offset: 0x00221F34
		public string UclAstro25Trk_CombinedID_A00014Value
		{
			get
			{
				short num = (short)397774818;
				short num2 = num;
				num = (short)451514338;
				switch (num2 == num)
				{
				}
				num = (short)816381953;
				if (num != 0)
				{
				}
				num = (short)174063616;
				if (num != 0)
				{
				}
				num = (short)1781071872;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.Value;
			}
			set
			{
				short num = (short)341963221;
				short num2 = num;
				num = (short)208073173;
				switch (num2 == num)
				{
				}
				num = (short)258998273;
				if (num != 0)
				{
				}
				num = (short)136839168;
				if (num != 0)
				{
				}
				num = (short)1919156224;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.Value = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00223DEC File Offset: 0x00221FEC
		public global::AcpBusinessLayer.AcpKeyField UclAstro25Trk_CombinedID_A00014Object
		{
			get
			{
				short num = (short)1616146248;
				short num2 = num;
				num = (short)1317629768;
				switch (num2 == num)
				{
				}
				num = (short)383188993;
				if (num != 0)
				{
				}
				num = (short)1850474496;
				if (num != 0)
				{
				}
				num = (short)82378752;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00223E98 File Offset: 0x00222098
		public string UclAstro25Trk_CombinedID_A00014_UILabel
		{
			get
			{
				short num = (short)788611069;
				short num2 = num;
				num = (short)724647933;
				switch (num2 == num)
				{
				}
				num = (short)2007826433;
				if (num != 0)
				{
				}
				num = (short)785448960;
				if (num != 0)
				{
				}
				num = (short)2009661440;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.UIName;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00223F4C File Offset: 0x0022214C
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00224000 File Offset: 0x00222200
		public bool UclAstro25Trk_CombinedID_A00014_Applicable
		{
			get
			{
				short num = (short)1702248099;
				short num2 = num;
				num = (short)1950039715;
				switch (num2 == num)
				{
				}
				num = (short)708640768;
				if (num != 0)
				{
				}
				num = (short)1314455553;
				if (num != 0)
				{
				}
				num = (short)1452605440;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.Applicable;
			}
			set
			{
				short num = (short)1549426409;
				short num2 = num;
				num = (short)374169321;
				switch (num2 == num)
				{
				}
				num = (short)818872321;
				if (num != 0)
				{
				}
				num = (short)1201340416;
				if (num != 0)
				{
				}
				num = (short)1820524544;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.Applicable = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x002240B8 File Offset: 0x002222B8
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0022416C File Offset: 0x0022236C
		public bool UclAstro25Trk_CombinedID_A00014_Editable
		{
			get
			{
				short num = (short)1582289421;
				short num2 = num;
				num = (short)823382541;
				switch (num2 == num)
				{
				}
				num = (short)160169985;
				if (num != 0)
				{
				}
				num = (short)499974144;
				if (num != 0)
				{
				}
				num = (short)1984102400;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.Editable;
			}
			set
			{
				short num = (short)1860743785;
				short num2 = num;
				num = (short)1091351145;
				switch (num2 == num)
				{
				}
				num = (short)152633345;
				if (num != 0)
				{
				}
				num = (short)481492992;
				if (num != 0)
				{
				}
				num = (short)184549376;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.Editable = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00224220 File Offset: 0x00222420
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x002242D8 File Offset: 0x002224D8
		public bool UclAstro25Trk_CombinedID_A00014_Visible
		{
			get
			{
				short num = (short)985062423;
				short num2 = num;
				num = (short)598858775;
				switch (num2 == num)
				{
				}
				num = (short)1698430976;
				if (num != 0)
				{
				}
				num = (short)1027342337;
				if (num != 0)
				{
				}
				num = (short)1568604160;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.Visible;
			}
			set
			{
				short num = (short)301923088;
				short num2 = num;
				num = (short)1808268048;
				switch (num2 == num)
				{
				}
				num = (short)871104513;
				if (num != 0)
				{
				}
				num = (short)1554841600;
				if (num != 0)
				{
				}
				num = (short)1240072192;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.Visible = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00224390 File Offset: 0x00222590
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00224444 File Offset: 0x00222644
		internal bool UclAstro25Trk_CombinedID_A00014_HiddenStatic
		{
			get
			{
				short num = (short)59294463;
				short num2 = num;
				num = (short)2112996095;
				switch (num2 == num)
				{
				}
				num = (short)1215692801;
				if (num != 0)
				{
				}
				num = (short)584253440;
				if (num != 0)
				{
				}
				num = (short)1121058816;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.HiddenStatic;
			}
			set
			{
				short num = (short)1245221999;
				short num2 = num;
				num = (short)1688441967;
				switch (num2 == num)
				{
				}
				num = (short)1691090944;
				if (num != 0)
				{
				}
				num = (short)1646919681;
				if (num != 0)
				{
				}
				num = (short)384696320;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.HiddenStatic = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x002244F8 File Offset: 0x002226F8
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x002245B0 File Offset: 0x002227B0
		public bool UclAstro25Trk_CombinedID_A00014_Valid
		{
			get
			{
				short num = (short)1756163431;
				short num2 = num;
				num = (short)1757015399;
				switch (num2 == num)
				{
				}
				num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)1423900672;
				if (num != 0)
				{
				}
				num = (short)556859392;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014.Valid;
			}
			set
			{
				short num = (short)767098881;
				if (num != 0)
				{
				}
				num = (short)1784580199;
				short num2 = num;
				num = (short)1118799975;
				switch (num2 == num)
				{
				}
				num = (short)1785462784;
				if (num != 0)
				{
				}
				num = (short)1993998336;
				short num3 = num;
				this.uclAstro25Trk_CombinedID_A00014.Valid = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00224668 File Offset: 0x00222868
		public bool UclAstro25Trk_CombinedID_A00014_HasDiffs
		{
			get
			{
				short num = (short)9580972;
				short num2 = num;
				num = (short)182596012;
				switch (num2 == num)
				{
				}
				num = (short)64684033;
				if (num != 0)
				{
				}
				num = (short)1414856704;
				if (num != 0)
				{
				}
				num = (short)628293632;
				short num3 = num;
				return this.uclAstro25Trk_CombinedID_A00014._HasDiffs;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0022471C File Offset: 0x0022291C
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x002247D0 File Offset: 0x002229D0
		public int UclAstro25Trk_CustomizedWACNID_A00015Value
		{
			get
			{
				short num = (short)669179281;
				short num2 = num;
				num = (short)2007424401;
				switch (num2 == num)
				{
				}
				num = (short)1247608833;
				if (num != 0)
				{
				}
				num = (short)188088320;
				if (num != 0)
				{
				}
				num = (short)898629632;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Value;
			}
			set
			{
				short num = (short)330524184;
				short num2 = num;
				num = (short)419352;
				switch (num2 == num)
				{
				}
				num = (short)909246464;
				if (num != 0)
				{
				}
				num = (short)1449197569;
				if (num != 0)
				{
				}
				num = (short)226820096;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.Value = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x00224884 File Offset: 0x00222A84
		public global::AcpBusinessLayer.AcpRangeField<int, int> UclAstro25Trk_CustomizedWACNID_A00015Object
		{
			get
			{
				short num = (short)934903229;
				short num2 = num;
				num = (short)1459387837;
				switch (num2 == num)
				{
				}
				num = (short)1028980737;
				if (num != 0)
				{
				}
				num = (short)1744896000;
				if (num != 0)
				{
				}
				num = (short)369623040;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00224930 File Offset: 0x00222B30
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x002249E4 File Offset: 0x00222BE4
		public int UclAstro25Trk_CustomizedWACNID_A00015_UIValue
		{
			get
			{
				short num = (short)2064153429;
				short num2 = num;
				num = (short)969964373;
				switch (num2 == num)
				{
				}
				num = (short)2065104896;
				if (num != 0)
				{
				}
				num = (short)1604059137;
				if (num != 0)
				{
				}
				num = (short)627834880;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.UIValue;
			}
			set
			{
				short num = (short)1403909044;
				short num2 = num;
				num = (short)663090100;
				switch (num2 == num)
				{
				}
				num = (short)1854472193;
				if (num != 0)
				{
				}
				num = (short)1305214976;
				if (num != 0)
				{
				}
				num = (short)1470562304;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.UIValue = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00224A98 File Offset: 0x00222C98
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x00224B50 File Offset: 0x00222D50
		public string UclAstro25Trk_CustomizedWACNID_A00015_HexUIValue
		{
			get
			{
				short num = (short)631911107;
				short num2 = num;
				num = (short)1989030595;
				switch (num2 == num)
				{
				}
				num = (short)1995898880;
				if (num != 0)
				{
				}
				num = (short)757923841;
				if (num != 0)
				{
				}
				num = (short)1074724864;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.HexUIValue;
			}
			set
			{
				short num = (short)333185025;
				if (num != 0)
				{
				}
				num = (short)559876052;
				short num2 = num;
				num = (short)1449199572;
				switch (num2 == num)
				{
				}
				num = (short)572063744;
				if (num != 0)
				{
				}
				num = (short)1933049856;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.HexUIValue = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x00224C04 File Offset: 0x00222E04
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x00224CB4 File Offset: 0x00222EB4
		internal int UclAstro25Trk_CustomizedWACNID_A00015Min
		{
			get
			{
				short num = (short)1522544024;
				short num2 = num;
				num = (short)1322003864;
				switch (num2 == num)
				{
				}
				num = (short)1313603585;
				if (num != 0)
				{
				}
				num = (short)434241536;
				if (num != 0)
				{
				}
				num = (short)1850408960;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Min;
			}
			set
			{
				short num = (short)1527189755;
				short num2 = num;
				num = (short)1432490235;
				switch (num2 == num)
				{
				}
				num = (short)1579548673;
				if (num != 0)
				{
				}
				num = (short)60555264;
				if (num != 0)
				{
				}
				num = (short)97648640;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.Min = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00224D6C File Offset: 0x00222F6C
		// (set) Token: 0x06001A52 RID: 6738 RVA: 0x00224E24 File Offset: 0x00223024
		internal int UclAstro25Trk_CustomizedWACNID_A00015Max
		{
			get
			{
				short num = (short)1022960839;
				short num2 = num;
				num = (short)1311057095;
				switch (num2 == num)
				{
				}
				num = (short)981532673;
				if (num != 0)
				{
				}
				num = (short)808386560;
				if (num != 0)
				{
				}
				num = (short)736624640;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Max;
			}
			set
			{
				short num = (short)382360778;
				short num2 = num;
				num = (short)729308362;
				switch (num2 == num)
				{
				}
				num = (short)310444032;
				if (num != 0)
				{
				}
				num = (short)79101953;
				if (num != 0)
				{
				}
				num = (short)857669632;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.Max = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00224EDC File Offset: 0x002230DC
		// (set) Token: 0x06001A54 RID: 6740 RVA: 0x00224F90 File Offset: 0x00223190
		internal int UclAstro25Trk_CustomizedWACNID_A00015Step
		{
			get
			{
				short num = (short)2042499661;
				short num2 = num;
				num = (short)676205133;
				switch (num2 == num)
				{
				}
				num = (short)1324285953;
				if (num != 0)
				{
				}
				num = (short)2111635456;
				if (num != 0)
				{
				}
				num = (short)83427328;
				short num3 = num;
				return this.uclAstro25Trk_CustomizedWACNID_A00015.StepSize;
			}
			set
			{
				short num = (short)716299711;
				short num2 = num;
				num = (short)677830079;
				switch (num2 == num)
				{
				}
				num = (short)1020854272;
				if (num != 0)
				{
				}
				num = (short)704970753;
				if (num != 0)
				{
				}
				num = (short)836632576;
				short num3 = num;
				this.uclAstro25Trk_CustomizedWACNID_A00015.StepSize = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00225048 File Offset: 0x00223248
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x00225100 File Offset: 0x00223300
		public bool UclAstro25Trk_CustomizedWACNID_A00015_Applicable
		{
			get
			{
				short num = (short)1864331677;
				short num2 = num;
				num = (short)1816687005;
				switch (num2 == num)
				{
				}
				num = (short)342884353;
				if (num != 0)
				{
				}
				num = (short)1487273984;
				short num3 = num;
				num = (short)1605828608;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Applicable;
			}
			set
			{
				short num = (short)1193110275;
				short num2 = num;
				num = (short)980249347;
				switch (num2 == num)
				{
				}
				num = (short)38797313;
				if (num != 0)
				{
				}
				num = (short)1492844544;
				short num3 = num;
				num = (short)716505088;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.Applicable = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x002251B8 File Offset: 0x002233B8
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0022526C File Offset: 0x0022346C
		public bool UclAstro25Trk_CustomizedWACNID_A00015_Valid
		{
			get
			{
				short num = (short)527553874;
				short num2 = num;
				num = (short)1962399058;
				switch (num2 == num)
				{
				}
				num = (short)2137915392;
				if (num != 0)
				{
				}
				num = (short)1074593792;
				short num3 = num;
				num = (short)1529151489;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Valid;
			}
			set
			{
				short num = (short)1831691588;
				short num2 = num;
				num = (short)813000004;
				switch (num2 == num)
				{
				}
				num = (short)921829377;
				if (num != 0)
				{
				}
				num = (short)504430592;
				short num3 = num;
				num = (short)525074432;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.Valid = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00225324 File Offset: 0x00223524
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x002253D8 File Offset: 0x002235D8
		public bool UclAstro25Trk_CustomizedWACNID_A00015_Visible
		{
			get
			{
				short num = (short)879006271;
				short num2 = num;
				num = (short)1326879295;
				switch (num2 == num)
				{
				}
				num = (short)550699008;
				if (num != 0)
				{
				}
				num = (short)1282080768;
				short num3 = num;
				num = (short)1158348801;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Visible;
			}
			set
			{
				short num = (short)1864826948;
				short num2 = num;
				num = (short)1323565124;
				switch (num2 == num)
				{
				}
				num = (short)1489174529;
				if (num != 0)
				{
				}
				num = (short)2098659328;
				short num3 = num;
				num = (short)1060831232;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.Visible = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0022548C File Offset: 0x0022368C
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x00225540 File Offset: 0x00223740
		public bool UclAstro25Trk_CustomizedWACNID_A00015_Editable
		{
			get
			{
				short num = (short)367016953;
				short num2 = num;
				num = (short)176897017;
				switch (num2 == num)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				num = (short)138149888;
				short num3 = num;
				num = (short)398721025;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.Editable;
			}
			set
			{
				short num = (short)1777558715;
				short num2 = num;
				num = (short)40068283;
				switch (num2 == num)
				{
				}
				num = (short)332660736;
				if (num != 0)
				{
				}
				num = (short)37552128;
				short num3 = num;
				num = (short)2058944513;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.Editable = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x002255F8 File Offset: 0x002237F8
		internal string UclAstro25Trk_CustomizedWACNID_A00015_UILabel
		{
			get
			{
				short num = (short)759209779;
				short num2 = num;
				num = (short)191471411;
				switch (num2 == num)
				{
				}
				num = (short)1871511553;
				if (num != 0)
				{
				}
				num = (short)445317120;
				short num3 = num;
				num = (short)366608384;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.UIName;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x002256AC File Offset: 0x002238AC
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00225760 File Offset: 0x00223960
		internal bool UclAstro25Trk_CustomizedWACNID_A00015_HiddenStatic
		{
			get
			{
				short num = (short)1388961087;
				short num2 = num;
				num = (short)157277503;
				switch (num2 == num)
				{
				}
				num = (short)291241984;
				if (num != 0)
				{
				}
				num = (short)540278784;
				short num3 = num;
				num = (short)1420034049;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.HiddenStatic;
			}
			set
			{
				short num = (short)1190004439;
				short num2 = num;
				num = (short)106301143;
				switch (num2 == num)
				{
				}
				num = (short)1262878720;
				if (num != 0)
				{
				}
				num = (short)922091520;
				short num3 = num;
				num = (short)544866305;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.HiddenStatic = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00225818 File Offset: 0x00223A18
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x002258C8 File Offset: 0x00223AC8
		internal bool UclAstro25Trk_CustomizedWACNID_A00015_HiddenDynamic
		{
			get
			{
				short num = (short)1643781408;
				short num2 = num;
				num = (short)1872108832;
				switch (num2 == num)
				{
				}
				num = (short)706150400;
				if (num != 0)
				{
				}
				num = (short)1368129536;
				short num3 = num;
				num = (short)2128412673;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015.HiddenDynamic;
			}
			set
			{
				short num = (short)1354107521;
				short num2 = num;
				num = (short)1673726593;
				switch (num2 == num)
				{
				}
				num = (short)578879489;
				if (num != 0)
				{
				}
				num = (short)2102460416;
				short num3 = num;
				num = (short)19595264;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedWACNID_A00015.HiddenDynamic = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0022597C File Offset: 0x00223B7C
		public bool UclAstro25Trk_CustomizedWACNID_A00015_HasDiffs
		{
			get
			{
				short num = (short)2062755918;
				short num2 = num;
				num = (short)186198094;
				switch (num2 == num)
				{
				}
				num = (short)1294204929;
				if (num != 0)
				{
				}
				num = (short)857800704;
				short num3 = num;
				num = (short)695861248;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedWACNID_A00015._HasDiffs;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00225A30 File Offset: 0x00223C30
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x00225AE4 File Offset: 0x00223CE4
		public int UclAstro25Trk_CustomizedHomeSystemID_A00016Value
		{
			get
			{
				short num = (short)962527233;
				if (num != 0)
				{
				}
				num = (short)18577092;
				short num2 = num;
				num = (short)883979972;
				switch (num2 == num)
				{
				}
				num = (short)1792671744;
				short num3 = num;
				num = (short)1085865984;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Value;
			}
			set
			{
				short num = (short)2126340384;
				short num2 = num;
				num = (short)605511968;
				switch (num2 == num)
				{
				}
				num = (short)998965248;
				if (num != 0)
				{
				}
				num = (short)940572672;
				short num3 = num;
				num = (short)1373175809;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Value = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00225B98 File Offset: 0x00223D98
		public global::AcpBusinessLayer.AcpRangeField<int, int> UclAstro25Trk_CustomizedHomeSystemID_A00016Object
		{
			get
			{
				short num = (short)1023541249;
				if (num != 0)
				{
				}
				num = (short)985648992;
				short num2 = num;
				num = (short)259772256;
				switch (num2 == num)
				{
				}
				num = (short)276234240;
				short num3 = num;
				num = (short)412483584;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00225C44 File Offset: 0x00223E44
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00225CFC File Offset: 0x00223EFC
		public int UclAstro25Trk_CustomizedHomeSystemID_A00016_UIValue
		{
			get
			{
				short num = (short)466521605;
				short num2 = num;
				num = (short)239308293;
				switch (num2 == num)
				{
				}
				num = (short)159711233;
				if (num != 0)
				{
				}
				num = (short)18939904;
				short num3 = num;
				num = (short)2026307584;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.UIValue;
			}
			set
			{
				short num = (short)445047358;
				short num2 = num;
				num = (short)1891033662;
				switch (num2 == num)
				{
				}
				num = (short)845807617;
				if (num != 0)
				{
				}
				num = (short)60358656;
				short num3 = num;
				num = (short)386859008;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.UIValue = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00225DB0 File Offset: 0x00223FB0
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00225E64 File Offset: 0x00224064
		public string UclAstro25Trk_CustomizedHomeSystemID_A00016_HexUIValue
		{
			get
			{
				short num = (short)517341935;
				short num2 = num;
				num = (short)1364722415;
				switch (num2 == num)
				{
				}
				num = (short)329973760;
				if (num != 0)
				{
				}
				num = (short)1663238144;
				short num3 = num;
				num = (short)1267859457;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HexUIValue;
			}
			set
			{
				short num = (short)2119630849;
				if (num != 0)
				{
				}
				num = (short)400205563;
				short num2 = num;
				num = (short)1887872763;
				switch (num2 == num)
				{
				}
				num = (short)797966336;
				short num3 = num;
				num = (short)1116405760;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HexUIValue = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00225F18 File Offset: 0x00224118
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x00225FD0 File Offset: 0x002241D0
		internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Min
		{
			get
			{
				short num = (short)1530795946;
				short num2 = num;
				num = (short)616044458;
				switch (num2 == num)
				{
				}
				num = (short)1081802753;
				if (num != 0)
				{
				}
				num = (short)597884928;
				short num3 = num;
				num = (short)1499660288;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Min;
			}
			set
			{
				short num = (short)64880044;
				short num2 = num;
				num = (short)395574700;
				switch (num2 == num)
				{
				}
				num = (short)1761214465;
				if (num != 0)
				{
				}
				num = (short)354680832;
				short num3 = num;
				num = (short)1024393216;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Min = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00226084 File Offset: 0x00224284
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0022613C File Offset: 0x0022433C
		internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Max
		{
			get
			{
				short num = (short)527800213;
				short num2 = num;
				num = (short)1321768853;
				switch (num2 == num)
				{
				}
				num = (short)1001193472;
				if (num != 0)
				{
				}
				num = (short)523042816;
				short num3 = num;
				num = (short)1150681089;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Max;
			}
			set
			{
				short num = (short)1279832771;
				short num2 = num;
				num = (short)1538241219;
				switch (num2 == num)
				{
				}
				num = (short)27262977;
				if (num != 0)
				{
				}
				num = (short)1478885376;
				short num3 = num;
				num = (short)1934688256;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Max = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x002261F0 File Offset: 0x002243F0
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x002262A4 File Offset: 0x002244A4
		internal int UclAstro25Trk_CustomizedHomeSystemID_A00016Step
		{
			get
			{
				short num = (short)573563865;
				short num2 = num;
				num = (short)637330393;
				switch (num2 == num)
				{
				}
				num = (short)1934884864;
				if (num != 0)
				{
				}
				num = (short)530186240;
				short num3 = num;
				num = (short)2117861377;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.StepSize;
			}
			set
			{
				short num = (short)1227710119;
				short num2 = num;
				num = (short)530603687;
				switch (num2 == num)
				{
				}
				num = (short)493158400;
				if (num != 0)
				{
				}
				num = (short)2046099456;
				short num3 = num;
				num = (short)1152253953;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.StepSize = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00226358 File Offset: 0x00224558
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0022640C File Offset: 0x0022460C
		public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Applicable
		{
			get
			{
				short num = (short)1517324301;
				short num2 = num;
				num = (short)415205389;
				switch (num2 == num)
				{
				}
				num = (short)390594561;
				if (num != 0)
				{
				}
				num = (short)1450901504;
				short num3 = num;
				num = (short)882114560;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Applicable;
			}
			set
			{
				short num = (short)654427197;
				short num2 = num;
				num = (short)1483457597;
				switch (num2 == num)
				{
				}
				num = (short)1036779520;
				if (num != 0)
				{
				}
				num = (short)2054291456;
				short num3 = num;
				num = (short)2117599233;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Applicable = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x002264C4 File Offset: 0x002246C4
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x00226578 File Offset: 0x00224778
		public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Valid
		{
			get
			{
				short num = (short)1581318145;
				if (num != 0)
				{
				}
				num = (short)1676697164;
				short num2 = num;
				num = (short)1340890700;
				switch (num2 == num)
				{
				}
				num = (short)1828651008;
				short num3 = num;
				num = (short)1141178368;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Valid;
			}
			set
			{
				short num = (short)1354832693;
				short num2 = num;
				num = (short)1715018549;
				switch (num2 == num)
				{
				}
				num = (short)1547960321;
				if (num != 0)
				{
				}
				num = (short)870711296;
				short num3 = num;
				num = (short)2143027200;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Valid = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0022662C File Offset: 0x0022482C
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x002266E4 File Offset: 0x002248E4
		public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Visible
		{
			get
			{
				short num = (short)1342759384;
				short num2 = num;
				num = (short)572973528;
				switch (num2 == num)
				{
				}
				num = (short)1984430080;
				if (num != 0)
				{
				}
				num = (short)2018770944;
				short num3 = num;
				num = (short)607387649;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Visible;
			}
			set
			{
				short num = (short)831868059;
				short num2 = num;
				num = (short)22105243;
				switch (num2 == num)
				{
				}
				num = (short)1189478401;
				if (num != 0)
				{
				}
				num = (short)1764753408;
				short num3 = num;
				num = (short)1632829440;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Visible = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0022679C File Offset: 0x0022499C
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x00226850 File Offset: 0x00224A50
		public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_Editable
		{
			get
			{
				short num = (short)1664218189;
				short num2 = num;
				num = (short)342291533;
				switch (num2 == num)
				{
				}
				num = (short)102563840;
				if (num != 0)
				{
				}
				num = (short)1550974976;
				short num3 = num;
				num = (short)103219201;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Editable;
			}
			set
			{
				short num = (short)873218252;
				short num2 = num;
				num = (short)1168195788;
				switch (num2 == num)
				{
				}
				num = (short)866320385;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				short num3 = num;
				num = (short)392429568;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.Editable = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00226908 File Offset: 0x00224B08
		internal string UclAstro25Trk_CustomizedHomeSystemID_A00016_UILabel
		{
			get
			{
				short num = (short)159740179;
				short num2 = num;
				num = (short)1962176787;
				switch (num2 == num)
				{
				}
				num = (short)797638657;
				if (num != 0)
				{
				}
				num = (short)1836384256;
				short num3 = num;
				num = (short)1954217984;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.UIName;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x002269BC File Offset: 0x00224BBC
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x00226A70 File Offset: 0x00224C70
		internal bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HiddenStatic
		{
			get
			{
				short num = (short)608970174;
				short num2 = num;
				num = (short)765470142;
				switch (num2 == num)
				{
				}
				num = (short)172818432;
				if (num != 0)
				{
				}
				num = (short)563347456;
				short num3 = num;
				num = (short)931659777;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HiddenStatic;
			}
			set
			{
				short num = (short)1937440769;
				if (num != 0)
				{
				}
				num = (short)1864392123;
				short num2 = num;
				num = (short)1636654523;
				switch (num2 == num)
				{
				}
				num = (short)1180368896;
				short num3 = num;
				num = (short)261750784;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HiddenStatic = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x00226B28 File Offset: 0x00224D28
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x00226BDC File Offset: 0x00224DDC
		internal bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HiddenDynamic
		{
			get
			{
				short num = (short)1189020208;
				short num2 = num;
				num = (short)204276272;
				switch (num2 == num)
				{
				}
				num = (short)152633345;
				if (num != 0)
				{
				}
				num = (short)1048641536;
				short num3 = num;
				num = (short)1600847872;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HiddenDynamic;
			}
			set
			{
				short num = (short)204336419;
				short num2 = num;
				num = (short)938077475;
				switch (num2 == num)
				{
				}
				num = (short)651362305;
				if (num != 0)
				{
				}
				num = (short)77463552;
				short num3 = num;
				num = (short)489619456;
				if (num != 0)
				{
				}
				this.uclAstro25Trk_CustomizedHomeSystemID_A00016.HiddenDynamic = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00226C90 File Offset: 0x00224E90
		public bool UclAstro25Trk_CustomizedHomeSystemID_A00016_HasDiffs
		{
			get
			{
				short num = (short)1461472365;
				short num2 = num;
				num = (short)1951157357;
				switch (num2 == num)
				{
				}
				num = (short)1952907265;
				if (num != 0)
				{
				}
				num = (short)308543488;
				short num3 = num;
				num = (short)1346371584;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CustomizedHomeSystemID_A00016._HasDiffs;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00226D44 File Offset: 0x00224F44
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x00226DF8 File Offset: 0x00224FF8
		public bool IsHotListItem
		{
			get
			{
				short num = (short)181652720;
				short num2 = num;
				num = (short)1277807856;
				switch (num2 == num)
				{
				}
				num = (short)2101084161;
				if (num != 0)
				{
				}
				num = (short)1075511296;
				short num3 = num;
				num = (short)354287616;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_CombinedID_A00014.IsReferenced;
			}
			set
			{
				short num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)2108505693;
				short num2 = num;
				num = (short)1969307229;
				switch (num2 == num)
				{
				}
				num = (short)1348141056;
				short num3 = num;
				num = (short)1126760448;
				if (num != 0)
				{
				}
				this.isHotListItem.Value = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00226EB0 File Offset: 0x002250B0
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00226F64 File Offset: 0x00225164
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Applicable
		{
			get
			{
				short num = (short)2011824129;
				if (num != 0)
				{
				}
				num = (short)1735755992;
				short num2 = num;
				num = (short)124815576;
				switch (num2 == num)
				{
				}
				num = (short)1333460992;
				short num3 = num;
				num = (short)444858368;
				if (num != 0)
				{
				}
				return this.isHotListItem.Applicable;
			}
			set
			{
				short num = (short)471561957;
				short num2 = num;
				num = (short)554006245;
				switch (num2 == num)
				{
				}
				num = (short)826277888;
				if (num != 0)
				{
				}
				num = (short)1601044480;
				short num3 = num;
				num = (short)123863041;
				if (num != 0)
				{
				}
				this.isHotListItem.Applicable = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00227014 File Offset: 0x00225214
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x002270C8 File Offset: 0x002252C8
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Editable
		{
			get
			{
				short num = (short)667049524;
				short num2 = num;
				num = (short)2104712756;
				switch (num2 == num)
				{
				}
				num = (short)1318453248;
				if (num != 0)
				{
				}
				num = (short)270270464;
				short num3 = num;
				num = (short)616759297;
				if (num != 0)
				{
				}
				return this.isHotListItem.Editable;
			}
			set
			{
				short num = (short)1081737217;
				if (num != 0)
				{
				}
				num = (short)471656754;
				short num2 = num;
				num = (short)1773726002;
				switch (num2 == num)
				{
				}
				num = (short)1409286144;
				short num3 = num;
				num = (short)2049310720;
				if (num != 0)
				{
				}
				this.isHotListItem.Editable = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0022717C File Offset: 0x0022537C
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00227230 File Offset: 0x00225430
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Visible
		{
			get
			{
				short num = (short)1612712565;
				short num2 = num;
				num = (short)707594869;
				switch (num2 == num)
				{
				}
				num = (short)39059456;
				if (num != 0)
				{
				}
				num = (short)68026368;
				short num3 = num;
				num = (short)743899137;
				if (num != 0)
				{
				}
				return this.isHotListItem.Visible;
			}
			set
			{
				short num = (short)1167364367;
				short num2 = num;
				num = (short)156930319;
				switch (num2 == num)
				{
				}
				num = (short)2129657856;
				if (num != 0)
				{
				}
				num = (short)1513095168;
				short num3 = num;
				num = (short)123797505;
				if (num != 0)
				{
				}
				this.isHotListItem.Visible = value;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x002272E4 File Offset: 0x002254E4
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x00227398 File Offset: 0x00225598
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Valid
		{
			get
			{
				short num = (short)72207479;
				short num2 = num;
				num = (short)864144503;
				switch (num2 == num)
				{
				}
				num = (short)1014038529;
				if (num != 0)
				{
				}
				num = (short)550961152;
				short num3 = num;
				num = (short)432406528;
				if (num != 0)
				{
				}
				return this.isHotListItem.Valid;
			}
			set
			{
				short num = (short)284180891;
				short num2 = num;
				num = (short)1148928411;
				switch (num2 == num)
				{
				}
				num = (short)708247553;
				if (num != 0)
				{
				}
				num = (short)1998716928;
				short num3 = num;
				num = (short)2069561344;
				if (num != 0)
				{
				}
				this.isHotListItem.Valid = value;
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000265F File Offset: 0x0000085F
		internal TrunkingCallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00227450 File Offset: 0x00225650
		public override void Init()
		{
			int a_ = 12;
			short num = (short)133600961;
			short num2 = num;
			num = (short)127702721;
			switch (num2 == num)
			{
			}
			num = (short)1155989504;
			if (num != 0)
			{
			}
			num = (short)884473856;
			short num3 = num;
			num = (short)1732968449;
			if (num != 0)
			{
			}
			this.uclAstro25Trk_SystemAlias_A00010 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦풬\udcae얰횲\ud8b4햸튺\udcbc첾黀苂杻響﷌", a_), global::CommonResources.AppResources.System_Name, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID,
				global::CommonResources.AppResources.Customized_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.uclAstro25Trk_SystemAlias_A00010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_SystemAlias_A00010.DataTransferOrder = 1;
			this.uclAstro25Trk_SystemAlias_A00010.KeyNameField = true;
			this.uclAstro25Trk_HomeSystemID_A00012 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦슬슮풰체쒶춸\udeba킼藀鳂蓄杻﯊ﳌ﷎", a_), global::CommonResources.AppResources.System_ID, global::CommonResources.AppResources.Unassigned_ID);
			this.uclAstro25Trk_HomeSystemID_A00012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_HomeSystemID_A00012.KeyNameField = true;
			this.uclAstro25Trk_WACNID_A00011 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦ﲪﾰ者论趼达", a_), global::CommonResources.AppResources.RAS_WACN_ID, global::CommonResources.AppResources.Unassigned_ID);
			this.uclAstro25Trk_WACNID_A00011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_WACNID_A00011.KeyNameField = true;
			this.uclAstro25Trk_IndividualID_A00013 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦쎬쮮\ud8b0얲\udcb4펶첸\udaba톼藀鳂蓄杻﯊ﳌﳎ", a_), global::CommonResources.AppResources.Unit_ID, 0, 16777215, 1, global::CommonResources.AppResources.Unassigned_ID, null);
			this.uclAstro25Trk_IndividualID_A00013.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
			this.uclAstro25Trk_IndividualID_A00013.DataTransferOrder = 6;
			this.uclAstro25Trk_IndividualID_A00013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_IndividualID_A00013.KeyNameField = true;
			this.uclAstro25Trk_CombinedID_A00014 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦슬슮펰\udab2\udbb4튶\uddb8寮胀ￊ", a_), global::CommonResources.AppResources.Call_ID);
			this.uclAstro25Trk_CombinedID_A00014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_CombinedID_A00014.EvaluateRecRefs = true;
			this.uclAstro25Trk_CustomizedWACNID_A00015 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦\ud8ac\udcae얰\udcb2\ud8b4\udeb6쎸\udeba\ud9bc胀胂评軆跈铊賌ￎ", a_), global::CommonResources.AppResources.Custom_WACN_ID, 1, 1048574, 1);
			this.uclAstro25Trk_CustomizedWACNID_A00015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_CustomizedWACNID_A00015.DataTransferOrder = 2;
			this.uclAstro25Trk_CustomizedWACNID_A00015.ShowHexValue = true;
			this.uclAstro25Trk_CustomizedWACNID_A00015.KeyNameField = true;
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ풔궞钠힤첦\ud8ac\udcae얰\udcb2\ud8b4\udeb6쎸\udeba\ud9bc껀껂ꃄ铆냈룊만꫎볐髒釔裖飘탠헢", a_), global::CommonResources.AppResources.Custom_System_ID, 1, 65535, 1);
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.DataTransferOrder = 3;
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.ShowHexValue = true;
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.KeyNameField = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캎릘ꦚꢜ뾞톢키즦슨슪쎬좮醰者쒶", a_);
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_IDs;
			base.DataTransferOrder = 4;
			base.Id = 10402;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00227768 File Offset: 0x00225968
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)842234508;
			short num2 = num;
			num = (short)15366796;
			switch (num2 == num)
			{
			}
			num = (short)473235457;
			if (num != 0)
			{
			}
			num = (short)1487863808;
			short num3 = num;
			num = (short)1946353664;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0022781C File Offset: 0x00225A1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)74514444;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)775487508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_688;
				case 1:
					goto IL_4C9;
				case 2:
					this.uclAstro25Trk_WACNID_A00011 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮ﾧ羚袷誹費辽", a_), global::CommonResources.AppResources.RAS_WACN_ID, global::CommonResources.AppResources.Unassigned_ID);
					this.uclAstro25Trk_WACNID_A00011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_WACNID_A00011.KeyNameField = true;
					num = (short)144572435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮얩솫청\ud9af\udcb1톳튵ﺹﾽﳇ", a_)))
					{
						num = (short)575995911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_516;
				case 4:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮ﾧ羚袷誹費辽", a_)))
					{
						num = (short)1715142658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63B;
				case 5:
					goto IL_516;
				case 6:
					this.uclAstro25Trk_CustomizedWACNID_A00015 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮\udfa9\udfab\udaad\udfaf\udfb1\uddb3첵\uddb7\udeb9ﾽ莿賁跃苅韇诉ﳋﻍ", a_), global::CommonResources.AppResources.Custom_WACN_ID);
					this.uclAstro25Trk_CustomizedWACNID_A00015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_CustomizedWACNID_A00015.DataTransferOrder = 2;
					this.uclAstro25Trk_CustomizedWACNID_A00015.ShowHexValue = true;
					this.uclAstro25Trk_CustomizedWACNID_A00015.KeyNameField = true;
					num = (short)1290010625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1834942465;
					if (num != 0)
					{
					}
					this.uclAstro25Trk_CombinedID_A00014 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮얩솫청\ud9af\udcb1톳튵ﺹﾽﳇ", a_), global::CommonResources.AppResources.Call_ID);
					this.uclAstro25Trk_CombinedID_A00014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_CombinedID_A00014.EvaluateRecRefs = true;
					num = (short)1783824389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮ﮧ펩\udfab\udaad햯\udfb1\udab5톷\udbb9쾻膿劉韛", a_)))
					{
						num = (short)563019792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47B;
				case 9:
					goto IL_41B;
				case 10:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮\udfa9\udfab\udaad\udfaf\udfb1\uddb3첵\uddb7\udeb9ﾽ莿賁跃苅韇诉ﳋﻍ", a_)))
					{
						num = (short)922157062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C9;
				case 11:
					goto IL_5B5;
				case 12:
				{
					num = (short)82575360;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					continue;
				}
				case 13:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮\udfa9\udfab\udaad\udfaf\udfb1\uddb3첵\uddb7\udeb9톽궿ꟁ韃뿅믇뻉꧋ꏍ駏雑诓韕훟", a_)))
					{
						num = (short)1859256342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_688;
				case 14:
					goto IL_47B;
				case 15:
					this.uclAstro25Trk_HomeSystemID_A00012 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮얩솫쮭쮱잳습\uddb7ힹ諾龿菁﯉ﻋ", a_), global::CommonResources.AppResources.System_ID, global::CommonResources.AppResources.Unassigned_ID);
					this.uclAstro25Trk_HomeSystemID_A00012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_HomeSystemID_A00012.KeyNameField = true;
					num = (short)114622475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.uclAstro25Trk_SystemAlias_A00010 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮ﮧ펩\udfab\udaad햯\udfb1\udab5톷\udbb9쾻膿劉韛", a_), global::CommonResources.AppResources.System_Name, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID,
						global::CommonResources.AppResources.Customized_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.uclAstro25Trk_SystemAlias_A00010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_SystemAlias_A00010.DataTransferOrder = 1;
					this.uclAstro25Trk_SystemAlias_A00010.KeyNameField = true;
					num = (short)1768816654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.uclAstro25Trk_IndividualID_A00013 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮쒩좫잭욯\udbb1킳쎵\ud9b7횹諾龿菁﯉ￋ", a_), global::CommonResources.AppResources.Unit_ID, global::CommonResources.AppResources.Unassigned_ID, null);
					this.uclAstro25Trk_IndividualID_A00013.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
					this.uclAstro25Trk_IndividualID_A00013.DataTransferOrder = 6;
					this.uclAstro25Trk_IndividualID_A00013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_IndividualID_A00013.KeyNameField = true;
					num = (short)468844568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮쒩좫잭욯\udbb1킳쎵\ud9b7횹諾龿菁﯉ￋ", a_)))
					{
						num = (short)1648295953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_33C;
				case 19:
					goto IL_63B;
				case 20:
				{
					num = (short)1870008158;
					short num4 = num;
					num = (short)982388574;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B5;
					default:
						num = (short)1427439616;
						if (num != 0)
						{
						}
						num = (short)1355808776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 21:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮얩솫쮭쮱잳습\uddb7ힹ諾龿菁﯉ﻋ", a_)))
					{
						num = (short)208273423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F0;
				case 22:
					this.uclAstro25Trk_CustomizedHomeSystemID_A00016 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑꺛ꮝ킡쾣殮\udfa9\udfab\udaad\udfaf\udfb1\uddb3첵\uddb7\udeb9톽궿ꟁ韃뿅믇뻉꧋ꏍ駏雑诓韕훟", a_), global::CommonResources.AppResources.Custom_System_ID);
					this.uclAstro25Trk_CustomizedHomeSystemID_A00016.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25Trk_CustomizedHomeSystemID_A00016.DataTransferOrder = 3;
					this.uclAstro25Trk_CustomizedHomeSystemID_A00016.ShowHexValue = true;
					this.uclAstro25Trk_CustomizedHomeSystemID_A00016.KeyNameField = true;
					num = (short)527237129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)205586432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_33C;
				}
				IL_B9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1871511575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_33C:
				num = (short)1273233411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47B:
				num = (short)576520213;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C9:
				num = (short)1653866509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_516:
				num = (short)53084170;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F0:
				num = (short)1050017796;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B5:
				goto IL_5F0;
				IL_63B:
				num = (short)513474578;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_41B:
			IL_688:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춋ﶍﮓ뚕ꪗ꾙벛쪝튟힡쪣춥솧쒩쮫躭羚잳", a_);
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_IDs;
			base.DataTransferOrder = 4;
			base.Id = 10402;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00227EE4 File Offset: 0x002260E4
		public override void PopulateReferences()
		{
			short num = (short)1376452611;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.FeatureNode referencedNode;
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					this.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = trunkingSystem.General.TrkSysGeneralSystemID_A9239;
					this.UclAstro25Trk_WACNID_A00011Object.PointedField = trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205;
					num = (short)970719242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					this.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = this.UclAstro25Trk_CustomizedHomeSystemID_A00016Object;
					this.UclAstro25Trk_WACNID_A00011Object.PointedField = this.UclAstro25Trk_CustomizedWACNID_A00015Object;
					num = (short)120586245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.uclAstro25Trk_SystemAlias_A00010.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2064));
					num = (short)619380744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 4:
					if (this.UclAstro25Trk_SystemAlias_A00010Value == 65535)
					{
						num = (short)2097807361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1258815500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_B9;
				case 6:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						goto IL_2E2;
					}
					num = (short)996357828;
					short num3 = num;
					num = (short)2051290820;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30C;
					default:
					{
						num = (short)1087897600;
						if (num != 0)
						{
						}
						num = (short)1132199937;
						if (num != 0)
						{
						}
						num = (short)46923776;
						short num4 = num;
						num = (short)918814722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 7:
					if (referencedNode != null)
					{
						goto IL_30C;
					}
					goto IL_BE;
				case 8:
					goto IL_2E2;
				case 9:
					num = (short)1097007110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_BE;
				case 11:
					this.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = null;
					this.UclAstro25Trk_WACNID_A00011Object.PointedField = null;
					num = (short)1084555277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.UclAstro25Trk_SystemAlias_A00010Value == 0)
					{
						num = (short)289406987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_329;
				case 13:
					goto IL_16D;
				}
				IL_5C:
				if (base.ParentRecset != null)
				{
					num = (short)1949499401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2E2;
				IL_BE:
				num = (short)1968439300;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E2:
				referencedNode = this.UclAstro25Trk_SystemAlias_A00010Object.ReferencedNode;
				num = (short)1300692999;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30C:
				num = (short)749142016;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			IL_16D:
			IL_329:
			((global::AcpBusinessLayer.Recordset)base.ParentRecset).RefreshKeyForNode((global::AcpBusinessLayer.FeatureNode)base.Parent);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00228238 File Offset: 0x00226438
		public override void DropReferences()
		{
			short num = (short)77529088;
			short num2 = num;
			num = (short)2107988467;
			short num3 = num;
			num = (short)1047157235;
			switch (num3 == num)
			{
			}
			num = (short)1244790784;
			if (num != 0)
			{
			}
			num = (short)1077477377;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x002282E0 File Offset: 0x002264E0
		public override void SetConstraints()
		{
			short num = (short)1513619456;
			short num2 = num;
			num = (short)1652190551;
			short num3 = num;
			num = (short)974482775;
			switch (num3 == num)
			{
			}
			num = (short)225312769;
			if (num != 0)
			{
			}
			num = (short)1275527168;
			if (num != 0)
			{
			}
			this.uclAstro25Trk_SystemAlias_A00010.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conTrk25SystemAliasIsValid);
			this.uclAstro25Trk_WACNID_A00011.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conSetTrkSystemIDs);
			this.uclAstro25Trk_IndividualID_A00013.ValidateAcrossRecset = true;
			this.uclAstro25Trk_IndividualID_A00013.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsTrkIndividualIdValid);
			this.uclAstro25Trk_CustomizedWACNID_A00015.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsCustomizedAstro25System);
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsCustomizedAstro25System);
			this.uclAstro25Trk_WACNID_A00011.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsNotCustomizedAstro25System);
			this.uclAstro25Trk_WACNID_A00011.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclAstro25Trk_HomeSystemID_A00012.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsNotCustomizedAstro25System);
			this.uclAstro25Trk_HomeSystemID_A00012.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclAstro25Trk_CombinedID_A00014.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0022847C File Offset: 0x0022667C
		public override void SetupDependencies()
		{
			short num = (short)885194752;
			short num2 = num;
			num = (short)927989761;
			if (num != 0)
			{
			}
			num = (short)1095843261;
			short num3 = num;
			num = (short)1691499965;
			switch (num3 == num)
			{
			}
			num = (short)684457984;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList trunkingCallHotList = ((global::AcpCommonLib.FeatureManager.GetFeature(2208)[0] as global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotList).TrunkingCallHotList.EmbeddedRecset as global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset)[0] as global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList;
			this.uclAstro25Trk_SystemAlias_A00010.AddDependentObject(trunkingCallHotList.HotList.UclAstro25TrkHotList_CallID_a00038Object);
			this.uclAstro25Trk_CustomizedWACNID_A00015.AddDependentObject(trunkingCallHotList.HotList.UclAstro25TrkHotList_CallID_a00038Object);
			this.uclAstro25Trk_CustomizedHomeSystemID_A00016.AddDependentObject(trunkingCallHotList.HotList.UclAstro25TrkHotList_CallID_a00038Object);
			this.uclAstro25Trk_IndividualID_A00013.AddDependentObject(trunkingCallHotList.HotList.UclAstro25TrkHotList_CallID_a00038Object);
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x002285B4 File Offset: 0x002267B4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem TrkSysGeneralSystemType_A9252
		{
			get
			{
				short num = (short)583794688;
				short num2 = num;
				num = (short)1370882049;
				if (num != 0)
				{
				}
				num = (short)1279505025;
				short num3 = num;
				num = (short)1040298625;
				switch (num3 == num)
				{
				}
				num = (short)1578106880;
				if (num != 0)
				{
				}
				return this.uclAstro25Trk_SystemAlias_A00010.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00228670 File Offset: 0x00226870
		public void ResolveReferenceAfterUnpack()
		{
			short num = (short)478281728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)608632832;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_A1;
				}
				global::AcpBusinessLayer.AcpField<int> acpField;
				global::AcpBusinessLayer.AcpField<int> acpField2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_52:
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)1966997506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						IL_3D0:
						num = (short)440336397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (acpField != null)
						{
							num = (short)664535044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D5;
					case 3:
						goto IL_142;
					case 4:
						goto IL_1A3;
					case 5:
						return;
					case 6:
						num = (short)2062745615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (acpField2 == null)
						{
							num = (short)925368320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 8:
						if (acpField2 == 0)
						{
							num = (short)480444428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralSystemType_A9252Value == 3)
						{
							num = (short)1180368902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
						if (num4 >= trunkingSystemRecset.Count)
						{
							num = (short)947388421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = trunkingSystemRecset[num4];
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General)acpFeatureNode[10157];
						num = (short)28114953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_363;
					case 12:
						num = (short)986644494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralSystemID_A9239Value == acpField.Value)
						{
							num = (short)1044512771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					case 14:
						if (acpField == 0)
						{
							num = (short)624885771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					case 15:
					{
						num = (short)62324737;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralHomeWACNID_A8205Value == acpField2.Value)
						{
							num = (short)2011758593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					case 16:
						goto IL_25B;
					case 17:
						goto IL_25B;
					}
					goto IL_A1;
					IL_1A3:
					num = (short)903020552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num4++;
					num = (short)1387528209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25B:
					num = (short)771883018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D:
					num = (short)1576513126;
					short num5 = num;
					num = (short)1410838118;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D0;
					default:
					{
						num = (short)2076639232;
						if (num != 0)
						{
						}
						this.uclAstro25Trk_SystemAlias_A00010.DefaultValue = 65535;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
						num4 = 0;
						num = (short)162529296;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_142:
				this.uclAstro25Trk_SystemAlias_A00010.DefaultValue = acpFeatureNode.Parent.IndexOf(acpFeatureNode) + 1;
				return;
				IL_363:
				IL_3D5:
				this.uclAstro25Trk_SystemAlias_A00010.DefaultValue = 0;
				this.UclAstro25Trk_CustomizedWACNID_A00015Value = this.uclAstro25Trk_CustomizedWACNID_A00015.DefaultValue;
				this.UclAstro25Trk_CustomizedHomeSystemID_A00016Value = this.uclAstro25Trk_CustomizedHomeSystemID_A00016.DefaultValue;
				return;
				IL_A1:
				acpField2 = (global::AcpBusinessLayer.AcpField<int>)this.UclAstro25Trk_WACNID_A00011Object.PointedField;
				acpField = (global::AcpBusinessLayer.AcpField<int>)this.UclAstro25Trk_HomeSystemID_A00012Object.PointedField;
				num = (short)1366687751;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x04000CBB RID: 3259
		private global::AcpBusinessLayer.AcpRecRefField uclAstro25Trk_SystemAlias_A00010;

		// Token: 0x04000CBC RID: 3260
		private global::AcpBusinessLayer.AcpPointerField<int> uclAstro25Trk_HomeSystemID_A00012;

		// Token: 0x04000CBD RID: 3261
		private global::AcpBusinessLayer.AcpPointerField<int> uclAstro25Trk_WACNID_A00011;

		// Token: 0x04000CBE RID: 3262
		private global::AcpBusinessLayer.AcpCustomRangeField uclAstro25Trk_IndividualID_A00013;

		// Token: 0x04000CBF RID: 3263
		private global::AcpBusinessLayer.AcpKeyField uclAstro25Trk_CombinedID_A00014;

		// Token: 0x04000CC0 RID: 3264
		private global::AcpBusinessLayer.AcpRangeField<int, int> uclAstro25Trk_CustomizedWACNID_A00015;

		// Token: 0x04000CC1 RID: 3265
		private global::AcpBusinessLayer.AcpRangeField<int, int> uclAstro25Trk_CustomizedHomeSystemID_A00016;

		// Token: 0x04000CC2 RID: 3266
		private global::AcpBusinessLayer.AcpField<bool> isHotListItem;

		// Token: 0x0200020C RID: 524
		internal class UnassignedConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001A92 RID: 6802 RVA: 0x00228A84 File Offset: 0x00226C84
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num;
				object result;
				try
				{
					num = (short)357736860;
					short num2 = num;
					num = (short)229351836;
					switch (num2 == num)
					{
					}
					num = (short)2010644480;
					if (num != 0)
					{
					}
					result = ((int)value).ToString();
				}
				catch
				{
					result = string.Empty;
				}
				num = (short)1951596545;
				if (num != 0)
				{
				}
				num = (short)1572798464;
				short num3 = num;
				return result;
			}

			// Token: 0x06001A93 RID: 6803 RVA: 0x00228B58 File Offset: 0x00226D58
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num = (short)390987777;
				int num2 = (int)((global::System.IntPtr)num);
				int num5;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1049146347;
						short num3 = num;
						num = (short)9745387;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_183;
						default:
						{
							num = (short)1023868928;
							if (num != 0)
							{
							}
							num = (short)314572800;
							short num4 = num;
							num = (short)1579089921;
							if (num != 0)
							{
							}
							num = (short)907411459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 2:
						num = (short)2007957509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num5 <= 16777215)
						{
							num = (short)1878851586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
					case 4:
						goto IL_117;
					case 5:
						if (num5 >= 0)
						{
							num = (short)397672452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C;
					}
					IL_3C:
					if (!int.TryParse((string)value, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num5))
					{
						goto IL_183;
					}
					num = (short)809566208;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				return num5;
				IL_17C:
				return 0;
				IL_183:
				return 0;
			}
		}
	}
}
