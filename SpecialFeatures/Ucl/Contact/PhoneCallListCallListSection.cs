using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.HotList;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000204 RID: 516
	[global::System.Serializable]
	public sealed class PhoneCallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x00002650 File Offset: 0x00000850
		internal PhoneCallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x002188B4 File Offset: 0x00216AB4
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x00218968 File Offset: 0x00216B68
		public string UclPhone_PhoneNumber_A00033Value
		{
			get
			{
				short num = (short)1682986874;
				short num2 = num;
				num = (short)447829882;
				switch (num2 == num)
				{
				}
				num = (short)1513947137;
				if (num != 0)
				{
				}
				num = (short)1579417600;
				short num3 = num;
				num = (short)504037376;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.Value;
			}
			set
			{
				short num = (short)1541405744;
				short num2 = num;
				num = (short)1497562160;
				switch (num2 == num)
				{
				}
				num = (short)1349648385;
				if (num != 0)
				{
				}
				num = (short)1731067904;
				short num3 = num;
				num = (short)105840640;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.Value = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00218A24 File Offset: 0x00216C24
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x00218AD8 File Offset: 0x00216CD8
		public string UclPhone_PhoneNumber_A00033_UIValue
		{
			get
			{
				short num = (short)640700218;
				short num2 = num;
				num = (short)701714234;
				switch (num2 == num)
				{
				}
				num = (short)394002433;
				if (num != 0)
				{
				}
				num = (short)637927424;
				short num3 = num;
				num = (short)1190658048;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.UIValue;
			}
			set
			{
				short num = (short)1869699194;
				short num2 = num;
				num = (short)152655994;
				switch (num2 == num)
				{
				}
				num = (short)1297088513;
				if (num != 0)
				{
				}
				num = (short)1113587712;
				short num3 = num;
				num = (short)631439360;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.UIValue = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00218B90 File Offset: 0x00216D90
		public global::AcpBusinessLayer.AcpField<string> UclPhone_PhoneNumber_A00033Object
		{
			get
			{
				short num = (short)1414608729;
				short num2 = num;
				num = (short)789395289;
				switch (num2 == num)
				{
				}
				num = (short)1684406273;
				if (num != 0)
				{
				}
				num = (short)740229120;
				short num3 = num;
				num = (short)286392320;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00218C44 File Offset: 0x00216E44
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00218CFC File Offset: 0x00216EFC
		public bool UclPhone_PhoneNumber_A00033_Applicable
		{
			get
			{
				short num = (short)1966044217;
				short num2 = num;
				num = (short)358839353;
				switch (num2 == num)
				{
				}
				num = (short)390987777;
				if (num != 0)
				{
				}
				num = (short)1727070208;
				short num3 = num;
				num = (short)1058930688;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.Applicable;
			}
			set
			{
				short num = (short)2147256863;
				short num2 = num;
				num = (short)750815775;
				switch (num2 == num)
				{
				}
				num = (short)90701824;
				if (num != 0)
				{
				}
				num = (short)1324613632;
				short num3 = num;
				num = (short)1428946945;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.Applicable = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00218DB0 File Offset: 0x00216FB0
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00218E64 File Offset: 0x00217064
		public bool UclPhone_PhoneNumber_A00033_Editable
		{
			get
			{
				short num = (short)1544074409;
				short num2 = num;
				num = (short)5158057;
				switch (num2 == num)
				{
				}
				num = (short)1722155008;
				if (num != 0)
				{
				}
				num = (short)541786112;
				short num3 = num;
				num = (short)1208221697;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.Editable;
			}
			set
			{
				short num = (short)581574350;
				short num2 = num;
				num = (short)1045372622;
				switch (num2 == num)
				{
				}
				num = (short)143720449;
				if (num != 0)
				{
				}
				num = (short)333053952;
				short num3 = num;
				num = (short)912982016;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.Editable = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00218F18 File Offset: 0x00217118
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00218FD0 File Offset: 0x002171D0
		public bool UclPhone_PhoneNumber_A00033_Visible
		{
			get
			{
				short num = (short)319267719;
				short num2 = num;
				num = (short)584950663;
				switch (num2 == num)
				{
				}
				num = (short)1934884865;
				if (num != 0)
				{
				}
				num = (short)2043412480;
				short num3 = num;
				num = (short)1304297472;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.Visible;
			}
			set
			{
				short num = (short)1697252454;
				short num2 = num;
				num = (short)1196557414;
				switch (num2 == num)
				{
				}
				num = (short)264241153;
				if (num != 0)
				{
				}
				num = (short)2033319936;
				short num3 = num;
				num = (short)1798504448;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.Visible = value;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00219088 File Offset: 0x00217288
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00219138 File Offset: 0x00217338
		public bool UclPhone_PhoneNumber_A00033_Valid
		{
			get
			{
				short num = (short)1356810448;
				short num2 = num;
				num = (short)511199440;
				switch (num2 == num)
				{
				}
				num = (short)1825570816;
				if (num != 0)
				{
				}
				num = (short)1629028352;
				short num3 = num;
				num = (short)824246273;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033.Valid;
			}
			set
			{
				short num = (short)683276167;
				short num2 = num;
				num = (short)1690302343;
				switch (num2 == num)
				{
				}
				num = (short)247463936;
				if (num != 0)
				{
				}
				num = (short)1233977344;
				short num3 = num;
				num = (short)1541603329;
				if (num != 0)
				{
				}
				this.uclPhone_PhoneNumber_A00033.Valid = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x002191F0 File Offset: 0x002173F0
		public bool UclPhone_PhoneNumber_A00033_HasDiffs
		{
			get
			{
				short num = (short)1417412609;
				if (num != 0)
				{
				}
				num = (short)1385466672;
				short num2 = num;
				num = (short)825068336;
				switch (num2 == num)
				{
				}
				num = (short)1388969984;
				short num3 = num;
				num = (short)132317184;
				if (num != 0)
				{
				}
				return this.uclPhone_PhoneNumber_A00033._HasDiffs;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x002192A4 File Offset: 0x002174A4
		public global::AcpBusinessLayer.AcpListField UclPhone_ListinfoPhoneCategory_A00034Object
		{
			get
			{
				short num = (short)748924842;
				short num2 = num;
				num = (short)1074048938;
				switch (num2 == num)
				{
				}
				num = (short)2025324545;
				if (num != 0)
				{
				}
				num = (short)1504378880;
				short num3 = num;
				num = (short)412090368;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00219354 File Offset: 0x00217554
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00219408 File Offset: 0x00217608
		public int UclPhone_ListinfoPhoneCategory_A00034Value
		{
			get
			{
				short num = (short)1045223092;
				short num2 = num;
				num = (short)643487412;
				switch (num2 == num)
				{
				}
				num = (short)773062656;
				if (num != 0)
				{
				}
				num = (short)343539712;
				short num3 = num;
				num = (short)2057109505;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.Value;
			}
			set
			{
				short num = (short)1964310529;
				if (num != 0)
				{
				}
				num = (short)1976959285;
				short num2 = num;
				num = (short)508166453;
				switch (num2 == num)
				{
				}
				num = (short)851771392;
				short num3 = num;
				num = (short)52559872;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.Value = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x002194BC File Offset: 0x002176BC
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00219574 File Offset: 0x00217774
		public string UclPhone_ListinfoPhoneCategory_A00034_UIValue
		{
			get
			{
				short num = (short)1715142657;
				if (num != 0)
				{
				}
				num = (short)108803611;
				short num2 = num;
				num = (short)706819611;
				switch (num2 == num)
				{
				}
				num = (short)145031168;
				short num3 = num;
				num = (short)935526400;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.UIValue;
			}
			set
			{
				short num = (short)397979952;
				short num2 = num;
				num = (short)334672176;
				switch (num2 == num)
				{
				}
				num = (short)528285696;
				if (num != 0)
				{
				}
				num = (short)1577451520;
				short num3 = num;
				num = (short)1829896193;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.UIValue = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00219628 File Offset: 0x00217828
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x002196DC File Offset: 0x002178DC
		[global::System.ComponentModel.Browsable(false)]
		public bool UclPhone_ListinfoPhoneCategory_A00034_Applicable
		{
			get
			{
				short num = (short)872825916;
				short num2 = num;
				num = (short)549340220;
				switch (num2 == num)
				{
				}
				num = (short)1030160385;
				if (num != 0)
				{
				}
				num = (short)449576960;
				short num3 = num;
				num = (short)501022720;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.Applicable;
			}
			set
			{
				short num = (short)2095332086;
				short num2 = num;
				num = (short)1311062774;
				switch (num2 == num)
				{
				}
				num = (short)1495400448;
				if (num != 0)
				{
				}
				num = (short)1089404928;
				short num3 = num;
				num = (short)1501233153;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.Applicable = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00219794 File Offset: 0x00217994
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00219848 File Offset: 0x00217A48
		[global::System.ComponentModel.Browsable(false)]
		public bool UclPhone_ListinfoPhoneCategory_A00034_Editable
		{
			get
			{
				short num = (short)825121200;
				short num2 = num;
				num = (short)461724080;
				switch (num2 == num)
				{
				}
				num = (short)680263681;
				if (num != 0)
				{
				}
				num = (short)584450048;
				short num3 = num;
				num = (short)575275008;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.Editable;
			}
			set
			{
				short num = (short)1945295213;
				short num2 = num;
				num = (short)27646317;
				switch (num2 == num)
				{
				}
				num = (short)780533761;
				if (num != 0)
				{
				}
				num = (short)204210176;
				short num3 = num;
				num = (short)529530880;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.Editable = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x002198FC File Offset: 0x00217AFC
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x002199B0 File Offset: 0x00217BB0
		[global::System.ComponentModel.Browsable(false)]
		public bool UclPhone_ListinfoPhoneCategory_A00034_Visible
		{
			get
			{
				short num = (short)793364373;
				short num2 = num;
				num = (short)2022688661;
				switch (num2 == num)
				{
				}
				num = (short)1067188224;
				if (num != 0)
				{
				}
				num = (short)916783104;
				short num3 = num;
				num = (short)1077215233;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.Visible;
			}
			set
			{
				short num = (short)2027092133;
				short num2 = num;
				num = (short)1235679397;
				switch (num2 == num)
				{
				}
				num = (short)742195201;
				if (num != 0)
				{
				}
				num = (short)1896677376;
				short num3 = num;
				num = (short)2053177344;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.Visible = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00219A64 File Offset: 0x00217C64
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00219B1C File Offset: 0x00217D1C
		[global::System.ComponentModel.Browsable(false)]
		public bool UclPhone_ListinfoPhoneCategory_A00034_Valid
		{
			get
			{
				short num = (short)517494271;
				short num2 = num;
				num = (short)1557812735;
				switch (num2 == num)
				{
				}
				num = (short)1826816001;
				if (num != 0)
				{
				}
				num = (short)1429405696;
				short num3 = num;
				num = (short)1820327936;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034.Valid;
			}
			set
			{
				short num = (short)117768665;
				short num2 = num;
				num = (short)1840382425;
				switch (num2 == num)
				{
				}
				num = (short)1136263168;
				if (num != 0)
				{
				}
				num = (short)797704192;
				short num3 = num;
				num = (short)652410881;
				if (num != 0)
				{
				}
				this.uclPhone_ListinfoPhoneCategory_A00034.Valid = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00219BD0 File Offset: 0x00217DD0
		public bool UclPhone_ListinfoPhoneCategory_A00034_HasDiffs
		{
			get
			{
				short num = (short)1935208989;
				short num2 = num;
				num = (short)940372509;
				switch (num2 == num)
				{
				}
				num = (short)1784938496;
				if (num != 0)
				{
				}
				num = (short)1136656384;
				short num3 = num;
				num = (short)2096824321;
				if (num != 0)
				{
				}
				return this.uclPhone_ListinfoPhoneCategory_A00034._HasDiffs;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00219C84 File Offset: 0x00217E84
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x00219D3C File Offset: 0x00217F3C
		public string UclPhone_CombinedID_A00035Value
		{
			get
			{
				short num = (short)1494519581;
				short num2 = num;
				num = (short)1817087773;
				switch (num2 == num)
				{
				}
				num = (short)1634140160;
				if (num != 0)
				{
				}
				num = (short)463994880;
				short num3 = num;
				num = (short)1713963009;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.Value;
			}
			set
			{
				short num = (short)320824935;
				short num2 = num;
				num = (short)1458005607;
				switch (num2 == num)
				{
				}
				num = (short)1192165377;
				if (num != 0)
				{
				}
				num = (short)1005518848;
				short num3 = num;
				num = (short)885522432;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.Value = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00219DF0 File Offset: 0x00217FF0
		public global::AcpBusinessLayer.AcpKeyField UclPhone_CombinedID_A00035Object
		{
			get
			{
				short num = (short)683755024;
				short num2 = num;
				num = (short)1320306192;
				switch (num2 == num)
				{
				}
				num = (short)1438056448;
				if (num != 0)
				{
				}
				num = (short)1420754944;
				short num3 = num;
				num = (short)1024655361;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00219E9C File Offset: 0x0021809C
		internal string UclPhone_CombinedID_A00035_UILabel
		{
			get
			{
				short num = (short)2127627735;
				short num2 = num;
				num = (short)971507159;
				switch (num2 == num)
				{
				}
				num = (short)433258496;
				if (num != 0)
				{
				}
				num = (short)1861812224;
				short num3 = num;
				num = (short)311558145;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.UIName;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00219F50 File Offset: 0x00218150
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x0021A004 File Offset: 0x00218204
		public bool UclPhone_CombinedID_A00035_Applicable
		{
			get
			{
				short num = (short)2090911788;
				short num2 = num;
				num = (short)1363265580;
				switch (num2 == num)
				{
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				num = (short)299499520;
				short num3 = num;
				num = (short)866320385;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.Applicable;
			}
			set
			{
				short num = (short)226161505;
				short num2 = num;
				num = (short)1233253217;
				switch (num2 == num)
				{
				}
				num = (short)767164417;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				short num3 = num;
				num = (short)2128150528;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.Applicable = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0021A0B8 File Offset: 0x002182B8
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0021A170 File Offset: 0x00218370
		public bool UclPhone_CombinedID_A00035_Editable
		{
			get
			{
				short num = (short)1601306625;
				if (num != 0)
				{
				}
				num = (short)1872435015;
				short num2 = num;
				num = (short)878450503;
				switch (num2 == num)
				{
				}
				num = (short)344064000;
				short num3 = num;
				num = (short)1646657536;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.Editable;
			}
			set
			{
				short num = (short)1058136736;
				short num2 = num;
				num = (short)39969440;
				switch (num2 == num)
				{
				}
				num = (short)1378942977;
				if (num != 0)
				{
				}
				num = (short)1882259456;
				short num3 = num;
				num = (short)684654592;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.Editable = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0021A228 File Offset: 0x00218428
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x0021A2DC File Offset: 0x002184DC
		public bool UclPhone_CombinedID_A00035_Visible
		{
			get
			{
				short num = (short)1271995206;
				short num2 = num;
				num = (short)60365638;
				switch (num2 == num)
				{
				}
				num = (short)2022834177;
				if (num != 0)
				{
				}
				num = (short)1905262592;
				short num3 = num;
				num = (short)899088384;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.Visible;
			}
			set
			{
				short num = (short)1508439714;
				short num2 = num;
				num = (short)1497429666;
				switch (num2 == num)
				{
				}
				num = (short)342360065;
				if (num != 0)
				{
				}
				num = (short)506593280;
				short num3 = num;
				num = (short)2003107840;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.Visible = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0021A390 File Offset: 0x00218590
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0021A444 File Offset: 0x00218644
		internal bool UclPhone_CombinedID_A00035_HiddenStatic
		{
			get
			{
				short num = (short)1869665214;
				short num2 = num;
				num = (short)1251791806;
				switch (num2 == num)
				{
				}
				num = (short)297533440;
				short num3 = num;
				num = (short)2082537473;
				if (num != 0)
				{
				}
				num = (short)1236467712;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.HiddenStatic;
			}
			set
			{
				short num = (short)391608101;
				short num2 = num;
				num = (short)1030256421;
				switch (num2 == num)
				{
				}
				num = (short)713490432;
				short num3 = num;
				num = (short)114753537;
				if (num != 0)
				{
				}
				num = (short)1154416640;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.HiddenStatic = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0021A4F8 File Offset: 0x002186F8
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0021A5B0 File Offset: 0x002187B0
		public bool UclPhone_CombinedID_A00035_Valid
		{
			get
			{
				short num = (short)1166409729;
				if (num != 0)
				{
				}
				num = (short)1731325283;
				short num2 = num;
				num = (short)56421731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720516608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)340459520;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035.Valid;
			}
			set
			{
				short num = (short)287671305;
				short num2 = num;
				num = (short)527139849;
				switch (num2 == num)
				{
				}
				num = (short)452984832;
				short num3 = num;
				num = (short)1004339201;
				if (num != 0)
				{
				}
				num = (short)1245184000;
				if (num != 0)
				{
				}
				this.uclPhone_CombinedID_A00035.Valid = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0021A668 File Offset: 0x00218868
		public bool UclPhone_CombinedID_A00035_HasDiffs
		{
			get
			{
				short num = (short)1135738881;
				if (num != 0)
				{
				}
				num = (short)306291507;
				short num2 = num;
				num = (short)1424466739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)394985472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)990838784;
				if (num != 0)
				{
				}
				return this.uclPhone_CombinedID_A00035._HasDiffs;
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0000265F File Offset: 0x0000085F
		internal PhoneCallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0021A71C File Offset: 0x0021891C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1055675749;
			short num2 = num;
			num = (short)1153258853;
			switch (num2 == num)
			{
			}
			num = (short)558956544;
			short num3 = num;
			num = (short)240189441;
			if (num != 0)
			{
			}
			num = (short)2025127936;
			if (num != 0)
			{
			}
			this.uclPhone_PhoneNumber_A00033 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펔", a_), new global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection.UnpackAndpackPhoneNumber(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔쮚쾠욢瘝솨쒪쎬쪮ﾰ욲\ud8b4햶\udcb8즺ﺾ靖", a_), global::CommonResources.AppResources.Number_Id);
			this.uclPhone_PhoneNumber_A00033.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclPhone_PhoneNumber_A00033.DataTransferOrder = 1;
			this.uclPhone_PhoneNumber_A00033.KeyNameField = true;
			this.uclPhone_ListinfoPhoneCategory_A00034 = new global::AcpBusinessLayer.AcpListField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔쮚쾠욢瘝삨\ud8aa\ud9ac욮\udfb0햲\udab4톸풺펼\udabe苀ꋂ뇄ꋆ껈꓊뿌뛎軐鋒", a_), global::CommonResources.AppResources.Category_Id, global::SpecialFeatures.Ucl.Contact.LOVs.PhoneCategoryList);
			this.uclPhone_ListinfoPhoneCategory_A00034.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclPhone_ListinfoPhoneCategory_A00034.DataTransferOrder = 2;
			this.uclPhone_ListinfoPhoneCategory_A00034.KeyNameField = true;
			this.uclPhone_CombinedID_A00035 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔쮚쾠욢瘝욨욪쾬욮\udfb0횲톴ﺶﶸﲼ达", a_), global::CommonResources.AppResources.Call_ID);
			this.uclPhone_CombinedID_A00035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclPhone_CombinedID_A00035.EvaluateRecRefs = true;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얔ﾖ뾞횢좤얦첨\ud9aa\udeac", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Numbers;
			base.DataTransferOrder = 3;
			base.Id = 10414;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0021A8D8 File Offset: 0x00218AD8
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)594161434;
			short num2 = num;
			num = (short)2028678938;
			switch (num2 == num)
			{
			}
			num = (short)1450967040;
			short num3 = num;
			num = (short)622133249;
			if (num != 0)
			{
			}
			num = (short)840368128;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0021A988 File Offset: 0x00218B88
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)874184710;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜\udc9e캠캢잤캦잨캪즬螶覸论躼誾", a_)))
					{
						num = (short)1887371266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 1:
					goto IL_E8;
				case 2:
				{
					num = (short)652279808;
					short num3 = num;
					this.uclPhone_CombinedID_A00035 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜\udc9e캠캢잤캦잨캪즬螶覸论躼誾", a_), global::CommonResources.AppResources.Call_ID);
					this.uclPhone_CombinedID_A00035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclPhone_CombinedID_A00035.EvaluateRecRefs = true;
					num = (short)309526532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜쾞즠첢쮤슦\udeaa사춮풰솲覸论趼貾", a_)))
					{
						num = (short)1888681992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 4:
					goto IL_241;
				case 5:
					if (producerFields != null)
					{
						num = (short)87359497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜펞좠킢톤캦잨춪슬ﾮ\ud9b0\udcb2\udbb4튶視\udaba즼\udabeꛀ곂럄뻆雈諊﷌ￎ", a_)))
					{
						num = (short)311689228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_280;
				case 8:
					this.uclPhone_PhoneNumber_A00033 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮌", a_), new global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection.UnpackAndpackPhoneNumber(), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜쾞즠첢쮤슦\udeaa사춮풰솲覸论趼貾", a_), global::CommonResources.AppResources.Number_Id);
					this.uclPhone_PhoneNumber_A00033.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclPhone_PhoneNumber_A00033.DataTransferOrder = 1;
					this.uclPhone_PhoneNumber_A00033.KeyNameField = true;
					goto IL_34B;
				case 9:
					num = (short)1642266627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)690749445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_280;
				case 12:
					this.uclPhone_ListinfoPhoneCategory_A00034 = new global::AcpBusinessLayer.AcpListField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88c﶐쎒ﶔﺚ슜펞좠킢톤캦잨춪슬ﾮ\ud9b0\udcb2\udbb4튶視\udaba즼\udabeꛀ곂럄뻆雈諊﷌ￎ", a_), global::CommonResources.AppResources.Category_Id, global::SpecialFeatures.Ucl.Contact.LOVs.PhoneCategoryList);
					this.uclPhone_ListinfoPhoneCategory_A00034.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclPhone_ListinfoPhoneCategory_A00034.DataTransferOrder = 2;
					this.uclPhone_ListinfoPhoneCategory_A00034.KeyNameField = true;
					num = (short)1381498891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)299761674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_E8:
				num = (short)71139086;
				short num4 = num;
				num = (short)197623566;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_34B:
					num = (short)1520041985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1163198464;
					if (num != 0)
					{
					}
					num = (short)1372913671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_280:
				num = (short)477560833;
				if (num != 0)
				{
				}
				num = (short)307363840;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_241:
			IL_367:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8cﺐﶒ랖힘ﶞ쒠톢횤", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Numbers;
			base.DataTransferOrder = 3;
			base.Id = 10414;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0021AD30 File Offset: 0x00218F30
		public override void PopulateReferences()
		{
			short num = (short)1131474547;
			short num2 = num;
			num = (short)89714291;
			switch (num2 == num)
			{
			}
			num = (short)1307181056;
			short num3 = num;
			num = (short)209125377;
			if (num != 0)
			{
			}
			num = (short)1916469248;
			if (num != 0)
			{
			}
			((global::AcpBusinessLayer.Recordset)base.ParentRecset).RefreshKeyForNode((global::AcpBusinessLayer.FeatureNode)base.Parent);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0021ADF4 File Offset: 0x00218FF4
		public override void DropReferences()
		{
			short num = (short)638857018;
			short num2 = num;
			num = (short)1173040954;
			switch (num2 == num)
			{
			}
			num = (short)1591345152;
			short num3 = num;
			num = (short)798949376;
			if (num != 0)
			{
			}
			num = (short)999424001;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0021AEA0 File Offset: 0x002190A0
		public override void SetConstraints()
		{
			short num = (short)2118451201;
			if (num != 0)
			{
			}
			num = (short)2119940994;
			short num2 = num;
			num = (short)716094338;
			switch (num2 == num)
			{
			default:
			{
				num = (short)848297984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1325793280;
			if (num != 0)
			{
			}
			this.uclPhone_ListinfoPhoneCategory_A00034.ValidateAcrossRecset = true;
			this.uclPhone_ListinfoPhoneCategory_A00034.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsPhoneCategoryTypeValid);
			this.uclPhone_CombinedID_A00035.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.uclPhone_PhoneNumber_A00033.ValidateAcrossRecset = true;
			this.uclPhone_PhoneNumber_A00033.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.Contact.UclContactConstraints.conIsPhoneNumberValid);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0021AFA8 File Offset: 0x002191A8
		public override void SetupDependencies()
		{
			short num = (short)105316353;
			if (num != 0)
			{
			}
			num = (short)152750677;
			short num2 = num;
			num = (short)1094044245;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1255342080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1207762944;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.PhoneCallHotList phoneCallHotList = ((global::AcpCommonLib.FeatureManager.GetFeature(2220)[0] as global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotList).PhoneCallHotList.EmbeddedRecset as global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset)[0] as global::SpecialFeatures.Ucl.HotList.PhoneCallHotList;
			this.uclPhone_PhoneNumber_A00033.AddDependentObject(phoneCallHotList.HotListPhone.UclPhoneHotList_CallID_A00050Object);
			this.uclPhone_ListinfoPhoneCategory_A00034.AddDependentObject(phoneCallHotList.HotListPhone.UclPhoneHotList_CallID_A00050Object);
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0021B0B0 File Offset: 0x002192B0
		public bool HasDiffs
		{
			get
			{
				short num = (short)9197285;
				short num2 = num;
				num = (short)1881691877;
				switch (num2 == num)
				{
				}
				num = (short)2062221312;
				short num3 = num;
				num = (short)607649792;
				if (num != 0)
				{
				}
				num = (short)144834561;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000CA8 RID: 3240
		private global::AcpBusinessLayer.AcpFieldX<string, string> uclPhone_PhoneNumber_A00033;

		// Token: 0x04000CA9 RID: 3241
		private global::AcpBusinessLayer.AcpListField uclPhone_ListinfoPhoneCategory_A00034;

		// Token: 0x04000CAA RID: 3242
		private global::AcpBusinessLayer.AcpKeyField uclPhone_CombinedID_A00035;

		// Token: 0x02000205 RID: 517
		internal class UnpackAndpackPhoneNumber : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001983 RID: 6531 RVA: 0x0021B160 File Offset: 0x00219360
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				int a_ = 10;
				short num;
				if (!value.ToString().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮌", a_)))
				{
					num = (short)1148712908;
					short num2 = num;
					num = (short)1448802252;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)868548608;
						if (num != 0)
						{
						}
						num = (short)1254752257;
						if (num != 0)
						{
						}
						return value.ToString().ToUpper().Replace('A', '*').Replace('B', '#').Replace('C', 'P');
					}
				}
				num = (short)529924096;
				short num3 = num;
				return "";
			}

			// Token: 0x06001984 RID: 6532 RVA: 0x0021B258 File Offset: 0x00219458
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				int a_ = 12;
				short num = (short)1201274882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_FB;
					case 1:
						num = (short)832700417;
						if (num != 0)
						{
						}
						if (value.ToString() == "")
						{
							num = (short)1584267264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3F;
						}
						continue;
					case 3:
						goto IL_80;
					}
					IL_3F:
					if (value == null)
					{
						num = (short)656867328;
						short num3 = num;
						num = (short)987365379;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1756561409;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_80:
				return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎", a_);
				IL_FB:
				num = (short)1570510627;
				short num4 = num;
				num = (short)364123939;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15B:
					return value.ToString().ToUpper().Replace('*', 'A').Replace('#', 'B').Replace('P', 'C');
				default:
					num = (short)2081357824;
					if (num != 0)
					{
					}
					return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎", a_);
				}
			}
		}
	}
}
