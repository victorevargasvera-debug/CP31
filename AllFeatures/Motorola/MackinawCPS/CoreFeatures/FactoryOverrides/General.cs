using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000451 RID: 1105
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060093C7 RID: 37831 RVA: 0x008B4E18 File Offset: 0x008B3018
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x008B4E34 File Offset: 0x008B3034
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x008B4E4C File Offset: 0x008B304C
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1998782464;
			short num2 = num;
			num = (short)1561378993;
			short num3 = num;
			num = (short)1832239281;
			switch (num3 == num)
			{
			}
			num = (short)710672385;
			if (num != 0)
			{
			}
			num = (short)2088960000;
			if (num != 0)
			{
			}
			this.radWideAdvancedFactoryOverrides_A8004 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖飘뿚ꯜ뻞迠胢胤菦꿨諪軬鯮黰臲賴룶迸黺迼跾栀朂怄理嘈䨊㔌㼎ℐ✒", a_), global::CommonResources.AcgResources.ID_FACTORYOVERRIDESENABLE);
			this.radWideAdvancedFactoryOverrides_A8004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideAdvancedFactoryOverrides_A8004.DataTransferOrder = 119;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10005;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x008B4F6C File Offset: 0x008B316C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1972992274;
			short num2 = num;
			num = (short)2047506706;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14B:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뛑ꋓ럕뛗맙맛뫝ꛟ菡蟣鋥蟧飩闫ꇭ蛯韱蛳蓵釷黹駻跽忿䌁㰃㘅㠇㸉", a_)))
				{
					goto IL_1DD;
				}
				num = (short)1390739459;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)211091456;
				if (num != 0)
				{
				}
				num = (short)601030656;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)379256833;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_BB;
					}
					continue;
				case 1:
					num = (short)1956446210;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields != null)
					{
						num = (short)377683973;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DD;
				case 3:
					this.radWideAdvancedFactoryOverrides_A8004 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뛑ꋓ럕뛗맙맛뫝ꛟ菡蟣鋥蟧飩闫ꇭ蛯韱蛳蓵釷黹駻跽忿䌁㰃㘅㠇㸉", a_), global::CommonResources.AcgResources.ID_FACTORYOVERRIDESENABLE);
					this.radWideAdvancedFactoryOverrides_A8004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideAdvancedFactoryOverrides_A8004.DataTransferOrder = 119;
					num = (short)1382154246;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_14B;
				case 5:
				{
					num = (short)524288;
					short num4 = num;
					num = (short)1617625092;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_12E;
				}
				IL_BB:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)697696257;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12E:
			IL_1DD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10005;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x008B5188 File Offset: 0x008B3388
		public override void PopulateReferences()
		{
			short num = (short)1768882176;
			short num2 = num;
			num = (short)647369603;
			short num3 = num;
			num = (short)449450883;
			switch (num3 == num)
			{
			}
			num = (short)1626537985;
			if (num != 0)
			{
			}
			num = (short)1619197952;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x008B5234 File Offset: 0x008B3434
		public override void DropReferences()
		{
			short num = (short)1187119104;
			short num2 = num;
			num = (short)1429929985;
			if (num != 0)
			{
			}
			num = (short)674584992;
			short num3 = num;
			num = (short)781080992;
			switch (num3 == num)
			{
			}
			num = (short)1115881472;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x008B52E0 File Offset: 0x008B34E0
		public override void SetConstraints()
		{
			short num = (short)1915551744;
			short num2 = num;
			num = (short)1403779999;
			short num3 = num;
			num = (short)1023671199;
			switch (num3 == num)
			{
			}
			num = (short)2113142784;
			if (num != 0)
			{
			}
			num = (short)1130037249;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x008B5388 File Offset: 0x008B3588
		public override void SetupDependencies()
		{
			short num = (short)398131200;
			short num2 = num;
			num = (short)6190853;
			short num3 = num;
			num = (short)2085058309;
			switch (num3 == num)
			{
			}
			num = (short)864944129;
			if (num != 0)
			{
			}
			num = (short)713359360;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x060093CF RID: 37839 RVA: 0x008B5434 File Offset: 0x008B3634
		public bool HasDiffs
		{
			get
			{
				short num = (short)1789722624;
				short num2 = num;
				num = (short)711744097;
				short num3 = num;
				num = (short)642144865;
				switch (num3 == num)
				{
				}
				num = (short)1251409921;
				if (num != 0)
				{
				}
				num = (short)615907328;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x060093D0 RID: 37840 RVA: 0x008B54E4 File Offset: 0x008B36E4
		// (set) Token: 0x060093D1 RID: 37841 RVA: 0x008B5598 File Offset: 0x008B3798
		public bool RadWideAdvancedFactoryOverrides_A8004Value
		{
			get
			{
				short num = (short)2122383360;
				short num2 = num;
				num = (short)1389614968;
				short num3 = num;
				num = (short)1162532728;
				switch (num3 == num)
				{
				}
				num = (short)1117323264;
				if (num != 0)
				{
				}
				num = (short)267780097;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Value;
			}
			set
			{
				short num = (short)2029387776;
				short num2 = num;
				num = (short)304592848;
				short num3 = num;
				num = (short)2110830544;
				switch (num3 == num)
				{
				}
				num = (short)316473345;
				if (num != 0)
				{
				}
				num = (short)1927610368;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Value = value;
			}
		}

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x060093D2 RID: 37842 RVA: 0x008B564C File Offset: 0x008B384C
		public global::AcpBusinessLayer.AcpField<bool> RadWideAdvancedFactoryOverrides_A8004
		{
			get
			{
				short num = (short)1054343168;
				short num2 = num;
				num = (short)1757158678;
				short num3 = num;
				num = (short)1031019798;
				switch (num3 == num)
				{
				}
				num = (short)362414081;
				if (num != 0)
				{
				}
				num = (short)881262592;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004;
			}
		}

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x060093D3 RID: 37843 RVA: 0x008B56FC File Offset: 0x008B38FC
		// (set) Token: 0x060093D4 RID: 37844 RVA: 0x008B57B4 File Offset: 0x008B39B4
		public bool RadWideAdvancedFactoryOverrides_A8004_UIValue
		{
			get
			{
				short num = (short)1247870976;
				short num2 = num;
				num = (short)1643816610;
				short num3 = num;
				num = (short)1701750434;
				switch (num3 == num)
				{
				}
				num = (short)240779265;
				if (num != 0)
				{
				}
				num = (short)960823296;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Value;
			}
			set
			{
				short num = (short)821428224;
				short num2 = num;
				num = (short)1720218387;
				short num3 = num;
				num = (short)1533571859;
				switch (num3 == num)
				{
				}
				num = (short)1668677632;
				if (num != 0)
				{
				}
				num = (short)1939144705;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Value = value;
			}
		}

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x060093D5 RID: 37845 RVA: 0x008B5868 File Offset: 0x008B3A68
		// (set) Token: 0x060093D6 RID: 37846 RVA: 0x008B591C File Offset: 0x008B3B1C
		public bool RadWideAdvancedFactoryOverrides_A8004_Applicable
		{
			get
			{
				short num = (short)689307648;
				short num2 = num;
				num = (short)1827341921;
				short num3 = num;
				num = (short)335283809;
				switch (num3 == num)
				{
				}
				num = (short)867893249;
				if (num != 0)
				{
				}
				num = (short)467992576;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Applicable;
			}
			set
			{
				short num = (short)1513750528;
				short num2 = num;
				num = (short)1690993745;
				short num3 = num;
				num = (short)1786610769;
				switch (num3 == num)
				{
				}
				num = (short)1095761921;
				if (num != 0)
				{
				}
				num = (short)1042939904;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Applicable = value;
			}
		}

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x060093D7 RID: 37847 RVA: 0x008B59D0 File Offset: 0x008B3BD0
		// (set) Token: 0x060093D8 RID: 37848 RVA: 0x008B5A84 File Offset: 0x008B3C84
		public bool RadWideAdvancedFactoryOverrides_A8004_Valid
		{
			get
			{
				short num = (short)275185664;
				short num2 = num;
				num = (short)126726290;
				short num3 = num;
				num = (short)1014083730;
				switch (num3 == num)
				{
				}
				num = (short)555024384;
				if (num != 0)
				{
				}
				num = (short)1528954881;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Valid;
			}
			set
			{
				short num = (short)926744576;
				short num2 = num;
				num = (short)222205940;
				short num3 = num;
				num = (short)486971380;
				switch (num3 == num)
				{
				}
				num = (short)2053701633;
				if (num != 0)
				{
				}
				num = (short)1040646144;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Valid = value;
			}
		}

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x060093D9 RID: 37849 RVA: 0x008B5B3C File Offset: 0x008B3D3C
		// (set) Token: 0x060093DA RID: 37850 RVA: 0x008B5BF0 File Offset: 0x008B3DF0
		public bool RadWideAdvancedFactoryOverrides_A8004_Visible
		{
			get
			{
				short num = (short)1403125760;
				short num2 = num;
				num = (short)1423580501;
				short num3 = num;
				num = (short)1274027349;
				switch (num3 == num)
				{
				}
				num = (short)1712783360;
				if (num != 0)
				{
				}
				num = (short)512491521;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Visible;
			}
			set
			{
				short num = (short)985268224;
				short num2 = num;
				num = (short)1719271425;
				if (num != 0)
				{
				}
				num = (short)1649386572;
				short num3 = num;
				num = (short)746300492;
				switch (num3 == num)
				{
				}
				num = (short)851116032;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Visible = value;
			}
		}

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x008B5CA4 File Offset: 0x008B3EA4
		// (set) Token: 0x060093DC RID: 37852 RVA: 0x008B5D58 File Offset: 0x008B3F58
		public bool RadWideAdvancedFactoryOverrides_A8004_Editable
		{
			get
			{
				short num = (short)1858338816;
				short num2 = num;
				num = (short)1933180929;
				if (num != 0)
				{
				}
				num = (short)1126349162;
				short num3 = num;
				num = (short)1196996970;
				switch (num3 == num)
				{
				}
				num = (short)293928960;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.Editable;
			}
			set
			{
				short num = (short)495648768;
				short num2 = num;
				num = (short)1128005633;
				if (num != 0)
				{
				}
				num = (short)54076106;
				short num3 = num;
				num = (short)773071562;
				switch (num3 == num)
				{
				}
				num = (short)1307377664;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.Editable = value;
			}
		}

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x008B5E0C File Offset: 0x008B400C
		internal string RadWideAdvancedFactoryOverrides_A8004_UILabel
		{
			get
			{
				short num = (short)931528704;
				short num2 = num;
				num = (short)333725053;
				short num3 = num;
				num = (short)694697341;
				switch (num3 == num)
				{
				}
				num = (short)1816395777;
				if (num != 0)
				{
				}
				num = (short)984154112;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.UIName;
			}
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x060093DE RID: 37854 RVA: 0x008B5EC0 File Offset: 0x008B40C0
		// (set) Token: 0x060093DF RID: 37855 RVA: 0x008B5F74 File Offset: 0x008B4174
		internal bool RadWideAdvancedFactoryOverrides_A8004_HiddenStatic
		{
			get
			{
				short num = (short)400031744;
				short num2 = num;
				num = (short)196018045;
				short num3 = num;
				num = (short)224984957;
				switch (num3 == num)
				{
				}
				num = (short)896860161;
				if (num != 0)
				{
				}
				num = (short)1351221248;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.HiddenStatic;
			}
			set
			{
				short num = (short)563347456;
				short num2 = num;
				num = (short)1106159648;
				short num3 = num;
				num = (short)2119346208;
				switch (num3 == num)
				{
				}
				num = (short)736886785;
				if (num != 0)
				{
				}
				num = (short)2110390272;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.HiddenStatic = value;
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x060093E0 RID: 37856 RVA: 0x008B6028 File Offset: 0x008B4228
		// (set) Token: 0x060093E1 RID: 37857 RVA: 0x008B60DC File Offset: 0x008B42DC
		internal bool RadWideAdvancedFactoryOverrides_A8004_HiddenDynamic
		{
			get
			{
				short num = (short)721747968;
				short num2 = num;
				num = (short)1896596942;
				short num3 = num;
				num = (short)394053070;
				switch (num3 == num)
				{
				}
				num = (short)1652686849;
				if (num != 0)
				{
				}
				num = (short)1490354176;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004.HiddenDynamic;
			}
			set
			{
				short num = (short)1936425176;
				short num2 = num;
				num = (short)460030168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1942355968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1387134976;
				if (num != 0)
				{
				}
				num = (short)846921729;
				if (num != 0)
				{
				}
				this.radWideAdvancedFactoryOverrides_A8004.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x060093E2 RID: 37858 RVA: 0x008B6194 File Offset: 0x008B4394
		public bool RadWideAdvancedFactoryOverrides_A8004_HasDiffs
		{
			get
			{
				short num = (short)1169109460;
				short num2 = num;
				num = (short)1145385428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224264192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)597032961;
				if (num != 0)
				{
				}
				num = (short)398065664;
				if (num != 0)
				{
				}
				return this.radWideAdvancedFactoryOverrides_A8004._HasDiffs;
			}
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x008B6248 File Offset: 0x008B4448
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				short num = (short)698286081;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				int num2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1526596982;
						short num3 = num;
						num = (short)99681654;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)544604160;
							if (num != 0)
							{
							}
							num = (short)1097072643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return result;
					case 2:
					{
						num = (short)1469120512;
						short num4 = num;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1023475713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1579876354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (base.ParentRecset != null)
						{
							num = (short)1313472512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				IL_4B:
				result = null;
				num = (short)1565458436;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			return result;
		}

		// Token: 0x040049DC RID: 18908
		private global::AcpBusinessLayer.AcpField<bool> radWideAdvancedFactoryOverrides_A8004;
	}
}
