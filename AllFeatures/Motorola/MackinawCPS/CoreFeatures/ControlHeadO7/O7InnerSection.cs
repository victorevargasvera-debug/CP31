using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039F RID: 927
	[global::System.Serializable]
	public class O7InnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008781 RID: 34689 RVA: 0x007E39D4 File Offset: 0x007E1BD4
		public O7InnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x007E39F0 File Offset: 0x007E1BF0
		protected O7InnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x007E3A08 File Offset: 0x007E1C08
		public override void Init()
		{
			int a_ = 8;
			short num = (short)983838962;
			short num2 = num;
			num = (short)2074292466;
			switch (num2 == num)
			{
			}
			num = (short)1146748928;
			if (num != 0)
			{
			}
			num = (short)800194561;
			if (num != 0)
			{
			}
			num = (short)595066880;
			short num3 = num;
			this.cHO7EmergencyButtonName_A41289 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꇮ郰黲郴ꣶ룸쿺쳼췾㤀㨂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO7EmergencyButtonName_A41289.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO7EmergencyButtonName_A41289.DataTransferOrder = -1;
			this.cHO7EmergencyButtonBCO_A41290 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexCHO7EmergencyButtonBCO_A41290LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idCHO7EmergencyButtonBCO_A41290LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬귮닰볲ꫴ뛶췸쫺쿼웾㄀", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.CHO7EmergencyButtonBCO_A41290LovStrs);
			this.cHO7EmergencyButtonBCO_A41290.IgnoreOnCompare = true;
			this.cHO7EmergencyButtonBCO_A41290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO7EmergencyButtonBCO_A41290.DataTransferOrder = -1;
			this.cHO7EmergencyButtonFeature_A41291 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexCHO7EmergencyButtonFeature_A41291LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idCHO7EmergencyButtonFeature_A41291LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꧮ铰鋲致苶诸黺ꋼ뻾㔀㈂㜄㸆㠈", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.CHO7EmergencyButtonFeature_A41291LovStrs);
			this.cHO7EmergencyButtonFeature_A41291.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO7EmergencyButtonFeature_A41291.DataTransferOrder = 17;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛈ﳊ", a_);
			base.Id = 10715;
			base.UIName = global::CommonResources.AcgResources.ID_O7;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x007E3BD4 File Offset: 0x007E1DD4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)808124424;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꧮ铰鋲致苶诸黺ꋼ뻾㔀㈂㜄㸆㠈", a_)))
					{
						num = (short)831127556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_379;
				case 1:
					this.cHO7EmergencyButtonBCO_A41290 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexCHO7EmergencyButtonBCO_A41290LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idCHO7EmergencyButtonBCO_A41290LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬귮닰볲ꫴ뛶췸쫺쿼웾㄀", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.CHO7EmergencyButtonBCO_A41290LovStrs);
					this.cHO7EmergencyButtonBCO_A41290.IgnoreOnCompare = true;
					this.cHO7EmergencyButtonBCO_A41290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO7EmergencyButtonBCO_A41290.DataTransferOrder = -1;
					num = (short)1970143237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2142175239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_FD;
				case 4:
					this.cHO7EmergencyButtonFeature_A41291 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexCHO7EmergencyButtonFeature_A41291LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idCHO7EmergencyButtonFeature_A41291LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꧮ铰鋲致苶诸黺ꋼ뻾㔀㈂㜄㸆㠈", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.CHO7EmergencyButtonFeature_A41291LovStrs);
					this.cHO7EmergencyButtonFeature_A41291.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO7EmergencyButtonFeature_A41291.DataTransferOrder = 17;
					num = (short)1837170698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2D4;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬귮닰볲ꫴ뛶췸쫺쿼웾㄀", a_)))
					{
						num = (short)1798701057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D4;
				case 7:
					goto IL_160;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 9:
					num = (short)1917845505;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)1143341058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_379;
				case 10:
					goto IL_26F;
				case 11:
				{
					num = (short)571958681;
					short num3 = num;
					num = (short)1212573081;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_160;
					default:
					{
						num = (short)698941440;
						short num4 = num;
						num = (short)1136721920;
						if (num != 0)
						{
						}
						this.cHO7EmergencyButtonName_A41289 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꇮ郰黲郴ꣶ룸쿺쳼췾㤀㨂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.cHO7EmergencyButtonName_A41289.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.cHO7EmergencyButtonName_A41289.DataTransferOrder = -1;
						num = (short)2098462723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 12:
					num = (short)1254031369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)804782092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FD:
				num = (short)1563361286;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_160:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈菊苌铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꇮ郰黲郴ꣶ룸쿺쳼췾㤀㨂", a_)))
				{
					num = (short)901447691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_FD;
				IL_2D4:
				num = (short)1060110336;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_26F:
			IL_379:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛈ﳊ", a_);
			base.Id = 10715;
			base.UIName = global::CommonResources.AcgResources.ID_O7;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x007E3F8C File Offset: 0x007E218C
		public override void PopulateReferences()
		{
			short num = (short)1131741185;
			if (num != 0)
			{
			}
			num = (short)1636046990;
			short num2 = num;
			num = (short)1489639566;
			switch (num2 == num)
			{
			}
			num = (short)2076377088;
			if (num != 0)
			{
			}
			num = (short)61669376;
			short num3 = num;
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x007E4038 File Offset: 0x007E2238
		public override void DropReferences()
		{
			short num = (short)1908491890;
			short num2 = num;
			num = (short)1589921394;
			switch (num2 == num)
			{
			}
			num = (short)1253376001;
			if (num != 0)
			{
			}
			num = (short)619708416;
			if (num != 0)
			{
			}
			num = (short)693764096;
			short num3 = num;
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x007E40E0 File Offset: 0x007E22E0
		public override void SetConstraints()
		{
			short num = (short)1233256449;
			if (num != 0)
			{
			}
			num = (short)447550528;
			short num2 = num;
			num = (short)117773376;
			switch (num2 == num)
			{
			}
			num = (short)723058688;
			if (num != 0)
			{
			}
			num = (short)115212288;
			short num3 = num;
			this.cHO7EmergencyButtonName_A41289.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO7EmergencyButtonFeature_A41291.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConControlHeadEmergencyFeaturesSelect);
			this.cHO7EmergencyButtonFeature_A41291.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConSyncOrangeBtn);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x007E41D0 File Offset: 0x007E23D0
		public override void SetupDependencies()
		{
			short num = (short)1112781396;
			short num2 = num;
			num = (short)188854868;
			switch (num2 == num)
			{
			}
			num = (short)1215561728;
			if (num != 0)
			{
			}
			num = (short)2057961473;
			if (num != 0)
			{
			}
			num = (short)355336192;
			short num3 = num;
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
			this.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
			this.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cHO7EmergencyButtonFeature_A41291);
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06008789 RID: 34697 RVA: 0x007E4320 File Offset: 0x007E2520
		public bool HasDiffs
		{
			get
			{
				short num = (short)294975475;
				short num2 = num;
				num = (short)1702623219;
				switch (num2 == num)
				{
				}
				num = (short)60882944;
				if (num != 0)
				{
				}
				num = (short)538312705;
				if (num != 0)
				{
				}
				num = (short)954400768;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x007E43D0 File Offset: 0x007E25D0
		// (set) Token: 0x0600878B RID: 34699 RVA: 0x007E4484 File Offset: 0x007E2684
		public string CHO7EmergencyButtonName_A41289Value
		{
			get
			{
				short num = (short)1000079361;
				if (num != 0)
				{
				}
				num = (short)980706805;
				short num2 = num;
				num = (short)380724725;
				switch (num2 == num)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				num = (short)1253769216;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Value;
			}
			set
			{
				short num = (short)256023577;
				short num2 = num;
				num = (short)1323932697;
				switch (num2 == num)
				{
				}
				num = (short)793903104;
				if (num != 0)
				{
				}
				num = (short)224067585;
				if (num != 0)
				{
				}
				num = (short)1537540096;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Value = value;
			}
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x0600878C RID: 34700 RVA: 0x007E4538 File Offset: 0x007E2738
		public global::AcpBusinessLayer.AcpField<string> CHO7EmergencyButtonName_A41289
		{
			get
			{
				short num = (short)1046285530;
				short num2 = num;
				num = (short)1985481946;
				switch (num2 == num)
				{
				}
				num = (short)2122252288;
				if (num != 0)
				{
				}
				num = (short)1091829761;
				if (num != 0)
				{
				}
				num = (short)1002242048;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289;
			}
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x0600878D RID: 34701 RVA: 0x007E45E8 File Offset: 0x007E27E8
		// (set) Token: 0x0600878E RID: 34702 RVA: 0x007E469C File Offset: 0x007E289C
		public string CHO7EmergencyButtonName_A41289_UIValue
		{
			get
			{
				short num = (short)461083270;
				short num2 = num;
				num = (short)1991676550;
				switch (num2 == num)
				{
				}
				num = (short)825753600;
				if (num != 0)
				{
				}
				num = (short)1430061057;
				if (num != 0)
				{
				}
				num = (short)1701838848;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Value;
			}
			set
			{
				short num = (short)441669945;
				short num2 = num;
				num = (short)2051823929;
				switch (num2 == num)
				{
				}
				num = (short)1283391489;
				if (num != 0)
				{
				}
				num = (short)1274281984;
				if (num != 0)
				{
				}
				num = (short)1368391680;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Value = value;
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x0600878F RID: 34703 RVA: 0x007E4754 File Offset: 0x007E2954
		// (set) Token: 0x06008790 RID: 34704 RVA: 0x007E4808 File Offset: 0x007E2A08
		public bool CHO7EmergencyButtonName_A41289_Applicable
		{
			get
			{
				short num = (short)1009204853;
				short num2 = num;
				num = (short)499662453;
				switch (num2 == num)
				{
				}
				num = (short)714670080;
				if (num != 0)
				{
				}
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)1141768192;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Applicable;
			}
			set
			{
				short num = (short)2013380395;
				short num2 = num;
				num = (short)36355883;
				switch (num2 == num)
				{
				}
				num = (short)2089025536;
				if (num != 0)
				{
				}
				num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)764477440;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Applicable = value;
			}
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x06008791 RID: 34705 RVA: 0x007E48BC File Offset: 0x007E2ABC
		// (set) Token: 0x06008792 RID: 34706 RVA: 0x007E4974 File Offset: 0x007E2B74
		public bool CHO7EmergencyButtonName_A41289_Valid
		{
			get
			{
				short num = (short)2010972161;
				if (num != 0)
				{
				}
				num = (short)1187519107;
				short num2 = num;
				num = (short)1551506051;
				switch (num2 == num)
				{
				}
				num = (short)683474944;
				if (num != 0)
				{
				}
				num = (short)883687424;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Valid;
			}
			set
			{
				short num = (short)261420027;
				short num2 = num;
				num = (short)595915771;
				switch (num2 == num)
				{
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)328925184;
				if (num != 0)
				{
				}
				num = (short)516292608;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Valid = value;
			}
		}

		// Token: 0x170044F0 RID: 17648
		// (get) Token: 0x06008793 RID: 34707 RVA: 0x007E4A28 File Offset: 0x007E2C28
		// (set) Token: 0x06008794 RID: 34708 RVA: 0x007E4ADC File Offset: 0x007E2CDC
		public bool CHO7EmergencyButtonName_A41289_Visible
		{
			get
			{
				short num = (short)1971453953;
				if (num != 0)
				{
				}
				num = (short)681078576;
				short num2 = num;
				num = (short)1171681072;
				switch (num2 == num)
				{
				}
				num = (short)852099072;
				if (num != 0)
				{
				}
				num = (short)1347354624;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Visible;
			}
			set
			{
				short num = (short)1097638324;
				short num2 = num;
				num = (short)1248698804;
				switch (num2 == num)
				{
				}
				num = (short)1562968065;
				if (num != 0)
				{
				}
				num = (short)548536320;
				if (num != 0)
				{
				}
				num = (short)1302921216;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Visible = value;
			}
		}

		// Token: 0x170044F1 RID: 17649
		// (get) Token: 0x06008795 RID: 34709 RVA: 0x007E4B90 File Offset: 0x007E2D90
		// (set) Token: 0x06008796 RID: 34710 RVA: 0x007E4C44 File Offset: 0x007E2E44
		public bool CHO7EmergencyButtonName_A41289_Editable
		{
			get
			{
				short num = (short)1773579889;
				short num2 = num;
				num = (short)1993780849;
				switch (num2 == num)
				{
				}
				num = (short)495714305;
				if (num != 0)
				{
				}
				num = (short)1327300608;
				if (num != 0)
				{
				}
				num = (short)654180352;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.Editable;
			}
			set
			{
				short num = (short)1140042262;
				short num2 = num;
				num = (short)641706518;
				switch (num2 == num)
				{
				}
				num = (short)1802698753;
				if (num != 0)
				{
				}
				num = (short)55902208;
				if (num != 0)
				{
				}
				num = (short)412483584;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.Editable = value;
			}
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x06008797 RID: 34711 RVA: 0x007E4CFC File Offset: 0x007E2EFC
		internal string CHO7EmergencyButtonName_A41289_UILabel
		{
			get
			{
				short num = (short)286479926;
				short num2 = num;
				num = (short)472077878;
				switch (num2 == num)
				{
				}
				num = (short)832110593;
				if (num != 0)
				{
				}
				num = (short)860815360;
				if (num != 0)
				{
				}
				num = (short)1176436736;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.UIName;
			}
		}

		// Token: 0x170044F3 RID: 17651
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x007E4DB4 File Offset: 0x007E2FB4
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x007E4E64 File Offset: 0x007E3064
		internal bool CHO7EmergencyButtonName_A41289_HiddenStatic
		{
			get
			{
				short num = (short)1523982071;
				short num2 = num;
				num = (short)993926903;
				switch (num2 == num)
				{
				}
				num = (short)1131085825;
				if (num != 0)
				{
				}
				num = (short)2082275328;
				if (num != 0)
				{
				}
				num = (short)535298048;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.HiddenStatic;
			}
			set
			{
				short num = (short)624666287;
				short num2 = num;
				num = (short)39888559;
				switch (num2 == num)
				{
				}
				num = (short)36438017;
				if (num != 0)
				{
				}
				num = (short)572784640;
				if (num != 0)
				{
				}
				num = (short)35127296;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.HiddenStatic = value;
			}
		}

		// Token: 0x170044F4 RID: 17652
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x007E4F1C File Offset: 0x007E311C
		// (set) Token: 0x0600879B RID: 34715 RVA: 0x007E4FD0 File Offset: 0x007E31D0
		internal bool CHO7EmergencyButtonName_A41289_HiddenDynamic
		{
			get
			{
				short num = (short)1649758163;
				short num2 = num;
				num = (short)251744211;
				switch (num2 == num)
				{
				}
				num = (short)2145124352;
				if (num != 0)
				{
				}
				num = (short)1864040449;
				if (num != 0)
				{
				}
				num = (short)1135017984;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289.HiddenDynamic;
			}
			set
			{
				short num = (short)505066576;
				short num2 = num;
				num = (short)1976480848;
				switch (num2 == num)
				{
				}
				num = (short)18743297;
				if (num != 0)
				{
				}
				num = (short)819920896;
				if (num != 0)
				{
				}
				num = (short)882180096;
				short num3 = num;
				this.cHO7EmergencyButtonName_A41289.HiddenDynamic = value;
			}
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x0600879C RID: 34716 RVA: 0x007E5084 File Offset: 0x007E3284
		public bool CHO7EmergencyButtonName_A41289_HasDiffs
		{
			get
			{
				short num = (short)1993914619;
				short num2 = num;
				num = (short)507558139;
				switch (num2 == num)
				{
				}
				num = (short)1060241408;
				if (num != 0)
				{
				}
				num = (short)906493953;
				if (num != 0)
				{
				}
				num = (short)172752896;
				short num3 = num;
				return this.cHO7EmergencyButtonName_A41289._HasDiffs;
			}
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x0600879D RID: 34717 RVA: 0x007E5138 File Offset: 0x007E3338
		// (set) Token: 0x0600879E RID: 34718 RVA: 0x007E51F0 File Offset: 0x007E33F0
		public int CHO7EmergencyButtonBCO_A41290Value
		{
			get
			{
				short num = (short)838271258;
				short num2 = num;
				num = (short)1630404890;
				switch (num2 == num)
				{
				}
				num = (short)1263140865;
				if (num != 0)
				{
				}
				num = (short)1953759232;
				if (num != 0)
				{
				}
				num = (short)1955725312;
				short num3 = num;
				return this.cHO7EmergencyButtonBCO_A41290.Value;
			}
			set
			{
				short num = (short)1882974554;
				short num2 = num;
				num = (short)1920919898;
				switch (num2 == num)
				{
				}
				num = (short)2044985345;
				if (num != 0)
				{
				}
				num = (short)1223557120;
				if (num != 0)
				{
				}
				num = (short)812646400;
				short num3 = num;
				this.cHO7EmergencyButtonBCO_A41290.Value = value;
			}
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x007E52A4 File Offset: 0x007E34A4
		// (set) Token: 0x060087A0 RID: 34720 RVA: 0x007E5358 File Offset: 0x007E3558
		public string CHO7EmergencyButtonBCO_A41290_UIValue
		{
			get
			{
				short num = (short)101734104;
				short num2 = num;
				num = (short)124081880;
				switch (num2 == num)
				{
				}
				num = (short)322109441;
				if (num != 0)
				{
				}
				num = (short)454098944;
				if (num != 0)
				{
				}
				num = (short)1614020608;
				short num3 = num;
				return this.cHO7EmergencyButtonBCO_A41290.UIValue;
			}
			set
			{
				short num = (short)812116780;
				short num2 = num;
				num = (short)980609836;
				switch (num2 == num)
				{
				}
				num = (short)70975489;
				if (num != 0)
				{
				}
				num = (short)1412562944;
				if (num != 0)
				{
				}
				num = (short)1437007872;
				short num3 = num;
				this.cHO7EmergencyButtonBCO_A41290.UIValue = value;
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x060087A1 RID: 34721 RVA: 0x007E540C File Offset: 0x007E360C
		public global::AcpBusinessLayer.AcpListField CHO7EmergencyButtonBCO_A41290
		{
			get
			{
				short num = (short)71981253;
				short num2 = num;
				num = (short)95180997;
				switch (num2 == num)
				{
				}
				num = (short)872153088;
				if (num != 0)
				{
				}
				num = (short)472907776;
				short num3 = num;
				num = (short)1679884289;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290;
			}
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x060087A2 RID: 34722 RVA: 0x007E54BC File Offset: 0x007E36BC
		// (set) Token: 0x060087A3 RID: 34723 RVA: 0x007E5570 File Offset: 0x007E3770
		public bool CHO7EmergencyButtonBCO_A41290_Applicable
		{
			get
			{
				short num = (short)139451035;
				short num2 = num;
				num = (short)1590483611;
				switch (num2 == num)
				{
				}
				num = (short)1503526913;
				if (num != 0)
				{
				}
				num = (short)1728839680;
				short num3 = num;
				num = (short)1602027520;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.Applicable;
			}
			set
			{
				short num = (short)570059970;
				short num2 = num;
				num = (short)1901358274;
				switch (num2 == num)
				{
				}
				num = (short)1368719361;
				if (num != 0)
				{
				}
				num = (short)1019609088;
				short num3 = num;
				num = (short)1753612288;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.Applicable = value;
			}
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x007E5628 File Offset: 0x007E3828
		// (set) Token: 0x060087A5 RID: 34725 RVA: 0x007E56DC File Offset: 0x007E38DC
		public bool CHO7EmergencyButtonBCO_A41290_Valid
		{
			get
			{
				short num = (short)1514995012;
				short num2 = num;
				num = (short)1652292932;
				switch (num2 == num)
				{
				}
				num = (short)1033764864;
				if (num != 0)
				{
				}
				num = (short)2118057984;
				short num3 = num;
				num = (short)589889537;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.Valid;
			}
			set
			{
				short num = (short)1195568887;
				short num2 = num;
				num = (short)1730801399;
				switch (num2 == num)
				{
				}
				num = (short)930545665;
				if (num != 0)
				{
				}
				num = (short)2053701632;
				short num3 = num;
				num = (short)727318528;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.Valid = value;
			}
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x007E5794 File Offset: 0x007E3994
		// (set) Token: 0x060087A7 RID: 34727 RVA: 0x007E5848 File Offset: 0x007E3A48
		public bool CHO7EmergencyButtonBCO_A41290_Visible
		{
			get
			{
				short num = (short)97875290;
				short num2 = num;
				num = (short)301692250;
				switch (num2 == num)
				{
				}
				num = (short)2023686144;
				if (num != 0)
				{
				}
				num = (short)383123456;
				short num3 = num;
				num = (short)458162177;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.Visible;
			}
			set
			{
				short num = (short)1534324778;
				short num2 = num;
				num = (short)1571418154;
				switch (num2 == num)
				{
				}
				num = (short)987365376;
				if (num != 0)
				{
				}
				num = (short)1816461312;
				short num3 = num;
				num = (short)1102446593;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.Visible = value;
			}
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x060087A8 RID: 34728 RVA: 0x007E5900 File Offset: 0x007E3B00
		// (set) Token: 0x060087A9 RID: 34729 RVA: 0x007E59B4 File Offset: 0x007E3BB4
		public bool CHO7EmergencyButtonBCO_A41290_Editable
		{
			get
			{
				short num = (short)1839731988;
				short num2 = num;
				num = (short)2144146708;
				switch (num2 == num)
				{
				}
				num = (short)1782120449;
				if (num != 0)
				{
				}
				num = (short)1144586240;
				short num3 = num;
				num = (short)1646592000;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.Editable;
			}
			set
			{
				short num = (short)1081567749;
				short num2 = num;
				num = (short)391211525;
				switch (num2 == num)
				{
				}
				num = (short)1899495425;
				if (num != 0)
				{
				}
				num = (short)1035993088;
				short num3 = num;
				num = (short)1689321472;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.Editable = value;
			}
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x060087AA RID: 34730 RVA: 0x007E5A68 File Offset: 0x007E3C68
		internal string CHO7EmergencyButtonBCO_A41290_UILabel
		{
			get
			{
				short num = (short)1628678408;
				short num2 = num;
				num = (short)827566344;
				switch (num2 == num)
				{
				}
				num = (short)1577320448;
				if (num != 0)
				{
				}
				num = (short)947912704;
				short num3 = num;
				num = (short)1580662785;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.UIName;
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x060087AB RID: 34731 RVA: 0x007E5B1C File Offset: 0x007E3D1C
		// (set) Token: 0x060087AC RID: 34732 RVA: 0x007E5BD4 File Offset: 0x007E3DD4
		internal bool CHO7EmergencyButtonBCO_A41290_HiddenStatic
		{
			get
			{
				short num = (short)235601921;
				if (num != 0)
				{
				}
				num = (short)1829761121;
				short num2 = num;
				num = (short)776925281;
				switch (num2 == num)
				{
				}
				num = (short)1290797056;
				short num3 = num;
				num = (short)1993080832;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.HiddenStatic;
			}
			set
			{
				short num = (short)437398734;
				short num2 = num;
				num = (short)767175886;
				switch (num2 == num)
				{
				}
				num = (short)2001928193;
				if (num != 0)
				{
				}
				num = (short)1636499456;
				short num3 = num;
				num = (short)1715929088;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.HiddenStatic = value;
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x060087AD RID: 34733 RVA: 0x007E5C88 File Offset: 0x007E3E88
		// (set) Token: 0x060087AE RID: 34734 RVA: 0x007E5D40 File Offset: 0x007E3F40
		internal bool CHO7EmergencyButtonBCO_A41290_HiddenDynamic
		{
			get
			{
				short num = (short)1714859754;
				short num2 = num;
				num = (short)1902554858;
				switch (num2 == num)
				{
				}
				num = (short)909770753;
				if (num != 0)
				{
				}
				num = (short)905510912;
				short num3 = num;
				num = (short)1057226752;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290.HiddenDynamic;
			}
			set
			{
				short num = (short)1888205059;
				short num2 = num;
				num = (short)790870275;
				switch (num2 == num)
				{
				}
				num = (short)1722810368;
				if (num != 0)
				{
				}
				num = (short)929824768;
				short num3 = num;
				num = (short)1900019713;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonBCO_A41290.HiddenDynamic = value;
			}
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x060087AF RID: 34735 RVA: 0x007E5DF8 File Offset: 0x007E3FF8
		public bool CHO7EmergencyButtonBCO_A41290_HasDiffs
		{
			get
			{
				short num = (short)369834713;
				short num2 = num;
				num = (short)1790720729;
				switch (num2 == num)
				{
				}
				num = (short)1838874625;
				if (num != 0)
				{
				}
				num = (short)794296320;
				short num3 = num;
				num = (short)1631780864;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonBCO_A41290._HasDiffs;
			}
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x060087B0 RID: 34736 RVA: 0x007E5EAC File Offset: 0x007E40AC
		// (set) Token: 0x060087B1 RID: 34737 RVA: 0x007E5F60 File Offset: 0x007E4160
		public int CHO7EmergencyButtonFeature_A41291Value
		{
			get
			{
				short num = (short)490349279;
				short num2 = num;
				num = (short)555492063;
				switch (num2 == num)
				{
				}
				num = (short)2117009409;
				if (num != 0)
				{
				}
				num = (short)1321009152;
				short num3 = num;
				num = (short)249561088;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.Value;
			}
			set
			{
				short num = (short)1524957185;
				if (num != 0)
				{
				}
				num = (short)1414829875;
				short num2 = num;
				num = (short)519149363;
				switch (num2 == num)
				{
				}
				num = (short)832503808;
				short num3 = num;
				num = (short)835780608;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.Value = value;
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x060087B2 RID: 34738 RVA: 0x007E6014 File Offset: 0x007E4214
		// (set) Token: 0x060087B3 RID: 34739 RVA: 0x007E60C8 File Offset: 0x007E42C8
		public string CHO7EmergencyButtonFeature_A41291_UIValue
		{
			get
			{
				short num = (short)1064960001;
				if (num != 0)
				{
				}
				num = (short)1224433836;
				short num2 = num;
				num = (short)703029420;
				switch (num2 == num)
				{
				}
				num = (short)617349120;
				short num3 = num;
				num = (short)1091436544;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.UIValue;
			}
			set
			{
				short num = (short)740322404;
				short num2 = num;
				num = (short)1007447140;
				switch (num2 == num)
				{
				}
				num = (short)2108882944;
				if (num != 0)
				{
				}
				num = (short)673775616;
				short num3 = num;
				num = (short)34275329;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.UIValue = value;
			}
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x060087B4 RID: 34740 RVA: 0x007E617C File Offset: 0x007E437C
		public global::AcpBusinessLayer.AcpListField CHO7EmergencyButtonFeature_A41291
		{
			get
			{
				short num = (short)1546896739;
				short num2 = num;
				num = (short)1734788451;
				switch (num2 == num)
				{
				}
				num = (short)1973616641;
				if (num != 0)
				{
				}
				num = (short)6160384;
				short num3 = num;
				num = (short)1107230720;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291;
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x060087B5 RID: 34741 RVA: 0x007E622C File Offset: 0x007E442C
		// (set) Token: 0x060087B6 RID: 34742 RVA: 0x007E62E0 File Offset: 0x007E44E0
		public bool CHO7EmergencyButtonFeature_A41291_Applicable
		{
			get
			{
				short num = (short)1515338634;
				short num2 = num;
				num = (short)1154825098;
				switch (num2 == num)
				{
				}
				num = (short)2100101120;
				if (num != 0)
				{
				}
				num = (short)1140981760;
				short num3 = num;
				num = (short)825098241;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.Applicable;
			}
			set
			{
				short num = (short)1530302183;
				short num2 = num;
				num = (short)1539608295;
				switch (num2 == num)
				{
				}
				num = (short)82837505;
				if (num != 0)
				{
				}
				num = (short)1127612416;
				short num3 = num;
				num = (short)1793261568;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.Applicable = value;
			}
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x060087B7 RID: 34743 RVA: 0x007E6394 File Offset: 0x007E4594
		// (set) Token: 0x060087B8 RID: 34744 RVA: 0x007E644C File Offset: 0x007E464C
		public bool CHO7EmergencyButtonFeature_A41291_Valid
		{
			get
			{
				short num = (short)595450844;
				short num2 = num;
				num = (short)669113308;
				switch (num2 == num)
				{
				}
				num = (short)341114881;
				if (num != 0)
				{
				}
				num = (short)1078001664;
				short num3 = num;
				num = (short)121634816;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.Valid;
			}
			set
			{
				short num = (short)1282964448;
				short num2 = num;
				num = (short)310475744;
				switch (num2 == num)
				{
				}
				num = (short)334954496;
				if (num != 0)
				{
				}
				num = (short)293863424;
				short num3 = num;
				num = (short)1057685505;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.Valid = value;
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x060087B9 RID: 34745 RVA: 0x007E6500 File Offset: 0x007E4700
		// (set) Token: 0x060087BA RID: 34746 RVA: 0x007E65B4 File Offset: 0x007E47B4
		public bool CHO7EmergencyButtonFeature_A41291_Visible
		{
			get
			{
				short num = (short)731151463;
				short num2 = num;
				num = (short)921599079;
				switch (num2 == num)
				{
				}
				num = (short)1309409280;
				if (num != 0)
				{
				}
				num = (short)1075183616;
				short num3 = num;
				num = (short)635437057;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.Visible;
			}
			set
			{
				short num = (short)357241339;
				short num2 = num;
				num = (short)1186206203;
				switch (num2 == num)
				{
				}
				num = (short)178192385;
				if (num != 0)
				{
				}
				num = (short)1799946240;
				short num3 = num;
				num = (short)2071396352;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.Visible = value;
			}
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x007E666C File Offset: 0x007E486C
		// (set) Token: 0x060087BC RID: 34748 RVA: 0x007E6724 File Offset: 0x007E4924
		public bool CHO7EmergencyButtonFeature_A41291_Editable
		{
			get
			{
				short num = (short)1681719297;
				if (num != 0)
				{
				}
				num = (short)618446570;
				short num2 = num;
				num = (short)111853290;
				switch (num2 == num)
				{
				}
				num = (short)345374720;
				short num3 = num;
				num = (short)822738944;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.Editable;
			}
			set
			{
				short num = (short)872532155;
				short num2 = num;
				num = (short)128436411;
				switch (num2 == num)
				{
				}
				num = (short)1229848577;
				if (num != 0)
				{
				}
				num = (short)1255342080;
				short num3 = num;
				num = (short)1106247680;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.Editable = value;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x007E67D8 File Offset: 0x007E49D8
		internal string CHO7EmergencyButtonFeature_A41291_UILabel
		{
			get
			{
				short num = (short)1289289729;
				if (num != 0)
				{
				}
				num = (short)1234539041;
				short num2 = num;
				num = (short)1582993953;
				switch (num2 == num)
				{
				}
				num = (short)916914176;
				short num3 = num;
				num = (short)2125463552;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.UIName;
			}
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x060087BE RID: 34750 RVA: 0x007E6890 File Offset: 0x007E4A90
		// (set) Token: 0x060087BF RID: 34751 RVA: 0x007E6948 File Offset: 0x007E4B48
		internal bool CHO7EmergencyButtonFeature_A41291_HiddenStatic
		{
			get
			{
				short num = (short)964689921;
				if (num != 0)
				{
				}
				num = (short)1397381957;
				short num2 = num;
				num = (short)500325189;
				switch (num2 == num)
				{
				}
				num = (short)1795489792;
				short num3 = num;
				num = (short)746586112;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.HiddenStatic;
			}
			set
			{
				short num = (short)410300729;
				short num2 = num;
				num = (short)1575465273;
				switch (num2 == num)
				{
				}
				num = (short)1912537089;
				if (num != 0)
				{
				}
				num = (short)1933377536;
				short num3 = num;
				num = (short)76021760;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.HiddenStatic = value;
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x060087C0 RID: 34752 RVA: 0x007E69FC File Offset: 0x007E4BFC
		// (set) Token: 0x060087C1 RID: 34753 RVA: 0x007E6AB0 File Offset: 0x007E4CB0
		internal bool CHO7EmergencyButtonFeature_A41291_HiddenDynamic
		{
			get
			{
				short num = (short)1377439384;
				short num2 = num;
				num = (short)638455448;
				switch (num2 == num)
				{
				}
				num = (short)309985281;
				if (num != 0)
				{
				}
				num = (short)200671232;
				short num3 = num;
				num = (short)762118144;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291.HiddenDynamic;
			}
			set
			{
				short num = (short)697372444;
				short num2 = num;
				num = (short)1152782108;
				switch (num2 == num)
				{
				}
				num = (short)235077633;
				if (num != 0)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				num = (short)335151104;
				if (num != 0)
				{
				}
				this.cHO7EmergencyButtonFeature_A41291.HiddenDynamic = value;
			}
		}

		// Token: 0x1700450B RID: 17675
		// (get) Token: 0x060087C2 RID: 34754 RVA: 0x007E6B68 File Offset: 0x007E4D68
		public bool CHO7EmergencyButtonFeature_A41291_HasDiffs
		{
			get
			{
				short num = (short)647475437;
				short num2 = num;
				num = (short)434942189;
				switch (num2 == num)
				{
				}
				num = (short)2078212097;
				if (num != 0)
				{
				}
				num = (short)1230372864;
				short num3 = num;
				num = (short)718209024;
				if (num != 0)
				{
				}
				return this.cHO7EmergencyButtonFeature_A41291._HasDiffs;
			}
		}

		// Token: 0x1700450C RID: 17676
		// (get) Token: 0x060087C3 RID: 34755 RVA: 0x007E6C20 File Offset: 0x007E4E20
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)352171029;
				short num2 = num;
				num = (short)287355925;
				switch (num2 == num)
				{
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				num = (short)642187264;
				short num3 = num;
				num = (short)1964048385;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x007E6CE0 File Offset: 0x007E4EE0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1583790059;
				short num2 = num;
				num = (short)2041362411;
				switch (num2 == num)
				{
				}
				num = (short)568000512;
				if (num != 0)
				{
				}
				num = (short)1748369408;
				short num3 = num;
				num = (short)572063745;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x007E6DA0 File Offset: 0x007E4FA0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)870640758;
			short num2 = num;
			num = (short)1616047222;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_144:
				num = (short)886112258;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)381616128;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_10E;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)714670083;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1455489028;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1831993344;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_CE;
				}
				goto IL_6E;
			}
			IL_CE:
			num = (short)1655504897;
			if (num != 0)
			{
			}
			return result;
			IL_10E:
			num = (short)814874624;
			short num4 = num;
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_144;
			}
			return result;
			IL_6E:
			result = null;
			num = (short)1511391233;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x04003FF4 RID: 16372
		private global::AcpBusinessLayer.AcpField<string> cHO7EmergencyButtonName_A41289;

		// Token: 0x04003FF5 RID: 16373
		private global::AcpBusinessLayer.AcpListField cHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003FF6 RID: 16374
		private global::AcpBusinessLayer.AcpListField cHO7EmergencyButtonFeature_A41291;
	}
}
