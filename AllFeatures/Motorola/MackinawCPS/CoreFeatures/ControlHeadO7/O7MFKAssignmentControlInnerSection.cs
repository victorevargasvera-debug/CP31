using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A2 RID: 930
	[global::System.Serializable]
	public class O7MFKAssignmentControlInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060087D5 RID: 34773 RVA: 0x007E77C4 File Offset: 0x007E59C4
		public O7MFKAssignmentControlInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x007E77E0 File Offset: 0x007E59E0
		protected O7MFKAssignmentControlInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x007E77F8 File Offset: 0x007E59F8
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1300239609;
			short num2 = num;
			num = (short)1348539641;
			switch (num2 == num)
			{
			}
			num = (short)692781056;
			short num3 = num;
			num = (short)1716781057;
			if (num != 0)
			{
			}
			num = (short)616366080;
			if (num != 0)
			{
			}
			this.o7MFKAssignmentControlName_A41294 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("诃藇賉蟋迍ꏏꇑ뷓뇕뛗럙맛냝铟ꇡ诣裥鳧飩菫苭뻯鏱駳鏵ꟷ믹죻쿽㋿㬁〃", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.o7MFKAssignmentControlName_A41294.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o7MFKAssignmentControlName_A41294.DataTransferOrder = -1;
			this.radErgoControlO7MFKFeatureAssignment_A41295 = new global::AcpBusinessLayer.AcpSparseLOVField(23, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7MFKFeatureAssignment_A41295LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7MFKFeatureAssignment_A41295LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金믓룕곗꣙돛닝꿟헡ꧣꃥꏧ곩觫迭蓯蟱蛳鏵맷觹迻韽柿氁椃挅昇縉匋伍␏⌑☓⼕ⴗ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7MFKFeatureAssignment_A41295LovStrs);
			this.radErgoControlO7MFKFeatureAssignment_A41295.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO7MFKFeatureAssignment_A41295.DataTransferOrder = 18;
			this.radErgoControlO7MFKFeatureAssignment_A41295.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觃胅菇黋ꇍ꓏돑ꛓ꿕駙돛냝铟郡诣諥", a_);
			base.Id = 10724;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x007E7974 File Offset: 0x007E5B74
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1369178119;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_266;
				case 1:
					num = (short)2067136521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1797755249;
					short num3 = num;
					num = (short)1885901169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						num = (short)443088896;
						if (num != 0)
						{
						}
						num = (short)1117519873;
						if (num != 0)
						{
						}
						num = (short)1067450374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_A3;
				case 4:
					this.radErgoControlO7MFKFeatureAssignment_A41295 = new global::AcpBusinessLayer.AcpSparseLOVField(23, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7MFKFeatureAssignment_A41295LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7MFKFeatureAssignment_A41295LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\udaecꋮ런룲돴鋶飸迺裼跾搀䈂瘄理怈氊挌戎琐紒愔䠖堘⼚Ⱌⴞᠠᘢ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7MFKFeatureAssignment_A41295LovStrs);
					this.radErgoControlO7MFKFeatureAssignment_A41295.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlO7MFKFeatureAssignment_A41295.DataTransferOrder = 18;
					this.radErgoControlO7MFKFeatureAssignment_A41295.ValidateAcrossRecset = true;
					num = (short)1197867008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\udaecꋮ런룲돴鋶飸迺裼跾搀䈂瘄理怈氊挌戎琐紒愔䠖堘⼚Ⱌⴞᠠᘢ", a_)))
					{
						num = (short)66191364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B6;
				case 6:
					if (producerFields != null)
					{
						num = (short)630849537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B6;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
					this.o7MFKAssignmentControlName_A41294 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("胎黒鏔鳖飘꣚껜뛞蛠跢裤苦蟨鿪껬胮鿰蟲蟴飶闸뗺鳼鋾搀専䐄㌆㠈㤊㐌㬎", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.o7MFKAssignmentControlName_A41294.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o7MFKAssignmentControlName_A41294.DataTransferOrder = -1;
					num = (short)223346691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胎黒鏔鳖飘꣚껜뛞蛠跢裤苦蟨鿪껬胮鿰蟲蟴飶闸뗺鳼鋾搀専䐄㌆㠈㤊㐌㬎", a_)))
					{
						num = (short)1340145672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
				}
				goto IL_56;
				IL_8A:
				num = (short)2027552770;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56:
				num = (short)2037448704;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_8A;
				}
				break;
				IL_A3:
				num = (short)1019609093;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_266:
			IL_2B6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苎韐飒藖뛘꿚볜귞飠쏢ꛤ裦蟨鿪鿬胮鷰", a_);
			base.Id = 10724;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x007E7C68 File Offset: 0x007E5E68
		public override void PopulateReferences()
		{
			short num = (short)230105543;
			short num2 = num;
			num = (short)320741831;
			switch (num2 == num)
			{
			}
			num = (short)1309081600;
			short num3 = num;
			num = (short)1251278848;
			if (num != 0)
			{
			}
			num = (short)885194753;
			if (num != 0)
			{
			}
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x007E7D10 File Offset: 0x007E5F10
		public override void DropReferences()
		{
			short num = (short)1244897390;
			short num2 = num;
			num = (short)1200136302;
			switch (num2 == num)
			{
			}
			num = (short)770113536;
			short num3 = num;
			num = (short)1205862401;
			if (num != 0)
			{
			}
			num = (short)199294976;
			if (num != 0)
			{
			}
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x007E7DB8 File Offset: 0x007E5FB8
		public override void SetConstraints()
		{
			short num = (short)410418422;
			short num2 = num;
			num = (short)966098166;
			switch (num2 == num)
			{
			}
			num = (short)1714814976;
			short num3 = num;
			num = (short)1148256257;
			if (num != 0)
			{
			}
			num = (short)516030464;
			if (num != 0)
			{
			}
			this.o7MFKAssignmentControlName_A41294.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO7MFKFeatureAssignment_A41295.ValidateAcrossRecset = true;
			this.radErgoControlO7MFKFeatureAssignment_A41295.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConPrimaryFunctionIsNonBlankO7);
			this.radErgoControlO7MFKFeatureAssignment_A41295.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConValidityMFKAssignControlO7);
			this.radErgoControlO7MFKFeatureAssignment_A41295.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConSynSwitchMFKWithO7);
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x007E7EC8 File Offset: 0x007E60C8
		public override void SetupDependencies()
		{
			short num = (short)455381364;
			short num2 = num;
			num = (short)1779077492;
			switch (num2 == num)
			{
			}
			num = (short)1263730688;
			short num3 = num;
			num = (short)391905280;
			if (num != 0)
			{
			}
			num = (short)1411710977;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x060087DD RID: 34781 RVA: 0x007E7F70 File Offset: 0x007E6170
		public bool HasDiffs
		{
			get
			{
				short num = (short)1937616801;
				short num2 = num;
				num = (short)1593552801;
				switch (num2 == num)
				{
				}
				num = (short)94896128;
				short num3 = num;
				num = (short)678887425;
				if (num != 0)
				{
				}
				num = (short)1052442624;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x060087DE RID: 34782 RVA: 0x007E801C File Offset: 0x007E621C
		// (set) Token: 0x060087DF RID: 34783 RVA: 0x007E80D0 File Offset: 0x007E62D0
		public string O7MFKAssignmentControlName_A41294Value
		{
			get
			{
				short num = (short)279759325;
				short num2 = num;
				num = (short)2084424157;
				switch (num2 == num)
				{
				}
				num = (short)404750336;
				short num3 = num;
				num = (short)8519681;
				if (num != 0)
				{
				}
				num = (short)1954152448;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Value;
			}
			set
			{
				short num = (short)1460600510;
				short num2 = num;
				num = (short)1187643070;
				switch (num2 == num)
				{
				}
				num = (short)1630142464;
				short num3 = num;
				num = (short)1883045888;
				if (num != 0)
				{
				}
				num = (short)2136997889;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Value = value;
			}
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x060087E0 RID: 34784 RVA: 0x007E8184 File Offset: 0x007E6384
		public global::AcpBusinessLayer.AcpField<string> O7MFKAssignmentControlName_A41294
		{
			get
			{
				short num = (short)1131999457;
				short num2 = num;
				num = (short)149614817;
				switch (num2 == num)
				{
				}
				num = (short)1042743296;
				short num3 = num;
				num = (short)515702785;
				if (num != 0)
				{
				}
				num = (short)589627392;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294;
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x060087E1 RID: 34785 RVA: 0x007E8234 File Offset: 0x007E6434
		// (set) Token: 0x060087E2 RID: 34786 RVA: 0x007E82EC File Offset: 0x007E64EC
		public string O7MFKAssignmentControlName_A41294_UIValue
		{
			get
			{
				short num = (short)1943634141;
				short num2 = num;
				num = (short)1660453085;
				switch (num2 == num)
				{
				}
				num = (short)1476984832;
				short num3 = num;
				num = (short)1756168192;
				if (num != 0)
				{
				}
				num = (short)2049048577;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Value;
			}
			set
			{
				short num = (short)1991171324;
				short num2 = num;
				num = (short)1192549628;
				switch (num2 == num)
				{
				}
				num = (short)1728184320;
				short num3 = num;
				num = (short)1707737088;
				if (num != 0)
				{
				}
				num = (short)1939275777;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Value = value;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x060087E3 RID: 34787 RVA: 0x007E83A4 File Offset: 0x007E65A4
		// (set) Token: 0x060087E4 RID: 34788 RVA: 0x007E8458 File Offset: 0x007E6658
		public bool O7MFKAssignmentControlName_A41294_Applicable
		{
			get
			{
				short num = (short)122861168;
				short num2 = num;
				num = (short)1088730736;
				switch (num2 == num)
				{
				}
				num = (short)2141913088;
				short num3 = num;
				num = (short)400031745;
				if (num != 0)
				{
				}
				num = (short)1329659904;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Applicable;
			}
			set
			{
				short num = (short)1738614639;
				short num2 = num;
				num = (short)1176643439;
				switch (num2 == num)
				{
				}
				num = (short)123404288;
				short num3 = num;
				num = (short)2014248961;
				if (num != 0)
				{
				}
				num = (short)1772945408;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Applicable = value;
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x060087E5 RID: 34789 RVA: 0x007E8510 File Offset: 0x007E6710
		// (set) Token: 0x060087E6 RID: 34790 RVA: 0x007E85C8 File Offset: 0x007E67C8
		public bool O7MFKAssignmentControlName_A41294_Valid
		{
			get
			{
				short num = (short)1667990259;
				short num2 = num;
				num = (short)1505133299;
				switch (num2 == num)
				{
				}
				num = (short)433586176;
				short num3 = num;
				num = (short)1944125441;
				if (num != 0)
				{
				}
				num = (short)873791488;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Valid;
			}
			set
			{
				short num = (short)1273757697;
				if (num != 0)
				{
				}
				num = (short)651955904;
				short num2 = num;
				num = (short)1823346368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1509163008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2043609088;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Valid = value;
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x060087E7 RID: 34791 RVA: 0x007E8680 File Offset: 0x007E6880
		// (set) Token: 0x060087E8 RID: 34792 RVA: 0x007E8738 File Offset: 0x007E6938
		public bool O7MFKAssignmentControlName_A41294_Visible
		{
			get
			{
				short num = (short)933165006;
				short num2 = num;
				num = (short)761919438;
				switch (num2 == num)
				{
				}
				num = (short)198574080;
				short num3 = num;
				num = (short)1147273217;
				if (num != 0)
				{
				}
				num = (short)2116550656;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Visible;
			}
			set
			{
				short num = (short)1332535752;
				short num2 = num;
				num = (short)1761736;
				switch (num2 == num)
				{
				}
				num = (short)1131479040;
				short num3 = num;
				num = (short)922615808;
				if (num != 0)
				{
				}
				num = (short)1038548993;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Visible = value;
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x060087E9 RID: 34793 RVA: 0x007E87E8 File Offset: 0x007E69E8
		// (set) Token: 0x060087EA RID: 34794 RVA: 0x007E889C File Offset: 0x007E6A9C
		public bool O7MFKAssignmentControlName_A41294_Editable
		{
			get
			{
				short num = (short)111353266;
				short num2 = num;
				num = (short)1943150002;
				switch (num2 == num)
				{
				}
				num = (short)546963456;
				short num3 = num;
				num = (short)250347521;
				if (num != 0)
				{
				}
				num = (short)493944832;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.Editable;
			}
			set
			{
				short num = (short)367918589;
				short num2 = num;
				num = (short)545652221;
				switch (num2 == num)
				{
				}
				num = (short)1228341248;
				short num3 = num;
				num = (short)813694976;
				if (num != 0)
				{
				}
				num = (short)97320961;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.Editable = value;
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x060087EB RID: 34795 RVA: 0x007E8954 File Offset: 0x007E6B54
		internal string O7MFKAssignmentControlName_A41294_UILabel
		{
			get
			{
				short num = (short)164234477;
				short num2 = num;
				num = (short)90047725;
				switch (num2 == num)
				{
				}
				num = (short)656605184;
				short num3 = num;
				num = (short)538181632;
				if (num != 0)
				{
				}
				num = (short)886964225;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.UIName;
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x060087EC RID: 34796 RVA: 0x007E8A08 File Offset: 0x007E6C08
		// (set) Token: 0x060087ED RID: 34797 RVA: 0x007E8ABC File Offset: 0x007E6CBC
		internal bool O7MFKAssignmentControlName_A41294_HiddenStatic
		{
			get
			{
				short num = (short)597000941;
				short num2 = num;
				num = (short)1186628333;
				switch (num2 == num)
				{
				}
				num = (short)646709248;
				short num3 = num;
				num = (short)473956353;
				if (num != 0)
				{
				}
				num = (short)1060634624;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.HiddenStatic;
			}
			set
			{
				short num = (short)237188712;
				short num2 = num;
				num = (short)668022376;
				switch (num2 == num)
				{
				}
				num = (short)1932722176;
				short num3 = num;
				num = (short)1207697408;
				if (num != 0)
				{
				}
				num = (short)2061107201;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.HiddenStatic = value;
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x060087EE RID: 34798 RVA: 0x007E8B70 File Offset: 0x007E6D70
		// (set) Token: 0x060087EF RID: 34799 RVA: 0x007E8C24 File Offset: 0x007E6E24
		internal bool O7MFKAssignmentControlName_A41294_HiddenDynamic
		{
			get
			{
				short num = (short)2012108290;
				short num2 = num;
				num = (short)1628067330;
				switch (num2 == num)
				{
				}
				num = (short)1724252160;
				short num3 = num;
				num = (short)1006043136;
				if (num != 0)
				{
				}
				num = (short)1279918081;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294.HiddenDynamic;
			}
			set
			{
				short num = (short)1789431927;
				short num2 = num;
				num = (short)385454199;
				switch (num2 == num)
				{
				}
				num = (short)1786118144;
				short num3 = num;
				num = (short)189988865;
				if (num != 0)
				{
				}
				num = (short)160694272;
				if (num != 0)
				{
				}
				this.o7MFKAssignmentControlName_A41294.HiddenDynamic = value;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x060087F0 RID: 34800 RVA: 0x007E8CDC File Offset: 0x007E6EDC
		public bool O7MFKAssignmentControlName_A41294_HasDiffs
		{
			get
			{
				short num = (short)2050803515;
				short num2 = num;
				num = (short)687523643;
				switch (num2 == num)
				{
				}
				num = (short)1026424832;
				short num3 = num;
				num = (short)1509228544;
				if (num != 0)
				{
				}
				num = (short)2006515713;
				if (num != 0)
				{
				}
				return this.o7MFKAssignmentControlName_A41294._HasDiffs;
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x060087F1 RID: 34801 RVA: 0x007E8D90 File Offset: 0x007E6F90
		// (set) Token: 0x060087F2 RID: 34802 RVA: 0x007E8E48 File Offset: 0x007E7048
		public int RadErgoControlO7MFKFeatureAssignment_A41295Value
		{
			get
			{
				short num = (short)230080915;
				short num2 = num;
				num = (short)1957085587;
				switch (num2 == num)
				{
				}
				num = (short)1549336576;
				short num3 = num;
				num = (short)625672192;
				if (num != 0)
				{
				}
				num = (short)565116929;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.Value;
			}
			set
			{
				short num = (short)1668604270;
				short num2 = num;
				num = (short)1168957806;
				switch (num2 == num)
				{
				}
				num = (short)244711424;
				short num3 = num;
				num = (short)877002753;
				if (num != 0)
				{
				}
				num = (short)1083572224;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.Value = value;
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x060087F3 RID: 34803 RVA: 0x007E8EFC File Offset: 0x007E70FC
		// (set) Token: 0x060087F4 RID: 34804 RVA: 0x007E8FAC File Offset: 0x007E71AC
		public string RadErgoControlO7MFKFeatureAssignment_A41295_UIValue
		{
			get
			{
				short num = (short)1625249593;
				short num2 = num;
				num = (short)2037012281;
				switch (num2 == num)
				{
				}
				num = (short)850657280;
				short num3 = num;
				num = (short)1935867905;
				if (num != 0)
				{
				}
				num = (short)1589837824;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.UIValue;
			}
			set
			{
				short num = (short)657774195;
				short num2 = num;
				num = (short)614389363;
				switch (num2 == num)
				{
				}
				num = (short)1359085568;
				short num3 = num;
				num = (short)1840513024;
				if (num != 0)
				{
				}
				num = (short)1312227329;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.UIValue = value;
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x007E9060 File Offset: 0x007E7260
		public global::AcpBusinessLayer.AcpListField RadErgoControlO7MFKFeatureAssignment_A41295
		{
			get
			{
				short num = (short)1363198508;
				short num2 = num;
				num = (short)123847212;
				switch (num2 == num)
				{
				}
				num = (short)1726480384;
				short num3 = num;
				num = (short)1734737921;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295;
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x007E9110 File Offset: 0x007E7310
		// (set) Token: 0x060087F7 RID: 34807 RVA: 0x007E91C4 File Offset: 0x007E73C4
		public bool RadErgoControlO7MFKFeatureAssignment_A41295_Applicable
		{
			get
			{
				short num = (short)780861441;
				if (num != 0)
				{
				}
				num = (short)1649955583;
				short num2 = num;
				num = (short)16339711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884880896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1029898240;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.Applicable;
			}
			set
			{
				short num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)659792366;
				short num2 = num;
				num = (short)568041966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669267456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1649999872;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.Applicable = value;
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x060087F8 RID: 34808 RVA: 0x007E9278 File Offset: 0x007E7478
		// (set) Token: 0x060087F9 RID: 34809 RVA: 0x007E932C File Offset: 0x007E752C
		public bool RadErgoControlO7MFKFeatureAssignment_A41295_Valid
		{
			get
			{
				short num = (short)1648152893;
				short num2 = num;
				num = (short)961466685;
				switch (num2 == num)
				{
				}
				num = (short)21233664;
				short num3 = num;
				num = (short)1492647937;
				if (num != 0)
				{
				}
				num = (short)1817772032;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.Valid;
			}
			set
			{
				short num = (short)358265793;
				short num2 = num;
				num = (short)472232897;
				switch (num2 == num)
				{
				}
				num = (short)230490112;
				short num3 = num;
				num = (short)564854784;
				if (num != 0)
				{
				}
				num = (short)2103705601;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.Valid = value;
			}
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x007E93E4 File Offset: 0x007E75E4
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x007E9498 File Offset: 0x007E7698
		public bool RadErgoControlO7MFKFeatureAssignment_A41295_Visible
		{
			get
			{
				short num = (short)150077616;
				short num2 = num;
				num = (short)934543536;
				switch (num2 == num)
				{
				}
				num = (short)758972416;
				short num3 = num;
				num = (short)1511653377;
				if (num != 0)
				{
				}
				num = (short)1985216512;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.Visible;
			}
			set
			{
				short num = (short)426850685;
				short num2 = num;
				num = (short)2007972221;
				switch (num2 == num)
				{
				}
				num = (short)2010972160;
				short num3 = num;
				num = (short)1651245057;
				if (num != 0)
				{
				}
				num = (short)1132068864;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.Visible = value;
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x007E9550 File Offset: 0x007E7750
		// (set) Token: 0x060087FD RID: 34813 RVA: 0x007E9604 File Offset: 0x007E7804
		public bool RadErgoControlO7MFKFeatureAssignment_A41295_Editable
		{
			get
			{
				short num = (short)167383243;
				short num2 = num;
				num = (short)1884754123;
				switch (num2 == num)
				{
				}
				num = (short)837681152;
				short num3 = num;
				num = (short)1036189696;
				if (num != 0)
				{
				}
				num = (short)618201089;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.Editable;
			}
			set
			{
				short num = (short)718049698;
				short num2 = num;
				num = (short)1405456802;
				switch (num2 == num)
				{
				}
				num = (short)1382612992;
				short num3 = num;
				num = (short)1504444417;
				if (num != 0)
				{
				}
				num = (short)61472768;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.Editable = value;
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x060087FE RID: 34814 RVA: 0x007E96B8 File Offset: 0x007E78B8
		internal string RadErgoControlO7MFKFeatureAssignment_A41295_UILabel
		{
			get
			{
				short num = (short)2076409256;
				short num2 = num;
				num = (short)286490024;
				switch (num2 == num)
				{
				}
				num = (short)1668218880;
				short num3 = num;
				num = (short)809828352;
				if (num != 0)
				{
				}
				num = (short)822673409;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.UIName;
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x060087FF RID: 34815 RVA: 0x007E9770 File Offset: 0x007E7970
		// (set) Token: 0x06008800 RID: 34816 RVA: 0x007E9824 File Offset: 0x007E7A24
		internal bool RadErgoControlO7MFKFeatureAssignment_A41295_HiddenStatic
		{
			get
			{
				short num = (short)472973643;
				short num2 = num;
				num = (short)1103364427;
				switch (num2 == num)
				{
				}
				num = (short)1659764736;
				short num3 = num;
				num = (short)1312817153;
				if (num != 0)
				{
				}
				num = (short)1332412416;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.HiddenStatic;
			}
			set
			{
				short num = (short)92531255;
				short num2 = num;
				num = (short)700181047;
				switch (num2 == num)
				{
				}
				num = (short)1474363392;
				short num3 = num;
				num = (short)971767809;
				if (num != 0)
				{
				}
				num = (short)1016856576;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.HiddenStatic = value;
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x06008801 RID: 34817 RVA: 0x007E98D8 File Offset: 0x007E7AD8
		// (set) Token: 0x06008802 RID: 34818 RVA: 0x007E9990 File Offset: 0x007E7B90
		internal bool RadErgoControlO7MFKFeatureAssignment_A41295_HiddenDynamic
		{
			get
			{
				short num = (short)563984685;
				short num2 = num;
				num = (short)1439086893;
				switch (num2 == num)
				{
				}
				num = (short)126681088;
				short num3 = num;
				num = (short)1577713664;
				if (num != 0)
				{
				}
				num = (short)824246273;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295.HiddenDynamic;
			}
			set
			{
				short num = (short)1968046081;
				if (num != 0)
				{
				}
				num = (short)108788628;
				short num2 = num;
				num = (short)397212564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1144913920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999568896;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKFeatureAssignment_A41295.HiddenDynamic = value;
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x007E9A48 File Offset: 0x007E7C48
		public bool RadErgoControlO7MFKFeatureAssignment_A41295_HasDiffs
		{
			get
			{
				short num = (short)1657192531;
				short num2 = num;
				num = (short)133873747;
				switch (num2 == num)
				{
				}
				num = (short)477495296;
				short num3 = num;
				num = (short)1703018497;
				if (num != 0)
				{
				}
				num = (short)483917824;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKFeatureAssignment_A41295._HasDiffs;
			}
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x007E9AFC File Offset: 0x007E7CFC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)1757999928;
					short num3 = num2;
					num2 = (short)1869607736;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1973157889;
						if (num2 != 0)
						{
						}
						num2 = (short)1772748800;
						short num4 = num2;
						num2 = (short)1574043648;
						if (num2 != 0)
						{
						}
						num2 = (short)245497859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1322844161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1258356740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)165216256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1587478530;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003FFC RID: 16380
		private global::AcpBusinessLayer.AcpField<string> o7MFKAssignmentControlName_A41294;

		// Token: 0x04003FFD RID: 16381
		private global::AcpBusinessLayer.AcpListField radErgoControlO7MFKFeatureAssignment_A41295;
	}
}
