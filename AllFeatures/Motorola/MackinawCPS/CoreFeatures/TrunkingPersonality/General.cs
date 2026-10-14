using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000C7 RID: 199
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x0019F294 File Offset: 0x0019D494
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0019F2B0 File Offset: 0x0019D4B0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0019F2C8 File Offset: 0x0019D4C8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)621215744;
			short num2 = num;
			num = (short)843021870;
			short num3 = num;
			num = (short)1330806318;
			switch (num3 == num)
			{
			}
			num = (short)279248896;
			if (num != 0)
			{
			}
			num = (short)1657208833;
			if (num != 0)
			{
			}
			this.b();
			this.trkPerGeneralAdvancedRFAGC_A7409 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢ꓤ菦鿨諪菬賮铰韲ꟴ뇶룸볺뻼ꃾ䀀㐂㄄㜆〈", a_), global::CommonResources.AcgResources.ID_ADVANCEDRFAGC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralAdvancedRFAGC_A7409LovStrs);
			this.trkPerGeneralAdvancedRFAGC_A7409.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerGeneralAdvancedRFAGC_A7409.DataTransferOrder = 17;
			this.trkEmerProfGeneralVoiceSignalType_A7500 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎铐뻒냔ꗖ觘꧚닜맞ꛠ蛢诤苦鯨諪臬맮黰髲雴鋶꫸鋺髼釾怀漂億縆礈渊刌与☐☒└✖", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkEmerProfGeneralVoiceSignalType_A7500LovStrs);
			this.trkEmerProfGeneralVoiceSignalType_A7500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralVoiceSignalType_A7500.DataTransferOrder = 67;
			this.trkPerGeneralConversationType_A7781 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢ꛤ裦蟨鷪裬鷮苰鋲致黶雸闺ꧼ蛾焀昂娄䘆㸈㰊㔌㸎", a_), global::CommonResources.AcgResources.ID_CONVERSATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralConversationType_A7781LovStrs);
			this.trkPerGeneralConversationType_A7781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralConversationType_A7781.DataTransferOrder = 18;
			this.trkPerGeneralFailsoftType_A8599 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢ꏤ蛦胨蟪黬胮韰蟲ꇴ軶觸黺ꋼ뻾㤀㘂㰄㸆", a_), global::CommonResources.AcgResources.ID_FAILSOFTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralFailsoftType_A8599LovStrs);
			this.trkPerGeneralFailsoftType_A8599.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralFailsoftType_A8599.DataTransferOrder = 8;
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤苦諨蓪菬诮郰臲賴ꗶ臸뷺迼髾瀀瘂怄椆樈爊䀌䜎欐䰒吔⼖‘⬚⤜", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYRXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.DataTransferOrder = 59;
			this.trkPerGeneralRxFrequencyMHz_A8910 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢럤鿦꿨駪裬黮蓰雲鯴银胸뛺뗼藾帀䈂㴄㸆㠈㬊", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYRXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerGeneralRxFrequencyMHz_A8910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralRxFrequencyMHz_A8910.DataTransferOrder = 60;
			this.trkEmerProfGeneralTalkgroup_A8969 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎铐뻒냔ꗖ觘꧚닜맞ꛠ蛢诤苦鯨諪臬믮郰鿲黴郶诸铺裼迾帀䈂㴄㸆㼈㈊", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTTALKGROUPID, 1, 65534, null, null, 0, 1);
			this.trkEmerProfGeneralTalkgroup_A8969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralTalkgroup_A8969.DataTransferOrder = 66;
			this.trkEmerProfGeneralTalkgroup_A8969.ShowHexValue = true;
			this.trkEmerProfGeneralKeySelect_A8970 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎铐뻒냔ꗖ觘꧚닜맞ꛠ蛢诤苦鯨諪臬ꓮ铰諲꛴鋶闸黺黼课帀䈂㴄㸆㸈㬊", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTKEYSELECT, null, null, true, false);
			this.trkEmerProfGeneralKeySelect_A8970.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralKeySelect_A8970.DataTransferOrder = 69;
			this.trkEmerProfGeneralSecureClearStrapping_A9092 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎铐뻒냔ꗖ觘꧚닜맞ꛠ蛢诤苦鯨諪臬볮铰郲胴藶鳸룺釼髾怀焂嘄猆笈樊紌缎砐紒爔䠖堘√ⴜ☞ጠ", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkEmerProfGeneralSecureClearStrapping_A9092LovStrs);
			this.trkEmerProfGeneralSecureClearStrapping_A9092.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralSecureClearStrapping_A9092.DataTransferOrder = 68;
			this.trkPerGeneralSystem_A9237 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤黦髨鿪裬苮껰닲쳴엶쫸쳺", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOSYSTEM, null, null, true, false);
			this.trkPerGeneralSystem_A9237.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralSystem_A9237.DataTransferOrder = 1;
			this.trkPerGeneralSystem_A9237.ValidateAcrossRecset = true;
			this.trkPerGeneralSystem_A9237.EvaluateRecRefs = true;
			this.trkPerGeneralSystemID_A9238 = new global::AcpBusinessLayer.AcpPointerField<int>(1, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤黦髨鿪裬苮룰럲ꫴ뛶샸짺컼쟾", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOSYSTEMID, global::AllFeatures.CodeplugGuid.b("響", a_));
			this.trkPerGeneralSystemID_A9238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralSystemID_A9238.DataTransferOrder = 46;
			this.trkPerGeneralTimeOutTimersec_A9379 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뇤軦蓨軪ꋬ髮藰ꟲ鳴髶鳸觺軼髾戀専䐄㸆㨈㰊㐌", a_), global::CommonResources.AcgResources.ID_TIMEOUTTIMERSEC, 0, 31, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
			this.trkPerGeneralTimeOutTimersec_A9379.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerGeneralTimeOutTimersec_A9379.DataTransferOrder = 38;
			this.trkPerGeneralTimeOutTimersec_A9379.ShowHexValue = false;
			this.trkPerGeneralTxFrequencyMHz_A9413 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뇤鿦꿨駪裬黮蓰雲鯴银胸뛺뗼藾帀䈂㰄㌆㠈㠊", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYTXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerGeneralTxFrequencyMHz_A9413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralTxFrequencyMHz_A9413.DataTransferOrder = 61;
			this.trkPerGeneralUnitID_A9593 = new global::AcpBusinessLayer.AcpPointerField<int>(1, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢냤触胨鿪ꓬ꯮껰닲쳴싶샸죺", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOUNITID, global::AllFeatures.CodeplugGuid.b("響", a_));
			this.trkPerGeneralUnitID_A9593.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralUnitID_A9593.DataTransferOrder = 99;
			this.trkPerGeneralTrunkingPersonalityName_A12659 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뇤闦鳨藪蛬蛮鿰铲ꗴ鋶诸裺鋼釾怀漂氄猆瀈䔊氌戎琐䰒吔☖⬘ⴚ⠜☞", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYNAME, 14);
			this.trkPerGeneralTrunkingPersonalityName_A12659.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralTrunkingPersonalityName_A12659.DataTransferOrder = 21;
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤苦諨蓪菬诮郰臲賴ꏶ臸뷺迼髾瀀瘂怄椆樈爊䀌䜎欐䰒吔☖⬘√ⴜⴞ", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYTXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.DataTransferOrder = 90;
			this.trkPerGeneralSecondaryFailsoft_A19991 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤苦諨蓪菬诮郰臲賴뇶飸鋺釼賾渀攂焄堆䠈㨊㐌㘎⠐−", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYFAILSOFT);
			this.trkPerGeneralSecondaryFailsoft_A19991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralSecondaryFailsoft_A19991.DataTransferOrder = 10;
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔鯖룘맚꧜냞軠迢뇤闦鳨藪蛬蛮鿰铲냴髶鳸觺髼髾漀怂簄圆笈搊欌明紐瘒嘔砖琘欚爜氞䠠圢䀤渦崨个䀬昮田氲琴ض8ȺԼ༾", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_EMERGENCYTXDISABLED
			}, new int[1], true, false);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.DataTransferOrder = 64;
			this.trkPerGeneralProtocolType_A8767 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerGeneralProtocolType_A8767LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerGeneralProtocolType_A8767LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뗤闦蛨鿪苬賮黰鿲ꇴ軶觸黺ꋼ뻾㤀㐂㌄〆", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOPROTOCOLTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralProtocolType_A8767LovStrs);
			this.trkPerGeneralProtocolType_A8767.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerGeneralProtocolType_A8767.DataTransferOrder = 2;
			this.trkPerGeneralDisableTransmitMode_A41742 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢ꇤ軦髨諪迬菮铰ꟲ蟴零韸裺郼雾甀丂樄挆氈吊䰌㬎‐␒℔┖", a_), global::CommonResources.AcgResources.ID_TRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralDisableTransmitMode_A41742LovStrs);
			this.trkPerGeneralDisableTransmitMode_A41742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralDisableTransmitMode_A41742.DataTransferOrder = 15;
			this.trkPerGeneralDisableTransmitMode_A41742.EvaluateRecRefs = true;
			this.trkPerFeaturesDVRSProf_A41796 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔釖볘뫚꧜꫞鏠蛢雤ꏦ뿨맪뻬뿮菰鳲鏴ꣶ룸쿺쳼죾㠀㔂", a_), global::CommonResources.AcgResources.ID_DVRSPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DVRSDISABLED
			}, new int[1], true, false);
			this.trkPerFeaturesDVRSProf_A41796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesDVRSProf_A41796.DataTransferOrder = 51;
			this.trkPerGeneralEmergencyRevertType_A41914 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢ꃤ諦賨駪諬諮鿰郲賴ꗶ鳸跺飼跾甀圂簄眆氈吊䰌㬎‐⨒␔⌖", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralEmergencyRevertType_A41914LovStrs);
			this.trkPerGeneralEmergencyRevertType_A41914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralEmergencyRevertType_A41914.DataTransferOrder = 110;
			this.trkPerGeneralRevertZone_A41916 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢럤苦鿨軪鿬鯮꯰鳲鯴鋶꛸뫺짼컾㠀㈂㌄", a_), global::CommonResources.AcgResources.ID_EMERGENCYSYSTEMREVERTREVERTZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkPerGeneralRevertZone_A41916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralRevertZone_A41916.DataTransferOrder = 112;
			this.trkPerGeneralRevertChannel_A41917 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢럤苦鿨軪鿬鯮닰鯲铴駶韸黺釼ꃾ䀀㜂㐄㸆㠈㰊", a_), global::CommonResources.AcgResources.ID_EMERGENCYSYSTEMREVERTREVERTCHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkPerGeneralRevertChannel_A41917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralRevertChannel_A41917.DataTransferOrder = 115;
			this.trkPerGeneralStrictFailsoftbyTalkgroup_43782 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢뛤鏦鯨苪軬鯮런鋲鳴鯶諸铺鯼课挀稂億昆攈怊樌紎縐昒攔䠖ⴘ⠚⨜✞ጠ", a_), global::CommonResources.AcgResources.ID_STRICTFAILSOFTBYTALKGROUP);
			this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.DataTransferOrder = 92;
			this.trkPerGeneralBroadbandProtection = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔郖볘뗚룜귞胠迢꟤闦蛨諪觬跮郰鷲釴ꟶ诸铺觼髾戀眂氄栆月", a_), global::CommonResources.AcgResources.ID_BROADPROTECTION);
			this.trkPerGeneralBroadbandProtection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerGeneralBroadbandProtection.DataTransferOrder = 116;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10178;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0019FAA4 File Offset: 0x0019DCA4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)537591823;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚ꓜ곞闠蛢裤껦귨듪곬훮쏰샲췴", a_)))
					{
						num = (short)1510998087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BFE;
				case 1:
					if (producerFields != null)
					{
						num = (short)648282120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13EF;
				case 2:
					goto IL_13A2;
				case 3:
					goto IL_76C;
				case 4:
					this.trkPerGeneralTimeOutTimersec_A9379 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚드닞蓠곢郤鏦뷨苪胬諮菰胲郴银꛸뫺쓼쳾㘀㨂", a_), global::CommonResources.AcgResources.ID_TIMEOUTTIMERSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
					this.trkPerGeneralTimeOutTimersec_A9379.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerGeneralTimeOutTimersec_A9379.DataTransferOrder = 38;
					this.trkPerGeneralTimeOutTimersec_A9379.ShowHexValue = false;
					num = (short)842203174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢돤裦胨裪裬볮飰铲鯴零闸꿺蓼迾搀専䐄〆㰈㬊㴌", a_)))
					{
						num = (short)1675034659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D68;
				case 6:
					this.trkEmerProfGeneralTalkgroup_A8969 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢뇤蛦藨胪諬鷮黰蛲藴ꣶ룸쏺쓼짾㠀", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTTALKGROUPID, null, null, 0, 1);
					this.trkEmerProfGeneralTalkgroup_A8969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralTalkgroup_A8969.DataTransferOrder = 66;
					this.trkEmerProfGeneralTalkgroup_A8969.ShowHexValue = true;
					num = (short)314507290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.trkPerGeneralConversationType_A7781 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘飚닜뇞韠蛢韤铦裨鿪蓬胮鿰ꟲ賴蟶鳸ꓺ볼죾㘀㬂㐄", a_), global::CommonResources.AcgResources.ID_CONVERSATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralConversationType_A7781LovStrs);
					this.trkPerGeneralConversationType_A7781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralConversationType_A7781.DataTransferOrder = 18;
					num = (short)1058406456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)160759873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_660;
				case 10:
					goto IL_19E;
				case 11:
					goto IL_A20;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪맬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㰌㴎⠐⌒✔", a_)))
					{
						num = (short)1141178440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C2;
				case 13:
					goto IL_FF5;
				case 14:
					goto IL_8C2;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_176;
					}
					continue;
				case 16:
					goto IL_D19;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚ꓜ곞闠蛢裤룦꣨틪\udfec\udcee웰", a_)))
					{
						num = (short)1254490193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_874;
				case 18:
					this.trkPerGeneralSecondaryFailsoft_A19991 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪꯬軮飰鿲蛴飶鿸迺ꋼ뻾\u3000㨂㰄㸆㠈", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYFAILSOFT);
					this.trkPerGeneralSecondaryFailsoft_A19991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralSecondaryFailsoft_A19991.DataTransferOrder = 10;
					num = (short)802357261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.trkPerGeneralEmergencyRevertType_A41914 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘黚냜뫞鏠蓢胤触諨鋪뿬諮蟰雲蟴菶그苺跼髾帀䈂㄄㘆〈㨊㤌", a_), global::CommonResources.AcgResources.ID_EMERGENCYREVERTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralEmergencyRevertType_A41914LovStrs);
					this.trkPerGeneralEmergencyRevertType_A41914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralEmergencyRevertType_A41914.DataTransferOrder = 110;
					num = (short)1803288620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘黚냜뫞鏠蓢胤触諨鋪뿬諮蟰雲蟴菶그苺跼髾帀䈂㄄㘆〈㨊㤌", a_)))
					{
						num = (short)711524371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E4;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘飚닜뇞韠蛢韤铦裨鿪蓬胮鿰ꟲ賴蟶鳸ꓺ볼죾㘀㬂㐄", a_)))
					{
						num = (short)1464664071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC2;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢뇤蛦藨胪諬鷮黰蛲藴ꣶ룸쏺쓼짾㠀", a_)))
					{
						num = (short)454361094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6E;
				case 23:
					this.trkPerGeneralBroadbandProtection = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘駚꿜냞胠蟢蟤蛦蟨迪뷬鷮黰蟲郴银跸鋺鋼釾", a_), global::CommonResources.AcgResources.ID_BROADPROTECTION);
					this.trkPerGeneralBroadbandProtection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralBroadbandProtection.DataTransferOrder = 116;
					num = (short)171573282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚드닞蓠곢郤鏦뷨苪胬諮菰胲郴银꛸뫺쓼쳾㘀㨂", a_)))
					{
						num = (short)1638596612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1300;
				case 25:
					this.trkPerGeneralSecondaryRxFrequencyMHz_A8904 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪뿬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㔌㘎ℐ✒", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYRXFREQUENCYMHZ);
					this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.DataTransferOrder = 59;
					num = (short)1935212583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_A6E;
				case 27:
					goto IL_1EB;
				case 28:
					this.trkPerGeneralFailsoftType_A8599 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘鷚볜뛞跠郢諤臦鷨뿪铬鿮铰곲듴쿶쳸싺쓼", a_), global::CommonResources.AcgResources.ID_FAILSOFTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralFailsoftType_A8599LovStrs);
					this.trkPerGeneralFailsoftType_A8599.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralFailsoftType_A8599.DataTransferOrder = 8;
					num = (short)936509449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘軚돜뛞闠ꫢꇤ룦꣨틪\ud8ec훮싰", a_)))
					{
						num = (short)237174833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊刌与⠐⌒Ⱄ┖", a_)))
					{
						num = (short)2007629870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FA8;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚룜꧞蓠釢釤뷦蛨藪裬냮냰쟲쓴컶죸췺", a_)))
					{
						num = (short)664141897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76C;
				case 32:
					goto IL_7BA;
				case 33:
				{
					num = (short)1477209891;
					short num3 = num;
					num = (short)1357868835;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46D;
					default:
						num = (short)1259143168;
						if (num != 0)
						{
						}
						this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨껪胬諮菰铲郴駶髸苺근跾渀攂氄欆氈䠊戌戎愐簒昔縖洘縚吜欞䐠丢氤挦瘨横ᰬᘮ࠰ଲԴ", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILESELECTION, new string[]
						{
							global::CommonResources.AcgResources.ID_EMERGENCYTXDISABLED
						}, new int[1], true, false);
						this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.DataTransferOrder = 64;
						num = (short)182714378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 34:
					goto IL_1246;
				case 35:
					this.trkEmerProfGeneralVoiceSignalType_A7500 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢돤裦胨裪裬볮飰铲鯴零闸꿺蓼迾搀専䐄〆㰈㬊㴌", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkEmerProfGeneralVoiceSignalType_A7500LovStrs);
					this.trkEmerProfGeneralVoiceSignalType_A7500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralVoiceSignalType_A7500.DataTransferOrder = 67;
					num = (short)1877278763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_874;
				case 37:
					this.trkPerGeneralDisableTransmitMode_A41742 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘鿚드곞胠臢觤苦뷨駪賬臮苰黲鳴菶듸铺駼髾帀䈂㄄㘆㸈㼊㼌", a_), global::CommonResources.AcgResources.ID_TRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralDisableTransmitMode_A41742LovStrs);
					this.trkPerGeneralDisableTransmitMode_A41742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralDisableTransmitMode_A41742.DataTransferOrder = 15;
					this.trkPerGeneralDisableTransmitMode_A41742.EvaluateRecRefs = true;
					num = (short)253034528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_1300;
				case 39:
					goto IL_968;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘駚꿜냞胠蟢蟤蛦蟨迪뷬鷮黰蟲郴银跸鋺鋼釾", a_)))
					{
						num = (short)525008919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13EF;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚ꗜ駞鏠蛢铤鋦賨藪軬雮볰믲迴ꣶ룸쏺쓼컾㄀", a_)))
					{
						num = (short)1722220610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB9;
				case 42:
					goto IL_BFE;
				case 43:
					goto IL_D68;
				case 44:
					goto IL_10E4;
				case 45:
					this.trkEmerProfGeneralKeySelect_A8970 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢껤苦部룪裬菮铰郲致ꣶ룸쏺쓼죾㄀", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTKEYSELECT, null, null, true, false);
					this.trkEmerProfGeneralKeySelect_A8970.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralKeySelect_A8970.DataTransferOrder = 69;
					num = (short)2228235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.trkEmerProfGeneralSecureClearStrapping_A9092 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊刌与⠐⌒Ⱄ┖", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACKREVERTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkEmerProfGeneralSecureClearStrapping_A9092LovStrs);
					this.trkEmerProfGeneralSecureClearStrapping_A9092.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralSecureClearStrapping_A9092.DataTransferOrder = 68;
					num = (short)779354164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄苆꓈껊뿌鿎ꏐ볒돔郖볘뗚룜귞胠迢껤苦部룪裬菮铰郲致ꣶ룸쏺쓼죾㄀", a_)))
					{
						num = (short)192872493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A20;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘鿚드곞胠臢觤苦뷨駪賬臮苰黲鳴菶듸铺駼髾帀䈂㄄㘆㸈㼊㼌", a_)))
					{
						num = (short)2103574565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7BA;
				case 49:
					this.trkPerGeneralUnitID_A9593 = new global::AcpBusinessLayer.AcpPointerField<int>(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘軚돜뛞闠ꫢꇤ룦꣨틪\ud8ec훮싰", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOUNITID, global::AllFeatures.CodeplugGuid.b("", a_));
					this.trkPerGeneralUnitID_A9593.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralUnitID_A9593.DataTransferOrder = 99;
					num = (short)1415839771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_291;
				case 51:
					num = (short)2040463361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					goto IL_FA8;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪뿬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㔌㘎ℐ✒", a_)))
					{
						num = (short)1822425113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_968;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾伀戂栄戆嘈䨊㰌㴎✐☒Ⱄ", a_)))
					{
						num = (short)1700528192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A2;
				case 55:
					this.trkPerGeneralAdvancedRFAGC_A7409 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘髚맜꧞胠跢蛤苦跨맪꯬껮뛰냲ꫴ뛶컸쿺췼웾", a_), global::CommonResources.AcgResources.ID_ADVANCEDRFAGC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralAdvancedRFAGC_A7409LovStrs);
					this.trkPerGeneralAdvancedRFAGC_A7409.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerGeneralAdvancedRFAGC_A7409.DataTransferOrder = 17;
					num = (short)940900409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_EC2;
				case 57:
					goto IL_F5C;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚ꗜ駞鏠蛢铤鋦賨藪軬雮볰믲迴ꣶ룸싺짼컾㈀", a_)))
					{
						num = (short)2107834447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BB2;
				case 59:
					this.trkPerGeneralProtocolType_A8767 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerGeneralProtocolType_A8767LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerGeneralProtocolType_A8767LovStrs), this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘诚꿜냞闠賢蛤裦藨뿪铬鿮铰곲듴쿶컸췺쫼", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOPROTOCOLTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerGeneralProtocolType_A8767LovStrs);
					this.trkPerGeneralProtocolType_A8767.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralProtocolType_A8767.DataTransferOrder = 2;
					num = (short)1368522832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					goto IL_550;
				case 61:
					this.trkPerFeaturesDVRSProf_A41796 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊诌꫎냐꟒ꃔꗖ볘꣚駜觞돠냢뗤闦蛨跪달껮연싲싴컶쿸", a_), global::CommonResources.AcgResources.ID_DVRSPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DVRSDISABLED
					}, new int[1], true, false);
					this.trkPerFeaturesDVRSProf_A41796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesDVRSProf_A41796.DataTransferOrder = 51;
					num = (short)1627324466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					goto IL_BB2;
				case 63:
					this.trkPerGeneralRevertChannel_A41917 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚룜꧞蓠釢釤ꓦ臨諪菬臮铰鿲ꫴ뛶췸쫺쓼컾㘀", a_), global::CommonResources.AcgResources.ID_EMERGENCYSYSTEMREVERTREVERTCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkPerGeneralRevertChannel_A41917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralRevertChannel_A41917.DataTransferOrder = 115;
					num = (short)1148387344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					num = (short)518586369;
					if (num != 0)
					{
					}
					this.trkPerGeneralTrunkingPersonalityName_A12659 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾伀戂栄戆嘈䨊㰌㴎✐☒Ⱄ", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYNAME, 14);
					this.trkPerGeneralTrunkingPersonalityName_A12659.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralTrunkingPersonalityName_A12659.DataTransferOrder = 21;
					goto IL_46D;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘髚맜꧞胠跢蛤苦跨맪꯬껮뛰냲ꫴ뛶컸쿺췼웾", a_)))
					{
						num = (short)169082935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F5C;
				case 66:
					this.trkPerGeneralRxFrequencyMHz_A8910 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚ꗜ駞鏠蛢铤鋦賨藪軬雮볰믲迴ꣶ룸쏺쓼컾㄀", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYRXFREQUENCYMHZ);
					this.trkPerGeneralRxFrequencyMHz_A8910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralRxFrequencyMHz_A8910.DataTransferOrder = 60;
					num = (short)1478557763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					goto IL_AB9;
				case 68:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚룜꧞蓠釢釤ꓦ臨諪菬臮铰鿲ꫴ뛶췸쫺쓼컾㘀", a_)))
					{
						num = (short)88670271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D19;
				case 69:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚꧜귞裠胢釤ꇦ裨苪臬鳮黰闲致闶胸꿺鳼鏾樀搂眄栆簈笊刌㬎∐␒ⴔ┖", a_)))
					{
						num = (short)1264320590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_550;
				case 70:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨껪胬諮菰铲郴駶髸苺근跾渀攂氄欆氈䠊戌戎愐簒昔縖洘縚吜欞䐠丢氤挦瘨横ᰬᘮ࠰ଲԴ", a_)))
					{
						num = (short)1145045025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 71:
					this.trkPerGeneralSystemID_A9238 = new global::AcpBusinessLayer.AcpPointerField<int>(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚ꓜ곞闠蛢裤껦귨듪곬훮쏰샲췴", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOSYSTEMID, global::AllFeatures.CodeplugGuid.b("", a_));
					this.trkPerGeneralSystemID_A9238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralSystemID_A9238.DataTransferOrder = 46;
					num = (short)1336803370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 72:
					this.trkPerGeneralSecondaryTxFrequencyMHz_A12902 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪맬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㰌㴎⠐⌒✔", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYSECONDARYTXFREQUENCYMHZ);
					this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.DataTransferOrder = 90;
					num = (short)2095775758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 73:
					this.trkPerGeneralRevertZone_A41916 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘觚룜꧞蓠釢釤뷦蛨藪裬냮냰쟲쓴컶죸췺", a_), global::CommonResources.AcgResources.ID_EMERGENCYSYSTEMREVERTREVERTZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkPerGeneralRevertZone_A41916.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralRevertZone_A41916.DataTransferOrder = 112;
					num = (short)590938115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 74:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘鷚볜뛞跠郢諤臦鷨뿪铬鿮铰곲듴쿶쳸싺쓼", a_)))
					{
						num = (short)613089308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_660;
				case 75:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚룜볞軠跢臤蛦鯨鋪꯬軮飰鿲蛴飶鿸迺ꋼ뻾\u3000㨂㰄㸆㠈", a_)))
					{
						num = (short)307429394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF5;
				case 76:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘诚꿜냞闠賢蛤裦藨뿪铬鿮铰곲듴쿶컸췺쫼", a_)))
					{
						num = (short)389742651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F0F;
				case 77:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊诌꫎냐꟒ꃔꗖ볘꣚駜觞돠냢뗤闦蛨跪달껮연싲싴컶쿸", a_)))
					{
						num = (short)1797587005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 78:
					this.trkPerGeneralStrictFailsoftbyTalkgroup_43782 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚꧜귞裠胢釤ꇦ裨苪臬鳮黰闲致闶胸꿺鳼鏾樀搂眄栆簈笊刌㬎∐␒ⴔ┖", a_), global::CommonResources.AcgResources.ID_STRICTFAILSOFTBYTALKGROUP);
					this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.DataTransferOrder = 92;
					num = (short)1692467260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 79:
					this.trkPerGeneralTxFrequencyMHz_A9413 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘迚ꗜ駞鏠蛢铤鋦賨藪軬雮볰믲迴ꣶ룸싺짼컾㈀", a_), global::CommonResources.AcgResources.ID_TYPEIIFAILSOFTBYPERSONALITYTXFREQUENCYMHZ);
					this.trkPerGeneralTxFrequencyMHz_A9413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerGeneralTxFrequencyMHz_A9413.DataTransferOrder = 61;
					num = (short)2126774334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 80:
					goto IL_F0F;
				case 81:
					this.trkPerGeneralSystem_A9237 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊諌꫎뿐뛒꟔뛖뗘裚ꓜ곞闠蛢裤룦꣨틪\udfec\udcee웰", a_), global::CommonResources.AcgResources.ID_SYSTEMINFOSYSTEM, null, null, true, false);
					this.trkPerGeneralSystem_A9237.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerGeneralSystem_A9237.DataTransferOrder = 1;
					this.trkPerGeneralSystem_A9237.ValidateAcrossRecset = true;
					this.trkPerGeneralSystem_A9237.EvaluateRecRefs = true;
					num = (short)452526116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_176:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)689373235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19E:
				num = (short)1917714508;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB:
				num = (short)288358454;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_291:
				num = (short)1162870804;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46D:
				num = (short)593690626;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_550:
				num = (short)761004032;
				short num4 = num;
				num = (short)1838088232;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_660:
				num = (short)735838261;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_76C:
				num = (short)997261380;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7BA:
				num = (short)939917389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_874:
				num = (short)421396480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C2:
				num = (short)712245323;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_968:
				num = (short)1265827881;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A20:
				num = (short)162136094;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6E:
				num = (short)1689321519;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AB9:
				num = (short)200998934;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BB2:
				num = (short)1058865181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BFE:
				num = (short)1261633560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D19:
				num = (short)1693974597;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D68:
				num = (short)1237843989;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC2:
				num = (short)1681129546;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F0F:
				num = (short)819200048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F5C:
				num = (short)1151467525;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FA8:
				num = (short)1308033041;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FF5:
				num = (short)870318150;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10E4:
				num = (short)1719533599;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1300:
				num = (short)1057030202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13A2:
				num = (short)1952317452;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1246:
			IL_13EF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛀ꛂꯄꋆ믈꫊ꇌ", a_);
			base.Id = 10178;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x001A0ED4 File Offset: 0x0019F0D4
		public override void PopulateReferences()
		{
			short num = (short)1488855287;
			short num2 = num;
			num = (short)791421175;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1010106368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)50003968;
			if (num != 0)
			{
			}
			num = (short)384892929;
			if (num != 0)
			{
			}
			this.trkPerGeneralSystem_A9237.SetRecset(this.a(2064));
			global::AcpCommonLib.IAcpRecordset secureKeysRecset = this.GetSecureKeysRecset();
			this.trkEmerProfGeneralKeySelect_A8970.SetRecset(secureKeysRecset);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.SetRecset(this.a(2076));
			this.trkPerFeaturesDVRSProf_A41796.SetRecset(this.a(4143));
			this.trkPerGeneralRevertZone_A41916.SetRecset(this.a(2051));
			this.trkPerGeneralRevertZone_A41916.AddSlaveField(this.trkPerGeneralRevertChannel_A41917, 10114);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x001A1000 File Offset: 0x0019F200
		internal global::AcpCommonLib.IAcpRecordset GetSecureKeysRecset()
		{
			short num = (short)1983905792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_28:
					bool? flag;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)1089798145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return embeddedRecset;
					case 2:
					{
						bool? flag2;
						flag = flag2;
						goto IL_2A7;
					}
					case 3:
					{
						num = (short)1164997931;
						short num3 = num;
						num = (short)1648063787;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D8;
						default:
						{
							num = (short)468123648;
							if (num != 0)
							{
							}
							num = (short)1183186944;
							short num4 = num;
							num = (short)1243480065;
							if (num != 0)
							{
							}
							num = (short)256901125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						num = (short)1282408454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
						if (general == null)
						{
							bool? flag2 = null;
							num = (short)620822530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
						goto IL_2A7;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.Value > 0)
						{
							num = (short)967639048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 7:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							goto IL_2D8;
						}
						return embeddedRecset;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = global::AcpCommonLib.FeatureManager.GetFeature(2055)[trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.Value - 1] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1032126476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (this.trkPerGeneralSystem_A9237.ReferencedNode != null)
						{
							num = (short)1191968778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = this.trkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						num = (short)2096300043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.ReferencedNode != null)
						{
							num = (short)826408964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)2094792707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					}
					goto IL_63;
					IL_2A7:
					flag3 = flag;
					flag4 = true;
					num = (short)1732575239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)879624192;
					num2 = (int)((global::System.IntPtr)num);
				}
				return embeddedRecset;
				IL_63:
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)1304756233;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x001A1350 File Offset: 0x0019F550
		public override void DropReferences()
		{
			short num = (short)1449459712;
			short num2 = num;
			num = (short)1698560649;
			short num3 = num;
			num = (short)2024209033;
			switch (num3 == num)
			{
			}
			num = (short)770637825;
			if (num != 0)
			{
			}
			num = (short)462684160;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x001A13FC File Offset: 0x0019F5FC
		public override void SetConstraints()
		{
			short num = (short)4325376;
			short num2 = num;
			num = (short)2050968069;
			short num3 = num;
			num = (short)1224100357;
			switch (num3 == num)
			{
			}
			num = (short)1928134656;
			if (num != 0)
			{
			}
			num = (short)599326721;
			if (num != 0)
			{
			}
			this.trkEmerProfGeneralVoiceSignalType_A7500.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkEmerProfGeneralVoiceSignalType_A7500.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeIINot900MDigital);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.Con2ndFsEnableAndTypeIIAndFsTypeIsPersonalityAndCoverageTypeNotSmartZone);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIIFailsoftSecRxFreqIsValid);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueTypeIIFailsoftbyPerSecondaryTxFrequency);
			this.trkPerGeneralRxFrequencyMHz_A8910.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerFailsoftTypeIsPersonalityAndTrkPerTypeIsTypeIIAndTrkSysAmssSelIsNotSmartZone);
			this.trkPerGeneralRxFrequencyMHz_A8910.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIIFailsoftRxFreqIsValid);
			this.trkPerGeneralRxFrequencyMHz_A8910.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerGeneralRxFrequencyMHz_A8910.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueTypeIIFailsoftbyPerTxFrequency);
			this.trkEmerProfGeneralTalkgroup_A8969.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateTalkgroupRangeForTypeII);
			this.trkEmerProfGeneralKeySelect_A8970.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTgKeyApplicable);
			this.trkEmerProfGeneralKeySelect_A8970.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConKeySelect8970IsValid);
			this.trkEmerProfGeneralSecureClearStrapping_A9092.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSecOpHwOrSecOpAdpAndASTRO25);
			this.trkEmerProfGeneralSecureClearStrapping_A9092.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateRevertSecureStrapping);
			this.trkPerGeneralSystem_A9237.ValidateAcrossRecset = true;
			this.trkPerGeneralSystem_A9237.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTrkPerGeneralSystemValid);
			this.trkPerGeneralSystem_A9237.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.SetEmergencyTalkbackRevertOtarKeys);
			this.trkPerGeneralSystemID_A9238.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetTrkPerSysIdPointerToTrkSysSysID);
			this.trkPerGeneralSystemID_A9238.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.SetEditabilityAlwaysFalse);
			this.trkPerGeneralTimeOutTimersec_A9379.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkTimeOutTimerValid);
			this.trkPerGeneralTxFrequencyMHz_A9413.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIITxFreqApplicability);
			this.trkPerGeneralTxFrequencyMHz_A9413.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIIFailsoftTxFreqIsValid);
			this.trkPerGeneralTxFrequencyMHz_A9413.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerGeneralTxFrequencyMHz_A9413.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIITxFreqApplicabilityEditbl);
			this.trkPerGeneralUnitID_A9593.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetTrkPerUntIdPointerToTrkSysUntIDAndSetEditabilityFalse);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIISecondaryTxApplicability);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIIFailsoftSecTxFreqIsValid);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTypeIISecondaryTxApplicabilityEditabl);
			this.trkPerGeneralSecondaryFailsoft_A19991.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerTypeIIAndFsTypeIsPersonalityAndCoverageTypeNotSmartZone);
			this.trkPerGeneralSecondaryFailsoft_A19991.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateEmergencyProfile);
			this.trkPerGeneralProtocolType_A8767.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conEnsureTrkPerProtoTypeMatchesTrkSysSysType);
			this.trkPerGeneralProtocolType_A8767.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueTypeIIFailsoftbyPerAllTxFrequency);
			this.trkPerGeneralDisableTransmitMode_A41742.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTiggerRevertChannelApplicableForTrk);
			this.trkPerFeaturesDVRSProf_A41796.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConDVRSHardWareIsEnabled);
			this.trkPerGeneralEmergencyRevertType_A41914.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyTypeApplcaible);
			this.trkPerGeneralEmergencyRevertType_A41914.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyTypeEditable);
			this.trkPerGeneralRevertZone_A41916.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertZoneApplicable);
			this.trkPerGeneralRevertZone_A41916.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertZoneValid);
			this.trkPerGeneralRevertZone_A41916.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertZoneEditable);
			this.trkPerGeneralRevertChannel_A41917.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertChannelApplicable);
			this.trkPerGeneralRevertChannel_A41917.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertChannelValid);
			this.trkPerGeneralRevertChannel_A41917.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkEmergencyRevertChannelEditable);
			this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConFailsoftIsTalkGrp);
			this.trkPerGeneralAdvancedRFAGC_A7409.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAdvancedRFAGCSmartOptionValid);
			this.trkPerGeneralBroadbandProtection.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TrkGeneralSmartRFAGCOptionApplicable);
			this.trkPerGeneralBroadbandProtection.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TrkGeneralBroadbandProtectionValid);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x001A18FC File Offset: 0x0019FAFC
		public override void SetupDependencies()
		{
			short num = (short)258080768;
			short num2 = num;
			num = (short)1958734351;
			short num3 = num;
			num = (short)476113423;
			switch (num3 == num)
			{
			}
			num = (short)1471414272;
			if (num != 0)
			{
			}
			num = (short)47710209;
			if (num != 0)
			{
			}
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkEmerProfGeneralVoiceSignalType_A7500);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkEmerProfGeneralVoiceSignalType_A7500);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.trkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.trkPerGeneralSecondaryFailsoft_A19991.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.AddDependentObject(this.trkPerGeneralSecondaryRxFrequencyMHz_A8904);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.trkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.trkPerGeneralTxFrequencyMHz_A9413.AddDependentObject(this.trkPerGeneralRxFrequencyMHz_A8910);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkEmerProfGeneralTalkgroup_A8969);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.trkEmerProfGeneralSecureClearStrapping_A9092.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkEmerProfGeneralKeySelect_A8970);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkEmerProfGeneralSecureClearStrapping_A9092);
			this.trkEmerProfGeneralVoiceSignalType_A7500.AddDependentObject(this.trkEmerProfGeneralSecureClearStrapping_A9092);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkEmerProfGeneralSecureClearStrapping_A9092);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkEmerProfGeneralSecureClearStrapping_A9092);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralSystemID_A9238);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.trkPerGeneralRxFrequencyMHz_A8910.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.trkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerGeneralTxFrequencyMHz_A9413);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralUnitID_A9593);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.trkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.trkPerGeneralSecondaryFailsoft_A19991.AddDependentObject(this.trkPerGeneralSecondaryTxFrequencyMHz_A12902);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerGeneralSecondaryFailsoft_A19991);
			this.trkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerGeneralSecondaryFailsoft_A19991);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralSecondaryFailsoft_A19991);
			this.trkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980);
			this.trkPerGeneralSystem_A9237.AddDependentObject(this.trkPerGeneralProtocolType_A8767);
			this.trkPerGeneralRxFrequencyMHz_A8910.AddDependentObject(this.trkPerGeneralProtocolType_A8767);
			this.trkPerGeneralTxFrequencyMHz_A9413.AddDependentObject(this.trkPerGeneralProtocolType_A8767);
			this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.AddDependentObject(this.trkPerGeneralProtocolType_A8767);
			this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.AddDependentObject(this.trkPerGeneralProtocolType_A8767);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkPerFeaturesDVRSProf_A41796);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.AddDependentObject(this.trkPerGeneralEmergencyRevertType_A41914);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.AddDependentObject(this.trkPerGeneralEmergencyRevertType_A41914);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.AddDependentObject(this.trkPerGeneralRevertZone_A41916);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.AddDependentObject(this.trkPerGeneralRevertZone_A41916);
			this.trkPerGeneralEmergencyRevertType_A41914.AddDependentObject(this.trkPerGeneralRevertZone_A41916);
			this.trkPerGeneralDisableTransmitMode_A41742.AddDependentObject(this.trkPerGeneralRevertChannel_A41917);
			this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.AddDependentObject(this.trkPerGeneralRevertChannel_A41917);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.AddDependentObject(this.trkPerGeneralRevertChannel_A41917);
			this.trkPerGeneralEmergencyRevertType_A41914.AddDependentObject(this.trkPerGeneralRevertChannel_A41917);
			this.trkPerGeneralRevertZone_A41916.AddDependentObject(this.trkPerGeneralRevertChannel_A41917);
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x001A2074 File Offset: 0x001A0274
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkEmerProfGeneralKeySelect_A8970
		{
			get
			{
				short num = (short)1688666112;
				short num2 = num;
				num = (short)1047265281;
				if (num != 0)
				{
				}
				num = (short)1426617173;
				short num3 = num;
				num = (short)2097640277;
				switch (num3 == num)
				{
				}
				num = (short)502267904;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x001A2130 File Offset: 0x001A0330
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem TrunkingSystemForTrkPerGeneralSystem_A9237
		{
			get
			{
				short num = (short)514654208;
				short num2 = num;
				num = (short)259840127;
				short num3 = num;
				num = (short)383834239;
				switch (num3 == num)
				{
				}
				num = (short)2131099649;
				if (num != 0)
				{
				}
				num = (short)1147600896;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x001A21E8 File Offset: 0x001A03E8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles TrunkingEmergencyProfilesForTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980
		{
			get
			{
				short num = (short)808321024;
				short num2 = num;
				num = (short)778775797;
				short num3 = num;
				num = (short)1431710965;
				switch (num3 == num)
				{
				}
				num = (short)893255681;
				if (num != 0)
				{
				}
				num = (short)185663488;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x001A22A4 File Offset: 0x001A04A4
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles DVRSProfilesForTrkPerFeaturesDVRSProf_A41796
		{
			get
			{
				short num = (short)1133903872;
				short num2 = num;
				num = (short)1421386059;
				short num3 = num;
				num = (short)1143120203;
				switch (num3 == num)
				{
				}
				num = (short)1220804608;
				if (num != 0)
				{
				}
				num = (short)1114308609;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x001A2360 File Offset: 0x001A0560
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForTrkPerGeneralRevertZone_A41916
		{
			get
			{
				short num = (short)954597376;
				short num2 = num;
				num = (short)256316420;
				short num3 = num;
				num = (short)1784288260;
				switch (num3 == num)
				{
				}
				num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)320339968;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x001A241C File Offset: 0x001A061C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForTrkPerGeneralRevertChannel_A41917
		{
			get
			{
				short num = (short)1258291200;
				short num2 = num;
				num = (short)1149578385;
				short num3 = num;
				num = (short)1328557201;
				switch (num3 == num)
				{
				}
				num = (short)1539178496;
				if (num != 0)
				{
				}
				num = (short)178782209;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x001A24D4 File Offset: 0x001A06D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)67043328;
				short num2 = num;
				num = (short)312679754;
				short num3 = num;
				num = (short)2145721674;
				switch (num3 == num)
				{
				}
				num = (short)1970864129;
				if (num != 0)
				{
				}
				num = (short)1348141056;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x001A2580 File Offset: 0x001A0780
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x001A2638 File Offset: 0x001A0838
		public int TrkPerGeneralAdvancedRFAGC_A7409Value
		{
			get
			{
				short num = (short)1245446144;
				short num2 = num;
				num = (short)86038592;
				short num3 = num;
				num = (short)748345408;
				switch (num3 == num)
				{
				}
				num = (short)430440449;
				if (num != 0)
				{
				}
				num = (short)1778909184;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.Value;
			}
			set
			{
				short num = (short)1283325952;
				short num2 = num;
				num = (short)1608223449;
				short num3 = num;
				num = (short)308644569;
				switch (num3 == num)
				{
				}
				num = (short)24379392;
				if (num != 0)
				{
				}
				num = (short)1734868993;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.Value = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x001A26EC File Offset: 0x001A08EC
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x001A27A0 File Offset: 0x001A09A0
		public string TrkPerGeneralAdvancedRFAGC_A7409_UIValue
		{
			get
			{
				short num = (short)1776680960;
				short num2 = num;
				num = (short)465554147;
				short num3 = num;
				num = (short)1507642083;
				switch (num3 == num)
				{
				}
				num = (short)93388800;
				if (num != 0)
				{
				}
				num = (short)1186201601;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.UIValue;
			}
			set
			{
				short num = (short)1889533952;
				short num2 = num;
				num = (short)1888097297;
				short num3 = num;
				num = (short)819663889;
				switch (num3 == num)
				{
				}
				num = (short)538705921;
				if (num != 0)
				{
				}
				num = (short)38666240;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.UIValue = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x001A285C File Offset: 0x001A0A5C
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralAdvancedRFAGC_A7409
		{
			get
			{
				short num = (short)1278607360;
				short num2 = num;
				num = (short)1198237792;
				short num3 = num;
				num = (short)1689430112;
				switch (num3 == num)
				{
				}
				num = (short)1716715520;
				if (num != 0)
				{
				}
				num = (short)1893466113;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x001A290C File Offset: 0x001A0B0C
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x001A29C0 File Offset: 0x001A0BC0
		public bool TrkPerGeneralAdvancedRFAGC_A7409_Applicable
		{
			get
			{
				short num = (short)2107703296;
				short num2 = num;
				num = (short)2139585849;
				short num3 = num;
				num = (short)620985657;
				switch (num3 == num)
				{
				}
				num = (short)1851326465;
				if (num != 0)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.Applicable;
			}
			set
			{
				short num = (short)1793589248;
				short num2 = num;
				num = (short)498519203;
				short num3 = num;
				num = (short)204590243;
				switch (num3 == num)
				{
				}
				num = (short)988282880;
				if (num != 0)
				{
				}
				num = (short)1699282945;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.Applicable = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x001A2A78 File Offset: 0x001A0C78
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x001A2B2C File Offset: 0x001A0D2C
		public bool TrkPerGeneralAdvancedRFAGC_A7409_Valid
		{
			get
			{
				short num = (short)1347682304;
				short num2 = num;
				num = (short)2125463553;
				if (num != 0)
				{
				}
				num = (short)1499454202;
				short num3 = num;
				num = (short)2061687546;
				switch (num3 == num)
				{
				}
				num = (short)1605894144;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.Valid;
			}
			set
			{
				short num = (short)4980736;
				short num2 = num;
				num = (short)1347723938;
				short num3 = num;
				num = (short)1410638498;
				switch (num3 == num)
				{
				}
				num = (short)1413677057;
				if (num != 0)
				{
				}
				num = (short)828375040;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.Valid = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x001A2BE0 File Offset: 0x001A0DE0
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x001A2C94 File Offset: 0x001A0E94
		public bool TrkPerGeneralAdvancedRFAGC_A7409_Visible
		{
			get
			{
				short num = (short)1533214720;
				short num2 = num;
				num = (short)1046544385;
				if (num != 0)
				{
				}
				num = (short)469316382;
				short num3 = num;
				num = (short)1458385694;
				switch (num3 == num)
				{
				}
				num = (short)965607424;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.Visible;
			}
			set
			{
				short num = (short)507838464;
				short num2 = num;
				num = (short)1283784705;
				if (num != 0)
				{
				}
				num = (short)932310712;
				short num3 = num;
				num = (short)330886840;
				switch (num3 == num)
				{
				}
				num = (short)1693843456;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.Visible = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x001A2D4C File Offset: 0x001A0F4C
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x001A2E00 File Offset: 0x001A1000
		public bool TrkPerGeneralAdvancedRFAGC_A7409_Editable
		{
			get
			{
				short num = (short)935854080;
				short num2 = num;
				num = (short)1078183916;
				short num3 = num;
				num = (short)1204996076;
				switch (num3 == num)
				{
				}
				num = (short)178126848;
				if (num != 0)
				{
				}
				num = (short)953745409;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.Editable;
			}
			set
			{
				short num = (short)1882259456;
				short num2 = num;
				num = (short)982549146;
				short num3 = num;
				num = (short)188383898;
				switch (num3 == num)
				{
				}
				num = (short)1226702849;
				if (num != 0)
				{
				}
				num = (short)1029832704;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.Editable = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x001A2EB4 File Offset: 0x001A10B4
		internal string TrkPerGeneralAdvancedRFAGC_A7409_UILabel
		{
			get
			{
				short num = (short)81199104;
				short num2 = num;
				num = (short)1326579994;
				short num3 = num;
				num = (short)440664346;
				switch (num3 == num)
				{
				}
				num = (short)1879703553;
				if (num != 0)
				{
				}
				num = (short)105381888;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.UIName;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x001A2F68 File Offset: 0x001A1168
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x001A301C File Offset: 0x001A121C
		internal bool TrkPerGeneralAdvancedRFAGC_A7409_HiddenStatic
		{
			get
			{
				short num = (short)1606483968;
				short num2 = num;
				num = (short)1028754644;
				short num3 = num;
				num = (short)1072336084;
				switch (num3 == num)
				{
				}
				num = (short)689504257;
				if (num != 0)
				{
				}
				num = (short)985595904;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.HiddenStatic;
			}
			set
			{
				short num = (short)363003904;
				short num2 = num;
				num = (short)101243506;
				short num3 = num;
				num = (short)1505483378;
				switch (num3 == num)
				{
				}
				num = (short)72941569;
				if (num != 0)
				{
				}
				num = (short)1135017984;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.HiddenStatic = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x001A30D4 File Offset: 0x001A12D4
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x001A318C File Offset: 0x001A138C
		internal bool TrkPerGeneralAdvancedRFAGC_A7409_HiddenDynamic
		{
			get
			{
				short num = (short)1453981696;
				short num2 = num;
				num = (short)1201129428;
				short num3 = num;
				num = (short)37275604;
				switch (num3 == num)
				{
				}
				num = (short)345833473;
				if (num != 0)
				{
				}
				num = (short)97058816;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409.HiddenDynamic;
			}
			set
			{
				short num = (short)1990328320;
				short num2 = num;
				num = (short)365511811;
				short num3 = num;
				num = (short)887047299;
				switch (num3 == num)
				{
				}
				num = (short)131596288;
				if (num != 0)
				{
				}
				num = (short)243400705;
				if (num != 0)
				{
				}
				this.trkPerGeneralAdvancedRFAGC_A7409.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x001A3244 File Offset: 0x001A1444
		public bool TrkPerGeneralAdvancedRFAGC_A7409_HasDiffs
		{
			get
			{
				short num = (short)1930887168;
				short num2 = num;
				num = (short)2073427969;
				if (num != 0)
				{
				}
				num = (short)2085458112;
				short num3 = num;
				num = (short)565874880;
				switch (num3 == num)
				{
				}
				num = (short)514785280;
				if (num != 0)
				{
				}
				return this.trkPerGeneralAdvancedRFAGC_A7409._HasDiffs;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x001A32FC File Offset: 0x001A14FC
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x001A33B0 File Offset: 0x001A15B0
		public int TrkEmerProfGeneralVoiceSignalType_A7500Value
		{
			get
			{
				short num = (short)194314240;
				short num2 = num;
				num = (short)1983806351;
				short num3 = num;
				num = (short)832666511;
				switch (num3 == num)
				{
				}
				num = (short)1888616449;
				if (num != 0)
				{
				}
				num = (short)1030094848;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.Value;
			}
			set
			{
				short num = (short)2146697216;
				short num2 = num;
				num = (short)2102167525;
				short num3 = num;
				num = (short)350128101;
				switch (num3 == num)
				{
				}
				num = (short)1259798528;
				if (num != 0)
				{
				}
				num = (short)1315045377;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.Value = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x001A3468 File Offset: 0x001A1668
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x001A351C File Offset: 0x001A171C
		public string TrkEmerProfGeneralVoiceSignalType_A7500_UIValue
		{
			get
			{
				short num = (short)1519648768;
				short num2 = num;
				num = (short)448611734;
				short num3 = num;
				num = (short)1516586390;
				switch (num3 == num)
				{
				}
				num = (short)1857355777;
				if (num != 0)
				{
				}
				num = (short)951517184;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.UIValue;
			}
			set
			{
				short num = (short)1072431104;
				short num2 = num;
				num = (short)1183783925;
				short num3 = num;
				num = (short)105389045;
				switch (num3 == num)
				{
				}
				num = (short)1248526337;
				if (num != 0)
				{
				}
				num = (short)1581318144;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.UIValue = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x001A35D0 File Offset: 0x001A17D0
		public global::AcpBusinessLayer.AcpListField TrkEmerProfGeneralVoiceSignalType_A7500
		{
			get
			{
				short num = (short)1043333120;
				short num2 = num;
				num = (short)2139066624;
				short num3 = num;
				num = (short)1426559232;
				switch (num3 == num)
				{
				}
				num = (short)1877606401;
				if (num != 0)
				{
				}
				num = (short)29294592;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x001A3680 File Offset: 0x001A1880
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x001A3738 File Offset: 0x001A1938
		public bool TrkEmerProfGeneralVoiceSignalType_A7500_Applicable
		{
			get
			{
				short num = (short)1480851456;
				short num2 = num;
				num = (short)726224796;
				short num3 = num;
				num = (short)982142876;
				switch (num3 == num)
				{
				}
				num = (short)222625793;
				if (num != 0)
				{
				}
				num = (short)313327616;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.Applicable;
			}
			set
			{
				short num = (short)2126970880;
				short num2 = num;
				num = (short)1086779190;
				short num3 = num;
				num = (short)448786230;
				switch (num3 == num)
				{
				}
				num = (short)654770177;
				if (num != 0)
				{
				}
				num = (short)1819869184;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.Applicable = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x001A37EC File Offset: 0x001A19EC
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x001A38A0 File Offset: 0x001A1AA0
		public bool TrkEmerProfGeneralVoiceSignalType_A7500_Valid
		{
			get
			{
				short num = (short)871301120;
				short num2 = num;
				num = (short)1533861971;
				short num3 = num;
				num = (short)1039130707;
				switch (num3 == num)
				{
				}
				num = (short)1288241153;
				if (num != 0)
				{
				}
				num = (short)531234816;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.Valid;
			}
			set
			{
				short num = (short)627507200;
				short num2 = num;
				num = (short)34532372;
				short num3 = num;
				num = (short)2069687316;
				switch (num3 == num)
				{
				}
				num = (short)739115009;
				if (num != 0)
				{
				}
				num = (short)1032650752;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.Valid = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x001A3954 File Offset: 0x001A1B54
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x001A3A0C File Offset: 0x001A1C0C
		public bool TrkEmerProfGeneralVoiceSignalType_A7500_Visible
		{
			get
			{
				short num = (short)53149696;
				short num2 = num;
				num = (short)858159017;
				short num3 = num;
				num = (short)930183081;
				switch (num3 == num)
				{
				}
				num = (short)921567233;
				if (num != 0)
				{
				}
				num = (short)132317184;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.Visible;
			}
			set
			{
				short num = (short)1894907904;
				short num2 = num;
				num = (short)1219612411;
				short num3 = num;
				num = (short)1481690875;
				switch (num3 == num)
				{
				}
				num = (short)1596260352;
				if (num != 0)
				{
				}
				num = (short)745144321;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.Visible = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x001A3AC0 File Offset: 0x001A1CC0
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x001A3B70 File Offset: 0x001A1D70
		public bool TrkEmerProfGeneralVoiceSignalType_A7500_Editable
		{
			get
			{
				short num = (short)968032256;
				short num2 = num;
				num = (short)2036649166;
				short num3 = num;
				num = (short)2070334670;
				switch (num3 == num)
				{
				}
				num = (short)577896449;
				if (num != 0)
				{
				}
				num = (short)53411840;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.Editable;
			}
			set
			{
				short num = (short)1127284736;
				short num2 = num;
				num = (short)1925252711;
				short num3 = num;
				num = (short)651626087;
				switch (num3 == num)
				{
				}
				num = (short)833814528;
				if (num != 0)
				{
				}
				num = (short)199360513;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.Editable = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x001A3C28 File Offset: 0x001A1E28
		internal string TrkEmerProfGeneralVoiceSignalType_A7500_UILabel
		{
			get
			{
				short num = (short)956563456;
				short num2 = num;
				num = (short)124324088;
				short num3 = num;
				num = (short)1132923128;
				switch (num3 == num)
				{
				}
				num = (short)631308289;
				if (num != 0)
				{
				}
				num = (short)1436745728;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.UIName;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x001A3CDC File Offset: 0x001A1EDC
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x001A3D94 File Offset: 0x001A1F94
		internal bool TrkEmerProfGeneralVoiceSignalType_A7500_HiddenStatic
		{
			get
			{
				short num = (short)1166409728;
				short num2 = num;
				num = (short)1515122449;
				short num3 = num;
				num = (short)1841164049;
				switch (num3 == num)
				{
				}
				num = (short)336592897;
				if (num != 0)
				{
				}
				num = (short)96075776;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.HiddenStatic;
			}
			set
			{
				short num = (short)1721434112;
				short num2 = num;
				num = (short)929204145;
				short num3 = num;
				num = (short)677611441;
				switch (num3 == num)
				{
				}
				num = (short)1165557760;
				if (num != 0)
				{
				}
				num = (short)1460142081;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.HiddenStatic = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x001A3E48 File Offset: 0x001A2048
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x001A3EFC File Offset: 0x001A20FC
		internal bool TrkEmerProfGeneralVoiceSignalType_A7500_HiddenDynamic
		{
			get
			{
				short num = (short)1022951424;
				short num2 = num;
				num = (short)1493762049;
				if (num != 0)
				{
				}
				num = (short)1930313630;
				short num3 = num;
				num = (short)192102302;
				switch (num3 == num)
				{
				}
				num = (short)235208704;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500.HiddenDynamic;
			}
			set
			{
				short num = (short)1510211584;
				short num2 = num;
				num = (short)1196330807;
				short num3 = num;
				num = (short)1844940599;
				switch (num3 == num)
				{
				}
				num = (short)448593920;
				if (num != 0)
				{
				}
				num = (short)606404609;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralVoiceSignalType_A7500.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x001A3FB0 File Offset: 0x001A21B0
		public bool TrkEmerProfGeneralVoiceSignalType_A7500_HasDiffs
		{
			get
			{
				short num = (short)1674051584;
				short num2 = num;
				num = (short)462543832;
				short num3 = num;
				num = (short)1752685528;
				switch (num3 == num)
				{
				}
				num = (short)1172242432;
				if (num != 0)
				{
				}
				num = (short)1572865;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralVoiceSignalType_A7500._HasDiffs;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x001A4064 File Offset: 0x001A2264
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x001A4118 File Offset: 0x001A2318
		public int TrkPerGeneralConversationType_A7781Value
		{
			get
			{
				short num = (short)1040318464;
				short num2 = num;
				num = (short)66381978;
				short num3 = num;
				num = (short)1342367898;
				switch (num3 == num)
				{
				}
				num = (short)792920065;
				if (num != 0)
				{
				}
				num = (short)1364590592;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.Value;
			}
			set
			{
				short num = (short)458555392;
				short num2 = num;
				num = (short)1386689474;
				short num3 = num;
				num = (short)716125122;
				switch (num3 == num)
				{
				}
				num = (short)1185677313;
				if (num != 0)
				{
				}
				num = (short)1196228608;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.Value = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x001A41D0 File Offset: 0x001A23D0
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x001A4284 File Offset: 0x001A2484
		public string TrkPerGeneralConversationType_A7781_UIValue
		{
			get
			{
				short num = (short)2045181952;
				short num2 = num;
				num = (short)1583290672;
				short num3 = num;
				num = (short)1203640624;
				switch (num3 == num)
				{
				}
				num = (short)1717174272;
				if (num != 0)
				{
				}
				num = (short)2115239937;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.UIValue;
			}
			set
			{
				short num = (short)1897529344;
				short num2 = num;
				num = (short)372024115;
				short num3 = num;
				num = (short)720937779;
				switch (num3 == num)
				{
				}
				num = (short)873201664;
				if (num != 0)
				{
				}
				num = (short)334561281;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.UIValue = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x001A4338 File Offset: 0x001A2538
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralConversationType_A7781
		{
			get
			{
				short num = (short)1384841216;
				short num2 = num;
				num = (short)1333841024;
				short num3 = num;
				num = (short)330812544;
				switch (num3 == num)
				{
				}
				num = (short)1807024128;
				if (num != 0)
				{
				}
				num = (short)1319829505;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x001A43E4 File Offset: 0x001A25E4
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x001A4498 File Offset: 0x001A2698
		public bool TrkPerGeneralConversationType_A7781_Applicable
		{
			get
			{
				short num = (short)1645215744;
				short num2 = num;
				num = (short)518843865;
				short num3 = num;
				num = (short)12905945;
				switch (num3 == num)
				{
				}
				num = (short)1568997376;
				if (num != 0)
				{
				}
				num = (short)252051457;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.Applicable;
			}
			set
			{
				short num = (short)1438253056;
				short num2 = num;
				num = (short)463046258;
				short num3 = num;
				num = (short)1404864114;
				switch (num3 == num)
				{
				}
				num = (short)991887361;
				if (num != 0)
				{
				}
				num = (short)351141888;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.Applicable = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x001A4550 File Offset: 0x001A2750
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x001A4604 File Offset: 0x001A2804
		public bool TrkPerGeneralConversationType_A7781_Valid
		{
			get
			{
				short num = (short)1677524992;
				short num2 = num;
				num = (short)30880413;
				short num3 = num;
				num = (short)36123293;
				switch (num3 == num)
				{
				}
				num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)136314880;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.Valid;
			}
			set
			{
				short num = (short)1669791744;
				short num2 = num;
				num = (short)1304807275;
				short num3 = num;
				num = (short)1769391979;
				switch (num3 == num)
				{
				}
				num = (short)1140457473;
				if (num != 0)
				{
				}
				num = (short)864747520;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.Valid = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x001A46BC File Offset: 0x001A28BC
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x001A476C File Offset: 0x001A296C
		public bool TrkPerGeneralConversationType_A7781_Visible
		{
			get
			{
				short num = (short)505348096;
				short num2 = num;
				num = (short)94628084;
				short num3 = num;
				num = (short)1797253364;
				switch (num3 == num)
				{
				}
				num = (short)695140353;
				if (num != 0)
				{
				}
				num = (short)1418854400;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.Visible;
			}
			set
			{
				short num = (short)952238080;
				short num2 = num;
				num = (short)127854209;
				short num3 = num;
				num = (short)208070273;
				switch (num3 == num)
				{
				}
				num = (short)1452736513;
				if (num != 0)
				{
				}
				num = (short)871759872;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.Visible = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x001A4824 File Offset: 0x001A2A24
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x001A48DC File Offset: 0x001A2ADC
		public bool TrkPerGeneralConversationType_A7781_Editable
		{
			get
			{
				short num = (short)90636288;
				short num2 = num;
				num = (short)280034828;
				short num3 = num;
				num = (short)1556545036;
				switch (num3 == num)
				{
				}
				num = (short)1357316096;
				if (num != 0)
				{
				}
				num = (short)1177681921;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.Editable;
			}
			set
			{
				short num = (short)2143420416;
				short num2 = num;
				num = (short)874865953;
				short num3 = num;
				num = (short)1417569569;
				switch (num3 == num)
				{
				}
				num = (short)1351286785;
				if (num != 0)
				{
				}
				num = (short)1993539584;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.Editable = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x001A4990 File Offset: 0x001A2B90
		internal string TrkPerGeneralConversationType_A7781_UILabel
		{
			get
			{
				short num = (short)1244921856;
				short num2 = num;
				num = (short)1677941959;
				short num3 = num;
				num = (short)792747207;
				switch (num3 == num)
				{
				}
				num = (short)981925889;
				if (num != 0)
				{
				}
				num = (short)380698624;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.UIName;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x001A4A40 File Offset: 0x001A2C40
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x001A4AF4 File Offset: 0x001A2CF4
		internal bool TrkPerGeneralConversationType_A7781_HiddenStatic
		{
			get
			{
				short num = (short)717291520;
				short num2 = num;
				num = (short)727614275;
				short num3 = num;
				num = (short)1718125379;
				switch (num3 == num)
				{
				}
				num = (short)852295681;
				if (num != 0)
				{
				}
				num = (short)1878392832;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.HiddenStatic;
			}
			set
			{
				short num = (short)962527232;
				short num2 = num;
				num = (short)1877324034;
				short num3 = num;
				num = (short)927117570;
				switch (num3 == num)
				{
				}
				num = (short)1329397761;
				if (num != 0)
				{
				}
				num = (short)46792704;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.HiddenStatic = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x001A4BAC File Offset: 0x001A2DAC
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x001A4C60 File Offset: 0x001A2E60
		internal bool TrkPerGeneralConversationType_A7781_HiddenDynamic
		{
			get
			{
				short num = (short)1037303808;
				short num2 = num;
				num = (short)1975096677;
				short num3 = num;
				num = (short)1503892837;
				switch (num3 == num)
				{
				}
				num = (short)1267204097;
				if (num != 0)
				{
				}
				num = (short)521207808;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781.HiddenDynamic;
			}
			set
			{
				short num = (short)1055064064;
				short num2 = num;
				num = (short)1556648618;
				short num3 = num;
				num = (short)1907266218;
				switch (num3 == num)
				{
				}
				num = (short)1550516224;
				if (num != 0)
				{
				}
				num = (short)1206517761;
				if (num != 0)
				{
				}
				this.trkPerGeneralConversationType_A7781.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x001A4D18 File Offset: 0x001A2F18
		public bool TrkPerGeneralConversationType_A7781_HasDiffs
		{
			get
			{
				short num = (short)147783680;
				short num2 = num;
				num = (short)692154083;
				short num3 = num;
				num = (short)1269657315;
				switch (num3 == num)
				{
				}
				num = (short)419102721;
				if (num != 0)
				{
				}
				num = (short)1372323840;
				if (num != 0)
				{
				}
				return this.trkPerGeneralConversationType_A7781._HasDiffs;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x001A4DCC File Offset: 0x001A2FCC
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x001A4E84 File Offset: 0x001A3084
		public int TrkPerGeneralFailsoftType_A8599Value
		{
			get
			{
				short num = (short)184549376;
				short num2 = num;
				num = (short)621623779;
				short num3 = num;
				num = (short)1811954147;
				switch (num3 == num)
				{
				}
				num = (short)1950810113;
				if (num != 0)
				{
				}
				num = (short)1969618944;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.Value;
			}
			set
			{
				short num = (short)592183296;
				short num2 = num;
				num = (short)1099744372;
				short num3 = num;
				num = (short)833733748;
				switch (num3 == num)
				{
				}
				num = (short)570884096;
				if (num != 0)
				{
				}
				num = (short)1528233985;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.Value = value;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x001A4F38 File Offset: 0x001A3138
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x001A4FEC File Offset: 0x001A31EC
		public string TrkPerGeneralFailsoftType_A8599_UIValue
		{
			get
			{
				short num = (short)1174798336;
				short num2 = num;
				num = (short)84523305;
				short num3 = num;
				num = (short)1236580649;
				switch (num3 == num)
				{
				}
				num = (short)1209925633;
				if (num != 0)
				{
				}
				num = (short)436666368;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.UIValue;
			}
			set
			{
				short num = (short)38273024;
				short num2 = num;
				num = (short)1470169089;
				if (num != 0)
				{
				}
				num = (short)97295590;
				short num3 = num;
				num = (short)1481088230;
				switch (num3 == num)
				{
				}
				num = (short)975306752;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.UIValue = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x001A50A0 File Offset: 0x001A32A0
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralFailsoftType_A8599
		{
			get
			{
				short num = (short)249823232;
				short num2 = num;
				num = (short)1743380622;
				short num3 = num;
				num = (short)860217486;
				switch (num3 == num)
				{
				}
				num = (short)503119873;
				if (num != 0)
				{
				}
				num = (short)1310785536;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x001A5154 File Offset: 0x001A3354
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x001A5208 File Offset: 0x001A3408
		public bool TrkPerGeneralFailsoftType_A8599_Applicable
		{
			get
			{
				short num = (short)1521483776;
				short num2 = num;
				num = (short)526476113;
				short num3 = num;
				num = (short)633168721;
				switch (num3 == num)
				{
				}
				num = (short)860422144;
				if (num != 0)
				{
				}
				num = (short)495648769;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.Applicable;
			}
			set
			{
				short num = (short)294518784;
				short num2 = num;
				num = (short)45405095;
				short num3 = num;
				num = (short)1453052839;
				switch (num3 == num)
				{
				}
				num = (short)1936719873;
				if (num != 0)
				{
				}
				num = (short)714539008;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.Applicable = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x001A52BC File Offset: 0x001A34BC
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x001A5374 File Offset: 0x001A3574
		public bool TrkPerGeneralFailsoftType_A8599_Valid
		{
			get
			{
				short num = (short)968753152;
				short num2 = num;
				num = (short)1765303888;
				short num3 = num;
				num = (short)421094992;
				switch (num3 == num)
				{
				}
				num = (short)916389889;
				if (num != 0)
				{
				}
				num = (short)1204682752;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.Valid;
			}
			set
			{
				short num = (short)2074279936;
				short num2 = num;
				num = (short)992340049;
				short num3 = num;
				num = (short)1352198225;
				switch (num3 == num)
				{
				}
				num = (short)699793409;
				if (num != 0)
				{
				}
				num = (short)1893990400;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.Valid = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x001A542C File Offset: 0x001A362C
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x001A54E0 File Offset: 0x001A36E0
		public bool TrkPerGeneralFailsoftType_A8599_Visible
		{
			get
			{
				short num = (short)1743323136;
				short num2 = num;
				num = (short)1066647283;
				short num3 = num;
				num = (short)1146339059;
				switch (num3 == num)
				{
				}
				num = (short)1537409025;
				if (num != 0)
				{
				}
				num = (short)320667648;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.Visible;
			}
			set
			{
				short num = (short)2103967744;
				short num2 = num;
				num = (short)1461293961;
				short num3 = num;
				num = (short)1745195913;
				switch (num3 == num)
				{
				}
				num = (short)870187009;
				if (num != 0)
				{
				}
				num = (short)118947840;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.Visible = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x001A5598 File Offset: 0x001A3798
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x001A564C File Offset: 0x001A384C
		public bool TrkPerGeneralFailsoftType_A8599_Editable
		{
			get
			{
				short num = (short)365035520;
				short num2 = num;
				num = (short)1237416297;
				short num3 = num;
				num = (short)94271849;
				switch (num3 == num)
				{
				}
				num = (short)654376961;
				if (num != 0)
				{
				}
				num = (short)17039360;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.Editable;
			}
			set
			{
				short num = (short)1314390016;
				short num2 = num;
				num = (short)2050706741;
				short num3 = num;
				num = (short)1471302965;
				switch (num3 == num)
				{
				}
				num = (short)1373044737;
				if (num != 0)
				{
				}
				num = (short)1389101056;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.Editable = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x001A5704 File Offset: 0x001A3904
		internal string TrkPerGeneralFailsoftType_A8599_UILabel
		{
			get
			{
				short num = (short)257032192;
				short num2 = num;
				num = (short)670059323;
				short num3 = num;
				num = (short)1910393659;
				switch (num3 == num)
				{
				}
				num = (short)742195200;
				if (num != 0)
				{
				}
				num = (short)1447362561;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.UIName;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x001A57B4 File Offset: 0x001A39B4
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x001A5868 File Offset: 0x001A3A68
		internal bool TrkPerGeneralFailsoftType_A8599_HiddenStatic
		{
			get
			{
				short num = (short)1229324288;
				short num2 = num;
				num = (short)734981115;
				short num3 = num;
				num = (short)501476347;
				switch (num3 == num)
				{
				}
				num = (short)973144065;
				if (num != 0)
				{
				}
				num = (short)838860800;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.HiddenStatic;
			}
			set
			{
				short num = (short)1707016192;
				short num2 = num;
				num = (short)1932614633;
				short num3 = num;
				num = (short)1880447977;
				switch (num3 == num)
				{
				}
				num = (short)1308164097;
				if (num != 0)
				{
				}
				num = (short)2136211456;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.HiddenStatic = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x001A591C File Offset: 0x001A3B1C
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x001A59D0 File Offset: 0x001A3BD0
		internal bool TrkPerGeneralFailsoftType_A8599_HiddenDynamic
		{
			get
			{
				short num = (short)803012608;
				short num2 = num;
				num = (short)1237409022;
				short num3 = num;
				num = (short)1066687742;
				switch (num3 == num)
				{
				}
				num = (short)1760296961;
				if (num != 0)
				{
				}
				num = (short)182452224;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599.HiddenDynamic;
			}
			set
			{
				short num = (short)864157696;
				short num2 = num;
				num = (short)823681631;
				short num3 = num;
				num = (short)1554866783;
				switch (num3 == num)
				{
				}
				num = (short)1030750209;
				if (num != 0)
				{
				}
				num = (short)1032650752;
				if (num != 0)
				{
				}
				this.trkPerGeneralFailsoftType_A8599.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x001A5A84 File Offset: 0x001A3C84
		public bool TrkPerGeneralFailsoftType_A8599_HasDiffs
		{
			get
			{
				short num = (short)39124992;
				short num2 = num;
				num = (short)1161494529;
				if (num != 0)
				{
				}
				num = (short)1207887025;
				short num3 = num;
				num = (short)2107172017;
				switch (num3 == num)
				{
				}
				num = (short)1637482496;
				if (num != 0)
				{
				}
				return this.trkPerGeneralFailsoftType_A8599._HasDiffs;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x001A5B38 File Offset: 0x001A3D38
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x001A5BEC File Offset: 0x001A3DEC
		public int TrkPerGeneralSecondaryRxFrequencyMHz_A8904Value
		{
			get
			{
				short num = (short)2001403904;
				short num2 = num;
				num = (short)1713207573;
				short num3 = num;
				num = (short)321091861;
				switch (num3 == num)
				{
				}
				num = (short)1350172673;
				if (num != 0)
				{
				}
				num = (short)1428750336;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Value;
			}
			set
			{
				short num = (short)1586114075;
				short num2 = num;
				num = (short)804990491;
				switch (num2 == num)
				{
				}
				num = (short)2112749569;
				if (num != 0)
				{
				}
				num = (short)713555968;
				if (num != 0)
				{
				}
				num = (short)1671364608;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Value = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x001A5CA0 File Offset: 0x001A3EA0
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x001A5D54 File Offset: 0x001A3F54
		public string TrkPerGeneralSecondaryRxFrequencyMHz_A8904_UIValue
		{
			get
			{
				short num = (short)214633102;
				short num2 = num;
				num = (short)811469454;
				switch (num2 == num)
				{
				}
				num = (short)2098593793;
				if (num != 0)
				{
				}
				num = (short)1940652032;
				if (num != 0)
				{
				}
				num = (short)888209408;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.UIValue;
			}
			set
			{
				short num = (short)600972543;
				short num2 = num;
				num = (short)1362107647;
				switch (num2 == num)
				{
				}
				num = (short)2020605952;
				if (num != 0)
				{
				}
				num = (short)1184563201;
				if (num != 0)
				{
				}
				num = (short)1416822784;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.UIValue = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x001A5E0C File Offset: 0x001A400C
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerGeneralSecondaryRxFrequencyMHz_A8904
		{
			get
			{
				short num = (short)1611005953;
				if (num != 0)
				{
				}
				num = (short)1951934411;
				short num2 = num;
				num = (short)677717963;
				switch (num2 == num)
				{
				}
				num = (short)1502871552;
				if (num != 0)
				{
				}
				num = (short)1908342784;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x001A5EBC File Offset: 0x001A40BC
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x001A5F74 File Offset: 0x001A4174
		internal int TrkPerGeneralSecondaryRxFrequencyMHz_A8904Min
		{
			get
			{
				short num = (short)731641694;
				short num2 = num;
				num = (short)1108604766;
				switch (num2 == num)
				{
				}
				num = (short)902365184;
				if (num != 0)
				{
				}
				num = (short)1070137345;
				if (num != 0)
				{
				}
				num = (short)495124480;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Min;
			}
			set
			{
				short num = (short)2145781139;
				short num2 = num;
				num = (short)2119370131;
				switch (num2 == num)
				{
				}
				num = (short)1688207361;
				if (num != 0)
				{
				}
				num = (short)679215104;
				if (num != 0)
				{
				}
				num = (short)636354560;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Min = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x001A6028 File Offset: 0x001A4228
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x001A60DC File Offset: 0x001A42DC
		internal int TrkPerGeneralSecondaryRxFrequencyMHz_A8904Max
		{
			get
			{
				short num = (short)1657829788;
				short num2 = num;
				num = (short)172128668;
				switch (num2 == num)
				{
				}
				num = (short)1023737857;
				if (num != 0)
				{
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				num = (short)2016411648;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Max;
			}
			set
			{
				short num = (short)22440409;
				short num2 = num;
				num = (short)403073497;
				switch (num2 == num)
				{
				}
				num = (short)1457389569;
				if (num != 0)
				{
				}
				num = (short)2097152;
				if (num != 0)
				{
				}
				num = (short)1752891392;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Max = value;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x001A6190 File Offset: 0x001A4390
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x001A6244 File Offset: 0x001A4444
		internal int TrkPerGeneralSecondaryRxFrequencyMHz_A8904Step
		{
			get
			{
				short num = (short)1720086534;
				short num2 = num;
				num = (short)1174761478;
				switch (num2 == num)
				{
				}
				num = (short)892796929;
				if (num != 0)
				{
				}
				num = (short)1210908672;
				if (num != 0)
				{
				}
				num = (short)1010237440;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.StepSize;
			}
			set
			{
				short num = (short)1477542691;
				short num2 = num;
				num = (short)1600226083;
				switch (num2 == num)
				{
				}
				num = (short)1714421761;
				if (num != 0)
				{
				}
				num = (short)626720768;
				if (num != 0)
				{
				}
				num = (short)1014366208;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.StepSize = value;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x001A62FC File Offset: 0x001A44FC
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x001A63B4 File Offset: 0x001A45B4
		public bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_Applicable
		{
			get
			{
				short num = (short)1558599670;
				short num2 = num;
				num = (short)1986222070;
				switch (num2 == num)
				{
				}
				num = (short)720175105;
				if (num != 0)
				{
				}
				num = (short)966852608;
				if (num != 0)
				{
				}
				num = (short)1862729728;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Applicable;
			}
			set
			{
				short num = (short)173824428;
				short num2 = num;
				num = (short)1613322668;
				switch (num2 == num)
				{
				}
				num = (short)1093337089;
				if (num != 0)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				num = (short)1455685632;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Applicable = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x001A646C File Offset: 0x001A466C
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x001A6524 File Offset: 0x001A4724
		public bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_Valid
		{
			get
			{
				short num = (short)89257223;
				short num2 = num;
				num = (short)318567687;
				switch (num2 == num)
				{
				}
				num = (short)29294592;
				if (num != 0)
				{
				}
				num = (short)47513601;
				if (num != 0)
				{
				}
				num = (short)589365248;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Valid;
			}
			set
			{
				short num = (short)678088890;
				short num2 = num;
				num = (short)15257786;
				switch (num2 == num)
				{
				}
				num = (short)1248133121;
				if (num != 0)
				{
				}
				num = (short)1969356800;
				if (num != 0)
				{
				}
				num = (short)353239040;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Valid = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x001A65DC File Offset: 0x001A47DC
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x001A6694 File Offset: 0x001A4894
		public bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_Visible
		{
			get
			{
				short num = (short)1323783508;
				short num2 = num;
				num = (short)702895444;
				switch (num2 == num)
				{
				}
				num = (short)798162945;
				if (num != 0)
				{
				}
				num = (short)114491392;
				if (num != 0)
				{
				}
				num = (short)1689845760;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Visible;
			}
			set
			{
				short num = (short)1632763905;
				if (num != 0)
				{
				}
				num = (short)1995052899;
				short num2 = num;
				num = (short)588715875;
				switch (num2 == num)
				{
				}
				num = (short)413335552;
				if (num != 0)
				{
				}
				num = (short)2072379392;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Visible = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x001A6748 File Offset: 0x001A4948
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x001A67FC File Offset: 0x001A49FC
		public bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_Editable
		{
			get
			{
				short num = (short)196542465;
				if (num != 0)
				{
				}
				num = (short)1259679600;
				short num2 = num;
				num = (short)965422960;
				switch (num2 == num)
				{
				}
				num = (short)494796800;
				if (num != 0)
				{
				}
				num = (short)655949824;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Editable;
			}
			set
			{
				short num = (short)2029754075;
				short num2 = num;
				num = (short)480220891;
				switch (num2 == num)
				{
				}
				num = (short)1632239617;
				if (num != 0)
				{
				}
				num = (short)1624768512;
				if (num != 0)
				{
				}
				num = (short)1454571520;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.Editable = value;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x001A68B4 File Offset: 0x001A4AB4
		internal string TrkPerGeneralSecondaryRxFrequencyMHz_A8904_UILabel
		{
			get
			{
				short num = (short)8468641;
				short num2 = num;
				num = (short)583481505;
				switch (num2 == num)
				{
				}
				num = (short)955580417;
				if (num != 0)
				{
				}
				num = (short)1408237568;
				if (num != 0)
				{
				}
				num = (short)947191808;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.UIName;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x001A6968 File Offset: 0x001A4B68
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x001A6A20 File Offset: 0x001A4C20
		internal bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_HiddenStatic
		{
			get
			{
				short num = (short)491454465;
				if (num != 0)
				{
				}
				num = (short)920272866;
				short num2 = num;
				num = (short)1115570146;
				switch (num2 == num)
				{
				}
				num = (short)942997504;
				if (num != 0)
				{
				}
				num = (short)878772224;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.HiddenStatic;
			}
			set
			{
				short num = (short)1696921817;
				short num2 = num;
				num = (short)101382361;
				switch (num2 == num)
				{
				}
				num = (short)1983774721;
				if (num != 0)
				{
				}
				num = (short)1116405760;
				if (num != 0)
				{
				}
				num = (short)1322188800;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.HiddenStatic = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x001A6AD4 File Offset: 0x001A4CD4
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x001A6B88 File Offset: 0x001A4D88
		internal bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_HiddenDynamic
		{
			get
			{
				short num = (short)431851401;
				short num2 = num;
				num = (short)1342605193;
				switch (num2 == num)
				{
				}
				num = (short)1577058305;
				if (num != 0)
				{
				}
				num = (short)1231618048;
				if (num != 0)
				{
				}
				num = (short)1801846784;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.HiddenDynamic;
			}
			set
			{
				short num = (short)500669984;
				short num2 = num;
				num = (short)180788768;
				switch (num2 == num)
				{
				}
				num = (short)111935489;
				if (num != 0)
				{
				}
				num = (short)1149829120;
				if (num != 0)
				{
				}
				num = (short)1906900992;
				short num3 = num;
				this.trkPerGeneralSecondaryRxFrequencyMHz_A8904.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x001A6C3C File Offset: 0x001A4E3C
		public bool TrkPerGeneralSecondaryRxFrequencyMHz_A8904_HasDiffs
		{
			get
			{
				short num = (short)1979806633;
				short num2 = num;
				num = (short)57701289;
				switch (num2 == num)
				{
				}
				num = (short)987496448;
				if (num != 0)
				{
				}
				num = (short)255918081;
				if (num != 0)
				{
				}
				num = (short)122159104;
				short num3 = num;
				return this.trkPerGeneralSecondaryRxFrequencyMHz_A8904._HasDiffs;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x001A6CF0 File Offset: 0x001A4EF0
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x001A6DA4 File Offset: 0x001A4FA4
		public int TrkPerGeneralRxFrequencyMHz_A8910Value
		{
			get
			{
				short num = (short)784531457;
				if (num != 0)
				{
				}
				num = (short)1008677857;
				short num2 = num;
				num = (short)1935422433;
				switch (num2 == num)
				{
				}
				num = (short)993918976;
				if (num != 0)
				{
				}
				num = (short)262602752;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Value;
			}
			set
			{
				short num = (short)1034289153;
				if (num != 0)
				{
				}
				num = (short)1754230667;
				short num2 = num;
				num = (short)256995211;
				switch (num2 == num)
				{
				}
				num = (short)909180928;
				if (num != 0)
				{
				}
				num = (short)63111168;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Value = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x001A6E5C File Offset: 0x001A505C
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x001A6F14 File Offset: 0x001A5114
		public string TrkPerGeneralRxFrequencyMHz_A8910_UIValue
		{
			get
			{
				short num = (short)1806408011;
				short num2 = num;
				num = (short)1297783115;
				switch (num2 == num)
				{
				}
				num = (short)694353920;
				if (num != 0)
				{
				}
				num = (short)1600192513;
				if (num != 0)
				{
				}
				num = (short)596115456;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.UIValue;
			}
			set
			{
				short num = (short)346141393;
				short num2 = num;
				num = (short)1072280273;
				switch (num2 == num)
				{
				}
				num = (short)181338112;
				if (num != 0)
				{
				}
				num = (short)1135935489;
				if (num != 0)
				{
				}
				num = (short)1597243392;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.UIValue = value;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x001A6FC8 File Offset: 0x001A51C8
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerGeneralRxFrequencyMHz_A8910
		{
			get
			{
				short num = (short)1335458085;
				short num2 = num;
				num = (short)1758624037;
				switch (num2 == num)
				{
				}
				num = (short)1623261184;
				if (num != 0)
				{
				}
				num = (short)1779367937;
				if (num != 0)
				{
				}
				num = (short)1220608000;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x001A7074 File Offset: 0x001A5274
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x001A7128 File Offset: 0x001A5328
		internal int TrkPerGeneralRxFrequencyMHz_A8910Min
		{
			get
			{
				short num = (short)1475018974;
				short num2 = num;
				num = (short)152568030;
				switch (num2 == num)
				{
				}
				num = (short)685244416;
				if (num != 0)
				{
				}
				num = (short)1249509377;
				if (num != 0)
				{
				}
				num = (short)896466944;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Min;
			}
			set
			{
				short num = (short)132261445;
				short num2 = num;
				num = (short)1010705989;
				switch (num2 == num)
				{
				}
				num = (short)1244266496;
				if (num != 0)
				{
				}
				num = (short)240713729;
				if (num != 0)
				{
				}
				num = (short)1813381120;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Min = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x001A71DC File Offset: 0x001A53DC
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x001A7290 File Offset: 0x001A5490
		internal int TrkPerGeneralRxFrequencyMHz_A8910Max
		{
			get
			{
				short num = (short)674168833;
				if (num != 0)
				{
				}
				num = (short)2035568291;
				short num2 = num;
				num = (short)1185238691;
				switch (num2 == num)
				{
				}
				num = (short)200540160;
				if (num != 0)
				{
				}
				num = (short)1704263680;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Max;
			}
			set
			{
				short num = (short)1421127859;
				short num2 = num;
				num = (short)377139379;
				switch (num2 == num)
				{
				}
				num = (short)71565313;
				if (num != 0)
				{
				}
				num = (short)1447165952;
				if (num != 0)
				{
				}
				num = (short)358088704;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Max = value;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x001A7348 File Offset: 0x001A5548
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x001A73FC File Offset: 0x001A55FC
		internal int TrkPerGeneralRxFrequencyMHz_A8910Step
		{
			get
			{
				short num = (short)740956564;
				short num2 = num;
				num = (short)658381204;
				switch (num2 == num)
				{
				}
				num = (short)273481729;
				if (num != 0)
				{
				}
				num = (short)142082048;
				if (num != 0)
				{
				}
				num = (short)475725824;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.StepSize;
			}
			set
			{
				short num = (short)149635271;
				short num2 = num;
				num = (short)708001991;
				switch (num2 == num)
				{
				}
				num = (short)1001455616;
				if (num != 0)
				{
				}
				num = (short)981794817;
				if (num != 0)
				{
				}
				num = (short)605618176;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.StepSize = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x001A74B4 File Offset: 0x001A56B4
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x001A7568 File Offset: 0x001A5768
		public bool TrkPerGeneralRxFrequencyMHz_A8910_Applicable
		{
			get
			{
				short num = (short)1957506901;
				short num2 = num;
				num = (short)2122329941;
				switch (num2 == num)
				{
				}
				num = (short)1863385088;
				if (num != 0)
				{
				}
				num = (short)1408040961;
				if (num != 0)
				{
				}
				num = (short)1450377216;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Applicable;
			}
			set
			{
				short num = (short)288335733;
				short num2 = num;
				num = (short)1276159861;
				switch (num2 == num)
				{
				}
				num = (short)1610416128;
				if (num != 0)
				{
				}
				num = (short)391249921;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Applicable = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x001A7620 File Offset: 0x001A5820
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x001A76D4 File Offset: 0x001A58D4
		public bool TrkPerGeneralRxFrequencyMHz_A8910_Valid
		{
			get
			{
				short num = (short)355766622;
				short num2 = num;
				num = (short)2002817374;
				switch (num2 == num)
				{
				}
				num = (short)1151598593;
				if (num != 0)
				{
				}
				num = (short)880214016;
				if (num != 0)
				{
				}
				num = (short)1220935680;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Valid;
			}
			set
			{
				short num = (short)700163463;
				short num2 = num;
				num = (short)253142407;
				switch (num2 == num)
				{
				}
				num = (short)839647233;
				if (num != 0)
				{
				}
				num = (short)234356736;
				if (num != 0)
				{
				}
				num = (short)1708982272;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Valid = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x001A7788 File Offset: 0x001A5988
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x001A7840 File Offset: 0x001A5A40
		public bool TrkPerGeneralRxFrequencyMHz_A8910_Visible
		{
			get
			{
				short num = (short)318898177;
				if (num != 0)
				{
				}
				num = (short)1826478843;
				short num2 = num;
				num = (short)1123212027;
				switch (num2 == num)
				{
				}
				num = (short)267845632;
				if (num != 0)
				{
				}
				num = (short)2047279104;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Visible;
			}
			set
			{
				short num = (short)983951796;
				short num2 = num;
				num = (short)1977936308;
				switch (num2 == num)
				{
				}
				num = (short)1165950977;
				if (num != 0)
				{
				}
				num = (short)1205665792;
				if (num != 0)
				{
				}
				num = (short)49348608;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Visible = value;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x001A78F8 File Offset: 0x001A5AF8
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x001A79AC File Offset: 0x001A5BAC
		public bool TrkPerGeneralRxFrequencyMHz_A8910_Editable
		{
			get
			{
				short num = (short)143196161;
				if (num != 0)
				{
				}
				num = (short)1657760205;
				short num2 = num;
				num = (short)94398925;
				switch (num2 == num)
				{
				}
				num = (short)342818816;
				if (num != 0)
				{
				}
				num = (short)1828519936;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.Editable;
			}
			set
			{
				short num = (short)933688905;
				short num2 = num;
				num = (short)594867785;
				switch (num2 == num)
				{
				}
				num = (short)643563521;
				if (num != 0)
				{
				}
				num = (short)208011264;
				if (num != 0)
				{
				}
				num = (short)319750144;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.Editable = value;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x001A7A64 File Offset: 0x001A5C64
		internal string TrkPerGeneralRxFrequencyMHz_A8910_UILabel
		{
			get
			{
				short num = (short)1216963886;
				short num2 = num;
				num = (short)1196582190;
				switch (num2 == num)
				{
				}
				num = (short)1376845825;
				if (num != 0)
				{
				}
				num = (short)1801715712;
				if (num != 0)
				{
				}
				num = (short)1905524736;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.UIName;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x001A7B18 File Offset: 0x001A5D18
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x001A7BCC File Offset: 0x001A5DCC
		internal bool TrkPerGeneralRxFrequencyMHz_A8910_HiddenStatic
		{
			get
			{
				short num = (short)47644673;
				if (num != 0)
				{
				}
				num = (short)152659709;
				short num2 = num;
				num = (short)1116497661;
				switch (num2 == num)
				{
				}
				num = (short)1383858176;
				if (num != 0)
				{
				}
				num = (short)1159790592;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.HiddenStatic;
			}
			set
			{
				short num = (short)1644247516;
				short num2 = num;
				num = (short)198523356;
				switch (num2 == num)
				{
				}
				num = (short)218431489;
				if (num != 0)
				{
				}
				num = (short)1302986752;
				if (num != 0)
				{
				}
				num = (short)1353973760;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.HiddenStatic = value;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x001A7C84 File Offset: 0x001A5E84
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x001A7D3C File Offset: 0x001A5F3C
		internal bool TrkPerGeneralRxFrequencyMHz_A8910_HiddenDynamic
		{
			get
			{
				short num = (short)1609925729;
				short num2 = num;
				num = (short)459441249;
				switch (num2 == num)
				{
				}
				num = (short)628359169;
				if (num != 0)
				{
				}
				num = (short)1982398464;
				if (num != 0)
				{
				}
				num = (short)1859977216;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910.HiddenDynamic;
			}
			set
			{
				short num = (short)110001274;
				short num2 = num;
				num = (short)1095859322;
				switch (num2 == num)
				{
				}
				num = (short)1762852864;
				if (num != 0)
				{
				}
				num = (short)1000210433;
				if (num != 0)
				{
				}
				num = (short)2021261312;
				short num3 = num;
				this.trkPerGeneralRxFrequencyMHz_A8910.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x001A7DF0 File Offset: 0x001A5FF0
		public bool TrkPerGeneralRxFrequencyMHz_A8910_HasDiffs
		{
			get
			{
				short num = (short)669119974;
				short num2 = num;
				num = (short)43644390;
				switch (num2 == num)
				{
				}
				num = (short)525467649;
				if (num != 0)
				{
				}
				num = (short)2005467136;
				if (num != 0)
				{
				}
				num = (short)1248329728;
				short num3 = num;
				return this.trkPerGeneralRxFrequencyMHz_A8910._HasDiffs;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x001A7EA0 File Offset: 0x001A60A0
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x001A7F50 File Offset: 0x001A6150
		public int TrkEmerProfGeneralTalkgroup_A8969Value
		{
			get
			{
				short num = (short)1049220247;
				short num2 = num;
				num = (short)2070992023;
				switch (num2 == num)
				{
				}
				num = (short)1096613889;
				if (num != 0)
				{
				}
				num = (short)1496973312;
				if (num != 0)
				{
				}
				num = (short)337641472;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969.Value;
			}
			set
			{
				short num = (short)1724394616;
				short num2 = num;
				num = (short)414264440;
				switch (num2 == num)
				{
				}
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)1526136832;
				if (num != 0)
				{
				}
				num = (short)379650048;
				short num3 = num;
				this.trkEmerProfGeneralTalkgroup_A8969.Value = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x001A8004 File Offset: 0x001A6204
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerProfGeneralTalkgroup_A8969
		{
			get
			{
				short num = (short)640075298;
				short num2 = num;
				num = (short)1739376162;
				switch (num2 == num)
				{
				}
				num = (short)1407188992;
				if (num != 0)
				{
				}
				num = (short)883556353;
				if (num != 0)
				{
				}
				num = (short)1232797696;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x001A80B4 File Offset: 0x001A62B4
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x001A816C File Offset: 0x001A636C
		public string TrkEmerProfGeneralTalkgroup_A8969_UIValue
		{
			get
			{
				short num = (short)1039083966;
				short num2 = num;
				num = (short)1460873662;
				switch (num2 == num)
				{
				}
				num = (short)1156513793;
				if (num != 0)
				{
				}
				num = (short)1781465088;
				if (num != 0)
				{
				}
				num = (short)728563712;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969.UIValue;
			}
			set
			{
				short num = (short)845611009;
				if (num != 0)
				{
				}
				num = (short)185967823;
				short num2 = num;
				num = (short)53978319;
				switch (num2 == num)
				{
				}
				num = (short)277413888;
				if (num != 0)
				{
				}
				num = (short)640024576;
				short num3 = num;
				this.trkEmerProfGeneralTalkgroup_A8969.UIValue = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x001A8224 File Offset: 0x001A6424
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x001A82DC File Offset: 0x001A64DC
		public string TrkEmerProfGeneralTalkgroup_A8969_HexUIValue
		{
			get
			{
				short num = (short)2076114945;
				if (num != 0)
				{
				}
				num = (short)128286780;
				short num2 = num;
				num = (short)99778620;
				switch (num2 == num)
				{
				}
				num = (short)155516928;
				if (num != 0)
				{
				}
				num = (short)433782784;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969.HexUIValue;
			}
			set
			{
				short num = (short)407807634;
				short num2 = num;
				num = (short)1767876242;
				switch (num2 == num)
				{
				}
				num = (short)708902913;
				if (num != 0)
				{
				}
				num = (short)1426849792;
				if (num != 0)
				{
				}
				num = (short)1296302080;
				short num3 = num;
				this.trkEmerProfGeneralTalkgroup_A8969.HexUIValue = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x001A8390 File Offset: 0x001A6590
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x001A8448 File Offset: 0x001A6648
		internal int TrkEmerProfGeneralTalkgroup_A8969Min
		{
			get
			{
				short num = (short)981888109;
				short num2 = num;
				num = (short)1928490093;
				switch (num2 == num)
				{
				}
				num = (short)406716416;
				if (num != 0)
				{
				}
				num = (short)362872833;
				if (num != 0)
				{
				}
				num = (short)834404352;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969.Min;
			}
			set
			{
				short num = (short)1675362305;
				if (num != 0)
				{
				}
				num = (short)634497365;
				short num2 = num;
				num = (short)1959700821;
				switch (num2 == num)
				{
				}
				num = (short)1406271488;
				if (num != 0)
				{
				}
				num = (short)1130233856;
				short num3 = num;
				this.trkEmerProfGeneralTalkgroup_A8969.Min = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x001A8500 File Offset: 0x001A6700
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x001A85B8 File Offset: 0x001A67B8
		internal int TrkEmerProfGeneralTalkgroup_A8969Max
		{
			get
			{
				short num = (short)666566657;
				if (num != 0)
				{
				}
				num = (short)885781481;
				short num2 = num;
				num = (short)348779497;
				switch (num2 == num)
				{
				}
				num = (short)904200192;
				if (num != 0)
				{
				}
				num = (short)2045640704;
				short num3 = num;
				return this.trkEmerProfGeneralTalkgroup_A8969.Max;
			}
			set
			{
				short num = (short)1253017555;
				short num2 = num;
				num = (short)227379155;
				switch (num2 == num)
				{
				}
				num = (short)76873728;
				if (num != 0)
				{
				}
				num = (short)461897729;
				if (num != 0)
				{
				}
				num = (short)1917911040;
				short num3 = num;
				this.trkEmerProfGeneralTalkgroup_A8969.Max = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x001A8670 File Offset: 0x001A6870
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x001A8724 File Offset: 0x001A6924
		internal int TrkEmerProfGeneralTalkgroup_A8969Step
		{
			get
			{
				short num = (short)365194312;
				short num2 = num;
				num = (short)1488677960;
				switch (num2 == num)
				{
				}
				num = (short)848953344;
				short num3 = num;
				num = (short)1324679169;
				if (num != 0)
				{
				}
				num = (short)2078736384;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.StepSize;
			}
			set
			{
				short num = (short)2020787915;
				short num2 = num;
				num = (short)1738720971;
				switch (num2 == num)
				{
				}
				num = (short)1439105024;
				short num3 = num;
				num = (short)816513025;
				if (num != 0)
				{
				}
				num = (short)1154940928;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.StepSize = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x001A87DC File Offset: 0x001A69DC
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x001A8894 File Offset: 0x001A6A94
		public bool TrkEmerProfGeneralTalkgroup_A8969_Applicable
		{
			get
			{
				short num = (short)622588084;
				short num2 = num;
				num = (short)790556852;
				switch (num2 == num)
				{
				}
				num = (short)935067648;
				short num3 = num;
				num = (short)1747714049;
				if (num != 0)
				{
				}
				num = (short)692387840;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.Applicable;
			}
			set
			{
				short num = (short)1206677288;
				short num2 = num;
				num = (short)733507368;
				switch (num2 == num)
				{
				}
				num = (short)507772928;
				short num3 = num;
				num = (short)1899102209;
				if (num != 0)
				{
				}
				num = (short)344981504;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.Applicable = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x001A894C File Offset: 0x001A6B4C
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x001A8A04 File Offset: 0x001A6C04
		public bool TrkEmerProfGeneralTalkgroup_A8969_Valid
		{
			get
			{
				short num = (short)220945629;
				short num2 = num;
				num = (short)1573018845;
				switch (num2 == num)
				{
				}
				num = (short)1047789568;
				short num3 = num;
				num = (short)1869414400;
				if (num != 0)
				{
				}
				num = (short)188153857;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.Valid;
			}
			set
			{
				short num = (short)1870072146;
				short num2 = num;
				num = (short)1601112402;
				switch (num2 == num)
				{
				}
				num = (short)1597440000;
				short num3 = num;
				num = (short)1737359361;
				if (num != 0)
				{
				}
				num = (short)560791552;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.Valid = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x001A8ABC File Offset: 0x001A6CBC
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x001A8B70 File Offset: 0x001A6D70
		public bool TrkEmerProfGeneralTalkgroup_A8969_Visible
		{
			get
			{
				short num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)1621862649;
				short num2 = num;
				num = (short)1413130489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1380384768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)352911360;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.Visible;
			}
			set
			{
				short num = (short)941480819;
				short num2 = num;
				num = (short)2132073331;
				switch (num2 == num)
				{
				}
				num = (short)1606615040;
				short num3 = num;
				num = (short)1492582401;
				if (num != 0)
				{
				}
				num = (short)1942159360;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.Visible = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x001A8C24 File Offset: 0x001A6E24
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x001A8CD8 File Offset: 0x001A6ED8
		public bool TrkEmerProfGeneralTalkgroup_A8969_Editable
		{
			get
			{
				short num = (short)1247055858;
				short num2 = num;
				num = (short)941199346;
				switch (num2 == num)
				{
				}
				num = (short)2095972352;
				short num3 = num;
				num = (short)814350337;
				if (num != 0)
				{
				}
				num = (short)1833828352;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.Editable;
			}
			set
			{
				short num = (short)1729046015;
				short num2 = num;
				num = (short)1755981311;
				switch (num2 == num)
				{
				}
				num = (short)1998585856;
				short num3 = num;
				num = (short)1642070017;
				if (num != 0)
				{
				}
				num = (short)1391853568;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.Editable = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x001A8D8C File Offset: 0x001A6F8C
		internal string TrkEmerProfGeneralTalkgroup_A8969_UILabel
		{
			get
			{
				short num = (short)1150644205;
				short num2 = num;
				num = (short)1377660909;
				switch (num2 == num)
				{
				}
				num = (short)1734672384;
				short num3 = num;
				num = (short)1596456961;
				if (num != 0)
				{
				}
				num = (short)1113915392;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.UIName;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x001A8E40 File Offset: 0x001A7040
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x001A8EF8 File Offset: 0x001A70F8
		internal bool TrkEmerProfGeneralTalkgroup_A8969_HiddenStatic
		{
			get
			{
				short num = (short)1018469905;
				short num2 = num;
				num = (short)30842385;
				switch (num2 == num)
				{
				}
				num = (short)149815296;
				short num3 = num;
				num = (short)206372864;
				if (num != 0)
				{
				}
				num = (short)231735297;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.HiddenStatic;
			}
			set
			{
				short num = (short)1959719252;
				short num2 = num;
				num = (short)1436676436;
				switch (num2 == num)
				{
				}
				num = (short)1394999296;
				short num3 = num;
				num = (short)455475201;
				if (num != 0)
				{
				}
				num = (short)606535680;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.HiddenStatic = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x001A8FAC File Offset: 0x001A71AC
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x001A9060 File Offset: 0x001A7260
		internal bool TrkEmerProfGeneralTalkgroup_A8969_HiddenDynamic
		{
			get
			{
				short num = (short)978869669;
				short num2 = num;
				num = (short)2146459045;
				switch (num2 == num)
				{
				}
				num = (short)187564032;
				short num3 = num;
				num = (short)1363410945;
				if (num != 0)
				{
				}
				num = (short)627179520;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969.HiddenDynamic;
			}
			set
			{
				short num = (short)687232557;
				short num2 = num;
				num = (short)815289901;
				switch (num2 == num)
				{
				}
				num = (short)887685120;
				short num3 = num;
				num = (short)455147520;
				if (num != 0)
				{
				}
				num = (short)1497628673;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTalkgroup_A8969.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x001A9118 File Offset: 0x001A7318
		public bool TrkEmerProfGeneralTalkgroup_A8969_HasDiffs
		{
			get
			{
				short num = (short)20680459;
				short num2 = num;
				num = (short)723357451;
				switch (num2 == num)
				{
				}
				num = (short)1171390464;
				short num3 = num;
				num = (short)426442753;
				if (num != 0)
				{
				}
				num = (short)1470234624;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTalkgroup_A8969._HasDiffs;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x001A91D0 File Offset: 0x001A73D0
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x001A9288 File Offset: 0x001A7488
		public int TrkEmerProfGeneralKeySelect_A8970Value
		{
			get
			{
				short num = (short)959578113;
				if (num != 0)
				{
				}
				num = (short)119443775;
				short num2 = num;
				num = (short)1535807807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255524864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834207744;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.Value;
			}
			set
			{
				short num = (short)1145846002;
				short num2 = num;
				num = (short)628242674;
				switch (num2 == num)
				{
				}
				num = (short)618921984;
				short num3 = num;
				num = (short)1509818368;
				if (num != 0)
				{
				}
				num = (short)152371201;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.Value = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x001A933C File Offset: 0x001A753C
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x001A93F0 File Offset: 0x001A75F0
		public string TrkEmerProfGeneralKeySelect_A8970_UIValue
		{
			get
			{
				short num = (short)520293548;
				short num2 = num;
				num = (short)1905069228;
				switch (num2 == num)
				{
				}
				num = (short)727842816;
				short num3 = num;
				num = (short)432340992;
				if (num != 0)
				{
				}
				num = (short)176488449;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.UIValue;
			}
			set
			{
				short num = (short)1923283461;
				short num2 = num;
				num = (short)1565063685;
				switch (num2 == num)
				{
				}
				num = (short)1911947264;
				short num3 = num;
				num = (short)170196993;
				if (num != 0)
				{
				}
				num = (short)278659072;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.UIValue = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x001A94A8 File Offset: 0x001A76A8
		public global::AcpBusinessLayer.AcpRecRefField TrkEmerProfGeneralKeySelect_A8970
		{
			get
			{
				short num = (short)1484712746;
				short num2 = num;
				num = (short)719776554;
				switch (num2 == num)
				{
				}
				num = (short)1281687552;
				short num3 = num;
				num = (short)724041729;
				if (num != 0)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x001A9558 File Offset: 0x001A7758
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x001A960C File Offset: 0x001A780C
		public bool TrkEmerProfGeneralKeySelect_A8970_Applicable
		{
			get
			{
				short num = (short)780861441;
				if (num != 0)
				{
				}
				num = (short)2028543184;
				short num2 = num;
				num = (short)481303760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1493368832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)10944512;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.Applicable;
			}
			set
			{
				short num = (short)1522580714;
				short num2 = num;
				num = (short)1811332330;
				switch (num2 == num)
				{
				}
				num = (short)1910308864;
				short num3 = num;
				num = (short)508755968;
				if (num != 0)
				{
				}
				num = (short)850460673;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.Applicable = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x001A96C0 File Offset: 0x001A78C0
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x001A9770 File Offset: 0x001A7970
		public bool TrkEmerProfGeneralKeySelect_A8970_Valid
		{
			get
			{
				short num = (short)1862509709;
				short num2 = num;
				num = (short)1572840589;
				switch (num2 == num)
				{
				}
				num = (short)1720123392;
				short num3 = num;
				num = (short)562888705;
				if (num != 0)
				{
				}
				num = (short)1635057664;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.Valid;
			}
			set
			{
				short num = (short)1504892005;
				short num2 = num;
				num = (short)1482871909;
				switch (num2 == num)
				{
				}
				num = (short)1495072768;
				short num3 = num;
				num = (short)1406926849;
				if (num != 0)
				{
				}
				num = (short)1810432000;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.Valid = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x001A9824 File Offset: 0x001A7A24
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x001A98DC File Offset: 0x001A7ADC
		public bool TrkEmerProfGeneralKeySelect_A8970_Visible
		{
			get
			{
				short num = (short)2083282978;
				short num2 = num;
				num = (short)1855283234;
				switch (num2 == num)
				{
				}
				num = (short)826933248;
				short num3 = num;
				num = (short)369688576;
				if (num != 0)
				{
				}
				num = (short)2116943873;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.Visible;
			}
			set
			{
				short num = (short)977741029;
				short num2 = num;
				num = (short)1034495205;
				switch (num2 == num)
				{
				}
				num = (short)1005125632;
				short num3 = num;
				num = (short)1647575041;
				if (num != 0)
				{
				}
				num = (short)910557184;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.Visible = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x001A9994 File Offset: 0x001A7B94
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x001A9A48 File Offset: 0x001A7C48
		public bool TrkEmerProfGeneralKeySelect_A8970_Editable
		{
			get
			{
				short num = (short)1072040931;
				short num2 = num;
				num = (short)150277091;
				switch (num2 == num)
				{
				}
				num = (short)982712320;
				short num3 = num;
				num = (short)546177025;
				if (num != 0)
				{
				}
				num = (short)1506738176;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.Editable;
			}
			set
			{
				short num = (short)1791924567;
				short num2 = num;
				num = (short)338794839;
				switch (num2 == num)
				{
				}
				num = (short)1395916800;
				short num3 = num;
				num = (short)129695745;
				if (num != 0)
				{
				}
				num = (short)1965686784;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.Editable = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x001A9AFC File Offset: 0x001A7CFC
		internal string TrkEmerProfGeneralKeySelect_A8970_UILabel
		{
			get
			{
				short num = (short)1527421493;
				short num2 = num;
				num = (short)1582864949;
				switch (num2 == num)
				{
				}
				num = (short)474284032;
				short num3 = num;
				num = (short)1894907904;
				if (num != 0)
				{
				}
				num = (short)2068840449;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.UIName;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x001A9BB0 File Offset: 0x001A7DB0
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x001A9C64 File Offset: 0x001A7E64
		internal bool TrkEmerProfGeneralKeySelect_A8970_HiddenStatic
		{
			get
			{
				short num = (short)799408129;
				if (num != 0)
				{
				}
				num = (short)1679278823;
				short num2 = num;
				num = (short)1240253159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516685824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1867448320;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.HiddenStatic;
			}
			set
			{
				short num = (short)1491271200;
				short num2 = num;
				num = (short)182320672;
				switch (num2 == num)
				{
				}
				num = (short)798031872;
				short num3 = num;
				num = (short)1864040448;
				if (num != 0)
				{
				}
				num = (short)1343029249;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.HiddenStatic = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x001A9D1C File Offset: 0x001A7F1C
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x001A9DD4 File Offset: 0x001A7FD4
		internal bool TrkEmerProfGeneralKeySelect_A8970_HiddenDynamic
		{
			get
			{
				short num = (short)1691721077;
				short num2 = num;
				num = (short)788307317;
				switch (num2 == num)
				{
				}
				num = (short)200802304;
				short num3 = num;
				num = (short)1420492801;
				if (num != 0)
				{
				}
				num = (short)1208156160;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970.HiddenDynamic;
			}
			set
			{
				short num = (short)1381047732;
				short num2 = num;
				num = (short)921181620;
				switch (num2 == num)
				{
				}
				num = (short)1840644096;
				short num3 = num;
				num = (short)279904257;
				if (num != 0)
				{
				}
				num = (short)1665204224;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralKeySelect_A8970.HiddenDynamic = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x001A9E88 File Offset: 0x001A8088
		public bool TrkEmerProfGeneralKeySelect_A8970_HasDiffs
		{
			get
			{
				short num = (short)1376022195;
				short num2 = num;
				num = (short)783314611;
				switch (num2 == num)
				{
				}
				num = (short)1277689856;
				short num3 = num;
				num = (short)1285357568;
				if (num != 0)
				{
				}
				num = (short)1539899393;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralKeySelect_A8970._HasDiffs;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x001A9F3C File Offset: 0x001A813C
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x001A9FF0 File Offset: 0x001A81F0
		public int TrkEmerProfGeneralSecureClearStrapping_A9092Value
		{
			get
			{
				short num = (short)1083450088;
				short num2 = num;
				num = (short)665789160;
				switch (num2 == num)
				{
				}
				num = (short)817233920;
				short num3 = num;
				num = (short)467402753;
				if (num != 0)
				{
				}
				num = (short)1629421568;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.Value;
			}
			set
			{
				short num = (short)1168406809;
				short num2 = num;
				num = (short)591100185;
				switch (num2 == num)
				{
				}
				num = (short)45023232;
				short num3 = num;
				num = (short)1738473472;
				if (num != 0)
				{
				}
				num = (short)1187840001;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.Value = value;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x001AA0A4 File Offset: 0x001A82A4
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x001AA15C File Offset: 0x001A835C
		public string TrkEmerProfGeneralSecureClearStrapping_A9092_UIValue
		{
			get
			{
				short num = (short)1718716192;
				short num2 = num;
				num = (short)1621460768;
				switch (num2 == num)
				{
				}
				num = (short)777191424;
				short num3 = num;
				num = (short)50200576;
				if (num != 0)
				{
				}
				num = (short)709820417;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.UIValue;
			}
			set
			{
				short num = (short)848824400;
				short num2 = num;
				num = (short)2120681552;
				switch (num2 == num)
				{
				}
				num = (short)318636032;
				short num3 = num;
				num = (short)329056257;
				if (num != 0)
				{
				}
				num = (short)616562688;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.UIValue = value;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x001AA210 File Offset: 0x001A8410
		public global::AcpBusinessLayer.AcpListField TrkEmerProfGeneralSecureClearStrapping_A9092
		{
			get
			{
				short num = (short)1391091114;
				short num2 = num;
				num = (short)1442930090;
				switch (num2 == num)
				{
				}
				num = (short)1655963648;
				short num3 = num;
				num = (short)1065418753;
				if (num != 0)
				{
				}
				num = (short)1054736384;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x001AA2C0 File Offset: 0x001A84C0
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x001AA374 File Offset: 0x001A8574
		public bool TrkEmerProfGeneralSecureClearStrapping_A9092_Applicable
		{
			get
			{
				short num = (short)519016674;
				short num2 = num;
				num = (short)1058574562;
				switch (num2 == num)
				{
				}
				num = (short)1017184256;
				short num3 = num;
				num = (short)843513857;
				if (num != 0)
				{
				}
				num = (short)1991639040;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.Applicable;
			}
			set
			{
				short num = (short)416327918;
				short num2 = num;
				num = (short)128952558;
				switch (num2 == num)
				{
				}
				num = (short)1935933440;
				short num3 = num;
				num = (short)1659764736;
				if (num != 0)
				{
				}
				num = (short)1279721473;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.Applicable = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x001AA42C File Offset: 0x001A862C
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x001AA4E0 File Offset: 0x001A86E0
		public bool TrkEmerProfGeneralSecureClearStrapping_A9092_Valid
		{
			get
			{
				short num = (short)1913646216;
				short num2 = num;
				num = (short)756673672;
				switch (num2 == num)
				{
				}
				num = (short)1031340032;
				short num3 = num;
				num = (short)141754369;
				if (num != 0)
				{
				}
				num = (short)1950679040;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.Valid;
			}
			set
			{
				short num = (short)480890855;
				short num2 = num;
				num = (short)2107953127;
				switch (num2 == num)
				{
				}
				num = (short)1174470656;
				short num3 = num;
				num = (short)1650065409;
				if (num != 0)
				{
				}
				num = (short)132055040;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.Valid = value;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x001AA598 File Offset: 0x001A8798
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x001AA64C File Offset: 0x001A884C
		public bool TrkEmerProfGeneralSecureClearStrapping_A9092_Visible
		{
			get
			{
				short num = (short)670917802;
				short num2 = num;
				num = (short)2016961706;
				switch (num2 == num)
				{
				}
				num = (short)1574305792;
				short num3 = num;
				num = (short)672071681;
				if (num != 0)
				{
				}
				num = (short)370081792;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.Visible;
			}
			set
			{
				short num = (short)825134695;
				short num2 = num;
				num = (short)99389031;
				switch (num2 == num)
				{
				}
				num = (short)1193672704;
				short num3 = num;
				num = (short)1816199169;
				if (num != 0)
				{
				}
				num = (short)1989410816;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.Visible = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x001AA704 File Offset: 0x001A8904
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x001AA7B8 File Offset: 0x001A89B8
		public bool TrkEmerProfGeneralSecureClearStrapping_A9092_Editable
		{
			get
			{
				short num = (short)520082637;
				short num2 = num;
				num = (short)96261325;
				switch (num2 == num)
				{
				}
				num = (short)2058289152;
				short num3 = num;
				num = (short)1423900673;
				if (num != 0)
				{
				}
				num = (short)882442240;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.Editable;
			}
			set
			{
				short num = (short)1533739009;
				if (num != 0)
				{
				}
				num = (short)301779992;
				short num2 = num;
				num = (short)1481165848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1878327296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1045495808;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.Editable = value;
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x001AA86C File Offset: 0x001A8A6C
		internal string TrkEmerProfGeneralSecureClearStrapping_A9092_UILabel
		{
			get
			{
				short num = (short)2126401185;
				short num2 = num;
				num = (short)1279413921;
				switch (num2 == num)
				{
				}
				num = (short)1278345216;
				short num3 = num;
				num = (short)661848065;
				if (num != 0)
				{
				}
				num = (short)1738539008;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.UIName;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x001AA920 File Offset: 0x001A8B20
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x001AA9D4 File Offset: 0x001A8BD4
		internal bool TrkEmerProfGeneralSecureClearStrapping_A9092_HiddenStatic
		{
			get
			{
				short num = (short)1271595008;
				short num2 = num;
				num = (short)2106650928;
				short num3 = num;
				num = (short)693956912;
				switch (num3 == num)
				{
				}
				num = (short)951189504;
				if (num != 0)
				{
				}
				num = (short)1136984065;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.HiddenStatic;
			}
			set
			{
				short num = (short)744685568;
				short num2 = num;
				num = (short)382271489;
				if (num != 0)
				{
				}
				num = (short)197662034;
				short num3 = num;
				num = (short)1944327506;
				switch (num3 == num)
				{
				}
				num = (short)1684340736;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.HiddenStatic = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x001AAA88 File Offset: 0x001A8C88
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x001AAB40 File Offset: 0x001A8D40
		internal bool TrkEmerProfGeneralSecureClearStrapping_A9092_HiddenDynamic
		{
			get
			{
				short num = (short)614465536;
				short num2 = num;
				num = (short)1138963322;
				short num3 = num;
				num = (short)732574586;
				switch (num3 == num)
				{
				}
				num = (short)856752129;
				if (num != 0)
				{
				}
				num = (short)250216448;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092.HiddenDynamic;
			}
			set
			{
				short num = (short)1780285440;
				short num2 = num;
				num = (short)1268776961;
				if (num != 0)
				{
				}
				num = (short)452959400;
				short num3 = num;
				num = (short)1501207720;
				switch (num3 == num)
				{
				}
				num = (short)51511296;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralSecureClearStrapping_A9092.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x001AABF8 File Offset: 0x001A8DF8
		public bool TrkEmerProfGeneralSecureClearStrapping_A9092_HasDiffs
		{
			get
			{
				short num = (short)1589837824;
				short num2 = num;
				num = (short)1847654883;
				short num3 = num;
				num = (short)1380514275;
				switch (num3 == num)
				{
				}
				num = (short)1318191105;
				if (num != 0)
				{
				}
				num = (short)1820786688;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralSecureClearStrapping_A9092._HasDiffs;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x001AACA8 File Offset: 0x001A8EA8
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x001AAD5C File Offset: 0x001A8F5C
		public int TrkPerGeneralSystem_A9237Value
		{
			get
			{
				short num = (short)168624128;
				short num2 = num;
				num = (short)1421843624;
				short num3 = num;
				num = (short)1718983848;
				switch (num3 == num)
				{
				}
				num = (short)593231873;
				if (num != 0)
				{
				}
				num = (short)887357440;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.Value;
			}
			set
			{
				short num = (short)1532428288;
				short num2 = num;
				num = (short)1147883383;
				short num3 = num;
				num = (short)675499895;
				switch (num3 == num)
				{
				}
				num = (short)2122055681;
				if (num != 0)
				{
				}
				num = (short)1229324288;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.Value = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x001AAE14 File Offset: 0x001A9014
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x001AAEC8 File Offset: 0x001A90C8
		public string TrkPerGeneralSystem_A9237_UIValue
		{
			get
			{
				short num = (short)1737949184;
				short num2 = num;
				num = (short)1573259745;
				short num3 = num;
				num = (short)1482230241;
				switch (num3 == num)
				{
				}
				num = (short)54394880;
				if (num != 0)
				{
				}
				num = (short)1300889601;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.UIValue;
			}
			set
			{
				short num = (short)531431424;
				short num2 = num;
				num = (short)937315366;
				short num3 = num;
				num = (short)476204070;
				switch (num3 == num)
				{
				}
				num = (short)642514944;
				if (num != 0)
				{
				}
				num = (short)668598273;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.UIValue = value;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x001AAF80 File Offset: 0x001A9180
		public global::AcpBusinessLayer.AcpRecRefField TrkPerGeneralSystem_A9237
		{
			get
			{
				short num = (short)1808662528;
				short num2 = num;
				num = (short)144218818;
				short num3 = num;
				num = (short)659987138;
				switch (num3 == num)
				{
				}
				num = (short)901709824;
				if (num != 0)
				{
				}
				num = (short)204800001;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x001AB030 File Offset: 0x001A9230
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x001AB0E4 File Offset: 0x001A92E4
		public bool TrkPerGeneralSystem_A9237_Applicable
		{
			get
			{
				short num = (short)12713984;
				short num2 = num;
				num = (short)1056898235;
				short num3 = num;
				num = (short)84278459;
				switch (num3 == num)
				{
				}
				num = (short)1158217728;
				if (num != 0)
				{
				}
				num = (short)1937637377;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.Applicable;
			}
			set
			{
				short num = (short)1489043456;
				short num2 = num;
				num = (short)1811283969;
				if (num != 0)
				{
				}
				num = (short)424010861;
				short num3 = num;
				num = (short)1404101741;
				switch (num3 == num)
				{
				}
				num = (short)1802371072;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.Applicable = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x001AB198 File Offset: 0x001A9398
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x001AB24C File Offset: 0x001A944C
		public bool TrkPerGeneralSystem_A9237_Valid
		{
			get
			{
				short num = (short)131596288;
				short num2 = num;
				num = (short)679451926;
				short num3 = num;
				num = (short)1600560406;
				switch (num3 == num)
				{
				}
				num = (short)771096577;
				if (num != 0)
				{
				}
				num = (short)2000355328;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.Valid;
			}
			set
			{
				short num = (short)1016004608;
				short num2 = num;
				num = (short)275464731;
				short num3 = num;
				num = (short)326582811;
				switch (num3 == num)
				{
				}
				num = (short)1316356097;
				if (num != 0)
				{
				}
				num = (short)192741376;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.Valid = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x001AB304 File Offset: 0x001A9504
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x001AB3B8 File Offset: 0x001A95B8
		public bool TrkPerGeneralSystem_A9237_Visible
		{
			get
			{
				short num = (short)540606464;
				short num2 = num;
				num = (short)1092679101;
				short num3 = num;
				num = (short)667940285;
				switch (num3 == num)
				{
				}
				num = (short)107610112;
				if (num != 0)
				{
				}
				num = (short)868483073;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.Visible;
			}
			set
			{
				short num = (short)1926234112;
				short num2 = num;
				num = (short)1560437527;
				short num3 = num;
				num = (short)1899782935;
				switch (num3 == num)
				{
				}
				num = (short)348127233;
				if (num != 0)
				{
				}
				num = (short)1436811264;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.Visible = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x001AB46C File Offset: 0x001A966C
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x001AB520 File Offset: 0x001A9720
		public bool TrkPerGeneralSystem_A9237_Editable
		{
			get
			{
				short num = (short)1514078208;
				short num2 = num;
				num = (short)2092921293;
				short num3 = num;
				num = (short)389378509;
				switch (num3 == num)
				{
				}
				num = (short)2100232193;
				if (num != 0)
				{
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.Editable;
			}
			set
			{
				short num = (short)2046951424;
				short num2 = num;
				num = (short)2074017948;
				short num3 = num;
				num = (short)1757085852;
				switch (num3 == num)
				{
				}
				num = (short)244842497;
				if (num != 0)
				{
				}
				num = (short)554631168;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.Editable = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x001AB5D4 File Offset: 0x001A97D4
		internal string TrkPerGeneralSystem_A9237_UILabel
		{
			get
			{
				short num = (short)1335820288;
				short num2 = num;
				num = (short)498455456;
				short num3 = num;
				num = (short)1620628384;
				switch (num3 == num)
				{
				}
				num = (short)1020067840;
				if (num != 0)
				{
				}
				num = (short)576192513;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.UIName;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x001AB688 File Offset: 0x001A9888
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x001AB73C File Offset: 0x001A993C
		internal bool TrkPerGeneralSystem_A9237_HiddenStatic
		{
			get
			{
				short num = (short)1345716224;
				short num2 = num;
				num = (short)1846603506;
				short num3 = num;
				num = (short)206237426;
				switch (num3 == num)
				{
				}
				num = (short)1299120128;
				if (num != 0)
				{
				}
				num = (short)833552385;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.HiddenStatic;
			}
			set
			{
				short num = (short)115539968;
				short num2 = num;
				num = (short)461963265;
				if (num != 0)
				{
				}
				num = (short)11875141;
				short num3 = num;
				num = (short)1750479685;
				switch (num3 == num)
				{
				}
				num = (short)1212612608;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.HiddenStatic = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x001AB7F4 File Offset: 0x001A99F4
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x001AB8A8 File Offset: 0x001A9AA8
		internal bool TrkPerGeneralSystem_A9237_HiddenDynamic
		{
			get
			{
				short num = (short)1363345408;
				short num2 = num;
				num = (short)1023415794;
				short num3 = num;
				num = (short)1998067186;
				switch (num3 == num)
				{
				}
				num = (short)1150615553;
				if (num != 0)
				{
				}
				num = (short)330235904;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237.HiddenDynamic;
			}
			set
			{
				short num = (short)12779520;
				short num2 = num;
				num = (short)1163201054;
				short num3 = num;
				num = (short)289671710;
				switch (num3 == num)
				{
				}
				num = (short)1053687809;
				if (num != 0)
				{
				}
				num = (short)581632000;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystem_A9237.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x001AB960 File Offset: 0x001A9B60
		public bool TrkPerGeneralSystem_A9237_HasDiffs
		{
			get
			{
				short num = (short)237699072;
				short num2 = num;
				num = (short)1720582145;
				if (num != 0)
				{
				}
				num = (short)1262891170;
				short num3 = num;
				num = (short)286339234;
				switch (num3 == num)
				{
				}
				num = (short)2109931520;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystem_A9237._HasDiffs;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x001ABA18 File Offset: 0x001A9C18
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x001ABACC File Offset: 0x001A9CCC
		public int TrkPerGeneralSystemID_A9238Value
		{
			get
			{
				short num = (short)1135411200;
				short num2 = num;
				num = (short)700100353;
				short num3 = num;
				num = (short)153005825;
				switch (num3 == num)
				{
				}
				num = (short)931397633;
				if (num != 0)
				{
				}
				num = (short)1020788736;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.Value;
			}
			set
			{
				short num = (short)1336410112;
				short num2 = num;
				num = (short)768409601;
				if (num != 0)
				{
				}
				num = (short)2106288418;
				short num3 = num;
				num = (short)1975281954;
				switch (num3 == num)
				{
				}
				num = (short)1396244480;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.Value = value;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x001ABB80 File Offset: 0x001A9D80
		public global::AcpBusinessLayer.AcpPointerField<int> TrkPerGeneralSystemID_A9238
		{
			get
			{
				short num = (short)1183252480;
				short num2 = num;
				num = (short)997737020;
				short num3 = num;
				num = (short)438256188;
				switch (num3 == num)
				{
				}
				num = (short)498466816;
				if (num != 0)
				{
				}
				num = (short)1544749057;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x001ABC2C File Offset: 0x001A9E2C
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x001ABCE4 File Offset: 0x001A9EE4
		public string TrkPerGeneralSystemID_A9238_UIValue
		{
			get
			{
				short num = (short)1366360064;
				short num2 = num;
				num = (short)2129211464;
				short num3 = num;
				num = (short)1999122504;
				switch (num3 == num)
				{
				}
				num = (short)891944960;
				if (num != 0)
				{
				}
				num = (short)151650305;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.UIValue;
			}
			set
			{
				short num = (short)23134208;
				short num2 = num;
				num = (short)132771075;
				short num3 = num;
				num = (short)1877929219;
				switch (num3 == num)
				{
				}
				num = (short)1517748225;
				if (num != 0)
				{
				}
				num = (short)268959744;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.UIValue = value;
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x001ABD98 File Offset: 0x001A9F98
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x001ABE4C File Offset: 0x001AA04C
		public string TrkPerGeneralSystemID_A9238_HexUIValue
		{
			get
			{
				short num = (short)375652352;
				short num2 = num;
				num = (short)345964545;
				if (num != 0)
				{
				}
				num = (short)1364213731;
				short num3 = num;
				num = (short)717176803;
				switch (num3 == num)
				{
				}
				num = (short)1973485568;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.HexUIValue;
			}
			set
			{
				short num = (short)531234816;
				short num2 = num;
				num = (short)1743734270;
				short num3 = num;
				num = (short)1291404798;
				switch (num3 == num)
				{
				}
				num = (short)1559035904;
				if (num != 0)
				{
				}
				num = (short)135725057;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.HexUIValue = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x001ABF04 File Offset: 0x001AA104
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x001ABFB8 File Offset: 0x001AA1B8
		public bool TrkPerGeneralSystemID_A9238_Applicable
		{
			get
			{
				short num = (short)1583218688;
				short num2 = num;
				num = (short)1986104148;
				short num3 = num;
				num = (short)610175828;
				switch (num3 == num)
				{
				}
				num = (short)344391681;
				if (num != 0)
				{
				}
				num = (short)616300544;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.Applicable;
			}
			set
			{
				short num = (short)509018112;
				short num2 = num;
				num = (short)1597528269;
				short num3 = num;
				num = (short)1477007565;
				switch (num3 == num)
				{
				}
				num = (short)840892417;
				if (num != 0)
				{
				}
				num = (short)2124283904;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.Applicable = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x001AC06C File Offset: 0x001AA26C
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x001AC120 File Offset: 0x001AA320
		public bool TrkPerGeneralSystemID_A9238_Valid
		{
			get
			{
				short num = (short)784924672;
				short num2 = num;
				num = (short)1587395905;
				short num3 = num;
				num = (short)1997716801;
				switch (num3 == num)
				{
				}
				num = (short)661716993;
				if (num != 0)
				{
				}
				num = (short)1390870528;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.Valid;
			}
			set
			{
				short num = (short)1663827968;
				short num2 = num;
				num = (short)509978663;
				short num3 = num;
				num = (short)1485088807;
				switch (num3 == num)
				{
				}
				num = (short)1110966273;
				if (num != 0)
				{
				}
				num = (short)1496317952;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.Valid = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x001AC1D4 File Offset: 0x001AA3D4
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x001AC288 File Offset: 0x001AA488
		public bool TrkPerGeneralSystemID_A9238_Visible
		{
			get
			{
				short num = (short)961478656;
				short num2 = num;
				num = (short)707822818;
				short num3 = num;
				num = (short)605914338;
				switch (num3 == num)
				{
				}
				num = (short)1741291521;
				if (num != 0)
				{
				}
				num = (short)163119104;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.Visible;
			}
			set
			{
				short num = (short)186384384;
				short num2 = num;
				num = (short)720605037;
				short num3 = num;
				num = (short)1222872941;
				switch (num3 == num)
				{
				}
				num = (short)302383104;
				if (num != 0)
				{
				}
				num = (short)782106625;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.Visible = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x001AC340 File Offset: 0x001AA540
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x001AC3F8 File Offset: 0x001AA5F8
		public bool TrkPerGeneralSystemID_A9238_Editable
		{
			get
			{
				short num = (short)27131904;
				short num2 = num;
				num = (short)1127637367;
				short num3 = num;
				num = (short)928342391;
				switch (num3 == num)
				{
				}
				num = (short)1219624960;
				if (num != 0)
				{
				}
				num = (short)550174721;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.Editable;
			}
			set
			{
				short num = (short)1189871616;
				short num2 = num;
				num = (short)407479185;
				short num3 = num;
				num = (short)1146135441;
				switch (num3 == num)
				{
				}
				num = (short)1995702272;
				if (num != 0)
				{
				}
				num = (short)1787625473;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.Editable = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x001AC4B0 File Offset: 0x001AA6B0
		internal string TrkPerGeneralSystemID_A9238_UILabel
		{
			get
			{
				short num = (short)2083454976;
				short num2 = num;
				num = (short)185499915;
				short num3 = num;
				num = (short)713851147;
				switch (num3 == num)
				{
				}
				num = (short)1190068225;
				if (num != 0)
				{
				}
				num = (short)107806720;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.UIName;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x001AC564 File Offset: 0x001AA764
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x001AC61C File Offset: 0x001AA81C
		internal bool TrkPerGeneralSystemID_A9238_HiddenStatic
		{
			get
			{
				short num = (short)523632640;
				short num2 = num;
				num = (short)118693691;
				short num3 = num;
				num = (short)2092834619;
				switch (num3 == num)
				{
				}
				num = (short)412549121;
				if (num != 0)
				{
				}
				num = (short)1024917504;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.HiddenStatic;
			}
			set
			{
				short num = (short)936837120;
				short num2 = num;
				num = (short)1297488135;
				short num3 = num;
				num = (short)1185487111;
				switch (num3 == num)
				{
				}
				num = (short)1662517248;
				if (num != 0)
				{
				}
				num = (short)1071448065;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.HiddenStatic = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x001AC6D4 File Offset: 0x001AA8D4
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x001AC784 File Offset: 0x001AA984
		internal bool TrkPerGeneralSystemID_A9238_HiddenDynamic
		{
			get
			{
				short num = (short)1641152512;
				short num2 = num;
				num = (short)2026581234;
				short num3 = num;
				num = (short)1960652018;
				switch (num3 == num)
				{
				}
				num = (short)1014300672;
				if (num != 0)
				{
				}
				num = (short)812253185;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238.HiddenDynamic;
			}
			set
			{
				short num = (short)1013579776;
				short num2 = num;
				num = (short)1662905438;
				short num3 = num;
				num = (short)1751772254;
				switch (num3 == num)
				{
				}
				num = (short)710868992;
				if (num != 0)
				{
				}
				num = (short)1518796801;
				if (num != 0)
				{
				}
				this.trkPerGeneralSystemID_A9238.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x001AC83C File Offset: 0x001AAA3C
		public bool TrkPerGeneralSystemID_A9238_HasDiffs
		{
			get
			{
				short num = (short)981467136;
				short num2 = num;
				num = (short)376638356;
				short num3 = num;
				num = (short)1458572180;
				switch (num3 == num)
				{
				}
				num = (short)757399552;
				if (num != 0)
				{
				}
				num = (short)319619073;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSystemID_A9238._HasDiffs;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x001AC8F0 File Offset: 0x001AAAF0
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x001AC9A4 File Offset: 0x001AABA4
		public int TrkPerGeneralTimeOutTimersec_A9379Value
		{
			get
			{
				short num = (short)308215808;
				short num2 = num;
				num = (short)1124628796;
				short num3 = num;
				num = (short)660109628;
				switch (num3 == num)
				{
				}
				num = (short)2095448065;
				if (num != 0)
				{
				}
				num = (short)1490681856;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379.Value;
			}
			set
			{
				short num = (short)1228013568;
				short num2 = num;
				num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)1244525516;
				short num3 = num;
				num = (short)1040708556;
				switch (num3 == num)
				{
				}
				num = (short)148635648;
				if (num != 0)
				{
				}
				this.trkPerGeneralTimeOutTimersec_A9379.Value = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x001ACA58 File Offset: 0x001AAC58
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerGeneralTimeOutTimersec_A9379
		{
			get
			{
				short num = (short)766377984;
				short num2 = num;
				num = (short)1504208594;
				short num3 = num;
				num = (short)1715496658;
				switch (num3 == num)
				{
				}
				num = (short)430243841;
				if (num != 0)
				{
				}
				num = (short)940376064;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x001ACB0C File Offset: 0x001AAD0C
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x001ACBC0 File Offset: 0x001AADC0
		public string TrkPerGeneralTimeOutTimersec_A9379_UIValue
		{
			get
			{
				short num = (short)694747136;
				short num2 = num;
				num = (short)1673721546;
				short num3 = num;
				num = (short)1297282762;
				switch (num3 == num)
				{
				}
				num = (short)185794561;
				if (num != 0)
				{
				}
				num = (short)1092812800;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379.UIValue;
			}
			set
			{
				short num = (short)1779761152;
				short num2 = num;
				num = (short)1190330369;
				if (num != 0)
				{
				}
				num = (short)350645455;
				short num3 = num;
				num = (short)1604938959;
				switch (num3 == num)
				{
				}
				num = (short)1668284416;
				if (num != 0)
				{
				}
				this.trkPerGeneralTimeOutTimersec_A9379.UIValue = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x001ACC74 File Offset: 0x001AAE74
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x001ACD2C File Offset: 0x001AAF2C
		internal int TrkPerGeneralTimeOutTimersec_A9379Min
		{
			get
			{
				short num = (short)551550976;
				short num2 = num;
				num = (short)918549212;
				short num3 = num;
				num = (short)181596892;
				switch (num3 == num)
				{
				}
				num = (short)1903951872;
				if (num != 0)
				{
				}
				num = (short)1968635905;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379.Min;
			}
			set
			{
				short num = (short)1134952448;
				short num2 = num;
				num = (short)1544195530;
				short num3 = num;
				num = (short)1011256778;
				switch (num3 == num)
				{
				}
				num = (short)476774400;
				if (num != 0)
				{
				}
				num = (short)1604255745;
				if (num != 0)
				{
				}
				this.trkPerGeneralTimeOutTimersec_A9379.Min = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x001ACDE0 File Offset: 0x001AAFE0
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x001ACE94 File Offset: 0x001AB094
		internal int TrkPerGeneralTimeOutTimersec_A9379Max
		{
			get
			{
				short num = (short)1664876544;
				short num2 = num;
				num = (short)1150615853;
				short num3 = num;
				num = (short)1543176493;
				switch (num3 == num)
				{
				}
				num = (short)881917952;
				if (num != 0)
				{
				}
				num = (short)1700003841;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379.Max;
			}
			set
			{
				short num = (short)1837367296;
				short num2 = num;
				num = (short)1649073445;
				short num3 = num;
				num = (short)1361632549;
				switch (num3 == num)
				{
				}
				num = (short)1632632833;
				if (num != 0)
				{
				}
				num = (short)2118385664;
				if (num != 0)
				{
				}
				this.trkPerGeneralTimeOutTimersec_A9379.Max = value;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x001ACF44 File Offset: 0x001AB144
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x001ACFFC File Offset: 0x001AB1FC
		internal int TrkPerGeneralTimeOutTimersec_A9379Step
		{
			get
			{
				short num = (short)1384316928;
				short num2 = num;
				num = (short)175898625;
				if (num != 0)
				{
				}
				num = (short)1291066204;
				short num3 = num;
				num = (short)1789139804;
				switch (num3 == num)
				{
				}
				num = (short)1518141440;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTimeOutTimersec_A9379.StepSize;
			}
			set
			{
				short num = (short)1565776701;
				short num2 = num;
				num = (short)2116541245;
				switch (num2 == num)
				{
				}
				num = (short)146866177;
				if (num != 0)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				num = (short)961347584;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.StepSize = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x001AD0B0 File Offset: 0x001AB2B0
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x001AD168 File Offset: 0x001AB368
		public bool TrkPerGeneralTimeOutTimersec_A9379_Applicable
		{
			get
			{
				short num = (short)698485555;
				short num2 = num;
				num = (short)192744243;
				switch (num2 == num)
				{
				}
				num = (short)358416384;
				if (num != 0)
				{
				}
				num = (short)464322561;
				if (num != 0)
				{
				}
				num = (short)866058240;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.Applicable;
			}
			set
			{
				short num = (short)1335558145;
				if (num != 0)
				{
				}
				num = (short)1667367639;
				short num2 = num;
				num = (short)1245774551;
				switch (num2 == num)
				{
				}
				num = (short)380960768;
				if (num != 0)
				{
				}
				num = (short)1086259200;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.Applicable = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x001AD21C File Offset: 0x001AB41C
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x001AD2D4 File Offset: 0x001AB4D4
		public bool TrkPerGeneralTimeOutTimersec_A9379_Valid
		{
			get
			{
				short num = (short)829484455;
				short num2 = num;
				num = (short)11726247;
				switch (num2 == num)
				{
				}
				num = (short)1805647873;
				if (num != 0)
				{
				}
				num = (short)1106837504;
				if (num != 0)
				{
				}
				num = (short)411631616;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.Valid;
			}
			set
			{
				short num = (short)1942786241;
				short num2 = num;
				num = (short)1922797761;
				switch (num2 == num)
				{
				}
				num = (short)801374209;
				if (num != 0)
				{
				}
				num = (short)298647552;
				if (num != 0)
				{
				}
				num = (short)721420288;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.Valid = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x001AD388 File Offset: 0x001AB588
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x001AD43C File Offset: 0x001AB63C
		public bool TrkPerGeneralTimeOutTimersec_A9379_Visible
		{
			get
			{
				short num = (short)480795244;
				short num2 = num;
				num = (short)1649564268;
				switch (num2 == num)
				{
				}
				num = (short)934936577;
				if (num != 0)
				{
				}
				num = (short)1701576704;
				if (num != 0)
				{
				}
				num = (short)1653932032;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.Visible;
			}
			set
			{
				short num = (short)1970478895;
				short num2 = num;
				num = (short)236855087;
				switch (num2 == num)
				{
				}
				num = (short)1947271169;
				if (num != 0)
				{
				}
				num = (short)1220542464;
				if (num != 0)
				{
				}
				num = (short)1310720;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.Visible = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x001AD4F4 File Offset: 0x001AB6F4
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x001AD5A8 File Offset: 0x001AB7A8
		public bool TrkPerGeneralTimeOutTimersec_A9379_Editable
		{
			get
			{
				short num = (short)304291037;
				short num2 = num;
				num = (short)974396637;
				switch (num2 == num)
				{
				}
				num = (short)1361903617;
				if (num != 0)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				num = (short)1446182912;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.Editable;
			}
			set
			{
				short num = (short)857803843;
				short num2 = num;
				num = (short)8916035;
				switch (num2 == num)
				{
				}
				num = (short)1602224128;
				if (num != 0)
				{
				}
				num = (short)1524563969;
				if (num != 0)
				{
				}
				num = (short)108462080;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.Editable = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x001AD65C File Offset: 0x001AB85C
		internal string TrkPerGeneralTimeOutTimersec_A9379_UILabel
		{
			get
			{
				short num = (short)372135108;
				short num2 = num;
				num = (short)240538820;
				switch (num2 == num)
				{
				}
				num = (short)563871744;
				if (num != 0)
				{
				}
				num = (short)1762787329;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.UIName;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x001AD710 File Offset: 0x001AB910
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x001AD7C4 File Offset: 0x001AB9C4
		internal bool TrkPerGeneralTimeOutTimersec_A9379_HiddenStatic
		{
			get
			{
				short num = (short)326857062;
				short num2 = num;
				num = (short)1413968230;
				switch (num2 == num)
				{
				}
				num = (short)989528064;
				if (num != 0)
				{
				}
				num = (short)950599681;
				if (num != 0)
				{
				}
				num = (short)1612775424;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.HiddenStatic;
			}
			set
			{
				short num = (short)244550560;
				short num2 = num;
				num = (short)871795616;
				switch (num2 == num)
				{
				}
				num = (short)1679491073;
				if (num != 0)
				{
				}
				num = (short)1275133952;
				if (num != 0)
				{
				}
				num = (short)2144600064;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.HiddenStatic = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x001AD878 File Offset: 0x001ABA78
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x001AD92C File Offset: 0x001ABB2C
		internal bool TrkPerGeneralTimeOutTimersec_A9379_HiddenDynamic
		{
			get
			{
				short num = (short)2078539777;
				if (num != 0)
				{
				}
				num = (short)50978772;
				short num2 = num;
				num = (short)286187476;
				switch (num2 == num)
				{
				}
				num = (short)956694528;
				if (num != 0)
				{
				}
				num = (short)798359552;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379.HiddenDynamic;
			}
			set
			{
				short num = (short)1728682484;
				short num2 = num;
				num = (short)285776372;
				switch (num2 == num)
				{
				}
				num = (short)1749876737;
				if (num != 0)
				{
				}
				num = (short)452722688;
				if (num != 0)
				{
				}
				num = (short)106823680;
				short num3 = num;
				this.trkPerGeneralTimeOutTimersec_A9379.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x001AD9E0 File Offset: 0x001ABBE0
		public bool TrkPerGeneralTimeOutTimersec_A9379_HasDiffs
		{
			get
			{
				short num = (short)1886548186;
				short num2 = num;
				num = (short)133132506;
				switch (num2 == num)
				{
				}
				num = (short)1240530945;
				if (num != 0)
				{
				}
				num = (short)1364066304;
				if (num != 0)
				{
				}
				num = (short)387645440;
				short num3 = num;
				return this.trkPerGeneralTimeOutTimersec_A9379._HasDiffs;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x001ADA98 File Offset: 0x001ABC98
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x001ADB4C File Offset: 0x001ABD4C
		public int TrkPerGeneralTxFrequencyMHz_A9413Value
		{
			get
			{
				short num = (short)372102057;
				short num2 = num;
				num = (short)372167593;
				switch (num2 == num)
				{
				}
				num = (short)1592197121;
				if (num != 0)
				{
				}
				num = (short)647036928;
				if (num != 0)
				{
				}
				num = (short)1172439040;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Value;
			}
			set
			{
				short num = (short)2099646549;
				short num2 = num;
				num = (short)672272469;
				switch (num2 == num)
				{
				}
				num = (short)1053032449;
				if (num != 0)
				{
				}
				num = (short)866189312;
				if (num != 0)
				{
				}
				num = (short)872153088;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Value = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x001ADC00 File Offset: 0x001ABE00
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x001ADCB8 File Offset: 0x001ABEB8
		public string TrkPerGeneralTxFrequencyMHz_A9413_UIValue
		{
			get
			{
				short num = (short)602365195;
				short num2 = num;
				num = (short)1385651467;
				switch (num2 == num)
				{
				}
				num = (short)1461977088;
				if (num != 0)
				{
				}
				num = (short)1387724801;
				if (num != 0)
				{
				}
				num = (short)2075918336;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.UIValue;
			}
			set
			{
				short num = (short)1102533268;
				short num2 = num;
				num = (short)1671975572;
				switch (num2 == num)
				{
				}
				num = (short)617742337;
				if (num != 0)
				{
				}
				num = (short)402063360;
				if (num != 0)
				{
				}
				num = (short)2111832064;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.UIValue = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x001ADD70 File Offset: 0x001ABF70
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerGeneralTxFrequencyMHz_A9413
		{
			get
			{
				short num = (short)1752485814;
				short num2 = num;
				num = (short)1631768502;
				switch (num2 == num)
				{
				}
				num = (short)1960443905;
				if (num != 0)
				{
				}
				num = (short)1650917376;
				if (num != 0)
				{
				}
				num = (short)636485632;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x001ADE1C File Offset: 0x001AC01C
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x001ADED0 File Offset: 0x001AC0D0
		internal int TrkPerGeneralTxFrequencyMHz_A9413Min
		{
			get
			{
				short num = (short)275454525;
				short num2 = num;
				num = (short)1610357309;
				switch (num2 == num)
				{
				}
				num = (short)1706033153;
				if (num != 0)
				{
				}
				num = (short)1001914368;
				if (num != 0)
				{
				}
				num = (short)1943470080;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Min;
			}
			set
			{
				short num = (short)939452672;
				short num2 = num;
				num = (short)810936576;
				switch (num2 == num)
				{
				}
				num = (short)84082688;
				if (num != 0)
				{
				}
				num = (short)805306369;
				if (num != 0)
				{
				}
				num = (short)1703280640;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Min = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x001ADF88 File Offset: 0x001AC188
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x001AE03C File Offset: 0x001AC23C
		internal int TrkPerGeneralTxFrequencyMHz_A9413Max
		{
			get
			{
				short num = (short)596254144;
				short num2 = num;
				num = (short)12262848;
				switch (num2 == num)
				{
				}
				num = (short)507314177;
				if (num != 0)
				{
				}
				num = (short)2025390080;
				if (num != 0)
				{
				}
				num = (short)1398079488;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Max;
			}
			set
			{
				short num = (short)844768525;
				short num2 = num;
				num = (short)1202267405;
				switch (num2 == num)
				{
				}
				num = (short)994115585;
				if (num != 0)
				{
				}
				num = (short)320864256;
				if (num != 0)
				{
				}
				num = (short)2038366208;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Max = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x001AE0F4 File Offset: 0x001AC2F4
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x001AE1A8 File Offset: 0x001AC3A8
		internal int TrkPerGeneralTxFrequencyMHz_A9413Step
		{
			get
			{
				short num = (short)79246789;
				short num2 = num;
				num = (short)103167429;
				switch (num2 == num)
				{
				}
				num = (short)266665984;
				if (num != 0)
				{
				}
				num = (short)156499969;
				if (num != 0)
				{
				}
				num = (short)597032960;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.StepSize;
			}
			set
			{
				short num = (short)2003435521;
				if (num != 0)
				{
				}
				num = (short)351958357;
				short num2 = num;
				num = (short)930248021;
				switch (num2 == num)
				{
				}
				num = (short)331153408;
				if (num != 0)
				{
				}
				num = (short)5701632;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.StepSize = value;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x001AE25C File Offset: 0x001AC45C
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x001AE314 File Offset: 0x001AC514
		public bool TrkPerGeneralTxFrequencyMHz_A9413_Applicable
		{
			get
			{
				short num = (short)1307836417;
				if (num != 0)
				{
				}
				num = (short)552721257;
				short num2 = num;
				num = (short)1018616681;
				switch (num2 == num)
				{
				}
				num = (short)645332992;
				if (num != 0)
				{
				}
				num = (short)705036288;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Applicable;
			}
			set
			{
				short num = (short)950679933;
				short num2 = num;
				num = (short)1642150269;
				switch (num2 == num)
				{
				}
				num = (short)151846913;
				if (num != 0)
				{
				}
				num = (short)450625536;
				if (num != 0)
				{
				}
				num = (short)293732352;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Applicable = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x001AE3C8 File Offset: 0x001AC5C8
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x001AE47C File Offset: 0x001AC67C
		public bool TrkPerGeneralTxFrequencyMHz_A9413_Valid
		{
			get
			{
				short num = (short)577208371;
				short num2 = num;
				num = (short)5079091;
				switch (num2 == num)
				{
				}
				num = (short)239534081;
				if (num != 0)
				{
				}
				num = (short)208863232;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Valid;
			}
			set
			{
				short num = (short)358023169;
				if (num != 0)
				{
				}
				num = (short)1133595910;
				short num2 = num;
				num = (short)2092715270;
				switch (num2 == num)
				{
				}
				num = (short)1646198784;
				if (num != 0)
				{
				}
				num = (short)334168064;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Valid = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x001AE530 File Offset: 0x001AC730
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x001AE5E4 File Offset: 0x001AC7E4
		public bool TrkPerGeneralTxFrequencyMHz_A9413_Visible
		{
			get
			{
				short num = (short)1731526657;
				if (num != 0)
				{
				}
				num = (short)1598732340;
				short num2 = num;
				num = (short)481540148;
				switch (num2 == num)
				{
				}
				num = (short)1812725760;
				if (num != 0)
				{
				}
				num = (short)1806893056;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Visible;
			}
			set
			{
				short num = (short)1485998631;
				short num2 = num;
				num = (short)56789543;
				switch (num2 == num)
				{
				}
				num = (short)202571777;
				if (num != 0)
				{
				}
				num = (short)1907884032;
				if (num != 0)
				{
				}
				num = (short)1102118912;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Visible = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x001AE698 File Offset: 0x001AC898
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x001AE750 File Offset: 0x001AC950
		public bool TrkPerGeneralTxFrequencyMHz_A9413_Editable
		{
			get
			{
				short num = (short)158497703;
				short num2 = num;
				num = (short)1219787687;
				switch (num2 == num)
				{
				}
				num = (short)940965889;
				if (num != 0)
				{
				}
				num = (short)546504704;
				if (num != 0)
				{
				}
				num = (short)700055552;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.Editable;
			}
			set
			{
				short num = (short)1938137573;
				short num2 = num;
				num = (short)2008588773;
				switch (num2 == num)
				{
				}
				num = (short)1133510657;
				if (num != 0)
				{
				}
				num = (short)1062338560;
				if (num != 0)
				{
				}
				num = (short)1081933824;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.Editable = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x001AE804 File Offset: 0x001ACA04
		internal string TrkPerGeneralTxFrequencyMHz_A9413_UILabel
		{
			get
			{
				short num = (short)1139264745;
				short num2 = num;
				num = (short)1609878761;
				switch (num2 == num)
				{
				}
				num = (short)1131282433;
				if (num != 0)
				{
				}
				num = (short)1225457664;
				if (num != 0)
				{
				}
				num = (short)1557987328;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.UIName;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x001AE8B8 File Offset: 0x001ACAB8
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x001AE96C File Offset: 0x001ACB6C
		internal bool TrkPerGeneralTxFrequencyMHz_A9413_HiddenStatic
		{
			get
			{
				short num = (short)446921134;
				short num2 = num;
				num = (short)1954904494;
				switch (num2 == num)
				{
				}
				num = (short)41484288;
				if (num != 0)
				{
				}
				num = (short)1204813825;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.HiddenStatic;
			}
			set
			{
				short num = (short)1879674006;
				short num2 = num;
				num = (short)1286900886;
				switch (num2 == num)
				{
				}
				num = (short)1973223424;
				if (num != 0)
				{
				}
				num = (short)1864695809;
				if (num != 0)
				{
				}
				num = (short)1831862272;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.HiddenStatic = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x001AEA20 File Offset: 0x001ACC20
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x001AEAD8 File Offset: 0x001ACCD8
		internal bool TrkPerGeneralTxFrequencyMHz_A9413_HiddenDynamic
		{
			get
			{
				short num = (short)655097857;
				if (num != 0)
				{
				}
				num = (short)159544272;
				short num2 = num;
				num = (short)353924048;
				switch (num2 == num)
				{
				}
				num = (short)1948712960;
				if (num != 0)
				{
				}
				num = (short)1972895744;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413.HiddenDynamic;
			}
			set
			{
				short num = (short)886182608;
				short num2 = num;
				num = (short)500110032;
				switch (num2 == num)
				{
				}
				num = (short)319356929;
				if (num != 0)
				{
				}
				num = (short)2119630848;
				if (num != 0)
				{
				}
				num = (short)1247543296;
				short num3 = num;
				this.trkPerGeneralTxFrequencyMHz_A9413.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x001AEB90 File Offset: 0x001ACD90
		public bool TrkPerGeneralTxFrequencyMHz_A9413_HasDiffs
		{
			get
			{
				short num = (short)827205278;
				short num2 = num;
				num = (short)1727276702;
				switch (num2 == num)
				{
				}
				num = (short)590217216;
				if (num != 0)
				{
				}
				num = (short)2046361601;
				if (num != 0)
				{
				}
				num = (short)1245249536;
				short num3 = num;
				return this.trkPerGeneralTxFrequencyMHz_A9413._HasDiffs;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x001AEC48 File Offset: 0x001ACE48
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x001AECFC File Offset: 0x001ACEFC
		public int TrkPerGeneralUnitID_A9593Value
		{
			get
			{
				short num = (short)1458503681;
				if (num != 0)
				{
				}
				num = (short)1703477260;
				short num2 = num;
				num = (short)2101084172;
				switch (num2 == num)
				{
				}
				num = (short)157286400;
				if (num != 0)
				{
				}
				num = (short)724303872;
				short num3 = num;
				return this.trkPerGeneralUnitID_A9593.Value;
			}
			set
			{
				short num = (short)870710313;
				short num2 = num;
				num = (short)782957609;
				switch (num2 == num)
				{
				}
				num = (short)355401729;
				if (num != 0)
				{
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				num = (short)310444032;
				short num3 = num;
				this.trkPerGeneralUnitID_A9593.Value = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x001AEDB4 File Offset: 0x001ACFB4
		public global::AcpBusinessLayer.AcpPointerField<int> TrkPerGeneralUnitID_A9593
		{
			get
			{
				short num = (short)2140151982;
				short num2 = num;
				num = (short)1477517486;
				switch (num2 == num)
				{
				}
				num = (short)1550909440;
				if (num != 0)
				{
				}
				num = (short)1714028545;
				if (num != 0)
				{
				}
				num = (short)4849664;
				short num3 = num;
				return this.trkPerGeneralUnitID_A9593;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x001AEE64 File Offset: 0x001AD064
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x001AEF18 File Offset: 0x001AD118
		public string TrkPerGeneralUnitID_A9593_UIValue
		{
			get
			{
				short num = (short)1018730393;
				short num2 = num;
				num = (short)1761318809;
				switch (num2 == num)
				{
				}
				num = (short)333578240;
				if (num != 0)
				{
				}
				num = (short)1270743041;
				if (num != 0)
				{
				}
				num = (short)517079040;
				short num3 = num;
				return this.trkPerGeneralUnitID_A9593.UIValue;
			}
			set
			{
				short num = (short)1167458305;
				if (num != 0)
				{
				}
				num = (short)626039342;
				short num2 = num;
				num = (short)19569198;
				switch (num2 == num)
				{
				}
				num = (short)2119565312;
				if (num != 0)
				{
				}
				num = (short)500563968;
				short num3 = num;
				this.trkPerGeneralUnitID_A9593.UIValue = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x001AEFCC File Offset: 0x001AD1CC
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x001AF080 File Offset: 0x001AD280
		public string TrkPerGeneralUnitID_A9593_HexUIValue
		{
			get
			{
				short num = (short)1529474460;
				short num2 = num;
				num = (short)894889372;
				switch (num2 == num)
				{
				}
				num = (short)1538981888;
				if (num != 0)
				{
				}
				num = (short)672595968;
				short num3 = num;
				num = (short)942080001;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.HexUIValue;
			}
			set
			{
				short num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)2128548856;
				short num2 = num;
				num = (short)101585912;
				switch (num2 == num)
				{
				}
				num = (short)1425735680;
				short num3 = num;
				num = (short)13631488;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.HexUIValue = value;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x001AF134 File Offset: 0x001AD334
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x001AF1E8 File Offset: 0x001AD3E8
		public bool TrkPerGeneralUnitID_A9593_Applicable
		{
			get
			{
				short num = (short)2046938334;
				short num2 = num;
				num = (short)1514523870;
				switch (num2 == num)
				{
				}
				num = (short)1865613312;
				if (num != 0)
				{
				}
				num = (short)1470824448;
				short num3 = num;
				num = (short)1127022593;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.Applicable;
			}
			set
			{
				short num = (short)286557679;
				short num2 = num;
				num = (short)1968342511;
				switch (num2 == num)
				{
				}
				num = (short)929824768;
				if (num != 0)
				{
				}
				num = (short)1767571456;
				short num3 = num;
				num = (short)1848836097;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.Applicable = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x001AF2A0 File Offset: 0x001AD4A0
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x001AF354 File Offset: 0x001AD554
		public bool TrkPerGeneralUnitID_A9593_Valid
		{
			get
			{
				short num = (short)1049270565;
				short num2 = num;
				num = (short)1739102501;
				switch (num2 == num)
				{
				}
				num = (short)345440257;
				if (num != 0)
				{
				}
				num = (short)119472128;
				short num3 = num;
				num = (short)1961033728;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.Valid;
			}
			set
			{
				short num = (short)401072774;
				short num2 = num;
				num = (short)1711268486;
				switch (num2 == num)
				{
				}
				num = (short)1784020993;
				if (num != 0)
				{
				}
				num = (short)885456896;
				short num3 = num;
				num = (short)134021120;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.Valid = value;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x001AF40C File Offset: 0x001AD60C
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x001AF4C0 File Offset: 0x001AD6C0
		public bool TrkPerGeneralUnitID_A9593_Visible
		{
			get
			{
				short num = (short)1373634561;
				if (num != 0)
				{
				}
				num = (short)660156607;
				short num2 = num;
				num = (short)1103638719;
				switch (num2 == num)
				{
				}
				num = (short)1249902592;
				short num3 = num;
				num = (short)1262092288;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.Visible;
			}
			set
			{
				short num = (short)1903996568;
				short num2 = num;
				num = (short)2023665304;
				switch (num2 == num)
				{
				}
				num = (short)1464729601;
				if (num != 0)
				{
				}
				num = (short)2060910592;
				short num3 = num;
				num = (short)663420928;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.Visible = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x001AF578 File Offset: 0x001AD778
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x001AF630 File Offset: 0x001AD830
		public bool TrkPerGeneralUnitID_A9593_Editable
		{
			get
			{
				short num = (short)2107113473;
				if (num != 0)
				{
				}
				num = (short)1667304815;
				short num2 = num;
				num = (short)1981025647;
				switch (num2 == num)
				{
				}
				num = (short)262209536;
				short num3 = num;
				num = (short)1580269568;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.Editable;
			}
			set
			{
				short num = (short)137363742;
				short num2 = num;
				num = (short)1201078558;
				switch (num2 == num)
				{
				}
				num = (short)482476032;
				if (num != 0)
				{
				}
				num = (short)1839398912;
				short num3 = num;
				num = (short)106037249;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.Editable = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x001AF6E8 File Offset: 0x001AD8E8
		internal string TrkPerGeneralUnitID_A9593_UILabel
		{
			get
			{
				short num = (short)372503101;
				short num2 = num;
				num = (short)28635709;
				switch (num2 == num)
				{
				}
				num = (short)470482945;
				if (num != 0)
				{
				}
				num = (short)951189504;
				short num3 = num;
				num = (short)914358272;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.UIName;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x001AF79C File Offset: 0x001AD99C
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x001AF854 File Offset: 0x001ADA54
		internal bool TrkPerGeneralUnitID_A9593_HiddenStatic
		{
			get
			{
				short num = (short)1047129458;
				short num2 = num;
				num = (short)1710943602;
				switch (num2 == num)
				{
				}
				num = (short)238813185;
				if (num != 0)
				{
				}
				num = (short)1844772864;
				short num3 = num;
				num = (short)879886336;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.HiddenStatic;
			}
			set
			{
				short num = (short)1983503817;
				short num2 = num;
				num = (short)1192680905;
				switch (num2 == num)
				{
				}
				num = (short)907018240;
				if (num != 0)
				{
				}
				num = (short)2019164160;
				short num3 = num;
				num = (short)2118582273;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.HiddenStatic = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x001AF90C File Offset: 0x001ADB0C
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x001AF9C0 File Offset: 0x001ADBC0
		internal bool TrkPerGeneralUnitID_A9593_HiddenDynamic
		{
			get
			{
				short num = (short)1173993442;
				short num2 = num;
				num = (short)1385281506;
				switch (num2 == num)
				{
				}
				num = (short)97517568;
				if (num != 0)
				{
				}
				num = (short)221970432;
				short num3 = num;
				num = (short)1444151297;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593.HiddenDynamic;
			}
			set
			{
				short num = (short)1063328619;
				short num2 = num;
				num = (short)24976235;
				switch (num2 == num)
				{
				}
				num = (short)1752104961;
				if (num != 0)
				{
				}
				num = (short)1483079680;
				short num3 = num;
				num = (short)152829952;
				if (num != 0)
				{
				}
				this.trkPerGeneralUnitID_A9593.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x001AFA74 File Offset: 0x001ADC74
		public bool TrkPerGeneralUnitID_A9593_HasDiffs
		{
			get
			{
				short num = (short)1679785731;
				short num2 = num;
				num = (short)286228227;
				switch (num2 == num)
				{
				}
				num = (short)812777473;
				if (num != 0)
				{
				}
				num = (short)1686110208;
				short num3 = num;
				num = (short)623116288;
				if (num != 0)
				{
				}
				return this.trkPerGeneralUnitID_A9593._HasDiffs;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x001AFB28 File Offset: 0x001ADD28
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x001AFBDC File Offset: 0x001ADDDC
		public string TrkPerGeneralTrunkingPersonalityName_A12659Value
		{
			get
			{
				short num = (short)438042625;
				if (num != 0)
				{
				}
				num = (short)1465771441;
				short num2 = num;
				num = (short)1412031921;
				switch (num2 == num)
				{
				}
				num = (short)2067988480;
				short num3 = num;
				num = (short)1910505472;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)477691906;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							num = (short)1991482537;
							short num3 = num;
							num = (short)208510121;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)2013593600;
								if (num != 0)
								{
								}
								this.trkPerGeneralTrunkingPersonalityName_A12659.Value = value;
								num = (short)1152122880;
								short num4 = num;
								num = (short)680853504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						}
						IL_30:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1064173569;
						if (num != 0)
						{
						}
						num = (short)1525415937;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x001AFD04 File Offset: 0x001ADF04
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x001AFDBC File Offset: 0x001ADFBC
		public string TrkPerGeneralTrunkingPersonalityName_A12659_UIValue
		{
			get
			{
				short num = (short)589807420;
				short num2 = num;
				num = (short)1495056188;
				switch (num2 == num)
				{
				}
				num = (short)991100928;
				if (num != 0)
				{
				}
				num = (short)375259136;
				short num3 = num;
				num = (short)1796079617;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Value;
			}
			set
			{
				short num = (short)1050254480;
				short num2 = num;
				num = (short)1734909072;
				switch (num2 == num)
				{
				}
				num = (short)245432320;
				if (num != 0)
				{
				}
				num = (short)141885440;
				short num3 = num;
				num = (short)1698103297;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.Value = value;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x001AFE70 File Offset: 0x001AE070
		public global::AcpBusinessLayer.AcpKeyField TrkPerGeneralTrunkingPersonalityName_A12659
		{
			get
			{
				short num = (short)492037951;
				short num2 = num;
				num = (short)1289676607;
				switch (num2 == num)
				{
				}
				num = (short)155975681;
				if (num != 0)
				{
				}
				num = (short)1097531392;
				short num3 = num;
				num = (short)1102249984;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x001AFF20 File Offset: 0x001AE120
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x001AFFD8 File Offset: 0x001AE1D8
		public bool TrkPerGeneralTrunkingPersonalityName_A12659_Applicable
		{
			get
			{
				short num = (short)2145718265;
				short num2 = num;
				num = (short)1251479545;
				switch (num2 == num)
				{
				}
				num = (short)1646592001;
				if (num != 0)
				{
				}
				num = (short)1349779456;
				short num3 = num;
				num = (short)1337131008;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Applicable;
			}
			set
			{
				short num = (short)204553710;
				short num2 = num;
				num = (short)1956789742;
				switch (num2 == num)
				{
				}
				num = (short)2015887360;
				if (num != 0)
				{
				}
				num = (short)1704263680;
				short num3 = num;
				num = (short)1128005633;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.Applicable = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x001B008C File Offset: 0x001AE28C
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x001B0140 File Offset: 0x001AE340
		public bool TrkPerGeneralTrunkingPersonalityName_A12659_Valid
		{
			get
			{
				short num = (short)676252938;
				short num2 = num;
				num = (short)1549913354;
				switch (num2 == num)
				{
				}
				num = (short)63700993;
				if (num != 0)
				{
				}
				num = (short)81985536;
				short num3 = num;
				num = (short)399441920;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Valid;
			}
			set
			{
				short num = (short)1803482923;
				short num2 = num;
				num = (short)1921382187;
				switch (num2 == num)
				{
				}
				num = (short)422313985;
				if (num != 0)
				{
				}
				num = (short)503250944;
				short num3 = num;
				num = (short)424542208;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.Valid = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x001B01F4 File Offset: 0x001AE3F4
		// (set) Token: 0x06001A88 RID: 6792 RVA: 0x001B02AC File Offset: 0x001AE4AC
		public bool TrkPerGeneralTrunkingPersonalityName_A12659_Visible
		{
			get
			{
				short num = (short)448349971;
				short num2 = num;
				num = (short)757417747;
				switch (num2 == num)
				{
				}
				num = (short)1305411584;
				if (num != 0)
				{
				}
				num = (short)2020868096;
				short num3 = num;
				num = (short)648085505;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Visible;
			}
			set
			{
				short num = (short)1973329029;
				short num2 = num;
				num = (short)689020037;
				switch (num2 == num)
				{
				}
				num = (short)1995177985;
				if (num != 0)
				{
				}
				num = (short)1183252480;
				short num3 = num;
				num = (short)1749614592;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.Visible = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x001B0364 File Offset: 0x001AE564
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x001B0418 File Offset: 0x001AE618
		public bool TrkPerGeneralTrunkingPersonalityName_A12659_Editable
		{
			get
			{
				short num = (short)782912059;
				short num2 = num;
				num = (short)69749307;
				switch (num2 == num)
				{
				}
				num = (short)1133641729;
				if (num != 0)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				num = (short)191430656;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.Editable;
			}
			set
			{
				short num = (short)87698421;
				short num2 = num;
				num = (short)2036345845;
				switch (num2 == num)
				{
				}
				num = (short)81788928;
				if (num != 0)
				{
				}
				num = (short)128122880;
				short num3 = num;
				num = (short)1950023681;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.Editable = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x001B04CC File Offset: 0x001AE6CC
		internal string TrkPerGeneralTrunkingPersonalityName_A12659_UILabel
		{
			get
			{
				short num = (short)1099890689;
				if (num != 0)
				{
				}
				num = (short)1002622890;
				short num2 = num;
				num = (short)920506282;
				switch (num2 == num)
				{
				}
				num = (short)1001259008;
				short num3 = num;
				num = (short)200146944;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.UIName;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x001B0584 File Offset: 0x001AE784
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x001B063C File Offset: 0x001AE83C
		internal bool TrkPerGeneralTrunkingPersonalityName_A12659_HiddenStatic
		{
			get
			{
				short num = (short)1592991252;
				short num2 = num;
				num = (short)1215176212;
				switch (num2 == num)
				{
				}
				num = (short)1006043136;
				if (num != 0)
				{
				}
				num = (short)967704576;
				short num3 = num;
				num = (short)1009319937;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.HiddenStatic;
			}
			set
			{
				short num = (short)287440897;
				if (num != 0)
				{
				}
				num = (short)1933953105;
				short num2 = num;
				num = (short)1075300433;
				switch (num2 == num)
				{
				}
				num = (short)1660813312;
				short num3 = num;
				num = (short)2010710016;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.HiddenStatic = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x001B06F4 File Offset: 0x001AE8F4
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x001B07A8 File Offset: 0x001AE9A8
		internal bool TrkPerGeneralTrunkingPersonalityName_A12659_HiddenDynamic
		{
			get
			{
				short num = (short)1277199911;
				short num2 = num;
				num = (short)1860077095;
				switch (num2 == num)
				{
				}
				num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)2077949952;
				short num3 = num;
				num = (short)1012137984;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659.HiddenDynamic;
			}
			set
			{
				short num = (short)935299807;
				short num2 = num;
				num = (short)1969851103;
				switch (num2 == num)
				{
				}
				num = (short)1471217665;
				if (num != 0)
				{
				}
				num = (short)234356736;
				short num3 = num;
				num = (short)1077739520;
				if (num != 0)
				{
				}
				this.trkPerGeneralTrunkingPersonalityName_A12659.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x001B0860 File Offset: 0x001AEA60
		public bool TrkPerGeneralTrunkingPersonalityName_A12659_HasDiffs
		{
			get
			{
				short num = (short)674758657;
				if (num != 0)
				{
				}
				num = (short)109791273;
				short num2 = num;
				num = (short)1018906665;
				switch (num2 == num)
				{
				}
				num = (short)657391616;
				short num3 = num;
				num = (short)534577152;
				if (num != 0)
				{
				}
				return this.trkPerGeneralTrunkingPersonalityName_A12659._HasDiffs;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x001B0914 File Offset: 0x001AEB14
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x001B09C4 File Offset: 0x001AEBC4
		public int TrkPerGeneralSecondaryTxFrequencyMHz_A12902Value
		{
			get
			{
				short num = (short)1738367325;
				short num2 = num;
				num = (short)1840931165;
				switch (num2 == num)
				{
				}
				num = (short)1566900224;
				if (num != 0)
				{
				}
				num = (short)1049362432;
				short num3 = num;
				num = (short)829161473;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Value;
			}
			set
			{
				short num = (short)623050753;
				if (num != 0)
				{
				}
				num = (short)984944266;
				short num2 = num;
				num = (short)2041974410;
				switch (num2 == num)
				{
				}
				num = (short)556924928;
				short num3 = num;
				num = (short)2124873728;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Value = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x001B0A7C File Offset: 0x001AEC7C
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x001B0B34 File Offset: 0x001AED34
		public string TrkPerGeneralSecondaryTxFrequencyMHz_A12902_UIValue
		{
			get
			{
				short num = (short)2111091597;
				short num2 = num;
				num = (short)1183036301;
				switch (num2 == num)
				{
				}
				num = (short)210239489;
				if (num != 0)
				{
				}
				num = (short)1440088064;
				short num3 = num;
				num = (short)1292369920;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.UIValue;
			}
			set
			{
				short num = (short)528869134;
				short num2 = num;
				num = (short)1320675086;
				switch (num2 == num)
				{
				}
				num = (short)199557120;
				if (num != 0)
				{
				}
				num = (short)1130496000;
				short num3 = num;
				num = (short)1448083457;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.UIValue = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x001B0BE8 File Offset: 0x001AEDE8
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerGeneralSecondaryTxFrequencyMHz_A12902
		{
			get
			{
				short num = (short)1291545215;
				short num2 = num;
				num = (short)988834431;
				switch (num2 == num)
				{
				}
				num = (short)945684480;
				if (num != 0)
				{
				}
				num = (short)782958592;
				short num3 = num;
				num = (short)884736001;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x001B0C98 File Offset: 0x001AEE98
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x001B0D4C File Offset: 0x001AEF4C
		internal int TrkPerGeneralSecondaryTxFrequencyMHz_A12902Min
		{
			get
			{
				short num = (short)1639352181;
				short num2 = num;
				num = (short)1261340533;
				switch (num2 == num)
				{
				}
				num = (short)1253638144;
				if (num != 0)
				{
				}
				num = (short)1168375808;
				short num3 = num;
				num = (short)952762369;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Min;
			}
			set
			{
				short num = (short)845405070;
				short num2 = num;
				num = (short)137026446;
				switch (num2 == num)
				{
				}
				num = (short)1386741761;
				if (num != 0)
				{
				}
				num = (short)2011496448;
				short num3 = num;
				num = (short)1383399424;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Min = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x001B0E00 File Offset: 0x001AF000
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x001B0EB4 File Offset: 0x001AF0B4
		internal int TrkPerGeneralSecondaryTxFrequencyMHz_A12902Max
		{
			get
			{
				short num = (short)1904934913;
				if (num != 0)
				{
				}
				num = (short)1907846712;
				short num2 = num;
				num = (short)2146463288;
				switch (num2 == num)
				{
				}
				num = (short)607911936;
				short num3 = num;
				num = (short)1592918016;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Max;
			}
			set
			{
				short num = (short)1597612230;
				short num2 = num;
				num = (short)230924486;
				switch (num2 == num)
				{
				}
				num = (short)985464833;
				if (num != 0)
				{
				}
				num = (short)808321024;
				short num3 = num;
				num = (short)729874432;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Max = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x001B0F68 File Offset: 0x001AF168
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x001B101C File Offset: 0x001AF21C
		internal int TrkPerGeneralSecondaryTxFrequencyMHz_A12902Step
		{
			get
			{
				short num = (short)814733996;
				short num2 = num;
				num = (short)1197136556;
				switch (num2 == num)
				{
				}
				num = (short)1953300480;
				if (num != 0)
				{
				}
				num = (short)910819328;
				short num3 = num;
				num = (short)1116667905;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.StepSize;
			}
			set
			{
				short num = (short)634948668;
				short num2 = num;
				num = (short)1404931132;
				switch (num2 == num)
				{
				}
				num = (short)107675649;
				if (num != 0)
				{
				}
				num = (short)1843200000;
				short num3 = num;
				num = (short)1870069760;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.StepSize = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x001B10D0 File Offset: 0x001AF2D0
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x001B1184 File Offset: 0x001AF384
		public bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_Applicable
		{
			get
			{
				short num = (short)514698956;
				short num2 = num;
				num = (short)1819586252;
				switch (num2 == num)
				{
				}
				num = (short)1129906176;
				if (num != 0)
				{
				}
				num = (short)1985806336;
				short num3 = num;
				num = (short)806289409;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Applicable;
			}
			set
			{
				short num = (short)233815022;
				short num2 = num;
				num = (short)1915796462;
				switch (num2 == num)
				{
				}
				num = (short)1567883265;
				if (num != 0)
				{
				}
				num = (short)1588396032;
				short num3 = num;
				num = (short)805306368;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Applicable = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x001B123C File Offset: 0x001AF43C
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x001B12F4 File Offset: 0x001AF4F4
		public bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_Valid
		{
			get
			{
				short num = (short)1837627236;
				short num2 = num;
				num = (short)308082532;
				switch (num2 == num)
				{
				}
				num = (short)582287360;
				if (num != 0)
				{
				}
				num = (short)1757085696;
				short num3 = num;
				num = (short)1673854977;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Valid;
			}
			set
			{
				short num = (short)77834139;
				short num2 = num;
				num = (short)119515035;
				switch (num2 == num)
				{
				}
				num = (short)1888157697;
				if (num != 0)
				{
				}
				num = (short)1198915584;
				short num3 = num;
				num = (short)1600520192;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Valid = value;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x001B13AC File Offset: 0x001AF5AC
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x001B1460 File Offset: 0x001AF660
		public bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_Visible
		{
			get
			{
				short num = (short)670236672;
				short num2 = num;
				num = (short)792854529;
				if (num != 0)
				{
				}
				num = (short)1640372826;
				short num3 = num;
				num = (short)368908890;
				switch (num3 == num)
				{
				}
				num = (short)1501495296;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Visible;
			}
			set
			{
				short num = (short)754843648;
				short num2 = num;
				num = (short)1894973441;
				if (num != 0)
				{
				}
				num = (short)59006847;
				short num3 = num;
				num = (short)1793286015;
				switch (num3 == num)
				{
				}
				num = (short)709754880;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Visible = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x001B1518 File Offset: 0x001AF718
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x001B15CC File Offset: 0x001AF7CC
		public bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_Editable
		{
			get
			{
				short num = (short)452788224;
				short num2 = num;
				num = (short)89219442;
				short num3 = num;
				num = (short)95838578;
				switch (num3 == num)
				{
				}
				num = (short)725483520;
				if (num != 0)
				{
				}
				num = (short)359661569;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Editable;
			}
			set
			{
				short num = (short)16908288;
				short num2 = num;
				num = (short)1157757705;
				short num3 = num;
				num = (short)166132489;
				switch (num3 == num)
				{
				}
				num = (short)689307648;
				if (num != 0)
				{
				}
				num = (short)266600449;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.Editable = value;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x001B1680 File Offset: 0x001AF880
		internal string TrkPerGeneralSecondaryTxFrequencyMHz_A12902_UILabel
		{
			get
			{
				short num = (short)1693384704;
				short num2 = num;
				num = (short)1872933615;
				short num3 = num;
				num = (short)810726127;
				switch (num3 == num)
				{
				}
				num = (short)1249574913;
				if (num != 0)
				{
				}
				num = (short)2096955392;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.UIName;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x001B1738 File Offset: 0x001AF938
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x001B17EC File Offset: 0x001AF9EC
		internal bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_HiddenStatic
		{
			get
			{
				short num = (short)590872576;
				short num2 = num;
				num = (short)1281678754;
				short num3 = num;
				num = (short)697884066;
				switch (num3 == num)
				{
				}
				num = (short)741801985;
				if (num != 0)
				{
				}
				num = (short)204800000;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.HiddenStatic;
			}
			set
			{
				short num = (short)1449066496;
				short num2 = num;
				num = (short)127981065;
				short num3 = num;
				num = (short)924309001;
				switch (num3 == num)
				{
				}
				num = (short)1816395777;
				if (num != 0)
				{
				}
				num = (short)1229193216;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.HiddenStatic = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x001B18A4 File Offset: 0x001AFAA4
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x001B1958 File Offset: 0x001AFB58
		internal bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_HiddenDynamic
		{
			get
			{
				short num = (short)1086586880;
				short num2 = num;
				num = (short)1379074003;
				short num3 = num;
				num = (short)52363219;
				switch (num3 == num)
				{
				}
				num = (short)698089473;
				if (num != 0)
				{
				}
				num = (short)236912640;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.HiddenDynamic;
			}
			set
			{
				short num = (short)1390608384;
				short num2 = num;
				num = (short)407211716;
				short num3 = num;
				num = (short)885296836;
				switch (num3 == num)
				{
				}
				num = (short)1779892225;
				if (num != 0)
				{
				}
				num = (short)1043333120;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryTxFrequencyMHz_A12902.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x001B1A10 File Offset: 0x001AFC10
		public bool TrkPerGeneralSecondaryTxFrequencyMHz_A12902_HasDiffs
		{
			get
			{
				short num = (short)1135280128;
				short num2 = num;
				num = (short)246895121;
				short num3 = num;
				num = (short)623399441;
				switch (num3 == num)
				{
				}
				num = (short)1151926273;
				if (num != 0)
				{
				}
				num = (short)300417024;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryTxFrequencyMHz_A12902._HasDiffs;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x001B1AC8 File Offset: 0x001AFCC8
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x001B1B7C File Offset: 0x001AFD7C
		public bool TrkPerGeneralSecondaryFailsoft_A19991Value
		{
			get
			{
				short num = (short)1623130112;
				short num2 = num;
				num = (short)1645430273;
				short num3 = num;
				num = (short)1057310209;
				switch (num3 == num)
				{
				}
				num = (short)1252458497;
				if (num != 0)
				{
				}
				num = (short)1146683392;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Value;
			}
			set
			{
				short num = (short)971702272;
				short num2 = num;
				num = (short)1236002435;
				short num3 = num;
				num = (short)878962307;
				switch (num3 == num)
				{
				}
				num = (short)1279066113;
				if (num != 0)
				{
				}
				num = (short)1828913152;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Value = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x001B1C30 File Offset: 0x001AFE30
		public global::AcpBusinessLayer.AcpField<bool> TrkPerGeneralSecondaryFailsoft_A19991
		{
			get
			{
				short num = (short)642056192;
				short num2 = num;
				num = (short)118129314;
				short num3 = num;
				num = (short)1536000674;
				switch (num3 == num)
				{
				}
				num = (short)20119553;
				if (num != 0)
				{
				}
				num = (short)465043456;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x001B1CDC File Offset: 0x001AFEDC
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x001B1D8C File Offset: 0x001AFF8C
		public bool TrkPerGeneralSecondaryFailsoft_A19991_UIValue
		{
			get
			{
				short num = (short)724631552;
				short num2 = num;
				num = (short)348520449;
				if (num != 0)
				{
				}
				num = (short)618872261;
				short num3 = num;
				num = (short)1956068805;
				switch (num3 == num)
				{
				}
				num = (short)814284800;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Value;
			}
			set
			{
				short num = (short)126222336;
				short num2 = num;
				num = (short)254665482;
				short num3 = num;
				num = (short)950199050;
				switch (num3 == num)
				{
				}
				num = (short)1490878465;
				if (num != 0)
				{
				}
				num = (short)114294784;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Value = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x001B1E44 File Offset: 0x001B0044
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x001B1EFC File Offset: 0x001B00FC
		public bool TrkPerGeneralSecondaryFailsoft_A19991_Applicable
		{
			get
			{
				short num = (short)1758068736;
				short num2 = num;
				num = (short)2000824811;
				short num3 = num;
				num = (short)877799915;
				switch (num3 == num)
				{
				}
				num = (short)1806172161;
				if (num != 0)
				{
				}
				num = (short)795410432;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Applicable;
			}
			set
			{
				short num = (short)1092354048;
				short num2 = num;
				num = (short)595748683;
				short num3 = num;
				num = (short)1881892683;
				switch (num3 == num)
				{
				}
				num = (short)130482177;
				if (num != 0)
				{
				}
				num = (short)581500928;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Applicable = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x001B1FB0 File Offset: 0x001B01B0
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x001B2064 File Offset: 0x001B0264
		public bool TrkPerGeneralSecondaryFailsoft_A19991_Valid
		{
			get
			{
				short num = (short)784465920;
				short num2 = num;
				num = (short)734286570;
				short num3 = num;
				num = (short)552293098;
				switch (num3 == num)
				{
				}
				num = (short)946143233;
				if (num != 0)
				{
				}
				num = (short)1682309120;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Valid;
			}
			set
			{
				short num = (short)1051262976;
				short num2 = num;
				num = (short)2019258296;
				short num3 = num;
				num = (short)904163256;
				switch (num3 == num)
				{
				}
				num = (short)890568704;
				if (num != 0)
				{
				}
				num = (short)190578689;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Valid = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x001B211C File Offset: 0x001B031C
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x001B21D4 File Offset: 0x001B03D4
		public bool TrkPerGeneralSecondaryFailsoft_A19991_Visible
		{
			get
			{
				short num = (short)1925447680;
				short num2 = num;
				num = (short)109754894;
				short num3 = num;
				num = (short)1400158734;
				switch (num3 == num)
				{
				}
				num = (short)2076114945;
				if (num != 0)
				{
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Visible;
			}
			set
			{
				short num = (short)751960064;
				short num2 = num;
				num = (short)326201464;
				short num3 = num;
				num = (short)5009528;
				switch (num3 == num)
				{
				}
				num = (short)1886912513;
				if (num != 0)
				{
				}
				num = (short)566493184;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Visible = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x001B2288 File Offset: 0x001B0488
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x001B233C File Offset: 0x001B053C
		public bool TrkPerGeneralSecondaryFailsoft_A19991_Editable
		{
			get
			{
				short num = (short)116523008;
				short num2 = num;
				num = (short)1035350564;
				short num3 = num;
				num = (short)1560883748;
				switch (num3 == num)
				{
				}
				num = (short)968294401;
				if (num != 0)
				{
				}
				num = (short)1235288064;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.Editable;
			}
			set
			{
				short num = (short)2109669376;
				short num2 = num;
				num = (short)1161737627;
				short num3 = num;
				num = (short)1106294171;
				switch (num3 == num)
				{
				}
				num = (short)1971912705;
				if (num != 0)
				{
				}
				num = (short)39059456;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.Editable = value;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x001B23F4 File Offset: 0x001B05F4
		internal string TrkPerGeneralSecondaryFailsoft_A19991_UILabel
		{
			get
			{
				short num = (short)1442447360;
				short num2 = num;
				num = (short)2062046396;
				short num3 = num;
				num = (short)1276335292;
				switch (num3 == num)
				{
				}
				num = (short)475856897;
				if (num != 0)
				{
				}
				num = (short)1650262016;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.UIName;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x001B24A8 File Offset: 0x001B06A8
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x001B255C File Offset: 0x001B075C
		internal bool TrkPerGeneralSecondaryFailsoft_A19991_HiddenStatic
		{
			get
			{
				short num = (short)1718550528;
				short num2 = num;
				num = (short)1297945883;
				short num3 = num;
				num = (short)931140891;
				switch (num3 == num)
				{
				}
				num = (short)1276182528;
				if (num != 0)
				{
				}
				num = (short)19005441;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.HiddenStatic;
			}
			set
			{
				short num = (short)218038272;
				short num2 = num;
				num = (short)1768164272;
				short num3 = num;
				num = (short)68553648;
				switch (num3 == num)
				{
				}
				num = (short)1478819841;
				if (num != 0)
				{
				}
				num = (short)1111293952;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.HiddenStatic = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x001B2614 File Offset: 0x001B0814
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x001B26C4 File Offset: 0x001B08C4
		internal bool TrkPerGeneralSecondaryFailsoft_A19991_HiddenDynamic
		{
			get
			{
				short num = (short)1064501248;
				short num2 = num;
				num = (short)389915073;
				short num3 = num;
				num = (short)2105516481;
				switch (num3 == num)
				{
				}
				num = (short)1288110081;
				if (num != 0)
				{
				}
				num = (short)158597120;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991.HiddenDynamic;
			}
			set
			{
				short num = (short)706740224;
				short num2 = num;
				num = (short)2063244584;
				short num3 = num;
				num = (short)1506516264;
				switch (num3 == num)
				{
				}
				num = (short)1485176833;
				if (num != 0)
				{
				}
				num = (short)1263271936;
				if (num != 0)
				{
				}
				this.trkPerGeneralSecondaryFailsoft_A19991.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x001B2778 File Offset: 0x001B0978
		public bool TrkPerGeneralSecondaryFailsoft_A19991_HasDiffs
		{
			get
			{
				short num = (short)2014511104;
				short num2 = num;
				num = (short)664138334;
				short num3 = num;
				num = (short)49869406;
				switch (num3 == num)
				{
				}
				num = (short)1206976513;
				if (num != 0)
				{
				}
				num = (short)1036648448;
				if (num != 0)
				{
				}
				return this.trkPerGeneralSecondaryFailsoft_A19991._HasDiffs;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x001B282C File Offset: 0x001B0A2C
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x001B28E4 File Offset: 0x001B0AE4
		public int TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980Value
		{
			get
			{
				short num = (short)1354104832;
				short num2 = num;
				num = (short)414777345;
				if (num != 0)
				{
				}
				num = (short)2030463727;
				short num3 = num;
				num = (short)981822191;
				switch (num3 == num)
				{
				}
				num = (short)1501036544;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Value;
			}
			set
			{
				short num = (short)354025472;
				short num2 = num;
				num = (short)452132865;
				if (num != 0)
				{
				}
				num = (short)1195612231;
				short num3 = num;
				num = (short)1041733703;
				switch (num3 == num)
				{
				}
				num = (short)1632174080;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Value = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x001B299C File Offset: 0x001B0B9C
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x001B2A50 File Offset: 0x001B0C50
		public string TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_UIValue
		{
			get
			{
				short num = (short)519307264;
				short num2 = num;
				num = (short)1475534999;
				short num3 = num;
				num = (short)145875095;
				switch (num3 == num)
				{
				}
				num = (short)1868365825;
				if (num != 0)
				{
				}
				num = (short)1236729856;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.UIValue;
			}
			set
			{
				short num = (short)814284800;
				short num2 = num;
				num = (short)570184406;
				short num3 = num;
				num = (short)1845842646;
				switch (num3 == num)
				{
				}
				num = (short)308281345;
				if (num != 0)
				{
				}
				num = (short)1657995264;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.UIValue = value;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x001B2B08 File Offset: 0x001B0D08
		public global::AcpBusinessLayer.AcpRecRefField TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980
		{
			get
			{
				short num = (short)1667891200;
				short num2 = num;
				num = (short)57836634;
				short num3 = num;
				num = (short)356287578;
				switch (num3 == num)
				{
				}
				num = (short)1329201153;
				if (num != 0)
				{
				}
				num = (short)780271616;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x001B2BB8 File Offset: 0x001B0DB8
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x001B2C6C File Offset: 0x001B0E6C
		public bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_Applicable
		{
			get
			{
				short num = (short)638582784;
				short num2 = num;
				num = (short)2096674127;
				short num3 = num;
				num = (short)823965007;
				switch (num3 == num)
				{
				}
				num = (short)132055040;
				if (num != 0)
				{
				}
				num = (short)314441729;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Applicable;
			}
			set
			{
				short num = (short)264896512;
				short num2 = num;
				num = (short)1199816340;
				short num3 = num;
				num = (short)1040891540;
				switch (num3 == num)
				{
				}
				num = (short)641925120;
				if (num != 0)
				{
				}
				num = (short)1038548993;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Applicable = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x001B2D24 File Offset: 0x001B0F24
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x001B2DDC File Offset: 0x001B0FDC
		public bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_Valid
		{
			get
			{
				short num = (short)839254016;
				short num2 = num;
				num = (short)730359519;
				short num3 = num;
				num = (short)1869702879;
				switch (num3 == num)
				{
				}
				num = (short)614268929;
				if (num != 0)
				{
				}
				num = (short)2090795008;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Valid;
			}
			set
			{
				short num = (short)1566900224;
				short num2 = num;
				num = (short)1546816286;
				short num3 = num;
				num = (short)1327205150;
				switch (num3 == num)
				{
				}
				num = (short)762249217;
				if (num != 0)
				{
				}
				num = (short)442630144;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Valid = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x001B2E90 File Offset: 0x001B1090
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x001B2F44 File Offset: 0x001B1144
		public bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_Visible
		{
			get
			{
				short num = (short)1842741248;
				short num2 = num;
				num = (short)1484445680;
				short num3 = num;
				num = (short)1571805168;
				switch (num3 == num)
				{
				}
				num = (short)798752769;
				if (num != 0)
				{
				}
				num = (short)374734848;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Visible;
			}
			set
			{
				short num = (short)1954545664;
				short num2 = num;
				num = (short)988637830;
				short num3 = num;
				num = (short)912681606;
				switch (num3 == num)
				{
				}
				num = (short)541851649;
				if (num != 0)
				{
				}
				num = (short)2083782656;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Visible = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x001B2FF8 File Offset: 0x001B11F8
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x001B30AC File Offset: 0x001B12AC
		public bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_Editable
		{
			get
			{
				short num = (short)1169358848;
				short num2 = num;
				num = (short)1693879123;
				short num3 = num;
				num = (short)1026198355;
				switch (num3 == num)
				{
				}
				num = (short)1449000961;
				if (num != 0)
				{
				}
				num = (short)387252224;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Editable;
			}
			set
			{
				short num = (short)275709952;
				short num2 = num;
				num = (short)2123042486;
				short num3 = num;
				num = (short)1122438838;
				switch (num3 == num)
				{
				}
				num = (short)229310465;
				if (num != 0)
				{
				}
				num = (short)1216413696;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.Editable = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x001B3160 File Offset: 0x001B1360
		internal string TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_UILabel
		{
			get
			{
				short num = (short)1583546368;
				short num2 = num;
				num = (short)2139684865;
				if (num != 0)
				{
				}
				num = (short)1161176265;
				short num3 = num;
				num = (short)702555337;
				switch (num3 == num)
				{
				}
				num = (short)299696128;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.UIName;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x001B3214 File Offset: 0x001B1414
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x001B32C8 File Offset: 0x001B14C8
		internal bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_HiddenStatic
		{
			get
			{
				short num = (short)228261888;
				short num2 = num;
				num = (short)715953404;
				short num3 = num;
				num = (short)28546300;
				switch (num3 == num)
				{
				}
				num = (short)279838721;
				if (num != 0)
				{
				}
				num = (short)585957376;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.HiddenStatic;
			}
			set
			{
				short num = (short)468385792;
				short num2 = num;
				num = (short)1014104065;
				if (num != 0)
				{
				}
				num = (short)689054846;
				short num3 = num;
				num = (short)607069310;
				switch (num3 == num)
				{
				}
				num = (short)1267990528;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.HiddenStatic = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x001B3380 File Offset: 0x001B1580
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x001B3434 File Offset: 0x001B1634
		internal bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_HiddenDynamic
		{
			get
			{
				short num = (short)1406533632;
				short num2 = num;
				num = (short)181903601;
				short num3 = num;
				num = (short)672440561;
				switch (num3 == num)
				{
				}
				num = (short)1068302337;
				if (num != 0)
				{
				}
				num = (short)522584064;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.HiddenDynamic;
			}
			set
			{
				short num = (short)1335951360;
				short num2 = num;
				num = (short)205412587;
				short num3 = num;
				num = (short)1508071659;
				switch (num3 == num)
				{
				}
				num = (short)830865408;
				if (num != 0)
				{
				}
				num = (short)1751121921;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x001B34EC File Offset: 0x001B16EC
		public bool TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980_HasDiffs
		{
			get
			{
				short num = (short)1213267968;
				short num2 = num;
				num = (short)2120941569;
				if (num != 0)
				{
				}
				num = (short)724119666;
				short num3 = num;
				num = (short)1789997170;
				switch (num3 == num)
				{
				}
				num = (short)823394304;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980._HasDiffs;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x001B35A4 File Offset: 0x001B17A4
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x001B3658 File Offset: 0x001B1858
		public int TrkPerGeneralProtocolType_A8767Value
		{
			get
			{
				short num = (short)431357952;
				short num2 = num;
				num = (short)1622785468;
				short num3 = num;
				num = (short)81247676;
				switch (num3 == num)
				{
				}
				num = (short)681115649;
				if (num != 0)
				{
				}
				num = (short)1720385536;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.Value;
			}
			set
			{
				short num = (short)214499328;
				short num2 = num;
				num = (short)995864769;
				short num3 = num;
				num = (short)607367361;
				switch (num3 == num)
				{
				}
				num = (short)193003521;
				if (num != 0)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.Value = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x001B370C File Offset: 0x001B190C
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x001B37C0 File Offset: 0x001B19C0
		public string TrkPerGeneralProtocolType_A8767_UIValue
		{
			get
			{
				short num = (short)2027028480;
				short num2 = num;
				num = (short)715728112;
				short num3 = num;
				num = (short)1148069104;
				switch (num3 == num)
				{
				}
				num = (short)807796736;
				if (num != 0)
				{
				}
				num = (short)1525153793;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.UIValue;
			}
			set
			{
				short num = (short)2110193664;
				short num2 = num;
				num = (short)134831074;
				short num3 = num;
				num = (short)1436179426;
				switch (num3 == num)
				{
				}
				num = (short)188416001;
				if (num != 0)
				{
				}
				num = (short)1948844032;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.UIValue = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x001B3874 File Offset: 0x001B1A74
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralProtocolType_A8767
		{
			get
			{
				short num = (short)1706360832;
				short num2 = num;
				num = (short)1014058037;
				short num3 = num;
				num = (short)430263349;
				switch (num3 == num)
				{
				}
				num = (short)1961558017;
				if (num != 0)
				{
				}
				num = (short)751763456;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x001B3920 File Offset: 0x001B1B20
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x001B39D8 File Offset: 0x001B1BD8
		public bool TrkPerGeneralProtocolType_A8767_Applicable
		{
			get
			{
				short num = (short)1022951424;
				short num2 = num;
				num = (short)355286358;
				short num3 = num;
				num = (short)1772764502;
				switch (num3 == num)
				{
				}
				num = (short)1837039617;
				if (num != 0)
				{
				}
				num = (short)1968570368;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.Applicable;
			}
			set
			{
				short num = (short)314376192;
				short num2 = num;
				num = (short)1464809250;
				short num3 = num;
				num = (short)317863714;
				switch (num3 == num)
				{
				}
				num = (short)1201537024;
				if (num != 0)
				{
				}
				num = (short)1119748097;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.Applicable = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x001B3A8C File Offset: 0x001B1C8C
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x001B3B40 File Offset: 0x001B1D40
		public bool TrkPerGeneralProtocolType_A8767_Valid
		{
			get
			{
				short num = (short)1270087680;
				short num2 = num;
				num = (short)697165878;
				short num3 = num;
				num = (short)1541531702;
				switch (num3 == num)
				{
				}
				num = (short)1818755073;
				if (num != 0)
				{
				}
				num = (short)1563492352;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.Valid;
			}
			set
			{
				short num = (short)657391616;
				short num2 = num;
				num = (short)63285732;
				short num3 = num;
				num = (short)1489807844;
				switch (num3 == num)
				{
				}
				num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)1088749568;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.Valid = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x001B3BF8 File Offset: 0x001B1DF8
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x001B3CAC File Offset: 0x001B1EAC
		public bool TrkPerGeneralProtocolType_A8767_Visible
		{
			get
			{
				short num = (short)1662386176;
				short num2 = num;
				num = (short)1035865269;
				short num3 = num;
				num = (short)1948650677;
				switch (num3 == num)
				{
				}
				num = (short)1700790273;
				if (num != 0)
				{
				}
				num = (short)1433862144;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.Visible;
			}
			set
			{
				short num = (short)111345664;
				short num2 = num;
				num = (short)1550771693;
				short num3 = num;
				num = (short)228255213;
				switch (num3 == num)
				{
				}
				num = (short)1579352064;
				if (num != 0)
				{
				}
				num = (short)1608384513;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.Visible = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x001B3D64 File Offset: 0x001B1F64
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x001B3E18 File Offset: 0x001B2018
		public bool TrkPerGeneralProtocolType_A8767_Editable
		{
			get
			{
				short num = (short)658810686;
				short num2 = num;
				num = (short)62302014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2006974464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1276510209;
				if (num != 0)
				{
				}
				num = (short)1259405312;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.Editable;
			}
			set
			{
				short num = (short)1630092257;
				short num2 = num;
				num = (short)310655969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35782656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319684609;
				if (num != 0)
				{
				}
				num = (short)1596063744;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.Editable = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x001B3ECC File Offset: 0x001B20CC
		internal string TrkPerGeneralProtocolType_A8767_UILabel
		{
			get
			{
				short num = (short)112081121;
				short num2 = num;
				num = (short)1095448801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1222770688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711734784;
				if (num != 0)
				{
				}
				num = (short)2056912897;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.UIName;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x001B3F80 File Offset: 0x001B2180
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x001B4034 File Offset: 0x001B2234
		internal bool TrkPerGeneralProtocolType_A8767_HiddenStatic
		{
			get
			{
				short num = (short)944442741;
				short num2 = num;
				num = (short)2111573365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)553123840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080571392;
				if (num != 0)
				{
				}
				num = (short)174850049;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.HiddenStatic;
			}
			set
			{
				short num = (short)1931879380;
				short num2 = num;
				num = (short)1473061844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432537600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1320878081;
				if (num != 0)
				{
				}
				num = (short)1516240896;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.HiddenStatic = value;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x001B40EC File Offset: 0x001B22EC
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x001B41A0 File Offset: 0x001B23A0
		internal bool TrkPerGeneralProtocolType_A8767_HiddenDynamic
		{
			get
			{
				short num = (short)256948682;
				short num2 = num;
				num = (short)1317452234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812529152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433403393;
				if (num != 0)
				{
				}
				num = (short)1750532096;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767.HiddenDynamic;
			}
			set
			{
				short num = (short)1812096362;
				short num2 = num;
				num = (short)336881002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1580597248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139591681;
				if (num != 0)
				{
				}
				num = (short)1244594176;
				if (num != 0)
				{
				}
				this.trkPerGeneralProtocolType_A8767.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x001B4254 File Offset: 0x001B2454
		public bool TrkPerGeneralProtocolType_A8767_HasDiffs
		{
			get
			{
				short num = (short)1434817453;
				short num2 = num;
				num = (short)1830065069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776273920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852702721;
				if (num != 0)
				{
				}
				num = (short)329580544;
				if (num != 0)
				{
				}
				return this.trkPerGeneralProtocolType_A8767._HasDiffs;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x001B4308 File Offset: 0x001B2508
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x001B43BC File Offset: 0x001B25BC
		public int TrkPerGeneralDisableTransmitMode_A41742Value
		{
			get
			{
				short num = (short)717684296;
				short num2 = num;
				num = (short)1678245448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970457088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575143936;
				if (num != 0)
				{
				}
				num = (short)1319239681;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.Value;
			}
			set
			{
				short num = (short)1363476481;
				if (num != 0)
				{
				}
				num = (short)886177792;
				short num2 = num;
				num = (short)473401461;
				short num3 = num;
				num = (short)514099317;
				switch (num3 == num)
				{
				}
				num = (short)562495488;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.Value = value;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x001B4474 File Offset: 0x001B2674
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x001B4528 File Offset: 0x001B2728
		public string TrkPerGeneralDisableTransmitMode_A41742_UIValue
		{
			get
			{
				short num = (short)387130486;
				short num2 = num;
				num = (short)170534006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100822016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052194305;
				if (num != 0)
				{
				}
				num = (short)1200881664;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.UIValue;
			}
			set
			{
				short num = (short)383042316;
				short num2 = num;
				num = (short)876135180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931804672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)292749313;
				if (num != 0)
				{
				}
				num = (short)628621312;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.UIValue = value;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x001B45E0 File Offset: 0x001B27E0
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralDisableTransmitMode_A41742
		{
			get
			{
				short num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)1168965632;
				short num2 = num;
				num = (short)1797119021;
				short num3 = num;
				num = (short)1222958125;
				switch (num3 == num)
				{
				}
				num = (short)362414080;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x001B468C File Offset: 0x001B288C
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x001B4740 File Offset: 0x001B2940
		public bool TrkPerGeneralDisableTransmitMode_A41742_Applicable
		{
			get
			{
				short num = (short)439025665;
				if (num != 0)
				{
				}
				num = (short)231342080;
				short num2 = num;
				num = (short)363100921;
				short num3 = num;
				num = (short)1003977465;
				switch (num3 == num)
				{
				}
				num = (short)1897463808;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.Applicable;
			}
			set
			{
				short num = (short)32638258;
				short num2 = num;
				num = (short)768935218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398341632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)103743489;
				if (num != 0)
				{
				}
				num = (short)583073792;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.Applicable = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x001B47F4 File Offset: 0x001B29F4
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x001B48A8 File Offset: 0x001B2AA8
		public bool TrkPerGeneralDisableTransmitMode_A41742_Valid
		{
			get
			{
				short num = (short)180432571;
				short num2 = num;
				num = (short)928132795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108658688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1456144384;
				if (num != 0)
				{
				}
				num = (short)1619918849;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.Valid;
			}
			set
			{
				short num = (short)1517052354;
				short num2 = num;
				num = (short)652304834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364590592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131858432;
				if (num != 0)
				{
				}
				num = (short)581566465;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.Valid = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x001B495C File Offset: 0x001B2B5C
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x001B4A10 File Offset: 0x001B2C10
		public bool TrkPerGeneralDisableTransmitMode_A41742_Visible
		{
			get
			{
				short num = (short)818744666;
				short num2 = num;
				num = (short)596774234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862781440;
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
				num = (short)833093632;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.Visible;
			}
			set
			{
				short num = (short)2100830366;
				short num2 = num;
				num = (short)360325278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332150272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109341696;
				if (num != 0)
				{
				}
				num = (short)1388969985;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.Visible = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x001B4AC8 File Offset: 0x001B2CC8
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x001B4B7C File Offset: 0x001B2D7C
		public bool TrkPerGeneralDisableTransmitMode_A41742_Editable
		{
			get
			{
				short num = (short)928395326;
				short num2 = num;
				num = (short)1136406590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1416560640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018363905;
				if (num != 0)
				{
				}
				num = (short)1989804032;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.Editable;
			}
			set
			{
				short num = (short)476345386;
				short num2 = num;
				num = (short)1622897706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900202496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2047016961;
				if (num != 0)
				{
				}
				num = (short)1270415360;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.Editable = value;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x001B4C30 File Offset: 0x001B2E30
		internal string TrkPerGeneralDisableTransmitMode_A41742_UILabel
		{
			get
			{
				short num = (short)1622520517;
				short num2 = num;
				num = (short)2144318149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954990592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720240641;
				if (num != 0)
				{
				}
				num = (short)2059862016;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.UIName;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x001B4CE0 File Offset: 0x001B2EE0
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x001B4D98 File Offset: 0x001B2F98
		internal bool TrkPerGeneralDisableTransmitMode_A41742_HiddenStatic
		{
			get
			{
				short num = (short)1403547982;
				short num2 = num;
				num = (short)360673614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1739194368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)433717249;
				if (num != 0)
				{
				}
				num = (short)580583424;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.HiddenStatic;
			}
			set
			{
				short num = (short)1468784491;
				short num2 = num;
				num = (short)1124523883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2019819520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054881281;
				if (num != 0)
				{
				}
				num = (short)589889536;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.HiddenStatic = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x001B4E4C File Offset: 0x001B304C
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x001B4F00 File Offset: 0x001B3100
		internal bool TrkPerGeneralDisableTransmitMode_A41742_HiddenDynamic
		{
			get
			{
				short num = (short)1538933149;
				short num2 = num;
				num = (short)1724334493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2028011520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)965804033;
				if (num != 0)
				{
				}
				num = (short)1222311936;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742.HiddenDynamic;
			}
			set
			{
				short num = (short)2044806654;
				short num2 = num;
				num = (short)37176830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1405157376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714801153;
				if (num != 0)
				{
				}
				num = (short)1351221248;
				if (num != 0)
				{
				}
				this.trkPerGeneralDisableTransmitMode_A41742.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x001B4FB8 File Offset: 0x001B31B8
		public bool TrkPerGeneralDisableTransmitMode_A41742_HasDiffs
		{
			get
			{
				short num = (short)1027226724;
				short num2 = num;
				num = (short)1118977124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1896415232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)425852928;
				if (num != 0)
				{
				}
				num = (short)1678639105;
				if (num != 0)
				{
				}
				return this.trkPerGeneralDisableTransmitMode_A41742._HasDiffs;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x001B506C File Offset: 0x001B326C
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x001B5120 File Offset: 0x001B3320
		public int TrkPerFeaturesDVRSProf_A41796Value
		{
			get
			{
				short num = (short)471307361;
				short num2 = num;
				num = (short)1318229089;
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
				num = (short)1050607616;
				if (num != 0)
				{
				}
				num = (short)1816920065;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.Value;
			}
			set
			{
				short num = (short)689771903;
				short num2 = num;
				num = (short)1155208575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205796864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451543040;
				if (num != 0)
				{
				}
				num = (short)1885995009;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.Value = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x001B51D8 File Offset: 0x001B33D8
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x001B528C File Offset: 0x001B348C
		public string TrkPerFeaturesDVRSProf_A41796_UIValue
		{
			get
			{
				short num = (short)1216236855;
				short num2 = num;
				num = (short)982469943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)535756800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)118751233;
				if (num != 0)
				{
				}
				num = (short)944701440;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.UIValue;
			}
			set
			{
				short num = (short)1132907800;
				short num2 = num;
				num = (short)1661586712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)103022592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2137522177;
				if (num != 0)
				{
				}
				num = (short)1662386176;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.UIValue = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x001B5344 File Offset: 0x001B3544
		public global::AcpBusinessLayer.AcpRecRefField TrkPerFeaturesDVRSProf_A41796
		{
			get
			{
				short num = (short)74650800;
				short num2 = num;
				num = (short)2082084016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588264960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1644494849;
				if (num != 0)
				{
				}
				num = (short)459341824;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x001B53F4 File Offset: 0x001B35F4
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x001B54AC File Offset: 0x001B36AC
		public bool TrkPerFeaturesDVRSProf_A41796_Applicable
		{
			get
			{
				short num = (short)728848937;
				short num2 = num;
				num = (short)1311988265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586626560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1802567681;
				if (num != 0)
				{
				}
				num = (short)1389559808;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.Applicable;
			}
			set
			{
				short num = (short)366585136;
				short num2 = num;
				num = (short)2085397808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1782906880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219821569;
				if (num != 0)
				{
				}
				num = (short)856227840;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.Applicable = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x001B5560 File Offset: 0x001B3760
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x001B5614 File Offset: 0x001B3814
		public bool TrkPerFeaturesDVRSProf_A41796_Valid
		{
			get
			{
				short num = (short)309723137;
				if (num != 0)
				{
				}
				num = (short)1187119104;
				short num2 = num;
				num = (short)2104766642;
				short num3 = num;
				num = (short)1792815282;
				switch (num3 == num)
				{
				}
				num = (short)806486016;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.Valid;
			}
			set
			{
				short num = (short)1715416741;
				short num2 = num;
				num = (short)2141925029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607139328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078460417;
				if (num != 0)
				{
				}
				num = (short)501153792;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.Valid = value;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x001B56C8 File Offset: 0x001B38C8
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x001B5780 File Offset: 0x001B3980
		public bool TrkPerFeaturesDVRSProf_A41796_Visible
		{
			get
			{
				short num = (short)813847153;
				short num2 = num;
				num = (short)644764273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785462784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1921187840;
				if (num != 0)
				{
				}
				num = (short)1821114369;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.Visible;
			}
			set
			{
				short num = (short)889979200;
				short num2 = num;
				num = (short)1201209664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236795392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)799604737;
				if (num != 0)
				{
				}
				num = (short)1884880896;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.Visible = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x001B5834 File Offset: 0x001B3A34
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x001B58E8 File Offset: 0x001B3AE8
		public bool TrkPerFeaturesDVRSProf_A41796_Editable
		{
			get
			{
				short num = (short)1874133236;
				short num2 = num;
				num = (short)1301217524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856897024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)85000192;
				if (num != 0)
				{
				}
				num = (short)1034354689;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.Editable;
			}
			set
			{
				short num = (short)310837249;
				if (num != 0)
				{
				}
				num = (short)79101952;
				short num2 = num;
				num = (short)1054858034;
				short num3 = num;
				num = (short)886889266;
				switch (num3 == num)
				{
				}
				num = (short)2029256704;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.Editable = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x001B599C File Offset: 0x001B3B9C
		internal string TrkPerFeaturesDVRSProf_A41796_UILabel
		{
			get
			{
				short num = (short)1487716115;
				short num2 = num;
				num = (short)743685907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1993015296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595853313;
				if (num != 0)
				{
				}
				num = (short)1072168960;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.UIName;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x001B5A54 File Offset: 0x001B3C54
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x001B5B0C File Offset: 0x001B3D0C
		internal bool TrkPerFeaturesDVRSProf_A41796_HiddenStatic
		{
			get
			{
				short num = (short)1216020481;
				if (num != 0)
				{
				}
				num = (short)1856700416;
				short num2 = num;
				num = (short)1563168067;
				short num3 = num;
				num = (short)2130120003;
				switch (num3 == num)
				{
				}
				num = (short)533331968;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.HiddenStatic;
			}
			set
			{
				short num = (short)538991266;
				short num2 = num;
				num = (short)1328896674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483393536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057554433;
				if (num != 0)
				{
				}
				num = (short)1305673728;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.HiddenStatic = value;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x001B5BC0 File Offset: 0x001B3DC0
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x001B5C78 File Offset: 0x001B3E78
		internal bool TrkPerFeaturesDVRSProf_A41796_HiddenDynamic
		{
			get
			{
				short num = (short)2089199612;
				short num2 = num;
				num = (short)1588111356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26935296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)972685312;
				if (num != 0)
				{
				}
				num = (short)611778561;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796.HiddenDynamic;
			}
			set
			{
				short num = (short)523213126;
				short num2 = num;
				num = (short)111384902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319815680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675886592;
				if (num != 0)
				{
				}
				num = (short)1954414593;
				if (num != 0)
				{
				}
				this.trkPerFeaturesDVRSProf_A41796.HiddenDynamic = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x001B5D30 File Offset: 0x001B3F30
		public bool TrkPerFeaturesDVRSProf_A41796_HasDiffs
		{
			get
			{
				short num = (short)1398800385;
				if (num != 0)
				{
				}
				num = (short)1376649216;
				short num2 = num;
				num = (short)1005448628;
				short num3 = num;
				num = (short)849210804;
				switch (num3 == num)
				{
				}
				num = (short)343080960;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesDVRSProf_A41796._HasDiffs;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x001B5DE4 File Offset: 0x001B3FE4
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x001B5E98 File Offset: 0x001B4098
		public int TrkPerGeneralEmergencyRevertType_A41914Value
		{
			get
			{
				short num = (short)1987201219;
				short num2 = num;
				num = (short)939542723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988886528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239403009;
				if (num != 0)
				{
				}
				num = (short)2088763392;
				if (num != 0)
				{
				}
				return this.trkPerGeneralEmergencyRevertType_A41914.Value;
			}
			set
			{
				short num = (short)974192641;
				if (num != 0)
				{
				}
				num = (short)958005248;
				short num2 = num;
				num = (short)793174248;
				short num3 = num;
				num = (short)319611112;
				switch (num3 == num)
				{
				}
				num = (short)1019609088;
				if (num != 0)
				{
				}
				this.trkPerGeneralEmergencyRevertType_A41914.Value = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x001B5F50 File Offset: 0x001B4150
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x001B6004 File Offset: 0x001B4204
		public string TrkPerGeneralEmergencyRevertType_A41914_UIValue
		{
			get
			{
				short num = (short)1150699267;
				short num2 = num;
				num = (short)1548896003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269432320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				num = (short)679608320;
				if (num != 0)
				{
				}
				return this.trkPerGeneralEmergencyRevertType_A41914.UIValue;
			}
			set
			{
				short num = (short)1082003099;
				short num2 = num;
				num = (short)759762587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)125239296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)646250496;
				if (num != 0)
				{
				}
				num = (short)16973825;
				if (num != 0)
				{
				}
				this.trkPerGeneralEmergencyRevertType_A41914.UIValue = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x001B60B8 File Offset: 0x001B42B8
		public global::AcpBusinessLayer.AcpListField TrkPerGeneralEmergencyRevertType_A41914
		{
			get
			{
				short num = (short)1544355841;
				if (num != 0)
				{
				}
				num = (short)558355808;
				short num2 = num;
				num = (short)488363360;
				switch (num2 == num)
				{
				}
				num = (short)325189632;
				if (num != 0)
				{
				}
				num = (short)1832648704;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x001B6168 File Offset: 0x001B4368
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x001B6220 File Offset: 0x001B4420
		public bool TrkPerGeneralEmergencyRevertType_A41914_Applicable
		{
			get
			{
				short num = (short)1475861211;
				short num2 = num;
				num = (short)869849819;
				switch (num2 == num)
				{
				}
				num = (short)1300430848;
				if (num != 0)
				{
				}
				num = (short)691142657;
				if (num != 0)
				{
				}
				num = (short)362807296;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.Applicable;
			}
			set
			{
				short num = (short)1639876933;
				short num2 = num;
				num = (short)51218757;
				switch (num2 == num)
				{
				}
				num = (short)690225153;
				if (num != 0)
				{
				}
				num = (short)2099511296;
				if (num != 0)
				{
				}
				num = (short)143065088;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.Applicable = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x001B62D4 File Offset: 0x001B44D4
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x001B6388 File Offset: 0x001B4588
		public bool TrkPerGeneralEmergencyRevertType_A41914_Valid
		{
			get
			{
				short num = (short)1686363254;
				short num2 = num;
				num = (short)1751637110;
				switch (num2 == num)
				{
				}
				num = (short)104333313;
				if (num != 0)
				{
				}
				num = (short)7471104;
				if (num != 0)
				{
				}
				num = (short)1744764928;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.Valid;
			}
			set
			{
				short num = (short)2018275779;
				short num2 = num;
				num = (short)1237676483;
				switch (num2 == num)
				{
				}
				num = (short)1820786689;
				if (num != 0)
				{
				}
				num = (short)56426496;
				if (num != 0)
				{
				}
				num = (short)774242304;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.Valid = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x001B643C File Offset: 0x001B463C
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x001B64F0 File Offset: 0x001B46F0
		public bool TrkPerGeneralEmergencyRevertType_A41914_Visible
		{
			get
			{
				short num = (short)284161145;
				short num2 = num;
				num = (short)1642067065;
				switch (num2 == num)
				{
				}
				num = (short)1789394945;
				if (num != 0)
				{
				}
				num = (short)2057109504;
				if (num != 0)
				{
				}
				num = (short)1533214720;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.Visible;
			}
			set
			{
				short num = (short)690749441;
				if (num != 0)
				{
				}
				num = (short)1516554898;
				short num2 = num;
				num = (short)1472580242;
				switch (num2 == num)
				{
				}
				num = (short)327352320;
				if (num != 0)
				{
				}
				num = (short)1279262720;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.Visible = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x001B65A8 File Offset: 0x001B47A8
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x001B665C File Offset: 0x001B485C
		public bool TrkPerGeneralEmergencyRevertType_A41914_Editable
		{
			get
			{
				short num = (short)753817974;
				short num2 = num;
				num = (short)1402558838;
				switch (num2 == num)
				{
				}
				num = (short)669974528;
				if (num != 0)
				{
				}
				num = (short)890109953;
				if (num != 0)
				{
				}
				num = (short)382992384;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.Editable;
			}
			set
			{
				short num = (short)409324504;
				short num2 = num;
				num = (short)1338624984;
				switch (num2 == num)
				{
				}
				num = (short)2028077057;
				if (num != 0)
				{
				}
				num = (short)1794703360;
				if (num != 0)
				{
				}
				num = (short)2024275968;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.Editable = value;
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x001B6710 File Offset: 0x001B4910
		internal string TrkPerGeneralEmergencyRevertType_A41914_UILabel
		{
			get
			{
				short num = (short)32890325;
				short num2 = num;
				num = (short)1903746517;
				switch (num2 == num)
				{
				}
				num = (short)773128192;
				if (num != 0)
				{
				}
				num = (short)1844248577;
				if (num != 0)
				{
				}
				num = (short)1483997184;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.UIName;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x001B67C4 File Offset: 0x001B49C4
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x001B6878 File Offset: 0x001B4A78
		internal bool TrkPerGeneralEmergencyRevertType_A41914_HiddenStatic
		{
			get
			{
				short num = (short)40009061;
				short num2 = num;
				num = (short)1135312229;
				switch (num2 == num)
				{
				}
				num = (short)1608056833;
				if (num != 0)
				{
				}
				num = (short)1688076288;
				if (num != 0)
				{
				}
				num = (short)1577385984;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.HiddenStatic;
			}
			set
			{
				short num = (short)42782984;
				short num2 = num;
				num = (short)1078776072;
				switch (num2 == num)
				{
				}
				num = (short)224198657;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				if (num != 0)
				{
				}
				num = (short)372113408;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.HiddenStatic = value;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x001B6930 File Offset: 0x001B4B30
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x001B69E8 File Offset: 0x001B4BE8
		internal bool TrkPerGeneralEmergencyRevertType_A41914_HiddenDynamic
		{
			get
			{
				short num = (short)1943502381;
				short num2 = num;
				num = (short)830963245;
				switch (num2 == num)
				{
				}
				num = (short)79298561;
				if (num != 0)
				{
				}
				num = (short)435879936;
				if (num != 0)
				{
				}
				num = (short)779091968;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914.HiddenDynamic;
			}
			set
			{
				short num = (short)257143057;
				short num2 = num;
				num = (short)485929233;
				switch (num2 == num)
				{
				}
				num = (short)1817772033;
				if (num != 0)
				{
				}
				num = (short)1856372736;
				if (num != 0)
				{
				}
				num = (short)2033451008;
				short num3 = num;
				this.trkPerGeneralEmergencyRevertType_A41914.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x001B6A9C File Offset: 0x001B4C9C
		public bool TrkPerGeneralEmergencyRevertType_A41914_HasDiffs
		{
			get
			{
				short num = (short)1414511453;
				short num2 = num;
				num = (short)1842592605;
				switch (num2 == num)
				{
				}
				num = (short)565313536;
				if (num != 0)
				{
				}
				num = (short)1945174017;
				if (num != 0)
				{
				}
				num = (short)542375936;
				short num3 = num;
				return this.trkPerGeneralEmergencyRevertType_A41914._HasDiffs;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x001B6B50 File Offset: 0x001B4D50
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x001B6C04 File Offset: 0x001B4E04
		public int TrkPerGeneralRevertZone_A41916Value
		{
			get
			{
				short num = (short)1084952518;
				short num2 = num;
				num = (short)330174406;
				switch (num2 == num)
				{
				}
				num = (short)751370241;
				if (num != 0)
				{
				}
				num = (short)593821696;
				if (num != 0)
				{
				}
				num = (short)280166400;
				short num3 = num;
				return this.trkPerGeneralRevertZone_A41916.Value;
			}
			set
			{
				short num = (short)1434320896;
				short num2 = num;
				num = (short)1668638946;
				short num3 = num;
				num = (short)1980590306;
				switch (num3 == num)
				{
				}
				num = (short)855834625;
				if (num != 0)
				{
				}
				num = (short)1555496960;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.Value = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x001B6CBC File Offset: 0x001B4EBC
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x001B6D70 File Offset: 0x001B4F70
		public string TrkPerGeneralRevertZone_A41916_UIValue
		{
			get
			{
				short num = (short)416481280;
				short num2 = num;
				num = (short)1016084220;
				short num3 = num;
				num = (short)1501574908;
				switch (num3 == num)
				{
				}
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)1673461760;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.UIValue;
			}
			set
			{
				short num = (short)187629568;
				short num2 = num;
				num = (short)1384906753;
				if (num != 0)
				{
				}
				num = (short)2012498503;
				short num3 = num;
				num = (short)43534919;
				switch (num3 == num)
				{
				}
				num = (short)554106880;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.UIValue = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x001B6E24 File Offset: 0x001B5024
		public global::AcpBusinessLayer.AcpRecRefField TrkPerGeneralRevertZone_A41916
		{
			get
			{
				short num = (short)1485438976;
				short num2 = num;
				num = (short)805175297;
				if (num != 0)
				{
				}
				num = (short)1723979404;
				short num3 = num;
				num = (short)90625676;
				switch (num3 == num)
				{
				}
				num = (short)219414528;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x001B6ED4 File Offset: 0x001B50D4
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x001B6F8C File Offset: 0x001B518C
		public bool TrkPerGeneralRevertZone_A41916_Applicable
		{
			get
			{
				short num = (short)1024524288;
				short num2 = num;
				num = (short)1968561225;
				short num3 = num;
				num = (short)188210249;
				switch (num3 == num)
				{
				}
				num = (short)987627520;
				if (num != 0)
				{
				}
				num = (short)639238145;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.Applicable;
			}
			set
			{
				short num = (short)1703018496;
				short num2 = num;
				num = (short)1138909313;
				short num3 = num;
				num = (short)273506433;
				switch (num3 == num)
				{
				}
				num = (short)69140481;
				if (num != 0)
				{
				}
				num = (short)2004615168;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.Applicable = value;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x001B7040 File Offset: 0x001B5240
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x001B70F4 File Offset: 0x001B52F4
		public bool TrkPerGeneralRevertZone_A41916_Valid
		{
			get
			{
				short num = (short)1715666944;
				short num2 = num;
				num = (short)4394085;
				short num3 = num;
				num = (short)1895828581;
				switch (num3 == num)
				{
				}
				num = (short)1468858368;
				if (num != 0)
				{
				}
				num = (short)435159041;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.Valid;
			}
			set
			{
				short num = (short)1820655616;
				short num2 = num;
				num = (short)1640711532;
				short num3 = num;
				num = (short)906642796;
				switch (num3 == num)
				{
				}
				num = (short)1241448448;
				if (num != 0)
				{
				}
				num = (short)424017921;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.Valid = value;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x001B71AC File Offset: 0x001B53AC
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x001B7260 File Offset: 0x001B5460
		public bool TrkPerGeneralRevertZone_A41916_Visible
		{
			get
			{
				short num = (short)812974080;
				short num2 = num;
				num = (short)1020293418;
				short num3 = num;
				num = (short)1271689514;
				switch (num3 == num)
				{
				}
				num = (short)667877377;
				if (num != 0)
				{
				}
				num = (short)946667520;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.Visible;
			}
			set
			{
				short num = (short)1066795008;
				short num2 = num;
				num = (short)1522296550;
				short num3 = num;
				num = (short)1790142182;
				switch (num3 == num)
				{
				}
				num = (short)713424897;
				if (num != 0)
				{
				}
				num = (short)1627455488;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.Visible = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x001B7314 File Offset: 0x001B5514
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x001B73CC File Offset: 0x001B55CC
		public bool TrkPerGeneralRevertZone_A41916_Editable
		{
			get
			{
				short num = (short)128778240;
				short num2 = num;
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)1754093602;
				short num3 = num;
				num = (short)64772130;
				switch (num3 == num)
				{
				}
				num = (short)1715470336;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.Editable;
			}
			set
			{
				short num = (short)976551936;
				short num2 = num;
				num = (short)640665937;
				short num3 = num;
				num = (short)82430289;
				switch (num3 == num)
				{
				}
				num = (short)15204353;
				if (num != 0)
				{
				}
				num = (short)854851584;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.Editable = value;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x001B7480 File Offset: 0x001B5680
		internal string TrkPerGeneralRevertZone_A41916_UILabel
		{
			get
			{
				short num = (short)1367932928;
				short num2 = num;
				num = (short)1732462117;
				short num3 = num;
				num = (short)2032092709;
				switch (num3 == num)
				{
				}
				num = (short)232194049;
				if (num != 0)
				{
				}
				num = (short)869466112;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.UIName;
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x001B7534 File Offset: 0x001B5734
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x001B75E8 File Offset: 0x001B57E8
		internal bool TrkPerGeneralRevertZone_A41916_HiddenStatic
		{
			get
			{
				short num = (short)108265472;
				short num2 = num;
				num = (short)362501096;
				short num3 = num;
				num = (short)355881960;
				switch (num3 == num)
				{
				}
				num = (short)321912833;
				if (num != 0)
				{
				}
				num = (short)1014300672;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.HiddenStatic;
			}
			set
			{
				short num = (short)1980039168;
				short num2 = num;
				num = (short)769588539;
				short num3 = num;
				num = (short)967179579;
				switch (num3 == num)
				{
				}
				num = (short)956628992;
				if (num != 0)
				{
				}
				num = (short)1815871489;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.HiddenStatic = value;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x001B76A0 File Offset: 0x001B58A0
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x001B7754 File Offset: 0x001B5954
		internal bool TrkPerGeneralRevertZone_A41916_HiddenDynamic
		{
			get
			{
				short num = (short)707526656;
				short num2 = num;
				num = (short)582376316;
				short num3 = num;
				num = (short)1366514556;
				switch (num3 == num)
				{
				}
				num = (short)98369537;
				if (num != 0)
				{
				}
				num = (short)500039680;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916.HiddenDynamic;
			}
			set
			{
				short num = (short)1875968000;
				short num2 = num;
				num = (short)1142771038;
				short num3 = num;
				num = (short)54283614;
				switch (num3 == num)
				{
				}
				num = (short)1864630273;
				if (num != 0)
				{
				}
				num = (short)539426816;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertZone_A41916.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x001B780C File Offset: 0x001B5A0C
		public bool TrkPerGeneralRevertZone_A41916_HasDiffs
		{
			get
			{
				short num = (short)1054015488;
				short num2 = num;
				num = (short)339738625;
				if (num != 0)
				{
				}
				num = (short)549521124;
				short num3 = num;
				num = (short)2361060;
				switch (num3 == num)
				{
				}
				num = (short)607780864;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertZone_A41916._HasDiffs;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x001B78C0 File Offset: 0x001B5AC0
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x001B7974 File Offset: 0x001B5B74
		public int TrkPerGeneralRevertChannel_A41917Value
		{
			get
			{
				short num = (short)697106432;
				short num2 = num;
				num = (short)620132310;
				short num3 = num;
				num = (short)35289046;
				switch (num3 == num)
				{
				}
				num = (short)1241710593;
				if (num != 0)
				{
				}
				num = (short)2070478848;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.Value;
			}
			set
			{
				short num = (short)217841664;
				short num2 = num;
				num = (short)858059324;
				short num3 = num;
				num = (short)1834676796;
				switch (num3 == num)
				{
				}
				num = (short)102498305;
				if (num != 0)
				{
				}
				num = (short)229900288;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.Value = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x001B7A2C File Offset: 0x001B5C2C
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x001B7AE0 File Offset: 0x001B5CE0
		public string TrkPerGeneralRevertChannel_A41917_UIValue
		{
			get
			{
				short num = (short)135004160;
				short num2 = num;
				num = (short)640387946;
				short num3 = num;
				num = (short)586058602;
				switch (num3 == num)
				{
				}
				num = (short)199819265;
				if (num != 0)
				{
				}
				num = (short)1070727168;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.UIValue;
			}
			set
			{
				short num = (short)1132134400;
				short num2 = num;
				num = (short)261258675;
				short num3 = num;
				num = (short)521829811;
				switch (num3 == num)
				{
				}
				num = (short)852164609;
				if (num != 0)
				{
				}
				num = (short)1781858304;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.UIValue = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x001B7B98 File Offset: 0x001B5D98
		public global::AcpBusinessLayer.AcpRecRefField TrkPerGeneralRevertChannel_A41917
		{
			get
			{
				short num = (short)1711538176;
				short num2 = num;
				num = (short)1457861485;
				short num3 = num;
				num = (short)1257321325;
				switch (num3 == num)
				{
				}
				num = (short)472252417;
				if (num != 0)
				{
				}
				num = (short)1902313472;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x001B7C48 File Offset: 0x001B5E48
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x001B7D00 File Offset: 0x001B5F00
		public bool TrkPerGeneralRevertChannel_A41917_Applicable
		{
			get
			{
				short num = (short)1342636032;
				short num2 = num;
				num = (short)246692920;
				short num3 = num;
				num = (short)1493711928;
				switch (num3 == num)
				{
				}
				num = (short)1133051904;
				if (num != 0)
				{
				}
				num = (short)479199233;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.Applicable;
			}
			set
			{
				short num = (short)1082523648;
				short num2 = num;
				num = (short)1232928769;
				if (num != 0)
				{
				}
				num = (short)394814482;
				short num3 = num;
				num = (short)588866578;
				switch (num3 == num)
				{
				}
				num = (short)982319104;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.Applicable = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x001B7DB8 File Offset: 0x001B5FB8
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x001B7E6C File Offset: 0x001B606C
		public bool TrkPerGeneralRevertChannel_A41917_Valid
		{
			get
			{
				short num = (short)964886528;
				short num2 = num;
				num = (short)1799092475;
				short num3 = num;
				num = (short)1593964795;
				switch (num3 == num)
				{
				}
				num = (short)1218510848;
				if (num != 0)
				{
				}
				num = (short)1813184513;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.Valid;
			}
			set
			{
				short num = (short)884998144;
				short num2 = num;
				num = (short)1164705793;
				if (num != 0)
				{
				}
				num = (short)177026408;
				short num3 = num;
				num = (short)1674327400;
				switch (num3 == num)
				{
				}
				num = (short)987430912;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.Valid = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x001B7F1C File Offset: 0x001B611C
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x001B7FD0 File Offset: 0x001B61D0
		public bool TrkPerGeneralRevertChannel_A41917_Visible
		{
			get
			{
				short num = (short)1224933376;
				short num2 = num;
				num = (short)18424607;
				short num3 = num;
				num = (short)1497047839;
				switch (num3 == num)
				{
				}
				num = (short)1060896768;
				if (num != 0)
				{
				}
				num = (short)507641857;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.Visible;
			}
			set
			{
				short num = (short)1629159424;
				short num2 = num;
				num = (short)66215372;
				short num3 = num;
				num = (short)1384144332;
				switch (num3 == num)
				{
				}
				num = (short)6619137;
				if (num != 0)
				{
				}
				num = (short)2117599232;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.Visible = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x001B8084 File Offset: 0x001B6284
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x001B813C File Offset: 0x001B633C
		public bool TrkPerGeneralRevertChannel_A41917_Editable
		{
			get
			{
				short num = (short)1998913536;
				short num2 = num;
				num = (short)1743449611;
				short num3 = num;
				num = (short)1750789643;
				switch (num3 == num)
				{
				}
				num = (short)899350529;
				if (num != 0)
				{
				}
				num = (short)1181351936;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.Editable;
			}
			set
			{
				short num = (short)1658519552;
				short num2 = num;
				num = (short)713920277;
				short num3 = num;
				num = (short)1682870037;
				switch (num3 == num)
				{
				}
				num = (short)1175191552;
				if (num != 0)
				{
				}
				num = (short)491323393;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.Editable = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x001B81F4 File Offset: 0x001B63F4
		internal string TrkPerGeneralRevertChannel_A41917_UILabel
		{
			get
			{
				short num = (short)1408958464;
				short num2 = num;
				num = (short)1916993537;
				if (num != 0)
				{
				}
				num = (short)1937156497;
				short num3 = num;
				num = (short)451520913;
				switch (num3 == num)
				{
				}
				num = (short)170262528;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.UIName;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x001B82AC File Offset: 0x001B64AC
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x001B8364 File Offset: 0x001B6564
		internal bool TrkPerGeneralRevertChannel_A41917_HiddenStatic
		{
			get
			{
				short num = (short)1355939840;
				short num2 = num;
				num = (short)1418652831;
				short num3 = num;
				num = (short)1196354719;
				switch (num3 == num)
				{
				}
				num = (short)1847197697;
				if (num != 0)
				{
				}
				num = (short)882442240;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.HiddenStatic;
			}
			set
			{
				short num = (short)239403008;
				short num2 = num;
				num = (short)1410697599;
				short num3 = num;
				num = (short)1141016959;
				switch (num3 == num)
				{
				}
				num = (short)619970561;
				if (num != 0)
				{
				}
				num = (short)1734344704;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.HiddenStatic = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x001B841C File Offset: 0x001B661C
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x001B84D4 File Offset: 0x001B66D4
		internal bool TrkPerGeneralRevertChannel_A41917_HiddenDynamic
		{
			get
			{
				short num = (short)301400064;
				short num2 = num;
				num = (short)1729594578;
				short num3 = num;
				num = (short)1959691474;
				switch (num3 == num)
				{
				}
				num = (short)916389889;
				if (num != 0)
				{
				}
				num = (short)374800384;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917.HiddenDynamic;
			}
			set
			{
				short num = (short)1201078272;
				short num2 = num;
				num = (short)1735922119;
				short num3 = num;
				num = (short)1396445639;
				switch (num3 == num)
				{
				}
				num = (short)2055471105;
				if (num != 0)
				{
				}
				num = (short)291373056;
				if (num != 0)
				{
				}
				this.trkPerGeneralRevertChannel_A41917.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x001B858C File Offset: 0x001B678C
		public bool TrkPerGeneralRevertChannel_A41917_HasDiffs
		{
			get
			{
				short num = (short)1081933824;
				short num2 = num;
				num = (short)1605369857;
				if (num != 0)
				{
				}
				num = (short)1765316256;
				short num3 = num;
				num = (short)1852675744;
				switch (num3 == num)
				{
				}
				num = (short)1057030144;
				if (num != 0)
				{
				}
				return this.trkPerGeneralRevertChannel_A41917._HasDiffs;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x001B8640 File Offset: 0x001B6840
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x001B86F4 File Offset: 0x001B68F4
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782Value
		{
			get
			{
				short num = (short)1122828288;
				short num2 = num;
				num = (short)133001334;
				short num3 = num;
				num = (short)374108278;
				switch (num3 == num)
				{
				}
				num = (short)64028673;
				if (num != 0)
				{
				}
				num = (short)1311768576;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Value;
			}
			set
			{
				short num = (short)994377728;
				short num2 = num;
				num = (short)1642213969;
				short num3 = num;
				num = (short)1233465937;
				switch (num3 == num)
				{
				}
				num = (short)2004221952;
				if (num != 0)
				{
				}
				num = (short)204996609;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Value = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x001B87A8 File Offset: 0x001B69A8
		public global::AcpBusinessLayer.AcpField<bool> TrkPerGeneralStrictFailsoftbyTalkgroup_43782
		{
			get
			{
				short num = (short)1250260191;
				short num2 = num;
				num = (short)178877663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195245568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767768064;
				if (num != 0)
				{
				}
				num = (short)1394475009;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x001B8854 File Offset: 0x001B6A54
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x001B890C File Offset: 0x001B6B0C
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_UIValue
		{
			get
			{
				short num = (short)1416285814;
				short num2 = num;
				num = (short)1523961462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)215810048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668153345;
				if (num != 0)
				{
				}
				num = (short)746192896;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Value;
			}
			set
			{
				short num = (short)175391704;
				short num2 = num;
				num = (short)878199768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)518717440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34537472;
				if (num != 0)
				{
				}
				num = (short)147783681;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Value = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x001B89C4 File Offset: 0x001B6BC4
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x001B8A78 File Offset: 0x001B6C78
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_Applicable
		{
			get
			{
				short num = (short)1242458956;
				short num2 = num;
				num = (short)167734092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561184768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746468864;
				if (num != 0)
				{
				}
				num = (short)2002780161;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Applicable;
			}
			set
			{
				short num = (short)419302108;
				short num2 = num;
				num = (short)1864043228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317928960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1339817985;
				if (num != 0)
				{
				}
				num = (short)1643053056;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Applicable = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x001B8B2C File Offset: 0x001B6D2C
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x001B8BE4 File Offset: 0x001B6DE4
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_Valid
		{
			get
			{
				short num = (short)952605782;
				short num2 = num;
				num = (short)1989123158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1596391424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647954433;
				if (num != 0)
				{
				}
				num = (short)532938752;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Valid;
			}
			set
			{
				short num = (short)1820787008;
				short num2 = num;
				num = (short)2133262656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034027008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2011955200;
				if (num != 0)
				{
				}
				num = (short)1185742849;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Valid = value;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x001B8C9C File Offset: 0x001B6E9C
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x001B8D50 File Offset: 0x001B6F50
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_Visible
		{
			get
			{
				short num = (short)1538069328;
				short num2 = num;
				num = (short)527242064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933494784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837287937;
				if (num != 0)
				{
				}
				num = (short)1327759360;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Visible;
			}
			set
			{
				short num = (short)1705801712;
				short num2 = num;
				num = (short)904165360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786970112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140640257;
				if (num != 0)
				{
				}
				num = (short)1913716736;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Visible = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x001B8E04 File Offset: 0x001B7004
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x001B8EB8 File Offset: 0x001B70B8
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_Editable
		{
			get
			{
				short num = (short)2141249690;
				short num2 = num;
				num = (short)1853350042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231276544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075642369;
				if (num != 0)
				{
				}
				num = (short)1382481920;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Editable;
			}
			set
			{
				short num = (short)2100306409;
				short num2 = num;
				num = (short)780345833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881786880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999699968;
				if (num != 0)
				{
				}
				num = (short)2096693249;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.Editable = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x001B8F70 File Offset: 0x001B7170
		internal string TrkPerGeneralStrictFailsoftbyTalkgroup_43782_UILabel
		{
			get
			{
				short num = (short)37192617;
				short num2 = num;
				num = (short)824345513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)766967808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152698880;
				if (num != 0)
				{
				}
				num = (short)2042232833;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.UIName;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x001B9024 File Offset: 0x001B7224
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x001B90D8 File Offset: 0x001B72D8
		internal bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_HiddenStatic
		{
			get
			{
				short num = (short)1624667977;
				short num2 = num;
				num = (short)1970108233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851064320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039532033;
				if (num != 0)
				{
				}
				num = (short)1003290624;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.HiddenStatic;
			}
			set
			{
				short num = (short)1926641978;
				short num2 = num;
				num = (short)1543387450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2049703936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847249409;
				if (num != 0)
				{
				}
				num = (short)801636352;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.HiddenStatic = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x001B918C File Offset: 0x001B738C
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x001B9240 File Offset: 0x001B7440
		internal bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_HiddenDynamic
		{
			get
			{
				short num = (short)306563360;
				short num2 = num;
				num = (short)1365887264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)934608896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17432577;
				if (num != 0)
				{
				}
				num = (short)672792576;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.HiddenDynamic;
			}
			set
			{
				short num = (short)151618651;
				short num2 = num;
				num = (short)120816731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047855104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468727296;
				if (num != 0)
				{
				}
				num = (short)2102722561;
				if (num != 0)
				{
				}
				this.trkPerGeneralStrictFailsoftbyTalkgroup_43782.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x001B92F8 File Offset: 0x001B74F8
		public bool TrkPerGeneralStrictFailsoftbyTalkgroup_43782_HasDiffs
		{
			get
			{
				short num = (short)499510062;
				short num2 = num;
				num = (short)498854702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275133952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1682833409;
				if (num != 0)
				{
				}
				num = (short)1047461888;
				if (num != 0)
				{
				}
				return this.trkPerGeneralStrictFailsoftbyTalkgroup_43782._HasDiffs;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x001B93AC File Offset: 0x001B75AC
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x001B9460 File Offset: 0x001B7660
		public bool TrkPerGeneralBroadbandProtectionValue
		{
			get
			{
				short num = (short)1300300686;
				short num2 = num;
				num = (short)1129382798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1022689280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467206144;
				if (num != 0)
				{
				}
				num = (short)2132017153;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Value;
			}
			set
			{
				short num = (short)196021774;
				short num2 = num;
				num = (short)2119896590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027801088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)254017537;
				if (num != 0)
				{
				}
				num = (short)1466368000;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Value = value;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x001B9518 File Offset: 0x001B7718
		public global::AcpBusinessLayer.AcpField<bool> TrkPerGeneralBroadbandProtection
		{
			get
			{
				short num = (short)931164794;
				short num2 = num;
				num = (short)54751866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976500224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258815488;
				if (num != 0)
				{
				}
				num = (short)180486145;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x001B95C4 File Offset: 0x001B77C4
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x001B967C File Offset: 0x001B787C
		public bool TrkPerGeneralBroadbandProtection_UIValue
		{
			get
			{
				short num = (short)1774969678;
				short num2 = num;
				num = (short)538633038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1857552384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498663424;
				if (num != 0)
				{
				}
				num = (short)663683073;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Value;
			}
			set
			{
				short num = (short)783559449;
				short num2 = num;
				num = (short)1001270041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59703296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252261889;
				if (num != 0)
				{
				}
				num = (short)1371930624;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Value = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x001B9730 File Offset: 0x001B7930
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x001B97E4 File Offset: 0x001B79E4
		public bool TrkPerGeneralBroadbandProtection_Applicable
		{
			get
			{
				short num = (short)1566763334;
				short num2 = num;
				num = (short)72083782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208863232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1615527936;
				if (num != 0)
				{
				}
				num = (short)1017577473;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Applicable;
			}
			set
			{
				short num = (short)1165748127;
				short num2 = num;
				num = (short)1153034143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2024669184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65339393;
				if (num != 0)
				{
				}
				num = (short)1378811904;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Applicable = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x001B989C File Offset: 0x001B7A9C
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x001B9954 File Offset: 0x001B7B54
		public bool TrkPerGeneralBroadbandProtection_Valid
		{
			get
			{
				short num = (short)1648788255;
				short num2 = num;
				num = (short)468550431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14548992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)792330241;
				if (num != 0)
				{
				}
				num = (short)1402863616;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Valid;
			}
			set
			{
				short num = (short)600496080;
				short num2 = num;
				num = (short)1503975376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2115567616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878786048;
				if (num != 0)
				{
				}
				num = (short)688586753;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Valid = value;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x001B9A08 File Offset: 0x001B7C08
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x001B9ABC File Offset: 0x001B7CBC
		public bool TrkPerGeneralBroadbandProtection_Visible
		{
			get
			{
				short num = (short)1044557457;
				short num2 = num;
				num = (short)1797762705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)729677824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193345024;
				if (num != 0)
				{
				}
				num = (short)1412038657;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Visible;
			}
			set
			{
				short num = (short)1512374273;
				if (num != 0)
				{
				}
				num = (short)1894907904;
				short num2 = num;
				num = (short)1763564721;
				short num3 = num;
				num = (short)628022449;
				switch (num3 == num)
				{
				}
				num = (short)1050804224;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Visible = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x001B9B70 File Offset: 0x001B7D70
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x001B9C24 File Offset: 0x001B7E24
		public bool TrkPerGeneralBroadbandProtection_Editable
		{
			get
			{
				short num = (short)1892155393;
				if (num != 0)
				{
				}
				num = (short)873070592;
				short num2 = num;
				num = (short)1823259813;
				short num3 = num;
				num = (short)1491057829;
				switch (num3 == num)
				{
				}
				num = (short)217317376;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.Editable;
			}
			set
			{
				short num = (short)309972757;
				short num2 = num;
				num = (short)1131597589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)223936512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44892160;
				if (num != 0)
				{
				}
				num = (short)1710948353;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.Editable = value;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x001B9CD8 File Offset: 0x001B7ED8
		internal string TrkPerGeneralBroadbandProtection_UILabel
		{
			get
			{
				short num = (short)1407052659;
				short num2 = num;
				num = (short)343075699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573898752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)600113153;
				if (num != 0)
				{
				}
				num = (short)250216448;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.UIName;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x001B9D8C File Offset: 0x001B7F8C
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x001B9E40 File Offset: 0x001B8040
		internal bool TrkPerGeneralBroadbandProtection_HiddenStatic
		{
			get
			{
				short num = (short)1100793051;
				short num2 = num;
				num = (short)1085195483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675610624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028666881;
				if (num != 0)
				{
				}
				num = (short)1797783552;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.HiddenStatic;
			}
			set
			{
				short num = (short)984734952;
				short num2 = num;
				num = (short)248634600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402456576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1393295361;
				if (num != 0)
				{
				}
				num = (short)1510342656;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.HiddenStatic = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x001B9EF8 File Offset: 0x001B80F8
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x001B9FB0 File Offset: 0x001B81B0
		internal bool TrkPerGeneralBroadbandProtection_HiddenDynamic
		{
			get
			{
				short num = (short)12189697;
				if (num != 0)
				{
				}
				num = (short)1077542912;
				short num2 = num;
				num = (short)931845266;
				short num3 = num;
				num = (short)1953092754;
				switch (num3 == num)
				{
				}
				num = (short)422182912;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection.HiddenDynamic;
			}
			set
			{
				short num = (short)367788791;
				short num2 = num;
				num = (short)1236992759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125791232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549074433;
				if (num != 0)
				{
				}
				num = (short)820772864;
				if (num != 0)
				{
				}
				this.trkPerGeneralBroadbandProtection.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x001BA064 File Offset: 0x001B8264
		public bool TrkPerGeneralBroadbandProtection_HasDiffs
		{
			get
			{
				short num = (short)1495278534;
				short num2 = num;
				num = (short)150938566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608960512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209321985;
				if (num != 0)
				{
				}
				num = (short)344719360;
				if (num != 0)
				{
				}
				return this.trkPerGeneralBroadbandProtection._HasDiffs;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x001BA11C File Offset: 0x001B831C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)6899601;
				short num2 = num;
				num = (short)1513899921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913520128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972371456;
				if (num != 0)
				{
				}
				num = (short)1346240513;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x001BA1DC File Offset: 0x001B83DC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1326060134;
				short num2 = num;
				num = (short)428479078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673658368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148649473;
				if (num != 0)
				{
				}
				num = (short)1427308544;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x001BA2A0 File Offset: 0x001B84A0
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1657415825;
				short num2 = num;
				num = (short)795158673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314783232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625882625;
				if (num != 0)
				{
				}
				num = (short)435552256;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x001BA35C File Offset: 0x001B855C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)890937314;
				short num2 = num;
				num = (short)1144561634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858062848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)466878465;
				if (num != 0)
				{
				}
				num = (short)1505886208;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x001BA41C File Offset: 0x001B861C
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
					num2 = (short)1780154370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)907149312;
						short num3 = num2;
						num2 = (short)1623785475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_163;
				case 4:
				{
					num2 = (short)2012348417;
					if (num2 != 0)
					{
					}
					num2 = (short)1646682833;
					short num4 = num2;
					num2 = (short)1229611729;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num2 = (short)1900806144;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)203161600;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_24;
				IL_163:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)665976833;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1968570372;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x001BA594 File Offset: 0x001B8794
		private void b()
		{
			short num = (short)59368875;
			short num2 = num;
			num = (short)992601515;
			switch (num2 == num)
			{
			default:
			{
				num = (short)134021120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1592786944;
			if (num != 0)
			{
			}
			num = (short)1494024193;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x001BA644 File Offset: 0x001B8844
		private void a()
		{
			short num = (short)1826733431;
			short num2 = num;
			num = (short)711900535;
			switch (num2 == num)
			{
			default:
			{
				num = (short)220659712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)867696641;
			if (num != 0)
			{
			}
			num = (short)893059072;
			if (num != 0)
			{
			}
			base.PropertyChanging += global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General.OnTrkPerSysName_PropertyChangingHandle;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x001BA700 File Offset: 0x001B8900
		public static void OnTrkPerSysName_PropertyChangingHandle(object section, global::System.ComponentModel.PropertyChangingEventArgs label)
		{
			int a_ = 8;
			short num = (short)1058471936;
			switch (num)
			{
			default:
			{
				num = (short)432078859;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					switch (num2)
					{
					case 0:
						if (channelAssignmentListInner != null)
						{
							num = (short)893059081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54A;
					case 1:
						goto IL_476;
					case 2:
						if (section != null)
						{
							num = (short)1350762496;
							short num3 = num;
							num = (short)203685905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 3:
						goto IL_23E;
					case 4:
						if (trunkingSystem.Features.TrkSysFeaturesChannel_A7647Value != 0)
						{
							num = (short)1296039948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 5:
						num = (short)15794183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1037434888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A5;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2113208325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current;
									goto IL_2BA;
								}
								case 2:
								{
									num = (short)1288258180;
									short num4 = num;
									num = (short)680149636;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2BA;
									default:
										num = (short)1845755904;
										if (num != 0)
										{
										}
										num = (short)1855127552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)993329156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									global::AcpBusinessLayer.FeatureSection featureSection;
									if (acpRecRefField.ReferencedNode != featureSection.Parent)
									{
										num = (short)744226818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)335872006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_402;
								case 7:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ReferencedNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1205796867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_2AC;
									}
									continue;
								}
								goto IL_2AC;
								IL_2BA:
								num = (short)474087431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AA:
								num = (short)1036124161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AC:
								goto IL_3AA;
							}
							IL_3A5:
							return;
							IL_402:
							goto IL_54A;
						}
						finally
						{
							num = (short)1804009474;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)554500097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_473;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_43A;
									}
									continue;
								}
								IL_43A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)356319232;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_473:;
						}
						goto IL_476;
					case 7:
					{
						string propertyName;
						if (propertyName == global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ鿎듐ꇒ鋔닖럘뻚꿜뻞跠냢鳤铦鷨軪胬냮냰쫲쟴쓶컸ꓺ꣼뛾圀戂椄爆氈", a_))
						{
							num = (short)1316356099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality != null)
						{
							num = (short)415891471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					}
					case 9:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator = channelAssignmentListInner.RecRefFields.GetEnumerator();
						num = (short)1458307078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						string propertyName;
						if (!(propertyName == global::AllFeatures.CodeplugGuid.b("鏈ꗊ軌꟎냐뷒雔뇖뻘飚뗜뻞迠跢胤详髨뿪賬菮髰铲蟴飶賸诺ꋼ뻾㠀㄂㈄ㄆ嘈帊䐌夎瀐缒怔爖", a_)))
						{
							num = (short)2061565957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 12:
						trunkingSystem.Features.TrkSysFeaturesZone_A9717_Valid = false;
						trunkingSystem.Features.TrkSysFeaturesChannel_A7647_Valid = false;
						num = (short)747765776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						string propertyName = label.PropertyName;
						num = (short)1714159617;
						if (num != 0)
						{
						}
						num = (short)340459530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						return;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						trunkingSystem = (trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
						num = (short)1046085651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_DC;
					case 17:
					{
						global::AcpBusinessLayer.FeatureSection featureSection = section as global::AcpBusinessLayer.FeatureSection;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						num = (short)307691528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (section != null)
						{
							num = (short)629145613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
						if (trunkingSystem != null)
						{
							num = (short)2032664577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 20:
						num = (short)1219297282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A1:
					if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ鿎듐ꇒ鋔닖럘뻚꿜뻞跠냢鳤铦鷨軪胬냮냰쫲쟴쓶컸ꓺ꣼뛾圀戂椄爆氈", a_))
					{
						num = (short)1353318420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					num = (short)1182924818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23E:
					global::ConstraintHelper.UtilityMack.PropertyChanging = true;
					num = (short)1178075150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_476:
					channelAssignmentListInner = (trunkingSystem.Features.TrkSysFeaturesChannel_A7647.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
					num = (short)1305673728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54A:
					num = (short)433455108;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x040008D8 RID: 2264
		private global::AcpBusinessLayer.AcpListField trkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x040008D9 RID: 2265
		private global::AcpBusinessLayer.AcpListField trkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040008DA RID: 2266
		private global::AcpBusinessLayer.AcpListField trkPerGeneralConversationType_A7781;

		// Token: 0x040008DB RID: 2267
		private global::AcpBusinessLayer.AcpListField trkPerGeneralFailsoftType_A8599;

		// Token: 0x040008DC RID: 2268
		private global::AcpBusinessLayer.AcpFrequencyField trkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x040008DD RID: 2269
		private global::AcpBusinessLayer.AcpFrequencyField trkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x040008DE RID: 2270
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x040008DF RID: 2271
		private global::AcpBusinessLayer.AcpRecRefField trkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040008E0 RID: 2272
		private global::AcpBusinessLayer.AcpListField trkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040008E1 RID: 2273
		private global::AcpBusinessLayer.AcpRecRefField trkPerGeneralSystem_A9237;

		// Token: 0x040008E2 RID: 2274
		private global::AcpBusinessLayer.AcpPointerField<int> trkPerGeneralSystemID_A9238;

		// Token: 0x040008E3 RID: 2275
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x040008E4 RID: 2276
		private global::AcpBusinessLayer.AcpFrequencyField trkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x040008E5 RID: 2277
		private global::AcpBusinessLayer.AcpPointerField<int> trkPerGeneralUnitID_A9593;

		// Token: 0x040008E6 RID: 2278
		private global::AcpBusinessLayer.AcpKeyField trkPerGeneralTrunkingPersonalityName_A12659;

		// Token: 0x040008E7 RID: 2279
		private global::AcpBusinessLayer.AcpFrequencyField trkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x040008E8 RID: 2280
		private global::AcpBusinessLayer.AcpField<bool> trkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x040008E9 RID: 2281
		private global::AcpBusinessLayer.AcpRecRefField trkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x040008EA RID: 2282
		private global::AcpBusinessLayer.AcpListField trkPerGeneralProtocolType_A8767;

		// Token: 0x040008EB RID: 2283
		private global::AcpBusinessLayer.AcpListField trkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x040008EC RID: 2284
		private global::AcpBusinessLayer.AcpRecRefField trkPerFeaturesDVRSProf_A41796;

		// Token: 0x040008ED RID: 2285
		private global::AcpBusinessLayer.AcpListField trkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x040008EE RID: 2286
		private global::AcpBusinessLayer.AcpRecRefField trkPerGeneralRevertZone_A41916;

		// Token: 0x040008EF RID: 2287
		private global::AcpBusinessLayer.AcpRecRefField trkPerGeneralRevertChannel_A41917;

		// Token: 0x040008F0 RID: 2288
		private global::AcpBusinessLayer.AcpField<bool> trkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x040008F1 RID: 2289
		private global::AcpBusinessLayer.AcpField<bool> trkPerGeneralBroadbandProtection;
	}
}
