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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F8 RID: 1016
	[global::System.Serializable]
	public class E5InnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008D31 RID: 36145 RVA: 0x00846AFC File Offset: 0x00844CFC
		public E5InnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00846B18 File Offset: 0x00844D18
		protected E5InnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x00846B30 File Offset: 0x00844D30
		public override void Init()
		{
			int a_ = 2;
			short num = (short)365953025;
			if (num != 0)
			{
			}
			num = (short)1381106953;
			short num2 = num;
			num = (short)444531977;
			switch (num2 == num)
			{
			default:
			{
				num = (short)494731264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2115043328;
			if (num != 0)
			{
			}
			this.cHE5EmergencyButtonName_43766 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("胂跄苆ﳈ車ꃌ꫎ꏐ듒냔맖뫘ꋚ鿜꫞闠韢諤触꟨諪胬諮껰쟲웴샶쿸췺", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHE5EmergencyButtonName_43766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHE5EmergencyButtonName_43766.DataTransferOrder = -1;
			this.cHE5EmergencyButtonBCO_43767 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexCHE5EmergencyButtonBCO_43767LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.CHE5EmergencyButtonBCO_43767LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄苆ﳈ車ꃌ꫎ꏐ듒냔맖뫘ꋚ鿜꫞闠韢諤触ꯨ꣪ꋬ냮연샲싴쇶컸", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.CHE5EmergencyButtonBCO_43767LovStrs);
			this.cHE5EmergencyButtonBCO_43767.IgnoreOnCompare = true;
			this.cHE5EmergencyButtonBCO_43767.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHE5EmergencyButtonBCO_43767.DataTransferOrder = -1;
			this.cHE5EmergencyButtonFeature_43768 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexCHE5EmergencyButtonFeature_43768LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idCHE5EmergencyButtonFeature_43768LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄苆ﳈ車ꃌ꫎ꏐ듒냔맖뫘ꋚ鿜꫞闠韢諤触꿨軪賬鯮蓰臲郴ꣶ췸죺쫼짾㤀", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.CHE5EmergencyButtonFeature_43768LovStrs);
			this.cHE5EmergencyButtonFeature_43768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHE5EmergencyButtonFeature_43768.DataTransferOrder = 17;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛂", a_);
			base.Id = 10901;
			base.UIName = global::CommonResources.AcgResources.ID_E5;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D34 RID: 36148 RVA: 0x00846D00 File Offset: 0x00844F00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)532283404;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cHE5EmergencyButtonFeature_43768 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexCHE5EmergencyButtonFeature_43768LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idCHE5EmergencyButtonFeature_43768LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧곩觫迭蓯蟱蛳鏵ꟷ컹쿻짽㛿㨁", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.CHE5EmergencyButtonFeature_43768LovStrs);
					this.cHE5EmergencyButtonFeature_43768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHE5EmergencyButtonFeature_43768.DataTransferOrder = 17;
					num = (short)1105788934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧곩觫迭蓯蟱蛳鏵ꟷ컹쿻짽㛿㨁", a_)))
					{
						num = (short)326696960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 2:
					goto IL_149;
				case 3:
					goto IL_1E0;
				case 4:
				{
					num = (short)1483538432;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧꣩꿫ꇭ꿯웱쟳쇵컷췹", a_)))
					{
						num = (short)589168643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				}
				case 5:
					if (producerFields != null)
					{
						num = (short)1959723019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 6:
					goto IL_299;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧ꓩ跫菭闯귱샳엵쿷쳹쫻", a_)))
					{
						num = (short)41680905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 8:
					num = (short)1531248645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.cHE5EmergencyButtonName_43766 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧ꓩ跫菭闯귱샳엵쿷쳹쫻", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHE5EmergencyButtonName_43766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHE5EmergencyButtonName_43766.DataTransferOrder = -1;
					num = (short)909246466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2D7;
				case 11:
					num = (short)980877319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)824600531;
					short num4 = num;
					num = (short)1014458323;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E0;
					default:
						num = (short)346488832;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				}
				IL_AC:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1506279432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_149:
				num = (short)1646133249;
				if (num != 0)
				{
				}
				num = (short)1153499140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E0:
				this.cHE5EmergencyButtonBCO_43767 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.indexCHE5EmergencyButtonBCO_43767LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.idCHE5EmergencyButtonBCO_43767LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟃軅跇￉觋ꏍ뗏ꃑ돓돕뛗맙ꗛ鳝闟雡郣觥蛧꣩꿫ꇭ꿯웱쟳쇵컷췹", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.LOVs.CHE5EmergencyButtonBCO_43767LovStrs);
				this.cHE5EmergencyButtonBCO_43767.IgnoreOnCompare = true;
				this.cHE5EmergencyButtonBCO_43767.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.cHE5EmergencyButtonBCO_43767.DataTransferOrder = -1;
				num = (short)267517962;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D7:
				num = (short)1454440449;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_299:
			IL_37C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臃", a_);
			base.Id = 10901;
			base.UIName = global::CommonResources.AcgResources.ID_E5;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D35 RID: 36149 RVA: 0x008470BC File Offset: 0x008452BC
		public override void PopulateReferences()
		{
			short num = (short)1023986407;
			short num2 = num;
			num = (short)460180199;
			switch (num2 == num)
			{
			}
			num = (short)1062469632;
			short num3 = num;
			num = (short)1298857985;
			if (num != 0)
			{
			}
			num = (short)1315373056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D36 RID: 36150 RVA: 0x00847164 File Offset: 0x00845364
		public override void DropReferences()
		{
			short num = (short)848376463;
			short num2 = num;
			num = (short)496513679;
			switch (num2 == num)
			{
			}
			num = (short)2098987008;
			short num3 = num;
			num = (short)2041774081;
			if (num != 0)
			{
			}
			num = (short)1427111936;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x00847210 File Offset: 0x00845410
		public override void SetConstraints()
		{
			short num = (short)2108554879;
			short num2 = num;
			num = (short)1244659327;
			switch (num2 == num)
			{
			}
			num = (short)2007302144;
			short num3 = num;
			num = (short)897253377;
			if (num != 0)
			{
			}
			num = (short)128188416;
			if (num != 0)
			{
			}
			this.cHE5EmergencyButtonFeature_43768.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConControlHeadEmergencyFeaturesSelect);
			this.cHE5EmergencyButtonFeature_43768.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.ConSyncOrangeBtn);
			this.cHE5EmergencyButtonName_43766.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x00847300 File Offset: 0x00845500
		public override void SetupDependencies()
		{
			short num = (short)2032033284;
			short num2 = num;
			num = (short)1953062404;
			switch (num2 == num)
			{
			}
			num = (short)383516672;
			short num3 = num;
			num = (short)87425024;
			if (num != 0)
			{
			}
			num = (short)277872641;
			if (num != 0)
			{
			}
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
			this.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
			this.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cHE5EmergencyButtonFeature_43768);
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x00847450 File Offset: 0x00845650
		public bool HasDiffs
		{
			get
			{
				short num = (short)1704386701;
				short num2 = num;
				num = (short)1833164941;
				switch (num2 == num)
				{
				}
				num = (short)1013710848;
				short num3 = num;
				num = (short)1764360193;
				if (num != 0)
				{
				}
				num = (short)609091584;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x06008D3A RID: 36154 RVA: 0x00847504 File Offset: 0x00845704
		// (set) Token: 0x06008D3B RID: 36155 RVA: 0x008475B8 File Offset: 0x008457B8
		public string CHE5EmergencyButtonName_43766Value
		{
			get
			{
				short num = (short)535035905;
				if (num != 0)
				{
				}
				num = (short)377935544;
				short num2 = num;
				num = (short)1806554808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747044864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784152064;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Value;
			}
			set
			{
				short num = (short)1823659463;
				short num2 = num;
				num = (short)617534919;
				switch (num2 == num)
				{
				}
				num = (short)767229952;
				short num3 = num;
				num = (short)1602879489;
				if (num != 0)
				{
				}
				num = (short)1075511296;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Value = value;
			}
		}

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x06008D3C RID: 36156 RVA: 0x00847670 File Offset: 0x00845870
		public global::AcpBusinessLayer.AcpField<string> CHE5EmergencyButtonName_43766
		{
			get
			{
				short num = (short)202016976;
				short num2 = num;
				num = (short)1930070224;
				switch (num2 == num)
				{
				}
				num = (short)1419378688;
				short num3 = num;
				num = (short)2092367872;
				if (num != 0)
				{
				}
				num = (short)1673986049;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x00847720 File Offset: 0x00845920
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x008477D4 File Offset: 0x008459D4
		public string CHE5EmergencyButtonName_43766_UIValue
		{
			get
			{
				short num = (short)1983867042;
				short num2 = num;
				num = (short)1387948194;
				switch (num2 == num)
				{
				}
				num = (short)927727616;
				short num3 = num;
				num = (short)1145176064;
				if (num != 0)
				{
				}
				num = (short)1506934785;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Value;
			}
			set
			{
				short num = (short)2045325875;
				short num2 = num;
				num = (short)910111283;
				switch (num2 == num)
				{
				}
				num = (short)1965686784;
				short num3 = num;
				num = (short)1729101825;
				if (num != 0)
				{
				}
				num = (short)921305088;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Value = value;
			}
		}

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0084788C File Offset: 0x00845A8C
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x00847940 File Offset: 0x00845B40
		public bool CHE5EmergencyButtonName_43766_Applicable
		{
			get
			{
				short num = (short)530519189;
				short num2 = num;
				num = (short)759829653;
				switch (num2 == num)
				{
				}
				num = (short)1677918208;
				short num3 = num;
				num = (short)742981633;
				if (num != 0)
				{
				}
				num = (short)269484032;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Applicable;
			}
			set
			{
				short num = (short)63838341;
				short num2 = num;
				num = (short)789321861;
				switch (num2 == num)
				{
				}
				num = (short)1877868544;
				short num3 = num;
				num = (short)207618048;
				if (num != 0)
				{
				}
				num = (short)124977153;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Applicable = value;
			}
		}

		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x008479F8 File Offset: 0x00845BF8
		// (set) Token: 0x06008D42 RID: 36162 RVA: 0x00847AAC File Offset: 0x00845CAC
		public bool CHE5EmergencyButtonName_43766_Valid
		{
			get
			{
				short num = (short)2047868929;
				if (num != 0)
				{
				}
				num = (short)358647409;
				short num2 = num;
				num = (short)851412593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)614400000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596115456;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Valid;
			}
			set
			{
				short num = (short)2077152550;
				short num2 = num;
				num = (short)1023595814;
				switch (num2 == num)
				{
				}
				num = (short)1210515456;
				short num3 = num;
				num = (short)441581569;
				if (num != 0)
				{
				}
				num = (short)1127088128;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Valid = value;
			}
		}

		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x06008D43 RID: 36163 RVA: 0x00847B60 File Offset: 0x00845D60
		// (set) Token: 0x06008D44 RID: 36164 RVA: 0x00847C14 File Offset: 0x00845E14
		public bool CHE5EmergencyButtonName_43766_Visible
		{
			get
			{
				short num = (short)1015289664;
				short num2 = num;
				num = (short)995170112;
				switch (num2 == num)
				{
				}
				num = (short)1775763456;
				short num3 = num;
				num = (short)2022440961;
				if (num != 0)
				{
				}
				num = (short)2136342528;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Visible;
			}
			set
			{
				short num = (short)2057601039;
				short num2 = num;
				num = (short)851673103;
				switch (num2 == num)
				{
				}
				num = (short)1194786816;
				short num3 = num;
				num = (short)1267728384;
				if (num != 0)
				{
				}
				num = (short)908197889;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Visible = value;
			}
		}

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x06008D45 RID: 36165 RVA: 0x00847CC8 File Offset: 0x00845EC8
		// (set) Token: 0x06008D46 RID: 36166 RVA: 0x00847D7C File Offset: 0x00845F7C
		public bool CHE5EmergencyButtonName_43766_Editable
		{
			get
			{
				short num = (short)1383740148;
				short num2 = num;
				num = (short)726872820;
				switch (num2 == num)
				{
				}
				num = (short)571211776;
				short num3 = num;
				num = (short)645595136;
				if (num != 0)
				{
				}
				num = (short)622657537;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.Editable;
			}
			set
			{
				short num = (short)191627265;
				if (num != 0)
				{
				}
				num = (short)918791097;
				short num2 = num;
				num = (short)1958847417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115015680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974272000;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.Editable = value;
			}
		}

		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x00847E30 File Offset: 0x00846030
		internal string CHE5EmergencyButtonName_43766_UILabel
		{
			get
			{
				short num = (short)1773374927;
				short num2 = num;
				num = (short)1986039247;
				switch (num2 == num)
				{
				}
				num = (short)204472320;
				short num3 = num;
				num = (short)326238209;
				if (num != 0)
				{
				}
				num = (short)743833600;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.UIName;
			}
		}

		// Token: 0x1700476A RID: 18282
		// (get) Token: 0x06008D48 RID: 36168 RVA: 0x00847EE8 File Offset: 0x008460E8
		// (set) Token: 0x06008D49 RID: 36169 RVA: 0x00847F9C File Offset: 0x0084619C
		internal bool CHE5EmergencyButtonName_43766_HiddenStatic
		{
			get
			{
				short num = (short)130203145;
				short num2 = num;
				num = (short)2053488137;
				switch (num2 == num)
				{
				}
				num = (short)1137180672;
				short num3 = num;
				num = (short)1706295296;
				if (num != 0)
				{
				}
				num = (short)205455361;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.HiddenStatic;
			}
			set
			{
				short num = (short)1239104910;
				short num2 = num;
				num = (short)376585614;
				switch (num2 == num)
				{
				}
				num = (short)515112960;
				short num3 = num;
				num = (short)1677197313;
				if (num != 0)
				{
				}
				num = (short)110231552;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.HiddenStatic = value;
			}
		}

		// Token: 0x1700476B RID: 18283
		// (get) Token: 0x06008D4A RID: 36170 RVA: 0x00848054 File Offset: 0x00846254
		// (set) Token: 0x06008D4B RID: 36171 RVA: 0x00848108 File Offset: 0x00846308
		internal bool CHE5EmergencyButtonName_43766_HiddenDynamic
		{
			get
			{
				short num = (short)984809473;
				if (num != 0)
				{
				}
				num = (short)1020302774;
				short num2 = num;
				num = (short)687052214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599733760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1615265792;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766.HiddenDynamic;
			}
			set
			{
				short num = (short)803606328;
				short num2 = num;
				num = (short)1165037368;
				switch (num2 == num)
				{
				}
				num = (short)112787456;
				short num3 = num;
				num = (short)564461568;
				if (num != 0)
				{
				}
				num = (short)1037762561;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonName_43766.HiddenDynamic = value;
			}
		}

		// Token: 0x1700476C RID: 18284
		// (get) Token: 0x06008D4C RID: 36172 RVA: 0x008481C0 File Offset: 0x008463C0
		public bool CHE5EmergencyButtonName_43766_HasDiffs
		{
			get
			{
				short num = (short)1967275496;
				short num2 = num;
				num = (short)886849000;
				switch (num2 == num)
				{
				}
				num = (short)331218944;
				short num3 = num;
				num = (short)708706305;
				if (num != 0)
				{
				}
				num = (short)110100480;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonName_43766._HasDiffs;
			}
		}

		// Token: 0x1700476D RID: 18285
		// (get) Token: 0x06008D4D RID: 36173 RVA: 0x00848274 File Offset: 0x00846474
		// (set) Token: 0x06008D4E RID: 36174 RVA: 0x00848328 File Offset: 0x00846528
		public int CHE5EmergencyButtonBCO_43767Value
		{
			get
			{
				short num = (short)1679056608;
				short num2 = num;
				num = (short)841244384;
				switch (num2 == num)
				{
				}
				num = (short)988348416;
				short num3 = num;
				num = (short)1787101185;
				if (num != 0)
				{
				}
				num = (short)1844707328;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.Value;
			}
			set
			{
				short num = (short)1533198088;
				short num2 = num;
				num = (short)1658633992;
				switch (num2 == num)
				{
				}
				num = (short)141361152;
				short num3 = num;
				num = (short)515375105;
				if (num != 0)
				{
				}
				num = (short)1528561664;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.Value = value;
			}
		}

		// Token: 0x1700476E RID: 18286
		// (get) Token: 0x06008D4F RID: 36175 RVA: 0x008483E0 File Offset: 0x008465E0
		// (set) Token: 0x06008D50 RID: 36176 RVA: 0x00848494 File Offset: 0x00846694
		public string CHE5EmergencyButtonBCO_43767_UIValue
		{
			get
			{
				short num = (short)493627353;
				short num2 = num;
				num = (short)804267993;
				switch (num2 == num)
				{
				}
				num = (short)202113024;
				short num3 = num;
				num = (short)957612033;
				if (num != 0)
				{
				}
				num = (short)1550254080;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.UIValue;
			}
			set
			{
				short num = (short)871150491;
				short num2 = num;
				num = (short)23966619;
				switch (num2 == num)
				{
				}
				num = (short)1537605632;
				short num3 = num;
				num = (short)1658388481;
				if (num != 0)
				{
				}
				num = (short)778895360;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.UIValue = value;
			}
		}

		// Token: 0x1700476F RID: 18287
		// (get) Token: 0x06008D51 RID: 36177 RVA: 0x0084854C File Offset: 0x0084674C
		public global::AcpBusinessLayer.AcpListField CHE5EmergencyButtonBCO_43767
		{
			get
			{
				short num = (short)626262017;
				if (num != 0)
				{
				}
				num = (short)1727221252;
				short num2 = num;
				num = (short)1145851396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479199232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998651392;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767;
			}
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x06008D52 RID: 36178 RVA: 0x008485FC File Offset: 0x008467FC
		// (set) Token: 0x06008D53 RID: 36179 RVA: 0x008486B0 File Offset: 0x008468B0
		public bool CHE5EmergencyButtonBCO_43767_Applicable
		{
			get
			{
				short num = (short)1619853370;
				short num2 = num;
				num = (short)1674248250;
				switch (num2 == num)
				{
				}
				num = (short)541392896;
				short num3 = num;
				num = (short)600375297;
				if (num != 0)
				{
				}
				num = (short)531890176;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.Applicable;
			}
			set
			{
				short num = (short)1466564609;
				if (num != 0)
				{
				}
				num = (short)254659199;
				short num2 = num;
				num = (short)246598271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875771392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257766912;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.Applicable = value;
			}
		}

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x06008D54 RID: 36180 RVA: 0x00848764 File Offset: 0x00846964
		// (set) Token: 0x06008D55 RID: 36181 RVA: 0x00848818 File Offset: 0x00846A18
		public bool CHE5EmergencyButtonBCO_43767_Valid
		{
			get
			{
				short num = (short)911122142;
				short num2 = num;
				num = (short)280469214;
				switch (num2 == num)
				{
				}
				num = (short)1947860992;
				short num3 = num;
				num = (short)411566081;
				if (num != 0)
				{
				}
				num = (short)1787166720;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.Valid;
			}
			set
			{
				short num = (short)1165996255;
				short num2 = num;
				num = (short)14135519;
				switch (num2 == num)
				{
				}
				num = (short)936181760;
				short num3 = num;
				num = (short)1454702593;
				if (num != 0)
				{
				}
				num = (short)1115553792;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.Valid = value;
			}
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x06008D56 RID: 36182 RVA: 0x008488D0 File Offset: 0x00846AD0
		// (set) Token: 0x06008D57 RID: 36183 RVA: 0x00848988 File Offset: 0x00846B88
		public bool CHE5EmergencyButtonBCO_43767_Visible
		{
			get
			{
				short num = (short)1295614540;
				short num2 = num;
				num = (short)540115532;
				switch (num2 == num)
				{
				}
				num = (short)895942656;
				short num3 = num;
				num = (short)917110785;
				if (num != 0)
				{
				}
				num = (short)1204748288;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.Visible;
			}
			set
			{
				short num = (short)1975627151;
				short num2 = num;
				num = (short)1708240271;
				switch (num2 == num)
				{
				}
				num = (short)807010304;
				short num3 = num;
				num = (short)1175060481;
				if (num != 0)
				{
				}
				num = (short)1850736640;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.Visible = value;
			}
		}

		// Token: 0x17004773 RID: 18291
		// (get) Token: 0x06008D58 RID: 36184 RVA: 0x00848A40 File Offset: 0x00846C40
		// (set) Token: 0x06008D59 RID: 36185 RVA: 0x00848AF4 File Offset: 0x00846CF4
		public bool CHE5EmergencyButtonBCO_43767_Editable
		{
			get
			{
				short num = (short)1557639901;
				short num2 = num;
				num = (short)806859485;
				switch (num2 == num)
				{
				}
				num = (short)1843855360;
				short num3 = num;
				num = (short)1812922369;
				if (num != 0)
				{
				}
				num = (short)1077608448;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.Editable;
			}
			set
			{
				short num = (short)1235784004;
				short num2 = num;
				num = (short)1757778244;
				switch (num2 == num)
				{
				}
				num = (short)1349517312;
				short num3 = num;
				num = (short)486866945;
				if (num != 0)
				{
				}
				num = (short)884539392;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.Editable = value;
			}
		}

		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x06008D5A RID: 36186 RVA: 0x00848BA8 File Offset: 0x00846DA8
		internal string CHE5EmergencyButtonBCO_43767_UILabel
		{
			get
			{
				short num = (short)1751390324;
				short num2 = num;
				num = (short)348067956;
				switch (num2 == num)
				{
				}
				num = (short)123142144;
				short num3 = num;
				num = (short)1553661953;
				if (num != 0)
				{
				}
				num = (short)703004672;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.UIName;
			}
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x00848C60 File Offset: 0x00846E60
		// (set) Token: 0x06008D5C RID: 36188 RVA: 0x00848D14 File Offset: 0x00846F14
		internal bool CHE5EmergencyButtonBCO_43767_HiddenStatic
		{
			get
			{
				short num = (short)846039997;
				short num2 = num;
				num = (short)1343458237;
				switch (num2 == num)
				{
				}
				num = (short)264175616;
				short num3 = num;
				num = (short)403439617;
				if (num != 0)
				{
				}
				num = (short)2076573696;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.HiddenStatic;
			}
			set
			{
				short num = (short)1496951272;
				short num2 = num;
				num = (short)1070442984;
				switch (num2 == num)
				{
				}
				num = (short)113573888;
				short num3 = num;
				num = (short)1544683520;
				if (num != 0)
				{
				}
				num = (short)2055667713;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.HiddenStatic = value;
			}
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x00848DCC File Offset: 0x00846FCC
		// (set) Token: 0x06008D5E RID: 36190 RVA: 0x00848E80 File Offset: 0x00847080
		internal bool CHE5EmergencyButtonBCO_43767_HiddenDynamic
		{
			get
			{
				short num = (short)581969752;
				short num2 = num;
				num = (short)870524760;
				switch (num2 == num)
				{
				}
				num = (short)804782080;
				short num3 = num;
				num = (short)1207238657;
				if (num != 0)
				{
				}
				num = (short)955252736;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767.HiddenDynamic;
			}
			set
			{
				short num = (short)271280078;
				short num2 = num;
				num = (short)1590978510;
				switch (num2 == num)
				{
				}
				num = (short)1293811712;
				short num3 = num;
				num = (short)1212022785;
				if (num != 0)
				{
				}
				num = (short)369426432;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonBCO_43767.HiddenDynamic = value;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x06008D5F RID: 36191 RVA: 0x00848F38 File Offset: 0x00847138
		public bool CHE5EmergencyButtonBCO_43767_HasDiffs
		{
			get
			{
				short num = (short)264335635;
				short num2 = num;
				num = (short)2063233299;
				switch (num2 == num)
				{
				}
				num = (short)1883766784;
				short num3 = num;
				num = (short)603652096;
				if (num != 0)
				{
				}
				num = (short)2139095041;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonBCO_43767._HasDiffs;
			}
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x06008D60 RID: 36192 RVA: 0x00848FEC File Offset: 0x008471EC
		// (set) Token: 0x06008D61 RID: 36193 RVA: 0x008490A4 File Offset: 0x008472A4
		public int CHE5EmergencyButtonFeature_43768Value
		{
			get
			{
				short num = (short)704282688;
				short num2 = num;
				num = (short)1896710208;
				switch (num2 == num)
				{
				}
				num = (short)471793664;
				short num3 = num;
				num = (short)983171073;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.Value;
			}
			set
			{
				short num = (short)466476825;
				short num2 = num;
				num = (short)505405209;
				switch (num2 == num)
				{
				}
				num = (short)342163456;
				short num3 = num;
				num = (short)1895038977;
				if (num != 0)
				{
				}
				num = (short)1031864320;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.Value = value;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x06008D62 RID: 36194 RVA: 0x0084915C File Offset: 0x0084735C
		// (set) Token: 0x06008D63 RID: 36195 RVA: 0x00849210 File Offset: 0x00847410
		public string CHE5EmergencyButtonFeature_43768_UIValue
		{
			get
			{
				short num = (short)1492499108;
				short num2 = num;
				num = (short)1376041636;
				switch (num2 == num)
				{
				}
				num = (short)717946880;
				short num3 = num;
				num = (short)631832576;
				if (num != 0)
				{
				}
				num = (short)1169686529;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.UIValue;
			}
			set
			{
				short num = (short)2075843708;
				short num2 = num;
				num = (short)2012208252;
				switch (num2 == num)
				{
				}
				num = (short)1452802048;
				short num3 = num;
				num = (short)213450752;
				if (num != 0)
				{
				}
				num = (short)248512513;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.UIValue = value;
			}
		}

		// Token: 0x1700477A RID: 18298
		// (get) Token: 0x06008D64 RID: 36196 RVA: 0x008492C8 File Offset: 0x008474C8
		public global::AcpBusinessLayer.AcpListField CHE5EmergencyButtonFeature_43768
		{
			get
			{
				short num = (short)1486880769;
				if (num != 0)
				{
				}
				num = (short)1786693338;
				short num2 = num;
				num = (short)445499098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746651648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937689088;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768;
			}
		}

		// Token: 0x1700477B RID: 18299
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x00849378 File Offset: 0x00847578
		// (set) Token: 0x06008D66 RID: 36198 RVA: 0x00849430 File Offset: 0x00847630
		public bool CHE5EmergencyButtonFeature_43768_Applicable
		{
			get
			{
				short num = (short)887889009;
				short num2 = num;
				num = (short)2102140017;
				switch (num2 == num)
				{
				}
				num = (short)1816330240;
				short num3 = num;
				num = (short)515047424;
				if (num != 0)
				{
				}
				num = (short)2003238913;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.Applicable;
			}
			set
			{
				short num = (short)1254752257;
				if (num != 0)
				{
				}
				num = (short)1321186195;
				short num2 = num;
				num = (short)491107219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622067712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200933376;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.Applicable = value;
			}
		}

		// Token: 0x1700477C RID: 18300
		// (get) Token: 0x06008D67 RID: 36199 RVA: 0x008494E4 File Offset: 0x008476E4
		// (set) Token: 0x06008D68 RID: 36200 RVA: 0x00849598 File Offset: 0x00847798
		public bool CHE5EmergencyButtonFeature_43768_Valid
		{
			get
			{
				short num = (short)264580863;
				short num2 = num;
				num = (short)290598655;
				switch (num2 == num)
				{
				}
				num = (short)1563426816;
				short num3 = num;
				num = (short)1253113856;
				if (num != 0)
				{
				}
				num = (short)1126825985;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.Valid;
			}
			set
			{
				short num = (short)277282817;
				if (num != 0)
				{
				}
				num = (short)2085981084;
				short num2 = num;
				num = (short)688425884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592000512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)613089280;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.Valid = value;
			}
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x00849650 File Offset: 0x00847850
		// (set) Token: 0x06008D6A RID: 36202 RVA: 0x00849704 File Offset: 0x00847904
		public bool CHE5EmergencyButtonFeature_43768_Visible
		{
			get
			{
				short num = (short)346259424;
				short num2 = num;
				num = (short)1140162528;
				switch (num2 == num)
				{
				}
				num = (short)1017249792;
				short num3 = num;
				num = (short)282656769;
				if (num != 0)
				{
				}
				num = (short)2017656832;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.Visible;
			}
			set
			{
				short num = (short)1979795199;
				short num2 = num;
				num = (short)1813333759;
				switch (num2 == num)
				{
				}
				num = (short)1809973248;
				short num3 = num;
				num = (short)1078394881;
				if (num != 0)
				{
				}
				num = (short)327024640;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.Visible = value;
			}
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x06008D6B RID: 36203 RVA: 0x008497B8 File Offset: 0x008479B8
		// (set) Token: 0x06008D6C RID: 36204 RVA: 0x00849870 File Offset: 0x00847A70
		public bool CHE5EmergencyButtonFeature_43768_Editable
		{
			get
			{
				short num = (short)1191979589;
				short num2 = num;
				num = (short)108997189;
				switch (num2 == num)
				{
				}
				num = (short)733413376;
				short num3 = num;
				num = (short)213188608;
				if (num != 0)
				{
				}
				num = (short)48824321;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.Editable;
			}
			set
			{
				short num = (short)532952368;
				short num2 = num;
				num = (short)1192113456;
				switch (num2 == num)
				{
				}
				num = (short)1199308800;
				short num3 = num;
				num = (short)1942487041;
				if (num != 0)
				{
				}
				num = (short)1232076800;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.Editable = value;
			}
		}

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x06008D6D RID: 36205 RVA: 0x00849928 File Offset: 0x00847B28
		internal string CHE5EmergencyButtonFeature_43768_UILabel
		{
			get
			{
				short num = (short)2000298838;
				short num2 = num;
				num = (short)1583817558;
				switch (num2 == num)
				{
				}
				num = (short)1046675456;
				short num3 = num;
				num = (short)73728001;
				if (num != 0)
				{
				}
				num = (short)444596224;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.UIName;
			}
		}

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x06008D6E RID: 36206 RVA: 0x008499DC File Offset: 0x00847BDC
		// (set) Token: 0x06008D6F RID: 36207 RVA: 0x00849A94 File Offset: 0x00847C94
		internal bool CHE5EmergencyButtonFeature_43768_HiddenStatic
		{
			get
			{
				short num = (short)1053097985;
				if (num != 0)
				{
				}
				num = (short)1658634390;
				short num2 = num;
				num = (short)1465958550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332674560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25821184;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.HiddenStatic;
			}
			set
			{
				short num = (short)129695523;
				short num2 = num;
				num = (short)2122710819;
				switch (num2 == num)
				{
				}
				num = (short)316407808;
				short num3 = num;
				num = (short)1044512769;
				if (num != 0)
				{
				}
				num = (short)1636040704;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.HiddenStatic = value;
			}
		}

		// Token: 0x17004781 RID: 18305
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x00849B4C File Offset: 0x00847D4C
		// (set) Token: 0x06008D71 RID: 36209 RVA: 0x00849C00 File Offset: 0x00847E00
		internal bool CHE5EmergencyButtonFeature_43768_HiddenDynamic
		{
			get
			{
				short num = (short)2030903685;
				short num2 = num;
				num = (short)1399726469;
				switch (num2 == num)
				{
				}
				num = (short)1173422080;
				short num3 = num;
				num = (short)1885863936;
				if (num != 0)
				{
				}
				num = (short)1594490881;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768.HiddenDynamic;
			}
			set
			{
				short num = (short)853651167;
				short num2 = num;
				num = (short)2062331615;
				switch (num2 == num)
				{
				}
				num = (short)1016135680;
				short num3 = num;
				num = (short)531759104;
				if (num != 0)
				{
				}
				num = (short)345833473;
				if (num != 0)
				{
				}
				this.cHE5EmergencyButtonFeature_43768.HiddenDynamic = value;
			}
		}

		// Token: 0x17004782 RID: 18306
		// (get) Token: 0x06008D72 RID: 36210 RVA: 0x00849CB8 File Offset: 0x00847EB8
		public bool CHE5EmergencyButtonFeature_43768_HasDiffs
		{
			get
			{
				short num = (short)1357905921;
				if (num != 0)
				{
				}
				num = (short)1247224363;
				short num2 = num;
				num = (short)162996779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1923874816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1744371712;
				if (num != 0)
				{
				}
				return this.cHE5EmergencyButtonFeature_43768._HasDiffs;
			}
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x06008D73 RID: 36211 RVA: 0x00849D6C File Offset: 0x00847F6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)642923212;
				short num2 = num;
				num = (short)1470708428;
				switch (num2 == num)
				{
				}
				num = (short)719650816;
				short num3 = num;
				num = (short)1920925696;
				if (num != 0)
				{
				}
				num = (short)1874919425;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x06008D74 RID: 36212 RVA: 0x00849E2C File Offset: 0x0084802C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1613391975;
				short num2 = num;
				num = (short)1698064487;
				switch (num2 == num)
				{
				}
				num = (short)1153433600;
				short num3 = num;
				num = (short)1271988225;
				if (num != 0)
				{
				}
				num = (short)881590272;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x00849EEC File Offset: 0x008480EC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)259194880;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1930493956;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					goto IL_141;
				case 3:
				{
					num = (short)2078762931;
					short num4 = num;
					num = (short)1603495859;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num = (short)88342528;
						if (num != 0)
						{
						}
						num = (short)976355329;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1742929920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)1022951426;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4E;
				IL_141:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num = (short)1436876803;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4E:
			result = null;
			num = (short)1245642753;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x04004584 RID: 17796
		private global::AcpBusinessLayer.AcpField<string> cHE5EmergencyButtonName_43766;

		// Token: 0x04004585 RID: 17797
		private global::AcpBusinessLayer.AcpListField cHE5EmergencyButtonBCO_43767;

		// Token: 0x04004586 RID: 17798
		private global::AcpBusinessLayer.AcpListField cHE5EmergencyButtonFeature_43768;
	}
}
