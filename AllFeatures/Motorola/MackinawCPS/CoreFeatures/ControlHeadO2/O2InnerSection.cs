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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003DF RID: 991
	[global::System.Serializable]
	public class O2InnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008B9A RID: 35738 RVA: 0x0082B8DC File Offset: 0x00829ADC
		public O2InnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x0082B8F8 File Offset: 0x00829AF8
		protected O2InnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x0082B910 File Offset: 0x00829B10
		public override void Init()
		{
			int a_ = 8;
			short num = (short)82753146;
			short num2 = num;
			num = (short)1765127802;
			switch (num2 == num)
			{
			}
			num = (short)1286340609;
			if (num != 0)
			{
			}
			num = (short)1648099328;
			if (num != 0)
			{
			}
			num = (short)1789460480;
			short num3 = num;
			this.cHO2EmergencyButtonName_A41270 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("諈菊苌﷎铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꇮ郰黲郴ꣶ룸쿺쳼췾㘀㌂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO2EmergencyButtonName_A41270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO2EmergencyButtonName_A41270.DataTransferOrder = -1;
			this.cHO2EmergencyButtonBCO_A41271 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexCHO2EmergencyButtonBCO_A41271LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idCHO2EmergencyButtonBCO_A41271LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌﷎铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬귮닰볲ꫴ뛶췸쫺쿼죾\u3000", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.CHO2EmergencyButtonBCO_A41271LovStrs);
			this.cHO2EmergencyButtonBCO_A41271.IgnoreOnCompare = true;
			this.cHO2EmergencyButtonBCO_A41271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO2EmergencyButtonBCO_A41271.DataTransferOrder = -1;
			this.cHO2EmergencyButtonFeature_A41272 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexCHO2EmergencyButtonFeature_A41272LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idCHO2EmergencyButtonFeature_A41272LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈菊苌﷎铐뻒냔ꗖ뻘뻚돜볞飠ꇢ郤鏦鷨蓪菬ꧮ铰鋲致苶诸黺ꋼ뻾㔀㈂㜄〆㬈", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.CHO2EmergencyButtonFeature_A41272LovStrs);
			this.cHO2EmergencyButtonFeature_A41272.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO2EmergencyButtonFeature_A41272.DataTransferOrder = 17;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛈流", a_);
			base.Id = 10716;
			base.UIName = global::CommonResources.AcgResources.ID_O2;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x0082BADC File Offset: 0x00829CDC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)2106785794;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶미룺닼ꃾ䀀㜂㐄㔆㸈㨊", a_)))
					{
						num = (short)927006727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B9;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶뿸黺鳼课琀焂怄堆䠈㼊㰌㴎☐ℒ", a_)))
					{
						num = (short)413007880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_388;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 3:
					goto IL_177;
				case 4:
					if (producerFields != null)
					{
						num = (short)2024472587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_388;
				case 5:
					goto IL_2B9;
				case 6:
					goto IL_278;
				case 7:
				{
					this.cHO2EmergencyButtonBCO_A41271 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexCHO2EmergencyButtonBCO_A41271LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idCHO2EmergencyButtonBCO_A41271LovStrs), this, global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶미룺닼ꃾ䀀㜂㐄㔆㸈㨊", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.CHO2EmergencyButtonBCO_A41271LovStrs);
					this.cHO2EmergencyButtonBCO_A41271.IgnoreOnCompare = true;
					this.cHO2EmergencyButtonBCO_A41271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO2EmergencyButtonBCO_A41271.DataTransferOrder = -1;
					num = (short)255968628;
					short num3 = num;
					num = (short)2089272692;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_260;
					default:
						num = (short)1301610496;
						if (num != 0)
						{
						}
						num = (short)37158917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					this.cHO2EmergencyButtonFeature_A41272 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.indexCHO2EmergencyButtonFeature_A41272LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.idCHO2EmergencyButtonFeature_A41272LovStrs), this, global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶뿸黺鳼课琀焂怄堆䠈㼊㰌㴎☐ℒ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.LOVs.CHO2EmergencyButtonFeature_A41272LovStrs);
					this.cHO2EmergencyButtonFeature_A41272.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO2EmergencyButtonFeature_A41272.DataTransferOrder = 17;
					goto IL_260;
				case 9:
					num = (short)525533188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶럸髺郼髾帀䈂㄄㘆㬈㰊㴌", a_)))
					{
						num = (short)1328939020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_177;
				case 11:
					num = (short)101777418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)884277249;
					if (num != 0)
					{
					}
					this.cHO2EmergencyButtonName_A41270 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("郒鷔飖黚냜뫞鏠蓢胤触諨鋪꿬髮藰蟲髴駶럸髺郼髾帀䈂㄄㘆㬈㰊㴌", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO2EmergencyButtonName_A41270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO2EmergencyButtonName_A41270.DataTransferOrder = -1;
					num = (short)910950403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				num = (short)475136000;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1361117193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_177:
				num = (short)483786752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_260:
				num = (short)1898053638;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B9:
				num = (short)789250049;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_278:
			IL_388:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳒", a_);
			base.Id = 10716;
			base.UIName = global::CommonResources.AcgResources.ID_O2;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x0082BEA4 File Offset: 0x0082A0A4
		public override void PopulateReferences()
		{
			short num = (short)1409105331;
			short num2 = num;
			num = (short)1271479731;
			switch (num2 == num)
			{
			}
			num = (short)28508160;
			if (num != 0)
			{
			}
			num = (short)1687617537;
			if (num != 0)
			{
			}
			num = (short)242941952;
			short num3 = num;
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x0082BF4C File Offset: 0x0082A14C
		public override void DropReferences()
		{
			short num = (short)1910964225;
			if (num != 0)
			{
			}
			num = (short)777848287;
			short num2 = num;
			num = (short)1622214111;
			switch (num2 == num)
			{
			}
			num = (short)1730871296;
			if (num != 0)
			{
			}
			num = (short)1731854336;
			short num3 = num;
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x0082BFF8 File Offset: 0x0082A1F8
		public override void SetConstraints()
		{
			short num = (short)1914026454;
			short num2 = num;
			num = (short)946911702;
			switch (num2 == num)
			{
			}
			num = (short)542375937;
			if (num != 0)
			{
			}
			num = (short)474873856;
			if (num != 0)
			{
			}
			num = (short)1107361792;
			short num3 = num;
			this.cHO2EmergencyButtonName_A41270.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO2EmergencyButtonFeature_A41272.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO2EmergencyButtonFeature_A41272.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConControlHeadEmergencyFeaturesSelect);
			this.cHO2EmergencyButtonFeature_A41272.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.ConSyncOrangeBtn);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x0082C0FC File Offset: 0x0082A2FC
		public override void SetupDependencies()
		{
			short num = (short)1322541862;
			short num2 = num;
			num = (short)1119970086;
			switch (num2 == num)
			{
			}
			num = (short)1368195073;
			if (num != 0)
			{
			}
			num = (short)1553924096;
			if (num != 0)
			{
			}
			num = (short)943915008;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
			this.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
			this.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cHO2EmergencyButtonFeature_A41272);
		}

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x06008BA2 RID: 35746 RVA: 0x0082C250 File Offset: 0x0082A450
		public bool HasDiffs
		{
			get
			{
				short num = (short)2010242664;
				short num2 = num;
				num = (short)2012733032;
				switch (num2 == num)
				{
				}
				num = (short)165085184;
				if (num != 0)
				{
				}
				num = (short)1723858945;
				if (num != 0)
				{
				}
				num = (short)1141899264;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x0082C300 File Offset: 0x0082A500
		// (set) Token: 0x06008BA4 RID: 35748 RVA: 0x0082C3B4 File Offset: 0x0082A5B4
		public string CHO2EmergencyButtonName_A41270Value
		{
			get
			{
				short num = (short)1843119108;
				short num2 = num;
				num = (short)1714406404;
				switch (num2 == num)
				{
				}
				num = (short)1842675712;
				if (num != 0)
				{
				}
				num = (short)1412694017;
				if (num != 0)
				{
				}
				num = (short)633339904;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Value;
			}
			set
			{
				short num = (short)770127762;
				short num2 = num;
				num = (short)1015429010;
				switch (num2 == num)
				{
				}
				num = (short)1122172929;
				if (num != 0)
				{
				}
				num = (short)1291321344;
				if (num != 0)
				{
				}
				num = (short)937951232;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Value = value;
			}
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x0082C46C File Offset: 0x0082A66C
		public global::AcpBusinessLayer.AcpField<string> CHO2EmergencyButtonName_A41270
		{
			get
			{
				short num = (short)374117250;
				short num2 = num;
				num = (short)1839895426;
				switch (num2 == num)
				{
				}
				num = (short)1999896577;
				if (num != 0)
				{
				}
				num = (short)985202688;
				if (num != 0)
				{
				}
				num = (short)468582400;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270;
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x06008BA6 RID: 35750 RVA: 0x0082C520 File Offset: 0x0082A720
		// (set) Token: 0x06008BA7 RID: 35751 RVA: 0x0082C5D4 File Offset: 0x0082A7D4
		public string CHO2EmergencyButtonName_A41270_UIValue
		{
			get
			{
				short num = (short)98258206;
				short num2 = num;
				num = (short)2082884894;
				switch (num2 == num)
				{
				}
				num = (short)429654017;
				if (num != 0)
				{
				}
				num = (short)1401225216;
				if (num != 0)
				{
				}
				num = (short)859242496;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Value;
			}
			set
			{
				short num = (short)809582505;
				short num2 = num;
				num = (short)1144209321;
				switch (num2 == num)
				{
				}
				num = (short)600834049;
				if (num != 0)
				{
				}
				num = (short)454295552;
				if (num != 0)
				{
				}
				num = (short)1763639296;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Value = value;
			}
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x06008BA8 RID: 35752 RVA: 0x0082C688 File Offset: 0x0082A888
		// (set) Token: 0x06008BA9 RID: 35753 RVA: 0x0082C738 File Offset: 0x0082A938
		public bool CHO2EmergencyButtonName_A41270_Applicable
		{
			get
			{
				short num = (short)1491565956;
				short num2 = num;
				num = (short)714112388;
				switch (num2 == num)
				{
				}
				num = (short)1798701056;
				if (num != 0)
				{
				}
				num = (short)1492975617;
				if (num != 0)
				{
				}
				num = (short)794165248;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Applicable;
			}
			set
			{
				short num = (short)811586189;
				short num2 = num;
				num = (short)1933890189;
				switch (num2 == num)
				{
				}
				num = (short)1626734593;
				if (num != 0)
				{
				}
				num = (short)50331648;
				if (num != 0)
				{
				}
				num = (short)483065856;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Applicable = value;
			}
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x06008BAA RID: 35754 RVA: 0x0082C7EC File Offset: 0x0082A9EC
		// (set) Token: 0x06008BAB RID: 35755 RVA: 0x0082C8A0 File Offset: 0x0082AAA0
		public bool CHO2EmergencyButtonName_A41270_Valid
		{
			get
			{
				short num = (short)1929445377;
				if (num != 0)
				{
				}
				num = (short)1072609244;
				short num2 = num;
				num = (short)1788327900;
				switch (num2 == num)
				{
				}
				num = (short)186449920;
				if (num != 0)
				{
				}
				num = (short)853671936;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Valid;
			}
			set
			{
				short num = (short)1954611201;
				if (num != 0)
				{
				}
				num = (short)1068155809;
				short num2 = num;
				num = (short)1980941217;
				switch (num2 == num)
				{
				}
				num = (short)682033152;
				if (num != 0)
				{
				}
				num = (short)152502272;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Valid = value;
			}
		}

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x06008BAC RID: 35756 RVA: 0x0082C954 File Offset: 0x0082AB54
		// (set) Token: 0x06008BAD RID: 35757 RVA: 0x0082CA08 File Offset: 0x0082AC08
		public bool CHO2EmergencyButtonName_A41270_Visible
		{
			get
			{
				short num = (short)595914279;
				short num2 = num;
				num = (short)998829607;
				switch (num2 == num)
				{
				}
				num = (short)1563623425;
				if (num != 0)
				{
				}
				num = (short)1205338112;
				if (num != 0)
				{
				}
				num = (short)973471744;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Visible;
			}
			set
			{
				short num = (short)1617082198;
				short num2 = num;
				num = (short)223524694;
				switch (num2 == num)
				{
				}
				num = (short)2067791873;
				if (num != 0)
				{
				}
				num = (short)1505296384;
				if (num != 0)
				{
				}
				num = (short)1478098944;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Visible = value;
			}
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x06008BAE RID: 35758 RVA: 0x0082CABC File Offset: 0x0082ACBC
		// (set) Token: 0x06008BAF RID: 35759 RVA: 0x0082CB74 File Offset: 0x0082AD74
		public bool CHO2EmergencyButtonName_A41270_Editable
		{
			get
			{
				short num = (short)1603469313;
				if (num != 0)
				{
				}
				num = (short)1122109694;
				short num2 = num;
				num = (short)2070481150;
				switch (num2 == num)
				{
				}
				num = (short)2109276160;
				if (num != 0)
				{
				}
				num = (short)358612992;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.Editable;
			}
			set
			{
				short num = (short)1137082203;
				short num2 = num;
				num = (short)86081371;
				switch (num2 == num)
				{
				}
				num = (short)2114781185;
				if (num != 0)
				{
				}
				num = (short)2054619136;
				if (num != 0)
				{
				}
				num = (short)1289289728;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.Editable = value;
			}
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x06008BB0 RID: 35760 RVA: 0x0082CC28 File Offset: 0x0082AE28
		internal string CHO2EmergencyButtonName_A41270_UILabel
		{
			get
			{
				short num = (short)967630337;
				short num2 = num;
				num = (short)708173313;
				switch (num2 == num)
				{
				}
				num = (short)1012858880;
				if (num != 0)
				{
				}
				num = (short)170196993;
				if (num != 0)
				{
				}
				num = (short)1932722176;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.UIName;
			}
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x0082CCE0 File Offset: 0x0082AEE0
		// (set) Token: 0x06008BB2 RID: 35762 RVA: 0x0082CD94 File Offset: 0x0082AF94
		internal bool CHO2EmergencyButtonName_A41270_HiddenStatic
		{
			get
			{
				short num = (short)1247834037;
				short num2 = num;
				num = (short)419196853;
				switch (num2 == num)
				{
				}
				num = (short)898039809;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				if (num != 0)
				{
				}
				num = (short)1909587968;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.HiddenStatic;
			}
			set
			{
				short num = (short)1704877651;
				short num2 = num;
				num = (short)2081054291;
				switch (num2 == num)
				{
				}
				num = (short)1545994240;
				if (num != 0)
				{
				}
				num = (short)83558401;
				if (num != 0)
				{
				}
				num = (short)1147338752;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.HiddenStatic = value;
			}
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x0082CE48 File Offset: 0x0082B048
		// (set) Token: 0x06008BB4 RID: 35764 RVA: 0x0082CF00 File Offset: 0x0082B100
		internal bool CHO2EmergencyButtonName_A41270_HiddenDynamic
		{
			get
			{
				short num = (short)1788896359;
				short num2 = num;
				num = (short)88892519;
				switch (num2 == num)
				{
				}
				num = (short)1040711681;
				if (num != 0)
				{
				}
				num = (short)229244928;
				if (num != 0)
				{
				}
				num = (short)1928790016;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270.HiddenDynamic;
			}
			set
			{
				short num = (short)1636564253;
				short num2 = num;
				num = (short)2017852701;
				switch (num2 == num)
				{
				}
				num = (short)1472987137;
				if (num != 0)
				{
				}
				num = (short)776208384;
				if (num != 0)
				{
				}
				num = (short)406650880;
				short num3 = num;
				this.cHO2EmergencyButtonName_A41270.HiddenDynamic = value;
			}
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x0082CFB4 File Offset: 0x0082B1B4
		public bool CHO2EmergencyButtonName_A41270_HasDiffs
		{
			get
			{
				short num = (short)1676607489;
				if (num != 0)
				{
				}
				num = (short)966519493;
				short num2 = num;
				num = (short)448522949;
				switch (num2 == num)
				{
				}
				num = (short)1359544320;
				if (num != 0)
				{
				}
				num = (short)683343872;
				short num3 = num;
				return this.cHO2EmergencyButtonName_A41270._HasDiffs;
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x0082D068 File Offset: 0x0082B268
		// (set) Token: 0x06008BB7 RID: 35767 RVA: 0x0082D124 File Offset: 0x0082B324
		public int CHO2EmergencyButtonBCO_A41271Value
		{
			get
			{
				short num = (short)2103864559;
				short num2 = num;
				num = (short)548629743;
				switch (num2 == num)
				{
				}
				num = (short)1557528577;
				if (num != 0)
				{
				}
				num = (short)738983936;
				if (num != 0)
				{
				}
				num = (short)431882240;
				short num3 = num;
				return this.cHO2EmergencyButtonBCO_A41271.Value;
			}
			set
			{
				short num = (short)1320681472;
				short num2 = num;
				num = (short)1781517273;
				short num3 = num;
				num = (short)284019673;
				switch (num3 == num)
				{
				}
				num = (short)904003585;
				if (num != 0)
				{
				}
				num = (short)962723840;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.Value = value;
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x06008BB8 RID: 35768 RVA: 0x0082D1DC File Offset: 0x0082B3DC
		// (set) Token: 0x06008BB9 RID: 35769 RVA: 0x0082D290 File Offset: 0x0082B490
		public string CHO2EmergencyButtonBCO_A41271_UIValue
		{
			get
			{
				short num = (short)147718144;
				short num2 = num;
				num = (short)1472567163;
				short num3 = num;
				num = (short)1125619579;
				switch (num3 == num)
				{
				}
				num = (short)946798593;
				if (num != 0)
				{
				}
				num = (short)140640256;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.UIValue;
			}
			set
			{
				short num = (short)93388800;
				short num2 = num;
				num = (short)1000060998;
				short num3 = num;
				num = (short)158906438;
				switch (num3 == num)
				{
				}
				num = (short)124583937;
				if (num != 0)
				{
				}
				num = (short)806944768;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.UIValue = value;
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x06008BBA RID: 35770 RVA: 0x0082D344 File Offset: 0x0082B544
		public global::AcpBusinessLayer.AcpListField CHO2EmergencyButtonBCO_A41271
		{
			get
			{
				short num = (short)1615200256;
				short num2 = num;
				num = (short)730503512;
				short num3 = num;
				num = (short)1377016152;
				switch (num3 == num)
				{
				}
				num = (short)237305857;
				if (num != 0)
				{
				}
				num = (short)1401552896;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271;
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x06008BBB RID: 35771 RVA: 0x0082D3F0 File Offset: 0x0082B5F0
		// (set) Token: 0x06008BBC RID: 35772 RVA: 0x0082D4A8 File Offset: 0x0082B6A8
		public bool CHO2EmergencyButtonBCO_A41271_Applicable
		{
			get
			{
				short num = (short)185270272;
				short num2 = num;
				num = (short)759500032;
				short num3 = num;
				num = (short)2105675008;
				switch (num3 == num)
				{
				}
				num = (short)126287873;
				if (num != 0)
				{
				}
				num = (short)1879048192;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.Applicable;
			}
			set
			{
				short num = (short)591921152;
				short num2 = num;
				num = (short)915691152;
				short num3 = num;
				num = (short)1127306896;
				switch (num3 == num)
				{
				}
				num = (short)1881604097;
				if (num != 0)
				{
				}
				num = (short)1766981632;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.Applicable = value;
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x06008BBD RID: 35773 RVA: 0x0082D55C File Offset: 0x0082B75C
		// (set) Token: 0x06008BBE RID: 35774 RVA: 0x0082D610 File Offset: 0x0082B810
		public bool CHO2EmergencyButtonBCO_A41271_Valid
		{
			get
			{
				short num = (short)768933888;
				short num2 = num;
				num = (short)627834881;
				if (num != 0)
				{
				}
				num = (short)785310761;
				short num3 = num;
				num = (short)816112681;
				switch (num3 == num)
				{
				}
				num = (short)1604976640;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.Valid;
			}
			set
			{
				short num = (short)818479104;
				short num2 = num;
				num = (short)1114730120;
				short num3 = num;
				num = (short)1697869448;
				switch (num3 == num)
				{
				}
				num = (short)1158414337;
				if (num != 0)
				{
				}
				num = (short)1167589376;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.Valid = value;
			}
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x06008BBF RID: 35775 RVA: 0x0082D6C4 File Offset: 0x0082B8C4
		// (set) Token: 0x06008BC0 RID: 35776 RVA: 0x0082D77C File Offset: 0x0082B97C
		public bool CHO2EmergencyButtonBCO_A41271_Visible
		{
			get
			{
				short num = (short)1730150400;
				short num2 = num;
				num = (short)494775560;
				short num3 = num;
				num = (short)1812770056;
				switch (num3 == num)
				{
				}
				num = (short)469958657;
				if (num != 0)
				{
				}
				num = (short)637140992;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.Visible;
			}
			set
			{
				short num = (short)1605828608;
				short num2 = num;
				num = (short)611251820;
				short num3 = num;
				num = (short)884668012;
				switch (num3 == num)
				{
				}
				num = (short)377815040;
				if (num != 0)
				{
				}
				num = (short)326172673;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.Visible = value;
			}
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x06008BC1 RID: 35777 RVA: 0x0082D834 File Offset: 0x0082BA34
		// (set) Token: 0x06008BC2 RID: 35778 RVA: 0x0082D8E8 File Offset: 0x0082BAE8
		public bool CHO2EmergencyButtonBCO_A41271_Editable
		{
			get
			{
				short num = (short)1274216448;
				short num2 = num;
				num = (short)911605761;
				if (num != 0)
				{
				}
				num = (short)1911655392;
				short num3 = num;
				num = (short)1631882208;
				switch (num3 == num)
				{
				}
				num = (short)1812987904;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.Editable;
			}
			set
			{
				short num = (short)1859190784;
				short num2 = num;
				num = (short)1275478491;
				short num3 = num;
				num = (short)1274233307;
				switch (num3 == num)
				{
				}
				num = (short)591265793;
				if (num != 0)
				{
				}
				num = (short)1952710656;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.Editable = value;
			}
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x06008BC3 RID: 35779 RVA: 0x0082D99C File Offset: 0x0082BB9C
		internal string CHO2EmergencyButtonBCO_A41271_UILabel
		{
			get
			{
				short num = (short)471728128;
				short num2 = num;
				num = (short)1935033527;
				short num3 = num;
				num = (short)2025604279;
				switch (num3 == num)
				{
				}
				num = (short)147718145;
				if (num != 0)
				{
				}
				num = (short)1830289408;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.UIName;
			}
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x06008BC4 RID: 35780 RVA: 0x0082DA50 File Offset: 0x0082BC50
		// (set) Token: 0x06008BC5 RID: 35781 RVA: 0x0082DB04 File Offset: 0x0082BD04
		internal bool CHO2EmergencyButtonBCO_A41271_HiddenStatic
		{
			get
			{
				short num = (short)708247552;
				short num2 = num;
				num = (short)94382706;
				short num3 = num;
				num = (short)1445603954;
				switch (num3 == num)
				{
				}
				num = (short)1589313537;
				if (num != 0)
				{
				}
				num = (short)1003683840;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.HiddenStatic;
			}
			set
			{
				short num = (short)836698112;
				short num2 = num;
				num = (short)2090222489;
				short num3 = num;
				num = (short)1988510617;
				switch (num3 == num)
				{
				}
				num = (short)862060545;
				if (num != 0)
				{
				}
				num = (short)481361920;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.HiddenStatic = value;
			}
		}

		// Token: 0x170046CA RID: 18122
		// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x0082DBB8 File Offset: 0x0082BDB8
		// (set) Token: 0x06008BC7 RID: 35783 RVA: 0x0082DC6C File Offset: 0x0082BE6C
		internal bool CHO2EmergencyButtonBCO_A41271_HiddenDynamic
		{
			get
			{
				short num = (short)2102329344;
				short num2 = num;
				num = (short)1151444115;
				short num3 = num;
				num = (short)387622035;
				switch (num3 == num)
				{
				}
				num = (short)1104805888;
				if (num != 0)
				{
				}
				num = (short)1310130177;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271.HiddenDynamic;
			}
			set
			{
				short num = (short)429654016;
				short num2 = num;
				num = (short)1628186143;
				short num3 = num;
				num = (short)1819354655;
				switch (num3 == num)
				{
				}
				num = (short)1960443905;
				if (num != 0)
				{
				}
				num = (short)493092864;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonBCO_A41271.HiddenDynamic = value;
			}
		}

		// Token: 0x170046CB RID: 18123
		// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x0082DD20 File Offset: 0x0082BF20
		public bool CHO2EmergencyButtonBCO_A41271_HasDiffs
		{
			get
			{
				short num = (short)2109669376;
				short num2 = num;
				num = (short)1097759512;
				short num3 = num;
				num = (short)1664449304;
				switch (num3 == num)
				{
				}
				num = (short)2118451201;
				if (num != 0)
				{
				}
				num = (short)191561728;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonBCO_A41271._HasDiffs;
			}
		}

		// Token: 0x170046CC RID: 18124
		// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x0082DDD4 File Offset: 0x0082BFD4
		// (set) Token: 0x06008BCA RID: 35786 RVA: 0x0082DE8C File Offset: 0x0082C08C
		public int CHO2EmergencyButtonFeature_A41272Value
		{
			get
			{
				short num = (short)1663959040;
				short num2 = num;
				num = (short)748224959;
				short num3 = num;
				num = (short)203424191;
				switch (num3 == num)
				{
				}
				num = (short)2039283712;
				if (num != 0)
				{
				}
				num = (short)322568193;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.Value;
			}
			set
			{
				short num = (short)485752832;
				short num2 = num;
				num = (short)2119172097;
				if (num != 0)
				{
				}
				num = (short)1088888135;
				short num3 = num;
				num = (short)1408048455;
				switch (num3 == num)
				{
				}
				num = (short)1224146944;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.Value = value;
			}
		}

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x06008BCB RID: 35787 RVA: 0x0082DF40 File Offset: 0x0082C140
		// (set) Token: 0x06008BCC RID: 35788 RVA: 0x0082DFF4 File Offset: 0x0082C1F4
		public string CHO2EmergencyButtonFeature_A41272_UIValue
		{
			get
			{
				short num = (short)1714946048;
				short num2 = num;
				num = (short)48057816;
				short num3 = num;
				num = (short)687623640;
				switch (num3 == num)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)1506082816;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.UIValue;
			}
			set
			{
				short num = (short)1520041984;
				short num2 = num;
				num = (short)1312108373;
				short num3 = num;
				num = (short)271986517;
				switch (num3 == num)
				{
				}
				num = (short)2121465856;
				if (num != 0)
				{
				}
				num = (short)2054291457;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.UIValue = value;
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x06008BCD RID: 35789 RVA: 0x0082E0A8 File Offset: 0x0082C2A8
		public global::AcpBusinessLayer.AcpListField CHO2EmergencyButtonFeature_A41272
		{
			get
			{
				short num = (short)1218052096;
				short num2 = num;
				num = (short)1452990399;
				short num3 = num;
				num = (short)808509375;
				switch (num3 == num)
				{
				}
				num = (short)1141571585;
				if (num != 0)
				{
				}
				num = (short)1647116288;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272;
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x06008BCE RID: 35790 RVA: 0x0082E158 File Offset: 0x0082C358
		// (set) Token: 0x06008BCF RID: 35791 RVA: 0x0082E20C File Offset: 0x0082C40C
		public bool CHO2EmergencyButtonFeature_A41272_Applicable
		{
			get
			{
				short num = (short)689242112;
				short num2 = num;
				num = (short)1723178489;
				short num3 = num;
				num = (short)1909431801;
				switch (num3 == num)
				{
				}
				num = (short)1380843521;
				if (num != 0)
				{
				}
				num = (short)1456209920;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.Applicable;
			}
			set
			{
				short num = (short)2102984704;
				short num2 = num;
				num = (short)822849917;
				short num3 = num;
				num = (short)1148957053;
				switch (num3 == num)
				{
				}
				num = (short)1051066369;
				if (num != 0)
				{
				}
				num = (short)1543831552;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.Applicable = value;
			}
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x0082E2C0 File Offset: 0x0082C4C0
		// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x0082E378 File Offset: 0x0082C578
		public bool CHO2EmergencyButtonFeature_A41272_Valid
		{
			get
			{
				short num = (short)1260912640;
				short num2 = num;
				num = (short)1862179257;
				short num3 = num;
				num = (short)1386060217;
				switch (num3 == num)
				{
				}
				num = (short)1901395969;
				if (num != 0)
				{
				}
				num = (short)49676288;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.Valid;
			}
			set
			{
				short num = (short)3670016;
				short num2 = num;
				num = (short)108628403;
				short num3 = num;
				num = (short)157125043;
				switch (num3 == num)
				{
				}
				num = (short)1115815937;
				if (num != 0)
				{
				}
				num = (short)706150400;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.Valid = value;
			}
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x0082E42C File Offset: 0x0082C62C
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x0082E4E0 File Offset: 0x0082C6E0
		public bool CHO2EmergencyButtonFeature_A41272_Visible
		{
			get
			{
				short num = (short)636813312;
				short num2 = num;
				num = (short)1367250721;
				short num3 = num;
				num = (short)1735169825;
				switch (num3 == num)
				{
				}
				num = (short)1440219137;
				if (num != 0)
				{
				}
				num = (short)1949433856;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.Visible;
			}
			set
			{
				short num = (short)334954496;
				short num2 = num;
				num = (short)1270630084;
				short num3 = num;
				num = (short)661210820;
				switch (num3 == num)
				{
				}
				num = (short)1231159297;
				if (num != 0)
				{
				}
				num = (short)1699872768;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.Visible = value;
			}
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x0082E594 File Offset: 0x0082C794
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x0082E648 File Offset: 0x0082C848
		public bool CHO2EmergencyButtonFeature_A41272_Editable
		{
			get
			{
				short num = (short)1562705920;
				short num2 = num;
				num = (short)963837953;
				if (num != 0)
				{
				}
				num = (short)1745119009;
				short num3 = num;
				num = (short)1248487201;
				switch (num3 == num)
				{
				}
				num = (short)709492736;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.Editable;
			}
			set
			{
				short num = (short)1952514048;
				short num2 = num;
				num = (short)176150860;
				short num3 = num;
				num = (short)895015244;
				switch (num3 == num)
				{
				}
				num = (short)74383361;
				if (num != 0)
				{
				}
				num = (short)1411448832;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.Editable = value;
			}
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x0082E700 File Offset: 0x0082C900
		internal string CHO2EmergencyButtonFeature_A41272_UILabel
		{
			get
			{
				short num = (short)2048196608;
				short num2 = num;
				num = (short)1671563457;
				short num3 = num;
				num = (short)664799425;
				switch (num3 == num)
				{
				}
				num = (short)306118656;
				if (num != 0)
				{
				}
				num = (short)1494286337;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.UIName;
			}
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x06008BD7 RID: 35799 RVA: 0x0082E7B4 File Offset: 0x0082C9B4
		// (set) Token: 0x06008BD8 RID: 35800 RVA: 0x0082E868 File Offset: 0x0082CA68
		internal bool CHO2EmergencyButtonFeature_A41272_HiddenStatic
		{
			get
			{
				short num = (short)131792896;
				short num2 = num;
				num = (short)2132541441;
				if (num != 0)
				{
				}
				num = (short)491376400;
				short num3 = num;
				num = (short)1281412880;
				switch (num3 == num)
				{
				}
				num = (short)90112000;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.HiddenStatic;
			}
			set
			{
				short num = (short)653328384;
				short num2 = num;
				num = (short)325973559;
				short num3 = num;
				num = (short)585561655;
				switch (num3 == num)
				{
				}
				num = (short)2039152641;
				if (num != 0)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.HiddenStatic = value;
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x0082E91C File Offset: 0x0082CB1C
		// (set) Token: 0x06008BDA RID: 35802 RVA: 0x0082E9D0 File Offset: 0x0082CBD0
		internal bool CHO2EmergencyButtonFeature_A41272_HiddenDynamic
		{
			get
			{
				short num = (short)1880424448;
				short num2 = num;
				num = (short)1603539598;
				short num3 = num;
				num = (short)1477710478;
				switch (num3 == num)
				{
				}
				num = (short)1361838081;
				if (num != 0)
				{
				}
				num = (short)1401880576;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272.HiddenDynamic;
			}
			set
			{
				short num = (short)1924988928;
				short num2 = num;
				num = (short)755510409;
				short num3 = num;
				num = (short)1812016265;
				switch (num3 == num)
				{
				}
				num = (short)662110209;
				if (num != 0)
				{
				}
				num = (short)196608000;
				if (num != 0)
				{
				}
				this.cHO2EmergencyButtonFeature_A41272.HiddenDynamic = value;
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x06008BDB RID: 35803 RVA: 0x0082EA84 File Offset: 0x0082CC84
		public bool CHO2EmergencyButtonFeature_A41272_HasDiffs
		{
			get
			{
				short num = (short)2086404096;
				short num2 = num;
				num = (short)740785995;
				short num3 = num;
				num = (short)1553235787;
				switch (num3 == num)
				{
				}
				num = (short)1372848129;
				if (num != 0)
				{
				}
				num = (short)531562496;
				if (num != 0)
				{
				}
				return this.cHO2EmergencyButtonFeature_A41272._HasDiffs;
			}
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x06008BDC RID: 35804 RVA: 0x0082EB3C File Offset: 0x0082CD3C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1511718912;
				short num2 = num;
				num = (short)760807425;
				if (num != 0)
				{
				}
				num = (short)1026882089;
				short num3 = num;
				num = (short)115735081;
				switch (num3 == num)
				{
				}
				num = (short)1761083392;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x06008BDD RID: 35805 RVA: 0x0082EC00 File Offset: 0x0082CE00
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)2006646784;
				short num2 = num;
				num = (short)219742209;
				if (num != 0)
				{
				}
				num = (short)957366302;
				short num3 = num;
				num = (short)1115897886;
				switch (num3 == num)
				{
				}
				num = (short)1690238976;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x0082ECC0 File Offset: 0x0082CEC0
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
				{
					num2 = (short)1623457793;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)216197400;
					short num3 = num2;
					num2 = (short)480831768;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E4;
					default:
						num2 = (short)197197824;
						if (num2 != 0)
						{
						}
						num2 = (short)279379971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)176685056;
					short num4 = num2;
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)431161348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					return result;
				case 3:
					num2 = (short)5636097;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_E4;
				}
				goto IL_24;
				IL_E4:
				num2 = (short)541720578;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1744633856;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040043E1 RID: 17377
		private global::AcpBusinessLayer.AcpField<string> cHO2EmergencyButtonName_A41270;

		// Token: 0x040043E2 RID: 17378
		private global::AcpBusinessLayer.AcpListField cHO2EmergencyButtonBCO_A41271;

		// Token: 0x040043E3 RID: 17379
		private global::AcpBusinessLayer.AcpListField cHO2EmergencyButtonFeature_A41272;
	}
}
