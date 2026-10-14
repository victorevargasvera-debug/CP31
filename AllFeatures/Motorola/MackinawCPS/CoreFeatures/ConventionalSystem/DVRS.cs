using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200056E RID: 1390
	[global::System.Serializable]
	public class DVRS : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B775 RID: 46965 RVA: 0x00AA91B0 File Offset: 0x00AA73B0
		public DVRS(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x00AA91CC File Offset: 0x00AA73CC
		protected DVRS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x00AA91E4 File Offset: 0x00AA73E4
		public override void Init()
		{
			int a_ = 10;
			short num = (short)382081600;
			short num2 = num;
			num = (short)172300864;
			switch (num2 == num)
			{
			}
			num = (short)276758528;
			if (num != 0)
			{
			}
			num = (short)585433089;
			if (num != 0)
			{
			}
			num = (short)930742272;
			short num3 = num;
			this.cnvSysDVRSTalkPermitTone_A40124 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜诞胠迢軤럦賨駪胬蛮藰ꟲ髴駶鳸ꓺ볼쯾㄀㈂㜄㌆", a_), global::CommonResources.AcgResources.ID_TALKPERMITTONE);
			this.cnvSysDVRSTalkPermitTone_A40124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSTalkPermitTone_A40124.DataTransferOrder = 19;
			this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜诞ꃠꋢ菤鏦賨駪ꧬ맮ꏰꃲ믴飶뫸铺郼鋾䀀眂焄戆搈笊礌簎丐划℔✖⠘⤚⠜", a_), global::CommonResources.AcgResources.ID_TAAFTERDVRSNOCOMMUNICATIONATTEMPTS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125LovStrs);
			this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.DataTransferOrder = 46;
			this.cnvSysDVRSOutOfDVRSRangeTime_A40127 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜郞铠韢ꫤ臦귨뷪뿬볮ꏰ鋲鯴郶鳸꿺铼鋾搀専䐄㌆㤈㨊㼌㠎", a_), global::CommonResources.AcgResources.ID_OUTOFDVRSRANGETIMESEC, 0, 120, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.cnvSysDVRSOutOfDVRSRangeTime_A40127.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSOutOfDVRSRangeTime_A40127.DataTransferOrder = 47;
			this.cnvSysDVRSOutOfDVRSRangeTime_A40127.ShowHexValue = false;
			this.cnvSysDVRSRespPendingTime_A40129 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜跞蓠郢闤럦賨藪觬蛮鿰铲ꇴ黶铸黺ꋼ뻾㔀㌂㐄㔆〈", a_), global::CommonResources.AcgResources.ID_TIMERSRESPONSEPENDINGTIMESEC, 0, 255, null, null, 0, 1);
			this.cnvSysDVRSRespPendingTime_A40129.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysDVRSRespPendingTime_A40129.DataTransferOrder = 58;
			this.cnvSysDVRSRespPendingTime_A40129.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.cnvSysDVRSRespPendingTime_A40129.ShowHexValue = false;
			this.cnvSysDVRSBusyUpdateTime_A40130 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜鷞铠郢鳤닦駨迪賬鯮铰ꟲ鳴髶鳸ꓺ볼쯾㄀㈂㘄㜆", a_), global::CommonResources.AcgResources.ID_TIMERSBUSYUPDATETIMESEC, 0, 63, null, null, 0, 15);
			this.cnvSysDVRSBusyUpdateTime_A40130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysDVRSBusyUpdateTime_A40130.DataTransferOrder = 56;
			this.cnvSysDVRSBusyUpdateTime_A40130.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.cnvSysDVRSBusyUpdateTime_A40130.ShowHexValue = false;
			this.cnvSysDVRSPTTWarningTime_A40131 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜连뗠럢다蛦鯨藪蓬臮雰ꟲ鳴髶鳸ꓺ볼쯾㄀㈂㘄㘆", a_), global::CommonResources.AcgResources.ID_TIMERSPTTWARNINGTIMEMS, 0, 255, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 25);
			this.cnvSysDVRSPTTWarningTime_A40131.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysDVRSPTTWarningTime_A40131.DataTransferOrder = 55;
			this.cnvSysDVRSPTTWarningTime_A40131.ShowHexValue = false;
			this.cnvSysDVRSForceUnmuteTime_A40138 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜駞軠釢蛤苦볨藪胬髮藰雲ꇴ黶铸黺ꋼ뻾㔀㌂㐄㐆ㄈ", a_), global::CommonResources.AcgResources.ID_TIMERSFORCEUNMUTETIMEMS, 0, 255, global::CommonResources.AcgResources.ID_IMMEDIATE, null, 0, 25);
			this.cnvSysDVRSForceUnmuteTime_A40138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvSysDVRSForceUnmuteTime_A40138.DataTransferOrder = 53;
			this.cnvSysDVRSForceUnmuteTime_A40138.ShowHexValue = false;
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139 = new global::AcpBusinessLayer.AcpSimpleRangeField(61, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜雞迠蟢ꛤ蛦藨蟪ꃬ軮觰ꟲ铴藶黸黺觼귾栀洂戄匆怈昊栌倎倐✒└☖⨘√", a_), global::CommonResources.AcgResources.ID_TIMERSINDIVIDUALCALLMAXTARGETRINGTIMESEC, 61, 120, null, null, 0, 1);
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.DataTransferOrder = 51;
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.ShowHexValue = false;
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜连鏠諢鏤蛦鷨軪껬軮鷰鿲룴零臸닺鏼雾甀儂氄椆済弊搌戎琐䰒吔⌖⤘⨚⤜⼞", a_), global::CommonResources.AcgResources.ID_TIMERSPRIVATECALLMAXINITIALRINGSEC, 0, 255, null, null, 0, 1);
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.DataTransferOrder = 52;
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.ShowHexValue = false;
			this.cnvSysDVRSAttachRetryTime_A40141 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜點闠韢蓤蓦臨맪裬鯮菰諲ꇴ黶铸黺ꋼ뻾㔀㌂㐄㌆㠈", a_), global::CommonResources.AcgResources.ID_FASTRETRYTIMEMS, 1, 245, null, null, 0, 25);
			this.cnvSysDVRSAttachRetryTime_A40141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSAttachRetryTime_A40141.DataTransferOrder = 48;
			this.cnvSysDVRSAttachRetryTime_A40141.ShowHexValue = false;
			this.cnvSysDVRSAttachRetries_A40142 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜點闠韢蓤蓦臨맪裬鯮菰髲郴蓶꛸뫺짼쿾\u3000㜂㜄", a_), global::CommonResources.AcgResources.ID_ATTACHMENTRETRIES, 1, 10, null, null, 0, 1);
			this.cnvSysDVRSAttachRetries_A40142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSAttachRetries_A40142.DataTransferOrder = 50;
			this.cnvSysDVRSAttachRetries_A40142.ShowHexValue = false;
			this.cnvSysDVRSEmerBlockInFS_A40143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜髞賠蛢韤ꗦ藨蓪軬蓮룰鷲돴ꓶ꛸뫺짼쿾\u3000㜂㘄", a_), global::CommonResources.AcgResources.ID_EMERGENCYBLOCKEDINFAILSOFT_1);
			this.cnvSysDVRSEmerBlockInFS_A40143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSEmerBlockInFS_A40143.DataTransferOrder = 18;
			this.cnvSysFeatureDynRegroupZone_A40145 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ釖볘뫚꧜꫞鏠蛢ꇤ黦蟨맪裬裮菰鳲胴蟶ꏸ铺鏼髾帀䈂㄄㜆㠈㼊㠌", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvSysFeatureDynRegroupZone_A40145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeatureDynRegroupZone_A40145.DataTransferOrder = 42;
			this.cnvSysFeatureDynRegroupZone_A40145.EvaluateRecRefs = true;
			this.cnvSysFeatureDynRegroupChannel_A40144 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ釖볘뫚꧜꫞鏠蛢ꇤ黦蟨맪裬裮菰鳲胴蟶뫸鏺鳼釾漀昂椄堆䠈㼊㴌㸎┐✒", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.cnvSysFeatureDynRegroupChannel_A40144.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeatureDynRegroupChannel_A40144.DataTransferOrder = 43;
			this.cnvSysFeatureDynRegroupChannel_A40144.EvaluateRecRefs = true;
			this.cnvSysFeatureDynRegroupEn_A40146 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ釖볘뫚꧜꫞鏠蛢ꇤ黦蟨맪裬裮菰鳲胴蟶본闺ꋼ뻾㔀㌂㐄㌆㼈", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGDYNAMICREGROUPINGENABLE);
			this.cnvSysFeatureDynRegroupEn_A40146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysFeatureDynRegroupEn_A40146.DataTransferOrder = 39;
			this.cnvSysFeatureDynRegroupEn_A40146.EvaluateRecRefs = true;
			this.cnvSysFeatureCallType_A40147 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ釖볘뫚꧜꫞鏠蛢ꛤ蛦藨蟪맬雮臰雲ꫴ뛶췸쯺쳼쯾㘀", a_), global::CommonResources.AcgResources.ID_CALLTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeatureCallType_A40147LovStrs);
			this.cnvSysFeatureCallType_A40147.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysFeatureCallType_A40147.DataTransferOrder = 86;
			this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜髞迠蟢ꫤ鋦鷨ꓪ诬뷮郰鷲鋴鋶뛸闺볼釾怀漂樄怆嬈猊刌与┐⌒␔⌖⨘", a_), global::CommonResources.AcgResources.ID_ENDOUTOFRANGEONANALOGRX);
			this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.DataTransferOrder = 81;
			this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜鷞飠鏢蓤铦髨뫪飬蛮鋰飲뻴鋶胸귺鋼雾戀昂䘄漆栈攊挌樎紐划瘔琖簘栚渜䀞ᔠᄢᄤጦᰨ", a_), global::CommonResources.AcgResources.ID_BYPASSQUICKKEYVOICECHANNELACCESS);
			this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.DataTransferOrder = 85;
			this.cnvSysDVRSPhase2SysCompatibility_43000 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜连觠苢雤苦\udbe8룪铬鳮닰鳲飴蟶飸迺铼鷾栀漂氄猆瀈吊㤌㰎ℐ⌒└", a_), global::CommonResources.AcgResources.ID_PHASE2SYSTEMCOMPATIBILITY);
			this.cnvSysDVRSPhase2SysCompatibility_43000.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSPhase2SysCompatibility_43000.DataTransferOrder = 87;
			this.cnvSysDVRSPreferTalkaroundInNoComms_44810 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜连鏠蛢菤苦鯨뿪賬菮髰鋲蟴飶賸闺駼뛾漀䴂樄䐆昈昊怌簎丐✒℔⼖⠘⬚", a_), global::CommonResources.AcgResources.ID_PREFERTALKAROUNDINNOCOMMS);
			this.cnvSysDVRSPreferTalkaroundInNoComms_44810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSPreferTalkaroundInNoComms_44810.DataTransferOrder = 88;
			this.cnvSysDVRSDVRSyncNACMatching_44811 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ鏖还觚軜鯞럠뇢뛤黦蟨裪ꏬ껮닰뻲铴菶髸鏺铼釾昀専㄄㌆ㄈ㨊㰌", a_), global::CommonResources.AcgResources.ID_DVRSYNCNACMATCHING);
			this.cnvSysDVRSDVRSyncNACMatching_44811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysDVRSDVRSyncNACMatching_44811.DataTransferOrder = 89;
			this.cnvSysTalkaroundAudioModes_44812 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많苐꫒ꛔ菖룘럚뛜뻞鏠賢郤触跨ꫪ飬诮飰鳲룴飶鷸黺軼ꃾ㔀㜂㴄㘆㬈", a_), global::CommonResources.AcgResources.ID_TALKAROUNDAUDIOMODES, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysTalkaroundAudioModes_44812LovStrs);
			this.cnvSysTalkaroundAudioModes_44812.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysTalkaroundAudioModes_44812.DataTransferOrder = 90;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迊鯌鷎苐", a_);
			base.Id = 10643;
			base.UIName = global::CommonResources.AcgResources.ID_DVRS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x00AA991C File Offset: 0x00AA7B1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)303759389;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟귡釣鋥꟧賩꣫룭ꋯꇱ꛳韵雷鷹駻꫽槿漁愃夅䤇㸉㰋㼍∏┑", a_)))
					{
						num = (short)423034882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0D;
				case 1:
					goto IL_E66;
				case 2:
					this.cnvSysDVRSOutOfDVRSRangeTime_A40127 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟귡釣鋥꟧賩꣫룭ꋯꇱ꛳韵雷鷹駻꫽槿漁愃夅䤇㸉㰋㼍∏┑", a_), global::CommonResources.AcgResources.ID_OUTOFDVRSRANGETIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.cnvSysDVRSOutOfDVRSRangeTime_A40127.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSOutOfDVRSRangeTime_A40127.DataTransferOrder = 47;
					this.cnvSysDVRSOutOfDVRSRangeTime_A40127.ShowHexValue = false;
					num = (short)670629900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvSysFeatureDynRegroupEn_A40146 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹맻都忿䌁〃㘅㤇㸉㨋", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGDYNAMICREGROUPINGENABLE);
					this.cnvSysFeatureDynRegroupEn_A40146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeatureDynRegroupEn_A40146.DataTransferOrder = 39;
					this.cnvSysFeatureDynRegroupEn_A40146.EvaluateRecRefs = true;
					num = (short)1086390308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)2128332225;
					short num3 = num;
					num = (short)2119353793;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_507;
					default:
						num = (short)2094399488;
						if (num != 0)
						{
						}
						this.cnvSysDVRSBusyUpdateTime_A40130 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꃡ釣闥釧뿩鳫諭釯蛱釳ꋵ釷韹駻ꇽ䇿㘁㐃㜅㬇㨉", a_), global::CommonResources.AcgResources.ID_TIMERSBUSYUPDATETIMESEC, null, null, 0, 15);
						this.cnvSysDVRSBusyUpdateTime_A40130.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.cnvSysDVRSBusyUpdateTime_A40130.DataTransferOrder = 56;
						this.cnvSysDVRSBusyUpdateTime_A40130.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
						this.cnvSysDVRSBusyUpdateTime_A40130.ShowHexValue = false;
						num = (short)765001792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟꟡解菥髧꣩胫臭鏯駱뷳飵뻷꧹ꏻ뿽㓿㈁㔃㈅㬇", a_)))
					{
						num = (short)1914175522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BA;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꯡ諣若ꯧ诩胫苭뷯鏱賳ꋵ駷裹鯻鯽瓿倁洃栅漇帉攋挍甏䴑唓∕⠗⬙⼛✝", a_)))
					{
						num = (short)293077013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_833;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟꟡諣若꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹돻都䇿氁攃樅朇洉帋瘍伏匑–☕⤗⸙⼛", a_)))
					{
						num = (short)248119339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD0;
				case 8:
					goto IL_4BA;
				case 9:
					goto IL_55D;
				case 10:
					goto IL_2F0;
				case 11:
					this.cnvSysDVRSForceUnmuteTime_A40138 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꓡ诣铥诧迩맫胭鷯蟱胳鏵곷鏹釻鯽忿䌁〃㘅㤇㤉㐋", a_), global::CommonResources.AcgResources.ID_TIMERSFORCEUNMUTETIMEMS, global::CommonResources.AcgResources.ID_IMMEDIATE, null, 0, 25);
					this.cnvSysDVRSForceUnmuteTime_A40138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysDVRSForceUnmuteTime_A40138.DataTransferOrder = 53;
					this.cnvSysDVRSForceUnmuteTime_A40138.ShowHexValue = false;
					num = (short)317390886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_B0D;
				case 13:
					this.cnvSysFeatureCallType_A40147 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥ꯧ诩胫苭ꓯ诱蓳鏵ꟷ믹죻컽ㇿ㘁㌃", a_), global::CommonResources.AcgResources.ID_CALLTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysFeatureCallType_A40147LovStrs);
					this.cnvSysFeatureCallType_A40147.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysFeatureCallType_A40147.DataTransferOrder = 86;
					num = (short)365756468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_D1E;
				case 15:
					goto IL_A76;
				case 16:
					this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟뛡ꗣ꟥軧黩觫鳭듯ꓱ꛳ꗵ뛷闹뿻釽淿漁䔃爅簇漉愋縍搏愑䬓圕Ⱇ⨙ⴛⰝᔟ", a_), global::CommonResources.AcgResources.ID_TAAFTERDVRSNOCOMMUNICATIONATTEMPTS, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125LovStrs);
					this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.DataTransferOrder = 46;
					num = (short)2087845898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_DC1;
				case 18:
					goto IL_C1E;
				case 19:
					goto IL_87D;
				case 20:
					this.cnvSysFeatureDynRegroupChannel_A40144 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹뿻雽懿氁樃挅搇唉䴋㨍‏⌑–∕", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.cnvSysFeatureDynRegroupChannel_A40144.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeatureDynRegroupChannel_A40144.DataTransferOrder = 43;
					this.cnvSysFeatureDynRegroupChannel_A40144.EvaluateRecRefs = true;
					num = (short)1367408670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.cnvSysDVRSIndCallMaxTargetRingTime_A40139 = new global::AcpBusinessLayer.AcpSimpleRangeField(61, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꯡ諣若ꯧ诩胫苭뷯鏱賳ꋵ駷裹鯻鯽瓿倁洃栅漇帉攋挍甏䴑唓∕⠗⬙⼛✝", a_), global::CommonResources.AcgResources.ID_TIMERSINDIVIDUALCALLMAXTARGETRINGTIMESEC, null, null, 0, 1);
					this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.DataTransferOrder = 51;
					this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.ShowHexValue = false;
					num = (short)878968890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields != null)
					{
						num = (short)35586096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117E;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꏡ郣鋥觧觩蓫볭闯蛱蛳鿵鷷觹ꏻ뿽㓿㈁㔃㈅㨇", a_)))
					{
						num = (short)108134462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1E;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡難迥黧诩飫语돯鏱飳髵뗷鯹蓻럽滿欁瀃吅愇搉欋娍礏缑焓䤕夗⸙Ⱋ⼝ᐟሡ", a_)))
					{
						num = (short)1194852392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87D;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥ꯧ诩胫苭ꓯ诱蓳鏵ꟷ믹죻컽ㇿ㘁㌃", a_)))
					{
						num = (short)55902221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F90;
				case 26:
					this.cnvSysDVRSRespPendingTime_A40129 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟냡臣闥飧뫩觫胭铯鯱髳釵곷鏹釻鯽忿䌁〃㘅㤇㠉㔋", a_), global::CommonResources.AcgResources.ID_TIMERSRESPONSEPENDINGTIMESEC, null, null, 0, 1);
					this.cnvSysDVRSRespPendingTime_A40129.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysDVRSRespPendingTime_A40129.DataTransferOrder = 58;
					this.cnvSysDVRSRespPendingTime_A40129.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.cnvSysDVRSRespPendingTime_A40129.ShowHexValue = false;
					num = (short)1551892513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꛡ닣듥믧鏩苫跭뻯돱럳믵駷軹鿻雽槿氁挃夅㰇㸉㐋㼍ℏ", a_)))
					{
						num = (short)1213726775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E66;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꃡ鷣雥觧駩鿫뿭藯鯱音鷵돷鿹藻ꣽ濿欁會挅䬇戉洋怍縏眑砓圕笗礙礛洝匟紡ဣᐥᰧḩᤫ", a_)))
					{
						num = (short)1825374274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A2;
				case 29:
					switch (0)
					{
					case 0:
						goto IL_146;
					}
					continue;
				case 30:
					goto IL_10DB;
				case 31:
				{
					this.cnvSysDVRSPreferTalkaroundInNoComms_44810 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡難菥軧迩黫뫭釯黱鿳韵諷闹觻都擿䬁樃䠅朇䤉挋挍紏愑䬓∕Ⱇ∙ⴛ⸝", a_), global::CommonResources.AcgResources.ID_PREFERTALKAROUNDINNOCOMMS);
					this.cnvSysDVRSPreferTalkaroundInNoComms_44810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSPreferTalkaroundInNoComms_44810.DataTransferOrder = 88;
					num = (short)919339008;
					short num4 = num;
					num = (short)1372323901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 32:
					this.cnvSysDVRSTalkPermitTone_A40124 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟뛡藣諥菧뫩觫鳭鷯鯱胳ꋵ韷铹駻ꇽ䇿㘁㐃㜅㨇㸉", a_), global::CommonResources.AcgResources.ID_TALKPERMITTONE);
					this.cnvSysDVRSTalkPermitTone_A40124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSTalkPermitTone_A40124.DataTransferOrder = 19;
					num = (short)35389457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					goto IL_208;
				case 34:
					this.cnvSysDVRSEmerBlockInFS_A40143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟꟡解菥髧꣩胫臭鏯駱뷳飵뻷꧹ꏻ뿽㓿㈁㔃㈅㬇", a_), global::CommonResources.AcgResources.ID_EMERGENCYBLOCKEDINFAILSOFT_1);
					this.cnvSysDVRSEmerBlockInFS_A40143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSEmerBlockInFS_A40143.DataTransferOrder = 18;
					num = (short)822083630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)1660813313;
					if (num != 0)
					{
					}
					this.cnvSysDVRSPTTWarningTime_A40131 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡냣닥뿧诩黫胭駯鳱鏳ꋵ釷韹駻ꇽ䇿㘁㐃㜅㬇㬉", a_), global::CommonResources.AcgResources.ID_TIMERSPTTWARNINGTIMEMS, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 25);
					this.cnvSysDVRSPTTWarningTime_A40131.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvSysDVRSPTTWarningTime_A40131.DataTransferOrder = 55;
					this.cnvSysDVRSPTTWarningTime_A40131.ShowHexValue = false;
					num = (short)189202447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_16C;
				case 37:
					goto IL_507;
				case 38:
					goto IL_AC0;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹맻都忿䌁〃㘅㤇㸉㨋", a_)))
					{
						num = (short)2087780355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C;
				case 40:
					this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡難迥黧诩飫语돯鏱飳髵뗷鯹蓻럽滿欁瀃吅愇搉欋娍礏缑焓䤕夗⸙Ⱋ⼝ᐟሡ", a_), global::CommonResources.AcgResources.ID_TIMERSPRIVATECALLMAXINITIALRINGSEC, null, null, 0, 1);
					this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.DataTransferOrder = 52;
					this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.ShowHexValue = false;
					num = (short)642252819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟냡臣闥飧뫩觫胭铯鯱髳釵곷鏹釻鯽忿䌁〃㘅㤇㠉㔋", a_)))
					{
						num = (short)2080309274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_208;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡賣蟥鯧迩\udeeb뷭觯臱럳駵闷諹鷻諽槿态洃樅愇縉甋儍␏ℑ␓☕⠗", a_)))
					{
						num = (short)1474035763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BA;
				case 43:
					this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟꟡諣若꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹돻都䇿氁攃樅朇洉帋瘍伏匑–☕⤗⸙⼛", a_), global::CommonResources.AcgResources.ID_ENDOUTOFRANGEONANALOGRX);
					this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.DataTransferOrder = 81;
					num = (short)2072838212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹뿻雽懿氁樃挅搇唉䴋㨍‏⌑–∕", a_)))
					{
						num = (short)1205993492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10DB;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟뛡藣諥菧뫩觫鳭鷯鯱胳ꋵ韷铹駻ꇽ䇿㘁㐃㜅㨇㸉", a_)))
					{
						num = (short)1364787232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC1;
				case 46:
					goto IL_1BA;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꃡ釣闥釧뿩鳫諭釯蛱釳ꋵ釷韹駻ꇽ䇿㘁㐃㜅㬇㨉", a_)))
					{
						num = (short)1359609860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9AC;
				case 48:
					num = (short)422641709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					goto IL_2A2;
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꏡ郣鋥觧觩蓫볭闯蛱蛳迵곷鏹釻鯽忿䌁〃㘅㤇㸉㴋", a_)))
					{
						num = (short)121307201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1E;
				case 51:
					this.cnvSysDVRSPhase2SysCompatibility_43000 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡賣蟥鯧迩\udeeb뷭觯臱럳駵闷諹鷻諽槿态洃樅愇縉甋儍␏ℑ␓☕⠗", a_), global::CommonResources.AcgResources.ID_PHASE2SYSTEMCOMPATIBILITY);
					this.cnvSysDVRSPhase2SysCompatibility_43000.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSPhase2SysCompatibility_43000.DataTransferOrder = 87;
					num = (short)2088763400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					goto IL_F90;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꓡ诣铥诧迩맫胭鷯蟱胳鏵곷鏹釻鯽忿䌁〃㘅㤇㤉㐋", a_)))
					{
						num = (short)1534787595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC0;
				case 54:
					this.cnvSysFeatureDynRegroupZone_A40145 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹꛻釽滿朁嬃䜅㰇㨉㴋㨍┏", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.cnvSysFeatureDynRegroupZone_A40145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysFeatureDynRegroupZone_A40145.DataTransferOrder = 42;
					this.cnvSysFeatureDynRegroupZone_A40145.EvaluateRecRefs = true;
					num = (short)1514209339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					this.cnvSysDVRSDVRSyncNACMatching_44811 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꛡ닣듥믧鏩苫跭뻯돱럳믵駷軹鿻雽槿氁挃夅㰇㸉㐋㼍ℏ", a_), global::CommonResources.AcgResources.ID_DVRSYNCNACMATCHING);
					this.cnvSysDVRSDVRSyncNACMatching_44811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSDVRSyncNACMatching_44811.DataTransferOrder = 89;
					num = (short)966459393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ鳙맛뿝铟韡難菥곧鏩苫볭闯闱蛳駵跷諹꛻釽滿朁嬃䜅㰇㨉㴋㨍┏", a_)))
					{
						num = (short)2052587574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1037;
				case 57:
					num = (short)457834518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					goto IL_833;
				case 59:
					goto IL_1037;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟뛡ꗣ꟥軧黩觫鳭듯ꓱ꛳ꗵ뛷闹뿻釽淿漁䔃爅簇漉愋縍搏愑䬓圕Ⱇ⨙ⴛⰝᔟ", a_)))
					{
						num = (short)961150992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F0;
				case 61:
					goto IL_39E;
				case 62:
					this.cnvSysDVRSAttachRetries_A40142 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꏡ郣鋥觧觩蓫볭闯蛱蛳鿵鷷觹ꏻ뿽㓿㈁㔃㈅㨇", a_), global::CommonResources.AcgResources.ID_ATTACHMENTRETRIES, null, null, 0, 1);
					this.cnvSysDVRSAttachRetries_A40142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSAttachRetries_A40142.DataTransferOrder = 50;
					this.cnvSysDVRSAttachRetries_A40142.ShowHexValue = false;
					num = (short)771686418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ軙뷛닝诟菡難觥鷧蓩裫꿭藯雱鷳駵뗷闹飻鯽珿崁〃㈅〇㬉㸋", a_)))
					{
						num = (short)559874085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117E;
				case 64:
					goto IL_9AC;
				case 65:
					this.cnvSysDVRSAttachRetryTime_A40141 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꏡ郣鋥觧觩蓫볭闯蛱蛳迵곷鏹釻鯽忿䌁〃㘅㤇㸉㴋", a_), global::CommonResources.AcgResources.ID_FASTRETRYTIMEMS, null, null, 0, 25);
					this.cnvSysDVRSAttachRetryTime_A40141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysDVRSAttachRetryTime_A40141.DataTransferOrder = 48;
					this.cnvSysDVRSAttachRetryTime_A40141.ShowHexValue = false;
					num = (short)1456341006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟ꃡ鷣雥觧駩鿫뿭藯鯱音鷵돷鿹藻ꣽ濿欁會挅䬇戉洋怍縏眑砓圕笗礙礛洝匟紡ဣᐥᰧḩᤫ", a_), global::CommonResources.AcgResources.ID_BYPASSQUICKKEYVOICECHANNELACCESS);
					this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.DataTransferOrder = 85;
					num = (short)341508145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡難菥軧迩黫뫭釯黱鿳韵諷闹觻都擿䬁樃䠅朇䤉挋挍紏愑䬓∕Ⱇ∙ⴛ⸝", a_)))
					{
						num = (short)822476831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39E;
				case 68:
					goto IL_CD0;
				case 69:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ黙諛賝돟닡냣닥뿧诩黫胭駯鳱鏳ꋵ釷韹駻ꇽ䇿㘁㐃㜅㬇㬉", a_)))
					{
						num = (short)59899939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A76;
				}
				IL_146:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1185022009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16C:
				num = (short)1858666521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BA:
				num = (short)661127224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_208:
				num = (short)1017184303;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A2:
				num = (short)1917517866;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F0:
				num = (short)1293680640;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39E:
				num = (short)2055798811;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BA:
				num = (short)1900740675;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_507:
				this.cnvSysTalkaroundAudioModes_44812 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ蟓꿕ꯗ軙뷛닝诟菡難觥鷧蓩裫꿭藯雱鷳駵뗷闹飻鯽珿崁〃㈅〇㬉㸋", a_), global::CommonResources.AcgResources.ID_TALKAROUNDAUDIOMODES, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysTalkaroundAudioModes_44812LovStrs);
				this.cnvSysTalkaroundAudioModes_44812.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.cnvSysTalkaroundAudioModes_44812.DataTransferOrder = 90;
				num = (short)1922236425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_833:
				num = (short)2073559064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_87D:
				num = (short)888602674;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9AC:
				num = (short)215285829;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A76:
				num = (short)2120024117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC0:
				num = (short)877068294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B0D:
				num = (short)1348141097;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1E:
				num = (short)1191247877;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD0:
				num = (short)2066546716;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D1E:
				num = (short)455409687;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DC1:
				num = (short)2049900604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E66:
				num = (short)1648164927;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F90:
				num = (short)1061027847;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1037:
				num = (short)1771831340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10DB:
				num = (short)340918311;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_55D:
			IL_117E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓", a_);
			base.Id = 10643;
			base.UIName = global::CommonResources.AcgResources.ID_DVRS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x00AAAAD8 File Offset: 0x00AA8CD8
		public override void PopulateReferences()
		{
			short num = (short)1064193007;
			short num2 = num;
			num = (short)200297455;
			switch (num2 == num)
			{
			}
			num = (short)1307115520;
			short num3 = num;
			num = (short)874512384;
			if (num != 0)
			{
			}
			num = (short)1540423681;
			if (num != 0)
			{
			}
			this.cnvSysFeatureDynRegroupZone_A40145.SetRecset(this.a(2051));
			this.cnvSysFeatureDynRegroupZone_A40145.AddSlaveField(this.cnvSysFeatureDynRegroupChannel_A40144, 10114);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x00AAABAC File Offset: 0x00AA8DAC
		public override void DropReferences()
		{
			short num = (short)926734157;
			short num2 = num;
			num = (short)525522765;
			switch (num2 == num)
			{
			}
			num = (short)952172544;
			short num3 = num;
			num = (short)1900019713;
			if (num != 0)
			{
			}
			num = (short)1627521024;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x00AAAC54 File Offset: 0x00AA8E54
		public override void SetConstraints()
		{
			short num = (short)436755185;
			short num2 = num;
			num = (short)1835424497;
			switch (num2 == num)
			{
			}
			num = (short)8126464;
			short num3 = num;
			num = (short)1198260225;
			if (num != 0)
			{
			}
			num = (short)196673536;
			if (num != 0)
			{
			}
			this.cnvSysDVRSTalkPermitTone_A40124.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSOutOfDVRSRangeTime_A40127.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSRespPendingTime_A40129.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSBusyUpdateTime_A40130.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSPTTWarningTime_A40131.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSForceUnmuteTime_A40138.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSAttachRetryTime_A40141.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSAttachRetries_A40142.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSEmerBlockInFS_A40143.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysFeatureDynRegroupZone_A40145.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSDynRegrIsEnabled);
			this.cnvSysFeatureDynRegroupZone_A40145.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSDynRegroupZoneIsValid);
			this.cnvSysFeatureDynRegroupZone_A40145.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysFeatureDynRegroupChannel_A40144.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSDynChlRegrIsEnabled);
			this.cnvSysFeatureDynRegroupChannel_A40144.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDVRSDynRegroupChannelIsValid);
			this.cnvSysFeatureDynRegroupChannel_A40144.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysFeatureDynRegroupEn_A40146.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysFeatureCallType_A40147.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSPhase2SysCompatibility_43000.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSDVRSyncNACMatching_44811.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysDVRSPreferTalkaroundInNoComms_44810.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSAndTAAttempsNotDisabled);
			this.cnvSysTalkaroundAudioModes_44812.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSAndTAAttempsNotDisabled);
			this.cnvSysTalkaroundAudioModes_44812.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConPhase2SystemCompatibilityIsEnabled);
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x00AAAF6C File Offset: 0x00AA916C
		public override void SetupDependencies()
		{
			short num = (short)855424919;
			short num2 = num;
			num = (short)1596374935;
			switch (num2 == num)
			{
			}
			num = (short)163840000;
			short num3 = num;
			num = (short)289406977;
			if (num != 0)
			{
			}
			num = (short)298713088;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSTalkPermitTone_A40124);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSOutOfDVRSRangeTime_A40127);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSRespPendingTime_A40129);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSBusyUpdateTime_A40130);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSPTTWarningTime_A40131);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSForceUnmuteTime_A40138);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSIndCallMaxTargetRingTime_A40139);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSAttachRetryTime_A40141);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSAttachRetries_A40142);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSEmerBlockInFS_A40143);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeatureDynRegroupZone_A40145);
			this.cnvSysFeatureDynRegroupEn_A40146.AddDependentObject(this.cnvSysFeatureDynRegroupZone_A40145);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeatureDynRegroupChannel_A40144);
			this.cnvSysFeatureDynRegroupEn_A40146.AddDependentObject(this.cnvSysFeatureDynRegroupChannel_A40144);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeatureDynRegroupEn_A40146);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysFeatureCallType_A40147);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSPhase2SysCompatibility_43000);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSPreferTalkaroundInNoComms_44810);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysDVRSDVRSyncNACMatching_44811);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysTalkaroundAudioModes_44812);
		}

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x0600B77D RID: 46973 RVA: 0x00AAB240 File Offset: 0x00AA9440
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForCnvSysFeatureDynRegroupZone_A40145
		{
			get
			{
				short num = (short)310196028;
				short num2 = num;
				num = (short)863844156;
				switch (num2 == num)
				{
				}
				num = (short)985071616;
				short num3 = num;
				num = (short)510263297;
				if (num != 0)
				{
				}
				num = (short)721354752;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x0600B77E RID: 46974 RVA: 0x00AAB2FC File Offset: 0x00AA94FC
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForCnvSysFeatureDynRegroupChannel_A40144
		{
			get
			{
				short num = (short)671350257;
				short num2 = num;
				num = (short)358350321;
				switch (num2 == num)
				{
				}
				num = (short)1107230720;
				short num3 = num;
				num = (short)1336279040;
				if (num != 0)
				{
				}
				num = (short)1507655681;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x0600B77F RID: 46975 RVA: 0x00AAB3B8 File Offset: 0x00AA95B8
		public bool HasDiffs
		{
			get
			{
				short num = (short)178388993;
				if (num != 0)
				{
				}
				num = (short)1872643253;
				short num2 = num;
				num = (short)763053237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043478016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298123264;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x00AAB464 File Offset: 0x00AA9664
		// (set) Token: 0x0600B781 RID: 46977 RVA: 0x00AAB518 File Offset: 0x00AA9718
		public bool CnvSysDVRSTalkPermitTone_A40124Value
		{
			get
			{
				short num = (short)495255553;
				if (num != 0)
				{
				}
				num = (short)573444042;
				short num2 = num;
				num = (short)1439240138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444792832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1533345792;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Value;
			}
			set
			{
				short num = (short)1723770601;
				short num2 = num;
				num = (short)1615505129;
				switch (num2 == num)
				{
				}
				num = (short)1905000448;
				short num3 = num;
				num = (short)21823489;
				if (num != 0)
				{
				}
				num = (short)1374617600;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Value = value;
			}
		}

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x0600B782 RID: 46978 RVA: 0x00AAB5CC File Offset: 0x00AA97CC
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSTalkPermitTone_A40124
		{
			get
			{
				short num = (short)736210048;
				short num2 = num;
				num = (short)57453696;
				switch (num2 == num)
				{
				}
				num = (short)326369280;
				short num3 = num;
				num = (short)1708326913;
				if (num != 0)
				{
				}
				num = (short)2021261312;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124;
			}
		}

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x0600B783 RID: 46979 RVA: 0x00AAB67C File Offset: 0x00AA987C
		// (set) Token: 0x0600B784 RID: 46980 RVA: 0x00AAB730 File Offset: 0x00AA9930
		public bool CnvSysDVRSTalkPermitTone_A40124_UIValue
		{
			get
			{
				short num = (short)308873574;
				short num2 = num;
				num = (short)622922086;
				switch (num2 == num)
				{
				}
				num = (short)839909376;
				short num3 = num;
				num = (short)1294204928;
				if (num != 0)
				{
				}
				num = (short)1429340161;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Value;
			}
			set
			{
				short num = (short)1998157850;
				short num2 = num;
				num = (short)753891354;
				switch (num2 == num)
				{
				}
				num = (short)221446144;
				short num3 = num;
				num = (short)1771962369;
				if (num != 0)
				{
				}
				num = (short)868941824;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Value = value;
			}
		}

		// Token: 0x17005BBA RID: 23482
		// (get) Token: 0x0600B785 RID: 46981 RVA: 0x00AAB7E8 File Offset: 0x00AA99E8
		// (set) Token: 0x0600B786 RID: 46982 RVA: 0x00AAB8A0 File Offset: 0x00AA9AA0
		public bool CnvSysDVRSTalkPermitTone_A40124_Applicable
		{
			get
			{
				short num = (short)515964929;
				if (num != 0)
				{
				}
				num = (short)1634311129;
				short num2 = num;
				num = (short)1600297945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499856896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1352990720;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Applicable;
			}
			set
			{
				short num = (short)498401281;
				if (num != 0)
				{
				}
				num = (short)102797347;
				short num2 = num;
				num = (short)935235619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1077149696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)998244352;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Applicable = value;
			}
		}

		// Token: 0x17005BBB RID: 23483
		// (get) Token: 0x0600B787 RID: 46983 RVA: 0x00AAB958 File Offset: 0x00AA9B58
		// (set) Token: 0x0600B788 RID: 46984 RVA: 0x00AABA0C File Offset: 0x00AA9C0C
		public bool CnvSysDVRSTalkPermitTone_A40124_Valid
		{
			get
			{
				short num = (short)1766912527;
				short num2 = num;
				num = (short)1327100431;
				switch (num2 == num)
				{
				}
				num = (short)473563136;
				short num3 = num;
				num = (short)519897089;
				if (num != 0)
				{
				}
				num = (short)830406656;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Valid;
			}
			set
			{
				short num = (short)1322838209;
				short num2 = num;
				num = (short)614197441;
				switch (num2 == num)
				{
				}
				num = (short)16318464;
				short num3 = num;
				num = (short)1721368576;
				if (num != 0)
				{
				}
				num = (short)213712897;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Valid = value;
			}
		}

		// Token: 0x17005BBC RID: 23484
		// (get) Token: 0x0600B789 RID: 46985 RVA: 0x00AABAC0 File Offset: 0x00AA9CC0
		// (set) Token: 0x0600B78A RID: 46986 RVA: 0x00AABB78 File Offset: 0x00AA9D78
		public bool CnvSysDVRSTalkPermitTone_A40124_Visible
		{
			get
			{
				short num = (short)855584912;
				short num2 = num;
				num = (short)2081763472;
				switch (num2 == num)
				{
				}
				num = (short)1035468800;
				short num3 = num;
				num = (short)661585921;
				if (num != 0)
				{
				}
				num = (short)1683423232;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Visible;
			}
			set
			{
				short num = (short)1519452161;
				if (num != 0)
				{
				}
				num = (short)1023763629;
				short num2 = num;
				num = (short)95642797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706819584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32964608;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Visible = value;
			}
		}

		// Token: 0x17005BBD RID: 23485
		// (get) Token: 0x0600B78B RID: 46987 RVA: 0x00AABC2C File Offset: 0x00AA9E2C
		// (set) Token: 0x0600B78C RID: 46988 RVA: 0x00AABCE0 File Offset: 0x00AA9EE0
		public bool CnvSysDVRSTalkPermitTone_A40124_Editable
		{
			get
			{
				short num = (short)1900177801;
				short num2 = num;
				num = (short)1266903433;
				switch (num2 == num)
				{
				}
				num = (short)1743519744;
				short num3 = num;
				num = (short)1905655809;
				if (num != 0)
				{
				}
				num = (short)1517092864;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.Editable;
			}
			set
			{
				short num = (short)1383621043;
				short num2 = num;
				num = (short)1439261107;
				switch (num2 == num)
				{
				}
				num = (short)10682368;
				short num3 = num;
				num = (short)266665985;
				if (num != 0)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.Editable = value;
			}
		}

		// Token: 0x17005BBE RID: 23486
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x00AABD94 File Offset: 0x00AA9F94
		internal string CnvSysDVRSTalkPermitTone_A40124_UILabel
		{
			get
			{
				short num = (short)516235137;
				short num2 = num;
				num = (short)219946881;
				switch (num2 == num)
				{
				}
				num = (short)293732352;
				short num3 = num;
				num = (short)156827649;
				if (num != 0)
				{
				}
				num = (short)1259012096;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.UIName;
			}
		}

		// Token: 0x17005BBF RID: 23487
		// (get) Token: 0x0600B78E RID: 46990 RVA: 0x00AABE48 File Offset: 0x00AAA048
		// (set) Token: 0x0600B78F RID: 46991 RVA: 0x00AABEFC File Offset: 0x00AAA0FC
		internal bool CnvSysDVRSTalkPermitTone_A40124_HiddenStatic
		{
			get
			{
				short num = (short)1428110450;
				short num2 = num;
				num = (short)1620982898;
				switch (num2 == num)
				{
				}
				num = (short)1518796800;
				short num3 = num;
				num = (short)1439105024;
				if (num != 0)
				{
				}
				num = (short)1019805697;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.HiddenStatic;
			}
			set
			{
				short num = (short)1932778558;
				short num2 = num;
				num = (short)1846664254;
				switch (num2 == num)
				{
				}
				num = (short)861274112;
				short num3 = num;
				num = (short)1914503169;
				if (num != 0)
				{
				}
				num = (short)786694144;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.HiddenStatic = value;
			}
		}

		// Token: 0x17005BC0 RID: 23488
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x00AABFB0 File Offset: 0x00AAA1B0
		// (set) Token: 0x0600B791 RID: 46993 RVA: 0x00AAC068 File Offset: 0x00AAA268
		internal bool CnvSysDVRSTalkPermitTone_A40124_HiddenDynamic
		{
			get
			{
				short num = (short)1721171969;
				if (num != 0)
				{
				}
				num = (short)400647438;
				short num2 = num;
				num = (short)1001874702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791347200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270008320;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124.HiddenDynamic;
			}
			set
			{
				short num = (short)1675061721;
				short num2 = num;
				num = (short)1718970841;
				switch (num2 == num)
				{
				}
				num = (short)489947136;
				short num3 = num;
				num = (short)708378625;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTalkPermitTone_A40124.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BC1 RID: 23489
		// (get) Token: 0x0600B792 RID: 46994 RVA: 0x00AAC120 File Offset: 0x00AAA320
		public bool CnvSysDVRSTalkPermitTone_A40124_HasDiffs
		{
			get
			{
				short num = (short)1526366636;
				short num2 = num;
				num = (short)22708652;
				switch (num2 == num)
				{
				}
				num = (short)2490368;
				short num3 = num;
				num = (short)1126498305;
				if (num != 0)
				{
				}
				num = (short)57737216;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTalkPermitTone_A40124._HasDiffs;
			}
		}

		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x0600B793 RID: 46995 RVA: 0x00AAC1D4 File Offset: 0x00AAA3D4
		// (set) Token: 0x0600B794 RID: 46996 RVA: 0x00AAC284 File Offset: 0x00AAA484
		public int CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125Value
		{
			get
			{
				short num = (short)394772804;
				short num2 = num;
				num = (short)1139917124;
				switch (num2 == num)
				{
				}
				num = (short)140771328;
				short num3 = num;
				num = (short)1352466433;
				if (num != 0)
				{
				}
				num = (short)279445504;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Value;
			}
			set
			{
				short num = (short)2094224355;
				short num2 = num;
				num = (short)1088771043;
				switch (num2 == num)
				{
				}
				num = (short)35782656;
				short num3 = num;
				num = (short)1480851457;
				if (num != 0)
				{
				}
				num = (short)534970368;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Value = value;
			}
		}

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x0600B795 RID: 46997 RVA: 0x00AAC33C File Offset: 0x00AAA53C
		// (set) Token: 0x0600B796 RID: 46998 RVA: 0x00AAC3F0 File Offset: 0x00AAA5F0
		public string CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_UIValue
		{
			get
			{
				short num = (short)301762634;
				short num2 = num;
				num = (short)1833207882;
				switch (num2 == num)
				{
				}
				num = (short)1793851392;
				short num3 = num;
				num = (short)540475393;
				if (num != 0)
				{
				}
				num = (short)875560960;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.UIValue;
			}
			set
			{
				short num = (short)1892824120;
				short num2 = num;
				num = (short)1283339320;
				switch (num2 == num)
				{
				}
				num = (short)1657405440;
				short num3 = num;
				num = (short)316866561;
				if (num != 0)
				{
				}
				num = (short)159383552;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.UIValue = value;
			}
		}

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x0600B797 RID: 46999 RVA: 0x00AAC4A4 File Offset: 0x00AAA6A4
		public global::AcpBusinessLayer.AcpListField CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125
		{
			get
			{
				short num = (short)1500973184;
				short num2 = num;
				num = (short)1410861184;
				switch (num2 == num)
				{
				}
				num = (short)487784448;
				short num3 = num;
				num = (short)28573697;
				if (num != 0)
				{
				}
				num = (short)768540672;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;
			}
		}

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x0600B798 RID: 47000 RVA: 0x00AAC558 File Offset: 0x00AAA758
		// (set) Token: 0x0600B799 RID: 47001 RVA: 0x00AAC60C File Offset: 0x00AAA80C
		public bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_Applicable
		{
			get
			{
				short num = (short)855423071;
				short num2 = num;
				num = (short)1575204959;
				switch (num2 == num)
				{
				}
				num = (short)364380160;
				short num3 = num;
				num = (short)2125201409;
				if (num != 0)
				{
				}
				num = (short)1544093696;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Applicable;
			}
			set
			{
				short num = (short)1483957686;
				short num2 = num;
				num = (short)1601070518;
				switch (num2 == num)
				{
				}
				num = (short)590872576;
				short num3 = num;
				num = (short)1111031809;
				if (num != 0)
				{
				}
				num = (short)334692352;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Applicable = value;
			}
		}

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x00AAC6C8 File Offset: 0x00AAA8C8
		// (set) Token: 0x0600B79B RID: 47003 RVA: 0x00AAC77C File Offset: 0x00AAA97C
		public bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_Valid
		{
			get
			{
				short num = (short)1528734900;
				short num2 = num;
				num = (short)111060148;
				switch (num2 == num)
				{
				}
				num = (short)718995456;
				short num3 = num;
				num = (short)670760960;
				if (num != 0)
				{
				}
				num = (short)1044905985;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Valid;
			}
			set
			{
				short num = (short)285824953;
				short num2 = num;
				num = (short)1778997177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761790464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925827072;
				if (num != 0)
				{
				}
				num = (short)978714625;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Valid = value;
			}
		}

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x0600B79C RID: 47004 RVA: 0x00AAC834 File Offset: 0x00AAAA34
		// (set) Token: 0x0600B79D RID: 47005 RVA: 0x00AAC8E8 File Offset: 0x00AAAAE8
		public bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_Visible
		{
			get
			{
				short num = (short)239067701;
				short num2 = num;
				num = (short)1933894197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558577152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207894017;
				if (num != 0)
				{
				}
				num = (short)1285357568;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Visible;
			}
			set
			{
				short num = (short)1713975618;
				short num2 = num;
				num = (short)930754882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085276160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757989377;
				if (num != 0)
				{
				}
				num = (short)2141847552;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Visible = value;
			}
		}

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x00AAC99C File Offset: 0x00AAAB9C
		// (set) Token: 0x0600B79F RID: 47007 RVA: 0x00AACA50 File Offset: 0x00AAAC50
		public bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_Editable
		{
			get
			{
				short num = (short)2065359339;
				short num2 = num;
				num = (short)1558176235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076690944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1620770817;
				if (num != 0)
				{
				}
				num = (short)767492096;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Editable;
			}
			set
			{
				short num = (short)1856176129;
				if (num != 0)
				{
				}
				num = (short)632815616;
				short num2 = num;
				num = (short)1655934431;
				short num3 = num;
				num = (short)1158254047;
				switch (num3 == num)
				{
				}
				num = (short)1656356864;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.Editable = value;
			}
		}

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x00AACB08 File Offset: 0x00AAAD08
		internal string CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_UILabel
		{
			get
			{
				short num = (short)295260116;
				short num2 = num;
				num = (short)1386958804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2031943680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)495779840;
				if (num != 0)
				{
				}
				num = (short)161873921;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.UIName;
			}
		}

		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x0600B7A1 RID: 47009 RVA: 0x00AACBC0 File Offset: 0x00AAADC0
		// (set) Token: 0x0600B7A2 RID: 47010 RVA: 0x00AACC74 File Offset: 0x00AAAE74
		internal bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_HiddenStatic
		{
			get
			{
				short num = (short)133203386;
				short num2 = num;
				num = (short)225281466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060255232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406061057;
				if (num != 0)
				{
				}
				num = (short)762970112;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.HiddenStatic;
			}
			set
			{
				short num = (short)456265731;
				short num2 = num;
				num = (short)1180962819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162412032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1702363137;
				if (num != 0)
				{
				}
				num = (short)2124349440;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.HiddenStatic = value;
			}
		}

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x00AACD2C File Offset: 0x00AAAF2C
		// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x00AACDE0 File Offset: 0x00AAAFE0
		internal bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_HiddenDynamic
		{
			get
			{
				short num = (short)137891022;
				short num2 = num;
				num = (short)282528974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1572864000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1655111681;
				if (num != 0)
				{
				}
				num = (short)1483931648;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.HiddenDynamic;
			}
			set
			{
				short num = (short)1024136410;
				short num2 = num;
				num = (short)1848251610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)839254016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)481296385;
				if (num != 0)
				{
				}
				num = (short)986316800;
				if (num != 0)
				{
				}
				this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x00AACE98 File Offset: 0x00AAB098
		public bool CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125_HasDiffs
		{
			get
			{
				short num = (short)1752793188;
				short num2 = num;
				num = (short)1099923556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355087872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1072103425;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125._HasDiffs;
			}
		}

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x00AACF50 File Offset: 0x00AAB150
		// (set) Token: 0x0600B7A7 RID: 47015 RVA: 0x00AAD008 File Offset: 0x00AAB208
		public int CnvSysDVRSOutOfDVRSRangeTime_A40127Value
		{
			get
			{
				short num = (short)1696333825;
				if (num != 0)
				{
				}
				num = (short)1655046144;
				short num2 = num;
				num = (short)1708973479;
				short num3 = num;
				num = (short)725015975;
				switch (num3 == num)
				{
				}
				num = (short)1311768576;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Value;
			}
			set
			{
				short num = (short)752360503;
				short num2 = num;
				num = (short)1635916855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031602176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761673217;
				if (num != 0)
				{
				}
				num = (short)1403125760;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Value = value;
			}
		}

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x00AAD0C0 File Offset: 0x00AAB2C0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSOutOfDVRSRangeTime_A40127
		{
			get
			{
				short num = (short)552665056;
				short num2 = num;
				num = (short)501153760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142109696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)86769664;
				if (num != 0)
				{
				}
				num = (short)727711745;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127;
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x00AAD170 File Offset: 0x00AAB370
		// (set) Token: 0x0600B7AA RID: 47018 RVA: 0x00AAD224 File Offset: 0x00AAB424
		public string CnvSysDVRSOutOfDVRSRangeTime_A40127_UIValue
		{
			get
			{
				short num = (short)1771372545;
				if (num != 0)
				{
				}
				num = (short)810614784;
				short num2 = num;
				num = (short)255692181;
				short num3 = num;
				num = (short)910658965;
				switch (num3 == num)
				{
				}
				num = (short)136642560;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.UIValue;
			}
			set
			{
				short num = (short)672859716;
				short num2 = num;
				num = (short)1570113092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96927744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440926208;
				if (num != 0)
				{
				}
				num = (short)123142145;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.UIValue = value;
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x00AAD2D8 File Offset: 0x00AAB4D8
		// (set) Token: 0x0600B7AC RID: 47020 RVA: 0x00AAD38C File Offset: 0x00AAB58C
		internal int CnvSysDVRSOutOfDVRSRangeTime_A40127Min
		{
			get
			{
				short num = (short)1873608705;
				if (num != 0)
				{
				}
				num = (short)1942814720;
				short num2 = num;
				num = (short)1665626407;
				short num3 = num;
				num = (short)1990816039;
				switch (num3 == num)
				{
				}
				num = (short)1342832640;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Min;
			}
			set
			{
				short num = (short)1487798273;
				if (num != 0)
				{
				}
				num = (short)227803136;
				short num2 = num;
				num = (short)1199057994;
				short num3 = num;
				num = (short)774712394;
				switch (num3 == num)
				{
				}
				num = (short)239534080;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Min = value;
			}
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x00AAD444 File Offset: 0x00AAB644
		// (set) Token: 0x0600B7AE RID: 47022 RVA: 0x00AAD4F8 File Offset: 0x00AAB6F8
		internal int CnvSysDVRSOutOfDVRSRangeTime_A40127Max
		{
			get
			{
				short num = (short)1378197921;
				short num2 = num;
				num = (short)119316897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)775487488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268842497;
				if (num != 0)
				{
				}
				num = (short)680919040;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Max;
			}
			set
			{
				short num = (short)961919117;
				short num2 = num;
				num = (short)64010381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095041024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059323905;
				if (num != 0)
				{
				}
				num = (short)167641088;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Max = value;
			}
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x0600B7AF RID: 47023 RVA: 0x00AAD5AC File Offset: 0x00AAB7AC
		// (set) Token: 0x0600B7B0 RID: 47024 RVA: 0x00AAD664 File Offset: 0x00AAB864
		internal int CnvSysDVRSOutOfDVRSRangeTime_A40127Step
		{
			get
			{
				short num = (short)1993385536;
				short num2 = num;
				num = (short)1033348672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074411008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)108265472;
				if (num != 0)
				{
				}
				num = (short)514064385;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.StepSize;
			}
			set
			{
				short num = (short)92409724;
				short num2 = num;
				num = (short)122752892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351090176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900871681;
				if (num != 0)
				{
				}
				num = (short)1031667712;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.StepSize = value;
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x0600B7B1 RID: 47025 RVA: 0x00AAD71C File Offset: 0x00AAB91C
		// (set) Token: 0x0600B7B2 RID: 47026 RVA: 0x00AAD7D0 File Offset: 0x00AAB9D0
		public bool CnvSysDVRSOutOfDVRSRangeTime_A40127_Applicable
		{
			get
			{
				short num = (short)1648360206;
				short num2 = num;
				num = (short)1677982478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239613440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1025835009;
				if (num != 0)
				{
				}
				num = (short)1522139136;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Applicable;
			}
			set
			{
				short num = (short)965998050;
				short num2 = num;
				num = (short)690157026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306984448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076625409;
				if (num != 0)
				{
				}
				num = (short)378077184;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Applicable = value;
			}
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x0600B7B3 RID: 47027 RVA: 0x00AAD888 File Offset: 0x00AABA88
		// (set) Token: 0x0600B7B4 RID: 47028 RVA: 0x00AAD93C File Offset: 0x00AABB3C
		public bool CnvSysDVRSOutOfDVRSRangeTime_A40127_Valid
		{
			get
			{
				short num = (short)1768554497;
				if (num != 0)
				{
				}
				num = (short)987299840;
				short num2 = num;
				num = (short)1424184766;
				short num3 = num;
				num = (short)332289470;
				switch (num3 == num)
				{
				}
				num = (short)1112670208;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Valid;
			}
			set
			{
				short num = (short)1914942864;
				short num2 = num;
				num = (short)991344016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1289814016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1466695680;
				if (num != 0)
				{
				}
				num = (short)1723203585;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Valid = value;
			}
		}

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x0600B7B5 RID: 47029 RVA: 0x00AAD9F0 File Offset: 0x00AABBF0
		// (set) Token: 0x0600B7B6 RID: 47030 RVA: 0x00AADAA4 File Offset: 0x00AABCA4
		public bool CnvSysDVRSOutOfDVRSRangeTime_A40127_Visible
		{
			get
			{
				short num = (short)515194028;
				short num2 = num;
				num = (short)611663020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135476736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1627848705;
				if (num != 0)
				{
				}
				num = (short)1490878464;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Visible;
			}
			set
			{
				short num = (short)1732767953;
				short num2 = num;
				num = (short)1354625233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837957120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179961857;
				if (num != 0)
				{
				}
				num = (short)1738473472;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Visible = value;
			}
		}

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x0600B7B7 RID: 47031 RVA: 0x00AADB58 File Offset: 0x00AABD58
		// (set) Token: 0x0600B7B8 RID: 47032 RVA: 0x00AADC0C File Offset: 0x00AABE0C
		public bool CnvSysDVRSOutOfDVRSRangeTime_A40127_Editable
		{
			get
			{
				short num = (short)1089111935;
				short num2 = num;
				num = (short)568756095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406861312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)691601409;
				if (num != 0)
				{
				}
				num = (short)1403650048;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Editable;
			}
			set
			{
				short num = (short)752710321;
				short num2 = num;
				num = (short)7959217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)814612480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307443201;
				if (num != 0)
				{
				}
				num = (short)1074135040;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.Editable = value;
			}
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x00AADCC4 File Offset: 0x00AABEC4
		internal string CnvSysDVRSOutOfDVRSRangeTime_A40127_UILabel
		{
			get
			{
				short num = (short)976397312;
				short num2 = num;
				num = (short)1821615104;
				switch (num2 == num)
				{
				}
				num = (short)1018298368;
				short num3 = num;
				num = (short)1160314880;
				if (num != 0)
				{
				}
				num = (short)1030750209;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.UIName;
			}
		}

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x0600B7BA RID: 47034 RVA: 0x00AADD7C File Offset: 0x00AABF7C
		// (set) Token: 0x0600B7BB RID: 47035 RVA: 0x00AADE30 File Offset: 0x00AAC030
		internal bool CnvSysDVRSOutOfDVRSRangeTime_A40127_HiddenStatic
		{
			get
			{
				short num = (short)305877254;
				short num2 = num;
				num = (short)1270960390;
				switch (num2 == num)
				{
				}
				num = (short)1472004096;
				short num3 = num;
				num = (short)1149435905;
				if (num != 0)
				{
				}
				num = (short)1963196416;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.HiddenStatic;
			}
			set
			{
				short num = (short)882184804;
				short num2 = num;
				num = (short)1626018404;
				switch (num2 == num)
				{
				}
				num = (short)1214316544;
				short num3 = num;
				num = (short)2094006272;
				if (num != 0)
				{
				}
				num = (short)476053505;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.HiddenStatic = value;
			}
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x00AADEE8 File Offset: 0x00AAC0E8
		// (set) Token: 0x0600B7BD RID: 47037 RVA: 0x00AADF9C File Offset: 0x00AAC19C
		internal bool CnvSysDVRSOutOfDVRSRangeTime_A40127_HiddenDynamic
		{
			get
			{
				short num = (short)722859812;
				short num2 = num;
				num = (short)2024011556;
				switch (num2 == num)
				{
				}
				num = (short)1762000896;
				short num3 = num;
				num = (short)524615681;
				if (num != 0)
				{
				}
				num = (short)793051136;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127.HiddenDynamic;
			}
			set
			{
				short num = (short)1153448041;
				short num2 = num;
				num = (short)906049641;
				switch (num2 == num)
				{
				}
				num = (short)521863168;
				short num3 = num;
				num = (short)560660481;
				if (num != 0)
				{
				}
				num = (short)1085210624;
				if (num != 0)
				{
				}
				this.cnvSysDVRSOutOfDVRSRangeTime_A40127.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x00AAE050 File Offset: 0x00AAC250
		public bool CnvSysDVRSOutOfDVRSRangeTime_A40127_HasDiffs
		{
			get
			{
				short num = (short)1997869017;
				short num2 = num;
				num = (short)1982009305;
				switch (num2 == num)
				{
				}
				num = (short)2081816576;
				short num3 = num;
				num = (short)1540161537;
				if (num != 0)
				{
				}
				num = (short)733478912;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSOutOfDVRSRangeTime_A40127._HasDiffs;
			}
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x00AAE104 File Offset: 0x00AAC304
		// (set) Token: 0x0600B7C0 RID: 47040 RVA: 0x00AAE1BC File Offset: 0x00AAC3BC
		public int CnvSysDVRSRespPendingTime_A40129Value
		{
			get
			{
				short num = (short)1475721086;
				short num2 = num;
				num = (short)1468249982;
				switch (num2 == num)
				{
				}
				num = (short)433913856;
				short num3 = num;
				num = (short)500957185;
				if (num != 0)
				{
				}
				num = (short)129695744;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Value;
			}
			set
			{
				short num = (short)172969637;
				short num2 = num;
				num = (short)157240997;
				switch (num2 == num)
				{
				}
				num = (short)1303838720;
				short num3 = num;
				num = (short)1349713921;
				if (num != 0)
				{
				}
				num = (short)1813184512;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Value = value;
			}
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x0600B7C1 RID: 47041 RVA: 0x00AAE274 File Offset: 0x00AAC474
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSRespPendingTime_A40129
		{
			get
			{
				short num = (short)45864653;
				short num2 = num;
				num = (short)1741936333;
				switch (num2 == num)
				{
				}
				num = (short)93716480;
				short num3 = num;
				num = (short)868548608;
				if (num != 0)
				{
				}
				num = (short)479723521;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129;
			}
		}

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x00AAE324 File Offset: 0x00AAC524
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x00AAE3DC File Offset: 0x00AAC5DC
		public string CnvSysDVRSRespPendingTime_A40129_UIValue
		{
			get
			{
				short num = (short)1574115764;
				short num2 = num;
				num = (short)1535056308;
				switch (num2 == num)
				{
				}
				num = (short)761856000;
				short num3 = num;
				num = (short)1696268289;
				if (num != 0)
				{
				}
				num = (short)2127233024;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.UIValue;
			}
			set
			{
				short num = (short)1761345537;
				if (num != 0)
				{
				}
				num = (short)1254087673;
				short num2 = num;
				num = (short)526048249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)263585792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)57671680;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.UIValue = value;
			}
		}

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x00AAE494 File Offset: 0x00AAC694
		// (set) Token: 0x0600B7C5 RID: 47045 RVA: 0x00AAE548 File Offset: 0x00AAC748
		internal int CnvSysDVRSRespPendingTime_A40129Min
		{
			get
			{
				short num = (short)1265241981;
				short num2 = num;
				num = (short)998313853;
				switch (num2 == num)
				{
				}
				num = (short)273547264;
				short num3 = num;
				num = (short)1626144769;
				if (num != 0)
				{
				}
				num = (short)780206080;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Min;
			}
			set
			{
				short num = (short)393031588;
				short num2 = num;
				num = (short)637939620;
				switch (num2 == num)
				{
				}
				num = (short)1897463808;
				short num3 = num;
				num = (short)1541013505;
				if (num != 0)
				{
				}
				num = (short)105709568;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Min = value;
			}
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x0600B7C6 RID: 47046 RVA: 0x00AAE5FC File Offset: 0x00AAC7FC
		// (set) Token: 0x0600B7C7 RID: 47047 RVA: 0x00AAE6B0 File Offset: 0x00AAC8B0
		internal int CnvSysDVRSRespPendingTime_A40129Max
		{
			get
			{
				short num = (short)311558145;
				if (num != 0)
				{
				}
				num = (short)1451345764;
				short num2 = num;
				num = (short)324716388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414922240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062076416;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Max;
			}
			set
			{
				short num = (short)1818813610;
				short num2 = num;
				num = (short)2053235882;
				switch (num2 == num)
				{
				}
				num = (short)32702464;
				short num3 = num;
				num = (short)10551297;
				if (num != 0)
				{
				}
				num = (short)1801256960;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Max = value;
			}
		}

		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x0600B7C8 RID: 47048 RVA: 0x00AAE764 File Offset: 0x00AAC964
		// (set) Token: 0x0600B7C9 RID: 47049 RVA: 0x00AAE814 File Offset: 0x00AACA14
		internal int CnvSysDVRSRespPendingTime_A40129Step
		{
			get
			{
				short num = (short)470322225;
				short num2 = num;
				num = (short)2088733745;
				switch (num2 == num)
				{
				}
				num = (short)264437760;
				short num3 = num;
				num = (short)1307443201;
				if (num != 0)
				{
				}
				num = (short)1278935040;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.StepSize;
			}
			set
			{
				short num = (short)19948916;
				short num2 = num;
				num = (short)335504756;
				switch (num2 == num)
				{
				}
				num = (short)1981939712;
				short num3 = num;
				num = (short)1984954368;
				if (num != 0)
				{
				}
				num = (short)1757544449;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.StepSize = value;
			}
		}

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x0600B7CA RID: 47050 RVA: 0x00AAE8CC File Offset: 0x00AACACC
		// (set) Token: 0x0600B7CB RID: 47051 RVA: 0x00AAE980 File Offset: 0x00AACB80
		public bool CnvSysDVRSRespPendingTime_A40129_Applicable
		{
			get
			{
				short num = (short)587186532;
				short num2 = num;
				num = (short)1138934116;
				switch (num2 == num)
				{
				}
				num = (short)307625984;
				short num3 = num;
				num = (short)1411907585;
				if (num != 0)
				{
				}
				num = (short)1963589632;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Applicable;
			}
			set
			{
				short num = (short)1364772430;
				short num2 = num;
				num = (short)1727514190;
				switch (num2 == num)
				{
				}
				num = (short)934871040;
				short num3 = num;
				num = (short)987037697;
				if (num != 0)
				{
				}
				num = (short)679804928;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Applicable = value;
			}
		}

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x0600B7CC RID: 47052 RVA: 0x00AAEA34 File Offset: 0x00AACC34
		// (set) Token: 0x0600B7CD RID: 47053 RVA: 0x00AAEAE8 File Offset: 0x00AACCE8
		public bool CnvSysDVRSRespPendingTime_A40129_Valid
		{
			get
			{
				short num = (short)1559134726;
				short num2 = num;
				num = (short)244089350;
				switch (num2 == num)
				{
				}
				num = (short)1367343104;
				short num3 = num;
				num = (short)1149632513;
				if (num != 0)
				{
				}
				num = (short)1661272064;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Valid;
			}
			set
			{
				short num = (short)1889846032;
				short num2 = num;
				num = (short)1422115600;
				switch (num2 == num)
				{
				}
				num = (short)1362231296;
				short num3 = num;
				num = (short)549060609;
				if (num != 0)
				{
				}
				num = (short)1083375616;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Valid = value;
			}
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x00AAEB9C File Offset: 0x00AACD9C
		// (set) Token: 0x0600B7CF RID: 47055 RVA: 0x00AAEC50 File Offset: 0x00AACE50
		public bool CnvSysDVRSRespPendingTime_A40129_Visible
		{
			get
			{
				short num = (short)1705172021;
				short num2 = num;
				num = (short)1163779125;
				switch (num2 == num)
				{
				}
				num = (short)1481965568;
				short num3 = num;
				num = (short)1943928833;
				if (num != 0)
				{
				}
				num = (short)1229193216;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Visible;
			}
			set
			{
				short num = (short)672929470;
				short num2 = num;
				num = (short)539498174;
				switch (num2 == num)
				{
				}
				num = (short)1986723840;
				short num3 = num;
				num = (short)2097610753;
				if (num != 0)
				{
				}
				num = (short)1072103424;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Visible = value;
			}
		}

		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x0600B7D0 RID: 47056 RVA: 0x00AAED08 File Offset: 0x00AACF08
		// (set) Token: 0x0600B7D1 RID: 47057 RVA: 0x00AAEDBC File Offset: 0x00AACFBC
		public bool CnvSysDVRSRespPendingTime_A40129_Editable
		{
			get
			{
				short num = (short)982756649;
				short num2 = num;
				num = (short)469871913;
				switch (num2 == num)
				{
				}
				num = (short)162988032;
				short num3 = num;
				num = (short)429457408;
				if (num != 0)
				{
				}
				num = (short)1533476865;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.Editable;
			}
			set
			{
				short num = (short)1509686900;
				short num2 = num;
				num = (short)861142644;
				switch (num2 == num)
				{
				}
				num = (short)1085800448;
				short num3 = num;
				num = (short)447807488;
				if (num != 0)
				{
				}
				num = (short)363003905;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.Editable = value;
			}
		}

		// Token: 0x17005BE5 RID: 23525
		// (get) Token: 0x0600B7D2 RID: 47058 RVA: 0x00AAEE6C File Offset: 0x00AAD06C
		internal string CnvSysDVRSRespPendingTime_A40129_UILabel
		{
			get
			{
				short num = (short)2032486461;
				short num2 = num;
				num = (short)397166653;
				switch (num2 == num)
				{
				}
				num = (short)655818752;
				short num3 = num;
				num = (short)1662779393;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.UIName;
			}
		}

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x0600B7D3 RID: 47059 RVA: 0x00AAEF24 File Offset: 0x00AAD124
		// (set) Token: 0x0600B7D4 RID: 47060 RVA: 0x00AAEFDC File Offset: 0x00AAD1DC
		internal bool CnvSysDVRSRespPendingTime_A40129_HiddenStatic
		{
			get
			{
				short num = (short)391702311;
				short num2 = num;
				num = (short)141616935;
				switch (num2 == num)
				{
				}
				num = (short)948305920;
				short num3 = num;
				num = (short)1205272577;
				if (num != 0)
				{
				}
				num = (short)1156120576;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.HiddenStatic;
			}
			set
			{
				short num = (short)816659295;
				short num2 = num;
				num = (short)584792927;
				switch (num2 == num)
				{
				}
				num = (short)816775168;
				short num3 = num;
				num = (short)1212809216;
				if (num != 0)
				{
				}
				num = (short)1874591745;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.HiddenStatic = value;
			}
		}

		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x00AAF090 File Offset: 0x00AAD290
		// (set) Token: 0x0600B7D6 RID: 47062 RVA: 0x00AAF144 File Offset: 0x00AAD344
		internal bool CnvSysDVRSRespPendingTime_A40129_HiddenDynamic
		{
			get
			{
				short num = (short)376081452;
				short num2 = num;
				num = (short)1806666796;
				switch (num2 == num)
				{
				}
				num = (short)466485248;
				short num3 = num;
				num = (short)1647837185;
				if (num != 0)
				{
				}
				num = (short)595066880;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129.HiddenDynamic;
			}
			set
			{
				short num = (short)115333199;
				short num2 = num;
				num = (short)577099855;
				switch (num2 == num)
				{
				}
				num = (short)1309278208;
				short num3 = num;
				num = (short)2121924609;
				if (num != 0)
				{
				}
				num = (short)32768000;
				if (num != 0)
				{
				}
				this.cnvSysDVRSRespPendingTime_A40129.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x00AAF1F8 File Offset: 0x00AAD3F8
		public bool CnvSysDVRSRespPendingTime_A40129_HasDiffs
		{
			get
			{
				short num = (short)202511143;
				short num2 = num;
				num = (short)954340135;
				switch (num2 == num)
				{
				}
				num = (short)160628736;
				short num3 = num;
				num = (short)74055681;
				if (num != 0)
				{
				}
				num = (short)479723520;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSRespPendingTime_A40129._HasDiffs;
			}
		}

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x00AAF2AC File Offset: 0x00AAD4AC
		// (set) Token: 0x0600B7D9 RID: 47065 RVA: 0x00AAF364 File Offset: 0x00AAD564
		public int CnvSysDVRSBusyUpdateTime_A40130Value
		{
			get
			{
				short num = (short)1001034984;
				short num2 = num;
				num = (short)800625896;
				switch (num2 == num)
				{
				}
				num = (short)1857355776;
				short num3 = num;
				num = (short)159711233;
				if (num != 0)
				{
				}
				num = (short)694484992;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Value;
			}
			set
			{
				short num = (short)4753540;
				short num2 = num;
				num = (short)1368819844;
				switch (num2 == num)
				{
				}
				num = (short)369426432;
				short num3 = num;
				num = (short)915210240;
				if (num != 0)
				{
				}
				num = (short)1166737409;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Value = value;
			}
		}

		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x00AAF418 File Offset: 0x00AAD618
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSBusyUpdateTime_A40130
		{
			get
			{
				short num = (short)1976867356;
				short num2 = num;
				num = (short)523147804;
				switch (num2 == num)
				{
				}
				num = (short)849543168;
				short num3 = num;
				num = (short)1658978305;
				if (num != 0)
				{
				}
				num = (short)1699086336;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130;
			}
		}

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x00AAF4C8 File Offset: 0x00AAD6C8
		// (set) Token: 0x0600B7DC RID: 47068 RVA: 0x00AAF580 File Offset: 0x00AAD780
		public string CnvSysDVRSBusyUpdateTime_A40130_UIValue
		{
			get
			{
				short num = (short)631861466;
				short num2 = num;
				num = (short)1658089690;
				switch (num2 == num)
				{
				}
				num = (short)736362496;
				short num3 = num;
				num = (short)497418241;
				if (num != 0)
				{
				}
				num = (short)489488384;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.UIValue;
			}
			set
			{
				short num = (short)1983250433;
				if (num != 0)
				{
				}
				num = (short)215625565;
				short num2 = num;
				num = (short)1946169181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37289984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869335040;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.UIValue = value;
			}
		}

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x0600B7DD RID: 47069 RVA: 0x00AAF634 File Offset: 0x00AAD834
		// (set) Token: 0x0600B7DE RID: 47070 RVA: 0x00AAF6E8 File Offset: 0x00AAD8E8
		internal int CnvSysDVRSBusyUpdateTime_A40130Min
		{
			get
			{
				short num = (short)962775874;
				short num2 = num;
				num = (short)899533634;
				switch (num2 == num)
				{
				}
				num = (short)1260322816;
				short num3 = num;
				num = (short)814612481;
				if (num != 0)
				{
				}
				num = (short)2131820544;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Min;
			}
			set
			{
				short num = (short)39265554;
				short num2 = num;
				num = (short)834807058;
				switch (num2 == num)
				{
				}
				num = (short)293208064;
				short num3 = num;
				num = (short)2062024705;
				if (num != 0)
				{
				}
				num = (short)1247477760;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Min = value;
			}
		}

		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x0600B7DF RID: 47071 RVA: 0x00AAF7A0 File Offset: 0x00AAD9A0
		// (set) Token: 0x0600B7E0 RID: 47072 RVA: 0x00AAF854 File Offset: 0x00AADA54
		internal int CnvSysDVRSBusyUpdateTime_A40130Max
		{
			get
			{
				short num = (short)1990641526;
				short num2 = num;
				num = (short)282969974;
				switch (num2 == num)
				{
				}
				num = (short)581435392;
				short num3 = num;
				num = (short)1377435649;
				if (num != 0)
				{
				}
				num = (short)691732480;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Max;
			}
			set
			{
				short num = (short)1049329084;
				short num2 = num;
				num = (short)152010172;
				switch (num2 == num)
				{
				}
				num = (short)440139776;
				short num3 = num;
				num = (short)1992753152;
				if (num != 0)
				{
				}
				num = (short)825491457;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Max = value;
			}
		}

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x00AAF908 File Offset: 0x00AADB08
		// (set) Token: 0x0600B7E2 RID: 47074 RVA: 0x00AAF9BC File Offset: 0x00AADBBC
		internal int CnvSysDVRSBusyUpdateTime_A40130Step
		{
			get
			{
				short num = (short)452480710;
				short num2 = num;
				num = (short)577261254;
				switch (num2 == num)
				{
				}
				num = (short)2128150528;
				short num3 = num;
				num = (short)822673409;
				if (num != 0)
				{
				}
				num = (short)574685184;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.StepSize;
			}
			set
			{
				short num = (short)1157046914;
				short num2 = num;
				num = (short)467608194;
				switch (num2 == num)
				{
				}
				num = (short)1589379072;
				short num3 = num;
				num = (short)556269568;
				if (num != 0)
				{
				}
				num = (short)881852417;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.StepSize = value;
			}
		}

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x0600B7E3 RID: 47075 RVA: 0x00AAFA70 File Offset: 0x00AADC70
		// (set) Token: 0x0600B7E4 RID: 47076 RVA: 0x00AAFB28 File Offset: 0x00AADD28
		public bool CnvSysDVRSBusyUpdateTime_A40130_Applicable
		{
			get
			{
				short num = (short)1377435648;
				short num2 = num;
				num = (short)843273596;
				short num3 = num;
				num = (short)1190417788;
				switch (num3 == num)
				{
				}
				num = (short)204996609;
				if (num != 0)
				{
				}
				num = (short)271253504;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Applicable;
			}
			set
			{
				short num = (short)763756544;
				short num2 = num;
				num = (short)1990625260;
				short num3 = num;
				num = (short)676038636;
				switch (num3 == num)
				{
				}
				num = (short)224395265;
				if (num != 0)
				{
				}
				num = (short)1582563328;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Applicable = value;
			}
		}

		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x0600B7E5 RID: 47077 RVA: 0x00AAFBDC File Offset: 0x00AADDDC
		// (set) Token: 0x0600B7E6 RID: 47078 RVA: 0x00AAFC94 File Offset: 0x00AADE94
		public bool CnvSysDVRSBusyUpdateTime_A40130_Valid
		{
			get
			{
				short num = (short)80281600;
				short num2 = num;
				num = (short)1483463827;
				short num3 = num;
				num = (short)1198382227;
				switch (num3 == num)
				{
				}
				num = (short)279379969;
				if (num != 0)
				{
				}
				num = (short)412483584;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Valid;
			}
			set
			{
				short num = (short)1539440640;
				short num2 = num;
				num = (short)1831442114;
				short num3 = num;
				num = (short)1177523906;
				switch (num3 == num)
				{
				}
				num = (short)1685061632;
				if (num != 0)
				{
				}
				num = (short)772603905;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Valid = value;
			}
		}

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x0600B7E7 RID: 47079 RVA: 0x00AAFD48 File Offset: 0x00AADF48
		// (set) Token: 0x0600B7E8 RID: 47080 RVA: 0x00AAFE00 File Offset: 0x00AAE000
		public bool CnvSysDVRSBusyUpdateTime_A40130_Visible
		{
			get
			{
				short num = (short)988545024;
				short num2 = num;
				num = (short)1843912664;
				short num3 = num;
				num = (short)649584600;
				switch (num3 == num)
				{
				}
				num = (short)152698880;
				if (num != 0)
				{
				}
				num = (short)1126039553;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Visible;
			}
			set
			{
				short num = (short)1819344896;
				short num2 = num;
				num = (short)1867002793;
				short num3 = num;
				num = (short)155071401;
				switch (num3 == num)
				{
				}
				num = (short)1293942785;
				if (num != 0)
				{
				}
				num = (short)314310656;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Visible = value;
			}
		}

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x0600B7E9 RID: 47081 RVA: 0x00AAFEB8 File Offset: 0x00AAE0B8
		// (set) Token: 0x0600B7EA RID: 47082 RVA: 0x00AAFF70 File Offset: 0x00AAE170
		public bool CnvSysDVRSBusyUpdateTime_A40130_Editable
		{
			get
			{
				short num = (short)230293504;
				short num2 = num;
				num = (short)625938744;
				short num3 = num;
				num = (short)572657976;
				switch (num3 == num)
				{
				}
				num = (short)972816384;
				if (num != 0)
				{
				}
				num = (short)1426849793;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.Editable;
			}
			set
			{
				short num = (short)133693440;
				short num2 = num;
				num = (short)2037238156;
				short num3 = num;
				num = (short)923388300;
				switch (num3 == num)
				{
				}
				num = (short)2080636928;
				if (num != 0)
				{
				}
				num = (short)1130692609;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.Editable = value;
			}
		}

		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x0600B7EB RID: 47083 RVA: 0x00AB0028 File Offset: 0x00AAE228
		internal string CnvSysDVRSBusyUpdateTime_A40130_UILabel
		{
			get
			{
				short num = (short)1093271552;
				short num2 = num;
				num = (short)404770843;
				short num3 = num;
				num = (short)2114211867;
				switch (num3 == num)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				num = (short)1651310593;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.UIName;
			}
		}

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x0600B7EC RID: 47084 RVA: 0x00AB00E0 File Offset: 0x00AAE2E0
		// (set) Token: 0x0600B7ED RID: 47085 RVA: 0x00AB0198 File Offset: 0x00AAE398
		internal bool CnvSysDVRSBusyUpdateTime_A40130_HiddenStatic
		{
			get
			{
				short num = (short)1334968320;
				short num2 = num;
				num = (short)137722696;
				short num3 = num;
				num = (short)325024584;
				switch (num3 == num)
				{
				}
				num = (short)1255342080;
				if (num != 0)
				{
				}
				num = (short)453967873;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.HiddenStatic;
			}
			set
			{
				short num = (short)2126708736;
				short num2 = num;
				num = (short)1071786627;
				short num3 = num;
				num = (short)653535875;
				switch (num3 == num)
				{
				}
				num = (short)1679818753;
				if (num != 0)
				{
				}
				num = (short)779812864;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.HiddenStatic = value;
			}
		}

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x0600B7EE RID: 47086 RVA: 0x00AB024C File Offset: 0x00AAE44C
		// (set) Token: 0x0600B7EF RID: 47087 RVA: 0x00AB02FC File Offset: 0x00AAE4FC
		internal bool CnvSysDVRSBusyUpdateTime_A40130_HiddenDynamic
		{
			get
			{
				short num = (short)1057226752;
				short num2 = num;
				num = (short)1535509880;
				short num3 = num;
				num = (short)459474296;
				switch (num3 == num)
				{
				}
				num = (short)1388969984;
				if (num != 0)
				{
				}
				num = (short)1735131137;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130.HiddenDynamic;
			}
			set
			{
				short num = (short)1659437056;
				short num2 = num;
				num = (short)508473249;
				short num3 = num;
				num = (short)271953825;
				switch (num3 == num)
				{
				}
				num = (short)1118961664;
				if (num != 0)
				{
				}
				num = (short)1183383553;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBusyUpdateTime_A40130.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x0600B7F0 RID: 47088 RVA: 0x00AB03B0 File Offset: 0x00AAE5B0
		public bool CnvSysDVRSBusyUpdateTime_A40130_HasDiffs
		{
			get
			{
				short num = (short)1603796992;
				short num2 = num;
				num = (short)1595262922;
				short num3 = num;
				num = (short)330614730;
				switch (num3 == num)
				{
				}
				num = (short)511770625;
				if (num != 0)
				{
				}
				num = (short)1881538560;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBusyUpdateTime_A40130._HasDiffs;
			}
		}

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x00AB0468 File Offset: 0x00AAE668
		// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x00AB051C File Offset: 0x00AAE71C
		public int CnvSysDVRSPTTWarningTime_A40131Value
		{
			get
			{
				short num = (short)1960837120;
				short num2 = num;
				num = (short)1916025416;
				short num3 = num;
				num = (short)1056782920;
				switch (num3 == num)
				{
				}
				num = (short)425656321;
				if (num != 0)
				{
				}
				num = (short)1787297792;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Value;
			}
			set
			{
				short num = (short)2047475712;
				short num2 = num;
				num = (short)18022401;
				if (num != 0)
				{
				}
				num = (short)73164091;
				short num3 = num;
				num = (short)943416635;
				switch (num3 == num)
				{
				}
				num = (short)155582464;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Value = value;
			}
		}

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x00AB05D0 File Offset: 0x00AAE7D0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSPTTWarningTime_A40131
		{
			get
			{
				short num = (short)994967552;
				short num2 = num;
				num = (short)1115224240;
				short num3 = num;
				num = (short)1510734000;
				switch (num3 == num)
				{
				}
				num = (short)433061889;
				if (num != 0)
				{
				}
				num = (short)1285750784;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131;
			}
		}

		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x0600B7F4 RID: 47092 RVA: 0x00AB0680 File Offset: 0x00AAE880
		// (set) Token: 0x0600B7F5 RID: 47093 RVA: 0x00AB0734 File Offset: 0x00AAE934
		public string CnvSysDVRSPTTWarningTime_A40131_UIValue
		{
			get
			{
				short num = (short)242483200;
				short num2 = num;
				num = (short)2086465580;
				short num3 = num;
				num = (short)2143350828;
				switch (num3 == num)
				{
				}
				num = (short)2104098816;
				if (num != 0)
				{
				}
				num = (short)392888321;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.UIValue;
			}
			set
			{
				short num = (short)597295104;
				short num2 = num;
				num = (short)333129906;
				short num3 = num;
				num = (short)1174284466;
				switch (num3 == num)
				{
				}
				num = (short)1354760193;
				if (num != 0)
				{
				}
				num = (short)1793130496;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.UIValue = value;
			}
		}

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x0600B7F6 RID: 47094 RVA: 0x00AB07E8 File Offset: 0x00AAE9E8
		// (set) Token: 0x0600B7F7 RID: 47095 RVA: 0x00AB089C File Offset: 0x00AAEA9C
		internal int CnvSysDVRSPTTWarningTime_A40131Min
		{
			get
			{
				short num = (short)1728446464;
				short num2 = num;
				num = (short)873233438;
				short num3 = num;
				num = (short)761625630;
				switch (num3 == num)
				{
				}
				num = (short)1207894017;
				if (num != 0)
				{
				}
				num = (short)1219821568;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Min;
			}
			set
			{
				short num = (short)906887168;
				short num2 = num;
				num = (short)800178808;
				short num3 = num;
				num = (short)1545585272;
				switch (num3 == num)
				{
				}
				num = (short)24182784;
				if (num != 0)
				{
				}
				num = (short)1438646273;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Min = value;
			}
		}

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x00AB0954 File Offset: 0x00AAEB54
		// (set) Token: 0x0600B7F9 RID: 47097 RVA: 0x00AB0A08 File Offset: 0x00AAEC08
		internal int CnvSysDVRSPTTWarningTime_A40131Max
		{
			get
			{
				short num = (short)1776484352;
				short num2 = num;
				num = (short)1220542077;
				short num3 = num;
				num = (short)517275261;
				switch (num3 == num)
				{
				}
				num = (short)2012872705;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Max;
			}
			set
			{
				short num = (short)867500032;
				short num2 = num;
				num = (short)98043533;
				short num3 = num;
				num = (short)813106829;
				switch (num3 == num)
				{
				}
				num = (short)1358233600;
				if (num != 0)
				{
				}
				num = (short)247267329;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Max = value;
			}
		}

		// Token: 0x17005BFC RID: 23548
		// (get) Token: 0x0600B7FA RID: 47098 RVA: 0x00AB0AC0 File Offset: 0x00AAECC0
		// (set) Token: 0x0600B7FB RID: 47099 RVA: 0x00AB0B74 File Offset: 0x00AAED74
		internal int CnvSysDVRSPTTWarningTime_A40131Step
		{
			get
			{
				short num = (short)1944780800;
				short num2 = num;
				num = (short)772097808;
				short num3 = num;
				num = (short)455755536;
				switch (num3 == num)
				{
				}
				num = (short)1886781441;
				if (num != 0)
				{
				}
				num = (short)74645504;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.StepSize;
			}
			set
			{
				short num = (short)8388608;
				short num2 = num;
				num = (short)1946257145;
				short num3 = num;
				num = (short)1190692601;
				switch (num3 == num)
				{
				}
				num = (short)972161025;
				if (num != 0)
				{
				}
				num = (short)1878982656;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.StepSize = value;
			}
		}

		// Token: 0x17005BFD RID: 23549
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x00AB0C2C File Offset: 0x00AAEE2C
		// (set) Token: 0x0600B7FD RID: 47101 RVA: 0x00AB0CE0 File Offset: 0x00AAEEE0
		public bool CnvSysDVRSPTTWarningTime_A40131_Applicable
		{
			get
			{
				short num = (short)329383936;
				short num2 = num;
				num = (short)1897136129;
				if (num != 0)
				{
				}
				num = (short)2036635015;
				short num3 = num;
				num = (short)1658361223;
				switch (num3 == num)
				{
				}
				num = (short)949026816;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Applicable;
			}
			set
			{
				short num = (short)2073624576;
				short num2 = num;
				num = (short)1124750986;
				short num3 = num;
				num = (short)1119049354;
				switch (num3 == num)
				{
				}
				num = (short)704643073;
				if (num != 0)
				{
				}
				num = (short)1162149888;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Applicable = value;
			}
		}

		// Token: 0x17005BFE RID: 23550
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x00AB0D94 File Offset: 0x00AAEF94
		// (set) Token: 0x0600B7FF RID: 47103 RVA: 0x00AB0E4C File Offset: 0x00AAF04C
		public bool CnvSysDVRSPTTWarningTime_A40131_Valid
		{
			get
			{
				short num = (short)410976256;
				short num2 = num;
				num = (short)811513164;
				short num3 = num;
				num = (short)2103686476;
				switch (num3 == num)
				{
				}
				num = (short)267321345;
				if (num != 0)
				{
				}
				num = (short)2019688448;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Valid;
			}
			set
			{
				short num = (short)1806696448;
				short num2 = num;
				num = (short)889651201;
				if (num != 0)
				{
				}
				num = (short)414105839;
				short num3 = num;
				num = (short)822722799;
				switch (num3 == num)
				{
				}
				num = (short)535035904;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Valid = value;
			}
		}

		// Token: 0x17005BFF RID: 23551
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x00AB0F04 File Offset: 0x00AAF104
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x00AB0FB8 File Offset: 0x00AAF1B8
		public bool CnvSysDVRSPTTWarningTime_A40131_Visible
		{
			get
			{
				short num = (short)1916993536;
				short num2 = num;
				num = (short)1446330466;
				short num3 = num;
				num = (short)2146386018;
				switch (num3 == num)
				{
				}
				num = (short)505282561;
				if (num != 0)
				{
				}
				num = (short)424804352;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Visible;
			}
			set
			{
				short num = (short)2092957696;
				short num2 = num;
				num = (short)1883175405;
				short num3 = num;
				num = (short)875756013;
				switch (num3 == num)
				{
				}
				num = (short)1127940096;
				if (num != 0)
				{
				}
				num = (short)884867073;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Visible = value;
			}
		}

		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x00AB1070 File Offset: 0x00AAF270
		// (set) Token: 0x0600B803 RID: 47107 RVA: 0x00AB1124 File Offset: 0x00AAF324
		public bool CnvSysDVRSPTTWarningTime_A40131_Editable
		{
			get
			{
				short num = (short)1195900928;
				short num2 = num;
				num = (short)2124957842;
				short num3 = num;
				num = (short)2078623890;
				switch (num3 == num)
				{
				}
				num = (short)1784283137;
				if (num != 0)
				{
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.Editable;
			}
			set
			{
				short num = (short)1197670400;
				short num2 = num;
				num = (short)438304769;
				if (num != 0)
				{
				}
				num = (short)2003186496;
				short num3 = num;
				num = (short)2120299328;
				switch (num3 == num)
				{
				}
				num = (short)418643968;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.Editable = value;
			}
		}

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x0600B804 RID: 47108 RVA: 0x00AB11D4 File Offset: 0x00AAF3D4
		internal string CnvSysDVRSPTTWarningTime_A40131_UILabel
		{
			get
			{
				short num = (short)801308672;
				short num2 = num;
				num = (short)1155244174;
				short num3 = num;
				num = (short)1532993678;
				switch (num3 == num)
				{
				}
				num = (short)380043265;
				if (num != 0)
				{
				}
				num = (short)1902247936;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.UIName;
			}
		}

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x0600B805 RID: 47109 RVA: 0x00AB1288 File Offset: 0x00AAF488
		// (set) Token: 0x0600B806 RID: 47110 RVA: 0x00AB1340 File Offset: 0x00AAF540
		internal bool CnvSysDVRSPTTWarningTime_A40131_HiddenStatic
		{
			get
			{
				short num = (short)1674969088;
				short num2 = num;
				num = (short)1173587641;
				short num3 = num;
				num = (short)1893238457;
				switch (num3 == num)
				{
				}
				num = (short)577437697;
				if (num != 0)
				{
				}
				num = (short)447873024;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.HiddenStatic;
			}
			set
			{
				short num = (short)2087583744;
				short num2 = num;
				num = (short)1829670609;
				short num3 = num;
				num = (short)1048612561;
				switch (num3 == num)
				{
				}
				num = (short)345309185;
				if (num != 0)
				{
				}
				num = (short)422248448;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.HiddenStatic = value;
			}
		}

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x0600B807 RID: 47111 RVA: 0x00AB13F8 File Offset: 0x00AAF5F8
		// (set) Token: 0x0600B808 RID: 47112 RVA: 0x00AB14AC File Offset: 0x00AAF6AC
		internal bool CnvSysDVRSPTTWarningTime_A40131_HiddenDynamic
		{
			get
			{
				short num = (short)1747517440;
				short num2 = num;
				num = (short)750440597;
				short num3 = num;
				num = (short)1531629717;
				switch (num3 == num)
				{
				}
				num = (short)1629552641;
				if (num != 0)
				{
				}
				num = (short)983171072;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131.HiddenDynamic;
			}
			set
			{
				short num = (short)1070923776;
				short num2 = num;
				num = (short)233963521;
				if (num != 0)
				{
				}
				num = (short)17000369;
				short num3 = num;
				num = (short)676620209;
				switch (num3 == num)
				{
				}
				num = (short)1377894400;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPTTWarningTime_A40131.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x0600B809 RID: 47113 RVA: 0x00AB1564 File Offset: 0x00AAF764
		public bool CnvSysDVRSPTTWarningTime_A40131_HasDiffs
		{
			get
			{
				short num = (short)1758068736;
				short num2 = num;
				num = (short)1589733477;
				short num3 = num;
				num = (short)1732405349;
				switch (num3 == num)
				{
				}
				num = (short)421593089;
				if (num != 0)
				{
				}
				num = (short)695140352;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPTTWarningTime_A40131._HasDiffs;
			}
		}

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x0600B80A RID: 47114 RVA: 0x00AB161C File Offset: 0x00AAF81C
		// (set) Token: 0x0600B80B RID: 47115 RVA: 0x00AB16D0 File Offset: 0x00AAF8D0
		public int CnvSysDVRSForceUnmuteTime_A40138Value
		{
			get
			{
				short num = (short)1642725377;
				if (num != 0)
				{
				}
				num = (short)454295552;
				short num2 = num;
				num = (short)1739436925;
				short num3 = num;
				num = (short)1279374205;
				switch (num3 == num)
				{
				}
				num = (short)1423572992;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Value;
			}
			set
			{
				short num = (short)1032650753;
				if (num != 0)
				{
				}
				num = (short)2024144896;
				short num2 = num;
				num = (short)1466378791;
				short num3 = num;
				num = (short)1379609127;
				switch (num3 == num)
				{
				}
				num = (short)187760640;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Value = value;
			}
		}

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x0600B80C RID: 47116 RVA: 0x00AB1784 File Offset: 0x00AAF984
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSForceUnmuteTime_A40138
		{
			get
			{
				short num = (short)581288608;
				short num2 = num;
				num = (short)1573438112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)826933248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208142337;
				if (num != 0)
				{
				}
				num = (short)434765824;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138;
			}
		}

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x0600B80D RID: 47117 RVA: 0x00AB1834 File Offset: 0x00AAFA34
		// (set) Token: 0x0600B80E RID: 47118 RVA: 0x00AB18E8 File Offset: 0x00AAFAE8
		public string CnvSysDVRSForceUnmuteTime_A40138_UIValue
		{
			get
			{
				short num = (short)1308133428;
				short num2 = num;
				num = (short)1636141108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2080571392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)555745281;
				if (num != 0)
				{
				}
				num = (short)693174272;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.UIValue;
			}
			set
			{
				short num = (short)1908316127;
				short num2 = num;
				num = (short)575969247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704249856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337327616;
				if (num != 0)
				{
				}
				num = (short)656867329;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.UIValue = value;
			}
		}

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x0600B80F RID: 47119 RVA: 0x00AB19A0 File Offset: 0x00AAFBA0
		// (set) Token: 0x0600B810 RID: 47120 RVA: 0x00AB1A58 File Offset: 0x00AAFC58
		internal int CnvSysDVRSForceUnmuteTime_A40138Min
		{
			get
			{
				short num = (short)1898801765;
				short num2 = num;
				num = (short)987261541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)835977216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55771137;
				if (num != 0)
				{
				}
				num = (short)818020352;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Min;
			}
			set
			{
				short num = (short)1027604481;
				if (num != 0)
				{
				}
				num = (short)791085056;
				short num2 = num;
				num = (short)1107460875;
				short num3 = num;
				num = (short)1115849483;
				switch (num3 == num)
				{
				}
				num = (short)2138767360;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Min = value;
			}
		}

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x0600B811 RID: 47121 RVA: 0x00AB1B14 File Offset: 0x00AAFD14
		// (set) Token: 0x0600B812 RID: 47122 RVA: 0x00AB1BC8 File Offset: 0x00AAFDC8
		internal int CnvSysDVRSForceUnmuteTime_A40138Max
		{
			get
			{
				short num = (short)602204795;
				short num2 = num;
				num = (short)1117907579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951189504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36634625;
				if (num != 0)
				{
				}
				num = (short)1770258432;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Max;
			}
			set
			{
				short num = (short)1795926287;
				short num2 = num;
				num = (short)446671119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767754240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169096705;
				if (num != 0)
				{
				}
				num = (short)509083648;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Max = value;
			}
		}

		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x0600B813 RID: 47123 RVA: 0x00AB1C7C File Offset: 0x00AAFE7C
		// (set) Token: 0x0600B814 RID: 47124 RVA: 0x00AB1D30 File Offset: 0x00AAFF30
		internal int CnvSysDVRSForceUnmuteTime_A40138Step
		{
			get
			{
				short num = (short)902690068;
				short num2 = num;
				num = (short)1514534164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979763200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1801322496;
				if (num != 0)
				{
				}
				num = (short)391708673;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.StepSize;
			}
			set
			{
				short num = (short)1765762566;
				short num2 = num;
				num = (short)1093887494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230307328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)855048193;
				if (num != 0)
				{
				}
				num = (short)253231104;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.StepSize = value;
			}
		}

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x0600B815 RID: 47125 RVA: 0x00AB1DE8 File Offset: 0x00AAFFE8
		// (set) Token: 0x0600B816 RID: 47126 RVA: 0x00AB1E9C File Offset: 0x00AB009C
		public bool CnvSysDVRSForceUnmuteTime_A40138_Applicable
		{
			get
			{
				short num = (short)478751842;
				short num2 = num;
				num = (short)2094935138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)821035008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)894959616;
				if (num != 0)
				{
				}
				num = (short)1590427649;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Applicable;
			}
			set
			{
				short num = (short)1682429770;
				short num2 = num;
				num = (short)635557706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847708160;
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
				num = (short)869335041;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Applicable = value;
			}
		}

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x0600B817 RID: 47127 RVA: 0x00AB1F50 File Offset: 0x00AB0150
		// (set) Token: 0x0600B818 RID: 47128 RVA: 0x00AB2004 File Offset: 0x00AB0204
		public bool CnvSysDVRSForceUnmuteTime_A40138_Valid
		{
			get
			{
				short num = (short)1073872897;
				if (num != 0)
				{
				}
				num = (short)328990720;
				short num2 = num;
				num = (short)1512264969;
				short num3 = num;
				num = (short)1216828681;
				switch (num3 == num)
				{
				}
				num = (short)1707868160;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Valid;
			}
			set
			{
				short num = (short)598266535;
				short num2 = num;
				num = (short)741659303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62390272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970601985;
				if (num != 0)
				{
				}
				num = (short)514588672;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Valid = value;
			}
		}

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x0600B819 RID: 47129 RVA: 0x00AB20BC File Offset: 0x00AB02BC
		// (set) Token: 0x0600B81A RID: 47130 RVA: 0x00AB2170 File Offset: 0x00AB0370
		public bool CnvSysDVRSForceUnmuteTime_A40138_Visible
		{
			get
			{
				short num = (short)740057097;
				short num2 = num;
				num = (short)460546057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165937152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)796327936;
				if (num != 0)
				{
				}
				num = (short)1621426177;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Visible;
			}
			set
			{
				short num = (short)173037310;
				short num2 = num;
				num = (short)1089820414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573584896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)446496768;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Visible = value;
			}
		}

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x0600B81B RID: 47131 RVA: 0x00AB2228 File Offset: 0x00AB0428
		// (set) Token: 0x0600B81C RID: 47132 RVA: 0x00AB22DC File Offset: 0x00AB04DC
		public bool CnvSysDVRSForceUnmuteTime_A40138_Editable
		{
			get
			{
				short num = (short)1675985247;
				short num2 = num;
				num = (short)1822064991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72941568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834797569;
				if (num != 0)
				{
				}
				num = (short)1399652352;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.Editable;
			}
			set
			{
				short num = (short)1935250819;
				short num2 = num;
				num = (short)1137022339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)450822144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688076288;
				if (num != 0)
				{
				}
				num = (short)1121189889;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.Editable = value;
			}
		}

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x0600B81D RID: 47133 RVA: 0x00AB2390 File Offset: 0x00AB0590
		internal string CnvSysDVRSForceUnmuteTime_A40138_UILabel
		{
			get
			{
				short num = (short)678367177;
				short num2 = num;
				num = (short)846139337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484259328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286995969;
				if (num != 0)
				{
				}
				num = (short)1947533312;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.UIName;
			}
		}

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x0600B81E RID: 47134 RVA: 0x00AB2448 File Offset: 0x00AB0648
		// (set) Token: 0x0600B81F RID: 47135 RVA: 0x00AB24FC File Offset: 0x00AB06FC
		internal bool CnvSysDVRSForceUnmuteTime_A40138_HiddenStatic
		{
			get
			{
				short num = (short)872958544;
				short num2 = num;
				num = (short)734349904;
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
				num = (short)1846607872;
				if (num != 0)
				{
				}
				num = (short)278134785;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.HiddenStatic;
			}
			set
			{
				short num = (short)2079251743;
				short num2 = num;
				num = (short)809229599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)73334784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382402560;
				if (num != 0)
				{
				}
				num = (short)473890817;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.HiddenStatic = value;
			}
		}

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x00AB25B4 File Offset: 0x00AB07B4
		// (set) Token: 0x0600B821 RID: 47137 RVA: 0x00AB2668 File Offset: 0x00AB0868
		internal bool CnvSysDVRSForceUnmuteTime_A40138_HiddenDynamic
		{
			get
			{
				short num = (short)484334571;
				short num2 = num;
				num = (short)381049835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626931200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)935133185;
				if (num != 0)
				{
				}
				num = (short)1110573056;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138.HiddenDynamic;
			}
			set
			{
				short num = (short)858392732;
				short num2 = num;
				num = (short)1307248796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109865984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970194945;
				if (num != 0)
				{
				}
				num = (short)763494400;
				if (num != 0)
				{
				}
				this.cnvSysDVRSForceUnmuteTime_A40138.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x00AB271C File Offset: 0x00AB091C
		public bool CnvSysDVRSForceUnmuteTime_A40138_HasDiffs
		{
			get
			{
				short num = (short)865210296;
				short num2 = num;
				num = (short)669388728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764687872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1379991553;
				if (num != 0)
				{
				}
				num = (short)1298464768;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSForceUnmuteTime_A40138._HasDiffs;
			}
		}

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x0600B823 RID: 47139 RVA: 0x00AB27D0 File Offset: 0x00AB09D0
		// (set) Token: 0x0600B824 RID: 47140 RVA: 0x00AB2884 File Offset: 0x00AB0A84
		public int CnvSysDVRSIndCallMaxTargetRingTime_A40139Value
		{
			get
			{
				short num = (short)622035290;
				short num2 = num;
				num = (short)1783660890;
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
				num = (short)873070592;
				if (num != 0)
				{
				}
				num = (short)1406533633;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Value;
			}
			set
			{
				short num = (short)1962140145;
				short num2 = num;
				num = (short)662626801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775960064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629880320;
				if (num != 0)
				{
				}
				num = (short)1370095617;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Value = value;
			}
		}

		// Token: 0x17005C14 RID: 23572
		// (get) Token: 0x0600B825 RID: 47141 RVA: 0x00AB2938 File Offset: 0x00AB0B38
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSIndCallMaxTargetRingTime_A40139
		{
			get
			{
				short num = (short)1319948856;
				short num2 = num;
				num = (short)184888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119761920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209584128;
				if (num != 0)
				{
				}
				num = (short)142934017;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139;
			}
		}

		// Token: 0x17005C15 RID: 23573
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x00AB29E4 File Offset: 0x00AB0BE4
		// (set) Token: 0x0600B827 RID: 47143 RVA: 0x00AB2A98 File Offset: 0x00AB0C98
		public string CnvSysDVRSIndCallMaxTargetRingTime_A40139_UIValue
		{
			get
			{
				short num = (short)955387666;
				short num2 = num;
				num = (short)1614679826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1490092032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523318785;
				if (num != 0)
				{
				}
				num = (short)858652672;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.UIValue;
			}
			set
			{
				short num = (short)231604225;
				if (num != 0)
				{
				}
				num = (short)94371840;
				short num2 = num;
				num = (short)974668049;
				short num3 = num;
				num = (short)461848849;
				switch (num3 == num)
				{
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.UIValue = value;
			}
		}

		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x0600B828 RID: 47144 RVA: 0x00AB2B50 File Offset: 0x00AB0D50
		// (set) Token: 0x0600B829 RID: 47145 RVA: 0x00AB2C04 File Offset: 0x00AB0E04
		internal int CnvSysDVRSIndCallMaxTargetRingTime_A40139Min
		{
			get
			{
				short num = (short)2029431671;
				short num2 = num;
				num = (short)543992695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)454688768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430847489;
				if (num != 0)
				{
				}
				num = (short)928055296;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Min;
			}
			set
			{
				short num = (short)1419220134;
				short num2 = num;
				num = (short)608801958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1067712512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716111873;
				if (num != 0)
				{
				}
				num = (short)2077097984;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Min = value;
			}
		}

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x0600B82A RID: 47146 RVA: 0x00AB2CB8 File Offset: 0x00AB0EB8
		// (set) Token: 0x0600B82B RID: 47147 RVA: 0x00AB2D6C File Offset: 0x00AB0F6C
		internal int CnvSysDVRSIndCallMaxTargetRingTime_A40139Max
		{
			get
			{
				short num = (short)1341034750;
				short num2 = num;
				num = (short)1555534078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233190912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696582145;
				if (num != 0)
				{
				}
				num = (short)1424949248;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Max;
			}
			set
			{
				short num = (short)1537771463;
				short num2 = num;
				num = (short)462718919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951123968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549453825;
				if (num != 0)
				{
				}
				num = (short)776077312;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Max = value;
			}
		}

		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x0600B82C RID: 47148 RVA: 0x00AB2E20 File Offset: 0x00AB1020
		// (set) Token: 0x0600B82D RID: 47149 RVA: 0x00AB2ED8 File Offset: 0x00AB10D8
		internal int CnvSysDVRSIndCallMaxTargetRingTime_A40139Step
		{
			get
			{
				short num = (short)846558516;
				short num2 = num;
				num = (short)2007528756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074935296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1411055617;
				if (num != 0)
				{
				}
				num = (short)1426325504;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.StepSize;
			}
			set
			{
				short num = (short)563958263;
				short num2 = num;
				num = (short)1592349175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684457984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758513665;
				if (num != 0)
				{
				}
				num = (short)1149566976;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.StepSize = value;
			}
		}

		// Token: 0x17005C19 RID: 23577
		// (get) Token: 0x0600B82E RID: 47150 RVA: 0x00AB2F90 File Offset: 0x00AB1190
		// (set) Token: 0x0600B82F RID: 47151 RVA: 0x00AB3044 File Offset: 0x00AB1244
		public bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_Applicable
		{
			get
			{
				short num = (short)1255997400;
				short num2 = num;
				num = (short)1560477656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408944640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469696513;
				if (num != 0)
				{
				}
				num = (short)273940480;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Applicable;
			}
			set
			{
				short num = (short)1794113537;
				if (num != 0)
				{
				}
				num = (short)478085120;
				short num2 = num;
				num = (short)244348489;
				short num3 = num;
				num = (short)1202812489;
				switch (num3 == num)
				{
				}
				num = (short)1757282304;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Applicable = value;
			}
		}

		// Token: 0x17005C1A RID: 23578
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x00AB30FC File Offset: 0x00AB12FC
		// (set) Token: 0x0600B831 RID: 47153 RVA: 0x00AB31B0 File Offset: 0x00AB13B0
		public bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_Valid
		{
			get
			{
				short num = (short)1256746669;
				short num2 = num;
				num = (short)1844407981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1779564544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149566977;
				if (num != 0)
				{
				}
				num = (short)399310848;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Valid;
			}
			set
			{
				short num = (short)29547690;
				short num2 = num;
				num = (short)1010883754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202061312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)650379265;
				if (num != 0)
				{
				}
				num = (short)682688512;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Valid = value;
			}
		}

		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x0600B832 RID: 47154 RVA: 0x00AB3264 File Offset: 0x00AB1464
		// (set) Token: 0x0600B833 RID: 47155 RVA: 0x00AB331C File Offset: 0x00AB151C
		public bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_Visible
		{
			get
			{
				short num = (short)972161025;
				if (num != 0)
				{
				}
				num = (short)1925382144;
				short num2 = num;
				num = (short)662045678;
				short num3 = num;
				num = (short)840696814;
				switch (num3 == num)
				{
				}
				num = (short)967114752;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Visible;
			}
			set
			{
				short num = (short)266840844;
				short num2 = num;
				num = (short)188590860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)852361216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602669057;
				if (num != 0)
				{
				}
				num = (short)1691680768;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Visible = value;
			}
		}

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x00AB33D4 File Offset: 0x00AB15D4
		// (set) Token: 0x0600B835 RID: 47157 RVA: 0x00AB348C File Offset: 0x00AB168C
		public bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_Editable
		{
			get
			{
				short num = (short)1796451706;
				short num2 = num;
				num = (short)597011834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051538944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189609473;
				if (num != 0)
				{
				}
				num = (short)1504575488;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Editable;
			}
			set
			{
				short num = (short)1729675320;
				short num2 = num;
				num = (short)1901576248;
				switch (num2 == num)
				{
				}
				num = (short)1600126976;
				short num3 = num;
				num = (short)2086535169;
				if (num != 0)
				{
				}
				num = (short)376963072;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.Editable = value;
			}
		}

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x00AB3540 File Offset: 0x00AB1740
		internal string CnvSysDVRSIndCallMaxTargetRingTime_A40139_UILabel
		{
			get
			{
				short num = (short)573790952;
				short num2 = num;
				num = (short)1683643112;
				switch (num2 == num)
				{
				}
				num = (short)297861120;
				short num3 = num;
				num = (short)1775108096;
				if (num != 0)
				{
				}
				num = (short)17104897;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.UIName;
			}
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x0600B837 RID: 47159 RVA: 0x00AB35F8 File Offset: 0x00AB17F8
		// (set) Token: 0x0600B838 RID: 47160 RVA: 0x00AB36B0 File Offset: 0x00AB18B0
		internal bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_HiddenStatic
		{
			get
			{
				short num = (short)503518207;
				short num2 = num;
				num = (short)1420235775;
				switch (num2 == num)
				{
				}
				num = (short)1395916800;
				short num3 = num;
				num = (short)1562247168;
				if (num != 0)
				{
				}
				num = (short)1069350913;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.HiddenStatic;
			}
			set
			{
				short num = (short)1529553571;
				short num2 = num;
				num = (short)837755555;
				switch (num2 == num)
				{
				}
				num = (short)287965184;
				short num3 = num;
				num = (short)1450311681;
				if (num != 0)
				{
				}
				num = (short)845152256;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.HiddenStatic = value;
			}
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x0600B839 RID: 47161 RVA: 0x00AB3768 File Offset: 0x00AB1968
		// (set) Token: 0x0600B83A RID: 47162 RVA: 0x00AB381C File Offset: 0x00AB1A1C
		internal bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_HiddenDynamic
		{
			get
			{
				short num = (short)324858760;
				short num2 = num;
				num = (short)944960392;
				switch (num2 == num)
				{
				}
				num = (short)956497920;
				short num3 = num;
				num = (short)1343750145;
				if (num != 0)
				{
				}
				num = (short)1963130880;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.HiddenDynamic;
			}
			set
			{
				short num = (short)89022616;
				short num2 = num;
				num = (short)329343128;
				switch (num2 == num)
				{
				}
				num = (short)492896256;
				short num3 = num;
				num = (short)513343488;
				if (num != 0)
				{
				}
				num = (short)784334849;
				if (num != 0)
				{
				}
				this.cnvSysDVRSIndCallMaxTargetRingTime_A40139.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x0600B83B RID: 47163 RVA: 0x00AB38D4 File Offset: 0x00AB1AD4
		public bool CnvSysDVRSIndCallMaxTargetRingTime_A40139_HasDiffs
		{
			get
			{
				short num = (short)812269700;
				short num2 = num;
				num = (short)1627472004;
				switch (num2 == num)
				{
				}
				num = (short)1106837504;
				short num3 = num;
				num = (short)828637185;
				if (num != 0)
				{
				}
				num = (short)869138432;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSIndCallMaxTargetRingTime_A40139._HasDiffs;
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x0600B83C RID: 47164 RVA: 0x00AB3988 File Offset: 0x00AB1B88
		// (set) Token: 0x0600B83D RID: 47165 RVA: 0x00AB3A3C File Offset: 0x00AB1C3C
		public int CnvSysDVRSPrivateCallMaxInitRingTime_A40140Value
		{
			get
			{
				short num = (short)1366110138;
				short num2 = num;
				num = (short)2005938106;
				switch (num2 == num)
				{
				}
				num = (short)1337327616;
				short num3 = num;
				num = (short)315228161;
				if (num != 0)
				{
				}
				num = (short)646905856;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Value;
			}
			set
			{
				short num = (short)151063921;
				short num2 = num;
				num = (short)1501236593;
				switch (num2 == num)
				{
				}
				num = (short)336265216;
				short num3 = num;
				num = (short)418250752;
				if (num != 0)
				{
				}
				num = (short)1972436993;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Value = value;
			}
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x0600B83E RID: 47166 RVA: 0x00AB3AF4 File Offset: 0x00AB1CF4
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSPrivateCallMaxInitRingTime_A40140
		{
			get
			{
				short num = (short)782318353;
				short num2 = num;
				num = (short)634010385;
				switch (num2 == num)
				{
				}
				num = (short)1478754304;
				short num3 = num;
				num = (short)1291583489;
				if (num != 0)
				{
				}
				num = (short)1402011648;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140;
			}
		}

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x0600B83F RID: 47167 RVA: 0x00AB3BA0 File Offset: 0x00AB1DA0
		// (set) Token: 0x0600B840 RID: 47168 RVA: 0x00AB3C54 File Offset: 0x00AB1E54
		public string CnvSysDVRSPrivateCallMaxInitRingTime_A40140_UIValue
		{
			get
			{
				short num = (short)1679316968;
				short num2 = num;
				num = (short)990861288;
				switch (num2 == num)
				{
				}
				num = (short)1371013120;
				short num3 = num;
				num = (short)1664745473;
				if (num != 0)
				{
				}
				num = (short)1642266624;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.UIValue;
			}
			set
			{
				short num = (short)2075008533;
				short num2 = num;
				num = (short)207101461;
				switch (num2 == num)
				{
				}
				num = (short)1593573376;
				short num3 = num;
				num = (short)1226440704;
				if (num != 0)
				{
				}
				num = (short)770441217;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.UIValue = value;
			}
		}

		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x0600B841 RID: 47169 RVA: 0x00AB3D08 File Offset: 0x00AB1F08
		// (set) Token: 0x0600B842 RID: 47170 RVA: 0x00AB3DC0 File Offset: 0x00AB1FC0
		internal int CnvSysDVRSPrivateCallMaxInitRingTime_A40140Min
		{
			get
			{
				short num = (short)954717790;
				short num2 = num;
				num = (short)777836126;
				switch (num2 == num)
				{
				}
				num = (short)523763712;
				short num3 = num;
				num = (short)1327824897;
				if (num != 0)
				{
				}
				num = (short)257032192;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Min;
			}
			set
			{
				short num = (short)368823867;
				short num2 = num;
				num = (short)1464913467;
				switch (num2 == num)
				{
				}
				num = (short)1052377088;
				short num3 = num;
				num = (short)246808577;
				if (num != 0)
				{
				}
				num = (short)1991049216;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Min = value;
			}
		}

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x0600B843 RID: 47171 RVA: 0x00AB3E7C File Offset: 0x00AB207C
		// (set) Token: 0x0600B844 RID: 47172 RVA: 0x00AB3F34 File Offset: 0x00AB2134
		internal int CnvSysDVRSPrivateCallMaxInitRingTime_A40140Max
		{
			get
			{
				short num = (short)1734064643;
				short num2 = num;
				num = (short)1967503875;
				switch (num2 == num)
				{
				}
				num = (short)1079771136;
				short num3 = num;
				num = (short)188022784;
				if (num != 0)
				{
				}
				num = (short)119865345;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Max;
			}
			set
			{
				short num = (short)321091707;
				short num2 = num;
				num = (short)1910995067;
				switch (num2 == num)
				{
				}
				num = (short)1063714816;
				short num3 = num;
				num = (short)1520369665;
				if (num != 0)
				{
				}
				num = (short)29294592;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Max = value;
			}
		}

		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x00AB3FEC File Offset: 0x00AB21EC
		// (set) Token: 0x0600B846 RID: 47174 RVA: 0x00AB409C File Offset: 0x00AB229C
		internal int CnvSysDVRSPrivateCallMaxInitRingTime_A40140Step
		{
			get
			{
				short num = (short)1011286017;
				if (num != 0)
				{
				}
				num = (short)498079365;
				short num2 = num;
				num = (short)386799237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1692401664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330760192;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.StepSize;
			}
			set
			{
				short num = (short)634882164;
				short num2 = num;
				num = (short)1901168756;
				switch (num2 == num)
				{
				}
				num = (short)135790592;
				short num3 = num;
				num = (short)1298792449;
				if (num != 0)
				{
				}
				num = (short)1159200768;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.StepSize = value;
			}
		}

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x0600B847 RID: 47175 RVA: 0x00AB4158 File Offset: 0x00AB2358
		// (set) Token: 0x0600B848 RID: 47176 RVA: 0x00AB420C File Offset: 0x00AB240C
		public bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_Applicable
		{
			get
			{
				short num = (short)1180610770;
				short num2 = num;
				num = (short)2133962962;
				switch (num2 == num)
				{
				}
				num = (short)552599552;
				short num3 = num;
				num = (short)1648689153;
				if (num != 0)
				{
				}
				num = (short)1980432384;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Applicable;
			}
			set
			{
				short num = (short)1205010433;
				if (num != 0)
				{
				}
				num = (short)29350760;
				short num2 = num;
				num = (short)1175051112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)522977280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)459997184;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Applicable = value;
			}
		}

		// Token: 0x17005C28 RID: 23592
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x00AB42C4 File Offset: 0x00AB24C4
		// (set) Token: 0x0600B84A RID: 47178 RVA: 0x00AB4378 File Offset: 0x00AB2578
		public bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_Valid
		{
			get
			{
				short num = (short)1905852417;
				if (num != 0)
				{
				}
				num = (short)1903257598;
				short num2 = num;
				num = (short)1559652350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694040064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024786432;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Valid;
			}
			set
			{
				short num = (short)1759332765;
				short num2 = num;
				num = (short)55265693;
				switch (num2 == num)
				{
				}
				num = (short)99876864;
				short num3 = num;
				num = (short)1301217281;
				if (num != 0)
				{
				}
				num = (short)941031424;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Valid = value;
			}
		}

		// Token: 0x17005C29 RID: 23593
		// (get) Token: 0x0600B84B RID: 47179 RVA: 0x00AB4430 File Offset: 0x00AB2630
		// (set) Token: 0x0600B84C RID: 47180 RVA: 0x00AB44E4 File Offset: 0x00AB26E4
		public bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_Visible
		{
			get
			{
				short num = (short)996921696;
				short num2 = num;
				num = (short)1456591200;
				switch (num2 == num)
				{
				}
				num = (short)2014117888;
				short num3 = num;
				num = (short)1215889409;
				if (num != 0)
				{
				}
				num = (short)851771392;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Visible;
			}
			set
			{
				short num = (short)1272159075;
				short num2 = num;
				num = (short)200186723;
				switch (num2 == num)
				{
				}
				num = (short)149159936;
				short num3 = num;
				num = (short)372441089;
				if (num != 0)
				{
				}
				num = (short)1166016512;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Visible = value;
			}
		}

		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x0600B84D RID: 47181 RVA: 0x00AB4598 File Offset: 0x00AB2798
		// (set) Token: 0x0600B84E RID: 47182 RVA: 0x00AB4650 File Offset: 0x00AB2850
		public bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_Editable
		{
			get
			{
				short num = (short)327700355;
				short num2 = num;
				num = (short)2084786051;
				switch (num2 == num)
				{
				}
				num = (short)1965293568;
				short num3 = num;
				num = (short)1450704897;
				if (num != 0)
				{
				}
				num = (short)1747845120;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Editable;
			}
			set
			{
				short num = (short)351395797;
				short num2 = num;
				num = (short)1297539029;
				switch (num2 == num)
				{
				}
				num = (short)1450115072;
				short num3 = num;
				num = (short)1103757313;
				if (num != 0)
				{
				}
				num = (short)1477181440;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.Editable = value;
			}
		}

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x0600B84F RID: 47183 RVA: 0x00AB4708 File Offset: 0x00AB2908
		internal string CnvSysDVRSPrivateCallMaxInitRingTime_A40140_UILabel
		{
			get
			{
				short num = (short)936673456;
				short num2 = num;
				num = (short)518226096;
				switch (num2 == num)
				{
				}
				num = (short)1565458432;
				short num3 = num;
				num = (short)424738816;
				if (num != 0)
				{
				}
				num = (short)1990787073;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.UIName;
			}
		}

		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x00AB47C0 File Offset: 0x00AB29C0
		// (set) Token: 0x0600B851 RID: 47185 RVA: 0x00AB4874 File Offset: 0x00AB2A74
		internal bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_HiddenStatic
		{
			get
			{
				short num = (short)317980672;
				short num2 = num;
				num = (short)1905418288;
				short num3 = num;
				num = (short)628908080;
				switch (num3 == num)
				{
				}
				num = (short)1168506881;
				if (num != 0)
				{
				}
				num = (short)240648192;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.HiddenStatic;
			}
			set
			{
				short num = (short)970260480;
				short num2 = num;
				num = (short)368107701;
				short num3 = num;
				num = (short)1048174773;
				switch (num3 == num)
				{
				}
				num = (short)779943937;
				if (num != 0)
				{
				}
				num = (short)1485438976;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.HiddenStatic = value;
			}
		}

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x0600B852 RID: 47186 RVA: 0x00AB4928 File Offset: 0x00AB2B28
		// (set) Token: 0x0600B853 RID: 47187 RVA: 0x00AB49DC File Offset: 0x00AB2BDC
		internal bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_HiddenDynamic
		{
			get
			{
				short num = (short)1555103744;
				short num2 = num;
				num = (short)1948324530;
				short num3 = num;
				num = (short)1062343346;
				switch (num3 == num)
				{
				}
				num = (short)1484193793;
				if (num != 0)
				{
				}
				num = (short)1084620800;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.HiddenDynamic;
			}
			set
			{
				short num = (short)75825152;
				short num2 = num;
				num = (short)1131329752;
				short num3 = num;
				num = (short)1077262552;
				switch (num3 == num)
				{
				}
				num = (short)2009006081;
				if (num != 0)
				{
				}
				num = (short)2000158720;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x0600B854 RID: 47188 RVA: 0x00AB4A90 File Offset: 0x00AB2C90
		public bool CnvSysDVRSPrivateCallMaxInitRingTime_A40140_HasDiffs
		{
			get
			{
				short num = (short)1472724992;
				short num2 = num;
				num = (short)1922108378;
				short num3 = num;
				num = (short)720636890;
				switch (num3 == num)
				{
				}
				num = (short)580124673;
				if (num != 0)
				{
				}
				num = (short)396558336;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPrivateCallMaxInitRingTime_A40140._HasDiffs;
			}
		}

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x0600B855 RID: 47189 RVA: 0x00AB4B44 File Offset: 0x00AB2D44
		// (set) Token: 0x0600B856 RID: 47190 RVA: 0x00AB4BF8 File Offset: 0x00AB2DF8
		public int CnvSysDVRSAttachRetryTime_A40141Value
		{
			get
			{
				short num = (short)2079260672;
				short num2 = num;
				num = (short)605593412;
				short num3 = num;
				num = (short)97754948;
				switch (num3 == num)
				{
				}
				num = (short)1397489665;
				if (num != 0)
				{
				}
				num = (short)876937216;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Value;
			}
			set
			{
				short num = (short)1285816320;
				short num2 = num;
				num = (short)1132605348;
				short num3 = num;
				num = (short)949563300;
				switch (num3 == num)
				{
				}
				num = (short)1709441025;
				if (num != 0)
				{
				}
				num = (short)577503232;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Value = value;
			}
		}

		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x00AB4CAC File Offset: 0x00AB2EAC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSAttachRetryTime_A40141
		{
			get
			{
				short num = (short)1881210880;
				short num2 = num;
				num = (short)748814337;
				if (num != 0)
				{
				}
				num = (short)118201267;
				short num3 = num;
				num = (short)523410355;
				switch (num3 == num)
				{
				}
				num = (short)1349910528;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141;
			}
		}

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x00AB4D60 File Offset: 0x00AB2F60
		// (set) Token: 0x0600B859 RID: 47193 RVA: 0x00AB4E14 File Offset: 0x00AB3014
		public string CnvSysDVRSAttachRetryTime_A40141_UIValue
		{
			get
			{
				short num = (short)1299054592;
				short num2 = num;
				num = (short)928951732;
				short num3 = num;
				num = (short)1886760372;
				switch (num3 == num)
				{
				}
				num = (short)824705025;
				if (num != 0)
				{
				}
				num = (short)1156317184;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.UIValue;
			}
			set
			{
				short num = (short)2066022400;
				short num2 = num;
				num = (short)1366358969;
				short num3 = num;
				num = (short)289078201;
				switch (num3 == num)
				{
				}
				num = (short)1472462849;
				if (num != 0)
				{
				}
				num = (short)2036334592;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.UIValue = value;
			}
		}

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x00AB4ECC File Offset: 0x00AB30CC
		// (set) Token: 0x0600B85B RID: 47195 RVA: 0x00AB4F80 File Offset: 0x00AB3180
		internal int CnvSysDVRSAttachRetryTime_A40141Min
		{
			get
			{
				short num = (short)336592896;
				short num2 = num;
				num = (short)2032885431;
				short num3 = num;
				num = (short)1140416183;
				switch (num3 == num)
				{
				}
				num = (short)478085121;
				if (num != 0)
				{
				}
				num = (short)1310457856;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Min;
			}
			set
			{
				short num = (short)1708392448;
				short num2 = num;
				num = (short)1688727144;
				short num3 = num;
				num = (short)1802301032;
				switch (num3 == num)
				{
				}
				num = (short)829095937;
				if (num != 0)
				{
				}
				num = (short)1246756864;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Min = value;
			}
		}

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x0600B85C RID: 47196 RVA: 0x00AB5034 File Offset: 0x00AB3234
		// (set) Token: 0x0600B85D RID: 47197 RVA: 0x00AB50E8 File Offset: 0x00AB32E8
		internal int CnvSysDVRSAttachRetryTime_A40141Max
		{
			get
			{
				short num = (short)364249088;
				short num2 = num;
				num = (short)679215105;
				if (num != 0)
				{
				}
				num = (short)140407199;
				short num3 = num;
				num = (short)1973186975;
				switch (num3 == num)
				{
				}
				num = (short)1869348864;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Max;
			}
			set
			{
				short num = (short)193921024;
				short num2 = num;
				num = (short)125816461;
				short num3 = num;
				num = (short)1400884877;
				switch (num3 == num)
				{
				}
				num = (short)1906900993;
				if (num != 0)
				{
				}
				num = (short)140771328;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Max = value;
			}
		}

		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x0600B85E RID: 47198 RVA: 0x00AB519C File Offset: 0x00AB339C
		// (set) Token: 0x0600B85F RID: 47199 RVA: 0x00AB5254 File Offset: 0x00AB3454
		internal int CnvSysDVRSAttachRetryTime_A40141Step
		{
			get
			{
				short num = (short)1234173952;
				short num2 = num;
				num = (short)2108100950;
				short num3 = num;
				num = (short)2021069142;
				switch (num3 == num)
				{
				}
				num = (short)2074017793;
				if (num != 0)
				{
				}
				num = (short)349896704;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.StepSize;
			}
			set
			{
				short num = (short)851116032;
				short num2 = num;
				num = (short)1753390597;
				short num3 = num;
				num = (short)706649605;
				switch (num3 == num)
				{
				}
				num = (short)211746817;
				if (num != 0)
				{
				}
				num = (short)732495872;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.StepSize = value;
			}
		}

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x0600B860 RID: 47200 RVA: 0x00AB5308 File Offset: 0x00AB3508
		// (set) Token: 0x0600B861 RID: 47201 RVA: 0x00AB53BC File Offset: 0x00AB35BC
		public bool CnvSysDVRSAttachRetryTime_A40141_Applicable
		{
			get
			{
				short num = (short)367394816;
				short num2 = num;
				num = (short)463690133;
				short num3 = num;
				num = (short)989878677;
				switch (num3 == num)
				{
				}
				num = (short)846135297;
				if (num != 0)
				{
				}
				num = (short)1763704832;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Applicable;
			}
			set
			{
				short num = (short)1912143872;
				short num2 = num;
				num = (short)1821128982;
				short num3 = num;
				num = (short)207698198;
				switch (num3 == num)
				{
				}
				num = (short)1811021824;
				if (num != 0)
				{
				}
				num = (short)771424257;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Applicable = value;
			}
		}

		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x0600B862 RID: 47202 RVA: 0x00AB5470 File Offset: 0x00AB3670
		// (set) Token: 0x0600B863 RID: 47203 RVA: 0x00AB5524 File Offset: 0x00AB3724
		public bool CnvSysDVRSAttachRetryTime_A40141_Valid
		{
			get
			{
				short num = (short)633929728;
				short num2 = num;
				num = (short)167537074;
				short num3 = num;
				num = (short)917793202;
				switch (num3 == num)
				{
				}
				num = (short)2073821185;
				if (num != 0)
				{
				}
				num = (short)1112014848;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Valid;
			}
			set
			{
				short num = (short)872546304;
				short num2 = num;
				num = (short)716021462;
				short num3 = num;
				num = (short)827956950;
				switch (num3 == num)
				{
				}
				num = (short)1468792833;
				if (num != 0)
				{
				}
				num = (short)2142699520;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Valid = value;
			}
		}

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x0600B864 RID: 47204 RVA: 0x00AB55D8 File Offset: 0x00AB37D8
		// (set) Token: 0x0600B865 RID: 47205 RVA: 0x00AB5690 File Offset: 0x00AB3890
		public bool CnvSysDVRSAttachRetryTime_A40141_Visible
		{
			get
			{
				short num = (short)1159135232;
				short num2 = num;
				num = (short)1207665596;
				short num3 = num;
				num = (short)867206076;
				switch (num3 == num)
				{
				}
				num = (short)705757185;
				if (num != 0)
				{
				}
				num = (short)1464991744;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Visible;
			}
			set
			{
				short num = (short)1529282560;
				short num2 = num;
				num = (short)450512340;
				short num3 = num;
				num = (short)1254770132;
				switch (num3 == num)
				{
				}
				num = (short)827064321;
				if (num != 0)
				{
				}
				num = (short)516358144;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Visible = value;
			}
		}

		// Token: 0x17005C38 RID: 23608
		// (get) Token: 0x0600B866 RID: 47206 RVA: 0x00AB5748 File Offset: 0x00AB3948
		// (set) Token: 0x0600B867 RID: 47207 RVA: 0x00AB57FC File Offset: 0x00AB39FC
		public bool CnvSysDVRSAttachRetryTime_A40141_Editable
		{
			get
			{
				short num = (short)246087680;
				short num2 = num;
				num = (short)1515060685;
				short num3 = num;
				num = (short)1039465933;
				switch (num3 == num)
				{
				}
				num = (short)69402624;
				if (num != 0)
				{
				}
				num = (short)1122762753;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.Editable;
			}
			set
			{
				short num = (short)526319616;
				short num2 = num;
				num = (short)2115698689;
				if (num != 0)
				{
				}
				num = (short)517101608;
				short num3 = num;
				num = (short)1325881384;
				switch (num3 == num)
				{
				}
				num = (short)1079967744;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.Editable = value;
			}
		}

		// Token: 0x17005C39 RID: 23609
		// (get) Token: 0x0600B868 RID: 47208 RVA: 0x00AB58B0 File Offset: 0x00AB3AB0
		internal string CnvSysDVRSAttachRetryTime_A40141_UILabel
		{
			get
			{
				short num = (short)467861504;
				short num2 = num;
				num = (short)1171062785;
				if (num != 0)
				{
				}
				num = (short)83055670;
				short num3 = num;
				num = (short)285955126;
				switch (num3 == num)
				{
				}
				num = (short)1271201792;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.UIName;
			}
		}

		// Token: 0x17005C3A RID: 23610
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x00AB5968 File Offset: 0x00AB3B68
		// (set) Token: 0x0600B86A RID: 47210 RVA: 0x00AB5A20 File Offset: 0x00AB3C20
		internal bool CnvSysDVRSAttachRetryTime_A40141_HiddenStatic
		{
			get
			{
				short num = (short)1344798720;
				short num2 = num;
				num = (short)2037928731;
				short num3 = num;
				num = (short)1981764379;
				switch (num3 == num)
				{
				}
				num = (short)1383596032;
				if (num != 0)
				{
				}
				num = (short)940572673;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.HiddenStatic;
			}
			set
			{
				short num = (short)927006720;
				short num2 = num;
				num = (short)448057251;
				short num3 = num;
				num = (short)401133475;
				switch (num3 == num)
				{
				}
				num = (short)741474305;
				if (num != 0)
				{
				}
				num = (short)1575026688;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.HiddenStatic = value;
			}
		}

		// Token: 0x17005C3B RID: 23611
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x00AB5AD8 File Offset: 0x00AB3CD8
		// (set) Token: 0x0600B86C RID: 47212 RVA: 0x00AB5B90 File Offset: 0x00AB3D90
		internal bool CnvSysDVRSAttachRetryTime_A40141_HiddenDynamic
		{
			get
			{
				short num = (short)375783424;
				short num2 = num;
				num = (short)1836074364;
				short num3 = num;
				num = (short)1331512700;
				switch (num3 == num)
				{
				}
				num = (short)216399873;
				if (num != 0)
				{
				}
				num = (short)1418788864;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141.HiddenDynamic;
			}
			set
			{
				short num = (short)782368768;
				short num2 = num;
				num = (short)201195521;
				if (num != 0)
				{
				}
				num = (short)435582618;
				short num3 = num;
				num = (short)699299482;
				switch (num3 == num)
				{
				}
				num = (short)270794752;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetryTime_A40141.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C3C RID: 23612
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x00AB5C48 File Offset: 0x00AB3E48
		public bool CnvSysDVRSAttachRetryTime_A40141_HasDiffs
		{
			get
			{
				short num = (short)9830400;
				short num2 = num;
				num = (short)1035897224;
				short num3 = num;
				num = (short)969116040;
				switch (num3 == num)
				{
				}
				num = (short)27983873;
				if (num != 0)
				{
				}
				num = (short)366215168;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetryTime_A40141._HasDiffs;
			}
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0600B86E RID: 47214 RVA: 0x00AB5CFC File Offset: 0x00AB3EFC
		// (set) Token: 0x0600B86F RID: 47215 RVA: 0x00AB5DB0 File Offset: 0x00AB3FB0
		public int CnvSysDVRSAttachRetries_A40142Value
		{
			get
			{
				short num = (short)1114112;
				short num2 = num;
				num = (short)1785921537;
				if (num != 0)
				{
				}
				num = (short)1597012124;
				short num3 = num;
				num = (short)486570140;
				switch (num3 == num)
				{
				}
				num = (short)1596456960;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Value;
			}
			set
			{
				short num = (short)632815616;
				short num2 = num;
				num = (short)318493471;
				short num3 = num;
				num = (short)770560799;
				switch (num3 == num)
				{
				}
				num = (short)1334378496;
				if (num != 0)
				{
				}
				num = (short)1691025409;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Value = value;
			}
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x0600B870 RID: 47216 RVA: 0x00AB5E68 File Offset: 0x00AB4068
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvSysDVRSAttachRetries_A40142
		{
			get
			{
				short num = (short)300810240;
				short num2 = num;
				num = (short)469499905;
				if (num != 0)
				{
				}
				num = (short)151327667;
				short num3 = num;
				num = (short)2005472179;
				switch (num3 == num)
				{
				}
				num = (short)2090467328;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142;
			}
		}

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x00AB5F18 File Offset: 0x00AB4118
		// (set) Token: 0x0600B872 RID: 47218 RVA: 0x00AB5FCC File Offset: 0x00AB41CC
		public string CnvSysDVRSAttachRetries_A40142_UIValue
		{
			get
			{
				short num = (short)972881920;
				short num2 = num;
				num = (short)1282990056;
				short num3 = num;
				num = (short)1478352872;
				switch (num3 == num)
				{
				}
				num = (short)91815936;
				if (num != 0)
				{
				}
				num = (short)254083073;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.UIValue;
			}
			set
			{
				short num = (short)1510277120;
				short num2 = num;
				num = (short)240967764;
				short num3 = num;
				num = (short)1922359380;
				switch (num3 == num)
				{
				}
				num = (short)692584449;
				if (num != 0)
				{
				}
				num = (short)249823232;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.UIValue = value;
			}
		}

		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x00AB6080 File Offset: 0x00AB4280
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x00AB613C File Offset: 0x00AB433C
		internal int CnvSysDVRSAttachRetries_A40142Min
		{
			get
			{
				short num = (short)704315392;
				short num2 = num;
				num = (short)1928265729;
				if (num != 0)
				{
				}
				num = (short)681201412;
				short num3 = num;
				num = (short)1687768836;
				switch (num3 == num)
				{
				}
				num = (short)1380646912;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Min;
			}
			set
			{
				short num = (short)1144520704;
				short num2 = num;
				num = (short)721025727;
				short num3 = num;
				num = (short)64158399;
				switch (num3 == num)
				{
				}
				num = (short)930152449;
				if (num != 0)
				{
				}
				num = (short)1668415488;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Min = value;
			}
		}

		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x00AB61F0 File Offset: 0x00AB43F0
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x00AB62A4 File Offset: 0x00AB44A4
		internal int CnvSysDVRSAttachRetries_A40142Max
		{
			get
			{
				short num = (short)548012032;
				short num2 = num;
				num = (short)1083540024;
				short num3 = num;
				num = (short)1130857016;
				switch (num3 == num)
				{
				}
				num = (short)999424000;
				if (num != 0)
				{
				}
				num = (short)883621889;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Max;
			}
			set
			{
				short num = (short)1428815872;
				short num2 = num;
				num = (short)1570393101;
				short num3 = num;
				num = (short)63523853;
				switch (num3 == num)
				{
				}
				num = (short)1321730048;
				if (num != 0)
				{
				}
				num = (short)354484225;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Max = value;
			}
		}

		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x00AB6358 File Offset: 0x00AB4558
		// (set) Token: 0x0600B878 RID: 47224 RVA: 0x00AB640C File Offset: 0x00AB460C
		internal int CnvSysDVRSAttachRetries_A40142Step
		{
			get
			{
				short num = (short)758644736;
				short num2 = num;
				num = (short)202866384;
				short num3 = num;
				num = (short)696811216;
				switch (num3 == num)
				{
				}
				num = (short)1885143041;
				if (num != 0)
				{
				}
				num = (short)2040070144;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.StepSize;
			}
			set
			{
				short num = (short)331350016;
				short num2 = num;
				num = (short)662611641;
				short num3 = num;
				num = (short)1275111097;
				switch (num3 == num)
				{
				}
				num = (short)2115371009;
				if (num != 0)
				{
				}
				num = (short)1475870720;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.StepSize = value;
			}
		}

		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x00AB64C4 File Offset: 0x00AB46C4
		// (set) Token: 0x0600B87A RID: 47226 RVA: 0x00AB6578 File Offset: 0x00AB4778
		public bool CnvSysDVRSAttachRetries_A40142_Applicable
		{
			get
			{
				short num = (short)1775304704;
				short num2 = num;
				num = (short)821375623;
				short num3 = num;
				num = (short)1376596615;
				switch (num3 == num)
				{
				}
				num = (short)96796673;
				if (num != 0)
				{
				}
				num = (short)1924726784;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Applicable;
			}
			set
			{
				short num = (short)887884879;
				short num2 = num;
				num = (short)27528271;
				switch (num2 == num)
				{
				}
				num = (short)755040257;
				if (num != 0)
				{
				}
				num = (short)1055850496;
				short num3 = num;
				num = (short)1097334784;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Applicable = value;
			}
		}

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x00AB662C File Offset: 0x00AB482C
		// (set) Token: 0x0600B87C RID: 47228 RVA: 0x00AB66E0 File Offset: 0x00AB48E0
		public bool CnvSysDVRSAttachRetries_A40142_Valid
		{
			get
			{
				short num = (short)1706851522;
				short num2 = num;
				num = (short)374176962;
				switch (num2 == num)
				{
				}
				num = (short)1982332928;
				if (num != 0)
				{
				}
				num = (short)1921187840;
				short num3 = num;
				num = (short)1421148161;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Valid;
			}
			set
			{
				short num = (short)1560459214;
				short num2 = num;
				num = (short)680835022;
				switch (num2 == num)
				{
				}
				num = (short)343408641;
				if (num != 0)
				{
				}
				num = (short)297336832;
				short num3 = num;
				num = (short)1955856384;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Valid = value;
			}
		}

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x00AB6794 File Offset: 0x00AB4994
		// (set) Token: 0x0600B87E RID: 47230 RVA: 0x00AB6848 File Offset: 0x00AB4A48
		public bool CnvSysDVRSAttachRetries_A40142_Visible
		{
			get
			{
				short num = (short)639369217;
				if (num != 0)
				{
				}
				num = (short)1464769035;
				short num2 = num;
				num = (short)630430219;
				switch (num2 == num)
				{
				}
				num = (short)1134755840;
				short num3 = num;
				num = (short)74121216;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Visible;
			}
			set
			{
				short num = (short)32390962;
				short num2 = num;
				num = (short)2052996914;
				switch (num2 == num)
				{
				}
				num = (short)95944705;
				if (num != 0)
				{
				}
				num = (short)568655872;
				short num3 = num;
				num = (short)741015552;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Visible = value;
			}
		}

		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x0600B87F RID: 47231 RVA: 0x00AB6900 File Offset: 0x00AB4B00
		// (set) Token: 0x0600B880 RID: 47232 RVA: 0x00AB69B4 File Offset: 0x00AB4BB4
		public bool CnvSysDVRSAttachRetries_A40142_Editable
		{
			get
			{
				short num = (short)1978010842;
				short num2 = num;
				num = (short)1033178330;
				switch (num2 == num)
				{
				}
				num = (short)702939137;
				if (num != 0)
				{
				}
				num = (short)1308950528;
				short num3 = num;
				num = (short)1614479360;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.Editable;
			}
			set
			{
				short num = (short)1566201511;
				short num2 = num;
				num = (short)519329447;
				switch (num2 == num)
				{
				}
				num = (short)526909441;
				if (num != 0)
				{
				}
				num = (short)453967872;
				short num3 = num;
				num = (short)1467154432;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.Editable = value;
			}
		}

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x0600B881 RID: 47233 RVA: 0x00AB6A68 File Offset: 0x00AB4C68
		internal string CnvSysDVRSAttachRetries_A40142_UILabel
		{
			get
			{
				short num = (short)1080273816;
				short num2 = num;
				num = (short)1434954648;
				switch (num2 == num)
				{
				}
				num = (short)314703872;
				if (num != 0)
				{
				}
				num = (short)2134441984;
				short num3 = num;
				num = (short)1250033665;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.UIName;
			}
		}

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x0600B882 RID: 47234 RVA: 0x00AB6B1C File Offset: 0x00AB4D1C
		// (set) Token: 0x0600B883 RID: 47235 RVA: 0x00AB6BD0 File Offset: 0x00AB4DD0
		internal bool CnvSysDVRSAttachRetries_A40142_HiddenStatic
		{
			get
			{
				short num = (short)338196426;
				short num2 = num;
				num = (short)2060285898;
				switch (num2 == num)
				{
				}
				num = (short)565837825;
				if (num != 0)
				{
				}
				num = (short)2053832704;
				short num3 = num;
				num = (short)211484672;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.HiddenStatic;
			}
			set
			{
				short num = (short)2016633421;
				short num2 = num;
				num = (short)949183053;
				switch (num2 == num)
				{
				}
				num = (short)1865809921;
				if (num != 0)
				{
				}
				num = (short)1698103296;
				short num3 = num;
				num = (short)463405056;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.HiddenStatic = value;
			}
		}

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x00AB6C84 File Offset: 0x00AB4E84
		// (set) Token: 0x0600B885 RID: 47237 RVA: 0x00AB6D38 File Offset: 0x00AB4F38
		internal bool CnvSysDVRSAttachRetries_A40142_HiddenDynamic
		{
			get
			{
				short num = (short)1653014529;
				if (num != 0)
				{
				}
				num = (short)1274799569;
				short num2 = num;
				num = (short)414311889;
				switch (num2 == num)
				{
				}
				num = (short)122159104;
				short num3 = num;
				num = (short)1924071424;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142.HiddenDynamic;
			}
			set
			{
				short num = (short)1859977217;
				if (num != 0)
				{
				}
				num = (short)626344190;
				short num2 = num;
				num = (short)2119647486;
				switch (num2 == num)
				{
				}
				num = (short)861274112;
				short num3 = num;
				num = (short)2142699520;
				if (num != 0)
				{
				}
				this.cnvSysDVRSAttachRetries_A40142.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x00AB6DF0 File Offset: 0x00AB4FF0
		public bool CnvSysDVRSAttachRetries_A40142_HasDiffs
		{
			get
			{
				short num = (short)2007956724;
				short num2 = num;
				num = (short)2096372;
				switch (num2 == num)
				{
				}
				num = (short)153485313;
				if (num != 0)
				{
				}
				num = (short)1860370432;
				short num3 = num;
				num = (short)796786688;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSAttachRetries_A40142._HasDiffs;
			}
		}

		// Token: 0x17005C4B RID: 23627
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x00AB6EA4 File Offset: 0x00AB50A4
		// (set) Token: 0x0600B888 RID: 47240 RVA: 0x00AB6F58 File Offset: 0x00AB5158
		public bool CnvSysDVRSEmerBlockInFS_A40143Value
		{
			get
			{
				short num = (short)535435868;
				short num2 = num;
				num = (short)1087969884;
				switch (num2 == num)
				{
				}
				num = (short)729874432;
				if (num != 0)
				{
				}
				num = (short)893714432;
				short num3 = num;
				num = (short)743571457;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Value;
			}
			set
			{
				short num = (short)1099227880;
				short num2 = num;
				num = (short)1867375336;
				switch (num2 == num)
				{
				}
				num = (short)881852416;
				if (num != 0)
				{
				}
				num = (short)907804672;
				short num3 = num;
				num = (short)381616129;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Value = value;
			}
		}

		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x00AB700C File Offset: 0x00AB520C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSEmerBlockInFS_A40143
		{
			get
			{
				short num = (short)640006794;
				short num2 = num;
				num = (short)1575533194;
				switch (num2 == num)
				{
				}
				num = (short)1012400129;
				if (num != 0)
				{
				}
				num = (short)1270808576;
				short num3 = num;
				num = (short)1660485632;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143;
			}
		}

		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x0600B88A RID: 47242 RVA: 0x00AB70BC File Offset: 0x00AB52BC
		// (set) Token: 0x0600B88B RID: 47243 RVA: 0x00AB7178 File Offset: 0x00AB5378
		public bool CnvSysDVRSEmerBlockInFS_A40143_UIValue
		{
			get
			{
				short num = (short)522347682;
				short num2 = num;
				num = (short)1114203298;
				switch (num2 == num)
				{
				}
				num = (short)220594177;
				if (num != 0)
				{
				}
				num = (short)90963968;
				short num3 = num;
				num = (short)604241920;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Value;
			}
			set
			{
				short num = (short)2145499326;
				short num2 = num;
				num = (short)984266942;
				switch (num2 == num)
				{
				}
				num = (short)1371996160;
				if (num != 0)
				{
				}
				num = (short)1227620352;
				short num3 = num;
				num = (short)784728065;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Value = value;
			}
		}

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x0600B88C RID: 47244 RVA: 0x00AB7230 File Offset: 0x00AB5430
		// (set) Token: 0x0600B88D RID: 47245 RVA: 0x00AB72E8 File Offset: 0x00AB54E8
		public bool CnvSysDVRSEmerBlockInFS_A40143_Applicable
		{
			get
			{
				short num = (short)696766368;
				short num2 = num;
				num = (short)2100613024;
				switch (num2 == num)
				{
				}
				num = (short)1246494720;
				if (num != 0)
				{
				}
				num = (short)1751515136;
				short num3 = num;
				num = (short)492699649;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Applicable;
			}
			set
			{
				short num = (short)851241512;
				short num2 = num;
				num = (short)304867880;
				switch (num2 == num)
				{
				}
				num = (short)92602369;
				if (num != 0)
				{
				}
				num = (short)1417543680;
				short num3 = num;
				num = (short)633012224;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Applicable = value;
			}
		}

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x0600B88E RID: 47246 RVA: 0x00AB73A0 File Offset: 0x00AB55A0
		// (set) Token: 0x0600B88F RID: 47247 RVA: 0x00AB7454 File Offset: 0x00AB5654
		public bool CnvSysDVRSEmerBlockInFS_A40143_Valid
		{
			get
			{
				short num = (short)1924867353;
				short num2 = num;
				num = (short)867575065;
				switch (num2 == num)
				{
				}
				num = (short)1736179712;
				if (num != 0)
				{
				}
				num = (short)1344077824;
				short num3 = num;
				num = (short)2140995585;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Valid;
			}
			set
			{
				short num = (short)1769874475;
				short num2 = num;
				num = (short)1070736427;
				switch (num2 == num)
				{
				}
				num = (short)954859521;
				if (num != 0)
				{
				}
				num = (short)846528512;
				short num3 = num;
				num = (short)1716649984;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Valid = value;
			}
		}

		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x0600B890 RID: 47248 RVA: 0x00AB7508 File Offset: 0x00AB5708
		// (set) Token: 0x0600B891 RID: 47249 RVA: 0x00AB75BC File Offset: 0x00AB57BC
		public bool CnvSysDVRSEmerBlockInFS_A40143_Visible
		{
			get
			{
				short num = (short)983794461;
				short num2 = num;
				num = (short)1369146141;
				switch (num2 == num)
				{
				}
				num = (short)1413480449;
				if (num != 0)
				{
				}
				num = (short)2084438016;
				short num3 = num;
				num = (short)642056192;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Visible;
			}
			set
			{
				short num = (short)103320471;
				short num2 = num;
				num = (short)754682775;
				switch (num2 == num)
				{
				}
				num = (short)1667301377;
				if (num != 0)
				{
				}
				num = (short)1953955840;
				short num3 = num;
				num = (short)1247346688;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Visible = value;
			}
		}

		// Token: 0x17005C51 RID: 23633
		// (get) Token: 0x0600B892 RID: 47250 RVA: 0x00AB7674 File Offset: 0x00AB5874
		// (set) Token: 0x0600B893 RID: 47251 RVA: 0x00AB7728 File Offset: 0x00AB5928
		public bool CnvSysDVRSEmerBlockInFS_A40143_Editable
		{
			get
			{
				short num = (short)1809570485;
				short num2 = num;
				num = (short)1187175093;
				switch (num2 == num)
				{
				}
				num = (short)1290207233;
				if (num != 0)
				{
				}
				num = (short)1491337216;
				short num3 = num;
				num = (short)601292800;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.Editable;
			}
			set
			{
				short num = (short)1573060609;
				if (num != 0)
				{
				}
				num = (short)991793590;
				short num2 = num;
				num = (short)1934201270;
				switch (num2 == num)
				{
				}
				num = (short)300613632;
				short num3 = num;
				num = (short)1489633280;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.Editable = value;
			}
		}

		// Token: 0x17005C52 RID: 23634
		// (get) Token: 0x0600B894 RID: 47252 RVA: 0x00AB77E0 File Offset: 0x00AB59E0
		internal string CnvSysDVRSEmerBlockInFS_A40143_UILabel
		{
			get
			{
				short num = (short)303099449;
				short num2 = num;
				num = (short)901312057;
				switch (num2 == num)
				{
				}
				num = (short)1557463041;
				if (num != 0)
				{
				}
				num = (short)1795162112;
				short num3 = num;
				num = (short)1310195712;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.UIName;
			}
		}

		// Token: 0x17005C53 RID: 23635
		// (get) Token: 0x0600B895 RID: 47253 RVA: 0x00AB7894 File Offset: 0x00AB5A94
		// (set) Token: 0x0600B896 RID: 47254 RVA: 0x00AB7948 File Offset: 0x00AB5B48
		internal bool CnvSysDVRSEmerBlockInFS_A40143_HiddenStatic
		{
			get
			{
				short num = (short)1874248274;
				short num2 = num;
				num = (short)553960018;
				switch (num2 == num)
				{
				}
				num = (short)1743585281;
				if (num != 0)
				{
				}
				num = (short)3735552;
				short num3 = num;
				num = (short)479789056;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.HiddenStatic;
			}
			set
			{
				short num = (short)356188161;
				if (num != 0)
				{
				}
				num = (short)303473477;
				short num2 = num;
				num = (short)2002035525;
				switch (num2 == num)
				{
				}
				num = (short)1205010432;
				short num3 = num;
				num = (short)203423744;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.HiddenStatic = value;
			}
		}

		// Token: 0x17005C54 RID: 23636
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x00AB79FC File Offset: 0x00AB5BFC
		// (set) Token: 0x0600B898 RID: 47256 RVA: 0x00AB7AB0 File Offset: 0x00AB5CB0
		internal bool CnvSysDVRSEmerBlockInFS_A40143_HiddenDynamic
		{
			get
			{
				short num = (short)475125596;
				short num2 = num;
				num = (short)425121628;
				switch (num2 == num)
				{
				}
				num = (short)36569089;
				if (num != 0)
				{
				}
				num = (short)924254208;
				short num3 = num;
				num = (short)653590528;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143.HiddenDynamic;
			}
			set
			{
				short num = (short)1172766721;
				if (num != 0)
				{
				}
				num = (short)1079438600;
				short num2 = num;
				num = (short)1545006344;
				switch (num2 == num)
				{
				}
				num = (short)953942016;
				short num3 = num;
				num = (short)700514304;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEmerBlockInFS_A40143.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x00AB7B64 File Offset: 0x00AB5D64
		public bool CnvSysDVRSEmerBlockInFS_A40143_HasDiffs
		{
			get
			{
				short num = (short)773516001;
				short num2 = num;
				num = (short)1326508769;
				switch (num2 == num)
				{
				}
				num = (short)1062076416;
				if (num != 0)
				{
				}
				num = (short)1943994368;
				short num3 = num;
				num = (short)1346502657;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEmerBlockInFS_A40143._HasDiffs;
			}
		}

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x0600B89A RID: 47258 RVA: 0x00AB7C1C File Offset: 0x00AB5E1C
		// (set) Token: 0x0600B89B RID: 47259 RVA: 0x00AB7CD0 File Offset: 0x00AB5ED0
		public int CnvSysFeatureDynRegroupZone_A40145Value
		{
			get
			{
				short num = (short)500693021;
				short num2 = num;
				num = (short)166262813;
				switch (num2 == num)
				{
				}
				num = (short)1326710784;
				if (num != 0)
				{
				}
				num = (short)1050935296;
				short num3 = num;
				num = (short)670826497;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.Value;
			}
			set
			{
				short num = (short)715063297;
				if (num != 0)
				{
				}
				num = (short)1264472372;
				short num2 = num;
				num = (short)403657012;
				switch (num2 == num)
				{
				}
				num = (short)1612054528;
				short num3 = num;
				num = (short)1558708224;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.Value = value;
			}
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x0600B89C RID: 47260 RVA: 0x00AB7D84 File Offset: 0x00AB5F84
		// (set) Token: 0x0600B89D RID: 47261 RVA: 0x00AB7E38 File Offset: 0x00AB6038
		public string CnvSysFeatureDynRegroupZone_A40145_UIValue
		{
			get
			{
				short num = (short)1831483781;
				short num2 = num;
				num = (short)268908933;
				switch (num2 == num)
				{
				}
				num = (short)140181505;
				if (num != 0)
				{
				}
				num = (short)2084438016;
				short num3 = num;
				num = (short)1560739840;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.UIValue;
			}
			set
			{
				short num = (short)710475777;
				if (num != 0)
				{
				}
				num = (short)713720074;
				short num2 = num;
				num = (short)862880010;
				switch (num2 == num)
				{
				}
				num = (short)297074688;
				short num3 = num;
				num = (short)787218432;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.UIValue = value;
			}
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x0600B89E RID: 47262 RVA: 0x00AB7EEC File Offset: 0x00AB60EC
		public global::AcpBusinessLayer.AcpRecRefField CnvSysFeatureDynRegroupZone_A40145
		{
			get
			{
				short num = (short)788176985;
				short num2 = num;
				num = (short)733257817;
				switch (num2 == num)
				{
				}
				num = (short)1682898945;
				if (num != 0)
				{
				}
				num = (short)1523449856;
				short num3 = num;
				num = (short)1222377472;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145;
			}
		}

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x0600B89F RID: 47263 RVA: 0x00AB7FA0 File Offset: 0x00AB61A0
		// (set) Token: 0x0600B8A0 RID: 47264 RVA: 0x00AB8054 File Offset: 0x00AB6254
		public bool CnvSysFeatureDynRegroupZone_A40145_Applicable
		{
			get
			{
				short num = (short)451066411;
				short num2 = num;
				num = (short)1948236331;
				switch (num2 == num)
				{
				}
				num = (short)722010112;
				if (num != 0)
				{
				}
				num = (short)1169752064;
				short num3 = num;
				num = (short)164757505;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.Applicable;
			}
			set
			{
				short num = (short)1640436712;
				short num2 = num;
				num = (short)1618547688;
				switch (num2 == num)
				{
				}
				num = (short)1566769153;
				if (num != 0)
				{
				}
				num = (short)1525153792;
				short num3 = num;
				num = (short)1584660480;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.Applicable = value;
			}
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x00AB810C File Offset: 0x00AB630C
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x00AB81C4 File Offset: 0x00AB63C4
		public bool CnvSysFeatureDynRegroupZone_A40145_Valid
		{
			get
			{
				short num = (short)205062145;
				if (num != 0)
				{
				}
				num = (short)1033355976;
				short num2 = num;
				num = (short)154125000;
				switch (num2 == num)
				{
				}
				num = (short)1604845568;
				short num3 = num;
				num = (short)1030225920;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.Valid;
			}
			set
			{
				short num = (short)1927671508;
				short num2 = num;
				num = (short)445902548;
				switch (num2 == num)
				{
				}
				num = (short)1555234817;
				if (num != 0)
				{
				}
				num = (short)1424752640;
				short num3 = num;
				num = (short)995557376;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.Valid = value;
			}
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x00AB827C File Offset: 0x00AB647C
		// (set) Token: 0x0600B8A4 RID: 47268 RVA: 0x00AB8330 File Offset: 0x00AB6530
		public bool CnvSysFeatureDynRegroupZone_A40145_Visible
		{
			get
			{
				short num = (short)224395265;
				if (num != 0)
				{
				}
				num = (short)2076887810;
				short num2 = num;
				num = (short)73845506;
				switch (num2 == num)
				{
				}
				num = (short)864681984;
				short num3 = num;
				num = (short)1296760832;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.Visible;
			}
			set
			{
				short num = (short)544014337;
				if (num != 0)
				{
				}
				num = (short)81465789;
				short num2 = num;
				num = (short)1979060669;
				switch (num2 == num)
				{
				}
				num = (short)955711488;
				short num3 = num;
				num = (short)1834287104;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.Visible = value;
			}
		}

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x00AB83E4 File Offset: 0x00AB65E4
		// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x00AB8498 File Offset: 0x00AB6698
		public bool CnvSysFeatureDynRegroupZone_A40145_Editable
		{
			get
			{
				short num = (short)1811813966;
				short num2 = num;
				num = (short)1002509902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)864747520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)516423681;
				if (num != 0)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.Editable;
			}
			set
			{
				short num = (short)1960439118;
				short num2 = num;
				num = (short)429583694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)163971072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)443088896;
				if (num != 0)
				{
				}
				num = (short)695074817;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.Editable = value;
			}
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x00AB8550 File Offset: 0x00AB6750
		internal string CnvSysFeatureDynRegroupZone_A40145_UILabel
		{
			get
			{
				short num = (short)1499004929;
				if (num != 0)
				{
				}
				num = (short)1052246016;
				short num2 = num;
				num = (short)1705759412;
				short num3 = num;
				num = (short)1221710516;
				switch (num3 == num)
				{
				}
				num = (short)884736000;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.UIName;
			}
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x0600B8A8 RID: 47272 RVA: 0x00AB8604 File Offset: 0x00AB6804
		// (set) Token: 0x0600B8A9 RID: 47273 RVA: 0x00AB86B8 File Offset: 0x00AB68B8
		internal bool CnvSysFeatureDynRegroupZone_A40145_HiddenStatic
		{
			get
			{
				short num = (short)1135207156;
				short num2 = num;
				num = (short)1805378292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42008576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)11337729;
				if (num != 0)
				{
				}
				num = (short)628883456;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.HiddenStatic;
			}
			set
			{
				short num = (short)1731184119;
				short num2 = num;
				num = (short)394053111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881145344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058747905;
				if (num != 0)
				{
				}
				num = (short)662241280;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.HiddenStatic = value;
			}
		}

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x0600B8AA RID: 47274 RVA: 0x00AB876C File Offset: 0x00AB696C
		// (set) Token: 0x0600B8AB RID: 47275 RVA: 0x00AB8824 File Offset: 0x00AB6A24
		internal bool CnvSysFeatureDynRegroupZone_A40145_HiddenDynamic
		{
			get
			{
				short num = (short)914910236;
				short num2 = num;
				num = (short)199519260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1962934272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772210689;
				if (num != 0)
				{
				}
				num = (short)1280573440;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145.HiddenDynamic;
			}
			set
			{
				short num = (short)849936385;
				if (num != 0)
				{
				}
				num = (short)1592262656;
				short num2 = num;
				num = (short)1070153781;
				short num3 = num;
				num = (short)535117877;
				switch (num3 == num)
				{
				}
				num = (short)42270720;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupZone_A40145.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x0600B8AC RID: 47276 RVA: 0x00AB88DC File Offset: 0x00AB6ADC
		public bool CnvSysFeatureDynRegroupZone_A40145_HasDiffs
		{
			get
			{
				short num = (short)817372566;
				short num2 = num;
				num = (short)388308374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)427884544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102381057;
				if (num != 0)
				{
				}
				num = (short)67698688;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupZone_A40145._HasDiffs;
			}
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x00AB8990 File Offset: 0x00AB6B90
		// (set) Token: 0x0600B8AE RID: 47278 RVA: 0x00AB8A44 File Offset: 0x00AB6C44
		public int CnvSysFeatureDynRegroupChannel_A40144Value
		{
			get
			{
				short num = (short)900923393;
				if (num != 0)
				{
				}
				num = (short)1914372096;
				short num2 = num;
				num = (short)909546318;
				short num3 = num;
				num = (short)741839694;
				switch (num3 == num)
				{
				}
				num = (short)1504182272;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.Value;
			}
			set
			{
				short num = (short)877440815;
				short num2 = num;
				num = (short)1058058031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208811520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)244383744;
				if (num != 0)
				{
				}
				num = (short)2135228417;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.Value = value;
			}
		}

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x0600B8AF RID: 47279 RVA: 0x00AB8AFC File Offset: 0x00AB6CFC
		// (set) Token: 0x0600B8B0 RID: 47280 RVA: 0x00AB8BB0 File Offset: 0x00AB6DB0
		public string CnvSysFeatureDynRegroupChannel_A40144_UIValue
		{
			get
			{
				short num = (short)275889297;
				short num2 = num;
				num = (short)1170455697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408223744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751646209;
				if (num != 0)
				{
				}
				num = (short)784400384;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.UIValue;
			}
			set
			{
				short num = (short)2064649582;
				short num2 = num;
				num = (short)54922606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1664548864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302186497;
				if (num != 0)
				{
				}
				num = (short)849674240;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.UIValue = value;
			}
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x00AB8C64 File Offset: 0x00AB6E64
		public global::AcpBusinessLayer.AcpRecRefField CnvSysFeatureDynRegroupChannel_A40144
		{
			get
			{
				short num = (short)1898309667;
				short num2 = num;
				num = (short)2034296867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646526464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820721152;
				if (num != 0)
				{
				}
				num = (short)1544552449;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144;
			}
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0600B8B2 RID: 47282 RVA: 0x00AB8D14 File Offset: 0x00AB6F14
		// (set) Token: 0x0600B8B3 RID: 47283 RVA: 0x00AB8DC8 File Offset: 0x00AB6FC8
		public bool CnvSysFeatureDynRegroupChannel_A40144_Applicable
		{
			get
			{
				short num = (short)1145108901;
				short num2 = num;
				num = (short)269023653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888616448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118647809;
				if (num != 0)
				{
				}
				num = (short)2014969856;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.Applicable;
			}
			set
			{
				short num = (short)1457728566;
				short num2 = num;
				num = (short)861744182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653787136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106327040;
				if (num != 0)
				{
				}
				num = (short)266797057;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.Applicable = value;
			}
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x0600B8B4 RID: 47284 RVA: 0x00AB8E80 File Offset: 0x00AB7080
		// (set) Token: 0x0600B8B5 RID: 47285 RVA: 0x00AB8F34 File Offset: 0x00AB7134
		public bool CnvSysFeatureDynRegroupChannel_A40144_Valid
		{
			get
			{
				short num = (short)2017902421;
				short num2 = num;
				num = (short)731299669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262616576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109248512;
				if (num != 0)
				{
				}
				num = (short)1916076033;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.Valid;
			}
			set
			{
				short num = (short)857189755;
				short num2 = num;
				num = (short)2107747707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101791232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94306305;
				if (num != 0)
				{
				}
				num = (short)2008678400;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.Valid = value;
			}
		}

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x0600B8B6 RID: 47286 RVA: 0x00AB8FEC File Offset: 0x00AB71EC
		// (set) Token: 0x0600B8B7 RID: 47287 RVA: 0x00AB90A4 File Offset: 0x00AB72A4
		public bool CnvSysFeatureDynRegroupChannel_A40144_Visible
		{
			get
			{
				short num = (short)1360723969;
				if (num != 0)
				{
				}
				num = (short)6881280;
				short num2 = num;
				num = (short)1945312928;
				short num3 = num;
				num = (short)192421536;
				switch (num3 == num)
				{
				}
				num = (short)203161600;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.Visible;
			}
			set
			{
				short num = (short)1799459925;
				short num2 = num;
				num = (short)1576375381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698482688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968373761;
				if (num != 0)
				{
				}
				num = (short)1082064896;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.Visible = value;
			}
		}

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x0600B8B8 RID: 47288 RVA: 0x00AB9158 File Offset: 0x00AB7358
		// (set) Token: 0x0600B8B9 RID: 47289 RVA: 0x00AB920C File Offset: 0x00AB740C
		public bool CnvSysFeatureDynRegroupChannel_A40144_Editable
		{
			get
			{
				short num = (short)432736338;
				short num2 = num;
				num = (short)1937508434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057095680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939327488;
				if (num != 0)
				{
				}
				num = (short)1936719873;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.Editable;
			}
			set
			{
				short num = (short)3973230;
				short num2 = num;
				num = (short)1312530542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)186580992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011810304;
				if (num != 0)
				{
				}
				num = (short)1090060289;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.Editable = value;
			}
		}

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x0600B8BA RID: 47290 RVA: 0x00AB92C0 File Offset: 0x00AB74C0
		internal string CnvSysFeatureDynRegroupChannel_A40144_UILabel
		{
			get
			{
				short num = (short)485520708;
				short num2 = num;
				num = (short)880506180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367460352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145896961;
				if (num != 0)
				{
				}
				num = (short)1432420352;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.UIName;
			}
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x00AB9378 File Offset: 0x00AB7578
		// (set) Token: 0x0600B8BC RID: 47292 RVA: 0x00AB942C File Offset: 0x00AB762C
		internal bool CnvSysFeatureDynRegroupChannel_A40144_HiddenStatic
		{
			get
			{
				short num = (short)105840641;
				if (num != 0)
				{
				}
				num = (short)2084569088;
				short num2 = num;
				num = (short)846265072;
				short num3 = num;
				num = (short)1585183472;
				switch (num3 == num)
				{
				}
				num = (short)250413056;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.HiddenStatic;
			}
			set
			{
				short num = (short)992215041;
				if (num != 0)
				{
				}
				num = (short)552009728;
				short num2 = num;
				num = (short)300173537;
				short num3 = num;
				num = (short)1346980065;
				switch (num3 == num)
				{
				}
				num = (short)457375744;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.HiddenStatic = value;
			}
		}

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x00AB94E0 File Offset: 0x00AB76E0
		// (set) Token: 0x0600B8BE RID: 47294 RVA: 0x00AB9598 File Offset: 0x00AB7798
		internal bool CnvSysFeatureDynRegroupChannel_A40144_HiddenDynamic
		{
			get
			{
				short num = (short)1113653249;
				if (num != 0)
				{
				}
				num = (short)110821376;
				short num2 = num;
				num = (short)763145151;
				short num3 = num;
				num = (short)1704307647;
				switch (num3 == num)
				{
				}
				num = (short)1879638016;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144.HiddenDynamic;
			}
			set
			{
				short num = (short)1441849558;
				short num2 = num;
				num = (short)1398726870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1442316288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)919404545;
				if (num != 0)
				{
				}
				num = (short)1337065472;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupChannel_A40144.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x00AB964C File Offset: 0x00AB784C
		public bool CnvSysFeatureDynRegroupChannel_A40144_HasDiffs
		{
			get
			{
				short num = (short)1545429469;
				short num2 = num;
				num = (short)835281373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376583680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551944192;
				if (num != 0)
				{
				}
				num = (short)1011482625;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupChannel_A40144._HasDiffs;
			}
		}

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x0600B8C0 RID: 47296 RVA: 0x00AB9700 File Offset: 0x00AB7900
		// (set) Token: 0x0600B8C1 RID: 47297 RVA: 0x00AB97B8 File Offset: 0x00AB79B8
		public bool CnvSysFeatureDynRegroupEn_A40146Value
		{
			get
			{
				short num = (short)2028018224;
				short num2 = num;
				num = (short)1531976240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390542848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				num = (short)1852506113;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Value;
			}
			set
			{
				short num = (short)1481353846;
				short num2 = num;
				num = (short)426224246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932132352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049821185;
				if (num != 0)
				{
				}
				num = (short)1889337344;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Value = value;
			}
		}

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x0600B8C2 RID: 47298 RVA: 0x00AB9870 File Offset: 0x00AB7A70
		public global::AcpBusinessLayer.AcpField<bool> CnvSysFeatureDynRegroupEn_A40146
		{
			get
			{
				short num = (short)849781973;
				short num2 = num;
				num = (short)1869391061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095303168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)952696833;
				if (num != 0)
				{
				}
				num = (short)262864896;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146;
			}
		}

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x0600B8C3 RID: 47299 RVA: 0x00AB9920 File Offset: 0x00AB7B20
		// (set) Token: 0x0600B8C4 RID: 47300 RVA: 0x00AB99D4 File Offset: 0x00AB7BD4
		public bool CnvSysFeatureDynRegroupEn_A40146_UIValue
		{
			get
			{
				short num = (short)1141312728;
				short num2 = num;
				num = (short)1488915672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)856489984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)667222016;
				if (num != 0)
				{
				}
				num = (short)377290753;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Value;
			}
			set
			{
				short num = (short)830077780;
				short num2 = num;
				num = (short)1701182292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)638648320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)503906304;
				if (num != 0)
				{
				}
				num = (short)496107521;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Value = value;
			}
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x00AB9A88 File Offset: 0x00AB7C88
		// (set) Token: 0x0600B8C6 RID: 47302 RVA: 0x00AB9B40 File Offset: 0x00AB7D40
		public bool CnvSysFeatureDynRegroupEn_A40146_Applicable
		{
			get
			{
				short num = (short)759323159;
				short num2 = num;
				num = (short)1044339223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208352768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1766064128;
				if (num != 0)
				{
				}
				num = (short)982384641;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Applicable;
			}
			set
			{
				short num = (short)1647710830;
				short num2 = num;
				num = (short)1600000622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764739584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1354563585;
				if (num != 0)
				{
				}
				num = (short)2024931328;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Applicable = value;
			}
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x0600B8C7 RID: 47303 RVA: 0x00AB9BF8 File Offset: 0x00AB7DF8
		// (set) Token: 0x0600B8C8 RID: 47304 RVA: 0x00AB9CB0 File Offset: 0x00AB7EB0
		public bool CnvSysFeatureDynRegroupEn_A40146_Valid
		{
			get
			{
				short num = (short)1265396942;
				short num2 = num;
				num = (short)90860750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169227776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300548096;
				if (num != 0)
				{
				}
				num = (short)1508769793;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Valid;
			}
			set
			{
				short num = (short)2008784456;
				short num2 = num;
				num = (short)26975816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88997888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83689472;
				if (num != 0)
				{
				}
				num = (short)1427832833;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Valid = value;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x00AB9D68 File Offset: 0x00AB7F68
		// (set) Token: 0x0600B8CA RID: 47306 RVA: 0x00AB9E20 File Offset: 0x00AB8020
		public bool CnvSysFeatureDynRegroupEn_A40146_Visible
		{
			get
			{
				short num = (short)1765998593;
				if (num != 0)
				{
				}
				num = (short)1000669184;
				short num2 = num;
				num = (short)1831929857;
				short num3 = num;
				num = (short)519374849;
				switch (num3 == num)
				{
				}
				num = (short)1720647680;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Visible;
			}
			set
			{
				short num = (short)1501474498;
				short num2 = num;
				num = (short)186494658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432799744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121386497;
				if (num != 0)
				{
				}
				num = (short)278921216;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Visible = value;
			}
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x00AB9ED4 File Offset: 0x00AB80D4
		// (set) Token: 0x0600B8CC RID: 47308 RVA: 0x00AB9F88 File Offset: 0x00AB8188
		public bool CnvSysFeatureDynRegroupEn_A40146_Editable
		{
			get
			{
				short num = (short)335413248;
				short num2 = num;
				num = (short)784859137;
				if (num != 0)
				{
				}
				num = (short)849225794;
				short num3 = num;
				num = (short)2038310978;
				switch (num3 == num)
				{
				}
				num = (short)1390215168;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.Editable;
			}
			set
			{
				short num = (short)128974848;
				short num2 = num;
				num = (short)1869436469;
				short num3 = num;
				num = (short)1766676021;
				switch (num3 == num)
				{
				}
				num = (short)1978007553;
				if (num != 0)
				{
				}
				num = (short)625147904;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.Editable = value;
			}
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x00ABA03C File Offset: 0x00AB823C
		internal string CnvSysFeatureDynRegroupEn_A40146_UILabel
		{
			get
			{
				short num = (short)738590720;
				short num2 = num;
				num = (short)1356555023;
				short num3 = num;
				num = (short)578183951;
				switch (num3 == num)
				{
				}
				num = (short)311885824;
				if (num != 0)
				{
				}
				num = (short)1640038401;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.UIName;
			}
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x0600B8CE RID: 47310 RVA: 0x00ABA0EC File Offset: 0x00AB82EC
		// (set) Token: 0x0600B8CF RID: 47311 RVA: 0x00ABA1A0 File Offset: 0x00AB83A0
		internal bool CnvSysFeatureDynRegroupEn_A40146_HiddenStatic
		{
			get
			{
				short num = (short)1206845440;
				short num2 = num;
				num = (short)1883748806;
				short num3 = num;
				num = (short)1826404806;
				switch (num3 == num)
				{
				}
				num = (short)329187328;
				if (num != 0)
				{
				}
				num = (short)1684865025;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.HiddenStatic;
			}
			set
			{
				short num = (short)1314062336;
				short num2 = num;
				num = (short)230775225;
				short num3 = num;
				num = (short)472471993;
				switch (num3 == num)
				{
				}
				num = (short)2046558208;
				if (num != 0)
				{
				}
				num = (short)1778450433;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.HiddenStatic = value;
			}
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x0600B8D0 RID: 47312 RVA: 0x00ABA258 File Offset: 0x00AB8458
		// (set) Token: 0x0600B8D1 RID: 47313 RVA: 0x00ABA30C File Offset: 0x00AB850C
		internal bool CnvSysFeatureDynRegroupEn_A40146_HiddenDynamic
		{
			get
			{
				short num = (short)664010752;
				short num2 = num;
				num = (short)1138375601;
				short num3 = num;
				num = (short)1394686897;
				switch (num3 == num)
				{
				}
				num = (short)523829249;
				if (num != 0)
				{
				}
				num = (short)409075712;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146.HiddenDynamic;
			}
			set
			{
				short num = (short)1525088256;
				short num2 = num;
				num = (short)1210661772;
				short num3 = num;
				num = (short)1700412300;
				switch (num3 == num)
				{
				}
				num = (short)676331521;
				if (num != 0)
				{
				}
				num = (short)1577123840;
				if (num != 0)
				{
				}
				this.cnvSysFeatureDynRegroupEn_A40146.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x00ABA3C4 File Offset: 0x00AB85C4
		public bool CnvSysFeatureDynRegroupEn_A40146_HasDiffs
		{
			get
			{
				short num = (short)701497344;
				short num2 = num;
				num = (short)966280134;
				short num3 = num;
				num = (short)818037702;
				switch (num3 == num)
				{
				}
				num = (short)1096679425;
				if (num != 0)
				{
				}
				num = (short)1944256512;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureDynRegroupEn_A40146._HasDiffs;
			}
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x0600B8D3 RID: 47315 RVA: 0x00ABA47C File Offset: 0x00AB867C
		// (set) Token: 0x0600B8D4 RID: 47316 RVA: 0x00ABA534 File Offset: 0x00AB8734
		public int CnvSysFeatureCallType_A40147Value
		{
			get
			{
				short num = (short)1857683456;
				short num2 = num;
				num = (short)1568100705;
				short num3 = num;
				num = (short)449532257;
				switch (num3 == num)
				{
				}
				num = (short)857931777;
				if (num != 0)
				{
				}
				num = (short)1711931392;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.Value;
			}
			set
			{
				short num = (short)594280448;
				short num2 = num;
				num = (short)2027194213;
				short num3 = num;
				num = (short)1005422437;
				switch (num3 == num)
				{
				}
				num = (short)342425601;
				if (num != 0)
				{
				}
				num = (short)1359937536;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.Value = value;
			}
		}

		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x0600B8D5 RID: 47317 RVA: 0x00ABA5E8 File Offset: 0x00AB87E8
		// (set) Token: 0x0600B8D6 RID: 47318 RVA: 0x00ABA698 File Offset: 0x00AB8898
		public string CnvSysFeatureCallType_A40147_UIValue
		{
			get
			{
				short num = (short)1426128896;
				short num2 = num;
				num = (short)103117858;
				short num3 = num;
				num = (short)472282146;
				switch (num3 == num)
				{
				}
				num = (short)711131137;
				if (num != 0)
				{
				}
				num = (short)1235288064;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.UIValue;
			}
			set
			{
				short num = (short)1839136768;
				short num2 = num;
				num = (short)148896469;
				short num3 = num;
				num = (short)455211733;
				switch (num3 == num)
				{
				}
				num = (short)69795840;
				if (num != 0)
				{
				}
				num = (short)86638593;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.UIValue = value;
			}
		}

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x0600B8D7 RID: 47319 RVA: 0x00ABA74C File Offset: 0x00AB894C
		public global::AcpBusinessLayer.AcpListField CnvSysFeatureCallType_A40147
		{
			get
			{
				short num = (short)1483603968;
				short num2 = num;
				num = (short)2104649325;
				short num3 = num;
				num = (short)590505581;
				switch (num3 == num)
				{
				}
				num = (short)2088763393;
				if (num != 0)
				{
				}
				num = (short)745603072;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147;
			}
		}

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x00ABA7FC File Offset: 0x00AB89FC
		// (set) Token: 0x0600B8D9 RID: 47321 RVA: 0x00ABA8B0 File Offset: 0x00AB8AB0
		public bool CnvSysFeatureCallType_A40147_Applicable
		{
			get
			{
				short num = (short)1296695296;
				short num2 = num;
				num = (short)1362797607;
				short num3 = num;
				num = (short)1505600551;
				switch (num3 == num)
				{
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				num = (short)708050945;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.Applicable;
			}
			set
			{
				short num = (short)628752384;
				short num2 = num;
				num = (short)902584958;
				short num3 = num;
				num = (short)438262398;
				switch (num3 == num)
				{
				}
				num = (short)495517697;
				if (num != 0)
				{
				}
				num = (short)2137653248;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.Applicable = value;
			}
		}

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x00ABA964 File Offset: 0x00AB8B64
		// (set) Token: 0x0600B8DB RID: 47323 RVA: 0x00ABAA18 File Offset: 0x00AB8C18
		public bool CnvSysFeatureCallType_A40147_Valid
		{
			get
			{
				short num = (short)1852571648;
				short num2 = num;
				num = (short)827769519;
				short num3 = num;
				num = (short)1085260463;
				switch (num3 == num)
				{
				}
				num = (short)334168065;
				if (num != 0)
				{
				}
				num = (short)1463746560;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.Valid;
			}
			set
			{
				short num = (short)1432551424;
				short num2 = num;
				num = (short)1193607169;
				if (num != 0)
				{
				}
				num = (short)361722191;
				short num3 = num;
				num = (short)1106080079;
				switch (num3 == num)
				{
				}
				num = (short)1543700480;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.Valid = value;
			}
		}

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x00ABAAD0 File Offset: 0x00AB8CD0
		// (set) Token: 0x0600B8DD RID: 47325 RVA: 0x00ABAB84 File Offset: 0x00AB8D84
		public bool CnvSysFeatureCallType_A40147_Visible
		{
			get
			{
				short num = (short)2125791232;
				short num2 = num;
				num = (short)266838281;
				short num3 = num;
				num = (short)1490329865;
				switch (num3 == num)
				{
				}
				num = (short)1444020224;
				if (num != 0)
				{
				}
				num = (short)444923905;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.Visible;
			}
			set
			{
				short num = (short)1513947136;
				short num2 = num;
				num = (short)144175710;
				short num3 = num;
				num = (short)778891870;
				switch (num3 == num)
				{
				}
				num = (short)714145793;
				if (num != 0)
				{
				}
				num = (short)1980497920;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.Visible = value;
			}
		}

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x00ABAC40 File Offset: 0x00AB8E40
		// (set) Token: 0x0600B8DF RID: 47327 RVA: 0x00ABACF4 File Offset: 0x00AB8EF4
		public bool CnvSysFeatureCallType_A40147_Editable
		{
			get
			{
				short num = (short)756613120;
				short num2 = num;
				num = (short)547916242;
				short num3 = num;
				num = (short)271616466;
				switch (num3 == num)
				{
				}
				num = (short)703135744;
				if (num != 0)
				{
				}
				num = (short)787546113;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.Editable;
			}
			set
			{
				short num = (short)1736638464;
				short num2 = num;
				num = (short)1069954869;
				short num3 = num;
				num = (short)1494628149;
				switch (num3 == num)
				{
				}
				num = (short)1970274305;
				if (num != 0)
				{
				}
				num = (short)1665007616;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.Editable = value;
			}
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x0600B8E0 RID: 47328 RVA: 0x00ABADAC File Offset: 0x00AB8FAC
		internal string CnvSysFeatureCallType_A40147_UILabel
		{
			get
			{
				short num = (short)1047986176;
				short num2 = num;
				num = (short)770303265;
				short num3 = num;
				num = (short)1349313825;
				switch (num3 == num)
				{
				}
				num = (short)265355264;
				if (num != 0)
				{
				}
				num = (short)466550785;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.UIName;
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x00ABAE60 File Offset: 0x00AB9060
		// (set) Token: 0x0600B8E2 RID: 47330 RVA: 0x00ABAF14 File Offset: 0x00AB9114
		internal bool CnvSysFeatureCallType_A40147_HiddenStatic
		{
			get
			{
				short num = (short)18612224;
				short num2 = num;
				num = (short)692455999;
				short num3 = num;
				num = (short)463211071;
				switch (num3 == num)
				{
				}
				num = (short)75431937;
				if (num != 0)
				{
				}
				num = (short)2044526592;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.HiddenStatic;
			}
			set
			{
				short num = (short)2096693248;
				short num2 = num;
				num = (short)1873674241;
				if (num != 0)
				{
				}
				num = (short)203564549;
				short num3 = num;
				num = (short)1263216133;
				switch (num3 == num)
				{
				}
				num = (short)2125004800;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.HiddenStatic = value;
			}
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x00ABAFCC File Offset: 0x00AB91CC
		// (set) Token: 0x0600B8E4 RID: 47332 RVA: 0x00ABB080 File Offset: 0x00AB9280
		internal bool CnvSysFeatureCallType_A40147_HiddenDynamic
		{
			get
			{
				short num = (short)1968504832;
				short num2 = num;
				num = (short)1900376863;
				short num3 = num;
				num = (short)1939632927;
				switch (num3 == num)
				{
				}
				num = (short)1415184384;
				if (num != 0)
				{
				}
				num = (short)1988558849;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147.HiddenDynamic;
			}
			set
			{
				short num = (short)554893312;
				short num2 = num;
				num = (short)1011347064;
				short num3 = num;
				num = (short)24899192;
				switch (num3 == num)
				{
				}
				num = (short)1123090432;
				if (num != 0)
				{
				}
				num = (short)1250033665;
				if (num != 0)
				{
				}
				this.cnvSysFeatureCallType_A40147.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x00ABB134 File Offset: 0x00AB9334
		public bool CnvSysFeatureCallType_A40147_HasDiffs
		{
			get
			{
				short num = (short)1545601024;
				short num2 = num;
				num = (short)704029271;
				short num3 = num;
				num = (short)1459331671;
				switch (num3 == num)
				{
				}
				num = (short)1190985728;
				if (num != 0)
				{
				}
				num = (short)921370625;
				if (num != 0)
				{
				}
				return this.cnvSysFeatureCallType_A40147._HasDiffs;
			}
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x0600B8E6 RID: 47334 RVA: 0x00ABB1E4 File Offset: 0x00AB93E4
		// (set) Token: 0x0600B8E7 RID: 47335 RVA: 0x00ABB298 File Offset: 0x00AB9498
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143Value
		{
			get
			{
				short num = (short)757268480;
				short num2 = num;
				num = (short)576373052;
				short num3 = num;
				num = (short)1287962940;
				switch (num3 == num)
				{
				}
				num = (short)2003107841;
				if (num != 0)
				{
				}
				num = (short)648609792;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Value;
			}
			set
			{
				short num = (short)1503789056;
				short num2 = num;
				num = (short)1203811159;
				short num3 = num;
				num = (short)170439511;
				switch (num3 == num)
				{
				}
				num = (short)1587412993;
				if (num != 0)
				{
				}
				num = (short)448266240;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Value = value;
			}
		}

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x0600B8E8 RID: 47336 RVA: 0x00ABB350 File Offset: 0x00AB9550
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143
		{
			get
			{
				short num = (short)1478361088;
				short num2 = num;
				num = (short)1819792821;
				short num3 = num;
				num = (short)1565119925;
				switch (num3 == num)
				{
				}
				num = (short)253100032;
				if (num != 0)
				{
				}
				num = (short)867827713;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;
			}
		}

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x0600B8E9 RID: 47337 RVA: 0x00ABB400 File Offset: 0x00AB9600
		// (set) Token: 0x0600B8EA RID: 47338 RVA: 0x00ABB4B4 File Offset: 0x00AB96B4
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_UIValue
		{
			get
			{
				short num = (short)1932132352;
				short num2 = num;
				num = (short)1255902423;
				short num3 = num;
				num = (short)1707642071;
				switch (num3 == num)
				{
				}
				num = (short)1560215553;
				if (num != 0)
				{
				}
				num = (short)240320512;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Value;
			}
			set
			{
				short num = (short)1753415680;
				short num2 = num;
				num = (short)847875566;
				short num3 = num;
				num = (short)1487769070;
				switch (num3 == num)
				{
				}
				num = (short)269746176;
				if (num != 0)
				{
				}
				num = (short)808910849;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Value = value;
			}
		}

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x0600B8EB RID: 47339 RVA: 0x00ABB56C File Offset: 0x00AB976C
		// (set) Token: 0x0600B8EC RID: 47340 RVA: 0x00ABB624 File Offset: 0x00AB9824
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_Applicable
		{
			get
			{
				short num = (short)1854210048;
				short num2 = num;
				num = (short)930658132;
				short num3 = num;
				num = (short)848475988;
				switch (num3 == num)
				{
				}
				num = (short)2085093376;
				if (num != 0)
				{
				}
				num = (short)1272512513;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Applicable;
			}
			set
			{
				short num = (short)204144640;
				short num2 = num;
				num = (short)1324482233;
				short num3 = num;
				num = (short)981073593;
				switch (num3 == num)
				{
				}
				num = (short)2015494145;
				if (num != 0)
				{
				}
				num = (short)697565184;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Applicable = value;
			}
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x0600B8ED RID: 47341 RVA: 0x00ABB6D8 File Offset: 0x00AB98D8
		// (set) Token: 0x0600B8EE RID: 47342 RVA: 0x00ABB78C File Offset: 0x00AB998C
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_Valid
		{
			get
			{
				short num = (short)1384841216;
				short num2 = num;
				num = (short)869007361;
				if (num != 0)
				{
				}
				num = (short)309458526;
				short num3 = num;
				num = (short)1976039006;
				switch (num3 == num)
				{
				}
				num = (short)1594425344;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Valid;
			}
			set
			{
				short num = (short)585629696;
				short num2 = num;
				num = (short)562692097;
				if (num != 0)
				{
				}
				num = (short)71974432;
				short num3 = num;
				num = (short)507657760;
				switch (num3 == num)
				{
				}
				num = (short)1615396864;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Valid = value;
			}
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x0600B8EF RID: 47343 RVA: 0x00ABB844 File Offset: 0x00AB9A44
		// (set) Token: 0x0600B8F0 RID: 47344 RVA: 0x00ABB8F8 File Offset: 0x00AB9AF8
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_Visible
		{
			get
			{
				short num = (short)1024000000;
				short num2 = num;
				num = (short)1607181634;
				short num3 = num;
				num = (short)92448066;
				switch (num3 == num)
				{
				}
				num = (short)1677590528;
				if (num != 0)
				{
				}
				num = (short)1177485313;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Visible;
			}
			set
			{
				short num = (short)230352551;
				short num2 = num;
				num = (short)694871719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547567104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1118240768;
				if (num != 0)
				{
				}
				num = (short)421199873;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Visible = value;
			}
		}

		// Token: 0x17005C88 RID: 23688
		// (get) Token: 0x0600B8F1 RID: 47345 RVA: 0x00ABB9B0 File Offset: 0x00AB9BB0
		// (set) Token: 0x0600B8F2 RID: 47346 RVA: 0x00ABBA64 File Offset: 0x00AB9C64
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_Editable
		{
			get
			{
				short num = (short)1641487243;
				short num2 = num;
				num = (short)309992331;
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
				num = (short)1086455808;
				if (num != 0)
				{
				}
				num = (short)568066049;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Editable;
			}
			set
			{
				short num = (short)1622523710;
				short num2 = num;
				num = (short)1214824254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086010880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)525729792;
				if (num != 0)
				{
				}
				num = (short)1550385153;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.Editable = value;
			}
		}

		// Token: 0x17005C89 RID: 23689
		// (get) Token: 0x0600B8F3 RID: 47347 RVA: 0x00ABBB1C File Offset: 0x00AB9D1C
		internal string CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_UILabel
		{
			get
			{
				short num = (short)1095503189;
				short num2 = num;
				num = (short)1744637269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607335936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1226506241;
				if (num != 0)
				{
				}
				num = (short)1774321664;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.UIName;
			}
		}

		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x00ABBBD0 File Offset: 0x00AB9DD0
		// (set) Token: 0x0600B8F5 RID: 47349 RVA: 0x00ABBC84 File Offset: 0x00AB9E84
		internal bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_HiddenStatic
		{
			get
			{
				short num = (short)1787062264;
				short num2 = num;
				num = (short)945383416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2066939904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1471152129;
				if (num != 0)
				{
				}
				num = (short)1621884928;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.HiddenStatic;
			}
			set
			{
				short num = (short)1522306933;
				short num2 = num;
				num = (short)128814965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052390912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1055784961;
				if (num != 0)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.HiddenStatic = value;
			}
		}

		// Token: 0x17005C8B RID: 23691
		// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x00ABBD3C File Offset: 0x00AB9F3C
		// (set) Token: 0x0600B8F7 RID: 47351 RVA: 0x00ABBDF0 File Offset: 0x00AB9FF0
		internal bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_HiddenDynamic
		{
			get
			{
				short num = (short)699924481;
				if (num != 0)
				{
				}
				num = (short)1250230272;
				short num2 = num;
				num = (short)540662391;
				short num3 = num;
				num = (short)1877138039;
				switch (num3 == num)
				{
				}
				num = (short)1969094656;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.HiddenDynamic;
			}
			set
			{
				short num = (short)126789133;
				short num2 = num;
				num = (short)594454029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97910784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				num = (short)1049034752;
				if (num != 0)
				{
				}
				this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x00ABBEA4 File Offset: 0x00ABA0A4
		public bool CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143_HasDiffs
		{
			get
			{
				short num = (short)1049341856;
				short num2 = num;
				num = (short)178565024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)457637888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306577409;
				if (num != 0)
				{
				}
				num = (short)615579648;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143._HasDiffs;
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x0600B8F9 RID: 47353 RVA: 0x00ABBF5C File Offset: 0x00ABA15C
		// (set) Token: 0x0600B8FA RID: 47354 RVA: 0x00ABC014 File Offset: 0x00ABA214
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445Value
		{
			get
			{
				short num = (short)1123876865;
				if (num != 0)
				{
				}
				num = (short)1592524800;
				short num2 = num;
				num = (short)619986536;
				short num3 = num;
				num = (short)888880744;
				switch (num3 == num)
				{
				}
				num = (short)2110783488;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Value;
			}
			set
			{
				short num = (short)1313106097;
				short num2 = num;
				num = (short)1958176945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471152128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)174915584;
				if (num != 0)
				{
				}
				num = (short)1348337665;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Value = value;
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x00ABC0C8 File Offset: 0x00ABA2C8
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445
		{
			get
			{
				short num = (short)182362325;
				short num2 = num;
				num = (short)740204757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794637824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1377304577;
				if (num != 0)
				{
				}
				num = (short)375521280;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x00ABC178 File Offset: 0x00ABA378
		// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x00ABC230 File Offset: 0x00ABA430
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_UIValue
		{
			get
			{
				short num = (short)1264424807;
				short num2 = num;
				num = (short)2085918567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624702976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)255655937;
				if (num != 0)
				{
				}
				num = (short)2041446400;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Value;
			}
			set
			{
				short num = (short)68198686;
				short num2 = num;
				num = (short)732012830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)774635520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1008992257;
				if (num != 0)
				{
				}
				num = (short)829620224;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Value = value;
			}
		}

		// Token: 0x17005C90 RID: 23696
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x00ABC2E4 File Offset: 0x00ABA4E4
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x00ABC398 File Offset: 0x00ABA598
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_Applicable
		{
			get
			{
				short num = (short)750046148;
				short num2 = num;
				num = (short)1566165956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726545920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)1757151232;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Applicable;
			}
			set
			{
				short num = (short)1217244138;
				short num2 = num;
				num = (short)637905898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916862464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281949697;
				if (num != 0)
				{
				}
				num = (short)747438080;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Applicable = value;
			}
		}

		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x00ABC44C File Offset: 0x00ABA64C
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x00ABC500 File Offset: 0x00ABA700
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_Valid
		{
			get
			{
				short num = (short)242810881;
				if (num != 0)
				{
				}
				num = (short)247857152;
				short num2 = num;
				num = (short)475889198;
				short num3 = num;
				num = (short)167804462;
				switch (num3 == num)
				{
				}
				num = (short)1812463616;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Valid;
			}
			set
			{
				short num = (short)1824225165;
				short num2 = num;
				num = (short)308574093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)218497024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)272171008;
				if (num != 0)
				{
				}
				num = (short)1340014593;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Valid = value;
			}
		}

		// Token: 0x17005C92 RID: 23698
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x00ABC5B8 File Offset: 0x00ABA7B8
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x00ABC66C File Offset: 0x00ABA86C
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_Visible
		{
			get
			{
				short num = (short)1114981152;
				short num2 = num;
				num = (short)1899840288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750518272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869203969;
				if (num != 0)
				{
				}
				num = (short)1244856320;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Visible;
			}
			set
			{
				short num = (short)968182773;
				short num2 = num;
				num = (short)44518389;
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
				num = (short)637796352;
				if (num != 0)
				{
				}
				num = (short)1979449345;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Visible = value;
			}
		}

		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x0600B904 RID: 47364 RVA: 0x00ABC724 File Offset: 0x00ABA924
		// (set) Token: 0x0600B905 RID: 47365 RVA: 0x00ABC7D8 File Offset: 0x00ABA9D8
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_Editable
		{
			get
			{
				short num = (short)642137354;
				short num2 = num;
				num = (short)51920138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118057984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153630208;
				if (num != 0)
				{
				}
				num = (short)1595473921;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Editable;
			}
			set
			{
				short num = (short)1427654310;
				short num2 = num;
				num = (short)1689077414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)473825280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143223809;
				if (num != 0)
				{
				}
				num = (short)1596063744;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.Editable = value;
			}
		}

		// Token: 0x17005C94 RID: 23700
		// (get) Token: 0x0600B906 RID: 47366 RVA: 0x00ABC88C File Offset: 0x00ABAA8C
		internal string CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_UILabel
		{
			get
			{
				short num = (short)1171587073;
				if (num != 0)
				{
				}
				num = (short)334036992;
				short num2 = num;
				num = (short)1972529984;
				short num3 = num;
				num = (short)1856531264;
				switch (num3 == num)
				{
				}
				num = (short)284426240;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.UIName;
			}
		}

		// Token: 0x17005C95 RID: 23701
		// (get) Token: 0x0600B907 RID: 47367 RVA: 0x00ABC940 File Offset: 0x00ABAB40
		// (set) Token: 0x0600B908 RID: 47368 RVA: 0x00ABC9F4 File Offset: 0x00ABABF4
		internal bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_HiddenStatic
		{
			get
			{
				short num = (short)1691195737;
				short num2 = num;
				num = (short)1802410329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085407232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099038721;
				if (num != 0)
				{
				}
				num = (short)1344405504;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.HiddenStatic;
			}
			set
			{
				short num = (short)1913323521;
				if (num != 0)
				{
				}
				num = (short)1073020928;
				short num2 = num;
				num = (short)177109583;
				short num3 = num;
				num = (short)661944911;
				switch (num3 == num)
				{
				}
				num = (short)1180368896;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.HiddenStatic = value;
			}
		}

		// Token: 0x17005C96 RID: 23702
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x00ABCAAC File Offset: 0x00ABACAC
		// (set) Token: 0x0600B90A RID: 47370 RVA: 0x00ABCB64 File Offset: 0x00ABAD64
		internal bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_HiddenDynamic
		{
			get
			{
				short num = (short)1406570607;
				short num2 = num;
				num = (short)1253347439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250033664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204996608;
				if (num != 0)
				{
				}
				num = (short)978124801;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.HiddenDynamic;
			}
			set
			{
				short num = (short)529562540;
				short num2 = num;
				num = (short)742489004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)397344768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075852801;
				if (num != 0)
				{
				}
				num = (short)582811648;
				if (num != 0)
				{
				}
				this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.HiddenDynamic = value;
			}
		}

		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x00ABCC1C File Offset: 0x00ABAE1C
		public bool CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445_HasDiffs
		{
			get
			{
				short num = (short)1820523150;
				short num2 = num;
				num = (short)856554126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89980928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581449217;
				if (num != 0)
				{
				}
				num = (short)1970012160;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445._HasDiffs;
			}
		}

		// Token: 0x17005C98 RID: 23704
		// (get) Token: 0x0600B90C RID: 47372 RVA: 0x00ABCCD0 File Offset: 0x00ABAED0
		// (set) Token: 0x0600B90D RID: 47373 RVA: 0x00ABCD80 File Offset: 0x00ABAF80
		public bool CnvSysDVRSPhase2SysCompatibility_43000Value
		{
			get
			{
				short num = (short)1110631988;
				short num2 = num;
				num = (short)787932724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383451136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1789067265;
				if (num != 0)
				{
				}
				num = (short)81330176;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Value;
			}
			set
			{
				short num = (short)1978400769;
				if (num != 0)
				{
				}
				num = (short)1973813248;
				short num2 = num;
				num = (short)582239105;
				short num3 = num;
				num = (short)1348027265;
				switch (num3 == num)
				{
				}
				num = (short)524353536;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Value = value;
			}
		}

		// Token: 0x17005C99 RID: 23705
		// (get) Token: 0x0600B90E RID: 47374 RVA: 0x00ABCE38 File Offset: 0x00ABB038
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSPhase2SysCompatibility_43000
		{
			get
			{
				short num = (short)1358718899;
				short num2 = num;
				num = (short)1357866931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136735744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)249561089;
				if (num != 0)
				{
				}
				num = (short)1801977856;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000;
			}
		}

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x0600B90F RID: 47375 RVA: 0x00ABCEEC File Offset: 0x00ABB0EC
		// (set) Token: 0x0600B910 RID: 47376 RVA: 0x00ABCFA0 File Offset: 0x00ABB1A0
		public bool CnvSysDVRSPhase2SysCompatibility_43000_UIValue
		{
			get
			{
				short num = (short)930000328;
				short num2 = num;
				num = (short)86027720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1179123712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114963968;
				if (num != 0)
				{
				}
				num = (short)1280442369;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Value;
			}
			set
			{
				short num = (short)628366429;
				short num2 = num;
				num = (short)119544925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2017132544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519648769;
				if (num != 0)
				{
				}
				num = (short)853278720;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Value = value;
			}
		}

		// Token: 0x17005C9B RID: 23707
		// (get) Token: 0x0600B911 RID: 47377 RVA: 0x00ABD054 File Offset: 0x00ABB254
		// (set) Token: 0x0600B912 RID: 47378 RVA: 0x00ABD108 File Offset: 0x00ABB308
		public bool CnvSysDVRSPhase2SysCompatibility_43000_Applicable
		{
			get
			{
				short num = (short)981278060;
				short num2 = num;
				num = (short)1005591916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1770127360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124452865;
				if (num != 0)
				{
				}
				num = (short)310575104;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Applicable;
			}
			set
			{
				short num = (short)975175681;
				if (num != 0)
				{
				}
				num = (short)2686976;
				short num2 = num;
				num = (short)398625447;
				short num3 = num;
				num = (short)647793319;
				switch (num3 == num)
				{
				}
				num = (short)1358364672;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Applicable = value;
			}
		}

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x00ABD1BC File Offset: 0x00ABB3BC
		// (set) Token: 0x0600B914 RID: 47380 RVA: 0x00ABD274 File Offset: 0x00ABB474
		public bool CnvSysDVRSPhase2SysCompatibility_43000_Valid
		{
			get
			{
				short num = (short)61538305;
				if (num != 0)
				{
				}
				num = (short)517210112;
				short num2 = num;
				num = (short)903513470;
				short num3 = num;
				num = (short)895780222;
				switch (num3 == num)
				{
				}
				num = (short)2081947648;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Valid;
			}
			set
			{
				short num = (short)1666528031;
				short num2 = num;
				num = (short)1285305119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362414080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1798176769;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Valid = value;
			}
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x00ABD328 File Offset: 0x00ABB528
		// (set) Token: 0x0600B916 RID: 47382 RVA: 0x00ABD3E0 File Offset: 0x00ABB5E0
		public bool CnvSysDVRSPhase2SysCompatibility_43000_Visible
		{
			get
			{
				short num = (short)381385853;
				short num2 = num;
				num = (short)652049533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1059717120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)318570497;
				if (num != 0)
				{
				}
				num = (short)2133196800;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Visible;
			}
			set
			{
				short num = (short)184209212;
				short num2 = num;
				num = (short)1948634940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639238144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431830528;
				if (num != 0)
				{
				}
				num = (short)993722369;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Visible = value;
			}
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x00ABD494 File Offset: 0x00ABB694
		// (set) Token: 0x0600B918 RID: 47384 RVA: 0x00ABD54C File Offset: 0x00ABB74C
		public bool CnvSysDVRSPhase2SysCompatibility_43000_Editable
		{
			get
			{
				short num = (short)409163180;
				short num2 = num;
				num = (short)441406892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1962409984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105723393;
				if (num != 0)
				{
				}
				num = (short)586153984;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.Editable;
			}
			set
			{
				short num = (short)1257385927;
				short num2 = num;
				num = (short)555888583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126891520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)256311297;
				if (num != 0)
				{
				}
				num = (short)2141650944;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.Editable = value;
			}
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x00ABD608 File Offset: 0x00ABB808
		internal string CnvSysDVRSPhase2SysCompatibility_43000_UILabel
		{
			get
			{
				short num = (short)1082294264;
				short num2 = num;
				num = (short)1803780088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964703744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687734785;
				if (num != 0)
				{
				}
				num = (short)905773056;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.UIName;
			}
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x0600B91A RID: 47386 RVA: 0x00ABD6BC File Offset: 0x00ABB8BC
		// (set) Token: 0x0600B91B RID: 47387 RVA: 0x00ABD774 File Offset: 0x00ABB974
		internal bool CnvSysDVRSPhase2SysCompatibility_43000_HiddenStatic
		{
			get
			{
				short num = (short)1336672257;
				if (num != 0)
				{
				}
				num = (short)1171062784;
				short num2 = num;
				num = (short)1365820286;
				short num3 = num;
				num = (short)1697104766;
				switch (num3 == num)
				{
				}
				num = (short)1973288960;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.HiddenStatic;
			}
			set
			{
				short num = (short)1643163663;
				short num2 = num;
				num = (short)659271695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)379060224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2116485120;
				if (num != 0)
				{
				}
				num = (short)1893072897;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.HiddenStatic = value;
			}
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x0600B91C RID: 47388 RVA: 0x00ABD828 File Offset: 0x00ABBA28
		// (set) Token: 0x0600B91D RID: 47389 RVA: 0x00ABD8DC File Offset: 0x00ABBADC
		internal bool CnvSysDVRSPhase2SysCompatibility_43000_HiddenDynamic
		{
			get
			{
				short num = (short)1929248769;
				if (num != 0)
				{
				}
				num = (short)244842496;
				short num2 = num;
				num = (short)163592614;
				short num3 = num;
				num = (short)205011366;
				switch (num3 == num)
				{
				}
				num = (short)708706304;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000.HiddenDynamic;
			}
			set
			{
				short num = (short)1937768449;
				if (num != 0)
				{
				}
				num = (short)1395458048;
				short num2 = num;
				num = (short)753999974;
				short num3 = num;
				num = (short)1826496614;
				switch (num3 == num)
				{
				}
				num = (short)180682752;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPhase2SysCompatibility_43000.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x0600B91E RID: 47390 RVA: 0x00ABD990 File Offset: 0x00ABBB90
		public bool CnvSysDVRSPhase2SysCompatibility_43000_HasDiffs
		{
			get
			{
				short num = (short)1775828993;
				if (num != 0)
				{
				}
				num = (short)1160708096;
				short num2 = num;
				num = (short)305077231;
				short num3 = num;
				num = (short)883956719;
				switch (num3 == num)
				{
				}
				num = (short)291373056;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPhase2SysCompatibility_43000._HasDiffs;
			}
		}

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x00ABDA44 File Offset: 0x00ABBC44
		// (set) Token: 0x0600B920 RID: 47392 RVA: 0x00ABDAF8 File Offset: 0x00ABBCF8
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810Value
		{
			get
			{
				short num = (short)2142188694;
				short num2 = num;
				num = (short)1595290774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497811456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507721217;
				if (num != 0)
				{
				}
				num = (short)2059665408;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Value;
			}
			set
			{
				short num = (short)451395858;
				short num2 = num;
				num = (short)1960558866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1538326528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)793640961;
				if (num != 0)
				{
				}
				num = (short)664403968;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Value = value;
			}
		}

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x00ABDBB0 File Offset: 0x00ABBDB0
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSPreferTalkaroundInNoComms_44810
		{
			get
			{
				short num = (short)2099110404;
				short num2 = num;
				num = (short)809165316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767243776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127822849;
				if (num != 0)
				{
				}
				num = (short)259719168;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810;
			}
		}

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x0600B922 RID: 47394 RVA: 0x00ABDC60 File Offset: 0x00ABBE60
		// (set) Token: 0x0600B923 RID: 47395 RVA: 0x00ABDD14 File Offset: 0x00ABBF14
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_UIValue
		{
			get
			{
				short num = (short)1226062117;
				short num2 = num;
				num = (short)1410087205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)940703744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1678180352;
				if (num != 0)
				{
				}
				num = (short)1814233089;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Value;
			}
			set
			{
				short num = (short)117802796;
				short num2 = num;
				num = (short)1774028588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891500032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1805320192;
				if (num != 0)
				{
				}
				num = (short)63307777;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Value = value;
			}
		}

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x0600B924 RID: 47396 RVA: 0x00ABDDC8 File Offset: 0x00ABBFC8
		// (set) Token: 0x0600B925 RID: 47397 RVA: 0x00ABDE80 File Offset: 0x00ABC080
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_Applicable
		{
			get
			{
				short num = (short)959755069;
				short num2 = num;
				num = (short)1827386173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811401216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869676544;
				if (num != 0)
				{
				}
				num = (short)1895432193;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Applicable;
			}
			set
			{
				short num = (short)1455026730;
				short num2 = num;
				num = (short)436728362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288555008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)456261633;
				if (num != 0)
				{
				}
				num = (short)1625423872;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Applicable = value;
			}
		}

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x0600B926 RID: 47398 RVA: 0x00ABDF34 File Offset: 0x00ABC134
		// (set) Token: 0x0600B927 RID: 47399 RVA: 0x00ABDFE8 File Offset: 0x00ABC1E8
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_Valid
		{
			get
			{
				short num = (short)1404069944;
				short num2 = num;
				num = (short)223111224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)539426816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)194183168;
				if (num != 0)
				{
				}
				num = (short)539820033;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Valid;
			}
			set
			{
				short num = (short)1096392705;
				short num2 = num;
				num = (short)934060033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88604672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118254592;
				if (num != 0)
				{
				}
				num = (short)942800897;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Valid = value;
			}
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0600B928 RID: 47400 RVA: 0x00ABE0A0 File Offset: 0x00ABC2A0
		// (set) Token: 0x0600B929 RID: 47401 RVA: 0x00ABE158 File Offset: 0x00ABC358
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_Visible
		{
			get
			{
				short num = (short)214544458;
				short num2 = num;
				num = (short)951758922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)74907648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1249837057;
				if (num != 0)
				{
				}
				num = (short)653393920;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Visible;
			}
			set
			{
				short num = (short)1285432805;
				short num2 = num;
				num = (short)761079269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479606272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662700033;
				if (num != 0)
				{
				}
				num = (short)443809792;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Visible = value;
			}
		}

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0600B92A RID: 47402 RVA: 0x00ABE20C File Offset: 0x00ABC40C
		// (set) Token: 0x0600B92B RID: 47403 RVA: 0x00ABE2C0 File Offset: 0x00ABC4C0
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_Editable
		{
			get
			{
				short num = (short)2047185670;
				short num2 = num;
				num = (short)557945606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380108800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264372225;
				if (num != 0)
				{
				}
				num = (short)1935540224;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Editable;
			}
			set
			{
				short num = (short)1953355657;
				short num2 = num;
				num = (short)493344649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1652948992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928317440;
				if (num != 0)
				{
				}
				num = (short)1674117121;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.Editable = value;
			}
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0600B92C RID: 47404 RVA: 0x00ABE378 File Offset: 0x00ABC578
		internal string CnvSysDVRSPreferTalkaroundInNoComms_44810_UILabel
		{
			get
			{
				short num = (short)40571848;
				short num2 = num;
				num = (short)1745425352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002845696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672661505;
				if (num != 0)
				{
				}
				num = (short)175243264;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.UIName;
			}
		}

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x0600B92D RID: 47405 RVA: 0x00ABE42C File Offset: 0x00ABC62C
		// (set) Token: 0x0600B92E RID: 47406 RVA: 0x00ABE4E4 File Offset: 0x00ABC6E4
		internal bool CnvSysDVRSPreferTalkaroundInNoComms_44810_HiddenStatic
		{
			get
			{
				short num = (short)1596579817;
				short num2 = num;
				num = (short)1751506921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912195584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454426624;
				if (num != 0)
				{
				}
				num = (short)1336475649;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.HiddenStatic;
			}
			set
			{
				short num = (short)265666520;
				short num2 = num;
				num = (short)409452504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519307264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)138739712;
				if (num != 0)
				{
				}
				num = (short)1514471425;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.HiddenStatic = value;
			}
		}

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x0600B92F RID: 47407 RVA: 0x00ABE59C File Offset: 0x00ABC79C
		// (set) Token: 0x0600B930 RID: 47408 RVA: 0x00ABE650 File Offset: 0x00ABC850
		internal bool CnvSysDVRSPreferTalkaroundInNoComms_44810_HiddenDynamic
		{
			get
			{
				short num = (short)1163226143;
				short num2 = num;
				num = (short)1082158111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1953103872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672530433;
				if (num != 0)
				{
				}
				num = (short)304807936;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810.HiddenDynamic;
			}
			set
			{
				short num = (short)1862653621;
				short num2 = num;
				num = (short)562091701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1261699072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265682945;
				if (num != 0)
				{
				}
				num = (short)1573978112;
				if (num != 0)
				{
				}
				this.cnvSysDVRSPreferTalkaroundInNoComms_44810.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x0600B931 RID: 47409 RVA: 0x00ABE708 File Offset: 0x00ABC908
		public bool CnvSysDVRSPreferTalkaroundInNoComms_44810_HasDiffs
		{
			get
			{
				short num = (short)355842792;
				short num2 = num;
				num = (short)148355816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798294016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489095168;
				if (num != 0)
				{
				}
				num = (short)2146238465;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSPreferTalkaroundInNoComms_44810._HasDiffs;
			}
		}

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x00ABE7BC File Offset: 0x00ABC9BC
		// (set) Token: 0x0600B933 RID: 47411 RVA: 0x00ABE870 File Offset: 0x00ABCA70
		public bool CnvSysDVRSDVRSyncNACMatching_44811Value
		{
			get
			{
				short num = (short)604372993;
				if (num != 0)
				{
				}
				num = (short)2097217536;
				short num2 = num;
				num = (short)373261432;
				short num3 = num;
				num = (short)1496745080;
				switch (num3 == num)
				{
				}
				num = (short)122683392;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Value;
			}
			set
			{
				short num = (short)556825082;
				short num2 = num;
				num = (short)1301314042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937820160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027145729;
				if (num != 0)
				{
				}
				num = (short)1044905984;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Value = value;
			}
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x0600B934 RID: 47412 RVA: 0x00ABE924 File Offset: 0x00ABCB24
		public global::AcpBusinessLayer.AcpField<bool> CnvSysDVRSDVRSyncNACMatching_44811
		{
			get
			{
				short num = (short)238223361;
				if (num != 0)
				{
				}
				num = (short)1022885888;
				short num2 = num;
				num = (short)1266751095;
				short num3 = num;
				num = (short)779622007;
				switch (num3 == num)
				{
				}
				num = (short)1562836992;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811;
			}
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0600B935 RID: 47413 RVA: 0x00ABE9D4 File Offset: 0x00ABCBD4
		// (set) Token: 0x0600B936 RID: 47414 RVA: 0x00ABEA88 File Offset: 0x00ABCC88
		public bool CnvSysDVRSDVRSyncNACMatching_44811_UIValue
		{
			get
			{
				short num = (short)1542342213;
				short num2 = num;
				num = (short)2140948037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962396160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661323777;
				if (num != 0)
				{
				}
				num = (short)869203968;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Value;
			}
			set
			{
				short num = (short)187332810;
				short num2 = num;
				num = (short)704608458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879624192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2139160577;
				if (num != 0)
				{
				}
				num = (short)650444800;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Value = value;
			}
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x00ABEB3C File Offset: 0x00ABCD3C
		// (set) Token: 0x0600B938 RID: 47416 RVA: 0x00ABEBF4 File Offset: 0x00ABCDF4
		public bool CnvSysDVRSDVRSyncNACMatching_44811_Applicable
		{
			get
			{
				short num = (short)1832452528;
				short num2 = num;
				num = (short)1766457776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532611072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79233025;
				if (num != 0)
				{
				}
				num = (short)421396480;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Applicable;
			}
			set
			{
				short num = (short)64159745;
				if (num != 0)
				{
				}
				num = (short)557907968;
				short num2 = num;
				num = (short)1027123280;
				short num3 = num;
				num = (short)326412368;
				switch (num3 == num)
				{
				}
				num = (short)253100032;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Applicable = value;
			}
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0600B939 RID: 47417 RVA: 0x00ABECA8 File Offset: 0x00ABCEA8
		// (set) Token: 0x0600B93A RID: 47418 RVA: 0x00ABED5C File Offset: 0x00ABCF5C
		public bool CnvSysDVRSDVRSyncNACMatching_44811_Valid
		{
			get
			{
				short num = (short)1815145844;
				short num2 = num;
				num = (short)1714285940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423835136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328400897;
				if (num != 0)
				{
				}
				num = (short)548667392;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Valid;
			}
			set
			{
				short num = (short)743243776;
				short num2 = num;
				num = (short)1126046766;
				short num3 = num;
				num = (short)117120046;
				switch (num3 == num)
				{
				}
				num = (short)803667969;
				if (num != 0)
				{
				}
				num = (short)1034027008;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Valid = value;
			}
		}

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x0600B93B RID: 47419 RVA: 0x00ABEE10 File Offset: 0x00ABD010
		// (set) Token: 0x0600B93C RID: 47420 RVA: 0x00ABEEC4 File Offset: 0x00ABD0C4
		public bool CnvSysDVRSDVRSyncNACMatching_44811_Visible
		{
			get
			{
				short num = (short)1560215552;
				short num2 = num;
				num = (short)1181138194;
				short num3 = num;
				num = (short)182041874;
				switch (num3 == num)
				{
				}
				num = (short)1489567745;
				if (num != 0)
				{
				}
				num = (short)1480130560;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Visible;
			}
			set
			{
				short num = (short)940834816;
				short num2 = num;
				num = (short)991265576;
				short num3 = num;
				num = (short)1202946856;
				switch (num3 == num)
				{
				}
				num = (short)355663873;
				if (num != 0)
				{
				}
				num = (short)235601920;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Visible = value;
			}
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x0600B93D RID: 47421 RVA: 0x00ABEF78 File Offset: 0x00ABD178
		// (set) Token: 0x0600B93E RID: 47422 RVA: 0x00ABF030 File Offset: 0x00ABD230
		public bool CnvSysDVRSDVRSyncNACMatching_44811_Editable
		{
			get
			{
				short num = (short)277610496;
				short num2 = num;
				num = (short)90618672;
				short num3 = num;
				num = (short)2116926256;
				switch (num3 == num)
				{
				}
				num = (short)2062942209;
				if (num != 0)
				{
				}
				num = (short)777781248;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.Editable;
			}
			set
			{
				short num = (short)1666711552;
				short num2 = num;
				num = (short)1211957249;
				if (num != 0)
				{
				}
				num = (short)452616115;
				short num3 = num;
				num = (short)424697779;
				switch (num3 == num)
				{
				}
				num = (short)221380608;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.Editable = value;
			}
		}

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x0600B93F RID: 47423 RVA: 0x00ABF0E4 File Offset: 0x00ABD2E4
		internal string CnvSysDVRSDVRSyncNACMatching_44811_UILabel
		{
			get
			{
				short num = (short)1342439424;
				short num2 = num;
				num = (short)1993736193;
				if (num != 0)
				{
				}
				num = (short)422664680;
				short num3 = num;
				num = (short)174283240;
				switch (num3 == num)
				{
				}
				num = (short)688783360;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.UIName;
			}
		}

		// Token: 0x17005CB6 RID: 23734
		// (get) Token: 0x0600B940 RID: 47424 RVA: 0x00ABF198 File Offset: 0x00ABD398
		// (set) Token: 0x0600B941 RID: 47425 RVA: 0x00ABF24C File Offset: 0x00ABD44C
		internal bool CnvSysDVRSDVRSyncNACMatching_44811_HiddenStatic
		{
			get
			{
				short num = (short)965148672;
				short num2 = num;
				num = (short)1021080703;
				short num3 = num;
				num = (short)220230783;
				switch (num3 == num)
				{
				}
				num = (short)548995072;
				if (num != 0)
				{
				}
				num = (short)1796866049;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.HiddenStatic;
			}
			set
			{
				short num = (short)882704384;
				short num2 = num;
				num = (short)1490550785;
				if (num != 0)
				{
				}
				num = (short)1213613845;
				short num3 = num;
				num = (short)2131576597;
				switch (num3 == num)
				{
				}
				num = (short)641597440;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.HiddenStatic = value;
			}
		}

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x00ABF304 File Offset: 0x00ABD504
		// (set) Token: 0x0600B943 RID: 47427 RVA: 0x00ABF3B8 File Offset: 0x00ABD5B8
		internal bool CnvSysDVRSDVRSyncNACMatching_44811_HiddenDynamic
		{
			get
			{
				short num = (short)567803904;
				short num2 = num;
				num = (short)1993554299;
				short num3 = num;
				num = (short)956512635;
				switch (num3 == num)
				{
				}
				num = (short)1547304960;
				if (num != 0)
				{
				}
				num = (short)430505985;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811.HiddenDynamic;
			}
			set
			{
				short num = (short)571998208;
				short num2 = num;
				num = (short)708510768;
				short num3 = num;
				num = (short)732628016;
				switch (num3 == num)
				{
				}
				num = (short)509214720;
				if (num != 0)
				{
				}
				num = (short)2064384001;
				if (num != 0)
				{
				}
				this.cnvSysDVRSDVRSyncNACMatching_44811.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x0600B944 RID: 47428 RVA: 0x00ABF46C File Offset: 0x00ABD66C
		public bool CnvSysDVRSDVRSyncNACMatching_44811_HasDiffs
		{
			get
			{
				short num = (short)2099642368;
				short num2 = num;
				num = (short)755632732;
				short num3 = num;
				num = (short)881658460;
				switch (num3 == num)
				{
				}
				num = (short)661585921;
				if (num != 0)
				{
				}
				num = (short)1577713664;
				if (num != 0)
				{
				}
				return this.cnvSysDVRSDVRSyncNACMatching_44811._HasDiffs;
			}
		}

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x0600B945 RID: 47429 RVA: 0x00ABF520 File Offset: 0x00ABD720
		// (set) Token: 0x0600B946 RID: 47430 RVA: 0x00ABF5D4 File Offset: 0x00ABD7D4
		public int CnvSysTalkaroundAudioModes_44812Value
		{
			get
			{
				short num = (short)799014912;
				short num2 = num;
				num = (short)1815666822;
				short num3 = num;
				num = (short)1052106886;
				switch (num3 == num)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				num = (short)1188626433;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.Value;
			}
			set
			{
				short num = (short)143392768;
				short num2 = num;
				num = (short)1366753281;
				if (num != 0)
				{
				}
				num = (short)1504967306;
				short num3 = num;
				num = (short)1517222538;
				switch (num3 == num)
				{
				}
				num = (short)928776192;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.Value = value;
			}
		}

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x0600B947 RID: 47431 RVA: 0x00ABF688 File Offset: 0x00ABD888
		// (set) Token: 0x0600B948 RID: 47432 RVA: 0x00ABF73C File Offset: 0x00ABD93C
		public string CnvSysTalkaroundAudioModes_44812_UIValue
		{
			get
			{
				short num = (short)1464139776;
				short num2 = num;
				num = (short)675686963;
				short num3 = num;
				num = (short)2031888947;
				switch (num3 == num)
				{
				}
				num = (short)1936326656;
				if (num != 0)
				{
				}
				num = (short)1897136129;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.UIValue;
			}
			set
			{
				short num = (short)344719360;
				short num2 = num;
				num = (short)1396290868;
				short num3 = num;
				num = (short)357676340;
				switch (num3 == num)
				{
				}
				num = (short)1688731649;
				if (num != 0)
				{
				}
				num = (short)547291136;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.UIValue = value;
			}
		}

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x0600B949 RID: 47433 RVA: 0x00ABF7F4 File Offset: 0x00ABD9F4
		public global::AcpBusinessLayer.AcpListField CnvSysTalkaroundAudioModes_44812
		{
			get
			{
				short num = (short)1569390592;
				short num2 = num;
				num = (short)1911745190;
				short num3 = num;
				num = (short)1965746854;
				switch (num3 == num)
				{
				}
				num = (short)37879809;
				if (num != 0)
				{
				}
				num = (short)1883766784;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812;
			}
		}

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x0600B94A RID: 47434 RVA: 0x00ABF8A4 File Offset: 0x00ABDAA4
		// (set) Token: 0x0600B94B RID: 47435 RVA: 0x00ABF958 File Offset: 0x00ABDB58
		public bool CnvSysTalkaroundAudioModes_44812_Applicable
		{
			get
			{
				short num = (short)571867136;
				short num2 = num;
				num = (short)1309726004;
				short num3 = num;
				num = (short)2009716020;
				switch (num3 == num)
				{
				}
				num = (short)190513153;
				if (num != 0)
				{
				}
				num = (short)108986368;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.Applicable;
			}
			set
			{
				short num = (short)1191313408;
				short num2 = num;
				num = (short)1095827457;
				if (num != 0)
				{
				}
				num = (short)1539640634;
				short num3 = num;
				num = (short)1982991674;
				switch (num3 == num)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.Applicable = value;
			}
		}

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x0600B94C RID: 47436 RVA: 0x00ABFA10 File Offset: 0x00ABDC10
		// (set) Token: 0x0600B94D RID: 47437 RVA: 0x00ABFAC4 File Offset: 0x00ABDCC4
		public bool CnvSysTalkaroundAudioModes_44812_Valid
		{
			get
			{
				short num = (short)1487863808;
				short num2 = num;
				num = (short)1861478775;
				short num3 = num;
				num = (short)1621289335;
				switch (num3 == num)
				{
				}
				num = (short)2129920001;
				if (num != 0)
				{
				}
				num = (short)217907200;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.Valid;
			}
			set
			{
				short num = (short)2119237632;
				short num2 = num;
				num = (short)1399846834;
				short num3 = num;
				num = (short)868677554;
				switch (num3 == num)
				{
				}
				num = (short)219938817;
				if (num != 0)
				{
				}
				num = (short)1360068608;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.Valid = value;
			}
		}

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x00ABFB7C File Offset: 0x00ABDD7C
		// (set) Token: 0x0600B94F RID: 47439 RVA: 0x00ABFC30 File Offset: 0x00ABDE30
		public bool CnvSysTalkaroundAudioModes_44812_Visible
		{
			get
			{
				short num = (short)702742528;
				short num2 = num;
				num = (short)263864803;
				short num3 = num;
				num = (short)874463715;
				switch (num3 == num)
				{
				}
				num = (short)143196160;
				if (num != 0)
				{
				}
				num = (short)164954113;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.Visible;
			}
			set
			{
				short num = (short)219545600;
				short num2 = num;
				num = (short)2109689821;
				short num3 = num;
				num = (short)2027769821;
				switch (num3 == num)
				{
				}
				num = (short)763559937;
				if (num != 0)
				{
				}
				num = (short)937951232;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.Visible = value;
			}
		}

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0600B950 RID: 47440 RVA: 0x00ABFCE4 File Offset: 0x00ABDEE4
		// (set) Token: 0x0600B951 RID: 47441 RVA: 0x00ABFD98 File Offset: 0x00ABDF98
		public bool CnvSysTalkaroundAudioModes_44812_Editable
		{
			get
			{
				short num = (short)753664000;
				short num2 = num;
				num = (short)270254111;
				short num3 = num;
				num = (short)2118107167;
				switch (num3 == num)
				{
				}
				num = (short)1194131456;
				if (num != 0)
				{
				}
				num = (short)569769985;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.Editable;
			}
			set
			{
				short num = (short)1295187968;
				short num2 = num;
				num = (short)855660383;
				short num3 = num;
				num = (short)1519998815;
				switch (num3 == num)
				{
				}
				num = (short)957546497;
				if (num != 0)
				{
				}
				num = (short)1417805824;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.Editable = value;
			}
		}

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x00ABFE4C File Offset: 0x00ABE04C
		internal string CnvSysTalkaroundAudioModes_44812_UILabel
		{
			get
			{
				short num = (short)615317504;
				short num2 = num;
				num = (short)1052498266;
				short num3 = num;
				num = (short)2042354010;
				switch (num3 == num)
				{
				}
				num = (short)584384513;
				if (num != 0)
				{
				}
				num = (short)1229783040;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.UIName;
			}
		}

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0600B953 RID: 47443 RVA: 0x00ABFF00 File Offset: 0x00ABE100
		// (set) Token: 0x0600B954 RID: 47444 RVA: 0x00ABFFB4 File Offset: 0x00ABE1B4
		internal bool CnvSysTalkaroundAudioModes_44812_HiddenStatic
		{
			get
			{
				short num = (short)2098593792;
				short num2 = num;
				num = (short)1340374717;
				short num3 = num;
				num = (short)1813282493;
				switch (num3 == num)
				{
				}
				num = (short)619511809;
				if (num != 0)
				{
				}
				num = (short)1087635456;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.HiddenStatic;
			}
			set
			{
				short num = (short)1691615232;
				short num2 = num;
				num = (short)2128911342;
				short num3 = num;
				num = (short)2096208878;
				switch (num3 == num)
				{
				}
				num = (short)140509184;
				if (num != 0)
				{
				}
				num = (short)1751580673;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.HiddenStatic = value;
			}
		}

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x0600B955 RID: 47445 RVA: 0x00AC0068 File Offset: 0x00ABE268
		// (set) Token: 0x0600B956 RID: 47446 RVA: 0x00AC0120 File Offset: 0x00ABE320
		internal bool CnvSysTalkaroundAudioModes_44812_HiddenDynamic
		{
			get
			{
				short num = (short)291438592;
				short num2 = num;
				num = (short)1576247796;
				short num3 = num;
				num = (short)1212981748;
				switch (num3 == num)
				{
				}
				num = (short)1009778689;
				if (num != 0)
				{
				}
				num = (short)997720064;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812.HiddenDynamic;
			}
			set
			{
				short num = (short)1376911360;
				short num2 = num;
				num = (short)1128865311;
				short num3 = num;
				num = (short)171908639;
				switch (num3 == num)
				{
				}
				num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)1619525632;
				if (num != 0)
				{
				}
				this.cnvSysTalkaroundAudioModes_44812.HiddenDynamic = value;
			}
		}

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x0600B957 RID: 47447 RVA: 0x00AC01D8 File Offset: 0x00ABE3D8
		public bool CnvSysTalkaroundAudioModes_44812_HasDiffs
		{
			get
			{
				short num = (short)987561984;
				short num2 = num;
				num = (short)1460076545;
				if (num != 0)
				{
				}
				num = (short)2001042125;
				short num3 = num;
				num = (short)976583373;
				switch (num3 == num)
				{
				}
				num = (short)1835139072;
				if (num != 0)
				{
				}
				return this.cnvSysTalkaroundAudioModes_44812._HasDiffs;
			}
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x00AC028C File Offset: 0x00ABE48C
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
				num = (short)1056112640;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)2014314499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 1:
					goto IL_FB;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)351600644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 3:
				{
					num = (short)905668921;
					short num4 = num;
					num = (short)1122986297;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)683016192;
						if (num != 0)
						{
						}
						num = (short)1869676546;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1349844993;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
			}
			IL_FB:
			IL_13C:
			num = (short)816250881;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = null;
			num = (short)186384384;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04005BDF RID: 23519
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x04005BE0 RID: 23520
		private global::AcpBusinessLayer.AcpListField cnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x04005BE1 RID: 23521
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x04005BE2 RID: 23522
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005BE3 RID: 23523
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005BE4 RID: 23524
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005BE5 RID: 23525
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005BE6 RID: 23526
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x04005BE7 RID: 23527
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005BE8 RID: 23528
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x04005BE9 RID: 23529
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvSysDVRSAttachRetries_A40142;

		// Token: 0x04005BEA RID: 23530
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x04005BEB RID: 23531
		private global::AcpBusinessLayer.AcpRecRefField cnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x04005BEC RID: 23532
		private global::AcpBusinessLayer.AcpRecRefField cnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x04005BED RID: 23533
		private global::AcpBusinessLayer.AcpField<bool> cnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x04005BEE RID: 23534
		private global::AcpBusinessLayer.AcpListField cnvSysFeatureCallType_A40147;

		// Token: 0x04005BEF RID: 23535
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x04005BF0 RID: 23536
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x04005BF1 RID: 23537
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x04005BF2 RID: 23538
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x04005BF3 RID: 23539
		private global::AcpBusinessLayer.AcpField<bool> cnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x04005BF4 RID: 23540
		private global::AcpBusinessLayer.AcpListField cnvSysTalkaroundAudioModes_44812;
	}
}
