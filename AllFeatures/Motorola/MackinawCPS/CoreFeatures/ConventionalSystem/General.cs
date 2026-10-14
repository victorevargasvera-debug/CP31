using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000571 RID: 1393
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BB3B RID: 47931 RVA: 0x00AD7AA4 File Offset: 0x00AD5CA4
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x00AD7AC0 File Offset: 0x00AD5CC0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x00AD7AD8 File Offset: 0x00AD5CD8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1773476641;
			short num2 = num;
			num = (short)152181537;
			switch (num2 == num)
			{
			}
			num = (short)1761542144;
			short num3 = num;
			num = (short)1086849024;
			if (num != 0)
			{
			}
			num = (short)1119682561;
			if (num != 0)
			{
			}
			this.cnvSysGeneralAckPretimems_A7393 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꓤ蓦苨믪鿬諮藰髲飴鋶铸裺ꋼ뻾㘀。㰄㐆", a_), global::CommonResources.AcgResources.ID_MDCACKPRETIMEMS, 1, 255, 2);
			this.cnvSysGeneralAckPretimems_A7393.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysGeneralAckPretimems_A7393.DataTransferOrder = 38;
			this.cnvSysGeneralAckPretimems_A7393.ShowHexValue = false;
			this.cnvSysGeneralInterPacketTimems_A8312 = new global::AcpBusinessLayer.AcpRangeField<int, string>(5, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢곤触鷨軪鿬뿮郰郲黴鋶跸꿺铼鋾搀渂瘄堆䠈㌊㸌㸎⌐", a_), global::CommonResources.AcgResources.ID_INTERPACKETTIMEMS, 1, 255, 2);
			this.cnvSysGeneralInterPacketTimems_A8312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysGeneralInterPacketTimems_A8312.DataTransferOrder = 44;
			this.cnvSysGeneralInterPacketTimems_A8312.ShowHexValue = false;
			this.cnvSysGeneralPTTID_A8427 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뗤돦뷨ꋪꧬ냮냰쯲쇴엶컸", a_), global::CommonResources.AcgResources.ID_PTTID, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralPTTID_A8427LovStrs);
			this.cnvSysGeneralPTTID_A8427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralPTTID_A8427.DataTransferOrder = 11;
			this.cnvSysGeneralLimitedPatiencesec_A8433 = new global::AcpBusinessLayer.AcpSimpleRangeField(53, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꧤ軦蓨苪駬諮闰ꏲ铴菶郸黺鏼鳾搀瀂怄搆嘈䨊㔌㬎∐‒", a_), global::CommonResources.AcgResources.ID_LIMITEDPATIENCESEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.cnvSysGeneralLimitedPatiencesec_A8433.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysGeneralLimitedPatiencesec_A8433.DataTransferOrder = 63;
			this.cnvSysGeneralLimitedPatiencesec_A8433.ShowHexValue = false;
			this.cnvSysGeneralPreambles_A8731 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뗤闦賨諪胬跮鷰雲蛴ꣶ룸쏺쫼쳾\u3000", a_), global::CommonResources.AcgResources.ID_PREAMBLES, 0, 255, null, null, 0, 1);
			this.cnvSysGeneralPreambles_A8731.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysGeneralPreambles_A8731.DataTransferOrder = 57;
			this.cnvSysGeneralPreambles_A8731.ShowHexValue = false;
			this.cnvSysGeneralRepeaterAccessPretimems_A8741 = new global::AcpBusinessLayer.AcpRangeField<int, string>(9, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢럤苦駨軪賬鯮铰臲듴银髸黺軼賾儀焂怄猆怈昊栌戎成䰒吔⼖⸘⼚Ⱌ", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSPRETIMEMS, 1, 255, 2);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.DataTransferOrder = 10;
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.ShowHexValue = false;
			this.cnvSysGeneralMDCPrimaryID_A8744 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢꣤ꏦꫨ믪鿬蛮鳰鋲蟴軶냸뿺ꋼ뻾㤀㐂㄄㌆", a_), global::CommonResources.AcgResources.ID_MDCPRIMARYIDHEX, 1, 65534, 1);
			this.cnvSysGeneralMDCPrimaryID_A8744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralMDCPrimaryID_A8744.DataTransferOrder = 75;
			this.cnvSysGeneralMDCPrimaryID_A8744.ShowHexValue = false;
			this.cnvSysGeneralSidetones_A8774 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤軦跨軪駬胮鿰雲蛴ꣶ룸쏺쫼죾㔀", a_), global::CommonResources.AcgResources.ID_SIDETONES, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralSidetones_A8774LovStrs);
			this.cnvSysGeneralSidetones_A8774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSidetones_A8774.DataTransferOrder = 32;
			this.cnvSysGeneralSecondaryID_A9065 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤苦諨蓪菬诮郰臲賴뻶뷸ꓺ볼웾㄀㔂〄", a_), global::CommonResources.AcgResources.ID_SECONDARYIDHEX, 0, 250539758, 1);
			this.cnvSysGeneralSecondaryID_A9065.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSecondaryID_A9065.DataTransferOrder = 33;
			this.cnvSysGeneralSecondaryID_A9065.ShowHexValue = false;
			this.cnvSysGeneralSystemPretimems2_A9246 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤黦髨鿪裬苮ꇰ臲郴菶郸雺飼鋾爀㄂娄䘆〈㤊㤌㤎", a_), global::CommonResources.AcgResources.ID_MDCSYSTEMPRETIMEMS, 0, 127, null, null, 0, 50);
			this.cnvSysGeneralSystemPretimems2_A9246.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSystemPretimems2_A9246.DataTransferOrder = 49;
			this.cnvSysGeneralSystemPretimems2_A9246.ShowHexValue = false;
			this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackRangeValueToLogicalIndexForTlkHangTime(), this, global::AllFeatures.CodeplugGuid.b("諊뻌믎藐뿒뻔냖ꯘꯚ釜곞闠ꓢ胤触賨駪賬菮ꋰ諲蛴菶鳸雺꫼雾攀昂億昆攈怊樌紎縐昒攔弖砘甚稜䬞䠠丢䀤否䰨䠪爬渮࠰Ĳȴึ", a_), global::CommonResources.AcgResources.ID_SYSTEMWIDETALKGROUPHANGTIMESEC, 0, 255, 1);
			this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.DataTransferOrder = 36;
			this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.ShowHexValue = false;
			this.cnvSysGeneralVariableID_A9612 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢돤蛦鯨苪賬跮鷰雲보돶꛸뫺쓼짾\u3000㄂", a_), global::CommonResources.AcgResources.ID_VARIABLEIDHEX, 0, 3822, 1);
			this.cnvSysGeneralVariableID_A9612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralVariableID_A9612.DataTransferOrder = 80;
			this.cnvSysGeneralVariableID_A9612.ShowHexValue = false;
			this.cnvSysGeneralSystemType_A13262 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤黦髨鿪裬苮ꗰ諲藴鋶꛸뫺쳼쳾㌀㔂㜄", a_), global::CommonResources.AcgResources.ID_SYSTEMTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralSystemType_A13262LovStrs);
			this.cnvSysGeneralSystemType_A13262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSystemType_A13262.DataTransferOrder = 1;
			this.cnvSysGeneralSystemType_A13262.EvaluateRecRefs = true;
			this.cnvSysGeneralDataProfileSelection_A13266 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꇤ蛦鷨諪뷬鷮黰闲鳴鯶鳸꣺飼鏾搀怂焄渆昈攊刌与‐‒✔№⼘", a_), global::CommonResources.AcgResources.ID_DATAPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DATADISABLED
			}, new int[1], true, false);
			this.cnvSysGeneralDataProfileSelection_A13266.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysGeneralDataProfileSelection_A13266.DataTransferOrder = 3;
			this.cnvSysGeneralDataProfileSelection_A13266.EvaluateRecRefs = true;
			this.cnvSysGeneralEmergencyProfileSelection_A19421 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꃤ諦賨駪諬諮鿰郲賴ꟶ诸铺鯼雾洀昂嘄戆攈渊渌笎砐簒笔䠖堘⨚␜⬞ጠሢ", a_), global::CommonResources.AcgResources.ID_EMERGENCYPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_EMERGENCYTXDISABLED_1
			}, new int[1], true, false);
			this.cnvSysGeneralEmergencyProfileSelection_A19421.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralEmergencyProfileSelection_A19421.DataTransferOrder = 14;
			this.cnvSysGeneralEmergencyProfileSelection_A19421.EvaluateRecRefs = true;
			this.cnvSysLabtoolPreambleEnable_A19576 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鯖룘맚꧜냞軠迢뗤闦賨諪胬跮鷰雲냴駶飸駺釼髾帀䈂㐄㸆㰈㰊㬌", a_), global::CommonResources.AcgResources.ID_PREAMBLEENABLE);
			this.cnvSysLabtoolPreambleEnable_A19576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysLabtoolPreambleEnable_A19576.DataTransferOrder = 15;
			this.cnvSysGeneralKeyofConventionalSystem_A20482 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢껤苦部蓪诬곮黰鷲菴鋶韸迺铼郾漀戂椄吆瀈砊礌樎簐䰒吔┖⤘⼚├ⴞ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEMNAME, 14);
			this.cnvSysGeneralKeyofConventionalSystem_A20482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralKeyofConventionalSystem_A20482.DataTransferOrder = 16;
			this.cnvSysGeneralSystemGroupNumber_A21960 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤黦髨鿪裬苮뛰臲髴苶觸뗺裼鋾挀昂眄堆䠈㤊㰌㘎✐⌒", a_), global::CommonResources.AcgResources.ID_SYSTEMGROUPNUMBER, 1, 65535, null, null, 0, 1);
			this.cnvSysGeneralSystemGroupNumber_A21960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSystemGroupNumber_A21960.DataTransferOrder = 17;
			this.cnvSysGeneralSystemGroupNumber_A21960.ShowHexValue = true;
			this.cnvSysGeneralPreambleLength_A8721 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뗤闦賨諪胬跮鷰雲맴鋶韸鳺觼韾帀䈂㴄〆㬈㨊", a_), global::CommonResources.AcgResources.ID_PREAMBLELENGTH, 0, 1275, null, null, 0, 1);
			this.cnvSysGeneralPreambleLength_A8721.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysGeneralPreambleLength_A8721.DataTransferOrder = 30;
			this.cnvSysGeneralPreambleLength_A8721.ShowHexValue = false;
			this.cnvSysGeneralIndividualID_A8287 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢곤触跨苪鯬蛮闰蛲铴鯶냸뿺ꋼ뻾㤀㄂㴄〆", a_), global::CommonResources.AcgResources.ID_INDIVIDUALID, 1, 16777211, null, null, 0, 1);
			this.cnvSysGeneralIndividualID_A8287.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralIndividualID_A8287.DataTransferOrder = 28;
			this.cnvSysGeneralIndividualID_A8287.ShowHexValue = true;
			this.cnvSysGeneralSystemKeyPresent_A40120 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤黦髨鿪裬苮뫰雲賴ꟶ诸黺軼髾漀眂娄䘆㴈㬊㰌㴎ℐ", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYPRESENT);
			this.cnvSysGeneralSystemKeyPresent_A40120.IgnoreOnCompare = true;
			this.cnvSysGeneralSystemKeyPresent_A40120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvSysGeneralSystemKeyPresent_A40120.DataTransferOrder = -1;
			this.cnvSysGeneralHomeWACNID_A40121 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢귤裦蓨軪뫬껮닰뷲보돶꛸뫺짼쿾\u3000㄂㐄", a_), global::CommonResources.AcgResources.ID_HOMEWACNID, 0, 1048574, 1, null, null);
			this.cnvSysGeneralHomeWACNID_A40121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysGeneralHomeWACNID_A40121.DataTransferOrder = 204;
			this.cnvSysGeneralHomeWACNID_A40121.ShowHexValue = true;
			this.cnvSysGeneralHomeWACNID_A40121.ShowLeadingZeros = true;
			this.cnvSysGeneralSystemID_A40122 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢뛤黦髨鿪裬苮룰럲ꫴ뛶췸쯺쳼췾㌀", a_), global::CommonResources.AcgResources.ID_SYSTEMID, 0, 4094, 1, null, null);
			this.cnvSysGeneralSystemID_A40122.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralSystemID_A40122.DataTransferOrder = 205;
			this.cnvSysGeneralSystemID_A40122.ShowHexValue = true;
			this.cnvSysGeneralSystemID_A40122.ShowLeadingZeros = true;
			this.cnvSysGeneralAdditionalMDCPID_A41761 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꓤ菦跨苪駬蛮黰鷲铴鯶듸뿺뻼꿾䠀䜂娄䘆㴈㨊㨌㤎‐", a_), global::CommonResources.AcgResources.ID_EXPANDEDMDCIDRANGE);
			this.cnvSysGeneralAdditionalMDCPID_A41761.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysGeneralAdditionalMDCPID_A41761.DataTransferOrder = 70;
			this.cnvSysGeneralAdditionalMDCPID_A41761.EvaluateRecRefs = true;
			this.convConfigConvSystemFeatRSISys_A41838 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꟐ郒뫔맖뿘닚뫜鳞軠跢鏤듦部飪駬諮鳰뗲郴零跸ꧺ껼뛾刀稂瘄堆䠈㼊㰌㜎∐⬒", a_), global::CommonResources.AcgResources.ID_REMOTESITEINTERFACESYSTEM);
			this.convConfigConvSystemFeatRSISys_A41838.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.convConfigConvSystemFeatRSISys_A41838.DataTransferOrder = 2;
			this.convConfigConvSystemFeatRSISys_A41838.EvaluateRecRefs = true;
			this.cnvSysGeneralCourtesyTone_43584 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ郖볘뗚룜귞胠迢ꛤ裦鳨駪駬諮苰諲ꇴ飶韸黺ꋼ쯾㈀㘂㴄㌆", a_), global::CommonResources.AcgResources.ID_COURTESYTONE);
			this.cnvSysGeneralCourtesyTone_43584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralCourtesyTone_43584.DataTransferOrder = 103;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10118;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x00AD8380 File Offset: 0x00AD6580
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)920977470;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvSysGeneralAckPretimems_A7393 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꧧ觩蟫뻭苯韱胳鿵闷鿹釻跽忿䌁㌃㔅ㄇ㤉", a_), global::CommonResources.AcgResources.ID_MDCACKPRETIMEMS);
					this.cnvSysGeneralAckPretimems_A7393.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysGeneralAckPretimems_A7393.DataTransferOrder = 38;
					this.cnvSysGeneralAckPretimems_A7393.ShowHexValue = false;
					num = (short)1218183176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.cnvSysGeneralSecondaryID_A9065 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧迩迫臭黯雱闳蓵臷돹룻ꇽ䇿㬁㐃々㴇", a_), global::CommonResources.AcgResources.ID_SECONDARYIDHEX);
					this.cnvSysGeneralSecondaryID_A9065.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralSecondaryID_A9065.DataTransferOrder = 33;
					this.cnvSysGeneralSecondaryID_A9065.ShowHexValue = false;
					num = (short)982057008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.cnvSysGeneralKeyofConventionalSystem_A20482 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꏧ迩闫臭雯뇱鯳飵軷鿹鋻諽槿洁樃朅搇変甋納搏眑礓䤕夗⠙Ⱋ⨝᠟အ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALSYSTEMNAME, 14);
					this.cnvSysGeneralKeyofConventionalSystem_A20482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralKeyofConventionalSystem_A20482.DataTransferOrder = 16;
					num = (short)1125580868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1E8;
				case 4:
					this.cnvSysGeneralDataProfileSelection_A13266 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥곧诩飫迭ꃯ胱鯳郵釷雹駻귽旿渁愃攅簇按挋怍伏匑┓┕⨗Ⱉ⨛", a_), global::CommonResources.AcgResources.ID_DATAPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DATADISABLED
					}, new int[1], true, false);
					this.cnvSysGeneralDataProfileSelection_A13266.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysGeneralDataProfileSelection_A13266.DataTransferOrder = 3;
					this.cnvSysGeneralDataProfileSelection_A13266.EvaluateRecRefs = true;
					num = (short)1165950979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.cnvSysGeneralRepeaterAccessPretimems_A8741 = new global::AcpBusinessLayer.AcpRangeField<int, string>(9, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥뫧迩鳫语釯蛱釳蓵맷駹鿻鯽珿焁吃琅洇縉攋挍甏缑朓䤕夗∙⬛⨝ᄟ", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSPRETIMEMS);
					this.cnvSysGeneralRepeaterAccessPretimems_A8741.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysGeneralRepeaterAccessPretimems_A8741.DataTransferOrder = 10;
					this.cnvSysGeneralRepeaterAccessPretimems_A8741.ShowHexValue = false;
					num = (short)840564772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_763;
				case 7:
					goto IL_F24;
				case 8:
					goto IL_FBD;
				case 9:
					goto IL_136D;
				case 10:
					this.cnvSysGeneralInterPacketTimems_A8312 = new global::AcpBusinessLayer.AcpRangeField<int, string>(5, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackPretimeAndPreambles(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꇧ蓩飫语苯ꋱ闳闵鏷鿹裻꫽槿漁愃欅笇唉䴋㘍⌏⌑☓", a_), global::CommonResources.AcgResources.ID_INTERPACKETTIMEMS);
					this.cnvSysGeneralInterPacketTimems_A8312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysGeneralInterPacketTimems_A8312.DataTransferOrder = 44;
					this.cnvSysGeneralInterPacketTimems_A8312.ShowHexValue = false;
					num = (short)1309540410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꇧ蓩裫蟭蛯鯱郳菵駷雹뗻뫽忿䌁㰃㐅〇㴉", a_)))
					{
						num = (short)427032606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B0;
				case 12:
					goto IL_646;
				case 13:
					this.cnvSysGeneralSystemID_A40122 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱뷳답ꟷ믹죻컽ㇿ、㘃", a_), global::CommonResources.AcgResources.ID_SYSTEMID, null, null);
					this.cnvSysGeneralSystemID_A40122.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralSystemID_A40122.DataTransferOrder = -1;
					this.cnvSysGeneralSystemID_A40122.ShowHexValue = true;
					this.cnvSysGeneralSystemID_A40122.ShowLeadingZeros = true;
					num = (short)374472710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_9A1;
				case 15:
					this.cnvSysGeneralSidetones_A8774 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧菩裫语蓯鷱髳鏵请ꗹ뷻웽㟿㔁〃", a_), global::CommonResources.AcgResources.ID_SIDETONES, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralSidetones_A8774LovStrs);
					this.cnvSysGeneralSidetones_A8774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralSidetones_A8774.DataTransferOrder = 32;
					num = (short)1438056464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_A4E;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꯧ藩駫鳭蓯韱蟳迵곷闹鋻鯽忿㘁㜃㌅〇㸉", a_)))
					{
						num = (short)806813766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1485;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꇧ蓩飫语苯ꋱ闳闵鏷鿹裻꫽槿漁愃欅笇唉䴋㘍⌏⌑☓", a_)))
					{
						num = (short)1453129738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA7;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꓧ菩臫蟭蓯韱郳꛵駷軹闻鯽滿愁愃甅洇椉匋伍⠏☑✓┕", a_)))
					{
						num = (short)1268711459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_646;
				case 20:
					this.convConfigConvSystemFeatRSISys_A41838 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뿏병ꋓ闕럗듙뫛럝蟟ꇡ诣裥黧맩闫鷭蓯韱駳냵鷷鯹裻곽叿䬁圃缅笇唉䴋㨍ℏ⨑✓⸕", a_), global::CommonResources.AcgResources.ID_REMOTESITEINTERFACESYSTEM);
					this.convConfigConvSystemFeatRSISys_A41838.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.convConfigConvSystemFeatRSISys_A41838.DataTransferOrder = 2;
					this.convConfigConvSystemFeatRSISys_A41838.EvaluateRecRefs = true;
					num = (short)655884344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱ꃳ迵裷鿹ꏻ뿽ㇿ㄁㘃々㨇", a_)))
					{
						num = (short)2029846568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF3;
				case 22:
					goto IL_A9C;
				case 23:
					goto IL_8AB;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥뫧迩鳫语釯蛱釳蓵맷駹鿻鯽珿焁吃琅洇縉攋挍甏缑朓䤕夗∙⬛⨝ᄟ", a_)))
					{
						num = (short)524550149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE6;
				case 25:
					goto IL_8F7;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧迩迫臭黯雱闳蓵臷돹룻ꇽ䇿㬁㐃々㴇", a_)))
					{
						num = (short)502071297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_100C;
				case 27:
					goto IL_1438;
				case 28:
					this.cnvSysGeneralSystemKeyPresent_A40120 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱뿳鏵臷꫹軻鯽珿朁樃爅圇䬉㠋㸍ℏ‑␓", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYPRESENT);
					this.cnvSysGeneralSystemKeyPresent_A40120.IgnoreOnCompare = true;
					this.cnvSysGeneralSystemKeyPresent_A40120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvSysGeneralSystemKeyPresent_A40120.DataTransferOrder = -1;
					num = (short)650248241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱뷳답ꟷ믹죻컽ㇿ、㘃", a_)))
					{
						num = (short)1570373645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_763;
				case 30:
					this.cnvSysGeneralIndividualID_A8287 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꇧ蓩裫蟭蛯鯱郳菵駷雹뗻뫽忿䌁㰃㐅〇㴉", a_), global::CommonResources.AcgResources.ID_INDIVIDUALID, null, null, 0, 1);
					this.cnvSysGeneralIndividualID_A8287.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralIndividualID_A8287.DataTransferOrder = 28;
					this.cnvSysGeneralIndividualID_A8287.ShowHexValue = true;
					num = (short)533856293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧飩觫迭鷯郱飳鏵请ꗹ뷻웽㟿㄁㔃", a_)))
					{
						num = (short)1613299789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A1;
				case 32:
					goto IL_BF3;
				case 33:
					goto IL_D59;
				case 34:
					goto IL_C42;
				case 35:
					this.cnvSysGeneralLimitedPatiencesec_A8433 = new global::AcpBusinessLayer.AcpSimpleRangeField(53, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꓧ菩臫蟭蓯韱郳꛵駷軹闻鯽滿愁愃甅洇椉匋伍⠏☑✓┕", a_), global::CommonResources.AcgResources.ID_LIMITEDPATIENCESEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.cnvSysGeneralLimitedPatiencesec_A8433.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysGeneralLimitedPatiencesec_A8433.DataTransferOrder = 63;
					this.cnvSysGeneralLimitedPatiencesec_A8433.ShowHexValue = false;
					num = (short)182255628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_AE6;
				case 37:
					goto IL_7B0;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥곧诩飫迭ꃯ胱鯳郵釷雹駻귽旿渁愃攅簇按挋怍伏匑┓┕⨗Ⱉ⨛", a_)))
					{
						num = (short)787611652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E8;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꃧ藩臫语꟯돱럳룵뇷뻹ꏻ뿽㓿㈁㔃㐅㤇", a_)))
					{
						num = (short)1404764214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1134;
				case 40:
					num = (short)1128792065;
					if (num != 0)
					{
					}
					goto IL_10CE;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱ꓳ蓵鷷軹闻鏽旿漁眃㐅圇䬉㔋㰍␏␑", a_)))
					{
						num = (short)212336716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AB;
				case 42:
					goto IL_19B;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧飩觫迭鷯郱飳鏵듷鿹鋻駽瓿樁嬃䜅〇㴉㸋㼍", a_)))
					{
						num = (short)1095565363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F70;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꧧ軩裫蟭蓯鯱鯳飵駷雹뇻뫽䏿刁䴃䈅圇䬉㠋㼍✏␑┓", a_)))
					{
						num = (short)213450815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D59;
				case 45:
					this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackAndpackRangeValueToLogicalIndexForTlkHangTime(), this, global::AllFeatures.CodeplugGuid.b("迍ꏏꛑ胓뫕돗뷙껛껝곟釡郣ꇥ跧蓩觫鳭釯黱ꟳ迵请軹駻鏽埿欁怃挅將欉怋攍眏怑笓挕栗则紛瀝䜟瘡䴣䬥䴧天䤫䴭漯猱ളе༷̹", a_), global::CommonResources.AcgResources.ID_SYSTEMWIDETALKGROUPHANGTIMESEC);
					this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.DataTransferOrder = 36;
					this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.ShowHexValue = false;
					num = (short)1772355618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.cnvSysGeneralPTTID_A8427 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧뻩룫꟭듯귱뗳컵쳷죹쯻", a_), global::CommonResources.AcgResources.ID_PTTID, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralPTTID_A8427LovStrs);
					this.cnvSysGeneralPTTID_A8427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralPTTID_A8427.DataTransferOrder = 11;
					num = (short)956891143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					this.cnvSysGeneralEmergencyProfileSelection_A19421 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥귧蟩觫鳭韯韱髳闵臷꫹軻釽替欁栃挅嬇漉怋欍猏昑紓礕瘗䔙崛⼝᤟ᘡᘣᜥ", a_), global::CommonResources.AcgResources.ID_EMERGENCYPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_EMERGENCYTXDISABLED_1
					}, new int[1], true, false);
					this.cnvSysGeneralEmergencyProfileSelection_A19421.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralEmergencyProfileSelection_A19421.DataTransferOrder = 14;
					this.cnvSysGeneralEmergencyProfileSelection_A19421.EvaluateRecRefs = true;
					num = (short)1666711579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					goto IL_100C;
				case 49:
					goto IL_29A;
				case 50:
					num = (short)1182597198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					this.cnvSysGeneralPreambleLength_A8721 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧飩觫迭鷯郱飳鏵듷鿹鋻駽瓿樁嬃䜅〇㴉㸋㼍", a_), global::CommonResources.AcgResources.ID_PREAMBLELENGTH, null, null, 0, 1);
					this.cnvSysGeneralPreambleLength_A8721.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysGeneralPreambleLength_A8721.DataTransferOrder = 30;
					this.cnvSysGeneralPreambleLength_A8721.ShowHexValue = false;
					num = (short)164167735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥귧蟩觫鳭韯韱髳闵臷꫹軻釽替欁栃挅嬇漉怋欍猏昑紓礕瘗䔙崛⼝᤟ᘡᘣᜥ", a_)))
					{
						num = (short)1786118191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1438;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꗧ껩꿫뻭苯鯱駳韵諷菹뗻뫽忿䌁㰃ㄅ㰇㸉", a_)))
					{
						num = (short)370737209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9C;
				case 54:
					this.cnvSysGeneralHomeWACNID_A40121 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꃧ藩臫语꟯돱럳룵뇷뻹ꏻ뿽㓿㈁㔃㐅㤇", a_), global::CommonResources.AcgResources.ID_HOMEWACNID, null, null);
					this.cnvSysGeneralHomeWACNID_A40121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysGeneralHomeWACNID_A40121.DataTransferOrder = -1;
					this.cnvSysGeneralHomeWACNID_A40121.ShowHexValue = true;
					this.cnvSysGeneralHomeWACNID_A40121.ShowLeadingZeros = true;
					num = (short)1455620171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					goto IL_F70;
				case 56:
					goto IL_556;
				case 57:
					this.cnvSysGeneralMDCPrimaryID_A8744 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꗧ껩꿫뻭苯鯱駳韵諷菹뗻뫽忿䌁㰃ㄅ㰇㸉", a_), global::CommonResources.AcgResources.ID_MDCPRIMARYIDHEX);
					this.cnvSysGeneralMDCPrimaryID_A8744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralMDCPrimaryID_A8744.DataTransferOrder = 75;
					this.cnvSysGeneralMDCPrimaryID_A8744.ShowHexValue = false;
					num = (short)300941334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					goto IL_DA7;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꏧ迩闫臭雯뇱鯳飵軷鿹鋻諽槿洁樃朅搇変甋納搏眑礓䤕夗⠙Ⱋ⨝᠟အ", a_)))
					{
						num = (short)216727554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1081;
				case 60:
					goto IL_12AA;
				case 61:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱뿳鏵臷꫹軻鯽珿朁樃爅圇䬉㠋㸍ℏ‑␓", a_)))
					{
						goto IL_29A;
					}
					num = (short)960204528;
					short num3 = num;
					num = (short)1388678896;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10CE;
					default:
						num = (short)369950720;
						if (num != 0)
						{
						}
						num = (short)658112540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 62:
					switch (0)
					{
					case 0:
						goto IL_175;
					}
					continue;
				case 63:
					this.cnvSysGeneralAdditionalMDCPID_A41761 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꧧ軩裫蟭蓯鯱鯳飵駷雹뇻뫽䏿刁䴃䈅圇䬉㠋㼍✏␑┓", a_), global::CommonResources.AcgResources.ID_EXPANDEDMDCIDRANGE);
					this.cnvSysGeneralAdditionalMDCPID_A41761.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysGeneralAdditionalMDCPID_A41761.DataTransferOrder = 70;
					this.cnvSysGeneralAdditionalMDCPID_A41761.EvaluateRecRefs = true;
					num = (short)234749985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ雙뷛볝铟跡诣諥룧飩觫迭鷯郱飳鏵뷷铹鷻鳽泿朁嬃䜅㤇㌉㤋㤍☏", a_)))
					{
						num = (short)854523976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F7;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꧧ觩蟫뻭苯韱胳鿵闷鿹釻跽忿䌁㌃㔅ㄇ㤉", a_)))
					{
						num = (short)868483072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FBD;
				case 66:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧뻩룫꟭듯귱뗳컵쳷죹쯻", a_)))
					{
						num = (short)115015726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F24;
				case 67:
					this.cnvSysGeneralVariableID_A9612 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.UnpackDecToHexPackHexToDec(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥뻧诩黫蟭釯郱飳鏵뇷뻹ꏻ뿽㧿㐁㔃㐅", a_), global::CommonResources.AcgResources.ID_VARIABLEIDHEX);
					this.cnvSysGeneralVariableID_A9612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralVariableID_A9612.DataTransferOrder = 80;
					this.cnvSysGeneralVariableID_A9612.ShowHexValue = false;
					num = (short)65208329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					goto IL_1081;
				case 69:
					num = (short)1441529921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 70:
					this.cnvSysGeneralCourtesyTone_43584 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥ꯧ藩駫鳭蓯韱蟳迵곷闹鋻鯽忿㘁㜃㌅〇㸉", a_), global::CommonResources.AcgResources.ID_COURTESYTONE);
					this.cnvSysGeneralCourtesyTone_43584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralCourtesyTone_43584.DataTransferOrder = 103;
					num = (short)748224572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 71:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뿏병ꋓ闕럗듙뫛럝蟟ꇡ诣裥黧맩闫鷭蓯韱駳냵鷷鯹裻곽叿䬁圃缅笇唉䴋㨍ℏ⨑✓⸕", a_)))
					{
						num = (short)217972756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_556;
				case 72:
					this.cnvSysLabtoolPreambleEnable_A19576 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ雙뷛볝铟跡诣諥룧飩觫迭鷯郱飳鏵뷷铹鷻鳽泿朁嬃䜅㤇㌉㤋㤍☏", a_), global::CommonResources.AcgResources.ID_PREAMBLEENABLE);
					this.cnvSysLabtoolPreambleEnable_A19576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysLabtoolPreambleEnable_A19576.DataTransferOrder = 15;
					num = (short)1900150809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 73:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧菩裫语蓯鷱髳鏵请ꗹ뷻웽㟿㔁〃", a_)))
					{
						num = (short)1168048143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4E;
				case 74:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥뻧诩黫蟭釯郱飳鏵뇷뻹ꏻ뿽㧿㐁㔃㐅", a_)))
					{
						num = (short)172949571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_136D;
				case 75:
					goto IL_1134;
				case 76:
				{
					num = (short)383188992;
					short num4 = num;
					this.cnvSysGeneralSystemPretimems2_A9246 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱ꓳ蓵鷷軹闻鏽旿漁眃㐅圇䬉㔋㰍␏␑", a_), global::CommonResources.AcgResources.ID_MDCSYSTEMPRETIMEMS, null, null, 0, 50);
					this.cnvSysGeneralSystemPretimems2_A9246.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralSystemPretimems2_A9246.DataTransferOrder = 49;
					this.cnvSysGeneralSystemPretimems2_A9246.ShowHexValue = false;
					num = (short)930349079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 77:
					this.cnvSysGeneralPreambles_A8731 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥룧飩觫迭鷯郱飳鏵请ꗹ뷻웽㟿㄁㔃", a_), global::CommonResources.AcgResources.ID_PREAMBLES, null, null, 0, 1);
					this.cnvSysGeneralPreambles_A8731.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysGeneralPreambles_A8731.DataTransferOrder = 57;
					this.cnvSysGeneralPreambles_A8731.ShowHexValue = false;
					num = (short)228261902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 78:
					if (producerFields != null)
					{
						num = (short)177602629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1485;
				case 79:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迍ꏏꛑ胓뫕돗뷙껛껝곟釡郣ꇥ跧蓩觫鳭釯黱ꟳ迵请軹駻鏽埿欁怃挅將欉怋攍眏怑笓挕栗则紛瀝䜟瘡䴣䬥䴧天䤫䴭漯猱ളе༷̹", a_)))
					{
						num = (short)552992813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C42;
				case 80:
					this.cnvSysGeneralSystemGroupNumber_A21960 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱돳蓵韷迹賻냽痿漁昃挅稇唉䴋㰍ℏ⬑∓☕", a_), global::CommonResources.AcgResources.ID_SYSTEMGROUPNUMBER, null, null, 0, 1);
					this.cnvSysGeneralSystemGroupNumber_A21960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralSystemGroupNumber_A21960.DataTransferOrder = 17;
					this.cnvSysGeneralSystemGroupNumber_A21960.ShowHexValue = true;
					num = (short)1993998378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 81:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱돳蓵韷迹賻냽痿漁昃挅稇唉䴋㰍ℏ⬑∓☕", a_)))
					{
						num = (short)1169031248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19B;
				}
				IL_175:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1352532018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19B:
				num = (short)978190379;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E8:
				num = (short)1078526004;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29A:
				num = (short)1737097255;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_556:
				num = (short)1043857425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_646:
				num = (short)83034143;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_763:
				num = (short)797573164;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7B0:
				num = (short)1291845693;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8AB:
				num = (short)2073886799;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F7:
				num = (short)1301413947;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9A1:
				num = (short)402915352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A4E:
				num = (short)120913946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A9C:
				num = (short)1498677321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AE6:
				num = (short)563216437;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BF3:
				num = (short)1450246182;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C42:
				num = (short)1544421450;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D59:
				num = (short)786300999;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DA7:
				num = (short)2115240002;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F24:
				num = (short)44171283;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F70:
				num = (short)54460427;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FBD:
				num = (short)1912143890;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_100C:
				num = (short)875167785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1081:
				num = (short)1572995153;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10CE:
				this.cnvSysGeneralSystemType_A13262 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鷙맛냝藟郡藣諥믧鏩鿫髭闯鿱ꃳ迵裷鿹ꏻ뿽ㇿ㄁㘃々㨇", a_), global::CommonResources.AcgResources.ID_SYSTEMTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralSystemType_A13262LovStrs);
				this.cnvSysGeneralSystemType_A13262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.cnvSysGeneralSystemType_A13262.DataTransferOrder = 1;
				this.cnvSysGeneralSystemType_A13262.EvaluateRecRefs = true;
				num = (short)1826422816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1134:
				num = (short)1010040861;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_136D:
				num = (short)1280638997;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1438:
				num = (short)577765440;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12AA:
			IL_1485:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍뗏병뇓ꓕ맗뛙", a_);
			base.Id = 10118;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x00AD9844 File Offset: 0x00AD7A44
		public override void PopulateReferences()
		{
			short num = (short)1064060953;
			short num2 = num;
			num = (short)138299417;
			switch (num2 == num)
			{
			}
			num = (short)1659305985;
			if (num != 0)
			{
			}
			num = (short)754450432;
			if (num != 0)
			{
			}
			num = (short)44892160;
			short num3 = num;
			this.cnvSysGeneralDataProfileSelection_A13266.SetRecset(this.a(2054));
			this.cnvSysGeneralEmergencyProfileSelection_A19421.SetRecset(this.a(2075));
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x00AD9918 File Offset: 0x00AD7B18
		public override void DropReferences()
		{
			short num = (short)1108882538;
			short num2 = num;
			num = (short)1098593386;
			switch (num2 == num)
			{
			}
			num = (short)422576129;
			if (num != 0)
			{
			}
			num = (short)2009661440;
			if (num != 0)
			{
			}
			num = (short)899284992;
			short num3 = num;
		}

		// Token: 0x0600BB41 RID: 47937 RVA: 0x00AD99C0 File Offset: 0x00AD7BC0
		public override void SetConstraints()
		{
			short num = (short)895974457;
			short num2 = num;
			num = (short)919436345;
			switch (num2 == num)
			{
			}
			num = (short)1289420801;
			if (num != 0)
			{
			}
			num = (short)622264320;
			if (num != 0)
			{
			}
			num = (short)1567752192;
			short num3 = num;
			this.cnvSysGeneralAckPretimems_A7393.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralAckPretimems_A7393.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSetNumberOfPreamblesRac);
			this.cnvSysGeneralInterPacketTimems_A8312.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralInterPacketTimems_A8312.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSetNumberOfPreamblesRac);
			this.cnvSysGeneralPTTID_A8427.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeisMDCorDTMF);
			this.cnvSysGeneralLimitedPatiencesec_A8433.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDTMFOrQCIIOrDVRS);
			this.cnvSysGeneralPreambles_A8731.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSetNumberOfPreamblesRac);
			this.cnvSysGeneralMDCPrimaryID_A8744.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConAddtionalMDCIDChecked);
			this.cnvSysGeneralMDCPrimaryID_A8744.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDCWithRMC);
			this.cnvSysGeneralMDCPrimaryID_A8744.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conNonEditableWhenOpenFromRMC);
			this.cnvSysGeneralSidetones_A8774.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConBoolMdcSysLdngPttIdEnIsEnable);
			this.cnvSysGeneralSidetones_A8774.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeisMDCorDTMForQCII);
			this.cnvSysGeneralSecondaryID_A9065.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralSystemPretimems2_A9246.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralSystemPretimems2_A9246.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSetTotalPretimeAndNumberOfPreamblesSys);
			this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstro);
			this.cnvSysGeneralVariableID_A9612.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConAddtionalMDCIDIsUnchecked);
			this.cnvSysGeneralVariableID_A9612.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysGeneralSystemType_A13262.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConTiggerRevertChannelApplicableForCon);
			this.cnvSysGeneralSystemType_A13262.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSysTypeEditabilityByZoneClone);
			this.cnvSysGeneralSystemType_A13262.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSetValueFalseOnRSISystem);
			this.cnvSysGeneralDataProfileSelection_A13266.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConRSISysEnAndDataProSelDisabled);
			this.cnvSysGeneralDataProfileSelection_A13266.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsCnvSysDataProSelValid);
			this.cnvSysGeneralDataProfileSelection_A13266.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrDVRS);
			this.cnvSysGeneralEmergencyProfileSelection_A19421.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConRSISysEnAndEmerProSelDisabled);
			this.cnvSysGeneralEmergencyProfileSelection_A19421.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConValidateDataProfileSelectionWhenSignalingRevertChannelInvalid);
			this.cnvSysGeneralEmergencyProfileSelection_A19421.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysLabtoolPreambleEnable_A19576.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.cnvSysLabtoolPreambleEnable_A19576.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSetNumberOfPreamblesRac);
			this.cnvSysGeneralSystemGroupNumber_A21960.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrMdcOrDVRS);
			this.cnvSysGeneralPreambleLength_A8721.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrDVRS);
			this.cnvSysGeneralIndividualID_A8287.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIndividualIDRangeCheck);
			this.cnvSysGeneralIndividualID_A8287.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsAstroOrDVRSWithRMC);
			this.cnvSysGeneralIndividualID_A8287.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conNonEditableWhenOpenFromRMC);
			this.cnvSysGeneralSystemKeyPresent_A40120.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysGeneralSystemKeyPresent_A40120.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvSysGeneralHomeWACNID_A40121.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysGeneralSystemID_A40122.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysGeneralAdditionalMDCPID_A41761.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
			this.convConfigConvSystemFeatRSISys_A41838.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConTriggerRSIModeValidity);
			this.convConfigConvSystemFeatRSISys_A41838.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvSystemTypeIsDigitalAstroAndEn);
			this.convConfigConvSystemFeatRSISys_A41838.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDCAndRSIDisabled);
			this.convConfigConvSystemFeatRSISys_A41838.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSetValueFalseOnRSISystem);
			this.cnvSysGeneralCourtesyTone_43584.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConBoolMdcSysLdngTrngPttIdEnIsEnable);
			this.cnvSysGeneralCourtesyTone_43584.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x00AD9EA4 File Offset: 0x00AD80A4
		public override void SetupDependencies()
		{
			short num = (short)544510164;
			short num2 = num;
			num = (short)1911656660;
			switch (num2 == num)
			{
			}
			num = (short)1442447361;
			if (num != 0)
			{
			}
			num = (short)575799296;
			if (num != 0)
			{
			}
			num = (short)795475968;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysGeneralPreambles_A8731.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysLabtoolPreambleEnable_A19576.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysGeneralInterPacketTimems_A8312.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			conventionalSystem.Labtool.CnvSysLabtoolInterPacketPreambles_A8311.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			conventionalSystem.Labtool.CnvSysLabtoolAckPreambles_A7392.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysGeneralSystemPretimems2_A9246.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralAckPretimems_A7393);
			conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralPreambles_A8731.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysLabtoolPreambleEnable_A19576.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			conventionalSystem.Labtool.CnvSysLabtoolInterPacketPreambles_A8311.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			conventionalSystem.Labtool.CnvSysLabtoolAckPreambles_A7392.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralAckPretimems_A7393.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralSystemPretimems2_A9246.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralInterPacketTimems_A8312);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralPTTID_A8427);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralLimitedPatiencesec_A8433);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralPreambles_A8731);
			conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralPreambles_A8731.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysLabtoolPreambleEnable_A19576.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralInterPacketTimems_A8312.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			conventionalSystem.Labtool.CnvSysLabtoolInterPacketPreambles_A8311.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			conventionalSystem.Labtool.CnvSysLabtoolAckPreambles_A7392.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralAckPretimems_A7393.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralSystemPretimems2_A9246.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralRepeaterAccessPretimems_A8741);
			this.cnvSysGeneralAdditionalMDCPID_A41761.AddDependentObject(this.cnvSysGeneralMDCPrimaryID_A8744);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralMDCPrimaryID_A8744);
			this.cnvSysGeneralPTTID_A8427.AddDependentObject(this.cnvSysGeneralSidetones_A8774);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSidetones_A8774);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSecondaryID_A9065);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSystemPretimems2_A9246);
			conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789.AddDependentObject(this.cnvSysGeneralSystemPretimems2_A9246);
			conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730.AddDependentObject(this.cnvSysGeneralSystemPretimems2_A9246);
			this.cnvSysLabtoolPreambleEnable_A19576.AddDependentObject(this.cnvSysGeneralSystemPretimems2_A9246);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralVariableID_A9612);
			this.cnvSysGeneralAdditionalMDCPID_A41761.AddDependentObject(this.cnvSysGeneralVariableID_A9612);
			this.convConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysGeneralSystemType_A13262);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralDataProfileSelection_A13266);
			this.convConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysGeneralDataProfileSelection_A13266);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cnvSysGeneralDataProfileSelection_A13266);
			this.RefRadioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.AddDependentObject(this.cnvSysGeneralDataProfileSelection_A13266);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralEmergencyProfileSelection_A19421);
			this.convConfigConvSystemFeatRSISys_A41838.AddDependentObject(this.cnvSysGeneralEmergencyProfileSelection_A19421);
			conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralPreambles_A8731.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralRepeaterAccessPretimems_A8741.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralInterPacketTimems_A8312.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			conventionalSystem.Labtool.CnvSysLabtoolInterPacketPreambles_A8311.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			conventionalSystem.Labtool.CnvSysLabtoolAckPreambles_A7392.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralAckPretimems_A7393.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralSystemPretimems2_A9246.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysLabtoolPreambleEnable_A19576);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSystemGroupNumber_A21960);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralPreambleLength_A8721);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralIndividualID_A8287);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSystemKeyPresent_A40120);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralHomeWACNID_A40121);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralSystemID_A40122);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralAdditionalMDCPID_A41761);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.convConfigConvSystemFeatRSISys_A41838);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralCourtesyTone_43584);
			this.cnvSysGeneralPTTID_A8427.AddDependentObject(this.cnvSysGeneralCourtesyTone_43584);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10045] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR).SecWideMDCOTARMDCOTARSystem_A8490);
			this.cnvSysGeneralSystemType_A13262.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideConventionalDynamicIDWithPassword_A43705);
			this.cnvSysGeneralAdditionalMDCPID_A41761.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10045] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR).SecWideMDCOTARMDCOTARSystem_A8490);
		}

		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x0600BB43 RID: 47939 RVA: 0x00ADA564 File Offset: 0x00AD8764
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles DataProfilesForCnvSysGeneralDataProfileSelection_A13266
		{
			get
			{
				short num = (short)1785536877;
				short num2 = num;
				num = (short)866001261;
				switch (num2 == num)
				{
				}
				num = (short)1361707009;
				if (num != 0)
				{
				}
				num = (short)2134900736;
				if (num != 0)
				{
				}
				num = (short)73269248;
				short num3 = num;
				return this.cnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			}
		}

		// Token: 0x17005DD8 RID: 24024
		// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x00ADA620 File Offset: 0x00AD8820
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles ConventionalEmergencyProfilesForCnvSysGeneralEmergencyProfileSelection_A19421
		{
			get
			{
				short num = (short)518256198;
				short num2 = num;
				num = (short)752285254;
				switch (num2 == num)
				{
				}
				num = (short)1709113344;
				if (num != 0)
				{
				}
				num = (short)1982726145;
				if (num != 0)
				{
				}
				num = (short)880345088;
				short num3 = num;
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
			}
		}

		// Token: 0x17005DD9 RID: 24025
		// (get) Token: 0x0600BB45 RID: 47941 RVA: 0x00ADA6DC File Offset: 0x00AD88DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)574506283;
				short num2 = num;
				num = (short)2145404203;
				switch (num2 == num)
				{
				}
				num = (short)849543169;
				if (num != 0)
				{
				}
				num = (short)103940096;
				if (num != 0)
				{
				}
				num = (short)1650524160;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x00ADA78C File Offset: 0x00AD898C
		// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x00ADA840 File Offset: 0x00AD8A40
		public int CnvSysGeneralAckPretimems_A7393Value
		{
			get
			{
				short num = (short)908258789;
				short num2 = num;
				num = (short)1540681189;
				switch (num2 == num)
				{
				}
				num = (short)80543745;
				if (num != 0)
				{
				}
				num = (short)603127808;
				if (num != 0)
				{
				}
				num = (short)1014562816;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Value;
			}
			set
			{
				short num = (short)2107923779;
				short num2 = num;
				num = (short)1989434691;
				switch (num2 == num)
				{
				}
				num = (short)337051649;
				if (num != 0)
				{
				}
				num = (short)772931584;
				if (num != 0)
				{
				}
				num = (short)2099576832;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Value = value;
			}
		}

		// Token: 0x17005DDB RID: 24027
		// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x00ADA8F8 File Offset: 0x00AD8AF8
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralAckPretimems_A7393
		{
			get
			{
				short num = (short)1050377296;
				short num2 = num;
				num = (short)649952336;
				switch (num2 == num)
				{
				}
				num = (short)1973747713;
				if (num != 0)
				{
				}
				num = (short)1045364736;
				if (num != 0)
				{
				}
				num = (short)522059776;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393;
			}
		}

		// Token: 0x17005DDC RID: 24028
		// (get) Token: 0x0600BB49 RID: 47945 RVA: 0x00ADA9A4 File Offset: 0x00AD8BA4
		// (set) Token: 0x0600BB4A RID: 47946 RVA: 0x00ADAA58 File Offset: 0x00AD8C58
		public string CnvSysGeneralAckPretimems_A7393_UIValue
		{
			get
			{
				short num = (short)1779398176;
				short num2 = num;
				num = (short)1848931872;
				switch (num2 == num)
				{
				}
				num = (short)824967169;
				if (num != 0)
				{
				}
				num = (short)474021888;
				if (num != 0)
				{
				}
				num = (short)1255800832;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.UIValue;
			}
			set
			{
				short num = (short)1578762241;
				if (num != 0)
				{
				}
				num = (short)1443387317;
				short num2 = num;
				num = (short)1264015285;
				switch (num2 == num)
				{
				}
				num = (short)505085952;
				if (num != 0)
				{
				}
				num = (short)1874526208;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.UIValue = value;
			}
		}

		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x0600BB4B RID: 47947 RVA: 0x00ADAB0C File Offset: 0x00AD8D0C
		// (set) Token: 0x0600BB4C RID: 47948 RVA: 0x00ADABC0 File Offset: 0x00AD8DC0
		internal int CnvSysGeneralAckPretimems_A7393Min
		{
			get
			{
				short num = (short)362979659;
				short num2 = num;
				num = (short)850370891;
				switch (num2 == num)
				{
				}
				num = (short)64094209;
				if (num != 0)
				{
				}
				num = (short)457375744;
				if (num != 0)
				{
				}
				num = (short)779354112;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Min;
			}
			set
			{
				short num = (short)651847117;
				short num2 = num;
				num = (short)1457677773;
				switch (num2 == num)
				{
				}
				num = (short)494403584;
				if (num != 0)
				{
				}
				num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)796131328;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Min = value;
			}
		}

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x0600BB4D RID: 47949 RVA: 0x00ADAC74 File Offset: 0x00AD8E74
		// (set) Token: 0x0600BB4E RID: 47950 RVA: 0x00ADAD28 File Offset: 0x00AD8F28
		internal int CnvSysGeneralAckPretimems_A7393Max
		{
			get
			{
				short num = (short)844517368;
				short num2 = num;
				num = (short)655839224;
				switch (num2 == num)
				{
				}
				num = (short)1166671873;
				if (num != 0)
				{
				}
				num = (short)25231360;
				if (num != 0)
				{
				}
				num = (short)1943011328;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Max;
			}
			set
			{
				short num = (short)427424560;
				short num2 = num;
				num = (short)435288880;
				switch (num2 == num)
				{
				}
				num = (short)2008154112;
				if (num != 0)
				{
				}
				num = (short)1681326081;
				if (num != 0)
				{
				}
				num = (short)185925632;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Max = value;
			}
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x0600BB4F RID: 47951 RVA: 0x00ADADDC File Offset: 0x00AD8FDC
		// (set) Token: 0x0600BB50 RID: 47952 RVA: 0x00ADAE8C File Offset: 0x00AD908C
		internal int CnvSysGeneralAckPretimems_A7393Step
		{
			get
			{
				short num = (short)1107734056;
				short num2 = num;
				num = (short)1198501416;
				switch (num2 == num)
				{
				}
				num = (short)1615200257;
				if (num != 0)
				{
				}
				num = (short)1736769536;
				if (num != 0)
				{
				}
				num = (short)12648448;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.StepSize;
			}
			set
			{
				short num = (short)2057311201;
				short num2 = num;
				num = (short)578819041;
				switch (num2 == num)
				{
				}
				num = (short)246480896;
				if (num != 0)
				{
				}
				num = (short)359596033;
				if (num != 0)
				{
				}
				num = (short)379650048;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.StepSize = value;
			}
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x0600BB51 RID: 47953 RVA: 0x00ADAF40 File Offset: 0x00AD9140
		// (set) Token: 0x0600BB52 RID: 47954 RVA: 0x00ADAFF4 File Offset: 0x00AD91F4
		public bool CnvSysGeneralAckPretimems_A7393_Applicable
		{
			get
			{
				short num = (short)1149854537;
				short num2 = num;
				num = (short)847012681;
				switch (num2 == num)
				{
				}
				num = (short)1582432257;
				if (num != 0)
				{
				}
				num = (short)610402304;
				if (num != 0)
				{
				}
				num = (short)1157758976;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Applicable;
			}
			set
			{
				short num = (short)1887041255;
				short num2 = num;
				num = (short)1021441767;
				switch (num2 == num)
				{
				}
				num = (short)1935605761;
				if (num != 0)
				{
				}
				num = (short)2109014016;
				if (num != 0)
				{
				}
				num = (short)2063597568;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Applicable = value;
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x0600BB53 RID: 47955 RVA: 0x00ADB0AC File Offset: 0x00AD92AC
		// (set) Token: 0x0600BB54 RID: 47956 RVA: 0x00ADB160 File Offset: 0x00AD9360
		public bool CnvSysGeneralAckPretimems_A7393_Valid
		{
			get
			{
				short num = (short)136205585;
				short num2 = num;
				num = (short)1550472465;
				switch (num2 == num)
				{
				}
				num = (short)183173121;
				if (num != 0)
				{
				}
				num = (short)1695809536;
				if (num != 0)
				{
				}
				num = (short)54263808;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Valid;
			}
			set
			{
				short num = (short)1269157844;
				short num2 = num;
				num = (short)2044841940;
				switch (num2 == num)
				{
				}
				num = (short)1592721409;
				if (num != 0)
				{
				}
				num = (short)1398800384;
				if (num != 0)
				{
				}
				num = (short)1261174784;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Valid = value;
			}
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x0600BB55 RID: 47957 RVA: 0x00ADB218 File Offset: 0x00AD9418
		// (set) Token: 0x0600BB56 RID: 47958 RVA: 0x00ADB2CC File Offset: 0x00AD94CC
		public bool CnvSysGeneralAckPretimems_A7393_Visible
		{
			get
			{
				short num = (short)1658868709;
				short num2 = num;
				num = (short)617042917;
				switch (num2 == num)
				{
				}
				num = (short)471465984;
				if (num != 0)
				{
				}
				num = (short)1491468289;
				if (num != 0)
				{
				}
				num = (short)758710272;
				short num3 = num;
				return this.cnvSysGeneralAckPretimems_A7393.Visible;
			}
			set
			{
				short num = (short)83951617;
				if (num != 0)
				{
				}
				num = (short)545182881;
				short num2 = num;
				num = (short)2101728417;
				switch (num2 == num)
				{
				}
				num = (short)1114243072;
				if (num != 0)
				{
				}
				num = (short)2001141760;
				short num3 = num;
				this.cnvSysGeneralAckPretimems_A7393.Visible = value;
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x0600BB57 RID: 47959 RVA: 0x00ADB380 File Offset: 0x00AD9580
		// (set) Token: 0x0600BB58 RID: 47960 RVA: 0x00ADB434 File Offset: 0x00AD9634
		public bool CnvSysGeneralAckPretimems_A7393_Editable
		{
			get
			{
				short num = (short)231727392;
				short num2 = num;
				num = (short)1407705376;
				switch (num2 == num)
				{
				}
				num = (short)1800536064;
				short num3 = num;
				num = (short)591790081;
				if (num != 0)
				{
				}
				num = (short)263585792;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAckPretimems_A7393.Editable;
			}
			set
			{
				short num = (short)1467485460;
				short num2 = num;
				num = (short)1565003028;
				switch (num2 == num)
				{
				}
				num = (short)178913280;
				short num3 = num;
				num = (short)1110507521;
				if (num != 0)
				{
				}
				num = (short)1934229504;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAckPretimems_A7393.Editable = value;
			}
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x0600BB59 RID: 47961 RVA: 0x00ADB4E8 File Offset: 0x00AD96E8
		internal string CnvSysGeneralAckPretimems_A7393_UILabel
		{
			get
			{
				short num = (short)598171965;
				short num2 = num;
				num = (short)1507811645;
				switch (num2 == num)
				{
				}
				num = (short)2081947648;
				short num3 = num;
				num = (short)1991901185;
				if (num != 0)
				{
				}
				num = (short)107216896;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAckPretimems_A7393.UIName;
			}
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x00ADB5A0 File Offset: 0x00AD97A0
		// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x00ADB658 File Offset: 0x00AD9858
		internal bool CnvSysGeneralAckPretimems_A7393_HiddenStatic
		{
			get
			{
				short num = (short)816192175;
				short num2 = num;
				num = (short)1287396015;
				switch (num2 == num)
				{
				}
				num = (short)1136132096;
				short num3 = num;
				num = (short)813301761;
				if (num != 0)
				{
				}
				num = (short)1576927232;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAckPretimems_A7393.HiddenStatic;
			}
			set
			{
				short num = (short)1265238017;
				if (num != 0)
				{
				}
				num = (short)715880908;
				short num2 = num;
				num = (short)48265676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012531200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)639565824;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAckPretimems_A7393.HiddenStatic = value;
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x00ADB70C File Offset: 0x00AD990C
		// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x00ADB7C0 File Offset: 0x00AD99C0
		internal bool CnvSysGeneralAckPretimems_A7393_HiddenDynamic
		{
			get
			{
				short num = (short)1090722292;
				short num2 = num;
				num = (short)1639782900;
				switch (num2 == num)
				{
				}
				num = (short)2131755008;
				short num3 = num;
				num = (short)1681326080;
				if (num != 0)
				{
				}
				num = (short)1266089985;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAckPretimems_A7393.HiddenDynamic;
			}
			set
			{
				short num = (short)111673345;
				if (num != 0)
				{
				}
				num = (short)276422997;
				short num2 = num;
				num = (short)1039982933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329922048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687996928;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAckPretimems_A7393.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x0600BB5E RID: 47966 RVA: 0x00ADB878 File Offset: 0x00AD9A78
		public bool CnvSysGeneralAckPretimems_A7393_HasDiffs
		{
			get
			{
				short num = (short)1020505392;
				short num2 = num;
				num = (short)2128915760;
				switch (num2 == num)
				{
				}
				num = (short)1232142336;
				short num3 = num;
				num = (short)1751056385;
				if (num != 0)
				{
				}
				num = (short)528285696;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAckPretimems_A7393._HasDiffs;
			}
		}

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x0600BB5F RID: 47967 RVA: 0x00ADB92C File Offset: 0x00AD9B2C
		// (set) Token: 0x0600BB60 RID: 47968 RVA: 0x00ADB9E4 File Offset: 0x00AD9BE4
		public int CnvSysGeneralInterPacketTimems_A8312Value
		{
			get
			{
				short num = (short)1692695086;
				short num2 = num;
				num = (short)298482222;
				switch (num2 == num)
				{
				}
				num = (short)1408565248;
				short num3 = num;
				num = (short)1349779457;
				if (num != 0)
				{
				}
				num = (short)1039728640;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Value;
			}
			set
			{
				short num = (short)929187843;
				short num2 = num;
				num = (short)2120042499;
				switch (num2 == num)
				{
				}
				num = (short)275185664;
				short num3 = num;
				num = (short)2136211457;
				if (num != 0)
				{
				}
				num = (short)164691968;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Value = value;
			}
		}

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x0600BB61 RID: 47969 RVA: 0x00ADBA98 File Offset: 0x00AD9C98
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralInterPacketTimems_A8312
		{
			get
			{
				short num = (short)972459602;
				short num2 = num;
				num = (short)1152224850;
				switch (num2 == num)
				{
				}
				num = (short)2075721728;
				short num3 = num;
				num = (short)233766913;
				if (num != 0)
				{
				}
				num = (short)925564928;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312;
			}
		}

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x00ADBB48 File Offset: 0x00AD9D48
		// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x00ADBBFC File Offset: 0x00AD9DFC
		public string CnvSysGeneralInterPacketTimems_A8312_UIValue
		{
			get
			{
				short num = (short)170830501;
				short num2 = num;
				num = (short)221227685;
				switch (num2 == num)
				{
				}
				num = (short)884539392;
				short num3 = num;
				num = (short)1340932097;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.UIValue;
			}
			set
			{
				short num = (short)2010920433;
				short num2 = num;
				num = (short)495007217;
				switch (num2 == num)
				{
				}
				num = (short)718733312;
				short num3 = num;
				num = (short)2120220673;
				if (num != 0)
				{
				}
				num = (short)138346496;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.UIValue = value;
			}
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x00ADBCB0 File Offset: 0x00AD9EB0
		// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x00ADBD64 File Offset: 0x00AD9F64
		internal int CnvSysGeneralInterPacketTimems_A8312Min
		{
			get
			{
				short num = (short)1211703207;
				short num2 = num;
				num = (short)1277632423;
				switch (num2 == num)
				{
				}
				num = (short)1152450560;
				short num3 = num;
				num = (short)726466560;
				if (num != 0)
				{
				}
				num = (short)1202323457;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Min;
			}
			set
			{
				short num = (short)1261090224;
				short num2 = num;
				num = (short)575387056;
				switch (num2 == num)
				{
				}
				num = (short)1798635520;
				short num3 = num;
				num = (short)1709637633;
				if (num != 0)
				{
				}
				num = (short)2001534976;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Min = value;
			}
		}

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x00ADBE18 File Offset: 0x00ADA018
		// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x00ADBECC File Offset: 0x00ADA0CC
		internal int CnvSysGeneralInterPacketTimems_A8312Max
		{
			get
			{
				short num = (short)1933358075;
				short num2 = num;
				num = (short)1977791483;
				switch (num2 == num)
				{
				}
				num = (short)1997471744;
				short num3 = num;
				num = (short)2120220673;
				if (num != 0)
				{
				}
				num = (short)493027328;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Max;
			}
			set
			{
				short num = (short)1331332731;
				short num2 = num;
				num = (short)434734715;
				switch (num2 == num)
				{
				}
				num = (short)1241907200;
				short num3 = num;
				num = (short)2104360961;
				if (num != 0)
				{
				}
				num = (short)1428619264;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Max = value;
			}
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x00ADBF80 File Offset: 0x00ADA180
		// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x00ADC034 File Offset: 0x00ADA234
		internal int CnvSysGeneralInterPacketTimems_A8312Step
		{
			get
			{
				short num = (short)1526707035;
				short num2 = num;
				num = (short)2095297371;
				switch (num2 == num)
				{
				}
				num = (short)60620800;
				short num3 = num;
				num = (short)548012033;
				if (num != 0)
				{
				}
				num = (short)1633157120;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.StepSize;
			}
			set
			{
				short num = (short)1672347649;
				if (num != 0)
				{
				}
				num = (short)2070151069;
				short num2 = num;
				num = (short)996999069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2096824320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)63111168;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.StepSize = value;
			}
		}

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x00ADC0E8 File Offset: 0x00ADA2E8
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x00ADC1A0 File Offset: 0x00ADA3A0
		public bool CnvSysGeneralInterPacketTimems_A8312_Applicable
		{
			get
			{
				short num = (short)458642400;
				short num2 = num;
				num = (short)1676039136;
				switch (num2 == num)
				{
				}
				num = (short)274923520;
				short num3 = num;
				num = (short)1609826305;
				if (num != 0)
				{
				}
				num = (short)1960837120;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Applicable;
			}
			set
			{
				short num = (short)1946738888;
				short num2 = num;
				num = (short)1945690312;
				switch (num2 == num)
				{
				}
				num = (short)525205504;
				short num3 = num;
				num = (short)1735262209;
				if (num != 0)
				{
				}
				num = (short)799539200;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Applicable = value;
			}
		}

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x00ADC258 File Offset: 0x00ADA458
		// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x00ADC30C File Offset: 0x00ADA50C
		public bool CnvSysGeneralInterPacketTimems_A8312_Valid
		{
			get
			{
				short num = (short)1532775503;
				short num2 = num;
				num = (short)1958628431;
				switch (num2 == num)
				{
				}
				num = (short)1406140416;
				short num3 = num;
				num = (short)1564606465;
				if (num != 0)
				{
				}
				num = (short)1552285696;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Valid;
			}
			set
			{
				short num = (short)1199469269;
				short num2 = num;
				num = (short)237990613;
				switch (num2 == num)
				{
				}
				num = (short)445054976;
				short num3 = num;
				num = (short)1919680512;
				if (num != 0)
				{
				}
				num = (short)210698241;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Valid = value;
			}
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x00ADC3C0 File Offset: 0x00ADA5C0
		// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x00ADC474 File Offset: 0x00ADA674
		public bool CnvSysGeneralInterPacketTimems_A8312_Visible
		{
			get
			{
				short num = (short)1269267100;
				short num2 = num;
				num = (short)1773632156;
				switch (num2 == num)
				{
				}
				num = (short)913899520;
				short num3 = num;
				num = (short)1805058048;
				if (num != 0)
				{
				}
				num = (short)2081816577;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Visible;
			}
			set
			{
				short num = (short)377343330;
				short num2 = num;
				num = (short)785763682;
				switch (num2 == num)
				{
				}
				num = (short)932642816;
				short num3 = num;
				num = (short)2013003777;
				if (num != 0)
				{
				}
				num = (short)897581056;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Visible = value;
			}
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x00ADC528 File Offset: 0x00ADA728
		// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x00ADC5DC File Offset: 0x00ADA7DC
		public bool CnvSysGeneralInterPacketTimems_A8312_Editable
		{
			get
			{
				short num = (short)379731952;
				short num2 = num;
				num = (short)171655152;
				switch (num2 == num)
				{
				}
				num = (short)484179968;
				short num3 = num;
				num = (short)1165819905;
				if (num != 0)
				{
				}
				num = (short)509804544;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.Editable;
			}
			set
			{
				short num = (short)1935799162;
				short num2 = num;
				num = (short)177075066;
				switch (num2 == num)
				{
				}
				num = (short)1274740736;
				short num3 = num;
				num = (short)1398210561;
				if (num != 0)
				{
				}
				num = (short)543227904;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.Editable = value;
			}
		}

		// Token: 0x17005DF2 RID: 24050
		// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x00ADC690 File Offset: 0x00ADA890
		internal string CnvSysGeneralInterPacketTimems_A8312_UILabel
		{
			get
			{
				short num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)158011323;
				short num2 = num;
				num = (short)2024214459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643380736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165085184;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.UIName;
			}
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x0600BB73 RID: 47987 RVA: 0x00ADC748 File Offset: 0x00ADA948
		// (set) Token: 0x0600BB74 RID: 47988 RVA: 0x00ADC7FC File Offset: 0x00ADA9FC
		internal bool CnvSysGeneralInterPacketTimems_A8312_HiddenStatic
		{
			get
			{
				short num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)602990856;
				short num2 = num;
				num = (short)231663880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1241645056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117009408;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.HiddenStatic;
			}
			set
			{
				short num = (short)1566778425;
				short num2 = num;
				num = (short)599139385;
				switch (num2 == num)
				{
				}
				num = (short)1250361344;
				short num3 = num;
				num = (short)629866497;
				if (num != 0)
				{
				}
				num = (short)1105133568;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.HiddenStatic = value;
			}
		}

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x0600BB75 RID: 47989 RVA: 0x00ADC8B4 File Offset: 0x00ADAAB4
		// (set) Token: 0x0600BB76 RID: 47990 RVA: 0x00ADC96C File Offset: 0x00ADAB6C
		internal bool CnvSysGeneralInterPacketTimems_A8312_HiddenDynamic
		{
			get
			{
				short num = (short)629815775;
				short num2 = num;
				num = (short)565590495;
				switch (num2 == num)
				{
				}
				num = (short)1308688384;
				short num3 = num;
				num = (short)1645084672;
				if (num != 0)
				{
				}
				num = (short)1946943489;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312.HiddenDynamic;
			}
			set
			{
				short num = (short)361168897;
				if (num != 0)
				{
				}
				num = (short)572094532;
				short num2 = num;
				num = (short)689666116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)718733312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)311033856;
				if (num != 0)
				{
				}
				this.cnvSysGeneralInterPacketTimems_A8312.HiddenDynamic = value;
			}
		}

		// Token: 0x17005DF5 RID: 24053
		// (get) Token: 0x0600BB77 RID: 47991 RVA: 0x00ADCA24 File Offset: 0x00ADAC24
		public bool CnvSysGeneralInterPacketTimems_A8312_HasDiffs
		{
			get
			{
				short num = (short)1353506949;
				short num2 = num;
				num = (short)1508761733;
				switch (num2 == num)
				{
				}
				num = (short)173998080;
				short num3 = num;
				num = (short)624230401;
				if (num != 0)
				{
				}
				num = (short)1231355904;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralInterPacketTimems_A8312._HasDiffs;
			}
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x00ADCAD8 File Offset: 0x00ADACD8
		// (set) Token: 0x0600BB79 RID: 47993 RVA: 0x00ADCB90 File Offset: 0x00ADAD90
		public int CnvSysGeneralPTTID_A8427Value
		{
			get
			{
				short num = (short)808691607;
				short num2 = num;
				num = (short)1967302551;
				switch (num2 == num)
				{
				}
				num = (short)1781137408;
				short num3 = num;
				num = (short)1915289601;
				if (num != 0)
				{
				}
				num = (short)923009024;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427.Value;
			}
			set
			{
				short num = (short)755347379;
				short num2 = num;
				num = (short)2145234867;
				switch (num2 == num)
				{
				}
				num = (short)107413504;
				short num3 = num;
				num = (short)1956511744;
				if (num != 0)
				{
				}
				num = (short)760610817;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPTTID_A8427.Value = value;
			}
		}

		// Token: 0x17005DF7 RID: 24055
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x00ADCC48 File Offset: 0x00ADAE48
		// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x00ADCCFC File Offset: 0x00ADAEFC
		public string CnvSysGeneralPTTID_A8427_UIValue
		{
			get
			{
				short num = (short)393090137;
				short num2 = num;
				num = (short)1161761881;
				switch (num2 == num)
				{
				}
				num = (short)478019584;
				short num3 = num;
				num = (short)2052653057;
				if (num != 0)
				{
				}
				num = (short)2061303808;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427.UIValue;
			}
			set
			{
				short num = (short)67605768;
				short num2 = num;
				num = (short)2039321864;
				switch (num2 == num)
				{
				}
				num = (short)965017600;
				short num3 = num;
				num = (short)871694337;
				if (num != 0)
				{
				}
				num = (short)228524032;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPTTID_A8427.UIValue = value;
			}
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x00ADCDB4 File Offset: 0x00ADAFB4
		public global::AcpBusinessLayer.AcpListField CnvSysGeneralPTTID_A8427
		{
			get
			{
				short num = (short)1551379068;
				short num2 = num;
				num = (short)881404540;
				switch (num2 == num)
				{
				}
				num = (short)46465024;
				short num3 = num;
				num = (short)627572736;
				if (num != 0)
				{
				}
				num = (short)959184897;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427;
			}
		}

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x0600BB7D RID: 47997 RVA: 0x00ADCE64 File Offset: 0x00ADB064
		// (set) Token: 0x0600BB7E RID: 47998 RVA: 0x00ADCF1C File Offset: 0x00ADB11C
		public bool CnvSysGeneralPTTID_A8427_Applicable
		{
			get
			{
				short num = (short)2063103000;
				short num2 = num;
				num = (short)2142401560;
				switch (num2 == num)
				{
				}
				num = (short)811073536;
				short num3 = num;
				num = (short)1578958849;
				if (num != 0)
				{
				}
				num = (short)1708064768;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427.Applicable;
			}
			set
			{
				short num = (short)1749893966;
				short num2 = num;
				num = (short)1103119182;
				switch (num2 == num)
				{
				}
				num = (short)772407296;
				short num3 = num;
				num = (short)1539309568;
				if (num != 0)
				{
				}
				num = (short)1048969217;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPTTID_A8427.Applicable = value;
			}
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x0600BB7F RID: 47999 RVA: 0x00ADCFD4 File Offset: 0x00ADB1D4
		// (set) Token: 0x0600BB80 RID: 48000 RVA: 0x00ADD08C File Offset: 0x00ADB28C
		public bool CnvSysGeneralPTTID_A8427_Valid
		{
			get
			{
				short num = (short)112368379;
				short num2 = num;
				num = (short)840735483;
				switch (num2 == num)
				{
				}
				num = (short)1030750208;
				short num3 = num;
				num = (short)63373313;
				if (num != 0)
				{
				}
				num = (short)459603968;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427.Valid;
			}
			set
			{
				short num = (short)757647600;
				short num2 = num;
				num = (short)972409072;
				switch (num2 == num)
				{
				}
				num = (short)498860032;
				short num3 = num;
				num = (short)950468608;
				if (num != 0)
				{
				}
				num = (short)1374355457;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPTTID_A8427.Valid = value;
			}
		}

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x0600BB81 RID: 48001 RVA: 0x00ADD140 File Offset: 0x00ADB340
		// (set) Token: 0x0600BB82 RID: 48002 RVA: 0x00ADD1F4 File Offset: 0x00ADB3F4
		public bool CnvSysGeneralPTTID_A8427_Visible
		{
			get
			{
				short num = (short)1691868551;
				short num2 = num;
				num = (short)1133763975;
				switch (num2 == num)
				{
				}
				num = (short)559874048;
				short num3 = num;
				num = (short)1358495745;
				if (num != 0)
				{
				}
				num = (short)2115239936;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPTTID_A8427.Visible;
			}
			set
			{
				short num = (short)1834745857;
				if (num != 0)
				{
				}
				num = (short)76896584;
				short num2 = num;
				num = (short)1007966536;
				switch (num2 == num)
				{
				}
				num = (short)407764992;
				if (num != 0)
				{
				}
				num = (short)2116747264;
				short num3 = num;
				this.cnvSysGeneralPTTID_A8427.Visible = value;
			}
		}

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x0600BB83 RID: 48003 RVA: 0x00ADD2A8 File Offset: 0x00ADB4A8
		// (set) Token: 0x0600BB84 RID: 48004 RVA: 0x00ADD35C File Offset: 0x00ADB55C
		public bool CnvSysGeneralPTTID_A8427_Editable
		{
			get
			{
				short num = (short)472045434;
				short num2 = num;
				num = (short)1106696058;
				switch (num2 == num)
				{
				}
				num = (short)247398401;
				if (num != 0)
				{
				}
				num = (short)702808064;
				if (num != 0)
				{
				}
				num = (short)724828160;
				short num3 = num;
				return this.cnvSysGeneralPTTID_A8427.Editable;
			}
			set
			{
				short num = (short)2085945345;
				if (num != 0)
				{
				}
				num = (short)113485139;
				short num2 = num;
				num = (short)897754451;
				switch (num2 == num)
				{
				}
				num = (short)799801344;
				if (num != 0)
				{
				}
				num = (short)45023232;
				short num3 = num;
				this.cnvSysGeneralPTTID_A8427.Editable = value;
			}
		}

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x0600BB85 RID: 48005 RVA: 0x00ADD410 File Offset: 0x00ADB610
		internal string CnvSysGeneralPTTID_A8427_UILabel
		{
			get
			{
				short num = (short)1000981822;
				short num2 = num;
				num = (short)631620926;
				switch (num2 == num)
				{
				}
				num = (short)1417936897;
				if (num != 0)
				{
				}
				num = (short)548274176;
				if (num != 0)
				{
				}
				num = (short)1045495808;
				short num3 = num;
				return this.cnvSysGeneralPTTID_A8427.UIName;
			}
		}

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x00ADD4C4 File Offset: 0x00ADB6C4
		// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x00ADD578 File Offset: 0x00ADB778
		internal bool CnvSysGeneralPTTID_A8427_HiddenStatic
		{
			get
			{
				short num = (short)318738048;
				short num2 = num;
				num = (short)1529122432;
				switch (num2 == num)
				{
				}
				num = (short)899874816;
				if (num != 0)
				{
				}
				num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)1848442880;
				short num3 = num;
				return this.cnvSysGeneralPTTID_A8427.HiddenStatic;
			}
			set
			{
				short num = (short)1895915057;
				short num2 = num;
				num = (short)874470961;
				switch (num2 == num)
				{
				}
				num = (short)89260033;
				if (num != 0)
				{
				}
				num = (short)729153536;
				if (num != 0)
				{
				}
				num = (short)1606811648;
				short num3 = num;
				this.cnvSysGeneralPTTID_A8427.HiddenStatic = value;
			}
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x0600BB88 RID: 48008 RVA: 0x00ADD62C File Offset: 0x00ADB82C
		// (set) Token: 0x0600BB89 RID: 48009 RVA: 0x00ADD6E0 File Offset: 0x00ADB8E0
		internal bool CnvSysGeneralPTTID_A8427_HiddenDynamic
		{
			get
			{
				short num = (short)1264975873;
				if (num != 0)
				{
				}
				num = (short)1730850638;
				short num2 = num;
				num = (short)1410707278;
				switch (num2 == num)
				{
				}
				num = (short)938344448;
				if (num != 0)
				{
				}
				num = (short)701759488;
				short num3 = num;
				return this.cnvSysGeneralPTTID_A8427.HiddenDynamic;
			}
			set
			{
				short num = (short)1332768876;
				short num2 = num;
				num = (short)424636524;
				switch (num2 == num)
				{
				}
				num = (short)1525678080;
				if (num != 0)
				{
				}
				num = (short)1096089601;
				if (num != 0)
				{
				}
				num = (short)1288634368;
				short num3 = num;
				this.cnvSysGeneralPTTID_A8427.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x00ADD798 File Offset: 0x00ADB998
		public bool CnvSysGeneralPTTID_A8427_HasDiffs
		{
			get
			{
				short num = (short)489005493;
				short num2 = num;
				num = (short)1534108085;
				switch (num2 == num)
				{
				}
				num = (short)226885633;
				if (num != 0)
				{
				}
				num = (short)1103953920;
				if (num != 0)
				{
				}
				num = (short)874971136;
				short num3 = num;
				return this.cnvSysGeneralPTTID_A8427._HasDiffs;
			}
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x0600BB8B RID: 48011 RVA: 0x00ADD84C File Offset: 0x00ADBA4C
		// (set) Token: 0x0600BB8C RID: 48012 RVA: 0x00ADD904 File Offset: 0x00ADBB04
		public int CnvSysGeneralLimitedPatiencesec_A8433Value
		{
			get
			{
				short num = (short)387645441;
				if (num != 0)
				{
				}
				num = (short)77254710;
				short num2 = num;
				num = (short)884592694;
				switch (num2 == num)
				{
				}
				num = (short)1057947648;
				if (num != 0)
				{
				}
				num = (short)1282998272;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Value;
			}
			set
			{
				short num = (short)962461700;
				short num2 = num;
				num = (short)696123396;
				switch (num2 == num)
				{
				}
				num = (short)1139998721;
				if (num != 0)
				{
				}
				num = (short)1076166656;
				if (num != 0)
				{
				}
				num = (short)1251082240;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Value = value;
			}
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x0600BB8D RID: 48013 RVA: 0x00ADD9BC File Offset: 0x00ADBBBC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralLimitedPatiencesec_A8433
		{
			get
			{
				short num = (short)1977742297;
				short num2 = num;
				num = (short)201520089;
				switch (num2 == num)
				{
				}
				num = (short)300089345;
				if (num != 0)
				{
				}
				num = (short)554696704;
				if (num != 0)
				{
				}
				num = (short)1489567744;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433;
			}
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x00ADDA6C File Offset: 0x00ADBC6C
		// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x00ADDB20 File Offset: 0x00ADBD20
		public string CnvSysGeneralLimitedPatiencesec_A8433_UIValue
		{
			get
			{
				short num = (short)1957336273;
				short num2 = num;
				num = (short)1240372433;
				switch (num2 == num)
				{
				}
				num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)689766400;
				if (num != 0)
				{
				}
				num = (short)153026560;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.UIValue;
			}
			set
			{
				short num = (short)1501534783;
				short num2 = num;
				num = (short)2083887679;
				switch (num2 == num)
				{
				}
				num = (short)522846208;
				if (num != 0)
				{
				}
				num = (short)1536294913;
				if (num != 0)
				{
				}
				num = (short)108068864;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.UIValue = value;
			}
		}

		// Token: 0x17005E04 RID: 24068
		// (get) Token: 0x0600BB90 RID: 48016 RVA: 0x00ADDBD4 File Offset: 0x00ADBDD4
		// (set) Token: 0x0600BB91 RID: 48017 RVA: 0x00ADDC8C File Offset: 0x00ADBE8C
		internal int CnvSysGeneralLimitedPatiencesec_A8433Min
		{
			get
			{
				short num = (short)1875895969;
				short num2 = num;
				num = (short)795207329;
				switch (num2 == num)
				{
				}
				num = (short)317849600;
				if (num != 0)
				{
				}
				num = (short)193658881;
				if (num != 0)
				{
				}
				num = (short)1199898624;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Min;
			}
			set
			{
				short num = (short)1440173388;
				short num2 = num;
				num = (short)902516044;
				switch (num2 == num)
				{
				}
				num = (short)280494081;
				if (num != 0)
				{
				}
				num = (short)1772552192;
				if (num != 0)
				{
				}
				num = (short)1343619072;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Min = value;
			}
		}

		// Token: 0x17005E05 RID: 24069
		// (get) Token: 0x0600BB92 RID: 48018 RVA: 0x00ADDD44 File Offset: 0x00ADBF44
		// (set) Token: 0x0600BB93 RID: 48019 RVA: 0x00ADDDFC File Offset: 0x00ADBFFC
		internal int CnvSysGeneralLimitedPatiencesec_A8433Max
		{
			get
			{
				short num = (short)2072000988;
				short num2 = num;
				num = (short)384448988;
				switch (num2 == num)
				{
				}
				num = (short)478871553;
				if (num != 0)
				{
				}
				num = (short)1484193792;
				if (num != 0)
				{
				}
				num = (short)353894400;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Max;
			}
			set
			{
				short num = (short)1443243642;
				short num2 = num;
				num = (short)969418362;
				switch (num2 == num)
				{
				}
				num = (short)676790273;
				if (num != 0)
				{
				}
				num = (short)950796288;
				if (num != 0)
				{
				}
				num = (short)5439488;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Max = value;
			}
		}

		// Token: 0x17005E06 RID: 24070
		// (get) Token: 0x0600BB94 RID: 48020 RVA: 0x00ADDEB4 File Offset: 0x00ADC0B4
		// (set) Token: 0x0600BB95 RID: 48021 RVA: 0x00ADDF68 File Offset: 0x00ADC168
		internal int CnvSysGeneralLimitedPatiencesec_A8433Step
		{
			get
			{
				short num = (short)691077121;
				if (num != 0)
				{
				}
				num = (short)1009570201;
				short num2 = num;
				num = (short)1808126361;
				switch (num2 == num)
				{
				}
				num = (short)397475840;
				if (num != 0)
				{
				}
				num = (short)598867968;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.StepSize;
			}
			set
			{
				short num = (short)1749926951;
				short num2 = num;
				num = (short)1292026919;
				switch (num2 == num)
				{
				}
				num = (short)161349633;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				if (num != 0)
				{
				}
				num = (short)41091072;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.StepSize = value;
			}
		}

		// Token: 0x17005E07 RID: 24071
		// (get) Token: 0x0600BB96 RID: 48022 RVA: 0x00ADE01C File Offset: 0x00ADC21C
		// (set) Token: 0x0600BB97 RID: 48023 RVA: 0x00ADE0D4 File Offset: 0x00ADC2D4
		public bool CnvSysGeneralLimitedPatiencesec_A8433_Applicable
		{
			get
			{
				short num = (short)1273255413;
				short num2 = num;
				num = (short)900486645;
				switch (num2 == num)
				{
				}
				num = (short)1584988160;
				if (num != 0)
				{
				}
				num = (short)1140654081;
				if (num != 0)
				{
				}
				num = (short)1321598976;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Applicable;
			}
			set
			{
				short num = (short)1567690275;
				short num2 = num;
				num = (short)1766788643;
				switch (num2 == num)
				{
				}
				num = (short)120586241;
				if (num != 0)
				{
				}
				num = (short)717160448;
				if (num != 0)
				{
				}
				num = (short)816840704;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Applicable = value;
			}
		}

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x00ADE18C File Offset: 0x00ADC38C
		// (set) Token: 0x0600BB99 RID: 48025 RVA: 0x00ADE240 File Offset: 0x00ADC440
		public bool CnvSysGeneralLimitedPatiencesec_A8433_Valid
		{
			get
			{
				short num = (short)2121078285;
				short num2 = num;
				num = (short)1305941517;
				switch (num2 == num)
				{
				}
				num = (short)1901658113;
				if (num != 0)
				{
				}
				num = (short)16318464;
				if (num != 0)
				{
				}
				num = (short)108265472;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Valid;
			}
			set
			{
				short num = (short)428802049;
				if (num != 0)
				{
				}
				num = (short)1102826015;
				short num2 = num;
				num = (short)1685834271;
				switch (num2 == num)
				{
				}
				num = (short)1442250752;
				if (num != 0)
				{
				}
				num = (short)5046272;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Valid = value;
			}
		}

		// Token: 0x17005E09 RID: 24073
		// (get) Token: 0x0600BB9A RID: 48026 RVA: 0x00ADE2F8 File Offset: 0x00ADC4F8
		// (set) Token: 0x0600BB9B RID: 48027 RVA: 0x00ADE3AC File Offset: 0x00ADC5AC
		public bool CnvSysGeneralLimitedPatiencesec_A8433_Visible
		{
			get
			{
				short num = (short)1516277337;
				short num2 = num;
				num = (short)1556975193;
				switch (num2 == num)
				{
				}
				num = (short)357564417;
				if (num != 0)
				{
				}
				num = (short)1077673984;
				if (num != 0)
				{
				}
				num = (short)1434058752;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Visible;
			}
			set
			{
				short num = (short)926248947;
				short num2 = num;
				num = (short)1535471603;
				switch (num2 == num)
				{
				}
				num = (short)939130881;
				if (num != 0)
				{
				}
				num = (short)445382656;
				if (num != 0)
				{
				}
				num = (short)190906368;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Visible = value;
			}
		}

		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x00ADE464 File Offset: 0x00ADC664
		// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x00ADE51C File Offset: 0x00ADC71C
		public bool CnvSysGeneralLimitedPatiencesec_A8433_Editable
		{
			get
			{
				short num = (short)1127653718;
				short num2 = num;
				num = (short)417505622;
				switch (num2 == num)
				{
				}
				num = (short)2102919168;
				if (num != 0)
				{
				}
				num = (short)375717889;
				if (num != 0)
				{
				}
				num = (short)1669464064;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.Editable;
			}
			set
			{
				short num = (short)1498357490;
				short num2 = num;
				num = (short)748297970;
				switch (num2 == num)
				{
				}
				num = (short)984285185;
				if (num != 0)
				{
				}
				num = (short)198770688;
				if (num != 0)
				{
				}
				num = (short)407764992;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.Editable = value;
			}
		}

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x00ADE5D0 File Offset: 0x00ADC7D0
		internal string CnvSysGeneralLimitedPatiencesec_A8433_UILabel
		{
			get
			{
				short num = (short)1941855231;
				short num2 = num;
				num = (short)1483824127;
				switch (num2 == num)
				{
				}
				num = (short)1830879233;
				if (num != 0)
				{
				}
				num = (short)792395776;
				if (num != 0)
				{
				}
				num = (short)1818558464;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.UIName;
			}
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x0600BB9F RID: 48031 RVA: 0x00ADE684 File Offset: 0x00ADC884
		// (set) Token: 0x0600BBA0 RID: 48032 RVA: 0x00ADE738 File Offset: 0x00ADC938
		internal bool CnvSysGeneralLimitedPatiencesec_A8433_HiddenStatic
		{
			get
			{
				short num = (short)1926758401;
				if (num != 0)
				{
				}
				num = (short)1026178882;
				short num2 = num;
				num = (short)1792819010;
				switch (num2 == num)
				{
				}
				num = (short)1168769024;
				if (num != 0)
				{
				}
				num = (short)1405616128;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.HiddenStatic;
			}
			set
			{
				short num = (short)443399247;
				short num2 = num;
				num = (short)2015476815;
				switch (num2 == num)
				{
				}
				num = (short)1032912897;
				if (num != 0)
				{
				}
				num = (short)2078670848;
				if (num != 0)
				{
				}
				num = (short)721420288;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.HiddenStatic = value;
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x0600BBA1 RID: 48033 RVA: 0x00ADE7EC File Offset: 0x00ADC9EC
		// (set) Token: 0x0600BBA2 RID: 48034 RVA: 0x00ADE8A0 File Offset: 0x00ADCAA0
		internal bool CnvSysGeneralLimitedPatiencesec_A8433_HiddenDynamic
		{
			get
			{
				short num = (short)380025060;
				short num2 = num;
				num = (short)1855961316;
				switch (num2 == num)
				{
				}
				num = (short)1777270785;
				if (num != 0)
				{
				}
				num = (short)2019950592;
				if (num != 0)
				{
				}
				num = (short)318504960;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433.HiddenDynamic;
			}
			set
			{
				short num = (short)237639640;
				short num2 = num;
				num = (short)1096226776;
				switch (num2 == num)
				{
				}
				num = (short)1338638336;
				if (num != 0)
				{
				}
				num = (short)1424359425;
				if (num != 0)
				{
				}
				num = (short)1635581952;
				short num3 = num;
				this.cnvSysGeneralLimitedPatiencesec_A8433.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x0600BBA3 RID: 48035 RVA: 0x00ADE954 File Offset: 0x00ADCB54
		public bool CnvSysGeneralLimitedPatiencesec_A8433_HasDiffs
		{
			get
			{
				short num = (short)1380253697;
				if (num != 0)
				{
				}
				num = (short)499740360;
				short num2 = num;
				num = (short)1575120584;
				switch (num2 == num)
				{
				}
				num = (short)1058078720;
				if (num != 0)
				{
				}
				num = (short)338034688;
				short num3 = num;
				return this.cnvSysGeneralLimitedPatiencesec_A8433._HasDiffs;
			}
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x00ADEA08 File Offset: 0x00ADCC08
		// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x00ADEAC0 File Offset: 0x00ADCCC0
		public int CnvSysGeneralPreambles_A8731Value
		{
			get
			{
				short num = (short)747641228;
				short num2 = num;
				num = (short)1271732620;
				switch (num2 == num)
				{
				}
				num = (short)504168448;
				if (num != 0)
				{
				}
				num = (short)680853505;
				if (num != 0)
				{
				}
				num = (short)71892992;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Value;
			}
			set
			{
				short num = (short)911516449;
				short num2 = num;
				num = (short)403612449;
				switch (num2 == num)
				{
				}
				num = (short)218103809;
				if (num != 0)
				{
				}
				num = (short)1602813952;
				if (num != 0)
				{
				}
				num = (short)2122317824;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Value = value;
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x00ADEB74 File Offset: 0x00ADCD74
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralPreambles_A8731
		{
			get
			{
				short num = (short)1128081423;
				short num2 = num;
				num = (short)427304975;
				switch (num2 == num)
				{
				}
				num = (short)1539047425;
				if (num != 0)
				{
				}
				num = (short)1895301120;
				if (num != 0)
				{
				}
				num = (short)1855389696;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731;
			}
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x0600BBA7 RID: 48039 RVA: 0x00ADEC24 File Offset: 0x00ADCE24
		// (set) Token: 0x0600BBA8 RID: 48040 RVA: 0x00ADECD8 File Offset: 0x00ADCED8
		public string CnvSysGeneralPreambles_A8731_UIValue
		{
			get
			{
				short num = (short)1138588337;
				short num2 = num;
				num = (short)1808038577;
				switch (num2 == num)
				{
				}
				num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)555876352;
				if (num != 0)
				{
				}
				num = (short)854982656;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.UIValue;
			}
			set
			{
				short num = (short)1279288569;
				short num2 = num;
				num = (short)751396089;
				switch (num2 == num)
				{
				}
				num = (short)1891696640;
				if (num != 0)
				{
				}
				num = (short)91357185;
				if (num != 0)
				{
				}
				num = (short)655097856;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.UIValue = value;
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x0600BBA9 RID: 48041 RVA: 0x00ADED8C File Offset: 0x00ADCF8C
		// (set) Token: 0x0600BBAA RID: 48042 RVA: 0x00ADEE40 File Offset: 0x00ADD040
		internal int CnvSysGeneralPreambles_A8731Min
		{
			get
			{
				short num = (short)1275703689;
				short num2 = num;
				num = (short)311800201;
				switch (num2 == num)
				{
				}
				num = (short)1867644928;
				if (num != 0)
				{
				}
				num = (short)879624193;
				if (num != 0)
				{
				}
				num = (short)1891237888;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Min;
			}
			set
			{
				short num = (short)1367357882;
				short num2 = num;
				num = (short)899103162;
				switch (num2 == num)
				{
				}
				num = (short)1301479424;
				if (num != 0)
				{
				}
				num = (short)651886593;
				if (num != 0)
				{
				}
				num = (short)389677056;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Min = value;
			}
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x0600BBAB RID: 48043 RVA: 0x00ADEEF4 File Offset: 0x00ADD0F4
		// (set) Token: 0x0600BBAC RID: 48044 RVA: 0x00ADEFA8 File Offset: 0x00ADD1A8
		internal int CnvSysGeneralPreambles_A8731Max
		{
			get
			{
				short num = (short)577156045;
				short num2 = num;
				num = (short)485929933;
				switch (num2 == num)
				{
				}
				num = (short)436142081;
				if (num != 0)
				{
				}
				num = (short)1589510144;
				if (num != 0)
				{
				}
				num = (short)2089680896;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Max;
			}
			set
			{
				short num = (short)1783076905;
				short num2 = num;
				num = (short)1983551529;
				switch (num2 == num)
				{
				}
				num = (short)1961426945;
				if (num != 0)
				{
				}
				num = (short)536281088;
				if (num != 0)
				{
				}
				num = (short)2053832704;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Max = value;
			}
		}

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x0600BBAD RID: 48045 RVA: 0x00ADF060 File Offset: 0x00ADD260
		// (set) Token: 0x0600BBAE RID: 48046 RVA: 0x00ADF110 File Offset: 0x00ADD310
		internal int CnvSysGeneralPreambles_A8731Step
		{
			get
			{
				short num = (short)1967695886;
				short num2 = num;
				num = (short)1725605902;
				switch (num2 == num)
				{
				}
				num = (short)48037888;
				if (num != 0)
				{
				}
				num = (short)1908539393;
				if (num != 0)
				{
				}
				num = (short)1938096128;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.StepSize;
			}
			set
			{
				short num = (short)702603392;
				short num2 = num;
				num = (short)1922752640;
				switch (num2 == num)
				{
				}
				num = (short)1910112257;
				if (num != 0)
				{
				}
				num = (short)1444085760;
				if (num != 0)
				{
				}
				num = (short)1252130816;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.StepSize = value;
			}
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x0600BBAF RID: 48047 RVA: 0x00ADF1C4 File Offset: 0x00ADD3C4
		// (set) Token: 0x0600BBB0 RID: 48048 RVA: 0x00ADF27C File Offset: 0x00ADD47C
		public bool CnvSysGeneralPreambles_A8731_Applicable
		{
			get
			{
				short num = (short)24425405;
				short num2 = num;
				num = (short)16954301;
				switch (num2 == num)
				{
				}
				num = (short)849149952;
				if (num != 0)
				{
				}
				num = (short)637861889;
				if (num != 0)
				{
				}
				num = (short)992935936;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Applicable;
			}
			set
			{
				short num = (short)1697579009;
				if (num != 0)
				{
				}
				num = (short)108206818;
				short num2 = num;
				num = (short)1380063970;
				switch (num2 == num)
				{
				}
				num = (short)1587609600;
				if (num != 0)
				{
				}
				num = (short)53542912;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Applicable = value;
			}
		}

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x0600BBB1 RID: 48049 RVA: 0x00ADF330 File Offset: 0x00ADD530
		// (set) Token: 0x0600BBB2 RID: 48050 RVA: 0x00ADF3E4 File Offset: 0x00ADD5E4
		public bool CnvSysGeneralPreambles_A8731_Valid
		{
			get
			{
				short num = (short)1095989786;
				short num2 = num;
				num = (short)256473626;
				switch (num2 == num)
				{
				}
				num = (short)2077556736;
				if (num != 0)
				{
				}
				num = (short)1581318145;
				if (num != 0)
				{
				}
				num = (short)1095892992;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Valid;
			}
			set
			{
				short num = (short)1060679271;
				short num2 = num;
				num = (short)1627696743;
				switch (num2 == num)
				{
				}
				num = (short)1117192193;
				if (num != 0)
				{
				}
				num = (short)268763136;
				if (num != 0)
				{
				}
				num = (short)791150592;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Valid = value;
			}
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x0600BBB3 RID: 48051 RVA: 0x00ADF49C File Offset: 0x00ADD69C
		// (set) Token: 0x0600BBB4 RID: 48052 RVA: 0x00ADF550 File Offset: 0x00ADD750
		public bool CnvSysGeneralPreambles_A8731_Visible
		{
			get
			{
				short num = (short)291888431;
				short num2 = num;
				num = (short)296148271;
				switch (num2 == num)
				{
				}
				num = (short)2119499777;
				if (num != 0)
				{
				}
				num = (short)1679163392;
				if (num != 0)
				{
				}
				num = (short)1395851264;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Visible;
			}
			set
			{
				short num = (short)1018378811;
				short num2 = num;
				num = (short)1707227707;
				switch (num2 == num)
				{
				}
				num = (short)1299972096;
				if (num != 0)
				{
				}
				num = (short)234684417;
				if (num != 0)
				{
				}
				num = (short)487915520;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Visible = value;
			}
		}

		// Token: 0x17005E18 RID: 24088
		// (get) Token: 0x0600BBB5 RID: 48053 RVA: 0x00ADF604 File Offset: 0x00ADD804
		// (set) Token: 0x0600BBB6 RID: 48054 RVA: 0x00ADF6B8 File Offset: 0x00ADD8B8
		public bool CnvSysGeneralPreambles_A8731_Editable
		{
			get
			{
				short num = (short)1107631315;
				short num2 = num;
				num = (short)2117082323;
				switch (num2 == num)
				{
				}
				num = (short)2004156417;
				if (num != 0)
				{
				}
				num = (short)567803904;
				if (num != 0)
				{
				}
				num = (short)70320128;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.Editable;
			}
			set
			{
				short num = (short)1021888865;
				short num2 = num;
				num = (short)1262471521;
				switch (num2 == num)
				{
				}
				num = (short)480575489;
				if (num != 0)
				{
				}
				num = (short)2094530560;
				if (num != 0)
				{
				}
				num = (short)1639186432;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.Editable = value;
			}
		}

		// Token: 0x17005E19 RID: 24089
		// (get) Token: 0x0600BBB7 RID: 48055 RVA: 0x00ADF76C File Offset: 0x00ADD96C
		internal string CnvSysGeneralPreambles_A8731_UILabel
		{
			get
			{
				short num = (short)1990132936;
				short num2 = num;
				num = (short)2071856328;
				switch (num2 == num)
				{
				}
				num = (short)1677131777;
				if (num != 0)
				{
				}
				num = (short)427753472;
				if (num != 0)
				{
				}
				num = (short)2087911424;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.UIName;
			}
		}

		// Token: 0x17005E1A RID: 24090
		// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x00ADF820 File Offset: 0x00ADDA20
		// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x00ADF8D4 File Offset: 0x00ADDAD4
		internal bool CnvSysGeneralPreambles_A8731_HiddenStatic
		{
			get
			{
				short num = (short)980584337;
				short num2 = num;
				num = (short)1365411729;
				switch (num2 == num)
				{
				}
				num = (short)681312256;
				if (num != 0)
				{
				}
				num = (short)282591233;
				if (num != 0)
				{
				}
				num = (short)1363214336;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.HiddenStatic;
			}
			set
			{
				short num = (short)1820085029;
				short num2 = num;
				num = (short)1006717733;
				switch (num2 == num)
				{
				}
				num = (short)1113128961;
				if (num != 0)
				{
				}
				num = (short)2091122688;
				if (num != 0)
				{
				}
				num = (short)428343296;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.HiddenStatic = value;
			}
		}

		// Token: 0x17005E1B RID: 24091
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x00ADF98C File Offset: 0x00ADDB8C
		// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x00ADFA40 File Offset: 0x00ADDC40
		internal bool CnvSysGeneralPreambles_A8731_HiddenDynamic
		{
			get
			{
				short num = (short)526254081;
				if (num != 0)
				{
				}
				num = (short)1245233516;
				short num2 = num;
				num = (short)483901804;
				switch (num2 == num)
				{
				}
				num = (short)1262878720;
				if (num != 0)
				{
				}
				num = (short)1027997696;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731.HiddenDynamic;
			}
			set
			{
				short num = (short)706927411;
				short num2 = num;
				num = (short)762829619;
				switch (num2 == num)
				{
				}
				num = (short)1462763520;
				if (num != 0)
				{
				}
				num = (short)1356857345;
				if (num != 0)
				{
				}
				num = (short)1238564864;
				short num3 = num;
				this.cnvSysGeneralPreambles_A8731.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E1C RID: 24092
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x00ADFAF0 File Offset: 0x00ADDCF0
		public bool CnvSysGeneralPreambles_A8731_HasDiffs
		{
			get
			{
				short num = (short)166868709;
				short num2 = num;
				num = (short)406337253;
				switch (num2 == num)
				{
				}
				num = (short)1863909376;
				if (num != 0)
				{
				}
				num = (short)781058049;
				if (num != 0)
				{
				}
				num = (short)1489567744;
				short num3 = num;
				return this.cnvSysGeneralPreambles_A8731._HasDiffs;
			}
		}

		// Token: 0x17005E1D RID: 24093
		// (get) Token: 0x0600BBBD RID: 48061 RVA: 0x00ADFBA4 File Offset: 0x00ADDDA4
		// (set) Token: 0x0600BBBE RID: 48062 RVA: 0x00ADFC58 File Offset: 0x00ADDE58
		public int CnvSysGeneralRepeaterAccessPretimems_A8741Value
		{
			get
			{
				short num = (short)472325773;
				short num2 = num;
				num = (short)769924749;
				switch (num2 == num)
				{
				}
				num = (short)1389166593;
				if (num != 0)
				{
				}
				num = (short)463011840;
				if (num != 0)
				{
				}
				num = (short)2120744960;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Value;
			}
			set
			{
				short num = (short)1256504539;
				short num2 = num;
				num = (short)1689042139;
				switch (num2 == num)
				{
				}
				num = (short)368050177;
				if (num != 0)
				{
				}
				num = (short)2112552960;
				if (num != 0)
				{
				}
				num = (short)201719808;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Value = value;
			}
		}

		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x0600BBBF RID: 48063 RVA: 0x00ADFD0C File Offset: 0x00ADDF0C
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralRepeaterAccessPretimems_A8741
		{
			get
			{
				short num = (short)1798410332;
				short num2 = num;
				num = (short)616534108;
				switch (num2 == num)
				{
				}
				num = (short)46727168;
				if (num != 0)
				{
				}
				num = (short)142278657;
				if (num != 0)
				{
				}
				num = (short)2029715456;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741;
			}
		}

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x0600BBC0 RID: 48064 RVA: 0x00ADFDB8 File Offset: 0x00ADDFB8
		// (set) Token: 0x0600BBC1 RID: 48065 RVA: 0x00ADFE6C File Offset: 0x00ADE06C
		public string CnvSysGeneralRepeaterAccessPretimems_A8741_UIValue
		{
			get
			{
				short num = (short)1082004589;
				short num2 = num;
				num = (short)427037805;
				switch (num2 == num)
				{
				}
				num = (short)1928331265;
				if (num != 0)
				{
				}
				num = (short)115736576;
				if (num != 0)
				{
				}
				num = (short)1636433920;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.UIValue;
			}
			set
			{
				short num = (short)206266995;
				short num2 = num;
				num = (short)409887347;
				switch (num2 == num)
				{
				}
				num = (short)870842369;
				if (num != 0)
				{
				}
				num = (short)1257439232;
				if (num != 0)
				{
				}
				num = (short)1076494336;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.UIValue = value;
			}
		}

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x00ADFF24 File Offset: 0x00ADE124
		// (set) Token: 0x0600BBC3 RID: 48067 RVA: 0x00ADFFDC File Offset: 0x00ADE1DC
		internal int CnvSysGeneralRepeaterAccessPretimems_A8741Min
		{
			get
			{
				short num = (short)1622479847;
				short num2 = num;
				num = (short)655692775;
				switch (num2 == num)
				{
				}
				num = (short)116719616;
				if (num != 0)
				{
				}
				num = (short)978780161;
				if (num != 0)
				{
				}
				num = (short)1676869632;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Min;
			}
			set
			{
				short num = (short)425000961;
				if (num != 0)
				{
				}
				num = (short)2118469408;
				short num2 = num;
				num = (short)829900576;
				switch (num2 == num)
				{
				}
				num = (short)1800077312;
				if (num != 0)
				{
				}
				num = (short)557056000;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Min = value;
			}
		}

		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x00AE0090 File Offset: 0x00ADE290
		// (set) Token: 0x0600BBC5 RID: 48069 RVA: 0x00AE0144 File Offset: 0x00ADE344
		internal int CnvSysGeneralRepeaterAccessPretimems_A8741Max
		{
			get
			{
				short num = (short)557636609;
				short num2 = num;
				num = (short)23452673;
				switch (num2 == num)
				{
				}
				num = (short)86441985;
				if (num != 0)
				{
				}
				num = (short)325451776;
				if (num != 0)
				{
				}
				num = (short)4784128;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Max;
			}
			set
			{
				short num = (short)767567368;
				short num2 = num;
				num = (short)1699554824;
				switch (num2 == num)
				{
				}
				num = (short)1379401729;
				if (num != 0)
				{
				}
				num = (short)1106182144;
				if (num != 0)
				{
				}
				num = (short)1773010944;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Max = value;
			}
		}

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x00AE01F8 File Offset: 0x00ADE3F8
		// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x00AE02AC File Offset: 0x00ADE4AC
		internal int CnvSysGeneralRepeaterAccessPretimems_A8741Step
		{
			get
			{
				short num = (short)1543930034;
				short num2 = num;
				num = (short)1777303730;
				switch (num2 == num)
				{
				}
				num = (short)1119092736;
				if (num != 0)
				{
				}
				num = (short)799211521;
				if (num != 0)
				{
				}
				num = (short)285409280;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.StepSize;
			}
			set
			{
				short num = (short)1826636671;
				short num2 = num;
				num = (short)12731263;
				switch (num2 == num)
				{
				}
				num = (short)729743361;
				if (num != 0)
				{
				}
				num = (short)845152256;
				if (num != 0)
				{
				}
				num = (short)1098711040;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.StepSize = value;
			}
		}

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x00AE0364 File Offset: 0x00ADE564
		// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x00AE041C File Offset: 0x00ADE61C
		public bool CnvSysGeneralRepeaterAccessPretimems_A8741_Applicable
		{
			get
			{
				short num = (short)1467285505;
				if (num != 0)
				{
				}
				num = (short)1934239037;
				short num2 = num;
				num = (short)1290151229;
				switch (num2 == num)
				{
				}
				num = (short)1729691648;
				if (num != 0)
				{
				}
				num = (short)2047344640;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Applicable;
			}
			set
			{
				short num = (short)1766965035;
				short num2 = num;
				num = (short)543604523;
				switch (num2 == num)
				{
				}
				num = (short)1126563841;
				if (num != 0)
				{
				}
				num = (short)1261436928;
				if (num != 0)
				{
				}
				num = (short)2053439488;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Applicable = value;
			}
		}

		// Token: 0x17005E24 RID: 24100
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x00AE04D0 File Offset: 0x00ADE6D0
		// (set) Token: 0x0600BBCB RID: 48075 RVA: 0x00AE0584 File Offset: 0x00ADE784
		public bool CnvSysGeneralRepeaterAccessPretimems_A8741_Valid
		{
			get
			{
				short num = (short)411746689;
				short num2 = num;
				num = (short)1254867329;
				switch (num2 == num)
				{
				}
				num = (short)1340538881;
				if (num != 0)
				{
				}
				num = (short)1440874496;
				if (num != 0)
				{
				}
				num = (short)2086535168;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Valid;
			}
			set
			{
				short num = (short)428417040;
				short num2 = num;
				num = (short)1813848080;
				switch (num2 == num)
				{
				}
				num = (short)1732182017;
				if (num != 0)
				{
				}
				num = (short)905969664;
				if (num != 0)
				{
				}
				num = (short)1594294272;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Valid = value;
			}
		}

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x00AE0638 File Offset: 0x00ADE838
		// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x00AE06EC File Offset: 0x00ADE8EC
		public bool CnvSysGeneralRepeaterAccessPretimems_A8741_Visible
		{
			get
			{
				short num = (short)1350273645;
				short num2 = num;
				num = (short)926780013;
				switch (num2 == num)
				{
				}
				num = (short)1938685953;
				if (num != 0)
				{
				}
				num = (short)1265106944;
				if (num != 0)
				{
				}
				num = (short)1622081536;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Visible;
			}
			set
			{
				short num = (short)1550819879;
				short num2 = num;
				num = (short)841392679;
				switch (num2 == num)
				{
				}
				num = (short)1742077953;
				if (num != 0)
				{
				}
				num = (short)1071906816;
				if (num != 0)
				{
				}
				num = (short)1507983360;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Visible = value;
			}
		}

		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x00AE07A4 File Offset: 0x00ADE9A4
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x00AE0858 File Offset: 0x00ADEA58
		public bool CnvSysGeneralRepeaterAccessPretimems_A8741_Editable
		{
			get
			{
				short num = (short)1614050809;
				short num2 = num;
				num = (short)1122727417;
				switch (num2 == num)
				{
				}
				num = (short)365821953;
				if (num != 0)
				{
				}
				num = (short)686489600;
				if (num != 0)
				{
				}
				num = (short)670695424;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.Editable;
			}
			set
			{
				short num = (short)1720610303;
				short num2 = num;
				num = (short)1875537407;
				switch (num2 == num)
				{
				}
				num = (short)1749417985;
				if (num != 0)
				{
				}
				num = (short)1908473856;
				if (num != 0)
				{
				}
				num = (short)1617952768;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.Editable = value;
			}
		}

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x0600BBD0 RID: 48080 RVA: 0x00AE090C File Offset: 0x00ADEB0C
		internal string CnvSysGeneralRepeaterAccessPretimems_A8741_UILabel
		{
			get
			{
				short num = (short)1523378591;
				short num2 = num;
				num = (short)525003167;
				switch (num2 == num)
				{
				}
				num = (short)1937899520;
				if (num != 0)
				{
				}
				num = (short)626655233;
				if (num != 0)
				{
				}
				num = (short)1661468672;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.UIName;
			}
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x0600BBD1 RID: 48081 RVA: 0x00AE09C0 File Offset: 0x00ADEBC0
		// (set) Token: 0x0600BBD2 RID: 48082 RVA: 0x00AE0A70 File Offset: 0x00ADEC70
		internal bool CnvSysGeneralRepeaterAccessPretimems_A8741_HiddenStatic
		{
			get
			{
				short num = (short)350018203;
				short num2 = num;
				num = (short)1225382555;
				switch (num2 == num)
				{
				}
				num = (short)475267073;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				if (num != 0)
				{
				}
				num = (short)565248000;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.HiddenStatic;
			}
			set
			{
				short num = (short)625410049;
				if (num != 0)
				{
				}
				num = (short)2005947665;
				short num2 = num;
				num = (short)100619537;
				switch (num2 == num)
				{
				}
				num = (short)1616117760;
				if (num != 0)
				{
				}
				num = (short)1532624896;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.HiddenStatic = value;
			}
		}

		// Token: 0x17005E29 RID: 24105
		// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x00AE0B24 File Offset: 0x00ADED24
		// (set) Token: 0x0600BBD4 RID: 48084 RVA: 0x00AE0BD8 File Offset: 0x00ADEDD8
		internal bool CnvSysGeneralRepeaterAccessPretimems_A8741_HiddenDynamic
		{
			get
			{
				short num = (short)831389697;
				if (num != 0)
				{
				}
				num = (short)1447700284;
				short num2 = num;
				num = (short)1788880700;
				switch (num2 == num)
				{
				}
				num = (short)198443008;
				if (num != 0)
				{
				}
				num = (short)204013568;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741.HiddenDynamic;
			}
			set
			{
				short num = (short)1584820362;
				short num2 = num;
				num = (short)1359704202;
				switch (num2 == num)
				{
				}
				num = (short)259981312;
				if (num != 0)
				{
				}
				num = (short)73203713;
				if (num != 0)
				{
				}
				num = (short)145227776;
				short num3 = num;
				this.cnvSysGeneralRepeaterAccessPretimems_A8741.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x00AE0C8C File Offset: 0x00ADEE8C
		public bool CnvSysGeneralRepeaterAccessPretimems_A8741_HasDiffs
		{
			get
			{
				short num = (short)531988175;
				short num2 = num;
				num = (short)1176862415;
				switch (num2 == num)
				{
				}
				num = (short)1240858625;
				if (num != 0)
				{
				}
				num = (short)2080309248;
				if (num != 0)
				{
				}
				num = (short)1907359744;
				short num3 = num;
				return this.cnvSysGeneralRepeaterAccessPretimems_A8741._HasDiffs;
			}
		}

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x0600BBD6 RID: 48086 RVA: 0x00AE0D40 File Offset: 0x00ADEF40
		// (set) Token: 0x0600BBD7 RID: 48087 RVA: 0x00AE0DF4 File Offset: 0x00ADEFF4
		public int CnvSysGeneralMDCPrimaryID_A8744Value
		{
			get
			{
				short num = (short)1223361798;
				short num2 = num;
				num = (short)1811612934;
				switch (num2 == num)
				{
				}
				num = (short)1796276225;
				if (num != 0)
				{
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				num = (short)1416822784;
				short num3 = num;
				return this.cnvSysGeneralMDCPrimaryID_A8744.Value;
			}
			set
			{
				short num = (short)1283301243;
				short num2 = num;
				num = (short)776642427;
				switch (num2 == num)
				{
				}
				num = (short)1011875840;
				if (num != 0)
				{
				}
				num = (short)664469505;
				if (num != 0)
				{
				}
				num = (short)1316421632;
				short num3 = num;
				this.cnvSysGeneralMDCPrimaryID_A8744.Value = value;
			}
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x0600BBD8 RID: 48088 RVA: 0x00AE0EA8 File Offset: 0x00ADF0A8
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralMDCPrimaryID_A8744
		{
			get
			{
				short num = (short)1021439874;
				short num2 = num;
				num = (short)1492578178;
				switch (num2 == num)
				{
				}
				num = (short)1061093377;
				if (num != 0)
				{
				}
				num = (short)749273088;
				if (num != 0)
				{
				}
				num = (short)1515323392;
				short num3 = num;
				return this.cnvSysGeneralMDCPrimaryID_A8744;
			}
		}

		// Token: 0x17005E2D RID: 24109
		// (get) Token: 0x0600BBD9 RID: 48089 RVA: 0x00AE0F5C File Offset: 0x00ADF15C
		// (set) Token: 0x0600BBDA RID: 48090 RVA: 0x00AE1010 File Offset: 0x00ADF210
		public string CnvSysGeneralMDCPrimaryID_A8744_UIValue
		{
			get
			{
				short num = (short)578097935;
				short num2 = num;
				num = (short)671355663;
				switch (num2 == num)
				{
				}
				num = (short)29097985;
				if (num != 0)
				{
				}
				num = (short)2091778048;
				if (num != 0)
				{
				}
				num = (short)818610176;
				short num3 = num;
				return this.cnvSysGeneralMDCPrimaryID_A8744.UIValue;
			}
			set
			{
				short num = (short)140240694;
				short num2 = num;
				num = (short)623830838;
				switch (num2 == num)
				{
				}
				num = (short)373358593;
				if (num != 0)
				{
				}
				num = (short)1995571200;
				short num3 = num;
				num = (short)1604583424;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.UIValue = value;
			}
		}

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x00AE10C8 File Offset: 0x00ADF2C8
		// (set) Token: 0x0600BBDC RID: 48092 RVA: 0x00AE117C File Offset: 0x00ADF37C
		internal int CnvSysGeneralMDCPrimaryID_A8744Min
		{
			get
			{
				short num = (short)1621216871;
				short num2 = num;
				num = (short)1912655463;
				switch (num2 == num)
				{
				}
				num = (short)1315766273;
				if (num != 0)
				{
				}
				num = (short)936574976;
				short num3 = num;
				num = (short)1261436928;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Min;
			}
			set
			{
				short num = (short)2108547508;
				short num2 = num;
				num = (short)513401268;
				switch (num2 == num)
				{
				}
				num = (short)513802241;
				if (num != 0)
				{
				}
				num = (short)267649024;
				short num3 = num;
				num = (short)86638592;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Min = value;
			}
		}

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x00AE1234 File Offset: 0x00ADF434
		// (set) Token: 0x0600BBDE RID: 48094 RVA: 0x00AE12EC File Offset: 0x00ADF4EC
		internal int CnvSysGeneralMDCPrimaryID_A8744Max
		{
			get
			{
				short num = (short)1644055772;
				short num2 = num;
				num = (short)188173532;
				switch (num2 == num)
				{
				}
				num = (short)890175489;
				if (num != 0)
				{
				}
				num = (short)1414332416;
				short num3 = num;
				num = (short)347996160;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Max;
			}
			set
			{
				short num = (short)209273803;
				short num2 = num;
				num = (short)1557087179;
				switch (num2 == num)
				{
				}
				num = (short)1607532545;
				if (num != 0)
				{
				}
				num = (short)110166016;
				short num3 = num;
				num = (short)954728448;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Max = value;
			}
		}

		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x0600BBDF RID: 48095 RVA: 0x00AE13A0 File Offset: 0x00ADF5A0
		// (set) Token: 0x0600BBE0 RID: 48096 RVA: 0x00AE1454 File Offset: 0x00ADF654
		internal int CnvSysGeneralMDCPrimaryID_A8744Step
		{
			get
			{
				short num = (short)1497384556;
				short num2 = num;
				num = (short)27018860;
				switch (num2 == num)
				{
				}
				num = (short)1671430145;
				if (num != 0)
				{
				}
				num = (short)1736900608;
				short num3 = num;
				num = (short)478281728;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.StepSize;
			}
			set
			{
				short num = (short)740684974;
				short num2 = num;
				num = (short)391967918;
				switch (num2 == num)
				{
				}
				num = (short)665387009;
				if (num != 0)
				{
				}
				num = (short)2029912064;
				short num3 = num;
				num = (short)1365442560;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.StepSize = value;
			}
		}

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x0600BBE1 RID: 48097 RVA: 0x00AE1508 File Offset: 0x00ADF708
		// (set) Token: 0x0600BBE2 RID: 48098 RVA: 0x00AE15C0 File Offset: 0x00ADF7C0
		public bool CnvSysGeneralMDCPrimaryID_A8744_Applicable
		{
			get
			{
				short num = (short)134719838;
				short num2 = num;
				num = (short)700426590;
				switch (num2 == num)
				{
				}
				num = (short)1787494401;
				if (num != 0)
				{
				}
				num = (short)1624702976;
				short num3 = num;
				num = (short)1976762368;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Applicable;
			}
			set
			{
				short num = (short)1698406239;
				short num2 = num;
				num = (short)171089759;
				switch (num2 == num)
				{
				}
				num = (short)204013569;
				if (num != 0)
				{
				}
				num = (short)849018880;
				short num3 = num;
				num = (short)56885248;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Applicable = value;
			}
		}

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x0600BBE3 RID: 48099 RVA: 0x00AE1674 File Offset: 0x00ADF874
		// (set) Token: 0x0600BBE4 RID: 48100 RVA: 0x00AE1728 File Offset: 0x00ADF928
		public bool CnvSysGeneralMDCPrimaryID_A8744_Valid
		{
			get
			{
				short num = (short)1167799734;
				short num2 = num;
				num = (short)1103508918;
				switch (num2 == num)
				{
				}
				num = (short)1449000961;
				if (num != 0)
				{
				}
				num = (short)663683072;
				short num3 = num;
				num = (short)1834483712;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Valid;
			}
			set
			{
				short num = (short)1260819494;
				short num2 = num;
				num = (short)1778684966;
				switch (num2 == num)
				{
				}
				num = (short)1983774720;
				if (num != 0)
				{
				}
				num = (short)1066991616;
				short num3 = num;
				num = (short)1552809985;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Valid = value;
			}
		}

		// Token: 0x17005E33 RID: 24115
		// (get) Token: 0x0600BBE5 RID: 48101 RVA: 0x00AE17E4 File Offset: 0x00ADF9E4
		// (set) Token: 0x0600BBE6 RID: 48102 RVA: 0x00AE189C File Offset: 0x00ADFA9C
		public bool CnvSysGeneralMDCPrimaryID_A8744_Visible
		{
			get
			{
				short num = (short)358023169;
				if (num != 0)
				{
				}
				num = (short)27892064;
				short num2 = num;
				num = (short)429562208;
				switch (num2 == num)
				{
				}
				num = (short)1851981824;
				short num3 = num;
				num = (short)354811904;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Visible;
			}
			set
			{
				short num = (short)1144772540;
				short num2 = num;
				num = (short)1696061372;
				switch (num2 == num)
				{
				}
				num = (short)1237123073;
				if (num != 0)
				{
				}
				num = (short)1616707584;
				short num3 = num;
				num = (short)493027328;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Visible = value;
			}
		}

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x00AE1950 File Offset: 0x00ADFB50
		// (set) Token: 0x0600BBE8 RID: 48104 RVA: 0x00AE1A04 File Offset: 0x00ADFC04
		public bool CnvSysGeneralMDCPrimaryID_A8744_Editable
		{
			get
			{
				short num = (short)2128803033;
				short num2 = num;
				num = (short)909833433;
				switch (num2 == num)
				{
				}
				num = (short)1700003841;
				if (num != 0)
				{
				}
				num = (short)58982400;
				short num3 = num;
				num = (short)769523712;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.Editable;
			}
			set
			{
				short num = (short)1498284033;
				if (num != 0)
				{
				}
				num = (short)737999208;
				short num2 = num;
				num = (short)857209192;
				switch (num2 == num)
				{
				}
				num = (short)1276182528;
				short num3 = num;
				num = (short)653656064;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.Editable = value;
			}
		}

		// Token: 0x17005E35 RID: 24117
		// (get) Token: 0x0600BBE9 RID: 48105 RVA: 0x00AE1ABC File Offset: 0x00ADFCBC
		internal string CnvSysGeneralMDCPrimaryID_A8744_UILabel
		{
			get
			{
				short num = (short)935815912;
				short num2 = num;
				num = (short)1437428456;
				switch (num2 == num)
				{
				}
				num = (short)648019968;
				if (num != 0)
				{
				}
				num = (short)1243217920;
				short num3 = num;
				num = (short)1133707265;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.UIName;
			}
		}

		// Token: 0x17005E36 RID: 24118
		// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x00AE1B70 File Offset: 0x00ADFD70
		// (set) Token: 0x0600BBEB RID: 48107 RVA: 0x00AE1C20 File Offset: 0x00ADFE20
		internal bool CnvSysGeneralMDCPrimaryID_A8744_HiddenStatic
		{
			get
			{
				short num = (short)935245810;
				short num2 = num;
				num = (short)1984018418;
				switch (num2 == num)
				{
				}
				num = (short)1223491585;
				if (num != 0)
				{
				}
				num = (short)1761607680;
				short num3 = num;
				num = (short)392953856;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.HiddenStatic;
			}
			set
			{
				short num = (short)599948048;
				short num2 = num;
				num = (short)46234384;
				switch (num2 == num)
				{
				}
				num = (short)695009281;
				if (num != 0)
				{
				}
				num = (short)1308295168;
				short num3 = num;
				num = (short)274726912;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.HiddenStatic = value;
			}
		}

		// Token: 0x17005E37 RID: 24119
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x00AE1CD4 File Offset: 0x00ADFED4
		// (set) Token: 0x0600BBED RID: 48109 RVA: 0x00AE1D88 File Offset: 0x00ADFF88
		internal bool CnvSysGeneralMDCPrimaryID_A8744_HiddenDynamic
		{
			get
			{
				short num = (short)1528257362;
				short num2 = num;
				num = (short)458185554;
				switch (num2 == num)
				{
				}
				num = (short)847249408;
				if (num != 0)
				{
				}
				num = (short)1244266496;
				short num3 = num;
				num = (short)447283201;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744.HiddenDynamic;
			}
			set
			{
				short num = (short)460302673;
				short num2 = num;
				num = (short)1596107089;
				switch (num2 == num)
				{
				}
				num = (short)2076246017;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				short num3 = num;
				num = (short)1101529088;
				if (num != 0)
				{
				}
				this.cnvSysGeneralMDCPrimaryID_A8744.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E38 RID: 24120
		// (get) Token: 0x0600BBEE RID: 48110 RVA: 0x00AE1E3C File Offset: 0x00AE003C
		public bool CnvSysGeneralMDCPrimaryID_A8744_HasDiffs
		{
			get
			{
				short num = (short)1383137281;
				if (num != 0)
				{
				}
				num = (short)659913307;
				short num2 = num;
				num = (short)1733458523;
				switch (num2 == num)
				{
				}
				num = (short)1601306624;
				short num3 = num;
				num = (short)1265238016;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralMDCPrimaryID_A8744._HasDiffs;
			}
		}

		// Token: 0x17005E39 RID: 24121
		// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x00AE1EEC File Offset: 0x00AE00EC
		// (set) Token: 0x0600BBF0 RID: 48112 RVA: 0x00AE1FA0 File Offset: 0x00AE01A0
		public int CnvSysGeneralSidetones_A8774Value
		{
			get
			{
				short num = (short)1766778217;
				short num2 = num;
				num = (short)1997006185;
				switch (num2 == num)
				{
				}
				num = (short)443809793;
				if (num != 0)
				{
				}
				num = (short)1038548992;
				short num3 = num;
				num = (short)1471021056;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.Value;
			}
			set
			{
				short num = (short)1768095745;
				if (num != 0)
				{
				}
				num = (short)1855771947;
				short num2 = num;
				num = (short)186111275;
				switch (num2 == num)
				{
				}
				num = (short)1647706112;
				short num3 = num;
				num = (short)1417805824;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.Value = value;
			}
		}

		// Token: 0x17005E3A RID: 24122
		// (get) Token: 0x0600BBF1 RID: 48113 RVA: 0x00AE2058 File Offset: 0x00AE0258
		// (set) Token: 0x0600BBF2 RID: 48114 RVA: 0x00AE2110 File Offset: 0x00AE0310
		public string CnvSysGeneralSidetones_A8774_UIValue
		{
			get
			{
				short num = (short)121656172;
				short num2 = num;
				num = (short)1529959276;
				switch (num2 == num)
				{
				}
				num = (short)874250241;
				if (num != 0)
				{
				}
				num = (short)1376190464;
				short num3 = num;
				num = (short)2056323072;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.UIValue;
			}
			set
			{
				short num = (short)116457473;
				if (num != 0)
				{
				}
				num = (short)290451860;
				short num2 = num;
				num = (short)396947860;
				switch (num2 == num)
				{
				}
				num = (short)1209729024;
				short num3 = num;
				num = (short)1282015232;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.UIValue = value;
			}
		}

		// Token: 0x17005E3B RID: 24123
		// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x00AE21C4 File Offset: 0x00AE03C4
		public global::AcpBusinessLayer.AcpListField CnvSysGeneralSidetones_A8774
		{
			get
			{
				short num = (short)34430025;
				short num2 = num;
				num = (short)816471113;
				switch (num2 == num)
				{
				}
				num = (short)42270721;
				if (num != 0)
				{
				}
				num = (short)857407488;
				short num3 = num;
				num = (short)2115829760;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774;
			}
		}

		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x00AE2270 File Offset: 0x00AE0470
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x00AE2324 File Offset: 0x00AE0524
		public bool CnvSysGeneralSidetones_A8774_Applicable
		{
			get
			{
				short num = (short)1010354555;
				short num2 = num;
				num = (short)1293339003;
				switch (num2 == num)
				{
				}
				num = (short)1532428289;
				if (num != 0)
				{
				}
				num = (short)1533476864;
				short num3 = num;
				num = (short)1209991168;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.Applicable;
			}
			set
			{
				short num = (short)1209570719;
				short num2 = num;
				num = (short)501323167;
				switch (num2 == num)
				{
				}
				num = (short)4063233;
				if (num != 0)
				{
				}
				num = (short)319094784;
				short num3 = num;
				num = (short)1983119360;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.Applicable = value;
			}
		}

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x00AE23DC File Offset: 0x00AE05DC
		// (set) Token: 0x0600BBF7 RID: 48119 RVA: 0x00AE2490 File Offset: 0x00AE0690
		public bool CnvSysGeneralSidetones_A8774_Valid
		{
			get
			{
				short num = (short)1169293313;
				if (num != 0)
				{
				}
				num = (short)1488265169;
				short num2 = num;
				num = (short)1742938065;
				switch (num2 == num)
				{
				}
				num = (short)1604255744;
				short num3 = num;
				num = (short)398852096;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.Valid;
			}
			set
			{
				short num = (short)841979293;
				short num2 = num;
				num = (short)79009181;
				switch (num2 == num)
				{
				}
				num = (short)1806434304;
				if (num != 0)
				{
				}
				num = (short)379781120;
				short num3 = num;
				num = (short)2048917505;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.Valid = value;
			}
		}

		// Token: 0x17005E3E RID: 24126
		// (get) Token: 0x0600BBF8 RID: 48120 RVA: 0x00AE2544 File Offset: 0x00AE0744
		// (set) Token: 0x0600BBF9 RID: 48121 RVA: 0x00AE25F8 File Offset: 0x00AE07F8
		public bool CnvSysGeneralSidetones_A8774_Visible
		{
			get
			{
				short num = (short)738745708;
				short num2 = num;
				num = (short)438918508;
				switch (num2 == num)
				{
				}
				num = (short)1898971137;
				if (num != 0)
				{
				}
				num = (short)1850671104;
				short num3 = num;
				num = (short)1245380608;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.Visible;
			}
			set
			{
				short num = (short)286291051;
				short num2 = num;
				num = (short)634811499;
				switch (num2 == num)
				{
				}
				num = (short)1095237633;
				if (num != 0)
				{
				}
				num = (short)1074593792;
				short num3 = num;
				num = (short)1671626752;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.Visible = value;
			}
		}

		// Token: 0x17005E3F RID: 24127
		// (get) Token: 0x0600BBFA RID: 48122 RVA: 0x00AE26AC File Offset: 0x00AE08AC
		// (set) Token: 0x0600BBFB RID: 48123 RVA: 0x00AE2760 File Offset: 0x00AE0960
		public bool CnvSysGeneralSidetones_A8774_Editable
		{
			get
			{
				short num = (short)278222749;
				short num2 = num;
				num = (short)1266898845;
				switch (num2 == num)
				{
				}
				num = (short)1007419393;
				if (num != 0)
				{
				}
				num = (short)1942224896;
				short num3 = num;
				num = (short)1013907456;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.Editable;
			}
			set
			{
				short num = (short)1561381106;
				short num2 = num;
				num = (short)1795279090;
				switch (num2 == num)
				{
				}
				num = (short)101515265;
				if (num != 0)
				{
				}
				num = (short)1140916224;
				short num3 = num;
				num = (short)2044919808;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.Editable = value;
			}
		}

		// Token: 0x17005E40 RID: 24128
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x00AE2818 File Offset: 0x00AE0A18
		internal string CnvSysGeneralSidetones_A8774_UILabel
		{
			get
			{
				short num = (short)1523269330;
				short num2 = num;
				num = (short)1138245330;
				switch (num2 == num)
				{
				}
				num = (short)1035534337;
				if (num != 0)
				{
				}
				num = (short)1757216768;
				short num3 = num;
				num = (short)1316421632;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.UIName;
			}
		}

		// Token: 0x17005E41 RID: 24129
		// (get) Token: 0x0600BBFD RID: 48125 RVA: 0x00AE28CC File Offset: 0x00AE0ACC
		// (set) Token: 0x0600BBFE RID: 48126 RVA: 0x00AE2980 File Offset: 0x00AE0B80
		internal bool CnvSysGeneralSidetones_A8774_HiddenStatic
		{
			get
			{
				short num = (short)789688907;
				short num2 = num;
				num = (short)1187099211;
				switch (num2 == num)
				{
				}
				num = (short)436731905;
				if (num != 0)
				{
				}
				num = (short)79101952;
				short num3 = num;
				num = (short)233963520;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.HiddenStatic;
			}
			set
			{
				short num = (short)1112236490;
				short num2 = num;
				num = (short)1741316554;
				switch (num2 == num)
				{
				}
				num = (short)1178927105;
				if (num != 0)
				{
				}
				num = (short)1018953728;
				short num3 = num;
				num = (short)1964048384;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.HiddenStatic = value;
			}
		}

		// Token: 0x17005E42 RID: 24130
		// (get) Token: 0x0600BBFF RID: 48127 RVA: 0x00AE2A34 File Offset: 0x00AE0C34
		// (set) Token: 0x0600BC00 RID: 48128 RVA: 0x00AE2AE8 File Offset: 0x00AE0CE8
		internal bool CnvSysGeneralSidetones_A8774_HiddenDynamic
		{
			get
			{
				short num = (short)1057020001;
				short num2 = num;
				num = (short)1450039393;
				switch (num2 == num)
				{
				}
				num = (short)1635581952;
				if (num != 0)
				{
				}
				num = (short)1831600128;
				short num3 = num;
				num = (short)1806106625;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774.HiddenDynamic;
			}
			set
			{
				short num = (short)1728543583;
				short num2 = num;
				num = (short)193559391;
				switch (num2 == num)
				{
				}
				num = (short)1216544768;
				if (num != 0)
				{
				}
				num = (short)1392115712;
				short num3 = num;
				num = (short)1886650369;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSidetones_A8774.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x00AE2B9C File Offset: 0x00AE0D9C
		public bool CnvSysGeneralSidetones_A8774_HasDiffs
		{
			get
			{
				short num = (short)187988757;
				short num2 = num;
				num = (short)1598913301;
				switch (num2 == num)
				{
				}
				num = (short)160825345;
				if (num != 0)
				{
				}
				num = (short)1706950656;
				short num3 = num;
				num = (short)1839529984;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSidetones_A8774._HasDiffs;
			}
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x00AE2C54 File Offset: 0x00AE0E54
		// (set) Token: 0x0600BC03 RID: 48131 RVA: 0x00AE2D08 File Offset: 0x00AE0F08
		public int CnvSysGeneralSecondaryID_A9065Value
		{
			get
			{
				short num = (short)364773377;
				if (num != 0)
				{
				}
				num = (short)1731603298;
				short num2 = num;
				num = (short)1477389154;
				switch (num2 == num)
				{
				}
				num = (short)482213888;
				short num3 = num;
				num = (short)1632829440;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Value;
			}
			set
			{
				short num = (short)1320804622;
				short num2 = num;
				num = (short)1048568078;
				switch (num2 == num)
				{
				}
				num = (short)37683201;
				if (num != 0)
				{
				}
				num = (short)1146093568;
				short num3 = num;
				num = (short)1183645696;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Value = value;
			}
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x00AE2DBC File Offset: 0x00AE0FBC
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralSecondaryID_A9065
		{
			get
			{
				short num = (short)755106504;
				short num2 = num;
				num = (short)225247944;
				switch (num2 == num)
				{
				}
				num = (short)1137967104;
				if (num != 0)
				{
				}
				num = (short)667484160;
				short num3 = num;
				num = (short)146931713;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065;
			}
		}

		// Token: 0x17005E46 RID: 24134
		// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x00AE2E6C File Offset: 0x00AE106C
		// (set) Token: 0x0600BC06 RID: 48134 RVA: 0x00AE2F24 File Offset: 0x00AE1124
		public string CnvSysGeneralSecondaryID_A9065_UIValue
		{
			get
			{
				short num = (short)2144747587;
				short num2 = num;
				num = (short)228212803;
				switch (num2 == num)
				{
				}
				num = (short)1337131009;
				if (num != 0)
				{
				}
				num = (short)903282688;
				short num3 = num;
				num = (short)887816192;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.UIValue;
			}
			set
			{
				short num = (short)1244846553;
				short num2 = num;
				num = (short)985913817;
				switch (num2 == num)
				{
				}
				num = (short)1724186625;
				if (num != 0)
				{
				}
				num = (short)811073536;
				short num3 = num;
				num = (short)1209532416;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.UIValue = value;
			}
		}

		// Token: 0x17005E47 RID: 24135
		// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x00AE2FD8 File Offset: 0x00AE11D8
		// (set) Token: 0x0600BC08 RID: 48136 RVA: 0x00AE308C File Offset: 0x00AE128C
		internal int CnvSysGeneralSecondaryID_A9065Min
		{
			get
			{
				short num = (short)1845645374;
				short num2 = num;
				num = (short)1242189886;
				switch (num2 == num)
				{
				}
				num = (short)1161691136;
				if (num != 0)
				{
				}
				num = (short)1864040448;
				short num3 = num;
				num = (short)6946817;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Min;
			}
			set
			{
				short num = (short)1023214303;
				short num2 = num;
				num = (short)1262224095;
				switch (num2 == num)
				{
				}
				num = (short)1653342209;
				if (num != 0)
				{
				}
				num = (short)1801977856;
				short num3 = num;
				num = (short)1608515584;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Min = value;
			}
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x00AE3144 File Offset: 0x00AE1344
		// (set) Token: 0x0600BC0A RID: 48138 RVA: 0x00AE31F8 File Offset: 0x00AE13F8
		internal int CnvSysGeneralSecondaryID_A9065Max
		{
			get
			{
				short num = (short)1115250743;
				short num2 = num;
				num = (short)1759600695;
				switch (num2 == num)
				{
				}
				num = (short)1655177217;
				if (num != 0)
				{
				}
				num = (short)448200704;
				short num3 = num;
				num = (short)734789632;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Max;
			}
			set
			{
				short num = (short)894840276;
				short num2 = num;
				num = (short)1011232212;
				switch (num2 == num)
				{
				}
				num = (short)1842872320;
				if (num != 0)
				{
				}
				num = (short)1094123520;
				short num3 = num;
				num = (short)1903886337;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Max = value;
			}
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x0600BC0B RID: 48139 RVA: 0x00AE32AC File Offset: 0x00AE14AC
		// (set) Token: 0x0600BC0C RID: 48140 RVA: 0x00AE3360 File Offset: 0x00AE1560
		internal int CnvSysGeneralSecondaryID_A9065Step
		{
			get
			{
				short num = (short)1747322274;
				short num2 = num;
				num = (short)1557333410;
				switch (num2 == num)
				{
				}
				num = (short)121110528;
				if (num != 0)
				{
				}
				num = (short)504954880;
				short num3 = num;
				num = (short)1785790465;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.StepSize;
			}
			set
			{
				short num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)433178333;
				short num2 = num;
				num = (short)1021298397;
				switch (num2 == num)
				{
				}
				num = (short)123076608;
				short num3 = num;
				num = (short)362545152;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.StepSize = value;
			}
		}

		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x0600BC0D RID: 48141 RVA: 0x00AE3414 File Offset: 0x00AE1614
		// (set) Token: 0x0600BC0E RID: 48142 RVA: 0x00AE34C8 File Offset: 0x00AE16C8
		public bool CnvSysGeneralSecondaryID_A9065_Applicable
		{
			get
			{
				short num = (short)357861878;
				short num2 = num;
				num = (short)580487670;
				switch (num2 == num)
				{
				}
				num = (short)610140161;
				if (num != 0)
				{
				}
				num = (short)1312620544;
				short num3 = num;
				num = (short)1117978624;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Applicable;
			}
			set
			{
				short num = (short)2124760105;
				short num2 = num;
				num = (short)1645495337;
				switch (num2 == num)
				{
				}
				num = (short)482672640;
				if (num != 0)
				{
				}
				num = (short)1945436160;
				short num3 = num;
				num = (short)964100097;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Applicable = value;
			}
		}

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x0600BC0F RID: 48143 RVA: 0x00AE3580 File Offset: 0x00AE1780
		// (set) Token: 0x0600BC10 RID: 48144 RVA: 0x00AE3634 File Offset: 0x00AE1834
		public bool CnvSysGeneralSecondaryID_A9065_Valid
		{
			get
			{
				short num = (short)1747863089;
				short num2 = num;
				num = (short)44254769;
				switch (num2 == num)
				{
				}
				num = (short)815071233;
				if (num != 0)
				{
				}
				num = (short)444792832;
				short num3 = num;
				num = (short)746455040;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Valid;
			}
			set
			{
				short num = (short)1164744884;
				short num2 = num;
				num = (short)2057148596;
				switch (num2 == num)
				{
				}
				num = (short)1360723969;
				if (num != 0)
				{
				}
				num = (short)2083979264;
				short num3 = num;
				num = (short)558170112;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Valid = value;
			}
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x00AE36EC File Offset: 0x00AE18EC
		// (set) Token: 0x0600BC12 RID: 48146 RVA: 0x00AE37A0 File Offset: 0x00AE19A0
		public bool CnvSysGeneralSecondaryID_A9065_Visible
		{
			get
			{
				short num = (short)2147090432;
				short num2 = num;
				num = (short)244908492;
				short num3 = num;
				num = (short)1363804620;
				switch (num3 == num)
				{
				}
				num = (short)1664024577;
				if (num != 0)
				{
				}
				num = (short)51642368;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Visible;
			}
			set
			{
				short num = (short)110166016;
				short num2 = num;
				num = (short)1217198395;
				short num3 = num;
				num = (short)2122971451;
				switch (num3 == num)
				{
				}
				num = (short)437125121;
				if (num != 0)
				{
				}
				num = (short)2008547328;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Visible = value;
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x0600BC13 RID: 48147 RVA: 0x00AE3858 File Offset: 0x00AE1A58
		// (set) Token: 0x0600BC14 RID: 48148 RVA: 0x00AE3910 File Offset: 0x00AE1B10
		public bool CnvSysGeneralSecondaryID_A9065_Editable
		{
			get
			{
				short num = (short)859045888;
				short num2 = num;
				num = (short)772640327;
				short num3 = num;
				num = (short)334007879;
				switch (num3 == num)
				{
				}
				num = (short)701497345;
				if (num != 0)
				{
				}
				num = (short)554958848;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.Editable;
			}
			set
			{
				short num = (short)850001920;
				short num2 = num;
				num = (short)1253661511;
				short num3 = num;
				num = (short)200170311;
				switch (num3 == num)
				{
				}
				num = (short)1537540097;
				if (num != 0)
				{
				}
				num = (short)416415744;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.Editable = value;
			}
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x0600BC15 RID: 48149 RVA: 0x00AE39C4 File Offset: 0x00AE1BC4
		internal string CnvSysGeneralSecondaryID_A9065_UILabel
		{
			get
			{
				short num = (short)2072707072;
				short num2 = num;
				num = (short)1322516481;
				if (num != 0)
				{
				}
				num = (short)74049410;
				short num3 = num;
				num = (short)118810498;
				switch (num3 == num)
				{
				}
				num = (short)1978138624;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.UIName;
			}
		}

		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x00AE3A78 File Offset: 0x00AE1C78
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x00AE3B2C File Offset: 0x00AE1D2C
		internal bool CnvSysGeneralSecondaryID_A9065_HiddenStatic
		{
			get
			{
				short num = (short)1338834944;
				short num2 = num;
				num = (short)1184464112;
				short num3 = num;
				num = (short)1408204016;
				switch (num3 == num)
				{
				}
				num = (short)1181876225;
				if (num != 0)
				{
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.HiddenStatic;
			}
			set
			{
				short num = (short)1042808832;
				short num2 = num;
				num = (short)1368547087;
				short num3 = num;
				num = (short)438591247;
				switch (num3 == num)
				{
				}
				num = (short)28246016;
				if (num != 0)
				{
				}
				num = (short)751763457;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.HiddenStatic = value;
			}
		}

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x00AE3BE0 File Offset: 0x00AE1DE0
		// (set) Token: 0x0600BC19 RID: 48153 RVA: 0x00AE3C94 File Offset: 0x00AE1E94
		internal bool CnvSysGeneralSecondaryID_A9065_HiddenDynamic
		{
			get
			{
				short num = (short)1736179712;
				short num2 = num;
				num = (short)834177420;
				short num3 = num;
				num = (short)1060735372;
				switch (num3 == num)
				{
				}
				num = (short)732495873;
				if (num != 0)
				{
				}
				num = (short)1320943616;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065.HiddenDynamic;
			}
			set
			{
				short num = (short)244580352;
				short num2 = num;
				num = (short)1838614978;
				short num3 = num;
				num = (short)154929602;
				switch (num3 == num)
				{
				}
				num = (short)156499969;
				if (num != 0)
				{
				}
				num = (short)2003369984;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSecondaryID_A9065.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x00AE3D48 File Offset: 0x00AE1F48
		public bool CnvSysGeneralSecondaryID_A9065_HasDiffs
		{
			get
			{
				short num = (short)1346240512;
				short num2 = num;
				num = (short)635623497;
				short num3 = num;
				num = (short)1438242889;
				switch (num3 == num)
				{
				}
				num = (short)2087190529;
				if (num != 0)
				{
				}
				num = (short)724959232;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSecondaryID_A9065._HasDiffs;
			}
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0600BC1B RID: 48155 RVA: 0x00AE3DFC File Offset: 0x00AE1FFC
		// (set) Token: 0x0600BC1C RID: 48156 RVA: 0x00AE3EB4 File Offset: 0x00AE20B4
		public int CnvSysGeneralSystemPretimems2_A9246Value
		{
			get
			{
				short num = (short)2014117888;
				short num2 = num;
				num = (short)40771514;
				short num3 = num;
				num = (short)1686380474;
				switch (num3 == num)
				{
				}
				num = (short)1653997568;
				if (num != 0)
				{
				}
				num = (short)1441071105;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Value;
			}
			set
			{
				short num = (short)5701632;
				short num2 = num;
				num = (short)2045198787;
				short num3 = num;
				num = (short)1015824835;
				switch (num3 == num)
				{
				}
				num = (short)791674881;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Value = value;
			}
		}

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x00AE3F68 File Offset: 0x00AE2168
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralSystemPretimems2_A9246
		{
			get
			{
				short num = (short)1510998016;
				short num2 = num;
				num = (short)1504054985;
				short num3 = num;
				num = (short)471338697;
				switch (num3 == num)
				{
				}
				num = (short)1186725888;
				if (num != 0)
				{
				}
				num = (short)1681326081;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246;
			}
		}

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x00AE4018 File Offset: 0x00AE2218
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x00AE40D0 File Offset: 0x00AE22D0
		public string CnvSysGeneralSystemPretimems2_A9246_UIValue
		{
			get
			{
				short num = (short)849477632;
				short num2 = num;
				num = (short)1828847617;
				if (num != 0)
				{
				}
				num = (short)1222227462;
				short num3 = num;
				num = (short)435009030;
				switch (num3 == num)
				{
				}
				num = (short)139001856;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.UIValue;
			}
			set
			{
				short num = (short)917504;
				short num2 = num;
				num = (short)478365468;
				short num3 = num;
				num = (short)1885292316;
				switch (num3 == num)
				{
				}
				num = (short)1512439808;
				if (num != 0)
				{
				}
				num = (short)1036517377;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.UIValue = value;
			}
		}

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x00AE4184 File Offset: 0x00AE2384
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x00AE4234 File Offset: 0x00AE2434
		internal int CnvSysGeneralSystemPretimems2_A9246Min
		{
			get
			{
				short num = (short)760152064;
				short num2 = num;
				num = (short)1885473054;
				short num3 = num;
				num = (short)1380714782;
				switch (num3 == num)
				{
				}
				num = (short)2010120192;
				if (num != 0)
				{
				}
				num = (short)1369112577;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Min;
			}
			set
			{
				short num = (short)1692401664;
				short num2 = num;
				num = (short)1915346832;
				short num3 = num;
				num = (short)522444688;
				switch (num3 == num)
				{
				}
				num = (short)1295384576;
				if (num != 0)
				{
				}
				num = (short)1170866177;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Min = value;
			}
		}

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x00AE42E8 File Offset: 0x00AE24E8
		// (set) Token: 0x0600BC23 RID: 48163 RVA: 0x00AE439C File Offset: 0x00AE259C
		internal int CnvSysGeneralSystemPretimems2_A9246Max
		{
			get
			{
				short num = (short)2097741824;
				short num2 = num;
				num = (short)1864105904;
				short num3 = num;
				num = (short)1256128432;
				switch (num3 == num)
				{
				}
				num = (short)1605500929;
				if (num != 0)
				{
				}
				num = (short)669581312;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Max;
			}
			set
			{
				short num = (short)57278464;
				short num2 = num;
				num = (short)537387069;
				short num3 = num;
				num = (short)1181868093;
				switch (num3 == num)
				{
				}
				num = (short)1315307521;
				if (num != 0)
				{
				}
				num = (short)1539571712;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Max = value;
			}
		}

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x0600BC24 RID: 48164 RVA: 0x00AE4450 File Offset: 0x00AE2650
		// (set) Token: 0x0600BC25 RID: 48165 RVA: 0x00AE4500 File Offset: 0x00AE2700
		internal int CnvSysGeneralSystemPretimems2_A9246Step
		{
			get
			{
				short num = (short)245366784;
				short num2 = num;
				num = (short)64978415;
				short num3 = num;
				num = (short)1385790959;
				switch (num3 == num)
				{
				}
				num = (short)1667694593;
				if (num != 0)
				{
				}
				num = (short)2040922112;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.StepSize;
			}
			set
			{
				short num = (short)1415315456;
				short num2 = num;
				num = (short)1022859596;
				short num3 = num;
				num = (short)2119211340;
				switch (num3 == num)
				{
				}
				num = (short)1132199936;
				if (num != 0)
				{
				}
				num = (short)1833304065;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.StepSize = value;
			}
		}

		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x00AE45B8 File Offset: 0x00AE27B8
		// (set) Token: 0x0600BC27 RID: 48167 RVA: 0x00AE4668 File Offset: 0x00AE2868
		public bool CnvSysGeneralSystemPretimems2_A9246_Applicable
		{
			get
			{
				short num = (short)2104360960;
				short num2 = num;
				num = (short)929686177;
				short num3 = num;
				num = (short)457368225;
				switch (num3 == num)
				{
				}
				num = (short)1419509761;
				if (num != 0)
				{
				}
				num = (short)830210048;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Applicable;
			}
			set
			{
				short num = (short)1224867840;
				short num2 = num;
				num = (short)866227432;
				short num3 = num;
				num = (short)983799016;
				switch (num3 == num)
				{
				}
				num = (short)1006698497;
				if (num != 0)
				{
				}
				num = (short)1339228160;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Applicable = value;
			}
		}

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x00AE4720 File Offset: 0x00AE2920
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x00AE47D4 File Offset: 0x00AE29D4
		public bool CnvSysGeneralSystemPretimems2_A9246_Valid
		{
			get
			{
				short num = (short)1170407424;
				short num2 = num;
				num = (short)82737555;
				short num3 = num;
				num = (short)1839561107;
				switch (num3 == num)
				{
				}
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)304283648;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Valid;
			}
			set
			{
				short num = (short)544145408;
				short num2 = num;
				num = (short)307732821;
				short num3 = num;
				num = (short)1027187029;
				switch (num3 == num)
				{
				}
				num = (short)1894711297;
				if (num != 0)
				{
				}
				num = (short)316145664;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Valid = value;
			}
		}

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x00AE488C File Offset: 0x00AE2A8C
		// (set) Token: 0x0600BC2B RID: 48171 RVA: 0x00AE4940 File Offset: 0x00AE2B40
		public bool CnvSysGeneralSystemPretimems2_A9246_Visible
		{
			get
			{
				short num = (short)276430848;
				short num2 = num;
				num = (short)1774868841;
				short num3 = num;
				num = (short)921131369;
				switch (num3 == num)
				{
				}
				num = (short)187236352;
				if (num != 0)
				{
				}
				num = (short)2130313217;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Visible;
			}
			set
			{
				short num = (short)1070202880;
				short num2 = num;
				num = (short)977430851;
				short num3 = num;
				num = (short)517826883;
				switch (num3 == num)
				{
				}
				num = (short)406913024;
				if (num != 0)
				{
				}
				num = (short)1844445185;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Visible = value;
			}
		}

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x00AE49F8 File Offset: 0x00AE2BF8
		// (set) Token: 0x0600BC2D RID: 48173 RVA: 0x00AE4AA8 File Offset: 0x00AE2CA8
		public bool CnvSysGeneralSystemPretimems2_A9246_Editable
		{
			get
			{
				short num = (short)692125696;
				short num2 = num;
				num = (short)1746298826;
				short num3 = num;
				num = (short)1081698250;
				switch (num3 == num)
				{
				}
				num = (short)2033713153;
				if (num != 0)
				{
				}
				num = (short)2108620800;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.Editable;
			}
			set
			{
				short num = (short)1551040512;
				short num2 = num;
				num = (short)1480006191;
				short num3 = num;
				num = (short)43260463;
				switch (num3 == num)
				{
				}
				num = (short)844234753;
				if (num != 0)
				{
				}
				num = (short)1911881728;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.Editable = value;
			}
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x0600BC2E RID: 48174 RVA: 0x00AE4B5C File Offset: 0x00AE2D5C
		internal string CnvSysGeneralSystemPretimems2_A9246_UILabel
		{
			get
			{
				short num = (short)1910964224;
				short num2 = num;
				num = (short)1186516671;
				short num3 = num;
				num = (short)1589235391;
				switch (num3 == num)
				{
				}
				num = (short)1268318209;
				if (num != 0)
				{
				}
				num = (short)1850933248;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.UIName;
			}
		}

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x00AE4C10 File Offset: 0x00AE2E10
		// (set) Token: 0x0600BC30 RID: 48176 RVA: 0x00AE4CC8 File Offset: 0x00AE2EC8
		internal bool CnvSysGeneralSystemPretimems2_A9246_HiddenStatic
		{
			get
			{
				short num = (short)1701445632;
				short num2 = num;
				num = (short)2081215350;
				short num3 = num;
				num = (short)1986450294;
				switch (num3 == num)
				{
				}
				num = (short)970719233;
				if (num != 0)
				{
				}
				num = (short)870842368;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.HiddenStatic;
			}
			set
			{
				short num = (short)780402688;
				short num2 = num;
				num = (short)1517629506;
				short num3 = num;
				num = (short)217133122;
				switch (num3 == num)
				{
				}
				num = (short)1557135361;
				if (num != 0)
				{
				}
				num = (short)891944960;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.HiddenStatic = value;
			}
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x00AE4D80 File Offset: 0x00AE2F80
		// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x00AE4E34 File Offset: 0x00AE3034
		internal bool CnvSysGeneralSystemPretimems2_A9246_HiddenDynamic
		{
			get
			{
				short num = (short)1400504320;
				short num2 = num;
				num = (short)200348012;
				short num3 = num;
				num = (short)235934060;
				switch (num3 == num)
				{
				}
				num = (short)1503657984;
				if (num != 0)
				{
				}
				num = (short)1732247553;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246.HiddenDynamic;
			}
			set
			{
				short num = (short)888602624;
				short num2 = num;
				num = (short)53227582;
				short num3 = num;
				num = (short)1121792062;
				switch (num3 == num)
				{
				}
				num = (short)221052928;
				if (num != 0)
				{
				}
				num = (short)2081554433;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemPretimems2_A9246.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x0600BC33 RID: 48179 RVA: 0x00AE4EEC File Offset: 0x00AE30EC
		public bool CnvSysGeneralSystemPretimems2_A9246_HasDiffs
		{
			get
			{
				short num = (short)134348800;
				short num2 = num;
				num = (short)578567430;
				short num3 = num;
				num = (short)1430928646;
				switch (num3 == num)
				{
				}
				num = (short)74776576;
				if (num != 0)
				{
				}
				num = (short)1464008705;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemPretimems2_A9246._HasDiffs;
			}
		}

		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x0600BC34 RID: 48180 RVA: 0x00AE4FA4 File Offset: 0x00AE31A4
		// (set) Token: 0x0600BC35 RID: 48181 RVA: 0x00AE5058 File Offset: 0x00AE3258
		public int AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Value
		{
			get
			{
				short num = (short)1624440832;
				short num2 = num;
				num = (short)512604431;
				short num3 = num;
				num = (short)793491727;
				switch (num3 == num)
				{
				}
				num = (short)212926464;
				if (num != 0)
				{
				}
				num = (short)969670657;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Value;
			}
			set
			{
				short num = (short)1556348928;
				short num2 = num;
				num = (short)1778242434;
				short num3 = num;
				num = (short)1498076034;
				switch (num3 == num)
				{
				}
				num = (short)755367937;
				if (num != 0)
				{
				}
				num = (short)195756032;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Value = value;
			}
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x00AE5110 File Offset: 0x00AE3310
		public global::AcpBusinessLayer.AcpRangeField<int, string> AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279
		{
			get
			{
				short num = (short)1090387968;
				short num2 = num;
				num = (short)1648196889;
				short num3 = num;
				num = (short)768048409;
				switch (num3 == num)
				{
				}
				num = (short)263585793;
				if (num != 0)
				{
				}
				num = (short)1008336896;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;
			}
		}

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x00AE51C0 File Offset: 0x00AE33C0
		// (set) Token: 0x0600BC38 RID: 48184 RVA: 0x00AE5270 File Offset: 0x00AE3470
		public string AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_UIValue
		{
			get
			{
				short num = (short)89391104;
				short num2 = num;
				num = (short)1888457693;
				short num3 = num;
				num = (short)115643357;
				switch (num3 == num)
				{
				}
				num = (short)1945501696;
				if (num != 0)
				{
				}
				num = (short)339083265;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.UIValue;
			}
			set
			{
				short num = (short)2064973824;
				short num2 = num;
				num = (short)138149413;
				short num3 = num;
				num = (short)1137507877;
				switch (num3 == num)
				{
				}
				num = (short)920977409;
				if (num != 0)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.UIValue = value;
			}
		}

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x0600BC39 RID: 48185 RVA: 0x00AE5328 File Offset: 0x00AE3528
		// (set) Token: 0x0600BC3A RID: 48186 RVA: 0x00AE53DC File Offset: 0x00AE35DC
		internal int AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Min
		{
			get
			{
				short num = (short)1742733312;
				short num2 = num;
				num = (short)921698305;
				if (num != 0)
				{
				}
				num = (short)90688595;
				short num3 = num;
				num = (short)1373293651;
				switch (num3 == num)
				{
				}
				num = (short)1916600320;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Min;
			}
			set
			{
				short num = (short)1944911872;
				short num2 = num;
				num = (short)1418985473;
				if (num != 0)
				{
				}
				num = (short)1862555521;
				short num3 = num;
				num = (short)1089689473;
				switch (num3 == num)
				{
				}
				num = (short)1954873344;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Min = value;
			}
		}

		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x0600BC3B RID: 48187 RVA: 0x00AE5490 File Offset: 0x00AE3690
		// (set) Token: 0x0600BC3C RID: 48188 RVA: 0x00AE5548 File Offset: 0x00AE3748
		internal int AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Max
		{
			get
			{
				short num = (short)495910912;
				short num2 = num;
				num = (short)785971461;
				short num3 = num;
				num = (short)1312094469;
				switch (num3 == num)
				{
				}
				num = (short)484507649;
				if (num != 0)
				{
				}
				num = (short)110755840;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Max;
			}
			set
			{
				short num = (short)1007288320;
				short num2 = num;
				num = (short)1517971449;
				short num3 = num;
				num = (short)1608017913;
				switch (num3 == num)
				{
				}
				num = (short)256114689;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Max = value;
			}
		}

		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x00AE5600 File Offset: 0x00AE3800
		// (set) Token: 0x0600BC3E RID: 48190 RVA: 0x00AE56B8 File Offset: 0x00AE38B8
		internal int AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Step
		{
			get
			{
				short num = (short)2028929024;
				short num2 = num;
				num = (short)276085278;
				short num3 = num;
				num = (short)1191426590;
				switch (num3 == num)
				{
				}
				num = (short)185401345;
				if (num != 0)
				{
				}
				num = (short)1321402368;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.StepSize;
			}
			set
			{
				short num = (short)223215616;
				short num2 = num;
				num = (short)1950875649;
				if (num != 0)
				{
				}
				num = (short)50466427;
				short num3 = num;
				num = (short)1887571579;
				switch (num3 == num)
				{
				}
				num = (short)1282605056;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.StepSize = value;
			}
		}

		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x0600BC3F RID: 48191 RVA: 0x00AE5770 File Offset: 0x00AE3970
		// (set) Token: 0x0600BC40 RID: 48192 RVA: 0x00AE5828 File Offset: 0x00AE3A28
		public bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_Applicable
		{
			get
			{
				short num = (short)1661861888;
				short num2 = num;
				num = (short)234157077;
				short num3 = num;
				num = (short)694744085;
				switch (num3 == num)
				{
				}
				num = (short)185270273;
				if (num != 0)
				{
				}
				num = (short)870645760;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Applicable;
			}
			set
			{
				short num = (short)901884464;
				short num2 = num;
				num = (short)469936688;
				switch (num2 == num)
				{
				}
				num = (short)521666561;
				if (num != 0)
				{
				}
				num = (short)1393295360;
				if (num != 0)
				{
				}
				num = (short)451805184;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Applicable = value;
			}
		}

		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x0600BC41 RID: 48193 RVA: 0x00AE58E0 File Offset: 0x00AE3AE0
		// (set) Token: 0x0600BC42 RID: 48194 RVA: 0x00AE5994 File Offset: 0x00AE3B94
		public bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_Valid
		{
			get
			{
				short num = (short)963045047;
				short num2 = num;
				num = (short)1872291511;
				switch (num2 == num)
				{
				}
				num = (short)1545469953;
				if (num != 0)
				{
				}
				num = (short)1122238464;
				if (num != 0)
				{
				}
				num = (short)680001536;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Valid;
			}
			set
			{
				short num = (short)816447489;
				if (num != 0)
				{
				}
				num = (short)577240195;
				short num2 = num;
				num = (short)10222723;
				switch (num2 == num)
				{
				}
				num = (short)1938817024;
				if (num != 0)
				{
				}
				num = (short)30736384;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Valid = value;
			}
		}

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x0600BC43 RID: 48195 RVA: 0x00AE5A48 File Offset: 0x00AE3C48
		// (set) Token: 0x0600BC44 RID: 48196 RVA: 0x00AE5AFC File Offset: 0x00AE3CFC
		public bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_Visible
		{
			get
			{
				short num = (short)662497100;
				short num2 = num;
				num = (short)1295050572;
				switch (num2 == num)
				{
				}
				num = (short)1810300929;
				if (num != 0)
				{
				}
				num = (short)476446720;
				if (num != 0)
				{
				}
				num = (short)44892160;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Visible;
			}
			set
			{
				short num = (short)1554710529;
				if (num != 0)
				{
				}
				num = (short)1343064646;
				short num2 = num;
				num = (short)1998883398;
				switch (num2 == num)
				{
				}
				num = (short)799080448;
				if (num != 0)
				{
				}
				num = (short)44630016;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Visible = value;
			}
		}

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x0600BC45 RID: 48197 RVA: 0x00AE5BB4 File Offset: 0x00AE3DB4
		// (set) Token: 0x0600BC46 RID: 48198 RVA: 0x00AE5C6C File Offset: 0x00AE3E6C
		public bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_Editable
		{
			get
			{
				short num = (short)142631915;
				short num2 = num;
				num = (short)659317739;
				switch (num2 == num)
				{
				}
				num = (short)1945108481;
				if (num != 0)
				{
				}
				num = (short)2140143616;
				if (num != 0)
				{
				}
				num = (short)1664942080;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Editable;
			}
			set
			{
				short num = (short)747030594;
				short num2 = num;
				num = (short)1501087810;
				switch (num2 == num)
				{
				}
				num = (short)200146945;
				if (num != 0)
				{
				}
				num = (short)1595473920;
				if (num != 0)
				{
				}
				num = (short)312934400;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.Editable = value;
			}
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x0600BC47 RID: 48199 RVA: 0x00AE5D20 File Offset: 0x00AE3F20
		internal string AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_UILabel
		{
			get
			{
				short num = (short)2048786279;
				short num2 = num;
				num = (short)1415053159;
				switch (num2 == num)
				{
				}
				num = (short)1512964097;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				if (num != 0)
				{
				}
				num = (short)1893859328;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.UIName;
			}
		}

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x00AE5DD8 File Offset: 0x00AE3FD8
		// (set) Token: 0x0600BC49 RID: 48201 RVA: 0x00AE5E8C File Offset: 0x00AE408C
		internal bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_HiddenStatic
		{
			get
			{
				short num = (short)1484660522;
				short num2 = num;
				num = (short)269688618;
				switch (num2 == num)
				{
				}
				num = (short)1155792896;
				if (num != 0)
				{
				}
				num = (short)848101377;
				if (num != 0)
				{
				}
				num = (short)371064832;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.HiddenStatic;
			}
			set
			{
				short num = (short)1667825665;
				if (num != 0)
				{
				}
				num = (short)558326866;
				short num2 = num;
				num = (short)531457106;
				switch (num2 == num)
				{
				}
				num = (short)1210515456;
				if (num != 0)
				{
				}
				num = (short)318046208;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.HiddenStatic = value;
			}
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x00AE5F44 File Offset: 0x00AE4144
		// (set) Token: 0x0600BC4B RID: 48203 RVA: 0x00AE5FF8 File Offset: 0x00AE41F8
		internal bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_HiddenDynamic
		{
			get
			{
				short num = (short)9835700;
				short num2 = num;
				num = (short)1807488180;
				switch (num2 == num)
				{
				}
				num = (short)1595211777;
				if (num != 0)
				{
				}
				num = (short)21692416;
				if (num != 0)
				{
				}
				num = (short)1900347392;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.HiddenDynamic;
			}
			set
			{
				short num = (short)2014248961;
				if (num != 0)
				{
				}
				num = (short)1458289138;
				short num2 = num;
				num = (short)1521203698;
				switch (num2 == num)
				{
				}
				num = (short)642646016;
				if (num != 0)
				{
				}
				num = (short)57868288;
				short num3 = num;
				this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x00AE60B0 File Offset: 0x00AE42B0
		public bool AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279_HasDiffs
		{
			get
			{
				short num = (short)1827536897;
				if (num != 0)
				{
				}
				num = (short)799444504;
				short num2 = num;
				num = (short)1556909592;
				switch (num2 == num)
				{
				}
				num = (short)1459945472;
				if (num != 0)
				{
				}
				num = (short)984285184;
				short num3 = num;
				return this.astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279._HasDiffs;
			}
		}

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x0600BC4D RID: 48205 RVA: 0x00AE6164 File Offset: 0x00AE4364
		// (set) Token: 0x0600BC4E RID: 48206 RVA: 0x00AE6218 File Offset: 0x00AE4418
		public int CnvSysGeneralVariableID_A9612Value
		{
			get
			{
				short num = (short)2141852588;
				short num2 = num;
				num = (short)1700926380;
				switch (num2 == num)
				{
				}
				num = (short)1671430144;
				if (num != 0)
				{
				}
				num = (short)716177409;
				if (num != 0)
				{
				}
				num = (short)1549795328;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Value;
			}
			set
			{
				short num = (short)1769469764;
				short num2 = num;
				num = (short)1147008836;
				switch (num2 == num)
				{
				}
				num = (short)750059521;
				if (num != 0)
				{
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				num = (short)1838153728;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Value = value;
			}
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x0600BC4F RID: 48207 RVA: 0x00AE62CC File Offset: 0x00AE44CC
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvSysGeneralVariableID_A9612
		{
			get
			{
				short num = (short)2116513629;
				short num2 = num;
				num = (short)984051549;
				switch (num2 == num)
				{
				}
				num = (short)1098514432;
				if (num != 0)
				{
				}
				num = (short)2099118081;
				if (num != 0)
				{
				}
				num = (short)1032847360;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612;
			}
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x00AE637C File Offset: 0x00AE457C
		// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x00AE6430 File Offset: 0x00AE4630
		public string CnvSysGeneralVariableID_A9612_UIValue
		{
			get
			{
				short num = (short)1853504258;
				short num2 = num;
				num = (short)899758850;
				switch (num2 == num)
				{
				}
				num = (short)1840971777;
				if (num != 0)
				{
				}
				num = (short)143196160;
				if (num != 0)
				{
				}
				num = (short)1710489600;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.UIValue;
			}
			set
			{
				short num = (short)1723204819;
				short num2 = num;
				num = (short)807470291;
				switch (num2 == num)
				{
				}
				num = (short)1583742976;
				if (num != 0)
				{
				}
				num = (short)457113601;
				if (num != 0)
				{
				}
				num = (short)957480960;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.UIValue = value;
			}
		}

		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x00AE64E4 File Offset: 0x00AE46E4
		// (set) Token: 0x0600BC53 RID: 48211 RVA: 0x00AE6598 File Offset: 0x00AE4798
		internal int CnvSysGeneralVariableID_A9612Min
		{
			get
			{
				short num = (short)1167322999;
				short num2 = num;
				num = (short)2092822391;
				switch (num2 == num)
				{
				}
				num = (short)1700331521;
				if (num != 0)
				{
				}
				num = (short)435748864;
				if (num != 0)
				{
				}
				num = (short)1668153344;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Min;
			}
			set
			{
				short num = (short)313929815;
				short num2 = num;
				num = (short)389689431;
				switch (num2 == num)
				{
				}
				num = (short)97124352;
				if (num != 0)
				{
				}
				num = (short)904069121;
				if (num != 0)
				{
				}
				num = (short)1824587776;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Min = value;
			}
		}

		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x00AE664C File Offset: 0x00AE484C
		// (set) Token: 0x0600BC55 RID: 48213 RVA: 0x00AE6700 File Offset: 0x00AE4900
		internal int CnvSysGeneralVariableID_A9612Max
		{
			get
			{
				short num = (short)14999179;
				short num2 = num;
				num = (short)1305730699;
				switch (num2 == num)
				{
				}
				num = (short)2002124800;
				if (num != 0)
				{
				}
				num = (short)553189377;
				if (num != 0)
				{
				}
				num = (short)543162368;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Max;
			}
			set
			{
				short num = (short)1265172481;
				if (num != 0)
				{
				}
				num = (short)1416657152;
				short num2 = num;
				num = (short)1952413952;
				switch (num2 == num)
				{
				}
				num = (short)759955456;
				if (num != 0)
				{
				}
				num = (short)1602158592;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Max = value;
			}
		}

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x00AE67B4 File Offset: 0x00AE49B4
		// (set) Token: 0x0600BC57 RID: 48215 RVA: 0x00AE6868 File Offset: 0x00AE4A68
		internal int CnvSysGeneralVariableID_A9612Step
		{
			get
			{
				short num = (short)204049933;
				short num2 = num;
				num = (short)373132813;
				switch (num2 == num)
				{
				}
				num = (short)712048640;
				if (num != 0)
				{
				}
				num = (short)1451032577;
				if (num != 0)
				{
				}
				num = (short)414384128;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.StepSize;
			}
			set
			{
				short num = (short)1726756251;
				short num2 = num;
				num = (short)1268790683;
				switch (num2 == num)
				{
				}
				num = (short)141950977;
				if (num != 0)
				{
				}
				num = (short)1703411712;
				if (num != 0)
				{
				}
				num = (short)1278083072;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.StepSize = value;
			}
		}

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x00AE6920 File Offset: 0x00AE4B20
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x00AE69D8 File Offset: 0x00AE4BD8
		public bool CnvSysGeneralVariableID_A9612_Applicable
		{
			get
			{
				short num = (short)719807095;
				short num2 = num;
				num = (short)70214263;
				switch (num2 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)434896896;
				if (num != 0)
				{
				}
				num = (short)1429012480;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Applicable;
			}
			set
			{
				short num = (short)1498311634;
				short num2 = num;
				num = (short)1438608338;
				switch (num2 == num)
				{
				}
				num = (short)1951858688;
				if (num != 0)
				{
				}
				num = (short)878182401;
				if (num != 0)
				{
				}
				num = (short)220987392;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Applicable = value;
			}
		}

		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x00AE6A90 File Offset: 0x00AE4C90
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x00AE6B40 File Offset: 0x00AE4D40
		public bool CnvSysGeneralVariableID_A9612_Valid
		{
			get
			{
				short num = (short)941285912;
				short num2 = num;
				num = (short)412475928;
				switch (num2 == num)
				{
				}
				num = (short)1623982080;
				if (num != 0)
				{
				}
				num = (short)1626669057;
				if (num != 0)
				{
				}
				num = (short)1316159488;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Valid;
			}
			set
			{
				short num = (short)1001586689;
				if (num != 0)
				{
				}
				num = (short)361345435;
				short num2 = num;
				num = (short)130396571;
				switch (num2 == num)
				{
				}
				num = (short)818282496;
				if (num != 0)
				{
				}
				num = (short)505282560;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Valid = value;
			}
		}

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x0600BC5C RID: 48220 RVA: 0x00AE6BF4 File Offset: 0x00AE4DF4
		// (set) Token: 0x0600BC5D RID: 48221 RVA: 0x00AE6CA8 File Offset: 0x00AE4EA8
		public bool CnvSysGeneralVariableID_A9612_Visible
		{
			get
			{
				short num = (short)1016021450;
				short num2 = num;
				num = (short)140919242;
				switch (num2 == num)
				{
				}
				num = (short)73007104;
				if (num != 0)
				{
				}
				num = (short)135987201;
				if (num != 0)
				{
				}
				num = (short)1880948736;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Visible;
			}
			set
			{
				short num = (short)1194917889;
				if (num != 0)
				{
				}
				num = (short)2076436892;
				short num2 = num;
				num = (short)1850927516;
				switch (num2 == num)
				{
				}
				num = (short)1733623808;
				if (num != 0)
				{
				}
				num = (short)1879834624;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Visible = value;
			}
		}

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x0600BC5E RID: 48222 RVA: 0x00AE6D58 File Offset: 0x00AE4F58
		// (set) Token: 0x0600BC5F RID: 48223 RVA: 0x00AE6E0C File Offset: 0x00AE500C
		public bool CnvSysGeneralVariableID_A9612_Editable
		{
			get
			{
				short num = (short)2070031599;
				short num2 = num;
				num = (short)573451503;
				switch (num2 == num)
				{
				}
				num = (short)1848639489;
				if (num != 0)
				{
				}
				num = (short)123928576;
				if (num != 0)
				{
				}
				num = (short)443482112;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.Editable;
			}
			set
			{
				short num = (short)1506000757;
				short num2 = num;
				num = (short)182828917;
				switch (num2 == num)
				{
				}
				num = (short)785186817;
				if (num != 0)
				{
				}
				num = (short)627245056;
				if (num != 0)
				{
				}
				num = (short)380174336;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.Editable = value;
			}
		}

		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x0600BC60 RID: 48224 RVA: 0x00AE6EC4 File Offset: 0x00AE50C4
		internal string CnvSysGeneralVariableID_A9612_UILabel
		{
			get
			{
				short num = (short)891420673;
				if (num != 0)
				{
				}
				num = (short)1323012826;
				short num2 = num;
				num = (short)545100506;
				switch (num2 == num)
				{
				}
				num = (short)1972043776;
				if (num != 0)
				{
				}
				num = (short)1450967040;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.UIName;
			}
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x0600BC61 RID: 48225 RVA: 0x00AE6F78 File Offset: 0x00AE5178
		// (set) Token: 0x0600BC62 RID: 48226 RVA: 0x00AE702C File Offset: 0x00AE522C
		internal bool CnvSysGeneralVariableID_A9612_HiddenStatic
		{
			get
			{
				short num = (short)867001684;
				short num2 = num;
				num = (short)831350100;
				switch (num2 == num)
				{
				}
				num = (short)50266113;
				if (num != 0)
				{
				}
				num = (short)1065287680;
				if (num != 0)
				{
				}
				num = (short)1287520256;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.HiddenStatic;
			}
			set
			{
				short num = (short)310165266;
				short num2 = num;
				num = (short)837467922;
				switch (num2 == num)
				{
				}
				num = (short)409337857;
				if (num != 0)
				{
				}
				num = (short)230686720;
				if (num != 0)
				{
				}
				num = (short)1768095744;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.HiddenStatic = value;
			}
		}

		// Token: 0x17005E7A RID: 24186
		// (get) Token: 0x0600BC63 RID: 48227 RVA: 0x00AE70E4 File Offset: 0x00AE52E4
		// (set) Token: 0x0600BC64 RID: 48228 RVA: 0x00AE7198 File Offset: 0x00AE5398
		internal bool CnvSysGeneralVariableID_A9612_HiddenDynamic
		{
			get
			{
				short num = (short)1548321043;
				short num2 = num;
				num = (short)151945491;
				switch (num2 == num)
				{
				}
				num = (short)573833217;
				if (num != 0)
				{
				}
				num = (short)1908473856;
				if (num != 0)
				{
				}
				num = (short)19333120;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612.HiddenDynamic;
			}
			set
			{
				short num = (short)684064769;
				if (num != 0)
				{
				}
				num = (short)707861931;
				short num2 = num;
				num = (short)1507270059;
				switch (num2 == num)
				{
				}
				num = (short)1194393600;
				if (num != 0)
				{
				}
				num = (short)245497856;
				short num3 = num;
				this.cnvSysGeneralVariableID_A9612.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E7B RID: 24187
		// (get) Token: 0x0600BC65 RID: 48229 RVA: 0x00AE724C File Offset: 0x00AE544C
		public bool CnvSysGeneralVariableID_A9612_HasDiffs
		{
			get
			{
				short num = (short)879355762;
				short num2 = num;
				num = (short)406120306;
				switch (num2 == num)
				{
				}
				num = (short)219348993;
				if (num != 0)
				{
				}
				num = (short)1659043840;
				if (num != 0)
				{
				}
				num = (short)1907097600;
				short num3 = num;
				return this.cnvSysGeneralVariableID_A9612._HasDiffs;
			}
		}

		// Token: 0x17005E7C RID: 24188
		// (get) Token: 0x0600BC66 RID: 48230 RVA: 0x00AE7300 File Offset: 0x00AE5500
		// (set) Token: 0x0600BC67 RID: 48231 RVA: 0x00AE73B0 File Offset: 0x00AE55B0
		public int CnvSysGeneralSystemType_A13262Value
		{
			get
			{
				short num = (short)148457775;
				short num2 = num;
				num = (short)54806831;
				switch (num2 == num)
				{
				}
				num = (short)982646785;
				if (num != 0)
				{
				}
				num = (short)659161088;
				if (num != 0)
				{
				}
				num = (short)1424293888;
				short num3 = num;
				return this.cnvSysGeneralSystemType_A13262.Value;
			}
			set
			{
				short num = (short)911264854;
				short num2 = num;
				num = (short)348114006;
				switch (num2 == num)
				{
				}
				num = (short)630194177;
				if (num != 0)
				{
				}
				num = (short)1811808256;
				if (num != 0)
				{
				}
				num = (short)1224081408;
				short num3 = num;
				this.cnvSysGeneralSystemType_A13262.Value = value;
			}
		}

		// Token: 0x17005E7D RID: 24189
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x00AE7464 File Offset: 0x00AE5664
		// (set) Token: 0x0600BC69 RID: 48233 RVA: 0x00AE7518 File Offset: 0x00AE5718
		public string CnvSysGeneralSystemType_A13262_UIValue
		{
			get
			{
				short num = (short)760236330;
				short num2 = num;
				num = (short)824527146;
				switch (num2 == num)
				{
				}
				num = (short)755367937;
				if (num != 0)
				{
				}
				num = (short)1376321536;
				if (num != 0)
				{
				}
				num = (short)1785462784;
				short num3 = num;
				return this.cnvSysGeneralSystemType_A13262.UIValue;
			}
			set
			{
				short num = (short)1951740118;
				short num2 = num;
				num = (short)770650326;
				switch (num2 == num)
				{
				}
				num = (short)1391132673;
				if (num != 0)
				{
				}
				num = (short)480444416;
				if (num != 0)
				{
				}
				num = (short)453836800;
				short num3 = num;
				this.cnvSysGeneralSystemType_A13262.UIValue = value;
			}
		}

		// Token: 0x17005E7E RID: 24190
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x00AE75CC File Offset: 0x00AE57CC
		public global::AcpBusinessLayer.AcpListField CnvSysGeneralSystemType_A13262
		{
			get
			{
				short num = (short)1114578395;
				short num2 = num;
				num = (short)978656731;
				switch (num2 == num)
				{
				}
				num = (short)1374814209;
				if (num != 0)
				{
				}
				num = (short)1013579776;
				if (num != 0)
				{
				}
				num = (short)1886257152;
				short num3 = num;
				return this.cnvSysGeneralSystemType_A13262;
			}
		}

		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x0600BC6B RID: 48235 RVA: 0x00AE767C File Offset: 0x00AE587C
		// (set) Token: 0x0600BC6C RID: 48236 RVA: 0x00AE7734 File Offset: 0x00AE5934
		public bool CnvSysGeneralSystemType_A13262_Applicable
		{
			get
			{
				short num = (short)2107331773;
				short num2 = num;
				num = (short)640439485;
				switch (num2 == num)
				{
				}
				num = (short)795541504;
				if (num != 0)
				{
				}
				num = (short)871890945;
				if (num != 0)
				{
				}
				num = (short)1558511616;
				short num3 = num;
				return this.cnvSysGeneralSystemType_A13262.Applicable;
			}
			set
			{
				short num = (short)422624974;
				short num2 = num;
				num = (short)1826012878;
				switch (num2 == num)
				{
				}
				num = (short)1802043393;
				if (num != 0)
				{
				}
				num = (short)1756495872;
				short num3 = num;
				num = (short)1716256768;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.Applicable = value;
			}
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x0600BC6D RID: 48237 RVA: 0x00AE77EC File Offset: 0x00AE59EC
		// (set) Token: 0x0600BC6E RID: 48238 RVA: 0x00AE78A4 File Offset: 0x00AE5AA4
		public bool CnvSysGeneralSystemType_A13262_Valid
		{
			get
			{
				short num = (short)1652671271;
				short num2 = num;
				num = (short)626836263;
				switch (num2 == num)
				{
				}
				num = (short)830930945;
				if (num != 0)
				{
				}
				num = (short)2117861376;
				short num3 = num;
				num = (short)2085748736;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.Valid;
			}
			set
			{
				short num = (short)980682180;
				short num2 = num;
				num = (short)2137130436;
				switch (num2 == num)
				{
				}
				num = (short)1773338624;
				if (num != 0)
				{
				}
				num = (short)1960443904;
				short num3 = num;
				num = (short)2090467329;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.Valid = value;
			}
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x00AE7958 File Offset: 0x00AE5B58
		// (set) Token: 0x0600BC70 RID: 48240 RVA: 0x00AE7A0C File Offset: 0x00AE5C0C
		public bool CnvSysGeneralSystemType_A13262_Visible
		{
			get
			{
				short num = (short)284093048;
				short num2 = num;
				num = (short)364505720;
				switch (num2 == num)
				{
				}
				num = (short)1001062400;
				if (num != 0)
				{
				}
				num = (short)2134441984;
				short num3 = num;
				num = (short)1968439297;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.Visible;
			}
			set
			{
				short num = (short)421844239;
				short num2 = num;
				num = (short)2118112527;
				switch (num2 == num)
				{
				}
				num = (short)252772353;
				if (num != 0)
				{
				}
				num = (short)1211105280;
				short num3 = num;
				num = (short)1557528576;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.Visible = value;
			}
		}

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x00AE7AC0 File Offset: 0x00AE5CC0
		// (set) Token: 0x0600BC72 RID: 48242 RVA: 0x00AE7B74 File Offset: 0x00AE5D74
		public bool CnvSysGeneralSystemType_A13262_Editable
		{
			get
			{
				short num = (short)187039745;
				if (num != 0)
				{
				}
				num = (short)1559947300;
				short num2 = num;
				num = (short)1068230692;
				switch (num2 == num)
				{
				}
				num = (short)1791426560;
				short num3 = num;
				num = (short)500498432;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.Editable;
			}
			set
			{
				short num = (short)258391554;
				short num2 = num;
				num = (short)1529069058;
				switch (num2 == num)
				{
				}
				num = (short)157941760;
				if (num != 0)
				{
				}
				num = (short)1025638400;
				short num3 = num;
				num = (short)682622977;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.Editable = value;
			}
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x0600BC73 RID: 48243 RVA: 0x00AE7C2C File Offset: 0x00AE5E2C
		internal string CnvSysGeneralSystemType_A13262_UILabel
		{
			get
			{
				short num = (short)1151296293;
				short num2 = num;
				num = (short)1650877221;
				switch (num2 == num)
				{
				}
				num = (short)1389625345;
				if (num != 0)
				{
				}
				num = (short)1112604672;
				short num3 = num;
				num = (short)1244856320;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.UIName;
			}
		}

		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x0600BC74 RID: 48244 RVA: 0x00AE7CE4 File Offset: 0x00AE5EE4
		// (set) Token: 0x0600BC75 RID: 48245 RVA: 0x00AE7D9C File Offset: 0x00AE5F9C
		internal bool CnvSysGeneralSystemType_A13262_HiddenStatic
		{
			get
			{
				short num = (short)2051787430;
				short num2 = num;
				num = (short)794151590;
				switch (num2 == num)
				{
				}
				num = (short)1927217153;
				if (num != 0)
				{
				}
				num = (short)1350959104;
				short num3 = num;
				num = (short)1958346752;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.HiddenStatic;
			}
			set
			{
				short num = (short)246079012;
				short num2 = num;
				num = (short)1392696868;
				switch (num2 == num)
				{
				}
				num = (short)846331905;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				short num3 = num;
				num = (short)598999040;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.HiddenStatic = value;
			}
		}

		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x0600BC76 RID: 48246 RVA: 0x00AE7E50 File Offset: 0x00AE6050
		// (set) Token: 0x0600BC77 RID: 48247 RVA: 0x00AE7F04 File Offset: 0x00AE6104
		internal bool CnvSysGeneralSystemType_A13262_HiddenDynamic
		{
			get
			{
				short num = (short)281089417;
				short num2 = num;
				num = (short)1633686921;
				switch (num2 == num)
				{
				}
				num = (short)1236402177;
				if (num != 0)
				{
				}
				num = (short)1448869888;
				short num3 = num;
				num = (short)2002976768;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262.HiddenDynamic;
			}
			set
			{
				short num = (short)472527152;
				short num2 = num;
				num = (short)2018521392;
				switch (num2 == num)
				{
				}
				num = (short)1410007041;
				if (num != 0)
				{
				}
				num = (short)154009600;
				short num3 = num;
				num = (short)18612224;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemType_A13262.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x0600BC78 RID: 48248 RVA: 0x00AE7FB8 File Offset: 0x00AE61B8
		public bool CnvSysGeneralSystemType_A13262_HasDiffs
		{
			get
			{
				short num = (short)65951914;
				short num2 = num;
				num = (short)970479786;
				switch (num2 == num)
				{
				}
				num = (short)1261502465;
				if (num != 0)
				{
				}
				num = (short)1663631360;
				short num3 = num;
				num = (short)517603328;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemType_A13262._HasDiffs;
			}
		}

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x00AE806C File Offset: 0x00AE626C
		// (set) Token: 0x0600BC7A RID: 48250 RVA: 0x00AE8120 File Offset: 0x00AE6320
		public int CnvSysGeneralDataProfileSelection_A13266Value
		{
			get
			{
				short num = (short)282773224;
				short num2 = num;
				num = (short)1283639016;
				switch (num2 == num)
				{
				}
				num = (short)128385024;
				if (num != 0)
				{
				}
				num = (short)561446912;
				short num3 = num;
				num = (short)442171393;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.Value;
			}
			set
			{
				short num = (short)1502315733;
				short num2 = num;
				num = (short)740590805;
				switch (num2 == num)
				{
				}
				num = (short)1015742464;
				if (num != 0)
				{
				}
				num = (short)1456799744;
				short num3 = num;
				num = (short)1022754817;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.Value = value;
			}
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0600BC7B RID: 48251 RVA: 0x00AE81D8 File Offset: 0x00AE63D8
		// (set) Token: 0x0600BC7C RID: 48252 RVA: 0x00AE828C File Offset: 0x00AE648C
		public string CnvSysGeneralDataProfileSelection_A13266_UIValue
		{
			get
			{
				short num = (short)343285363;
				short num2 = num;
				num = (short)836050547;
				switch (num2 == num)
				{
				}
				num = (short)942080001;
				if (num != 0)
				{
				}
				num = (short)2040201216;
				short num3 = num;
				num = (short)1240662016;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.UIValue;
			}
			set
			{
				short num = (short)1821934035;
				short num2 = num;
				num = (short)152142291;
				switch (num2 == num)
				{
				}
				num = (short)1799225345;
				if (num != 0)
				{
				}
				num = (short)41091072;
				short num3 = num;
				num = (short)8323072;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.UIValue = value;
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0600BC7D RID: 48253 RVA: 0x00AE8340 File Offset: 0x00AE6540
		public global::AcpBusinessLayer.AcpRecRefField CnvSysGeneralDataProfileSelection_A13266
		{
			get
			{
				short num = (short)648615590;
				short num2 = num;
				num = (short)202839718;
				switch (num2 == num)
				{
				}
				num = (short)635174913;
				if (num != 0)
				{
				}
				num = (short)740163584;
				short num3 = num;
				num = (short)763887616;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266;
			}
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0600BC7E RID: 48254 RVA: 0x00AE83F0 File Offset: 0x00AE65F0
		// (set) Token: 0x0600BC7F RID: 48255 RVA: 0x00AE84A4 File Offset: 0x00AE66A4
		public bool CnvSysGeneralDataProfileSelection_A13266_Applicable
		{
			get
			{
				short num = (short)1770044828;
				short num2 = num;
				num = (short)2073804188;
				switch (num2 == num)
				{
				}
				num = (short)2012741633;
				if (num != 0)
				{
				}
				num = (short)215941120;
				short num3 = num;
				num = (short)1887174656;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.Applicable;
			}
			set
			{
				short num = (short)1494300046;
				short num2 = num;
				num = (short)287323534;
				switch (num2 == num)
				{
				}
				num = (short)1271595009;
				if (num != 0)
				{
				}
				num = (short)222560256;
				short num3 = num;
				num = (short)1801781248;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.Applicable = value;
			}
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x00AE855C File Offset: 0x00AE675C
		// (set) Token: 0x0600BC81 RID: 48257 RVA: 0x00AE860C File Offset: 0x00AE680C
		public bool CnvSysGeneralDataProfileSelection_A13266_Valid
		{
			get
			{
				short num = (short)840841058;
				short num2 = num;
				num = (short)555759458;
				switch (num2 == num)
				{
				}
				num = (short)602996736;
				if (num != 0)
				{
				}
				num = (short)1972764672;
				short num3 = num;
				num = (short)1887436801;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.Valid;
			}
			set
			{
				short num = (short)887969086;
				short num2 = num;
				num = (short)72832318;
				switch (num2 == num)
				{
				}
				num = (short)613482496;
				if (num != 0)
				{
				}
				num = (short)1693581312;
				short num3 = num;
				num = (short)1850081281;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.Valid = value;
			}
		}

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x00AE86C4 File Offset: 0x00AE68C4
		// (set) Token: 0x0600BC83 RID: 48259 RVA: 0x00AE8778 File Offset: 0x00AE6978
		public bool CnvSysGeneralDataProfileSelection_A13266_Visible
		{
			get
			{
				short num = (short)1225139991;
				short num2 = num;
				num = (short)1179658007;
				switch (num2 == num)
				{
				}
				num = (short)21299200;
				if (num != 0)
				{
				}
				num = (short)1338966016;
				short num3 = num;
				num = (short)75300865;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.Visible;
			}
			set
			{
				short num = (short)95627460;
				short num2 = num;
				num = (short)1128081604;
				switch (num2 == num)
				{
				}
				num = (short)1821704193;
				if (num != 0)
				{
				}
				num = (short)283246592;
				short num3 = num;
				num = (short)1021640704;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.Visible = value;
			}
		}

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x00AE8830 File Offset: 0x00AE6A30
		// (set) Token: 0x0600BC85 RID: 48261 RVA: 0x00AE88E8 File Offset: 0x00AE6AE8
		public bool CnvSysGeneralDataProfileSelection_A13266_Editable
		{
			get
			{
				short num = (short)39146649;
				short num2 = num;
				num = (short)1364874393;
				switch (num2 == num)
				{
				}
				num = (short)1416691713;
				if (num != 0)
				{
				}
				num = (short)1503199232;
				short num3 = num;
				num = (short)618070016;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.Editable;
			}
			set
			{
				short num = (short)73430576;
				short num2 = num;
				num = (short)276985392;
				switch (num2 == num)
				{
				}
				num = (short)2120024065;
				if (num != 0)
				{
				}
				num = (short)1847394304;
				short num3 = num;
				num = (short)1350041600;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.Editable = value;
			}
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x00AE899C File Offset: 0x00AE6B9C
		internal string CnvSysGeneralDataProfileSelection_A13266_UILabel
		{
			get
			{
				short num = (short)305353137;
				short num2 = num;
				num = (short)71193009;
				switch (num2 == num)
				{
				}
				num = (short)437649408;
				if (num != 0)
				{
				}
				num = (short)2010775552;
				short num3 = num;
				num = (short)1063714817;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.UIName;
			}
		}

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x0600BC87 RID: 48263 RVA: 0x00AE8A50 File Offset: 0x00AE6C50
		// (set) Token: 0x0600BC88 RID: 48264 RVA: 0x00AE8B04 File Offset: 0x00AE6D04
		internal bool CnvSysGeneralDataProfileSelection_A13266_HiddenStatic
		{
			get
			{
				short num = (short)1387615120;
				short num2 = num;
				num = (short)1784304528;
				switch (num2 == num)
				{
				}
				num = (short)1976500225;
				if (num != 0)
				{
				}
				num = (short)173604864;
				short num3 = num;
				num = (short)1631387648;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.HiddenStatic;
			}
			set
			{
				short num = (short)902740900;
				short num2 = num;
				num = (short)822590372;
				switch (num2 == num)
				{
				}
				num = (short)2015756289;
				if (num != 0)
				{
				}
				num = (short)424869888;
				short num3 = num;
				num = (short)1395785728;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.HiddenStatic = value;
			}
		}

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x0600BC89 RID: 48265 RVA: 0x00AE8BB8 File Offset: 0x00AE6DB8
		// (set) Token: 0x0600BC8A RID: 48266 RVA: 0x00AE8C6C File Offset: 0x00AE6E6C
		internal bool CnvSysGeneralDataProfileSelection_A13266_HiddenDynamic
		{
			get
			{
				short num = (short)589430785;
				if (num != 0)
				{
				}
				num = (short)1370759968;
				short num2 = num;
				num = (short)1645355808;
				switch (num2 == num)
				{
				}
				num = (short)1738145792;
				short num3 = num;
				num = (short)1142882304;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266.HiddenDynamic;
			}
			set
			{
				short num = (short)1880090412;
				short num2 = num;
				num = (short)573237036;
				switch (num2 == num)
				{
				}
				num = (short)1163984897;
				if (num != 0)
				{
				}
				num = (short)574029824;
				short num3 = num;
				num = (short)1489502208;
				if (num != 0)
				{
				}
				this.cnvSysGeneralDataProfileSelection_A13266.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x0600BC8B RID: 48267 RVA: 0x00AE8D24 File Offset: 0x00AE6F24
		public bool CnvSysGeneralDataProfileSelection_A13266_HasDiffs
		{
			get
			{
				short num = (short)915516853;
				short num2 = num;
				num = (short)1184411061;
				switch (num2 == num)
				{
				}
				num = (short)43122689;
				if (num != 0)
				{
				}
				num = (short)512229376;
				short num3 = num;
				num = (short)1323040768;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralDataProfileSelection_A13266._HasDiffs;
			}
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x0600BC8C RID: 48268 RVA: 0x00AE8DD8 File Offset: 0x00AE6FD8
		// (set) Token: 0x0600BC8D RID: 48269 RVA: 0x00AE8E88 File Offset: 0x00AE7088
		public int CnvSysGeneralEmergencyProfileSelection_A19421Value
		{
			get
			{
				short num = (short)161831717;
				short num2 = num;
				num = (short)631069477;
				switch (num2 == num)
				{
				}
				num = (short)74055680;
				if (num != 0)
				{
				}
				num = (short)1402011648;
				short num3 = num;
				num = (short)1487667201;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.Value;
			}
			set
			{
				short num = (short)1407778817;
				if (num != 0)
				{
				}
				num = (short)1977170255;
				short num2 = num;
				num = (short)1501772111;
				switch (num2 == num)
				{
				}
				num = (short)1819017216;
				short num3 = num;
				num = (short)109379584;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.Value = value;
			}
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x00AE8F3C File Offset: 0x00AE713C
		// (set) Token: 0x0600BC8F RID: 48271 RVA: 0x00AE8FF0 File Offset: 0x00AE71F0
		public string CnvSysGeneralEmergencyProfileSelection_A19421_UIValue
		{
			get
			{
				short num = (short)1783133901;
				short num2 = num;
				num = (short)1218737869;
				switch (num2 == num)
				{
				}
				num = (short)1359544320;
				if (num != 0)
				{
				}
				num = (short)977797120;
				short num3 = num;
				num = (short)1927479297;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.UIValue;
			}
			set
			{
				short num = (short)627023695;
				short num2 = num;
				num = (short)1193582415;
				switch (num2 == num)
				{
				}
				num = (short)1323565056;
				if (num != 0)
				{
				}
				num = (short)1075118080;
				short num3 = num;
				num = (short)956301313;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.UIValue = value;
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x0600BC90 RID: 48272 RVA: 0x00AE90A4 File Offset: 0x00AE72A4
		public global::AcpBusinessLayer.AcpRecRefField CnvSysGeneralEmergencyProfileSelection_A19421
		{
			get
			{
				short num = (short)787375630;
				short num2 = num;
				num = (short)1323001358;
				switch (num2 == num)
				{
				}
				num = (short)872939520;
				if (num != 0)
				{
				}
				num = (short)986972160;
				short num3 = num;
				num = (short)443416577;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421;
			}
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x0600BC91 RID: 48273 RVA: 0x00AE9154 File Offset: 0x00AE7354
		// (set) Token: 0x0600BC92 RID: 48274 RVA: 0x00AE9208 File Offset: 0x00AE7408
		public bool CnvSysGeneralEmergencyProfileSelection_A19421_Applicable
		{
			get
			{
				short num = (short)1012006913;
				if (num != 0)
				{
				}
				num = (short)2122839967;
				short num2 = num;
				num = (short)1123612575;
				switch (num2 == num)
				{
				}
				num = (short)1850277888;
				short num3 = num;
				num = (short)680329216;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.Applicable;
			}
			set
			{
				short num = (short)79617164;
				short num2 = num;
				num = (short)1712184460;
				switch (num2 == num)
				{
				}
				num = (short)1023213569;
				if (num != 0)
				{
				}
				num = (short)931201024;
				short num3 = num;
				num = (short)194248704;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.Applicable = value;
			}
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x0600BC93 RID: 48275 RVA: 0x00AE92BC File Offset: 0x00AE74BC
		// (set) Token: 0x0600BC94 RID: 48276 RVA: 0x00AE9370 File Offset: 0x00AE7570
		public bool CnvSysGeneralEmergencyProfileSelection_A19421_Valid
		{
			get
			{
				short num = (short)224024998;
				short num2 = num;
				num = (short)1488738726;
				switch (num2 == num)
				{
				}
				num = (short)1656750080;
				if (num != 0)
				{
				}
				num = (short)154402816;
				short num3 = num;
				num = (short)1904541697;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.Valid;
			}
			set
			{
				short num = (short)2053319577;
				short num2 = num;
				num = (short)355412889;
				switch (num2 == num)
				{
				}
				num = (short)109576193;
				if (num != 0)
				{
				}
				num = (short)1786576896;
				short num3 = num;
				num = (short)1604780032;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.Valid = value;
			}
		}

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x00AE9428 File Offset: 0x00AE7628
		// (set) Token: 0x0600BC96 RID: 48278 RVA: 0x00AE94DC File Offset: 0x00AE76DC
		public bool CnvSysGeneralEmergencyProfileSelection_A19421_Visible
		{
			get
			{
				short num = (short)891013577;
				short num2 = num;
				num = (short)486001097;
				switch (num2 == num)
				{
				}
				num = (short)1829568512;
				if (num != 0)
				{
				}
				num = (short)1185742848;
				short num3 = num;
				num = (short)280100865;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.Visible;
			}
			set
			{
				short num = (short)516224207;
				short num2 = num;
				num = (short)674231503;
				switch (num2 == num)
				{
				}
				num = (short)1847787521;
				if (num != 0)
				{
				}
				num = (short)1129644032;
				short num3 = num;
				num = (short)1024589824;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.Visible = value;
			}
		}

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x0600BC97 RID: 48279 RVA: 0x00AE9590 File Offset: 0x00AE7790
		// (set) Token: 0x0600BC98 RID: 48280 RVA: 0x00AE9644 File Offset: 0x00AE7844
		public bool CnvSysGeneralEmergencyProfileSelection_A19421_Editable
		{
			get
			{
				short num = (short)199734454;
				short num2 = num;
				num = (short)1544860854;
				switch (num2 == num)
				{
				}
				num = (short)952238080;
				if (num != 0)
				{
				}
				num = (short)914751488;
				short num3 = num;
				num = (short)733085697;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.Editable;
			}
			set
			{
				short num = (short)283115521;
				if (num != 0)
				{
				}
				num = (short)1213878218;
				short num2 = num;
				num = (short)94130122;
				switch (num2 == num)
				{
				}
				num = (short)1823735808;
				short num3 = num;
				num = (short)1397555200;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.Editable = value;
			}
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x00AE96FC File Offset: 0x00AE78FC
		internal string CnvSysGeneralEmergencyProfileSelection_A19421_UILabel
		{
			get
			{
				short num = (short)801869282;
				short num2 = num;
				num = (short)1638960610;
				switch (num2 == num)
				{
				}
				num = (short)1773797377;
				if (num != 0)
				{
				}
				num = (short)1333919744;
				short num3 = num;
				num = (short)1739915264;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.UIName;
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x0600BC9A RID: 48282 RVA: 0x00AE97B0 File Offset: 0x00AE79B0
		// (set) Token: 0x0600BC9B RID: 48283 RVA: 0x00AE9864 File Offset: 0x00AE7A64
		internal bool CnvSysGeneralEmergencyProfileSelection_A19421_HiddenStatic
		{
			get
			{
				short num = (short)269166697;
				short num2 = num;
				num = (short)1681795177;
				switch (num2 == num)
				{
				}
				num = (short)628424704;
				if (num != 0)
				{
				}
				num = (short)1020657664;
				short num3 = num;
				num = (short)1505820673;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.HiddenStatic;
			}
			set
			{
				short num = (short)882333379;
				short num2 = num;
				num = (short)1886279363;
				switch (num2 == num)
				{
				}
				num = (short)1511522305;
				if (num != 0)
				{
				}
				num = (short)1026752512;
				short num3 = num;
				num = (short)1007157248;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.HiddenStatic = value;
			}
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x0600BC9C RID: 48284 RVA: 0x00AE991C File Offset: 0x00AE7B1C
		// (set) Token: 0x0600BC9D RID: 48285 RVA: 0x00AE99D4 File Offset: 0x00AE7BD4
		internal bool CnvSysGeneralEmergencyProfileSelection_A19421_HiddenDynamic
		{
			get
			{
				short num = (short)826434205;
				short num2 = num;
				num = (short)1375888029;
				switch (num2 == num)
				{
				}
				num = (short)915341313;
				if (num != 0)
				{
				}
				num = (short)1810563072;
				short num3 = num;
				num = (short)159580160;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421.HiddenDynamic;
			}
			set
			{
				short num = (short)1788160699;
				short num2 = num;
				num = (short)1713449659;
				switch (num2 == num)
				{
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)393805824;
				short num3 = num;
				num = (short)1661861888;
				if (num != 0)
				{
				}
				this.cnvSysGeneralEmergencyProfileSelection_A19421.HiddenDynamic = value;
			}
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x0600BC9E RID: 48286 RVA: 0x00AE9A8C File Offset: 0x00AE7C8C
		public bool CnvSysGeneralEmergencyProfileSelection_A19421_HasDiffs
		{
			get
			{
				short num = (short)341180417;
				if (num != 0)
				{
				}
				num = (short)549997187;
				short num2 = num;
				num = (short)627526275;
				switch (num2 == num)
				{
				}
				num = (short)863764480;
				short num3 = num;
				num = (short)2013724672;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralEmergencyProfileSelection_A19421._HasDiffs;
			}
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0600BC9F RID: 48287 RVA: 0x00AE9B40 File Offset: 0x00AE7D40
		// (set) Token: 0x0600BCA0 RID: 48288 RVA: 0x00AE9BF4 File Offset: 0x00AE7DF4
		public bool CnvSysLabtoolPreambleEnable_A19576Value
		{
			get
			{
				short num = (short)2126721668;
				short num2 = num;
				num = (short)221065860;
				switch (num2 == num)
				{
				}
				num = (short)555679745;
				if (num != 0)
				{
				}
				num = (short)26214400;
				short num3 = num;
				num = (short)416022528;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Value;
			}
			set
			{
				short num = (short)7369529;
				short num2 = num;
				num = (short)1844409145;
				switch (num2 == num)
				{
				}
				num = (short)440270849;
				if (num != 0)
				{
				}
				num = (short)146472960;
				short num3 = num;
				num = (short)603652096;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Value = value;
			}
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x0600BCA1 RID: 48289 RVA: 0x00AE9CA8 File Offset: 0x00AE7EA8
		public global::AcpBusinessLayer.AcpField<bool> CnvSysLabtoolPreambleEnable_A19576
		{
			get
			{
				short num = (short)1018161229;
				short num2 = num;
				num = (short)282847309;
				switch (num2 == num)
				{
				}
				num = (short)2008743937;
				if (num != 0)
				{
				}
				num = (short)1939210240;
				short num3 = num;
				num = (short)1377304576;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576;
			}
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x00AE9D58 File Offset: 0x00AE7F58
		// (set) Token: 0x0600BCA3 RID: 48291 RVA: 0x00AE9E10 File Offset: 0x00AE8010
		public bool CnvSysLabtoolPreambleEnable_A19576_UIValue
		{
			get
			{
				short num = (short)1543438337;
				if (num != 0)
				{
				}
				num = (short)1161436506;
				short num2 = num;
				num = (short)1649089882;
				switch (num2 == num)
				{
				}
				num = (short)1983315968;
				short num3 = num;
				num = (short)530776064;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Value;
			}
			set
			{
				short num = (short)1754098063;
				short num2 = num;
				num = (short)1267034511;
				switch (num2 == num)
				{
				}
				num = (short)249888769;
				if (num != 0)
				{
				}
				num = (short)848101376;
				short num3 = num;
				num = (short)1100677120;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Value = value;
			}
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x00AE9EC4 File Offset: 0x00AE80C4
		// (set) Token: 0x0600BCA5 RID: 48293 RVA: 0x00AE9F78 File Offset: 0x00AE8178
		public bool CnvSysLabtoolPreambleEnable_A19576_Applicable
		{
			get
			{
				short num = (short)399285264;
				short num2 = num;
				num = (short)203136016;
				switch (num2 == num)
				{
				}
				num = (short)240648193;
				if (num != 0)
				{
				}
				num = (short)229113856;
				short num3 = num;
				num = (short)1206255616;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Applicable;
			}
			set
			{
				short num = (short)1220861183;
				short num2 = num;
				num = (short)494132479;
				switch (num2 == num)
				{
				}
				num = (short)1925513217;
				if (num != 0)
				{
				}
				num = (short)1821442048;
				short num3 = num;
				num = (short)1059389440;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Applicable = value;
			}
		}

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x0600BCA6 RID: 48294 RVA: 0x00AEA030 File Offset: 0x00AE8230
		// (set) Token: 0x0600BCA7 RID: 48295 RVA: 0x00AEA0E4 File Offset: 0x00AE82E4
		public bool CnvSysLabtoolPreambleEnable_A19576_Valid
		{
			get
			{
				short num = (short)692846592;
				short num2 = num;
				num = (short)702453215;
				short num3 = num;
				num = (short)129275359;
				switch (num3 == num)
				{
				}
				num = (short)1739194369;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Valid;
			}
			set
			{
				short num = (short)1025900544;
				short num2 = num;
				num = (short)1660354561;
				if (num != 0)
				{
				}
				num = (short)1284071134;
				short num3 = num;
				num = (short)1547984606;
				switch (num3 == num)
				{
				}
				num = (short)1463681024;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Valid = value;
			}
		}

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x0600BCA8 RID: 48296 RVA: 0x00AEA198 File Offset: 0x00AE8398
		// (set) Token: 0x0600BCA9 RID: 48297 RVA: 0x00AEA24C File Offset: 0x00AE844C
		public bool CnvSysLabtoolPreambleEnable_A19576_Visible
		{
			get
			{
				short num = (short)1260847104;
				short num2 = num;
				num = (short)1141806706;
				short num3 = num;
				num = (short)1985582706;
				switch (num3 == num)
				{
				}
				num = (short)1860435969;
				if (num != 0)
				{
				}
				num = (short)912588800;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Visible;
			}
			set
			{
				short num = (short)1381236736;
				short num2 = num;
				num = (short)240675442;
				short num3 = num;
				num = (short)1185966706;
				switch (num3 == num)
				{
				}
				num = (short)193724416;
				if (num != 0)
				{
				}
				num = (short)1374355457;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Visible = value;
			}
		}

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x00AEA300 File Offset: 0x00AE8500
		// (set) Token: 0x0600BCAB RID: 48299 RVA: 0x00AEA3B4 File Offset: 0x00AE85B4
		public bool CnvSysLabtoolPreambleEnable_A19576_Editable
		{
			get
			{
				short num = (short)806354944;
				short num2 = num;
				num = (short)237217665;
				short num3 = num;
				num = (short)1968809857;
				switch (num3 == num)
				{
				}
				num = (short)1840381952;
				if (num != 0)
				{
				}
				num = (short)967639041;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.Editable;
			}
			set
			{
				short num = (short)934281216;
				short num2 = num;
				num = (short)1867491205;
				short num3 = num;
				num = (short)540256133;
				switch (num3 == num)
				{
				}
				num = (short)366608385;
				if (num != 0)
				{
				}
				num = (short)515178496;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.Editable = value;
			}
		}

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x0600BCAC RID: 48300 RVA: 0x00AEA468 File Offset: 0x00AE8668
		internal string CnvSysLabtoolPreambleEnable_A19576_UILabel
		{
			get
			{
				short num = (short)136773632;
				short num2 = num;
				num = (short)928382977;
				if (num != 0)
				{
				}
				num = (short)660797175;
				short num3 = num;
				num = (short)658634487;
				switch (num3 == num)
				{
				}
				num = (short)1592983552;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.UIName;
			}
		}

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x0600BCAD RID: 48301 RVA: 0x00AEA51C File Offset: 0x00AE871C
		// (set) Token: 0x0600BCAE RID: 48302 RVA: 0x00AEA5D4 File Offset: 0x00AE87D4
		internal bool CnvSysLabtoolPreambleEnable_A19576_HiddenStatic
		{
			get
			{
				short num = (short)1048707072;
				short num2 = num;
				num = (short)531261396;
				short num3 = num;
				num = (short)2068408276;
				switch (num3 == num)
				{
				}
				num = (short)1399455745;
				if (num != 0)
				{
				}
				num = (short)177340416;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.HiddenStatic;
			}
			set
			{
				short num = (short)1535836160;
				short num2 = num;
				num = (short)715445770;
				short num3 = num;
				num = (short)1791874570;
				switch (num3 == num)
				{
				}
				num = (short)1784348672;
				if (num != 0)
				{
				}
				num = (short)2082013185;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.HiddenStatic = value;
			}
		}

		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x00AEA688 File Offset: 0x00AE8888
		// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x00AEA73C File Offset: 0x00AE893C
		internal bool CnvSysLabtoolPreambleEnable_A19576_HiddenDynamic
		{
			get
			{
				short num = (short)1979777024;
				short num2 = num;
				num = (short)458432346;
				short num3 = num;
				num = (short)152248154;
				switch (num3 == num)
				{
				}
				num = (short)1374158849;
				if (num != 0)
				{
				}
				num = (short)1680474112;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576.HiddenDynamic;
			}
			set
			{
				short num = (short)2083717120;
				short num2 = num;
				num = (short)291590170;
				short num3 = num;
				num = (short)552620058;
				switch (num3 == num)
				{
				}
				num = (short)1429995520;
				if (num != 0)
				{
				}
				num = (short)2117533697;
				if (num != 0)
				{
				}
				this.cnvSysLabtoolPreambleEnable_A19576.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EA7 RID: 24231
		// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x00AEA7F4 File Offset: 0x00AE89F4
		public bool CnvSysLabtoolPreambleEnable_A19576_HasDiffs
		{
			get
			{
				short num = (short)1645871104;
				short num2 = num;
				num = (short)1247150081;
				if (num != 0)
				{
				}
				num = (short)21423493;
				short num3 = num;
				num = (short)1170793861;
				switch (num3 == num)
				{
				}
				num = (short)882835456;
				if (num != 0)
				{
				}
				return this.cnvSysLabtoolPreambleEnable_A19576._HasDiffs;
			}
		}

		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0600BCB2 RID: 48306 RVA: 0x00AEA8AC File Offset: 0x00AE8AAC
		// (set) Token: 0x0600BCB3 RID: 48307 RVA: 0x00AEA960 File Offset: 0x00AE8B60
		public string CnvSysGeneralKeyofConventionalSystem_A20482Value
		{
			get
			{
				short num = (short)873398272;
				short num2 = num;
				num = (short)777500773;
				short num3 = num;
				num = (short)1949939813;
				switch (num3 == num)
				{
				}
				num = (short)1900937217;
				if (num != 0)
				{
				}
				num = (short)1696333824;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Value;
			}
			set
			{
				short num = (short)1726611458;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.cnvSysGeneralKeyofConventionalSystem_A20482.Value = value;
						num = (short)178651136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)859701249;
						if (num != 0)
						{
						}
						num = (short)1139575348;
						short num3 = num;
						num = (short)948472372;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)1143472128;
							if (num != 0)
							{
							}
							num = (short)89653248;
							short num4 = num;
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						}
						}
						break;
					}
					}
					IL_CE:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)18874369;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x0600BCB4 RID: 48308 RVA: 0x00AEAA80 File Offset: 0x00AE8C80
		// (set) Token: 0x0600BCB5 RID: 48309 RVA: 0x00AEAB38 File Offset: 0x00AE8D38
		public string CnvSysGeneralKeyofConventionalSystem_A20482_UIValue
		{
			get
			{
				short num = (short)965672960;
				short num2 = num;
				num = (short)544291353;
				short num3 = num;
				num = (short)83638809;
				switch (num3 == num)
				{
				}
				num = (short)1364918273;
				if (num != 0)
				{
				}
				num = (short)848560128;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Value;
			}
			set
			{
				short num = (short)18415616;
				short num2 = num;
				num = (short)376333302;
				short num3 = num;
				num = (short)1895064566;
				switch (num3 == num)
				{
				}
				num = (short)1115553793;
				if (num != 0)
				{
				}
				num = (short)1904869376;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.Value = value;
			}
		}

		// Token: 0x17005EAA RID: 24234
		// (get) Token: 0x0600BCB6 RID: 48310 RVA: 0x00AEABF0 File Offset: 0x00AE8DF0
		public global::AcpBusinessLayer.AcpKeyField CnvSysGeneralKeyofConventionalSystem_A20482
		{
			get
			{
				short num = (short)845348864;
				short num2 = num;
				num = (short)623446516;
				short num3 = num;
				num = (short)302975476;
				switch (num3 == num)
				{
				}
				num = (short)1371602945;
				if (num != 0)
				{
				}
				num = (short)262471680;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482;
			}
		}

		// Token: 0x17005EAB RID: 24235
		// (get) Token: 0x0600BCB7 RID: 48311 RVA: 0x00AEACA0 File Offset: 0x00AE8EA0
		// (set) Token: 0x0600BCB8 RID: 48312 RVA: 0x00AEAD54 File Offset: 0x00AE8F54
		public bool CnvSysGeneralKeyofConventionalSystem_A20482_Applicable
		{
			get
			{
				short num = (short)985858048;
				short num2 = num;
				num = (short)1369795993;
				short num3 = num;
				num = (short)1366650265;
				switch (num3 == num)
				{
				}
				num = (short)1806827520;
				if (num != 0)
				{
				}
				num = (short)525991937;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Applicable;
			}
			set
			{
				short num = (short)1598291968;
				short num2 = num;
				num = (short)1576755311;
				short num3 = num;
				num = (short)1504534639;
				switch (num3 == num)
				{
				}
				num = (short)280494081;
				if (num != 0)
				{
				}
				num = (short)1761542144;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.Applicable = value;
			}
		}

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x0600BCB9 RID: 48313 RVA: 0x00AEAE10 File Offset: 0x00AE9010
		// (set) Token: 0x0600BCBA RID: 48314 RVA: 0x00AEAEC4 File Offset: 0x00AE90C4
		public bool CnvSysGeneralKeyofConventionalSystem_A20482_Valid
		{
			get
			{
				short num = (short)836173824;
				short num2 = num;
				num = (short)1334211168;
				short num3 = num;
				num = (short)945058400;
				switch (num3 == num)
				{
				}
				num = (short)1615855617;
				if (num != 0)
				{
				}
				num = (short)1636958208;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Valid;
			}
			set
			{
				short num = (short)1550974976;
				short num2 = num;
				num = (short)1578621178;
				short num3 = num;
				num = (short)660986106;
				switch (num3 == num)
				{
				}
				num = (short)1529479169;
				if (num != 0)
				{
				}
				num = (short)591724544;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.Valid = value;
			}
		}

		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x00AEAF78 File Offset: 0x00AE9178
		// (set) Token: 0x0600BCBC RID: 48316 RVA: 0x00AEB02C File Offset: 0x00AE922C
		public bool CnvSysGeneralKeyofConventionalSystem_A20482_Visible
		{
			get
			{
				short num = (short)1679294464;
				short num2 = num;
				num = (short)1692059318;
				short num3 = num;
				num = (short)1796589238;
				switch (num3 == num)
				{
				}
				num = (short)1472724992;
				if (num != 0)
				{
				}
				num = (short)1951465473;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Visible;
			}
			set
			{
				short num = (short)1401552896;
				short num2 = num;
				num = (short)428232135;
				short num3 = num;
				num = (short)1311395271;
				switch (num3 == num)
				{
				}
				num = (short)49086465;
				if (num != 0)
				{
				}
				num = (short)1339621376;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.Visible = value;
			}
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x0600BCBD RID: 48317 RVA: 0x00AEB0E0 File Offset: 0x00AE92E0
		// (set) Token: 0x0600BCBE RID: 48318 RVA: 0x00AEB194 File Offset: 0x00AE9394
		public bool CnvSysGeneralKeyofConventionalSystem_A20482_Editable
		{
			get
			{
				short num = (short)667942912;
				short num2 = num;
				num = (short)257424110;
				short num3 = num;
				num = (short)1443429102;
				switch (num3 == num)
				{
				}
				num = (short)1771700225;
				if (num != 0)
				{
				}
				num = (short)66387968;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.Editable;
			}
			set
			{
				short num = (short)1570766848;
				short num2 = num;
				num = (short)1364062450;
				short num3 = num;
				num = (short)1762586866;
				switch (num3 == num)
				{
				}
				num = (short)727384065;
				if (num != 0)
				{
				}
				num = (short)1481703424;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.Editable = value;
			}
		}

		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x00AEB248 File Offset: 0x00AE9448
		internal string CnvSysGeneralKeyofConventionalSystem_A20482_UILabel
		{
			get
			{
				short num = (short)1098055680;
				short num2 = num;
				num = (short)733581544;
				short num3 = num;
				num = (short)1323471080;
				switch (num3 == num)
				{
				}
				num = (short)1367343105;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.UIName;
			}
		}

		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x00AEB2FC File Offset: 0x00AE94FC
		// (set) Token: 0x0600BCC1 RID: 48321 RVA: 0x00AEB3B0 File Offset: 0x00AE95B0
		internal bool CnvSysGeneralKeyofConventionalSystem_A20482_HiddenStatic
		{
			get
			{
				short num = (short)444596224;
				short num2 = num;
				num = (short)1787166721;
				if (num != 0)
				{
				}
				num = (short)1241897117;
				short num3 = num;
				num = (short)360503453;
				switch (num3 == num)
				{
				}
				num = (short)1068236800;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.HiddenStatic;
			}
			set
			{
				short num = (short)1946681344;
				short num2 = num;
				num = (short)1263534081;
				if (num != 0)
				{
				}
				num = (short)397391016;
				short num3 = num;
				num = (short)769897640;
				switch (num3 == num)
				{
				}
				num = (short)1610153984;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.HiddenStatic = value;
			}
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x00AEB464 File Offset: 0x00AE9664
		// (set) Token: 0x0600BCC3 RID: 48323 RVA: 0x00AEB51C File Offset: 0x00AE971C
		internal bool CnvSysGeneralKeyofConventionalSystem_A20482_HiddenDynamic
		{
			get
			{
				short num = (short)959184896;
				short num2 = num;
				num = (short)170801787;
				short num3 = num;
				num = (short)568081019;
				switch (num3 == num)
				{
				}
				num = (short)1328021505;
				if (num != 0)
				{
				}
				num = (short)475004928;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482.HiddenDynamic;
			}
			set
			{
				short num = (short)2145452032;
				short num2 = num;
				num = (short)915436248;
				short num3 = num;
				num = (short)1060532952;
				switch (num3 == num)
				{
				}
				num = (short)695402497;
				if (num != 0)
				{
				}
				num = (short)1505165312;
				if (num != 0)
				{
				}
				this.cnvSysGeneralKeyofConventionalSystem_A20482.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x00AEB5D4 File Offset: 0x00AE97D4
		public bool CnvSysGeneralKeyofConventionalSystem_A20482_HasDiffs
		{
			get
			{
				short num = (short)1673986048;
				short num2 = num;
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)2079136756;
				short num3 = num;
				num = (short)576199668;
				switch (num3 == num)
				{
				}
				num = (short)1575944192;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralKeyofConventionalSystem_A20482._HasDiffs;
			}
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x0600BCC5 RID: 48325 RVA: 0x00AEB688 File Offset: 0x00AE9888
		// (set) Token: 0x0600BCC6 RID: 48326 RVA: 0x00AEB73C File Offset: 0x00AE993C
		public int CnvSysGeneralSystemGroupNumber_A21960Value
		{
			get
			{
				short num = (short)42598400;
				short num2 = num;
				num = (short)1905397053;
				short num3 = num;
				num = (short)1328221501;
				switch (num3 == num)
				{
				}
				num = (short)723910657;
				if (num != 0)
				{
				}
				num = (short)460849152;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Value;
			}
			set
			{
				short num = (short)15990784;
				short num2 = num;
				num = (short)615711551;
				short num3 = num;
				num = (short)783614783;
				switch (num3 == num)
				{
				}
				num = (short)1565786113;
				if (num != 0)
				{
				}
				num = (short)675151872;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Value = value;
			}
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x00AEB7F4 File Offset: 0x00AE99F4
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralSystemGroupNumber_A21960
		{
			get
			{
				short num = (short)63242240;
				short num2 = num;
				num = (short)389646606;
				short num3 = num;
				num = (short)35424526;
				switch (num3 == num)
				{
				}
				num = (short)1509228545;
				if (num != 0)
				{
				}
				num = (short)1114963968;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960;
			}
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x00AEB8A4 File Offset: 0x00AE9AA4
		// (set) Token: 0x0600BCC9 RID: 48329 RVA: 0x00AEB95C File Offset: 0x00AE9B5C
		public string CnvSysGeneralSystemGroupNumber_A21960_UIValue
		{
			get
			{
				short num = (short)741146624;
				short num2 = num;
				num = (short)753557951;
				short num3 = num;
				num = (short)1039360447;
				switch (num3 == num)
				{
				}
				num = (short)1229783040;
				if (num != 0)
				{
				}
				num = (short)581566465;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.UIValue;
			}
			set
			{
				short num = (short)1501888512;
				short num2 = num;
				num = (short)1846705582;
				short num3 = num;
				num = (short)277446062;
				switch (num3 == num)
				{
				}
				num = (short)1394475009;
				if (num != 0)
				{
				}
				num = (short)1158676480;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.UIValue = value;
			}
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x00AEBA14 File Offset: 0x00AE9C14
		// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x00AEBACC File Offset: 0x00AE9CCC
		public string CnvSysGeneralSystemGroupNumber_A21960_HexUIValue
		{
			get
			{
				short num = (short)1923809280;
				short num2 = num;
				num = (short)333955891;
				short num3 = num;
				num = (short)1570358067;
				switch (num3 == num)
				{
				}
				num = (short)1773076481;
				if (num != 0)
				{
				}
				num = (short)1859911680;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.HexUIValue;
			}
			set
			{
				short num = (short)243073024;
				short num2 = num;
				num = (short)1701560615;
				short num3 = num;
				num = (short)649052455;
				switch (num3 == num)
				{
				}
				num = (short)1944518657;
				if (num != 0)
				{
				}
				num = (short)1772093440;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.HexUIValue = value;
			}
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x00AEBB84 File Offset: 0x00AE9D84
		// (set) Token: 0x0600BCCD RID: 48333 RVA: 0x00AEBC38 File Offset: 0x00AE9E38
		internal int CnvSysGeneralSystemGroupNumber_A21960Min
		{
			get
			{
				short num = (short)1373962240;
				short num2 = num;
				num = (short)71901767;
				short num3 = num;
				num = (short)2139038279;
				switch (num3 == num)
				{
				}
				num = (short)318439425;
				if (num != 0)
				{
				}
				num = (short)1331953664;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Min;
			}
			set
			{
				short num = (short)241238016;
				short num2 = num;
				num = (short)561663305;
				short num3 = num;
				num = (short)1133989193;
				switch (num3 == num)
				{
				}
				num = (short)1979842560;
				if (num != 0)
				{
				}
				num = (short)1405353985;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Min = value;
			}
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x00AEBCF0 File Offset: 0x00AE9EF0
		// (set) Token: 0x0600BCCF RID: 48335 RVA: 0x00AEBDA4 File Offset: 0x00AE9FA4
		internal int CnvSysGeneralSystemGroupNumber_A21960Max
		{
			get
			{
				short num = (short)660930560;
				short num2 = num;
				num = (short)1540734399;
				short num3 = num;
				num = (short)884063679;
				switch (num3 == num)
				{
				}
				num = (short)1695088640;
				if (num != 0)
				{
				}
				num = (short)828899329;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Max;
			}
			set
			{
				short num = (short)618266624;
				short num2 = num;
				num = (short)999286773;
				short num3 = num;
				num = (short)1041033205;
				switch (num3 == num)
				{
				}
				num = (short)497418240;
				if (num != 0)
				{
				}
				num = (short)536805377;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Max = value;
			}
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x00AEBE58 File Offset: 0x00AEA058
		// (set) Token: 0x0600BCD1 RID: 48337 RVA: 0x00AEBF0C File Offset: 0x00AEA10C
		internal int CnvSysGeneralSystemGroupNumber_A21960Step
		{
			get
			{
				short num = (short)955580416;
				short num2 = num;
				num = (short)2084288471;
				short num3 = num;
				num = (short)550746071;
				switch (num3 == num)
				{
				}
				num = (short)818020352;
				if (num != 0)
				{
				}
				num = (short)159580161;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.StepSize;
			}
			set
			{
				short num = (short)1044119552;
				short num2 = num;
				num = (short)2036664590;
				short num3 = num;
				num = (short)1366624526;
				switch (num3 == num)
				{
				}
				num = (short)283901952;
				if (num != 0)
				{
				}
				num = (short)787087361;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.StepSize = value;
			}
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x00AEBFC4 File Offset: 0x00AEA1C4
		// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x00AEC078 File Offset: 0x00AEA278
		public bool CnvSysGeneralSystemGroupNumber_A21960_Applicable
		{
			get
			{
				short num = (short)1860173824;
				short num2 = num;
				num = (short)289408680;
				short num3 = num;
				num = (short)1875576488;
				switch (num3 == num)
				{
				}
				num = (short)1480916993;
				if (num != 0)
				{
				}
				num = (short)1363279872;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Applicable;
			}
			set
			{
				short num = (short)1286340608;
				short num2 = num;
				num = (short)1781759255;
				short num3 = num;
				num = (short)725450007;
				switch (num3 == num)
				{
				}
				num = (short)1152057345;
				if (num != 0)
				{
				}
				num = (short)1637744640;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Applicable = value;
			}
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x0600BCD4 RID: 48340 RVA: 0x00AEC12C File Offset: 0x00AEA32C
		// (set) Token: 0x0600BCD5 RID: 48341 RVA: 0x00AEC1E0 File Offset: 0x00AEA3E0
		public bool CnvSysGeneralSystemGroupNumber_A21960_Valid
		{
			get
			{
				short num = (short)1544552448;
				short num2 = num;
				num = (short)185692758;
				short num3 = num;
				num = (short)1420980822;
				switch (num3 == num)
				{
				}
				num = (short)2000617472;
				if (num != 0)
				{
				}
				num = (short)185532417;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Valid;
			}
			set
			{
				short num = (short)1069809664;
				short num2 = num;
				num = (short)1119141966;
				short num3 = num;
				num = (short)557957198;
				switch (num3 == num)
				{
				}
				num = (short)615579648;
				if (num != 0)
				{
				}
				num = (short)273743873;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Valid = value;
			}
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x00AEC294 File Offset: 0x00AEA494
		// (set) Token: 0x0600BCD7 RID: 48343 RVA: 0x00AEC348 File Offset: 0x00AEA548
		public bool CnvSysGeneralSystemGroupNumber_A21960_Visible
		{
			get
			{
				short num = (short)503054336;
				short num2 = num;
				num = (short)1456797802;
				short num3 = num;
				num = (short)1997994090;
				switch (num3 == num)
				{
				}
				num = (short)1878917121;
				if (num != 0)
				{
				}
				num = (short)1442906112;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Visible;
			}
			set
			{
				short num = (short)414842880;
				short num2 = num;
				num = (short)1371082562;
				short num3 = num;
				num = (short)724111170;
				switch (num3 == num)
				{
				}
				num = (short)1176043521;
				if (num != 0)
				{
				}
				num = (short)1084948480;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Visible = value;
			}
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x00AEC400 File Offset: 0x00AEA600
		// (set) Token: 0x0600BCD9 RID: 48345 RVA: 0x00AEC4B8 File Offset: 0x00AEA6B8
		public bool CnvSysGeneralSystemGroupNumber_A21960_Editable
		{
			get
			{
				short num = (short)1025966080;
				short num2 = num;
				num = (short)341049345;
				if (num != 0)
				{
				}
				num = (short)1539825240;
				short num3 = num;
				num = (short)279502424;
				switch (num3 == num)
				{
				}
				num = (short)392888320;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.Editable;
			}
			set
			{
				short num = (short)321716224;
				short num2 = num;
				num = (short)20688833;
				short num3 = num;
				num = (short)2145693633;
				switch (num3 == num)
				{
				}
				num = (short)1003814913;
				if (num != 0)
				{
				}
				num = (short)218562560;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.Editable = value;
			}
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x0600BCDA RID: 48346 RVA: 0x00AEC570 File Offset: 0x00AEA770
		internal string CnvSysGeneralSystemGroupNumber_A21960_UILabel
		{
			get
			{
				short num = (short)1733623808;
				short num2 = num;
				num = (short)1359022368;
				short num3 = num;
				num = (short)1391986976;
				switch (num3 == num)
				{
				}
				num = (short)1839071233;
				if (num != 0)
				{
				}
				num = (short)1952120832;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.UIName;
			}
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x0600BCDB RID: 48347 RVA: 0x00AEC628 File Offset: 0x00AEA828
		// (set) Token: 0x0600BCDC RID: 48348 RVA: 0x00AEC6DC File Offset: 0x00AEA8DC
		internal bool CnvSysGeneralSystemGroupNumber_A21960_HiddenStatic
		{
			get
			{
				short num = (short)201457664;
				short num2 = num;
				num = (short)2038049199;
				short num3 = num;
				num = (short)51587503;
				switch (num3 == num)
				{
				}
				num = (short)982646785;
				if (num != 0)
				{
				}
				num = (short)1922760704;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.HiddenStatic;
			}
			set
			{
				short num = (short)1605238784;
				short num2 = num;
				num = (short)606797825;
				if (num != 0)
				{
				}
				num = (short)1932592133;
				short num3 = num;
				num = (short)1157235717;
				switch (num3 == num)
				{
				}
				num = (short)1051197440;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.HiddenStatic = value;
			}
		}

		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x0600BCDD RID: 48349 RVA: 0x00AEC790 File Offset: 0x00AEA990
		// (set) Token: 0x0600BCDE RID: 48350 RVA: 0x00AEC84C File Offset: 0x00AEAA4C
		internal bool CnvSysGeneralSystemGroupNumber_A21960_HiddenDynamic
		{
			get
			{
				short num = (short)622854144;
				short num2 = num;
				num = (short)1348980520;
				short num3 = num;
				num = (short)1395248936;
				switch (num3 == num)
				{
				}
				num = (short)65994753;
				if (num != 0)
				{
				}
				num = (short)134348800;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960.HiddenDynamic;
			}
			set
			{
				short num = (short)510722048;
				short num2 = num;
				num = (short)2017923351;
				short num3 = num;
				num = (short)2026443031;
				switch (num3 == num)
				{
				}
				num = (short)756023297;
				if (num != 0)
				{
				}
				num = (short)1284702208;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemGroupNumber_A21960.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x00AEC904 File Offset: 0x00AEAB04
		public bool CnvSysGeneralSystemGroupNumber_A21960_HasDiffs
		{
			get
			{
				short num = (short)1507328;
				short num2 = num;
				num = (short)420912003;
				short num3 = num;
				num = (short)359373699;
				switch (num3 == num)
				{
				}
				num = (short)2002845697;
				if (num != 0)
				{
				}
				num = (short)1274413056;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemGroupNumber_A21960._HasDiffs;
			}
		}

		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x00AEC9B8 File Offset: 0x00AEABB8
		// (set) Token: 0x0600BCE1 RID: 48353 RVA: 0x00AECA6C File Offset: 0x00AEAC6C
		public int CnvSysGeneralPreambleLength_A8721Value
		{
			get
			{
				short num = (short)2124873728;
				short num2 = num;
				num = (short)1299709953;
				if (num != 0)
				{
				}
				num = (short)1902868863;
				short num3 = num;
				num = (short)2094954879;
				switch (num3 == num)
				{
				}
				num = (short)397672448;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Value;
			}
			set
			{
				short num = (short)1427177472;
				short num2 = num;
				num = (short)2102269593;
				short num3 = num;
				num = (short)191239833;
				switch (num3 == num)
				{
				}
				num = (short)294256641;
				if (num != 0)
				{
				}
				num = (short)1084293120;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Value = value;
			}
		}

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x0600BCE2 RID: 48354 RVA: 0x00AECB24 File Offset: 0x00AEAD24
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralPreambleLength_A8721
		{
			get
			{
				short num = (short)539295744;
				short num2 = num;
				num = (short)1559416551;
				short num3 = num;
				num = (short)580832999;
				switch (num3 == num)
				{
				}
				num = (short)1402077185;
				if (num != 0)
				{
				}
				num = (short)489684992;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721;
			}
		}

		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x0600BCE3 RID: 48355 RVA: 0x00AECBD0 File Offset: 0x00AEADD0
		// (set) Token: 0x0600BCE4 RID: 48356 RVA: 0x00AECC88 File Offset: 0x00AEAE88
		public string CnvSysGeneralPreambleLength_A8721_UIValue
		{
			get
			{
				short num = (short)1770651648;
				short num2 = num;
				num = (short)576930382;
				short num3 = num;
				num = (short)44253774;
				switch (num3 == num)
				{
				}
				num = (short)665452544;
				if (num != 0)
				{
				}
				num = (short)166854657;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.UIValue;
			}
			set
			{
				short num = (short)374013952;
				short num2 = num;
				num = (short)1659371521;
				if (num != 0)
				{
				}
				num = (short)843328857;
				short num3 = num;
				num = (short)1857039705;
				switch (num3 == num)
				{
				}
				num = (short)20512768;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.UIValue = value;
			}
		}

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x00AECD3C File Offset: 0x00AEAF3C
		// (set) Token: 0x0600BCE6 RID: 48358 RVA: 0x00AECDF4 File Offset: 0x00AEAFF4
		internal int CnvSysGeneralPreambleLength_A8721Min
		{
			get
			{
				short num = (short)325255168;
				short num2 = num;
				num = (short)553542450;
				short num3 = num;
				num = (short)152462130;
				switch (num3 == num)
				{
				}
				num = (short)1346043905;
				if (num != 0)
				{
				}
				num = (short)54788096;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Min;
			}
			set
			{
				short num = (short)1093992448;
				short num2 = num;
				num = (short)1657013093;
				short num3 = num;
				num = (short)715129701;
				switch (num3 == num)
				{
				}
				num = (short)1559756801;
				if (num != 0)
				{
				}
				num = (short)1090519040;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Min = value;
			}
		}

		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x0600BCE7 RID: 48359 RVA: 0x00AECEAC File Offset: 0x00AEB0AC
		// (set) Token: 0x0600BCE8 RID: 48360 RVA: 0x00AECF60 File Offset: 0x00AEB160
		internal int CnvSysGeneralPreambleLength_A8721Max
		{
			get
			{
				short num = (short)847904768;
				short num2 = num;
				num = (short)52839133;
				short num3 = num;
				num = (short)2136228573;
				switch (num3 == num)
				{
				}
				num = (short)363134977;
				if (num != 0)
				{
				}
				num = (short)1172766720;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Max;
			}
			set
			{
				short num = (short)1562509312;
				short num2 = num;
				num = (short)413852229;
				short num3 = num;
				num = (short)530309701;
				switch (num3 == num)
				{
				}
				num = (short)1606156288;
				if (num != 0)
				{
				}
				num = (short)86638593;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Max = value;
			}
		}

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x0600BCE9 RID: 48361 RVA: 0x00AED018 File Offset: 0x00AEB218
		// (set) Token: 0x0600BCEA RID: 48362 RVA: 0x00AED0CC File Offset: 0x00AEB2CC
		internal int CnvSysGeneralPreambleLength_A8721Step
		{
			get
			{
				short num = (short)1585381376;
				short num2 = num;
				num = (short)1315450710;
				short num3 = num;
				num = (short)470101846;
				switch (num3 == num)
				{
				}
				num = (short)1984233472;
				if (num != 0)
				{
				}
				num = (short)223608833;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.StepSize;
			}
			set
			{
				short num = (short)1471086592;
				short num2 = num;
				num = (short)1636771956;
				short num3 = num;
				num = (short)916793460;
				switch (num3 == num)
				{
				}
				num = (short)2051473409;
				if (num != 0)
				{
				}
				num = (short)1142030336;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.StepSize = value;
			}
		}

		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x00AED180 File Offset: 0x00AEB380
		// (set) Token: 0x0600BCEC RID: 48364 RVA: 0x00AED234 File Offset: 0x00AEB434
		public bool CnvSysGeneralPreambleLength_A8721_Applicable
		{
			get
			{
				short num = (short)2120548352;
				short num2 = num;
				num = (short)1692401665;
				if (num != 0)
				{
				}
				num = (short)254786667;
				short num3 = num;
				num = (short)1237040235;
				switch (num3 == num)
				{
				}
				num = (short)1018888192;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Applicable;
			}
			set
			{
				short num = (short)997588992;
				short num2 = num;
				num = (short)221577217;
				if (num != 0)
				{
				}
				num = (short)1821548739;
				short num3 = num;
				num = (short)828154051;
				switch (num3 == num)
				{
				}
				num = (short)216793088;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Applicable = value;
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x0600BCED RID: 48365 RVA: 0x00AED2EC File Offset: 0x00AEB4EC
		// (set) Token: 0x0600BCEE RID: 48366 RVA: 0x00AED3A0 File Offset: 0x00AEB5A0
		public bool CnvSysGeneralPreambleLength_A8721_Valid
		{
			get
			{
				short num = (short)30277632;
				short num2 = num;
				num = (short)1821507585;
				if (num != 0)
				{
				}
				num = (short)1094011085;
				short num3 = num;
				num = (short)1563052237;
				switch (num3 == num)
				{
				}
				num = (short)2080243712;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Valid;
			}
			set
			{
				short num = (short)917635072;
				short num2 = num;
				num = (short)278285137;
				short num3 = num;
				num = (short)1532316497;
				switch (num3 == num)
				{
				}
				num = (short)720764929;
				if (num != 0)
				{
				}
				num = (short)1549402112;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Valid = value;
			}
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x00AED454 File Offset: 0x00AEB654
		// (set) Token: 0x0600BCF0 RID: 48368 RVA: 0x00AED50C File Offset: 0x00AEB70C
		public bool CnvSysGeneralPreambleLength_A8721_Visible
		{
			get
			{
				short num = (short)704249856;
				short num2 = num;
				num = (short)533074725;
				short num3 = num;
				num = (short)1317999397;
				switch (num3 == num)
				{
				}
				num = (short)1908736001;
				if (num != 0)
				{
				}
				num = (short)934281216;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Visible;
			}
			set
			{
				short num = (short)591462400;
				short num2 = num;
				num = (short)1069069473;
				short num3 = num;
				num = (short)851424417;
				switch (num3 == num)
				{
				}
				num = (short)894894081;
				if (num != 0)
				{
				}
				num = (short)2096037888;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Visible = value;
			}
		}

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x00AED5C0 File Offset: 0x00AEB7C0
		// (set) Token: 0x0600BCF2 RID: 48370 RVA: 0x00AED674 File Offset: 0x00AEB874
		public bool CnvSysGeneralPreambleLength_A8721_Editable
		{
			get
			{
				short num = (short)1576009728;
				short num2 = num;
				num = (short)1860890885;
				short num3 = num;
				num = (short)669380869;
				switch (num3 == num)
				{
				}
				num = (short)609615873;
				if (num != 0)
				{
				}
				num = (short)671940608;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.Editable;
			}
			set
			{
				short num = (short)1346830336;
				short num2 = num;
				num = (short)2082144257;
				if (num != 0)
				{
				}
				num = (short)309268190;
				short num3 = num;
				num = (short)1632767710;
				switch (num3 == num)
				{
				}
				num = (short)1828388864;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.Editable = value;
			}
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x00AED72C File Offset: 0x00AEB92C
		internal string CnvSysGeneralPreambleLength_A8721_UILabel
		{
			get
			{
				short num = (short)868155392;
				short num2 = num;
				num = (short)1365394616;
				short num3 = num;
				num = (short)1926317240;
				switch (num3 == num)
				{
				}
				num = (short)1757347841;
				if (num != 0)
				{
				}
				num = (short)320143360;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.UIName;
			}
		}

		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x0600BCF4 RID: 48372 RVA: 0x00AED7DC File Offset: 0x00AEB9DC
		// (set) Token: 0x0600BCF5 RID: 48373 RVA: 0x00AED890 File Offset: 0x00AEBA90
		internal bool CnvSysGeneralPreambleLength_A8721_HiddenStatic
		{
			get
			{
				short num = (short)1032126464;
				short num2 = num;
				num = (short)138671173;
				short num3 = num;
				num = (short)915928133;
				switch (num3 == num)
				{
				}
				num = (short)1530789889;
				if (num != 0)
				{
				}
				num = (short)487522304;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.HiddenStatic;
			}
			set
			{
				short num = (short)1234370560;
				short num2 = num;
				num = (short)951743451;
				short num3 = num;
				num = (short)2101310427;
				switch (num3 == num)
				{
				}
				num = (short)506855425;
				if (num != 0)
				{
				}
				num = (short)214237184;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.HiddenStatic = value;
			}
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x0600BCF6 RID: 48374 RVA: 0x00AED948 File Offset: 0x00AEBB48
		// (set) Token: 0x0600BCF7 RID: 48375 RVA: 0x00AEDA00 File Offset: 0x00AEBC00
		internal bool CnvSysGeneralPreambleLength_A8721_HiddenDynamic
		{
			get
			{
				short num = (short)48627712;
				short num2 = num;
				num = (short)1202593425;
				short num3 = num;
				num = (short)818159249;
				switch (num3 == num)
				{
				}
				num = (short)790626305;
				if (num != 0)
				{
				}
				num = (short)1317273600;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721.HiddenDynamic;
			}
			set
			{
				short num = (short)814612480;
				short num2 = num;
				num = (short)902758401;
				if (num != 0)
				{
				}
				num = (short)561387599;
				short num3 = num;
				num = (short)1017256015;
				switch (num3 == num)
				{
				}
				num = (short)1801977856;
				if (num != 0)
				{
				}
				this.cnvSysGeneralPreambleLength_A8721.HiddenDynamic = value;
			}
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x00AEDAB4 File Offset: 0x00AEBCB4
		public bool CnvSysGeneralPreambleLength_A8721_HasDiffs
		{
			get
			{
				short num = (short)1418919936;
				short num2 = num;
				num = (short)386841661;
				short num3 = num;
				num = (short)82230333;
				switch (num3 == num)
				{
				}
				num = (short)662700033;
				if (num != 0)
				{
				}
				num = (short)343080960;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralPreambleLength_A8721._HasDiffs;
			}
		}

		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x00AEDB68 File Offset: 0x00AEBD68
		// (set) Token: 0x0600BCFA RID: 48378 RVA: 0x00AEDC1C File Offset: 0x00AEBE1C
		public int CnvSysGeneralIndividualID_A8287Value
		{
			get
			{
				short num = (short)1308360704;
				short num2 = num;
				num = (short)1784818488;
				short num3 = num;
				num = (short)245771064;
				switch (num3 == num)
				{
				}
				num = (short)2026831873;
				if (num != 0)
				{
				}
				num = (short)1954414592;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Value;
			}
			set
			{
				short num = (short)394526720;
				short num2 = num;
				num = (short)588420223;
				short num3 = num;
				num = (short)181638271;
				switch (num3 == num)
				{
				}
				num = (short)168230913;
				if (num != 0)
				{
				}
				num = (short)1241645056;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Value = value;
			}
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x00AEDCD4 File Offset: 0x00AEBED4
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysGeneralIndividualID_A8287
		{
			get
			{
				short num = (short)251002880;
				short num2 = num;
				num = (short)896625715;
				short num3 = num;
				num = (short)970222643;
				switch (num3 == num)
				{
				}
				num = (short)531824640;
				if (num != 0)
				{
				}
				num = (short)1196097537;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287;
			}
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x0600BCFC RID: 48380 RVA: 0x00AEDD80 File Offset: 0x00AEBF80
		// (set) Token: 0x0600BCFD RID: 48381 RVA: 0x00AEDE34 File Offset: 0x00AEC034
		public string CnvSysGeneralIndividualID_A8287_UIValue
		{
			get
			{
				short num = (short)446824448;
				short num2 = num;
				num = (short)1408630785;
				if (num != 0)
				{
				}
				num = (short)733283356;
				short num3 = num;
				num = (short)1783104540;
				switch (num3 == num)
				{
				}
				num = (short)1323171840;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.UIValue;
			}
			set
			{
				short num = (short)1138753536;
				short num2 = num;
				num = (short)1955125648;
				short num3 = num;
				num = (short)440785296;
				switch (num3 == num)
				{
				}
				num = (short)304087040;
				if (num != 0)
				{
				}
				num = (short)1482293249;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.UIValue = value;
			}
		}

		// Token: 0x17005ED3 RID: 24275
		// (get) Token: 0x0600BCFE RID: 48382 RVA: 0x00AEDEEC File Offset: 0x00AEC0EC
		// (set) Token: 0x0600BCFF RID: 48383 RVA: 0x00AEDFA0 File Offset: 0x00AEC1A0
		public string CnvSysGeneralIndividualID_A8287_HexUIValue
		{
			get
			{
				short num = (short)693370880;
				short num2 = num;
				num = (short)617710857;
				short num3 = num;
				num = (short)1137935625;
				switch (num3 == num)
				{
				}
				num = (short)181141505;
				if (num != 0)
				{
				}
				num = (short)430178304;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.HexUIValue;
			}
			set
			{
				short num = (short)367591424;
				short num2 = num;
				num = (short)617255575;
				short num3 = num;
				num = (short)44602007;
				switch (num3 == num)
				{
				}
				num = (short)2086469633;
				if (num != 0)
				{
				}
				num = (short)901447680;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.HexUIValue = value;
			}
		}

		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x0600BD00 RID: 48384 RVA: 0x00AEE058 File Offset: 0x00AEC258
		// (set) Token: 0x0600BD01 RID: 48385 RVA: 0x00AEE110 File Offset: 0x00AEC310
		internal int CnvSysGeneralIndividualID_A8287Min
		{
			get
			{
				short num = (short)764084224;
				short num2 = num;
				num = (short)758054913;
				if (num != 0)
				{
				}
				num = (short)1692363926;
				short num3 = num;
				num = (short)553217174;
				switch (num3 == num)
				{
				}
				num = (short)10747904;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Min;
			}
			set
			{
				short num = (short)1276968960;
				short num2 = num;
				num = (short)390856705;
				if (num != 0)
				{
				}
				num = (short)828450735;
				short num3 = num;
				num = (short)649209775;
				switch (num3 == num)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Min = value;
			}
		}

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x0600BD02 RID: 48386 RVA: 0x00AEE1C4 File Offset: 0x00AEC3C4
		// (set) Token: 0x0600BD03 RID: 48387 RVA: 0x00AEE278 File Offset: 0x00AEC478
		internal int CnvSysGeneralIndividualID_A8287Max
		{
			get
			{
				short num = (short)1727791104;
				short num2 = num;
				num = (short)775178151;
				short num3 = num;
				num = (short)1721649063;
				switch (num3 == num)
				{
				}
				num = (short)1686306817;
				if (num != 0)
				{
				}
				num = (short)1952579584;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Max;
			}
			set
			{
				short num = (short)1437532160;
				short num2 = num;
				num = (short)1008012206;
				short num3 = num;
				num = (short)276630446;
				switch (num3 == num)
				{
				}
				num = (short)138674176;
				if (num != 0)
				{
				}
				num = (short)37945345;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Max = value;
			}
		}

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x0600BD04 RID: 48388 RVA: 0x00AEE330 File Offset: 0x00AEC530
		// (set) Token: 0x0600BD05 RID: 48389 RVA: 0x00AEE3E8 File Offset: 0x00AEC5E8
		internal int CnvSysGeneralIndividualID_A8287Step
		{
			get
			{
				short num = (short)1458044928;
				short num2 = num;
				num = (short)2116189794;
				short num3 = num;
				num = (short)399539810;
				switch (num3 == num)
				{
				}
				num = (short)1697513472;
				if (num != 0)
				{
				}
				num = (short)1188560897;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.StepSize;
			}
			set
			{
				short num = (short)1015218176;
				short num2 = num;
				num = (short)1592294256;
				short num3 = num;
				num = (short)1213627248;
				switch (num3 == num)
				{
				}
				num = (short)1967063040;
				if (num != 0)
				{
				}
				num = (short)112918529;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.StepSize = value;
			}
		}

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x0600BD06 RID: 48390 RVA: 0x00AEE49C File Offset: 0x00AEC69C
		// (set) Token: 0x0600BD07 RID: 48391 RVA: 0x00AEE550 File Offset: 0x00AEC750
		public bool CnvSysGeneralIndividualID_A8287_Applicable
		{
			get
			{
				short num = (short)1620246528;
				short num2 = num;
				num = (short)248232604;
				short num3 = num;
				num = (short)1727117980;
				switch (num3 == num)
				{
				}
				num = (short)68485120;
				if (num != 0)
				{
				}
				num = (short)156893185;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Applicable;
			}
			set
			{
				short num = (short)562757632;
				short num2 = num;
				num = (short)265180325;
				short num3 = num;
				num = (short)1119573157;
				switch (num3 == num)
				{
				}
				num = (short)565903361;
				if (num != 0)
				{
				}
				num = (short)724566016;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Applicable = value;
			}
		}

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x0600BD08 RID: 48392 RVA: 0x00AEE608 File Offset: 0x00AEC808
		// (set) Token: 0x0600BD09 RID: 48393 RVA: 0x00AEE6BC File Offset: 0x00AEC8BC
		public bool CnvSysGeneralIndividualID_A8287_Valid
		{
			get
			{
				short num = (short)59441152;
				short num2 = num;
				num = (short)826475944;
				short num3 = num;
				num = (short)2137064872;
				switch (num3 == num)
				{
				}
				num = (short)1399062529;
				if (num != 0)
				{
				}
				num = (short)1644036096;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Valid;
			}
			set
			{
				short num = (short)509018112;
				short num2 = num;
				num = (short)2064696267;
				short num3 = num;
				num = (short)1349960651;
				switch (num3 == num)
				{
				}
				num = (short)1453981697;
				if (num != 0)
				{
				}
				num = (short)844562432;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Valid = value;
			}
		}

		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x0600BD0A RID: 48394 RVA: 0x00AEE770 File Offset: 0x00AEC970
		// (set) Token: 0x0600BD0B RID: 48395 RVA: 0x00AEE820 File Offset: 0x00AECA20
		public bool CnvSysGeneralIndividualID_A8287_Visible
		{
			get
			{
				short num = (short)1700659200;
				short num2 = num;
				num = (short)1986501330;
				short num3 = num;
				num = (short)1095604946;
				switch (num3 == num)
				{
				}
				num = (short)1304952833;
				if (num != 0)
				{
				}
				num = (short)2139095040;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Visible;
			}
			set
			{
				short num = (short)1542979584;
				short num2 = num;
				num = (short)2108244735;
				short num3 = num;
				num = (short)1771979519;
				switch (num3 == num)
				{
				}
				num = (short)1680998400;
				if (num != 0)
				{
				}
				num = (short)1480589313;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Visible = value;
			}
		}

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x0600BD0C RID: 48396 RVA: 0x00AEE8D4 File Offset: 0x00AECAD4
		// (set) Token: 0x0600BD0D RID: 48397 RVA: 0x00AEE988 File Offset: 0x00AECB88
		public bool CnvSysGeneralIndividualID_A8287_Editable
		{
			get
			{
				short num = (short)1301610496;
				short num2 = num;
				num = (short)2123208665;
				short num3 = num;
				num = (short)17012697;
				switch (num3 == num)
				{
				}
				num = (short)1457258496;
				if (num != 0)
				{
				}
				num = (short)944177153;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.Editable;
			}
			set
			{
				short num = (short)49610752;
				short num2 = num;
				num = (short)1567767551;
				short num3 = num;
				num = (short)942160895;
				switch (num3 == num)
				{
				}
				num = (short)1855782913;
				if (num != 0)
				{
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.Editable = value;
			}
		}

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x0600BD0E RID: 48398 RVA: 0x00AEEA40 File Offset: 0x00AECC40
		internal string CnvSysGeneralIndividualID_A8287_UILabel
		{
			get
			{
				short num = (short)2104688640;
				short num2 = num;
				num = (short)12086911;
				short num3 = num;
				num = (short)223112831;
				switch (num3 == num)
				{
				}
				num = (short)2136080385;
				if (num != 0)
				{
				}
				num = (short)683737088;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.UIName;
			}
		}

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x00AEEAF4 File Offset: 0x00AECCF4
		// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x00AEEBA8 File Offset: 0x00AECDA8
		internal bool CnvSysGeneralIndividualID_A8287_HiddenStatic
		{
			get
			{
				short num = (short)1021640704;
				short num2 = num;
				num = (short)2077267339;
				short num3 = num;
				num = (short)1806603659;
				switch (num3 == num)
				{
				}
				num = (short)1776353280;
				if (num != 0)
				{
				}
				num = (short)1231749121;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.HiddenStatic;
			}
			set
			{
				short num = (short)729415680;
				short num2 = num;
				num = (short)1649501295;
				short num3 = num;
				num = (short)1897292911;
				switch (num3 == num)
				{
				}
				num = (short)1468465153;
				if (num != 0)
				{
				}
				num = (short)1519255552;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.HiddenStatic = value;
			}
		}

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x0600BD11 RID: 48401 RVA: 0x00AEEC5C File Offset: 0x00AECE5C
		// (set) Token: 0x0600BD12 RID: 48402 RVA: 0x00AEED14 File Offset: 0x00AECF14
		internal bool CnvSysGeneralIndividualID_A8287_HiddenDynamic
		{
			get
			{
				short num = (short)132183547;
				short num2 = num;
				num = (short)301725179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021851136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356122624;
				if (num != 0)
				{
				}
				num = (short)942931969;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287.HiddenDynamic;
			}
			set
			{
				short num = (short)516882433;
				if (num != 0)
				{
				}
				num = (short)1477771264;
				short num2 = num;
				num = (short)419525901;
				short num3 = num;
				num = (short)418805005;
				switch (num3 == num)
				{
				}
				num = (short)2018705408;
				if (num != 0)
				{
				}
				this.cnvSysGeneralIndividualID_A8287.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x0600BD13 RID: 48403 RVA: 0x00AEEDCC File Offset: 0x00AECFCC
		public bool CnvSysGeneralIndividualID_A8287_HasDiffs
		{
			get
			{
				short num = (short)1014043391;
				short num2 = num;
				num = (short)1225855743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296026112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422131201;
				if (num != 0)
				{
				}
				num = (short)2058223616;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralIndividualID_A8287._HasDiffs;
			}
		}

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x0600BD14 RID: 48404 RVA: 0x00AEEE84 File Offset: 0x00AED084
		// (set) Token: 0x0600BD15 RID: 48405 RVA: 0x00AEEF38 File Offset: 0x00AED138
		public bool CnvSysGeneralSystemKeyPresent_A40120Value
		{
			get
			{
				short num = (short)2023669833;
				short num2 = num;
				num = (short)2007875657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422248448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)557776897;
				if (num != 0)
				{
				}
				num = (short)824377344;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Value;
			}
			set
			{
				short num = (short)585288799;
				short num2 = num;
				num = (short)1133562975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22806528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48562176;
				if (num != 0)
				{
				}
				num = (short)162594817;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Value = value;
			}
		}

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x0600BD16 RID: 48406 RVA: 0x00AEEFEC File Offset: 0x00AED1EC
		public global::AcpBusinessLayer.AcpField<bool> CnvSysGeneralSystemKeyPresent_A40120
		{
			get
			{
				short num = (short)299149117;
				short num2 = num;
				num = (short)1688381245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)827260928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1139736577;
				if (num != 0)
				{
				}
				num = (short)578158592;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120;
			}
		}

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x00AEF09C File Offset: 0x00AED29C
		// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x00AEF150 File Offset: 0x00AED350
		public bool CnvSysGeneralSystemKeyPresent_A40120_UIValue
		{
			get
			{
				short num = (short)318571940;
				short num2 = num;
				num = (short)2003502500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803550720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031550464;
				if (num != 0)
				{
				}
				num = (short)534315009;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Value;
			}
			set
			{
				short num = (short)153286663;
				short num2 = num;
				num = (short)1476130823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)903675904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630666752;
				if (num != 0)
				{
				}
				num = (short)1286471681;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Value = value;
			}
		}

		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x00AEF208 File Offset: 0x00AED408
		// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x00AEF2C0 File Offset: 0x00AED4C0
		public bool CnvSysGeneralSystemKeyPresent_A40120_Applicable
		{
			get
			{
				short num = (short)1020133377;
				if (num != 0)
				{
				}
				num = (short)1644691456;
				short num2 = num;
				num = (short)663467672;
				short num3 = num;
				num = (short)1804121752;
				switch (num3 == num)
				{
				}
				num = (short)450297856;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Applicable;
			}
			set
			{
				short num = (short)1902675472;
				short num2 = num;
				num = (short)23234064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882324992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229376001;
				if (num != 0)
				{
				}
				num = (short)1574305792;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Applicable = value;
			}
		}

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x0600BD1B RID: 48411 RVA: 0x00AEF37C File Offset: 0x00AED57C
		// (set) Token: 0x0600BD1C RID: 48412 RVA: 0x00AEF430 File Offset: 0x00AED630
		public bool CnvSysGeneralSystemKeyPresent_A40120_Valid
		{
			get
			{
				short num = (short)1799291424;
				short num2 = num;
				num = (short)1017774624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)190251008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032585217;
				if (num != 0)
				{
				}
				num = (short)1778384896;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Valid;
			}
			set
			{
				short num = (short)255918081;
				if (num != 0)
				{
				}
				num = (short)101711872;
				short num2 = num;
				num = (short)517000883;
				short num3 = num;
				num = (short)97701555;
				switch (num3 == num)
				{
				}
				num = (short)1741094912;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Valid = value;
			}
		}

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x00AEF4E8 File Offset: 0x00AED6E8
		// (set) Token: 0x0600BD1E RID: 48414 RVA: 0x00AEF59C File Offset: 0x00AED79C
		public bool CnvSysGeneralSystemKeyPresent_A40120_Visible
		{
			get
			{
				short num = (short)217290546;
				short num2 = num;
				num = (short)696555314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231866368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743243777;
				if (num != 0)
				{
				}
				num = (short)1031077888;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Visible;
			}
			set
			{
				short num = (short)922369728;
				short num2 = num;
				num = (short)1176321728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211484672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172490753;
				if (num != 0)
				{
				}
				num = (short)1873084416;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Visible = value;
			}
		}

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x00AEF650 File Offset: 0x00AED850
		// (set) Token: 0x0600BD20 RID: 48416 RVA: 0x00AEF708 File Offset: 0x00AED908
		public bool CnvSysGeneralSystemKeyPresent_A40120_Editable
		{
			get
			{
				short num = (short)1191512244;
				short num2 = num;
				num = (short)628492468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498663424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067070977;
				if (num != 0)
				{
				}
				num = (short)415170560;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.Editable;
			}
			set
			{
				short num = (short)634301005;
				short num2 = num;
				num = (short)1478535757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1676214272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097138177;
				if (num != 0)
				{
				}
				num = (short)941293568;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.Editable = value;
			}
		}

		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x0600BD21 RID: 48417 RVA: 0x00AEF7BC File Offset: 0x00AED9BC
		internal string CnvSysGeneralSystemKeyPresent_A40120_UILabel
		{
			get
			{
				short num = (short)962893277;
				short num2 = num;
				num = (short)1715181021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992411648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950285825;
				if (num != 0)
				{
				}
				num = (short)796327936;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.UIName;
			}
		}

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x0600BD22 RID: 48418 RVA: 0x00AEF870 File Offset: 0x00AEDA70
		// (set) Token: 0x0600BD23 RID: 48419 RVA: 0x00AEF924 File Offset: 0x00AEDB24
		internal bool CnvSysGeneralSystemKeyPresent_A40120_HiddenStatic
		{
			get
			{
				short num = (short)1473445889;
				if (num != 0)
				{
				}
				num = (short)455737344;
				short num2 = num;
				num = (short)1668239316;
				short num3 = num;
				num = (short)460214228;
				switch (num3 == num)
				{
				}
				num = (short)1991835648;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.HiddenStatic;
			}
			set
			{
				short num = (short)979859731;
				short num2 = num;
				num = (short)1555265811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667497984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654718464;
				if (num != 0)
				{
				}
				num = (short)1045823489;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.HiddenStatic = value;
			}
		}

		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x00AEF9DC File Offset: 0x00AEDBDC
		// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x00AEFA90 File Offset: 0x00AEDC90
		internal bool CnvSysGeneralSystemKeyPresent_A40120_HiddenDynamic
		{
			get
			{
				short num = (short)328794406;
				short num2 = num;
				num = (short)1767112998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957153280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048969217;
				if (num != 0)
				{
				}
				num = (short)1954545664;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120.HiddenDynamic;
			}
			set
			{
				short num = (short)1996898211;
				short num2 = num;
				num = (short)1712799651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109145088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085341696;
				if (num != 0)
				{
				}
				num = (short)2087780353;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemKeyPresent_A40120.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x00AEFB48 File Offset: 0x00AEDD48
		public bool CnvSysGeneralSystemKeyPresent_A40120_HasDiffs
		{
			get
			{
				short num = (short)1159632066;
				short num2 = num;
				num = (short)296850626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943535616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1138688000;
				if (num != 0)
				{
				}
				num = (short)1996619777;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemKeyPresent_A40120._HasDiffs;
			}
		}

		// Token: 0x17005EEA RID: 24298
		// (get) Token: 0x0600BD27 RID: 48423 RVA: 0x00AEFBFC File Offset: 0x00AEDDFC
		// (set) Token: 0x0600BD28 RID: 48424 RVA: 0x00AEFCB4 File Offset: 0x00AEDEB4
		public int CnvSysGeneralHomeWACNID_A40121Value
		{
			get
			{
				short num = (short)1382758705;
				short num2 = num;
				num = (short)813971761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1951399936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1456078849;
				if (num != 0)
				{
				}
				num = (short)667090944;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Value;
			}
			set
			{
				short num = (short)1175860840;
				short num2 = num;
				num = (short)1570387560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630784000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121189889;
				if (num != 0)
				{
				}
				num = (short)196149248;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Value = value;
			}
		}

		// Token: 0x17005EEB RID: 24299
		// (get) Token: 0x0600BD29 RID: 48425 RVA: 0x00AEFD68 File Offset: 0x00AEDF68
		public global::AcpBusinessLayer.AcpCustomRangeField CnvSysGeneralHomeWACNID_A40121
		{
			get
			{
				short num = (short)1789770297;
				short num2 = num;
				num = (short)1254668857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635647488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723976193;
				if (num != 0)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121;
			}
		}

		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x0600BD2A RID: 48426 RVA: 0x00AEFE18 File Offset: 0x00AEE018
		// (set) Token: 0x0600BD2B RID: 48427 RVA: 0x00AEFECC File Offset: 0x00AEE0CC
		public string CnvSysGeneralHomeWACNID_A40121_UIValue
		{
			get
			{
				short num = (short)1006632961;
				if (num != 0)
				{
				}
				num = (short)393084928;
				short num2 = num;
				num = (short)1639726863;
				short num3 = num;
				num = (short)1872903951;
				switch (num3 == num)
				{
				}
				num = (short)732102656;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.UIValue;
			}
			set
			{
				short num = (short)44367873;
				if (num != 0)
				{
				}
				num = (short)1527316480;
				short num2 = num;
				num = (short)794439802;
				short num3 = num;
				num = (short)1193291898;
				switch (num3 == num)
				{
				}
				num = (short)1270611968;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.UIValue = value;
			}
		}

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x0600BD2C RID: 48428 RVA: 0x00AEFF84 File Offset: 0x00AEE184
		// (set) Token: 0x0600BD2D RID: 48429 RVA: 0x00AF0038 File Offset: 0x00AEE238
		public string CnvSysGeneralHomeWACNID_A40121_HexUIValue
		{
			get
			{
				short num = (short)1365760264;
				short num2 = num;
				num = (short)1379850504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105278464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755774976;
				if (num != 0)
				{
				}
				num = (short)1990000641;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.HexUIValue;
			}
			set
			{
				short num = (short)1347017618;
				short num2 = num;
				num = (short)688184210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1711013888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913585664;
				if (num != 0)
				{
				}
				num = (short)1576599553;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.HexUIValue = value;
			}
		}

		// Token: 0x17005EEE RID: 24302
		// (get) Token: 0x0600BD2E RID: 48430 RVA: 0x00AF00F0 File Offset: 0x00AEE2F0
		// (set) Token: 0x0600BD2F RID: 48431 RVA: 0x00AF01A8 File Offset: 0x00AEE3A8
		internal int CnvSysGeneralHomeWACNID_A40121Min
		{
			get
			{
				short num = (short)2087813237;
				short num2 = num;
				num = (short)1929543797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1065746432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204406785;
				if (num != 0)
				{
				}
				num = (short)1455751168;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Min;
			}
			set
			{
				short num = (short)1842020353;
				if (num != 0)
				{
				}
				num = (short)971767808;
				short num2 = num;
				num = (short)1234731070;
				short num3 = num;
				num = (short)1790476350;
				switch (num3 == num)
				{
				}
				num = (short)1463156736;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Min = value;
			}
		}

		// Token: 0x17005EEF RID: 24303
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x00AF0260 File Offset: 0x00AEE460
		// (set) Token: 0x0600BD31 RID: 48433 RVA: 0x00AF0314 File Offset: 0x00AEE514
		internal int CnvSysGeneralHomeWACNID_A40121Max
		{
			get
			{
				short num = (short)1937554616;
				short num2 = num;
				num = (short)1959443640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)230293504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368850433;
				if (num != 0)
				{
				}
				num = (short)1872953344;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Max;
			}
			set
			{
				short num = (short)187367155;
				short num2 = num;
				num = (short)1898381043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32374784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563885569;
				if (num != 0)
				{
				}
				num = (short)1788084224;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Max = value;
			}
		}

		// Token: 0x17005EF0 RID: 24304
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x00AF03CC File Offset: 0x00AEE5CC
		// (set) Token: 0x0600BD33 RID: 48435 RVA: 0x00AF0480 File Offset: 0x00AEE680
		internal int CnvSysGeneralHomeWACNID_A40121Step
		{
			get
			{
				short num = (short)1306918913;
				if (num != 0)
				{
				}
				num = (short)1905328128;
				short num2 = num;
				num = (short)504367043;
				short num3 = num;
				num = (short)371263427;
				switch (num3 == num)
				{
				}
				num = (short)768016384;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.StepSize;
			}
			set
			{
				short num = (short)1576275489;
				short num2 = num;
				num = (short)1134235169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1937440768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1640955905;
				if (num != 0)
				{
				}
				num = (short)1171914752;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.StepSize = value;
			}
		}

		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x00AF0534 File Offset: 0x00AEE734
		// (set) Token: 0x0600BD35 RID: 48437 RVA: 0x00AF05E8 File Offset: 0x00AEE7E8
		public bool CnvSysGeneralHomeWACNID_A40121_Applicable
		{
			get
			{
				short num = (short)956589187;
				short num2 = num;
				num = (short)1427072131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026031616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1640169472;
				if (num != 0)
				{
				}
				num = (short)1072365569;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Applicable;
			}
			set
			{
				short num = (short)1242198537;
				short num2 = num;
				num = (short)1793290761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872480768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				num = (short)1238499329;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Applicable = value;
			}
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x00AF069C File Offset: 0x00AEE89C
		// (set) Token: 0x0600BD37 RID: 48439 RVA: 0x00AF0754 File Offset: 0x00AEE954
		public bool CnvSysGeneralHomeWACNID_A40121_Valid
		{
			get
			{
				short num = (short)1487589965;
				short num2 = num;
				num = (short)633066061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464729600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598685185;
				if (num != 0)
				{
				}
				num = (short)1364066304;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Valid;
			}
			set
			{
				short num = (short)1156120577;
				if (num != 0)
				{
				}
				num = (short)1011286016;
				short num2 = num;
				num = (short)249077815;
				short num3 = num;
				num = (short)969449527;
				switch (num3 == num)
				{
				}
				num = (short)1101987840;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Valid = value;
			}
		}

		// Token: 0x17005EF3 RID: 24307
		// (get) Token: 0x0600BD38 RID: 48440 RVA: 0x00AF080C File Offset: 0x00AEEA0C
		// (set) Token: 0x0600BD39 RID: 48441 RVA: 0x00AF08C0 File Offset: 0x00AEEAC0
		public bool CnvSysGeneralHomeWACNID_A40121_Visible
		{
			get
			{
				short num = (short)509706353;
				short num2 = num;
				num = (short)1923973233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145569280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1230766080;
				if (num != 0)
				{
				}
				num = (short)603324417;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Visible;
			}
			set
			{
				short num = (short)1285488640;
				short num2 = num;
				num = (short)1979597314;
				short num3 = num;
				num = (short)1754546690;
				switch (num3 == num)
				{
				}
				num = (short)494010369;
				if (num != 0)
				{
				}
				num = (short)2007498752;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Visible = value;
			}
		}

		// Token: 0x17005EF4 RID: 24308
		// (get) Token: 0x0600BD3A RID: 48442 RVA: 0x00AF0978 File Offset: 0x00AEEB78
		// (set) Token: 0x0600BD3B RID: 48443 RVA: 0x00AF0A2C File Offset: 0x00AEEC2C
		public bool CnvSysGeneralHomeWACNID_A40121_Editable
		{
			get
			{
				short num = (short)1270808576;
				short num2 = num;
				num = (short)1513427878;
				short num3 = num;
				num = (short)1967002534;
				switch (num3 == num)
				{
				}
				num = (short)1360265216;
				if (num != 0)
				{
				}
				num = (short)813039617;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.Editable;
			}
			set
			{
				short num = (short)1566441472;
				short num2 = num;
				num = (short)813615049;
				short num3 = num;
				num = (short)1420412873;
				switch (num3 == num)
				{
				}
				num = (short)1948450816;
				if (num != 0)
				{
				}
				num = (short)1504706561;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.Editable = value;
			}
		}

		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x0600BD3C RID: 48444 RVA: 0x00AF0AE0 File Offset: 0x00AEECE0
		internal string CnvSysGeneralHomeWACNID_A40121_UILabel
		{
			get
			{
				short num = (short)1957036032;
				short num2 = num;
				num = (short)121566559;
				short num3 = num;
				num = (short)1829762399;
				switch (num3 == num)
				{
				}
				num = (short)2094596097;
				if (num != 0)
				{
				}
				num = (short)756613120;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.UIName;
			}
		}

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x0600BD3D RID: 48445 RVA: 0x00AF0B94 File Offset: 0x00AEED94
		// (set) Token: 0x0600BD3E RID: 48446 RVA: 0x00AF0C4C File Offset: 0x00AEEE4C
		internal bool CnvSysGeneralHomeWACNID_A40121_HiddenStatic
		{
			get
			{
				short num = (short)275709952;
				short num2 = num;
				num = (short)2028779643;
				short num3 = num;
				num = (short)739293307;
				switch (num3 == num)
				{
				}
				num = (short)603062273;
				if (num != 0)
				{
				}
				num = (short)1923022848;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.HiddenStatic;
			}
			set
			{
				short num = (short)496107520;
				short num2 = num;
				num = (short)1985775089;
				short num3 = num;
				num = (short)2034140657;
				switch (num3 == num)
				{
				}
				num = (short)523042817;
				if (num != 0)
				{
				}
				num = (short)1514274816;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.HiddenStatic = value;
			}
		}

		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x0600BD3F RID: 48447 RVA: 0x00AF0D08 File Offset: 0x00AEEF08
		// (set) Token: 0x0600BD40 RID: 48448 RVA: 0x00AF0DBC File Offset: 0x00AEEFBC
		internal bool CnvSysGeneralHomeWACNID_A40121_HiddenDynamic
		{
			get
			{
				short num = (short)276758528;
				short num2 = num;
				num = (short)1012887158;
				short num3 = num;
				num = (short)1063808630;
				switch (num3 == num)
				{
				}
				num = (short)107610113;
				if (num != 0)
				{
				}
				num = (short)683999232;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121.HiddenDynamic;
			}
			set
			{
				short num = (short)1038942208;
				short num2 = num;
				num = (short)1750007809;
				if (num != 0)
				{
				}
				num = (short)534873354;
				short num3 = num;
				num = (short)949454090;
				switch (num3 == num)
				{
				}
				num = (short)410583040;
				if (num != 0)
				{
				}
				this.cnvSysGeneralHomeWACNID_A40121.HiddenDynamic = value;
			}
		}

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x0600BD41 RID: 48449 RVA: 0x00AF0E70 File Offset: 0x00AEF070
		public bool CnvSysGeneralHomeWACNID_A40121_HasDiffs
		{
			get
			{
				short num = (short)2127691776;
				short num2 = num;
				num = (short)170627613;
				short num3 = num;
				num = (short)1383895581;
				switch (num3 == num)
				{
				}
				num = (short)1405616129;
				if (num != 0)
				{
				}
				num = (short)662110208;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralHomeWACNID_A40121._HasDiffs;
			}
		}

		// Token: 0x17005EF9 RID: 24313
		// (get) Token: 0x0600BD42 RID: 48450 RVA: 0x00AF0F24 File Offset: 0x00AEF124
		// (set) Token: 0x0600BD43 RID: 48451 RVA: 0x00AF0FD8 File Offset: 0x00AEF1D8
		public int CnvSysGeneralSystemID_A40122Value
		{
			get
			{
				short num = (short)1074003968;
				short num2 = num;
				num = (short)1551014066;
				short num3 = num;
				num = (short)1591318706;
				switch (num3 == num)
				{
				}
				num = (short)365166593;
				if (num != 0)
				{
				}
				num = (short)2100887552;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Value;
			}
			set
			{
				short num = (short)680853504;
				short num2 = num;
				num = (short)2086732284;
				short num3 = num;
				num = (short)1306198524;
				switch (num3 == num)
				{
				}
				num = (short)241500161;
				if (num != 0)
				{
				}
				num = (short)1365049344;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Value = value;
			}
		}

		// Token: 0x17005EFA RID: 24314
		// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x00AF1090 File Offset: 0x00AEF290
		public global::AcpBusinessLayer.AcpCustomRangeField CnvSysGeneralSystemID_A40122
		{
			get
			{
				short num = (short)1011941376;
				short num2 = num;
				num = (short)518646827;
				short num3 = num;
				num = (short)1015540779;
				switch (num3 == num)
				{
				}
				num = (short)940179457;
				if (num != 0)
				{
				}
				num = (short)1987313664;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122;
			}
		}

		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x0600BD45 RID: 48453 RVA: 0x00AF1140 File Offset: 0x00AEF340
		// (set) Token: 0x0600BD46 RID: 48454 RVA: 0x00AF11F4 File Offset: 0x00AEF3F4
		public string CnvSysGeneralSystemID_A40122_UIValue
		{
			get
			{
				short num = (short)1846804480;
				short num2 = num;
				num = (short)563017068;
				short num3 = num;
				num = (short)1873016172;
				switch (num3 == num)
				{
				}
				num = (short)1039400961;
				if (num != 0)
				{
				}
				num = (short)1497890816;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.UIValue;
			}
			set
			{
				short num = (short)2090205184;
				short num2 = num;
				num = (short)1379636325;
				short num3 = num;
				num = (short)385389669;
				switch (num3 == num)
				{
				}
				num = (short)776142849;
				if (num != 0)
				{
				}
				num = (short)1385431040;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.UIValue = value;
			}
		}

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0600BD47 RID: 48455 RVA: 0x00AF12A8 File Offset: 0x00AEF4A8
		// (set) Token: 0x0600BD48 RID: 48456 RVA: 0x00AF135C File Offset: 0x00AEF55C
		public string CnvSysGeneralSystemID_A40122_HexUIValue
		{
			get
			{
				short num = (short)1968439296;
				short num2 = num;
				num = (short)13968588;
				short num3 = num;
				num = (short)1600005324;
				switch (num3 == num)
				{
				}
				num = (short)1843200000;
				if (num != 0)
				{
				}
				num = (short)1226506241;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.HexUIValue;
			}
			set
			{
				short num = (short)772210688;
				short num2 = num;
				num = (short)1052835841;
				if (num != 0)
				{
				}
				num = (short)2005033272;
				short num3 = num;
				num = (short)892821816;
				switch (num3 == num)
				{
				}
				num = (short)2124611584;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.HexUIValue = value;
			}
		}

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x0600BD49 RID: 48457 RVA: 0x00AF1410 File Offset: 0x00AEF610
		// (set) Token: 0x0600BD4A RID: 48458 RVA: 0x00AF14C8 File Offset: 0x00AEF6C8
		internal int CnvSysGeneralSystemID_A40122Min
		{
			get
			{
				short num = (short)30277632;
				short num2 = num;
				num = (short)1118845916;
				short num3 = num;
				num = (short)779959260;
				switch (num3 == num)
				{
				}
				num = (short)231669761;
				if (num != 0)
				{
				}
				num = (short)583467008;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Min;
			}
			set
			{
				short num = (short)1750728704;
				short num2 = num;
				num = (short)1568201879;
				short num3 = num;
				num = (short)1669061783;
				switch (num3 == num)
				{
				}
				num = (short)65339392;
				if (num != 0)
				{
				}
				num = (short)997982209;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Min = value;
			}
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x0600BD4B RID: 48459 RVA: 0x00AF1580 File Offset: 0x00AEF780
		// (set) Token: 0x0600BD4C RID: 48460 RVA: 0x00AF1634 File Offset: 0x00AEF834
		internal int CnvSysGeneralSystemID_A40122Max
		{
			get
			{
				short num = (short)1197998080;
				short num2 = num;
				num = (short)1742013968;
				short num3 = num;
				num = (short)504038928;
				switch (num3 == num)
				{
				}
				num = (short)622592001;
				if (num != 0)
				{
				}
				num = (short)1615462400;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Max;
			}
			set
			{
				short num = (short)359792640;
				short num2 = num;
				num = (short)737971535;
				short num3 = num;
				num = (short)1398639951;
				switch (num3 == num)
				{
				}
				num = (short)1963786240;
				if (num != 0)
				{
				}
				num = (short)562036737;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Max = value;
			}
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x0600BD4D RID: 48461 RVA: 0x00AF16EC File Offset: 0x00AEF8EC
		// (set) Token: 0x0600BD4E RID: 48462 RVA: 0x00AF17A0 File Offset: 0x00AEF9A0
		internal int CnvSysGeneralSystemID_A40122Step
		{
			get
			{
				short num = (short)156565504;
				short num2 = num;
				num = (short)2142467779;
				short num3 = num;
				num = (short)1738110659;
				switch (num3 == num)
				{
				}
				num = (short)1726152705;
				if (num != 0)
				{
				}
				num = (short)2063990784;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.StepSize;
			}
			set
			{
				short num = (short)1243414528;
				short num2 = num;
				num = (short)200158364;
				short num3 = num;
				num = (short)1272589468;
				switch (num3 == num)
				{
				}
				num = (short)1406009345;
				if (num != 0)
				{
				}
				num = (short)1967980544;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.StepSize = value;
			}
		}

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x0600BD4F RID: 48463 RVA: 0x00AF1854 File Offset: 0x00AEFA54
		// (set) Token: 0x0600BD50 RID: 48464 RVA: 0x00AF1908 File Offset: 0x00AEFB08
		public bool CnvSysGeneralSystemID_A40122_Applicable
		{
			get
			{
				short num = (short)124977152;
				short num2 = num;
				num = (short)429464693;
				short num3 = num;
				num = (short)326179957;
				switch (num3 == num)
				{
				}
				num = (short)306839553;
				if (num != 0)
				{
				}
				num = (short)714014720;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Applicable;
			}
			set
			{
				short num = (short)1890385920;
				short num2 = num;
				num = (short)1867200034;
				short num3 = num;
				num = (short)1528706594;
				switch (num3 == num)
				{
				}
				num = (short)874577920;
				if (num != 0)
				{
				}
				num = (short)495779841;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Applicable = value;
			}
		}

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x0600BD51 RID: 48465 RVA: 0x00AF19BC File Offset: 0x00AEFBBC
		// (set) Token: 0x0600BD52 RID: 48466 RVA: 0x00AF1A70 File Offset: 0x00AEFC70
		public bool CnvSysGeneralSystemID_A40122_Valid
		{
			get
			{
				short num = (short)1133838336;
				short num2 = num;
				num = (short)1199506898;
				short num3 = num;
				num = (short)1120273874;
				switch (num3 == num)
				{
				}
				num = (short)1830289409;
				if (num != 0)
				{
				}
				num = (short)856424448;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Valid;
			}
			set
			{
				short num = (short)1590034432;
				short num2 = num;
				num = (short)1130251623;
				short num3 = num;
				num = (short)631457127;
				switch (num3 == num)
				{
				}
				num = (short)1124204545;
				if (num != 0)
				{
				}
				num = (short)1159004160;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Valid = value;
			}
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x0600BD53 RID: 48467 RVA: 0x00AF1B28 File Offset: 0x00AEFD28
		// (set) Token: 0x0600BD54 RID: 48468 RVA: 0x00AF1BDC File Offset: 0x00AEFDDC
		public bool CnvSysGeneralSystemID_A40122_Visible
		{
			get
			{
				short num = (short)1653080064;
				short num2 = num;
				num = (short)1958989759;
				short num3 = num;
				num = (short)1869270975;
				switch (num3 == num)
				{
				}
				num = (short)54329344;
				if (num != 0)
				{
				}
				num = (short)1653342209;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Visible;
			}
			set
			{
				short num = (short)1597636608;
				short num2 = num;
				num = (short)133271406;
				short num3 = num;
				num = (short)1396805486;
				switch (num3 == num)
				{
				}
				num = (short)542375937;
				if (num != 0)
				{
				}
				num = (short)1218052096;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Visible = value;
			}
		}

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x0600BD55 RID: 48469 RVA: 0x00AF1C90 File Offset: 0x00AEFE90
		// (set) Token: 0x0600BD56 RID: 48470 RVA: 0x00AF1D48 File Offset: 0x00AEFF48
		public bool CnvSysGeneralSystemID_A40122_Editable
		{
			get
			{
				short num = (short)556793856;
				short num2 = num;
				num = (short)1909587969;
				if (num != 0)
				{
				}
				num = (short)854470815;
				short num3 = num;
				num = (short)840315039;
				switch (num3 == num)
				{
				}
				num = (short)443023360;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.Editable;
			}
			set
			{
				short num = (short)948699136;
				short num2 = num;
				num = (short)348628017;
				short num3 = num;
				num = (short)1123394609;
				switch (num3 == num)
				{
				}
				num = (short)276037633;
				if (num != 0)
				{
				}
				num = (short)548012032;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.Editable = value;
			}
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x0600BD57 RID: 48471 RVA: 0x00AF1E00 File Offset: 0x00AF0000
		internal string CnvSysGeneralSystemID_A40122_UILabel
		{
			get
			{
				short num = (short)224985088;
				short num2 = num;
				num = (short)1735997507;
				short num3 = num;
				num = (short)322385987;
				switch (num3 == num)
				{
				}
				num = (short)1999503360;
				if (num != 0)
				{
				}
				num = (short)2114322433;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.UIName;
			}
		}

		// Token: 0x17005F05 RID: 24325
		// (get) Token: 0x0600BD58 RID: 48472 RVA: 0x00AF1EB8 File Offset: 0x00AF00B8
		// (set) Token: 0x0600BD59 RID: 48473 RVA: 0x00AF1F6C File Offset: 0x00AF016C
		internal bool CnvSysGeneralSystemID_A40122_HiddenStatic
		{
			get
			{
				short num = (short)587923456;
				short num2 = num;
				num = (short)425328641;
				if (num != 0)
				{
				}
				num = (short)1774830480;
				short num3 = num;
				num = (short)2086781840;
				switch (num3 == num)
				{
				}
				num = (short)1068367872;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.HiddenStatic;
			}
			set
			{
				short num = (short)369754112;
				short num2 = num;
				num = (short)528265116;
				short num3 = num;
				num = (short)942321564;
				switch (num3 == num)
				{
				}
				num = (short)1892679680;
				if (num != 0)
				{
				}
				num = (short)1623392257;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.HiddenStatic = value;
			}
		}

		// Token: 0x17005F06 RID: 24326
		// (get) Token: 0x0600BD5A RID: 48474 RVA: 0x00AF2020 File Offset: 0x00AF0220
		// (set) Token: 0x0600BD5B RID: 48475 RVA: 0x00AF20D8 File Offset: 0x00AF02D8
		internal bool CnvSysGeneralSystemID_A40122_HiddenDynamic
		{
			get
			{
				short num = (short)1434714112;
				short num2 = num;
				num = (short)437975201;
				short num3 = num;
				num = (short)149878945;
				switch (num3 == num)
				{
				}
				num = (short)259653633;
				if (num != 0)
				{
				}
				num = (short)598081536;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122.HiddenDynamic;
			}
			set
			{
				short num = (short)116850688;
				short num2 = num;
				num = (short)882229027;
				short num3 = num;
				num = (short)1957478179;
				switch (num3 == num)
				{
				}
				num = (short)108462081;
				if (num != 0)
				{
				}
				num = (short)206831616;
				if (num != 0)
				{
				}
				this.cnvSysGeneralSystemID_A40122.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x00AF218C File Offset: 0x00AF038C
		public bool CnvSysGeneralSystemID_A40122_HasDiffs
		{
			get
			{
				short num = (short)337641472;
				short num2 = num;
				num = (short)1543515133;
				short num3 = num;
				num = (short)954280957;
				switch (num3 == num)
				{
				}
				num = (short)25427968;
				if (num != 0)
				{
				}
				num = (short)1237123073;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralSystemID_A40122._HasDiffs;
			}
		}

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x0600BD5D RID: 48477 RVA: 0x00AF2240 File Offset: 0x00AF0440
		// (set) Token: 0x0600BD5E RID: 48478 RVA: 0x00AF22F4 File Offset: 0x00AF04F4
		public bool CnvSysGeneralAdditionalMDCPID_A41761Value
		{
			get
			{
				short num = (short)935002112;
				short num2 = num;
				num = (short)546897921;
				if (num != 0)
				{
				}
				num = (short)1824902392;
				short num3 = num;
				num = (short)1217973496;
				switch (num3 == num)
				{
				}
				num = (short)301203456;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Value;
			}
			set
			{
				short num = (short)1444610048;
				short num2 = num;
				num = (short)215237585;
				short num3 = num;
				num = (short)1621705681;
				switch (num3 == num)
				{
				}
				num = (short)313982977;
				if (num != 0)
				{
				}
				num = (short)1559166976;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Value = value;
			}
		}

		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x0600BD5F RID: 48479 RVA: 0x00AF23A8 File Offset: 0x00AF05A8
		public global::AcpBusinessLayer.AcpField<bool> CnvSysGeneralAdditionalMDCPID_A41761
		{
			get
			{
				short num = (short)1279590400;
				short num2 = num;
				num = (short)642842625;
				if (num != 0)
				{
				}
				num = (short)1994227180;
				short num3 = num;
				num = (short)258637292;
				switch (num3 == num)
				{
				}
				num = (short)1930362880;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761;
			}
		}

		// Token: 0x17005F0A RID: 24330
		// (get) Token: 0x0600BD60 RID: 48480 RVA: 0x00AF2458 File Offset: 0x00AF0658
		// (set) Token: 0x0600BD61 RID: 48481 RVA: 0x00AF2508 File Offset: 0x00AF0708
		public bool CnvSysGeneralAdditionalMDCPID_A41761_UIValue
		{
			get
			{
				short num = (short)190709760;
				short num2 = num;
				num = (short)1927296072;
				short num3 = num;
				num = (short)1526805576;
				switch (num3 == num)
				{
				}
				num = (short)1739456513;
				if (num != 0)
				{
				}
				num = (short)798949376;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Value;
			}
			set
			{
				short num = (short)827850752;
				short num2 = num;
				num = (short)686936216;
				short num3 = num;
				num = (short)1370935448;
				switch (num3 == num)
				{
				}
				num = (short)1605763072;
				if (num != 0)
				{
				}
				num = (short)73138177;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Value = value;
			}
		}

		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x00AF25BC File Offset: 0x00AF07BC
		// (set) Token: 0x0600BD63 RID: 48483 RVA: 0x00AF2670 File Offset: 0x00AF0870
		public bool CnvSysGeneralAdditionalMDCPID_A41761_Applicable
		{
			get
			{
				short num = (short)51773440;
				short num2 = num;
				num = (short)866779137;
				if (num != 0)
				{
				}
				num = (short)726707055;
				short num3 = num;
				num = (short)1665117039;
				switch (num3 == num)
				{
				}
				num = (short)1694695424;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Applicable;
			}
			set
			{
				short num = (short)1224343552;
				short num2 = num;
				num = (short)981026539;
				short num3 = num;
				num = (short)1863665387;
				switch (num3 == num)
				{
				}
				num = (short)1115422721;
				if (num != 0)
				{
				}
				num = (short)131268608;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Applicable = value;
			}
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x00AF2724 File Offset: 0x00AF0924
		// (set) Token: 0x0600BD65 RID: 48485 RVA: 0x00AF27D8 File Offset: 0x00AF09D8
		public bool CnvSysGeneralAdditionalMDCPID_A41761_Valid
		{
			get
			{
				short num = (short)1474363392;
				short num2 = num;
				num = (short)567296735;
				short num3 = num;
				num = (short)1879458527;
				switch (num3 == num)
				{
				}
				num = (short)1325531137;
				if (num != 0)
				{
				}
				num = (short)1215365120;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Valid;
			}
			set
			{
				short num = (short)47120384;
				short num2 = num;
				num = (short)1415708673;
				if (num != 0)
				{
				}
				num = (short)1053130360;
				short num3 = num;
				num = (short)199196280;
				switch (num3 == num)
				{
				}
				num = (short)1393360896;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Valid = value;
			}
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x0600BD66 RID: 48486 RVA: 0x00AF288C File Offset: 0x00AF0A8C
		// (set) Token: 0x0600BD67 RID: 48487 RVA: 0x00AF2944 File Offset: 0x00AF0B44
		public bool CnvSysGeneralAdditionalMDCPID_A41761_Visible
		{
			get
			{
				short num = (short)1870200832;
				short num2 = num;
				num = (short)1861391378;
				short num3 = num;
				num = (short)601592850;
				switch (num3 == num)
				{
				}
				num = (short)1500577792;
				if (num != 0)
				{
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Visible;
			}
			set
			{
				short num = (short)1997471744;
				short num2 = num;
				num = (short)1625016140;
				short num3 = num;
				num = (short)377931596;
				switch (num3 == num)
				{
				}
				num = (short)1175781377;
				if (num != 0)
				{
				}
				num = (short)358875136;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Visible = value;
			}
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x00AF29F8 File Offset: 0x00AF0BF8
		// (set) Token: 0x0600BD69 RID: 48489 RVA: 0x00AF2AB0 File Offset: 0x00AF0CB0
		public bool CnvSysGeneralAdditionalMDCPID_A41761_Editable
		{
			get
			{
				short num = (short)1887764480;
				short num2 = num;
				num = (short)982515713;
				if (num != 0)
				{
				}
				num = (short)1702128270;
				short num3 = num;
				num = (short)542468750;
				switch (num3 == num)
				{
				}
				num = (short)1853161472;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.Editable;
			}
			set
			{
				short num = (short)221118464;
				short num2 = num;
				num = (short)1885463287;
				short num3 = num;
				num = (short)941875959;
				switch (num3 == num)
				{
				}
				num = (short)189661185;
				if (num != 0)
				{
				}
				num = (short)1412366336;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.Editable = value;
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x00AF2B64 File Offset: 0x00AF0D64
		internal string CnvSysGeneralAdditionalMDCPID_A41761_UILabel
		{
			get
			{
				short num = (short)2076508160;
				short num2 = num;
				num = (short)2095382529;
				if (num != 0)
				{
				}
				num = (short)429829352;
				short num3 = num;
				num = (short)1817226472;
				switch (num3 == num)
				{
				}
				num = (short)501743616;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.UIName;
			}
		}

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x00AF2C18 File Offset: 0x00AF0E18
		// (set) Token: 0x0600BD6C RID: 48492 RVA: 0x00AF2CCC File Offset: 0x00AF0ECC
		internal bool CnvSysGeneralAdditionalMDCPID_A41761_HiddenStatic
		{
			get
			{
				short num = (short)122683392;
				short num2 = num;
				num = (short)1679632550;
				short num3 = num;
				num = (short)657926310;
				switch (num3 == num)
				{
				}
				num = (short)678166529;
				if (num != 0)
				{
				}
				num = (short)1425211392;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.HiddenStatic;
			}
			set
			{
				short num = (short)674496512;
				short num2 = num;
				num = (short)82154866;
				short num3 = num;
				num = (short)1337693554;
				switch (num3 == num)
				{
				}
				num = (short)1227423744;
				if (num != 0)
				{
				}
				num = (short)164757505;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.HiddenStatic = value;
			}
		}

		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x0600BD6D RID: 48493 RVA: 0x00AF2D7C File Offset: 0x00AF0F7C
		// (set) Token: 0x0600BD6E RID: 48494 RVA: 0x00AF2E30 File Offset: 0x00AF1030
		internal bool CnvSysGeneralAdditionalMDCPID_A41761_HiddenDynamic
		{
			get
			{
				short num = (short)1713176576;
				short num2 = num;
				num = (short)2542652;
				short num3 = num;
				num = (short)1906101308;
				switch (num3 == num)
				{
				}
				num = (short)268828672;
				if (num != 0)
				{
				}
				num = (short)2135031809;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761.HiddenDynamic;
			}
			set
			{
				short num = (short)863113959;
				short num2 = num;
				num = (short)2097025767;
				switch (num2 == num)
				{
				}
				num = (short)445972480;
				short num3 = num;
				num = (short)498270209;
				if (num != 0)
				{
				}
				num = (short)1642070016;
				if (num != 0)
				{
				}
				this.cnvSysGeneralAdditionalMDCPID_A41761.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x00AF2EE8 File Offset: 0x00AF10E8
		public bool CnvSysGeneralAdditionalMDCPID_A41761_HasDiffs
		{
			get
			{
				short num = (short)1449331118;
				short num2 = num;
				num = (short)1127090606;
				switch (num2 == num)
				{
				}
				num = (short)975568896;
				short num3 = num;
				num = (short)555745281;
				if (num != 0)
				{
				}
				num = (short)1750073344;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralAdditionalMDCPID_A41761._HasDiffs;
			}
		}

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x00AF2F9C File Offset: 0x00AF119C
		// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x00AF3050 File Offset: 0x00AF1250
		public bool ConvConfigConvSystemFeatRSISys_A41838Value
		{
			get
			{
				short num = (short)2233702;
				short num2 = num;
				num = (short)1893995878;
				switch (num2 == num)
				{
				}
				num = (short)877723648;
				short num3 = num;
				num = (short)1614479361;
				if (num != 0)
				{
				}
				num = (short)1099038720;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Value;
			}
			set
			{
				short num = (short)932968241;
				short num2 = num;
				num = (short)997062449;
				switch (num2 == num)
				{
				}
				num = (short)2002190336;
				short num3 = num;
				num = (short)1280573441;
				if (num != 0)
				{
				}
				num = (short)2008154112;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Value = value;
			}
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x00AF3104 File Offset: 0x00AF1304
		public global::AcpBusinessLayer.AcpField<bool> ConvConfigConvSystemFeatRSISys_A41838
		{
			get
			{
				short num = (short)1032454145;
				if (num != 0)
				{
				}
				num = (short)1807520167;
				short num2 = num;
				num = (short)7704999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)560660480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729088000;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838;
			}
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x0600BD73 RID: 48499 RVA: 0x00AF31B4 File Offset: 0x00AF13B4
		// (set) Token: 0x0600BD74 RID: 48500 RVA: 0x00AF3268 File Offset: 0x00AF1468
		public bool ConvConfigConvSystemFeatRSISys_A41838_UIValue
		{
			get
			{
				short num = (short)1035267980;
				short num2 = num;
				num = (short)1475342220;
				switch (num2 == num)
				{
				}
				num = (short)1059454976;
				short num3 = num;
				num = (short)912392193;
				if (num != 0)
				{
				}
				num = (short)2136866816;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Value;
			}
			set
			{
				short num = (short)1313829652;
				short num2 = num;
				num = (short)1860072212;
				switch (num2 == num)
				{
				}
				num = (short)347144192;
				short num3 = num;
				num = (short)498728961;
				if (num != 0)
				{
				}
				num = (short)1252458496;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Value = value;
			}
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x0600BD75 RID: 48501 RVA: 0x00AF331C File Offset: 0x00AF151C
		// (set) Token: 0x0600BD76 RID: 48502 RVA: 0x00AF33CC File Offset: 0x00AF15CC
		public bool ConvConfigConvSystemFeatRSISys_A41838_Applicable
		{
			get
			{
				short num = (short)479770161;
				short num2 = num;
				num = (short)652129841;
				switch (num2 == num)
				{
				}
				num = (short)55181312;
				short num3 = num;
				num = (short)443613185;
				if (num != 0)
				{
				}
				num = (short)508100608;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Applicable;
			}
			set
			{
				short num = (short)1705500424;
				short num2 = num;
				num = (short)304078600;
				switch (num2 == num)
				{
				}
				num = (short)1458044928;
				short num3 = num;
				num = (short)1643053056;
				if (num != 0)
				{
				}
				num = (short)503382017;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Applicable = value;
			}
		}

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x0600BD77 RID: 48503 RVA: 0x00AF3488 File Offset: 0x00AF1688
		// (set) Token: 0x0600BD78 RID: 48504 RVA: 0x00AF353C File Offset: 0x00AF173C
		public bool ConvConfigConvSystemFeatRSISys_A41838_Valid
		{
			get
			{
				short num = (short)489051243;
				short num2 = num;
				num = (short)1348097131;
				switch (num2 == num)
				{
				}
				num = (short)1166213120;
				short num3 = num;
				num = (short)186515456;
				if (num != 0)
				{
				}
				num = (short)1376518145;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Valid;
			}
			set
			{
				short num = (short)643493355;
				short num2 = num;
				num = (short)2089545195;
				switch (num2 == num)
				{
				}
				num = (short)411172864;
				short num3 = num;
				num = (short)1353056256;
				if (num != 0)
				{
				}
				num = (short)1763508225;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Valid = value;
			}
		}

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x0600BD79 RID: 48505 RVA: 0x00AF35F0 File Offset: 0x00AF17F0
		// (set) Token: 0x0600BD7A RID: 48506 RVA: 0x00AF36A4 File Offset: 0x00AF18A4
		public bool ConvConfigConvSystemFeatRSISys_A41838_Visible
		{
			get
			{
				short num = (short)87318639;
				short num2 = num;
				num = (short)880697455;
				switch (num2 == num)
				{
				}
				num = (short)1850540032;
				short num3 = num;
				num = (short)164626433;
				if (num != 0)
				{
				}
				num = (short)552337408;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Visible;
			}
			set
			{
				short num = (short)1346911852;
				short num2 = num;
				num = (short)863452780;
				switch (num2 == num)
				{
				}
				num = (short)1204355072;
				short num3 = num;
				num = (short)205717505;
				if (num != 0)
				{
				}
				num = (short)312410112;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Visible = value;
			}
		}

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x00AF3758 File Offset: 0x00AF1958
		// (set) Token: 0x0600BD7C RID: 48508 RVA: 0x00AF380C File Offset: 0x00AF1A0C
		public bool ConvConfigConvSystemFeatRSISys_A41838_Editable
		{
			get
			{
				short num = (short)2052275342;
				short num2 = num;
				num = (short)593378446;
				switch (num2 == num)
				{
				}
				num = (short)1130496000;
				short num3 = num;
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)14942208;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.Editable;
			}
			set
			{
				short num = (short)999881931;
				short num2 = num;
				num = (short)1567554763;
				switch (num2 == num)
				{
				}
				num = (short)1566769152;
				short num3 = num;
				num = (short)725876737;
				if (num != 0)
				{
				}
				num = (short)1725628416;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.Editable = value;
			}
		}

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x00AF38C0 File Offset: 0x00AF1AC0
		internal string ConvConfigConvSystemFeatRSISys_A41838_UILabel
		{
			get
			{
				short num = (short)1522597889;
				if (num != 0)
				{
				}
				num = (short)1519310145;
				short num2 = num;
				num = (short)1722864961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1824325632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1320157184;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.UIName;
			}
		}

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x0600BD7E RID: 48510 RVA: 0x00AF3974 File Offset: 0x00AF1B74
		// (set) Token: 0x0600BD7F RID: 48511 RVA: 0x00AF3A28 File Offset: 0x00AF1C28
		internal bool ConvConfigConvSystemFeatRSISys_A41838_HiddenStatic
		{
			get
			{
				short num = (short)590674127;
				short num2 = num;
				num = (short)727775439;
				switch (num2 == num)
				{
				}
				num = (short)2120417280;
				short num3 = num;
				num = (short)1224474624;
				if (num != 0)
				{
				}
				num = (short)1371734017;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.HiddenStatic;
			}
			set
			{
				short num = (short)1256363071;
				short num2 = num;
				num = (short)2051707967;
				switch (num2 == num)
				{
				}
				num = (short)2089484288;
				short num3 = num;
				num = (short)850591744;
				if (num != 0)
				{
				}
				num = (short)1815609345;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.HiddenStatic = value;
			}
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x0600BD80 RID: 48512 RVA: 0x00AF3AE0 File Offset: 0x00AF1CE0
		// (set) Token: 0x0600BD81 RID: 48513 RVA: 0x00AF3B94 File Offset: 0x00AF1D94
		internal bool ConvConfigConvSystemFeatRSISys_A41838_HiddenDynamic
		{
			get
			{
				short num = (short)322435082;
				short num2 = num;
				num = (short)953939978;
				switch (num2 == num)
				{
				}
				num = (short)1858076672;
				short num3 = num;
				num = (short)266272769;
				if (num != 0)
				{
				}
				num = (short)308674560;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838.HiddenDynamic;
			}
			set
			{
				short num = (short)519069354;
				short num2 = num;
				num = (short)1432968874;
				switch (num2 == num)
				{
				}
				num = (short)1212678144;
				short num3 = num;
				num = (short)1704198144;
				if (num != 0)
				{
				}
				num = (short)51707905;
				if (num != 0)
				{
				}
				this.convConfigConvSystemFeatRSISys_A41838.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x0600BD82 RID: 48514 RVA: 0x00AF3C4C File Offset: 0x00AF1E4C
		public bool ConvConfigConvSystemFeatRSISys_A41838_HasDiffs
		{
			get
			{
				short num = (short)1981075912;
				short num2 = num;
				num = (short)1991496136;
				switch (num2 == num)
				{
				}
				num = (short)1375928320;
				short num3 = num;
				num = (short)574160897;
				if (num != 0)
				{
				}
				num = (short)265224192;
				if (num != 0)
				{
				}
				return this.convConfigConvSystemFeatRSISys_A41838._HasDiffs;
			}
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x00AF3D00 File Offset: 0x00AF1F00
		// (set) Token: 0x0600BD84 RID: 48516 RVA: 0x00AF3DB4 File Offset: 0x00AF1FB4
		public bool CnvSysGeneralCourtesyTone_43584Value
		{
			get
			{
				short num = (short)1124335617;
				if (num != 0)
				{
				}
				num = (short)2049293494;
				short num2 = num;
				num = (short)1522646198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666842624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15794176;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Value;
			}
			set
			{
				short num = (short)1166409729;
				if (num != 0)
				{
				}
				num = (short)1210698579;
				short num2 = num;
				num = (short)1481952083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371340800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1718288384;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Value = value;
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x0600BD85 RID: 48517 RVA: 0x00AF3E68 File Offset: 0x00AF2068
		public global::AcpBusinessLayer.AcpField<bool> CnvSysGeneralCourtesyTone_43584
		{
			get
			{
				short num = (short)689628592;
				short num2 = num;
				num = (short)173270448;
				switch (num2 == num)
				{
				}
				num = (short)719781888;
				short num3 = num;
				num = (short)192282624;
				if (num != 0)
				{
				}
				num = (short)2092630017;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584;
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x00AF3F18 File Offset: 0x00AF2118
		// (set) Token: 0x0600BD87 RID: 48519 RVA: 0x00AF3FC8 File Offset: 0x00AF21C8
		public bool CnvSysGeneralCourtesyTone_43584_UIValue
		{
			get
			{
				short num = (short)1474484629;
				short num2 = num;
				num = (short)842979733;
				switch (num2 == num)
				{
				}
				num = (short)1079967744;
				short num3 = num;
				num = (short)1969815553;
				if (num != 0)
				{
				}
				num = (short)1069219840;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Value;
			}
			set
			{
				short num = (short)23574442;
				short num2 = num;
				num = (short)1341568938;
				switch (num2 == num)
				{
				}
				num = (short)1555169280;
				short num3 = num;
				num = (short)312934400;
				if (num != 0)
				{
				}
				num = (short)732758017;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Value = value;
			}
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x0600BD88 RID: 48520 RVA: 0x00AF407C File Offset: 0x00AF227C
		// (set) Token: 0x0600BD89 RID: 48521 RVA: 0x00AF4134 File Offset: 0x00AF2334
		public bool CnvSysGeneralCourtesyTone_43584_Applicable
		{
			get
			{
				short num = (short)617574847;
				short num2 = num;
				num = (short)1409839551;
				switch (num2 == num)
				{
				}
				num = (short)744882176;
				short num3 = num;
				num = (short)672595969;
				if (num != 0)
				{
				}
				num = (short)933101568;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Applicable;
			}
			set
			{
				short num = (short)1918139931;
				short num2 = num;
				num = (short)1778220571;
				switch (num2 == num)
				{
				}
				num = (short)427687936;
				short num3 = num;
				num = (short)1223753729;
				if (num != 0)
				{
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Applicable = value;
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x00AF41E8 File Offset: 0x00AF23E8
		// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x00AF429C File Offset: 0x00AF249C
		public bool CnvSysGeneralCourtesyTone_43584_Valid
		{
			get
			{
				short num = (short)1057645873;
				short num2 = num;
				num = (short)755000625;
				switch (num2 == num)
				{
				}
				num = (short)470417408;
				short num3 = num;
				num = (short)898564096;
				if (num != 0)
				{
				}
				num = (short)186384385;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Valid;
			}
			set
			{
				short num = (short)47972353;
				if (num != 0)
				{
				}
				num = (short)316124278;
				short num2 = num;
				num = (short)60075126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101332480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1567031296;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Valid = value;
			}
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x0600BD8C RID: 48524 RVA: 0x00AF4350 File Offset: 0x00AF2550
		// (set) Token: 0x0600BD8D RID: 48525 RVA: 0x00AF4408 File Offset: 0x00AF2608
		public bool CnvSysGeneralCourtesyTone_43584_Visible
		{
			get
			{
				short num = (short)1691714486;
				short num2 = num;
				num = (short)167936950;
				switch (num2 == num)
				{
				}
				num = (short)5767168;
				short num3 = num;
				num = (short)217448448;
				if (num != 0)
				{
				}
				num = (short)1981808641;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Visible;
			}
			set
			{
				short num = (short)60686337;
				if (num != 0)
				{
				}
				num = (short)494304138;
				short num2 = num;
				num = (short)842431370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661127168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016332288;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Visible = value;
			}
		}

		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x0600BD8E RID: 48526 RVA: 0x00AF44BC File Offset: 0x00AF26BC
		// (set) Token: 0x0600BD8F RID: 48527 RVA: 0x00AF4570 File Offset: 0x00AF2770
		public bool CnvSysGeneralCourtesyTone_43584_Editable
		{
			get
			{
				short num = (short)1382326992;
				short num2 = num;
				num = (short)1216258768;
				switch (num2 == num)
				{
				}
				num = (short)920584192;
				short num3 = num;
				num = (short)130547712;
				if (num != 0)
				{
				}
				num = (short)674693121;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.Editable;
			}
			set
			{
				short num = (short)1273558867;
				short num2 = num;
				num = (short)984741715;
				switch (num2 == num)
				{
				}
				num = (short)905248768;
				short num3 = num;
				num = (short)1149501441;
				if (num != 0)
				{
				}
				num = (short)1832583168;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.Editable = value;
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x0600BD90 RID: 48528 RVA: 0x00AF4624 File Offset: 0x00AF2824
		internal string CnvSysGeneralCourtesyTone_43584_UILabel
		{
			get
			{
				short num = (short)925473972;
				short num2 = num;
				num = (short)698588340;
				switch (num2 == num)
				{
				}
				num = (short)2144403456;
				short num3 = num;
				num = (short)474349569;
				if (num != 0)
				{
				}
				num = (short)1706295296;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.UIName;
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x0600BD91 RID: 48529 RVA: 0x00AF46DC File Offset: 0x00AF28DC
		// (set) Token: 0x0600BD92 RID: 48530 RVA: 0x00AF4790 File Offset: 0x00AF2990
		internal bool CnvSysGeneralCourtesyTone_43584_HiddenStatic
		{
			get
			{
				short num = (short)159313650;
				short num2 = num;
				num = (short)1180626674;
				switch (num2 == num)
				{
				}
				num = (short)1997144064;
				short num3 = num;
				num = (short)1266614273;
				if (num != 0)
				{
				}
				num = (short)411107328;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.HiddenStatic;
			}
			set
			{
				short num = (short)1154787772;
				short num2 = num;
				num = (short)249866684;
				switch (num2 == num)
				{
				}
				num = (short)1130299392;
				short num3 = num;
				num = (short)714080256;
				if (num != 0)
				{
				}
				num = (short)2106261505;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.HiddenStatic = value;
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x0600BD93 RID: 48531 RVA: 0x00AF4848 File Offset: 0x00AF2A48
		// (set) Token: 0x0600BD94 RID: 48532 RVA: 0x00AF48FC File Offset: 0x00AF2AFC
		internal bool CnvSysGeneralCourtesyTone_43584_HiddenDynamic
		{
			get
			{
				short num = (short)460534987;
				short num2 = num;
				num = (short)296301771;
				switch (num2 == num)
				{
				}
				num = (short)477167616;
				short num3 = num;
				num = (short)967573505;
				if (num != 0)
				{
				}
				num = (short)944111616;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584.HiddenDynamic;
			}
			set
			{
				short num = (short)914030593;
				if (num != 0)
				{
				}
				num = (short)262421329;
				short num2 = num;
				num = (short)463158097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238695936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887422976;
				if (num != 0)
				{
				}
				this.cnvSysGeneralCourtesyTone_43584.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x00AF49B4 File Offset: 0x00AF2BB4
		public bool CnvSysGeneralCourtesyTone_43584_HasDiffs
		{
			get
			{
				short num = (short)288117828;
				short num2 = num;
				num = (short)516248644;
				switch (num2 == num)
				{
				}
				num = (short)821755904;
				short num3 = num;
				num = (short)1199702016;
				if (num != 0)
				{
				}
				num = (short)1283653633;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralCourtesyTone_43584._HasDiffs;
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x0600BD96 RID: 48534 RVA: 0x00AF4A68 File Offset: 0x00AF2C68
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2145782488;
				short num2 = num;
				num = (short)6556376;
				switch (num2 == num)
				{
				}
				num = (short)486080512;
				short num3 = num;
				num = (short)2082078720;
				if (num != 0)
				{
				}
				num = (short)1197932545;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x00AF4B28 File Offset: 0x00AF2D28
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
					goto IL_115;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1838153731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				case 2:
				{
					IL_59:
					num2 = (short)1096089600;
					short num3 = num2;
					num2 = (short)2011430913;
					if (num2 != 0)
					{
					}
					num2 = (short)1084817409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)890437632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)520945666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				}
				goto IL_24;
				IL_115:
				num2 = (short)1085636118;
				short num4 = num2;
				num2 = (short)1805221398;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_59;
				default:
					goto IL_149;
				}
			}
			IL_149:
			num2 = (short)68812800;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)989003780;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C0C RID: 23564
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralAckPretimems_A7393;

		// Token: 0x04005C0D RID: 23565
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005C0E RID: 23566
		private global::AcpBusinessLayer.AcpListField cnvSysGeneralPTTID_A8427;

		// Token: 0x04005C0F RID: 23567
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x04005C10 RID: 23568
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralPreambles_A8731;

		// Token: 0x04005C11 RID: 23569
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x04005C12 RID: 23570
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x04005C13 RID: 23571
		private global::AcpBusinessLayer.AcpListField cnvSysGeneralSidetones_A8774;

		// Token: 0x04005C14 RID: 23572
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005C15 RID: 23573
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x04005C16 RID: 23574
		private global::AcpBusinessLayer.AcpRangeField<int, string> astTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x04005C17 RID: 23575
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvSysGeneralVariableID_A9612;

		// Token: 0x04005C18 RID: 23576
		private global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A13262;

		// Token: 0x04005C19 RID: 23577
		private global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x04005C1A RID: 23578
		private global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005C1B RID: 23579
		private global::AcpBusinessLayer.AcpField<bool> cnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005C1C RID: 23580
		private global::AcpBusinessLayer.AcpKeyField cnvSysGeneralKeyofConventionalSystem_A20482;

		// Token: 0x04005C1D RID: 23581
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x04005C1E RID: 23582
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralPreambleLength_A8721;

		// Token: 0x04005C1F RID: 23583
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralIndividualID_A8287;

		// Token: 0x04005C20 RID: 23584
		private global::AcpBusinessLayer.AcpField<bool> cnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x04005C21 RID: 23585
		private global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralHomeWACNID_A40121;

		// Token: 0x04005C22 RID: 23586
		private global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralSystemID_A40122;

		// Token: 0x04005C23 RID: 23587
		private global::AcpBusinessLayer.AcpField<bool> cnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005C24 RID: 23588
		private global::AcpBusinessLayer.AcpField<bool> convConfigConvSystemFeatRSISys_A41838;

		// Token: 0x04005C25 RID: 23589
		private global::AcpBusinessLayer.AcpField<bool> cnvSysGeneralCourtesyTone_43584;
	}
}
