using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A4 RID: 1188
	[global::System.Serializable]
	public class EmergencyToneTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009B14 RID: 39700 RVA: 0x009149D4 File Offset: 0x00912BD4
		public EmergencyToneTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x009149F0 File Offset: 0x00912BF0
		protected EmergencyToneTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x00914A08 File Offset: 0x00912C08
		public override void Init()
		{
			int a_ = 6;
			short num = (short)990954231;
			short num2 = num;
			num = (short)1915011831;
			switch (num2 == num)
			{
			default:
			{
				num = (short)998834176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)387383297;
			if (num != 0)
			{
			}
			num = (short)749076480;
			if (num != 0)
			{
			}
			this.emergencyToneTrigger_42045 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖跘듚돜뫞뗠釢賤胦軨軪鿬냮연쇲열쏶쳸", a_), global::CommonResources.AcgResources.ID_TRIGGER, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmergencyToneTrigger_42045LovStrs);
			this.emergencyToneTrigger_42045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emergencyToneTrigger_42045.DataTransferOrder = 19;
			this.emerTone_42046 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌鯎뻐뷒냔裖ퟠ", a_), global::CommonResources.AcgResources.ID_TONE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmerTone_42046LovStrs);
			this.emerTone_42046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emerTone_42046.DataTransferOrder = 20;
			this.emerToneMinimumVolumn_42047 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌鯎뻐뷒냔髖냘뗚드닞铠転돤裦藨黪胬臮껰쟲쟴쟶췸쳺", a_), global::CommonResources.AcgResources.ID_TONEMINIMUMVOLUME, 0, 255, null, null, 0, 1);
			this.emerToneMinimumVolumn_42047.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emerToneMinimumVolumn_42047.DataTransferOrder = 21;
			this.emerToneMinimumVolumn_42047.ShowHexValue = false;
			this.emerTonePeriodSec_42048 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌鯎뻐뷒냔蟖볘꧚드냞藠냢胤蓦뛨\udfea\udfec\udfee연쯲", a_), global::CommonResources.AcgResources.ID_TONEPERIODSEC, 0, 255, global::CommonResources.AcgResources.ID_ONCE, null, 0, 1);
			this.emerTonePeriodSec_42048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emerTonePeriodSec_42048.DataTransferOrder = 22;
			this.emerTonePeriodSec_42048.ShowHexValue = false;
			this.emerAudioRouting_42049 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌軎ꓐ럒볔룖诘듚꣜ꯞ裠跢苤룦\udde8\ud9ea\uddec\udbee죰", a_), global::CommonResources.AcgResources.ID_AUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmerAudioRouting_42049LovStrs);
			this.emerAudioRouting_42049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emerAudioRouting_42049.DataTransferOrder = 23;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖律迚닜뇞蓠쏢뇤蛦诨蟪裬", a_);
			base.Id = 10774;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00914C4C File Offset: 0x00912E4C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1614217234;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙鷛ꯝ蓟诡诣듥蟧鿩飫蟭黯闱꯳싵쫷쫹죻쟽", a_)))
					{
						num = (short)1013841927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D3;
				case 1:
					goto IL_486;
				case 2:
					num = (short)1332150273;
					if (num != 0)
					{
					}
					this.emerTonePeriodSec_42048 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡듣菥髧菩菫諭ꏯ韱音꧵쳷죹쳻쫽㣿", a_), global::CommonResources.AcgResources.ID_TONEPERIODSEC, global::CommonResources.AcgResources.ID_ONCE, null, 0, 1);
					this.emerTonePeriodSec_42048.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.emerTonePeriodSec_42048.DataTransferOrder = 22;
					this.emerTonePeriodSec_42048.ShowHexValue = false;
					num = (short)1427308550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.emerToneMinimumVolumn_42047 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡ꧣ迥蛧菩臫鯭鷯ꓱ鯳髵跷韹鋻ꇽ㓿、㐃㈅㼇", a_), global::CommonResources.AcgResources.ID_TONEMINIMUMVOLUME, null, null, 0, 1);
					this.emerToneMinimumVolumn_42047.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.emerToneMinimumVolumn_42047.DataTransferOrder = 21;
					this.emerToneMinimumVolumn_42047.ShowHexValue = false;
					num = (short)18153489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_E8;
				case 5:
					goto IL_365;
				case 6:
					goto IL_1CB;
				case 7:
				{
					num = (short)2002911232;
					short num3 = num;
					this.emerAudioRouting_42049 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙鷛ꯝ蓟诡诣듥蟧鿩飫蟭黯闱꯳싵쫷쫹죻쟽", a_), global::CommonResources.AcgResources.ID_AUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmerAudioRouting_42049LovStrs);
					this.emerAudioRouting_42049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.emerAudioRouting_42049.DataTransferOrder = 23;
					goto IL_34E;
				}
				case 8:
					num = (short)1460338701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡믣틥\udae7\udae9\ud8eb\ud8ed", a_)))
					{
						num = (short)368181264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡ꧣ迥蛧菩臫鯭鷯ꓱ鯳髵跷韹鋻ꇽ㓿、㐃㈅㼇", a_)))
					{
						num = (short)90701827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 11:
					if (producerFields != null)
					{
						num = (short)1047592968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D3;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡듣菥髧菩菫諭ꏯ韱音꧵쳷죹쳻쫽㣿", a_)))
					{
						num = (short)1349582850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙믛믝軟臡鷣닥蟧蓩觫뫭苯鯱鏳釵鷷裹ꏻ쫽㋿㈁〃㌅", a_)))
					{
						num = (short)803995663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_486;
				case 14:
					num = (short)179699723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)481050133;
					short num4 = num;
					num = (short)1430339093;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_34E;
					default:
						num = (short)977076224;
						if (num != 0)
						{
						}
						this.emergencyToneTrigger_42045 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙믛믝軟臡鷣닥蟧蓩觫뫭苯鯱鏳釵鷷裹ꏻ쫽㋿㈁〃㌅", a_), global::CommonResources.AcgResources.ID_TRIGGER, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmergencyToneTrigger_42045LovStrs);
						this.emergencyToneTrigger_42045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.emergencyToneTrigger_42045.DataTransferOrder = 19;
						num = (short)1864302593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					this.emerTone_42046 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙裛뇝軟蟡믣틥\udae7\udae9\ud8eb\ud8ed", a_), global::CommonResources.AcgResources.ID_TONE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.EmerTone_42046LovStrs);
					this.emerTone_42046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.emerTone_42046.DataTransferOrder = 20;
					num = (short)1364328452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_9C;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1013121038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)436666380;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E8:
				num = (short)350158858;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CB:
				num = (short)652541952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34E:
				num = (short)745209861;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_486:
				num = (short)1923547145;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_365:
			IL_4D3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙믛믝軟臡鷣웥볧藩苫语탯꛱闳铵铷鿹", a_);
			base.Id = 10774;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00915160 File Offset: 0x00913360
		public override void PopulateReferences()
		{
			short num = (short)360579073;
			if (num != 0)
			{
			}
			num = (short)855179264;
			short num2 = num;
			num = (short)1439138936;
			short num3 = num;
			num = (short)481395832;
			switch (num3 == num)
			{
			}
			num = (short)1196425216;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0091520C File Offset: 0x0091340C
		public override void DropReferences()
		{
			short num = (short)1591345461;
			short num2 = num;
			num = (short)1757479221;
			switch (num2 == num)
			{
			default:
			{
				num = (short)799997952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)520683520;
			if (num != 0)
			{
			}
			num = (short)1453981697;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x009152B4 File Offset: 0x009134B4
		public override void SetConstraints()
		{
			short num = (short)869578873;
			short num2 = num;
			num = (short)762624121;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1823014912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1015087105;
			if (num != 0)
			{
			}
			num = (short)55967744;
			if (num != 0)
			{
			}
			this.emergencyToneTrigger_42045.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conTriggedByManDownEnabled);
			this.emerTone_42046.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conTriggedByManDownEnabled);
			this.emerToneMinimumVolumn_42047.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConCnvLegacyToneNotSelected);
			this.emerTonePeriodSec_42048.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConCnvLegacyToneNotSelected);
			this.emerTonePeriodSec_42048.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conTonePeriodInvalid);
			this.emerAudioRouting_42049.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conCnvAudioRoutingIsApplicable);
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x009153E8 File Offset: 0x009135E8
		public override void SetupDependencies()
		{
			short num = (short)482078327;
			short num2 = num;
			num = (short)1706421879;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1157890048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1658257409;
			if (num != 0)
			{
			}
			num = (short)1274937344;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emergencyToneTrigger_42045);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emergencyToneTrigger_42045);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emergencyToneTrigger_42045);
			conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391.AddDependentObject(this.emergencyToneTrigger_42045);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emergencyToneTrigger_42045);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emerTone_42046);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emerTone_42046);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emerTone_42046);
			conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391.AddDependentObject(this.emerTone_42046);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerTone_42046);
			this.emerTone_42046.AddDependentObject(this.emerToneMinimumVolumn_42047);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emerToneMinimumVolumn_42047);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emerToneMinimumVolumn_42047);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emerToneMinimumVolumn_42047);
			conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391.AddDependentObject(this.emerToneMinimumVolumn_42047);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerToneMinimumVolumn_42047);
			this.emerTone_42046.AddDependentObject(this.emerTonePeriodSec_42048);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emerTonePeriodSec_42048);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emerTonePeriodSec_42048);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emerTonePeriodSec_42048);
			conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391.AddDependentObject(this.emerTonePeriodSec_42048);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerTonePeriodSec_42048);
			this.emerTone_42046.AddDependentObject(this.emerAudioRouting_42049);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emerAudioRouting_42049);
			this.emerTonePeriodSec_42048.AddDependentObject(this.emerAudioRouting_42049);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emerAudioRouting_42049);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emerAudioRouting_42049);
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x0091575C File Offset: 0x0091395C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2116288513;
				if (num != 0)
				{
				}
				num = (short)684392448;
				short num2 = num;
				num = (short)651530270;
				short num3 = num;
				num = (short)966430750;
				switch (num3 == num)
				{
				}
				num = (short)705429504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x06009B1D RID: 39709 RVA: 0x00915810 File Offset: 0x00913A10
		// (set) Token: 0x06009B1E RID: 39710 RVA: 0x009158C8 File Offset: 0x00913AC8
		public int EmergencyToneTrigger_42045Value
		{
			get
			{
				short num = (short)652675234;
				short num2 = num;
				num = (short)1736902818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1653080064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)296878081;
				if (num != 0)
				{
				}
				num = (short)259653632;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.Value;
			}
			set
			{
				short num = (short)113246209;
				if (num != 0)
				{
				}
				num = (short)1708457984;
				short num2 = num;
				num = (short)1913208192;
				short num3 = num;
				num = (short)952384896;
				switch (num3 == num)
				{
				}
				num = (short)1078132736;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.Value = value;
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x00915980 File Offset: 0x00913B80
		// (set) Token: 0x06009B20 RID: 39712 RVA: 0x00915A38 File Offset: 0x00913C38
		public string EmergencyToneTrigger_42045_UIValue
		{
			get
			{
				short num = (short)1527005253;
				short num2 = num;
				num = (short)549142597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230110720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)782630912;
				if (num != 0)
				{
				}
				num = (short)728498177;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.UIValue;
			}
			set
			{
				short num = (short)1238260307;
				short num2 = num;
				num = (short)2121882195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399900672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624965120;
				if (num != 0)
				{
				}
				num = (short)158400513;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.UIValue = value;
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x00915AF0 File Offset: 0x00913CF0
		public global::AcpBusinessLayer.AcpListField EmergencyToneTrigger_42045
		{
			get
			{
				short num = (short)246188784;
				short num2 = num;
				num = (short)1563003632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902903296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)1036058624;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045;
			}
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x06009B22 RID: 39714 RVA: 0x00915BA0 File Offset: 0x00913DA0
		// (set) Token: 0x06009B23 RID: 39715 RVA: 0x00915C54 File Offset: 0x00913E54
		public bool EmergencyToneTrigger_42045_Applicable
		{
			get
			{
				short num = (short)1493106689;
				if (num != 0)
				{
				}
				num = (short)1365377024;
				short num2 = num;
				num = (short)1722639667;
				short num3 = num;
				num = (short)2068210995;
				switch (num3 == num)
				{
				}
				num = (short)525467648;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.Applicable;
			}
			set
			{
				short num = (short)661593253;
				short num2 = num;
				num = (short)1642536101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803471360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682754048;
				if (num != 0)
				{
				}
				num = (short)1246625793;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.Applicable = value;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x00915D08 File Offset: 0x00913F08
		// (set) Token: 0x06009B25 RID: 39717 RVA: 0x00915DBC File Offset: 0x00913FBC
		public bool EmergencyToneTrigger_42045_Valid
		{
			get
			{
				short num = (short)432335940;
				short num2 = num;
				num = (short)266071108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224540160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1774256129;
				if (num != 0)
				{
				}
				num = (short)849412096;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.Valid;
			}
			set
			{
				short num = (short)59352244;
				short num2 = num;
				num = (short)153527476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)994705408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735576065;
				if (num != 0)
				{
				}
				num = (short)824049664;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.Valid = value;
			}
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x00915E70 File Offset: 0x00914070
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x00915F24 File Offset: 0x00914124
		public bool EmergencyToneTrigger_42045_Visible
		{
			get
			{
				short num = (short)1312117094;
				short num2 = num;
				num = (short)784421222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187446784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781530625;
				if (num != 0)
				{
				}
				num = (short)1011548160;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.Visible;
			}
			set
			{
				short num = (short)127206536;
				short num2 = num;
				num = (short)555287688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988231168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272643585;
				if (num != 0)
				{
				}
				num = (short)2001338368;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.Visible = value;
			}
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x00915FD8 File Offset: 0x009141D8
		// (set) Token: 0x06009B29 RID: 39721 RVA: 0x00916090 File Offset: 0x00914290
		public bool EmergencyToneTrigger_42045_Editable
		{
			get
			{
				short num = (short)1792331574;
				short num2 = num;
				num = (short)1074450230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2069889024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391853569;
				if (num != 0)
				{
				}
				num = (short)773324800;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.Editable;
			}
			set
			{
				short num = (short)597267468;
				short num2 = num;
				num = (short)1986630668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568262656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020657665;
				if (num != 0)
				{
				}
				num = (short)435027968;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.Editable = value;
			}
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x00916144 File Offset: 0x00914344
		internal string EmergencyToneTrigger_42045_UILabel
		{
			get
			{
				short num = (short)1275724512;
				short num2 = num;
				num = (short)356451040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870645760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972436992;
				if (num != 0)
				{
				}
				num = (short)1731002369;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.UIName;
			}
		}

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x009161FC File Offset: 0x009143FC
		// (set) Token: 0x06009B2C RID: 39724 RVA: 0x009162B0 File Offset: 0x009144B0
		internal bool EmergencyToneTrigger_42045_HiddenStatic
		{
			get
			{
				short num = (short)1709999427;
				short num2 = num;
				num = (short)750552387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1729691648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873594881;
				if (num != 0)
				{
				}
				num = (short)467075072;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.HiddenStatic;
			}
			set
			{
				short num = (short)1577319479;
				short num2 = num;
				num = (short)732757047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091188224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266534913;
				if (num != 0)
				{
				}
				num = (short)1564344320;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.HiddenStatic = value;
			}
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x06009B2D RID: 39725 RVA: 0x00916368 File Offset: 0x00914568
		// (set) Token: 0x06009B2E RID: 39726 RVA: 0x0091641C File Offset: 0x0091461C
		internal bool EmergencyToneTrigger_42045_HiddenDynamic
		{
			get
			{
				short num = (short)1821968050;
				short num2 = num;
				num = (short)1828456114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)543162368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298530305;
				if (num != 0)
				{
				}
				num = (short)1081868288;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045.HiddenDynamic;
			}
			set
			{
				short num = (short)1736758757;
				short num2 = num;
				num = (short)1986516453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039400960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)436994049;
				if (num != 0)
				{
				}
				num = (short)568328192;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42045.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x009164D4 File Offset: 0x009146D4
		public bool EmergencyToneTrigger_42045_HasDiffs
		{
			get
			{
				short num = (short)1908534753;
				short num2 = num;
				num = (short)1429859809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964113920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51838977;
				if (num != 0)
				{
				}
				num = (short)150732800;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42045._HasDiffs;
			}
		}

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x0091658C File Offset: 0x0091478C
		// (set) Token: 0x06009B31 RID: 39729 RVA: 0x00916640 File Offset: 0x00914840
		public int EmerTone_42046Value
		{
			get
			{
				short num = (short)1632436225;
				if (num != 0)
				{
				}
				num = (short)884998144;
				short num2 = num;
				num = (short)191279345;
				short num3 = num;
				num = (short)1777119473;
				switch (num3 == num)
				{
				}
				num = (short)749404160;
				if (num != 0)
				{
				}
				return this.emerTone_42046.Value;
			}
			set
			{
				short num = (short)973611005;
				short num2 = num;
				num = (short)1507663869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581449216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023737857;
				if (num != 0)
				{
				}
				num = (short)2049245184;
				if (num != 0)
				{
				}
				this.emerTone_42046.Value = value;
			}
		}

		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x009166F8 File Offset: 0x009148F8
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x009167B0 File Offset: 0x009149B0
		public string EmerTone_42046_UIValue
		{
			get
			{
				short num = (short)1342874593;
				short num2 = num;
				num = (short)329556961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647771648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801636353;
				if (num != 0)
				{
				}
				num = (short)1341849600;
				if (num != 0)
				{
				}
				return this.emerTone_42046.UIValue;
			}
			set
			{
				short num = (short)77287978;
				short num2 = num;
				num = (short)421089834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002962944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)890241025;
				if (num != 0)
				{
				}
				num = (short)702611456;
				if (num != 0)
				{
				}
				this.emerTone_42046.UIValue = value;
			}
		}

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x06009B34 RID: 39732 RVA: 0x00916864 File Offset: 0x00914A64
		public global::AcpBusinessLayer.AcpListField EmerTone_42046
		{
			get
			{
				short num = (short)1064285578;
				short num2 = num;
				num = (short)1173730698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)517013504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705312257;
				if (num != 0)
				{
				}
				num = (short)1952907264;
				if (num != 0)
				{
				}
				return this.emerTone_42046;
			}
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x00916918 File Offset: 0x00914B18
		// (set) Token: 0x06009B36 RID: 39734 RVA: 0x009169CC File Offset: 0x00914BCC
		public bool EmerTone_42046_Applicable
		{
			get
			{
				short num = (short)288206161;
				short num2 = num;
				num = (short)556510545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488898560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383727105;
				if (num != 0)
				{
				}
				num = (short)147849216;
				if (num != 0)
				{
				}
				return this.emerTone_42046.Applicable;
			}
			set
			{
				short num = (short)768483068;
				short num2 = num;
				num = (short)1269636860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2071855104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1807155201;
				if (num != 0)
				{
				}
				num = (short)1830813696;
				if (num != 0)
				{
				}
				this.emerTone_42046.Applicable = value;
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x06009B37 RID: 39735 RVA: 0x00916A84 File Offset: 0x00914C84
		// (set) Token: 0x06009B38 RID: 39736 RVA: 0x00916B38 File Offset: 0x00914D38
		public bool EmerTone_42046_Valid
		{
			get
			{
				short num = (short)2120744961;
				if (num != 0)
				{
				}
				num = (short)902692864;
				short num2 = num;
				num = (short)1896930998;
				short num3 = num;
				num = (short)1582554806;
				switch (num3 == num)
				{
				}
				num = (short)1113260032;
				if (num != 0)
				{
				}
				return this.emerTone_42046.Valid;
			}
			set
			{
				short num = (short)1410473910;
				short num2 = num;
				num = (short)805642166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970326016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35454976;
				if (num != 0)
				{
				}
				num = (short)701825025;
				if (num != 0)
				{
				}
				this.emerTone_42046.Valid = value;
			}
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x06009B39 RID: 39737 RVA: 0x00916BF0 File Offset: 0x00914DF0
		// (set) Token: 0x06009B3A RID: 39738 RVA: 0x00916CA4 File Offset: 0x00914EA4
		public bool EmerTone_42046_Visible
		{
			get
			{
				short num = (short)820873468;
				short num2 = num;
				num = (short)363759868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1890058240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)914423808;
				if (num != 0)
				{
				}
				num = (short)1822687233;
				if (num != 0)
				{
				}
				return this.emerTone_42046.Visible;
			}
			set
			{
				short num = (short)1402884232;
				short num2 = num;
				num = (short)1101746312;
				switch (num2 == num)
				{
				}
				num = (short)1879572481;
				if (num != 0)
				{
				}
				num = (short)723845120;
				short num3 = num;
				num = (short)1144455168;
				if (num != 0)
				{
				}
				this.emerTone_42046.Visible = value;
			}
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x00916D58 File Offset: 0x00914F58
		// (set) Token: 0x06009B3C RID: 39740 RVA: 0x00916E0C File Offset: 0x0091500C
		public bool EmerTone_42046_Editable
		{
			get
			{
				short num = (short)271503796;
				short num2 = num;
				num = (short)451072436;
				switch (num2 == num)
				{
				}
				num = (short)426115073;
				if (num != 0)
				{
				}
				num = (short)205193216;
				short num3 = num;
				num = (short)240058368;
				if (num != 0)
				{
				}
				return this.emerTone_42046.Editable;
			}
			set
			{
				short num = (short)419825664;
				short num2 = num;
				num = (short)1407322112;
				switch (num2 == num)
				{
				}
				num = (short)1138688001;
				if (num != 0)
				{
				}
				num = (short)515309568;
				short num3 = num;
				num = (short)1329201152;
				if (num != 0)
				{
				}
				this.emerTone_42046.Editable = value;
			}
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x00916EC0 File Offset: 0x009150C0
		internal string EmerTone_42046_UILabel
		{
			get
			{
				short num = (short)1098160119;
				short num2 = num;
				num = (short)411211767;
				switch (num2 == num)
				{
				}
				num = (short)1054343168;
				if (num != 0)
				{
				}
				num = (short)83034112;
				short num3 = num;
				num = (short)38535169;
				if (num != 0)
				{
				}
				return this.emerTone_42046.UIName;
			}
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x00916F7C File Offset: 0x0091517C
		// (set) Token: 0x06009B3F RID: 39743 RVA: 0x00917034 File Offset: 0x00915234
		internal bool EmerTone_42046_HiddenStatic
		{
			get
			{
				short num = (short)1174391788;
				short num2 = num;
				num = (short)483314668;
				switch (num2 == num)
				{
				}
				num = (short)1315635201;
				if (num != 0)
				{
				}
				num = (short)1492582400;
				short num3 = num;
				num = (short)1086980096;
				if (num != 0)
				{
				}
				return this.emerTone_42046.HiddenStatic;
			}
			set
			{
				short num = (short)209387521;
				if (num != 0)
				{
				}
				num = (short)330420532;
				short num2 = num;
				num = (short)551276852;
				switch (num2 == num)
				{
				}
				num = (short)71565312;
				short num3 = num;
				num = (short)1159725056;
				if (num != 0)
				{
				}
				this.emerTone_42046.HiddenStatic = value;
			}
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x06009B40 RID: 39744 RVA: 0x009170E8 File Offset: 0x009152E8
		// (set) Token: 0x06009B41 RID: 39745 RVA: 0x00917198 File Offset: 0x00915398
		internal bool EmerTone_42046_HiddenDynamic
		{
			get
			{
				short num = (short)800554904;
				short num2 = num;
				num = (short)1435729816;
				switch (num2 == num)
				{
				}
				num = (short)784662528;
				if (num != 0)
				{
				}
				num = (short)1625751552;
				short num3 = num;
				num = (short)851312641;
				if (num != 0)
				{
				}
				return this.emerTone_42046.HiddenDynamic;
			}
			set
			{
				short num = (short)1565589505;
				if (num != 0)
				{
				}
				num = (short)584388424;
				short num2 = num;
				num = (short)1480462152;
				switch (num2 == num)
				{
				}
				num = (short)1219821568;
				short num3 = num;
				num = (short)187301888;
				if (num != 0)
				{
				}
				this.emerTone_42046.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x06009B42 RID: 39746 RVA: 0x00917254 File Offset: 0x00915454
		public bool EmerTone_42046_HasDiffs
		{
			get
			{
				short num = (short)1831353242;
				short num2 = num;
				num = (short)1913338778;
				switch (num2 == num)
				{
				}
				num = (short)339083264;
				if (num != 0)
				{
				}
				num = (short)1789198336;
				short num3 = num;
				num = (short)339410945;
				if (num != 0)
				{
				}
				return this.emerTone_42046._HasDiffs;
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x00917308 File Offset: 0x00915508
		// (set) Token: 0x06009B44 RID: 39748 RVA: 0x009173BC File Offset: 0x009155BC
		public int EmerToneMinimumVolumn_42047Value
		{
			get
			{
				short num = (short)2109470095;
				short num2 = num;
				num = (short)912520591;
				switch (num2 == num)
				{
				}
				num = (short)892469249;
				if (num != 0)
				{
				}
				num = (short)365887488;
				short num3 = num;
				num = (short)428670976;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Value;
			}
			set
			{
				short num = (short)679679736;
				short num2 = num;
				num = (short)217913080;
				switch (num2 == num)
				{
				}
				num = (short)1127546881;
				if (num != 0)
				{
				}
				num = (short)1428946944;
				short num3 = num;
				num = (short)1163657216;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Value = value;
			}
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x06009B45 RID: 39749 RVA: 0x00917474 File Offset: 0x00915674
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerToneMinimumVolumn_42047
		{
			get
			{
				short num = (short)895338027;
				short num2 = num;
				num = (short)1006749227;
				switch (num2 == num)
				{
				}
				num = (short)440139777;
				if (num != 0)
				{
				}
				num = (short)197656576;
				short num3 = num;
				num = (short)1317732352;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047;
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x06009B46 RID: 39750 RVA: 0x00917524 File Offset: 0x00915724
		// (set) Token: 0x06009B47 RID: 39751 RVA: 0x009175D8 File Offset: 0x009157D8
		public string EmerToneMinimumVolumn_42047_UIValue
		{
			get
			{
				short num = (short)56727320;
				short num2 = num;
				num = (short)1972672280;
				switch (num2 == num)
				{
				}
				num = (short)1002045440;
				if (num != 0)
				{
				}
				num = (short)160825344;
				short num3 = num;
				num = (short)1085014017;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.UIValue;
			}
			set
			{
				short num = (short)1861940549;
				short num2 = num;
				num = (short)109049157;
				switch (num2 == num)
				{
				}
				num = (short)2005991425;
				if (num != 0)
				{
				}
				num = (short)282525696;
				short num3 = num;
				num = (short)1516765184;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.UIValue = value;
			}
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x06009B48 RID: 39752 RVA: 0x00917690 File Offset: 0x00915890
		// (set) Token: 0x06009B49 RID: 39753 RVA: 0x00917748 File Offset: 0x00915948
		internal int EmerToneMinimumVolumn_42047Min
		{
			get
			{
				short num = (short)1506817913;
				short num2 = num;
				num = (short)2125346681;
				switch (num2 == num)
				{
				}
				num = (short)998834176;
				if (num != 0)
				{
				}
				num = (short)1695481856;
				short num3 = num;
				num = (short)1225785345;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Min;
			}
			set
			{
				short num = (short)1087089109;
				short num2 = num;
				num = (short)1950394837;
				switch (num2 == num)
				{
				}
				num = (short)61997057;
				if (num != 0)
				{
				}
				num = (short)309723136;
				short num3 = num;
				num = (short)2035482624;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Min = value;
			}
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x06009B4A RID: 39754 RVA: 0x009177FC File Offset: 0x009159FC
		// (set) Token: 0x06009B4B RID: 39755 RVA: 0x009178B4 File Offset: 0x00915AB4
		internal int EmerToneMinimumVolumn_42047Max
		{
			get
			{
				short num = (short)926322107;
				short num2 = num;
				num = (short)1335070139;
				switch (num2 == num)
				{
				}
				num = (short)1217724417;
				if (num != 0)
				{
				}
				num = (short)1268908032;
				short num3 = num;
				num = (short)732102656;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Max;
			}
			set
			{
				short num = (short)1946373228;
				short num2 = num;
				num = (short)1268075628;
				switch (num2 == num)
				{
				}
				num = (short)226623489;
				if (num != 0)
				{
				}
				num = (short)534970368;
				short num3 = num;
				num = (short)1749745664;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Max = value;
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x06009B4C RID: 39756 RVA: 0x0091796C File Offset: 0x00915B6C
		// (set) Token: 0x06009B4D RID: 39757 RVA: 0x00917A20 File Offset: 0x00915C20
		internal int EmerToneMinimumVolumn_42047Step
		{
			get
			{
				short num = (short)669614524;
				short num2 = num;
				num = (short)1940160956;
				switch (num2 == num)
				{
				}
				num = (short)1452015616;
				if (num != 0)
				{
				}
				num = (short)770637824;
				short num3 = num;
				num = (short)1264254977;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.StepSize;
			}
			set
			{
				short num = (short)757677491;
				short num2 = num;
				num = (short)1118846387;
				switch (num2 == num)
				{
				}
				num = (short)995229697;
				if (num != 0)
				{
				}
				num = (short)1727987712;
				short num3 = num;
				num = (short)1840447488;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.StepSize = value;
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x06009B4E RID: 39758 RVA: 0x00917AD4 File Offset: 0x00915CD4
		// (set) Token: 0x06009B4F RID: 39759 RVA: 0x00917B88 File Offset: 0x00915D88
		public bool EmerToneMinimumVolumn_42047_Applicable
		{
			get
			{
				short num = (short)864109022;
				short num2 = num;
				num = (short)164839902;
				switch (num2 == num)
				{
				}
				num = (short)1828847617;
				if (num != 0)
				{
				}
				num = (short)1160970240;
				short num3 = num;
				num = (short)733413376;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Applicable;
			}
			set
			{
				short num = (short)430603718;
				short num2 = num;
				num = (short)831749574;
				switch (num2 == num)
				{
				}
				num = (short)1025114113;
				if (num != 0)
				{
				}
				num = (short)780861440;
				short num3 = num;
				num = (short)1283915776;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Applicable = value;
			}
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x06009B50 RID: 39760 RVA: 0x00917C3C File Offset: 0x00915E3C
		// (set) Token: 0x06009B51 RID: 39761 RVA: 0x00917CF0 File Offset: 0x00915EF0
		public bool EmerToneMinimumVolumn_42047_Valid
		{
			get
			{
				short num = (short)1333865295;
				short num2 = num;
				num = (short)1751853903;
				switch (num2 == num)
				{
				}
				num = (short)1405419521;
				if (num != 0)
				{
				}
				num = (short)1571422208;
				short num3 = num;
				num = (short)1530134528;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Valid;
			}
			set
			{
				short num = (short)649592833;
				if (num != 0)
				{
				}
				num = (short)1039190679;
				short num2 = num;
				num = (short)745327255;
				switch (num2 == num)
				{
				}
				num = (short)1155858432;
				short num3 = num;
				num = (short)1948516352;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Valid = value;
			}
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x06009B52 RID: 39762 RVA: 0x00917DA4 File Offset: 0x00915FA4
		// (set) Token: 0x06009B53 RID: 39763 RVA: 0x00917E58 File Offset: 0x00916058
		public bool EmerToneMinimumVolumn_42047_Visible
		{
			get
			{
				short num = (short)1671839109;
				short num2 = num;
				num = (short)2108112261;
				switch (num2 == num)
				{
				}
				num = (short)1549139969;
				if (num != 0)
				{
				}
				num = (short)495976448;
				short num3 = num;
				num = (short)1603665920;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Visible;
			}
			set
			{
				short num = (short)296120353;
				short num2 = num;
				num = (short)235302945;
				switch (num2 == num)
				{
				}
				num = (short)881328128;
				if (num != 0)
				{
				}
				num = (short)151977984;
				short num3 = num;
				num = (short)298254337;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Visible = value;
			}
		}

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x00917F0C File Offset: 0x0091610C
		// (set) Token: 0x06009B55 RID: 39765 RVA: 0x00917FC0 File Offset: 0x009161C0
		public bool EmerToneMinimumVolumn_42047_Editable
		{
			get
			{
				short num = (short)2107860161;
				short num2 = num;
				num = (short)1814127809;
				switch (num2 == num)
				{
				}
				num = (short)1681522689;
				if (num != 0)
				{
				}
				num = (short)764674048;
				short num3 = num;
				num = (short)1371471872;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.Editable;
			}
			set
			{
				short num = (short)417590102;
				short num2 = num;
				num = (short)1589242710;
				switch (num2 == num)
				{
				}
				num = (short)16646144;
				if (num != 0)
				{
				}
				num = (short)1512636416;
				short num3 = num;
				num = (short)1711144961;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.Editable = value;
			}
		}

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x06009B56 RID: 39766 RVA: 0x00918078 File Offset: 0x00916278
		internal string EmerToneMinimumVolumn_42047_UILabel
		{
			get
			{
				short num = (short)1369606842;
				short num2 = num;
				num = (short)1378454202;
				switch (num2 == num)
				{
				}
				num = (short)1626734593;
				if (num != 0)
				{
				}
				num = (short)1827078144;
				short num3 = num;
				num = (short)649068544;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.UIName;
			}
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x06009B57 RID: 39767 RVA: 0x00918128 File Offset: 0x00916328
		// (set) Token: 0x06009B58 RID: 39768 RVA: 0x009181E0 File Offset: 0x009163E0
		internal bool EmerToneMinimumVolumn_42047_HiddenStatic
		{
			get
			{
				short num = (short)426618114;
				short num2 = num;
				num = (short)560704770;
				switch (num2 == num)
				{
				}
				num = (short)2118385665;
				if (num != 0)
				{
				}
				num = (short)1967718400;
				short num3 = num;
				num = (short)1162477568;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.HiddenStatic;
			}
			set
			{
				short num = (short)1137470451;
				short num2 = num;
				num = (short)356805619;
				switch (num2 == num)
				{
				}
				num = (short)1043791872;
				if (num != 0)
				{
				}
				num = (short)1568473088;
				short num3 = num;
				num = (short)295829505;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.HiddenStatic = value;
			}
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x06009B59 RID: 39769 RVA: 0x00918298 File Offset: 0x00916498
		// (set) Token: 0x06009B5A RID: 39770 RVA: 0x00918350 File Offset: 0x00916550
		internal bool EmerToneMinimumVolumn_42047_HiddenDynamic
		{
			get
			{
				short num = (short)2002159228;
				short num2 = num;
				num = (short)837060220;
				switch (num2 == num)
				{
				}
				num = (short)1808138240;
				if (num != 0)
				{
				}
				num = (short)1092026368;
				short num3 = num;
				num = (short)1468006401;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047.HiddenDynamic;
			}
			set
			{
				short num = (short)1793522926;
				short num2 = num;
				num = (short)1035599086;
				switch (num2 == num)
				{
				}
				num = (short)1711079424;
				if (num != 0)
				{
				}
				num = (short)2027880448;
				short num3 = num;
				num = (short)1345388545;
				if (num != 0)
				{
				}
				this.emerToneMinimumVolumn_42047.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x06009B5B RID: 39771 RVA: 0x00918408 File Offset: 0x00916608
		public bool EmerToneMinimumVolumn_42047_HasDiffs
		{
			get
			{
				short num = (short)448357192;
				short num2 = num;
				num = (short)1603560264;
				switch (num2 == num)
				{
				}
				num = (short)465502209;
				if (num != 0)
				{
				}
				num = (short)118554624;
				short num3 = num;
				num = (short)589365248;
				if (num != 0)
				{
				}
				return this.emerToneMinimumVolumn_42047._HasDiffs;
			}
		}

		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x06009B5C RID: 39772 RVA: 0x009184BC File Offset: 0x009166BC
		// (set) Token: 0x06009B5D RID: 39773 RVA: 0x00918574 File Offset: 0x00916774
		public int EmerTonePeriodSec_42048Value
		{
			get
			{
				short num = (short)9983019;
				short num2 = num;
				num = (short)101667883;
				switch (num2 == num)
				{
				}
				num = (short)1651638272;
				if (num != 0)
				{
				}
				num = (short)1880096768;
				short num3 = num;
				num = (short)2081030145;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Value;
			}
			set
			{
				short num = (short)1853194162;
				short num2 = num;
				num = (short)881819570;
				switch (num2 == num)
				{
				}
				num = (short)1896480768;
				if (num != 0)
				{
				}
				num = (short)1630535680;
				short num3 = num;
				num = (short)145031169;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Value = value;
			}
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x0091862C File Offset: 0x0091682C
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerTonePeriodSec_42048
		{
			get
			{
				short num = (short)1987247239;
				short num2 = num;
				num = (short)1472593031;
				switch (num2 == num)
				{
				}
				num = (short)1257635841;
				if (num != 0)
				{
				}
				num = (short)1743585280;
				short num3 = num;
				num = (short)1342373888;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048;
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x009186D8 File Offset: 0x009168D8
		// (set) Token: 0x06009B60 RID: 39776 RVA: 0x0091878C File Offset: 0x0091698C
		public string EmerTonePeriodSec_42048_UIValue
		{
			get
			{
				short num = (short)1685468990;
				short num2 = num;
				num = (short)854931262;
				switch (num2 == num)
				{
				}
				num = (short)1224998913;
				if (num != 0)
				{
				}
				num = (short)945815552;
				short num3 = num;
				num = (short)390725632;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.UIValue;
			}
			set
			{
				short num = (short)1616168991;
				short num2 = num;
				num = (short)401655839;
				switch (num2 == num)
				{
				}
				num = (short)972029952;
				if (num != 0)
				{
				}
				num = (short)405471232;
				short num3 = num;
				num = (short)1578106881;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.UIValue = value;
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x00918848 File Offset: 0x00916A48
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x009188FC File Offset: 0x00916AFC
		internal int EmerTonePeriodSec_42048Min
		{
			get
			{
				short num = (short)310260139;
				short num2 = num;
				num = (short)1111765419;
				switch (num2 == num)
				{
				}
				num = (short)1901264897;
				if (num != 0)
				{
				}
				num = (short)266469376;
				short num3 = num;
				num = (short)319946752;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Min;
			}
			set
			{
				short num = (short)1531119019;
				short num2 = num;
				num = (short)259130795;
				switch (num2 == num)
				{
				}
				num = (short)847249409;
				if (num != 0)
				{
				}
				num = (short)283312128;
				short num3 = num;
				num = (short)1712259072;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Min = value;
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x009189B4 File Offset: 0x00916BB4
		// (set) Token: 0x06009B64 RID: 39780 RVA: 0x00918A68 File Offset: 0x00916C68
		internal int EmerTonePeriodSec_42048Max
		{
			get
			{
				short num = (short)573893871;
				short num2 = num;
				num = (short)899345647;
				switch (num2 == num)
				{
				}
				num = (short)159776769;
				if (num != 0)
				{
				}
				num = (short)136445952;
				short num3 = num;
				num = (short)570556416;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Max;
			}
			set
			{
				short num = (short)2129054488;
				short num2 = num;
				num = (short)602524440;
				switch (num2 == num)
				{
				}
				num = (short)314572801;
				if (num != 0)
				{
				}
				num = (short)1248854016;
				short num3 = num;
				num = (short)116523008;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Max = value;
			}
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x00918B1C File Offset: 0x00916D1C
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x00918BD0 File Offset: 0x00916DD0
		internal int EmerTonePeriodSec_42048Step
		{
			get
			{
				short num = (short)1861345365;
				short num2 = num;
				num = (short)340451413;
				switch (num2 == num)
				{
				}
				num = (short)1821573120;
				if (num != 0)
				{
				}
				num = (short)2120482816;
				short num3 = num;
				num = (short)1411514369;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.StepSize;
			}
			set
			{
				short num = (short)622581480;
				short num2 = num;
				num = (short)1908725480;
				switch (num2 == num)
				{
				}
				num = (short)1624309760;
				if (num != 0)
				{
				}
				num = (short)1500512256;
				short num3 = num;
				num = (short)222101505;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.StepSize = value;
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x00918C84 File Offset: 0x00916E84
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x00918D38 File Offset: 0x00916F38
		public bool EmerTonePeriodSec_42048_Applicable
		{
			get
			{
				short num = (short)76278470;
				short num2 = num;
				num = (short)38333126;
				switch (num2 == num)
				{
				}
				num = (short)887619585;
				if (num != 0)
				{
				}
				num = (short)693370880;
				short num3 = num;
				num = (short)1838874624;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Applicable;
			}
			set
			{
				short num = (short)807110884;
				short num2 = num;
				num = (short)746096868;
				switch (num2 == num)
				{
				}
				num = (short)429981697;
				if (num != 0)
				{
				}
				num = (short)812908544;
				short num3 = num;
				num = (short)2062024704;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Applicable = value;
			}
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x00918DEC File Offset: 0x00916FEC
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x00918EA0 File Offset: 0x009170A0
		public bool EmerTonePeriodSec_42048_Valid
		{
			get
			{
				short num = (short)1401269916;
				short num2 = num;
				num = (short)775859868;
				switch (num2 == num)
				{
				}
				num = (short)30081024;
				if (num != 0)
				{
				}
				num = (short)1507786752;
				short num3 = num;
				num = (short)46727169;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Valid;
			}
			set
			{
				short num = (short)72817328;
				short num2 = num;
				num = (short)1871977136;
				switch (num2 == num)
				{
				}
				num = (short)1059651585;
				if (num != 0)
				{
				}
				num = (short)1972764672;
				short num3 = num;
				num = (short)1608056832;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Valid = value;
			}
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x00918F58 File Offset: 0x00917158
		// (set) Token: 0x06009B6C RID: 39788 RVA: 0x0091900C File Offset: 0x0091720C
		public bool EmerTonePeriodSec_42048_Visible
		{
			get
			{
				short num = (short)44501941;
				short num2 = num;
				num = (short)250219445;
				switch (num2 == num)
				{
				}
				num = (short)370606080;
				if (num != 0)
				{
				}
				num = (short)1147666432;
				short num3 = num;
				num = (short)1896677377;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Visible;
			}
			set
			{
				short num = (short)151977985;
				if (num != 0)
				{
				}
				num = (short)1534730134;
				short num2 = num;
				num = (short)1176903574;
				switch (num2 == num)
				{
				}
				num = (short)1498939392;
				short num3 = num;
				num = (short)141557760;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Visible = value;
			}
		}

		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x009190C0 File Offset: 0x009172C0
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x00919174 File Offset: 0x00917374
		public bool EmerTonePeriodSec_42048_Editable
		{
			get
			{
				short num = (short)343265935;
				short num2 = num;
				num = (short)2088555151;
				switch (num2 == num)
				{
				}
				num = (short)1942421504;
				if (num != 0)
				{
				}
				num = (short)1867710464;
				short num3 = num;
				num = (short)102760449;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.Editable;
			}
			set
			{
				short num = (short)181731329;
				if (num != 0)
				{
				}
				num = (short)836066554;
				short num2 = num;
				num = (short)513170682;
				switch (num2 == num)
				{
				}
				num = (short)340656128;
				short num3 = num;
				num = (short)1514405888;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.Editable = value;
			}
		}

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x00919228 File Offset: 0x00917428
		internal string EmerTonePeriodSec_42048_UILabel
		{
			get
			{
				short num = (short)1316545027;
				short num2 = num;
				num = (short)1915740675;
				switch (num2 == num)
				{
				}
				num = (short)1780088832;
				if (num != 0)
				{
				}
				num = (short)589824000;
				short num3 = num;
				num = (short)1510146049;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.UIName;
			}
		}

		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06009B70 RID: 39792 RVA: 0x009192DC File Offset: 0x009174DC
		// (set) Token: 0x06009B71 RID: 39793 RVA: 0x00919390 File Offset: 0x00917590
		internal bool EmerTonePeriodSec_42048_HiddenStatic
		{
			get
			{
				short num = (short)1895909149;
				short num2 = num;
				num = (short)1825261341;
				switch (num2 == num)
				{
				}
				num = (short)1332871169;
				if (num != 0)
				{
				}
				num = (short)1918500864;
				short num3 = num;
				num = (short)1267728384;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.HiddenStatic;
			}
			set
			{
				short num = (short)2036269057;
				if (num != 0)
				{
				}
				num = (short)931517122;
				short num2 = num;
				num = (short)768594626;
				switch (num2 == num)
				{
				}
				num = (short)944439296;
				short num3 = num;
				num = (short)163315712;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.HiddenStatic = value;
			}
		}

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x06009B72 RID: 39794 RVA: 0x00919444 File Offset: 0x00917644
		// (set) Token: 0x06009B73 RID: 39795 RVA: 0x009194FC File Offset: 0x009176FC
		internal bool EmerTonePeriodSec_42048_HiddenDynamic
		{
			get
			{
				short num = (short)653459457;
				if (num != 0)
				{
				}
				num = (short)1828628068;
				short num2 = num;
				num = (short)150251108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250361344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224395264;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048.HiddenDynamic;
			}
			set
			{
				short num = (short)2037071209;
				short num2 = num;
				num = (short)1964981609;
				switch (num2 == num)
				{
				}
				num = (short)989462528;
				short num3 = num;
				num = (short)763232257;
				if (num != 0)
				{
				}
				num = (short)1351745536;
				if (num != 0)
				{
				}
				this.emerTonePeriodSec_42048.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x06009B74 RID: 39796 RVA: 0x009195B8 File Offset: 0x009177B8
		public bool EmerTonePeriodSec_42048_HasDiffs
		{
			get
			{
				short num = (short)1278302834;
				short num2 = num;
				num = (short)13458034;
				switch (num2 == num)
				{
				}
				num = (short)333381632;
				short num3 = num;
				num = (short)1401749505;
				if (num != 0)
				{
				}
				num = (short)1457520640;
				if (num != 0)
				{
				}
				return this.emerTonePeriodSec_42048._HasDiffs;
			}
		}

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x06009B75 RID: 39797 RVA: 0x00919670 File Offset: 0x00917870
		// (set) Token: 0x06009B76 RID: 39798 RVA: 0x00919724 File Offset: 0x00917924
		public int EmerAudioRouting_42049Value
		{
			get
			{
				short num = (short)1038638027;
				short num2 = num;
				num = (short)2008243147;
				switch (num2 == num)
				{
				}
				num = (short)1409220608;
				short num3 = num;
				num = (short)1984299009;
				if (num != 0)
				{
				}
				num = (short)411828224;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.Value;
			}
			set
			{
				short num = (short)1933274227;
				short num2 = num;
				num = (short)1968073843;
				switch (num2 == num)
				{
				}
				num = (short)1338966016;
				short num3 = num;
				num = (short)1344733184;
				if (num != 0)
				{
				}
				num = (short)1027538945;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.Value = value;
			}
		}

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x009197D8 File Offset: 0x009179D8
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x00919890 File Offset: 0x00917A90
		public string EmerAudioRouting_42049_UIValue
		{
			get
			{
				short num = (short)1657574466;
				short num2 = num;
				num = (short)1298568258;
				switch (num2 == num)
				{
				}
				num = (short)1024983040;
				short num3 = num;
				num = (short)1485242369;
				if (num != 0)
				{
				}
				num = (short)922288128;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.UIValue;
			}
			set
			{
				short num = (short)946242701;
				short num2 = num;
				num = (short)937460877;
				switch (num2 == num)
				{
				}
				num = (short)1611857920;
				short num3 = num;
				num = (short)1970274304;
				if (num != 0)
				{
				}
				num = (short)560922625;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.UIValue = value;
			}
		}

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x00919948 File Offset: 0x00917B48
		public global::AcpBusinessLayer.AcpListField EmerAudioRouting_42049
		{
			get
			{
				short num = (short)2135264920;
				short num2 = num;
				num = (short)1874431640;
				switch (num2 == num)
				{
				}
				num = (short)382468096;
				short num3 = num;
				num = (short)1634861057;
				if (num != 0)
				{
				}
				num = (short)1111293952;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049;
			}
		}

		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x009199F4 File Offset: 0x00917BF4
		// (set) Token: 0x06009B7B RID: 39803 RVA: 0x00919AAC File Offset: 0x00917CAC
		public bool EmerAudioRouting_42049_Applicable
		{
			get
			{
				short num = (short)1143769499;
				short num2 = num;
				num = (short)624724379;
				switch (num2 == num)
				{
				}
				num = (short)65273856;
				short num3 = num;
				num = (short)916127745;
				if (num != 0)
				{
				}
				num = (short)1275723776;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.Applicable;
			}
			set
			{
				short num = (short)383225979;
				short num2 = num;
				num = (short)860459131;
				switch (num2 == num)
				{
				}
				num = (short)1358561280;
				short num3 = num;
				num = (short)1153957889;
				if (num != 0)
				{
				}
				num = (short)1529544704;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.Applicable = value;
			}
		}

		// Token: 0x17004E02 RID: 19970
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x00919B60 File Offset: 0x00917D60
		// (set) Token: 0x06009B7D RID: 39805 RVA: 0x00919C18 File Offset: 0x00917E18
		public bool EmerAudioRouting_42049_Valid
		{
			get
			{
				short num = (short)84527420;
				short num2 = num;
				num = (short)1314769212;
				switch (num2 == num)
				{
				}
				num = (short)580845568;
				short num3 = num;
				num = (short)1486880769;
				if (num != 0)
				{
				}
				num = (short)1929314304;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.Valid;
			}
			set
			{
				short num = (short)1773024208;
				short num2 = num;
				num = (short)1491022800;
				switch (num2 == num)
				{
				}
				num = (short)2112028672;
				short num3 = num;
				num = (short)1507131393;
				if (num != 0)
				{
				}
				num = (short)2098593792;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.Valid = value;
			}
		}

		// Token: 0x17004E03 RID: 19971
		// (get) Token: 0x06009B7E RID: 39806 RVA: 0x00919CD0 File Offset: 0x00917ED0
		// (set) Token: 0x06009B7F RID: 39807 RVA: 0x00919D88 File Offset: 0x00917F88
		public bool EmerAudioRouting_42049_Visible
		{
			get
			{
				short num = (short)1868734745;
				short num2 = num;
				num = (short)2001772825;
				switch (num2 == num)
				{
				}
				num = (short)1551761408;
				short num3 = num;
				num = (short)398458881;
				if (num != 0)
				{
				}
				num = (short)1054146560;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.Visible;
			}
			set
			{
				short num = (short)441366471;
				short num2 = num;
				num = (short)775665607;
				switch (num2 == num)
				{
				}
				num = (short)644874240;
				short num3 = num;
				num = (short)1379074048;
				if (num != 0)
				{
				}
				num = (short)1430585345;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.Visible = value;
			}
		}

		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06009B80 RID: 39808 RVA: 0x00919E40 File Offset: 0x00918040
		// (set) Token: 0x06009B81 RID: 39809 RVA: 0x00919EF4 File Offset: 0x009180F4
		public bool EmerAudioRouting_42049_Editable
		{
			get
			{
				short num = (short)1888092161;
				if (num != 0)
				{
				}
				num = (short)1501211982;
				short num2 = num;
				num = (short)2001120590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554776064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188874752;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.Editable;
			}
			set
			{
				short num = (short)1061574269;
				short num2 = num;
				num = (short)897799805;
				switch (num2 == num)
				{
				}
				num = (short)1559887872;
				short num3 = num;
				num = (short)139657216;
				if (num != 0)
				{
				}
				num = (short)1248067585;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.Editable = value;
			}
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06009B82 RID: 39810 RVA: 0x00919FAC File Offset: 0x009181AC
		internal string EmerAudioRouting_42049_UILabel
		{
			get
			{
				short num = (short)19039308;
				short num2 = num;
				num = (short)368936012;
				switch (num2 == num)
				{
				}
				num = (short)398196736;
				short num3 = num;
				num = (short)1534984193;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.UIName;
			}
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x0091A064 File Offset: 0x00918264
		// (set) Token: 0x06009B84 RID: 39812 RVA: 0x0091A118 File Offset: 0x00918318
		internal bool EmerAudioRouting_42049_HiddenStatic
		{
			get
			{
				short num = (short)346837008;
				short num2 = num;
				num = (short)1337937936;
				switch (num2 == num)
				{
				}
				num = (short)178716672;
				short num3 = num;
				num = (short)1197277185;
				if (num != 0)
				{
				}
				num = (short)152633344;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.HiddenStatic;
			}
			set
			{
				short num = (short)129710088;
				short num2 = num;
				num = (short)861485064;
				switch (num2 == num)
				{
				}
				num = (short)1805910016;
				short num3 = num;
				num = (short)73138176;
				if (num != 0)
				{
				}
				num = (short)1081933825;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.HiddenStatic = value;
			}
		}

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x06009B85 RID: 39813 RVA: 0x0091A1D0 File Offset: 0x009183D0
		// (set) Token: 0x06009B86 RID: 39814 RVA: 0x0091A284 File Offset: 0x00918484
		internal bool EmerAudioRouting_42049_HiddenDynamic
		{
			get
			{
				short num = (short)893867246;
				short num2 = num;
				num = (short)856970478;
				switch (num2 == num)
				{
				}
				num = (short)1558118400;
				short num3 = num;
				num = (short)107347969;
				if (num != 0)
				{
				}
				num = (short)1000407040;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049.HiddenDynamic;
			}
			set
			{
				short num = (short)1396814510;
				short num2 = num;
				num = (short)1011856046;
				switch (num2 == num)
				{
				}
				num = (short)579796992;
				short num3 = num;
				num = (short)211353600;
				if (num != 0)
				{
				}
				num = (short)843579393;
				if (num != 0)
				{
				}
				this.emerAudioRouting_42049.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x0091A338 File Offset: 0x00918538
		public bool EmerAudioRouting_42049_HasDiffs
		{
			get
			{
				short num = (short)945310457;
				short num2 = num;
				num = (short)459623161;
				switch (num2 == num)
				{
				}
				num = (short)54067200;
				short num3 = num;
				num = (short)2061041665;
				if (num != 0)
				{
				}
				num = (short)2031484928;
				if (num != 0)
				{
				}
				return this.emerAudioRouting_42049._HasDiffs;
			}
		}

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x06009B88 RID: 39816 RVA: 0x0091A3EC File Offset: 0x009185EC
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1252324270;
				short num2 = num;
				num = (short)1429271470;
				switch (num2 == num)
				{
				}
				num = (short)373686272;
				short num3 = num;
				num = (short)674103297;
				if (num != 0)
				{
				}
				num = (short)602537984;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0091A4AC File Offset: 0x009186AC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1367736320;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_11C;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)33947651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11C;
				case 2:
					num = (short)193789953;
					if (num != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1349386240;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)684195844;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					IL_CB:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)27131906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11C;
				}
				goto IL_4D;
				IL_11C:
				num = (short)997610175;
				short num4 = num;
				num = (short)432296639;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CB;
				default:
					goto IL_152;
				}
			}
			IL_152:
			num = (short)1799553024;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = null;
			num = (short)254738433;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04004CF8 RID: 19704
		private global::AcpBusinessLayer.AcpListField emergencyToneTrigger_42045;

		// Token: 0x04004CF9 RID: 19705
		private global::AcpBusinessLayer.AcpListField emerTone_42046;

		// Token: 0x04004CFA RID: 19706
		private global::AcpBusinessLayer.AcpSimpleRangeField emerToneMinimumVolumn_42047;

		// Token: 0x04004CFB RID: 19707
		private global::AcpBusinessLayer.AcpSimpleRangeField emerTonePeriodSec_42048;

		// Token: 0x04004CFC RID: 19708
		private global::AcpBusinessLayer.AcpListField emerAudioRouting_42049;
	}
}
