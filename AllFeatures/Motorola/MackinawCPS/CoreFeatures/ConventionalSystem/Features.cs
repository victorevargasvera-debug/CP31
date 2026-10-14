using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000570 RID: 1392
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B964 RID: 47460 RVA: 0x00AC0D34 File Offset: 0x00ABEF34
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x00AC0D50 File Offset: 0x00ABEF50
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x00AC0D68 File Offset: 0x00ABEF68
		public override void Init()
		{
			int a_ = 5;
			short num = (short)989946633;
			short num2 = num;
			num = (short)650339081;
			switch (num2 == num)
			{
			}
			num = (short)1139081216;
			short num3 = num;
			num = (short)370278400;
			if (num != 0)
			{
			}
			num = (short)1156710401;
			if (num != 0)
			{
			}
			this.cnvSysFeaturesAutoResetTimesec_A7511 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꏡ釣鋥蟧룩觫鷭闯蛱ꃳ鿵闷鿹迻鯽揿崁䔃ㄅ㴇㬉㴋", a_), global::CommonResources.AcgResources.ID_AUTORESETTIMESEC, 0, 255, null, null, 0, 1);
			this.cnvSysFeaturesAutoResetTimesec_A7511.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesAutoResetTimesec_A7511.DataTransferOrder = 24;
			this.cnvSysFeaturesAutoResetTimesec_A7511.ShowHexValue = false;
			this.cnvSysFeaturesCAIDataRegistration_A7585 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꇡꗣ꿥곧诩飫迭ꋯ韱鏳鿵请軹軻鿽瓿欁欃栅圇䬉㬋㬍⠏✑", a_), global::CommonResources.AcgResources.ID_CAIDATAREGISTRATION);
			this.cnvSysFeaturesCAIDataRegistration_A7585.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesCAIDataRegistration_A7585.DataTransferOrder = 40;
			this.cnvSysFeaturesCAIDataRegistration_A7585.EvaluateRecRefs = true;
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꛡ藣鋥觧ꗩ鳫语苯鏱胳鏵鳷꧹跻诽旿渁會清䰇䔉弋儍儏┑⌓⼕⸗", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDATAOPERATEDSQUELCHDOS);
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.DataTransferOrder = 8;
			this.cnvSysFeaturesDOSCoastTimems_A7890 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꛡꯣ뗥ꯧ藩跫鷭蓯꛱鷳鯵鷷韹迻ꇽ䇿㔁㰃㼅㠇", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDOSCOASTTIMEMS, 0, 255, global::AllFeatures.CodeplugGuid.b("", a_), global::AllFeatures.CodeplugGuid.b("﯇﷉溜", a_), 0, 25);
			this.cnvSysFeaturesDOSCoastTimems_A7890.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysFeaturesDOSCoastTimems_A7890.DataTransferOrder = 41;
			this.cnvSysFeaturesDOSCoastTimems_A7890.ShowHexValue = false;
			this.cnvSysFeaturesDOSOperation_A7891 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꛡꯣ뗥꟧髩觫鳭釯蛱鷳駵雷ꗹ뷻짽㣿㬁㔃", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDOSOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesDOSOperation_A7891LovStrs);
			this.cnvSysFeaturesDOSOperation_A7891.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysFeaturesDOSOperation_A7891.DataTransferOrder = 25;
			this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟꟡解菥髧跩觫胭鏯诱뗳髵駷裹釻곽磿䬁樃戅愇椉洋稍缏怑䬓圕⼗⌙⼛⸝", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRXINDICATOR);
			this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.DataTransferOrder = 27;
			this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟돡釣蟥蓧菩諫韭뗯鿱釳蓵鿷鿹鋻鷽秿䌁栃朅稇有帋瘍伏匑⌓⼕⬗⬙", a_), global::CommonResources.AcgResources.ID_QUALIFYEMERGENCYALARMRX);
			this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.DataTransferOrder = 111;
			this.cnvSysFeaturesMessage_A8497 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟꿡臣闥鯧诩诫语꿯돱쳳싵쇷췹", a_), global::CommonResources.AcgResources.ID_MESSAGE);
			this.cnvSysFeaturesMessage_A8497.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesMessage_A8497.DataTransferOrder = 45;
			this.cnvSysFeaturesMessage_A8497.EvaluateRecRefs = true;
			this.cnvSysFeaturesRadioCheck_A8826 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟냡藣若臧藩꿫蛭闯釱鿳꧵맷싹쓻쳽㛿", a_), global::CommonResources.AcgResources.ID_RADIOCHECK);
			this.cnvSysFeaturesRadioCheck_A8826.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesRadioCheck_A8826.DataTransferOrder = 22;
			this.cnvSysFeaturesRadioInhibit_A8831 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟냡藣若臧藩ꗫ胭飯鯱雳鿵賷ꗹ뷻웽㣿㄁㔃", a_), global::CommonResources.AcgResources.ID_RADIOINHIBIT);
			this.cnvSysFeaturesRadioInhibit_A8831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesRadioInhibit_A8831.DataTransferOrder = 23;
			this.cnvSysFeaturesRemoteRadioMode_A8935 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.indexCnvSysFeaturesRemoteRadioMode_A8935LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.idCnvSysFeaturesRemoteRadioMode_A8935LovStrs), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟냡臣该蟧黩觫볭釯雱鷳駵뗷闹飻鯽忿䌁㰃㼅㬇㼉", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACEREMOTERADIOMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesRemoteRadioMode_A8935LovStrs);
			this.cnvSysFeaturesRemoteRadioMode_A8935.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesRemoteRadioMode_A8935.DataTransferOrder = 12;
			this.cnvSysFeaturesSelectCallInCallReset_A9102 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.indexCnvSysFeaturesSelectCallInCallReset_A9102LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.idCnvSysFeaturesSelectCallInCallReset_A9102LovStrs), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟뇡臣諥跧觩飫귭釯黱飳뿵雷맹鷻鋽泿倁愃甅洇縉匋伍⤏⌑␓␕", a_), global::CommonResources.AcgResources.ID_SELECTCALLINCALLRESET, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesSelectCallInCallReset_A9102LovStrs);
			this.cnvSysFeaturesSelectCallInCallReset_A9102.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesSelectCallInCallReset_A9102.DataTransferOrder = 5;
			this.cnvSysFeaturesStatus_A9186 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟뇡郣蟥鳧鿩鿫뇭뇯쯱엳컵컷", a_), global::CommonResources.AcgResources.ID_STATUS);
			this.cnvSysFeaturesStatus_A9186.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesStatus_A9186.DataTransferOrder = 13;
			this.cnvSysFeaturesStatus_A9186.EvaluateRecRefs = true;
			this.cnvSysFeaturesStatusRequest_A9198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟뇡郣蟥鳧鿩鿫볭闯菱至鏵请軹ꏻ뿽㧿㌁㴃㸅", a_), global::CommonResources.AcgResources.ID_STATUSREQUEST);
			this.cnvSysFeaturesStatusRequest_A9198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesStatusRequest_A9198.DataTransferOrder = 54;
			this.dataProfFeaturesTextMessagingService_A9372 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣닥跧鋩飫ꏭ闯臱蟳韵鿷鏹鋻駽叿朁瘃瀅愇椉椋儍儏⬑✓ℕ⨗", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.DataProfFeaturesTextMessagingService_A9372LovStrs);
			this.dataProfFeaturesTextMessagingService_A9372.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesTextMessagingService_A9372.DataTransferOrder = 71;
			this.cnvSysFeaturesExtendedDispatchEn_A37220 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟꟡鳣鋥跧蓩裫语铯뛱鷳藵裷鯹裻鷽棿䜁樃夅䤇㤉㬋㰍∏∑", a_), global::CommonResources.AcgResources.ID_EXTENDEDDISPATCHENABLE);
			this.cnvSysFeaturesExtendedDispatchEn_A37220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesExtendedDispatchEn_A37220.DataTransferOrder = 72;
			this.cnvSysFeaturesTxBaseTimeSec_A9513 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟뛡鳣ꓥ觧駩觫뫭駯鿱釳ꗵ鷷駹ꏻ뿽㧿㜁㔃㔅", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACETXBASETIMESEC_1, 10, 120, 10);
			this.cnvSysFeaturesTxBaseTimeSec_A9513.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysFeaturesTxBaseTimeSec_A9513.DataTransferOrder = 61;
			this.cnvSysFeaturesTxBaseTimeSec_A9513.ShowHexValue = false;
			this.cnvSysFeaturesDynamicIDEnable_A40100 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꛡ鷣裥觧蟩藫跭맯뛱뇳飵駷飹郻鯽忿䌁〃㘅㤇㨉㰋", a_), global::CommonResources.AcgResources.ID_DYNAMICIDENABLE);
			this.cnvSysFeaturesDynamicIDEnable_A40100.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesDynamicIDEnable_A40100.DataTransferOrder = 64;
			this.cnvSysDVRSPOP25Enable_A40126 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ雑苓蓕诗諙鏛軝틟ퟡꇣ裥觧裩胫语꿯돱샳웵짷죹쫻", a_), global::CommonResources.AcgResources.ID_POP25ENABLE);
			this.cnvSysDVRSPOP25Enable_A40126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSPOP25Enable_A40126.DataTransferOrder = 73;
			this.cnvSysFeaturesEmergencyAckEn_A41546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟꟡解菥髧跩觫胭鏯诱뗳闵鏷뿹鋻ꇽ䇿㘁㔃㌅㰇㰉", a_), global::CommonResources.AcgResources.ID_EMERGENCYACKENABLE);
			this.cnvSysFeaturesEmergencyAckEn_A41546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesEmergencyAckEn_A41546.DataTransferOrder = 80;
			this.cnvSysFeaturesSendLocationToPeer_42427 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟뇡臣裥賧ꛩ菫跭釯蛱鷳駵雷껹鏻껽旿朁瘃夅㰇㠉㠋㰍✏", a_), global::CommonResources.AcgResources.ID_SENDLOCATIONTOPEERONPTT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LegacyTitles.CnvSysFeaturesSendLocationToPeer_42427LegacyTitles);
			this.cnvSysFeaturesSendLocationToPeer_42427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysFeaturesSendLocationToPeer_42427.DataTransferOrder = 51;
			this.cnvSysFeaturesSendLocationToPeer_42427.EvaluateRecRefs = true;
			this.cnvSysFeaturesGroupTMSEable_42809 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟ꗡ難觥鷧髩룫ꏭꏯ럱闳铵铷鿹ꏻ쫽㋿㨁㐃㼅", a_), global::CommonResources.AcgResources.ID_GROUPTEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesGroupTMSEable_42809LovStrs);
			this.cnvSysFeaturesGroupTMSEable_42809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesGroupTMSEable_42809.DataTransferOrder = 76;
			this.cnvSysFeaturesPASelection_A42880 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鿋럍ꏏ铑뇓럕곗꿙껛믝鏟닡ꗣ뗥跧蛩觫跭蓯鯱鯳飵ꟷ믹죻쳽㣿㨁㐃", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.cnvSysFeaturesPASelection_A42880.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeaturesPASelection_A42880.DataTransferOrder = 110;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胅귇ꯉ룋믍ꋏ럑ꟓ", a_);
			base.Id = 10119;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x00AC1444 File Offset: 0x00ABF644
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1010827328;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvSysFeaturesCAIDataRegistration_A7585 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꃢꓤ껦귨諪駬軮ꏰ雲鋴黶諸迺迼黾甀樂樄椆嘈䨊㨌㨎⤐☒", a_), global::CommonResources.AcgResources.ID_CAIDATAREGISTRATION);
					this.cnvSysFeaturesCAIDataRegistration_A7585.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesCAIDataRegistration_A7585.DataTransferOrder = 40;
					this.cnvSysFeaturesCAIDataRegistration_A7585.EvaluateRecRefs = true;
					num = (short)1401749564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠껢胤铦髨諪諬諮껰닲췴쏶샸쳺", a_)))
					{
						num = (short)1221066822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E52;
				case 2:
					this.cnvSysFeaturesExtendedDispatchEn_A37220 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ鷤鏦賨藪觬諮闰럲鳴蓶觸髺觼鳾椀䘂欄堆䠈㠊㨌㴎⌐⌒", a_), global::CommonResources.AcgResources.ID_EXTENDEDDISPATCHENABLE);
					this.cnvSysFeaturesExtendedDispatchEn_A37220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesExtendedDispatchEn_A37220.DataTransferOrder = 72;
					num = (short)1070334023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvSysFeaturesRemoteRadioMode_A8935 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.indexCnvSysFeaturesRemoteRadioMode_A8935LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.idCnvSysFeaturesRemoteRadioMode_A8935LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢胤諦蛨鿪裬뷮郰韲鳴飶듸铺駼髾帀䈂㴄㸆㨈㸊", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACEREMOTERADIOMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesRemoteRadioMode_A8935LovStrs);
					this.cnvSysFeaturesRemoteRadioMode_A8935.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesRemoteRadioMode_A8935.DataTransferOrder = 12;
					num = (short)1768161304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢蓤菦胨蓪ꓬ臮駰髲韴黶跸ꓺ볼쟾㤀。㐄", a_)))
					{
						num = (short)297074694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA0;
				case 5:
					num = (short)1545142273;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢釤蛦鷨黪黬뷮铰苲胴鋶諸迺ꋼ뻾㠀㈂㰄㼆", a_)))
					{
						num = (short)361758785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7DA;
				case 6:
					this.cnvSysFeaturesRadioInhibit_A8831 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢蓤菦胨蓪ꓬ臮駰髲韴黶跸ꓺ볼쟾㤀。㐄", a_), global::CommonResources.AcgResources.ID_RADIOINHIBIT);
					this.cnvSysFeaturesRadioInhibit_A8831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesRadioInhibit_A8831.DataTransferOrder = 23;
					num = (short)1692925963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢釤蛦鷨黪黬냮냰쫲쓴쿶쿸", a_)))
					{
						num = (short)769130517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2A;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢胤諦蛨鿪裬뷮郰韲鳴飶듸铺駼髾帀䈂㴄㸆㨈㸊", a_)))
					{
						num = (short)2058813443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8B;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢胤触跨꟪苬賮郰蟲鳴飶韸꿺鋼꿾搀昂眄堆㴈㤊㤌㴎☐", a_)))
					{
						num = (short)345374789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_362;
				case 10:
					num = (short)1479934008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_BA0;
				case 12:
					goto IL_227;
				case 13:
					goto IL_6D8;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ韒菔藖諘诚鋜连폠훢ꃤ触裨觪臬諮껰닲쇴쟶죸짺쯼", a_)))
					{
						num = (short)760152090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF3;
				case 15:
					this.cnvSysFeaturesTxBaseTimeSec_A9513 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠럢鷤ꗦ裨飪裬믮飰黲郴ꓶ鳸飺ꋼ뻾㠀㘂㐄㐆", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACETXBASETIMESEC_1);
					this.cnvSysFeaturesTxBaseTimeSec_A9513.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysFeaturesTxBaseTimeSec_A9513.DataTransferOrder = 61;
					this.cnvSysFeaturesTxBaseTimeSec_A9513.ShowHexValue = false;
					num = (short)600703008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.cnvSysFeaturesDOSOperation_A7891 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢ꫤ듦ꛨ鯪裬鷮郰蟲鳴飶韸ꓺ볼죾㤀㨂㐄", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDOSOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesDOSOperation_A7891LovStrs);
					this.cnvSysFeaturesDOSOperation_A7891.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysFeaturesDOSOperation_A7891.DataTransferOrder = 25;
					num = (short)1825112116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_10EB;
				case 18:
				{
					num = (short)766430387;
					short num3 = num;
					num = (short)981978291;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D8;
					default:
						num = (short)653393920;
						if (num != 0)
						{
						}
						num = (short)1938358323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠닢郤蛦藨苪诬雮듰黲郴藶黸黺鏼鳾砀䈂椄昆笈昊弌眎丐划∔⸖⨘⨚", a_)))
					{
						num = (short)1446903848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_827;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢蓤菦胨蓪껬蟮铰郲黴ꣶ룸쏺염췾㜀", a_)))
					{
						num = (short)456720428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E0;
				case 21:
					this.cnvSysFeaturesStatus_A9186 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢釤蛦鷨黪黬냮냰쫲쓴쿶쿸", a_), global::CommonResources.AcgResources.ID_STATUS);
					this.cnvSysFeaturesStatus_A9186.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesStatus_A9186.DataTransferOrder = 13;
					this.cnvSysFeaturesStatus_A9186.EvaluateRecRefs = true;
					num = (short)247529508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢蓤鏦裨ꓪ鷬諮菰鋲致鋶鷸꣺購諾搀漂昄漆䴈䐊希倎倐␒∔⸖⼘", a_)))
					{
						num = (short)633733151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E9;
				case 23:
					goto IL_EF3;
				case 24:
					goto IL_F8B;
				case 25:
					this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ裤苦鯨質裬臮鋰諲듴鯶飸觺郼귾礀䨂欄挆怈栊氌笎縐愒䨔嘖⸘√⸜⼞", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRXINDICATOR);
					this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.DataTransferOrder = 27;
					num = (short)361758782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.cnvSysDVRSPOP25Enable_A40126 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ韒菔藖諘诚鋜连폠훢ꃤ触裨觪臬諮껰닲쇴쟶죸짺쯼", a_), global::CommonResources.AcgResources.ID_POP25ENABLE);
					this.cnvSysDVRSPOP25Enable_A40126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSPOP25Enable_A40126.DataTransferOrder = 73;
					num = (short)891027479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꓢ韤裦鳨鯪맬ꋮꋰ뛲铴闶闸黺ꋼ쯾㌀㬂㔄㸆", a_)))
					{
						num = (short)832569391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_494;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ裤苦鯨質裬臮鋰諲듴银鋸뻺鏼ꃾ䀀㜂㐄㈆㴈㴊", a_)))
					{
						num = (short)614858794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_448;
				case 29:
					goto IL_F3F;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔釖볘뫚꧜꫞鏠蛢雤돦賨鏪駬ꋮ铰胲蛴零黸鋺鏼飾刀昂眄焆怈栊栌倎倐⨒☔‖⬘", a_)))
					{
						num = (short)2000224324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_315;
				case 31:
					this.cnvSysFeaturesDataOperatedSquelchDOS_A7796 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢蓤鏦裨ꓪ鷬諮菰鋲致鋶鷸꣺購諾搀漂昄漆䴈䐊希倎倐␒∔⸖⼘", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDATAOPERATEDSQUELCHDOS);
					this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.DataTransferOrder = 8;
					num = (short)27918375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_BE9;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢ꫤ듦ꛨ鯪裬鷮郰蟲鳴飶韸ꓺ볼죾㤀㨂㐄", a_)))
					{
						num = (short)501874704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FC;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢鳤触裨蛪蓬賮룰럲냴駶飸駺釼髾帀䈂㄄㜆㠈㬊㴌", a_)))
					{
						num = (short)841154560;
						short num4 = num;
						num = (short)285212685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8CE;
				case 35:
					goto IL_7DA;
				case 36:
					goto IL_A2A;
				case 37:
					this.cnvSysFeaturesSelectCallInCallReset_A9102 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.indexCnvSysFeaturesSelectCallInCallReset_A9102LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.idCnvSysFeaturesSelectCallInCallReset_A9102LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢胤详賨裪駬곮郰鿲駴뻶韸룺鳼鏾洀儂怄理氈缊刌与⠐−└┖", a_), global::CommonResources.AcgResources.ID_SELECTCALLINCALLRESET, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesSelectCallInCallReset_A9102LovStrs);
					this.cnvSysFeaturesSelectCallInCallReset_A9102.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesSelectCallInCallReset_A9102.DataTransferOrder = 5;
					num = (short)489750595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_4E0;
				case 39:
					goto IL_5E9;
				case 40:
					this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠닢郤蛦藨苪诬雮듰黲郴藶黸黺鏼鳾砀䈂椄昆笈昊弌眎丐划∔⸖⨘⨚", a_), global::CommonResources.AcgResources.ID_QUALIFYEMERGENCYALARMRX);
					this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.DataTransferOrder = 111;
					num = (short)1268645933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_362;
				case 42:
					this.cnvSysFeaturesEmergencyAckEn_A41546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ裤苦鯨質裬臮鋰諲듴银鋸뻺鏼ꃾ䀀㜂㐄㈆㴈㴊", a_), global::CommonResources.AcgResources.ID_EMERGENCYACKENABLE);
					this.cnvSysFeaturesEmergencyAckEn_A41546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesEmergencyAckEn_A41546.DataTransferOrder = 80;
					num = (short)1964441648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					goto IL_494;
				case 44:
					this.cnvSysFeaturesRadioCheck_A8826 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠뇢蓤菦胨蓪껬蟮铰郲黴ꣶ룸쏺염췾㜀", a_), global::CommonResources.AcgResources.ID_RADIOCHECK);
					this.cnvSysFeaturesRadioCheck_A8826.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesRadioCheck_A8826.DataTransferOrder = 22;
					num = (short)27263014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					goto IL_827;
				case 46:
					goto IL_8CE;
				case 47:
					this.cnvSysFeaturesGroupTMSEable_42809 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꓢ韤裦鳨鯪맬ꋮꋰ뛲铴闶闸黺ꋼ쯾㌀㬂㔄㸆", a_), global::CommonResources.AcgResources.ID_GROUPTEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeaturesGroupTMSEable_42809LovStrs);
					this.cnvSysFeaturesGroupTMSEable_42809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesGroupTMSEable_42809.DataTransferOrder = 76;
					num = (short)632291371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					goto IL_448;
				case 49:
					goto IL_315;
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢ꫤ듦ꫨ蓪賬鳮藰ꟲ鳴髶鳸雺軼ꃾ䀀㐂㴄㸆㤈", a_)))
					{
						num = (short)1645346877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꋢ郤鏦蛨맪裬鳮铰蟲ꇴ黶铸黺軼髾戀専䐄〆㰈㨊㰌", a_)))
					{
						num = (short)1306591289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F3F;
				case 52:
					goto IL_3FC;
				case 53:
					this.cnvSysFeaturesPASelection_A42880 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠돢ꓤ듦賨蟪裬賮藰髲髴駶꛸뫺짼췾㤀㬂㔄", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.cnvSysFeaturesPASelection_A42880.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesPASelection_A42880.DataTransferOrder = 110;
					num = (short)101449745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢胤详賨裪駬곮郰鿲駴뻶韸룺鳼鏾洀儂怄理氈缊刌与⠐−└┖", a_)))
					{
						num = (short)12976165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				case 55:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꃢꓤ껦귨諪駬軮ꏰ雲鋴黶諸迺迼黾甀樂樄椆嘈䨊㨌㨎⤐☒", a_)))
					{
						num = (short)1378811904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C9;
				case 56:
					if (producerFields != null)
					{
						num = (short)34013202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B3;
				case 57:
					this.cnvSysFeaturesAutoResetTimesec_A7511 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꋢ郤鏦蛨맪裬鳮铰蟲ꇴ黶铸黺軼髾戀専䐄〆㰈㨊㰌", a_), global::CommonResources.AcgResources.ID_AUTORESETTIMESEC, null, null, 0, 1);
					this.cnvSysFeaturesAutoResetTimesec_A7511.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesAutoResetTimesec_A7511.DataTransferOrder = 24;
					this.cnvSysFeaturesAutoResetTimesec_A7511.ShowHexValue = false;
					num = (short)690487325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠돢ꓤ듦賨蟪裬賮藰髲髴駶꛸뫺짼췾㤀㬂㔄", a_)))
					{
						num = (short)1764753461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B3;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠럢鷤ꗦ裨飪裬믮飰黲郴ꓶ鳸飺ꋼ뻾㠀㘂㐄㐆", a_)))
					{
						num = (short)1269104655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE9;
				case 60:
					goto IL_2C9;
				case 61:
					this.cnvSysFeaturesDOSCoastTimems_A7890 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢ꫤ듦ꫨ蓪賬鳮藰ꟲ鳴髶鳸雺軼ꃾ䀀㐂㴄㸆㤈", a_), global::CommonResources.AcgResources.ID_DATAOPERATEDSQUELCHENABLEDOSCOASTTIMEMS, global::AllFeatures.CodeplugGuid.b("", a_), global::AllFeatures.CodeplugGuid.b("靖ﳊ", a_), 0, 25);
					this.cnvSysFeaturesDOSCoastTimems_A7890.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysFeaturesDOSCoastTimems_A7890.DataTransferOrder = 41;
					this.cnvSysFeaturesDOSCoastTimems_A7890.ShowHexValue = false;
					num = (short)1367998476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					goto IL_637;
				case 63:
					goto IL_E52;
				case 64:
					switch (0)
					{
					case 0:
						goto IL_152;
					}
					continue;
				case 65:
					this.cnvSysFeaturesStatusRequest_A9198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢釤蛦鷨黪黬뷮铰苲胴鋶諸迺ꋼ뻾㠀㈂㰄㼆", a_), global::CommonResources.AcgResources.ID_STATUSREQUEST);
					this.cnvSysFeaturesStatusRequest_A9198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesStatusRequest_A9198.DataTransferOrder = 54;
					num = (short)702349347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ鷤鏦賨藪觬諮闰럲鳴蓶觸髺觼鳾椀䘂欄堆䠈㠊㨌㴎⌐⌒", a_)))
					{
						num = (short)232980482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_178;
				case 67:
					goto IL_3B0;
				case 68:
					this.dataProfFeaturesTextMessagingService_A9372 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔釖볘뫚꧜꫞鏠蛢雤돦賨鏪駬ꋮ铰胲蛴零黸鋺鏼飾刀昂眄焆怈栊栌倎倐⨒☔‖⬘", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.DataProfFeaturesTextMessagingService_A9372LovStrs);
					this.dataProfFeaturesTextMessagingService_A9372.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesTextMessagingService_A9372.DataTransferOrder = 71;
					num = (short)1589116977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					this.cnvSysFeaturesSendLocationToPeer_42427 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠냢胤触跨꟪苬賮郰蟲鳴飶韸꿺鋼꿾搀昂眄堆㴈㤊㤌㴎☐", a_), global::CommonResources.AcgResources.ID_SENDLOCATIONTOPEERONPTT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LegacyTitles.CnvSysFeaturesSendLocationToPeer_42427LegacyTitles);
					this.cnvSysFeaturesSendLocationToPeer_42427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysFeaturesSendLocationToPeer_42427.DataTransferOrder = 51;
					this.cnvSysFeaturesSendLocationToPeer_42427.EvaluateRecRefs = true;
					num = (short)1279262761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 70:
					this.cnvSysFeaturesMessage_A8497 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠껢胤铦髨諪諬諮껰닲췴쏶샸쳺", a_), global::CommonResources.AcgResources.ID_MESSAGE);
					this.cnvSysFeaturesMessage_A8497.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeaturesMessage_A8497.DataTransferOrder = 45;
					this.cnvSysFeaturesMessage_A8497.EvaluateRecRefs = true;
					num = (short)1337393215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 71:
					goto IL_178;
				case 72:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠ꛢ裤苦鯨質裬臮鋰諲듴鯶飸觺郼귾礀䨂欄挆怈栊氌笎縐愒䨔嘖⸘√⸜⼞", a_)))
					{
						num = (short)1810956313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_637;
				}
				IL_152:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1976041482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_178:
				num = (short)1441792059;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_227:
				num = (short)429522977;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C9:
				num = (short)1849753622;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_315:
				num = (short)20906050;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_362:
				num = (short)911081499;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B0:
				num = (short)1850605575;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FC:
				num = (short)1013252168;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_448:
				num = (short)1128464393;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_494:
				num = (short)1892352058;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E0:
				num = (short)1292435460;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E9:
				num = (short)2116943922;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_637:
				num = (short)2072313875;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D8:
				this.cnvSysFeaturesDynamicIDEnable_A40100 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊黌뛎ꋐ闒냔뛖귘껚꿜뫞鋠꟢鳤触裨蛪蓬賮룰럲냴駶飸駺釼髾帀䈂㄄㜆㠈㬊㴌", a_), global::CommonResources.AcgResources.ID_DYNAMICIDENABLE);
				this.cnvSysFeaturesDynamicIDEnable_A40100.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.cnvSysFeaturesDynamicIDEnable_A40100.DataTransferOrder = 64;
				num = (short)2883630;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7DA:
				num = (short)2136080414;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_827:
				num = (short)607649793;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8CE:
				num = (short)1263206414;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A2A:
				num = (short)1527775237;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BA0:
				num = (short)1371537416;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE9:
				num = (short)1906180130;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E52:
				num = (short)407109652;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EF3:
				num = (short)985399324;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F3F:
				num = (short)964689975;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F8B:
				num = (short)621805622;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10EB:
			IL_11B3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臆곈꫊만뫎ꏐ뛒ꛔ", a_);
			base.Id = 10119;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x00AC2638 File Offset: 0x00AC0838
		public override void PopulateReferences()
		{
			short num = (short)402456577;
			if (num != 0)
			{
			}
			num = (short)508274286;
			short num2 = num;
			num = (short)1169401454;
			switch (num2 == num)
			{
			}
			num = (short)1768620032;
			short num3 = num;
			num = (short)1805778944;
			if (num != 0)
			{
			}
			this.cnvSysFeaturesPASelection_A42880.SetRecset(this.a(4176));
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x00AC26F8 File Offset: 0x00AC08F8
		public override void DropReferences()
		{
			short num = (short)2114304936;
			short num2 = num;
			num = (short)1090108328;
			switch (num2 == num)
			{
			}
			num = (short)203816960;
			if (num != 0)
			{
			}
			num = (short)744161280;
			short num3 = num;
			num = (short)415498241;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x00AC27A4 File Offset: 0x00AC09A4
		public override void SetConstraints()
		{
			short num = (short)1748591043;
			short num2 = num;
			num = (short)860119491;
			switch (num2 == num)
			{
			}
			num = (short)154861569;
			if (num != 0)
			{
			}
			num = (short)156631040;
			short num3 = num;
			num = (short)1287585792;
			if (num != 0)
			{
			}
			this.cnvSysFeaturesAutoResetTimesec_A7511.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSelCallResetIsNotManual);
			this.cnvSysFeaturesCAIDataRegistration_A7585.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCAIDataRegApplicable);
			this.cnvSysFeaturesCAIDataRegistration_A7585.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCAIDataRegValid);
			this.cnvSysFeaturesCAIDataRegistration_A7585.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstro);
			this.cnvSysFeaturesCAIDataRegistration_A7585.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCAIDataReadOnly);
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysFeaturesDOSCoastTimems_A7890.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConMdcSysDosEnIsEnabled);
			this.cnvSysFeaturesDOSCoastTimems_A7890.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysFeaturesDOSOperation_A7891.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConMdcSysDosEnIsEnabled);
			this.cnvSysFeaturesDOSOperation_A7891.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConEmerAlrmRxIndicTypeNotNoIndicAndNotAstroRSI);
			this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysFeaturesMessage_A8497.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvFeatureMsgApplicable);
			this.cnvSysFeaturesMessage_A8497.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsNotQC2);
			this.cnvSysFeaturesRadioCheck_A8826.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysTypeIsAstroAndRSISysEnabled);
			this.cnvSysFeaturesRadioCheck_A8826.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysFeaturesRadioInhibit_A8831.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysTypeIsAstroAndRSISysEnabled);
			this.cnvSysFeaturesRadioInhibit_A8831.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysFeaturesRemoteRadioMode_A8935.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysTypeIsAstroAndRSISysEnabled);
			this.cnvSysFeaturesRemoteRadioMode_A8935.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysRemRadioModeIsRadioTrace);
			this.cnvSysFeaturesRemoteRadioMode_A8935.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrIsMDC);
			this.cnvSysFeaturesSelectCallInCallReset_A9102.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysTypeIsAstroAndRSISysEnabled);
			this.cnvSysFeaturesSelectCallInCallReset_A9102.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConValidateSelCallInCallReset);
			this.cnvSysFeaturesStatus_A9186.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysTypeIsAstroAndRSISysEnabled);
			this.cnvSysFeaturesStatus_A9186.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysFeaturesStatusRequest_A9198.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conConventionalStatusIsEnabled);
			this.cnvSysFeaturesStatusRequest_A9198.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.dataProfFeaturesTextMessagingService_A9372.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCnvDataEnabled);
			this.dataProfFeaturesTextMessagingService_A9372.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCnvTxtMsgValueValid);
			this.dataProfFeaturesTextMessagingService_A9372.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstro);
			this.cnvSysFeaturesExtendedDispatchEn_A37220.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCnvSysIsMDCorASTRO);
			this.cnvSysFeaturesExtendedDispatchEn_A37220.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSetEmergencyACKPerExtendedDispatch);
			this.cnvSysFeaturesTxBaseTimeSec_A9513.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conConventionalRemMonRadTraceIsEnabledAndDvrsIsDisabled);
			this.cnvSysFeaturesTxBaseTimeSec_A9513.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrIsMDC);
			this.cnvSysFeaturesDynamicIDEnable_A40100.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSIsEnAndDynamicIDApp);
			this.cnvSysFeaturesDynamicIDEnable_A40100.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSIsEnAndDynamicIDValid);
			this.cnvSysFeaturesDynamicIDEnable_A40100.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCnvSysIsMDCorASTRO);
			this.cnvSysDVRSPOP25Enable_A40126.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSPop25App);
			this.cnvSysDVRSPOP25Enable_A40126.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsNotQC2);
			this.cnvSysFeaturesEmergencyAckEn_A41546.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCnvSysIsMDCorASTRO);
			this.cnvSysFeaturesEmergencyAckEn_A41546.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conExtendedDispatchNotEnable);
			this.cnvSysFeaturesSendLocationToPeer_42427.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConLocationEnableIsEnabledAndConSysIsASTRO);
			this.cnvSysFeaturesSendLocationToPeer_42427.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSendLocationToPeeronPTTValid);
			this.cnvSysFeaturesSendLocationToPeer_42427.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrDVRS);
			this.cnvSysFeaturesGroupTMSEable_42809.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSysGroupTMSIsEnabled);
			this.cnvSysFeaturesPASelection_A42880.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvPerAccSelectionIsValid);
			this.cnvSysFeaturesPASelection_A42880.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvPerAccSelectionIsVisible);
			this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConQualifyEmergencyAlarmRxIsApplicable);
			this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConQualifyEmergencyAlarmRxIsVisiblity);
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00AC2CB4 File Offset: 0x00AC0EB4
		public override void SetupDependencies()
		{
			short num = (short)783218222;
			short num2 = num;
			num = (short)874182190;
			switch (num2 == num)
			{
			}
			num = (short)1903165440;
			short num3 = num;
			num = (short)890568705;
			if (num != 0)
			{
			}
			num = (short)1049755648;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			this.cnvSysFeaturesSelectCallInCallReset_A9102.AddDependentObject(this.cnvSysFeaturesAutoResetTimesec_A7511);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesAutoResetTimesec_A7511);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesAutoResetTimesec_A7511);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesCAIDataRegistration_A7585);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesCAIDataRegistration_A7585);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesDataOperatedSquelchDOS_A7796);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesDOSCoastTimems_A7890);
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.AddDependentObject(this.cnvSysFeaturesDOSCoastTimems_A7890);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesDOSOperation_A7891);
			this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.AddDependentObject(this.cnvSysFeaturesDOSOperation_A7891);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930);
			this.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.AddDependentObject(this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesMessage_A8497);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesMessage_A8497);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesRadioCheck_A8826);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesRadioCheck_A8826);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesRadioInhibit_A8831);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesRadioInhibit_A8831);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesRemoteRadioMode_A8935);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesRemoteRadioMode_A8935);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesSelectCallInCallReset_A9102);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesSelectCallInCallReset_A9102);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesStatus_A9186);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesStatus_A9186);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesStatusRequest_A9198);
			this.cnvSysFeaturesStatus_A9186.AddDependentObject(this.cnvSysFeaturesStatusRequest_A9198);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesStatusRequest_A9198);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.dataProfFeaturesTextMessagingService_A9372);
			conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.AddDependentObject(this.dataProfFeaturesTextMessagingService_A9372);
			this.RefDisplayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.AddDependentObject(this.dataProfFeaturesTextMessagingService_A9372);
			this.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372.AddDependentObject(this.dataProfFeaturesTextMessagingService_A9372);
			this.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.AddDependentObject(this.dataProfFeaturesTextMessagingService_A9372);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesExtendedDispatchEn_A37220);
			this.cnvSysFeaturesEmergencyAckEn_A41546.AddDependentObject(this.cnvSysFeaturesExtendedDispatchEn_A37220);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesTxBaseTimeSec_A9513);
			this.cnvSysFeaturesRemoteRadioMode_A8935.AddDependentObject(this.cnvSysFeaturesTxBaseTimeSec_A9513);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesTxBaseTimeSec_A9513);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesDynamicIDEnable_A40100);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvSysFeaturesDynamicIDEnable_A40100);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysFeaturesDynamicIDEnable_A40100);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSPOP25Enable_A40126);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysDVRSPOP25Enable_A40126);
			conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.AddDependentObject(this.cnvSysDVRSPOP25Enable_A40126);
			conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysDVRSPOP25Enable_A40126);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesEmergencyAckEn_A41546);
			this.cnvSysFeaturesExtendedDispatchEn_A37220.AddDependentObject(this.cnvSysFeaturesEmergencyAckEn_A41546);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesSendLocationToPeer_42427);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.cnvSysFeaturesSendLocationToPeer_42427);
			conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.AddDependentObject(this.cnvSysFeaturesSendLocationToPeer_42427);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesGroupTMSEable_42809);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeaturesPASelection_A42880);
			this.cnvSysFeaturesDynamicIDEnable_A40100.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideConventionalDynamicIDWithPassword_A43705);
		}

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x0600B96C RID: 47468 RVA: 0x00AC3240 File Offset: 0x00AC1440
		public global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability PersonnelAccountabilityForCnvSysFeaturesPASelection_A42880
		{
			get
			{
				short num = (short)1558954078;
				short num2 = num;
				num = (short)1097252958;
				switch (num2 == num)
				{
				}
				num = (short)475856896;
				short num3 = num;
				num = (short)1274740736;
				if (num != 0)
				{
				}
				num = (short)1312161793;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesPASelection_A42880.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability;
			}
		}

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x00AC32F8 File Offset: 0x00AC14F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)41310788;
				short num2 = num;
				num = (short)962419268;
				switch (num2 == num)
				{
				}
				num = (short)1878851584;
				short num3 = num;
				num = (short)1838088193;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x0600B96E RID: 47470 RVA: 0x00AC33AC File Offset: 0x00AC15AC
		// (set) Token: 0x0600B96F RID: 47471 RVA: 0x00AC3460 File Offset: 0x00AC1660
		public int CnvSysFeaturesAutoResetTimesec_A7511Value
		{
			get
			{
				short num = (short)310691014;
				short num2 = num;
				num = (short)1267385542;
				switch (num2 == num)
				{
				}
				num = (short)1842282496;
				short num3 = num;
				num = (short)1522925568;
				if (num != 0)
				{
				}
				num = (short)35192833;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Value;
			}
			set
			{
				short num = (short)1190734801;
				short num2 = num;
				num = (short)1951935441;
				switch (num2 == num)
				{
				}
				num = (short)1383792640;
				short num3 = num;
				num = (short)1049100288;
				if (num != 0)
				{
				}
				num = (short)1912274945;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Value = value;
			}
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x0600B970 RID: 47472 RVA: 0x00AC3518 File Offset: 0x00AC1718
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysFeaturesAutoResetTimesec_A7511
		{
			get
			{
				short num = (short)1989439760;
				short num2 = num;
				num = (short)1024094480;
				switch (num2 == num)
				{
				}
				num = (short)1947860992;
				short num3 = num;
				num = (short)1920073728;
				if (num != 0)
				{
				}
				num = (short)1303969793;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511;
			}
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x0600B971 RID: 47473 RVA: 0x00AC35C8 File Offset: 0x00AC17C8
		// (set) Token: 0x0600B972 RID: 47474 RVA: 0x00AC3678 File Offset: 0x00AC1878
		public string CnvSysFeaturesAutoResetTimesec_A7511_UIValue
		{
			get
			{
				short num = (short)2127850383;
				short num2 = num;
				num = (short)486697871;
				switch (num2 == num)
				{
				}
				num = (short)1402798080;
				short num3 = num;
				num = (short)895483905;
				if (num != 0)
				{
				}
				num = (short)546242560;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.UIValue;
			}
			set
			{
				short num = (short)2127173689;
				short num2 = num;
				num = (short)202512441;
				switch (num2 == num)
				{
				}
				num = (short)573046784;
				short num3 = num;
				num = (short)1625489409;
				if (num != 0)
				{
				}
				num = (short)1529413632;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.UIValue = value;
			}
		}

		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x0600B973 RID: 47475 RVA: 0x00AC3730 File Offset: 0x00AC1930
		// (set) Token: 0x0600B974 RID: 47476 RVA: 0x00AC37E4 File Offset: 0x00AC19E4
		internal int CnvSysFeaturesAutoResetTimesec_A7511Min
		{
			get
			{
				short num = (short)1412280478;
				short num2 = num;
				num = (short)79933598;
				switch (num2 == num)
				{
				}
				num = (short)1603796992;
				short num3 = num;
				num = (short)1828782080;
				if (num != 0)
				{
				}
				num = (short)504037377;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Min;
			}
			set
			{
				short num = (short)879930257;
				short num2 = num;
				num = (short)1192471441;
				switch (num2 == num)
				{
				}
				num = (short)1215823872;
				short num3 = num;
				num = (short)839909376;
				if (num != 0)
				{
				}
				num = (short)13893633;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Min = value;
			}
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x00AC3898 File Offset: 0x00AC1A98
		// (set) Token: 0x0600B976 RID: 47478 RVA: 0x00AC394C File Offset: 0x00AC1B4C
		internal int CnvSysFeaturesAutoResetTimesec_A7511Max
		{
			get
			{
				short num = (short)728812624;
				short num2 = num;
				num = (short)2143669328;
				switch (num2 == num)
				{
				}
				num = (short)2041184256;
				short num3 = num;
				num = (short)1878654976;
				if (num != 0)
				{
				}
				num = (short)233635841;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Max;
			}
			set
			{
				short num = (short)1231158514;
				short num2 = num;
				num = (short)876543218;
				switch (num2 == num)
				{
				}
				num = (short)515964928;
				short num3 = num;
				num = (short)2044067841;
				if (num != 0)
				{
				}
				num = (short)400556032;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Max = value;
			}
		}

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x0600B977 RID: 47479 RVA: 0x00AC3A04 File Offset: 0x00AC1C04
		// (set) Token: 0x0600B978 RID: 47480 RVA: 0x00AC3AB8 File Offset: 0x00AC1CB8
		internal int CnvSysFeaturesAutoResetTimesec_A7511Step
		{
			get
			{
				short num = (short)850209736;
				short num2 = num;
				num = (short)254290888;
				switch (num2 == num)
				{
				}
				num = (short)402063360;
				short num3 = num;
				num = (short)1908277248;
				if (num != 0)
				{
				}
				num = (short)1759379457;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.StepSize;
			}
			set
			{
				short num = (short)2128936961;
				if (num != 0)
				{
				}
				num = (short)881779158;
				short num2 = num;
				num = (short)840688086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397686272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267583488;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.StepSize = value;
			}
		}

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0600B979 RID: 47481 RVA: 0x00AC3B6C File Offset: 0x00AC1D6C
		// (set) Token: 0x0600B97A RID: 47482 RVA: 0x00AC3C20 File Offset: 0x00AC1E20
		public bool CnvSysFeaturesAutoResetTimesec_A7511_Applicable
		{
			get
			{
				short num = (short)1138286838;
				short num2 = num;
				num = (short)514908406;
				switch (num2 == num)
				{
				}
				num = (short)1462239232;
				short num3 = num;
				num = (short)1438318592;
				if (num != 0)
				{
				}
				num = (short)1610416129;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Applicable;
			}
			set
			{
				short num = (short)1665400833;
				if (num != 0)
				{
				}
				num = (short)1372765689;
				short num2 = num;
				num = (short)2042150393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231342080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)63504384;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Applicable = value;
			}
		}

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x00AC3CD4 File Offset: 0x00AC1ED4
		// (set) Token: 0x0600B97C RID: 47484 RVA: 0x00AC3D88 File Offset: 0x00AC1F88
		public bool CnvSysFeaturesAutoResetTimesec_A7511_Valid
		{
			get
			{
				short num = (short)1075892875;
				short num2 = num;
				num = (short)184472203;
				switch (num2 == num)
				{
				}
				num = (short)665649153;
				if (num != 0)
				{
				}
				num = (short)1035665408;
				short num3 = num;
				num = (short)2044002304;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Valid;
			}
			set
			{
				short num = (short)561195254;
				short num2 = num;
				num = (short)1869097206;
				switch (num2 == num)
				{
				}
				num = (short)895549441;
				if (num != 0)
				{
				}
				num = (short)1153892352;
				short num3 = num;
				num = (short)161742848;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Valid = value;
			}
		}

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x00AC3E3C File Offset: 0x00AC203C
		// (set) Token: 0x0600B97E RID: 47486 RVA: 0x00AC3EF0 File Offset: 0x00AC20F0
		public bool CnvSysFeaturesAutoResetTimesec_A7511_Visible
		{
			get
			{
				short num = (short)478789293;
				short num2 = num;
				num = (short)182435501;
				switch (num2 == num)
				{
				}
				num = (short)1646854144;
				if (num != 0)
				{
				}
				num = (short)504430592;
				short num3 = num;
				num = (short)1472397313;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Visible;
			}
			set
			{
				short num = (short)1739627254;
				short num2 = num;
				num = (short)1511561974;
				switch (num2 == num)
				{
				}
				num = (short)445186048;
				if (num != 0)
				{
				}
				num = (short)1476329472;
				short num3 = num;
				num = (short)802553857;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Visible = value;
			}
		}

		// Token: 0x17005CD5 RID: 23765
		// (get) Token: 0x0600B97F RID: 47487 RVA: 0x00AC3FAC File Offset: 0x00AC21AC
		// (set) Token: 0x0600B980 RID: 47488 RVA: 0x00AC4060 File Offset: 0x00AC2260
		public bool CnvSysFeaturesAutoResetTimesec_A7511_Editable
		{
			get
			{
				short num = (short)1178861569;
				if (num != 0)
				{
				}
				num = (short)1129763559;
				short num2 = num;
				num = (short)2031473383;
				switch (num2 == num)
				{
				}
				num = (short)700645376;
				short num3 = num;
				num = (short)675414016;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.Editable;
			}
			set
			{
				short num = (short)1132134401;
				if (num != 0)
				{
				}
				num = (short)1186333099;
				short num2 = num;
				num = (short)1886781867;
				switch (num2 == num)
				{
				}
				num = (short)861274112;
				short num3 = num;
				num = (short)1734213632;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.Editable = value;
			}
		}

		// Token: 0x17005CD6 RID: 23766
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x00AC4114 File Offset: 0x00AC2314
		internal string CnvSysFeaturesAutoResetTimesec_A7511_UILabel
		{
			get
			{
				short num = (short)2118071489;
				short num2 = num;
				num = (short)1774728385;
				switch (num2 == num)
				{
				}
				num = (short)485949440;
				if (num != 0)
				{
				}
				num = (short)485359616;
				short num3 = num;
				num = (short)1293680641;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.UIName;
			}
		}

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x00AC41CC File Offset: 0x00AC23CC
		// (set) Token: 0x0600B983 RID: 47491 RVA: 0x00AC4280 File Offset: 0x00AC2480
		internal bool CnvSysFeaturesAutoResetTimesec_A7511_HiddenStatic
		{
			get
			{
				short num = (short)743003190;
				short num2 = num;
				num = (short)293098550;
				switch (num2 == num)
				{
				}
				num = (short)864485376;
				if (num != 0)
				{
				}
				num = (short)698679296;
				short num3 = num;
				num = (short)1891565569;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.HiddenStatic;
			}
			set
			{
				short num = (short)396691981;
				short num2 = num;
				num = (short)1480329741;
				switch (num2 == num)
				{
				}
				num = (short)2132213761;
				if (num != 0)
				{
				}
				num = (short)827326464;
				short num3 = num;
				num = (short)1981480960;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.HiddenStatic = value;
			}
		}

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x0600B984 RID: 47492 RVA: 0x00AC4334 File Offset: 0x00AC2534
		// (set) Token: 0x0600B985 RID: 47493 RVA: 0x00AC43EC File Offset: 0x00AC25EC
		internal bool CnvSysFeaturesAutoResetTimesec_A7511_HiddenDynamic
		{
			get
			{
				short num = (short)1995951565;
				short num2 = num;
				num = (short)1871367629;
				switch (num2 == num)
				{
				}
				num = (short)1151008768;
				if (num != 0)
				{
				}
				num = (short)1934360576;
				short num3 = num;
				num = (short)344522753;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511.HiddenDynamic;
			}
			set
			{
				short num = (short)1303052289;
				if (num != 0)
				{
				}
				num = (short)424665115;
				short num2 = num;
				num = (short)30138395;
				switch (num2 == num)
				{
				}
				num = (short)942735360;
				short num3 = num;
				num = (short)632750080;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesAutoResetTimesec_A7511.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x00AC44A0 File Offset: 0x00AC26A0
		public bool CnvSysFeaturesAutoResetTimesec_A7511_HasDiffs
		{
			get
			{
				short num = (short)1329481481;
				short num2 = num;
				num = (short)742672137;
				switch (num2 == num)
				{
				}
				num = (short)1823539201;
				if (num != 0)
				{
				}
				num = (short)151781376;
				short num3 = num;
				num = (short)506855424;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesAutoResetTimesec_A7511._HasDiffs;
			}
		}

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x0600B987 RID: 47495 RVA: 0x00AC4554 File Offset: 0x00AC2754
		// (set) Token: 0x0600B988 RID: 47496 RVA: 0x00AC4608 File Offset: 0x00AC2808
		public bool CnvSysFeaturesCAIDataRegistration_A7585Value
		{
			get
			{
				short num = (short)2013966425;
				short num2 = num;
				num = (short)91402329;
				switch (num2 == num)
				{
				}
				num = (short)1983512576;
				if (num != 0)
				{
				}
				num = (short)112197632;
				short num3 = num;
				num = (short)2043609089;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Value;
			}
			set
			{
				short num = (short)2044499113;
				short num2 = num;
				num = (short)1148818601;
				switch (num2 == num)
				{
				}
				num = (short)527237121;
				if (num != 0)
				{
				}
				num = (short)289341440;
				short num3 = num;
				num = (short)1406337024;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Value = value;
			}
		}

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x00AC46C0 File Offset: 0x00AC28C0
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesCAIDataRegistration_A7585
		{
			get
			{
				short num = (short)305820975;
				short num2 = num;
				num = (short)40465711;
				switch (num2 == num)
				{
				}
				num = (short)1273298945;
				if (num != 0)
				{
				}
				num = (short)47644672;
				short num3 = num;
				num = (short)209453056;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585;
			}
		}

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x0600B98A RID: 47498 RVA: 0x00AC4770 File Offset: 0x00AC2970
		// (set) Token: 0x0600B98B RID: 47499 RVA: 0x00AC4824 File Offset: 0x00AC2A24
		public bool CnvSysFeaturesCAIDataRegistration_A7585_UIValue
		{
			get
			{
				short num = (short)63547759;
				short num2 = num;
				num = (short)667855215;
				switch (num2 == num)
				{
				}
				num = (short)733741057;
				if (num != 0)
				{
				}
				num = (short)598212608;
				short num3 = num;
				num = (short)692256768;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Value;
			}
			set
			{
				short num = (short)1937507446;
				short num2 = num;
				num = (short)1722156150;
				switch (num2 == num)
				{
				}
				num = (short)64094208;
				if (num != 0)
				{
				}
				num = (short)181731328;
				short num3 = num;
				num = (short)1394540545;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Value = value;
			}
		}

		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x0600B98C RID: 47500 RVA: 0x00AC48DC File Offset: 0x00AC2ADC
		// (set) Token: 0x0600B98D RID: 47501 RVA: 0x00AC4990 File Offset: 0x00AC2B90
		public bool CnvSysFeaturesCAIDataRegistration_A7585_Applicable
		{
			get
			{
				short num = (short)269615105;
				if (num != 0)
				{
				}
				num = (short)285996444;
				short num2 = num;
				num = (short)163378588;
				switch (num2 == num)
				{
				}
				num = (short)2020147200;
				short num3 = num;
				num = (short)177799168;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Applicable;
			}
			set
			{
				short num = (short)925426475;
				short num2 = num;
				num = (short)2074796843;
				switch (num2 == num)
				{
				}
				num = (short)1671692288;
				if (num != 0)
				{
				}
				num = (short)1271201792;
				short num3 = num;
				num = (short)1201733633;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Applicable = value;
			}
		}

		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x0600B98E RID: 47502 RVA: 0x00AC4A44 File Offset: 0x00AC2C44
		// (set) Token: 0x0600B98F RID: 47503 RVA: 0x00AC4AF8 File Offset: 0x00AC2CF8
		public bool CnvSysFeaturesCAIDataRegistration_A7585_Valid
		{
			get
			{
				short num = (short)716619358;
				short num2 = num;
				num = (short)1447411294;
				switch (num2 == num)
				{
				}
				num = (short)959578113;
				if (num != 0)
				{
				}
				num = (short)1565392896;
				short num3 = num;
				num = (short)751763456;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Valid;
			}
			set
			{
				short num = (short)1705001385;
				short num2 = num;
				num = (short)919028137;
				switch (num2 == num)
				{
				}
				num = (short)531103744;
				if (num != 0)
				{
				}
				num = (short)1931018240;
				short num3 = num;
				num = (short)530710529;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Valid = value;
			}
		}

		// Token: 0x17005CDF RID: 23775
		// (get) Token: 0x0600B990 RID: 47504 RVA: 0x00AC4BAC File Offset: 0x00AC2DAC
		// (set) Token: 0x0600B991 RID: 47505 RVA: 0x00AC4C60 File Offset: 0x00AC2E60
		public bool CnvSysFeaturesCAIDataRegistration_A7585_Visible
		{
			get
			{
				short num = (short)1416551726;
				short num2 = num;
				num = (short)1039981870;
				switch (num2 == num)
				{
				}
				num = (short)929038337;
				if (num != 0)
				{
				}
				num = (short)1486880768;
				short num3 = num;
				num = (short)1228668928;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Visible;
			}
			set
			{
				short num = (short)2138829390;
				short num2 = num;
				num = (short)1205727822;
				switch (num2 == num)
				{
				}
				num = (short)1333526528;
				if (num != 0)
				{
				}
				num = (short)435421184;
				short num3 = num;
				num = (short)2092957697;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Visible = value;
			}
		}

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x0600B992 RID: 47506 RVA: 0x00AC4D18 File Offset: 0x00AC2F18
		// (set) Token: 0x0600B993 RID: 47507 RVA: 0x00AC4DCC File Offset: 0x00AC2FCC
		public bool CnvSysFeaturesCAIDataRegistration_A7585_Editable
		{
			get
			{
				short num = (short)1228802492;
				short num2 = num;
				num = (short)1798244796;
				switch (num2 == num)
				{
				}
				num = (short)1643773953;
				if (num != 0)
				{
				}
				num = (short)1067319296;
				short num3 = num;
				num = (short)1537015808;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.Editable;
			}
			set
			{
				short num = (short)1604517289;
				short num2 = num;
				num = (short)1422654889;
				switch (num2 == num)
				{
				}
				num = (short)1435697153;
				if (num != 0)
				{
				}
				num = (short)277741568;
				short num3 = num;
				num = (short)1913847808;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.Editable = value;
			}
		}

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x00AC4E84 File Offset: 0x00AC3084
		internal string CnvSysFeaturesCAIDataRegistration_A7585_UILabel
		{
			get
			{
				short num = (short)1524113211;
				short num2 = num;
				num = (short)443686715;
				switch (num2 == num)
				{
				}
				num = (short)505806849;
				if (num != 0)
				{
				}
				num = (short)574226432;
				short num3 = num;
				num = (short)1228341248;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.UIName;
			}
		}

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x00AC4F38 File Offset: 0x00AC3138
		// (set) Token: 0x0600B996 RID: 47510 RVA: 0x00AC4FEC File Offset: 0x00AC31EC
		internal bool CnvSysFeaturesCAIDataRegistration_A7585_HiddenStatic
		{
			get
			{
				short num = (short)25177661;
				short num2 = num;
				num = (short)140848701;
				switch (num2 == num)
				{
				}
				num = (short)394592256;
				if (num != 0)
				{
				}
				num = (short)84672512;
				short num3 = num;
				num = (short)1572995073;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.HiddenStatic;
			}
			set
			{
				short num = (short)85203510;
				short num2 = num;
				num = (short)801249846;
				switch (num2 == num)
				{
				}
				num = (short)1379794945;
				if (num != 0)
				{
				}
				num = (short)1285423104;
				short num3 = num;
				num = (short)1041432576;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.HiddenStatic = value;
			}
		}

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x0600B997 RID: 47511 RVA: 0x00AC50A0 File Offset: 0x00AC32A0
		// (set) Token: 0x0600B998 RID: 47512 RVA: 0x00AC5154 File Offset: 0x00AC3354
		internal bool CnvSysFeaturesCAIDataRegistration_A7585_HiddenDynamic
		{
			get
			{
				short num = (short)170723756;
				short num2 = num;
				num = (short)487524780;
				switch (num2 == num)
				{
				}
				num = (short)1431830528;
				if (num != 0)
				{
				}
				num = (short)819068928;
				short num3 = num;
				num = (short)1271660545;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585.HiddenDynamic;
			}
			set
			{
				short num = (short)371895859;
				short num2 = num;
				num = (short)230600243;
				switch (num2 == num)
				{
				}
				num = (short)1416429569;
				if (num != 0)
				{
				}
				num = (short)676724736;
				short num3 = num;
				num = (short)414056448;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesCAIDataRegistration_A7585.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0600B999 RID: 47513 RVA: 0x00AC520C File Offset: 0x00AC340C
		public bool CnvSysFeaturesCAIDataRegistration_A7585_HasDiffs
		{
			get
			{
				short num = (short)857075983;
				short num2 = num;
				num = (short)1374875919;
				switch (num2 == num)
				{
				}
				num = (short)1524039681;
				if (num != 0)
				{
				}
				num = (short)1666449408;
				short num3 = num;
				num = (short)235732992;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesCAIDataRegistration_A7585._HasDiffs;
			}
		}

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x0600B99A RID: 47514 RVA: 0x00AC52C0 File Offset: 0x00AC34C0
		// (set) Token: 0x0600B99B RID: 47515 RVA: 0x00AC5374 File Offset: 0x00AC3574
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796Value
		{
			get
			{
				short num = (short)773460802;
				short num2 = num;
				num = (short)1110512450;
				switch (num2 == num)
				{
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				num = (short)421527552;
				short num3 = num;
				num = (short)1145438208;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Value;
			}
			set
			{
				short num = (short)2072307002;
				short num2 = num;
				num = (short)1130554682;
				switch (num2 == num)
				{
				}
				num = (short)1988034561;
				if (num != 0)
				{
				}
				num = (short)406257664;
				short num3 = num;
				num = (short)351797248;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Value = value;
			}
		}

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x0600B99C RID: 47516 RVA: 0x00AC542C File Offset: 0x00AC362C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesDataOperatedSquelchDOS_A7796
		{
			get
			{
				short num = (short)368409380;
				short num2 = num;
				num = (short)1986034468;
				switch (num2 == num)
				{
				}
				num = (short)1877278721;
				if (num != 0)
				{
				}
				num = (short)1684275200;
				short num3 = num;
				num = (short)616890368;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796;
			}
		}

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x0600B99D RID: 47517 RVA: 0x00AC54DC File Offset: 0x00AC36DC
		// (set) Token: 0x0600B99E RID: 47518 RVA: 0x00AC5590 File Offset: 0x00AC3790
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_UIValue
		{
			get
			{
				short num = (short)181833854;
				short num2 = num;
				num = (short)1344639102;
				switch (num2 == num)
				{
				}
				num = (short)77070336;
				if (num != 0)
				{
				}
				num = (short)2006188032;
				short num3 = num;
				num = (short)1958019073;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Value;
			}
			set
			{
				short num = (short)1914765313;
				if (num != 0)
				{
				}
				num = (short)194552765;
				short num2 = num;
				num = (short)69247933;
				switch (num2 == num)
				{
				}
				num = (short)1701511168;
				short num3 = num;
				num = (short)1610874880;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Value = value;
			}
		}

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0600B99F RID: 47519 RVA: 0x00AC5644 File Offset: 0x00AC3844
		// (set) Token: 0x0600B9A0 RID: 47520 RVA: 0x00AC56FC File Offset: 0x00AC38FC
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_Applicable
		{
			get
			{
				short num = (short)1909516224;
				short num2 = num;
				num = (short)2074798016;
				switch (num2 == num)
				{
				}
				num = (short)82771969;
				if (num != 0)
				{
				}
				num = (short)806551552;
				short num3 = num;
				num = (short)187301888;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Applicable;
			}
			set
			{
				short num = (short)1360265217;
				if (num != 0)
				{
				}
				num = (short)1633820849;
				short num2 = num;
				num = (short)2016747697;
				switch (num2 == num)
				{
				}
				num = (short)1081606144;
				short num3 = num;
				num = (short)1065877504;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Applicable = value;
			}
		}

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x00AC57B0 File Offset: 0x00AC39B0
		// (set) Token: 0x0600B9A2 RID: 47522 RVA: 0x00AC5864 File Offset: 0x00AC3A64
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_Valid
		{
			get
			{
				short num = (short)156077787;
				short num2 = num;
				num = (short)1256296155;
				switch (num2 == num)
				{
				}
				num = (short)602865665;
				if (num != 0)
				{
				}
				num = (short)1729429504;
				short num3 = num;
				num = (short)1547960320;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Valid;
			}
			set
			{
				short num = (short)1980757123;
				short num2 = num;
				num = (short)135853187;
				switch (num2 == num)
				{
				}
				num = (short)1549729793;
				if (num != 0)
				{
				}
				num = (short)1290141696;
				short num3 = num;
				num = (short)729284608;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Valid = value;
			}
		}

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x00AC5918 File Offset: 0x00AC3B18
		// (set) Token: 0x0600B9A4 RID: 47524 RVA: 0x00AC59D0 File Offset: 0x00AC3BD0
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_Visible
		{
			get
			{
				short num = (short)1925971969;
				if (num != 0)
				{
				}
				num = (short)1084853148;
				short num2 = num;
				num = (short)1782418332;
				switch (num2 == num)
				{
				}
				num = (short)2032074752;
				short num3 = num;
				num = (short)1959133184;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Visible;
			}
			set
			{
				short num = (short)1555105294;
				short num2 = num;
				num = (short)1807091214;
				switch (num2 == num)
				{
				}
				num = (short)1187840001;
				if (num != 0)
				{
				}
				num = (short)2057306112;
				short num3 = num;
				num = (short)1248854016;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Visible = value;
			}
		}

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x00AC5A84 File Offset: 0x00AC3C84
		// (set) Token: 0x0600B9A6 RID: 47526 RVA: 0x00AC5B38 File Offset: 0x00AC3D38
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_Editable
		{
			get
			{
				short num = (short)438942392;
				short num2 = num;
				num = (short)311212728;
				switch (num2 == num)
				{
				}
				num = (short)286982145;
				if (num != 0)
				{
				}
				num = (short)545193984;
				short num3 = num;
				num = (short)1553334272;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Editable;
			}
			set
			{
				short num = (short)953507331;
				short num2 = num;
				num = (short)2059755011;
				switch (num2 == num)
				{
				}
				num = (short)350683136;
				if (num != 0)
				{
				}
				num = (short)1452212224;
				short num3 = num;
				num = (short)331677697;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.Editable = value;
			}
		}

		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x00AC5BEC File Offset: 0x00AC3DEC
		internal string CnvSysFeaturesDataOperatedSquelchDOS_A7796_UILabel
		{
			get
			{
				short num = (short)2137034997;
				short num2 = num;
				num = (short)1199542517;
				switch (num2 == num)
				{
				}
				num = (short)1341784065;
				if (num != 0)
				{
				}
				num = (short)483983360;
				short num3 = num;
				num = (short)2104164352;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.UIName;
			}
		}

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x00AC5CA4 File Offset: 0x00AC3EA4
		// (set) Token: 0x0600B9A9 RID: 47529 RVA: 0x00AC5D58 File Offset: 0x00AC3F58
		internal bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_HiddenStatic
		{
			get
			{
				short num = (short)229703681;
				if (num != 0)
				{
				}
				num = (short)2039686278;
				short num2 = num;
				num = (short)175121542;
				switch (num2 == num)
				{
				}
				num = (short)464125952;
				short num3 = num;
				num = (short)1984299008;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.HiddenStatic;
			}
			set
			{
				short num = (short)705783775;
				short num2 = num;
				num = (short)1723492319;
				switch (num2 == num)
				{
				}
				num = (short)1019478017;
				if (num != 0)
				{
				}
				num = (short)2075000832;
				short num3 = num;
				num = (short)1533214720;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.HiddenStatic = value;
			}
		}

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x00AC5E10 File Offset: 0x00AC4010
		// (set) Token: 0x0600B9AB RID: 47531 RVA: 0x00AC5EC8 File Offset: 0x00AC40C8
		internal bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_HiddenDynamic
		{
			get
			{
				short num = (short)318381044;
				short num2 = num;
				num = (short)348330996;
				switch (num2 == num)
				{
				}
				num = (short)1920204801;
				if (num != 0)
				{
				}
				num = (short)511442944;
				short num3 = num;
				num = (short)985858048;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.HiddenDynamic;
			}
			set
			{
				short num = (short)161166946;
				short num2 = num;
				num = (short)1491940962;
				switch (num2 == num)
				{
				}
				num = (short)1770717185;
				if (num != 0)
				{
				}
				num = (short)1199046656;
				short num3 = num;
				num = (short)725811200;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDataOperatedSquelchDOS_A7796.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x00AC5F80 File Offset: 0x00AC4180
		public bool CnvSysFeaturesDataOperatedSquelchDOS_A7796_HasDiffs
		{
			get
			{
				short num = (short)181936865;
				short num2 = num;
				num = (short)2104435425;
				switch (num2 == num)
				{
				}
				num = (short)6029313;
				if (num != 0)
				{
				}
				num = (short)677707776;
				short num3 = num;
				num = (short)1345126400;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDataOperatedSquelchDOS_A7796._HasDiffs;
			}
		}

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x00AC6034 File Offset: 0x00AC4234
		// (set) Token: 0x0600B9AE RID: 47534 RVA: 0x00AC60E8 File Offset: 0x00AC42E8
		public int CnvSysFeaturesDOSCoastTimems_A7890Value
		{
			get
			{
				short num = (short)1178925180;
				short num2 = num;
				num = (short)889518204;
				switch (num2 == num)
				{
				}
				num = (short)1000603649;
				if (num != 0)
				{
				}
				num = (short)688586752;
				short num3 = num;
				num = (short)379518976;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Value;
			}
			set
			{
				short num = (short)1990997548;
				short num2 = num;
				num = (short)105723436;
				switch (num2 == num)
				{
				}
				num = (short)1258684416;
				if (num != 0)
				{
				}
				num = (short)288686080;
				short num3 = num;
				num = (short)1600192513;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Value = value;
			}
		}

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x0600B9AF RID: 47535 RVA: 0x00AC61A0 File Offset: 0x00AC43A0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysFeaturesDOSCoastTimems_A7890
		{
			get
			{
				short num = (short)683736746;
				short num2 = num;
				num = (short)2105999018;
				switch (num2 == num)
				{
				}
				num = (short)212729857;
				if (num != 0)
				{
				}
				num = (short)2100232192;
				short num3 = num;
				num = (short)1530855424;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890;
			}
		}

		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x0600B9B0 RID: 47536 RVA: 0x00AC6250 File Offset: 0x00AC4450
		// (set) Token: 0x0600B9B1 RID: 47537 RVA: 0x00AC6304 File Offset: 0x00AC4504
		public string CnvSysFeaturesDOSCoastTimems_A7890_UIValue
		{
			get
			{
				short num = (short)330637975;
				short num2 = num;
				num = (short)1792090775;
				switch (num2 == num)
				{
				}
				num = (short)632487937;
				if (num != 0)
				{
				}
				num = (short)1943732224;
				short num3 = num;
				num = (short)310575104;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.UIValue;
			}
			set
			{
				short num = (short)1958444111;
				short num2 = num;
				num = (short)1388346447;
				switch (num2 == num)
				{
				}
				num = (short)1054474241;
				if (num != 0)
				{
				}
				num = (short)1484783616;
				short num3 = num;
				num = (short)1762590720;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.UIValue = value;
			}
		}

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x00AC63B8 File Offset: 0x00AC45B8
		// (set) Token: 0x0600B9B3 RID: 47539 RVA: 0x00AC646C File Offset: 0x00AC466C
		internal int CnvSysFeaturesDOSCoastTimems_A7890Min
		{
			get
			{
				short num = (short)2015098204;
				short num2 = num;
				num = (short)469693788;
				switch (num2 == num)
				{
				}
				num = (short)2007040001;
				if (num != 0)
				{
				}
				num = (short)1373437952;
				short num3 = num;
				num = (short)1561853952;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Min;
			}
			set
			{
				short num = (short)1654601384;
				short num2 = num;
				num = (short)349845160;
				switch (num2 == num)
				{
				}
				num = (short)1487732736;
				if (num != 0)
				{
				}
				num = (short)2045902848;
				short num3 = num;
				num = (short)1364525057;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Min = value;
			}
		}

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x0600B9B4 RID: 47540 RVA: 0x00AC6524 File Offset: 0x00AC4724
		// (set) Token: 0x0600B9B5 RID: 47541 RVA: 0x00AC65DC File Offset: 0x00AC47DC
		internal int CnvSysFeaturesDOSCoastTimems_A7890Max
		{
			get
			{
				short num = (short)1433974001;
				short num2 = num;
				num = (short)1382724849;
				switch (num2 == num)
				{
				}
				num = (short)1486815233;
				if (num != 0)
				{
				}
				num = (short)2146172928;
				short num3 = num;
				num = (short)781058048;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Max;
			}
			set
			{
				short num = (short)308321612;
				short num2 = num;
				num = (short)2040503628;
				switch (num2 == num)
				{
				}
				num = (short)254672897;
				if (num != 0)
				{
				}
				num = (short)100007936;
				short num3 = num;
				num = (short)241500160;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Max = value;
			}
		}

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x00AC668C File Offset: 0x00AC488C
		// (set) Token: 0x0600B9B7 RID: 47543 RVA: 0x00AC6744 File Offset: 0x00AC4944
		internal int CnvSysFeaturesDOSCoastTimems_A7890Step
		{
			get
			{
				short num = (short)909161388;
				short num2 = num;
				num = (short)2054337452;
				switch (num2 == num)
				{
				}
				num = (short)1311244289;
				if (num != 0)
				{
				}
				num = (short)1624834048;
				short num3 = num;
				num = (short)1231683584;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.StepSize;
			}
			set
			{
				short num = (short)2145440622;
				short num2 = num;
				num = (short)11129710;
				switch (num2 == num)
				{
				}
				num = (short)1860042753;
				if (num != 0)
				{
				}
				num = (short)1186594816;
				short num3 = num;
				num = (short)619184128;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.StepSize = value;
			}
		}

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x0600B9B8 RID: 47544 RVA: 0x00AC67FC File Offset: 0x00AC49FC
		// (set) Token: 0x0600B9B9 RID: 47545 RVA: 0x00AC68B4 File Offset: 0x00AC4AB4
		public bool CnvSysFeaturesDOSCoastTimems_A7890_Applicable
		{
			get
			{
				short num = (short)1798249098;
				short num2 = num;
				num = (short)733092490;
				switch (num2 == num)
				{
				}
				num = (short)984875009;
				if (num != 0)
				{
				}
				num = (short)1689583616;
				short num3 = num;
				num = (short)216006656;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Applicable;
			}
			set
			{
				short num = (short)1573276298;
				short num2 = num;
				num = (short)647776906;
				switch (num2 == num)
				{
				}
				num = (short)1581056000;
				if (num != 0)
				{
				}
				num = (short)2105999360;
				short num3 = num;
				num = (short)311296001;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Applicable = value;
			}
		}

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x0600B9BA RID: 47546 RVA: 0x00AC6968 File Offset: 0x00AC4B68
		// (set) Token: 0x0600B9BB RID: 47547 RVA: 0x00AC6A1C File Offset: 0x00AC4C1C
		public bool CnvSysFeaturesDOSCoastTimems_A7890_Valid
		{
			get
			{
				short num = (short)414079962;
				short num2 = num;
				num = (short)564419546;
				switch (num2 == num)
				{
				}
				num = (short)1290403841;
				if (num != 0)
				{
				}
				num = (short)689766400;
				short num3 = num;
				num = (short)258277376;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Valid;
			}
			set
			{
				short num = (short)93314237;
				short num2 = num;
				num = (short)127458493;
				switch (num2 == num)
				{
				}
				num = (short)1548550145;
				if (num != 0)
				{
				}
				num = (short)1990852608;
				short num3 = num;
				num = (short)1657143296;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Valid = value;
			}
		}

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x00AC6AD4 File Offset: 0x00AC4CD4
		// (set) Token: 0x0600B9BD RID: 47549 RVA: 0x00AC6B8C File Offset: 0x00AC4D8C
		public bool CnvSysFeaturesDOSCoastTimems_A7890_Visible
		{
			get
			{
				short num = (short)697224408;
				short num2 = num;
				num = (short)1299107032;
				switch (num2 == num)
				{
				}
				num = (short)1646657536;
				if (num != 0)
				{
				}
				num = (short)135856128;
				short num3 = num;
				num = (short)585302017;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Visible;
			}
			set
			{
				short num = (short)810836430;
				short num2 = num;
				num = (short)759325134;
				switch (num2 == num)
				{
				}
				num = (short)2011758592;
				if (num != 0)
				{
				}
				num = (short)1858863104;
				short num3 = num;
				num = (short)74907649;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Visible = value;
			}
		}

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x00AC6C44 File Offset: 0x00AC4E44
		// (set) Token: 0x0600B9BF RID: 47551 RVA: 0x00AC6CF8 File Offset: 0x00AC4EF8
		public bool CnvSysFeaturesDOSCoastTimems_A7890_Editable
		{
			get
			{
				short num = (short)328348981;
				short num2 = num;
				num = (short)171193653;
				switch (num2 == num)
				{
				}
				num = (short)1328218113;
				if (num != 0)
				{
				}
				num = (short)643039232;
				short num3 = num;
				num = (short)243007488;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.Editable;
			}
			set
			{
				short num = (short)1056965674;
				short num2 = num;
				num = (short)178783274;
				switch (num2 == num)
				{
				}
				num = (short)527237121;
				if (num != 0)
				{
				}
				num = (short)1032650752;
				short num3 = num;
				num = (short)730923008;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.Editable = value;
			}
		}

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x0600B9C0 RID: 47552 RVA: 0x00AC6DB0 File Offset: 0x00AC4FB0
		internal string CnvSysFeaturesDOSCoastTimems_A7890_UILabel
		{
			get
			{
				short num = (short)1939788146;
				short num2 = num;
				num = (short)1432080754;
				switch (num2 == num)
				{
				}
				num = (short)1950482433;
				if (num != 0)
				{
				}
				num = (short)641794048;
				short num3 = num;
				num = (short)496631808;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.UIName;
			}
		}

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x00AC6E68 File Offset: 0x00AC5068
		// (set) Token: 0x0600B9C2 RID: 47554 RVA: 0x00AC6F1C File Offset: 0x00AC511C
		internal bool CnvSysFeaturesDOSCoastTimems_A7890_HiddenStatic
		{
			get
			{
				short num = (short)938475521;
				if (num != 0)
				{
				}
				num = (short)511623598;
				short num2 = num;
				num = (short)943636910;
				switch (num2 == num)
				{
				}
				num = (short)2004221952;
				short num3 = num;
				num = (short)110362624;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.HiddenStatic;
			}
			set
			{
				short num = (short)1705370564;
				short num2 = num;
				num = (short)2076238788;
				switch (num2 == num)
				{
				}
				num = (short)243531776;
				if (num != 0)
				{
				}
				num = (short)1467416576;
				short num3 = num;
				num = (short)1279262721;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.HiddenStatic = value;
			}
		}

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x00AC6FD0 File Offset: 0x00AC51D0
		// (set) Token: 0x0600B9C4 RID: 47556 RVA: 0x00AC7084 File Offset: 0x00AC5284
		internal bool CnvSysFeaturesDOSCoastTimems_A7890_HiddenDynamic
		{
			get
			{
				short num = (short)1132947136;
				short num2 = num;
				num = (short)1370973888;
				switch (num2 == num)
				{
				}
				num = (short)819134464;
				if (num != 0)
				{
				}
				num = (short)362807296;
				short num3 = num;
				num = (short)1549074433;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890.HiddenDynamic;
			}
			set
			{
				short num = (short)678096552;
				short num2 = num;
				num = (short)2067721896;
				switch (num2 == num)
				{
				}
				num = (short)2134769665;
				if (num != 0)
				{
				}
				num = (short)167706624;
				short num3 = num;
				num = (short)1203961856;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSCoastTimems_A7890.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x00AC713C File Offset: 0x00AC533C
		public bool CnvSysFeaturesDOSCoastTimems_A7890_HasDiffs
		{
			get
			{
				short num = (short)711209666;
				short num2 = num;
				num = (short)652620482;
				switch (num2 == num)
				{
				}
				num = (short)167116801;
				if (num != 0)
				{
				}
				num = (short)374013952;
				short num3 = num;
				num = (short)1773076480;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSCoastTimems_A7890._HasDiffs;
			}
		}

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x00AC71F0 File Offset: 0x00AC53F0
		// (set) Token: 0x0600B9C7 RID: 47559 RVA: 0x00AC72A4 File Offset: 0x00AC54A4
		public int CnvSysFeaturesDOSOperation_A7891Value
		{
			get
			{
				short num = (short)1414216603;
				short num2 = num;
				num = (short)1223244699;
				switch (num2 == num)
				{
				}
				num = (short)118030337;
				if (num != 0)
				{
				}
				num = (short)1450573824;
				short num3 = num;
				num = (short)1635450880;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.Value;
			}
			set
			{
				short num = (short)1457594997;
				short num2 = num;
				num = (short)250946165;
				switch (num2 == num)
				{
				}
				num = (short)2133786625;
				if (num != 0)
				{
				}
				num = (short)231866368;
				short num3 = num;
				num = (short)2015363072;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.Value = value;
			}
		}

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x00AC7358 File Offset: 0x00AC5558
		// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x00AC7410 File Offset: 0x00AC5610
		public string CnvSysFeaturesDOSOperation_A7891_UIValue
		{
			get
			{
				short num = (short)1079284810;
				short num2 = num;
				num = (short)766284874;
				switch (num2 == num)
				{
				}
				num = (short)2107834368;
				if (num != 0)
				{
				}
				num = (short)237305856;
				short num3 = num;
				num = (short)407109633;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.UIValue;
			}
			set
			{
				short num = (short)900757703;
				short num2 = num;
				num = (short)504068295;
				switch (num2 == num)
				{
				}
				num = (short)2067857409;
				if (num != 0)
				{
				}
				num = (short)681312256;
				short num3 = num;
				num = (short)2023489536;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.UIValue = value;
			}
		}

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x0600B9CA RID: 47562 RVA: 0x00AC74C4 File Offset: 0x00AC56C4
		public global::AcpBusinessLayer.AcpListField CnvSysFeaturesDOSOperation_A7891
		{
			get
			{
				short num = (short)1894897954;
				short num2 = num;
				num = (short)1264179490;
				switch (num2 == num)
				{
				}
				num = (short)1895432193;
				if (num != 0)
				{
				}
				num = (short)28835840;
				short num3 = num;
				num = (short)1112735744;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891;
			}
		}

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x00AC7578 File Offset: 0x00AC5778
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x00AC762C File Offset: 0x00AC582C
		public bool CnvSysFeaturesDOSOperation_A7891_Applicable
		{
			get
			{
				short num = (short)193396737;
				if (num != 0)
				{
				}
				num = (short)21935963;
				short num2 = num;
				num = (short)937080667;
				switch (num2 == num)
				{
				}
				num = (short)1178140672;
				short num3 = num;
				num = (short)1307377664;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.Applicable;
			}
			set
			{
				short num = (short)208998984;
				short num2 = num;
				num = (short)404886088;
				switch (num2 == num)
				{
				}
				num = (short)843120641;
				if (num != 0)
				{
				}
				num = (short)735248384;
				short num3 = num;
				num = (short)359858176;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.Applicable = value;
			}
		}

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x0600B9CD RID: 47565 RVA: 0x00AC76E4 File Offset: 0x00AC58E4
		// (set) Token: 0x0600B9CE RID: 47566 RVA: 0x00AC779C File Offset: 0x00AC599C
		public bool CnvSysFeaturesDOSOperation_A7891_Valid
		{
			get
			{
				short num = (short)1887240193;
				if (num != 0)
				{
				}
				num = (short)1963320276;
				short num2 = num;
				num = (short)2035606484;
				switch (num2 == num)
				{
				}
				num = (short)1111359488;
				short num3 = num;
				num = (short)1047199744;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.Valid;
			}
			set
			{
				short num = (short)1815799498;
				short num2 = num;
				num = (short)907470538;
				switch (num2 == num)
				{
				}
				num = (short)554237953;
				if (num != 0)
				{
				}
				num = (short)39714816;
				short num3 = num;
				num = (short)537722880;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.Valid = value;
			}
		}

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x0600B9CF RID: 47567 RVA: 0x00AC7850 File Offset: 0x00AC5A50
		// (set) Token: 0x0600B9D0 RID: 47568 RVA: 0x00AC7904 File Offset: 0x00AC5B04
		public bool CnvSysFeaturesDOSOperation_A7891_Visible
		{
			get
			{
				short num = (short)225949111;
				short num2 = num;
				num = (short)1666626999;
				switch (num2 == num)
				{
				}
				num = (short)946733056;
				if (num != 0)
				{
				}
				num = (short)45875200;
				short num3 = num;
				num = (short)1765736449;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.Visible;
			}
			set
			{
				short num = (short)562608866;
				short num2 = num;
				num = (short)733657826;
				switch (num2 == num)
				{
				}
				num = (short)835452928;
				if (num != 0)
				{
				}
				num = (short)592642048;
				short num3 = num;
				num = (short)211550209;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.Visible = value;
			}
		}

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x00AC79BC File Offset: 0x00AC5BBC
		// (set) Token: 0x0600B9D2 RID: 47570 RVA: 0x00AC7A70 File Offset: 0x00AC5C70
		public bool CnvSysFeaturesDOSOperation_A7891_Editable
		{
			get
			{
				short num = (short)1347687575;
				short num2 = num;
				num = (short)2058425495;
				switch (num2 == num)
				{
				}
				num = (short)1831862272;
				if (num != 0)
				{
				}
				num = (short)1807745024;
				short num3 = num;
				num = (short)201261057;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.Editable;
			}
			set
			{
				short num = (short)1101513379;
				short num2 = num;
				num = (short)1968292515;
				switch (num2 == num)
				{
				}
				num = (short)547028992;
				if (num != 0)
				{
				}
				num = (short)734396416;
				short num3 = num;
				num = (short)1235288065;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.Editable = value;
			}
		}

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x0600B9D3 RID: 47571 RVA: 0x00AC7B28 File Offset: 0x00AC5D28
		internal string CnvSysFeaturesDOSOperation_A7891_UILabel
		{
			get
			{
				short num = (short)734265345;
				if (num != 0)
				{
				}
				num = (short)178585300;
				short num2 = num;
				num = (short)623574740;
				switch (num2 == num)
				{
				}
				num = (short)71172096;
				short num3 = num;
				num = (short)1489240064;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.UIName;
			}
		}

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x0600B9D4 RID: 47572 RVA: 0x00AC7BE0 File Offset: 0x00AC5DE0
		// (set) Token: 0x0600B9D5 RID: 47573 RVA: 0x00AC7C94 File Offset: 0x00AC5E94
		internal bool CnvSysFeaturesDOSOperation_A7891_HiddenStatic
		{
			get
			{
				short num = (short)1498913569;
				short num2 = num;
				num = (short)1361615649;
				switch (num2 == num)
				{
				}
				num = (short)138674177;
				if (num != 0)
				{
				}
				num = (short)1538129920;
				short num3 = num;
				num = (short)321126400;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.HiddenStatic;
			}
			set
			{
				short num = (short)2064018709;
				short num2 = num;
				num = (short)37317909;
				switch (num2 == num)
				{
				}
				num = (short)510918657;
				if (num != 0)
				{
				}
				num = (short)586809344;
				short num3 = num;
				num = (short)209780736;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.HiddenStatic = value;
			}
		}

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x0600B9D6 RID: 47574 RVA: 0x00AC7D48 File Offset: 0x00AC5F48
		// (set) Token: 0x0600B9D7 RID: 47575 RVA: 0x00AC7DFC File Offset: 0x00AC5FFC
		internal bool CnvSysFeaturesDOSOperation_A7891_HiddenDynamic
		{
			get
			{
				short num = (short)1798320847;
				short num2 = num;
				num = (short)548156111;
				switch (num2 == num)
				{
				}
				num = (short)851312640;
				if (num != 0)
				{
				}
				num = (short)138936320;
				short num3 = num;
				num = (short)1485963265;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891.HiddenDynamic;
			}
			set
			{
				short num = (short)1981055845;
				short num2 = num;
				num = (short)1778156389;
				switch (num2 == num)
				{
				}
				num = (short)652935169;
				if (num != 0)
				{
				}
				num = (short)1548288000;
				short num3 = num;
				num = (short)28180480;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDOSOperation_A7891.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x00AC7EB0 File Offset: 0x00AC60B0
		public bool CnvSysFeaturesDOSOperation_A7891_HasDiffs
		{
			get
			{
				short num = (short)1615190831;
				short num2 = num;
				num = (short)132111151;
				switch (num2 == num)
				{
				}
				num = (short)303955968;
				if (num != 0)
				{
				}
				num = (short)1238564864;
				short num3 = num;
				num = (short)498073601;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDOSOperation_A7891._HasDiffs;
			}
		}

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x00AC7F64 File Offset: 0x00AC6164
		// (set) Token: 0x0600B9DA RID: 47578 RVA: 0x00AC8018 File Offset: 0x00AC6218
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930Value
		{
			get
			{
				short num = (short)479338773;
				short num2 = num;
				num = (short)911286549;
				switch (num2 == num)
				{
				}
				num = (short)454295553;
				if (num != 0)
				{
				}
				num = (short)1658585088;
				short num3 = num;
				num = (short)1335951360;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Value;
			}
			set
			{
				short num = (short)167407889;
				short num2 = num;
				num = (short)645165329;
				switch (num2 == num)
				{
				}
				num = (short)642646017;
				if (num != 0)
				{
				}
				num = (short)670498816;
				short num3 = num;
				num = (short)1524236288;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Value = value;
			}
		}

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x00AC80CC File Offset: 0x00AC62CC
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesEmergencyAlarmRxIndicator_A7930
		{
			get
			{
				short num = (short)372358019;
				short num2 = num;
				num = (short)234601347;
				switch (num2 == num)
				{
				}
				num = (short)370475008;
				short num3 = num;
				num = (short)1253376001;
				if (num != 0)
				{
				}
				num = (short)1680211968;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930;
			}
		}

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x00AC8178 File Offset: 0x00AC6378
		// (set) Token: 0x0600B9DD RID: 47581 RVA: 0x00AC8230 File Offset: 0x00AC6430
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_UIValue
		{
			get
			{
				short num = (short)2098487006;
				short num2 = num;
				num = (short)60579550;
				switch (num2 == num)
				{
				}
				num = (short)1785462784;
				short num3 = num;
				num = (short)1710686209;
				if (num != 0)
				{
				}
				num = (short)2132410368;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Value;
			}
			set
			{
				short num = (short)1465811270;
				short num2 = num;
				num = (short)805667142;
				switch (num2 == num)
				{
				}
				num = (short)982646784;
				short num3 = num;
				num = (short)428081153;
				if (num != 0)
				{
				}
				num = (short)825163776;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Value = value;
			}
		}

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x0600B9DE RID: 47582 RVA: 0x00AC82E8 File Offset: 0x00AC64E8
		// (set) Token: 0x0600B9DF RID: 47583 RVA: 0x00AC839C File Offset: 0x00AC659C
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_Applicable
		{
			get
			{
				short num = (short)1161282588;
				short num2 = num;
				num = (short)389202972;
				switch (num2 == num)
				{
				}
				num = (short)587726848;
				short num3 = num;
				num = (short)274726912;
				if (num != 0)
				{
				}
				num = (short)1646067713;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Applicable;
			}
			set
			{
				short num = (short)1960297144;
				short num2 = num;
				num = (short)1386726072;
				switch (num2 == num)
				{
				}
				num = (short)261685248;
				short num3 = num;
				num = (short)1594490881;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Applicable = value;
			}
		}

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x00AC8450 File Offset: 0x00AC6650
		// (set) Token: 0x0600B9E1 RID: 47585 RVA: 0x00AC8504 File Offset: 0x00AC6704
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_Valid
		{
			get
			{
				short num = (short)1763848874;
				short num2 = num;
				num = (short)563491498;
				switch (num2 == num)
				{
				}
				num = (short)385220608;
				short num3 = num;
				num = (short)271450112;
				if (num != 0)
				{
				}
				num = (short)1200422913;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Valid;
			}
			set
			{
				short num = (short)711327745;
				if (num != 0)
				{
				}
				num = (short)123082697;
				short num2 = num;
				num = (short)1195775945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227620352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824129024;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Valid = value;
			}
		}

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x00AC85B8 File Offset: 0x00AC67B8
		// (set) Token: 0x0600B9E3 RID: 47587 RVA: 0x00AC8668 File Offset: 0x00AC6868
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_Visible
		{
			get
			{
				short num = (short)571499760;
				short num2 = num;
				num = (short)1086940400;
				switch (num2 == num)
				{
				}
				num = (short)1195376640;
				short num3 = num;
				num = (short)1829699585;
				if (num != 0)
				{
				}
				num = (short)1809776640;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Visible;
			}
			set
			{
				short num = (short)32923955;
				short num2 = num;
				num = (short)1596350771;
				switch (num2 == num)
				{
				}
				num = (short)115212288;
				short num3 = num;
				num = (short)2009464833;
				if (num != 0)
				{
				}
				num = (short)968294400;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Visible = value;
			}
		}

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x00AC871C File Offset: 0x00AC691C
		// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x00AC87D4 File Offset: 0x00AC69D4
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_Editable
		{
			get
			{
				short num = (short)913118391;
				short num2 = num;
				num = (short)1551111351;
				switch (num2 == num)
				{
				}
				num = (short)1595604992;
				short num3 = num;
				num = (short)1319174144;
				if (num != 0)
				{
				}
				num = (short)154992641;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Editable;
			}
			set
			{
				short num = (short)1955778412;
				short num2 = num;
				num = (short)1534906220;
				switch (num2 == num)
				{
				}
				num = (short)1827012608;
				short num3 = num;
				num = (short)1511915520;
				if (num != 0)
				{
				}
				num = (short)268763137;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Editable = value;
			}
		}

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x0600B9E6 RID: 47590 RVA: 0x00AC8888 File Offset: 0x00AC6A88
		internal string CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_UILabel
		{
			get
			{
				short num = (short)127401985;
				if (num != 0)
				{
				}
				num = (short)998969346;
				short num2 = num;
				num = (short)1802506242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209256448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676659200;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.UIName;
			}
		}

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x00AC893C File Offset: 0x00AC6B3C
		// (set) Token: 0x0600B9E8 RID: 47592 RVA: 0x00AC89F0 File Offset: 0x00AC6BF0
		internal bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_HiddenStatic
		{
			get
			{
				short num = (short)1461514197;
				short num2 = num;
				num = (short)1464135637;
				switch (num2 == num)
				{
				}
				num = (short)1226964992;
				short num3 = num;
				num = (short)1376649217;
				if (num != 0)
				{
				}
				num = (short)755499008;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.HiddenStatic;
			}
			set
			{
				short num = (short)297681076;
				short num2 = num;
				num = (short)650985652;
				switch (num2 == num)
				{
				}
				num = (short)365494272;
				short num3 = num;
				num = (short)657981441;
				if (num != 0)
				{
				}
				num = (short)754384896;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.HiddenStatic = value;
			}
		}

		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x00AC8AA4 File Offset: 0x00AC6CA4
		// (set) Token: 0x0600B9EA RID: 47594 RVA: 0x00AC8B58 File Offset: 0x00AC6D58
		internal bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_HiddenDynamic
		{
			get
			{
				short num = (short)1822937831;
				short num2 = num;
				num = (short)1814352615;
				switch (num2 == num)
				{
				}
				num = (short)840040448;
				short num3 = num;
				num = (short)1200291841;
				if (num != 0)
				{
				}
				num = (short)1212612608;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.HiddenDynamic;
			}
			set
			{
				short num = (short)65643101;
				short num2 = num;
				num = (short)645571165;
				switch (num2 == num)
				{
				}
				num = (short)1685585920;
				short num3 = num;
				num = (short)22413312;
				if (num != 0)
				{
				}
				num = (short)387710977;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D13 RID: 23827
		// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x00AC8C0C File Offset: 0x00AC6E0C
		public bool CnvSysFeaturesEmergencyAlarmRxIndicator_A7930_HasDiffs
		{
			get
			{
				short num = (short)1790589994;
				short num2 = num;
				num = (short)1188314154;
				switch (num2 == num)
				{
				}
				num = (short)517996544;
				short num3 = num;
				num = (short)1292828673;
				if (num != 0)
				{
				}
				num = (short)1845100544;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAlarmRxIndicator_A7930._HasDiffs;
			}
		}

		// Token: 0x17005D14 RID: 23828
		// (get) Token: 0x0600B9EC RID: 47596 RVA: 0x00AC8CC0 File Offset: 0x00AC6EC0
		// (set) Token: 0x0600B9ED RID: 47597 RVA: 0x00AC8D74 File Offset: 0x00AC6F74
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931Value
		{
			get
			{
				short num = (short)1125565481;
				short num2 = num;
				num = (short)631161897;
				switch (num2 == num)
				{
				}
				num = (short)1123614720;
				short num3 = num;
				num = (short)2065694721;
				if (num != 0)
				{
				}
				num = (short)1044054016;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Value;
			}
			set
			{
				short num = (short)839318608;
				short num2 = num;
				num = (short)493812816;
				switch (num2 == num)
				{
				}
				num = (short)566099968;
				short num3 = num;
				num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)377946112;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Value = value;
			}
		}

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x00AC8E28 File Offset: 0x00AC7028
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesQualifyEmergencyAlarmRx_A7931
		{
			get
			{
				short num = (short)1499054373;
				short num2 = num;
				num = (short)1309720869;
				switch (num2 == num)
				{
				}
				num = (short)142082048;
				short num3 = num;
				num = (short)1295319040;
				if (num != 0)
				{
				}
				num = (short)1003487233;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931;
			}
		}

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x00AC8ED8 File Offset: 0x00AC70D8
		// (set) Token: 0x0600B9F0 RID: 47600 RVA: 0x00AC8F90 File Offset: 0x00AC7190
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_UIValue
		{
			get
			{
				short num = (short)447493814;
				short num2 = num;
				num = (short)1629238966;
				switch (num2 == num)
				{
				}
				num = (short)1029242880;
				short num3 = num;
				num = (short)457834497;
				if (num != 0)
				{
				}
				num = (short)653787136;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Value;
			}
			set
			{
				short num = (short)1681089471;
				short num2 = num;
				num = (short)1336304575;
				switch (num2 == num)
				{
				}
				num = (short)1608515584;
				short num3 = num;
				num = (short)2004680705;
				if (num != 0)
				{
				}
				num = (short)38862848;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Value = value;
			}
		}

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x00AC9044 File Offset: 0x00AC7244
		// (set) Token: 0x0600B9F2 RID: 47602 RVA: 0x00AC90F8 File Offset: 0x00AC72F8
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_Applicable
		{
			get
			{
				short num = (short)1818666530;
				short num2 = num;
				num = (short)1814668834;
				switch (num2 == num)
				{
				}
				num = (short)2119106560;
				short num3 = num;
				num = (short)1530462209;
				if (num != 0)
				{
				}
				num = (short)1188757504;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Applicable;
			}
			set
			{
				short num = (short)1774592474;
				short num2 = num;
				num = (short)1050091994;
				switch (num2 == num)
				{
				}
				num = (short)153812992;
				short num3 = num;
				num = (short)1948909569;
				if (num != 0)
				{
				}
				num = (short)430047232;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Applicable = value;
			}
		}

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x0600B9F3 RID: 47603 RVA: 0x00AC91AC File Offset: 0x00AC73AC
		// (set) Token: 0x0600B9F4 RID: 47604 RVA: 0x00AC9260 File Offset: 0x00AC7460
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_Valid
		{
			get
			{
				short num = (short)1809842177;
				if (num != 0)
				{
				}
				num = (short)1149614145;
				short num2 = num;
				num = (short)422099009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)31457280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414646272;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Valid;
			}
			set
			{
				short num = (short)1517158401;
				if (num != 0)
				{
				}
				num = (short)1769185067;
				short num2 = num;
				num = (short)1575657259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119827456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476526080;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Valid = value;
			}
		}

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x0600B9F5 RID: 47605 RVA: 0x00AC9318 File Offset: 0x00AC7518
		// (set) Token: 0x0600B9F6 RID: 47606 RVA: 0x00AC93CC File Offset: 0x00AC75CC
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_Visible
		{
			get
			{
				short num = (short)2133407328;
				short num2 = num;
				num = (short)967194208;
				switch (num2 == num)
				{
				}
				num = (short)152305664;
				short num3 = num;
				num = (short)1635057665;
				if (num != 0)
				{
				}
				num = (short)1588330496;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Visible;
			}
			set
			{
				short num = (short)1722837257;
				short num2 = num;
				num = (short)392849673;
				switch (num2 == num)
				{
				}
				num = (short)51118080;
				short num3 = num;
				num = (short)1690304513;
				if (num != 0)
				{
				}
				num = (short)866713600;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Visible = value;
			}
		}

		// Token: 0x17005D1A RID: 23834
		// (get) Token: 0x0600B9F7 RID: 47607 RVA: 0x00AC9480 File Offset: 0x00AC7680
		// (set) Token: 0x0600B9F8 RID: 47608 RVA: 0x00AC9534 File Offset: 0x00AC7734
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_Editable
		{
			get
			{
				short num = (short)1920427101;
				short num2 = num;
				num = (short)628581469;
				switch (num2 == num)
				{
				}
				num = (short)1981153280;
				short num3 = num;
				num = (short)695730176;
				if (num != 0)
				{
				}
				num = (short)984875009;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Editable;
			}
			set
			{
				short num = (short)407801566;
				short num2 = num;
				num = (short)1931185886;
				switch (num2 == num)
				{
				}
				num = (short)1192230912;
				short num3 = num;
				num = (short)297467905;
				if (num != 0)
				{
				}
				num = (short)958136320;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.Editable = value;
			}
		}

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x00AC95EC File Offset: 0x00AC77EC
		internal string CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_UILabel
		{
			get
			{
				short num = (short)1639931999;
				short num2 = num;
				num = (short)571433055;
				switch (num2 == num)
				{
				}
				num = (short)1636433920;
				short num3 = num;
				num = (short)1135673345;
				if (num != 0)
				{
				}
				num = (short)254869504;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.UIName;
			}
		}

		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x0600B9FA RID: 47610 RVA: 0x00AC96A0 File Offset: 0x00AC78A0
		// (set) Token: 0x0600B9FB RID: 47611 RVA: 0x00AC9750 File Offset: 0x00AC7950
		internal bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_HiddenStatic
		{
			get
			{
				short num = (short)1175453697;
				if (num != 0)
				{
				}
				num = (short)912952208;
				short num2 = num;
				num = (short)103910288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242497024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407240704;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.HiddenStatic;
			}
			set
			{
				short num = (short)1999293843;
				short num2 = num;
				num = (short)1135857043;
				switch (num2 == num)
				{
				}
				num = (short)1279524864;
				short num3 = num;
				num = (short)932511744;
				if (num != 0)
				{
				}
				num = (short)1232863233;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.HiddenStatic = value;
			}
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x0600B9FC RID: 47612 RVA: 0x00AC9804 File Offset: 0x00AC7A04
		// (set) Token: 0x0600B9FD RID: 47613 RVA: 0x00AC98BC File Offset: 0x00AC7ABC
		internal bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_HiddenDynamic
		{
			get
			{
				short num = (short)1623310768;
				short num2 = num;
				num = (short)1704903088;
				switch (num2 == num)
				{
				}
				num = (short)1664024576;
				short num3 = num;
				num = (short)370802689;
				if (num != 0)
				{
				}
				num = (short)1290731520;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.HiddenDynamic;
			}
			set
			{
				short num = (short)1234468887;
				short num2 = num;
				num = (short)250642455;
				switch (num2 == num)
				{
				}
				num = (short)621936640;
				short num3 = num;
				num = (short)1078263809;
				if (num != 0)
				{
				}
				num = (short)392429568;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0600B9FE RID: 47614 RVA: 0x00AC9974 File Offset: 0x00AC7B74
		public bool CnvSysFeaturesQualifyEmergencyAlarmRx_A7931_HasDiffs
		{
			get
			{
				short num = (short)402653185;
				if (num != 0)
				{
				}
				num = (short)619430807;
				short num2 = num;
				num = (short)1808974743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716649984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)827916288;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesQualifyEmergencyAlarmRx_A7931._HasDiffs;
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0600B9FF RID: 47615 RVA: 0x00AC9A28 File Offset: 0x00AC7C28
		// (set) Token: 0x0600BA00 RID: 47616 RVA: 0x00AC9AE0 File Offset: 0x00AC7CE0
		public bool CnvSysFeaturesMessage_A8497Value
		{
			get
			{
				short num = (short)1402082052;
				short num2 = num;
				num = (short)2105283332;
				switch (num2 == num)
				{
				}
				num = (short)208535552;
				short num3 = num;
				num = (short)1506738177;
				if (num != 0)
				{
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Value;
			}
			set
			{
				short num = (short)709997738;
				short num2 = num;
				num = (short)540456106;
				switch (num2 == num)
				{
				}
				num = (short)340066304;
				short num3 = num;
				num = (short)59768832;
				if (num != 0)
				{
				}
				num = (short)1383464961;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Value = value;
			}
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x00AC9B98 File Offset: 0x00AC7D98
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesMessage_A8497
		{
			get
			{
				short num = (short)1885863937;
				if (num != 0)
				{
				}
				num = (short)1549932138;
				short num2 = num;
				num = (short)1677071978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)343670784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497;
			}
		}

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x0600BA02 RID: 47618 RVA: 0x00AC9C48 File Offset: 0x00AC7E48
		// (set) Token: 0x0600BA03 RID: 47619 RVA: 0x00AC9CFC File Offset: 0x00AC7EFC
		public bool CnvSysFeaturesMessage_A8497_UIValue
		{
			get
			{
				short num = (short)1929610417;
				short num2 = num;
				num = (short)578913457;
				switch (num2 == num)
				{
				}
				num = (short)6815744;
				short num3 = num;
				num = (short)1395654657;
				if (num != 0)
				{
				}
				num = (short)1658781696;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Value;
			}
			set
			{
				short num = (short)818085889;
				if (num != 0)
				{
				}
				num = (short)1376254590;
				short num2 = num;
				num = (short)2116745854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)612433920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716570624;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Value = value;
			}
		}

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x00AC9DB0 File Offset: 0x00AC7FB0
		// (set) Token: 0x0600BA05 RID: 47621 RVA: 0x00AC9E68 File Offset: 0x00AC8068
		public bool CnvSysFeaturesMessage_A8497_Applicable
		{
			get
			{
				short num = (short)1324383972;
				short num2 = num;
				num = (short)2015657700;
				switch (num2 == num)
				{
				}
				num = (short)900857856;
				short num3 = num;
				num = (short)1867186176;
				if (num != 0)
				{
				}
				num = (short)1981480961;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Applicable;
			}
			set
			{
				short num = (short)183338391;
				short num2 = num;
				num = (short)907904407;
				switch (num2 == num)
				{
				}
				num = (short)315031552;
				short num3 = num;
				num = (short)1841299456;
				if (num != 0)
				{
				}
				num = (short)1613168641;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Applicable = value;
			}
		}

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x00AC9F20 File Offset: 0x00AC8120
		// (set) Token: 0x0600BA07 RID: 47623 RVA: 0x00AC9FD4 File Offset: 0x00AC81D4
		public bool CnvSysFeaturesMessage_A8497_Valid
		{
			get
			{
				short num = (short)929955841;
				if (num != 0)
				{
				}
				num = (short)808689920;
				short num2 = num;
				num = (short)1924768000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)357826560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1623064576;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Valid;
			}
			set
			{
				short num = (short)665190401;
				if (num != 0)
				{
				}
				num = (short)1117252470;
				short num2 = num;
				num = (short)171371382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)24117248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1744109568;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Valid = value;
			}
		}

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x00ACA088 File Offset: 0x00AC8288
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x00ACA13C File Offset: 0x00AC833C
		public bool CnvSysFeaturesMessage_A8497_Visible
		{
			get
			{
				short num = (short)1964967061;
				short num2 = num;
				num = (short)592839829;
				switch (num2 == num)
				{
				}
				num = (short)1325334528;
				short num3 = num;
				num = (short)1317994496;
				if (num != 0)
				{
				}
				num = (short)1074855937;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Visible;
			}
			set
			{
				short num = (short)1075172045;
				short num2 = num;
				num = (short)421450445;
				switch (num2 == num)
				{
				}
				num = (short)159383552;
				short num3 = num;
				num = (short)725811201;
				if (num != 0)
				{
				}
				num = (short)1147142144;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Visible = value;
			}
		}

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x00ACA1F4 File Offset: 0x00AC83F4
		// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x00ACA2A8 File Offset: 0x00AC84A8
		public bool CnvSysFeaturesMessage_A8497_Editable
		{
			get
			{
				short num = (short)1357954592;
				short num2 = num;
				num = (short)1622654496;
				switch (num2 == num)
				{
				}
				num = (short)2092433408;
				short num3 = num;
				num = (short)1876295681;
				if (num != 0)
				{
				}
				num = (short)493551616;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.Editable;
			}
			set
			{
				short num = (short)2048706618;
				short num2 = num;
				num = (short)99403834;
				switch (num2 == num)
				{
				}
				num = (short)569704448;
				short num3 = num;
				num = (short)1186922497;
				if (num != 0)
				{
				}
				num = (short)1281687552;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.Editable = value;
			}
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x0600BA0C RID: 47628 RVA: 0x00ACA360 File Offset: 0x00AC8560
		internal string CnvSysFeaturesMessage_A8497_UILabel
		{
			get
			{
				short num = (short)358206135;
				short num2 = num;
				num = (short)1948175031;
				switch (num2 == num)
				{
				}
				num = (short)1188298752;
				short num3 = num;
				num = (short)1092878337;
				if (num != 0)
				{
				}
				num = (short)949616640;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.UIName;
			}
		}

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0600BA0D RID: 47629 RVA: 0x00ACA414 File Offset: 0x00AC8614
		// (set) Token: 0x0600BA0E RID: 47630 RVA: 0x00ACA4C8 File Offset: 0x00AC86C8
		internal bool CnvSysFeaturesMessage_A8497_HiddenStatic
		{
			get
			{
				short num = (short)1377105573;
				short num2 = num;
				num = (short)223540901;
				switch (num2 == num)
				{
				}
				num = (short)67829760;
				short num3 = num;
				num = (short)1198522369;
				if (num != 0)
				{
				}
				num = (short)204210176;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.HiddenStatic;
			}
			set
			{
				short num = (short)2093989691;
				short num2 = num;
				num = (short)850050875;
				switch (num2 == num)
				{
				}
				num = (short)93585408;
				short num3 = num;
				num = (short)1308164097;
				if (num != 0)
				{
				}
				num = (short)1804992512;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.HiddenStatic = value;
			}
		}

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x0600BA0F RID: 47631 RVA: 0x00ACA57C File Offset: 0x00AC877C
		// (set) Token: 0x0600BA10 RID: 47632 RVA: 0x00ACA630 File Offset: 0x00AC8830
		internal bool CnvSysFeaturesMessage_A8497_HiddenDynamic
		{
			get
			{
				short num = (short)1220927199;
				short num2 = num;
				num = (short)2006376159;
				switch (num2 == num)
				{
				}
				num = (short)77332480;
				short num3 = num;
				num = (short)698417153;
				if (num != 0)
				{
				}
				num = (short)1116995584;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497.HiddenDynamic;
			}
			set
			{
				short num = (short)1467768815;
				short num2 = num;
				num = (short)1806065647;
				switch (num2 == num)
				{
				}
				num = (short)425656320;
				short num3 = num;
				num = (short)1968504833;
				if (num != 0)
				{
				}
				num = (short)1773404160;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesMessage_A8497.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x0600BA11 RID: 47633 RVA: 0x00ACA6E4 File Offset: 0x00AC88E4
		public bool CnvSysFeaturesMessage_A8497_HasDiffs
		{
			get
			{
				short num = (short)2093955675;
				short num2 = num;
				num = (short)1031354971;
				switch (num2 == num)
				{
				}
				num = (short)1886715904;
				short num3 = num;
				num = (short)1255669761;
				if (num != 0)
				{
				}
				num = (short)616824832;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesMessage_A8497._HasDiffs;
			}
		}

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x00ACA79C File Offset: 0x00AC899C
		// (set) Token: 0x0600BA13 RID: 47635 RVA: 0x00ACA850 File Offset: 0x00AC8A50
		public bool CnvSysFeaturesRadioCheck_A8826Value
		{
			get
			{
				short num = (short)1129732036;
				short num2 = num;
				num = (short)1859082180;
				switch (num2 == num)
				{
				}
				num = (short)1141637120;
				short num3 = num;
				num = (short)1246756865;
				if (num != 0)
				{
				}
				num = (short)2085552128;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Value;
			}
			set
			{
				short num = (short)1038071995;
				short num2 = num;
				num = (short)2031925435;
				switch (num2 == num)
				{
				}
				num = (short)1409744896;
				short num3 = num;
				num = (short)1624506368;
				if (num != 0)
				{
				}
				num = (short)1258815489;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Value = value;
			}
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x0600BA14 RID: 47636 RVA: 0x00ACA904 File Offset: 0x00AC8B04
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesRadioCheck_A8826
		{
			get
			{
				short num = (short)1103716203;
				short num2 = num;
				num = (short)1298292587;
				switch (num2 == num)
				{
				}
				num = (short)1130889216;
				short num3 = num;
				num = (short)425525249;
				if (num != 0)
				{
				}
				num = (short)437256192;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826;
			}
		}

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x00ACA9B4 File Offset: 0x00AC8BB4
		// (set) Token: 0x0600BA16 RID: 47638 RVA: 0x00ACAA68 File Offset: 0x00AC8C68
		public bool CnvSysFeaturesRadioCheck_A8826_UIValue
		{
			get
			{
				short num = (short)1929186267;
				short num2 = num;
				num = (short)684788699;
				switch (num2 == num)
				{
				}
				num = (short)2128740352;
				short num3 = num;
				num = (short)731316224;
				if (num != 0)
				{
				}
				num = (short)771686401;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Value;
			}
			set
			{
				short num = (short)1921646593;
				if (num != 0)
				{
				}
				num = (short)626271116;
				short num2 = num;
				num = (short)549856140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127940096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893976576;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Value = value;
			}
		}

		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x0600BA17 RID: 47639 RVA: 0x00ACAB20 File Offset: 0x00AC8D20
		// (set) Token: 0x0600BA18 RID: 47640 RVA: 0x00ACABD8 File Offset: 0x00AC8DD8
		public bool CnvSysFeaturesRadioCheck_A8826_Applicable
		{
			get
			{
				short num = (short)719945;
				short num2 = num;
				num = (short)25558089;
				switch (num2 == num)
				{
				}
				num = (short)754778112;
				short num3 = num;
				num = (short)142082049;
				if (num != 0)
				{
				}
				num = (short)719257600;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Applicable;
			}
			set
			{
				short num = (short)1652010688;
				short num2 = num;
				num = (short)2127343296;
				switch (num2 == num)
				{
				}
				num = (short)95485952;
				short num3 = num;
				num = (short)1134297088;
				if (num != 0)
				{
				}
				num = (short)2045313025;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Applicable = value;
			}
		}

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x0600BA19 RID: 47641 RVA: 0x00ACAC8C File Offset: 0x00AC8E8C
		// (set) Token: 0x0600BA1A RID: 47642 RVA: 0x00ACAD40 File Offset: 0x00AC8F40
		public bool CnvSysFeaturesRadioCheck_A8826_Valid
		{
			get
			{
				short num = (short)190709907;
				short num2 = num;
				num = (short)666632339;
				switch (num2 == num)
				{
				}
				num = (short)1343160320;
				short num3 = num;
				num = (short)688717825;
				if (num != 0)
				{
				}
				num = (short)40304640;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Valid;
			}
			set
			{
				short num = (short)1253102164;
				short num2 = num;
				num = (short)623432276;
				switch (num2 == num)
				{
				}
				num = (short)830341120;
				short num3 = num;
				num = (short)140836865;
				if (num != 0)
				{
				}
				num = (short)1392902144;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Valid = value;
			}
		}

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x0600BA1B RID: 47643 RVA: 0x00ACADF8 File Offset: 0x00AC8FF8
		// (set) Token: 0x0600BA1C RID: 47644 RVA: 0x00ACAEB0 File Offset: 0x00AC90B0
		public bool CnvSysFeaturesRadioCheck_A8826_Visible
		{
			get
			{
				short num = (short)1174320215;
				short num2 = num;
				num = (short)529314903;
				switch (num2 == num)
				{
				}
				num = (short)1266089984;
				short num3 = num;
				num = (short)380633089;
				if (num != 0)
				{
				}
				num = (short)1623588864;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Visible;
			}
			set
			{
				short num = (short)737100764;
				short num2 = num;
				num = (short)270877660;
				switch (num2 == num)
				{
				}
				num = (short)1618804736;
				short num3 = num;
				num = (short)1028063233;
				if (num != 0)
				{
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Visible = value;
			}
		}

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x0600BA1D RID: 47645 RVA: 0x00ACAF64 File Offset: 0x00AC9164
		// (set) Token: 0x0600BA1E RID: 47646 RVA: 0x00ACB014 File Offset: 0x00AC9214
		public bool CnvSysFeaturesRadioCheck_A8826_Editable
		{
			get
			{
				short num = (short)2015838831;
				short num2 = num;
				num = (short)1984316015;
				switch (num2 == num)
				{
				}
				num = (short)883818496;
				short num3 = num;
				num = (short)151257089;
				if (num != 0)
				{
				}
				num = (short)467075072;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.Editable;
			}
			set
			{
				short num = (short)367013413;
				short num2 = num;
				num = (short)50015781;
				switch (num2 == num)
				{
				}
				num = (short)1839595520;
				short num3 = num;
				num = (short)1098514432;
				if (num != 0)
				{
				}
				num = (short)1299185665;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.Editable = value;
			}
		}

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0600BA1F RID: 47647 RVA: 0x00ACB0CC File Offset: 0x00AC92CC
		internal string CnvSysFeaturesRadioCheck_A8826_UILabel
		{
			get
			{
				short num = (short)355582108;
				short num2 = num;
				num = (short)1554825372;
				switch (num2 == num)
				{
				}
				num = (short)2115567616;
				short num3 = num;
				num = (short)1817051137;
				if (num != 0)
				{
				}
				num = (short)744816640;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.UIName;
			}
		}

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x00ACB180 File Offset: 0x00AC9380
		// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x00ACB234 File Offset: 0x00AC9434
		internal bool CnvSysFeaturesRadioCheck_A8826_HiddenStatic
		{
			get
			{
				short num = (short)1131216897;
				if (num != 0)
				{
				}
				num = (short)742920015;
				short num2 = num;
				num = (short)460984143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2133458944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314979840;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.HiddenStatic;
			}
			set
			{
				short num = (short)1693486937;
				short num2 = num;
				num = (short)95522649;
				switch (num2 == num)
				{
				}
				num = (short)1273823232;
				short num3 = num;
				num = (short)951123969;
				if (num != 0)
				{
				}
				num = (short)108986368;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.HiddenStatic = value;
			}
		}

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x00ACB2F0 File Offset: 0x00AC94F0
		// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x00ACB3A4 File Offset: 0x00AC95A4
		internal bool CnvSysFeaturesRadioCheck_A8826_HiddenDynamic
		{
			get
			{
				short num = (short)1259243391;
				short num2 = num;
				num = (short)880052095;
				switch (num2 == num)
				{
				}
				num = (short)363790336;
				short num3 = num;
				num = (short)1623195649;
				if (num != 0)
				{
				}
				num = (short)578289664;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826.HiddenDynamic;
			}
			set
			{
				short num = (short)738307519;
				short num2 = num;
				num = (short)1940958655;
				switch (num2 == num)
				{
				}
				num = (short)1278935040;
				short num3 = num;
				num = (short)1613430785;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioCheck_A8826.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x00ACB458 File Offset: 0x00AC9658
		public bool CnvSysFeaturesRadioCheck_A8826_HasDiffs
		{
			get
			{
				short num = (short)302055425;
				if (num != 0)
				{
				}
				num = (short)1993373599;
				short num2 = num;
				num = (short)1444968351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1368326144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981612032;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioCheck_A8826._HasDiffs;
			}
		}

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x0600BA25 RID: 47653 RVA: 0x00ACB50C File Offset: 0x00AC970C
		// (set) Token: 0x0600BA26 RID: 47654 RVA: 0x00ACB5C4 File Offset: 0x00AC97C4
		public bool CnvSysFeaturesRadioInhibit_A8831Value
		{
			get
			{
				short num = (short)1337444006;
				short num2 = num;
				num = (short)57460390;
				switch (num2 == num)
				{
				}
				num = (short)427229184;
				short num3 = num;
				num = (short)50921472;
				if (num != 0)
				{
				}
				num = (short)921174017;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Value;
			}
			set
			{
				short num = (short)1266399185;
				short num2 = num;
				num = (short)266975185;
				switch (num2 == num)
				{
				}
				num = (short)358023168;
				short num3 = num;
				num = (short)340066305;
				if (num != 0)
				{
				}
				num = (short)376176640;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Value = value;
			}
		}

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0600BA27 RID: 47655 RVA: 0x00ACB67C File Offset: 0x00AC987C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesRadioInhibit_A8831
		{
			get
			{
				short num = (short)965598760;
				short num2 = num;
				num = (short)868474408;
				switch (num2 == num)
				{
				}
				num = (short)534708224;
				short num3 = num;
				num = (short)1844707329;
				if (num != 0)
				{
				}
				num = (short)1557528576;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831;
			}
		}

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x00ACB72C File Offset: 0x00AC992C
		// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x00ACB7E4 File Offset: 0x00AC99E4
		public bool CnvSysFeaturesRadioInhibit_A8831_UIValue
		{
			get
			{
				short num = (short)689898786;
				short num2 = num;
				num = (short)866059554;
				switch (num2 == num)
				{
				}
				num = (short)1161494528;
				short num3 = num;
				num = (short)1946353665;
				if (num != 0)
				{
				}
				num = (short)1197801472;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Value;
			}
			set
			{
				short num = (short)1125987940;
				short num2 = num;
				num = (short)1763653220;
				switch (num2 == num)
				{
				}
				num = (short)722468864;
				short num3 = num;
				num = (short)924319745;
				if (num != 0)
				{
				}
				num = (short)2027552768;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Value = value;
			}
		}

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x00ACB89C File Offset: 0x00AC9A9C
		// (set) Token: 0x0600BA2B RID: 47659 RVA: 0x00ACB950 File Offset: 0x00AC9B50
		public bool CnvSysFeaturesRadioInhibit_A8831_Applicable
		{
			get
			{
				short num = (short)1766044587;
				short num2 = num;
				num = (short)136426411;
				switch (num2 == num)
				{
				}
				num = (short)648937472;
				short num3 = num;
				num = (short)1354366977;
				if (num != 0)
				{
				}
				num = (short)1541341184;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Applicable;
			}
			set
			{
				short num = (short)2137377885;
				short num2 = num;
				num = (short)190106717;
				switch (num2 == num)
				{
				}
				num = (short)1130823680;
				short num3 = num;
				num = (short)380764160;
				if (num != 0)
				{
				}
				num = (short)1874329601;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Applicable = value;
			}
		}

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x00ACBA04 File Offset: 0x00AC9C04
		// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x00ACBABC File Offset: 0x00AC9CBC
		public bool CnvSysFeaturesRadioInhibit_A8831_Valid
		{
			get
			{
				short num = (short)1649702976;
				short num2 = num;
				num = (short)383940672;
				switch (num2 == num)
				{
				}
				num = (short)2027880448;
				short num3 = num;
				num = (short)1081344001;
				if (num != 0)
				{
				}
				num = (short)723124224;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Valid;
			}
			set
			{
				short num = (short)1283784705;
				if (num != 0)
				{
				}
				num = (short)2108399822;
				short num2 = num;
				num = (short)1288806606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068630016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103364096;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Valid = value;
			}
		}

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x00ACBB70 File Offset: 0x00AC9D70
		// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x00ACBC24 File Offset: 0x00AC9E24
		public bool CnvSysFeaturesRadioInhibit_A8831_Visible
		{
			get
			{
				short num = (short)1222416805;
				short num2 = num;
				num = (short)1347525029;
				switch (num2 == num)
				{
				}
				num = (short)159580160;
				short num3 = num;
				num = (short)953221121;
				if (num != 0)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Visible;
			}
			set
			{
				short num = (short)1589352505;
				short num2 = num;
				num = (short)885954617;
				switch (num2 == num)
				{
				}
				num = (short)1466499072;
				short num3 = num;
				num = (short)1852833792;
				if (num != 0)
				{
				}
				num = (short)879362049;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Visible = value;
			}
		}

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x0600BA30 RID: 47664 RVA: 0x00ACBCD8 File Offset: 0x00AC9ED8
		// (set) Token: 0x0600BA31 RID: 47665 RVA: 0x00ACBD8C File Offset: 0x00AC9F8C
		public bool CnvSysFeaturesRadioInhibit_A8831_Editable
		{
			get
			{
				short num = (short)1546452993;
				if (num != 0)
				{
				}
				num = (short)1470144804;
				short num2 = num;
				num = (short)811573540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1408696320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448738816;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.Editable;
			}
			set
			{
				short num = (short)931769521;
				short num2 = num;
				num = (short)1879157937;
				switch (num2 == num)
				{
				}
				num = (short)580255744;
				short num3 = num;
				num = (short)1812594689;
				if (num != 0)
				{
				}
				num = (short)773914624;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.Editable = value;
			}
		}

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x00ACBE40 File Offset: 0x00ACA040
		internal string CnvSysFeaturesRadioInhibit_A8831_UILabel
		{
			get
			{
				short num = (short)1999269283;
				short num2 = num;
				num = (short)1734045091;
				switch (num2 == num)
				{
				}
				num = (short)1951072256;
				short num3 = num;
				num = (short)1507262465;
				if (num != 0)
				{
				}
				num = (short)2143027200;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.UIName;
			}
		}

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x0600BA33 RID: 47667 RVA: 0x00ACBEF4 File Offset: 0x00ACA0F4
		// (set) Token: 0x0600BA34 RID: 47668 RVA: 0x00ACBFA8 File Offset: 0x00ACA1A8
		internal bool CnvSysFeaturesRadioInhibit_A8831_HiddenStatic
		{
			get
			{
				short num = (short)1418299220;
				short num2 = num;
				num = (short)1497532244;
				switch (num2 == num)
				{
				}
				num = (short)75104256;
				short num3 = num;
				num = (short)322437121;
				if (num != 0)
				{
				}
				num = (short)495517696;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.HiddenStatic;
			}
			set
			{
				short num = (short)377825363;
				short num2 = num;
				num = (short)1650272339;
				switch (num2 == num)
				{
				}
				num = (short)1372192768;
				short num3 = num;
				num = (short)1418854401;
				if (num != 0)
				{
				}
				num = (short)2113470464;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.HiddenStatic = value;
			}
		}

		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0600BA35 RID: 47669 RVA: 0x00ACC05C File Offset: 0x00ACA25C
		// (set) Token: 0x0600BA36 RID: 47670 RVA: 0x00ACC110 File Offset: 0x00ACA310
		internal bool CnvSysFeaturesRadioInhibit_A8831_HiddenDynamic
		{
			get
			{
				short num = (short)1417284315;
				short num2 = num;
				num = (short)200870619;
				switch (num2 == num)
				{
				}
				num = (short)1824260096;
				short num3 = num;
				num = (short)679870465;
				if (num != 0)
				{
				}
				num = (short)393084928;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831.HiddenDynamic;
			}
			set
			{
				short num = (short)495694744;
				short num2 = num;
				num = (short)331920280;
				switch (num2 == num)
				{
				}
				num = (short)1331822592;
				short num3 = num;
				num = (short)363593728;
				if (num != 0)
				{
				}
				num = (short)12189697;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRadioInhibit_A8831.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0600BA37 RID: 47671 RVA: 0x00ACC1C8 File Offset: 0x00ACA3C8
		public bool CnvSysFeaturesRadioInhibit_A8831_HasDiffs
		{
			get
			{
				short num = (short)1377741007;
				short num2 = num;
				num = (short)1450617039;
				switch (num2 == num)
				{
				}
				num = (short)1441857536;
				short num3 = num;
				num = (short)785580033;
				if (num != 0)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRadioInhibit_A8831._HasDiffs;
			}
		}

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x00ACC27C File Offset: 0x00ACA47C
		// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x00ACC330 File Offset: 0x00ACA530
		public int CnvSysFeaturesRemoteRadioMode_A8935Value
		{
			get
			{
				short num = (short)1632498398;
				short num2 = num;
				num = (short)1390801630;
				switch (num2 == num)
				{
				}
				num = (short)1631518720;
				short num3 = num;
				num = (short)1029701632;
				if (num != 0)
				{
				}
				num = (short)1250885633;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRemoteRadioMode_A8935.Value;
			}
			set
			{
				short num = (short)801540199;
				short num2 = num;
				num = (short)835946599;
				switch (num2 == num)
				{
				}
				num = (short)2003894272;
				short num3 = num;
				num = (short)751108096;
				if (num != 0)
				{
				}
				num = (short)302972929;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesRemoteRadioMode_A8935.Value = value;
			}
		}

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x00ACC3EC File Offset: 0x00ACA5EC
		// (set) Token: 0x0600BA3B RID: 47675 RVA: 0x00ACC4A0 File Offset: 0x00ACA6A0
		public string CnvSysFeaturesRemoteRadioMode_A8935_UIValue
		{
			get
			{
				short num = (short)976833469;
				short num2 = num;
				num = (short)1670728637;
				switch (num2 == num)
				{
				}
				num = (short)1939275776;
				short num3 = num;
				num = (short)1107689473;
				if (num != 0)
				{
				}
				num = (short)760086528;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesRemoteRadioMode_A8935.UIValue;
			}
			set
			{
				short num = (short)214531665;
				short num2 = num;
				num = (short)1390706257;
				switch (num2 == num)
				{
				}
				num = (short)895680513;
				if (num != 0)
				{
				}
				num = (short)98041856;
				if (num != 0)
				{
				}
				num = (short)821886976;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.UIValue = value;
			}
		}

		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x00ACC558 File Offset: 0x00ACA758
		public global::AcpBusinessLayer.AcpListField CnvSysFeaturesRemoteRadioMode_A8935
		{
			get
			{
				short num = (short)1607775043;
				short num2 = num;
				num = (short)1024897859;
				switch (num2 == num)
				{
				}
				num = (short)1712455681;
				if (num != 0)
				{
				}
				num = (short)985792512;
				if (num != 0)
				{
				}
				num = (short)1557331968;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935;
			}
		}

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x00ACC608 File Offset: 0x00ACA808
		// (set) Token: 0x0600BA3E RID: 47678 RVA: 0x00ACC6C0 File Offset: 0x00ACA8C0
		public bool CnvSysFeaturesRemoteRadioMode_A8935_Applicable
		{
			get
			{
				short num = (short)2072177832;
				short num2 = num;
				num = (short)1809706152;
				switch (num2 == num)
				{
				}
				num = (short)345964545;
				if (num != 0)
				{
				}
				num = (short)2039152640;
				if (num != 0)
				{
				}
				num = (short)1444151296;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.Applicable;
			}
			set
			{
				short num = (short)592291737;
				short num2 = num;
				num = (short)1993844633;
				switch (num2 == num)
				{
				}
				num = (short)501088257;
				if (num != 0)
				{
				}
				num = (short)156434432;
				if (num != 0)
				{
				}
				num = (short)325124096;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.Applicable = value;
			}
		}

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x00ACC774 File Offset: 0x00ACA974
		// (set) Token: 0x0600BA40 RID: 47680 RVA: 0x00ACC828 File Offset: 0x00ACAA28
		public bool CnvSysFeaturesRemoteRadioMode_A8935_Valid
		{
			get
			{
				short num = (short)605209126;
				short num2 = num;
				num = (short)1600111142;
				switch (num2 == num)
				{
				}
				num = (short)129105921;
				if (num != 0)
				{
				}
				num = (short)404422656;
				if (num != 0)
				{
				}
				num = (short)1336541184;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.Valid;
			}
			set
			{
				short num = (short)1404675240;
				short num2 = num;
				num = (short)1235854504;
				switch (num2 == num)
				{
				}
				num = (short)154140673;
				if (num != 0)
				{
				}
				num = (short)1975713792;
				if (num != 0)
				{
				}
				num = (short)1904738304;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.Valid = value;
			}
		}

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x0600BA41 RID: 47681 RVA: 0x00ACC8DC File Offset: 0x00ACAADC
		// (set) Token: 0x0600BA42 RID: 47682 RVA: 0x00ACC990 File Offset: 0x00ACAB90
		public bool CnvSysFeaturesRemoteRadioMode_A8935_Visible
		{
			get
			{
				short num = (short)509476865;
				if (num != 0)
				{
				}
				num = (short)135331203;
				short num2 = num;
				num = (short)1201536387;
				switch (num2 == num)
				{
				}
				num = (short)1583349760;
				if (num != 0)
				{
				}
				num = (short)609878016;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.Visible;
			}
			set
			{
				short num = (short)1506851050;
				short num2 = num;
				num = (short)128694506;
				switch (num2 == num)
				{
				}
				num = (short)1028849665;
				if (num != 0)
				{
				}
				num = (short)490668032;
				if (num != 0)
				{
				}
				num = (short)1900478464;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.Visible = value;
			}
		}

		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x00ACCA48 File Offset: 0x00ACAC48
		// (set) Token: 0x0600BA44 RID: 47684 RVA: 0x00ACCB00 File Offset: 0x00ACAD00
		public bool CnvSysFeaturesRemoteRadioMode_A8935_Editable
		{
			get
			{
				short num = (short)673659742;
				short num2 = num;
				num = (short)1538603870;
				switch (num2 == num)
				{
				}
				num = (short)523173888;
				if (num != 0)
				{
				}
				num = (short)1650065409;
				if (num != 0)
				{
				}
				num = (short)1318256640;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.Editable;
			}
			set
			{
				short num = (short)814640933;
				short num2 = num;
				num = (short)1813802789;
				switch (num2 == num)
				{
				}
				num = (short)1878786049;
				if (num != 0)
				{
				}
				num = (short)697368576;
				if (num != 0)
				{
				}
				num = (short)511115264;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.Editable = value;
			}
		}

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x00ACCBB4 File Offset: 0x00ACADB4
		internal string CnvSysFeaturesRemoteRadioMode_A8935_UILabel
		{
			get
			{
				short num = (short)922161532;
				short num2 = num;
				num = (short)1049039228;
				switch (num2 == num)
				{
				}
				num = (short)1196687360;
				if (num != 0)
				{
				}
				num = (short)940769281;
				if (num != 0)
				{
				}
				num = (short)119341056;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.UIName;
			}
		}

		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x00ACCC6C File Offset: 0x00ACAE6C
		// (set) Token: 0x0600BA47 RID: 47687 RVA: 0x00ACCD24 File Offset: 0x00ACAF24
		internal bool CnvSysFeaturesRemoteRadioMode_A8935_HiddenStatic
		{
			get
			{
				short num = (short)280782655;
				short num2 = num;
				num = (short)1647470399;
				switch (num2 == num)
				{
				}
				num = (short)1125056513;
				if (num != 0)
				{
				}
				num = (short)2116747264;
				if (num != 0)
				{
				}
				num = (short)1991245824;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.HiddenStatic;
			}
			set
			{
				short num = (short)2051840328;
				short num2 = num;
				num = (short)1295227208;
				switch (num2 == num)
				{
				}
				num = (short)2045706241;
				if (num != 0)
				{
				}
				num = (short)1754857472;
				if (num != 0)
				{
				}
				num = (short)140771328;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.HiddenStatic = value;
			}
		}

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x0600BA48 RID: 47688 RVA: 0x00ACCDDC File Offset: 0x00ACAFDC
		// (set) Token: 0x0600BA49 RID: 47689 RVA: 0x00ACCE94 File Offset: 0x00ACB094
		internal bool CnvSysFeaturesRemoteRadioMode_A8935_HiddenDynamic
		{
			get
			{
				short num = (short)654475914;
				short num2 = num;
				num = (short)1778156170;
				switch (num2 == num)
				{
				}
				num = (short)1663041537;
				if (num != 0)
				{
				}
				num = (short)1178075136;
				if (num != 0)
				{
				}
				num = (short)781254656;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935.HiddenDynamic;
			}
			set
			{
				short num = (short)75628545;
				if (num != 0)
				{
				}
				num = (short)1508276635;
				short num2 = num;
				num = (short)1970174363;
				switch (num2 == num)
				{
				}
				num = (short)1800208384;
				if (num != 0)
				{
				}
				num = (short)594673664;
				short num3 = num;
				this.cnvSysFeaturesRemoteRadioMode_A8935.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x00ACCF48 File Offset: 0x00ACB148
		public bool CnvSysFeaturesRemoteRadioMode_A8935_HasDiffs
		{
			get
			{
				short num = (short)387691417;
				short num2 = num;
				num = (short)107262873;
				switch (num2 == num)
				{
				}
				num = (short)458424321;
				if (num != 0)
				{
				}
				num = (short)468123648;
				if (num != 0)
				{
				}
				num = (short)1972830208;
				short num3 = num;
				return this.cnvSysFeaturesRemoteRadioMode_A8935._HasDiffs;
			}
		}

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x0600BA4B RID: 47691 RVA: 0x00ACCFFC File Offset: 0x00ACB1FC
		// (set) Token: 0x0600BA4C RID: 47692 RVA: 0x00ACD0B0 File Offset: 0x00ACB2B0
		public int CnvSysFeaturesSelectCallInCallReset_A9102Value
		{
			get
			{
				short num = (short)1742874886;
				short num2 = num;
				num = (short)2115447046;
				switch (num2 == num)
				{
				}
				num = (short)1922170881;
				if (num != 0)
				{
				}
				num = (short)1939865600;
				if (num != 0)
				{
				}
				num = (short)965804032;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.Value;
			}
			set
			{
				short num = (short)422467631;
				short num2 = num;
				num = (short)903764015;
				switch (num2 == num)
				{
				}
				num = (short)31981569;
				if (num != 0)
				{
				}
				num = (short)136052736;
				if (num != 0)
				{
				}
				num = (short)769916928;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.Value = value;
			}
		}

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0600BA4D RID: 47693 RVA: 0x00ACD168 File Offset: 0x00ACB368
		// (set) Token: 0x0600BA4E RID: 47694 RVA: 0x00ACD21C File Offset: 0x00ACB41C
		public string CnvSysFeaturesSelectCallInCallReset_A9102_UIValue
		{
			get
			{
				short num = (short)1878021934;
				short num2 = num;
				num = (short)1501845294;
				switch (num2 == num)
				{
				}
				num = (short)1888485377;
				if (num != 0)
				{
				}
				num = (short)405340160;
				if (num != 0)
				{
				}
				num = (short)1542062080;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.UIValue;
			}
			set
			{
				short num = (short)1147634696;
				short num2 = num;
				num = (short)627541000;
				switch (num2 == num)
				{
				}
				num = (short)1995964417;
				if (num != 0)
				{
				}
				num = (short)1542651904;
				if (num != 0)
				{
				}
				num = (short)717357056;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.UIValue = value;
			}
		}

		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0600BA4F RID: 47695 RVA: 0x00ACD2D4 File Offset: 0x00ACB4D4
		public global::AcpBusinessLayer.AcpListField CnvSysFeaturesSelectCallInCallReset_A9102
		{
			get
			{
				short num = (short)811601394;
				short num2 = num;
				num = (short)1823346162;
				switch (num2 == num)
				{
				}
				num = (short)550567936;
				if (num != 0)
				{
				}
				num = (short)1974534145;
				if (num != 0)
				{
				}
				num = (short)928251904;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102;
			}
		}

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x00ACD388 File Offset: 0x00ACB588
		// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x00ACD43C File Offset: 0x00ACB63C
		public bool CnvSysFeaturesSelectCallInCallReset_A9102_Applicable
		{
			get
			{
				short num = (short)148530925;
				short num2 = num;
				num = (short)122578669;
				switch (num2 == num)
				{
				}
				num = (short)1992294401;
				if (num != 0)
				{
				}
				num = (short)805568512;
				if (num != 0)
				{
				}
				num = (short)979107840;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.Applicable;
			}
			set
			{
				short num = (short)829045274;
				short num2 = num;
				num = (short)1898920474;
				switch (num2 == num)
				{
				}
				num = (short)791019521;
				if (num != 0)
				{
				}
				num = (short)10682368;
				if (num != 0)
				{
				}
				num = (short)431226880;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.Applicable = value;
			}
		}

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x00ACD4F4 File Offset: 0x00ACB6F4
		// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x00ACD5A8 File Offset: 0x00ACB7A8
		public bool CnvSysFeaturesSelectCallInCallReset_A9102_Valid
		{
			get
			{
				short num = (short)413799219;
				short num2 = num;
				num = (short)1448219443;
				switch (num2 == num)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				num = (short)861339648;
				if (num != 0)
				{
				}
				num = (short)1752367104;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.Valid;
			}
			set
			{
				short num = (short)266993665;
				if (num != 0)
				{
				}
				num = (short)267294507;
				short num2 = num;
				num = (short)405509931;
				switch (num2 == num)
				{
				}
				num = (short)1521352704;
				if (num != 0)
				{
				}
				num = (short)1638268928;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.Valid = value;
			}
		}

		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x00ACD65C File Offset: 0x00ACB85C
		// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x00ACD710 File Offset: 0x00ACB910
		public bool CnvSysFeaturesSelectCallInCallReset_A9102_Visible
		{
			get
			{
				short num = (short)592630987;
				short num2 = num;
				num = (short)918017227;
				switch (num2 == num)
				{
				}
				num = (short)403570689;
				if (num != 0)
				{
				}
				num = (short)215941120;
				if (num != 0)
				{
				}
				num = (short)1847459840;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.Visible;
			}
			set
			{
				short num = (short)767862480;
				short num2 = num;
				num = (short)1791796944;
				switch (num2 == num)
				{
				}
				num = (short)1174208513;
				if (num != 0)
				{
				}
				num = (short)763232256;
				if (num != 0)
				{
				}
				num = (short)244121600;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.Visible = value;
			}
		}

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x00ACD7C8 File Offset: 0x00ACB9C8
		// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x00ACD880 File Offset: 0x00ACBA80
		public bool CnvSysFeaturesSelectCallInCallReset_A9102_Editable
		{
			get
			{
				short num = (short)1596495945;
				short num2 = num;
				num = (short)1430886473;
				switch (num2 == num)
				{
				}
				num = (short)764674049;
				if (num != 0)
				{
				}
				num = (short)1180499968;
				if (num != 0)
				{
				}
				num = (short)636551168;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.Editable;
			}
			set
			{
				short num = (short)1163002996;
				short num2 = num;
				num = (short)936969332;
				switch (num2 == num)
				{
				}
				num = (short)57147393;
				if (num != 0)
				{
				}
				num = (short)1657208832;
				if (num != 0)
				{
				}
				num = (short)952041472;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.Editable = value;
			}
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x0600BA58 RID: 47704 RVA: 0x00ACD934 File Offset: 0x00ACBB34
		internal string CnvSysFeaturesSelectCallInCallReset_A9102_UILabel
		{
			get
			{
				short num = (short)974707648;
				short num2 = num;
				num = (short)666229696;
				switch (num2 == num)
				{
				}
				num = (short)1557725185;
				if (num != 0)
				{
				}
				num = (short)591396864;
				if (num != 0)
				{
				}
				num = (short)1777532928;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.UIName;
			}
		}

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x00ACD9E8 File Offset: 0x00ACBBE8
		// (set) Token: 0x0600BA5A RID: 47706 RVA: 0x00ACDAA0 File Offset: 0x00ACBCA0
		internal bool CnvSysFeaturesSelectCallInCallReset_A9102_HiddenStatic
		{
			get
			{
				short num = (short)2001460911;
				short num2 = num;
				num = (short)659676847;
				switch (num2 == num)
				{
				}
				num = (short)249233409;
				if (num != 0)
				{
				}
				num = (short)135725056;
				if (num != 0)
				{
				}
				num = (short)396230656;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.HiddenStatic;
			}
			set
			{
				short num = (short)462273248;
				short num2 = num;
				num = (short)1056488160;
				switch (num2 == num)
				{
				}
				num = (short)1682178049;
				if (num != 0)
				{
				}
				num = (short)371654656;
				if (num != 0)
				{
				}
				num = (short)1178075136;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.HiddenStatic = value;
			}
		}

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x0600BA5B RID: 47707 RVA: 0x00ACDB58 File Offset: 0x00ACBD58
		// (set) Token: 0x0600BA5C RID: 47708 RVA: 0x00ACDC10 File Offset: 0x00ACBE10
		internal bool CnvSysFeaturesSelectCallInCallReset_A9102_HiddenDynamic
		{
			get
			{
				short num = (short)821882679;
				short num2 = num;
				num = (short)284290871;
				switch (num2 == num)
				{
				}
				num = (short)1033502721;
				if (num != 0)
				{
				}
				num = (short)1628504064;
				if (num != 0)
				{
				}
				num = (short)2046361600;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102.HiddenDynamic;
			}
			set
			{
				short num = (short)1777302249;
				short num2 = num;
				num = (short)536115945;
				switch (num2 == num)
				{
				}
				num = (short)1117388801;
				if (num != 0)
				{
				}
				num = (short)1685585920;
				if (num != 0)
				{
				}
				num = (short)1539833856;
				short num3 = num;
				this.cnvSysFeaturesSelectCallInCallReset_A9102.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x0600BA5D RID: 47709 RVA: 0x00ACDCCC File Offset: 0x00ACBECC
		public bool CnvSysFeaturesSelectCallInCallReset_A9102_HasDiffs
		{
			get
			{
				short num = (short)1659976064;
				short num2 = num;
				num = (short)797063552;
				switch (num2 == num)
				{
				}
				num = (short)1454899200;
				if (num != 0)
				{
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				num = (short)1887240192;
				short num3 = num;
				return this.cnvSysFeaturesSelectCallInCallReset_A9102._HasDiffs;
			}
		}

		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x00ACDD84 File Offset: 0x00ACBF84
		// (set) Token: 0x0600BA5F RID: 47711 RVA: 0x00ACDE38 File Offset: 0x00ACC038
		public bool CnvSysFeaturesStatus_A9186Value
		{
			get
			{
				short num = (short)898837220;
				short num2 = num;
				num = (short)1795762916;
				switch (num2 == num)
				{
				}
				num = (short)1969225728;
				if (num != 0)
				{
				}
				num = (short)332464129;
				if (num != 0)
				{
				}
				num = (short)413335552;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Value;
			}
			set
			{
				short num = (short)937433209;
				short num2 = num;
				num = (short)2141001849;
				switch (num2 == num)
				{
				}
				num = (short)1523384320;
				if (num != 0)
				{
				}
				num = (short)1612382209;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Value = value;
			}
		}

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x00ACDEEC File Offset: 0x00ACC0EC
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesStatus_A9186
		{
			get
			{
				short num = (short)1940950730;
				short num2 = num;
				num = (short)710905546;
				switch (num2 == num)
				{
				}
				num = (short)1013907456;
				if (num != 0)
				{
				}
				num = (short)592576513;
				if (num != 0)
				{
				}
				num = (short)554369024;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186;
			}
		}

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x0600BA61 RID: 47713 RVA: 0x00ACDF9C File Offset: 0x00ACC19C
		// (set) Token: 0x0600BA62 RID: 47714 RVA: 0x00ACE050 File Offset: 0x00ACC250
		public bool CnvSysFeaturesStatus_A9186_UIValue
		{
			get
			{
				short num = (short)1579151749;
				short num2 = num;
				num = (short)520483205;
				switch (num2 == num)
				{
				}
				num = (short)1351155713;
				if (num != 0)
				{
				}
				num = (short)2108817408;
				if (num != 0)
				{
				}
				num = (short)912195584;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Value;
			}
			set
			{
				short num = (short)515844021;
				short num2 = num;
				num = (short)1747330997;
				switch (num2 == num)
				{
				}
				num = (short)1392771073;
				if (num != 0)
				{
				}
				num = (short)660340736;
				if (num != 0)
				{
				}
				num = (short)1773797376;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Value = value;
			}
		}

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x0600BA63 RID: 47715 RVA: 0x00ACE108 File Offset: 0x00ACC308
		// (set) Token: 0x0600BA64 RID: 47716 RVA: 0x00ACE1BC File Offset: 0x00ACC3BC
		public bool CnvSysFeaturesStatus_A9186_Applicable
		{
			get
			{
				short num = (short)311327420;
				short num2 = num;
				num = (short)220035772;
				switch (num2 == num)
				{
				}
				num = (short)1595867137;
				if (num != 0)
				{
				}
				num = (short)1068826624;
				if (num != 0)
				{
				}
				num = (short)214630400;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Applicable;
			}
			set
			{
				short num = (short)290908131;
				short num2 = num;
				num = (short)388425699;
				switch (num2 == num)
				{
				}
				num = (short)1355087872;
				if (num != 0)
				{
				}
				num = (short)1640562689;
				if (num != 0)
				{
				}
				num = (short)742653952;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Applicable = value;
			}
		}

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x0600BA65 RID: 47717 RVA: 0x00ACE274 File Offset: 0x00ACC474
		// (set) Token: 0x0600BA66 RID: 47718 RVA: 0x00ACE328 File Offset: 0x00ACC528
		public bool CnvSysFeaturesStatus_A9186_Valid
		{
			get
			{
				short num = (short)1709006407;
				short num2 = num;
				num = (short)292380231;
				switch (num2 == num)
				{
				}
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)1037238272;
				if (num != 0)
				{
				}
				num = (short)641138688;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Valid;
			}
			set
			{
				short num = (short)204613908;
				short num2 = num;
				num = (short)1039411476;
				switch (num2 == num)
				{
				}
				num = (short)1634664449;
				if (num != 0)
				{
				}
				num = (short)1623326720;
				if (num != 0)
				{
				}
				num = (short)45481984;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Valid = value;
			}
		}

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x0600BA67 RID: 47719 RVA: 0x00ACE3E0 File Offset: 0x00ACC5E0
		// (set) Token: 0x0600BA68 RID: 47720 RVA: 0x00ACE494 File Offset: 0x00ACC694
		public bool CnvSysFeaturesStatus_A9186_Visible
		{
			get
			{
				short num = (short)1248432039;
				short num2 = num;
				num = (short)1533841319;
				switch (num2 == num)
				{
				}
				num = (short)1154088961;
				if (num != 0)
				{
				}
				num = (short)1157824512;
				if (num != 0)
				{
				}
				num = (short)53542912;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Visible;
			}
			set
			{
				short num = (short)1151288689;
				short num2 = num;
				num = (short)364594545;
				switch (num2 == num)
				{
				}
				num = (short)246284289;
				if (num != 0)
				{
				}
				num = (short)1546387456;
				if (num != 0)
				{
				}
				num = (short)303104000;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Visible = value;
			}
		}

		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x0600BA69 RID: 47721 RVA: 0x00ACE548 File Offset: 0x00ACC748
		// (set) Token: 0x0600BA6A RID: 47722 RVA: 0x00ACE600 File Offset: 0x00ACC800
		public bool CnvSysFeaturesStatus_A9186_Editable
		{
			get
			{
				short num = (short)894107649;
				if (num != 0)
				{
				}
				num = (short)1663620186;
				short num2 = num;
				num = (short)552391770;
				switch (num2 == num)
				{
				}
				num = (short)395116544;
				if (num != 0)
				{
				}
				num = (short)2088960000;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.Editable;
			}
			set
			{
				short num = (short)1103693002;
				short num2 = num;
				num = (short)1754662090;
				switch (num2 == num)
				{
				}
				num = (short)327221249;
				if (num != 0)
				{
				}
				num = (short)1018888192;
				if (num != 0)
				{
				}
				num = (short)1564540928;
				short num3 = num;
				this.cnvSysFeaturesStatus_A9186.Editable = value;
			}
		}

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x0600BA6B RID: 47723 RVA: 0x00ACE6B4 File Offset: 0x00ACC8B4
		internal string CnvSysFeaturesStatus_A9186_UILabel
		{
			get
			{
				short num = (short)1846390455;
				short num2 = num;
				num = (short)1211805367;
				switch (num2 == num)
				{
				}
				num = (short)507052033;
				if (num != 0)
				{
				}
				num = (short)704512000;
				if (num != 0)
				{
				}
				num = (short)1053032448;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.UIName;
			}
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x00ACE768 File Offset: 0x00ACC968
		// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x00ACE81C File Offset: 0x00ACCA1C
		internal bool CnvSysFeaturesStatus_A9186_HiddenStatic
		{
			get
			{
				short num = (short)665583617;
				if (num != 0)
				{
				}
				num = (short)1514821441;
				short num2 = num;
				num = (short)1485592385;
				switch (num2 == num)
				{
				}
				num = (short)676134912;
				if (num != 0)
				{
				}
				num = (short)456392704;
				short num3 = num;
				return this.cnvSysFeaturesStatus_A9186.HiddenStatic;
			}
			set
			{
				short num = (short)1894156946;
				short num2 = num;
				num = (short)229739154;
				switch (num2 == num)
				{
				}
				num = (short)735707136;
				if (num != 0)
				{
				}
				num = (short)827719680;
				short num3 = num;
				num = (short)1990983681;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatus_A9186.HiddenStatic = value;
			}
		}

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x00ACE8D4 File Offset: 0x00ACCAD4
		// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x00ACE98C File Offset: 0x00ACCB8C
		internal bool CnvSysFeaturesStatus_A9186_HiddenDynamic
		{
			get
			{
				short num = (short)1382305951;
				short num2 = num;
				num = (short)1963151519;
				switch (num2 == num)
				{
				}
				num = (short)1223032833;
				if (num != 0)
				{
				}
				num = (short)1795817472;
				short num3 = num;
				num = (short)637009920;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatus_A9186.HiddenDynamic;
			}
			set
			{
				short num = (short)154835887;
				short num2 = num;
				num = (short)1437178799;
				switch (num2 == num)
				{
				}
				num = (short)1005715457;
				if (num != 0)
				{
				}
				num = (short)1188036608;
				short num3 = num;
				num = (short)1163132928;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatus_A9186.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x00ACEA40 File Offset: 0x00ACCC40
		public bool CnvSysFeaturesStatus_A9186_HasDiffs
		{
			get
			{
				short num = (short)1293354079;
				short num2 = num;
				num = (short)1797194847;
				switch (num2 == num)
				{
				}
				num = (short)1507852289;
				if (num != 0)
				{
				}
				num = (short)700514304;
				short num3 = num;
				num = (short)842072064;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatus_A9186._HasDiffs;
			}
		}

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x00ACEAF4 File Offset: 0x00ACCCF4
		// (set) Token: 0x0600BA72 RID: 47730 RVA: 0x00ACEBA8 File Offset: 0x00ACCDA8
		public bool CnvSysFeaturesStatusRequest_A9198Value
		{
			get
			{
				short num = (short)1208565195;
				short num2 = num;
				num = (short)234896843;
				switch (num2 == num)
				{
				}
				num = (short)1102577665;
				if (num != 0)
				{
				}
				num = (short)531628032;
				short num3 = num;
				num = (short)25165824;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Value;
			}
			set
			{
				short num = (short)829489153;
				if (num != 0)
				{
				}
				num = (short)1623594851;
				short num2 = num;
				num = (short)1083709283;
				switch (num2 == num)
				{
				}
				num = (short)1829765120;
				short num3 = num;
				num = (short)1940652032;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Value = value;
			}
		}

		// Token: 0x17005D62 RID: 23906
		// (get) Token: 0x0600BA73 RID: 47731 RVA: 0x00ACEC5C File Offset: 0x00ACCE5C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesStatusRequest_A9198
		{
			get
			{
				short num = (short)1371109672;
				short num2 = num;
				num = (short)39942440;
				switch (num2 == num)
				{
				}
				num = (short)2040659969;
				if (num != 0)
				{
				}
				num = (short)1151795200;
				short num3 = num;
				num = (short)1422065664;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198;
			}
		}

		// Token: 0x17005D63 RID: 23907
		// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x00ACED0C File Offset: 0x00ACCF0C
		// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x00ACEDC4 File Offset: 0x00ACCFC4
		public bool CnvSysFeaturesStatusRequest_A9198_UIValue
		{
			get
			{
				short num = (short)924516353;
				if (num != 0)
				{
				}
				num = (short)300407157;
				short num2 = num;
				num = (short)1948637557;
				switch (num2 == num)
				{
				}
				num = (short)537133056;
				short num3 = num;
				num = (short)1416364032;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Value;
			}
			set
			{
				short num = (short)1271140462;
				short num2 = num;
				num = (short)324997230;
				switch (num2 == num)
				{
				}
				num = (short)856686593;
				if (num != 0)
				{
				}
				num = (short)1841364992;
				short num3 = num;
				num = (short)1248591872;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Value = value;
			}
		}

		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x00ACEE78 File Offset: 0x00ACD078
		// (set) Token: 0x0600BA77 RID: 47735 RVA: 0x00ACEF2C File Offset: 0x00ACD12C
		public bool CnvSysFeaturesStatusRequest_A9198_Applicable
		{
			get
			{
				short num = (short)1033109505;
				if (num != 0)
				{
				}
				num = (short)1632496986;
				short num2 = num;
				num = (short)1187507546;
				switch (num2 == num)
				{
				}
				num = (short)712179712;
				short num3 = num;
				num = (short)1484324864;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Applicable;
			}
			set
			{
				short num = (short)441384407;
				short num2 = num;
				num = (short)2067070423;
				switch (num2 == num)
				{
				}
				num = (short)1210449920;
				if (num != 0)
				{
				}
				num = (short)1163001856;
				short num3 = num;
				num = (short)535953409;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Applicable = value;
			}
		}

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x00ACEFE0 File Offset: 0x00ACD1E0
		// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x00ACF098 File Offset: 0x00ACD298
		public bool CnvSysFeaturesStatusRequest_A9198_Valid
		{
			get
			{
				short num = (short)406086970;
				short num2 = num;
				num = (short)1766679866;
				switch (num2 == num)
				{
				}
				num = (short)13697025;
				if (num != 0)
				{
				}
				num = (short)743964672;
				short num3 = num;
				num = (short)842727424;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Valid;
			}
			set
			{
				short num = (short)467645557;
				short num2 = num;
				num = (short)1628353653;
				switch (num2 == num)
				{
				}
				num = (short)2122448897;
				if (num != 0)
				{
				}
				num = (short)2073034752;
				short num3 = num;
				num = (short)249888768;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Valid = value;
			}
		}

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x00ACF14C File Offset: 0x00ACD34C
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x00ACF200 File Offset: 0x00ACD400
		public bool CnvSysFeaturesStatusRequest_A9198_Visible
		{
			get
			{
				short num = (short)341008285;
				short num2 = num;
				num = (short)1166368669;
				switch (num2 == num)
				{
				}
				num = (short)1997668353;
				if (num != 0)
				{
				}
				num = (short)1282998272;
				short num3 = num;
				num = (short)998703104;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Visible;
			}
			set
			{
				short num = (short)1546518529;
				if (num != 0)
				{
				}
				num = (short)1477611637;
				short num2 = num;
				num = (short)501452917;
				switch (num2 == num)
				{
				}
				num = (short)2103508992;
				short num3 = num;
				num = (short)2040004608;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Visible = value;
			}
		}

		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x00ACF2B8 File Offset: 0x00ACD4B8
		// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x00ACF36C File Offset: 0x00ACD56C
		public bool CnvSysFeaturesStatusRequest_A9198_Editable
		{
			get
			{
				short num = (short)210785947;
				short num2 = num;
				num = (short)855266971;
				switch (num2 == num)
				{
				}
				num = (short)1450442753;
				if (num != 0)
				{
				}
				num = (short)184811520;
				short num3 = num;
				num = (short)561053696;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.Editable;
			}
			set
			{
				short num = (short)482637831;
				short num2 = num;
				num = (short)1879209991;
				switch (num2 == num)
				{
				}
				num = (short)637140992;
				if (num != 0)
				{
				}
				num = (short)807337984;
				short num3 = num;
				num = (short)1867579393;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.Editable = value;
			}
		}

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x00ACF424 File Offset: 0x00ACD624
		internal string CnvSysFeaturesStatusRequest_A9198_UILabel
		{
			get
			{
				short num = (short)315104863;
				short num2 = num;
				num = (short)2004098655;
				switch (num2 == num)
				{
				}
				num = (short)898891776;
				if (num != 0)
				{
				}
				num = (short)318767104;
				short num3 = num;
				num = (short)1227358209;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.UIName;
			}
		}

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x0600BA7F RID: 47743 RVA: 0x00ACF4D8 File Offset: 0x00ACD6D8
		// (set) Token: 0x0600BA80 RID: 47744 RVA: 0x00ACF590 File Offset: 0x00ACD790
		internal bool CnvSysFeaturesStatusRequest_A9198_HiddenStatic
		{
			get
			{
				short num = (short)1061112074;
				short num2 = num;
				num = (short)1109215498;
				switch (num2 == num)
				{
				}
				num = (short)684720128;
				if (num != 0)
				{
				}
				num = (short)762773504;
				short num3 = num;
				num = (short)2063663105;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.HiddenStatic;
			}
			set
			{
				short num = (short)2041708545;
				if (num != 0)
				{
				}
				num = (short)913985206;
				short num2 = num;
				num = (short)1937395382;
				switch (num2 == num)
				{
				}
				num = (short)1725497344;
				short num3 = num;
				num = (short)223215616;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.HiddenStatic = value;
			}
		}

		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x0600BA81 RID: 47745 RVA: 0x00ACF644 File Offset: 0x00ACD844
		// (set) Token: 0x0600BA82 RID: 47746 RVA: 0x00ACF6F8 File Offset: 0x00ACD8F8
		internal bool CnvSysFeaturesStatusRequest_A9198_HiddenDynamic
		{
			get
			{
				short num = (short)2080676639;
				short num2 = num;
				num = (short)687971103;
				switch (num2 == num)
				{
				}
				num = (short)461832193;
				if (num != 0)
				{
				}
				num = (short)1610088448;
				short num3 = num;
				num = (short)35782656;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198.HiddenDynamic;
			}
			set
			{
				short num = (short)1133746747;
				short num2 = num;
				num = (short)203135547;
				switch (num2 == num)
				{
				}
				num = (short)1250689025;
				if (num != 0)
				{
				}
				num = (short)39780352;
				short num3 = num;
				num = (short)581107712;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesStatusRequest_A9198.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x0600BA83 RID: 47747 RVA: 0x00ACF7B0 File Offset: 0x00ACD9B0
		public bool CnvSysFeaturesStatusRequest_A9198_HasDiffs
		{
			get
			{
				short num = (short)1807967914;
				short num2 = num;
				num = (short)860972714;
				switch (num2 == num)
				{
				}
				num = (short)48431104;
				if (num != 0)
				{
				}
				num = (short)683147264;
				short num3 = num;
				num = (short)1865744385;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesStatusRequest_A9198._HasDiffs;
			}
		}

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x0600BA84 RID: 47748 RVA: 0x00ACF868 File Offset: 0x00ACDA68
		// (set) Token: 0x0600BA85 RID: 47749 RVA: 0x00ACF91C File Offset: 0x00ACDB1C
		public int DataProfFeaturesTextMessagingService_A9372Value
		{
			get
			{
				short num = (short)314441729;
				if (num != 0)
				{
				}
				num = (short)47067001;
				short num2 = num;
				num = (short)547630969;
				switch (num2 == num)
				{
				}
				num = (short)672923648;
				short num3 = num;
				num = (short)317521920;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.Value;
			}
			set
			{
				short num = (short)931203403;
				short num2 = num;
				num = (short)952305995;
				switch (num2 == num)
				{
				}
				num = (short)745472000;
				if (num != 0)
				{
				}
				num = (short)4980736;
				short num3 = num;
				num = (short)1843462145;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.Value = value;
			}
		}

		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x00ACF9D0 File Offset: 0x00ACDBD0
		// (set) Token: 0x0600BA87 RID: 47751 RVA: 0x00ACFA84 File Offset: 0x00ACDC84
		public string DataProfFeaturesTextMessagingService_A9372_UIValue
		{
			get
			{
				short num = (short)802684929;
				if (num != 0)
				{
				}
				num = (short)1029449230;
				short num2 = num;
				num = (short)314123790;
				switch (num2 == num)
				{
				}
				num = (short)1461387264;
				short num3 = num;
				num = (short)1527054336;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.UIValue;
			}
			set
			{
				short num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)731908262;
				short num2 = num;
				num = (short)1424361638;
				switch (num2 == num)
				{
				}
				num = (short)846331904;
				short num3 = num;
				num = (short)1346174976;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.UIValue = value;
			}
		}

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x00ACFB3C File Offset: 0x00ACDD3C
		public global::AcpBusinessLayer.AcpListField DataProfFeaturesTextMessagingService_A9372
		{
			get
			{
				short num = (short)386601222;
				short num2 = num;
				num = (short)1646399750;
				switch (num2 == num)
				{
				}
				num = (short)1037041664;
				if (num != 0)
				{
				}
				num = (short)975634432;
				short num3 = num;
				num = (short)1827405825;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372;
			}
		}

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x00ACFBF0 File Offset: 0x00ACDDF0
		// (set) Token: 0x0600BA8A RID: 47754 RVA: 0x00ACFCA4 File Offset: 0x00ACDEA4
		public bool DataProfFeaturesTextMessagingService_A9372_Applicable
		{
			get
			{
				short num = (short)1419674507;
				short num2 = num;
				num = (short)502367115;
				switch (num2 == num)
				{
				}
				num = (short)1069678593;
				if (num != 0)
				{
				}
				num = (short)1143865344;
				short num3 = num;
				num = (short)879493120;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.Applicable;
			}
			set
			{
				short num = (short)824725945;
				short num2 = num;
				num = (short)1555124665;
				switch (num2 == num)
				{
				}
				num = (short)76808193;
				if (num != 0)
				{
				}
				num = (short)2058092544;
				short num3 = num;
				num = (short)1585512448;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.Applicable = value;
			}
		}

		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x00ACFD58 File Offset: 0x00ACDF58
		// (set) Token: 0x0600BA8C RID: 47756 RVA: 0x00ACFE0C File Offset: 0x00ACE00C
		public bool DataProfFeaturesTextMessagingService_A9372_Valid
		{
			get
			{
				short num = (short)1537933425;
				short num2 = num;
				num = (short)1903231089;
				switch (num2 == num)
				{
				}
				num = (short)180158465;
				if (num != 0)
				{
				}
				num = (short)1656750080;
				short num3 = num;
				num = (short)1757741056;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.Valid;
			}
			set
			{
				short num = (short)1961927174;
				short num2 = num;
				num = (short)1858511366;
				switch (num2 == num)
				{
				}
				num = (short)1315045376;
				if (num != 0)
				{
				}
				num = (short)546439168;
				short num3 = num;
				num = (short)486211585;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.Valid = value;
			}
		}

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x0600BA8D RID: 47757 RVA: 0x00ACFEC0 File Offset: 0x00ACE0C0
		// (set) Token: 0x0600BA8E RID: 47758 RVA: 0x00ACFF74 File Offset: 0x00ACE174
		public bool DataProfFeaturesTextMessagingService_A9372_Visible
		{
			get
			{
				short num = (short)428075410;
				short num2 = num;
				num = (short)206891410;
				switch (num2 == num)
				{
				}
				num = (short)1841561600;
				if (num != 0)
				{
				}
				num = (short)2228224;
				short num3 = num;
				num = (short)304283649;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.Visible;
			}
			set
			{
				short num = (short)445426995;
				short num2 = num;
				num = (short)208514355;
				switch (num2 == num)
				{
				}
				num = (short)1290993665;
				if (num != 0)
				{
				}
				num = (short)2134179840;
				short num3 = num;
				num = (short)1036845056;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.Visible = value;
			}
		}

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x00AD0028 File Offset: 0x00ACE228
		// (set) Token: 0x0600BA90 RID: 47760 RVA: 0x00AD00E0 File Offset: 0x00ACE2E0
		public bool DataProfFeaturesTextMessagingService_A9372_Editable
		{
			get
			{
				short num = (short)702959918;
				short num2 = num;
				num = (short)426397998;
				switch (num2 == num)
				{
				}
				num = (short)1122238464;
				if (num != 0)
				{
				}
				num = (short)1809645568;
				short num3 = num;
				num = (short)1908867073;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.Editable;
			}
			set
			{
				short num = (short)739741200;
				short num2 = num;
				num = (short)614239760;
				switch (num2 == num)
				{
				}
				num = (short)480968704;
				if (num != 0)
				{
				}
				num = (short)149487616;
				short num3 = num;
				num = (short)686817281;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.Editable = value;
			}
		}

		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x0600BA91 RID: 47761 RVA: 0x00AD0198 File Offset: 0x00ACE398
		internal string DataProfFeaturesTextMessagingService_A9372_UILabel
		{
			get
			{
				short num = (short)1082859313;
				short num2 = num;
				num = (short)1527717681;
				switch (num2 == num)
				{
				}
				num = (short)1004404737;
				if (num != 0)
				{
				}
				num = (short)579731456;
				short num3 = num;
				num = (short)1712324608;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.UIName;
			}
		}

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x00AD024C File Offset: 0x00ACE44C
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x00AD0300 File Offset: 0x00ACE500
		internal bool DataProfFeaturesTextMessagingService_A9372_HiddenStatic
		{
			get
			{
				short num = (short)627567320;
				short num2 = num;
				num = (short)2122640088;
				switch (num2 == num)
				{
				}
				num = (short)416743424;
				if (num != 0)
				{
				}
				num = (short)376766464;
				short num3 = num;
				num = (short)1415905281;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.HiddenStatic;
			}
			set
			{
				short num = (short)1190673694;
				short num2 = num;
				num = (short)757677342;
				switch (num2 == num)
				{
				}
				num = (short)1121976321;
				if (num != 0)
				{
				}
				num = (short)824442880;
				short num3 = num;
				num = (short)501284864;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.HiddenStatic = value;
			}
		}

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x00AD03B4 File Offset: 0x00ACE5B4
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x00AD0468 File Offset: 0x00ACE668
		internal bool DataProfFeaturesTextMessagingService_A9372_HiddenDynamic
		{
			get
			{
				short num = (short)1150886428;
				short num2 = num;
				num = (short)754000412;
				switch (num2 == num)
				{
				}
				num = (short)178585600;
				if (num != 0)
				{
				}
				num = (short)780009472;
				short num3 = num;
				num = (short)1959395329;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372.HiddenDynamic;
			}
			set
			{
				short num = (short)1966584251;
				short num2 = num;
				num = (short)1878897083;
				switch (num2 == num)
				{
				}
				num = (short)1024589825;
				if (num != 0)
				{
				}
				num = (short)116588544;
				short num3 = num;
				num = (short)61145088;
				if (num != 0)
				{
				}
				this.dataProfFeaturesTextMessagingService_A9372.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x00AD0520 File Offset: 0x00ACE720
		public bool DataProfFeaturesTextMessagingService_A9372_HasDiffs
		{
			get
			{
				short num = (short)31342340;
				short num2 = num;
				num = (short)1129266948;
				switch (num2 == num)
				{
				}
				num = (short)119275520;
				if (num != 0)
				{
				}
				num = (short)1542586368;
				short num3 = num;
				num = (short)152371201;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesTextMessagingService_A9372._HasDiffs;
			}
		}

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x00AD05D4 File Offset: 0x00ACE7D4
		// (set) Token: 0x0600BA98 RID: 47768 RVA: 0x00AD0688 File Offset: 0x00ACE888
		public bool CnvSysFeaturesExtendedDispatchEn_A37220Value
		{
			get
			{
				short num = (short)1962245724;
				short num2 = num;
				num = (short)64847452;
				switch (num2 == num)
				{
				}
				num = (short)1413480449;
				if (num != 0)
				{
				}
				num = (short)1085603840;
				short num3 = num;
				num = (short)4587520;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Value;
			}
			set
			{
				short num = (short)1553597483;
				short num2 = num;
				num = (short)1054475307;
				switch (num2 == num)
				{
				}
				num = (short)1130627073;
				if (num != 0)
				{
				}
				num = (short)848625664;
				short num3 = num;
				num = (short)1062141952;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Value = value;
			}
		}

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x0600BA99 RID: 47769 RVA: 0x00AD073C File Offset: 0x00ACE93C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesExtendedDispatchEn_A37220
		{
			get
			{
				short num = (short)1042295261;
				short num2 = num;
				num = (short)2089822685;
				switch (num2 == num)
				{
				}
				num = (short)1127874561;
				if (num != 0)
				{
				}
				num = (short)2043281408;
				short num3 = num;
				num = (short)1261305856;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220;
			}
		}

		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x00AD07E8 File Offset: 0x00ACE9E8
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x00AD089C File Offset: 0x00ACEA9C
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_UIValue
		{
			get
			{
				short num = (short)367596930;
				short num2 = num;
				num = (short)97129858;
				switch (num2 == num)
				{
				}
				num = (short)1489108992;
				if (num != 0)
				{
				}
				num = (short)335151104;
				short num3 = num;
				num = (short)698286081;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Value;
			}
			set
			{
				short num = (short)1122710381;
				short num2 = num;
				num = (short)179123053;
				switch (num2 == num)
				{
				}
				num = (short)798490625;
				if (num != 0)
				{
				}
				num = (short)1861943296;
				short num3 = num;
				num = (short)297074688;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Value = value;
			}
		}

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x0600BA9C RID: 47772 RVA: 0x00AD0950 File Offset: 0x00ACEB50
		// (set) Token: 0x0600BA9D RID: 47773 RVA: 0x00AD0A04 File Offset: 0x00ACEC04
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_Applicable
		{
			get
			{
				short num = (short)2080308905;
				short num2 = num;
				num = (short)244317865;
				switch (num2 == num)
				{
				}
				num = (short)2083389441;
				if (num != 0)
				{
				}
				num = (short)1625554944;
				short num3 = num;
				num = (short)78381056;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Applicable;
			}
			set
			{
				short num = (short)879663262;
				short num2 = num;
				num = (short)1916049566;
				switch (num2 == num)
				{
				}
				num = (short)1839661057;
				if (num != 0)
				{
				}
				num = (short)740622336;
				short num3 = num;
				num = (short)641073152;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Applicable = value;
			}
		}

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x00AD0ABC File Offset: 0x00ACECBC
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x00AD0B74 File Offset: 0x00ACED74
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_Valid
		{
			get
			{
				short num = (short)1613904140;
				short num2 = num;
				num = (short)1211185420;
				switch (num2 == num)
				{
				}
				num = (short)338821121;
				if (num != 0)
				{
				}
				num = (short)660013056;
				short num3 = num;
				num = (short)831193088;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Valid;
			}
			set
			{
				short num = (short)905760106;
				short num2 = num;
				num = (short)150981994;
				switch (num2 == num)
				{
				}
				num = (short)594477057;
				if (num != 0)
				{
				}
				num = (short)878968832;
				short num3 = num;
				num = (short)1430257664;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Valid = value;
			}
		}

		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x00AD0C28 File Offset: 0x00ACEE28
		// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x00AD0CD8 File Offset: 0x00ACEED8
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_Visible
		{
			get
			{
				short num = (short)1415427579;
				short num2 = num;
				num = (short)1040233979;
				switch (num2 == num)
				{
				}
				num = (short)35127297;
				if (num != 0)
				{
				}
				num = (short)1626341376;
				short num3 = num;
				num = (short)1096744960;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Visible;
			}
			set
			{
				short num = (short)771734463;
				short num2 = num;
				num = (short)581483455;
				switch (num2 == num)
				{
				}
				num = (short)1534590976;
				if (num != 0)
				{
				}
				num = (short)906952704;
				short num3 = num;
				num = (short)1796603905;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Visible = value;
			}
		}

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x00AD0D90 File Offset: 0x00ACEF90
		// (set) Token: 0x0600BAA3 RID: 47779 RVA: 0x00AD0E44 File Offset: 0x00ACF044
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_Editable
		{
			get
			{
				short num = (short)822370304;
				short num2 = num;
				num = (short)982081536;
				switch (num2 == num)
				{
				}
				num = (short)451280897;
				if (num != 0)
				{
				}
				num = (short)784007168;
				short num3 = num;
				num = (short)1541996544;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.Editable;
			}
			set
			{
				short num = (short)746896417;
				short num2 = num;
				num = (short)495893537;
				switch (num2 == num)
				{
				}
				num = (short)1237254145;
				if (num != 0)
				{
				}
				num = (short)65011712;
				short num3 = num;
				num = (short)1014890496;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.Editable = value;
			}
		}

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x00AD0EF8 File Offset: 0x00ACF0F8
		internal string CnvSysFeaturesExtendedDispatchEn_A37220_UILabel
		{
			get
			{
				short num = (short)1234956374;
				short num2 = num;
				num = (short)1642131542;
				switch (num2 == num)
				{
				}
				num = (short)1650393088;
				short num3 = num;
				num = (short)202113025;
				if (num != 0)
				{
				}
				num = (short)551288832;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.UIName;
			}
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x00AD0FA8 File Offset: 0x00ACF1A8
		// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x00AD1060 File Offset: 0x00ACF260
		internal bool CnvSysFeaturesExtendedDispatchEn_A37220_HiddenStatic
		{
			get
			{
				short num = (short)1906043381;
				short num2 = num;
				num = (short)671803893;
				switch (num2 == num)
				{
				}
				num = (short)1229586432;
				short num3 = num;
				num = (short)1358823424;
				if (num != 0)
				{
				}
				num = (short)1045037057;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.HiddenStatic;
			}
			set
			{
				short num = (short)1131965493;
				short num2 = num;
				num = (short)729508917;
				switch (num2 == num)
				{
				}
				num = (short)137625600;
				short num3 = num;
				num = (short)1922367489;
				if (num != 0)
				{
				}
				num = (short)640942080;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.HiddenStatic = value;
			}
		}

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x00AD1114 File Offset: 0x00ACF314
		// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x00AD11CC File Offset: 0x00ACF3CC
		internal bool CnvSysFeaturesExtendedDispatchEn_A37220_HiddenDynamic
		{
			get
			{
				short num = (short)608697107;
				short num2 = num;
				num = (short)2043869971;
				switch (num2 == num)
				{
				}
				num = (short)2064187392;
				short num3 = num;
				num = (short)1016397825;
				if (num != 0)
				{
				}
				num = (short)1662910464;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220.HiddenDynamic;
			}
			set
			{
				short num = (short)1365835777;
				if (num != 0)
				{
				}
				num = (short)685840316;
				short num2 = num;
				num = (short)1890588604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783613952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420754944;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesExtendedDispatchEn_A37220.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x0600BAA9 RID: 47785 RVA: 0x00AD1280 File Offset: 0x00ACF480
		public bool CnvSysFeaturesExtendedDispatchEn_A37220_HasDiffs
		{
			get
			{
				short num = (short)566693565;
				short num2 = num;
				num = (short)1954287293;
				switch (num2 == num)
				{
				}
				num = (short)795934720;
				short num3 = num;
				num = (short)1743454208;
				if (num != 0)
				{
				}
				num = (short)1590165505;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesExtendedDispatchEn_A37220._HasDiffs;
			}
		}

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x00AD1334 File Offset: 0x00ACF534
		// (set) Token: 0x0600BAAB RID: 47787 RVA: 0x00AD13E8 File Offset: 0x00ACF5E8
		public int CnvSysFeaturesTxBaseTimeSec_A9513Value
		{
			get
			{
				short num = (short)386230306;
				short num2 = num;
				num = (short)1473210402;
				switch (num2 == num)
				{
				}
				num = (short)1343488000;
				short num3 = num;
				num = (short)1939144705;
				if (num != 0)
				{
				}
				num = (short)847314944;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Value;
			}
			set
			{
				short num = (short)1570395625;
				short num2 = num;
				num = (short)1417958889;
				switch (num2 == num)
				{
				}
				num = (short)574619648;
				short num3 = num;
				num = (short)111673344;
				if (num != 0)
				{
				}
				num = (short)55967745;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Value = value;
			}
		}

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x0600BAAC RID: 47788 RVA: 0x00AD149C File Offset: 0x00ACF69C
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysFeaturesTxBaseTimeSec_A9513
		{
			get
			{
				short num = (short)335789748;
				short num2 = num;
				num = (short)674283188;
				switch (num2 == num)
				{
				}
				num = (short)154271744;
				short num3 = num;
				num = (short)1191706624;
				if (num != 0)
				{
				}
				num = (short)1905328129;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513;
			}
		}

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x00AD1548 File Offset: 0x00ACF748
		// (set) Token: 0x0600BAAE RID: 47790 RVA: 0x00AD1600 File Offset: 0x00ACF800
		public string CnvSysFeaturesTxBaseTimeSec_A9513_UIValue
		{
			get
			{
				short num = (short)308997352;
				short num2 = num;
				num = (short)1760554216;
				switch (num2 == num)
				{
				}
				num = (short)270729216;
				short num3 = num;
				num = (short)1103626241;
				if (num != 0)
				{
				}
				num = (short)1245970432;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.UIValue;
			}
			set
			{
				short num = (short)1719819217;
				short num2 = num;
				num = (short)203840465;
				switch (num2 == num)
				{
				}
				num = (short)2033844224;
				short num3 = num;
				num = (short)1513291777;
				if (num != 0)
				{
				}
				num = (short)106561536;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.UIValue = value;
			}
		}

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x0600BAAF RID: 47791 RVA: 0x00AD16B4 File Offset: 0x00ACF8B4
		// (set) Token: 0x0600BAB0 RID: 47792 RVA: 0x00AD1768 File Offset: 0x00ACF968
		internal int CnvSysFeaturesTxBaseTimeSec_A9513Min
		{
			get
			{
				short num = (short)268794792;
				short num2 = num;
				num = (short)890796968;
				switch (num2 == num)
				{
				}
				num = (short)780337152;
				short num3 = num;
				num = (short)1043791873;
				if (num != 0)
				{
				}
				num = (short)2082603008;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Min;
			}
			set
			{
				short num = (short)1952253762;
				short num2 = num;
				num = (short)1687488322;
				switch (num2 == num)
				{
				}
				num = (short)405798912;
				short num3 = num;
				num = (short)474415104;
				if (num != 0)
				{
				}
				num = (short)93257729;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Min = value;
			}
		}

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x0600BAB1 RID: 47793 RVA: 0x00AD1820 File Offset: 0x00ACFA20
		// (set) Token: 0x0600BAB2 RID: 47794 RVA: 0x00AD18D4 File Offset: 0x00ACFAD4
		internal int CnvSysFeaturesTxBaseTimeSec_A9513Max
		{
			get
			{
				short num = (short)1383861871;
				short num2 = num;
				num = (short)1800670831;
				switch (num2 == num)
				{
				}
				num = (short)1071841280;
				short num3 = num;
				num = (short)1415905281;
				if (num != 0)
				{
				}
				num = (short)1055195136;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Max;
			}
			set
			{
				short num = (short)1415053925;
				short num2 = num;
				num = (short)10420837;
				switch (num2 == num)
				{
				}
				num = (short)1749024768;
				short num3 = num;
				num = (short)385941505;
				if (num != 0)
				{
				}
				num = (short)1796079616;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Max = value;
			}
		}

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x00AD198C File Offset: 0x00ACFB8C
		// (set) Token: 0x0600BAB4 RID: 47796 RVA: 0x00AD1A40 File Offset: 0x00ACFC40
		internal int CnvSysFeaturesTxBaseTimeSec_A9513Step
		{
			get
			{
				short num = (short)958595073;
				if (num != 0)
				{
				}
				num = (short)349648745;
				short num2 = num;
				num = (short)1863989097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009268224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)686227456;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.StepSize;
			}
			set
			{
				short num = (short)1895533870;
				short num2 = num;
				num = (short)414289198;
				switch (num2 == num)
				{
				}
				num = (short)132710400;
				short num3 = num;
				num = (short)149225473;
				if (num != 0)
				{
				}
				num = (short)1589510144;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.StepSize = value;
			}
		}

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x0600BAB5 RID: 47797 RVA: 0x00AD1AF8 File Offset: 0x00ACFCF8
		// (set) Token: 0x0600BAB6 RID: 47798 RVA: 0x00AD1BB0 File Offset: 0x00ACFDB0
		public bool CnvSysFeaturesTxBaseTimeSec_A9513_Applicable
		{
			get
			{
				short num = (short)1368252737;
				short num2 = num;
				num = (short)1802035521;
				switch (num2 == num)
				{
				}
				num = (short)1955856384;
				short num3 = num;
				num = (short)1045430273;
				if (num != 0)
				{
				}
				num = (short)2053177344;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Applicable;
			}
			set
			{
				short num = (short)1446717165;
				short num2 = num;
				num = (short)239478509;
				switch (num2 == num)
				{
				}
				num = (short)833552384;
				short num3 = num;
				num = (short)1207959552;
				if (num != 0)
				{
				}
				num = (short)1016266753;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Applicable = value;
			}
		}

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x00AD1C64 File Offset: 0x00ACFE64
		// (set) Token: 0x0600BAB8 RID: 47800 RVA: 0x00AD1D18 File Offset: 0x00ACFF18
		public bool CnvSysFeaturesTxBaseTimeSec_A9513_Valid
		{
			get
			{
				short num = (short)1143250170;
				short num2 = num;
				num = (short)2016582906;
				switch (num2 == num)
				{
				}
				num = (short)1046085632;
				short num3 = num;
				num = (short)945881089;
				if (num != 0)
				{
				}
				num = (short)881524736;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Valid;
			}
			set
			{
				short num = (short)1753504795;
				short num2 = num;
				num = (short)2137545755;
				switch (num2 == num)
				{
				}
				num = (short)957939712;
				short num3 = num;
				num = (short)71565313;
				if (num != 0)
				{
				}
				num = (short)2032533504;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Valid = value;
			}
		}

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x00AD1DD0 File Offset: 0x00ACFFD0
		// (set) Token: 0x0600BABA RID: 47802 RVA: 0x00AD1E84 File Offset: 0x00AD0084
		public bool CnvSysFeaturesTxBaseTimeSec_A9513_Visible
		{
			get
			{
				short num = (short)924319745;
				if (num != 0)
				{
				}
				num = (short)1069947871;
				short num2 = num;
				num = (short)2123766751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42270720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1276510208;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Visible;
			}
			set
			{
				short num = (short)1045914238;
				short num2 = num;
				num = (short)57434750;
				switch (num2 == num)
				{
				}
				num = (short)139526144;
				short num3 = num;
				num = (short)555483137;
				if (num != 0)
				{
				}
				num = (short)666697728;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Visible = value;
			}
		}

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x0600BABB RID: 47803 RVA: 0x00AD1F38 File Offset: 0x00AD0138
		// (set) Token: 0x0600BABC RID: 47804 RVA: 0x00AD1FEC File Offset: 0x00AD01EC
		public bool CnvSysFeaturesTxBaseTimeSec_A9513_Editable
		{
			get
			{
				short num = (short)1988953500;
				short num2 = num;
				num = (short)270665116;
				switch (num2 == num)
				{
				}
				num = (short)1446903808;
				short num3 = num;
				num = (short)900136960;
				if (num != 0)
				{
				}
				num = (short)75694081;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.Editable;
			}
			set
			{
				short num = (short)1303904257;
				if (num != 0)
				{
				}
				num = (short)1220735945;
				short num2 = num;
				num = (short)516158409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034827264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958412288;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.Editable = value;
			}
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x0600BABD RID: 47805 RVA: 0x00AD20A4 File Offset: 0x00AD02A4
		internal string CnvSysFeaturesTxBaseTimeSec_A9513_UILabel
		{
			get
			{
				short num = (short)757920417;
				short num2 = num;
				num = (short)1523905185;
				switch (num2 == num)
				{
				}
				num = (short)254017536;
				short num3 = num;
				num = (short)1292435456;
				if (num != 0)
				{
				}
				num = (short)511508481;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.UIName;
			}
		}

		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x0600BABE RID: 47806 RVA: 0x00AD2158 File Offset: 0x00AD0358
		// (set) Token: 0x0600BABF RID: 47807 RVA: 0x00AD220C File Offset: 0x00AD040C
		internal bool CnvSysFeaturesTxBaseTimeSec_A9513_HiddenStatic
		{
			get
			{
				short num = (short)1868892668;
				short num2 = num;
				num = (short)142674428;
				switch (num2 == num)
				{
				}
				num = (short)384303104;
				short num3 = num;
				num = (short)932970496;
				if (num != 0)
				{
				}
				num = (short)1338114049;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.HiddenStatic;
			}
			set
			{
				short num = (short)349993063;
				short num2 = num;
				num = (short)576026727;
				switch (num2 == num)
				{
				}
				num = (short)931987456;
				short num3 = num;
				num = (short)41746433;
				if (num != 0)
				{
				}
				num = (short)2082996224;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.HiddenStatic = value;
			}
		}

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x00AD22C4 File Offset: 0x00AD04C4
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x00AD2378 File Offset: 0x00AD0578
		internal bool CnvSysFeaturesTxBaseTimeSec_A9513_HiddenDynamic
		{
			get
			{
				short num = (short)1134447230;
				short num2 = num;
				num = (short)379800190;
				switch (num2 == num)
				{
				}
				num = (short)2133065728;
				short num3 = num;
				num = (short)1568735232;
				if (num != 0)
				{
				}
				num = (short)438632449;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513.HiddenDynamic;
			}
			set
			{
				short num = (short)643728463;
				short num2 = num;
				num = (short)695501903;
				switch (num2 == num)
				{
				}
				num = (short)2018836480;
				short num3 = num;
				num = (short)959774721;
				if (num != 0)
				{
				}
				num = (short)471662592;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesTxBaseTimeSec_A9513.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x00AD2428 File Offset: 0x00AD0628
		public bool CnvSysFeaturesTxBaseTimeSec_A9513_HasDiffs
		{
			get
			{
				short num = (short)53103222;
				short num2 = num;
				num = (short)1540049526;
				switch (num2 == num)
				{
				}
				num = (short)1622802432;
				short num3 = num;
				num = (short)898891777;
				if (num != 0)
				{
				}
				num = (short)107020288;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesTxBaseTimeSec_A9513._HasDiffs;
			}
		}

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x0600BAC3 RID: 47811 RVA: 0x00AD24DC File Offset: 0x00AD06DC
		// (set) Token: 0x0600BAC4 RID: 47812 RVA: 0x00AD2594 File Offset: 0x00AD0794
		public bool CnvSysFeaturesDynamicIDEnable_A40100Value
		{
			get
			{
				short num = (short)1164895814;
				short num2 = num;
				num = (short)1411900998;
				switch (num2 == num)
				{
				}
				num = (short)1006436352;
				short num3 = num;
				num = (short)285671424;
				if (num != 0)
				{
				}
				num = (short)1083506689;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Value;
			}
			set
			{
				short num = (short)849250705;
				short num2 = num;
				num = (short)2140375441;
				switch (num2 == num)
				{
				}
				num = (short)1763246080;
				short num3 = num;
				num = (short)182779905;
				if (num != 0)
				{
				}
				num = (short)848297984;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Value = value;
			}
		}

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x0600BAC5 RID: 47813 RVA: 0x00AD2648 File Offset: 0x00AD0848
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesDynamicIDEnable_A40100
		{
			get
			{
				short num = (short)451932433;
				short num2 = num;
				num = (short)1927934225;
				switch (num2 == num)
				{
				}
				num = (short)583204864;
				short num3 = num;
				num = (short)1799356416;
				if (num != 0)
				{
				}
				num = (short)309723137;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100;
			}
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x00AD26F8 File Offset: 0x00AD08F8
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x00AD27AC File Offset: 0x00AD09AC
		public bool CnvSysFeaturesDynamicIDEnable_A40100_UIValue
		{
			get
			{
				short num = (short)549150936;
				short num2 = num;
				num = (short)1929208024;
				switch (num2 == num)
				{
				}
				num = (short)1922170880;
				short num3 = num;
				num = (short)2074083329;
				if (num != 0)
				{
				}
				num = (short)1756299264;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Value;
			}
			set
			{
				short num = (short)566231041;
				if (num != 0)
				{
				}
				num = (short)428450842;
				short num2 = num;
				num = (short)119579674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136473600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)803733504;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Value = value;
			}
		}

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x00AD2860 File Offset: 0x00AD0A60
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x00AD2918 File Offset: 0x00AD0B18
		public bool CnvSysFeaturesDynamicIDEnable_A40100_Applicable
		{
			get
			{
				short num = (short)1487647484;
				short num2 = num;
				num = (short)827044604;
				switch (num2 == num)
				{
				}
				num = (short)151388160;
				short num3 = num;
				num = (short)459603969;
				if (num != 0)
				{
				}
				num = (short)1316093952;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Applicable;
			}
			set
			{
				short num = (short)394985473;
				if (num != 0)
				{
				}
				num = (short)155250629;
				short num2 = num;
				num = (short)1596125125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873805312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)354418688;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Applicable = value;
			}
		}

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x00AD29D0 File Offset: 0x00AD0BD0
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x00AD2A84 File Offset: 0x00AD0C84
		public bool CnvSysFeaturesDynamicIDEnable_A40100_Valid
		{
			get
			{
				short num = (short)124396898;
				short num2 = num;
				num = (short)909321570;
				switch (num2 == num)
				{
				}
				num = (short)1717043200;
				short num3 = num;
				num = (short)1379991553;
				if (num != 0)
				{
				}
				num = (short)1445068800;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Valid;
			}
			set
			{
				short num = (short)1075843934;
				short num2 = num;
				num = (short)1431638878;
				switch (num2 == num)
				{
				}
				num = (short)1208025088;
				short num3 = num;
				num = (short)185073664;
				if (num != 0)
				{
				}
				num = (short)1731723265;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Valid = value;
			}
		}

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x00AD2B3C File Offset: 0x00AD0D3C
		// (set) Token: 0x0600BACD RID: 47821 RVA: 0x00AD2BF0 File Offset: 0x00AD0DF0
		public bool CnvSysFeaturesDynamicIDEnable_A40100_Visible
		{
			get
			{
				short num = (short)804407705;
				short num2 = num;
				num = (short)690702745;
				switch (num2 == num)
				{
				}
				num = (short)1494810624;
				short num3 = num;
				num = (short)132448257;
				if (num != 0)
				{
				}
				num = (short)738328576;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Visible;
			}
			set
			{
				short num = (short)218491162;
				short num2 = num;
				num = (short)190310682;
				switch (num2 == num)
				{
				}
				num = (short)101646336;
				short num3 = num;
				num = (short)2123235328;
				if (num != 0)
				{
				}
				num = (short)503578625;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Visible = value;
			}
		}

		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x0600BACE RID: 47822 RVA: 0x00AD2CA4 File Offset: 0x00AD0EA4
		// (set) Token: 0x0600BACF RID: 47823 RVA: 0x00AD2D5C File Offset: 0x00AD0F5C
		public bool CnvSysFeaturesDynamicIDEnable_A40100_Editable
		{
			get
			{
				short num = (short)1076805544;
				short num2 = num;
				num = (short)1484111784;
				switch (num2 == num)
				{
				}
				num = (short)143720448;
				short num3 = num;
				num = (short)1915486209;
				if (num != 0)
				{
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.Editable;
			}
			set
			{
				short num = (short)1948391234;
				short num2 = num;
				num = (short)1549997890;
				switch (num2 == num)
				{
				}
				num = (short)840105984;
				short num3 = num;
				num = (short)685834240;
				if (num != 0)
				{
				}
				num = (short)1049755649;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.Editable = value;
			}
		}

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x00AD2E10 File Offset: 0x00AD1010
		internal string CnvSysFeaturesDynamicIDEnable_A40100_UILabel
		{
			get
			{
				short num = (short)554106881;
				if (num != 0)
				{
				}
				num = (short)123522571;
				short num2 = num;
				num = (short)2054409739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774977024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794310144;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.UIName;
			}
		}

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x00AD2EC4 File Offset: 0x00AD10C4
		// (set) Token: 0x0600BAD2 RID: 47826 RVA: 0x00AD2F78 File Offset: 0x00AD1178
		internal bool CnvSysFeaturesDynamicIDEnable_A40100_HiddenStatic
		{
			get
			{
				short num = (short)833001946;
				short num2 = num;
				num = (short)1475516890;
				switch (num2 == num)
				{
				}
				num = (short)922288128;
				short num3 = num;
				num = (short)136445953;
				if (num != 0)
				{
				}
				num = (short)2082078720;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.HiddenStatic;
			}
			set
			{
				short num = (short)1390542848;
				short num2 = num;
				num = (short)392047659;
				short num3 = num;
				num = (short)746531883;
				switch (num3 == num)
				{
				}
				num = (short)1451163649;
				if (num != 0)
				{
				}
				num = (short)1795096576;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.HiddenStatic = value;
			}
		}

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x00AD3030 File Offset: 0x00AD1230
		// (set) Token: 0x0600BAD4 RID: 47828 RVA: 0x00AD30E4 File Offset: 0x00AD12E4
		internal bool CnvSysFeaturesDynamicIDEnable_A40100_HiddenDynamic
		{
			get
			{
				short num = (short)1858928640;
				short num2 = num;
				num = (short)313913402;
				short num3 = num;
				num = (short)824832058;
				switch (num3 == num)
				{
				}
				num = (short)1603272705;
				if (num != 0)
				{
				}
				num = (short)1724317696;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100.HiddenDynamic;
			}
			set
			{
				short num = (short)547094528;
				short num2 = num;
				num = (short)1229166136;
				short num3 = num;
				num = (short)2069599800;
				switch (num3 == num)
				{
				}
				num = (short)331218945;
				if (num != 0)
				{
				}
				num = (short)1169555456;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesDynamicIDEnable_A40100.HiddenDynamic = value;
			}
		}

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x00AD3198 File Offset: 0x00AD1398
		public bool CnvSysFeaturesDynamicIDEnable_A40100_HasDiffs
		{
			get
			{
				short num = (short)282591232;
				short num2 = num;
				num = (short)1543045538;
				short num3 = num;
				num = (short)1331298722;
				switch (num3 == num)
				{
				}
				num = (short)83230721;
				if (num != 0)
				{
				}
				num = (short)955056128;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesDynamicIDEnable_A40100._HasDiffs;
			}
		}

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x0600BAD6 RID: 47830 RVA: 0x00AD324C File Offset: 0x00AD144C
		// (set) Token: 0x0600BAD7 RID: 47831 RVA: 0x00AD3300 File Offset: 0x00AD1500
		public bool CnvSysDVRSPOP25Enable_A40126Value
		{
			get
			{
				short num = (short)1924202496;
				short num2 = num;
				num = (short)587153467;
				short num3 = num;
				num = (short)893075515;
				switch (num3 == num)
				{
				}
				num = (short)1620377601;
				if (num != 0)
				{
				}
				num = (short)1742077952;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Value;
			}
			set
			{
				short num = (short)1277493248;
				short num2 = num;
				num = (short)681759929;
				short num3 = num;
				num = (short)382194873;
				switch (num3 == num)
				{
				}
				num = (short)2001469440;
				if (num != 0)
				{
				}
				num = (short)716505089;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Value = value;
			}
		}

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x0600BAD8 RID: 47832 RVA: 0x00AD33B8 File Offset: 0x00AD15B8
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSPOP25Enable_A40126
		{
			get
			{
				short num = (short)682229760;
				short num2 = num;
				num = (short)1397986514;
				short num3 = num;
				num = (short)1419941074;
				switch (num3 == num)
				{
				}
				num = (short)511311872;
				if (num != 0)
				{
				}
				num = (short)487718913;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126;
			}
		}

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x0600BAD9 RID: 47833 RVA: 0x00AD3468 File Offset: 0x00AD1668
		// (set) Token: 0x0600BADA RID: 47834 RVA: 0x00AD351C File Offset: 0x00AD171C
		public bool CnvSysDVRSPOP25Enable_A40126_UIValue
		{
			get
			{
				short num = (short)604569600;
				short num2 = num;
				num = (short)865649413;
				short num3 = num;
				num = (short)1346618117;
				switch (num3 == num)
				{
				}
				num = (short)1601830913;
				if (num != 0)
				{
				}
				num = (short)1817313280;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Value;
			}
			set
			{
				short num = (short)1932984320;
				short num2 = num;
				num = (short)334192646;
				short num3 = num;
				num = (short)380723206;
				switch (num3 == num)
				{
				}
				num = (short)745013248;
				if (num != 0)
				{
				}
				num = (short)1641545729;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Value = value;
			}
		}

		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x0600BADB RID: 47835 RVA: 0x00AD35D8 File Offset: 0x00AD17D8
		// (set) Token: 0x0600BADC RID: 47836 RVA: 0x00AD368C File Offset: 0x00AD188C
		public bool CnvSysDVRSPOP25Enable_A40126_Applicable
		{
			get
			{
				short num = (short)1638596608;
				short num2 = num;
				num = (short)787207286;
				short num3 = num;
				num = (short)1636029558;
				switch (num3 == num)
				{
				}
				num = (short)596705281;
				if (num != 0)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Applicable;
			}
			set
			{
				short num = (short)591790080;
				short num2 = num;
				num = (short)1767343990;
				short num3 = num;
				num = (short)1663862646;
				switch (num3 == num)
				{
				}
				num = (short)408354817;
				if (num != 0)
				{
				}
				num = (short)1442447360;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Applicable = value;
			}
		}

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x0600BADD RID: 47837 RVA: 0x00AD3740 File Offset: 0x00AD1940
		// (set) Token: 0x0600BADE RID: 47838 RVA: 0x00AD37F4 File Offset: 0x00AD19F4
		public bool CnvSysDVRSPOP25Enable_A40126_Valid
		{
			get
			{
				short num = (short)1499267072;
				short num2 = num;
				num = (short)853567128;
				short num3 = num;
				num = (short)1958897304;
				switch (num3 == num)
				{
				}
				num = (short)327614465;
				if (num != 0)
				{
				}
				num = (short)2076442624;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Valid;
			}
			set
			{
				short num = (short)1455423488;
				short num2 = num;
				num = (short)1076496202;
				short num3 = num;
				num = (short)229246794;
				switch (num3 == num)
				{
				}
				num = (short)46006273;
				if (num != 0)
				{
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Valid = value;
			}
		}

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x0600BADF RID: 47839 RVA: 0x00AD38A8 File Offset: 0x00AD1AA8
		// (set) Token: 0x0600BAE0 RID: 47840 RVA: 0x00AD395C File Offset: 0x00AD1B5C
		public bool CnvSysDVRSPOP25Enable_A40126_Visible
		{
			get
			{
				short num = (short)2083127296;
				short num2 = num;
				num = (short)1457857818;
				short num3 = num;
				num = (short)1893279002;
				switch (num3 == num)
				{
				}
				num = (short)475791361;
				if (num != 0)
				{
				}
				num = (short)882966528;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Visible;
			}
			set
			{
				short num = (short)245366784;
				short num2 = num;
				num = (short)253231105;
				if (num != 0)
				{
				}
				num = (short)1886979265;
				short num3 = num;
				num = (short)1270809793;
				switch (num3 == num)
				{
				}
				num = (short)639959040;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Visible = value;
			}
		}

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x00AD3A10 File Offset: 0x00AD1C10
		// (set) Token: 0x0600BAE2 RID: 47842 RVA: 0x00AD3AC8 File Offset: 0x00AD1CC8
		public bool CnvSysDVRSPOP25Enable_A40126_Editable
		{
			get
			{
				short num = (short)779616256;
				short num2 = num;
				num = (short)2129260474;
				short num3 = num;
				num = (short)671018938;
				switch (num3 == num)
				{
				}
				num = (short)1743388672;
				if (num != 0)
				{
				}
				num = (short)1244135425;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.Editable;
			}
			set
			{
				short num = (short)1145372672;
				short num2 = num;
				num = (short)99879786;
				short num3 = num;
				num = (short)1661209450;
				switch (num3 == num)
				{
				}
				num = (short)18939905;
				if (num != 0)
				{
				}
				num = (short)1939472384;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.Editable = value;
			}
		}

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x0600BAE3 RID: 47843 RVA: 0x00AD3B7C File Offset: 0x00AD1D7C
		internal string CnvSysDVRSPOP25Enable_A40126_UILabel
		{
			get
			{
				short num = (short)950665216;
				short num2 = num;
				num = (short)377764453;
				short num3 = num;
				num = (short)458308197;
				switch (num3 == num)
				{
				}
				num = (short)1661468673;
				if (num != 0)
				{
				}
				num = (short)124321792;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.UIName;
			}
		}

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x00AD3C2C File Offset: 0x00AD1E2C
		// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x00AD3CE0 File Offset: 0x00AD1EE0
		internal bool CnvSysDVRSPOP25Enable_A40126_HiddenStatic
		{
			get
			{
				short num = (short)1222180864;
				short num2 = num;
				num = (short)1504092786;
				short num3 = num;
				num = (short)2113053298;
				switch (num3 == num)
				{
				}
				num = (short)877330433;
				if (num != 0)
				{
				}
				num = (short)360906752;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.HiddenStatic;
			}
			set
			{
				short num = (short)1062731776;
				short num2 = num;
				num = (short)241595786;
				short num3 = num;
				num = (short)923170186;
				switch (num3 == num)
				{
				}
				num = (short)629014529;
				if (num != 0)
				{
				}
				num = (short)1576599552;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.HiddenStatic = value;
			}
		}

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x00AD3D94 File Offset: 0x00AD1F94
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x00AD3E48 File Offset: 0x00AD2048
		internal bool CnvSysDVRSPOP25Enable_A40126_HiddenDynamic
		{
			get
			{
				short num = (short)1226899456;
				short num2 = num;
				num = (short)2126053377;
				if (num != 0)
				{
				}
				num = (short)1588851222;
				short num3 = num;
				num = (short)1932522006;
				switch (num3 == num)
				{
				}
				num = (short)166526976;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126.HiddenDynamic;
			}
			set
			{
				short num = (short)1582235648;
				short num2 = num;
				num = (short)1541931009;
				if (num != 0)
				{
				}
				num = (short)1960777264;
				short num3 = num;
				num = (short)21763632;
				switch (num3 == num)
				{
				}
				num = (short)551092224;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPOP25Enable_A40126.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x00AD3F00 File Offset: 0x00AD2100
		public bool CnvSysDVRSPOP25Enable_A40126_HasDiffs
		{
			get
			{
				short num = (short)2078146560;
				short num2 = num;
				num = (short)1412279702;
				short num3 = num;
				num = (short)1463922070;
				switch (num3 == num)
				{
				}
				num = (short)437256193;
				if (num != 0)
				{
				}
				num = (short)1031471104;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPOP25Enable_A40126._HasDiffs;
			}
		}

		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x0600BAE9 RID: 47849 RVA: 0x00AD3FB4 File Offset: 0x00AD21B4
		// (set) Token: 0x0600BAEA RID: 47850 RVA: 0x00AD4068 File Offset: 0x00AD2268
		public bool CnvSysFeaturesEmergencyAckEn_A41546Value
		{
			get
			{
				short num = (short)2133721088;
				short num2 = num;
				num = (short)1824546379;
				short num3 = num;
				num = (short)151084619;
				switch (num3 == num)
				{
				}
				num = (short)610861057;
				if (num != 0)
				{
				}
				num = (short)810549248;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Value;
			}
			set
			{
				short num = (short)1186922496;
				short num2 = num;
				num = (short)910001261;
				short num3 = num;
				num = (short)1802470509;
				switch (num3 == num)
				{
				}
				num = (short)1009188864;
				if (num != 0)
				{
				}
				num = (short)1091567617;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Value = value;
			}
		}

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x0600BAEB RID: 47851 RVA: 0x00AD411C File Offset: 0x00AD231C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesEmergencyAckEn_A41546
		{
			get
			{
				short num = (short)1931804672;
				short num2 = num;
				num = (short)954204161;
				if (num != 0)
				{
				}
				num = (short)801676648;
				short num3 = num;
				num = (short)136027496;
				switch (num3 == num)
				{
				}
				num = (short)256311296;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546;
			}
		}

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x0600BAEC RID: 47852 RVA: 0x00AD41CC File Offset: 0x00AD23CC
		// (set) Token: 0x0600BAED RID: 47853 RVA: 0x00AD4280 File Offset: 0x00AD2480
		public bool CnvSysFeaturesEmergencyAckEn_A41546_UIValue
		{
			get
			{
				short num = (short)494927872;
				short num2 = num;
				num = (short)1656422401;
				if (num != 0)
				{
				}
				num = (short)453753822;
				short num3 = num;
				num = (short)1812708318;
				switch (num3 == num)
				{
				}
				num = (short)1368260608;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Value;
			}
			set
			{
				short num = (short)1489829888;
				short num2 = num;
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)676402063;
				short num3 = num;
				num = (short)2083001231;
				switch (num3 == num)
				{
				}
				num = (short)1004470272;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Value = value;
			}
		}

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x00AD4338 File Offset: 0x00AD2538
		// (set) Token: 0x0600BAEF RID: 47855 RVA: 0x00AD43EC File Offset: 0x00AD25EC
		public bool CnvSysFeaturesEmergencyAckEn_A41546_Applicable
		{
			get
			{
				short num = (short)1850408960;
				short num2 = num;
				num = (short)1595429729;
				short num3 = num;
				num = (short)828527457;
				switch (num3 == num)
				{
				}
				num = (short)1712193537;
				if (num != 0)
				{
				}
				num = (short)479723520;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Applicable;
			}
			set
			{
				short num = (short)1320026112;
				short num2 = num;
				num = (short)809726720;
				short num3 = num;
				num = (short)449278720;
				switch (num3 == num)
				{
				}
				num = (short)672464896;
				if (num != 0)
				{
				}
				num = (short)368115713;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Applicable = value;
			}
		}

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x00AD44A4 File Offset: 0x00AD26A4
		// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x00AD4558 File Offset: 0x00AD2758
		public bool CnvSysFeaturesEmergencyAckEn_A41546_Valid
		{
			get
			{
				short num = (short)138084352;
				short num2 = num;
				num = (short)288971830;
				short num3 = num;
				num = (short)518741046;
				switch (num3 == num)
				{
				}
				num = (short)291897345;
				if (num != 0)
				{
				}
				num = (short)1918304256;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Valid;
			}
			set
			{
				short num = (short)464125952;
				short num2 = num;
				num = (short)798378812;
				short num3 = num;
				num = (short)1090210620;
				switch (num3 == num)
				{
				}
				num = (short)1846542336;
				if (num != 0)
				{
				}
				num = (short)1882062849;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Valid = value;
			}
		}

		// Token: 0x17005DAB RID: 23979
		// (get) Token: 0x0600BAF2 RID: 47858 RVA: 0x00AD4610 File Offset: 0x00AD2810
		// (set) Token: 0x0600BAF3 RID: 47859 RVA: 0x00AD46C4 File Offset: 0x00AD28C4
		public bool CnvSysFeaturesEmergencyAckEn_A41546_Visible
		{
			get
			{
				short num = (short)331218944;
				short num2 = num;
				num = (short)1147942800;
				short num3 = num;
				num = (short)1986148240;
				switch (num3 == num)
				{
				}
				num = (short)1815937024;
				if (num != 0)
				{
				}
				num = (short)1699872769;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Visible;
			}
			set
			{
				short num = (short)776798208;
				short num2 = num;
				num = (short)1822906862;
				short num3 = num;
				num = (short)1753569774;
				switch (num3 == num)
				{
				}
				num = (short)794755073;
				if (num != 0)
				{
				}
				num = (short)499056640;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Visible = value;
			}
		}

		// Token: 0x17005DAC RID: 23980
		// (get) Token: 0x0600BAF4 RID: 47860 RVA: 0x00AD477C File Offset: 0x00AD297C
		// (set) Token: 0x0600BAF5 RID: 47861 RVA: 0x00AD4834 File Offset: 0x00AD2A34
		public bool CnvSysFeaturesEmergencyAckEn_A41546_Editable
		{
			get
			{
				short num = (short)854982656;
				short num2 = num;
				num = (short)690210422;
				short num3 = num;
				num = (short)1871038070;
				switch (num3 == num)
				{
				}
				num = (short)243335169;
				if (num != 0)
				{
				}
				num = (short)419495936;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.Editable;
			}
			set
			{
				short num = (short)701104128;
				short num2 = num;
				num = (short)240720321;
				short num3 = num;
				num = (short)899226049;
				switch (num3 == num)
				{
				}
				num = (short)1105461249;
				if (num != 0)
				{
				}
				num = (short)468975616;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.Editable = value;
			}
		}

		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x0600BAF6 RID: 47862 RVA: 0x00AD48EC File Offset: 0x00AD2AEC
		internal string CnvSysFeaturesEmergencyAckEn_A41546_UILabel
		{
			get
			{
				short num = (short)2056978432;
				short num2 = num;
				num = (short)1598939695;
				short num3 = num;
				num = (short)892330543;
				switch (num3 == num)
				{
				}
				num = (short)1092222977;
				if (num != 0)
				{
				}
				num = (short)1317601280;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.UIName;
			}
		}

		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x00AD49A0 File Offset: 0x00AD2BA0
		// (set) Token: 0x0600BAF8 RID: 47864 RVA: 0x00AD4A58 File Offset: 0x00AD2C58
		internal bool CnvSysFeaturesEmergencyAckEn_A41546_HiddenStatic
		{
			get
			{
				short num = (short)1180958720;
				short num2 = num;
				num = (short)1466517724;
				short num3 = num;
				num = (short)1277053148;
				switch (num3 == num)
				{
				}
				num = (short)459472897;
				if (num != 0)
				{
				}
				num = (short)1023213568;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.HiddenStatic;
			}
			set
			{
				short num = (short)2124152832;
				short num2 = num;
				num = (short)1005798419;
				short num3 = num;
				num = (short)1433945107;
				switch (num3 == num)
				{
				}
				num = (short)1011220481;
				if (num != 0)
				{
				}
				num = (short)327286784;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.HiddenStatic = value;
			}
		}

		// Token: 0x17005DAF RID: 23983
		// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x00AD4B0C File Offset: 0x00AD2D0C
		// (set) Token: 0x0600BAFA RID: 47866 RVA: 0x00AD4BC0 File Offset: 0x00AD2DC0
		internal bool CnvSysFeaturesEmergencyAckEn_A41546_HiddenDynamic
		{
			get
			{
				short num = (short)685965312;
				short num2 = num;
				num = (short)472872380;
				short num3 = num;
				num = (short)1971549628;
				switch (num3 == num)
				{
				}
				num = (short)1115422721;
				if (num != 0)
				{
				}
				num = (short)415956992;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546.HiddenDynamic;
			}
			set
			{
				short num = (short)517996544;
				short num2 = num;
				num = (short)331087873;
				if (num != 0)
				{
				}
				num = (short)119951732;
				short num3 = num;
				num = (short)1294946676;
				switch (num3 == num)
				{
				}
				num = (short)1506738176;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesEmergencyAckEn_A41546.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x00AD4C74 File Offset: 0x00AD2E74
		public bool CnvSysFeaturesEmergencyAckEn_A41546_HasDiffs
		{
			get
			{
				short num = (short)1285554176;
				short num2 = num;
				num = (short)69926913;
				if (num != 0)
				{
				}
				num = (short)320718476;
				short num3 = num;
				num = (short)10077836;
				switch (num3 == num)
				{
				}
				num = (short)381419520;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesEmergencyAckEn_A41546._HasDiffs;
			}
		}

		// Token: 0x17005DB1 RID: 23985
		// (get) Token: 0x0600BAFC RID: 47868 RVA: 0x00AD4D28 File Offset: 0x00AD2F28
		// (set) Token: 0x0600BAFD RID: 47869 RVA: 0x00AD4DDC File Offset: 0x00AD2FDC
		public bool CnvSysFeaturesSendLocationToPeer_42427Value
		{
			get
			{
				short num = (short)222429184;
				short num2 = num;
				num = (short)1518768395;
				short num3 = num;
				num = (short)1022857483;
				switch (num3 == num)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				num = (short)1645084673;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesSendLocationToPeer_42427.Value;
			}
			set
			{
				short num = (short)1848705024;
				short num2 = num;
				num = (short)1056702465;
				if (num != 0)
				{
				}
				num = (short)180391009;
				short num3 = num;
				num = (short)1751747681;
				switch (num3 == num)
				{
				}
				num = (short)1836711936;
				if (num != 0)
				{
				}
				this.cnvSysFeaturesSendLocationToPeer_42427.Value = value;
			}
		}

		// Token: 0x17005DB2 RID: 23986
		// (get) Token: 0x0600BAFE RID: 47870 RVA: 0x00AD4E90 File Offset: 0x00AD3090
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeaturesSendLocationToPeer_42427
		{
			get
			{
				short num = (short)388235264;
				short num2 = num;
				num = (short)309075107;
				short num3 = num;
				num = (short)2143755427;
				switch (num3 == num)
				{
				}
				num = (short)1103888384;
				if (num != 0)
				{
				}
				num = (short)51445761;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesSendLocationToPeer_42427;
			}
		}

		// Token: 0x17005DB3 RID: 23987
		// (get) Token: 0x0600BAFF RID: 47871 RVA: 0x00AD4F40 File Offset: 0x00AD3140
		// (set) Token: 0x0600BB00 RID: 47872 RVA: 0x00AD4FF4 File Offset: 0x00AD31F4
		public bool CnvSysFeaturesSendLocationToPeer_42427_UIValue
		{
			get
			{
				short num = (short)121307136;
				short num2 = num;
				num = (short)548424803;
				short num3 = num;
				num = (short)1041583203;
				switch (num3 == num)
				{
				}
				num = (short)1430519809;
				if (num != 0)
				{
				}
				num = (short)1835728896;
				if (num != 0)
				{
				}
				return this.cnvSysFeaturesSendLocationToPeer_42427.Value;
			}
			set
			{
				short num = (short)2121263227;
				short num2 = num;
				num = (short)1170401403;
				switch (num2 == num)
				{
				}
				num = (short)650510337;
				if (num != 0)
				{
				}
				num = (short)303431680;
				if (num != 0)
				{
				}
				num = (short)1379205120;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.Value = value;
			}
		}

		// Token: 0x17005DB4 RID: 23988
		// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x00AD50AC File Offset: 0x00AD32AC
		// (set) Token: 0x0600BB02 RID: 47874 RVA: 0x00AD5164 File Offset: 0x00AD3364
		public bool CnvSysFeaturesSendLocationToPeer_42427_Applicable
		{
			get
			{
				short num = (short)500432897;
				if (num != 0)
				{
				}
				num = (short)1818886215;
				short num2 = num;
				num = (short)151978055;
				switch (num2 == num)
				{
				}
				num = (short)450101248;
				if (num != 0)
				{
				}
				num = (short)938147840;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.Applicable;
			}
			set
			{
				short num = (short)436670109;
				short num2 = num;
				num = (short)896667293;
				switch (num2 == num)
				{
				}
				num = (short)1099563008;
				if (num != 0)
				{
				}
				num = (short)377880577;
				if (num != 0)
				{
				}
				num = (short)592183296;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.Applicable = value;
			}
		}

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x00AD5218 File Offset: 0x00AD3418
		// (set) Token: 0x0600BB04 RID: 47876 RVA: 0x00AD52D0 File Offset: 0x00AD34D0
		public bool CnvSysFeaturesSendLocationToPeer_42427_Valid
		{
			get
			{
				short num = (short)430201310;
				short num2 = num;
				num = (short)1100241374;
				switch (num2 == num)
				{
				}
				num = (short)1158152193;
				if (num != 0)
				{
				}
				num = (short)644153344;
				if (num != 0)
				{
				}
				num = (short)400687104;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.Valid;
			}
			set
			{
				short num = (short)1363860912;
				short num2 = num;
				num = (short)2078793136;
				switch (num2 == num)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				num = (short)71827456;
				if (num != 0)
				{
				}
				num = (short)1360396288;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.Valid = value;
			}
		}

		// Token: 0x17005DB6 RID: 23990
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x00AD5384 File Offset: 0x00AD3584
		// (set) Token: 0x0600BB06 RID: 47878 RVA: 0x00AD5438 File Offset: 0x00AD3638
		public bool CnvSysFeaturesSendLocationToPeer_42427_Visible
		{
			get
			{
				short num = (short)1597080898;
				short num2 = num;
				num = (short)1996588354;
				switch (num2 == num)
				{
				}
				num = (short)1420492801;
				if (num != 0)
				{
				}
				num = (short)1203699712;
				if (num != 0)
				{
				}
				num = (short)1130430464;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.Visible;
			}
			set
			{
				short num = (short)93222095;
				short num2 = num;
				num = (short)839349455;
				switch (num2 == num)
				{
				}
				num = (short)1392115713;
				if (num != 0)
				{
				}
				num = (short)1891827712;
				if (num != 0)
				{
				}
				num = (short)789250048;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.Visible = value;
			}
		}

		// Token: 0x17005DB7 RID: 23991
		// (get) Token: 0x0600BB07 RID: 47879 RVA: 0x00AD54EC File Offset: 0x00AD36EC
		// (set) Token: 0x0600BB08 RID: 47880 RVA: 0x00AD55A4 File Offset: 0x00AD37A4
		public bool CnvSysFeaturesSendLocationToPeer_42427_Editable
		{
			get
			{
				short num = (short)1475827840;
				short num2 = num;
				num = (short)750999680;
				switch (num2 == num)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)1666973696;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.Editable;
			}
			set
			{
				short num = (short)641443779;
				short num2 = num;
				num = (short)272672707;
				switch (num2 == num)
				{
				}
				num = (short)779747329;
				if (num != 0)
				{
				}
				num = (short)1646985216;
				if (num != 0)
				{
				}
				num = (short)1201471488;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.Editable = value;
			}
		}

		// Token: 0x17005DB8 RID: 23992
		// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x00AD565C File Offset: 0x00AD385C
		internal string CnvSysFeaturesSendLocationToPeer_42427_UILabel
		{
			get
			{
				short num = (short)1170019834;
				short num2 = num;
				num = (short)1694176762;
				switch (num2 == num)
				{
				}
				num = (short)516554753;
				if (num != 0)
				{
				}
				num = (short)543555584;
				if (num != 0)
				{
				}
				num = (short)1780285440;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.UIName;
			}
		}

		// Token: 0x17005DB9 RID: 23993
		// (get) Token: 0x0600BB0A RID: 47882 RVA: 0x00AD5710 File Offset: 0x00AD3910
		// (set) Token: 0x0600BB0B RID: 47883 RVA: 0x00AD57C0 File Offset: 0x00AD39C0
		internal bool CnvSysFeaturesSendLocationToPeer_42427_HiddenStatic
		{
			get
			{
				short num = (short)11158179;
				short num2 = num;
				num = (short)2112242339;
				switch (num2 == num)
				{
				}
				num = (short)1117061121;
				if (num != 0)
				{
				}
				num = (short)747044864;
				if (num != 0)
				{
				}
				num = (short)1522925568;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.HiddenStatic;
			}
			set
			{
				short num = (short)674234369;
				if (num != 0)
				{
				}
				num = (short)461125613;
				short num2 = num;
				num = (short)2020095981;
				switch (num2 == num)
				{
				}
				num = (short)958922752;
				if (num != 0)
				{
				}
				num = (short)262471680;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.HiddenStatic = value;
			}
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x00AD5878 File Offset: 0x00AD3A78
		// (set) Token: 0x0600BB0D RID: 47885 RVA: 0x00AD5930 File Offset: 0x00AD3B30
		internal bool CnvSysFeaturesSendLocationToPeer_42427_HiddenDynamic
		{
			get
			{
				short num = (short)1438285109;
				short num2 = num;
				num = (short)1466400053;
				switch (num2 == num)
				{
				}
				num = (short)1761607681;
				if (num != 0)
				{
				}
				num = (short)1281884160;
				if (num != 0)
				{
				}
				num = (short)1011548160;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427.HiddenDynamic;
			}
			set
			{
				short num = (short)2032926721;
				if (num != 0)
				{
				}
				num = (short)2133762770;
				short num2 = num;
				num = (short)1478337234;
				switch (num2 == num)
				{
				}
				num = (short)448397312;
				if (num != 0)
				{
				}
				num = (short)1580138496;
				short num3 = num;
				this.cnvSysFeaturesSendLocationToPeer_42427.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x00AD59E4 File Offset: 0x00AD3BE4
		public bool CnvSysFeaturesSendLocationToPeer_42427_HasDiffs
		{
			get
			{
				short num = (short)1405360346;
				short num2 = num;
				num = (short)740563162;
				switch (num2 == num)
				{
				}
				num = (short)344522753;
				if (num != 0)
				{
				}
				num = (short)1065877504;
				if (num != 0)
				{
				}
				num = (short)755499008;
				short num3 = num;
				return this.cnvSysFeaturesSendLocationToPeer_42427._HasDiffs;
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x00AD5A98 File Offset: 0x00AD3C98
		// (set) Token: 0x0600BB10 RID: 47888 RVA: 0x00AD5B50 File Offset: 0x00AD3D50
		public int CnvSysFeaturesGroupTMSEable_42809Value
		{
			get
			{
				short num = (short)1625784643;
				short num2 = num;
				num = (short)1327399235;
				switch (num2 == num)
				{
				}
				num = (short)2131165184;
				if (num != 0)
				{
				}
				num = (short)1016856577;
				if (num != 0)
				{
				}
				num = (short)1713307648;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.Value;
			}
			set
			{
				short num = (short)1285975971;
				short num2 = num;
				num = (short)828010403;
				switch (num2 == num)
				{
				}
				num = (short)2097741825;
				if (num != 0)
				{
				}
				num = (short)1627521024;
				if (num != 0)
				{
				}
				num = (short)865599488;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.Value = value;
			}
		}

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x0600BB11 RID: 47889 RVA: 0x00AD5C04 File Offset: 0x00AD3E04
		// (set) Token: 0x0600BB12 RID: 47890 RVA: 0x00AD5CB4 File Offset: 0x00AD3EB4
		public string CnvSysFeaturesGroupTMSEable_42809_UIValue
		{
			get
			{
				short num = (short)197455110;
				short num2 = num;
				num = (short)763161862;
				switch (num2 == num)
				{
				}
				num = (short)71958529;
				if (num != 0)
				{
				}
				num = (short)842596352;
				if (num != 0)
				{
				}
				num = (short)341180416;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.UIValue;
			}
			set
			{
				short num = (short)1976596544;
				short num2 = num;
				num = (short)2039380032;
				switch (num2 == num)
				{
				}
				num = (short)892141568;
				if (num != 0)
				{
				}
				num = (short)828243969;
				if (num != 0)
				{
				}
				num = (short)1429602304;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.UIValue = value;
			}
		}

		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x0600BB13 RID: 47891 RVA: 0x00AD5D6C File Offset: 0x00AD3F6C
		public global::AcpBusinessLayer.AcpListField CnvSysFeaturesGroupTMSEable_42809
		{
			get
			{
				short num = (short)684604474;
				short num2 = num;
				num = (short)64764986;
				switch (num2 == num)
				{
				}
				num = (short)228261889;
				if (num != 0)
				{
				}
				num = (short)1246167040;
				if (num != 0)
				{
				}
				num = (short)479002624;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809;
			}
		}

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x00AD5E18 File Offset: 0x00AD4018
		// (set) Token: 0x0600BB15 RID: 47893 RVA: 0x00AD5ED0 File Offset: 0x00AD40D0
		public bool CnvSysFeaturesGroupTMSEable_42809_Applicable
		{
			get
			{
				short num = (short)328150792;
				short num2 = num;
				num = (short)929378056;
				switch (num2 == num)
				{
				}
				num = (short)412090368;
				if (num != 0)
				{
				}
				num = (short)1008992257;
				if (num != 0)
				{
				}
				num = (short)1278935040;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.Applicable;
			}
			set
			{
				short num = (short)853475329;
				if (num != 0)
				{
				}
				num = (short)527936859;
				short num2 = num;
				num = (short)77376859;
				switch (num2 == num)
				{
				}
				num = (short)1629683712;
				if (num != 0)
				{
				}
				num = (short)814809088;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.Applicable = value;
			}
		}

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x00AD5F84 File Offset: 0x00AD4184
		// (set) Token: 0x0600BB17 RID: 47895 RVA: 0x00AD603C File Offset: 0x00AD423C
		public bool CnvSysFeaturesGroupTMSEable_42809_Valid
		{
			get
			{
				short num = (short)70868644;
				short num2 = num;
				num = (short)2033999524;
				switch (num2 == num)
				{
				}
				num = (short)325320704;
				if (num != 0)
				{
				}
				num = (short)484704257;
				if (num != 0)
				{
				}
				num = (short)135266304;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.Valid;
			}
			set
			{
				short num = (short)338881279;
				short num2 = num;
				num = (short)1858136831;
				switch (num2 == num)
				{
				}
				num = (short)1031143424;
				if (num != 0)
				{
				}
				num = (short)37486593;
				if (num != 0)
				{
				}
				num = (short)244318208;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.Valid = value;
			}
		}

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x00AD60F0 File Offset: 0x00AD42F0
		// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x00AD61A8 File Offset: 0x00AD43A8
		public bool CnvSysFeaturesGroupTMSEable_42809_Visible
		{
			get
			{
				short num = (short)482020747;
				short num2 = num;
				num = (short)480578955;
				switch (num2 == num)
				{
				}
				num = (short)1610219521;
				if (num != 0)
				{
				}
				num = (short)1092616192;
				if (num != 0)
				{
				}
				num = (short)2079522816;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.Visible;
			}
			set
			{
				short num = (short)31769230;
				short num2 = num;
				num = (short)1633862286;
				switch (num2 == num)
				{
				}
				num = (short)2058223616;
				if (num != 0)
				{
				}
				num = (short)1574436865;
				if (num != 0)
				{
				}
				num = (short)1652162560;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.Visible = value;
			}
		}

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x00AD6260 File Offset: 0x00AD4460
		// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x00AD6318 File Offset: 0x00AD4518
		public bool CnvSysFeaturesGroupTMSEable_42809_Editable
		{
			get
			{
				short num = (short)847246929;
				short num2 = num;
				num = (short)934344273;
				switch (num2 == num)
				{
				}
				num = (short)1534459905;
				if (num != 0)
				{
				}
				num = (short)153812992;
				if (num != 0)
				{
				}
				num = (short)306315264;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.Editable;
			}
			set
			{
				short num = (short)556728321;
				if (num != 0)
				{
				}
				num = (short)2126458038;
				short num2 = num;
				num = (short)1372007606;
				switch (num2 == num)
				{
				}
				num = (short)61341696;
				if (num != 0)
				{
				}
				num = (short)253427712;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.Editable = value;
			}
		}

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x00AD63D0 File Offset: 0x00AD45D0
		internal string CnvSysFeaturesGroupTMSEable_42809_UILabel
		{
			get
			{
				short num = (short)1941644310;
				short num2 = num;
				num = (short)1348281366;
				switch (num2 == num)
				{
				}
				num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1137901568;
				if (num != 0)
				{
				}
				num = (short)1989214208;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.UIName;
			}
		}

		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x0600BB1D RID: 47901 RVA: 0x00AD6484 File Offset: 0x00AD4684
		// (set) Token: 0x0600BB1E RID: 47902 RVA: 0x00AD6538 File Offset: 0x00AD4738
		internal bool CnvSysFeaturesGroupTMSEable_42809_HiddenStatic
		{
			get
			{
				short num = (short)2144468993;
				if (num != 0)
				{
				}
				num = (short)1571302282;
				short num2 = num;
				num = (short)1786522506;
				switch (num2 == num)
				{
				}
				num = (short)80936960;
				if (num != 0)
				{
				}
				num = (short)1830748160;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.HiddenStatic;
			}
			set
			{
				short num = (short)370016257;
				if (num != 0)
				{
				}
				num = (short)1266320677;
				short num2 = num;
				num = (short)750748965;
				switch (num2 == num)
				{
				}
				num = (short)1471217664;
				if (num != 0)
				{
				}
				num = (short)1431568384;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.HiddenStatic = value;
			}
		}

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0600BB1F RID: 47903 RVA: 0x00AD65EC File Offset: 0x00AD47EC
		// (set) Token: 0x0600BB20 RID: 47904 RVA: 0x00AD669C File Offset: 0x00AD489C
		internal bool CnvSysFeaturesGroupTMSEable_42809_HiddenDynamic
		{
			get
			{
				short num = (short)1978204161;
				if (num != 0)
				{
				}
				num = (short)346169653;
				short num2 = num;
				num = (short)1347297589;
				switch (num2 == num)
				{
				}
				num = (short)891355136;
				if (num != 0)
				{
				}
				num = (short)583794688;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809.HiddenDynamic;
			}
			set
			{
				short num = (short)1181696423;
				short num2 = num;
				num = (short)1621770663;
				switch (num2 == num)
				{
				}
				num = (short)298909697;
				if (num != 0)
				{
				}
				num = (short)1374355456;
				if (num != 0)
				{
				}
				num = (short)50724864;
				short num3 = num;
				this.cnvSysFeaturesGroupTMSEable_42809.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x0600BB21 RID: 47905 RVA: 0x00AD6754 File Offset: 0x00AD4954
		public bool CnvSysFeaturesGroupTMSEable_42809_HasDiffs
		{
			get
			{
				short num = (short)1999583242;
				short num2 = num;
				num = (short)351549450;
				switch (num2 == num)
				{
				}
				num = (short)1273102337;
				if (num != 0)
				{
				}
				num = (short)1193541632;
				if (num != 0)
				{
				}
				num = (short)1956577280;
				short num3 = num;
				return this.cnvSysFeaturesGroupTMSEable_42809._HasDiffs;
			}
		}

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x00AD680C File Offset: 0x00AD4A0C
		// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x00AD68C4 File Offset: 0x00AD4AC4
		public int CnvSysFeaturesPASelection_A42880Value
		{
			get
			{
				short num = (short)1699001581;
				short num2 = num;
				num = (short)1505998061;
				switch (num2 == num)
				{
				}
				num = (short)792592385;
				if (num != 0)
				{
				}
				num = (short)2000945152;
				if (num != 0)
				{
				}
				num = (short)444530688;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.Value;
			}
			set
			{
				short num = (short)268763137;
				if (num != 0)
				{
				}
				num = (short)708033431;
				short num2 = num;
				num = (short)682408855;
				switch (num2 == num)
				{
				}
				num = (short)1579679744;
				if (num != 0)
				{
				}
				num = (short)483065856;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.Value = value;
			}
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x00AD697C File Offset: 0x00AD4B7C
		// (set) Token: 0x0600BB25 RID: 47909 RVA: 0x00AD6A30 File Offset: 0x00AD4C30
		public string CnvSysFeaturesPASelection_A42880_UIValue
		{
			get
			{
				short num = (short)1289815282;
				short num2 = num;
				num = (short)1249838322;
				switch (num2 == num)
				{
				}
				num = (short)1888747521;
				if (num != 0)
				{
				}
				num = (short)838598656;
				if (num != 0)
				{
				}
				num = (short)1569914880;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.UIValue;
			}
			set
			{
				short num = (short)568785283;
				short num2 = num;
				num = (short)413530499;
				switch (num2 == num)
				{
				}
				num = (short)542310400;
				if (num != 0)
				{
				}
				num = (short)1378680833;
				if (num != 0)
				{
				}
				num = (short)520486912;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.UIValue = value;
			}
		}

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x00AD6AE4 File Offset: 0x00AD4CE4
		public global::AcpBusinessLayer.AcpRecRefField CnvSysFeaturesPASelection_A42880
		{
			get
			{
				short num = (short)497259856;
				short num2 = num;
				num = (short)965514576;
				switch (num2 == num)
				{
				}
				num = (short)2104033281;
				if (num != 0)
				{
				}
				num = (short)804192256;
				if (num != 0)
				{
				}
				num = (short)1943076864;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880;
			}
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x0600BB27 RID: 47911 RVA: 0x00AD6B94 File Offset: 0x00AD4D94
		// (set) Token: 0x0600BB28 RID: 47912 RVA: 0x00AD6C48 File Offset: 0x00AD4E48
		public bool CnvSysFeaturesPASelection_A42880_Applicable
		{
			get
			{
				short num = (short)1974982388;
				short num2 = num;
				num = (short)1676728052;
				switch (num2 == num)
				{
				}
				num = (short)1312948225;
				if (num != 0)
				{
				}
				num = (short)448724992;
				if (num != 0)
				{
				}
				num = (short)1100546048;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.Applicable;
			}
			set
			{
				short num = (short)1437587052;
				short num2 = num;
				num = (short)822990444;
				switch (num2 == num)
				{
				}
				num = (short)1451229185;
				if (num != 0)
				{
				}
				num = (short)488767488;
				if (num != 0)
				{
				}
				num = (short)430047232;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.Applicable = value;
			}
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x0600BB29 RID: 47913 RVA: 0x00AD6CFC File Offset: 0x00AD4EFC
		// (set) Token: 0x0600BB2A RID: 47914 RVA: 0x00AD6DB0 File Offset: 0x00AD4FB0
		public bool CnvSysFeaturesPASelection_A42880_Valid
		{
			get
			{
				short num = (short)1270546433;
				if (num != 0)
				{
				}
				num = (short)1088085775;
				short num2 = num;
				num = (short)1649991439;
				switch (num2 == num)
				{
				}
				num = (short)418447360;
				if (num != 0)
				{
				}
				num = (short)1770389504;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.Valid;
			}
			set
			{
				short num = (short)937295873;
				if (num != 0)
				{
				}
				num = (short)111146;
				short num2 = num;
				num = (short)1410970154;
				switch (num2 == num)
				{
				}
				num = (short)2108293120;
				if (num != 0)
				{
				}
				num = (short)1834352640;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.Valid = value;
			}
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x0600BB2B RID: 47915 RVA: 0x00AD6E64 File Offset: 0x00AD5064
		// (set) Token: 0x0600BB2C RID: 47916 RVA: 0x00AD6F14 File Offset: 0x00AD5114
		public bool CnvSysFeaturesPASelection_A42880_Visible
		{
			get
			{
				short num = (short)371458049;
				if (num != 0)
				{
				}
				num = (short)2113384572;
				short num2 = num;
				num = (short)2081403004;
				switch (num2 == num)
				{
				}
				num = (short)1604845568;
				if (num != 0)
				{
				}
				num = (short)1831272448;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.Visible;
			}
			set
			{
				short num = (short)1972360990;
				short num2 = num;
				num = (short)313251614;
				switch (num2 == num)
				{
				}
				num = (short)1704460288;
				if (num != 0)
				{
				}
				num = (short)1665335297;
				if (num != 0)
				{
				}
				num = (short)845414400;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.Visible = value;
			}
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x00AD6FC8 File Offset: 0x00AD51C8
		// (set) Token: 0x0600BB2E RID: 47918 RVA: 0x00AD707C File Offset: 0x00AD527C
		public bool CnvSysFeaturesPASelection_A42880_Editable
		{
			get
			{
				short num = (short)760916545;
				short num2 = num;
				num = (short)2032052801;
				switch (num2 == num)
				{
				}
				num = (short)96796673;
				if (num != 0)
				{
				}
				num = (short)303955968;
				if (num != 0)
				{
				}
				num = (short)3997696;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.Editable;
			}
			set
			{
				short num = (short)331467686;
				short num2 = num;
				num = (short)586075046;
				switch (num2 == num)
				{
				}
				num = (short)1291780097;
				if (num != 0)
				{
				}
				num = (short)43253760;
				if (num != 0)
				{
				}
				num = (short)395509760;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.Editable = value;
			}
		}

		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0600BB2F RID: 47919 RVA: 0x00AD7130 File Offset: 0x00AD5330
		internal string CnvSysFeaturesPASelection_A42880_UILabel
		{
			get
			{
				short num = (short)411959297;
				if (num != 0)
				{
				}
				num = (short)2121244992;
				short num2 = num;
				num = (short)1994236224;
				switch (num2 == num)
				{
				}
				num = (short)717094912;
				if (num != 0)
				{
				}
				num = (short)1238958080;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.UIName;
			}
		}

		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x00AD71E4 File Offset: 0x00AD53E4
		// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x00AD729C File Offset: 0x00AD549C
		internal bool CnvSysFeaturesPASelection_A42880_HiddenStatic
		{
			get
			{
				short num = (short)1569873121;
				short num2 = num;
				num = (short)590961889;
				switch (num2 == num)
				{
				}
				num = (short)1351548928;
				if (num != 0)
				{
				}
				num = (short)1556807681;
				if (num != 0)
				{
				}
				num = (short)1183252480;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.HiddenStatic;
			}
			set
			{
				short num = (short)910544945;
				short num2 = num;
				num = (short)249548849;
				switch (num2 == num)
				{
				}
				num = (short)1262878721;
				if (num != 0)
				{
				}
				num = (short)1290534912;
				if (num != 0)
				{
				}
				num = (short)1343881216;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.HiddenStatic = value;
			}
		}

		// Token: 0x17005DD0 RID: 24016
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x00AD7350 File Offset: 0x00AD5550
		// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x00AD7408 File Offset: 0x00AD5608
		internal bool CnvSysFeaturesPASelection_A42880_HiddenDynamic
		{
			get
			{
				short num = (short)1862620904;
				short num2 = num;
				num = (short)1987073768;
				switch (num2 == num)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				num = (short)1774649345;
				if (num != 0)
				{
				}
				num = (short)1753546752;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880.HiddenDynamic;
			}
			set
			{
				short num = (short)1741399045;
				short num2 = num;
				num = (short)1693230085;
				switch (num2 == num)
				{
				}
				num = (short)1249247232;
				if (num != 0)
				{
				}
				num = (short)1713963009;
				if (num != 0)
				{
				}
				num = (short)705953792;
				short num3 = num;
				this.cnvSysFeaturesPASelection_A42880.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DD1 RID: 24017
		// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x00AD74C0 File Offset: 0x00AD56C0
		public bool CnvSysFeaturesPASelection_A42880_HasDiffs
		{
			get
			{
				short num = (short)2002392097;
				short num2 = num;
				num = (short)124785697;
				switch (num2 == num)
				{
				}
				num = (short)245235713;
				if (num != 0)
				{
				}
				num = (short)258801664;
				if (num != 0)
				{
				}
				num = (short)582156288;
				short num3 = num;
				return this.cnvSysFeaturesPASelection_A42880._HasDiffs;
			}
		}

		// Token: 0x17005DD2 RID: 24018
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x00AD7578 File Offset: 0x00AD5778
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)2084888681;
				short num2 = num;
				num = (short)1877925993;
				switch (num2 == num)
				{
				}
				num = (short)880934913;
				if (num != 0)
				{
				}
				num = (short)1830617088;
				if (num != 0)
				{
				}
				num = (short)2080702464;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x00AD7634 File Offset: 0x00AD5834
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)721952090;
				short num2 = num;
				num = (short)1316887898;
				switch (num2 == num)
				{
				}
				num = (short)442368000;
				if (num != 0)
				{
				}
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)535756800;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x0600BB37 RID: 47927 RVA: 0x00AD76F4 File Offset: 0x00AD58F4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1859533600;
				short num2 = num;
				num = (short)1831484192;
				switch (num2 == num)
				{
				}
				num = (short)994050049;
				if (num != 0)
				{
				}
				num = (short)442957824;
				if (num != 0)
				{
				}
				num = (short)359727104;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x00AD77B0 File Offset: 0x00AD59B0
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1346871714;
				short num2 = num;
				num = (short)1168220578;
				switch (num2 == num)
				{
				}
				num = (short)1534590977;
				if (num != 0)
				{
				}
				num = (short)1525940224;
				if (num != 0)
				{
				}
				num = (short)845611008;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x0600BB39 RID: 47929 RVA: 0x00AD7870 File Offset: 0x00AD5A70
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)628817921;
				if (num != 0)
				{
				}
				num = (short)236528541;
				short num2 = num;
				num = (short)1162224541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697892864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1589837824;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x00AD7930 File Offset: 0x00AD5B30
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)977030226;
				short num2 = num;
				num = (short)909790290;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)334299136;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)572850176;
							short num4 = num;
							num = (short)543424514;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)1642594305;
						if (num != 0)
						{
						}
						goto IL_125;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1546649604;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)148111360;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D;
				}
				IL_125:
				num = (short)2028929027;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6D:
			result = null;
			num = (short)1124794369;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04005BF5 RID: 23541
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005BF6 RID: 23542
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005BF7 RID: 23543
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005BF8 RID: 23544
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005BF9 RID: 23545
		private global::AcpBusinessLayer.AcpListField cnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005BFA RID: 23546
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005BFB RID: 23547
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005BFC RID: 23548
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesMessage_A8497;

		// Token: 0x04005BFD RID: 23549
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005BFE RID: 23550
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005BFF RID: 23551
		private global::AcpBusinessLayer.AcpListField cnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005C00 RID: 23552
		private global::AcpBusinessLayer.AcpListField cnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005C01 RID: 23553
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesStatus_A9186;

		// Token: 0x04005C02 RID: 23554
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005C03 RID: 23555
		private global::AcpBusinessLayer.AcpListField dataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005C04 RID: 23556
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005C05 RID: 23557
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005C06 RID: 23558
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005C07 RID: 23559
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005C08 RID: 23560
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005C09 RID: 23561
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005C0A RID: 23562
		private global::AcpBusinessLayer.AcpListField cnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005C0B RID: 23563
		private global::AcpBusinessLayer.AcpRecRefField cnvSysFeaturesPASelection_A42880;
	}
}
