using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A8 RID: 1192
	[global::System.Serializable]
	public class MDC : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009D41 RID: 40257 RVA: 0x0092F2B0 File Offset: 0x0092D4B0
		public MDC(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x0092F2CC File Offset: 0x0092D4CC
		protected MDC(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x0092F2E4 File Offset: 0x0092D4E4
		public override void Init()
		{
			int a_ = 4;
			short num = (short)936995461;
			short num2 = num;
			num = (short)546990725;
			switch (num2 == num)
			{
			}
			num = (short)702742529;
			if (num != 0)
			{
			}
			num = (short)749600768;
			if (num != 0)
			{
			}
			num = (short)143261696;
			short num3 = num;
			this.cnvEmerProfMDCEnable2_A7924 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈車ꃌ꫎ꏐ菒꟔룖뿘雚駜鳞ꓠ跢蓤藦藨軪\udfec냮냰쓲쳴엶췸", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITOREMERREMOTEMONITORENABLE);
			this.cnvEmerProfMDCEnable2_A7924.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfMDCEnable2_A7924.DataTransferOrder = 6;
			this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈車ꃌ꫎ꏐ菒꟔룖뿘雚駜鳞ꓠ転胤闦軨軪菬賮裰ꏲꇴꏶ냸뿺껼雾攀昂焄栆月渊刌与☐⨒℔№", a_), global::CommonResources.AcgResources.ID_EMERGENCYPTTIDSIDETONE);
			this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.DataTransferOrder = 7;
			this.cnvEmerProfMDCRxBaseTimesec_A8999 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈車ꃌ꫎ꏐ菒꟔룖뿘雚駜鳞돠鯢꟤蛦髨軪맬蛮鳰雲蛴鋶髸ꓺ볼쟾㠀㨂㰄", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITORRXBASETIMESEC, 10, 120, 10);
			this.cnvEmerProfMDCRxBaseTimesec_A8999.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfMDCRxBaseTimesec_A8999.DataTransferOrder = 12;
			this.cnvEmerProfMDCRxBaseTimesec_A8999.ShowHexValue = false;
			this.cnvEmerProfMDCTxBaseTimeSec_A9514 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈車ꃌ꫎ꏐ菒꟔룖뿘雚駜鳞뗠鯢꟤蛦髨軪맬蛮鳰雲꛴鋶髸ꓺ볼웾㐀㈂㄄", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITORTXBASETIMESEC, 10, 120, 10);
			this.cnvEmerProfMDCTxBaseTimeSec_A9514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfMDCTxBaseTimeSec_A9514.DataTransferOrder = 14;
			this.cnvEmerProfMDCTxBaseTimeSec_A9514.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裄菆諈", a_);
			base.Id = 10185;
			base.UIName = global::CommonResources.AcgResources.ID_MDC;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x0092F4D8 File Offset: 0x0092D6D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)632356879;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvEmerProfMDCEnable2_A7924 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ꟡諣蟥諧蛩觫\udced꿯돱쏳쿵쫷컹", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITOREMERREMOTEMONITORENABLE);
					this.cnvEmerProfMDCEnable2_A7924.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfMDCEnable2_A7924.DataTransferOrder = 6;
					num = (short)31522822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)368836610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ꟡諣蟥諧蛩觫\udced꿯돱쏳쿵쫷컹", a_)))
					{
						num = (short)972029952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ꟡解菥髧跩觫胭鏯诱ꓳꋵ곷돹룻귽槿昁愃爅朇搉椋儍儏┑ⴓ∕⸗", a_)))
					{
						num = (short)1101070348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 4:
					if (producerFields != null)
					{
						num = (short)1918238721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_414;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ뛡鳣ꓥ觧駩觫뫭駯鿱釳ꗵ鷷駹ꏻ뿽㧿㜁㔃㈅", a_)))
					{
						num = (short)1777860622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_414;
				case 6:
					goto IL_2D5;
				case 7:
					this.cnvEmerProfMDCRxBaseTimesec_A8999 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ냡鳣ꓥ觧駩觫뫭駯鿱釳藵鷷駹ꏻ뿽㣿㬁㴃㼅", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITORRXBASETIMESEC);
					this.cnvEmerProfMDCRxBaseTimesec_A8999.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvEmerProfMDCRxBaseTimesec_A8999.DataTransferOrder = 12;
					this.cnvEmerProfMDCRxBaseTimesec_A8999.ShowHexValue = false;
					num = (short)1242103817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)21823492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_19A;
				case 10:
					goto IL_221;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ냡鳣ꓥ觧駩觫뫭駯鿱釳藵鷷駹ꏻ뿽㣿㬁㴃㼅", a_)))
					{
						num = (short)363855879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
				case 12:
				{
					num = (short)1443341286;
					short num3 = num;
					num = (short)2104796134;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26E;
					default:
						num = (short)412024833;
						if (num != 0)
						{
						}
						num = (short)10289152;
						if (num != 0)
						{
						}
						this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ꟡解菥髧跩觫胭鏯诱ꓳꋵ곷돹룻귽槿昁愃爅朇搉椋儍儏┑ⴓ∕⸗", a_), global::CommonResources.AcgResources.ID_EMERGENCYPTTIDSIDETONE);
						this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.DataTransferOrder = 7;
						num = (short)1639776266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_2D0;
				case 14:
					goto IL_26E;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				}
				IL_6E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)373620744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19A:
				num = (short)650575877;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				num = (short)1192296459;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26E:
				this.cnvEmerProfMDCTxBaseTimeSec_A9514 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉觋ꏍ뗏ꃑ蓓ꓕ럗볙釛髝ꏟ뛡鳣ꓥ觧駩觫뫭駯鿱釳ꗵ鷷駹ꏻ뿽㧿㜁㔃㈅", a_), global::CommonResources.AcgResources.ID_EMERGENCYREMOTEMONITORTXBASETIMESEC);
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.DataTransferOrder = 14;
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.ShowHexValue = false;
				num = (short)898760717;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D5:
				num = (short)416219136;
				short num4 = num;
				num = (short)1236336643;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2D0:
			IL_414:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诅資觉", a_);
			base.Id = 10185;
			base.UIName = global::CommonResources.AcgResources.ID_MDC;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x0092F92C File Offset: 0x0092DB2C
		public override void PopulateReferences()
		{
			short num = (short)2061978027;
			short num2 = num;
			num = (short)1258834347;
			switch (num2 == num)
			{
			}
			num = (short)664600577;
			if (num != 0)
			{
			}
			num = (short)95748096;
			if (num != 0)
			{
			}
			num = (short)1239089152;
			short num3 = num;
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x0092F9D4 File Offset: 0x0092DBD4
		public override void DropReferences()
		{
			short num = (short)582615041;
			if (num != 0)
			{
			}
			num = (short)75845370;
			short num2 = num;
			num = (short)808603386;
			switch (num2 == num)
			{
			}
			num = (short)120520704;
			if (num != 0)
			{
			}
			num = (short)998113280;
			short num3 = num;
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x0092FA80 File Offset: 0x0092DC80
		public override void SetConstraints()
		{
			short num = (short)1830758054;
			short num2 = num;
			num = (short)1099179686;
			switch (num2 == num)
			{
			}
			num = (short)1518010368;
			if (num != 0)
			{
			}
			num = (short)1231224833;
			if (num != 0)
			{
			}
			num = (short)2063007744;
			short num3 = num;
			this.cnvEmerProfMDCEnable2_A7924.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConEmerRemoMonIsInvalidWhenEnabledAndTypeisNotAlarmAndCall);
			this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConEmergencyTypeisAlarmAndCall);
			this.cnvEmerProfMDCRxBaseTimesec_A8999.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConEmergencyTypeisAlarmAndCall);
			this.cnvEmerProfMDCTxBaseTimeSec_A9514.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConEmergencyTypeisAlarmAndCall);
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x0092FB84 File Offset: 0x0092DD84
		public override void SetupDependencies()
		{
			short num = (short)1410682173;
			short num2 = num;
			num = (short)1499221309;
			switch (num2 == num)
			{
			}
			num = (short)231931904;
			if (num != 0)
			{
			}
			num = (short)1841561601;
			if (num != 0)
			{
			}
			num = (short)1949696000;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfMDCEnable2_A7924);
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946);
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfMDCRxBaseTimesec_A8999);
			conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfMDCTxBaseTimeSec_A9514);
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x06009D49 RID: 40265 RVA: 0x0092FC94 File Offset: 0x0092DE94
		public bool HasDiffs
		{
			get
			{
				short num = (short)960495617;
				if (num != 0)
				{
				}
				num = (short)1064787510;
				short num2 = num;
				num = (short)2132106806;
				switch (num2 == num)
				{
				}
				num = (short)849674240;
				if (num != 0)
				{
				}
				num = (short)1187381248;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004EFE RID: 20222
		// (get) Token: 0x06009D4A RID: 40266 RVA: 0x0092FD44 File Offset: 0x0092DF44
		// (set) Token: 0x06009D4B RID: 40267 RVA: 0x0092FDF8 File Offset: 0x0092DFF8
		public bool CnvEmerProfMDCEnable2_A7924Value
		{
			get
			{
				short num = (short)1071115422;
				short num2 = num;
				num = (short)1333652638;
				switch (num2 == num)
				{
				}
				num = (short)977600513;
				if (num != 0)
				{
				}
				num = (short)1224146944;
				if (num != 0)
				{
				}
				num = (short)1293352960;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Value;
			}
			set
			{
				short num = (short)1121583105;
				if (num != 0)
				{
				}
				num = (short)1503030252;
				short num2 = num;
				num = (short)331770860;
				switch (num2 == num)
				{
				}
				num = (short)1183318016;
				if (num != 0)
				{
				}
				num = (short)488046592;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Value = value;
			}
		}

		// Token: 0x17004EFF RID: 20223
		// (get) Token: 0x06009D4C RID: 40268 RVA: 0x0092FEAC File Offset: 0x0092E0AC
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfMDCEnable2_A7924
		{
			get
			{
				short num = (short)1340562931;
				short num2 = num;
				num = (short)1442799091;
				switch (num2 == num)
				{
				}
				num = (short)1453588480;
				if (num != 0)
				{
				}
				num = (short)1788608513;
				if (num != 0)
				{
				}
				num = (short)474611712;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924;
			}
		}

		// Token: 0x17004F00 RID: 20224
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x0092FF58 File Offset: 0x0092E158
		// (set) Token: 0x06009D4E RID: 40270 RVA: 0x0093000C File Offset: 0x0092E20C
		public bool CnvEmerProfMDCEnable2_A7924_UIValue
		{
			get
			{
				short num = (short)800133849;
				short num2 = num;
				num = (short)807801561;
				switch (num2 == num)
				{
				}
				num = (short)756154369;
				if (num != 0)
				{
				}
				num = (short)1855062016;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Value;
			}
			set
			{
				short num = (short)998913529;
				short num2 = num;
				num = (short)1314928121;
				switch (num2 == num)
				{
				}
				num = (short)690552833;
				if (num != 0)
				{
				}
				num = (short)659423232;
				if (num != 0)
				{
				}
				num = (short)968818688;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Value = value;
			}
		}

		// Token: 0x17004F01 RID: 20225
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x009300C4 File Offset: 0x0092E2C4
		// (set) Token: 0x06009D50 RID: 40272 RVA: 0x00930178 File Offset: 0x0092E378
		public bool CnvEmerProfMDCEnable2_A7924_Applicable
		{
			get
			{
				short num = (short)1036192441;
				short num2 = num;
				num = (short)1609632441;
				switch (num2 == num)
				{
				}
				num = (short)162856960;
				if (num != 0)
				{
				}
				num = (short)2026110977;
				if (num != 0)
				{
				}
				num = (short)1131151360;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Applicable;
			}
			set
			{
				short num = (short)908120131;
				short num2 = num;
				num = (short)1751896131;
				switch (num2 == num)
				{
				}
				num = (short)386465793;
				if (num != 0)
				{
				}
				num = (short)1499725824;
				if (num != 0)
				{
				}
				num = (short)1383399424;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Applicable = value;
			}
		}

		// Token: 0x17004F02 RID: 20226
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x00930230 File Offset: 0x0092E430
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x009302E8 File Offset: 0x0092E4E8
		public bool CnvEmerProfMDCEnable2_A7924_Valid
		{
			get
			{
				short num = (short)1030999398;
				short num2 = num;
				num = (short)1486605670;
				switch (num2 == num)
				{
				}
				num = (short)1853620225;
				if (num != 0)
				{
				}
				num = (short)1780613120;
				if (num != 0)
				{
				}
				num = (short)1712128000;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Valid;
			}
			set
			{
				short num = (short)1401284230;
				short num2 = num;
				num = (short)168093318;
				switch (num2 == num)
				{
				}
				num = (short)1399848960;
				if (num != 0)
				{
				}
				num = (short)1953693697;
				if (num != 0)
				{
				}
				num = (short)1025376256;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Valid = value;
			}
		}

		// Token: 0x17004F03 RID: 20227
		// (get) Token: 0x06009D53 RID: 40275 RVA: 0x0093039C File Offset: 0x0092E59C
		// (set) Token: 0x06009D54 RID: 40276 RVA: 0x00930454 File Offset: 0x0092E654
		public bool CnvEmerProfMDCEnable2_A7924_Visible
		{
			get
			{
				short num = (short)116850689;
				if (num != 0)
				{
				}
				num = (short)1529079802;
				short num2 = num;
				num = (short)257419258;
				switch (num2 == num)
				{
				}
				num = (short)85458944;
				if (num != 0)
				{
				}
				num = (short)1990197248;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Visible;
			}
			set
			{
				short num = (short)1350269184;
				short num2 = num;
				num = (short)909998336;
				switch (num2 == num)
				{
				}
				num = (short)553320449;
				if (num != 0)
				{
				}
				num = (short)1042808832;
				if (num != 0)
				{
				}
				num = (short)94896128;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Visible = value;
			}
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06009D55 RID: 40277 RVA: 0x0093050C File Offset: 0x0092E70C
		// (set) Token: 0x06009D56 RID: 40278 RVA: 0x009305C4 File Offset: 0x0092E7C4
		public bool CnvEmerProfMDCEnable2_A7924_Editable
		{
			get
			{
				short num = (short)1521680385;
				if (num != 0)
				{
				}
				num = (short)1949929547;
				short num2 = num;
				num = (short)723488843;
				switch (num2 == num)
				{
				}
				num = (short)1854996480;
				if (num != 0)
				{
				}
				num = (short)1332674560;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.Editable;
			}
			set
			{
				short num = (short)471072769;
				if (num != 0)
				{
				}
				num = (short)9021410;
				short num2 = num;
				num = (short)328706018;
				switch (num2 == num)
				{
				}
				num = (short)1165557760;
				if (num != 0)
				{
				}
				num = (short)1802895360;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.Editable = value;
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x0093067C File Offset: 0x0092E87C
		internal string CnvEmerProfMDCEnable2_A7924_UILabel
		{
			get
			{
				short num = (short)1346371585;
				if (num != 0)
				{
				}
				num = (short)2131089106;
				short num2 = num;
				num = (short)1380112082;
				switch (num2 == num)
				{
				}
				num = (short)1737097216;
				if (num != 0)
				{
				}
				num = (short)862846976;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.UIName;
			}
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x00930734 File Offset: 0x0092E934
		// (set) Token: 0x06009D59 RID: 40281 RVA: 0x009307E4 File Offset: 0x0092E9E4
		internal bool CnvEmerProfMDCEnable2_A7924_HiddenStatic
		{
			get
			{
				short num = (short)316728468;
				short num2 = num;
				num = (short)285926548;
				switch (num2 == num)
				{
				}
				num = (short)1255800833;
				if (num != 0)
				{
				}
				num = (short)1905197056;
				if (num != 0)
				{
				}
				num = (short)211615744;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.HiddenStatic;
			}
			set
			{
				short num = (short)147284955;
				short num2 = num;
				num = (short)72704987;
				switch (num2 == num)
				{
				}
				num = (short)1266221056;
				if (num != 0)
				{
				}
				num = (short)1165623297;
				if (num != 0)
				{
				}
				num = (short)731119616;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.HiddenStatic = value;
			}
		}

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x06009D5A RID: 40282 RVA: 0x0093089C File Offset: 0x0092EA9C
		// (set) Token: 0x06009D5B RID: 40283 RVA: 0x0093094C File Offset: 0x0092EB4C
		internal bool CnvEmerProfMDCEnable2_A7924_HiddenDynamic
		{
			get
			{
				short num = (short)1359974347;
				short num2 = num;
				num = (short)1912246219;
				switch (num2 == num)
				{
				}
				num = (short)829358081;
				if (num != 0)
				{
				}
				num = (short)1410990080;
				if (num != 0)
				{
				}
				num = (short)497614848;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924.HiddenDynamic;
			}
			set
			{
				short num = (short)1722585281;
				short num2 = num;
				num = (short)948998337;
				switch (num2 == num)
				{
				}
				num = (short)92340225;
				if (num != 0)
				{
				}
				num = (short)901447680;
				if (num != 0)
				{
				}
				num = (short)667942912;
				short num3 = num;
				this.cnvEmerProfMDCEnable2_A7924.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x00930A00 File Offset: 0x0092EC00
		public bool CnvEmerProfMDCEnable2_A7924_HasDiffs
		{
			get
			{
				short num = (short)1838361625;
				short num2 = num;
				num = (short)875310105;
				switch (num2 == num)
				{
				}
				num = (short)1590820864;
				if (num != 0)
				{
				}
				num = (short)1614217217;
				if (num != 0)
				{
				}
				num = (short)136642560;
				short num3 = num;
				return this.cnvEmerProfMDCEnable2_A7924._HasDiffs;
			}
		}

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x06009D5D RID: 40285 RVA: 0x00930AB8 File Offset: 0x0092ECB8
		// (set) Token: 0x06009D5E RID: 40286 RVA: 0x00930B70 File Offset: 0x0092ED70
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946Value
		{
			get
			{
				short num = (short)1062909;
				short num2 = num;
				num = (short)435435517;
				switch (num2 == num)
				{
				}
				num = (short)117243904;
				if (num != 0)
				{
				}
				num = (short)1239875585;
				if (num != 0)
				{
				}
				num = (short)210436096;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Value;
			}
			set
			{
				short num = (short)838402049;
				if (num != 0)
				{
				}
				num = (short)1064462960;
				short num2 = num;
				num = (short)392850032;
				switch (num2 == num)
				{
				}
				num = (short)350617600;
				if (num != 0)
				{
				}
				num = (short)990445568;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Value = value;
			}
		}

		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x06009D5F RID: 40287 RVA: 0x00930C28 File Offset: 0x0092EE28
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfMDCEmergencyPTTIDSidetone_A7946
		{
			get
			{
				short num = (short)66083746;
				short num2 = num;
				num = (short)551246754;
				switch (num2 == num)
				{
				}
				num = (short)1513947137;
				if (num != 0)
				{
				}
				num = (short)1730805760;
				if (num != 0)
				{
				}
				num = (short)1863319552;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946;
			}
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x06009D60 RID: 40288 RVA: 0x00930CD8 File Offset: 0x0092EED8
		// (set) Token: 0x06009D61 RID: 40289 RVA: 0x00930D8C File Offset: 0x0092EF8C
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_UIValue
		{
			get
			{
				short num = (short)184287233;
				if (num != 0)
				{
				}
				num = (short)460687858;
				short num2 = num;
				num = (short)1525713394;
				switch (num2 == num)
				{
				}
				num = (short)2082996224;
				if (num != 0)
				{
				}
				num = (short)2114977792;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Value;
			}
			set
			{
				short num = (short)375386319;
				short num2 = num;
				num = (short)1401614543;
				switch (num2 == num)
				{
				}
				num = (short)2136014849;
				if (num != 0)
				{
				}
				num = (short)178323456;
				if (num != 0)
				{
				}
				num = (short)1646002176;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Value = value;
			}
		}

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x00930E44 File Offset: 0x0092F044
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x00930EF4 File Offset: 0x0092F0F4
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_Applicable
		{
			get
			{
				short num = (short)156653454;
				short num2 = num;
				num = (short)1166366606;
				switch (num2 == num)
				{
				}
				num = (short)1476395009;
				if (num != 0)
				{
				}
				num = (short)1574502400;
				if (num != 0)
				{
				}
				num = (short)1233453056;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Applicable;
			}
			set
			{
				short num = (short)1529525886;
				short num2 = num;
				num = (short)900511358;
				switch (num2 == num)
				{
				}
				num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)1912602624;
				if (num != 0)
				{
				}
				num = (short)769392640;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Applicable = value;
			}
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x00930FAC File Offset: 0x0092F1AC
		// (set) Token: 0x06009D65 RID: 40293 RVA: 0x00931060 File Offset: 0x0092F260
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_Valid
		{
			get
			{
				short num = (short)819006124;
				short num2 = num;
				num = (short)58591916;
				switch (num2 == num)
				{
				}
				num = (short)1980301313;
				if (num != 0)
				{
				}
				num = (short)1187250176;
				if (num != 0)
				{
				}
				num = (short)591790080;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Valid;
			}
			set
			{
				short num = (short)1306705682;
				short num2 = num;
				num = (short)1229504274;
				switch (num2 == num)
				{
				}
				num = (short)745209857;
				if (num != 0)
				{
				}
				num = (short)1714159616;
				if (num != 0)
				{
				}
				num = (short)859504640;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Valid = value;
			}
		}

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x00931118 File Offset: 0x0092F318
		// (set) Token: 0x06009D67 RID: 40295 RVA: 0x009311CC File Offset: 0x0092F3CC
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_Visible
		{
			get
			{
				short num = (short)760338355;
				short num2 = num;
				num = (short)518182835;
				switch (num2 == num)
				{
				}
				num = (short)621019137;
				if (num != 0)
				{
				}
				num = (short)1076756480;
				if (num != 0)
				{
				}
				num = (short)796590080;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Visible;
			}
			set
			{
				short num = (short)1879975900;
				short num2 = num;
				num = (short)1173563356;
				switch (num2 == num)
				{
				}
				num = (short)1740374017;
				if (num != 0)
				{
				}
				num = (short)850395136;
				if (num != 0)
				{
				}
				num = (short)1081999360;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Visible = value;
			}
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x06009D68 RID: 40296 RVA: 0x00931280 File Offset: 0x0092F480
		// (set) Token: 0x06009D69 RID: 40297 RVA: 0x00931338 File Offset: 0x0092F538
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_Editable
		{
			get
			{
				short num = (short)1473904641;
				if (num != 0)
				{
				}
				num = (short)623755076;
				short num2 = num;
				num = (short)1370013508;
				switch (num2 == num)
				{
				}
				num = (short)1124401152;
				if (num != 0)
				{
				}
				num = (short)1397882880;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Editable;
			}
			set
			{
				short num = (short)765274970;
				short num2 = num;
				num = (short)652356442;
				switch (num2 == num)
				{
				}
				num = (short)2068250625;
				if (num != 0)
				{
				}
				num = (short)1514536960;
				if (num != 0)
				{
				}
				num = (short)1190395904;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.Editable = value;
			}
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x009313EC File Offset: 0x0092F5EC
		internal string CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_UILabel
		{
			get
			{
				short num = (short)546944348;
				short num2 = num;
				num = (short)2000598364;
				switch (num2 == num)
				{
				}
				num = (short)71106561;
				if (num != 0)
				{
				}
				num = (short)124518400;
				if (num != 0)
				{
				}
				num = (short)1965686784;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.UIName;
			}
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06009D6B RID: 40299 RVA: 0x009314A4 File Offset: 0x0092F6A4
		// (set) Token: 0x06009D6C RID: 40300 RVA: 0x00931558 File Offset: 0x0092F758
		internal bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_HiddenStatic
		{
			get
			{
				short num = (short)740063596;
				short num2 = num;
				num = (short)381450604;
				switch (num2 == num)
				{
				}
				num = (short)14286849;
				if (num != 0)
				{
				}
				num = (short)1573453824;
				if (num != 0)
				{
				}
				num = (short)1790574592;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.HiddenStatic;
			}
			set
			{
				short num = (short)1816854529;
				if (num != 0)
				{
				}
				num = (short)548465375;
				short num2 = num;
				num = (short)663546591;
				switch (num2 == num)
				{
				}
				num = (short)73859072;
				if (num != 0)
				{
				}
				num = (short)1122435072;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.HiddenStatic = value;
			}
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06009D6D RID: 40301 RVA: 0x00931610 File Offset: 0x0092F810
		// (set) Token: 0x06009D6E RID: 40302 RVA: 0x009316C8 File Offset: 0x0092F8C8
		internal bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_HiddenDynamic
		{
			get
			{
				short num = (short)1359712713;
				short num2 = num;
				num = (short)789156297;
				switch (num2 == num)
				{
				}
				num = (short)771751937;
				if (num != 0)
				{
				}
				num = (short)2017132544;
				if (num != 0)
				{
				}
				num = (short)1291517952;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.HiddenDynamic;
			}
			set
			{
				short num = (short)1710078055;
				short num2 = num;
				num = (short)1094826087;
				switch (num2 == num)
				{
				}
				num = (short)1379729409;
				if (num != 0)
				{
				}
				num = (short)1671954432;
				if (num != 0)
				{
				}
				num = (short)10223616;
				short num3 = num;
				this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06009D6F RID: 40303 RVA: 0x00931778 File Offset: 0x0092F978
		public bool CnvEmerProfMDCEmergencyPTTIDSidetone_A7946_HasDiffs
		{
			get
			{
				short num = (short)2093882114;
				short num2 = num;
				num = (short)1178016514;
				switch (num2 == num)
				{
				}
				num = (short)1869479937;
				if (num != 0)
				{
				}
				num = (short)206372864;
				if (num != 0)
				{
				}
				num = (short)332660736;
				short num3 = num;
				return this.cnvEmerProfMDCEmergencyPTTIDSidetone_A7946._HasDiffs;
			}
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x0093182C File Offset: 0x0092FA2C
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x009318E0 File Offset: 0x0092FAE0
		public int CnvEmerProfMDCRxBaseTimesec_A8999Value
		{
			get
			{
				short num = (short)674824193;
				if (num != 0)
				{
				}
				num = (short)475229943;
				short num2 = num;
				num = (short)1655926519;
				switch (num2 == num)
				{
				}
				num = (short)369426432;
				if (num != 0)
				{
				}
				num = (short)231014400;
				short num3 = num;
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Value;
			}
			set
			{
				short num = (short)1793969464;
				short num2 = num;
				num = (short)828886328;
				switch (num2 == num)
				{
				}
				num = (short)1912340480;
				if (num != 0)
				{
				}
				num = (short)328466433;
				if (num != 0)
				{
				}
				num = (short)1940717568;
				short num3 = num;
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Value = value;
			}
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x00931994 File Offset: 0x0092FB94
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvEmerProfMDCRxBaseTimesec_A8999
		{
			get
			{
				short num = (short)1834257966;
				short num2 = num;
				num = (short)1424264750;
				switch (num2 == num)
				{
				}
				num = (short)1784807425;
				if (num != 0)
				{
				}
				num = (short)1102708736;
				if (num != 0)
				{
				}
				num = (short)986382336;
				short num3 = num;
				return this.cnvEmerProfMDCRxBaseTimesec_A8999;
			}
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x06009D73 RID: 40307 RVA: 0x00931A44 File Offset: 0x0092FC44
		// (set) Token: 0x06009D74 RID: 40308 RVA: 0x00931AF8 File Offset: 0x0092FCF8
		public string CnvEmerProfMDCRxBaseTimesec_A8999_UIValue
		{
			get
			{
				short num = (short)673690843;
				short num2 = num;
				num = (short)1431418075;
				switch (num2 == num)
				{
				}
				num = (short)429129729;
				if (num != 0)
				{
				}
				num = (short)1159397376;
				if (num != 0)
				{
				}
				num = (short)241827840;
				short num3 = num;
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.UIValue;
			}
			set
			{
				short num = (short)1270828767;
				short num2 = num;
				num = (short)376000223;
				switch (num2 == num)
				{
				}
				num = (short)1980563457;
				if (num != 0)
				{
				}
				num = (short)1263927296;
				if (num != 0)
				{
				}
				num = (short)1973813248;
				short num3 = num;
				this.cnvEmerProfMDCRxBaseTimesec_A8999.UIValue = value;
			}
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06009D75 RID: 40309 RVA: 0x00931BAC File Offset: 0x0092FDAC
		// (set) Token: 0x06009D76 RID: 40310 RVA: 0x00931C60 File Offset: 0x0092FE60
		internal int CnvEmerProfMDCRxBaseTimesec_A8999Min
		{
			get
			{
				short num = (short)176117905;
				short num2 = num;
				num = (short)1091983505;
				switch (num2 == num)
				{
				}
				num = (short)1888157696;
				if (num != 0)
				{
				}
				num = (short)1341259777;
				if (num != 0)
				{
				}
				num = (short)1213005824;
				short num3 = num;
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Min;
			}
			set
			{
				short num = (short)1073058428;
				short num2 = num;
				num = (short)134451836;
				switch (num2 == num)
				{
				}
				num = (short)366673920;
				if (num != 0)
				{
				}
				num = (short)1684013057;
				if (num != 0)
				{
				}
				num = (short)1484259328;
				short num3 = num;
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Min = value;
			}
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x06009D77 RID: 40311 RVA: 0x00931D1C File Offset: 0x0092FF1C
		// (set) Token: 0x06009D78 RID: 40312 RVA: 0x00931DD4 File Offset: 0x0092FFD4
		internal int CnvEmerProfMDCRxBaseTimesec_A8999Max
		{
			get
			{
				short num = (short)237785871;
				short num2 = num;
				num = (short)927224591;
				switch (num2 == num)
				{
				}
				num = (short)482541568;
				if (num != 0)
				{
				}
				num = (short)1605566465;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				short num3 = num;
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Max;
			}
			set
			{
				short num = (short)1890048298;
				short num2 = num;
				num = (short)682088746;
				switch (num2 == num)
				{
				}
				num = (short)2066874369;
				if (num != 0)
				{
				}
				num = (short)1240793088;
				if (num != 0)
				{
				}
				num = (short)1673854976;
				short num3 = num;
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Max = value;
			}
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x06009D79 RID: 40313 RVA: 0x00931E88 File Offset: 0x00930088
		// (set) Token: 0x06009D7A RID: 40314 RVA: 0x00931F40 File Offset: 0x00930140
		internal int CnvEmerProfMDCRxBaseTimesec_A8999Step
		{
			get
			{
				short num = (short)1796409060;
				short num2 = num;
				num = (short)192218852;
				switch (num2 == num)
				{
				}
				num = (short)798949377;
				if (num != 0)
				{
				}
				num = (short)1579483136;
				short num3 = num;
				num = (short)1959854080;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.StepSize;
			}
			set
			{
				short num = (short)674203120;
				short num2 = num;
				num = (short)1702528496;
				switch (num2 == num)
				{
				}
				num = (short)2105016320;
				if (num != 0)
				{
				}
				num = (short)1842806784;
				short num3 = num;
				num = (short)2124546049;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.StepSize = value;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x06009D7B RID: 40315 RVA: 0x00931FF8 File Offset: 0x009301F8
		// (set) Token: 0x06009D7C RID: 40316 RVA: 0x009320B0 File Offset: 0x009302B0
		public bool CnvEmerProfMDCRxBaseTimesec_A8999_Applicable
		{
			get
			{
				short num = (short)1836318721;
				if (num != 0)
				{
				}
				num = (short)811286539;
				short num2 = num;
				num = (short)1756774411;
				switch (num2 == num)
				{
				}
				num = (short)1966276608;
				short num3 = num;
				num = (short)1554776064;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Applicable;
			}
			set
			{
				short num = (short)425507296;
				short num2 = num;
				num = (short)917551584;
				switch (num2 == num)
				{
				}
				num = (short)1570439169;
				if (num != 0)
				{
				}
				num = (short)444661760;
				short num3 = num;
				num = (short)1972436992;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Applicable = value;
			}
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06009D7D RID: 40317 RVA: 0x00932168 File Offset: 0x00930368
		// (set) Token: 0x06009D7E RID: 40318 RVA: 0x00932220 File Offset: 0x00930420
		public bool CnvEmerProfMDCRxBaseTimesec_A8999_Valid
		{
			get
			{
				short num = (short)1149025849;
				short num2 = num;
				num = (short)920960569;
				switch (num2 == num)
				{
				}
				num = (short)231538688;
				if (num != 0)
				{
				}
				num = (short)1026031616;
				short num3 = num;
				num = (short)502661121;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Valid;
			}
			set
			{
				short num = (short)373424129;
				if (num != 0)
				{
				}
				num = (short)646249101;
				short num2 = num;
				num = (short)215808653;
				switch (num2 == num)
				{
				}
				num = (short)529858560;
				short num3 = num;
				num = (short)1901264896;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Valid = value;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x06009D7F RID: 40319 RVA: 0x009322D4 File Offset: 0x009304D4
		// (set) Token: 0x06009D80 RID: 40320 RVA: 0x00932388 File Offset: 0x00930588
		public bool CnvEmerProfMDCRxBaseTimesec_A8999_Visible
		{
			get
			{
				short num = (short)1430132032;
				short num2 = num;
				num = (short)1280447808;
				switch (num2 == num)
				{
				}
				num = (short)1260978177;
				if (num != 0)
				{
				}
				num = (short)1447886848;
				short num3 = num;
				num = (short)2228224;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Visible;
			}
			set
			{
				short num = (short)1072693249;
				if (num != 0)
				{
				}
				num = (short)282915782;
				short num2 = num;
				num = (short)1451553734;
				switch (num2 == num)
				{
				}
				num = (short)1307377664;
				short num3 = num;
				num = (short)1697775616;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Visible = value;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x06009D81 RID: 40321 RVA: 0x0093243C File Offset: 0x0093063C
		// (set) Token: 0x06009D82 RID: 40322 RVA: 0x009324F0 File Offset: 0x009306F0
		public bool CnvEmerProfMDCRxBaseTimesec_A8999_Editable
		{
			get
			{
				short num = (short)817402107;
				short num2 = num;
				num = (short)1950454011;
				switch (num2 == num)
				{
				}
				num = (short)607846401;
				if (num != 0)
				{
				}
				num = (short)1584201728;
				short num3 = num;
				num = (short)912785408;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.Editable;
			}
			set
			{
				short num = (short)375382521;
				short num2 = num;
				num = (short)892658169;
				switch (num2 == num)
				{
				}
				num = (short)833552384;
				if (num != 0)
				{
				}
				num = (short)878641152;
				short num3 = num;
				num = (short)1674313729;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.Editable = value;
			}
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06009D83 RID: 40323 RVA: 0x009325A8 File Offset: 0x009307A8
		internal string CnvEmerProfMDCRxBaseTimesec_A8999_UILabel
		{
			get
			{
				short num = (short)1345285412;
				short num2 = num;
				num = (short)259288356;
				switch (num2 == num)
				{
				}
				num = (short)1615134721;
				if (num != 0)
				{
				}
				num = (short)1470300160;
				short num3 = num;
				num = (short)1066926080;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.UIName;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x06009D84 RID: 40324 RVA: 0x0093265C File Offset: 0x0093085C
		// (set) Token: 0x06009D85 RID: 40325 RVA: 0x00932710 File Offset: 0x00930910
		internal bool CnvEmerProfMDCRxBaseTimesec_A8999_HiddenStatic
		{
			get
			{
				short num = (short)22478849;
				if (num != 0)
				{
				}
				num = (short)594525003;
				short num2 = num;
				num = (short)939965259;
				switch (num2 == num)
				{
				}
				num = (short)1278541824;
				short num3 = num;
				num = (short)503513088;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.HiddenStatic;
			}
			set
			{
				short num = (short)433422202;
				short num2 = num;
				num = (short)974684026;
				switch (num2 == num)
				{
				}
				num = (short)1823145984;
				if (num != 0)
				{
				}
				num = (short)972226560;
				short num3 = num;
				num = (short)456916993;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.HiddenStatic = value;
			}
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x009327C8 File Offset: 0x009309C8
		// (set) Token: 0x06009D87 RID: 40327 RVA: 0x00932878 File Offset: 0x00930A78
		internal bool CnvEmerProfMDCRxBaseTimesec_A8999_HiddenDynamic
		{
			get
			{
				short num = (short)1032257548;
				short num2 = num;
				num = (short)969015308;
				switch (num2 == num)
				{
				}
				num = (short)703397889;
				if (num != 0)
				{
				}
				num = (short)308477952;
				short num3 = num;
				num = (short)1346437120;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999.HiddenDynamic;
			}
			set
			{
				short num = (short)255332657;
				short num2 = num;
				num = (short)2093682993;
				switch (num2 == num)
				{
				}
				num = (short)209518593;
				if (num != 0)
				{
				}
				num = (short)1295450112;
				short num3 = num;
				num = (short)720371712;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCRxBaseTimesec_A8999.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x06009D88 RID: 40328 RVA: 0x0093292C File Offset: 0x00930B2C
		public bool CnvEmerProfMDCRxBaseTimesec_A8999_HasDiffs
		{
			get
			{
				short num = (short)542569907;
				short num2 = num;
				num = (short)500037043;
				switch (num2 == num)
				{
				}
				num = (short)1121320961;
				if (num != 0)
				{
				}
				num = (short)1571160064;
				short num3 = num;
				num = (short)364773376;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCRxBaseTimesec_A8999._HasDiffs;
			}
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x06009D89 RID: 40329 RVA: 0x009329E0 File Offset: 0x00930BE0
		// (set) Token: 0x06009D8A RID: 40330 RVA: 0x00932A94 File Offset: 0x00930C94
		public int CnvEmerProfMDCTxBaseTimeSec_A9514Value
		{
			get
			{
				short num = (short)1590541993;
				short num2 = num;
				num = (short)660324009;
				switch (num2 == num)
				{
				}
				num = (short)1227685889;
				if (num != 0)
				{
				}
				num = (short)96993280;
				short num3 = num;
				num = (short)1737162752;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Value;
			}
			set
			{
				short num = (short)1106313217;
				if (num != 0)
				{
				}
				num = (short)382478517;
				short num2 = num;
				num = (short)159656117;
				switch (num2 == num)
				{
				}
				num = (short)644546560;
				short num3 = num;
				num = (short)2056847360;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Value = value;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x06009D8B RID: 40331 RVA: 0x00932B4C File Offset: 0x00930D4C
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvEmerProfMDCTxBaseTimeSec_A9514
		{
			get
			{
				short num = (short)1328434598;
				short num2 = num;
				num = (short)875908518;
				switch (num2 == num)
				{
				}
				num = (short)710475777;
				if (num != 0)
				{
				}
				num = (short)1830879232;
				short num3 = num;
				num = (short)177799168;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514;
			}
		}

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x06009D8C RID: 40332 RVA: 0x00932C00 File Offset: 0x00930E00
		// (set) Token: 0x06009D8D RID: 40333 RVA: 0x00932CB4 File Offset: 0x00930EB4
		public string CnvEmerProfMDCTxBaseTimeSec_A9514_UIValue
		{
			get
			{
				short num = (short)1775819503;
				short num2 = num;
				num = (short)1058396911;
				switch (num2 == num)
				{
				}
				num = (short)221708288;
				if (num != 0)
				{
				}
				num = (short)632225792;
				short num3 = num;
				num = (short)343605249;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.UIValue;
			}
			set
			{
				short num = (short)549596789;
				short num2 = num;
				num = (short)1984507509;
				switch (num2 == num)
				{
				}
				num = (short)740294657;
				if (num != 0)
				{
				}
				num = (short)1030422528;
				short num3 = num;
				num = (short)771817472;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.UIValue = value;
			}
		}

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x06009D8E RID: 40334 RVA: 0x00932D6C File Offset: 0x00930F6C
		// (set) Token: 0x06009D8F RID: 40335 RVA: 0x00932E20 File Offset: 0x00931020
		internal int CnvEmerProfMDCTxBaseTimeSec_A9514Min
		{
			get
			{
				short num = (short)973012993;
				if (num != 0)
				{
				}
				num = (short)248703986;
				short num2 = num;
				num = (short)295169010;
				switch (num2 == num)
				{
				}
				num = (short)261423104;
				short num3 = num;
				num = (short)496107520;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Min;
			}
			set
			{
				short num = (short)1622212609;
				if (num != 0)
				{
				}
				num = (short)2051822283;
				short num2 = num;
				num = (short)191779531;
				switch (num2 == num)
				{
				}
				num = (short)1743978496;
				short num3 = num;
				num = (short)1876426752;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Min = value;
			}
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x00932ED4 File Offset: 0x009310D4
		// (set) Token: 0x06009D91 RID: 40337 RVA: 0x00932F88 File Offset: 0x00931188
		internal int CnvEmerProfMDCTxBaseTimeSec_A9514Max
		{
			get
			{
				short num = (short)134261619;
				short num2 = num;
				num = (short)741780339;
				switch (num2 == num)
				{
				}
				num = (short)1784676353;
				if (num != 0)
				{
				}
				num = (short)548536320;
				short num3 = num;
				num = (short)1115422720;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Max;
			}
			set
			{
				short num = (short)2054649032;
				short num2 = num;
				num = (short)541488328;
				switch (num2 == num)
				{
				}
				num = (short)1468006400;
				if (num != 0)
				{
				}
				num = (short)1255604224;
				short num3 = num;
				num = (short)1824456705;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Max = value;
			}
		}

		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x06009D92 RID: 40338 RVA: 0x0093303C File Offset: 0x0093123C
		// (set) Token: 0x06009D93 RID: 40339 RVA: 0x009330F4 File Offset: 0x009312F4
		internal int CnvEmerProfMDCTxBaseTimeSec_A9514Step
		{
			get
			{
				short num = (short)1362436553;
				short num2 = num;
				num = (short)1774854601;
				switch (num2 == num)
				{
				}
				num = (short)1486618625;
				if (num != 0)
				{
				}
				num = (short)1501560832;
				short num3 = num;
				num = (short)210632704;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.StepSize;
			}
			set
			{
				short num = (short)348913665;
				if (num != 0)
				{
				}
				num = (short)928734944;
				short num2 = num;
				num = (short)1021927136;
				switch (num2 == num)
				{
				}
				num = (short)1850933248;
				short num3 = num;
				num = (short)1801256960;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.StepSize = value;
			}
		}

		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x06009D94 RID: 40340 RVA: 0x009331AC File Offset: 0x009313AC
		// (set) Token: 0x06009D95 RID: 40341 RVA: 0x00933260 File Offset: 0x00931460
		public bool CnvEmerProfMDCTxBaseTimeSec_A9514_Applicable
		{
			get
			{
				short num = (short)1372367310;
				short num2 = num;
				num = (short)991734222;
				switch (num2 == num)
				{
				}
				num = (short)129695745;
				if (num != 0)
				{
				}
				num = (short)159449088;
				short num3 = num;
				num = (short)465502208;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Applicable;
			}
			set
			{
				short num = (short)1023980948;
				short num2 = num;
				num = (short)1192670612;
				switch (num2 == num)
				{
				}
				num = (short)1138688000;
				if (num != 0)
				{
				}
				num = (short)663879680;
				short num3 = num;
				num = (short)999751681;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Applicable = value;
			}
		}

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x06009D96 RID: 40342 RVA: 0x00933318 File Offset: 0x00931518
		// (set) Token: 0x06009D97 RID: 40343 RVA: 0x009333CC File Offset: 0x009315CC
		public bool CnvEmerProfMDCTxBaseTimeSec_A9514_Valid
		{
			get
			{
				short num = (short)1449331907;
				short num2 = num;
				num = (short)1515588803;
				switch (num2 == num)
				{
				}
				num = (short)684457984;
				if (num != 0)
				{
				}
				num = (short)715128832;
				short num3 = num;
				num = (short)985202689;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Valid;
			}
			set
			{
				short num = (short)1758461953;
				if (num != 0)
				{
				}
				num = (short)770257249;
				short num2 = num;
				num = (short)2033660257;
				switch (num2 == num)
				{
				}
				num = (short)1352925184;
				short num3 = num;
				num = (short)1944584192;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Valid = value;
			}
		}

		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x00933484 File Offset: 0x00931684
		// (set) Token: 0x06009D99 RID: 40345 RVA: 0x0093353C File Offset: 0x0093173C
		public bool CnvEmerProfMDCTxBaseTimeSec_A9514_Visible
		{
			get
			{
				short num = (short)2089180755;
				short num2 = num;
				num = (short)920542803;
				switch (num2 == num)
				{
				}
				num = (short)278331393;
				if (num != 0)
				{
				}
				num = (short)566886400;
				short num3 = num;
				num = (short)823197696;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Visible;
			}
			set
			{
				short num = (short)414057598;
				short num2 = num;
				num = (short)2065171582;
				switch (num2 == num)
				{
				}
				num = (short)1305477120;
				if (num != 0)
				{
				}
				num = (short)809500672;
				short num3 = num;
				num = (short)1060896769;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Visible = value;
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x06009D9A RID: 40346 RVA: 0x009335F0 File Offset: 0x009317F0
		// (set) Token: 0x06009D9B RID: 40347 RVA: 0x009336A4 File Offset: 0x009318A4
		public bool CnvEmerProfMDCTxBaseTimeSec_A9514_Editable
		{
			get
			{
				short num = (short)2035613697;
				if (num != 0)
				{
				}
				num = (short)2026167635;
				short num2 = num;
				num = (short)902683987;
				switch (num2 == num)
				{
				}
				num = (short)130482176;
				short num3 = num;
				num = (short)569376768;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.Editable;
			}
			set
			{
				short num = (short)340001736;
				short num2 = num;
				num = (short)1366819784;
				switch (num2 == num)
				{
				}
				num = (short)1269694465;
				if (num != 0)
				{
				}
				num = (short)356253696;
				short num3 = num;
				num = (short)877264896;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.Editable = value;
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x06009D9C RID: 40348 RVA: 0x00933758 File Offset: 0x00931958
		internal string CnvEmerProfMDCTxBaseTimeSec_A9514_UILabel
		{
			get
			{
				short num = (short)1788033313;
				short num2 = num;
				num = (short)1675573537;
				switch (num2 == num)
				{
				}
				num = (short)445186048;
				if (num != 0)
				{
				}
				num = (short)1889599488;
				short num3 = num;
				num = (short)2141978625;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.UIName;
			}
		}

		// Token: 0x17004F2D RID: 20269
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x0093380C File Offset: 0x00931A0C
		// (set) Token: 0x06009D9E RID: 40350 RVA: 0x009338C0 File Offset: 0x00931AC0
		internal bool CnvEmerProfMDCTxBaseTimeSec_A9514_HiddenStatic
		{
			get
			{
				short num = (short)180721576;
				short num2 = num;
				num = (short)2078185384;
				switch (num2 == num)
				{
				}
				num = (short)1977548801;
				if (num != 0)
				{
				}
				num = (short)69468160;
				short num3 = num;
				num = (short)1594949632;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.HiddenStatic;
			}
			set
			{
				short num = (short)1715432956;
				short num2 = num;
				num = (short)59534844;
				switch (num2 == num)
				{
				}
				num = (short)965869568;
				if (num != 0)
				{
				}
				num = (short)1293352960;
				short num3 = num;
				num = (short)1790181377;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.HiddenStatic = value;
			}
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x00933974 File Offset: 0x00931B74
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x00933A2C File Offset: 0x00931C2C
		internal bool CnvEmerProfMDCTxBaseTimeSec_A9514_HiddenDynamic
		{
			get
			{
				short num = (short)211419403;
				short num2 = num;
				num = (short)2012872971;
				switch (num2 == num)
				{
				}
				num = (short)759365633;
				if (num != 0)
				{
				}
				num = (short)496959488;
				short num3 = num;
				num = (short)2038497280;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514.HiddenDynamic;
			}
			set
			{
				short num = (short)1546006732;
				short num2 = num;
				num = (short)1215443148;
				switch (num2 == num)
				{
				}
				num = (short)1547436033;
				if (num != 0)
				{
				}
				num = (short)1827143680;
				short num3 = num;
				num = (short)122552320;
				if (num != 0)
				{
				}
				this.cnvEmerProfMDCTxBaseTimeSec_A9514.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x00933AE0 File Offset: 0x00931CE0
		public bool CnvEmerProfMDCTxBaseTimeSec_A9514_HasDiffs
		{
			get
			{
				short num = (short)1401815041;
				if (num != 0)
				{
				}
				num = (short)1790484508;
				short num2 = num;
				num = (short)453484572;
				switch (num2 == num)
				{
				}
				num = (short)911212544;
				short num3 = num;
				num = (short)1245577216;
				if (num != 0)
				{
				}
				return this.cnvEmerProfMDCTxBaseTimeSec_A9514._HasDiffs;
			}
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x00933B98 File Offset: 0x00931D98
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
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1719698853;
					short num3 = num2;
					num2 = (short)754746789;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1261961216;
						if (num2 != 0)
						{
						}
						num2 = (short)131596288;
						short num4 = num2;
						num2 = (short)1328676866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)413007876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1336279043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_82;
				case 4:
					num2 = (short)575275008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_82:
			num2 = (short)677576705;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)826277889;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004D11 RID: 19729
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004D12 RID: 19730
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004D13 RID: 19731
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004D14 RID: 19732
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvEmerProfMDCTxBaseTimeSec_A9514;
	}
}
