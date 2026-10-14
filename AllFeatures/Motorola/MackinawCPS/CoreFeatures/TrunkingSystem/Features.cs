using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability;
using Motorola.MackinawCPS.CoreFeatures.PhoneWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000093 RID: 147
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000D08 RID: 3336 RVA: 0x000D688C File Offset: 0x000D4A8C
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000D68A8 File Offset: 0x000D4AA8
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000D68C0 File Offset: 0x000D4AC0
		public override void Init()
		{
			int a_ = 10;
			short num = (short)538640385;
			if (num != 0)
			{
			}
			num = (short)1450246144;
			short num2 = num;
			num = (short)2029676449;
			short num3 = num;
			num = (short)171861921;
			switch (num3 == num)
			{
			}
			num = (short)1770455040;
			if (num != 0)
			{
			}
			this.trkSysFeaturesICUAAutoResetTimesec_A7515 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤껦ꫨ뻪곬껮蓰蟲髴ꗶ鳸裺飼课唀樂栄戆稈渊渌倎倐␒—☖Ⱈ", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTICUAAUTORESETTIMESEC, 0, 255, null, null, 0, 1);
			this.trkSysFeaturesICUAAutoResetTimesec_A7515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysFeaturesICUAAutoResetTimesec_A7515.DataTransferOrder = 35;
			this.trkSysFeaturesICUAAutoResetTimesec_A7515.ShowHexValue = false;
			this.trkSysFeaturesDTMFTimingTable_A7900 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꏦ뷨ꛪ꯬믮飰黲鳴駶黸꿺鳼鷾洀昂娄䘆㸈㈊㴌㼎", a_), global::CommonResources.AcgResources.ID_DTMFTIMINGSELECT, null, null, false, false);
			this.trkSysFeaturesDTMFTimingTable_A7900.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesDTMFTimingTable_A7900.DataTransferOrder = 88;
			this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꋦ蓨軪鿬裮铰鷲雴軶룸韺鳼跾氀儂約丆月漊搌氎瀐朒稔攖䘘娚⨜☞ሠᄢ", a_), global::CommonResources.AcgResources.ID_RADIOERGOEMERGENCYALARMRXINDICATOR);
			this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.DataTransferOrder = 37;
			this.trkSysFeaturesDynamicRegroupingEnable_A7969 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꏦ部藪賬苮飰郲ꟴ鋶黸觺鋼諾焀樂欄怆䰈攊氌洎紐瘒䨔嘖⸘√⬜☞", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGDYNAMICREGROUPINGENABLE);
			this.trkSysFeaturesDynamicRegroupingEnable_A7969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesDynamicRegroupingEnable_A7969.DataTransferOrder = 8;
			this.trkSysFeaturesICUAReset_A8249 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤껦ꫨ뻪곬뷮铰胲郴菶꛸뫺염췾㔀㨂", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTICUARESET, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesICUAReset_A8249LovStrs);
			this.trkSysFeaturesICUAReset_A8249.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysFeaturesICUAReset_A8249.DataTransferOrder = 10;
			this.trkSysLabtoolEnable_A8669 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ鯖룘맚꧜냞軠迢ꃤ触裨觪臬諮껰닲췴쇶쿸싺", a_), global::CommonResources.AcgResources.ID_POP25ENABLE);
			this.trkSysLabtoolEnable_A8669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysLabtoolEnable_A8669.DataTransferOrder = 103;
			this.trkSysFeaturesRadioInhibit_A8833 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤뗦裨迪蓬胮룰鷲鷴黶鯸鋺觼ꃾ䀀㬂㴄㐆㨈", a_), global::CommonResources.AcgResources.ID_RADIOINHIBIT);
			this.trkSysFeaturesRadioInhibit_A8833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesRadioInhibit_A8833.DataTransferOrder = 100;
			this.trkSysFeaturesSecureLED_A9071 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤듦賨裪飬鷮铰뿲냴돶꛸뫺쓼쿾㘀㈂", a_), global::CommonResources.AcgResources.ID_RADIOERGOSECURELED);
			this.trkSysFeaturesSecureLED_A9071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesSecureLED_A9071.DataTransferOrder = 30;
			this.trkSysFeaturesBusyLED_44911 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꗦ鳨飪铬ꏮ듰럲ꫴ쏶췸싺쳼컾", a_), global::CommonResources.AcgResources.ID_BUSYLED);
			this.trkSysFeaturesBusyLED_44911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysFeaturesBusyLED_44911.DataTransferOrder = 31;
			this.trkSysFeaturesTextMessagingService_A9373 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤돦賨鏪駬ꋮ铰胲蛴零黸鋺鏼飾刀昂眄焆怈栊栌倎倐⨒☔‖⨘", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTextMessagingService_A9373LovStrs);
			this.trkSysFeaturesTextMessagingService_A9373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesTextMessagingService_A9373.DataTransferOrder = 102;
			this.trkSysFeaturesTxBaseTimeSec_A9512 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤돦釨ꧪ賬鳮铰ꟲ鳴髶鳸꣺飼鳾帀䈂㰄㈆㠈㤊", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACETXBASETIMESEC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTxBaseTimeSec_A9512LovStrs);
			this.trkSysFeaturesTxBaseTimeSec_A9512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysFeaturesTxBaseTimeSec_A9512.DataTransferOrder = 78;
			this.trkSysFeaturesTxPowerLevel_A9557 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysFeaturesTxPowerLevel_A9557LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysFeaturesTxPowerLevel_A9557LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤돦釨믪苬飮铰臲맴鋶迸黺釼ꃾ䀀㨂〄㈆㸈", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTxPowerLevel_A9557LovStrs);
			this.trkSysFeaturesTxPowerLevel_A9557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesTxPowerLevel_A9557.DataTransferOrder = 9;
			this.trkSysFeaturesZone_A9717 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤뷦蛨藪裬냮냰쫲싴웶컸", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkSysFeaturesZone_A9717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysFeaturesZone_A9717.DataTransferOrder = 52;
			this.trkSysFeaturesChannel_A7647 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꓦ臨諪菬臮铰鿲ꫴ뛶컸췺짼죾", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkSysFeaturesChannel_A7647.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesChannel_A7647.DataTransferOrder = 79;
			this.trkSysFeaturesHearClear_A36422 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤꿦賨諪鿬곮鷰雲铴藶꛸뫺컼짾㔀㄂㜄", a_), global::CommonResources.AcgResources.ID_HEARCLEAR, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesHearClear_A36422LovStrs);
			this.trkSysFeaturesHearClear_A36422.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesHearClear_A36422.DataTransferOrder = 120;
			this.trkSysFeaturesEnable_A7968 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꋦ蟨諪迬菮铰곲듴샶샸췺염", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACEENABLE);
			this.trkSysFeaturesEnable_A7968.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesEnable_A7968.DataTransferOrder = 25;
			this.siteSelectableAlertList_A42060 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飊꓌믎듐胒냔믖볘룚꧜뻞菠迢胤ꛦ藨軪鿬鯮뷰髲蛴菶꛸뫺짼췾㄀㔂㔄", a_), global::CommonResources.AcgResources.ID_SITESELECTABLEALERTSITESELECTABLEALERTLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.siteSelectableAlertList_A42060.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.siteSelectableAlertList_A42060.DataTransferOrder = 104;
			this.siteSelectableAlertAliasList_A42100 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飊꓌믎듐胒냔믖볘룚꧜뻞菠迢胤ꛦ藨軪鿬鯮냰鿲鳴零諸럺铼賾甀専䐄㌆㬈㨊㴌㼎", a_), global::CommonResources.AcgResources.ID_SITESELECTABLEALERTSITESELECTABLEALERTALIASTEXTLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.siteSelectableAlertAliasList_A42100.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.siteSelectableAlertAliasList_A42100.DataTransferOrder = -1;
			this.trkSysFeaturesGroupTMSEable_42804 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤ꃦ鯨蓪飬鿮ꗰ뻲꛴닶飸駺釼髾帀㜂㜄㼆㤈㼊", a_), global::CommonResources.AcgResources.ID_GROUPTEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesGroupTMSEable_42804LovStrs);
			this.trkSysFeaturesGroupTMSEable_42804.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesGroupTMSEable_42804.DataTransferOrder = 151;
			this.trkPerFeaturesOTARadioAliasType_42854 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔釖볘뫚꧜꫞鏠蛢雤꣦뷨ꫪ뿬軮闰髲髴뛶闸鋺鳼賾唀稂甄戆嘈㼊㼌㜎␐✒", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkPerFeaturesOTARadioAliasType_42854LovStrs);
			this.trkPerFeaturesOTARadioAliasType_42854.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerFeaturesOTARadioAliasType_42854.DataTransferOrder = 300;
			this.trkSysFeaturesPASelection_A42882 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤럦꣨룪裬菮铰郲致黶雸闺ꋼ뻾㔀㄂㴄㼆㬈", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.trkSysFeaturesPASelection_A42882.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesPASelection_A42882.DataTransferOrder = 150;
			this.trkSysFeatureLocationOnPTT_43026 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢ꧤ裦諨諪駬蛮黰鷲뫴駶꧸꿺ꧼꃾ㔀。㔄㔆㼈", a_), global::CommonResources.AcgResources.ID_LOCATIONONPTT);
			this.trkSysFeatureLocationOnPTT_43026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysFeatureLocationOnPTT_43026.DataTransferOrder = 265;
			this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ釖볘뫚꧜꫞鏠蛢雤꣦뷨ꫪ뿬軮闰髲髴뛶闸鋺鳼賾吀猂愄昆紈渊䠌愎瀐焒礔爖䘘娚⤜Ⱎᄠᘢሤ", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASUPDATEENABLE);
			this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.DataTransferOrder = 310;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跊꣌껎ꗐꛒ꟔닖꫘", a_);
			base.Id = 10154;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x000D6F80 File Offset: 0x000D5180
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)97714210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.trkSysFeaturesChannel_A7647 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫귭飯鏱髳飵鷷雹ꏻ뿽㟿㐁〃ㄅ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkSysFeaturesChannel_A7647.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesChannel_A7647.DataTransferOrder = 79;
					num = (short)1955332125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_678;
				case 2:
					num = (short)980549633;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭闯諱胳믵鷷觹迻鿽柿欁樃愅嬇漉縋砍礏焑焓䤕夗⌙⼛⤝ጟ", a_)))
					{
						num = (short)1464991765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BCB;
				case 3:
				{
					num = (short)1589248000;
					short num3 = num;
					this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꇭꓯ돱꛳韵鳷鏹鏻뿽泿欁攃甅崇稉栋漍搏眑儓砕礗砙瀛笝缟挡ဣᔥᠧἩᬫ", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASUPDATEENABLE);
					this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.DataTransferOrder = 310;
					num = (short)1574043694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_E42;
				case 5:
					goto IL_F7E;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꟭돯꟱뗳럵跷軹鏻곽旿焁愃爅將按愋欍挏眑眓䤕夗ⴙ⤛⼝ᔟ", a_)))
					{
						num = (short)1056309312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F32;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꫭ觯鳱闳鯵釷駹껻鯽柿瀁欃猅砇按戋植唏簑甓琕琗缙䌛弝ᜟᬡሣἥ", a_)))
					{
						num = (short)1379794999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				case 8:
					goto IL_32C;
				case 9:
					if (producerFields != null)
					{
						num = (short)1446576172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11AB;
				case 10:
					goto IL_BCB;
				case 11:
					this.trkSysFeaturesTxPowerLevel_A9557 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysFeaturesTxPowerLevel_A9557LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysFeaturesTxPowerLevel_A9557LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭裯ꋱ鯳臵鷷裹냻鯽盿朁栃夅䤇㌉㤋㬍✏", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVEL, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTxPowerLevel_A9557LovStrs);
					this.trkSysFeaturesTxPowerLevel_A9557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesTxPowerLevel_A9557.DataTransferOrder = 9;
					num = (short)359727140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_62A;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫곭藯臱跳뫵뷷뻹ꏻ쫽㓿㬁㔃㜅", a_)))
					{
						num = (short)2136932421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_525;
				case 14:
					this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꯭鷯韱蛳釵鷷铹鿻蟽䇿渁攃琅攇堉琋䜍縏瘑紓甕礗渙猛氝缟挡ጣἥᬧᠩ", a_), global::CommonResources.AcgResources.ID_RADIOERGOEMERGENCYALARMRXINDICATOR);
					this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.DataTransferOrder = 37;
					num = (short)1677066252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_ACA;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꇭꓯ돱꛳韵鳷鏹鏻뿽泿欁攃甅崇稉栋漍搏眑儓砕礗砙瀛笝缟挡ဣᔥᠧἩᬫ", a_)))
					{
						num = (short)1192820739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11AB;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕裗뿙껛飝藟菡郣鏥髧迩鿫ꇭꓯ돱꛳韵鳷鏹鏻뿽泿欁攃甅將猉簋欍伏☑☓⸕ⴗ⸙", a_)))
					{
						num = (short)787218502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_463;
				case 18:
					goto IL_8D5;
				case 19:
					this.trkSysFeaturesICUAReset_A8249 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꟭돯꟱뗳ꓵ鷷觹駻諽忿䌁㰃㐅㰇㌉", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTICUARESET, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesICUAReset_A8249LovStrs);
					this.trkSysFeaturesICUAReset_A8249.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysFeaturesICUAReset_A8249.DataTransferOrder = 10;
					num = (short)1058865180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.trkSysFeaturesDTMFTimingTable_A7900 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꫭꓯ뿱닳ꋵ釷韹闻都柿嘁攃搅搇漉匋伍✏⬑␓☕", a_), global::CommonResources.AcgResources.ID_DTMFTIMINGSELECT, null, null, false, false);
					this.trkSysFeaturesDTMFTimingTable_A7900.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesDTMFTimingTable_A7900.DataTransferOrder = 88;
					num = (short)1211105327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.trkSysFeaturesTextMessagingService_A9373 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭闯諱胳믵鷷觹迻鿽柿欁樃愅嬇漉縋砍礏焑焓䤕夗⌙⼛⤝ጟ", a_), global::CommonResources.AcgResources.ID_TEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTextMessagingService_A9373LovStrs);
					this.trkSysFeaturesTextMessagingService_A9373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesTextMessagingService_A9373.DataTransferOrder = 102;
					num = (short)1048117258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.trkSysFeaturesTxBaseTimeSec_A9512 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭裯냱闳藵鷷껹闻鏽旿儁愃攅圇䬉㔋㬍ℏ‑", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACETXBASETIMESEC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesTxBaseTimeSec_A9512LovStrs);
					this.trkSysFeaturesTxBaseTimeSec_A9512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysFeaturesTxBaseTimeSec_A9512.DataTransferOrder = 78;
					num = (short)744226821;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑뷓ꋕ뷗觙맛닝藟臡郣蟥諧蛩觫꿭鳯韱蛳苵듷鏹迻諽忿䌁〃㐅㠇㰉㰋", a_)))
					{
						num = (short)213450785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C16;
				case 24:
					this.trkSysFeaturesSecureLED_A9071 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뷭闯釱至蓵鷷뛹맻뫽忿䌁㴃㘅㼇㬉", a_), global::CommonResources.AcgResources.ID_RADIOERGOSECURELED);
					this.trkSysFeaturesSecureLED_A9071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesSecureLED_A9071.DataTransferOrder = 30;
					num = (short)507183108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)1201602569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_4B0;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뻭뇯ꇱ釳髵鷷駹裻韽濿氁嬃䜅㰇㠉㐋㘍∏", a_)))
					{
						num = (short)1876033568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37A;
				case 28:
					goto IL_415;
				case 29:
					goto IL_886;
				case 30:
					goto IL_97C;
				case 31:
					goto IL_F32;
				case 32:
					this.trkSysFeaturesPASelection_A42882 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뻭뇯ꇱ釳髵鷷駹裻韽濿氁嬃䜅㰇㠉㐋㘍∏", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.trkSysFeaturesPASelection_A42882.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesPASelection_A42882.DataTransferOrder = 150;
					num = (short)432930872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					this.siteSelectableAlertList_A42060 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臑뷓ꋕ뷗觙맛닝藟臡郣蟥諧蛩觫꿭鳯韱蛳苵듷鏹迻諽忿䌁〃㐅㠇㰉㰋", a_), global::CommonResources.AcgResources.ID_SITESELECTABLEALERTSITESELECTABLEALERTLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.siteSelectableAlertList_A42060.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.siteSelectableAlertList_A42060.DataTransferOrder = 104;
					num = (short)1102250051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					switch (0)
					{
					case 0:
						goto IL_151;
					}
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뷭闯釱至蓵鷷뛹맻뫽忿䌁㴃㘅㼇㬉", a_)))
					{
						num = (short)345505816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E42;
				case 36:
					goto IL_3C8;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫듭鿯鳱釳꧵맷쏹쯻쿽㟿", a_)))
					{
						num = (short)1447559210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ACA;
				case 38:
					this.trkSysFeatureLocationOnPTT_43026 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩ꃫ臭鏯鏱胳鿵韷铹돻都僿嘁倃夅㰇㤉㰋㰍☏", a_), global::CommonResources.AcgResources.ID_LOCATIONONPTT);
					this.trkSysFeatureLocationOnPTT_43026.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysFeatureLocationOnPTT_43026.DataTransferOrder = 265;
					num = (short)573833242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꯭黯鏱雳髵鷷ꗹ뷻짽㧿㐁㰃", a_)))
					{
						num = (short)279248944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_179;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꟭돯꟱뗳ꓵ鷷觹駻諽忿䌁㰃㐅㰇㌉", a_)))
					{
						num = (short)74645523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_415;
				case 41:
					goto IL_463;
				case 42:
					this.trkSysFeaturesZone_A9717 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫듭鿯鳱釳꧵맷쏹쯻쿽㟿", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkSysFeaturesZone_A9717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysFeaturesZone_A9717.DataTransferOrder = 52;
					num = (short)87949327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					this.trkSysFeaturesHearClear_A36422 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꛭ闯鏱蛳뗵铷鿹鷻賽忿䌁㜃々㰇㠉㸋", a_), global::CommonResources.AcgResources.ID_HEARCLEAR, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesHearClear_A36422LovStrs);
					this.trkSysFeaturesHearClear_A36422.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesHearClear_A36422.DataTransferOrder = 120;
					num = (short)2031419400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					num = (short)1402273798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭裯냱闳藵鷷껹闻鏽旿儁愃攅圇䬉㔋㬍ℏ‑", a_)))
					{
						num = (short)795279382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7E;
				case 46:
					goto IL_10E1;
				case 47:
					goto IL_2DC;
				case 48:
					this.trkSysFeaturesEnable_A7968 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꯭黯鏱雳髵鷷ꗹ뷻짽㧿㐁㰃", a_), global::CommonResources.AcgResources.ID_REMOTEMONITORRADIOTRACEENABLE);
					this.trkSysFeaturesEnable_A7968.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesEnable_A7968.DataTransferOrder = 25;
					num = (short)2055733305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫볭釯雱鷳駵뇷铹铻韽拿欁瀃夅䤇㈉㐋㴍⌏", a_)))
					{
						num = (short)2032009266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D5;
				case 50:
					this.trkSysFeaturesRadioInhibit_A8833 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫볭釯雱鷳駵뇷铹铻韽拿欁瀃夅䤇㈉㐋㴍⌏", a_), global::CommonResources.AcgResources.ID_RADIOINHIBIT);
					this.trkSysFeaturesRadioInhibit_A8833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesRadioInhibit_A8833.DataTransferOrder = 100;
					num = (short)1437466642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_230;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑뷓ꋕ뷗觙맛닝藟臡郣蟥諧蛩觫꿭鳯韱蛳苵맷雹闻鿽珿丁洃甅簇唉䴋㨍∏⌑␓☕", a_)))
					{
						num = (short)725024821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97C;
				case 53:
					goto IL_76C;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꫭꓯ뿱닳ꋵ釷韹闻都柿嘁攃搅搇漉匋伍✏⬑␓☕", a_)))
					{
						num = (short)1423507476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DC;
				case 55:
					this.trkSysFeaturesDynamicRegroupingEnable_A7969 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꫭ觯鳱闳鯵釷駹껻鯽柿瀁欃猅砇按戋植唏簑甓琕琗缙䌛弝ᜟᬡሣἥ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGDYNAMICREGROUPINGENABLE);
					this.trkSysFeaturesDynamicRegroupingEnable_A7969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesDynamicRegroupingEnable_A7969.DataTransferOrder = 8;
					num = (short)2051080243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_37A;
				case 57:
					goto IL_179;
				case 58:
					goto IL_EE4;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꛭ闯鏱蛳뗵铷鿹鷻賽忿䌁㜃々㰇㠉㸋", a_)))
					{
						num = (short)1482883115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32C;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩ꃫ臭鏯鏱胳鿵韷铹돻都僿嘁倃夅㰇㤉㰋㰍☏", a_)))
					{
						num = (short)2128085030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B0;
				case 61:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫뫭裯ꋱ鯳臵鷷裹냻鯽盿朁栃夅䤇㌉㤋㬍✏", a_)))
					{
						num = (short)1698627595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C8;
				case 62:
					this.trkSysLabtoolEnable_A8669 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鋝臟胡郣觥蟧蛩ꧫ胭釯郱飳鏵ꟷ믹쓻죽㛿㬁", a_), global::CommonResources.AcgResources.ID_POP25ENABLE);
					this.trkSysLabtoolEnable_A8669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysLabtoolEnable_A8669.DataTransferOrder = 103;
					num = (short)698417153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫귭飯鏱髳飵鷷雹ꏻ뿽㟿㐁〃ㄅ", a_)))
					{
						num = (short)1034682368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_886;
				case 64:
					this.trkSysFeaturesICUAAutoResetTimesec_A7515 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꟭돯꟱뗳럵跷軹鏻곽旿焁愃爅將按愋欍挏眑眓䤕夗ⴙ⤛⼝ᔟ", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTICUAAUTORESETTIMESEC, null, null, 0, 1);
					this.trkSysFeaturesICUAAutoResetTimesec_A7515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysFeaturesICUAAutoResetTimesec_A7515.DataTransferOrder = 35;
					this.trkSysFeaturesICUAAutoResetTimesec_A7515.ShowHexValue = false;
					num = (short)569442335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					this.trkSysFeaturesGroupTMSEable_42804 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꧭ苯鷱至蛵곷럹꿻믽懿态栃挅圇㸉㸋㘍‏☑", a_), global::CommonResources.AcgResources.ID_GROUPTEXTMESSAGINGSERVICE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysFeaturesGroupTMSEable_42804LovStrs);
					this.trkSysFeaturesGroupTMSEable_42804.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysFeaturesGroupTMSEable_42804.DataTransferOrder = 151;
					num = (short)260112442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫꯭鷯韱蛳釵鷷铹鿻蟽䇿渁攃琅攇堉琋䜍縏瘑紓甕礗渙猛氝缟挡ጣἥᬧᠩ", a_)))
					{
						num = (short)475856910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62A;
				case 67:
					goto IL_C16;
				case 68:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鋝臟胡郣觥蟧蛩ꧫ胭釯郱飳鏵ꟷ믹쓻죽㛿㬁", a_)))
					{
						num = (short)994836542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_678;
				case 69:
					this.trkSysFeaturesBusyLED_44911 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫곭藯臱跳뫵뷷뻹ꏻ쫽㓿㬁㔃㜅", a_), global::CommonResources.AcgResources.ID_BUSYLED);
					this.trkSysFeaturesBusyLED_44911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysFeaturesBusyLED_44911.DataTransferOrder = 31;
					num = (short)1818493000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 70:
					this.trkPerFeaturesOTARadioAliasType_42854 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕裗뿙껛飝藟菡郣鏥髧迩鿫ꇭꓯ돱꛳韵鳷鏹鏻뿽泿欁攃甅將猉簋欍伏☑☓⸕ⴗ⸙", a_), global::CommonResources.AcgResources.ID_OTARADIOALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkPerFeaturesOTARadioAliasType_42854LovStrs);
					this.trkPerFeaturesOTARadioAliasType_42854.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerFeaturesOTARadioAliasType_42854.DataTransferOrder = 300;
					num = (short)1297023017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 71:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛飝藟菡郣鏥髧迩鿫ꧭ苯鷱至蛵곷럹꿻믽懿态栃挅圇㸉㸋㘍‏☑", a_)))
					{
						num = (short)1805582401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE4;
				case 72:
					goto IL_525;
				}
				IL_151:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1715470361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_179:
				num = (short)225116183;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_230:
				num = (short)689111080;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DC:
				num = (short)287375426;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32C:
				num = (short)2038235175;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37A:
				num = (short)1754136636;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C8:
				num = (short)1342439461;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_415:
				num = (short)919273540;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_463:
				num = (short)771751963;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B0:
				num = (short)409272336;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_525:
				num = (short)320339970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62A:
				num = (short)1835991047;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_678:
				num = (short)1337310085;
				short num4 = num;
				num = (short)1426897797;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_76C:
					this.siteSelectableAlertAliasList_A42100 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臑뷓ꋕ뷗觙맛닝藟臡郣蟥諧蛩觫꿭鳯韱蛳苵맷雹闻鿽珿丁洃甅簇唉䴋㨍∏⌑␓☕", a_), global::CommonResources.AcgResources.ID_SITESELECTABLEALERTSITESELECTABLEALERTALIASTEXTLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.siteSelectableAlertAliasList_A42100.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.siteSelectableAlertAliasList_A42100.DataTransferOrder = -1;
					num = (short)479395870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1083310080;
					if (num != 0)
					{
					}
					num = (short)1191182385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_886:
				num = (short)786169915;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D5:
				num = (short)848232483;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_97C:
				num = (short)334233671;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ACA:
				num = (short)137166911;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BCB:
				num = (short)1256521773;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C16:
				num = (short)1681653812;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E42:
				num = (short)124321805;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EE4:
				num = (short)478543889;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F32:
				num = (short)1256587318;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F7E:
				num = (short)956432445;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E1:
			IL_11AB:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铑뇓럕곗꿙껛믝鏟", a_);
			base.Id = 10154;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000D816C File Offset: 0x000D636C
		public override void PopulateReferences()
		{
			short num = (short)1071500083;
			short num2 = num;
			num = (short)744082227;
			switch (num2 == num)
			{
			}
			num = (short)2102198272;
			if (num != 0)
			{
			}
			num = (short)2040201217;
			if (num != 0)
			{
			}
			num = (short)1475739648;
			short num3 = num;
			this.trkSysFeaturesDTMFTimingTable_A7900.SetRecset(this.a(2000)[0][10002].EmbeddedRecset);
			this.trkSysFeaturesZone_A9717.SetRecset(this.a(2051));
			this.siteSelectableAlertList_A42060.SetRecset(this.a(4145));
			this.siteSelectableAlertAliasList_A42100.SetRecset(this.a(4145));
			this.trkSysFeaturesPASelection_A42882.SetRecset(this.a(4176));
			this.trkSysFeaturesZone_A9717.AddSlaveField(this.trkSysFeaturesChannel_A7647, 10114);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000D82B0 File Offset: 0x000D64B0
		public override void DropReferences()
		{
			short num = (short)963360869;
			short num2 = num;
			num = (short)1488304229;
			switch (num2 == num)
			{
			}
			num = (short)1602289664;
			if (num != 0)
			{
			}
			num = (short)210894849;
			if (num != 0)
			{
			}
			num = (short)1522270208;
			short num3 = num;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000D835C File Offset: 0x000D655C
		public override void SetConstraints()
		{
			short num = (short)950775392;
			short num2 = num;
			num = (short)1422175840;
			switch (num2 == num)
			{
			}
			num = (short)1775042561;
			if (num != 0)
			{
			}
			num = (short)758972416;
			if (num != 0)
			{
			}
			num = (short)824049664;
			short num3 = num;
			this.trkSysFeaturesICUAAutoResetTimesec_A7515.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkInCallRstTypeIsNotManual);
			this.trkSysFeaturesDTMFTimingTable_A7900.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConEmerAlrmRxIndicTypeNotNoIndic);
			this.trkSysFeaturesDynamicRegroupingEnable_A7969.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysDynamicRegroupEnIsValid);
			this.trkSysLabtoolEnable_A8669.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysIsDataEnabledAndTrkSysTypeIsASTRO25);
			this.trkSysFeaturesRadioInhibit_A8833.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkRadInhApp);
			this.trkSysFeaturesRadioInhibit_A8833.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkRadInhValid);
			this.trkSysFeaturesTextMessagingService_A9373.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysIsDataEnabledAndTrkSysTypeIsASTRO25);
			this.trkSysFeaturesTextMessagingService_A9373.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkTxtMsgValueValid);
			this.trkSysFeaturesTxBaseTimeSec_A9512.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIIAndTrkRemoteMonTraceEn);
			this.trkSysFeaturesZone_A9717.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysDynRegrIsEnabled);
			this.trkSysFeaturesZone_A9717.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysDynRegroupZoneIsValid);
			this.trkSysFeaturesChannel_A7647.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysDynRegrIsEnabledAndNonDynamicZone);
			this.trkSysFeaturesChannel_A7647.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysDynRegroupChannelIsValid);
			this.trkSysFeaturesHearClear_A36422.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDVRSIsEnAndTrkHearClearApp);
			this.trkSysFeaturesHearClear_A36422.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDVRSIsEnAndTrkHearClearValid);
			this.trkSysFeaturesEnable_A7968.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsIIOrAstro25);
			this.siteSelectableAlertList_A42060.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.siteSelectableAlertList_A42060.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConNOTTrkSysCoverageTypeNotDisableAndSiteAliasDisable);
			this.siteSelectableAlertList_A42060.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25_2);
			this.siteSelectableAlertList_A42060.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetTgrpAliasTxtRecRef);
			this.trkSysFeaturesGroupTMSEable_42804.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysGroupTMSIsEnabled);
			this.trkSysFeaturesPASelection_A42882.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkPerAccSelectionIsValid);
			this.trkSysFeaturesPASelection_A42882.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkPerAccSelectionIsVisible);
			this.trkSysFeatureLocationOnPTT_43026.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConLocationEnableIsEnabledAndSystemTypeIsASTRO25);
			this.trkSysFeatureLocationOnPTT_43026.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conLocationOnPTTValid);
			this.trkSysFeatureLocationOnPTT_43026.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysOTARadioAliasUpdateEnableIsApp);
			this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000D86A0 File Offset: 0x000D68A0
		public override void SetupDependencies()
		{
			short num = (short)1712655411;
			short num2 = num;
			num = (short)883493939;
			switch (num2 == num)
			{
			}
			num = (short)801046529;
			if (num != 0)
			{
			}
			num = (short)979632128;
			if (num != 0)
			{
			}
			num = (short)1576534016;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			this.trkSysFeaturesICUAReset_A8249.AddDependentObject(this.trkSysFeaturesICUAAutoResetTimesec_A7515);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesDTMFTimingTable_A7900);
			this.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.AddDependentObject(this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysLabtoolEnable_A8669);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysLabtoolEnable_A8669);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			trunkingSystem.SecureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysFeaturesRadioInhibit_A8833);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysFeaturesTextMessagingService_A9373);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesTextMessagingService_A9373);
			this.RefDisplayAndMenu.Advanced.DispMenuAdvancedLanguageSelection_A8386.AddDependentObject(this.trkSysFeaturesTextMessagingService_A9373);
			this.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372.AddDependentObject(this.trkSysFeaturesTextMessagingService_A9373);
			this.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.AddDependentObject(this.trkSysFeaturesTextMessagingService_A9373);
			this.trkSysFeaturesEnable_A7968.AddDependentObject(this.trkSysFeaturesTxBaseTimeSec_A9512);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesTxBaseTimeSec_A9512);
			this.trkSysFeaturesDynamicRegroupingEnable_A7969.AddDependentObject(this.trkSysFeaturesZone_A9717);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkSysFeaturesHearClear_A36422);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesHearClear_A36422);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesEnable_A7968);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.siteSelectableAlertList_A42060);
			this.siteSelectableAlertAliasList_A42100.AddDependentObject(this.siteSelectableAlertList_A42060);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesGroupTMSEable_42804);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesPASelection_A42882);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeatureLocationOnPTT_43026);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.trkSysFeatureLocationOnPTT_43026);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysFeatureLocationOnPTT_43026);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057);
			this.trkPerFeaturesOTARadioAliasType_42854.AddDependentObject(this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.AddDependentObject(this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057);
			this.trkSysFeaturesRadioInhibit_A8833.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10042] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR).SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000D8AB8 File Offset: 0x000D6CB8
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner DTMFTimingInnerSectionForTrkSysFeaturesDTMFTimingTable_A7900
		{
			get
			{
				short num = (short)480209965;
				short num2 = num;
				num = (short)5925933;
				switch (num2 == num)
				{
				}
				num = (short)368705537;
				if (num != 0)
				{
				}
				num = (short)2031026176;
				if (num != 0)
				{
				}
				num = (short)38600704;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000D8B74 File Offset: 0x000D6D74
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForTrkSysFeaturesZone_A9717
		{
			get
			{
				short num = (short)1260580684;
				short num2 = num;
				num = (short)1161490252;
				switch (num2 == num)
				{
				}
				num = (short)585302017;
				if (num != 0)
				{
				}
				num = (short)1921187840;
				if (num != 0)
				{
				}
				num = (short)1738342400;
				short num3 = num;
				return this.trkSysFeaturesZone_A9717.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000D8C2C File Offset: 0x000D6E2C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForTrkSysFeaturesChannel_A7647
		{
			get
			{
				short num = (short)1847459841;
				if (num != 0)
				{
				}
				num = (short)995964457;
				short num2 = num;
				num = (short)334706217;
				switch (num2 == num)
				{
				}
				num = (short)1273167872;
				if (num != 0)
				{
				}
				num = (short)1497038848;
				short num3 = num;
				return this.trkSysFeaturesChannel_A7647.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000D8CE4 File Offset: 0x000D6EE4
		public global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability PersonnelAccountabilityForTrkSysFeaturesPASelection_A42882
		{
			get
			{
				short num = (short)1774043880;
				short num2 = num;
				num = (short)806339304;
				switch (num2 == num)
				{
				}
				num = (short)1329790977;
				if (num != 0)
				{
				}
				num = (short)35913728;
				if (num != 0)
				{
				}
				num = (short)227082240;
				short num3 = num;
				return this.trkSysFeaturesPASelection_A42882.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x000D8D9C File Offset: 0x000D6F9C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1327276198;
				short num2 = num;
				num = (short)1503043750;
				switch (num2 == num)
				{
				}
				num = (short)809697281;
				if (num != 0)
				{
				}
				num = (short)1181745152;
				if (num != 0)
				{
				}
				num = (short)877723648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000D8E4C File Offset: 0x000D704C
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x000D8F00 File Offset: 0x000D7100
		public int TrkSysFeaturesICUAAutoResetTimesec_A7515Value
		{
			get
			{
				short num = (short)1883349391;
				short num2 = num;
				num = (short)458203535;
				switch (num2 == num)
				{
				}
				num = (short)17563649;
				if (num != 0)
				{
				}
				num = (short)665124864;
				if (num != 0)
				{
				}
				num = (short)221118464;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Value;
			}
			set
			{
				short num = (short)1676824741;
				short num2 = num;
				num = (short)201150629;
				switch (num2 == num)
				{
				}
				num = (short)1292697600;
				if (num != 0)
				{
				}
				num = (short)186908673;
				if (num != 0)
				{
				}
				num = (short)758185984;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Value = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysFeaturesICUAAutoResetTimesec_A7515
		{
			get
			{
				short num = (short)427475243;
				short num2 = num;
				num = (short)1537392939;
				switch (num2 == num)
				{
				}
				num = (short)1517682688;
				if (num != 0)
				{
				}
				num = (short)1110245377;
				if (num != 0)
				{
				}
				num = (short)1715011584;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000D9064 File Offset: 0x000D7264
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x000D911C File Offset: 0x000D731C
		public string TrkSysFeaturesICUAAutoResetTimesec_A7515_UIValue
		{
			get
			{
				short num = (short)825522310;
				short num2 = num;
				num = (short)933787782;
				switch (num2 == num)
				{
				}
				num = (short)985333761;
				if (num != 0)
				{
				}
				num = (short)550502400;
				if (num != 0)
				{
				}
				num = (short)380239872;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.UIValue;
			}
			set
			{
				short num = (short)1589027591;
				short num2 = num;
				num = (short)750035719;
				switch (num2 == num)
				{
				}
				num = (short)1722023936;
				if (num != 0)
				{
				}
				num = (short)461832193;
				if (num != 0)
				{
				}
				num = (short)440664064;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.UIValue = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000D91D4 File Offset: 0x000D73D4
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x000D9284 File Offset: 0x000D7484
		internal int TrkSysFeaturesICUAAutoResetTimesec_A7515Min
		{
			get
			{
				short num = (short)513619710;
				short num2 = num;
				num = (short)1276655358;
				switch (num2 == num)
				{
				}
				num = (short)1279655936;
				if (num != 0)
				{
				}
				num = (short)684392449;
				if (num != 0)
				{
				}
				num = (short)734855168;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Min;
			}
			set
			{
				short num = (short)593887233;
				if (num != 0)
				{
				}
				num = (short)650988215;
				short num2 = num;
				num = (short)1284786871;
				switch (num2 == num)
				{
				}
				num = (short)1098711040;
				if (num != 0)
				{
				}
				num = (short)1920663552;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Min = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x000D933C File Offset: 0x000D753C
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x000D93F0 File Offset: 0x000D75F0
		internal int TrkSysFeaturesICUAAutoResetTimesec_A7515Max
		{
			get
			{
				short num = (short)168593881;
				short num2 = num;
				num = (short)2038467033;
				switch (num2 == num)
				{
				}
				num = (short)593231873;
				if (num != 0)
				{
				}
				num = (short)873267200;
				if (num != 0)
				{
				}
				num = (short)1054408704;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Max;
			}
			set
			{
				short num = (short)1367998465;
				if (num != 0)
				{
				}
				num = (short)1621043955;
				short num2 = num;
				num = (short)1173170931;
				switch (num2 == num)
				{
				}
				num = (short)1061683200;
				if (num != 0)
				{
				}
				num = (short)2104557568;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Max = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x000D94A8 File Offset: 0x000D76A8
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000D955C File Offset: 0x000D775C
		internal int TrkSysFeaturesICUAAutoResetTimesec_A7515Step
		{
			get
			{
				short num = (short)520387931;
				short num2 = num;
				num = (short)568425819;
				switch (num2 == num)
				{
				}
				num = (short)1840316417;
				if (num != 0)
				{
				}
				num = (short)566231040;
				if (num != 0)
				{
				}
				num = (short)1521090560;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.StepSize;
			}
			set
			{
				short num = (short)924443854;
				short num2 = num;
				num = (short)66184398;
				switch (num2 == num)
				{
				}
				num = (short)1087700993;
				if (num != 0)
				{
				}
				num = (short)1722875904;
				if (num != 0)
				{
				}
				num = (short)631373824;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.StepSize = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x000D9610 File Offset: 0x000D7810
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000D96C4 File Offset: 0x000D78C4
		public bool TrkSysFeaturesICUAAutoResetTimesec_A7515_Applicable
		{
			get
			{
				short num = (short)1184366593;
				if (num != 0)
				{
				}
				num = (short)1488885211;
				short num2 = num;
				num = (short)1497798107;
				switch (num2 == num)
				{
				}
				num = (short)1608777728;
				if (num != 0)
				{
				}
				num = (short)1130102784;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Applicable;
			}
			set
			{
				short num = (short)1018416666;
				short num2 = num;
				num = (short)2095762970;
				switch (num2 == num)
				{
				}
				num = (short)1198850048;
				if (num != 0)
				{
				}
				num = (short)1981415425;
				if (num != 0)
				{
				}
				num = (short)1597308928;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Applicable = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x000D977C File Offset: 0x000D797C
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x000D9830 File Offset: 0x000D7A30
		public bool TrkSysFeaturesICUAAutoResetTimesec_A7515_Valid
		{
			get
			{
				short num = (short)1092040293;
				short num2 = num;
				num = (short)619918949;
				switch (num2 == num)
				{
				}
				num = (short)181075968;
				if (num != 0)
				{
				}
				num = (short)1893335041;
				if (num != 0)
				{
				}
				num = (short)1789132800;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Valid;
			}
			set
			{
				short num = (short)304798880;
				short num2 = num;
				num = (short)158391456;
				switch (num2 == num)
				{
				}
				num = (short)887619584;
				if (num != 0)
				{
				}
				num = (short)366936065;
				if (num != 0)
				{
				}
				num = (short)1510932480;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Valid = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000D98E4 File Offset: 0x000D7AE4
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x000D999C File Offset: 0x000D7B9C
		public bool TrkSysFeaturesICUAAutoResetTimesec_A7515_Visible
		{
			get
			{
				short num = (short)50394020;
				short num2 = num;
				num = -3164;
				switch (num2 == num)
				{
				}
				num = (short)1418657793;
				if (num != 0)
				{
				}
				num = (short)287768576;
				if (num != 0)
				{
				}
				num = (short)883621888;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Visible;
			}
			set
			{
				short num = (short)497259136;
				short num2 = num;
				num = (short)1696633472;
				switch (num2 == num)
				{
				}
				num = (short)76677121;
				if (num != 0)
				{
				}
				num = (short)2065367040;
				if (num != 0)
				{
				}
				num = (short)1115684864;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Visible = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000D9A58 File Offset: 0x000D7C58
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x000D9B10 File Offset: 0x000D7D10
		public bool TrkSysFeaturesICUAAutoResetTimesec_A7515_Editable
		{
			get
			{
				short num = (short)1634413066;
				short num2 = num;
				num = (short)1730423306;
				switch (num2 == num)
				{
				}
				num = (short)939851776;
				if (num != 0)
				{
				}
				num = (short)366215169;
				if (num != 0)
				{
				}
				num = (short)17104896;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.Editable;
			}
			set
			{
				short num = (short)1158301830;
				short num2 = num;
				num = (short)1540573318;
				switch (num2 == num)
				{
				}
				num = (short)1199767553;
				if (num != 0)
				{
				}
				num = (short)629342208;
				if (num != 0)
				{
				}
				num = (short)2117795840;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.Editable = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000D9BC8 File Offset: 0x000D7DC8
		internal string TrkSysFeaturesICUAAutoResetTimesec_A7515_UILabel
		{
			get
			{
				short num = (short)1168190126;
				short num2 = num;
				num = (short)890579630;
				switch (num2 == num)
				{
				}
				num = (short)267517952;
				if (num != 0)
				{
				}
				num = (short)2027880449;
				if (num != 0)
				{
				}
				num = (short)1711210496;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.UIName;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000D9C80 File Offset: 0x000D7E80
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x000D9D38 File Offset: 0x000D7F38
		internal bool TrkSysFeaturesICUAAutoResetTimesec_A7515_HiddenStatic
		{
			get
			{
				short num = (short)1196212673;
				short num2 = num;
				num = (short)89244097;
				switch (num2 == num)
				{
				}
				num = (short)596967424;
				if (num != 0)
				{
				}
				num = (short)1343422465;
				if (num != 0)
				{
				}
				num = (short)702480384;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.HiddenStatic;
			}
			set
			{
				short num = (short)845545473;
				if (num != 0)
				{
				}
				num = (short)746719534;
				short num2 = num;
				num = (short)1566771502;
				switch (num2 == num)
				{
				}
				num = (short)1412956160;
				if (num != 0)
				{
				}
				num = (short)2096103424;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.HiddenStatic = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000D9DF0 File Offset: 0x000D7FF0
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000D9EA4 File Offset: 0x000D80A4
		internal bool TrkSysFeaturesICUAAutoResetTimesec_A7515_HiddenDynamic
		{
			get
			{
				short num = (short)1811809115;
				short num2 = num;
				num = (short)36766555;
				switch (num2 == num)
				{
				}
				num = (short)975699969;
				if (num != 0)
				{
				}
				num = (short)796131328;
				if (num != 0)
				{
				}
				num = (short)671612928;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515.HiddenDynamic;
			}
			set
			{
				short num = (short)1973726518;
				short num2 = num;
				num = (short)923315510;
				switch (num2 == num)
				{
				}
				num = (short)1903820800;
				if (num != 0)
				{
				}
				num = (short)347668481;
				if (num != 0)
				{
				}
				num = (short)876347392;
				short num3 = num;
				this.trkSysFeaturesICUAAutoResetTimesec_A7515.HiddenDynamic = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000D9F5C File Offset: 0x000D815C
		public bool TrkSysFeaturesICUAAutoResetTimesec_A7515_HasDiffs
		{
			get
			{
				short num = (short)2094077804;
				short num2 = num;
				num = (short)1664227180;
				switch (num2 == num)
				{
				}
				num = (short)1049100289;
				if (num != 0)
				{
				}
				num = (short)826212352;
				if (num != 0)
				{
				}
				num = (short)2020671488;
				short num3 = num;
				return this.trkSysFeaturesICUAAutoResetTimesec_A7515._HasDiffs;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000DA010 File Offset: 0x000D8210
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x000DA0C0 File Offset: 0x000D82C0
		public int TrkSysFeaturesDTMFTimingTable_A7900Value
		{
			get
			{
				short num = (short)1266417665;
				if (num != 0)
				{
				}
				num = (short)1427426571;
				short num2 = num;
				num = (short)1830014219;
				switch (num2 == num)
				{
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				num = (short)47644672;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900.Value;
			}
			set
			{
				short num = (short)1348801480;
				short num2 = num;
				num = (short)1601639368;
				switch (num2 == num)
				{
				}
				num = (short)134676480;
				if (num != 0)
				{
				}
				num = (short)1704329217;
				if (num != 0)
				{
				}
				num = (short)965738496;
				short num3 = num;
				this.trkSysFeaturesDTMFTimingTable_A7900.Value = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x000DA178 File Offset: 0x000D8378
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x000DA22C File Offset: 0x000D842C
		public string TrkSysFeaturesDTMFTimingTable_A7900_UIValue
		{
			get
			{
				short num = (short)1218926867;
				short num2 = num;
				num = (short)1484609811;
				switch (num2 == num)
				{
				}
				num = (short)651558912;
				if (num != 0)
				{
				}
				num = (short)277872641;
				if (num != 0)
				{
				}
				num = (short)2095448064;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900.UIValue;
			}
			set
			{
				short num = (short)1223294977;
				if (num != 0)
				{
				}
				num = (short)86201645;
				short num2 = num;
				num = (short)2037798189;
				switch (num2 == num)
				{
				}
				num = (short)1692532736;
				if (num != 0)
				{
				}
				num = (short)2053767168;
				short num3 = num;
				this.trkSysFeaturesDTMFTimingTable_A7900.UIValue = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x000DA2E0 File Offset: 0x000D84E0
		public global::AcpBusinessLayer.AcpRecRefField TrkSysFeaturesDTMFTimingTable_A7900
		{
			get
			{
				short num = (short)1485645619;
				short num2 = num;
				num = (short)1617241907;
				switch (num2 == num)
				{
				}
				num = (short)1513095168;
				if (num != 0)
				{
				}
				num = (short)711393281;
				if (num != 0)
				{
				}
				num = (short)1745813504;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000DA390 File Offset: 0x000D8590
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x000DA444 File Offset: 0x000D8644
		public bool TrkSysFeaturesDTMFTimingTable_A7900_Applicable
		{
			get
			{
				short num = (short)729864431;
				short num2 = num;
				num = (short)730978543;
				switch (num2 == num)
				{
				}
				num = (short)874840064;
				if (num != 0)
				{
				}
				num = (short)1648754689;
				if (num != 0)
				{
				}
				num = (short)2066481152;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900.Applicable;
			}
			set
			{
				short num = (short)1134609847;
				short num2 = num;
				num = (short)1298777527;
				switch (num2 == num)
				{
				}
				num = (short)906887169;
				if (num != 0)
				{
				}
				num = (short)639041536;
				if (num != 0)
				{
				}
				num = (short)663486464;
				short num3 = num;
				this.trkSysFeaturesDTMFTimingTable_A7900.Applicable = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000DA4F8 File Offset: 0x000D86F8
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000DA5AC File Offset: 0x000D87AC
		public bool TrkSysFeaturesDTMFTimingTable_A7900_Valid
		{
			get
			{
				short num = (short)2025315445;
				short num2 = num;
				num = (short)1710742645;
				switch (num2 == num)
				{
				}
				num = (short)72810497;
				if (num != 0)
				{
				}
				num = (short)471728128;
				if (num != 0)
				{
				}
				num = (short)1920925696;
				short num3 = num;
				return this.trkSysFeaturesDTMFTimingTable_A7900.Valid;
			}
			set
			{
				short num = (short)1641618838;
				short num2 = num;
				num = (short)151657878;
				switch (num2 == num)
				{
				}
				num = (short)1669332993;
				if (num != 0)
				{
				}
				num = (short)319750144;
				if (num != 0)
				{
				}
				num = (short)416743424;
				short num3 = num;
				this.trkSysFeaturesDTMFTimingTable_A7900.Valid = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000DA664 File Offset: 0x000D8864
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000DA714 File Offset: 0x000D8914
		public bool TrkSysFeaturesDTMFTimingTable_A7900_Visible
		{
			get
			{
				short num = (short)695468032;
				short num2 = num;
				num = (short)2042752846;
				short num3 = num;
				num = (short)1819078478;
				switch (num3 == num)
				{
				}
				num = (short)1983053825;
				if (num != 0)
				{
				}
				num = (short)145883136;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900.Visible;
			}
			set
			{
				short num = (short)77266944;
				short num2 = num;
				num = (short)225091824;
				short num3 = num;
				num = (short)731488496;
				switch (num3 == num)
				{
				}
				num = (short)1694367744;
				if (num != 0)
				{
				}
				num = (short)2118385665;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDTMFTimingTable_A7900.Visible = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000DA7C8 File Offset: 0x000D89C8
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000DA87C File Offset: 0x000D8A7C
		public bool TrkSysFeaturesDTMFTimingTable_A7900_Editable
		{
			get
			{
				short num = (short)177799168;
				short num2 = num;
				num = (short)638773212;
				short num3 = num;
				num = (short)2076108764;
				switch (num3 == num)
				{
				}
				num = (short)249364480;
				if (num != 0)
				{
				}
				num = (short)1689059329;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900.Editable;
			}
			set
			{
				short num = (short)2018246656;
				short num2 = num;
				num = (short)1399220525;
				short num3 = num;
				num = (short)495544621;
				switch (num3 == num)
				{
				}
				num = (short)1628569600;
				if (num != 0)
				{
				}
				num = (short)1411186689;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDTMFTimingTable_A7900.Editable = value;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000DA92C File Offset: 0x000D8B2C
		internal string TrkSysFeaturesDTMFTimingTable_A7900_UILabel
		{
			get
			{
				short num = (short)2084438016;
				short num2 = num;
				num = (short)964930626;
				short num3 = num;
				num = (short)1643424834;
				switch (num3 == num)
				{
				}
				num = (short)1674641408;
				if (num != 0)
				{
				}
				num = (short)2105016321;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900.UIName;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000DAA9C File Offset: 0x000D8C9C
		internal bool TrkSysFeaturesDTMFTimingTable_A7900_HiddenStatic
		{
			get
			{
				short num = (short)248315904;
				short num2 = num;
				num = (short)2057043969;
				if (num != 0)
				{
				}
				num = (short)60756427;
				short num3 = num;
				num = (short)1834947019;
				switch (num3 == num)
				{
				}
				num = (short)592642048;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900.HiddenStatic;
			}
			set
			{
				short num = (short)640221184;
				short num2 = num;
				num = (short)1861025793;
				if (num != 0)
				{
				}
				num = (short)930488407;
				short num3 = num;
				num = (short)2106138711;
				switch (num3 == num)
				{
				}
				num = (short)1212219392;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDTMFTimingTable_A7900.HiddenStatic = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000DAB50 File Offset: 0x000D8D50
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x000DAC04 File Offset: 0x000D8E04
		internal bool TrkSysFeaturesDTMFTimingTable_A7900_HiddenDynamic
		{
			get
			{
				short num = (short)763691008;
				short num2 = num;
				num = (short)71784267;
				short num3 = num;
				num = (short)1360353099;
				switch (num3 == num)
				{
				}
				num = (short)2082668545;
				if (num != 0)
				{
				}
				num = (short)139460608;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900.HiddenDynamic;
			}
			set
			{
				short num = (short)965672960;
				short num2 = num;
				num = (short)1198998615;
				short num3 = num;
				num = (short)2109752407;
				switch (num3 == num)
				{
				}
				num = (short)348258305;
				if (num != 0)
				{
				}
				num = (short)1233780736;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDTMFTimingTable_A7900.HiddenDynamic = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x000DACBC File Offset: 0x000D8EBC
		public bool TrkSysFeaturesDTMFTimingTable_A7900_HasDiffs
		{
			get
			{
				short num = (short)1347747840;
				short num2 = num;
				num = (short)482688210;
				short num3 = num;
				num = (short)36650194;
				switch (num3 == num)
				{
				}
				num = (short)621740033;
				if (num != 0)
				{
				}
				num = (short)1162149888;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDTMFTimingTable_A7900._HasDiffs;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000DAD70 File Offset: 0x000D8F70
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000DAE24 File Offset: 0x000D9024
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932Value
		{
			get
			{
				short num = (short)2113273856;
				short num2 = num;
				num = (short)1105429203;
				short num3 = num;
				num = (short)1859551955;
				switch (num3 == num)
				{
				}
				num = (short)1931673601;
				if (num != 0)
				{
				}
				num = (short)261881856;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Value;
			}
			set
			{
				short num = (short)824967168;
				short num2 = num;
				num = (short)4531625;
				short num3 = num;
				num = (short)849028521;
				switch (num3 == num)
				{
				}
				num = (short)1338834945;
				if (num != 0)
				{
				}
				num = (short)1646592000;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Value = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000DAED8 File Offset: 0x000D90D8
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesEmergencyAlarmRxIndicator_A7932
		{
			get
			{
				short num = (short)2128281600;
				short num2 = num;
				num = (short)352256001;
				if (num != 0)
				{
				}
				num = (short)870055192;
				short num3 = num;
				num = (short)1454046488;
				switch (num3 == num)
				{
				}
				num = (short)1571160064;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x000DAF88 File Offset: 0x000D9188
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x000DB040 File Offset: 0x000D9240
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_UIValue
		{
			get
			{
				short num = (short)1258225664;
				short num2 = num;
				num = (short)1578958849;
				if (num != 0)
				{
				}
				num = (short)1860928000;
				short num3 = num;
				num = (short)1305051648;
				switch (num3 == num)
				{
				}
				num = (short)1791033344;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Value;
			}
			set
			{
				short num = (short)1406074880;
				short num2 = num;
				num = (short)996856255;
				short num3 = num;
				num = (short)2011419071;
				switch (num3 == num)
				{
				}
				num = (short)595132416;
				if (num != 0)
				{
				}
				num = (short)1325203457;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Value = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x000DB0F8 File Offset: 0x000D92F8
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x000DB1AC File Offset: 0x000D93AC
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_Applicable
		{
			get
			{
				short num = (short)1604976640;
				short num2 = num;
				num = (short)1317804175;
				short num3 = num;
				num = (short)989599887;
				switch (num3 == num)
				{
				}
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)1263992832;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Applicable;
			}
			set
			{
				short num = (short)921042944;
				short num2 = num;
				num = (short)599316908;
				short num3 = num;
				num = (short)728684972;
				switch (num3 == num)
				{
				}
				num = (short)277282816;
				if (num != 0)
				{
				}
				num = (short)684916737;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Applicable = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000DB264 File Offset: 0x000D9464
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000DB31C File Offset: 0x000D951C
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_Valid
		{
			get
			{
				short num = (short)1830944768;
				short num2 = num;
				num = (short)1943127362;
				short num3 = num;
				num = (short)1272956226;
				switch (num3 == num)
				{
				}
				num = (short)762904577;
				if (num != 0)
				{
				}
				num = (short)1560281088;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Valid;
			}
			set
			{
				short num = (short)205193216;
				short num2 = num;
				num = (short)1133178275;
				short num3 = num;
				num = (short)497872291;
				switch (num3 == num)
				{
				}
				num = (short)249888769;
				if (num != 0)
				{
				}
				num = (short)489619456;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Valid = value;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000DB3D4 File Offset: 0x000D95D4
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x000DB488 File Offset: 0x000D9688
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_Visible
		{
			get
			{
				short num = (short)1490092032;
				short num2 = num;
				num = (short)2139134009;
				short num3 = num;
				num = (short)1449564217;
				switch (num3 == num)
				{
				}
				num = (short)1717960705;
				if (num != 0)
				{
				}
				num = (short)252182528;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Visible;
			}
			set
			{
				short num = (short)2145910784;
				short num2 = num;
				num = (short)1389354725;
				short num3 = num;
				num = (short)1909710565;
				switch (num3 == num)
				{
				}
				num = (short)1637023745;
				if (num != 0)
				{
				}
				num = (short)744423424;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Visible = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000DB540 File Offset: 0x000D9740
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x000DB5F4 File Offset: 0x000D97F4
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_Editable
		{
			get
			{
				short num = (short)758814817;
				short num2 = num;
				num = (short)832084065;
				switch (num2 == num)
				{
				}
				num = (short)1823866881;
				if (num != 0)
				{
				}
				num = (short)160497664;
				short num3 = num;
				num = (short)537001984;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Editable;
			}
			set
			{
				short num = (short)1010912585;
				short num2 = num;
				num = (short)1910132041;
				switch (num2 == num)
				{
				}
				num = (short)888012801;
				if (num != 0)
				{
				}
				num = (short)448266240;
				short num3 = num;
				num = (short)597819392;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.Editable = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x000DB6AC File Offset: 0x000D98AC
		internal string TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_UILabel
		{
			get
			{
				short num = (short)1025840116;
				short num2 = num;
				num = (short)1532302324;
				switch (num2 == num)
				{
				}
				num = (short)1361641472;
				if (num != 0)
				{
				}
				num = (short)823525376;
				short num3 = num;
				num = (short)1877606401;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.UIName;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000DB760 File Offset: 0x000D9960
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000DB818 File Offset: 0x000D9A18
		internal bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_HiddenStatic
		{
			get
			{
				short num = (short)1993236762;
				short num2 = num;
				num = (short)613835034;
				switch (num2 == num)
				{
				}
				num = (short)2079064064;
				if (num != 0)
				{
				}
				num = (short)360513536;
				short num3 = num;
				num = (short)1054408705;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.HiddenStatic;
			}
			set
			{
				short num = (short)1816778235;
				short num2 = num;
				num = (short)1253103099;
				switch (num2 == num)
				{
				}
				num = (short)1640431617;
				if (num != 0)
				{
				}
				num = (short)2137456640;
				short num3 = num;
				num = (short)973144064;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.HiddenStatic = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000DB8D0 File Offset: 0x000D9AD0
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x000DB984 File Offset: 0x000D9B84
		internal bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_HiddenDynamic
		{
			get
			{
				short num = (short)1224671233;
				if (num != 0)
				{
				}
				num = (short)166273845;
				short num2 = num;
				num = (short)1223762741;
				switch (num2 == num)
				{
				}
				num = (short)2125463552;
				short num3 = num;
				num = (short)1039532032;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.HiddenDynamic;
			}
			set
			{
				short num = (short)1160904705;
				if (num != 0)
				{
				}
				num = (short)1563488675;
				short num2 = num;
				num = (short)363590051;
				switch (num2 == num)
				{
				}
				num = (short)244449280;
				short num3 = num;
				num = (short)352714752;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932.HiddenDynamic = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000DBA3C File Offset: 0x000D9C3C
		public bool TrkSysFeaturesEmergencyAlarmRxIndicator_A7932_HasDiffs
		{
			get
			{
				short num = (short)1789473963;
				short num2 = num;
				num = (short)874656939;
				switch (num2 == num)
				{
				}
				num = (short)715128833;
				if (num != 0)
				{
				}
				num = (short)1191378944;
				short num3 = num;
				num = (short)52428800;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEmergencyAlarmRxIndicator_A7932._HasDiffs;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x000DBAEC File Offset: 0x000D9CEC
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x000DBBA0 File Offset: 0x000D9DA0
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969Value
		{
			get
			{
				short num = (short)980288447;
				short num2 = num;
				num = (short)1929315263;
				switch (num2 == num)
				{
				}
				num = (short)1687420929;
				if (num != 0)
				{
				}
				num = (short)599719936;
				short num3 = num;
				num = (short)417529856;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Value;
			}
			set
			{
				short num = (short)1776395372;
				short num2 = num;
				num = (short)1183884396;
				switch (num2 == num)
				{
				}
				num = (short)143196161;
				if (num != 0)
				{
				}
				num = (short)1836515328;
				short num3 = num;
				num = (short)1166278656;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Value = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x000DBC54 File Offset: 0x000D9E54
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesDynamicRegroupingEnable_A7969
		{
			get
			{
				short num = (short)316276737;
				if (num != 0)
				{
				}
				num = (short)1943346966;
				short num2 = num;
				num = (short)186392342;
				switch (num2 == num)
				{
				}
				num = (short)242352128;
				short num3 = num;
				num = (short)287965184;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000DBD04 File Offset: 0x000D9F04
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000DBDBC File Offset: 0x000D9FBC
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_UIValue
		{
			get
			{
				short num = (short)2044508517;
				short num2 = num;
				num = (short)850704741;
				switch (num2 == num)
				{
				}
				num = (short)1120600065;
				if (num != 0)
				{
				}
				num = (short)1987510272;
				short num3 = num;
				num = (short)1785724928;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Value;
			}
			set
			{
				short num = (short)912044164;
				short num2 = num;
				num = (short)1394847876;
				switch (num2 == num)
				{
				}
				num = (short)187039745;
				if (num != 0)
				{
				}
				num = (short)906756096;
				short num3 = num;
				num = (short)1099628544;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Value = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000DBE70 File Offset: 0x000DA070
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x000DBF24 File Offset: 0x000DA124
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_Applicable
		{
			get
			{
				short num = (short)342443798;
				short num2 = num;
				num = (short)1015564054;
				switch (num2 == num)
				{
				}
				num = (short)1446117377;
				if (num != 0)
				{
				}
				num = (short)2008285184;
				short num3 = num;
				num = (short)894304256;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Applicable;
			}
			set
			{
				short num = (short)1040137136;
				short num2 = num;
				num = (short)1763392432;
				switch (num2 == num)
				{
				}
				num = (short)256966656;
				if (num != 0)
				{
				}
				num = (short)2135490560;
				short num3 = num;
				num = (short)904921089;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Applicable = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000DBFD8 File Offset: 0x000DA1D8
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x000DC08C File Offset: 0x000DA28C
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_Valid
		{
			get
			{
				short num = (short)2021526471;
				short num2 = num;
				num = (short)1538853831;
				switch (num2 == num)
				{
				}
				num = (short)1718550529;
				if (num != 0)
				{
				}
				num = (short)1787756544;
				short num3 = num;
				num = (short)1466695680;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Valid;
			}
			set
			{
				short num = (short)373500242;
				short num2 = num;
				num = (short)263727442;
				switch (num2 == num)
				{
				}
				num = (short)103153665;
				if (num != 0)
				{
				}
				num = (short)487849984;
				short num3 = num;
				num = (short)1180237824;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Valid = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000DC144 File Offset: 0x000DA344
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x000DC1F8 File Offset: 0x000DA3F8
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_Visible
		{
			get
			{
				short num = (short)1429012481;
				if (num != 0)
				{
				}
				num = (short)1762098631;
				short num2 = num;
				num = (short)175996359;
				switch (num2 == num)
				{
				}
				num = (short)974258176;
				short num3 = num;
				num = (short)794951680;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Visible;
			}
			set
			{
				short num = (short)1879520955;
				short num2 = num;
				num = (short)1719088827;
				switch (num2 == num)
				{
				}
				num = (short)2091646977;
				if (num != 0)
				{
				}
				num = (short)917307392;
				short num3 = num;
				num = (short)530776064;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Visible = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000DC2AC File Offset: 0x000DA4AC
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000DC360 File Offset: 0x000DA560
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_Editable
		{
			get
			{
				short num = (short)2017856087;
				short num2 = num;
				num = (short)56691287;
				switch (num2 == num)
				{
				}
				num = (short)1811808257;
				if (num != 0)
				{
				}
				num = (short)675545088;
				short num3 = num;
				num = (short)580124672;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.Editable;
			}
			set
			{
				short num = (short)499149429;
				short num2 = num;
				num = (short)1061448309;
				switch (num2 == num)
				{
				}
				num = (short)703660032;
				if (num != 0)
				{
				}
				num = (short)1056571392;
				short num3 = num;
				num = (short)137494529;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.Editable = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000DC418 File Offset: 0x000DA618
		internal string TrkSysFeaturesDynamicRegroupingEnable_A7969_UILabel
		{
			get
			{
				short num = (short)1212728535;
				short num2 = num;
				num = (short)499041495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1819213824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122711040;
				if (num != 0)
				{
				}
				num = (short)1480982529;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.UIName;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x000DC4CC File Offset: 0x000DA6CC
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x000DC580 File Offset: 0x000DA780
		internal bool TrkSysFeaturesDynamicRegroupingEnable_A7969_HiddenStatic
		{
			get
			{
				short num = (short)1172489865;
				short num2 = num;
				num = (short)700368521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714211328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334823425;
				if (num != 0)
				{
				}
				num = (short)123142144;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.HiddenStatic;
			}
			set
			{
				short num = (short)1345137251;
				short num2 = num;
				num = (short)646195811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1054408704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811742721;
				if (num != 0)
				{
				}
				num = (short)1305870336;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.HiddenStatic = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x000DC638 File Offset: 0x000DA838
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x000DC6EC File Offset: 0x000DA8EC
		internal bool TrkSysFeaturesDynamicRegroupingEnable_A7969_HiddenDynamic
		{
			get
			{
				short num = (short)443154433;
				if (num != 0)
				{
				}
				num = (short)391053312;
				short num2 = num;
				num = (short)913306050;
				short num3 = num;
				num = (short)1278407106;
				switch (num3 == num)
				{
				}
				num = (short)1702887424;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969.HiddenDynamic;
			}
			set
			{
				short num = (short)683016193;
				if (num != 0)
				{
				}
				num = (short)570359808;
				short num2 = num;
				num = (short)647614451;
				short num3 = num;
				num = (short)849661939;
				switch (num3 == num)
				{
				}
				num = (short)621543424;
				if (num != 0)
				{
				}
				this.trkSysFeaturesDynamicRegroupingEnable_A7969.HiddenDynamic = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x000DC7A4 File Offset: 0x000DA9A4
		public bool TrkSysFeaturesDynamicRegroupingEnable_A7969_HasDiffs
		{
			get
			{
				short num = (short)852070856;
				short num2 = num;
				num = (short)1256624584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411317760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396244481;
				if (num != 0)
				{
				}
				num = (short)723058688;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesDynamicRegroupingEnable_A7969._HasDiffs;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000DC858 File Offset: 0x000DAA58
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x000DC90C File Offset: 0x000DAB0C
		public int TrkSysFeaturesICUAReset_A8249Value
		{
			get
			{
				short num = (short)556959571;
				short num2 = num;
				num = (short)473990995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452277760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526974977;
				if (num != 0)
				{
				}
				num = (short)1604976640;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.Value;
			}
			set
			{
				short num = (short)1328823454;
				short num2 = num;
				num = (short)1007565982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)576913408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557331969;
				if (num != 0)
				{
				}
				num = (short)1176567808;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.Value = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000DC9C0 File Offset: 0x000DABC0
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x000DCA74 File Offset: 0x000DAC74
		public string TrkSysFeaturesICUAReset_A8249_UIValue
		{
			get
			{
				short num = (short)1914634241;
				if (num != 0)
				{
				}
				num = (short)753991680;
				short num2 = num;
				num = (short)1124224391;
				short num3 = num;
				num = (short)1451249031;
				switch (num3 == num)
				{
				}
				num = (short)894238720;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.UIValue;
			}
			set
			{
				short num = (short)243340204;
				short num2 = num;
				num = (short)1704399788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364183552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477509121;
				if (num != 0)
				{
				}
				num = (short)1305018368;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.UIValue = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000DCB2C File Offset: 0x000DAD2C
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesICUAReset_A8249
		{
			get
			{
				short num = (short)1445920769;
				if (num != 0)
				{
				}
				num = (short)1258356736;
				short num2 = num;
				num = (short)53336084;
				short num3 = num;
				num = (short)1815992340;
				switch (num3 == num)
				{
				}
				num = (short)837484544;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000DCBDC File Offset: 0x000DADDC
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x000DCC90 File Offset: 0x000DAE90
		public bool TrkSysFeaturesICUAReset_A8249_Applicable
		{
			get
			{
				short num = (short)1846953019;
				short num2 = num;
				num = (short)1151616059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276444672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675427840;
				if (num != 0)
				{
				}
				num = (short)1621884929;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.Applicable;
			}
			set
			{
				short num = (short)1247887024;
				short num2 = num;
				num = (short)1220165296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926168576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107806721;
				if (num != 0)
				{
				}
				num = (short)118620160;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.Applicable = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000DCD48 File Offset: 0x000DAF48
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000DCDFC File Offset: 0x000DAFFC
		public bool TrkSysFeaturesICUAReset_A8249_Valid
		{
			get
			{
				short num = (short)1589663469;
				short num2 = num;
				num = (short)1626494701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288765440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488177664;
				if (num != 0)
				{
				}
				num = (short)907280385;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.Valid;
			}
			set
			{
				short num = (short)416175014;
				short num2 = num;
				num = (short)1038111654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194314240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1088815105;
				if (num != 0)
				{
				}
				num = (short)1226899456;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.Valid = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000DCEB4 File Offset: 0x000DB0B4
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000DCF68 File Offset: 0x000DB168
		public bool TrkSysFeaturesICUAReset_A8249_Visible
		{
			get
			{
				short num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)1387134976;
				short num2 = num;
				num = (short)1330435047;
				short num3 = num;
				num = (short)269669351;
				switch (num3 == num)
				{
				}
				num = (short)994574336;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.Visible;
			}
			set
			{
				short num = (short)1585184769;
				if (num != 0)
				{
				}
				num = (short)2044592128;
				short num2 = num;
				num = (short)990316563;
				short num3 = num;
				num = (short)1012336659;
				switch (num3 == num)
				{
				}
				num = (short)411172864;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.Visible = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000DD020 File Offset: 0x000DB220
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000DD0D4 File Offset: 0x000DB2D4
		public bool TrkSysFeaturesICUAReset_A8249_Editable
		{
			get
			{
				short num = (short)774766593;
				if (num != 0)
				{
				}
				num = (short)982319104;
				short num2 = num;
				num = (short)1173345863;
				short num3 = num;
				num = (short)49075783;
				switch (num3 == num)
				{
				}
				num = (short)1172570112;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.Editable;
			}
			set
			{
				short num = (short)1359151105;
				if (num != 0)
				{
				}
				num = (short)1270153216;
				short num2 = num;
				num = (short)802221717;
				short num3 = num;
				num = (short)1833889429;
				switch (num3 == num)
				{
				}
				num = (short)1101660160;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.Editable = value;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x000DD188 File Offset: 0x000DB388
		internal string TrkSysFeaturesICUAReset_A8249_UILabel
		{
			get
			{
				short num = (short)590032563;
				short num2 = num;
				num = (short)1175465651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)200671232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469762048;
				if (num != 0)
				{
				}
				num = (short)94044161;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.UIName;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000DD23C File Offset: 0x000DB43C
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x000DD2F0 File Offset: 0x000DB4F0
		internal bool TrkSysFeaturesICUAReset_A8249_HiddenStatic
		{
			get
			{
				short num = (short)893395615;
				short num2 = num;
				num = (short)1747591839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515571712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1737490432;
				if (num != 0)
				{
				}
				num = (short)1707474945;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.HiddenStatic;
			}
			set
			{
				short num = (short)1728970753;
				if (num != 0)
				{
				}
				num = (short)1090125824;
				short num2 = num;
				num = (short)1853833367;
				short num3 = num;
				num = (short)571752599;
				switch (num3 == num)
				{
				}
				num = (short)2107703296;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.HiddenStatic = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000DD3A8 File Offset: 0x000DB5A8
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x000DD45C File Offset: 0x000DB65C
		internal bool TrkSysFeaturesICUAReset_A8249_HiddenDynamic
		{
			get
			{
				short num = (short)1480104038;
				short num2 = num;
				num = (short)509450342;
				switch (num2 == num)
				{
				}
				num = (short)936968192;
				short num3 = num;
				num = (short)519045120;
				if (num != 0)
				{
				}
				num = (short)707395585;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249.HiddenDynamic;
			}
			set
			{
				short num = (short)93807548;
				short num2 = num;
				num = (short)1109615548;
				switch (num2 == num)
				{
				}
				num = (short)1388249088;
				short num3 = num;
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)182059008;
				if (num != 0)
				{
				}
				this.trkSysFeaturesICUAReset_A8249.HiddenDynamic = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000DD510 File Offset: 0x000DB710
		public bool TrkSysFeaturesICUAReset_A8249_HasDiffs
		{
			get
			{
				short num = (short)8481860;
				short num2 = num;
				num = (short)1190816836;
				switch (num2 == num)
				{
				}
				num = (short)2134376448;
				short num3 = num;
				num = (short)1709572097;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesICUAReset_A8249._HasDiffs;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000DD5C8 File Offset: 0x000DB7C8
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000DD67C File Offset: 0x000DB87C
		public bool TrkSysLabtoolEnable_A8669Value
		{
			get
			{
				short num = (short)642075796;
				short num2 = num;
				num = (short)501238932;
				switch (num2 == num)
				{
				}
				num = (short)964624384;
				short num3 = num;
				num = (short)393019392;
				if (num != 0)
				{
				}
				num = (short)1541079041;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Value;
			}
			set
			{
				short num = (short)442645226;
				short num2 = num;
				num = (short)1005861610;
				switch (num2 == num)
				{
				}
				num = (short)1752039424;
				short num3 = num;
				num = (short)943718401;
				if (num != 0)
				{
				}
				num = (short)119668736;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Value = value;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000DD730 File Offset: 0x000DB930
		public global::AcpBusinessLayer.AcpField<bool> TrkSysLabtoolEnable_A8669
		{
			get
			{
				short num = (short)1275368975;
				short num2 = num;
				num = (short)1621530127;
				switch (num2 == num)
				{
				}
				num = (short)1044512768;
				short num3 = num;
				num = (short)1617559552;
				if (num != 0)
				{
				}
				num = (short)897449985;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000DD7E0 File Offset: 0x000DB9E0
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000DD898 File Offset: 0x000DBA98
		public bool TrkSysLabtoolEnable_A8669_UIValue
		{
			get
			{
				short num = (short)1924861127;
				short num2 = num;
				num = (short)1966279879;
				switch (num2 == num)
				{
				}
				num = (short)2057568256;
				short num3 = num;
				num = (short)1255669761;
				if (num != 0)
				{
				}
				num = (short)1280245760;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Value;
			}
			set
			{
				short num = (short)637382745;
				short num2 = num;
				num = (short)1954852953;
				switch (num2 == num)
				{
				}
				num = (short)334626816;
				short num3 = num;
				num = (short)1445199873;
				if (num != 0)
				{
				}
				num = (short)907673600;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Value = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000DD950 File Offset: 0x000DBB50
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000DDA04 File Offset: 0x000DBC04
		public bool TrkSysLabtoolEnable_A8669_Applicable
		{
			get
			{
				short num = (short)1209550715;
				short num2 = num;
				num = (short)115689339;
				switch (num2 == num)
				{
				}
				num = (short)590348288;
				short num3 = num;
				num = (short)258080769;
				if (num != 0)
				{
				}
				num = (short)1397751808;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Applicable;
			}
			set
			{
				short num = (short)1233846273;
				if (num != 0)
				{
				}
				num = (short)1185658599;
				short num2 = num;
				num = (short)642889447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774845952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1360658432;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Applicable = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000DDAB8 File Offset: 0x000DBCB8
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x000DDB6C File Offset: 0x000DBD6C
		public bool TrkSysLabtoolEnable_A8669_Valid
		{
			get
			{
				short num = (short)715689442;
				short num2 = num;
				num = (short)373394914;
				switch (num2 == num)
				{
				}
				num = (short)559415296;
				short num3 = num;
				num = (short)1437204480;
				if (num != 0)
				{
				}
				num = (short)6422529;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Valid;
			}
			set
			{
				short num = (short)189166703;
				short num2 = num;
				num = (short)2108388463;
				switch (num2 == num)
				{
				}
				num = (short)1865220096;
				short num3 = num;
				num = (short)518455297;
				if (num != 0)
				{
				}
				num = (short)43057152;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Valid = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000DDC20 File Offset: 0x000DBE20
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x000DDCD4 File Offset: 0x000DBED4
		public bool TrkSysLabtoolEnable_A8669_Visible
		{
			get
			{
				short num = (short)1666765705;
				short num2 = num;
				num = (short)243389321;
				switch (num2 == num)
				{
				}
				num = (short)1011679232;
				short num3 = num;
				num = (short)349306881;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Visible;
			}
			set
			{
				short num = (short)631277248;
				short num2 = num;
				num = (short)702449344;
				switch (num2 == num)
				{
				}
				num = (short)1859780608;
				short num3 = num;
				num = (short)1295319040;
				if (num != 0)
				{
				}
				num = (short)2109079553;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Visible = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000DDD88 File Offset: 0x000DBF88
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000DDE40 File Offset: 0x000DC040
		public bool TrkSysLabtoolEnable_A8669_Editable
		{
			get
			{
				short num = (short)659876241;
				short num2 = num;
				num = (short)144959889;
				switch (num2 == num)
				{
				}
				num = (short)2047868928;
				short num3 = num;
				num = (short)306708481;
				if (num != 0)
				{
				}
				num = (short)1180631040;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.Editable;
			}
			set
			{
				short num = (short)910258007;
				short num2 = num;
				num = (short)488468311;
				switch (num2 == num)
				{
				}
				num = (short)1039073280;
				short num3 = num;
				num = (short)1968439296;
				if (num != 0)
				{
				}
				num = (short)432734209;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.Editable = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000DDEF4 File Offset: 0x000DC0F4
		internal string TrkSysLabtoolEnable_A8669_UILabel
		{
			get
			{
				short num = (short)443024904;
				short num2 = num;
				num = (short)1970537992;
				switch (num2 == num)
				{
				}
				num = (short)932839424;
				short num3 = num;
				num = (short)2140798977;
				if (num != 0)
				{
				}
				num = (short)1467875328;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.UIName;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000DDFA4 File Offset: 0x000DC1A4
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000DE058 File Offset: 0x000DC258
		internal bool TrkSysLabtoolEnable_A8669_HiddenStatic
		{
			get
			{
				short num = (short)2138280301;
				short num2 = num;
				num = (short)1982894445;
				switch (num2 == num)
				{
				}
				num = (short)1777401856;
				short num3 = num;
				num = (short)1640300545;
				if (num != 0)
				{
				}
				num = (short)1859059712;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.HiddenStatic;
			}
			set
			{
				short num = (short)1184787023;
				short num2 = num;
				num = (short)492268111;
				switch (num2 == num)
				{
				}
				num = (short)1065484288;
				short num3 = num;
				num = (short)1460273152;
				if (num != 0)
				{
				}
				num = (short)1115815937;
				if (num != 0)
				{
				}
				this.trkSysLabtoolEnable_A8669.HiddenStatic = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000DE10C File Offset: 0x000DC30C
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x000DE1C0 File Offset: 0x000DC3C0
		internal bool TrkSysLabtoolEnable_A8669_HiddenDynamic
		{
			get
			{
				short num = (short)978057229;
				short num2 = num;
				num = (short)193132557;
				switch (num2 == num)
				{
				}
				num = (short)1148190720;
				short num3 = num;
				num = (short)1171783681;
				if (num != 0)
				{
				}
				num = (short)1497432064;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolEnable_A8669.HiddenDynamic;
			}
			set
			{
				short num = (short)1159378488;
				short num2 = num;
				num = (short)1222620728;
				switch (num2 == num)
				{
				}
				num = (short)1371602945;
				if (num != 0)
				{
				}
				num = (short)1517617152;
				if (num != 0)
				{
				}
				num = (short)963313664;
				short num3 = num;
				this.trkSysLabtoolEnable_A8669.HiddenDynamic = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000DE274 File Offset: 0x000DC474
		public bool TrkSysLabtoolEnable_A8669_HasDiffs
		{
			get
			{
				short num = (short)269914303;
				short num2 = num;
				num = (short)1958383807;
				switch (num2 == num)
				{
				}
				num = (short)1636499457;
				if (num != 0)
				{
				}
				num = (short)659292160;
				if (num != 0)
				{
				}
				num = (short)1514274816;
				short num3 = num;
				return this.trkSysLabtoolEnable_A8669._HasDiffs;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x000DE328 File Offset: 0x000DC528
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000DE3DC File Offset: 0x000DC5DC
		public bool TrkSysFeaturesRadioInhibit_A8833Value
		{
			get
			{
				short num = (short)52822017;
				if (num != 0)
				{
				}
				num = (short)210978562;
				short num2 = num;
				num = (short)1840924418;
				switch (num2 == num)
				{
				}
				num = (short)1620705280;
				if (num != 0)
				{
				}
				num = (short)736100352;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Value;
			}
			set
			{
				short num = (short)988312873;
				short num2 = num;
				num = (short)786396457;
				switch (num2 == num)
				{
				}
				num = (short)1422065664;
				if (num != 0)
				{
				}
				num = (short)393217;
				if (num != 0)
				{
				}
				num = (short)1373765632;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Value = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000DE490 File Offset: 0x000DC690
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesRadioInhibit_A8833
		{
			get
			{
				short num = (short)137428993;
				if (num != 0)
				{
				}
				num = (short)38105555;
				short num2 = num;
				num = (short)1708028371;
				switch (num2 == num)
				{
				}
				num = (short)1077673984;
				if (num != 0)
				{
				}
				num = (short)413270016;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000DE540 File Offset: 0x000DC740
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000DE5F4 File Offset: 0x000DC7F4
		public bool TrkSysFeaturesRadioInhibit_A8833_UIValue
		{
			get
			{
				short num = (short)324399144;
				short num2 = num;
				num = (short)437055528;
				switch (num2 == num)
				{
				}
				num = (short)948043777;
				if (num != 0)
				{
				}
				num = (short)1144979456;
				if (num != 0)
				{
				}
				num = (short)1617821696;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Value;
			}
			set
			{
				short num = (short)1149233161;
				short num2 = num;
				num = (short)1001449481;
				switch (num2 == num)
				{
				}
				num = (short)1172307969;
				if (num != 0)
				{
				}
				num = (short)835452928;
				if (num != 0)
				{
				}
				num = (short)479330304;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Value = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x000DE6A8 File Offset: 0x000DC8A8
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x000DE75C File Offset: 0x000DC95C
		public bool TrkSysFeaturesRadioInhibit_A8833_Applicable
		{
			get
			{
				short num = (short)361052128;
				short num2 = num;
				num = (short)1290024928;
				switch (num2 == num)
				{
				}
				num = (short)1419902977;
				if (num != 0)
				{
				}
				num = (short)1024196608;
				if (num != 0)
				{
				}
				num = (short)1190133760;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Applicable;
			}
			set
			{
				short num = (short)544940351;
				short num2 = num;
				num = (short)1115169087;
				switch (num2 == num)
				{
				}
				num = (short)1721434113;
				if (num != 0)
				{
				}
				num = (short)1461256192;
				if (num != 0)
				{
				}
				num = (short)15532032;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Applicable = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x000DE810 File Offset: 0x000DCA10
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x000DE8C0 File Offset: 0x000DCAC0
		public bool TrkSysFeaturesRadioInhibit_A8833_Valid
		{
			get
			{
				short num = (short)81920001;
				if (num != 0)
				{
				}
				num = (short)1780197248;
				short num2 = num;
				num = (short)1340909440;
				switch (num2 == num)
				{
				}
				num = (short)2067857408;
				if (num != 0)
				{
				}
				num = (short)359071744;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Valid;
			}
			set
			{
				short num = (short)972900389;
				short num2 = num;
				num = (short)838617125;
				switch (num2 == num)
				{
				}
				num = (short)1356660737;
				if (num != 0)
				{
				}
				num = (short)1884160000;
				if (num != 0)
				{
				}
				num = (short)1925840896;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Valid = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000DE978 File Offset: 0x000DCB78
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000DEA30 File Offset: 0x000DCC30
		public bool TrkSysFeaturesRadioInhibit_A8833_Visible
		{
			get
			{
				short num = (short)1053023139;
				short num2 = num;
				num = (short)551410595;
				switch (num2 == num)
				{
				}
				num = (short)1295515648;
				if (num != 0)
				{
				}
				num = (short)2088042497;
				if (num != 0)
				{
				}
				num = (short)312147968;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Visible;
			}
			set
			{
				short num = (short)1658669014;
				short num2 = num;
				num = (short)559761366;
				switch (num2 == num)
				{
				}
				num = (short)717750272;
				if (num != 0)
				{
				}
				num = (short)1270874113;
				if (num != 0)
				{
				}
				num = (short)1318977536;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Visible = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000DEAEC File Offset: 0x000DCCEC
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000DEBA0 File Offset: 0x000DCDA0
		public bool TrkSysFeaturesRadioInhibit_A8833_Editable
		{
			get
			{
				short num = (short)1934984255;
				short num2 = num;
				num = (short)109872191;
				switch (num2 == num)
				{
				}
				num = (short)1433600001;
				if (num != 0)
				{
				}
				num = (short)764936192;
				if (num != 0)
				{
				}
				num = (short)863764480;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.Editable;
			}
			set
			{
				short num = (short)1394290210;
				short num2 = num;
				num = (short)1523133986;
				switch (num2 == num)
				{
				}
				num = (short)200409089;
				if (num != 0)
				{
				}
				num = (short)645791744;
				if (num != 0)
				{
				}
				num = (short)176029696;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.Editable = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000DEC58 File Offset: 0x000DCE58
		internal string TrkSysFeaturesRadioInhibit_A8833_UILabel
		{
			get
			{
				short num = (short)196331174;
				short num2 = num;
				num = (short)636405414;
				switch (num2 == num)
				{
				}
				num = (short)1494089728;
				if (num != 0)
				{
				}
				num = (short)773586945;
				if (num != 0)
				{
				}
				num = (short)1441792000;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.UIName;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x000DED0C File Offset: 0x000DCF0C
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000DEDC4 File Offset: 0x000DCFC4
		internal bool TrkSysFeaturesRadioInhibit_A8833_HiddenStatic
		{
			get
			{
				short num = (short)1032226174;
				short num2 = num;
				num = (short)1298367870;
				switch (num2 == num)
				{
				}
				num = (short)1651965953;
				if (num != 0)
				{
				}
				num = (short)1302593536;
				if (num != 0)
				{
				}
				num = (short)95879168;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.HiddenStatic;
			}
			set
			{
				short num = (short)1076986718;
				short num2 = num;
				num = (short)226591582;
				switch (num2 == num)
				{
				}
				num = (short)1731002369;
				if (num != 0)
				{
				}
				num = (short)1218904064;
				if (num != 0)
				{
				}
				num = (short)545849344;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.HiddenStatic = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000DEE7C File Offset: 0x000DD07C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x000DEF2C File Offset: 0x000DD12C
		internal bool TrkSysFeaturesRadioInhibit_A8833_HiddenDynamic
		{
			get
			{
				short num = (short)752943105;
				if (num != 0)
				{
				}
				num = (short)1272338142;
				short num2 = num;
				num = (short)1978357470;
				switch (num2 == num)
				{
				}
				num = (short)219545600;
				if (num != 0)
				{
				}
				num = (short)862715904;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833.HiddenDynamic;
			}
			set
			{
				short num = (short)1120465220;
				short num2 = num;
				num = (short)615051588;
				switch (num2 == num)
				{
				}
				num = (short)1843986433;
				if (num != 0)
				{
				}
				num = (short)281739264;
				if (num != 0)
				{
				}
				num = (short)344064000;
				short num3 = num;
				this.trkSysFeaturesRadioInhibit_A8833.HiddenDynamic = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x000DEFE0 File Offset: 0x000DD1E0
		public bool TrkSysFeaturesRadioInhibit_A8833_HasDiffs
		{
			get
			{
				short num = (short)1044525014;
				short num2 = num;
				num = (short)2063806422;
				switch (num2 == num)
				{
				}
				num = (short)691339265;
				if (num != 0)
				{
				}
				num = (short)1190723584;
				if (num != 0)
				{
				}
				num = (short)241827840;
				short num3 = num;
				return this.trkSysFeaturesRadioInhibit_A8833._HasDiffs;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000DF098 File Offset: 0x000DD298
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x000DF14C File Offset: 0x000DD34C
		public bool TrkSysFeaturesSecureLED_A9071Value
		{
			get
			{
				short num = (short)1209376045;
				short num2 = num;
				num = (short)43752749;
				switch (num2 == num)
				{
				}
				num = (short)490209281;
				if (num != 0)
				{
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				num = (short)1509621760;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Value;
			}
			set
			{
				short num = (short)286444593;
				short num2 = num;
				num = (short)530435121;
				switch (num2 == num)
				{
				}
				num = (short)398327808;
				if (num != 0)
				{
				}
				num = (short)1367736321;
				if (num != 0)
				{
				}
				num = (short)1644888064;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Value = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000DF204 File Offset: 0x000DD404
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesSecureLED_A9071
		{
			get
			{
				short num = (short)1441398785;
				if (num != 0)
				{
				}
				num = (short)1430004012;
				short num2 = num;
				num = (short)1455235372;
				switch (num2 == num)
				{
				}
				num = (short)1180499968;
				if (num != 0)
				{
				}
				num = (short)60686336;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000DF2B4 File Offset: 0x000DD4B4
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x000DF36C File Offset: 0x000DD56C
		public bool TrkSysFeaturesSecureLED_A9071_UIValue
		{
			get
			{
				short num = (short)1310439001;
				short num2 = num;
				num = (short)633976409;
				switch (num2 == num)
				{
				}
				num = (short)366804992;
				if (num != 0)
				{
				}
				num = (short)385155073;
				if (num != 0)
				{
				}
				num = (short)534183936;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Value;
			}
			set
			{
				short num = (short)1668336192;
				short num2 = num;
				num = (short)1161087552;
				switch (num2 == num)
				{
				}
				num = (short)1900544001;
				if (num != 0)
				{
				}
				num = (short)369098752;
				if (num != 0)
				{
				}
				num = (short)994836480;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Value = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000DF424 File Offset: 0x000DD624
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000DF4D8 File Offset: 0x000DD6D8
		public bool TrkSysFeaturesSecureLED_A9071_Applicable
		{
			get
			{
				short num = (short)1154515811;
				short num2 = num;
				num = (short)62292835;
				switch (num2 == num)
				{
				}
				num = (short)1157890049;
				if (num != 0)
				{
				}
				num = (short)209125376;
				if (num != 0)
				{
				}
				num = (short)2003894272;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Applicable;
			}
			set
			{
				short num = (short)873385190;
				short num2 = num;
				num = (short)192204006;
				switch (num2 == num)
				{
				}
				num = (short)1570242560;
				if (num != 0)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				num = (short)1383137280;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Applicable = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x000DF590 File Offset: 0x000DD790
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x000DF644 File Offset: 0x000DD844
		public bool TrkSysFeaturesSecureLED_A9071_Valid
		{
			get
			{
				short num = (short)1264183894;
				short num2 = num;
				num = (short)1272638038;
				switch (num2 == num)
				{
				}
				num = (short)2118516737;
				if (num != 0)
				{
				}
				num = (short)1860763648;
				if (num != 0)
				{
				}
				num = (short)226951168;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Valid;
			}
			set
			{
				short num = (short)543856828;
				short num2 = num;
				num = (short)334207164;
				switch (num2 == num)
				{
				}
				num = (short)1052180481;
				if (num != 0)
				{
				}
				num = (short)1576730624;
				if (num != 0)
				{
				}
				num = (short)129171456;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Valid = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000DF6F8 File Offset: 0x000DD8F8
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x000DF7AC File Offset: 0x000DD9AC
		public bool TrkSysFeaturesSecureLED_A9071_Visible
		{
			get
			{
				short num = (short)1772408895;
				short num2 = num;
				num = (short)619237439;
				switch (num2 == num)
				{
				}
				num = (short)2022703105;
				if (num != 0)
				{
				}
				num = (short)1883832320;
				if (num != 0)
				{
				}
				num = (short)1284702208;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Visible;
			}
			set
			{
				short num = (short)1145265448;
				short num2 = num;
				num = (short)1097293096;
				switch (num2 == num)
				{
				}
				num = (short)1803747329;
				if (num != 0)
				{
				}
				num = (short)487849984;
				if (num != 0)
				{
				}
				num = (short)461373440;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Visible = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000DF860 File Offset: 0x000DDA60
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x000DF918 File Offset: 0x000DDB18
		public bool TrkSysFeaturesSecureLED_A9071_Editable
		{
			get
			{
				short num = (short)1628438529;
				if (num != 0)
				{
				}
				num = (short)1343538276;
				short num2 = num;
				num = (short)1994310756;
				switch (num2 == num)
				{
				}
				num = (short)1959133184;
				if (num != 0)
				{
				}
				num = (short)659619840;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.Editable;
			}
			set
			{
				short num = (short)1897409170;
				short num2 = num;
				num = (short)1169435282;
				switch (num2 == num)
				{
				}
				num = (short)1967849473;
				if (num != 0)
				{
				}
				num = (short)1555562496;
				if (num != 0)
				{
				}
				num = (short)1172045824;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.Editable = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
		internal string TrkSysFeaturesSecureLED_A9071_UILabel
		{
			get
			{
				short num = (short)1585089118;
				short num2 = num;
				num = (short)1958513246;
				switch (num2 == num)
				{
				}
				num = (short)1838743552;
				if (num != 0)
				{
				}
				num = (short)1199702017;
				if (num != 0)
				{
				}
				num = (short)1859452928;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.UIName;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000DFA88 File Offset: 0x000DDC88
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x000DFB3C File Offset: 0x000DDD3C
		internal bool TrkSysFeaturesSecureLED_A9071_HiddenStatic
		{
			get
			{
				short num = (short)1664026534;
				short num2 = num;
				num = (short)1748305830;
				switch (num2 == num)
				{
				}
				num = (short)127139841;
				if (num != 0)
				{
				}
				num = (short)1177157632;
				if (num != 0)
				{
				}
				num = (short)1503002624;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.HiddenStatic;
			}
			set
			{
				short num = (short)1894849722;
				short num2 = num;
				num = (short)383786170;
				switch (num2 == num)
				{
				}
				num = (short)628424705;
				if (num != 0)
				{
				}
				num = (short)417005568;
				if (num != 0)
				{
				}
				num = (short)1333264384;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.HiddenStatic = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000DFBF4 File Offset: 0x000DDDF4
		// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x000DFCA8 File Offset: 0x000DDEA8
		internal bool TrkSysFeaturesSecureLED_A9071_HiddenDynamic
		{
			get
			{
				short num = (short)1139406618;
				short num2 = num;
				num = (short)223541018;
				switch (num2 == num)
				{
				}
				num = (short)1867251713;
				if (num != 0)
				{
				}
				num = (short)1607467008;
				if (num != 0)
				{
				}
				num = (short)1152843776;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071.HiddenDynamic;
			}
			set
			{
				short num = (short)2031934144;
				short num2 = num;
				num = (short)1202838208;
				switch (num2 == num)
				{
				}
				num = (short)530513920;
				if (num != 0)
				{
				}
				num = (short)1129971713;
				if (num != 0)
				{
				}
				num = (short)75038720;
				short num3 = num;
				this.trkSysFeaturesSecureLED_A9071.HiddenDynamic = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000DFD60 File Offset: 0x000DDF60
		public bool TrkSysFeaturesSecureLED_A9071_HasDiffs
		{
			get
			{
				short num = (short)2128956097;
				short num2 = num;
				num = (short)1019562689;
				switch (num2 == num)
				{
				}
				num = (short)425918465;
				if (num != 0)
				{
				}
				num = (short)1878589440;
				if (num != 0)
				{
				}
				num = (short)43188224;
				short num3 = num;
				return this.trkSysFeaturesSecureLED_A9071._HasDiffs;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x000DFE14 File Offset: 0x000DE014
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x000DFECC File Offset: 0x000DE0CC
		public bool TrkSysFeaturesBusyLED_44911Value
		{
			get
			{
				short num = (short)1492626949;
				short num2 = num;
				num = (short)226668037;
				switch (num2 == num)
				{
				}
				num = (short)1269956609;
				if (num != 0)
				{
				}
				num = (short)1108541440;
				if (num != 0)
				{
				}
				num = (short)365953024;
				short num3 = num;
				return this.trkSysFeaturesBusyLED_44911.Value;
			}
			set
			{
				short num = (short)1871238375;
				short num2 = num;
				num = (short)229889255;
				switch (num2 == num)
				{
				}
				num = (short)1054801920;
				short num3 = num;
				num = (short)2101608448;
				if (num != 0)
				{
				}
				num = (short)1106051073;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Value = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x000DFF80 File Offset: 0x000DE180
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesBusyLED_44911
		{
			get
			{
				short num = (short)2051604481;
				if (num != 0)
				{
				}
				num = (short)104173338;
				short num2 = num;
				num = (short)53120794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707330048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672137216;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000E0030 File Offset: 0x000DE230
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000E00E4 File Offset: 0x000DE2E4
		public bool TrkSysFeaturesBusyLED_44911_UIValue
		{
			get
			{
				short num = (short)415473658;
				short num2 = num;
				num = (short)2134614010;
				switch (num2 == num)
				{
				}
				num = (short)1520500736;
				short num3 = num;
				num = (short)681967617;
				if (num != 0)
				{
				}
				num = (short)1359872000;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.Value;
			}
			set
			{
				short num = (short)1585278657;
				short num2 = num;
				num = (short)859205313;
				switch (num2 == num)
				{
				}
				num = (short)1432944640;
				short num3 = num;
				num = (short)50593793;
				if (num != 0)
				{
				}
				num = (short)381288448;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Value = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000E0198 File Offset: 0x000DE398
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000E024C File Offset: 0x000DE44C
		public bool TrkSysFeaturesBusyLED_44911_Applicable
		{
			get
			{
				short num = (short)703574590;
				short num2 = num;
				num = (short)2143466046;
				switch (num2 == num)
				{
				}
				num = (short)1619394560;
				short num3 = num;
				num = (short)1719533569;
				if (num != 0)
				{
				}
				num = (short)1105133568;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.Applicable;
			}
			set
			{
				short num = (short)1771580569;
				short num2 = num;
				num = (short)1731669145;
				switch (num2 == num)
				{
				}
				num = (short)1926627328;
				short num3 = num;
				num = (short)2145255424;
				if (num != 0)
				{
				}
				num = (short)273285121;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Applicable = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000E0304 File Offset: 0x000DE504
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000E03B8 File Offset: 0x000DE5B8
		public bool TrkSysFeaturesBusyLED_44911_Valid
		{
			get
			{
				short num = (short)30822218;
				short num2 = num;
				num = (short)1985630026;
				switch (num2 == num)
				{
				}
				num = (short)22806528;
				short num3 = num;
				num = (short)1027538944;
				if (num != 0)
				{
				}
				num = (short)1203568641;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.Valid;
			}
			set
			{
				short num = (short)863459485;
				short num2 = num;
				num = (short)58349725;
				switch (num2 == num)
				{
				}
				num = (short)730791936;
				short num3 = num;
				num = (short)286785537;
				if (num != 0)
				{
				}
				num = (short)1730347008;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Valid = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000E046C File Offset: 0x000DE66C
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000E0520 File Offset: 0x000DE720
		public bool TrkSysFeaturesBusyLED_44911_Visible
		{
			get
			{
				short num = (short)890446571;
				short num2 = num;
				num = (short)2038833899;
				switch (num2 == num)
				{
				}
				num = (short)1562836992;
				short num3 = num;
				num = (short)1376124929;
				if (num != 0)
				{
				}
				num = (short)1471938560;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.Visible;
			}
			set
			{
				short num = (short)429779416;
				short num2 = num;
				num = (short)620358104;
				switch (num2 == num)
				{
				}
				num = (short)1716125696;
				short num3 = num;
				num = (short)1388052481;
				if (num != 0)
				{
				}
				num = (short)393412608;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Visible = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x000E05D4 File Offset: 0x000DE7D4
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x000E0688 File Offset: 0x000DE888
		public bool TrkSysFeaturesBusyLED_44911_Editable
		{
			get
			{
				short num = (short)666075817;
				short num2 = num;
				num = (short)87524009;
				switch (num2 == num)
				{
				}
				num = (short)1724317696;
				short num3 = num;
				num = (short)193331201;
				if (num != 0)
				{
				}
				num = (short)1385693184;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.Editable;
			}
			set
			{
				short num = (short)1902590606;
				short num2 = num;
				num = (short)186202766;
				switch (num2 == num)
				{
				}
				num = (short)1322647552;
				short num3 = num;
				num = (short)1781202945;
				if (num != 0)
				{
				}
				num = (short)472514560;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.Editable = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000E073C File Offset: 0x000DE93C
		internal string TrkSysFeaturesBusyLED_44911_UILabel
		{
			get
			{
				short num = (short)556628234;
				short num2 = num;
				num = (short)89159946;
				switch (num2 == num)
				{
				}
				num = (short)381157376;
				short num3 = num;
				num = (short)1356726273;
				if (num != 0)
				{
				}
				num = (short)336592896;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.UIName;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000E07F0 File Offset: 0x000DE9F0
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000E08A4 File Offset: 0x000DEAA4
		internal bool TrkSysFeaturesBusyLED_44911_HiddenStatic
		{
			get
			{
				short num = (short)424331318;
				short num2 = num;
				num = (short)1843054646;
				switch (num2 == num)
				{
				}
				num = (short)1251999744;
				short num3 = num;
				num = (short)632750080;
				if (num != 0)
				{
				}
				num = (short)1718878209;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.HiddenStatic;
			}
			set
			{
				short num = (short)326637834;
				short num2 = num;
				num = (short)364583178;
				switch (num2 == num)
				{
				}
				num = (short)1016594432;
				short num3 = num;
				num = (short)1162936321;
				if (num != 0)
				{
				}
				num = (short)2126708736;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.HiddenStatic = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000E095C File Offset: 0x000DEB5C
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000E0A0C File Offset: 0x000DEC0C
		internal bool TrkSysFeaturesBusyLED_44911_HiddenDynamic
		{
			get
			{
				short num = (short)206161038;
				short num2 = num;
				num = (short)1657914510;
				switch (num2 == num)
				{
				}
				num = (short)1551958016;
				short num3 = num;
				num = (short)1143865345;
				if (num != 0)
				{
				}
				num = (short)505544704;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911.HiddenDynamic;
			}
			set
			{
				short num = (short)1132144085;
				short num2 = num;
				num = (short)307307989;
				switch (num2 == num)
				{
				}
				num = (short)1447034880;
				short num3 = num;
				num = (short)1353908224;
				if (num != 0)
				{
				}
				num = (short)1524563969;
				if (num != 0)
				{
				}
				this.trkSysFeaturesBusyLED_44911.HiddenDynamic = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000E0AC4 File Offset: 0x000DECC4
		public bool TrkSysFeaturesBusyLED_44911_HasDiffs
		{
			get
			{
				short num = (short)1371324112;
				short num2 = num;
				num = (short)1538637520;
				switch (num2 == num)
				{
				}
				num = (short)1015939072;
				short num3 = num;
				num = (short)1239547905;
				if (num != 0)
				{
				}
				num = (short)1707999232;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesBusyLED_44911._HasDiffs;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000E0B78 File Offset: 0x000DED78
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000E0C28 File Offset: 0x000DEE28
		public int TrkSysFeaturesTextMessagingService_A9373Value
		{
			get
			{
				short num = (short)1478076306;
				short num2 = num;
				num = (short)12625810;
				switch (num2 == num)
				{
				}
				num = (short)1525743616;
				short num3 = num;
				num = (short)619380737;
				if (num != 0)
				{
				}
				num = (short)648085504;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.Value;
			}
			set
			{
				short num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)854879428;
				short num2 = num;
				num = (short)206662852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854996480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053898240;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.Value = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x000E0CDC File Offset: 0x000DEEDC
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x000E0D90 File Offset: 0x000DEF90
		public string TrkSysFeaturesTextMessagingService_A9373_UIValue
		{
			get
			{
				short num = (short)1069882147;
				short num2 = num;
				num = (short)1067457315;
				switch (num2 == num)
				{
				}
				num = (short)764018688;
				short num3 = num;
				num = (short)1031012353;
				if (num != 0)
				{
				}
				num = (short)2055143424;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.UIValue;
			}
			set
			{
				short num = (short)2093567369;
				short num2 = num;
				num = (short)23940489;
				switch (num2 == num)
				{
				}
				num = (short)1648230400;
				short num3 = num;
				num = (short)2016608256;
				if (num != 0)
				{
				}
				num = (short)656736257;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.UIValue = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x000E0E48 File Offset: 0x000DF048
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesTextMessagingService_A9373
		{
			get
			{
				short num = (short)514295938;
				short num2 = num;
				num = (short)1475250306;
				switch (num2 == num)
				{
				}
				num = (short)962330624;
				short num3 = num;
				num = (short)1773600768;
				if (num != 0)
				{
				}
				num = (short)1462763521;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000E0FAC File Offset: 0x000DF1AC
		public bool TrkSysFeaturesTextMessagingService_A9373_Applicable
		{
			get
			{
				short num = (short)91608897;
				short num2 = num;
				num = (short)931387201;
				switch (num2 == num)
				{
				}
				num = (short)1780416512;
				short num3 = num;
				num = (short)1664745473;
				if (num != 0)
				{
				}
				num = (short)2001731584;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.Applicable;
			}
			set
			{
				short num = (short)1410067197;
				short num2 = num;
				num = (short)1015409405;
				switch (num2 == num)
				{
				}
				num = (short)879886336;
				short num3 = num;
				num = (short)684916737;
				if (num != 0)
				{
				}
				num = (short)1627848704;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.Applicable = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000E1060 File Offset: 0x000DF260
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000E1114 File Offset: 0x000DF314
		public bool TrkSysFeaturesTextMessagingService_A9373_Valid
		{
			get
			{
				short num = (short)1625686016;
				short num2 = num;
				num = (short)1935808319;
				short num3 = num;
				num = (short)395908927;
				switch (num3 == num)
				{
				}
				num = (short)10682368;
				if (num != 0)
				{
				}
				num = (short)502464513;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.Valid;
			}
			set
			{
				short num = (short)30343168;
				short num2 = num;
				num = (short)640621891;
				short num3 = num;
				num = (short)1377705283;
				switch (num3 == num)
				{
				}
				num = (short)872284161;
				if (num != 0)
				{
				}
				num = (short)1280311296;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.Valid = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000E11CC File Offset: 0x000DF3CC
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000E1280 File Offset: 0x000DF480
		public bool TrkSysFeaturesTextMessagingService_A9373_Visible
		{
			get
			{
				short num = (short)527433728;
				short num2 = num;
				num = (short)1501493729;
				short num3 = num;
				num = (short)364313057;
				switch (num3 == num)
				{
				}
				num = (short)1057095680;
				if (num != 0)
				{
				}
				num = (short)367984641;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.Visible;
			}
			set
			{
				short num = (short)1661272064;
				short num2 = num;
				num = (short)1871062652;
				short num3 = num;
				num = (short)304359036;
				switch (num3 == num)
				{
				}
				num = (short)1039204352;
				if (num != 0)
				{
				}
				num = (short)1264844801;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.Visible = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000E1338 File Offset: 0x000DF538
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x000E13EC File Offset: 0x000DF5EC
		public bool TrkSysFeaturesTextMessagingService_A9373_Editable
		{
			get
			{
				short num = (short)1473970176;
				short num2 = num;
				num = (short)1570023915;
				short num3 = num;
				num = (short)1427941867;
				switch (num3 == num)
				{
				}
				num = (short)1958608897;
				if (num != 0)
				{
				}
				num = (short)265748480;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.Editable;
			}
			set
			{
				short num = (short)745275392;
				short num2 = num;
				num = (short)1844940388;
				short num3 = num;
				num = (short)1109560932;
				switch (num3 == num)
				{
				}
				num = (short)431357952;
				if (num != 0)
				{
				}
				num = (short)2128347137;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.Editable = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x000E14A0 File Offset: 0x000DF6A0
		internal string TrkSysFeaturesTextMessagingService_A9373_UILabel
		{
			get
			{
				short num = (short)1203634176;
				short num2 = num;
				num = (short)436250782;
				short num3 = num;
				num = (short)1446619294;
				switch (num3 == num)
				{
				}
				num = (short)1473445889;
				if (num != 0)
				{
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.UIName;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x000E1554 File Offset: 0x000DF754
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000E1608 File Offset: 0x000DF808
		internal bool TrkSysFeaturesTextMessagingService_A9373_HiddenStatic
		{
			get
			{
				short num = (short)878313472;
				short num2 = num;
				num = (short)1648036892;
				short num3 = num;
				num = (short)1530465308;
				switch (num3 == num)
				{
				}
				num = (short)1807482880;
				if (num != 0)
				{
				}
				num = (short)2000551937;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.HiddenStatic;
			}
			set
			{
				short num = (short)1883897856;
				short num2 = num;
				num = (short)109903873;
				if (num != 0)
				{
				}
				num = (short)1732068159;
				short num3 = num;
				num = (short)2043560767;
				switch (num3 == num)
				{
				}
				num = (short)1658060800;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.HiddenStatic = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000E16C0 File Offset: 0x000DF8C0
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000E1774 File Offset: 0x000DF974
		internal bool TrkSysFeaturesTextMessagingService_A9373_HiddenDynamic
		{
			get
			{
				short num = (short)463011840;
				short num2 = num;
				num = (short)773479151;
				short num3 = num;
				num = (short)1365072623;
				switch (num3 == num)
				{
				}
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)2051342336;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373.HiddenDynamic;
			}
			set
			{
				short num = (short)2015756288;
				short num2 = num;
				num = (short)641469971;
				short num3 = num;
				num = (short)9113107;
				switch (num3 == num)
				{
				}
				num = (short)932380673;
				if (num != 0)
				{
				}
				num = (short)2000158720;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTextMessagingService_A9373.HiddenDynamic = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000E182C File Offset: 0x000DFA2C
		public bool TrkSysFeaturesTextMessagingService_A9373_HasDiffs
		{
			get
			{
				short num = (short)1838809088;
				short num2 = num;
				num = (short)1758538806;
				short num3 = num;
				num = (short)1999711286;
				switch (num3 == num)
				{
				}
				num = (short)1720123393;
				if (num != 0)
				{
				}
				num = (short)2067333120;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTextMessagingService_A9373._HasDiffs;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000E18E4 File Offset: 0x000DFAE4
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x000E1998 File Offset: 0x000DFB98
		public int TrkSysFeaturesTxBaseTimeSec_A9512Value
		{
			get
			{
				short num = (short)1335164928;
				short num2 = num;
				num = (short)281391722;
				short num3 = num;
				num = (short)324121194;
				switch (num3 == num)
				{
				}
				num = (short)634126337;
				if (num != 0)
				{
				}
				num = (short)1204420608;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.Value;
			}
			set
			{
				short num = (short)483459072;
				short num2 = num;
				num = (short)412943386;
				short num3 = num;
				num = (short)219612186;
				switch (num3 == num)
				{
				}
				num = (short)1187381249;
				if (num != 0)
				{
				}
				num = (short)23068672;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.Value = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000E1A50 File Offset: 0x000DFC50
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x000E1B04 File Offset: 0x000DFD04
		public string TrkSysFeaturesTxBaseTimeSec_A9512_UIValue
		{
			get
			{
				short num = (short)390201344;
				short num2 = num;
				num = (short)54893991;
				short num3 = num;
				num = (short)620273063;
				switch (num3 == num)
				{
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				num = (short)691208192;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.UIValue;
			}
			set
			{
				short num = (short)630849536;
				short num2 = num;
				num = (short)1082602521;
				short num3 = num;
				num = (short)923874329;
				switch (num3 == num)
				{
				}
				num = (short)1552351233;
				if (num != 0)
				{
				}
				num = (short)1554710528;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.UIValue = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000E1BB8 File Offset: 0x000DFDB8
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesTxBaseTimeSec_A9512
		{
			get
			{
				short num = (short)1070268416;
				short num2 = num;
				num = (short)1904702536;
				short num3 = num;
				num = (short)788821064;
				switch (num3 == num)
				{
				}
				num = (short)1764163585;
				if (num != 0)
				{
				}
				num = (short)2094858240;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000E1C64 File Offset: 0x000DFE64
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x000E1D18 File Offset: 0x000DFF18
		public bool TrkSysFeaturesTxBaseTimeSec_A9512_Applicable
		{
			get
			{
				short num = (short)262864896;
				short num2 = num;
				num = (short)1158203243;
				short num3 = num;
				num = (short)257804139;
				switch (num3 == num)
				{
				}
				num = (short)313720833;
				if (num != 0)
				{
				}
				num = (short)2143879168;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.Applicable;
			}
			set
			{
				short num = (short)1651703808;
				short num2 = num;
				num = (short)111411201;
				if (num != 0)
				{
				}
				num = (short)1288875747;
				short num3 = num;
				num = (short)175550179;
				switch (num3 == num)
				{
				}
				num = (short)127991808;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.Applicable = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x000E1DCC File Offset: 0x000DFFCC
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x000E1E7C File Offset: 0x000E007C
		public bool TrkSysFeaturesTxBaseTimeSec_A9512_Valid
		{
			get
			{
				short num = (short)900595712;
				short num2 = num;
				num = (short)1640123797;
				short num3 = num;
				num = (short)1891585429;
				switch (num3 == num)
				{
				}
				num = (short)370999296;
				if (num != 0)
				{
				}
				num = (short)643432449;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.Valid;
			}
			set
			{
				short num = (short)1177878528;
				short num2 = num;
				num = (short)1237394073;
				short num3 = num;
				num = (short)582492825;
				switch (num3 == num)
				{
				}
				num = (short)1161428993;
				if (num != 0)
				{
				}
				num = (short)206700544;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.Valid = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x000E1F34 File Offset: 0x000E0134
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x000E1FEC File Offset: 0x000E01EC
		public bool TrkSysFeaturesTxBaseTimeSec_A9512_Visible
		{
			get
			{
				short num = (short)860356608;
				short num2 = num;
				num = (short)1442466649;
				short num3 = num;
				num = (short)710560601;
				switch (num3 == num)
				{
				}
				num = (short)1986592769;
				if (num != 0)
				{
				}
				num = (short)1718878208;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.Visible;
			}
			set
			{
				short num = (short)2112184924;
				short num2 = num;
				num = (short)1265525340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179896320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231211009;
				if (num != 0)
				{
				}
				num = (short)1464664064;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.Visible = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000E20A0 File Offset: 0x000E02A0
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x000E2154 File Offset: 0x000E0354
		public bool TrkSysFeaturesTxBaseTimeSec_A9512_Editable
		{
			get
			{
				short num = (short)1378025473;
				if (num != 0)
				{
				}
				num = (short)614662144;
				short num2 = num;
				num = (short)402288980;
				short num3 = num;
				num = (short)894595412;
				switch (num3 == num)
				{
				}
				num = (short)946995200;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.Editable;
			}
			set
			{
				short num = (short)1829847831;
				short num2 = num;
				num = (short)1726497559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712638464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)822083585;
				if (num != 0)
				{
				}
				num = (short)1717305344;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.Editable = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x000E220C File Offset: 0x000E040C
		internal string TrkSysFeaturesTxBaseTimeSec_A9512_UILabel
		{
			get
			{
				short num = (short)1903032036;
				short num2 = num;
				num = (short)1656551140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1945174016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324023809;
				if (num != 0)
				{
				}
				num = (short)1476984832;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.UIName;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000E22C0 File Offset: 0x000E04C0
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x000E2374 File Offset: 0x000E0574
		internal bool TrkSysFeaturesTxBaseTimeSec_A9512_HiddenStatic
		{
			get
			{
				short num = (short)1185298505;
				short num2 = num;
				num = (short)807024713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929890304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)724107265;
				if (num != 0)
				{
				}
				num = (short)806551552;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.HiddenStatic;
			}
			set
			{
				short num = (short)1220096813;
				short num2 = num;
				num = (short)448541485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587530240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195035137;
				if (num != 0)
				{
				}
				num = (short)1070137344;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.HiddenStatic = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000E2428 File Offset: 0x000E0628
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x000E24DC File Offset: 0x000E06DC
		internal bool TrkSysFeaturesTxBaseTimeSec_A9512_HiddenDynamic
		{
			get
			{
				short num = (short)14155777;
				if (num != 0)
				{
				}
				num = (short)1904607232;
				short num2 = num;
				num = (short)336846333;
				short num3 = num;
				num = (short)1081466365;
				switch (num3 == num)
				{
				}
				num = (short)95354880;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512.HiddenDynamic;
			}
			set
			{
				short num = (short)2113508065;
				short num2 = num;
				num = (short)1629590241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091581440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)413073408;
				if (num != 0)
				{
				}
				num = (short)1543831553;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxBaseTimeSec_A9512.HiddenDynamic = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x000E2590 File Offset: 0x000E0790
		public bool TrkSysFeaturesTxBaseTimeSec_A9512_HasDiffs
		{
			get
			{
				short num = (short)2069727069;
				short num2 = num;
				num = (short)25200477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)972881920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)217513985;
				if (num != 0)
				{
				}
				num = (short)2045444096;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxBaseTimeSec_A9512._HasDiffs;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x000E2644 File Offset: 0x000E0844
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000E26F8 File Offset: 0x000E08F8
		public int TrkSysFeaturesTxPowerLevel_A9557Value
		{
			get
			{
				short num = (short)292816535;
				short num2 = num;
				num = (short)1940326039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834273280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348979201;
				if (num != 0)
				{
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.Value;
			}
			set
			{
				short num = (short)85248185;
				short num2 = num;
				num = (short)1379387577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733492736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)294846465;
				if (num != 0)
				{
				}
				num = (short)868417536;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.Value = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x000E27AC File Offset: 0x000E09AC
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000E2860 File Offset: 0x000E0A60
		public string TrkSysFeaturesTxPowerLevel_A9557_UIValue
		{
			get
			{
				short num = (short)1785889732;
				short num2 = num;
				num = (short)2146993092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719009280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1077149696;
				if (num != 0)
				{
				}
				num = (short)116588545;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.UIValue;
			}
			set
			{
				short num = (short)94214911;
				short num2 = num;
				num = (short)671849215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398996992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				num = (short)772472832;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.UIValue = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x000E2918 File Offset: 0x000E0B18
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesTxPowerLevel_A9557
		{
			get
			{
				short num = (short)1528237909;
				short num2 = num;
				num = (short)1553010517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346161152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633746945;
				if (num != 0)
				{
				}
				num = (short)1196032000;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000E29C8 File Offset: 0x000E0BC8
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x000E2A7C File Offset: 0x000E0C7C
		public bool TrkSysFeaturesTxPowerLevel_A9557_Applicable
		{
			get
			{
				short num = (short)1934644584;
				short num2 = num;
				num = (short)829248872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839464448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784020992;
				if (num != 0)
				{
				}
				num = (short)342622209;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.Applicable;
			}
			set
			{
				short num = (short)2003972641;
				short num2 = num;
				num = (short)982331937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262944256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479213057;
				if (num != 0)
				{
				}
				num = (short)676855808;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.Applicable = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x000E2B30 File Offset: 0x000E0D30
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
		public bool TrkSysFeaturesTxPowerLevel_A9557_Valid
		{
			get
			{
				short num = (short)1181251839;
				short num2 = num;
				num = (short)297695487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045823488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)145948673;
				if (num != 0)
				{
				}
				num = (short)794689536;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.Valid;
			}
			set
			{
				short num = (short)685923187;
				short num2 = num;
				num = (short)1238260595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)104923136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492765185;
				if (num != 0)
				{
				}
				num = (short)217776128;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.Valid = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x000E2C98 File Offset: 0x000E0E98
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x000E2D4C File Offset: 0x000E0F4C
		public bool TrkSysFeaturesTxPowerLevel_A9557_Visible
		{
			get
			{
				short num = (short)416415745;
				if (num != 0)
				{
				}
				num = (short)81461248;
				short num2 = num;
				num = (short)1478351370;
				short num3 = num;
				num = (short)1975179786;
				switch (num3 == num)
				{
				}
				num = (short)1416888320;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.Visible;
			}
			set
			{
				short num = (short)1290022514;
				short num2 = num;
				num = (short)521481842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1065156608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1947271169;
				if (num != 0)
				{
				}
				num = (short)695992320;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.Visible = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x000E2E04 File Offset: 0x000E1004
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x000E2EBC File Offset: 0x000E10BC
		public bool TrkSysFeaturesTxPowerLevel_A9557_Editable
		{
			get
			{
				short num = (short)677459403;
				short num2 = num;
				num = (short)1210004939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527185408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)244318209;
				if (num != 0)
				{
				}
				num = (short)218497024;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.Editable;
			}
			set
			{
				short num = (short)1543007559;
				short num2 = num;
				num = (short)1481862471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93913088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1693908993;
				if (num != 0)
				{
				}
				num = (short)459931648;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.Editable = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000E2F70 File Offset: 0x000E1170
		internal string TrkSysFeaturesTxPowerLevel_A9557_UILabel
		{
			get
			{
				short num = (short)531234817;
				if (num != 0)
				{
				}
				num = (short)2080243712;
				short num2 = num;
				num = (short)1754335991;
				short num3 = num;
				num = (short)46992119;
				switch (num3 == num)
				{
				}
				num = (short)1321926656;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.UIName;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x000E3028 File Offset: 0x000E1228
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x000E30DC File Offset: 0x000E12DC
		internal bool TrkSysFeaturesTxPowerLevel_A9557_HiddenStatic
		{
			get
			{
				short num = (short)901683287;
				short num2 = num;
				num = (short)357472343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257622016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)520028161;
				if (num != 0)
				{
				}
				num = (short)511049728;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.HiddenStatic;
			}
			set
			{
				short num = (short)21984107;
				short num2 = num;
				num = (short)1632072555;
				switch (num2 == num)
				{
				}
				num = (short)377225217;
				if (num != 0)
				{
				}
				num = (short)769327104;
				short num3 = num;
				num = (short)595263488;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.HiddenStatic = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x000E3190 File Offset: 0x000E1390
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x000E3244 File Offset: 0x000E1444
		internal bool TrkSysFeaturesTxPowerLevel_A9557_HiddenDynamic
		{
			get
			{
				short num = (short)1571732149;
				short num2 = num;
				num = (short)460044981;
				switch (num2 == num)
				{
				}
				num = (short)1797652481;
				if (num != 0)
				{
				}
				num = (short)1985282048;
				short num3 = num;
				num = (short)1716453376;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557.HiddenDynamic;
			}
			set
			{
				short num = (short)1738344939;
				short num2 = num;
				num = (short)1251609067;
				switch (num2 == num)
				{
				}
				num = (short)1900019712;
				if (num != 0)
				{
				}
				num = (short)1934819328;
				short num3 = num;
				num = (short)587988993;
				if (num != 0)
				{
				}
				this.trkSysFeaturesTxPowerLevel_A9557.HiddenDynamic = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000E32F8 File Offset: 0x000E14F8
		public bool TrkSysFeaturesTxPowerLevel_A9557_HasDiffs
		{
			get
			{
				short num = (short)1040136362;
				short num2 = num;
				num = (short)135215274;
				switch (num2 == num)
				{
				}
				num = (short)274333697;
				if (num != 0)
				{
				}
				num = (short)1324351488;
				short num3 = num;
				num = (short)619380736;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesTxPowerLevel_A9557._HasDiffs;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000E33AC File Offset: 0x000E15AC
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000E3460 File Offset: 0x000E1660
		public int TrkSysFeaturesZone_A9717Value
		{
			get
			{
				short num = (short)568305370;
				short num2 = num;
				num = (short)1074112218;
				switch (num2 == num)
				{
				}
				num = (short)2133721089;
				if (num != 0)
				{
				}
				num = (short)500891648;
				short num3 = num;
				num = (short)117309440;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.Value;
			}
			set
			{
				short num = (short)587857921;
				if (num != 0)
				{
				}
				num = (short)1644791326;
				short num2 = num;
				num = (short)1993311774;
				switch (num2 == num)
				{
				}
				num = (short)205848576;
				short num3 = num;
				num = (short)805568512;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.Value = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x000E3514 File Offset: 0x000E1714
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x000E35CC File Offset: 0x000E17CC
		public string TrkSysFeaturesZone_A9717_UIValue
		{
			get
			{
				short num = (short)742709663;
				short num2 = num;
				num = (short)705878431;
				switch (num2 == num)
				{
				}
				num = (short)1689518080;
				if (num != 0)
				{
				}
				num = (short)2073100288;
				short num3 = num;
				num = (short)670433281;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.UIValue;
			}
			set
			{
				short num = (short)1145014699;
				short num2 = num;
				num = (short)297568683;
				switch (num2 == num)
				{
				}
				num = (short)222232576;
				if (num != 0)
				{
				}
				num = (short)19136512;
				short num3 = num;
				num = (short)100794369;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.UIValue = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x000E3680 File Offset: 0x000E1880
		public global::AcpBusinessLayer.AcpRecRefField TrkSysFeaturesZone_A9717
		{
			get
			{
				short num = (short)932300900;
				short num2 = num;
				num = (short)1765984356;
				switch (num2 == num)
				{
				}
				num = (short)583073793;
				if (num != 0)
				{
				}
				num = (short)453443584;
				short num3 = num;
				num = (short)2121072640;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x000E3730 File Offset: 0x000E1930
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x000E37E4 File Offset: 0x000E19E4
		public bool TrkSysFeaturesZone_A9717_Applicable
		{
			get
			{
				short num = (short)1527434213;
				short num2 = num;
				num = (short)47959013;
				switch (num2 == num)
				{
				}
				num = (short)1922826241;
				if (num != 0)
				{
				}
				num = (short)194183168;
				short num3 = num;
				num = (short)1660944384;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.Applicable;
			}
			set
			{
				short num = (short)478919399;
				short num2 = num;
				num = (short)259242727;
				switch (num2 == num)
				{
				}
				num = (short)654573568;
				if (num != 0)
				{
				}
				num = (short)299171840;
				short num3 = num;
				num = (short)762576897;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.Applicable = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000E3898 File Offset: 0x000E1A98
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x000E3948 File Offset: 0x000E1B48
		public bool TrkSysFeaturesZone_A9717_Valid
		{
			get
			{
				short num = (short)1773176972;
				short num2 = num;
				num = (short)1852868748;
				switch (num2 == num)
				{
				}
				num = (short)1982005248;
				if (num != 0)
				{
				}
				num = (short)1824063488;
				short num3 = num;
				num = (short)1136197633;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.Valid;
			}
			set
			{
				short num = (short)854188900;
				short num2 = num;
				num = (short)51962724;
				switch (num2 == num)
				{
				}
				num = (short)225640449;
				if (num != 0)
				{
				}
				num = (short)1486487552;
				short num3 = num;
				num = (short)1230766080;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.Valid = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x000E39FC File Offset: 0x000E1BFC
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000E3AB0 File Offset: 0x000E1CB0
		public bool TrkSysFeaturesZone_A9717_Visible
		{
			get
			{
				short num = (short)286916609;
				if (num != 0)
				{
				}
				num = (short)924824327;
				short num2 = num;
				num = (short)1819259655;
				switch (num2 == num)
				{
				}
				num = (short)436666368;
				short num3 = num;
				num = (short)2128740352;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.Visible;
			}
			set
			{
				short num = (short)337597979;
				short num2 = num;
				num = (short)1519932955;
				switch (num2 == num)
				{
				}
				num = (short)1041235969;
				if (num != 0)
				{
				}
				num = (short)232390656;
				short num3 = num;
				num = (short)56229888;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.Visible = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000E3B68 File Offset: 0x000E1D68
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x000E3C20 File Offset: 0x000E1E20
		public bool TrkSysFeaturesZone_A9717_Editable
		{
			get
			{
				short num = (short)456589313;
				if (num != 0)
				{
				}
				num = (short)240481648;
				short num2 = num;
				num = (short)1220244848;
				switch (num2 == num)
				{
				}
				num = (short)1036517376;
				short num3 = num;
				num = (short)1274085376;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.Editable;
			}
			set
			{
				short num = (short)1519857183;
				short num2 = num;
				num = (short)694365727;
				switch (num2 == num)
				{
				}
				num = (short)1498218496;
				if (num != 0)
				{
				}
				num = (short)437583872;
				short num3 = num;
				num = (short)1099694081;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.Editable = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x000E3CD8 File Offset: 0x000E1ED8
		internal string TrkSysFeaturesZone_A9717_UILabel
		{
			get
			{
				short num = (short)1426108509;
				short num2 = num;
				num = (short)129544285;
				switch (num2 == num)
				{
				}
				num = (short)327221249;
				if (num != 0)
				{
				}
				num = (short)1920008192;
				short num3 = num;
				num = (short)1953955840;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.UIName;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000E3D8C File Offset: 0x000E1F8C
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x000E3E40 File Offset: 0x000E2040
		internal bool TrkSysFeaturesZone_A9717_HiddenStatic
		{
			get
			{
				short num = (short)1139790737;
				short num2 = num;
				num = (short)1831719825;
				switch (num2 == num)
				{
				}
				num = (short)2099576833;
				if (num != 0)
				{
				}
				num = (short)1223229440;
				short num3 = num;
				num = (short)1713766400;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.HiddenStatic;
			}
			set
			{
				short num = (short)310708091;
				short num2 = num;
				num = (short)673908603;
				switch (num2 == num)
				{
				}
				num = (short)1158348801;
				if (num != 0)
				{
				}
				num = (short)1477771264;
				short num3 = num;
				num = (short)1332805632;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.HiddenStatic = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000E3EF4 File Offset: 0x000E20F4
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x000E3FA8 File Offset: 0x000E21A8
		internal bool TrkSysFeaturesZone_A9717_HiddenDynamic
		{
			get
			{
				short num = (short)2146919293;
				short num2 = num;
				num = (short)1885692797;
				switch (num2 == num)
				{
				}
				num = (short)875495424;
				if (num != 0)
				{
				}
				num = (short)330235904;
				short num3 = num;
				num = (short)865599489;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717.HiddenDynamic;
			}
			set
			{
				short num = (short)971386534;
				short num2 = num;
				num = (short)1939156646;
				switch (num2 == num)
				{
				}
				num = (short)1610285057;
				if (num != 0)
				{
				}
				num = (short)1031012352;
				short num3 = num;
				num = (short)1003749376;
				if (num != 0)
				{
				}
				this.trkSysFeaturesZone_A9717.HiddenDynamic = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x000E4060 File Offset: 0x000E2260
		public bool TrkSysFeaturesZone_A9717_HasDiffs
		{
			get
			{
				short num = (short)607807770;
				short num2 = num;
				num = (short)701851930;
				switch (num2 == num)
				{
				}
				num = (short)1003880448;
				if (num != 0)
				{
				}
				num = (short)1492189184;
				short num3 = num;
				num = (short)866254849;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesZone_A9717._HasDiffs;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000E4118 File Offset: 0x000E2318
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x000E41D0 File Offset: 0x000E23D0
		public int TrkSysFeaturesChannel_A7647Value
		{
			get
			{
				short num = (short)1709113345;
				if (num != 0)
				{
				}
				num = (short)535006801;
				short num2 = num;
				num = (short)383290961;
				switch (num2 == num)
				{
				}
				num = (short)390725632;
				short num3 = num;
				num = (short)280035328;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.Value;
			}
			set
			{
				short num = (short)869588656;
				short num2 = num;
				num = (short)1648287408;
				switch (num2 == num)
				{
				}
				num = (short)557383681;
				if (num != 0)
				{
				}
				num = (short)1582694400;
				short num3 = num;
				num = (short)1455161344;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.Value = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000E4288 File Offset: 0x000E2488
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x000E4338 File Offset: 0x000E2538
		public string TrkSysFeaturesChannel_A7647_UIValue
		{
			get
			{
				short num = (short)1777615399;
				short num2 = num;
				num = (short)1407861287;
				switch (num2 == num)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				num = (short)1411645440;
				short num3 = num;
				num = (short)1719140353;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.UIValue;
			}
			set
			{
				short num = (short)2033340011;
				short num2 = num;
				num = (short)1674661483;
				switch (num2 == num)
				{
				}
				num = (short)70451201;
				if (num != 0)
				{
				}
				num = (short)1807941632;
				short num3 = num;
				num = (short)2103705600;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.UIValue = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x000E43EC File Offset: 0x000E25EC
		public global::AcpBusinessLayer.AcpRecRefField TrkSysFeaturesChannel_A7647
		{
			get
			{
				short num = (short)509367151;
				short num2 = num;
				num = (short)255677295;
				switch (num2 == num)
				{
				}
				num = (short)669515777;
				if (num != 0)
				{
				}
				num = (short)100466688;
				short num3 = num;
				num = (short)650117120;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x000E449C File Offset: 0x000E269C
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x000E4550 File Offset: 0x000E2750
		public bool TrkSysFeaturesChannel_A7647_Applicable
		{
			get
			{
				short num = (short)534606730;
				short num2 = num;
				num = (short)1806201738;
				switch (num2 == num)
				{
				}
				num = (short)446431232;
				if (num != 0)
				{
				}
				num = (short)1279393792;
				short num3 = num;
				num = (short)1334181889;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.Applicable;
			}
			set
			{
				short num = (short)1395323943;
				short num2 = num;
				num = (short)780137511;
				switch (num2 == num)
				{
				}
				num = (short)222953472;
				if (num != 0)
				{
				}
				num = (short)1895170048;
				short num3 = num;
				num = (short)33161217;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.Applicable = value;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000E4608 File Offset: 0x000E2808
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000E46C0 File Offset: 0x000E28C0
		public bool TrkSysFeaturesChannel_A7647_Valid
		{
			get
			{
				short num = (short)55967745;
				if (num != 0)
				{
				}
				num = (short)1788614030;
				short num2 = num;
				num = (short)922359182;
				switch (num2 == num)
				{
				}
				num = (short)910229504;
				short num3 = num;
				num = (short)158793728;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.Valid;
			}
			set
			{
				short num = (short)141426689;
				if (num != 0)
				{
				}
				num = (short)1651438868;
				short num2 = num;
				num = (short)1668936980;
				switch (num2 == num)
				{
				}
				num = (short)1743519744;
				short num3 = num;
				num = (short)1793720320;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.Valid = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000E4774 File Offset: 0x000E2974
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000E4828 File Offset: 0x000E2A28
		public bool TrkSysFeaturesChannel_A7647_Visible
		{
			get
			{
				short num = (short)1042022401;
				if (num != 0)
				{
				}
				num = (short)1829070429;
				short num2 = num;
				num = (short)945251933;
				switch (num2 == num)
				{
				}
				num = (short)1785069568;
				short num3 = num;
				num = (short)507904000;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.Visible;
			}
			set
			{
				short num = (short)384477888;
				short num2 = num;
				num = (short)29403840;
				switch (num2 == num)
				{
				}
				num = (short)796655617;
				if (num != 0)
				{
				}
				num = (short)1290403840;
				short num3 = num;
				num = (short)1422917632;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.Visible = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000E48DC File Offset: 0x000E2ADC
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x000E4990 File Offset: 0x000E2B90
		public bool TrkSysFeaturesChannel_A7647_Editable
		{
			get
			{
				short num = (short)620987257;
				short num2 = num;
				num = (short)866222969;
				switch (num2 == num)
				{
				}
				num = (short)403636224;
				if (num != 0)
				{
				}
				num = (short)744095744;
				short num3 = num;
				num = (short)1339293697;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.Editable;
			}
			set
			{
				short num = (short)1248558483;
				short num2 = num;
				num = (short)287800723;
				switch (num2 == num)
				{
				}
				num = (short)494206976;
				if (num != 0)
				{
				}
				num = (short)86507520;
				short num3 = num;
				num = (short)732954625;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.Editable = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000E4A48 File Offset: 0x000E2C48
		internal string TrkSysFeaturesChannel_A7647_UILabel
		{
			get
			{
				short num = (short)1402874177;
				short num2 = num;
				num = (short)1634871617;
				switch (num2 == num)
				{
				}
				num = (short)1308033025;
				if (num != 0)
				{
				}
				num = (short)1700790272;
				short num3 = num;
				num = (short)1392574464;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.UIName;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000E4B00 File Offset: 0x000E2D00
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x000E4BB4 File Offset: 0x000E2DB4
		internal bool TrkSysFeaturesChannel_A7647_HiddenStatic
		{
			get
			{
				short num = (short)1055761746;
				short num2 = num;
				num = (short)88581458;
				switch (num2 == num)
				{
				}
				num = (short)1698955265;
				if (num != 0)
				{
				}
				num = (short)1852506112;
				short num3 = num;
				num = (short)993067008;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.HiddenStatic;
			}
			set
			{
				short num = (short)528018438;
				short num2 = num;
				num = (short)825289734;
				switch (num2 == num)
				{
				}
				num = (short)621608961;
				if (num != 0)
				{
				}
				num = (short)1649803264;
				short num3 = num;
				num = (short)1461977088;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.HiddenStatic = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000E4C6C File Offset: 0x000E2E6C
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x000E4D20 File Offset: 0x000E2F20
		internal bool TrkSysFeaturesChannel_A7647_HiddenDynamic
		{
			get
			{
				short num = (short)738591039;
				short num2 = num;
				num = (short)1688928575;
				switch (num2 == num)
				{
				}
				num = (short)2042560513;
				if (num != 0)
				{
				}
				num = (short)1483407360;
				short num3 = num;
				num = (short)885915648;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647.HiddenDynamic;
			}
			set
			{
				short num = (short)754461944;
				short num2 = num;
				num = (short)33434872;
				switch (num2 == num)
				{
				}
				num = (short)1512964097;
				if (num != 0)
				{
				}
				num = (short)1559232512;
				short num3 = num;
				num = (short)715522048;
				if (num != 0)
				{
				}
				this.trkSysFeaturesChannel_A7647.HiddenDynamic = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x000E4DD4 File Offset: 0x000E2FD4
		public bool TrkSysFeaturesChannel_A7647_HasDiffs
		{
			get
			{
				short num = (short)632110861;
				short num2 = num;
				num = (short)1076117261;
				switch (num2 == num)
				{
				}
				num = (short)543555584;
				if (num != 0)
				{
				}
				num = (short)231473152;
				short num3 = num;
				num = (short)106037249;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesChannel_A7647._HasDiffs;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000E4E88 File Offset: 0x000E3088
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000E4F3C File Offset: 0x000E313C
		public int TrkSysFeaturesHearClear_A36422Value
		{
			get
			{
				short num = (short)1965472608;
				short num2 = num;
				num = (short)589151072;
				switch (num2 == num)
				{
				}
				num = (short)97386497;
				if (num != 0)
				{
				}
				num = (short)160694272;
				short num3 = num;
				num = (short)105185280;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.Value;
			}
			set
			{
				short num = (short)1402785562;
				short num2 = num;
				num = (short)537120538;
				switch (num2 == num)
				{
				}
				num = (short)733151233;
				if (num != 0)
				{
				}
				num = (short)445906944;
				short num3 = num;
				num = (short)2075852800;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.Value = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000E4FF4 File Offset: 0x000E31F4
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000E50A8 File Offset: 0x000E32A8
		public string TrkSysFeaturesHearClear_A36422_UIValue
		{
			get
			{
				short num = (short)737301614;
				short num2 = num;
				num = (short)1357993070;
				switch (num2 == num)
				{
				}
				num = (short)14286849;
				if (num != 0)
				{
				}
				num = (short)429457408;
				short num3 = num;
				num = (short)1562181632;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.UIValue;
			}
			set
			{
				short num = (short)1099694081;
				if (num != 0)
				{
				}
				num = (short)518507740;
				short num2 = num;
				num = (short)643550428;
				switch (num2 == num)
				{
				}
				num = (short)570294272;
				short num3 = num;
				num = (short)373424128;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.UIValue = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000E5160 File Offset: 0x000E3360
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesHearClear_A36422
		{
			get
			{
				short num = (short)550719164;
				short num2 = num;
				num = (short)2134331068;
				switch (num2 == num)
				{
				}
				num = (short)1397620736;
				if (num != 0)
				{
				}
				num = (short)1927020544;
				short num3 = num;
				num = (short)1191575553;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x000E5210 File Offset: 0x000E3410
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x000E52C4 File Offset: 0x000E34C4
		public bool TrkSysFeaturesHearClear_A36422_Applicable
		{
			get
			{
				short num = (short)339410945;
				if (num != 0)
				{
				}
				num = (short)750306807;
				short num2 = num;
				num = (short)463390199;
				switch (num2 == num)
				{
				}
				num = (short)1225588736;
				short num3 = num;
				num = (short)447348736;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.Applicable;
			}
			set
			{
				short num = (short)1469775873;
				if (num != 0)
				{
				}
				num = (short)1231224832;
				short num2 = num;
				num = (short)1031996760;
				short num3 = num;
				num = (short)1022362968;
				switch (num3 == num)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.Applicable = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000E537C File Offset: 0x000E357C
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x000E5430 File Offset: 0x000E3630
		public bool TrkSysFeaturesHearClear_A36422_Valid
		{
			get
			{
				short num = (short)1074619546;
				short num2 = num;
				num = (short)1323197594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068185088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661323776;
				if (num != 0)
				{
				}
				num = (short)806551553;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.Valid;
			}
			set
			{
				short num = (short)2040791122;
				short num2 = num;
				num = (short)1977417810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687800320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021902848;
				if (num != 0)
				{
				}
				num = (short)531955713;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.Valid = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x000E54E4 File Offset: 0x000E36E4
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x000E5598 File Offset: 0x000E3798
		public bool TrkSysFeaturesHearClear_A36422_Visible
		{
			get
			{
				short num = (short)813073773;
				short num2 = num;
				num = (short)1759741293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1755054080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1729036289;
				if (num != 0)
				{
				}
				num = (short)2056388608;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.Visible;
			}
			set
			{
				short num = (short)1747582977;
				if (num != 0)
				{
				}
				num = (short)500236288;
				short num2 = num;
				num = (short)1923389878;
				short num3 = num;
				num = (short)1495570870;
				switch (num3 == num)
				{
				}
				num = (short)1957560320;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.Visible = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000E564C File Offset: 0x000E384C
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x000E5700 File Offset: 0x000E3900
		public bool TrkSysFeaturesHearClear_A36422_Editable
		{
			get
			{
				short num = (short)432014203;
				short num2 = num;
				num = (short)1059521403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660078592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210843136;
				if (num != 0)
				{
				}
				num = (short)1281949697;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.Editable;
			}
			set
			{
				short num = (short)836842714;
				short num2 = num;
				num = (short)739456218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882521600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749797376;
				if (num != 0)
				{
				}
				num = (short)1624178689;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.Editable = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x000E57B4 File Offset: 0x000E39B4
		internal string TrkSysFeaturesHearClear_A36422_UILabel
		{
			get
			{
				short num = (short)1194590209;
				if (num != 0)
				{
				}
				num = (short)52887552;
				short num2 = num;
				num = (short)779371716;
				short num3 = num;
				num = (short)2127185092;
				switch (num3 == num)
				{
				}
				num = (short)1487929344;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.UIName;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000E586C File Offset: 0x000E3A6C
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000E5920 File Offset: 0x000E3B20
		internal bool TrkSysFeaturesHearClear_A36422_HiddenStatic
		{
			get
			{
				short num = (short)796610971;
				short num2 = num;
				num = (short)1926713755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)238354432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1908211713;
				if (num != 0)
				{
				}
				num = (short)463929344;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.HiddenStatic;
			}
			set
			{
				short num = (short)688225178;
				short num2 = num;
				num = (short)115375002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594687488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136328704;
				if (num != 0)
				{
				}
				num = (short)1403387905;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.HiddenStatic = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000E59D4 File Offset: 0x000E3BD4
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000E5A8C File Offset: 0x000E3C8C
		internal bool TrkSysFeaturesHearClear_A36422_HiddenDynamic
		{
			get
			{
				short num = (short)780229113;
				short num2 = num;
				num = (short)475683321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749680128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559887872;
				if (num != 0)
				{
				}
				num = (short)684720129;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422.HiddenDynamic;
			}
			set
			{
				short num = (short)1519871155;
				short num2 = num;
				num = (short)1582523571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771686400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)132972545;
				if (num != 0)
				{
				}
				num = (short)1918631936;
				if (num != 0)
				{
				}
				this.trkSysFeaturesHearClear_A36422.HiddenDynamic = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000E5B44 File Offset: 0x000E3D44
		public bool TrkSysFeaturesHearClear_A36422_HasDiffs
		{
			get
			{
				short num = (short)357578674;
				short num2 = num;
				num = (short)681129906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514260992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033502721;
				if (num != 0)
				{
				}
				num = (short)1675821056;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesHearClear_A36422._HasDiffs;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000E5BF8 File Offset: 0x000E3DF8
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x000E5CAC File Offset: 0x000E3EAC
		public bool TrkSysFeaturesEnable_A7968Value
		{
			get
			{
				short num = (short)2083882543;
				short num2 = num;
				num = (short)1656784431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757609984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756495873;
				if (num != 0)
				{
				}
				num = (short)1608450048;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Value;
			}
			set
			{
				short num = (short)1661277728;
				short num2 = num;
				num = (short)1838224928;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850408960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1302528000;
				if (num != 0)
				{
				}
				num = (short)145293313;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Value = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000E5D60 File Offset: 0x000E3F60
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesEnable_A7968
		{
			get
			{
				short num = (short)385602621;
				short num2 = num;
				num = (short)782423101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039269888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573388289;
				if (num != 0)
				{
				}
				num = (short)1782972416;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x000E5E10 File Offset: 0x000E4010
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x000E5EC8 File Offset: 0x000E40C8
		public bool TrkSysFeaturesEnable_A7968_UIValue
		{
			get
			{
				short num = (short)517210113;
				if (num != 0)
				{
				}
				num = (short)1402798080;
				short num2 = num;
				num = (short)1134671447;
				short num3 = num;
				num = (short)1308407383;
				switch (num3 == num)
				{
				}
				num = (short)1107689472;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Value;
			}
			set
			{
				short num = (short)63489491;
				short num2 = num;
				num = (short)1295107539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335020032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346174976;
				if (num != 0)
				{
				}
				num = (short)1139605505;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Value = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000E5F7C File Offset: 0x000E417C
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x000E6030 File Offset: 0x000E4230
		public bool TrkSysFeaturesEnable_A7968_Applicable
		{
			get
			{
				short num = (short)502342191;
				short num2 = num;
				num = (short)1331569199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)386859008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)821493760;
				if (num != 0)
				{
				}
				num = (short)1038221313;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Applicable;
			}
			set
			{
				short num = (short)1943091364;
				short num2 = num;
				num = (short)888158372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15728640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1882456064;
				if (num != 0)
				{
				}
				num = (short)1570045953;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Applicable = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x000E60E8 File Offset: 0x000E42E8
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000E61A0 File Offset: 0x000E43A0
		public bool TrkSysFeaturesEnable_A7968_Valid
		{
			get
			{
				short num = (short)1744252814;
				short num2 = num;
				num = (short)75181966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773259264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001127937;
				if (num != 0)
				{
				}
				num = (short)1295122432;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Valid;
			}
			set
			{
				short num = (short)1953159303;
				short num2 = num;
				num = (short)1430902919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1640431616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882769921;
				if (num != 0)
				{
				}
				num = (short)1074003968;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Valid = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000E6254 File Offset: 0x000E4454
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000E6308 File Offset: 0x000E4508
		public bool TrkSysFeaturesEnable_A7968_Visible
		{
			get
			{
				short num = (short)662457390;
				short num2 = num;
				num = (short)949898286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)583139328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298844160;
				if (num != 0)
				{
				}
				num = (short)706543617;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Visible;
			}
			set
			{
				short num = (short)756219904;
				short num2 = num;
				num = (short)140675276;
				short num3 = num;
				num = (short)1257081036;
				switch (num3 == num)
				{
				}
				num = (short)1757151233;
				if (num != 0)
				{
				}
				num = (short)1050279936;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Visible = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000E63C0 File Offset: 0x000E45C0
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000E6474 File Offset: 0x000E4674
		public bool TrkSysFeaturesEnable_A7968_Editable
		{
			get
			{
				short num = (short)1531904000;
				short num2 = num;
				num = (short)212911191;
				short num3 = num;
				num = (short)1428800599;
				switch (num3 == num)
				{
				}
				num = (short)1986527233;
				if (num != 0)
				{
				}
				num = (short)822738944;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.Editable;
			}
			set
			{
				short num = (short)1747910656;
				short num2 = num;
				num = (short)856948737;
				if (num != 0)
				{
				}
				num = (short)323211858;
				short num3 = num;
				num = (short)801886802;
				switch (num3 == num)
				{
				}
				num = (short)1003880448;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.Editable = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000E652C File Offset: 0x000E472C
		internal string TrkSysFeaturesEnable_A7968_UILabel
		{
			get
			{
				short num = (short)333643776;
				short num2 = num;
				num = (short)1561657345;
				if (num != 0)
				{
				}
				num = (short)619436675;
				short num3 = num;
				num = (short)256694915;
				switch (num3 == num)
				{
				}
				num = (short)239009792;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.UIName;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000E65E4 File Offset: 0x000E47E4
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x000E669C File Offset: 0x000E489C
		internal bool TrkSysFeaturesEnable_A7968_HiddenStatic
		{
			get
			{
				short num = (short)745930752;
				short num2 = num;
				num = (short)1022043247;
				short num3 = num;
				num = (short)1455039599;
				switch (num3 == num)
				{
				}
				num = (short)127664128;
				if (num != 0)
				{
				}
				num = (short)585760769;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.HiddenStatic;
			}
			set
			{
				short num = (short)1104019456;
				short num2 = num;
				num = (short)1513976645;
				short num3 = num;
				num = (short)1328706373;
				switch (num3 == num)
				{
				}
				num = (short)2006056960;
				if (num != 0)
				{
				}
				num = (short)1515126785;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.HiddenStatic = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000E6750 File Offset: 0x000E4950
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x000E6804 File Offset: 0x000E4A04
		internal bool TrkSysFeaturesEnable_A7968_HiddenDynamic
		{
			get
			{
				short num = (short)763166720;
				short num2 = num;
				num = (short)1859951104;
				short num3 = num;
				num = (short)1264425472;
				switch (num3 == num)
				{
				}
				num = (short)968884225;
				if (num != 0)
				{
				}
				num = (short)290455552;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968.HiddenDynamic;
			}
			set
			{
				short num = (short)1405026304;
				short num2 = num;
				num = (short)127154659;
				short num3 = num;
				num = (short)2069772771;
				switch (num3 == num)
				{
				}
				num = (short)376045569;
				if (num != 0)
				{
				}
				num = (short)281214976;
				if (num != 0)
				{
				}
				this.trkSysFeaturesEnable_A7968.HiddenDynamic = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000E68BC File Offset: 0x000E4ABC
		public bool TrkSysFeaturesEnable_A7968_HasDiffs
		{
			get
			{
				short num = (short)1693515776;
				short num2 = num;
				num = (short)730010068;
				short num3 = num;
				num = (short)1254822356;
				switch (num3 == num)
				{
				}
				num = (short)1154613249;
				if (num != 0)
				{
				}
				num = (short)1376649216;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesEnable_A7968._HasDiffs;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000E6974 File Offset: 0x000E4B74
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x000E6A28 File Offset: 0x000E4C28
		public int SiteSelectableAlertList_A42060Value
		{
			get
			{
				short num = (short)15335424;
				short num2 = num;
				num = (short)316339050;
				short num3 = num;
				num = (short)1110242154;
				switch (num3 == num)
				{
				}
				num = (short)1401815040;
				if (num != 0)
				{
				}
				num = (short)513015809;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.Value;
			}
			set
			{
				short num = (short)1668087808;
				short num2 = num;
				num = (short)1029277812;
				short num3 = num;
				num = (short)2144110708;
				switch (num3 == num)
				{
				}
				num = (short)1178730497;
				if (num != 0)
				{
				}
				num = (short)1131937792;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.Value = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x000E6ADC File Offset: 0x000E4CDC
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x000E6B90 File Offset: 0x000E4D90
		public string SiteSelectableAlertList_A42060_UIValue
		{
			get
			{
				short num = (short)1503461376;
				short num2 = num;
				num = (short)39734806;
				short num3 = num;
				num = (short)752307734;
				switch (num3 == num)
				{
				}
				num = (short)1073545217;
				if (num != 0)
				{
				}
				num = (short)1069219840;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.UIValue;
			}
			set
			{
				short num = (short)1916403712;
				short num2 = num;
				num = (short)525602544;
				short num3 = num;
				num = (short)1229000432;
				switch (num3 == num)
				{
				}
				num = (short)551026688;
				if (num != 0)
				{
				}
				num = (short)1717043201;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.UIValue = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000E6C44 File Offset: 0x000E4E44
		public global::AcpBusinessLayer.AcpRecRefField SiteSelectableAlertList_A42060
		{
			get
			{
				short num = (short)87556096;
				short num2 = num;
				num = (short)570228737;
				if (num != 0)
				{
				}
				num = (short)1109193684;
				short num3 = num;
				num = (short)1239675860;
				switch (num3 == num)
				{
				}
				num = (short)824639488;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000E6CF4 File Offset: 0x000E4EF4
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x000E6DA8 File Offset: 0x000E4FA8
		public bool SiteSelectableAlertList_A42060_Applicable
		{
			get
			{
				short num = (short)896925696;
				short num2 = num;
				num = (short)315789344;
				short num3 = num;
				num = (short)2104135712;
				switch (num3 == num)
				{
				}
				num = (short)1169096704;
				if (num != 0)
				{
				}
				num = (short)628228097;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.Applicable;
			}
			set
			{
				short num = (short)1212350464;
				short num2 = num;
				num = (short)297950046;
				short num3 = num;
				num = (short)1555520350;
				switch (num3 == num)
				{
				}
				num = (short)895746048;
				if (num != 0)
				{
				}
				num = (short)927662081;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.Applicable = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x000E6E60 File Offset: 0x000E5060
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x000E6F14 File Offset: 0x000E5114
		public bool SiteSelectableAlertList_A42060_Valid
		{
			get
			{
				short num = (short)674758656;
				short num2 = num;
				num = (short)1606378209;
				short num3 = num;
				num = (short)718627553;
				switch (num3 == num)
				{
				}
				num = (short)987168769;
				if (num != 0)
				{
				}
				num = (short)1541865472;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.Valid;
			}
			set
			{
				short num = (short)1612775424;
				short num2 = num;
				num = (short)1586329061;
				short num3 = num;
				num = (short)707098085;
				switch (num3 == num)
				{
				}
				num = (short)2115960832;
				if (num != 0)
				{
				}
				num = (short)271384577;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.Valid = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000E6FC8 File Offset: 0x000E51C8
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000E7080 File Offset: 0x000E5280
		public bool SiteSelectableAlertList_A42060_Visible
		{
			get
			{
				short num = (short)557842432;
				short num2 = num;
				num = (short)881213108;
				short num3 = num;
				num = (short)2083995316;
				switch (num3 == num)
				{
				}
				num = (short)427491329;
				if (num != 0)
				{
				}
				num = (short)221839360;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.Visible;
			}
			set
			{
				short num = (short)1147535360;
				short num2 = num;
				num = (short)1888562168;
				short num3 = num;
				num = (short)1719348216;
				switch (num3 == num)
				{
				}
				num = (short)251920385;
				if (num != 0)
				{
				}
				num = (short)1967718400;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.Visible = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x000E7138 File Offset: 0x000E5338
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x000E71EC File Offset: 0x000E53EC
		public bool SiteSelectableAlertList_A42060_Editable
		{
			get
			{
				short num = (short)814874624;
				short num2 = num;
				num = (short)1118416295;
				short num3 = num;
				num = (short)804040103;
				switch (num3 == num)
				{
				}
				num = (short)2090860545;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.Editable;
			}
			set
			{
				short num = (short)1657995264;
				short num2 = num;
				num = (short)1238911832;
				short num3 = num;
				num = (short)1144671064;
				switch (num3 == num)
				{
				}
				num = (short)1849622529;
				if (num != 0)
				{
				}
				num = (short)2119041024;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.Editable = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000E72A4 File Offset: 0x000E54A4
		internal string SiteSelectableAlertList_A42060_UILabel
		{
			get
			{
				short num = (short)1064370176;
				short num2 = num;
				num = (short)1558249473;
				if (num != 0)
				{
				}
				num = (short)1169852243;
				short num3 = num;
				num = (short)1572308819;
				switch (num3 == num)
				{
				}
				num = (short)1970995200;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.UIName;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000E7358 File Offset: 0x000E5558
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x000E7410 File Offset: 0x000E5610
		internal bool SiteSelectableAlertList_A42060_HiddenStatic
		{
			get
			{
				short num = (short)1873936384;
				short num2 = num;
				num = (short)686606732;
				short num3 = num;
				num = (short)1085524364;
				switch (num3 == num)
				{
				}
				num = (short)1554186241;
				if (num != 0)
				{
				}
				num = (short)236191744;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.HiddenStatic;
			}
			set
			{
				short num = (short)887160832;
				short num2 = num;
				num = (short)1824827081;
				short num3 = num;
				num = (short)1532339913;
				switch (num3 == num)
				{
				}
				num = (short)1470431233;
				if (num != 0)
				{
				}
				num = (short)1468727296;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.HiddenStatic = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000E74C8 File Offset: 0x000E56C8
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x000E757C File Offset: 0x000E577C
		internal bool SiteSelectableAlertList_A42060_HiddenDynamic
		{
			get
			{
				short num = (short)1319698432;
				short num2 = num;
				num = (short)270805229;
				short num3 = num;
				num = (short)1668753645;
				switch (num3 == num)
				{
				}
				num = (short)1387659264;
				if (num != 0)
				{
				}
				num = (short)295829505;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060.HiddenDynamic;
			}
			set
			{
				short num = (short)1813839872;
				short num2 = num;
				num = (short)1058989859;
				short num3 = num;
				num = (short)2136729379;
				switch (num3 == num)
				{
				}
				num = (short)2041905152;
				if (num != 0)
				{
				}
				num = (short)797048833;
				if (num != 0)
				{
				}
				this.siteSelectableAlertList_A42060.HiddenDynamic = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000E7634 File Offset: 0x000E5834
		public bool SiteSelectableAlertList_A42060_HasDiffs
		{
			get
			{
				short num = (short)1679622144;
				short num2 = num;
				num = (short)596121795;
				short num3 = num;
				num = (short)957618371;
				switch (num3 == num)
				{
				}
				num = (short)4063233;
				if (num != 0)
				{
				}
				num = (short)620756992;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertList_A42060._HasDiffs;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x000E76EC File Offset: 0x000E58EC
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000E77A4 File Offset: 0x000E59A4
		public int SiteSelectableAlertAliasList_A42100Value
		{
			get
			{
				short num = (short)207880192;
				short num2 = num;
				num = (short)806784667;
				short num3 = num;
				num = (short)1043631771;
				switch (num3 == num)
				{
				}
				num = (short)95551489;
				if (num != 0)
				{
				}
				num = (short)981270528;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.Value;
			}
			set
			{
				short num = (short)363462656;
				short num2 = num;
				num = (short)1550297772;
				short num3 = num;
				num = (short)417966764;
				switch (num3 == num)
				{
				}
				num = (short)1821245441;
				if (num != 0)
				{
				}
				num = (short)24838144;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.Value = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000E785C File Offset: 0x000E5A5C
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000E7910 File Offset: 0x000E5B10
		public string SiteSelectableAlertAliasList_A42100_UIValue
		{
			get
			{
				short num = (short)235470848;
				short num2 = num;
				num = (short)1903695384;
				short num3 = num;
				num = (short)416618008;
				switch (num3 == num)
				{
				}
				num = (short)94044160;
				if (num != 0)
				{
				}
				num = (short)1237319681;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.UIValue;
			}
			set
			{
				short num = (short)1473773568;
				short num2 = num;
				num = (short)1909429865;
				short num3 = num;
				num = (short)1521849961;
				switch (num3 == num)
				{
				}
				num = (short)1215496192;
				if (num != 0)
				{
				}
				num = (short)1569128449;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.UIValue = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000E79C4 File Offset: 0x000E5BC4
		public global::AcpBusinessLayer.AcpRecRefField SiteSelectableAlertAliasList_A42100
		{
			get
			{
				short num = (short)105512960;
				short num2 = num;
				num = (short)2142710993;
				short num3 = num;
				num = (short)2079206609;
				switch (num3 == num)
				{
				}
				num = (short)1016856577;
				if (num != 0)
				{
				}
				num = (short)510197760;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x000E7A74 File Offset: 0x000E5C74
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x000E7B2C File Offset: 0x000E5D2C
		public bool SiteSelectableAlertAliasList_A42100_Applicable
		{
			get
			{
				short num = (short)403963904;
				short num2 = num;
				num = (short)2036734059;
				short num3 = num;
				num = (short)684136555;
				switch (num3 == num)
				{
				}
				num = (short)1668087809;
				if (num != 0)
				{
				}
				num = (short)791281664;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.Applicable;
			}
			set
			{
				short num = (short)2084241408;
				short num2 = num;
				num = (short)252802949;
				short num3 = num;
				num = (short)1248032645;
				switch (num3 == num)
				{
				}
				num = (short)1270022145;
				if (num != 0)
				{
				}
				num = (short)251330560;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.Applicable = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000E7BE4 File Offset: 0x000E5DE4
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x000E7C94 File Offset: 0x000E5E94
		public bool SiteSelectableAlertAliasList_A42100_Valid
		{
			get
			{
				short num = (short)1665925120;
				short num2 = num;
				num = (short)1149813014;
				short num3 = num;
				num = (short)1718862102;
				switch (num3 == num)
				{
				}
				num = (short)1332805633;
				if (num != 0)
				{
				}
				num = (short)1606221824;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.Valid;
			}
			set
			{
				short num = (short)1820196864;
				short num2 = num;
				num = (short)425510756;
				short num3 = num;
				num = (short)614385508;
				switch (num3 == num)
				{
				}
				num = (short)1836449792;
				if (num != 0)
				{
				}
				num = (short)1154023425;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.Valid = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000E7D4C File Offset: 0x000E5F4C
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x000E7E00 File Offset: 0x000E6000
		public bool SiteSelectableAlertAliasList_A42100_Visible
		{
			get
			{
				short num = (short)2097741824;
				short num2 = num;
				num = (short)378939640;
				short num3 = num;
				num = (short)1392716024;
				switch (num3 == num)
				{
				}
				num = (short)950665216;
				if (num != 0)
				{
				}
				num = (short)417923073;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.Visible;
			}
			set
			{
				short num = (short)2023489536;
				short num2 = num;
				num = (short)296489066;
				short num3 = num;
				num = (short)1193480298;
				switch (num3 == num)
				{
				}
				num = (short)164429824;
				if (num != 0)
				{
				}
				num = (short)828309505;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.Visible = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000E7EB4 File Offset: 0x000E60B4
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x000E7F6C File Offset: 0x000E616C
		public bool SiteSelectableAlertAliasList_A42100_Editable
		{
			get
			{
				short num = (short)257622016;
				short num2 = num;
				num = (short)1818022270;
				short num3 = num;
				num = (short)964088190;
				switch (num3 == num)
				{
				}
				num = (short)835977217;
				if (num != 0)
				{
				}
				num = (short)1094909952;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.Editable;
			}
			set
			{
				short num = (short)371523584;
				short num2 = num;
				num = (short)74711041;
				if (num != 0)
				{
				}
				num = (short)604223386;
				short num3 = num;
				num = (short)1583986586;
				switch (num3 == num)
				{
				}
				num = (short)1298792448;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.Editable = value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000E8020 File Offset: 0x000E6220
		internal string SiteSelectableAlertAliasList_A42100_UILabel
		{
			get
			{
				short num = (short)1671036928;
				short num2 = num;
				num = (short)1158693303;
				short num3 = num;
				num = (short)1173242295;
				switch (num3 == num)
				{
				}
				num = (short)1001455617;
				if (num != 0)
				{
				}
				num = (short)2103312384;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.UIName;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x000E80D4 File Offset: 0x000E62D4
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x000E8188 File Offset: 0x000E6388
		internal bool SiteSelectableAlertAliasList_A42100_HiddenStatic
		{
			get
			{
				short num = (short)1475674112;
				short num2 = num;
				num = (short)147605541;
				short num3 = num;
				num = (short)836192293;
				switch (num3 == num)
				{
				}
				num = (short)1377828865;
				if (num != 0)
				{
				}
				num = (short)91226112;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.HiddenStatic;
			}
			set
			{
				short num = (short)1358626816;
				short num2 = num;
				num = (short)46690632;
				short num3 = num;
				num = (short)289698120;
				switch (num3 == num)
				{
				}
				num = (short)1497366529;
				if (num != 0)
				{
				}
				num = (short)768409600;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.HiddenStatic = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000E823C File Offset: 0x000E643C
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x000E82F0 File Offset: 0x000E64F0
		internal bool SiteSelectableAlertAliasList_A42100_HiddenDynamic
		{
			get
			{
				short num = (short)151126017;
				if (num != 0)
				{
				}
				num = (short)98217790;
				short num2 = num;
				num = (short)1702866750;
				switch (num2 == num)
				{
				}
				num = (short)722599936;
				short num3 = num;
				num = (short)1950875648;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100.HiddenDynamic;
			}
			set
			{
				short num = (short)644888600;
				short num2 = num;
				num = (short)290535448;
				switch (num2 == num)
				{
				}
				num = (short)1674641409;
				if (num != 0)
				{
				}
				num = (short)2064646144;
				short num3 = num;
				num = (short)1253310464;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAliasList_A42100.HiddenDynamic = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000E83A4 File Offset: 0x000E65A4
		public bool SiteSelectableAlertAliasList_A42100_HasDiffs
		{
			get
			{
				short num = (short)2125660161;
				if (num != 0)
				{
				}
				num = (short)569968431;
				short num2 = num;
				num = (short)177276719;
				switch (num2 == num)
				{
				}
				num = (short)537329664;
				short num3 = num;
				num = (short)2145845248;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAliasList_A42100._HasDiffs;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000E8458 File Offset: 0x000E6658
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x000E8510 File Offset: 0x000E6710
		public int TrkSysFeaturesGroupTMSEable_42804Value
		{
			get
			{
				short num = (short)944693352;
				short num2 = num;
				num = (short)1526587496;
				switch (num2 == num)
				{
				}
				num = (short)1630470145;
				if (num != 0)
				{
				}
				num = (short)2090270720;
				short num3 = num;
				num = (short)1853358080;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.Value;
			}
			set
			{
				short num = (short)1050551862;
				short num2 = num;
				num = (short)989668918;
				switch (num2 == num)
				{
				}
				num = (short)2078081025;
				if (num != 0)
				{
				}
				num = (short)399638528;
				short num3 = num;
				num = (short)1547763712;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.Value = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x000E85C8 File Offset: 0x000E67C8
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x000E867C File Offset: 0x000E687C
		public string TrkSysFeaturesGroupTMSEable_42804_UIValue
		{
			get
			{
				short num = (short)1048641537;
				if (num != 0)
				{
				}
				num = (short)1406954100;
				short num2 = num;
				num = (short)2015652468;
				switch (num2 == num)
				{
				}
				num = (short)536674304;
				short num3 = num;
				num = (short)1555693568;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.UIValue;
			}
			set
			{
				short num = (short)674348878;
				short num2 = num;
				num = (short)2105261902;
				switch (num2 == num)
				{
				}
				num = (short)560201729;
				if (num != 0)
				{
				}
				num = (short)193462272;
				short num3 = num;
				num = (short)574291968;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.UIValue = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000E8734 File Offset: 0x000E6934
		public global::AcpBusinessLayer.AcpListField TrkSysFeaturesGroupTMSEable_42804
		{
			get
			{
				short num = (short)1226047489;
				if (num != 0)
				{
				}
				num = (short)1783022270;
				short num2 = num;
				num = (short)1250411198;
				switch (num2 == num)
				{
				}
				num = (short)1032912896;
				short num3 = num;
				num = (short)1609236480;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000E87E4 File Offset: 0x000E69E4
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x000E889C File Offset: 0x000E6A9C
		public bool TrkSysFeaturesGroupTMSEable_42804_Applicable
		{
			get
			{
				short num = (short)1454698713;
				short num2 = num;
				num = (short)1393750233;
				switch (num2 == num)
				{
				}
				num = (short)1544552449;
				if (num != 0)
				{
				}
				num = (short)1905262592;
				short num3 = num;
				num = (short)2077229056;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.Applicable;
			}
			set
			{
				short num = (short)1090104463;
				short num2 = num;
				num = (short)1501736079;
				switch (num2 == num)
				{
				}
				num = (short)1682046977;
				if (num != 0)
				{
				}
				num = (short)388956160;
				short num3 = num;
				num = (short)319553536;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.Applicable = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000E8950 File Offset: 0x000E6B50
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x000E8A04 File Offset: 0x000E6C04
		public bool TrkSysFeaturesGroupTMSEable_42804_Valid
		{
			get
			{
				short num = (short)704093831;
				short num2 = num;
				num = (short)1259839111;
				switch (num2 == num)
				{
				}
				num = (short)1879244801;
				if (num != 0)
				{
				}
				num = (short)1798635520;
				short num3 = num;
				num = (short)1522532352;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.Valid;
			}
			set
			{
				short num = (short)802635124;
				short num2 = num;
				num = (short)1098202484;
				switch (num2 == num)
				{
				}
				num = (short)1685979137;
				if (num != 0)
				{
				}
				num = (short)1371537408;
				short num3 = num;
				num = (short)754319360;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.Valid = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000E8ABC File Offset: 0x000E6CBC
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x000E8B70 File Offset: 0x000E6D70
		public bool TrkSysFeaturesGroupTMSEable_42804_Visible
		{
			get
			{
				short num = (short)259669252;
				short num2 = num;
				num = (short)1509506308;
				switch (num2 == num)
				{
				}
				num = (short)1086455809;
				if (num != 0)
				{
				}
				num = (short)1852964864;
				short num3 = num;
				num = (short)922877952;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.Visible;
			}
			set
			{
				short num = (short)1593837765;
				short num2 = num;
				num = (short)1142884549;
				switch (num2 == num)
				{
				}
				num = (short)1835663361;
				if (num != 0)
				{
				}
				num = (short)70385664;
				short num3 = num;
				num = (short)1821114368;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.Visible = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000E8C24 File Offset: 0x000E6E24
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000E8CD8 File Offset: 0x000E6ED8
		public bool TrkSysFeaturesGroupTMSEable_42804_Editable
		{
			get
			{
				short num = (short)798241722;
				short num2 = num;
				num = (short)1164981178;
				switch (num2 == num)
				{
				}
				num = (short)2056454144;
				if (num != 0)
				{
				}
				num = (short)877068288;
				short num3 = num;
				num = (short)1521680385;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.Editable;
			}
			set
			{
				short num = (short)865926018;
				short num2 = num;
				num = (short)561118082;
				switch (num2 == num)
				{
				}
				num = (short)160497664;
				if (num != 0)
				{
				}
				num = (short)93716480;
				short num3 = num;
				num = (short)1984495617;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.Editable = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000E8D8C File Offset: 0x000E6F8C
		internal string TrkSysFeaturesGroupTMSEable_42804_UILabel
		{
			get
			{
				short num = (short)580226082;
				short num2 = num;
				num = (short)1458474018;
				switch (num2 == num)
				{
				}
				num = (short)2048786432;
				if (num != 0)
				{
				}
				num = (short)1921843200;
				short num3 = num;
				num = (short)1803812865;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.UIName;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000E8E40 File Offset: 0x000E7040
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x000E8EF4 File Offset: 0x000E70F4
		internal bool TrkSysFeaturesGroupTMSEable_42804_HiddenStatic
		{
			get
			{
				short num = (short)1561690429;
				short num2 = num;
				num = (short)775913789;
				switch (num2 == num)
				{
				}
				num = (short)692912129;
				if (num != 0)
				{
				}
				num = (short)791937024;
				short num3 = num;
				num = (short)606732288;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.HiddenStatic;
			}
			set
			{
				short num = (short)383167303;
				short num2 = num;
				num = (short)137800519;
				switch (num2 == num)
				{
				}
				num = (short)2101608448;
				if (num != 0)
				{
				}
				num = (short)1214251008;
				short num3 = num;
				num = (short)204275713;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.HiddenStatic = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000E8FA8 File Offset: 0x000E71A8
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000E9060 File Offset: 0x000E7260
		internal bool TrkSysFeaturesGroupTMSEable_42804_HiddenDynamic
		{
			get
			{
				short num = (short)953771816;
				short num2 = num;
				num = (short)1451452200;
				switch (num2 == num)
				{
				}
				num = (short)1719664641;
				if (num != 0)
				{
				}
				num = (short)238223360;
				short num3 = num;
				num = (short)1495597056;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804.HiddenDynamic;
			}
			set
			{
				short num = (short)1795751937;
				if (num != 0)
				{
				}
				num = (short)699718994;
				short num2 = num;
				num = (short)319216978;
				switch (num2 == num)
				{
				}
				num = (short)682885120;
				short num3 = num;
				num = (short)588578816;
				if (num != 0)
				{
				}
				this.trkSysFeaturesGroupTMSEable_42804.HiddenDynamic = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000E9114 File Offset: 0x000E7314
		public bool TrkSysFeaturesGroupTMSEable_42804_HasDiffs
		{
			get
			{
				short num = (short)1037169162;
				short num2 = num;
				num = (short)659157514;
				switch (num2 == num)
				{
				}
				num = (short)22085633;
				if (num != 0)
				{
				}
				num = (short)1519779840;
				short num3 = num;
				num = (short)920977408;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesGroupTMSEable_42804._HasDiffs;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000E91C8 File Offset: 0x000E73C8
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x000E927C File Offset: 0x000E747C
		public int TrkPerFeaturesOTARadioAliasType_42854Value
		{
			get
			{
				short num = (short)1516511557;
				short num2 = num;
				num = (short)459219269;
				switch (num2 == num)
				{
				}
				num = (short)348782592;
				if (num != 0)
				{
				}
				num = (short)180224000;
				short num3 = num;
				num = (short)870449153;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.Value;
			}
			set
			{
				short num = (short)2031482500;
				short num2 = num;
				num = (short)1359935108;
				switch (num2 == num)
				{
				}
				num = (short)2011561985;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				short num3 = num;
				num = (short)447152128;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.Value = value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000E9334 File Offset: 0x000E7534
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x000E93E4 File Offset: 0x000E75E4
		public string TrkPerFeaturesOTARadioAliasType_42854_UIValue
		{
			get
			{
				short num = (short)1104313422;
				short num2 = num;
				num = (short)250838094;
				switch (num2 == num)
				{
				}
				num = (short)679739392;
				short num3 = num;
				num = (short)1883635713;
				if (num != 0)
				{
				}
				num = (short)1612644352;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.UIValue;
			}
			set
			{
				short num = (short)1076875017;
				short num2 = num;
				num = (short)1736101641;
				switch (num2 == num)
				{
				}
				num = (short)143654912;
				short num3 = num;
				num = (short)2024275969;
				if (num != 0)
				{
				}
				num = (short)127991808;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.UIValue = value;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000E9498 File Offset: 0x000E7698
		public global::AcpBusinessLayer.AcpListField TrkPerFeaturesOTARadioAliasType_42854
		{
			get
			{
				short num = (short)1353159674;
				short num2 = num;
				num = (short)153129978;
				switch (num2 == num)
				{
				}
				num = (short)473759744;
				short num3 = num;
				num = (short)1233911808;
				if (num != 0)
				{
				}
				num = (short)706150401;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000E9548 File Offset: 0x000E7748
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x000E95FC File Offset: 0x000E77FC
		public bool TrkPerFeaturesOTARadioAliasType_42854_Applicable
		{
			get
			{
				short num = (short)861878761;
				short num2 = num;
				num = (short)1089026537;
				switch (num2 == num)
				{
				}
				num = (short)125108224;
				short num3 = num;
				num = (short)84672513;
				if (num != 0)
				{
				}
				num = (short)371785728;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.Applicable;
			}
			set
			{
				short num = (short)383214971;
				short num2 = num;
				num = (short)686777723;
				switch (num2 == num)
				{
				}
				num = (short)1544683520;
				short num3 = num;
				num = (short)1074069504;
				if (num != 0)
				{
				}
				num = (short)1002569729;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.Applicable = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000E96B0 File Offset: 0x000E78B0
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000E9764 File Offset: 0x000E7964
		public bool TrkPerFeaturesOTARadioAliasType_42854_Valid
		{
			get
			{
				short num = (short)2142399797;
				short num2 = num;
				num = (short)535260469;
				switch (num2 == num)
				{
				}
				num = (short)1476984832;
				short num3 = num;
				num = (short)1717895169;
				if (num != 0)
				{
				}
				num = (short)230227968;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.Valid;
			}
			set
			{
				short num = (short)2115960833;
				if (num != 0)
				{
				}
				num = (short)1019114589;
				short num2 = num;
				num = (short)985035869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)372572160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741408768;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.Valid = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000E9818 File Offset: 0x000E7A18
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x000E98CC File Offset: 0x000E7ACC
		public bool TrkPerFeaturesOTARadioAliasType_42854_Visible
		{
			get
			{
				short num = (short)1896246256;
				short num2 = num;
				num = (short)1610247152;
				switch (num2 == num)
				{
				}
				num = (short)979435520;
				short num3 = num;
				num = (short)317784065;
				if (num != 0)
				{
				}
				num = (short)1634664448;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.Visible;
			}
			set
			{
				short num = (short)1236927283;
				short num2 = num;
				num = (short)786760499;
				switch (num2 == num)
				{
				}
				num = (short)1223884800;
				short num3 = num;
				num = (short)1017643009;
				if (num != 0)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.Visible = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000E9980 File Offset: 0x000E7B80
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x000E9A34 File Offset: 0x000E7C34
		public bool TrkPerFeaturesOTARadioAliasType_42854_Editable
		{
			get
			{
				short num = (short)126162442;
				short num2 = num;
				num = (short)1900221962;
				switch (num2 == num)
				{
				}
				num = (short)1406140416;
				short num3 = num;
				num = (short)2083913729;
				if (num != 0)
				{
				}
				num = (short)1167196160;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.Editable;
			}
			set
			{
				short num = (short)292362829;
				short num2 = num;
				num = (short)452794957;
				switch (num2 == num)
				{
				}
				num = (short)185925632;
				short num3 = num;
				num = (short)901971969;
				if (num != 0)
				{
				}
				num = (short)953417728;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.Editable = value;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000E9AEC File Offset: 0x000E7CEC
		internal string TrkPerFeaturesOTARadioAliasType_42854_UILabel
		{
			get
			{
				short num = (short)542011056;
				short num2 = num;
				num = (short)1042640560;
				switch (num2 == num)
				{
				}
				num = (short)338493440;
				short num3 = num;
				num = (short)5570561;
				if (num != 0)
				{
				}
				num = (short)771227648;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.UIName;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000E9BA4 File Offset: 0x000E7DA4
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x000E9C58 File Offset: 0x000E7E58
		internal bool TrkPerFeaturesOTARadioAliasType_42854_HiddenStatic
		{
			get
			{
				short num = (short)1162813885;
				short num2 = num;
				num = (short)1270817213;
				switch (num2 == num)
				{
				}
				num = (short)1703936000;
				short num3 = num;
				num = (short)1350893568;
				if (num != 0)
				{
				}
				num = (short)914882561;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.HiddenStatic;
			}
			set
			{
				short num = (short)769394362;
				short num2 = num;
				num = (short)59508410;
				switch (num2 == num)
				{
				}
				num = (short)664076288;
				short num3 = num;
				num = (short)1529085953;
				if (num != 0)
				{
				}
				num = (short)72417280;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.HiddenStatic = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x000E9D10 File Offset: 0x000E7F10
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x000E9DC4 File Offset: 0x000E7FC4
		internal bool TrkPerFeaturesOTARadioAliasType_42854_HiddenDynamic
		{
			get
			{
				short num = (short)2099314689;
				if (num != 0)
				{
				}
				num = (short)587133580;
				short num2 = num;
				num = (short)639169164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1780154368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697579008;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854.HiddenDynamic;
			}
			set
			{
				short num = (short)1034822694;
				short num2 = num;
				num = (short)664544294;
				switch (num2 == num)
				{
				}
				num = (short)1994719232;
				short num3 = num;
				num = (short)1903362049;
				if (num != 0)
				{
				}
				num = (short)1012465664;
				if (num != 0)
				{
				}
				this.trkPerFeaturesOTARadioAliasType_42854.HiddenDynamic = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x000E9E78 File Offset: 0x000E8078
		public bool TrkPerFeaturesOTARadioAliasType_42854_HasDiffs
		{
			get
			{
				short num = (short)1124002654;
				short num2 = num;
				num = (short)1433398110;
				switch (num2 == num)
				{
				}
				num = (short)22347776;
				short num3 = num;
				num = (short)317128704;
				if (num != 0)
				{
				}
				num = (short)1284571137;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesOTARadioAliasType_42854._HasDiffs;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000E9F28 File Offset: 0x000E8128
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x000E9FDC File Offset: 0x000E81DC
		public int TrkSysFeaturesPASelection_A42882Value
		{
			get
			{
				short num = (short)1977045849;
				short num2 = num;
				num = (short)1374049113;
				switch (num2 == num)
				{
				}
				num = (short)1024000000;
				short num3 = num;
				num = (short)1793327104;
				if (num != 0)
				{
				}
				num = (short)2145714177;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.Value;
			}
			set
			{
				short num = (short)181052816;
				short num2 = num;
				num = (short)1399235984;
				switch (num2 == num)
				{
				}
				num = (short)1015021568;
				short num3 = num;
				num = (short)144506881;
				if (num != 0)
				{
				}
				num = (short)976814080;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.Value = value;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000EA094 File Offset: 0x000E8294
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x000EA148 File Offset: 0x000E8348
		public string TrkSysFeaturesPASelection_A42882_UIValue
		{
			get
			{
				short num = (short)2029879362;
				short num2 = num;
				num = (short)1168474178;
				switch (num2 == num)
				{
				}
				num = (short)590938112;
				short num3 = num;
				num = (short)1159069697;
				if (num != 0)
				{
				}
				num = (short)1836580864;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.UIValue;
			}
			set
			{
				short num = (short)1129906177;
				if (num != 0)
				{
				}
				num = (short)1382840804;
				short num2 = num;
				num = (short)1266776548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332084736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548667392;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.UIValue = value;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000EA1FC File Offset: 0x000E83FC
		public global::AcpBusinessLayer.AcpRecRefField TrkSysFeaturesPASelection_A42882
		{
			get
			{
				short num = (short)378092049;
				short num2 = num;
				num = (short)2108570129;
				switch (num2 == num)
				{
				}
				num = (short)630652928;
				short num3 = num;
				num = (short)835649536;
				if (num != 0)
				{
				}
				num = (short)1711669249;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x000EA2AC File Offset: 0x000E84AC
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x000EA360 File Offset: 0x000E8560
		public bool TrkSysFeaturesPASelection_A42882_Applicable
		{
			get
			{
				short num = (short)1584070657;
				if (num != 0)
				{
				}
				num = (short)417235986;
				short num2 = num;
				num = (short)511149074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567424512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081554432;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.Applicable;
			}
			set
			{
				short num = (short)275627678;
				short num2 = num;
				num = (short)1991294622;
				switch (num2 == num)
				{
				}
				num = (short)1703149568;
				short num3 = num;
				num = (short)653656065;
				if (num != 0)
				{
				}
				num = (short)973078528;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.Applicable = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000EA414 File Offset: 0x000E8614
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x000EA4CC File Offset: 0x000E86CC
		public bool TrkSysFeaturesPASelection_A42882_Valid
		{
			get
			{
				short num = (short)870970686;
				short num2 = num;
				num = (short)1185281342;
				switch (num2 == num)
				{
				}
				num = (short)1764032512;
				short num3 = num;
				num = (short)1007616000;
				if (num != 0)
				{
				}
				num = (short)377159681;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.Valid;
			}
			set
			{
				short num = (short)1817908455;
				short num2 = num;
				num = (short)42341607;
				switch (num2 == num)
				{
				}
				num = (short)44826624;
				short num3 = num;
				num = (short)1230962688;
				if (num != 0)
				{
				}
				num = (short)825688065;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.Valid = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000EA584 File Offset: 0x000E8784
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x000EA638 File Offset: 0x000E8838
		public bool TrkSysFeaturesPASelection_A42882_Visible
		{
			get
			{
				short num = (short)134169948;
				short num2 = num;
				num = (short)1512981852;
				switch (num2 == num)
				{
				}
				num = (short)44498944;
				short num3 = num;
				num = (short)931659777;
				if (num != 0)
				{
				}
				num = (short)1994653696;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.Visible;
			}
			set
			{
				short num = (short)1867003485;
				short num2 = num;
				num = (short)308164189;
				switch (num2 == num)
				{
				}
				num = (short)542834688;
				short num3 = num;
				num = (short)1058209792;
				if (num != 0)
				{
				}
				num = (short)335282177;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.Visible = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x000EA6EC File Offset: 0x000E88EC
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x000EA7A0 File Offset: 0x000E89A0
		public bool TrkSysFeaturesPASelection_A42882_Editable
		{
			get
			{
				short num = (short)761304687;
				short num2 = num;
				num = (short)650090095;
				switch (num2 == num)
				{
				}
				num = (short)2044133376;
				short num3 = num;
				num = (short)1211629569;
				if (num != 0)
				{
				}
				num = (short)1190264832;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.Editable;
			}
			set
			{
				short num = (short)509468924;
				short num2 = num;
				num = (short)1804787964;
				switch (num2 == num)
				{
				}
				num = (short)1244004353;
				if (num != 0)
				{
				}
				num = (short)1267728384;
				short num3 = num;
				num = (short)977207296;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.Editable = value;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x000EA854 File Offset: 0x000E8A54
		internal string TrkSysFeaturesPASelection_A42882_UILabel
		{
			get
			{
				short num = (short)127112182;
				short num2 = num;
				num = (short)1725797366;
				switch (num2 == num)
				{
				}
				num = (short)1200422913;
				if (num != 0)
				{
				}
				num = (short)357695488;
				short num3 = num;
				num = (short)1674575872;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.UIName;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000EA904 File Offset: 0x000E8B04
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000EA9BC File Offset: 0x000E8BBC
		internal bool TrkSysFeaturesPASelection_A42882_HiddenStatic
		{
			get
			{
				short num = (short)917224756;
				short num2 = num;
				num = (short)317373748;
				switch (num2 == num)
				{
				}
				num = (short)442761217;
				if (num != 0)
				{
				}
				num = (short)1307312128;
				short num3 = num;
				num = (short)2053177344;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.HiddenStatic;
			}
			set
			{
				short num = (short)1074337490;
				short num2 = num;
				num = (short)991434450;
				switch (num2 == num)
				{
				}
				num = (short)1344667648;
				if (num != 0)
				{
				}
				num = (short)48300032;
				short num3 = num;
				num = (short)2046164993;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.HiddenStatic = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000EAA74 File Offset: 0x000E8C74
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000EAB2C File Offset: 0x000E8D2C
		internal bool TrkSysFeaturesPASelection_A42882_HiddenDynamic
		{
			get
			{
				short num = (short)1809387690;
				short num2 = num;
				num = (short)1694765226;
				switch (num2 == num)
				{
				}
				num = (short)1715798017;
				if (num != 0)
				{
				}
				num = (short)1053622272;
				short num3 = num;
				num = (short)2023817216;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882.HiddenDynamic;
			}
			set
			{
				short num = (short)177930241;
				if (num != 0)
				{
				}
				num = (short)1605329946;
				short num2 = num;
				num = (short)2083415066;
				switch (num2 == num)
				{
				}
				num = (short)1696333824;
				short num3 = num;
				num = (short)1525153792;
				if (num != 0)
				{
				}
				this.trkSysFeaturesPASelection_A42882.HiddenDynamic = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000EABE0 File Offset: 0x000E8DE0
		public bool TrkSysFeaturesPASelection_A42882_HasDiffs
		{
			get
			{
				short num = (short)397498157;
				short num2 = num;
				num = (short)484202285;
				switch (num2 == num)
				{
				}
				num = (short)917831680;
				if (num != 0)
				{
				}
				num = (short)318898176;
				short num3 = num;
				num = (short)130809857;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesPASelection_A42882._HasDiffs;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000EAC94 File Offset: 0x000E8E94
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x000EAD48 File Offset: 0x000E8F48
		public bool TrkSysFeatureLocationOnPTT_43026Value
		{
			get
			{
				short num = (short)2080964609;
				if (num != 0)
				{
				}
				num = (short)1516426874;
				short num2 = num;
				num = (short)1503319674;
				switch (num2 == num)
				{
				}
				num = (short)25034752;
				short num3 = num;
				num = (short)1606549504;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Value;
			}
			set
			{
				short num = (short)1580238181;
				short num2 = num;
				num = (short)1060996453;
				switch (num2 == num)
				{
				}
				num = (short)772210688;
				if (num != 0)
				{
				}
				num = (short)1803354112;
				short num3 = num;
				num = (short)750583809;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Value = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x000EADFC File Offset: 0x000E8FFC
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeatureLocationOnPTT_43026
		{
			get
			{
				short num = (short)460152130;
				short num2 = num;
				num = (short)1851350338;
				switch (num2 == num)
				{
				}
				num = (short)219348993;
				if (num != 0)
				{
				}
				num = (short)2140209152;
				short num3 = num;
				num = (short)1933049856;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000EAEB0 File Offset: 0x000E90B0
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x000EAF64 File Offset: 0x000E9164
		public bool TrkSysFeatureLocationOnPTT_43026_UIValue
		{
			get
			{
				short num = (short)1246101505;
				if (num != 0)
				{
				}
				num = (short)1876919203;
				short num2 = num;
				num = (short)38962083;
				switch (num2 == num)
				{
				}
				num = (short)1463418880;
				short num3 = num;
				num = (short)571015168;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Value;
			}
			set
			{
				short num = (short)1222195249;
				short num2 = num;
				num = (short)1024276529;
				switch (num2 == num)
				{
				}
				num = (short)1454374913;
				if (num != 0)
				{
				}
				num = (short)1182007296;
				short num3 = num;
				num = (short)1437794304;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Value = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000EB01C File Offset: 0x000E921C
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x000EB0D0 File Offset: 0x000E92D0
		public bool TrkSysFeatureLocationOnPTT_43026_Applicable
		{
			get
			{
				short num = (short)1148452865;
				if (num != 0)
				{
				}
				num = (short)603599510;
				short num2 = num;
				num = (short)1811231382;
				switch (num2 == num)
				{
				}
				num = (short)1389559808;
				short num3 = num;
				num = (short)49152000;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Applicable;
			}
			set
			{
				short num = (short)1121008192;
				short num2 = num;
				num = (short)674183744;
				switch (num2 == num)
				{
				}
				num = (short)750649345;
				if (num != 0)
				{
				}
				num = (short)618463232;
				short num3 = num;
				num = (short)257490944;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Applicable = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000EB188 File Offset: 0x000E9388
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x000EB23C File Offset: 0x000E943C
		public bool TrkSysFeatureLocationOnPTT_43026_Valid
		{
			get
			{
				short num = (short)686106361;
				short num2 = num;
				num = (short)1844979449;
				switch (num2 == num)
				{
				}
				num = (short)1312292864;
				if (num != 0)
				{
				}
				num = (short)2048524288;
				short num3 = num;
				num = (short)458227713;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Valid;
			}
			set
			{
				short num = (short)136113784;
				short num2 = num;
				num = (short)797306488;
				switch (num2 == num)
				{
				}
				num = (short)1310392320;
				if (num != 0)
				{
				}
				num = (short)111607808;
				short num3 = num;
				num = (short)565968897;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Valid = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000EB2F4 File Offset: 0x000E94F4
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x000EB3A8 File Offset: 0x000E95A8
		public bool TrkSysFeatureLocationOnPTT_43026_Visible
		{
			get
			{
				short num = (short)108643593;
				short num2 = num;
				num = (short)45204745;
				switch (num2 == num)
				{
				}
				num = (short)106102785;
				if (num != 0)
				{
				}
				num = (short)2108227584;
				short num3 = num;
				num = (short)730660864;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Visible;
			}
			set
			{
				short num = (short)524222465;
				if (num != 0)
				{
				}
				num = (short)632871365;
				short num2 = num;
				num = (short)8772037;
				switch (num2 == num)
				{
				}
				num = (short)233046016;
				short num3 = num;
				num = (short)217776128;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Visible = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000EB45C File Offset: 0x000E965C
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000EB510 File Offset: 0x000E9710
		public bool TrkSysFeatureLocationOnPTT_43026_Editable
		{
			get
			{
				short num = (short)1255966056;
				short num2 = num;
				num = (short)1776780648;
				switch (num2 == num)
				{
				}
				num = (short)1692336129;
				if (num != 0)
				{
				}
				num = (short)286261248;
				short num3 = num;
				num = (short)169279488;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.Editable;
			}
			set
			{
				short num = (short)674074288;
				short num2 = num;
				num = (short)1164283568;
				switch (num2 == num)
				{
				}
				num = (short)1210712065;
				if (num != 0)
				{
				}
				num = (short)437059584;
				short num3 = num;
				num = (short)2127364096;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.Editable = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000EB5C4 File Offset: 0x000E97C4
		internal string TrkSysFeatureLocationOnPTT_43026_UILabel
		{
			get
			{
				short num = (short)2043184929;
				short num2 = num;
				num = (short)1774880545;
				switch (num2 == num)
				{
				}
				num = (short)383188993;
				if (num != 0)
				{
				}
				num = (short)1091829760;
				short num3 = num;
				num = (short)6619136;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.UIName;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000EB67C File Offset: 0x000E987C
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x000EB730 File Offset: 0x000E9930
		internal bool TrkSysFeatureLocationOnPTT_43026_HiddenStatic
		{
			get
			{
				short num = (short)1442806730;
				short num2 = num;
				num = (short)1475967946;
				switch (num2 == num)
				{
				}
				num = (short)477626369;
				if (num != 0)
				{
				}
				num = (short)1350303744;
				short num3 = num;
				num = (short)1036058624;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.HiddenStatic;
			}
			set
			{
				short num = (short)190054401;
				if (num != 0)
				{
				}
				num = (short)375687672;
				short num2 = num;
				num = (short)39160312;
				switch (num2 == num)
				{
				}
				num = (short)1074593792;
				short num3 = num;
				num = (short)772997120;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.HiddenStatic = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000EB7E8 File Offset: 0x000E99E8
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x000EB89C File Offset: 0x000E9A9C
		internal bool TrkSysFeatureLocationOnPTT_43026_HiddenDynamic
		{
			get
			{
				short num = (short)1989495930;
				short num2 = num;
				num = (short)1762872442;
				switch (num2 == num)
				{
				}
				num = (short)1008271361;
				if (num != 0)
				{
				}
				num = (short)2064318464;
				short num3 = num;
				num = (short)392364032;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026.HiddenDynamic;
			}
			set
			{
				short num = (short)1212784899;
				short num2 = num;
				num = (short)593469699;
				switch (num2 == num)
				{
				}
				num = (short)1477050369;
				if (num != 0)
				{
				}
				num = (short)311820288;
				short num3 = num;
				num = (short)1233518592;
				if (num != 0)
				{
				}
				this.trkSysFeatureLocationOnPTT_43026.HiddenDynamic = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000EB950 File Offset: 0x000E9B50
		public bool TrkSysFeatureLocationOnPTT_43026_HasDiffs
		{
			get
			{
				short num = (short)644578464;
				short num2 = num;
				num = (short)1749777568;
				switch (num2 == num)
				{
				}
				num = (short)1244987393;
				if (num != 0)
				{
				}
				num = (short)1274871808;
				short num3 = num;
				num = (short)1632829440;
				if (num != 0)
				{
				}
				return this.trkSysFeatureLocationOnPTT_43026._HasDiffs;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000EBA04 File Offset: 0x000E9C04
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x000EBAB8 File Offset: 0x000E9CB8
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057Value
		{
			get
			{
				short num = (short)451625532;
				short num2 = num;
				num = (short)704856636;
				switch (num2 == num)
				{
				}
				num = (short)1587019776;
				if (num != 0)
				{
				}
				num = (short)321126400;
				short num3 = num;
				num = (short)394067969;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Value;
			}
			set
			{
				short num = (short)1386302198;
				short num2 = num;
				num = (short)2016430838;
				switch (num2 == num)
				{
				}
				num = (short)677511169;
				if (num != 0)
				{
				}
				num = (short)300023808;
				short num3 = num;
				num = (short)1487339520;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Value = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x000EBB70 File Offset: 0x000E9D70
		public global::AcpBusinessLayer.AcpField<bool> TrkSysFeaturesOTARadioAliasUpdateEnable_A43057
		{
			get
			{
				short num = (short)1928844635;
				short num2 = num;
				num = (short)1672140123;
				switch (num2 == num)
				{
				}
				num = (short)1172504577;
				if (num != 0)
				{
				}
				num = (short)1364066304;
				short num3 = num;
				num = (short)1315307520;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000EBC20 File Offset: 0x000E9E20
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x000EBCD4 File Offset: 0x000E9ED4
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_UIValue
		{
			get
			{
				short num = (short)1759069354;
				short num2 = num;
				num = (short)1028539562;
				switch (num2 == num)
				{
				}
				num = (short)1040384001;
				if (num != 0)
				{
				}
				num = (short)1050738688;
				short num3 = num;
				num = (short)1563754496;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Value;
			}
			set
			{
				short num = (short)727535764;
				short num2 = num;
				num = (short)213930132;
				switch (num2 == num)
				{
				}
				num = (short)1135542272;
				if (num != 0)
				{
				}
				num = (short)1030291456;
				short num3 = num;
				num = (short)592969729;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Value = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x000EBD8C File Offset: 0x000E9F8C
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x000EBE40 File Offset: 0x000EA040
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_Applicable
		{
			get
			{
				short num = (short)1899243481;
				short num2 = num;
				num = (short)508372953;
				switch (num2 == num)
				{
				}
				num = (short)230555649;
				if (num != 0)
				{
				}
				num = (short)489553920;
				short num3 = num;
				num = (short)522911744;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Applicable;
			}
			set
			{
				short num = (short)357842431;
				short num2 = num;
				num = (short)1051344383;
				switch (num2 == num)
				{
				}
				num = (short)1862533121;
				if (num != 0)
				{
				}
				num = (short)1187119104;
				short num3 = num;
				num = (short)1277362176;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Applicable = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x000EBEF8 File Offset: 0x000EA0F8
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x000EBFAC File Offset: 0x000EA1AC
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_Valid
		{
			get
			{
				short num = (short)1743574401;
				short num2 = num;
				num = (short)517526913;
				switch (num2 == num)
				{
				}
				num = (short)821821441;
				if (num != 0)
				{
				}
				num = (short)724238336;
				short num3 = num;
				num = (short)1886781440;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Valid;
			}
			set
			{
				short num = (short)741614134;
				short num2 = num;
				num = (short)550511158;
				switch (num2 == num)
				{
				}
				num = (short)513605632;
				if (num != 0)
				{
				}
				num = (short)1420034048;
				short num3 = num;
				num = (short)716111873;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Valid = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x000EC064 File Offset: 0x000EA264
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x000EC118 File Offset: 0x000EA318
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_Visible
		{
			get
			{
				short num = (short)137527828;
				short num2 = num;
				num = (short)149979668;
				switch (num2 == num)
				{
				}
				num = (short)428277761;
				if (num != 0)
				{
				}
				num = (short)873922560;
				short num3 = num;
				num = (short)1603010560;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Visible;
			}
			set
			{
				short num = (short)496983321;
				short num2 = num;
				num = (short)1409506585;
				switch (num2 == num)
				{
				}
				num = (short)174653441;
				if (num != 0)
				{
				}
				num = (short)590741504;
				short num3 = num;
				num = (short)356843520;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Visible = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000EC1CC File Offset: 0x000EA3CC
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x000EC280 File Offset: 0x000EA480
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_Editable
		{
			get
			{
				short num = (short)1717721053;
				short num2 = num;
				num = (short)980178909;
				switch (num2 == num)
				{
				}
				num = (short)2107244544;
				if (num != 0)
				{
				}
				num = (short)865861632;
				short num3 = num;
				num = (short)1871642625;
				if (num != 0)
				{
				}
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Editable;
			}
			set
			{
				short num = (short)895029522;
				short num2 = num;
				num = (short)1928466706;
				switch (num2 == num)
				{
				}
				num = (short)668467201;
				if (num != 0)
				{
				}
				num = (short)110493696;
				short num3 = num;
				num = (short)1596194816;
				if (num != 0)
				{
				}
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.Editable = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000EC334 File Offset: 0x000EA534
		internal string TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_UILabel
		{
			get
			{
				short num = (short)1953604255;
				short num2 = num;
				num = (short)528261791;
				switch (num2 == num)
				{
				}
				num = (short)644874241;
				if (num != 0)
				{
				}
				num = (short)641204224;
				if (num != 0)
				{
				}
				num = (short)1860501504;
				short num3 = num;
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.UIName;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000EC3E8 File Offset: 0x000EA5E8
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x000EC49C File Offset: 0x000EA69C
		internal bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_HiddenStatic
		{
			get
			{
				short num = (short)115474433;
				if (num != 0)
				{
				}
				num = (short)94542686;
				short num2 = num;
				num = (short)1553177438;
				switch (num2 == num)
				{
				}
				num = (short)418381824;
				if (num != 0)
				{
				}
				num = (short)454492160;
				short num3 = num;
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.HiddenStatic;
			}
			set
			{
				short num = (short)818826667;
				short num2 = num;
				num = (short)647777707;
				switch (num2 == num)
				{
				}
				num = (short)1760559105;
				if (num != 0)
				{
				}
				num = (short)1672413184;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				short num3 = num;
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.HiddenStatic = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000EC550 File Offset: 0x000EA750
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x000EC604 File Offset: 0x000EA804
		internal bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_HiddenDynamic
		{
			get
			{
				short num = (short)837379577;
				short num2 = num;
				num = (short)487089657;
				switch (num2 == num)
				{
				}
				num = (short)792199168;
				if (num != 0)
				{
				}
				num = (short)836042753;
				if (num != 0)
				{
				}
				num = (short)1057030144;
				short num3 = num;
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.HiddenDynamic;
			}
			set
			{
				short num = (short)689567255;
				short num2 = num;
				num = (short)1123218967;
				switch (num2 == num)
				{
				}
				num = (short)2065235969;
				if (num != 0)
				{
				}
				num = (short)1544355840;
				if (num != 0)
				{
				}
				num = (short)2000027648;
				short num3 = num;
				this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057.HiddenDynamic = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000EC6BC File Offset: 0x000EA8BC
		public bool TrkSysFeaturesOTARadioAliasUpdateEnable_A43057_HasDiffs
		{
			get
			{
				short num = (short)814874625;
				if (num != 0)
				{
				}
				num = (short)1588863468;
				short num2 = num;
				num = (short)930423276;
				switch (num2 == num)
				{
				}
				num = (short)1281359872;
				if (num != 0)
				{
				}
				num = (short)423886848;
				short num3 = num;
				return this.trkSysFeaturesOTARadioAliasUpdateEnable_A43057._HasDiffs;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000EC770 File Offset: 0x000EA970
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1324089345;
				if (num != 0)
				{
				}
				num = (short)99633168;
				short num2 = num;
				num = (short)1777420304;
				switch (num2 == num)
				{
				}
				num = (short)1951989760;
				if (num != 0)
				{
				}
				num = (short)1255931904;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000EC834 File Offset: 0x000EAA34
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)959465294;
				short num2 = num;
				num = (short)1217873742;
				switch (num2 == num)
				{
				}
				num = (short)316735488;
				if (num != 0)
				{
				}
				num = (short)663945217;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000EC8F4 File Offset: 0x000EAAF4
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)813498321;
				short num2 = num;
				num = (short)1935540177;
				switch (num2 == num)
				{
				}
				num = (short)156565505;
				if (num != 0)
				{
				}
				num = (short)855638016;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000EC9B0 File Offset: 0x000EABB0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1798659353;
				short num2 = num;
				num = (short)863657241;
				switch (num2 == num)
				{
				}
				num = (short)106102785;
				if (num != 0)
				{
				}
				num = (short)364052480;
				if (num != 0)
				{
				}
				num = (short)8912896;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000ECA70 File Offset: 0x000EAC70
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1347407909;
				short num2 = num;
				num = (short)1655623717;
				switch (num2 == num)
				{
				}
				num = (short)1414856705;
				if (num != 0)
				{
				}
				num = (short)956956672;
				if (num != 0)
				{
				}
				num = (short)915800064;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000ECB2C File Offset: 0x000EAD2C
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)732364804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)269221891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)72757300;
					short num3 = num2;
					num2 = (short)1183068212;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)537395200;
						if (num2 != 0)
						{
						}
						num2 = (short)1624899584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)315817985;
					if (num2 != 0)
					{
					}
					num2 = (short)203554816;
					short num4 = num2;
					num2 = (short)1083047938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1166540801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400040B RID: 1035
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x0400040C RID: 1036
		private global::AcpBusinessLayer.AcpRecRefField trkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x0400040D RID: 1037
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x0400040E RID: 1038
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x0400040F RID: 1039
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesICUAReset_A8249;

		// Token: 0x04000410 RID: 1040
		private global::AcpBusinessLayer.AcpField<bool> trkSysLabtoolEnable_A8669;

		// Token: 0x04000411 RID: 1041
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesRadioInhibit_A8833;

		// Token: 0x04000412 RID: 1042
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesSecureLED_A9071;

		// Token: 0x04000413 RID: 1043
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesBusyLED_44911;

		// Token: 0x04000414 RID: 1044
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesTextMessagingService_A9373;

		// Token: 0x04000415 RID: 1045
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x04000416 RID: 1046
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x04000417 RID: 1047
		private global::AcpBusinessLayer.AcpRecRefField trkSysFeaturesZone_A9717;

		// Token: 0x04000418 RID: 1048
		private global::AcpBusinessLayer.AcpRecRefField trkSysFeaturesChannel_A7647;

		// Token: 0x04000419 RID: 1049
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesHearClear_A36422;

		// Token: 0x0400041A RID: 1050
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesEnable_A7968;

		// Token: 0x0400041B RID: 1051
		private global::AcpBusinessLayer.AcpRecRefField siteSelectableAlertList_A42060;

		// Token: 0x0400041C RID: 1052
		private global::AcpBusinessLayer.AcpRecRefField siteSelectableAlertAliasList_A42100;

		// Token: 0x0400041D RID: 1053
		private global::AcpBusinessLayer.AcpListField trkSysFeaturesGroupTMSEable_42804;

		// Token: 0x0400041E RID: 1054
		private global::AcpBusinessLayer.AcpListField trkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x0400041F RID: 1055
		private global::AcpBusinessLayer.AcpRecRefField trkSysFeaturesPASelection_A42882;

		// Token: 0x04000420 RID: 1056
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeatureLocationOnPTT_43026;

		// Token: 0x04000421 RID: 1057
		private global::AcpBusinessLayer.AcpField<bool> trkSysFeaturesOTARadioAliasUpdateEnable_A43057;
	}
}
