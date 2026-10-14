using System;
using System.Collections.Generic;
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
	// Token: 0x02000200 RID: 512
	[global::System.Serializable]
	public sealed class MDCCallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x00003CB4 File Offset: 0x00001EB4
		internal MDCCallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.uclMDCCnv_SystemGroupNumber_A00029.PointedField = this.uclMDCCnv_CustomizedSysGrpNumber_A00032;
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0021259C File Offset: 0x0021079C
		// (set) Token: 0x060018DA RID: 6362 RVA: 0x00212654 File Offset: 0x00210854
		public int UclMDCCnv_SystemAlias_A00028Value
		{
			get
			{
				short num = (short)490733568;
				short num2 = num;
				num = (short)1823551027;
				short num3 = num;
				num = (short)1844325939;
				switch (num3 == num)
				{
				}
				num = (short)365953025;
				if (num != 0)
				{
				}
				num = (short)1480720384;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.Value;
			}
			set
			{
				short num = (short)884801536;
				short num2 = num;
				num = (short)1989652817;
				short num3 = num;
				num = (short)282702161;
				switch (num3 == num)
				{
				}
				num = (short)1246298112;
				if (num != 0)
				{
				}
				num = (short)301137921;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.Value = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00212708 File Offset: 0x00210908
		public global::AcpBusinessLayer.AcpRecRefField UclMDCCnv_SystemAlias_A00028Object
		{
			get
			{
				short num = (short)554762240;
				short num2 = num;
				num = (short)1844792184;
				short num3 = num;
				num = (short)441666424;
				switch (num3 == num)
				{
				}
				num = (short)720897;
				if (num != 0)
				{
				}
				num = (short)1683947520;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x002127B8 File Offset: 0x002109B8
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x0021286C File Offset: 0x00210A6C
		public string UclMDCCnv_SystemAlias_A00028_UIValue
		{
			get
			{
				short num = (short)446098899;
				short num2 = num;
				num = (short)315944403;
				switch (num2 == num)
				{
				}
				num = (short)2033319936;
				short num3 = num;
				num = (short)85786625;
				if (num != 0)
				{
				}
				num = (short)1799553024;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.UIValue;
			}
			set
			{
				short num = (short)112440600;
				short num2 = num;
				num = (short)1669707032;
				switch (num2 == num)
				{
				}
				num = (short)438173696;
				short num3 = num;
				num = (short)1511522305;
				if (num != 0)
				{
				}
				num = (short)336658432;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.UIValue = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00212920 File Offset: 0x00210B20
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x002129D4 File Offset: 0x00210BD4
		public bool UclMDCCnv_SystemAlias_A00028_Applicable
		{
			get
			{
				short num = (short)1260232992;
				short num2 = num;
				num = (short)878944544;
				switch (num2 == num)
				{
				}
				num = (short)1990656000;
				short num3 = num;
				num = (short)1582825473;
				if (num != 0)
				{
				}
				num = (short)387973120;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.Applicable;
			}
			set
			{
				short num = (short)1240809052;
				short num2 = num;
				num = (short)1410154076;
				switch (num2 == num)
				{
				}
				num = (short)1959526400;
				short num3 = num;
				num = (short)1148452864;
				if (num != 0)
				{
				}
				num = (short)1298792449;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.Applicable = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00212A8C File Offset: 0x00210C8C
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00212B40 File Offset: 0x00210D40
		public bool UclMDCCnv_SystemAlias_A00028_Editable
		{
			get
			{
				short num = (short)963508022;
				short num2 = num;
				num = (short)371652406;
				switch (num2 == num)
				{
				}
				num = (short)1868890112;
				short num3 = num;
				num = (short)1344143360;
				if (num != 0)
				{
				}
				num = (short)255000577;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.Editable;
			}
			set
			{
				short num = (short)1909605440;
				short num2 = num;
				num = (short)758793280;
				switch (num2 == num)
				{
				}
				num = (short)1435435008;
				short num3 = num;
				num = (short)865861633;
				if (num != 0)
				{
				}
				num = (short)850132992;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.Editable = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00212BF4 File Offset: 0x00210DF4
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00212CA8 File Offset: 0x00210EA8
		public bool UclMDCCnv_SystemAlias_A00028_Visible
		{
			get
			{
				short num = (short)889911957;
				short num2 = num;
				num = (short)1081080469;
				switch (num2 == num)
				{
				}
				num = (short)1890058240;
				short num3 = num;
				num = (short)2142044161;
				if (num != 0)
				{
				}
				num = (short)324599808;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.Visible;
			}
			set
			{
				short num = (short)806880672;
				short num2 = num;
				num = (short)884999584;
				switch (num2 == num)
				{
				}
				num = (short)1655046144;
				short num3 = num;
				num = (short)1205338113;
				if (num != 0)
				{
				}
				num = (short)787152896;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.Visible = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00212D60 File Offset: 0x00210F60
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00212E14 File Offset: 0x00211014
		public bool UclMDCCnv_SystemAlias_A00028_Valid
		{
			get
			{
				short num = (short)1839286080;
				short num2 = num;
				num = (short)1964197696;
				switch (num2 == num)
				{
				}
				num = (short)42598400;
				short num3 = num;
				num = (short)2121924609;
				if (num != 0)
				{
				}
				num = (short)312147968;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028.Valid;
			}
			set
			{
				short num = (short)686747814;
				short num2 = num;
				num = (short)1501294758;
				switch (num2 == num)
				{
				}
				num = (short)1090387968;
				short num3 = num;
				num = (short)363724801;
				if (num != 0)
				{
				}
				num = (short)1402339328;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemAlias_A00028.Valid = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00212ECC File Offset: 0x002110CC
		public bool UclMDCCnv_SystemAlias_A00028_HasDiffs
		{
			get
			{
				short num = (short)1892539360;
				short num2 = num;
				num = (short)1352915936;
				switch (num2 == num)
				{
				}
				num = (short)631373824;
				short num3 = num;
				num = (short)1498611713;
				if (num != 0)
				{
				}
				num = (short)991756288;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemAlias_A00028._HasDiffs;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00212F7C File Offset: 0x0021117C
		public int UclMDCCnv_SystemGroupNumber_A00029Value
		{
			get
			{
				short num = (short)156056536;
				short num2 = num;
				num = (short)17251288;
				switch (num2 == num)
				{
				}
				num = (short)1042677760;
				short num3 = num;
				num = (short)1666580481;
				if (num != 0)
				{
				}
				num = (short)1359872000;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.Value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00213030 File Offset: 0x00211230
		public global::AcpBusinessLayer.AcpPointerField<int> UclMDCCnv_SystemGroupNumber_A00029Object
		{
			get
			{
				short num = (short)209057286;
				short num2 = num;
				num = (short)660141574;
				switch (num2 == num)
				{
				}
				num = (short)1339555840;
				short num3 = num;
				num = (short)1985216512;
				if (num != 0)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x002130E0 File Offset: 0x002112E0
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x00213194 File Offset: 0x00211394
		public string UclMDCCnv_SystemGroupNumber_A00029_UIValue
		{
			get
			{
				short num = (short)426817647;
				short num2 = num;
				num = (short)1345828975;
				switch (num2 == num)
				{
				}
				num = (short)177209344;
				short num3 = num;
				num = (short)653328385;
				if (num != 0)
				{
				}
				num = (short)739442688;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.UIValue;
			}
			set
			{
				short num = (short)1863303071;
				short num2 = num;
				num = (short)931774367;
				switch (num2 == num)
				{
				}
				num = (short)158990336;
				short num3 = num;
				num = (short)5898240;
				if (num != 0)
				{
				}
				num = (short)1796734977;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemGroupNumber_A00029.UIValue = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0021324C File Offset: 0x0021144C
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x00213300 File Offset: 0x00211500
		public bool UclMDCCnv_SystemGroupNumber_A00029_Applicable
		{
			get
			{
				short num = (short)1147713643;
				short num2 = num;
				num = (short)428521579;
				switch (num2 == num)
				{
				}
				num = (short)1691615232;
				short num3 = num;
				num = (short)605618177;
				if (num != 0)
				{
				}
				num = (short)1268776960;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.Applicable;
			}
			set
			{
				short num = (short)1069750955;
				short num2 = num;
				num = (short)1457199787;
				switch (num2 == num)
				{
				}
				num = (short)1000013824;
				short num3 = num;
				num = (short)1991835649;
				if (num != 0)
				{
				}
				num = (short)740753408;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemGroupNumber_A00029.Applicable = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x002133BC File Offset: 0x002115BC
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00213470 File Offset: 0x00211670
		public bool UclMDCCnv_SystemGroupNumber_A00029_Editable
		{
			get
			{
				short num = (short)1580306732;
				short num2 = num;
				num = (short)759337260;
				switch (num2 == num)
				{
				}
				num = (short)1302134784;
				short num3 = num;
				num = (short)875626497;
				if (num != 0)
				{
				}
				num = (short)1603993600;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.Editable;
			}
			set
			{
				short num = (short)68795142;
				short num2 = num;
				num = (short)603568902;
				switch (num2 == num)
				{
				}
				num = (short)312934400;
				short num3 = num;
				num = (short)1409810433;
				if (num != 0)
				{
				}
				num = (short)992411648;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemGroupNumber_A00029.Editable = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00213524 File Offset: 0x00211724
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x002135D8 File Offset: 0x002117D8
		public bool UclMDCCnv_SystemGroupNumber_A00029_Visible
		{
			get
			{
				short num = (short)1799348934;
				short num2 = num;
				num = (short)1434444486;
				switch (num2 == num)
				{
				}
				num = (short)750321664;
				short num3 = num;
				num = (short)835256321;
				if (num != 0)
				{
				}
				num = (short)289931264;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.Visible;
			}
			set
			{
				short num = (short)1318388008;
				short num2 = num;
				num = (short)414122280;
				switch (num2 == num)
				{
				}
				num = (short)206307328;
				short num3 = num;
				num = (short)1783300097;
				if (num != 0)
				{
				}
				num = (short)1016463360;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemGroupNumber_A00029.Visible = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00213690 File Offset: 0x00211890
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00213744 File Offset: 0x00211944
		public bool UclMDCCnv_SystemGroupNumber_A00029_Valid
		{
			get
			{
				short num = (short)907531475;
				short num2 = num;
				num = (short)1586681043;
				switch (num2 == num)
				{
				}
				num = (short)1917714432;
				short num3 = num;
				num = (short)2048262144;
				if (num != 0)
				{
				}
				num = (short)822083585;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029.Valid;
			}
			set
			{
				short num = (short)298467780;
				short num2 = num;
				num = (short)2097758660;
				switch (num2 == num)
				{
				}
				num = (short)362872832;
				short num3 = num;
				num = (short)1531641856;
				if (num != 0)
				{
				}
				num = (short)2109079553;
				if (num != 0)
				{
				}
				this.uclMDCCnv_SystemGroupNumber_A00029.Valid = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x002137F8 File Offset: 0x002119F8
		public bool UclMDCCnv_SystemGroupNumber_A00029_HasDiffs
		{
			get
			{
				short num = (short)2031222785;
				if (num != 0)
				{
				}
				num = (short)477393058;
				short num2 = num;
				num = (short)913338530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064842752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1488846848;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_SystemGroupNumber_A00029._HasDiffs;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x002138AC File Offset: 0x00211AAC
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x00213964 File Offset: 0x00211B64
		public int UclMDCCnv_PrimaryID_A00030Value
		{
			get
			{
				short num = (short)1348753138;
				short num2 = num;
				num = (short)549672690;
				switch (num2 == num)
				{
				}
				num = (short)1624965120;
				short num3 = num;
				num = (short)1401421824;
				if (num != 0)
				{
				}
				num = (short)159055873;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.Value;
			}
			set
			{
				short num = (short)622072421;
				short num2 = num;
				num = (short)939070053;
				switch (num2 == num)
				{
				}
				num = (short)1399062528;
				short num3 = num;
				num = (short)188219393;
				if (num != 0)
				{
				}
				num = (short)308871168;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.Value = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00213A1C File Offset: 0x00211C1C
		public global::AcpBusinessLayer.AcpCustomRangeField UclMDCCnv_PrimaryID_A00030Object
		{
			get
			{
				short num = (short)329187329;
				if (num != 0)
				{
				}
				num = (short)188442351;
				short num2 = num;
				num = (short)891447023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110624768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)517996544;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00213AC8 File Offset: 0x00211CC8
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00213B80 File Offset: 0x00211D80
		public string UclMDCCnv_PrimaryID_A00030_UIValue
		{
			get
			{
				short num = (short)1627972373;
				short num2 = num;
				num = (short)569828117;
				switch (num2 == num)
				{
				}
				num = (short)704249856;
				short num3 = num;
				num = (short)27197440;
				if (num != 0)
				{
				}
				num = (short)909901825;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.UIValue;
			}
			set
			{
				short num = (short)1549415183;
				short num2 = num;
				num = (short)1647457039;
				switch (num2 == num)
				{
				}
				num = (short)1946288128;
				short num3 = num;
				num = (short)1721892865;
				if (num != 0)
				{
				}
				num = (short)1044119552;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.UIValue = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00213C38 File Offset: 0x00211E38
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x00213CF0 File Offset: 0x00211EF0
		public bool UclMDCCnv_PrimaryID_A00030_Applicable
		{
			get
			{
				short num = (short)2001730257;
				short num2 = num;
				num = (short)221051601;
				switch (num2 == num)
				{
				}
				num = (short)1927479296;
				short num3 = num;
				num = (short)1473904641;
				if (num != 0)
				{
				}
				num = (short)833028096;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.Applicable;
			}
			set
			{
				short num = (short)966054103;
				short num2 = num;
				num = (short)515756247;
				switch (num2 == num)
				{
				}
				num = (short)2116354048;
				short num3 = num;
				num = (short)1720516608;
				if (num != 0)
				{
				}
				num = (short)678625281;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.Applicable = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00213DA8 File Offset: 0x00211FA8
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00213E5C File Offset: 0x0021205C
		public bool UclMDCCnv_PrimaryID_A00030_Editable
		{
			get
			{
				short num = (short)697688558;
				short num2 = num;
				num = (short)1321132526;
				switch (num2 == num)
				{
				}
				num = (short)1319829504;
				short num3 = num;
				num = (short)465305601;
				if (num != 0)
				{
				}
				num = (short)2028797952;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.Editable;
			}
			set
			{
				short num = (short)539733340;
				short num2 = num;
				num = (short)802991452;
				switch (num2 == num)
				{
				}
				num = (short)1161953280;
				short num3 = num;
				num = (short)1503461377;
				if (num != 0)
				{
				}
				num = (short)824770560;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.Editable = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00213F10 File Offset: 0x00212110
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00213FC4 File Offset: 0x002121C4
		public bool UclMDCCnv_PrimaryID_A00030_Visible
		{
			get
			{
				short num = (short)1006941393;
				short num2 = num;
				num = (short)496481489;
				switch (num2 == num)
				{
				}
				num = (short)1204092928;
				short num3 = num;
				num = (short)1201537025;
				if (num != 0)
				{
				}
				num = (short)404094976;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.Visible;
			}
			set
			{
				short num = (short)333998108;
				short num2 = num;
				num = (short)674719772;
				switch (num2 == num)
				{
				}
				num = (short)376832000;
				short num3 = num;
				num = (short)784596993;
				if (num != 0)
				{
				}
				num = (short)610467840;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.Visible = value;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0021407C File Offset: 0x0021227C
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00214134 File Offset: 0x00212334
		internal bool UclMDCCnv_PrimaryID_A00030_HiddenStatic
		{
			get
			{
				short num = (short)1236106859;
				short num2 = num;
				num = (short)1558478443;
				switch (num2 == num)
				{
				}
				num = (short)1279918080;
				short num3 = num;
				num = (short)492044288;
				if (num != 0)
				{
				}
				num = (short)1387593729;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.HiddenStatic;
			}
			set
			{
				short num = (short)1327438812;
				short num2 = num;
				num = (short)1778064348;
				switch (num2 == num)
				{
				}
				num = (short)69337088;
				short num3 = num;
				num = (short)527368192;
				if (num != 0)
				{
				}
				num = (short)553975809;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.HiddenStatic = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x002141E8 File Offset: 0x002123E8
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x002142A0 File Offset: 0x002124A0
		public bool UclMDCCnv_PrimaryID_A00030_Valid
		{
			get
			{
				short num = (short)1670381569;
				if (num != 0)
				{
				}
				num = (short)1766809324;
				short num2 = num;
				num = (short)2093965036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386283008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1806761984;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030.Valid;
			}
			set
			{
				short num = (short)1311841667;
				short num2 = num;
				num = (short)1572740483;
				switch (num2 == num)
				{
				}
				num = (short)1101266944;
				short num3 = num;
				num = (short)718602241;
				if (num != 0)
				{
				}
				num = (short)50790400;
				if (num != 0)
				{
				}
				this.uclMDCCnv_PrimaryID_A00030.Valid = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00214354 File Offset: 0x00212554
		public bool UclMDCCnv_PrimaryID_A00030_HasDiffs
		{
			get
			{
				short num = (short)1945280339;
				short num2 = num;
				num = (short)1898094419;
				switch (num2 == num)
				{
				}
				num = (short)596836352;
				short num3 = num;
				num = (short)2075590657;
				if (num != 0)
				{
				}
				num = (short)1415380992;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_PrimaryID_A00030._HasDiffs;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00214408 File Offset: 0x00212608
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x002144BC File Offset: 0x002126BC
		public string UclMDCCnv_CallID_A00031Value
		{
			get
			{
				short num = (short)1504972909;
				short num2 = num;
				num = (short)1972441197;
				switch (num2 == num)
				{
				}
				num = (short)1138032640;
				short num3 = num;
				num = (short)2131296257;
				if (num != 0)
				{
				}
				num = (short)949420032;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.Value;
			}
			set
			{
				short num = (short)235667457;
				if (num != 0)
				{
				}
				num = (short)1564280338;
				short num2 = num;
				num = (short)1434977810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1234239488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32571392;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.Value = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00214574 File Offset: 0x00212774
		public global::AcpBusinessLayer.AcpKeyField UclMDCCnv_CallID_A00031Object
		{
			get
			{
				short num = (short)859182159;
				short num2 = num;
				num = (short)400692303;
				switch (num2 == num)
				{
				}
				num = (short)1755447296;
				short num3 = num;
				num = (short)2007695361;
				if (num != 0)
				{
				}
				num = (short)521732096;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x00214620 File Offset: 0x00212820
		public string UclMDCCnv_CallID_A00031_UILabel
		{
			get
			{
				short num = (short)1912733697;
				if (num != 0)
				{
				}
				num = (short)1052313034;
				short num2 = num;
				num = (short)1462502858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1149239296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948699136;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.UIName;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x002146D4 File Offset: 0x002128D4
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x00214788 File Offset: 0x00212988
		public bool UclMDCCnv_CallID_A00031_Applicable
		{
			get
			{
				short num = (short)225752157;
				short num2 = num;
				num = (short)569685085;
				switch (num2 == num)
				{
				}
				num = (short)1980563456;
				short num3 = num;
				num = (short)2131099649;
				if (num != 0)
				{
				}
				num = (short)1944059904;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.Applicable;
			}
			set
			{
				short num = (short)658635176;
				short num2 = num;
				num = (short)871954856;
				switch (num2 == num)
				{
				}
				num = (short)1772552192;
				short num3 = num;
				num = (short)105906177;
				if (num != 0)
				{
				}
				num = (short)1602420736;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.Applicable = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00214840 File Offset: 0x00212A40
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x002148F4 File Offset: 0x00212AF4
		public bool UclMDCCnv_CallID_A00031_Editable
		{
			get
			{
				short num = (short)1582096958;
				short num2 = num;
				num = (short)1039524414;
				switch (num2 == num)
				{
				}
				num = (short)1902051328;
				short num3 = num;
				num = (short)854786049;
				if (num != 0)
				{
				}
				num = (short)1336213504;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.Editable;
			}
			set
			{
				short num = (short)478718061;
				short num2 = num;
				num = (short)1149937773;
				switch (num2 == num)
				{
				}
				num = (short)1479933952;
				short num3 = num;
				num = (short)278855680;
				if (num != 0)
				{
				}
				num = (short)119537665;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.Editable = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x002149AC File Offset: 0x00212BAC
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x00214A60 File Offset: 0x00212C60
		public bool UclMDCCnv_CallID_A00031_Visible
		{
			get
			{
				short num = (short)1824391169;
				if (num != 0)
				{
				}
				num = (short)1929670428;
				short num2 = num;
				num = (short)1551265564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375666176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.Visible;
			}
			set
			{
				short num = (short)39845889;
				if (num != 0)
				{
				}
				num = (short)732718307;
				short num2 = num;
				num = (short)723346659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643118592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1777270784;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.Visible = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00214B14 File Offset: 0x00212D14
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x00214BCC File Offset: 0x00212DCC
		internal bool UclMDCCnv_CallID_A00031_HiddenStatic
		{
			get
			{
				short num = (short)988870450;
				short num2 = num;
				num = (short)1563424562;
				switch (num2 == num)
				{
				}
				num = (short)188481536;
				short num3 = num;
				num = (short)1133248513;
				if (num != 0)
				{
				}
				num = (short)1373700096;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.HiddenStatic;
			}
			set
			{
				short num = (short)505456783;
				short num2 = num;
				num = (short)389261455;
				switch (num2 == num)
				{
				}
				num = (short)1340211200;
				short num3 = num;
				num = (short)1181286401;
				if (num != 0)
				{
				}
				num = (short)1798438912;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.HiddenStatic = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x00214C80 File Offset: 0x00212E80
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x00214D34 File Offset: 0x00212F34
		public bool UclMDCCnv_CallID_A00031_Valid
		{
			get
			{
				short num = (short)2087416620;
				short num2 = num;
				num = (short)878736172;
				switch (num2 == num)
				{
				}
				num = (short)1175191552;
				short num3 = num;
				num = (short)697827328;
				if (num != 0)
				{
				}
				num = (short)1351286785;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031.Valid;
			}
			set
			{
				short num = (short)1180356234;
				short num2 = num;
				num = (short)1066061450;
				switch (num2 == num)
				{
				}
				num = (short)1885536256;
				short num3 = num;
				num = (short)1043070976;
				if (num != 0)
				{
				}
				num = (short)1401487361;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CallID_A00031.Valid = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00214DEC File Offset: 0x00212FEC
		public bool UclMDCCnv_CallID_A00031_HasDiffs
		{
			get
			{
				short num = (short)1050954320;
				short num2 = num;
				num = (short)1552894544;
				switch (num2 == num)
				{
				}
				num = (short)2082471936;
				short num3 = num;
				num = (short)602144769;
				if (num != 0)
				{
				}
				num = (short)601948160;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CallID_A00031._HasDiffs;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x00214EA4 File Offset: 0x002130A4
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00214F58 File Offset: 0x00213158
		public int UclMDCCnv_CustomizedSysGrpNumber_A00032Value
		{
			get
			{
				short num = (short)1020598527;
				short num2 = num;
				num = (short)421206271;
				switch (num2 == num)
				{
				}
				num = (short)477233152;
				short num3 = num;
				num = (short)1525088256;
				if (num != 0)
				{
				}
				num = (short)888406017;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Value;
			}
			set
			{
				short num = (short)1056469843;
				short num2 = num;
				num = (short)1305375571;
				switch (num2 == num)
				{
				}
				num = (short)736952320;
				short num3 = num;
				num = (short)744226817;
				if (num != 0)
				{
				}
				num = (short)709427200;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Value = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00215010 File Offset: 0x00213210
		public global::AcpBusinessLayer.AcpRangeField<int, int> UclMDCCnv_CustomizedSysGrpNumber_A00032Object
		{
			get
			{
				short num = (short)88944766;
				short num2 = num;
				num = (short)30552190;
				switch (num2 == num)
				{
				}
				num = (short)1378877440;
				short num3 = num;
				num = (short)384434177;
				if (num != 0)
				{
				}
				num = (short)1486028800;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x002150C0 File Offset: 0x002132C0
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x00215174 File Offset: 0x00213374
		public int UclMDCCnv_CustomizedSysGrpNumber_A00032_UIValue
		{
			get
			{
				short num = (short)432275457;
				if (num != 0)
				{
				}
				num = (short)1914365801;
				short num2 = num;
				num = (short)1310189417;
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
				num = (short)716636160;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.UIValue;
			}
			set
			{
				short num = (short)972874960;
				short num2 = num;
				num = (short)290120912;
				switch (num2 == num)
				{
				}
				num = (short)118489088;
				short num3 = num;
				num = (short)1307246593;
				if (num != 0)
				{
				}
				num = (short)136249344;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.UIValue = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x00215228 File Offset: 0x00213428
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x002152E0 File Offset: 0x002134E0
		internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Min
		{
			get
			{
				short num = (short)132832592;
				short num2 = num;
				num = (short)163896656;
				switch (num2 == num)
				{
				}
				num = (short)323420160;
				short num3 = num;
				num = (short)1893859329;
				if (num != 0)
				{
				}
				num = (short)1535574016;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Min;
			}
			set
			{
				short num = (short)482023296;
				short num2 = num;
				num = (short)1546327936;
				switch (num2 == num)
				{
				}
				num = (short)1276182528;
				short num3 = num;
				num = (short)2108948481;
				if (num != 0)
				{
				}
				num = (short)683606016;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Min = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x00215398 File Offset: 0x00213598
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0021544C File Offset: 0x0021364C
		internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Max
		{
			get
			{
				short num = (short)92852881;
				short num2 = num;
				num = (short)124899985;
				switch (num2 == num)
				{
				}
				num = (short)1336147968;
				short num3 = num;
				num = (short)332529664;
				if (num != 0)
				{
				}
				num = (short)1711079425;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Max;
			}
			set
			{
				short num = (short)89082991;
				short num2 = num;
				num = (short)858213487;
				switch (num2 == num)
				{
				}
				num = (short)2013724672;
				short num3 = num;
				num = (short)157089792;
				if (num != 0)
				{
				}
				num = (short)914882561;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Max = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00215504 File Offset: 0x00213704
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x002155B8 File Offset: 0x002137B8
		internal int UclMDCCnv_CustomizedSysGrpNumber_A00032Step
		{
			get
			{
				short num = (short)378019791;
				short num2 = num;
				num = (short)1609375695;
				switch (num2 == num)
				{
				}
				num = (short)648413184;
				short num3 = num;
				num = (short)828637184;
				if (num != 0)
				{
				}
				num = (short)1573519361;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.StepSize;
			}
			set
			{
				short num = (short)1346894322;
				short num2 = num;
				num = (short)715913714;
				switch (num2 == num)
				{
				}
				num = (short)731709440;
				short num3 = num;
				num = (short)1233911809;
				if (num != 0)
				{
				}
				num = (short)507248640;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.StepSize = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00215670 File Offset: 0x00213870
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00215724 File Offset: 0x00213924
		public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Applicable
		{
			get
			{
				short num = (short)849543169;
				if (num != 0)
				{
				}
				num = (short)1459457660;
				short num2 = num;
				num = (short)1056935548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)613351424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460193792;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Applicable;
			}
			set
			{
				short num = (short)2066628916;
				short num2 = num;
				num = (short)220414260;
				switch (num2 == num)
				{
				}
				num = (short)2065235968;
				short num3 = num;
				num = (short)71892993;
				if (num != 0)
				{
				}
				num = (short)393150464;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Applicable = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x002157D8 File Offset: 0x002139D8
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0021588C File Offset: 0x00213A8C
		public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Valid
		{
			get
			{
				short num = (short)1083396178;
				short num2 = num;
				num = (short)1408979026;
				switch (num2 == num)
				{
				}
				num = (short)193527808;
				short num3 = num;
				num = (short)1156775936;
				if (num != 0)
				{
				}
				num = (short)821428225;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Valid;
			}
			set
			{
				short num = (short)1285308723;
				short num2 = num;
				num = (short)1424769331;
				switch (num2 == num)
				{
				}
				num = (short)1607991296;
				short num3 = num;
				num = (short)97255425;
				if (num != 0)
				{
				}
				num = (short)1766785024;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Valid = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00215940 File Offset: 0x00213B40
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x002159F4 File Offset: 0x00213BF4
		public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Visible
		{
			get
			{
				short num = (short)1090165903;
				short num2 = num;
				num = (short)1245879439;
				switch (num2 == num)
				{
				}
				num = (short)1646264320;
				short num3 = num;
				num = (short)774897665;
				if (num != 0)
				{
				}
				num = (short)1743978496;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Visible;
			}
			set
			{
				short num = (short)685489087;
				short num2 = num;
				num = (short)1835252671;
				switch (num2 == num)
				{
				}
				num = (short)931594240;
				short num3 = num;
				num = (short)1817575425;
				if (num != 0)
				{
				}
				num = (short)519307264;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Visible = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00215AAC File Offset: 0x00213CAC
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00215B60 File Offset: 0x00213D60
		public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_Editable
		{
			get
			{
				short num = (short)2105635753;
				short num2 = num;
				num = (short)1331131305;
				switch (num2 == num)
				{
				}
				num = (short)1081278464;
				short num3 = num;
				num = (short)1973354497;
				if (num != 0)
				{
				}
				num = (short)1688666112;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Editable;
			}
			set
			{
				short num = (short)604773298;
				short num2 = num;
				num = (short)279845810;
				switch (num2 == num)
				{
				}
				num = (short)741015552;
				short num3 = num;
				num = (short)1620443137;
				if (num != 0)
				{
				}
				num = (short)216530944;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.Editable = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00215C14 File Offset: 0x00213E14
		internal string UclMDCCnv_CustomizedSysGrpNumber_A00032_UILabel
		{
			get
			{
				short num = (short)1925632601;
				short num2 = num;
				num = (short)165204569;
				switch (num2 == num)
				{
				}
				num = (short)1630797824;
				short num3 = num;
				num = (short)260702209;
				if (num != 0)
				{
				}
				num = (short)1211236352;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.UIName;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00215CCC File Offset: 0x00213ECC
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x00215D84 File Offset: 0x00213F84
		internal bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HiddenStatic
		{
			get
			{
				short num = (short)1254817793;
				if (num != 0)
				{
				}
				num = (short)1667758870;
				short num2 = num;
				num = (short)657914646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1702297600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770703360;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.HiddenStatic;
			}
			set
			{
				short num = (short)2145714177;
				if (num != 0)
				{
				}
				num = (short)1200472196;
				short num2 = num;
				num = (short)835829892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507000320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734148096;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.HiddenStatic = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00215E3C File Offset: 0x0021403C
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00215EF4 File Offset: 0x002140F4
		internal bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HiddenDynamic
		{
			get
			{
				short num = (short)1275804666;
				short num2 = num;
				num = (short)919944186;
				switch (num2 == num)
				{
				}
				num = (short)993001472;
				short num3 = num;
				num = (short)355860480;
				if (num != 0)
				{
				}
				num = (short)45350913;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032.HiddenDynamic;
			}
			set
			{
				short num = (short)1695857732;
				short num2 = num;
				num = (short)1229962308;
				switch (num2 == num)
				{
				}
				num = (short)1464795136;
				short num3 = num;
				num = (short)1439498240;
				if (num != 0)
				{
				}
				num = (short)1134428161;
				if (num != 0)
				{
				}
				this.uclMDCCnv_CustomizedSysGrpNumber_A00032.HiddenDynamic = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00215FA8 File Offset: 0x002141A8
		public bool UclMDCCnv_CustomizedSysGrpNumber_A00032_HasDiffs
		{
			get
			{
				short num = (short)1221221706;
				short num2 = num;
				num = (short)2030394698;
				switch (num2 == num)
				{
				}
				num = (short)1326579712;
				short num3 = num;
				num = (short)7208961;
				if (num != 0)
				{
				}
				num = (short)1762590720;
				if (num != 0)
				{
				}
				return this.uclMDCCnv_CustomizedSysGrpNumber_A00032._HasDiffs;
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0000265F File Offset: 0x0000085F
		internal MDCCallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00216060 File Offset: 0x00214260
		public bool HasDiffs
		{
			get
			{
				short num = (short)966602791;
				short num2 = num;
				num = (short)534523943;
				switch (num2 == num)
				{
				}
				num = (short)1724383232;
				short num3 = num;
				num = (short)196673537;
				if (num != 0)
				{
				}
				num = (short)72679424;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0021610C File Offset: 0x0021430C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)368623233;
			short num2 = num;
			num = (short)1790885505;
			switch (num2 == num)
			{
			}
			num = (short)1288372224;
			short num3 = num;
			num = (short)1575092225;
			if (num != 0)
			{
			}
			num = (short)1208221696;
			if (num != 0)
			{
			}
			this.uclMDCCnv_SystemAlias_A00028 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\udb95\udc97\ud999\udf9b횟ﶡ\udfa5\udba7\udea9즫쎭\udeb1\uddb3ힵ쮷ﶻ躽ﻅ", a_), global::CommonResources.AppResources.System_Name, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID,
				global::CommonResources.AppResources.Customized_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.uclMDCCnv_SystemAlias_A00028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnv_SystemAlias_A00028.DataTransferOrder = 1;
			this.uclMDCCnv_SystemAlias_A00028.KeyNameField = true;
			this.uclMDCCnv_SystemGroupNumber_A00029 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\udb95\udc97\ud999\udf9b횟ﶡ\udfa5\udba7\udea9즫쎭삱\udbb3쎵좷즻펽ꊿꟁ뛃駅觇韛ﳋﻍ", a_), global::CommonResources.AppResources.System_Group_Number, global::CommonResources.AppResources.Unassigned_ID);
			this.uclMDCCnv_SystemGroupNumber_A00029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnv_SystemGroupNumber_A00029.KeyNameField = true;
			this.uclMDCCnv_PrimaryID_A00030 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection.DecToHexConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\udb95\udc97\ud999\udf9b횟ﶡ풥솧잩춫\udcad즯ﮱ醴誹費躽", a_), global::CommonResources.AppResources.Primary_ID, 0, 65535, 1, global::CommonResources.AppResources.Unassigned_ID, null);
			this.uclMDCCnv_PrimaryID_A00030.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnv_PrimaryID_A00030.DataTransferOrder = 4;
			this.uclMDCCnv_PrimaryID_A00030.KeyNameField = true;
			this.uclMDCCnv_CallID_A00031 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\udb95\udc97\ud999\udf9b횟ﶡ장쒧용蒳蚵袷覹趻", a_), global::CommonResources.AppResources.Call_ID);
			this.uclMDCCnv_CallID_A00031.EvaluateRecRefs = true;
			this.uclMDCCnv_CallID_A00031.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얏\udb95\udc97\ud999\udf9b횟ﶡ펥\udba7\udea9쎫쎭\ud9af좱톳튵쎹쾻尿늿닁諃독ꗇ꣉꧋볍迏鏑", a_), global::CommonResources.AppResources.Custom_Group_Number, 1, 65535, 1);
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032.DataTransferOrder = 2;
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032.KeyNameField = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8f횑힓뚕\udb97얟첡킣쾥잧쒩춫슭邯ﮱ억", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_IDs;
			base.DataTransferOrder = 2;
			base.Id = 10406;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0021636C File Offset: 0x0021456C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)749106168;
			short num2 = num;
			num = (short)1911714808;
			switch (num2 == num)
			{
			}
			num = (short)674103296;
			short num3 = num;
			num = (short)1336279040;
			if (num != 0)
			{
			}
			num = (short)1703084033;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00216420 File Offset: 0x00214620
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1940389894;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.uclMDCCnv_SystemAlias_A00028 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘좚햠욢좤얨슪첬\udcae薴螶覸覺薼", a_), global::CommonResources.AppResources.System_Name, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID,
						global::CommonResources.AppResources.Customized_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.uclMDCCnv_SystemAlias_A00028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclMDCCnv_SystemAlias_A00028.DataTransferOrder = 1;
					this.uclMDCCnv_SystemAlias_A00028.KeyNameField = true;
					num = (short)2133196813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.uclMDCCnv_CustomizedSysGrpNumber_A00032 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘\ud89a햠첢좤캦펨캪즬ﲮ좰삲얶즸좼튾ꏀꛂ럄飆裈﯊﷌ￎ", a_), global::CommonResources.AppResources.Custom_Group_Number);
					this.uclMDCCnv_CustomizedSysGrpNumber_A00032.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclMDCCnv_CustomizedSysGrpNumber_A00032.DataTransferOrder = 2;
					this.uclMDCCnv_CustomizedSysGrpNumber_A00032.KeyNameField = true;
					num = (short)1155792899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.uclMDCCnv_SystemGroupNumber_A00029 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘좚햠욢좤\udba8쒪\ud8ac\udfaeﾰ욲\ud8b4햶\udcb8즺ﺾ", a_), global::CommonResources.AppResources.System_Group_Number, global::CommonResources.AppResources.Unassigned_ID);
					this.uclMDCCnv_SystemGroupNumber_A00029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclMDCCnv_SystemGroupNumber_A00029.KeyNameField = true;
					num = (short)888471561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_30E;
				case 4:
				{
					num = (short)1045102593;
					if (num != 0)
					{
					}
					num = (short)457035307;
					short num3 = num;
					num = (short)689229355;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23B;
					default:
						num = (short)1820000256;
						if (num != 0)
						{
						}
						this.uclMDCCnv_PrimaryID_A00030 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection.DecToHexConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘쮚철슢힤\udea6膰莲薴蒶覸", a_), global::CommonResources.AppResources.Primary_ID, global::CommonResources.AppResources.Unassigned_ID, null);
						this.uclMDCCnv_PrimaryID_A00030.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.uclMDCCnv_PrimaryID_A00030.DataTransferOrder = 4;
						this.uclMDCCnv_PrimaryID_A00030.KeyNameField = true;
						num = (short)1281425416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_1AC;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘좚햠욢좤\udba8쒪\ud8ac\udfaeﾰ욲\ud8b4햶\udcb8즺ﺾ", a_)))
					{
						num = (short)796721154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 8:
					goto IL_9D;
				case 9:
					goto IL_EC;
				case 10:
					goto IL_23B;
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘좚햠욢좤얨슪첬\udcae薴螶覸覺薼", a_)))
					{
						num = (short)1026883584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AB;
				case 12:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘\ud89aﲜ춠鮪鶬龮芰芲", a_)))
					{
						num = (short)401276946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC;
				case 13:
					goto IL_4AB;
				case 14:
					num = (short)558628875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘쮚철슢힤\udea6膰莲薴蒶覸", a_)))
					{
						num = (short)1418199044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 16:
				{
					num = (short)1514930176;
					short num4 = num;
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘\ud89a햠첢좤캦펨캪즬ﲮ좰삲얶즸좼튾ꏀꛂ럄飆裈﯊﷌ￎ", a_)))
					{
						num = (short)464453633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FA;
				}
				case 17:
					num = (short)1602617354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.uclMDCCnv_CallID_A00031 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튆삌쮎튐킒ﮔ욘\ud89aﲜ춠鮪鶬龮芰芲", a_), global::CommonResources.AppResources.Call_ID);
					this.uclMDCCnv_CallID_A00031.EvaluateRecRefs = true;
					this.uclMDCCnv_CallID_A00031.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					num = (short)70582277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1312030737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9D:
				num = (short)673579020;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)780140559;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AC:
				num = (short)1206124560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23B:
				if (producerFields != null)
				{
					num = (short)1977942030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_4AB:
				num = (short)39256071;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_30E:
			IL_4FA:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆춈좊권첎ﺐﶒ쾠슢즤螦\udeac", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_IDs;
			base.DataTransferOrder = 2;
			base.Id = 10406;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00216958 File Offset: 0x00214B58
		public override void PopulateReferences()
		{
			short num = (short)377159682;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.FeatureNode referencedNode;
				switch (num2)
				{
				case 0:
					if (this.UclMDCCnv_SystemAlias_A00028Value == 0)
					{
						num = (short)279183368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F9;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					this.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960;
					num = (short)720901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 3:
					goto IL_118;
				case 4:
					goto IL_1C6;
				case 5:
					goto IL_D7;
				case 6:
				{
					num = (short)1695679391;
					short num3 = num;
					num = (short)1915814815;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)72679424;
						if (num != 0)
						{
						}
						this.uclMDCCnv_SystemAlias_A00028.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2053));
						num = (short)708837387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (referencedNode != null)
					{
						num = (short)2024865793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D7;
				case 8:
					this.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = null;
					num = (short)1366032388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)2088304646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28B;
				case 10:
					if (this.UclMDCCnv_SystemAlias_A00028Value == 65535)
					{
						num = (short)924516355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)651689984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_28B;
				case 12:
					num = (short)1466040321;
					if (num != 0)
					{
					}
					num = (short)323420169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_D2;
				}
				IL_5D:
				if (base.ParentRecset != null)
				{
					num = (short)1820327948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_28B;
				IL_D7:
				num = (short)377356298;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				this.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = this.UclMDCCnv_CustomizedSysGrpNumber_A00032Object;
				num = (short)281280525;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28B:
				referencedNode = this.UclMDCCnv_SystemAlias_A00028Object.ReferencedNode;
				num = (short)1083244544;
				short num4 = num;
				num = (short)3604487;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			IL_1C6:
			IL_2F9:
			((global::AcpBusinessLayer.Recordset)base.ParentRecset).RefreshKeyForNode((global::AcpBusinessLayer.FeatureNode)base.Parent);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00216C7C File Offset: 0x00214E7C
		public override void DropReferences()
		{
			short num = (short)815333377;
			if (num != 0)
			{
			}
			num = (short)1800153159;
			short num2 = num;
			num = (short)372975687;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1525874688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1069940736;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00216D28 File Offset: 0x00214F28
		public override void SetConstraints()
		{
			short num = (short)1944940225;
			short num2 = num;
			num = (short)1019113153;
			switch (num2 == num)
			{
			}
			num = (short)760610816;
			short num3 = num;
			num = (short)631635969;
			if (num != 0)
			{
			}
			num = (short)1519648768;
			if (num != 0)
			{
			}
			this.uclMDCCnv_SystemAlias_A00028.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsMDCSystemAliasValid);
			this.uclMDCCnv_SystemGroupNumber_A00029.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conSetMDCSysGroupNumber);
			this.uclMDCCnv_SystemGroupNumber_A00029.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclMDCCnv_PrimaryID_A00030.ValidateAcrossRecset = true;
			this.uclMDCCnv_PrimaryID_A00030.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsPrimaryIdValid);
			this.uclMDCCnv_CallID_A00031.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclMDCCnv_SystemGroupNumber_A00029.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsNotCustomizedMDCSystem);
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsCustomizedMDCSystem);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00216E80 File Offset: 0x00215080
		public override void SetupDependencies()
		{
			short num = (short)238149329;
			short num2 = num;
			num = (short)1726275281;
			switch (num2 == num)
			{
			}
			num = (short)150142976;
			short num3 = num;
			num = (short)1614086145;
			if (num != 0)
			{
			}
			num = (short)866123776;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.MDCCallHotList mdccallHotList = ((global::AcpCommonLib.FeatureManager.GetFeature(2212)[0] as global::SpecialFeatures.Ucl.HotList.UclMDCCallHotList).MDCCallHotList.EmbeddedRecset as global::SpecialFeatures.Ucl.HotList.MDCCallHotListRecset)[0] as global::SpecialFeatures.Ucl.HotList.MDCCallHotList;
			this.uclMDCCnv_SystemAlias_A00028.AddDependentObject(mdccallHotList.HotListMDC.UclMDCCnvHotList_CallID_A00047Object);
			this.uclMDCCnv_CustomizedSysGrpNumber_A00032.AddDependentObject(mdccallHotList.HotListMDC.UclMDCCnvHotList_CallID_A00047Object);
			this.uclMDCCnv_PrimaryID_A00030.AddDependentObject(mdccallHotList.HotListMDC.UclMDCCnvHotList_CallID_A00047Object);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00216FA0 File Offset: 0x002151A0
		public void ResolveReferenceAfterUnpack()
		{
			short num = (short)135659520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::AcpBusinessLayer.AcpField<int> acpField;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						num = (short)482082827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1065025537;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
						if (general.CnvSysGeneralSystemType_A13262Value == 1)
						{
							num = (short)2042626048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CE;
					}
					case 2:
						return;
					case 3:
						goto IL_100;
					case 4:
						goto IL_1C9;
					case 5:
						num = (short)1687748615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_120;
					case 7:
					{
						if (acpField == 0)
						{
							num = (short)20447236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.uclMDCCnv_SystemAlias_A00028.DefaultValue = 65535;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
						num3 = 0;
						num = (short)1229127688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_120;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						if (num3 >= conventionalSystemRecset.Count)
						{
							num = (short)190316546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = conventionalSystemRecset[num3];
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General)acpFeatureNode[10118];
						num = (short)1327065728;
						short num4 = num;
						num = (short)1060465280;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)1725235200;
							if (num != 0)
							{
							}
							num = (short)1528496129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (acpField != null)
						{
							num = (short)323747845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
						if (general.CnvSysGeneralSystemGroupNumber_A21960Value == acpField.Value)
						{
							goto IL_E7;
						}
						goto IL_1CE;
					}
					}
					goto IL_5E;
					IL_E7:
					num = (short)945815555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)1038745600;
					short num5 = num;
					num = (short)2026438665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CE:
					num3++;
					num = (short)1332871174;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				this.uclMDCCnv_SystemAlias_A00028.DefaultValue = acpFeatureNode.Parent.IndexOf(acpFeatureNode) + 1;
				return;
				IL_102:
				this.uclMDCCnv_SystemAlias_A00028.DefaultValue = 0;
				this.UclMDCCnv_CustomizedSysGrpNumber_A00032Value = this.uclMDCCnv_CustomizedSysGrpNumber_A00032.DefaultValue;
				return;
				IL_1C9:
				goto IL_102;
				IL_5E:
				acpField = (global::AcpBusinessLayer.AcpField<int>)this.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField;
				num = (short)1860239370;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000CA1 RID: 3233
		private global::AcpBusinessLayer.AcpRecRefField uclMDCCnv_SystemAlias_A00028;

		// Token: 0x04000CA2 RID: 3234
		private global::AcpBusinessLayer.AcpPointerField<int> uclMDCCnv_SystemGroupNumber_A00029;

		// Token: 0x04000CA3 RID: 3235
		private global::AcpBusinessLayer.AcpCustomRangeField uclMDCCnv_PrimaryID_A00030;

		// Token: 0x04000CA4 RID: 3236
		private global::AcpBusinessLayer.AcpKeyField uclMDCCnv_CallID_A00031;

		// Token: 0x04000CA5 RID: 3237
		private global::AcpBusinessLayer.AcpRangeField<int, int> uclMDCCnv_CustomizedSysGrpNumber_A00032;

		// Token: 0x02000201 RID: 513
		internal class DecToHexConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001936 RID: 6454 RVA: 0x002172AC File Offset: 0x002154AC
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				int a_ = 0;
				short num;
				object result;
				try
				{
					num = (short)173035293;
					short num2 = num;
					num = (short)1787186973;
					switch (num2 == num)
					{
					}
					num = (short)261357568;
					if (num != 0)
					{
					}
					result = ((int)value).ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb82", a_), global::System.Globalization.CultureInfo.CurrentCulture);
				}
				catch
				{
					result = string.Empty;
				}
				num = (short)482344961;
				if (num != 0)
				{
				}
				num = (short)1936523264;
				short num3 = num;
				return result;
			}

			// Token: 0x06001937 RID: 6455 RVA: 0x0021739C File Offset: 0x0021559C
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num = (short)1050673156;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (num3 >= 0)
						{
							num = (short)258605057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 1:
						goto IL_FB;
					case 2:
						if (num3 <= 65535)
						{
							num = (short)2042953731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 3:
						num = (short)1238368256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
					{
						num = (short)654835712;
						short num4 = num;
						num = (short)2021919512;
						short num5 = num;
						num = (short)90114840;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FB;
						default:
							num = (short)95092736;
							if (num != 0)
							{
							}
							num = (short)672530434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_3C:
					if (!int.TryParse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out num3))
					{
						goto IL_18A;
					}
					num = (short)1228865537;
					if (num != 0)
					{
					}
					num = (short)962592773;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				return num3;
				IL_183:
				return 0;
				IL_18A:
				return 0;
			}
		}
	}
}
