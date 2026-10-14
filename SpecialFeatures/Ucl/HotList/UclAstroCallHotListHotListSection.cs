using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D3 RID: 467
	[global::System.Serializable]
	public sealed class UclAstroCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x00003A16 File Offset: 0x00001C16
		internal UclAstroCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.astroCallHotListRecset = new global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset();
			base.EmbeddedRecset = this.astroCallHotListRecset;
			this.astroCallHotListRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x001F2C40 File Offset: 0x001F0E40
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x001F2CF0 File Offset: 0x001F0EF0
		public string UclAstroCnvHotList_HotListAlias_A00042Value
		{
			get
			{
				short num = (short)1909981185;
				if (num != 0)
				{
				}
				num = (short)138999214;
				short num2 = num;
				num = (short)968947118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034171904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379715584;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.Value;
			}
			set
			{
				short num = (short)620393137;
				short num2 = num;
				num = (short)1847095985;
				switch (num2 == num)
				{
				}
				num = (short)1619132416;
				short num3 = num;
				num = (short)728694785;
				if (num != 0)
				{
				}
				num = (short)1231683584;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.Value = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x001F2DA4 File Offset: 0x001F0FA4
		public global::AcpBusinessLayer.AcpKeyField UclAstroCnvHotList_HotListAlias_A00042Object
		{
			get
			{
				short num = (short)1733850753;
				short num2 = num;
				num = (short)413628033;
				switch (num2 == num)
				{
				}
				num = (short)1230766080;
				short num3 = num;
				num = (short)1992556544;
				if (num != 0)
				{
				}
				num = (short)1657733121;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x001F2E54 File Offset: 0x001F1054
		internal string UclAstroCnvHotList_HotListAlias_A00042_UILabel
		{
			get
			{
				short num = (short)1347436494;
				short num2 = num;
				num = (short)1209024462;
				switch (num2 == num)
				{
				}
				num = (short)412090368;
				short num3 = num;
				num = (short)1375076353;
				if (num != 0)
				{
				}
				num = (short)1380057088;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.UIName;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x001F2F0C File Offset: 0x001F110C
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x001F2FC0 File Offset: 0x001F11C0
		public bool UclAstroCnvHotList_HotListAlias_A00042_Applicable
		{
			get
			{
				short num = (short)1611660655;
				short num2 = num;
				num = (short)2062089583;
				switch (num2 == num)
				{
				}
				num = (short)1642135552;
				short num3 = num;
				num = (short)1441136641;
				if (num != 0)
				{
				}
				num = (short)1543372800;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.Applicable;
			}
			set
			{
				short num = (short)979737300;
				short num2 = num;
				num = (short)1602067156;
				switch (num2 == num)
				{
				}
				num = (short)2100297728;
				short num3 = num;
				num = (short)96010240;
				if (num != 0)
				{
				}
				num = (short)595656705;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.Applicable = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x001F3074 File Offset: 0x001F1274
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x001F3124 File Offset: 0x001F1324
		public bool UclAstroCnvHotList_HotListAlias_A00042_Editable
		{
			get
			{
				short num = (short)925958931;
				short num2 = num;
				num = (short)380568339;
				switch (num2 == num)
				{
				}
				num = (short)1527906304;
				short num3 = num;
				num = (short)2028011521;
				if (num != 0)
				{
				}
				num = (short)1711079424;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.Editable;
			}
			set
			{
				short num = (short)239891277;
				short num2 = num;
				num = (short)1022653261;
				switch (num2 == num)
				{
				}
				num = (short)884998144;
				short num3 = num;
				num = (short)1183055872;
				if (num != 0)
				{
				}
				num = (short)1588133889;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.Editable = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x001F31D8 File Offset: 0x001F13D8
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x001F328C File Offset: 0x001F148C
		public bool UclAstroCnvHotList_HotListAlias_A00042_Visible
		{
			get
			{
				short num = (short)416209132;
				short num2 = num;
				num = (short)54515948;
				switch (num2 == num)
				{
				}
				num = (short)2064973824;
				short num3 = num;
				num = (short)981860353;
				if (num != 0)
				{
				}
				num = (short)2046689280;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.Visible;
			}
			set
			{
				short num = (short)2071967228;
				short num2 = num;
				num = (short)1164686844;
				switch (num2 == num)
				{
				}
				num = (short)719323136;
				short num3 = num;
				num = (short)982974465;
				if (num != 0)
				{
				}
				num = (short)537067520;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.Visible = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x001F3344 File Offset: 0x001F1544
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x001F33F8 File Offset: 0x001F15F8
		internal bool UclAstroCnvHotList_HotListAlias_A00042_HiddenStatic
		{
			get
			{
				short num = (short)701792674;
				short num2 = num;
				num = (short)87916962;
				switch (num2 == num)
				{
				}
				num = (short)232718336;
				short num3 = num;
				num = (short)1410990081;
				if (num != 0)
				{
				}
				num = (short)718536704;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.HiddenStatic;
			}
			set
			{
				short num = (short)398445928;
				short num2 = num;
				num = (short)1930874216;
				switch (num2 == num)
				{
				}
				num = (short)375848960;
				short num3 = num;
				num = (short)1954545664;
				if (num != 0)
				{
				}
				num = (short)1752432641;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.HiddenStatic = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x001F34AC File Offset: 0x001F16AC
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x001F3560 File Offset: 0x001F1760
		public bool UclAstroCnvHotList_HotListAlias_A00042_Valid
		{
			get
			{
				short num = (short)1311703040;
				short num2 = num;
				num = (short)1716362253;
				short num3 = num;
				num = (short)1574804493;
				switch (num3 == num)
				{
				}
				num = (short)808714241;
				if (num != 0)
				{
				}
				num = (short)1495990272;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042.Valid;
			}
			set
			{
				short num = (short)1164050432;
				short num2 = num;
				num = (short)1596281004;
				short num3 = num;
				num = (short)1987596460;
				switch (num3 == num)
				{
				}
				num = (short)3866625;
				if (num != 0)
				{
				}
				num = (short)2008416256;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042.Valid = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x001F3614 File Offset: 0x001F1814
		public bool UclAstroCnvHotList_HotListAlias_A00042_HasDiffs
		{
			get
			{
				short num = (short)1102184448;
				short num2 = num;
				num = (short)957440467;
				short num3 = num;
				num = (short)682058195;
				switch (num3 == num)
				{
				}
				num = (short)931659777;
				if (num != 0)
				{
				}
				num = (short)1432551424;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_HotListAlias_A00042._HasDiffs;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x001F36C8 File Offset: 0x001F18C8
		public global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset AstroCallHotListRecset
		{
			get
			{
				short num = (short)1703346176;
				short num2 = num;
				num = (short)230456007;
				short num3 = num;
				num = (short)421362375;
				switch (num3 == num)
				{
				}
				num = (short)605945857;
				if (num != 0)
				{
				}
				num = (short)301203456;
				if (num != 0)
				{
				}
				return this.astroCallHotListRecset;
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x001F3778 File Offset: 0x001F1978
		public override void PopulateReferences()
		{
			short num = (short)1658650624;
			short num2 = num;
			num = (short)1834653415;
			short num3 = num;
			num = (short)270702311;
			switch (num3 == num)
			{
			}
			num = (short)597557249;
			if (num != 0)
			{
			}
			num = (short)276168704;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x001F3820 File Offset: 0x001F1A20
		public override void DropReferences()
		{
			short num = (short)1231224832;
			short num2 = num;
			num = (short)123284717;
			short num3 = num;
			num = (short)538324205;
			switch (num3 == num)
			{
			}
			num = (short)374079488;
			if (num != 0)
			{
			}
			num = (short)1079377921;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x001F38CC File Offset: 0x001F1ACC
		public override void SetupDependencies()
		{
			short num = (short)1385889792;
			short num2 = num;
			num = (short)1055106099;
			short num3 = num;
			num = (short)192324659;
			switch (num3 == num)
			{
			}
			num = (short)477495297;
			if (num != 0)
			{
			}
			num = (short)1158283264;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x001F3974 File Offset: 0x001F1B74
		public override void SetConstraints()
		{
			short num = (short)1950613504;
			short num2 = num;
			num = (short)650217316;
			short num3 = num;
			num = (short)153061220;
			switch (num3 == num)
			{
			}
			num = (short)646053889;
			if (num != 0)
			{
			}
			num = (short)1409744896;
			if (num != 0)
			{
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x001F3A1C File Offset: 0x001F1C1C
		public override void Init()
		{
			int a_ = 9;
			short num = (short)13500416;
			short num2 = num;
			num = (short)2106800440;
			short num3 = num;
			num = (short)189675832;
			switch (num3 == num)
			{
			}
			num = (short)38600705;
			if (num != 0)
			{
			}
			num = (short)979894272;
			if (num != 0)
			{
			}
			this.uclAstroCnvHotList_HotListAlias_A00042 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98bﲏ펑\udf9b횟쮣튥쎩\udfab\udaad缾\udbb3습펹쾻쪽膿껁귃Ʂ믇闉跋ﻍ", a_), global::CommonResources.AppResources.Hot_List_Alias, 14);
			this.uclAstroCnvHotList_HotListAlias_A00042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnvHotList_HotListAlias_A00042.DataTransferOrder = 1;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춋\udd8d쒏삑\udb93뚕\udb97얟첡킣쾥잧쒩춫슭邯缾\udbb3습颷햻춽뒿", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.DataTransferOrder = 1;
			base.Id = 10417;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x001F3B38 File Offset: 0x001F1D38
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1646526464;
			short num2 = num;
			num = (short)1933116185;
			short num3 = num;
			num = (short)835846937;
			switch (num3 == num)
			{
			}
			num = (short)487849985;
			if (num != 0)
			{
			}
			num = (short)1095172096;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x001F3BEC File Offset: 0x001F1DEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1600061442;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)12058624;
					short num3 = num;
					num = (short)1358626820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_E3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					goto IL_6D;
				case 4:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc88캎\uda98힞캠힢캦\udaa8\udfaa\udeb0잲領\udeb6쪸쾺ﲼ펾ꣀꋂ뛄飆裈﯊﷌ￎ", a_)))
					{
						num = (short)1054539779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 5:
					if (producerFields != null)
					{
						num = (short)526450688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 6:
				{
					num = (short)1153936895;
					short num4 = num;
					num = (short)324578815;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						num = (short)1533411328;
						if (num != 0)
						{
						}
						num = (short)1843593221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1566441478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6D:
				num = (short)1966211073;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_HotListAlias_A00042 = new global::AcpBusinessLayer.AcpKeyField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc88캎\uda98힞캠힢캦\udaa8\udfaa\udeb0잲領\udeb6쪸쾺ﲼ펾ꣀꋂ뛄飆裈﯊﷌ￎ", a_), global::CommonResources.AppResources.Hot_List_Alias, 14);
				this.uclAstroCnvHotList_HotListAlias_A00042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.uclAstroCnvHotList_HotListAlias_A00042.DataTransferOrder = 1;
				num = (short)1051131905;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E3:
			IL_1E1:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좈\ud88a\ud98c\udd8e\ude90뎒횔햠쪢쪤즦좨잪趬\udeb0잲閴﮶킸좺즼", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.DataTransferOrder = 1;
			base.Id = 10417;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclAstroCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x001F3E0C File Offset: 0x001F200C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1300955136;
				short num2 = num;
				num = (short)1602038438;
				short num3 = num;
				num = (short)1862937254;
				switch (num3 == num)
				{
				}
				num = (short)1449918465;
				if (num != 0)
				{
				}
				num = (short)484638720;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B99 RID: 2969
		private global::SpecialFeatures.Ucl.HotList.AstroCallHotListRecset astroCallHotListRecset;

		// Token: 0x04000B9A RID: 2970
		private global::AcpBusinessLayer.AcpKeyField uclAstroCnvHotList_HotListAlias_A00042;
	}
}
