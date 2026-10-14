using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E7 RID: 999
	[global::System.Serializable]
	public class O2NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008C57 RID: 35927 RVA: 0x00834404 File Offset: 0x00832604
		public O2NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00834420 File Offset: 0x00832620
		protected O2NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00834438 File Offset: 0x00832638
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1924268033;
			if (num != 0)
			{
			}
			num = (short)2056357476;
			short num2 = num;
			num = (short)185894500;
			switch (num2 == num)
			{
			}
			num = (short)1075511296;
			if (num != 0)
			{
			}
			num = (short)1714159616;
			short num3 = num;
			this.o2UpDownButtonName_A41277 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("蛈流飌뿎闐볒ꋔ맖鯘껚꧜ꯞ軠跢ꯤ蛦蓨軪달껮연싲쟴샶컸", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.o2UpDownButtonName_A41277.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o2UpDownButtonName_A41277.DataTransferOrder = -1;
			this.radErgoControlO2UpDownButton_A41278 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2UpDownButton_A41278LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2UpDownButton_A41278LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뛘뗚꧜귞軠迢ꫤ헦볨鯪ꧬ胮蛰鷲럴苶跸迺鋼釾帀䈂㄄㘆㬈㰊㔌", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2UpDownButton_A41278LovStrs);
			this.radErgoControlO2UpDownButton_A41278.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO2UpDownButton_A41278.DataTransferOrder = 18;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟈꫊믌ꛎ뛐닒ꇔ뻖뛘뗚﷜鳞軠跢釤闦蛨蟪黬", a_);
			base.Id = 10725;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x008345AC File Offset: 0x008327AC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1295384576;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 1:
					for (;;)
					{
						this.o2UpDownButtonName_A41277 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("諄鳈믊觌ꃎꛐ뷒韔ꋖ귘꿚닜뇞꿠苢裤苦뛨ꫪ\ud9ec\udeee쏰쓲싴", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.o2UpDownButtonName_A41277.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.o2UpDownButtonName_A41277.DataTransferOrder = -1;
						num = (short)613443189;
						short num3 = num;
						num = (short)1879795317;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_161;
						}
					}
					IL_161:
					num = (short)670826497;
					if (num != 0)
					{
					}
					num = (short)390463488;
					if (num != 0)
					{
					}
					num = (short)190709766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)597229568;
					short num4 = num;
					num = (short)2053242889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_25B;
				case 4:
					num = (short)1359478792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radErgoControlO2UpDownButton_A41278 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2UpDownButton_A41278LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2UpDownButton_A41278LovStrs), this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠퇢냤韦귨蓪髬臮돰蛲致菶雸闺ꋼ뻾㔀㈂㜄〆ㄈ", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2UpDownButton_A41278LovStrs);
					this.radErgoControlO2UpDownButton_A41278.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO2UpDownButton_A41278.DataTransferOrder = 18;
					num = (short)1273823235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_A2;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞껠퇢냤韦귨蓪髬臮돰蛲致菶雸闺ꋼ뻾㔀㈂㜄〆ㄈ", a_)))
					{
						num = (short)326041605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諄鳈믊觌ꃎꛐ뷒韔ꋖ귘꿚닜뇞꿠苢裤苦뛨ꫪ\ud9ec\udeee쏰쓲싴", a_)))
					{
						num = (short)1488191489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2;
				case 9:
					if (producerFields != null)
					{
						num = (short)1630470148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1918894082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A2:
				num = (short)916652039;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25B:
			IL_2A9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("评ꛆ뿈ꋊ꫌껎ꗐ뫒뫔맖律飚닜뇞闠釢諤详髨", a_);
			base.Id = 10725;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00834894 File Offset: 0x00832A94
		public override void PopulateReferences()
		{
			short num = (short)1417293570;
			short num2 = num;
			num = (short)797585154;
			switch (num2 == num)
			{
			}
			num = (short)1677524993;
			if (num != 0)
			{
			}
			num = (short)1580138496;
			if (num != 0)
			{
			}
			num = (short)2015428608;
			short num3 = num;
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x00834940 File Offset: 0x00832B40
		public override void DropReferences()
		{
			short num = (short)1866171433;
			short num2 = num;
			num = (short)109282345;
			switch (num2 == num)
			{
			}
			num = (short)482869249;
			if (num != 0)
			{
			}
			num = (short)748879872;
			if (num != 0)
			{
			}
			num = (short)76546048;
			short num3 = num;
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x008349EC File Offset: 0x00832BEC
		public override void SetConstraints()
		{
			short num = (short)1207106563;
			short num2 = num;
			num = (short)1158806531;
			switch (num2 == num)
			{
			}
			num = (short)527368193;
			if (num != 0)
			{
			}
			num = (short)999292928;
			if (num != 0)
			{
			}
			num = (short)2044264448;
			short num3 = num;
			this.o2UpDownButtonName_A41277.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO2UpDownButton_A41278.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConStandaloneRadioSystemEnableApp);
			this.radErgoControlO2UpDownButton_A41278.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.conDownButtonApplicable);
			this.radErgoControlO2UpDownButton_A41278.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x00834AF0 File Offset: 0x00832CF0
		public override void SetupDependencies()
		{
			short num = (short)475303965;
			short num2 = num;
			num = (short)553160733;
			switch (num2 == num)
			{
			}
			num = (short)1985871872;
			if (num != 0)
			{
			}
			num = (short)1712914433;
			if (num != 0)
			{
			}
			num = (short)891682816;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO2UpDownButton_A41278);
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x06008C5F RID: 35935 RVA: 0x00834BB4 File Offset: 0x00832DB4
		public bool HasDiffs
		{
			get
			{
				short num = (short)315993587;
				short num2 = num;
				num = (short)2125966835;
				switch (num2 == num)
				{
				}
				num = (short)166330368;
				if (num != 0)
				{
				}
				num = (short)542572545;
				if (num != 0)
				{
				}
				num = (short)730267648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x00834C60 File Offset: 0x00832E60
		// (set) Token: 0x06008C61 RID: 35937 RVA: 0x00834D18 File Offset: 0x00832F18
		public string O2UpDownButtonName_A41277Value
		{
			get
			{
				short num = (short)937919218;
				short num2 = num;
				num = (short)1229226738;
				switch (num2 == num)
				{
				}
				num = (short)1865023489;
				if (num != 0)
				{
				}
				num = (short)934739968;
				if (num != 0)
				{
				}
				num = (short)220266496;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Value;
			}
			set
			{
				short num = (short)120678764;
				short num2 = num;
				num = (short)1742367084;
				switch (num2 == num)
				{
				}
				num = (short)1053818880;
				if (num != 0)
				{
				}
				num = (short)890961921;
				if (num != 0)
				{
				}
				num = (short)1599340544;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Value = value;
			}
		}

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x00834DD0 File Offset: 0x00832FD0
		public global::AcpBusinessLayer.AcpField<string> O2UpDownButtonName_A41277
		{
			get
			{
				short num = (short)713134456;
				short num2 = num;
				num = (short)2061537656;
				switch (num2 == num)
				{
				}
				num = (short)1263534080;
				if (num != 0)
				{
				}
				num = (short)1949302785;
				if (num != 0)
				{
				}
				num = (short)86376448;
				short num3 = num;
				return this.o2UpDownButtonName_A41277;
			}
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x06008C63 RID: 35939 RVA: 0x00834E80 File Offset: 0x00833080
		// (set) Token: 0x06008C64 RID: 35940 RVA: 0x00834F30 File Offset: 0x00833130
		public string O2UpDownButtonName_A41277_UIValue
		{
			get
			{
				short num = (short)1856175719;
				short num2 = num;
				num = (short)1422130791;
				switch (num2 == num)
				{
				}
				num = (short)206766081;
				if (num != 0)
				{
				}
				num = (short)339607552;
				if (num != 0)
				{
				}
				num = (short)1251278848;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Value;
			}
			set
			{
				short num = (short)182623021;
				short num2 = num;
				num = (short)1165007661;
				switch (num2 == num)
				{
				}
				num = (short)1077215232;
				if (num != 0)
				{
				}
				num = (short)1494876161;
				if (num != 0)
				{
				}
				num = (short)2054225920;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Value = value;
			}
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x06008C65 RID: 35941 RVA: 0x00834FE4 File Offset: 0x008331E4
		// (set) Token: 0x06008C66 RID: 35942 RVA: 0x0083509C File Offset: 0x0083329C
		public bool O2UpDownButtonName_A41277_Applicable
		{
			get
			{
				short num = (short)123789592;
				short num2 = num;
				num = (short)57794840;
				switch (num2 == num)
				{
				}
				num = (short)360251392;
				if (num != 0)
				{
				}
				num = (short)1963589633;
				if (num != 0)
				{
				}
				num = (short)1898971136;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Applicable;
			}
			set
			{
				short num = (short)51111313;
				short num2 = num;
				num = (short)1740891537;
				switch (num2 == num)
				{
				}
				num = (short)892207105;
				if (num != 0)
				{
				}
				num = (short)649986048;
				if (num != 0)
				{
				}
				num = (short)1046544384;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Applicable = value;
			}
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x06008C67 RID: 35943 RVA: 0x00835150 File Offset: 0x00833350
		// (set) Token: 0x06008C68 RID: 35944 RVA: 0x00835204 File Offset: 0x00833404
		public bool O2UpDownButtonName_A41277_Valid
		{
			get
			{
				short num = (short)256635543;
				short num2 = num;
				num = (short)750121623;
				switch (num2 == num)
				{
				}
				num = (short)1300889601;
				if (num != 0)
				{
				}
				num = (short)897581056;
				if (num != 0)
				{
				}
				num = (short)1960968192;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Valid;
			}
			set
			{
				short num = (short)430047233;
				if (num != 0)
				{
				}
				num = (short)603865137;
				short num2 = num;
				num = (short)1968783409;
				switch (num2 == num)
				{
				}
				num = (short)1915027456;
				if (num != 0)
				{
				}
				num = (short)1286602752;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Valid = value;
			}
		}

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x06008C69 RID: 35945 RVA: 0x008352B8 File Offset: 0x008334B8
		// (set) Token: 0x06008C6A RID: 35946 RVA: 0x0083536C File Offset: 0x0083356C
		public bool O2UpDownButtonName_A41277_Visible
		{
			get
			{
				short num = (short)887809612;
				short num2 = num;
				num = (short)548988492;
				switch (num2 == num)
				{
				}
				num = (short)87359489;
				if (num != 0)
				{
				}
				num = (short)1123811328;
				if (num != 0)
				{
				}
				num = (short)233439232;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Visible;
			}
			set
			{
				short num = (short)1503990261;
				short num2 = num;
				num = (short)1411453429;
				switch (num2 == num)
				{
				}
				num = (short)1826881537;
				if (num != 0)
				{
				}
				num = (short)1528889344;
				if (num != 0)
				{
				}
				num = (short)100270080;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Visible = value;
			}
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x06008C6B RID: 35947 RVA: 0x00835424 File Offset: 0x00833624
		// (set) Token: 0x06008C6C RID: 35948 RVA: 0x008354DC File Offset: 0x008336DC
		public bool O2UpDownButtonName_A41277_Editable
		{
			get
			{
				short num = (short)799539201;
				if (num != 0)
				{
				}
				num = (short)1979811759;
				short num2 = num;
				num = (short)126650287;
				switch (num2 == num)
				{
				}
				num = (short)1366360064;
				if (num != 0)
				{
				}
				num = (short)1789526016;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.Editable;
			}
			set
			{
				short num = (short)1596069995;
				short num2 = num;
				num = (short)1244076139;
				switch (num2 == num)
				{
				}
				num = (short)1001062401;
				if (num != 0)
				{
				}
				num = (short)1954938880;
				if (num != 0)
				{
				}
				num = (short)1166409728;
				short num3 = num;
				this.o2UpDownButtonName_A41277.Editable = value;
			}
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x06008C6D RID: 35949 RVA: 0x00835590 File Offset: 0x00833790
		internal string O2UpDownButtonName_A41277_UILabel
		{
			get
			{
				short num = (short)979321533;
				short num2 = num;
				num = (short)1937064637;
				switch (num2 == num)
				{
				}
				num = (short)513146881;
				if (num != 0)
				{
				}
				num = (short)301203456;
				if (num != 0)
				{
				}
				num = (short)1626603520;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.UIName;
			}
		}

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x00835644 File Offset: 0x00833844
		// (set) Token: 0x06008C6F RID: 35951 RVA: 0x008356F8 File Offset: 0x008338F8
		internal bool O2UpDownButtonName_A41277_HiddenStatic
		{
			get
			{
				short num = (short)1829077521;
				short num2 = num;
				num = (short)1090290193;
				switch (num2 == num)
				{
				}
				num = (short)818282497;
				if (num != 0)
				{
				}
				num = (short)40370176;
				if (num != 0)
				{
				}
				num = (short)867500032;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.HiddenStatic;
			}
			set
			{
				short num = (short)1634431622;
				short num2 = num;
				num = (short)996897414;
				switch (num2 == num)
				{
				}
				num = (short)455868416;
				if (num != 0)
				{
				}
				num = (short)776667137;
				if (num != 0)
				{
				}
				num = (short)720044032;
				short num3 = num;
				this.o2UpDownButtonName_A41277.HiddenStatic = value;
			}
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x008357AC File Offset: 0x008339AC
		// (set) Token: 0x06008C71 RID: 35953 RVA: 0x00835860 File Offset: 0x00833A60
		internal bool O2UpDownButtonName_A41277_HiddenDynamic
		{
			get
			{
				short num = (short)221855273;
				short num2 = num;
				num = (short)541998633;
				switch (num2 == num)
				{
				}
				num = (short)229376000;
				if (num != 0)
				{
				}
				num = (short)248119297;
				if (num != 0)
				{
				}
				num = (short)1434189824;
				short num3 = num;
				return this.o2UpDownButtonName_A41277.HiddenDynamic;
			}
			set
			{
				short num = (short)2078253132;
				short num2 = num;
				num = (short)86876236;
				switch (num2 == num)
				{
				}
				num = (short)1886584833;
				if (num != 0)
				{
				}
				num = (short)139657216;
				if (num != 0)
				{
				}
				num = (short)1821376512;
				short num3 = num;
				this.o2UpDownButtonName_A41277.HiddenDynamic = value;
			}
		}

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x00835914 File Offset: 0x00833B14
		public bool O2UpDownButtonName_A41277_HasDiffs
		{
			get
			{
				short num = (short)217306863;
				short num2 = num;
				num = (short)99997423;
				switch (num2 == num)
				{
				}
				num = (short)1994391553;
				if (num != 0)
				{
				}
				num = (short)1447821312;
				if (num != 0)
				{
				}
				num = (short)2000879616;
				short num3 = num;
				return this.o2UpDownButtonName_A41277._HasDiffs;
			}
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x06008C73 RID: 35955 RVA: 0x008359C8 File Offset: 0x00833BC8
		// (set) Token: 0x06008C74 RID: 35956 RVA: 0x00835A7C File Offset: 0x00833C7C
		public int RadErgoControlO2UpDownButton_A41278Value
		{
			get
			{
				short num = (short)1052366425;
				short num2 = num;
				num = (short)93902425;
				switch (num2 == num)
				{
				}
				num = (short)1921122305;
				if (num != 0)
				{
				}
				num = (short)635633664;
				if (num != 0)
				{
				}
				num = (short)2014314496;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.Value;
			}
			set
			{
				short num = (short)1816264705;
				if (num != 0)
				{
				}
				num = (short)87553098;
				short num2 = num;
				num = (short)1327494218;
				switch (num2 == num)
				{
				}
				num = (short)2026897408;
				if (num != 0)
				{
				}
				num = (short)1314127872;
				short num3 = num;
				this.radErgoControlO2UpDownButton_A41278.Value = value;
			}
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x06008C75 RID: 35957 RVA: 0x00835B30 File Offset: 0x00833D30
		// (set) Token: 0x06008C76 RID: 35958 RVA: 0x00835BE8 File Offset: 0x00833DE8
		public string RadErgoControlO2UpDownButton_A41278_UIValue
		{
			get
			{
				short num = (short)1014295418;
				short num2 = num;
				num = (short)1925376890;
				switch (num2 == num)
				{
				}
				num = (short)611385345;
				if (num != 0)
				{
				}
				num = (short)2098790400;
				if (num != 0)
				{
				}
				num = (short)13762560;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.UIValue;
			}
			set
			{
				short num = (short)1912556304;
				short num2 = num;
				num = (short)1507019536;
				switch (num2 == num)
				{
				}
				num = (short)779681793;
				if (num != 0)
				{
				}
				num = (short)465240064;
				if (num != 0)
				{
				}
				num = (short)906756096;
				short num3 = num;
				this.radErgoControlO2UpDownButton_A41278.UIValue = value;
			}
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x00835CA0 File Offset: 0x00833EA0
		public global::AcpBusinessLayer.AcpListField RadErgoControlO2UpDownButton_A41278
		{
			get
			{
				short num = (short)912982017;
				if (num != 0)
				{
				}
				num = (short)1242151219;
				short num2 = num;
				num = (short)367114547;
				switch (num2 == num)
				{
				}
				num = (short)1010237440;
				if (num != 0)
				{
				}
				num = (short)1352335360;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278;
			}
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x00835D50 File Offset: 0x00833F50
		// (set) Token: 0x06008C79 RID: 35961 RVA: 0x00835E04 File Offset: 0x00834004
		public bool RadErgoControlO2UpDownButton_A41278_Applicable
		{
			get
			{
				short num = (short)1252578690;
				short num2 = num;
				num = (short)727307650;
				switch (num2 == num)
				{
				}
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)126156800;
				if (num != 0)
				{
				}
				num = (short)890241024;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.Applicable;
			}
			set
			{
				short num = (short)1879638017;
				if (num != 0)
				{
				}
				num = (short)1182114765;
				short num2 = num;
				num = (short)1457693645;
				switch (num2 == num)
				{
				}
				num = (short)868679680;
				if (num != 0)
				{
				}
				num = (short)867041280;
				short num3 = num;
				this.radErgoControlO2UpDownButton_A41278.Applicable = value;
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x06008C7A RID: 35962 RVA: 0x00835EBC File Offset: 0x008340BC
		// (set) Token: 0x06008C7B RID: 35963 RVA: 0x00835F70 File Offset: 0x00834170
		public bool RadErgoControlO2UpDownButton_A41278_Valid
		{
			get
			{
				short num = (short)1892274852;
				short num2 = num;
				num = (short)1864028836;
				switch (num2 == num)
				{
				}
				num = (short)680984576;
				if (num != 0)
				{
				}
				num = (short)1692663809;
				if (num != 0)
				{
				}
				num = (short)1483997184;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.Valid;
			}
			set
			{
				short num = (short)387594724;
				short num2 = num;
				num = (short)994916836;
				switch (num2 == num)
				{
				}
				num = (short)1807351809;
				if (num != 0)
				{
				}
				num = (short)1188757504;
				if (num != 0)
				{
				}
				num = (short)1656160256;
				short num3 = num;
				this.radErgoControlO2UpDownButton_A41278.Valid = value;
			}
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x06008C7C RID: 35964 RVA: 0x00836024 File Offset: 0x00834224
		// (set) Token: 0x06008C7D RID: 35965 RVA: 0x008360D8 File Offset: 0x008342D8
		public bool RadErgoControlO2UpDownButton_A41278_Visible
		{
			get
			{
				short num = (short)145620993;
				if (num != 0)
				{
				}
				num = (short)1293923122;
				short num2 = num;
				num = (short)643085106;
				switch (num2 == num)
				{
				}
				num = (short)1168769024;
				if (num != 0)
				{
				}
				num = (short)739311616;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.Visible;
			}
			set
			{
				short num = (short)1599406081;
				if (num != 0)
				{
				}
				num = (short)1941258016;
				short num2 = num;
				num = (short)566443808;
				switch (num2 == num)
				{
				}
				num = (short)1670512640;
				if (num != 0)
				{
				}
				num = (short)279773184;
				short num3 = num;
				this.radErgoControlO2UpDownButton_A41278.Visible = value;
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x06008C7E RID: 35966 RVA: 0x0083618C File Offset: 0x0083438C
		// (set) Token: 0x06008C7F RID: 35967 RVA: 0x00836240 File Offset: 0x00834440
		public bool RadErgoControlO2UpDownButton_A41278_Editable
		{
			get
			{
				short num = (short)158365761;
				short num2 = num;
				num = (short)1585543233;
				switch (num2 == num)
				{
				}
				num = (short)676134912;
				if (num != 0)
				{
				}
				num = (short)225247233;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				short num3 = num;
				return this.radErgoControlO2UpDownButton_A41278.Editable;
			}
			set
			{
				short num = (short)1579760535;
				short num2 = num;
				num = (short)311245719;
				switch (num2 == num)
				{
				}
				num = (short)1495400449;
				if (num != 0)
				{
				}
				num = (short)1149829120;
				short num3 = num;
				num = (short)1832452096;
				if (num != 0)
				{
				}
				this.radErgoControlO2UpDownButton_A41278.Editable = value;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x06008C80 RID: 35968 RVA: 0x008362F8 File Offset: 0x008344F8
		internal string RadErgoControlO2UpDownButton_A41278_UILabel
		{
			get
			{
				short num = (short)500964726;
				short num2 = num;
				num = (short)1555570038;
				switch (num2 == num)
				{
				}
				num = (short)22675457;
				if (num != 0)
				{
				}
				num = (short)1935343616;
				short num3 = num;
				num = (short)214171648;
				if (num != 0)
				{
				}
				return this.radErgoControlO2UpDownButton_A41278.UIName;
			}
		}

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x008363AC File Offset: 0x008345AC
		// (set) Token: 0x06008C82 RID: 35970 RVA: 0x00836460 File Offset: 0x00834660
		internal bool RadErgoControlO2UpDownButton_A41278_HiddenStatic
		{
			get
			{
				short num = (short)151761314;
				short num2 = num;
				num = (short)615035298;
				switch (num2 == num)
				{
				}
				num = (short)1536622592;
				if (num != 0)
				{
				}
				num = (short)723582976;
				short num3 = num;
				num = (short)413204481;
				if (num != 0)
				{
				}
				return this.radErgoControlO2UpDownButton_A41278.HiddenStatic;
			}
			set
			{
				short num = (short)769712001;
				short num2 = num;
				num = (short)969662337;
				switch (num2 == num)
				{
				}
				num = (short)486146049;
				if (num != 0)
				{
				}
				num = (short)526909440;
				short num3 = num;
				num = (short)127074304;
				if (num != 0)
				{
				}
				this.radErgoControlO2UpDownButton_A41278.HiddenStatic = value;
			}
		}

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x00836514 File Offset: 0x00834714
		// (set) Token: 0x06008C84 RID: 35972 RVA: 0x008365C8 File Offset: 0x008347C8
		internal bool RadErgoControlO2UpDownButton_A41278_HiddenDynamic
		{
			get
			{
				short num = (short)520221468;
				short num2 = num;
				num = (short)1402860316;
				switch (num2 == num)
				{
				}
				num = (short)747962369;
				if (num != 0)
				{
				}
				num = (short)1243152384;
				short num3 = num;
				num = (short)1258225664;
				if (num != 0)
				{
				}
				return this.radErgoControlO2UpDownButton_A41278.HiddenDynamic;
			}
			set
			{
				short num = (short)562036737;
				if (num != 0)
				{
				}
				num = (short)1294706650;
				short num2 = num;
				num = (short)191670234;
				switch (num2 == num)
				{
				}
				num = (short)143458304;
				short num3 = num;
				num = (short)999817216;
				if (num != 0)
				{
				}
				this.radErgoControlO2UpDownButton_A41278.HiddenDynamic = value;
			}
		}

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x0083667C File Offset: 0x0083487C
		public bool RadErgoControlO2UpDownButton_A41278_HasDiffs
		{
			get
			{
				short num = (short)158753091;
				short num2 = num;
				num = (short)1668309315;
				switch (num2 == num)
				{
				}
				num = (short)273416193;
				if (num != 0)
				{
				}
				num = (short)602669056;
				short num3 = num;
				num = (short)702939136;
				if (num != 0)
				{
				}
				return this.radErgoControlO2UpDownButton_A41278._HasDiffs;
			}
		}

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x06008C86 RID: 35974 RVA: 0x00836734 File Offset: 0x00834934
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)955800727;
				short num2 = num;
				num = (short)1094933655;
				switch (num2 == num)
				{
				}
				num = (short)1935867905;
				if (num != 0)
				{
				}
				num = (short)469762048;
				short num3 = num;
				num = (short)1985544192;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x008367F0 File Offset: 0x008349F0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1924988932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1712259074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)1271306311;
					short num3 = num2;
					num2 = (short)390699079;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)413401089;
						if (num2 != 0)
						{
						}
						num2 = (short)1824980992;
						if (num2 != 0)
						{
						}
						num2 = (short)1221787648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_F7;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)297533443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_F7:
			num2 = (short)825819136;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1480130561;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040043F3 RID: 17395
		private global::AcpBusinessLayer.AcpField<string> o2UpDownButtonName_A41277;

		// Token: 0x040043F4 RID: 17396
		private global::AcpBusinessLayer.AcpListField radErgoControlO2UpDownButton_A41278;
	}
}
