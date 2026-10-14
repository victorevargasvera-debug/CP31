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
	// Token: 0x020003E2 RID: 994
	[global::System.Serializable]
	public class O2MFKAssignmentControlInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008BEE RID: 35822 RVA: 0x0082F6DC File Offset: 0x0082D8DC
		public O2MFKAssignmentControlInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x0082F6F8 File Offset: 0x0082D8F8
		protected O2MFKAssignmentControlInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x0082F710 File Offset: 0x0082D910
		public override void Init()
		{
			int a_ = 3;
			short num = (short)662497614;
			short num2 = num;
			num = (short)163899726;
			switch (num2 == num)
			{
			}
			num = (short)280100864;
			if (num != 0)
			{
			}
			num = (short)1420689409;
			if (num != 0)
			{
			}
			num = (short)683147264;
			short num3 = num;
			this.o2MFKAssignmentControlName_A41274 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("诃藇賉蟋迍ꏏꇑ뷓뇕뛗럙맛냝铟ꇡ诣裥鳧飩菫苭뻯鏱駳鏵ꟷ믹죻쿽㋿㔁〃", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.o2MFKAssignmentControlName_A41274.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o2MFKAssignmentControlName_A41274.DataTransferOrder = -1;
			this.radErgoControlO2MFKFeatureAssignment_A41275 = new global::AcpBusinessLayer.AcpSparseLOVField(23, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2MFKFeatureAssignment_A41275LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2MFKFeatureAssignment_A41275LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金믓룕곗꣙돛닝꿟탡ꧣꃥꏧ곩觫迭蓯蟱蛳鏵맷觹迻韽柿氁椃挅昇縉匋伍␏⌑☓ℕⴗ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2MFKFeatureAssignment_A41275LovStrs);
			this.radErgoControlO2MFKFeatureAssignment_A41275.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO2MFKFeatureAssignment_A41275.DataTransferOrder = 1;
			this.radErgoControlO2MFKFeatureAssignment_A41275.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觃胅菇黋ꇍ꓏돑ꛓ꿕駙돛냝铟郡诣諥", a_);
			base.Id = 10726;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x0082F88C File Offset: 0x0082DA8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1412431878;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A1;
				case 1:
					num = (short)753467394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賂諆迈胊賌볎ꋐ뫒닔맖듘뻚돜ꯞꋠ賢诤鏦鯨蓪臬ꇮ郰黲郴ꣶ룸쿺쳼췾㘀㜂", a_)))
					{
						num = (short)1679294468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A1;
				case 3:
					if (producerFields != null)
					{
						num = (short)1625882625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				case 4:
					this.o2MFKAssignmentControlName_A41274 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("賂諆迈胊賌볎ꋐ뫒닔맖듘뻚돜ꯞꋠ賢诤鏦鯨蓪臬ꇮ郰黲郴ꣶ룸쿺쳼췾㘀㜂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.o2MFKAssignmentControlName_A41274.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o2MFKAssignmentControlName_A41274.DataTransferOrder = -1;
					num = (short)298647552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radErgoControlO2MFKFeatureAssignment_A41275 = new global::AcpBusinessLayer.AcpSparseLOVField(23, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexRadErgoControlO2MFKFeatureAssignment_A41275LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idRadErgoControlO2MFKFeatureAssignment_A41275LovStrs), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐볒믔ꏖꯘ듚뇜郞폠껢ꏤ곦꿨軪賬鯮蓰臲郴뛶諸裺铼飾漀渂怄椆紈吊䰌㬎‐ℒ∔∖", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.RadErgoControlO2MFKFeatureAssignment_A41275LovStrs);
					this.radErgoControlO2MFKFeatureAssignment_A41275.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO2MFKFeatureAssignment_A41275.DataTransferOrder = 1;
					this.radErgoControlO2MFKFeatureAssignment_A41275.ValidateAcrossRecset = true;
					num = (short)1294073863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 7:
					goto IL_261;
				case 8:
					num = (short)357761027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)243137374;
					short num3 = num;
					num = (short)1589115742;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_261;
					default:
						num = (short)720897;
						if (num != 0)
						{
						}
						num = (short)2127953920;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐볒믔ꏖꯘ듚뇜郞폠껢ꏤ곦꿨軪賬鯮蓰臲郴뛶諸裺铼飾漀渂怄椆紈吊䰌㬎‐ℒ∔∖", a_)))
						{
							num = (short)1369571333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
					}
					break;
				}
				}
				IL_55:
				num = (short)1870462976;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2065891336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A1:
				num = (short)948895753;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_261:
			IL_2AF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軂菄賆駊ꋌ믎냐ꇒ곔高듚돜ꯞ鏠賢觤", a_);
			base.Id = 10726;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x0082FB7C File Offset: 0x0082DD7C
		public override void PopulateReferences()
		{
			short num = (short)749993985;
			if (num != 0)
			{
			}
			num = (short)428789117;
			short num2 = num;
			num = (short)1569574269;
			switch (num2 == num)
			{
			}
			num = (short)2038038528;
			if (num != 0)
			{
			}
			num = (short)1704001536;
			short num3 = num;
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x0082FC24 File Offset: 0x0082DE24
		public override void DropReferences()
		{
			short num = (short)2131042071;
			short num2 = num;
			num = (short)1863589655;
			switch (num2 == num)
			{
			}
			num = (short)1760624641;
			if (num != 0)
			{
			}
			num = (short)1022558208;
			if (num != 0)
			{
			}
			num = (short)425394176;
			short num3 = num;
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x0082FCCC File Offset: 0x0082DECC
		public override void SetConstraints()
		{
			short num = (short)636066947;
			short num2 = num;
			num = (short)1718328451;
			switch (num2 == num)
			{
			}
			num = (short)740884481;
			if (num != 0)
			{
			}
			num = (short)1133379584;
			if (num != 0)
			{
			}
			num = (short)2026962944;
			short num3 = num;
			this.o2MFKAssignmentControlName_A41274.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO2MFKFeatureAssignment_A41275.ValidateAcrossRecset = true;
			this.radErgoControlO2MFKFeatureAssignment_A41275.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConPrimaryFunctionIsNonBlankO2);
			this.radErgoControlO2MFKFeatureAssignment_A41275.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConValidityMFKAssignControlO2);
			this.radErgoControlO2MFKFeatureAssignment_A41275.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConSynSwitchMFKWithO2);
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x0082FDDC File Offset: 0x0082DFDC
		public override void SetupDependencies()
		{
			short num = (short)1706276795;
			short num2 = num;
			num = (short)795719611;
			switch (num2 == num)
			{
			}
			num = (short)1544683521;
			if (num != 0)
			{
			}
			num = (short)1124270080;
			if (num != 0)
			{
			}
			num = (short)1900609536;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoControlO2MFKFeatureAssignment_A41275);
		}

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x0082FEA4 File Offset: 0x0082E0A4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1901140556;
				short num2 = num;
				num = (short)64821836;
				switch (num2 == num)
				{
				}
				num = (short)196476928;
				if (num != 0)
				{
				}
				num = (short)1212284929;
				if (num != 0)
				{
				}
				num = (short)660602880;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x0082FF54 File Offset: 0x0082E154
		// (set) Token: 0x06008BF8 RID: 35832 RVA: 0x0083000C File Offset: 0x0082E20C
		public string O2MFKAssignmentControlName_A41274Value
		{
			get
			{
				short num = (short)183101403;
				short num2 = num;
				num = (short)252569563;
				switch (num2 == num)
				{
				}
				num = (short)2003501056;
				if (num != 0)
				{
				}
				num = (short)96403457;
				if (num != 0)
				{
				}
				num = (short)410189824;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Value;
			}
			set
			{
				short num = (short)666399558;
				short num2 = num;
				num = (short)1086550854;
				switch (num2 == num)
				{
				}
				num = (short)293470208;
				if (num != 0)
				{
				}
				num = (short)1859190785;
				if (num != 0)
				{
				}
				num = (short)115736576;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Value = value;
			}
		}

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x008300C0 File Offset: 0x0082E2C0
		public global::AcpBusinessLayer.AcpField<string> O2MFKAssignmentControlName_A41274
		{
			get
			{
				short num = (short)1929904129;
				if (num != 0)
				{
				}
				num = (short)1236585692;
				short num2 = num;
				num = (short)1992019164;
				switch (num2 == num)
				{
				}
				num = (short)149749760;
				if (num != 0)
				{
				}
				num = (short)293535744;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x06008BFA RID: 35834 RVA: 0x00830170 File Offset: 0x0082E370
		// (set) Token: 0x06008BFB RID: 35835 RVA: 0x00830224 File Offset: 0x0082E424
		public string O2MFKAssignmentControlName_A41274_UIValue
		{
			get
			{
				short num = (short)163859720;
				short num2 = num;
				num = (short)771443976;
				switch (num2 == num)
				{
				}
				num = (short)275709953;
				if (num != 0)
				{
				}
				num = (short)1137311744;
				if (num != 0)
				{
				}
				num = (short)452395008;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Value;
			}
			set
			{
				short num = (short)1797138372;
				short num2 = num;
				num = (short)1880106948;
				switch (num2 == num)
				{
				}
				num = (short)373882881;
				if (num != 0)
				{
				}
				num = (short)520617984;
				if (num != 0)
				{
				}
				num = (short)1524039680;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Value = value;
			}
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x008302D8 File Offset: 0x0082E4D8
		// (set) Token: 0x06008BFD RID: 35837 RVA: 0x00830390 File Offset: 0x0082E590
		public bool O2MFKAssignmentControlName_A41274_Applicable
		{
			get
			{
				short num = (short)1944536551;
				short num2 = num;
				num = (short)1233208807;
				switch (num2 == num)
				{
				}
				num = (short)1520500737;
				if (num != 0)
				{
				}
				num = (short)221249536;
				if (num != 0)
				{
				}
				num = (short)1109590016;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Applicable;
			}
			set
			{
				short num = (short)1646533919;
				short num2 = num;
				num = (short)490347807;
				switch (num2 == num)
				{
				}
				num = (short)1379467265;
				if (num != 0)
				{
				}
				num = (short)538968064;
				if (num != 0)
				{
				}
				num = (short)1274347520;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Applicable = value;
			}
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00830444 File Offset: 0x0082E644
		// (set) Token: 0x06008BFF RID: 35839 RVA: 0x008304FC File Offset: 0x0082E6FC
		public bool O2MFKAssignmentControlName_A41274_Valid
		{
			get
			{
				short num = (short)811500318;
				short num2 = num;
				num = (short)137331486;
				switch (num2 == num)
				{
				}
				num = (short)1115881473;
				if (num != 0)
				{
				}
				num = (short)804454400;
				if (num != 0)
				{
				}
				num = (short)1683619840;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Valid;
			}
			set
			{
				short num = (short)765162187;
				short num2 = num;
				num = (short)1623749323;
				switch (num2 == num)
				{
				}
				num = (short)1777205249;
				if (num != 0)
				{
				}
				num = (short)1101332480;
				if (num != 0)
				{
				}
				num = (short)1272709120;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Valid = value;
			}
		}

		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x06008C00 RID: 35840 RVA: 0x008305B4 File Offset: 0x0082E7B4
		// (set) Token: 0x06008C01 RID: 35841 RVA: 0x00830668 File Offset: 0x0082E868
		public bool O2MFKAssignmentControlName_A41274_Visible
		{
			get
			{
				short num = (short)1740046337;
				if (num != 0)
				{
				}
				num = (short)1385844352;
				short num2 = num;
				num = (short)44387968;
				switch (num2 == num)
				{
				}
				num = (short)808255488;
				if (num != 0)
				{
				}
				num = (short)39124992;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Visible;
			}
			set
			{
				short num = (short)2041321443;
				short num2 = num;
				num = (short)611653603;
				switch (num2 == num)
				{
				}
				num = (short)2050424833;
				if (num != 0)
				{
				}
				num = (short)991232000;
				if (num != 0)
				{
				}
				num = (short)1393295360;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Visible = value;
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x06008C02 RID: 35842 RVA: 0x0083071C File Offset: 0x0082E91C
		// (set) Token: 0x06008C03 RID: 35843 RVA: 0x008307D0 File Offset: 0x0082E9D0
		public bool O2MFKAssignmentControlName_A41274_Editable
		{
			get
			{
				short num = (short)2103777039;
				short num2 = num;
				num = (short)1097930511;
				switch (num2 == num)
				{
				}
				num = (short)1627652096;
				if (num != 0)
				{
				}
				num = (short)1483866113;
				if (num != 0)
				{
				}
				num = (short)282591232;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.Editable;
			}
			set
			{
				short num = (short)2119836999;
				short num2 = num;
				num = (short)1243030855;
				switch (num2 == num)
				{
				}
				num = (short)934215680;
				if (num != 0)
				{
				}
				num = (short)923795457;
				if (num != 0)
				{
				}
				num = (short)1242234880;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.Editable = value;
			}
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x06008C04 RID: 35844 RVA: 0x00830884 File Offset: 0x0082EA84
		internal string O2MFKAssignmentControlName_A41274_UILabel
		{
			get
			{
				short num = (short)1512909813;
				short num2 = num;
				num = (short)1883581429;
				switch (num2 == num)
				{
				}
				num = (short)1121845249;
				if (num != 0)
				{
				}
				num = (short)329777152;
				if (num != 0)
				{
				}
				num = (short)1941504000;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.UIName;
			}
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x06008C05 RID: 35845 RVA: 0x00830938 File Offset: 0x0082EB38
		// (set) Token: 0x06008C06 RID: 35846 RVA: 0x008309EC File Offset: 0x0082EBEC
		internal bool O2MFKAssignmentControlName_A41274_HiddenStatic
		{
			get
			{
				short num = (short)835730170;
				short num2 = num;
				num = (short)1293695738;
				switch (num2 == num)
				{
				}
				num = (short)1337720833;
				if (num != 0)
				{
				}
				num = (short)27131904;
				if (num != 0)
				{
				}
				num = (short)1808728064;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.HiddenStatic;
			}
			set
			{
				short num = (short)201726118;
				short num2 = num;
				num = (short)137566374;
				switch (num2 == num)
				{
				}
				num = (short)1652293633;
				if (num != 0)
				{
				}
				num = (short)1250754560;
				if (num != 0)
				{
				}
				num = (short)2140667904;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.HiddenStatic = value;
			}
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x06008C07 RID: 35847 RVA: 0x00830AA4 File Offset: 0x0082ECA4
		// (set) Token: 0x06008C08 RID: 35848 RVA: 0x00830B58 File Offset: 0x0082ED58
		internal bool O2MFKAssignmentControlName_A41274_HiddenDynamic
		{
			get
			{
				short num = (short)927695852;
				short num2 = num;
				num = (short)114656236;
				switch (num2 == num)
				{
				}
				num = (short)919404545;
				if (num != 0)
				{
				}
				num = (short)1931870208;
				if (num != 0)
				{
				}
				num = (short)613089280;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274.HiddenDynamic;
			}
			set
			{
				short num = (short)2146691539;
				short num2 = num;
				num = (short)1472915923;
				switch (num2 == num)
				{
				}
				num = (short)1608908800;
				if (num != 0)
				{
				}
				num = (short)1134755841;
				if (num != 0)
				{
				}
				num = (short)1885536256;
				short num3 = num;
				this.o2MFKAssignmentControlName_A41274.HiddenDynamic = value;
			}
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x00830C0C File Offset: 0x0082EE0C
		public bool O2MFKAssignmentControlName_A41274_HasDiffs
		{
			get
			{
				short num = (short)411051138;
				short num2 = num;
				num = (short)611525762;
				switch (num2 == num)
				{
				}
				num = (short)793837569;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				if (num != 0)
				{
				}
				num = (short)26345472;
				short num3 = num;
				return this.o2MFKAssignmentControlName_A41274._HasDiffs;
			}
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x00830CC0 File Offset: 0x0082EEC0
		// (set) Token: 0x06008C0B RID: 35851 RVA: 0x00830D78 File Offset: 0x0082EF78
		public int RadErgoControlO2MFKFeatureAssignment_A41275Value
		{
			get
			{
				short num = (short)352785034;
				short num2 = num;
				num = (short)2044924554;
				switch (num2 == num)
				{
				}
				num = (short)392495105;
				if (num != 0)
				{
				}
				num = (short)492437504;
				if (num != 0)
				{
				}
				num = (short)1210253312;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.Value;
			}
			set
			{
				short num = (short)492780466;
				short num2 = num;
				num = (short)290208690;
				switch (num2 == num)
				{
				}
				num = (short)344653824;
				if (num != 0)
				{
				}
				num = (short)425328641;
				if (num != 0)
				{
				}
				num = (short)906428416;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.Value = value;
			}
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x06008C0C RID: 35852 RVA: 0x00830E2C File Offset: 0x0082F02C
		// (set) Token: 0x06008C0D RID: 35853 RVA: 0x00830EE0 File Offset: 0x0082F0E0
		public string RadErgoControlO2MFKFeatureAssignment_A41275_UIValue
		{
			get
			{
				short num = (short)785005570;
				short num2 = num;
				num = (short)1038892034;
				switch (num2 == num)
				{
				}
				num = (short)397934593;
				if (num != 0)
				{
				}
				num = (short)1943601152;
				if (num != 0)
				{
				}
				num = (short)489095168;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.UIValue;
			}
			set
			{
				short num = (short)323081586;
				short num2 = num;
				num = (short)1080022386;
				switch (num2 == num)
				{
				}
				num = (short)2066219009;
				if (num != 0)
				{
				}
				num = (short)1026490368;
				if (num != 0)
				{
				}
				num = (short)2108817408;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.UIValue = value;
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x06008C0E RID: 35854 RVA: 0x00830F98 File Offset: 0x0082F198
		public global::AcpBusinessLayer.AcpListField RadErgoControlO2MFKFeatureAssignment_A41275
		{
			get
			{
				short num = (short)878523594;
				short num2 = num;
				num = (short)733623498;
				switch (num2 == num)
				{
				}
				num = (short)741277697;
				if (num != 0)
				{
				}
				num = (short)225312768;
				if (num != 0)
				{
				}
				num = (short)1551237120;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275;
			}
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x00831044 File Offset: 0x0082F244
		// (set) Token: 0x06008C10 RID: 35856 RVA: 0x008310FC File Offset: 0x0082F2FC
		public bool RadErgoControlO2MFKFeatureAssignment_A41275_Applicable
		{
			get
			{
				short num = (short)1909980344;
				short num2 = num;
				num = (short)1460141240;
				switch (num2 == num)
				{
				}
				num = (short)1914896384;
				if (num != 0)
				{
				}
				num = (short)282329089;
				if (num != 0)
				{
				}
				num = (short)468123648;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.Applicable;
			}
			set
			{
				short num = (short)1383431074;
				short num2 = num;
				num = (short)1945140130;
				switch (num2 == num)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				num = (short)1389559809;
				if (num != 0)
				{
				}
				num = (short)1355808768;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.Applicable = value;
			}
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x06008C11 RID: 35857 RVA: 0x008311B4 File Offset: 0x0082F3B4
		// (set) Token: 0x06008C12 RID: 35858 RVA: 0x0083126C File Offset: 0x0082F46C
		public bool RadErgoControlO2MFKFeatureAssignment_A41275_Valid
		{
			get
			{
				short num = (short)1990536941;
				short num2 = num;
				num = (short)47984365;
				switch (num2 == num)
				{
				}
				num = (short)1083310081;
				if (num != 0)
				{
				}
				num = (short)1490288640;
				if (num != 0)
				{
				}
				num = (short)2024996864;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.Valid;
			}
			set
			{
				short num = (short)1316679677;
				short num2 = num;
				num = (short)2617341;
				switch (num2 == num)
				{
				}
				num = (short)1912143873;
				if (num != 0)
				{
				}
				num = (short)1384513536;
				if (num != 0)
				{
				}
				num = (short)1383989248;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.Valid = value;
			}
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x00831320 File Offset: 0x0082F520
		// (set) Token: 0x06008C14 RID: 35860 RVA: 0x008313D4 File Offset: 0x0082F5D4
		public bool RadErgoControlO2MFKFeatureAssignment_A41275_Visible
		{
			get
			{
				short num = (short)1853295971;
				short num2 = num;
				num = (short)391974243;
				switch (num2 == num)
				{
				}
				num = (short)1283981313;
				if (num != 0)
				{
				}
				num = (short)1608581120;
				if (num != 0)
				{
				}
				num = (short)1160904704;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.Visible;
			}
			set
			{
				short num = (short)87293953;
				if (num != 0)
				{
				}
				num = (short)950600083;
				short num2 = num;
				num = (short)519176595;
				switch (num2 == num)
				{
				}
				num = (short)472383488;
				if (num != 0)
				{
				}
				num = (short)1253113856;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.Visible = value;
			}
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x06008C15 RID: 35861 RVA: 0x0083148C File Offset: 0x0082F68C
		// (set) Token: 0x06008C16 RID: 35862 RVA: 0x0083153C File Offset: 0x0082F73C
		public bool RadErgoControlO2MFKFeatureAssignment_A41275_Editable
		{
			get
			{
				short num = (short)1404557088;
				short num2 = num;
				num = (short)2006046496;
				switch (num2 == num)
				{
				}
				num = (short)1902247937;
				if (num != 0)
				{
				}
				num = (short)2106327040;
				if (num != 0)
				{
				}
				num = (short)324468736;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.Editable;
			}
			set
			{
				short num = (short)196965899;
				short num2 = num;
				num = (short)1332770315;
				switch (num2 == num)
				{
				}
				num = (short)1615593473;
				if (num != 0)
				{
				}
				num = (short)1787625472;
				if (num != 0)
				{
				}
				num = (short)1685913600;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.Editable = value;
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x008315F0 File Offset: 0x0082F7F0
		internal string RadErgoControlO2MFKFeatureAssignment_A41275_UILabel
		{
			get
			{
				short num = (short)648740865;
				if (num != 0)
				{
				}
				num = (short)1449293006;
				short num2 = num;
				num = (short)200701134;
				switch (num2 == num)
				{
				}
				num = (short)865861632;
				if (num != 0)
				{
				}
				num = (short)2102263808;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.UIName;
			}
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x06008C18 RID: 35864 RVA: 0x008316A4 File Offset: 0x0082F8A4
		// (set) Token: 0x06008C19 RID: 35865 RVA: 0x0083175C File Offset: 0x0082F95C
		internal bool RadErgoControlO2MFKFeatureAssignment_A41275_HiddenStatic
		{
			get
			{
				short num = (short)365651199;
				short num2 = num;
				num = (short)557343999;
				switch (num2 == num)
				{
				}
				num = (short)1152974849;
				if (num != 0)
				{
				}
				num = (short)1333919744;
				if (num != 0)
				{
				}
				num = (short)330432512;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.HiddenStatic;
			}
			set
			{
				short num = (short)1825046529;
				if (num != 0)
				{
				}
				num = (short)505352782;
				short num2 = num;
				num = (short)61018702;
				switch (num2 == num)
				{
				}
				num = (short)143720448;
				if (num != 0)
				{
				}
				num = (short)2072510464;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.HiddenStatic = value;
			}
		}

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x06008C1A RID: 35866 RVA: 0x00831814 File Offset: 0x0082FA14
		// (set) Token: 0x06008C1B RID: 35867 RVA: 0x008318CC File Offset: 0x0082FACC
		internal bool RadErgoControlO2MFKFeatureAssignment_A41275_HiddenDynamic
		{
			get
			{
				short num = (short)792199169;
				if (num != 0)
				{
				}
				num = (short)881970391;
				short num2 = num;
				num = (short)863882455;
				switch (num2 == num)
				{
				}
				num = (short)485031936;
				if (num != 0)
				{
				}
				num = (short)925696000;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275.HiddenDynamic;
			}
			set
			{
				short num = (short)2106851329;
				if (num != 0)
				{
				}
				num = (short)1078598715;
				short num2 = num;
				num = (short)1866669115;
				switch (num2 == num)
				{
				}
				num = (short)1440612352;
				if (num != 0)
				{
				}
				num = (short)1755119616;
				short num3 = num;
				this.radErgoControlO2MFKFeatureAssignment_A41275.HiddenDynamic = value;
			}
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x06008C1C RID: 35868 RVA: 0x00831980 File Offset: 0x0082FB80
		public bool RadErgoControlO2MFKFeatureAssignment_A41275_HasDiffs
		{
			get
			{
				short num = (short)1167346770;
				short num2 = num;
				num = (short)807423058;
				switch (num2 == num)
				{
				}
				num = (short)544866305;
				if (num != 0)
				{
				}
				num = (short)633405440;
				if (num != 0)
				{
				}
				num = (short)1099759616;
				short num3 = num;
				return this.radErgoControlO2MFKFeatureAssignment_A41275._HasDiffs;
			}
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x06008C1D RID: 35869 RVA: 0x00831A34 File Offset: 0x0082FC34
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1696480319;
				short num2 = num;
				num = (short)107428927;
				switch (num2 == num)
				{
				}
				num = (short)371261440;
				if (num != 0)
				{
				}
				num = (short)558039041;
				if (num != 0)
				{
				}
				num = (short)385220608;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00831AF4 File Offset: 0x0082FCF4
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
					IL_9E:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)287834113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C6;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)773455875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1425735680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_C6;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)909115394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C6;
				}
				goto IL_24;
				IL_C6:
				num2 = (short)726779116;
				short num3 = num2;
				num2 = (short)545375468;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9E;
				default:
					goto IL_FB;
				}
			}
			IL_FB:
			num2 = (short)2008678401;
			if (num2 != 0)
			{
			}
			num2 = (short)2077163520;
			if (num2 != 0)
			{
			}
			num2 = (short)1322844160;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1901592580;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040043E9 RID: 17385
		private global::AcpBusinessLayer.AcpField<string> o2MFKAssignmentControlName_A41274;

		// Token: 0x040043EA RID: 17386
		private global::AcpBusinessLayer.AcpListField radErgoControlO2MFKFeatureAssignment_A41275;
	}
}
