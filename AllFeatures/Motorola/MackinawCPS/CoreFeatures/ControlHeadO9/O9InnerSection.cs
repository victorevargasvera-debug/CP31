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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000375 RID: 885
	[global::System.Serializable]
	public class O9InnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008327 RID: 33575 RVA: 0x007A0A04 File Offset: 0x0079EC04
		public O9InnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x007A0A20 File Offset: 0x0079EC20
		protected O9InnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x007A0A38 File Offset: 0x0079EC38
		public override void Init()
		{
			int a_ = 3;
			short num = (short)72429938;
			short num2 = num;
			num = (short)1825190258;
			switch (num2 == num)
			{
			}
			num = (short)555679744;
			short num3 = num;
			num = (short)330694657;
			if (num != 0)
			{
			}
			num = (short)316211200;
			if (num != 0)
			{
			}
			this.cHO9EmergencyButtonName_A36680 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("蟃軅蟇觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧ꓩ跫菭闯귱뗳엵컷쳹쓻컽", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO9EmergencyButtonName_A36680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9EmergencyButtonName_A36680.DataTransferOrder = -1;
			this.cHO9EmergencyButtonBCO_A36681 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9EmergencyButtonBCO_A36681LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9EmergencyButtonBCO_A36681LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟃軅蟇觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧꣩꿫ꇭ꿯돱쟳샵컷싹췻", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9EmergencyButtonBCO_A36681LovStrs);
			this.cHO9EmergencyButtonBCO_A36681.IgnoreOnCompare = true;
			this.cHO9EmergencyButtonBCO_A36681.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9EmergencyButtonBCO_A36681.DataTransferOrder = -1;
			this.cHO9EmergencyButtonFeature_A36682 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9EmergencyButtonFeature_A36682LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9EmergencyButtonFeature_A36682LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟃軅蟇觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧곩觫迭蓯蟱蛳鏵ꟷ믹쿻죽㛿㨁㘃", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9EmergencyButtonFeature_A36682LovStrs);
			this.cHO9EmergencyButtonFeature_A36682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9EmergencyButtonFeature_A36682.DataTransferOrder = 17;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诃ￅ", a_);
			base.Id = 10627;
			base.UIName = global::CommonResources.AcgResources.ID_O9;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x007A0C04 File Offset: 0x0079EE04
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1189281792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1089142785;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫꣭闯鏱胳菵諷鿹ꏻ뿽㏿㐁㈃㸅㨇", a_)))
					{
						num = (short)457048068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_376;
				case 2:
					this.cHO9EmergencyButtonName_A36680 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫ꃭ釯鿱釳꧵맷짹쫻죽㣿㈁", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO9EmergencyButtonName_A36680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9EmergencyButtonName_A36680.DataTransferOrder = -1;
					num = (short)1146945541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫ꃭ釯鿱釳꧵맷짹쫻죽㣿㈁", a_)))
					{
						num = (short)1165950978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 4:
					this.cHO9EmergencyButtonFeature_A36682 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9EmergencyButtonFeature_A36682LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9EmergencyButtonFeature_A36682LovStrs), this, global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫꣭闯鏱胳菵諷鿹ꏻ뿽㏿㐁㈃㸅㨇", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9EmergencyButtonFeature_A36682LovStrs);
					this.cHO9EmergencyButtonFeature_A36682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9EmergencyButtonFeature_A36682.DataTransferOrder = 17;
					num = (short)1124073482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_195;
				case 6:
					num = (short)941359107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)41746438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_376;
				case 8:
					num = (short)1316552711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					this.cHO9EmergencyButtonBCO_A36681 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9EmergencyButtonBCO_A36681LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9EmergencyButtonBCO_A36681LovStrs), this, global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫곭돯뷱꯳럵쯷쳹쫻웽ㇿ", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9EmergencyButtonBCO_A36681LovStrs);
					this.cHO9EmergencyButtonBCO_A36681.IgnoreOnCompare = true;
					this.cHO9EmergencyButtonBCO_A36681.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9EmergencyButtonBCO_A36681.DataTransferOrder = -1;
					num = (short)1168480652;
					short num3 = num;
					num = (short)1834064268;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AC;
					default:
						num = (short)878182400;
						if (num != 0)
						{
						}
						num = (short)556335115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					goto IL_292;
				case 11:
				{
					num = (short)157024256;
					short num4 = num;
					goto IL_2D0;
				}
				case 12:
					goto IL_1AC;
				}
				IL_88:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1795686408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_195:
				num = (short)970784780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AC:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋闏뿑뇓ꓕ뿗뿙닛뷝駟ꃡ釣鋥鳧藩苫곭돯뷱꯳럵쯷쳹쫻웽ㇿ", a_)))
				{
					num = (short)1046937609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2D0:
				num = (short)383320065;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_292:
			IL_376:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟇", a_);
			base.Id = 10627;
			base.UIName = global::CommonResources.AcgResources.ID_O9;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x007A0FB8 File Offset: 0x0079F1B8
		public override void PopulateReferences()
		{
			short num = (short)20642784;
			short num2 = num;
			num = (short)2023685088;
			switch (num2 == num)
			{
			}
			num = (short)590020608;
			short num3 = num;
			num = (short)1780547585;
			if (num != 0)
			{
			}
			num = (short)1070006272;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x007A1060 File Offset: 0x0079F260
		public override void DropReferences()
		{
			short num = (short)1808203777;
			if (num != 0)
			{
			}
			num = (short)9430687;
			short num2 = num;
			num = (short)2077091487;
			switch (num2 == num)
			{
			default:
			{
				num = (short)194052096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1327431680;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x007A1108 File Offset: 0x0079F308
		public override void SetConstraints()
		{
			short num = (short)1122615062;
			short num2 = num;
			num = (short)1993916182;
			switch (num2 == num)
			{
			}
			num = (short)1887502336;
			short num3 = num;
			num = (short)1055522817;
			if (num != 0)
			{
			}
			num = (short)54919168;
			if (num != 0)
			{
			}
			this.cHO9EmergencyButtonName_A36680.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO9EmergencyButtonFeature_A36682.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9EmergencyButtonFeature_A36682.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConControlHeadEmergencyFeaturesSelect);
			this.cHO9EmergencyButtonFeature_A36682.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncOrangeBtn);
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x007A1214 File Offset: 0x0079F414
		public override void SetupDependencies()
		{
			short num = (short)126832154;
			short num2 = num;
			num = (short)769019418;
			switch (num2 == num)
			{
			}
			num = (short)1067581440;
			short num3 = num;
			num = (short)2046099456;
			if (num != 0)
			{
			}
			num = (short)832307201;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
			this.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
			this.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cHO9EmergencyButtonFeature_A36682);
		}

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0600832F RID: 33583 RVA: 0x007A1368 File Offset: 0x0079F568
		public bool HasDiffs
		{
			get
			{
				short num = (short)1657415333;
				short num2 = num;
				num = (short)1020405413;
				switch (num2 == num)
				{
				}
				num = (short)1286602752;
				short num3 = num;
				num = (short)1944846337;
				if (num != 0)
				{
				}
				num = (short)868417536;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x007A1418 File Offset: 0x0079F618
		// (set) Token: 0x06008331 RID: 33585 RVA: 0x007A14CC File Offset: 0x0079F6CC
		public string CHO9EmergencyButtonName_A36680Value
		{
			get
			{
				short num = (short)1407449224;
				short num2 = num;
				num = (short)762968200;
				switch (num2 == num)
				{
				}
				num = (short)819658752;
				short num3 = num;
				num = (short)1507917824;
				if (num != 0)
				{
				}
				num = (short)1591345153;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Value;
			}
			set
			{
				short num = (short)835651553;
				short num2 = num;
				num = (short)702810081;
				switch (num2 == num)
				{
				}
				num = (short)882900992;
				short num3 = num;
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)1655177216;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Value = value;
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x06008332 RID: 33586 RVA: 0x007A1580 File Offset: 0x0079F780
		public global::AcpBusinessLayer.AcpField<string> CHO9EmergencyButtonName_A36680
		{
			get
			{
				short num = (short)1722088925;
				short num2 = num;
				num = (short)1588788701;
				switch (num2 == num)
				{
				}
				num = (short)11730944;
				short num3 = num;
				num = (short)1073283072;
				if (num != 0)
				{
				}
				num = (short)1499594753;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680;
			}
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x06008333 RID: 33587 RVA: 0x007A1630 File Offset: 0x0079F830
		// (set) Token: 0x06008334 RID: 33588 RVA: 0x007A16E0 File Offset: 0x0079F8E0
		public string CHO9EmergencyButtonName_A36680_UIValue
		{
			get
			{
				short num = (short)1264260702;
				short num2 = num;
				num = (short)129242718;
				switch (num2 == num)
				{
				}
				num = (short)1647247360;
				short num3 = num;
				num = (short)790626305;
				if (num != 0)
				{
				}
				num = (short)1658978304;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Value;
			}
			set
			{
				short num = (short)2094286002;
				short num2 = num;
				num = (short)1857766578;
				switch (num2 == num)
				{
				}
				num = (short)791805952;
				short num3 = num;
				num = (short)1218969601;
				if (num != 0)
				{
				}
				num = (short)1842216960;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Value = value;
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x06008335 RID: 33589 RVA: 0x007A1794 File Offset: 0x0079F994
		// (set) Token: 0x06008336 RID: 33590 RVA: 0x007A184C File Offset: 0x0079FA4C
		public bool CHO9EmergencyButtonName_A36680_Applicable
		{
			get
			{
				short num = (short)576496783;
				short num2 = num;
				num = (short)1186636943;
				switch (num2 == num)
				{
				}
				num = (short)1941569536;
				short num3 = num;
				num = (short)730529792;
				if (num != 0)
				{
				}
				num = (short)1667825665;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Applicable;
			}
			set
			{
				short num = (short)622361279;
				short num2 = num;
				num = (short)1920301759;
				switch (num2 == num)
				{
				}
				num = (short)1348009984;
				short num3 = num;
				num = (short)1542717440;
				if (num != 0)
				{
				}
				num = (short)1186725889;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Applicable = value;
			}
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x06008337 RID: 33591 RVA: 0x007A1904 File Offset: 0x0079FB04
		// (set) Token: 0x06008338 RID: 33592 RVA: 0x007A19B8 File Offset: 0x0079FBB8
		public bool CHO9EmergencyButtonName_A36680_Valid
		{
			get
			{
				short num = (short)1219205835;
				short num2 = num;
				num = (short)1560976075;
				switch (num2 == num)
				{
				}
				num = (short)1971453952;
				short num3 = num;
				num = (short)1311506433;
				if (num != 0)
				{
				}
				num = (short)2115764224;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Valid;
			}
			set
			{
				short num = (short)765984769;
				if (num != 0)
				{
				}
				num = (short)1176586742;
				short num2 = num;
				num = (short)1240484342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107768832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019426304;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Valid = value;
			}
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x06008339 RID: 33593 RVA: 0x007A1A70 File Offset: 0x0079FC70
		// (set) Token: 0x0600833A RID: 33594 RVA: 0x007A1B24 File Offset: 0x0079FD24
		public bool CHO9EmergencyButtonName_A36680_Visible
		{
			get
			{
				short num = (short)191387735;
				short num2 = num;
				num = (short)1563318359;
				switch (num2 == num)
				{
				}
				num = (short)1491599360;
				short num3 = num;
				num = (short)260964352;
				if (num != 0)
				{
				}
				num = (short)432406529;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Visible;
			}
			set
			{
				short num = (short)1381957633;
				if (num != 0)
				{
				}
				num = (short)2003007723;
				short num2 = num;
				num = (short)572029163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13762560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1175322624;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Visible = value;
			}
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x0600833B RID: 33595 RVA: 0x007A1BD8 File Offset: 0x0079FDD8
		// (set) Token: 0x0600833C RID: 33596 RVA: 0x007A1C8C File Offset: 0x0079FE8C
		public bool CHO9EmergencyButtonName_A36680_Editable
		{
			get
			{
				short num = (short)1423750076;
				short num2 = num;
				num = (short)1834529724;
				switch (num2 == num)
				{
				}
				num = (short)811728896;
				short num3 = num;
				num = (short)751042561;
				if (num != 0)
				{
				}
				num = (short)433258496;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.Editable;
			}
			set
			{
				short num = (short)1507797471;
				short num2 = num;
				num = (short)1543776735;
				switch (num2 == num)
				{
				}
				num = (short)1387528192;
				short num3 = num;
				num = (short)941424640;
				if (num != 0)
				{
				}
				num = (short)113180673;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.Editable = value;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x0600833D RID: 33597 RVA: 0x007A1D40 File Offset: 0x0079FF40
		internal string CHO9EmergencyButtonName_A36680_UILabel
		{
			get
			{
				short num = (short)532447376;
				short num2 = num;
				num = (short)157909136;
				switch (num2 == num)
				{
				}
				num = (short)2107113472;
				short num3 = num;
				num = (short)311099393;
				if (num != 0)
				{
				}
				num = (short)262209536;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.UIName;
			}
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x0600833E RID: 33598 RVA: 0x007A1DF8 File Offset: 0x0079FFF8
		// (set) Token: 0x0600833F RID: 33599 RVA: 0x007A1EAC File Offset: 0x007A00AC
		internal bool CHO9EmergencyButtonName_A36680_HiddenStatic
		{
			get
			{
				short num = (short)608986165;
				short num2 = num;
				num = (short)480273461;
				switch (num2 == num)
				{
				}
				num = (short)1085800448;
				short num3 = num;
				num = (short)490405889;
				if (num != 0)
				{
				}
				num = (short)419364864;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.HiddenStatic;
			}
			set
			{
				short num = (short)1527016399;
				short num2 = num;
				num = (short)1966697423;
				switch (num2 == num)
				{
				}
				num = (short)952958976;
				short num3 = num;
				num = (short)953810945;
				if (num != 0)
				{
				}
				num = (short)416350208;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.HiddenStatic = value;
			}
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x06008340 RID: 33600 RVA: 0x007A1F60 File Offset: 0x007A0160
		// (set) Token: 0x06008341 RID: 33601 RVA: 0x007A2018 File Offset: 0x007A0218
		internal bool CHO9EmergencyButtonName_A36680_HiddenDynamic
		{
			get
			{
				short num = (short)654346680;
				short num2 = num;
				num = (short)609585592;
				switch (num2 == num)
				{
				}
				num = (short)1883766784;
				short num3 = num;
				num = (short)633864193;
				if (num != 0)
				{
				}
				num = (short)1185742848;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680.HiddenDynamic;
			}
			set
			{
				short num = (short)773567217;
				short num2 = num;
				num = (short)417444593;
				switch (num2 == num)
				{
				}
				num = (short)333578240;
				short num3 = num;
				num = (short)610467840;
				if (num != 0)
				{
				}
				num = (short)411303937;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonName_A36680.HiddenDynamic = value;
			}
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x06008342 RID: 33602 RVA: 0x007A20D0 File Offset: 0x007A02D0
		public bool CHO9EmergencyButtonName_A36680_HasDiffs
		{
			get
			{
				short num = (short)149230402;
				short num2 = num;
				num = (short)2069500738;
				switch (num2 == num)
				{
				}
				num = (short)1234894848;
				short num3 = num;
				num = (short)623116289;
				if (num != 0)
				{
				}
				num = (short)197328896;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonName_A36680._HasDiffs;
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x06008343 RID: 33603 RVA: 0x007A2188 File Offset: 0x007A0388
		// (set) Token: 0x06008344 RID: 33604 RVA: 0x007A223C File Offset: 0x007A043C
		public int CHO9EmergencyButtonBCO_A36681Value
		{
			get
			{
				short num = (short)1671810528;
				short num2 = num;
				num = (short)1472843232;
				switch (num2 == num)
				{
				}
				num = (short)1576730624;
				short num3 = num;
				num = (short)1136984065;
				if (num != 0)
				{
				}
				num = (short)2106982400;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.Value;
			}
			set
			{
				short num = (short)1998343600;
				short num2 = num;
				num = (short)336219568;
				switch (num2 == num)
				{
				}
				num = (short)993853440;
				short num3 = num;
				num = (short)316145665;
				if (num != 0)
				{
				}
				num = (short)549388288;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.Value = value;
			}
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x06008345 RID: 33605 RVA: 0x007A22F0 File Offset: 0x007A04F0
		// (set) Token: 0x06008346 RID: 33606 RVA: 0x007A23A8 File Offset: 0x007A05A8
		public string CHO9EmergencyButtonBCO_A36681_UIValue
		{
			get
			{
				short num = (short)1321533441;
				if (num != 0)
				{
				}
				num = (short)1415523342;
				short num2 = num;
				num = (short)390081550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761462784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855848448;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.UIValue;
			}
			set
			{
				short num = (short)288197335;
				short num2 = num;
				num = (short)1930070743;
				switch (num2 == num)
				{
				}
				num = (short)908460032;
				short num3 = num;
				num = (short)1562509312;
				if (num != 0)
				{
				}
				num = (short)1246691329;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.UIValue = value;
			}
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x06008347 RID: 33607 RVA: 0x007A2460 File Offset: 0x007A0660
		public global::AcpBusinessLayer.AcpListField CHO9EmergencyButtonBCO_A36681
		{
			get
			{
				short num = (short)1844707329;
				if (num != 0)
				{
				}
				num = (short)667036026;
				short num2 = num;
				num = (short)1613113722;
				switch (num2 == num)
				{
				}
				num = (short)205324288;
				short num3 = num;
				num = (short)482672640;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681;
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x007A250C File Offset: 0x007A070C
		// (set) Token: 0x06008349 RID: 33609 RVA: 0x007A25C0 File Offset: 0x007A07C0
		public bool CHO9EmergencyButtonBCO_A36681_Applicable
		{
			get
			{
				short num = (short)157089793;
				if (num != 0)
				{
				}
				num = (short)135732318;
				short num2 = num;
				num = (short)639769694;
				switch (num2 == num)
				{
				}
				num = (short)1574436864;
				short num3 = num;
				num = (short)1570373632;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.Applicable;
			}
			set
			{
				short num = (short)1628018526;
				short num2 = num;
				num = (short)922589022;
				switch (num2 == num)
				{
				}
				num = (short)392757249;
				if (num != 0)
				{
				}
				num = (short)588251136;
				short num3 = num;
				num = (short)567279616;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.Applicable = value;
			}
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x007A2674 File Offset: 0x007A0874
		// (set) Token: 0x0600834B RID: 33611 RVA: 0x007A2728 File Offset: 0x007A0928
		public bool CHO9EmergencyButtonBCO_A36681_Valid
		{
			get
			{
				short num = (short)76148009;
				short num2 = num;
				num = (short)444001577;
				switch (num2 == num)
				{
				}
				num = (short)1307770881;
				if (num != 0)
				{
				}
				num = (short)232849408;
				short num3 = num;
				num = (short)299368448;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.Valid;
			}
			set
			{
				short num = (short)242990671;
				short num2 = num;
				num = (short)981974607;
				switch (num2 == num)
				{
				}
				num = (short)1254096897;
				if (num != 0)
				{
				}
				num = (short)1586298880;
				short num3 = num;
				num = (short)1760886784;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.Valid = value;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x0600834C RID: 33612 RVA: 0x007A27DC File Offset: 0x007A09DC
		// (set) Token: 0x0600834D RID: 33613 RVA: 0x007A2894 File Offset: 0x007A0A94
		public bool CHO9EmergencyButtonBCO_A36681_Visible
		{
			get
			{
				short num = (short)793059310;
				short num2 = num;
				num = (short)328277998;
				switch (num2 == num)
				{
				}
				num = (short)1785200640;
				if (num != 0)
				{
				}
				num = (short)1250426880;
				short num3 = num;
				num = (short)1308753921;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.Visible;
			}
			set
			{
				short num = (short)1630023946;
				short num2 = num;
				num = (short)395456778;
				switch (num2 == num)
				{
				}
				num = (short)1742864385;
				if (num != 0)
				{
				}
				num = (short)134742016;
				short num3 = num;
				num = (short)1218445312;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.Visible = value;
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x0600834E RID: 33614 RVA: 0x007A2948 File Offset: 0x007A0B48
		// (set) Token: 0x0600834F RID: 33615 RVA: 0x007A2A00 File Offset: 0x007A0C00
		public bool CHO9EmergencyButtonBCO_A36681_Editable
		{
			get
			{
				short num = (short)1966323970;
				short num2 = num;
				num = (short)1032108290;
				switch (num2 == num)
				{
				}
				num = (short)336003072;
				if (num != 0)
				{
				}
				num = (short)1643708416;
				short num3 = num;
				num = (short)1465647105;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.Editable;
			}
			set
			{
				short num = (short)1534603592;
				short num2 = num;
				num = (short)1753100616;
				switch (num2 == num)
				{
				}
				num = (short)824311809;
				if (num != 0)
				{
				}
				num = (short)2072444928;
				short num3 = num;
				num = (short)1261699072;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.Editable = value;
			}
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x007A2AB4 File Offset: 0x007A0CB4
		internal string CHO9EmergencyButtonBCO_A36681_UILabel
		{
			get
			{
				short num = (short)1612568625;
				short num2 = num;
				num = (short)7460913;
				switch (num2 == num)
				{
				}
				num = (short)1686831104;
				if (num != 0)
				{
				}
				num = (short)1405222912;
				short num3 = num;
				num = (short)1575944193;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.UIName;
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x007A2B68 File Offset: 0x007A0D68
		// (set) Token: 0x06008352 RID: 33618 RVA: 0x007A2C1C File Offset: 0x007A0E1C
		internal bool CHO9EmergencyButtonBCO_A36681_HiddenStatic
		{
			get
			{
				short num = (short)492290191;
				short num2 = num;
				num = (short)2049556623;
				switch (num2 == num)
				{
				}
				num = (short)1715798017;
				if (num != 0)
				{
				}
				num = (short)640483328;
				short num3 = num;
				num = (short)1058340864;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.HiddenStatic;
			}
			set
			{
				short num = (short)1867692914;
				short num2 = num;
				num = (short)1606531954;
				switch (num2 == num)
				{
				}
				num = (short)2127888384;
				if (num != 0)
				{
				}
				num = (short)1235746816;
				short num3 = num;
				num = (short)406257665;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.HiddenStatic = value;
			}
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x06008353 RID: 33619 RVA: 0x007A2CD4 File Offset: 0x007A0ED4
		// (set) Token: 0x06008354 RID: 33620 RVA: 0x007A2D88 File Offset: 0x007A0F88
		internal bool CHO9EmergencyButtonBCO_A36681_HiddenDynamic
		{
			get
			{
				short num = (short)1432317463;
				short num2 = num;
				num = (short)211381783;
				switch (num2 == num)
				{
				}
				num = (short)1220935681;
				if (num != 0)
				{
				}
				num = (short)547422208;
				short num3 = num;
				num = (short)617611264;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681.HiddenDynamic;
			}
			set
			{
				short num = (short)932184065;
				if (num != 0)
				{
				}
				num = (short)334790286;
				short num2 = num;
				num = (short)117210766;
				switch (num2 == num)
				{
				}
				num = (short)2065235968;
				short num3 = num;
				num = (short)1195180032;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonBCO_A36681.HiddenDynamic = value;
			}
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x007A2E40 File Offset: 0x007A1040
		public bool CHO9EmergencyButtonBCO_A36681_HasDiffs
		{
			get
			{
				short num = (short)1289441402;
				short num2 = num;
				num = (short)1363562618;
				switch (num2 == num)
				{
				}
				num = (short)1918107649;
				if (num != 0)
				{
				}
				num = (short)1349189632;
				short num3 = num;
				num = (short)461045760;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonBCO_A36681._HasDiffs;
			}
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x06008356 RID: 33622 RVA: 0x007A2EF4 File Offset: 0x007A10F4
		// (set) Token: 0x06008357 RID: 33623 RVA: 0x007A2FA8 File Offset: 0x007A11A8
		public int CHO9EmergencyButtonFeature_A36682Value
		{
			get
			{
				short num = (short)680678170;
				short num2 = num;
				num = (short)75256602;
				switch (num2 == num)
				{
				}
				num = (short)759103489;
				if (num != 0)
				{
				}
				num = (short)803864576;
				short num3 = num;
				num = (short)1236140032;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.Value;
			}
			set
			{
				short num = (short)981865570;
				short num2 = num;
				num = (short)1310659682;
				switch (num2 == num)
				{
				}
				num = (short)269877248;
				if (num != 0)
				{
				}
				num = (short)335937536;
				short num3 = num;
				num = (short)398000129;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.Value = value;
			}
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x06008358 RID: 33624 RVA: 0x007A305C File Offset: 0x007A125C
		// (set) Token: 0x06008359 RID: 33625 RVA: 0x007A3110 File Offset: 0x007A1310
		public string CHO9EmergencyButtonFeature_A36682_UIValue
		{
			get
			{
				short num = (short)436928512;
				short num2 = num;
				num = (short)1230674059;
				short num3 = num;
				num = (short)67541131;
				switch (num3 == num)
				{
				}
				num = (short)1610547201;
				if (num != 0)
				{
				}
				num = (short)60489728;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.UIValue;
			}
			set
			{
				short num = (short)1405419520;
				short num2 = num;
				num = (short)76917901;
				short num3 = num;
				num = (short)2036968589;
				switch (num3 == num)
				{
				}
				num = (short)1922498560;
				if (num != 0)
				{
				}
				num = (short)1798897665;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.UIValue = value;
			}
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x007A31C4 File Offset: 0x007A13C4
		public global::AcpBusinessLayer.AcpListField CHO9EmergencyButtonFeature_A36682
		{
			get
			{
				short num = (short)959643648;
				short num2 = num;
				num = (short)1391169677;
				short num3 = num;
				num = (short)1914474637;
				switch (num3 == num)
				{
				}
				num = (short)2024079361;
				if (num != 0)
				{
				}
				num = (short)147980288;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682;
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x0600835B RID: 33627 RVA: 0x007A3274 File Offset: 0x007A1474
		// (set) Token: 0x0600835C RID: 33628 RVA: 0x007A3328 File Offset: 0x007A1528
		public bool CHO9EmergencyButtonFeature_A36682_Applicable
		{
			get
			{
				short num = (short)219414528;
				short num2 = num;
				num = (short)2042171148;
				short num3 = num;
				num = (short)1958940428;
				switch (num3 == num)
				{
				}
				num = (short)1922826241;
				if (num != 0)
				{
				}
				num = (short)1034682368;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.Applicable;
			}
			set
			{
				short num = (short)1885405184;
				short num2 = num;
				num = (short)197422781;
				short num3 = num;
				num = (short)965373629;
				switch (num3 == num)
				{
				}
				num = (short)844234753;
				if (num != 0)
				{
				}
				num = (short)249692160;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.Applicable = value;
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x0600835D RID: 33629 RVA: 0x007A33E0 File Offset: 0x007A15E0
		// (set) Token: 0x0600835E RID: 33630 RVA: 0x007A3494 File Offset: 0x007A1694
		public bool CHO9EmergencyButtonFeature_A36682_Valid
		{
			get
			{
				short num = (short)291110912;
				short num2 = num;
				num = (short)1316927739;
				short num3 = num;
				num = (short)45660411;
				switch (num3 == num)
				{
				}
				num = (short)158531585;
				if (num != 0)
				{
				}
				num = (short)1956446208;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.Valid;
			}
			set
			{
				short num = (short)1933705216;
				short num2 = num;
				num = (short)1913558328;
				short num3 = num;
				num = (short)550278456;
				switch (num3 == num)
				{
				}
				num = (short)231866369;
				if (num != 0)
				{
				}
				num = (short)1988100096;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.Valid = value;
			}
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x007A3548 File Offset: 0x007A1748
		// (set) Token: 0x06008360 RID: 33632 RVA: 0x007A3600 File Offset: 0x007A1800
		public bool CHO9EmergencyButtonFeature_A36682_Visible
		{
			get
			{
				short num = (short)1106509824;
				short num2 = num;
				num = (short)343132237;
				short num3 = num;
				num = (short)1770899533;
				switch (num3 == num)
				{
				}
				num = (short)1769275393;
				if (num != 0)
				{
				}
				num = (short)928776192;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.Visible;
			}
			set
			{
				short num = (short)1548681216;
				short num2 = num;
				num = (short)1533070653;
				short num3 = num;
				num = (short)1966984509;
				switch (num3 == num)
				{
				}
				num = (short)528220161;
				if (num != 0)
				{
				}
				num = (short)1023737856;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.Visible = value;
			}
		}

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x06008361 RID: 33633 RVA: 0x007A36B4 File Offset: 0x007A18B4
		// (set) Token: 0x06008362 RID: 33634 RVA: 0x007A3768 File Offset: 0x007A1968
		public bool CHO9EmergencyButtonFeature_A36682_Editable
		{
			get
			{
				short num = (short)2069299200;
				short num2 = num;
				num = (short)2094017980;
				short num3 = num;
				num = (short)1579625916;
				switch (num3 == num)
				{
				}
				num = (short)853868545;
				if (num != 0)
				{
				}
				num = (short)960561152;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.Editable;
			}
			set
			{
				short num = (short)439156736;
				short num2 = num;
				num = (short)628847144;
				short num3 = num;
				num = (short)485126696;
				switch (num3 == num)
				{
				}
				num = (short)1954545665;
				if (num != 0)
				{
				}
				num = (short)1748434944;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.Editable = value;
			}
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x007A381C File Offset: 0x007A1A1C
		internal string CHO9EmergencyButtonFeature_A36682_UILabel
		{
			get
			{
				short num = (short)169213952;
				short num2 = num;
				num = (short)1554920365;
				short num3 = num;
				num = (short)908538797;
				switch (num3 == num)
				{
				}
				num = (short)244318209;
				if (num != 0)
				{
				}
				num = (short)439549952;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.UIName;
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x06008364 RID: 33636 RVA: 0x007A38D0 File Offset: 0x007A1AD0
		// (set) Token: 0x06008365 RID: 33637 RVA: 0x007A3984 File Offset: 0x007A1B84
		internal bool CHO9EmergencyButtonFeature_A36682_HiddenStatic
		{
			get
			{
				short num = (short)1454505984;
				short num2 = num;
				num = (short)1427286995;
				short num3 = num;
				num = (short)196979667;
				switch (num3 == num)
				{
				}
				num = (short)897187841;
				if (num != 0)
				{
				}
				num = (short)424542208;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.HiddenStatic;
			}
			set
			{
				short num = (short)602275840;
				short num2 = num;
				num = (short)152535098;
				short num3 = num;
				num = (short)1243643962;
				switch (num3 == num)
				{
				}
				num = (short)917110785;
				if (num != 0)
				{
				}
				num = (short)1230176256;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.HiddenStatic = value;
			}
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x06008366 RID: 33638 RVA: 0x007A3A38 File Offset: 0x007A1C38
		// (set) Token: 0x06008367 RID: 33639 RVA: 0x007A3AF0 File Offset: 0x007A1CF0
		internal bool CHO9EmergencyButtonFeature_A36682_HiddenDynamic
		{
			get
			{
				short num = (short)1305542656;
				short num2 = num;
				num = (short)234871028;
				short num3 = num;
				num = (short)496687348;
				switch (num3 == num)
				{
				}
				num = (short)347013121;
				if (num != 0)
				{
				}
				num = (short)1987641344;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682.HiddenDynamic;
			}
			set
			{
				short num = (short)1809907712;
				short num2 = num;
				num = (short)1921436794;
				short num3 = num;
				num = (short)1483983994;
				switch (num3 == num)
				{
				}
				num = (short)783155200;
				if (num != 0)
				{
				}
				num = (short)728039425;
				if (num != 0)
				{
				}
				this.cHO9EmergencyButtonFeature_A36682.HiddenDynamic = value;
			}
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x06008368 RID: 33640 RVA: 0x007A3BA4 File Offset: 0x007A1DA4
		public bool CHO9EmergencyButtonFeature_A36682_HasDiffs
		{
			get
			{
				short num = (short)702283776;
				short num2 = num;
				num = (short)303660298;
				short num3 = num;
				num = (short)1248230666;
				switch (num3 == num)
				{
				}
				num = (short)2079719425;
				if (num != 0)
				{
				}
				num = (short)1638400;
				if (num != 0)
				{
				}
				return this.cHO9EmergencyButtonFeature_A36682._HasDiffs;
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x007A3C58 File Offset: 0x007A1E58
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)883818496;
				short num2 = num;
				num = (short)1699861602;
				short num3 = num;
				num = (short)1477956706;
				switch (num3 == num)
				{
				}
				num = (short)1779564544;
				if (num != 0)
				{
				}
				num = (short)524681217;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x0600836A RID: 33642 RVA: 0x007A3D14 File Offset: 0x007A1F14
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)301727744;
				short num2 = num;
				num = (short)1058798080;
				short num3 = num;
				num = (short)1636956672;
				switch (num3 == num)
				{
				}
				num = (short)582877185;
				if (num != 0)
				{
				}
				num = (short)1829896192;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x007A3DD4 File Offset: 0x007A1FD4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num2 = (short)17039364;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
					{
						num2 = (short)1906638848;
						short num3 = num2;
						num2 = (short)434154835;
						short num4 = num2;
						num2 = (short)136883539;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)416219136;
							if (num2 != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)2007433217;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						num2 = (short)1467154433;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1462501378;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)1902706691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1853227008;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04003E56 RID: 15958
		private global::AcpBusinessLayer.AcpField<string> cHO9EmergencyButtonName_A36680;

		// Token: 0x04003E57 RID: 15959
		private global::AcpBusinessLayer.AcpListField cHO9EmergencyButtonBCO_A36681;

		// Token: 0x04003E58 RID: 15960
		private global::AcpBusinessLayer.AcpListField cHO9EmergencyButtonFeature_A36682;
	}
}
