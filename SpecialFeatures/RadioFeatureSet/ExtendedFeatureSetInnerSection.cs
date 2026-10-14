using System;
using System.Runtime.CompilerServices;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000077 RID: 119
	public sealed class ExtendedFeatureSetInnerSection : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x00002B8F File Offset: 0x00000D8F
		internal ExtendedFeatureSetInnerSection(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.Init();
			this.a();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000AB588 File Offset: 0x000A9788
		private void a()
		{
			short num = (short)859417651;
			short num2 = num;
			num = (short)1881517107;
			switch (num2 == num)
			{
			}
			num = (short)1012989953;
			if (num != 0)
			{
			}
			num = (short)1910046720;
			if (num != 0)
			{
			}
			num = (short)62652416;
			short num3 = num;
			this.c.Value = global::CommonResources.AppResources.N_A;
			this.d.Value = global::CommonResources.AppResources.N_A;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000AB650 File Offset: 0x000A9850
		public override void Init()
		{
			int a_ = 18;
			short num = (short)390108458;
			short num2 = num;
			num = (short)854562090;
			switch (num2 == num)
			{
			}
			num = (short)685375489;
			if (num != 0)
			{
			}
			num = (short)1544093696;
			if (num != 0)
			{
			}
			num = (short)150798336;
			short num3 = num;
			this.c = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Extended_Feature_Name, true);
			this.d = new global::SpecialFeatures.Flashport.Field(global::CommonResources.AppResources.Enabled_Id, true);
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킔ﺚﮞ쒠잢슦좨\udfaa\ud8ac\uddae풰킴쎶", a_);
			base.Id = 34;
			base.UIName = global::CommonResources.AppResources.Extended_Feature_Set;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000AB748 File Offset: 0x000A9948
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000AB7F8 File Offset: 0x000A99F8
		public bool ExtendedFeatureSetEnabled_boolValue
		{
			get
			{
				short num = (short)911556211;
				short num2 = num;
				num = (short)1926184563;
				switch (num2 == num)
				{
				}
				num = (short)835321857;
				if (num != 0)
				{
				}
				num = (short)624033792;
				if (num != 0)
				{
				}
				num = (short)394592256;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)834087247;
				short num2 = num;
				num = (short)461842767;
				switch (num2 == num)
				{
				}
				num = (short)1244856321;
				if (num != 0)
				{
				}
				num = (short)1870200832;
				if (num != 0)
				{
				}
				num = (short)1267990528;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000AB958 File Offset: 0x000A9B58
		internal bool IsUseforPermanentExcised
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)159776769;
				if (num != 0)
				{
				}
				num = (short)179625378;
				short num2 = num;
				num = (short)1959255458;
				switch (num2 == num)
				{
				}
				num = (short)1162805248;
				if (num != 0)
				{
				}
				num = (short)1665466368;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)13106486;
				short num2 = num;
				num = (short)1491926326;
				switch (num2 == num)
				{
				}
				num = (short)244383745;
				if (num != 0)
				{
				}
				num = (short)1956118528;
				if (num != 0)
				{
				}
				num = (short)2107113472;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000ABA08 File Offset: 0x000A9C08
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000ABAC0 File Offset: 0x000A9CC0
		public string ExtendedFeatureSetFeatureNameValue
		{
			get
			{
				short num = (short)1809580394;
				short num2 = num;
				num = (short)643301738;
				switch (num2 == num)
				{
				}
				num = (short)1743650816;
				if (num != 0)
				{
				}
				num = (short)709099521;
				if (num != 0)
				{
				}
				num = (short)352845824;
				short num3 = num;
				return this.c.Value;
			}
			set
			{
				short num = (short)1090893518;
				short num2 = num;
				num = (short)89962190;
				switch (num2 == num)
				{
				}
				num = (short)1466433536;
				if (num != 0)
				{
				}
				num = (short)297140225;
				if (num != 0)
				{
				}
				num = (short)2035875840;
				short num3 = num;
				this.c.Value = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000ABB78 File Offset: 0x000A9D78
		public global::SpecialFeatures.Flashport.Field ExtendedFeatureSetFeatureName
		{
			get
			{
				short num = (short)233309939;
				short num2 = num;
				num = (short)1639909107;
				switch (num2 == num)
				{
				}
				num = (short)2135031808;
				if (num != 0)
				{
				}
				num = (short)211484673;
				if (num != 0)
				{
				}
				num = (short)316669952;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000ABC28 File Offset: 0x000A9E28
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x000ABCDC File Offset: 0x000A9EDC
		public string ExtendedFeatureSetFeatureName_UIValue
		{
			get
			{
				short num = (short)606110289;
				short num2 = num;
				num = (short)1181778513;
				switch (num2 == num)
				{
				}
				num = (short)62259201;
				if (num != 0)
				{
				}
				num = (short)1983643648;
				if (num != 0)
				{
				}
				num = (short)139526144;
				short num3 = num;
				return this.c.Value;
			}
			set
			{
				short num = (short)1716628414;
				short num2 = num;
				num = (short)28486590;
				switch (num2 == num)
				{
				}
				num = (short)1738932225;
				if (num != 0)
				{
				}
				num = (short)842137600;
				if (num != 0)
				{
				}
				num = (short)311427072;
				short num3 = num;
				this.c.Value = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000ABD90 File Offset: 0x000A9F90
		public bool ExtendedFeatureSetFeatureName_Applicable
		{
			get
			{
				short num = (short)2006651841;
				short num2 = num;
				num = (short)693375937;
				switch (num2 == num)
				{
				}
				num = (short)743309312;
				if (num != 0)
				{
				}
				num = (short)372834305;
				if (num != 0)
				{
				}
				num = (short)469762048;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000ABE38 File Offset: 0x000AA038
		public bool ExtendedFeatureSetFeatureName_Valid
		{
			get
			{
				short num = (short)679384205;
				short num2 = num;
				num = (short)1019122829;
				switch (num2 == num)
				{
				}
				num = (short)2097152001;
				if (num != 0)
				{
				}
				num = (short)1929248768;
				if (num != 0)
				{
				}
				num = (short)431226880;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000ABEE0 File Offset: 0x000AA0E0
		public bool ExtendedFeatureSetFeatureName_Visible
		{
			get
			{
				short num = (short)278755710;
				short num2 = num;
				num = (short)287209854;
				switch (num2 == num)
				{
				}
				num = (short)24182785;
				if (num != 0)
				{
				}
				num = (short)538181632;
				if (num != 0)
				{
				}
				num = (short)1370357760;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000ABF8C File Offset: 0x000AA18C
		public bool ExtendedFeatureSetFeatureName_Editable
		{
			get
			{
				short num = (short)999751681;
				if (num != 0)
				{
				}
				num = (short)680330313;
				short num2 = num;
				num = (short)1442579529;
				switch (num2 == num)
				{
				}
				num = (short)1153892352;
				if (num != 0)
				{
				}
				num = (short)785383424;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000AC034 File Offset: 0x000AA234
		internal string ExtendedFeatureSetFeatureName_UILabel
		{
			get
			{
				short num = (short)1871868739;
				short num2 = num;
				num = (short)1114075971;
				switch (num2 == num)
				{
				}
				num = (short)1453916160;
				if (num != 0)
				{
				}
				num = (short)1170669569;
				if (num != 0)
				{
				}
				num = (short)1918500864;
				short num3 = num;
				return this.c.UIName;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000AC0E8 File Offset: 0x000AA2E8
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x000AC2C4 File Offset: 0x000AA4C4
		public string ExtendedFeatureSetEnabledValue
		{
			get
			{
				for (;;)
				{
					IL_00:
					short num = (short)400293889;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1BF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_41;
							}
							continue;
						case 2:
							goto IL_B4;
						case 3:
							goto IL_87;
						case 4:
							this.d.Value = global::CommonResources.AppResources.Yes_Id;
							num = (short)1953234946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)1950941184;
							short num3 = num;
							num = (short)153812998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							num = (short)1989518662;
							short num4 = num;
							num = (short)299017542;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1395326977;
								if (num != 0)
								{
								}
								num = (short)1901461504;
								if (num != 0)
								{
								}
								if (this.ExtendedFeatureSetEnabled_boolValue)
								{
									num = (short)21626884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								this.d.Value = global::CommonResources.AppResources.No_Id;
								num = (short)305463299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_41:
						if (!this.IsUseforPermanentExcised)
						{
							num = (short)1478033413;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							this.d.Value = global::CommonResources.AppResources.Permanently_Enabled;
							num = (short)60882944;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
				}
				IL_87:
				IL_B4:
				IL_1BF:
				return this.d.Value;
			}
			set
			{
				short num = (short)299292649;
				short num2 = num;
				num = (short)573298665;
				switch (num2 == num)
				{
				}
				num = (short)108134400;
				if (num != 0)
				{
				}
				num = (short)1000341505;
				if (num != 0)
				{
				}
				num = (short)750977024;
				short num3 = num;
				this.d.Value = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000AC378 File Offset: 0x000AA578
		public global::SpecialFeatures.Flashport.Field ExtendedFeatureSetEnabled
		{
			get
			{
				short num = (short)254732883;
				short num2 = num;
				num = (short)1971382867;
				switch (num2 == num)
				{
				}
				num = (short)352452608;
				if (num != 0)
				{
				}
				num = (short)900726785;
				if (num != 0)
				{
				}
				num = (short)2115305472;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000AC42C File Offset: 0x000AA62C
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000AC4E0 File Offset: 0x000AA6E0
		public string ExtendedFeatureSetEnabled_UIValue
		{
			get
			{
				short num = (short)2098937419;
				short num2 = num;
				num = (short)1629699659;
				switch (num2 == num)
				{
				}
				num = (short)1267859457;
				if (num != 0)
				{
				}
				num = (short)372178944;
				if (num != 0)
				{
				}
				num = (short)1597177856;
				short num3 = num;
				return this.d.Value;
			}
			set
			{
				short num = (short)868611618;
				short num2 = num;
				num = (short)448263714;
				switch (num2 == num)
				{
				}
				num = (short)1766850560;
				if (num != 0)
				{
				}
				num = (short)370802689;
				if (num != 0)
				{
				}
				num = (short)1022296064;
				short num3 = num;
				this.d.Value = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000AC598 File Offset: 0x000AA798
		public bool ExtendedFeatureSetEnabled_Applicable
		{
			get
			{
				short num = (short)1313209500;
				short num2 = num;
				num = (short)623967388;
				switch (num2 == num)
				{
				}
				num = (short)491257856;
				if (num != 0)
				{
				}
				num = (short)72024065;
				if (num != 0)
				{
				}
				num = (short)1856176128;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000AC644 File Offset: 0x000AA844
		public bool ExtendedFeatureSetEnabled_Valid
		{
			get
			{
				short num = (short)225978209;
				short num2 = num;
				num = (short)1359095649;
				switch (num2 == num)
				{
				}
				num = (short)265486337;
				if (num != 0)
				{
				}
				num = (short)1071382528;
				if (num != 0)
				{
				}
				num = (short)628359168;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000AC6F0 File Offset: 0x000AA8F0
		public bool ExtendedFeatureSetEnabled_Visible
		{
			get
			{
				short num = (short)651139911;
				short num2 = num;
				num = (short)2103745351;
				switch (num2 == num)
				{
				}
				num = (short)1919483905;
				if (num != 0)
				{
				}
				num = (short)5898240;
				if (num != 0)
				{
				}
				num = (short)701562880;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000AC79C File Offset: 0x000AA99C
		public bool ExtendedFeatureSetEnabled_Editable
		{
			get
			{
				short num = (short)1358880447;
				short num2 = num;
				num = (short)1013046975;
				switch (num2 == num)
				{
				}
				num = (short)1615724544;
				if (num != 0)
				{
				}
				num = (short)33619969;
				if (num != 0)
				{
				}
				num = (short)1835204608;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000AC844 File Offset: 0x000AAA44
		internal string ExtendedFeatureSetEnabled_UILabel
		{
			get
			{
				short num = (short)1835491316;
				short num2 = num;
				num = (short)1856593908;
				switch (num2 == num)
				{
				}
				num = (short)93192192;
				if (num != 0)
				{
				}
				num = (short)1318322177;
				if (num != 0)
				{
				}
				num = (short)1883766784;
				short num3 = num;
				return this.d.UIName;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000AC8F8 File Offset: 0x000AAAF8
		public bool ExtendedFeature_Visible
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)1883373570;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)938082307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return true;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_34;
							}
							continue;
						case 3:
							if (this.ExtendedFeatureSetEnabled_boolValue)
							{
								num = (short)247398401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7B;
						}
						IL_34:
						num = (short)2012479489;
						if (num != 0)
						{
						}
						if (!this.IsUseforPermanentExcised)
						{
							return true;
						}
						num = (short)1205993472;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7B:
					num = (short)154009600;
					short num3 = num;
					num = (short)315767178;
					short num4 = num;
					num = (short)515520906;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D9;
					}
				}
				IL_D9:
				num = (short)1213005824;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x040003D5 RID: 981
		private bool a;

		// Token: 0x040003D6 RID: 982
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x040003D7 RID: 983
		private global::SpecialFeatures.Flashport.Field c;

		// Token: 0x040003D8 RID: 984
		private global::SpecialFeatures.Flashport.Field d;
	}
}
