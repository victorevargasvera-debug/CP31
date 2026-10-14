using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B7 RID: 951
	[global::System.Serializable]
	public class O5NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600893E RID: 35134 RVA: 0x007FC3CC File Offset: 0x007FA5CC
		public O5NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x007FC3E8 File Offset: 0x007FA5E8
		protected O5NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x007FC400 File Offset: 0x007FA600
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1860926078;
			short num2 = num;
			num = (short)215775870;
			switch (num2 == num)
			{
			}
			num = (short)113770496;
			if (num != 0)
			{
			}
			num = (short)18874368;
			short num3 = num;
			num = (short)1038024705;
			if (num != 0)
			{
			}
			this.radErgoControlO5NaviControlName_A41378 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎뻐뷒ꇔꗖ뛘럚鋜꿠苢鏤軦ꫨ蓪菬鯮菰鳲駴맶飸雺飼ꃾ䀀㜂㐄㐆㸈㌊", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoControlO5NaviControlName_A41378.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO5NaviControlName_A41378.DataTransferOrder = -1;
			this.radErgoControlO5NaviControlFeature_A41379 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexRadErgoControlO5NaviControlFeature_A41379LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idRadErgoControlO5NaviControlFeature_A41379LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎뻐뷒ꇔꗖ뛘럚鋜꿠苢鏤軦ꫨ蓪菬鯮菰鳲駴뇶鳸髺觼諾猀昂娄䘆㴈㨊㸌㠎⠐", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.RadErgoControlO5NaviControlFeature_A41379LovStrs);
			this.radErgoControlO5NaviControlFeature_A41379.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO5NaviControlFeature_A41379.DataTransferOrder = 2;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迀ꋂ도껆껈꫊만ꛎ뻐뷒铖뛘뗚꧜귞軠迢雤", a_);
			base.Id = 10736;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x007FC570 File Offset: 0x007FA770
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1442906118;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1506541573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\ud8ecꇮ郰藲鳴듶雸闺觼跾渀漂䬄昆搈渊刌与┐−☔‖℘", a_)))
					{
						num = (short)1060831234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 2:
					num = (short)1450049537;
					if (num != 0)
					{
					}
					this.radErgoControlO5NaviControlName_A41378 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\ud8ecꇮ郰藲鳴듶雸闺觼跾渀漂䬄昆搈渊刌与┐−☔‖℘", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoControlO5NaviControlName_A41378.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO5NaviControlName_A41378.DataTransferOrder = -1;
					num = (short)494075913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\ud8ecꇮ郰藲鳴듶雸闺觼跾渀漂䌄戆栈缊砌紎琐䰒吔⌖⠘⠚⨜☞", a_)))
					{
						num = (short)1851916296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 4:
					goto IL_20C;
				case 5:
					if (producerFields != null)
					{
						num = (short)1905000455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 7:
					num = (short)1485701121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					IL_10D:
					this.radErgoControlO5NaviControlFeature_A41379 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexRadErgoControlO5NaviControlFeature_A41379LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idRadErgoControlO5NaviControlFeature_A41379LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\ud8ecꇮ郰藲鳴듶雸闺觼跾渀漂䌄戆栈缊砌紎琐䰒吔⌖⠘⠚⨜☞", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.RadErgoControlO5NaviControlFeature_A41379LovStrs);
					this.radErgoControlO5NaviControlFeature_A41379.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO5NaviControlFeature_A41379.DataTransferOrder = 2;
					num = (short)1141243908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_7A;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)251002880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2A9;
				IL_7A:
				num = (short)2052809200;
				short num3 = num;
				num = (short)1015046640;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10D;
				default:
					num = (short)1657274368;
					if (num != 0)
					{
					}
					num = (short)1377304579;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_20C:
			num = (short)267255808;
			short num4 = num;
			IL_2A9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臎냐ꗒ볔냖룘꿚드냞迠쏢ꛤ裦蟨鿪鿬胮鷰胲", a_);
			base.Id = 10736;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x007FC858 File Offset: 0x007FAA58
		public override void PopulateReferences()
		{
			short num = (short)1634363104;
			short num2 = num;
			num = (short)730752736;
			switch (num2 == num)
			{
			}
			num = (short)1935802369;
			if (num != 0)
			{
			}
			num = (short)1441005568;
			short num3 = num;
			num = (short)42139648;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x007FC908 File Offset: 0x007FAB08
		public override void DropReferences()
		{
			short num = (short)1814476901;
			short num2 = num;
			num = (short)1509275749;
			switch (num2 == num)
			{
			}
			num = (short)1949040641;
			if (num != 0)
			{
			}
			num = (short)1866596352;
			short num3 = num;
			num = (short)1532100608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x007FC9B0 File Offset: 0x007FABB0
		public override void SetConstraints()
		{
			short num = (short)156827649;
			if (num != 0)
			{
			}
			num = (short)2080724179;
			short num2 = num;
			num = (short)569005267;
			switch (num2 == num)
			{
			}
			num = (short)1884225536;
			short num3 = num;
			num = (short)114229248;
			if (num != 0)
			{
			}
			this.radErgoControlO5NaviControlName_A41378.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO5NaviControlFeature_A41379.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgoControlO5NaviControlFeature_A41379.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.conDownButtonApplicable);
			this.radErgoControlO5NaviControlFeature_A41379.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x007FCAB8 File Offset: 0x007FACB8
		public override void SetupDependencies()
		{
			short num = (short)1236664321;
			if (num != 0)
			{
			}
			num = (short)1631545533;
			short num2 = num;
			num = (short)987261117;
			switch (num2 == num)
			{
			}
			num = (short)905379840;
			short num3 = num;
			num = (short)142016512;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO5NaviControlFeature_A41379);
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x06008946 RID: 35142 RVA: 0x007FCB7C File Offset: 0x007FAD7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)297350853;
				short num2 = num;
				num = (short)537409221;
				switch (num2 == num)
				{
				}
				num = (short)214237185;
				if (num != 0)
				{
				}
				num = (short)963641344;
				short num3 = num;
				num = (short)751370240;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x06008947 RID: 35143 RVA: 0x007FCC2C File Offset: 0x007FAE2C
		// (set) Token: 0x06008948 RID: 35144 RVA: 0x007FCCE0 File Offset: 0x007FAEE0
		public string RadErgoControlO5NaviControlName_A41378Value
		{
			get
			{
				short num = (short)1822271422;
				short num2 = num;
				num = (short)1581492158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005336064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725825025;
				if (num != 0)
				{
				}
				num = (short)1075904512;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Value;
			}
			set
			{
				short num = (short)943456257;
				if (num != 0)
				{
				}
				num = (short)17367040;
				short num2 = num;
				num = (short)310114577;
				short num3 = num;
				num = (short)1977153809;
				switch (num3 == num)
				{
				}
				num = (short)1709703168;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Value = value;
			}
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x06008949 RID: 35145 RVA: 0x007FCD94 File Offset: 0x007FAF94
		public global::AcpBusinessLayer.AcpField<string> RadErgoControlO5NaviControlName_A41378
		{
			get
			{
				short num = (short)815286759;
				short num2 = num;
				num = (short)2085964263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854406656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154809857;
				if (num != 0)
				{
				}
				num = (short)944570368;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378;
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x007FCE48 File Offset: 0x007FB048
		// (set) Token: 0x0600894B RID: 35147 RVA: 0x007FCF00 File Offset: 0x007FB100
		public string RadErgoControlO5NaviControlName_A41378_UIValue
		{
			get
			{
				short num = (short)597950465;
				if (num != 0)
				{
				}
				num = (short)2061893632;
				short num2 = num;
				num = (short)1877862607;
				short num3 = num;
				num = (short)1699539151;
				switch (num3 == num)
				{
				}
				num = (short)760938496;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Value;
			}
			set
			{
				short num = (short)1377836695;
				short num2 = num;
				num = (short)2071404183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015821824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)871956481;
				if (num != 0)
				{
				}
				num = (short)1767243776;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Value = value;
			}
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x007FCFB8 File Offset: 0x007FB1B8
		// (set) Token: 0x0600894D RID: 35149 RVA: 0x007FD06C File Offset: 0x007FB26C
		public bool RadErgoControlO5NaviControlName_A41378_Applicable
		{
			get
			{
				short num = (short)2001968675;
				short num2 = num;
				num = (short)305438243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898105344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)122683393;
				if (num != 0)
				{
				}
				num = (short)108462080;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Applicable;
			}
			set
			{
				short num = (short)158703465;
				short num2 = num;
				num = (short)806985577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)560398336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)802947072;
				if (num != 0)
				{
				}
				num = (short)1418788865;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Applicable = value;
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x0600894E RID: 35150 RVA: 0x007FD120 File Offset: 0x007FB320
		// (set) Token: 0x0600894F RID: 35151 RVA: 0x007FD1D8 File Offset: 0x007FB3D8
		public bool RadErgoControlO5NaviControlName_A41378_Valid
		{
			get
			{
				short num = (short)1705903249;
				short num2 = num;
				num = (short)850723985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256311296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708771841;
				if (num != 0)
				{
				}
				num = (short)1189347328;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Valid;
			}
			set
			{
				short num = (short)1551891889;
				short num2 = num;
				num = (short)2015624625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981401600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818820609;
				if (num != 0)
				{
				}
				num = (short)420675584;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Valid = value;
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x06008950 RID: 35152 RVA: 0x007FD290 File Offset: 0x007FB490
		// (set) Token: 0x06008951 RID: 35153 RVA: 0x007FD344 File Offset: 0x007FB544
		public bool RadErgoControlO5NaviControlName_A41378_Visible
		{
			get
			{
				short num = (short)1323793285;
				short num2 = num;
				num = (short)50363269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210108416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989265921;
				if (num != 0)
				{
				}
				num = (short)1496252416;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Visible;
			}
			set
			{
				short num = (short)1041625276;
				short num2 = num;
				num = (short)509210812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964310528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322830336;
				if (num != 0)
				{
				}
				num = (short)1560739841;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Visible = value;
			}
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x06008952 RID: 35154 RVA: 0x007FD3F8 File Offset: 0x007FB5F8
		// (set) Token: 0x06008953 RID: 35155 RVA: 0x007FD4AC File Offset: 0x007FB6AC
		public bool RadErgoControlO5NaviControlName_A41378_Editable
		{
			get
			{
				short num = (short)261685249;
				if (num != 0)
				{
				}
				num = (short)1149042688;
				short num2 = num;
				num = (short)454558214;
				short num3 = num;
				num = (short)99418630;
				switch (num3 == num)
				{
				}
				num = (short)61079552;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.Editable;
			}
			set
			{
				short num = (short)23564578;
				short num2 = num;
				num = (short)544837922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093926912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767964673;
				if (num != 0)
				{
				}
				num = (short)1475149824;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.Editable = value;
			}
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x06008954 RID: 35156 RVA: 0x007FD564 File Offset: 0x007FB764
		internal string RadErgoControlO5NaviControlName_A41378_UILabel
		{
			get
			{
				short num = (short)1542083256;
				short num2 = num;
				num = (short)1526026936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100494336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)612171776;
				if (num != 0)
				{
				}
				num = (short)45285377;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.UIName;
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x06008955 RID: 35157 RVA: 0x007FD61C File Offset: 0x007FB81C
		// (set) Token: 0x06008956 RID: 35158 RVA: 0x007FD6D0 File Offset: 0x007FB8D0
		internal bool RadErgoControlO5NaviControlName_A41378_HiddenStatic
		{
			get
			{
				short num = (short)857293633;
				short num2 = num;
				num = (short)843006785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355808768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378863616;
				if (num != 0)
				{
				}
				num = (short)520159233;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.HiddenStatic;
			}
			set
			{
				short num = (short)1081080383;
				short num2 = num;
				num = (short)128645695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)127991808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1446379520;
				if (num != 0)
				{
				}
				num = (short)1168703489;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.HiddenStatic = value;
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06008957 RID: 35159 RVA: 0x007FD784 File Offset: 0x007FB984
		// (set) Token: 0x06008958 RID: 35160 RVA: 0x007FD838 File Offset: 0x007FBA38
		internal bool RadErgoControlO5NaviControlName_A41378_HiddenDynamic
		{
			get
			{
				short num = (short)1226135249;
				short num2 = num;
				num = (short)1032541905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562116096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1034289153;
				if (num != 0)
				{
				}
				num = (short)1065615360;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378.HiddenDynamic;
			}
			set
			{
				short num = (short)887368575;
				short num2 = num;
				num = (short)201534335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421606912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900871680;
				if (num != 0)
				{
				}
				num = (short)288555009;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlName_A41378.HiddenDynamic = value;
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x007FD8EC File Offset: 0x007FBAEC
		public bool RadErgoControlO5NaviControlName_A41378_HasDiffs
		{
			get
			{
				short num = (short)744875475;
				short num2 = num;
				num = (short)1233118675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978190336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779892225;
				if (num != 0)
				{
				}
				num = (short)2109472768;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlName_A41378._HasDiffs;
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x0600895A RID: 35162 RVA: 0x007FD9A0 File Offset: 0x007FBBA0
		// (set) Token: 0x0600895B RID: 35163 RVA: 0x007FDA54 File Offset: 0x007FBC54
		public int RadErgoControlO5NaviControlFeature_A41379Value
		{
			get
			{
				short num = (short)1109218579;
				short num2 = num;
				num = (short)655250707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116930048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641218048;
				if (num != 0)
				{
				}
				num = (short)356909057;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.Value;
			}
			set
			{
				short num = (short)1904959243;
				short num2 = num;
				num = (short)1991139083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1378549760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941293569;
				if (num != 0)
				{
				}
				num = (short)780468224;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.Value = value;
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x0600895C RID: 35164 RVA: 0x007FDB0C File Offset: 0x007FBD0C
		// (set) Token: 0x0600895D RID: 35165 RVA: 0x007FDBC0 File Offset: 0x007FBDC0
		public string RadErgoControlO5NaviControlFeature_A41379_UIValue
		{
			get
			{
				short num = (short)714084850;
				short num2 = num;
				num = (short)26481138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469106688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1780744193;
				if (num != 0)
				{
				}
				num = (short)1132134400;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.UIValue;
			}
			set
			{
				short num = (short)1107886081;
				if (num != 0)
				{
				}
				num = (short)382009344;
				short num2 = num;
				num = (short)1888552117;
				short num3 = num;
				num = (short)1827603637;
				switch (num3 == num)
				{
				}
				num = (short)1659305984;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.UIValue = value;
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x007FDC78 File Offset: 0x007FBE78
		public global::AcpBusinessLayer.AcpListField RadErgoControlO5NaviControlFeature_A41379
		{
			get
			{
				short num = (short)1708941286;
				short num2 = num;
				num = (short)1503879142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498939392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134900737;
				if (num != 0)
				{
				}
				num = (short)1508245504;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379;
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x007FDD28 File Offset: 0x007FBF28
		// (set) Token: 0x06008960 RID: 35168 RVA: 0x007FDDDC File Offset: 0x007FBFDC
		public bool RadErgoControlO5NaviControlFeature_A41379_Applicable
		{
			get
			{
				short num = (short)1784464823;
				short num2 = num;
				num = (short)262522295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)284229632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)739246081;
				if (num != 0)
				{
				}
				num = (short)1142030336;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.Applicable;
			}
			set
			{
				short num = (short)1976006947;
				short num2 = num;
				num = (short)1053653283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449970176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575537153;
				if (num != 0)
				{
				}
				num = (short)736428032;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.Applicable = value;
			}
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x007FDE90 File Offset: 0x007FC090
		// (set) Token: 0x06008962 RID: 35170 RVA: 0x007FDF48 File Offset: 0x007FC148
		public bool RadErgoControlO5NaviControlFeature_A41379_Valid
		{
			get
			{
				short num = (short)1041432577;
				if (num != 0)
				{
				}
				num = (short)885850112;
				short num2 = num;
				num = (short)1044669294;
				short num3 = num;
				num = (short)166486894;
				switch (num3 == num)
				{
				}
				num = (short)743505920;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.Valid;
			}
			set
			{
				short num = (short)166854657;
				if (num != 0)
				{
				}
				num = (short)1272512512;
				short num2 = num;
				num = (short)1056494257;
				short num3 = num;
				num = (short)36033201;
				switch (num3 == num)
				{
				}
				num = (short)1096613888;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.Valid = value;
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x06008963 RID: 35171 RVA: 0x007FDFFC File Offset: 0x007FC1FC
		// (set) Token: 0x06008964 RID: 35172 RVA: 0x007FE0B0 File Offset: 0x007FC2B0
		public bool RadErgoControlO5NaviControlFeature_A41379_Visible
		{
			get
			{
				short num = (short)731977459;
				short num2 = num;
				num = (short)1061754611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1216217088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851050497;
				if (num != 0)
				{
				}
				num = (short)133038080;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.Visible;
			}
			set
			{
				short num = (short)8494409;
				short num2 = num;
				num = (short)779459913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61079552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373306881;
				if (num != 0)
				{
				}
				num = (short)1762787328;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.Visible = value;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06008965 RID: 35173 RVA: 0x007FE168 File Offset: 0x007FC368
		// (set) Token: 0x06008966 RID: 35174 RVA: 0x007FE220 File Offset: 0x007FC420
		public bool RadErgoControlO5NaviControlFeature_A41379_Editable
		{
			get
			{
				short num = (short)776501441;
				short num2 = num;
				num = (short)1006926017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)147849216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010040832;
				if (num != 0)
				{
				}
				num = (short)674627585;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.Editable;
			}
			set
			{
				short num = (short)1256626971;
				short num2 = num;
				num = (short)1531353883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504102912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1967325185;
				if (num != 0)
				{
				}
				num = (short)712376320;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.Editable = value;
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06008967 RID: 35175 RVA: 0x007FE2D8 File Offset: 0x007FC4D8
		internal string RadErgoControlO5NaviControlFeature_A41379_UILabel
		{
			get
			{
				short num = (short)1464083194;
				short num2 = num;
				num = (short)1332683514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1649082368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)796786689;
				if (num != 0)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.UIName;
			}
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06008968 RID: 35176 RVA: 0x007FE38C File Offset: 0x007FC58C
		// (set) Token: 0x06008969 RID: 35177 RVA: 0x007FE440 File Offset: 0x007FC640
		internal bool RadErgoControlO5NaviControlFeature_A41379_HiddenStatic
		{
			get
			{
				short num = (short)2062197454;
				short num2 = num;
				num = (short)1717019342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1522335744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)934215681;
				if (num != 0)
				{
				}
				num = (short)67960832;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.HiddenStatic;
			}
			set
			{
				short num = (short)605642142;
				short num2 = num;
				num = (short)1589337502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1583546368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1853227008;
				if (num != 0)
				{
				}
				num = (short)1975058433;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.HiddenStatic = value;
			}
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x0600896A RID: 35178 RVA: 0x007FE4F8 File Offset: 0x007FC6F8
		// (set) Token: 0x0600896B RID: 35179 RVA: 0x007FE5AC File Offset: 0x007FC7AC
		internal bool RadErgoControlO5NaviControlFeature_A41379_HiddenDynamic
		{
			get
			{
				short num = (short)294912001;
				if (num != 0)
				{
				}
				num = (short)1850146816;
				short num2 = num;
				num = (short)1097809403;
				short num3 = num;
				num = (short)927612411;
				switch (num3 == num)
				{
				}
				num = (short)910098432;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379.HiddenDynamic;
			}
			set
			{
				short num = (short)1935337346;
				short num2 = num;
				num = (short)1718609794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1504051200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548025857;
				if (num != 0)
				{
				}
				num = (short)97714176;
				if (num != 0)
				{
				}
				this.radErgoControlO5NaviControlFeature_A41379.HiddenDynamic = value;
			}
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x007FE660 File Offset: 0x007FC860
		public bool RadErgoControlO5NaviControlFeature_A41379_HasDiffs
		{
			get
			{
				short num = (short)630423192;
				short num2 = num;
				num = (short)1556577944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2146828288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)154664961;
				if (num != 0)
				{
				}
				num = (short)560136192;
				if (num != 0)
				{
				}
				return this.radErgoControlO5NaviControlFeature_A41379._HasDiffs;
			}
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x0600896D RID: 35181 RVA: 0x007FE714 File Offset: 0x007FC914
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)258504522;
				short num2 = num;
				num = (short)930969418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982332928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867172352;
				if (num != 0)
				{
				}
				num = (short)1385824257;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x007FE7D4 File Offset: 0x007FC9D4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)266403841;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1492582401;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)949616644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_101;
				case 3:
					goto IL_B2;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)937754626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_101:
			return result;
			IL_24:
			result = null;
			num2 = (short)82697135;
			short num3 = num2;
			num2 = (short)1158994863;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B2:
				if (base.ParentRecset != null)
				{
					num2 = (short)1805647872;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1757741056;
				short num4 = num2;
				num2 = (short)1562902528;
				if (num2 != 0)
				{
				}
				num2 = (short)1731657731;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x040040ED RID: 16621
		private global::AcpBusinessLayer.AcpField<string> radErgoControlO5NaviControlName_A41378;

		// Token: 0x040040EE RID: 16622
		private global::AcpBusinessLayer.AcpListField radErgoControlO5NaviControlFeature_A41379;
	}
}
