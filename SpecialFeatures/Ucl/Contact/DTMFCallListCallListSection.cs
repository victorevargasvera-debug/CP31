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
	// Token: 0x020001FD RID: 509
	[global::System.Serializable]
	public sealed class DTMFCallListCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x00002650 File Offset: 0x00000850
		internal DTMFCallListCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0020EA08 File Offset: 0x0020CC08
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0020EAC0 File Offset: 0x0020CCC0
		public string SystemGroupNumber
		{
			get
			{
				short num = (short)524293992;
				short num2 = num;
				num = (short)700258152;
				switch (num2 == num)
				{
				}
				num = (short)1389101057;
				if (num != 0)
				{
				}
				num = (short)897843200;
				short num3 = num;
				num = (short)132448256;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Value;
			}
			set
			{
				int a_ = 5;
				short num = (short)159670706;
				short num2 = num;
				num = (short)1915249074;
				switch (num2 == num)
				{
				}
				num = (short)1691549697;
				if (num != 0)
				{
				}
				num = (short)1891631104;
				short num3 = num;
				num = (short)209584128;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Value = value;
				this.combinedID.Value = this.systemGroupNumber.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖇ", a_) + this.primaryID.ToString();
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0020EBB4 File Offset: 0x0020CDB4
		public global::AcpBusinessLayer.AcpField<string> SystemGroupNumberObject
		{
			get
			{
				short num = (short)439594880;
				short num2 = num;
				num = (short)123645824;
				switch (num2 == num)
				{
				}
				num = (short)1286012929;
				if (num != 0)
				{
				}
				num = (short)1961885696;
				short num3 = num;
				num = (short)2090598400;
				if (num != 0)
				{
				}
				return this.systemGroupNumber;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0020EC64 File Offset: 0x0020CE64
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x0020ED1C File Offset: 0x0020CF1C
		public bool SystemGroupNumber_Applicable
		{
			get
			{
				short num = (short)282522027;
				short num2 = num;
				num = (short)456520107;
				switch (num2 == num)
				{
				}
				num = (short)933822465;
				if (num != 0)
				{
				}
				num = (short)936706048;
				short num3 = num;
				num = (short)1923284992;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Applicable;
			}
			set
			{
				short num = (short)953515072;
				short num2 = num;
				num = (short)2126543936;
				switch (num2 == num)
				{
				}
				num = (short)1669464064;
				if (num != 0)
				{
				}
				num = (short)824705024;
				short num3 = num;
				num = (short)367132673;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Applicable = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0020EDD4 File Offset: 0x0020CFD4
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0020EE8C File Offset: 0x0020D08C
		public bool SystemGroupNumber_Editable
		{
			get
			{
				short num = (short)2081476615;
				short num2 = num;
				num = (short)201904135;
				switch (num2 == num)
				{
				}
				num = (short)835649537;
				if (num != 0)
				{
				}
				num = (short)301465600;
				short num3 = num;
				num = (short)682885120;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Editable;
			}
			set
			{
				short num = (short)1521156097;
				if (num != 0)
				{
				}
				num = (short)927649429;
				short num2 = num;
				num = (short)383504021;
				switch (num2 == num)
				{
				}
				num = (short)199819264;
				short num3 = num;
				num = (short)693633024;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Editable = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0020EF40 File Offset: 0x0020D140
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0020EFF4 File Offset: 0x0020D1F4
		public bool SystemGroupNumber_Visible
		{
			get
			{
				short num = (short)1136291644;
				short num2 = num;
				num = (short)58945340;
				switch (num2 == num)
				{
				}
				num = (short)1967259649;
				if (num != 0)
				{
				}
				num = (short)1997864960;
				short num3 = num;
				num = (short)321716224;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Visible;
			}
			set
			{
				short num = (short)1798906336;
				short num2 = num;
				num = (short)699408864;
				switch (num2 == num)
				{
				}
				num = (short)471334913;
				if (num != 0)
				{
				}
				num = (short)1668415488;
				short num3 = num;
				num = (short)1379401728;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Visible = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0020F0A8 File Offset: 0x0020D2A8
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0020F15C File Offset: 0x0020D35C
		public bool SystemGroupNumber_Valid
		{
			get
			{
				short num = (short)1065456312;
				short num2 = num;
				num = (short)2082968248;
				switch (num2 == num)
				{
				}
				num = (short)135790593;
				if (num != 0)
				{
				}
				num = (short)1454374912;
				short num3 = num;
				num = (short)1807482880;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.Valid;
			}
			set
			{
				short num = (short)1592131585;
				if (num != 0)
				{
				}
				num = (short)141412818;
				short num2 = num;
				num = (short)38455762;
				switch (num2 == num)
				{
				}
				num = (short)1646198784;
				short num3 = num;
				num = (short)1490747392;
				if (num != 0)
				{
				}
				this.systemGroupNumber.Valid = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0020F210 File Offset: 0x0020D410
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0020F2C8 File Offset: 0x0020D4C8
		public string PrimaryID
		{
			get
			{
				short num = (short)1857478563;
				short num2 = num;
				num = (short)1086578595;
				switch (num2 == num)
				{
				}
				num = (short)225116161;
				if (num != 0)
				{
				}
				num = (short)406650880;
				short num3 = num;
				num = (short)1215430656;
				if (num != 0)
				{
				}
				return this.primaryID.Value;
			}
			set
			{
				int a_ = 2;
				short num = (short)1160957132;
				short num2 = num;
				num = (short)1696779468;
				switch (num2 == num)
				{
				}
				num = (short)1347223553;
				if (num != 0)
				{
				}
				num = (short)290193408;
				short num3 = num;
				num = (short)1072955392;
				if (num != 0)
				{
				}
				this.primaryID.Value = value;
				this.combinedID.Value = this.systemGroupNumber.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢄ", a_) + this.primaryID.ToString();
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0020F3B8 File Offset: 0x0020D5B8
		public global::AcpBusinessLayer.AcpField<string> PrimaryIDObject
		{
			get
			{
				short num = (short)65969947;
				short num2 = num;
				num = (short)1988337435;
				switch (num2 == num)
				{
				}
				num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)1766653952;
				short num3 = num;
				num = (short)858914816;
				if (num != 0)
				{
				}
				return this.primaryID;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0020F468 File Offset: 0x0020D668
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x0020F51C File Offset: 0x0020D71C
		public bool PrimaryID_Applicable
		{
			get
			{
				short num = (short)48715860;
				short num2 = num;
				num = (short)411916372;
				switch (num2 == num)
				{
				}
				num = (short)308936704;
				if (num != 0)
				{
				}
				num = (short)343212032;
				short num3 = num;
				num = (short)878772225;
				if (num != 0)
				{
				}
				return this.primaryID.Applicable;
			}
			set
			{
				short num = (short)2144607799;
				short num2 = num;
				num = (short)691805751;
				switch (num2 == num)
				{
				}
				num = (short)240254977;
				if (num != 0)
				{
				}
				num = (short)166658048;
				short num3 = num;
				num = (short)801439744;
				if (num != 0)
				{
				}
				this.primaryID.Applicable = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0020F5D0 File Offset: 0x0020D7D0
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0020F684 File Offset: 0x0020D884
		public bool PrimaryID_Editable
		{
			get
			{
				short num = (short)98430286;
				short num2 = num;
				num = (short)79031630;
				switch (num2 == num)
				{
				}
				num = (short)1580335104;
				if (num != 0)
				{
				}
				num = (short)823721984;
				short num3 = num;
				num = (short)1109327873;
				if (num != 0)
				{
				}
				return this.primaryID.Editable;
			}
			set
			{
				short num = (short)480485889;
				short num2 = num;
				num = (short)449749505;
				switch (num2 == num)
				{
				}
				num = (short)1341390849;
				if (num != 0)
				{
				}
				num = (short)2144731136;
				short num3 = num;
				num = (short)1277231104;
				if (num != 0)
				{
				}
				this.primaryID.Editable = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0020F73C File Offset: 0x0020D93C
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0020F7F0 File Offset: 0x0020D9F0
		public bool PrimaryID_Visible
		{
			get
			{
				short num = (short)2066402000;
				short num2 = num;
				num = (short)350669520;
				switch (num2 == num)
				{
				}
				num = (short)1158086656;
				if (num != 0)
				{
				}
				num = (short)74186752;
				short num3 = num;
				num = (short)1798242305;
				if (num != 0)
				{
				}
				return this.primaryID.Visible;
			}
			set
			{
				short num = (short)1971577312;
				short num2 = num;
				num = (short)846455264;
				switch (num2 == num)
				{
				}
				num = (short)1493499904;
				if (num != 0)
				{
				}
				num = (short)1570045952;
				short num3 = num;
				num = (short)928120833;
				if (num != 0)
				{
				}
				this.primaryID.Visible = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0020F8A8 File Offset: 0x0020DAA8
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0020F95C File Offset: 0x0020DB5C
		public bool PrimaryID_Valid
		{
			get
			{
				short num = (short)531041292;
				short num2 = num;
				num = (short)1965820940;
				switch (num2 == num)
				{
				}
				num = (short)481558528;
				if (num != 0)
				{
				}
				num = (short)1450704896;
				short num3 = num;
				num = (short)161873921;
				if (num != 0)
				{
				}
				return this.primaryID.Valid;
			}
			set
			{
				short num = (short)1455426662;
				short num2 = num;
				num = (short)304876646;
				switch (num2 == num)
				{
				}
				num = (short)1269956609;
				if (num != 0)
				{
				}
				num = (short)1154678784;
				short num3 = num;
				num = (short)126484480;
				if (num != 0)
				{
				}
				this.primaryID.Valid = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0020FA10 File Offset: 0x0020DC10
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0020FAE8 File Offset: 0x0020DCE8
		public string CombinedID
		{
			get
			{
				int a_ = 15;
				short num = (short)1453741567;
				short num2 = num;
				num = (short)1902728703;
				switch (num2 == num)
				{
				}
				num = (short)659030017;
				if (num != 0)
				{
				}
				num = (short)1330249728;
				short num3 = num;
				num = (short)878379008;
				if (num != 0)
				{
				}
				return this.systemGroupNumber.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾑", a_) + this.primaryID.ToString();
			}
			set
			{
				int a_ = 16;
				short num = (short)128668656;
				short num2 = num;
				num = (short)1317884912;
				switch (num2 == num)
				{
				}
				num = (short)1834287105;
				if (num != 0)
				{
				}
				num = (short)2121203712;
				short num3 = num;
				num = (short)2088108032;
				if (num != 0)
				{
				}
				this.combinedID.Value = this.systemGroupNumber.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺒", a_) + this.primaryID.ToString();
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0020FBCC File Offset: 0x0020DDCC
		public global::AcpBusinessLayer.AcpKeyField CombinedIDObject
		{
			get
			{
				short num = (short)656931643;
				short num2 = num;
				num = (short)964819771;
				switch (num2 == num)
				{
				}
				num = (short)1943011329;
				if (num != 0)
				{
				}
				num = (short)270663680;
				short num3 = num;
				num = (short)1251999744;
				if (num != 0)
				{
				}
				return this.combinedID;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0020FC7C File Offset: 0x0020DE7C
		internal string CombinedID_UILabel
		{
			get
			{
				short num = (short)601615362;
				short num2 = num;
				num = (short)1988619266;
				switch (num2 == num)
				{
				}
				num = (short)271450112;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				short num3 = num;
				num = (short)1039400961;
				if (num != 0)
				{
				}
				return this.combinedID.UIName;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0020FD30 File Offset: 0x0020DF30
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x0020FDE8 File Offset: 0x0020DFE8
		public bool CombinedID_Applicable
		{
			get
			{
				short num = (short)53608449;
				if (num != 0)
				{
				}
				num = (short)1113299590;
				short num2 = num;
				num = (short)1491311238;
				switch (num2 == num)
				{
				}
				num = (short)1906769920;
				short num3 = num;
				num = (short)1403518976;
				if (num != 0)
				{
				}
				return this.combinedID.Applicable;
			}
			set
			{
				short num = (short)589035088;
				short num2 = num;
				num = (short)1296430672;
				switch (num2 == num)
				{
				}
				num = (short)1252458497;
				if (num != 0)
				{
				}
				num = (short)141557760;
				short num3 = num;
				num = (short)1789198336;
				if (num != 0)
				{
				}
				this.combinedID.Applicable = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x0020FE9C File Offset: 0x0020E09C
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x0020FF50 File Offset: 0x0020E150
		public bool CombinedID_Editable
		{
			get
			{
				short num = (short)1783434847;
				short num2 = num;
				num = (short)2069892703;
				switch (num2 == num)
				{
				}
				num = (short)508166144;
				if (num != 0)
				{
				}
				num = (short)1226899456;
				short num3 = num;
				num = (short)1064304641;
				if (num != 0)
				{
				}
				return this.combinedID.Editable;
			}
			set
			{
				short num = (short)340787201;
				if (num != 0)
				{
				}
				num = (short)831779620;
				short num2 = num;
				num = (short)797831972;
				switch (num2 == num)
				{
				}
				num = (short)1101332480;
				short num3 = num;
				num = (short)1428422656;
				if (num != 0)
				{
				}
				this.combinedID.Editable = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00210008 File Offset: 0x0020E208
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x002100BC File Offset: 0x0020E2BC
		public bool CombinedID_Visible
		{
			get
			{
				short num = (short)842102121;
				short num2 = num;
				num = (short)532510057;
				switch (num2 == num)
				{
				}
				num = (short)1304363009;
				if (num != 0)
				{
				}
				num = (short)1351417856;
				short num3 = num;
				num = (short)537722880;
				if (num != 0)
				{
				}
				return this.combinedID.Visible;
			}
			set
			{
				short num = (short)1345763316;
				short num2 = num;
				num = (short)938260468;
				switch (num2 == num)
				{
				}
				num = (short)2012413953;
				if (num != 0)
				{
				}
				num = (short)236716032;
				short num3 = num;
				num = (short)416284672;
				if (num != 0)
				{
				}
				this.combinedID.Visible = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00210170 File Offset: 0x0020E370
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x00210228 File Offset: 0x0020E428
		internal bool CombinedID_HiddenStatic
		{
			get
			{
				short num = (short)1130407398;
				short num2 = num;
				num = (short)301245926;
				switch (num2 == num)
				{
				}
				num = (short)948699137;
				if (num != 0)
				{
				}
				num = (short)1057488896;
				short num3 = num;
				num = (short)2002255872;
				if (num != 0)
				{
				}
				return this.combinedID.HiddenStatic;
			}
			set
			{
				short num = (short)590126745;
				short num2 = num;
				num = (short)550674073;
				switch (num2 == num)
				{
				}
				num = (short)1043922945;
				if (num != 0)
				{
				}
				num = (short)1334312960;
				short num3 = num;
				num = (short)840630272;
				if (num != 0)
				{
				}
				this.combinedID.HiddenStatic = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x002102DC File Offset: 0x0020E4DC
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x00210390 File Offset: 0x0020E590
		public bool CombinedID_Valid
		{
			get
			{
				short num = (short)278326729;
				short num2 = num;
				num = (short)1537011145;
				switch (num2 == num)
				{
				}
				num = (short)212074497;
				if (num != 0)
				{
				}
				num = (short)1696858112;
				short num3 = num;
				num = (short)1289682944;
				if (num != 0)
				{
				}
				return this.combinedID.Valid;
			}
			set
			{
				short num = (short)1222511835;
				short num2 = num;
				num = (short)838601947;
				switch (num2 == num)
				{
				}
				num = (short)1563295745;
				if (num != 0)
				{
				}
				num = (short)1715142656;
				short num3 = num;
				num = (short)2080636928;
				if (num != 0)
				{
				}
				this.combinedID.Valid = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x00210444 File Offset: 0x0020E644
		public global::AcpBusinessLayer.AcpField<bool> IsHotListItemObject
		{
			get
			{
				short num = (short)562036737;
				if (num != 0)
				{
				}
				num = (short)1185165411;
				short num2 = num;
				num = (short)100741219;
				switch (num2 == num)
				{
				}
				num = (short)1084030976;
				short num3 = num;
				num = (short)114622464;
				if (num != 0)
				{
				}
				return this.isHotListItem;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x002104F4 File Offset: 0x0020E6F4
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x002105AC File Offset: 0x0020E7AC
		public bool IsHotListItem
		{
			get
			{
				short num = (short)1531918389;
				short num2 = num;
				num = (short)378550325;
				switch (num2 == num)
				{
				}
				num = (short)843382785;
				if (num != 0)
				{
				}
				num = (short)1762328576;
				short num3 = num;
				num = (short)1580597248;
				if (num != 0)
				{
				}
				return this.combinedID.IsReferenced;
			}
			set
			{
				short num = (short)1256980704;
				short num2 = num;
				num = (short)1918173408;
				switch (num2 == num)
				{
				}
				num = (short)1487863808;
				if (num != 0)
				{
				}
				num = (short)2144468992;
				short num3 = num;
				num = (short)117768193;
				if (num != 0)
				{
				}
				this.isHotListItem.Value = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x00210660 File Offset: 0x0020E860
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00210718 File Offset: 0x0020E918
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Applicable
		{
			get
			{
				short num = (short)233897985;
				if (num != 0)
				{
				}
				num = (short)1109363828;
				short num2 = num;
				num = (short)66620532;
				switch (num2 == num)
				{
				}
				num = (short)1383137280;
				short num3 = num;
				num = (short)2115174400;
				if (num != 0)
				{
				}
				return this.isHotListItem.Applicable;
			}
			set
			{
				short num = (short)1563814570;
				short num2 = num;
				num = (short)1164962474;
				switch (num2 == num)
				{
				}
				num = (short)1703018496;
				if (num != 0)
				{
				}
				num = (short)1213988864;
				short num3 = num;
				num = (short)1386741761;
				if (num != 0)
				{
				}
				this.isHotListItem.Applicable = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x002107D0 File Offset: 0x0020E9D0
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00210884 File Offset: 0x0020EA84
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Editable
		{
			get
			{
				short num = (short)1549205504;
				short num2 = num;
				num = (short)1054132172;
				short num3 = num;
				num = (short)408930252;
				switch (num3 == num)
				{
				}
				num = (short)967311361;
				if (num != 0)
				{
				}
				num = (short)73007104;
				if (num != 0)
				{
				}
				return this.isHotListItem.Editable;
			}
			set
			{
				short num = (short)1209008128;
				short num2 = num;
				num = (short)867827713;
				if (num != 0)
				{
				}
				num = (short)349311441;
				short num3 = num;
				num = (short)1938624977;
				switch (num3 == num)
				{
				}
				num = (short)620625920;
				if (num != 0)
				{
				}
				this.isHotListItem.Editable = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00210938 File Offset: 0x0020EB38
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x002109EC File Offset: 0x0020EBEC
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Visible
		{
			get
			{
				short num = (short)1752891392;
				short num2 = num;
				num = (short)443043934;
				short num3 = num;
				num = (short)1801015390;
				switch (num3 == num)
				{
				}
				num = (short)495386624;
				if (num != 0)
				{
				}
				num = (short)545521665;
				if (num != 0)
				{
				}
				return this.isHotListItem.Visible;
			}
			set
			{
				short num = (short)20905984;
				short num2 = num;
				num = (short)1301548207;
				short num3 = num;
				num = (short)109841583;
				switch (num3 == num)
				{
				}
				num = (short)439353345;
				if (num != 0)
				{
				}
				num = (short)1012531200;
				if (num != 0)
				{
				}
				this.isHotListItem.Visible = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00210AA0 File Offset: 0x0020ECA0
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00210B54 File Offset: 0x0020ED54
		[global::System.ComponentModel.Browsable(false)]
		public bool IsHotListItem_Valid
		{
			get
			{
				short num = (short)1705639936;
				short num2 = num;
				num = (short)1671563924;
				short num3 = num;
				num = (short)1254886036;
				switch (num3 == num)
				{
				}
				num = (short)1509556224;
				if (num != 0)
				{
				}
				num = (short)674365441;
				if (num != 0)
				{
				}
				return this.isHotListItem.Valid;
			}
			set
			{
				short num = (short)1427046400;
				short num2 = num;
				num = (short)1799491617;
				short num3 = num;
				num = (short)1131286561;
				switch (num3 == num)
				{
				}
				num = (short)1120600065;
				if (num != 0)
				{
				}
				num = (short)1020461056;
				if (num != 0)
				{
				}
				this.isHotListItem.Valid = value;
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0000265F File Offset: 0x0000085F
		internal DTMFCallListCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00210C08 File Offset: 0x0020EE08
		public override void Init()
		{
			int a_ = 15;
			short num = (short)88801280;
			short num2 = num;
			num = (short)100294318;
			short num3 = num;
			num = (short)757685934;
			switch (num3 == num)
			{
			}
			num = (short)1849884673;
			if (num != 0)
			{
			}
			num = (short)243073024;
			if (num != 0)
			{
			}
			this.systemGroupNumber = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪑ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﾙ\ud99d튟춡톣횥\udfa9솫청햯삱", a_), global::CommonResources.AppResources.System_Group_Number);
			this.primaryID = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊑ꒓ꚕꢗꮙ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﾕﮙ", a_), global::CommonResources.AppResources.Primary_ID);
			this.combinedID = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﮕ流ﮝ쒟", a_), global::CommonResources.AppResources.Call_ID);
			this.isHotListItem = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91\ude95킛펟횡튥춧잩", a_), global::CommonResources.AppResources.Hot_Listed);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑歹몙킛펟횡", a_);
			base.UIName = global::CommonResources.AppResources.Call_List;
			base.Id = 10408;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00210D84 File Offset: 0x0020EF84
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)569835520;
			short num2 = num;
			num = (short)1271922762;
			short num3 = num;
			num = (short)436600906;
			switch (num3 == num)
			{
			}
			num = (short)1343160320;
			if (num != 0)
			{
			}
			num = (short)109051905;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00210E38 File Offset: 0x0020F038
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1491271691;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)334255600;
					short num3 = num;
					num = (short)993809904;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25C;
					default:
						num = (short)550043648;
						if (num != 0)
						{
						}
						num = (short)1437532161;
						if (num != 0)
						{
						}
						this.combinedID = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﶒ킘\udf9a", a_), global::CommonResources.AppResources.Call_ID);
						num = (short)513605633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1D5;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988力\ude96\udd98", a_)))
					{
						num = (short)707854341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25C;
				case 3:
					goto IL_25C;
				case 4:
					goto IL_2E6;
				case 5:
					this.primaryID = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릈뮊붌뾎ꂐ", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988力\ude96\udd98", a_), global::CommonResources.AppResources.Primary_ID);
					num = (short)209584131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)606011406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_2E1;
				case 8:
					this.isHotListItem = new global::AcpBusinessLayer.AcpField<bool>(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈얌\udf92ﲔ튚爵철", a_), global::CommonResources.AppResources.Hot_Listed);
					num = (short)1548877831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1154023437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈얌\udf92ﲔ튚爵철", a_)))
					{
						num = (short)1207369736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37B;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 12:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈ﶒ킘\udf9a", a_)))
					{
						num = (short)1042677760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				case 13:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﺌﮎﺒ튔톞풠캢잤슦\udba8", a_)))
					{
						num = (short)464519183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E6;
				case 14:
					if (producerFields != null)
					{
						num = (short)1793654793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37B;
				case 15:
					this.systemGroupNumber = new global::AcpBusinessLayer.AcpField<string>(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놈", a_), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﺌﮎﺒ튔톞풠캢잤슦\udba8", a_), global::CommonResources.AppResources.System_Group_Number);
					num = (short)554172420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1056505862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D5:
				num = (short)1423704074;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25C:
				num = (short)1585709068;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E6:
				num = (short)795213826;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2E1:
			IL_37B:
			num = (short)1784086528;
			short num4 = num;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪈놐\udf92ﲔ", a_);
			base.UIName = global::CommonResources.AppResources.Call_List;
			base.Id = 10408;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0021121C File Offset: 0x0020F41C
		public override void PopulateReferences()
		{
			short num = (short)397279232;
			short num2 = num;
			num = (short)1621491713;
			if (num != 0)
			{
			}
			num = (short)1966486404;
			short num3 = num;
			num = (short)1440756612;
			switch (num3 == num)
			{
			}
			num = (short)1691090944;
			if (num != 0)
			{
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x002112C8 File Offset: 0x0020F4C8
		public override void DropReferences()
		{
			short num = (short)1076953088;
			short num2 = num;
			num = (short)1126808829;
			short num3 = num;
			num = (short)1200536829;
			switch (num3 == num)
			{
			}
			num = (short)1170931713;
			if (num != 0)
			{
			}
			num = (short)120455168;
			if (num != 0)
			{
			}
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00211374 File Offset: 0x0020F574
		public override void SetConstraints()
		{
			short num = (short)1939079168;
			short num2 = num;
			num = (short)1228053832;
			short num3 = num;
			num = (short)384015688;
			switch (num3 == num)
			{
			}
			num = (short)2130575360;
			if (num != 0)
			{
			}
			num = (short)2086797313;
			if (num != 0)
			{
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0021141C File Offset: 0x0020F61C
		public override void SetupDependencies()
		{
			short num = (short)926613504;
			short num2 = num;
			num = (short)1665400833;
			if (num != 0)
			{
			}
			num = (short)1318589625;
			short num3 = num;
			num = (short)847254713;
			switch (num3 == num)
			{
			}
			num = (short)52822016;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000C9B RID: 3227
		private global::AcpBusinessLayer.AcpField<string> systemGroupNumber;

		// Token: 0x04000C9C RID: 3228
		private global::AcpBusinessLayer.AcpField<string> primaryID;

		// Token: 0x04000C9D RID: 3229
		private global::AcpBusinessLayer.AcpKeyField combinedID;

		// Token: 0x04000C9E RID: 3230
		private global::AcpBusinessLayer.AcpField<bool> isHotListItem;
	}
}
