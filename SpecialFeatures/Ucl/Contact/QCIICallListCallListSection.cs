using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000208 RID: 520
	[global::System.Serializable]
	public sealed class QCIICallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600199F RID: 6559 RVA: 0x00002650 File Offset: 0x00000850
		internal QCIICallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0021C45C File Offset: 0x0021A65C
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0021C510 File Offset: 0x0021A710
		public string SystemGroupNumber
		{
			get
			{
				short num = (short)1195194891;
				short num2 = num;
				num = (short)1420311051;
				switch (num2 == num)
				{
				}
				num = (short)1679425536;
				short num3 = num;
				num = (short)827588608;
				if (num != 0)
				{
				}
				num = (short)952303617;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Value;
			}
			set
			{
				int a_ = 16;
				short num = (short)858805976;
				short num2 = num;
				num = (short)40916696;
				switch (num2 == num)
				{
				}
				num = (short)1094516736;
				short num3 = num;
				num = (short)784400385;
				if (num != 0)
				{
				}
				num = (short)1626341376;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Value = value;
				this.combinedID.Value = string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺒", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺒", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺒", a_),
					this.toneBFreq.ToString()
				});
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0021C650 File Offset: 0x0021A850
		public global::AcpBusinessLayer.AcpField<string> SystemGroupNumberObject
		{
			get
			{
				short num = (short)312850156;
				short num2 = num;
				num = (short)1547024108;
				switch (num2 == num)
				{
				}
				num = (short)1669267456;
				short num3 = num;
				num = (short)686751745;
				if (num != 0)
				{
				}
				num = (short)1287913472;
				if (num != 0)
				{
				}
				return this.systemGroupNumber;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x0021C700 File Offset: 0x0021A900
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x0021C7B4 File Offset: 0x0021A9B4
		public bool SystemGroupNumber_Applicable
		{
			get
			{
				short num = (short)1829222012;
				short num2 = num;
				num = (short)132691580;
				switch (num2 == num)
				{
				}
				num = (short)238944256;
				short num3 = num;
				num = (short)1205141505;
				if (num != 0)
				{
				}
				num = (short)773062656;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Applicable;
			}
			set
			{
				short num = (short)347702279;
				short num2 = num;
				num = (short)174425095;
				switch (num2 == num)
				{
				}
				num = (short)427425792;
				short num3 = num;
				num = (short)1095172096;
				if (num != 0)
				{
				}
				num = (short)2114387969;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Applicable = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x0021C86C File Offset: 0x0021AA6C
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0021C920 File Offset: 0x0021AB20
		public bool SystemGroupNumber_Editable
		{
			get
			{
				short num = (short)745052283;
				short num2 = num;
				num = (short)21338235;
				switch (num2 == num)
				{
				}
				num = (short)1788149760;
				short num3 = num;
				num = (short)1609564161;
				if (num != 0)
				{
				}
				num = (short)1576730624;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Editable;
			}
			set
			{
				short num = (short)748124566;
				short num2 = num;
				num = (short)731740566;
				switch (num2 == num)
				{
				}
				num = (short)1464205312;
				short num3 = num;
				num = (short)492240897;
				if (num != 0)
				{
				}
				num = (short)741277696;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Editable = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x0021C9D4 File Offset: 0x0021ABD4
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0021CA88 File Offset: 0x0021AC88
		public bool SystemGroupNumber_Visible
		{
			get
			{
				short num = (short)777283468;
				short num2 = num;
				num = (short)337012620;
				switch (num2 == num)
				{
				}
				num = (short)208404480;
				short num3 = num;
				num = (short)1848246273;
				if (num != 0)
				{
				}
				num = (short)608698368;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Visible;
			}
			set
			{
				short num = (short)53662366;
				short num2 = num;
				num = (short)1646842526;
				switch (num2 == num)
				{
				}
				num = (short)1814495232;
				short num3 = num;
				num = (short)645136384;
				if (num != 0)
				{
				}
				num = (short)2069233665;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Visible = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x0021CB40 File Offset: 0x0021AD40
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0021CBF4 File Offset: 0x0021ADF4
		public bool SystemGroupNumber_Valid
		{
			get
			{
				short num = (short)1856714395;
				short num2 = num;
				num = (short)978531995;
				switch (num2 == num)
				{
				}
				num = (short)234553344;
				short num3 = num;
				num = (short)900333568;
				if (num != 0)
				{
				}
				num = (short)1998848001;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Valid;
			}
			set
			{
				short num = (short)1302906056;
				short num2 = num;
				num = (short)601998536;
				switch (num2 == num)
				{
				}
				num = (short)285409280;
				short num3 = num;
				num = (short)873463809;
				if (num != 0)
				{
				}
				num = (short)1555824640;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Valid = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x0021CCAC File Offset: 0x0021AEAC
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0021CD68 File Offset: 0x0021AF68
		public string CallFormat
		{
			get
			{
				short num = (short)2134773633;
				short num2 = num;
				num = (short)1185484673;
				switch (num2 == num)
				{
				}
				num = (short)2038693888;
				short num3 = num;
				num = (short)561315841;
				if (num != 0)
				{
				}
				num = (short)1414922240;
				if (num != 0)
				{
				}
				return this.callFormat.Value;
			}
			set
			{
				int a_ = 4;
				short num = (short)285147137;
				if (num != 0)
				{
				}
				num = (short)1221938756;
				short num2 = num;
				num = (short)727469636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1138163712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534590976;
				if (num != 0)
				{
				}
				this.callFormat.Value = value;
				this.combinedID.Value = string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪆ", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪆ", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪆ", a_),
					this.toneBFreq.ToString()
				});
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0021CEA8 File Offset: 0x0021B0A8
		public global::AcpBusinessLayer.AcpField<string> CallFormatObject
		{
			get
			{
				short num = (short)709684916;
				short num2 = num;
				num = (short)613150388;
				switch (num2 == num)
				{
				}
				num = (short)311099392;
				short num3 = num;
				num = (short)1614807041;
				if (num != 0)
				{
				}
				num = (short)2113404928;
				if (num != 0)
				{
				}
				return this.callFormat;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0021CF58 File Offset: 0x0021B158
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0021D00C File Offset: 0x0021B20C
		public bool CallFormat_Applicable
		{
			get
			{
				short num = (short)136630517;
				short num2 = num;
				num = (short)1106759925;
				switch (num2 == num)
				{
				}
				num = (short)1934295040;
				short num3 = num;
				num = (short)989528065;
				if (num != 0)
				{
				}
				num = (short)803930112;
				if (num != 0)
				{
				}
				return this.callFormat.Applicable;
			}
			set
			{
				short num = (short)1871118337;
				if (num != 0)
				{
				}
				num = (short)167967090;
				short num2 = num;
				num = (short)995817842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355612160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842989568;
				if (num != 0)
				{
				}
				this.callFormat.Applicable = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0021D0C4 File Offset: 0x0021B2C4
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0021D17C File Offset: 0x0021B37C
		public bool CallFormat_Editable
		{
			get
			{
				short num = (short)860166525;
				short num2 = num;
				num = (short)1847728509;
				switch (num2 == num)
				{
				}
				num = (short)260177920;
				short num3 = num;
				num = (short)1104609281;
				if (num != 0)
				{
				}
				num = (short)1682833408;
				if (num != 0)
				{
				}
				return this.callFormat.Editable;
			}
			set
			{
				short num = (short)1125105628;
				short num2 = num;
				num = (short)2026684380;
				switch (num2 == num)
				{
				}
				num = (short)762839040;
				short num3 = num;
				num = (short)353632257;
				if (num != 0)
				{
				}
				num = (short)525139968;
				if (num != 0)
				{
				}
				this.callFormat.Editable = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x0021D234 File Offset: 0x0021B434
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0021D2E8 File Offset: 0x0021B4E8
		public bool CallFormat_Visible
		{
			get
			{
				short num = (short)1317508001;
				short num2 = num;
				num = (short)817140641;
				switch (num2 == num)
				{
				}
				num = (short)1220608000;
				short num3 = num;
				num = (short)522977281;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				if (num != 0)
				{
				}
				return this.callFormat.Visible;
			}
			set
			{
				short num = (short)666277580;
				short num2 = num;
				num = (short)182359756;
				switch (num2 == num)
				{
				}
				num = (short)1695809536;
				short num3 = num;
				num = (short)2107244544;
				if (num != 0)
				{
				}
				num = (short)1561722881;
				if (num != 0)
				{
				}
				this.callFormat.Visible = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0021D39C File Offset: 0x0021B59C
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0021D454 File Offset: 0x0021B654
		public bool CallFormat_Valid
		{
			get
			{
				short num = (short)628617829;
				short num2 = num;
				num = (short)393933413;
				switch (num2 == num)
				{
				}
				num = (short)1057751040;
				short num3 = num;
				num = (short)1302790145;
				if (num != 0)
				{
				}
				num = (short)251068416;
				if (num != 0)
				{
				}
				return this.callFormat.Valid;
			}
			set
			{
				short num = (short)176227525;
				short num2 = num;
				num = (short)1802306757;
				switch (num2 == num)
				{
				}
				num = (short)1898971136;
				short num3 = num;
				num = (short)897712129;
				if (num != 0)
				{
				}
				num = (short)2002780160;
				if (num != 0)
				{
				}
				this.callFormat.Valid = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0021D508 File Offset: 0x0021B708
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0021D5BC File Offset: 0x0021B7BC
		public string ToneAFreq
		{
			get
			{
				short num = (short)1521046881;
				short num2 = num;
				num = (short)625562977;
				switch (num2 == num)
				{
				}
				num = (short)707461120;
				short num3 = num;
				num = (short)215351296;
				if (num != 0)
				{
				}
				num = (short)427622401;
				if (num != 0)
				{
				}
				return this.toneAFreq.Value;
			}
			set
			{
				int a_ = 5;
				short num = (short)1252351614;
				short num2 = num;
				num = (short)227171966;
				switch (num2 == num)
				{
				}
				num = (short)953942016;
				short num3 = num;
				num = (short)733544449;
				if (num != 0)
				{
				}
				num = (short)194904064;
				if (num != 0)
				{
				}
				this.toneAFreq.Value = value;
				this.combinedID.Value = string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖇ", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖇ", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖇ", a_),
					this.toneBFreq.ToString()
				});
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0021D6FC File Offset: 0x0021B8FC
		public global::AcpBusinessLayer.AcpField<string> ToneAFreqObject
		{
			get
			{
				short num = (short)1304100865;
				if (num != 0)
				{
				}
				num = (short)1861479116;
				short num2 = num;
				num = (short)259844812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246874112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463863808;
				if (num != 0)
				{
				}
				return this.toneAFreq;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0021D7AC File Offset: 0x0021B9AC
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x0021D85C File Offset: 0x0021BA5C
		public bool ToneAFreq_Applicable
		{
			get
			{
				short num = (short)770373615;
				short num2 = num;
				num = (short)927856623;
				switch (num2 == num)
				{
				}
				num = (short)706936832;
				short num3 = num;
				num = (short)1037500416;
				if (num != 0)
				{
				}
				num = (short)1607532545;
				if (num != 0)
				{
				}
				return this.toneAFreq.Applicable;
			}
			set
			{
				short num = (short)1505439884;
				short num2 = num;
				num = (short)1378300044;
				switch (num2 == num)
				{
				}
				num = (short)1496317952;
				short num3 = num;
				num = (short)884015105;
				if (num != 0)
				{
				}
				num = (short)765984768;
				if (num != 0)
				{
				}
				this.toneAFreq.Applicable = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0021D914 File Offset: 0x0021BB14
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x0021D9CC File Offset: 0x0021BBCC
		public bool ToneAFreq_Editable
		{
			get
			{
				short num = (short)861273706;
				short num2 = num;
				num = (short)1344339562;
				switch (num2 == num)
				{
				}
				num = (short)549453824;
				short num3 = num;
				num = (short)1607204865;
				if (num != 0)
				{
				}
				num = (short)1272971264;
				if (num != 0)
				{
				}
				return this.toneAFreq.Editable;
			}
			set
			{
				short num = (short)1204415053;
				short num2 = num;
				num = (short)209709645;
				switch (num2 == num)
				{
				}
				num = (short)1682309120;
				short num3 = num;
				num = (short)2006712321;
				if (num != 0)
				{
				}
				num = (short)1074397184;
				if (num != 0)
				{
				}
				this.toneAFreq.Editable = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0021DA80 File Offset: 0x0021BC80
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x0021DB34 File Offset: 0x0021BD34
		public bool ToneAFreq_Visible
		{
			get
			{
				short num = (short)1177354241;
				if (num != 0)
				{
				}
				num = (short)1636416337;
				short num2 = num;
				num = (short)45726545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481244672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				return this.toneAFreq.Visible;
			}
			set
			{
				short num = (short)359071745;
				if (num != 0)
				{
				}
				num = (short)679145079;
				short num2 = num;
				num = (short)13561463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023882752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				this.toneAFreq.Visible = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0021DBEC File Offset: 0x0021BDEC
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0021DCA0 File Offset: 0x0021BEA0
		public bool ToneAFreq_Valid
		{
			get
			{
				short num = (short)1710821094;
				short num2 = num;
				num = (short)2003046118;
				switch (num2 == num)
				{
				}
				num = (short)38797312;
				short num3 = num;
				num = (short)1995767808;
				if (num != 0)
				{
				}
				num = (short)541130753;
				if (num != 0)
				{
				}
				return this.toneAFreq.Valid;
			}
			set
			{
				short num = (short)719670353;
				short num2 = num;
				num = (short)751193169;
				switch (num2 == num)
				{
				}
				num = (short)1039138816;
				short num3 = num;
				num = (short)1576665088;
				if (num != 0)
				{
				}
				num = (short)1879375873;
				if (num != 0)
				{
				}
				this.toneAFreq.Valid = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0021DD58 File Offset: 0x0021BF58
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0021DE14 File Offset: 0x0021C014
		public string ToneBFreq
		{
			get
			{
				short num = (short)1683264879;
				short num2 = num;
				num = (short)1152030063;
				switch (num2 == num)
				{
				}
				num = (short)938672128;
				short num3 = num;
				num = (short)360316929;
				if (num != 0)
				{
				}
				num = (short)662241280;
				if (num != 0)
				{
				}
				return this.toneBFreq.Value;
			}
			set
			{
				int a_ = 11;
				short num = (short)1361632535;
				short num2 = num;
				num = (short)1462885655;
				switch (num2 == num)
				{
				}
				num = (short)371916800;
				short num3 = num;
				num = (short)1748631552;
				if (num != 0)
				{
				}
				num = (short)828178433;
				if (num != 0)
				{
				}
				this.toneAFreq.Value = value;
				this.combinedID.Value = string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.toneBFreq.ToString()
				});
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0021DF50 File Offset: 0x0021C150
		public global::AcpBusinessLayer.AcpField<string> ToneBFreqObject
		{
			get
			{
				short num = (short)1401200734;
				short num2 = num;
				num = (short)170958942;
				switch (num2 == num)
				{
				}
				num = (short)1084882944;
				short num3 = num;
				num = (short)1124532224;
				if (num != 0)
				{
				}
				num = (short)760283137;
				if (num != 0)
				{
				}
				return this.toneBFreq;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0021E000 File Offset: 0x0021C200
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0021E0B4 File Offset: 0x0021C2B4
		public bool ToneBFreq_Applicable
		{
			get
			{
				short num = (short)110641922;
				short num2 = num;
				num = (short)1276920578;
				switch (num2 == num)
				{
				}
				num = (short)25821184;
				short num3 = num;
				num = (short)648019969;
				if (num != 0)
				{
				}
				num = (short)1772879872;
				if (num != 0)
				{
				}
				return this.toneBFreq.Applicable;
			}
			set
			{
				short num = (short)114706253;
				short num2 = num;
				num = (short)186795853;
				switch (num2 == num)
				{
				}
				num = (short)576978944;
				short num3 = num;
				num = (short)1687617537;
				if (num != 0)
				{
				}
				num = (short)1331822592;
				if (num != 0)
				{
				}
				this.toneBFreq.Applicable = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0021E168 File Offset: 0x0021C368
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0021E21C File Offset: 0x0021C41C
		public bool ToneBFreq_Editable
		{
			get
			{
				short num = (short)793026236;
				short num2 = num;
				num = (short)1628610236;
				switch (num2 == num)
				{
				}
				num = (short)740884480;
				short num3 = num;
				num = (short)1854996480;
				if (num != 0)
				{
				}
				num = (short)1669791745;
				if (num != 0)
				{
				}
				return this.toneBFreq.Editable;
			}
			set
			{
				short num = (short)261156649;
				short num2 = num;
				num = (short)1669459753;
				switch (num2 == num)
				{
				}
				num = (short)797900800;
				short num3 = num;
				num = (short)355336192;
				if (num != 0)
				{
				}
				num = (short)421134337;
				if (num != 0)
				{
				}
				this.toneBFreq.Editable = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0021E2D0 File Offset: 0x0021C4D0
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0021E388 File Offset: 0x0021C588
		public bool ToneBFreq_Visible
		{
			get
			{
				short num = (short)514188862;
				short num2 = num;
				num = (short)2016601662;
				switch (num2 == num)
				{
				}
				num = (short)752812032;
				short num3 = num;
				num = (short)262668289;
				if (num != 0)
				{
				}
				num = (short)1588854784;
				if (num != 0)
				{
				}
				return this.toneBFreq.Visible;
			}
			set
			{
				short num = (short)1167948237;
				short num2 = num;
				num = (short)2068806093;
				switch (num2 == num)
				{
				}
				num = (short)1235550208;
				short num3 = num;
				num = (short)987430913;
				if (num != 0)
				{
				}
				num = (short)381091840;
				if (num != 0)
				{
				}
				this.toneBFreq.Visible = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0021E440 File Offset: 0x0021C640
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0021E4F4 File Offset: 0x0021C6F4
		public bool ToneBFreq_Valid
		{
			get
			{
				short num = (short)988585921;
				short num2 = num;
				num = (short)716742593;
				switch (num2 == num)
				{
				}
				num = (short)1826357248;
				short num3 = num;
				num = (short)2136473600;
				if (num != 0)
				{
				}
				num = (short)846266369;
				if (num != 0)
				{
				}
				return this.toneBFreq.Valid;
			}
			set
			{
				short num = (short)998728038;
				short num2 = num;
				num = (short)546988390;
				switch (num2 == num)
				{
				}
				num = (short)1022689280;
				short num3 = num;
				num = (short)1585643521;
				if (num != 0)
				{
				}
				num = (short)523698176;
				if (num != 0)
				{
				}
				this.toneBFreq.Valid = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0021E5A8 File Offset: 0x0021C7A8
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0021E6D0 File Offset: 0x0021C8D0
		public string CombinedID
		{
			get
			{
				int a_ = 11;
				short num = (short)310075586;
				short num2 = num;
				num = (short)453206210;
				switch (num2 == num)
				{
				}
				num = (short)1922498560;
				short num3 = num;
				num = (short)1311965185;
				if (num != 0)
				{
				}
				num = (short)314703872;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎍ", a_),
					this.toneBFreq.ToString()
				});
			}
			set
			{
				int a_ = 1;
				short num = (short)501459173;
				short num2 = num;
				num = (short)91138277;
				switch (num2 == num)
				{
				}
				num = (short)338952192;
				short num3 = num;
				num = (short)412942337;
				if (num != 0)
				{
				}
				num = (short)1306132480;
				if (num != 0)
				{
				}
				this.combinedID.Value = string.Concat(new string[]
				{
					this.systemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦃ", a_),
					this.callFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦃ", a_),
					this.toneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦃ", a_),
					this.toneBFreq.ToString()
				});
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0021E804 File Offset: 0x0021CA04
		public global::AcpBusinessLayer.AcpKeyField CombinedIDObject
		{
			get
			{
				short num = (short)660148018;
				short num2 = num;
				num = (short)106237746;
				switch (num2 == num)
				{
				}
				num = (short)1735458816;
				short num3 = num;
				num = (short)78577665;
				if (num != 0)
				{
				}
				num = (short)894828544;
				if (num != 0)
				{
				}
				return this.combinedID;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0021E8B4 File Offset: 0x0021CAB4
		public string CombinedID_UILabel
		{
			get
			{
				short num = (short)1618350041;
				short num2 = num;
				num = (short)2002259929;
				switch (num2 == num)
				{
				}
				num = (short)1973288960;
				short num3 = num;
				num = (short)340590593;
				if (num != 0)
				{
				}
				num = (short)552599552;
				if (num != 0)
				{
				}
				return this.combinedID.UIName;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0021E968 File Offset: 0x0021CB68
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0021EA1C File Offset: 0x0021CC1C
		public bool CombinedID_Applicable
		{
			get
			{
				short num = (short)1264889774;
				short num2 = num;
				num = (short)1230221230;
				switch (num2 == num)
				{
				}
				num = (short)849215488;
				short num3 = num;
				num = (short)625344513;
				if (num != 0)
				{
				}
				num = (short)1461780480;
				if (num != 0)
				{
				}
				return this.combinedID.Applicable;
			}
			set
			{
				short num = (short)724369408;
				short num2 = num;
				num = (short)1007026177;
				if (num != 0)
				{
				}
				num = (short)1421347507;
				short num3 = num;
				num = (short)1609566899;
				switch (num3 == num)
				{
				}
				num = (short)1333592064;
				if (num != 0)
				{
				}
				this.combinedID.Applicable = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0021EAD4 File Offset: 0x0021CCD4
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0021EB8C File Offset: 0x0021CD8C
		public bool CombinedID_Editable
		{
			get
			{
				short num = (short)1858863104;
				short num2 = num;
				num = (short)2063030892;
				short num3 = num;
				num = (short)1374116460;
				switch (num3 == num)
				{
				}
				num = (short)811139073;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				if (num != 0)
				{
				}
				return this.combinedID.Editable;
			}
			set
			{
				short num = (short)1581056000;
				short num2 = num;
				num = (short)854527277;
				short num3 = num;
				num = (short)760679725;
				switch (num3 == num)
				{
				}
				num = (short)1518141441;
				if (num != 0)
				{
				}
				num = (short)633012224;
				if (num != 0)
				{
				}
				this.combinedID.Editable = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x0021EC40 File Offset: 0x0021CE40
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x0021ECF4 File Offset: 0x0021CEF4
		public bool CombinedID_Visible
		{
			get
			{
				short num = (short)54001664;
				short num2 = num;
				num = (short)691611597;
				short num3 = num;
				num = (short)1757095885;
				switch (num3 == num)
				{
				}
				num = (short)853147648;
				if (num != 0)
				{
				}
				num = (short)155844609;
				if (num != 0)
				{
				}
				return this.combinedID.Visible;
			}
			set
			{
				short num = (short)1172439040;
				short num2 = num;
				num = (short)1567323078;
				short num3 = num;
				num = (short)971797446;
				switch (num3 == num)
				{
				}
				num = (short)731578368;
				if (num != 0)
				{
				}
				num = (short)1748566017;
				if (num != 0)
				{
				}
				this.combinedID.Visible = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0021EDAC File Offset: 0x0021CFAC
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0021EE60 File Offset: 0x0021D060
		internal bool CombinedID_HiddenStatic
		{
			get
			{
				short num = (short)109117440;
				short num2 = num;
				num = (short)1995243521;
				if (num != 0)
				{
				}
				num = (short)1429893111;
				short num3 = num;
				num = (short)1524985847;
				switch (num3 == num)
				{
				}
				num = (short)90112000;
				if (num != 0)
				{
				}
				return this.combinedID.HiddenStatic;
			}
			set
			{
				short num = (short)122814464;
				short num2 = num;
				num = (short)1395602758;
				short num3 = num;
				num = (short)2093299014;
				switch (num3 == num)
				{
				}
				num = (short)295501825;
				if (num != 0)
				{
				}
				num = (short)583073792;
				if (num != 0)
				{
				}
				this.combinedID.HiddenStatic = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0021EF14 File Offset: 0x0021D114
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0021EFC8 File Offset: 0x0021D1C8
		public bool CombinedID_Valid
		{
			get
			{
				short num = (short)158793728;
				short num2 = num;
				num = (short)51183990;
				short num3 = num;
				num = (short)432341366;
				switch (num3 == num)
				{
				}
				num = (short)194969601;
				if (num != 0)
				{
				}
				num = (short)556531712;
				if (num != 0)
				{
				}
				return this.combinedID.Valid;
			}
			set
			{
				short num = (short)1386807296;
				short num2 = num;
				num = (short)1846696046;
				short num3 = num;
				num = (short)777082990;
				switch (num3 == num)
				{
				}
				num = (short)483196928;
				if (num != 0)
				{
				}
				num = (short)2137325569;
				if (num != 0)
				{
				}
				this.combinedID.Valid = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0021F07C File Offset: 0x0021D27C
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0021F130 File Offset: 0x0021D330
		public bool IsHotListItem
		{
			get
			{
				short num = (short)213188608;
				short num2 = num;
				num = (short)389008303;
				short num3 = num;
				num = (short)719375279;
				switch (num3 == num)
				{
				}
				num = (short)1114570753;
				if (num != 0)
				{
				}
				num = (short)1863254016;
				if (num != 0)
				{
				}
				return this.combinedID.IsReferenced;
			}
			set
			{
				short num = (short)1739390976;
				short num2 = num;
				num = (short)1802931224;
				short num3 = num;
				num = (short)610765848;
				switch (num3 == num)
				{
				}
				num = (short)191102977;
				if (num != 0)
				{
				}
				num = (short)182845440;
				if (num != 0)
				{
				}
				this.isHotListItem.Value = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x0021F1E4 File Offset: 0x0021D3E4
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0021F29C File Offset: 0x0021D49C
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Applicable
		{
			get
			{
				short num = (short)630128640;
				short num2 = num;
				num = (short)1013934063;
				short num3 = num;
				num = (short)880044015;
				switch (num3 == num)
				{
				}
				num = (short)702873600;
				if (num != 0)
				{
				}
				num = (short)1250492417;
				if (num != 0)
				{
				}
				return this.isHotListItem.Applicable;
			}
			set
			{
				short num = (short)1274937344;
				short num2 = num;
				num = (short)1691253547;
				short num3 = num;
				num = (short)1269725995;
				switch (num3 == num)
				{
				}
				num = (short)250478592;
				if (num != 0)
				{
				}
				num = (short)185991169;
				if (num != 0)
				{
				}
				this.isHotListItem.Applicable = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0021F350 File Offset: 0x0021D550
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0021F408 File Offset: 0x0021D608
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Editable
		{
			get
			{
				short num = (short)1859780608;
				short num2 = num;
				num = (short)434666814;
				short num3 = num;
				num = (short)328498494;
				switch (num3 == num)
				{
				}
				num = (short)139657217;
				if (num != 0)
				{
				}
				num = (short)228458496;
				if (num != 0)
				{
				}
				return this.isHotListItem.Editable;
			}
			set
			{
				short num = (short)315883520;
				short num2 = num;
				num = (short)792396;
				short num3 = num;
				num = (short)1520703308;
				switch (num3 == num)
				{
				}
				num = (short)1858404352;
				if (num != 0)
				{
				}
				num = (short)1651245057;
				if (num != 0)
				{
				}
				this.isHotListItem.Editable = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0021F4BC File Offset: 0x0021D6BC
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0021F574 File Offset: 0x0021D774
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Visible
		{
			get
			{
				short num = (short)2074673152;
				short num2 = num;
				num = (short)1381320739;
				short num3 = num;
				num = (short)1250773027;
				switch (num3 == num)
				{
				}
				num = (short)1457979393;
				if (num != 0)
				{
				}
				num = (short)110362624;
				if (num != 0)
				{
				}
				return this.isHotListItem.Visible;
			}
			set
			{
				short num = (short)1875836928;
				short num2 = num;
				num = (short)2000532962;
				short num3 = num;
				num = (short)1718531554;
				switch (num3 == num)
				{
				}
				num = (short)1086128128;
				if (num != 0)
				{
				}
				num = (short)1364656129;
				if (num != 0)
				{
				}
				this.isHotListItem.Visible = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0021F628 File Offset: 0x0021D828
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0021F6E0 File Offset: 0x0021D8E0
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Valid
		{
			get
			{
				short num = (short)990511104;
				short num2 = num;
				num = (short)1938670384;
				short num3 = num;
				num = (short)1980220208;
				switch (num3 == num)
				{
				}
				num = (short)1375862785;
				if (num != 0)
				{
				}
				num = (short)776339456;
				if (num != 0)
				{
				}
				return this.isHotListItem.Valid;
			}
			set
			{
				short num = (short)344195072;
				short num2 = num;
				num = (short)1235925205;
				short num3 = num;
				num = (short)1122220245;
				switch (num3 == num)
				{
				}
				num = (short)739442688;
				if (num != 0)
				{
				}
				num = (short)1938685953;
				if (num != 0)
				{
				}
				this.isHotListItem.Valid = value;
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0000265F File Offset: 0x0000085F
		internal QCIICallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0021F798 File Offset: 0x0021D998
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1680998400;
			short num2 = num;
			num = (short)571347357;
			short num3 = num;
			num = (short)1828327837;
			switch (num3 == num)
			{
			}
			num = (short)320798721;
			if (num != 0)
			{
			}
			num = (short)1562836992;
			if (num != 0)
			{
			}
			this.systemGroupNumber = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("Ꚓꂔ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒ﺚ\ud89e펠첢키힦\udeaa사춮풰솲", a_), global::CommonResources.AppResources.System_Group_Number);
			this.callFormat = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf92杖練ﺘ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒ﮖ\udd9a철슢톤", a_), global::CommonResources.AppResources.Call_Format);
			this.toneAFreq = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊒ궔ꎖ꺘떚ꢜꦞ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잒杖練ﲘ\uda9a\udb9c쒠튢", a_), global::CommonResources.AppResources.Tone_A_Freq);
			this.toneBFreq = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆒꂔ꺖꺘떚겜ꦞ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잒杖練ﲘ\ud99a\udb9c쒠튢", a_), global::CommonResources.AppResources.Tone_B_Freq);
			this.combinedID = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒杖殺ﮘ爵얠", a_), global::CommonResources.AppResources.Call_ID);
			this.isHotListItem = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda92\udf96톜튠힢펦첨욪", a_), global::CommonResources.AppResources.Hot_Listed);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒ﮖ뮚톜튠힢", a_);
			base.UIName = global::CommonResources.AppResources.Call_List;
			base.Id = 10410;
			base.DataTransferOrder = 7;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0021F96C File Offset: 0x0021DB6C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)792985600;
			short num2 = num;
			num = (short)1923100823;
			short num3 = num;
			num = (short)461123735;
			switch (num3 == num)
			{
			}
			num = (short)720896;
			if (num != 0)
			{
			}
			num = (short)1283457025;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0021FA1C File Offset: 0x0021DC1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1635057679;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2134441985;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐璉ﮖ\udf98삠힢", a_)))
					{
						num = (short)1178861570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31B;
				case 1:
					goto IL_41A;
				case 2:
					this.callFormat = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd90ﲒﮔ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐璉ﮖ\udf98삠힢", a_), global::CommonResources.AppResources.Call_Format);
					num = (short)1661665290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1756495885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.combinedID = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐ﲒﮞ", a_), global::CommonResources.AppResources.Call_ID);
					num = (short)1230569491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)911015952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐ﲒﮞ", a_)))
					{
						num = (short)774963204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_188;
				case 7:
					goto IL_316;
				case 8:
					this.toneBFreq = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎐꚒ겔ꂖ래ꪚꮜ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐ﲒﮔ\udb98\udd9a爵킠", a_), global::CommonResources.AppResources.Tone_B_Freq);
					num = (short)1852833810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.isHotListItem = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890\udd94힚햠톤슦쒨", a_), global::CommonResources.AppResources.Hot_Listed);
					num = (short)1151664135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_31B;
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐ﲒﮔ\udb98\udd9a爵킠", a_)))
					{
						num = (short)643760136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 12:
				{
					if (!producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890\udd94힚햠톤슦쒨", a_)))
					{
						goto IL_4EE;
					}
					num = (short)1950220288;
					short num3 = num;
					num = (short)1063499376;
					short num4 = num;
					num = (short)663008880;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_34B;
					default:
						num = (short)1188823040;
						if (num != 0)
						{
						}
						num = (short)11075593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					if (producerFields != null)
					{
						num = (short)839122949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4EE;
				case 14:
					this.systemGroupNumber = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒐Ꚓ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐ﲘ\uda9c캠횢햤\udca8욪쾬쪮쎰", a_), global::CommonResources.AppResources.System_Group_Number);
					num = (short)1737359380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 16:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐ﲘ\uda9c캠횢햤\udca8욪쾬쪮쎰", a_)))
					{
						num = (short)616235022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_368;
				case 17:
					this.toneAFreq = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂐꮒꆔꂖ래꺚ꮜ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐ﲒﮔ\ud898\udd9a爵킠", a_), global::CommonResources.AppResources.Tone_A_Freq);
					num = (short)1947271169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_A9;
				case 19:
					goto IL_188;
				case 20:
					goto IL_368;
				case 21:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐ﲒﮔ\ud898\udd9a爵킠", a_)))
					{
						goto IL_34B;
					}
					goto IL_41A;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1297940483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1318912006;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_188:
				num = (short)1580859404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31B:
				num = (short)63242261;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34B:
				num = (short)13828113;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_368:
				num = (short)329580544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41A:
				num = (short)356515851;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_316:
			IL_4EE:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐璉ﮖ릘힚햠", a_);
			base.UIName = global::CommonResources.AppResources.Call_List;
			base.Id = 10410;
			base.DataTransferOrder = 7;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0021FF48 File Offset: 0x0021E148
		public override void PopulateReferences()
		{
			short num = (short)1856045056;
			short num2 = num;
			num = (short)1750204417;
			if (num != 0)
			{
			}
			num = (short)539808303;
			short num3 = num;
			num = (short)1760809519;
			switch (num3 == num)
			{
			}
			num = (short)1662189568;
			if (num != 0)
			{
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0021FFF0 File Offset: 0x0021E1F0
		public override void DropReferences()
		{
			short num = (short)177799168;
			short num2 = num;
			num = (short)703275296;
			short num3 = num;
			num = (short)621027616;
			switch (num3 == num)
			{
			}
			num = (short)1792671744;
			if (num != 0)
			{
			}
			num = (short)1499660289;
			if (num != 0)
			{
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00220098 File Offset: 0x0021E298
		public override void SetConstraints()
		{
			short num = (short)1742602240;
			short num2 = num;
			num = (short)1721541751;
			short num3 = num;
			num = (short)1411622007;
			switch (num3 == num)
			{
			}
			num = (short)1878982657;
			if (num != 0)
			{
			}
			num = (short)540737536;
			if (num != 0)
			{
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00220144 File Offset: 0x0021E344
		public override void SetupDependencies()
		{
			short num = (short)1228275712;
			short num2 = num;
			num = (short)43430030;
			short num3 = num;
			num = (short)2124132494;
			switch (num3 == num)
			{
			}
			num = (short)1577123841;
			if (num != 0)
			{
			}
			num = (short)440139776;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000CB3 RID: 3251
		private global::AcpBusinessLayer.AcpField<string> systemGroupNumber;

		// Token: 0x04000CB4 RID: 3252
		private global::AcpBusinessLayer.AcpField<string> callFormat;

		// Token: 0x04000CB5 RID: 3253
		private global::AcpBusinessLayer.AcpField<string> toneAFreq;

		// Token: 0x04000CB6 RID: 3254
		private global::AcpBusinessLayer.AcpField<string> toneBFreq;

		// Token: 0x04000CB7 RID: 3255
		private global::AcpBusinessLayer.AcpKeyField combinedID;

		// Token: 0x04000CB8 RID: 3256
		private global::AcpBusinessLayer.AcpField<bool> isHotListItem;
	}
}
