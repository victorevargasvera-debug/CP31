using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050E RID: 1294
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AB50 RID: 43856 RVA: 0x009FB3CC File Offset: 0x009F95CC
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x009FB3E8 File Offset: 0x009F95E8
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x009FB400 File Offset: 0x009F9600
		public override void Init()
		{
			int a_ = 12;
			short num = (short)545822045;
			short num2 = num;
			num = (short)2054657373;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1601044480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)120061952;
			if (num != 0)
			{
			}
			num = (short)990117889;
			if (num != 0)
			{
			}
			this.dataProfFeaturesARSMode_A7465 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.indexDataProfFeaturesARSMode_A7465LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.idDataProfFeaturesARSMode_A7465LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬뷮ꋰ뻲髴鏶鳸ꓺ볼죾㔀㔂〄", a_), global::CommonResources.AcgResources.ID_ARSARSMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfFeaturesARSMode_A7465LovStrs);
			this.dataProfFeaturesARSMode_A7465.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesARSMode_A7465.DataTransferOrder = 2;
			this.dataProfFeaturesARSMode_A7465.EvaluateRecRefs = true;
			this.dataProfFeaturesARSRetryTimermin_A7466 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬뷮ꋰꇲ郴菶诸苺ꧼ雾氀昂眄樆怈攊刌与☐✒⌔№", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSLONGTIMERMIN, 4, 300, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.dataProfFeaturesARSRetryTimermin_A7466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfFeaturesARSRetryTimermin_A7466.DataTransferOrder = 22;
			this.dataProfFeaturesARSRetryTimermin_A7466.ShowHexValue = false;
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬髮藰鳲飴零跸鋺黼귾搀搂氄理紈礊氌笎砐簒笔䐖簘椚欜稞匠戢䄤䌦嬨个帬尮渰爲ȴȶସ༺", a_), global::CommonResources.AcgResources.ID_ARSAUTOMATICREGISTRATIONSERVERADDRESS);
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.DataTransferOrder = 13;
			this.dataProfFeaturesTerminalData_A9288 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪맬諮菰黲鳴駶飸韺맼黾甀戂娄䘆〈㤊㔌㜎", a_), global::CommonResources.AcgResources.ID_TERMINALDATA);
			this.dataProfFeaturesTerminalData_A9288.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesTerminalData_A9288.DataTransferOrder = 11;
			this.dataProfFeaturesTerminalData_A9288.EvaluateRecRefs = true;
			this.datProFeaturesPADMode_A20536 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦맨ꫪꧬꋮ黰韲郴ꣶ룸짺췼쫾㈀㔂", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERPADMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DatProFeaturesPADMode_A20536LovStrs);
			this.datProFeaturesPADMode_A20536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesPADMode_A20536.DataTransferOrder = 1;
			this.datProFeaturesPADMode_A20536.EvaluateRecRefs = true;
			this.datProFeaturesStartSequence_A20537 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦뫨鿪賬鷮藰ꃲ郴蛶賸黺鏼鳾搀専䐄㔆㤈㸊㸌㠎", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERSTARTSEQUENCE, 18);
			this.datProFeaturesStartSequence_A20537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesStartSequence_A20537.DataTransferOrder = 25;
			this.datProFeaturesStopSequence_A20538 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦뫨鿪苬鿮ꋰ雲蓴苶鳸闺黼髾帀䈂㜄㜆㰈㠊㔌", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERSTOPSEQUENCE, 18);
			this.datProFeaturesStopSequence_A20538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesStopSequence_A20538.DataTransferOrder = 26;
			this.datProFeaturesEscapeSequence_A20539 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦골飪軬軮臰雲꛴鋶裸軺飼釾戀昂娄䘆㬈㬊㠌㰎⠐", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERESCAPESEQUENCE, 10);
			this.datProFeaturesEscapeSequence_A20539.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesEscapeSequence_A20539.DataTransferOrder = 27;
			this.datProFeaturesReceiveIdleTimeOut_A20540 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1000, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦믨軪軬諮飰藲郴뻶鷸韺飼꯾栀渂怄䠆簈缊刌与⌐⌒—⌖⤘", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERRECEIVEIDLETIMEOUTMS, 0, 15000, 25);
			this.datProFeaturesReceiveIdleTimeOut_A20540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesReceiveIdleTimeOut_A20540.DataTransferOrder = 18;
			this.datProFeaturesReceiveIdleTimeOut_A20540.ShowHexValue = false;
			this.datProFeaturesTransmissionInhibitValue_A20541 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1000, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦뷨駪賬臮苰黲鳴蓶諸鋺鋼釾䠀洂洄渆欈戊礌夎瀐缒怔爖䘘娚⼜⼞ᐠᜢᐤ", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERTRANSMISSIONINHIBITVALUE, 0, 15000, 25);
			this.datProFeaturesTransmissionInhibitValue_A20541.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesTransmissionInhibitValue_A20541.DataTransferOrder = 19;
			this.datProFeaturesTransmissionInhibitValue_A20541.ShowHexValue = false;
			this.datProFeaturesDestinationAddress_A20543 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦귨軪黬鯮飰鷲铴菶郸铺鏼뻾攀朂眄戆稈砊刌与⌐⌒—⌖⨘", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERDESTINATIONADDRESS);
			this.datProFeaturesDestinationAddress_A20543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesDestinationAddress_A20543.DataTransferOrder = 28;
			this.datProFeaturesDestinationPort_A20544 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦귨軪黬鯮飰鷲铴菶郸铺鏼꿾渀焂焄堆䠈㤊㴌㨎┐✒", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERDESTINATIONPORT, 0, 65535, null, null, 0, 1);
			this.datProFeaturesDestinationPort_A20544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesDestinationPort_A20544.DataTransferOrder = 29;
			this.datProFeaturesDestinationPort_A20544.ShowHexValue = false;
			this.dataProfFeatureContxActivHldoffMode_A36469 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨꣪苬臮藰诲듴银跸鋺诼럾洀朂樄愆漈䘊戌欎琐䰒吔␖⼘⼚⬜☞", a_), global::CommonResources.AcgResources.ID_CONTEXTACTIVATIONHOLDOFFMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfFeatureContxActivHldoffMode_A36469LovStrs);
			this.dataProfFeatureContxActivHldoffMode_A36469.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeatureContxActivHldoffMode_A36469.DataTransferOrder = 40;
			this.dataProfFeaturesApplicationNumberofAttempts_A7458 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬鿮臰鿲鳴银飸迺铼郾漀䴂瀄樆欈渊缌怎眐划愔挖簘瘚洜欞删簢搤ဦᴨḪᔬ", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSNUMBEROFATTEMPTS, 1, 10, null, null, 0, 1);
			this.dataProfFeaturesApplicationNumberofAttempts_A7458.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfFeaturesApplicationNumberofAttempts_A7458.DataTransferOrder = 9;
			this.dataProfFeaturesApplicationNumberofAttempts_A7458.ShowHexValue = false;
			this.trkSysLabtoolRetransmissionTimersec_A8672 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("駌뷎뫐胒곔ꓖ闘뫚뿜ꯞ軠賢觤뗦賨鿪鿬軮鿰胲飴黶諸裺铼郾漀圂氄樆氈礊縌樎爐䰒吔⼖⼘Ⱊ⼜", a_), global::CommonResources.AcgResources.ID_POP25RETRANSMISSIONTIMERSEC, 5, 90, null, null, 0, 1);
			this.trkSysLabtoolRetransmissionTimersec_A8672.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysLabtoolRetransmissionTimersec_A8672.DataTransferOrder = 16;
			this.trkSysLabtoolRetransmissionTimersec_A8672.ShowHexValue = false;
			this.datProFeaturesMaximumBufferThreshold_A20542 = new global::AcpBusinessLayer.AcpSimpleRangeField(100, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ菒꟔룖鿘뻚볜ꯞ铠釢胤铦ꓨ諪闬蛮鳰蛲飴뗶賸鷺鯼髾猀圂洄甆氈砊攌怎紐眒䨔嘖⬘⬚⠜⬞ጠ", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERMAXIMUMBUFFERTHRESHOLD, 1, 3000, null, null, 0, 1);
			this.datProFeaturesMaximumBufferThreshold_A20542.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.datProFeaturesMaximumBufferThreshold_A20542.DataTransferOrder = 20;
			this.datProFeaturesMaximumBufferThreshold_A20542.ShowHexValue = false;
			this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = new global::AcpBusinessLayer.AcpRangeField<int, string>(15, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬鿮臰鿲鳴银飸迺铼郾漀圂氄樆氈䤊栌笎昐瘒瀔礖堘漚検稞䰠匢儤否娨个丬瀮瀰вĴĶस", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSSHORTTIMERSEC, 5, 90, 5);
			this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.DataTransferOrder = 10;
			this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.ShowHexValue = false;
			this.dataProfFeaturesDirLocReg_A42332 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪ꧬ蛮菰뿲髴银꯸黺髼ꃾ䀀㜂㜄㐆㨈㤊", a_), global::CommonResources.AcgResources.ID_DLRDIRECTLOCATIONREGISTRATION);
			this.dataProfFeaturesDirLocReg_A42332.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesDirLocReg_A42332.DataTransferOrder = 71;
			this.dataProfFeaturesLocServerIPAddr_A42333 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪ꇬ胮鋰ꃲ郴藶迸黺迼뛾儀䈂愄挆笈吊䰌㬎⌐‒☔␖", a_), global::CommonResources.AcgResources.ID_DLRLOCATIONSERVERIPADDRESS);
			this.dataProfFeaturesLocServerIPAddr_A42333.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesLocServerIPAddr_A42333.DataTransferOrder = 72;
			this.dataProfFeaturesAtakField = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("觌껎ꗐ닒藔ꗖ뛘뷚鯜뫞胠韢郤闦賨飪곬鯮郰飲돴黶鳸韺駼", a_), global::CommonResources.AcgResources.ID_ATAK_DATA);
			this.dataProfFeaturesAtakField.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfFeaturesAtakField.DataTransferOrder = 73;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诌꫎냐꟒ꃔꗖ볘꣚", a_);
			base.Id = 10122;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x009FBA70 File Offset: 0x009F9C70
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)464125983;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥뫧맩뻫语蓯胱跳ꋵ釷韹駻賽淿欁樃夅䤇㴉㠋㠍☏", a_)))
					{
						num = (short)1316225079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A55;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥飧髩胫蟭鏯鏱胳鿵韷铹ꣻ韽淿朁䘃挅簇紉椋欍縏匑怓戕紗眙氛樝匟儡䄣䔥眧欩ᬫᨭدȱ", a_)))
					{
						num = (short)1415905342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AB;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡꟣觥蛧黩铫꿭鏯蛱鷳胵냷雹飻釽替搁䤃椅氇漉匋伍⌏␑–―℗", a_)))
					{
						num = (short)374734875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_378;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟닡ꗣꋥꗧ藩裫语꿯돱웳웵췷짹쫻", a_)))
					{
						goto IL_48E;
					}
					goto IL_68A;
				case 4:
					this.dataProfFeaturesTerminalData_A9288 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣닥跧飩臫蟭黯鏱飳답駷軹鷻ꇽ䇿㬁㘃㸅〇", a_), global::CommonResources.AcgResources.ID_TERMINALDATA);
					this.dataProfFeaturesTerminalData_A9288.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesTerminalData_A9288.DataTransferOrder = 11;
					this.dataProfFeaturesTerminalData_A9288.EvaluateRecRefs = true;
					num = (short)1170931772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣ꫥ蟧觩뿫语苯蓱釳蓵뇷꫹뷻髽擿瀁嬃䜅㰇㠉㼋㴍⌏", a_)))
					{
						num = (short)1992556603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DFC;
				case 6:
					goto IL_779;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뇡郣蟥髧黩뿫语臯蟱釳飵鯷鿹ꏻ뿽㋿㈁㄃㔅㼇", a_)))
					{
						num = (short)1903624225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_85D;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝닟蟡郣铥觧蓩鿫菭駯臱蟳鿵韷铹ꣻ韽淿朁瘃甅洇椉匋伍⠏␑⌓␕", a_)))
					{
						num = (short)2141126690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72C;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뇡郣觥飧맩觫鿭藯韱髳闵鷷ꗹ뷻쳽ヿ㜁㜃㸅", a_)))
					{
						num = (short)2093350965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C6;
				case 10:
					this.datProFeaturesTransmissionInhibitValue_A20541 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1000, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뛡難蟥蛧駩臫蟭華臱鷳駵雷돹鋻雽槿态洃爅帇欉怋笍甏䴑唓␕⠗⼙⠛⼝", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERTRANSMISSIONINHIBITVALUE);
					this.datProFeaturesTransmissionInhibitValue_A20541.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesTransmissionInhibitValue_A20541.DataTransferOrder = 19;
					this.datProFeaturesTransmissionInhibitValue_A20541.ShowHexValue = false;
					num = (short)443678737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣ꋥ臧飩ꃫ臭鏯ꃱ釳釵ꟷ믹죻쳽㏿㄁㘃", a_)))
					{
						num = (short)875823150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C4;
				case 12:
					this.datProFeaturesEscapeSequence_A20539 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟꟡韣藥觧髩觫뷭闯菱至鏵雷駹駻ꇽ䇿、㐃㌅㬇㌉", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERESCAPESEQUENCE, 10);
					this.datProFeaturesEscapeSequence_A20539.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesEscapeSequence_A20539.DataTransferOrder = 27;
					num = (short)1697644550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣닥跧飩臫蟭黯鏱飳답駷軹鷻ꇽ䇿㬁㘃㸅〇", a_)))
					{
						num = (short)719060996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45D;
				case 14:
					num = (short)369819685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.datProFeaturesReceiveIdleTimeOut_A20540 = new global::AcpBusinessLayer.AcpRangeField<int, string>(1000, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟냡臣藥跧菩髫语맯雱飳鏵곷鏹釻鯽俿省瀃夅䤇㠉㰋㬍␏∑", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERRECEIVEIDLETIMEOUTMS);
					this.datProFeaturesReceiveIdleTimeOut_A20540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesReceiveIdleTimeOut_A20540.DataTransferOrder = 18;
					this.datProFeaturesReceiveIdleTimeOut_A20540.ShowHexValue = false;
					num = (short)93061143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_811;
				case 17:
					goto IL_B55;
				case 18:
					num = (short)1462108210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_D12;
				case 20:
					this.datProFeaturesDestinationPort_A20544 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟ꛡ臣闥鳧菩苫迭蓯鯱鯳飵ꣷ闹軻諽忿䌁㘃㘅㴇㸉㠋", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERDESTINATIONPORT, null, null, 0, 1);
					this.datProFeaturesDestinationPort_A20544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesDestinationPort_A20544.DataTransferOrder = 29;
					this.datProFeaturesDestinationPort_A20544.ShowHexValue = false;
					num = (short)303366160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_72C;
				case 22:
					num = (short)1119813633;
					if (num != 0)
					{
					}
					goto IL_7C6;
				case 23:
					goto IL_BA1;
				case 24:
				{
					num = (short)708416042;
					short num3 = num;
					num = (short)660116010;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48E;
					default:
						num = (short)1860698112;
						if (num != 0)
						{
						}
						this.dataProfFeaturesApplicationNumberofAttempts_A7458 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥飧髩胫蟭鏯鏱胳鿵韷铹닻诽淿态愃琅朇氉䴋稍搏眑礓昕気椙䌛弝ᜟᘡᄣḥ", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSNUMBEROFATTEMPTS, null, null, 0, 1);
						this.dataProfFeaturesApplicationNumberofAttempts_A7458.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.dataProfFeaturesApplicationNumberofAttempts_A7458.DataTransferOrder = 9;
						this.dataProfFeaturesApplicationNumberofAttempts_A7458.ShowHexValue = false;
						num = (short)341180451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
					goto IL_2BF;
				case 26:
					this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥鷧黩菫菭釯蛱鷳闵꫷鿹鯻韽珿瘁瘃朅簇按挋怍䌏眑易怕紗栙崛稝䐟倡䄣唥嬧甩洫᤭ԯ13", a_), global::CommonResources.AcgResources.ID_ARSAUTOMATICREGISTRATIONSERVERADDRESS);
					this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.DataTransferOrder = 13;
					num = (short)717160495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.dataProfFeatureContxActivHldoffMode_A36469 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡꟣觥蛧黩铫꿭鏯蛱鷳胵냷雹飻釽替搁䤃椅氇漉匋伍⌏␑–―℗", a_), global::CommonResources.AcgResources.ID_CONTEXTACTIVATIONHOLDOFFMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfFeatureContxActivHldoffMode_A36469LovStrs);
					this.dataProfFeatureContxActivHldoffMode_A36469.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeatureContxActivHldoffMode_A36469.DataTransferOrder = 40;
					num = (short)407961636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_3C4;
				case 29:
					this.datProFeaturesPADMode_A20536 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟닡ꗣꋥꗧ藩裫语꿯돱웳웵췷짹쫻", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERPADMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DatProFeaturesPADMode_A20536LovStrs);
					this.datProFeaturesPADMode_A20536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesPADMode_A20536.DataTransferOrder = 1;
					this.datProFeaturesPADMode_A20536.EvaluateRecRefs = true;
					num = (short)520945696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					goto IL_54B;
				case 31:
					switch (0)
					{
					case 0:
						goto IL_12F;
					}
					continue;
				case 32:
					goto IL_68A;
				case 33:
					this.datProFeaturesStartSequence_A20537 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뇡郣蟥髧黩뿫语臯蟱釳飵鯷鿹ꏻ뿽㋿㈁㄃㔅㼇", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERSTARTSEQUENCE, 18);
					this.datProFeaturesStartSequence_A20537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesStartSequence_A20537.DataTransferOrder = 25;
					num = (short)954400809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.trkSysLabtoolRetransmissionTimersec_A8672 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝닟蟡郣铥觧蓩鿫菭駯臱蟳鿵韷铹ꣻ韽淿朁瘃甅洇椉匋伍⠏␑⌓␕", a_), global::CommonResources.AcgResources.ID_POP25RETRANSMISSIONTIMERSEC, null, null, 0, 1);
					this.trkSysLabtoolRetransmissionTimersec_A8672.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysLabtoolRetransmissionTimersec_A8672.DataTransferOrder = 16;
					this.trkSysLabtoolRetransmissionTimersec_A8672.ShowHexValue = false;
					num = (short)281739285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_F76;
				case 36:
					goto IL_378;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥뫧맩ꇫ臭铯韱꯳럵쿷컹쫻쯽", a_)))
					{
						num = (short)1136918572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D12;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟ꛡ臣闥鳧菩苫迭蓯鯱鯳飵ꣷ闹軻諽忿䌁㘃㘅㴇㸉㠋", a_)))
					{
						num = (short)108789780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_811;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟냡臣藥跧菩髫语맯雱飳鏵곷鏹釻鯽俿省瀃夅䤇㠉㰋㬍␏∑", a_)))
					{
						num = (short)2091646991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA1;
				case 40:
					goto IL_A55;
				case 41:
					goto IL_85D;
				case 42:
					this.datProFeaturesMaximumBufferThreshold_A20542 = new global::AcpBusinessLayer.AcpSimpleRangeField(100, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟꿡藣黥臧蟩駫菭닯蟱鋳郵鷷裹ꣻ雽狿朁眃清朇昉栋儍儏‑␓⌕Ⱇ⠙", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERMAXIMUMBUFFERTHRESHOLD, null, null, 0, 1);
					this.datProFeaturesMaximumBufferThreshold_A20542.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesMaximumBufferThreshold_A20542.DataTransferOrder = 20;
					this.datProFeaturesMaximumBufferThreshold_A20542.ShowHexValue = false;
					num = (short)1321402393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥鷧黩菫菭釯蛱鷳闵꫷鿹鯻韽珿瘁瘃朅簇按挋怍䌏眑易怕紗栙崛稝䐟倡䄣唥嬧甩洫᤭ԯ13", a_)))
					{
						num = (short)482017306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E5;
				case 44:
					this.dataProfFeaturesARSMode_A7465 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.indexDataProfFeaturesARSMode_A7465LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.idDataProfFeaturesARSMode_A7465LovStrs), this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥뫧맩ꇫ臭铯韱꯳럵쿷컹쫻쯽", a_), global::CommonResources.AcgResources.ID_ARSARSMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfFeaturesARSMode_A7465LovStrs);
					this.dataProfFeaturesARSMode_A7465.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesARSMode_A7465.DataTransferOrder = 2;
					this.dataProfFeaturesARSMode_A7465.EvaluateRecRefs = true;
					num = (short)427098131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟꟡韣藥觧髩觫뷭闯菱至鏵雷駹駻ꇽ䇿、㐃㌅㬇㌉", a_)))
					{
						num = (short)1955725324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_779;
				case 46:
					this.dataProfFeaturesDirLocReg_A42332 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣ꋥ臧飩ꃫ臭鏯ꃱ釳釵ꟷ믹죻쳽㏿㄁㘃", a_), global::CommonResources.AcgResources.ID_DLRDIRECTLOCATIONREGISTRATION);
					this.dataProfFeaturesDirLocReg_A42332.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesDirLocReg_A42332.DataTransferOrder = 71;
					num = (short)1569456156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_5E5;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뛡難蟥蛧駩臫蟭華臱鷳駵雷돹鋻雽槿态洃爅帇欉怋笍甏䴑唓␕⠗⼙⠛⼝", a_)))
					{
						num = (short)2020212746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B55;
				case 49:
					goto IL_410;
				case 50:
					if (producerFields != null)
					{
						num = (short)1077280782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FC4;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥飧髩胫蟭鏯鏱胳鿵韷铹닻诽淿态愃琅朇氉䴋稍搏眑礓昕気椙䌛弝ᜟᘡᄣḥ", a_)))
					{
						num = (short)572194840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F76;
				case 52:
					this.dataProfFeaturesAtakField = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥鳧诩蟫꣭駯韱飳鋵", a_), global::CommonResources.AcgResources.ID_ATAK_DATA);
					this.dataProfFeaturesAtakField.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesAtakField.DataTransferOrder = 73;
					num = (short)1043136542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					this.datProFeaturesStopSequence_A20538 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟뇡郣觥飧맩觫鿭藯韱髳闵鷷ꗹ뷻쳽ヿ㜁㜃㸅", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERSTOPSEQUENCE, 18);
					this.datProFeaturesStopSequence_A20538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesStopSequence_A20538.DataTransferOrder = 26;
					num = (short)516292630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥鳧诩蟫꣭駯韱飳鋵", a_)))
					{
						num = (short)1563492404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FC4;
				case 55:
				{
					num = (short)1600782336;
					short num4 = num;
					this.dataProfFeaturesARSRetryTimermin_A7466 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥뫧맩뻫语蓯胱跳ꋵ釷韹駻賽淿欁樃夅䤇㴉㠋㠍☏", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSLONGTIMERMIN, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.dataProfFeaturesARSRetryTimermin_A7466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfFeaturesARSRetryTimermin_A7466.DataTransferOrder = 22;
					this.dataProfFeaturesARSRetryTimermin_A7466.ShowHexValue = false;
					num = (short)1980497960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟ꛡ臣闥鳧菩苫迭蓯鯱鯳飵맷黹飻賽旿焁眃夅䤇㠉㰋㬍␏ℑ", a_)))
					{
						num = (short)1078067257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_410;
				case 57:
					this.datProFeaturesDestinationAddress_A20543 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟ꛡ臣闥鳧菩苫迭蓯鯱鯳飵맷黹飻賽旿焁眃夅䤇㠉㰋㬍␏ℑ", a_), global::CommonResources.AcgResources.ID_PROTOCOLASSEMBLERDISASSEMBLERDESTINATIONADDRESS);
					this.datProFeaturesDestinationAddress_A20543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.datProFeaturesDestinationAddress_A20543.DataTransferOrder = 28;
					num = (short)903610417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					goto IL_4AB;
				case 59:
					this.dataProfFeaturesLocServerIPAddr_A42333 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣ꫥ蟧觩뿫语苯蓱釳蓵뇷꫹뷻髽擿瀁嬃䜅㰇㠉㼋㴍⌏", a_), global::CommonResources.AcgResources.ID_DLRLOCATIONSERVERIPADDRESS);
					this.dataProfFeaturesLocServerIPAddr_A42333.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfFeaturesLocServerIPAddr_A42333.DataTransferOrder = 72;
					num = (short)458293309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					goto IL_45D;
				case 61:
					goto IL_DFC;
				case 62:
					this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = new global::AcpBusinessLayer.AcpRangeField<int, string>(15, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓郕뷗믙꣛ꯝ鋟蟡韣꟥飧髩胫蟭鏯鏱胳鿵韷铹ꣻ韽淿朁䘃挅簇紉椋欍縏匑怓戕紗眙氛樝匟儡䄣䔥眧欩ᬫᨭدȱ", a_), global::CommonResources.AcgResources.ID_RETRYTIMERSSHORTTIMERSEC);
					this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.DataTransferOrder = 10;
					this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.ShowHexValue = false;
					num = (short)349110330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉鳋볍뿏铑뇓럕곗꿙껛믝鏟꿡藣黥臧蟩駫菭닯蟱鋳郵鷷裹ꣻ雽狿朁眃清朇昉栋儍儏‑␓⌕Ⱇ⠙", a_)))
					{
						num = (short)1483604010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BF;
				}
				IL_12F:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2041708562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2BF:
				num = (short)1451032577;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_378:
				num = (short)756809779;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C4:
				num = (short)2125791237;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_410:
				num = (short)902823974;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45D:
				num = (short)1077608451;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48E:
				num = (short)1342570525;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4AB:
				num = (short)452395019;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E5:
				num = (short)1099038733;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68A:
				num = (short)523304967;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_72C:
				num = (short)135528511;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_779:
				num = (short)1188823079;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C6:
				num = (short)1121386541;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_811:
				num = (short)484573186;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_85D:
				num = (short)153026569;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A55:
				num = (short)908001323;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B55:
				num = (short)729743416;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BA1:
				num = (short)1163526192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D12:
				num = (short)1500774400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DFC:
				num = (short)507314230;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F76:
				num = (short)1225588744;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_54B:
			IL_FC4:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胅귇ꯉ룋믍ꋏ럑ꟓ", a_);
			base.Id = 10122;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x009FCA74 File Offset: 0x009FAC74
		public override void PopulateReferences()
		{
			short num = (short)1286340609;
			if (num != 0)
			{
			}
			num = (short)279773184;
			short num2 = num;
			num = (short)1730883258;
			short num3 = num;
			num = (short)541470394;
			switch (num3 == num)
			{
			}
			num = (short)833028096;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x009FCB1C File Offset: 0x009FAD1C
		public override void DropReferences()
		{
			short num = (short)380444488;
			short num2 = num;
			num = (short)797908808;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1760821248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)463863808;
			if (num != 0)
			{
			}
			num = (short)990969857;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x009FCBC8 File Offset: 0x009FADC8
		public override void SetConstraints()
		{
			short num = (short)751304705;
			if (num != 0)
			{
			}
			num = (short)2036629891;
			short num2 = num;
			num = (short)581075331;
			switch (num2 == num)
			{
			default:
			{
				num = (short)932380672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)749338624;
			if (num != 0)
			{
			}
			this.dataProfFeaturesARSMode_A7465.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConARSModeIsApplicable);
			this.dataProfFeaturesARSMode_A7465.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfileIsNotTrunkingOrNotNonServer);
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conARSModeIsServer);
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conAutoRegSvrAddressValid);
			this.dataProfFeaturesTerminalData_A9288.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTerminalDataScanlistDataMember);
			this.dataProfFeaturesTerminalData_A9288.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfATAKDataEnableChannels);
			this.datProFeaturesPADMode_A20536.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeValid);
			this.datProFeaturesPADMode_A20536.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesStartSequence_A20537.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPadModIsSentence);
			this.datProFeaturesStartSequence_A20537.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConStartSequenceIsValid);
			this.datProFeaturesStartSequence_A20537.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesStopSequence_A20538.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPadModIsSentence);
			this.datProFeaturesStopSequence_A20538.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConStopSequenceIsValid);
			this.datProFeaturesStopSequence_A20538.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesEscapeSequence_A20539.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPadModIsSentence);
			this.datProFeaturesEscapeSequence_A20539.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConEscapeSequenceIsValid);
			this.datProFeaturesEscapeSequence_A20539.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesReceiveIdleTimeOut_A20540.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConReceiveIdleTimeOutApplicable);
			this.datProFeaturesReceiveIdleTimeOut_A20540.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesTransmissionInhibitValue_A20541.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConTransmissionInhibitValueApplicable);
			this.datProFeaturesTransmissionInhibitValue_A20541.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesDestinationAddress_A20543.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPadModeIsEnabled);
			this.datProFeaturesDestinationAddress_A20543.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDestinationAddressValid);
			this.datProFeaturesDestinationAddress_A20543.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesDestinationPort_A20544.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPadModeIsEnabled);
			this.datProFeaturesDestinationPort_A20544.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDestinationPortValid);
			this.datProFeaturesDestinationPort_A20544.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.datProFeaturesMaximumBufferThreshold_A20542.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConMaximumBufferThresholdApplicable);
			this.datProFeaturesMaximumBufferThreshold_A20542.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfPADModeVisible);
			this.dataProfFeaturesDirLocReg_A42332.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDirectLocationRegInApplicable);
			this.dataProfFeaturesLocServerIPAddr_A42333.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDirectLocationRegIsAppAndEnabled);
			this.dataProfFeaturesLocServerIPAddr_A42333.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conLocServerIPAddrValid);
			this.dataProfFeaturesAtakField.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfATAKFieldApplicable);
			this.dataProfFeaturesAtakField.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfATAKFieldVisible);
			this.dataProfFeaturesAtakField.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfATAKDataEnableChannelsValid);
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x009FCF94 File Offset: 0x009FB194
		public override void SetupDependencies()
		{
			short num = (short)180758032;
			short num2 = num;
			num = (short)1499604496;
			switch (num2 == num)
			{
			}
			num = (short)812711936;
			short num3 = num;
			num = (short)1328349184;
			if (num != 0)
			{
			}
			num = (short)755040257;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfFeaturesARSMode_A7465);
			dataProfiles.General.DataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfFeaturesARSMode_A7465);
			this.dataProfFeaturesARSMode_A7465.AddDependentObject(this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524);
			dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524);
			dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject(this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524);
			this.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesPADMode_A20536);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesStartSequence_A20537);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesStartSequence_A20537);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesStopSequence_A20538);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesStopSequence_A20538);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesEscapeSequence_A20539);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesEscapeSequence_A20539);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesReceiveIdleTimeOut_A20540);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesReceiveIdleTimeOut_A20540);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesTransmissionInhibitValue_A20541);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesTransmissionInhibitValue_A20541);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesDestinationAddress_A20543);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesDestinationAddress_A20543);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.datProFeaturesDestinationAddress_A20543);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesDestinationPort_A20544);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesDestinationPort_A20544);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesMaximumBufferThreshold_A20542);
			this.datProFeaturesPADMode_A20536.AddDependentObject(this.datProFeaturesMaximumBufferThreshold_A20542);
			this.dataProfFeaturesARSMode_A7465.AddDependentObject(this.dataProfFeaturesDirLocReg_A42332);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.dataProfFeaturesDirLocReg_A42332);
			this.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.AddDependentObject(this.dataProfFeaturesDirLocReg_A42332);
			this.dataProfFeaturesDirLocReg_A42332.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefDataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfFeaturesLocServerIPAddr_A42333);
			this.dataProfFeaturesARSMode_A7465.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10100] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationSystemManagedGeofence_43042);
			this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.datProFeaturesDestinationPort_A20544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413);
			this.datProFeaturesDestinationPort_A20544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.datProFeaturesDestinationPort_A20544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022);
			this.datProFeaturesDestinationPort_A20544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x009FD4D4 File Offset: 0x009FB6D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)433107762;
				short num2 = num;
				num = (short)1611248434;
				switch (num2 == num)
				{
				}
				num = (short)1207631872;
				short num3 = num;
				num = (short)636944384;
				if (num != 0)
				{
				}
				num = (short)1107558401;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170055BF RID: 21951
		// (get) Token: 0x0600AB59 RID: 43865 RVA: 0x009FD588 File Offset: 0x009FB788
		// (set) Token: 0x0600AB5A RID: 43866 RVA: 0x009FD640 File Offset: 0x009FB840
		public int DataProfFeaturesARSMode_A7465Value
		{
			get
			{
				short num = (short)207245656;
				short num2 = num;
				num = (short)892752216;
				switch (num2 == num)
				{
				}
				num = (short)1288634368;
				short num3 = num;
				num = (short)292028417;
				if (num != 0)
				{
				}
				num = (short)505806848;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.Value;
			}
			set
			{
				short num = (short)2070143974;
				short num2 = num;
				num = (short)892068838;
				switch (num2 == num)
				{
				}
				num = (short)1254817792;
				short num3 = num;
				num = (short)293208065;
				if (num != 0)
				{
				}
				num = (short)761135104;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.Value = value;
			}
		}

		// Token: 0x170055C0 RID: 21952
		// (get) Token: 0x0600AB5B RID: 43867 RVA: 0x009FD6F8 File Offset: 0x009FB8F8
		// (set) Token: 0x0600AB5C RID: 43868 RVA: 0x009FD7AC File Offset: 0x009FB9AC
		public string DataProfFeaturesARSMode_A7465_UIValue
		{
			get
			{
				short num = (short)526116582;
				short num2 = num;
				num = (short)1024714470;
				switch (num2 == num)
				{
				}
				num = (short)846987264;
				short num3 = num;
				num = (short)122880001;
				if (num != 0)
				{
				}
				num = (short)459210752;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.UIValue;
			}
			set
			{
				short num = (short)1782442659;
				short num2 = num;
				num = (short)1268378275;
				switch (num2 == num)
				{
				}
				num = (short)910622720;
				short num3 = num;
				num = (short)1404895232;
				if (num != 0)
				{
				}
				num = (short)1768423425;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.UIValue = value;
			}
		}

		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x009FD864 File Offset: 0x009FBA64
		public global::AcpBusinessLayer.AcpListField DataProfFeaturesARSMode_A7465
		{
			get
			{
				short num = (short)689546326;
				short num2 = num;
				num = (short)1839244374;
				switch (num2 == num)
				{
				}
				num = (short)986578944;
				short num3 = num;
				num = (short)376897537;
				if (num != 0)
				{
				}
				num = (short)242745344;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465;
			}
		}

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x009FD914 File Offset: 0x009FBB14
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x009FD9C8 File Offset: 0x009FBBC8
		public bool DataProfFeaturesARSMode_A7465_Applicable
		{
			get
			{
				short num = (short)1450824010;
				short num2 = num;
				num = (short)815255882;
				switch (num2 == num)
				{
				}
				num = (short)968556544;
				short num3 = num;
				num = (short)1504182273;
				if (num != 0)
				{
				}
				num = (short)729546752;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.Applicable;
			}
			set
			{
				short num = (short)2071330817;
				if (num != 0)
				{
				}
				num = (short)1144324294;
				short num2 = num;
				num = (short)1186726086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1760559104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)862060544;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.Applicable = value;
			}
		}

		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x009FDA80 File Offset: 0x009FBC80
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x009FDB34 File Offset: 0x009FBD34
		public bool DataProfFeaturesARSMode_A7465_Valid
		{
			get
			{
				short num = (short)814397451;
				short num2 = num;
				num = (short)1118025739;
				switch (num2 == num)
				{
				}
				num = (short)778895360;
				short num3 = num;
				num = (short)1006305280;
				if (num != 0)
				{
				}
				num = (short)439812097;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.Valid;
			}
			set
			{
				short num = (short)1425257730;
				short num2 = num;
				num = (short)1061008642;
				switch (num2 == num)
				{
				}
				num = (short)606928896;
				short num3 = num;
				num = (short)1829240832;
				if (num != 0)
				{
				}
				num = (short)1352925185;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.Valid = value;
			}
		}

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x009FDBE8 File Offset: 0x009FBDE8
		// (set) Token: 0x0600AB63 RID: 43875 RVA: 0x009FDC9C File Offset: 0x009FBE9C
		public bool DataProfFeaturesARSMode_A7465_Visible
		{
			get
			{
				short num = (short)1856482168;
				short num2 = num;
				num = (short)304851832;
				switch (num2 == num)
				{
				}
				num = (short)307298304;
				short num3 = num;
				num = (short)1484652545;
				if (num != 0)
				{
				}
				num = (short)375128064;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.Visible;
			}
			set
			{
				short num = (short)634191873;
				if (num != 0)
				{
				}
				num = (short)905637051;
				short num2 = num;
				num = (short)1256844475;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195624960;
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
				this.dataProfFeaturesARSMode_A7465.Visible = value;
			}
		}

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x009FDD50 File Offset: 0x009FBF50
		// (set) Token: 0x0600AB65 RID: 43877 RVA: 0x009FDE04 File Offset: 0x009FC004
		public bool DataProfFeaturesARSMode_A7465_Editable
		{
			get
			{
				short num = (short)1867271449;
				short num2 = num;
				num = (short)1025199385;
				switch (num2 == num)
				{
				}
				num = (short)2049507328;
				short num3 = num;
				num = (short)2034565121;
				if (num != 0)
				{
				}
				num = (short)458686464;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.Editable;
			}
			set
			{
				short num = (short)130659683;
				short num2 = num;
				num = (short)1025422691;
				switch (num2 == num)
				{
				}
				num = (short)1664352256;
				short num3 = num;
				num = (short)235601921;
				if (num != 0)
				{
				}
				num = (short)374145024;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.Editable = value;
			}
		}

		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x0600AB66 RID: 43878 RVA: 0x009FDEB8 File Offset: 0x009FC0B8
		internal string DataProfFeaturesARSMode_A7465_UILabel
		{
			get
			{
				short num = (short)486525640;
				short num2 = num;
				num = (short)991414984;
				switch (num2 == num)
				{
				}
				num = (short)1827078144;
				short num3 = num;
				num = (short)1550450689;
				if (num != 0)
				{
				}
				num = (short)593166336;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.UIName;
			}
		}

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x009FDF68 File Offset: 0x009FC168
		// (set) Token: 0x0600AB68 RID: 43880 RVA: 0x009FE020 File Offset: 0x009FC220
		internal bool DataProfFeaturesARSMode_A7465_HiddenStatic
		{
			get
			{
				short num = (short)195423726;
				short num2 = num;
				num = (short)1434971630;
				switch (num2 == num)
				{
				}
				num = (short)1023672320;
				short num3 = num;
				num = (short)1318649856;
				if (num != 0)
				{
				}
				num = (short)905248769;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.HiddenStatic;
			}
			set
			{
				short num = (short)149261524;
				short num2 = num;
				num = (short)37981396;
				switch (num2 == num)
				{
				}
				num = (short)2106327040;
				short num3 = num;
				num = (short)254410752;
				if (num != 0)
				{
				}
				num = (short)824573953;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.HiddenStatic = value;
			}
		}

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x0600AB69 RID: 43881 RVA: 0x009FE0D8 File Offset: 0x009FC2D8
		// (set) Token: 0x0600AB6A RID: 43882 RVA: 0x009FE18C File Offset: 0x009FC38C
		internal bool DataProfFeaturesARSMode_A7465_HiddenDynamic
		{
			get
			{
				short num = (short)1589116929;
				if (num != 0)
				{
				}
				num = (short)855385623;
				short num2 = num;
				num = (short)1735796247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1819934720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019084800;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465.HiddenDynamic;
			}
			set
			{
				short num = (short)130517491;
				short num2 = num;
				num = (short)1694861811;
				switch (num2 == num)
				{
				}
				num = (short)781320192;
				short num3 = num;
				num = (short)1341915136;
				if (num != 0)
				{
				}
				num = (short)195362817;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSMode_A7465.HiddenDynamic = value;
			}
		}

		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x0600AB6B RID: 43883 RVA: 0x009FE244 File Offset: 0x009FC444
		public bool DataProfFeaturesARSMode_A7465_HasDiffs
		{
			get
			{
				short num = (short)627813749;
				short num2 = num;
				num = (short)1849470325;
				switch (num2 == num)
				{
				}
				num = (short)2065760256;
				short num3 = num;
				num = (short)1534590977;
				if (num != 0)
				{
				}
				num = (short)1477967872;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSMode_A7465._HasDiffs;
			}
		}

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x0600AB6C RID: 43884 RVA: 0x009FE2F8 File Offset: 0x009FC4F8
		// (set) Token: 0x0600AB6D RID: 43885 RVA: 0x009FE3B0 File Offset: 0x009FC5B0
		public int DataProfFeaturesARSRetryTimermin_A7466Value
		{
			get
			{
				short num = (short)2052428596;
				short num2 = num;
				num = (short)224957236;
				switch (num2 == num)
				{
				}
				num = (short)233373696;
				short num3 = num;
				num = (short)2069430273;
				if (num != 0)
				{
				}
				num = (short)1176502272;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Value;
			}
			set
			{
				short num = (short)636428955;
				short num2 = num;
				num = (short)345842331;
				switch (num2 == num)
				{
				}
				num = (short)637403136;
				short num3 = num;
				num = (short)1781530625;
				if (num != 0)
				{
				}
				num = (short)821624832;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Value = value;
			}
		}

		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x009FE468 File Offset: 0x009FC668
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfFeaturesARSRetryTimermin_A7466
		{
			get
			{
				short num = (short)359647682;
				short num2 = num;
				num = (short)1293863362;
				switch (num2 == num)
				{
				}
				num = (short)470155264;
				short num3 = num;
				num = (short)1444347904;
				if (num != 0)
				{
				}
				num = (short)1312882689;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466;
			}
		}

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x009FE51C File Offset: 0x009FC71C
		// (set) Token: 0x0600AB70 RID: 43888 RVA: 0x009FE5D0 File Offset: 0x009FC7D0
		public string DataProfFeaturesARSRetryTimermin_A7466_UIValue
		{
			get
			{
				short num = (short)1778843649;
				if (num != 0)
				{
				}
				num = (short)302215362;
				short num2 = num;
				num = (short)740716738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1437990912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)839254016;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.UIValue;
			}
			set
			{
				short num = (short)844899271;
				short num2 = num;
				num = (short)1129456583;
				switch (num2 == num)
				{
				}
				num = (short)1882980352;
				short num3 = num;
				num = (short)2142240769;
				if (num != 0)
				{
				}
				num = (short)1756495872;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.UIValue = value;
			}
		}

		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x009FE688 File Offset: 0x009FC888
		// (set) Token: 0x0600AB72 RID: 43890 RVA: 0x009FE73C File Offset: 0x009FC93C
		internal int DataProfFeaturesARSRetryTimermin_A7466Min
		{
			get
			{
				short num = (short)286525110;
				short num2 = num;
				num = (short)218498742;
				switch (num2 == num)
				{
				}
				num = (short)479133696;
				short num3 = num;
				num = (short)1157562369;
				if (num != 0)
				{
				}
				num = (short)1707474944;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Min;
			}
			set
			{
				short num = (short)1629239366;
				short num2 = num;
				num = (short)1802319942;
				switch (num2 == num)
				{
				}
				num = (short)1266024448;
				short num3 = num;
				num = (short)2053767168;
				if (num != 0)
				{
				}
				num = (short)605224961;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Min = value;
			}
		}

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x0600AB73 RID: 43891 RVA: 0x009FE7F0 File Offset: 0x009FC9F0
		// (set) Token: 0x0600AB74 RID: 43892 RVA: 0x009FE8A8 File Offset: 0x009FCAA8
		internal int DataProfFeaturesARSRetryTimermin_A7466Max
		{
			get
			{
				short num = (short)335544321;
				if (num != 0)
				{
				}
				num = (short)1826512642;
				short num2 = num;
				num = (short)694443778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925775360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)959381504;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Max;
			}
			set
			{
				short num = (short)1770492946;
				short num2 = num;
				num = (short)59675666;
				switch (num2 == num)
				{
				}
				num = (short)1935933440;
				short num3 = num;
				num = (short)2141716481;
				if (num != 0)
				{
				}
				num = (short)433586176;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Max = value;
			}
		}

		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x0600AB75 RID: 43893 RVA: 0x009FE95C File Offset: 0x009FCB5C
		// (set) Token: 0x0600AB76 RID: 43894 RVA: 0x009FEA10 File Offset: 0x009FCC10
		internal int DataProfFeaturesARSRetryTimermin_A7466Step
		{
			get
			{
				short num = (short)1162631980;
				short num2 = num;
				num = (short)1346263852;
				switch (num2 == num)
				{
				}
				num = (short)839843840;
				short num3 = num;
				num = (short)1948319744;
				if (num != 0)
				{
				}
				num = (short)828375041;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.StepSize;
			}
			set
			{
				short num = (short)1368195073;
				if (num != 0)
				{
				}
				num = (short)1944093867;
				short num2 = num;
				num = (short)1930134699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093664768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985399296;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.StepSize = value;
			}
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x009FEAC4 File Offset: 0x009FCCC4
		// (set) Token: 0x0600AB78 RID: 43896 RVA: 0x009FEB74 File Offset: 0x009FCD74
		public bool DataProfFeaturesARSRetryTimermin_A7466_Applicable
		{
			get
			{
				short num = (short)342954482;
				short num2 = num;
				num = (short)1808798194;
				switch (num2 == num)
				{
				}
				num = (short)90570752;
				short num3 = num;
				num = (short)1604976641;
				if (num != 0)
				{
				}
				num = (short)2130968576;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Applicable;
			}
			set
			{
				short num = (short)954414885;
				short num2 = num;
				num = (short)1028863781;
				switch (num2 == num)
				{
				}
				num = (short)1015349248;
				short num3 = num;
				num = (short)981729281;
				if (num != 0)
				{
				}
				num = (short)708706304;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Applicable = value;
			}
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x009FEC2C File Offset: 0x009FCE2C
		// (set) Token: 0x0600AB7A RID: 43898 RVA: 0x009FECE0 File Offset: 0x009FCEE0
		public bool DataProfFeaturesARSRetryTimermin_A7466_Valid
		{
			get
			{
				short num = (short)1521745921;
				if (num != 0)
				{
				}
				num = (short)1825276779;
				short num2 = num;
				num = (short)713982827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775304704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964296704;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Valid;
			}
			set
			{
				short num = (short)11696722;
				short num2 = num;
				num = (short)715422290;
				switch (num2 == num)
				{
				}
				num = (short)1802108928;
				short num3 = num;
				num = (short)1615134721;
				if (num != 0)
				{
				}
				num = (short)1015152640;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Valid = value;
			}
		}

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x0600AB7B RID: 43899 RVA: 0x009FED94 File Offset: 0x009FCF94
		// (set) Token: 0x0600AB7C RID: 43900 RVA: 0x009FEE48 File Offset: 0x009FD048
		public bool DataProfFeaturesARSRetryTimermin_A7466_Visible
		{
			get
			{
				short num = (short)1348012862;
				short num2 = num;
				num = (short)1104153406;
				switch (num2 == num)
				{
				}
				num = (short)15990784;
				short num3 = num;
				num = (short)1371799553;
				if (num != 0)
				{
				}
				num = (short)1867055104;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Visible;
			}
			set
			{
				short num = (short)1137288932;
				short num2 = num;
				num = (short)2140055268;
				switch (num2 == num)
				{
				}
				num = (short)1507065856;
				short num3 = num;
				num = (short)247398401;
				if (num != 0)
				{
				}
				num = (short)1146945536;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Visible = value;
			}
		}

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x0600AB7D RID: 43901 RVA: 0x009FEEFC File Offset: 0x009FD0FC
		// (set) Token: 0x0600AB7E RID: 43902 RVA: 0x009FEFAC File Offset: 0x009FD1AC
		public bool DataProfFeaturesARSRetryTimermin_A7466_Editable
		{
			get
			{
				short num = (short)2008365185;
				short num2 = num;
				num = (short)248789121;
				switch (num2 == num)
				{
				}
				num = (short)80805888;
				short num3 = num;
				num = (short)1482752000;
				if (num != 0)
				{
				}
				num = (short)1828519937;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.Editable;
			}
			set
			{
				short num = (short)914244858;
				short num2 = num;
				num = (short)1563575546;
				switch (num2 == num)
				{
				}
				num = (short)1144324096;
				short num3 = num;
				num = (short)545128449;
				if (num != 0)
				{
				}
				num = (short)1317011456;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.Editable = value;
			}
		}

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x0600AB7F RID: 43903 RVA: 0x009FF060 File Offset: 0x009FD260
		internal string DataProfFeaturesARSRetryTimermin_A7466_UILabel
		{
			get
			{
				short num = (short)1177932007;
				short num2 = num;
				num = (short)1096077543;
				switch (num2 == num)
				{
				}
				num = (short)1904214016;
				short num3 = num;
				num = (short)431751169;
				if (num != 0)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.UIName;
			}
		}

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x009FF114 File Offset: 0x009FD314
		// (set) Token: 0x0600AB81 RID: 43905 RVA: 0x009FF1C8 File Offset: 0x009FD3C8
		internal bool DataProfFeaturesARSRetryTimermin_A7466_HiddenStatic
		{
			get
			{
				short num = (short)794312804;
				short num2 = num;
				num = (short)415187044;
				switch (num2 == num)
				{
				}
				num = (short)1270153216;
				short num3 = num;
				num = (short)1894121473;
				if (num != 0)
				{
				}
				num = (short)1796866048;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.HiddenStatic;
			}
			set
			{
				short num = (short)503859399;
				short num2 = num;
				num = (short)1658734791;
				switch (num2 == num)
				{
				}
				num = (short)959971328;
				short num3 = num;
				num = (short)1026752513;
				if (num != 0)
				{
				}
				num = (short)1444872192;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.HiddenStatic = value;
			}
		}

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x009FF27C File Offset: 0x009FD47C
		// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x009FF330 File Offset: 0x009FD530
		internal bool DataProfFeaturesARSRetryTimermin_A7466_HiddenDynamic
		{
			get
			{
				short num = (short)2124924936;
				short num2 = num;
				num = (short)824559624;
				switch (num2 == num)
				{
				}
				num = (short)1027801088;
				short num3 = num;
				num = (short)452329472;
				if (num != 0)
				{
				}
				num = (short)161218561;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesARSRetryTimermin_A7466.HiddenDynamic;
			}
			set
			{
				short num = (short)1002110411;
				short num2 = num;
				num = (short)2005597643;
				switch (num2 == num)
				{
				}
				num = (short)2115960832;
				short num3 = num;
				num = (short)1990852609;
				if (num != 0)
				{
				}
				num = (short)1407582208;
				if (num != 0)
				{
				}
				this.dataProfFeaturesARSRetryTimermin_A7466.HiddenDynamic = value;
			}
		}

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x009FF3E8 File Offset: 0x009FD5E8
		public bool DataProfFeaturesARSRetryTimermin_A7466_HasDiffs
		{
			get
			{
				short num = (short)1906403149;
				short num2 = num;
				num = (short)866150221;
				switch (num2 == num)
				{
				}
				num = (short)1282932737;
				if (num != 0)
				{
				}
				num = (short)1646002176;
				if (num != 0)
				{
				}
				num = (short)64159744;
				short num3 = num;
				return this.dataProfFeaturesARSRetryTimermin_A7466._HasDiffs;
			}
		}

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x0600AB85 RID: 43909 RVA: 0x009FF49C File Offset: 0x009FD69C
		// (set) Token: 0x0600AB86 RID: 43910 RVA: 0x009FF550 File Offset: 0x009FD750
		public long DataProfFeaturesAutomaticRegistrationServerAddress_A7524Value
		{
			get
			{
				short num = (short)110755841;
				if (num != 0)
				{
				}
				num = (short)879538669;
				short num2 = num;
				num = (short)594850285;
				switch (num2 == num)
				{
				}
				num = (short)329252864;
				if (num != 0)
				{
				}
				num = (short)609026048;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Value;
			}
			set
			{
				short num = (short)1698184575;
				short num2 = num;
				num = (short)1993096575;
				switch (num2 == num)
				{
				}
				num = (short)1678704641;
				if (num != 0)
				{
				}
				num = (short)1410203648;
				if (num != 0)
				{
				}
				num = (short)1062076416;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Value = value;
			}
		}

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x0600AB87 RID: 43911 RVA: 0x009FF608 File Offset: 0x009FD808
		// (set) Token: 0x0600AB88 RID: 43912 RVA: 0x009FF6C4 File Offset: 0x009FD8C4
		public string DataProfFeaturesAutomaticRegistrationServerAddress_A7524_UIValue
		{
			get
			{
				short num = (short)2008966745;
				short num2 = num;
				num = (short)111502937;
				switch (num2 == num)
				{
				}
				num = (short)1395261440;
				if (num != 0)
				{
				}
				num = (short)1609170945;
				if (num != 0)
				{
				}
				num = (short)430637056;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.UIValue;
			}
			set
			{
				short num = (short)1904908446;
				short num2 = num;
				num = (short)1082955934;
				switch (num2 == num)
				{
				}
				num = (short)1688600576;
				if (num != 0)
				{
				}
				num = (short)589824001;
				if (num != 0)
				{
				}
				num = (short)124059648;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.UIValue = value;
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x009FF77C File Offset: 0x009FD97C
		public global::AcpBusinessLayer.AcpIPAddressField DataProfFeaturesAutomaticRegistrationServerAddress_A7524
		{
			get
			{
				short num = (short)133277550;
				short num2 = num;
				num = (short)988129134;
				switch (num2 == num)
				{
				}
				num = (short)586153985;
				if (num != 0)
				{
				}
				num = (short)550895616;
				if (num != 0)
				{
				}
				num = (short)1652555776;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524;
			}
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x009FF82C File Offset: 0x009FDA2C
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x009FF8E0 File Offset: 0x009FDAE0
		public bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_Applicable
		{
			get
			{
				short num = (short)2007369046;
				short num2 = num;
				num = (short)1529283926;
				switch (num2 == num)
				{
				}
				num = (short)679608320;
				if (num != 0)
				{
				}
				num = (short)873529345;
				if (num != 0)
				{
				}
				num = (short)1816068096;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Applicable;
			}
			set
			{
				short num = (short)1334642850;
				short num2 = num;
				num = (short)1868761250;
				switch (num2 == num)
				{
				}
				num = (short)1177616384;
				if (num != 0)
				{
				}
				num = (short)602537985;
				if (num != 0)
				{
				}
				num = (short)619315200;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Applicable = value;
			}
		}

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x009FF998 File Offset: 0x009FDB98
		// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x009FFA4C File Offset: 0x009FDC4C
		public bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_Valid
		{
			get
			{
				short num = (short)1666618709;
				short num2 = num;
				num = (short)899388757;
				switch (num2 == num)
				{
				}
				num = (short)385286144;
				if (num != 0)
				{
				}
				num = (short)1278803969;
				if (num != 0)
				{
				}
				num = (short)1609695232;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Valid;
			}
			set
			{
				short num = (short)618714126;
				short num2 = num;
				num = (short)396940302;
				switch (num2 == num)
				{
				}
				num = (short)2133655553;
				if (num != 0)
				{
				}
				num = (short)968622080;
				if (num != 0)
				{
				}
				num = (short)473497600;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Valid = value;
			}
		}

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x009FFB00 File Offset: 0x009FDD00
		// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x009FFBB4 File Offset: 0x009FDDB4
		public bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_Visible
		{
			get
			{
				short num = (short)1377959937;
				if (num != 0)
				{
				}
				num = (short)1385140955;
				short num2 = num;
				num = (short)1334874843;
				switch (num2 == num)
				{
				}
				num = (short)525926400;
				if (num != 0)
				{
				}
				num = (short)221904896;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Visible;
			}
			set
			{
				short num = (short)2097123479;
				short num2 = num;
				num = (short)1565757591;
				switch (num2 == num)
				{
				}
				num = (short)1342439425;
				if (num != 0)
				{
				}
				num = (short)2132606976;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Visible = value;
			}
		}

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x009FFC6C File Offset: 0x009FDE6C
		// (set) Token: 0x0600AB91 RID: 43921 RVA: 0x009FFD24 File Offset: 0x009FDF24
		public bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_Editable
		{
			get
			{
				short num = (short)1481279381;
				short num2 = num;
				num = (short)850888597;
				switch (num2 == num)
				{
				}
				num = (short)574488577;
				if (num != 0)
				{
				}
				num = (short)2048786432;
				if (num != 0)
				{
				}
				num = (short)1352335360;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Editable;
			}
			set
			{
				short num = (short)944861987;
				short num2 = num;
				num = (short)1133474595;
				switch (num2 == num)
				{
				}
				num = (short)1244332033;
				if (num != 0)
				{
				}
				num = (short)448200704;
				if (num != 0)
				{
				}
				num = (short)1345847296;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.Editable = value;
			}
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x009FFDD8 File Offset: 0x009FDFD8
		internal string DataProfFeaturesAutomaticRegistrationServerAddress_A7524_UILabel
		{
			get
			{
				short num = (short)2020524830;
				short num2 = num;
				num = (short)2053161758;
				switch (num2 == num)
				{
				}
				num = (short)31719425;
				if (num != 0)
				{
				}
				num = (short)1533214720;
				if (num != 0)
				{
				}
				num = (short)478543872;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.UIName;
			}
		}

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x009FFE8C File Offset: 0x009FE08C
		// (set) Token: 0x0600AB94 RID: 43924 RVA: 0x009FFF40 File Offset: 0x009FE140
		internal bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_HiddenStatic
		{
			get
			{
				short num = (short)372106220;
				short num2 = num;
				num = (short)1307042796;
				switch (num2 == num)
				{
				}
				num = (short)704905217;
				if (num != 0)
				{
				}
				num = (short)884473856;
				if (num != 0)
				{
				}
				num = (short)1820983296;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.HiddenStatic;
			}
			set
			{
				short num = (short)725380111;
				short num2 = num;
				num = (short)928082959;
				switch (num2 == num)
				{
				}
				num = (short)659750912;
				if (num != 0)
				{
				}
				num = (short)130613249;
				if (num != 0)
				{
				}
				num = (short)303366144;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.HiddenStatic = value;
			}
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x0600AB95 RID: 43925 RVA: 0x009FFFF4 File Offset: 0x009FE1F4
		// (set) Token: 0x0600AB96 RID: 43926 RVA: 0x00A000A8 File Offset: 0x009FE2A8
		internal bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_HiddenDynamic
		{
			get
			{
				short num = (short)142242376;
				short num2 = num;
				num = (short)106852936;
				switch (num2 == num)
				{
				}
				num = (short)1817051137;
				if (num != 0)
				{
				}
				num = (short)1259929600;
				if (num != 0)
				{
				}
				num = (short)194707456;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.HiddenDynamic;
			}
			set
			{
				short num = (short)1002728627;
				short num2 = num;
				num = (short)583560371;
				switch (num2 == num)
				{
				}
				num = (short)1258684417;
				if (num != 0)
				{
				}
				num = (short)1389297664;
				if (num != 0)
				{
				}
				num = (short)1831403520;
				short num3 = num;
				this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524.HiddenDynamic = value;
			}
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x0600AB97 RID: 43927 RVA: 0x00A0015C File Offset: 0x009FE35C
		public bool DataProfFeaturesAutomaticRegistrationServerAddress_A7524_HasDiffs
		{
			get
			{
				short num = (short)651427841;
				if (num != 0)
				{
				}
				num = (short)2107006174;
				short num2 = num;
				num = (short)391273694;
				switch (num2 == num)
				{
				}
				num = (short)146800640;
				if (num != 0)
				{
				}
				num = (short)1255604224;
				short num3 = num;
				return this.dataProfFeaturesAutomaticRegistrationServerAddress_A7524._HasDiffs;
			}
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x00A00210 File Offset: 0x009FE410
		// (set) Token: 0x0600AB99 RID: 43929 RVA: 0x00A002C8 File Offset: 0x009FE4C8
		public bool DataProfFeaturesTerminalData_A9288Value
		{
			get
			{
				short num = (short)2038968407;
				short num2 = num;
				num = (short)969027671;
				switch (num2 == num)
				{
				}
				num = (short)1472987136;
				if (num != 0)
				{
				}
				num = (short)522846209;
				if (num != 0)
				{
				}
				num = (short)608501760;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Value;
			}
			set
			{
				short num = (short)428251525;
				short num2 = num;
				num = (short)1044486533;
				switch (num2 == num)
				{
				}
				num = (short)873136129;
				if (num != 0)
				{
				}
				num = (short)1064304640;
				if (num != 0)
				{
				}
				num = (short)317390848;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Value = value;
			}
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x00A00380 File Offset: 0x009FE580
		public global::AcpBusinessLayer.AcpField<bool> DataProfFeaturesTerminalData_A9288
		{
			get
			{
				short num = (short)758232469;
				short num2 = num;
				num = (short)796439957;
				switch (num2 == num)
				{
				}
				num = (short)298450944;
				if (num != 0)
				{
				}
				num = (short)1512898561;
				if (num != 0)
				{
				}
				num = (short)2123563008;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288;
			}
		}

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x0600AB9B RID: 43931 RVA: 0x00A00434 File Offset: 0x009FE634
		// (set) Token: 0x0600AB9C RID: 43932 RVA: 0x00A004E8 File Offset: 0x009FE6E8
		public bool DataProfFeaturesTerminalData_A9288_UIValue
		{
			get
			{
				short num = (short)697747885;
				short num2 = num;
				num = (short)1029884333;
				switch (num2 == num)
				{
				}
				num = (short)1093533697;
				if (num != 0)
				{
				}
				num = (short)476381184;
				if (num != 0)
				{
				}
				num = (short)638844928;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Value;
			}
			set
			{
				short num = (short)1215445777;
				short num2 = num;
				num = (short)1498757905;
				switch (num2 == num)
				{
				}
				num = (short)1684275201;
				if (num != 0)
				{
				}
				num = (short)696385536;
				if (num != 0)
				{
				}
				num = (short)1092222976;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Value = value;
			}
		}

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x0600AB9D RID: 43933 RVA: 0x00A005A0 File Offset: 0x009FE7A0
		// (set) Token: 0x0600AB9E RID: 43934 RVA: 0x00A00654 File Offset: 0x009FE854
		public bool DataProfFeaturesTerminalData_A9288_Applicable
		{
			get
			{
				short num = (short)552665089;
				if (num != 0)
				{
				}
				num = (short)10796938;
				short num2 = num;
				num = (short)1927528330;
				switch (num2 == num)
				{
				}
				num = (short)1665269760;
				if (num != 0)
				{
				}
				num = (short)259915776;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Applicable;
			}
			set
			{
				short num = (short)2078033674;
				short num2 = num;
				num = (short)736118538;
				switch (num2 == num)
				{
				}
				num = (short)1146159105;
				if (num != 0)
				{
				}
				num = (short)1779892224;
				if (num != 0)
				{
				}
				num = (short)921239552;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Applicable = value;
			}
		}

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x00A0070C File Offset: 0x009FE90C
		// (set) Token: 0x0600ABA0 RID: 43936 RVA: 0x00A007C0 File Offset: 0x009FE9C0
		public bool DataProfFeaturesTerminalData_A9288_Valid
		{
			get
			{
				short num = (short)187367425;
				if (num != 0)
				{
				}
				num = (short)933975122;
				short num2 = num;
				num = (short)297817170;
				switch (num2 == num)
				{
				}
				num = (short)284295168;
				if (num != 0)
				{
				}
				num = (short)1180368896;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Valid;
			}
			set
			{
				short num = (short)13164828;
				short num2 = num;
				num = (short)565174556;
				switch (num2 == num)
				{
				}
				num = (short)124452864;
				if (num != 0)
				{
				}
				num = (short)140443649;
				if (num != 0)
				{
				}
				num = (short)1551106048;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Valid = value;
			}
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x00A00874 File Offset: 0x009FEA74
		// (set) Token: 0x0600ABA2 RID: 43938 RVA: 0x00A00928 File Offset: 0x009FEB28
		public bool DataProfFeaturesTerminalData_A9288_Visible
		{
			get
			{
				short num = (short)1480636683;
				short num2 = num;
				num = (short)1513404683;
				switch (num2 == num)
				{
				}
				num = (short)1478492160;
				if (num != 0)
				{
				}
				num = (short)1779957761;
				if (num != 0)
				{
				}
				num = (short)599392256;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Visible;
			}
			set
			{
				short num = (short)229141776;
				short num2 = num;
				num = (short)1407085840;
				switch (num2 == num)
				{
				}
				num = (short)1692205057;
				if (num != 0)
				{
				}
				num = (short)2052980736;
				if (num != 0)
				{
				}
				num = (short)623443968;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Visible = value;
			}
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x0600ABA3 RID: 43939 RVA: 0x00A009E0 File Offset: 0x009FEBE0
		// (set) Token: 0x0600ABA4 RID: 43940 RVA: 0x00A00A98 File Offset: 0x009FEC98
		public bool DataProfFeaturesTerminalData_A9288_Editable
		{
			get
			{
				short num = (short)1451491329;
				if (num != 0)
				{
				}
				num = (short)1166035565;
				short num2 = num;
				num = (short)1172130413;
				switch (num2 == num)
				{
				}
				num = (short)105119744;
				if (num != 0)
				{
				}
				num = (short)416088064;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.Editable;
			}
			set
			{
				short num = (short)1901484691;
				short num2 = num;
				num = (short)860117651;
				switch (num2 == num)
				{
				}
				num = (short)2055602177;
				if (num != 0)
				{
				}
				num = (short)1504444416;
				if (num != 0)
				{
				}
				num = (short)2042626048;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.Editable = value;
			}
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x0600ABA5 RID: 43941 RVA: 0x00A00B50 File Offset: 0x009FED50
		internal string DataProfFeaturesTerminalData_A9288_UILabel
		{
			get
			{
				short num = (short)269274103;
				short num2 = num;
				num = (short)1503054839;
				switch (num2 == num)
				{
				}
				num = (short)867434497;
				if (num != 0)
				{
				}
				num = (short)1545732096;
				if (num != 0)
				{
				}
				num = (short)1251540992;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.UIName;
			}
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x00A00C08 File Offset: 0x009FEE08
		// (set) Token: 0x0600ABA7 RID: 43943 RVA: 0x00A00CC0 File Offset: 0x009FEEC0
		internal bool DataProfFeaturesTerminalData_A9288_HiddenStatic
		{
			get
			{
				short num = (short)1051265397;
				short num2 = num;
				num = (short)1092749685;
				switch (num2 == num)
				{
				}
				num = (short)586743808;
				if (num != 0)
				{
				}
				num = (short)88801281;
				if (num != 0)
				{
				}
				num = (short)742785024;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.HiddenStatic;
			}
			set
			{
				short num = (short)1287483865;
				short num2 = num;
				num = (short)1760719321;
				switch (num2 == num)
				{
				}
				num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)1246822400;
				if (num != 0)
				{
				}
				num = (short)551616512;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.HiddenStatic = value;
			}
		}

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x00A00D74 File Offset: 0x009FEF74
		// (set) Token: 0x0600ABA9 RID: 43945 RVA: 0x00A00E2C File Offset: 0x009FF02C
		internal bool DataProfFeaturesTerminalData_A9288_HiddenDynamic
		{
			get
			{
				short num = (short)625264951;
				short num2 = num;
				num = (short)576571703;
				switch (num2 == num)
				{
				}
				num = (short)798294016;
				if (num != 0)
				{
				}
				num = (short)768933889;
				if (num != 0)
				{
				}
				num = (short)1360658432;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288.HiddenDynamic;
			}
			set
			{
				short num = (short)749982189;
				short num2 = num;
				num = (short)814207469;
				switch (num2 == num)
				{
				}
				num = (short)2064252928;
				if (num != 0)
				{
				}
				num = (short)1721040897;
				if (num != 0)
				{
				}
				num = (short)1443102720;
				short num3 = num;
				this.dataProfFeaturesTerminalData_A9288.HiddenDynamic = value;
			}
		}

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x00A00EE4 File Offset: 0x009FF0E4
		public bool DataProfFeaturesTerminalData_A9288_HasDiffs
		{
			get
			{
				short num = (short)2041693796;
				short num2 = num;
				num = (short)802080356;
				switch (num2 == num)
				{
				}
				num = (short)1460928513;
				if (num != 0)
				{
				}
				num = (short)210501632;
				if (num != 0)
				{
				}
				num = (short)1946615808;
				short num3 = num;
				return this.dataProfFeaturesTerminalData_A9288._HasDiffs;
			}
		}

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x00A00F98 File Offset: 0x009FF198
		// (set) Token: 0x0600ABAC RID: 43948 RVA: 0x00A01050 File Offset: 0x009FF250
		public int DatProFeaturesPADMode_A20536Value
		{
			get
			{
				short num = (short)495119524;
				short num2 = num;
				num = (short)8776868;
				switch (num2 == num)
				{
				}
				num = (short)141623297;
				if (num != 0)
				{
				}
				num = (short)1860501504;
				if (num != 0)
				{
				}
				num = (short)48365568;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.Value;
			}
			set
			{
				short num = (short)1495815638;
				short num2 = num;
				num = (short)1651987926;
				switch (num2 == num)
				{
				}
				num = (short)1300889600;
				if (num != 0)
				{
				}
				num = (short)1707802625;
				if (num != 0)
				{
				}
				num = (short)1968701440;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.Value = value;
			}
		}

		// Token: 0x170055EF RID: 21999
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x00A01104 File Offset: 0x009FF304
		// (set) Token: 0x0600ABAE RID: 43950 RVA: 0x00A011B8 File Offset: 0x009FF3B8
		public string DatProFeaturesPADMode_A20536_UIValue
		{
			get
			{
				short num = (short)1764785160;
				short num2 = num;
				num = (short)309951496;
				switch (num2 == num)
				{
				}
				num = (short)170196993;
				if (num != 0)
				{
				}
				num = (short)1685258240;
				if (num != 0)
				{
				}
				num = (short)1930493952;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.UIValue;
			}
			set
			{
				short num = (short)2092399772;
				short num2 = num;
				num = (short)376339612;
				switch (num2 == num)
				{
				}
				num = (short)1520893953;
				if (num != 0)
				{
				}
				num = (short)1649737728;
				if (num != 0)
				{
				}
				num = (short)309854208;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.UIValue = value;
			}
		}

		// Token: 0x170055F0 RID: 22000
		// (get) Token: 0x0600ABAF RID: 43951 RVA: 0x00A01270 File Offset: 0x009FF470
		public global::AcpBusinessLayer.AcpListField DatProFeaturesPADMode_A20536
		{
			get
			{
				short num = (short)767648534;
				short num2 = num;
				num = (short)555967254;
				switch (num2 == num)
				{
				}
				num = (short)160825344;
				if (num != 0)
				{
				}
				num = (short)2024079361;
				if (num != 0)
				{
				}
				num = (short)637861888;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536;
			}
		}

		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x0600ABB0 RID: 43952 RVA: 0x00A01320 File Offset: 0x009FF520
		// (set) Token: 0x0600ABB1 RID: 43953 RVA: 0x00A013D4 File Offset: 0x009FF5D4
		public bool DatProFeaturesPADMode_A20536_Applicable
		{
			get
			{
				short num = (short)1193738241;
				if (num != 0)
				{
				}
				num = (short)75165840;
				short num2 = num;
				num = (short)1819406480;
				switch (num2 == num)
				{
				}
				num = (short)158138368;
				if (num != 0)
				{
				}
				num = (short)1177681920;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.Applicable;
			}
			set
			{
				short num = (short)1593311233;
				if (num != 0)
				{
				}
				num = (short)152103354;
				short num2 = num;
				num = (short)733407674;
				switch (num2 == num)
				{
				}
				num = (short)467206144;
				if (num != 0)
				{
				}
				num = (short)1836253184;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.Applicable = value;
			}
		}

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x0600ABB2 RID: 43954 RVA: 0x00A0148C File Offset: 0x009FF68C
		// (set) Token: 0x0600ABB3 RID: 43955 RVA: 0x00A01540 File Offset: 0x009FF740
		public bool DatProFeaturesPADMode_A20536_Valid
		{
			get
			{
				short num = (short)948109313;
				if (num != 0)
				{
				}
				num = (short)804684712;
				short num2 = num;
				num = (short)416580520;
				switch (num2 == num)
				{
				}
				num = (short)1326579712;
				if (num != 0)
				{
				}
				num = (short)1802764288;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.Valid;
			}
			set
			{
				short num = (short)713503680;
				short num2 = num;
				num = (short)2101949376;
				switch (num2 == num)
				{
				}
				num = (short)1618411520;
				if (num != 0)
				{
				}
				num = (short)1036517377;
				if (num != 0)
				{
				}
				num = (short)597688320;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.Valid = value;
			}
		}

		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x0600ABB4 RID: 43956 RVA: 0x00A015FC File Offset: 0x009FF7FC
		// (set) Token: 0x0600ABB5 RID: 43957 RVA: 0x00A016B4 File Offset: 0x009FF8B4
		public bool DatProFeaturesPADMode_A20536_Visible
		{
			get
			{
				short num = (short)159675747;
				short num2 = num;
				num = (short)1104311651;
				switch (num2 == num)
				{
				}
				num = (short)1810432001;
				if (num != 0)
				{
				}
				num = (short)1132527616;
				if (num != 0)
				{
				}
				num = (short)716963840;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.Visible;
			}
			set
			{
				short num = (short)1203724557;
				short num2 = num;
				num = (short)631529741;
				switch (num2 == num)
				{
				}
				num = (short)1746534400;
				if (num != 0)
				{
				}
				num = (short)1113522177;
				if (num != 0)
				{
				}
				num = (short)671154176;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.Visible = value;
			}
		}

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x0600ABB6 RID: 43958 RVA: 0x00A01768 File Offset: 0x009FF968
		// (set) Token: 0x0600ABB7 RID: 43959 RVA: 0x00A0181C File Offset: 0x009FFA1C
		public bool DatProFeaturesPADMode_A20536_Editable
		{
			get
			{
				short num = (short)1778214103;
				short num2 = num;
				num = (short)1480680663;
				switch (num2 == num)
				{
				}
				num = (short)2111766529;
				if (num != 0)
				{
				}
				num = (short)336658432;
				if (num != 0)
				{
				}
				num = (short)1808859136;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.Editable;
			}
			set
			{
				short num = (short)1783431169;
				if (num != 0)
				{
				}
				num = (short)625921563;
				short num2 = num;
				num = (short)896978459;
				switch (num2 == num)
				{
				}
				num = (short)843186176;
				if (num != 0)
				{
				}
				num = (short)630980608;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.Editable = value;
			}
		}

		// Token: 0x170055F5 RID: 22005
		// (get) Token: 0x0600ABB8 RID: 43960 RVA: 0x00A018D0 File Offset: 0x009FFAD0
		internal string DatProFeaturesPADMode_A20536_UILabel
		{
			get
			{
				short num = (short)208470017;
				if (num != 0)
				{
				}
				num = (short)997252115;
				short num2 = num;
				num = (short)664001555;
				switch (num2 == num)
				{
				}
				num = (short)1681326080;
				if (num != 0)
				{
				}
				num = (short)255197184;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.UIName;
			}
		}

		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x0600ABB9 RID: 43961 RVA: 0x00A01988 File Offset: 0x009FFB88
		// (set) Token: 0x0600ABBA RID: 43962 RVA: 0x00A01A40 File Offset: 0x009FFC40
		internal bool DatProFeaturesPADMode_A20536_HiddenStatic
		{
			get
			{
				short num = (short)416901929;
				short num2 = num;
				num = (short)1108110121;
				switch (num2 == num)
				{
				}
				num = (short)1547108353;
				if (num != 0)
				{
				}
				num = (short)1130823680;
				if (num != 0)
				{
				}
				num = (short)1194065920;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.HiddenStatic;
			}
			set
			{
				short num = (short)1403243892;
				short num2 = num;
				num = (short)1984286068;
				switch (num2 == num)
				{
				}
				num = (short)717815808;
				if (num != 0)
				{
				}
				num = (short)910950401;
				if (num != 0)
				{
				}
				num = (short)132644864;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.HiddenStatic = value;
			}
		}

		// Token: 0x170055F7 RID: 22007
		// (get) Token: 0x0600ABBB RID: 43963 RVA: 0x00A01AF8 File Offset: 0x009FFCF8
		// (set) Token: 0x0600ABBC RID: 43964 RVA: 0x00A01BB0 File Offset: 0x009FFDB0
		internal bool DatProFeaturesPADMode_A20536_HiddenDynamic
		{
			get
			{
				short num = (short)626314695;
				short num2 = num;
				num = (short)1501810119;
				switch (num2 == num)
				{
				}
				num = (short)2102001664;
				if (num != 0)
				{
				}
				num = (short)1320681473;
				if (num != 0)
				{
				}
				num = (short)2098528256;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536.HiddenDynamic;
			}
			set
			{
				short num = (short)1303379032;
				short num2 = num;
				num = (short)2133261400;
				switch (num2 == num)
				{
				}
				num = (short)32833537;
				if (num != 0)
				{
				}
				num = (short)974520320;
				if (num != 0)
				{
				}
				num = (short)474546176;
				short num3 = num;
				this.datProFeaturesPADMode_A20536.HiddenDynamic = value;
			}
		}

		// Token: 0x170055F8 RID: 22008
		// (get) Token: 0x0600ABBD RID: 43965 RVA: 0x00A01C64 File Offset: 0x009FFE64
		public bool DatProFeaturesPADMode_A20536_HasDiffs
		{
			get
			{
				short num = (short)1722810369;
				if (num != 0)
				{
				}
				num = (short)649950161;
				short num2 = num;
				num = (short)1164080081;
				switch (num2 == num)
				{
				}
				num = (short)661651456;
				if (num != 0)
				{
				}
				num = (short)73793536;
				short num3 = num;
				return this.datProFeaturesPADMode_A20536._HasDiffs;
			}
		}

		// Token: 0x170055F9 RID: 22009
		// (get) Token: 0x0600ABBE RID: 43966 RVA: 0x00A01D18 File Offset: 0x009FFF18
		// (set) Token: 0x0600ABBF RID: 43967 RVA: 0x00A01DCC File Offset: 0x009FFFCC
		public string DatProFeaturesStartSequence_A20537Value
		{
			get
			{
				short num = (short)416492359;
				short num2 = num;
				num = (short)1956457287;
				switch (num2 == num)
				{
				}
				num = (short)875495425;
				if (num != 0)
				{
				}
				num = (short)329252864;
				if (num != 0)
				{
				}
				num = (short)1329397760;
				short num3 = num;
				return this.datProFeaturesStartSequence_A20537.Value;
			}
			set
			{
				short num = (short)900389140;
				short num2 = num;
				num = (short)1085266196;
				switch (num2 == num)
				{
				}
				num = (short)1215692801;
				if (num != 0)
				{
				}
				num = (short)326500352;
				if (num != 0)
				{
				}
				num = (short)82903040;
				short num3 = num;
				this.datProFeaturesStartSequence_A20537.Value = value;
			}
		}

		// Token: 0x170055FA RID: 22010
		// (get) Token: 0x0600ABC0 RID: 43968 RVA: 0x00A01E80 File Offset: 0x00A00080
		public global::AcpBusinessLayer.AcpField<string> DatProFeaturesStartSequence_A20537
		{
			get
			{
				short num = (short)616128611;
				short num2 = num;
				num = (short)1997496419;
				switch (num2 == num)
				{
				}
				num = (short)1617756160;
				if (num != 0)
				{
				}
				num = (short)1826947073;
				if (num != 0)
				{
				}
				num = (short)617807872;
				short num3 = num;
				return this.datProFeaturesStartSequence_A20537;
			}
		}

		// Token: 0x170055FB RID: 22011
		// (get) Token: 0x0600ABC1 RID: 43969 RVA: 0x00A01F30 File Offset: 0x00A00130
		// (set) Token: 0x0600ABC2 RID: 43970 RVA: 0x00A01FE8 File Offset: 0x00A001E8
		public string DatProFeaturesStartSequence_A20537_UIValue
		{
			get
			{
				short num = (short)1979822339;
				short num2 = num;
				num = (short)1102426371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)775356416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082275328;
				if (num != 0)
				{
				}
				num = (short)833880065;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.Value;
			}
			set
			{
				short num = (short)568731525;
				short num2 = num;
				num = (short)1158358917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458948608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270139393;
				if (num != 0)
				{
				}
				num = (short)1139867648;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.Value = value;
			}
		}

		// Token: 0x170055FC RID: 22012
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x00A020A0 File Offset: 0x00A002A0
		// (set) Token: 0x0600ABC4 RID: 43972 RVA: 0x00A02154 File Offset: 0x00A00354
		public bool DatProFeaturesStartSequence_A20537_Applicable
		{
			get
			{
				short num = (short)696385537;
				if (num != 0)
				{
				}
				num = (short)488308736;
				short num2 = num;
				num = (short)1572527178;
				short num3 = num;
				num = (short)2067848266;
				switch (num3 == num)
				{
				}
				num = (short)297205760;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.Applicable;
			}
			set
			{
				short num = (short)1878288125;
				short num2 = num;
				num = (short)651519741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1759772672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)242417665;
				if (num != 0)
				{
				}
				num = (short)321519616;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.Applicable = value;
			}
		}

		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x00A0220C File Offset: 0x00A0040C
		// (set) Token: 0x0600ABC6 RID: 43974 RVA: 0x00A022C4 File Offset: 0x00A004C4
		public bool DatProFeaturesStartSequence_A20537_Valid
		{
			get
			{
				short num = (short)1873477633;
				if (num != 0)
				{
				}
				num = (short)202047488;
				short num2 = num;
				num = (short)1796032622;
				short num3 = num;
				num = (short)1671579758;
				switch (num3 == num)
				{
				}
				num = (short)1413545984;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.Valid;
			}
			set
			{
				short num = (short)488846852;
				short num2 = num;
				num = (short)1840723460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)48365568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1274085377;
				if (num != 0)
				{
				}
				num = (short)903151616;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.Valid = value;
			}
		}

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x00A02378 File Offset: 0x00A00578
		// (set) Token: 0x0600ABC8 RID: 43976 RVA: 0x00A0242C File Offset: 0x00A0062C
		public bool DatProFeaturesStartSequence_A20537_Visible
		{
			get
			{
				short num = (short)1046592414;
				short num2 = num;
				num = (short)2108996510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195704320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979056128;
				if (num != 0)
				{
				}
				num = (short)1596588033;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.Visible;
			}
			set
			{
				short num = (short)1154181550;
				short num2 = num;
				num = (short)872835502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097596928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970522625;
				if (num != 0)
				{
				}
				num = (short)1852768256;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.Visible = value;
			}
		}

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x0600ABC9 RID: 43977 RVA: 0x00A024E0 File Offset: 0x00A006E0
		// (set) Token: 0x0600ABCA RID: 43978 RVA: 0x00A02598 File Offset: 0x00A00798
		public bool DatProFeaturesStartSequence_A20537_Editable
		{
			get
			{
				short num = (short)1281642820;
				short num2 = num;
				num = (short)2113294660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)160890880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229638144;
				if (num != 0)
				{
				}
				num = (short)696778753;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.Editable;
			}
			set
			{
				short num = (short)2024544948;
				short num2 = num;
				num = (short)631642804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2076966912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543948800;
				if (num != 0)
				{
				}
				num = (short)1972830209;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.Editable = value;
			}
		}

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x0600ABCB RID: 43979 RVA: 0x00A02650 File Offset: 0x00A00850
		internal string DatProFeaturesStartSequence_A20537_UILabel
		{
			get
			{
				short num = (short)247896610;
				short num2 = num;
				num = (short)1474927138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525874688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696647680;
				if (num != 0)
				{
				}
				num = (short)1832648705;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.UIName;
			}
		}

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x00A02704 File Offset: 0x00A00904
		// (set) Token: 0x0600ABCD RID: 43981 RVA: 0x00A027BC File Offset: 0x00A009BC
		internal bool DatProFeaturesStartSequence_A20537_HiddenStatic
		{
			get
			{
				short num = (short)1105832932;
				short num2 = num;
				num = (short)397781988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292828672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970719233;
				if (num != 0)
				{
				}
				num = (short)1268645888;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.HiddenStatic;
			}
			set
			{
				short num = (short)948207631;
				short num2 = num;
				num = (short)1363836943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242038272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642514945;
				if (num != 0)
				{
				}
				num = (short)1565458432;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.HiddenStatic = value;
			}
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x0600ABCE RID: 43982 RVA: 0x00A02870 File Offset: 0x00A00A70
		// (set) Token: 0x0600ABCF RID: 43983 RVA: 0x00A02924 File Offset: 0x00A00B24
		internal bool DatProFeaturesStartSequence_A20537_HiddenDynamic
		{
			get
			{
				short num = (short)1306656769;
				if (num != 0)
				{
				}
				num = (short)1364328448;
				short num2 = num;
				num = (short)1539639048;
				short num3 = num;
				num = (short)1241450248;
				switch (num3 == num)
				{
				}
				num = (short)1618214912;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537.HiddenDynamic;
			}
			set
			{
				short num = (short)579384398;
				short num2 = num;
				num = (short)1281209422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88670208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2042822657;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				if (num != 0)
				{
				}
				this.datProFeaturesStartSequence_A20537.HiddenDynamic = value;
			}
		}

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x0600ABD0 RID: 43984 RVA: 0x00A029D8 File Offset: 0x00A00BD8
		public bool DatProFeaturesStartSequence_A20537_HasDiffs
		{
			get
			{
				short num = (short)1768430825;
				short num2 = num;
				num = (short)2138119401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2137260032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900675073;
				if (num != 0)
				{
				}
				num = (short)16842752;
				if (num != 0)
				{
				}
				return this.datProFeaturesStartSequence_A20537._HasDiffs;
			}
		}

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x0600ABD1 RID: 43985 RVA: 0x00A02A8C File Offset: 0x00A00C8C
		// (set) Token: 0x0600ABD2 RID: 43986 RVA: 0x00A02B44 File Offset: 0x00A00D44
		public string DatProFeaturesStopSequence_A20538Value
		{
			get
			{
				short num = (short)1842238078;
				short num2 = num;
				num = (short)1243632254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10354688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863371264;
				if (num != 0)
				{
				}
				num = (short)810876929;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Value;
			}
			set
			{
				short num = (short)470472989;
				short num2 = num;
				num = (short)1429330205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709558272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844234753;
				if (num != 0)
				{
				}
				num = (short)346947584;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Value = value;
			}
		}

		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x0600ABD3 RID: 43987 RVA: 0x00A02BF8 File Offset: 0x00A00DF8
		public global::AcpBusinessLayer.AcpField<string> DatProFeaturesStopSequence_A20538
		{
			get
			{
				short num = (short)1090933079;
				short num2 = num;
				num = (short)1642025303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620115456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492451329;
				if (num != 0)
				{
				}
				num = (short)1982005248;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538;
			}
		}

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x00A02CA8 File Offset: 0x00A00EA8
		// (set) Token: 0x0600ABD5 RID: 43989 RVA: 0x00A02D5C File Offset: 0x00A00F5C
		public string DatProFeaturesStopSequence_A20538_UIValue
		{
			get
			{
				short num = (short)2116878337;
				if (num != 0)
				{
				}
				num = (short)1265172480;
				short num2 = num;
				num = (short)52378593;
				short num3 = num;
				num = (short)1046821857;
				switch (num3 == num)
				{
				}
				num = (short)265814016;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Value;
			}
			set
			{
				short num = (short)286921546;
				short num2 = num;
				num = (short)740889418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)269615104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319501825;
				if (num != 0)
				{
				}
				num = (short)197918720;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Value = value;
			}
		}

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x00A02E14 File Offset: 0x00A01014
		// (set) Token: 0x0600ABD7 RID: 43991 RVA: 0x00A02EC8 File Offset: 0x00A010C8
		public bool DatProFeaturesStopSequence_A20538_Applicable
		{
			get
			{
				short num = (short)2137186031;
				short num2 = num;
				num = (short)157015791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)785186816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938227201;
				if (num != 0)
				{
				}
				num = (short)908918784;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Applicable;
			}
			set
			{
				short num = (short)591265793;
				if (num != 0)
				{
				}
				num = (short)1521090560;
				short num2 = num;
				num = (short)1622441999;
				short num3 = num;
				num = (short)1522106383;
				switch (num3 == num)
				{
				}
				num = (short)158990336;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Applicable = value;
			}
		}

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x0600ABD8 RID: 43992 RVA: 0x00A02F80 File Offset: 0x00A01180
		// (set) Token: 0x0600ABD9 RID: 43993 RVA: 0x00A03034 File Offset: 0x00A01234
		public bool DatProFeaturesStopSequence_A20538_Valid
		{
			get
			{
				short num = (short)1598313523;
				short num2 = num;
				num = (short)127226931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713555968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357105665;
				if (num != 0)
				{
				}
				num = (short)821690368;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Valid;
			}
			set
			{
				short num = (short)177405953;
				if (num != 0)
				{
				}
				num = (short)1818689536;
				short num2 = num;
				num = (short)638557940;
				short num3 = num;
				num = (short)59809524;
				switch (num3 == num)
				{
				}
				num = (short)371982336;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Valid = value;
			}
		}

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x00A030E8 File Offset: 0x00A012E8
		// (set) Token: 0x0600ABDB RID: 43995 RVA: 0x00A0319C File Offset: 0x00A0139C
		public bool DatProFeaturesStopSequence_A20538_Visible
		{
			get
			{
				short num = (short)1142554625;
				if (num != 0)
				{
				}
				num = (short)1787691008;
				short num2 = num;
				num = (short)404188761;
				short num3 = num;
				num = (short)1476685401;
				switch (num3 == num)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Visible;
			}
			set
			{
				short num = (short)1782771561;
				short num2 = num;
				num = (short)1683353449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588133888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)598147073;
				if (num != 0)
				{
				}
				num = (short)353173504;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Visible = value;
			}
		}

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x00A03250 File Offset: 0x00A01450
		// (set) Token: 0x0600ABDD RID: 43997 RVA: 0x00A03304 File Offset: 0x00A01504
		public bool DatProFeaturesStopSequence_A20538_Editable
		{
			get
			{
				short num = (short)426507907;
				short num2 = num;
				num = (short)1674378883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)317521920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1221656576;
				if (num != 0)
				{
				}
				num = (short)1911160833;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.Editable;
			}
			set
			{
				short num = (short)1471429549;
				short num2 = num;
				num = (short)714226605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1555955712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1881473024;
				if (num != 0)
				{
				}
				num = (short)487063553;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.Editable = value;
			}
		}

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x00A033BC File Offset: 0x00A015BC
		internal string DatProFeaturesStopSequence_A20538_UILabel
		{
			get
			{
				short num = (short)804913153;
				if (num != 0)
				{
				}
				num = (short)1810169856;
				short num2 = num;
				num = (short)1959949697;
				short num3 = num;
				num = (short)1366783361;
				switch (num3 == num)
				{
				}
				num = (short)402784256;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.UIName;
			}
		}

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x00A03470 File Offset: 0x00A01670
		// (set) Token: 0x0600ABE0 RID: 44000 RVA: 0x00A03524 File Offset: 0x00A01724
		internal bool DatProFeaturesStopSequence_A20538_HiddenStatic
		{
			get
			{
				short num = (short)1982223718;
				short num2 = num;
				num = (short)1356027238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359006208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619315200;
				if (num != 0)
				{
				}
				num = (short)225640449;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.HiddenStatic;
			}
			set
			{
				short num = (short)1056024229;
				short num2 = num;
				num = (short)1240704677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495465984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)432144384;
				if (num != 0)
				{
				}
				num = (short)836894721;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.HiddenStatic = value;
			}
		}

		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x00A035DC File Offset: 0x00A017DC
		// (set) Token: 0x0600ABE2 RID: 44002 RVA: 0x00A03690 File Offset: 0x00A01890
		internal bool DatProFeaturesStopSequence_A20538_HiddenDynamic
		{
			get
			{
				short num = (short)1809902928;
				short num2 = num;
				num = (short)1271786832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992346112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861746689;
				if (num != 0)
				{
				}
				num = (short)1631322112;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538.HiddenDynamic;
			}
			set
			{
				short num = (short)837323840;
				short num2 = num;
				num = (short)1124174912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721813504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765343233;
				if (num != 0)
				{
				}
				num = (short)663945216;
				if (num != 0)
				{
				}
				this.datProFeaturesStopSequence_A20538.HiddenDynamic = value;
			}
		}

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x0600ABE3 RID: 44003 RVA: 0x00A03744 File Offset: 0x00A01944
		public bool DatProFeaturesStopSequence_A20538_HasDiffs
		{
			get
			{
				short num = (short)549168338;
				short num2 = num;
				num = (short)1020437714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954728448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552337409;
				if (num != 0)
				{
				}
				num = (short)1611857920;
				if (num != 0)
				{
				}
				return this.datProFeaturesStopSequence_A20538._HasDiffs;
			}
		}

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x00A037F8 File Offset: 0x00A019F8
		// (set) Token: 0x0600ABE5 RID: 44005 RVA: 0x00A038AC File Offset: 0x00A01AAC
		public string DatProFeaturesEscapeSequence_A20539Value
		{
			get
			{
				short num = (short)1737446530;
				short num2 = num;
				num = (short)2108052610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401866752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393543680;
				if (num != 0)
				{
				}
				num = (short)983105537;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Value;
			}
			set
			{
				short num = (short)1078698066;
				short num2 = num;
				num = (short)1165795410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)614137856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023016961;
				if (num != 0)
				{
				}
				num = (short)425656320;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Value = value;
			}
		}

		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x0600ABE6 RID: 44006 RVA: 0x00A03964 File Offset: 0x00A01B64
		public global::AcpBusinessLayer.AcpField<string> DatProFeaturesEscapeSequence_A20539
		{
			get
			{
				short num = (short)907213849;
				short num2 = num;
				num = (short)1452866585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421279232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729415681;
				if (num != 0)
				{
				}
				num = (short)60096512;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539;
			}
		}

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x0600ABE7 RID: 44007 RVA: 0x00A03A14 File Offset: 0x00A01C14
		// (set) Token: 0x0600ABE8 RID: 44008 RVA: 0x00A03AC8 File Offset: 0x00A01CC8
		public string DatProFeaturesEscapeSequence_A20539_UIValue
		{
			get
			{
				short num = (short)672507937;
				short num2 = num;
				num = (short)240166945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113587712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209335808;
				if (num != 0)
				{
				}
				num = (short)1874591745;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Value;
			}
			set
			{
				short num = (short)154973110;
				short num2 = num;
				num = (short)987083702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015742464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725628416;
				if (num != 0)
				{
				}
				num = (short)1640497153;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Value = value;
			}
		}

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x00A03B7C File Offset: 0x00A01D7C
		// (set) Token: 0x0600ABEA RID: 44010 RVA: 0x00A03C2C File Offset: 0x00A01E2C
		public bool DatProFeaturesEscapeSequence_A20539_Applicable
		{
			get
			{
				short num = (short)455198730;
				short num2 = num;
				num = (short)1512097802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533790720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895628801;
				if (num != 0)
				{
				}
				num = (short)1731133440;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Applicable;
			}
			set
			{
				short num = (short)680446482;
				short num2 = num;
				num = (short)1914292754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637665280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)864354305;
				if (num != 0)
				{
				}
				num = (short)453574656;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Applicable = value;
			}
		}

		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x0600ABEB RID: 44011 RVA: 0x00A03CE0 File Offset: 0x00A01EE0
		// (set) Token: 0x0600ABEC RID: 44012 RVA: 0x00A03D94 File Offset: 0x00A01F94
		public bool DatProFeaturesEscapeSequence_A20539_Valid
		{
			get
			{
				short num = (short)1787175966;
				short num2 = num;
				num = (short)2131698718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1144651776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1511653377;
				if (num != 0)
				{
				}
				num = (short)337707008;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Valid;
			}
			set
			{
				short num = (short)1520780888;
				short num2 = num;
				num = (short)2050836056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407582208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1362624512;
				if (num != 0)
				{
				}
				num = (short)784793601;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Valid = value;
			}
		}

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x0600ABED RID: 44013 RVA: 0x00A03E48 File Offset: 0x00A02048
		// (set) Token: 0x0600ABEE RID: 44014 RVA: 0x00A03EFC File Offset: 0x00A020FC
		public bool DatProFeaturesEscapeSequence_A20539_Visible
		{
			get
			{
				short num = (short)1802488501;
				short num2 = num;
				num = (short)351652533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499463680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1113260033;
				if (num != 0)
				{
				}
				num = (short)1004077056;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Visible;
			}
			set
			{
				short num = (short)934748727;
				short num2 = num;
				num = (short)1384522295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184825344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1516896256;
				if (num != 0)
				{
				}
				num = (short)297992193;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Visible = value;
			}
		}

		// Token: 0x17005615 RID: 22037
		// (get) Token: 0x0600ABEF RID: 44015 RVA: 0x00A03FB0 File Offset: 0x00A021B0
		// (set) Token: 0x0600ABF0 RID: 44016 RVA: 0x00A04064 File Offset: 0x00A02264
		public bool DatProFeaturesEscapeSequence_A20539_Editable
		{
			get
			{
				short num = (short)1526422532;
				short num2 = num;
				num = (short)1990745092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)345636864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)462946304;
				if (num != 0)
				{
				}
				num = (short)989921281;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.Editable;
			}
			set
			{
				short num = (short)451830817;
				short num2 = num;
				num = (short)1850827809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514654208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328138753;
				if (num != 0)
				{
				}
				num = (short)1043070976;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.Editable = value;
			}
		}

		// Token: 0x17005616 RID: 22038
		// (get) Token: 0x0600ABF1 RID: 44017 RVA: 0x00A04118 File Offset: 0x00A02318
		internal string DatProFeaturesEscapeSequence_A20539_UILabel
		{
			get
			{
				short num = (short)824377345;
				if (num != 0)
				{
				}
				num = (short)1533607936;
				short num2 = num;
				num = (short)325392677;
				short num3 = num;
				num = (short)1632901413;
				switch (num3 == num)
				{
				}
				num = (short)1719205888;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.UIName;
			}
		}

		// Token: 0x17005617 RID: 22039
		// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x00A041D0 File Offset: 0x00A023D0
		// (set) Token: 0x0600ABF3 RID: 44019 RVA: 0x00A04284 File Offset: 0x00A02484
		internal bool DatProFeaturesEscapeSequence_A20539_HiddenStatic
		{
			get
			{
				short num = (short)585347294;
				short num2 = num;
				num = (short)810856670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317339136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262145;
				if (num != 0)
				{
				}
				num = (short)1182990336;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.HiddenStatic;
			}
			set
			{
				short num = (short)410757593;
				short num2 = num;
				num = (short)2137106905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980039168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832438273;
				if (num != 0)
				{
				}
				num = (short)999686144;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.HiddenStatic = value;
			}
		}

		// Token: 0x17005618 RID: 22040
		// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x00A04338 File Offset: 0x00A02538
		// (set) Token: 0x0600ABF5 RID: 44021 RVA: 0x00A043F0 File Offset: 0x00A025F0
		internal bool DatProFeaturesEscapeSequence_A20539_HiddenDynamic
		{
			get
			{
				short num = (short)752327348;
				short num2 = num;
				num = (short)1471847092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387659264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1807482881;
				if (num != 0)
				{
				}
				num = (short)1341390848;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539.HiddenDynamic;
			}
			set
			{
				short num = (short)1012324848;
				short num2 = num;
				num = (short)1193269744;
				switch (num2 == num)
				{
				}
				num = (short)186646529;
				if (num != 0)
				{
				}
				num = (short)1047986176;
				short num3 = num;
				num = (short)311296000;
				if (num != 0)
				{
				}
				this.datProFeaturesEscapeSequence_A20539.HiddenDynamic = value;
			}
		}

		// Token: 0x17005619 RID: 22041
		// (get) Token: 0x0600ABF6 RID: 44022 RVA: 0x00A044A8 File Offset: 0x00A026A8
		public bool DatProFeaturesEscapeSequence_A20539_HasDiffs
		{
			get
			{
				short num = (short)1516936498;
				short num2 = num;
				num = (short)700554546;
				switch (num2 == num)
				{
				}
				num = (short)1075445761;
				if (num != 0)
				{
				}
				num = (short)1937309696;
				short num3 = num;
				num = (short)1196818432;
				if (num != 0)
				{
				}
				return this.datProFeaturesEscapeSequence_A20539._HasDiffs;
			}
		}

		// Token: 0x1700561A RID: 22042
		// (get) Token: 0x0600ABF7 RID: 44023 RVA: 0x00A0455C File Offset: 0x00A0275C
		// (set) Token: 0x0600ABF8 RID: 44024 RVA: 0x00A04610 File Offset: 0x00A02810
		public int DatProFeaturesReceiveIdleTimeOut_A20540Value
		{
			get
			{
				short num = (short)786320665;
				short num2 = num;
				num = (short)214060313;
				switch (num2 == num)
				{
				}
				num = (short)1966866433;
				if (num != 0)
				{
				}
				num = (short)777322496;
				short num3 = num;
				num = (short)521404416;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Value;
			}
			set
			{
				short num = (short)923652627;
				short num2 = num;
				num = (short)1048826387;
				switch (num2 == num)
				{
				}
				num = (short)1027735553;
				if (num != 0)
				{
				}
				num = (short)1609760768;
				short num3 = num;
				num = (short)1632632832;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Value = value;
			}
		}

		// Token: 0x1700561B RID: 22043
		// (get) Token: 0x0600ABF9 RID: 44025 RVA: 0x00A046C4 File Offset: 0x00A028C4
		public global::AcpBusinessLayer.AcpRangeField<int, string> DatProFeaturesReceiveIdleTimeOut_A20540
		{
			get
			{
				short num = (short)1420886017;
				if (num != 0)
				{
				}
				num = (short)792307574;
				short num2 = num;
				num = (short)1783539574;
				switch (num2 == num)
				{
				}
				num = (short)1250361344;
				short num3 = num;
				num = (short)1298661376;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540;
			}
		}

		// Token: 0x1700561C RID: 22044
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x00A04774 File Offset: 0x00A02974
		// (set) Token: 0x0600ABFB RID: 44027 RVA: 0x00A04828 File Offset: 0x00A02A28
		public string DatProFeaturesReceiveIdleTimeOut_A20540_UIValue
		{
			get
			{
				short num = (short)74352662;
				short num2 = num;
				num = (short)2021623830;
				switch (num2 == num)
				{
				}
				num = (short)1456799745;
				if (num != 0)
				{
				}
				num = (short)2094333952;
				short num3 = num;
				num = (short)890044416;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.UIValue;
			}
			set
			{
				short num = (short)385468425;
				short num2 = num;
				num = (short)1769654281;
				switch (num2 == num)
				{
				}
				num = (short)1949368321;
				if (num != 0)
				{
				}
				num = (short)419627008;
				short num3 = num;
				num = (short)174063616;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.UIValue = value;
			}
		}

		// Token: 0x1700561D RID: 22045
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x00A048DC File Offset: 0x00A02ADC
		// (set) Token: 0x0600ABFD RID: 44029 RVA: 0x00A04994 File Offset: 0x00A02B94
		internal int DatProFeaturesReceiveIdleTimeOut_A20540Min
		{
			get
			{
				short num = (short)1150943233;
				if (num != 0)
				{
				}
				num = (short)486398484;
				short num2 = num;
				num = (short)709351956;
				switch (num2 == num)
				{
				}
				num = (short)1193017344;
				short num3 = num;
				num = (short)1485242368;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Min;
			}
			set
			{
				short num = (short)127944346;
				short num2 = num;
				num = (short)1904690842;
				switch (num2 == num)
				{
				}
				num = (short)1278017537;
				if (num != 0)
				{
				}
				num = (short)1438121984;
				short num3 = num;
				num = (short)1299513344;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Min = value;
			}
		}

		// Token: 0x1700561E RID: 22046
		// (get) Token: 0x0600ABFE RID: 44030 RVA: 0x00A04A48 File Offset: 0x00A02C48
		// (set) Token: 0x0600ABFF RID: 44031 RVA: 0x00A04AFC File Offset: 0x00A02CFC
		internal int DatProFeaturesReceiveIdleTimeOut_A20540Max
		{
			get
			{
				short num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)1682029851;
				short num2 = num;
				num = (short)13548827;
				switch (num2 == num)
				{
				}
				num = (short)1239154688;
				short num3 = num;
				num = (short)1949106176;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Max;
			}
			set
			{
				short num = (short)797715968;
				short num2 = num;
				num = (short)1558326784;
				switch (num2 == num)
				{
				}
				num = (short)1251803136;
				if (num != 0)
				{
				}
				num = (short)2137325568;
				short num3 = num;
				num = (short)300351489;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Max = value;
			}
		}

		// Token: 0x1700561F RID: 22047
		// (get) Token: 0x0600AC00 RID: 44032 RVA: 0x00A04BB0 File Offset: 0x00A02DB0
		// (set) Token: 0x0600AC01 RID: 44033 RVA: 0x00A04C68 File Offset: 0x00A02E68
		internal int DatProFeaturesReceiveIdleTimeOut_A20540Step
		{
			get
			{
				short num = (short)1551424450;
				short num2 = num;
				num = (short)1957551042;
				switch (num2 == num)
				{
				}
				num = (short)1318125568;
				if (num != 0)
				{
				}
				num = (short)1897922560;
				short num3 = num;
				num = (short)709558273;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.StepSize;
			}
			set
			{
				short num = (short)835896654;
				short num2 = num;
				num = (short)892519758;
				switch (num2 == num)
				{
				}
				num = (short)2058223616;
				if (num != 0)
				{
				}
				num = (short)392560640;
				short num3 = num;
				num = (short)708378625;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.StepSize = value;
			}
		}

		// Token: 0x17005620 RID: 22048
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x00A04D20 File Offset: 0x00A02F20
		// (set) Token: 0x0600AC03 RID: 44035 RVA: 0x00A04DD4 File Offset: 0x00A02FD4
		public bool DatProFeaturesReceiveIdleTimeOut_A20540_Applicable
		{
			get
			{
				short num = (short)568655873;
				if (num != 0)
				{
				}
				num = (short)324531068;
				short num2 = num;
				num = (short)7598972;
				switch (num2 == num)
				{
				}
				num = (short)335347712;
				short num3 = num;
				num = (short)1129447424;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Applicable;
			}
			set
			{
				short num = (short)244432532;
				short num2 = num;
				num = (short)1362476692;
				switch (num2 == num)
				{
				}
				num = (short)978452481;
				if (num != 0)
				{
				}
				num = (short)1497759744;
				short num3 = num;
				num = (short)1610022912;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Applicable = value;
			}
		}

		// Token: 0x17005621 RID: 22049
		// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x00A04E8C File Offset: 0x00A0308C
		// (set) Token: 0x0600AC05 RID: 44037 RVA: 0x00A04F40 File Offset: 0x00A03140
		public bool DatProFeaturesReceiveIdleTimeOut_A20540_Valid
		{
			get
			{
				short num = (short)619508686;
				short num2 = num;
				num = (short)1800074190;
				switch (num2 == num)
				{
				}
				num = (short)1250230273;
				if (num != 0)
				{
				}
				num = (short)3276800;
				short num3 = num;
				num = (short)1844576256;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Valid;
			}
			set
			{
				short num = (short)325411381;
				short num2 = num;
				num = (short)710304309;
				switch (num2 == num)
				{
				}
				num = (short)1998520320;
				if (num != 0)
				{
				}
				num = (short)250871808;
				short num3 = num;
				num = (short)1641873409;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Valid = value;
			}
		}

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x00A04FF8 File Offset: 0x00A031F8
		// (set) Token: 0x0600AC07 RID: 44039 RVA: 0x00A050AC File Offset: 0x00A032AC
		public bool DatProFeaturesReceiveIdleTimeOut_A20540_Visible
		{
			get
			{
				short num = (short)1364942795;
				short num2 = num;
				num = (short)1674338251;
				switch (num2 == num)
				{
				}
				num = (short)1250492417;
				if (num != 0)
				{
				}
				num = (short)2048065536;
				short num3 = num;
				num = (short)650444800;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Visible;
			}
			set
			{
				short num = (short)1051098262;
				short num2 = num;
				num = (short)860716182;
				switch (num2 == num)
				{
				}
				num = (short)1855062016;
				if (num != 0)
				{
				}
				num = (short)1458438144;
				short num3 = num;
				num = (short)1674838017;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Visible = value;
			}
		}

		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x00A05160 File Offset: 0x00A03360
		// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x00A05214 File Offset: 0x00A03414
		public bool DatProFeaturesReceiveIdleTimeOut_A20540_Editable
		{
			get
			{
				short num = (short)1939035749;
				short num2 = num;
				num = (short)171464293;
				switch (num2 == num)
				{
				}
				num = (short)2081947649;
				if (num != 0)
				{
				}
				num = (short)1052442624;
				short num3 = num;
				num = (short)1224998912;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.Editable;
			}
			set
			{
				short num = (short)1491611899;
				short num2 = num;
				num = (short)432615675;
				switch (num2 == num)
				{
				}
				num = (short)622198785;
				if (num != 0)
				{
				}
				num = (short)1422983168;
				short num3 = num;
				num = (short)648806400;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.Editable = value;
			}
		}

		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x00A052CC File Offset: 0x00A034CC
		internal string DatProFeaturesReceiveIdleTimeOut_A20540_UILabel
		{
			get
			{
				short num = (short)159620512;
				short num2 = num;
				num = (short)1633131936;
				switch (num2 == num)
				{
				}
				num = (short)78708737;
				if (num != 0)
				{
				}
				num = (short)160759808;
				short num3 = num;
				num = (short)1150025728;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.UIName;
			}
		}

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x00A05380 File Offset: 0x00A03580
		// (set) Token: 0x0600AC0C RID: 44044 RVA: 0x00A05438 File Offset: 0x00A03638
		internal bool DatProFeaturesReceiveIdleTimeOut_A20540_HiddenStatic
		{
			get
			{
				short num = (short)145191894;
				short num2 = num;
				num = (short)359691222;
				switch (num2 == num)
				{
				}
				num = (short)1577779200;
				if (num != 0)
				{
				}
				num = (short)1861091328;
				short num3 = num;
				num = (short)30474241;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.HiddenStatic;
			}
			set
			{
				short num = (short)1792952632;
				short num2 = num;
				num = (short)1848461624;
				switch (num2 == num)
				{
				}
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)1673265152;
				short num3 = num;
				num = (short)1125974016;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.HiddenStatic = value;
			}
		}

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x0600AC0D RID: 44045 RVA: 0x00A054F0 File Offset: 0x00A036F0
		// (set) Token: 0x0600AC0E RID: 44046 RVA: 0x00A055A4 File Offset: 0x00A037A4
		internal bool DatProFeaturesReceiveIdleTimeOut_A20540_HiddenDynamic
		{
			get
			{
				short num = (short)633584336;
				short num2 = num;
				num = (short)228637392;
				switch (num2 == num)
				{
				}
				num = (short)1343029248;
				if (num != 0)
				{
				}
				num = (short)951582720;
				short num3 = num;
				num = (short)1371275265;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540.HiddenDynamic;
			}
			set
			{
				short num = (short)662634497;
				if (num != 0)
				{
				}
				num = (short)1925331382;
				short num2 = num;
				num = (short)622279094;
				switch (num2 == num)
				{
				}
				num = (short)526974976;
				short num3 = num;
				num = (short)472711168;
				if (num != 0)
				{
				}
				this.datProFeaturesReceiveIdleTimeOut_A20540.HiddenDynamic = value;
			}
		}

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x0600AC0F RID: 44047 RVA: 0x00A05658 File Offset: 0x00A03858
		public bool DatProFeaturesReceiveIdleTimeOut_A20540_HasDiffs
		{
			get
			{
				short num = (short)2081589630;
				short num2 = num;
				num = (short)401639806;
				switch (num2 == num)
				{
				}
				num = (short)557318144;
				if (num != 0)
				{
				}
				num = (short)850591744;
				short num3 = num;
				num = (short)1656160257;
				if (num != 0)
				{
				}
				return this.datProFeaturesReceiveIdleTimeOut_A20540._HasDiffs;
			}
		}

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x00A0570C File Offset: 0x00A0390C
		// (set) Token: 0x0600AC11 RID: 44049 RVA: 0x00A057C0 File Offset: 0x00A039C0
		public int DatProFeaturesTransmissionInhibitValue_A20541Value
		{
			get
			{
				short num = (short)2007203005;
				short num2 = num;
				num = (short)79789245;
				switch (num2 == num)
				{
				}
				num = (short)117702657;
				if (num != 0)
				{
				}
				num = (short)734068736;
				short num3 = num;
				num = (short)368508928;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Value;
			}
			set
			{
				short num = (short)926683733;
				short num2 = num;
				num = (short)574362197;
				switch (num2 == num)
				{
				}
				num = (short)982843393;
				if (num != 0)
				{
				}
				num = (short)20381696;
				short num3 = num;
				num = (short)211943424;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Value = value;
			}
		}

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x0600AC12 RID: 44050 RVA: 0x00A05874 File Offset: 0x00A03A74
		public global::AcpBusinessLayer.AcpRangeField<int, string> DatProFeaturesTransmissionInhibitValue_A20541
		{
			get
			{
				short num = (short)1261043713;
				if (num != 0)
				{
				}
				num = (short)177834824;
				short num2 = num;
				num = (short)851741512;
				switch (num2 == num)
				{
				}
				num = (short)723386368;
				short num3 = num;
				num = (short)1641283584;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541;
			}
		}

		// Token: 0x1700562A RID: 22058
		// (get) Token: 0x0600AC13 RID: 44051 RVA: 0x00A05924 File Offset: 0x00A03B24
		// (set) Token: 0x0600AC14 RID: 44052 RVA: 0x00A059DC File Offset: 0x00A03BDC
		public string DatProFeaturesTransmissionInhibitValue_A20541_UIValue
		{
			get
			{
				short num = (short)743368029;
				short num2 = num;
				num = (short)2019419485;
				switch (num2 == num)
				{
				}
				num = (short)736755713;
				if (num != 0)
				{
				}
				num = (short)261947392;
				short num3 = num;
				num = (short)494206976;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.UIValue;
			}
			set
			{
				short num = (short)425822927;
				short num2 = num;
				num = (short)587434703;
				switch (num2 == num)
				{
				}
				num = (short)739770369;
				if (num != 0)
				{
				}
				num = (short)432275456;
				short num3 = num;
				num = (short)1585250304;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.UIValue = value;
			}
		}

		// Token: 0x1700562B RID: 22059
		// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x00A05A90 File Offset: 0x00A03C90
		// (set) Token: 0x0600AC16 RID: 44054 RVA: 0x00A05B48 File Offset: 0x00A03D48
		internal int DatProFeaturesTransmissionInhibitValue_A20541Min
		{
			get
			{
				short num = (short)882756520;
				short num2 = num;
				num = (short)810273704;
				switch (num2 == num)
				{
				}
				num = (short)1173094401;
				if (num != 0)
				{
				}
				num = (short)272564224;
				short num3 = num;
				num = (short)233963520;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Min;
			}
			set
			{
				short num = (short)1060879026;
				short num2 = num;
				num = (short)1722792626;
				switch (num2 == num)
				{
				}
				num = (short)59047937;
				if (num != 0)
				{
				}
				num = (short)1724579840;
				short num3 = num;
				num = (short)53608448;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Min = value;
			}
		}

		// Token: 0x1700562C RID: 22060
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x00A05BFC File Offset: 0x00A03DFC
		// (set) Token: 0x0600AC18 RID: 44056 RVA: 0x00A05CB0 File Offset: 0x00A03EB0
		internal int DatProFeaturesTransmissionInhibitValue_A20541Max
		{
			get
			{
				short num = (short)160235521;
				if (num != 0)
				{
				}
				num = (short)1413532852;
				short num2 = num;
				num = (short)1727974580;
				switch (num2 == num)
				{
				}
				num = (short)765132800;
				short num3 = num;
				num = (short)2147287040;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Max;
			}
			set
			{
				short num = (short)1650065409;
				if (num != 0)
				{
				}
				num = (short)1142312989;
				short num2 = num;
				num = (short)1536839709;
				switch (num2 == num)
				{
				}
				num = (short)1018363904;
				short num3 = num;
				num = (short)437780480;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Max = value;
			}
		}

		// Token: 0x1700562D RID: 22061
		// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x00A05D64 File Offset: 0x00A03F64
		// (set) Token: 0x0600AC1A RID: 44058 RVA: 0x00A05E18 File Offset: 0x00A04018
		internal int DatProFeaturesTransmissionInhibitValue_A20541Step
		{
			get
			{
				short num = (short)1893547815;
				short num2 = num;
				num = (short)2076458791;
				switch (num2 == num)
				{
				}
				num = (short)351666177;
				if (num != 0)
				{
				}
				num = (short)1158086656;
				short num3 = num;
				num = (short)1342242816;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.StepSize;
			}
			set
			{
				short num = (short)64148158;
				short num2 = num;
				num = (short)1847710398;
				switch (num2 == num)
				{
				}
				num = (short)524288000;
				if (num != 0)
				{
				}
				num = (short)152698880;
				short num3 = num;
				num = (short)428867585;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.StepSize = value;
			}
		}

		// Token: 0x1700562E RID: 22062
		// (get) Token: 0x0600AC1B RID: 44059 RVA: 0x00A05ED0 File Offset: 0x00A040D0
		// (set) Token: 0x0600AC1C RID: 44060 RVA: 0x00A05F88 File Offset: 0x00A04188
		public bool DatProFeaturesTransmissionInhibitValue_A20541_Applicable
		{
			get
			{
				short num = (short)1502850316;
				short num2 = num;
				num = (short)884583692;
				switch (num2 == num)
				{
				}
				num = (short)117833728;
				if (num != 0)
				{
				}
				num = (short)146079744;
				short num3 = num;
				num = (short)848887809;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Applicable;
			}
			set
			{
				short num = (short)2071074876;
				short num2 = num;
				num = (short)209459260;
				switch (num2 == num)
				{
				}
				num = (short)278462464;
				if (num != 0)
				{
				}
				num = (short)1244594176;
				short num3 = num;
				num = (short)1299185665;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Applicable = value;
			}
		}

		// Token: 0x1700562F RID: 22063
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x00A0603C File Offset: 0x00A0423C
		// (set) Token: 0x0600AC1E RID: 44062 RVA: 0x00A060F4 File Offset: 0x00A042F4
		public bool DatProFeaturesTransmissionInhibitValue_A20541_Valid
		{
			get
			{
				short num = (short)498283536;
				short num2 = num;
				num = (short)1892955152;
				switch (num2 == num)
				{
				}
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)79560704;
				short num3 = num;
				num = (short)123404288;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Valid;
			}
			set
			{
				short num = (short)1273941517;
				short num2 = num;
				num = (short)1089064461;
				switch (num2 == num)
				{
				}
				num = (short)283443200;
				if (num != 0)
				{
				}
				num = (short)1832976384;
				short num3 = num;
				num = (short)1637548033;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Valid = value;
			}
		}

		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x0600AC1F RID: 44063 RVA: 0x00A061A8 File Offset: 0x00A043A8
		// (set) Token: 0x0600AC20 RID: 44064 RVA: 0x00A0625C File Offset: 0x00A0445C
		public bool DatProFeaturesTransmissionInhibitValue_A20541_Visible
		{
			get
			{
				short num = (short)908619035;
				short num2 = num;
				num = (short)84634907;
				switch (num2 == num)
				{
				}
				num = (short)853803009;
				if (num != 0)
				{
				}
				num = (short)1084817408;
				short num3 = num;
				num = (short)1271922688;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Visible;
			}
			set
			{
				short num = (short)1064372974;
				short num2 = num;
				num = (short)1281166062;
				switch (num2 == num)
				{
				}
				num = (short)374341633;
				if (num != 0)
				{
				}
				num = (short)372768768;
				short num3 = num;
				num = (short)1716715520;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Visible = value;
			}
		}

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x0600AC21 RID: 44065 RVA: 0x00A06310 File Offset: 0x00A04510
		// (set) Token: 0x0600AC22 RID: 44066 RVA: 0x00A063C4 File Offset: 0x00A045C4
		public bool DatProFeaturesTransmissionInhibitValue_A20541_Editable
		{
			get
			{
				short num = (short)181771281;
				short num2 = num;
				num = (short)1829215249;
				switch (num2 == num)
				{
				}
				num = (short)780402689;
				if (num != 0)
				{
				}
				num = (short)1689321472;
				short num3 = num;
				num = (short)1880555520;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.Editable;
			}
			set
			{
				short num = (short)717113436;
				short num2 = num;
				num = (short)163530844;
				switch (num2 == num)
				{
				}
				num = (short)522518528;
				if (num != 0)
				{
				}
				num = (short)2064056320;
				short num3 = num;
				num = (short)45154305;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.Editable = value;
			}
		}

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x0600AC23 RID: 44067 RVA: 0x00A06478 File Offset: 0x00A04678
		internal string DatProFeaturesTransmissionInhibitValue_A20541_UILabel
		{
			get
			{
				short num = (short)483328001;
				if (num != 0)
				{
				}
				num = (short)367493386;
				short num2 = num;
				num = (short)581402890;
				switch (num2 == num)
				{
				}
				num = (short)1802960896;
				short num3 = num;
				num = (short)2042757120;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.UIName;
			}
		}

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x00A0652C File Offset: 0x00A0472C
		// (set) Token: 0x0600AC25 RID: 44069 RVA: 0x00A065E4 File Offset: 0x00A047E4
		internal bool DatProFeaturesTransmissionInhibitValue_A20541_HiddenStatic
		{
			get
			{
				short num = (short)1182127928;
				short num2 = num;
				num = (short)1265489720;
				switch (num2 == num)
				{
				}
				num = (short)1674903553;
				if (num != 0)
				{
				}
				num = (short)307167232;
				short num3 = num;
				num = (short)1338179584;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.HiddenStatic;
			}
			set
			{
				short num = (short)2107401123;
				short num2 = num;
				num = (short)1365205923;
				switch (num2 == num)
				{
				}
				num = (short)376504321;
				if (num != 0)
				{
				}
				num = (short)1109983232;
				short num3 = num;
				num = (short)1723072512;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.HiddenStatic = value;
			}
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x00A06698 File Offset: 0x00A04898
		// (set) Token: 0x0600AC27 RID: 44071 RVA: 0x00A06750 File Offset: 0x00A04950
		internal bool DatProFeaturesTransmissionInhibitValue_A20541_HiddenDynamic
		{
			get
			{
				short num = (short)1907818497;
				if (num != 0)
				{
				}
				num = (short)1476945973;
				short num2 = num;
				num = (short)1932093493;
				switch (num2 == num)
				{
				}
				num = (short)344326144;
				short num3 = num;
				num = (short)1440874496;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541.HiddenDynamic;
			}
			set
			{
				short num = (short)1128923627;
				short num2 = num;
				num = (short)948896235;
				switch (num2 == num)
				{
				}
				num = (short)1003749377;
				if (num != 0)
				{
				}
				num = (short)2049572864;
				short num3 = num;
				num = (short)768933888;
				if (num != 0)
				{
				}
				this.datProFeaturesTransmissionInhibitValue_A20541.HiddenDynamic = value;
			}
		}

		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x0600AC28 RID: 44072 RVA: 0x00A06804 File Offset: 0x00A04A04
		public bool DatProFeaturesTransmissionInhibitValue_A20541_HasDiffs
		{
			get
			{
				short num = (short)1493678426;
				short num2 = num;
				num = (short)79608154;
				switch (num2 == num)
				{
				}
				num = (short)889585665;
				if (num != 0)
				{
				}
				num = (short)744423424;
				short num3 = num;
				num = (short)1932591104;
				if (num != 0)
				{
				}
				return this.datProFeaturesTransmissionInhibitValue_A20541._HasDiffs;
			}
		}

		// Token: 0x17005636 RID: 22070
		// (get) Token: 0x0600AC29 RID: 44073 RVA: 0x00A068BC File Offset: 0x00A04ABC
		// (set) Token: 0x0600AC2A RID: 44074 RVA: 0x00A06974 File Offset: 0x00A04B74
		public long DatProFeaturesDestinationAddress_A20543Value
		{
			get
			{
				short num = (short)1768961095;
				short num2 = num;
				num = (short)107295815;
				switch (num2 == num)
				{
				}
				num = (short)1174208512;
				if (num != 0)
				{
				}
				num = (short)923467776;
				short num3 = num;
				num = (short)1412038657;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543.Value;
			}
			set
			{
				short num = (short)1503548275;
				short num2 = num;
				num = (short)2026853235;
				switch (num2 == num)
				{
				}
				num = (short)454361088;
				if (num != 0)
				{
				}
				num = (short)1212940288;
				short num3 = num;
				num = (short)2003435521;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationAddress_A20543.Value = value;
			}
		}

		// Token: 0x17005637 RID: 22071
		// (get) Token: 0x0600AC2B RID: 44075 RVA: 0x00A06A2C File Offset: 0x00A04C2C
		// (set) Token: 0x0600AC2C RID: 44076 RVA: 0x00A06AE4 File Offset: 0x00A04CE4
		public string DatProFeaturesDestinationAddress_A20543_UIValue
		{
			get
			{
				short num = (short)1804626360;
				short num2 = num;
				num = (short)2090691000;
				switch (num2 == num)
				{
				}
				num = (short)925630464;
				if (num != 0)
				{
				}
				num = (short)732168192;
				short num3 = num;
				num = (short)788332545;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543.UIValue;
			}
			set
			{
				short num = (short)750402639;
				short num2 = num;
				num = (short)96156751;
				switch (num2 == num)
				{
				}
				num = (short)869793792;
				if (num != 0)
				{
				}
				num = (short)633077760;
				short num3 = num;
				num = (short)1946812417;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationAddress_A20543.UIValue = value;
			}
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x00A06B9C File Offset: 0x00A04D9C
		public global::AcpBusinessLayer.AcpIPAddressField DatProFeaturesDestinationAddress_A20543
		{
			get
			{
				short num = (short)28584284;
				short num2 = num;
				num = (short)1611278684;
				switch (num2 == num)
				{
				}
				num = (short)1594097664;
				if (num != 0)
				{
				}
				num = (short)1523318784;
				short num3 = num;
				num = (short)1974796289;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543;
			}
		}

		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x00A06C4C File Offset: 0x00A04E4C
		// (set) Token: 0x0600AC2F RID: 44079 RVA: 0x00A06CFC File Offset: 0x00A04EFC
		public bool DatProFeaturesDestinationAddress_A20543_Applicable
		{
			get
			{
				short num = (short)1155990497;
				short num2 = num;
				num = (short)1494418401;
				switch (num2 == num)
				{
				}
				num = (short)1530724352;
				if (num != 0)
				{
				}
				num = (short)1875705856;
				short num3 = num;
				num = (short)106954753;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543.Applicable;
			}
			set
			{
				short num = (short)1748375363;
				short num2 = num;
				num = (short)518002499;
				switch (num2 == num)
				{
				}
				num = (short)2104557569;
				if (num != 0)
				{
				}
				num = (short)931594240;
				short num3 = num;
				num = (short)748617728;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationAddress_A20543.Applicable = value;
			}
		}

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x00A06DB4 File Offset: 0x00A04FB4
		// (set) Token: 0x0600AC31 RID: 44081 RVA: 0x00A06E68 File Offset: 0x00A05068
		public bool DatProFeaturesDestinationAddress_A20543_Valid
		{
			get
			{
				short num = (short)1252392961;
				if (num != 0)
				{
				}
				num = (short)1746365888;
				short num2 = num;
				num = (short)52587968;
				switch (num2 == num)
				{
				}
				num = (short)1804337152;
				short num3 = num;
				num = (short)1227358208;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543.Valid;
			}
			set
			{
				short num = (short)1452998296;
				short num2 = num;
				num = (short)969014936;
				switch (num2 == num)
				{
				}
				num = (short)684523520;
				if (num != 0)
				{
				}
				num = (short)1838415872;
				short num3 = num;
				num = (short)1957691393;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationAddress_A20543.Valid = value;
			}
		}

		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x00A06F1C File Offset: 0x00A0511C
		// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x00A06FD4 File Offset: 0x00A051D4
		public bool DatProFeaturesDestinationAddress_A20543_Visible
		{
			get
			{
				short num = (short)751717195;
				short num2 = num;
				num = (short)503532363;
				switch (num2 == num)
				{
				}
				num = (short)1888944128;
				if (num != 0)
				{
				}
				num = (short)1362231296;
				short num3 = num;
				num = (short)1650786305;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationAddress_A20543.Visible;
			}
			set
			{
				short num = (short)1855899583;
				short num2 = num;
				num = (short)271894463;
				switch (num2 == num)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				num = (short)2027094016;
				short num3 = num;
				num = (short)1120731137;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationAddress_A20543.Visible = value;
			}
		}

		// Token: 0x1700563C RID: 22076
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x00A07088 File Offset: 0x00A05288
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x00A0713C File Offset: 0x00A0533C
		public bool DatProFeaturesDestinationAddress_A20543_Editable
		{
			get
			{
				short num = (short)19053394;
				short num2 = num;
				num = (short)685554514;
				switch (num2 == num)
				{
				}
				num = (short)334626817;
				if (num != 0)
				{
				}
				num = (short)1447100416;
				if (num != 0)
				{
				}
				num = (short)215547904;
				short num3 = num;
				return this.datProFeaturesDestinationAddress_A20543.Editable;
			}
			set
			{
				short num = (short)955045822;
				short num2 = num;
				num = (short)1885984702;
				switch (num2 == num)
				{
				}
				num = (short)504037377;
				if (num != 0)
				{
				}
				num = (short)1088946176;
				if (num != 0)
				{
				}
				num = (short)1679294464;
				short num3 = num;
				this.datProFeaturesDestinationAddress_A20543.Editable = value;
			}
		}

		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x00A071F0 File Offset: 0x00A053F0
		internal string DatProFeaturesDestinationAddress_A20543_UILabel
		{
			get
			{
				short num = (short)965845808;
				short num2 = num;
				num = (short)1624286000;
				switch (num2 == num)
				{
				}
				num = (short)1955659777;
				if (num != 0)
				{
				}
				num = (short)474742784;
				if (num != 0)
				{
				}
				num = (short)1581645824;
				short num3 = num;
				return this.datProFeaturesDestinationAddress_A20543.UIName;
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x0600AC37 RID: 44087 RVA: 0x00A072A8 File Offset: 0x00A054A8
		// (set) Token: 0x0600AC38 RID: 44088 RVA: 0x00A07360 File Offset: 0x00A05560
		internal bool DatProFeaturesDestinationAddress_A20543_HiddenStatic
		{
			get
			{
				short num = (short)1624576026;
				short num2 = num;
				num = (short)2074480666;
				switch (num2 == num)
				{
				}
				num = (short)1743126529;
				if (num != 0)
				{
				}
				num = (short)1018298368;
				if (num != 0)
				{
				}
				num = (short)1068236800;
				short num3 = num;
				return this.datProFeaturesDestinationAddress_A20543.HiddenStatic;
			}
			set
			{
				short num = (short)1194986140;
				short num2 = num;
				num = (short)1714555548;
				switch (num2 == num)
				{
				}
				num = (short)255000576;
				if (num != 0)
				{
				}
				num = (short)1013907457;
				if (num != 0)
				{
				}
				num = (short)754450432;
				short num3 = num;
				this.datProFeaturesDestinationAddress_A20543.HiddenStatic = value;
			}
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x0600AC39 RID: 44089 RVA: 0x00A07418 File Offset: 0x00A05618
		// (set) Token: 0x0600AC3A RID: 44090 RVA: 0x00A074CC File Offset: 0x00A056CC
		internal bool DatProFeaturesDestinationAddress_A20543_HiddenDynamic
		{
			get
			{
				short num = (short)1132537543;
				short num2 = num;
				num = (short)1165043399;
				switch (num2 == num)
				{
				}
				num = (short)2043871232;
				if (num != 0)
				{
				}
				num = (short)1245446145;
				if (num != 0)
				{
				}
				num = (short)1576665088;
				short num3 = num;
				return this.datProFeaturesDestinationAddress_A20543.HiddenDynamic;
			}
			set
			{
				short num = (short)377777783;
				short num2 = num;
				num = (short)866938487;
				switch (num2 == num)
				{
				}
				num = (short)1532428289;
				if (num != 0)
				{
				}
				num = (short)33947648;
				if (num != 0)
				{
				}
				num = (short)1208221696;
				short num3 = num;
				this.datProFeaturesDestinationAddress_A20543.HiddenDynamic = value;
			}
		}

		// Token: 0x17005640 RID: 22080
		// (get) Token: 0x0600AC3B RID: 44091 RVA: 0x00A07580 File Offset: 0x00A05780
		public bool DatProFeaturesDestinationAddress_A20543_HasDiffs
		{
			get
			{
				short num = (short)1257026727;
				short num2 = num;
				num = (short)1301918887;
				switch (num2 == num)
				{
				}
				num = (short)1863450625;
				if (num != 0)
				{
				}
				num = (short)618987520;
				if (num != 0)
				{
				}
				num = (short)1172111360;
				short num3 = num;
				return this.datProFeaturesDestinationAddress_A20543._HasDiffs;
			}
		}

		// Token: 0x17005641 RID: 22081
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x00A07634 File Offset: 0x00A05834
		// (set) Token: 0x0600AC3D RID: 44093 RVA: 0x00A076E8 File Offset: 0x00A058E8
		public int DatProFeaturesDestinationPort_A20544Value
		{
			get
			{
				short num = (short)1388941175;
				short num2 = num;
				num = (short)1899794295;
				switch (num2 == num)
				{
				}
				num = (short)2036662272;
				if (num != 0)
				{
				}
				num = (short)926547969;
				if (num != 0)
				{
				}
				num = (short)1492385792;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Value;
			}
			set
			{
				short num = (short)1005564607;
				short num2 = num;
				num = (short)1197650623;
				switch (num2 == num)
				{
				}
				num = (short)1490616320;
				if (num != 0)
				{
				}
				num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)1788674048;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Value = value;
			}
		}

		// Token: 0x17005642 RID: 22082
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x00A0779C File Offset: 0x00A0599C
		public global::AcpBusinessLayer.AcpSimpleRangeField DatProFeaturesDestinationPort_A20544
		{
			get
			{
				short num = (short)971177985;
				if (num != 0)
				{
				}
				num = (short)1779328089;
				short num2 = num;
				num = (short)1494901849;
				switch (num2 == num)
				{
				}
				num = (short)541720576;
				if (num != 0)
				{
				}
				num = (short)45678592;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544;
			}
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x0600AC3F RID: 44095 RVA: 0x00A0784C File Offset: 0x00A05A4C
		// (set) Token: 0x0600AC40 RID: 44096 RVA: 0x00A07900 File Offset: 0x00A05B00
		public string DatProFeaturesDestinationPort_A20544_UIValue
		{
			get
			{
				short num = (short)1789272661;
				short num2 = num;
				num = (short)297542229;
				switch (num2 == num)
				{
				}
				num = (short)1706885121;
				if (num != 0)
				{
				}
				num = (short)1875050496;
				if (num != 0)
				{
				}
				num = (short)911540224;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.UIValue;
			}
			set
			{
				short num = (short)161047278;
				short num2 = num;
				num = (short)280322798;
				switch (num2 == num)
				{
				}
				num = (short)1429405697;
				if (num != 0)
				{
				}
				num = (short)1814691840;
				if (num != 0)
				{
				}
				num = (short)1529217024;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.UIValue = value;
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x0600AC41 RID: 44097 RVA: 0x00A079B4 File Offset: 0x00A05BB4
		// (set) Token: 0x0600AC42 RID: 44098 RVA: 0x00A07A6C File Offset: 0x00A05C6C
		internal int DatProFeaturesDestinationPort_A20544Min
		{
			get
			{
				short num = (short)1278619781;
				short num2 = num;
				num = (short)548417669;
				switch (num2 == num)
				{
				}
				num = (short)834666497;
				if (num != 0)
				{
				}
				num = (short)1400438784;
				if (num != 0)
				{
				}
				num = (short)1137442816;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Min;
			}
			set
			{
				short num = (short)5859559;
				short num2 = num;
				num = (short)1248422119;
				switch (num2 == num)
				{
				}
				num = (short)2138374145;
				if (num != 0)
				{
				}
				num = (short)1523843072;
				if (num != 0)
				{
				}
				num = (short)1728643072;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Min = value;
			}
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x0600AC43 RID: 44099 RVA: 0x00A07B24 File Offset: 0x00A05D24
		// (set) Token: 0x0600AC44 RID: 44100 RVA: 0x00A07BD8 File Offset: 0x00A05DD8
		internal int DatProFeaturesDestinationPort_A20544Max
		{
			get
			{
				short num = (short)637119782;
				short num2 = num;
				num = (short)561098022;
				switch (num2 == num)
				{
				}
				num = (short)118554624;
				if (num != 0)
				{
				}
				num = (short)1355743233;
				if (num != 0)
				{
				}
				num = (short)1959198720;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Max;
			}
			set
			{
				short num = (short)194474612;
				short num2 = num;
				num = (short)1034908276;
				switch (num2 == num)
				{
				}
				num = (short)304414720;
				if (num != 0)
				{
				}
				num = (short)1392181249;
				if (num != 0)
				{
				}
				num = (short)255721472;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Max = value;
			}
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x00A07C90 File Offset: 0x00A05E90
		// (set) Token: 0x0600AC46 RID: 44102 RVA: 0x00A07D48 File Offset: 0x00A05F48
		internal int DatProFeaturesDestinationPort_A20544Step
		{
			get
			{
				short num = (short)903282689;
				if (num != 0)
				{
				}
				num = (short)61061292;
				short num2 = num;
				num = (short)1835251884;
				switch (num2 == num)
				{
				}
				num = (short)94961664;
				if (num != 0)
				{
				}
				num = (short)894369792;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.StepSize;
			}
			set
			{
				short num = (short)1487843909;
				short num2 = num;
				num = (short)841658949;
				switch (num2 == num)
				{
				}
				num = (short)1971650561;
				if (num != 0)
				{
				}
				num = (short)1861156864;
				if (num != 0)
				{
				}
				num = (short)1391198208;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.StepSize = value;
			}
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x0600AC47 RID: 44103 RVA: 0x00A07DFC File Offset: 0x00A05FFC
		// (set) Token: 0x0600AC48 RID: 44104 RVA: 0x00A07EB0 File Offset: 0x00A060B0
		public bool DatProFeaturesDestinationPort_A20544_Applicable
		{
			get
			{
				short num = (short)1408375065;
				short num2 = num;
				num = (short)1686313241;
				switch (num2 == num)
				{
				}
				num = (short)1528365056;
				if (num != 0)
				{
				}
				num = (short)1153368065;
				if (num != 0)
				{
				}
				num = (short)18022400;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Applicable;
			}
			set
			{
				short num = (short)1011657247;
				short num2 = num;
				num = (short)412002847;
				switch (num2 == num)
				{
				}
				num = (short)1017184257;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				if (num != 0)
				{
				}
				num = (short)2134310912;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Applicable = value;
			}
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x0600AC49 RID: 44105 RVA: 0x00A07F64 File Offset: 0x00A06164
		// (set) Token: 0x0600AC4A RID: 44106 RVA: 0x00A08018 File Offset: 0x00A06218
		public bool DatProFeaturesDestinationPort_A20544_Valid
		{
			get
			{
				short num = (short)89622876;
				short num2 = num;
				num = (short)2104920412;
				switch (num2 == num)
				{
				}
				num = (short)1826684929;
				if (num != 0)
				{
				}
				num = (short)232718336;
				if (num != 0)
				{
				}
				num = (short)1681784832;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Valid;
			}
			set
			{
				short num = (short)8585217;
				if (num != 0)
				{
				}
				num = (short)1137716226;
				short num2 = num;
				num = (short)1654336514;
				switch (num2 == num)
				{
				}
				num = (short)372178944;
				if (num != 0)
				{
				}
				num = (short)801767424;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Valid = value;
			}
		}

		// Token: 0x17005649 RID: 22089
		// (get) Token: 0x0600AC4B RID: 44107 RVA: 0x00A080CC File Offset: 0x00A062CC
		// (set) Token: 0x0600AC4C RID: 44108 RVA: 0x00A08180 File Offset: 0x00A06380
		public bool DatProFeaturesDestinationPort_A20544_Visible
		{
			get
			{
				short num = (short)185751175;
				short num2 = num;
				num = (short)172840583;
				switch (num2 == num)
				{
				}
				num = (short)446955521;
				if (num != 0)
				{
				}
				num = (short)285736960;
				if (num != 0)
				{
				}
				num = (short)1013252096;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Visible;
			}
			set
			{
				short num = (short)358119476;
				short num2 = num;
				num = (short)1298954292;
				switch (num2 == num)
				{
				}
				num = (short)1151795200;
				if (num != 0)
				{
				}
				num = (short)1463943169;
				if (num != 0)
				{
				}
				num = (short)274202624;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Visible = value;
			}
		}

		// Token: 0x1700564A RID: 22090
		// (get) Token: 0x0600AC4D RID: 44109 RVA: 0x00A08234 File Offset: 0x00A06434
		// (set) Token: 0x0600AC4E RID: 44110 RVA: 0x00A082EC File Offset: 0x00A064EC
		public bool DatProFeaturesDestinationPort_A20544_Editable
		{
			get
			{
				short num = (short)1606701305;
				short num2 = num;
				num = (short)248074489;
				switch (num2 == num)
				{
				}
				num = (short)1833893889;
				if (num != 0)
				{
				}
				num = (short)1988755456;
				if (num != 0)
				{
				}
				num = (short)1589903360;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.Editable;
			}
			set
			{
				short num = (short)1778188289;
				if (num != 0)
				{
				}
				num = (short)758550628;
				short num2 = num;
				num = (short)1895862372;
				switch (num2 == num)
				{
				}
				num = (short)193921024;
				if (num != 0)
				{
				}
				num = (short)1917452288;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.Editable = value;
			}
		}

		// Token: 0x1700564B RID: 22091
		// (get) Token: 0x0600AC4F RID: 44111 RVA: 0x00A083A0 File Offset: 0x00A065A0
		internal string DatProFeaturesDestinationPort_A20544_UILabel
		{
			get
			{
				short num = (short)173221568;
				short num2 = num;
				num = (short)464070336;
				switch (num2 == num)
				{
				}
				num = (short)1896677377;
				if (num != 0)
				{
				}
				num = (short)1518141440;
				if (num != 0)
				{
				}
				num = (short)1152778240;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.UIName;
			}
		}

		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x00A08450 File Offset: 0x00A06650
		// (set) Token: 0x0600AC51 RID: 44113 RVA: 0x00A08504 File Offset: 0x00A06704
		internal bool DatProFeaturesDestinationPort_A20544_HiddenStatic
		{
			get
			{
				short num = (short)162675526;
				short num2 = num;
				num = (short)403258182;
				switch (num2 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)911212544;
				if (num != 0)
				{
				}
				num = (short)2035482624;
				short num3 = num;
				return this.datProFeaturesDestinationPort_A20544.HiddenStatic;
			}
			set
			{
				short num = (short)292207483;
				short num2 = num;
				num = (short)1145551739;
				switch (num2 == num)
				{
				}
				num = (short)960757761;
				if (num != 0)
				{
				}
				num = (short)1149304832;
				if (num != 0)
				{
				}
				num = (short)2048786432;
				short num3 = num;
				this.datProFeaturesDestinationPort_A20544.HiddenStatic = value;
			}
		}

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x0600AC52 RID: 44114 RVA: 0x00A085B8 File Offset: 0x00A067B8
		// (set) Token: 0x0600AC53 RID: 44115 RVA: 0x00A0866C File Offset: 0x00A0686C
		internal bool DatProFeaturesDestinationPort_A20544_HiddenDynamic
		{
			get
			{
				short num = (short)32325451;
				short num2 = num;
				num = (short)1616789323;
				switch (num2 == num)
				{
				}
				num = (short)768671744;
				short num3 = num;
				num = (short)1635385344;
				if (num != 0)
				{
				}
				num = (short)1669726209;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationPort_A20544.HiddenDynamic;
			}
			set
			{
				short num = (short)1018108324;
				short num2 = num;
				num = (short)787028388;
				switch (num2 == num)
				{
				}
				num = (short)1554317312;
				short num3 = num;
				num = (short)1598357504;
				if (num != 0)
				{
				}
				num = (short)1171193857;
				if (num != 0)
				{
				}
				this.datProFeaturesDestinationPort_A20544.HiddenDynamic = value;
			}
		}

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x00A08720 File Offset: 0x00A06920
		public bool DatProFeaturesDestinationPort_A20544_HasDiffs
		{
			get
			{
				short num = (short)491645124;
				short num2 = num;
				num = (short)1828907204;
				switch (num2 == num)
				{
				}
				num = (short)495124480;
				short num3 = num;
				num = (short)785711105;
				if (num != 0)
				{
				}
				num = (short)1808531456;
				if (num != 0)
				{
				}
				return this.datProFeaturesDestinationPort_A20544._HasDiffs;
			}
		}

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x00A087D4 File Offset: 0x00A069D4
		// (set) Token: 0x0600AC56 RID: 44118 RVA: 0x00A0888C File Offset: 0x00A06A8C
		public int DataProfFeatureContxActivHldoffMode_A36469Value
		{
			get
			{
				short num = (short)1358104141;
				short num2 = num;
				num = (short)709887565;
				switch (num2 == num)
				{
				}
				num = (short)1791688704;
				short num3 = num;
				num = (short)774504449;
				if (num != 0)
				{
				}
				num = (short)1420754944;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.Value;
			}
			set
			{
				short num = (short)1567863240;
				short num2 = num;
				num = (short)1539158472;
				switch (num2 == num)
				{
				}
				num = (short)230424576;
				short num3 = num;
				num = (short)1491140608;
				if (num != 0)
				{
				}
				num = (short)934543361;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.Value = value;
			}
		}

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x00A08944 File Offset: 0x00A06B44
		// (set) Token: 0x0600AC58 RID: 44120 RVA: 0x00A089F8 File Offset: 0x00A06BF8
		public string DataProfFeatureContxActivHldoffMode_A36469_UIValue
		{
			get
			{
				short num = (short)1913467696;
				short num2 = num;
				num = (short)1351234352;
				switch (num2 == num)
				{
				}
				num = (short)127139840;
				short num3 = num;
				num = (short)1192296448;
				if (num != 0)
				{
				}
				num = (short)1563295745;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.UIValue;
			}
			set
			{
				short num = (short)1107689473;
				if (num != 0)
				{
				}
				num = (short)1516042465;
				short num2 = num;
				num = (short)844495073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)784793600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748828160;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.UIValue = value;
			}
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x00A08AAC File Offset: 0x00A06CAC
		public global::AcpBusinessLayer.AcpListField DataProfFeatureContxActivHldoffMode_A36469
		{
			get
			{
				short num = (short)1927034945;
				short num2 = num;
				num = (short)807352385;
				switch (num2 == num)
				{
				}
				num = (short)752680960;
				short num3 = num;
				num = (short)2141323265;
				if (num != 0)
				{
				}
				num = (short)1909915648;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469;
			}
		}

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x00A08B5C File Offset: 0x00A06D5C
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x00A08C10 File Offset: 0x00A06E10
		public bool DataProfFeatureContxActivHldoffMode_A36469_Applicable
		{
			get
			{
				short num = (short)2079553134;
				short num2 = num;
				num = (short)356480622;
				switch (num2 == num)
				{
				}
				num = (short)1194393600;
				short num3 = num;
				num = (short)71499777;
				if (num != 0)
				{
				}
				num = (short)457179136;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.Applicable;
			}
			set
			{
				short num = (short)1818931312;
				short num2 = num;
				num = (short)1430106224;
				switch (num2 == num)
				{
				}
				num = (short)289079296;
				short num3 = num;
				num = (short)1176502273;
				if (num != 0)
				{
				}
				num = (short)2091581440;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.Applicable = value;
			}
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x00A08CC4 File Offset: 0x00A06EC4
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x00A08D78 File Offset: 0x00A06F78
		public bool DataProfFeatureContxActivHldoffMode_A36469_Valid
		{
			get
			{
				short num = (short)2113008940;
				short num2 = num;
				num = (short)888599852;
				switch (num2 == num)
				{
				}
				num = (short)1720975360;
				short num3 = num;
				num = (short)1765015552;
				if (num != 0)
				{
				}
				num = (short)222822401;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.Valid;
			}
			set
			{
				short num = (short)1954526094;
				short num2 = num;
				num = (short)132428686;
				switch (num2 == num)
				{
				}
				num = (short)1836777472;
				short num3 = num;
				num = (short)824901632;
				if (num != 0)
				{
				}
				num = (short)1776680961;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.Valid = value;
			}
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x00A08E30 File Offset: 0x00A07030
		// (set) Token: 0x0600AC5F RID: 44127 RVA: 0x00A08EE4 File Offset: 0x00A070E4
		public bool DataProfFeatureContxActivHldoffMode_A36469_Visible
		{
			get
			{
				short num = (short)17789555;
				short num2 = num;
				num = (short)1208513139;
				switch (num2 == num)
				{
				}
				num = (short)1606352896;
				short num3 = num;
				num = (short)436731904;
				if (num != 0)
				{
				}
				num = (short)795082753;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.Visible;
			}
			set
			{
				short num = (short)105842330;
				short num2 = num;
				num = (short)1694893722;
				switch (num2 == num)
				{
				}
				num = (short)937754624;
				short num3 = num;
				num = (short)210501633;
				if (num != 0)
				{
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.Visible = value;
			}
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x00A08F98 File Offset: 0x00A07198
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x00A09050 File Offset: 0x00A07250
		public bool DataProfFeatureContxActivHldoffMode_A36469_Editable
		{
			get
			{
				short num = (short)242339821;
				short num2 = num;
				num = (short)316067821;
				switch (num2 == num)
				{
				}
				num = (short)2059993088;
				short num3 = num;
				num = (short)31522816;
				if (num != 0)
				{
				}
				num = (short)694026241;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.Editable;
			}
			set
			{
				short num = (short)19542302;
				short num2 = num;
				num = (short)364196126;
				switch (num2 == num)
				{
				}
				num = (short)1316356096;
				short num3 = num;
				num = (short)1958739969;
				if (num != 0)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.Editable = value;
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x00A09108 File Offset: 0x00A07308
		internal string DataProfFeatureContxActivHldoffMode_A36469_UILabel
		{
			get
			{
				short num = (short)936380106;
				short num2 = num;
				num = (short)1914635978;
				switch (num2 == num)
				{
				}
				num = (short)204341248;
				short num3 = num;
				num = (short)2123366401;
				if (num != 0)
				{
				}
				num = (short)1787953152;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.UIName;
			}
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x0600AC63 RID: 44131 RVA: 0x00A091BC File Offset: 0x00A073BC
		// (set) Token: 0x0600AC64 RID: 44132 RVA: 0x00A09274 File Offset: 0x00A07474
		internal bool DataProfFeatureContxActivHldoffMode_A36469_HiddenStatic
		{
			get
			{
				short num = (short)1587088330;
				short num2 = num;
				num = (short)1063652298;
				switch (num2 == num)
				{
				}
				num = (short)1466433536;
				short num3 = num;
				num = (short)1023410177;
				if (num != 0)
				{
				}
				num = (short)1814888448;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.HiddenStatic;
			}
			set
			{
				short num = (short)707706996;
				short num2 = num;
				num = (short)1440989300;
				switch (num2 == num)
				{
				}
				num = (short)789577728;
				short num3 = num;
				num = (short)135462913;
				if (num != 0)
				{
				}
				num = (short)160104448;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.HiddenStatic = value;
			}
		}

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x00A0932C File Offset: 0x00A0752C
		// (set) Token: 0x0600AC66 RID: 44134 RVA: 0x00A093E0 File Offset: 0x00A075E0
		internal bool DataProfFeatureContxActivHldoffMode_A36469_HiddenDynamic
		{
			get
			{
				short num = (short)1032672954;
				short num2 = num;
				num = (short)2011780794;
				switch (num2 == num)
				{
				}
				num = (short)937623552;
				short num3 = num;
				num = (short)420806657;
				if (num != 0)
				{
				}
				num = (short)226951168;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469.HiddenDynamic;
			}
			set
			{
				short num = (short)1248634062;
				short num2 = num;
				num = (short)1720362190;
				switch (num2 == num)
				{
				}
				num = (short)815071232;
				short num3 = num;
				num = (short)356384769;
				if (num != 0)
				{
				}
				num = (short)312410112;
				if (num != 0)
				{
				}
				this.dataProfFeatureContxActivHldoffMode_A36469.HiddenDynamic = value;
			}
		}

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x0600AC67 RID: 44135 RVA: 0x00A09494 File Offset: 0x00A07694
		public bool DataProfFeatureContxActivHldoffMode_A36469_HasDiffs
		{
			get
			{
				short num = (short)1596456961;
				if (num != 0)
				{
				}
				num = (short)1814279444;
				short num2 = num;
				num = (short)2075309332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563557888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)597426176;
				if (num != 0)
				{
				}
				return this.dataProfFeatureContxActivHldoffMode_A36469._HasDiffs;
			}
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x00A09548 File Offset: 0x00A07748
		// (set) Token: 0x0600AC69 RID: 44137 RVA: 0x00A095FC File Offset: 0x00A077FC
		public int DataProfFeaturesApplicationNumberofAttempts_A7458Value
		{
			get
			{
				short num = (short)1297239122;
				short num2 = num;
				num = (short)336874578;
				switch (num2 == num)
				{
				}
				num = (short)589168640;
				short num3 = num;
				num = (short)1713963009;
				if (num != 0)
				{
				}
				num = (short)1585971200;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Value;
			}
			set
			{
				short num = (short)87031809;
				if (num != 0)
				{
				}
				num = (short)1099248178;
				short num2 = num;
				num = (short)258683442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336868864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1984299008;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Value = value;
			}
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x00A096B8 File Offset: 0x00A078B8
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfFeaturesApplicationNumberofAttempts_A7458
		{
			get
			{
				short num = (short)12000672;
				short num2 = num;
				num = (short)1409097120;
				switch (num2 == num)
				{
				}
				num = (short)1860960256;
				short num3 = num;
				num = (short)591593473;
				if (num != 0)
				{
				}
				num = (short)1077411840;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458;
			}
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x0600AC6B RID: 44139 RVA: 0x00A09768 File Offset: 0x00A07968
		// (set) Token: 0x0600AC6C RID: 44140 RVA: 0x00A0981C File Offset: 0x00A07A1C
		public string DataProfFeaturesApplicationNumberofAttempts_A7458_UIValue
		{
			get
			{
				short num = (short)1249968129;
				if (num != 0)
				{
				}
				num = (short)1564815861;
				short num2 = num;
				num = (short)872362485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16449536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406140416;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.UIValue;
			}
			set
			{
				short num = (short)681814971;
				short num2 = num;
				num = (short)909224891;
				switch (num2 == num)
				{
				}
				num = (short)1550712832;
				short num3 = num;
				num = (short)1797586945;
				if (num != 0)
				{
				}
				num = (short)1501036544;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.UIValue = value;
			}
		}

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x0600AC6D RID: 44141 RVA: 0x00A098D4 File Offset: 0x00A07AD4
		// (set) Token: 0x0600AC6E RID: 44142 RVA: 0x00A09988 File Offset: 0x00A07B88
		internal int DataProfFeaturesApplicationNumberofAttempts_A7458Min
		{
			get
			{
				short num = (short)5262505;
				short num2 = num;
				num = (short)1911704745;
				switch (num2 == num)
				{
				}
				num = (short)362217472;
				short num3 = num;
				num = (short)1673003009;
				if (num != 0)
				{
				}
				num = (short)1081081856;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Min;
			}
			set
			{
				short num = (short)701470694;
				short num2 = num;
				num = (short)1066637286;
				switch (num2 == num)
				{
				}
				num = (short)1074331648;
				short num3 = num;
				num = (short)527630337;
				if (num != 0)
				{
				}
				num = (short)1414987776;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Min = value;
			}
		}

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x00A09A40 File Offset: 0x00A07C40
		// (set) Token: 0x0600AC70 RID: 44144 RVA: 0x00A09AF4 File Offset: 0x00A07CF4
		internal int DataProfFeaturesApplicationNumberofAttempts_A7458Max
		{
			get
			{
				short num = (short)1189919138;
				short num2 = num;
				num = (short)2047654306;
				switch (num2 == num)
				{
				}
				num = (short)1190789120;
				short num3 = num;
				num = (short)1484390401;
				if (num != 0)
				{
				}
				num = (short)617283584;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Max;
			}
			set
			{
				short num = (short)933992035;
				short num2 = num;
				num = (short)2121897571;
				switch (num2 == num)
				{
				}
				num = (short)85786624;
				short num3 = num;
				num = (short)1993801728;
				if (num != 0)
				{
				}
				num = (short)113442817;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Max = value;
			}
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x00A09BA8 File Offset: 0x00A07DA8
		// (set) Token: 0x0600AC72 RID: 44146 RVA: 0x00A09C5C File Offset: 0x00A07E5C
		internal int DataProfFeaturesApplicationNumberofAttempts_A7458Step
		{
			get
			{
				short num = (short)1735608246;
				short num2 = num;
				num = (short)1589331894;
				switch (num2 == num)
				{
				}
				num = (short)2118844416;
				short num3 = num;
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)1095696384;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.StepSize;
			}
			set
			{
				short num = (short)317225313;
				short num2 = num;
				num = (short)398162273;
				switch (num2 == num)
				{
				}
				num = (short)1866465280;
				short num3 = num;
				num = (short)95617024;
				if (num != 0)
				{
				}
				num = (short)1821573121;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.StepSize = value;
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x00A09D14 File Offset: 0x00A07F14
		// (set) Token: 0x0600AC74 RID: 44148 RVA: 0x00A09DC8 File Offset: 0x00A07FC8
		public bool DataProfFeaturesApplicationNumberofAttempts_A7458_Applicable
		{
			get
			{
				short num = (short)589616123;
				short num2 = num;
				num = (short)1898370043;
				switch (num2 == num)
				{
				}
				num = (short)461045760;
				short num3 = num;
				num = (short)1678180353;
				if (num != 0)
				{
				}
				num = (short)922025984;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Applicable;
			}
			set
			{
				short num = (short)810680321;
				if (num != 0)
				{
				}
				num = (short)844329843;
				short num2 = num;
				num = (short)449016691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868693504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655032320;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Applicable = value;
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x0600AC75 RID: 44149 RVA: 0x00A09E80 File Offset: 0x00A08080
		// (set) Token: 0x0600AC76 RID: 44150 RVA: 0x00A09F34 File Offset: 0x00A08134
		public bool DataProfFeaturesApplicationNumberofAttempts_A7458_Valid
		{
			get
			{
				short num = (short)1912733697;
				if (num != 0)
				{
				}
				num = (short)1125403317;
				short num2 = num;
				num = (short)734218933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485176832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099431936;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Valid;
			}
			set
			{
				short num = (short)277559697;
				short num2 = num;
				num = (short)867056017;
				switch (num2 == num)
				{
				}
				num = (short)285868032;
				short num3 = num;
				num = (short)437846016;
				if (num != 0)
				{
				}
				num = (short)760283137;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Valid = value;
			}
		}

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x00A09FE8 File Offset: 0x00A081E8
		// (set) Token: 0x0600AC78 RID: 44152 RVA: 0x00A0A09C File Offset: 0x00A0829C
		public bool DataProfFeaturesApplicationNumberofAttempts_A7458_Visible
		{
			get
			{
				short num = (short)76307616;
				short num2 = num;
				num = (short)180640928;
				switch (num2 == num)
				{
				}
				num = (short)1993211904;
				short num3 = num;
				num = (short)1256390657;
				if (num != 0)
				{
				}
				num = (short)1807417344;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Visible;
			}
			set
			{
				short num = (short)783777468;
				short num2 = num;
				num = (short)464748220;
				switch (num2 == num)
				{
				}
				num = (short)315817984;
				short num3 = num;
				num = (short)1706557441;
				if (num != 0)
				{
				}
				num = (short)254345216;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Visible = value;
			}
		}

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x0600AC79 RID: 44153 RVA: 0x00A0A150 File Offset: 0x00A08350
		// (set) Token: 0x0600AC7A RID: 44154 RVA: 0x00A0A208 File Offset: 0x00A08408
		public bool DataProfFeaturesApplicationNumberofAttempts_A7458_Editable
		{
			get
			{
				short num = (short)414266807;
				short num2 = num;
				num = (short)390542775;
				switch (num2 == num)
				{
				}
				num = (short)1996357632;
				short num3 = num;
				num = (short)1209335808;
				if (num != 0)
				{
				}
				num = (short)442236929;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.Editable;
			}
			set
			{
				short num = (short)1361949765;
				short num2 = num;
				num = (short)1061008453;
				switch (num2 == num)
				{
				}
				num = (short)222035968;
				short num3 = num;
				num = (short)1574699009;
				if (num != 0)
				{
				}
				num = (short)958267392;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.Editable = value;
			}
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x0600AC7B RID: 44155 RVA: 0x00A0A2C0 File Offset: 0x00A084C0
		internal string DataProfFeaturesApplicationNumberofAttempts_A7458_UILabel
		{
			get
			{
				short num = (short)1682979378;
				short num2 = num;
				num = (short)95697458;
				switch (num2 == num)
				{
				}
				num = (short)1440284672;
				short num3 = num;
				num = (short)1236926465;
				if (num != 0)
				{
				}
				num = (short)228589568;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.UIName;
			}
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x00A0A370 File Offset: 0x00A08570
		// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x00A0A424 File Offset: 0x00A08624
		internal bool DataProfFeaturesApplicationNumberofAttempts_A7458_HiddenStatic
		{
			get
			{
				short num = (short)1053966910;
				short num2 = num;
				num = (short)137511486;
				switch (num2 == num)
				{
				}
				num = (short)1094844416;
				short num3 = num;
				num = (short)1874853889;
				if (num != 0)
				{
				}
				num = (short)677052416;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.HiddenStatic;
			}
			set
			{
				short num = (short)1811677652;
				short num2 = num;
				num = (short)1743847892;
				switch (num2 == num)
				{
				}
				num = (short)893452288;
				short num3 = num;
				num = (short)1991507969;
				if (num != 0)
				{
				}
				num = (short)938868736;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.HiddenStatic = value;
			}
		}

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x00A0A4D8 File Offset: 0x00A086D8
		// (set) Token: 0x0600AC7F RID: 44159 RVA: 0x00A0A58C File Offset: 0x00A0878C
		internal bool DataProfFeaturesApplicationNumberofAttempts_A7458_HiddenDynamic
		{
			get
			{
				short num = (short)86114305;
				if (num != 0)
				{
				}
				num = (short)1003365357;
				short num2 = num;
				num = (short)432677869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421279232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636237312;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458.HiddenDynamic;
			}
			set
			{
				short num = (short)1162278545;
				short num2 = num;
				num = (short)947320465;
				switch (num2 == num)
				{
				}
				num = (short)1458176000;
				short num3 = num;
				num = (short)692846593;
				if (num != 0)
				{
				}
				num = (short)1921908736;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationNumberofAttempts_A7458.HiddenDynamic = value;
			}
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x00A0A644 File Offset: 0x00A08844
		public bool DataProfFeaturesApplicationNumberofAttempts_A7458_HasDiffs
		{
			get
			{
				short num = (short)125179624;
				short num2 = num;
				num = (short)240719592;
				switch (num2 == num)
				{
				}
				num = (short)251985920;
				short num3 = num;
				num = (short)272236545;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationNumberofAttempts_A7458._HasDiffs;
			}
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x0600AC81 RID: 44161 RVA: 0x00A0A6F8 File Offset: 0x00A088F8
		// (set) Token: 0x0600AC82 RID: 44162 RVA: 0x00A0A7AC File Offset: 0x00A089AC
		public int TrkSysLabtoolRetransmissionTimersec_A8672Value
		{
			get
			{
				short num = (short)1825383783;
				short num2 = num;
				num = (short)771237223;
				switch (num2 == num)
				{
				}
				num = (short)580911104;
				short num3 = num;
				num = (short)935395329;
				if (num != 0)
				{
				}
				num = (short)859832320;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Value;
			}
			set
			{
				short num = (short)437880473;
				short num2 = num;
				num = (short)663783065;
				switch (num2 == num)
				{
				}
				num = (short)214564864;
				short num3 = num;
				num = (short)2003959809;
				if (num != 0)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Value = value;
			}
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x00A0A864 File Offset: 0x00A08A64
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysLabtoolRetransmissionTimersec_A8672
		{
			get
			{
				short num = (short)816531222;
				short num2 = num;
				num = (short)303777558;
				switch (num2 == num)
				{
				}
				num = (short)1442447360;
				short num3 = num;
				num = (short)776208385;
				if (num != 0)
				{
				}
				num = (short)2071330816;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672;
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x00A0A914 File Offset: 0x00A08B14
		// (set) Token: 0x0600AC85 RID: 44165 RVA: 0x00A0A9C8 File Offset: 0x00A08BC8
		public string TrkSysLabtoolRetransmissionTimersec_A8672_UIValue
		{
			get
			{
				short num = (short)649134080;
				short num2 = num;
				num = (short)1965771311;
				short num3 = num;
				num = (short)2137147951;
				switch (num3 == num)
				{
				}
				num = (short)701890560;
				if (num != 0)
				{
				}
				num = (short)820707329;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.UIValue;
			}
			set
			{
				short num = (short)17563648;
				short num2 = num;
				num = (short)1409516698;
				short num3 = num;
				num = (short)2138342554;
				switch (num3 == num)
				{
				}
				num = (short)1760231425;
				if (num != 0)
				{
				}
				num = (short)1185284096;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.UIValue = value;
			}
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x00A0AA80 File Offset: 0x00A08C80
		// (set) Token: 0x0600AC87 RID: 44167 RVA: 0x00A0AB34 File Offset: 0x00A08D34
		internal int TrkSysLabtoolRetransmissionTimersec_A8672Min
		{
			get
			{
				short num = (short)1335099392;
				short num2 = num;
				num = (short)1602971212;
				short num3 = num;
				num = (short)1976395340;
				switch (num3 == num)
				{
				}
				num = (short)1098186752;
				if (num != 0)
				{
				}
				num = (short)2075852801;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Min;
			}
			set
			{
				short num = (short)2123038720;
				short num2 = num;
				num = (short)1316480139;
				short num3 = num;
				num = (short)521397387;
				switch (num3 == num)
				{
				}
				num = (short)1276313601;
				if (num != 0)
				{
				}
				num = (short)1626800128;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Min = value;
			}
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x0600AC88 RID: 44168 RVA: 0x00A0ABEC File Offset: 0x00A08DEC
		// (set) Token: 0x0600AC89 RID: 44169 RVA: 0x00A0ACA0 File Offset: 0x00A08EA0
		internal int TrkSysLabtoolRetransmissionTimersec_A8672Max
		{
			get
			{
				short num = (short)2040070144;
				short num2 = num;
				num = (short)1485313709;
				short num3 = num;
				num = (short)79238829;
				switch (num3 == num)
				{
				}
				num = (short)463536128;
				if (num != 0)
				{
				}
				num = (short)104202241;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Max;
			}
			set
			{
				short num = (short)1240596480;
				short num2 = num;
				num = (short)1089899063;
				short num3 = num;
				num = (short)1593674295;
				switch (num3 == num)
				{
				}
				num = (short)1303838721;
				if (num != 0)
				{
				}
				num = (short)678428672;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Max = value;
			}
		}

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x0600AC8A RID: 44170 RVA: 0x00A0AD5C File Offset: 0x00A08F5C
		// (set) Token: 0x0600AC8B RID: 44171 RVA: 0x00A0AE10 File Offset: 0x00A09010
		internal int TrkSysLabtoolRetransmissionTimersec_A8672Step
		{
			get
			{
				short num = (short)925237248;
				short num2 = num;
				num = (short)1357106513;
				short num3 = num;
				num = (short)888458577;
				switch (num3 == num)
				{
				}
				num = (short)2042953729;
				if (num != 0)
				{
				}
				num = (short)230948864;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.StepSize;
			}
			set
			{
				short num = (short)1838612480;
				short num2 = num;
				num = (short)1470805649;
				short num3 = num;
				num = (short)1954002577;
				switch (num3 == num)
				{
				}
				num = (short)517472257;
				if (num != 0)
				{
				}
				num = (short)1317142528;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.StepSize = value;
			}
		}

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x00A0AEC4 File Offset: 0x00A090C4
		// (set) Token: 0x0600AC8D RID: 44173 RVA: 0x00A0AF78 File Offset: 0x00A09178
		public bool TrkSysLabtoolRetransmissionTimersec_A8672_Applicable
		{
			get
			{
				short num = (short)1108475904;
				short num2 = num;
				num = (short)1803479213;
				short num3 = num;
				num = (short)1784735917;
				switch (num3 == num)
				{
				}
				num = (short)1613234177;
				if (num != 0)
				{
				}
				num = (short)2087387136;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Applicable;
			}
			set
			{
				short num = (short)1794244608;
				short num2 = num;
				num = (short)1307017170;
				short num3 = num;
				num = (short)286752722;
				switch (num3 == num)
				{
				}
				num = (short)1757609985;
				if (num != 0)
				{
				}
				num = (short)1042022400;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Applicable = value;
			}
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x00A0B02C File Offset: 0x00A0922C
		// (set) Token: 0x0600AC8F RID: 44175 RVA: 0x00A0B0E4 File Offset: 0x00A092E4
		public bool TrkSysLabtoolRetransmissionTimersec_A8672_Valid
		{
			get
			{
				short num = (short)118554624;
				short num2 = num;
				num = (short)519473013;
				short num3 = num;
				num = (short)443254645;
				switch (num3 == num)
				{
				}
				num = (short)1168244737;
				if (num != 0)
				{
				}
				num = (short)221839360;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Valid;
			}
			set
			{
				short num = (short)1106968576;
				short num2 = num;
				num = (short)1764666423;
				short num3 = num;
				num = (short)145534007;
				switch (num3 == num)
				{
				}
				num = (short)43778048;
				if (num != 0)
				{
				}
				num = (short)534249473;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Valid = value;
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x0600AC90 RID: 44176 RVA: 0x00A0B198 File Offset: 0x00A09398
		// (set) Token: 0x0600AC91 RID: 44177 RVA: 0x00A0B24C File Offset: 0x00A0944C
		public bool TrkSysLabtoolRetransmissionTimersec_A8672_Visible
		{
			get
			{
				short num = (short)1445462016;
				short num2 = num;
				num = (short)1851695195;
				short num3 = num;
				num = (short)957587547;
				switch (num3 == num)
				{
				}
				num = (short)744751105;
				if (num != 0)
				{
				}
				num = (short)1801322496;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Visible;
			}
			set
			{
				short num = (short)1351417856;
				short num2 = num;
				num = (short)1222360267;
				short num3 = num;
				num = (short)1424211147;
				switch (num3 == num)
				{
				}
				num = (short)1378353152;
				if (num != 0)
				{
				}
				num = (short)838860801;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Visible = value;
			}
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x0600AC92 RID: 44178 RVA: 0x00A0B304 File Offset: 0x00A09504
		// (set) Token: 0x0600AC93 RID: 44179 RVA: 0x00A0B3BC File Offset: 0x00A095BC
		public bool TrkSysLabtoolRetransmissionTimersec_A8672_Editable
		{
			get
			{
				short num = (short)2083258368;
				short num2 = num;
				num = (short)536877581;
				short num3 = num;
				num = (short)1774983693;
				switch (num3 == num)
				{
				}
				num = (short)1352400896;
				if (num != 0)
				{
				}
				num = (short)1839005697;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.Editable;
			}
			set
			{
				short num = (short)948633600;
				short num2 = num;
				num = (short)1418243445;
				short num3 = num;
				num = (short)1476963701;
				switch (num3 == num)
				{
				}
				num = (short)248119297;
				if (num != 0)
				{
				}
				num = (short)466878464;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.Editable = value;
			}
		}

		// Token: 0x17005672 RID: 22130
		// (get) Token: 0x0600AC94 RID: 44180 RVA: 0x00A0B474 File Offset: 0x00A09674
		internal string TrkSysLabtoolRetransmissionTimersec_A8672_UILabel
		{
			get
			{
				short num = (short)389480448;
				short num2 = num;
				num = (short)1187315713;
				if (num != 0)
				{
				}
				num = (short)1228093996;
				short num3 = num;
				num = (short)1405434412;
				switch (num3 == num)
				{
				}
				num = (short)1052114944;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.UIName;
			}
		}

		// Token: 0x17005673 RID: 22131
		// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x00A0B528 File Offset: 0x00A09728
		// (set) Token: 0x0600AC96 RID: 44182 RVA: 0x00A0B5DC File Offset: 0x00A097DC
		internal bool TrkSysLabtoolRetransmissionTimersec_A8672_HiddenStatic
		{
			get
			{
				short num = (short)1315635200;
				short num2 = num;
				num = (short)1808965240;
				short num3 = num;
				num = (short)1949408888;
				switch (num3 == num)
				{
				}
				num = (short)1170997249;
				if (num != 0)
				{
				}
				num = (short)1348927488;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.HiddenStatic;
			}
			set
			{
				short num = (short)1497956352;
				short num2 = num;
				num = (short)1103532839;
				short num3 = num;
				num = (short)46109479;
				switch (num3 == num)
				{
				}
				num = (short)1294925825;
				if (num != 0)
				{
				}
				num = (short)824377344;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.HiddenStatic = value;
			}
		}

		// Token: 0x17005674 RID: 22132
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x00A0B690 File Offset: 0x00A09890
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x00A0B744 File Offset: 0x00A09944
		internal bool TrkSysLabtoolRetransmissionTimersec_A8672_HiddenDynamic
		{
			get
			{
				short num = (short)1870594048;
				short num2 = num;
				num = (short)744588600;
				short num3 = num;
				num = (short)1659274552;
				switch (num3 == num)
				{
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				num = (short)160038913;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672.HiddenDynamic;
			}
			set
			{
				short num = (short)1136394240;
				short num2 = num;
				num = (short)626915212;
				short num3 = num;
				num = (short)2098460556;
				switch (num3 == num)
				{
				}
				num = (short)2095972353;
				if (num != 0)
				{
				}
				num = (short)1514668032;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRetransmissionTimersec_A8672.HiddenDynamic = value;
			}
		}

		// Token: 0x17005675 RID: 22133
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x00A0B7F8 File Offset: 0x00A099F8
		public bool TrkSysLabtoolRetransmissionTimersec_A8672_HasDiffs
		{
			get
			{
				short num = (short)1701445632;
				short num2 = num;
				num = (short)908962345;
				short num3 = num;
				num = (short)1198434857;
				switch (num3 == num)
				{
				}
				num = (short)1320419328;
				if (num != 0)
				{
				}
				num = (short)2012151809;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRetransmissionTimersec_A8672._HasDiffs;
			}
		}

		// Token: 0x17005676 RID: 22134
		// (get) Token: 0x0600AC9A RID: 44186 RVA: 0x00A0B8B0 File Offset: 0x00A09AB0
		// (set) Token: 0x0600AC9B RID: 44187 RVA: 0x00A0B964 File Offset: 0x00A09B64
		public int DatProFeaturesMaximumBufferThreshold_A20542Value
		{
			get
			{
				short num = (short)221839360;
				short num2 = num;
				num = (short)1935904013;
				short num3 = num;
				num = (short)790727949;
				switch (num3 == num)
				{
				}
				num = (short)906100736;
				if (num != 0)
				{
				}
				num = (short)2088042497;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Value;
			}
			set
			{
				short num = (short)1528168448;
				short num2 = num;
				num = (short)1472301757;
				short num3 = num;
				num = (short)264669885;
				switch (num3 == num)
				{
				}
				num = (short)1184956417;
				if (num != 0)
				{
				}
				num = (short)1041235968;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Value = value;
			}
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x0600AC9C RID: 44188 RVA: 0x00A0BA1C File Offset: 0x00A09C1C
		public global::AcpBusinessLayer.AcpSimpleRangeField DatProFeaturesMaximumBufferThreshold_A20542
		{
			get
			{
				short num = (short)48693248;
				short num2 = num;
				num = (short)787325557;
				short num3 = num;
				num = (short)1833804405;
				switch (num3 == num)
				{
				}
				num = (short)998244353;
				if (num != 0)
				{
				}
				num = (short)2087780352;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542;
			}
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x00A0BAC8 File Offset: 0x00A09CC8
		// (set) Token: 0x0600AC9E RID: 44190 RVA: 0x00A0BB80 File Offset: 0x00A09D80
		public string DatProFeaturesMaximumBufferThreshold_A20542_UIValue
		{
			get
			{
				short num = (short)1081081856;
				short num2 = num;
				num = (short)1514760859;
				short num3 = num;
				num = (short)1360947867;
				switch (num3 == num)
				{
				}
				num = (short)47120385;
				if (num != 0)
				{
				}
				num = (short)1861943296;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.UIValue;
			}
			set
			{
				short num = (short)2093940736;
				short num2 = num;
				num = (short)1928557270;
				short num3 = num;
				num = (short)638481110;
				switch (num3 == num)
				{
				}
				num = (short)1560805377;
				if (num != 0)
				{
				}
				num = (short)1840054272;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.UIValue = value;
			}
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x0600AC9F RID: 44191 RVA: 0x00A0BC34 File Offset: 0x00A09E34
		// (set) Token: 0x0600ACA0 RID: 44192 RVA: 0x00A0BCEC File Offset: 0x00A09EEC
		internal int DatProFeaturesMaximumBufferThreshold_A20542Min
		{
			get
			{
				short num = (short)1916862464;
				short num2 = num;
				num = (short)2034368513;
				if (num != 0)
				{
				}
				num = (short)1626819198;
				short num3 = num;
				num = (short)1924221566;
				switch (num3 == num)
				{
				}
				num = (short)1448542208;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Min;
			}
			set
			{
				short num = (short)144244736;
				short num2 = num;
				num = (short)1751842817;
				if (num != 0)
				{
				}
				num = (short)1669664324;
				short num3 = num;
				num = (short)1512312388;
				switch (num3 == num)
				{
				}
				num = (short)2014511104;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Min = value;
			}
		}

		// Token: 0x1700567A RID: 22138
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x00A0BDA4 File Offset: 0x00A09FA4
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x00A0BE58 File Offset: 0x00A0A058
		internal int DatProFeaturesMaximumBufferThreshold_A20542Max
		{
			get
			{
				short num = (short)301400064;
				short num2 = num;
				num = (short)582231823;
				short num3 = num;
				num = (short)1663117071;
				switch (num3 == num)
				{
				}
				num = (short)5570561;
				if (num != 0)
				{
				}
				num = (short)13762560;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Max;
			}
			set
			{
				short num = (short)2075590656;
				short num2 = num;
				num = (short)552409868;
				short num3 = num;
				num = (short)1504058124;
				switch (num3 == num)
				{
				}
				num = (short)1176698881;
				if (num != 0)
				{
				}
				num = (short)430964736;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Max = value;
			}
		}

		// Token: 0x1700567B RID: 22139
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x00A0BF0C File Offset: 0x00A0A10C
		// (set) Token: 0x0600ACA4 RID: 44196 RVA: 0x00A0BFC0 File Offset: 0x00A0A1C0
		internal int DatProFeaturesMaximumBufferThreshold_A20542Step
		{
			get
			{
				short num = (short)896204800;
				short num2 = num;
				num = (short)1526040147;
				short num3 = num;
				num = (short)1915979347;
				switch (num3 == num)
				{
				}
				num = (short)1653604352;
				if (num != 0)
				{
				}
				num = (short)394526721;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.StepSize;
			}
			set
			{
				short num = (short)192675840;
				short num2 = num;
				num = (short)1390134799;
				short num3 = num;
				num = (short)890947087;
				switch (num3 == num)
				{
				}
				num = (short)581500929;
				if (num != 0)
				{
				}
				num = (short)459341824;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.StepSize = value;
			}
		}

		// Token: 0x1700567C RID: 22140
		// (get) Token: 0x0600ACA5 RID: 44197 RVA: 0x00A0C074 File Offset: 0x00A0A274
		// (set) Token: 0x0600ACA6 RID: 44198 RVA: 0x00A0C12C File Offset: 0x00A0A32C
		public bool DatProFeaturesMaximumBufferThreshold_A20542_Applicable
		{
			get
			{
				short num = (short)604110848;
				short num2 = num;
				num = (short)1906966529;
				if (num != 0)
				{
				}
				num = (short)1401639120;
				short num3 = num;
				num = (short)909136080;
				switch (num3 == num)
				{
				}
				num = (short)691929088;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Applicable;
			}
			set
			{
				short num = (short)1603665920;
				short num2 = num;
				num = (short)344223603;
				short num3 = num;
				num = (short)1309831027;
				switch (num3 == num)
				{
				}
				num = (short)388431873;
				if (num != 0)
				{
				}
				num = (short)990052352;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Applicable = value;
			}
		}

		// Token: 0x1700567D RID: 22141
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x00A0C1E4 File Offset: 0x00A0A3E4
		// (set) Token: 0x0600ACA8 RID: 44200 RVA: 0x00A0C298 File Offset: 0x00A0A498
		public bool DatProFeaturesMaximumBufferThreshold_A20542_Valid
		{
			get
			{
				short num = (short)1360855040;
				short num2 = num;
				num = (short)783749576;
				short num3 = num;
				num = (short)115151304;
				switch (num3 == num)
				{
				}
				num = (short)348782593;
				if (num != 0)
				{
				}
				num = (short)1669070848;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Valid;
			}
			set
			{
				short num = (short)638386176;
				short num2 = num;
				num = (short)768926057;
				short num3 = num;
				num = (short)1468588393;
				switch (num3 == num)
				{
				}
				num = (short)1581580289;
				if (num != 0)
				{
				}
				num = (short)1343750144;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Valid = value;
			}
		}

		// Token: 0x1700567E RID: 22142
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x00A0C350 File Offset: 0x00A0A550
		// (set) Token: 0x0600ACAA RID: 44202 RVA: 0x00A0C404 File Offset: 0x00A0A604
		public bool DatProFeaturesMaximumBufferThreshold_A20542_Visible
		{
			get
			{
				short num = (short)1528233984;
				short num2 = num;
				num = (short)1674679510;
				short num3 = num;
				num = (short)790795478;
				switch (num3 == num)
				{
				}
				num = (short)1726283777;
				if (num != 0)
				{
				}
				num = (short)1214840832;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Visible;
			}
			set
			{
				short num = (short)657719296;
				short num2 = num;
				num = (short)1267252558;
				short num3 = num;
				num = (short)500743502;
				switch (num3 == num)
				{
				}
				num = (short)790364161;
				if (num != 0)
				{
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Visible = value;
			}
		}

		// Token: 0x1700567F RID: 22143
		// (get) Token: 0x0600ACAB RID: 44203 RVA: 0x00A0C4BC File Offset: 0x00A0A6BC
		// (set) Token: 0x0600ACAC RID: 44204 RVA: 0x00A0C570 File Offset: 0x00A0A770
		public bool DatProFeaturesMaximumBufferThreshold_A20542_Editable
		{
			get
			{
				short num = (short)1201668096;
				short num2 = num;
				num = (short)299166011;
				short num3 = num;
				num = (short)401140027;
				switch (num3 == num)
				{
				}
				num = (short)1339359233;
				if (num != 0)
				{
				}
				num = (short)338427904;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.Editable;
			}
			set
			{
				short num = (short)213778432;
				short num2 = num;
				num = (short)2063433060;
				short num3 = num;
				num = (short)566000996;
				switch (num3 == num)
				{
				}
				num = (short)681115648;
				if (num != 0)
				{
				}
				num = (short)1289879553;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.Editable = value;
			}
		}

		// Token: 0x17005680 RID: 22144
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x00A0C628 File Offset: 0x00A0A828
		internal string DatProFeaturesMaximumBufferThreshold_A20542_UILabel
		{
			get
			{
				short num = (short)1266679808;
				short num2 = num;
				num = (short)175538943;
				short num3 = num;
				num = (short)1048543999;
				switch (num3 == num)
				{
				}
				num = (short)2127167489;
				if (num != 0)
				{
				}
				num = (short)61210624;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.UIName;
			}
		}

		// Token: 0x17005681 RID: 22145
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x00A0C6DC File Offset: 0x00A0A8DC
		// (set) Token: 0x0600ACAF RID: 44207 RVA: 0x00A0C794 File Offset: 0x00A0A994
		internal bool DatProFeaturesMaximumBufferThreshold_A20542_HiddenStatic
		{
			get
			{
				short num = (short)864026624;
				short num2 = num;
				num = (short)1626108915;
				short num3 = num;
				num = (short)44463091;
				switch (num3 == num)
				{
				}
				num = (short)49610752;
				if (num != 0)
				{
				}
				num = (short)1954742273;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.HiddenStatic;
			}
			set
			{
				short num = (short)1613824000;
				short num2 = num;
				num = (short)537657066;
				short num3 = num;
				num = (short)734461674;
				switch (num3 == num)
				{
				}
				num = (short)130154496;
				if (num != 0)
				{
				}
				num = (short)1342570497;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.HiddenStatic = value;
			}
		}

		// Token: 0x17005682 RID: 22146
		// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x00A0C848 File Offset: 0x00A0AA48
		// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x00A0C8FC File Offset: 0x00A0AAFC
		internal bool DatProFeaturesMaximumBufferThreshold_A20542_HiddenDynamic
		{
			get
			{
				short num = (short)321585152;
				short num2 = num;
				num = (short)2075700802;
				short num3 = num;
				num = (short)1244638786;
				switch (num3 == num)
				{
				}
				num = (short)49086465;
				if (num != 0)
				{
				}
				num = (short)1170931712;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542.HiddenDynamic;
			}
			set
			{
				short num = (short)945094656;
				short num2 = num;
				num = (short)789841933;
				short num3 = num;
				num = (short)851511309;
				switch (num3 == num)
				{
				}
				num = (short)2047803392;
				if (num != 0)
				{
				}
				num = (short)1905065985;
				if (num != 0)
				{
				}
				this.datProFeaturesMaximumBufferThreshold_A20542.HiddenDynamic = value;
			}
		}

		// Token: 0x17005683 RID: 22147
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x00A0C9B0 File Offset: 0x00A0ABB0
		public bool DatProFeaturesMaximumBufferThreshold_A20542_HasDiffs
		{
			get
			{
				short num = (short)193527808;
				short num2 = num;
				num = (short)207788503;
				short num3 = num;
				num = (short)296458711;
				switch (num3 == num)
				{
				}
				num = (short)1991180288;
				if (num != 0)
				{
				}
				num = (short)881393665;
				if (num != 0)
				{
				}
				return this.datProFeaturesMaximumBufferThreshold_A20542._HasDiffs;
			}
		}

		// Token: 0x17005684 RID: 22148
		// (get) Token: 0x0600ACB3 RID: 44211 RVA: 0x00A0CA64 File Offset: 0x00A0AC64
		// (set) Token: 0x0600ACB4 RID: 44212 RVA: 0x00A0CB18 File Offset: 0x00A0AD18
		public int DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Value
		{
			get
			{
				short num = (short)1077346304;
				short num2 = num;
				num = (short)372737394;
				short num3 = num;
				num = (short)1834059122;
				switch (num3 == num)
				{
				}
				num = (short)1997537280;
				if (num != 0)
				{
				}
				num = (short)525664257;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Value;
			}
			set
			{
				short num = (short)894304256;
				short num2 = num;
				num = (short)5105606;
				short num3 = num;
				num = (short)1320347590;
				switch (num3 == num)
				{
				}
				num = (short)1047003136;
				if (num != 0)
				{
				}
				num = (short)1534001153;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Value = value;
			}
		}

		// Token: 0x17005685 RID: 22149
		// (get) Token: 0x0600ACB5 RID: 44213 RVA: 0x00A0CBCC File Offset: 0x00A0ADCC
		public global::AcpBusinessLayer.AcpRangeField<int, string> DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460
		{
			get
			{
				short num = (short)819920896;
				short num2 = num;
				num = (short)1828877943;
				short num3 = num;
				num = (short)970225271;
				switch (num3 == num)
				{
				}
				num = (short)708378625;
				if (num != 0)
				{
				}
				num = (short)1781202944;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;
			}
		}

		// Token: 0x17005686 RID: 22150
		// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x00A0CC7C File Offset: 0x00A0AE7C
		// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x00A0CD30 File Offset: 0x00A0AF30
		public string DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_UIValue
		{
			get
			{
				short num = (short)1852178432;
				short num2 = num;
				num = (short)1250278500;
				short num3 = num;
				num = (short)1548401764;
				switch (num3 == num)
				{
				}
				num = (short)1279655937;
				if (num != 0)
				{
				}
				num = (short)945750016;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.UIValue;
			}
			set
			{
				short num = (short)1680408576;
				short num2 = num;
				num = (short)1918990448;
				short num3 = num;
				num = (short)323909744;
				switch (num3 == num)
				{
				}
				num = (short)847577089;
				if (num != 0)
				{
				}
				num = (short)1063845888;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.UIValue = value;
			}
		}

		// Token: 0x17005687 RID: 22151
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x00A0CDE4 File Offset: 0x00A0AFE4
		// (set) Token: 0x0600ACB9 RID: 44217 RVA: 0x00A0CEA0 File Offset: 0x00A0B0A0
		internal int DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Min
		{
			get
			{
				short num = (short)669122560;
				short num2 = num;
				num = (short)1113690688;
				short num3 = num;
				num = (short)115380800;
				switch (num3 == num)
				{
				}
				num = (short)269156352;
				if (num != 0)
				{
				}
				num = (short)1821966337;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Min;
			}
			set
			{
				short num = (short)483721216;
				short num2 = num;
				num = (short)1650852193;
				short num3 = num;
				num = (short)1224212833;
				switch (num3 == num)
				{
				}
				num = (short)941228032;
				if (num != 0)
				{
				}
				num = (short)2055077889;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Min = value;
			}
		}

		// Token: 0x17005688 RID: 22152
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x00A0CF54 File Offset: 0x00A0B154
		// (set) Token: 0x0600ACBB RID: 44219 RVA: 0x00A0D008 File Offset: 0x00A0B208
		internal int DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Max
		{
			get
			{
				short num = (short)47316992;
				short num2 = num;
				num = (short)2080133001;
				short num3 = num;
				num = (short)1149521801;
				switch (num3 == num)
				{
				}
				num = (short)251527169;
				if (num != 0)
				{
				}
				num = (short)1800339456;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Max;
			}
			set
			{
				short num = (short)1708195840;
				short num2 = num;
				num = (short)123535361;
				if (num != 0)
				{
				}
				num = (short)337485829;
				short num3 = num;
				num = (short)2125635589;
				switch (num3 == num)
				{
				}
				num = (short)832700416;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Max = value;
			}
		}

		// Token: 0x17005689 RID: 22153
		// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x00A0D0C4 File Offset: 0x00A0B2C4
		// (set) Token: 0x0600ACBD RID: 44221 RVA: 0x00A0D178 File Offset: 0x00A0B378
		internal int DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Step
		{
			get
			{
				short num = (short)1841624972;
				short num2 = num;
				num = (short)1387460492;
				switch (num2 == num)
				{
				}
				num = (short)443547649;
				if (num != 0)
				{
				}
				num = (short)1887567872;
				short num3 = num;
				num = (short)358350848;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.StepSize;
			}
			set
			{
				short num = (short)1172167567;
				short num2 = num;
				num = (short)2003098511;
				switch (num2 == num)
				{
				}
				num = (short)1318584321;
				if (num != 0)
				{
				}
				num = (short)580845568;
				short num3 = num;
				num = (short)666763264;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.StepSize = value;
			}
		}

		// Token: 0x1700568A RID: 22154
		// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x00A0D230 File Offset: 0x00A0B430
		// (set) Token: 0x0600ACBF RID: 44223 RVA: 0x00A0D2E4 File Offset: 0x00A0B4E4
		public bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_Applicable
		{
			get
			{
				short num = (short)916341270;
				short num2 = num;
				num = (short)2110734870;
				switch (num2 == num)
				{
				}
				num = (short)79560705;
				if (num != 0)
				{
				}
				num = (short)1892024320;
				short num3 = num;
				num = (short)2038759424;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Applicable;
			}
			set
			{
				short num = (short)554675217;
				short num2 = num;
				num = (short)1311026193;
				switch (num2 == num)
				{
				}
				num = (short)1231159297;
				if (num != 0)
				{
				}
				num = (short)2110914560;
				short num3 = num;
				num = (short)1920532480;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Applicable = value;
			}
		}

		// Token: 0x1700568B RID: 22155
		// (get) Token: 0x0600ACC0 RID: 44224 RVA: 0x00A0D39C File Offset: 0x00A0B59C
		// (set) Token: 0x0600ACC1 RID: 44225 RVA: 0x00A0D450 File Offset: 0x00A0B650
		public bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_Valid
		{
			get
			{
				short num = (short)969807713;
				short num2 = num;
				num = (short)1276122977;
				switch (num2 == num)
				{
				}
				num = (short)1754333185;
				if (num != 0)
				{
				}
				num = (short)1875443712;
				short num3 = num;
				num = (short)799670272;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Valid;
			}
			set
			{
				short num = (short)1192919762;
				short num2 = num;
				num = (short)877101778;
				switch (num2 == num)
				{
				}
				num = (short)2145189889;
				if (num != 0)
				{
				}
				num = (short)1960706048;
				short num3 = num;
				num = (short)1993015296;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Valid = value;
			}
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x00A0D504 File Offset: 0x00A0B704
		// (set) Token: 0x0600ACC3 RID: 44227 RVA: 0x00A0D5BC File Offset: 0x00A0B7BC
		public bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_Visible
		{
			get
			{
				short num = (short)904898637;
				short num2 = num;
				num = (short)2137303117;
				switch (num2 == num)
				{
				}
				num = (short)1207238657;
				if (num != 0)
				{
				}
				num = (short)844890112;
				short num3 = num;
				num = (short)1584463872;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Visible;
			}
			set
			{
				short num = (short)363774366;
				short num2 = num;
				num = (short)1014874526;
				switch (num2 == num)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)992739328;
				short num3 = num;
				num = (short)1794113536;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Visible = value;
			}
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x00A0D670 File Offset: 0x00A0B870
		// (set) Token: 0x0600ACC5 RID: 44229 RVA: 0x00A0D724 File Offset: 0x00A0B924
		public bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_Editable
		{
			get
			{
				short num = (short)1505780933;
				short num2 = num;
				num = (short)715809989;
				switch (num2 == num)
				{
				}
				num = (short)1867972609;
				if (num != 0)
				{
				}
				num = (short)1968504832;
				short num3 = num;
				num = (short)37093376;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Editable;
			}
			set
			{
				short num = (short)1479541025;
				short num2 = num;
				num = (short)473301281;
				switch (num2 == num)
				{
				}
				num = (short)2072117249;
				if (num != 0)
				{
				}
				num = (short)1555365888;
				short num3 = num;
				num = (short)444203008;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.Editable = value;
			}
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x00A0D7DC File Offset: 0x00A0B9DC
		internal string DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_UILabel
		{
			get
			{
				short num = (short)1947199016;
				short num2 = num;
				num = (short)185132584;
				switch (num2 == num)
				{
				}
				num = (short)1077542913;
				if (num != 0)
				{
				}
				num = (short)833945600;
				short num3 = num;
				num = (short)706150400;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.UIName;
			}
		}

		// Token: 0x1700568F RID: 22159
		// (get) Token: 0x0600ACC7 RID: 44231 RVA: 0x00A0D894 File Offset: 0x00A0BA94
		// (set) Token: 0x0600ACC8 RID: 44232 RVA: 0x00A0D948 File Offset: 0x00A0BB48
		internal bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_HiddenStatic
		{
			get
			{
				short num = (short)1148342155;
				short num2 = num;
				num = (short)1877430155;
				switch (num2 == num)
				{
				}
				num = (short)2046033921;
				if (num != 0)
				{
				}
				num = (short)74055680;
				short num3 = num;
				num = (short)1853751296;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.HiddenStatic;
			}
			set
			{
				short num = (short)1389514071;
				short num2 = num;
				num = (short)37178711;
				switch (num2 == num)
				{
				}
				num = (short)388628481;
				if (num != 0)
				{
				}
				num = (short)609157120;
				short num3 = num;
				num = (short)1518862336;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.HiddenStatic = value;
			}
		}

		// Token: 0x17005690 RID: 22160
		// (get) Token: 0x0600ACC9 RID: 44233 RVA: 0x00A0D9FC File Offset: 0x00A0BBFC
		// (set) Token: 0x0600ACCA RID: 44234 RVA: 0x00A0DAB0 File Offset: 0x00A0BCB0
		internal bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_HiddenDynamic
		{
			get
			{
				short num = (short)87361605;
				short num2 = num;
				num = (short)754387013;
				switch (num2 == num)
				{
				}
				num = (short)1738145793;
				if (num != 0)
				{
				}
				num = (short)1784807424;
				short num3 = num;
				num = (short)1229324288;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.HiddenDynamic;
			}
			set
			{
				short num = (short)116902923;
				short num2 = num;
				num = (short)1399049227;
				switch (num2 == num)
				{
				}
				num = (short)1684799488;
				if (num != 0)
				{
				}
				num = (short)662175744;
				short num3 = num;
				num = (short)125108225;
				if (num != 0)
				{
				}
				this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.HiddenDynamic = value;
			}
		}

		// Token: 0x17005691 RID: 22161
		// (get) Token: 0x0600ACCB RID: 44235 RVA: 0x00A0DB68 File Offset: 0x00A0BD68
		public bool DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460_HasDiffs
		{
			get
			{
				short num = (short)2031723862;
				short num2 = num;
				num = (short)1532601686;
				switch (num2 == num)
				{
				}
				num = (short)1656750081;
				if (num != 0)
				{
				}
				num = (short)632684544;
				short num3 = num;
				num = (short)833945600;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460._HasDiffs;
			}
		}

		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x00A0DC20 File Offset: 0x00A0BE20
		// (set) Token: 0x0600ACCD RID: 44237 RVA: 0x00A0DCD8 File Offset: 0x00A0BED8
		public bool DataProfFeaturesDirLocReg_A42332Value
		{
			get
			{
				short num = (short)288547113;
				short num2 = num;
				num = (short)372302121;
				switch (num2 == num)
				{
				}
				num = (short)176750592;
				if (num != 0)
				{
				}
				num = (short)870449152;
				short num3 = num;
				num = (short)1006370817;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Value;
			}
			set
			{
				short num = (short)741583339;
				short num2 = num;
				num = (short)1464052203;
				switch (num2 == num)
				{
				}
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1590689792;
				short num3 = num;
				num = (short)711852032;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Value = value;
			}
		}

		// Token: 0x17005693 RID: 22163
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x00A0DD90 File Offset: 0x00A0BF90
		public global::AcpBusinessLayer.AcpField<bool> DataProfFeaturesDirLocReg_A42332
		{
			get
			{
				short num = (short)583794689;
				if (num != 0)
				{
				}
				num = (short)70387668;
				short num2 = num;
				num = (short)1658456020;
				switch (num2 == num)
				{
				}
				num = (short)216334336;
				short num3 = num;
				num = (short)1881931776;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332;
			}
		}

		// Token: 0x17005694 RID: 22164
		// (get) Token: 0x0600ACCF RID: 44239 RVA: 0x00A0DE40 File Offset: 0x00A0C040
		// (set) Token: 0x0600ACD0 RID: 44240 RVA: 0x00A0DEF4 File Offset: 0x00A0C0F4
		public bool DataProfFeaturesDirLocReg_A42332_UIValue
		{
			get
			{
				short num = (short)1901264897;
				if (num != 0)
				{
				}
				num = (short)877425805;
				short num2 = num;
				num = (short)2100655245;
				switch (num2 == num)
				{
				}
				num = (short)1993408512;
				short num3 = num;
				num = (short)212795392;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Value;
			}
			set
			{
				short num = (short)1720006198;
				short num2 = num;
				num = (short)302462518;
				switch (num2 == num)
				{
				}
				num = (short)77529088;
				if (num != 0)
				{
				}
				num = (short)198967296;
				short num3 = num;
				num = (short)52101121;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Value = value;
			}
		}

		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x0600ACD1 RID: 44241 RVA: 0x00A0DFAC File Offset: 0x00A0C1AC
		// (set) Token: 0x0600ACD2 RID: 44242 RVA: 0x00A0E064 File Offset: 0x00A0C264
		public bool DataProfFeaturesDirLocReg_A42332_Applicable
		{
			get
			{
				short num = (short)653692451;
				short num2 = num;
				num = (short)1033539107;
				switch (num2 == num)
				{
				}
				num = (short)1822556160;
				if (num != 0)
				{
				}
				num = (short)526188544;
				short num3 = num;
				num = (short)745275393;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Applicable;
			}
			set
			{
				short num = (short)1182400513;
				if (num != 0)
				{
				}
				num = (short)1535958138;
				short num2 = num;
				num = (short)1565252730;
				switch (num2 == num)
				{
				}
				num = (short)1607991296;
				short num3 = num;
				num = (short)1725431808;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Applicable = value;
			}
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x0600ACD3 RID: 44243 RVA: 0x00A0E118 File Offset: 0x00A0C318
		// (set) Token: 0x0600ACD4 RID: 44244 RVA: 0x00A0E1CC File Offset: 0x00A0C3CC
		public bool DataProfFeaturesDirLocReg_A42332_Valid
		{
			get
			{
				short num = (short)1183029863;
				short num2 = num;
				num = (short)287611495;
				switch (num2 == num)
				{
				}
				num = (short)1279197184;
				if (num != 0)
				{
				}
				num = (short)778305536;
				short num3 = num;
				num = (short)358744065;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Valid;
			}
			set
			{
				short num = (short)2140655811;
				short num2 = num;
				num = (short)1191563459;
				switch (num2 == num)
				{
				}
				num = (short)227344385;
				if (num != 0)
				{
				}
				num = (short)711196672;
				short num3 = num;
				num = (short)344391680;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Valid = value;
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x0600ACD5 RID: 44245 RVA: 0x00A0E284 File Offset: 0x00A0C484
		// (set) Token: 0x0600ACD6 RID: 44246 RVA: 0x00A0E33C File Offset: 0x00A0C53C
		public bool DataProfFeaturesDirLocReg_A42332_Visible
		{
			get
			{
				short num = (short)1034087779;
				short num2 = num;
				num = (short)961539427;
				switch (num2 == num)
				{
				}
				num = (short)1152057345;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				short num3 = num;
				num = (short)631570432;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Visible;
			}
			set
			{
				short num = (short)688284344;
				short num2 = num;
				num = (short)799433400;
				switch (num2 == num)
				{
				}
				num = (short)1393623041;
				if (num != 0)
				{
				}
				num = (short)1058340864;
				short num3 = num;
				num = (short)1555628032;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Visible = value;
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x0600ACD7 RID: 44247 RVA: 0x00A0E3F0 File Offset: 0x00A0C5F0
		// (set) Token: 0x0600ACD8 RID: 44248 RVA: 0x00A0E4A4 File Offset: 0x00A0C6A4
		public bool DataProfFeaturesDirLocReg_A42332_Editable
		{
			get
			{
				short num = (short)1206687693;
				short num2 = num;
				num = (short)289445837;
				switch (num2 == num)
				{
				}
				num = (short)226885633;
				if (num != 0)
				{
				}
				num = (short)1310851072;
				short num3 = num;
				num = (short)174915584;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.Editable;
			}
			set
			{
				short num = (short)739639297;
				if (num != 0)
				{
				}
				num = (short)443574954;
				short num2 = num;
				num = (short)1343056554;
				switch (num2 == num)
				{
				}
				num = (short)1032650752;
				short num3 = num;
				num = (short)931659776;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.Editable = value;
			}
		}

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x0600ACD9 RID: 44249 RVA: 0x00A0E558 File Offset: 0x00A0C758
		internal string DataProfFeaturesDirLocReg_A42332_UILabel
		{
			get
			{
				short num = (short)2014904321;
				if (num != 0)
				{
				}
				num = (short)520200860;
				short num2 = num;
				num = (short)504341148;
				switch (num2 == num)
				{
				}
				num = (short)95289344;
				short num3 = num;
				num = (short)15728640;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.UIName;
			}
		}

		// Token: 0x1700569A RID: 22170
		// (get) Token: 0x0600ACDA RID: 44250 RVA: 0x00A0E610 File Offset: 0x00A0C810
		// (set) Token: 0x0600ACDB RID: 44251 RVA: 0x00A0E6C4 File Offset: 0x00A0C8C4
		internal bool DataProfFeaturesDirLocReg_A42332_HiddenStatic
		{
			get
			{
				short num = (short)2074411009;
				if (num != 0)
				{
				}
				num = (short)1381561362;
				short num2 = num;
				num = (short)1080947730;
				switch (num2 == num)
				{
				}
				num = (short)304611328;
				short num3 = num;
				num = (short)953090048;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.HiddenStatic;
			}
			set
			{
				short num = (short)1889584302;
				short num2 = num;
				num = (short)744080558;
				switch (num2 == num)
				{
				}
				num = (short)2127429632;
				if (num != 0)
				{
				}
				num = (short)522911744;
				short num3 = num;
				num = (short)867762177;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.HiddenStatic = value;
			}
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x00A0E77C File Offset: 0x00A0C97C
		// (set) Token: 0x0600ACDD RID: 44253 RVA: 0x00A0E830 File Offset: 0x00A0CA30
		internal bool DataProfFeaturesDirLocReg_A42332_HiddenDynamic
		{
			get
			{
				short num = (short)1388642630;
				short num2 = num;
				num = (short)1747124550;
				switch (num2 == num)
				{
				}
				num = (short)566231041;
				if (num != 0)
				{
				}
				num = (short)787087360;
				short num3 = num;
				num = (short)1180434432;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332.HiddenDynamic;
			}
			set
			{
				short num = (short)1197789038;
				short num2 = num;
				num = (short)804835182;
				switch (num2 == num)
				{
				}
				num = (short)2040594433;
				if (num != 0)
				{
				}
				num = (short)798228480;
				short num3 = num;
				num = (short)2091778048;
				if (num != 0)
				{
				}
				this.dataProfFeaturesDirLocReg_A42332.HiddenDynamic = value;
			}
		}

		// Token: 0x1700569C RID: 22172
		// (get) Token: 0x0600ACDE RID: 44254 RVA: 0x00A0E8E8 File Offset: 0x00A0CAE8
		public bool DataProfFeaturesDirLocReg_A42332_HasDiffs
		{
			get
			{
				short num = (short)2125601339;
				short num2 = num;
				num = (short)974592571;
				switch (num2 == num)
				{
				}
				num = (short)1176371201;
				if (num != 0)
				{
				}
				num = (short)1032978432;
				short num3 = num;
				num = (short)554369024;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesDirLocReg_A42332._HasDiffs;
			}
		}

		// Token: 0x1700569D RID: 22173
		// (get) Token: 0x0600ACDF RID: 44255 RVA: 0x00A0E9A0 File Offset: 0x00A0CBA0
		// (set) Token: 0x0600ACE0 RID: 44256 RVA: 0x00A0EA54 File Offset: 0x00A0CC54
		public bool DataProfFeaturesAtakFieldValue
		{
			get
			{
				short num = (short)863372762;
				short num2 = num;
				num = (short)1144325594;
				switch (num2 == num)
				{
				}
				num = (short)204275713;
				if (num != 0)
				{
				}
				num = (short)1171456000;
				short num3 = num;
				num = (short)1845100544;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Value;
			}
			set
			{
				short num = (short)645332993;
				if (num != 0)
				{
				}
				num = (short)2090226368;
				short num2 = num;
				num = (short)1425035968;
				switch (num2 == num)
				{
				}
				num = (short)600244224;
				short num3 = num;
				num = (short)639107072;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Value = value;
			}
		}

		// Token: 0x1700569E RID: 22174
		// (get) Token: 0x0600ACE1 RID: 44257 RVA: 0x00A0EB08 File Offset: 0x00A0CD08
		public global::AcpBusinessLayer.AcpField<bool> DataProfFeaturesAtakField
		{
			get
			{
				short num = (short)1603735868;
				short num2 = num;
				num = (short)375263548;
				switch (num2 == num)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				num = (short)726663168;
				short num3 = num;
				num = (short)494403585;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField;
			}
		}

		// Token: 0x1700569F RID: 22175
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x00A0EBB4 File Offset: 0x00A0CDB4
		// (set) Token: 0x0600ACE3 RID: 44259 RVA: 0x00A0EC68 File Offset: 0x00A0CE68
		public bool DataProfFeaturesAtakField_UIValue
		{
			get
			{
				short num = (short)17104897;
				if (num != 0)
				{
				}
				num = (short)27644378;
				short num2 = num;
				num = (short)779866586;
				switch (num2 == num)
				{
				}
				num = (short)22478848;
				short num3 = num;
				num = (short)1304756224;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Value;
			}
			set
			{
				short num = (short)85785233;
				short num2 = num;
				num = (short)379189905;
				switch (num2 == num)
				{
				}
				num = (short)1501298689;
				if (num != 0)
				{
				}
				num = (short)209453056;
				short num3 = num;
				num = (short)1288110080;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Value = value;
			}
		}

		// Token: 0x170056A0 RID: 22176
		// (get) Token: 0x0600ACE4 RID: 44260 RVA: 0x00A0ED1C File Offset: 0x00A0CF1C
		// (set) Token: 0x0600ACE5 RID: 44261 RVA: 0x00A0EDD0 File Offset: 0x00A0CFD0
		public bool DataProfFeaturesAtakField_Applicable
		{
			get
			{
				short num = (short)1915935410;
				short num2 = num;
				num = (short)176609970;
				switch (num2 == num)
				{
				}
				num = (short)832569345;
				if (num != 0)
				{
				}
				num = (short)753860608;
				short num3 = num;
				num = (short)1532755968;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Applicable;
			}
			set
			{
				short num = (short)390640213;
				short num2 = num;
				num = (short)1001042517;
				switch (num2 == num)
				{
				}
				num = (short)436404225;
				if (num != 0)
				{
				}
				num = (short)1791557632;
				short num3 = num;
				num = (short)34799616;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Applicable = value;
			}
		}

		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x0600ACE6 RID: 44262 RVA: 0x00A0EE88 File Offset: 0x00A0D088
		// (set) Token: 0x0600ACE7 RID: 44263 RVA: 0x00A0EF3C File Offset: 0x00A0D13C
		public bool DataProfFeaturesAtakField_Valid
		{
			get
			{
				short num = (short)1888918052;
				short num2 = num;
				num = (short)1597020708;
				switch (num2 == num)
				{
				}
				num = (short)1747058688;
				if (num != 0)
				{
				}
				num = (short)353435648;
				short num3 = num;
				num = (short)295436289;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Valid;
			}
			set
			{
				short num = (short)1679622145;
				if (num != 0)
				{
				}
				num = (short)1828695328;
				short num2 = num;
				num = (short)1869720864;
				switch (num2 == num)
				{
				}
				num = (short)2090532864;
				short num3 = num;
				num = (short)722731008;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Valid = value;
			}
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x0600ACE8 RID: 44264 RVA: 0x00A0EFF4 File Offset: 0x00A0D1F4
		// (set) Token: 0x0600ACE9 RID: 44265 RVA: 0x00A0F0AC File Offset: 0x00A0D2AC
		public bool DataProfFeaturesAtakField_Visible
		{
			get
			{
				short num = (short)180560356;
				short num2 = num;
				num = (short)1256268260;
				switch (num2 == num)
				{
				}
				num = (short)682164225;
				if (num != 0)
				{
				}
				num = (short)900857856;
				short num3 = num;
				num = (short)1210187776;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Visible;
			}
			set
			{
				short num = (short)1059015244;
				short num2 = num;
				num = (short)208357964;
				switch (num2 == num)
				{
				}
				num = (short)1284636673;
				if (num != 0)
				{
				}
				num = (short)115867648;
				short num3 = num;
				num = (short)1809580032;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Visible = value;
			}
		}

		// Token: 0x170056A3 RID: 22179
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x00A0F160 File Offset: 0x00A0D360
		// (set) Token: 0x0600ACEB RID: 44267 RVA: 0x00A0F214 File Offset: 0x00A0D414
		public bool DataProfFeaturesAtakField_Editable
		{
			get
			{
				short num = (short)1578514458;
				short num2 = num;
				num = (short)831076378;
				switch (num2 == num)
				{
				}
				num = (short)1310326785;
				if (num != 0)
				{
				}
				num = (short)1506279424;
				short num3 = num;
				num = (short)1904869376;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.Editable;
			}
			set
			{
				short num = (short)55697281;
				short num2 = num;
				num = (short)24240001;
				switch (num2 == num)
				{
				}
				num = (short)420741121;
				if (num != 0)
				{
				}
				num = (short)519700480;
				short num3 = num;
				num = (short)913965056;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.Editable = value;
			}
		}

		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x0600ACEC RID: 44268 RVA: 0x00A0F2C8 File Offset: 0x00A0D4C8
		internal string DataProfFeaturesAtakField_UILabel
		{
			get
			{
				short num = (short)565619307;
				short num2 = num;
				num = (short)321366635;
				switch (num2 == num)
				{
				}
				num = (short)1117454337;
				if (num != 0)
				{
				}
				num = (short)582811648;
				short num3 = num;
				num = (short)495255552;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.UIName;
			}
		}

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x0600ACED RID: 44269 RVA: 0x00A0F37C File Offset: 0x00A0D57C
		// (set) Token: 0x0600ACEE RID: 44270 RVA: 0x00A0F430 File Offset: 0x00A0D630
		internal bool DataProfFeaturesAtakField_HiddenStatic
		{
			get
			{
				short num = (short)724375310;
				short num2 = num;
				num = (short)358029070;
				switch (num2 == num)
				{
				}
				num = (short)2036531200;
				if (num != 0)
				{
				}
				num = (short)624885760;
				short num3 = num;
				num = (short)326303745;
				if (num != 0)
				{
				}
				return this.dataProfFeaturesAtakField.HiddenStatic;
			}
			set
			{
				short num = (short)243832647;
				short num2 = num;
				num = (short)153392967;
				switch (num2 == num)
				{
				}
				num = (short)1495400449;
				if (num != 0)
				{
				}
				num = (short)1716649984;
				short num3 = num;
				num = (short)1364262912;
				if (num != 0)
				{
				}
				this.dataProfFeaturesAtakField.HiddenStatic = value;
			}
		}

		// Token: 0x170056A6 RID: 22182
		// (get) Token: 0x0600ACEF RID: 44271 RVA: 0x00A0F4E4 File Offset: 0x00A0D6E4
		// (set) Token: 0x0600ACF0 RID: 44272 RVA: 0x00A0F598 File Offset: 0x00A0D798
		internal bool DataProfFeaturesAtakField_HiddenDynamic
		{
			get
			{
				short num = (short)1515513941;
				short num2 = num;
				num = (short)1810819157;
				switch (num2 == num)
				{
				}
				num = (short)155451393;
				if (num != 0)
				{
				}
				num = (short)358023168;
				if (num != 0)
				{
				}
				num = (short)560594944;
				short num3 = num;
				return this.dataProfFeaturesAtakField.HiddenDynamic;
			}
			set
			{
				short num = (short)1235220876;
				short num2 = num;
				num = (short)1814952332;
				switch (num2 == num)
				{
				}
				num = (short)1413939200;
				if (num != 0)
				{
				}
				num = (short)896204801;
				if (num != 0)
				{
				}
				num = (short)1022230528;
				short num3 = num;
				this.dataProfFeaturesAtakField.HiddenDynamic = value;
			}
		}

		// Token: 0x170056A7 RID: 22183
		// (get) Token: 0x0600ACF1 RID: 44273 RVA: 0x00A0F64C File Offset: 0x00A0D84C
		public bool DataProfFeaturesAtakField_HasDiffs
		{
			get
			{
				short num = (short)1311038204;
				short num2 = num;
				num = (short)1848892156;
				switch (num2 == num)
				{
				}
				num = (short)268632065;
				if (num != 0)
				{
				}
				num = (short)167378944;
				if (num != 0)
				{
				}
				num = (short)1877868544;
				short num3 = num;
				return this.dataProfFeaturesAtakField._HasDiffs;
			}
		}

		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x0600ACF2 RID: 44274 RVA: 0x00A0F700 File Offset: 0x00A0D900
		// (set) Token: 0x0600ACF3 RID: 44275 RVA: 0x00A0F7B8 File Offset: 0x00A0D9B8
		public long DataProfFeaturesLocServerIPAddr_A42333Value
		{
			get
			{
				short num = (short)275775489;
				if (num != 0)
				{
				}
				num = (short)843475407;
				short num2 = num;
				num = (short)1129671119;
				switch (num2 == num)
				{
				}
				num = (short)672989184;
				if (num != 0)
				{
				}
				num = (short)268435456;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.Value;
			}
			set
			{
				short num = (short)353528169;
				short num2 = num;
				num = (short)1400924521;
				switch (num2 == num)
				{
				}
				num = (short)356122624;
				if (num != 0)
				{
				}
				num = (short)2011299841;
				if (num != 0)
				{
				}
				num = (short)435027968;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.Value = value;
			}
		}

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x0600ACF4 RID: 44276 RVA: 0x00A0F86C File Offset: 0x00A0DA6C
		// (set) Token: 0x0600ACF5 RID: 44277 RVA: 0x00A0F920 File Offset: 0x00A0DB20
		public string DataProfFeaturesLocServerIPAddr_A42333_UIValue
		{
			get
			{
				short num = (short)351338260;
				short num2 = num;
				num = (short)1548680980;
				switch (num2 == num)
				{
				}
				num = (short)1521483777;
				if (num != 0)
				{
				}
				num = (short)1769078784;
				if (num != 0)
				{
				}
				num = (short)312737792;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.UIValue;
			}
			set
			{
				short num = (short)1463920558;
				short num2 = num;
				num = (short)460367790;
				switch (num2 == num)
				{
				}
				num = (short)1296826368;
				if (num != 0)
				{
				}
				num = (short)869007361;
				if (num != 0)
				{
				}
				num = (short)1596456960;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.UIValue = value;
			}
		}

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x0600ACF6 RID: 44278 RVA: 0x00A0F9D8 File Offset: 0x00A0DBD8
		public global::AcpBusinessLayer.AcpIPAddressField DataProfFeaturesLocServerIPAddr_A42333
		{
			get
			{
				short num = (short)2039733069;
				short num2 = num;
				num = (short)1689836365;
				switch (num2 == num)
				{
				}
				num = (short)651952129;
				if (num != 0)
				{
				}
				num = (short)1143209984;
				if (num != 0)
				{
				}
				num = (short)1652293632;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333;
			}
		}

		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x0600ACF7 RID: 44279 RVA: 0x00A0FA88 File Offset: 0x00A0DC88
		// (set) Token: 0x0600ACF8 RID: 44280 RVA: 0x00A0FB3C File Offset: 0x00A0DD3C
		public bool DataProfFeaturesLocServerIPAddr_A42333_Applicable
		{
			get
			{
				short num = (short)1592535550;
				short num2 = num;
				num = (short)1124149758;
				switch (num2 == num)
				{
				}
				num = (short)281346048;
				if (num != 0)
				{
				}
				num = (short)1152581633;
				if (num != 0)
				{
				}
				num = (short)1651638272;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.Applicable;
			}
			set
			{
				short num = (short)233897985;
				if (num != 0)
				{
				}
				num = (short)983769114;
				short num2 = num;
				num = (short)1228808218;
				switch (num2 == num)
				{
				}
				num = (short)768933888;
				if (num != 0)
				{
				}
				num = (short)1525940224;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.Applicable = value;
			}
		}

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x0600ACF9 RID: 44281 RVA: 0x00A0FBF4 File Offset: 0x00A0DDF4
		// (set) Token: 0x0600ACFA RID: 44282 RVA: 0x00A0FCAC File Offset: 0x00A0DEAC
		public bool DataProfFeaturesLocServerIPAddr_A42333_Valid
		{
			get
			{
				short num = (short)76943487;
				short num2 = num;
				num = (short)1128271999;
				switch (num2 == num)
				{
				}
				num = (short)151715840;
				if (num != 0)
				{
				}
				num = (short)1619394561;
				if (num != 0)
				{
				}
				num = (short)647954432;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.Valid;
			}
			set
			{
				short num = (short)580802291;
				short num2 = num;
				num = (short)112744179;
				switch (num2 == num)
				{
				}
				num = (short)687538177;
				if (num != 0)
				{
				}
				num = (short)868417536;
				if (num != 0)
				{
				}
				num = (short)2053701632;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.Valid = value;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x00A0FD68 File Offset: 0x00A0DF68
		// (set) Token: 0x0600ACFC RID: 44284 RVA: 0x00A0FE20 File Offset: 0x00A0E020
		public bool DataProfFeaturesLocServerIPAddr_A42333_Visible
		{
			get
			{
				short num = (short)409911849;
				short num2 = num;
				num = (short)2010038825;
				switch (num2 == num)
				{
				}
				num = (short)1955725313;
				if (num != 0)
				{
				}
				num = (short)1946615808;
				if (num != 0)
				{
				}
				num = (short)169017344;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.Visible;
			}
			set
			{
				short num = (short)1684737294;
				short num2 = num;
				num = (short)40766734;
				switch (num2 == num)
				{
				}
				num = (short)1518600193;
				if (num != 0)
				{
				}
				num = (short)1462960128;
				if (num != 0)
				{
				}
				num = (short)1554972672;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.Visible = value;
			}
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x00A0FED8 File Offset: 0x00A0E0D8
		// (set) Token: 0x0600ACFE RID: 44286 RVA: 0x00A0FF8C File Offset: 0x00A0E18C
		public bool DataProfFeaturesLocServerIPAddr_A42333_Editable
		{
			get
			{
				short num = (short)223945082;
				short num2 = num;
				num = (short)1175069050;
				switch (num2 == num)
				{
				}
				num = (short)391970817;
				if (num != 0)
				{
				}
				num = (short)1974534144;
				if (num != 0)
				{
				}
				num = (short)1141178368;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.Editable;
			}
			set
			{
				short num = (short)1799114308;
				short num2 = num;
				num = (short)1378176580;
				switch (num2 == num)
				{
				}
				num = (short)1299775488;
				if (num != 0)
				{
				}
				num = (short)1733623809;
				if (num != 0)
				{
				}
				num = (short)644808704;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.Editable = value;
			}
		}

		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x00A10044 File Offset: 0x00A0E244
		internal string DataProfFeaturesLocServerIPAddr_A42333_UILabel
		{
			get
			{
				short num = (short)755006953;
				short num2 = num;
				num = (short)1825340905;
				switch (num2 == num)
				{
				}
				num = (short)1271726081;
				if (num != 0)
				{
				}
				num = (short)976617472;
				if (num != 0)
				{
				}
				num = (short)782565376;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.UIName;
			}
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x0600AD00 RID: 44288 RVA: 0x00A100F8 File Offset: 0x00A0E2F8
		// (set) Token: 0x0600AD01 RID: 44289 RVA: 0x00A101AC File Offset: 0x00A0E3AC
		internal bool DataProfFeaturesLocServerIPAddr_A42333_HiddenStatic
		{
			get
			{
				short num = (short)686026249;
				short num2 = num;
				num = (short)392031753;
				switch (num2 == num)
				{
				}
				num = (short)1110048768;
				if (num != 0)
				{
				}
				num = (short)2125660161;
				if (num != 0)
				{
				}
				num = (short)470351872;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.HiddenStatic;
			}
			set
			{
				short num = (short)1862911537;
				short num2 = num;
				num = (short)543409713;
				switch (num2 == num)
				{
				}
				num = (short)1227358208;
				if (num != 0)
				{
				}
				num = (short)1646067713;
				if (num != 0)
				{
				}
				num = (short)2018967552;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.HiddenStatic = value;
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x0600AD02 RID: 44290 RVA: 0x00A10260 File Offset: 0x00A0E460
		// (set) Token: 0x0600AD03 RID: 44291 RVA: 0x00A10318 File Offset: 0x00A0E518
		internal bool DataProfFeaturesLocServerIPAddr_A42333_HiddenDynamic
		{
			get
			{
				short num = (short)369316501;
				short num2 = num;
				num = (short)464671381;
				switch (num2 == num)
				{
				}
				num = (short)1022099457;
				if (num != 0)
				{
				}
				num = (short)1455226880;
				if (num != 0)
				{
				}
				num = (short)737935360;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333.HiddenDynamic;
			}
			set
			{
				short num = (short)490328044;
				short num2 = num;
				num = (short)2061619180;
				switch (num2 == num)
				{
				}
				num = (short)2092302336;
				if (num != 0)
				{
				}
				num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)2066219008;
				short num3 = num;
				this.dataProfFeaturesLocServerIPAddr_A42333.HiddenDynamic = value;
			}
		}

		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x0600AD04 RID: 44292 RVA: 0x00A103D0 File Offset: 0x00A0E5D0
		public bool DataProfFeaturesLocServerIPAddr_A42333_HasDiffs
		{
			get
			{
				short num = (short)616103937;
				if (num != 0)
				{
				}
				num = (short)1713035281;
				short num2 = num;
				num = (short)953866257;
				switch (num2 == num)
				{
				}
				num = (short)1278410752;
				if (num != 0)
				{
				}
				num = (short)943652864;
				short num3 = num;
				return this.dataProfFeaturesLocServerIPAddr_A42333._HasDiffs;
			}
		}

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x0600AD05 RID: 44293 RVA: 0x00A10484 File Offset: 0x00A0E684
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide RefDataWide
		{
			get
			{
				short num = (short)1752763715;
				short num2 = num;
				num = (short)15797571;
				switch (num2 == num)
				{
				}
				num = (short)1317142529;
				if (num != 0)
				{
				}
				num = (short)321388544;
				if (num != 0)
				{
				}
				num = (short)688848896;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			}
		}

		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x0600AD06 RID: 44294 RVA: 0x00A10544 File Offset: 0x00A0E744
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)832674266;
				short num2 = num;
				num = (short)1509005786;
				switch (num2 == num)
				{
				}
				num = (short)2046164992;
				if (num != 0)
				{
				}
				num = (short)1572405249;
				if (num != 0)
				{
				}
				num = (short)1084948480;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x00A10600 File Offset: 0x00A0E800
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
					num2 = (short)1076855776;
					short num3 = num2;
					num2 = (short)1186104288;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
					{
						num2 = (short)544604160;
						if (num2 != 0)
						{
						}
						num2 = (short)213843968;
						short num4 = num2;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1607663619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					num2 = (short)1958281217;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)278200322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)523370500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_D9;
					}
					return result;
				}
				goto IL_24;
				IL_D9:
				num2 = (short)122486784;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)571867137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053AF RID: 21423
		private global::AcpBusinessLayer.AcpListField dataProfFeaturesARSMode_A7465;

		// Token: 0x040053B0 RID: 21424
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x040053B1 RID: 21425
		private global::AcpBusinessLayer.AcpIPAddressField dataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x040053B2 RID: 21426
		private global::AcpBusinessLayer.AcpField<bool> dataProfFeaturesTerminalData_A9288;

		// Token: 0x040053B3 RID: 21427
		private global::AcpBusinessLayer.AcpListField datProFeaturesPADMode_A20536;

		// Token: 0x040053B4 RID: 21428
		private global::AcpBusinessLayer.AcpField<string> datProFeaturesStartSequence_A20537;

		// Token: 0x040053B5 RID: 21429
		private global::AcpBusinessLayer.AcpField<string> datProFeaturesStopSequence_A20538;

		// Token: 0x040053B6 RID: 21430
		private global::AcpBusinessLayer.AcpField<string> datProFeaturesEscapeSequence_A20539;

		// Token: 0x040053B7 RID: 21431
		private global::AcpBusinessLayer.AcpRangeField<int, string> datProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x040053B8 RID: 21432
		private global::AcpBusinessLayer.AcpRangeField<int, string> datProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x040053B9 RID: 21433
		private global::AcpBusinessLayer.AcpIPAddressField datProFeaturesDestinationAddress_A20543;

		// Token: 0x040053BA RID: 21434
		private global::AcpBusinessLayer.AcpSimpleRangeField datProFeaturesDestinationPort_A20544;

		// Token: 0x040053BB RID: 21435
		private global::AcpBusinessLayer.AcpListField dataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x040053BC RID: 21436
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x040053BD RID: 21437
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x040053BE RID: 21438
		private global::AcpBusinessLayer.AcpSimpleRangeField datProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x040053BF RID: 21439
		private global::AcpBusinessLayer.AcpRangeField<int, string> dataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x040053C0 RID: 21440
		private global::AcpBusinessLayer.AcpField<bool> dataProfFeaturesDirLocReg_A42332;

		// Token: 0x040053C1 RID: 21441
		private global::AcpBusinessLayer.AcpField<bool> dataProfFeaturesAtakField;

		// Token: 0x040053C2 RID: 21442
		private global::AcpBusinessLayer.AcpIPAddressField dataProfFeaturesLocServerIPAddr_A42333;
	}
}
