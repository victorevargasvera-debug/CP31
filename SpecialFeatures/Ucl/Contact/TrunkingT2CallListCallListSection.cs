using System;
using System.Collections.Generic;
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
	// Token: 0x0200020F RID: 527
	[global::System.Serializable]
	public sealed class TrunkingT2CallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x00003DBE File Offset: 0x00001FBE
		internal TrunkingT2CallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.uclT2Trk_SystemID_A00018.PointedField = this.uclT2Trk_CustomizedSystemID_A00021;
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00229DB8 File Offset: 0x00227FB8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1694554635;
				short num2 = num;
				num = (short)1992940043;
				switch (num2 == num)
				{
				}
				num = (short)1189216256;
				short num3 = num;
				num = (short)1700855809;
				if (num != 0)
				{
				}
				num = (short)205389824;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00229E68 File Offset: 0x00228068
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00229F1C File Offset: 0x0022811C
		public int UclT2Trk_SystemAlias_A00017Value
		{
			get
			{
				short num = (short)217766220;
				short num2 = num;
				num = (short)180017484;
				switch (num2 == num)
				{
				}
				num = (short)1189478400;
				short num3 = num;
				num = (short)85000193;
				if (num != 0)
				{
				}
				num = (short)358678528;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.Value;
			}
			set
			{
				short num = (short)1017410771;
				short num2 = num;
				num = (short)403797203;
				switch (num2 == num)
				{
				}
				num = (short)1549991936;
				short num3 = num;
				num = (short)880345089;
				if (num != 0)
				{
				}
				num = (short)89718784;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.Value = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00229FD4 File Offset: 0x002281D4
		public global::AcpBusinessLayer.AcpRecRefField UclT2Trk_SystemAlias_A00017Object
		{
			get
			{
				short num = (short)232128513;
				if (num != 0)
				{
				}
				num = (short)861806767;
				short num2 = num;
				num = (short)861479087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610992128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076166656;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0022A084 File Offset: 0x00228284
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0022A138 File Offset: 0x00228338
		public string UclT2Trk_SystemAlias_A00017_UIValue
		{
			get
			{
				short num = (short)1360811151;
				short num2 = num;
				num = (short)2067420303;
				switch (num2 == num)
				{
				}
				num = (short)481624064;
				short num3 = num;
				num = (short)785645569;
				if (num != 0)
				{
				}
				num = (short)1354301440;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.UIValue;
			}
			set
			{
				short num = (short)1082194598;
				short num2 = num;
				num = (short)165935782;
				switch (num2 == num)
				{
				}
				num = (short)1900740608;
				short num3 = num;
				num = (short)1812594688;
				if (num != 0)
				{
				}
				num = (short)1360658433;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.UIValue = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0022A1EC File Offset: 0x002283EC
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0022A2A0 File Offset: 0x002284A0
		public bool UclT2Trk_SystemAlias_A00017_Applicable
		{
			get
			{
				short num = (short)174718977;
				if (num != 0)
				{
				}
				num = (short)904287282;
				short num2 = num;
				num = (short)475288626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)154796032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)924712960;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.Applicable;
			}
			set
			{
				short num = (short)1696003837;
				short num2 = num;
				num = (short)94566141;
				switch (num2 == num)
				{
				}
				num = (short)442236928;
				short num3 = num;
				num = (short)171245569;
				if (num != 0)
				{
				}
				num = (short)1240203264;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.Applicable = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0022A358 File Offset: 0x00228558
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0022A40C File Offset: 0x0022860C
		public bool UclT2Trk_SystemAlias_A00017_Editable
		{
			get
			{
				short num = (short)184678341;
				short num2 = num;
				num = (short)283768773;
				switch (num2 == num)
				{
				}
				num = (short)788594688;
				short num3 = num;
				num = (short)1373831169;
				if (num != 0)
				{
				}
				num = (short)1824063488;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.Editable;
			}
			set
			{
				short num = (short)604380336;
				short num2 = num;
				num = (short)142875824;
				switch (num2 == num)
				{
				}
				num = (short)1450639360;
				short num3 = num;
				num = (short)102039553;
				if (num != 0)
				{
				}
				num = (short)2076311552;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.Editable = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0022A4C4 File Offset: 0x002286C4
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0022A578 File Offset: 0x00228778
		public bool UclT2Trk_SystemAlias_A00017_Visible
		{
			get
			{
				short num = (short)995329139;
				short num2 = num;
				num = (short)390169715;
				switch (num2 == num)
				{
				}
				num = (short)2091122688;
				short num3 = num;
				num = (short)123011073;
				if (num != 0)
				{
				}
				num = (short)1887633408;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.Visible;
			}
			set
			{
				short num = (short)87844684;
				short num2 = num;
				num = (short)183920460;
				switch (num2 == num)
				{
				}
				num = (short)1736900608;
				short num3 = num;
				num = (short)829489153;
				if (num != 0)
				{
				}
				num = (short)1880883200;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.Visible = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0022A62C File Offset: 0x0022882C
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0022A6E0 File Offset: 0x002288E0
		public bool UclT2Trk_SystemAlias_A00017_Valid
		{
			get
			{
				short num = (short)17972541;
				short num2 = num;
				num = (short)693517629;
				switch (num2 == num)
				{
				}
				num = (short)1144193024;
				short num3 = num;
				num = (short)989921280;
				if (num != 0)
				{
				}
				num = (short)2006581249;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017.Valid;
			}
			set
			{
				short num = (short)1516961793;
				if (num != 0)
				{
				}
				num = (short)1422572937;
				short num2 = num;
				num = (short)2010955145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101922304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886439936;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemAlias_A00017.Valid = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0022A798 File Offset: 0x00228998
		public bool UclT2Trk_SystemAlias_A00017_HasDiffs
		{
			get
			{
				short num = (short)1862723288;
				short num2 = num;
				num = (short)937027288;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				short num3 = num;
				num = (short)1308688385;
				if (num != 0)
				{
				}
				num = (short)827523072;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemAlias_A00017._HasDiffs;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0022A84C File Offset: 0x00228A4C
		public int UclT2Trk_SystemID_A00018Value
		{
			get
			{
				short num = (short)2095711164;
				short num2 = num;
				num = (short)853279676;
				switch (num2 == num)
				{
				}
				num = (short)1903034368;
				short num3 = num;
				num = (short)775618560;
				if (num != 0)
				{
				}
				num = (short)350420993;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.Value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0022A900 File Offset: 0x00228B00
		public global::AcpBusinessLayer.AcpPointerField<int> UclT2Trk_SystemID_A00018Object
		{
			get
			{
				short num = (short)1759111168;
				short num2 = num;
				num = (short)1595205632;
				switch (num2 == num)
				{
				}
				num = (short)633667584;
				short num3 = num;
				num = (short)732692481;
				if (num != 0)
				{
				}
				num = (short)2012545024;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0022A9B4 File Offset: 0x00228BB4
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x0022AA6C File Offset: 0x00228C6C
		public string UclT2Trk_SystemID_A00018_UIValue
		{
			get
			{
				short num = (short)835452929;
				if (num != 0)
				{
				}
				num = (short)119909177;
				short num2 = num;
				num = (short)1282321209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46006272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1063518208;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.UIValue;
			}
			set
			{
				short num = (short)247681994;
				short num2 = num;
				num = (short)1647727562;
				switch (num2 == num)
				{
				}
				num = (short)2125791232;
				short num3 = num;
				num = (short)1983774721;
				if (num != 0)
				{
				}
				num = (short)810483712;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemID_A00018.UIValue = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0022AB20 File Offset: 0x00228D20
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x0022ABD4 File Offset: 0x00228DD4
		public bool UclT2Trk_SystemID_A00018_Applicable
		{
			get
			{
				short num = (short)1831816070;
				short num2 = num;
				num = (short)2045070214;
				switch (num2 == num)
				{
				}
				num = (short)1204486144;
				short num3 = num;
				num = (short)1334771712;
				if (num != 0)
				{
				}
				num = (short)831455233;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.Applicable;
			}
			set
			{
				short num = (short)1218615426;
				short num2 = num;
				num = (short)1423480962;
				switch (num2 == num)
				{
				}
				num = (short)1694171136;
				short num3 = num;
				num = (short)414646273;
				if (num != 0)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemID_A00018.Applicable = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0022AC8C File Offset: 0x00228E8C
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0022AD44 File Offset: 0x00228F44
		public bool UclT2Trk_SystemID_A00018_Editable
		{
			get
			{
				short num = (short)690957425;
				short num2 = num;
				num = (short)424291441;
				switch (num2 == num)
				{
				}
				num = (short)1552220160;
				short num3 = num;
				num = (short)1423638529;
				if (num != 0)
				{
				}
				num = (short)802291712;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.Editable;
			}
			set
			{
				short num = (short)312343926;
				short num2 = num;
				num = (short)860224886;
				switch (num2 == num)
				{
				}
				num = (short)672202752;
				short num3 = num;
				num = (short)2047541248;
				if (num != 0)
				{
				}
				num = (short)929431553;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemID_A00018.Editable = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0022ADF8 File Offset: 0x00228FF8
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0022AEB0 File Offset: 0x002290B0
		public bool UclT2Trk_SystemID_A00018_Visible
		{
			get
			{
				short num = (short)1953875662;
				short num2 = num;
				num = (short)686737102;
				switch (num2 == num)
				{
				}
				num = (short)632619008;
				short num3 = num;
				num = (short)1713635329;
				if (num != 0)
				{
				}
				num = (short)1606418432;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.Visible;
			}
			set
			{
				short num = (short)1958302182;
				short num2 = num;
				num = (short)1719357926;
				switch (num2 == num)
				{
				}
				num = (short)1902968832;
				short num3 = num;
				num = (short)1267597312;
				if (num != 0)
				{
				}
				num = (short)406716417;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemID_A00018.Visible = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0022AF64 File Offset: 0x00229164
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0022B01C File Offset: 0x0022921C
		public bool UclT2Trk_SystemID_A00018_Valid
		{
			get
			{
				short num = (short)1906150830;
				short num2 = num;
				num = (short)1224576430;
				switch (num2 == num)
				{
				}
				num = (short)1706754048;
				short num3 = num;
				num = (short)501284865;
				if (num != 0)
				{
				}
				num = (short)365953024;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018.Valid;
			}
			set
			{
				short num = (short)1644745469;
				short num2 = num;
				num = (short)669700861;
				switch (num2 == num)
				{
				}
				num = (short)627310592;
				short num3 = num;
				num = (short)269090817;
				if (num != 0)
				{
				}
				num = (short)128188416;
				if (num != 0)
				{
				}
				this.uclT2Trk_SystemID_A00018.Valid = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0022B0D0 File Offset: 0x002292D0
		public bool UclT2Trk_SystemID_A00018_HasDiffs
		{
			get
			{
				short num = (short)779363059;
				short num2 = num;
				num = (short)905716467;
				switch (num2 == num)
				{
				}
				num = (short)2115371008;
				short num3 = num;
				num = (short)266797056;
				if (num != 0)
				{
				}
				num = (short)1301741569;
				if (num != 0)
				{
				}
				return this.uclT2Trk_SystemID_A00018._HasDiffs;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0022B188 File Offset: 0x00229388
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0022B23C File Offset: 0x0022943C
		public int UclT2Trk_IndividualID_A00019Value
		{
			get
			{
				short num = (short)1062308703;
				short num2 = num;
				num = (short)1787136863;
				switch (num2 == num)
				{
				}
				num = (short)1009844224;
				short num3 = num;
				num = (short)99287041;
				if (num != 0)
				{
				}
				num = (short)1514930176;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.Value;
			}
			set
			{
				short num = (short)470061333;
				short num2 = num;
				num = (short)1516867861;
				switch (num2 == num)
				{
				}
				num = (short)1715929088;
				short num3 = num;
				num = (short)1189675009;
				if (num != 0)
				{
				}
				num = (short)1836449792;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.Value = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0022B2F0 File Offset: 0x002294F0
		public global::AcpBusinessLayer.AcpCustomRangeField UclT2Trk_IndividualID_A00019Object
		{
			get
			{
				short num = (short)576180214;
				short num2 = num;
				num = (short)1334824950;
				switch (num2 == num)
				{
				}
				num = (short)528154624;
				short num3 = num;
				num = (short)1512374273;
				if (num != 0)
				{
				}
				num = (short)1907949568;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0022B3A0 File Offset: 0x002295A0
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0022B454 File Offset: 0x00229654
		public string UclT2Trk_IndividualID_A00019_UIValue
		{
			get
			{
				short num = (short)1920404204;
				short num2 = num;
				num = (short)953748204;
				switch (num2 == num)
				{
				}
				num = (short)1106837504;
				short num3 = num;
				num = (short)785186816;
				if (num != 0)
				{
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.UIValue;
			}
			set
			{
				short num = (short)2026603889;
				short num2 = num;
				num = (short)803898737;
				switch (num2 == num)
				{
				}
				num = (short)49152000;
				short num3 = num;
				num = (short)1931739137;
				if (num != 0)
				{
				}
				num = (short)1061224448;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.UIValue = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0022B508 File Offset: 0x00229708
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0022B5BC File Offset: 0x002297BC
		public bool UclT2Trk_IndividualID_A00019_Applicable
		{
			get
			{
				short num = (short)1789810908;
				short num2 = num;
				num = (short)1565677788;
				switch (num2 == num)
				{
				}
				num = (short)1411907584;
				short num3 = num;
				num = (short)751763456;
				if (num != 0)
				{
				}
				num = (short)291438593;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.Applicable;
			}
			set
			{
				short num = (short)1227644088;
				short num2 = num;
				num = (short)1616665784;
				switch (num2 == num)
				{
				}
				num = (short)372506624;
				short num3 = num;
				num = (short)215220225;
				if (num != 0)
				{
				}
				num = (short)1667694592;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.Applicable = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0022B670 File Offset: 0x00229870
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x0022B728 File Offset: 0x00229928
		public bool UclT2Trk_IndividualID_A00019_Editable
		{
			get
			{
				short num = (short)401244326;
				short num2 = num;
				num = (short)1262518438;
				switch (num2 == num)
				{
				}
				num = (short)828375040;
				short num3 = num;
				num = (short)1259077633;
				if (num != 0)
				{
				}
				num = (short)990445568;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.Editable;
			}
			set
			{
				short num = (short)622460929;
				if (num != 0)
				{
				}
				num = (short)2118776964;
				short num2 = num;
				num = (short)1313732740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1347551232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1524301824;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.Editable = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0022B7DC File Offset: 0x002299DC
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x0022B890 File Offset: 0x00229A90
		public bool UclT2Trk_IndividualID_A00019_Visible
		{
			get
			{
				short num = (short)1013841921;
				if (num != 0)
				{
				}
				num = (short)1173101837;
				short num2 = num;
				num = (short)1321016589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624506368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1081868288;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.Visible;
			}
			set
			{
				short num = (short)492133874;
				short num2 = num;
				num = (short)2017549810;
				switch (num2 == num)
				{
				}
				num = (short)438173696;
				short num3 = num;
				num = (short)643563521;
				if (num != 0)
				{
				}
				num = (short)909639680;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.Visible = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0022B948 File Offset: 0x00229B48
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0022B9FC File Offset: 0x00229BFC
		public bool UclT2Trk_IndividualID_A00019_Valid
		{
			get
			{
				short num = (short)1657012225;
				if (num != 0)
				{
				}
				num = (short)1008972735;
				short num2 = num;
				num = (short)1996075967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379991552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39190528;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.Valid;
			}
			set
			{
				short num = (short)391794026;
				short num2 = num;
				num = (short)752700778;
				switch (num2 == num)
				{
				}
				num = (short)2095906816;
				short num3 = num;
				num = (short)409534465;
				if (num != 0)
				{
				}
				num = (short)1018626048;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.Valid = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0022BAB0 File Offset: 0x00229CB0
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0022BB68 File Offset: 0x00229D68
		internal bool UclT2Trk_IndividualID_A00019_HiddenStatic
		{
			get
			{
				short num = (short)674693120;
				short num2 = num;
				num = (short)707378413;
				short num3 = num;
				num = (short)816037101;
				switch (num3 == num)
				{
				}
				num = (short)1475870721;
				if (num != 0)
				{
				}
				num = (short)1732706304;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019.HiddenStatic;
			}
			set
			{
				short num = (short)448593920;
				short num2 = num;
				num = (short)1462675641;
				short num3 = num;
				num = (short)1465952441;
				switch (num3 == num)
				{
				}
				num = (short)971898880;
				if (num != 0)
				{
				}
				num = (short)2024407041;
				if (num != 0)
				{
				}
				this.uclT2Trk_IndividualID_A00019.HiddenStatic = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0022BC20 File Offset: 0x00229E20
		public bool UclT2Trk_IndividualID_A00019_HasDiffs
		{
			get
			{
				short num = (short)1113063424;
				short num2 = num;
				num = (short)816391222;
				short num3 = num;
				num = (short)808199222;
				switch (num3 == num)
				{
				}
				num = (short)1720123393;
				if (num != 0)
				{
				}
				num = (short)1031864320;
				if (num != 0)
				{
				}
				return this.uclT2Trk_IndividualID_A00019._HasDiffs;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0022BCD4 File Offset: 0x00229ED4
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0022BD88 File Offset: 0x00229F88
		public string UclT2Trk_CombinedID_A00020Value
		{
			get
			{
				short num = (short)127270912;
				short num2 = num;
				num = (short)1045904790;
				short num3 = num;
				num = (short)666844566;
				switch (num3 == num)
				{
				}
				num = (short)2075983873;
				if (num != 0)
				{
				}
				num = (short)919928832;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.Value;
			}
			set
			{
				short num = (short)2128019456;
				short num2 = num;
				num = (short)608288178;
				short num3 = num;
				num = (short)1441643954;
				switch (num3 == num)
				{
				}
				num = (short)1135869953;
				if (num != 0)
				{
				}
				num = (short)638255104;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.Value = value;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0022BE40 File Offset: 0x0022A040
		public global::AcpBusinessLayer.AcpKeyField UclT2Trk_CombinedID_A00020Object
		{
			get
			{
				short num = (short)1557528576;
				short num2 = num;
				num = (short)1774621512;
				short num3 = num;
				num = (short)1866961736;
				switch (num3 == num)
				{
				}
				num = (short)277086208;
				if (num != 0)
				{
				}
				num = (short)1746862081;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0022BEEC File Offset: 0x0022A0EC
		internal string UclT2Trk_CombinedID_A00020_UILabel
		{
			get
			{
				short num = (short)250347520;
				short num2 = num;
				num = (short)1245403307;
				short num3 = num;
				num = (short)873158827;
				switch (num3 == num)
				{
				}
				num = (short)2122383361;
				if (num != 0)
				{
				}
				num = (short)465436672;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.UIName;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0022BFA0 File Offset: 0x0022A1A0
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0022C054 File Offset: 0x0022A254
		public bool UclT2Trk_CombinedID_A00020_Applicable
		{
			get
			{
				short num = (short)705232896;
				short num2 = num;
				num = (short)1992556713;
				short num3 = num;
				num = (short)1986527401;
				switch (num3 == num)
				{
				}
				num = (short)1125515265;
				if (num != 0)
				{
				}
				num = (short)1859846144;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.Applicable;
			}
			set
			{
				short num = (short)522649600;
				short num2 = num;
				num = (short)1992819188;
				short num3 = num;
				num = (short)942998004;
				switch (num3 == num)
				{
				}
				num = (short)2065694721;
				if (num != 0)
				{
				}
				num = (short)1994915840;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.Applicable = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0022C108 File Offset: 0x0022A308
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0022C1BC File Offset: 0x0022A3BC
		public bool UclT2Trk_CombinedID_A00020_Editable
		{
			get
			{
				short num = (short)1499004928;
				short num2 = num;
				num = (short)302732129;
				short num3 = num;
				num = (short)1550603105;
				switch (num3 == num)
				{
				}
				num = (short)143196161;
				if (num != 0)
				{
				}
				num = (short)2064711680;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.Editable;
			}
			set
			{
				short num = (short)1746468864;
				short num2 = num;
				num = (short)2060189697;
				if (num != 0)
				{
				}
				num = (short)638568043;
				short num3 = num;
				num = (short)1703528043;
				switch (num3 == num)
				{
				}
				num = (short)357892096;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.Editable = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0022C274 File Offset: 0x0022A474
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0022C328 File Offset: 0x0022A528
		public bool UclT2Trk_CombinedID_A00020_Visible
		{
			get
			{
				short num = (short)191365120;
				short num2 = num;
				num = (short)1777874954;
				short num3 = num;
				num = (short)1952331786;
				switch (num3 == num)
				{
				}
				num = (short)1800994816;
				if (num != 0)
				{
				}
				num = (short)1130364929;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.Visible;
			}
			set
			{
				short num = (short)691601408;
				short num2 = num;
				num = (short)317784065;
				if (num != 0)
				{
				}
				num = (short)1435347348;
				short num3 = num;
				num = (short)991996308;
				switch (num3 == num)
				{
				}
				num = (short)1504444416;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.Visible = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0022C3E0 File Offset: 0x0022A5E0
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0022C494 File Offset: 0x0022A694
		internal bool UclT2Trk_CombinedID_A00020_HiddenStatic
		{
			get
			{
				short num = (short)981336064;
				short num2 = num;
				num = (short)2132803585;
				if (num != 0)
				{
				}
				num = (short)1990663679;
				short num3 = num;
				num = (short)133635583;
				switch (num3 == num)
				{
				}
				num = (short)1549402112;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.HiddenStatic;
			}
			set
			{
				short num = (short)948502528;
				short num2 = num;
				num = (short)1198501273;
				short num3 = num;
				num = (short)2051321241;
				switch (num3 == num)
				{
				}
				num = (short)454361088;
				if (num != 0)
				{
				}
				num = (short)2104360961;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.HiddenStatic = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0022C54C File Offset: 0x0022A74C
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0022C600 File Offset: 0x0022A800
		public bool UclT2Trk_CombinedID_A00020_Valid
		{
			get
			{
				short num = (short)2014183424;
				short num2 = num;
				num = (short)51633110;
				short num3 = num;
				num = (short)1040374742;
				switch (num3 == num)
				{
				}
				num = (short)1415708673;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020.Valid;
			}
			set
			{
				short num = (short)1942552576;
				short num2 = num;
				num = (short)449490437;
				short num3 = num;
				num = (short)1710075397;
				switch (num3 == num)
				{
				}
				num = (short)1611530241;
				if (num != 0)
				{
				}
				num = (short)1530724352;
				if (num != 0)
				{
				}
				this.uclT2Trk_CombinedID_A00020.Valid = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0022C6B4 File Offset: 0x0022A8B4
		public bool UclT2Trk_CombinedID_A00020_HasDiffs
		{
			get
			{
				short num = (short)1588396032;
				short num2 = num;
				num = (short)376491720;
				short num3 = num;
				num = (short)1443679944;
				switch (num3 == num)
				{
				}
				num = (short)1283522561;
				if (num != 0)
				{
				}
				num = (short)2049179648;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CombinedID_A00020._HasDiffs;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0022C768 File Offset: 0x0022A968
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0022C81C File Offset: 0x0022AA1C
		public int UclT2Trk_CustomizedSystemID_A00021Value
		{
			get
			{
				short num = (short)1578827776;
				short num2 = num;
				num = (short)2086010881;
				if (num != 0)
				{
				}
				num = (short)407619296;
				short num3 = num;
				num = (short)884655840;
				switch (num3 == num)
				{
				}
				num = (short)1273823232;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Value;
			}
			set
			{
				short num = (short)1437859840;
				short num2 = num;
				num = (short)1050683304;
				short num3 = num;
				num = (short)345122728;
				switch (num3 == num)
				{
				}
				num = (short)1700790273;
				if (num != 0)
				{
				}
				num = (short)1147797504;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Value = value;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0022C8D4 File Offset: 0x0022AAD4
		public global::AcpBusinessLayer.AcpRangeField<int, int> UclT2Trk_CustomizedSystemID_A00021Object
		{
			get
			{
				short num = (short)667418624;
				short num2 = num;
				num = (short)1572811070;
				short num3 = num;
				num = (short)1556164926;
				switch (num3 == num)
				{
				}
				num = (short)1516175361;
				if (num != 0)
				{
				}
				num = (short)64684032;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0022C988 File Offset: 0x0022AB88
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0022CA40 File Offset: 0x0022AC40
		public int UclT2Trk_CustomizedSystemID_A00021_UIValue
		{
			get
			{
				short num = (short)933101568;
				short num2 = num;
				num = (short)666135454;
				short num3 = num;
				num = (short)10840990;
				switch (num3 == num)
				{
				}
				num = (short)1958150145;
				if (num != 0)
				{
				}
				num = (short)1133248512;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.UIValue;
			}
			set
			{
				short num = (short)2006581248;
				short num2 = num;
				num = (short)1487693488;
				short num3 = num;
				num = (short)1247635120;
				switch (num3 == num)
				{
				}
				num = (short)1122566145;
				if (num != 0)
				{
				}
				num = (short)69206016;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.UIValue = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0022CAF8 File Offset: 0x0022ACF8
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x0022CBAC File Offset: 0x0022ADAC
		internal int UclT2Trk_CustomizedSystemID_A00021Min
		{
			get
			{
				short num = (short)1881997312;
				short num2 = num;
				num = (short)1690520762;
				short num3 = num;
				num = (short)1794657466;
				switch (num3 == num)
				{
				}
				num = (short)478806017;
				if (num != 0)
				{
				}
				num = (short)1420623872;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Min;
			}
			set
			{
				short num = (short)941555712;
				short num2 = num;
				num = (short)1256814983;
				short num3 = num;
				num = (short)22968711;
				switch (num3 == num)
				{
				}
				num = (short)1964900353;
				if (num != 0)
				{
				}
				num = (short)396558336;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Min = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0022CC64 File Offset: 0x0022AE64
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x0022CD1C File Offset: 0x0022AF1C
		internal int UclT2Trk_CustomizedSystemID_A00021Max
		{
			get
			{
				short num = (short)43057152;
				short num2 = num;
				num = (short)676979163;
				short num3 = num;
				num = (short)927326683;
				switch (num3 == num)
				{
				}
				num = (short)811991041;
				if (num != 0)
				{
				}
				num = (short)1850605568;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Max;
			}
			set
			{
				short num = (short)101842944;
				short num2 = num;
				num = (short)544728160;
				short num3 = num;
				num = (short)334685280;
				switch (num3 == num)
				{
				}
				num = (short)1701052416;
				if (num != 0)
				{
				}
				num = (short)26738689;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Max = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0022CDD0 File Offset: 0x0022AFD0
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0022CE84 File Offset: 0x0022B084
		internal int UclT2Trk_CustomizedSystemID_A00021Step
		{
			get
			{
				short num = (short)1775173632;
				short num2 = num;
				num = (short)1224892624;
				short num3 = num;
				num = (short)466641104;
				switch (num3 == num)
				{
				}
				num = (short)1765801984;
				if (num != 0)
				{
				}
				num = (short)2131558401;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.StepSize;
			}
			set
			{
				short num = (short)187432960;
				short num2 = num;
				num = (short)1822778930;
				short num3 = num;
				num = (short)63923762;
				switch (num3 == num)
				{
				}
				num = (short)386990080;
				if (num != 0)
				{
				}
				num = (short)1401815041;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.StepSize = value;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0022CF3C File Offset: 0x0022B13C
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x0022CFF0 File Offset: 0x0022B1F0
		public bool UclT2Trk_CustomizedSystemID_A00021_Applicable
		{
			get
			{
				short num = (short)838402048;
				short num2 = num;
				num = (short)602934072;
				short num3 = num;
				num = (short)1674316600;
				switch (num3 == num)
				{
				}
				num = (short)104923136;
				if (num != 0)
				{
				}
				num = (short)1036976129;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Applicable;
			}
			set
			{
				short num = (short)469827584;
				short num2 = num;
				num = (short)1134086898;
				short num3 = num;
				num = (short)1379977970;
				switch (num3 == num)
				{
				}
				num = (short)911867905;
				if (num != 0)
				{
				}
				num = (short)151388160;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Applicable = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0022D0A4 File Offset: 0x0022B2A4
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0022D154 File Offset: 0x0022B354
		public bool UclT2Trk_CustomizedSystemID_A00021_Valid
		{
			get
			{
				short num = (short)912916480;
				short num2 = num;
				num = (short)560024903;
				short num3 = num;
				num = (short)1142836551;
				switch (num3 == num)
				{
				}
				num = (short)1163722753;
				if (num != 0)
				{
				}
				num = (short)1635516416;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Valid;
			}
			set
			{
				short num = (short)1823408128;
				short num2 = num;
				num = (short)1213464577;
				if (num != 0)
				{
				}
				num = (short)979607563;
				short num3 = num;
				num = (short)959094795;
				switch (num3 == num)
				{
				}
				num = (short)1790902272;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Valid = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0022D20C File Offset: 0x0022B40C
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x0022D2C4 File Offset: 0x0022B4C4
		public bool UclT2Trk_CustomizedSystemID_A00021_Visible
		{
			get
			{
				short num = (short)1507131392;
				short num2 = num;
				num = (short)1758527489;
				if (num != 0)
				{
				}
				num = (short)1753218588;
				short num3 = num;
				num = (short)97517084;
				switch (num3 == num)
				{
				}
				num = (short)94175232;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Visible;
			}
			set
			{
				short num = (short)946339840;
				short num2 = num;
				num = (short)1287707540;
				short num3 = num;
				num = (short)655743892;
				switch (num3 == num)
				{
				}
				num = (short)560398336;
				if (num != 0)
				{
				}
				num = (short)1474625537;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Visible = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0022D37C File Offset: 0x0022B57C
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0022D430 File Offset: 0x0022B630
		public bool UclT2Trk_CustomizedSystemID_A00021_Editable
		{
			get
			{
				short num = (short)1519452160;
				short num2 = num;
				num = (short)848462776;
				short num3 = num;
				num = (short)1316651960;
				switch (num3 == num)
				{
				}
				num = (short)1493893120;
				if (num != 0)
				{
				}
				num = (short)1195507713;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.Editable;
			}
			set
			{
				short num = (short)1777074176;
				short num2 = num;
				num = (short)1419958591;
				short num3 = num;
				num = (short)1380636991;
				switch (num3 == num)
				{
				}
				num = (short)1496645633;
				if (num != 0)
				{
				}
				num = (short)828506112;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.Editable = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0022D4E8 File Offset: 0x0022B6E8
		internal string UclT2Trk_CustomizedSystemID_A00021_UILabel
		{
			get
			{
				short num = (short)1883832320;
				short num2 = num;
				num = (short)2077854007;
				short num3 = num;
				num = (short)1352304951;
				switch (num3 == num)
				{
				}
				num = (short)27197440;
				if (num != 0)
				{
				}
				num = (short)1480392705;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.UIName;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0022D5A0 File Offset: 0x0022B7A0
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0022D654 File Offset: 0x0022B854
		internal bool UclT2Trk_CustomizedSystemID_A00021_HiddenStatic
		{
			get
			{
				short num = (short)1116602368;
				short num2 = num;
				num = (short)2060096564;
				short num3 = num;
				num = (short)575116340;
				switch (num3 == num)
				{
				}
				num = (short)2121859073;
				if (num != 0)
				{
				}
				num = (short)1801977856;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.HiddenStatic;
			}
			set
			{
				short num = (short)2062090240;
				short num2 = num;
				num = (short)639171174;
				short num3 = num;
				num = (short)384891494;
				switch (num3 == num)
				{
				}
				num = (short)1095434241;
				if (num != 0)
				{
				}
				num = (short)620167168;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.HiddenStatic = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0022D708 File Offset: 0x0022B908
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0022D7BC File Offset: 0x0022B9BC
		internal bool UclT2Trk_CustomizedSystemID_A00021_HiddenDynamic
		{
			get
			{
				short num = (short)252248064;
				short num2 = num;
				num = (short)846953042;
				short num3 = num;
				num = (short)1919908434;
				switch (num3 == num)
				{
				}
				num = (short)666238976;
				if (num != 0)
				{
				}
				num = (short)961413121;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021.HiddenDynamic;
			}
			set
			{
				short num = (short)1068695552;
				short num2 = num;
				num = (short)181019210;
				short num3 = num;
				num = (short)933175882;
				switch (num3 == num)
				{
				}
				num = (short)1267073024;
				if (num != 0)
				{
				}
				num = (short)284229633;
				if (num != 0)
				{
				}
				this.uclT2Trk_CustomizedSystemID_A00021.HiddenDynamic = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0022D874 File Offset: 0x0022BA74
		public bool UclT2Trk_CustomizedSystemID_A00021_HasDiffs
		{
			get
			{
				short num = (short)1414201344;
				short num2 = num;
				num = (short)1597308929;
				if (num != 0)
				{
				}
				num = (short)1795787114;
				short num3 = num;
				num = (short)121538922;
				switch (num3 == num)
				{
				}
				num = (short)856293376;
				if (num != 0)
				{
				}
				return this.uclT2Trk_CustomizedSystemID_A00021._HasDiffs;
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0000265F File Offset: 0x0000085F
		internal TrunkingT2CallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0022D928 File Offset: 0x0022BB28
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1686110208;
			short num2 = num;
			num = (short)1977171380;
			short num3 = num;
			num = (short)1339964852;
			switch (num3 == num)
			{
			}
			num = (short)2008547329;
			if (num != 0)
			{
			}
			num = (short)1572274176;
			if (num != 0)
			{
			}
			this.uclT2Trk_SystemAlias_A00017 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉쎖ꮘ쾚ﺠ\udca4풦\udda8캪사\uddb0\udab2풴쒶諸趼达", a_), global::CommonResources.AppResources.System_Name, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID,
				global::CommonResources.AppResources.Customized_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.uclT2Trk_SystemAlias_A00017.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2Trk_SystemAlias_A00017.DataTransferOrder = 1;
			this.uclT2Trk_SystemAlias_A00017.KeyNameField = true;
			this.uclT2Trk_SystemID_A00018 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉쎖ꮘ쾚ﺠ\udca4풦\udda8캪사螶覸论貼螾", a_), global::CommonResources.AppResources.System_ID, global::CommonResources.AppResources.Unassigned_ID);
			this.uclT2Trk_SystemID_A00018.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2Trk_SystemID_A00018.KeyNameField = true;
			this.uclT2Trk_IndividualID_A00019 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉쎖ꮘ쾚ﺠ쮤쎦삨\uddaa쒬쮮쒰튲\ud9b4ﺶﶸﲼ达ﻆ", a_), global::CommonResources.AppResources.Unit_ID, 0, 65534, 1, global::CommonResources.AppResources.Unassigned_ID, null);
			this.uclT2Trk_IndividualID_A00019.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2Trk_IndividualID_A00019.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
			this.uclT2Trk_IndividualID_A00019.DataTransferOrder = 4;
			this.uclT2Trk_IndividualID_A00019.KeyNameField = true;
			this.uclT2Trk_CombinedID_A00020 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉쎖ꮘ쾚ﺠ쪤쪦쮨슪쎬쪮햰者论趼达", a_), global::CommonResources.AppResources.Call_ID);
			this.uclT2Trk_CombinedID_A00020.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2Trk_CustomizedSystemID_A00021 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉쎖ꮘ쾚ﺠ키풦\udda8쒪사욮쮰횲톴삸좺즼\udabe곀諂臄飆裈﯊﷌ￎ", a_), global::CommonResources.AppResources.Custom_System_ID, 1, 65535, 1);
			this.uclT2Trk_CustomizedSystemID_A00021.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2Trk_CustomizedSystemID_A00021.DataTransferOrder = 2;
			this.uclT2Trk_CustomizedSystemID_A00021.KeyNameField = true;
			this.uclT2Trk_CustomizedSystemID_A00021.EvaluateRecRefs = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐릘튚풜뾞톢키즦슨슪쎬좮醰者쒶", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_IDs;
			base.DataTransferOrder = 5;
			base.Id = 10412;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0022DB98 File Offset: 0x0022BD98
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1509883904;
			short num2 = num;
			num = (short)1535707531;
			short num3 = num;
			num = (short)638454155;
			switch (num3 == num)
			{
			}
			num = (short)474546177;
			if (num != 0)
			{
			}
			num = (short)998899712;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0022DC48 File Offset: 0x0022BE48
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1546256387;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗즙풟잡즣쒧쎩춫\uddad蒳蚵袷讹讻", a_)))
					{
						num = (short)605814791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45F;
				case 1:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗펙瞧즟풡춣슥\udda7쮩삫蚵袷誹趻螽", a_)))
					{
						goto IL_118;
					}
					goto IL_9C;
				case 2:
					num = (short)1844707328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 4:
					this.uclT2Trk_IndividualID_A00019 = new global::AcpBusinessLayer.AcpCustomRangeField(new global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection.UnassignedConverter(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗펙瞧즟풡춣슥\udda7쮩삫蚵袷誹趻螽", a_), global::CommonResources.AppResources.Unit_ID, global::CommonResources.AppResources.Unassigned_ID, null);
					this.uclT2Trk_IndividualID_A00019.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2Trk_IndividualID_A00019.AddCustomValue(0, global::CommonResources.AppResources.Unassigned_ID);
					this.uclT2Trk_IndividualID_A00019.DataTransferOrder = 4;
					this.uclT2Trk_IndividualID_A00019.KeyNameField = true;
					num = (short)2128543759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.uclT2Trk_CombinedID_A00020 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗\ud999슟쮡쪣쎥첧花蒳蚵誷誹", a_), global::CommonResources.AppResources.Call_ID);
					this.uclT2Trk_CombinedID_A00020.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					num = (short)478412818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)2109997058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FA;
				case 7:
					this.uclT2Trk_SystemAlias_A00017 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗즙풟잡즣쒧쎩춫\uddad蒳蚵袷讹讻", a_), global::CommonResources.AppResources.System_Name, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID,
						global::CommonResources.AppResources.Customized_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.uclT2Trk_SystemAlias_A00017.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2Trk_SystemAlias_A00017.DataTransferOrder = 1;
					this.uclT2Trk_SystemAlias_A00017.KeyNameField = true;
					num = (short)1881538577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗\ud999풟춡즣쾥튧쾩좫ﶭ즯솱삳펵햷膿難﯉", a_)))
					{
						num = (short)2031550480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FA;
				case 9:
					this.uclT2Trk_SystemID_A00018 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗즙풟잡즣麭肯花薳躵", a_), global::CommonResources.AppResources.System_ID, global::CommonResources.AppResources.Unassigned_ID);
					this.uclT2Trk_SystemID_A00018.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2Trk_SystemID_A00018.KeyNameField = true;
					num = (short)344326154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_E9;
				case 11:
					goto IL_2B5;
				case 12:
					num = (short)1150877702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)891027456;
					short num3 = num;
					num = (short)11927553;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗즙풟잡즣麭肯花薳躵", a_)))
					{
						num = (short)1477050377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				}
				case 14:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗\ud999슟쮡쪣쎥첧花蒳蚵誷誹", a_)))
					{
						num = (short)118489093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 15:
					goto IL_9C;
				case 16:
					this.uclT2Trk_CustomizedSystemID_A00021 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd87\uda8dꊏ욑ﶕ잗\ud999풟춡즣쾥튧쾩좫ﶭ즯솱삳펵햷膿難﯉", a_), global::CommonResources.AppResources.Custom_System_ID);
					this.uclT2Trk_CustomizedSystemID_A00021.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2Trk_CustomizedSystemID_A00021.DataTransferOrder = 2;
					this.uclT2Trk_CustomizedSystemID_A00021.KeyNameField = true;
					this.uclT2Trk_CustomizedSystemID_A00021.EvaluateRecRefs = true;
					num = (short)1246429195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					num = (short)725734114;
					short num4 = num;
					num = (short)1649529570;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)603914240;
						if (num != 0)
						{
						}
						goto IL_45F;
					}
					break;
				}
				case 18:
					goto IL_181;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)622460940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)1451360270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E9:
				num = (short)424214529;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				num = (short)693043204;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_181:
				num = (short)1285619720;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45F:
				num = (short)260833293;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2B5:
			IL_4FA:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87ﲋ낏\udb91\udd93뚕첗쮟쮡쪣솥袧\uddad", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_IDs;
			base.DataTransferOrder = 5;
			base.Id = 10412;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0022E180 File Offset: 0x0022C380
		public override void PopulateReferences()
		{
			short num = (short)1314455565;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.FeatureNode referencedNode;
				switch (num2)
				{
				case 0:
					if (this.UclT2Trk_SystemAlias_A00017Value == 65535)
					{
						num = (short)1409941505;
						if (num != 0)
						{
						}
						num = (short)1056702473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)678756353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.UclT2Trk_SystemAlias_A00017Value == 0)
					{
						num = (short)2072313860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FA;
				case 2:
					goto IL_17C;
				case 3:
					if (referencedNode != null)
					{
						num = (short)1408434186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				case 4:
					goto IL_158;
				case 5:
					num = (short)1699872780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_AF;
				case 7:
					goto IL_AA;
				case 8:
					goto IL_2B7;
				case 9:
					this.UclT2Trk_SystemID_A00018Object.PointedField = this.UclT2Trk_CustomizedSystemID_A00021Object;
					num = (short)1285685255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					this.UclT2Trk_SystemID_A00018Object.PointedField = trunkingSystem.General.TrkSysGeneralSystemID_A9239;
					num = (short)152043526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					this.uclT2Trk_SystemAlias_A00017.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2064));
					num = (short)1797390344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)17947612;
						short num3 = num;
						num = (short)1834867676;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_158;
						case 1:
							break;
						default:
						{
							num = (short)215154688;
							short num4 = num;
							break;
						}
						}
						num = (short)1527447552;
						if (num != 0)
						{
						}
						num = (short)1653145611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (base.ParentRecset != null)
				{
					num = (short)826277893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2B7;
				IL_AF:
				num = (short)1869021184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_158:
				this.UclT2Trk_SystemID_A00018Object.PointedField = null;
				num = (short)337903618;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B7:
				referencedNode = this.UclT2Trk_SystemAlias_A00017Object.ReferencedNode;
				num = (short)1812463619;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			IL_17C:
			IL_2FA:
			((global::AcpBusinessLayer.Recordset)base.ParentRecset).RefreshKeyForNode((global::AcpBusinessLayer.FeatureNode)base.Parent);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0022E4A4 File Offset: 0x0022C6A4
		public override void DropReferences()
		{
			short num = (short)584071900;
			short num2 = num;
			num = (short)1394424540;
			switch (num2 == num)
			{
			default:
			{
				num = (short)412614656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2065498112;
			if (num != 0)
			{
			}
			num = (short)28049409;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0022E54C File Offset: 0x0022C74C
		public override void SetConstraints()
		{
			short num = (short)1252765471;
			short num2 = num;
			num = (short)1737404191;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1341194240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1687814145;
			if (num != 0)
			{
			}
			num = (short)737738752;
			if (num != 0)
			{
			}
			this.uclT2Trk_SystemAlias_A00017.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsTrkType2SystemAliasValid);
			this.uclT2Trk_SystemID_A00018.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conSetType2SystemID);
			this.uclT2Trk_IndividualID_A00019.ValidateAcrossRecset = true;
			this.uclT2Trk_IndividualID_A00019.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsT2IndividualIdValid);
			this.uclT2Trk_CombinedID_A00020.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclT2Trk_SystemID_A00018.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsNotCustomizedT2System);
			this.uclT2Trk_SystemID_A00018.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclT2Trk_CustomizedSystemID_A00021.IsVisible = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsCustomizedT2System);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0022E6A0 File Offset: 0x0022C8A0
		public override void SetupDependencies()
		{
			short num = (short)1256301775;
			short num2 = num;
			num = (short)1133552847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)382533632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1368588289;
			if (num != 0)
			{
			}
			num = (short)1483079680;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotList trunkingT2CallHotList = ((global::AcpCommonLib.FeatureManager.GetFeature(2214)[0] as global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotList).TrunkingT2CallHotList.EmbeddedRecset as global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset)[0] as global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotList;
			this.uclT2Trk_SystemAlias_A00017.AddDependentObject(trunkingT2CallHotList.HotListT2.UclT2TrkHotList_CallID_A00041Object);
			this.uclT2Trk_CustomizedSystemID_A00021.AddDependentObject(trunkingT2CallHotList.HotListT2.UclT2TrkHotList_CallID_A00041Object);
			this.uclT2Trk_IndividualID_A00019.AddDependentObject(trunkingT2CallHotList.HotListT2.UclT2TrkHotList_CallID_A00041Object);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0022E7C0 File Offset: 0x0022C9C0
		public void ResolveReferenceAfterUnpack()
		{
			short num = (short)1387397120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::AcpBusinessLayer.AcpField<int> acpField;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				for (;;)
				{
					IL_28:
					int num4;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralSystemID_A9239Value == acpField.Value)
						{
							num = (short)1808138247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)222972542;
						short num3 = num;
						num = (short)1421691518;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						default:
						{
							num = (short)545521664;
							if (num != 0)
							{
							}
							num = (short)1266679809;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
							if (general.TrkSysGeneralSystemType_A9252Value == 2)
							{
								num = (short)170262532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A6;
						}
						}
						break;
					}
					case 3:
						goto IL_120;
					case 4:
						num = (short)234225664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)860487690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
						if (num4 >= trunkingSystemRecset.Count)
						{
							num = (short)616759297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpFeatureNode = trunkingSystemRecset[num4];
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General)acpFeatureNode[10157];
						num = (short)797900802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_100;
					case 8:
						goto IL_120;
					case 9:
						goto IL_1A1;
					case 10:
					{
						if (acpField == 0)
						{
							num = (short)386924553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)871825408;
						short num5 = num;
						this.uclT2Trk_SystemAlias_A00017.DefaultValue = 65535;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
						num4 = 0;
						num = (short)1052835848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (acpField != null)
						{
							num = (short)469172229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					}
					goto IL_5F;
					IL_120:
					num = (short)1578696710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A6:
					num4++;
					num = (short)804388867;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				this.uclT2Trk_SystemAlias_A00017.DefaultValue = acpFeatureNode.Parent.IndexOf(acpFeatureNode) + 1;
				return;
				IL_102:
				this.uclT2Trk_SystemAlias_A00017.DefaultValue = 0;
				this.UclT2Trk_CustomizedSystemID_A00021Value = this.uclT2Trk_CustomizedSystemID_A00021.DefaultValue;
				return;
				IL_1A1:
				goto IL_102;
				IL_5F:
				acpField = (global::AcpBusinessLayer.AcpField<int>)this.UclT2Trk_SystemID_A00018Object.PointedField;
				num = (short)1514995723;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000CC5 RID: 3269
		private global::AcpBusinessLayer.AcpRecRefField uclT2Trk_SystemAlias_A00017;

		// Token: 0x04000CC6 RID: 3270
		private global::AcpBusinessLayer.AcpPointerField<int> uclT2Trk_SystemID_A00018;

		// Token: 0x04000CC7 RID: 3271
		private global::AcpBusinessLayer.AcpCustomRangeField uclT2Trk_IndividualID_A00019;

		// Token: 0x04000CC8 RID: 3272
		private global::AcpBusinessLayer.AcpKeyField uclT2Trk_CombinedID_A00020;

		// Token: 0x04000CC9 RID: 3273
		private global::AcpBusinessLayer.AcpRangeField<int, int> uclT2Trk_CustomizedSystemID_A00021;

		// Token: 0x02000210 RID: 528
		internal class UnassignedConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001B05 RID: 6917 RVA: 0x0022EAD0 File Offset: 0x0022CCD0
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num;
				object result;
				try
				{
					num = (short)1648774725;
					short num2 = num;
					num = (short)897273413;
					switch (num2 == num)
					{
					}
					num = (short)540999680;
					if (num != 0)
					{
					}
					result = ((int)value).ToString();
				}
				catch
				{
					result = string.Empty;
				}
				num = (short)222953473;
				if (num != 0)
				{
				}
				num = (short)1276313600;
				short num3 = num;
				return result;
			}

			// Token: 0x06001B06 RID: 6918 RVA: 0x0022EBA4 File Offset: 0x0022CDA4
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				short num = (short)703922181;
				int num2 = (int)((global::System.IntPtr)num);
				int num4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1151401984;
						short num3 = num;
						num = (short)2074148865;
						if (num != 0)
						{
						}
						goto IL_145;
					}
					case 1:
						goto IL_143;
					case 2:
						num = (short)1880883204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num4 <= 65534)
						{
							num = (short)2088632322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 4:
						if (num4 >= 0)
						{
							num = (short)513933313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					}
					IL_3D:
					if (!int.TryParse((string)value, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num4))
					{
						goto IL_186;
					}
					num = (short)664573714;
					short num5 = num;
					num = (short)930846482;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2072379392;
						if (num != 0)
						{
						}
						num = (short)680525824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_145:
					num = (short)247726083;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_143:
				return num4;
				IL_17F:
				return 0;
				IL_186:
				return 0;
			}
		}
	}
}
