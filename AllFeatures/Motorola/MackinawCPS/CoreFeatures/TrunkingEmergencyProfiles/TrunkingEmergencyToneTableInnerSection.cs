using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x02000482 RID: 1154
	[global::System.Serializable]
	public class TrunkingEmergencyToneTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060097F6 RID: 38902 RVA: 0x008EA4D0 File Offset: 0x008E86D0
		public TrunkingEmergencyToneTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x008EA4EC File Offset: 0x008E86EC
		protected TrunkingEmergencyToneTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x008EA504 File Offset: 0x008E8704
		public override void Init()
		{
			int a_ = 2;
			short num = (short)72131487;
			short num2 = num;
			num = (short)1641063327;
			switch (num2 == num)
			{
			}
			num = (short)458883073;
			if (num != 0)
			{
			}
			num = (short)1460338688;
			short num3 = num;
			num = (short)1026359296;
			if (num != 0)
			{
			}
			this.emergencyToneTrigger_42107 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("蛂꣄ꋆ믈곊꣌ꇎ닐꫒臔룖럘뻚觜귞裠蓢苤苦鯨듪\ud9ec\uddee샰쏲싴", a_), global::CommonResources.AcgResources.ID_TRIGGER, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.EmergencyToneTrigger_42107LovStrs);
			this.emergencyToneTrigger_42107.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.emergencyToneTrigger_42107.DataTransferOrder = 19;
			this.trkEmerTone_42108 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韂럄곆賈ꛊ꣌뷎藐볒믔닖蛘퇠\udbe2", a_), global::CommonResources.AcgResources.ID_TONE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerTone_42108LovStrs);
			this.trkEmerTone_42108.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerTone_42108.DataTransferOrder = 20;
			this.trkEmerToneMinimumVolume_42109 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("韂럄곆賈ꛊ꣌뷎藐볒믔닖铘닚돜뛞賠離裤뇦蛨蟪飬苮铰곲쇴엶죸쯺쓼", a_), global::CommonResources.AcgResources.ID_TONEMINIMUMVOLUME, 0, 255, null, null, 0, 1);
			this.trkEmerToneMinimumVolume_42109.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerToneMinimumVolume_42109.DataTransferOrder = 21;
			this.trkEmerToneMinimumVolume_42109.ShowHexValue = false;
			this.trkEmerTonePeriodSec_42110 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("韂럄곆賈ꛊ꣌뷎藐볒믔닖觘뻚꿜뛞軠蟢뛤苦諨듪\ud9ec\uddee샰싲열", a_), global::CommonResources.AcgResources.ID_TONEPERIODSEC, 0, 255, global::CommonResources.AcgResources.ID_ONCE, null, 0, 1);
			this.trkEmerTonePeriodSec_42110.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerTonePeriodSec_42110.DataTransferOrder = 22;
			this.trkEmerTonePeriodSec_42110.ShowHexValue = false;
			this.trkEmerAudioRouting_42111 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韂럄곆賈ꛊ꣌뷎郐ꛒ뇔뻖뛘觚닜꫞闠諢诤胦뛨\udfea\udfec\udeee샰싲", a_), global::CommonResources.AcgResources.ID_AUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerAudioRouting_42111LovStrs);
			this.trkEmerAudioRouting_42111.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerAudioRouting_42111.DataTransferOrder = 23;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛂꣄ꋆ믈곊꣌ꇎ닐꫒菖뛘뗚룜￞뗠苢蟤详賨", a_);
			base.Id = 10776;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x008EA74C File Offset: 0x008E894C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1208221696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1466230875;
				short num3 = num;
				num = (short)897443931;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)482476032;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_C7;
						}
						continue;
					case 1:
						this.trkEmerToneMinimumVolume_42109 = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜鋞裠跢賤諦鳨蛪믬胮鷰蛲飴鋶꛸쿺쿼컾㄀㨂", a_), global::CommonResources.AcgResources.ID_TONEMINIMUMVOLUME, null, null, 0, 1);
						this.trkEmerToneMinimumVolume_42109.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkEmerToneMinimumVolume_42109.DataTransferOrder = 21;
						this.trkEmerToneMinimumVolume_42109.ShowHexValue = false;
						num = (short)388759566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔雖곘뿚드냞돠賢郤鏦胨藪諬냮연쇲쓴웶죸", a_)))
						{
							num = (short)1009778699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D6;
					case 3:
						goto IL_342;
					case 4:
						num = (short)1040056337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_165;
					case 6:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜胞헠퇢퓤ퟦ퇨", a_)))
						{
							num = (short)2133458954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					case 7:
					{
						num = (short)195362816;
						short num4 = num;
						goto IL_489;
					}
					case 8:
						num = (short)482279425;
						if (num != 0)
						{
						}
						this.trkEmerTonePeriodSec_42110 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜连蓠釢賤裦跨룪裬賮껰쟲쟴웶죸쯺", a_), global::CommonResources.AcgResources.ID_TONEPERIODSEC, global::CommonResources.AcgResources.ID_ONCE, null, 0, 1);
						this.trkEmerTonePeriodSec_42110.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkEmerTonePeriodSec_42110.DataTransferOrder = 22;
						this.trkEmerTonePeriodSec_42110.ShowHexValue = false;
						num = (short)899219465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1FD;
					case 10:
						this.trkEmerTone_42108 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜胞헠퇢퓤ퟦ퇨", a_), global::CommonResources.AcgResources.ID_TONE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerTone_42108LovStrs);
						this.trkEmerTone_42108.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkEmerTone_42108.DataTransferOrder = 20;
						num = (short)949026821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						this.trkEmerAudioRouting_42111 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔雖곘뿚드냞돠賢郤鏦胨藪諬냮연쇲쓴웶죸", a_), global::CommonResources.AcgResources.ID_AUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerAudioRouting_42111LovStrs);
						this.trkEmerAudioRouting_42111.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkEmerAudioRouting_42111.DataTransferOrder = 23;
						num = (short)444530691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜鋞裠跢賤諦鳨蛪믬胮鷰蛲飴鋶꛸쿺쿼컾㄀㨂", a_)))
						{
							goto IL_195;
						}
						goto IL_EF;
					case 13:
						this.emergencyToneTrigger_42107 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ迚닜뇞蓠럢韤軦軨質裬鷮껰쟲쟴웶째쳺", a_), global::CommonResources.AcgResources.ID_TRIGGER, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.EmergencyToneTrigger_42107LovStrs);
						this.emergencyToneTrigger_42107.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.emergencyToneTrigger_42107.DataTransferOrder = 19;
						num = (short)259194887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_EF;
					case 15:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ諎볐뛒꟔菖뛘뗚룜连蓠釢賤裦跨룪裬賮껰쟲쟴웶죸쯺", a_)))
						{
							num = (short)1025376264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD;
					case 16:
						num = (short)1074397202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ迚닜뇞蓠럢韤軦軨質裬鷮껰쟲쟴웶째쳺", a_)))
						{
							num = (short)608567309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_489;
					case 18:
						if (producerFields != null)
						{
							num = (short)1338507268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D6;
					}
					IL_C7:
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)947781648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D6;
					IL_EF:
					num = (short)2002583567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165:
					num = (short)1358102540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					num = (short)777388034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					num = (short)1353318406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_195:
				num = (short)1097793537;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_342:
			IL_4D6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘﯚ觜냞迠蛢엤돦裨觪臬諮", a_);
			base.Id = 10776;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x008EAC60 File Offset: 0x008E8E60
		public override void PopulateReferences()
		{
			short num = (short)1235181159;
			short num2 = num;
			num = (short)106520167;
			switch (num2 == num)
			{
			}
			num = (short)1716518913;
			if (num != 0)
			{
			}
			num = (short)714997760;
			short num3 = num;
			num = (short)1384841216;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x008EAD0C File Offset: 0x008E8F0C
		public override void DropReferences()
		{
			short num = (short)235732993;
			if (num != 0)
			{
			}
			num = (short)898208780;
			short num2 = num;
			num = (short)617976844;
			switch (num2 == num)
			{
			}
			num = (short)1474232320;
			short num3 = num;
			num = (short)613613568;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x008EADB8 File Offset: 0x008E8FB8
		public override void SetConstraints()
		{
			short num = (short)954743733;
			short num2 = num;
			num = (short)334511029;
			switch (num2 == num)
			{
			}
			num = (short)1351090176;
			if (num != 0)
			{
			}
			num = (short)1806237696;
			short num3 = num;
			num = (short)1980694529;
			if (num != 0)
			{
			}
			this.emergencyToneTrigger_42107.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conTriggedByManDownEnabled);
			this.trkEmerTone_42108.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conTriggedByManDownEnabled);
			this.trkEmerToneMinimumVolume_42109.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConTrkLegacyToneNotSelected);
			this.trkEmerTonePeriodSec_42110.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConTrkLegacyToneNotSelected);
			this.trkEmerTonePeriodSec_42110.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conTrkEmerPrfTonePeriodInvalid);
			this.trkEmerAudioRouting_42111.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conTrkAudioRoutingIsApplicable);
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x008EAEE8 File Offset: 0x008E90E8
		public override void SetupDependencies()
		{
			short num = (short)786819781;
			short num2 = num;
			num = (short)1113057989;
			switch (num2 == num)
			{
			}
			num = (short)1032847360;
			short num3 = num;
			num = (short)781713408;
			if (num != 0)
			{
			}
			num = (short)320077825;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.emergencyToneTrigger_42107);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.emergencyToneTrigger_42107);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.emergencyToneTrigger_42107);
			trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392.AddDependentObject(this.emergencyToneTrigger_42107);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emergencyToneTrigger_42107);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.trkEmerTone_42108);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.trkEmerTone_42108);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.trkEmerTone_42108);
			trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392.AddDependentObject(this.trkEmerTone_42108);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.trkEmerTone_42108);
			this.trkEmerTone_42108.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.trkEmerToneMinimumVolume_42109);
			this.trkEmerTone_42108.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.trkEmerTonePeriodSec_42110);
			this.trkEmerTone_42108.AddDependentObject(this.trkEmerAudioRouting_42111);
			this.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.trkEmerAudioRouting_42111);
			this.trkEmerTonePeriodSec_42110.AddDependentObject(this.trkEmerAudioRouting_42111);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.trkEmerAudioRouting_42111);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.trkEmerAudioRouting_42111);
		}

		// Token: 0x17004C4F RID: 19535
		// (get) Token: 0x060097FE RID: 38910 RVA: 0x008EB25C File Offset: 0x008E945C
		public bool HasDiffs
		{
			get
			{
				short num = (short)493223937;
				if (num != 0)
				{
				}
				num = (short)1754650475;
				short num2 = num;
				num = (short)1418712939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386414080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2121531392;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x060097FF RID: 38911 RVA: 0x008EB310 File Offset: 0x008E9510
		// (set) Token: 0x06009800 RID: 38912 RVA: 0x008EB3C8 File Offset: 0x008E95C8
		public int EmergencyToneTrigger_42107Value
		{
			get
			{
				short num = (short)477489709;
				short num2 = num;
				num = (short)1235937837;
				switch (num2 == num)
				{
				}
				num = (short)260374528;
				short num3 = num;
				num = (short)1884356609;
				if (num != 0)
				{
				}
				num = (short)347799552;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.Value;
			}
			set
			{
				short num = (short)1746297944;
				short num2 = num;
				num = (short)1071408216;
				switch (num2 == num)
				{
				}
				num = (short)1266417664;
				short num3 = num;
				num = (short)1360265216;
				if (num != 0)
				{
				}
				num = (short)1405288449;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.Value = value;
			}
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x06009801 RID: 38913 RVA: 0x008EB480 File Offset: 0x008E9680
		// (set) Token: 0x06009802 RID: 38914 RVA: 0x008EB534 File Offset: 0x008E9734
		public string EmergencyToneTrigger_42107_UIValue
		{
			get
			{
				short num = (short)1553833958;
				short num2 = num;
				num = (short)894738406;
				switch (num2 == num)
				{
				}
				num = (short)349241344;
				short num3 = num;
				num = (short)2083651584;
				if (num != 0)
				{
				}
				num = (short)1176502273;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.UIValue;
			}
			set
			{
				short num = (short)1367153352;
				short num2 = num;
				num = (short)2125208264;
				switch (num2 == num)
				{
				}
				num = (short)764870656;
				short num3 = num;
				num = (short)622723073;
				if (num != 0)
				{
				}
				num = (short)1759641600;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.UIValue = value;
			}
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x008EB5E8 File Offset: 0x008E97E8
		public global::AcpBusinessLayer.AcpListField EmergencyToneTrigger_42107
		{
			get
			{
				short num = (short)821136938;
				short num2 = num;
				num = (short)823758378;
				switch (num2 == num)
				{
				}
				num = (short)255131648;
				short num3 = num;
				num = (short)364445697;
				if (num != 0)
				{
				}
				num = (short)895156224;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107;
			}
		}

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x008EB698 File Offset: 0x008E9898
		// (set) Token: 0x06009805 RID: 38917 RVA: 0x008EB750 File Offset: 0x008E9950
		public bool EmergencyToneTrigger_42107_Applicable
		{
			get
			{
				short num = (short)1187942802;
				short num2 = num;
				num = (short)1508938130;
				switch (num2 == num)
				{
				}
				num = (short)1683881984;
				short num3 = num;
				num = (short)844627969;
				if (num != 0)
				{
				}
				num = (short)145883136;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.Applicable;
			}
			set
			{
				short num = (short)550009977;
				short num2 = num;
				num = (short)251952249;
				switch (num2 == num)
				{
				}
				num = (short)1555562496;
				short num3 = num;
				num = (short)453640192;
				if (num != 0)
				{
				}
				num = (short)1000996865;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.Applicable = value;
			}
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x06009806 RID: 38918 RVA: 0x008EB808 File Offset: 0x008E9A08
		// (set) Token: 0x06009807 RID: 38919 RVA: 0x008EB8BC File Offset: 0x008E9ABC
		public bool EmergencyToneTrigger_42107_Valid
		{
			get
			{
				short num = (short)361742666;
				short num2 = num;
				num = (short)549830986;
				switch (num2 == num)
				{
				}
				num = (short)262864896;
				short num3 = num;
				num = (short)109772801;
				if (num != 0)
				{
				}
				num = (short)542638080;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.Valid;
			}
			set
			{
				short num = (short)214699140;
				short num2 = num;
				num = (short)1360727172;
				switch (num2 == num)
				{
				}
				num = (short)180092928;
				short num3 = num;
				num = (short)233046017;
				if (num != 0)
				{
				}
				num = (short)423493632;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.Valid = value;
			}
		}

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x06009808 RID: 38920 RVA: 0x008EB974 File Offset: 0x008E9B74
		// (set) Token: 0x06009809 RID: 38921 RVA: 0x008EBA28 File Offset: 0x008E9C28
		public bool EmergencyToneTrigger_42107_Visible
		{
			get
			{
				short num = (short)1959422839;
				short num2 = num;
				num = (short)902327159;
				switch (num2 == num)
				{
				}
				num = (short)15007744;
				short num3 = num;
				num = (short)788660225;
				if (num != 0)
				{
				}
				num = (short)856555520;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.Visible;
			}
			set
			{
				short num = (short)303162981;
				short num2 = num;
				num = (short)1513743973;
				switch (num2 == num)
				{
				}
				num = (short)1979777024;
				short num3 = num;
				num = (short)1263730688;
				if (num != 0)
				{
				}
				num = (short)1339162625;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.Visible = value;
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x0600980A RID: 38922 RVA: 0x008EBADC File Offset: 0x008E9CDC
		// (set) Token: 0x0600980B RID: 38923 RVA: 0x008EBB8C File Offset: 0x008E9D8C
		public bool EmergencyToneTrigger_42107_Editable
		{
			get
			{
				short num = (short)901796966;
				short num2 = num;
				num = (short)154293350;
				switch (num2 == num)
				{
				}
				num = (short)1035141120;
				short num3 = num;
				num = (short)1567096833;
				if (num != 0)
				{
				}
				num = (short)1121386496;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.Editable;
			}
			set
			{
				short num = (short)253041054;
				short num2 = num;
				num = (short)663165342;
				switch (num2 == num)
				{
				}
				num = (short)1437794304;
				short num3 = num;
				num = (short)2065891329;
				if (num != 0)
				{
				}
				num = (short)232652800;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.Editable = value;
			}
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x0600980C RID: 38924 RVA: 0x008EBC44 File Offset: 0x008E9E44
		internal string EmergencyToneTrigger_42107_UILabel
		{
			get
			{
				short num = (short)546652555;
				short num2 = num;
				num = (short)768754059;
				switch (num2 == num)
				{
				}
				num = (short)1775632384;
				short num3 = num;
				num = (short)1698824193;
				if (num != 0)
				{
				}
				num = (short)1275592704;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.UIName;
			}
		}

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x0600980D RID: 38925 RVA: 0x008EBCF8 File Offset: 0x008E9EF8
		// (set) Token: 0x0600980E RID: 38926 RVA: 0x008EBDAC File Offset: 0x008E9FAC
		internal bool EmergencyToneTrigger_42107_HiddenStatic
		{
			get
			{
				short num = (short)471686166;
				short num2 = num;
				num = (short)287988758;
				switch (num2 == num)
				{
				}
				num = (short)674693120;
				short num3 = num;
				num = (short)1733361665;
				if (num != 0)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.HiddenStatic;
			}
			set
			{
				short num = (short)109629535;
				short num2 = num;
				num = (short)1795608671;
				switch (num2 == num)
				{
				}
				num = (short)1047658496;
				short num3 = num;
				num = (short)577175553;
				if (num != 0)
				{
				}
				num = (short)2033254400;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.HiddenStatic = value;
			}
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x0600980F RID: 38927 RVA: 0x008EBE60 File Offset: 0x008EA060
		// (set) Token: 0x06009810 RID: 38928 RVA: 0x008EBF10 File Offset: 0x008EA110
		internal bool EmergencyToneTrigger_42107_HiddenDynamic
		{
			get
			{
				short num = (short)1380052495;
				short num2 = num;
				num = (short)1605103119;
				switch (num2 == num)
				{
				}
				num = (short)1000341504;
				short num3 = num;
				num = (short)1600061440;
				if (num != 0)
				{
				}
				num = (short)566165505;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107.HiddenDynamic;
			}
			set
			{
				short num = (short)847716660;
				short num2 = num;
				num = (short)291971380;
				switch (num2 == num)
				{
				}
				num = (short)2041511936;
				short num3 = num;
				num = (short)748552193;
				if (num != 0)
				{
				}
				num = (short)1714421760;
				if (num != 0)
				{
				}
				this.emergencyToneTrigger_42107.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x06009811 RID: 38929 RVA: 0x008EBFC4 File Offset: 0x008EA1C4
		public bool EmergencyToneTrigger_42107_HasDiffs
		{
			get
			{
				short num = (short)515196241;
				short num2 = num;
				num = (short)112674129;
				switch (num2 == num)
				{
				}
				num = (short)479330304;
				short num3 = num;
				num = (short)778305537;
				if (num != 0)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				return this.emergencyToneTrigger_42107._HasDiffs;
			}
		}

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x008EC078 File Offset: 0x008EA278
		// (set) Token: 0x06009813 RID: 38931 RVA: 0x008EC12C File Offset: 0x008EA32C
		public int TrkEmerTone_42108Value
		{
			get
			{
				short num = (short)1814442906;
				short num2 = num;
				num = (short)1206399898;
				switch (num2 == num)
				{
				}
				num = (short)279576576;
				short num3 = num;
				num = (short)682622976;
				if (num != 0)
				{
				}
				num = (short)1253965825;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.Value;
			}
			set
			{
				short num = (short)2031229804;
				short num2 = num;
				num = (short)660872044;
				switch (num2 == num)
				{
				}
				num = (short)395444224;
				short num3 = num;
				num = (short)536739840;
				if (num != 0)
				{
				}
				num = (short)1440481281;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.Value = value;
			}
		}

		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x008EC1E4 File Offset: 0x008EA3E4
		// (set) Token: 0x06009815 RID: 38933 RVA: 0x008EC298 File Offset: 0x008EA498
		public string TrkEmerTone_42108_UIValue
		{
			get
			{
				short num = (short)2118057985;
				if (num != 0)
				{
				}
				num = (short)976996991;
				short num2 = num;
				num = (short)803326591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)841547776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113142784;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.UIValue;
			}
			set
			{
				short num = (short)2016608257;
				if (num != 0)
				{
				}
				num = (short)1880708164;
				short num2 = num;
				num = (short)1476547652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970260480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)375783424;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.UIValue = value;
			}
		}

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x06009816 RID: 38934 RVA: 0x008EC34C File Offset: 0x008EA54C
		public global::AcpBusinessLayer.AcpListField TrkEmerTone_42108
		{
			get
			{
				short num = (short)1504805998;
				short num2 = num;
				num = (short)418284654;
				switch (num2 == num)
				{
				}
				num = (short)1242365952;
				short num3 = num;
				num = (short)627834881;
				if (num != 0)
				{
				}
				num = (short)139067392;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108;
			}
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x06009817 RID: 38935 RVA: 0x008EC3FC File Offset: 0x008EA5FC
		// (set) Token: 0x06009818 RID: 38936 RVA: 0x008EC4B0 File Offset: 0x008EA6B0
		public bool TrkEmerTone_42108_Applicable
		{
			get
			{
				short num = (short)1894959290;
				short num2 = num;
				num = (short)390842554;
				switch (num2 == num)
				{
				}
				num = (short)2064580608;
				short num3 = num;
				num = (short)1539375105;
				if (num != 0)
				{
				}
				num = (short)464453632;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.Applicable;
			}
			set
			{
				short num = (short)1537701431;
				short num2 = num;
				num = (short)1226602039;
				switch (num2 == num)
				{
				}
				num = (short)433455104;
				short num3 = num;
				num = (short)1947402241;
				if (num != 0)
				{
				}
				num = (short)752484352;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.Applicable = value;
			}
		}

		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x06009819 RID: 38937 RVA: 0x008EC564 File Offset: 0x008EA764
		// (set) Token: 0x0600981A RID: 38938 RVA: 0x008EC61C File Offset: 0x008EA81C
		public bool TrkEmerTone_42108_Valid
		{
			get
			{
				short num = (short)1114598460;
				short num2 = num;
				num = (short)1834118204;
				switch (num2 == num)
				{
				}
				num = (short)286982144;
				short num3 = num;
				num = (short)927203329;
				if (num != 0)
				{
				}
				num = (short)78970880;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.Valid;
			}
			set
			{
				short num = (short)6456751;
				short num2 = num;
				num = (short)99911087;
				switch (num2 == num)
				{
				}
				num = (short)957874176;
				short num3 = num;
				num = (short)855375873;
				if (num != 0)
				{
				}
				num = (short)1755250688;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.Valid = value;
			}
		}

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x0600981B RID: 38939 RVA: 0x008EC6D4 File Offset: 0x008EA8D4
		// (set) Token: 0x0600981C RID: 38940 RVA: 0x008EC788 File Offset: 0x008EA988
		public bool TrkEmerTone_42108_Visible
		{
			get
			{
				short num = (short)1041223079;
				short num2 = num;
				num = (short)632606119;
				switch (num2 == num)
				{
				}
				num = (short)1873739776;
				short num3 = num;
				num = (short)6094848;
				if (num != 0)
				{
				}
				num = (short)1826029569;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.Visible;
			}
			set
			{
				short num = (short)1261633537;
				if (num != 0)
				{
				}
				num = (short)1452620192;
				short num2 = num;
				num = (short)874068384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)306249728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736704000;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.Visible = value;
			}
		}

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x0600981D RID: 38941 RVA: 0x008EC83C File Offset: 0x008EAA3C
		// (set) Token: 0x0600981E RID: 38942 RVA: 0x008EC8F4 File Offset: 0x008EAAF4
		public bool TrkEmerTone_42108_Editable
		{
			get
			{
				short num = (short)1973441608;
				short num2 = num;
				num = (short)181163080;
				switch (num2 == num)
				{
				}
				num = (short)123076608;
				short num3 = num;
				num = (short)1466105857;
				if (num != 0)
				{
				}
				num = (short)1373437952;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.Editable;
			}
			set
			{
				short num = (short)1960203371;
				short num2 = num;
				num = (short)1791083;
				switch (num2 == num)
				{
				}
				num = (short)1538129920;
				short num3 = num;
				num = (short)406585344;
				if (num != 0)
				{
				}
				num = (short)1277952001;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.Editable = value;
			}
		}

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x0600981F RID: 38943 RVA: 0x008EC9AC File Offset: 0x008EABAC
		internal string TrkEmerTone_42108_UILabel
		{
			get
			{
				short num = (short)1674364880;
				short num2 = num;
				num = (short)1571014608;
				switch (num2 == num)
				{
				}
				num = (short)748617728;
				short num3 = num;
				num = (short)1272184833;
				if (num != 0)
				{
				}
				num = (short)896794624;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.UIName;
			}
		}

		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x06009820 RID: 38944 RVA: 0x008ECA60 File Offset: 0x008EAC60
		// (set) Token: 0x06009821 RID: 38945 RVA: 0x008ECB14 File Offset: 0x008EAD14
		internal bool TrkEmerTone_42108_HiddenStatic
		{
			get
			{
				short num = (short)664738356;
				short num2 = num;
				num = (short)434051636;
				switch (num2 == num)
				{
				}
				num = (short)2007171072;
				short num3 = num;
				num = (short)2131820544;
				if (num != 0)
				{
				}
				num = (short)459800577;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.HiddenStatic;
			}
			set
			{
				short num = (short)1362100225;
				if (num != 0)
				{
				}
				num = (short)522303767;
				short num2 = num;
				num = (short)971553047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244004352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392967680;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.HiddenStatic = value;
			}
		}

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x008ECBC8 File Offset: 0x008EADC8
		// (set) Token: 0x06009823 RID: 38947 RVA: 0x008ECC80 File Offset: 0x008EAE80
		internal bool TrkEmerTone_42108_HiddenDynamic
		{
			get
			{
				short num = (short)1771945930;
				short num2 = num;
				num = (short)1068220362;
				switch (num2 == num)
				{
				}
				num = (short)884604928;
				short num3 = num;
				num = (short)1022885889;
				if (num != 0)
				{
				}
				num = (short)161939456;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108.HiddenDynamic;
			}
			set
			{
				short num = (short)275705150;
				short num2 = num;
				num = (short)128904510;
				switch (num2 == num)
				{
				}
				num = (short)654573568;
				short num3 = num;
				num = (short)1665597441;
				if (num != 0)
				{
				}
				num = (short)260505600;
				if (num != 0)
				{
				}
				this.trkEmerTone_42108.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x008ECD38 File Offset: 0x008EAF38
		public bool TrkEmerTone_42108_HasDiffs
		{
			get
			{
				short num = (short)1848599631;
				short num2 = num;
				num = (short)448750671;
				switch (num2 == num)
				{
				}
				num = (short)1225850880;
				short num3 = num;
				num = (short)488112128;
				if (num != 0)
				{
				}
				num = (short)757071873;
				if (num != 0)
				{
				}
				return this.trkEmerTone_42108._HasDiffs;
			}
		}

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x06009825 RID: 38949 RVA: 0x008ECDEC File Offset: 0x008EAFEC
		// (set) Token: 0x06009826 RID: 38950 RVA: 0x008ECEA4 File Offset: 0x008EB0A4
		public int TrkEmerToneMinimumVolume_42109Value
		{
			get
			{
				short num = (short)1422524417;
				if (num != 0)
				{
				}
				num = (short)352351268;
				short num2 = num;
				num = (short)1907520548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912850944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039204352;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Value;
			}
			set
			{
				short num = (short)2098404072;
				short num2 = num;
				num = (short)706747112;
				switch (num2 == num)
				{
				}
				num = (short)1688076288;
				short num3 = num;
				num = (short)1633353728;
				if (num != 0)
				{
				}
				num = (short)525860865;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Value = value;
			}
		}

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x06009827 RID: 38951 RVA: 0x008ECF58 File Offset: 0x008EB158
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerToneMinimumVolume_42109
		{
			get
			{
				short num = (short)1109060448;
				short num2 = num;
				num = (short)423291744;
				switch (num2 == num)
				{
				}
				num = (short)1174077440;
				short num3 = num;
				num = (short)1943535617;
				if (num != 0)
				{
				}
				num = (short)575275008;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109;
			}
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x008ED004 File Offset: 0x008EB204
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x008ED0B8 File Offset: 0x008EB2B8
		public string TrkEmerToneMinimumVolume_42109_UIValue
		{
			get
			{
				short num = (short)1970574721;
				short num2 = num;
				num = (short)1788319105;
				switch (num2 == num)
				{
				}
				num = (short)750059520;
				short num3 = num;
				num = (short)104136704;
				if (num != 0)
				{
				}
				num = (short)895746049;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.UIValue;
			}
			set
			{
				short num = (short)1672590569;
				short num2 = num;
				num = (short)2059252969;
				switch (num2 == num)
				{
				}
				num = (short)343539712;
				short num3 = num;
				num = (short)1823604737;
				if (num != 0)
				{
				}
				num = (short)38731776;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.UIValue = value;
			}
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x008ED170 File Offset: 0x008EB370
		// (set) Token: 0x0600982B RID: 38955 RVA: 0x008ED228 File Offset: 0x008EB428
		internal int TrkEmerToneMinimumVolume_42109Min
		{
			get
			{
				short num = (short)1254093697;
				short num2 = num;
				num = (short)83293057;
				switch (num2 == num)
				{
				}
				num = (short)76283904;
				short num3 = num;
				num = (short)760741888;
				if (num != 0)
				{
				}
				num = (short)55902209;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Min;
			}
			set
			{
				short num = (short)476250113;
				if (num != 0)
				{
				}
				num = (short)597673432;
				short num2 = num;
				num = (short)179684824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)173473792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960247296;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Min = value;
			}
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x008ED2DC File Offset: 0x008EB4DC
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x008ED38C File Offset: 0x008EB58C
		internal int TrkEmerToneMinimumVolume_42109Max
		{
			get
			{
				short num = (short)1323982119;
				short num2 = num;
				num = (short)1253268775;
				switch (num2 == num)
				{
				}
				num = (short)195690496;
				short num3 = num;
				num = (short)2102198272;
				if (num != 0)
				{
				}
				num = (short)573308929;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Max;
			}
			set
			{
				short num = (short)1942796591;
				short num2 = num;
				num = (short)512735535;
				switch (num2 == num)
				{
				}
				num = (short)812646400;
				short num3 = num;
				num = (short)2115502080;
				if (num != 0)
				{
				}
				num = (short)2040922113;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Max = value;
			}
		}

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x008ED444 File Offset: 0x008EB644
		// (set) Token: 0x0600982F RID: 38959 RVA: 0x008ED4F4 File Offset: 0x008EB6F4
		internal int TrkEmerToneMinimumVolume_42109Step
		{
			get
			{
				short num = (short)1352702967;
				short num2 = num;
				num = (short)1540594679;
				switch (num2 == num)
				{
				}
				num = (short)184877056;
				short num3 = num;
				num = (short)1549271040;
				if (num != 0)
				{
				}
				num = (short)1425342465;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.StepSize;
			}
			set
			{
				short num = (short)1081016321;
				if (num != 0)
				{
				}
				num = (short)1041188744;
				short num2 = num;
				num = (short)20334472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271332864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945829376;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.StepSize = value;
			}
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x008ED5A8 File Offset: 0x008EB7A8
		// (set) Token: 0x06009831 RID: 38961 RVA: 0x008ED658 File Offset: 0x008EB858
		public bool TrkEmerToneMinimumVolume_42109_Applicable
		{
			get
			{
				short num = (short)1940914177;
				if (num != 0)
				{
				}
				num = (short)961812475;
				short num2 = num;
				num = (short)1790842875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663158784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1325858816;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Applicable;
			}
			set
			{
				short num = (short)1897820248;
				short num2 = num;
				num = (short)1598779480;
				switch (num2 == num)
				{
				}
				num = (short)1765670912;
				short num3 = num;
				num = (short)955908097;
				if (num != 0)
				{
				}
				num = (short)901709824;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Applicable = value;
			}
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x008ED70C File Offset: 0x008EB90C
		// (set) Token: 0x06009833 RID: 38963 RVA: 0x008ED7C0 File Offset: 0x008EB9C0
		public bool TrkEmerToneMinimumVolume_42109_Valid
		{
			get
			{
				short num = (short)1788018688;
				short num2 = num;
				num = (short)1743418071;
				short num3 = num;
				num = (short)1219654359;
				switch (num3 == num)
				{
				}
				num = (short)1187250177;
				if (num != 0)
				{
				}
				num = (short)653787136;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Valid;
			}
			set
			{
				short num = (short)1457455104;
				short num2 = num;
				num = (short)1050211939;
				short num3 = num;
				num = (short)1001322083;
				switch (num3 == num)
				{
				}
				num = (short)632029185;
				if (num != 0)
				{
				}
				num = (short)657063936;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Valid = value;
			}
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x008ED874 File Offset: 0x008EBA74
		// (set) Token: 0x06009835 RID: 38965 RVA: 0x008ED928 File Offset: 0x008EBB28
		public bool TrkEmerToneMinimumVolume_42109_Visible
		{
			get
			{
				short num = (short)1990852608;
				short num2 = num;
				num = (short)837072683;
				short num3 = num;
				num = (short)63289131;
				switch (num3 == num)
				{
				}
				num = (short)794820608;
				if (num != 0)
				{
				}
				num = (short)631767041;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Visible;
			}
			set
			{
				short num = (short)1600520192;
				short num2 = num;
				num = (short)237436929;
				if (num != 0)
				{
				}
				num = (short)926530559;
				short num3 = num;
				num = (short)2139077631;
				switch (num3 == num)
				{
				}
				num = (short)807337984;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Visible = value;
			}
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x06009836 RID: 38966 RVA: 0x008ED9DC File Offset: 0x008EBBDC
		// (set) Token: 0x06009837 RID: 38967 RVA: 0x008EDA90 File Offset: 0x008EBC90
		public bool TrkEmerToneMinimumVolume_42109_Editable
		{
			get
			{
				short num = (short)1007288320;
				short num2 = num;
				num = (short)696786861;
				short num3 = num;
				num = (short)233906093;
				switch (num3 == num)
				{
				}
				num = (short)2009333761;
				if (num != 0)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.Editable;
			}
			set
			{
				short num = (short)730005504;
				short num2 = num;
				num = (short)24317972;
				short num3 = num;
				num = (short)138416148;
				switch (num3 == num)
				{
				}
				num = (short)1144324096;
				if (num != 0)
				{
				}
				num = (short)1365442561;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.Editable = value;
			}
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x06009838 RID: 38968 RVA: 0x008EDB48 File Offset: 0x008EBD48
		internal string TrkEmerToneMinimumVolume_42109_UILabel
		{
			get
			{
				short num = (short)1461256192;
				short num2 = num;
				num = (short)1478433656;
				short num3 = num;
				num = (short)369040248;
				switch (num3 == num)
				{
				}
				num = (short)2039742465;
				if (num != 0)
				{
				}
				num = (short)504561664;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.UIName;
			}
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x06009839 RID: 38969 RVA: 0x008EDBFC File Offset: 0x008EBDFC
		// (set) Token: 0x0600983A RID: 38970 RVA: 0x008EDCB4 File Offset: 0x008EBEB4
		internal bool TrkEmerToneMinimumVolume_42109_HiddenStatic
		{
			get
			{
				short num = (short)497025024;
				short num2 = num;
				num = (short)1787449870;
				short num3 = num;
				num = (short)1843221006;
				switch (num3 == num)
				{
				}
				num = (short)1487601665;
				if (num != 0)
				{
				}
				num = (short)2085421056;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.HiddenStatic;
			}
			set
			{
				short num = (short)925302784;
				short num2 = num;
				num = (short)525664257;
				if (num != 0)
				{
				}
				num = (short)1766397938;
				short num3 = num;
				num = (short)1387534322;
				switch (num3 == num)
				{
				}
				num = (short)295567360;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.HiddenStatic = value;
			}
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x0600983B RID: 38971 RVA: 0x008EDD68 File Offset: 0x008EBF68
		// (set) Token: 0x0600983C RID: 38972 RVA: 0x008EDE1C File Offset: 0x008EC01C
		internal bool TrkEmerToneMinimumVolume_42109_HiddenDynamic
		{
			get
			{
				short num = (short)60817408;
				short num2 = num;
				num = (short)1952720214;
				short num3 = num;
				num = (short)1534666070;
				switch (num3 == num)
				{
				}
				num = (short)1395785729;
				if (num != 0)
				{
				}
				num = (short)609419264;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109.HiddenDynamic;
			}
			set
			{
				short num = (short)741933056;
				short num2 = num;
				num = (short)383776457;
				short num3 = num;
				num = (short)598603465;
				switch (num3 == num)
				{
				}
				num = (short)995098625;
				if (num != 0)
				{
				}
				num = (short)1853947904;
				if (num != 0)
				{
				}
				this.trkEmerToneMinimumVolume_42109.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x008EDED4 File Offset: 0x008EC0D4
		public bool TrkEmerToneMinimumVolume_42109_HasDiffs
		{
			get
			{
				short num = (short)392757248;
				short num2 = num;
				num = (short)1869280162;
				short num3 = num;
				num = (short)1923937186;
				switch (num3 == num)
				{
				}
				num = (short)2013921281;
				if (num != 0)
				{
				}
				num = (short)719650816;
				if (num != 0)
				{
				}
				return this.trkEmerToneMinimumVolume_42109._HasDiffs;
			}
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x008EDF88 File Offset: 0x008EC188
		// (set) Token: 0x0600983F RID: 38975 RVA: 0x008EE03C File Offset: 0x008EC23C
		public int TrkEmerTonePeriodSec_42110Value
		{
			get
			{
				short num = (short)304742400;
				short num2 = num;
				num = (short)968282852;
				short num3 = num;
				num = (short)584504036;
				switch (num3 == num)
				{
				}
				num = (short)738656257;
				if (num != 0)
				{
				}
				num = (short)1860108288;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Value;
			}
			set
			{
				short num = (short)1367867392;
				short num2 = num;
				num = (short)551753519;
				short num3 = num;
				num = (short)2132547375;
				switch (num3 == num)
				{
				}
				num = (short)1002569729;
				if (num != 0)
				{
				}
				num = (short)1068367872;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Value = value;
			}
		}

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x06009840 RID: 38976 RVA: 0x008EE0F0 File Offset: 0x008EC2F0
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerTonePeriodSec_42110
		{
			get
			{
				short num = (short)841940992;
				short num2 = num;
				num = (short)1228668929;
				if (num != 0)
				{
				}
				num = (short)1085247994;
				short num3 = num;
				num = (short)956207610;
				switch (num3 == num)
				{
				}
				num = (short)1733099520;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110;
			}
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x008EE1A0 File Offset: 0x008EC3A0
		// (set) Token: 0x06009842 RID: 38978 RVA: 0x008EE254 File Offset: 0x008EC454
		public string TrkEmerTonePeriodSec_42110_UIValue
		{
			get
			{
				short num = (short)235012096;
				short num2 = num;
				num = (short)1976011926;
				short num3 = num;
				num = (short)2064419990;
				switch (num3 == num)
				{
				}
				num = (short)479330305;
				if (num != 0)
				{
				}
				num = (short)854917120;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.UIValue;
			}
			set
			{
				short num = (short)729350144;
				short num2 = num;
				num = (short)1993015145;
				short num3 = num;
				num = (short)1836056425;
				switch (num3 == num)
				{
				}
				num = (short)2120220673;
				if (num != 0)
				{
				}
				num = (short)2141323264;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.UIValue = value;
			}
		}

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x06009843 RID: 38979 RVA: 0x008EE30C File Offset: 0x008EC50C
		// (set) Token: 0x06009844 RID: 38980 RVA: 0x008EE3C0 File Offset: 0x008EC5C0
		internal int TrkEmerTonePeriodSec_42110Min
		{
			get
			{
				short num = (short)496631808;
				short num2 = num;
				num = (short)1995802740;
				short num3 = num;
				num = (short)1490454644;
				switch (num3 == num)
				{
				}
				num = (short)1309147137;
				if (num != 0)
				{
				}
				num = (short)2752512;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Min;
			}
			set
			{
				short num = (short)581697536;
				short num2 = num;
				num = (short)1249025100;
				short num3 = num;
				num = (short)90676300;
				switch (num3 == num)
				{
				}
				num = (short)522059776;
				if (num != 0)
				{
				}
				num = (short)2079522817;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Min = value;
			}
		}

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06009845 RID: 38981 RVA: 0x008EE478 File Offset: 0x008EC678
		// (set) Token: 0x06009846 RID: 38982 RVA: 0x008EE52C File Offset: 0x008EC72C
		internal int TrkEmerTonePeriodSec_42110Max
		{
			get
			{
				short num = (short)1265893376;
				short num2 = num;
				num = (short)1948057601;
				if (num != 0)
				{
				}
				num = (short)1199104800;
				short num3 = num;
				num = (short)307946272;
				switch (num3 == num)
				{
				}
				num = (short)566427648;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Max;
			}
			set
			{
				short num = (short)1840906240;
				short num2 = num;
				num = (short)785842177;
				if (num != 0)
				{
				}
				num = (short)520194495;
				short num3 = num;
				num = (short)723093951;
				switch (num3 == num)
				{
				}
				num = (short)1584463872;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Max = value;
			}
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x06009847 RID: 38983 RVA: 0x008EE5E0 File Offset: 0x008EC7E0
		// (set) Token: 0x06009848 RID: 38984 RVA: 0x008EE694 File Offset: 0x008EC894
		internal int TrkEmerTonePeriodSec_42110Step
		{
			get
			{
				short num = (short)250085376;
				short num2 = num;
				num = (short)1586736400;
				short num3 = num;
				num = (short)2047651088;
				switch (num3 == num)
				{
				}
				num = (short)1246035969;
				if (num != 0)
				{
				}
				num = (short)1291190272;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.StepSize;
			}
			set
			{
				short num = (short)2086010880;
				short num2 = num;
				num = (short)1380264552;
				short num3 = num;
				num = (short)1718299240;
				switch (num3 == num)
				{
				}
				num = (short)727580673;
				if (num != 0)
				{
				}
				num = (short)784203776;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.StepSize = value;
			}
		}

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x06009849 RID: 38985 RVA: 0x008EE748 File Offset: 0x008EC948
		// (set) Token: 0x0600984A RID: 38986 RVA: 0x008EE7FC File Offset: 0x008EC9FC
		public bool TrkEmerTonePeriodSec_42110_Applicable
		{
			get
			{
				short num = (short)426901504;
				short num2 = num;
				num = (short)518473785;
				short num3 = num;
				num = (short)882657337;
				switch (num3 == num)
				{
				}
				num = (short)1718681600;
				if (num != 0)
				{
				}
				num = (short)1970995201;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Applicable;
			}
			set
			{
				short num = (short)2019753984;
				short num2 = num;
				num = (short)430343658;
				short num3 = num;
				num = (short)1130726890;
				switch (num3 == num)
				{
				}
				num = (short)1587937280;
				if (num != 0)
				{
				}
				num = (short)2003894273;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Applicable = value;
			}
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0600984B RID: 38987 RVA: 0x008EE8B4 File Offset: 0x008ECAB4
		// (set) Token: 0x0600984C RID: 38988 RVA: 0x008EE96C File Offset: 0x008ECB6C
		public bool TrkEmerTonePeriodSec_42110_Valid
		{
			get
			{
				short num = (short)1101660160;
				short num2 = num;
				num = (short)2146833814;
				short num3 = num;
				num = (short)1220285846;
				switch (num3 == num)
				{
				}
				num = (short)338296833;
				if (num != 0)
				{
				}
				num = (short)1802829824;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Valid;
			}
			set
			{
				short num = (short)1564147712;
				short num2 = num;
				num = (short)569401538;
				short num3 = num;
				num = (short)1317626050;
				switch (num3 == num)
				{
				}
				num = (short)491454465;
				if (num != 0)
				{
				}
				num = (short)2086076416;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Valid = value;
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x0600984D RID: 38989 RVA: 0x008EEA24 File Offset: 0x008ECC24
		// (set) Token: 0x0600984E RID: 38990 RVA: 0x008EEAD8 File Offset: 0x008ECCD8
		public bool TrkEmerTonePeriodSec_42110_Visible
		{
			get
			{
				short num = (short)1649278976;
				short num2 = num;
				num = (short)1600962197;
				short num3 = num;
				num = (short)618512021;
				switch (num3 == num)
				{
				}
				num = (short)1424752641;
				if (num != 0)
				{
				}
				num = (short)534118400;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Visible;
			}
			set
			{
				short num = (short)303562752;
				short num2 = num;
				num = (short)1553034131;
				short num3 = num;
				num = (short)2000055187;
				switch (num3 == num)
				{
				}
				num = (short)321585153;
				if (num != 0)
				{
				}
				num = (short)1782317056;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Visible = value;
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x0600984F RID: 38991 RVA: 0x008EEB90 File Offset: 0x008ECD90
		// (set) Token: 0x06009850 RID: 38992 RVA: 0x008EEC44 File Offset: 0x008ECE44
		public bool TrkEmerTonePeriodSec_42110_Editable
		{
			get
			{
				short num = (short)105250816;
				short num2 = num;
				num = (short)503954695;
				short num3 = num;
				num = (short)79674631;
				switch (num3 == num)
				{
				}
				num = (short)827392001;
				if (num != 0)
				{
				}
				num = (short)2142306304;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.Editable;
			}
			set
			{
				short num = (short)765722624;
				short num2 = num;
				num = (short)1009635397;
				short num3 = num;
				num = (short)255971397;
				switch (num3 == num)
				{
				}
				num = (short)953942016;
				if (num != 0)
				{
				}
				num = (short)1603796993;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.Editable = value;
			}
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x008EECFC File Offset: 0x008ECEFC
		internal string TrkEmerTonePeriodSec_42110_UILabel
		{
			get
			{
				short num = (short)582877184;
				short num2 = num;
				num = (short)1099382310;
				short num3 = num;
				num = (short)1178287654;
				switch (num3 == num)
				{
				}
				num = (short)1255931905;
				if (num != 0)
				{
				}
				num = (short)1110835200;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.UIName;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x008EEDB0 File Offset: 0x008ECFB0
		// (set) Token: 0x06009853 RID: 38995 RVA: 0x008EEE64 File Offset: 0x008ED064
		internal bool TrkEmerTonePeriodSec_42110_HiddenStatic
		{
			get
			{
				short num = (short)1256718336;
				short num2 = num;
				num = (short)167294379;
				short num3 = num;
				num = (short)821343659;
				switch (num3 == num)
				{
				}
				num = (short)462946304;
				if (num != 0)
				{
				}
				num = (short)814284801;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.HiddenStatic;
			}
			set
			{
				short num = (short)1372848128;
				short num2 = num;
				num = (short)738773319;
				short num3 = num;
				num = (short)1332791623;
				switch (num3 == num)
				{
				}
				num = (short)1421934593;
				if (num != 0)
				{
				}
				num = (short)2137653248;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.HiddenStatic = value;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06009854 RID: 38996 RVA: 0x008EEF18 File Offset: 0x008ED118
		// (set) Token: 0x06009855 RID: 38997 RVA: 0x008EEFD0 File Offset: 0x008ED1D0
		internal bool TrkEmerTonePeriodSec_42110_HiddenDynamic
		{
			get
			{
				short num = (short)613875712;
				short num2 = num;
				num = (short)598729072;
				short num3 = num;
				num = (short)1190519152;
				switch (num3 == num)
				{
				}
				num = (short)510984192;
				if (num != 0)
				{
				}
				num = (short)1267466241;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110.HiddenDynamic;
			}
			set
			{
				short num = (short)1132986368;
				short num2 = num;
				num = (short)1094147591;
				short num3 = num;
				num = (short)93478407;
				switch (num3 == num)
				{
				}
				num = (short)46792705;
				if (num != 0)
				{
				}
				num = (short)1310457856;
				if (num != 0)
				{
				}
				this.trkEmerTonePeriodSec_42110.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x06009856 RID: 38998 RVA: 0x008EF088 File Offset: 0x008ED288
		public bool TrkEmerTonePeriodSec_42110_HasDiffs
		{
			get
			{
				short num = (short)640745472;
				short num2 = num;
				num = (short)283840677;
				short num3 = num;
				num = (short)22679717;
				switch (num3 == num)
				{
				}
				num = (short)510918657;
				if (num != 0)
				{
				}
				num = (short)1392836608;
				if (num != 0)
				{
				}
				return this.trkEmerTonePeriodSec_42110._HasDiffs;
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x06009857 RID: 38999 RVA: 0x008EF13C File Offset: 0x008ED33C
		// (set) Token: 0x06009858 RID: 39000 RVA: 0x008EF1F4 File Offset: 0x008ED3F4
		public int TrkEmerAudioRouting_42111Value
		{
			get
			{
				short num = (short)1997668352;
				short num2 = num;
				num = (short)256204340;
				short num3 = num;
				num = (short)1458986548;
				switch (num3 == num)
				{
				}
				num = (short)102694912;
				if (num != 0)
				{
				}
				num = (short)568524801;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.Value;
			}
			set
			{
				short num = (short)467075072;
				short num2 = num;
				num = (short)1618712937;
				short num3 = num;
				num = (short)1632409961;
				switch (num3 == num)
				{
				}
				num = (short)180748289;
				if (num != 0)
				{
				}
				num = (short)1411514368;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.Value = value;
			}
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x06009859 RID: 39001 RVA: 0x008EF2AC File Offset: 0x008ED4AC
		// (set) Token: 0x0600985A RID: 39002 RVA: 0x008EF360 File Offset: 0x008ED560
		public string TrkEmerAudioRouting_42111_UIValue
		{
			get
			{
				short num = (short)1460011008;
				short num2 = num;
				num = (short)508604341;
				short num3 = num;
				num = (short)1684320181;
				switch (num3 == num)
				{
				}
				num = (short)802422784;
				if (num != 0)
				{
				}
				num = (short)312147969;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.UIValue;
			}
			set
			{
				short num = (short)10551296;
				short num2 = num;
				num = (short)193319366;
				short num3 = num;
				num = (short)1693372870;
				switch (num3 == num)
				{
				}
				num = (short)1153040385;
				if (num != 0)
				{
				}
				num = (short)93978624;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.UIValue = value;
			}
		}

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x0600985B RID: 39003 RVA: 0x008EF418 File Offset: 0x008ED618
		public global::AcpBusinessLayer.AcpListField TrkEmerAudioRouting_42111
		{
			get
			{
				short num = (short)449642496;
				short num2 = num;
				num = (short)5968448;
				short num3 = num;
				num = (short)308417088;
				switch (num3 == num)
				{
				}
				num = (short)1218183169;
				if (num != 0)
				{
				}
				num = (short)1754529792;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111;
			}
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x008EF4C8 File Offset: 0x008ED6C8
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x008EF57C File Offset: 0x008ED77C
		public bool TrkEmerAudioRouting_42111_Applicable
		{
			get
			{
				short num = (short)830865408;
				short num2 = num;
				num = (short)2121030705;
				short num3 = num;
				num = (short)1445354545;
				switch (num3 == num)
				{
				}
				num = (short)2077884416;
				if (num != 0)
				{
				}
				num = (short)680198145;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.Applicable;
			}
			set
			{
				short num = (short)813367296;
				short num2 = num;
				num = (short)1848112530;
				short num3 = num;
				num = (short)638383506;
				switch (num3 == num)
				{
				}
				num = (short)1981546497;
				if (num != 0)
				{
				}
				num = (short)1947140096;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.Applicable = value;
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x0600985E RID: 39006 RVA: 0x008EF634 File Offset: 0x008ED834
		// (set) Token: 0x0600985F RID: 39007 RVA: 0x008EF6E8 File Offset: 0x008ED8E8
		public bool TrkEmerAudioRouting_42111_Valid
		{
			get
			{
				short num = (short)1594163200;
				short num2 = num;
				num = (short)1536226455;
				short num3 = num;
				num = (short)654636183;
				switch (num3 == num)
				{
				}
				num = (short)802816000;
				if (num != 0)
				{
				}
				num = (short)1562116097;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.Valid;
			}
			set
			{
				short num = (short)1883635712;
				short num2 = num;
				num = (short)418750942;
				short num3 = num;
				num = (short)2043257310;
				switch (num3 == num)
				{
				}
				num = (short)739311617;
				if (num != 0)
				{
				}
				num = (short)745930752;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.Valid = value;
			}
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06009860 RID: 39008 RVA: 0x008EF79C File Offset: 0x008ED99C
		// (set) Token: 0x06009861 RID: 39009 RVA: 0x008EF854 File Offset: 0x008EDA54
		public bool TrkEmerAudioRouting_42111_Visible
		{
			get
			{
				short num = (short)1608777728;
				short num2 = num;
				num = (short)1846862340;
				short num3 = num;
				num = (short)1513480708;
				switch (num3 == num)
				{
				}
				num = (short)1503068160;
				if (num != 0)
				{
				}
				num = (short)1577254913;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.Visible;
			}
			set
			{
				short num = (short)649789440;
				short num2 = num;
				num = (short)994434130;
				short num3 = num;
				num = (short)725408850;
				switch (num3 == num)
				{
				}
				num = (short)1418985473;
				if (num != 0)
				{
				}
				num = (short)1333788672;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.Visible = value;
			}
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06009862 RID: 39010 RVA: 0x008EF908 File Offset: 0x008EDB08
		// (set) Token: 0x06009863 RID: 39011 RVA: 0x008EF9B8 File Offset: 0x008EDBB8
		public bool TrkEmerAudioRouting_42111_Editable
		{
			get
			{
				short num = (short)11010048;
				short num2 = num;
				num = (short)1311440897;
				if (num != 0)
				{
				}
				num = (short)1500525534;
				short num3 = num;
				num = (short)2101556190;
				switch (num3 == num)
				{
				}
				num = (short)385220608;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.Editable;
			}
			set
			{
				short num = (short)749535232;
				short num2 = num;
				num = (short)757780624;
				short num3 = num;
				num = (short)1408749712;
				switch (num3 == num)
				{
				}
				num = (short)255066112;
				if (num != 0)
				{
				}
				num = (short)1107361793;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.Editable = value;
			}
		}

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x06009864 RID: 39012 RVA: 0x008EFA70 File Offset: 0x008EDC70
		internal string TrkEmerAudioRouting_42111_UILabel
		{
			get
			{
				short num = (short)1403715584;
				short num2 = num;
				num = (short)1452980677;
				short num3 = num;
				num = (short)1546762693;
				switch (num3 == num)
				{
				}
				num = (short)1379205121;
				if (num != 0)
				{
				}
				num = (short)1656815616;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.UIName;
			}
		}

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x06009865 RID: 39013 RVA: 0x008EFB24 File Offset: 0x008EDD24
		// (set) Token: 0x06009866 RID: 39014 RVA: 0x008EFBD8 File Offset: 0x008EDDD8
		internal bool TrkEmerAudioRouting_42111_HiddenStatic
		{
			get
			{
				short num = (short)289472512;
				short num2 = num;
				num = (short)10556290;
				short num3 = num;
				num = (short)1644499842;
				switch (num3 == num)
				{
				}
				num = (short)1123155969;
				if (num != 0)
				{
				}
				num = (short)814481408;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.HiddenStatic;
			}
			set
			{
				short num = (short)43712512;
				short num2 = num;
				num = (short)1281731388;
				short num3 = num;
				num = (short)1205054268;
				switch (num3 == num)
				{
				}
				num = (short)1076363265;
				if (num != 0)
				{
				}
				num = (short)887750656;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.HiddenStatic = value;
			}
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x008EFC90 File Offset: 0x008EDE90
		// (set) Token: 0x06009868 RID: 39016 RVA: 0x008EFD44 File Offset: 0x008EDF44
		internal bool TrkEmerAudioRouting_42111_HiddenDynamic
		{
			get
			{
				short num = (short)1191247872;
				short num2 = num;
				num = (short)2031695066;
				short num3 = num;
				num = (short)191771866;
				switch (num3 == num)
				{
				}
				num = (short)271384576;
				if (num != 0)
				{
				}
				num = (short)449380353;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111.HiddenDynamic;
			}
			set
			{
				short num = (short)1003421696;
				short num2 = num;
				num = (short)1240131224;
				short num3 = num;
				num = (short)1689642648;
				switch (num3 == num)
				{
				}
				num = (short)1975386113;
				if (num != 0)
				{
				}
				num = (short)1855979520;
				if (num != 0)
				{
				}
				this.trkEmerAudioRouting_42111.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x008EFDFC File Offset: 0x008EDFFC
		public bool TrkEmerAudioRouting_42111_HasDiffs
		{
			get
			{
				short num = (short)1757726150;
				short num2 = num;
				num = (short)881182150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1459486720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1452605441;
				if (num != 0)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				return this.trkEmerAudioRouting_42111._HasDiffs;
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x0600986A RID: 39018 RVA: 0x008EFEB4 File Offset: 0x008EE0B4
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)130075642;
				short num2 = num;
				num = (short)766168058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)775290880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287571968;
				if (num != 0)
				{
				}
				num = (short)695336961;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x008EFF74 File Offset: 0x008EE174
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
					num2 = (short)569442305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_F4;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1052602097;
					short num3 = num2;
					num2 = (short)1178169073;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					default:
						num2 = (short)2002124800;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1512374274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1995702273;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)958726144;
						short num4 = num2;
						num2 = (short)189792256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_F4:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)1069678595;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)26673156;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004B14 RID: 19220
		private global::AcpBusinessLayer.AcpListField emergencyToneTrigger_42107;

		// Token: 0x04004B15 RID: 19221
		private global::AcpBusinessLayer.AcpListField trkEmerTone_42108;

		// Token: 0x04004B16 RID: 19222
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerToneMinimumVolume_42109;

		// Token: 0x04004B17 RID: 19223
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerTonePeriodSec_42110;

		// Token: 0x04004B18 RID: 19224
		private global::AcpBusinessLayer.AcpListField trkEmerAudioRouting_42111;
	}
}
