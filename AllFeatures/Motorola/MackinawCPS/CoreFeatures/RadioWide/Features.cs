using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000171 RID: 369
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003031 RID: 12337 RVA: 0x002F1E2C File Offset: 0x002F002C
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x002F1E48 File Offset: 0x002F0048
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x002F1E60 File Offset: 0x002F0060
		public override void Init()
		{
			int a_ = 8;
			short num = (short)864538688;
			short num2 = num;
			num = (short)1698746432;
			switch (num2 == num)
			{
			}
			num = (short)1182334976;
			short num3 = num;
			num = (short)1240137729;
			if (num != 0)
			{
			}
			num = (short)112459776;
			if (num != 0)
			{
			}
			this.radWideFeaturesBlockPendingCAPC_A7564 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꗦ藨蓪軬蓮ꇰ雲鯴鏶郸闺髼볾䀀匂䘄堆䠈㰊㠌㤎┐", a_), global::CommonResources.AcgResources.ID_BLOCKPENDINGCAPC);
			this.radWideFeaturesBlockPendingCAPC_A7564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesBlockPendingCAPC_A7564.DataTransferOrder = 17;
			this.radWideFeaturesChannelFallbackEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꓦ臨諪菬臮铰鿲돴零闸韺鿼黾戀栂䀄椆栈椊愌樎", a_), global::CommonResources.AcgResources.ID_CHANNELFALLBACKENABLE);
			this.radWideFeaturesChannelFallbackEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesChannelFallbackEnable.DataTransferOrder = 21;
			this.radWideAdvancedCyclicKeying_A7795 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤ꓦ部裪臬蛮鋰룲郴軶郸闺髼ꃾ䀀㐂㈄㸆㰈", a_), global::CommonResources.AcgResources.ID_CYCLICKEYING);
			this.radWideAdvancedCyclicKeying_A7795.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAdvancedCyclicKeying_A7795.DataTransferOrder = 20;
			this.radWideTPSFiregroundEvacuationTone_A7980 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔菖觘裚鯜뛞鏠蛢苤闦蛨黪菬诮듰藲铴银賸髺觼雾渀洂億栆月渊刌与☐⨒ⴔ✖", a_), global::CommonResources.AcgResources.ID_EVACUATIONTONE);
			this.radWideTPSFiregroundEvacuationTone_A7980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundEvacuationTone_A7980.DataTransferOrder = 26;
			this.znChanCfgFPPProtectionFPPEnable_A8142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏈ꗊ軌꟎냐뷒雔뇖뻘鷚跜连뇠釢諤鏦賨裪駬蛮黰鷲돴ꟶ꧸뻺鏼黾挀漂怄堆䠈㌊㰌㬎⌐", a_), global::CommonResources.AcgResources.ID_FPPENABLE);
			this.znChanCfgFPPProtectionFPPEnable_A8142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgFPPProtectionFPPEnable_A8142.DataTransferOrder = 120;
			this.radWideAdvancedPreAmp_A8733 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤럦鯨軪곬苮臰곲듴쿶컸죺컼", a_), global::CommonResources.AcgResources.ID_PREAMP);
			this.radWideAdvancedPreAmp_A8733.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAdvancedPreAmp_A8733.DataTransferOrder = 31;
			this.radWideAdvancedRecordAudio_A8922 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤뗦賨裪苬鷮闰닲胴鏶郸铺ꋼ뻾㤀㨂㜄㔆", a_), global::CommonResources.AcgResources.ID_RECORDAUDIO, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedRecordAudio_A8922LovStrs);
			this.radWideAdvancedRecordAudio_A8922.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideAdvancedRecordAudio_A8922.DataTransferOrder = 33;
			this.radWideAdvancedRFModem_A8972 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤뗦꿨ꛪ苬诮铰黲ꫴ뛶쇸싺쫼췾", a_), global::CommonResources.AcgResources.ID_RFMODEM, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedRFModem_A8972LovStrs);
			this.radWideAdvancedRFModem_A8972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideAdvancedRFModem_A8972.DataTransferOrder = 6;
			this.radWideFeaturesRotarySwitchScanPrgm_A8986 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦蛨鿪賬鷮裰ꃲ苴黶跸飺闼곾戀戂欄圆笈氊怌倎倐⬒Ⱄ⼖⼘", a_), global::CommonResources.AcgResources.ID_ROTARYSWITCHSCANPRGM, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesRotarySwitchScanPrgm_A8986LovStrs);
			this.radWideFeaturesRotarySwitchScanPrgm_A8986.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesRotarySwitchScanPrgm_A8986.DataTransferOrder = 36;
			this.switchConventionalSwitchesPosition1_A12643 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexSwitchConventionalSwitchesPosition1_A12643LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idSwitchConventionalSwitchesPosition1_A12643LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㰌倎倐−✔№ⴘ⠚", a_), global::CommonResources.AcgResources.ID_IGNITIONSWITCH, true, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.SwitchConventionalSwitchesPosition1_A12643LovStrs);
			this.switchConventionalSwitchesPosition1_A12643.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.switchConventionalSwitchesPosition1_A12643.DataTransferOrder = 48;
			this.radWideFeaturesInactivityAutoPoweroff_A38013 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤껦蟨諪軬鯮飰藲鳴菶胸뫺裼课渀匂樄瀆氈礊戌椎眐䰒吔␖℘⬚ⰜⰞ", a_), global::CommonResources.AcgResources.ID_INACTIVITYAUTOPOWEROFFMIN, 15, 840, 1, null, null);
			this.radWideFeaturesInactivityAutoPoweroff_A38013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesInactivityAutoPoweroff_A38013.DataTransferOrder = 156;
			this.radWideFeaturesInactivityAutoPoweroff_A38013.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
			this.radWideFeaturesInactivityAutoPoweroff_A38013.ShowHexValue = false;
			this.radWideFeaturesIgnitionAutoPoweroff_A38014 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤껦軨藪蓬鯮飰鳲鯴뛶賸迺鋼꿾渀琂怄甆昈洊欌倎倐‒ⴔ✖⠘⼚", a_), global::CommonResources.AcgResources.ID_IGNITIONAUTOPOWEROFFMIN, 3, 840, 1, null, null);
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.DataTransferOrder = 155;
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.ShowHexValue = false;
			this.radWideTransmitPowerLevelsBandSplitOverride_A41064 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔菖ꯘ뫚돜곞賠諢釤럦蛨鳪裬鷮뷰雲菴鋶闸裺뿼黾漀朂嘄眆攈戊礌䀎朐瘒朔攖瀘缚砜䀞怠ᜢᐤᜦἨἪ", a_), global::CommonResources.AcgResources.ID_OVERLAPREGIONBANDPREFERENCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTransmitPowerLevelsBandSplitOverride_A41064LovStrs);
			this.radWideTransmitPowerLevelsBandSplitOverride_A41064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideTransmitPowerLevelsBandSplitOverride_A41064.DataTransferOrder = 107;
			this.radWideFeaturesAccessoryCableConfiguration_41997 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꛦ諨裪裬鳮苰鳲蟴軶뫸髺鿼鏾搀䀂樄椆漈戊樌税挐爒愔縖瘘甚䈜⬞ဠᨢᰤဦ", a_), global::CommonResources.AcgResources.ID_ACCESSORYCABLECONFIGURATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesAccessoryCableConfiguration_41997LovStrs);
			this.radWideFeaturesAccessoryCableConfiguration_41997.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideFeaturesAccessoryCableConfiguration_41997.DataTransferOrder = 11;
			this.radWideFeaturesChanChangeOnOffHookEnable_A42354 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꓦ臨諪菬곮駰鋲鯴郶鳸듺鏼냾最攂䴄栆昈怊䠌愎瀐焒礔爖䘘娚⤜ⴞሠᘢᄤ", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBENABLE);
			this.radWideFeaturesChanChangeOnOffHookEnable_A42354.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesChanChangeOnOffHookEnable_A42354.DataTransferOrder = 240;
			this.radWideFeaturesTargetZoneOnOffHook_A42355 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤돦裨駪諬諮藰꧲髴駶鳸듺鏼냾最攂䴄栆昈怊刌与┐ℒ☔∖Ⱈ", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBTARGETZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radWideFeaturesTargetZoneOnOffHook_A42355.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesTargetZoneOnOffHook_A42355.DataTransferOrder = 241;
			this.radWideFeaturesTargetChanOnOffHook_A42356 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤돦裨駪諬諮藰냲鷴零韸듺鏼냾最攂䴄栆昈怊刌与┐ℒ☔∖⼘", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBTARGETCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radWideFeaturesTargetChanOnOffHook_A42356.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesTargetChanOnOffHook_A42356.DataTransferOrder = 242;
			this.radWideFeaturesVoiceAbsenceTimer_42458 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뇦蛨苪軬諮냰釲蛴鋶韸飺飼꯾栀渂怄甆嘈㼊㼌㬎␐⬒", a_), global::CommonResources.AcgResources.ID_VOICEABSENCETIMERSEC, 5, 60, null, null, 0, 1);
			this.radWideFeaturesVoiceAbsenceTimer_42458.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideFeaturesVoiceAbsenceTimer_42458.DataTransferOrder = 255;
			this.radWideFeaturesVoiceAbsenceTimer_42458.ShowHexValue = false;
			this.isolatedGCAIAccessoryPlugAndPlayDisable_42927 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胈룊ꋌꏎ냐꟒냔돖默飚鳜雞ꃠ胢蛤苦髨飪苬鷮裰ꏲ駴苶黸뫺鏼鯾儀漂搄縆䴈戊縌渎猐缒瀔䠖ⴘ⤚␜ⴞᘠ", a_), global::CommonResources.AcgResources.ID_DISABLEPLUGANDPLAY);
			this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.DataTransferOrder = 243;
			this.radWideFeaturePreAmpVHF_A42960 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢뗤闦賨ꫪ胬鿮꟰믲돴ꣶ룸쿺쿼웾㜀㌂", a_), global::CommonResources.AcgResources.ID_PREAMPVHF);
			this.radWideFeaturePreAmpVHF_A42960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideFeaturePreAmpVHF_A42960.DataTransferOrder = 250;
			this.radWideFeaturePreAmpUHF_A42962 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢뗤闦賨ꫪ胬鿮ꓰ믲돴ꣶ룸쿺쿼웾㜀㄂", a_), global::CommonResources.AcgResources.ID_PREAMPUHF);
			this.radWideFeaturePreAmpUHF_A42962.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideFeaturePreAmpUHF_A42962.DataTransferOrder = 251;
			this.radWideFeatureDynamicIcons_A42963 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢ꇤ黦蟨諪胬蛮鋰뫲雴飶韸裺ꋼ뻾㔀㄂㰄ㄆ㨈", a_), global::CommonResources.AcgResources.ID_DYNAMICICONS);
			this.radWideFeatureDynamicIcons_A42963.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeatureDynamicIcons_A42963.DataTransferOrder = 252;
			this.radWideFeaturesNFPACompliant = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꧦ꿨믪곬곮黰黲藴鯶郸髺鏼课", a_), global::CommonResources.AcgResources.ID_NFPACOMPLIANT);
			this.radWideFeaturesNFPACompliant.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesNFPACompliant.DataTransferOrder = 358;
			this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꏦ胨飪鷬菮郰諲맴零諸迺볼鳾樀洂樄瀆攈渊椌栎琐眒䀔搖簘椚东欞䀠圢値否䘨太怬䨮䈰䀲吴倶尸携簼ା獀獂畄睆", a_), global::CommonResources.AcgResources.ID_DISPLAYLASTACKNOWLEDGEDUSERSTATUSORMESSAGE);
			this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.DataTransferOrder = 253;
			this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꏦ胨飪賬跮鷰雲보郶韸鋺觼雾渀洂䐄爆紈搊崌怎昐瘒朔堖缘級尜猞䐠儢儤砦栨ᠪᔬἮ0ز", a_), global::CommonResources.AcgResources.ID_DISABLEIGNITIONAUTOPOWEROFFALERT);
			this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.DataTransferOrder = 254;
			this.radWideFeaturesExtRFRoute_A43020 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideFeaturesExtRFRoute_A43020LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideFeaturesExtRFRoute_A43020LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꋦ釨鿪뿬ꧮꏰ鳲胴菶鳸ꓺ볼쯾㈀㌂㜄㜆", a_), global::CommonResources.AcgResources.ID_EXTERNALRFROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesExtRFRoute_A43020LovStrs);
			this.radWideFeaturesExtRFRoute_A43020.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesExtRFRoute_A43020.DataTransferOrder = 171;
			this.radWideFeaturesRadioCertificationType_43064 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦裨迪蓬胮닰雲蟴菶郸鷺铼鳾怀眂氄栆月弊琌缎琐䰒℔␖⤘ⴚ⤜", a_), global::CommonResources.AcgResources.ID_RADIOCERTIFICATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesRadioCertificationType_43064LovStrs);
			this.radWideFeaturesRadioCertificationType_43064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesRadioCertificationType_43064.DataTransferOrder = 350;
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦賨裪苬鷮闰ꏲ駴零胸駺鳼鳾樀䈂瀄挆怈搊伌税眐甒瀔攖䨘爚朜稞縠戢ᄤᐦᠨᤪᠬ", a_), global::CommonResources.AcgResources.ID_RECORDPLAYBACKAUDIOBUFFERSIZESEC, 10, 60, 1, null, null);
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.DataTransferOrder = 352;
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.ShowHexValue = false;
			this.radWideFeaturesZoneCloneEnable_43130 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뷦蛨藪裬곮鷰鳲鯴鋶본闺鳼鷾洀昂娄㌆㨈㨊㸌㼎", a_), global::CommonResources.AcgResources.ID_ZONECLONEENABLE);
			this.radWideFeaturesZoneCloneEnable_43130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesZoneCloneEnable_43130.DataTransferOrder = 500;
			this.radWideFeaturesVoiceControlPriority = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뇦蛨苪軬諮닰鳲鯴菶诸铺釼꿾猀樂樄甆怈缊琌", a_), global::CommonResources.AcgResources.ID_RADIOWIDEFEATURESVOICECONTROLPRIORITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVoiceControlPriorityLovStrs);
			this.radWideFeaturesVoiceControlPriority.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesVoiceControlPriority.DataTransferOrder = 353;
			this.radCfgVirtualPartnerMode = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌賎럐듒菔뻖ꯘ꿚꣜뻞跠돢蓤闦鷨藪裬鷮볰鳲釴鋶", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgVirtualPartnerModeLovStrs);
			this.radCfgVirtualPartnerMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radCfgVirtualPartnerMode.DataTransferOrder = 354;
			this.radWideFeaturesVirtualPartnerAudioPriority = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뇦胨駪駬髮郰鿲ꗴ零诸迺鏼髾猀䈂瀄挆怈搊崌紎砐簒朔縖洘戚", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESVIRTUALPARTNERAUDIOPRIORITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVirtualPartnerAudioPriorityLovStrs);
			this.radWideFeaturesVirtualPartnerAudioPriority.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesVirtualPartnerAudioPriority.DataTransferOrder = 355;
			this.radCfgVirtualPartnerInactivityTime = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌賎럐듒菔뻖ꯘ꿚꣜뻞跠돢蓤闦鷨藪裬鷮룰鷲铴银跸鋺诼雾甀稂億渆搈渊", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERINACTIVITYTIME, 5, 255, null, null, 0, 1);
			this.radCfgVirtualPartnerInactivityTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radCfgVirtualPartnerInactivityTime.DataTransferOrder = 356;
			this.radCfgVirtualPartnerInactivityTime.ShowHexValue = false;
			this.radWideFeaturesSmartMessagingSmartMessageMode = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤듦蓨諪鿬鯮볰雲蛴蓶飸鳺铼釾昀倂栄昆笈缊䀌樎成怒琔瀖簘嘚爜笞䐠", a_), global::CommonResources.AcgResources.ID_RADIOFEATURESSMARTMESSAGINGSMARTMESSAGEMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesSmartMessagingSmartMessageModeLovStrs);
			this.radWideFeaturesSmartMessagingSmartMessageMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesSmartMessagingSmartMessageMode.DataTransferOrder = 357;
			this.radWideFeaturesPowerManagementStandbyTime = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤럦蛨鳪裬鷮볰鋲鯴零黸黺郼髾漀眂嘄猆栈攊椌洎栐䜒簔稖簘", a_), global::CommonResources.AcgResources.ID_POWERDOWNSTANDBYMODEHRS, 0, 8, null, null, 0, 1);
			this.radWideFeaturesPowerManagementStandbyTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesPowerManagementStandbyTime.DataTransferOrder = 112;
			this.radWideFeaturesPowerManagementStandbyTime.ShowHexValue = false;
			this.radWideFeatureAnalogWidebandData = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢ꓤ触裨蟪苬裮꛰髲釴鋶鯸髺鏼鯾䔀戂焄昆", a_), global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATA);
			this.radWideFeatureAnalogWidebandData.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideFeatureAnalogWidebandData.DataTransferOrder = 359;
			this.radWideFeaturesVLIFPLOSSFIELD_A9596 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뇦ꗨꋪ꯬뿮뷰볲꛴ꓶ뿸닺룼돾䔀専䐄㸆㰈㈊㬌", a_), global::CommonResources.AcgResources.ID_VLIFPLOSSFIELD, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVLIFPLOSSFIELD_A9596LovStrs);
			this.radWideFeaturesVLIFPLOSSFIELD_A9596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideFeaturesVLIFPLOSSFIELD_A9596.DataTransferOrder = 360;
			this.radWideCustomLogoEnabled = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔铖곘꣚꧜냞賠꿢諤胦蛨껪菬軮鏰鿲郴鏶", a_), global::CommonResources.AcgResources.ID_CUSTOMLOGOENABLED);
			this.radWideCustomLogoEnabled.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideCustomLogoEnabled.DataTransferOrder = 361;
			this.radWideFeaturesRadioInhibitUIEnabled_44914 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦裨迪蓬胮룰鷲鷴黶鯸鋺觼꫾䠀䘂欄昆欈朊栌欎丐✒℔⸖⠘⼚", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITUIENABLED);
			this.radWideFeaturesRadioInhibitUIEnabled_44914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesRadioInhibitUIEnabled_44914.DataTransferOrder = 363;
			this.radWideFeaturesRadioInhibitDisplayTextLine1_44915 = new global::AcpBusinessLayer.AcpField<string>(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦裨迪蓬胮룰鷲鷴黶鯸鋺觼믾栀瀂甄欆栈爊夌樎椐朒夔縖眘縚Ⱌ䀞ᔠᜢᰤᘦᰨ", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITDISPLAYTEXTLINE1);
			this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.DataTransferOrder = 364;
			this.radWideFeaturesRadioInhibitDisplayTextLine2_44916 = new global::AcpBusinessLayer.AcpField<string>(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤뗦裨迪蓬胮룰鷲鷴黶鯸鋺觼믾栀瀂甄欆栈爊夌樎椐朒夔縖眘縚⼜䀞ᔠᜢᰤᘦἨ", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITDISPLAYTEXTLINE2);
			this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.DataTransferOrder = 365;
			this.radWideFeaturesEnableInvalidSIMNotification_A44945 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔釖볘뫚꧜꫞鏠蛢雤ꋦ蟨諪迬菮铰뫲鯴臶飸韺铼鯾刀䨂䠄䤆昈缊搌椎砐瀒琔挖瀘琚猜䀞怠ᜢᄤḦᴨḪ", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESENABLEINVALIDSIMNOTIFICATION);
			this.radWideFeaturesEnableInvalidSIMNotification_A44945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideFeaturesEnableInvalidSIMNotification_A44945.DataTransferOrder = 366;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迈껊곌믎ꓐꇒ냔ꓖ", a_);
			base.Id = 10105;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x002F2A34 File Offset: 0x002F0C34
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1878327404;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1983250433;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䄂搄椆洈堊紌挎砐朒娔愖簘椚漜瘞䔠䘢稤昦ᴨᨪᴬ᤮԰", a_)))
					{
						num = (short)141426770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1118;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬諮鋰鳲蟴鏶꧸韺鳼蛾挀戂昄氆䠈縊椌明縐儒怔焖缘縚漜䰞䠠夢䀤砦栨ἪḬḬ̈́ز", a_)))
					{
						num = (short)1093075054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10CB;
				case 2:
					this.radWideFeaturesRadioInhibitDisplayTextLine1_44915 = new global::AcpBusinessLayer.AcpField<string>(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂䄄渆稈笊愌渎栐䜒瀔漖洘圚琜焞䐠ሢ稤ጦᴨሪᰬᨮ", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITDISPLAYTEXTLINE1);
					this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.DataTransferOrder = 364;
					num = (short)470351887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎ꛐ뫒ꇔ듖뇘飚닜뇞韠蛢诤鏦胨蓪菬軮鷰ꃲ苴黶跸飺闼髾爀匂樄理怈缊搌怎缐−䨔嘖⠘⤚⬜⬞ሠ", a_)))
					{
						num = (short)2073362537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_746;
				case 4:
					this.radWideFeaturesPowerManagementStandbyTime = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뷬胮蛰雲蟴뫶飸闺鳼飾搀渂怄椆紈堊礌渎缐眒眔渖䴘爚瀜稞", a_), global::CommonResources.AcgResources.ID_VOICEABSENCETIMERSEC, null, null, 0, 1);
					this.radWideFeaturesPowerManagementStandbyTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesPowerManagementStandbyTime.DataTransferOrder = 112;
					this.radWideFeaturesPowerManagementStandbyTime.ShowHexValue = false;
					num = (short)1188757558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radCfgVirtualPartnerInactivityTime = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴뻶韸髺黼课栀甂氄猆瀈弊搌戎琐", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERINACTIVITYTIME, null, null, 0, 1);
					this.radCfgVirtualPartnerInactivityTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radCfgVirtualPartnerInactivityTime.DataTransferOrder = 356;
					this.radCfgVirtualPartnerInactivityTime.ShowHexValue = false;
					num = (short)475398210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_19AD;
				case 7:
					goto IL_19F9;
				case 8:
					this.radWideFeaturesVirtualPartnerAudioPriority = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬蛮菰蟲胴零闸꯺鳼跾甀洂怄甆䠈縊椌明縐䌒朔縖瘘椚琜欞堠", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESVIRTUALPARTNERAUDIOPRIORITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVirtualPartnerAudioPriorityLovStrs);
					this.radWideFeaturesVirtualPartnerAudioPriority.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesVirtualPartnerAudioPriority.DataTransferOrder = 355;
					num = (short)1331953719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.radWideAdvancedRecordAudio_A8922 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뿬諮鋰鳲蟴鏶룸軺駼雾渀専䐄㼆〈㤊㼌", a_), global::CommonResources.AcgResources.ID_RECORDAUDIO, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedRecordAudio_A8922LovStrs);
					this.radWideAdvancedRecordAudio_A8922.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideAdvancedRecordAudio_A8922.DataTransferOrder = 33;
					num = (short)1010958378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radWideFeaturesTargetZoneOnOffHook_A42355 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪맬軮菰铲郴菶ꏸ铺鏼髾一洂䨄愆漈䌊戌怎稐䰒吔⌖⬘⠚⠜⨞", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBTARGETZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radWideFeaturesTargetZoneOnOffHook_A42355.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesTargetZoneOnOffHook_A42355.DataTransferOrder = 241;
					num = (short)175243382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.radWideFeaturesRotarySwitchScanPrgm_A8986 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬胮藰鋲蟴軶꫸賺铼课戀欂嘄搆栈攊崌紎瘐縒䨔嘖℘√├⤞", a_), global::CommonResources.AcgResources.ID_ROTARYSWITCHSCANPRGM, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesRotarySwitchScanPrgm_A8986LovStrs);
					this.radWideFeaturesRotarySwitchScanPrgm_A8986.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesRotarySwitchScanPrgm_A8986.DataTransferOrder = 36;
					num = (short)183762995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.radWideFeaturesVoiceAbsenceTimer_42458 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬胮飰郲郴뛶鯸裺飼釾戀昂億渆搈渊缌倎┐ℒ℔∖℘", a_), global::CommonResources.AcgResources.ID_VOICEABSENCETIMERSEC, null, null, 0, 1);
					this.radWideFeaturesVoiceAbsenceTimer_42458.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideFeaturesVoiceAbsenceTimer_42458.DataTransferOrder = 255;
					this.radWideFeaturesVoiceAbsenceTimer_42458.ShowHexValue = false;
					num = (short)71434323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨믪鿬諮냰黲藴ꇶ뇸뷺ꋼ뻾㔀㄂㰄ㄆ㤈", a_)))
					{
						num = (short)1189871661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C4;
				case 14:
					goto IL_1CA9;
				case 15:
					goto IL_165E;
				case 16:
					this.radWideAdvancedCyclicKeying_A7795 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪껬雮鋰鿲鳴银닸黺蓼雾漀搂娄䘆㸈㰊㐌㨎", a_), global::CommonResources.AcgResources.ID_CYCLICKEYING);
					this.radWideAdvancedCyclicKeying_A7795.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAdvancedCyclicKeying_A7795.DataTransferOrder = 20;
					num = (short)376242190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꣬韮藰ꇲ돴ꗶ雸軺觼髾帀䈂㄄㐆㤈㤊㴌", a_)))
					{
						num = (short)630718494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14D0;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨ꫪ菬軮鷰鳲鋴ꃶ郸鿺飼鷾怀洂愄䌆栈缊氌", a_)))
					{
						num = (short)1960902780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DBD;
				case 19:
					goto IL_B6E;
				case 20:
					this.radWideFeaturesVoiceControlPriority = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬胮飰郲郴듶雸闺觼跾渀漂唄甆怈搊缌明攐樒", a_), global::CommonResources.AcgResources.ID_RADIOWIDEFEATURESVOICECONTROLPRIORITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVoiceControlPriorityLovStrs);
					this.radWideFeaturesVoiceControlPriority.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesVoiceControlPriority.DataTransferOrder = 353;
					num = (short)1866727462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_1118;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬ꏮ룰뗲ꗴ믶뛸꣺껼맾䠀䘂䤄䌆嘈䨊㐌㨎⠐┒", a_)))
					{
						num = (short)772210799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1255;
				case 23:
					this.radWideFeaturesAccessoryCableConfiguration_41997 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪곬賮鋰雲蛴蓶雸觺蓼볾怀愂椄戆䨈搊挌椎砐琒怔攖砘漚琜瀞传簢ᄤᘦဨሪᨬ", a_), global::CommonResources.AcgResources.ID_ACCESSORYCABLECONFIGURATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesAccessoryCableConfiguration_41997LovStrs);
					this.radWideFeaturesAccessoryCableConfiguration_41997.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideFeaturesAccessoryCableConfiguration_41997.DataTransferOrder = 11;
					num = (short)517210180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.radWideTPSFiregroundEvacuationTone_A7980 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜连닠ꗢ賤闦賨質鿬胮蓰鷲釴닶迸髺黼諾怀眂氄栆月弊戌愎琐䰒吔‖‘⌚ⴜ", a_), global::CommonResources.AcgResources.ID_EVACUATIONTONE);
					this.radWideTPSFiregroundEvacuationTone_A7980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundEvacuationTone_A7980.DataTransferOrder = 26;
					num = (short)200278068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.znChanCfgFPPProtectionFPPEnable_A8142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闎뿐郒뷔뛖럘飚믜룞꟠돢뗤럦鯨蓪駬諮鋰蟲鳴飶韸뷺근꿾䐀洂搄攆攈渊刌与⤐−℔┖", a_), global::CommonResources.AcgResources.ID_FPPENABLE);
					this.znChanCfgFPPProtectionFPPEnable_A8142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgFPPProtectionFPPEnable_A8142.DataTransferOrder = 120;
					num = (short)1531576363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪맬軮菰铲郴菶ꏸ铺鏼髾一洂䨄愆漈䌊戌怎稐䰒吔⌖⬘⠚⠜⨞", a_)))
					{
						num = (short)1034223626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8A3;
				case 27:
					num = (short)2016673883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_1B6A;
				case 29:
					goto IL_15C4;
				case 30:
					this.radWideFeaturesExtRFRoute_A43020 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideFeaturesExtRFRoute_A43020LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideFeaturesExtRFRoute_A43020LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꣬韮藰ꇲ돴ꗶ雸軺觼髾帀䈂㄄㐆㤈㤊㴌", a_), global::CommonResources.AcgResources.ID_EXTERNALRFROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesExtRFRoute_A43020LovStrs);
					this.radWideFeaturesExtRFRoute_A43020.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesExtRFRoute_A43020.DataTransferOrder = 171;
					num = (short)207618141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꧬ蛮苰鋲韴鯶鳸닺髼釾栀眂氄栆月䨊砌笎縐䌒稔怖簘椚刜礞䜠戢䤤䈦嬨弪爬渮ȰଲԴضస", a_)))
					{
						num = (short)1443561550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 32:
					goto IL_2AE;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪껬雮鋰鿲鳴银닸黺蓼雾漀搂娄䘆㸈㰊㐌㨎", a_)))
					{
						num = (short)963837968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA9;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뿬ꧮ볰鳲釴鋶铸ꓺ볼쟾㠀㐂㜄", a_)))
					{
						num = (short)832045095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FC;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꓬ臮郰郲致黶迸鋺觼蛾䀀瘂焄栆夈搊稌樎挐簒猔焖䘘娚⸜✞ᄠሢᘤ", a_)))
					{
						num = (short)1215299710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6E;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꣬臮郰釲駴鋶냸闺诼黾洀樂愄吆䀈䘊䌌怎攐稒猔縖稘稚検瘞丠䴢稤昦ᴨἪᐬᬮа", a_)))
					{
						goto IL_1C8C;
					}
					goto IL_1E9C;
				case 37:
					this.radWideFeaturesChannelFallbackEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪껬蟮郰鷲鯴鋶闸뷺鳼鏾洀愂搄搆戈上挌渎猐缒瀔", a_), global::CommonResources.AcgResources.ID_CHANNELFALLBACKENABLE);
					this.radWideFeaturesChannelFallbackEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesChannelFallbackEnable.DataTransferOrder = 21;
					num = (short)1494745160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_1DAD;
				case 39:
					this.radWideAdvancedRFModem_A8972 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뿬ꧮ볰鳲釴鋶铸ꓺ볼쟾㠀㐂㜄", a_), global::CommonResources.AcgResources.ID_RFMODEM, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedRFModem_A8972LovStrs);
					this.radWideAdvancedRFModem_A8972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideAdvancedRFModem_A8972.DataTransferOrder = 6;
					num = (short)1316028492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂䄄渆稈笊愌渎栐䜒瀔漖洘圚琜焞䐠ᄢ稤ጦᴨሪᰬ᤮", a_)))
					{
						num = (short)919076950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5B;
				case 41:
					goto IL_1C5B;
				case 42:
					goto IL_6AD;
				case 43:
					goto IL_E0A;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꓬ裮鿰髲致黶雸闺볼諾甀氂唄栆縈渊缌怎眐甒䨔嘖⨘⌚ⴜ⸞ᔠ", a_)))
					{
						num = (short)74776636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19F9;
				case 45:
					this.radWideFeaturePreAmpVHF_A42960 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨믪鿬諮냰黲藴ꇶ뇸뷺ꋼ뻾㔀㄂㰄ㄆ㤈", a_), global::CommonResources.AcgResources.ID_PREAMPVHF);
					this.radWideFeaturePreAmpVHF_A42960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideFeaturePreAmpVHF_A42960.DataTransferOrder = 250;
					num = (short)712572957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.radWideFeaturesZoneCloneEnable_43130 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪러胮鿰雲뛴鯶雸闺飼뫾漀戂朄欆氈吊㤌㰎‐‒└", a_), global::CommonResources.AcgResources.ID_ZONECLONEENABLE);
					this.radWideFeaturesZoneCloneEnable_43130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesZoneCloneEnable_43130.DataTransferOrder = 500;
					num = (short)1017970758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪맬軮菰铲郴菶뫸鏺鳼釾一洂䨄愆漈䌊戌怎稐䰒吔⌖⬘⠚⠜⤞", a_)))
					{
						num = (short)901578856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_627;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪껬蟮郰鷲뛴鿶飸闺髼髾一洂䨄愆漈䌊戌怎稐嘒笔瘖笘眚砜䀞怠ᜢᜤᐦᰨἪ", a_)))
					{
						num = (short)1943666765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D6E;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨믪鿬諮냰黲藴ꋶ뇸뷺ꋼ뻾㔀㄂㰄ㄆ㬈", a_)))
					{
						num = (short)166592587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BBB;
				case 50:
					this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("뷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꧬ蛮苰菲駴零胸럺鳼賾甀䈂昄氆月搊稌挎琐眒爔爖紘业渜稞匠瀢儤䘦崨帪帬䀮䌰縲倴䐶䨸娺娼娾Ṁɂ煄畆祈筊経", a_), global::CommonResources.AcgResources.ID_DISPLAYLASTACKNOWLEDGEDUSERSTATUSORMESSAGE);
					this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.DataTransferOrder = 253;
					num = (short)270532677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_F1B;
				case 52:
					goto IL_18BB;
				case 53:
					num = (short)1171718231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					goto IL_1165;
				case 55:
					goto IL_11B1;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뻬苮郰臲致뫶鳸裺軼黾昀樂欄怆娈昊氌紎攐帒瀔搖樘稚稜稞氠䰢䄤䈦", a_)))
					{
						num = (short)1298464877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7EA;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜连닠ꗢ賤闦賨質鿬胮蓰鷲釴닶迸髺黼諾怀眂氄栆月弊戌愎琐䰒吔‖‘⌚ⴜ", a_)))
					{
						num = (short)1374617624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18BB;
				case 58:
					goto IL_348;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뿬諮鋰鳲蟴鏶룸軺駼雾渀専䐄㼆〈㤊㼌", a_)))
					{
						num = (short)503578633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6AD;
				case 60:
					this.radWideFeaturesIgnitionAutoPoweroff_A38014 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꓬ裮鿰髲致黶雸闺볼諾甀氂唄栆縈渊缌怎眐甒䨔嘖⨘⌚ⴜ⸞ᔠ", a_), global::CommonResources.AcgResources.ID_IGNITIONAUTOPOWEROFFMIN, null, null);
					this.radWideFeaturesIgnitionAutoPoweroff_A38014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesIgnitionAutoPoweroff_A38014.DataTransferOrder = 155;
					this.radWideFeaturesIgnitionAutoPoweroff_A38014.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
					this.radWideFeaturesIgnitionAutoPoweroff_A38014.ShowHexValue = false;
					num = (short)1130430471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 61:
					goto IL_DBD;
				case 62:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뷬鷮铰닲飴蟶꛸뫺염죾㈀。", a_)))
					{
						num = (short)451412062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6FB;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛎ꋐ볒맔뛖귘뻚맜飞ꋠꋢ곤ꛦ諨裪裬鳮苰鳲蟴軶꧸韺裼飾䀀洂愄圆攈樊琌䬎砐怒琔甖甘縚䈜⬞ጠᨢᜤဦ", a_)))
					{
						num = (short)961282151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DFA;
				case 64:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪러胮鿰雲뛴鯶雸闺飼뫾漀戂朄欆氈吊㤌㰎‐‒└", a_)))
					{
						num = (short)631111726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0F;
				case 65:
					goto IL_BBB;
				case 66:
					goto IL_1AC6;
				case 67:
					this.radWideCustomLogoEnabled = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚黜꫞鋠韢諤諦ꗨ蓪諬胮듰鷲铴闶闸黺駼", a_), global::CommonResources.AcgResources.ID_CUSTOMLOGOENABLED);
					this.radWideCustomLogoEnabled.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideCustomLogoEnabled.DataTransferOrder = 361;
					num = (short)1800994931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					goto IL_CB7;
				case 69:
					goto IL_1823;
				case 70:
					goto IL_1C0F;
				case 71:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴뫶雸鿺飼", a_)))
					{
						num = (short)1616248951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B6A;
				case 72:
					goto IL_195F;
				case 73:
					this.radWideFeaturesRadioCertificationType_43064 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴듶鳸觺觼雾最樂昄昆紈戊戌愎䔐樒攔爖䘘⼚⸜⼞ᜠᜢ", a_), global::CommonResources.AcgResources.ID_RADIOCERTIFICATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesRadioCertificationType_43064LovStrs);
					this.radWideFeaturesRadioCertificationType_43064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesRadioCertificationType_43064.DataTransferOrder = 350;
					num = (short)1833828433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 74:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪곬賮鋰雲蛴蓶雸觺蓼볾怀愂椄戆䨈搊挌椎砐琒怔攖砘漚琜瀞传簢ᄤᘦဨሪᨬ", a_)))
					{
						num = (short)1485373463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB7;
				case 75:
					this.radWideFeaturePreAmpUHF_A42962 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨믪鿬諮냰黲藴ꋶ뇸뷺ꋼ뻾㔀㄂㰄ㄆ㬈", a_), global::CommonResources.AcgResources.ID_PREAMPUHF);
					this.radWideFeaturePreAmpUHF_A42962.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideFeaturePreAmpUHF_A42962.DataTransferOrder = 251;
					num = (short)1700134977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 76:
					goto IL_2FC;
				case 77:
					this.radWideFeaturesChanChangeOnOffHookEnable_A42354 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪껬蟮郰鷲뛴鿶飸闺髼髾一洂䨄愆漈䌊戌怎稐嘒笔瘖笘眚砜䀞怠ᜢᜤᐦᰨἪ", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBENABLE);
					this.radWideFeaturesChanChangeOnOffHookEnable_A42354.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesChanChangeOnOffHookEnable_A42354.DataTransferOrder = 240;
					num = (short)1637154912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 78:
					this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꧬ蛮苰鋲韴鯶鳸닺髼釾栀眂氄栆月䨊砌笎縐䌒稔怖簘椚刜礞䜠戢䤤䈦嬨弪爬渮ȰଲԴضస", a_), global::CommonResources.AcgResources.ID_DISABLEIGNITIONAUTOPOWEROFFALERT);
					this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.DataTransferOrder = 254;
					num = (short)308543520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 79:
					goto IL_627;
				case 80:
					this.radWideFeaturesBlockPendingCAPC_A7564 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꿬菮黰郲黴ꟶ鳸闺駼雾漀搂䘄䘆夈䠊刌与☐☒⌔⌖", a_), global::CommonResources.AcgResources.ID_BLOCKPENDINGCAPC);
					this.radWideFeaturesBlockPendingCAPC_A7564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesBlockPendingCAPC_A7564.DataTransferOrder = 17;
					num = (short)2021720070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 81:
					goto IL_1611;
				case 82:
					this.radWideTransmitPowerLevelsBandSplitOverride_A41064 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䄂搄椆洈堊紌挎砐朒娔愖簘椚漜瘞䔠䘢稤昦ᴨᨪᴬ᤮԰", a_), global::CommonResources.AcgResources.ID_OVERLAPREGIONBANDPREFERENCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTransmitPowerLevelsBandSplitOverride_A41064LovStrs);
					this.radWideTransmitPowerLevelsBandSplitOverride_A41064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideTransmitPowerLevelsBandSplitOverride_A41064.DataTransferOrder = 107;
					num = (short)560398357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 83:
					goto IL_1577;
				case 84:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬胮飰郲郴듶雸闺觼跾渀漂唄甆怈搊缌明攐樒", a_)))
					{
						num = (short)1738473492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DAD;
				case 85:
					this.radWideFeaturesRadioInhibitUIEnabled_44914 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂倄丆䰈攊氌洎紐瘒焔䠖ⴘ⼚␜⸞ᔠ", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITUIENABLED);
					this.radWideFeaturesRadioInhibitUIEnabled_44914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesRadioInhibitUIEnabled_44914.DataTransferOrder = 363;
					num = (short)1427243114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 86:
					this.radWideFeaturesRadioInhibitDisplayTextLine2_44916 = new global::AcpBusinessLayer.AcpField<string>(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂䄄渆稈笊愌渎栐䜒瀔漖洘圚琜焞䐠ᄢ稤ጦᴨሪᰬ᤮", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESRADIOINHIBITDISPLAYTEXTLINE2);
					this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.DataTransferOrder = 365;
					num = (short)1413808169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 87:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꿬菮黰郲黴ꟶ鳸闺駼雾漀搂䘄䘆夈䠊刌与☐☒⌔⌖", a_)))
					{
						num = (short)257228880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19AD;
				case 88:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪껬蟮郰鷲鯴鋶闸뷺鳼鏾洀愂搄搆戈上挌渎猐缒瀔", a_)))
					{
						num = (short)1128398885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195F;
				case 89:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚黜꫞鋠韢諤諦ꗨ蓪諬胮듰鷲铴闶闸黺駼", a_)))
					{
						num = (short)297009219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_448;
				case 90:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("뷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꧬ蛮苰菲駴零胸럺鳼賾甀䈂昄氆月搊稌挎琐眒爔爖紘业渜稞匠瀢儤䘦崨帪帬䀮䌰縲倴䐶䨸娺娼娾Ṁɂ煄畆祈筊経", a_)))
					{
						num = (short)1951465522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1823;
				case 91:
					if (producerFields != null)
					{
						num = (short)437583925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E9C;
				case 92:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂䄄渆稈笊愌渎栐䜒瀔漖洘圚琜焞䐠ሢ稤ጦᴨሪᰬᨮ", a_)))
					{
						num = (short)994115586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_165E;
				case 93:
					goto IL_14D0;
				case 94:
				{
					num = (short)1029701632;
					short num3 = num;
					this.radWideAdvancedPreAmp_A8733 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鳜믞韠苢诤蓦賨迪뷬鷮铰닲飴蟶꛸뫺염죾㈀。", a_), global::CommonResources.AcgResources.ID_PREAMP);
					this.radWideAdvancedPreAmp_A8733.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAdvancedPreAmp_A8733.DataTransferOrder = 31;
					num = (short)133234790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 95:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꏬꧮꇰ닲뛴飶铸诺釼雾怀洂焄", a_)))
					{
						num = (short)599064673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_348;
				case 96:
					goto IL_D6E;
				case 97:
					this.radWideFeaturesNFPACompliant = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꏬꧮꇰ닲뛴飶铸诺釼雾怀洂焄", a_), global::CommonResources.AcgResources.ID_NFPACOMPLIANT);
					this.radWideFeaturesNFPACompliant.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesNFPACompliant.DataTransferOrder = 358;
					num = (short)1585119290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 98:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴듶鳸觺觼雾最樂昄昆紈戊戌愎䔐樒攔爖䘘⼚⸜⼞ᜠᜢ", a_)))
					{
						num = (short)278397001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1611;
				case 99:
					goto IL_1E9A;
				case 100:
					goto IL_10CB;
				case 101:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴뻶韸髺黼课栀甂氄猆瀈弊搌戎琐", a_)))
					{
						num = (short)864616453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AC6;
				case 102:
					goto IL_6FB;
				case 103:
					this.isolatedGCAIAccessoryPlugAndPlayDisable_42927 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛎ꋐ볒맔뛖귘뻚맜飞ꋠꋢ곤ꛦ諨裪裬鳮苰鳲蟴軶꧸韺裼飾䀀洂愄圆攈樊琌䬎砐怒琔甖甘縚䈜⬞ጠᨢᜤဦ", a_), global::CommonResources.AcgResources.ID_DISABLEPLUGANDPLAY);
					this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.DataTransferOrder = 243;
					num = (short)1093075066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 104:
					this.radWideFeaturesTargetChanOnOffHook_A42356 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪맬軮菰铲郴菶뫸鏺鳼釾一洂䨄愆漈䌊戌怎稐䰒吔⌖⬘⠚⠜⤞", a_), global::CommonResources.AcgResources.ID_CHANNELCHANGEONHUBTARGETCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radWideFeaturesTargetChanOnOffHook_A42356.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesTargetChanOnOffHook_A42356.DataTransferOrder = 242;
					num = (short)897253455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 105:
					this.switchConventionalSwitchesPosition1_A12643 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexSwitchConventionalSwitchesPosition1_A12643LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idSwitchConventionalSwitchesPosition1_A12643LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳎ꛐ뫒ꇔ듖뇘飚닜뇞韠蛢诤鏦胨蓪菬軮鷰ꃲ苴黶跸飺闼髾爀匂樄理怈缊搌怎缐−䨔嘖⠘⤚⬜⬞ሠ", a_), global::CommonResources.AcgResources.ID_IGNITIONSWITCH, true, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.SwitchConventionalSwitchesPosition1_A12643LovStrs);
					this.switchConventionalSwitchesPosition1_A12643.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.switchConventionalSwitchesPosition1_A12643.DataTransferOrder = 48;
					num = (short)1707475064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 106:
					goto IL_ECE;
				case 107:
					this.radWideFeaturesEnableInvalidSIMNotification_A44945 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪꣬臮郰釲駴鋶냸闺诼黾洀樂愄吆䀈䘊䌌怎攐稒猔縖稘稚検瘞丠䴢稤昦ᴨἪᐬᬮа", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESENABLEINVALIDSIMNOTIFICATION);
					this.radWideFeaturesEnableInvalidSIMNotification_A44945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideFeaturesEnableInvalidSIMNotification_A44945.DataTransferOrder = 366;
					num = (short)1830813795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 108:
					switch (0)
					{
					case 0:
						goto IL_229;
					}
					continue;
				case 109:
					this.radWideFeaturesSmartMessagingSmartMessageMode = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뻬苮郰臲致뫶鳸裺軼黾昀樂欄怆娈昊氌紎攐帒瀔搖樘稚稜稞氠䰢䄤䈦", a_), global::CommonResources.AcgResources.ID_RADIOFEATURESSMARTMESSAGINGSMARTMESSAGEMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesSmartMessagingSmartMessageModeLovStrs);
					this.radWideFeaturesSmartMessagingSmartMessageMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesSmartMessagingSmartMessageMode.DataTransferOrder = 357;
					num = (short)1065353330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 110:
					this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬諮鋰鳲蟴鏶꧸韺鳼蛾挀戂昄氆䠈縊椌明縐儒怔焖缘縚漜䰞䠠夢䀤砦栨ἪḬḬ̈́ز", a_), global::CommonResources.AcgResources.ID_RECORDPLAYBACKAUDIOBUFFERSIZESEC, null, null);
					this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.DataTransferOrder = 352;
					this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
					this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.ShowHexValue = false;
					num = (short)1826685028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 111:
					this.radWideFeaturesVLIFPLOSSFIELD_A9596 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬ꏮ룰뗲ꗴ믶뛸꣺껼맾䠀䘂䤄䌆嘈䨊㐌㨎⠐┒", a_), global::CommonResources.AcgResources.ID_VLIFPLOSSFIELD, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVLIFPLOSSFIELD_A9596LovStrs);
					this.radWideFeaturesVLIFPLOSSFIELD_A9596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideFeaturesVLIFPLOSSFIELD_A9596.DataTransferOrder = 360;
					num = (short)1143799920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 112:
					goto IL_1255;
				case 113:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬軮闰髲髴뻶韸鏺铼鷾栀眂倄丆䰈攊氌洎紐瘒焔䠖ⴘ⼚␜⸞ᔠ", a_)))
					{
						num = (short)1342963797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ECE;
				case 114:
					goto IL_7EA;
				case 115:
					goto IL_448;
				case 116:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬胮飰郲郴뛶鯸裺飼釾戀昂億渆搈渊缌倎┐ℒ℔∖℘", a_)))
					{
						num = (short)947650572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1577;
				case 117:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪믬蛮菰蟲胴零闸꯺鳼跾甀洂怄甆䠈縊椌明縐䌒朔縖瘘椚琜欞堠", a_)))
					{
						num = (short)2103705608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B1;
				case 118:
					goto IL_8A3;
				case 119:
					this.radCfgVirtualPartnerMode = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴뫶雸鿺飼", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgVirtualPartnerModeLovStrs);
					this.radCfgVirtualPartnerMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radCfgVirtualPartnerMode.DataTransferOrder = 354;
					num = (short)230227996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 120:
					goto IL_746;
				case 121:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뿬胮藰鋲蟴軶꫸賺铼课戀欂嘄搆栈攊崌紎瘐縒䨔嘖℘√├⤞", a_)))
					{
						num = (short)16711691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F1B;
				case 122:
					goto IL_1DFA;
				case 123:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闎뿐郒뷔뛖럘飚믜룞꟠돢뗤럦鯨蓪駬諮鋰蟲鳴飶韸뷺근꿾䐀洂搄攆攈渊刌与⤐−℔┖", a_)))
					{
						num = (short)1593770009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E0A;
				case 124:
					this.radWideFeatureAnalogWidebandData = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨ꫪ菬軮鷰鳲鋴ꃶ郸鿺飼鷾怀洂愄䌆栈缊氌", a_), global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATA);
					this.radWideFeatureAnalogWidebandData.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideFeatureAnalogWidebandData.DataTransferOrder = 359;
					num = (short)489357373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 125:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪뷬胮蛰雲蟴뫶飸闺鳼飾搀渂怄椆紈堊礌渎缐眒眔渖䴘爚瀜稞", a_)))
					{
						num = (short)675020804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1165;
				case 126:
					this.radWideFeaturesInactivityAutoPoweroff_A38013 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꓬ臮郰郲致黶迸鋺觼蛾䀀瘂焄栆夈搊稌樎挐簒猔焖䘘娚⸜✞ᄠሢᘤ", a_), global::CommonResources.AcgResources.ID_INACTIVITYAUTOPOWEROFFMIN, null, null);
					this.radWideFeaturesInactivityAutoPoweroff_A38013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesInactivityAutoPoweroff_A38013.DataTransferOrder = 156;
					this.radWideFeaturesInactivityAutoPoweroff_A38013.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
					this.radWideFeaturesInactivityAutoPoweroff_A38013.ShowHexValue = false;
					num = (short)949616659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_229:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1994784795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2AE:
				num = (short)1875574801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FC:
				num = (short)29622393;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_348:
				num = (short)2022047869;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_448:
				num = (short)482345073;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_627:
				num = (short)832962676;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6AD:
				num = (short)1350369314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6FB:
				num = (short)1603862587;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_746:
				num = (short)480182307;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7EA:
				num = (short)1710948447;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8A3:
				num = (short)2013462575;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B6E:
				num = (short)1271398444;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BBB:
				num = (short)244645978;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CB7:
				num = (short)581763120;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D6E:
				num = (short)501940250;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DBD:
				num = (short)391446550;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E0A:
				num = (short)1272053822;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ECE:
				num = (short)695009372;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F1B:
				num = (short)1698037763;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10CB:
				num = (short)831389760;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1118:
				num = (short)908197962;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1165:
				num = (short)664797202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11B1:
				num = (short)473759845;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1255:
				num = (short)1257701465;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14D0:
				num = (short)1427112034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1577:
				num = (short)1116340287;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C4:
				num = (short)1645150257;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1611:
				num = (short)1718681601;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165E:
				num = (short)1433993256;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1823:
				num = (short)1848828466;
				short num4 = num;
				num = (short)738648626;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1C8C:
					num = (short)1390084203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)654245888;
					if (num != 0)
					{
					}
					num = (short)1942028319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_18BB:
				num = (short)1721892987;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195F:
				num = (short)134938681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19AD:
				num = (short)1080229921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19F9:
				num = (short)1957429248;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AC6:
				num = (short)332202040;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B6A:
				num = (short)1813315701;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C0F:
				num = (short)1322713172;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C5B:
				num = (short)1368195108;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CA9:
				num = (short)1821835352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DAD:
				num = (short)292094023;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DFA:
				num = (short)586940429;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E9A:
			IL_1E9C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觎듐닒ꇔꋖꯘ뻚껜", a_);
			base.Id = 10105;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x002F4910 File Offset: 0x002F2B10
		public override void PopulateReferences()
		{
			short num = (short)1283398281;
			short num2 = num;
			num = (short)1400445577;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1900544000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1921122304;
			if (num != 0)
			{
			}
			num = (short)700121089;
			if (num != 0)
			{
			}
			this.radWideFeaturesTargetZoneOnOffHook_A42355.SetRecset(this.a(2051));
			this.radWideFeaturesTargetZoneOnOffHook_A42355.AddSlaveField(this.radWideFeaturesTargetChanOnOffHook_A42356, 10114);
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x002F49E4 File Offset: 0x002F2BE4
		public override void DropReferences()
		{
			short num = (short)643694593;
			if (num != 0)
			{
			}
			num = (short)1090125824;
			short num2 = num;
			num = (short)1599415841;
			short num3 = num;
			num = (short)1923294753;
			switch (num3 == num)
			{
			}
			num = (short)1688535040;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x002F4A90 File Offset: 0x002F2C90
		public override void SetConstraints()
		{
			short num = (short)1606477307;
			short num2 = num;
			num = (short)450422267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)822345728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1628897281;
			if (num != 0)
			{
			}
			num = (short)823328768;
			if (num != 0)
			{
			}
			this.radWideAdvancedPreAmp_A8733.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSynVHFUHFPreAmpValue);
			this.radWideAdvancedRecordAudio_A8922.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.radWideAdvancedRFModem_A8972.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDVRSIsEnAndRFModemApp);
			this.radWideAdvancedRFModem_A8972.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDVRSIsEnAndRFModemValid);
			this.switchConventionalSwitchesPosition1_A12643.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIgnitionSwitchValidity);
			this.switchConventionalSwitchesPosition1_A12643.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConToSyncIgnitionSwitchToPosAInTrkAndCnv);
			this.radWideFeaturesInactivityAutoPoweroff_A38013.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsIgnitionAutoPowerOffApplicable);
			this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsIgnitionAutoPowerOffEnabled);
			this.radWideFeaturesTargetZoneOnOffHook_A42355.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conIsTargetZoneChannelApplicable);
			this.radWideFeaturesTargetZoneOnOffHook_A42355.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conIsTargetZoneValid);
			this.radWideFeaturesTargetChanOnOffHook_A42356.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conIsTargetChannelApplicable);
			this.radWideFeaturesTargetChanOnOffHook_A42356.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conIsTargetChannelValid);
			this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAPX1000RefreshandVertexNotEditable);
			this.radWideFeaturePreAmpVHF_A42960.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSynPreAmpValue);
			this.radWideFeaturePreAmpUHF_A42962.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSynPreAmpValue);
			this.radWideFeatureDynamicIcons_A42963.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAPX1000RefreshandVertexNotEditable);
			this.radWideFeaturesExtRFRoute_A43020.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConExtRFRouteBandSelect);
			this.radWideFeaturesExtRFRoute_A43020.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConMultiBandAvai);
			this.radWideFeaturesZoneCloneEnable_43130.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConZoneCloneEnableApplicable);
			this.radWideFeaturesZoneCloneEnable_43130.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConZoneCloneEnableValid);
			this.radWideFeaturesZoneCloneEnable_43130.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConNotCompareMode);
			this.radWideFeaturesZoneCloneEnable_43130.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConZoneCloneEnableValueSetter);
			this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConShowWarningForRecordings);
			this.radCfgVirtualPartnerInactivityTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConVirtualPartnerInactivityTimeEnable);
			this.radWideFeaturesVirtualPartnerAudioPriority.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConVirtualPartnerInactivityTimeEnable);
			this.radCfgVirtualPartnerMode.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRadCfgVirtualPartnerModeEnable);
			this.radCfgVirtualPartnerMode.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForVirtualPartnerMode);
			this.radWideFeaturesSmartMessagingSmartMessageMode.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSmartMessagingValidBasedOnLTEAndWifiEnableBitForSmartMessagingMode);
			this.radWideCustomLogoEnabled.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideFeaturesRadioInhibitUIEnabled_44914.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x002F4E30 File Offset: 0x002F3030
		public override void SetupDependencies()
		{
			short num = (short)1313870993;
			short num2 = num;
			num = (short)615388305;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1367277568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2121662465;
			if (num != 0)
			{
			}
			num = (short)2093744128;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			this.radWideFeaturePreAmpVHF_A42960.AddDependentObject(this.radWideAdvancedPreAmp_A8733);
			this.radWideFeaturePreAmpUHF_A42962.AddDependentObject(this.radWideAdvancedPreAmp_A8733);
			radioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideAdvancedRecordAudio_A8922);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.radWideAdvancedRFModem_A8972);
			radioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideAdvancedRFModem_A8972);
			radioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.switchConventionalSwitchesPosition1_A12643);
			radioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideFeaturesInactivityAutoPoweroff_A38013);
			this.switchConventionalSwitchesPosition1_A12643.AddDependentObject(this.radWideFeaturesIgnitionAutoPoweroff_A38014);
			this.radWideFeaturesIgnitionAutoPoweroff_A38014.AddDependentObject(this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015);
			this.radWideFeaturesChanChangeOnOffHookEnable_A42354.AddDependentObject(this.radWideFeaturesTargetZoneOnOffHook_A42355);
			this.radWideFeaturesChanChangeOnOffHookEnable_A42354.AddDependentObject(this.radWideFeaturesTargetChanOnOffHook_A42356);
			this.radWideAdvancedPreAmp_A8733.AddDependentObject(this.radWideFeaturePreAmpVHF_A42960);
			this.radWideFeaturePreAmpUHF_A42962.AddDependentObject(this.radWideFeaturePreAmpVHF_A42960);
			this.radWideAdvancedPreAmp_A8733.AddDependentObject(this.radWideFeaturePreAmpUHF_A42962);
			this.radWideFeaturePreAmpVHF_A42960.AddDependentObject(this.radWideFeaturePreAmpUHF_A42962);
			this.radCfgVirtualPartnerMode.AddDependentObject(this.radCfgVirtualPartnerInactivityTime);
			this.radCfgVirtualPartnerMode.AddDependentObject(this.radWideFeaturesVirtualPartnerAudioPriority);
			radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.AddDependentObject(this.radCfgVirtualPartnerMode);
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x002F504C File Offset: 0x002F324C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForRadWideFeaturesTargetZoneOnOffHook_A42355
		{
			get
			{
				short num = (short)186348339;
				short num2 = num;
				num = (short)183857971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1440219136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1390280705;
				if (num != 0)
				{
				}
				num = (short)688062464;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x002F5108 File Offset: 0x002F3308
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForRadWideFeaturesTargetChanOnOffHook_A42356
		{
			get
			{
				short num = (short)1773575022;
				short num2 = num;
				num = (short)430414702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1106051072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207552513;
				if (num != 0)
				{
				}
				num = (short)470482944;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x002F51C4 File Offset: 0x002F33C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1507564327;
				short num2 = num;
				num = (short)821402407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1049624576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970733057;
				if (num != 0)
				{
				}
				num = (short)414515200;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x002F5270 File Offset: 0x002F3470
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x002F5324 File Offset: 0x002F3524
		public bool RadWideFeaturesBlockPendingCAPC_A7564Value
		{
			get
			{
				short num = (short)1152623947;
				short num2 = num;
				num = (short)979412299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900412928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659685377;
				if (num != 0)
				{
				}
				num = (short)1432879104;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Value;
			}
			set
			{
				short num = (short)1673512923;
				short num2 = num;
				num = (short)2071775195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462225408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1792802817;
				if (num != 0)
				{
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Value = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x002F53D8 File Offset: 0x002F35D8
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesBlockPendingCAPC_A7564
		{
			get
			{
				short num = (short)281681957;
				short num2 = num;
				num = (short)704258085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034878976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617283584;
				if (num != 0)
				{
				}
				num = (short)1286012929;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x002F5484 File Offset: 0x002F3684
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x002F5538 File Offset: 0x002F3738
		public bool RadWideFeaturesBlockPendingCAPC_A7564_UIValue
		{
			get
			{
				short num = (short)321082614;
				short num2 = num;
				num = (short)707810550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276641280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342491137;
				if (num != 0)
				{
				}
				num = (short)1352794112;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Value;
			}
			set
			{
				short num = (short)1258998601;
				short num2 = num;
				num = (short)1602865993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707526656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327300609;
				if (num != 0)
				{
				}
				num = (short)2084306944;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Value = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x002F55F0 File Offset: 0x002F37F0
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x002F56A4 File Offset: 0x002F38A4
		public bool RadWideFeaturesBlockPendingCAPC_A7564_Applicable
		{
			get
			{
				short num = (short)1613712434;
				short num2 = num;
				num = (short)249711666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917766144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008023041;
				if (num != 0)
				{
				}
				num = (short)1029963776;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Applicable;
			}
			set
			{
				short num = (short)2010456308;
				short num2 = num;
				num = (short)1546592500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561905664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831324161;
				if (num != 0)
				{
				}
				num = (short)1270480896;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Applicable = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x002F5758 File Offset: 0x002F3958
		// (set) Token: 0x06003044 RID: 12356 RVA: 0x002F580C File Offset: 0x002F3A0C
		public bool RadWideFeaturesBlockPendingCAPC_A7564_Valid
		{
			get
			{
				short num = (short)1274388303;
				short num2 = num;
				num = (short)760586063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)79429632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533856257;
				if (num != 0)
				{
				}
				num = (short)1430192128;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Valid;
			}
			set
			{
				short num = (short)253033494;
				short num2 = num;
				num = (short)512228374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615776256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382612993;
				if (num != 0)
				{
				}
				num = (short)1468989440;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Valid = value;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x002F58C0 File Offset: 0x002F3AC0
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x002F5974 File Offset: 0x002F3B74
		public bool RadWideFeaturesBlockPendingCAPC_A7564_Visible
		{
			get
			{
				short num = (short)1861021271;
				short num2 = num;
				num = (short)897314391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1997668352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2095513601;
				if (num != 0)
				{
				}
				num = (short)1620115456;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Visible;
			}
			set
			{
				short num = (short)850722817;
				if (num != 0)
				{
				}
				num = (short)1937571840;
				short num2 = num;
				num = (short)358171250;
				short num3 = num;
				num = (short)914375282;
				switch (num3 == num)
				{
				}
				num = (short)585302016;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Visible = value;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x002F5A2C File Offset: 0x002F3C2C
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x002F5AE0 File Offset: 0x002F3CE0
		public bool RadWideFeaturesBlockPendingCAPC_A7564_Editable
		{
			get
			{
				short num = (short)286636805;
				short num2 = num;
				num = (short)599440133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976631296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)998506496;
				if (num != 0)
				{
				}
				num = (short)2090926081;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.Editable;
			}
			set
			{
				short num = (short)1324697203;
				short num2 = num;
				num = (short)1646544499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382795776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500039681;
				if (num != 0)
				{
				}
				num = (short)1746337792;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.Editable = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x002F5B94 File Offset: 0x002F3D94
		internal string RadWideFeaturesBlockPendingCAPC_A7564_UILabel
		{
			get
			{
				short num = (short)30211102;
				short num2 = num;
				num = (short)1059716126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97583104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801439745;
				if (num != 0)
				{
				}
				num = (short)304021504;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.UIName;
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x002F5C4C File Offset: 0x002F3E4C
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x002F5D00 File Offset: 0x002F3F00
		internal bool RadWideFeaturesBlockPendingCAPC_A7564_HiddenStatic
		{
			get
			{
				short num = (short)124147601;
				short num2 = num;
				num = (short)2036684689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472973312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1274413057;
				if (num != 0)
				{
				}
				num = (short)1247215616;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.HiddenStatic;
			}
			set
			{
				short num = (short)582195039;
				short num2 = num;
				num = (short)663787359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842006528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085931520;
				if (num != 0)
				{
				}
				num = (short)928186369;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.HiddenStatic = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x002F5DB8 File Offset: 0x002F3FB8
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x002F5E6C File Offset: 0x002F406C
		internal bool RadWideFeaturesBlockPendingCAPC_A7564_HiddenDynamic
		{
			get
			{
				short num = (short)278117459;
				short num2 = num;
				num = (short)1913896019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)603324416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383727104;
				if (num != 0)
				{
				}
				num = (short)904593409;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564.HiddenDynamic;
			}
			set
			{
				short num = (short)1944286787;
				short num2 = num;
				num = (short)652572227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1828454400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1917714433;
				if (num != 0)
				{
				}
				num = (short)250085376;
				if (num != 0)
				{
				}
				this.radWideFeaturesBlockPendingCAPC_A7564.HiddenDynamic = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x002F5F20 File Offset: 0x002F4120
		public bool RadWideFeaturesBlockPendingCAPC_A7564_HasDiffs
		{
			get
			{
				short num = (short)1027090021;
				short num2 = num;
				num = (short)1659971173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086324736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1789067264;
				if (num != 0)
				{
				}
				num = (short)2029518849;
				if (num != 0)
				{
				}
				return this.radWideFeaturesBlockPendingCAPC_A7564._HasDiffs;
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x002F5FD4 File Offset: 0x002F41D4
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x002F6088 File Offset: 0x002F4288
		public bool RadWideFeaturesChannelFallbackEnableValue
		{
			get
			{
				short num = (short)1204841028;
				short num2 = num;
				num = (short)211380804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012137984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010827265;
				if (num != 0)
				{
				}
				num = (short)318636032;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Value;
			}
			set
			{
				short num = (short)436319338;
				short num2 = num;
				num = (short)1061008490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811663360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721944577;
				if (num != 0)
				{
				}
				num = (short)573440000;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Value = value;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x002F613C File Offset: 0x002F433C
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesChannelFallbackEnable
		{
			get
			{
				short num = (short)1237359452;
				short num2 = num;
				num = (short)328440668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435617792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)855900160;
				if (num != 0)
				{
				}
				num = (short)1563688961;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable;
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x002F61F0 File Offset: 0x002F43F0
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x002F62A4 File Offset: 0x002F44A4
		public bool RadWideFeaturesChannelFallbackEnable_UIValue
		{
			get
			{
				short num = (short)204800001;
				if (num != 0)
				{
				}
				num = (short)1981939712;
				short num2 = num;
				num = (short)1580712719;
				short num3 = num;
				num = (short)2069938959;
				switch (num3 == num)
				{
				}
				num = (short)918093824;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Value;
			}
			set
			{
				short num = (short)1392848248;
				short num2 = num;
				num = (short)1348218232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454047232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382664705;
				if (num != 0)
				{
				}
				num = (short)324403200;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Value = value;
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x002F635C File Offset: 0x002F455C
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x002F6410 File Offset: 0x002F4610
		public bool RadWideFeaturesChannelFallbackEnable_Applicable
		{
			get
			{
				short num = (short)1189047778;
				short num2 = num;
				num = (short)1558474210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396834304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2066939904;
				if (num != 0)
				{
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Applicable;
			}
			set
			{
				short num = (short)1681653761;
				if (num != 0)
				{
				}
				num = (short)1119879168;
				short num2 = num;
				num = (short)677671756;
				short num3 = num;
				num = (short)721122124;
				switch (num3 == num)
				{
				}
				num = (short)915406848;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Applicable = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x002F64C4 File Offset: 0x002F46C4
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x002F6578 File Offset: 0x002F4778
		public bool RadWideFeaturesChannelFallbackEnable_Valid
		{
			get
			{
				short num = (short)1468088406;
				short num2 = num;
				num = (short)700989526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784152064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842006529;
				if (num != 0)
				{
				}
				num = (short)2059993088;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Valid;
			}
			set
			{
				short num = (short)1582868465;
				short num2 = num;
				num = (short)523347953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121517568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715325441;
				if (num != 0)
				{
				}
				num = (short)1762066432;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Valid = value;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x002F6630 File Offset: 0x002F4830
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x002F66E4 File Offset: 0x002F48E4
		public bool RadWideFeaturesChannelFallbackEnable_Visible
		{
			get
			{
				short num = (short)856112126;
				short num2 = num;
				num = (short)2145401854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)886964224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)503447553;
				if (num != 0)
				{
				}
				num = (short)1481048064;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Visible;
			}
			set
			{
				short num = (short)664010753;
				if (num != 0)
				{
				}
				num = (short)326434816;
				short num2 = num;
				num = (short)1065148291;
				short num3 = num;
				num = (short)1158995843;
				switch (num3 == num)
				{
				}
				num = (short)21233664;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Visible = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x002F6798 File Offset: 0x002F4998
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x002F6850 File Offset: 0x002F4A50
		public bool RadWideFeaturesChannelFallbackEnable_Editable
		{
			get
			{
				short num = (short)1450770433;
				if (num != 0)
				{
				}
				num = (short)1027735552;
				short num2 = num;
				num = (short)919987220;
				short num3 = num;
				num = (short)2096292884;
				switch (num3 == num)
				{
				}
				num = (short)28966912;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.Editable;
			}
			set
			{
				short num = (short)1647002158;
				short num2 = num;
				num = (short)845759022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1713438720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)115802113;
				if (num != 0)
				{
				}
				num = (short)657915904;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.Editable = value;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x002F6904 File Offset: 0x002F4B04
		internal string RadWideFeaturesChannelFallbackEnable_UILabel
		{
			get
			{
				short num = (short)696523475;
				short num2 = num;
				num = (short)1983912659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704263680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015742464;
				if (num != 0)
				{
				}
				num = (short)1246756865;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.UIName;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x002F69B8 File Offset: 0x002F4BB8
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x002F6A6C File Offset: 0x002F4C6C
		internal bool RadWideFeaturesChannelFallbackEnable_HiddenStatic
		{
			get
			{
				short num = (short)239206401;
				if (num != 0)
				{
				}
				num = (short)906231808;
				short num2 = num;
				num = (short)1719203716;
				short num3 = num;
				num = (short)1732048772;
				switch (num3 == num)
				{
				}
				num = (short)1094189056;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.HiddenStatic;
			}
			set
			{
				short num = (short)19595264;
				short num2 = num;
				num = (short)74591952;
				short num3 = num;
				num = (short)1263021776;
				switch (num3 == num)
				{
				}
				num = (short)1116209152;
				if (num != 0)
				{
				}
				num = (short)1964769281;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.HiddenStatic = value;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x002F6B24 File Offset: 0x002F4D24
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x002F6BD8 File Offset: 0x002F4DD8
		internal bool RadWideFeaturesChannelFallbackEnable_HiddenDynamic
		{
			get
			{
				short num = (short)1127546880;
				short num2 = num;
				num = (short)277837900;
				short num3 = num;
				num = (short)1706981452;
				switch (num3 == num)
				{
				}
				num = (short)1013186561;
				if (num != 0)
				{
				}
				num = (short)730071040;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)1623064576;
				short num2 = num;
				num = (short)2000318821;
				short num3 = num;
				num = (short)1183609189;
				switch (num3 == num)
				{
				}
				num = (short)1437925377;
				if (num != 0)
				{
				}
				num = (short)964362240;
				if (num != 0)
				{
				}
				this.radWideFeaturesChannelFallbackEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x002F6C8C File Offset: 0x002F4E8C
		public bool RadWideFeaturesChannelFallbackEnable_HasDiffs
		{
			get
			{
				short num = (short)361693184;
				short num2 = num;
				num = (short)502770153;
				short num3 = num;
				num = (short)1774496233;
				switch (num3 == num)
				{
				}
				num = (short)1534263297;
				if (num != 0)
				{
				}
				num = (short)110297088;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChannelFallbackEnable._HasDiffs;
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x002F6D40 File Offset: 0x002F4F40
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x002F6DF4 File Offset: 0x002F4FF4
		public bool RadWideAdvancedCyclicKeying_A7795Value
		{
			get
			{
				short num = (short)1288110080;
				short num2 = num;
				num = (short)835662596;
				short num3 = num;
				num = (short)462304004;
				switch (num3 == num)
				{
				}
				num = (short)833159168;
				if (num != 0)
				{
				}
				num = (short)1032716289;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Value;
			}
			set
			{
				short num = (short)966459392;
				short num2 = num;
				num = (short)757189464;
				short num3 = num;
				num = (short)764529496;
				switch (num3 == num)
				{
				}
				num = (short)2006188033;
				if (num != 0)
				{
				}
				num = (short)639827968;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Value = value;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x002F6EA8 File Offset: 0x002F50A8
		public global::AcpBusinessLayer.AcpField<bool> RadWideAdvancedCyclicKeying_A7795
		{
			get
			{
				short num = (short)7340032;
				short num2 = num;
				num = (short)1408618584;
				short num3 = num;
				num = (short)1744031832;
				switch (num3 == num)
				{
				}
				num = (short)571408384;
				if (num != 0)
				{
				}
				num = (short)979828737;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795;
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x002F6F58 File Offset: 0x002F5158
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x002F700C File Offset: 0x002F520C
		public bool RadWideAdvancedCyclicKeying_A7795_UIValue
		{
			get
			{
				short num = (short)541589504;
				short num2 = num;
				num = (short)1927271738;
				short num3 = num;
				num = (short)603641146;
				switch (num3 == num)
				{
				}
				num = (short)1957756929;
				if (num != 0)
				{
				}
				num = (short)938016768;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Value;
			}
			set
			{
				short num = (short)557252608;
				short num2 = num;
				num = (short)1632439056;
				short num3 = num;
				num = (short)160828176;
				switch (num3 == num)
				{
				}
				num = (short)1566769153;
				if (num != 0)
				{
				}
				num = (short)1707474944;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Value = value;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x002F70C0 File Offset: 0x002F52C0
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x002F7174 File Offset: 0x002F5374
		public bool RadWideAdvancedCyclicKeying_A7795_Applicable
		{
			get
			{
				short num = (short)1092812800;
				short num2 = num;
				num = (short)1675351253;
				short num3 = num;
				num = (short)1949947093;
				switch (num3 == num)
				{
				}
				num = (short)147783681;
				if (num != 0)
				{
				}
				num = (short)293273600;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Applicable;
			}
			set
			{
				short num = (short)2042494976;
				short num2 = num;
				num = (short)838150413;
				short num3 = num;
				num = (short)697248013;
				switch (num3 == num)
				{
				}
				num = (short)934477825;
				if (num != 0)
				{
				}
				num = (short)1751515136;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Applicable = value;
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x002F722C File Offset: 0x002F542C
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x002F72E0 File Offset: 0x002F54E0
		public bool RadWideAdvancedCyclicKeying_A7795_Valid
		{
			get
			{
				short num = (short)1296957440;
				short num2 = num;
				num = (short)293901594;
				short num3 = num;
				num = (short)1402049818;
				switch (num3 == num)
				{
				}
				num = (short)1135017984;
				if (num != 0)
				{
				}
				num = (short)1805058049;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Valid;
			}
			set
			{
				short num = (short)632619008;
				short num2 = num;
				num = (short)353274317;
				short num3 = num;
				num = (short)2123860429;
				switch (num3 == num)
				{
				}
				num = (short)1304035329;
				if (num != 0)
				{
				}
				num = (short)993329152;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Valid = value;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x002F7394 File Offset: 0x002F5594
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x002F7448 File Offset: 0x002F5648
		public bool RadWideAdvancedCyclicKeying_A7795_Visible
		{
			get
			{
				short num = (short)1232338944;
				short num2 = num;
				num = (short)565044756;
				short num3 = num;
				num = (short)359065108;
				switch (num3 == num)
				{
				}
				num = (short)306053121;
				if (num != 0)
				{
				}
				num = (short)1733558272;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Visible;
			}
			set
			{
				short num = (short)1000407040;
				short num2 = num;
				num = (short)1283588097;
				if (num != 0)
				{
				}
				num = (short)1141949176;
				short num3 = num;
				num = (short)832684792;
				switch (num3 == num)
				{
				}
				num = (short)2068316160;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Visible = value;
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x002F74FC File Offset: 0x002F56FC
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x002F75B0 File Offset: 0x002F57B0
		public bool RadWideAdvancedCyclicKeying_A7795_Editable
		{
			get
			{
				short num = (short)1069350912;
				short num2 = num;
				num = (short)619548354;
				short num3 = num;
				num = (short)1373081282;
				switch (num3 == num)
				{
				}
				num = (short)140640257;
				if (num != 0)
				{
				}
				num = (short)1647050752;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.Editable;
			}
			set
			{
				short num = (short)114098176;
				short num2 = num;
				num = (short)953035176;
				short num3 = num;
				num = (short)1121986984;
				switch (num3 == num)
				{
				}
				num = (short)167313409;
				if (num != 0)
				{
				}
				num = (short)912982016;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.Editable = value;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x002F7668 File Offset: 0x002F5868
		internal string RadWideAdvancedCyclicKeying_A7795_UILabel
		{
			get
			{
				short num = (short)213057536;
				short num2 = num;
				num = (short)1703845454;
				short num3 = num;
				num = (short)1887018574;
				switch (num3 == num)
				{
				}
				num = (short)354025473;
				if (num != 0)
				{
				}
				num = (short)938475520;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.UIName;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x002F771C File Offset: 0x002F591C
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x002F77D4 File Offset: 0x002F59D4
		internal bool RadWideAdvancedCyclicKeying_A7795_HiddenStatic
		{
			get
			{
				short num = (short)330825728;
				short num2 = num;
				num = (short)97471694;
				short num3 = num;
				num = (short)1768574158;
				switch (num3 == num)
				{
				}
				num = (short)1330708480;
				if (num != 0)
				{
				}
				num = (short)516751361;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.HiddenStatic;
			}
			set
			{
				short num = (short)1030684672;
				short num2 = num;
				num = (short)1951084842;
				short num3 = num;
				num = (short)2016227626;
				switch (num3 == num)
				{
				}
				num = (short)1979645953;
				if (num != 0)
				{
				}
				num = (short)1713504256;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.HiddenStatic = value;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x002F7888 File Offset: 0x002F5A88
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x002F793C File Offset: 0x002F5B3C
		internal bool RadWideAdvancedCyclicKeying_A7795_HiddenDynamic
		{
			get
			{
				short num = (short)1213399040;
				short num2 = num;
				num = (short)372375553;
				if (num != 0)
				{
				}
				num = (short)502916796;
				short num3 = num;
				num = (short)1217521340;
				switch (num3 == num)
				{
				}
				num = (short)391774208;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795.HiddenDynamic;
			}
			set
			{
				short num = (short)1246887936;
				short num2 = num;
				num = (short)1082919406;
				short num3 = num;
				num = (short)1624377838;
				switch (num3 == num)
				{
				}
				num = (short)1202913281;
				if (num != 0)
				{
				}
				num = (short)607256576;
				if (num != 0)
				{
				}
				this.radWideAdvancedCyclicKeying_A7795.HiddenDynamic = value;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x002F79F0 File Offset: 0x002F5BF0
		public bool RadWideAdvancedCyclicKeying_A7795_HasDiffs
		{
			get
			{
				short num = (short)1157234688;
				short num2 = num;
				num = (short)1171457228;
				short num3 = num;
				num = (short)462292172;
				switch (num3 == num)
				{
				}
				num = (short)2128936961;
				if (num != 0)
				{
				}
				num = (short)1884880896;
				if (num != 0)
				{
				}
				return this.radWideAdvancedCyclicKeying_A7795._HasDiffs;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x002F7AA4 File Offset: 0x002F5CA4
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x002F7B58 File Offset: 0x002F5D58
		public bool RadWideTPSFiregroundEvacuationTone_A7980Value
		{
			get
			{
				short num = (short)765526016;
				short num2 = num;
				num = (short)1934488236;
				short num3 = num;
				num = (short)1657991852;
				switch (num3 == num)
				{
				}
				num = (short)294846465;
				if (num != 0)
				{
				}
				num = (short)1418723328;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Value;
			}
			set
			{
				short num = (short)1752498176;
				short num2 = num;
				num = (short)863561491;
				short num3 = num;
				num = (short)1009182483;
				switch (num3 == num)
				{
				}
				num = (short)1598291969;
				if (num != 0)
				{
				}
				num = (short)1205993472;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Value = value;
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x002F7C0C File Offset: 0x002F5E0C
		public global::AcpBusinessLayer.AcpField<bool> RadWideTPSFiregroundEvacuationTone_A7980
		{
			get
			{
				short num = (short)435814400;
				short num2 = num;
				num = (short)382621692;
				short num3 = num;
				num = (short)1693079548;
				switch (num3 == num)
				{
				}
				num = (short)440336385;
				if (num != 0)
				{
				}
				num = (short)1720778752;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x002F7CC0 File Offset: 0x002F5EC0
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x002F7D74 File Offset: 0x002F5F74
		public bool RadWideTPSFiregroundEvacuationTone_A7980_UIValue
		{
			get
			{
				short num = (short)1927348224;
				short num2 = num;
				num = (short)1343622107;
				short num3 = num;
				num = (short)1573587931;
				switch (num3 == num)
				{
				}
				num = (short)789446656;
				if (num != 0)
				{
				}
				num = (short)1892679681;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Value;
			}
			set
			{
				short num = (short)1722286080;
				short num2 = num;
				num = (short)1126922499;
				short num3 = num;
				num = (short)856783107;
				switch (num3 == num)
				{
				}
				num = (short)1506541568;
				if (num != 0)
				{
				}
				num = (short)1238433793;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Value = value;
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x002F7E28 File Offset: 0x002F6028
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x002F7EDC File Offset: 0x002F60DC
		public bool RadWideTPSFiregroundEvacuationTone_A7980_Applicable
		{
			get
			{
				short num = (short)83034112;
				short num2 = num;
				num = (short)1201300304;
				short num3 = num;
				num = (short)1507025744;
				switch (num3 == num)
				{
				}
				num = (short)2019033089;
				if (num != 0)
				{
				}
				num = (short)759365632;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Applicable;
			}
			set
			{
				short num = (short)427098112;
				short num2 = num;
				num = (short)1999969427;
				short num3 = num;
				num = (short)1645157523;
				switch (num3 == num)
				{
				}
				num = (short)2058551297;
				if (num != 0)
				{
				}
				num = (short)1569980416;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Applicable = value;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x002F7F90 File Offset: 0x002F6190
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x002F8044 File Offset: 0x002F6244
		public bool RadWideTPSFiregroundEvacuationTone_A7980_Valid
		{
			get
			{
				short num = (short)1264058368;
				short num2 = num;
				num = (short)1669007939;
				short num3 = num;
				num = (short)656935491;
				switch (num3 == num)
				{
				}
				num = (short)744226817;
				if (num != 0)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Valid;
			}
			set
			{
				short num = (short)1046544384;
				short num2 = num;
				num = (short)973537348;
				short num3 = num;
				num = (short)864354372;
				switch (num3 == num)
				{
				}
				num = (short)863502336;
				if (num != 0)
				{
				}
				num = (short)571473921;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Valid = value;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x002F80FC File Offset: 0x002F62FC
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x002F81B0 File Offset: 0x002F63B0
		public bool RadWideTPSFiregroundEvacuationTone_A7980_Visible
		{
			get
			{
				short num = (short)918093824;
				short num2 = num;
				num = (short)1079377921;
				if (num != 0)
				{
				}
				num = (short)2015338545;
				short num3 = num;
				num = (short)1291427889;
				switch (num3 == num)
				{
				}
				num = (short)2081816576;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Visible;
			}
			set
			{
				short num = (short)4390912;
				short num2 = num;
				num = (short)1572687598;
				short num3 = num;
				num = (short)1322012398;
				switch (num3 == num)
				{
				}
				num = (short)1802240001;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Visible = value;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x002F8268 File Offset: 0x002F6468
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x002F831C File Offset: 0x002F651C
		public bool RadWideTPSFiregroundEvacuationTone_A7980_Editable
		{
			get
			{
				short num = (short)154468352;
				short num2 = num;
				num = (short)1255525709;
				short num3 = num;
				num = (short)1009372493;
				switch (num3 == num)
				{
				}
				num = (short)1630339073;
				if (num != 0)
				{
				}
				num = (short)1788739584;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.Editable;
			}
			set
			{
				short num = (short)2090074112;
				short num2 = num;
				num = (short)1344397124;
				short num3 = num;
				num = (short)1871372100;
				switch (num3 == num)
				{
				}
				num = (short)1849884672;
				if (num != 0)
				{
				}
				num = (short)855638017;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.Editable = value;
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x002F83D0 File Offset: 0x002F65D0
		internal string RadWideTPSFiregroundEvacuationTone_A7980_UILabel
		{
			get
			{
				short num = (short)844824576;
				short num2 = num;
				num = (short)1690959873;
				if (num != 0)
				{
				}
				num = (short)438445561;
				short num3 = num;
				num = (short)368125433;
				switch (num3 == num)
				{
				}
				num = (short)146276352;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.UIName;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x002F8480 File Offset: 0x002F6680
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x002F8534 File Offset: 0x002F6734
		internal bool RadWideTPSFiregroundEvacuationTone_A7980_HiddenStatic
		{
			get
			{
				short num = (short)1740898304;
				short num2 = num;
				num = (short)1643057769;
				short num3 = num;
				num = (short)970527337;
				switch (num3 == num)
				{
				}
				num = (short)942080001;
				if (num != 0)
				{
				}
				num = (short)417202176;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.HiddenStatic;
			}
			set
			{
				short num = (short)809238528;
				short num2 = num;
				num = (short)443433790;
				short num3 = num;
				num = (short)479347518;
				switch (num3 == num)
				{
				}
				num = (short)355663873;
				if (num != 0)
				{
				}
				num = (short)2128805888;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.HiddenStatic = value;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x002F85E8 File Offset: 0x002F67E8
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x002F869C File Offset: 0x002F689C
		internal bool RadWideTPSFiregroundEvacuationTone_A7980_HiddenDynamic
		{
			get
			{
				short num = (short)646316032;
				short num2 = num;
				num = (short)1564695309;
				short num3 = num;
				num = (short)1232034573;
				switch (num3 == num)
				{
				}
				num = (short)665452545;
				if (num != 0)
				{
				}
				num = (short)888143872;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980.HiddenDynamic;
			}
			set
			{
				short num = (short)1626603520;
				short num2 = num;
				num = (short)497457644;
				short num3 = num;
				num = (short)595892716;
				switch (num3 == num)
				{
				}
				num = (short)1113063425;
				if (num != 0)
				{
				}
				num = (short)514719744;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationTone_A7980.HiddenDynamic = value;
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x002F8750 File Offset: 0x002F6950
		public bool RadWideTPSFiregroundEvacuationTone_A7980_HasDiffs
		{
			get
			{
				short num = (short)1616117760;
				short num2 = num;
				num = (short)1921572656;
				short num3 = num;
				num = (short)339074864;
				switch (num3 == num)
				{
				}
				num = (short)885325825;
				if (num != 0)
				{
				}
				num = (short)257294336;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationTone_A7980._HasDiffs;
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x002F8804 File Offset: 0x002F6A04
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x002F88BC File Offset: 0x002F6ABC
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142Value
		{
			get
			{
				short num = (short)233242624;
				short num2 = num;
				num = (short)628723787;
				short num3 = num;
				num = (short)2118750283;
				switch (num3 == num)
				{
				}
				num = (short)1215954945;
				if (num != 0)
				{
				}
				num = (short)246087680;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Value;
			}
			set
			{
				short num = (short)1040646144;
				short num2 = num;
				num = (short)161148473;
				short num3 = num;
				num = (short)26799673;
				switch (num3 == num)
				{
				}
				num = (short)1643839489;
				if (num != 0)
				{
				}
				num = (short)1835794432;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Value = value;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x002F8974 File Offset: 0x002F6B74
		public global::AcpBusinessLayer.AcpField<bool> ZnChanCfgFPPProtectionFPPEnable_A8142
		{
			get
			{
				short num = (short)1822687232;
				short num2 = num;
				num = (short)1665401962;
				short num3 = num;
				num = (short)845743210;
				switch (num3 == num)
				{
				}
				num = (short)878772225;
				if (num != 0)
				{
				}
				num = (short)1477050368;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142;
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x002F8A24 File Offset: 0x002F6C24
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x002F8AD4 File Offset: 0x002F6CD4
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_UIValue
		{
			get
			{
				short num = (short)1945239552;
				short num2 = num;
				num = (short)733010120;
				short num3 = num;
				num = (short)753260744;
				switch (num3 == num)
				{
				}
				num = (short)539492353;
				if (num != 0)
				{
				}
				num = (short)59179008;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Value;
			}
			set
			{
				short num = (short)2032467968;
				short num2 = num;
				num = (short)1041754495;
				short num3 = num;
				num = (short)1264511359;
				switch (num3 == num)
				{
				}
				num = (short)1935015937;
				if (num != 0)
				{
				}
				num = (short)195362816;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Value = value;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x002F8B8C File Offset: 0x002F6D8C
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x002F8C40 File Offset: 0x002F6E40
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_Applicable
		{
			get
			{
				short num = (short)28508160;
				short num2 = num;
				num = (short)2102286914;
				short num3 = num;
				num = (short)809720386;
				switch (num3 == num)
				{
				}
				num = (short)1061879808;
				if (num != 0)
				{
				}
				num = (short)994508801;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Applicable;
			}
			set
			{
				short num = (short)704643072;
				short num2 = num;
				num = (short)943121657;
				short num3 = num;
				num = (short)2001331449;
				switch (num3 == num)
				{
				}
				num = (short)1418788865;
				if (num != 0)
				{
				}
				num = (short)1104936960;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Applicable = value;
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x002F8CF4 File Offset: 0x002F6EF4
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x002F8DA8 File Offset: 0x002F6FA8
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_Valid
		{
			get
			{
				short num = (short)813760512;
				short num2 = num;
				num = (short)1839312188;
				short num3 = num;
				num = (short)1263447356;
				switch (num3 == num)
				{
				}
				num = (short)688390144;
				if (num != 0)
				{
				}
				num = (short)747438081;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Valid;
			}
			set
			{
				short num = (short)464977920;
				short num2 = num;
				num = (short)428258778;
				short num3 = num;
				num = (short)1574090202;
				switch (num3 == num)
				{
				}
				num = (short)1394147329;
				if (num != 0)
				{
				}
				num = (short)2015035392;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Valid = value;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x002F8E60 File Offset: 0x002F7060
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x002F8F14 File Offset: 0x002F7114
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_Visible
		{
			get
			{
				short num = (short)1509901766;
				short num2 = num;
				num = (short)2005812678;
				switch (num2 == num)
				{
				}
				num = (short)354811904;
				if (num != 0)
				{
				}
				num = (short)2094596096;
				short num3 = num;
				num = (short)125632513;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Visible;
			}
			set
			{
				short num = (short)1867576672;
				short num2 = num;
				num = (short)974386528;
				switch (num2 == num)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				num = (short)381485056;
				short num3 = num;
				num = (short)420216832;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Visible = value;
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x002F8FCC File Offset: 0x002F71CC
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x002F9084 File Offset: 0x002F7284
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_Editable
		{
			get
			{
				short num = (short)1200548265;
				short num2 = num;
				num = (short)1685645737;
				switch (num2 == num)
				{
				}
				num = (short)431554561;
				if (num != 0)
				{
				}
				num = (short)1125580800;
				short num3 = num;
				num = (short)634781696;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.Editable;
			}
			set
			{
				short num = (short)1402601473;
				if (num != 0)
				{
				}
				num = (short)1869484231;
				short num2 = num;
				num = (short)1243025607;
				switch (num2 == num)
				{
				}
				num = (short)1529151488;
				short num3 = num;
				num = (short)322764800;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.Editable = value;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x002F913C File Offset: 0x002F733C
		internal string ZnChanCfgFPPProtectionFPPEnable_A8142_UILabel
		{
			get
			{
				short num = (short)1274160353;
				short num2 = num;
				num = (short)746595553;
				switch (num2 == num)
				{
				}
				num = (short)1604714497;
				if (num != 0)
				{
				}
				num = (short)172490752;
				short num3 = num;
				num = (short)508821504;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.UIName;
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x002F91F0 File Offset: 0x002F73F0
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x002F92A4 File Offset: 0x002F74A4
		internal bool ZnChanCfgFPPProtectionFPPEnable_A8142_HiddenStatic
		{
			get
			{
				short num = (short)685339520;
				short num2 = num;
				num = (short)1591702400;
				switch (num2 == num)
				{
				}
				num = (short)2019360769;
				if (num != 0)
				{
				}
				num = (short)1769340928;
				short num3 = num;
				num = (short)1963196416;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.HiddenStatic;
			}
			set
			{
				short num = (short)2127495169;
				if (num != 0)
				{
				}
				num = (short)742227640;
				short num2 = num;
				num = (short)17727160;
				switch (num2 == num)
				{
				}
				num = (short)2053308416;
				short num3 = num;
				num = (short)1749221376;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.HiddenStatic = value;
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x002F9358 File Offset: 0x002F7558
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x002F940C File Offset: 0x002F760C
		internal bool ZnChanCfgFPPProtectionFPPEnable_A8142_HiddenDynamic
		{
			get
			{
				short num = (short)356434645;
				short num2 = num;
				num = (short)877576917;
				switch (num2 == num)
				{
				}
				num = (short)2058944513;
				if (num != 0)
				{
				}
				num = (short)653656064;
				short num3 = num;
				num = (short)1007222784;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142.HiddenDynamic;
			}
			set
			{
				short num = (short)2108611336;
				short num2 = num;
				num = (short)233233160;
				switch (num2 == num)
				{
				}
				num = (short)268369921;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				short num3 = num;
				num = (short)1584463872;
				if (num != 0)
				{
				}
				this.znChanCfgFPPProtectionFPPEnable_A8142.HiddenDynamic = value;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x002F94C0 File Offset: 0x002F76C0
		public bool ZnChanCfgFPPProtectionFPPEnable_A8142_HasDiffs
		{
			get
			{
				short num = (short)202227580;
				short num2 = num;
				num = (short)161595260;
				switch (num2 == num)
				{
				}
				num = (short)1401028609;
				if (num != 0)
				{
				}
				num = (short)328728576;
				short num3 = num;
				num = (short)1969225728;
				if (num != 0)
				{
				}
				return this.znChanCfgFPPProtectionFPPEnable_A8142._HasDiffs;
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x002F9578 File Offset: 0x002F7778
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x002F962C File Offset: 0x002F782C
		public bool RadWideAdvancedPreAmp_A8733Value
		{
			get
			{
				short num = (short)83558401;
				if (num != 0)
				{
				}
				num = (short)1941067605;
				short num2 = num;
				num = (short)852580181;
				switch (num2 == num)
				{
				}
				num = (short)1337458688;
				short num3 = num;
				num = (short)1942355968;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Value;
			}
			set
			{
				short num = (short)2050257385;
				short num2 = num;
				num = (short)617181673;
				switch (num2 == num)
				{
				}
				num = (short)1219887105;
				if (num != 0)
				{
				}
				num = (short)1615593472;
				short num3 = num;
				num = (short)1494876160;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Value = value;
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x002F96E0 File Offset: 0x002F78E0
		public global::AcpBusinessLayer.AcpField<bool> RadWideAdvancedPreAmp_A8733
		{
			get
			{
				short num = (short)1729036289;
				if (num != 0)
				{
				}
				num = (short)768339581;
				short num2 = num;
				num = (short)988606077;
				switch (num2 == num)
				{
				}
				num = (short)1783562240;
				short num3 = num;
				num = (short)987561984;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733;
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x002F9790 File Offset: 0x002F7990
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x002F9844 File Offset: 0x002F7A44
		public bool RadWideAdvancedPreAmp_A8733_UIValue
		{
			get
			{
				short num = (short)2050345618;
				short num2 = num;
				num = (short)1517669010;
				switch (num2 == num)
				{
				}
				num = (short)1030356993;
				if (num != 0)
				{
				}
				num = (short)1544224768;
				short num3 = num;
				num = (short)1345519616;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Value;
			}
			set
			{
				short num = (short)100739273;
				short num2 = num;
				num = (short)761866441;
				switch (num2 == num)
				{
				}
				num = (short)1163591680;
				if (num != 0)
				{
				}
				num = (short)342228992;
				short num3 = num;
				num = (short)1812332545;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Value = value;
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x002F98FC File Offset: 0x002F7AFC
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x002F99B4 File Offset: 0x002F7BB4
		public bool RadWideAdvancedPreAmp_A8733_Applicable
		{
			get
			{
				short num = (short)57603304;
				short num2 = num;
				num = (short)843445480;
				switch (num2 == num)
				{
				}
				num = (short)1315176449;
				if (num != 0)
				{
				}
				num = (short)151388160;
				short num3 = num;
				num = (short)2132082688;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Applicable;
			}
			set
			{
				short num = (short)1549220574;
				short num2 = num;
				num = (short)1864776414;
				switch (num2 == num)
				{
				}
				num = (short)1815543808;
				if (num != 0)
				{
				}
				num = (short)1624244224;
				short num3 = num;
				num = (short)54722561;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Applicable = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x002F9A68 File Offset: 0x002F7C68
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x002F9B20 File Offset: 0x002F7D20
		public bool RadWideAdvancedPreAmp_A8733_Valid
		{
			get
			{
				short num = (short)774707398;
				short num2 = num;
				num = (short)1068112070;
				switch (num2 == num)
				{
				}
				num = (short)696778752;
				if (num != 0)
				{
				}
				num = (short)614400000;
				short num3 = num;
				num = (short)47448065;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Valid;
			}
			set
			{
				short num = (short)1096613889;
				if (num != 0)
				{
				}
				num = (short)1541333940;
				short num2 = num;
				num = (short)362668980;
				switch (num2 == num)
				{
				}
				num = (short)1433141248;
				short num3 = num;
				num = (short)1874919424;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Valid = value;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x002F9BD8 File Offset: 0x002F7DD8
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x002F9C8C File Offset: 0x002F7E8C
		public bool RadWideAdvancedPreAmp_A8733_Visible
		{
			get
			{
				short num = (short)925001928;
				short num2 = num;
				num = (short)1516726472;
				switch (num2 == num)
				{
				}
				num = (short)1718157313;
				if (num != 0)
				{
				}
				num = (short)928186368;
				short num3 = num;
				num = (short)1756037120;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Visible;
			}
			set
			{
				short num = (short)1014437694;
				short num2 = num;
				num = (short)1000281918;
				switch (num2 == num)
				{
				}
				num = (short)1294925825;
				if (num != 0)
				{
				}
				num = (short)1791361024;
				short num3 = num;
				num = (short)416088064;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Visible = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x002F9D40 File Offset: 0x002F7F40
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x002F9DF8 File Offset: 0x002F7FF8
		public bool RadWideAdvancedPreAmp_A8733_Editable
		{
			get
			{
				short num = (short)8084239;
				short num2 = num;
				num = (short)1113086735;
				switch (num2 == num)
				{
				}
				num = (short)2121859073;
				if (num != 0)
				{
				}
				num = (short)1732902912;
				short num3 = num;
				num = (short)677642240;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.Editable;
			}
			set
			{
				short num = (short)928182721;
				short num2 = num;
				num = (short)508817857;
				switch (num2 == num)
				{
				}
				num = (short)7208961;
				if (num != 0)
				{
				}
				num = (short)650248192;
				short num3 = num;
				num = (short)1496121344;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.Editable = value;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x002F9EAC File Offset: 0x002F80AC
		internal string RadWideAdvancedPreAmp_A8733_UILabel
		{
			get
			{
				short num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)1264883517;
				short num2 = num;
				num = (short)1851168573;
				switch (num2 == num)
				{
				}
				num = (short)44826624;
				short num3 = num;
				num = (short)203096064;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.UIName;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x002F9F60 File Offset: 0x002F8160
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x002FA014 File Offset: 0x002F8214
		internal bool RadWideAdvancedPreAmp_A8733_HiddenStatic
		{
			get
			{
				short num = (short)42403724;
				short num2 = num;
				num = (short)5769100;
				switch (num2 == num)
				{
				}
				num = (short)1031995393;
				if (num != 0)
				{
				}
				num = (short)2082537472;
				short num3 = num;
				num = (short)30277632;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.HiddenStatic;
			}
			set
			{
				short num = (short)761035170;
				short num2 = num;
				num = (short)1273854370;
				switch (num2 == num)
				{
				}
				num = (short)346423296;
				if (num != 0)
				{
				}
				num = (short)900661248;
				short num3 = num;
				num = (short)1437270017;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.HiddenStatic = value;
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x002FA0CC File Offset: 0x002F82CC
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x002FA180 File Offset: 0x002F8380
		internal bool RadWideAdvancedPreAmp_A8733_HiddenDynamic
		{
			get
			{
				short num = (short)835393170;
				short num2 = num;
				num = (short)1763514002;
				switch (num2 == num)
				{
				}
				num = (short)1054277632;
				if (num != 0)
				{
				}
				num = (short)1210384384;
				short num3 = num;
				num = (short)1583153153;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733.HiddenDynamic;
			}
			set
			{
				short num = (short)140504642;
				short num2 = num;
				num = (short)913829442;
				switch (num2 == num)
				{
				}
				num = (short)1693122560;
				if (num != 0)
				{
				}
				num = (short)1111425024;
				short num3 = num;
				num = (short)421265409;
				if (num != 0)
				{
				}
				this.radWideAdvancedPreAmp_A8733.HiddenDynamic = value;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x002FA234 File Offset: 0x002F8434
		public bool RadWideAdvancedPreAmp_A8733_HasDiffs
		{
			get
			{
				short num = (short)1093406283;
				short num2 = num;
				num = (short)2118323787;
				switch (num2 == num)
				{
				}
				num = (short)1324613633;
				if (num != 0)
				{
				}
				num = (short)1934950400;
				short num3 = num;
				num = (short)58785792;
				if (num != 0)
				{
				}
				return this.radWideAdvancedPreAmp_A8733._HasDiffs;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x002FA2EC File Offset: 0x002F84EC
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x002FA3A0 File Offset: 0x002F85A0
		public int RadWideAdvancedRecordAudio_A8922Value
		{
			get
			{
				short num = (short)994602621;
				short num2 = num;
				num = (short)1912630909;
				switch (num2 == num)
				{
				}
				num = (short)914882561;
				if (num != 0)
				{
				}
				num = (short)865665024;
				short num3 = num;
				num = (short)1339883520;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.Value;
			}
			set
			{
				short num = (short)473870745;
				short num2 = num;
				num = (short)1750118809;
				switch (num2 == num)
				{
				}
				num = (short)2139684864;
				if (num != 0)
				{
				}
				num = (short)2032926720;
				short num3 = num;
				num = (short)1804992513;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.Value = value;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060030B0 RID: 12464 RVA: 0x002FA454 File Offset: 0x002F8654
		// (set) Token: 0x060030B1 RID: 12465 RVA: 0x002FA50C File Offset: 0x002F870C
		public string RadWideAdvancedRecordAudio_A8922_UIValue
		{
			get
			{
				short num = (short)543724554;
				short num2 = num;
				num = (short)723489802;
				switch (num2 == num)
				{
				}
				num = (short)2114256897;
				if (num != 0)
				{
				}
				num = (short)1009319936;
				short num3 = num;
				num = (short)1602224128;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.UIValue;
			}
			set
			{
				short num = (short)1813362196;
				short num2 = num;
				num = (short)1064482324;
				switch (num2 == num)
				{
				}
				num = (short)1012400129;
				if (num != 0)
				{
				}
				num = (short)283246592;
				short num3 = num;
				num = (short)834142208;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.UIValue = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060030B2 RID: 12466 RVA: 0x002FA5C4 File Offset: 0x002F87C4
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedRecordAudio_A8922
		{
			get
			{
				short num = (short)1095434241;
				if (num != 0)
				{
				}
				num = (short)507799224;
				short num2 = num;
				num = (short)1088186040;
				switch (num2 == num)
				{
				}
				num = (short)678952960;
				short num3 = num;
				num = (short)2147352576;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x002FA674 File Offset: 0x002F8874
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x002FA728 File Offset: 0x002F8928
		public bool RadWideAdvancedRecordAudio_A8922_Applicable
		{
			get
			{
				short num = (short)1291175037;
				short num2 = num;
				num = (short)645121149;
				switch (num2 == num)
				{
				}
				num = (short)2034892801;
				if (num != 0)
				{
				}
				num = (short)1554317312;
				short num3 = num;
				num = (short)1478754304;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.Applicable;
			}
			set
			{
				short num = (short)53283556;
				short num2 = num;
				num = (short)2093157092;
				switch (num2 == num)
				{
				}
				num = (short)784596993;
				if (num != 0)
				{
				}
				num = (short)981401600;
				short num3 = num;
				num = (short)771817472;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.Applicable = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x002FA7DC File Offset: 0x002F89DC
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x002FA890 File Offset: 0x002F8A90
		public bool RadWideAdvancedRecordAudio_A8922_Valid
		{
			get
			{
				short num = (short)493270664;
				short num2 = num;
				num = (short)1565308552;
				switch (num2 == num)
				{
				}
				num = (short)1128595457;
				if (num != 0)
				{
				}
				num = (short)2022375424;
				short num3 = num;
				num = (short)1968963584;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.Valid;
			}
			set
			{
				short num = (short)484392487;
				short num2 = num;
				num = (short)1384791591;
				switch (num2 == num)
				{
				}
				num = (short)1596325889;
				if (num != 0)
				{
				}
				num = (short)1254293504;
				short num3 = num;
				num = (short)900530176;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.Valid = value;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x002FA944 File Offset: 0x002F8B44
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x002FA9F8 File Offset: 0x002F8BF8
		public bool RadWideAdvancedRecordAudio_A8922_Visible
		{
			get
			{
				short num = (short)270598145;
				if (num != 0)
				{
				}
				num = (short)795977836;
				short num2 = num;
				num = (short)841787500;
				switch (num2 == num)
				{
				}
				num = (short)1678966784;
				short num3 = num;
				num = (short)467009536;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.Visible;
			}
			set
			{
				short num = (short)215313347;
				short num2 = num;
				num = (short)362507203;
				switch (num2 == num)
				{
				}
				num = (short)1028128769;
				if (num != 0)
				{
				}
				num = (short)1571880960;
				short num3 = num;
				num = (short)1543569408;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.Visible = value;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x002FAAB0 File Offset: 0x002F8CB0
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x002FAB68 File Offset: 0x002F8D68
		public bool RadWideAdvancedRecordAudio_A8922_Editable
		{
			get
			{
				short num = (short)47382529;
				if (num != 0)
				{
				}
				num = (short)471377729;
				short num2 = num;
				num = (short)1722787649;
				switch (num2 == num)
				{
				}
				num = (short)1236402176;
				short num3 = num;
				num = (short)805830656;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.Editable;
			}
			set
			{
				short num = (short)111869953;
				if (num != 0)
				{
				}
				num = (short)1575112596;
				short num2 = num;
				num = (short)1342001044;
				switch (num2 == num)
				{
				}
				num = (short)644939776;
				short num3 = num;
				num = (short)1358102528;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.Editable = value;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x002FAC20 File Offset: 0x002F8E20
		internal string RadWideAdvancedRecordAudio_A8922_UILabel
		{
			get
			{
				short num = (short)828532790;
				short num2 = num;
				num = (short)1489791030;
				switch (num2 == num)
				{
				}
				num = (short)190513152;
				if (num != 0)
				{
				}
				num = (short)2046623744;
				short num3 = num;
				num = (short)1760886785;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.UIName;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x002FACD4 File Offset: 0x002F8ED4
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x002FAD88 File Offset: 0x002F8F88
		internal bool RadWideAdvancedRecordAudio_A8922_HiddenStatic
		{
			get
			{
				short num = (short)1321311120;
				short num2 = num;
				num = (short)1113168784;
				switch (num2 == num)
				{
				}
				num = (short)458753;
				if (num != 0)
				{
				}
				num = (short)670498816;
				short num3 = num;
				num = (short)1766850560;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.HiddenStatic;
			}
			set
			{
				short num = (short)1819689622;
				short num2 = num;
				num = (short)229851798;
				switch (num2 == num)
				{
				}
				num = (short)669843457;
				if (num != 0)
				{
				}
				num = (short)2131099648;
				short num3 = num;
				num = (short)2087649280;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.HiddenStatic = value;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x002FAE40 File Offset: 0x002F9040
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x002FAEF4 File Offset: 0x002F90F4
		internal bool RadWideAdvancedRecordAudio_A8922_HiddenDynamic
		{
			get
			{
				short num = (short)196111687;
				short num2 = num;
				num = (short)1226140999;
				switch (num2 == num)
				{
				}
				num = (short)898236416;
				if (num != 0)
				{
				}
				num = (short)1973747712;
				short num3 = num;
				num = (short)734330881;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922.HiddenDynamic;
			}
			set
			{
				short num = (short)1795989966;
				short num2 = num;
				num = (short)849846734;
				switch (num2 == num)
				{
				}
				num = (short)1824260097;
				if (num != 0)
				{
				}
				num = (short)1542586368;
				short num3 = num;
				num = (short)426704896;
				if (num != 0)
				{
				}
				this.radWideAdvancedRecordAudio_A8922.HiddenDynamic = value;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x002FAFA8 File Offset: 0x002F91A8
		public bool RadWideAdvancedRecordAudio_A8922_HasDiffs
		{
			get
			{
				short num = (short)1048117249;
				if (num != 0)
				{
				}
				num = (short)876422054;
				short num2 = num;
				num = (short)1871455142;
				switch (num2 == num)
				{
				}
				num = (short)1026883584;
				short num3 = num;
				num = (short)1865023488;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRecordAudio_A8922._HasDiffs;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x002FB05C File Offset: 0x002F925C
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x002FB114 File Offset: 0x002F9314
		public int RadWideAdvancedRFModem_A8972Value
		{
			get
			{
				short num = (short)820370337;
				short num2 = num;
				num = (short)1981930401;
				switch (num2 == num)
				{
				}
				num = (short)1688928256;
				if (num != 0)
				{
				}
				num = (short)205258752;
				short num3 = num;
				num = (short)1889533953;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.Value;
			}
			set
			{
				short num = (short)924902367;
				short num2 = num;
				num = (short)995419103;
				switch (num2 == num)
				{
				}
				num = (short)1218969601;
				if (num != 0)
				{
				}
				num = (short)1505886208;
				short num3 = num;
				num = (short)1607860224;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.Value = value;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x002FB1C8 File Offset: 0x002F93C8
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x002FB278 File Offset: 0x002F9478
		public string RadWideAdvancedRFModem_A8972_UIValue
		{
			get
			{
				short num = (short)1715056288;
				short num2 = num;
				num = (short)1780788896;
				switch (num2 == num)
				{
				}
				num = (short)1554644993;
				if (num != 0)
				{
				}
				num = (short)1879638016;
				short num3 = num;
				num = (short)323223552;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.UIValue;
			}
			set
			{
				short num = (short)304628091;
				short num2 = num;
				num = (short)238371195;
				switch (num2 == num)
				{
				}
				num = (short)1629290496;
				if (num != 0)
				{
				}
				num = (short)405471232;
				short num3 = num;
				num = (short)1442709505;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.UIValue = value;
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x002FB330 File Offset: 0x002F9530
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedRFModem_A8972
		{
			get
			{
				short num = (short)1884946756;
				short num2 = num;
				num = (short)50069828;
				switch (num2 == num)
				{
				}
				num = (short)789577729;
				if (num != 0)
				{
				}
				num = (short)233963520;
				short num3 = num;
				num = (short)1590099968;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x002FB3E0 File Offset: 0x002F95E0
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x002FB494 File Offset: 0x002F9694
		public bool RadWideAdvancedRFModem_A8972_Applicable
		{
			get
			{
				short num = (short)567755892;
				short num2 = num;
				num = (short)1451115636;
				switch (num2 == num)
				{
				}
				num = (short)1599733761;
				if (num != 0)
				{
				}
				num = (short)181534720;
				short num3 = num;
				num = (short)1118633984;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.Applicable;
			}
			set
			{
				short num = (short)343318172;
				short num2 = num;
				num = (short)563256988;
				switch (num2 == num)
				{
				}
				num = (short)1729232896;
				if (num != 0)
				{
				}
				num = (short)516358144;
				short num3 = num;
				num = (short)179568641;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.Applicable = value;
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x002FB548 File Offset: 0x002F9748
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x002FB600 File Offset: 0x002F9800
		public bool RadWideAdvancedRFModem_A8972_Valid
		{
			get
			{
				short num = (short)1954278070;
				short num2 = num;
				num = (short)1226959542;
				switch (num2 == num)
				{
				}
				num = (short)2114977793;
				if (num != 0)
				{
				}
				num = (short)1258160128;
				short num3 = num;
				num = (short)1427570688;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.Valid;
			}
			set
			{
				short num = (short)703660033;
				if (num != 0)
				{
				}
				num = (short)1395064832;
				short num2 = num;
				num = (short)1534591903;
				short num3 = num;
				num = (short)771031967;
				switch (num3 == num)
				{
				}
				num = (short)2003763200;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.Valid = value;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x002FB6B8 File Offset: 0x002F98B8
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x002FB770 File Offset: 0x002F9970
		public bool RadWideAdvancedRFModem_A8972_Visible
		{
			get
			{
				short num = (short)1884639851;
				short num2 = num;
				num = (short)924602987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)875692032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)600309761;
				if (num != 0)
				{
				}
				num = (short)1261633536;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.Visible;
			}
			set
			{
				short num = (short)1247349051;
				short num2 = num;
				num = (short)1599146299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803419648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950023681;
				if (num != 0)
				{
				}
				num = (short)961675264;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.Visible = value;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x002FB824 File Offset: 0x002F9A24
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x002FB8D8 File Offset: 0x002F9AD8
		public bool RadWideAdvancedRFModem_A8972_Editable
		{
			get
			{
				short num = (short)1034857279;
				short num2 = num;
				num = (short)1950264127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417478144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)521404417;
				if (num != 0)
				{
				}
				num = (short)1800273920;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.Editable;
			}
			set
			{
				short num = (short)726031597;
				short num2 = num;
				num = (short)1260936429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43974656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.Editable = value;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x002FB990 File Offset: 0x002F9B90
		internal string RadWideAdvancedRFModem_A8972_UILabel
		{
			get
			{
				short num = (short)2034892801;
				if (num != 0)
				{
				}
				num = (short)1243742208;
				short num2 = num;
				num = (short)264147062;
				short num3 = num;
				num = (short)917540982;
				switch (num3 == num)
				{
				}
				num = (short)1418592256;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.UIName;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x002FBA44 File Offset: 0x002F9C44
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x002FBAFC File Offset: 0x002F9CFC
		internal bool RadWideAdvancedRFModem_A8972_HiddenStatic
		{
			get
			{
				short num = (short)1907143818;
				short num2 = num;
				num = (short)393000074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805058048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863305728;
				if (num != 0)
				{
				}
				num = (short)2144075777;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.HiddenStatic;
			}
			set
			{
				short num = (short)365980810;
				short num2 = num;
				num = (short)597978250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571749888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298385408;
				if (num != 0)
				{
				}
				num = (short)1742143489;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.HiddenStatic = value;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x002FBBB4 File Offset: 0x002F9DB4
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x002FBC6C File Offset: 0x002F9E6C
		internal bool RadWideAdvancedRFModem_A8972_HiddenDynamic
		{
			get
			{
				short num = (short)874253795;
				short num2 = num;
				num = (short)1083051491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255800832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310851072;
				if (num != 0)
				{
				}
				num = (short)1247805441;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972.HiddenDynamic;
			}
			set
			{
				short num = (short)207799114;
				short num2 = num;
				num = (short)531088202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666697728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)439156736;
				if (num != 0)
				{
				}
				num = (short)269877249;
				if (num != 0)
				{
				}
				this.radWideAdvancedRFModem_A8972.HiddenDynamic = value;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x002FBD24 File Offset: 0x002F9F24
		public bool RadWideAdvancedRFModem_A8972_HasDiffs
		{
			get
			{
				short num = (short)1264648193;
				if (num != 0)
				{
				}
				num = (short)174718976;
				short num2 = num;
				num = (short)332053461;
				short num3 = num;
				num = (short)1782102997;
				switch (num3 == num)
				{
				}
				num = (short)1535770624;
				if (num != 0)
				{
				}
				return this.radWideAdvancedRFModem_A8972._HasDiffs;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x002FBDD8 File Offset: 0x002F9FD8
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x002FBE90 File Offset: 0x002FA090
		public int RadWideFeaturesRotarySwitchScanPrgm_A8986Value
		{
			get
			{
				short num = (short)1000865793;
				if (num != 0)
				{
				}
				num = (short)1221591040;
				short num2 = num;
				num = (short)679708612;
				short num3 = num;
				num = (short)1826916292;
				switch (num3 == num)
				{
				}
				num = (short)1464270848;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.Value;
			}
			set
			{
				short num = (short)1218119189;
				short num2 = num;
				num = (short)1122240021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769734144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)604045313;
				if (num != 0)
				{
				}
				num = (short)221642752;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.Value = value;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x002FBF48 File Offset: 0x002FA148
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x002FBFF8 File Offset: 0x002FA1F8
		public string RadWideFeaturesRotarySwitchScanPrgm_A8986_UIValue
		{
			get
			{
				short num = (short)1701715429;
				short num2 = num;
				num = (short)262741477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1695416320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)848166913;
				if (num != 0)
				{
				}
				num = (short)1098973184;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.UIValue;
			}
			set
			{
				short num = (short)972357633;
				if (num != 0)
				{
				}
				num = (short)1540816896;
				short num2 = num;
				num = (short)319700576;
				short num3 = num;
				num = (short)1486700128;
				switch (num3 == num)
				{
				}
				num = (short)45481984;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.UIValue = value;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x002FC0B0 File Offset: 0x002FA2B0
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesRotarySwitchScanPrgm_A8986
		{
			get
			{
				short num = (short)1902640311;
				short num2 = num;
				num = (short)1216019639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1028849664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685979137;
				if (num != 0)
				{
				}
				num = (short)1183318016;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986;
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x002FC160 File Offset: 0x002FA360
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x002FC218 File Offset: 0x002FA418
		public bool RadWideFeaturesRotarySwitchScanPrgm_A8986_Applicable
		{
			get
			{
				short num = (short)972255322;
				short num2 = num;
				num = (short)1602056282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441333248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624689152;
				if (num != 0)
				{
				}
				num = (short)532742145;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.Applicable;
			}
			set
			{
				short num = (short)61831152;
				short num2 = num;
				num = (short)1764587504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881131520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1782251521;
				if (num != 0)
				{
				}
				num = (short)405798912;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.Applicable = value;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x002FC2CC File Offset: 0x002FA4CC
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x002FC384 File Offset: 0x002FA584
		public bool RadWideFeaturesRotarySwitchScanPrgm_A8986_Valid
		{
			get
			{
				short num = (short)49594759;
				short num2 = num;
				num = (short)413516167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066074112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1491795969;
				if (num != 0)
				{
				}
				num = (short)1423048704;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.Valid;
			}
			set
			{
				short num = (short)270321578;
				short num2 = num;
				num = (short)2087569322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)778043392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)986120193;
				if (num != 0)
				{
				}
				num = (short)1259208704;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.Valid = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x002FC43C File Offset: 0x002FA63C
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x002FC4F0 File Offset: 0x002FA6F0
		public bool RadWideFeaturesRotarySwitchScanPrgm_A8986_Visible
		{
			get
			{
				short num = (short)1653732057;
				short num2 = num;
				num = (short)1003746009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)882638848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806551553;
				if (num != 0)
				{
				}
				num = (short)111083520;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.Visible;
			}
			set
			{
				short num = (short)1934972464;
				short num2 = num;
				num = (short)1414092336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)482279424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334233600;
				if (num != 0)
				{
				}
				num = (short)1261895681;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.Visible = value;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x002FC5A4 File Offset: 0x002FA7A4
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x002FC65C File Offset: 0x002FA85C
		public bool RadWideFeaturesRotarySwitchScanPrgm_A8986_Editable
		{
			get
			{
				short num = (short)1594905767;
				short num2 = num;
				num = (short)1841058983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492975616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1572208641;
				if (num != 0)
				{
				}
				num = (short)130154496;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.Editable;
			}
			set
			{
				short num = (short)1768790596;
				short num2 = num;
				num = (short)1477745220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10223616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)305266688;
				if (num != 0)
				{
				}
				num = (short)1582235649;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.Editable = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x002FC710 File Offset: 0x002FA910
		internal string RadWideFeaturesRotarySwitchScanPrgm_A8986_UILabel
		{
			get
			{
				short num = (short)1865340884;
				short num2 = num;
				num = (short)603183060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)950009856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1984495617;
				if (num != 0)
				{
				}
				num = (short)750321664;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.UIName;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x002FC7C4 File Offset: 0x002FA9C4
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x002FC878 File Offset: 0x002FAA78
		internal bool RadWideFeaturesRotarySwitchScanPrgm_A8986_HiddenStatic
		{
			get
			{
				short num = (short)1427698411;
				short num2 = num;
				num = (short)305656555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1741881344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093940736;
				if (num != 0)
				{
				}
				num = (short)508428289;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.HiddenStatic;
			}
			set
			{
				short num = (short)1707147265;
				if (num != 0)
				{
				}
				num = (short)153419776;
				short num2 = num;
				num = (short)1882591904;
				short num3 = num;
				num = (short)1557992096;
				switch (num3 == num)
				{
				}
				num = (short)1036189696;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.HiddenStatic = value;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x002FC930 File Offset: 0x002FAB30
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x002FC9E4 File Offset: 0x002FABE4
		internal bool RadWideFeaturesRotarySwitchScanPrgm_A8986_HiddenDynamic
		{
			get
			{
				short num = (short)1586113131;
				short num2 = num;
				num = (short)402401899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534052864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2116616193;
				if (num != 0)
				{
				}
				num = (short)391839744;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986.HiddenDynamic;
			}
			set
			{
				short num = (short)508952577;
				if (num != 0)
				{
				}
				num = (short)2097414144;
				short num2 = num;
				num = (short)672907228;
				short num3 = num;
				num = (short)1753399260;
				switch (num3 == num)
				{
				}
				num = (short)1091633152;
				if (num != 0)
				{
				}
				this.radWideFeaturesRotarySwitchScanPrgm_A8986.HiddenDynamic = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x002FCA98 File Offset: 0x002FAC98
		public bool RadWideFeaturesRotarySwitchScanPrgm_A8986_HasDiffs
		{
			get
			{
				short num = (short)2038919197;
				short num2 = num;
				num = (short)2040819741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683881984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1466236928;
				if (num != 0)
				{
				}
				num = (short)1844248577;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRotarySwitchScanPrgm_A8986._HasDiffs;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x002FCB4C File Offset: 0x002FAD4C
		// (set) Token: 0x060030E8 RID: 12520 RVA: 0x002FCC00 File Offset: 0x002FAE00
		public int SwitchConventionalSwitchesPosition1_A12643Value
		{
			get
			{
				short num = (short)1529516741;
				short num2 = num;
				num = (short)1333695173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37421056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)909115392;
				if (num != 0)
				{
				}
				num = (short)2037121025;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.Value;
			}
			set
			{
				short num = (short)1707241887;
				short num2 = num;
				num = (short)2036232607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1310326784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132606976;
				if (num != 0)
				{
				}
				num = (short)357892097;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.Value = value;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x002FCCB4 File Offset: 0x002FAEB4
		// (set) Token: 0x060030EA RID: 12522 RVA: 0x002FCD68 File Offset: 0x002FAF68
		public string SwitchConventionalSwitchesPosition1_A12643_UIValue
		{
			get
			{
				short num = (short)155385857;
				if (num != 0)
				{
				}
				num = (short)1844183040;
				short num2 = num;
				num = (short)1313523740;
				short num3 = num;
				num = (short)897042460;
				switch (num3 == num)
				{
				}
				num = (short)1626144768;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.UIValue;
			}
			set
			{
				short num = (short)1260050886;
				short num2 = num;
				num = (short)1619712454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438253056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450967041;
				if (num != 0)
				{
				}
				num = (short)1650262016;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.UIValue = value;
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x002FCE1C File Offset: 0x002FB01C
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition1_A12643
		{
			get
			{
				short num = (short)1103497028;
				short num2 = num;
				num = (short)505939780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632763904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901920257;
				if (num != 0)
				{
				}
				num = (short)762511360;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x002FCECC File Offset: 0x002FB0CC
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x002FCF80 File Offset: 0x002FB180
		public bool SwitchConventionalSwitchesPosition1_A12643_Applicable
		{
			get
			{
				short num = (short)1001219100;
				short num2 = num;
				num = (short)1982358556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691484160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506003457;
				if (num != 0)
				{
				}
				num = (short)580452352;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.Applicable;
			}
			set
			{
				short num = (short)218510571;
				short num2 = num;
				num = (short)1435776235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1377828864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324941312;
				if (num != 0)
				{
				}
				num = (short)581894145;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.Applicable = value;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x002FD034 File Offset: 0x002FB234
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x002FD0E8 File Offset: 0x002FB2E8
		public bool SwitchConventionalSwitchesPosition1_A12643_Valid
		{
			get
			{
				short num = (short)656145708;
				short num2 = num;
				num = (short)1860697388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224605696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690238977;
				if (num != 0)
				{
				}
				num = (short)1366032384;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.Valid;
			}
			set
			{
				short num = (short)1102646998;
				short num2 = num;
				num = (short)1763315414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335544320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227082241;
				if (num != 0)
				{
				}
				num = (short)1784938496;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.Valid = value;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x002FD1A0 File Offset: 0x002FB3A0
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x002FD254 File Offset: 0x002FB454
		public bool SwitchConventionalSwitchesPosition1_A12643_Visible
		{
			get
			{
				short num = (short)438179530;
				short num2 = num;
				num = (short)329651914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2027749376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335296000;
				if (num != 0)
				{
				}
				num = (short)873398273;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.Visible;
			}
			set
			{
				short num = (short)1629461257;
				short num2 = num;
				num = (short)874748681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438187520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1982267393;
				if (num != 0)
				{
				}
				num = (short)611385344;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.Visible = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x002FD308 File Offset: 0x002FB508
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x002FD3BC File Offset: 0x002FB5BC
		public bool SwitchConventionalSwitchesPosition1_A12643_Editable
		{
			get
			{
				short num = (short)1087242241;
				if (num != 0)
				{
				}
				num = (short)1889206272;
				short num2 = num;
				num = (short)883358635;
				short num3 = num;
				num = (short)1492646827;
				switch (num3 == num)
				{
				}
				num = (short)91881472;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.Editable;
			}
			set
			{
				short num = (short)62164397;
				short num2 = num;
				num = (short)1902218669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)489881600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1119027200;
				if (num != 0)
				{
				}
				num = (short)1990787073;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.Editable = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x002FD470 File Offset: 0x002FB670
		internal string SwitchConventionalSwitchesPosition1_A12643_UILabel
		{
			get
			{
				short num = (short)1546485580;
				short num2 = num;
				num = (short)1126268748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19595264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719205889;
				if (num != 0)
				{
				}
				num = (short)396754944;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.UIName;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x002FD524 File Offset: 0x002FB724
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x002FD5D8 File Offset: 0x002FB7D8
		internal bool SwitchConventionalSwitchesPosition1_A12643_HiddenStatic
		{
			get
			{
				short num = (short)211923314;
				short num2 = num;
				num = (short)86225266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336737792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1165492225;
				if (num != 0)
				{
				}
				num = (short)20905984;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.HiddenStatic;
			}
			set
			{
				short num = (short)1324620297;
				short num2 = num;
				num = (short)1315117577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911867904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083703297;
				if (num != 0)
				{
				}
				num = (short)1483341824;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.HiddenStatic = value;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x002FD68C File Offset: 0x002FB88C
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x002FD744 File Offset: 0x002FB944
		internal bool SwitchConventionalSwitchesPosition1_A12643_HiddenDynamic
		{
			get
			{
				short num = (short)2027429265;
				short num2 = num;
				num = (short)1440619921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155727360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343867393;
				if (num != 0)
				{
				}
				num = (short)1798045696;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643.HiddenDynamic;
			}
			set
			{
				short num = (short)471907771;
				short num2 = num;
				num = (short)1198702011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)977993728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707278337;
				if (num != 0)
				{
				}
				num = (short)389152768;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A12643.HiddenDynamic = value;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x002FD7F8 File Offset: 0x002FB9F8
		public bool SwitchConventionalSwitchesPosition1_A12643_HasDiffs
		{
			get
			{
				short num = (short)707700095;
				short num2 = num;
				num = (short)348366207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238892544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826029569;
				if (num != 0)
				{
				}
				num = (short)1876688896;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A12643._HasDiffs;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x002FD8AC File Offset: 0x002FBAAC
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x002FD964 File Offset: 0x002FBB64
		public int RadWideFeaturesInactivityAutoPoweroff_A38013Value
		{
			get
			{
				short num = (short)578093057;
				if (num != 0)
				{
				}
				num = (short)1836711936;
				short num2 = num;
				num = (short)1756475881;
				short num3 = num;
				num = (short)849326569;
				switch (num3 == num)
				{
				}
				num = (short)1888026624;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Value;
			}
			set
			{
				short num = (short)394985473;
				if (num != 0)
				{
				}
				num = (short)1268645888;
				short num2 = num;
				num = (short)1952960801;
				short num3 = num;
				num = (short)1758646561;
				switch (num3 == num)
				{
				}
				num = (short)1897267200;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Value = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x002FDA18 File Offset: 0x002FBC18
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideFeaturesInactivityAutoPoweroff_A38013
		{
			get
			{
				short num = (short)934936577;
				if (num != 0)
				{
				}
				num = (short)1938620416;
				short num2 = num;
				num = (short)96569684;
				short num3 = num;
				num = (short)543656276;
				switch (num3 == num)
				{
				}
				num = (short)237895680;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x002FDAC8 File Offset: 0x002FBCC8
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x002FDB7C File Offset: 0x002FBD7C
		public string RadWideFeaturesInactivityAutoPoweroff_A38013_UIValue
		{
			get
			{
				short num = (short)1090093805;
				short num2 = num;
				num = (short)652641005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1595801600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572456961;
				if (num != 0)
				{
				}
				num = (short)484048896;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.UIValue;
			}
			set
			{
				short num = (short)1274337010;
				short num2 = num;
				num = (short)352900850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1357774848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779761153;
				if (num != 0)
				{
				}
				num = (short)401473536;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.UIValue = value;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x002FDC30 File Offset: 0x002FBE30
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x002FDCE4 File Offset: 0x002FBEE4
		internal int RadWideFeaturesInactivityAutoPoweroff_A38013Min
		{
			get
			{
				short num = (short)84342748;
				short num2 = num;
				num = (short)744486876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288751616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19333121;
				if (num != 0)
				{
				}
				num = (short)245497856;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Min;
			}
			set
			{
				short num = (short)753642862;
				short num2 = num;
				num = (short)51555694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1310851072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574699009;
				if (num != 0)
				{
				}
				num = (short)1764098048;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Min = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x002FDD9C File Offset: 0x002FBF9C
		// (set) Token: 0x06003102 RID: 12546 RVA: 0x002FDE54 File Offset: 0x002FC054
		internal int RadWideFeaturesInactivityAutoPoweroff_A38013Max
		{
			get
			{
				short num = (short)35388868;
				short num2 = num;
				num = (short)346881476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15990784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431764992;
				if (num != 0)
				{
				}
				num = (short)1169358849;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Max;
			}
			set
			{
				short num = (short)2029940470;
				short num2 = num;
				num = (short)378826486;
				switch (num2 == num)
				{
				}
				num = (short)1874657281;
				if (num != 0)
				{
				}
				num = (short)116588544;
				short num3 = num;
				num = (short)119603200;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Max = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x002FDF08 File Offset: 0x002FC108
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x002FDFBC File Offset: 0x002FC1BC
		internal int RadWideFeaturesInactivityAutoPoweroff_A38013Step
		{
			get
			{
				short num = (short)1413010282;
				short num2 = num;
				num = (short)2018366314;
				switch (num2 == num)
				{
				}
				num = (short)69140481;
				if (num != 0)
				{
				}
				num = (short)2014445568;
				short num3 = num;
				num = (short)1972568064;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.StepSize;
			}
			set
			{
				short num = (short)650603009;
				short num2 = num;
				num = (short)769354241;
				switch (num2 == num)
				{
				}
				num = (short)1581907969;
				if (num != 0)
				{
				}
				num = (short)1709309952;
				short num3 = num;
				num = (short)116981760;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.StepSize = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x002FE070 File Offset: 0x002FC270
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x002FE124 File Offset: 0x002FC324
		public bool RadWideFeaturesInactivityAutoPoweroff_A38013_Applicable
		{
			get
			{
				short num = (short)1199308801;
				if (num != 0)
				{
				}
				num = (short)1494187477;
				short num2 = num;
				num = (short)812285397;
				switch (num2 == num)
				{
				}
				num = (short)873922560;
				short num3 = num;
				num = (short)1171980288;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Applicable;
			}
			set
			{
				short num = (short)1426688542;
				short num2 = num;
				num = (short)334203422;
				switch (num2 == num)
				{
				}
				num = (short)1527644161;
				if (num != 0)
				{
				}
				num = (short)1136918528;
				short num3 = num;
				num = (short)1104216064;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Applicable = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x002FE1D8 File Offset: 0x002FC3D8
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x002FE28C File Offset: 0x002FC48C
		public bool RadWideFeaturesInactivityAutoPoweroff_A38013_Valid
		{
			get
			{
				short num = (short)1891937454;
				short num2 = num;
				num = (short)381725870;
				switch (num2 == num)
				{
				}
				num = (short)47972352;
				if (num != 0)
				{
				}
				num = (short)114556928;
				short num3 = num;
				num = (short)1984692225;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Valid;
			}
			set
			{
				short num = (short)1088658885;
				short num2 = num;
				num = (short)658087365;
				switch (num2 == num)
				{
				}
				num = (short)1621950464;
				if (num != 0)
				{
				}
				num = (short)1575223296;
				short num3 = num;
				num = (short)194904065;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Valid = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x002FE344 File Offset: 0x002FC544
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x002FE3F4 File Offset: 0x002FC5F4
		public bool RadWideFeaturesInactivityAutoPoweroff_A38013_Visible
		{
			get
			{
				short num = (short)401223813;
				short num2 = num;
				num = (short)354824325;
				switch (num2 == num)
				{
				}
				num = (short)931201024;
				if (num != 0)
				{
				}
				num = (short)638386176;
				short num3 = num;
				num = (short)1367277569;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Visible;
			}
			set
			{
				short num = (short)1047134209;
				if (num != 0)
				{
				}
				num = (short)683297333;
				short num2 = num;
				num = (short)548031029;
				switch (num2 == num)
				{
				}
				num = (short)222822400;
				short num3 = num;
				num = (short)1950285824;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Visible = value;
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x002FE4A8 File Offset: 0x002FC6A8
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x002FE55C File Offset: 0x002FC75C
		public bool RadWideFeaturesInactivityAutoPoweroff_A38013_Editable
		{
			get
			{
				short num = (short)1718812673;
				if (num != 0)
				{
				}
				num = (short)938721191;
				short num2 = num;
				num = (short)1578221479;
				switch (num2 == num)
				{
				}
				num = (short)355598336;
				short num3 = num;
				num = (short)354877440;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.Editable;
			}
			set
			{
				short num = (short)1213923329;
				if (num != 0)
				{
				}
				num = (short)1071721550;
				short num2 = num;
				num = (short)123546702;
				switch (num2 == num)
				{
				}
				num = (short)230031360;
				short num3 = num;
				num = (short)1494417408;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.Editable = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x002FE610 File Offset: 0x002FC810
		internal string RadWideFeaturesInactivityAutoPoweroff_A38013_UILabel
		{
			get
			{
				short num = (short)2059212448;
				short num2 = num;
				num = (short)1112151712;
				switch (num2 == num)
				{
				}
				num = (short)70320129;
				if (num != 0)
				{
				}
				num = (short)218955776;
				short num3 = num;
				num = (short)964755456;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.UIName;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x002FE6C4 File Offset: 0x002FC8C4
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x002FE778 File Offset: 0x002FC978
		internal bool RadWideFeaturesInactivityAutoPoweroff_A38013_HiddenStatic
		{
			get
			{
				short num = (short)2066602563;
				short num2 = num;
				num = (short)732617283;
				switch (num2 == num)
				{
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				num = (short)1275920384;
				short num3 = num;
				num = (short)243335169;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.HiddenStatic;
			}
			set
			{
				short num = (short)1572456395;
				short num2 = num;
				num = (short)307611595;
				switch (num2 == num)
				{
				}
				num = (short)1259995137;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				short num3 = num;
				num = (short)1352728576;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.HiddenStatic = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x002FE82C File Offset: 0x002FCA2C
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x002FE8E0 File Offset: 0x002FCAE0
		internal bool RadWideFeaturesInactivityAutoPoweroff_A38013_HiddenDynamic
		{
			get
			{
				short num = (short)896758573;
				short num2 = num;
				num = (short)1559327533;
				switch (num2 == num)
				{
				}
				num = (short)968622081;
				if (num != 0)
				{
				}
				num = (short)1929314304;
				short num3 = num;
				num = (short)1190723584;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013.HiddenDynamic;
			}
			set
			{
				short num = (short)1710975258;
				short num2 = num;
				num = (short)523987226;
				switch (num2 == num)
				{
				}
				num = (short)857931777;
				if (num != 0)
				{
				}
				num = (short)1994784768;
				short num3 = num;
				num = (short)63569920;
				if (num != 0)
				{
				}
				this.radWideFeaturesInactivityAutoPoweroff_A38013.HiddenDynamic = value;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x002FE994 File Offset: 0x002FCB94
		public bool RadWideFeaturesInactivityAutoPoweroff_A38013_HasDiffs
		{
			get
			{
				short num = (short)542223036;
				short num2 = num;
				num = (short)1969007292;
				switch (num2 == num)
				{
				}
				num = (short)983040001;
				if (num != 0)
				{
				}
				num = (short)1304166400;
				short num3 = num;
				num = (short)1358102528;
				if (num != 0)
				{
				}
				return this.radWideFeaturesInactivityAutoPoweroff_A38013._HasDiffs;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x002FEA4C File Offset: 0x002FCC4C
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x002FEB04 File Offset: 0x002FCD04
		public int RadWideFeaturesIgnitionAutoPoweroff_A38014Value
		{
			get
			{
				short num = (short)1991650464;
				short num2 = num;
				num = (short)132787360;
				switch (num2 == num)
				{
				}
				num = (short)1913323521;
				if (num != 0)
				{
				}
				num = (short)1203896320;
				short num3 = num;
				num = (short)256049152;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Value;
			}
			set
			{
				short num = (short)1794832173;
				short num2 = num;
				num = (short)88536877;
				switch (num2 == num)
				{
				}
				num = (short)27656193;
				if (num != 0)
				{
				}
				num = (short)1866661888;
				short num3 = num;
				num = (short)565575680;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Value = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x002FEBBC File Offset: 0x002FCDBC
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideFeaturesIgnitionAutoPoweroff_A38014
		{
			get
			{
				short num = (short)637206529;
				if (num != 0)
				{
				}
				num = (short)1731709059;
				short num2 = num;
				num = (short)861784195;
				switch (num2 == num)
				{
				}
				num = (short)2073034752;
				short num3 = num;
				num = (short)1914896384;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x002FEC68 File Offset: 0x002FCE68
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x002FED20 File Offset: 0x002FCF20
		public string RadWideFeaturesIgnitionAutoPoweroff_A38014_UIValue
		{
			get
			{
				short num = (short)167826778;
				short num2 = num;
				num = (short)824038746;
				switch (num2 == num)
				{
				}
				num = (short)1844641792;
				if (num != 0)
				{
				}
				num = (short)1496383488;
				short num3 = num;
				num = (short)1244987393;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.UIValue;
			}
			set
			{
				short num = (short)1057286354;
				short num2 = num;
				num = (short)1519315154;
				switch (num2 == num)
				{
				}
				num = (short)1714487297;
				if (num != 0)
				{
				}
				num = (short)1566900224;
				short num3 = num;
				num = (short)428802048;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.UIValue = value;
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x002FEDD4 File Offset: 0x002FCFD4
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x002FEE88 File Offset: 0x002FD088
		internal int RadWideFeaturesIgnitionAutoPoweroff_A38014Min
		{
			get
			{
				short num = (short)574340554;
				short num2 = num;
				num = (short)1810087370;
				switch (num2 == num)
				{
				}
				num = (short)522846208;
				if (num != 0)
				{
				}
				num = (short)879689728;
				short num3 = num;
				num = (short)779026433;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Min;
			}
			set
			{
				short num = (short)1131992410;
				short num2 = num;
				num = (short)1318638938;
				switch (num2 == num)
				{
				}
				num = (short)1265762305;
				if (num != 0)
				{
				}
				num = (short)1294270464;
				short num3 = num;
				num = (short)1321205760;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Min = value;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x002FEF40 File Offset: 0x002FD140
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x002FEFF4 File Offset: 0x002FD1F4
		internal int RadWideFeaturesIgnitionAutoPoweroff_A38014Max
		{
			get
			{
				short num = (short)211440869;
				short num2 = num;
				num = (short)137843941;
				switch (num2 == num)
				{
				}
				num = (short)32440320;
				if (num != 0)
				{
				}
				num = (short)729546752;
				short num3 = num;
				num = (short)447283201;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Max;
			}
			set
			{
				short num = (short)1845134572;
				short num2 = num;
				num = (short)1632077036;
				switch (num2 == num)
				{
				}
				num = (short)262340609;
				if (num != 0)
				{
				}
				num = (short)300941312;
				short num3 = num;
				num = (short)1278803968;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Max = value;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x002FF0AC File Offset: 0x002FD2AC
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x002FF160 File Offset: 0x002FD360
		internal int RadWideFeaturesIgnitionAutoPoweroff_A38014Step
		{
			get
			{
				short num = (short)771031041;
				if (num != 0)
				{
				}
				num = (short)982519283;
				short num2 = num;
				num = (short)182717939;
				switch (num2 == num)
				{
				}
				num = (short)1840709632;
				short num3 = num;
				num = (short)1266614272;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.StepSize;
			}
			set
			{
				short num = (short)1496358651;
				short num2 = num;
				num = (short)1516936955;
				switch (num2 == num)
				{
				}
				num = (short)519110656;
				if (num != 0)
				{
				}
				num = (short)365953024;
				short num3 = num;
				num = (short)1587740673;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.StepSize = value;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x002FF218 File Offset: 0x002FD418
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x002FF2CC File Offset: 0x002FD4CC
		public bool RadWideFeaturesIgnitionAutoPoweroff_A38014_Applicable
		{
			get
			{
				short num = (short)1317210480;
				short num2 = num;
				num = (short)119998832;
				switch (num2 == num)
				{
				}
				num = (short)605356033;
				if (num != 0)
				{
				}
				num = (short)279379968;
				short num3 = num;
				num = (short)1748631552;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Applicable;
			}
			set
			{
				short num = (short)585821874;
				short num2 = num;
				num = (short)1912860338;
				switch (num2 == num)
				{
				}
				num = (short)1792212993;
				if (num != 0)
				{
				}
				num = (short)1354629120;
				short num3 = num;
				num = (short)102367232;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Applicable = value;
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x002FF384 File Offset: 0x002FD584
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x002FF438 File Offset: 0x002FD638
		public bool RadWideFeaturesIgnitionAutoPoweroff_A38014_Valid
		{
			get
			{
				short num = (short)358150442;
				short num2 = num;
				num = (short)1145762090;
				switch (num2 == num)
				{
				}
				num = (short)268107777;
				if (num != 0)
				{
				}
				num = (short)1700331520;
				short num3 = num;
				num = (short)1162346496;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Valid;
			}
			set
			{
				short num = (short)1703404010;
				short num2 = num;
				num = (short)210952682;
				switch (num2 == num)
				{
				}
				num = (short)322437120;
				if (num != 0)
				{
				}
				num = (short)1869807616;
				short num3 = num;
				num = (short)261029889;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Valid = value;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x002FF4E8 File Offset: 0x002FD6E8
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x002FF59C File Offset: 0x002FD79C
		public bool RadWideFeaturesIgnitionAutoPoweroff_A38014_Visible
		{
			get
			{
				short num = (short)373161985;
				if (num != 0)
				{
				}
				num = (short)1093622230;
				short num2 = num;
				num = (short)1082284502;
				switch (num2 == num)
				{
				}
				num = (short)1825636352;
				short num3 = num;
				num = (short)1943142400;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Visible;
			}
			set
			{
				short num = (short)344024664;
				short num2 = num;
				num = (short)417293912;
				switch (num2 == num)
				{
				}
				num = (short)1413021697;
				if (num != 0)
				{
				}
				num = (short)1335230464;
				short num3 = num;
				num = (short)429981696;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Visible = value;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x002FF650 File Offset: 0x002FD850
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x002FF708 File Offset: 0x002FD908
		public bool RadWideFeaturesIgnitionAutoPoweroff_A38014_Editable
		{
			get
			{
				short num = (short)548586997;
				short num2 = num;
				num = (short)2085209589;
				switch (num2 == num)
				{
				}
				num = (short)1197867009;
				if (num != 0)
				{
				}
				num = (short)1807155200;
				short num3 = num;
				num = (short)1509294080;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.Editable;
			}
			set
			{
				short num = (short)1447635394;
				short num2 = num;
				num = (short)1643588034;
				switch (num2 == num)
				{
				}
				num = (short)660865025;
				if (num != 0)
				{
				}
				num = (short)864681984;
				short num3 = num;
				num = (short)387776512;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.Editable = value;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x002FF7C4 File Offset: 0x002FD9C4
		internal string RadWideFeaturesIgnitionAutoPoweroff_A38014_UILabel
		{
			get
			{
				short num = (short)2031002836;
				short num2 = num;
				num = (short)1744479444;
				switch (num2 == num)
				{
				}
				num = (short)68616193;
				if (num != 0)
				{
				}
				num = (short)1801453568;
				short num3 = num;
				num = (short)23527424;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.UIName;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x002FF87C File Offset: 0x002FDA7C
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x002FF930 File Offset: 0x002FDB30
		internal bool RadWideFeaturesIgnitionAutoPoweroff_A38014_HiddenStatic
		{
			get
			{
				short num = (short)1771542773;
				short num2 = num;
				num = (short)1840421109;
				switch (num2 == num)
				{
				}
				num = (short)704315392;
				if (num != 0)
				{
				}
				num = (short)338886656;
				short num3 = num;
				num = (short)1087635457;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.HiddenStatic;
			}
			set
			{
				short num = (short)371069163;
				short num2 = num;
				num = (short)1518801131;
				switch (num2 == num)
				{
				}
				num = (short)1062731776;
				if (num != 0)
				{
				}
				num = (short)2059534336;
				short num3 = num;
				num = (short)175833089;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.HiddenStatic = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x002FF9E4 File Offset: 0x002FDBE4
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x002FFA98 File Offset: 0x002FDC98
		internal bool RadWideFeaturesIgnitionAutoPoweroff_A38014_HiddenDynamic
		{
			get
			{
				short num = (short)2006994685;
				short num2 = num;
				num = (short)921456381;
				switch (num2 == num)
				{
				}
				num = (short)1436024833;
				if (num != 0)
				{
				}
				num = (short)741867520;
				short num3 = num;
				num = (short)767361024;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014.HiddenDynamic;
			}
			set
			{
				short num = (short)1113128961;
				if (num != 0)
				{
				}
				num = (short)1781329895;
				short num2 = num;
				num = (short)457830375;
				switch (num2 == num)
				{
				}
				num = (short)781713408;
				short num3 = num;
				num = (short)257884160;
				if (num != 0)
				{
				}
				this.radWideFeaturesIgnitionAutoPoweroff_A38014.HiddenDynamic = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x002FFB4C File Offset: 0x002FDD4C
		public bool RadWideFeaturesIgnitionAutoPoweroff_A38014_HasDiffs
		{
			get
			{
				short num = (short)648629958;
				short num2 = num;
				num = (short)361451206;
				switch (num2 == num)
				{
				}
				num = (short)549191681;
				if (num != 0)
				{
				}
				num = (short)1632829440;
				short num3 = num;
				num = (short)632815616;
				if (num != 0)
				{
				}
				return this.radWideFeaturesIgnitionAutoPoweroff_A38014._HasDiffs;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x002FFC00 File Offset: 0x002FDE00
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x002FFCB0 File Offset: 0x002FDEB0
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015Value
		{
			get
			{
				short num = (short)1057974076;
				short num2 = num;
				num = (short)1632855868;
				switch (num2 == num)
				{
				}
				num = (short)169803777;
				if (num != 0)
				{
				}
				num = (short)359071744;
				short num3 = num;
				num = (short)674299904;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Value;
			}
			set
			{
				short num = (short)1114200674;
				short num2 = num;
				num = (short)2001099362;
				switch (num2 == num)
				{
				}
				num = (short)2096300033;
				if (num != 0)
				{
				}
				num = (short)2143027200;
				short num3 = num;
				num = (short)268107776;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Value = value;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x002FFD68 File Offset: 0x002FDF68
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015
		{
			get
			{
				short num = (short)698216771;
				short num2 = num;
				num = (short)1571811651;
				switch (num2 == num)
				{
				}
				num = (short)721616897;
				if (num != 0)
				{
				}
				num = (short)1680867328;
				short num3 = num;
				num = (short)359727104;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x002FFE18 File Offset: 0x002FE018
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x002FFECC File Offset: 0x002FE0CC
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_UIValue
		{
			get
			{
				short num = (short)1349887770;
				short num2 = num;
				num = (short)1951508250;
				switch (num2 == num)
				{
				}
				num = (short)1008795648;
				if (num != 0)
				{
				}
				num = (short)2036269056;
				short num3 = num;
				num = (short)1588985857;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Value;
			}
			set
			{
				short num = (short)742181692;
				short num2 = num;
				num = (short)2007026492;
				switch (num2 == num)
				{
				}
				num = (short)1820393473;
				if (num != 0)
				{
				}
				num = (short)1031536640;
				short num3 = num;
				num = (short)319422464;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Value = value;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x002FFF80 File Offset: 0x002FE180
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00300034 File Offset: 0x002FE234
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_Applicable
		{
			get
			{
				short num = (short)1368123933;
				short num2 = num;
				num = (short)811657757;
				switch (num2 == num)
				{
				}
				num = (short)397344769;
				if (num != 0)
				{
				}
				num = (short)1616052224;
				short num3 = num;
				num = (short)243859456;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Applicable;
			}
			set
			{
				short num = (short)946560500;
				short num2 = num;
				num = (short)1371430388;
				switch (num2 == num)
				{
				}
				num = (short)1527185408;
				if (num != 0)
				{
				}
				num = (short)1690173440;
				short num3 = num;
				num = (short)1302069249;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Applicable = value;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x003000E8 File Offset: 0x002FE2E8
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x003001A0 File Offset: 0x002FE3A0
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_Valid
		{
			get
			{
				short num = (short)583802938;
				short num2 = num;
				num = (short)1677074490;
				switch (num2 == num)
				{
				}
				num = (short)2045575168;
				if (num != 0)
				{
				}
				num = (short)1338638336;
				short num3 = num;
				num = (short)2122186753;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Valid;
			}
			set
			{
				short num = (short)836163633;
				short num2 = num;
				num = (short)211408945;
				switch (num2 == num)
				{
				}
				num = (short)583204865;
				if (num != 0)
				{
				}
				num = (short)2035941376;
				short num3 = num;
				num = (short)449052672;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Valid = value;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x00300254 File Offset: 0x002FE454
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x0030030C File Offset: 0x002FE50C
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_Visible
		{
			get
			{
				short num = (short)274442833;
				short num2 = num;
				num = (short)1866246737;
				switch (num2 == num)
				{
				}
				num = (short)357433345;
				if (num != 0)
				{
				}
				num = (short)1622802432;
				short num3 = num;
				num = (short)2070282240;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Visible;
			}
			set
			{
				short num = (short)1648099503;
				short num2 = num;
				num = (short)1879048367;
				switch (num2 == num)
				{
				}
				num = (short)1902247936;
				if (num != 0)
				{
				}
				num = (short)415367168;
				short num3 = num;
				num = (short)1063256065;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Visible = value;
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x003003C0 File Offset: 0x002FE5C0
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x00300478 File Offset: 0x002FE678
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_Editable
		{
			get
			{
				short num = (short)780075009;
				if (num != 0)
				{
				}
				num = (short)418374890;
				short num2 = num;
				num = (short)2071127274;
				switch (num2 == num)
				{
				}
				num = (short)1837170688;
				short num3 = num;
				num = (short)1020526592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Editable;
			}
			set
			{
				short num = (short)720578665;
				short num2 = num;
				num = (short)1383934057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071185920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)530251776;
				if (num != 0)
				{
				}
				num = (short)1011089409;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.Editable = value;
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0030052C File Offset: 0x002FE72C
		internal string RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_UILabel
		{
			get
			{
				short num = (short)506693155;
				short num2 = num;
				num = (short)1220904483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)217710592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902168577;
				if (num != 0)
				{
				}
				num = (short)1946550272;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.UIName;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x003005E0 File Offset: 0x002FE7E0
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x00300694 File Offset: 0x002FE894
		internal bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_HiddenStatic
		{
			get
			{
				short num = (short)98899360;
				short num2 = num;
				num = (short)1545934240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804061184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312882689;
				if (num != 0)
				{
				}
				num = (short)1448673280;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.HiddenStatic;
			}
			set
			{
				short num = (short)133076135;
				short num2 = num;
				num = (short)1962906791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269891072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870528513;
				if (num != 0)
				{
				}
				num = (short)2127233024;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.HiddenStatic = value;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x0030074C File Offset: 0x002FE94C
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x00300800 File Offset: 0x002FEA00
		internal bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_HiddenDynamic
		{
			get
			{
				short num = (short)1815030000;
				short num2 = num;
				num = (short)1556162800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100270080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340211201;
				if (num != 0)
				{
				}
				num = (short)543490048;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.HiddenDynamic;
			}
			set
			{
				short num = (short)1528692737;
				if (num != 0)
				{
				}
				num = (short)942735360;
				short num2 = num;
				num = (short)1692927282;
				short num3 = num;
				num = (short)223937842;
				switch (num3 == num)
				{
				}
				num = (short)1860829184;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.HiddenDynamic = value;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x003008B4 File Offset: 0x002FEAB4
		public bool RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015_HasDiffs
		{
			get
			{
				short num = (short)1657904826;
				short num2 = num;
				num = (short)1548656314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839529984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174798337;
				if (num != 0)
				{
				}
				num = (short)2111832064;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015._HasDiffs;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x00300968 File Offset: 0x002FEB68
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x00300A20 File Offset: 0x002FEC20
		public int RadWideTransmitPowerLevelsBandSplitOverride_A41064Value
		{
			get
			{
				short num = (short)638451401;
				short num2 = num;
				num = (short)481427145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)512294912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073690112;
				if (num != 0)
				{
				}
				num = (short)1975123969;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Value;
			}
			set
			{
				short num = (short)1590634260;
				short num2 = num;
				num = (short)1650992916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243531776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019950593;
				if (num != 0)
				{
				}
				num = (short)1763770368;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Value = value;
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x00300AD4 File Offset: 0x002FECD4
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x00300B8C File Offset: 0x002FED8C
		public string RadWideTransmitPowerLevelsBandSplitOverride_A41064_UIValue
		{
			get
			{
				short num = (short)1004166018;
				short num2 = num;
				num = (short)1135631234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892941824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)205127681;
				if (num != 0)
				{
				}
				num = (short)1310982144;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.UIValue;
			}
			set
			{
				short num = (short)1523764861;
				short num2 = num;
				num = (short)298962557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396375552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545652737;
				if (num != 0)
				{
				}
				num = (short)2060451840;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.UIValue = value;
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x00300C44 File Offset: 0x002FEE44
		public global::AcpBusinessLayer.AcpListField RadWideTransmitPowerLevelsBandSplitOverride_A41064
		{
			get
			{
				short num = (short)1255361124;
				short num2 = num;
				num = (short)1768835684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485687296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)1430192128;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064;
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00300CF4 File Offset: 0x002FEEF4
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00300DA4 File Offset: 0x002FEFA4
		public bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_Applicable
		{
			get
			{
				short num = (short)300661962;
				short num2 = num;
				num = (short)508345546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259339776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)311951361;
				if (num != 0)
				{
				}
				num = (short)1225326592;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Applicable;
			}
			set
			{
				short num = (short)1568175082;
				short num2 = num;
				num = (short)442659818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081816576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)137232385;
				if (num != 0)
				{
				}
				num = (short)2139619328;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Applicable = value;
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x00300E58 File Offset: 0x002FF058
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00300F10 File Offset: 0x002FF110
		public bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_Valid
		{
			get
			{
				short num = (short)1947206102;
				short num2 = num;
				num = (short)981664214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290600448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)643432449;
				if (num != 0)
				{
				}
				num = (short)1693319168;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Valid;
			}
			set
			{
				short num = (short)189661185;
				if (num != 0)
				{
				}
				num = (short)77856768;
				short num2 = num;
				num = (short)1891125611;
				short num3 = num;
				num = (short)1070614891;
				switch (num3 == num)
				{
				}
				num = (short)604831744;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Valid = value;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00300FC8 File Offset: 0x002FF1C8
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x0030107C File Offset: 0x002FF27C
		public bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_Visible
		{
			get
			{
				short num = (short)2081473605;
				short num2 = num;
				num = (short)1162069061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37748736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299237377;
				if (num != 0)
				{
				}
				num = (short)745996288;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Visible;
			}
			set
			{
				short num = (short)1476727238;
				short num2 = num;
				num = (short)962531782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061486592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753795073;
				if (num != 0)
				{
				}
				num = (short)440795136;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Visible = value;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x00301130 File Offset: 0x002FF330
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x003011E4 File Offset: 0x002FF3E4
		public bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_Editable
		{
			get
			{
				short num = (short)1588796340;
				short num2 = num;
				num = (short)1734417332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091174400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750269953;
				if (num != 0)
				{
				}
				num = (short)940900352;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Editable;
			}
			set
			{
				short num = (short)792373296;
				short num2 = num;
				num = (short)1087809584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52494336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332857345;
				if (num != 0)
				{
				}
				num = (short)309657600;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.Editable = value;
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x0030129C File Offset: 0x002FF49C
		internal string RadWideTransmitPowerLevelsBandSplitOverride_A41064_UILabel
		{
			get
			{
				short num = (short)2013528065;
				if (num != 0)
				{
				}
				num = (short)1846607872;
				short num2 = num;
				num = (short)2091505819;
				short num3 = num;
				num = (short)420665499;
				switch (num3 == num)
				{
				}
				num = (short)110166016;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.UIName;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x00301350 File Offset: 0x002FF550
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x00301404 File Offset: 0x002FF604
		internal bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_HiddenStatic
		{
			get
			{
				short num = (short)1229620884;
				short num2 = num;
				num = (short)46958228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35454976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474218497;
				if (num != 0)
				{
				}
				num = (short)1666842624;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.HiddenStatic;
			}
			set
			{
				short num = (short)688488854;
				short num2 = num;
				num = (short)1508082070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336789504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981663745;
				if (num != 0)
				{
				}
				num = (short)439156736;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.HiddenStatic = value;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x003014B8 File Offset: 0x002FF6B8
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x0030156C File Offset: 0x002FF76C
		internal bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_HiddenDynamic
		{
			get
			{
				short num = (short)1724277608;
				short num2 = num;
				num = (short)272196456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162870784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950272001;
				if (num != 0)
				{
				}
				num = (short)1637023744;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064.HiddenDynamic;
			}
			set
			{
				short num = (short)818799639;
				short num2 = num;
				num = (short)1474225175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907687424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2128019456;
				if (num != 0)
				{
				}
				num = (short)673120257;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsBandSplitOverride_A41064.HiddenDynamic = value;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x00301620 File Offset: 0x002FF820
		public bool RadWideTransmitPowerLevelsBandSplitOverride_A41064_HasDiffs
		{
			get
			{
				short num = (short)1436003786;
				short num2 = num;
				num = (short)251702730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217200128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2025848832;
				if (num != 0)
				{
				}
				num = (short)377683969;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsBandSplitOverride_A41064._HasDiffs;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x003016D8 File Offset: 0x002FF8D8
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x0030178C File Offset: 0x002FF98C
		public int RadWideFeaturesAccessoryCableConfiguration_41997Value
		{
			get
			{
				short num = (short)919976367;
				short num2 = num;
				num = (short)690207151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624637440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135490561;
				if (num != 0)
				{
				}
				num = (short)1266286592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.Value;
			}
			set
			{
				short num = (short)1489511381;
				short num2 = num;
				num = (short)2003837909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727397888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429012480;
				if (num != 0)
				{
				}
				num = (short)973406209;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.Value = value;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x00301840 File Offset: 0x002FFA40
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x003018F4 File Offset: 0x002FFAF4
		public string RadWideFeaturesAccessoryCableConfiguration_41997_UIValue
		{
			get
			{
				short num = (short)1741488129;
				if (num != 0)
				{
				}
				num = (short)601489408;
				short num2 = num;
				num = (short)1362116871;
				short num3 = num;
				num = (short)80691463;
				switch (num3 == num)
				{
				}
				num = (short)261488640;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.UIValue;
			}
			set
			{
				short num = (short)943450422;
				short num2 = num;
				num = (short)1481697590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13959168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448280064;
				if (num != 0)
				{
				}
				num = (short)1364066305;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.UIValue = value;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x003019A8 File Offset: 0x002FFBA8
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesAccessoryCableConfiguration_41997
		{
			get
			{
				short num = (short)1833506433;
				short num2 = num;
				num = (short)81270401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162267136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408303105;
				if (num != 0)
				{
				}
				num = (short)904462336;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x00301A5C File Offset: 0x002FFC5C
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x00301B10 File Offset: 0x002FFD10
		public bool RadWideFeaturesAccessoryCableConfiguration_41997_Applicable
		{
			get
			{
				short num = (short)1237272280;
				short num2 = num;
				num = (short)268060376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210829312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1551630336;
				if (num != 0)
				{
				}
				num = (short)1988689921;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.Applicable;
			}
			set
			{
				short num = (short)1363992891;
				short num2 = num;
				num = (short)1390272827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)950403072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)301858816;
				if (num != 0)
				{
				}
				num = (short)1314914305;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.Applicable = value;
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x00301BC4 File Offset: 0x002FFDC4
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x00301C78 File Offset: 0x002FFE78
		public bool RadWideFeaturesAccessoryCableConfiguration_41997_Valid
		{
			get
			{
				short num = (short)1082029291;
				short num2 = num;
				num = (short)389248235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094189056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785252352;
				if (num != 0)
				{
				}
				num = (short)520355841;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.Valid;
			}
			set
			{
				short num = (short)1793998318;
				short num2 = num;
				num = (short)740834798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871773696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)544473089;
				if (num != 0)
				{
				}
				num = (short)1708392448;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.Valid = value;
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x00301D30 File Offset: 0x002FFF30
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x00301DE4 File Offset: 0x002FFFE4
		public bool RadWideFeaturesAccessoryCableConfiguration_41997_Visible
		{
			get
			{
				short num = (short)468860881;
				short num2 = num;
				num = (short)842481617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608384512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960902657;
				if (num != 0)
				{
				}
				num = (short)1140588544;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.Visible;
			}
			set
			{
				short num = (short)1967920162;
				short num2 = num;
				num = (short)870716450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012020736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869007360;
				if (num != 0)
				{
				}
				num = (short)294977537;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.Visible = value;
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x00301E9C File Offset: 0x0030009C
		// (set) Token: 0x0600315E RID: 12638 RVA: 0x00301F54 File Offset: 0x00300154
		public bool RadWideFeaturesAccessoryCableConfiguration_41997_Editable
		{
			get
			{
				short num = (short)1054806060;
				short num2 = num;
				num = (short)907939884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)106102784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330432513;
				if (num != 0)
				{
				}
				num = (short)378994688;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.Editable;
			}
			set
			{
				short num = (short)256798725;
				short num2 = num;
				num = (short)843149317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845348864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)81723393;
				if (num != 0)
				{
				}
				num = (short)400359424;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.Editable = value;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x0030200C File Offset: 0x0030020C
		internal string RadWideFeaturesAccessoryCableConfiguration_41997_UILabel
		{
			get
			{
				short num = (short)410979257;
				short num2 = num;
				num = (short)1789987769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1857814528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357564416;
				if (num != 0)
				{
				}
				num = (short)1163067393;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.UIName;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x003020C0 File Offset: 0x003002C0
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x00302174 File Offset: 0x00300374
		internal bool RadWideFeaturesAccessoryCableConfiguration_41997_HiddenStatic
		{
			get
			{
				short num = (short)2087366722;
				short num2 = num;
				num = (short)1271115842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2057895936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584974337;
				if (num != 0)
				{
				}
				num = (short)490995712;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.HiddenStatic;
			}
			set
			{
				short num = (short)1486159873;
				if (num != 0)
				{
				}
				num = (short)1999110144;
				short num2 = num;
				num = (short)105443613;
				short num3 = num;
				num = (short)1765994781;
				switch (num3 == num)
				{
				}
				num = (short)580452352;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.HiddenStatic = value;
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x00302224 File Offset: 0x00300424
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x003022DC File Offset: 0x003004DC
		internal bool RadWideFeaturesAccessoryCableConfiguration_41997_HiddenDynamic
		{
			get
			{
				short num = (short)1276389297;
				short num2 = num;
				num = (short)961750961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2001141760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1196228609;
				if (num != 0)
				{
				}
				num = (short)297795584;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997.HiddenDynamic;
			}
			set
			{
				short num = (short)597035961;
				short num2 = num;
				num = (short)1859849145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118161408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474939392;
				if (num != 0)
				{
				}
				num = (short)1577123841;
				if (num != 0)
				{
				}
				this.radWideFeaturesAccessoryCableConfiguration_41997.HiddenDynamic = value;
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x00302390 File Offset: 0x00300590
		public bool RadWideFeaturesAccessoryCableConfiguration_41997_HasDiffs
		{
			get
			{
				short num = (short)633637860;
				short num2 = num;
				num = (short)1040681956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98959360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264962048;
				if (num != 0)
				{
				}
				num = (short)80478209;
				if (num != 0)
				{
				}
				return this.radWideFeaturesAccessoryCableConfiguration_41997._HasDiffs;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x00302448 File Offset: 0x00300648
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x003024FC File Offset: 0x003006FC
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354Value
		{
			get
			{
				short num = (short)173582047;
				short num2 = num;
				num = (short)1727178463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1159528448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)11206657;
				if (num != 0)
				{
				}
				num = (short)810549248;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Value;
			}
			set
			{
				short num = (short)1175448144;
				short num2 = num;
				num = (short)931981904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390870528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062207489;
				if (num != 0)
				{
				}
				num = (short)357498880;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Value = value;
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x003025B4 File Offset: 0x003007B4
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesChanChangeOnOffHookEnable_A42354
		{
			get
			{
				short num = (short)2065170433;
				if (num != 0)
				{
				}
				num = (short)461504512;
				short num2 = num;
				num = (short)1234851665;
				short num3 = num;
				num = (short)1434605393;
				switch (num3 == num)
				{
				}
				num = (short)612433920;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x00302664 File Offset: 0x00300864
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x00302718 File Offset: 0x00300918
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_UIValue
		{
			get
			{
				short num = (short)299231303;
				short num2 = num;
				num = (short)124512327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675414016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329842688;
				if (num != 0)
				{
				}
				num = (short)1165623297;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Value;
			}
			set
			{
				short num = (short)73995401;
				short num2 = num;
				num = (short)416486537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861536256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749076481;
				if (num != 0)
				{
				}
				num = (short)24444928;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Value = value;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x003027CC File Offset: 0x003009CC
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x00302880 File Offset: 0x00300A80
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_Applicable
		{
			get
			{
				short num = (short)577068020;
				short num2 = num;
				num = (short)2087082996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1053949952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)115212289;
				if (num != 0)
				{
				}
				num = (short)1641414656;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Applicable;
			}
			set
			{
				short num = (short)897304170;
				short num2 = num;
				num = (short)205571690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067791872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)285016064;
				if (num != 0)
				{
				}
				num = (short)751042561;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Applicable = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x00302934 File Offset: 0x00300B34
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x003029EC File Offset: 0x00300BEC
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_Valid
		{
			get
			{
				short num = (short)1272155804;
				short num2 = num;
				num = (short)1708625564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105933824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036531201;
				if (num != 0)
				{
				}
				num = (short)442171392;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Valid;
			}
			set
			{
				short num = (short)1415010431;
				short num2 = num;
				num = (short)1074354303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613168640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470220801;
				if (num != 0)
				{
				}
				num = (short)455213056;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Valid = value;
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x00302AA0 File Offset: 0x00300CA0
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x00302B58 File Offset: 0x00300D58
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_Visible
		{
			get
			{
				short num = (short)889978881;
				if (num != 0)
				{
				}
				num = (short)1476591616;
				short num2 = num;
				num = (short)617417806;
				short num3 = num;
				num = (short)450628686;
				switch (num3 == num)
				{
				}
				num = (short)635174912;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Visible;
			}
			set
			{
				short num = (short)1651483093;
				short num2 = num;
				num = (short)1992073685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055457280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)598999041;
				if (num != 0)
				{
				}
				num = (short)2108358656;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Visible = value;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x00302C10 File Offset: 0x00300E10
		// (set) Token: 0x06003171 RID: 12657 RVA: 0x00302CC8 File Offset: 0x00300EC8
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_Editable
		{
			get
			{
				short num = (short)2086470797;
				short num2 = num;
				num = (short)1606288525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901723648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671088640;
				if (num != 0)
				{
				}
				num = (short)2070609921;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Editable;
			}
			set
			{
				short num = (short)1950265911;
				short num2 = num;
				num = (short)612872759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)438566912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273298944;
				if (num != 0)
				{
				}
				num = (short)126550017;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.Editable = value;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x00302D80 File Offset: 0x00300F80
		internal string RadWideFeaturesChanChangeOnOffHookEnable_A42354_UILabel
		{
			get
			{
				short num = (short)1762439312;
				short num2 = num;
				num = (short)265597072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561381376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1063321601;
				if (num != 0)
				{
				}
				num = (short)1753350144;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.UIName;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x00302E34 File Offset: 0x00301034
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x00302EEC File Offset: 0x003010EC
		internal bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_HiddenStatic
		{
			get
			{
				short num = (short)2062252837;
				short num2 = num;
				num = (short)753629989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519176192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299447809;
				if (num != 0)
				{
				}
				num = (short)1861877760;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.HiddenStatic;
			}
			set
			{
				short num = (short)36916098;
				short num2 = num;
				num = (short)440355714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565837824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)895811585;
				if (num != 0)
				{
				}
				num = (short)788332544;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.HiddenStatic = value;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x00302FA0 File Offset: 0x003011A0
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x00303054 File Offset: 0x00301254
		internal bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_HiddenDynamic
		{
			get
			{
				short num = (short)991656676;
				short num2 = num;
				num = (short)1829468900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561119232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686765568;
				if (num != 0)
				{
				}
				num = (short)1325400065;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354.HiddenDynamic;
			}
			set
			{
				short num = (short)1183169985;
				short num2 = num;
				num = (short)1171963329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434845184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1497497600;
				if (num != 0)
				{
				}
				num = (short)845021185;
				if (num != 0)
				{
				}
				this.radWideFeaturesChanChangeOnOffHookEnable_A42354.HiddenDynamic = value;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x00303108 File Offset: 0x00301308
		public bool RadWideFeaturesChanChangeOnOffHookEnable_A42354_HasDiffs
		{
			get
			{
				short num = (short)1126972894;
				short num2 = num;
				num = (short)83574238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1219166208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978649089;
				if (num != 0)
				{
				}
				num = (short)1752170496;
				if (num != 0)
				{
				}
				return this.radWideFeaturesChanChangeOnOffHookEnable_A42354._HasDiffs;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x003031BC File Offset: 0x003013BC
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0030326C File Offset: 0x0030146C
		public int RadWideFeaturesTargetZoneOnOffHook_A42355Value
		{
			get
			{
				short num = (short)1665877249;
				short num2 = num;
				num = (short)1044071681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560150016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)191037441;
				if (num != 0)
				{
				}
				num = (short)1026359296;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.Value;
			}
			set
			{
				short num = (short)546211748;
				short num2 = num;
				num = (short)2133165988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055471104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562692097;
				if (num != 0)
				{
				}
				num = (short)339083264;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.Value = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x00303320 File Offset: 0x00301520
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x003033D4 File Offset: 0x003015D4
		public string RadWideFeaturesTargetZoneOnOffHook_A42355_UIValue
		{
			get
			{
				short num = (short)69167400;
				short num2 = num;
				num = (short)179267880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767571456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149173761;
				if (num != 0)
				{
				}
				num = (short)1300561920;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.UIValue;
			}
			set
			{
				short num = (short)623200222;
				short num2 = num;
				num = (short)787892190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738328576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)501022721;
				if (num != 0)
				{
				}
				num = (short)1034158080;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.UIValue = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x0030348C File Offset: 0x0030168C
		public global::AcpBusinessLayer.AcpRecRefField RadWideFeaturesTargetZoneOnOffHook_A42355
		{
			get
			{
				short num = (short)456275451;
				short num2 = num;
				num = (short)957560315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055077888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546190848;
				if (num != 0)
				{
				}
				num = (short)348454913;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x0030353C File Offset: 0x0030173C
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x003035F0 File Offset: 0x003017F0
		public bool RadWideFeaturesTargetZoneOnOffHook_A42355_Applicable
		{
			get
			{
				short num = (short)126206469;
				short num2 = num;
				num = (short)899465733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2063466496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)493223936;
				if (num != 0)
				{
				}
				num = (short)248381441;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.Applicable;
			}
			set
			{
				short num = (short)238433608;
				short num2 = num;
				num = (short)1581004104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1780678656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9240577;
				if (num != 0)
				{
				}
				num = (short)1815871488;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.Applicable = value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x003036A8 File Offset: 0x003018A8
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x0030375C File Offset: 0x0030195C
		public bool RadWideFeaturesTargetZoneOnOffHook_A42355_Valid
		{
			get
			{
				short num = (short)258080769;
				if (num != 0)
				{
				}
				num = (short)618594304;
				short num2 = num;
				num = (short)153662488;
				short num3 = num;
				num = (short)1369420824;
				switch (num3 == num)
				{
				}
				num = (short)1075249152;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.Valid;
			}
			set
			{
				short num = (short)136487361;
				short num2 = num;
				num = (short)1524998593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335033856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)665321472;
				if (num != 0)
				{
				}
				num = (short)1778974721;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.Valid = value;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x00303810 File Offset: 0x00301A10
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x003038C4 File Offset: 0x00301AC4
		public bool RadWideFeaturesTargetZoneOnOffHook_A42355_Visible
		{
			get
			{
				short num = (short)1506807803;
				short num2 = num;
				num = (short)29822971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)217448448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395916801;
				if (num != 0)
				{
				}
				num = (short)2092892160;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.Visible;
			}
			set
			{
				short num = (short)1967388653;
				short num2 = num;
				num = (short)1487534061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185860096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687276032;
				if (num != 0)
				{
				}
				num = (short)1228341249;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.Visible = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0030397C File Offset: 0x00301B7C
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x00303A34 File Offset: 0x00301C34
		public bool RadWideFeaturesTargetZoneOnOffHook_A42355_Editable
		{
			get
			{
				short num = (short)111667070;
				short num2 = num;
				num = (short)1032120190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1265172480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132527616;
				if (num != 0)
				{
				}
				num = (short)2122514433;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.Editable;
			}
			set
			{
				short num = (short)389963490;
				short num2 = num;
				num = (short)336879330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)75956224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1489633280;
				if (num != 0)
				{
				}
				num = (short)562626561;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.Editable = value;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x00303AE8 File Offset: 0x00301CE8
		internal string RadWideFeaturesTargetZoneOnOffHook_A42355_UILabel
		{
			get
			{
				short num = (short)1742304732;
				short num2 = num;
				num = (short)1464825308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1736179712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				num = (short)752746497;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.UIName;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x00303B9C File Offset: 0x00301D9C
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x00303C50 File Offset: 0x00301E50
		internal bool RadWideFeaturesTargetZoneOnOffHook_A42355_HiddenStatic
		{
			get
			{
				short num = (short)96655235;
				short num2 = num;
				num = (short)1876023171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497483776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024327680;
				if (num != 0)
				{
				}
				num = (short)825294849;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.HiddenStatic;
			}
			set
			{
				short num = (short)759119160;
				short num2 = num;
				num = (short)1750940984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1458962432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821048832;
				if (num != 0)
				{
				}
				num = (short)1620836353;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.HiddenStatic = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x00303D04 File Offset: 0x00301F04
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x00303DB8 File Offset: 0x00301FB8
		internal bool RadWideFeaturesTargetZoneOnOffHook_A42355_HiddenDynamic
		{
			get
			{
				short num = (short)1641202554;
				short num2 = num;
				num = (short)648594298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438842880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)1147535360;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355.HiddenDynamic;
			}
			set
			{
				short num = (short)277963358;
				short num2 = num;
				num = (short)50487902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33161216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				num = (short)480772096;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetZoneOnOffHook_A42355.HiddenDynamic = value;
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00303E70 File Offset: 0x00302070
		public bool RadWideFeaturesTargetZoneOnOffHook_A42355_HasDiffs
		{
			get
			{
				short num = (short)1195391886;
				short num2 = num;
				num = (short)679885710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078670848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829240832;
				if (num != 0)
				{
				}
				num = (short)1582432257;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetZoneOnOffHook_A42355._HasDiffs;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x00303F28 File Offset: 0x00302128
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x00303FDC File Offset: 0x003021DC
		public int RadWideFeaturesTargetChanOnOffHook_A42356Value
		{
			get
			{
				short num = (short)943860862;
				short num2 = num;
				num = (short)1299852414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355284480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2020802561;
				if (num != 0)
				{
				}
				num = (short)965672960;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.Value;
			}
			set
			{
				short num = (short)1083215169;
				short num2 = num;
				num = (short)1505267009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1712848896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610402305;
				if (num != 0)
				{
				}
				num = (short)594083840;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.Value = value;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x00304090 File Offset: 0x00302290
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x00304148 File Offset: 0x00302348
		public string RadWideFeaturesTargetChanOnOffHook_A42356_UIValue
		{
			get
			{
				short num = (short)762400790;
				short num2 = num;
				num = (short)424235030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)703135744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319356929;
				if (num != 0)
				{
				}
				num = (short)794755072;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.UIValue;
			}
			set
			{
				short num = (short)1137293371;
				short num2 = num;
				num = (short)1781053499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775042560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896349697;
				if (num != 0)
				{
				}
				num = (short)1464336384;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.UIValue = value;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x00304200 File Offset: 0x00302400
		public global::AcpBusinessLayer.AcpRecRefField RadWideFeaturesTargetChanOnOffHook_A42356
		{
			get
			{
				short num = (short)220825788;
				short num2 = num;
				num = (short)296913084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608501760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644415489;
				if (num != 0)
				{
				}
				num = (short)744488960;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x003042AC File Offset: 0x003024AC
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x00304360 File Offset: 0x00302560
		public bool RadWideFeaturesTargetChanOnOffHook_A42356_Applicable
		{
			get
			{
				short num = (short)1229940892;
				short num2 = num;
				num = (short)292055196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435748864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703936;
				if (num != 0)
				{
				}
				num = (short)1318322177;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.Applicable;
			}
			set
			{
				short num = (short)1741422593;
				if (num != 0)
				{
				}
				num = (short)137756672;
				short num2 = num;
				num = (short)1797823513;
				short num3 = num;
				num = (short)235314201;
				switch (num3 == num)
				{
				}
				num = (short)935198720;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.Applicable = value;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x00304418 File Offset: 0x00302618
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x003044CC File Offset: 0x003026CC
		public bool RadWideFeaturesTargetChanOnOffHook_A42356_Valid
		{
			get
			{
				short num = (short)1106918211;
				short num2 = num;
				num = (short)417282883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114243072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)783286272;
				if (num != 0)
				{
				}
				num = (short)294912001;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.Valid;
			}
			set
			{
				short num = (short)1925079530;
				short num2 = num;
				num = (short)34169322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423572992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)313786368;
				if (num != 0)
				{
				}
				num = (short)1303379969;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.Valid = value;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00304580 File Offset: 0x00302780
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x00304630 File Offset: 0x00302830
		public bool RadWideFeaturesTargetChanOnOffHook_A42356_Visible
		{
			get
			{
				short num = (short)936075164;
				short num2 = num;
				num = (short)1454268316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699676160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468071937;
				if (num != 0)
				{
				}
				num = (short)1201078272;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.Visible;
			}
			set
			{
				short num = (short)2036989953;
				if (num != 0)
				{
				}
				num = (short)371326976;
				short num2 = num;
				num = (short)1378677984;
				short num3 = num;
				num = (short)795669728;
				switch (num3 == num)
				{
				}
				num = (short)61341696;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.Visible = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x003046E8 File Offset: 0x003028E8
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x003047A0 File Offset: 0x003029A0
		public bool RadWideFeaturesTargetChanOnOffHook_A42356_Editable
		{
			get
			{
				short num = (short)420003895;
				short num2 = num;
				num = (short)196984887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1368522752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127795201;
				if (num != 0)
				{
				}
				num = (short)2060582912;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.Editable;
			}
			set
			{
				short num = (short)643773790;
				short num2 = num;
				num = (short)127939934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2123759616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)561446913;
				if (num != 0)
				{
				}
				num = (short)2079784960;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.Editable = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x00304858 File Offset: 0x00302A58
		internal string RadWideFeaturesTargetChanOnOffHook_A42356_UILabel
		{
			get
			{
				short num = (short)1885470721;
				if (num != 0)
				{
				}
				num = (short)283181056;
				short num2 = num;
				num = (short)1373320027;
				short num3 = num;
				num = (short)818033499;
				switch (num3 == num)
				{
				}
				num = (short)620888064;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.UIName;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x00304910 File Offset: 0x00302B10
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x003049C4 File Offset: 0x00302BC4
		internal bool RadWideFeaturesTargetChanOnOffHook_A42356_HiddenStatic
		{
			get
			{
				short num = (short)50457043;
				short num2 = num;
				num = (short)378268115;
				switch (num2 == num)
				{
				}
				num = (short)251658240;
				short num3 = num;
				num = (short)1488191488;
				if (num != 0)
				{
				}
				num = (short)313196545;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.HiddenStatic;
			}
			set
			{
				short num = (short)1893254840;
				short num2 = num;
				num = (short)1191954104;
				switch (num2 == num)
				{
				}
				num = (short)499515392;
				short num3 = num;
				num = (short)1555365889;
				if (num != 0)
				{
				}
				num = (short)1470169088;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.HiddenStatic = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x00304A7C File Offset: 0x00302C7C
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x00304B2C File Offset: 0x00302D2C
		internal bool RadWideFeaturesTargetChanOnOffHook_A42356_HiddenDynamic
		{
			get
			{
				short num = (short)1967719488;
				short num2 = num;
				num = (short)369624128;
				switch (num2 == num)
				{
				}
				num = (short)731381760;
				short num3 = num;
				num = (short)1569849345;
				if (num != 0)
				{
				}
				num = (short)953745408;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356.HiddenDynamic;
			}
			set
			{
				short num = (short)1839545782;
				short num2 = num;
				num = (short)774585782;
				switch (num2 == num)
				{
				}
				num = (short)1883373568;
				short num3 = num;
				num = (short)898105344;
				if (num != 0)
				{
				}
				num = (short)1253179393;
				if (num != 0)
				{
				}
				this.radWideFeaturesTargetChanOnOffHook_A42356.HiddenDynamic = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x00304BE4 File Offset: 0x00302DE4
		public bool RadWideFeaturesTargetChanOnOffHook_A42356_HasDiffs
		{
			get
			{
				short num = (short)319267441;
				short num2 = num;
				num = (short)1395434097;
				switch (num2 == num)
				{
				}
				num = (short)210829312;
				short num3 = num;
				num = (short)25886720;
				if (num != 0)
				{
				}
				num = (short)1356267521;
				if (num != 0)
				{
				}
				return this.radWideFeaturesTargetChanOnOffHook_A42356._HasDiffs;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x00304C94 File Offset: 0x00302E94
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x00304D48 File Offset: 0x00302F48
		public int RadWideFeaturesVoiceAbsenceTimer_42458Value
		{
			get
			{
				short num = (short)361693185;
				if (num != 0)
				{
				}
				num = (short)1647386965;
				short num2 = num;
				num = (short)51847509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389494272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1911685120;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Value;
			}
			set
			{
				short num = (short)1110058562;
				short num2 = num;
				num = (short)440411714;
				switch (num2 == num)
				{
				}
				num = (short)105906176;
				short num3 = num;
				num = (short)243073025;
				if (num != 0)
				{
				}
				num = (short)152109056;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Value = value;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00304DFC File Offset: 0x00302FFC
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideFeaturesVoiceAbsenceTimer_42458
		{
			get
			{
				short num = (short)615636800;
				short num2 = num;
				num = (short)650239808;
				switch (num2 == num)
				{
				}
				num = (short)1718616064;
				short num3 = num;
				num = (short)880476161;
				if (num != 0)
				{
				}
				num = (short)1406205952;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x00304EAC File Offset: 0x003030AC
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x00304F60 File Offset: 0x00303160
		public string RadWideFeaturesVoiceAbsenceTimer_42458_UIValue
		{
			get
			{
				short num = (short)1725409243;
				short num2 = num;
				num = (short)876914651;
				switch (num2 == num)
				{
				}
				num = (short)136708096;
				short num3 = num;
				num = (short)1104674817;
				if (num != 0)
				{
				}
				num = (short)888209408;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.UIValue;
			}
			set
			{
				short num = (short)1117988008;
				short num2 = num;
				num = (short)382870696;
				switch (num2 == num)
				{
				}
				num = (short)1552351232;
				short num3 = num;
				num = (short)1271136256;
				if (num != 0)
				{
				}
				num = (short)1242234881;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.UIValue = value;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x00305014 File Offset: 0x00303214
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x003050C8 File Offset: 0x003032C8
		internal int RadWideFeaturesVoiceAbsenceTimer_42458Min
		{
			get
			{
				short num = (short)1974828705;
				short num2 = num;
				num = (short)241270433;
				switch (num2 == num)
				{
				}
				num = (short)533069824;
				short num3 = num;
				num = (short)143130624;
				if (num != 0)
				{
				}
				num = (short)1203437569;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Min;
			}
			set
			{
				short num = (short)515924113;
				short num2 = num;
				num = (short)254435473;
				switch (num2 == num)
				{
				}
				num = (short)1756495872;
				short num3 = num;
				num = (short)1669136384;
				if (num != 0)
				{
				}
				num = (short)937689089;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Min = value;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x0030517C File Offset: 0x0030337C
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x00305230 File Offset: 0x00303430
		internal int RadWideFeaturesVoiceAbsenceTimer_42458Max
		{
			get
			{
				short num = (short)1403266256;
				short num2 = num;
				num = (short)139666640;
				switch (num2 == num)
				{
				}
				num = (short)1783234560;
				short num3 = num;
				num = (short)1378222081;
				if (num != 0)
				{
				}
				num = (short)979566592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Max;
			}
			set
			{
				short num = (short)2129937138;
				short num2 = num;
				num = (short)1937457906;
				switch (num2 == num)
				{
				}
				num = (short)412352512;
				short num3 = num;
				num = (short)353697793;
				if (num != 0)
				{
				}
				num = (short)1110245376;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Max = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x003052E4 File Offset: 0x003034E4
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00305398 File Offset: 0x00303598
		internal int RadWideFeaturesVoiceAbsenceTimer_42458Step
		{
			get
			{
				short num = (short)1608515585;
				if (num != 0)
				{
				}
				num = (short)1990233777;
				short num2 = num;
				num = (short)1987022513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021588992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982384640;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.StepSize;
			}
			set
			{
				short num = (short)1096220673;
				if (num != 0)
				{
				}
				num = (short)2070272691;
				short num2 = num;
				num = (short)245488307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317142528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131072000;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.StepSize = value;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x0030544C File Offset: 0x0030364C
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00305500 File Offset: 0x00303700
		public bool RadWideFeaturesVoiceAbsenceTimer_42458_Applicable
		{
			get
			{
				short num = (short)808874840;
				short num2 = num;
				num = (short)556888920;
				switch (num2 == num)
				{
				}
				num = (short)660144128;
				short num3 = num;
				num = (short)7667713;
				if (num != 0)
				{
				}
				num = (short)2121465856;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Applicable;
			}
			set
			{
				short num = (short)1544992682;
				short num2 = num;
				num = (short)2113583018;
				switch (num2 == num)
				{
				}
				num = (short)1158283264;
				short num3 = num;
				num = (short)1200947200;
				if (num != 0)
				{
				}
				num = (short)48955393;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Applicable = value;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x003055B4 File Offset: 0x003037B4
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00305668 File Offset: 0x00303868
		public bool RadWideFeaturesVoiceAbsenceTimer_42458_Valid
		{
			get
			{
				short num = (short)2877732;
				short num2 = num;
				num = (short)954919204;
				switch (num2 == num)
				{
				}
				num = (short)327745536;
				short num3 = num;
				num = (short)29097984;
				if (num != 0)
				{
				}
				num = (short)931856385;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Valid;
			}
			set
			{
				short num = (short)2024554326;
				short num2 = num;
				num = (short)676413270;
				switch (num2 == num)
				{
				}
				num = (short)1739915264;
				short num3 = num;
				num = (short)1604780033;
				if (num != 0)
				{
				}
				num = (short)1290731520;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Valid = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x00305720 File Offset: 0x00303920
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x003057D4 File Offset: 0x003039D4
		public bool RadWideFeaturesVoiceAbsenceTimer_42458_Visible
		{
			get
			{
				short num = (short)338792771;
				short num2 = num;
				num = (short)1946915139;
				switch (num2 == num)
				{
				}
				num = (short)1627914240;
				short num3 = num;
				num = (short)1148059649;
				if (num != 0)
				{
				}
				num = (short)1616379904;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Visible;
			}
			set
			{
				short num = (short)2071113885;
				short num2 = num;
				num = (short)1647685789;
				switch (num2 == num)
				{
				}
				num = (short)637861888;
				short num3 = num;
				num = (short)921436160;
				if (num != 0)
				{
				}
				num = (short)1535115265;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Visible = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x00305888 File Offset: 0x00303A88
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x0030593C File Offset: 0x00303B3C
		public bool RadWideFeaturesVoiceAbsenceTimer_42458_Editable
		{
			get
			{
				short num = (short)1551365354;
				short num2 = num;
				num = (short)1069479146;
				switch (num2 == num)
				{
				}
				num = (short)635699200;
				short num3 = num;
				num = (short)66912257;
				if (num != 0)
				{
				}
				num = (short)879951872;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.Editable;
			}
			set
			{
				short num = (short)1178718056;
				short num2 = num;
				num = (short)169267048;
				switch (num2 == num)
				{
				}
				num = (short)802750464;
				short num3 = num;
				num = (short)1747910656;
				if (num != 0)
				{
				}
				num = (short)1167196161;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.Editable = value;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x003059F0 File Offset: 0x00303BF0
		internal string RadWideFeaturesVoiceAbsenceTimer_42458_UILabel
		{
			get
			{
				short num = (short)631373825;
				if (num != 0)
				{
				}
				num = (short)958849132;
				short num2 = num;
				num = (short)1541398636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435303936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267793920;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.UIName;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x00305AA8 File Offset: 0x00303CA8
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x00305B60 File Offset: 0x00303D60
		internal bool RadWideFeaturesVoiceAbsenceTimer_42458_HiddenStatic
		{
			get
			{
				short num = (short)805494594;
				short num2 = num;
				num = (short)213245762;
				switch (num2 == num)
				{
				}
				num = (short)108265472;
				short num3 = num;
				num = (short)974061568;
				if (num != 0)
				{
				}
				num = (short)1191575553;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.HiddenStatic;
			}
			set
			{
				short num = (short)773298658;
				short num2 = num;
				num = (short)566729186;
				switch (num2 == num)
				{
				}
				num = (short)1297219584;
				short num3 = num;
				num = (short)853475328;
				if (num != 0)
				{
				}
				num = (short)1090519041;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.HiddenStatic = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x00305C14 File Offset: 0x00303E14
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x00305CC8 File Offset: 0x00303EC8
		internal bool RadWideFeaturesVoiceAbsenceTimer_42458_HiddenDynamic
		{
			get
			{
				short num = (short)1861650113;
				short num2 = num;
				num = (short)1912899265;
				switch (num2 == num)
				{
				}
				num = (short)1869873152;
				short num3 = num;
				num = (short)130416640;
				if (num != 0)
				{
				}
				num = (short)745930753;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458.HiddenDynamic;
			}
			set
			{
				short num = (short)27841373;
				short num2 = num;
				num = (short)889312093;
				switch (num2 == num)
				{
				}
				num = (short)985333760;
				short num3 = num;
				num = (short)1342570497;
				if (num != 0)
				{
				}
				num = (short)1667629056;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceAbsenceTimer_42458.HiddenDynamic = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x00305D80 File Offset: 0x00303F80
		public bool RadWideFeaturesVoiceAbsenceTimer_42458_HasDiffs
		{
			get
			{
				short num = (short)749753468;
				short num2 = num;
				num = (short)1448367228;
				switch (num2 == num)
				{
				}
				num = (short)1854144512;
				short num3 = num;
				num = (short)1627389952;
				if (num != 0)
				{
				}
				num = (short)664731649;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceAbsenceTimer_42458._HasDiffs;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x00305E30 File Offset: 0x00304030
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00305EE4 File Offset: 0x003040E4
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927Value
		{
			get
			{
				short num = (short)916499681;
				short num2 = num;
				num = (short)309701857;
				switch (num2 == num)
				{
				}
				num = (short)208207872;
				short num3 = num;
				num = (short)1761935360;
				if (num != 0)
				{
				}
				num = (short)1709506561;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Value;
			}
			set
			{
				short num = (short)1760776131;
				short num2 = num;
				num = (short)1017204675;
				switch (num2 == num)
				{
				}
				num = (short)2050555904;
				short num3 = num;
				num = (short)1927479296;
				if (num != 0)
				{
				}
				num = (short)147193857;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Value = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x00305F98 File Offset: 0x00304198
		public global::AcpBusinessLayer.AcpField<bool> IsolatedGCAIAccessoryPlugAndPlayDisable_42927
		{
			get
			{
				short num = (short)288670351;
				short num2 = num;
				num = (short)1308279439;
				switch (num2 == num)
				{
				}
				num = (short)1239351296;
				short num3 = num;
				num = (short)1887436801;
				if (num != 0)
				{
				}
				num = (short)236912640;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x00306048 File Offset: 0x00304248
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x00306100 File Offset: 0x00304300
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_UIValue
		{
			get
			{
				short num = (short)1443673122;
				short num2 = num;
				num = (short)1599714338;
				switch (num2 == num)
				{
				}
				num = (short)327811072;
				short num3 = num;
				num = (short)1002766336;
				if (num != 0)
				{
				}
				num = (short)1320484865;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Value;
			}
			set
			{
				short num = (short)654144783;
				short num2 = num;
				num = (short)1361540367;
				switch (num2 == num)
				{
				}
				num = (short)221577216;
				short num3 = num;
				num = (short)880869376;
				if (num != 0)
				{
				}
				num = (short)586219521;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Value = value;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x003061B8 File Offset: 0x003043B8
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x00306270 File Offset: 0x00304470
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_Applicable
		{
			get
			{
				short num = (short)2129309476;
				short num2 = num;
				num = (short)1295822628;
				switch (num2 == num)
				{
				}
				num = (short)393150464;
				short num3 = num;
				num = (short)382992385;
				if (num != 0)
				{
				}
				num = (short)275906560;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Applicable;
			}
			set
			{
				short num = (short)1329320771;
				short num2 = num;
				num = (short)1171641155;
				switch (num2 == num)
				{
				}
				num = (short)2101542912;
				short num3 = num;
				num = (short)745013249;
				if (num != 0)
				{
				}
				num = (short)2077032448;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Applicable = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x00306328 File Offset: 0x00304528
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x003063E0 File Offset: 0x003045E0
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_Valid
		{
			get
			{
				short num = (short)602537858;
				short num2 = num;
				num = (short)293994370;
				switch (num2 == num)
				{
				}
				num = (short)2083586048;
				short num3 = num;
				num = (short)429457408;
				if (num != 0)
				{
				}
				num = (short)116654081;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Valid;
			}
			set
			{
				short num = (short)581050632;
				short num2 = num;
				num = (short)427434248;
				switch (num2 == num)
				{
				}
				num = (short)679084032;
				short num3 = num;
				num = (short)1228210177;
				if (num != 0)
				{
				}
				num = (short)1218445312;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Valid = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x00306498 File Offset: 0x00304698
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x0030654C File Offset: 0x0030474C
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_Visible
		{
			get
			{
				short num = (short)693977352;
				short num2 = num;
				num = (short)1536246024;
				switch (num2 == num)
				{
				}
				num = (short)423559168;
				short num3 = num;
				num = (short)1456144385;
				if (num != 0)
				{
				}
				num = (short)465436672;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Visible;
			}
			set
			{
				short num = (short)971117900;
				short num2 = num;
				num = (short)658707788;
				switch (num2 == num)
				{
				}
				num = (short)274006016;
				short num3 = num;
				num = (short)615514113;
				if (num != 0)
				{
				}
				num = (short)488112128;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Visible = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x00306604 File Offset: 0x00304804
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x003066BC File Offset: 0x003048BC
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_Editable
		{
			get
			{
				short num = (short)1939950910;
				short num2 = num;
				num = (short)1106464062;
				switch (num2 == num)
				{
				}
				num = (short)1046216704;
				short num3 = num;
				num = (short)1541734400;
				if (num != 0)
				{
				}
				num = (short)1639579649;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Editable;
			}
			set
			{
				short num = (short)665970021;
				short num2 = num;
				num = (short)968615269;
				switch (num2 == num)
				{
				}
				num = (short)1528299520;
				short num3 = num;
				num = (short)1486815233;
				if (num != 0)
				{
				}
				num = (short)140443648;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.Editable = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x00306774 File Offset: 0x00304974
		internal string IsolatedGCAIAccessoryPlugAndPlayDisable_42927_UILabel
		{
			get
			{
				short num = (short)919546733;
				short num2 = num;
				num = (short)1754409837;
				switch (num2 == num)
				{
				}
				num = (short)1802895360;
				short num3 = num;
				num = (short)877854721;
				if (num != 0)
				{
				}
				num = (short)140312576;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.UIName;
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x0030682C File Offset: 0x00304A2C
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x003068E4 File Offset: 0x00304AE4
		internal bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_HiddenStatic
		{
			get
			{
				short num = (short)324745626;
				short num2 = num;
				num = (short)635517338;
				switch (num2 == num)
				{
				}
				num = (short)1045037056;
				short num3 = num;
				num = (short)1678573568;
				if (num != 0)
				{
				}
				num = (short)937492481;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.HiddenStatic;
			}
			set
			{
				short num = (short)1222453290;
				short num2 = num;
				num = (short)1937057834;
				switch (num2 == num)
				{
				}
				num = (short)1091371008;
				short num3 = num;
				num = (short)1984626689;
				if (num != 0)
				{
				}
				num = (short)2070282240;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.HiddenStatic = value;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x00306998 File Offset: 0x00304B98
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x00306A4C File Offset: 0x00304C4C
		internal bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_HiddenDynamic
		{
			get
			{
				short num = (short)1506952139;
				short num2 = num;
				num = (short)205800395;
				switch (num2 == num)
				{
				}
				num = (short)450691072;
				short num3 = num;
				num = (short)764018689;
				if (num != 0)
				{
				}
				num = (short)915996672;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.HiddenDynamic;
			}
			set
			{
				short num = (short)1671125287;
				short num2 = num;
				num = (short)1770674471;
				switch (num2 == num)
				{
				}
				num = (short)849936384;
				short num3 = num;
				num = (short)1023672321;
				if (num != 0)
				{
				}
				num = (short)332267520;
				if (num != 0)
				{
				}
				this.isolatedGCAIAccessoryPlugAndPlayDisable_42927.HiddenDynamic = value;
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x00306B00 File Offset: 0x00304D00
		public bool IsolatedGCAIAccessoryPlugAndPlayDisable_42927_HasDiffs
		{
			get
			{
				short num = (short)1225436305;
				short num2 = num;
				num = (short)1666624657;
				switch (num2 == num)
				{
				}
				num = (short)1597440000;
				short num3 = num;
				num = (short)709296129;
				if (num != 0)
				{
				}
				num = (short)1345060864;
				if (num != 0)
				{
				}
				return this.isolatedGCAIAccessoryPlugAndPlayDisable_42927._HasDiffs;
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x00306BB4 File Offset: 0x00304DB4
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x00306C6C File Offset: 0x00304E6C
		public bool RadWideFeaturePreAmpVHF_A42960Value
		{
			get
			{
				short num = (short)1267369782;
				short num2 = num;
				num = (short)1658226486;
				switch (num2 == num)
				{
				}
				num = (short)1860960256;
				short num3 = num;
				num = (short)1208614912;
				if (num != 0)
				{
				}
				num = (short)2128740353;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Value;
			}
			set
			{
				short num = (short)636283972;
				short num2 = num;
				num = (short)1157688388;
				switch (num2 == num)
				{
				}
				num = (short)1574240256;
				short num3 = num;
				num = (short)1256652801;
				if (num != 0)
				{
				}
				num = (short)2043478016;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Value = value;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x00306D20 File Offset: 0x00304F20
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturePreAmpVHF_A42960
		{
			get
			{
				short num = (short)600063285;
				short num2 = num;
				num = (short)1064245;
				switch (num2 == num)
				{
				}
				num = (short)1017511936;
				short num3 = num;
				num = (short)802422785;
				if (num != 0)
				{
				}
				num = (short)338100224;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x00306DD0 File Offset: 0x00304FD0
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x00306E84 File Offset: 0x00305084
		public bool RadWideFeaturePreAmpVHF_A42960_UIValue
		{
			get
			{
				short num = (short)776722195;
				short num2 = num;
				num = (short)608229139;
				switch (num2 == num)
				{
				}
				num = (short)1587085312;
				short num3 = num;
				num = (short)1842675713;
				if (num != 0)
				{
				}
				num = (short)847773696;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Value;
			}
			set
			{
				short num = (short)1427371527;
				short num2 = num;
				num = (short)550434311;
				switch (num2 == num)
				{
				}
				num = (short)1119748096;
				short num3 = num;
				num = (short)475922433;
				if (num != 0)
				{
				}
				num = (short)2052063232;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Value = value;
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x00306F38 File Offset: 0x00305138
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x00306FEC File Offset: 0x003051EC
		public bool RadWideFeaturePreAmpVHF_A42960_Applicable
		{
			get
			{
				short num = (short)20423192;
				short num2 = num;
				num = (short)207921688;
				switch (num2 == num)
				{
				}
				num = (short)1416691712;
				short num3 = num;
				num = (short)1013121025;
				if (num != 0)
				{
				}
				num = (short)479461376;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Applicable;
			}
			set
			{
				short num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)774125877;
				short num2 = num;
				num = (short)494418229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712245248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457900032;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Applicable = value;
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x003070A4 File Offset: 0x003052A4
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x0030715C File Offset: 0x0030535C
		public bool RadWideFeaturePreAmpVHF_A42960_Valid
		{
			get
			{
				short num = (short)760283137;
				if (num != 0)
				{
				}
				num = (short)774951373;
				short num2 = num;
				num = (short)310694349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113536000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2142175232;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Valid;
			}
			set
			{
				short num = (short)1004418263;
				short num2 = num;
				num = (short)144651479;
				switch (num2 == num)
				{
				}
				num = (short)1770520576;
				short num3 = num;
				num = (short)1580269569;
				if (num != 0)
				{
				}
				num = (short)686555136;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Valid = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x00307214 File Offset: 0x00305414
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x003072C8 File Offset: 0x003054C8
		public bool RadWideFeaturePreAmpVHF_A42960_Visible
		{
			get
			{
				short num = (short)394419529;
				short num2 = num;
				num = (short)2140429641;
				switch (num2 == num)
				{
				}
				num = (short)839188480;
				short num3 = num;
				num = (short)3276800;
				if (num != 0)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Visible;
			}
			set
			{
				short num = (short)2010054657;
				if (num != 0)
				{
				}
				num = (short)1697760047;
				short num2 = num;
				num = (short)1467073327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675886592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036976128;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Visible = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x0030737C File Offset: 0x0030557C
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x00307434 File Offset: 0x00305634
		public bool RadWideFeaturePreAmpVHF_A42960_Editable
		{
			get
			{
				short num = (short)57837427;
				short num2 = num;
				num = (short)1463322483;
				switch (num2 == num)
				{
				}
				num = (short)832634880;
				short num3 = num;
				num = (short)1839333377;
				if (num != 0)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.Editable;
			}
			set
			{
				short num = (short)2143854464;
				short num2 = num;
				num = (short)1841340288;
				switch (num2 == num)
				{
				}
				num = (short)1802764288;
				short num3 = num;
				num = (short)1854078977;
				if (num != 0)
				{
				}
				num = (short)150994944;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.Editable = value;
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x003074E8 File Offset: 0x003056E8
		internal string RadWideFeaturePreAmpVHF_A42960_UILabel
		{
			get
			{
				short num = (short)871104513;
				if (num != 0)
				{
				}
				num = (short)1793854434;
				short num2 = num;
				num = (short)951192546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13303808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)58458112;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.UIName;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0030759C File Offset: 0x0030579C
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00307650 File Offset: 0x00305850
		internal bool RadWideFeaturePreAmpVHF_A42960_HiddenStatic
		{
			get
			{
				short num = (short)9130847;
				short num2 = num;
				num = (short)1865831263;
				switch (num2 == num)
				{
				}
				num = (short)1312358400;
				short num3 = num;
				num = (short)1744699393;
				if (num != 0)
				{
				}
				num = (short)849936384;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.HiddenStatic;
			}
			set
			{
				short num = (short)760217601;
				if (num != 0)
				{
				}
				num = (short)1728935879;
				short num2 = num;
				num = (short)1003255751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)926023680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)782106624;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.HiddenStatic = value;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00307704 File Offset: 0x00305904
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x003077B8 File Offset: 0x003059B8
		internal bool RadWideFeaturePreAmpVHF_A42960_HiddenDynamic
		{
			get
			{
				short num = (short)1442054145;
				if (num != 0)
				{
				}
				num = (short)1089220317;
				short num2 = num;
				num = (short)563162845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56754176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356319232;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960.HiddenDynamic;
			}
			set
			{
				short num = (short)1551277570;
				short num2 = num;
				num = (short)530095618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)930283520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109210625;
				if (num != 0)
				{
				}
				num = (short)1353908224;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpVHF_A42960.HiddenDynamic = value;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x00307870 File Offset: 0x00305A70
		public bool RadWideFeaturePreAmpVHF_A42960_HasDiffs
		{
			get
			{
				short num = (short)1164734637;
				short num2 = num;
				num = (short)1416327341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525547008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333578241;
				if (num != 0)
				{
				}
				num = (short)1333526528;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpVHF_A42960._HasDiffs;
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060031DD RID: 12765 RVA: 0x00307924 File Offset: 0x00305B24
		// (set) Token: 0x060031DE RID: 12766 RVA: 0x003079D8 File Offset: 0x00305BD8
		public bool RadWideFeaturePreAmpUHF_A42962Value
		{
			get
			{
				short num = (short)2063060450;
				short num2 = num;
				num = (short)98684386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158152192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1780023297;
				if (num != 0)
				{
				}
				num = (short)1334444032;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Value;
			}
			set
			{
				short num = (short)290119565;
				short num2 = num;
				num = (short)897507213;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177092096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1088815104;
				if (num != 0)
				{
				}
				num = (short)539361281;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Value = value;
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x00307A8C File Offset: 0x00305C8C
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturePreAmpUHF_A42962
		{
			get
			{
				short num = (short)734660464;
				short num2 = num;
				num = (short)155125616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238171648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1702166529;
				if (num != 0)
				{
				}
				num = (short)227540992;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x00307B3C File Offset: 0x00305D3C
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00307BF0 File Offset: 0x00305DF0
		public bool RadWideFeaturePreAmpUHF_A42962_UIValue
		{
			get
			{
				short num = (short)186217429;
				short num2 = num;
				num = (short)889680853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933639680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547501569;
				if (num != 0)
				{
				}
				num = (short)1978466304;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Value;
			}
			set
			{
				short num = (short)966891170;
				short num2 = num;
				num = (short)501126818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400045568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260781569;
				if (num != 0)
				{
				}
				num = (short)1410465792;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Value = value;
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x00307CA8 File Offset: 0x00305EA8
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00307D60 File Offset: 0x00305F60
		public bool RadWideFeaturePreAmpUHF_A42962_Applicable
		{
			get
			{
				short num = (short)713664539;
				short num2 = num;
				num = (short)976660507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042691584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049886721;
				if (num != 0)
				{
				}
				num = (short)1743388672;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Applicable;
			}
			set
			{
				short num = (short)1852058121;
				short num2 = num;
				num = (short)449718793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118226944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)599654401;
				if (num != 0)
				{
				}
				num = (short)1846870016;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Applicable = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x00307E14 File Offset: 0x00306014
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x00307EC8 File Offset: 0x003060C8
		public bool RadWideFeaturePreAmpUHF_A42962_Valid
		{
			get
			{
				short num = (short)1602503684;
				short num2 = num;
				num = (short)1001866244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741736448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440401921;
				if (num != 0)
				{
				}
				num = (short)810811392;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Valid;
			}
			set
			{
				short num = (short)2134362935;
				short num2 = num;
				num = (short)1569180471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126774272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492568577;
				if (num != 0)
				{
				}
				num = (short)759300096;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Valid = value;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x00307F7C File Offset: 0x0030617C
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x00308034 File Offset: 0x00306234
		public bool RadWideFeaturePreAmpUHF_A42962_Visible
		{
			get
			{
				short num = (short)1673841020;
				short num2 = num;
				num = (short)2027407740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1674969088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1805254656;
				if (num != 0)
				{
				}
				num = (short)1883766785;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Visible;
			}
			set
			{
				short num = (short)2092209614;
				short num2 = num;
				num = (short)1393137102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992753152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826671105;
				if (num != 0)
				{
				}
				num = (short)376307712;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Visible = value;
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x003080EC File Offset: 0x003062EC
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x003081A0 File Offset: 0x003063A0
		public bool RadWideFeaturePreAmpUHF_A42962_Editable
		{
			get
			{
				short num = (short)825931842;
				short num2 = num;
				num = (short)1214756930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435238400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322582017;
				if (num != 0)
				{
				}
				num = (short)1255079936;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.Editable;
			}
			set
			{
				short num = (short)119184246;
				short num2 = num;
				num = (short)408984438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589379072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1356529665;
				if (num != 0)
				{
				}
				num = (short)162791424;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.Editable = value;
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x00308258 File Offset: 0x00306458
		internal string RadWideFeaturePreAmpUHF_A42962_UILabel
		{
			get
			{
				short num = (short)1566654650;
				short num2 = num;
				num = (short)1015955642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872218624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496121345;
				if (num != 0)
				{
				}
				num = (short)413466624;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.UIName;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x00308310 File Offset: 0x00306510
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x003083C4 File Offset: 0x003065C4
		internal bool RadWideFeaturePreAmpUHF_A42962_HiddenStatic
		{
			get
			{
				short num = (short)1240390191;
				short num2 = num;
				num = (short)361159215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)521273344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271529473;
				if (num != 0)
				{
				}
				num = (short)2066415616;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.HiddenStatic;
			}
			set
			{
				short num = (short)618286119;
				short num2 = num;
				num = (short)1632128039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46006272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100663297;
				if (num != 0)
				{
				}
				num = (short)1514471424;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.HiddenStatic = value;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060031ED RID: 12781 RVA: 0x0030847C File Offset: 0x0030667C
		// (set) Token: 0x060031EE RID: 12782 RVA: 0x00308534 File Offset: 0x00306734
		internal bool RadWideFeaturePreAmpUHF_A42962_HiddenDynamic
		{
			get
			{
				short num = (short)652765239;
				short num2 = num;
				num = (short)1183803447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804519936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370933761;
				if (num != 0)
				{
				}
				num = (short)350093312;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962.HiddenDynamic;
			}
			set
			{
				short num = (short)1767010220;
				short num2 = num;
				num = (short)773943212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919994368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498008065;
				if (num != 0)
				{
				}
				num = (short)2081030144;
				if (num != 0)
				{
				}
				this.radWideFeaturePreAmpUHF_A42962.HiddenDynamic = value;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x003085E8 File Offset: 0x003067E8
		public bool RadWideFeaturePreAmpUHF_A42962_HasDiffs
		{
			get
			{
				short num = (short)1548318896;
				short num2 = num;
				num = (short)259618992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097728000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300889601;
				if (num != 0)
				{
				}
				num = (short)1800994816;
				if (num != 0)
				{
				}
				return this.radWideFeaturePreAmpUHF_A42962._HasDiffs;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x0030869C File Offset: 0x0030689C
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x0030874C File Offset: 0x0030694C
		public bool RadWideFeatureDynamicIcons_A42963Value
		{
			get
			{
				short num = (short)442158215;
				short num2 = num;
				num = (short)1523043463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1280311296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215351296;
				if (num != 0)
				{
				}
				num = (short)1207173121;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Value;
			}
			set
			{
				short num = (short)1905005066;
				short num2 = num;
				num = (short)1629819402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1125974016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349962241;
				if (num != 0)
				{
				}
				num = (short)862126080;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Value = value;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x00308800 File Offset: 0x00306A00
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeatureDynamicIcons_A42963
		{
			get
			{
				short num = (short)295189465;
				short num2 = num;
				num = (short)227490777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180158464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)732823552;
				if (num != 0)
				{
				}
				num = (short)1005977601;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x003088B0 File Offset: 0x00306AB0
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x00308960 File Offset: 0x00306B60
		public bool RadWideFeatureDynamicIcons_A42963_UIValue
		{
			get
			{
				short num = (short)994106710;
				short num2 = num;
				num = (short)984341846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745092608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)118816769;
				if (num != 0)
				{
				}
				num = (short)238354432;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Value;
			}
			set
			{
				short num = (short)928816747;
				short num2 = num;
				num = (short)1612488299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967114752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48103425;
				if (num != 0)
				{
				}
				num = (short)13369344;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Value = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x00308A18 File Offset: 0x00306C18
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x00308ACC File Offset: 0x00306CCC
		public bool RadWideFeatureDynamicIcons_A42963_Applicable
		{
			get
			{
				short num = (short)353042433;
				if (num != 0)
				{
				}
				num = (short)1144913920;
				short num2 = num;
				num = (short)376676920;
				short num3 = num;
				num = (short)2084217400;
				switch (num3 == num)
				{
				}
				num = (short)2021261312;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Applicable;
			}
			set
			{
				short num = (short)1448631769;
				short num2 = num;
				num = (short)1165516249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196673536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544945665;
				if (num != 0)
				{
				}
				num = (short)1413611520;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Applicable = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x00308B84 File Offset: 0x00306D84
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x00308C3C File Offset: 0x00306E3C
		public bool RadWideFeatureDynamicIcons_A42963_Valid
		{
			get
			{
				short num = (short)555661716;
				short num2 = num;
				num = (short)274119060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307181056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034368513;
				if (num != 0)
				{
				}
				num = (short)1319108608;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Valid;
			}
			set
			{
				short num = (short)1916892619;
				short num2 = num;
				num = (short)1123513803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1817247744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543358977;
				if (num != 0)
				{
				}
				num = (short)1587937280;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Valid = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x00308CF4 File Offset: 0x00306EF4
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x00308DA8 File Offset: 0x00306FA8
		public bool RadWideFeatureDynamicIcons_A42963_Visible
		{
			get
			{
				short num = (short)491602268;
				short num2 = num;
				num = (short)1008550236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066336256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687276032;
				if (num != 0)
				{
				}
				num = (short)1235746817;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Visible;
			}
			set
			{
				short num = (short)1547370497;
				if (num != 0)
				{
				}
				num = (short)1123155968;
				short num2 = num;
				num = (short)62886406;
				short num3 = num;
				num = (short)1728877062;
				switch (num3 == num)
				{
				}
				num = (short)1372454912;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Visible = value;
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x00308E60 File Offset: 0x00307060
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x00308F18 File Offset: 0x00307118
		public bool RadWideFeatureDynamicIcons_A42963_Editable
		{
			get
			{
				short num = (short)1597879206;
				short num2 = num;
				num = (short)263304102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536360448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756299265;
				if (num != 0)
				{
				}
				num = (short)1841233920;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.Editable;
			}
			set
			{
				short num = (short)378866364;
				short num2 = num;
				num = (short)1281362620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095696384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1197277184;
				if (num != 0)
				{
				}
				num = (short)911212545;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.Editable = value;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x00308FCC File Offset: 0x003071CC
		internal string RadWideFeatureDynamicIcons_A42963_UILabel
		{
			get
			{
				short num = (short)291211815;
				short num2 = num;
				num = (short)1677494823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)740491264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1856831488;
				if (num != 0)
				{
				}
				num = (short)82509825;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.UIName;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x00309084 File Offset: 0x00307284
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00309138 File Offset: 0x00307338
		internal bool RadWideFeatureDynamicIcons_A42963_HiddenStatic
		{
			get
			{
				short num = (short)1137955613;
				short num2 = num;
				num = (short)556192541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284833280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1822162945;
				if (num != 0)
				{
				}
				num = (short)1495269376;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.HiddenStatic;
			}
			set
			{
				short num = (short)109611844;
				short num2 = num;
				num = (short)678398788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987182592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)57409536;
				if (num != 0)
				{
				}
				num = (short)1075642369;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.HiddenStatic = value;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x003091F4 File Offset: 0x003073F4
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x003092A8 File Offset: 0x003074A8
		internal bool RadWideFeatureDynamicIcons_A42963_HiddenDynamic
		{
			get
			{
				short num = (short)1700646148;
				short num2 = num;
				num = (short)1856687364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164495360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1362165760;
				if (num != 0)
				{
				}
				num = (short)1481179137;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963.HiddenDynamic;
			}
			set
			{
				short num = (short)770277318;
				short num2 = num;
				num = (short)1715240902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2103312384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2092040193;
				if (num != 0)
				{
				}
				num = (short)2063663104;
				if (num != 0)
				{
				}
				this.radWideFeatureDynamicIcons_A42963.HiddenDynamic = value;
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x00309360 File Offset: 0x00307560
		public bool RadWideFeatureDynamicIcons_A42963_HasDiffs
		{
			get
			{
				short num = (short)955514881;
				if (num != 0)
				{
				}
				num = (short)1450573824;
				short num2 = num;
				num = (short)643725422;
				short num3 = num;
				num = (short)792426606;
				switch (num3 == num)
				{
				}
				num = (short)876412928;
				if (num != 0)
				{
				}
				return this.radWideFeatureDynamicIcons_A42963._HasDiffs;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x00309414 File Offset: 0x00307614
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x003094C8 File Offset: 0x003076C8
		public bool RadWideFeaturesNFPACompliantValue
		{
			get
			{
				short num = (short)1093314195;
				short num2 = num;
				num = (short)1547740819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266548736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185532416;
				if (num != 0)
				{
				}
				num = (short)1458634753;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Value;
			}
			set
			{
				short num = (short)1156001527;
				short num2 = num;
				num = (short)1174286071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059993088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)411303937;
				if (num != 0)
				{
				}
				num = (short)1328283648;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Value = value;
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x0030957C File Offset: 0x0030777C
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesNFPACompliant
		{
			get
			{
				short num = (short)1196280829;
				short num2 = num;
				num = (short)46975997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367198208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451346433;
				if (num != 0)
				{
				}
				num = (short)517799936;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant;
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x0030962C File Offset: 0x0030782C
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x003096E0 File Offset: 0x003078E0
		public bool RadWideFeaturesNFPACompliant_UIValue
		{
			get
			{
				short num = (short)1247608833;
				if (num != 0)
				{
				}
				num = (short)1489895424;
				short num2 = num;
				num = (short)1406623251;
				short num3 = num;
				num = (short)2122014227;
				switch (num3 == num)
				{
				}
				num = (short)1844445184;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Value;
			}
			set
			{
				short num = (short)1757965822;
				short num2 = num;
				num = (short)2049273342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684537344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007288321;
				if (num != 0)
				{
				}
				num = (short)1070530560;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Value = value;
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x00309798 File Offset: 0x00307998
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x0030984C File Offset: 0x00307A4C
		public bool RadWideFeaturesNFPACompliant_Applicable
		{
			get
			{
				short num = (short)185927760;
				short num2 = num;
				num = (short)630720592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1303511040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485752833;
				if (num != 0)
				{
				}
				num = (short)1007878144;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Applicable;
			}
			set
			{
				short num = (short)201326593;
				if (num != 0)
				{
				}
				num = (short)1312817152;
				short num2 = num;
				num = (short)1734909705;
				short num3 = num;
				num = (short)638361353;
				switch (num3 == num)
				{
				}
				num = (short)2110717952;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Applicable = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x00309904 File Offset: 0x00307B04
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x003099B8 File Offset: 0x00307BB8
		public bool RadWideFeaturesNFPACompliant_Valid
		{
			get
			{
				short num = (short)462464262;
				short num2 = num;
				num = (short)74491142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592983552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)122814465;
				if (num != 0)
				{
				}
				num = (short)1537736704;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Valid;
			}
			set
			{
				short num = (short)1200236472;
				short num2 = num;
				num = (short)25700280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483669504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772210688;
				if (num != 0)
				{
				}
				num = (short)1015873537;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Valid = value;
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x00309A6C File Offset: 0x00307C6C
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00309B24 File Offset: 0x00307D24
		public bool RadWideFeaturesNFPACompliant_Visible
		{
			get
			{
				short num = (short)1691371192;
				short num2 = num;
				num = (short)1549616824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)843317248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)274857984;
				if (num != 0)
				{
				}
				num = (short)2101542913;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Visible;
			}
			set
			{
				short num = (short)1734410241;
				if (num != 0)
				{
				}
				num = (short)2113208320;
				short num2 = num;
				num = (short)559596880;
				short num3 = num;
				num = (short)1572980048;
				switch (num3 == num)
				{
				}
				num = (short)628621312;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Visible = value;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x00309BD8 File Offset: 0x00307DD8
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x00309C8C File Offset: 0x00307E8C
		public bool RadWideFeaturesNFPACompliant_Editable
		{
			get
			{
				short num = (short)823508923;
				short num2 = num;
				num = (short)1517338555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735524352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)249167873;
				if (num != 0)
				{
				}
				num = (short)1459945472;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.Editable;
			}
			set
			{
				short num = (short)374603777;
				if (num != 0)
				{
				}
				num = (short)1135280128;
				short num2 = num;
				num = (short)642181927;
				short num3 = num;
				num = (short)671869735;
				switch (num3 == num)
				{
				}
				num = (short)125501440;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.Editable = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x00309D40 File Offset: 0x00307F40
		internal string RadWideFeaturesNFPACompliant_UILabel
		{
			get
			{
				short num = (short)274333696;
				short num2 = num;
				num = (short)1997670427;
				short num3 = num;
				num = (short)856819739;
				switch (num3 == num)
				{
				}
				num = (short)50266113;
				if (num != 0)
				{
				}
				num = (short)1445986304;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.UIName;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x00309DF4 File Offset: 0x00307FF4
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x00309EA8 File Offset: 0x003080A8
		internal bool RadWideFeaturesNFPACompliant_HiddenStatic
		{
			get
			{
				short num = (short)1115881472;
				short num2 = num;
				num = (short)387036717;
				short num3 = num;
				num = (short)1073657389;
				switch (num3 == num)
				{
				}
				num = (short)1814626304;
				if (num != 0)
				{
				}
				num = (short)340918273;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.HiddenStatic;
			}
			set
			{
				short num = (short)369885184;
				short num2 = num;
				num = (short)2131480955;
				short num3 = num;
				num = (short)2053230971;
				switch (num3 == num)
				{
				}
				num = (short)809304064;
				if (num != 0)
				{
				}
				num = (short)465436673;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.HiddenStatic = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x00309F60 File Offset: 0x00308160
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x0030A014 File Offset: 0x00308214
		internal bool RadWideFeaturesNFPACompliant_HiddenDynamic
		{
			get
			{
				short num = (short)461438976;
				short num2 = num;
				num = (short)1617321635;
				short num3 = num;
				num = (short)460938915;
				switch (num3 == num)
				{
				}
				num = (short)1110638593;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant.HiddenDynamic;
			}
			set
			{
				short num = (short)1317208064;
				short num2 = num;
				num = (short)176722440;
				short num3 = num;
				num = (short)525701640;
				switch (num3 == num)
				{
				}
				num = (short)1271136256;
				if (num != 0)
				{
				}
				num = (short)1144782849;
				if (num != 0)
				{
				}
				this.radWideFeaturesNFPACompliant.HiddenDynamic = value;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0030A0CC File Offset: 0x003082CC
		public bool RadWideFeaturesNFPACompliant_HasDiffs
		{
			get
			{
				short num = (short)214171648;
				short num2 = num;
				num = (short)290980406;
				short num3 = num;
				num = (short)1382023734;
				switch (num3 == num)
				{
				}
				num = (short)920649729;
				if (num != 0)
				{
				}
				num = (short)1143930880;
				if (num != 0)
				{
				}
				return this.radWideFeaturesNFPACompliant._HasDiffs;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x0030A184 File Offset: 0x00308384
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x0030A23C File Offset: 0x0030843C
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000Value
		{
			get
			{
				short num = (short)1352007680;
				short num2 = num;
				num = (short)72837381;
				short num3 = num;
				num = (short)1688824069;
				switch (num3 == num)
				{
				}
				num = (short)32964609;
				if (num != 0)
				{
				}
				num = (short)831127552;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Value;
			}
			set
			{
				short num = (short)1167982592;
				short num2 = num;
				num = (short)1124782493;
				short num3 = num;
				num = (short)1936183709;
				switch (num3 == num)
				{
				}
				num = (short)935657473;
				if (num != 0)
				{
				}
				num = (short)772800512;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Value = value;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x0030A2F4 File Offset: 0x003084F4
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000
		{
			get
			{
				short num = (short)1682309120;
				short num2 = num;
				num = (short)1336817864;
				short num3 = num;
				num = (short)419313864;
				switch (num3 == num)
				{
				}
				num = (short)958464001;
				if (num != 0)
				{
				}
				num = (short)1819213824;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x0030A3A4 File Offset: 0x003085A4
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x0030A458 File Offset: 0x00308658
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_UIValue
		{
			get
			{
				short num = (short)746520576;
				short num2 = num;
				num = (short)1095368705;
				if (num != 0)
				{
				}
				num = (short)1135603334;
				short num3 = num;
				num = (short)522251910;
				switch (num3 == num)
				{
				}
				num = (short)1944453120;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Value;
			}
			set
			{
				short num = (short)2084503552;
				short num2 = num;
				num = (short)1135785022;
				short num3 = num;
				num = (short)1027716158;
				switch (num3 == num)
				{
				}
				num = (short)19464193;
				if (num != 0)
				{
				}
				num = (short)647495680;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Value = value;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x0030A50C File Offset: 0x0030870C
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x0030A5C0 File Offset: 0x003087C0
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_Applicable
		{
			get
			{
				short num = (short)2018443264;
				short num2 = num;
				num = (short)931136168;
				short num3 = num;
				num = (short)609747624;
				switch (num3 == num)
				{
				}
				num = (short)240517121;
				if (num != 0)
				{
				}
				num = (short)1981874176;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Applicable;
			}
			set
			{
				short num = (short)382664704;
				short num2 = num;
				num = (short)746273073;
				short num3 = num;
				num = (short)871643441;
				switch (num3 == num)
				{
				}
				num = (short)1945960449;
				if (num != 0)
				{
				}
				num = (short)399572992;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Applicable = value;
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x0030A674 File Offset: 0x00308874
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x0030A728 File Offset: 0x00308928
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_Valid
		{
			get
			{
				short num = (short)1477246976;
				short num2 = num;
				num = (short)104076758;
				short num3 = num;
				num = (short)473044438;
				switch (num3 == num)
				{
				}
				num = (short)729874433;
				if (num != 0)
				{
				}
				num = (short)306380800;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Valid;
			}
			set
			{
				short num = (short)577699840;
				short num2 = num;
				num = (short)1315539730;
				short num3 = num;
				num = (short)1343326994;
				switch (num3 == num)
				{
				}
				num = (short)812384257;
				if (num != 0)
				{
				}
				num = (short)885391360;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Valid = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x0030A7E0 File Offset: 0x003089E0
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x0030A894 File Offset: 0x00308A94
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_Visible
		{
			get
			{
				short num = (short)1758330880;
				short num2 = num;
				num = (short)1020145179;
				short num3 = num;
				num = (short)1304899099;
				switch (num3 == num)
				{
				}
				num = (short)1865416704;
				if (num != 0)
				{
				}
				num = (short)1799225345;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Visible;
			}
			set
			{
				short num = (short)900071424;
				short num2 = num;
				num = (short)1918748760;
				short num3 = num;
				num = (short)1924778072;
				switch (num3 == num)
				{
				}
				num = (short)1233387520;
				if (num != 0)
				{
				}
				num = (short)1361838081;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Visible = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x0030A948 File Offset: 0x00308B48
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x0030A9FC File Offset: 0x00308BFC
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_Editable
		{
			get
			{
				short num = (short)1773666304;
				short num2 = num;
				num = (short)1440003445;
				short num3 = num;
				num = (short)1173337461;
				switch (num3 == num)
				{
				}
				num = (short)1601765377;
				if (num != 0)
				{
				}
				num = (short)1112932352;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Editable;
			}
			set
			{
				short num = (short)1451950080;
				short num2 = num;
				num = (short)1085541674;
				short num3 = num;
				num = (short)1242762538;
				switch (num3 == num)
				{
				}
				num = (short)1442316289;
				if (num != 0)
				{
				}
				num = (short)913899520;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.Editable = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x0030AAB0 File Offset: 0x00308CB0
		internal string RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_UILabel
		{
			get
			{
				short num = (short)1997406208;
				short num2 = num;
				num = (short)588368992;
				short num3 = num;
				num = (short)1253297248;
				switch (num3 == num)
				{
				}
				num = (short)2140798977;
				if (num != 0)
				{
				}
				num = (short)149749760;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.UIName;
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x0030AB64 File Offset: 0x00308D64
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x0030AC1C File Offset: 0x00308E1C
		internal bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_HiddenStatic
		{
			get
			{
				short num = (short)581173248;
				short num2 = num;
				num = (short)1669529601;
				if (num != 0)
				{
				}
				num = (short)1088942024;
				short num3 = num;
				num = (short)988409800;
				switch (num3 == num)
				{
				}
				num = (short)621871104;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.HiddenStatic;
			}
			set
			{
				short num = (short)1908408320;
				short num2 = num;
				num = (short)500746521;
				short num3 = num;
				num = (short)853002521;
				switch (num3 == num)
				{
				}
				num = (short)2145910785;
				if (num != 0)
				{
				}
				num = (short)1014956032;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.HiddenStatic = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0030ACD4 File Offset: 0x00308ED4
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x0030AD88 File Offset: 0x00308F88
		internal bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_HiddenDynamic
		{
			get
			{
				short num = (short)940638208;
				short num2 = num;
				num = (short)1296976312;
				short num3 = num;
				num = (short)545868216;
				switch (num3 == num)
				{
				}
				num = (short)659292160;
				if (num != 0)
				{
				}
				num = (short)1814691841;
				if (num != 0)
				{
				}
				return this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.HiddenDynamic;
			}
			set
			{
				short num = (short)1743912960;
				short num2 = num;
				num = (short)834011273;
				short num3 = num;
				num = (short)3211401;
				switch (num3 == num)
				{
				}
				num = (short)1399783425;
				if (num != 0)
				{
				}
				num = (short)842989568;
				if (num != 0)
				{
				}
				this.radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.HiddenDynamic = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0030AE44 File Offset: 0x00309044
		public bool RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000_HasDiffs
		{
			get
			{
				short num = (short)1650393088;
				short num2 = num;
				num = (short)1099235329;
				if (num != 0)
				{
				}
				num = (short)111719414;
				short num3 = num;
				num = (short)1622717430;
				switch (num3 == num)
				{
				}
				num = (short)172032000;
				if (num != 0)
				{
				}
				return this.RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000._HasDiffs;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x0030AEF8 File Offset: 0x003090F8
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x0030AFAC File Offset: 0x003091AC
		public int RadWideFeaturesExtRFRoute_A43020Value
		{
			get
			{
				short num = (short)891027456;
				short num2 = num;
				num = (short)887475675;
				short num3 = num;
				num = (short)224579035;
				switch (num3 == num)
				{
				}
				num = (short)384827393;
				if (num != 0)
				{
				}
				num = (short)7077888;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.Value;
			}
			set
			{
				short num = (short)2146697216;
				short num2 = num;
				num = (short)179830785;
				if (num != 0)
				{
				}
				num = (short)1127732485;
				short num3 = num;
				num = (short)983225605;
				switch (num3 == num)
				{
				}
				num = (short)1519583232;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.Value = value;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x0030B064 File Offset: 0x00309264
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x0030B11C File Offset: 0x0030931C
		public string RadWideFeaturesExtRFRoute_A43020_UIValue
		{
			get
			{
				short num = (short)1435435008;
				short num2 = num;
				num = (short)637730658;
				short num3 = num;
				num = (short)1604255586;
				switch (num3 == num)
				{
				}
				num = (short)376373249;
				if (num != 0)
				{
				}
				num = (short)1443627008;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.UIValue;
			}
			set
			{
				short num = (short)1016004608;
				short num2 = num;
				num = (short)2051865906;
				short num3 = num;
				num = (short)796523826;
				switch (num3 == num)
				{
				}
				num = (short)2038824960;
				if (num != 0)
				{
				}
				num = (short)1285423105;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.UIValue = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x0030B1D0 File Offset: 0x003093D0
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesExtRFRoute_A43020
		{
			get
			{
				short num = (short)1590427648;
				short num2 = num;
				num = (short)1024669216;
				short num3 = num;
				num = (short)652424736;
				switch (num3 == num)
				{
				}
				num = (short)1576730625;
				if (num != 0)
				{
				}
				num = (short)996474880;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x0030B284 File Offset: 0x00309484
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x0030B338 File Offset: 0x00309538
		public bool RadWideFeaturesExtRFRoute_A43020_Applicable
		{
			get
			{
				short num = (short)11730944;
				short num2 = num;
				num = (short)1871147740;
				short num3 = num;
				num = (short)981168860;
				switch (num3 == num)
				{
				}
				num = (short)1711865857;
				if (num != 0)
				{
				}
				num = (short)1254686720;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.Applicable;
			}
			set
			{
				short num = (short)2114453504;
				short num2 = num;
				num = (short)1381740666;
				short num3 = num;
				num = (short)1345368186;
				switch (num3 == num)
				{
				}
				num = (short)633274369;
				if (num != 0)
				{
				}
				num = (short)1466302464;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.Applicable = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x0030B3E8 File Offset: 0x003095E8
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x0030B49C File Offset: 0x0030969C
		public bool RadWideFeaturesExtRFRoute_A43020_Valid
		{
			get
			{
				short num = (short)943783936;
				short num2 = num;
				num = (short)1824686497;
				short num3 = num;
				num = (short)128352673;
				switch (num3 == num)
				{
				}
				num = (short)894959617;
				if (num != 0)
				{
				}
				num = (short)1781399552;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.Valid;
			}
			set
			{
				short num = (short)1187905536;
				short num2 = num;
				num = (short)502202369;
				if (num != 0)
				{
				}
				num = (short)2118756062;
				short num3 = num;
				num = (short)171747038;
				switch (num3 == num)
				{
				}
				num = (short)231473152;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.Valid = value;
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x0030B550 File Offset: 0x00309750
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x0030B604 File Offset: 0x00309804
		public bool RadWideFeaturesExtRFRoute_A43020_Visible
		{
			get
			{
				short num = (short)1244463104;
				short num2 = num;
				num = (short)268544906;
				short num3 = num;
				num = (short)1030400906;
				switch (num3 == num)
				{
				}
				num = (short)222363648;
				if (num != 0)
				{
				}
				num = (short)2073100289;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.Visible;
			}
			set
			{
				short num = (short)179044352;
				short num2 = num;
				num = (short)745165967;
				short num3 = num;
				num = (short)2052412559;
				switch (num3 == num)
				{
				}
				num = (short)922222592;
				if (num != 0)
				{
				}
				num = (short)151912449;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.Visible = value;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x0030B6BC File Offset: 0x003098BC
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x0030B770 File Offset: 0x00309970
		public bool RadWideFeaturesExtRFRoute_A43020_Editable
		{
			get
			{
				short num = (short)576258048;
				short num2 = num;
				num = (short)1002373121;
				if (num != 0)
				{
				}
				num = (short)912308395;
				short num3 = num;
				num = (short)578140331;
				switch (num3 == num)
				{
				}
				num = (short)1941241856;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.Editable;
			}
			set
			{
				short num = (short)686882816;
				short num2 = num;
				num = (short)614006785;
				if (num != 0)
				{
				}
				num = (short)2040296570;
				short num3 = num;
				num = (short)1529836666;
				switch (num3 == num)
				{
				}
				num = (short)509804544;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.Editable = value;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x0030B828 File Offset: 0x00309A28
		internal string RadWideFeaturesExtRFRoute_A43020_UILabel
		{
			get
			{
				short num = (short)641794048;
				short num2 = num;
				num = (short)1115224379;
				short num3 = num;
				num = (short)1244592443;
				switch (num3 == num)
				{
				}
				num = (short)880607232;
				if (num != 0)
				{
				}
				num = (short)65929217;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.UIName;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x0030B8DC File Offset: 0x00309ADC
		// (set) Token: 0x06003238 RID: 12856 RVA: 0x0030B990 File Offset: 0x00309B90
		internal bool RadWideFeaturesExtRFRoute_A43020_HiddenStatic
		{
			get
			{
				short num = (short)259194880;
				short num2 = num;
				num = (short)840616654;
				short num3 = num;
				num = (short)34130638;
				switch (num3 == num)
				{
				}
				num = (short)1278476289;
				if (num != 0)
				{
				}
				num = (short)2033057792;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.HiddenStatic;
			}
			set
			{
				short num = (short)1124401152;
				short num2 = num;
				num = (short)1890254849;
				if (num != 0)
				{
				}
				num = (short)1634735809;
				short num3 = num;
				num = (short)546641601;
				switch (num3 == num)
				{
				}
				num = (short)349437952;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.HiddenStatic = value;
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x0030BA44 File Offset: 0x00309C44
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x0030BAF8 File Offset: 0x00309CF8
		internal bool RadWideFeaturesExtRFRoute_A43020_HiddenDynamic
		{
			get
			{
				short num = (short)1056047104;
				short num2 = num;
				num = (short)2050467537;
				short num3 = num;
				num = (short)462857937;
				switch (num3 == num)
				{
				}
				num = (short)1694957569;
				if (num != 0)
				{
				}
				num = (short)618004480;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020.HiddenDynamic;
			}
			set
			{
				short num = (short)221380608;
				short num2 = num;
				num = (short)1048800714;
				short num3 = num;
				num = (short)529296842;
				switch (num3 == num)
				{
				}
				num = (short)875298817;
				if (num != 0)
				{
				}
				num = (short)152961024;
				if (num != 0)
				{
				}
				this.radWideFeaturesExtRFRoute_A43020.HiddenDynamic = value;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x0030BBAC File Offset: 0x00309DAC
		public bool RadWideFeaturesExtRFRoute_A43020_HasDiffs
		{
			get
			{
				short num = (short)407306240;
				short num2 = num;
				num = (short)326975601;
				short num3 = num;
				num = (short)1487487089;
				switch (num3 == num)
				{
				}
				num = (short)2106064897;
				if (num != 0)
				{
				}
				num = (short)1651179520;
				if (num != 0)
				{
				}
				return this.radWideFeaturesExtRFRoute_A43020._HasDiffs;
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x0030BC64 File Offset: 0x00309E64
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x0030BD1C File Offset: 0x00309F1C
		public int RadWideFeaturesRadioCertificationType_43064Value
		{
			get
			{
				short num = (short)1379532800;
				short num2 = num;
				num = (short)57153471;
				short num3 = num;
				num = (short)1970673599;
				switch (num3 == num)
				{
				}
				num = (short)1119682561;
				if (num != 0)
				{
				}
				num = (short)1699217408;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.Value;
			}
			set
			{
				short num = (short)52822016;
				short num2 = num;
				num = (short)2019122027;
				short num3 = num;
				num = (short)640310123;
				switch (num3 == num)
				{
				}
				num = (short)243662849;
				if (num != 0)
				{
				}
				num = (short)1274740736;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.Value = value;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x0030BDD0 File Offset: 0x00309FD0
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x0030BE84 File Offset: 0x0030A084
		public string RadWideFeaturesRadioCertificationType_43064_UIValue
		{
			get
			{
				short num = (short)335872001;
				if (num != 0)
				{
				}
				num = (short)482424013;
				short num2 = num;
				num = (short)241120461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918304256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1628766208;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.UIValue;
			}
			set
			{
				short num = (short)1678111354;
				short num2 = num;
				num = (short)697234042;
				switch (num2 == num)
				{
				}
				num = (short)641400832;
				short num3 = num;
				num = (short)21626881;
				if (num != 0)
				{
				}
				num = (short)1045168128;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.UIValue = value;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x0030BF38 File Offset: 0x0030A138
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesRadioCertificationType_43064
		{
			get
			{
				short num = (short)794235895;
				short num2 = num;
				num = (short)495129591;
				switch (num2 == num)
				{
				}
				num = (short)1335754752;
				short num3 = num;
				num = (short)910295041;
				if (num != 0)
				{
				}
				num = (short)382140416;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064;
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06003241 RID: 12865 RVA: 0x0030BFE8 File Offset: 0x0030A1E8
		// (set) Token: 0x06003242 RID: 12866 RVA: 0x0030C09C File Offset: 0x0030A29C
		public bool RadWideFeaturesRadioCertificationType_43064_Applicable
		{
			get
			{
				short num = (short)172586731;
				short num2 = num;
				num = (short)630814443;
				switch (num2 == num)
				{
				}
				num = (short)1637810176;
				short num3 = num;
				num = (short)1916928001;
				if (num != 0)
				{
				}
				num = (short)823918592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.Applicable;
			}
			set
			{
				short num = (short)478175072;
				short num2 = num;
				num = (short)569597792;
				switch (num2 == num)
				{
				}
				num = (short)1897791488;
				short num3 = num;
				num = (short)1500446720;
				if (num != 0)
				{
				}
				num = (short)510263297;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.Applicable = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x0030C154 File Offset: 0x0030A354
		// (set) Token: 0x06003244 RID: 12868 RVA: 0x0030C208 File Offset: 0x0030A408
		public bool RadWideFeaturesRadioCertificationType_43064_Valid
		{
			get
			{
				short num = (short)716636161;
				if (num != 0)
				{
				}
				num = (short)56267075;
				short num2 = num;
				num = (short)2132382019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478740480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329659904;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.Valid;
			}
			set
			{
				short num = (short)581023781;
				short num2 = num;
				num = (short)1949218853;
				switch (num2 == num)
				{
				}
				num = (short)2036334592;
				short num3 = num;
				num = (short)1584726016;
				if (num != 0)
				{
				}
				num = (short)141688833;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.Valid = value;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x0030C2C0 File Offset: 0x0030A4C0
		// (set) Token: 0x06003246 RID: 12870 RVA: 0x0030C370 File Offset: 0x0030A570
		public bool RadWideFeaturesRadioCertificationType_43064_Visible
		{
			get
			{
				short num = (short)1524888410;
				short num2 = num;
				num = (short)1982591834;
				switch (num2 == num)
				{
				}
				num = (short)105578496;
				short num3 = num;
				num = (short)1457324033;
				if (num != 0)
				{
				}
				num = (short)1148518400;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.Visible;
			}
			set
			{
				short num = (short)343145310;
				short num2 = num;
				num = (short)34732894;
				switch (num2 == num)
				{
				}
				num = (short)499712000;
				short num3 = num;
				num = (short)1147994112;
				if (num != 0)
				{
				}
				num = (short)325451777;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.Visible = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x0030C424 File Offset: 0x0030A624
		// (set) Token: 0x06003248 RID: 12872 RVA: 0x0030C4D8 File Offset: 0x0030A6D8
		public bool RadWideFeaturesRadioCertificationType_43064_Editable
		{
			get
			{
				short num = (short)1810054914;
				short num2 = num;
				num = (short)7159554;
				switch (num2 == num)
				{
				}
				num = (short)1560739840;
				short num3 = num;
				num = (short)1305739264;
				if (num != 0)
				{
				}
				num = (short)276365313;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.Editable;
			}
			set
			{
				short num = (short)429916161;
				if (num != 0)
				{
				}
				num = (short)1820486772;
				short num2 = num;
				num = (short)1199926388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402063360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)464781312;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.Editable = value;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x0030C590 File Offset: 0x0030A790
		internal string RadWideFeaturesRadioCertificationType_43064_UILabel
		{
			get
			{
				short num = (short)340185330;
				short num2 = num;
				num = (short)1660276978;
				switch (num2 == num)
				{
				}
				num = (short)1197998080;
				short num3 = num;
				num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)1419837440;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.UIName;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x0030C640 File Offset: 0x0030A840
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x0030C6F4 File Offset: 0x0030A8F4
		internal bool RadWideFeaturesRadioCertificationType_43064_HiddenStatic
		{
			get
			{
				short num = (short)863305729;
				if (num != 0)
				{
				}
				num = (short)1937943213;
				short num2 = num;
				num = (short)2026547885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)122355712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)686096384;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.HiddenStatic;
			}
			set
			{
				short num = (short)200655917;
				short num2 = num;
				num = (short)138069037;
				switch (num2 == num)
				{
				}
				num = (short)1915748352;
				short num3 = num;
				num = (short)560463873;
				if (num != 0)
				{
				}
				num = (short)1056309248;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.HiddenStatic = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x0030C7A8 File Offset: 0x0030A9A8
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x0030C85C File Offset: 0x0030AA5C
		internal bool RadWideFeaturesRadioCertificationType_43064_HiddenDynamic
		{
			get
			{
				short num = (short)175713584;
				short num2 = num;
				num = (short)1035676976;
				switch (num2 == num)
				{
				}
				num = (short)914358272;
				short num3 = num;
				num = (short)242745345;
				if (num != 0)
				{
				}
				num = (short)85131264;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064.HiddenDynamic;
			}
			set
			{
				short num = (short)311716259;
				short num2 = num;
				num = (short)1892116899;
				switch (num2 == num)
				{
				}
				num = (short)613023744;
				short num3 = num;
				num = (short)767361024;
				if (num != 0)
				{
				}
				num = (short)508952577;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioCertificationType_43064.HiddenDynamic = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x0030C910 File Offset: 0x0030AB10
		public bool RadWideFeaturesRadioCertificationType_43064_HasDiffs
		{
			get
			{
				short num = (short)273208426;
				short num2 = num;
				num = (short)446682218;
				switch (num2 == num)
				{
				}
				num = (short)1542979584;
				short num3 = num;
				num = (short)1711079425;
				if (num != 0)
				{
				}
				num = (short)1934884864;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioCertificationType_43064._HasDiffs;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x0030C9C8 File Offset: 0x0030ABC8
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x0030CA7C File Offset: 0x0030AC7C
		public int RadWideFeaturesVLIFPLOSSFIELD_A9596Value
		{
			get
			{
				short num = (short)741015553;
				if (num != 0)
				{
				}
				num = (short)126681768;
				short num2 = num;
				num = (short)2115633832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)689111040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725038592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.Value;
			}
			set
			{
				short num = (short)875920298;
				short num2 = num;
				num = (short)1694006186;
				switch (num2 == num)
				{
				}
				num = (short)1575354368;
				short num3 = num;
				num = (short)272498689;
				if (num != 0)
				{
				}
				num = (short)543096832;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.Value = value;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x0030CB30 File Offset: 0x0030AD30
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x0030CBE4 File Offset: 0x0030ADE4
		public string RadWideFeaturesVLIFPLOSSFIELD_A9596_UIValue
		{
			get
			{
				short num = (short)1290142659;
				short num2 = num;
				num = (short)792527811;
				switch (num2 == num)
				{
				}
				num = (short)1791361024;
				short num3 = num;
				num = (short)1928462337;
				if (num != 0)
				{
				}
				num = (short)723386368;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.UIValue;
			}
			set
			{
				short num = (short)717848839;
				short num2 = num;
				num = (short)856850695;
				switch (num2 == num)
				{
				}
				num = (short)738131968;
				short num3 = num;
				num = (short)342753281;
				if (num != 0)
				{
				}
				num = (short)606208000;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.UIValue = value;
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x0030CC9C File Offset: 0x0030AE9C
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesVLIFPLOSSFIELD_A9596
		{
			get
			{
				short num = (short)233935442;
				short num2 = num;
				num = (short)1596428882;
				switch (num2 == num)
				{
				}
				num = (short)1437138944;
				short num3 = num;
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)213319680;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x0030CD4C File Offset: 0x0030AF4C
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x0030CE00 File Offset: 0x0030B000
		public bool RadWideFeaturesVLIFPLOSSFIELD_A9596_Applicable
		{
			get
			{
				short num = (short)164522571;
				short num2 = num;
				num = (short)1189440075;
				switch (num2 == num)
				{
				}
				num = (short)46202880;
				short num3 = num;
				num = (short)1064239104;
				if (num != 0)
				{
				}
				num = (short)178913281;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.Applicable;
			}
			set
			{
				short num = (short)1252734594;
				short num2 = num;
				num = (short)992032386;
				switch (num2 == num)
				{
				}
				num = (short)328466432;
				short num3 = num;
				num = (short)171048961;
				if (num != 0)
				{
				}
				num = (short)1378942976;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.Applicable = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x0030CEB8 File Offset: 0x0030B0B8
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x0030CF6C File Offset: 0x0030B16C
		public bool RadWideFeaturesVLIFPLOSSFIELD_A9596_Valid
		{
			get
			{
				short num = (short)1931965807;
				short num2 = num;
				num = (short)733836655;
				switch (num2 == num)
				{
				}
				num = (short)1684013056;
				short num3 = num;
				num = (short)1634009088;
				if (num != 0)
				{
				}
				num = (short)38993921;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.Valid;
			}
			set
			{
				short num = (short)803034078;
				short num2 = num;
				num = (short)1338201054;
				switch (num2 == num)
				{
				}
				num = (short)1030946816;
				short num3 = num;
				num = (short)1357840384;
				if (num != 0)
				{
				}
				num = (short)1369112577;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.Valid = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x0030D020 File Offset: 0x0030B220
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x0030D0D4 File Offset: 0x0030B2D4
		public bool RadWideFeaturesVLIFPLOSSFIELD_A9596_Visible
		{
			get
			{
				short num = (short)870628409;
				short num2 = num;
				num = (short)1375452217;
				switch (num2 == num)
				{
				}
				num = (short)427163648;
				short num3 = num;
				num = (short)2113601536;
				if (num != 0)
				{
				}
				num = (short)1291780097;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.Visible;
			}
			set
			{
				short num = (short)1482900060;
				short num2 = num;
				num = (short)1011565148;
				switch (num2 == num)
				{
				}
				num = (short)316276736;
				short num3 = num;
				num = (short)359858176;
				if (num != 0)
				{
				}
				num = (short)1997078529;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.Visible = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x0030D188 File Offset: 0x0030B388
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x0030D23C File Offset: 0x0030B43C
		public bool RadWideFeaturesVLIFPLOSSFIELD_A9596_Editable
		{
			get
			{
				short num = (short)563085313;
				if (num != 0)
				{
				}
				num = (short)966964639;
				short num2 = num;
				num = (short)1568912799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217200128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412680192;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.Editable;
			}
			set
			{
				short num = (short)1801013495;
				short num2 = num;
				num = (short)2000242935;
				switch (num2 == num)
				{
				}
				num = (short)1481768960;
				short num3 = num;
				num = (short)1199898625;
				if (num != 0)
				{
				}
				num = (short)1047199744;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.Editable = value;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x0030D2F0 File Offset: 0x0030B4F0
		internal string RadWideFeaturesVLIFPLOSSFIELD_A9596_UILabel
		{
			get
			{
				short num = (short)1576360782;
				short num2 = num;
				num = (short)50092878;
				switch (num2 == num)
				{
				}
				num = (short)1834876928;
				short num3 = num;
				num = (short)1361379329;
				if (num != 0)
				{
				}
				num = (short)531628032;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.UIName;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x0030D3A4 File Offset: 0x0030B5A4
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x0030D458 File Offset: 0x0030B658
		internal bool RadWideFeaturesVLIFPLOSSFIELD_A9596_HiddenStatic
		{
			get
			{
				short num = (short)1915816263;
				short num2 = num;
				num = (short)890767687;
				switch (num2 == num)
				{
				}
				num = (short)2025652224;
				short num3 = num;
				num = (short)1252655105;
				if (num != 0)
				{
				}
				num = (short)106561536;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.HiddenStatic;
			}
			set
			{
				short num = (short)125167817;
				short num2 = num;
				num = (short)133556425;
				switch (num2 == num)
				{
				}
				num = (short)1889009664;
				short num3 = num;
				num = (short)1254096896;
				if (num != 0)
				{
				}
				num = (short)222953473;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.HiddenStatic = value;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x0030D50C File Offset: 0x0030B70C
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0030D5C0 File Offset: 0x0030B7C0
		internal bool RadWideGeneralVLIFPLOSSFIELD_A9596_HiddenDynamic
		{
			get
			{
				short num = (short)302405770;
				short num2 = num;
				num = (short)199841930;
				switch (num2 == num)
				{
				}
				num = (short)2095841280;
				short num3 = num;
				num = (short)686489601;
				if (num != 0)
				{
				}
				num = (short)347406336;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596.HiddenDynamic;
			}
			set
			{
				short num = (short)184785165;
				short num2 = num;
				num = (short)1729075469;
				switch (num2 == num)
				{
				}
				num = (short)1507590144;
				short num3 = num;
				num = (short)1500184577;
				if (num != 0)
				{
				}
				num = (short)437125120;
				if (num != 0)
				{
				}
				this.radWideFeaturesVLIFPLOSSFIELD_A9596.HiddenDynamic = value;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x0030D674 File Offset: 0x0030B874
		public bool RadWideFeaturesVLIFPLOSSFIELD_A9596_HasDiffs
		{
			get
			{
				short num = (short)1334108811;
				short num2 = num;
				num = (short)1045684875;
				switch (num2 == num)
				{
				}
				num = (short)620888064;
				short num3 = num;
				num = (short)1809711105;
				if (num != 0)
				{
				}
				num = (short)2065825792;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVLIFPLOSSFIELD_A9596._HasDiffs;
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x0030D728 File Offset: 0x0030B928
		// (set) Token: 0x06003263 RID: 12899 RVA: 0x0030D7DC File Offset: 0x0030B9DC
		public int RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Value
		{
			get
			{
				short num = (short)1083566954;
				short num2 = num;
				num = (short)1362422634;
				switch (num2 == num)
				{
				}
				num = (short)1827012608;
				short num3 = num;
				num = (short)315621377;
				if (num != 0)
				{
				}
				num = (short)2086338560;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Value;
			}
			set
			{
				short num = (short)1793885767;
				short num2 = num;
				num = (short)194938439;
				switch (num2 == num)
				{
				}
				num = (short)584450048;
				short num3 = num;
				num = (short)926154753;
				if (num != 0)
				{
				}
				num = (short)1310326784;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Value = value;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x0030D894 File Offset: 0x0030BA94
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideFeaturesRecordPlaybackAudioBufferSize_A43125
		{
			get
			{
				short num = (short)1962530495;
				short num2 = num;
				num = (short)870766271;
				switch (num2 == num)
				{
				}
				num = (short)2102198272;
				short num3 = num;
				num = (short)1025048577;
				if (num != 0)
				{
				}
				num = (short)1117192192;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125;
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x0030D944 File Offset: 0x0030BB44
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x0030D9F8 File Offset: 0x0030BBF8
		public string RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_UIValue
		{
			get
			{
				short num = (short)2093670808;
				short num2 = num;
				num = (short)2116608408;
				switch (num2 == num)
				{
				}
				num = (short)985464832;
				short num3 = num;
				num = (short)663617537;
				if (num != 0)
				{
				}
				num = (short)784793600;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.UIValue;
			}
			set
			{
				short num = (short)1313994837;
				short num2 = num;
				num = (short)1870067797;
				switch (num2 == num)
				{
				}
				num = (short)1771110400;
				short num3 = num;
				num = (short)1493303297;
				if (num != 0)
				{
				}
				num = (short)1841627136;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.UIValue = value;
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x0030DAB0 File Offset: 0x0030BCB0
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x0030DB68 File Offset: 0x0030BD68
		internal int RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Min
		{
			get
			{
				short num = (short)1451331142;
				short num2 = num;
				num = (short)833523270;
				switch (num2 == num)
				{
				}
				num = (short)1934819328;
				short num3 = num;
				num = (short)1572798465;
				if (num != 0)
				{
				}
				num = (short)1272905728;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Min;
			}
			set
			{
				short num = (short)1568014337;
				if (num != 0)
				{
				}
				num = (short)705407871;
				short num2 = num;
				num = (short)467446655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1353449472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764884480;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Min = value;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x0030DC1C File Offset: 0x0030BE1C
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x0030DCD0 File Offset: 0x0030BED0
		internal int RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Max
		{
			get
			{
				short num = (short)719257601;
				if (num != 0)
				{
				}
				num = (short)1058827400;
				short num2 = num;
				num = (short)83389576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206386688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)843579392;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Max;
			}
			set
			{
				short num = (short)164096026;
				short num2 = num;
				num = (short)732031002;
				switch (num2 == num)
				{
				}
				num = (short)1614938112;
				short num3 = num;
				num = (short)1497366528;
				if (num != 0)
				{
				}
				num = (short)1763180545;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Max = value;
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x0030DD84 File Offset: 0x0030BF84
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x0030DE38 File Offset: 0x0030C038
		internal int RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Step
		{
			get
			{
				short num = (short)222685113;
				short num2 = num;
				num = (short)462612409;
				switch (num2 == num)
				{
				}
				num = (short)864288768;
				short num3 = num;
				num = (short)489553921;
				if (num != 0)
				{
				}
				num = (short)1101529088;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.StepSize;
			}
			set
			{
				short num = (short)255052236;
				short num2 = num;
				num = (short)1546242508;
				switch (num2 == num)
				{
				}
				num = (short)40894464;
				short num3 = num;
				num = (short)678297600;
				if (num != 0)
				{
				}
				num = (short)1711407105;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.StepSize = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x0030DEEC File Offset: 0x0030C0EC
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x0030DFA0 File Offset: 0x0030C1A0
		public bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_Applicable
		{
			get
			{
				short num = (short)172504334;
				short num2 = num;
				num = (short)496448782;
				switch (num2 == num)
				{
				}
				num = (short)1618608128;
				short num3 = num;
				num = (short)1221787649;
				if (num != 0)
				{
				}
				num = (short)455344128;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Applicable;
			}
			set
			{
				short num = (short)824745373;
				short num2 = num;
				num = (short)2055445917;
				switch (num2 == num)
				{
				}
				num = (short)432144384;
				short num3 = num;
				num = (short)463929345;
				if (num != 0)
				{
				}
				num = (short)21757952;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Applicable = value;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x0030E054 File Offset: 0x0030C254
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x0030E108 File Offset: 0x0030C308
		public bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_Valid
		{
			get
			{
				short num = (short)1902292254;
				short num2 = num;
				num = (short)346074398;
				switch (num2 == num)
				{
				}
				num = (short)771817472;
				short num3 = num;
				num = (short)182321153;
				if (num != 0)
				{
				}
				num = (short)1257963520;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Valid;
			}
			set
			{
				short num = (short)149410406;
				short num2 = num;
				num = (short)1557779046;
				switch (num2 == num)
				{
				}
				num = (short)1883045888;
				short num3 = num;
				num = (short)317587456;
				if (num != 0)
				{
				}
				num = (short)84541441;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Valid = value;
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x0030E1BC File Offset: 0x0030C3BC
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x0030E274 File Offset: 0x0030C474
		public bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_Visible
		{
			get
			{
				short num = (short)1430612769;
				short num2 = num;
				num = (short)1694395169;
				switch (num2 == num)
				{
				}
				num = (short)49545216;
				short num3 = num;
				num = (short)1429274625;
				if (num != 0)
				{
				}
				num = (short)129171456;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Visible;
			}
			set
			{
				short num = (short)48350406;
				short num2 = num;
				num = (short)1383580870;
				switch (num2 == num)
				{
				}
				num = (short)290914304;
				short num3 = num;
				num = (short)454033409;
				if (num != 0)
				{
				}
				num = (short)99352576;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Visible = value;
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x0030E328 File Offset: 0x0030C528
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x0030E3DC File Offset: 0x0030C5DC
		public bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_Editable
		{
			get
			{
				short num = (short)1824653313;
				if (num != 0)
				{
				}
				num = (short)1489966076;
				short num2 = num;
				num = (short)365040636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)407437312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012151808;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Editable;
			}
			set
			{
				short num = (short)537198593;
				if (num != 0)
				{
				}
				num = (short)2034489955;
				short num2 = num;
				num = (short)583981667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015480320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)243859456;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.Editable = value;
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x0030E494 File Offset: 0x0030C694
		internal string RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_UILabel
		{
			get
			{
				short num = (short)1262854778;
				short num2 = num;
				num = (short)154772090;
				switch (num2 == num)
				{
				}
				num = (short)22020096;
				short num3 = num;
				num = (short)1306525697;
				if (num != 0)
				{
				}
				num = (short)1930100736;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.UIName;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x0030E548 File Offset: 0x0030C748
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0030E5FC File Offset: 0x0030C7FC
		internal bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_HiddenStatic
		{
			get
			{
				short num = (short)785483822;
				short num2 = num;
				num = (short)212371502;
				switch (num2 == num)
				{
				}
				num = (short)414187520;
				short num3 = num;
				num = (short)1151270913;
				if (num != 0)
				{
				}
				num = (short)1661665280;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.HiddenStatic;
			}
			set
			{
				short num = (short)1558183937;
				if (num != 0)
				{
				}
				num = (short)887938420;
				short num2 = num;
				num = (short)2141707636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42795008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519634944;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.HiddenStatic = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x0030E6B0 File Offset: 0x0030C8B0
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x0030E764 File Offset: 0x0030C964
		internal bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_HiddenDynamic
		{
			get
			{
				short num = (short)13631867;
				short num2 = num;
				num = (short)289669499;
				switch (num2 == num)
				{
				}
				num = (short)351469568;
				short num3 = num;
				num = (short)764870657;
				if (num != 0)
				{
				}
				num = (short)1138622464;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.HiddenDynamic;
			}
			set
			{
				short num = (short)1019871233;
				if (num != 0)
				{
				}
				num = (short)1337985922;
				short num2 = num;
				num = (short)415632258;
				switch (num2 == num)
				{
				}
				num = (short)1695940608;
				short num3 = num;
				num = (short)1531772928;
				if (num != 0)
				{
				}
				this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125.HiddenDynamic = value;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x0030E81C File Offset: 0x0030CA1C
		public bool RadWideFeaturesRecordPlaybackAudioBufferSize_A43125_HasDiffs
		{
			get
			{
				short num = (short)1012454665;
				short num2 = num;
				num = (short)1626985737;
				switch (num2 == num)
				{
				}
				num = (short)1462632449;
				if (num != 0)
				{
				}
				num = (short)1377959936;
				short num3 = num;
				num = (short)761200640;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRecordPlaybackAudioBufferSize_A43125._HasDiffs;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x0030E8D0 File Offset: 0x0030CAD0
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x0030E984 File Offset: 0x0030CB84
		public bool RadWideFeaturesZoneCloneEnable_43130Value
		{
			get
			{
				short num = (short)1226244097;
				if (num != 0)
				{
				}
				num = (short)38368713;
				short num2 = num;
				num = (short)747992521;
				switch (num2 == num)
				{
				}
				num = (short)881328128;
				short num3 = num;
				num = (short)526581760;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Value;
			}
			set
			{
				short num = (short)61160890;
				short num2 = num;
				num = (short)708263354;
				switch (num2 == num)
				{
				}
				num = (short)158924801;
				if (num != 0)
				{
				}
				num = (short)40173568;
				short num3 = num;
				num = (short)246284288;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Value = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x0030EA38 File Offset: 0x0030CC38
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesZoneCloneEnable_43130
		{
			get
			{
				short num = (short)250065511;
				short num2 = num;
				num = (short)1595585127;
				switch (num2 == num)
				{
				}
				num = (short)1969684481;
				if (num != 0)
				{
				}
				num = (short)1262813184;
				short num3 = num;
				num = (short)2138898432;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x0030EAEC File Offset: 0x0030CCEC
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x0030EBA4 File Offset: 0x0030CDA4
		public bool RadWideFeaturesZoneCloneEnable_43130_UIValue
		{
			get
			{
				short num = (short)1100997555;
				short num2 = num;
				num = (short)2051072947;
				switch (num2 == num)
				{
				}
				num = (short)1875574785;
				if (num != 0)
				{
				}
				num = (short)1858273280;
				short num3 = num;
				num = (short)231342080;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Value;
			}
			set
			{
				short num = (short)1914463020;
				short num2 = num;
				num = (short)347890476;
				switch (num2 == num)
				{
				}
				num = (short)1247281153;
				if (num != 0)
				{
				}
				num = (short)49610752;
				short num3 = num;
				num = (short)110034944;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Value = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0030EC58 File Offset: 0x0030CE58
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0030ED0C File Offset: 0x0030CF0C
		public bool RadWideFeaturesZoneCloneEnable_43130_Applicable
		{
			get
			{
				short num = (short)1748625448;
				short num2 = num;
				num = (short)2010310696;
				switch (num2 == num)
				{
				}
				num = (short)1948516353;
				if (num != 0)
				{
				}
				num = (short)1218576384;
				short num3 = num;
				num = (short)1219821568;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Applicable;
			}
			set
			{
				short num = (short)1430213154;
				short num2 = num;
				num = (short)1391219234;
				switch (num2 == num)
				{
				}
				num = (short)1463287809;
				if (num != 0)
				{
				}
				num = (short)420347904;
				short num3 = num;
				num = (short)1744568320;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Applicable = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x0030EDC4 File Offset: 0x0030CFC4
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x0030EE74 File Offset: 0x0030D074
		public bool RadWideFeaturesZoneCloneEnable_43130_Valid
		{
			get
			{
				short num = (short)54930208;
				short num2 = num;
				num = (short)1281829664;
				switch (num2 == num)
				{
				}
				num = (short)1023541249;
				if (num != 0)
				{
				}
				num = (short)1878196224;
				short num3 = num;
				num = (short)1799356416;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Valid;
			}
			set
			{
				short num = (short)1190611621;
				short num2 = num;
				num = (short)2094811813;
				switch (num2 == num)
				{
				}
				num = (short)1739718657;
				if (num != 0)
				{
				}
				num = (short)372506624;
				short num3 = num;
				num = (short)25559040;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Valid = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x0030EF2C File Offset: 0x0030D12C
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x0030EFE0 File Offset: 0x0030D1E0
		public bool RadWideFeaturesZoneCloneEnable_43130_Visible
		{
			get
			{
				short num = (short)1533705784;
				short num2 = num;
				num = (short)1605176;
				switch (num2 == num)
				{
				}
				num = (short)1521942529;
				if (num != 0)
				{
				}
				num = (short)1818034176;
				short num3 = num;
				num = (short)508100608;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Visible;
			}
			set
			{
				short num = (short)1714900515;
				short num2 = num;
				num = (short)369118755;
				switch (num2 == num)
				{
				}
				num = (short)809762817;
				if (num != 0)
				{
				}
				num = (short)1479868416;
				short num3 = num;
				num = (short)30867456;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Visible = value;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0030F098 File Offset: 0x0030D298
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x0030F150 File Offset: 0x0030D350
		public bool RadWideFeaturesZoneCloneEnable_43130_Editable
		{
			get
			{
				short num = (short)1858218984;
				short num2 = num;
				num = (short)418786280;
				switch (num2 == num)
				{
				}
				num = (short)852164609;
				if (num != 0)
				{
				}
				num = (short)594214912;
				short num3 = num;
				num = (short)2034630656;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.Editable;
			}
			set
			{
				short num = (short)2102565393;
				short num2 = num;
				num = (short)237279761;
				switch (num2 == num)
				{
				}
				num = (short)1602420737;
				if (num != 0)
				{
				}
				num = (short)25034752;
				short num3 = num;
				num = (short)879820800;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.Editable = value;
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0030F204 File Offset: 0x0030D404
		internal string RadWideFeaturesZoneCloneEnable_43130_UILabel
		{
			get
			{
				short num = (short)2015824750;
				short num2 = num;
				num = (short)800590702;
				switch (num2 == num)
				{
				}
				num = (short)1231421440;
				if (num != 0)
				{
				}
				num = (short)1326841856;
				short num3 = num;
				num = (short)1129054209;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.UIName;
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x0030F2B8 File Offset: 0x0030D4B8
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x0030F370 File Offset: 0x0030D570
		internal bool RadWideFeaturesZoneCloneEnable_43130_HiddenStatic
		{
			get
			{
				short num = (short)353366720;
				short num2 = num;
				num = (short)2089808576;
				switch (num2 == num)
				{
				}
				num = (short)1123483648;
				if (num != 0)
				{
				}
				num = (short)1546584064;
				short num3 = num;
				num = (short)1969422337;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.HiddenStatic;
			}
			set
			{
				short num = (short)1323099858;
				short num2 = num;
				num = (short)1389618898;
				switch (num2 == num)
				{
				}
				num = (short)1339162625;
				if (num != 0)
				{
				}
				num = (short)1442512896;
				short num3 = num;
				num = (short)934674432;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.HiddenStatic = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x0030F424 File Offset: 0x0030D624
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x0030F4D8 File Offset: 0x0030D6D8
		internal bool RadWideFeaturesZoneCloneEnable_43130_HiddenDynamic
		{
			get
			{
				short num = (short)1390935491;
				short num2 = num;
				num = (short)1866923459;
				switch (num2 == num)
				{
				}
				num = (short)1866137600;
				if (num != 0)
				{
				}
				num = (short)130613248;
				short num3 = num;
				num = (short)1819803649;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130.HiddenDynamic;
			}
			set
			{
				short num = (short)127159912;
				short num2 = num;
				num = (short)985484904;
				switch (num2 == num)
				{
				}
				num = (short)2063204352;
				if (num != 0)
				{
				}
				num = (short)153026560;
				short num3 = num;
				num = (short)1939537921;
				if (num != 0)
				{
				}
				this.radWideFeaturesZoneCloneEnable_43130.HiddenDynamic = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x0030F590 File Offset: 0x0030D790
		public bool RadWideFeaturesZoneCloneEnable_43130_HasDiffs
		{
			get
			{
				short num = (short)415927734;
				short num2 = num;
				num = (short)953650614;
				switch (num2 == num)
				{
				}
				num = (short)1992949761;
				if (num != 0)
				{
				}
				num = (short)1853358080;
				short num3 = num;
				num = (short)1510604800;
				if (num != 0)
				{
				}
				return this.radWideFeaturesZoneCloneEnable_43130._HasDiffs;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x0030F648 File Offset: 0x0030D848
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x0030F700 File Offset: 0x0030D900
		public int RadWideFeaturesVoiceControlPriorityValue
		{
			get
			{
				short num = (short)1670416913;
				short num2 = num;
				num = (short)1732413969;
				switch (num2 == num)
				{
				}
				num = (short)1521811456;
				if (num != 0)
				{
				}
				num = (short)155058176;
				short num3 = num;
				num = (short)1059389441;
				if (num != 0)
				{
				}
				return this.RadWideFeaturesVoiceControlPriority.Value;
			}
			set
			{
				short num = (short)392857387;
				short num2 = num;
				num = (short)1310164779;
				switch (num2 == num)
				{
				}
				num = (short)1534459905;
				if (num != 0)
				{
				}
				num = (short)1354563584;
				short num3 = num;
				num = (short)1452933120;
				if (num != 0)
				{
				}
				this.RadWideFeaturesVoiceControlPriority.Value = value;
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x0030F7B8 File Offset: 0x0030D9B8
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x0030F86C File Offset: 0x0030DA6C
		public string RadWideFeaturesVoiceControlPriority_UIValue
		{
			get
			{
				short num = (short)1837933759;
				short num2 = num;
				num = (short)508273855;
				switch (num2 == num)
				{
				}
				num = (short)1884815361;
				if (num != 0)
				{
				}
				num = (short)22609920;
				short num3 = num;
				num = (short)1990393856;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.UIValue;
			}
			set
			{
				short num = (short)1020528769;
				short num2 = num;
				num = (short)382273665;
				switch (num2 == num)
				{
				}
				num = (short)692846592;
				if (num != 0)
				{
				}
				num = (short)1397751808;
				short num3 = num;
				num = (short)1847918593;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.UIValue = value;
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x0030F924 File Offset: 0x0030DB24
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesVoiceControlPriority
		{
			get
			{
				short num = (short)2072409744;
				short num2 = num;
				num = (short)1471837840;
				switch (num2 == num)
				{
				}
				num = (short)212140033;
				if (num != 0)
				{
				}
				num = (short)813301760;
				short num3 = num;
				num = (short)387907584;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x0030F9D4 File Offset: 0x0030DBD4
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x0030FA8C File Offset: 0x0030DC8C
		public bool RadWideFeaturesVoiceControlPriority_Applicable
		{
			get
			{
				short num = (short)608235565;
				short num2 = num;
				num = (short)1904930861;
				switch (num2 == num)
				{
				}
				num = (short)58785793;
				if (num != 0)
				{
				}
				num = (short)1916141568;
				short num3 = num;
				num = (short)318177280;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.Applicable;
			}
			set
			{
				short num = (short)655361;
				if (num != 0)
				{
				}
				num = (short)479282304;
				short num2 = num;
				num = (short)332481664;
				switch (num2 == num)
				{
				}
				num = (short)168230912;
				short num3 = num;
				num = (short)107020288;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.Applicable = value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x0030FB44 File Offset: 0x0030DD44
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x0030FBF8 File Offset: 0x0030DDF8
		public bool RadWideFeaturesVoiceControlPriority_Valid
		{
			get
			{
				short num = (short)1806423245;
				short num2 = num;
				num = (short)1116329165;
				switch (num2 == num)
				{
				}
				num = (short)1848967168;
				if (num != 0)
				{
				}
				num = (short)1461780480;
				short num3 = num;
				num = (short)1164443649;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.Valid;
			}
			set
			{
				short num = (short)1159822887;
				short num2 = num;
				num = (short)2008514087;
				switch (num2 == num)
				{
				}
				num = (short)1989214209;
				if (num != 0)
				{
				}
				num = (short)28639232;
				short num3 = num;
				num = (short)1514602496;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.Valid = value;
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x0030FCB0 File Offset: 0x0030DEB0
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x0030FD64 File Offset: 0x0030DF64
		public bool RadWideFeaturesVoiceControlPriority_Visible
		{
			get
			{
				short num = (short)1541535378;
				short num2 = num;
				num = (short)108328594;
				switch (num2 == num)
				{
				}
				num = (short)869531649;
				if (num != 0)
				{
				}
				num = (short)694419456;
				short num3 = num;
				num = (short)66256896;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.Visible;
			}
			set
			{
				short num = (short)1387747932;
				short num2 = num;
				num = (short)540301916;
				switch (num2 == num)
				{
				}
				num = (short)1424556032;
				if (num != 0)
				{
				}
				num = (short)438304768;
				short num3 = num;
				num = (short)1819213825;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.Visible = value;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x0030FE18 File Offset: 0x0030E018
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x0030FECC File Offset: 0x0030E0CC
		public bool RadWideFeaturesVoiceControlPriority_Editable
		{
			get
			{
				short num = (short)942280182;
				short num2 = num;
				num = (short)1651117558;
				switch (num2 == num)
				{
				}
				num = (short)1867382785;
				if (num != 0)
				{
				}
				num = (short)223543296;
				short num3 = num;
				num = (short)574685184;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.Editable;
			}
			set
			{
				short num = (short)1508934859;
				short num2 = num;
				num = (short)589989067;
				switch (num2 == num)
				{
				}
				num = (short)265879552;
				if (num != 0)
				{
				}
				num = (short)484573184;
				short num3 = num;
				num = (short)1119027201;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.Editable = value;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x0030FF80 File Offset: 0x0030E180
		internal string RadWideFeaturesVoiceControlPriority_UILabel
		{
			get
			{
				short num = (short)298699581;
				short num2 = num;
				num = (short)1129106237;
				switch (num2 == num)
				{
				}
				num = (short)87293953;
				if (num != 0)
				{
				}
				num = (short)1002438656;
				short num3 = num;
				num = (short)1649344512;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.UIName;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x00310038 File Offset: 0x0030E238
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x003100EC File Offset: 0x0030E2EC
		internal bool RadWideFeaturesVoiceControlPriority_HiddenStatic
		{
			get
			{
				short num = (short)1191903233;
				if (num != 0)
				{
				}
				num = (short)940772495;
				short num2 = num;
				num = (short)1779698831;
				switch (num2 == num)
				{
				}
				num = (short)1282211840;
				short num3 = num;
				num = (short)1292173312;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.HiddenStatic;
			}
			set
			{
				short num = (short)437813899;
				short num2 = num;
				num = (short)893026955;
				switch (num2 == num)
				{
				}
				num = (short)161742849;
				if (num != 0)
				{
				}
				num = (short)1494482944;
				short num3 = num;
				num = (short)300613632;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.HiddenStatic = value;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x003101A0 File Offset: 0x0030E3A0
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x00310258 File Offset: 0x0030E458
		internal bool RadWideFeaturesVoiceControlPriority_HiddenDynamic
		{
			get
			{
				short num = (short)163664012;
				short num2 = num;
				num = (short)1226985612;
				switch (num2 == num)
				{
				}
				num = (short)1298137089;
				if (num != 0)
				{
				}
				num = (short)1637941248;
				short num3 = num;
				num = (short)1964376064;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority.HiddenDynamic;
			}
			set
			{
				short num = (short)673315096;
				short num2 = num;
				num = (short)1500576024;
				switch (num2 == num)
				{
				}
				num = (short)1553072129;
				if (num != 0)
				{
				}
				num = (short)110166016;
				short num3 = num;
				num = (short)2102198272;
				if (num != 0)
				{
				}
				this.radWideFeaturesVoiceControlPriority.HiddenDynamic = value;
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x0031030C File Offset: 0x0030E50C
		public bool RadWideFeaturesVoiceControlPriority_HasDiffs
		{
			get
			{
				short num = (short)1098221780;
				short num2 = num;
				num = (short)1552976084;
				switch (num2 == num)
				{
				}
				num = (short)1443299329;
				if (num != 0)
				{
				}
				num = (short)927531008;
				short num3 = num;
				num = (short)204341248;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVoiceControlPriority._HasDiffs;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x003103C0 File Offset: 0x0030E5C0
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x00310474 File Offset: 0x0030E674
		public int RadCfgVirtualPartnerModeValue
		{
			get
			{
				short num = (short)1589051392;
				short num2 = num;
				num = (short)297764078;
				short num3 = num;
				num = (short)1267041518;
				switch (num3 == num)
				{
				}
				num = (short)937426945;
				if (num != 0)
				{
				}
				num = (short)1127284736;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.Value;
			}
			set
			{
				short num = (short)1370882048;
				short num2 = num;
				num = (short)1034747793;
				short num3 = num;
				num = (short)14483345;
				switch (num3 == num)
				{
				}
				num = (short)1900281856;
				if (num != 0)
				{
				}
				num = (short)1574633473;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.Value = value;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x00310528 File Offset: 0x0030E728
		// (set) Token: 0x060032A4 RID: 12964 RVA: 0x003105DC File Offset: 0x0030E7DC
		public string RadCfgVirtualPartnerMode_UIValue
		{
			get
			{
				short num = (short)1383661568;
				short num2 = num;
				num = (short)1042118570;
				short num3 = num;
				num = (short)1668249514;
				switch (num3 == num)
				{
				}
				num = (short)2036793345;
				if (num != 0)
				{
				}
				num = (short)31129600;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.UIValue;
			}
			set
			{
				short num = (short)1034682368;
				short num2 = num;
				num = (short)1100024301;
				short num3 = num;
				num = (short)1032587757;
				switch (num3 == num)
				{
				}
				num = (short)1109262336;
				if (num != 0)
				{
				}
				num = (short)41680897;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.UIValue = value;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x00310694 File Offset: 0x0030E894
		public global::AcpBusinessLayer.AcpListField RadCfgVirtualPartnerMode
		{
			get
			{
				short num = (short)810876928;
				short num2 = num;
				num = (short)421745400;
				short num3 = num;
				num = (short)1473008376;
				switch (num3 == num)
				{
				}
				num = (short)594149377;
				if (num != 0)
				{
				}
				num = (short)1690238976;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x00310748 File Offset: 0x0030E948
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x00310800 File Offset: 0x0030EA00
		public bool RadCfgVirtualPartnerMode_Applicable
		{
			get
			{
				short num = (short)1386807296;
				short num2 = num;
				num = (short)1590951937;
				if (num != 0)
				{
				}
				num = (short)2125278949;
				short num3 = num;
				num = (short)171060965;
				switch (num3 == num)
				{
				}
				num = (short)207093760;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.Applicable;
			}
			set
			{
				short num = (short)441974784;
				short num2 = num;
				num = (short)1583121474;
				short num3 = num;
				num = (short)1614906434;
				switch (num3 == num)
				{
				}
				num = (short)1082982401;
				if (num != 0)
				{
				}
				num = (short)1989935104;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.Applicable = value;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x003108B4 File Offset: 0x0030EAB4
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00310968 File Offset: 0x0030EB68
		public bool RadCfgVirtualPartnerMode_Valid
		{
			get
			{
				short num = (short)1328939008;
				short num2 = num;
				num = (short)599473976;
				short num3 = num;
				num = (short)1002782520;
				switch (num3 == num)
				{
				}
				num = (short)797442048;
				if (num != 0)
				{
				}
				num = (short)452263937;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.Valid;
			}
			set
			{
				short num = (short)264175616;
				short num2 = num;
				num = (short)1131817653;
				short num3 = num;
				num = (short)725494453;
				switch (num3 == num)
				{
				}
				num = (short)1336147969;
				if (num != 0)
				{
				}
				num = (short)1686241280;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.Valid = value;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x00310A1C File Offset: 0x0030EC1C
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x00310AD0 File Offset: 0x0030ECD0
		public bool RadCfgVirtualPartnerMode_Visible
		{
			get
			{
				short num = (short)562561024;
				short num2 = num;
				num = (short)907675790;
				short num3 = num;
				num = (short)966789262;
				switch (num3 == num)
				{
				}
				num = (short)1763246081;
				if (num != 0)
				{
				}
				num = (short)267321344;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.Visible;
			}
			set
			{
				short num = (short)563347456;
				short num2 = num;
				num = (short)1934944163;
				short num3 = num;
				num = (short)2094852003;
				switch (num3 == num)
				{
				}
				num = (short)1156972545;
				if (num != 0)
				{
				}
				num = (short)272039936;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.Visible = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00310B84 File Offset: 0x0030ED84
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x00310C38 File Offset: 0x0030EE38
		public bool RadCfgVirtualPartnerMode_Editable
		{
			get
			{
				short num = (short)608305152;
				short num2 = num;
				num = (short)1127725992;
				short num3 = num;
				num = (short)1810807720;
				switch (num3 == num)
				{
				}
				num = (short)1345716225;
				if (num != 0)
				{
				}
				num = (short)1617035264;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.Editable;
			}
			set
			{
				short num = (short)1090060288;
				short num2 = num;
				num = (short)879331947;
				short num3 = num;
				num = (short)1632864875;
				switch (num3 == num)
				{
				}
				num = (short)1550712832;
				if (num != 0)
				{
				}
				num = (short)864616449;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.Editable = value;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x00310CEC File Offset: 0x0030EEEC
		internal string RadCfgVirtualPartnerMode_UILabel
		{
			get
			{
				short num = (short)350486528;
				short num2 = num;
				num = (short)466288641;
				if (num != 0)
				{
				}
				num = (short)1195347724;
				short num3 = num;
				num = (short)772640524;
				switch (num3 == num)
				{
				}
				num = (short)626917376;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.UIName;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x00310DA0 File Offset: 0x0030EFA0
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x00310E58 File Offset: 0x0030F058
		internal bool RadCfgVirtualPartnerMode_HiddenStatic
		{
			get
			{
				short num = (short)560005120;
				short num2 = num;
				num = (short)50230213;
				short num3 = num;
				num = (short)94729157;
				switch (num3 == num)
				{
				}
				num = (short)1779564545;
				if (num != 0)
				{
				}
				num = (short)963903488;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.HiddenStatic;
			}
			set
			{
				short num = (short)262602752;
				short num2 = num;
				num = (short)2086830448;
				short num3 = num;
				num = (short)1733394800;
				switch (num3 == num)
				{
				}
				num = (short)684064769;
				if (num != 0)
				{
				}
				num = (short)1685454848;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.HiddenStatic = value;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x00310F0C File Offset: 0x0030F10C
		// (set) Token: 0x060032B2 RID: 12978 RVA: 0x00310FC0 File Offset: 0x0030F1C0
		internal bool RadCfgVirtualPartnerMode_HiddenDynamic
		{
			get
			{
				short num = (short)1728708608;
				short num2 = num;
				num = (short)35933661;
				short num3 = num;
				num = (short)1011109341;
				switch (num3 == num)
				{
				}
				num = (short)2037645312;
				if (num != 0)
				{
				}
				num = (short)252641281;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode.HiddenDynamic;
			}
			set
			{
				short num = (short)1391329280;
				short num2 = num;
				num = (short)1516163338;
				short num3 = num;
				num = (short)1041289482;
				switch (num3 == num)
				{
				}
				num = (short)639631361;
				if (num != 0)
				{
				}
				num = (short)1929248768;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerMode.HiddenDynamic = value;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x00311074 File Offset: 0x0030F274
		public bool RadCfgVirtualPartnerMode_HasDiffs
		{
			get
			{
				short num = (short)1414004736;
				short num2 = num;
				num = (short)1231959352;
				short num3 = num;
				num = (short)703018296;
				switch (num3 == num)
				{
				}
				num = (short)1557004289;
				if (num != 0)
				{
				}
				num = (short)272564224;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerMode._HasDiffs;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x00311128 File Offset: 0x0030F328
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x003111E0 File Offset: 0x0030F3E0
		public int RadWideFeaturesVirtualPartnerAudioPriorityValue
		{
			get
			{
				short num = (short)1271922688;
				short num2 = num;
				num = (short)1242840022;
				short num3 = num;
				num = (short)1783708630;
				switch (num3 == num)
				{
				}
				num = (short)497221632;
				if (num != 0)
				{
				}
				num = (short)1393164289;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.Value;
			}
			set
			{
				short num = (short)1183907840;
				short num2 = num;
				num = (short)1670250497;
				if (num != 0)
				{
				}
				num = (short)455472006;
				short num3 = num;
				num = (short)1255732102;
				switch (num3 == num)
				{
				}
				num = (short)324272128;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.Value = value;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x00311294 File Offset: 0x0030F494
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00311348 File Offset: 0x0030F548
		public string RadWideFeaturesVirtualPartnerAudioPriority_UIValue
		{
			get
			{
				short num = (short)804651008;
				short num2 = num;
				num = (short)351477420;
				short num3 = num;
				num = (short)2112167596;
				switch (num3 == num)
				{
				}
				num = (short)926613505;
				if (num != 0)
				{
				}
				num = (short)1144520704;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.UIValue;
			}
			set
			{
				short num = (short)1898512384;
				short num2 = num;
				num = (short)1849561946;
				short num3 = num;
				num = (short)1647121242;
				switch (num3 == num)
				{
				}
				num = (short)1665925120;
				if (num != 0)
				{
				}
				num = (short)1619722241;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.UIValue = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x00311400 File Offset: 0x0030F600
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesVirtualPartnerAudioPriority
		{
			get
			{
				short num = (short)1902641152;
				short num2 = num;
				num = (short)2001141761;
				if (num != 0)
				{
				}
				num = (short)207279099;
				short num3 = num;
				num = (short)1476711419;
				switch (num3 == num)
				{
				}
				num = (short)830341120;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x003114AC File Offset: 0x0030F6AC
		// (set) Token: 0x060032BA RID: 12986 RVA: 0x00311560 File Offset: 0x0030F760
		public bool RadWideFeaturesVirtualPartnerAudioPriority_Applicable
		{
			get
			{
				short num = (short)1977286656;
				short num2 = num;
				num = (short)658846861;
				short num3 = num;
				num = (short)675689613;
				switch (num3 == num)
				{
				}
				num = (short)540016641;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.Applicable;
			}
			set
			{
				short num = (short)1341587456;
				short num2 = num;
				num = (short)1444802633;
				short num3 = num;
				num = (short)1117253705;
				switch (num3 == num)
				{
				}
				num = (short)2038104064;
				if (num != 0)
				{
				}
				num = (short)1365442561;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.Applicable = value;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x00311618 File Offset: 0x0030F818
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x003116C8 File Offset: 0x0030F8C8
		public bool RadWideFeaturesVirtualPartnerAudioPriority_Valid
		{
			get
			{
				short num = (short)849543168;
				short num2 = num;
				num = (short)610299969;
				short num3 = num;
				num = (short)2024566849;
				switch (num3 == num)
				{
				}
				num = (short)1531969537;
				if (num != 0)
				{
				}
				num = (short)281804800;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.Valid;
			}
			set
			{
				short num = (short)310312960;
				short num2 = num;
				num = (short)47106392;
				short num3 = num;
				num = (short)966969688;
				switch (num3 == num)
				{
				}
				num = (short)2002649089;
				if (num != 0)
				{
				}
				num = (short)1434189824;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.Valid = value;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x0031177C File Offset: 0x0030F97C
		// (set) Token: 0x060032BE RID: 12990 RVA: 0x00311830 File Offset: 0x0030FA30
		public bool RadWideFeaturesVirtualPartnerAudioPriority_Visible
		{
			get
			{
				short num = (short)593625088;
				short num2 = num;
				num = (short)212820139;
				short num3 = num;
				num = (short)611344555;
				switch (num3 == num)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				num = (short)113639425;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.Visible;
			}
			set
			{
				short num = (short)374013952;
				short num2 = num;
				num = (short)1559858561;
				short num3 = num;
				num = (short)770149761;
				switch (num3 == num)
				{
				}
				num = (short)1894776833;
				if (num != 0)
				{
				}
				num = (short)1530331136;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.Visible = value;
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x003118E8 File Offset: 0x0030FAE8
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x003119A0 File Offset: 0x0030FBA0
		public bool RadWideFeaturesVirtualPartnerAudioPriority_Editable
		{
			get
			{
				short num = (short)225968128;
				short num2 = num;
				num = (short)64522466;
				short num3 = num;
				num = (short)1676118242;
				switch (num3 == num)
				{
				}
				num = (short)1295908865;
				if (num != 0)
				{
				}
				num = (short)700579840;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.Editable;
			}
			set
			{
				short num = (short)326631424;
				short num2 = num;
				num = (short)1895539252;
				short num3 = num;
				num = (short)839885364;
				switch (num3 == num)
				{
				}
				num = (short)1503068161;
				if (num != 0)
				{
				}
				num = (short)393216;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.Editable = value;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x00311A54 File Offset: 0x0030FC54
		internal string RadWideFeaturesVirtualPartnerAudioPriority_UILabel
		{
			get
			{
				short num = (short)1052966912;
				short num2 = num;
				num = (short)1167977914;
				short num3 = num;
				num = (short)1912270266;
				switch (num3 == num)
				{
				}
				num = (short)1898381313;
				if (num != 0)
				{
				}
				num = (short)1859584000;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.UIName;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00311B08 File Offset: 0x0030FD08
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x00311BC0 File Offset: 0x0030FDC0
		internal bool RadWideFeaturesVirtualPartnerAudioPriority_HiddenStatic
		{
			get
			{
				short num = (short)886308864;
				short num2 = num;
				num = (short)939393025;
				if (num != 0)
				{
				}
				num = (short)911242479;
				short num3 = num;
				num = (short)325678319;
				switch (num3 == num)
				{
				}
				num = (short)1405878272;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.HiddenStatic;
			}
			set
			{
				short num = (short)556269568;
				short num2 = num;
				num = (short)559401337;
				short num3 = num;
				num = (short)2014038393;
				switch (num3 == num)
				{
				}
				num = (short)1947729921;
				if (num != 0)
				{
				}
				num = (short)1504444416;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.HiddenStatic = value;
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00311C74 File Offset: 0x0030FE74
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00311D28 File Offset: 0x0030FF28
		internal bool RadWideFeaturesVirtualPartnerAudioPriority_HiddenDynamic
		{
			get
			{
				short num = (short)437780480;
				short num2 = num;
				num = (short)921407013;
				short num3 = num;
				num = (short)457477669;
				switch (num3 == num)
				{
				}
				num = (short)1918631937;
				if (num != 0)
				{
				}
				num = (short)402718720;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority.HiddenDynamic;
			}
			set
			{
				short num = (short)314769408;
				short num2 = num;
				num = (short)532025959;
				short num3 = num;
				num = (short)2069041767;
				switch (num3 == num)
				{
				}
				num = (short)2034827265;
				if (num != 0)
				{
				}
				num = (short)1318387712;
				if (num != 0)
				{
				}
				this.radWideFeaturesVirtualPartnerAudioPriority.HiddenDynamic = value;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x00311DDC File Offset: 0x0030FFDC
		public bool RadWideFeaturesVirtualPartnerAudioPriority_HasDiffs
		{
			get
			{
				short num = (short)878379008;
				short num2 = num;
				num = (short)1204911422;
				short num3 = num;
				num = (short)1136753982;
				switch (num3 == num)
				{
				}
				num = (short)638451713;
				if (num != 0)
				{
				}
				num = (short)2049376256;
				if (num != 0)
				{
				}
				return this.radWideFeaturesVirtualPartnerAudioPriority._HasDiffs;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x00311E90 File Offset: 0x00310090
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00311F48 File Offset: 0x00310148
		public int RadCfgVirtualPartnerInactivityTimeValue
		{
			get
			{
				short num = (short)466944000;
				short num2 = num;
				num = (short)317149638;
				short num3 = num;
				num = (short)1297895878;
				switch (num3 == num)
				{
				}
				num = (short)2076770304;
				if (num != 0)
				{
				}
				num = (short)800063489;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Value;
			}
			set
			{
				short num = (short)2131623936;
				short num2 = num;
				num = (short)1721555355;
				short num3 = num;
				num = (short)385800603;
				switch (num3 == num)
				{
				}
				num = (short)718274560;
				if (num != 0)
				{
				}
				num = (short)1847263233;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Value = value;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x00312000 File Offset: 0x00310200
		public global::AcpBusinessLayer.AcpSimpleRangeField RadCfgVirtualPartnerInactivityTime
		{
			get
			{
				short num = (short)1420230656;
				short num2 = num;
				num = (short)385741389;
				short num3 = num;
				num = (short)548336205;
				switch (num3 == num)
				{
				}
				num = (short)2053832704;
				if (num != 0)
				{
				}
				num = (short)71106561;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x003120B0 File Offset: 0x003102B0
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00312164 File Offset: 0x00310364
		public string RadCfgVirtualPartnerInactivityTime_UIValue
		{
			get
			{
				short num = (short)1236008960;
				short num2 = num;
				num = (short)1118286068;
				short num3 = num;
				num = (short)1696051444;
				switch (num3 == num)
				{
				}
				num = (short)1149698049;
				if (num != 0)
				{
				}
				num = (short)151715840;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.UIValue;
			}
			set
			{
				short num = (short)1634074624;
				short num2 = num;
				num = (short)536746443;
				short num3 = num;
				num = (short)643307979;
				switch (num3 == num)
				{
				}
				num = (short)1025638400;
				if (num != 0)
				{
				}
				num = (short)264896513;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.UIValue = value;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x0031221C File Offset: 0x0031041C
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x003122D4 File Offset: 0x003104D4
		internal int RadCfgVirtualPartnerInactivityTimeMin
		{
			get
			{
				short num = (short)78381056;
				short num2 = num;
				num = (short)1296878655;
				short num3 = num;
				num = (short)322227263;
				switch (num3 == num)
				{
				}
				num = (short)728104961;
				if (num != 0)
				{
				}
				num = (short)914817024;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Min;
			}
			set
			{
				short num = (short)70254592;
				short num2 = num;
				num = (short)600872579;
				short num3 = num;
				num = (short)2028967555;
				switch (num3 == num)
				{
				}
				num = (short)961544193;
				if (num != 0)
				{
				}
				num = (short)1116340224;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Min = value;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x0031238C File Offset: 0x0031058C
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00312440 File Offset: 0x00310640
		internal int RadCfgVirtualPartnerInactivityTimeMax
		{
			get
			{
				short num = (short)567279616;
				short num2 = num;
				num = (short)1097939690;
				short num3 = num;
				num = (short)1398553322;
				switch (num3 == num)
				{
				}
				num = (short)720764929;
				if (num != 0)
				{
				}
				num = (short)1642004480;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Max;
			}
			set
			{
				short num = (short)1509163008;
				short num2 = num;
				num = (short)361103361;
				if (num != 0)
				{
				}
				num = (short)510185456;
				short num3 = num;
				num = (short)1022742512;
				switch (num3 == num)
				{
				}
				num = (short)1612578816;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Max = value;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x003124F4 File Offset: 0x003106F4
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x003125AC File Offset: 0x003107AC
		internal int RadCfgVirtualPartnerInactivityTimeStep
		{
			get
			{
				short num = (short)1080426496;
				short num2 = num;
				num = (short)39943914;
				short num3 = num;
				num = (short)781942506;
				switch (num3 == num)
				{
				}
				num = (short)476708865;
				if (num != 0)
				{
				}
				num = (short)1297088512;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.StepSize;
			}
			set
			{
				short num = (short)539885568;
				short num2 = num;
				num = (short)364122374;
				short num3 = num;
				num = (short)1692471558;
				switch (num3 == num)
				{
				}
				num = (short)1335820288;
				if (num != 0)
				{
				}
				num = (short)1186660353;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.StepSize = value;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x00312660 File Offset: 0x00310860
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x00312714 File Offset: 0x00310914
		public bool RadCfgVirtualPartnerInactivityTime_Applicable
		{
			get
			{
				short num = (short)361693184;
				short num2 = num;
				num = (short)135547341;
				short num3 = num;
				num = (short)712001997;
				switch (num3 == num)
				{
				}
				num = (short)1976041473;
				if (num != 0)
				{
				}
				num = (short)1532690432;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Applicable;
			}
			set
			{
				short num = (short)267386880;
				short num2 = num;
				num = (short)1205321394;
				short num3 = num;
				num = (short)768720562;
				switch (num3 == num)
				{
				}
				num = (short)1783300097;
				if (num != 0)
				{
				}
				num = (short)405536768;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Applicable = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x003127C8 File Offset: 0x003109C8
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x0031287C File Offset: 0x00310A7C
		public bool RadCfgVirtualPartnerInactivityTime_Valid
		{
			get
			{
				short num = (short)647364608;
				short num2 = num;
				num = (short)1432465793;
				short num3 = num;
				num = (short)1511698817;
				switch (num3 == num)
				{
				}
				num = (short)1019281409;
				if (num != 0)
				{
				}
				num = (short)1650524160;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Valid;
			}
			set
			{
				short num = (short)1336147968;
				short num2 = num;
				num = (short)19471187;
				short num3 = num;
				num = (short)1245322067;
				switch (num3 == num)
				{
				}
				num = (short)1943339009;
				if (num != 0)
				{
				}
				num = (short)227737600;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Valid = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00312934 File Offset: 0x00310B34
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x003129E4 File Offset: 0x00310BE4
		public bool RadCfgVirtualPartnerInactivityTime_Visible
		{
			get
			{
				short num = (short)354418688;
				short num2 = num;
				num = (short)34848065;
				short num3 = num;
				num = (short)1102822721;
				switch (num3 == num)
				{
				}
				num = (short)1888550912;
				if (num != 0)
				{
				}
				num = (short)1878851585;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Visible;
			}
			set
			{
				short num = (short)1697054720;
				short num2 = num;
				num = (short)1895798094;
				short num3 = num;
				num = (short)1825674574;
				switch (num3 == num)
				{
				}
				num = (short)1558052865;
				if (num != 0)
				{
				}
				num = (short)1126432768;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Visible = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00312A9C File Offset: 0x00310C9C
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00312B50 File Offset: 0x00310D50
		public bool RadCfgVirtualPartnerInactivityTime_Editable
		{
			get
			{
				short num = (short)330104832;
				short num2 = num;
				num = (short)1729062465;
				short num3 = num;
				num = (short)1736599105;
				switch (num3 == num)
				{
				}
				num = (short)438239232;
				if (num != 0)
				{
				}
				num = (short)464191489;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.Editable;
			}
			set
			{
				short num = (short)803209216;
				short num2 = num;
				num = (short)1449978934;
				short num3 = num;
				num = (short)182774838;
				switch (num3 == num)
				{
				}
				num = (short)1271398400;
				if (num != 0)
				{
				}
				num = (short)1812922369;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.Editable = value;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x00312C04 File Offset: 0x00310E04
		internal string RadCfgVirtualPartnerInactivityTime_UILabel
		{
			get
			{
				short num = (short)1428726702;
				short num2 = num;
				num = (short)228238254;
				switch (num2 == num)
				{
				}
				num = (short)1502674944;
				short num3 = num;
				num = (short)149028865;
				if (num != 0)
				{
				}
				num = (short)592838656;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.UIName;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x00312CB8 File Offset: 0x00310EB8
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x00312D6C File Offset: 0x00310F6C
		internal bool RadCfgVirtualPartnerInactivityTime_HiddenStatic
		{
			get
			{
				short num = (short)873846112;
				short num2 = num;
				num = (short)1839584608;
				switch (num2 == num)
				{
				}
				num = (short)1444413440;
				short num3 = num;
				num = (short)1870135297;
				if (num != 0)
				{
				}
				num = (short)448135168;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.HiddenStatic;
			}
			set
			{
				short num = (short)1526489775;
				short num2 = num;
				num = (short)1579115183;
				switch (num2 == num)
				{
				}
				num = (short)585564160;
				short num3 = num;
				num = (short)206962688;
				if (num != 0)
				{
				}
				num = (short)1169293313;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.HiddenStatic = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x00312E20 File Offset: 0x00311020
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x00312ED4 File Offset: 0x003110D4
		internal bool RadCfgVirtualPartnerInactivityTime_HiddenDynamic
		{
			get
			{
				short num = (short)1513012900;
				short num2 = num;
				num = (short)1500888740;
				switch (num2 == num)
				{
				}
				num = (short)1842937856;
				short num3 = num;
				num = (short)447086593;
				if (num != 0)
				{
				}
				num = (short)1832976384;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime.HiddenDynamic;
			}
			set
			{
				short num = (short)652196586;
				short num2 = num;
				num = (short)1110162154;
				switch (num2 == num)
				{
				}
				num = (short)560594944;
				short num3 = num;
				num = (short)1802371073;
				if (num != 0)
				{
				}
				num = (short)76021760;
				if (num != 0)
				{
				}
				this.radCfgVirtualPartnerInactivityTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00312F8C File Offset: 0x0031118C
		public bool RadCfgVirtualPartnerInactivityTime_HasDiffs
		{
			get
			{
				short num = (short)1755250689;
				if (num != 0)
				{
				}
				num = (short)856612493;
				short num2 = num;
				num = (short)505273997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673592832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1666973696;
				if (num != 0)
				{
				}
				return this.radCfgVirtualPartnerInactivityTime._HasDiffs;
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x00313040 File Offset: 0x00311240
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x003130F4 File Offset: 0x003112F4
		public int RadWideFeaturesSmartMessagingSmartMessageModeValue
		{
			get
			{
				short num = (short)1882627379;
				short num2 = num;
				num = (short)2004196659;
				switch (num2 == num)
				{
				}
				num = (short)1678966784;
				short num3 = num;
				num = (short)1363869696;
				if (num != 0)
				{
				}
				num = (short)1188102145;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.Value;
			}
			set
			{
				short num = (short)1554743211;
				short num2 = num;
				num = (short)1182236587;
				switch (num2 == num)
				{
				}
				num = (short)642121728;
				short num3 = num;
				num = (short)204734465;
				if (num != 0)
				{
				}
				num = (short)1890582528;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.Value = value;
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x003131A8 File Offset: 0x003113A8
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x0031325C File Offset: 0x0031145C
		public string RadWideFeaturesSmartMessagingSmartMessageMode_UIValue
		{
			get
			{
				short num = (short)159925615;
				short num2 = num;
				num = (short)1763984751;
				switch (num2 == num)
				{
				}
				num = (short)168034304;
				short num3 = num;
				num = (short)1126105089;
				if (num != 0)
				{
				}
				num = (short)1340276736;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.UIValue;
			}
			set
			{
				short num = (short)1480183277;
				short num2 = num;
				num = (short)216780269;
				switch (num2 == num)
				{
				}
				num = (short)1516240896;
				short num3 = num;
				num = (short)41091073;
				if (num != 0)
				{
				}
				num = (short)1132199936;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.UIValue = value;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x00313314 File Offset: 0x00311514
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesSmartMessagingSmartMessageMode
		{
			get
			{
				short num = (short)891688316;
				short num2 = num;
				num = (short)916985212;
				switch (num2 == num)
				{
				}
				num = (short)949354496;
				short num3 = num;
				num = (short)824442880;
				if (num != 0)
				{
				}
				num = (short)1590296577;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x003133C4 File Offset: 0x003115C4
		// (set) Token: 0x060032E6 RID: 13030 RVA: 0x00313478 File Offset: 0x00311678
		public bool RadWideFeaturesSmartMessagingSmartMessageMode_Applicable
		{
			get
			{
				short num = (short)360236434;
				short num2 = num;
				num = (short)85837202;
				switch (num2 == num)
				{
				}
				num = (short)714604544;
				short num3 = num;
				num = (short)662831105;
				if (num != 0)
				{
				}
				num = (short)167706624;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.Applicable;
			}
			set
			{
				short num = (short)770303392;
				short num2 = num;
				num = (short)739829152;
				switch (num2 == num)
				{
				}
				num = (short)859504640;
				short num3 = num;
				num = (short)776339457;
				if (num != 0)
				{
				}
				num = (short)2048589824;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.Applicable = value;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x00313530 File Offset: 0x00311730
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x003135E4 File Offset: 0x003117E4
		public bool RadWideFeaturesSmartMessagingSmartMessageMode_Valid
		{
			get
			{
				short num = (short)848719624;
				short num2 = num;
				num = (short)656830216;
				switch (num2 == num)
				{
				}
				num = (short)317784064;
				short num3 = num;
				num = (short)1914109952;
				if (num != 0)
				{
				}
				num = (short)2057502721;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.Valid;
			}
			set
			{
				short num = (short)514981889;
				if (num != 0)
				{
				}
				num = (short)1975439519;
				short num2 = num;
				num = (short)1035128991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848246272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708982272;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.Valid = value;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x0031369C File Offset: 0x0031189C
		// (set) Token: 0x060032EA RID: 13034 RVA: 0x00313750 File Offset: 0x00311950
		public bool RadWideFeaturesSmartMessagingSmartMessageMode_Visible
		{
			get
			{
				short num = (short)944799555;
				short num2 = num;
				num = (short)981892931;
				switch (num2 == num)
				{
				}
				num = (short)1974927360;
				short num3 = num;
				num = (short)960299008;
				if (num != 0)
				{
				}
				num = (short)1386545153;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.Visible;
			}
			set
			{
				short num = (short)1860852636;
				short num2 = num;
				num = (short)1097816988;
				switch (num2 == num)
				{
				}
				num = (short)1175584768;
				short num3 = num;
				num = (short)755367936;
				if (num != 0)
				{
				}
				num = (short)1260060673;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.Visible = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x060032EB RID: 13035 RVA: 0x00313804 File Offset: 0x00311A04
		// (set) Token: 0x060032EC RID: 13036 RVA: 0x003138B8 File Offset: 0x00311AB8
		public bool RadWideFeaturesSmartMessagingSmartMessageMode_Editable
		{
			get
			{
				short num = (short)1518881160;
				short num2 = num;
				num = (short)58149256;
				switch (num2 == num)
				{
				}
				num = (short)145752064;
				short num3 = num;
				num = (short)1703936;
				if (num != 0)
				{
				}
				num = (short)1617887233;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.Editable;
			}
			set
			{
				short num = (short)150225553;
				short num2 = num;
				num = (short)1032798865;
				switch (num2 == num)
				{
				}
				num = (short)319553536;
				short num3 = num;
				num = (short)855441408;
				if (num != 0)
				{
				}
				num = (short)1781530625;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.Editable = value;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x00313970 File Offset: 0x00311B70
		internal string RadWideFeaturesSmartMessagingSmartMessageMode_UILabel
		{
			get
			{
				short num = (short)1335362785;
				short num2 = num;
				num = (short)1447888097;
				switch (num2 == num)
				{
				}
				num = (short)1391853568;
				short num3 = num;
				num = (short)623968257;
				if (num != 0)
				{
				}
				num = (short)505675776;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.UIName;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00313A24 File Offset: 0x00311C24
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00313AD8 File Offset: 0x00311CD8
		internal bool RadWideFeaturesSmartMessagingSmartMessageMode_HiddenStatic
		{
			get
			{
				short num = (short)1814382363;
				short num2 = num;
				num = (short)1254442779;
				switch (num2 == num)
				{
				}
				num = (short)106037248;
				short num3 = num;
				num = (short)1388380161;
				if (num != 0)
				{
				}
				num = (short)48562176;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.HiddenStatic;
			}
			set
			{
				short num = (short)667893111;
				short num2 = num;
				num = (short)1406352759;
				switch (num2 == num)
				{
				}
				num = (short)1396703232;
				short num3 = num;
				num = (short)1339883520;
				if (num != 0)
				{
				}
				num = (short)2008678401;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.HiddenStatic = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00313B8C File Offset: 0x00311D8C
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00313C40 File Offset: 0x00311E40
		internal bool RadWideFeaturesSmartMessagingSmartMessageMode_HiddenDynamic
		{
			get
			{
				short num = (short)1497692578;
				short num2 = num;
				num = (short)1685649826;
				switch (num2 == num)
				{
				}
				num = (short)2122711040;
				short num3 = num;
				num = (short)273547265;
				if (num != 0)
				{
				}
				num = (short)1448214528;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode.HiddenDynamic;
			}
			set
			{
				short num = (short)1107239000;
				short num2 = num;
				num = (short)266346584;
				switch (num2 == num)
				{
				}
				num = (short)2045247488;
				short num3 = num;
				num = (short)442236929;
				if (num != 0)
				{
				}
				num = (short)2128019456;
				if (num != 0)
				{
				}
				this.radWideFeaturesSmartMessagingSmartMessageMode.HiddenDynamic = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00313CF8 File Offset: 0x00311EF8
		public bool RadWideFeaturesSmartMessagingSmartMessageMode_HasDiffs
		{
			get
			{
				short num = (short)1737158998;
				short num2 = num;
				num = (short)318304598;
				switch (num2 == num)
				{
				}
				num = (short)1027932160;
				short num3 = num;
				num = (short)1932656640;
				if (num != 0)
				{
				}
				num = (short)1212678145;
				if (num != 0)
				{
				}
				return this.radWideFeaturesSmartMessagingSmartMessageMode._HasDiffs;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x00313DAC File Offset: 0x00311FAC
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x00313E60 File Offset: 0x00312060
		public int RadWideFeaturesPowerManagementStandbyTimeValue
		{
			get
			{
				short num = (short)453294161;
				short num2 = num;
				num = (short)1445181521;
				switch (num2 == num)
				{
				}
				num = (short)989003776;
				short num3 = num;
				num = (short)1579352065;
				if (num != 0)
				{
				}
				num = (short)1604452352;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Value;
			}
			set
			{
				short num = (short)1285691101;
				short num2 = num;
				num = (short)1690310365;
				switch (num2 == num)
				{
				}
				num = (short)32243712;
				short num3 = num;
				num = (short)936247297;
				if (num != 0)
				{
				}
				num = (short)385286144;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Value = value;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x00313F14 File Offset: 0x00312114
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideFeaturesPowerManagementStandbyTime
		{
			get
			{
				short num = (short)762760911;
				short num2 = num;
				num = (short)1155911375;
				switch (num2 == num)
				{
				}
				num = (short)1398472704;
				short num3 = num;
				num = (short)2105868288;
				if (num != 0)
				{
				}
				num = (short)558825473;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00313FC0 File Offset: 0x003121C0
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x00314074 File Offset: 0x00312274
		public string RadWideFeaturesPowerManagementStandbyTime_UIValue
		{
			get
			{
				short num = (short)330301441;
				if (num != 0)
				{
				}
				num = (short)670095200;
				short num2 = num;
				num = (short)1560074080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847263232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858666496;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.UIValue;
			}
			set
			{
				short num = (short)1865582304;
				short num2 = num;
				num = (short)1752139488;
				switch (num2 == num)
				{
				}
				num = (short)1015087104;
				short num3 = num;
				num = (short)1734541312;
				if (num != 0)
				{
				}
				num = (short)773586945;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.UIValue = value;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x0031412C File Offset: 0x0031232C
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x003141E0 File Offset: 0x003123E0
		internal int RadWideFeaturesPowerManagementStandbyTimeMin
		{
			get
			{
				short num = (short)1320235128;
				short num2 = num;
				num = (short)2034839672;
				switch (num2 == num)
				{
				}
				num = (short)1524170752;
				short num3 = num;
				num = (short)5046272;
				if (num != 0)
				{
				}
				num = (short)886636545;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Min;
			}
			set
			{
				short num = (short)201449377;
				short num2 = num;
				num = (short)960290721;
				switch (num2 == num)
				{
				}
				num = (short)1113456640;
				short num3 = num;
				num = (short)1973420033;
				if (num != 0)
				{
				}
				num = (short)734003200;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Min = value;
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x00314294 File Offset: 0x00312494
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x0031434C File Offset: 0x0031254C
		internal int RadWideFeaturesPowerManagementStandbyTimeMax
		{
			get
			{
				short num = (short)2013422392;
				short num2 = num;
				num = (short)1060725560;
				switch (num2 == num)
				{
				}
				num = (short)2137522176;
				short num3 = num;
				num = (short)1356988417;
				if (num != 0)
				{
				}
				num = (short)207618048;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Max;
			}
			set
			{
				short num = (short)1461821934;
				short num2 = num;
				num = (short)1991549422;
				switch (num2 == num)
				{
				}
				num = (short)1088356352;
				short num3 = num;
				num = (short)1779826689;
				if (num != 0)
				{
				}
				num = (short)204406784;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Max = value;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00314400 File Offset: 0x00312600
		// (set) Token: 0x060032FD RID: 13053 RVA: 0x003144B8 File Offset: 0x003126B8
		internal int RadWideFeaturesPowerManagementStandbyTimeStep
		{
			get
			{
				short num = (short)504983225;
				short num2 = num;
				num = (short)675966649;
				switch (num2 == num)
				{
				}
				num = (short)28246016;
				short num3 = num;
				num = (short)1151664129;
				if (num != 0)
				{
				}
				num = (short)1823211520;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.StepSize;
			}
			set
			{
				short num = (short)666871773;
				short num2 = num;
				num = (short)1101178845;
				switch (num2 == num)
				{
				}
				num = (short)617676800;
				short num3 = num;
				num = (short)1913913345;
				if (num != 0)
				{
				}
				num = (short)102629376;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.StepSize = value;
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00314574 File Offset: 0x00312774
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00314628 File Offset: 0x00312828
		public bool RadWideFeaturesPowerManagementStandbyTime_Applicable
		{
			get
			{
				short num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)1557262103;
				short num2 = num;
				num = (short)686092055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359137280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987037696;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Applicable;
			}
			set
			{
				short num = (short)1447369463;
				short num2 = num;
				num = (short)1891769079;
				switch (num2 == num)
				{
				}
				num = (short)1565851648;
				short num3 = num;
				num = (short)1337589761;
				if (num != 0)
				{
				}
				num = (short)1672413184;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Applicable = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x003146DC File Offset: 0x003128DC
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00314790 File Offset: 0x00312990
		public bool RadWideFeaturesPowerManagementStandbyTime_Valid
		{
			get
			{
				short num = (short)33765219;
				short num2 = num;
				num = (short)194918243;
				switch (num2 == num)
				{
				}
				num = (short)1324613632;
				short num3 = num;
				num = (short)207749121;
				if (num != 0)
				{
				}
				num = (short)965279744;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Valid;
			}
			set
			{
				short num = (short)1340920423;
				short num2 = num;
				num = (short)1744163431;
				switch (num2 == num)
				{
				}
				num = (short)68943872;
				short num3 = num;
				num = (short)1269628929;
				if (num != 0)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Valid = value;
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00314844 File Offset: 0x00312A44
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x003148F8 File Offset: 0x00312AF8
		public bool RadWideFeaturesPowerManagementStandbyTime_Visible
		{
			get
			{
				short num = (short)1410793473;
				if (num != 0)
				{
				}
				num = (short)1988459671;
				short num2 = num;
				num = (short)1094155415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721158144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317325312;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Visible;
			}
			set
			{
				short num = (short)629473281;
				if (num != 0)
				{
				}
				num = (short)489311379;
				short num2 = num;
				num = (short)1801473171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479985664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Visible = value;
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x003149AC File Offset: 0x00312BAC
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00314A5C File Offset: 0x00312C5C
		public bool RadWideFeaturesPowerManagementStandbyTime_Editable
		{
			get
			{
				short num = (short)1065177364;
				short num2 = num;
				num = (short)1707888916;
				switch (num2 == num)
				{
				}
				num = (short)435683328;
				short num3 = num;
				num = (short)2042232833;
				if (num != 0)
				{
				}
				num = (short)974520320;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.Editable;
			}
			set
			{
				short num = (short)1771793661;
				short num2 = num;
				num = (short)1804168445;
				switch (num2 == num)
				{
				}
				num = (short)1027670016;
				short num3 = num;
				num = (short)221446144;
				if (num != 0)
				{
				}
				num = (short)1634009089;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.Editable = value;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x00314B10 File Offset: 0x00312D10
		internal string RadWideFeaturesPowerManagementStandbyTime_UILabel
		{
			get
			{
				short num = (short)1714141812;
				short num2 = num;
				num = (short)2013510260;
				switch (num2 == num)
				{
				}
				num = (short)1734279168;
				short num3 = num;
				num = (short)1189085185;
				if (num != 0)
				{
				}
				num = (short)1410990080;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.UIName;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x00314BC8 File Offset: 0x00312DC8
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x00314C7C File Offset: 0x00312E7C
		internal bool RadWideFeaturesPowerManagementStandbyTime_HiddenStatic
		{
			get
			{
				short num = (short)854327297;
				if (num != 0)
				{
				}
				num = (short)1106688344;
				short num2 = num;
				num = (short)206027096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1503330304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716374016;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.HiddenStatic;
			}
			set
			{
				short num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)628304742;
				short num2 = num;
				num = (short)1321830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790233088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869924864;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.HiddenStatic = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x00314D30 File Offset: 0x00312F30
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00314DE4 File Offset: 0x00312FE4
		internal bool RadWideFeaturesPowerManagementStandbyTime_HiddenDynamic
		{
			get
			{
				short num = (short)886758085;
				short num2 = num;
				num = (short)387898053;
				switch (num2 == num)
				{
				}
				num = (short)1199964160;
				short num3 = num;
				num = (short)2029125633;
				if (num != 0)
				{
				}
				num = (short)159252480;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime.HiddenDynamic;
			}
			set
			{
				short num = (short)774106643;
				short num2 = num;
				num = (short)1426386451;
				switch (num2 == num)
				{
				}
				num = (short)786890752;
				short num3 = num;
				num = (short)301596673;
				if (num != 0)
				{
				}
				num = (short)2009137152;
				if (num != 0)
				{
				}
				this.radWideFeaturesPowerManagementStandbyTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x00314E98 File Offset: 0x00313098
		public bool RadWideFeaturesPowerManagementStandbyTime_HasDiffs
		{
			get
			{
				short num = (short)134820414;
				short num2 = num;
				num = (short)569913918;
				switch (num2 == num)
				{
				}
				num = (short)1179975680;
				short num3 = num;
				num = (short)1556348928;
				if (num != 0)
				{
				}
				num = (short)927203329;
				if (num != 0)
				{
				}
				return this.radWideFeaturesPowerManagementStandbyTime._HasDiffs;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x00314F50 File Offset: 0x00313150
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x00315000 File Offset: 0x00313200
		public bool RadWideFeatureAnalogWidebandDataValue
		{
			get
			{
				short num = (short)1066713014;
				short num2 = num;
				num = (short)2065743798;
				switch (num2 == num)
				{
				}
				num = (short)2090401792;
				short num3 = num;
				num = (short)616038400;
				if (num != 0)
				{
				}
				num = (short)1656356865;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Value;
			}
			set
			{
				short num = (short)1415643137;
				if (num != 0)
				{
				}
				num = (short)133723064;
				short num2 = num;
				num = (short)701068216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044709376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773666304;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Value = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x003150B8 File Offset: 0x003132B8
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeatureAnalogWidebandData
		{
			get
			{
				short num = (short)1827820220;
				short num2 = num;
				num = (short)1930449596;
				switch (num2 == num)
				{
				}
				num = (short)1913257984;
				short num3 = num;
				num = (short)2115567616;
				if (num != 0)
				{
				}
				num = (short)704184321;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x00315168 File Offset: 0x00313368
		// (set) Token: 0x06003310 RID: 13072 RVA: 0x00315220 File Offset: 0x00313420
		public bool RadWideFeatureAnalogWidebandData_UIValue
		{
			get
			{
				short num = (short)1974624608;
				short num2 = num;
				num = (short)1488281952;
				switch (num2 == num)
				{
				}
				num = (short)2041708544;
				short num3 = num;
				num = (short)261750785;
				if (num != 0)
				{
				}
				num = (short)1175126016;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Value;
			}
			set
			{
				short num = (short)1770824986;
				short num2 = num;
				num = (short)528262426;
				switch (num2 == num)
				{
				}
				num = (short)1366294528;
				short num3 = num;
				num = (short)311033856;
				if (num != 0)
				{
				}
				num = (short)124780545;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Value = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x003152D4 File Offset: 0x003134D4
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x0031538C File Offset: 0x0031358C
		public bool RadWideFeatureAnalogWidebandData_Applicable
		{
			get
			{
				short num = (short)1216505398;
				short num2 = num;
				num = (short)716072502;
				switch (num2 == num)
				{
				}
				num = (short)145883136;
				short num3 = num;
				num = (short)738721793;
				if (num != 0)
				{
				}
				num = (short)230948864;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Applicable;
			}
			set
			{
				short num = (short)1604770749;
				short num2 = num;
				num = (short)1587927997;
				switch (num2 == num)
				{
				}
				num = (short)1490616320;
				short num3 = num;
				num = (short)165150720;
				if (num != 0)
				{
				}
				num = (short)170328065;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Applicable = value;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00315444 File Offset: 0x00313644
		// (set) Token: 0x06003314 RID: 13076 RVA: 0x003154F8 File Offset: 0x003136F8
		public bool RadWideFeatureAnalogWidebandData_Valid
		{
			get
			{
				short num = (short)434831361;
				if (num != 0)
				{
				}
				num = (short)2093892182;
				short num2 = num;
				num = (short)1391018582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)426704896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1676148736;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Valid;
			}
			set
			{
				short num = (short)1015401805;
				short num2 = num;
				num = (short)1136119117;
				switch (num2 == num)
				{
				}
				num = (short)1371209728;
				short num3 = num;
				num = (short)28049408;
				if (num != 0)
				{
				}
				num = (short)1106837505;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Valid = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x003155AC File Offset: 0x003137AC
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x00315660 File Offset: 0x00313860
		public bool RadWideFeatureAnalogWidebandData_Visible
		{
			get
			{
				short num = (short)2081292952;
				short num2 = num;
				num = (short)1076036248;
				switch (num2 == num)
				{
				}
				num = (short)137101312;
				short num3 = num;
				num = (short)11534336;
				if (num != 0)
				{
				}
				num = (short)796590081;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Visible;
			}
			set
			{
				short num = (short)354928559;
				short num2 = num;
				num = (short)377014191;
				switch (num2 == num)
				{
				}
				num = (short)575471616;
				short num3 = num;
				num = (short)868614145;
				if (num != 0)
				{
				}
				num = (short)102170624;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Visible = value;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x00315714 File Offset: 0x00313914
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x003157C8 File Offset: 0x003139C8
		public bool RadWideFeatureAnalogWidebandData_Editable
		{
			get
			{
				short num = (short)1122291300;
				short num2 = num;
				num = (short)1332858468;
				switch (num2 == num)
				{
				}
				num = (short)760872960;
				short num3 = num;
				num = (short)776732672;
				if (num != 0)
				{
				}
				num = (short)937230337;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.Editable;
			}
			set
			{
				short num = (short)969779275;
				short num2 = num;
				num = (short)145598539;
				switch (num2 == num)
				{
				}
				num = (short)1663369216;
				short num3 = num;
				num = (short)1961099265;
				if (num != 0)
				{
				}
				num = (short)842268672;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.Editable = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x00315880 File Offset: 0x00313A80
		internal string RadWideFeatureAnalogWidebandData_UILabel
		{
			get
			{
				short num = (short)943373966;
				short num2 = num;
				num = (short)1782562446;
				switch (num2 == num)
				{
				}
				num = (short)798294016;
				short num3 = num;
				num = (short)533135360;
				if (num != 0)
				{
				}
				num = (short)980156417;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.UIName;
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600331A RID: 13082 RVA: 0x00315934 File Offset: 0x00313B34
		// (set) Token: 0x0600331B RID: 13083 RVA: 0x003159E8 File Offset: 0x00313BE8
		internal bool RadWideFeatureAnalogWidebandData_HiddenStatic
		{
			get
			{
				short num = (short)1748344180;
				short num2 = num;
				num = (short)2065210740;
				switch (num2 == num)
				{
				}
				num = (short)920125440;
				short num3 = num;
				num = (short)885981184;
				if (num != 0)
				{
				}
				num = (short)886177793;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.HiddenStatic;
			}
			set
			{
				short num = (short)103167450;
				short num2 = num;
				num = (short)1197159898;
				switch (num2 == num)
				{
				}
				num = (short)1307574272;
				short num3 = num;
				num = (short)98435073;
				if (num != 0)
				{
				}
				num = (short)1384644608;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.HiddenStatic = value;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x0600331C RID: 13084 RVA: 0x00315A9C File Offset: 0x00313C9C
		// (set) Token: 0x0600331D RID: 13085 RVA: 0x00315B50 File Offset: 0x00313D50
		internal bool RadWideFeatureAnalogWidebandData_HiddenDynamic
		{
			get
			{
				short num = (short)1124033114;
				short num2 = num;
				num = (short)1080189530;
				switch (num2 == num)
				{
				}
				num = (short)1736835072;
				short num3 = num;
				num = (short)729481216;
				if (num != 0)
				{
				}
				num = (short)79167489;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData.HiddenDynamic;
			}
			set
			{
				short num = (short)1791574961;
				short num2 = num;
				num = (short)248988593;
				switch (num2 == num)
				{
				}
				num = (short)1817116672;
				short num3 = num;
				num = (short)1989738497;
				if (num != 0)
				{
				}
				num = (short)93126656;
				if (num != 0)
				{
				}
				this.radWideFeatureAnalogWidebandData.HiddenDynamic = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x00315C04 File Offset: 0x00313E04
		public bool RadWideFeatureAnalogWidebandData_HasDiffs
		{
			get
			{
				short num = (short)576454735;
				short num2 = num;
				num = (short)379846735;
				switch (num2 == num)
				{
				}
				num = (short)1927675904;
				short num3 = num;
				num = (short)912982017;
				if (num != 0)
				{
				}
				num = (short)1815347200;
				if (num != 0)
				{
				}
				return this.radWideFeatureAnalogWidebandData._HasDiffs;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x0600331F RID: 13087 RVA: 0x00315CB8 File Offset: 0x00313EB8
		// (set) Token: 0x06003320 RID: 13088 RVA: 0x00315D6C File Offset: 0x00313F6C
		public bool RadWideCustomLogoEnabledValue
		{
			get
			{
				short num = (short)1932208321;
				short num2 = num;
				num = (short)840575169;
				switch (num2 == num)
				{
				}
				num = (short)1370030080;
				short num3 = num;
				num = (short)373555201;
				if (num != 0)
				{
				}
				num = (short)1705967616;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Value;
			}
			set
			{
				short num = (short)1800638507;
				short num2 = num;
				num = (short)832606251;
				switch (num2 == num)
				{
				}
				num = (short)1065877504;
				short num3 = num;
				num = (short)708050944;
				if (num != 0)
				{
				}
				num = (short)1852375041;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Value = value;
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x00315E20 File Offset: 0x00314020
		public global::AcpBusinessLayer.AcpField<bool> RadWideCustomLogoEnabled
		{
			get
			{
				short num = (short)2011447461;
				short num2 = num;
				num = (short)467812517;
				switch (num2 == num)
				{
				}
				num = (short)1996619776;
				short num3 = num;
				num = (short)902627329;
				if (num != 0)
				{
				}
				num = (short)435552256;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled;
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x00315ED4 File Offset: 0x003140D4
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x00315F8C File Offset: 0x0031418C
		public bool RadWideCustomLogoEnabled_UIValue
		{
			get
			{
				short num = (short)494801445;
				short num2 = num;
				num = (short)1683624485;
				switch (num2 == num)
				{
				}
				num = (short)1803026432;
				short num3 = num;
				num = (short)840892417;
				if (num != 0)
				{
				}
				num = (short)640483328;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Value;
			}
			set
			{
				short num = (short)1475833897;
				short num2 = num;
				num = (short)757559337;
				switch (num2 == num)
				{
				}
				num = (short)1413611520;
				short num3 = num;
				num = (short)2104229889;
				if (num != 0)
				{
				}
				num = (short)1945305088;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Value = value;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x00316044 File Offset: 0x00314244
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x003160F4 File Offset: 0x003142F4
		public bool RadWideCustomLogoEnabled_Applicable
		{
			get
			{
				short num = (short)74287177;
				short num2 = num;
				num = (short)726042697;
				switch (num2 == num)
				{
				}
				num = (short)590413824;
				short num3 = num;
				num = (short)1797521409;
				if (num != 0)
				{
				}
				num = (short)336527360;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Applicable;
			}
			set
			{
				short num = (short)1699543688;
				short num2 = num;
				num = (short)1447754376;
				switch (num2 == num)
				{
				}
				num = (short)79822848;
				short num3 = num;
				num = (short)1569652737;
				if (num != 0)
				{
				}
				num = (short)412680192;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Applicable = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x003161B0 File Offset: 0x003143B0
		// (set) Token: 0x06003327 RID: 13095 RVA: 0x00316264 File Offset: 0x00314464
		public bool RadWideCustomLogoEnabled_Valid
		{
			get
			{
				short num = (short)377154658;
				short num2 = num;
				num = (short)2036853858;
				switch (num2 == num)
				{
				}
				num = (short)1201274880;
				short num3 = num;
				num = (short)50593793;
				if (num != 0)
				{
				}
				num = (short)966262784;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Valid;
			}
			set
			{
				short num = (short)1244630181;
				short num2 = num;
				num = (short)1351322789;
				switch (num2 == num)
				{
				}
				num = (short)2112356352;
				short num3 = num;
				num = (short)842203137;
				if (num != 0)
				{
				}
				num = (short)421265408;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Valid = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x0031631C File Offset: 0x0031451C
		// (set) Token: 0x06003329 RID: 13097 RVA: 0x003163D0 File Offset: 0x003145D0
		public bool RadWideCustomLogoEnabled_Visible
		{
			get
			{
				short num = (short)841967075;
				short num2 = num;
				num = (short)499017187;
				switch (num2 == num)
				{
				}
				num = (short)1811939328;
				short num3 = num;
				num = (short)1014431745;
				if (num != 0)
				{
				}
				num = (short)1172307968;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Visible;
			}
			set
			{
				short num = (short)530593790;
				short num2 = num;
				num = (short)891303934;
				switch (num2 == num)
				{
				}
				num = (short)243924992;
				short num3 = num;
				num = (short)750780416;
				if (num != 0)
				{
				}
				num = (short)952369153;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Visible = value;
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x00316484 File Offset: 0x00314684
		// (set) Token: 0x0600332B RID: 13099 RVA: 0x00316538 File Offset: 0x00314738
		public bool RadWideCustomLogoEnabled_Editable
		{
			get
			{
				short num = (short)23891179;
				short num2 = num;
				num = (short)1814531307;
				switch (num2 == num)
				{
				}
				num = (short)732954624;
				short num3 = num;
				num = (short)2072641537;
				if (num != 0)
				{
				}
				num = (short)1999634432;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.Editable;
			}
			set
			{
				short num = (short)633536513;
				if (num != 0)
				{
				}
				num = (short)1685273624;
				short num2 = num;
				num = (short)904215576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)702414848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.Editable = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x003165F0 File Offset: 0x003147F0
		internal string RadWideCustomLogoEnabled_UILabel
		{
			get
			{
				short num = (short)1350426811;
				short num2 = num;
				num = (short)2085216443;
				switch (num2 == num)
				{
				}
				num = (short)1117323264;
				short num3 = num;
				num = (short)332398592;
				if (num != 0)
				{
				}
				num = (short)1251213313;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.UIName;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x003166A4 File Offset: 0x003148A4
		// (set) Token: 0x0600332E RID: 13102 RVA: 0x0031675C File Offset: 0x0031495C
		internal bool RadWideCustomLogoEnabled_HiddenStatic
		{
			get
			{
				short num = (short)743154978;
				short num2 = num;
				num = (short)8496418;
				switch (num2 == num)
				{
				}
				num = (short)393281536;
				short num3 = num;
				num = (short)2102394881;
				if (num != 0)
				{
				}
				num = (short)25165824;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.HiddenStatic;
			}
			set
			{
				short num = (short)375834409;
				short num2 = num;
				num = (short)1516029737;
				switch (num2 == num)
				{
				}
				num = (short)162856960;
				short num3 = num;
				num = (short)1232732160;
				if (num != 0)
				{
				}
				num = (short)602603521;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.HiddenStatic = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x00316810 File Offset: 0x00314A10
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x003168C4 File Offset: 0x00314AC4
		internal bool RadWideCustomLogoEnabled_HiddenDynamic
		{
			get
			{
				short num = (short)1551613119;
				short num2 = num;
				num = (short)1122942143;
				switch (num2 == num)
				{
				}
				num = (short)1531510784;
				short num3 = num;
				num = (short)188219392;
				if (num != 0)
				{
				}
				num = (short)104071169;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled.HiddenDynamic;
			}
			set
			{
				short num = (short)516721892;
				short num2 = num;
				num = (short)485330148;
				switch (num2 == num)
				{
				}
				num = (short)2128871424;
				short num3 = num;
				num = (short)444268545;
				if (num != 0)
				{
				}
				num = (short)1845362688;
				if (num != 0)
				{
				}
				this.radWideCustomLogoEnabled.HiddenDynamic = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x0031697C File Offset: 0x00314B7C
		public bool RadWideCustomLogoEnabled_HasDiffs
		{
			get
			{
				short num = (short)1396048343;
				short num2 = num;
				num = (short)1200619991;
				switch (num2 == num)
				{
				}
				num = (short)336658432;
				short num3 = num;
				num = (short)447676417;
				if (num != 0)
				{
				}
				num = (short)275578880;
				if (num != 0)
				{
				}
				return this.radWideCustomLogoEnabled._HasDiffs;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x00316A34 File Offset: 0x00314C34
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x00316AE8 File Offset: 0x00314CE8
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914Value
		{
			get
			{
				short num = (short)70319316;
				short num2 = num;
				num = (short)1096875220;
				switch (num2 == num)
				{
				}
				num = (short)1471348736;
				short num3 = num;
				num = (short)851443712;
				if (num != 0)
				{
				}
				num = (short)2053832705;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Value;
			}
			set
			{
				short num = (short)1116604546;
				short num2 = num;
				num = (short)1799686274;
				switch (num2 == num)
				{
				}
				num = (short)1210449920;
				short num3 = num;
				num = (short)371785728;
				if (num != 0)
				{
				}
				num = (short)1621295105;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Value = value;
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x00316BA0 File Offset: 0x00314DA0
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesRadioInhibitUIEnabled_44914
		{
			get
			{
				short num = (short)1291504672;
				short num2 = num;
				num = (short)308005920;
				switch (num2 == num)
				{
				}
				num = (short)143589376;
				short num3 = num;
				num = (short)1663434753;
				if (num != 0)
				{
				}
				num = (short)1623326720;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00316C50 File Offset: 0x00314E50
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00316D08 File Offset: 0x00314F08
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_UIValue
		{
			get
			{
				short num = (short)544844993;
				short num2 = num;
				num = (short)1641917633;
				switch (num2 == num)
				{
				}
				num = (short)1094909952;
				short num3 = num;
				num = (short)511967232;
				if (num != 0)
				{
				}
				num = (short)496369665;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Value;
			}
			set
			{
				short num = (short)1904889257;
				short num2 = num;
				num = (short)1723878825;
				switch (num2 == num)
				{
				}
				num = (short)656670720;
				short num3 = num;
				num = (short)468844545;
				if (num != 0)
				{
				}
				num = (short)2068054016;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Value = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x00316DBC File Offset: 0x00314FBC
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x00316E70 File Offset: 0x00315070
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_Applicable
		{
			get
			{
				short num = (short)788935882;
				short num2 = num;
				num = (short)1434596554;
				switch (num2 == num)
				{
				}
				num = (short)71434240;
				short num3 = num;
				num = (short)845348865;
				if (num != 0)
				{
				}
				num = (short)392036352;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Applicable;
			}
			set
			{
				short num = (short)1612909239;
				short num2 = num;
				num = (short)1143212727;
				switch (num2 == num)
				{
				}
				num = (short)1224671232;
				short num3 = num;
				num = (short)1068236801;
				if (num != 0)
				{
				}
				num = (short)256180224;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Applicable = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x00316F28 File Offset: 0x00315128
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x00316FDC File Offset: 0x003151DC
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_Valid
		{
			get
			{
				short num = (short)2104405554;
				short num2 = num;
				num = (short)3124786;
				switch (num2 == num)
				{
				}
				num = (short)752353280;
				short num3 = num;
				num = (short)2036006913;
				if (num != 0)
				{
				}
				num = (short)1012858880;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Valid;
			}
			set
			{
				short num = (short)615162952;
				short num2 = num;
				num = (short)1800840264;
				switch (num2 == num)
				{
				}
				num = (short)1665597440;
				short num3 = num;
				num = (short)1419051009;
				if (num != 0)
				{
				}
				num = (short)1574830080;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Valid = value;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x00317090 File Offset: 0x00315290
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x00317148 File Offset: 0x00315348
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_Visible
		{
			get
			{
				short num = (short)1013224070;
				short num2 = num;
				num = (short)1174049414;
				switch (num2 == num)
				{
				}
				num = (short)130220032;
				short num3 = num;
				num = (short)1001062400;
				if (num != 0)
				{
				}
				num = (short)1183449089;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Visible;
			}
			set
			{
				short num = (short)923402241;
				if (num != 0)
				{
				}
				num = (short)1258540936;
				short num2 = num;
				num = (short)180866952;
				switch (num2 == num)
				{
				default:
				{
					num = (short)930349056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879099904;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Visible = value;
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x00317200 File Offset: 0x00315400
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x003172B4 File Offset: 0x003154B4
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_Editable
		{
			get
			{
				short num = (short)1675886593;
				if (num != 0)
				{
				}
				num = (short)59933850;
				short num2 = num;
				num = (short)1131054234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514392064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333905920;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.Editable;
			}
			set
			{
				short num = (short)1507284734;
				short num2 = num;
				num = (short)1498044158;
				switch (num2 == num)
				{
				}
				num = (short)2104360960;
				short num3 = num;
				num = (short)60293121;
				if (num != 0)
				{
				}
				num = (short)828047360;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.Editable = value;
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x0031736C File Offset: 0x0031556C
		internal string RadWideFeaturesRadioInhibitUIEnabled_44914_UILabel
		{
			get
			{
				short num = (short)98101172;
				short num2 = num;
				num = (short)155772852;
				switch (num2 == num)
				{
				}
				num = (short)34209792;
				short num3 = num;
				num = (short)525664256;
				if (num != 0)
				{
				}
				num = (short)1206386689;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.UIName;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x0031741C File Offset: 0x0031561C
		// (set) Token: 0x06003341 RID: 13121 RVA: 0x003174D0 File Offset: 0x003156D0
		internal bool RadWideFeaturesRadioInhibitUIEnabled_44914_HiddenStatic
		{
			get
			{
				short num = (short)282712693;
				short num2 = num;
				num = (short)1299372661;
				switch (num2 == num)
				{
				}
				num = (short)424345600;
				short num3 = num;
				num = (short)512098304;
				if (num != 0)
				{
				}
				num = (short)399900673;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.HiddenStatic;
			}
			set
			{
				short num = (short)1032635729;
				short num2 = num;
				num = (short)1998374225;
				switch (num2 == num)
				{
				}
				num = (short)1811218432;
				short num3 = num;
				num = (short)669777921;
				if (num != 0)
				{
				}
				num = (short)302776320;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.HiddenStatic = value;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x00317588 File Offset: 0x00315788
		// (set) Token: 0x06003343 RID: 13123 RVA: 0x0031763C File Offset: 0x0031583C
		internal bool RadWideFeaturesRadioInhibitUIEnabled_44914_HiddenDynamic
		{
			get
			{
				short num = (short)1465754131;
				short num2 = num;
				num = (short)1907139091;
				switch (num2 == num)
				{
				}
				num = (short)995557376;
				short num3 = num;
				num = (short)1729429504;
				if (num != 0)
				{
				}
				num = (short)2107506689;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914.HiddenDynamic;
			}
			set
			{
				short num = (short)66682641;
				short num2 = num;
				num = (short)230653713;
				switch (num2 == num)
				{
				}
				num = (short)1586429952;
				short num3 = num;
				num = (short)229965825;
				if (num != 0)
				{
				}
				num = (short)274464768;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitUIEnabled_44914.HiddenDynamic = value;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x003176F0 File Offset: 0x003158F0
		public bool RadWideFeaturesRadioInhibitUIEnabled_44914_HasDiffs
		{
			get
			{
				short num = (short)328753555;
				short num2 = num;
				num = (short)696738195;
				switch (num2 == num)
				{
				}
				num = (short)32571392;
				short num3 = num;
				num = (short)568721408;
				if (num != 0)
				{
				}
				num = (short)1380843521;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitUIEnabled_44914._HasDiffs;
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x003177A8 File Offset: 0x003159A8
		// (set) Token: 0x06003346 RID: 13126 RVA: 0x0031785C File Offset: 0x00315A5C
		public string RadWideFeaturesRadioInhibitDisplayTextLine1_44915Value
		{
			get
			{
				short num = (short)1304421010;
				short num2 = num;
				num = (short)906289810;
				switch (num2 == num)
				{
				}
				num = (short)1645543424;
				short num3 = num;
				num = (short)348717057;
				if (num != 0)
				{
				}
				num = (short)216989696;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Value;
			}
			set
			{
				short num = (short)832297238;
				short num2 = num;
				num = (short)1764022550;
				switch (num2 == num)
				{
				}
				num = (short)2069889024;
				short num3 = num;
				num = (short)246087681;
				if (num != 0)
				{
				}
				num = (short)1012072448;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Value = value;
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06003347 RID: 13127 RVA: 0x00317914 File Offset: 0x00315B14
		public global::AcpBusinessLayer.AcpField<string> RadWideFeaturesRadioInhibitDisplayTextLine1_44915
		{
			get
			{
				short num = (short)464104081;
				short num2 = num;
				num = (short)752265873;
				switch (num2 == num)
				{
				}
				num = (short)1439694849;
				if (num != 0)
				{
				}
				num = (short)777191424;
				short num3 = num;
				num = (short)124911616;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x003179C4 File Offset: 0x00315BC4
		// (set) Token: 0x06003349 RID: 13129 RVA: 0x00317A7C File Offset: 0x00315C7C
		public string RadWideFeaturesRadioInhibitDisplayTextLine1_44915_UIValue
		{
			get
			{
				short num = (short)1349451777;
				if (num != 0)
				{
				}
				num = (short)1262057940;
				short num2 = num;
				num = (short)44857812;
				switch (num2 == num)
				{
				}
				num = (short)1194262528;
				short num3 = num;
				num = (short)391184384;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Value;
			}
			set
			{
				short num = (short)694832920;
				short num2 = num;
				num = (short)753880856;
				switch (num2 == num)
				{
				}
				num = (short)1504903169;
				if (num != 0)
				{
				}
				num = (short)286523392;
				short num3 = num;
				num = (short)641859584;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Value = value;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x00317B30 File Offset: 0x00315D30
		// (set) Token: 0x0600334B RID: 13131 RVA: 0x00317BE4 File Offset: 0x00315DE4
		public bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_Applicable
		{
			get
			{
				short num = (short)1357962355;
				short num2 = num;
				num = (short)1685511283;
				switch (num2 == num)
				{
				}
				num = (short)1835401216;
				if (num != 0)
				{
				}
				num = (short)1785397248;
				short num3 = num;
				num = (short)1446641665;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Applicable;
			}
			set
			{
				short num = (short)2112722255;
				short num2 = num;
				num = (short)567973199;
				switch (num2 == num)
				{
				}
				num = (short)1758593024;
				if (num != 0)
				{
				}
				num = (short)351928320;
				short num3 = num;
				num = (short)1355546625;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Applicable = value;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x00317C98 File Offset: 0x00315E98
		// (set) Token: 0x0600334D RID: 13133 RVA: 0x00317D50 File Offset: 0x00315F50
		public bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_Valid
		{
			get
			{
				short num = (short)165246381;
				short num2 = num;
				num = (short)1308784045;
				switch (num2 == num)
				{
				}
				num = (short)1334247425;
				if (num != 0)
				{
				}
				num = (short)743571456;
				short num3 = num;
				num = (short)1799618560;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Valid;
			}
			set
			{
				short num = (short)1578535831;
				short num2 = num;
				num = (short)1961069463;
				switch (num2 == num)
				{
				}
				num = (short)708050945;
				if (num != 0)
				{
				}
				num = (short)20774912;
				short num3 = num;
				num = (short)243073024;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Valid = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600334E RID: 13134 RVA: 0x00317E08 File Offset: 0x00316008
		// (set) Token: 0x0600334F RID: 13135 RVA: 0x00317EBC File Offset: 0x003160BC
		public bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_Visible
		{
			get
			{
				short num = (short)313847208;
				short num2 = num;
				num = (short)2004610472;
				switch (num2 == num)
				{
				}
				num = (short)1750597633;
				if (num != 0)
				{
				}
				num = (short)626458624;
				short num3 = num;
				num = (short)724238336;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Visible;
			}
			set
			{
				short num = (short)2015560488;
				short num2 = num;
				num = (short)1054671656;
				switch (num2 == num)
				{
				}
				num = (short)588447745;
				if (num != 0)
				{
				}
				num = (short)1230241792;
				short num3 = num;
				num = (short)1180303360;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Visible = value;
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x00317F74 File Offset: 0x00316174
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x00318028 File Offset: 0x00316228
		public bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_Editable
		{
			get
			{
				short num = (short)724498276;
				short num2 = num;
				num = (short)152893284;
				switch (num2 == num)
				{
				}
				num = (short)2058158080;
				if (num != 0)
				{
				}
				num = (short)1645412352;
				short num3 = num;
				num = (short)2035548161;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Editable;
			}
			set
			{
				short num = (short)1182728193;
				if (num != 0)
				{
				}
				num = (short)1583669428;
				short num2 = num;
				num = (short)713810100;
				switch (num2 == num)
				{
				}
				num = (short)1741094912;
				short num3 = num;
				num = (short)483393536;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.Editable = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x003180DC File Offset: 0x003162DC
		internal string RadWideFeaturesRadioInhibitDisplayTextLine1_44915_UILabel
		{
			get
			{
				short num = (short)1965730038;
				short num2 = num;
				num = (short)403941622;
				switch (num2 == num)
				{
				}
				num = (short)1416036353;
				if (num != 0)
				{
				}
				num = (short)959119360;
				short num3 = num;
				num = (short)1796800512;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.UIName;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x00318190 File Offset: 0x00316390
		// (set) Token: 0x06003354 RID: 13140 RVA: 0x00318248 File Offset: 0x00316448
		internal bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_HiddenStatic
		{
			get
			{
				short num = (short)170221698;
				short num2 = num;
				num = (short)920936578;
				switch (num2 == num)
				{
				}
				num = (short)1611530241;
				if (num != 0)
				{
				}
				num = (short)1892417536;
				short num3 = num;
				num = (short)1319370752;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.HiddenStatic;
			}
			set
			{
				short num = (short)848840412;
				short num2 = num;
				num = (short)1458849500;
				switch (num2 == num)
				{
				}
				num = (short)1870790657;
				if (num != 0)
				{
				}
				num = (short)2023686144;
				short num3 = num;
				num = (short)9175040;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.HiddenStatic = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x00318300 File Offset: 0x00316500
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x003183B4 File Offset: 0x003165B4
		internal bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_HiddenDynamic
		{
			get
			{
				short num = (short)1931016141;
				short num2 = num;
				num = (short)1407907789;
				switch (num2 == num)
				{
				}
				num = (short)2126446592;
				if (num != 0)
				{
				}
				num = (short)1816526848;
				short num3 = num;
				num = (short)1899429889;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.HiddenDynamic;
			}
			set
			{
				short num = (short)472865953;
				short num2 = num;
				num = (short)432037025;
				switch (num2 == num)
				{
				}
				num = (short)2133983233;
				if (num != 0)
				{
				}
				num = (short)1019609088;
				short num3 = num;
				num = (short)1497235456;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine1_44915.HiddenDynamic = value;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x00318468 File Offset: 0x00316668
		public bool RadWideFeaturesRadioInhibitDisplayTextLine1_44915_HasDiffs
		{
			get
			{
				short num = (short)107864938;
				short num2 = num;
				num = (short)492823402;
				switch (num2 == num)
				{
				}
				num = (short)1603862528;
				if (num != 0)
				{
				}
				num = (short)700776448;
				short num3 = num;
				num = (short)2129330177;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine1_44915._HasDiffs;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x0031851C File Offset: 0x0031671C
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x003185D0 File Offset: 0x003167D0
		public string RadWideFeaturesRadioInhibitDisplayTextLine2_44916Value
		{
			get
			{
				short num = (short)73531393;
				if (num != 0)
				{
				}
				num = (short)213447420;
				short num2 = num;
				num = (short)1768026876;
				switch (num2 == num)
				{
				}
				num = (short)540213248;
				short num3 = num;
				num = (short)373293056;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Value;
			}
			set
			{
				short num = (short)1015864667;
				short num2 = num;
				num = (short)1809898843;
				switch (num2 == num)
				{
				}
				num = (short)1739587585;
				if (num != 0)
				{
				}
				num = (short)1380384768;
				short num3 = num;
				num = (short)1957888000;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Value = value;
			}
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x00318684 File Offset: 0x00316884
		public global::AcpBusinessLayer.AcpField<string> RadWideFeaturesRadioInhibitDisplayTextLine2_44916
		{
			get
			{
				short num = (short)1388733810;
				short num2 = num;
				num = (short)144860530;
				switch (num2 == num)
				{
				}
				num = (short)1728643072;
				if (num != 0)
				{
				}
				num = (short)719126528;
				short num3 = num;
				num = (short)1697382401;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x00318734 File Offset: 0x00316934
		// (set) Token: 0x0600335C RID: 13148 RVA: 0x003187E8 File Offset: 0x003169E8
		public string RadWideFeaturesRadioInhibitDisplayTextLine2_44916_UIValue
		{
			get
			{
				short num = (short)295950871;
				short num2 = num;
				num = (short)1844632087;
				switch (num2 == num)
				{
				}
				num = (short)701497345;
				if (num != 0)
				{
				}
				num = (short)1200488448;
				short num3 = num;
				num = (short)977207296;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Value;
			}
			set
			{
				short num = (short)1001018944;
				short num2 = num;
				num = (short)1758746176;
				switch (num2 == num)
				{
				}
				num = (short)771162113;
				if (num != 0)
				{
				}
				num = (short)1599275008;
				short num3 = num;
				num = (short)530841600;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Value = value;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x003188A0 File Offset: 0x00316AA0
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x00318958 File Offset: 0x00316B58
		public bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_Applicable
		{
			get
			{
				short num = (short)1713854940;
				short num2 = num;
				num = (short)731994588;
				switch (num2 == num)
				{
				}
				num = (short)118358017;
				if (num != 0)
				{
				}
				num = (short)1621753856;
				short num3 = num;
				num = (short)486801408;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Applicable;
			}
			set
			{
				short num = (short)1308278044;
				short num2 = num;
				num = (short)2088418588;
				switch (num2 == num)
				{
				}
				num = (short)1073807361;
				if (num != 0)
				{
				}
				num = (short)1281228800;
				short num3 = num;
				num = (short)1997930496;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Applicable = value;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x00318A0C File Offset: 0x00316C0C
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x00318AC0 File Offset: 0x00316CC0
		public bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_Valid
		{
			get
			{
				short num = (short)618848584;
				short num2 = num;
				num = (short)583590216;
				switch (num2 == num)
				{
				}
				num = (short)391970817;
				if (num != 0)
				{
				}
				num = (short)488636416;
				short num3 = num;
				num = (short)903544832;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Valid;
			}
			set
			{
				short num = (short)1633345792;
				short num2 = num;
				num = (short)1958144;
				switch (num2 == num)
				{
				}
				num = (short)1968242689;
				if (num != 0)
				{
				}
				num = (short)1821507584;
				short num3 = num;
				num = (short)1679097856;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Valid = value;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x00318B74 File Offset: 0x00316D74
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x00318C28 File Offset: 0x00316E28
		public bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_Visible
		{
			get
			{
				short num = (short)50308406;
				short num2 = num;
				num = (short)1697031478;
				switch (num2 == num)
				{
				}
				num = (short)1495990273;
				if (num != 0)
				{
				}
				num = (short)816513024;
				short num3 = num;
				num = (short)790691840;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Visible;
			}
			set
			{
				short num = (short)1467441570;
				short num2 = num;
				num = (short)410345890;
				switch (num2 == num)
				{
				}
				num = (short)390922241;
				if (num != 0)
				{
				}
				num = (short)1491992576;
				short num3 = num;
				num = (short)1775763456;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Visible = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x00318CE0 File Offset: 0x00316EE0
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x00318D94 File Offset: 0x00316F94
		public bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_Editable
		{
			get
			{
				short num = (short)1901140842;
				short num2 = num;
				num = (short)355146602;
				switch (num2 == num)
				{
				}
				num = (short)1795162113;
				if (num != 0)
				{
				}
				num = (short)1268056064;
				short num3 = num;
				num = (short)1359282176;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Editable;
			}
			set
			{
				short num = (short)473301774;
				short num2 = num;
				num = (short)779027214;
				switch (num2 == num)
				{
				}
				num = (short)1212153857;
				if (num != 0)
				{
				}
				num = (short)1699151872;
				short num3 = num;
				num = (short)1825243136;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.Editable = value;
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x00318E48 File Offset: 0x00317048
		internal string RadWideFeaturesRadioInhibitDisplayTextLine2_44916_UILabel
		{
			get
			{
				short num = (short)173951000;
				short num2 = num;
				num = (short)313542680;
				switch (num2 == num)
				{
				}
				num = (short)431489025;
				if (num != 0)
				{
				}
				num = (short)219348992;
				short num3 = num;
				num = (short)1126105088;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.UIName;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06003366 RID: 13158 RVA: 0x00318F00 File Offset: 0x00317100
		// (set) Token: 0x06003367 RID: 13159 RVA: 0x00318FB4 File Offset: 0x003171B4
		internal bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_HiddenStatic
		{
			get
			{
				short num = (short)83516204;
				short num2 = num;
				num = (short)1981438764;
				switch (num2 == num)
				{
				}
				num = (short)1767899136;
				if (num != 0)
				{
				}
				num = (short)763166720;
				short num3 = num;
				num = (short)1193934849;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.HiddenStatic;
			}
			set
			{
				short num = (short)2094115409;
				short num2 = num;
				num = (short)986425937;
				switch (num2 == num)
				{
				}
				num = (short)2139750401;
				if (num != 0)
				{
				}
				num = (short)1695875072;
				short num3 = num;
				num = (short)1758134272;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.HiddenStatic = value;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06003368 RID: 13160 RVA: 0x00319068 File Offset: 0x00317268
		// (set) Token: 0x06003369 RID: 13161 RVA: 0x00319120 File Offset: 0x00317320
		internal bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_HiddenDynamic
		{
			get
			{
				short num = (short)1999044609;
				if (num != 0)
				{
				}
				num = (short)302655680;
				short num2 = num;
				num = (short)1877682368;
				switch (num2 == num)
				{
				}
				num = (short)13434880;
				short num3 = num;
				num = (short)1338703872;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.HiddenDynamic;
			}
			set
			{
				short num = (short)800260097;
				if (num != 0)
				{
				}
				num = (short)524964419;
				short num2 = num;
				num = (short)493703747;
				switch (num2 == num)
				{
				}
				num = (short)853147648;
				short num3 = num;
				num = (short)841416704;
				if (num != 0)
				{
				}
				this.radWideFeaturesRadioInhibitDisplayTextLine2_44916.HiddenDynamic = value;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x003191D4 File Offset: 0x003173D4
		public bool RadWideFeaturesRadioInhibitDisplayTextLine2_44916_HasDiffs
		{
			get
			{
				short num = (short)148016814;
				short num2 = num;
				num = (short)1151438510;
				switch (num2 == num)
				{
				}
				num = (short)2077949953;
				if (num != 0)
				{
				}
				num = (short)375259136;
				short num3 = num;
				num = (short)2096955392;
				if (num != 0)
				{
				}
				return this.radWideFeaturesRadioInhibitDisplayTextLine2_44916._HasDiffs;
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x00319288 File Offset: 0x00317488
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x0031933C File Offset: 0x0031753C
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945Value
		{
			get
			{
				short num = (short)988708103;
				short num2 = num;
				num = (short)996375815;
				switch (num2 == num)
				{
				}
				num = (short)1291976704;
				if (num != 0)
				{
				}
				num = (short)1726021632;
				short num3 = num;
				num = (short)1570045953;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Value;
			}
			set
			{
				short num = (short)1022689281;
				if (num != 0)
				{
				}
				num = (short)1919275085;
				short num2 = num;
				num = (short)1978585165;
				switch (num2 == num)
				{
				}
				num = (short)1631715328;
				short num3 = num;
				num = (short)1127677952;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Value = value;
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x003193F0 File Offset: 0x003175F0
		public global::AcpBusinessLayer.AcpField<bool> RadWideFeaturesEnableInvalidSIMNotification_A44945
		{
			get
			{
				short num = (short)1029879898;
				short num2 = num;
				num = (short)1455274074;
				switch (num2 == num)
				{
				}
				num = (short)1409286145;
				if (num != 0)
				{
				}
				num = (short)1367736320;
				short num3 = num;
				num = (short)261816320;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945;
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x0031949C File Offset: 0x0031769C
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x00319554 File Offset: 0x00317754
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_UIValue
		{
			get
			{
				short num = (short)900893;
				short num2 = num;
				num = (short)1664139037;
				switch (num2 == num)
				{
				}
				num = (short)1296498689;
				if (num != 0)
				{
				}
				num = (short)594608128;
				short num3 = num;
				num = (short)1870725120;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Value;
			}
			set
			{
				short num = (short)1178173216;
				short num2 = num;
				num = (short)1544781600;
				switch (num2 == num)
				{
				}
				num = (short)2070544385;
				if (num != 0)
				{
				}
				num = (short)669974528;
				short num3 = num;
				num = (short)866582528;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Value = value;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x0031960C File Offset: 0x0031780C
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x003196C0 File Offset: 0x003178C0
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_Applicable
		{
			get
			{
				short num = (short)1238483081;
				short num2 = num;
				num = (short)585351305;
				switch (num2 == num)
				{
				}
				num = (short)1326514176;
				if (num != 0)
				{
				}
				num = (short)1965752320;
				short num3 = num;
				num = (short)517865473;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Applicable;
			}
			set
			{
				short num = (short)1288741151;
				short num2 = num;
				num = (short)1418567967;
				switch (num2 == num)
				{
				}
				num = (short)1278345217;
				if (num != 0)
				{
				}
				num = (short)454754304;
				short num3 = num;
				num = (short)1642070016;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Applicable = value;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x00319774 File Offset: 0x00317974
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x00319828 File Offset: 0x00317A28
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_Valid
		{
			get
			{
				short num = (short)12622625;
				short num2 = num;
				num = (short)399285025;
				switch (num2 == num)
				{
				}
				num = (short)482148352;
				if (num != 0)
				{
				}
				num = (short)1625948160;
				short num3 = num;
				num = (short)894631937;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Valid;
			}
			set
			{
				short num = (short)1350041601;
				if (num != 0)
				{
				}
				num = (short)1890709203;
				short num2 = num;
				num = (short)617082579;
				switch (num2 == num)
				{
				}
				num = (short)1712783360;
				short num3 = num;
				num = (short)1843134464;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Valid = value;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x003198DC File Offset: 0x00317ADC
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x00319990 File Offset: 0x00317B90
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_Visible
		{
			get
			{
				short num = (short)1717099428;
				short num2 = num;
				num = (short)2055658404;
				switch (num2 == num)
				{
				}
				num = (short)883687425;
				if (num != 0)
				{
				}
				num = (short)507707392;
				short num3 = num;
				num = (short)124911616;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Visible;
			}
			set
			{
				short num = (short)526448251;
				short num2 = num;
				num = (short)606205563;
				switch (num2 == num)
				{
				}
				num = (short)1831862273;
				if (num != 0)
				{
				}
				num = (short)1160118272;
				short num3 = num;
				num = (short)1801846784;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Visible = value;
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x00319A44 File Offset: 0x00317C44
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x00319AF8 File Offset: 0x00317CF8
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_Editable
		{
			get
			{
				short num = (short)466526424;
				short num2 = num;
				num = (short)1699193048;
				switch (num2 == num)
				{
				}
				num = (short)2021326849;
				if (num != 0)
				{
				}
				num = (short)655360000;
				short num3 = num;
				num = (short)2064056320;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.Editable;
			}
			set
			{
				short num = (short)1330438824;
				short num2 = num;
				num = (short)433709736;
				switch (num2 == num)
				{
				}
				num = (short)594018304;
				if (num != 0)
				{
				}
				num = (short)498532352;
				short num3 = num;
				num = (short)303759361;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.Editable = value;
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x00319BB0 File Offset: 0x00317DB0
		internal string RadWideFeaturesEnableInvalidSIMNotification_A44945_UILabel
		{
			get
			{
				short num = (short)1525770416;
				short num2 = num;
				num = (short)337406128;
				switch (num2 == num)
				{
				}
				num = (short)2122776577;
				if (num != 0)
				{
				}
				num = (short)1099694080;
				short num3 = num;
				num = (short)1167130624;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.UIName;
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x00319C64 File Offset: 0x00317E64
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x00319D18 File Offset: 0x00317F18
		internal bool RadWideFeaturesEnableInvalidSIMNotification_A44945_HiddenStatic
		{
			get
			{
				short num = (short)842530817;
				if (num != 0)
				{
				}
				num = (short)1971699369;
				short num2 = num;
				num = (short)106872489;
				switch (num2 == num)
				{
				}
				num = (short)2040922112;
				short num3 = num;
				num = (short)2072182784;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.HiddenStatic;
			}
			set
			{
				short num = (short)1973193749;
				short num2 = num;
				num = (short)1113230357;
				switch (num2 == num)
				{
				}
				num = (short)497680385;
				if (num != 0)
				{
				}
				num = (short)1720320000;
				short num3 = num;
				num = (short)1929707520;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.HiddenStatic = value;
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x0600337B RID: 13179 RVA: 0x00319DC8 File Offset: 0x00317FC8
		// (set) Token: 0x0600337C RID: 13180 RVA: 0x00319E7C File Offset: 0x0031807C
		internal bool RadWideFeaturesEnableInvalidSIMNotification_A44945_HiddenDynamic
		{
			get
			{
				short num = (short)2027127864;
				short num2 = num;
				num = (short)106923064;
				switch (num2 == num)
				{
				}
				num = (short)1441267713;
				if (num != 0)
				{
				}
				num = (short)1892089856;
				short num3 = num;
				num = (short)1173487616;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945.HiddenDynamic;
			}
			set
			{
				short num = (short)72711456;
				short num2 = num;
				num = (short)1346927904;
				switch (num2 == num)
				{
				}
				num = (short)1540685825;
				if (num != 0)
				{
				}
				num = (short)1655701504;
				short num3 = num;
				num = (short)779616256;
				if (num != 0)
				{
				}
				this.radWideFeaturesEnableInvalidSIMNotification_A44945.HiddenDynamic = value;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x0600337D RID: 13181 RVA: 0x00319F34 File Offset: 0x00318134
		public bool RadWideFeaturesEnableInvalidSIMNotification_A44945_HasDiffs
		{
			get
			{
				short num = (short)356318975;
				short num2 = num;
				num = (short)97517311;
				switch (num2 == num)
				{
				}
				num = (short)1800142848;
				if (num != 0)
				{
				}
				num = (short)1283719168;
				short num3 = num;
				num = (short)1688993793;
				if (num != 0)
				{
				}
				return this.radWideFeaturesEnableInvalidSIMNotification_A44945._HasDiffs;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x00319FE8 File Offset: 0x003181E8
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1419116545;
				if (num != 0)
				{
				}
				num = (short)1944474705;
				short num2 = num;
				num = (short)1174164561;
				switch (num2 == num)
				{
				}
				num = (short)1047396352;
				short num3 = num;
				num = (short)240386048;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0031A0A8 File Offset: 0x003182A8
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
						num2 = (short)911736836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)58851329;
					if (num2 != 0)
					{
					}
					num2 = (short)1625358336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)362422263;
					short num3 = num2;
					num2 = (short)334438391;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10F;
					default:
					{
						num2 = (short)661585920;
						short num4 = num2;
						num2 = (short)196608000;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)991035393;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_10F;
				}
				goto IL_24;
				IL_10F:
				num2 = (short)1574371331;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)811859970;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400116B RID: 4459
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x0400116C RID: 4460
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesChannelFallbackEnable;

		// Token: 0x0400116D RID: 4461
		private global::AcpBusinessLayer.AcpField<bool> radWideAdvancedCyclicKeying_A7795;

		// Token: 0x0400116E RID: 4462
		private global::AcpBusinessLayer.AcpField<bool> radWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x0400116F RID: 4463
		private global::AcpBusinessLayer.AcpField<bool> znChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x04001170 RID: 4464
		private global::AcpBusinessLayer.AcpField<bool> radWideAdvancedPreAmp_A8733;

		// Token: 0x04001171 RID: 4465
		private global::AcpBusinessLayer.AcpListField radWideAdvancedRecordAudio_A8922;

		// Token: 0x04001172 RID: 4466
		private global::AcpBusinessLayer.AcpListField radWideAdvancedRFModem_A8972;

		// Token: 0x04001173 RID: 4467
		private global::AcpBusinessLayer.AcpListField radWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x04001174 RID: 4468
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A12643;

		// Token: 0x04001175 RID: 4469
		private global::AcpBusinessLayer.AcpCustomRangeField radWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x04001176 RID: 4470
		private global::AcpBusinessLayer.AcpCustomRangeField radWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x04001177 RID: 4471
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001178 RID: 4472
		private global::AcpBusinessLayer.AcpListField radWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x04001179 RID: 4473
		private global::AcpBusinessLayer.AcpListField radWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400117A RID: 4474
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x0400117B RID: 4475
		private global::AcpBusinessLayer.AcpRecRefField radWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x0400117C RID: 4476
		private global::AcpBusinessLayer.AcpRecRefField radWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x0400117D RID: 4477
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x0400117E RID: 4478
		private global::AcpBusinessLayer.AcpField<bool> isolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x0400117F RID: 4479
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpVHF_A42960;

		// Token: 0x04001180 RID: 4480
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001181 RID: 4481
		private global::AcpBusinessLayer.AcpField<bool> radWideFeatureDynamicIcons_A42963;

		// Token: 0x04001182 RID: 4482
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesNFPACompliant;

		// Token: 0x04001183 RID: 4483
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001184 RID: 4484
		private global::AcpBusinessLayer.AcpListField radWideFeaturesExtRFRoute_A43020;

		// Token: 0x04001185 RID: 4485
		private global::AcpBusinessLayer.AcpListField radWideFeaturesRadioCertificationType_43064;

		// Token: 0x04001186 RID: 4486
		private global::AcpBusinessLayer.AcpListField radWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x04001187 RID: 4487
		private global::AcpBusinessLayer.AcpCustomRangeField radWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001188 RID: 4488
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesZoneCloneEnable_43130;

		// Token: 0x04001189 RID: 4489
		private global::AcpBusinessLayer.AcpListField radWideFeaturesVoiceControlPriority;

		// Token: 0x0400118A RID: 4490
		private global::AcpBusinessLayer.AcpListField radCfgVirtualPartnerMode;

		// Token: 0x0400118B RID: 4491
		private global::AcpBusinessLayer.AcpListField radWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400118C RID: 4492
		private global::AcpBusinessLayer.AcpSimpleRangeField radCfgVirtualPartnerInactivityTime;

		// Token: 0x0400118D RID: 4493
		private global::AcpBusinessLayer.AcpListField radWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x0400118E RID: 4494
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideFeaturesPowerManagementStandbyTime;

		// Token: 0x0400118F RID: 4495
		private global::AcpBusinessLayer.AcpField<bool> radWideFeatureAnalogWidebandData;

		// Token: 0x04001190 RID: 4496
		private global::AcpBusinessLayer.AcpField<bool> radWideCustomLogoEnabled;

		// Token: 0x04001191 RID: 4497
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x04001192 RID: 4498
		private global::AcpBusinessLayer.AcpField<string> radWideFeaturesRadioInhibitDisplayTextLine1_44915;

		// Token: 0x04001193 RID: 4499
		private global::AcpBusinessLayer.AcpField<string> radWideFeaturesRadioInhibitDisplayTextLine2_44916;

		// Token: 0x04001194 RID: 4500
		private global::AcpBusinessLayer.AcpField<bool> radWideFeaturesEnableInvalidSIMNotification_A44945;
	}
}
