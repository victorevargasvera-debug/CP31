using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007C RID: 124
	public sealed partial class FeatureSetInnerSection : FeatureSection
	{
		// Token: 0x060009C2 RID: 2498 RVA: 0x00002BE9 File Offset: 0x00000DE9
		internal FeatureSetInnerSection(FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000AD0B0 File Offset: 0x000AB2B0
		private void a()
		{
			short num = (short)1730623127;
			short num2 = num;
			num = (short)97728151;
			switch (num2 == num)
			{
			}
			num = (short)1845755905;
			if (num != 0)
			{
			}
			num = (short)1105330176;
			if (num != 0)
			{
			}
			num = (short)1103495168;
			short num3 = num;
			this.a.Value = AppResources.N_A;
			this.b.Value = AppResources.N_A;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000AD17C File Offset: 0x000AB37C
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1268887692;
			short num2 = num;
			num = (short)1890103436;
			switch (num2 == num)
			{
			}
			num = (short)1846411265;
			if (num != 0)
			{
			}
			num = (short)761659392;
			if (num != 0)
			{
			}
			num = (short)1926365184;
			short num3 = num;
			this.a = new Field(AppResources.Purchased_Feature, true);
			this.b = new Field(AppResources.Enabled_in_Used_FLASHcode, true);
			base.FeatureSectionName = RptMgrErrorHandler.b("솆歷搜요", a_);
			base.Id = 32;
			base.UIName = AppResources.FeatureSet_Id;
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000AD274 File Offset: 0x000AB474
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000AD328 File Offset: 0x000AB528
		public string FeatureSetPurchasedFeatureNameValue
		{
			get
			{
				short num = (short)1153246730;
				short num2 = num;
				num = (short)2034968074;
				switch (num2 == num)
				{
				}
				num = (short)1612185601;
				if (num != 0)
				{
				}
				num = (short)1099104256;
				if (num != 0)
				{
				}
				num = (short)2104885248;
				short num3 = num;
				return this.a.Value;
			}
			set
			{
				short num = (short)1157208467;
				short num2 = num;
				num = (short)1042192787;
				switch (num2 == num)
				{
				}
				num = (short)1280311296;
				if (num != 0)
				{
				}
				num = (short)704380929;
				if (num != 0)
				{
				}
				num = (short)1535180800;
				short num3 = num;
				this.a.Value = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000AD3E0 File Offset: 0x000AB5E0
		public Field FeatureSetPurchasedFeatureName
		{
			get
			{
				short num = (short)929456422;
				short num2 = num;
				num = (short)501113126;
				switch (num2 == num)
				{
				}
				num = (short)752418817;
				if (num != 0)
				{
				}
				num = (short)332201984;
				if (num != 0)
				{
				}
				num = (short)415825920;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000AD490 File Offset: 0x000AB690
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x000AD544 File Offset: 0x000AB744
		public string FeatureSetPurchasedFeatureName_UIValue
		{
			get
			{
				short num = (short)661145383;
				short num2 = num;
				num = (short)2069448487;
				switch (num2 == num)
				{
				}
				num = (short)1783758849;
				if (num != 0)
				{
				}
				num = (short)1543766016;
				if (num != 0)
				{
				}
				num = (short)534708224;
				short num3 = num;
				return this.a.Value;
			}
			set
			{
				short num = (short)788673796;
				short num2 = num;
				num = (short)446969092;
				switch (num2 == num)
				{
				}
				num = (short)1480916992;
				if (num != 0)
				{
				}
				num = (short)1653669889;
				if (num != 0)
				{
				}
				num = (short)1514274816;
				short num3 = num;
				this.a.Value = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000AD5F8 File Offset: 0x000AB7F8
		public bool FeatureSetPurchasedFeatureName_Applicable
		{
			get
			{
				short num = (short)1960125493;
				short num2 = num;
				num = (short)1971201077;
				switch (num2 == num)
				{
				}
				num = (short)780795905;
				if (num != 0)
				{
				}
				num = (short)1692729344;
				if (num != 0)
				{
				}
				num = (short)1535049728;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000AD6A4 File Offset: 0x000AB8A4
		public bool FeatureSetPurchasedFeatureName_Valid
		{
			get
			{
				short num = (short)678107217;
				short num2 = num;
				num = (short)136517713;
				switch (num2 == num)
				{
				}
				num = (short)189267968;
				if (num != 0)
				{
				}
				num = (short)718077953;
				if (num != 0)
				{
				}
				num = (short)101974016;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x000AD750 File Offset: 0x000AB950
		public bool FeatureSetPurchasedFeatureName_Visible
		{
			get
			{
				short num = (short)37686537;
				short num2 = num;
				num = (short)475729161;
				switch (num2 == num)
				{
				}
				num = (short)2009792513;
				if (num != 0)
				{
				}
				num = (short)2118057984;
				if (num != 0)
				{
				}
				num = (short)46137344;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x000AD7FC File Offset: 0x000AB9FC
		public bool FeatureSetPurchasedFeatureName_Editable
		{
			get
			{
				short num = (short)1462472463;
				short num2 = num;
				num = (short)331058959;
				switch (num2 == num)
				{
				}
				num = (short)1063059456;
				if (num != 0)
				{
				}
				num = (short)1687027713;
				if (num != 0)
				{
				}
				num = (short)513540096;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x000AD8AC File Offset: 0x000ABAAC
		public string FeatureSetPurchasedFeatureName_UILabel
		{
			get
			{
				short num = (short)2098856090;
				short num2 = num;
				num = (short)261030042;
				switch (num2 == num)
				{
				}
				num = (short)1869217793;
				if (num != 0)
				{
				}
				num = (short)1761411072;
				if (num != 0)
				{
				}
				num = (short)1902968832;
				short num3 = num;
				return this.a.UIName;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x000AD960 File Offset: 0x000ABB60
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000ADA14 File Offset: 0x000ABC14
		public string FeatureSetEnabledInUsedFlashcodeValue
		{
			get
			{
				short num = (short)1273244060;
				short num2 = num;
				num = (short)953166236;
				switch (num2 == num)
				{
				}
				num = (short)433848321;
				if (num != 0)
				{
				}
				num = (short)768606208;
				if (num != 0)
				{
				}
				num = (short)811204608;
				short num3 = num;
				return this.b.Value;
			}
			set
			{
				short num = (short)2052538232;
				short num2 = num;
				num = (short)1023426424;
				switch (num2 == num)
				{
				}
				num = (short)1271922689;
				if (num != 0)
				{
				}
				num = (short)1546649600;
				if (num != 0)
				{
				}
				num = (short)1551695872;
				short num3 = num;
				this.b.Value = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x000ADACC File Offset: 0x000ABCCC
		public Field FeatureSetEnabledInUsedFlashcode
		{
			get
			{
				short num = (short)203384735;
				short num2 = num;
				num = (short)1452566431;
				switch (num2 == num)
				{
				}
				num = (short)658374657;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				num = (short)383647744;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x000ADB7C File Offset: 0x000ABD7C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x000ADC30 File Offset: 0x000ABE30
		public string FeatureSetEnabledInUsedFlashcode_UIValue
		{
			get
			{
				short num = (short)1632811556;
				short num2 = num;
				num = (short)1331149348;
				switch (num2 == num)
				{
				}
				num = (short)1539047424;
				if (num != 0)
				{
				}
				num = (short)450297857;
				if (num != 0)
				{
				}
				num = (short)654835712;
				short num3 = num;
				return this.b.Value;
			}
			set
			{
				short num = (short)886907560;
				short num2 = num;
				num = (short)552149672;
				switch (num2 == num)
				{
				}
				num = (short)230817793;
				if (num != 0)
				{
				}
				num = (short)908001280;
				if (num != 0)
				{
				}
				num = (short)2042363904;
				short num3 = num;
				this.b.Value = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000ADCE4 File Offset: 0x000ABEE4
		public bool FeatureSetEnabledInUsedFlashcode_Applicable
		{
			get
			{
				short num = (short)1170943724;
				short num2 = num;
				num = (short)1423191788;
				switch (num2 == num)
				{
				}
				num = (short)677904384;
				if (num != 0)
				{
				}
				num = (short)1281490945;
				if (num != 0)
				{
				}
				num = (short)91684864;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000ADD90 File Offset: 0x000ABF90
		public bool FeatureSetEnabledInUsedFlashcode_Valid
		{
			get
			{
				short num = (short)644153344;
				short num2 = num;
				num = (short)582993658;
				short num3 = num;
				num = (short)264750842;
				switch (num3 == num)
				{
				}
				num = (short)1926037504;
				if (num != 0)
				{
				}
				num = (short)405274625;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000ADE3C File Offset: 0x000AC03C
		public bool FeatureSetEnabledInUsedFlashcode_Visible
		{
			get
			{
				short num = (short)459210752;
				short num2 = num;
				num = (short)434044929;
				if (num != 0)
				{
				}
				num = (short)2012799103;
				short num3 = num;
				num = (short)1573511295;
				switch (num3 == num)
				{
				}
				num = (short)1632763904;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000ADEEC File Offset: 0x000AC0EC
		public bool FeatureSetEnabledInUsedFlashcode_Editable
		{
			get
			{
				short num = (short)1238171648;
				short num2 = num;
				num = (short)1396027286;
				short num3 = num;
				num = (short)909160342;
				switch (num3 == num)
				{
				}
				num = (short)1428029441;
				if (num != 0)
				{
				}
				num = (short)1284440064;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000ADF98 File Offset: 0x000AC198
		public string FeatureSetEnabledInUsedFlashcode_UILabel
		{
			get
			{
				short num = (short)1997864960;
				short num2 = num;
				num = (short)1073311177;
				short num3 = num;
				num = (short)1415605705;
				switch (num3 == num)
				{
				}
				num = (short)1515651073;
				if (num != 0)
				{
				}
				num = (short)120717312;
				if (num != 0)
				{
				}
				return this.b.UIName;
			}
		}

		// Token: 0x040003DA RID: 986
		private Field a;

		// Token: 0x040003DB RID: 987
		private Field b;
	}
}
