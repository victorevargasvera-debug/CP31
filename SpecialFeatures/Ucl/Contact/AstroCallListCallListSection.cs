using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.HotList;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001F4 RID: 500
	[global::System.Serializable]
	public sealed class AstroCallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001802 RID: 6146 RVA: 0x00003C39 File Offset: 0x00001E39
		internal AstroCallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.uclAstroCnv_SystemGroupNumber_A00023.PointedField = this.uclAstroCnv_CustomizedSysGrpNumber_A00027;
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00207CD0 File Offset: 0x00205ED0
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00207D88 File Offset: 0x00205F88
		public int UclAstroCnv_SystemAlias_A00022Value
		{
			get
			{
				short num = (short)1757109714;
				short num2 = num;
				num = (short)274947538;
				switch (num2 == num)
				{
				}
				num = (short)1128595456;
				short num3 = num;
				num = (short)735444992;
				if (num != 0)
				{
				}
				num = (short)1139998721;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.Value;
			}
			set
			{
				short num = (short)1671309164;
				short num2 = num;
				num = (short)1747789676;
				switch (num2 == num)
				{
				}
				num = (short)1376714752;
				short num3 = num;
				num = (short)1732116480;
				if (num != 0)
				{
				}
				num = (short)1063190529;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.Value = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00207E3C File Offset: 0x0020603C
		public global::AcpBusinessLayer.AcpRecRefField UclAstroCnv_SystemAlias_A00022Object
		{
			get
			{
				short num = (short)744554497;
				if (num != 0)
				{
				}
				num = (short)299138714;
				short num2 = num;
				num = (short)1680244378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27262976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1789788160;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00207EEC File Offset: 0x002060EC
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x00207FA0 File Offset: 0x002061A0
		public string UclAstroCnv_SystemAlias_A00022_UIValue
		{
			get
			{
				short num = (short)674037761;
				if (num != 0)
				{
				}
				num = (short)1745363947;
				short num2 = num;
				num = (short)698622955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2137587712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029387776;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.UIValue;
			}
			set
			{
				short num = (short)1995180136;
				short num2 = num;
				num = (short)613681256;
				switch (num2 == num)
				{
				}
				num = (short)1685061632;
				short num3 = num;
				num = (short)1682767873;
				if (num != 0)
				{
				}
				num = (short)2128609280;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.UIValue = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00208054 File Offset: 0x00206254
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x00208108 File Offset: 0x00206308
		public bool UclAstroCnv_SystemAlias_A00022_Applicable
		{
			get
			{
				short num = (short)1667065743;
				short num2 = num;
				num = (short)1130588047;
				switch (num2 == num)
				{
				}
				num = (short)1411317760;
				short num3 = num;
				num = (short)929562625;
				if (num != 0)
				{
				}
				num = (short)1098711040;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.Applicable;
			}
			set
			{
				short num = (short)1050305205;
				short num2 = num;
				num = (short)141779637;
				switch (num2 == num)
				{
				}
				num = (short)450232320;
				short num3 = num;
				num = (short)641204224;
				if (num != 0)
				{
				}
				num = (short)1710620673;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.Applicable = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x002081BC File Offset: 0x002063BC
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00208270 File Offset: 0x00206470
		public bool UclAstroCnv_SystemAlias_A00022_Editable
		{
			get
			{
				short num = (short)1769668609;
				if (num != 0)
				{
				}
				num = (short)318508891;
				short num2 = num;
				num = (short)762777435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508297216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132593152;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.Editable;
			}
			set
			{
				short num = (short)1698627585;
				if (num != 0)
				{
				}
				num = (short)685960024;
				short num2 = num;
				num = (short)1533406040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093154304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494075904;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.Editable = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00208324 File Offset: 0x00206524
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x002083D8 File Offset: 0x002065D8
		public bool UclAstroCnv_SystemAlias_A00022_Visible
		{
			get
			{
				short num = (short)291111905;
				short num2 = num;
				num = (short)936444897;
				switch (num2 == num)
				{
				}
				num = (short)2020999168;
				short num3 = num;
				num = (short)462815233;
				if (num != 0)
				{
				}
				num = (short)2120876032;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.Visible;
			}
			set
			{
				short num = (short)85612980;
				short num2 = num;
				num = (short)1092180404;
				switch (num2 == num)
				{
				}
				num = (short)1653735424;
				short num3 = num;
				num = (short)754057217;
				if (num != 0)
				{
				}
				num = (short)604110848;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.Visible = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0020848C File Offset: 0x0020668C
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x00208540 File Offset: 0x00206740
		public bool UclAstroCnv_SystemAlias_A00022_Valid
		{
			get
			{
				short num = (short)1833570488;
				short num2 = num;
				num = (short)85987512;
				switch (num2 == num)
				{
				}
				num = (short)1154416640;
				short num3 = num;
				num = (short)848625665;
				if (num != 0)
				{
				}
				num = (short)435159040;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022.Valid;
			}
			set
			{
				short num = (short)1318212585;
				short num2 = num;
				num = (short)1408062441;
				switch (num2 == num)
				{
				}
				num = (short)1235025920;
				short num3 = num;
				num = (short)565510145;
				if (num != 0)
				{
				}
				num = (short)903938048;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemAlias_A00022.Valid = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x002085F8 File Offset: 0x002067F8
		public bool UclAstroCnv_SystemAlias_A00022_HasDiffs
		{
			get
			{
				short num = (short)17867541;
				short num2 = num;
				num = (short)782607125;
				switch (num2 == num)
				{
				}
				num = (short)952958976;
				short num3 = num;
				num = (short)2060189697;
				if (num != 0)
				{
				}
				num = (short)699531264;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemAlias_A00022._HasDiffs;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x002086AC File Offset: 0x002068AC
		public int UclAstroCnv_SystemGroupNumber_A00023Value
		{
			get
			{
				short num = (short)667090945;
				if (num != 0)
				{
				}
				num = (short)1072033719;
				short num2 = num;
				num = (short)2006052791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139001856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958150144;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.Value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00208760 File Offset: 0x00206960
		public global::AcpBusinessLayer.AcpPointerField<int> UclAstroCnv_SystemGroupNumber_A00023Object
		{
			get
			{
				short num = (short)604241921;
				if (num != 0)
				{
				}
				num = (short)572271156;
				short num2 = num;
				num = (short)1324624436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423376384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00208810 File Offset: 0x00206A10
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x002088C0 File Offset: 0x00206AC0
		public string UclAstroCnv_SystemGroupNumber_A00023_UIValue
		{
			get
			{
				short num = (short)892010497;
				if (num != 0)
				{
				}
				num = (short)1381584946;
				short num2 = num;
				num = (short)1918849074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1743454208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264437760;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.UIValue;
			}
			set
			{
				short num = (short)172449685;
				short num2 = num;
				num = (short)523919253;
				switch (num2 == num)
				{
				}
				num = (short)1146159104;
				short num3 = num;
				num = (short)1112211457;
				if (num != 0)
				{
				}
				num = (short)985333760;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemGroupNumber_A00023.UIValue = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00208974 File Offset: 0x00206B74
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x00208A2C File Offset: 0x00206C2C
		public bool UclAstroCnv_SystemGroupNumber_A00023_Applicable
		{
			get
			{
				short num = (short)909343619;
				short num2 = num;
				num = (short)1261075331;
				switch (num2 == num)
				{
				}
				num = (short)1336344576;
				short num3 = num;
				num = (short)557383680;
				if (num != 0)
				{
				}
				num = (short)1138556929;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.Applicable;
			}
			set
			{
				short num = (short)194053021;
				short num2 = num;
				num = (short)1594426269;
				switch (num2 == num)
				{
				}
				num = (short)252706816;
				short num3 = num;
				num = (short)369557505;
				if (num != 0)
				{
				}
				num = (short)2086469632;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemGroupNumber_A00023.Applicable = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00208AE0 File Offset: 0x00206CE0
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x00208B94 File Offset: 0x00206D94
		public bool UclAstroCnv_SystemGroupNumber_A00023_Editable
		{
			get
			{
				short num = (short)849059478;
				short num2 = num;
				num = (short)248028822;
				switch (num2 == num)
				{
				}
				num = (short)204341248;
				short num3 = num;
				num = (short)1704525825;
				if (num != 0)
				{
				}
				num = (short)1249902592;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.Editable;
			}
			set
			{
				short num = (short)1712980256;
				short num2 = num;
				num = (short)1235026208;
				switch (num2 == num)
				{
				}
				num = (short)1859256320;
				short num3 = num;
				num = (short)715587585;
				if (num != 0)
				{
				}
				num = (short)460390400;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemGroupNumber_A00023.Editable = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00208C48 File Offset: 0x00206E48
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00208CFC File Offset: 0x00206EFC
		public bool UclAstroCnv_SystemGroupNumber_A00023_Visible
		{
			get
			{
				short num = (short)2074615318;
				short num2 = num;
				num = (short)239607318;
				switch (num2 == num)
				{
				}
				num = (short)1571160064;
				short num3 = num;
				num = (short)1874198529;
				if (num != 0)
				{
				}
				num = (short)111935488;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.Visible;
			}
			set
			{
				short num = (short)1841611973;
				short num2 = num;
				num = (short)383632581;
				switch (num2 == num)
				{
				}
				num = (short)702939136;
				short num3 = num;
				num = (short)1272381440;
				if (num != 0)
				{
				}
				num = (short)768671745;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemGroupNumber_A00023.Visible = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00208DB0 File Offset: 0x00206FB0
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00208E64 File Offset: 0x00207064
		public bool UclAstroCnv_SystemGroupNumber_A00023_Valid
		{
			get
			{
				short num = (short)303506155;
				short num2 = num;
				num = (short)1936728811;
				switch (num2 == num)
				{
				}
				num = (short)1010827264;
				short num3 = num;
				num = (short)1425342465;
				if (num != 0)
				{
				}
				num = (short)10682368;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023.Valid;
			}
			set
			{
				short num = (short)1531576321;
				if (num != 0)
				{
				}
				num = (short)1630684694;
				short num2 = num;
				num = (short)479872534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)548012032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557790720;
				if (num != 0)
				{
				}
				this.uclAstroCnv_SystemGroupNumber_A00023.Valid = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00208F1C File Offset: 0x0020711C
		public bool UclAstroCnv_SystemGroupNumber_A00023_HasDiffs
		{
			get
			{
				short num = (short)878748348;
				short num2 = num;
				num = (short)1889903292;
				switch (num2 == num)
				{
				}
				num = (short)489816064;
				short num3 = num;
				num = (short)1183449088;
				if (num != 0)
				{
				}
				num = (short)1448345601;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_SystemGroupNumber_A00023._HasDiffs;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x00208FD0 File Offset: 0x002071D0
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x00209084 File Offset: 0x00207284
		public int UclAstroCnv_IndividualID_A00024Value
		{
			get
			{
				short num = (short)1515949042;
				short num2 = num;
				num = (short)1198361586;
				switch (num2 == num)
				{
				}
				num = (short)231079936;
				short num3 = num;
				num = (short)45154305;
				if (num != 0)
				{
				}
				num = (short)1705771008;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.Value;
			}
			set
			{
				short num = (short)388294286;
				short num2 = num;
				num = (short)2049369742;
				switch (num2 == num)
				{
				}
				num = (short)2048065536;
				short num3 = num;
				num = (short)1161494529;
				if (num != 0)
				{
				}
				num = (short)497287168;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.Value = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00209138 File Offset: 0x00207338
		public global::AcpBusinessLayer.AcpCustomRangeField UclAstroCnv_IndividualID_A00024Object
		{
			get
			{
				short num = (short)299598288;
				short num2 = num;
				num = (short)555647440;
				switch (num2 == num)
				{
				}
				num = (short)521338880;
				short num3 = num;
				num = (short)778633217;
				if (num != 0)
				{
				}
				num = (short)1112604672;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x002091E4 File Offset: 0x002073E4
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x00209298 File Offset: 0x00207498
		public string UclAstroCnv_IndividualID_A00024_UIValue
		{
			get
			{
				short num = (short)2079504809;
				short num2 = num;
				num = (short)1194047913;
				switch (num2 == num)
				{
				}
				num = (short)1588068352;
				short num3 = num;
				num = (short)913768449;
				if (num != 0)
				{
				}
				num = (short)1032781824;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.UIValue;
			}
			set
			{
				short num = (short)1236271105;
				if (num != 0)
				{
				}
				num = (short)969906514;
				short num2 = num;
				num = (short)70883666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1999175680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151584768;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.UIValue = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00209350 File Offset: 0x00207550
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x00209404 File Offset: 0x00207604
		public bool UclAstroCnv_IndividualID_A00024_Applicable
		{
			get
			{
				short num = (short)2066524765;
				short num2 = num;
				num = (short)431729245;
				switch (num2 == num)
				{
				}
				num = (short)1923678208;
				short num3 = num;
				num = (short)1924005888;
				if (num != 0)
				{
				}
				num = (short)1174536193;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.Applicable;
			}
			set
			{
				short num = (short)1037245428;
				short num2 = num;
				num = (short)2076777460;
				switch (num2 == num)
				{
				}
				num = (short)351928320;
				short num3 = num;
				num = (short)2094465025;
				if (num != 0)
				{
				}
				num = (short)1790967808;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.Applicable = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x002094BC File Offset: 0x002076BC
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x00209574 File Offset: 0x00207774
		public bool UclAstroCnv_IndividualID_A00024_Editable
		{
			get
			{
				short num = (short)1839464703;
				short num2 = num;
				num = (short)1380385023;
				switch (num2 == num)
				{
				}
				num = (short)435748864;
				short num3 = num;
				num = (short)2092892161;
				if (num != 0)
				{
				}
				num = (short)297926656;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.Editable;
			}
			set
			{
				short num = (short)693162039;
				short num2 = num;
				num = (short)509464631;
				switch (num2 == num)
				{
				}
				num = (short)615383040;
				short num3 = num;
				num = (short)432734209;
				if (num != 0)
				{
				}
				num = (short)349831168;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.Editable = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00209628 File Offset: 0x00207828
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x002096E0 File Offset: 0x002078E0
		public bool UclAstroCnv_IndividualID_A00024_Visible
		{
			get
			{
				short num = (short)1148631025;
				short num2 = num;
				num = (short)1167308785;
				switch (num2 == num)
				{
				}
				num = (short)1697316864;
				short num3 = num;
				num = (short)2131623937;
				if (num != 0)
				{
				}
				num = (short)345309184;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.Visible;
			}
			set
			{
				short num = (short)81074223;
				short num2 = num;
				num = (short)436869167;
				switch (num2 == num)
				{
				}
				num = (short)630325248;
				short num3 = num;
				num = (short)1462632449;
				if (num != 0)
				{
				}
				num = (short)895942656;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.Visible = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00209794 File Offset: 0x00207994
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00209848 File Offset: 0x00207A48
		internal bool UclAstroCnv_IndividualID_A00024_HiddenStatic
		{
			get
			{
				short num = (short)580124673;
				if (num != 0)
				{
				}
				num = (short)1159913844;
				short num2 = num;
				num = (short)449306996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433127424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332529664;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.HiddenStatic;
			}
			set
			{
				short num = (short)345107486;
				short num2 = num;
				num = (short)1943006238;
				switch (num2 == num)
				{
				}
				num = (short)301268992;
				short num3 = num;
				num = (short)1311178752;
				if (num != 0)
				{
				}
				num = (short)415760385;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.HiddenStatic = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x002098FC File Offset: 0x00207AFC
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x002099AC File Offset: 0x00207BAC
		public bool UclAstroCnv_IndividualID_A00024_Valid
		{
			get
			{
				short num = (short)1072889856;
				short num2 = num;
				num = (short)660013057;
				if (num != 0)
				{
				}
				num = (short)1593668067;
				short num3 = num;
				num = (short)1330213347;
				switch (num3 == num)
				{
				}
				num = (short)2111897600;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024.Valid;
			}
			set
			{
				short num = (short)874643456;
				short num2 = num;
				num = (short)1408789473;
				short num3 = num;
				num = (short)88108001;
				switch (num3 == num)
				{
				}
				num = (short)538968065;
				if (num != 0)
				{
				}
				num = (short)454426624;
				if (num != 0)
				{
				}
				this.uclAstroCnv_IndividualID_A00024.Valid = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00209A64 File Offset: 0x00207C64
		public bool UclAstroCnv_IndividualID_A00024_HasDiffs
		{
			get
			{
				short num = (short)90570752;
				short num2 = num;
				num = (short)68135327;
				short num3 = num;
				num = (short)1888266655;
				switch (num3 == num)
				{
				}
				num = (short)1873281025;
				if (num != 0)
				{
				}
				num = (short)1632632832;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_IndividualID_A00024._HasDiffs;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00209B1C File Offset: 0x00207D1C
		public global::AcpBusinessLayer.AcpListField UclAstroCnv_ListinfoCallType_A00025Object
		{
			get
			{
				short num = (short)1849163776;
				short num2 = num;
				num = (short)819364685;
				short num3 = num;
				num = (short)1175028557;
				switch (num3 == num)
				{
				}
				num = (short)580583425;
				if (num != 0)
				{
				}
				num = (short)200998912;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00209BCC File Offset: 0x00207DCC
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00209C84 File Offset: 0x00207E84
		public int UclAstroCnv_ListinfoCallType_A00025Value
		{
			get
			{
				short num = (short)907542528;
				short num2 = num;
				num = (short)644213459;
				short num3 = num;
				num = (short)841804499;
				switch (num3 == num)
				{
				}
				num = (short)2055471105;
				if (num != 0)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.Value;
			}
			set
			{
				short num = (short)54263808;
				short num2 = num;
				num = (short)654265292;
				short num3 = num;
				num = (short)1841843148;
				switch (num3 == num)
				{
				}
				num = (short)773849089;
				if (num != 0)
				{
				}
				num = (short)2105344000;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.Value = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00209D3C File Offset: 0x00207F3C
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00209DF0 File Offset: 0x00207FF0
		public string UclAstroCnv_ListinfoCallType_A00025_UIValue
		{
			get
			{
				short num = (short)158597120;
				short num2 = num;
				num = (short)342098149;
				short num3 = num;
				num = (short)1760428261;
				switch (num3 == num)
				{
				}
				num = (short)1522270209;
				if (num != 0)
				{
				}
				num = (short)1239547904;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.UIValue;
			}
			set
			{
				short num = (short)636354560;
				short num2 = num;
				num = (short)977025637;
				short num3 = num;
				num = (short)104413797;
				switch (num3 == num)
				{
				}
				num = (short)1393950720;
				if (num != 0)
				{
				}
				num = (short)1727004673;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.UIValue = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00209EA4 File Offset: 0x002080A4
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00209F58 File Offset: 0x00208158
		[global::System.ComponentModel.Browsable(false)]
		public bool UclAstroCnv_ListinfoCallType_A00025_Applicable
		{
			get
			{
				short num = (short)1658716160;
				short num2 = num;
				num = (short)238513774;
				short num3 = num;
				num = (short)461598318;
				switch (num3 == num)
				{
				}
				num = (short)1929773056;
				if (num != 0)
				{
				}
				num = (short)457834497;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.Applicable;
			}
			set
			{
				short num = (short)1470431232;
				short num2 = num;
				num = (short)1690694858;
				short num3 = num;
				num = (short)1527182538;
				switch (num3 == num)
				{
				}
				num = (short)1368391681;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.Applicable = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0020A010 File Offset: 0x00208210
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0020A0C4 File Offset: 0x002082C4
		[global::System.ComponentModel.Browsable(false)]
		public bool UclAstroCnv_ListinfoCallType_A00025_Editable
		{
			get
			{
				short num = (short)2031091712;
				short num2 = num;
				num = (short)1501907961;
				short num3 = num;
				num = (short)1184320505;
				switch (num3 == num)
				{
				}
				num = (short)1446969344;
				if (num != 0)
				{
				}
				num = (short)724828161;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.Editable;
			}
			set
			{
				short num = (short)1571160064;
				short num2 = num;
				num = (short)2022068873;
				short num3 = num;
				num = (short)1088115337;
				switch (num3 == num)
				{
				}
				num = (short)1007288321;
				if (num != 0)
				{
				}
				num = (short)1776091136;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.Editable = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0020A178 File Offset: 0x00208378
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0020A230 File Offset: 0x00208430
		[global::System.ComponentModel.Browsable(false)]
		public bool UclAstroCnv_ListinfoCallType_A00025_Visible
		{
			get
			{
				short num = (short)1906704384;
				short num2 = num;
				num = (short)316669953;
				if (num != 0)
				{
				}
				num = (short)1597943666;
				short num3 = num;
				num = (short)1838133106;
				switch (num3 == num)
				{
				}
				num = (short)704118784;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.Visible;
			}
			set
			{
				short num = (short)118030336;
				short num2 = num;
				num = (short)2094018106;
				short num3 = num;
				num = (short)934686266;
				switch (num3 == num)
				{
				}
				num = (short)384499712;
				if (num != 0)
				{
				}
				num = (short)1577975809;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.Visible = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0020A2E4 File Offset: 0x002084E4
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0020A398 File Offset: 0x00208598
		[global::System.ComponentModel.Browsable(false)]
		public bool UclAstroCnv_ListinfoCallType_A00025_Valid
		{
			get
			{
				short num = (short)835387392;
				short num2 = num;
				num = (short)2145501422;
				short num3 = num;
				num = (short)626114798;
				switch (num3 == num)
				{
				}
				num = (short)1482293248;
				if (num != 0)
				{
				}
				num = (short)940179457;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025.Valid;
			}
			set
			{
				short num = (short)93454336;
				short num2 = num;
				num = (short)1858034866;
				short num3 = num;
				num = (short)1401314482;
				switch (num3 == num)
				{
				}
				num = (short)386859009;
				if (num != 0)
				{
				}
				num = (short)78381056;
				if (num != 0)
				{
				}
				this.uclAstroCnv_ListinfoCallType_A00025.Valid = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0020A450 File Offset: 0x00208650
		public bool UclAstroCnv_ListinfoCallType_A00025_HasDiffs
		{
			get
			{
				short num = (short)954728448;
				short num2 = num;
				num = (short)1008929110;
				short num3 = num;
				num = (short)1842088278;
				switch (num3 == num)
				{
				}
				num = (short)1841299457;
				if (num != 0)
				{
				}
				num = (short)1776353280;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_ListinfoCallType_A00025._HasDiffs;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0020A504 File Offset: 0x00208704
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0020A5BC File Offset: 0x002087BC
		public string UclAstroCnv_CallID_A00026Value
		{
			get
			{
				short num = (short)289734656;
				short num2 = num;
				num = (short)1326234069;
				short num3 = num;
				num = (short)1876670933;
				switch (num3 == num)
				{
				}
				num = (short)1531969537;
				if (num != 0)
				{
				}
				num = (short)1811939328;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.Value;
			}
			set
			{
				short num = (short)1184825344;
				short num2 = num;
				num = (short)1713045760;
				short num3 = num;
				num = (short)2019557632;
				switch (num3 == num)
				{
				}
				num = (short)2037252096;
				if (num != 0)
				{
				}
				num = (short)1524105217;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.Value = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0020A670 File Offset: 0x00208870
		public global::AcpBusinessLayer.AcpKeyField UclAstroCnv_CallID_A00026Object
		{
			get
			{
				short num = (short)1494089728;
				short num2 = num;
				num = (short)643023442;
				short num3 = num;
				num = (short)133153362;
				switch (num3 == num)
				{
				}
				num = (short)256835585;
				if (num != 0)
				{
				}
				num = (short)1619329024;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x0020A720 File Offset: 0x00208920
		public string UclAstroCnv_CallID_A00026_UILabel
		{
			get
			{
				short num = (short)498794496;
				short num2 = num;
				num = (short)2004927698;
				short num3 = num;
				num = (short)303940818;
				switch (num3 == num)
				{
				}
				num = (short)1903362049;
				if (num != 0)
				{
				}
				num = (short)1346240512;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.UIName;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x0020A7D4 File Offset: 0x002089D4
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x0020A884 File Offset: 0x00208A84
		public bool UclAstroCnv_CallID_A00026_Applicable
		{
			get
			{
				short num = (short)1668874240;
				short num2 = num;
				num = (short)431478467;
				short num3 = num;
				num = (short)822728387;
				switch (num3 == num)
				{
				}
				num = (short)881393665;
				if (num != 0)
				{
				}
				num = (short)1180237824;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.Applicable;
			}
			set
			{
				short num = (short)467730432;
				short num2 = num;
				num = (short)138684620;
				short num3 = num;
				num = (short)1459693772;
				switch (num3 == num)
				{
				}
				num = (short)1331691520;
				if (num != 0)
				{
				}
				num = (short)415760385;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.Applicable = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x0020A93C File Offset: 0x00208B3C
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0020A9F4 File Offset: 0x00208BF4
		public bool UclAstroCnv_CallID_A00026_Editable
		{
			get
			{
				short num = (short)364969984;
				short num2 = num;
				num = (short)1334405512;
				short num3 = num;
				num = (short)961046920;
				switch (num3 == num)
				{
				}
				num = (short)371654656;
				if (num != 0)
				{
				}
				num = (short)697630721;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.Editable;
			}
			set
			{
				short num = (short)995753984;
				short num2 = num;
				num = (short)1306020407;
				short num3 = num;
				num = (short)1922779703;
				switch (num3 == num)
				{
				}
				num = (short)1185939457;
				if (num != 0)
				{
				}
				num = (short)94437376;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.Editable = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0020AAA8 File Offset: 0x00208CA8
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0020AB60 File Offset: 0x00208D60
		public bool UclAstroCnv_CallID_A00026_Visible
		{
			get
			{
				short num = (short)311689216;
				short num2 = num;
				num = (short)1722007649;
				short num3 = num;
				num = (short)757973089;
				switch (num3 == num)
				{
				}
				num = (short)1403715585;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.Visible;
			}
			set
			{
				short num = (short)642318336;
				short num2 = num;
				num = (short)1971873370;
				short num3 = num;
				num = (short)1260414554;
				switch (num3 == num)
				{
				}
				num = (short)873922561;
				if (num != 0)
				{
				}
				num = (short)229244928;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.Visible = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0020AC18 File Offset: 0x00208E18
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0020ACCC File Offset: 0x00208ECC
		internal bool UclAstroCnv_CallID_A00026_HiddenStatic
		{
			get
			{
				short num = (short)1885601792;
				short num2 = num;
				num = (short)1403664372;
				short num3 = num;
				num = (short)327235572;
				switch (num3 == num)
				{
				}
				num = (short)879558657;
				if (num != 0)
				{
				}
				num = (short)288620544;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.HiddenStatic;
			}
			set
			{
				short num = (short)909312000;
				short num2 = num;
				num = (short)606642710;
				short num3 = num;
				num = (short)1437901334;
				switch (num3 == num)
				{
				}
				num = (short)132317184;
				if (num != 0)
				{
				}
				num = (short)480247809;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.HiddenStatic = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x0020AD84 File Offset: 0x00208F84
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0020AE38 File Offset: 0x00209038
		public bool UclAstroCnv_CallID_A00026_Valid
		{
			get
			{
				short num = (short)1134493696;
				short num2 = num;
				num = (short)2139561855;
				short num3 = num;
				num = (short)1546395519;
				switch (num3 == num)
				{
				}
				num = (short)2042298369;
				if (num != 0)
				{
				}
				num = (short)1878458368;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026.Valid;
			}
			set
			{
				short num = (short)1605435392;
				short num2 = num;
				num = (short)1648718403;
				short num3 = num;
				num = (short)101151299;
				switch (num3 == num)
				{
				}
				num = (short)1021771777;
				if (num != 0)
				{
				}
				num = (short)1898774528;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CallID_A00026.Valid = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0020AEF0 File Offset: 0x002090F0
		public bool UclAstroCnv_CallID_A00026_HasDiffs
		{
			get
			{
				short num = (short)1207042048;
				short num2 = num;
				num = (short)1262106626;
				short num3 = num;
				num = (short)1685141506;
				switch (num3 == num)
				{
				}
				num = (short)895418368;
				if (num != 0)
				{
				}
				num = (short)1323630593;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CallID_A00026._HasDiffs;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0020AFA8 File Offset: 0x002091A8
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0020B05C File Offset: 0x0020925C
		public int UclAstroCnv_CustomizedSysGrpNumber_A00027Value
		{
			get
			{
				short num = (short)1737293824;
				short num2 = num;
				num = (short)1033666081;
				short num3 = num;
				num = (short)2016968225;
				switch (num3 == num)
				{
				}
				num = (short)85655553;
				if (num != 0)
				{
				}
				num = (short)1266417664;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Value;
			}
			set
			{
				short num = (short)798621696;
				short num2 = num;
				num = (short)1084293121;
				if (num != 0)
				{
				}
				num = (short)1695059812;
				short num3 = num;
				num = (short)123047780;
				switch (num3 == num)
				{
				}
				num = (short)529858560;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Value = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0020B114 File Offset: 0x00209314
		public global::AcpBusinessLayer.AcpRangeField<int, int> UclAstroCnv_CustomizedSysGrpNumber_A00027Object
		{
			get
			{
				short num = (short)1453654016;
				short num2 = num;
				num = (short)305172921;
				short num3 = num;
				num = (short)1574343097;
				switch (num3 == num)
				{
				}
				num = (short)194314241;
				if (num != 0)
				{
				}
				num = (short)1502281728;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0020B1C4 File Offset: 0x002093C4
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0020B278 File Offset: 0x00209478
		public int UclAstroCnv_CustomizedSysGrpNumber_A00027_UIValue
		{
			get
			{
				short num = (short)1287061504;
				short num2 = num;
				num = (short)1824142004;
				short num3 = num;
				num = (short)1511404212;
				switch (num3 == num)
				{
				}
				num = (short)817233921;
				if (num != 0)
				{
				}
				num = (short)780271616;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.UIValue;
			}
			set
			{
				short num = (short)1552482304;
				short num2 = num;
				num = (short)1190156160;
				short num3 = num;
				num = (short)373118848;
				switch (num3 == num)
				{
				}
				num = (short)1687224321;
				if (num != 0)
				{
				}
				num = (short)455540736;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.UIValue = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0020B330 File Offset: 0x00209530
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0020B3E4 File Offset: 0x002095E4
		internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Min
		{
			get
			{
				short num = (short)1482227712;
				short num2 = num;
				num = (short)1468832456;
				short num3 = num;
				num = (short)1119066824;
				switch (num3 == num)
				{
				}
				num = (short)1090846720;
				if (num != 0)
				{
				}
				num = (short)812908545;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Min;
			}
			set
			{
				short num = (short)551616512;
				short num2 = num;
				num = (short)2049890801;
				short num3 = num;
				num = (short)546298353;
				switch (num3 == num)
				{
				}
				num = (short)216334337;
				if (num != 0)
				{
				}
				num = (short)2019098624;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Min = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x0020B49C File Offset: 0x0020969C
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x0020B550 File Offset: 0x00209750
		internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Max
		{
			get
			{
				short num = (short)141623296;
				short num2 = num;
				num = (short)1027342337;
				if (num != 0)
				{
				}
				num = (short)1009440542;
				short num3 = num;
				num = (short)1703859998;
				switch (num3 == num)
				{
				}
				num = (short)84148224;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Max;
			}
			set
			{
				short num = (short)1906442240;
				short num2 = num;
				num = (short)307971376;
				short num3 = num;
				num = (short)624117040;
				switch (num3 == num)
				{
				}
				num = (short)1683423233;
				if (num != 0)
				{
				}
				num = (short)482082816;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Max = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0020B608 File Offset: 0x00209808
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0020B6BC File Offset: 0x002098BC
		internal int UclAstroCnv_CustomizedSysGrpNumber_A00027Step
		{
			get
			{
				short num = (short)269746176;
				short num2 = num;
				num = (short)1748592726;
				short num3 = num;
				num = (short)1671587926;
				switch (num3 == num)
				{
				}
				num = (short)2079457281;
				if (num != 0)
				{
				}
				num = (short)1155072000;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.StepSize;
			}
			set
			{
				short num = (short)1156186112;
				short num2 = num;
				num = (short)12131715;
				short num3 = num;
				num = (short)1399528835;
				switch (num3 == num)
				{
				}
				num = (short)48627713;
				if (num != 0)
				{
				}
				num = (short)1630339072;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.StepSize = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0020B770 File Offset: 0x00209970
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0020B824 File Offset: 0x00209A24
		public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Applicable
		{
			get
			{
				short num = (short)213254144;
				short num2 = num;
				num = (short)652673025;
				if (num != 0)
				{
				}
				num = (short)883618244;
				short num3 = num;
				num = (short)2106978756;
				switch (num3 == num)
				{
				}
				num = (short)81199104;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Applicable;
			}
			set
			{
				short num = (short)415432704;
				short num2 = num;
				num = (short)1022768599;
				short num3 = num;
				num = (short)262813143;
				switch (num3 == num)
				{
				}
				num = (short)998244353;
				if (num != 0)
				{
				}
				num = (short)826081280;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Applicable = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0020B8DC File Offset: 0x00209ADC
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0020B990 File Offset: 0x00209B90
		public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Valid
		{
			get
			{
				short num = (short)2137260032;
				short num2 = num;
				num = (short)1717724960;
				short num3 = num;
				num = (short)253323040;
				switch (num3 == num)
				{
				}
				num = (short)1870987265;
				if (num != 0)
				{
				}
				num = (short)1092812800;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Valid;
			}
			set
			{
				short num = (short)1577320448;
				short num2 = num;
				num = (short)865992705;
				if (num != 0)
				{
				}
				num = (short)99019232;
				short num3 = num;
				num = (short)1437264352;
				switch (num3 == num)
				{
				}
				num = (short)466550784;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Valid = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0020BA48 File Offset: 0x00209C48
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x0020BAFC File Offset: 0x00209CFC
		public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Visible
		{
			get
			{
				short num = (short)1413152768;
				short num2 = num;
				num = (short)2123825153;
				if (num != 0)
				{
				}
				num = (short)1862106147;
				short num3 = num;
				num = (short)1860008995;
				switch (num3 == num)
				{
				}
				num = (short)506331136;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Visible;
			}
			set
			{
				short num = (short)207093760;
				short num2 = num;
				num = (short)1921145606;
				short num3 = num;
				num = (short)868113158;
				switch (num3 == num)
				{
				}
				num = (short)1172045824;
				if (num != 0)
				{
				}
				num = (short)519372801;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Visible = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0020BBB4 File Offset: 0x00209DB4
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x0020BC68 File Offset: 0x00209E68
		public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_Editable
		{
			get
			{
				short num = (short)2074673152;
				short num2 = num;
				num = (short)307625985;
				if (num != 0)
				{
				}
				num = (short)284206157;
				short num3 = num;
				num = (short)1192404045;
				switch (num3 == num)
				{
				}
				num = (short)1036976128;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Editable;
			}
			set
			{
				short num = (short)261881856;
				short num2 = num;
				num = (short)1800718049;
				short num3 = num;
				num = (short)1735771873;
				switch (num3 == num)
				{
				}
				num = (short)2138112000;
				if (num != 0)
				{
				}
				num = (short)646119425;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.Editable = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0020BD20 File Offset: 0x00209F20
		internal string UclAstroCnv_CustomizedSysGrpNumber_A00027_UILabel
		{
			get
			{
				short num = (short)603717632;
				short num2 = num;
				num = (short)920714779;
				short num3 = num;
				num = (short)1281097243;
				switch (num3 == num)
				{
				}
				num = (short)1115553793;
				if (num != 0)
				{
				}
				num = (short)893911040;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.UIName;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0020BDD4 File Offset: 0x00209FD4
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x0020BE88 File Offset: 0x0020A088
		internal bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HiddenStatic
		{
			get
			{
				short num = (short)2129723392;
				short num2 = num;
				num = (short)611391279;
				short num3 = num;
				num = (short)1237391151;
				switch (num3 == num)
				{
				}
				num = (short)662634497;
				if (num != 0)
				{
				}
				num = (short)2026045440;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.HiddenStatic;
			}
			set
			{
				short num = (short)67829760;
				short num2 = num;
				num = (short)585834274;
				short num3 = num;
				num = (short)1499995938;
				switch (num3 == num)
				{
				}
				num = (short)550240256;
				if (num != 0)
				{
				}
				num = (short)1062404097;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.HiddenStatic = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0020BF40 File Offset: 0x0020A140
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0020BFF8 File Offset: 0x0020A1F8
		internal bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HiddenDynamic
		{
			get
			{
				short num = (short)1834090496;
				short num2 = num;
				num = (short)2018060107;
				short num3 = num;
				num = (short)797910859;
				switch (num3 == num)
				{
				}
				num = (short)1269760001;
				if (num != 0)
				{
				}
				num = (short)1290993664;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027.HiddenDynamic;
			}
			set
			{
				short num = (short)784898848;
				short num2 = num;
				num = (short)1341168416;
				switch (num2 == num)
				{
				}
				num = (short)14024705;
				if (num != 0)
				{
				}
				num = (short)1776615424;
				short num3 = num;
				num = (short)941359104;
				if (num != 0)
				{
				}
				this.uclAstroCnv_CustomizedSysGrpNumber_A00027.HiddenDynamic = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x0020C0AC File Offset: 0x0020A2AC
		public bool UclAstroCnv_CustomizedSysGrpNumber_A00027_HasDiffs
		{
			get
			{
				short num = (short)1447969556;
				short num2 = num;
				num = (short)1041515284;
				switch (num2 == num)
				{
				}
				num = (short)857079808;
				if (num != 0)
				{
				}
				num = (short)1496383488;
				short num3 = num;
				num = (short)1412300801;
				if (num != 0)
				{
				}
				return this.uclAstroCnv_CustomizedSysGrpNumber_A00027._HasDiffs;
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000265F File Offset: 0x0000085F
		internal AstroCallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0020C160 File Offset: 0x0020A360
		public bool HasDiffs
		{
			get
			{
				short num = (short)912080919;
				short num2 = num;
				num = (short)1814708247;
				switch (num2 == num)
				{
				}
				num = (short)510787584;
				if (num != 0)
				{
				}
				num = (short)217776128;
				short num3 = num;
				num = (short)760676353;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0020C210 File Offset: 0x0020A410
		public override void Init()
		{
			int a_ = 2;
			short num = (short)2089957654;
			short num2 = num;
			num = (short)2103523606;
			switch (num2 == num)
			{
			}
			num = (short)1593638913;
			if (num != 0)
			{
			}
			num = (short)1424097280;
			short num3 = num;
			num = (short)1431633920;
			if (num != 0)
			{
			}
			this.uclAstroCnv_SystemAlias_A00022 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚캜튠힢삤쪦잪쒬캮슰螶覸论込趾", a_), global::CommonResources.AppResources.System_Name, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID,
				global::CommonResources.AppResources.Customized_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.uclAstroCnv_SystemAlias_A00022.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_SystemAlias_A00022.DataTransferOrder = 1;
			this.uclAstroCnv_SystemAlias_A00022.KeyNameField = true;
			this.uclAstroCnv_SystemGroupNumber_A00023 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚캜튠힢삤쪦\ud9aa슬\udaae솰ﶲ살\udab6\udbb8\udeba쾼胀﯈", a_), global::CommonResources.AppResources.System_Group_Number, global::CommonResources.AppResources.Unassigned_ID);
			this.uclAstroCnv_SystemGroupNumber_A00023.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_SystemGroupNumber_A00023.KeyNameField = true;
			this.uclAstroCnv_IndividualID_A00024 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚풜얠쪢펤캦춨\udeaa첬쎮覸论趼趾", a_), global::CommonResources.AppResources.Individual_ID_Id, 0, 16777215, 1, global::CommonResources.AppResources.Unassigned_ID, null);
			this.uclAstroCnv_IndividualID_A00024.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_IndividualID_A00024.DataTransferOrder = 4;
			this.uclAstroCnv_IndividualID_A00024.KeyNameField = true;
			this.uclAstroCnv_ListinfoCallType_A00025 = new global::AcpBusinessLayer.AcpListField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚톜튠힢첤즦쾨쒪캮\uddb0\udfb2캶즸\udebaﺾﳈ", a_), global::CommonResources.AppResources.Call_Type, global::SpecialFeatures.Ucl.Contact.LOVs.CallTypeList);
			this.uclAstroCnv_ListinfoCallType_A00025.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_ListinfoCallType_A00025.DataTransferOrder = 5;
			this.uclAstroCnv_ListinfoCallType_A00025.KeyNameField = true;
			this.uclAstroCnv_CallID_A00026 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚\ude9cﺞ춠쾢鶬龮膰膲莴", a_), global::CommonResources.AppResources.Call_ID);
			this.uclAstroCnv_CallID_A00026.EvaluateRecRefs = true;
			this.uclAstroCnv_CallID_A00026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킄쪊ﺌﮎﲒ횔練쒚\ude9c튠힢쪤쪦삨톪좬쮮쪲운쮸쮺쪾곀ꇂꃄ뗆雈諊﷌ￎ", a_), global::CommonResources.AppResources.Custom_Group_Number, 1, 65535, 1);
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027.DataTransferOrder = 2;
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027.KeyNameField = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒄ﶈ力꾎튐ﲒﮔﲘ캠춢쒤쮦覨\udcae", a_);
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_IDs;
			base.DataTransferOrder = 1;
			base.Id = 10404;
			this.uclAstroCnv_IndividualID_A00024.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0020C4CC File Offset: 0x0020A6CC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)478685809;
			short num2 = num;
			num = (short)526264945;
			switch (num2 == num)
			{
			}
			num = (short)1794244608;
			if (num != 0)
			{
			}
			num = (short)1586233344;
			short num3 = num;
			num = (short)1643511809;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0020C57C File Offset: 0x0020A77C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)395444241;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.uclAstroCnv_CustomizedSysGrpNumber_A00027 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦\ud8ac\udcae얰\udcb2\ud8b4\udeb6쎸\udeba\ud9bc룀냂苄뗆마藊료ꋎ돐뛒꟔裖飘폠퓢", a_), global::CommonResources.AppResources.Custom_Group_Number);
					this.uclAstroCnv_CustomizedSysGrpNumber_A00027.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstroCnv_CustomizedSysGrpNumber_A00027.DataTransferOrder = 2;
					this.uclAstroCnv_CustomizedSysGrpNumber_A00027.KeyNameField = true;
					num = (short)901906438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)717553680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields != null)
					{
						num = (short)120455169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BE;
				case 3:
					goto IL_1F6;
				case 4:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦첬쎮\uddb0者论趼达", a_)))
					{
						num = (short)1100480533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 5:
					goto IL_445;
				case 6:
					goto IL_354;
				case 7:
					this.uclAstroCnv_SystemGroupNumber_A00023 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦풬\udcae얰횲\ud8b4쮸풺좼쾾迀뛂꣄ꗆ곈맊鋌軎", a_), global::CommonResources.AppResources.System_Group_Number, global::CommonResources.AppResources.Unassigned_ID);
					this.uclAstroCnv_SystemGroupNumber_A00023.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstroCnv_SystemGroupNumber_A00023.KeyNameField = true;
					num = (short)1955856402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦풬\udcae얰횲\ud8b4쮸풺좼쾾迀뛂꣄ꗆ곈맊鋌軎", a_)))
					{
						num = (short)278331399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_359;
				case 9:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦\ud8ac\udcae얰\udcb2\ud8b4\udeb6쎸\udeba\ud9bc룀냂苄뗆마藊료ꋎ돐뛒꟔裖飘폠퓢", a_)))
					{
						num = (short)1550254080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BE;
				case 10:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦쒬\udcae얰\udab2\udbb4톶횸\udcbc펾귀韂별럆곈铊賌ￎ", a_)))
					{
						num = (short)238747662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 11:
					goto IL_3A7;
				case 12:
					this.uclAstroCnv_SystemAlias_A00022 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦풬\udcae얰횲\ud8b4햸튺\udcbc첾黀苂杻流ￌ", a_), global::CommonResources.AppResources.System_Name, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID,
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.uclAstroCnv_SystemAlias_A00022.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstroCnv_SystemAlias_A00022.DataTransferOrder = 1;
					this.uclAstroCnv_SystemAlias_A00022.KeyNameField = true;
					num = (short)1718288395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦쎬쮮\ud8b0얲\udcb4펶첸\udaba톼藀鳂蓄杻﯊ￌ﯎", a_)))
					{
						num = (short)842989587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_445;
				case 14:
				{
					num = (short)1185277298;
					short num3 = num;
					num = (short)399828338;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
					{
						num = (short)1921974272;
						if (num != 0)
						{
						}
						num = (short)1194786817;
						if (num != 0)
						{
						}
						num = (short)402718720;
						short num4 = num;
						this.uclAstroCnv_ListinfoCallType_A00025 = new global::AcpBusinessLayer.AcpListField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦쒬\udcae얰\udab2\udbb4톶횸\udcbc펾귀韂별럆곈铊賌ￎ", a_), global::CommonResources.AppResources.Call_Type, global::SpecialFeatures.Ucl.Contact.LOVs.CallTypeList);
						this.uclAstroCnv_ListinfoCallType_A00025.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.uclAstroCnv_ListinfoCallType_A00025.DataTransferOrder = 5;
						this.uclAstroCnv_ListinfoCallType_A00025.KeyNameField = true;
						num = (short)200540180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 15:
					num = (short)14090242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦풬\udcae얰횲\ud8b4햸튺\udcbc첾黀苂杻流ￌ", a_)))
					{
						num = (short)1626341388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A7;
				case 17:
					goto IL_1D;
				case 18:
					goto IL_359;
				case 19:
					this.uclAstroCnv_IndividualID_A00024 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦쎬쮮\ud8b0얲\udcb4펶첸\udaba톼藀鳂蓄杻﯊ￌ﯎", a_), global::CommonResources.AppResources.Individual_ID_Id, global::CommonResources.AppResources.Unassigned_ID, null);
					this.uclAstroCnv_IndividualID_A00024.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstroCnv_IndividualID_A00024.DataTransferOrder = 4;
					this.uclAstroCnv_IndividualID_A00024.KeyNameField = true;
					this.uclAstroCnv_IndividualID_A00024.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
					num = (short)1796603909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_A9;
				case 21:
					this.uclAstroCnv_CallID_A00026 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욒ﮖ\ud898캠쮤톦첬쎮\uddb0者论趼达", a_), global::CommonResources.AppResources.Call_ID);
					this.uclAstroCnv_CallID_A00026.EvaluateRecRefs = true;
					this.uclAstroCnv_CallID_A00026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					num = (short)1854799875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_85;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_85:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_5BE;
					}
					num = (short)405078031;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_A9:
				num = (short)1366949892;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				num = (short)479723529;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_359:
				num = (short)1433468941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A7:
				num = (short)1115488264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_445:
				num = (short)997130250;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_354:
			IL_5BE:
			base.FeatureSectionName = global::CommonResources.AppResources.Astro_Conventional_IDs;
			base.UIName = global::CommonResources.AppResources.Astro_Conventional_IDs;
			base.Id = 10404;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0020CB70 File Offset: 0x0020AD70
		public override void PopulateReferences()
		{
			short num = (short)2051538953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.FeatureNode referencedNode;
				switch (num2)
				{
				case 0:
				{
					num = (short)1466105856;
					short num3 = num;
					num = (short)525584624;
					short num4 = num;
					num = (short)1120651504;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B3;
					default:
						num = (short)631373824;
						if (num != 0)
						{
						}
						this.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = null;
						num = (short)616497164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)2014773249;
					if (num != 0)
					{
					}
					goto IL_B0;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1089929227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AA;
				case 3:
					if (referencedNode != null)
					{
						num = (short)684720138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				case 4:
					if (this.UclAstroCnv_SystemAlias_A00022Value == 65535)
					{
						num = (short)972619784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)276430855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2AA;
				case 6:
					num = (short)1623982082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1B3;
				case 8:
					this.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = this.UclAstroCnv_CustomizedSysGrpNumber_A00027Object;
					num = (short)1917321229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					this.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960;
					num = (short)530579457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					this.uclAstroCnv_SystemAlias_A00022.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2053));
					num = (short)48103429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_153;
				case 13:
					goto IL_AB;
				}
				IL_5D:
				if (base.ParentRecset != null)
				{
					num = (short)1408237574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2AA;
				IL_B0:
				num = (short)1894776836;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B3:
				if (this.UclAstroCnv_SystemAlias_A00022Value == 0)
				{
					num = (short)400752640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2AA:
				referencedNode = this.UclAstroCnv_SystemAlias_A00022Object.ReferencedNode;
				num = (short)318242819;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			IL_153:
			((global::AcpBusinessLayer.Recordset)base.ParentRecset).RefreshKeyForNode((global::AcpBusinessLayer.FeatureNode)base.Parent);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0020CE88 File Offset: 0x0020B088
		public override void DropReferences()
		{
			short num = (short)1763612751;
			short num2 = num;
			num = (short)1871353935;
			switch (num2 == num)
			{
			}
			num = (short)537133056;
			if (num != 0)
			{
			}
			num = (short)1649803264;
			short num3 = num;
			num = (short)1912209409;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0020CF34 File Offset: 0x0020B134
		public override void SetConstraints()
		{
			short num = (short)1686982382;
			short num2 = num;
			num = (short)719605486;
			switch (num2 == num)
			{
			}
			num = (short)1258553345;
			if (num != 0)
			{
			}
			num = (short)1213923328;
			short num3 = num;
			num = (short)259915776;
			if (num != 0)
			{
			}
			this.uclAstroCnv_SystemAlias_A00022.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsAstroSystemAliasValid);
			this.uclAstroCnv_SystemGroupNumber_A00023.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conSetAstroSysGroupNumber);
			this.uclAstroCnv_SystemGroupNumber_A00023.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclAstroCnv_IndividualID_A00024.ValidateAcrossRecset = true;
			this.uclAstroCnv_IndividualID_A00024.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsAstroIndividualIdValid);
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsCustomizedAstroSystem);
			this.uclAstroCnv_SystemGroupNumber_A00023.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsNotCustomizedAstroSystem);
			this.uclAstroCnv_ListinfoCallType_A00025.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsAstroCallTypeValid);
			this.uclAstroCnv_CallID_A00026.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0020D0A4 File Offset: 0x0020B2A4
		public override void SetupDependencies()
		{
			short num = (short)1727103623;
			short num2 = num;
			num = (short)324567687;
			switch (num2 == num)
			{
			}
			num = (short)62324736;
			if (num != 0)
			{
			}
			num = (short)1613037568;
			short num3 = num;
			num = (short)1057554433;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.AstroCallHotList astroCallHotList = ((global::AcpCommonLib.FeatureManager.GetFeature(2210)[0] as global::SpecialFeatures.Ucl.HotList.UclAstroCallHotList).AstroCallHotList.EmbeddedRecset as global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset)[0] as global::SpecialFeatures.Ucl.HotList.AstroCallHotList;
			this.uclAstroCnv_SystemAlias_A00022.AddDependentObject(astroCallHotList.HotListAstro.UclAstroCnvHotList_CallID_A00044Object);
			this.uclAstroCnv_CustomizedSysGrpNumber_A00027.AddDependentObject(astroCallHotList.HotListAstro.UclAstroCnvHotList_CallID_A00044Object);
			this.uclAstroCnv_ListinfoCallType_A00025.AddDependentObject(astroCallHotList.HotListAstro.UclAstroCnvHotList_CallID_A00044Object);
			this.uclAstroCnv_IndividualID_A00024.AddDependentObject(astroCallHotList.HotListAstro.UclAstroCnvHotList_CallID_A00044Object);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0020D1D8 File Offset: 0x0020B3D8
		public void ResolveReferenceAfterUnpack()
		{
			short num = (short)504627200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::AcpBusinessLayer.AcpField<int> acpField;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
						if (general.CnvSysGeneralSystemType_A13262Value == 0)
						{
							goto IL_1DC;
						}
						num = (short)157619190;
						short num3 = num;
						num = (short)588649462;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32D;
						default:
							num = (short)260767744;
							if (num != 0)
							{
							}
							num = (short)1362886659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
						if (general.CnvSysGeneralSystemGroupNumber_A21960Value == acpField.Value)
						{
							num = (short)1321730059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					}
					case 3:
						num = (short)2085093389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1DC;
					case 5:
					{
						if (acpField == 0)
						{
							num = (short)872742924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.uclAstroCnv_SystemAlias_A00022.DefaultValue = 65535;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
						num4 = 0;
						goto IL_32D;
					}
					case 6:
					{
						num = (short)1154744321;
						if (num != 0)
						{
						}
						num = (short)958988288;
						short num5 = num;
						num = (short)1785528325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						if (num4 >= conventionalSystemRecset.Count)
						{
							num = (short)158400512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = conventionalSystemRecset[num4];
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General)acpFeatureNode[10118];
						num = (short)1747058689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_224;
					case 9:
						if (acpField != null)
						{
							num = (short)710672390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					case 10:
						goto IL_224;
					case 11:
						goto IL_21F;
					case 12:
						goto IL_1D7;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
						if (general.CnvSysGeneralSystemType_A13262Value == 2)
						{
							num = (short)431489028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					}
					}
					goto IL_66;
					IL_14F:
					num4++;
					num = (short)863371272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)680263682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224:
					num = (short)530710535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					num = (short)651362314;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_131:
				this.uclAstroCnv_SystemAlias_A00022.DefaultValue = 0;
				this.UclAstroCnv_CustomizedSysGrpNumber_A00027Value = this.uclAstroCnv_CustomizedSysGrpNumber_A00027.DefaultValue;
				return;
				IL_1D7:
				goto IL_131;
				IL_21F:
				this.uclAstroCnv_SystemAlias_A00022.DefaultValue = acpFeatureNode.Parent.IndexOf(acpFeatureNode) + 1;
				return;
				IL_66:
				acpField = (global::AcpBusinessLayer.AcpField<int>)this.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField;
				num = (short)1419902985;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000C82 RID: 3202
		private global::AcpBusinessLayer.AcpRecRefField uclAstroCnv_SystemAlias_A00022;

		// Token: 0x04000C83 RID: 3203
		private global::AcpBusinessLayer.AcpPointerField<int> uclAstroCnv_SystemGroupNumber_A00023;

		// Token: 0x04000C84 RID: 3204
		private global::AcpBusinessLayer.AcpCustomRangeField uclAstroCnv_IndividualID_A00024;

		// Token: 0x04000C85 RID: 3205
		private global::AcpBusinessLayer.AcpListField uclAstroCnv_ListinfoCallType_A00025;

		// Token: 0x04000C86 RID: 3206
		private global::AcpBusinessLayer.AcpKeyField uclAstroCnv_CallID_A00026;

		// Token: 0x04000C87 RID: 3207
		private global::AcpBusinessLayer.AcpRangeField<int, int> uclAstroCnv_CustomizedSysGrpNumber_A00027;

		// Token: 0x020001F5 RID: 501
		internal class UnassignedConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x0600186E RID: 6254 RVA: 0x0020D530 File Offset: 0x0020B730
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num;
				object result;
				try
				{
					num = (short)762172519;
					short num2 = num;
					num = (short)116577383;
					switch (num2 == num)
					{
					}
					num = (short)2019557376;
					if (num != 0)
					{
					}
					result = ((int)value).ToString();
				}
				catch
				{
					result = string.Empty;
				}
				num = (short)1839857665;
				if (num != 0)
				{
				}
				num = (short)731250688;
				short num3 = num;
				return result;
			}

			// Token: 0x0600186F RID: 6255 RVA: 0x0020D604 File Offset: 0x0020B804
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num = (short)613154821;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)741867523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11E;
					case 2:
						num = (short)642383876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3 <= 16777215)
						{
							num = (short)1820590082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 4:
					{
						if (num3 < 0)
						{
							goto IL_15F;
						}
						num = (short)276570125;
						short num4 = num;
						num = (short)896344077;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
						{
							num = (short)200474624;
							short num5 = num;
							num = (short)1776746496;
							if (num != 0)
							{
							}
							num = (short)1681326081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					}
					goto IL_3D;
					IL_55:
					num = (short)1848180736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D:
					if (int.TryParse((string)value, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num3))
					{
						goto IL_55;
					}
					goto IL_166;
				}
				IL_11E:
				return num3;
				IL_15F:
				return 0;
				IL_166:
				num = (short)715063297;
				if (num != 0)
				{
				}
				return 0;
			}
		}
	}
}
