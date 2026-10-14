using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000169 RID: 361
	[global::System.Serializable]
	public class Depot : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002E11 RID: 11793 RVA: 0x002D834C File Offset: 0x002D654C
		public Depot(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x002D8368 File Offset: 0x002D6568
		protected Depot(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x002D8380 File Offset: 0x002D6580
		public override void Init()
		{
			int a_ = 7;
			short num = (short)933718079;
			short num2 = num;
			num = (short)78800959;
			switch (num2 == num)
			{
			}
			num = (short)907345920;
			short num3 = num;
			num = (short)267583488;
			if (num != 0)
			{
			}
			num = (short)1004077057;
			if (num != 0)
			{
			}
			this.advancedExternalMicOnly = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觇껉뫋꿍뻏뇑뇓닕鷗ꋙ꣛믝鋟賡藣諥ꗧ菩迫ꇭ黯黱跳", a_), global::CommonResources.AcgResources.ID_RADIOWRITEPROTECTENABLED);
			this.advancedExternalMicOnly.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
			this.advancedExternalMicOnly.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("資꿉볋ꇍ꓏", a_);
			base.Id = 10106;
			base.UIName = global::CommonResources.AcgResources.ID_DEPOT;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x002D84A0 File Offset: 0x002D66A0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)853879411;
			short num2 = num;
			num = (short)60107379;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BC:
				num = (short)607715328;
				short num3 = num;
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_1E0;
				}
				num = (short)1165623302;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1753546752;
				if (num != 0)
				{
				}
				num = (short)606339072;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)2010775553;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闓닕껗믙닛뷝藟蛡ꇣ黥鳧迩黫胭釯黱맳鿵鯷뗹鋻鋽秿", a_)))
					{
						num = (short)868548610;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 2:
					this.advancedExternalMicOnly = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闓닕껗믙닛뷝藟蛡ꇣ黥鳧迩黫胭釯黱맳鿵鯷뗹鋻鋽秿", a_), global::CommonResources.AcgResources.ID_RADIOWRITEPROTECTENABLED);
					this.advancedExternalMicOnly.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
					this.advancedExternalMicOnly.DataTransferOrder = -1;
					num = (short)459603973;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1926627329;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)2144862211;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 5:
					goto IL_15B;
				case 6:
					num = (short)854589444;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BC;
			}
			IL_15B:
			IL_1E0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郓돕꣗뗙꣛", a_);
			base.Id = 10106;
			base.UIName = global::CommonResources.AcgResources.ID_DEPOT;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x002D86C0 File Offset: 0x002D68C0
		public override void PopulateReferences()
		{
			short num = (short)1326376941;
			short num2 = num;
			num = (short)170649581;
			switch (num2 == num)
			{
			}
			num = (short)1913847808;
			short num3 = num;
			num = (short)95879169;
			if (num != 0)
			{
			}
			num = (short)873005056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x002D8768 File Offset: 0x002D6968
		public override void DropReferences()
		{
			short num = (short)958363890;
			short num2 = num;
			num = (short)1753446642;
			switch (num2 == num)
			{
			}
			num = (short)396034048;
			short num3 = num;
			num = (short)953221120;
			if (num != 0)
			{
			}
			num = (short)1099694081;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x002D8814 File Offset: 0x002D6A14
		public override void SetConstraints()
		{
			short num = (short)361228576;
			short num2 = num;
			num = (short)1223289120;
			switch (num2 == num)
			{
			}
			num = (short)581763072;
			short num3 = num;
			num = (short)145031168;
			if (num != 0)
			{
			}
			num = (short)1971060737;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x002D88C0 File Offset: 0x002D6AC0
		public override void SetupDependencies()
		{
			short num = (short)667751737;
			short num2 = num;
			num = (short)1948915001;
			switch (num2 == num)
			{
			}
			num = (short)785907712;
			short num3 = num;
			num = (short)1257766913;
			if (num != 0)
			{
			}
			num = (short)1209073664;
			if (num != 0)
			{
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x002D896C File Offset: 0x002D6B6C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1906163077;
				short num2 = num;
				num = (short)1897250181;
				switch (num2 == num)
				{
				}
				num = (short)243007488;
				short num3 = num;
				num = (short)1705705473;
				if (num != 0)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x002D8A1C File Offset: 0x002D6C1C
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x002D8AD4 File Offset: 0x002D6CD4
		public bool AdvancedExternalMicOnlyValue
		{
			get
			{
				short num = (short)304351906;
				short num2 = num;
				num = (short)816384674;
				switch (num2 == num)
				{
				}
				num = (short)716308480;
				short num3 = num;
				num = (short)1389035520;
				if (num != 0)
				{
				}
				num = (short)920125441;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Value;
			}
			set
			{
				short num = (short)104932061;
				short num2 = num;
				num = (short)2147099357;
				switch (num2 == num)
				{
				}
				num = (short)2055929856;
				short num3 = num;
				num = (short)2045640704;
				if (num != 0)
				{
				}
				num = (short)325517313;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Value = value;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x002D8B88 File Offset: 0x002D6D88
		public global::AcpBusinessLayer.AcpField<bool> AdvancedExternalMicOnly
		{
			get
			{
				short num = (short)1354051156;
				short num2 = num;
				num = (short)845229652;
				switch (num2 == num)
				{
				}
				num = (short)1928331264;
				short num3 = num;
				num = (short)487784449;
				if (num != 0)
				{
				}
				num = (short)2074869760;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x002D8C38 File Offset: 0x002D6E38
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x002D8CEC File Offset: 0x002D6EEC
		public bool AdvancedExternalMicOnly_UIValue
		{
			get
			{
				short num = (short)1419321618;
				short num2 = num;
				num = (short)1431707922;
				switch (num2 == num)
				{
				}
				num = (short)457113600;
				short num3 = num;
				num = (short)1309671425;
				if (num != 0)
				{
				}
				num = (short)1064632320;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Value;
			}
			set
			{
				short num = (short)1941214484;
				short num2 = num;
				num = (short)1664783636;
				switch (num2 == num)
				{
				}
				num = (short)1816395776;
				short num3 = num;
				num = (short)211550208;
				if (num != 0)
				{
				}
				num = (short)1160577025;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Value = value;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x002D8DA0 File Offset: 0x002D6FA0
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x002D8E54 File Offset: 0x002D7054
		public bool AdvancedExternalMicOnly_Applicable
		{
			get
			{
				short num = (short)1183796286;
				short num2 = num;
				num = (short)427772990;
				switch (num2 == num)
				{
				}
				num = (short)746389504;
				short num3 = num;
				num = (short)228392961;
				if (num != 0)
				{
				}
				num = (short)1641938944;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Applicable;
			}
			set
			{
				short num = (short)1931669065;
				short num2 = num;
				num = (short)306900553;
				switch (num2 == num)
				{
				}
				num = (short)1756692480;
				short num3 = num;
				num = (short)1847656448;
				if (num != 0)
				{
				}
				num = (short)1173946369;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Applicable = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x002D8F0C File Offset: 0x002D710C
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x002D8FC0 File Offset: 0x002D71C0
		public bool AdvancedExternalMicOnly_Valid
		{
			get
			{
				short num = (short)2132049944;
				short num2 = num;
				num = (short)551518232;
				switch (num2 == num)
				{
				}
				num = (short)5439488;
				short num3 = num;
				num = (short)612827137;
				if (num != 0)
				{
				}
				num = (short)1469775872;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Valid;
			}
			set
			{
				short num = (short)943259649;
				if (num != 0)
				{
				}
				num = (short)915212632;
				short num2 = num;
				num = (short)159189336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679687680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818558464;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Valid = value;
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x002D9074 File Offset: 0x002D7274
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x002D912C File Offset: 0x002D732C
		public bool AdvancedExternalMicOnly_Visible
		{
			get
			{
				short num = (short)1773428847;
				short num2 = num;
				num = (short)1522950255;
				switch (num2 == num)
				{
				}
				num = (short)1965490176;
				short num3 = num;
				num = (short)1380319233;
				if (num != 0)
				{
				}
				num = (short)313786368;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Visible;
			}
			set
			{
				short num = (short)1178533889;
				if (num != 0)
				{
				}
				num = (short)1637333105;
				short num2 = num;
				num = (short)487635057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086783488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)706674688;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Visible = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x002D91E0 File Offset: 0x002D73E0
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x002D9294 File Offset: 0x002D7494
		public bool AdvancedExternalMicOnly_Editable
		{
			get
			{
				short num = (short)354334425;
				short num2 = num;
				num = (short)892581593;
				switch (num2 == num)
				{
				}
				num = (short)546111488;
				short num3 = num;
				num = (short)120061952;
				if (num != 0)
				{
				}
				num = (short)1388511233;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.Editable;
			}
			set
			{
				short num = (short)1809304104;
				short num2 = num;
				num = (short)156224040;
				switch (num2 == num)
				{
				}
				num = (short)1635188736;
				short num3 = num;
				num = (short)124977152;
				if (num != 0)
				{
				}
				num = (short)2099445761;
				if (num != 0)
				{
				}
				this.advancedExternalMicOnly.Editable = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x002D9348 File Offset: 0x002D7548
		internal string AdvancedExternalMicOnly_UILabel
		{
			get
			{
				short num = (short)728303294;
				short num2 = num;
				num = (short)1036060350;
				switch (num2 == num)
				{
				}
				num = (short)1309605888;
				short num3 = num;
				num = (short)821755904;
				if (num != 0)
				{
				}
				num = (short)1243545601;
				if (num != 0)
				{
				}
				return this.advancedExternalMicOnly.UIName;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x002D93FC File Offset: 0x002D75FC
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x002D94B0 File Offset: 0x002D76B0
		internal bool AdvancedExternalMicOnly_HiddenStatic
		{
			get
			{
				short num = (short)53857223;
				short num2 = num;
				num = (short)2091436999;
				switch (num2 == num)
				{
				}
				num = (short)61800449;
				if (num != 0)
				{
				}
				num = (short)1236271104;
				if (num != 0)
				{
				}
				num = (short)1986985984;
				short num3 = num;
				return this.advancedExternalMicOnly.HiddenStatic;
			}
			set
			{
				short num = (short)280502302;
				short num2 = num;
				num = (short)1078534174;
				switch (num2 == num)
				{
				}
				num = (short)1557921793;
				if (num != 0)
				{
				}
				num = (short)753926144;
				if (num != 0)
				{
				}
				num = (short)1890451456;
				short num3 = num;
				this.advancedExternalMicOnly.HiddenStatic = value;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x002D9564 File Offset: 0x002D7764
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x002D9618 File Offset: 0x002D7818
		internal bool AdvancedExternalMicOnly_HiddenDynamic
		{
			get
			{
				short num = (short)2085182220;
				short num2 = num;
				num = (short)770726668;
				switch (num2 == num)
				{
				}
				num = (short)2109145089;
				if (num != 0)
				{
				}
				num = (short)750780416;
				if (num != 0)
				{
				}
				num = (short)1964703744;
				short num3 = num;
				return this.advancedExternalMicOnly.HiddenDynamic;
			}
			set
			{
				short num = (short)1307296000;
				short num2 = num;
				num = (short)795459840;
				switch (num2 == num)
				{
				}
				num = (short)2030436353;
				if (num != 0)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				num = (short)1032126464;
				short num3 = num;
				this.advancedExternalMicOnly.HiddenDynamic = value;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x002D96C8 File Offset: 0x002D78C8
		public bool AdvancedExternalMicOnly_HasDiffs
		{
			get
			{
				short num = (short)427753108;
				short num2 = num;
				num = (short)463994516;
				switch (num2 == num)
				{
				}
				num = (short)1718878208;
				if (num != 0)
				{
				}
				num = (short)762314753;
				if (num != 0)
				{
				}
				num = (short)1391919104;
				short num3 = num;
				return this.advancedExternalMicOnly._HasDiffs;
			}
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x002D977C File Offset: 0x002D797C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1715652075;
						short num3 = num2;
						num2 = (short)638830059;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)1052704768;
							if (num2 != 0)
							{
							}
							num2 = (short)1185153026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						num2 = (short)1821704193;
						if (num2 != 0)
						{
						}
						num2 = (short)1247150084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_F8;
					case 3:
						if (base.ParentRecset != null)
						{
							num2 = (short)1841823745;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13A;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1160970240;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13A;
					}
					goto IL_24;
				}
				IL_F8:
				IL_13A:
				num2 = (short)677445632;
				short num4 = num2;
				return result;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)601030659;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400114E RID: 4430
		private global::AcpBusinessLayer.AcpField<bool> advancedExternalMicOnly;
	}
}
