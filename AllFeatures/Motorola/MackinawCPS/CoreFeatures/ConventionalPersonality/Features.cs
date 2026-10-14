using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005BD RID: 1469
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C2D3 RID: 49875 RVA: 0x00B6F0A4 File Offset: 0x00B6D2A4
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x00B6F0C0 File Offset: 0x00B6D2C0
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x00B6F0D8 File Offset: 0x00B6D2D8
		public override void Init()
		{
			int a_ = 2;
			short num = (short)785973248;
			short num2 = num;
			num = (short)1166620192;
			short num3 = num;
			num = (short)577648160;
			switch (num3 == num)
			{
			}
			num = (short)1341390848;
			if (num != 0)
			{
			}
			num = (short)998178817;
			if (num != 0)
			{
			}
			this.cnvPerLabtoolAutomaticScan_A7527 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚鳜꫞闠賢裤蛦鷨苪軬볮鋰鋲鯴ꣶ룸쳺주췾㘀", a_), global::CommonResources.AcgResources.ID_SCANAUTOMATICSCAN);
			this.cnvPerLabtoolAutomaticScan_A7527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolAutomaticScan_A7527.DataTransferOrder = 71;
			this.cnvPerFeaturesFiregroundRegistration_A33242 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜駞裠釢胤胦鯨蓪飬臮闰ꇲ郴郶郸裺觼跾怀眂氄栆月吊䰌㰎∐ℒ℔┖", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYPERSONNELACCOUNTABILITYREGISTRATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesFiregroundRegistration_A33242LegacyTitles);
			this.cnvPerFeaturesFiregroundRegistration_A33242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesFiregroundRegistration_A33242.DataTransferOrder = 180;
			this.cnvPerLabtoolHotKeypad_A8208 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚關냞闠꣢胤黦駨諪觬냮냰쯲쟴쟶쇸", a_), global::CommonResources.AcgResources.ID_HOTKEYPAD);
			this.cnvPerLabtoolHotKeypad_A8208.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerLabtoolHotKeypad_A8208.DataTransferOrder = 85;
			this.cnvPerLabtoolOTACROTACSMessaging_A8663 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚鋜诞ꃠꃢ럤꣦뷨ꫪ껬볮볰雲蛴蓶飸鳺铼釾昀専䐄㼆㼈㴊㸌", a_), global::CommonResources.AcgResources.ID_OTACROTACSMESSAGING);
			this.cnvPerLabtoolOTACROTACSMessaging_A8663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolOTACROTACSMessaging_A8663.DataTransferOrder = 100;
			this.cnvPerLabtoolQuickKeyOverride_A8808 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚賜꫞裠胢軤곦賨鋪ꋬ駮铰臲蟴黶鷸黺ꋼ뻾㤀㬂㔄㼆", a_), global::CommonResources.AcgResources.ID_SMARTPTTQUICKKEYOVERRIDE);
			this.cnvPerLabtoolQuickKeyOverride_A8808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolQuickKeyOverride_A8808.DataTransferOrder = 89;
			this.cnvPerLabtoolScanListSelection_A9054 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚軜볞胠跢ꧤ軦髨鿪뻬諮鷰雲雴菶郸铺鏼ꃾ䀀㨂㔄㈆㴈", a_), global::CommonResources.AcgResources.ID_SCANSCANLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvPerLabtoolScanListSelection_A9054.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolScanListSelection_A9054.DataTransferOrder = 37;
			this.cnvPerLabtoolSmartPTTType_A9164 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌菎냐뇒ꇔ룖뛘럚軜닞胠釢釤럦뷨뿪맬雮臰雲ꫴ뛶샸쫺쯼쯾", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerLabtoolSmartPTTType_A9164LovStrs);
			this.cnvPerLabtoolSmartPTTType_A9164.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerLabtoolSmartPTTType_A9164.DataTransferOrder = 33;
			this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜连軠迢賤鏦賨꿪믬뷮ꋰ뫲鯴闶雸軺鏼鯾儀圂億唆氈稊砌樎成朒䨔⌖ⴘ√ⰜⰞ", a_), global::CommonResources.AcgResources.ID_POLITE_DVRS_INBOUND_PTT_REQUEST);
			this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.DataTransferOrder = 34;
			this.cnvPerTPSTPSUIEnable_A9400 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌鯎臐胒臔蟖諘軚铜髞迠苢蟤详賨듪곬훮연쏲열", a_), global::CommonResources.AcgResources.ID_TACTICALPUBLICSAFETYUIENABLE);
			this.cnvPerTPSTPSUIEnable_A9400.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerTPSTPSUIEnable_A9400.DataTransferOrder = 165;
			this.cnvPerFeaturesTxVoiceType_A9573 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜诞駠뗢諤軦諨軪맬雮臰雲ꫴ뛶샸컺쫼쳾", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYTXVOICETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeaturesTxVoiceType_A9573LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesTxVoiceType_A9573LegacyTitles);
			this.cnvPerFeaturesTxVoiceType_A9573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesTxVoiceType_A9573.DataTransferOrder = 182;
			this.cnvPerFeaturesTacticalRekeyEnable_A19309 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜诞胠胢釤軦諨諪臬뷮铰飲郴軶본闺鳼鷾洀昂娄䘆㠈㈊㸌㼎⠐", a_), global::CommonResources.AcgResources.ID_TACTICALREKEYENABLE);
			this.cnvPerFeaturesTacticalRekeyEnable_A19309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesTacticalRekeyEnable_A19309.DataTransferOrder = 46;
			this.cnvPerFeaturesMixedVoteScanEnable_A38723 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜鋞裠鯢胤菦뿨蓪駬諮ꋰ郲铴駶본闺鳼鷾洀昂娄䘆㨈㌊㨌㴎∐", a_), global::CommonResources.AcgResources.ID_SCANMIXEDVOTESCANENABLE);
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.DataTransferOrder = 160;
			this.cnvPerFeaturesMixedVoteScanTxSteering_A38878 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜鋞裠鯢胤菦뿨蓪駬諮ꋰ郲铴駶그菺껼课搀昂眄渆月氊刌与∐⬒ⴔ‖℘", a_), global::CommonResources.AcgResources.ID_SCANMIXEDVOTESCANTXSTEERING);
			this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.DataTransferOrder = 162;
			this.conPerFeatureIncidentSignalingType_A41507 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FiregroundFixupSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexConPerFeatureIncidentSignalingType_A41507LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idConPerFeatureIncidentSignalingType_A41507LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂꫄꧆駈껊뿌觎듐닒ꇔꋖꯘ뻚铜뇞苠諢臤苦蟨鿪뻬蛮雰鷲铴鯶郸闺髼꯾砀猂怄堆䠈㼊㰌㨎ℐ␒", a_), global::CommonResources.AcgResources.ID_INCIDENTSIGNALINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.ConPerFeatureIncidentSignalingType_A41507LovStrs);
			this.conPerFeatureIncidentSignalingType_A41507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.conPerFeatureIncidentSignalingType_A41507.DataTransferOrder = 178;
			this.conPerFeatureIncidentSignalingType_A41507.EvaluateRecRefs = true;
			this.cnvPerEndTxOnVoiceAbsence_42460 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌諎뿐럒臔꿖雘뗚诜냞裠胢胤ꛦ诨飪裬臮鋰雲ꫴ쏶쯸쿺쯼쿾", a_), global::CommonResources.AcgResources.ID_ENDTXONVOICEABSENCE);
			this.cnvPerEndTxOnVoiceAbsence_42460.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerEndTxOnVoiceAbsence_42460.DataTransferOrder = 166;
			this.cnvPerFeatureDTMFMicEn_A42481 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚駜诞고ꗢ꣤軦諨껪菬냮냰쟲쟴쏶쇸쫺", a_), global::CommonResources.AcgResources.ID_DTMFMICENABLE);
			this.cnvPerFeatureDTMFMicEn_A42481.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerFeatureDTMFMicEn_A42481.DataTransferOrder = 285;
			this.cnvPerFeatureRFModem_42485 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚远駞고賢臤苦蓨듪\ud9ec\uddee연쯲샴", a_), global::CommonResources.AcgResources.ID_RFMODEM, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeatureRFModem_42485LovStrs);
			this.cnvPerFeatureRFModem_42485.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeatureRFModem_42485.DataTransferOrder = 201;
			this.cnvPerFeaturesOTARadioAliasType_42784 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜郞뗠ꋢ럤蛦跨苪苬껮鷰髲铴蓶그苺跼髾帀㜂㜄〆ㄈ㼊", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeaturesOTARadioAliasType_42784LovStrs);
			this.cnvPerFeaturesOTARadioAliasType_42784.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerFeaturesOTARadioAliasType_42784.DataTransferOrder = 202;
			this.cnvPerFeaturesConvetionalRSSIDisplay_42785 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜鳞軠跢鏤苦鷨苪苬臮郰鿲ꟴꓶ꫸닺맼雾爀猂椄昆瀈吊㤌㴎☐⬒—", a_), global::CommonResources.AcgResources.ID_CONVENTIONALRSSIDISPLAY);
			this.cnvPerFeaturesConvetionalRSSIDisplay_42785.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerFeaturesConvetionalRSSIDisplay_42785.DataTransferOrder = 203;
			this.cnvPerFeaturesHazardZoneModePersonality = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜韞胠駢蓤闦跨뇪苬臮铰뻲髴鏶鳸꯺飼跾爀氂欄昆攈戊礌瘎", a_), global::CommonResources.AcgResources.ID_HAZARDZONEMODEPERSONALITY);
			this.cnvPerFeaturesHazardZoneModePersonality.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerFeaturesHazardZoneModePersonality.DataTransferOrder = 206;
			this.cnvPerFeaturesRSSIDisplayTimer_42786 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜跞닠냢곤ꏦ胨飪鷬菮郰諲ꇴ黶铸黺迼ꃾ㔀㄂㈄㼆㼈", a_), global::CommonResources.AcgResources.ID_RSSIDISPLAYTIMERSEC, 1, 255, null, null, 0, 1);
			this.cnvPerFeaturesRSSIDisplayTimer_42786.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerFeaturesRSSIDisplayTimer_42786.DataTransferOrder = 204;
			this.cnvPerFeaturesRSSIDisplayTimer_42786.ShowHexValue = false;
			this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆駈껊뿌觎듐닒ꇔꋖꯘ뻚껜郞뗠ꋢ럤蛦跨苪苬껮鷰髲铴蓶곸诺駼黾甀昂䀄椆栈椊愌樎丐划℔␖⤘⸚␜", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASUPDATEENABLE);
			this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.DataTransferOrder = 205;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藂ꃄꛆ뷈뻊뿌꫎ꋐ", a_);
			base.Id = 10135;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x00B6F734 File Offset: 0x00B6D934
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1364918308;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_349;
				case 1:
					this.cnvPerFeaturesRSSIDisplayTimer_42786 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟냡럣뗥ꇧ껩藫鷭胯黱闳迵곷鏹釻鯽狿崁〃㐅㼇㈉㨋", a_), global::CommonResources.AcgResources.ID_RSSIDISPLAYTIMERSEC, null, null, 0, 1);
					this.cnvPerFeaturesRSSIDisplayTimer_42786.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerFeaturesRSSIDisplayTimer_42786.DataTransferOrder = 204;
					this.cnvPerFeaturesRSSIDisplayTimer_42786.ShowHexValue = false;
					num = (short)319422479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_79C;
				case 3:
					goto IL_C33;
				case 4:
					goto IL_B86;
				case 5:
					goto IL_4E6;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝ꇟ韡郣觥藧诩飫蟭鏯ꇱ音韵雷ꗹ뷻짽㗿、㌃", a_)))
					{
						num = (short)1759379522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D36;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟냡럣뗥ꇧ껩藫鷭胯黱闳迵곷鏹釻鯽狿崁〃㐅㼇㈉㨋", a_)))
					{
						num = (short)1916469249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD8;
				case 8:
					goto IL_16C;
				case 9:
					this.cnvPerFeaturesHazardZoneModePersonality = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꫡ藣鳥觧飩裫듭鿯鳱釳믵韷黹駻껽旿瀁眃椅昇欉怋服搏欑", a_), global::CommonResources.AcgResources.ID_HAZARDZONEMODEPERSONALITY);
					this.cnvPerFeaturesHazardZoneModePersonality.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerFeaturesHazardZoneModePersonality.DataTransferOrder = 206;
					num = (short)1647902720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.cnvPerLabtoolSmartPTTType_A9164 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝돟迡藣铥鳧뫩룫뫭ꓯ诱蓳鏵ꟷ믹엻쿽㛿㘁", a_), global::CommonResources.AcgResources.ID_SMARTPTTSMARTPTTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerLabtoolSmartPTTType_A9164LovStrs);
					this.cnvPerLabtoolSmartPTTType_A9164.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerLabtoolSmartPTTType_A9164.DataTransferOrder = 33;
					num = (short)1619394629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_7E6;
				case 12:
					goto IL_9FC;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝꣟跡郣귥跧鏩鳫迭铯귱뗳컵쫷쫹쓻", a_)))
					{
						num = (short)240582706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A94;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝ꓟ뛡ꧣꃥꗧ菩迫꯭黯귱뗳싵쫷컹쓻쿽", a_)))
					{
						num = (short)2009727040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ED0;
				case 15:
					goto IL_DD8;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꇡ诣裥黧迩飫蟭鿯鳱闳髵꫷꧹꿻럽䓿欁眃瘅搇欉甋儍␏‑⌓⸕ⴗ", a_)))
					{
						num = (short)663027763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_445;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝꿟뛡ꗣꗥ뫧ꗩ룫꿭돯ꇱ맳鏵请觹鷻駽槿氁挃夅䤇㈉㨋㠍⌏", a_)))
					{
						num = (short)511377461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				case 18:
					if (producerFields != null)
					{
						num = (short)484835365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C6;
				case 19:
					this.cnvPerTPSTPSUIEnable_A9400 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑蓓藕賗諙进话꧟꟡諣蟥諧蛩觫뇭뇯쯱샳웵죷", a_), global::CommonResources.AcgResources.ID_TACTICALPUBLICSAFETYUIENABLE);
					this.cnvPerTPSTPSUIEnable_A9400.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerTPSTPSUIEnable_A9400.DataTransferOrder = 165;
					num = (short)872742923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.cnvPerFeaturesFiregroundRegistration_A33242 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꓡ跣铥跧跩黫臭藯鳱郳ꓵ鷷鷹闻跽瓿瀁攃爅愇攉戋儍儏ℑ✓␕Ⱇ⠙", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYPERSONNELACCOUNTABILITYREGISTRATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesFiregroundRegistration_A33242LegacyTitles);
					this.cnvPerFeaturesFiregroundRegistration_A33242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesFiregroundRegistration_A33242.DataTransferOrder = 180;
					num = (short)2020802589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟귡냣꟥뫧诩裫蟭鿯돱飳鿵駷觹ꧻ軽擿持瀃挅䴇搉洋氍簏眑䬓圕Ⱇ⤙Ⱋ⬝᤟", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASUPDATEENABLE);
					this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.DataTransferOrder = 205;
					num = (short)14548997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.conPerFeatureIncidentSignalingType_A41507 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FiregroundFixupSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexConPerFeatureIncidentSignalingType_A41507LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idConPerFeatureIncidentSignalingType_A41507LovStrs), this, global::AllFeatures.CodeplugGuid.b("藅Ꟈ꓉鳋ꯍꋏ铑뇓럕곗꿙껛믝꧟賡蟣迥賧迩苫髭ꏯ鯱鏳飵駷雹闻都柿嘁紃瘅洇唉䴋㨍ℏ✑␓ℕ", a_), global::CommonResources.AcgResources.ID_INCIDENTSIGNALINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.ConPerFeatureIncidentSignalingType_A41507LovStrs);
					this.conPerFeatureIncidentSignalingType_A41507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.conPerFeatureIncidentSignalingType_A41507.DataTransferOrder = 178;
					this.conPerFeatureIncidentSignalingType_A41507.EvaluateRecRefs = true;
					num = (short)108396574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					num = (short)1795795865;
					short num3 = num;
					num = (short)472034201;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64F;
					default:
						num = (short)1700986880;
						if (num != 0)
						{
						}
						goto IL_253;
					}
					break;
				}
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅Ꟈ꓉鳋ꯍꋏ铑뇓럕곗꿙껛믝꧟賡蟣迥賧迩苫髭ꏯ鯱鏳飵駷雹闻都柿嘁紃瘅洇唉䴋㨍ℏ✑␓ℕ", a_)))
					{
						num = (short)1063321622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1020;
				case 25:
					goto IL_A94;
				case 26:
					goto IL_C81;
				case 27:
					goto IL_F7C;
				case 28:
					this.cnvPerFeaturesTacticalRekeyEnable_A19309 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟뛡藣藥鳧菩迫迭鳯ꃱ釳鷵鷷菹맻都懿态栃挅圇䬉㴋㜍⌏∑ⴓ", a_), global::CommonResources.AcgResources.ID_TACTICALREKEYENABLE);
					this.cnvPerFeaturesTacticalRekeyEnable_A19309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesTacticalRekeyEnable_A19309.DataTransferOrder = 46;
					num = (short)1750007812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_2A2;
				case 30:
					goto IL_1020;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟뛡藣藥鳧菩迫迭鳯ꃱ釳鷵鷷菹맻都懿态栃挅圇䬉㴋㜍⌏∑ⴓ", a_)))
					{
						num = (short)1221656604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B86;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟귡냣꟥뫧诩裫蟭鿯돱飳鿵駷觹ꣻ蟽烿朁嬃㈅㨇㴉㐋㨍", a_)))
					{
						num = (short)266272815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_253;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟귡냣꟥뫧诩裫蟭鿯돱飳鿵駷觹ꧻ軽擿持瀃挅䴇搉洋氍簏眑䬓圕Ⱇ⤙Ⱋ⬝᤟", a_)))
					{
						num = (short)1576796181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C6;
				case 34:
					goto IL_D36;
				case 35:
					this.cnvPerEndTxOnVoiceAbsence_42460 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ韑뫓닕賗ꋙ鏛냝뛟跡跣藥跧ꯩ軫鷭闯鳱音鏵ꟷ컹컻쫽㛿㈁", a_), global::CommonResources.AcgResources.ID_ENDTXONVOICEABSENCE);
					this.cnvPerEndTxOnVoiceAbsence_42460.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerEndTxOnVoiceAbsence_42460.DataTransferOrder = 166;
					num = (short)703397896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					switch (0)
					{
					case 0:
						goto IL_145;
					}
					continue;
				case 37:
					num = (short)817496070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					this.cnvPerLabtoolQuickKeyOverride_A8808 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝뇟韡跣藥菧ꇩ觫韭뿯蓱釳蓵諷鏹飻鯽忿䌁㰃㸅㠇㈉", a_), global::CommonResources.AcgResources.ID_SMARTPTTQUICKKEYOVERRIDE);
					this.cnvPerLabtoolQuickKeyOverride_A8808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerLabtoolQuickKeyOverride_A8808.DataTransferOrder = 89;
					num = (short)554434608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					goto IL_445;
				case 40:
					num = (short)59834386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_206;
				case 42:
				{
					this.cnvPerFeatureRFModem_42485 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝닟ꓡꧣ觥賧迩臫뇭쓯샱샳컵췷", a_), global::CommonResources.AcgResources.ID_RFMODEM, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeatureRFModem_42485LovStrs);
					this.cnvPerFeatureRFModem_42485.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeatureRFModem_42485.DataTransferOrder = 201;
					num = (short)1066598400;
					short num4 = num;
					num = (short)1020657667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝닟ꓡꧣ觥賧迩臫뇭쓯샱샳컵췷", a_)))
					{
						num = (short)1998127146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C33;
				case 44:
					this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟닡诣諥臧黩觫ꫭꛯꃱꟳ뿵雷飹鏻诽滿昁吃刅將堉椋缍攏眑朓戕䜗⸙⠛✝ᄟᄡ", a_), global::CommonResources.AcgResources.ID_POLITE_DVRS_INBOUND_PTT_REQUEST);
					this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.DataTransferOrder = 34;
					num = (short)1092878338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟닡诣諥臧黩觫ꫭꛯꃱꟳ뿵雷飹鏻诽滿昁吃刅將堉椋缍攏眑朓戕䜗⸙⠛✝ᄟᄡ", a_)))
					{
						num = (short)816513068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79C;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꓡ跣铥跧跩黫臭藯鳱郳ꓵ鷷鷹闻跽瓿瀁攃爅愇攉戋儍儏ℑ✓␕Ⱇ⠙", a_)))
					{
						num = (short)1943666708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A2;
				case 47:
					this.cnvPerFeaturesOTARadioAliasType_42784 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟귡냣꟥뫧诩裫蟭鿯돱飳鿵駷觹ꣻ蟽烿朁嬃㈅㨇㴉㐋㨍", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeaturesOTARadioAliasType_42784LovStrs);
					this.cnvPerFeaturesOTARadioAliasType_42784.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerFeaturesOTARadioAliasType_42784.DataTransferOrder = 202;
					num = (short)1344733207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					goto IL_904;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟꿡跣黥跧軩뫫臭蓯韱ꟳ闵駷铹맻都懿态栃挅圇䬉㼋㘍✏‑✓", a_)))
					{
						num = (short)583073848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				case 50:
					this.cnvPerLabtoolHotKeypad_A8208 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝꣟跡郣귥跧鏩鳫迭铯귱뗳컵쫷쫹쓻", a_), global::CommonResources.AcgResources.ID_HOTKEYPAD);
					this.cnvPerLabtoolHotKeypad_A8208.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerLabtoolHotKeypad_A8208.DataTransferOrder = 85;
					num = (short)494469145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					this.cnvPerFeaturesConvetionalRSSIDisplay_42785 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꇡ诣裥黧迩飫蟭鿯鳱闳髵꫷꧹꿻럽䓿欁眃瘅搇欉甋儍␏‑⌓⸕ⴗ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALRSSIDISPLAY);
					this.cnvPerFeaturesConvetionalRSSIDisplay_42785.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerFeaturesConvetionalRSSIDisplay_42785.DataTransferOrder = 203;
					num = (short)531169319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					this.cnvPerFeaturesTxVoiceType_A9573 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟뛡鳣냥蟧菩迫语ꓯ诱蓳鏵ꟷ믹엻쯽㟿㄁", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYTXVOICETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerFeaturesTxVoiceType_A9573LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LegacyTitles.CnvPerFeaturesTxVoiceType_A9573LegacyTitles);
					this.cnvPerFeaturesTxVoiceType_A9573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesTxVoiceType_A9573.DataTransferOrder = 182;
					num = (short)759496730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					this.cnvPerLabtoolOTACROTACSMessaging_A8663 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝꿟뛡ꗣꗥ뫧ꗩ룫꿭돯ꇱ맳鏵请觹鷻駽槿氁挃夅䤇㈉㨋㠍⌏", a_), global::CommonResources.AcgResources.ID_OTACROTACSMESSAGING);
					this.cnvPerLabtoolOTACROTACSMessaging_A8663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerLabtoolOTACROTACSMessaging_A8663.DataTransferOrder = 100;
					num = (short)902955009;
					if (num != 0)
					{
					}
					num = (short)1648623657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝뇟韡跣藥菧ꇩ觫韭뿯蓱釳蓵諷鏹飻鯽忿䌁㰃㸅㠇㈉", a_)))
					{
						num = (short)417660966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_904;
				case 55:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ韑뫓닕賗ꋙ鏛냝뛟跡跣藥跧ꯩ軫鷭闯鳱音鏵ꟷ컹컻쫽㛿㈁", a_)))
					{
						num = (short)1911816227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C;
				case 56:
					this.cnvPerFeaturesMixedVoteScanEnable_A38723 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟꿡跣黥跧軩뫫臭蓯韱ꟳ闵駷铹맻都懿态栃挅圇䬉㼋㘍✏‑✓", a_), global::CommonResources.AcgResources.ID_SCANMIXEDVOTESCANENABLE);
					this.cnvPerFeaturesMixedVoteScanEnable_A38723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerFeaturesMixedVoteScanEnable_A38723.DataTransferOrder = 160;
					num = (short)109314111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟뛡鳣냥蟧菩迫语ꓯ诱蓳鏵ꟷ믹엻쯽㟿㄁", a_)))
					{
						num = (short)1195966516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C81;
				case 58:
					goto IL_64F;
				case 59:
					this.cnvPerFeaturesMixedVoteScanTxSteering_A38878 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟꿡跣黥跧軩뫫臭蓯韱ꟳ闵駷铹ꣻ蛽叿瘁愃挅稇按戋植伏匑✓⸕‗ⴙ␛", a_), global::CommonResources.AcgResources.ID_SCANMIXEDVOTESCANTXSTEERING);
					this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.DataTransferOrder = 162;
					num = (short)543752219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟꿡跣黥跧軩뫫臭蓯韱ꟳ闵駷铹ꣻ蛽叿瘁愃挅稇按戋植伏匑✓⸕‗ⴙ␛", a_)))
					{
						num = (short)2020278331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7C;
				case 61:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝鏟ꫡ藣鳥觧飩裫듭鿯鳱釳믵韷黹駻껽旿瀁眃椅昇欉怋服搏欑", a_)))
					{
						num = (short)30146569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_349;
				case 62:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝돟臡藣裥ꓧ菩鿫髭ꏯ韱飳鏵鯷軹闻釽滿崁䔃㼅㠇㼉㠋", a_)))
					{
						num = (short)1395916858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9FC;
				case 63:
					goto IL_1B9;
				case 64:
					this.cnvPerFeatureDTMFMicEn_A42481 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ铑뇓럕곗꿙껛믝ꓟ뛡ꧣꃥꗧ菩迫꯭黯귱뗳싵쫷컹쓻쿽", a_), global::CommonResources.AcgResources.ID_DTMFMICENABLE);
					this.cnvPerFeatureDTMFMicEn_A42481.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerFeatureDTMFMicEn_A42481.DataTransferOrder = 285;
					num = (short)1268383812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝돟迡藣铥鳧뫩룫뫭ꓯ诱蓳鏵ꟷ믹엻쿽㛿㘁", a_)))
					{
						num = (short)309395466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A45;
				case 66:
					this.cnvPerLabtoolAutomaticScan_A7527 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝ꇟ韡郣觥藧诩飫蟭鏯ꇱ音韵雷ꗹ뷻짽㗿、㌃", a_), global::CommonResources.AcgResources.ID_SCANAUTOMATICSCAN);
					this.cnvPerLabtoolAutomaticScan_A7527.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerLabtoolAutomaticScan_A7527.DataTransferOrder = 71;
					num = (short)1155924002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ蛑蓓藕賗諙进话꧟꟡諣蟥諧蛩觫뇭뇯쯱샳웵죷", a_)))
					{
						num = (short)1866334227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E6;
				case 68:
					goto IL_ED0;
				case 69:
					goto IL_A45;
				}
				IL_145:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)638124072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16C:
				num = (short)2050752526;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B9:
				num = (short)910098492;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_206:
				num = (short)1719926838;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_253:
				num = (short)869466128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A2:
				num = (short)1330511885;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_349:
				num = (short)285278215;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_445:
				num = (short)2076180541;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64F:
				this.cnvPerLabtoolScanListSelection_A9054 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ黑뗓듕곗뗙돛닝돟臡藣裥ꓧ菩鿫髭ꏯ韱飳鏵鯷軹闻釽滿崁䔃㼅㠇㼉㠋", a_), global::CommonResources.AcgResources.ID_SCANSCANLISTSELECTION, new string[]
				{
					global::CommonResources.AcgResources.ID_NONE
				}, new int[1], true, false);
				this.cnvPerLabtoolScanListSelection_A9054.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.cnvPerLabtoolScanListSelection_A9054.DataTransferOrder = 37;
				num = (short)1545207820;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_79C:
				num = (short)1054539843;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E6:
				num = (short)1159397433;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_904:
				num = (short)727384126;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9FC:
				num = (short)1336016961;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A45:
				num = (short)203489325;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A94:
				num = (short)1369243665;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B86:
				num = (short)420741169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C33:
				num = (short)1668612128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C81:
				num = (short)588644383;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D36:
				num = (short)1800863790;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DD8:
				num = (short)764674081;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ED0:
				num = (short)311951403;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F7C:
				num = (short)815923224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1020:
				num = (short)2030829623;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4E6:
			IL_10C6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胅귇ꯉ룋믍ꋏ럑ꟓ", a_);
			base.Id = 10135;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00B7083C File Offset: 0x00B6EA3C
		public override void PopulateReferences()
		{
			short num = (short)1107034112;
			short num2 = num;
			num = (short)271978081;
			short num3 = num;
			num = (short)982716001;
			switch (num3 == num)
			{
			}
			num = (short)2088370177;
			if (num != 0)
			{
			}
			num = (short)819200000;
			if (num != 0)
			{
			}
			this.cnvPerLabtoolScanListSelection_A9054.SetRecset(this.a(2057));
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x00B708FC File Offset: 0x00B6EAFC
		public override void DropReferences()
		{
			short num = (short)549584896;
			short num2 = num;
			num = (short)1671511145;
			short num3 = num;
			num = (short)299121769;
			switch (num3 == num)
			{
			}
			num = (short)2096758785;
			if (num != 0)
			{
			}
			num = (short)1668939776;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x00B709A4 File Offset: 0x00B6EBA4
		public override void SetConstraints()
		{
			short num = (short)129139896;
			short num2 = num;
			num = (short)827819192;
			switch (num2 == num)
			{
			}
			num = (short)1023475713;
			if (num != 0)
			{
			}
			num = (short)2055667712;
			short num3 = num;
			num = (short)187695104;
			if (num != 0)
			{
			}
			this.cnvPerLabtoolAutomaticScan_A7527.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerCnvPerScanMbrVctIndexIsNotNone);
			this.cnvPerLabtoolAutomaticScan_A7527.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conPerConventionalChannelOptionsUserSelectablePLMPLValid);
			this.cnvPerFeaturesFiregroundRegistration_A33242.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConFiregroundRegistrationIsApplicable);
			this.cnvPerFeaturesFiregroundRegistration_A33242.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConFiregroundRegistrationIsValid);
			this.cnvPerLabtoolHotKeypad_A8208.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerAstroVoiceTxModIsNotAstroAndCnvPerCnvRxOnlyIsDisable);
			this.cnvPerLabtoolOTACROTACSMessaging_A8663.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroGatingConstraintForOtacsMsg);
			this.cnvPerLabtoolOTACROTACSMessaging_A8663.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConOTACROTACSMessagingValid);
			this.cnvPerLabtoolQuickKeyOverride_A8808.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerCnvTxInhIsNotDisableAndCnvPerCnvRxOnlyIsDisable);
			this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.CnvPerFeaturesPoliteDVRSInboundPTTRequestApplicable);
			this.cnvPerLabtoolScanListSelection_A9054.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsCnvPerScanRecRefSelectionApp);
			this.cnvPerLabtoolScanListSelection_A9054.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsCnvPerScanRecRefSelectionValid);
			this.cnvPerLabtoolSmartPTTType_A9164.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsSmartPTTTypeApplicable);
			this.cnvPerFeaturesTxVoiceType_A9573.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxVoiceTypeIsApplicable);
			this.cnvPerFeaturesTxVoiceType_A9573.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxVoiceTypeIsValid);
			this.cnvPerFeaturesTacticalRekeyEnable_A19309.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSecureHardwareAndCnvPerAstroAndPacketDataNotDisabledAndOtarNotFullyConfigured);
			this.cnvPerFeaturesTacticalRekeyEnable_A19309.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvTacticalRekeyValidity);
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConMixCVScanSetFrqOptionsMax);
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSetMixedVoteScanEnValid);
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConMixedVoteScanEnabled);
			this.conPerFeatureIncidentSignalingType_A41507.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIncidentSignalingTypeIsValid);
			this.conPerFeatureIncidentSignalingType_A41507.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.conPerFeatureIncidentSignalingType_A41507.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIncidentSignalingTypeSetFiregroundSectorIDValue);
			this.cnvPerFeatureDTMFMicEn_A42481.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerAstroVoiceTxModIsNotAstroAndCnvPerCnvRxOnlyIsDisable);
			this.cnvPerFeatureRFModem_42485.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerRFModemApp);
			this.cnvPerFeatureRFModem_42485.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerRFModemValid);
			this.cnvPerFeatureRFModem_42485.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerFeaturesOTARadioAliasType_42784.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConOTARadAliasTypeIsValid);
			this.cnvPerFeaturesRSSIDisplayTimer_42786.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvRSSIDisplayIsEnabled);
			this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerOTARadioAliasUpdateEnableIsApp);
			this.cnvPerFeaturesHazardZoneModePersonality.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFeaturesHazardZoneModePersonalityIsValid);
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x00B70D18 File Offset: 0x00B6EF18
		public override void SetupDependencies()
		{
			short num = (short)642287513;
			short num2 = num;
			num = (short)695830425;
			switch (num2 == num)
			{
			}
			num = (short)892534785;
			if (num != 0)
			{
			}
			num = (short)2039611392;
			short num3 = num;
			num = (short)1208942592;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			this.cnvPerLabtoolScanListSelection_A9054.AddDependentObject(this.cnvPerLabtoolAutomaticScan_A7527);
			this.conPerFeatureIncidentSignalingType_A41507.AddDependentObject(this.cnvPerFeaturesFiregroundRegistration_A33242);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesFiregroundRegistration_A33242);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeaturesFiregroundRegistration_A33242);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerLabtoolHotKeypad_A8208);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerLabtoolHotKeypad_A8208);
			this.RefRadioInformation.Labtool.RadInfoLabtoolAstroAlertingOperHOption.AddDependentObject(this.cnvPerLabtoolHotKeypad_A8208);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerLabtoolHotKeypad_A8208);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolHotKeypad_A8208);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolOTACROTACSMessaging_A8663);
			this.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACRFeature_A8662.AddDependentObject(this.cnvPerLabtoolOTACROTACSMessaging_A8663);
			this.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACSFeature_A8667.AddDependentObject(this.cnvPerLabtoolOTACROTACSMessaging_A8663);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerLabtoolOTACROTACSMessaging_A8663);
			this.cnvPerLabtoolSmartPTTType_A9164.AddDependentObject(this.cnvPerLabtoolQuickKeyOverride_A8808);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerLabtoolQuickKeyOverride_A8808);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerLabtoolQuickKeyOverride_A8808);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolQuickKeyOverride_A8808);
			conventionalPersonality.Advanced.CnvPerAdvancedAnalogFlatAudio_A7443.AddDependentObject(this.cnvPerLabtoolScanListSelection_A9054);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolScanListSelection_A9054);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerLabtoolScanListSelection_A9054);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerLabtoolSmartPTTType_A9164);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerLabtoolSmartPTTType_A9164);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerLabtoolSmartPTTType_A9164);
			this.conPerFeatureIncidentSignalingType_A41507.AddDependentObject(this.cnvPerFeaturesTxVoiceType_A9573);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeaturesTxVoiceType_A9573);
			conventionalPersonality.ASTROCall.CnvPerASTROCallSelectiveCallRxTx_A9114.AddDependentObject(this.cnvPerFeaturesTxVoiceType_A9573);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerFeaturesTxVoiceType_A9573);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.Secure.CnvPerSecureOTARTx_A8675.AddDependentObject(this.cnvPerFeaturesTacticalRekeyEnable_A19309);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeaturesMixedVoteScanEnable_A38723);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesMixedVoteScanEnable_A38723);
			this.cnvPerFeaturesMixedVoteScanEnable_A38723.AddDependentObject(this.cnvPerFeaturesMixedVoteScanTxSteering_A38878);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.Secure.CnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.Secure.CnvPerSecureSecureClearStrapping2_A9091.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.ASTROCall.CnvPerASTROCallSelectiveCallRxTx_A9114.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.Phone.CnvPerPhonePhoneOperation_A8703.AddDependentObject(this.conPerFeatureIncidentSignalingType_A41507);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerFeatureDTMFMicEn_A42481);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerFeatureDTMFMicEn_A42481);
			this.RefRadioInformation.Labtool.RadInfoLabtoolAstroAlertingOperHOption.AddDependentObject(this.cnvPerFeatureDTMFMicEn_A42481);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeatureDTMFMicEn_A42481);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeatureDTMFMicEn_A42481);
			this.RefRadioWide.Features.RadWideAdvancedRFModem_A8972.AddDependentObject(this.cnvPerFeatureRFModem_42485);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerFeatureRFModem_42485);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cnvPerFeatureRFModem_42485);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeatureRFModem_42485);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeatureRFModem_42485);
			this.cnvPerFeaturesTxVoiceType_A9573.AddDependentObject(this.cnvPerFeaturesOTARadioAliasType_42784);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesOTARadioAliasType_42784);
			this.cnvPerFeaturesConvetionalRSSIDisplay_42785.AddDependentObject(this.cnvPerFeaturesRSSIDisplayTimer_42786);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059);
			this.cnvPerFeaturesOTARadioAliasType_42784.AddDependentObject(this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.AddDependentObject(this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			this.cnvPerFeaturesHazardZoneModePersonality.AddDependentObject(radioErgonomicsWide.HomeMode.HomeModeChannel);
		}

		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x0600C2DB RID: 49883 RVA: 0x00B713CC File Offset: 0x00B6F5CC
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList ScanListForCnvPerLabtoolScanListSelection_A9054
		{
			get
			{
				short num = (short)879689885;
				short num2 = num;
				num = (short)1330905245;
				switch (num2 == num)
				{
				}
				num = (short)679215105;
				if (num != 0)
				{
				}
				num = (short)657326080;
				short num3 = num;
				num = (short)1651376128;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
			}
		}

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x00B71488 File Offset: 0x00B6F688
		public bool HasDiffs
		{
			get
			{
				short num = (short)1661534209;
				if (num != 0)
				{
				}
				num = (short)129545785;
				short num2 = num;
				num = (short)1621669433;
				switch (num2 == num)
				{
				}
				num = (short)1212219392;
				short num3 = num;
				num = (short)112328704;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x0600C2DD RID: 49885 RVA: 0x00B71538 File Offset: 0x00B6F738
		// (set) Token: 0x0600C2DE RID: 49886 RVA: 0x00B715EC File Offset: 0x00B6F7EC
		public bool CnvPerLabtoolAutomaticScan_A7527Value
		{
			get
			{
				short num = (short)933232641;
				if (num != 0)
				{
				}
				num = (short)1726261134;
				short num2 = num;
				num = (short)1974904718;
				switch (num2 == num)
				{
				}
				num = (short)1099694080;
				short num3 = num;
				num = (short)398000128;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Value;
			}
			set
			{
				short num = (short)348520449;
				if (num != 0)
				{
				}
				num = (short)1491439773;
				short num2 = num;
				num = (short)1550815389;
				switch (num2 == num)
				{
				}
				num = (short)834142208;
				short num3 = num;
				num = (short)30081024;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Value = value;
			}
		}

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x0600C2DF RID: 49887 RVA: 0x00B716A4 File Offset: 0x00B6F8A4
		public global::AcpBusinessLayer.AcpField<bool> CnvPerLabtoolAutomaticScan_A7527
		{
			get
			{
				short num = (short)2114115236;
				short num2 = num;
				num = (short)1592252068;
				switch (num2 == num)
				{
				}
				num = (short)1167065089;
				if (num != 0)
				{
				}
				num = (short)1849688064;
				short num3 = num;
				num = (short)836829184;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527;
			}
		}

		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x0600C2E0 RID: 49888 RVA: 0x00B71754 File Offset: 0x00B6F954
		// (set) Token: 0x0600C2E1 RID: 49889 RVA: 0x00B7180C File Offset: 0x00B6FA0C
		public bool CnvPerLabtoolAutomaticScan_A7527_UIValue
		{
			get
			{
				short num = (short)259984227;
				short num2 = num;
				num = (short)657197923;
				switch (num2 == num)
				{
				}
				num = (short)1370161153;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				short num3 = num;
				num = (short)440598528;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Value;
			}
			set
			{
				short num = (short)863371265;
				if (num != 0)
				{
				}
				num = (short)1109108543;
				short num2 = num;
				num = (short)477734719;
				switch (num2 == num)
				{
				}
				num = (short)736886784;
				short num3 = num;
				num = (short)985595904;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Value = value;
			}
		}

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x00B718C4 File Offset: 0x00B6FAC4
		// (set) Token: 0x0600C2E3 RID: 49891 RVA: 0x00B7197C File Offset: 0x00B6FB7C
		public bool CnvPerLabtoolAutomaticScan_A7527_Applicable
		{
			get
			{
				short num = (short)174600120;
				short num2 = num;
				num = (short)1626156984;
				switch (num2 == num)
				{
				}
				num = (short)53542912;
				if (num != 0)
				{
				}
				num = (short)253689856;
				short num3 = num;
				num = (short)719585281;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Applicable;
			}
			set
			{
				short num = (short)853789433;
				short num2 = num;
				num = (short)851954425;
				switch (num2 == num)
				{
				}
				num = (short)1854406657;
				if (num != 0)
				{
				}
				num = (short)47972352;
				short num3 = num;
				num = (short)1892876288;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Applicable = value;
			}
		}

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x00B71A34 File Offset: 0x00B6FC34
		// (set) Token: 0x0600C2E5 RID: 49893 RVA: 0x00B71AE8 File Offset: 0x00B6FCE8
		public bool CnvPerLabtoolAutomaticScan_A7527_Valid
		{
			get
			{
				short num = (short)235414948;
				short num2 = num;
				num = (short)748496292;
				switch (num2 == num)
				{
				}
				num = (short)1023016961;
				if (num != 0)
				{
				}
				num = (short)349175808;
				short num3 = num;
				num = (short)2041249792;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Valid;
			}
			set
			{
				short num = (short)860291073;
				if (num != 0)
				{
				}
				num = (short)359200018;
				short num2 = num;
				num = (short)1264121106;
				switch (num2 == num)
				{
				}
				num = (short)139984896;
				short num3 = num;
				num = (short)1736507392;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Valid = value;
			}
		}

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x0600C2E6 RID: 49894 RVA: 0x00B71B9C File Offset: 0x00B6FD9C
		// (set) Token: 0x0600C2E7 RID: 49895 RVA: 0x00B71C54 File Offset: 0x00B6FE54
		public bool CnvPerLabtoolAutomaticScan_A7527_Visible
		{
			get
			{
				short num = (short)1477087307;
				short num2 = num;
				num = (short)1541443659;
				switch (num2 == num)
				{
				}
				num = (short)1964834816;
				if (num != 0)
				{
				}
				num = (short)1305608192;
				short num3 = num;
				num = (short)244187137;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Visible;
			}
			set
			{
				short num = (short)1754478862;
				short num2 = num;
				num = (short)1729771790;
				switch (num2 == num)
				{
				}
				num = (short)435355649;
				if (num != 0)
				{
				}
				num = (short)727842816;
				short num3 = num;
				num = (short)1083441152;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Visible = value;
			}
		}

		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x0600C2E8 RID: 49896 RVA: 0x00B71D08 File Offset: 0x00B6FF08
		// (set) Token: 0x0600C2E9 RID: 49897 RVA: 0x00B71DC0 File Offset: 0x00B6FFC0
		public bool CnvPerLabtoolAutomaticScan_A7527_Editable
		{
			get
			{
				short num = (short)935936223;
				short num2 = num;
				num = (short)1016217823;
				switch (num2 == num)
				{
				}
				num = (short)1962147841;
				if (num != 0)
				{
				}
				num = (short)379191296;
				short num3 = num;
				num = (short)682491904;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.Editable;
			}
			set
			{
				short num = (short)115736577;
				if (num != 0)
				{
				}
				num = (short)1647243084;
				short num2 = num;
				num = (short)780726092;
				switch (num2 == num)
				{
				}
				num = (short)1690828800;
				short num3 = num;
				num = (short)1604845568;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.Editable = value;
			}
		}

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x0600C2EA RID: 49898 RVA: 0x00B71E78 File Offset: 0x00B70078
		internal string CnvPerLabtoolAutomaticScan_A7527_UILabel
		{
			get
			{
				short num = (short)1490732942;
				short num2 = num;
				num = (short)584042382;
				switch (num2 == num)
				{
				}
				num = (short)553189376;
				if (num != 0)
				{
				}
				num = (short)123011072;
				short num3 = num;
				num = (short)1367867393;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.UIName;
			}
		}

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x0600C2EB RID: 49899 RVA: 0x00B71F2C File Offset: 0x00B7012C
		// (set) Token: 0x0600C2EC RID: 49900 RVA: 0x00B71FE0 File Offset: 0x00B701E0
		internal bool CnvPerLabtoolAutomaticScan_A7527_HiddenStatic
		{
			get
			{
				short num = (short)1228672107;
				short num2 = num;
				num = (short)1640041579;
				switch (num2 == num)
				{
				}
				num = (short)497287168;
				if (num != 0)
				{
				}
				num = (short)1745616896;
				short num3 = num;
				num = (short)200212481;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.HiddenStatic;
			}
			set
			{
				short num = (short)815805458;
				short num2 = num;
				num = (short)1579103250;
				switch (num2 == num)
				{
				}
				num = (short)826408961;
				if (num != 0)
				{
				}
				num = (short)1193410560;
				short num3 = num;
				num = (short)1344995328;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.HiddenStatic = value;
			}
		}

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x0600C2ED RID: 49901 RVA: 0x00B72098 File Offset: 0x00B70298
		// (set) Token: 0x0600C2EE RID: 49902 RVA: 0x00B7214C File Offset: 0x00B7034C
		internal bool CnvPerLabtoolAutomaticScan_A7527_HiddenDynamic
		{
			get
			{
				short num = (short)1718910651;
				short num2 = num;
				num = (short)275152571;
				switch (num2 == num)
				{
				}
				num = (short)1521614848;
				if (num != 0)
				{
				}
				num = (short)20840448;
				short num3 = num;
				num = (short)634781697;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527.HiddenDynamic;
			}
			set
			{
				short num = (short)274017456;
				short num2 = num;
				num = (short)2119511216;
				switch (num2 == num)
				{
				}
				num = (short)496566272;
				if (num != 0)
				{
				}
				num = (short)1669791744;
				short num3 = num;
				num = (short)273350657;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolAutomaticScan_A7527.HiddenDynamic = value;
			}
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x0600C2EF RID: 49903 RVA: 0x00B72200 File Offset: 0x00B70400
		public bool CnvPerLabtoolAutomaticScan_A7527_HasDiffs
		{
			get
			{
				short num = (short)1913958212;
				short num2 = num;
				num = (short)951955268;
				switch (num2 == num)
				{
				}
				num = (short)1265303552;
				if (num != 0)
				{
				}
				num = (short)1489305600;
				short num3 = num;
				num = (short)296484865;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolAutomaticScan_A7527._HasDiffs;
			}
		}

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x00B722B4 File Offset: 0x00B704B4
		// (set) Token: 0x0600C2F1 RID: 49905 RVA: 0x00B7236C File Offset: 0x00B7056C
		public bool CnvPerFeaturesFiregroundRegistration_A33242Value
		{
			get
			{
				short num = (short)894085167;
				short num2 = num;
				num = (short)1900062767;
				switch (num2 == num)
				{
				}
				num = (short)1430126593;
				if (num != 0)
				{
				}
				num = (short)1860108288;
				short num3 = num;
				num = (short)1685520384;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Value;
			}
			set
			{
				short num = (short)1338171432;
				short num2 = num;
				num = (short)1444012072;
				switch (num2 == num)
				{
				}
				num = (short)1413021697;
				if (num != 0)
				{
				}
				num = (short)479657984;
				short num3 = num;
				num = (short)607387648;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Value = value;
			}
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x0600C2F2 RID: 49906 RVA: 0x00B72420 File Offset: 0x00B70620
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesFiregroundRegistration_A33242
		{
			get
			{
				short num = (short)1463687725;
				short num2 = num;
				num = (short)1249581613;
				switch (num2 == num)
				{
				}
				num = (short)1182400513;
				if (num != 0)
				{
				}
				num = (short)1292304384;
				short num3 = num;
				num = (short)463667200;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242;
			}
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x0600C2F3 RID: 49907 RVA: 0x00B724D0 File Offset: 0x00B706D0
		// (set) Token: 0x0600C2F4 RID: 49908 RVA: 0x00B72584 File Offset: 0x00B70784
		public bool CnvPerFeaturesFiregroundRegistration_A33242_UIValue
		{
			get
			{
				short num = (short)1290482484;
				short num2 = num;
				num = (short)479671092;
				switch (num2 == num)
				{
				}
				num = (short)940441601;
				if (num != 0)
				{
				}
				num = (short)1422458880;
				short num3 = num;
				num = (short)1611137024;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Value;
			}
			set
			{
				short num = (short)988552471;
				short num2 = num;
				num = (short)563813655;
				switch (num2 == num)
				{
				}
				num = (short)1888813057;
				if (num != 0)
				{
				}
				num = (short)34340864;
				short num3 = num;
				num = (short)1975910400;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Value = value;
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x0600C2F5 RID: 49909 RVA: 0x00B72638 File Offset: 0x00B70838
		// (set) Token: 0x0600C2F6 RID: 49910 RVA: 0x00B726F0 File Offset: 0x00B708F0
		public bool CnvPerFeaturesFiregroundRegistration_A33242_Applicable
		{
			get
			{
				short num = (short)211877889;
				if (num != 0)
				{
				}
				num = (short)2011702960;
				short num2 = num;
				num = (short)1607280304;
				switch (num2 == num)
				{
				}
				num = (short)1961361408;
				short num3 = num;
				num = (short)631111680;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Applicable;
			}
			set
			{
				short num = (short)725510307;
				short num2 = num;
				num = (short)1441949859;
				switch (num2 == num)
				{
				}
				num = (short)1660354561;
				if (num != 0)
				{
				}
				num = (short)832045056;
				short num3 = num;
				num = (short)223739904;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Applicable = value;
			}
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x0600C2F7 RID: 49911 RVA: 0x00B727A4 File Offset: 0x00B709A4
		// (set) Token: 0x0600C2F8 RID: 49912 RVA: 0x00B7285C File Offset: 0x00B70A5C
		public bool CnvPerFeaturesFiregroundRegistration_A33242_Valid
		{
			get
			{
				short num = (short)335806465;
				if (num != 0)
				{
				}
				num = (short)1996171613;
				short num2 = num;
				num = (short)412100957;
				switch (num2 == num)
				{
				}
				num = (short)69009408;
				short num3 = num;
				num = (short)626589696;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Valid;
			}
			set
			{
				short num = (short)372665196;
				short num2 = num;
				num = (short)1002269548;
				switch (num2 == num)
				{
				}
				num = (short)1850998785;
				if (num != 0)
				{
				}
				num = (short)596115456;
				short num3 = num;
				num = (short)346423296;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Valid = value;
			}
		}

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x0600C2F9 RID: 49913 RVA: 0x00B72914 File Offset: 0x00B70B14
		// (set) Token: 0x0600C2FA RID: 49914 RVA: 0x00B729C8 File Offset: 0x00B70BC8
		public bool CnvPerFeaturesFiregroundRegistration_A33242_Visible
		{
			get
			{
				short num = (short)1775214127;
				short num2 = num;
				num = (short)419470895;
				switch (num2 == num)
				{
				}
				num = (short)723910657;
				if (num != 0)
				{
				}
				num = (short)2077687808;
				short num3 = num;
				num = (short)1080295424;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Visible;
			}
			set
			{
				short num = (short)220404244;
				short num2 = num;
				num = (short)1423710740;
				switch (num2 == num)
				{
				}
				num = (short)956956673;
				if (num != 0)
				{
				}
				num = (short)677117952;
				short num3 = num;
				num = (short)1121517568;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Visible = value;
			}
		}

		// Token: 0x17006182 RID: 24962
		// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x00B72A7C File Offset: 0x00B70C7C
		// (set) Token: 0x0600C2FC RID: 49916 RVA: 0x00B72B30 File Offset: 0x00B70D30
		public bool CnvPerFeaturesFiregroundRegistration_A33242_Editable
		{
			get
			{
				short num = (short)960757761;
				if (num != 0)
				{
				}
				num = (short)1285045042;
				short num2 = num;
				num = (short)357317426;
				switch (num2 == num)
				{
				}
				num = (short)1840185344;
				short num3 = num;
				num = (short)1146748928;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.Editable;
			}
			set
			{
				short num = (short)1830092801;
				if (num != 0)
				{
				}
				num = (short)1068117880;
				short num2 = num;
				num = (short)1386098552;
				switch (num2 == num)
				{
				}
				num = (short)1456340992;
				short num3 = num;
				num = (short)1912537088;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.Editable = value;
			}
		}

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x00B72BE4 File Offset: 0x00B70DE4
		internal string CnvPerFeaturesFiregroundRegistration_A33242_UILabel
		{
			get
			{
				short num = (short)1900521907;
				short num2 = num;
				num = (short)1681500595;
				switch (num2 == num)
				{
				}
				num = (short)786432;
				if (num != 0)
				{
				}
				num = (short)1422589952;
				short num3 = num;
				num = (short)346030081;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.UIName;
			}
		}

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x0600C2FE RID: 49918 RVA: 0x00B72C98 File Offset: 0x00B70E98
		// (set) Token: 0x0600C2FF RID: 49919 RVA: 0x00B72D54 File Offset: 0x00B70F54
		internal bool CnvPerFeaturesFiregroundRegistration_A33242_HiddenStatic
		{
			get
			{
				short num = (short)1080663934;
				short num2 = num;
				num = (short)1268162430;
				switch (num2 == num)
				{
				}
				num = (short)1132658689;
				if (num != 0)
				{
				}
				num = (short)129957888;
				short num3 = num;
				num = (short)791478272;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.HiddenStatic;
			}
			set
			{
				short num = (short)249900674;
				short num2 = num;
				num = (short)177811074;
				switch (num2 == num)
				{
				}
				num = (short)1034223617;
				if (num != 0)
				{
				}
				num = (short)446693376;
				short num3 = num;
				num = (short)891486208;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.HiddenStatic = value;
			}
		}

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x0600C300 RID: 49920 RVA: 0x00B72E0C File Offset: 0x00B7100C
		// (set) Token: 0x0600C301 RID: 49921 RVA: 0x00B72EC0 File Offset: 0x00B710C0
		internal bool CnvPerFeaturesFiregroundRegistration_A33242_HiddenDynamic
		{
			get
			{
				short num = (short)1659717649;
				short num2 = num;
				num = (short)1806190609;
				switch (num2 == num)
				{
				}
				num = (short)158728192;
				if (num != 0)
				{
				}
				num = (short)1700069376;
				short num3 = num;
				num = (short)1399259137;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242.HiddenDynamic;
			}
			set
			{
				short num = (short)2030602323;
				short num2 = num;
				num = (short)254773331;
				switch (num2 == num)
				{
				}
				num = (short)922812417;
				if (num != 0)
				{
				}
				num = (short)1574371328;
				short num3 = num;
				num = (short)51511296;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesFiregroundRegistration_A33242.HiddenDynamic = value;
			}
		}

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x0600C302 RID: 49922 RVA: 0x00B72F74 File Offset: 0x00B71174
		public bool CnvPerFeaturesFiregroundRegistration_A33242_HasDiffs
		{
			get
			{
				short num = (short)1884880614;
				short num2 = num;
				num = (short)1050541798;
				switch (num2 == num)
				{
				}
				num = (short)1166802945;
				if (num != 0)
				{
				}
				num = (short)393936896;
				short num3 = num;
				num = (short)1220280320;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesFiregroundRegistration_A33242._HasDiffs;
			}
		}

		// Token: 0x17006187 RID: 24967
		// (get) Token: 0x0600C303 RID: 49923 RVA: 0x00B73028 File Offset: 0x00B71228
		// (set) Token: 0x0600C304 RID: 49924 RVA: 0x00B730DC File Offset: 0x00B712DC
		public bool CnvPerLabtoolHotKeypad_A8208Value
		{
			get
			{
				short num = (short)158859265;
				if (num != 0)
				{
				}
				num = (short)610782722;
				short num2 = num;
				num = (short)1970064898;
				switch (num2 == num)
				{
				}
				num = (short)534183936;
				short num3 = num;
				num = (short)302710784;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Value;
			}
			set
			{
				short num = (short)1815614133;
				short num2 = num;
				num = (short)899355317;
				switch (num2 == num)
				{
				}
				num = (short)1005846529;
				if (num != 0)
				{
				}
				num = (short)394985472;
				short num3 = num;
				num = (short)1085997056;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Value = value;
			}
		}

		// Token: 0x17006188 RID: 24968
		// (get) Token: 0x0600C305 RID: 49925 RVA: 0x00B73190 File Offset: 0x00B71390
		public global::AcpBusinessLayer.AcpField<bool> CnvPerLabtoolHotKeypad_A8208
		{
			get
			{
				short num = (short)1980172512;
				short num2 = num;
				num = (short)1075185888;
				switch (num2 == num)
				{
				}
				num = (short)2063335425;
				if (num != 0)
				{
				}
				num = (short)376635392;
				short num3 = num;
				num = (short)1099563008;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208;
			}
		}

		// Token: 0x17006189 RID: 24969
		// (get) Token: 0x0600C306 RID: 49926 RVA: 0x00B7323C File Offset: 0x00B7143C
		// (set) Token: 0x0600C307 RID: 49927 RVA: 0x00B732F0 File Offset: 0x00B714F0
		public bool CnvPerLabtoolHotKeypad_A8208_UIValue
		{
			get
			{
				short num = (short)773866245;
				short num2 = num;
				num = (short)2053915397;
				switch (num2 == num)
				{
				}
				num = (short)258932736;
				if (num != 0)
				{
				}
				num = (short)768344064;
				short num3 = num;
				num = (short)524615681;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Value;
			}
			set
			{
				short num = (short)2107070553;
				short num2 = num;
				num = (short)1518295129;
				switch (num2 == num)
				{
				}
				num = (short)43450369;
				if (num != 0)
				{
				}
				num = (short)168361984;
				short num3 = num;
				num = (short)749993984;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Value = value;
			}
		}

		// Token: 0x1700618A RID: 24970
		// (get) Token: 0x0600C308 RID: 49928 RVA: 0x00B733A8 File Offset: 0x00B715A8
		// (set) Token: 0x0600C309 RID: 49929 RVA: 0x00B7345C File Offset: 0x00B7165C
		public bool CnvPerLabtoolHotKeypad_A8208_Applicable
		{
			get
			{
				short num = (short)1050154299;
				short num2 = num;
				num = (short)1431246139;
				switch (num2 == num)
				{
				}
				num = (short)555417600;
				if (num != 0)
				{
				}
				num = (short)1717567488;
				short num3 = num;
				num = (short)1736179713;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Applicable;
			}
			set
			{
				short num = (short)89653249;
				if (num != 0)
				{
				}
				num = (short)62382849;
				short num2 = num;
				num = (short)1533731585;
				switch (num2 == num)
				{
				}
				num = (short)544866304;
				short num3 = num;
				num = (short)3538944;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Applicable = value;
			}
		}

		// Token: 0x1700618B RID: 24971
		// (get) Token: 0x0600C30A RID: 49930 RVA: 0x00B73510 File Offset: 0x00B71710
		// (set) Token: 0x0600C30B RID: 49931 RVA: 0x00B735C0 File Offset: 0x00B717C0
		public bool CnvPerLabtoolHotKeypad_A8208_Valid
		{
			get
			{
				short num = (short)1610620904;
				short num2 = num;
				num = (short)463478760;
				switch (num2 == num)
				{
				}
				num = (short)400424961;
				if (num != 0)
				{
				}
				num = (short)1714749440;
				short num3 = num;
				num = (short)1581711360;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Valid;
			}
			set
			{
				short num = (short)947519489;
				if (num != 0)
				{
				}
				num = (short)1855547196;
				short num2 = num;
				num = (short)1988650812;
				switch (num2 == num)
				{
				}
				num = (short)1700528128;
				short num3 = num;
				num = (short)1295712256;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Valid = value;
			}
		}

		// Token: 0x1700618C RID: 24972
		// (get) Token: 0x0600C30C RID: 49932 RVA: 0x00B73674 File Offset: 0x00B71874
		// (set) Token: 0x0600C30D RID: 49933 RVA: 0x00B7372C File Offset: 0x00B7192C
		public bool CnvPerLabtoolHotKeypad_A8208_Visible
		{
			get
			{
				short num = (short)1104674817;
				if (num != 0)
				{
				}
				num = (short)856780434;
				short num2 = num;
				num = (short)957640338;
				switch (num2 == num)
				{
				}
				num = (short)235864064;
				short num3 = num;
				num = (short)273874944;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Visible;
			}
			set
			{
				short num = (short)631938862;
				short num2 = num;
				num = (short)324902702;
				switch (num2 == num)
				{
				}
				num = (short)87556097;
				if (num != 0)
				{
				}
				num = (short)1115422720;
				short num3 = num;
				num = (short)179044352;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Visible = value;
			}
		}

		// Token: 0x1700618D RID: 24973
		// (get) Token: 0x0600C30E RID: 49934 RVA: 0x00B737E0 File Offset: 0x00B719E0
		// (set) Token: 0x0600C30F RID: 49935 RVA: 0x00B73894 File Offset: 0x00B71A94
		public bool CnvPerLabtoolHotKeypad_A8208_Editable
		{
			get
			{
				short num = (short)846462977;
				if (num != 0)
				{
				}
				num = (short)1785331712;
				short num2 = num;
				num = (short)1636162126;
				short num3 = num;
				num = (short)1061214798;
				switch (num3 == num)
				{
				}
				num = (short)1995636736;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.Editable;
			}
			set
			{
				short num = (short)1504624046;
				short num2 = num;
				num = (short)1676066222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2143748096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)408158208;
				if (num != 0)
				{
				}
				num = (short)8716289;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.Editable = value;
			}
		}

		// Token: 0x1700618E RID: 24974
		// (get) Token: 0x0600C310 RID: 49936 RVA: 0x00B73948 File Offset: 0x00B71B48
		internal string CnvPerLabtoolHotKeypad_A8208_UILabel
		{
			get
			{
				short num = (short)658331656;
				short num2 = num;
				num = (short)2029017096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)935002112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507196928;
				if (num != 0)
				{
				}
				num = (short)113901569;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.UIName;
			}
		}

		// Token: 0x1700618F RID: 24975
		// (get) Token: 0x0600C311 RID: 49937 RVA: 0x00B739FC File Offset: 0x00B71BFC
		// (set) Token: 0x0600C312 RID: 49938 RVA: 0x00B73AB0 File Offset: 0x00B71CB0
		internal bool CnvPerLabtoolHotKeypad_A8208_HiddenStatic
		{
			get
			{
				short num = (short)1962661973;
				short num2 = num;
				num = (short)1122621525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274530304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726204417;
				if (num != 0)
				{
				}
				num = (short)872480768;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.HiddenStatic;
			}
			set
			{
				short num = (short)1573345390;
				short num2 = num;
				num = (short)588929134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1538195456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1152974848;
				if (num != 0)
				{
				}
				num = (short)614858753;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.HiddenStatic = value;
			}
		}

		// Token: 0x17006190 RID: 24976
		// (get) Token: 0x0600C313 RID: 49939 RVA: 0x00B73B64 File Offset: 0x00B71D64
		// (set) Token: 0x0600C314 RID: 49940 RVA: 0x00B73C1C File Offset: 0x00B71E1C
		internal bool CnvPerLabtoolHotKeypad_A8208_HiddenDynamic
		{
			get
			{
				short num = (short)1409799697;
				short num2 = num;
				num = (short)1038013969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901395968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136314881;
				if (num != 0)
				{
				}
				num = (short)2020868096;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208.HiddenDynamic;
			}
			set
			{
				short num = (short)843418977;
				short num2 = num;
				num = (short)611159393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2069757952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1639514113;
				if (num != 0)
				{
				}
				num = (short)1382744064;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolHotKeypad_A8208.HiddenDynamic = value;
			}
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x0600C315 RID: 49941 RVA: 0x00B73CD0 File Offset: 0x00B71ED0
		public bool CnvPerLabtoolHotKeypad_A8208_HasDiffs
		{
			get
			{
				short num = (short)1663458664;
				short num2 = num;
				num = (short)1030905192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)560005120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)503382017;
				if (num != 0)
				{
				}
				num = (short)1376256000;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolHotKeypad_A8208._HasDiffs;
			}
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x0600C316 RID: 49942 RVA: 0x00B73D88 File Offset: 0x00B71F88
		// (set) Token: 0x0600C317 RID: 49943 RVA: 0x00B73E3C File Offset: 0x00B7203C
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663Value
		{
			get
			{
				short num = (short)86900737;
				if (num != 0)
				{
				}
				num = (short)418709504;
				short num2 = num;
				num = (short)889764237;
				short num3 = num;
				num = (short)344177037;
				switch (num3 == num)
				{
				}
				num = (short)1579876352;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Value;
			}
			set
			{
				short num = (short)921101490;
				short num2 = num;
				num = (short)1424024754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007616000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)374996993;
				if (num != 0)
				{
				}
				num = (short)1177681920;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Value = value;
			}
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x0600C318 RID: 49944 RVA: 0x00B73EF4 File Offset: 0x00B720F4
		public global::AcpBusinessLayer.AcpField<bool> CnvPerLabtoolOTACROTACSMessaging_A8663
		{
			get
			{
				short num = (short)2134982300;
				short num2 = num;
				num = (short)1840856732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33751040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264765441;
				if (num != 0)
				{
				}
				num = (short)1240137728;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663;
			}
		}

		// Token: 0x17006194 RID: 24980
		// (get) Token: 0x0600C319 RID: 49945 RVA: 0x00B73FA4 File Offset: 0x00B721A4
		// (set) Token: 0x0600C31A RID: 49946 RVA: 0x00B7405C File Offset: 0x00B7225C
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_UIValue
		{
			get
			{
				short num = (short)481101402;
				short num2 = num;
				num = (short)2065958490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914685952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1270415361;
				if (num != 0)
				{
				}
				num = (short)1773993984;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Value;
			}
			set
			{
				short num = (short)13828097;
				if (num != 0)
				{
				}
				num = (short)93454336;
				short num2 = num;
				num = (short)89546637;
				short num3 = num;
				num = (short)1459576717;
				switch (num3 == num)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Value = value;
			}
		}

		// Token: 0x17006195 RID: 24981
		// (get) Token: 0x0600C31B RID: 49947 RVA: 0x00B74114 File Offset: 0x00B72314
		// (set) Token: 0x0600C31C RID: 49948 RVA: 0x00B741C8 File Offset: 0x00B723C8
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_Applicable
		{
			get
			{
				short num = (short)2098169717;
				short num2 = num;
				num = (short)1829865333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299775488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1790246913;
				if (num != 0)
				{
				}
				num = (short)887291904;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Applicable;
			}
			set
			{
				short num = (short)1278663421;
				short num2 = num;
				num = (short)354474749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61931520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192427521;
				if (num != 0)
				{
				}
				num = (short)1692467200;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Applicable = value;
			}
		}

		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x0600C31D RID: 49949 RVA: 0x00B74280 File Offset: 0x00B72480
		// (set) Token: 0x0600C31E RID: 49950 RVA: 0x00B74338 File Offset: 0x00B72538
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_Valid
		{
			get
			{
				short num = (short)1936413977;
				short num2 = num;
				num = (short)1536316697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534970368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651703808;
				if (num != 0)
				{
				}
				num = (short)2135621633;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Valid;
			}
			set
			{
				short num = (short)391121302;
				short num2 = num;
				num = (short)1262225814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990918144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660420097;
				if (num != 0)
				{
				}
				num = (short)1741750272;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Valid = value;
			}
		}

		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x0600C31F RID: 49951 RVA: 0x00B743F0 File Offset: 0x00B725F0
		// (set) Token: 0x0600C320 RID: 49952 RVA: 0x00B744A4 File Offset: 0x00B726A4
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_Visible
		{
			get
			{
				short num = (short)1416599339;
				short num2 = num;
				num = (short)363960107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1606877184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066205185;
				if (num != 0)
				{
				}
				num = (short)1089077248;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Visible;
			}
			set
			{
				short num = (short)1441746893;
				short num2 = num;
				num = (short)1310543821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56098816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814481408;
				if (num != 0)
				{
				}
				num = (short)78643201;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Visible = value;
			}
		}

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x0600C321 RID: 49953 RVA: 0x00B7455C File Offset: 0x00B7275C
		// (set) Token: 0x0600C322 RID: 49954 RVA: 0x00B74610 File Offset: 0x00B72810
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_Editable
		{
			get
			{
				short num = (short)620468492;
				short num2 = num;
				num = (short)710449420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)895156224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759758849;
				if (num != 0)
				{
				}
				num = (short)494403584;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.Editable;
			}
			set
			{
				short num = (short)1983578113;
				if (num != 0)
				{
				}
				num = (short)342687744;
				short num2 = num;
				num = (short)1958790233;
				short num3 = num;
				num = (short)2144781401;
				switch (num3 == num)
				{
				}
				num = (short)1388904448;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.Editable = value;
			}
		}

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x0600C323 RID: 49955 RVA: 0x00B746C4 File Offset: 0x00B728C4
		internal string CnvPerLabtoolOTACROTACSMessaging_A8663_UILabel
		{
			get
			{
				short num = (short)1458613183;
				short num2 = num;
				num = (short)1613933503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631242752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1635385344;
				if (num != 0)
				{
				}
				num = (short)1933377537;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.UIName;
			}
		}

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x0600C324 RID: 49956 RVA: 0x00B74778 File Offset: 0x00B72978
		// (set) Token: 0x0600C325 RID: 49957 RVA: 0x00B74828 File Offset: 0x00B72A28
		internal bool CnvPerLabtoolOTACROTACSMessaging_A8663_HiddenStatic
		{
			get
			{
				short num = (short)966164436;
				short num2 = num;
				num = (short)2028699604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005453312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2048589825;
				if (num != 0)
				{
				}
				num = (short)460521472;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.HiddenStatic;
			}
			set
			{
				short num = (short)1871339181;
				short num2 = num;
				num = (short)963206829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013659136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794965504;
				if (num != 0)
				{
				}
				num = (short)1193541633;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.HiddenStatic = value;
			}
		}

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x0600C326 RID: 49958 RVA: 0x00B748E0 File Offset: 0x00B72AE0
		// (set) Token: 0x0600C327 RID: 49959 RVA: 0x00B74994 File Offset: 0x00B72B94
		internal bool CnvPerLabtoolOTACROTACSMessaging_A8663_HiddenDynamic
		{
			get
			{
				short num = (short)407411854;
				short num2 = num;
				num = (short)107584654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108003328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759889921;
				if (num != 0)
				{
				}
				num = (short)1468596224;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663.HiddenDynamic;
			}
			set
			{
				short num = (short)170630990;
				short num2 = num;
				num = (short)228564814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1321402368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103953920;
				if (num != 0)
				{
				}
				num = (short)1734410241;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolOTACROTACSMessaging_A8663.HiddenDynamic = value;
			}
		}

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x0600C328 RID: 49960 RVA: 0x00B74A4C File Offset: 0x00B72C4C
		public bool CnvPerLabtoolOTACROTACSMessaging_A8663_HasDiffs
		{
			get
			{
				short num = (short)879992099;
				short num2 = num;
				num = (short)1604164899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)636878848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117257729;
				if (num != 0)
				{
				}
				num = (short)11468800;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolOTACROTACSMessaging_A8663._HasDiffs;
			}
		}

		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x0600C329 RID: 49961 RVA: 0x00B74B00 File Offset: 0x00B72D00
		// (set) Token: 0x0600C32A RID: 49962 RVA: 0x00B74BB4 File Offset: 0x00B72DB4
		public bool CnvPerLabtoolQuickKeyOverride_A8808Value
		{
			get
			{
				short num = (short)1139917267;
				short num2 = num;
				num = (short)950583763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860960256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549271040;
				if (num != 0)
				{
				}
				num = (short)1276510209;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Value;
			}
			set
			{
				short num = (short)1379671545;
				short num2 = num;
				num = (short)1734811129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1797980160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727332352;
				if (num != 0)
				{
				}
				num = (short)1634533377;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Value = value;
			}
		}

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x0600C32B RID: 49963 RVA: 0x00B74C6C File Offset: 0x00B72E6C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerLabtoolQuickKeyOverride_A8808
		{
			get
			{
				short num = (short)432159254;
				short num2 = num;
				num = (short)792672790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227803136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469841409;
				if (num != 0)
				{
				}
				num = (short)2016739328;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808;
			}
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x0600C32C RID: 49964 RVA: 0x00B74D1C File Offset: 0x00B72F1C
		// (set) Token: 0x0600C32D RID: 49965 RVA: 0x00B74DD0 File Offset: 0x00B72FD0
		public bool CnvPerLabtoolQuickKeyOverride_A8808_UIValue
		{
			get
			{
				short num = (short)1801062087;
				short num2 = num;
				num = (short)66324167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39452672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)73465857;
				if (num != 0)
				{
				}
				num = (short)974323712;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Value;
			}
			set
			{
				short num = (short)1458831718;
				short num2 = num;
				num = (short)1929773414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990393856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752615425;
				if (num != 0)
				{
				}
				num = (short)1550319616;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Value = value;
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x0600C32E RID: 49966 RVA: 0x00B74E84 File Offset: 0x00B73084
		// (set) Token: 0x0600C32F RID: 49967 RVA: 0x00B74F3C File Offset: 0x00B7313C
		public bool CnvPerLabtoolQuickKeyOverride_A8808_Applicable
		{
			get
			{
				short num = (short)1630583499;
				short num2 = num;
				num = (short)1996929739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447610880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)431226880;
				if (num != 0)
				{
				}
				num = (short)1827340289;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Applicable;
			}
			set
			{
				short num = (short)1941372929;
				if (num != 0)
				{
				}
				num = (short)1062404096;
				short num2 = num;
				num = (short)30198845;
				short num3 = num;
				num = (short)434621501;
				switch (num3 == num)
				{
				}
				num = (short)1829109760;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Applicable = value;
			}
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x0600C330 RID: 49968 RVA: 0x00B74FF4 File Offset: 0x00B731F4
		// (set) Token: 0x0600C331 RID: 49969 RVA: 0x00B750A8 File Offset: 0x00B732A8
		public bool CnvPerLabtoolQuickKeyOverride_A8808_Valid
		{
			get
			{
				short num = (short)297976800;
				short num2 = num;
				num = (short)638501856;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455475200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542324225;
				if (num != 0)
				{
				}
				num = (short)457572352;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Valid;
			}
			set
			{
				short num = (short)2004442214;
				short num2 = num;
				num = (short)619273318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386938368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832845312;
				if (num != 0)
				{
				}
				num = (short)1552809985;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Valid = value;
			}
		}

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x0600C332 RID: 49970 RVA: 0x00B75160 File Offset: 0x00B73360
		// (set) Token: 0x0600C333 RID: 49971 RVA: 0x00B75214 File Offset: 0x00B73414
		public bool CnvPerLabtoolQuickKeyOverride_A8808_Visible
		{
			get
			{
				short num = (short)249750314;
				short num2 = num;
				num = (short)111272746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730674688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)116588545;
				if (num != 0)
				{
				}
				num = (short)1729822720;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Visible;
			}
			set
			{
				short num = (short)2007652131;
				short num2 = num;
				num = (short)1142380323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116143616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631191041;
				if (num != 0)
				{
				}
				num = (short)1155072000;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Visible = value;
			}
		}

		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x0600C334 RID: 49972 RVA: 0x00B752D0 File Offset: 0x00B734D0
		// (set) Token: 0x0600C335 RID: 49973 RVA: 0x00B75384 File Offset: 0x00B73584
		public bool CnvPerLabtoolQuickKeyOverride_A8808_Editable
		{
			get
			{
				short num = (short)593100801;
				if (num != 0)
				{
				}
				num = (short)591790080;
				short num2 = num;
				num = (short)249844036;
				short num3 = num;
				num = (short)1978552644;
				switch (num3 == num)
				{
				}
				num = (short)1314783232;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.Editable;
			}
			set
			{
				short num = (short)1458030957;
				short num2 = num;
				num = (short)401000813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1466695680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				num = (short)117506048;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.Editable = value;
			}
		}

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x0600C336 RID: 49974 RVA: 0x00B7543C File Offset: 0x00B7363C
		internal string CnvPerLabtoolQuickKeyOverride_A8808_UILabel
		{
			get
			{
				short num = (short)1834393889;
				short num2 = num;
				num = (short)83337505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1500446720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1569193985;
				if (num != 0)
				{
				}
				num = (short)29753344;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.UIName;
			}
		}

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x0600C337 RID: 49975 RVA: 0x00B754F4 File Offset: 0x00B736F4
		// (set) Token: 0x0600C338 RID: 49976 RVA: 0x00B755A8 File Offset: 0x00B737A8
		internal bool CnvPerLabtoolQuickKeyOverride_A8808_HiddenStatic
		{
			get
			{
				short num = (short)1970858665;
				short num2 = num;
				num = (short)1562503849;
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
				num = (short)1605894145;
				if (num != 0)
				{
				}
				num = (short)415825920;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.HiddenStatic;
			}
			set
			{
				short num = (short)276614854;
				short num2 = num;
				num = (short)1510067910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919404544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)274989057;
				if (num != 0)
				{
				}
				num = (short)422313984;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.HiddenStatic = value;
			}
		}

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x0600C339 RID: 49977 RVA: 0x00B7565C File Offset: 0x00B7385C
		// (set) Token: 0x0600C33A RID: 49978 RVA: 0x00B7570C File Offset: 0x00B7390C
		internal bool CnvPerLabtoolQuickKeyOverride_A8808_HiddenDynamic
		{
			get
			{
				short num = (short)404363827;
				short num2 = num;
				num = (short)1854282291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1373503488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341311488;
				if (num != 0)
				{
				}
				num = (short)583925761;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808.HiddenDynamic;
			}
			set
			{
				short num = (short)1136037734;
				short num2 = num;
				num = (short)868847462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720844288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660878849;
				if (num != 0)
				{
				}
				num = (short)419364864;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolQuickKeyOverride_A8808.HiddenDynamic = value;
			}
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x0600C33B RID: 49979 RVA: 0x00B757C0 File Offset: 0x00B739C0
		public bool CnvPerLabtoolQuickKeyOverride_A8808_HasDiffs
		{
			get
			{
				short num = (short)526650459;
				short num2 = num;
				num = (short)649858139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217855488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1567162368;
				if (num != 0)
				{
				}
				num = (short)862191617;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolQuickKeyOverride_A8808._HasDiffs;
			}
		}

		// Token: 0x170061A8 RID: 25000
		// (get) Token: 0x0600C33C RID: 49980 RVA: 0x00B75874 File Offset: 0x00B73A74
		// (set) Token: 0x0600C33D RID: 49981 RVA: 0x00B75928 File Offset: 0x00B73B28
		public int CnvPerLabtoolScanListSelection_A9054Value
		{
			get
			{
				short num = (short)705931603;
				short num2 = num;
				num = (short)1845799251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767557632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236205569;
				if (num != 0)
				{
				}
				num = (short)1926365184;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.Value;
			}
			set
			{
				short num = (short)596425615;
				short num2 = num;
				num = (short)56474511;
				switch (num2 == num)
				{
				}
				num = (short)166592512;
				short num3 = num;
				num = (short)1621819393;
				if (num != 0)
				{
				}
				num = (short)284753920;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.Value = value;
			}
		}

		// Token: 0x170061A9 RID: 25001
		// (get) Token: 0x0600C33E RID: 49982 RVA: 0x00B759E0 File Offset: 0x00B73BE0
		// (set) Token: 0x0600C33F RID: 49983 RVA: 0x00B75A98 File Offset: 0x00B73C98
		public string CnvPerLabtoolScanListSelection_A9054_UIValue
		{
			get
			{
				short num = (short)876510556;
				short num2 = num;
				num = (short)1671331164;
				switch (num2 == num)
				{
				}
				num = (short)678232064;
				short num3 = num;
				num = (short)298516480;
				if (num != 0)
				{
				}
				num = (short)1088421889;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.UIValue;
			}
			set
			{
				short num = (short)1936130049;
				if (num != 0)
				{
				}
				num = (short)380157985;
				short num2 = num;
				num = (short)1696776225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57671680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152043520;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.UIValue = value;
			}
		}

		// Token: 0x170061AA RID: 25002
		// (get) Token: 0x0600C340 RID: 49984 RVA: 0x00B75B4C File Offset: 0x00B73D4C
		public global::AcpBusinessLayer.AcpRecRefField CnvPerLabtoolScanListSelection_A9054
		{
			get
			{
				short num = (short)2046351723;
				short num2 = num;
				num = (short)2100025707;
				switch (num2 == num)
				{
				}
				num = (short)1116798976;
				short num3 = num;
				num = (short)1441202176;
				if (num != 0)
				{
				}
				num = (short)357498881;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054;
			}
		}

		// Token: 0x170061AB RID: 25003
		// (get) Token: 0x0600C341 RID: 49985 RVA: 0x00B75BFC File Offset: 0x00B73DFC
		// (set) Token: 0x0600C342 RID: 49986 RVA: 0x00B75CB0 File Offset: 0x00B73EB0
		public bool CnvPerLabtoolScanListSelection_A9054_Applicable
		{
			get
			{
				short num = (short)52756481;
				if (num != 0)
				{
				}
				num = (short)2090895548;
				short num2 = num;
				num = (short)2004519100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)512163840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1910374400;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.Applicable;
			}
			set
			{
				short num = (short)1186010991;
				short num2 = num;
				num = (short)409671535;
				switch (num2 == num)
				{
				}
				num = (short)399114240;
				short num3 = num;
				num = (short)1615724545;
				if (num != 0)
				{
				}
				num = (short)2075721728;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.Applicable = value;
			}
		}

		// Token: 0x170061AC RID: 25004
		// (get) Token: 0x0600C343 RID: 49987 RVA: 0x00B75D64 File Offset: 0x00B73F64
		// (set) Token: 0x0600C344 RID: 49988 RVA: 0x00B75E18 File Offset: 0x00B74018
		public bool CnvPerLabtoolScanListSelection_A9054_Valid
		{
			get
			{
				short num = (short)1361696133;
				short num2 = num;
				num = (short)975426949;
				switch (num2 == num)
				{
				}
				num = (short)488701952;
				short num3 = num;
				num = (short)525860865;
				if (num != 0)
				{
				}
				num = (short)1764360192;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.Valid;
			}
			set
			{
				short num = (short)1213782741;
				short num2 = num;
				num = (short)677108437;
				switch (num2 == num)
				{
				}
				num = (short)754450432;
				short num3 = num;
				num = (short)484769793;
				if (num != 0)
				{
				}
				num = (short)2126708736;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.Valid = value;
			}
		}

		// Token: 0x170061AD RID: 25005
		// (get) Token: 0x0600C345 RID: 49989 RVA: 0x00B75ECC File Offset: 0x00B740CC
		// (set) Token: 0x0600C346 RID: 49990 RVA: 0x00B75F80 File Offset: 0x00B74180
		public bool CnvPerLabtoolScanListSelection_A9054_Visible
		{
			get
			{
				short num = (short)542441473;
				if (num != 0)
				{
				}
				num = (short)4730511;
				short num2 = num;
				num = (short)1610624655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2001010688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104464384;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.Visible;
			}
			set
			{
				short num = (short)286408153;
				short num2 = num;
				num = (short)992886233;
				switch (num2 == num)
				{
				}
				num = (short)1463746560;
				short num3 = num;
				num = (short)1742602241;
				if (num != 0)
				{
				}
				num = (short)437125120;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.Visible = value;
			}
		}

		// Token: 0x170061AE RID: 25006
		// (get) Token: 0x0600C347 RID: 49991 RVA: 0x00B76030 File Offset: 0x00B74230
		// (set) Token: 0x0600C348 RID: 49992 RVA: 0x00B760E4 File Offset: 0x00B742E4
		public bool CnvPerLabtoolScanListSelection_A9054_Editable
		{
			get
			{
				short num = (short)1856305498;
				short num2 = num;
				num = (short)15595866;
				switch (num2 == num)
				{
				}
				num = (short)1338179584;
				short num3 = num;
				num = (short)190447616;
				if (num != 0)
				{
				}
				num = (short)1952382977;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.Editable;
			}
			set
			{
				short num = (short)12517377;
				if (num != 0)
				{
				}
				num = (short)561134534;
				short num2 = num;
				num = (short)72825798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1751777280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2079326208;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.Editable = value;
			}
		}

		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x0600C349 RID: 49993 RVA: 0x00B76198 File Offset: 0x00B74398
		internal string CnvPerLabtoolScanListSelection_A9054_UILabel
		{
			get
			{
				short num = (short)1206303007;
				short num2 = num;
				num = (short)1540208927;
				switch (num2 == num)
				{
				}
				num = (short)308805632;
				short num3 = num;
				num = (short)1934360576;
				if (num != 0)
				{
				}
				num = (short)1154285569;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.UIName;
			}
		}

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x0600C34A RID: 49994 RVA: 0x00B7624C File Offset: 0x00B7444C
		// (set) Token: 0x0600C34B RID: 49995 RVA: 0x00B76300 File Offset: 0x00B74500
		internal bool CnvPerLabtoolScanListSelection_A9054_HiddenStatic
		{
			get
			{
				short num = (short)332544237;
				short num2 = num;
				num = (short)1160657133;
				switch (num2 == num)
				{
				}
				num = (short)151519232;
				short num3 = num;
				num = (short)1602093056;
				if (num != 0)
				{
				}
				num = (short)253755393;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.HiddenStatic;
			}
			set
			{
				short num = (short)1166592909;
				short num2 = num;
				num = (short)17222541;
				switch (num2 == num)
				{
				}
				num = (short)1326645248;
				short num3 = num;
				num = (short)1217003521;
				if (num != 0)
				{
				}
				num = (short)462553088;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.HiddenStatic = value;
			}
		}

		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x0600C34C RID: 49996 RVA: 0x00B763B8 File Offset: 0x00B745B8
		// (set) Token: 0x0600C34D RID: 49997 RVA: 0x00B7646C File Offset: 0x00B7466C
		internal bool CnvPerLabtoolScanListSelection_A9054_HiddenDynamic
		{
			get
			{
				short num = (short)1910194031;
				short num2 = num;
				num = (short)1496137583;
				switch (num2 == num)
				{
				}
				num = (short)1534328832;
				short num3 = num;
				num = (short)10027009;
				if (num != 0)
				{
				}
				num = (short)1234960384;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054.HiddenDynamic;
			}
			set
			{
				short num = (short)1541177206;
				short num2 = num;
				num = (short)1056931702;
				switch (num2 == num)
				{
				}
				num = (short)1842675712;
				short num3 = num;
				num = (short)541589504;
				if (num != 0)
				{
				}
				num = (short)675086337;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolScanListSelection_A9054.HiddenDynamic = value;
			}
		}

		// Token: 0x170061B2 RID: 25010
		// (get) Token: 0x0600C34E RID: 49998 RVA: 0x00B76520 File Offset: 0x00B74720
		public bool CnvPerLabtoolScanListSelection_A9054_HasDiffs
		{
			get
			{
				short num = (short)1906302443;
				short num2 = num;
				num = (short)719314411;
				switch (num2 == num)
				{
				}
				num = (short)457965568;
				short num3 = num;
				num = (short)1375404032;
				if (num != 0)
				{
				}
				num = (short)963772417;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolScanListSelection_A9054._HasDiffs;
			}
		}

		// Token: 0x170061B3 RID: 25011
		// (get) Token: 0x0600C34F RID: 49999 RVA: 0x00B765D8 File Offset: 0x00B747D8
		// (set) Token: 0x0600C350 RID: 50000 RVA: 0x00B7668C File Offset: 0x00B7488C
		public int CnvPerLabtoolSmartPTTType_A9164Value
		{
			get
			{
				short num = (short)560676149;
				short num2 = num;
				num = (short)1473002805;
				switch (num2 == num)
				{
				}
				num = (short)928841728;
				short num3 = num;
				num = (short)124583936;
				if (num != 0)
				{
				}
				num = (short)566296577;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.Value;
			}
			set
			{
				short num = (short)1130318735;
				short num2 = num;
				num = (short)1199000463;
				switch (num2 == num)
				{
				}
				num = (short)24379392;
				short num3 = num;
				num = (short)752353281;
				if (num != 0)
				{
				}
				num = (short)264437760;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.Value = value;
			}
		}

		// Token: 0x170061B4 RID: 25012
		// (get) Token: 0x0600C351 RID: 50001 RVA: 0x00B76744 File Offset: 0x00B74944
		// (set) Token: 0x0600C352 RID: 50002 RVA: 0x00B767F8 File Offset: 0x00B749F8
		public string CnvPerLabtoolSmartPTTType_A9164_UIValue
		{
			get
			{
				short num = (short)410124289;
				if (num != 0)
				{
				}
				num = (short)1851560783;
				short num2 = num;
				num = (short)1957466959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)84148224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370278400;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.UIValue;
			}
			set
			{
				short num = (short)832816021;
				short num2 = num;
				num = (short)1631765397;
				switch (num2 == num)
				{
				}
				num = (short)857341952;
				short num3 = num;
				num = (short)1931804673;
				if (num != 0)
				{
				}
				num = (short)1503395840;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.UIValue = value;
			}
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x0600C353 RID: 50003 RVA: 0x00B768AC File Offset: 0x00B74AAC
		public global::AcpBusinessLayer.AcpListField CnvPerLabtoolSmartPTTType_A9164
		{
			get
			{
				short num = (short)1483570839;
				short num2 = num;
				num = (short)770866839;
				switch (num2 == num)
				{
				}
				num = (short)1551368192;
				short num3 = num;
				num = (short)1719533568;
				if (num != 0)
				{
				}
				num = (short)448659457;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164;
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x0600C354 RID: 50004 RVA: 0x00B7695C File Offset: 0x00B74B5C
		// (set) Token: 0x0600C355 RID: 50005 RVA: 0x00B76A10 File Offset: 0x00B74C10
		public bool CnvPerLabtoolSmartPTTType_A9164_Applicable
		{
			get
			{
				short num = (short)330854895;
				short num2 = num;
				num = (short)183005679;
				switch (num2 == num)
				{
				}
				num = (short)1539375104;
				short num3 = num;
				num = (short)278069249;
				if (num != 0)
				{
				}
				num = (short)162201600;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.Applicable;
			}
			set
			{
				short num = (short)859746930;
				short num2 = num;
				num = (short)1739764338;
				switch (num2 == num)
				{
				}
				num = (short)1660747776;
				short num3 = num;
				num = (short)1192493057;
				if (num != 0)
				{
				}
				num = (short)1136263168;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.Applicable = value;
			}
		}

		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x0600C356 RID: 50006 RVA: 0x00B76AC4 File Offset: 0x00B74CC4
		// (set) Token: 0x0600C357 RID: 50007 RVA: 0x00B76B78 File Offset: 0x00B74D78
		public bool CnvPerLabtoolSmartPTTType_A9164_Valid
		{
			get
			{
				short num = (short)1221740006;
				short num2 = num;
				num = (short)571688422;
				switch (num2 == num)
				{
				}
				num = (short)1948057600;
				short num3 = num;
				num = (short)1667563521;
				if (num != 0)
				{
				}
				num = (short)121176064;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.Valid;
			}
			set
			{
				short num = (short)1126729311;
				short num2 = num;
				num = (short)816940639;
				switch (num2 == num)
				{
				}
				num = (short)801046528;
				short num3 = num;
				num = (short)1441793;
				if (num != 0)
				{
				}
				num = (short)1628372992;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.Valid = value;
			}
		}

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x0600C358 RID: 50008 RVA: 0x00B76C2C File Offset: 0x00B74E2C
		// (set) Token: 0x0600C359 RID: 50009 RVA: 0x00B76CE0 File Offset: 0x00B74EE0
		public bool CnvPerLabtoolSmartPTTType_A9164_Visible
		{
			get
			{
				short num = (short)1887172587;
				short num2 = num;
				num = (short)1405679595;
				switch (num2 == num)
				{
				}
				num = (short)1646723072;
				short num3 = num;
				num = (short)138412033;
				if (num != 0)
				{
				}
				num = (short)541851648;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.Visible;
			}
			set
			{
				short num = (short)602986928;
				short num2 = num;
				num = (short)311876016;
				switch (num2 == num)
				{
				}
				num = (short)1805975552;
				short num3 = num;
				num = (short)789512193;
				if (num != 0)
				{
				}
				num = (short)1148780544;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.Visible = value;
			}
		}

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x00B76D94 File Offset: 0x00B74F94
		// (set) Token: 0x0600C35B RID: 50011 RVA: 0x00B76E4C File Offset: 0x00B7504C
		public bool CnvPerLabtoolSmartPTTType_A9164_Editable
		{
			get
			{
				short num = (short)1023073529;
				short num2 = num;
				num = (short)2073156857;
				switch (num2 == num)
				{
				}
				num = (short)127860736;
				short num3 = num;
				num = (short)1824522240;
				if (num != 0)
				{
				}
				num = (short)217382913;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.Editable;
			}
			set
			{
				short num = (short)1031628192;
				short num2 = num;
				num = (short)1091528096;
				switch (num2 == num)
				{
				}
				num = (short)75890688;
				short num3 = num;
				num = (short)1935212544;
				if (num != 0)
				{
				}
				num = (short)556597249;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.Editable = value;
			}
		}

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x0600C35C RID: 50012 RVA: 0x00B76F04 File Offset: 0x00B75104
		internal string CnvPerLabtoolSmartPTTType_A9164_UILabel
		{
			get
			{
				short num = (short)1289146183;
				short num2 = num;
				num = (short)1877593927;
				switch (num2 == num)
				{
				}
				num = (short)2001469440;
				short num3 = num;
				num = (short)215220225;
				if (num != 0)
				{
				}
				num = (short)620560384;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.UIName;
			}
		}

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x0600C35D RID: 50013 RVA: 0x00B76FB8 File Offset: 0x00B751B8
		// (set) Token: 0x0600C35E RID: 50014 RVA: 0x00B77070 File Offset: 0x00B75270
		internal bool CnvPerLabtoolSmartPTTType_A9164_HiddenStatic
		{
			get
			{
				short num = (short)1138200627;
				short num2 = num;
				num = (short)1969000499;
				switch (num2 == num)
				{
				}
				num = (short)1561329664;
				short num3 = num;
				num = (short)749469697;
				if (num != 0)
				{
				}
				num = (short)2129264640;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.HiddenStatic;
			}
			set
			{
				short num = (short)9696763;
				short num2 = num;
				num = (short)1699673595;
				switch (num2 == num)
				{
				}
				num = (short)2011496448;
				short num3 = num;
				num = (short)2084569089;
				if (num != 0)
				{
				}
				num = (short)1929641984;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.HiddenStatic = value;
			}
		}

		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x0600C35F RID: 50015 RVA: 0x00B77128 File Offset: 0x00B75328
		// (set) Token: 0x0600C360 RID: 50016 RVA: 0x00B771DC File Offset: 0x00B753DC
		internal bool CnvPerLabtoolSmartPTTType_A9164_HiddenDynamic
		{
			get
			{
				short num = (short)182706579;
				short num2 = num;
				num = (short)1100669331;
				switch (num2 == num)
				{
				}
				num = (short)1686896640;
				short num3 = num;
				num = (short)913244161;
				if (num != 0)
				{
				}
				num = (short)1936457728;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164.HiddenDynamic;
			}
			set
			{
				short num = (short)1437335553;
				if (num != 0)
				{
				}
				num = (short)1033585783;
				short num2 = num;
				num = (short)262947959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1793851392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485883904;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSmartPTTType_A9164.HiddenDynamic = value;
			}
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x0600C361 RID: 50017 RVA: 0x00B77294 File Offset: 0x00B75494
		public bool CnvPerLabtoolSmartPTTType_A9164_HasDiffs
		{
			get
			{
				short num = (short)1490443735;
				short num2 = num;
				num = (short)76766679;
				switch (num2 == num)
				{
				}
				num = (short)1670184960;
				short num3 = num;
				num = (short)1381564416;
				if (num != 0)
				{
				}
				num = (short)556793857;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSmartPTTType_A9164._HasDiffs;
			}
		}

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x0600C362 RID: 50018 RVA: 0x00B77348 File Offset: 0x00B75548
		// (set) Token: 0x0600C363 RID: 50019 RVA: 0x00B773FC File Offset: 0x00B755FC
		public bool CnvPerTPSTPSUIEnable_A9400Value
		{
			get
			{
				short num = (short)898850987;
				short num2 = num;
				num = (short)1856200875;
				switch (num2 == num)
				{
				}
				num = (short)920518656;
				short num3 = num;
				num = (short)307363841;
				if (num != 0)
				{
				}
				num = (short)1407844352;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Value;
			}
			set
			{
				short num = (short)1175027210;
				short num2 = num;
				num = (short)510819850;
				switch (num2 == num)
				{
				}
				num = (short)1399324672;
				short num3 = num;
				num = (short)1045430273;
				if (num != 0)
				{
				}
				num = (short)1703215104;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Value = value;
			}
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x0600C364 RID: 50020 RVA: 0x00B774B0 File Offset: 0x00B756B0
		public global::AcpBusinessLayer.AcpField<bool> CnvPerTPSTPSUIEnable_A9400
		{
			get
			{
				short num = (short)21031415;
				short num2 = num;
				num = (short)720103927;
				switch (num2 == num)
				{
				}
				num = (short)176029696;
				short num3 = num;
				num = (short)425000961;
				if (num != 0)
				{
				}
				num = (short)387121152;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400;
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x0600C365 RID: 50021 RVA: 0x00B77560 File Offset: 0x00B75760
		// (set) Token: 0x0600C366 RID: 50022 RVA: 0x00B77618 File Offset: 0x00B75818
		public bool CnvPerTPSTPSUIEnable_A9400_UIValue
		{
			get
			{
				short num = (short)1744233797;
				short num2 = num;
				num = (short)250996037;
				switch (num2 == num)
				{
				}
				num = (short)1669398528;
				short num3 = num;
				num = (short)228851713;
				if (num != 0)
				{
				}
				num = (short)101449728;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Value;
			}
			set
			{
				short num = (short)2133455208;
				short num2 = num;
				num = (short)2128605544;
				switch (num2 == num)
				{
				}
				num = (short)1041956864;
				short num3 = num;
				num = (short)1871970304;
				if (num != 0)
				{
				}
				num = (short)66519041;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Value = value;
			}
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x0600C367 RID: 50023 RVA: 0x00B776CC File Offset: 0x00B758CC
		// (set) Token: 0x0600C368 RID: 50024 RVA: 0x00B77784 File Offset: 0x00B75984
		public bool CnvPerTPSTPSUIEnable_A9400_Applicable
		{
			get
			{
				short num = (short)2085421057;
				if (num != 0)
				{
				}
				num = (short)2094241104;
				short num2 = num;
				num = (short)202020176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274413056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122973184;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Applicable;
			}
			set
			{
				short num = (short)442310285;
				short num2 = num;
				num = (short)526917261;
				switch (num2 == num)
				{
				}
				num = (short)1549664256;
				short num3 = num;
				num = (short)846528513;
				if (num != 0)
				{
				}
				num = (short)1687617536;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Applicable = value;
			}
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x0600C369 RID: 50025 RVA: 0x00B77838 File Offset: 0x00B75A38
		// (set) Token: 0x0600C36A RID: 50026 RVA: 0x00B778F0 File Offset: 0x00B75AF0
		public bool CnvPerTPSTPSUIEnable_A9400_Valid
		{
			get
			{
				short num = (short)565373391;
				short num2 = num;
				num = (short)1897195983;
				switch (num2 == num)
				{
				}
				num = (short)1082392576;
				short num3 = num;
				num = (short)446038017;
				if (num != 0)
				{
				}
				num = (short)1482489856;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Valid;
			}
			set
			{
				short num = (short)1270618972;
				short num2 = num;
				num = (short)1335303004;
				switch (num2 == num)
				{
				}
				num = (short)730267648;
				short num3 = num;
				num = (short)1685454849;
				if (num != 0)
				{
				}
				num = (short)1623064576;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Valid = value;
			}
		}

		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x0600C36B RID: 50027 RVA: 0x00B779A8 File Offset: 0x00B75BA8
		// (set) Token: 0x0600C36C RID: 50028 RVA: 0x00B77A58 File Offset: 0x00B75C58
		public bool CnvPerTPSTPSUIEnable_A9400_Visible
		{
			get
			{
				short num = (short)525074433;
				if (num != 0)
				{
				}
				num = (short)2036111396;
				short num2 = num;
				num = (short)1041340452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1139671040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2005991424;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Visible;
			}
			set
			{
				short num = (short)1845727359;
				short num2 = num;
				num = (short)1897500799;
				switch (num2 == num)
				{
				}
				num = (short)1397882880;
				short num3 = num;
				num = (short)777256961;
				if (num != 0)
				{
				}
				num = (short)1843593216;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Visible = value;
			}
		}

		// Token: 0x170061C4 RID: 25028
		// (get) Token: 0x0600C36D RID: 50029 RVA: 0x00B77B10 File Offset: 0x00B75D10
		// (set) Token: 0x0600C36E RID: 50030 RVA: 0x00B77BC4 File Offset: 0x00B75DC4
		public bool CnvPerTPSTPSUIEnable_A9400_Editable
		{
			get
			{
				short num = (short)1937560979;
				short num2 = num;
				num = (short)1586484627;
				switch (num2 == num)
				{
				}
				num = (short)882638848;
				if (num != 0)
				{
				}
				num = (short)309329920;
				short num3 = num;
				num = (short)784400385;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.Editable;
			}
			set
			{
				short num = (short)1202170682;
				short num2 = num;
				num = (short)1169206074;
				switch (num2 == num)
				{
				}
				num = (short)753139712;
				if (num != 0)
				{
				}
				num = (short)1978335232;
				short num3 = num;
				num = (short)1637875713;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.Editable = value;
			}
		}

		// Token: 0x170061C5 RID: 25029
		// (get) Token: 0x0600C36F RID: 50031 RVA: 0x00B77C78 File Offset: 0x00B75E78
		internal string CnvPerTPSTPSUIEnable_A9400_UILabel
		{
			get
			{
				short num = (short)931745615;
				short num2 = num;
				num = (short)381439823;
				switch (num2 == num)
				{
				}
				num = (short)1427963905;
				if (num != 0)
				{
				}
				num = (short)828047360;
				short num3 = num;
				num = (short)1769472;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.UIName;
			}
		}

		// Token: 0x170061C6 RID: 25030
		// (get) Token: 0x0600C370 RID: 50032 RVA: 0x00B77D2C File Offset: 0x00B75F2C
		// (set) Token: 0x0600C371 RID: 50033 RVA: 0x00B77DE0 File Offset: 0x00B75FE0
		internal bool CnvPerTPSTPSUIEnable_A9400_HiddenStatic
		{
			get
			{
				short num = (short)1394883656;
				short num2 = num;
				num = (short)1421229128;
				switch (num2 == num)
				{
				}
				num = (short)1329987585;
				if (num != 0)
				{
				}
				num = (short)207159296;
				short num3 = num;
				num = (short)1069481984;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.HiddenStatic;
			}
			set
			{
				short num = (short)1323061809;
				short num2 = num;
				num = (short)1188057649;
				switch (num2 == num)
				{
				}
				num = (short)1555300353;
				if (num != 0)
				{
				}
				num = (short)850329600;
				short num3 = num;
				num = (short)330170368;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.HiddenStatic = value;
			}
		}

		// Token: 0x170061C7 RID: 25031
		// (get) Token: 0x0600C372 RID: 50034 RVA: 0x00B77E98 File Offset: 0x00B76098
		// (set) Token: 0x0600C373 RID: 50035 RVA: 0x00B77F4C File Offset: 0x00B7614C
		internal bool CnvPerTPSTPSUIEnable_A9400_HiddenDynamic
		{
			get
			{
				short num = (short)1968095435;
				short num2 = num;
				num = (short)575127755;
				switch (num2 == num)
				{
				}
				num = (short)1573257217;
				if (num != 0)
				{
				}
				num = (short)904462336;
				short num3 = num;
				num = (short)505937920;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400.HiddenDynamic;
			}
			set
			{
				short num = (short)1518474755;
				short num2 = num;
				num = (short)1661408771;
				switch (num2 == num)
				{
				}
				num = (short)277217281;
				if (num != 0)
				{
				}
				num = (short)1191641088;
				short num3 = num;
				num = (short)1066663936;
				if (num != 0)
				{
				}
				this.cnvPerTPSTPSUIEnable_A9400.HiddenDynamic = value;
			}
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x0600C374 RID: 50036 RVA: 0x00B78004 File Offset: 0x00B76204
		public bool CnvPerTPSTPSUIEnable_A9400_HasDiffs
		{
			get
			{
				short num = (short)251590650;
				short num2 = num;
				num = (short)1975318522;
				switch (num2 == num)
				{
				}
				num = 1;
				if (num != 0)
				{
				}
				num = (short)1403256832;
				short num3 = num;
				num = (short)1671495680;
				if (num != 0)
				{
				}
				return this.cnvPerTPSTPSUIEnable_A9400._HasDiffs;
			}
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x0600C375 RID: 50037 RVA: 0x00B780BC File Offset: 0x00B762BC
		// (set) Token: 0x0600C376 RID: 50038 RVA: 0x00B78170 File Offset: 0x00B76370
		public int CnvPerFeaturesTxVoiceType_A9573Value
		{
			get
			{
				short num = (short)2056781509;
				short num2 = num;
				num = (short)1505361605;
				switch (num2 == num)
				{
				}
				num = (short)806027265;
				if (num != 0)
				{
				}
				num = (short)735576064;
				short num3 = num;
				num = (short)2020737024;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.Value;
			}
			set
			{
				short num = (short)2090159666;
				short num2 = num;
				num = (short)1308773938;
				switch (num2 == num)
				{
				}
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)1979645952;
				short num3 = num;
				num = (short)2008416256;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.Value = value;
			}
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x0600C377 RID: 50039 RVA: 0x00B78224 File Offset: 0x00B76424
		// (set) Token: 0x0600C378 RID: 50040 RVA: 0x00B782D8 File Offset: 0x00B764D8
		public string CnvPerFeaturesTxVoiceType_A9573_UIValue
		{
			get
			{
				short num = (short)1840064248;
				short num2 = num;
				num = (short)49227512;
				switch (num2 == num)
				{
				}
				num = (short)1245773825;
				if (num != 0)
				{
				}
				num = (short)1976696832;
				short num3 = num;
				num = (short)360579072;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.UIValue;
			}
			set
			{
				short num = (short)1109082838;
				short num2 = num;
				num = (short)1896170198;
				switch (num2 == num)
				{
				}
				num = (short)2034040833;
				if (num != 0)
				{
				}
				num = (short)1345323008;
				short num3 = num;
				num = (short)173080576;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.UIValue = value;
			}
		}

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x0600C379 RID: 50041 RVA: 0x00B7838C File Offset: 0x00B7658C
		public global::AcpBusinessLayer.AcpListField CnvPerFeaturesTxVoiceType_A9573
		{
			get
			{
				short num = (short)822018049;
				if (num != 0)
				{
				}
				num = (short)1418694927;
				short num2 = num;
				num = (short)1472434447;
				switch (num2 == num)
				{
				}
				num = (short)582746112;
				short num3 = num;
				num = (short)1908211712;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573;
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x0600C37A RID: 50042 RVA: 0x00B7843C File Offset: 0x00B7663C
		// (set) Token: 0x0600C37B RID: 50043 RVA: 0x00B784F0 File Offset: 0x00B766F0
		public bool CnvPerFeaturesTxVoiceType_A9573_Applicable
		{
			get
			{
				short num = (short)89709978;
				short num2 = num;
				num = (short)993779098;
				switch (num2 == num)
				{
				}
				num = (short)1769406465;
				if (num != 0)
				{
				}
				num = (short)446103552;
				short num3 = num;
				num = (short)846594048;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.Applicable;
			}
			set
			{
				short num = (short)1614610724;
				short num2 = num;
				num = (short)43516196;
				switch (num2 == num)
				{
				}
				num = (short)1375862785;
				if (num != 0)
				{
				}
				num = (short)1004666880;
				short num3 = num;
				num = (short)1080950784;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.Applicable = value;
			}
		}

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x0600C37C RID: 50044 RVA: 0x00B785A8 File Offset: 0x00B767A8
		// (set) Token: 0x0600C37D RID: 50045 RVA: 0x00B7865C File Offset: 0x00B7685C
		public bool CnvPerFeaturesTxVoiceType_A9573_Valid
		{
			get
			{
				short num = (short)375738773;
				short num2 = num;
				num = (short)463163797;
				switch (num2 == num)
				{
				}
				num = (short)1359151105;
				if (num != 0)
				{
				}
				num = (short)194052096;
				short num3 = num;
				num = (short)1870200832;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.Valid;
			}
			set
			{
				short num = (short)732354616;
				short num2 = num;
				num = (short)46782520;
				switch (num2 == num)
				{
				}
				num = (short)1844445185;
				if (num != 0)
				{
				}
				num = (short)1910636544;
				short num3 = num;
				num = (short)669253632;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.Valid = value;
			}
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x0600C37E RID: 50046 RVA: 0x00B78710 File Offset: 0x00B76910
		// (set) Token: 0x0600C37F RID: 50047 RVA: 0x00B787C4 File Offset: 0x00B769C4
		public bool CnvPerFeaturesTxVoiceType_A9573_Visible
		{
			get
			{
				short num = (short)1572481554;
				short num2 = num;
				num = (short)507128338;
				switch (num2 == num)
				{
				}
				num = (short)2010382337;
				if (num != 0)
				{
				}
				num = (short)33554432;
				short num3 = num;
				num = (short)538705920;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.Visible;
			}
			set
			{
				short num = (short)1307683731;
				short num2 = num;
				num = (short)631090067;
				switch (num2 == num)
				{
				}
				num = (short)1174536193;
				if (num != 0)
				{
				}
				num = (short)59637760;
				short num3 = num;
				num = (short)183959552;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.Visible = value;
			}
		}

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x0600C380 RID: 50048 RVA: 0x00B7887C File Offset: 0x00B76A7C
		// (set) Token: 0x0600C381 RID: 50049 RVA: 0x00B78930 File Offset: 0x00B76B30
		public bool CnvPerFeaturesTxVoiceType_A9573_Editable
		{
			get
			{
				short num = (short)1917567780;
				short num2 = num;
				num = (short)394838820;
				switch (num2 == num)
				{
				}
				num = (short)1659109377;
				if (num != 0)
				{
				}
				num = (short)1489371136;
				short num3 = num;
				num = (short)10485760;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.Editable;
			}
			set
			{
				short num = (short)311973722;
				short num2 = num;
				num = (short)515004250;
				switch (num2 == num)
				{
				}
				num = (short)321716225;
				if (num != 0)
				{
				}
				num = (short)901644288;
				short num3 = num;
				num = (short)1972174848;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.Editable = value;
			}
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x0600C382 RID: 50050 RVA: 0x00B789E4 File Offset: 0x00B76BE4
		internal string CnvPerFeaturesTxVoiceType_A9573_UILabel
		{
			get
			{
				short num = (short)744785685;
				short num2 = num;
				num = (short)1223591701;
				switch (num2 == num)
				{
				}
				num = (short)453574657;
				if (num != 0)
				{
				}
				num = (short)722403328;
				short num3 = num;
				num = (short)2004353024;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.UIName;
			}
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x0600C383 RID: 50051 RVA: 0x00B78A98 File Offset: 0x00B76C98
		// (set) Token: 0x0600C384 RID: 50052 RVA: 0x00B78B4C File Offset: 0x00B76D4C
		internal bool CnvPerFeaturesTxVoiceType_A9573_HiddenStatic
		{
			get
			{
				short num = (short)1210638743;
				short num2 = num;
				num = (short)829350295;
				switch (num2 == num)
				{
				}
				num = (short)1440808961;
				if (num != 0)
				{
				}
				num = (short)46137344;
				short num3 = num;
				num = (short)315752448;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.HiddenStatic;
			}
			set
			{
				short num = (short)679812811;
				short num2 = num;
				num = (short)1108877003;
				switch (num2 == num)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				num = (short)359596032;
				short num3 = num;
				num = (short)1610940416;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.HiddenStatic = value;
			}
		}

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x0600C385 RID: 50053 RVA: 0x00B78C00 File Offset: 0x00B76E00
		// (set) Token: 0x0600C386 RID: 50054 RVA: 0x00B78CB4 File Offset: 0x00B76EB4
		internal bool CnvPerFeaturesTxVoiceType_A9573_HiddenDynamic
		{
			get
			{
				short num = (short)438460384;
				short num2 = num;
				num = (short)2029477856;
				switch (num2 == num)
				{
				}
				num = (short)792985601;
				if (num != 0)
				{
				}
				num = (short)1725038592;
				short num3 = num;
				num = (short)50462720;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573.HiddenDynamic;
			}
			set
			{
				short num = (short)1292456765;
				short num2 = num;
				num = (short)306336573;
				switch (num2 == num)
				{
				}
				num = (short)8978433;
				if (num != 0)
				{
				}
				num = (short)1067384832;
				short num3 = num;
				num = (short)1868234752;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTxVoiceType_A9573.HiddenDynamic = value;
			}
		}

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x0600C387 RID: 50055 RVA: 0x00B78D6C File Offset: 0x00B76F6C
		public bool CnvPerFeaturesTxVoiceType_A9573_HasDiffs
		{
			get
			{
				short num = (short)1683383882;
				short num2 = num;
				num = (short)1189439050;
				switch (num2 == num)
				{
				}
				num = (short)150011905;
				if (num != 0)
				{
				}
				num = (short)1389821952;
				short num3 = num;
				num = (short)840368128;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTxVoiceType_A9573._HasDiffs;
			}
		}

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x00B78E20 File Offset: 0x00B77020
		// (set) Token: 0x0600C389 RID: 50057 RVA: 0x00B78ED4 File Offset: 0x00B770D4
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309Value
		{
			get
			{
				short num = (short)788898278;
				short num2 = num;
				num = (short)491168230;
				switch (num2 == num)
				{
				}
				num = (short)203816961;
				if (num != 0)
				{
				}
				num = (short)116719616;
				short num3 = num;
				num = (short)350879744;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Value;
			}
			set
			{
				short num = (short)1988427777;
				if (num != 0)
				{
				}
				num = (short)556805700;
				short num2 = num;
				num = (short)568929860;
				switch (num2 == num)
				{
				}
				num = (short)1512243200;
				short num3 = num;
				num = (short)1704853504;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Value = value;
			}
		}

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x0600C38A RID: 50058 RVA: 0x00B78F88 File Offset: 0x00B77188
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesTacticalRekeyEnable_A19309
		{
			get
			{
				short num = (short)1474453513;
				short num2 = num;
				num = (short)1418092553;
				switch (num2 == num)
				{
				}
				num = (short)1979318273;
				if (num != 0)
				{
				}
				num = (short)1932132352;
				short num3 = num;
				num = (short)764608512;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309;
			}
		}

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x0600C38B RID: 50059 RVA: 0x00B79038 File Offset: 0x00B77238
		// (set) Token: 0x0600C38C RID: 50060 RVA: 0x00B790F0 File Offset: 0x00B772F0
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_UIValue
		{
			get
			{
				short num = (short)1942587423;
				short num2 = num;
				num = (short)374376479;
				switch (num2 == num)
				{
				}
				num = (short)440008704;
				if (num != 0)
				{
				}
				num = (short)1414201344;
				short num3 = num;
				num = (short)896532481;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Value;
			}
			set
			{
				short num = (short)626431766;
				short num2 = num;
				num = (short)720541462;
				switch (num2 == num)
				{
				}
				num = (short)874971136;
				if (num != 0)
				{
				}
				num = (short)1171914752;
				short num3 = num;
				num = (short)1743192065;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Value = value;
			}
		}

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x0600C38D RID: 50061 RVA: 0x00B791A8 File Offset: 0x00B773A8
		// (set) Token: 0x0600C38E RID: 50062 RVA: 0x00B7925C File Offset: 0x00B7745C
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_Applicable
		{
			get
			{
				short num = (short)1443933633;
				short num2 = num;
				num = (short)963947969;
				switch (num2 == num)
				{
				}
				num = (short)378273793;
				if (num != 0)
				{
				}
				num = (short)1219559424;
				short num3 = num;
				num = (short)341180416;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Applicable;
			}
			set
			{
				short num = (short)1534916063;
				short num2 = num;
				num = (short)1666315743;
				switch (num2 == num)
				{
				}
				num = (short)1202454529;
				if (num != 0)
				{
				}
				num = (short)1065222144;
				short num3 = num;
				num = (short)720633856;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Applicable = value;
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x0600C38F RID: 50063 RVA: 0x00B79314 File Offset: 0x00B77514
		// (set) Token: 0x0600C390 RID: 50064 RVA: 0x00B793C8 File Offset: 0x00B775C8
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_Valid
		{
			get
			{
				short num = (short)818225751;
				short num2 = num;
				num = (short)1774854743;
				switch (num2 == num)
				{
				}
				num = (short)1103560705;
				if (num != 0)
				{
				}
				num = (short)1499529216;
				short num3 = num;
				num = (short)1284440064;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Valid;
			}
			set
			{
				short num = (short)1534602870;
				short num2 = num;
				num = (short)343682678;
				switch (num2 == num)
				{
				}
				num = (short)248643584;
				if (num != 0)
				{
				}
				num = (short)1316945920;
				short num3 = num;
				num = (short)1116209153;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Valid = value;
			}
		}

		// Token: 0x170061D9 RID: 25049
		// (get) Token: 0x0600C391 RID: 50065 RVA: 0x00B79480 File Offset: 0x00B77680
		// (set) Token: 0x0600C392 RID: 50066 RVA: 0x00B79534 File Offset: 0x00B77734
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_Visible
		{
			get
			{
				short num = (short)1031114154;
				short num2 = num;
				num = (short)354127274;
				switch (num2 == num)
				{
				}
				num = (short)297861121;
				if (num != 0)
				{
				}
				num = (short)2075394048;
				short num3 = num;
				num = (short)1640759296;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Visible;
			}
			set
			{
				short num = (short)2059610456;
				short num2 = num;
				num = (short)983509336;
				switch (num2 == num)
				{
				}
				num = (short)937558017;
				if (num != 0)
				{
				}
				num = (short)1265238016;
				short num3 = num;
				num = (short)744095744;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Visible = value;
			}
		}

		// Token: 0x170061DA RID: 25050
		// (get) Token: 0x0600C393 RID: 50067 RVA: 0x00B795E8 File Offset: 0x00B777E8
		// (set) Token: 0x0600C394 RID: 50068 RVA: 0x00B7969C File Offset: 0x00B7789C
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_Editable
		{
			get
			{
				short num = (short)983923990;
				short num2 = num;
				num = (short)1988263190;
				switch (num2 == num)
				{
				}
				num = (short)1186988033;
				if (num != 0)
				{
				}
				num = (short)638124032;
				short num3 = num;
				num = (short)2104819712;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.Editable;
			}
			set
			{
				short num = (short)1957089127;
				short num2 = num;
				num = (short)1668992871;
				switch (num2 == num)
				{
				}
				num = (short)456392705;
				if (num != 0)
				{
				}
				num = (short)1997078528;
				short num3 = num;
				num = (short)1985675264;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.Editable = value;
			}
		}

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x0600C395 RID: 50069 RVA: 0x00B79750 File Offset: 0x00B77950
		internal string CnvPerFeaturesTacticalRekeyEnable_A19309_UILabel
		{
			get
			{
				short num = (short)2071781368;
				short num2 = num;
				num = (short)588505080;
				switch (num2 == num)
				{
				}
				num = (short)417726464;
				if (num != 0)
				{
				}
				num = (short)1092419584;
				short num3 = num;
				num = (short)1969160193;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.UIName;
			}
		}

		// Token: 0x170061DC RID: 25052
		// (get) Token: 0x0600C396 RID: 50070 RVA: 0x00B79808 File Offset: 0x00B77A08
		// (set) Token: 0x0600C397 RID: 50071 RVA: 0x00B798B8 File Offset: 0x00B77AB8
		internal bool CnvPerFeaturesTacticalRekeyEnable_A19309_HiddenStatic
		{
			get
			{
				short num = (short)355860481;
				if (num != 0)
				{
				}
				num = (short)277866904;
				short num2 = num;
				num = (short)626583960;
				switch (num2 == num)
				{
				}
				num = (short)1853292544;
				short num3 = num;
				num = (short)764215296;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.HiddenStatic;
			}
			set
			{
				short num = (short)1740785074;
				short num2 = num;
				num = (short)1661420978;
				switch (num2 == num)
				{
				}
				num = (short)225902592;
				if (num != 0)
				{
				}
				num = (short)1957036032;
				short num3 = num;
				num = (short)588775425;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.HiddenStatic = value;
			}
		}

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x0600C398 RID: 50072 RVA: 0x00B7996C File Offset: 0x00B77B6C
		// (set) Token: 0x0600C399 RID: 50073 RVA: 0x00B79A20 File Offset: 0x00B77C20
		internal bool CnvPerFeaturesTacticalRekeyEnable_A19309_HiddenDynamic
		{
			get
			{
				short num = (short)702091173;
				short num2 = num;
				num = (short)1732186021;
				switch (num2 == num)
				{
				}
				num = (short)39059457;
				if (num != 0)
				{
				}
				num = (short)1327366144;
				short num3 = num;
				num = (short)603193344;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309.HiddenDynamic;
			}
			set
			{
				short num = (short)991625217;
				if (num != 0)
				{
				}
				num = (short)1399404979;
				short num2 = num;
				num = (short)870791603;
				switch (num2 == num)
				{
				}
				num = (short)1773010944;
				short num3 = num;
				num = (short)1166737408;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesTacticalRekeyEnable_A19309.HiddenDynamic = value;
			}
		}

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x0600C39A RID: 50074 RVA: 0x00B79AD4 File Offset: 0x00B77CD4
		public bool CnvPerFeaturesTacticalRekeyEnable_A19309_HasDiffs
		{
			get
			{
				short num = (short)1993227060;
				short num2 = num;
				num = (short)885930804;
				switch (num2 == num)
				{
				}
				num = (short)528351232;
				if (num != 0)
				{
				}
				num = (short)768147456;
				short num3 = num;
				num = (short)1901723649;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesTacticalRekeyEnable_A19309._HasDiffs;
			}
		}

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x0600C39B RID: 50075 RVA: 0x00B79B88 File Offset: 0x00B77D88
		// (set) Token: 0x0600C39C RID: 50076 RVA: 0x00B79C38 File Offset: 0x00B77E38
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723Value
		{
			get
			{
				short num = (short)1329354983;
				short num2 = num;
				num = (short)593189095;
				switch (num2 == num)
				{
				}
				num = (short)1372651521;
				if (num != 0)
				{
				}
				num = (short)1290534912;
				short num3 = num;
				num = (short)979501056;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Value;
			}
			set
			{
				short num = (short)169871274;
				short num2 = num;
				num = (short)1801062314;
				switch (num2 == num)
				{
				}
				num = (short)767492097;
				if (num != 0)
				{
				}
				num = (short)364249088;
				short num3 = num;
				num = (short)1062731776;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Value = value;
			}
		}

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x0600C39D RID: 50077 RVA: 0x00B79CEC File Offset: 0x00B77EEC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesMixedVoteScanEnable_A38723
		{
			get
			{
				short num = (short)707264513;
				if (num != 0)
				{
				}
				num = (short)640675907;
				short num2 = num;
				num = (short)197324867;
				switch (num2 == num)
				{
				}
				num = (short)895287296;
				short num3 = num;
				num = (short)832438272;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723;
			}
		}

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x0600C39E RID: 50078 RVA: 0x00B79D9C File Offset: 0x00B77F9C
		// (set) Token: 0x0600C39F RID: 50079 RVA: 0x00B79E50 File Offset: 0x00B78050
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_UIValue
		{
			get
			{
				short num = (short)298992571;
				short num2 = num;
				num = (short)937903035;
				switch (num2 == num)
				{
				}
				num = (short)609550336;
				if (num != 0)
				{
				}
				num = (short)158138368;
				short num3 = num;
				num = (short)960626689;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Value;
			}
			set
			{
				short num = (short)1302200321;
				if (num != 0)
				{
				}
				num = (short)1619215957;
				short num2 = num;
				num = (short)667829845;
				switch (num2 == num)
				{
				}
				num = (short)846790656;
				short num3 = num;
				num = (short)166658048;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Value = value;
			}
		}

		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x0600C3A0 RID: 50080 RVA: 0x00B79F04 File Offset: 0x00B78104
		// (set) Token: 0x0600C3A1 RID: 50081 RVA: 0x00B79FB8 File Offset: 0x00B781B8
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_Applicable
		{
			get
			{
				short num = (short)843628476;
				short num2 = num;
				num = (short)1878966204;
				switch (num2 == num)
				{
				}
				num = (short)231735296;
				if (num != 0)
				{
				}
				num = (short)11796480;
				short num3 = num;
				num = (short)1290797057;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Applicable;
			}
			set
			{
				short num = (short)1660252104;
				short num2 = num;
				num = (short)1449881544;
				switch (num2 == num)
				{
				}
				num = (short)954793985;
				if (num != 0)
				{
				}
				num = (short)1102446592;
				short num3 = num;
				num = (short)1925906432;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Applicable = value;
			}
		}

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x0600C3A2 RID: 50082 RVA: 0x00B7A06C File Offset: 0x00B7826C
		// (set) Token: 0x0600C3A3 RID: 50083 RVA: 0x00B7A120 File Offset: 0x00B78320
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_Valid
		{
			get
			{
				short num = (short)1198839040;
				short num2 = num;
				num = (short)896652544;
				switch (num2 == num)
				{
				}
				num = (short)701235201;
				if (num != 0)
				{
				}
				num = (short)1351090176;
				short num3 = num;
				num = (short)2098659328;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Valid;
			}
			set
			{
				short num = (short)1596930341;
				short num2 = num;
				num = (short)1895643429;
				switch (num2 == num)
				{
				}
				num = (short)978780160;
				if (num != 0)
				{
				}
				num = (short)704118784;
				short num3 = num;
				num = (short)1005912065;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Valid = value;
			}
		}

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x0600C3A4 RID: 50084 RVA: 0x00B7A1D4 File Offset: 0x00B783D4
		// (set) Token: 0x0600C3A5 RID: 50085 RVA: 0x00B7A288 File Offset: 0x00B78488
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_Visible
		{
			get
			{
				short num = (short)420216833;
				if (num != 0)
				{
				}
				num = (short)1535069821;
				short num2 = num;
				num = (short)518344317;
				switch (num2 == num)
				{
				}
				num = (short)114622464;
				short num3 = num;
				num = (short)1146355712;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Visible;
			}
			set
			{
				short num = (short)997181858;
				short num2 = num;
				num = (short)1821297058;
				switch (num2 == num)
				{
				}
				num = (short)1967783937;
				if (num != 0)
				{
				}
				num = (short)1649082368;
				short num3 = num;
				num = (short)1045037056;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Visible = value;
			}
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x0600C3A6 RID: 50086 RVA: 0x00B7A33C File Offset: 0x00B7853C
		// (set) Token: 0x0600C3A7 RID: 50087 RVA: 0x00B7A3F0 File Offset: 0x00B785F0
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_Editable
		{
			get
			{
				short num = (short)320024708;
				short num2 = num;
				num = (short)1063530628;
				switch (num2 == num)
				{
				}
				num = (short)872939521;
				if (num != 0)
				{
				}
				num = (short)1946615808;
				short num3 = num;
				num = (short)2056716288;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.Editable;
			}
			set
			{
				short num = (short)152099944;
				short num2 = num;
				num = (short)1421859944;
				switch (num2 == num)
				{
				}
				num = (short)1538195456;
				if (num != 0)
				{
				}
				num = (short)433913856;
				short num3 = num;
				num = (short)139984897;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.Editable = value;
			}
		}

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x00B7A4A8 File Offset: 0x00B786A8
		internal string CnvPerFeaturesMixedVoteScanEnable_A38723_UILabel
		{
			get
			{
				short num = (short)120324097;
				if (num != 0)
				{
				}
				num = (short)980287219;
				short num2 = num;
				num = (short)77135603;
				switch (num2 == num)
				{
				}
				num = (short)1008402432;
				short num3 = num;
				num = (short)295239680;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.UIName;
			}
		}

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x0600C3A9 RID: 50089 RVA: 0x00B7A55C File Offset: 0x00B7875C
		// (set) Token: 0x0600C3AA RID: 50090 RVA: 0x00B7A610 File Offset: 0x00B78810
		internal bool CnvPerFeaturesMixedVoteScanEnable_A38723_HiddenStatic
		{
			get
			{
				short num = (short)1360157313;
				short num2 = num;
				num = (short)1787386497;
				switch (num2 == num)
				{
				}
				num = (short)206962688;
				if (num != 0)
				{
				}
				num = (short)1356464129;
				if (num != 0)
				{
				}
				num = (short)1362165760;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.HiddenStatic;
			}
			set
			{
				short num = (short)1607365660;
				short num2 = num;
				num = (short)1740928028;
				switch (num2 == num)
				{
				}
				num = (short)833748993;
				if (num != 0)
				{
				}
				num = (short)905707520;
				if (num != 0)
				{
				}
				num = (short)2125266944;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.HiddenStatic = value;
			}
		}

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x0600C3AB RID: 50091 RVA: 0x00B7A6C4 File Offset: 0x00B788C4
		// (set) Token: 0x0600C3AC RID: 50092 RVA: 0x00B7A778 File Offset: 0x00B78978
		internal bool CnvPerFeaturesMixedVoteScanEnable_A38723_HiddenDynamic
		{
			get
			{
				short num = (short)826212353;
				if (num != 0)
				{
				}
				num = (short)1322437046;
				short num2 = num;
				num = (short)966904246;
				switch (num2 == num)
				{
				}
				num = (short)42991616;
				if (num != 0)
				{
				}
				num = (short)536543232;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723.HiddenDynamic;
			}
			set
			{
				short num = (short)174694075;
				short num2 = num;
				num = (short)848862907;
				switch (num2 == num)
				{
				}
				num = (short)1611923456;
				if (num != 0)
				{
				}
				num = (short)109445121;
				if (num != 0)
				{
				}
				num = (short)921698304;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanEnable_A38723.HiddenDynamic = value;
			}
		}

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x0600C3AD RID: 50093 RVA: 0x00B7A830 File Offset: 0x00B78A30
		public bool CnvPerFeaturesMixedVoteScanEnable_A38723_HasDiffs
		{
			get
			{
				short num = (short)1284490770;
				short num2 = num;
				num = (short)1871234578;
				switch (num2 == num)
				{
				}
				num = (short)1494614016;
				if (num != 0)
				{
				}
				num = (short)1121320961;
				if (num != 0)
				{
				}
				num = (short)404291584;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanEnable_A38723._HasDiffs;
			}
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x0600C3AE RID: 50094 RVA: 0x00B7A8E4 File Offset: 0x00B78AE4
		// (set) Token: 0x0600C3AF RID: 50095 RVA: 0x00B7A998 File Offset: 0x00B78B98
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878Value
		{
			get
			{
				short num = (short)1575784417;
				short num2 = num;
				num = (short)1097568225;
				switch (num2 == num)
				{
				}
				num = (short)2080047105;
				if (num != 0)
				{
				}
				num = (short)2029846528;
				if (num != 0)
				{
				}
				num = (short)1507393536;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Value;
			}
			set
			{
				short num = (short)1401525524;
				short num2 = num;
				num = (short)256546068;
				switch (num2 == num)
				{
				}
				num = (short)1950810113;
				if (num != 0)
				{
				}
				num = (short)628162560;
				if (num != 0)
				{
				}
				num = (short)404881408;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Value = value;
			}
		}

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x0600C3B0 RID: 50096 RVA: 0x00B7AA4C File Offset: 0x00B78C4C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesMixedVoteScanTxSteering_A38878
		{
			get
			{
				short num = (short)1695914800;
				short num2 = num;
				num = (short)280075056;
				switch (num2 == num)
				{
				}
				num = (short)135069697;
				if (num != 0)
				{
				}
				num = (short)529793024;
				if (num != 0)
				{
				}
				num = (short)263127040;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878;
			}
		}

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x0600C3B1 RID: 50097 RVA: 0x00B7AAFC File Offset: 0x00B78CFC
		// (set) Token: 0x0600C3B2 RID: 50098 RVA: 0x00B7ABB0 File Offset: 0x00B78DB0
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_UIValue
		{
			get
			{
				short num = (short)929545026;
				short num2 = num;
				num = (short)117029698;
				switch (num2 == num)
				{
				}
				num = (short)866123776;
				if (num != 0)
				{
				}
				num = (short)424083457;
				if (num != 0)
				{
				}
				num = (short)706805760;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Value;
			}
			set
			{
				short num = (short)926274222;
				short num2 = num;
				num = (short)354013870;
				switch (num2 == num)
				{
				}
				num = (short)1626669056;
				if (num != 0)
				{
				}
				num = (short)1097465857;
				if (num != 0)
				{
				}
				num = (short)118292480;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Value = value;
			}
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x0600C3B3 RID: 50099 RVA: 0x00B7AC68 File Offset: 0x00B78E68
		// (set) Token: 0x0600C3B4 RID: 50100 RVA: 0x00B7AD1C File Offset: 0x00B78F1C
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_Applicable
		{
			get
			{
				short num = (short)1111081963;
				short num2 = num;
				num = (short)1208730603;
				switch (num2 == num)
				{
				}
				num = (short)1324154880;
				if (num != 0)
				{
				}
				num = (short)132251649;
				if (num != 0)
				{
				}
				num = (short)1621622784;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Applicable;
			}
			set
			{
				short num = (short)1245949664;
				short num2 = num;
				num = (short)157134560;
				switch (num2 == num)
				{
				}
				num = (short)693305344;
				if (num != 0)
				{
				}
				num = (short)1626603521;
				if (num != 0)
				{
				}
				num = (short)358416384;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Applicable = value;
			}
		}

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x0600C3B5 RID: 50101 RVA: 0x00B7ADD0 File Offset: 0x00B78FD0
		// (set) Token: 0x0600C3B6 RID: 50102 RVA: 0x00B7AE84 File Offset: 0x00B79084
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_Valid
		{
			get
			{
				short num = (short)995557377;
				if (num != 0)
				{
				}
				num = (short)435727612;
				short num2 = num;
				num = (short)490384636;
				switch (num2 == num)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				num = (short)1239547904;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Valid;
			}
			set
			{
				short num = (short)1254874155;
				short num2 = num;
				num = (short)1154800683;
				switch (num2 == num)
				{
				}
				num = (short)1049231361;
				if (num != 0)
				{
				}
				num = (short)136183808;
				if (num != 0)
				{
				}
				num = (short)611450880;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Valid = value;
			}
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x0600C3B7 RID: 50103 RVA: 0x00B7AF34 File Offset: 0x00B79134
		// (set) Token: 0x0600C3B8 RID: 50104 RVA: 0x00B7AFEC File Offset: 0x00B791EC
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_Visible
		{
			get
			{
				short num = (short)36627243;
				short num2 = num;
				num = (short)1041556267;
				switch (num2 == num)
				{
				}
				num = (short)1873084417;
				if (num != 0)
				{
				}
				num = (short)153944064;
				if (num != 0)
				{
				}
				num = (short)694288384;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Visible;
			}
			set
			{
				short num = (short)318533057;
				short num2 = num;
				num = (short)1787850177;
				switch (num2 == num)
				{
				}
				num = (short)126615553;
				if (num != 0)
				{
				}
				num = (short)1941635072;
				if (num != 0)
				{
				}
				num = (short)805240832;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Visible = value;
			}
		}

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x0600C3B9 RID: 50105 RVA: 0x00B7B0A4 File Offset: 0x00B792A4
		// (set) Token: 0x0600C3BA RID: 50106 RVA: 0x00B7B158 File Offset: 0x00B79358
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_Editable
		{
			get
			{
				short num = (short)1035092323;
				short num2 = num;
				num = (short)746078563;
				switch (num2 == num)
				{
				}
				num = (short)1539178496;
				if (num != 0)
				{
				}
				num = (short)234553345;
				if (num != 0)
				{
				}
				num = (short)1335492608;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Editable;
			}
			set
			{
				short num = (short)2120143345;
				short num2 = num;
				num = (short)1053872625;
				switch (num2 == num)
				{
				}
				num = (short)673513473;
				if (num != 0)
				{
				}
				num = (short)1676279808;
				if (num != 0)
				{
				}
				num = (short)1088159744;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.Editable = value;
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x0600C3BB RID: 50107 RVA: 0x00B7B20C File Offset: 0x00B7940C
		internal string CnvPerFeaturesMixedVoteScanTxSteering_A38878_UILabel
		{
			get
			{
				short num = (short)150988055;
				short num2 = num;
				num = (short)1572726039;
				switch (num2 == num)
				{
				}
				num = (short)555417601;
				if (num != 0)
				{
				}
				num = (short)369033216;
				if (num != 0)
				{
				}
				num = (short)1300955136;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.UIName;
			}
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x0600C3BC RID: 50108 RVA: 0x00B7B2C4 File Offset: 0x00B794C4
		// (set) Token: 0x0600C3BD RID: 50109 RVA: 0x00B7B37C File Offset: 0x00B7957C
		internal bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_HiddenStatic
		{
			get
			{
				short num = (short)1888756907;
				short num2 = num;
				num = (short)596190379;
				switch (num2 == num)
				{
				}
				num = (short)38731777;
				if (num != 0)
				{
				}
				num = (short)405733376;
				if (num != 0)
				{
				}
				num = (short)1066205184;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.HiddenStatic;
			}
			set
			{
				short num = (short)531365889;
				if (num != 0)
				{
				}
				num = (short)837155414;
				short num2 = num;
				num = (short)1970797142;
				switch (num2 == num)
				{
				}
				num = (short)188809216;
				if (num != 0)
				{
				}
				num = (short)1258946560;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.HiddenStatic = value;
			}
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x0600C3BE RID: 50110 RVA: 0x00B7B434 File Offset: 0x00B79634
		// (set) Token: 0x0600C3BF RID: 50111 RVA: 0x00B7B4EC File Offset: 0x00B796EC
		internal bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_HiddenDynamic
		{
			get
			{
				short num = (short)667115167;
				short num2 = num;
				num = (short)303259295;
				switch (num2 == num)
				{
				}
				num = (short)432209920;
				if (num != 0)
				{
				}
				num = (short)2013200385;
				if (num != 0)
				{
				}
				num = (short)1881604096;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.HiddenDynamic;
			}
			set
			{
				short num = (short)1233498531;
				short num2 = num;
				num = (short)595898787;
				switch (num2 == num)
				{
				}
				num = (short)800522241;
				if (num != 0)
				{
				}
				num = (short)1263730688;
				if (num != 0)
				{
				}
				num = (short)1798569984;
				short num3 = num;
				this.cnvPerFeaturesMixedVoteScanTxSteering_A38878.HiddenDynamic = value;
			}
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x0600C3C0 RID: 50112 RVA: 0x00B7B5A0 File Offset: 0x00B797A0
		public bool CnvPerFeaturesMixedVoteScanTxSteering_A38878_HasDiffs
		{
			get
			{
				short num = (short)614853257;
				short num2 = num;
				num = (short)271051401;
				switch (num2 == num)
				{
				}
				num = (short)645988353;
				if (num != 0)
				{
				}
				num = (short)92930048;
				if (num != 0)
				{
				}
				num = (short)69206016;
				short num3 = num;
				return this.cnvPerFeaturesMixedVoteScanTxSteering_A38878._HasDiffs;
			}
		}

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x0600C3C1 RID: 50113 RVA: 0x00B7B654 File Offset: 0x00B79854
		// (set) Token: 0x0600C3C2 RID: 50114 RVA: 0x00B7B704 File Offset: 0x00B79904
		public int ConPerFeatureIncidentSignalingType_A41507Value
		{
			get
			{
				short num = (short)807934388;
				short num2 = num;
				num = (short)793057716;
				switch (num2 == num)
				{
				}
				num = (short)159514625;
				if (num != 0)
				{
				}
				num = (short)1574174720;
				if (num != 0)
				{
				}
				num = (short)1012924416;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.Value;
			}
			set
			{
				short num = (short)1627652097;
				if (num != 0)
				{
				}
				num = (short)2091173987;
				short num2 = num;
				num = (short)2080295011;
				switch (num2 == num)
				{
				}
				num = (short)150798336;
				if (num != 0)
				{
				}
				num = (short)23265280;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.Value = value;
			}
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x0600C3C3 RID: 50115 RVA: 0x00B7B7B8 File Offset: 0x00B799B8
		// (set) Token: 0x0600C3C4 RID: 50116 RVA: 0x00B7B86C File Offset: 0x00B79A6C
		public string ConPerFeatureIncidentSignalingType_A41507_UIValue
		{
			get
			{
				short num = (short)1150691150;
				short num2 = num;
				num = (short)1267541838;
				switch (num2 == num)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				num = (short)1916731393;
				if (num != 0)
				{
				}
				num = (short)1576730624;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.UIValue;
			}
			set
			{
				short num = (short)1331353792;
				short num2 = num;
				num = (short)1365563584;
				switch (num2 == num)
				{
				}
				num = (short)1027735552;
				if (num != 0)
				{
				}
				num = (short)2006056961;
				if (num != 0)
				{
				}
				num = (short)2036596736;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.UIValue = value;
			}
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x0600C3C5 RID: 50117 RVA: 0x00B7B924 File Offset: 0x00B79B24
		public global::AcpBusinessLayer.AcpListField ConPerFeatureIncidentSignalingType_A41507
		{
			get
			{
				short num = (short)1414839482;
				short num2 = num;
				num = (short)130202810;
				switch (num2 == num)
				{
				}
				num = (short)1847263233;
				if (num != 0)
				{
				}
				num = (short)994902016;
				if (num != 0)
				{
				}
				num = (short)2136539136;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507;
			}
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x0600C3C6 RID: 50118 RVA: 0x00B7B9D4 File Offset: 0x00B79BD4
		// (set) Token: 0x0600C3C7 RID: 50119 RVA: 0x00B7BA88 File Offset: 0x00B79C88
		public bool ConPerFeatureIncidentSignalingType_A41507_Applicable
		{
			get
			{
				short num = (short)2110837722;
				short num2 = num;
				num = (short)935384026;
				switch (num2 == num)
				{
				}
				num = (short)1310326785;
				if (num != 0)
				{
				}
				num = (short)1834876928;
				if (num != 0)
				{
				}
				num = (short)1723662336;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.Applicable;
			}
			set
			{
				short num = (short)890660051;
				short num2 = num;
				num = (short)1447912659;
				switch (num2 == num)
				{
				}
				num = (short)1334444033;
				if (num != 0)
				{
				}
				num = (short)1367080960;
				if (num != 0)
				{
				}
				num = (short)318439424;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.Applicable = value;
			}
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x0600C3C8 RID: 50120 RVA: 0x00B7BB3C File Offset: 0x00B79D3C
		// (set) Token: 0x0600C3C9 RID: 50121 RVA: 0x00B7BBF4 File Offset: 0x00B79DF4
		public bool ConPerFeatureIncidentSignalingType_A41507_Valid
		{
			get
			{
				short num = (short)558193958;
				short num2 = num;
				num = (short)667639078;
				switch (num2 == num)
				{
				}
				num = (short)79495168;
				if (num != 0)
				{
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)68616192;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.Valid;
			}
			set
			{
				short num = (short)1658277103;
				short num2 = num;
				num = (short)2144685295;
				switch (num2 == num)
				{
				}
				num = (short)2106720257;
				if (num != 0)
				{
				}
				num = (short)433324032;
				if (num != 0)
				{
				}
				num = (short)977534976;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.Valid = value;
			}
		}

		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x0600C3CA RID: 50122 RVA: 0x00B7BCAC File Offset: 0x00B79EAC
		// (set) Token: 0x0600C3CB RID: 50123 RVA: 0x00B7BD60 File Offset: 0x00B79F60
		public bool ConPerFeatureIncidentSignalingType_A41507_Visible
		{
			get
			{
				short num = (short)2077654563;
				short num2 = num;
				num = (short)1304329763;
				switch (num2 == num)
				{
				}
				num = (short)1914830849;
				if (num != 0)
				{
				}
				num = (short)2043609088;
				if (num != 0)
				{
				}
				num = (short)869924864;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.Visible;
			}
			set
			{
				short num = (short)357594341;
				short num2 = num;
				num = (short)1476883685;
				switch (num2 == num)
				{
				}
				num = (short)1736572929;
				if (num != 0)
				{
				}
				num = (short)1296629760;
				if (num != 0)
				{
				}
				num = (short)1543700480;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.Visible = value;
			}
		}

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x0600C3CC RID: 50124 RVA: 0x00B7BE14 File Offset: 0x00B7A014
		// (set) Token: 0x0600C3CD RID: 50125 RVA: 0x00B7BEC8 File Offset: 0x00B7A0C8
		public bool ConPerFeatureIncidentSignalingType_A41507_Editable
		{
			get
			{
				short num = (short)550530011;
				short num2 = num;
				num = (short)1728277467;
				switch (num2 == num)
				{
				}
				num = (short)1129840640;
				if (num != 0)
				{
				}
				num = (short)984219649;
				if (num != 0)
				{
				}
				num = (short)1954676736;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.Editable;
			}
			set
			{
				short num = (short)961552354;
				short num2 = num;
				num = (short)1067524066;
				switch (num2 == num)
				{
				}
				num = (short)1651310592;
				if (num != 0)
				{
				}
				num = (short)1229914113;
				if (num != 0)
				{
				}
				num = (short)1119223808;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.Editable = value;
			}
		}

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x0600C3CE RID: 50126 RVA: 0x00B7BF7C File Offset: 0x00B7A17C
		internal string ConPerFeatureIncidentSignalingType_A41507_UILabel
		{
			get
			{
				short num = (short)1439672055;
				short num2 = num;
				num = (short)709732087;
				switch (num2 == num)
				{
				}
				num = (short)154402816;
				if (num != 0)
				{
				}
				num = (short)2020212737;
				if (num != 0)
				{
				}
				num = (short)258080768;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.UIName;
			}
		}

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x0600C3CF RID: 50127 RVA: 0x00B7C034 File Offset: 0x00B7A234
		// (set) Token: 0x0600C3D0 RID: 50128 RVA: 0x00B7C0E8 File Offset: 0x00B7A2E8
		internal bool ConPerFeatureIncidentSignalingType_A41507_HiddenStatic
		{
			get
			{
				short num = (short)256133523;
				short num2 = num;
				num = (short)1738492307;
				switch (num2 == num)
				{
				}
				num = (short)1867710465;
				if (num != 0)
				{
				}
				num = (short)259129344;
				if (num != 0)
				{
				}
				num = (short)38273024;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.HiddenStatic;
			}
			set
			{
				short num = (short)147302866;
				short num2 = num;
				num = (short)304327122;
				switch (num2 == num)
				{
				}
				num = (short)516947969;
				if (num != 0)
				{
				}
				num = (short)302055424;
				if (num != 0)
				{
				}
				num = (short)1854996480;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.HiddenStatic = value;
			}
		}

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x0600C3D1 RID: 50129 RVA: 0x00B7C1A0 File Offset: 0x00B7A3A0
		// (set) Token: 0x0600C3D2 RID: 50130 RVA: 0x00B7C254 File Offset: 0x00B7A454
		internal bool ConPerFeatureIncidentSignalingType_A41507_HiddenDynamic
		{
			get
			{
				short num = (short)625780255;
				short num2 = num;
				num = (short)918857247;
				switch (num2 == num)
				{
				}
				num = (short)966262785;
				if (num != 0)
				{
				}
				num = (short)1167917056;
				if (num != 0)
				{
				}
				num = (short)579600384;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507.HiddenDynamic;
			}
			set
			{
				short num = (short)1824243127;
				short num2 = num;
				num = (short)1694481847;
				switch (num2 == num)
				{
				}
				num = (short)786169856;
				if (num != 0)
				{
				}
				num = (short)373424129;
				if (num != 0)
				{
				}
				num = (short)490340352;
				short num3 = num;
				this.conPerFeatureIncidentSignalingType_A41507.HiddenDynamic = value;
			}
		}

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x0600C3D3 RID: 50131 RVA: 0x00B7C308 File Offset: 0x00B7A508
		public bool ConPerFeatureIncidentSignalingType_A41507_HasDiffs
		{
			get
			{
				short num = (short)24595560;
				short num2 = num;
				num = (short)683560040;
				switch (num2 == num)
				{
				}
				num = (short)1050869761;
				if (num != 0)
				{
				}
				num = (short)587202560;
				if (num != 0)
				{
				}
				num = (short)1033830400;
				short num3 = num;
				return this.conPerFeatureIncidentSignalingType_A41507._HasDiffs;
			}
		}

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x0600C3D4 RID: 50132 RVA: 0x00B7C3BC File Offset: 0x00B7A5BC
		// (set) Token: 0x0600C3D5 RID: 50133 RVA: 0x00B7C474 File Offset: 0x00B7A674
		public bool CnvPerEndTxOnVoiceAbsence_42460Value
		{
			get
			{
				short num = (short)1531518356;
				short num2 = num;
				num = (short)16260500;
				switch (num2 == num)
				{
				}
				num = (short)993787905;
				if (num != 0)
				{
				}
				num = (short)1911422976;
				if (num != 0)
				{
				}
				num = (short)2001338368;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460.Value;
			}
			set
			{
				short num = (short)265551873;
				if (num != 0)
				{
				}
				num = (short)10518480;
				short num2 = num;
				num = (short)903053264;
				switch (num2 == num)
				{
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				num = (short)904790016;
				short num3 = num;
				this.cnvPerEndTxOnVoiceAbsence_42460.Value = value;
			}
		}

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x0600C3D6 RID: 50134 RVA: 0x00B7C528 File Offset: 0x00B7A728
		public global::AcpBusinessLayer.AcpField<bool> CnvPerEndTxOnVoiceAbsence_42460
		{
			get
			{
				short num = (short)1370095617;
				if (num != 0)
				{
				}
				num = (short)1334941557;
				short num2 = num;
				num = (short)1809880949;
				switch (num2 == num)
				{
				}
				num = (short)1593376768;
				if (num != 0)
				{
				}
				num = (short)79036416;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460;
			}
		}

		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x0600C3D7 RID: 50135 RVA: 0x00B7C5D8 File Offset: 0x00B7A7D8
		// (set) Token: 0x0600C3D8 RID: 50136 RVA: 0x00B7C68C File Offset: 0x00B7A88C
		public bool CnvPerEndTxOnVoiceAbsence_42460_UIValue
		{
			get
			{
				short num = (short)1581060800;
				short num2 = num;
				num = (short)181605056;
				switch (num2 == num)
				{
				}
				num = (short)805306369;
				if (num != 0)
				{
				}
				num = (short)866385920;
				if (num != 0)
				{
				}
				num = (short)367591424;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460.Value;
			}
			set
			{
				short num = (short)351572892;
				short num2 = num;
				num = (short)586978204;
				switch (num2 == num)
				{
				}
				num = (short)688848896;
				if (num != 0)
				{
				}
				num = (short)927268865;
				if (num != 0)
				{
				}
				num = (short)1918042112;
				short num3 = num;
				this.cnvPerEndTxOnVoiceAbsence_42460.Value = value;
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x0600C3D9 RID: 50137 RVA: 0x00B7C740 File Offset: 0x00B7A940
		// (set) Token: 0x0600C3DA RID: 50138 RVA: 0x00B7C7F8 File Offset: 0x00B7A9F8
		public bool CnvPerEndTxOnVoiceAbsence_42460_Applicable
		{
			get
			{
				short num = (short)1339093460;
				short num2 = num;
				num = (short)573305300;
				switch (num2 == num)
				{
				}
				num = (short)65536000;
				if (num != 0)
				{
				}
				num = (short)244187137;
				if (num != 0)
				{
				}
				num = (short)297402368;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460.Applicable;
			}
			set
			{
				short num = (short)562940771;
				short num2 = num;
				num = (short)1519242083;
				switch (num2 == num)
				{
				}
				num = (short)1447428097;
				if (num != 0)
				{
				}
				num = (short)1525743616;
				if (num != 0)
				{
				}
				num = (short)749993984;
				short num3 = num;
				this.cnvPerEndTxOnVoiceAbsence_42460.Applicable = value;
			}
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x0600C3DB RID: 50139 RVA: 0x00B7C8AC File Offset: 0x00B7AAAC
		// (set) Token: 0x0600C3DC RID: 50140 RVA: 0x00B7C964 File Offset: 0x00B7AB64
		public bool CnvPerEndTxOnVoiceAbsence_42460_Valid
		{
			get
			{
				short num = (short)502402330;
				short num2 = num;
				num = (short)171576602;
				switch (num2 == num)
				{
				}
				num = (short)1721761793;
				if (num != 0)
				{
				}
				num = (short)572063744;
				if (num != 0)
				{
				}
				num = (short)584843264;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460.Valid;
			}
			set
			{
				short num = (short)1638201265;
				short num2 = num;
				num = (short)1394472881;
				switch (num2 == num)
				{
				}
				num = (short)56688640;
				if (num != 0)
				{
				}
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)51249152;
				short num3 = num;
				this.cnvPerEndTxOnVoiceAbsence_42460.Valid = value;
			}
		}

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x0600C3DD RID: 50141 RVA: 0x00B7CA1C File Offset: 0x00B7AC1C
		// (set) Token: 0x0600C3DE RID: 50142 RVA: 0x00B7CAD4 File Offset: 0x00B7ACD4
		public bool CnvPerEndTxOnVoiceAbsence_42460_Visible
		{
			get
			{
				short num = (short)388516716;
				short num2 = num;
				num = (short)275336044;
				switch (num2 == num)
				{
				}
				num = (short)1266221057;
				if (num != 0)
				{
				}
				num = (short)637599744;
				if (num != 0)
				{
				}
				num = (short)1140981760;
				short num3 = num;
				return this.cnvPerEndTxOnVoiceAbsence_42460.Visible;
			}
			set
			{
				short num = (short)2107226044;
				short num2 = num;
				num = (short)1529329596;
				switch (num2 == num)
				{
				}
				num = (short)1019150337;
				if (num != 0)
				{
				}
				num = (short)543621120;
				short num3 = num;
				num = (short)2293760;
				if (num != 0)
				{
				}
				this.cnvPerEndTxOnVoiceAbsence_42460.Visible = value;
			}
		}

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x0600C3DF RID: 50143 RVA: 0x00B7CB88 File Offset: 0x00B7AD88
		// (set) Token: 0x0600C3E0 RID: 50144 RVA: 0x00B7CC40 File Offset: 0x00B7AE40
		public bool CnvPerEndTxOnVoiceAbsence_42460_Editable
		{
			get
			{
				short num = (short)1714095261;
				short num2 = num;
				num = (short)1119814813;
				switch (num2 == num)
				{
				}
				num = (short)1972895744;
				if (num != 0)
				{
				}
				num = (short)739901440;
				short num3 = num;
				num = (short)2085683201;
				if (num != 0)
				{
				}
				return this.cnvPerEndTxOnVoiceAbsence_42460.Editable;
			}
			set
			{
				short num = (short)278724609;
				if (num != 0)
				{
				}
				num = (short)168360930;
				short num2 = num;
				num = (short)998112226;
				switch (num2 == num)
				{
				}
				num = (short)1760231424;
				short num3 = num;
				num = (short)801046528;
				if (num != 0)
				{
				}
				this.cnvPerEndTxOnVoiceAbsence_42460.Editable = value;
			}
		}

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x0600C3E1 RID: 50145 RVA: 0x00B7CCF4 File Offset: 0x00B7AEF4
		internal string CnvPerEndTxOnVoiceAbsence_42460_UILabel
		{
			get
			{
				short num = (short)1232650873;
				short num2 = num;
				num = (short)1945682553;
				switch (num2 == num)
				{
				}
				num = (short)1127546880;
				if (num != 0)
				{
				}
				num = (short)578224128;
				short num3 = num;
				num = (short)2140602369;
				if (num != 0)
				{
				}
				return this.cnvPerEndTxOnVoiceAbsence_42460.UIName;
			}
		}

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x0600C3E2 RID: 50146 RVA: 0x00B7CDA8 File Offset: 0x00B7AFA8
		// (set) Token: 0x0600C3E3 RID: 50147 RVA: 0x00B7CE5C File Offset: 0x00B7B05C
		internal bool CnvPerEndTxOnVoiceAbsence_42460_HiddenStatic
		{
			get
			{
				short num = (short)654303020;
				short num2 = num;
				num = (short)1389616940;
				switch (num2 == num)
				{
				}
				num = (short)559742976;
				if (num != 0)
				{
				}
				num = (short)1760100352;
				short num3 = num;
				num = (short)1475936257;
				if (num != 0)
				{
				}
				return this.cnvPerEndTxOnVoiceAbsence_42460.HiddenStatic;
			}
			set
			{
				short num = (short)465274119;
				short num2 = num;
				num = (short)1445233927;
				switch (num2 == num)
				{
				}
				num = (short)236126209;
				if (num != 0)
				{
				}
				num = (short)110362624;
				short num3 = num;
				num = (short)253034496;
				if (num != 0)
				{
				}
				this.cnvPerEndTxOnVoiceAbsence_42460.HiddenStatic = value;
			}
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x0600C3E4 RID: 50148 RVA: 0x00B7CF14 File Offset: 0x00B7B114
		// (set) Token: 0x0600C3E5 RID: 50149 RVA: 0x00B7CFCC File Offset: 0x00B7B1CC
		internal bool CnvPerEndTxOnVoiceAbsence_42460_HiddenDynamic
		{
			get
			{
				short num = (short)972029359;
				short num2 = num;
				num = (short)1972305327;
				switch (num2 == num)
				{
				}
				num = (short)2101739520;
				if (num != 0)
				{
				}
				num = (short)1208352768;
				short num3 = num;
				num = (short)1098383361;
				if (num != 0)
				{
				}
				return this.cnvPerEndTxOnVoiceAbsence_42460.HiddenDynamic;
			}
			set
			{
				short num = (short)2067753107;
				short num2 = num;
				num = (short)1309960339;
				switch (num2 == num)
				{
				}
				num = (short)515178496;
				if (num != 0)
				{
				}
				num = (short)2064318464;
				short num3 = num;
				num = (short)204013569;
				if (num != 0)
				{
				}
				this.cnvPerEndTxOnVoiceAbsence_42460.HiddenDynamic = value;
			}
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x0600C3E6 RID: 50150 RVA: 0x00B7D080 File Offset: 0x00B7B280
		public bool CnvPerEndTxOnVoiceAbsence_42460_HasDiffs
		{
			get
			{
				short num = (short)1924971604;
				short num2 = num;
				num = (short)289848404;
				switch (num2 == num)
				{
				}
				num = (short)1415643137;
				if (num != 0)
				{
				}
				num = (short)1093271552;
				short num3 = num;
				num = (short)2053505024;
				if (num != 0)
				{
				}
				return this.cnvPerEndTxOnVoiceAbsence_42460._HasDiffs;
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x00B7D134 File Offset: 0x00B7B334
		// (set) Token: 0x0600C3E8 RID: 50152 RVA: 0x00B7D1EC File Offset: 0x00B7B3EC
		public bool CnvPerFeatureDTMFMicEn_A42481Value
		{
			get
			{
				short num = (short)2050031617;
				if (num != 0)
				{
				}
				num = (short)1150475893;
				short num2 = num;
				num = (short)1196023413;
				switch (num2 == num)
				{
				}
				num = (short)112197632;
				short num3 = num;
				num = (short)1762787328;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Value;
			}
			set
			{
				short num = (short)386721640;
				short num2 = num;
				num = (short)827975528;
				switch (num2 == num)
				{
				}
				num = (short)1340342273;
				if (num != 0)
				{
				}
				num = (short)1136984064;
				short num3 = num;
				num = (short)537395200;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Value = value;
			}
		}

		// Token: 0x1700620C RID: 25100
		// (get) Token: 0x0600C3E9 RID: 50153 RVA: 0x00B7D2A4 File Offset: 0x00B7B4A4
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeatureDTMFMicEn_A42481
		{
			get
			{
				short num = (short)925199835;
				short num2 = num;
				num = (short)577334747;
				switch (num2 == num)
				{
				}
				num = (short)979304449;
				if (num != 0)
				{
				}
				num = (short)33816576;
				short num3 = num;
				num = (short)1781792768;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481;
			}
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x0600C3EA RID: 50154 RVA: 0x00B7D354 File Offset: 0x00B7B554
		// (set) Token: 0x0600C3EB RID: 50155 RVA: 0x00B7D40C File Offset: 0x00B7B60C
		public bool CnvPerFeatureDTMFMicEn_A42481_UIValue
		{
			get
			{
				short num = (short)1471112901;
				short num2 = num;
				num = (short)1003906757;
				switch (num2 == num)
				{
				}
				num = (short)551419904;
				if (num != 0)
				{
				}
				num = (short)1233387520;
				short num3 = num;
				num = (short)871563265;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Value;
			}
			set
			{
				short num = (short)1569153520;
				short num2 = num;
				num = (short)989946352;
				switch (num2 == num)
				{
				}
				num = (short)851968001;
				if (num != 0)
				{
				}
				num = (short)1637613568;
				short num3 = num;
				num = (short)2082275328;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Value = value;
			}
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x0600C3EC RID: 50156 RVA: 0x00B7D4C0 File Offset: 0x00B7B6C0
		// (set) Token: 0x0600C3ED RID: 50157 RVA: 0x00B7D574 File Offset: 0x00B7B774
		public bool CnvPerFeatureDTMFMicEn_A42481_Applicable
		{
			get
			{
				short num = (short)744697561;
				short num2 = num;
				num = (short)1626615513;
				switch (num2 == num)
				{
				}
				num = (short)13631489;
				if (num != 0)
				{
				}
				num = (short)2142765056;
				short num3 = num;
				num = (short)774176768;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Applicable;
			}
			set
			{
				short num = (short)1718380357;
				short num2 = num;
				num = (short)684746565;
				switch (num2 == num)
				{
				}
				num = (short)165937152;
				if (num != 0)
				{
				}
				num = (short)1049493504;
				short num3 = num;
				num = (short)590348289;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Applicable = value;
			}
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x00B7D62C File Offset: 0x00B7B82C
		// (set) Token: 0x0600C3EF RID: 50159 RVA: 0x00B7D6E0 File Offset: 0x00B7B8E0
		public bool CnvPerFeatureDTMFMicEn_A42481_Valid
		{
			get
			{
				short num = (short)2086696784;
				short num2 = num;
				num = (short)454195024;
				switch (num2 == num)
				{
				}
				num = (short)1402404864;
				if (num != 0)
				{
				}
				num = (short)811597824;
				short num3 = num;
				num = (short)1477509121;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Valid;
			}
			set
			{
				short num = (short)168316383;
				short num2 = num;
				num = (short)593776095;
				switch (num2 == num)
				{
				}
				num = (short)1353515009;
				if (num != 0)
				{
				}
				num = (short)1932525568;
				short num3 = num;
				num = (short)1448280064;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Valid = value;
			}
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x00B7D794 File Offset: 0x00B7B994
		// (set) Token: 0x0600C3F1 RID: 50161 RVA: 0x00B7D848 File Offset: 0x00B7BA48
		public bool CnvPerFeatureDTMFMicEn_A42481_Visible
		{
			get
			{
				short num = (short)1265932908;
				short num2 = num;
				num = (short)2036636268;
				switch (num2 == num)
				{
				}
				num = (short)775094272;
				if (num != 0)
				{
				}
				num = (short)1811415040;
				short num3 = num;
				num = (short)2087190529;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Visible;
			}
			set
			{
				short num = (short)1358989406;
				short num2 = num;
				num = (short)909871198;
				switch (num2 == num)
				{
				}
				num = (short)428474369;
				if (num != 0)
				{
				}
				num = (short)515768320;
				short num3 = num;
				num = (short)377290752;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Visible = value;
			}
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x00B7D8FC File Offset: 0x00B7BAFC
		// (set) Token: 0x0600C3F3 RID: 50163 RVA: 0x00B7D9B4 File Offset: 0x00B7BBB4
		public bool CnvPerFeatureDTMFMicEn_A42481_Editable
		{
			get
			{
				short num = (short)932789061;
				short num2 = num;
				num = (short)224279365;
				switch (num2 == num)
				{
				}
				num = (short)1407188992;
				if (num != 0)
				{
				}
				num = (short)1119813632;
				short num3 = num;
				num = (short)1677197313;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.Editable;
			}
			set
			{
				short num = (short)93027979;
				short num2 = num;
				num = (short)1464565387;
				switch (num2 == num)
				{
				}
				num = (short)1180631040;
				if (num != 0)
				{
				}
				num = (short)2113470464;
				short num3 = num;
				num = (short)384630785;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.Editable = value;
			}
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x0600C3F4 RID: 50164 RVA: 0x00B7DA68 File Offset: 0x00B7BC68
		internal string CnvPerFeatureDTMFMicEn_A42481_UILabel
		{
			get
			{
				short num = (short)674970782;
				short num2 = num;
				num = (short)1928346782;
				switch (num2 == num)
				{
				}
				num = (short)1199308801;
				if (num != 0)
				{
				}
				num = (short)1119158272;
				short num3 = num;
				num = (short)1611530240;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.UIName;
			}
		}

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x0600C3F5 RID: 50165 RVA: 0x00B7DB1C File Offset: 0x00B7BD1C
		// (set) Token: 0x0600C3F6 RID: 50166 RVA: 0x00B7DBD8 File Offset: 0x00B7BDD8
		internal bool CnvPerFeatureDTMFMicEn_A42481_HiddenStatic
		{
			get
			{
				short num = (short)1769476662;
				short num2 = num;
				num = (short)265097782;
				switch (num2 == num)
				{
				}
				num = (short)535953409;
				if (num != 0)
				{
				}
				num = (short)413401088;
				short num3 = num;
				num = (short)1185677312;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.HiddenStatic;
			}
			set
			{
				short num = (short)1801977857;
				if (num != 0)
				{
				}
				num = (short)151688206;
				short num2 = num;
				num = (short)1567593486;
				switch (num2 == num)
				{
				}
				num = (short)1524760576;
				short num3 = num;
				num = (short)1636171776;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.HiddenStatic = value;
			}
		}

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x0600C3F7 RID: 50167 RVA: 0x00B7DC90 File Offset: 0x00B7BE90
		// (set) Token: 0x0600C3F8 RID: 50168 RVA: 0x00B7DD44 File Offset: 0x00B7BF44
		internal bool CnvPerFeatureDTMFMicEn_A42481_HiddenDynamic
		{
			get
			{
				short num = (short)1961192121;
				short num2 = num;
				num = (short)2126146233;
				switch (num2 == num)
				{
				}
				num = (short)297861121;
				if (num != 0)
				{
				}
				num = (short)1105592320;
				short num3 = num;
				num = (short)1017577472;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481.HiddenDynamic;
			}
			set
			{
				short num = (short)2121596929;
				if (num != 0)
				{
				}
				num = (short)1011974719;
				short num2 = num;
				num = (short)284131903;
				switch (num2 == num)
				{
				}
				num = (short)920125440;
				short num3 = num;
				num = (short)965935104;
				if (num != 0)
				{
				}
				this.cnvPerFeatureDTMFMicEn_A42481.HiddenDynamic = value;
			}
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x0600C3F9 RID: 50169 RVA: 0x00B7DDF8 File Offset: 0x00B7BFF8
		public bool CnvPerFeatureDTMFMicEn_A42481_HasDiffs
		{
			get
			{
				short num = (short)860337570;
				short num2 = num;
				num = (short)138458530;
				switch (num2 == num)
				{
				}
				num = (short)314114049;
				if (num != 0)
				{
				}
				num = (short)1011023872;
				short num3 = num;
				num = (short)1007419392;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureDTMFMicEn_A42481._HasDiffs;
			}
		}

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x00B7DEAC File Offset: 0x00B7C0AC
		// (set) Token: 0x0600C3FB RID: 50171 RVA: 0x00B7DF60 File Offset: 0x00B7C160
		public int CnvPerFeatureRFModem_42485Value
		{
			get
			{
				short num = (short)1078563761;
				short num2 = num;
				num = (short)1200985009;
				switch (num2 == num)
				{
				}
				num = (short)144506880;
				if (num != 0)
				{
				}
				num = (short)2060976128;
				short num3 = num;
				num = (short)247267329;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.Value;
			}
			set
			{
				short num = (short)294250219;
				short num2 = num;
				num = (short)1381426923;
				switch (num2 == num)
				{
				}
				num = (short)594673664;
				if (num != 0)
				{
				}
				num = (short)1934032896;
				short num3 = num;
				num = (short)1452081153;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.Value = value;
			}
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x0600C3FC RID: 50172 RVA: 0x00B7E014 File Offset: 0x00B7C214
		// (set) Token: 0x0600C3FD RID: 50173 RVA: 0x00B7E0CC File Offset: 0x00B7C2CC
		public string CnvPerFeatureRFModem_42485_UIValue
		{
			get
			{
				short num = (short)1410990081;
				if (num != 0)
				{
				}
				num = (short)809496919;
				short num2 = num;
				num = (short)319615319;
				switch (num2 == num)
				{
				}
				num = (short)168951808;
				short num3 = num;
				num = (short)861208576;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.UIValue;
			}
			set
			{
				short num = (short)1578616511;
				short num2 = num;
				num = (short)1097516735;
				switch (num2 == num)
				{
				}
				num = (short)1399652352;
				if (num != 0)
				{
				}
				num = (short)1602420736;
				short num3 = num;
				num = (short)1379991553;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.UIValue = value;
			}
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x0600C3FE RID: 50174 RVA: 0x00B7E188 File Offset: 0x00B7C388
		public global::AcpBusinessLayer.AcpListField CnvPerFeatureRFModem_42485
		{
			get
			{
				short num = (short)824601890;
				short num2 = num;
				num = (short)1864527138;
				switch (num2 == num)
				{
				}
				num = (short)1349844993;
				if (num != 0)
				{
				}
				num = (short)1448148992;
				short num3 = num;
				num = (short)506920960;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485;
			}
		}

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x0600C3FF RID: 50175 RVA: 0x00B7E238 File Offset: 0x00B7C438
		// (set) Token: 0x0600C400 RID: 50176 RVA: 0x00B7E2EC File Offset: 0x00B7C4EC
		public bool CnvPerFeatureRFModem_42485_Applicable
		{
			get
			{
				short num = (short)1355420089;
				short num2 = num;
				num = (short)547885497;
				switch (num2 == num)
				{
				}
				num = (short)1293484033;
				if (num != 0)
				{
				}
				num = (short)68222976;
				short num3 = num;
				num = (short)2026569728;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.Applicable;
			}
			set
			{
				short num = (short)1450939698;
				short num2 = num;
				num = (short)944739634;
				switch (num2 == num)
				{
				}
				num = (short)905314305;
				if (num != 0)
				{
				}
				num = (short)1985806336;
				short num3 = num;
				num = (short)495910912;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.Applicable = value;
			}
		}

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x0600C401 RID: 50177 RVA: 0x00B7E3A0 File Offset: 0x00B7C5A0
		// (set) Token: 0x0600C402 RID: 50178 RVA: 0x00B7E454 File Offset: 0x00B7C654
		public bool CnvPerFeatureRFModem_42485_Valid
		{
			get
			{
				short num = (short)234453381;
				short num2 = num;
				num = (short)871332229;
				switch (num2 == num)
				{
				}
				num = (short)1655504897;
				if (num != 0)
				{
				}
				num = (short)550633472;
				short num3 = num;
				num = (short)521011200;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.Valid;
			}
			set
			{
				short num = (short)676100355;
				short num2 = num;
				num = (short)2100787459;
				switch (num2 == num)
				{
				}
				num = (short)285802497;
				if (num != 0)
				{
				}
				num = (short)2073821184;
				short num3 = num;
				num = (short)1055719424;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.Valid = value;
			}
		}

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x0600C403 RID: 50179 RVA: 0x00B7E508 File Offset: 0x00B7C708
		// (set) Token: 0x0600C404 RID: 50180 RVA: 0x00B7E5BC File Offset: 0x00B7C7BC
		public bool CnvPerFeatureRFModem_42485_Visible
		{
			get
			{
				short num = (short)1747167585;
				short num2 = num;
				num = (short)1663609185;
				switch (num2 == num)
				{
				}
				num = (short)910622720;
				if (num != 0)
				{
				}
				num = (short)1280770048;
				short num3 = num;
				num = (short)197984257;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.Visible;
			}
			set
			{
				short num = (short)1300889601;
				if (num != 0)
				{
				}
				num = (short)1348157621;
				short num2 = num;
				num = (short)337526965;
				switch (num2 == num)
				{
				}
				num = (short)684720128;
				short num3 = num;
				num = (short)1174405120;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.Visible = value;
			}
		}

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x0600C405 RID: 50181 RVA: 0x00B7E674 File Offset: 0x00B7C874
		// (set) Token: 0x0600C406 RID: 50182 RVA: 0x00B7E728 File Offset: 0x00B7C928
		public bool CnvPerFeatureRFModem_42485_Editable
		{
			get
			{
				short num = (short)88678896;
				short num2 = num;
				num = (short)2074616304;
				switch (num2 == num)
				{
				}
				num = (short)1513095169;
				if (num != 0)
				{
				}
				num = (short)1974337536;
				short num3 = num;
				num = (short)843186176;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.Editable;
			}
			set
			{
				short num = (short)1482247139;
				short num2 = num;
				num = (short)1708280803;
				switch (num2 == num)
				{
				}
				num = (short)1003225089;
				if (num != 0)
				{
				}
				num = (short)168886272;
				short num3 = num;
				num = (short)917897216;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.Editable = value;
			}
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x0600C407 RID: 50183 RVA: 0x00B7E7DC File Offset: 0x00B7C9DC
		internal string CnvPerFeatureRFModem_42485_UILabel
		{
			get
			{
				short num = (short)1502626111;
				short num2 = num;
				num = (short)1991917887;
				switch (num2 == num)
				{
				}
				num = (short)416219136;
				if (num != 0)
				{
				}
				num = (short)1664876544;
				short num3 = num;
				num = (short)1842675713;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.UIName;
			}
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x0600C408 RID: 50184 RVA: 0x00B7E890 File Offset: 0x00B7CA90
		// (set) Token: 0x0600C409 RID: 50185 RVA: 0x00B7E944 File Offset: 0x00B7CB44
		internal bool CnvPerFeatureRFModem_42485_HiddenStatic
		{
			get
			{
				short num = (short)158329291;
				short num2 = num;
				num = (short)1713236427;
				switch (num2 == num)
				{
				}
				num = (short)148897792;
				if (num != 0)
				{
				}
				num = (short)2014707712;
				short num3 = num;
				num = (short)1573060609;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.HiddenStatic;
			}
			set
			{
				short num = (short)2029182785;
				short num2 = num;
				num = (short)1033428801;
				switch (num2 == num)
				{
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				num = (short)1116798976;
				short num3 = num;
				num = (short)436731905;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.HiddenStatic = value;
			}
		}

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x0600C40A RID: 50186 RVA: 0x00B7E9F8 File Offset: 0x00B7CBF8
		// (set) Token: 0x0600C40B RID: 50187 RVA: 0x00B7EAAC File Offset: 0x00B7CCAC
		internal bool CnvPerFeatureRFModem_42485_HiddenDynamic
		{
			get
			{
				short num = (short)2125266945;
				if (num != 0)
				{
				}
				num = (short)1700029695;
				short num2 = num;
				num = (short)530867455;
				switch (num2 == num)
				{
				}
				num = (short)209190912;
				short num3 = num;
				num = (short)246153216;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485.HiddenDynamic;
			}
			set
			{
				short num = (short)1668460472;
				short num2 = num;
				num = (short)1921757112;
				switch (num2 == num)
				{
				}
				num = (short)219938817;
				if (num != 0)
				{
				}
				num = (short)1592000512;
				short num3 = num;
				num = (short)685834240;
				if (num != 0)
				{
				}
				this.cnvPerFeatureRFModem_42485.HiddenDynamic = value;
			}
		}

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x0600C40C RID: 50188 RVA: 0x00B7EB60 File Offset: 0x00B7CD60
		public bool CnvPerFeatureRFModem_42485_HasDiffs
		{
			get
			{
				short num = (short)10158081;
				if (num != 0)
				{
				}
				num = (short)577181962;
				short num2 = num;
				num = (short)881334538;
				switch (num2 == num)
				{
				}
				num = (short)687079424;
				short num3 = num;
				num = (short)166264832;
				if (num != 0)
				{
				}
				return this.cnvPerFeatureRFModem_42485._HasDiffs;
			}
		}

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x0600C40D RID: 50189 RVA: 0x00B7EC14 File Offset: 0x00B7CE14
		// (set) Token: 0x0600C40E RID: 50190 RVA: 0x00B7ECC8 File Offset: 0x00B7CEC8
		public int CnvPerFeaturesOTARadioAliasType_42784Value
		{
			get
			{
				short num = (short)1339372932;
				short num2 = num;
				num = (short)671036804;
				switch (num2 == num)
				{
				}
				num = (short)2095120384;
				if (num != 0)
				{
				}
				num = (short)1355939840;
				short num3 = num;
				num = (short)374669313;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.Value;
			}
			set
			{
				short num = (short)1483334630;
				short num2 = num;
				num = (short)935257062;
				switch (num2 == num)
				{
				}
				num = (short)1346568193;
				if (num != 0)
				{
				}
				num = (short)440139776;
				short num3 = num;
				num = (short)1764163584;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.Value = value;
			}
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x0600C40F RID: 50191 RVA: 0x00B7ED80 File Offset: 0x00B7CF80
		// (set) Token: 0x0600C410 RID: 50192 RVA: 0x00B7EE38 File Offset: 0x00B7D038
		public string CnvPerFeaturesOTARadioAliasType_42784_UIValue
		{
			get
			{
				short num = (short)81657857;
				if (num != 0)
				{
				}
				num = (short)312159318;
				short num2 = num;
				num = (short)511454294;
				switch (num2 == num)
				{
				}
				num = (short)166199296;
				short num3 = num;
				num = (short)1115488256;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.UIValue;
			}
			set
			{
				short num = (short)1758034564;
				short num2 = num;
				num = (short)2104785540;
				switch (num2 == num)
				{
				}
				num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)2076639232;
				short num3 = num;
				num = (short)672661504;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.UIValue = value;
			}
		}

		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x0600C411 RID: 50193 RVA: 0x00B7EEF0 File Offset: 0x00B7D0F0
		public global::AcpBusinessLayer.AcpListField CnvPerFeaturesOTARadioAliasType_42784
		{
			get
			{
				short num = (short)1203338627;
				short num2 = num;
				num = (short)1186626947;
				switch (num2 == num)
				{
				}
				num = (short)827260929;
				if (num != 0)
				{
				}
				num = (short)1272709120;
				short num3 = num;
				num = (short)2076311552;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784;
			}
		}

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x0600C412 RID: 50194 RVA: 0x00B7EFA0 File Offset: 0x00B7D1A0
		// (set) Token: 0x0600C413 RID: 50195 RVA: 0x00B7F054 File Offset: 0x00B7D254
		public bool CnvPerFeaturesOTARadioAliasType_42784_Applicable
		{
			get
			{
				short num = (short)35549869;
				short num2 = num;
				num = (short)1451324077;
				switch (num2 == num)
				{
				}
				num = (short)773783553;
				if (num != 0)
				{
				}
				num = (short)2070216704;
				short num3 = num;
				num = (short)1546059776;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.Applicable;
			}
			set
			{
				short num = (short)73035602;
				short num2 = num;
				num = (short)1926262610;
				switch (num2 == num)
				{
				}
				num = (short)368902145;
				if (num != 0)
				{
				}
				num = (short)1870004224;
				short num3 = num;
				num = (short)1433010176;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.Applicable = value;
			}
		}

		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x0600C414 RID: 50196 RVA: 0x00B7F108 File Offset: 0x00B7D308
		// (set) Token: 0x0600C415 RID: 50197 RVA: 0x00B7F1BC File Offset: 0x00B7D3BC
		public bool CnvPerFeaturesOTARadioAliasType_42784_Valid
		{
			get
			{
				short num = (short)1713049638;
				short num2 = num;
				num = (short)587075622;
				switch (num2 == num)
				{
				}
				num = (short)1174732801;
				if (num != 0)
				{
				}
				num = (short)992739328;
				short num3 = num;
				num = (short)428015616;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.Valid;
			}
			set
			{
				short num = (short)1059731761;
				short num2 = num;
				num = (short)752695601;
				switch (num2 == num)
				{
				}
				num = (short)1970339841;
				if (num != 0)
				{
				}
				num = (short)320995328;
				short num3 = num;
				num = (short)869793792;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.Valid = value;
			}
		}

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x0600C416 RID: 50198 RVA: 0x00B7F270 File Offset: 0x00B7D470
		// (set) Token: 0x0600C417 RID: 50199 RVA: 0x00B7F324 File Offset: 0x00B7D524
		public bool CnvPerFeaturesOTARadioAliasType_42784_Visible
		{
			get
			{
				short num = (short)1457113086;
				short num2 = num;
				num = (short)1574946814;
				switch (num2 == num)
				{
				}
				num = (short)1573191681;
				if (num != 0)
				{
				}
				num = (short)1351155712;
				short num3 = num;
				num = (short)1660289024;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.Visible;
			}
			set
			{
				short num = (short)1899489707;
				short num2 = num;
				num = (short)1399450027;
				switch (num2 == num)
				{
				}
				num = (short)1930362880;
				if (num != 0)
				{
				}
				num = (short)1490485248;
				short num3 = num;
				num = (short)1186463745;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.Visible = value;
			}
		}

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x0600C418 RID: 50200 RVA: 0x00B7F3D8 File Offset: 0x00B7D5D8
		// (set) Token: 0x0600C419 RID: 50201 RVA: 0x00B7F48C File Offset: 0x00B7D68C
		public bool CnvPerFeaturesOTARadioAliasType_42784_Editable
		{
			get
			{
				short num = (short)1663381098;
				short num2 = num;
				num = (short)228535914;
				switch (num2 == num)
				{
				}
				num = (short)679018496;
				if (num != 0)
				{
				}
				num = (short)2119827456;
				short num3 = num;
				num = (short)872022017;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.Editable;
			}
			set
			{
				short num = (short)1121285235;
				short num2 = num;
				num = (short)1753838707;
				switch (num2 == num)
				{
				}
				num = (short)1821179905;
				if (num != 0)
				{
				}
				num = (short)1699086336;
				short num3 = num;
				num = (short)6553600;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.Editable = value;
			}
		}

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x0600C41A RID: 50202 RVA: 0x00B7F540 File Offset: 0x00B7D740
		internal string CnvPerFeaturesOTARadioAliasType_42784_UILabel
		{
			get
			{
				short num = (short)2092695552;
				short num2 = num;
				num = (short)137953991;
				short num3 = num;
				num = (short)654574279;
				switch (num3 == num)
				{
				}
				num = (short)838402049;
				if (num != 0)
				{
				}
				num = (short)920977408;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.UIName;
			}
		}

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x0600C41B RID: 50203 RVA: 0x00B7F5F4 File Offset: 0x00B7D7F4
		// (set) Token: 0x0600C41C RID: 50204 RVA: 0x00B7F6AC File Offset: 0x00B7D8AC
		internal bool CnvPerFeaturesOTARadioAliasType_42784_HiddenStatic
		{
			get
			{
				short num = (short)277413888;
				short num2 = num;
				num = (short)358172684;
				short num3 = num;
				num = (short)1738885132;
				switch (num3 == num)
				{
				}
				num = (short)902823937;
				if (num != 0)
				{
				}
				num = (short)1030356992;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.HiddenStatic;
			}
			set
			{
				short num = (short)1228013568;
				short num2 = num;
				num = (short)1532220641;
				short num3 = num;
				num = (short)1817892065;
				switch (num3 == num)
				{
				}
				num = (short)2083454976;
				if (num != 0)
				{
				}
				num = (short)1256652801;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.HiddenStatic = value;
			}
		}

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x0600C41D RID: 50205 RVA: 0x00B7F760 File Offset: 0x00B7D960
		// (set) Token: 0x0600C41E RID: 50206 RVA: 0x00B7F814 File Offset: 0x00B7DA14
		internal bool CnvPerFeaturesOTARadioAliasType_42784_HiddenDynamic
		{
			get
			{
				short num = (short)1583808512;
				short num2 = num;
				num = (short)1973867880;
				short num3 = num;
				num = (short)1488639336;
				switch (num3 == num)
				{
				}
				num = (short)74842112;
				if (num != 0)
				{
				}
				num = (short)90177537;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784.HiddenDynamic;
			}
			set
			{
				short num = (short)1764687872;
				short num2 = num;
				num = (short)546106654;
				short num3 = num;
				num = (short)583920926;
				switch (num3 == num)
				{
				}
				num = (short)1881210880;
				if (num != 0)
				{
				}
				num = (short)2090598401;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasType_42784.HiddenDynamic = value;
			}
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x00B7F8CC File Offset: 0x00B7DACC
		public bool CnvPerFeaturesOTARadioAliasType_42784_HasDiffs
		{
			get
			{
				short num = (short)614268928;
				short num2 = num;
				num = (short)2009014440;
				short num3 = num;
				num = (short)241246376;
				switch (num3 == num)
				{
				}
				num = (short)410517505;
				if (num != 0)
				{
				}
				num = (short)185794560;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasType_42784._HasDiffs;
			}
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x0600C420 RID: 50208 RVA: 0x00B7F984 File Offset: 0x00B7DB84
		// (set) Token: 0x0600C421 RID: 50209 RVA: 0x00B7FA3C File Offset: 0x00B7DC3C
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785Value
		{
			get
			{
				short num = (short)1234305024;
				short num2 = num;
				num = (short)763691193;
				short num3 = num;
				num = (short)17170617;
				switch (num3 == num)
				{
				}
				num = (short)475922432;
				if (num != 0)
				{
				}
				num = (short)530120705;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Value;
			}
			set
			{
				short num = (short)1564999680;
				short num2 = num;
				num = (short)452154635;
				short num3 = num;
				num = (short)645354763;
				switch (num3 == num)
				{
				}
				num = (short)1970864129;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Value = value;
			}
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x0600C422 RID: 50210 RVA: 0x00B7FAF0 File Offset: 0x00B7DCF0
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesConvetionalRSSIDisplay_42785
		{
			get
			{
				short num = (short)1564606464;
				short num2 = num;
				num = (short)684851201;
				if (num != 0)
				{
				}
				num = (short)503631037;
				short num3 = num;
				num = (short)1052363965;
				switch (num3 == num)
				{
				}
				num = (short)316997632;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785;
			}
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x0600C423 RID: 50211 RVA: 0x00B7FBA0 File Offset: 0x00B7DDA0
		// (set) Token: 0x0600C424 RID: 50212 RVA: 0x00B7FC54 File Offset: 0x00B7DE54
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_UIValue
		{
			get
			{
				short num = (short)794296320;
				short num2 = num;
				num = (short)754365779;
				short num3 = num;
				num = (short)1419818323;
				switch (num3 == num)
				{
				}
				num = (short)1092485120;
				if (num != 0)
				{
				}
				num = (short)389808129;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Value;
			}
			set
			{
				short num = (short)1408172032;
				short num2 = num;
				num = (short)858910274;
				short num3 = num;
				num = (short)1957752386;
				switch (num3 == num)
				{
				}
				num = (short)95682561;
				if (num != 0)
				{
				}
				num = (short)863698944;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Value = value;
			}
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x0600C425 RID: 50213 RVA: 0x00B7FD08 File Offset: 0x00B7DF08
		// (set) Token: 0x0600C426 RID: 50214 RVA: 0x00B7FDC0 File Offset: 0x00B7DFC0
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_Applicable
		{
			get
			{
				short num = (short)552534016;
				short num2 = num;
				num = (short)216911343;
				short num3 = num;
				num = (short)1981599215;
				switch (num3 == num)
				{
				}
				num = (short)472973312;
				if (num != 0)
				{
				}
				num = (short)1960050689;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Applicable;
			}
			set
			{
				short num = (short)536150016;
				short num2 = num;
				num = (short)1190989097;
				short num3 = num;
				num = (short)386927913;
				switch (num3 == num)
				{
				}
				num = (short)1334771713;
				if (num != 0)
				{
				}
				num = (short)1274281984;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Applicable = value;
			}
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x0600C427 RID: 50215 RVA: 0x00B7FE78 File Offset: 0x00B7E078
		// (set) Token: 0x0600C428 RID: 50216 RVA: 0x00B7FF2C File Offset: 0x00B7E12C
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_Valid
		{
			get
			{
				short num = (short)1643970560;
				short num2 = num;
				num = (short)567572604;
				short num3 = num;
				num = (short)1118533756;
				switch (num3 == num)
				{
				}
				num = (short)1689255937;
				if (num != 0)
				{
				}
				num = (short)479854592;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Valid;
			}
			set
			{
				short num = (short)1547567104;
				short num2 = num;
				num = (short)1859796091;
				short num3 = num;
				num = (short)1317747835;
				switch (num3 == num)
				{
				}
				num = (short)1105526785;
				if (num != 0)
				{
				}
				num = (short)2008350720;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Valid = value;
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x0600C429 RID: 50217 RVA: 0x00B7FFE4 File Offset: 0x00B7E1E4
		// (set) Token: 0x0600C42A RID: 50218 RVA: 0x00B80098 File Offset: 0x00B7E298
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_Visible
		{
			get
			{
				short num = (short)1431175168;
				short num2 = num;
				num = (short)252313601;
				if (num != 0)
				{
				}
				num = (short)1214118406;
				short num3 = num;
				num = (short)1076361734;
				switch (num3 == num)
				{
				}
				num = (short)1558642688;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Visible;
			}
			set
			{
				short num = (short)460390400;
				short num2 = num;
				num = (short)697144511;
				short num3 = num;
				num = (short)598840511;
				switch (num3 == num)
				{
				}
				num = (short)528351232;
				if (num != 0)
				{
				}
				num = (short)1963458561;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Visible = value;
			}
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x0600C42B RID: 50219 RVA: 0x00B80150 File Offset: 0x00B7E350
		// (set) Token: 0x0600C42C RID: 50220 RVA: 0x00B80208 File Offset: 0x00B7E408
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_Editable
		{
			get
			{
				short num = (short)867762176;
				short num2 = num;
				num = (short)275733853;
				short num3 = num;
				num = (short)2041863517;
				switch (num3 == num)
				{
				}
				num = (short)1868824577;
				if (num != 0)
				{
				}
				num = (short)602406912;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Editable;
			}
			set
			{
				short num = (short)1186398208;
				short num2 = num;
				num = (short)792440119;
				short num3 = num;
				num = (short)2002365751;
				switch (num3 == num)
				{
				}
				num = (short)1812070401;
				if (num != 0)
				{
				}
				num = (short)1089339392;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.Editable = value;
			}
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x0600C42D RID: 50221 RVA: 0x00B802C0 File Offset: 0x00B7E4C0
		internal string CnvPerFeaturesConvetionalRSSIDisplay_42785_UILabel
		{
			get
			{
				short num = (short)476250112;
				short num2 = num;
				num = (short)1343480917;
				short num3 = num;
				num = (short)1652679765;
				switch (num3 == num)
				{
				}
				num = (short)1920270337;
				if (num != 0)
				{
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.UIName;
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x0600C42E RID: 50222 RVA: 0x00B80374 File Offset: 0x00B7E574
		// (set) Token: 0x0600C42F RID: 50223 RVA: 0x00B80428 File Offset: 0x00B7E628
		internal bool CnvPerFeaturesConvetionalRSSIDisplay_42785_HiddenStatic
		{
			get
			{
				short num = (short)11730944;
				short num2 = num;
				num = (short)1448017921;
				if (num != 0)
				{
				}
				num = (short)1098994094;
				short num3 = num;
				num = (short)268652974;
				switch (num3 == num)
				{
				}
				num = (short)659750912;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.HiddenStatic;
			}
			set
			{
				short num = (short)1349058560;
				short num2 = num;
				num = (short)349981882;
				short num3 = num;
				num = (short)1978813626;
				switch (num3 == num)
				{
				}
				num = (short)575340545;
				if (num != 0)
				{
				}
				num = (short)1850474496;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.HiddenStatic = value;
			}
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x0600C430 RID: 50224 RVA: 0x00B804E4 File Offset: 0x00B7E6E4
		// (set) Token: 0x0600C431 RID: 50225 RVA: 0x00B8059C File Offset: 0x00B7E79C
		internal bool CnvPerFeaturesConvetionalRSSIDisplay_42785_HiddenDynamic
		{
			get
			{
				short num = (short)1088028672;
				short num2 = num;
				num = (short)1163579836;
				short num3 = num;
				num = (short)1352323516;
				switch (num3 == num)
				{
				}
				num = (short)820183041;
				if (num != 0)
				{
				}
				num = (short)611450880;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785.HiddenDynamic;
			}
			set
			{
				short num = (short)1609302016;
				short num2 = num;
				num = (short)1963681627;
				short num3 = num;
				num = (short)64251739;
				switch (num3 == num)
				{
				}
				num = (short)2129788929;
				if (num != 0)
				{
				}
				num = (short)1191051264;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesConvetionalRSSIDisplay_42785.HiddenDynamic = value;
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x0600C432 RID: 50226 RVA: 0x00B80650 File Offset: 0x00B7E850
		public bool CnvPerFeaturesConvetionalRSSIDisplay_42785_HasDiffs
		{
			get
			{
				short num = (short)865796096;
				short num2 = num;
				num = (short)1867541607;
				short num3 = num;
				num = (short)960785511;
				switch (num3 == num)
				{
				}
				num = (short)893648897;
				if (num != 0)
				{
				}
				num = (short)425328640;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesConvetionalRSSIDisplay_42785._HasDiffs;
			}
		}

		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x0600C433 RID: 50227 RVA: 0x00B80704 File Offset: 0x00B7E904
		// (set) Token: 0x0600C434 RID: 50228 RVA: 0x00B807B8 File Offset: 0x00B7E9B8
		public bool CnvPerFeaturesHazardZoneModePersonalityValue
		{
			get
			{
				short num = (short)1319632896;
				short num2 = num;
				num = (short)454390739;
				short num3 = num;
				num = (short)1988522963;
				switch (num3 == num)
				{
				}
				num = (short)2097283073;
				if (num != 0)
				{
				}
				num = (short)1522139136;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Value;
			}
			set
			{
				short num = (short)1640562688;
				short num2 = num;
				num = (short)1057444881;
				short num3 = num;
				num = (short)689460241;
				switch (num3 == num)
				{
				}
				num = (short)645660673;
				if (num != 0)
				{
				}
				num = (short)834797568;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Value = value;
			}
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x0600C435 RID: 50229 RVA: 0x00B8086C File Offset: 0x00B7EA6C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesHazardZoneModePersonality
		{
			get
			{
				short num = (short)1183186944;
				short num2 = num;
				num = (short)34340865;
				if (num != 0)
				{
				}
				num = (short)971177423;
				short num3 = num;
				num = (short)209321423;
				switch (num3 == num)
				{
				}
				num = (short)1717043200;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality;
			}
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x0600C436 RID: 50230 RVA: 0x00B80918 File Offset: 0x00B7EB18
		// (set) Token: 0x0600C437 RID: 50231 RVA: 0x00B809CC File Offset: 0x00B7EBCC
		public bool CnvPerFeaturesHazardZoneModePersonality_UIValue
		{
			get
			{
				short num = (short)515112960;
				short num2 = num;
				num = (short)54067602;
				short num3 = num;
				num = (short)563216786;
				switch (num3 == num)
				{
				}
				num = (short)1064173569;
				if (num != 0)
				{
				}
				num = (short)1700462592;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Value;
			}
			set
			{
				short num = (short)15532032;
				short num2 = num;
				num = (short)620977153;
				short num3 = num;
				num = (short)1169120257;
				switch (num3 == num)
				{
				}
				num = (short)2114453505;
				if (num != 0)
				{
				}
				num = (short)1267073024;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Value = value;
			}
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x0600C438 RID: 50232 RVA: 0x00B80A80 File Offset: 0x00B7EC80
		// (set) Token: 0x0600C439 RID: 50233 RVA: 0x00B80B34 File Offset: 0x00B7ED34
		public bool CnvPerFeaturesHazardZoneModePersonality_Applicable
		{
			get
			{
				short num = (short)167837696;
				short num2 = num;
				num = (short)489861511;
				short num3 = num;
				num = (short)1938731399;
				switch (num3 == num)
				{
				}
				num = (short)1725038592;
				if (num != 0)
				{
				}
				num = (short)801439745;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Applicable;
			}
			set
			{
				short num = (short)1434189824;
				short num2 = num;
				num = (short)1203867479;
				short num3 = num;
				num = (short)536645463;
				switch (num3 == num)
				{
				}
				num = (short)791412737;
				if (num != 0)
				{
				}
				num = (short)1903820800;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Applicable = value;
			}
		}

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x0600C43A RID: 50234 RVA: 0x00B80BE8 File Offset: 0x00B7EDE8
		// (set) Token: 0x0600C43B RID: 50235 RVA: 0x00B80C9C File Offset: 0x00B7EE9C
		public bool CnvPerFeaturesHazardZoneModePersonality_Valid
		{
			get
			{
				short num = (short)1258749952;
				short num2 = num;
				num = (short)543587062;
				short num3 = num;
				num = (short)2010872566;
				switch (num3 == num)
				{
				}
				num = (short)53018624;
				if (num != 0)
				{
				}
				num = (short)218955777;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Valid;
			}
			set
			{
				short num = (short)1788215296;
				short num2 = num;
				num = (short)1133497409;
				short num3 = num;
				num = (short)2020723777;
				switch (num3 == num)
				{
				}
				num = (short)595132417;
				if (num != 0)
				{
				}
				num = (short)1263271936;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Valid = value;
			}
		}

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x0600C43C RID: 50236 RVA: 0x00B80D54 File Offset: 0x00B7EF54
		// (set) Token: 0x0600C43D RID: 50237 RVA: 0x00B80E0C File Offset: 0x00B7F00C
		public bool CnvPerFeaturesHazardZoneModePersonality_Visible
		{
			get
			{
				short num = (short)1576468480;
				short num2 = num;
				num = (short)1196891944;
				short num3 = num;
				num = (short)1549803304;
				switch (num3 == num)
				{
				}
				num = (short)156434433;
				if (num != 0)
				{
				}
				num = (short)1017708544;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Visible;
			}
			set
			{
				short num = (short)1651834880;
				short num2 = num;
				num = (short)1402536919;
				short num3 = num;
				num = (short)972358615;
				switch (num3 == num)
				{
				}
				num = (short)1882980353;
				if (num != 0)
				{
				}
				num = (short)437714944;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Visible = value;
			}
		}

		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x0600C43E RID: 50238 RVA: 0x00B80EC4 File Offset: 0x00B7F0C4
		// (set) Token: 0x0600C43F RID: 50239 RVA: 0x00B80F78 File Offset: 0x00B7F178
		public bool CnvPerFeaturesHazardZoneModePersonality_Editable
		{
			get
			{
				short num = (short)47579136;
				short num2 = num;
				num = (short)1821994077;
				short num3 = num;
				num = (short)1543203933;
				switch (num3 == num)
				{
				}
				num = (short)1702494208;
				if (num != 0)
				{
				}
				num = (short)1832255489;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.Editable;
			}
			set
			{
				short num = (short)2025717761;
				if (num != 0)
				{
				}
				num = (short)1537212416;
				short num2 = num;
				num = (short)1755059299;
				short num3 = num;
				num = (short)705107043;
				switch (num3 == num)
				{
				}
				num = (short)1299709952;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.Editable = value;
			}
		}

		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x0600C440 RID: 50240 RVA: 0x00B81030 File Offset: 0x00B7F230
		internal string CnvPerFeaturesHazardZoneModePersonality_UILabel
		{
			get
			{
				short num = (short)953348642;
				short num2 = num;
				num = (short)278524450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284243456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869086720;
				if (num != 0)
				{
				}
				num = (short)1725431809;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.UIName;
			}
		}

		// Token: 0x1700623F RID: 25151
		// (get) Token: 0x0600C441 RID: 50241 RVA: 0x00B810E8 File Offset: 0x00B7F2E8
		// (set) Token: 0x0600C442 RID: 50242 RVA: 0x00B8119C File Offset: 0x00B7F39C
		internal bool CnvPerFeaturesHazardZoneModePersonality_HiddenStatic
		{
			get
			{
				short num = (short)235619414;
				short num2 = num;
				num = (short)562644054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008809472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361889793;
				if (num != 0)
				{
				}
				num = (short)973144064;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.HiddenStatic;
			}
			set
			{
				short num = (short)1117302527;
				short num2 = num;
				num = (short)1966845695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)502988800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815805952;
				if (num != 0)
				{
				}
				num = (short)1938751489;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.HiddenStatic = value;
			}
		}

		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x0600C443 RID: 50243 RVA: 0x00B81254 File Offset: 0x00B7F454
		// (set) Token: 0x0600C444 RID: 50244 RVA: 0x00B81308 File Offset: 0x00B7F508
		internal bool CnvPerFeaturesHazardZoneModePersonality_HiddenDynamic
		{
			get
			{
				short num = (short)1871561726;
				short num2 = num;
				num = (short)1005962238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974468608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600978944;
				if (num != 0)
				{
				}
				num = (short)1430781953;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality.HiddenDynamic;
			}
			set
			{
				short num = (short)728983751;
				short num2 = num;
				num = (short)784099527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287389184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1475149824;
				if (num != 0)
				{
				}
				num = (short)157351937;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesHazardZoneModePersonality.HiddenDynamic = value;
			}
		}

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x0600C445 RID: 50245 RVA: 0x00B813C0 File Offset: 0x00B7F5C0
		public bool CnvPerFeaturesHazardZoneModePersonality_HasDiffs
		{
			get
			{
				short num = (short)658058898;
				short num2 = num;
				num = (short)784608914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013331456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)669646849;
				if (num != 0)
				{
				}
				num = (short)49348608;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesHazardZoneModePersonality._HasDiffs;
			}
		}

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x0600C446 RID: 50246 RVA: 0x00B81474 File Offset: 0x00B7F674
		// (set) Token: 0x0600C447 RID: 50247 RVA: 0x00B81528 File Offset: 0x00B7F728
		public int CnvPerFeaturesRSSIDisplayTimer_42786Value
		{
			get
			{
				short num = (short)566050324;
				short num2 = num;
				num = (short)1469922836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1959067648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655097857;
				if (num != 0)
				{
				}
				num = (short)1021378560;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Value;
			}
			set
			{
				short num = (short)1837214868;
				short num2 = num;
				num = (short)438938772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246494720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630718465;
				if (num != 0)
				{
				}
				num = (short)1236402176;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Value = value;
			}
		}

		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x0600C448 RID: 50248 RVA: 0x00B815DC File Offset: 0x00B7F7DC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerFeaturesRSSIDisplayTimer_42786
		{
			get
			{
				short num = (short)662503425;
				if (num != 0)
				{
				}
				num = (short)1745682432;
				short num2 = num;
				num = (short)277573722;
				short num3 = num;
				num = (short)126120026;
				switch (num3 == num)
				{
				}
				num = (short)297271296;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786;
			}
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x0600C449 RID: 50249 RVA: 0x00B81688 File Offset: 0x00B7F888
		// (set) Token: 0x0600C44A RID: 50250 RVA: 0x00B8173C File Offset: 0x00B7F93C
		public string CnvPerFeaturesRSSIDisplayTimer_42786_UIValue
		{
			get
			{
				short num = (short)1383791153;
				short num2 = num;
				num = (short)408353329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1609039872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)986185728;
				if (num != 0)
				{
				}
				num = (short)1907490817;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.UIValue;
			}
			set
			{
				short num = (short)1905655809;
				if (num != 0)
				{
				}
				num = (short)826408960;
				short num2 = num;
				num = (short)625095383;
				short num3 = num;
				num = (short)568865495;
				switch (num3 == num)
				{
				}
				num = (short)623706112;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.UIValue = value;
			}
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x0600C44B RID: 50251 RVA: 0x00B817F0 File Offset: 0x00B7F9F0
		// (set) Token: 0x0600C44C RID: 50252 RVA: 0x00B818A8 File Offset: 0x00B7FAA8
		internal int CnvPerFeaturesRSSIDisplayTimer_42786Min
		{
			get
			{
				short num = (short)1555633696;
				short num2 = num;
				num = (short)1457002016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496317952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586547201;
				if (num != 0)
				{
				}
				num = (short)534839296;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Min;
			}
			set
			{
				short num = (short)2109908081;
				short num2 = num;
				num = (short)1983685745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1322647552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649003009;
				if (num != 0)
				{
				}
				num = (short)988872704;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Min = value;
			}
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x0600C44D RID: 50253 RVA: 0x00B81960 File Offset: 0x00B7FB60
		// (set) Token: 0x0600C44E RID: 50254 RVA: 0x00B81A18 File Offset: 0x00B7FC18
		internal int CnvPerFeaturesRSSIDisplayTimer_42786Max
		{
			get
			{
				short num = (short)541458433;
				if (num != 0)
				{
				}
				num = (short)514326528;
				short num2 = num;
				num = (short)241920672;
				short num3 = num;
				num = (short)1921149600;
				switch (num3 == num)
				{
				}
				num = (short)1155465216;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Max;
			}
			set
			{
				short num = (short)1212300404;
				short num2 = num;
				num = (short)1262763124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1501167616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)226099201;
				if (num != 0)
				{
				}
				num = (short)106627072;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Max = value;
			}
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x0600C44F RID: 50255 RVA: 0x00B81AD0 File Offset: 0x00B7FCD0
		// (set) Token: 0x0600C450 RID: 50256 RVA: 0x00B81B84 File Offset: 0x00B7FD84
		internal int CnvPerFeaturesRSSIDisplayTimer_42786Step
		{
			get
			{
				short num = (short)1095322133;
				short num2 = num;
				num = (short)1645758997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835532288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1221328897;
				if (num != 0)
				{
				}
				num = (short)1242300416;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.StepSize;
			}
			set
			{
				short num = (short)94053061;
				short num2 = num;
				num = (short)1018110661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232076800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)1718812672;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.StepSize = value;
			}
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x0600C451 RID: 50257 RVA: 0x00B81C3C File Offset: 0x00B7FE3C
		// (set) Token: 0x0600C452 RID: 50258 RVA: 0x00B81CF0 File Offset: 0x00B7FEF0
		public bool CnvPerFeaturesRSSIDisplayTimer_42786_Applicable
		{
			get
			{
				short num = (short)1320269325;
				short num2 = num;
				num = (short)756856333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)53805056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				num = (short)620822528;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Applicable;
			}
			set
			{
				short num = (short)854130689;
				if (num != 0)
				{
				}
				num = (short)1780678656;
				short num2 = num;
				num = (short)1130395215;
				short num3 = num;
				num = (short)716338767;
				switch (num3 == num)
				{
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Applicable = value;
			}
		}

		// Token: 0x17006249 RID: 25161
		// (get) Token: 0x0600C453 RID: 50259 RVA: 0x00B81DA4 File Offset: 0x00B7FFA4
		// (set) Token: 0x0600C454 RID: 50260 RVA: 0x00B81E54 File Offset: 0x00B80054
		public bool CnvPerFeaturesRSSIDisplayTimer_42786_Valid
		{
			get
			{
				short num = (short)1316318598;
				short num2 = num;
				num = (short)180841862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)352190464;
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
				num = (short)2068381696;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Valid;
			}
			set
			{
				short num = (short)1284598016;
				short num2 = num;
				num = (short)324626688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719664640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530527745;
				if (num != 0)
				{
				}
				num = (short)1541799936;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Valid = value;
			}
		}

		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x0600C455 RID: 50261 RVA: 0x00B81F0C File Offset: 0x00B8010C
		// (set) Token: 0x0600C456 RID: 50262 RVA: 0x00B81FC0 File Offset: 0x00B801C0
		public bool CnvPerFeaturesRSSIDisplayTimer_42786_Visible
		{
			get
			{
				short num = (short)1986951499;
				short num2 = num;
				num = (short)521632075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958346752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901461505;
				if (num != 0)
				{
				}
				num = (short)423100416;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Visible;
			}
			set
			{
				short num = (short)1050411009;
				if (num != 0)
				{
				}
				num = (short)1696792576;
				short num2 = num;
				num = (short)801492118;
				short num3 = num;
				num = (short)1955318934;
				switch (num3 == num)
				{
				}
				num = (short)845414400;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Visible = value;
			}
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x0600C457 RID: 50263 RVA: 0x00B82078 File Offset: 0x00B80278
		// (set) Token: 0x0600C458 RID: 50264 RVA: 0x00B82130 File Offset: 0x00B80330
		public bool CnvPerFeaturesRSSIDisplayTimer_42786_Editable
		{
			get
			{
				short num = (short)1568473833;
				short num2 = num;
				num = (short)1749746409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805713408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941096960;
				if (num != 0)
				{
				}
				num = (short)1359740929;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.Editable;
			}
			set
			{
				short num = (short)455103353;
				short num2 = num;
				num = (short)1389843321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667039232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386727936;
				if (num != 0)
				{
				}
				num = (short)1970470913;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.Editable = value;
			}
		}

		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x00B821E8 File Offset: 0x00B803E8
		internal string CnvPerFeaturesRSSIDisplayTimer_42786_UILabel
		{
			get
			{
				short num = (short)186020028;
				short num2 = num;
				num = (short)965439676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398145024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18284545;
				if (num != 0)
				{
				}
				num = (short)1916862464;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.UIName;
			}
		}

		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x0600C45A RID: 50266 RVA: 0x00B8229C File Offset: 0x00B8049C
		// (set) Token: 0x0600C45B RID: 50267 RVA: 0x00B82354 File Offset: 0x00B80554
		internal bool CnvPerFeaturesRSSIDisplayTimer_42786_HiddenStatic
		{
			get
			{
				short num = (short)1134034945;
				if (num != 0)
				{
				}
				num = (short)1183383552;
				short num2 = num;
				num = (short)60490700;
				short num3 = num;
				num = (short)25625548;
				switch (num3 == num)
				{
				}
				num = (short)477626368;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.HiddenStatic;
			}
			set
			{
				short num = (short)1521966826;
				short num2 = num;
				num = (short)1588420330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735182848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94633985;
				if (num != 0)
				{
				}
				num = (short)1171128320;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.HiddenStatic = value;
			}
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x0600C45C RID: 50268 RVA: 0x00B82408 File Offset: 0x00B80608
		// (set) Token: 0x0600C45D RID: 50269 RVA: 0x00B824BC File Offset: 0x00B806BC
		internal bool CnvPerFeaturesRSSIDisplayTimer_42786_HiddenDynamic
		{
			get
			{
				short num = (short)2006536952;
				short num2 = num;
				num = (short)2079216376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035010048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)927203329;
				if (num != 0)
				{
				}
				num = (short)262864896;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786.HiddenDynamic;
			}
			set
			{
				short num = (short)1449656321;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num2 = num;
				num = (short)334250215;
				short num3 = num;
				num = (short)360923367;
				switch (num3 == num)
				{
				}
				num = (short)1033109504;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesRSSIDisplayTimer_42786.HiddenDynamic = value;
			}
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x0600C45E RID: 50270 RVA: 0x00B82574 File Offset: 0x00B80774
		public bool CnvPerFeaturesRSSIDisplayTimer_42786_HasDiffs
		{
			get
			{
				short num = (short)1242782036;
				short num2 = num;
				num = (short)660429140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741998592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788201472;
				if (num != 0)
				{
				}
				num = (short)406913025;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesRSSIDisplayTimer_42786._HasDiffs;
			}
		}

		// Token: 0x17006250 RID: 25168
		// (get) Token: 0x0600C45F RID: 50271 RVA: 0x00B82628 File Offset: 0x00B80828
		// (set) Token: 0x0600C460 RID: 50272 RVA: 0x00B826DC File Offset: 0x00B808DC
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059Value
		{
			get
			{
				short num = (short)311244964;
				short num2 = num;
				num = (short)750467236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837301760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1138622465;
				if (num != 0)
				{
				}
				num = (short)45613056;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Value;
			}
			set
			{
				short num = (short)1974767016;
				short num2 = num;
				num = (short)1118473640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483786752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052587521;
				if (num != 0)
				{
				}
				num = (short)24313856;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Value = value;
			}
		}

		// Token: 0x17006251 RID: 25169
		// (get) Token: 0x0600C461 RID: 50273 RVA: 0x00B82790 File Offset: 0x00B80990
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesOTARadioAliasUpdateEnable_A43059
		{
			get
			{
				short num = (short)1240432732;
				short num2 = num;
				num = (short)1643872348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945618944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847904768;
				if (num != 0)
				{
				}
				num = (short)1516830721;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059;
			}
		}

		// Token: 0x17006252 RID: 25170
		// (get) Token: 0x0600C462 RID: 50274 RVA: 0x00B82840 File Offset: 0x00B80A40
		// (set) Token: 0x0600C463 RID: 50275 RVA: 0x00B828F4 File Offset: 0x00B80AF4
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_UIValue
		{
			get
			{
				short num = (short)1091595066;
				short num2 = num;
				num = (short)1993567034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287323648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915355136;
				if (num != 0)
				{
				}
				num = (short)576323585;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Value;
			}
			set
			{
				short num = (short)1346070752;
				short num2 = num;
				num = (short)660039904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581121536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141164545;
				if (num != 0)
				{
				}
				num = (short)161087488;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Value = value;
			}
		}

		// Token: 0x17006253 RID: 25171
		// (get) Token: 0x0600C464 RID: 50276 RVA: 0x00B829A8 File Offset: 0x00B80BA8
		// (set) Token: 0x0600C465 RID: 50277 RVA: 0x00B82A5C File Offset: 0x00B80C5C
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_Applicable
		{
			get
			{
				short num = (short)1168323926;
				short num2 = num;
				num = (short)340342102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329383936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)233504769;
				if (num != 0)
				{
				}
				num = (short)825229312;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Applicable;
			}
			set
			{
				short num = (short)397774255;
				short num2 = num;
				num = (short)2096860591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525533184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337196545;
				if (num != 0)
				{
				}
				num = (short)1792409600;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Applicable = value;
			}
		}

		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x0600C466 RID: 50278 RVA: 0x00B82B14 File Offset: 0x00B80D14
		// (set) Token: 0x0600C467 RID: 50279 RVA: 0x00B82BC8 File Offset: 0x00B80DC8
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_Valid
		{
			get
			{
				short num = (short)1303438323;
				short num2 = num;
				num = (short)797893619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244987392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262223361;
				if (num != 0)
				{
				}
				num = (short)1919025152;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Valid;
			}
			set
			{
				short num = (short)1219011369;
				short num2 = num;
				num = (short)1174446889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360316928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1836384256;
				if (num != 0)
				{
				}
				num = (short)254738433;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Valid = value;
			}
		}

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x0600C468 RID: 50280 RVA: 0x00B82C7C File Offset: 0x00B80E7C
		// (set) Token: 0x0600C469 RID: 50281 RVA: 0x00B82D30 File Offset: 0x00B80F30
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_Visible
		{
			get
			{
				short num = (short)1450256710;
				short num2 = num;
				num = (short)1769089350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694564352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341521921;
				if (num != 0)
				{
				}
				num = (short)322371584;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Visible;
			}
			set
			{
				short num = (short)1590476754;
				short num2 = num;
				num = (short)2044313554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413677056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)639631361;
				if (num != 0)
				{
				}
				num = (short)264634368;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Visible = value;
			}
		}

		// Token: 0x17006256 RID: 25174
		// (get) Token: 0x0600C46A RID: 50282 RVA: 0x00B82DE8 File Offset: 0x00B80FE8
		// (set) Token: 0x0600C46B RID: 50283 RVA: 0x00B82EA0 File Offset: 0x00B810A0
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_Editable
		{
			get
			{
				short num = (short)1549271928;
				short num2 = num;
				num = (short)698024824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029636096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207435265;
				if (num != 0)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Editable;
			}
			set
			{
				short num = (short)1397840352;
				short num2 = num;
				num = (short)947935712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722927616;
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
				num = (short)1223819264;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.Editable = value;
			}
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x0600C46C RID: 50284 RVA: 0x00B82F54 File Offset: 0x00B81154
		internal string CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_UILabel
		{
			get
			{
				short num = (short)1709951736;
				short num2 = num;
				num = (short)1333316344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324351488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)255524864;
				if (num != 0)
				{
				}
				num = (short)611188737;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.UIName;
			}
		}

		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x0600C46D RID: 50285 RVA: 0x00B8300C File Offset: 0x00B8120C
		// (set) Token: 0x0600C46E RID: 50286 RVA: 0x00B830C0 File Offset: 0x00B812C0
		internal bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_HiddenStatic
		{
			get
			{
				short num = (short)1256713074;
				short num2 = num;
				num = (short)1834019698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410124288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610271233;
				if (num != 0)
				{
				}
				num = (short)1420754944;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.HiddenStatic;
			}
			set
			{
				short num = (short)831389697;
				if (num != 0)
				{
				}
				num = (short)1482424320;
				short num2 = num;
				num = (short)2063710095;
				short num3 = num;
				num = (short)640399247;
				switch (num3 == num)
				{
				}
				num = (short)333250560;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.HiddenStatic = value;
			}
		}

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x0600C46F RID: 50287 RVA: 0x00B83178 File Offset: 0x00B81378
		// (set) Token: 0x0600C470 RID: 50288 RVA: 0x00B8322C File Offset: 0x00B8142C
		internal bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_HiddenDynamic
		{
			get
			{
				short num = (short)820201190;
				short num2 = num;
				num = (short)1360742118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1827209216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051197440;
				if (num != 0)
				{
				}
				num = (short)18743297;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.HiddenDynamic;
			}
			set
			{
				short num = (short)2016957154;
				short num2 = num;
				num = (short)839406306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584201728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375469569;
				if (num != 0)
				{
				}
				num = (short)838991872;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059.HiddenDynamic = value;
			}
		}

		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x0600C471 RID: 50289 RVA: 0x00B832E0 File Offset: 0x00B814E0
		public bool CnvPerFeaturesOTARadioAliasUpdateEnable_A43059_HasDiffs
		{
			get
			{
				short num = (short)1804415201;
				short num2 = num;
				num = (short)262418657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1447886848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381171201;
				if (num != 0)
				{
				}
				num = (short)1954742272;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesOTARadioAliasUpdateEnable_A43059._HasDiffs;
			}
		}

		// Token: 0x1700625B RID: 25179
		// (get) Token: 0x0600C472 RID: 50290 RVA: 0x00B83398 File Offset: 0x00B81598
		// (set) Token: 0x0600C473 RID: 50291 RVA: 0x00B8344C File Offset: 0x00B8164C
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913Value
		{
			get
			{
				short num = (short)128690556;
				short num2 = num;
				num = (short)1461561724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305004544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210187776;
				if (num != 0)
				{
				}
				num = (short)99876865;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Value;
			}
			set
			{
				short num = (short)2076207386;
				short num2 = num;
				num = (short)653682970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)202506240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032519681;
				if (num != 0)
				{
				}
				num = (short)1601437696;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Value = value;
			}
		}

		// Token: 0x1700625C RID: 25180
		// (get) Token: 0x0600C474 RID: 50292 RVA: 0x00B83504 File Offset: 0x00B81704
		public global::AcpBusinessLayer.AcpField<bool> CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913
		{
			get
			{
				short num = (short)228101511;
				short num2 = num;
				num = (short)2082114951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1123680256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)192741376;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;
			}
		}

		// Token: 0x1700625D RID: 25181
		// (get) Token: 0x0600C475 RID: 50293 RVA: 0x00B835B4 File Offset: 0x00B817B4
		// (set) Token: 0x0600C476 RID: 50294 RVA: 0x00B83668 File Offset: 0x00B81868
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_UIValue
		{
			get
			{
				short num = (short)1730739927;
				short num2 = num;
				num = (short)1620246231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319960576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)675086337;
				if (num != 0)
				{
				}
				num = (short)782106624;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Value;
			}
			set
			{
				short num = (short)1725803362;
				short num2 = num;
				num = (short)846310242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389428736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)952958976;
				if (num != 0)
				{
				}
				num = (short)1200488449;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Value = value;
			}
		}

		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x0600C477 RID: 50295 RVA: 0x00B83724 File Offset: 0x00B81924
		// (set) Token: 0x0600C478 RID: 50296 RVA: 0x00B837D8 File Offset: 0x00B819D8
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_Applicable
		{
			get
			{
				short num = (short)86997207;
				short num2 = num;
				num = (short)533231831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257425408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1100480513;
				if (num != 0)
				{
				}
				num = (short)614596608;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Applicable;
			}
			set
			{
				short num = (short)627275712;
				short num2 = num;
				num = (short)679704512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785593856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276627457;
				if (num != 0)
				{
				}
				num = (short)368312320;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Applicable = value;
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x0600C479 RID: 50297 RVA: 0x00B8388C File Offset: 0x00B81A8C
		// (set) Token: 0x0600C47A RID: 50298 RVA: 0x00B83940 File Offset: 0x00B81B40
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_Valid
		{
			get
			{
				short num = (short)1653342209;
				if (num != 0)
				{
				}
				num = (short)331939840;
				short num2 = num;
				num = (short)2025761813;
				short num3 = num;
				num = (short)569420821;
				switch (num3 == num)
				{
				}
				num = (short)60882944;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Valid;
			}
			set
			{
				short num = (short)1816817797;
				short num2 = num;
				num = (short)1855877253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736624640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2048065536;
				if (num != 0)
				{
				}
				num = (short)1317666817;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Valid = value;
			}
		}

		// Token: 0x17006260 RID: 25184
		// (get) Token: 0x0600C47B RID: 50299 RVA: 0x00B839F4 File Offset: 0x00B81BF4
		// (set) Token: 0x0600C47C RID: 50300 RVA: 0x00B83AAC File Offset: 0x00B81CAC
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_Visible
		{
			get
			{
				short num = (short)869595146;
				short num2 = num;
				num = (short)1791883274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860304896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754071041;
				if (num != 0)
				{
				}
				num = (short)17760256;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Visible;
			}
			set
			{
				short num = (short)404433606;
				short num2 = num;
				num = (short)2040277702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068709376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929693697;
				if (num != 0)
				{
				}
				num = (short)1790771200;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Visible = value;
			}
		}

		// Token: 0x17006261 RID: 25185
		// (get) Token: 0x0600C47D RID: 50301 RVA: 0x00B83B64 File Offset: 0x00B81D64
		// (set) Token: 0x0600C47E RID: 50302 RVA: 0x00B83C18 File Offset: 0x00B81E18
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_Editable
		{
			get
			{
				short num = (short)1146814465;
				if (num != 0)
				{
				}
				num = (short)2146107392;
				short num2 = num;
				num = (short)883023657;
				short num3 = num;
				num = (short)1438048041;
				switch (num3 == num)
				{
				}
				num = (short)1300430848;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Editable;
			}
			set
			{
				short num = (short)686424065;
				if (num != 0)
				{
				}
				num = (short)951451648;
				short num2 = num;
				num = (short)68376987;
				short num3 = num;
				num = (short)2099075483;
				switch (num3 == num)
				{
				}
				num = (short)989921280;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.Editable = value;
			}
		}

		// Token: 0x17006262 RID: 25186
		// (get) Token: 0x0600C47F RID: 50303 RVA: 0x00B83CCC File Offset: 0x00B81ECC
		internal string CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_UILabel
		{
			get
			{
				short num = (short)617676801;
				if (num != 0)
				{
				}
				num = (short)1709322099;
				short num2 = num;
				num = (short)1111109491;
				switch (num2 == num)
				{
				}
				num = (short)791478272;
				if (num != 0)
				{
				}
				num = (short)1426784256;
				short num3 = num;
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.UIName;
			}
		}

		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x0600C480 RID: 50304 RVA: 0x00B83D84 File Offset: 0x00B81F84
		// (set) Token: 0x0600C481 RID: 50305 RVA: 0x00B83E3C File Offset: 0x00B8203C
		internal bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_HiddenStatic
		{
			get
			{
				short num = (short)1917124609;
				if (num != 0)
				{
				}
				num = (short)447717597;
				short num2 = num;
				num = (short)706912477;
				switch (num2 == num)
				{
				}
				num = (short)2089287680;
				if (num != 0)
				{
				}
				num = (short)1553072128;
				short num3 = num;
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.HiddenStatic;
			}
			set
			{
				short num = (short)111213107;
				short num2 = num;
				num = (short)1161099827;
				switch (num2 == num)
				{
				}
				num = (short)907476992;
				if (num != 0)
				{
				}
				num = (short)1650786305;
				if (num != 0)
				{
				}
				num = (short)1871773696;
				short num3 = num;
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.HiddenStatic = value;
			}
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x0600C482 RID: 50306 RVA: 0x00B83EF4 File Offset: 0x00B820F4
		// (set) Token: 0x0600C483 RID: 50307 RVA: 0x00B83FA8 File Offset: 0x00B821A8
		internal bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_HiddenDynamic
		{
			get
			{
				short num = (short)368771073;
				if (num != 0)
				{
				}
				num = (short)760776823;
				short num2 = num;
				num = (short)1864927351;
				switch (num2 == num)
				{
				}
				num = (short)1567031296;
				if (num != 0)
				{
				}
				num = (short)1260584960;
				short num3 = num;
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.HiddenDynamic;
			}
			set
			{
				short num = (short)1387734037;
				short num2 = num;
				num = (short)597894165;
				switch (num2 == num)
				{
				}
				num = (short)72220672;
				if (num != 0)
				{
				}
				num = (short)1660223489;
				if (num != 0)
				{
				}
				num = (short)1568800768;
				short num3 = num;
				this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913.HiddenDynamic = value;
			}
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x0600C484 RID: 50308 RVA: 0x00B8405C File Offset: 0x00B8225C
		public bool CnvPerFeaturesPoliteDVRSInboundPTTRequest_44913_HasDiffs
		{
			get
			{
				short num = (short)12648293;
				short num2 = num;
				num = (short)36241253;
				switch (num2 == num)
				{
				}
				num = (short)521338881;
				if (num != 0)
				{
				}
				num = (short)1758461952;
				if (num != 0)
				{
				}
				num = (short)463339520;
				short num3 = num;
				return this.cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913._HasDiffs;
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x0600C485 RID: 50309 RVA: 0x00B84110 File Offset: 0x00B82310
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1260114836;
				short num2 = num;
				num = (short)2110903188;
				switch (num2 == num)
				{
				}
				num = (short)121438209;
				if (num != 0)
				{
				}
				num = (short)1070268416;
				if (num != 0)
				{
				}
				num = (short)1738014720;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x0600C486 RID: 50310 RVA: 0x00B841D0 File Offset: 0x00B823D0
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide RefConventionalWide
		{
			get
			{
				short num = (short)536150017;
				if (num != 0)
				{
				}
				num = (short)827331774;
				short num2 = num;
				num = (short)1202328766;
				switch (num2 == num)
				{
				}
				num = (short)1823539200;
				if (num != 0)
				{
				}
				num = (short)979697664;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide;
			}
		}

		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x0600C487 RID: 50311 RVA: 0x00B84290 File Offset: 0x00B82490
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1587189014;
				short num2 = num;
				num = (short)1472632086;
				switch (num2 == num)
				{
				}
				num = (short)1737621505;
				if (num != 0)
				{
				}
				num = (short)157810688;
				if (num != 0)
				{
				}
				num = (short)657981440;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x0600C488 RID: 50312 RVA: 0x00B84350 File Offset: 0x00B82550
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1292030490;
				short num2 = num;
				num = (short)1919078938;
				switch (num2 == num)
				{
				}
				num = (short)1341194240;
				if (num != 0)
				{
				}
				num = (short)1307115521;
				if (num != 0)
				{
				}
				num = (short)188350464;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x0600C489 RID: 50313 RVA: 0x00B84410 File Offset: 0x00B82610
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1260584961;
				if (num != 0)
				{
				}
				num = (short)1897059110;
				short num2 = num;
				num = (short)1323881254;
				switch (num2 == num)
				{
				}
				num = (short)796262400;
				if (num != 0)
				{
				}
				num = (short)982515712;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x00B844D0 File Offset: 0x00B826D0
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
					num2 = (short)1416495105;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)491406399;
					short num3 = num2;
					num2 = (short)858276927;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num2 = (short)1428422656;
						if (num2 != 0)
						{
						}
						num2 = (short)1709178882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1205469184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_83;
				case 4:
				{
					num2 = (short)1246560256;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)1529479171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
				IL_83:
				num2 = (short)893190145;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1897725956;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04006472 RID: 25714
		private global::AcpBusinessLayer.AcpField<bool> cnvPerLabtoolAutomaticScan_A7527;

		// Token: 0x04006473 RID: 25715
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesFiregroundRegistration_A33242;

		// Token: 0x04006474 RID: 25716
		private global::AcpBusinessLayer.AcpField<bool> cnvPerLabtoolHotKeypad_A8208;

		// Token: 0x04006475 RID: 25717
		private global::AcpBusinessLayer.AcpField<bool> cnvPerLabtoolOTACROTACSMessaging_A8663;

		// Token: 0x04006476 RID: 25718
		private global::AcpBusinessLayer.AcpField<bool> cnvPerLabtoolQuickKeyOverride_A8808;

		// Token: 0x04006477 RID: 25719
		private global::AcpBusinessLayer.AcpRecRefField cnvPerLabtoolScanListSelection_A9054;

		// Token: 0x04006478 RID: 25720
		private global::AcpBusinessLayer.AcpListField cnvPerLabtoolSmartPTTType_A9164;

		// Token: 0x04006479 RID: 25721
		private global::AcpBusinessLayer.AcpField<bool> cnvPerTPSTPSUIEnable_A9400;

		// Token: 0x0400647A RID: 25722
		private global::AcpBusinessLayer.AcpListField cnvPerFeaturesTxVoiceType_A9573;

		// Token: 0x0400647B RID: 25723
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesTacticalRekeyEnable_A19309;

		// Token: 0x0400647C RID: 25724
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesMixedVoteScanEnable_A38723;

		// Token: 0x0400647D RID: 25725
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesMixedVoteScanTxSteering_A38878;

		// Token: 0x0400647E RID: 25726
		private global::AcpBusinessLayer.AcpListField conPerFeatureIncidentSignalingType_A41507;

		// Token: 0x0400647F RID: 25727
		private global::AcpBusinessLayer.AcpField<bool> cnvPerEndTxOnVoiceAbsence_42460;

		// Token: 0x04006480 RID: 25728
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeatureDTMFMicEn_A42481;

		// Token: 0x04006481 RID: 25729
		private global::AcpBusinessLayer.AcpListField cnvPerFeatureRFModem_42485;

		// Token: 0x04006482 RID: 25730
		private global::AcpBusinessLayer.AcpListField cnvPerFeaturesOTARadioAliasType_42784;

		// Token: 0x04006483 RID: 25731
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesConvetionalRSSIDisplay_42785;

		// Token: 0x04006484 RID: 25732
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesHazardZoneModePersonality;

		// Token: 0x04006485 RID: 25733
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerFeaturesRSSIDisplayTimer_42786;

		// Token: 0x04006486 RID: 25734
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesOTARadioAliasUpdateEnable_A43059;

		// Token: 0x04006487 RID: 25735
		private global::AcpBusinessLayer.AcpField<bool> cnvPerFeaturesPoliteDVRSInboundPTTRequest_44913;
	}
}
