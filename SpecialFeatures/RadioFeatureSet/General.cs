using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007E RID: 126
	public sealed class General : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x00002BFE File Offset: 0x00000DFE
		internal General(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000AE4AC File Offset: 0x000AC6AC
		private void a()
		{
			int a_ = 10;
			short num = (short)949354496;
			short num2 = num;
			num = (short)239063698;
			short num3 = num;
			num = (short)195547794;
			switch (num3 == num)
			{
			}
			num = (short)918552577;
			if (num != 0)
			{
			}
			num = (short)264896512;
			if (num != 0)
			{
			}
			this.a.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌뾎ꆐꎒꖔꞖ뒘ꮚ궜꾞醠鎢閤誦馨", a_);
			this.b.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌뾎ꆐꎒꖔꞖ뒘ꮚ궜꾞醠鎢閤誦馨", a_);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000AE594 File Offset: 0x000AC794
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1954152448;
			short num2 = num;
			num = (short)1653932033;
			if (num != 0)
			{
			}
			num = (short)1057258361;
			short num3 = num;
			num = (short)14646137;
			switch (num3 == num)
			{
			}
			num = (short)432078848;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Purchased_FLASHcode, true);
			this.b = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Used_FLASHcode, true);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햑ﶗﶛ", a_);
			base.Id = 31;
			base.UIName = global::CommonResources.AppResources.General_Id;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000AE68C File Offset: 0x000AC88C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x000AE744 File Offset: 0x000AC944
		public string FeatureSetGeneralPurchasedFLASHcodeValue
		{
			get
			{
				short num = (short)796590080;
				short num2 = num;
				num = (short)1860556433;
				short num3 = num;
				num = (short)1789646481;
				switch (num3 == num)
				{
				}
				num = (short)2087387137;
				if (num != 0)
				{
				}
				num = (short)596049920;
				if (num != 0)
				{
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)1975189504;
				short num2 = num;
				num = (short)467644991;
				short num3 = num;
				num = (short)1178907199;
				switch (num3 == num)
				{
				}
				num = (short)2117664769;
				if (num != 0)
				{
				}
				num = (short)1681326080;
				if (num != 0)
				{
				}
				this.a.Value = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000AE7FC File Offset: 0x000AC9FC
		public global::SpecialFeatures.Flashport.Field FeatureSetGeneralPurchasedFLASHcode
		{
			get
			{
				short num = (short)527171584;
				short num2 = num;
				num = (short)1876940804;
				short num3 = num;
				num = (short)2043664388;
				switch (num3 == num)
				{
				}
				num = (short)1419968512;
				if (num != 0)
				{
				}
				num = (short)1195180033;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000AE8AC File Offset: 0x000ACAAC
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x000AE960 File Offset: 0x000ACB60
		public string FeatureSetGeneralPurchasedFLASHcode_UIValue
		{
			get
			{
				short num = (short)228196352;
				short num2 = num;
				num = (short)1422073621;
				short num3 = num;
				num = (short)479141653;
				switch (num3 == num)
				{
				}
				num = (short)1738276864;
				if (num != 0)
				{
				}
				num = (short)626917377;
				if (num != 0)
				{
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)1004863488;
				short num2 = num;
				num = (short)53730006;
				short num3 = num;
				num = (short)855628502;
				switch (num3 == num)
				{
				}
				num = (short)1632829441;
				if (num != 0)
				{
				}
				num = (short)1991114752;
				if (num != 0)
				{
				}
				this.a.Value = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000AEA14 File Offset: 0x000ACC14
		public bool FeatureSetGeneralPurchasedFLASHcode_Applicable
		{
			get
			{
				short num = (short)274202624;
				short num2 = num;
				num = (short)1940084153;
				short num3 = num;
				num = (short)1065440697;
				switch (num3 == num)
				{
				}
				num = (short)474415105;
				if (num != 0)
				{
				}
				num = (short)1629749248;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		public bool FeatureSetGeneralPurchasedFLASHcode_Valid
		{
			get
			{
				short num = (short)171180032;
				short num2 = num;
				num = (short)899665330;
				short num3 = num;
				num = (short)1985465778;
				switch (num3 == num)
				{
				}
				num = (short)738983937;
				if (num != 0)
				{
				}
				num = (short)983564288;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000AEB6C File Offset: 0x000ACD6C
		public bool FeatureSetGeneralPurchasedFLASHcode_Visible
		{
			get
			{
				short num = (short)94765056;
				short num2 = num;
				num = (short)1903755265;
				if (num != 0)
				{
				}
				num = (short)1787019958;
				short num3 = num;
				num = (short)1035584182;
				switch (num3 == num)
				{
				}
				num = (short)735903744;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000AEC18 File Offset: 0x000ACE18
		public bool FeatureSetGeneralPurchasedFLASHcode_Editable
		{
			get
			{
				short num = (short)2083520512;
				short num2 = num;
				num = (short)1836908545;
				if (num != 0)
				{
				}
				num = (short)472809276;
				short num3 = num;
				num = (short)2059108156;
				switch (num3 == num)
				{
				}
				num = (short)92274688;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000AECC4 File Offset: 0x000ACEC4
		public string FeatureSetGeneralPurchasedFLASHcode_UILabel
		{
			get
			{
				short num = (short)1860632576;
				short num2 = num;
				num = (short)532495957;
				short num3 = num;
				num = (short)975584853;
				switch (num3 == num)
				{
				}
				num = (short)1699282944;
				if (num != 0)
				{
				}
				num = (short)1576468481;
				if (num != 0)
				{
				}
				return this.a.UIName;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x000AED7C File Offset: 0x000ACF7C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x000AEE30 File Offset: 0x000AD030
		public string FeatureSetGeneralUsedFLASHcodeValue
		{
			get
			{
				short num = (short)1448476672;
				short num2 = num;
				num = (short)1588496685;
				short num3 = num;
				num = (short)1937606957;
				switch (num3 == num)
				{
				}
				num = (short)971505665;
				if (num != 0)
				{
				}
				num = (short)943325184;
				if (num != 0)
				{
				}
				return this.b.Value;
			}
			set
			{
				short num = (short)566165504;
				short num2 = num;
				num = (short)1251999745;
				if (num != 0)
				{
				}
				num = (short)794228516;
				short num3 = num;
				num = (short)1275000612;
				switch (num3 == num)
				{
				}
				num = (short)407961600;
				if (num != 0)
				{
				}
				this.b.Value = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000AEEE8 File Offset: 0x000AD0E8
		public global::SpecialFeatures.Flashport.Field FeatureSetGeneralUsedFLASHcode
		{
			get
			{
				short num = (short)774242304;
				short num2 = num;
				num = (short)1147322654;
				short num3 = num;
				num = (short)1513406750;
				switch (num3 == num)
				{
				}
				num = (short)1455292416;
				if (num != 0)
				{
				}
				num = (short)555679745;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000AEF9C File Offset: 0x000AD19C
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x000AF050 File Offset: 0x000AD250
		public string FeatureSetGeneralUsedFLASHcode_UIValue
		{
			get
			{
				short num = (short)1074987008;
				short num2 = num;
				num = (short)193189991;
				short num3 = num;
				num = (short)1878644839;
				switch (num3 == num)
				{
				}
				num = (short)156172289;
				if (num != 0)
				{
				}
				num = (short)1887567872;
				if (num != 0)
				{
				}
				return this.b.Value;
			}
			set
			{
				short num = (short)1528758272;
				short num2 = num;
				num = (short)880676623;
				short num3 = num;
				num = (short)1724518159;
				switch (num3 == num)
				{
				}
				num = (short)420872193;
				if (num != 0)
				{
				}
				num = (short)687341568;
				if (num != 0)
				{
				}
				this.b.Value = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000AF108 File Offset: 0x000AD308
		public bool FeatureSetGeneralUsedFLASHcode_Applicable
		{
			get
			{
				short num = (short)1968308224;
				short num2 = num;
				num = (short)292421633;
				if (num != 0)
				{
				}
				num = (short)979144253;
				short num3 = num;
				num = (short)1986301501;
				switch (num3 == num)
				{
				}
				num = (short)1172176896;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000AF1B0 File Offset: 0x000AD3B0
		public bool FeatureSetGeneralUsedFLASHcode_Valid
		{
			get
			{
				short num = (short)1823080448;
				short num2 = num;
				num = (short)946864129;
				if (num != 0)
				{
				}
				num = (short)902451119;
				short num3 = num;
				num = (short)257183663;
				switch (num3 == num)
				{
				}
				num = (short)1929641984;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000AF260 File Offset: 0x000AD460
		public bool FeatureSetGeneralUsedFLASHcode_Visible
		{
			get
			{
				short num = (short)2063728640;
				short num2 = num;
				num = (short)1912233818;
				short num3 = num;
				num = (short)785801050;
				switch (num3 == num)
				{
				}
				num = (short)171900928;
				if (num != 0)
				{
				}
				num = (short)2144468993;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000AF30C File Offset: 0x000AD50C
		public bool FeatureSetGeneralUsedFLASHcode_Editable
		{
			get
			{
				short num = (short)749862912;
				short num2 = num;
				num = (short)84807662;
				short num3 = num;
				num = (short)1156517870;
				switch (num3 == num)
				{
				}
				num = (short)1532035072;
				if (num != 0)
				{
				}
				num = (short)1744699393;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000AF3BC File Offset: 0x000AD5BC
		public string FeatureSetGeneralUsedFLASHcode_UILabel
		{
			get
			{
				short num = (short)636944384;
				short num2 = num;
				num = (short)672464897;
				if (num != 0)
				{
				}
				num = (short)270659423;
				short num3 = num;
				num = (short)1373302623;
				switch (num3 == num)
				{
				}
				num = (short)1874001920;
				if (num != 0)
				{
				}
				return this.b.UIName;
			}
		}

		// Token: 0x040003E3 RID: 995
		private global::SpecialFeatures.Flashport.Field a;

		// Token: 0x040003E4 RID: 996
		private global::SpecialFeatures.Flashport.Field b;
	}
}
