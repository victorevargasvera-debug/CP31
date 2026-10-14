using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E2 RID: 1250
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A48B RID: 42123 RVA: 0x00998BAC File Offset: 0x00996DAC
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x00998BC8 File Offset: 0x00996DC8
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x00998BE0 File Offset: 0x00996DE0
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1419957668;
			short num2 = num;
			num = (short)345888164;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1670643712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2008154113;
			if (num != 0)
			{
			}
			num = (short)1664483328;
			if (num != 0)
			{
			}
			this.dataWideGeneralContextDeactivationAlertTone_A7715 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪껬胮鿰蟲郴迶跸뿺飼黾戀眂氄焆栈缊搌怎缐划礔爖欘漚䤜瀞传䘢稤昦Ḩᰪᰬᨮ", a_), global::CommonResources.AcgResources.ID_CONTEXTDEACTIVATIONALERTTONE);
			this.dataWideGeneralContextDeactivationAlertTone_A7715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideGeneralContextDeactivationAlertTone_A7715.DataTransferOrder = 1;
			this.dataWideGeneralICMPEcho_A8219 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪ꓬ곮볰ꏲ냴银釸铺ꋼ뻾㤀㄂㐄㸆", a_), global::CommonResources.AcgResources.ID_ICMPECHO);
			this.dataWideGeneralICMPEcho_A8219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralICMPEcho_A8219.DataTransferOrder = 2;
			this.dataWideGeneralPeerIPAddress1_A8524 = new global::AcpBusinessLayer.AcpIPAddressField(41986240L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪뷬諮铰臲보ꟶ룸鿺駼跾搀瀂瘄㘆嘈䨊㔌㨎⌐✒", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESS);
			this.dataWideGeneralPeerIPAddress1_A8524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralPeerIPAddress1_A8524.DataTransferOrder = 6;
			this.dataWideGeneralSNMPTraps_A9166 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪뻬ꇮ볰ꏲꇴ藶飸诺軼ꃾ䀀㨂㐄ㄆ㼈", a_), global::CommonResources.AcgResources.ID_SNMPTRAPS);
			this.dataWideGeneralSNMPTraps_A9166.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideGeneralSNMPTraps_A9166.DataTransferOrder = 5;
			this.dataWideGeneralSubscriberIPAddress1_A9222 = new global::AcpBusinessLayer.AcpIPAddressField(25209024L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪뻬髮鏰胲雴藶郸駺飼跾䠀匂䐄挆洈礊栌簎成−䨔嘖‘⤚⼜ⴞ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESSUBSCRIBERIPADDRESS);
			this.dataWideGeneralSubscriberIPAddress1_A9222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralSubscriberIPAddress1_A9222.DataTransferOrder = 3;
			this.dataWideGeneralPeerIPAddressAssignmentType1_A22376 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪뷬諮铰臲보ꟶ룸鿺駼跾搀瀂瘄䘆稈砊搌栎缐縒瀔礖洘会搜漞䐠ሢ稤昦ᬨᤪḬᠮܰ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralPeerIPAddressAssignmentType1_A22376LovStrs);
			this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.DataTransferOrder = 7;
			this.dataWideGeneralPeerIPAddressAssignmentType2_A22377 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪뷬諮铰臲보ꟶ룸鿺駼跾搀瀂瘄䘆稈砊搌栎缐縒瀔礖洘会搜漞䐠ᄢ稤昦ᬨᤪḬᠮذ", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralPeerIPAddressAssignmentType2_A22377LovStrs);
			this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.DataTransferOrder = 28;
			this.dataWideGeneralBTDUNSUIPAddress_A41120 = new global::AcpBusinessLayer.AcpIPAddressField(25340096L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪꿬믮뗰꛲믴ꓶ곸닺근뻾攀朂眄戆稈砊刌与┐−␔┖⤘", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESSUBSCRIBERIPADDRESS);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralBTDUNSUIPAddress_A41120.DataTransferOrder = 13;
			this.dataWideGeneralBTDUNPeerIPAddress_A41123 = new global::AcpBusinessLayer.AcpIPAddressField(42117312L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪꿬믮뗰꛲믴ꟶ鳸黺迼뛾儀䈂愄挆笈渊縌簎丐划℔☖⠘⤚⸜", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESS);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.DataTransferOrder = 14;
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪꿬믮뗰꛲믴ꟶ鳸黺迼뛾儀䈂愄挆笈渊縌簎倐怒昔縖縘甚瀜稞传圢焤带夨个爬渮԰ȲдԶസ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124LovStrs);
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.DataTransferOrder = 8;
			this.dataWideGeneralDeleteMessagesOnSessionEnd_41308 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪ꧬ諮鷰雲致鋶듸黺軼賾怀搂怄理䘈攊希樎成怒簔砖眘帚猜笞縠ᜢᐤᐦᤨጪ", a_), global::CommonResources.AcgResources.ID_DELETEMESSAGESONSESSIONEND);
			this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.DataTransferOrder = 60;
			this.dataWideGeneralDVRIPAddress_A41818 = new global::AcpBusinessLayer.AcpIPAddressField(42051776L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪ꧬ맮ꏰ뫲ꗴ뛶鷸鿺迼髾爀瀂娄䘆㴈㨊㔌㸎⤐", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESPEERIPADDRESS);
			this.dataWideGeneralDVRIPAddress_A41818.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralDVRIPAddress_A41818.DataTransferOrder = 27;
			this.dataWideGeneralMobileSubIPAddress_A41819 = new global::AcpBusinessLayer.AcpIPAddressField(25274560L, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪ꃬ胮鏰髲駴鋶꫸軺鿼뛾儀䈂愄挆笈渊縌簎丐划℔☖℘⨚␜", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESSUBSCRIBERIPADDRESS);
			this.dataWideGeneralMobileSubIPAddress_A41819.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralMobileSubIPAddress_A41819.DataTransferOrder = 26;
			this.dataWideGeneralInternalRadioSubnet_A42073 = new global::AcpBusinessLayer.AcpFieldX<long, string>((long)((ulong)-956301312), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConvertSubnetAddress(), this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪ꓬ臮藰雲蟴駶飸韺꿼黾攀樂樄吆簈椊挌樎攐䰒吔⌖⬘⬚⨜Ⱎ", a_), global::CommonResources.AcgResources.ID_INTERNALRADIOSUBNET);
			this.dataWideGeneralInternalRadioSubnet_A42073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dataWideGeneralInternalRadioSubnet_A42073.DataTransferOrder = 55;
			this.dataWideLTEAPCOAvalancheTime_A42204 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜鏞뗠ꛢꓤ럦ꫨꓪ곬駮郰鿲铴駶髸鏺飼꯾栀渂怄堆䠈㼊㼌㴎ℐ✒", a_), global::CommonResources.AcgResources.ID_APCOAVALANCHETIMESEC, 0, 3600, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.dataWideLTEAPCOAvalancheTime_A42204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideLTEAPCOAvalancheTime_A42204.DataTransferOrder = 56;
			this.dataWideLTEAPCOAvalancheTime_A42204.ShowHexValue = false;
			this.directTMSContentDisplay_42323 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎룐ꇒ냔듖귘迚郜賞ꋠ賢诤鏦賨藪駬꯮飰胲藴鯶飸苺ꋼ쯾㌀。㜄㐆", a_), global::CommonResources.AcgResources.ID_DIRECTTMSCONTENTDISPLAY);
			this.directTMSContentDisplay_42323.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.directTMSContentDisplay_42323.DataTransferOrder = 61;
			this.dataWideExternalTextMessagingBroadcast_42418 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜髞駠韢胤闦蟨諪臬믮铰诲致뫶鳸裺軼黾昀樂欄怆䬈礊戌渎甐瀒琔搖洘䐚⤜ⴞᔠሢᴤ", a_), global::CommonResources.AcgResources.ID_EXTERNALTEXTMESSAGINGBROADCAST);
			this.dataWideExternalTextMessagingBroadcast_42418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalTextMessagingBroadcast_42418.DataTransferOrder = 62;
			this.dataWideGeneralBroadbandCheckbackTime_A42862 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔胖냘뿚룜飞蓠跢胤闦裨蟪꿬鷮黰鋲釴闶飸闺駼볾椀昂昄氆欈樊渌搎䔐稒研爖䘘娚⤜ⴞᤠᔢᜤ", a_), global::CommonResources.AcgResources.ID_BROADBANDCHECKBACKTIMESEC, 0, 3600, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LegacyTitles.DataWideGeneralBroadbandCheckbackTime_A42862LegacyTitles);
			this.dataWideGeneralBroadbandCheckbackTime_A42862.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralBroadbandCheckbackTime_A42862.DataTransferOrder = 77;
			this.dataWideGeneralBroadbandCheckbackTime_A42862.ShowHexValue = false;
			this.sensorMeasurementReporting_A43021 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳎듐뷒ꛔ룖ꯘ雚룜뻞鋠離韤苦蓨軪菬鯮ꏰ雲藴飶诸迺铼釾昀専䐄㌆㨈㬊㼌㸎", a_), global::CommonResources.AcgResources.ID_SENSORMEASUREMENTREPORTING);
			this.sensorMeasurementReporting_A43021.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.sensorMeasurementReporting_A43021.DataTransferOrder = 70;
			this.acknowledgedGunHolsterStateReportingEnable_43551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軎닐룒믔룖께럚룜믞蛠蛢臤ꃦ鳨藪ꗬ胮鷰胲致鋶诸꣺觼黾甀昂圄戆礈搊缌笎砐紒爔刖眘稚缜猞䐠簢ᄤᐦᰨḪᰬ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDGUNHOLSTERSTATEREPORTINGENABLE);
			this.acknowledgedGunHolsterStateReportingEnable_43551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.acknowledgedGunHolsterStateReportingEnable_43551.DataTransferOrder = 71;
			this.acknowledgedStunGunStateReportingEnable_43552 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軎닐룒믔룖께럚룜믞蛠蛢臤듦鷨黪菬꣮蓰鷲꛴菶飸迺飼귾搀猂樄甆紈戊挌栎吐紒琔甖甘縚䈜⬞ሠᘢဤᔦ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDSTUNGUNSTATEREPORTINGENABLE);
			this.acknowledgedStunGunStateReportingEnable_43552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.acknowledgedStunGunStateReportingEnable_43552.DataTransferOrder = 72;
			this.acknowledgedWeaponFiredEventReportingEnable_43582 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軎닐룒믔룖께럚룜믞蛠蛢臤냦賨諪鷬胮鿰뗲鳴藶鳸鿺룼觾搀洂焄唆氈笊戌紎攐稒笔瀖尘甚簜紞䴠䘢稤ጦᨨḪᔬᴮ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDWEAPONFIREDEVENTREPORTINGENABLE);
			this.acknowledgedWeaponFiredEventReportingEnable_43582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.acknowledgedWeaponFiredEventReportingEnable_43582.DataTransferOrder = 73;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10066;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x0099921C File Offset: 0x0099741C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1231814716;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖軘뻚볜꿞軠跢ꏤ軦鯨軪觬ꫮ蟰雲鯴菶꯸黺跼郾猀眂氄椆済上挌渎猐缒瀔䠖ⴘ⠚⠜✞ጠ", a_)))
					{
						num = (short)396165145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_109A;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜雞ꋠ껢뗤ꋦ諨菪苬냮냰쯲쟴웶샸", a_)))
					{
						num = (short)1525547041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CB;
				case 2:
					this.directTMSContentDisplay_42323 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ럄ꋆ꫈뿊駌苎苐郒뫔맖귘뻚돜ꯞꗠ諢雤韦藨諪铬냮연쇲웴엶쫸", a_), global::CommonResources.AcgResources.ID_DIRECTTMSCONTENTDISPLAY);
					this.directTMSContentDisplay_42323.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.directTMSContentDisplay_42323.DataTransferOrder = 61;
					num = (short)758251585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)421082116;
					short num3 = num;
					num = (short)694301700;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_295;
					default:
						num = (short)1665925120;
						if (num != 0)
						{
						}
						this.dataWideGeneralPeerIPAddress1_A8524 = new global::AcpBusinessLayer.AcpIPAddressField(41986240L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶죸ꓺ볼쟾㐀㄂㄄", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESS);
						this.dataWideGeneralPeerIPAddress1_A8524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.dataWideGeneralPeerIPAddress1_A8524.DataTransferOrder = 6;
						num = (short)855834628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_A90;
				case 5:
					this.sensorMeasurementReporting_A43021 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋀ꛂꯄ듆ꛈ맊背꫎냐ꃒꃔꗖ볘뛚룜뇞闠뇢胤韦蛨駪駬蛮鿰铲ꫴ뛶췸죺췼췾\u3000", a_), global::CommonResources.AcgResources.ID_SENSORMEASUREMENTREPORTING);
					this.sensorMeasurementReporting_A43021.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.sensorMeasurementReporting_A43021.DataTransferOrder = 70;
					num = (short)1466499104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_9FB;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ맨軪裬鷮룰ꏲ듴鏶鷸觺飼賾爀専䐄㌆㠈㨊㼌㰎", a_)))
					{
						num = (short)1556021257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_832;
				case 8:
					goto IL_2CB;
				case 9:
					this.dataWideGeneralBTDUNPeerIPAddress_A41123 = new global::AcpBusinessLayer.AcpIPAddressField(42117312L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ맨軪裬鷮룰ꏲ듴鏶鷸觺飼賾爀専䐄㌆㠈㨊㼌㰎", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESS);
					this.dataWideGeneralBTDUNPeerIPAddress_A41123.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralBTDUNPeerIPAddress_A41123.DataTransferOrder = 14;
					num = (short)1170210859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1B8;
				case 11:
					this.dataWideGeneralPeerIPAddressAssignmentType1_A22376 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶룸裺軼雾昀洂栄戆月缊夌瘎愐瘒␔䠖堘⤚⼜Ⱎᘠᔢ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralPeerIPAddressAssignmentType1_A22376LovStrs);
					this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.DataTransferOrder = 7;
					num = (short)1974534150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_205;
				case 13:
					num = (short)481296431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_B84;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖諘꿚꣜뇞ꛠ離诤듦鷨諪駬諮ꏰ雲藴飶诸迺铼釾昀䘂欄昆欈朊栌倎┐‒—∖⬘", a_)))
					{
						num = (short)489619473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB7;
				case 16:
					this.dataWideGeneralBroadbandCheckbackTime_A42862 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞鏠賢蓤菦诨諪菬诮닰鯲郴银鋸駺鳼鳾樀圂氄樆氈吊䰌㬎⌐⬒⌔┖", a_), global::CommonResources.AcgResources.ID_BROADBANDCHECKBACKTIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LegacyTitles.DataWideGeneralBroadbandCheckbackTime_A42862LegacyTitles);
					this.dataWideGeneralBroadbandCheckbackTime_A42862.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralBroadbandCheckbackTime_A42862.DataTransferOrder = 77;
					this.dataWideGeneralBroadbandCheckbackTime_A42862.ShowHexValue = false;
					num = (short)641859606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.acknowledgedStunGunStateReportingEnable_43552 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖諘꿚꣜뇞ꛠ離诤듦鷨諪駬諮ꏰ雲藴飶诸迺铼釾昀䘂欄昆欈朊栌倎┐‒—∖⬘", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDSTUNGUNSTATEREPORTINGENABLE);
					this.acknowledgedStunGunStateReportingEnable_43552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.acknowledgedStunGunStateReportingEnable_43552.DataTransferOrder = 72;
					num = (short)236519463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_FF7;
				case 19:
					goto IL_7E9;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜雞迠韢胤闦蟨諪臬뷮郰韲鳴飶꫸軺鿼釾搀眂娄䘆㴈㤊㴌㠎∐", a_)))
					{
						num = (short)1859518490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF7;
				case 21:
					this.dataWideGeneralBTDUNSUIPAddress_A41120 = new global::AcpBusinessLayer.AcpIPAddressField(25340096L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ뫨뻪ꓬ뿮냰韲釴藶鳸裺軼ꃾ䀀㜂㐄㘆㬈㬊", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESSUBSCRIBERIPADDRESS);
					this.dataWideGeneralBTDUNSUIPAddress_A41120.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralBTDUNSUIPAddress_A41120.DataTransferOrder = 13;
					num = (short)625934355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_253;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜賞꿠껢뗤돦鯨諪鷬鳮껰닲쳴웶쿸췺", a_)))
					{
						num = (short)213909558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				case 24:
					goto IL_16B;
				case 25:
					this.acknowledgedWeaponFiredEventReportingEnable_43582 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖軘뻚볜꿞軠跢ꏤ軦鯨軪觬ꫮ蟰雲鯴菶꯸黺跼郾猀眂氄椆済上挌渎猐缒瀔䠖ⴘ⠚⠜✞ጠ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDWEAPONFIREDEVENTREPORTINGENABLE);
					this.acknowledgedWeaponFiredEventReportingEnable_43582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.acknowledgedWeaponFiredEventReportingEnable_43582.DataTransferOrder = 73;
					num = (short)2088108084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.dataWideGeneralInternalRadioSubnet_A42073 = new global::AcpBusinessLayer.AcpFieldX<long, string>((long)((ulong)-956301312), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConvertSubnetAddress(), this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜雞迠韢胤闦蟨諪臬뷮郰韲鳴飶꫸軺鿼釾搀眂娄䘆㴈㤊㴌㠎∐", a_), global::CommonResources.AcgResources.ID_INTERNALRADIOSUBNET);
					this.dataWideGeneralInternalRadioSubnet_A42073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dataWideGeneralInternalRadioSubnet_A42073.DataTransferOrder = 55;
					num = (short)318570514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.dataWideGeneralMobileSubIPAddress_A41819 = new global::AcpBusinessLayer.AcpIPAddressField(25274560L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鋞軠臢賤详賨룪飬跮룰ꏲ듴鏶鷸觺飼賾爀専䐄㌆㠈㌊㰌㘎", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESSUBSCRIBERIPADDRESS);
					this.dataWideGeneralMobileSubIPAddress_A41819.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralMobileSubIPAddress_A41819.DataTransferOrder = 26;
					num = (short)1943339069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					this.dataWideGeneralContextDeactivationAlertTone_A7715 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鳞軠跢釤苦釨鿪ꧬ諮郰郲致黶迸髺觼雾渀洂䐄欆氈礊礌嬎縐紒瀔䠖堘Ⱊ⨜⸞ᐠ", a_), global::CommonResources.AcgResources.ID_CONTEXTDEACTIVATIONALERTTONE);
					this.dataWideGeneralContextDeactivationAlertTone_A7715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWideGeneralContextDeactivationAlertTone_A7715.DataTransferOrder = 1;
					num = (short)139853859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜賞铠臢雤蓦鯨苪迬諮菰뫲ꗴ뛶鷸鿺迼髾爀瀂㐄堆䠈㈊㼌㴎⌐", a_)))
					{
						num = (short)889978935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93B;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶룸裺軼雾昀洂栄戆月缊夌瘎愐瘒✔䠖堘⤚⼜Ⱎᘠᐢ", a_)))
					{
						num = (short)1066532932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A44;
				case 31:
					this.dataWideGeneralDeleteMessagesOnSessionEnd_41308 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鯞蓠迢胤鏦賨ꛪ裬鳮苰鋲鋴鋶諸듺鏼곾搀瀂瘄渆昈攊䠌愎甐䰒℔☖⨘⬚├", a_), global::CommonResources.AcgResources.ID_DELETEMESSAGESONSESSIONEND);
					this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.DataTransferOrder = 60;
					num = (short)2137194510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_489;
				case 33:
					this.dataWideGeneralICMPEcho_A8219 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜雞ꋠ껢뗤ꋦ諨菪苬냮냰쯲쟴웶샸", a_), global::CommonResources.AcgResources.ID_ICMPECHO);
					this.dataWideGeneralICMPEcho_A8219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralICMPEcho_A8219.DataTransferOrder = 2;
					num = (short)1413611528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.dataWideGeneralDVRIPAddress_A41818 = new global::AcpBusinessLayer.AcpIPAddressField(42051776L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鯞럠뇢곤럦꣨迪觬鷮铰胲蛴ꣶ룸쿺쳼쟾\u3000㬂", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESPEERIPADDRESS);
					this.dataWideGeneralDVRIPAddress_A41818.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralDVRIPAddress_A41818.DataTransferOrder = 27;
					num = (short)2096365578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_D16;
				case 36:
					this.dataWideLTEAPCOAvalancheTime_A42204 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎鷐蟒郔雖觘飚鋜點韠苢觤蛦蟨裪藬諮ꗰ髲飴鋶꛸뫺짼췾㌀㌂㄄", a_), global::CommonResources.AcgResources.ID_APCOAVALANCHETIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.dataWideLTEAPCOAvalancheTime_A42204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideLTEAPCOAvalancheTime_A42204.DataTransferOrder = 56;
					this.dataWideLTEAPCOAvalancheTime_A42204.ShowHexValue = false;
					num = (short)1350500376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎鷐蟒郔雖觘飚鋜點韠苢觤蛦蟨裪藬諮ꗰ髲飴鋶꛸뫺짼췾㌀㌂㄄", a_)))
					{
						num = (short)1777139748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鯞럠뇢곤럦꣨迪觬鷮铰胲蛴ꣶ룸쿺쳼쟾\u3000㬂", a_)))
					{
						num = (short)1313013794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
				case 39:
					goto IL_DB7;
				case 40:
					goto IL_C74;
				case 41:
					num = (short)1333723199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鋞軠臢賤详賨룪飬跮룰ꏲ듴鏶鷸觺飼賾爀専䐄㌆㠈㌊㰌㘎", a_)))
					{
						num = (short)460521499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F57;
				case 43:
					goto IL_832;
				case 44:
					goto IL_93B;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶룸裺軼雾昀洂栄戆月缊夌瘎愐瘒␔䠖堘⤚⼜Ⱎᘠᔢ", a_)))
					{
						num = (short)2036334603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9FB;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞鏠賢蓤菦诨諪菬诮닰鯲郴银鋸駺鳼鳾樀圂氄樆氈吊䰌㬎⌐⬒⌔┖", a_)))
					{
						num = (short)1635123216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_253;
				case 47:
					if (producerFields != null)
					{
						num = (short)1705246761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_109A;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖默껚돜韞軠迢雤鏦賨駪뻬鯮郰蟲郴ꗶ鳸诺鋼跾甀樂欄怆䰈攊氌洎紐瘒䨔⌖⨘⸚⠜⸞", a_)))
					{
						num = (short)973733938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_387;
				case 49:
					this.dataWideExternalTextMessagingBroadcast_42418 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎铐ꯒꇔ닖ꯘ뗚볜돞뗠蛢鷤鏦ꓨ軪黬鳮郰铲鳴駶黸맺迼郾怀朂昄昆稈缊刌㬎⌐✒␔⼖", a_), global::CommonResources.AcgResources.ID_EXTERNALTEXTMESSAGINGBROADCAST);
					this.dataWideExternalTextMessagingBroadcast_42418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalTextMessagingBroadcast_42418.DataTransferOrder = 62;
					num = (short)71303237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.acknowledgedGunHolsterStateReportingEnable_43551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胀ꃂ껄꧆ꛈ볊ꇌ꫎뗐듒냔돖默껚돜韞軠迢雤鏦賨駪뻬鯮郰蟲郴ꗶ鳸诺鋼跾甀樂欄怆䰈攊氌洎紐瘒䨔⌖⨘⸚⠜⸞", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEDGUNHOLSTERSTATEREPORTINGENABLE);
					this.acknowledgedGunHolsterStateReportingEnable_43551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.acknowledgedGunHolsterStateReportingEnable_43551.DataTransferOrder = 71;
					num = (short)996671555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꫂ럄ꋆ꫈뿊駌苎苐郒뫔맖귘뻚돜ꯞꗠ諢雤韦藨諪铬냮연쇲웴엶쫸", a_)))
					{
						num = (short)1260978178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB7;
				case 52:
					goto IL_526;
				case 53:
					goto IL_A44;
				case 54:
					this.dataWideGeneralSNMPTraps_A9166 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜賞꿠껢뗤돦鯨諪鷬鳮껰닲쳴웶쿸췺", a_), global::CommonResources.AcgResources.ID_SNMPTRAPS);
					this.dataWideGeneralSNMPTraps_A9166.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWideGeneralSNMPTraps_A9166.DataTransferOrder = 5;
					num = (short)550436876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					this.dataWideGeneralSubscriberIPAddress1_A9222 = new global::AcpBusinessLayer.AcpIPAddressField(25209024L, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜賞铠臢雤蓦鯨苪迬諮菰뫲ꗴ뛶鷸鿺迼髾爀瀂㐄堆䠈㈊㼌㴎⌐", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESSUBSCRIBERIPADDRESS);
					this.dataWideGeneralSubscriberIPAddress1_A9222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralSubscriberIPAddress1_A9222.DataTransferOrder = 3;
					num = (short)2080833580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎铐ꯒꇔ닖ꯘ뗚볜돞뗠蛢鷤鏦ꓨ軪黬鳮郰铲鳴駶黸맺迼郾怀朂昄昆稈缊刌㬎⌐✒␔⼖", a_)))
					{
						num = (short)199753777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C28;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ맨軪裬鷮룰ꏲ듴鏶鷸觺飼賾爀䈂瘄理怈氊挌戎琐紒愔䌖怘欚砜䀞怠ᜢᐤᘦᬨἪ", a_)))
					{
						num = (short)1839333442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C74;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶죸ꓺ볼쟾㐀㄂㄄", a_)))
					{
						num = (short)1205600259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A90;
				case 59:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鯞蓠迢胤鏦賨ꛪ裬鳮苰鋲鋴鋶諸듺鏼곾搀瀂瘄渆昈攊䠌愎甐䰒℔☖⨘⬚├", a_)))
					{
						num = (short)1604452383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B84;
				case 60:
					switch (0)
					{
					case 0:
						goto IL_145;
					}
					continue;
				case 61:
					goto IL_F57;
				case 62:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ뫨뻪ꓬ뿮냰韲釴藶鳸裺軼ꃾ䀀㜂㐄㘆㬈㬊", a_)))
					{
						num = (short)217251861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E9;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鳞軠跢釤苦釨鿪ꧬ諮郰郲致黶迸髺觼雾渀洂䐄欆氈礊礌嬎縐紒瀔䠖堘Ⱊ⨜⸞ᐠ", a_)))
					{
						num = (short)841941020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D16;
				case 64:
					goto IL_295;
				case 65:
					goto IL_EB7;
				case 66:
					this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜鷞뗠꟢냤ꧦ맨軪裬鷮룰ꏲ듴鏶鷸觺飼賾爀䈂瘄理怈氊挌戎琐紒愔䌖怘欚砜䀞怠ᜢᐤᘦᬨἪ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124LovStrs);
					this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.DataTransferOrder = 8;
					num = (short)1444020264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					num = (short)973209601;
					if (num != 0)
					{
					}
					goto IL_387;
				case 68:
					this.dataWideGeneralPeerIPAddressAssignmentType2_A22377 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎雐뛒믔닖ꯘ뫚뇜连蓠蛢韤껦맨ꫪ觬诮菰雲蛴蓶룸裺軼雾昀洂栄戆月缊夌瘎愐瘒✔䠖堘⤚⼜Ⱎᘠᐢ", a_), global::CommonResources.AcgResources.ID_SERIALLINK2ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideGeneralPeerIPAddressAssignmentType2_A22377LovStrs);
					this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.DataTransferOrder = 28;
					num = (short)227082293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					goto IL_C28;
				}
				IL_145:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)94437389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_16B:
				num = (short)1928265779;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				num = (short)1809711146;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_205:
				num = (short)1688862749;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_253:
				num = (short)1166016512;
				short num4 = num;
				num = (short)441974848;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_295:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋀ꛂꯄ듆ꛈ맊背꫎냐ꃒꃔꗖ볘뛚룜뇞闠뇢胤韦蛨駪駬蛮鿰铲ꫴ뛶췸죺췼췾\u3000", a_)))
				{
					num = (short)1858207749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_489;
				IL_2CB:
				num = (short)698155066;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_387:
				num = (short)554041359;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_489:
				num = (short)289865776;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E9:
				num = (short)656343047;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_832:
				num = (short)911343673;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_93B:
				num = (short)1305804845;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9FB:
				num = (short)856162334;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A44:
				num = (short)1430061118;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A90:
				num = (short)221315095;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B84:
				num = (short)2084700198;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C28:
				num = (short)651886638;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C74:
				num = (short)1046282299;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D16:
				num = (short)845938689;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DB7:
				num = (short)1588920320;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB7:
				num = (short)2064056376;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F57:
				num = (short)1800667156;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FF7:
				num = (short)809238565;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_526:
			IL_109A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛀ꛂꯄꋆ믈꫊ꇌ", a_);
			base.Id = 10066;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x0099A2F4 File Offset: 0x009984F4
		public override void PopulateReferences()
		{
			short num = (short)1556417280;
			short num2 = num;
			num = (short)1230572288;
			switch (num2 == num)
			{
			}
			num = (short)371261440;
			if (num != 0)
			{
			}
			num = (short)248053760;
			short num3 = num;
			num = (short)530579457;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x0099A39C File Offset: 0x0099859C
		public override void DropReferences()
		{
			short num = (short)1549055500;
			short num2 = num;
			num = (short)261731852;
			switch (num2 == num)
			{
			}
			num = (short)58851328;
			if (num != 0)
			{
			}
			num = (short)1313865728;
			short num3 = num;
			num = (short)810745857;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x0099A444 File Offset: 0x00998644
		public override void SetConstraints()
		{
			short num = (short)1963963511;
			short num2 = num;
			num = (short)1535358071;
			switch (num2 == num)
			{
			}
			num = (short)1472397313;
			if (num != 0)
			{
			}
			num = (short)205848576;
			short num3 = num;
			num = (short)1872429056;
			if (num != 0)
			{
			}
			this.dataWideGeneralPeerIPAddress1_A8524.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conEnsureSameSubnetBetweenDCEAndDTE);
			this.dataWideGeneralPeerIPAddress1_A8524.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.dataWideGeneralPeerIPAddress1_A8524.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conNonEditableWhenOpenFromRMC);
			this.dataWideGeneralPeerIPAddress1_A8524.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conSetDataPrfPeerIpValue);
			this.dataWideGeneralSubscriberIPAddress1_A9222.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conSubIpAddress1Valid);
			this.dataWideGeneralSubscriberIPAddress1_A9222.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.dataWideGeneralSubscriberIPAddress1_A9222.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conNonEditableWhenOpenFromRMC);
			this.dataWideGeneralSubscriberIPAddress1_A9222.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conSetDataPrfSubIpValue);
			this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conSetDataPrfPeerIpAssignTypeValue);
			this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDVRSHardWareIsEnabled);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConBluetoothEnableIsEnabled);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataWideBTDUNSUIPAddressesIsValid);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conNonEditableWhenOpenFromRMC);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSetDataProBTDUNSUIPADDValue);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataWideBTDUNPeerIPAddressesIsApplicable);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataWideBTDUNPeerIPAddressesIsValid);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conNonEditableWhenOpenFromRMC);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSetDataProBTDUNPeerIPADDValue);
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConBluetoothEnableIsEnabled);
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSetDataProBTDUNPeerIPADDAssignTypeValue);
			this.dataWideGeneralDVRIPAddress_A41818.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDVRSHardWareIsEnabled);
			this.dataWideGeneralDVRIPAddress_A41818.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataWideDVRSPeerIPAddressesIsValid);
			this.dataWideGeneralMobileSubIPAddress_A41819.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDVRSHardWareIsEnabled);
			this.dataWideGeneralMobileSubIPAddress_A41819.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConDataWideDVRSSUIPAddressesIsValid);
			this.dataWideGeneralInternalRadioSubnet_A42073.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConInternalRadioSubnetValid);
			this.dataWideGeneralBroadbandCheckbackTime_A42862.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConSetLTECheckbackTime);
			this.acknowledgedGunHolsterStateReportingEnable_43551.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.SensorsReportingEditability);
			this.acknowledgedStunGunStateReportingEnable_43552.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.SensorsReportingEditability);
			this.acknowledgedWeaponFiredEventReportingEnable_43582.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConAcknowledgedWeaponFiredEventReportingEnable);
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x0099A7B4 File Offset: 0x009989B4
		public override void SetupDependencies()
		{
			short num = (short)1970234408;
			short num2 = num;
			num = (short)588997672;
			switch (num2 == num)
			{
			}
			num = (short)1867776001;
			if (num != 0)
			{
			}
			num = (short)1428881408;
			short num3 = num;
			num = (short)341966848;
			if (num != 0)
			{
			}
			this.dataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataWideGeneralPeerIPAddress1_A8524);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralPeerIPAddress1_A8524);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralSubscriberIPAddress1_A9222);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dataWideGeneralPeerIPAddressAssignmentType2_A22377);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataWideGeneralBTDUNPeerIPAddress_A41123.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataWideGeneralBTDUNSUIPAddress_A41120.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddress_A41123);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dataWideGeneralDVRIPAddress_A41818);
			this.dataWideGeneralMobileSubIPAddress_A41819.AddDependentObject(this.dataWideGeneralDVRIPAddress_A41818);
			this.dataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataWideGeneralDVRIPAddress_A41818);
			this.dataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataWideGeneralDVRIPAddress_A41818);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralDVRIPAddress_A41818);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dataWideGeneralMobileSubIPAddress_A41819);
			this.dataWideGeneralDVRIPAddress_A41818.AddDependentObject(this.dataWideGeneralMobileSubIPAddress_A41819);
			this.dataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataWideGeneralMobileSubIPAddress_A41819);
			this.dataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataWideGeneralMobileSubIPAddress_A41819);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideGeneralMobileSubIPAddress_A41819);
			this.sensorMeasurementReporting_A43021.AddDependentObject(this.acknowledgedWeaponFiredEventReportingEnable_43582);
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x0600A493 RID: 42131 RVA: 0x0099AACC File Offset: 0x00998CCC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1573847544;
				short num2 = num;
				num = (short)2123760120;
				switch (num2 == num)
				{
				}
				num = (short)965345280;
				if (num != 0)
				{
				}
				num = (short)1270546432;
				short num3 = num;
				num = (short)530644993;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x0600A494 RID: 42132 RVA: 0x0099AB80 File Offset: 0x00998D80
		// (set) Token: 0x0600A495 RID: 42133 RVA: 0x0099AC34 File Offset: 0x00998E34
		public bool DataWideGeneralContextDeactivationAlertTone_A7715Value
		{
			get
			{
				short num = (short)1307037367;
				short num2 = num;
				num = (short)1313525431;
				switch (num2 == num)
				{
				}
				num = (short)300023808;
				if (num != 0)
				{
				}
				num = (short)759758848;
				short num3 = num;
				num = (short)205914113;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Value;
			}
			set
			{
				short num = (short)1528610676;
				short num2 = num;
				num = (short)86556532;
				switch (num2 == num)
				{
				}
				num = (short)971571201;
				if (num != 0)
				{
				}
				num = (short)1016201216;
				short num3 = num;
				num = (short)691994624;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Value = value;
			}
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x0600A496 RID: 42134 RVA: 0x0099ACEC File Offset: 0x00998EEC
		public global::AcpBusinessLayer.AcpField<bool> DataWideGeneralContextDeactivationAlertTone_A7715
		{
			get
			{
				short num = (short)604897280;
				short num2 = num;
				num = (short)750518273;
				if (num != 0)
				{
				}
				num = (short)185646663;
				short num3 = num;
				num = (short)1716829767;
				switch (num3 == num)
				{
				}
				num = (short)195100672;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715;
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x0600A497 RID: 42135 RVA: 0x0099AD9C File Offset: 0x00998F9C
		// (set) Token: 0x0600A498 RID: 42136 RVA: 0x0099AE4C File Offset: 0x0099904C
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_UIValue
		{
			get
			{
				short num = (short)1488322560;
				short num2 = num;
				num = (short)1509247374;
				short num3 = num;
				num = (short)241977742;
				switch (num3 == num)
				{
				}
				num = (short)1852637185;
				if (num != 0)
				{
				}
				num = (short)2121334784;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Value;
			}
			set
			{
				short num = (short)1925971968;
				short num2 = num;
				num = (short)1607738980;
				short num3 = num;
				num = (short)739059300;
				switch (num3 == num)
				{
				}
				num = (short)600834049;
				if (num != 0)
				{
				}
				num = (short)259719168;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Value = value;
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x0600A499 RID: 42137 RVA: 0x0099AF04 File Offset: 0x00999104
		// (set) Token: 0x0600A49A RID: 42138 RVA: 0x0099AFB8 File Offset: 0x009991B8
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_Applicable
		{
			get
			{
				short num = (short)844234752;
				short num2 = num;
				num = (short)1819295295;
				short num3 = num;
				num = (short)71712319;
				switch (num3 == num)
				{
				}
				num = (short)1970405377;
				if (num != 0)
				{
				}
				num = (short)1516896256;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Applicable;
			}
			set
			{
				short num = (short)1739456512;
				short num2 = num;
				num = (short)1211935355;
				short num3 = num;
				num = (short)1757719163;
				switch (num3 == num)
				{
				}
				num = (short)246218753;
				if (num != 0)
				{
				}
				num = (short)1378811904;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Applicable = value;
			}
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x0099B06C File Offset: 0x0099926C
		// (set) Token: 0x0600A49C RID: 42140 RVA: 0x0099B120 File Offset: 0x00999320
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_Valid
		{
			get
			{
				short num = (short)578027520;
				short num2 = num;
				num = (short)1320337178;
				short num3 = num;
				num = (short)1533460250;
				switch (num3 == num)
				{
				}
				num = (short)511967233;
				if (num != 0)
				{
				}
				num = (short)1059323904;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Valid;
			}
			set
			{
				short num = (short)1147928576;
				short num2 = num;
				num = (short)425721857;
				if (num != 0)
				{
				}
				num = (short)1386077402;
				short num3 = num;
				num = (short)1343937754;
				switch (num3 == num)
				{
				}
				num = (short)1221132288;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Valid = value;
			}
		}

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x0600A49D RID: 42141 RVA: 0x0099B1D8 File Offset: 0x009993D8
		// (set) Token: 0x0600A49E RID: 42142 RVA: 0x0099B28C File Offset: 0x0099948C
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_Visible
		{
			get
			{
				short num = (short)672792576;
				short num2 = num;
				num = (short)1251970935;
				short num3 = num;
				num = (short)2071498615;
				switch (num3 == num)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				num = (short)893321216;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Visible;
			}
			set
			{
				short num = (short)2070872064;
				short num2 = num;
				num = (short)717758120;
				short num3 = num;
				num = (short)2144607912;
				switch (num3 == num)
				{
				}
				num = (short)824573953;
				if (num != 0)
				{
				}
				num = (short)1796538368;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Visible = value;
			}
		}

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x0600A49F RID: 42143 RVA: 0x0099B340 File Offset: 0x00999540
		// (set) Token: 0x0600A4A0 RID: 42144 RVA: 0x0099B3F4 File Offset: 0x009995F4
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_Editable
		{
			get
			{
				short num = (short)146800640;
				short num2 = num;
				num = (short)72452381;
				short num3 = num;
				num = (short)2136770845;
				switch (num3 == num)
				{
				}
				num = (short)1166082048;
				if (num != 0)
				{
				}
				num = (short)302710785;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.Editable;
			}
			set
			{
				short num = (short)2069299200;
				short num2 = num;
				num = (short)9611212;
				short num3 = num;
				num = (short)44410828;
				switch (num3 == num)
				{
				}
				num = (short)593887233;
				if (num != 0)
				{
				}
				num = (short)1742667776;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.Editable = value;
			}
		}

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x0099B4A8 File Offset: 0x009996A8
		internal string DataWideGeneralContextDeactivationAlertTone_A7715_UILabel
		{
			get
			{
				short num = (short)965214208;
				short num2 = num;
				num = (short)2027624564;
				short num3 = num;
				num = (short)1105008756;
				switch (num3 == num)
				{
				}
				num = (short)1660682241;
				if (num != 0)
				{
				}
				num = (short)310575104;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.UIName;
			}
		}

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x0099B55C File Offset: 0x0099975C
		// (set) Token: 0x0600A4A3 RID: 42147 RVA: 0x0099B614 File Offset: 0x00999814
		internal bool DataWideGeneralContextDeactivationAlertTone_A7715_HiddenStatic
		{
			get
			{
				short num = (short)276299776;
				short num2 = num;
				num = (short)1562151655;
				short num3 = num;
				num = (short)1475775207;
				switch (num3 == num)
				{
				}
				num = (short)1862336513;
				if (num != 0)
				{
				}
				num = (short)1433010176;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.HiddenStatic;
			}
			set
			{
				short num = (short)517406720;
				short num2 = num;
				num = (short)532164349;
				short num3 = num;
				num = (short)641543933;
				switch (num3 == num)
				{
				}
				num = (short)672268289;
				if (num != 0)
				{
				}
				num = (short)1689845760;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.HiddenStatic = value;
			}
		}

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x0600A4A4 RID: 42148 RVA: 0x0099B6CC File Offset: 0x009998CC
		// (set) Token: 0x0600A4A5 RID: 42149 RVA: 0x0099B784 File Offset: 0x00999984
		internal bool DataWideGeneralContextDeactivationAlertTone_A7715_HiddenDynamic
		{
			get
			{
				short num = (short)1559756800;
				short num2 = num;
				num = (short)1172206727;
				short num3 = num;
				num = (short)1140159623;
				switch (num3 == num)
				{
				}
				num = (short)929824769;
				if (num != 0)
				{
				}
				num = (short)2095841280;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715.HiddenDynamic;
			}
			set
			{
				short num = (short)124387328;
				short num2 = num;
				num = (short)1836050201;
				short num3 = num;
				num = (short)789702425;
				switch (num3 == num)
				{
				}
				num = (short)351993857;
				if (num != 0)
				{
				}
				num = (short)1338834944;
				if (num != 0)
				{
				}
				this.dataWideGeneralContextDeactivationAlertTone_A7715.HiddenDynamic = value;
			}
		}

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x0600A4A6 RID: 42150 RVA: 0x0099B838 File Offset: 0x00999A38
		public bool DataWideGeneralContextDeactivationAlertTone_A7715_HasDiffs
		{
			get
			{
				short num = (short)1914765312;
				short num2 = num;
				num = (short)1417541591;
				short num3 = num;
				num = (short)1394866135;
				switch (num3 == num)
				{
				}
				num = (short)73269248;
				if (num != 0)
				{
				}
				num = (short)2004746241;
				if (num != 0)
				{
				}
				return this.dataWideGeneralContextDeactivationAlertTone_A7715._HasDiffs;
			}
		}

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x0099B8F0 File Offset: 0x00999AF0
		// (set) Token: 0x0600A4A8 RID: 42152 RVA: 0x0099B9A4 File Offset: 0x00999BA4
		public bool DataWideGeneralICMPEcho_A8219Value
		{
			get
			{
				short num = (short)1120862208;
				short num2 = num;
				num = (short)525150762;
				short num3 = num;
				num = (short)1115957802;
				switch (num3 == num)
				{
				}
				num = (short)975699969;
				if (num != 0)
				{
				}
				num = (short)2098855936;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Value;
			}
			set
			{
				short num = (short)1710424064;
				short num2 = num;
				num = (short)135203114;
				short num3 = num;
				num = (short)1583679786;
				switch (num3 == num)
				{
				}
				num = (short)1181220865;
				if (num != 0)
				{
				}
				num = (short)1898905600;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Value = value;
			}
		}

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x0099BA58 File Offset: 0x00999C58
		public global::AcpBusinessLayer.AcpField<bool> DataWideGeneralICMPEcho_A8219
		{
			get
			{
				short num = (short)1445920768;
				short num2 = num;
				num = (short)590791886;
				short num3 = num;
				num = (short)1779418318;
				switch (num3 == num)
				{
				}
				num = (short)1297088513;
				if (num != 0)
				{
				}
				num = (short)2147155968;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219;
			}
		}

		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x0099BB08 File Offset: 0x00999D08
		// (set) Token: 0x0600A4AB RID: 42155 RVA: 0x0099BBBC File Offset: 0x00999DBC
		public bool DataWideGeneralICMPEcho_A8219_UIValue
		{
			get
			{
				short num = (short)599982080;
				short num2 = num;
				num = (short)2059662086;
				short num3 = num;
				num = (short)555217670;
				switch (num3 == num)
				{
				}
				num = (short)636747777;
				if (num != 0)
				{
				}
				num = (short)593231872;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Value;
			}
			set
			{
				short num = (short)1766326272;
				short num2 = num;
				num = (short)1720844289;
				if (num != 0)
				{
				}
				num = (short)1622868407;
				short num3 = num;
				num = (short)1227489719;
				switch (num3 == num)
				{
				}
				num = (short)803602432;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Value = value;
			}
		}

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x0099BC70 File Offset: 0x00999E70
		// (set) Token: 0x0600A4AD RID: 42157 RVA: 0x0099BD24 File Offset: 0x00999F24
		public bool DataWideGeneralICMPEcho_A8219_Applicable
		{
			get
			{
				short num = (short)248053760;
				short num2 = num;
				num = (short)222298113;
				if (num != 0)
				{
				}
				num = (short)312388859;
				short num3 = num;
				num = (short)939306235;
				switch (num3 == num)
				{
				}
				num = (short)529465344;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Applicable;
			}
			set
			{
				short num = (short)148045824;
				short num2 = num;
				num = (short)1574109185;
				if (num != 0)
				{
				}
				num = (short)553870219;
				short num3 = num;
				num = (short)1595302795;
				switch (num3 == num)
				{
				}
				num = (short)478216192;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Applicable = value;
			}
		}

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x0099BDD8 File Offset: 0x00999FD8
		// (set) Token: 0x0600A4AF RID: 42159 RVA: 0x0099BE90 File Offset: 0x0099A090
		public bool DataWideGeneralICMPEcho_A8219_Valid
		{
			get
			{
				short num = (short)1413873664;
				short num2 = num;
				num = (short)798478147;
				short num3 = num;
				num = (short)1311493955;
				switch (num3 == num)
				{
				}
				num = (short)1220935681;
				if (num != 0)
				{
				}
				num = (short)1417281536;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Valid;
			}
			set
			{
				short num = (short)562692096;
				short num2 = num;
				num = (short)1902762427;
				short num3 = num;
				num = (short)425580987;
				switch (num3 == num)
				{
				}
				num = (short)1772617729;
				if (num != 0)
				{
				}
				num = (short)761593856;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Valid = value;
			}
		}

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x0099BF44 File Offset: 0x0099A144
		// (set) Token: 0x0600A4B1 RID: 42161 RVA: 0x0099BFF4 File Offset: 0x0099A1F4
		public bool DataWideGeneralICMPEcho_A8219_Visible
		{
			get
			{
				short num = (short)1959919616;
				short num2 = num;
				num = (short)384418535;
				short num3 = num;
				num = (short)329892583;
				switch (num3 == num)
				{
				}
				num = (short)1175388161;
				if (num != 0)
				{
				}
				num = (short)1288765440;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Visible;
			}
			set
			{
				short num = (short)1470693376;
				short num2 = num;
				num = (short)955150983;
				short num3 = num;
				num = (short)1698001543;
				switch (num3 == num)
				{
				}
				num = (short)2098266113;
				if (num != 0)
				{
				}
				num = (short)145227776;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Visible = value;
			}
		}

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x0099C0A8 File Offset: 0x0099A2A8
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x0099C15C File Offset: 0x0099A35C
		public bool DataWideGeneralICMPEcho_A8219_Editable
		{
			get
			{
				short num = (short)312344576;
				short num2 = num;
				num = (short)68796214;
				short num3 = num;
				num = (short)1149812534;
				switch (num3 == num)
				{
				}
				num = (short)249102336;
				if (num != 0)
				{
				}
				num = (short)557645825;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.Editable;
			}
			set
			{
				short num = (short)2093350912;
				short num2 = num;
				num = (short)1072510506;
				short num3 = num;
				num = (short)1861301802;
				switch (num3 == num)
				{
				}
				num = (short)1321140224;
				if (num != 0)
				{
				}
				num = (short)958201857;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.Editable = value;
			}
		}

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x0600A4B4 RID: 42164 RVA: 0x0099C214 File Offset: 0x0099A414
		internal string DataWideGeneralICMPEcho_A8219_UILabel
		{
			get
			{
				short num = (short)1226375168;
				short num2 = num;
				num = (short)1402803871;
				short num3 = num;
				num = (short)1306859167;
				switch (num3 == num)
				{
				}
				num = (short)1836122112;
				if (num != 0)
				{
				}
				num = (short)677314561;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.UIName;
			}
		}

		// Token: 0x17005289 RID: 21129
		// (get) Token: 0x0600A4B5 RID: 42165 RVA: 0x0099C2C8 File Offset: 0x0099A4C8
		// (set) Token: 0x0600A4B6 RID: 42166 RVA: 0x0099C380 File Offset: 0x0099A580
		internal bool DataWideGeneralICMPEcho_A8219_HiddenStatic
		{
			get
			{
				short num = (short)1158873088;
				short num2 = num;
				num = (short)1890254215;
				short num3 = num;
				num = (short)439876999;
				switch (num3 == num)
				{
				}
				num = (short)550764545;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.HiddenStatic;
			}
			set
			{
				short num = (short)2067595264;
				short num2 = num;
				num = (short)1806057647;
				short num3 = num;
				num = (short)79380655;
				switch (num3 == num)
				{
				}
				num = (short)812253184;
				if (num != 0)
				{
				}
				num = (short)1468727297;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.HiddenStatic = value;
			}
		}

		// Token: 0x1700528A RID: 21130
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x0099C434 File Offset: 0x0099A634
		// (set) Token: 0x0600A4B8 RID: 42168 RVA: 0x0099C4E8 File Offset: 0x0099A6E8
		internal bool DataWideGeneralICMPEcho_A8219_HiddenDynamic
		{
			get
			{
				short num = (short)1279066112;
				short num2 = num;
				num = (short)249298945;
				if (num != 0)
				{
				}
				num = (short)604086994;
				short num3 = num;
				num = (short)789029586;
				switch (num3 == num)
				{
				}
				num = (short)1215758336;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219.HiddenDynamic;
			}
			set
			{
				short num = (short)1528430592;
				short num2 = num;
				num = (short)1760289367;
				short num3 = num;
				num = (short)1079698007;
				switch (num3 == num)
				{
				}
				num = (short)627965953;
				if (num != 0)
				{
				}
				num = (short)1531904000;
				if (num != 0)
				{
				}
				this.dataWideGeneralICMPEcho_A8219.HiddenDynamic = value;
			}
		}

		// Token: 0x1700528B RID: 21131
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x0099C5A0 File Offset: 0x0099A7A0
		public bool DataWideGeneralICMPEcho_A8219_HasDiffs
		{
			get
			{
				short num = (short)1867776000;
				short num2 = num;
				num = (short)555020124;
				short num3 = num;
				num = (short)1666051932;
				switch (num3 == num)
				{
				}
				num = (short)328466432;
				if (num != 0)
				{
				}
				num = (short)1046347777;
				if (num != 0)
				{
				}
				return this.dataWideGeneralICMPEcho_A8219._HasDiffs;
			}
		}

		// Token: 0x1700528C RID: 21132
		// (get) Token: 0x0600A4BA RID: 42170 RVA: 0x0099C658 File Offset: 0x0099A858
		// (set) Token: 0x0600A4BB RID: 42171 RVA: 0x0099C70C File Offset: 0x0099A90C
		public long DataWideGeneralPeerIPAddress1_A8524Value
		{
			get
			{
				short num = (short)455016448;
				short num2 = num;
				num = (short)651165697;
				if (num != 0)
				{
				}
				num = (short)6902229;
				short num3 = num;
				num = (short)123752917;
				switch (num3 == num)
				{
				}
				num = (short)805437440;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.Value;
			}
			set
			{
				short num = (short)2134114304;
				short num2 = num;
				num = (short)1428675733;
				short num3 = num;
				num = (short)1232919701;
				switch (num3 == num)
				{
				}
				num = (short)81199104;
				if (num != 0)
				{
				}
				num = (short)1829502977;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.Value = value;
			}
		}

		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x0600A4BC RID: 42172 RVA: 0x0099C7C0 File Offset: 0x0099A9C0
		// (set) Token: 0x0600A4BD RID: 42173 RVA: 0x0099C874 File Offset: 0x0099AA74
		public string DataWideGeneralPeerIPAddress1_A8524_UIValue
		{
			get
			{
				short num = (short)37355520;
				short num2 = num;
				num = (short)730162703;
				short num3 = num;
				num = (short)479618575;
				switch (num3 == num)
				{
				}
				num = (short)949813249;
				if (num != 0)
				{
				}
				num = (short)1007288320;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.UIValue;
			}
			set
			{
				short num = (short)1897922560;
				short num2 = num;
				num = (short)132231947;
				short num3 = num;
				num = (short)1021358859;
				switch (num3 == num)
				{
				}
				num = (short)808779776;
				if (num != 0)
				{
				}
				num = (short)80216065;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.UIValue = value;
			}
		}

		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x0600A4BE RID: 42174 RVA: 0x0099C928 File Offset: 0x0099AB28
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralPeerIPAddress1_A8524
		{
			get
			{
				short num = (short)92602368;
				short num2 = num;
				num = (short)173735937;
				if (num != 0)
				{
				}
				num = (short)200385137;
				short num3 = num;
				num = (short)1984668273;
				switch (num3 == num)
				{
				}
				num = (short)173604864;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524;
			}
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x0099C9D8 File Offset: 0x0099ABD8
		// (set) Token: 0x0600A4C0 RID: 42176 RVA: 0x0099CA8C File Offset: 0x0099AC8C
		public bool DataWideGeneralPeerIPAddress1_A8524_Applicable
		{
			get
			{
				short num = (short)37093376;
				short num2 = num;
				num = (short)138723405;
				short num3 = num;
				num = (short)1721221197;
				switch (num3 == num)
				{
				}
				num = (short)1325334528;
				if (num != 0)
				{
				}
				num = (short)1568276481;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.Applicable;
			}
			set
			{
				short num = (short)1319698432;
				short num2 = num;
				num = (short)1830578870;
				short num3 = num;
				num = (short)1813736118;
				switch (num3 == num)
				{
				}
				num = (short)1487732737;
				if (num != 0)
				{
				}
				num = (short)1957363712;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.Applicable = value;
			}
		}

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x0099CB40 File Offset: 0x0099AD40
		// (set) Token: 0x0600A4C2 RID: 42178 RVA: 0x0099CBF8 File Offset: 0x0099ADF8
		public bool DataWideGeneralPeerIPAddress1_A8524_Valid
		{
			get
			{
				short num = (short)334168064;
				short num2 = num;
				num = (short)1479249900;
				short num3 = num;
				num = (short)1256624108;
				switch (num3 == num)
				{
				}
				num = (short)510656512;
				if (num != 0)
				{
				}
				num = (short)1312096257;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.Valid;
			}
			set
			{
				short num = (short)637534208;
				short num2 = num;
				num = (short)1519912643;
				short num3 = num;
				num = (short)123995843;
				switch (num3 == num)
				{
				}
				num = (short)394199041;
				if (num != 0)
				{
				}
				num = (short)854327296;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.Valid = value;
			}
		}

		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x0099CCAC File Offset: 0x0099AEAC
		// (set) Token: 0x0600A4C4 RID: 42180 RVA: 0x0099CD60 File Offset: 0x0099AF60
		public bool DataWideGeneralPeerIPAddress1_A8524_Visible
		{
			get
			{
				short num = (short)2092695552;
				short num2 = num;
				num = (short)2070656852;
				short num3 = num;
				num = (short)1344255828;
				switch (num3 == num)
				{
				}
				num = (short)726073345;
				if (num != 0)
				{
				}
				num = (short)651165696;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.Visible;
			}
			set
			{
				short num = (short)2071855104;
				short num2 = num;
				num = (short)1000865793;
				if (num != 0)
				{
				}
				num = (short)758794941;
				short num3 = num;
				num = (short)1784498877;
				switch (num3 == num)
				{
				}
				num = (short)1754529792;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.Visible = value;
			}
		}

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x0099CE14 File Offset: 0x0099B014
		// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x0099CECC File Offset: 0x0099B0CC
		public bool DataWideGeneralPeerIPAddress1_A8524_Editable
		{
			get
			{
				short num = (short)2138570752;
				short num2 = num;
				num = (short)895354118;
				short num3 = num;
				num = (short)583730438;
				switch (num3 == num)
				{
				}
				num = (short)522452993;
				if (num != 0)
				{
				}
				num = (short)1202257920;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.Editable;
			}
			set
			{
				short num = (short)1747648512;
				short num2 = num;
				num = (short)97752697;
				short num3 = num;
				num = (short)1060148857;
				switch (num3 == num)
				{
				}
				num = (short)1630142465;
				if (num != 0)
				{
				}
				num = (short)167641088;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.Editable = value;
			}
		}

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x0099CF80 File Offset: 0x0099B180
		internal string DataWideGeneralPeerIPAddress1_A8524_UILabel
		{
			get
			{
				short num = (short)2022309888;
				short num2 = num;
				num = (short)1776078578;
				short num3 = num;
				num = (short)424791794;
				switch (num3 == num)
				{
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				num = (short)527040512;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.UIName;
			}
		}

		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x0600A4C8 RID: 42184 RVA: 0x0099D038 File Offset: 0x0099B238
		// (set) Token: 0x0600A4C9 RID: 42185 RVA: 0x0099D0EC File Offset: 0x0099B2EC
		internal bool DataWideGeneralPeerIPAddress1_A8524_HiddenStatic
		{
			get
			{
				short num = (short)88735744;
				short num2 = num;
				num = (short)1676262559;
				short num3 = num;
				num = (short)223460511;
				switch (num3 == num)
				{
				}
				num = (short)473563137;
				if (num != 0)
				{
				}
				num = (short)1808924672;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.HiddenStatic;
			}
			set
			{
				short num = (short)1067122688;
				short num2 = num;
				num = (short)678050301;
				short num3 = num;
				num = (short)1361983997;
				switch (num3 == num)
				{
				}
				num = (short)963379200;
				if (num != 0)
				{
				}
				num = (short)1256259585;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.HiddenStatic = value;
			}
		}

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x0600A4CA RID: 42186 RVA: 0x0099D1A4 File Offset: 0x0099B3A4
		// (set) Token: 0x0600A4CB RID: 42187 RVA: 0x0099D25C File Offset: 0x0099B45C
		internal bool DataWideGeneralPeerIPAddress1_A8524_HiddenDynamic
		{
			get
			{
				short num = (short)1404567552;
				short num2 = num;
				num = (short)1362163917;
				short num3 = num;
				num = (short)923269325;
				switch (num3 == num)
				{
				}
				num = (short)1877737473;
				if (num != 0)
				{
				}
				num = (short)1581383680;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524.HiddenDynamic;
			}
			set
			{
				short num = (short)950337536;
				short num2 = num;
				num = (short)1442512897;
				if (num != 0)
				{
				}
				num = (short)117377512;
				short num3 = num;
				num = (short)2096564712;
				switch (num3 == num)
				{
				}
				num = (short)1474887680;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddress1_A8524.HiddenDynamic = value;
			}
		}

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x0600A4CC RID: 42188 RVA: 0x0099D314 File Offset: 0x0099B514
		public bool DataWideGeneralPeerIPAddress1_A8524_HasDiffs
		{
			get
			{
				short num = (short)1858666496;
				short num2 = num;
				num = (short)1864354926;
				short num3 = num;
				num = (short)1724828782;
				switch (num3 == num)
				{
				}
				num = (short)1623392256;
				if (num != 0)
				{
				}
				num = (short)1687748609;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddress1_A8524._HasDiffs;
			}
		}

		// Token: 0x17005297 RID: 21143
		// (get) Token: 0x0600A4CD RID: 42189 RVA: 0x0099D3C4 File Offset: 0x0099B5C4
		// (set) Token: 0x0600A4CE RID: 42190 RVA: 0x0099D47C File Offset: 0x0099B67C
		public bool DataWideGeneralSNMPTraps_A9166Value
		{
			get
			{
				short num = (short)443744256;
				short num2 = num;
				num = (short)1420754945;
				if (num != 0)
				{
				}
				num = (short)1576647823;
				short num3 = num;
				num = (short)1219869839;
				switch (num3 == num)
				{
				}
				num = (short)1963917312;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Value;
			}
			set
			{
				short num = (short)1470431232;
				short num2 = num;
				num = (short)2012716179;
				short num3 = num;
				num = (short)1382325395;
				switch (num3 == num)
				{
				}
				num = (short)1989345281;
				if (num != 0)
				{
				}
				num = (short)1121386496;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Value = value;
			}
		}

		// Token: 0x17005298 RID: 21144
		// (get) Token: 0x0600A4CF RID: 42191 RVA: 0x0099D534 File Offset: 0x0099B734
		public global::AcpBusinessLayer.AcpField<bool> DataWideGeneralSNMPTraps_A9166
		{
			get
			{
				short num = (short)221446144;
				short num2 = num;
				num = (short)1524367361;
				if (num != 0)
				{
				}
				num = (short)1606009561;
				short num3 = num;
				num = (short)283951833;
				switch (num3 == num)
				{
				}
				num = (short)106496000;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166;
			}
		}

		// Token: 0x17005299 RID: 21145
		// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x0099D5E4 File Offset: 0x0099B7E4
		// (set) Token: 0x0600A4D1 RID: 42193 RVA: 0x0099D698 File Offset: 0x0099B898
		public bool DataWideGeneralSNMPTraps_A9166_UIValue
		{
			get
			{
				short num = (short)154758907;
				short num2 = num;
				num = (short)2081648379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1601110016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				num = (short)2058551297;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Value;
			}
			set
			{
				short num = (short)1461047488;
				short num2 = num;
				num = (short)1966592192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144272384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574240257;
				if (num != 0)
				{
				}
				num = (short)2052259840;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Value = value;
			}
		}

		// Token: 0x1700529A RID: 21146
		// (get) Token: 0x0600A4D2 RID: 42194 RVA: 0x0099D750 File Offset: 0x0099B950
		// (set) Token: 0x0600A4D3 RID: 42195 RVA: 0x0099D800 File Offset: 0x0099BA00
		public bool DataWideGeneralSNMPTraps_A9166_Applicable
		{
			get
			{
				short num = (short)799408129;
				if (num != 0)
				{
				}
				num = (short)2082209792;
				short num2 = num;
				num = (short)2069036082;
				short num3 = num;
				num = (short)1684536370;
				switch (num3 == num)
				{
				}
				num = (short)314966016;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Applicable;
			}
			set
			{
				short num = (short)778922578;
				short num2 = num;
				num = (short)1565420114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417660928;
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
				num = (short)1420754944;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Applicable = value;
			}
		}

		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x0099D8B8 File Offset: 0x0099BAB8
		// (set) Token: 0x0600A4D5 RID: 42197 RVA: 0x0099D96C File Offset: 0x0099BB6C
		public bool DataWideGeneralSNMPTraps_A9166_Valid
		{
			get
			{
				short num = (short)1186254913;
				short num2 = num;
				num = (short)654102593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304821760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998389249;
				if (num != 0)
				{
				}
				num = (short)1168703488;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Valid;
			}
			set
			{
				short num = (short)1527048317;
				short num2 = num;
				num = (short)964814973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1712521216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642332160;
				if (num != 0)
				{
				}
				num = (short)751697921;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Valid = value;
			}
		}

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x0099DA20 File Offset: 0x0099BC20
		// (set) Token: 0x0600A4D7 RID: 42199 RVA: 0x0099DAD8 File Offset: 0x0099BCD8
		public bool DataWideGeneralSNMPTraps_A9166_Visible
		{
			get
			{
				short num = (short)1242854013;
				short num2 = num;
				num = (short)1513910909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000603648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1973616640;
				if (num != 0)
				{
				}
				num = (short)604438529;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Visible;
			}
			set
			{
				short num = (short)157788741;
				short num2 = num;
				num = (short)1943644741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395589120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)891289600;
				if (num != 0)
				{
				}
				num = (short)1835794433;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Visible = value;
			}
		}

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x0600A4D8 RID: 42200 RVA: 0x0099DB8C File Offset: 0x0099BD8C
		// (set) Token: 0x0600A4D9 RID: 42201 RVA: 0x0099DC44 File Offset: 0x0099BE44
		public bool DataWideGeneralSNMPTraps_A9166_Editable
		{
			get
			{
				short num = (short)703387588;
				short num2 = num;
				num = (short)183687108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2084634624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189478400;
				if (num != 0)
				{
				}
				num = (short)49020929;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.Editable;
			}
			set
			{
				short num = (short)629401621;
				short num2 = num;
				num = (short)577955861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536084480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1976107009;
				if (num != 0)
				{
				}
				num = (short)1107886080;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.Editable = value;
			}
		}

		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x0600A4DA RID: 42202 RVA: 0x0099DCF8 File Offset: 0x0099BEF8
		internal string DataWideGeneralSNMPTraps_A9166_UILabel
		{
			get
			{
				short num = (short)1596214438;
				short num2 = num;
				num = (short)1639664806;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174863872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879965697;
				if (num != 0)
				{
				}
				num = (short)1126957056;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.UIName;
			}
		}

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x0600A4DB RID: 42203 RVA: 0x0099DDAC File Offset: 0x0099BFAC
		// (set) Token: 0x0600A4DC RID: 42204 RVA: 0x0099DE60 File Offset: 0x0099C060
		internal bool DataWideGeneralSNMPTraps_A9166_HiddenStatic
		{
			get
			{
				short num = (short)937919787;
				short num2 = num;
				num = (short)1874167083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)396492800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281228801;
				if (num != 0)
				{
				}
				num = (short)1983971328;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.HiddenStatic;
			}
			set
			{
				short num = (short)954963268;
				short num2 = num;
				num = (short)853448004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464598528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646919681;
				if (num != 0)
				{
				}
				num = (short)2049769472;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.HiddenStatic = value;
			}
		}

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x0600A4DD RID: 42205 RVA: 0x0099DF14 File Offset: 0x0099C114
		// (set) Token: 0x0600A4DE RID: 42206 RVA: 0x0099DFC8 File Offset: 0x0099C1C8
		internal bool DataWideGeneralSNMPTraps_A9166_HiddenDynamic
		{
			get
			{
				short num = (short)95099714;
				short num2 = num;
				num = (short)1282480962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1263271936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)170131456;
				if (num != 0)
				{
				}
				num = (short)1802567681;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166.HiddenDynamic;
			}
			set
			{
				short num = (short)365347867;
				short num2 = num;
				num = (short)1957807131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588002816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1290862593;
				if (num != 0)
				{
				}
				num = (short)1404108800;
				if (num != 0)
				{
				}
				this.dataWideGeneralSNMPTraps_A9166.HiddenDynamic = value;
			}
		}

		// Token: 0x170052A1 RID: 21153
		// (get) Token: 0x0600A4DF RID: 42207 RVA: 0x0099E07C File Offset: 0x0099C27C
		public bool DataWideGeneralSNMPTraps_A9166_HasDiffs
		{
			get
			{
				short num = (short)2121553439;
				short num2 = num;
				num = (short)1238521375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)378601472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576782337;
				if (num != 0)
				{
				}
				num = (short)621281280;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSNMPTraps_A9166._HasDiffs;
			}
		}

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x0600A4E0 RID: 42208 RVA: 0x0099E130 File Offset: 0x0099C330
		// (set) Token: 0x0600A4E1 RID: 42209 RVA: 0x0099E1E4 File Offset: 0x0099C3E4
		public long DataWideGeneralSubscriberIPAddress1_A9222Value
		{
			get
			{
				short num = (short)61219421;
				short num2 = num;
				num = (short)1762140765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1478492160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295043073;
				if (num != 0)
				{
				}
				num = (short)239730688;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.Value;
			}
			set
			{
				short num = (short)1859596985;
				short num2 = num;
				num = (short)851784377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968373760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)91226112;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.Value = value;
			}
		}

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x0600A4E2 RID: 42210 RVA: 0x0099E298 File Offset: 0x0099C498
		// (set) Token: 0x0600A4E3 RID: 42211 RVA: 0x0099E34C File Offset: 0x0099C54C
		public string DataWideGeneralSubscriberIPAddress1_A9222_UIValue
		{
			get
			{
				short num = (short)757700353;
				short num2 = num;
				num = (short)1439274753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1429864448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885536257;
				if (num != 0)
				{
				}
				num = (short)2146828288;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.UIValue;
			}
			set
			{
				short num = (short)527899919;
				short num2 = num;
				num = (short)660151567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305018368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199833089;
				if (num != 0)
				{
				}
				num = (short)1558183936;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.UIValue = value;
			}
		}

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x0099E400 File Offset: 0x0099C600
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralSubscriberIPAddress1_A9222
		{
			get
			{
				short num = (short)2011323592;
				short num2 = num;
				num = (short)1344036040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078867456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52756480;
				if (num != 0)
				{
				}
				num = (short)28966913;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222;
			}
		}

		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x0600A4E5 RID: 42213 RVA: 0x0099E4B4 File Offset: 0x0099C6B4
		// (set) Token: 0x0600A4E6 RID: 42214 RVA: 0x0099E568 File Offset: 0x0099C768
		public bool DataWideGeneralSubscriberIPAddress1_A9222_Applicable
		{
			get
			{
				short num = (short)852629487;
				short num2 = num;
				num = (short)431364079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116419584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563820033;
				if (num != 0)
				{
				}
				num = (short)1613561856;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.Applicable;
			}
			set
			{
				short num = (short)1299943166;
				short num2 = num;
				num = (short)593268478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1797718016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70189057;
				if (num != 0)
				{
				}
				num = (short)1159921664;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.Applicable = value;
			}
		}

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x0600A4E7 RID: 42215 RVA: 0x0099E620 File Offset: 0x0099C820
		// (set) Token: 0x0600A4E8 RID: 42216 RVA: 0x0099E6D8 File Offset: 0x0099C8D8
		public bool DataWideGeneralSubscriberIPAddress1_A9222_Valid
		{
			get
			{
				short num = (short)64404961;
				short num2 = num;
				num = (short)493141473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169031168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266089985;
				if (num != 0)
				{
				}
				num = (short)1386545152;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.Valid;
			}
			set
			{
				short num = (short)1513881601;
				if (num != 0)
				{
				}
				num = (short)1582759936;
				short num2 = num;
				num = (short)429317134;
				short num3 = num;
				num = (short)1187306510;
				switch (num3 == num)
				{
				}
				num = (short)687276032;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.Valid = value;
			}
		}

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x0600A4E9 RID: 42217 RVA: 0x0099E790 File Offset: 0x0099C990
		// (set) Token: 0x0600A4EA RID: 42218 RVA: 0x0099E844 File Offset: 0x0099CA44
		public bool DataWideGeneralSubscriberIPAddress1_A9222_Visible
		{
			get
			{
				short num = (short)58716227;
				short num2 = num;
				num = (short)1545465923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927531008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296105473;
				if (num != 0)
				{
				}
				num = (short)1818820608;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.Visible;
			}
			set
			{
				short num = (short)924613003;
				short num2 = num;
				num = (short)824146315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610088448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1893990401;
				if (num != 0)
				{
				}
				num = (short)934281216;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.Visible = value;
			}
		}

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x0600A4EB RID: 42219 RVA: 0x0099E8FC File Offset: 0x0099CAFC
		// (set) Token: 0x0600A4EC RID: 42220 RVA: 0x0099E9B0 File Offset: 0x0099CBB0
		public bool DataWideGeneralSubscriberIPAddress1_A9222_Editable
		{
			get
			{
				short num = (short)672586914;
				short num2 = num;
				num = (short)1521605794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466419712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1014562817;
				if (num != 0)
				{
				}
				num = (short)1921908736;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.Editable;
			}
			set
			{
				short num = (short)1624637441;
				if (num != 0)
				{
				}
				num = (short)1103233024;
				short num2 = num;
				num = (short)900203705;
				short num3 = num;
				num = (short)1241711801;
				switch (num3 == num)
				{
				}
				num = (short)792526848;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.Editable = value;
			}
		}

		// Token: 0x170052A9 RID: 21161
		// (get) Token: 0x0600A4ED RID: 42221 RVA: 0x0099EA64 File Offset: 0x0099CC64
		internal string DataWideGeneralSubscriberIPAddress1_A9222_UILabel
		{
			get
			{
				short num = (short)113850055;
				short num2 = num;
				num = (short)1871460039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360723968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668270592;
				if (num != 0)
				{
				}
				num = (short)1952120833;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.UIName;
			}
		}

		// Token: 0x170052AA RID: 21162
		// (get) Token: 0x0600A4EE RID: 42222 RVA: 0x0099EB1C File Offset: 0x0099CD1C
		// (set) Token: 0x0600A4EF RID: 42223 RVA: 0x0099EBD0 File Offset: 0x0099CDD0
		internal bool DataWideGeneralSubscriberIPAddress1_A9222_HiddenStatic
		{
			get
			{
				short num = (short)1306525697;
				if (num != 0)
				{
				}
				num = (short)1017184256;
				short num2 = num;
				num = (short)1945687652;
				short num3 = num;
				num = (short)1637996132;
				switch (num3 == num)
				{
				}
				num = (short)2114584576;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.HiddenStatic;
			}
			set
			{
				short num = (short)1211770311;
				short num2 = num;
				num = (short)1592993223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483065856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1054539777;
				if (num != 0)
				{
				}
				num = (short)429457408;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.HiddenStatic = value;
			}
		}

		// Token: 0x170052AB RID: 21163
		// (get) Token: 0x0600A4F0 RID: 42224 RVA: 0x0099EC8C File Offset: 0x0099CE8C
		// (set) Token: 0x0600A4F1 RID: 42225 RVA: 0x0099ED44 File Offset: 0x0099CF44
		internal bool DataWideGeneralSubscriberIPAddress1_A9222_HiddenDynamic
		{
			get
			{
				short num = (short)526734024;
				short num2 = num;
				num = (short)755192520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002504192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493368833;
				if (num != 0)
				{
				}
				num = (short)1428815872;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222.HiddenDynamic;
			}
			set
			{
				short num = (short)1902022396;
				short num2 = num;
				num = (short)1290768124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1831272448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033764864;
				if (num != 0)
				{
				}
				num = (short)246874113;
				if (num != 0)
				{
				}
				this.dataWideGeneralSubscriberIPAddress1_A9222.HiddenDynamic = value;
			}
		}

		// Token: 0x170052AC RID: 21164
		// (get) Token: 0x0600A4F2 RID: 42226 RVA: 0x0099EDFC File Offset: 0x0099CFFC
		public bool DataWideGeneralSubscriberIPAddress1_A9222_HasDiffs
		{
			get
			{
				short num = (short)796749209;
				short num2 = num;
				num = (short)891383193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942669824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2011758592;
				if (num != 0)
				{
				}
				num = (short)723648513;
				if (num != 0)
				{
				}
				return this.dataWideGeneralSubscriberIPAddress1_A9222._HasDiffs;
			}
		}

		// Token: 0x170052AD RID: 21165
		// (get) Token: 0x0600A4F3 RID: 42227 RVA: 0x0099EEB0 File Offset: 0x0099D0B0
		// (set) Token: 0x0600A4F4 RID: 42228 RVA: 0x0099EF68 File Offset: 0x0099D168
		public int DataWideGeneralPeerIPAddressAssignmentType1_A22376Value
		{
			get
			{
				short num = (short)1449197569;
				if (num != 0)
				{
				}
				num = (short)1040711680;
				short num2 = num;
				num = (short)962237775;
				short num3 = num;
				num = (short)158111055;
				switch (num3 == num)
				{
				}
				num = (short)1603141632;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Value;
			}
			set
			{
				short num = (short)1980675800;
				short num2 = num;
				num = (short)1639102168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1020329984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7995392;
				if (num != 0)
				{
				}
				num = (short)1520959489;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Value = value;
			}
		}

		// Token: 0x170052AE RID: 21166
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x0099F01C File Offset: 0x0099D21C
		// (set) Token: 0x0600A4F6 RID: 42230 RVA: 0x0099F0D4 File Offset: 0x0099D2D4
		public string DataWideGeneralPeerIPAddressAssignmentType1_A22376_UIValue
		{
			get
			{
				short num = (short)1749104671;
				short num2 = num;
				num = (short)2056796191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706557440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893845505;
				if (num != 0)
				{
				}
				num = (short)1470693376;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.UIValue;
			}
			set
			{
				short num = (short)451538955;
				short num2 = num;
				num = (short)1976758283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947533312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505151489;
				if (num != 0)
				{
				}
				num = (short)125239296;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.UIValue = value;
			}
		}

		// Token: 0x170052AF RID: 21167
		// (get) Token: 0x0600A4F7 RID: 42231 RVA: 0x0099F18C File Offset: 0x0099D38C
		public global::AcpBusinessLayer.AcpListField DataWideGeneralPeerIPAddressAssignmentType1_A22376
		{
			get
			{
				short num = (short)853246521;
				short num2 = num;
				num = (short)963609145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93192192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953417728;
				if (num != 0)
				{
				}
				num = (short)1591803905;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376;
			}
		}

		// Token: 0x170052B0 RID: 21168
		// (get) Token: 0x0600A4F8 RID: 42232 RVA: 0x0099F23C File Offset: 0x0099D43C
		// (set) Token: 0x0600A4F9 RID: 42233 RVA: 0x0099F2F0 File Offset: 0x0099D4F0
		public bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_Applicable
		{
			get
			{
				short num = (short)2136211457;
				if (num != 0)
				{
				}
				num = (short)1102577664;
				short num2 = num;
				num = (short)1384979822;
				short num3 = num;
				num = (short)641080686;
				switch (num3 == num)
				{
				}
				num = (short)677314560;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Applicable;
			}
			set
			{
				short num = (short)2106940542;
				short num2 = num;
				num = (short)261971070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1502478336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)62652417;
				if (num != 0)
				{
				}
				num = (short)359202816;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Applicable = value;
			}
		}

		// Token: 0x170052B1 RID: 21169
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x0099F3A8 File Offset: 0x0099D5A8
		// (set) Token: 0x0600A4FB RID: 42235 RVA: 0x0099F45C File Offset: 0x0099D65C
		public bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_Valid
		{
			get
			{
				short num = (short)1936842640;
				short num2 = num;
				num = (short)1131732880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1896480768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378667008;
				if (num != 0)
				{
				}
				num = (short)1258946561;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Valid;
			}
			set
			{
				short num = (short)182280872;
				short num2 = num;
				num = (short)818045608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966538752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)313327617;
				if (num != 0)
				{
				}
				num = (short)1684209664;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Valid = value;
			}
		}

		// Token: 0x170052B2 RID: 21170
		// (get) Token: 0x0600A4FC RID: 42236 RVA: 0x0099F514 File Offset: 0x0099D714
		// (set) Token: 0x0600A4FD RID: 42237 RVA: 0x0099F5C8 File Offset: 0x0099D7C8
		public bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_Visible
		{
			get
			{
				short num = (short)2141894751;
				short num2 = num;
				num = (short)1232910431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592248832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206569473;
				if (num != 0)
				{
				}
				num = (short)1226833920;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Visible;
			}
			set
			{
				short num = (short)889389057;
				if (num != 0)
				{
				}
				num = (short)973406208;
				short num2 = num;
				num = (short)1010962766;
				short num3 = num;
				num = (short)1821380942;
				switch (num3 == num)
				{
				}
				num = (short)2133721088;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Visible = value;
			}
		}

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x0600A4FE RID: 42238 RVA: 0x0099F67C File Offset: 0x0099D87C
		// (set) Token: 0x0600A4FF RID: 42239 RVA: 0x0099F734 File Offset: 0x0099D934
		public bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_Editable
		{
			get
			{
				short num = (short)2098149806;
				short num2 = num;
				num = (short)994458030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030750208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1180368896;
				if (num != 0)
				{
				}
				num = (short)454033409;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Editable;
			}
			set
			{
				short num = (short)939303260;
				short num2 = num;
				num = (short)1819582812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582483968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893845505;
				if (num != 0)
				{
				}
				num = (short)1285226496;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.Editable = value;
			}
		}

		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x0600A500 RID: 42240 RVA: 0x0099F7EC File Offset: 0x0099D9EC
		internal string DataWideGeneralPeerIPAddressAssignmentType1_A22376_UILabel
		{
			get
			{
				short num = (short)1263957473;
				short num2 = num;
				num = (short)963343841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887422976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549781505;
				if (num != 0)
				{
				}
				num = (short)497549312;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.UIName;
			}
		}

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x0600A501 RID: 42241 RVA: 0x0099F8A0 File Offset: 0x0099DAA0
		// (set) Token: 0x0600A502 RID: 42242 RVA: 0x0099F954 File Offset: 0x0099DB54
		internal bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_HiddenStatic
		{
			get
			{
				short num = (short)188219393;
				if (num != 0)
				{
				}
				num = (short)1908015104;
				short num2 = num;
				num = (short)1455465134;
				short num3 = num;
				num = (short)136290990;
				switch (num3 == num)
				{
				}
				num = (short)1280573440;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.HiddenStatic;
			}
			set
			{
				short num = (short)1616373643;
				short num2 = num;
				num = (short)1403905931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227082240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)691142656;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.HiddenStatic = value;
			}
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x0600A503 RID: 42243 RVA: 0x0099FA0C File Offset: 0x0099DC0C
		// (set) Token: 0x0600A504 RID: 42244 RVA: 0x0099FAC0 File Offset: 0x0099DCC0
		internal bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_HiddenDynamic
		{
			get
			{
				short num = (short)1775540660;
				short num2 = num;
				num = (short)1698601396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762328576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1882128385;
				if (num != 0)
				{
				}
				num = (short)1951203328;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.HiddenDynamic;
			}
			set
			{
				short num = (short)1809982862;
				short num2 = num;
				num = (short)444736910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)774242304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1460273153;
				if (num != 0)
				{
				}
				num = (short)145031168;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType1_A22376.HiddenDynamic = value;
			}
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x0099FB74 File Offset: 0x0099DD74
		public bool DataWideGeneralPeerIPAddressAssignmentType1_A22376_HasDiffs
		{
			get
			{
				short num = (short)2077622273;
				if (num != 0)
				{
				}
				num = (short)263782400;
				short num2 = num;
				num = (short)1281851267;
				short num3 = num;
				num = (short)814972803;
				switch (num3 == num)
				{
				}
				num = (short)1235419136;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType1_A22376._HasDiffs;
			}
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x0600A506 RID: 42246 RVA: 0x0099FC28 File Offset: 0x0099DE28
		// (set) Token: 0x0600A507 RID: 42247 RVA: 0x0099FCDC File Offset: 0x0099DEDC
		public int DataWideGeneralPeerIPAddressAssignmentType2_A22377Value
		{
			get
			{
				short num = (short)747857424;
				short num2 = num;
				num = (short)701392400;
				switch (num2 == num)
				{
				}
				num = (short)383975425;
				if (num != 0)
				{
				}
				num = (short)164691968;
				short num3 = num;
				num = (short)1097662464;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Value;
			}
			set
			{
				short num = (short)1627412236;
				short num2 = num;
				num = (short)1833195276;
				switch (num2 == num)
				{
				}
				num = (short)759627777;
				if (num != 0)
				{
				}
				num = (short)1616576512;
				short num3 = num;
				num = (short)920911872;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Value = value;
			}
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x0600A508 RID: 42248 RVA: 0x0099FD90 File Offset: 0x0099DF90
		// (set) Token: 0x0600A509 RID: 42249 RVA: 0x0099FE44 File Offset: 0x0099E044
		public string DataWideGeneralPeerIPAddressAssignmentType2_A22377_UIValue
		{
			get
			{
				short num = (short)306594241;
				short num2 = num;
				num = (short)1806713281;
				switch (num2 == num)
				{
				}
				num = (short)990117888;
				if (num != 0)
				{
				}
				num = (short)50528256;
				short num3 = num;
				num = (short)1336147969;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.UIValue;
			}
			set
			{
				short num = (short)373505617;
				short num2 = num;
				num = (short)1000554065;
				switch (num2 == num)
				{
				}
				num = (short)438763521;
				if (num != 0)
				{
				}
				num = (short)1476263936;
				short num3 = num;
				num = (short)1573191680;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.UIValue = value;
			}
		}

		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x0600A50A RID: 42250 RVA: 0x0099FEFC File Offset: 0x0099E0FC
		public global::AcpBusinessLayer.AcpListField DataWideGeneralPeerIPAddressAssignmentType2_A22377
		{
			get
			{
				short num = (short)2115145283;
				short num2 = num;
				num = (short)1849790019;
				switch (num2 == num)
				{
				}
				num = (short)1441660929;
				if (num != 0)
				{
				}
				num = (short)153944064;
				short num3 = num;
				num = (short)243662848;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377;
			}
		}

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x0099FFA8 File Offset: 0x0099E1A8
		// (set) Token: 0x0600A50C RID: 42252 RVA: 0x009A005C File Offset: 0x0099E25C
		public bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_Applicable
		{
			get
			{
				short num = (short)1391321086;
				short num2 = num;
				num = (short)1776082942;
				switch (num2 == num)
				{
				}
				num = (short)940965888;
				if (num != 0)
				{
				}
				num = (short)1881735168;
				short num3 = num;
				num = (short)1726283777;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Applicable;
			}
			set
			{
				short num = (short)895512306;
				short num2 = num;
				num = (short)1944088306;
				switch (num2 == num)
				{
				}
				num = (short)1583153153;
				if (num != 0)
				{
				}
				num = (short)1700200448;
				short num3 = num;
				num = (short)615317504;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Applicable = value;
			}
		}

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x009A0110 File Offset: 0x0099E310
		// (set) Token: 0x0600A50E RID: 42254 RVA: 0x009A01C4 File Offset: 0x0099E3C4
		public bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_Valid
		{
			get
			{
				short num = (short)640914907;
				short num2 = num;
				num = (short)1546556891;
				switch (num2 == num)
				{
				}
				num = (short)146407425;
				if (num != 0)
				{
				}
				num = (short)293601280;
				short num3 = num;
				num = (short)264634368;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Valid;
			}
			set
			{
				short num = (short)2094507403;
				short num2 = num;
				num = (short)213951883;
				switch (num2 == num)
				{
				}
				num = (short)1854013440;
				if (num != 0)
				{
				}
				num = (short)1398931456;
				short num3 = num;
				num = (short)39780353;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Valid = value;
			}
		}

		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x0600A50F RID: 42255 RVA: 0x009A0278 File Offset: 0x0099E478
		// (set) Token: 0x0600A510 RID: 42256 RVA: 0x009A0330 File Offset: 0x0099E530
		public bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_Visible
		{
			get
			{
				short num = (short)2025627901;
				short num2 = num;
				num = (short)929603837;
				switch (num2 == num)
				{
				}
				num = (short)1761345536;
				if (num != 0)
				{
				}
				num = (short)594935808;
				short num3 = num;
				num = (short)716636161;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Visible;
			}
			set
			{
				short num = (short)130945456;
				short num2 = num;
				num = (short)1466765744;
				switch (num2 == num)
				{
				}
				num = (short)1999110145;
				if (num != 0)
				{
				}
				num = (short)1632436224;
				short num3 = num;
				num = (short)1682309120;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Visible = value;
			}
		}

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x009A03E8 File Offset: 0x0099E5E8
		// (set) Token: 0x0600A512 RID: 42258 RVA: 0x009A049C File Offset: 0x0099E69C
		public bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_Editable
		{
			get
			{
				short num = (short)1235156993;
				if (num != 0)
				{
				}
				num = (short)113321695;
				short num2 = num;
				num = (short)474228447;
				switch (num2 == num)
				{
				}
				num = (short)513146880;
				short num3 = num;
				num = (short)319291392;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Editable;
			}
			set
			{
				short num = (short)1738682978;
				short num2 = num;
				num = (short)1213215330;
				switch (num2 == num)
				{
				}
				num = (short)593625088;
				if (num != 0)
				{
				}
				num = (short)65994752;
				short num3 = num;
				num = (short)747438081;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.Editable = value;
			}
		}

		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x0600A513 RID: 42259 RVA: 0x009A0554 File Offset: 0x0099E754
		internal string DataWideGeneralPeerIPAddressAssignmentType2_A22377_UILabel
		{
			get
			{
				short num = (short)2047739464;
				short num2 = num;
				num = (short)1258161736;
				switch (num2 == num)
				{
				}
				num = (short)1627127809;
				if (num != 0)
				{
				}
				num = (short)1585709056;
				short num3 = num;
				num = (short)1947860992;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.UIName;
			}
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x009A060C File Offset: 0x0099E80C
		// (set) Token: 0x0600A515 RID: 42261 RVA: 0x009A06C0 File Offset: 0x0099E8C0
		internal bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_HiddenStatic
		{
			get
			{
				short num = (short)2019863977;
				short num2 = num;
				num = (short)2065214889;
				switch (num2 == num)
				{
				}
				num = (short)321716224;
				if (num != 0)
				{
				}
				num = (short)851050496;
				short num3 = num;
				num = (short)1655898113;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.HiddenStatic;
			}
			set
			{
				short num = (short)87699148;
				short num2 = num;
				num = (short)1643720396;
				switch (num2 == num)
				{
				}
				num = (short)1189085185;
				if (num != 0)
				{
				}
				num = (short)1316028416;
				short num3 = num;
				num = (short)1001783296;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.HiddenStatic = value;
			}
		}

		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x0600A516 RID: 42262 RVA: 0x009A0778 File Offset: 0x0099E978
		// (set) Token: 0x0600A517 RID: 42263 RVA: 0x009A082C File Offset: 0x0099EA2C
		internal bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_HiddenDynamic
		{
			get
			{
				short num = (short)315858758;
				short num2 = num;
				num = (short)1199349574;
				switch (num2 == num)
				{
				}
				num = (short)532807681;
				if (num != 0)
				{
				}
				num = (short)297730048;
				short num3 = num;
				num = (short)79233024;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.HiddenDynamic;
			}
			set
			{
				short num = (short)1698097726;
				short num2 = num;
				num = (short)211479102;
				switch (num2 == num)
				{
				}
				num = (short)1113260032;
				if (num != 0)
				{
				}
				num = (short)1880424448;
				short num3 = num;
				num = (short)1798569985;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType2_A22377.HiddenDynamic = value;
			}
		}

		// Token: 0x170052C2 RID: 21186
		// (get) Token: 0x0600A518 RID: 42264 RVA: 0x009A08E4 File Offset: 0x0099EAE4
		public bool DataWideGeneralPeerIPAddressAssignmentType2_A22377_HasDiffs
		{
			get
			{
				short num = (short)449331885;
				short num2 = num;
				num = (short)753681069;
				switch (num2 == num)
				{
				}
				num = (short)118882304;
				if (num != 0)
				{
				}
				num = (short)1070399488;
				short num3 = num;
				num = (short)1928003585;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType2_A22377._HasDiffs;
			}
		}

		// Token: 0x170052C3 RID: 21187
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x009A0998 File Offset: 0x0099EB98
		// (set) Token: 0x0600A51A RID: 42266 RVA: 0x009A0A50 File Offset: 0x0099EC50
		public long DataWideGeneralBTDUNSUIPAddress_A41120Value
		{
			get
			{
				short num = (short)1556550856;
				short num2 = num;
				num = (short)782439624;
				switch (num2 == num)
				{
				}
				num = (short)1245118465;
				if (num != 0)
				{
				}
				num = (short)1840709632;
				short num3 = num;
				num = (short)503316480;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.Value;
			}
			set
			{
				short num = (short)1054081025;
				if (num != 0)
				{
				}
				num = (short)1267728288;
				short num2 = num;
				num = (short)1196752800;
				switch (num2 == num)
				{
				}
				num = (short)51576832;
				short num3 = num;
				num = (short)1039138816;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.Value = value;
			}
		}

		// Token: 0x170052C4 RID: 21188
		// (get) Token: 0x0600A51B RID: 42267 RVA: 0x009A0B04 File Offset: 0x0099ED04
		// (set) Token: 0x0600A51C RID: 42268 RVA: 0x009A0BB8 File Offset: 0x0099EDB8
		public string DataWideGeneralBTDUNSUIPAddress_A41120_UIValue
		{
			get
			{
				short num = (short)1300824138;
				short num2 = num;
				num = (short)508166218;
				switch (num2 == num)
				{
				}
				num = (short)1603731457;
				if (num != 0)
				{
				}
				num = (short)114622464;
				short num3 = num;
				num = (short)585039872;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.UIValue;
			}
			set
			{
				short num = (short)18888798;
				short num2 = num;
				num = (short)1529690206;
				switch (num2 == num)
				{
				}
				num = (short)545193984;
				if (num != 0)
				{
				}
				num = (short)2129920000;
				short num3 = num;
				num = (short)769458177;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.UIValue = value;
			}
		}

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x0600A51D RID: 42269 RVA: 0x009A0C6C File Offset: 0x0099EE6C
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralBTDUNSUIPAddress_A41120
		{
			get
			{
				short num = (short)1272709121;
				if (num != 0)
				{
				}
				num = (short)571747414;
				short num2 = num;
				num = (short)1483549782;
				switch (num2 == num)
				{
				}
				num = (short)12976128;
				short num3 = num;
				num = (short)644218880;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120;
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x009A0D20 File Offset: 0x0099EF20
		// (set) Token: 0x0600A51F RID: 42271 RVA: 0x009A0DD4 File Offset: 0x0099EFD4
		public bool DataWideGeneralBTDUNSUIPAddress_A41120_Applicable
		{
			get
			{
				short num = (short)1287652738;
				short num2 = num;
				num = (short)777192834;
				switch (num2 == num)
				{
				}
				num = (short)2017853441;
				if (num != 0)
				{
				}
				num = (short)921305088;
				short num3 = num;
				num = (short)681902080;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.Applicable;
			}
			set
			{
				short num = (short)1304821761;
				if (num != 0)
				{
				}
				num = (short)1124584128;
				short num2 = num;
				num = (short)312658624;
				switch (num2 == num)
				{
				}
				num = (short)1192493056;
				short num3 = num;
				num = (short)217186304;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.Applicable = value;
			}
		}

		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x0600A520 RID: 42272 RVA: 0x009A0E88 File Offset: 0x0099F088
		// (set) Token: 0x0600A521 RID: 42273 RVA: 0x009A0F3C File Offset: 0x0099F13C
		public bool DataWideGeneralBTDUNSUIPAddress_A41120_Valid
		{
			get
			{
				short num = (short)249476757;
				short num2 = num;
				num = (short)1200076437;
				switch (num2 == num)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				num = (short)1455095808;
				short num3 = num;
				num = (short)912064513;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.Valid;
			}
			set
			{
				short num = (short)1145231406;
				short num2 = num;
				num = (short)1552406574;
				switch (num2 == num)
				{
				}
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)1276051456;
				short num3 = num;
				num = (short)494272512;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.Valid = value;
			}
		}

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x009A0FF0 File Offset: 0x0099F1F0
		// (set) Token: 0x0600A523 RID: 42275 RVA: 0x009A10A4 File Offset: 0x0099F2A4
		public bool DataWideGeneralBTDUNSUIPAddress_A41120_Visible
		{
			get
			{
				short num = (short)1137010368;
				short num2 = num;
				num = (short)1297573568;
				switch (num2 == num)
				{
				}
				num = (short)1418526721;
				if (num != 0)
				{
				}
				num = (short)982450176;
				short num3 = num;
				num = (short)526843904;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.Visible;
			}
			set
			{
				short num = (short)1759863307;
				short num2 = num;
				num = (short)255746571;
				switch (num2 == num)
				{
				}
				num = (short)1534656512;
				if (num != 0)
				{
				}
				num = (short)605814784;
				short num3 = num;
				num = (short)2037317633;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.Visible = value;
			}
		}

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x0600A524 RID: 42276 RVA: 0x009A115C File Offset: 0x0099F35C
		// (set) Token: 0x0600A525 RID: 42277 RVA: 0x009A1210 File Offset: 0x0099F410
		public bool DataWideGeneralBTDUNSUIPAddress_A41120_Editable
		{
			get
			{
				short num = (short)725372731;
				short num2 = num;
				num = (short)1176850235;
				switch (num2 == num)
				{
				}
				num = (short)1169686529;
				if (num != 0)
				{
				}
				num = (short)1074397184;
				short num3 = num;
				num = (short)765984768;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.Editable;
			}
			set
			{
				short num = (short)692599983;
				short num2 = num;
				num = (short)276380847;
				switch (num2 == num)
				{
				}
				num = (short)1798373377;
				if (num != 0)
				{
				}
				num = (short)1799946240;
				short num3 = num;
				num = (short)1819738112;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.Editable = value;
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x009A12C4 File Offset: 0x0099F4C4
		internal string DataWideGeneralBTDUNSUIPAddress_A41120_UILabel
		{
			get
			{
				short num = (short)2113208376;
				short num2 = num;
				num = (short)1597964344;
				switch (num2 == num)
				{
				}
				num = (short)2009858048;
				if (num != 0)
				{
				}
				num = (short)222035968;
				short num3 = num;
				num = (short)125960193;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.UIName;
			}
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x0600A527 RID: 42279 RVA: 0x009A1378 File Offset: 0x0099F578
		// (set) Token: 0x0600A528 RID: 42280 RVA: 0x009A1430 File Offset: 0x0099F630
		internal bool DataWideGeneralBTDUNSUIPAddress_A41120_HiddenStatic
		{
			get
			{
				short num = (short)1519113028;
				short num2 = num;
				num = (short)151376708;
				switch (num2 == num)
				{
				}
				num = (short)1659830273;
				if (num != 0)
				{
				}
				num = (short)2043478016;
				short num3 = num;
				num = (short)1139736576;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.HiddenStatic;
			}
			set
			{
				short num = (short)696723691;
				short num2 = num;
				num = (short)1853696235;
				switch (num2 == num)
				{
				}
				num = (short)1451556864;
				if (num != 0)
				{
				}
				num = (short)1573322752;
				short num3 = num;
				num = (short)1216020481;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.HiddenStatic = value;
			}
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x0600A529 RID: 42281 RVA: 0x009A14E4 File Offset: 0x0099F6E4
		// (set) Token: 0x0600A52A RID: 42282 RVA: 0x009A1598 File Offset: 0x0099F798
		internal bool DataWideGeneralBTDUNSUIPAddress_A41120_HiddenDynamic
		{
			get
			{
				short num = (short)249632396;
				short num2 = num;
				num = (short)1438520972;
				switch (num2 == num)
				{
				}
				num = (short)314048512;
				if (num != 0)
				{
				}
				num = (short)188219392;
				short num3 = num;
				num = (short)988086273;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120.HiddenDynamic;
			}
			set
			{
				short num = (short)1459704717;
				short num2 = num;
				num = (short)98063245;
				switch (num2 == num)
				{
				}
				num = (short)1305346049;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				short num3 = num;
				num = (short)454230016;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNSUIPAddress_A41120.HiddenDynamic = value;
			}
		}

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x0600A52B RID: 42283 RVA: 0x009A164C File Offset: 0x0099F84C
		public bool DataWideGeneralBTDUNSUIPAddress_A41120_HasDiffs
		{
			get
			{
				short num = (short)1034027009;
				if (num != 0)
				{
				}
				num = (short)389970055;
				short num2 = num;
				num = (short)332691591;
				switch (num2 == num)
				{
				}
				num = (short)548536320;
				short num3 = num;
				num = (short)813367296;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNSUIPAddress_A41120._HasDiffs;
			}
		}

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x0600A52C RID: 42284 RVA: 0x009A1704 File Offset: 0x0099F904
		// (set) Token: 0x0600A52D RID: 42285 RVA: 0x009A17B8 File Offset: 0x0099F9B8
		public long DataWideGeneralBTDUNPeerIPAddress_A41123Value
		{
			get
			{
				short num = (short)313043419;
				short num2 = num;
				num = (short)290171355;
				switch (num2 == num)
				{
				}
				num = (short)1943732225;
				if (num != 0)
				{
				}
				num = (short)726007808;
				short num3 = num;
				num = (short)1427963904;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.Value;
			}
			set
			{
				short num = (short)177278989;
				short num2 = num;
				num = (short)2055606285;
				switch (num2 == num)
				{
				}
				num = (short)421986304;
				if (num != 0)
				{
				}
				num = (short)441516032;
				short num3 = num;
				num = (short)938213377;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.Value = value;
			}
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x009A186C File Offset: 0x0099FA6C
		// (set) Token: 0x0600A52F RID: 42287 RVA: 0x009A1920 File Offset: 0x0099FB20
		public string DataWideGeneralBTDUNPeerIPAddress_A41123_UIValue
		{
			get
			{
				short num = (short)1504313345;
				if (num != 0)
				{
				}
				num = (short)2139427654;
				short num2 = num;
				num = (short)2120487750;
				switch (num2 == num)
				{
				}
				num = (short)1203044352;
				short num3 = num;
				num = (short)922943488;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.UIValue;
			}
			set
			{
				short num = (short)145852307;
				short num2 = num;
				num = (short)1549502355;
				switch (num2 == num)
				{
				}
				num = (short)1309736961;
				if (num != 0)
				{
				}
				num = (short)1823670272;
				short num3 = num;
				num = (short)1414332416;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.UIValue = value;
			}
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x0600A530 RID: 42288 RVA: 0x009A19D4 File Offset: 0x0099FBD4
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralBTDUNPeerIPAddress_A41123
		{
			get
			{
				short num = (short)790476530;
				short num2 = num;
				num = (short)1415493362;
				switch (num2 == num)
				{
				}
				num = (short)281018369;
				if (num != 0)
				{
				}
				num = (short)98304000;
				short num3 = num;
				num = (short)1881669632;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123;
			}
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x0600A531 RID: 42289 RVA: 0x009A1A84 File Offset: 0x0099FC84
		// (set) Token: 0x0600A532 RID: 42290 RVA: 0x009A1B38 File Offset: 0x0099FD38
		public bool DataWideGeneralBTDUNPeerIPAddress_A41123_Applicable
		{
			get
			{
				short num = (short)687276033;
				if (num != 0)
				{
				}
				num = (short)818626195;
				short num2 = num;
				num = (short)561856147;
				switch (num2 == num)
				{
				}
				num = (short)1233387520;
				short num3 = num;
				num = (short)289406976;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.Applicable;
			}
			set
			{
				short num = (short)1194217719;
				short num2 = num;
				num = (short)1077104887;
				switch (num2 == num)
				{
				}
				num = (short)115605505;
				if (num != 0)
				{
				}
				num = (short)580321280;
				short num3 = num;
				num = (short)86966272;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.Applicable = value;
			}
		}

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x0600A533 RID: 42291 RVA: 0x009A1BF0 File Offset: 0x0099FDF0
		// (set) Token: 0x0600A534 RID: 42292 RVA: 0x009A1CA4 File Offset: 0x0099FEA4
		public bool DataWideGeneralBTDUNPeerIPAddress_A41123_Valid
		{
			get
			{
				short num = (short)198283647;
				short num2 = num;
				num = (short)486379903;
				switch (num2 == num)
				{
				}
				num = (short)1149698049;
				if (num != 0)
				{
				}
				num = (short)2127364096;
				short num3 = num;
				num = (short)1981349888;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.Valid;
			}
			set
			{
				short num = (short)567869441;
				if (num != 0)
				{
				}
				num = (short)1793515244;
				short num2 = num;
				num = (short)629989100;
				switch (num2 == num)
				{
				}
				num = (short)404750336;
				short num3 = num;
				num = (short)1197277184;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.Valid = value;
			}
		}

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x0600A535 RID: 42293 RVA: 0x009A1D58 File Offset: 0x0099FF58
		// (set) Token: 0x0600A536 RID: 42294 RVA: 0x009A1E10 File Offset: 0x009A0010
		public bool DataWideGeneralBTDUNPeerIPAddress_A41123_Visible
		{
			get
			{
				short num = (short)81212262;
				short num2 = num;
				num = (short)1405694822;
				switch (num2 == num)
				{
				}
				num = (short)1103888385;
				if (num != 0)
				{
				}
				num = (short)344129536;
				short num3 = num;
				num = (short)450560000;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.Visible;
			}
			set
			{
				short num = (short)610071474;
				short num2 = num;
				num = (short)486601650;
				switch (num2 == num)
				{
				}
				num = (short)1576599553;
				if (num != 0)
				{
				}
				num = (short)1982201856;
				short num3 = num;
				num = (short)676790272;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.Visible = value;
			}
		}

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x0600A537 RID: 42295 RVA: 0x009A1EC4 File Offset: 0x009A00C4
		// (set) Token: 0x0600A538 RID: 42296 RVA: 0x009A1F78 File Offset: 0x009A0178
		public bool DataWideGeneralBTDUNPeerIPAddress_A41123_Editable
		{
			get
			{
				short num = (short)760104725;
				short num2 = num;
				num = (short)543049493;
				switch (num2 == num)
				{
				}
				num = (short)548208641;
				if (num != 0)
				{
				}
				num = (short)1481768960;
				short num3 = num;
				num = (short)1989935104;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.Editable;
			}
			set
			{
				short num = (short)77988712;
				short num2 = num;
				num = (short)1298596712;
				switch (num2 == num)
				{
				}
				num = (short)1890779137;
				if (num != 0)
				{
				}
				num = (short)217841664;
				short num3 = num;
				num = (short)21233664;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.Editable = value;
			}
		}

		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x0600A539 RID: 42297 RVA: 0x009A2034 File Offset: 0x009A0234
		internal string DataWideGeneralBTDUNPeerIPAddress_A41123_UILabel
		{
			get
			{
				short num = (short)909442381;
				short num2 = num;
				num = (short)1692400973;
				switch (num2 == num)
				{
				}
				num = (short)200212481;
				if (num != 0)
				{
				}
				num = (short)666566656;
				short num3 = num;
				num = (short)1563623424;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.UIName;
			}
		}

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x009A20E8 File Offset: 0x009A02E8
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x009A21A0 File Offset: 0x009A03A0
		internal bool DataWideGeneralBTDUNPeerIPAddress_A41123_HiddenStatic
		{
			get
			{
				short num = (short)623924999;
				short num2 = num;
				num = (short)277698311;
				switch (num2 == num)
				{
				}
				num = (short)2060320769;
				if (num != 0)
				{
				}
				num = (short)1133903872;
				short num3 = num;
				num = (short)647233536;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.HiddenStatic;
			}
			set
			{
				short num = (short)1692930246;
				short num2 = num;
				num = (short)1881149638;
				switch (num2 == num)
				{
				}
				num = (short)209911808;
				if (num != 0)
				{
				}
				num = (short)1211498496;
				short num3 = num;
				num = (short)532742145;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.HiddenStatic = value;
			}
		}

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x0600A53C RID: 42300 RVA: 0x009A2254 File Offset: 0x009A0454
		// (set) Token: 0x0600A53D RID: 42301 RVA: 0x009A230C File Offset: 0x009A050C
		internal bool DataWideGeneralBTDUNPeerIPAddress_A41123_HiddenDynamic
		{
			get
			{
				short num = (short)1055064065;
				if (num != 0)
				{
				}
				num = (short)2026274787;
				short num2 = num;
				num = (short)2078113763;
				switch (num2 == num)
				{
				}
				num = (short)43909120;
				short num3 = num;
				num = (short)1328087040;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123.HiddenDynamic;
			}
			set
			{
				short num = (short)821454278;
				short num2 = num;
				num = (short)1234986438;
				switch (num2 == num)
				{
				}
				num = (short)1427439617;
				if (num != 0)
				{
				}
				num = (short)1174142976;
				short num3 = num;
				num = (short)581238784;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddress_A41123.HiddenDynamic = value;
			}
		}

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x0600A53E RID: 42302 RVA: 0x009A23C0 File Offset: 0x009A05C0
		public bool DataWideGeneralBTDUNPeerIPAddress_A41123_HasDiffs
		{
			get
			{
				short num = (short)464395950;
				short num2 = num;
				num = (short)577445550;
				switch (num2 == num)
				{
				}
				num = (short)828571649;
				if (num != 0)
				{
				}
				num = (short)1160839168;
				short num3 = num;
				num = (short)1324548096;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddress_A41123._HasDiffs;
			}
		}

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x0600A53F RID: 42303 RVA: 0x009A2474 File Offset: 0x009A0674
		// (set) Token: 0x0600A540 RID: 42304 RVA: 0x009A252C File Offset: 0x009A072C
		public int DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124Value
		{
			get
			{
				short num = (short)1645024619;
				short num2 = num;
				num = (short)1880036715;
				switch (num2 == num)
				{
				}
				num = (short)1759576064;
				if (num != 0)
				{
				}
				num = (short)1151729664;
				short num3 = num;
				num = (short)1313734657;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value;
			}
			set
			{
				short num = (short)1486502094;
				short num2 = num;
				num = (short)1179072718;
				switch (num2 == num)
				{
				}
				num = (short)1426849793;
				if (num != 0)
				{
				}
				num = (short)1072955392;
				short num3 = num;
				num = (short)476315648;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value = value;
			}
		}

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x0600A541 RID: 42305 RVA: 0x009A25DC File Offset: 0x009A07DC
		// (set) Token: 0x0600A542 RID: 42306 RVA: 0x009A2694 File Offset: 0x009A0894
		public string DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_UIValue
		{
			get
			{
				short num = (short)1047184259;
				short num2 = num;
				num = (short)1402192771;
				switch (num2 == num)
				{
				}
				num = (short)888602625;
				if (num != 0)
				{
				}
				num = (short)658571264;
				short num3 = num;
				num = (short)1743978496;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.UIValue;
			}
			set
			{
				short num = (short)687669248;
				short num2 = num;
				num = (short)57157993;
				short num3 = num;
				num = (short)1151084905;
				switch (num3 == num)
				{
				}
				num = (short)143851520;
				if (num != 0)
				{
				}
				num = (short)1739980801;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.UIValue = value;
			}
		}

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x0600A543 RID: 42307 RVA: 0x009A274C File Offset: 0x009A094C
		public global::AcpBusinessLayer.AcpListField DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124
		{
			get
			{
				short num = (short)794034176;
				short num2 = num;
				num = (short)1159304899;
				short num3 = num;
				num = (short)908564163;
				switch (num3 == num)
				{
				}
				num = (short)1369767937;
				if (num != 0)
				{
				}
				num = (short)1687683072;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;
			}
		}

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x009A27F8 File Offset: 0x009A09F8
		// (set) Token: 0x0600A545 RID: 42309 RVA: 0x009A28AC File Offset: 0x009A0AAC
		public bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_Applicable
		{
			get
			{
				short num = (short)515244032;
				short num2 = num;
				num = (short)2019819521;
				if (num != 0)
				{
				}
				num = (short)1806774042;
				short num3 = num;
				num = (short)119222042;
				switch (num3 == num)
				{
				}
				num = (short)2128084992;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Applicable;
			}
			set
			{
				short num = (short)837287936;
				short num2 = num;
				num = (short)1050690432;
				short num3 = num;
				num = (short)1775715200;
				switch (num3 == num)
				{
				}
				num = (short)954466304;
				if (num != 0)
				{
				}
				num = (short)1439563777;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Applicable = value;
			}
		}

		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x009A2960 File Offset: 0x009A0B60
		// (set) Token: 0x0600A547 RID: 42311 RVA: 0x009A2A18 File Offset: 0x009A0C18
		public bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_Valid
		{
			get
			{
				short num = (short)2102460416;
				short num2 = num;
				num = (short)430854593;
				short num3 = num;
				num = (short)974475713;
				switch (num3 == num)
				{
				}
				num = (short)2019295233;
				if (num != 0)
				{
				}
				num = (short)213843968;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Valid;
			}
			set
			{
				short num = (short)857079808;
				short num2 = num;
				num = (short)1587795201;
				short num3 = num;
				num = (short)1428870401;
				switch (num3 == num)
				{
				}
				num = (short)393674753;
				if (num != 0)
				{
				}
				num = (short)294584320;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Valid = value;
			}
		}

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x009A2AD0 File Offset: 0x009A0CD0
		// (set) Token: 0x0600A549 RID: 42313 RVA: 0x009A2B88 File Offset: 0x009A0D88
		public bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_Visible
		{
			get
			{
				short num = (short)702873600;
				short num2 = num;
				num = (short)439821990;
				short num3 = num;
				num = (short)75114150;
				switch (num3 == num)
				{
				}
				num = (short)1128988673;
				if (num != 0)
				{
				}
				num = (short)244645888;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Visible;
			}
			set
			{
				short num = (short)1857552384;
				short num2 = num;
				num = (short)57630493;
				short num3 = num;
				num = (short)518283037;
				switch (num3 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)449445888;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Visible = value;
			}
		}

		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x009A2C3C File Offset: 0x009A0E3C
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x009A2CF0 File Offset: 0x009A0EF0
		public bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_Editable
		{
			get
			{
				short num = (short)1875836928;
				short num2 = num;
				num = (short)135519580;
				short num3 = num;
				num = (short)947248476;
				switch (num3 == num)
				{
				}
				num = (short)549912577;
				if (num != 0)
				{
				}
				num = (short)1354039296;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Editable;
			}
			set
			{
				short num = (short)1814364160;
				short num2 = num;
				num = (short)706778909;
				short num3 = num;
				num = (short)447584029;
				switch (num3 == num)
				{
				}
				num = (short)1058209793;
				if (num != 0)
				{
				}
				num = (short)1153105920;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Editable = value;
			}
		}

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x009A2DA4 File Offset: 0x009A0FA4
		internal string DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_UILabel
		{
			get
			{
				short num = (short)526581760;
				short num2 = num;
				num = (short)1958468414;
				short num3 = num;
				num = (short)152951614;
				switch (num3 == num)
				{
				}
				num = (short)1773142016;
				if (num != 0)
				{
				}
				num = (short)1576206337;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.UIName;
			}
		}

		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x0600A54D RID: 42317 RVA: 0x009A2E5C File Offset: 0x009A105C
		// (set) Token: 0x0600A54E RID: 42318 RVA: 0x009A2F10 File Offset: 0x009A1110
		internal bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_HiddenStatic
		{
			get
			{
				short num = (short)1095368704;
				short num2 = num;
				num = (short)1633691326;
				short num3 = num;
				num = (short)833889982;
				switch (num3 == num)
				{
				}
				num = (short)907804673;
				if (num != 0)
				{
				}
				num = (short)1614348288;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.HiddenStatic;
			}
			set
			{
				short num = (short)1705443328;
				short num2 = num;
				num = (short)343490659;
				short num3 = num;
				num = (short)1648771171;
				switch (num3 == num)
				{
				}
				num = (short)1550188545;
				if (num != 0)
				{
				}
				num = (short)1089863680;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.HiddenStatic = value;
			}
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x0600A54F RID: 42319 RVA: 0x009A2FC8 File Offset: 0x009A11C8
		// (set) Token: 0x0600A550 RID: 42320 RVA: 0x009A307C File Offset: 0x009A127C
		internal bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_HiddenDynamic
		{
			get
			{
				short num = (short)2076639232;
				short num2 = num;
				num = (short)656749215;
				short num3 = num;
				num = (short)436220575;
				switch (num3 == num)
				{
				}
				num = (short)801898497;
				if (num != 0)
				{
				}
				num = (short)1402535936;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.HiddenDynamic;
			}
			set
			{
				short num = (short)1264517120;
				short num2 = num;
				num = (short)846332289;
				short num3 = num;
				num = (short)1836908929;
				switch (num3 == num)
				{
				}
				num = (short)7012353;
				if (num != 0)
				{
				}
				num = (short)470876160;
				if (num != 0)
				{
				}
				this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.HiddenDynamic = value;
			}
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x0600A551 RID: 42321 RVA: 0x009A3134 File Offset: 0x009A1334
		public bool DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124_HasDiffs
		{
			get
			{
				short num = (short)324599808;
				short num2 = num;
				num = (short)920221709;
				short num3 = num;
				num = (short)1102805005;
				switch (num3 == num)
				{
				}
				num = (short)1560215552;
				if (num != 0)
				{
				}
				num = (short)1625620481;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124._HasDiffs;
			}
		}

		// Token: 0x170052E4 RID: 21220
		// (get) Token: 0x0600A552 RID: 42322 RVA: 0x009A31E8 File Offset: 0x009A13E8
		// (set) Token: 0x0600A553 RID: 42323 RVA: 0x009A329C File Offset: 0x009A149C
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308Value
		{
			get
			{
				short num = (short)2116222976;
				short num2 = num;
				num = (short)1020283223;
				short num3 = num;
				num = (short)1358514519;
				switch (num3 == num)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				num = (short)1144193025;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Value;
			}
			set
			{
				short num = (short)1211367424;
				short num2 = num;
				num = (short)1865939402;
				short num3 = num;
				num = (short)767031754;
				switch (num3 == num)
				{
				}
				num = (short)292683777;
				if (num != 0)
				{
				}
				num = (short)1884225536;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Value = value;
			}
		}

		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x0600A554 RID: 42324 RVA: 0x009A334C File Offset: 0x009A154C
		public global::AcpBusinessLayer.AcpField<bool> DataWideGeneralDeleteMessagesOnSessionEnd_41308
		{
			get
			{
				short num = (short)1800667136;
				short num2 = num;
				num = (short)1842010974;
				short num3 = num;
				num = (short)1362287454;
				switch (num3 == num)
				{
				}
				num = (short)1947664385;
				if (num != 0)
				{
				}
				num = (short)1826029568;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308;
			}
		}

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x0600A555 RID: 42325 RVA: 0x009A33FC File Offset: 0x009A15FC
		// (set) Token: 0x0600A556 RID: 42326 RVA: 0x009A34B0 File Offset: 0x009A16B0
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_UIValue
		{
			get
			{
				short num = (short)147914752;
				short num2 = num;
				num = (short)2117891074;
				short num3 = num;
				num = (short)672035842;
				switch (num3 == num)
				{
				}
				num = (short)2080112640;
				if (num != 0)
				{
				}
				num = (short)1411383297;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Value;
			}
			set
			{
				short num = (short)589168640;
				short num2 = num;
				num = (short)825748435;
				short num3 = num;
				num = (short)1121315795;
				switch (num3 == num)
				{
				}
				num = (short)83492864;
				if (num != 0)
				{
				}
				num = (short)1170538497;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Value = value;
			}
		}

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x009A3568 File Offset: 0x009A1768
		// (set) Token: 0x0600A558 RID: 42328 RVA: 0x009A3620 File Offset: 0x009A1820
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_Applicable
		{
			get
			{
				short num = (short)270204928;
				short num2 = num;
				num = (short)1419150126;
				short num3 = num;
				num = (short)726500142;
				switch (num3 == num)
				{
				}
				num = (short)336527361;
				if (num != 0)
				{
				}
				num = (short)2119827456;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Applicable;
			}
			set
			{
				short num = (short)1611005952;
				short num2 = num;
				num = (short)1259136124;
				short num3 = num;
				num = (short)738059388;
				switch (num3 == num)
				{
				}
				num = (short)1236926464;
				if (num != 0)
				{
				}
				num = (short)1612054529;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Applicable = value;
			}
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x009A36D4 File Offset: 0x009A18D4
		// (set) Token: 0x0600A55A RID: 42330 RVA: 0x009A3788 File Offset: 0x009A1988
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_Valid
		{
			get
			{
				short num = (short)434896896;
				short num2 = num;
				num = (short)422977451;
				short num3 = num;
				num = (short)1002315691;
				switch (num3 == num)
				{
				}
				num = (short)1408761857;
				if (num != 0)
				{
				}
				num = (short)1849229312;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Valid;
			}
			set
			{
				short num = (short)65601536;
				short num2 = num;
				num = (short)847142563;
				short num3 = num;
				num = (short)1829723811;
				switch (num3 == num)
				{
				}
				num = (short)952958977;
				if (num != 0)
				{
				}
				num = (short)1879965696;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Valid = value;
			}
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x0600A55B RID: 42331 RVA: 0x009A383C File Offset: 0x009A1A3C
		// (set) Token: 0x0600A55C RID: 42332 RVA: 0x009A38F0 File Offset: 0x009A1AF0
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_Visible
		{
			get
			{
				short num = (short)999751680;
				short num2 = num;
				num = (short)416874497;
				if (num != 0)
				{
				}
				num = (short)150229486;
				short num3 = num;
				num = (short)1207521774;
				switch (num3 == num)
				{
				}
				num = (short)6094848;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Visible;
			}
			set
			{
				short num = (short)395706368;
				short num2 = num;
				num = (short)389211559;
				short num3 = num;
				num = (short)28173735;
				switch (num3 == num)
				{
				}
				num = (short)1016659969;
				if (num != 0)
				{
				}
				num = (short)1721958400;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Visible = value;
			}
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x009A39A8 File Offset: 0x009A1BA8
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x009A3A5C File Offset: 0x009A1C5C
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_Editable
		{
			get
			{
				short num = (short)111542272;
				short num2 = num;
				num = (short)992014194;
				short num3 = num;
				num = (short)137883506;
				switch (num3 == num)
				{
				}
				num = (short)1272971264;
				if (num != 0)
				{
				}
				num = (short)1279000577;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Editable;
			}
			set
			{
				short num = (short)1344733184;
				short num2 = num;
				num = (short)2135315297;
				short num3 = num;
				num = (short)250958689;
				switch (num3 == num)
				{
				}
				num = (short)458817537;
				if (num != 0)
				{
				}
				num = (short)2046820352;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.Editable = value;
			}
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x009A3B10 File Offset: 0x009A1D10
		internal string DataWideGeneralDeleteMessagesOnSessionEnd_41308_UILabel
		{
			get
			{
				short num = (short)1446313984;
				short num2 = num;
				num = (short)169657124;
				short num3 = num;
				num = (short)1599980324;
				switch (num3 == num)
				{
				}
				num = (short)297533441;
				if (num != 0)
				{
				}
				num = (short)1445658624;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.UIName;
			}
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x009A3BC8 File Offset: 0x009A1DC8
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x009A3C80 File Offset: 0x009A1E80
		internal bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_HiddenStatic
		{
			get
			{
				short num = (short)2123563008;
				short num2 = num;
				num = (short)254277598;
				short num3 = num;
				num = (short)1932261342;
				switch (num3 == num)
				{
				}
				num = (short)564068353;
				if (num != 0)
				{
				}
				num = (short)882835456;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.HiddenStatic;
			}
			set
			{
				short num = (short)1689649152;
				short num2 = num;
				num = (short)1339637282;
				short num3 = num;
				num = (short)1620459042;
				switch (num3 == num)
				{
				}
				num = (short)516292609;
				if (num != 0)
				{
				}
				num = (short)821297152;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.HiddenStatic = value;
			}
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x009A3D34 File Offset: 0x009A1F34
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x009A3DEC File Offset: 0x009A1FEC
		internal bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_HiddenDynamic
		{
			get
			{
				short num = (short)833028096;
				short num2 = num;
				num = (short)626802616;
				short num3 = num;
				num = (short)26034104;
				switch (num3 == num)
				{
				}
				num = (short)287834113;
				if (num != 0)
				{
				}
				num = (short)2015035392;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.HiddenDynamic;
			}
			set
			{
				short num = (short)1593835520;
				short num2 = num;
				num = (short)1908473857;
				if (num != 0)
				{
				}
				num = (short)1475274327;
				short num3 = num;
				num = (short)1491854935;
				switch (num3 == num)
				{
				}
				num = (short)1053818880;
				if (num != 0)
				{
				}
				this.dataWideGeneralDeleteMessagesOnSessionEnd_41308.HiddenDynamic = value;
			}
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x009A3EA0 File Offset: 0x009A20A0
		public bool DataWideGeneralDeleteMessagesOnSessionEnd_41308_HasDiffs
		{
			get
			{
				short num = (short)981008384;
				short num2 = num;
				num = (short)1155393188;
				short num3 = num;
				num = (short)1998251684;
				switch (num3 == num)
				{
				}
				num = (short)1993408512;
				if (num != 0)
				{
				}
				num = (short)2086666241;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDeleteMessagesOnSessionEnd_41308._HasDiffs;
			}
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x0600A565 RID: 42341 RVA: 0x009A3F54 File Offset: 0x009A2154
		// (set) Token: 0x0600A566 RID: 42342 RVA: 0x009A4008 File Offset: 0x009A2208
		public long DataWideGeneralDVRIPAddress_A41818Value
		{
			get
			{
				short num = (short)1938882560;
				short num2 = num;
				num = (short)1535671426;
				short num3 = num;
				num = (short)1014660226;
				switch (num3 == num)
				{
				}
				num = (short)1094189056;
				if (num != 0)
				{
				}
				num = (short)1577189377;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.Value;
			}
			set
			{
				short num = (short)1061945344;
				short num2 = num;
				num = (short)47667320;
				short num3 = num;
				num = (short)330455160;
				switch (num3 == num)
				{
				}
				num = (short)375848961;
				if (num != 0)
				{
				}
				num = (short)943128576;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.Value = value;
			}
		}

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x009A40BC File Offset: 0x009A22BC
		// (set) Token: 0x0600A568 RID: 42344 RVA: 0x009A4170 File Offset: 0x009A2370
		public string DataWideGeneralDVRIPAddress_A41818_UIValue
		{
			get
			{
				short num = (short)797179904;
				short num2 = num;
				num = (short)342651762;
				short num3 = num;
				num = (short)810906482;
				switch (num3 == num)
				{
				}
				num = (short)375521281;
				if (num != 0)
				{
				}
				num = (short)1867513856;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.UIValue;
			}
			set
			{
				short num = (short)598278144;
				short num2 = num;
				num = (short)675671250;
				short num3 = num;
				num = (short)996011218;
				switch (num3 == num)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				num = (short)2143748097;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.UIValue = value;
			}
		}

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x0600A569 RID: 42345 RVA: 0x009A4228 File Offset: 0x009A2428
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralDVRIPAddress_A41818
		{
			get
			{
				short num = (short)656801792;
				short num2 = num;
				num = (short)2053602293;
				short num3 = num;
				num = (short)1275952117;
				switch (num3 == num)
				{
				}
				num = (short)1150222336;
				if (num != 0)
				{
				}
				num = (short)1516961793;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818;
			}
		}

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x0600A56A RID: 42346 RVA: 0x009A42D8 File Offset: 0x009A24D8
		// (set) Token: 0x0600A56B RID: 42347 RVA: 0x009A438C File Offset: 0x009A258C
		public bool DataWideGeneralDVRIPAddress_A41818_Applicable
		{
			get
			{
				short num = (short)168099840;
				short num2 = num;
				num = (short)735800025;
				short num3 = num;
				num = (short)425355993;
				switch (num3 == num)
				{
				}
				num = (short)541261824;
				if (num != 0)
				{
				}
				num = (short)822214657;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.Applicable;
			}
			set
			{
				short num = (short)444203008;
				short num2 = num;
				num = (short)2101903311;
				short num3 = num;
				num = (short)1611562959;
				switch (num3 == num)
				{
				}
				num = (short)1960771585;
				if (num != 0)
				{
				}
				num = (short)1407320064;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.Applicable = value;
			}
		}

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x009A4440 File Offset: 0x009A2640
		// (set) Token: 0x0600A56D RID: 42349 RVA: 0x009A44F8 File Offset: 0x009A26F8
		public bool DataWideGeneralDVRIPAddress_A41818_Valid
		{
			get
			{
				short num = (short)1947140096;
				short num2 = num;
				num = (short)1329550857;
				short num3 = num;
				num = (short)564155913;
				switch (num3 == num)
				{
				}
				num = (short)1928658944;
				if (num != 0)
				{
				}
				num = (short)383123457;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.Valid;
			}
			set
			{
				short num = (short)680001536;
				short num2 = num;
				num = (short)2096323733;
				short num3 = num;
				num = (short)1670798485;
				switch (num3 == num)
				{
				}
				num = (short)343867393;
				if (num != 0)
				{
				}
				num = (short)80216064;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.Valid = value;
			}
		}

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x009A45B0 File Offset: 0x009A27B0
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x009A4664 File Offset: 0x009A2864
		public bool DataWideGeneralDVRIPAddress_A41818_Visible
		{
			get
			{
				short num = (short)1049821184;
				short num2 = num;
				num = (short)446852055;
				short num3 = num;
				num = (short)669674455;
				switch (num3 == num)
				{
				}
				num = (short)1340014593;
				if (num != 0)
				{
				}
				num = (short)1085734912;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.Visible;
			}
			set
			{
				short num = (short)1718616064;
				short num2 = num;
				num = (short)71041025;
				if (num != 0)
				{
				}
				num = (short)1137826985;
				short num3 = num;
				num = (short)1942805673;
				switch (num3 == num)
				{
				}
				num = (short)1746010112;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.Visible = value;
			}
		}

		// Token: 0x170052F5 RID: 21237
		// (get) Token: 0x0600A570 RID: 42352 RVA: 0x009A471C File Offset: 0x009A291C
		// (set) Token: 0x0600A571 RID: 42353 RVA: 0x009A47D0 File Offset: 0x009A29D0
		public bool DataWideGeneralDVRIPAddress_A41818_Editable
		{
			get
			{
				short num = (short)253558784;
				short num2 = num;
				num = (short)1974385897;
				short num3 = num;
				num = (short)1077722345;
				switch (num3 == num)
				{
				}
				num = (short)1539112960;
				if (num != 0)
				{
				}
				num = (short)940638209;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.Editable;
			}
			set
			{
				short num = (short)251461632;
				short num2 = num;
				num = (short)758326375;
				short num3 = num;
				num = (short)2047026279;
				switch (num3 == num)
				{
				}
				num = (short)434634753;
				if (num != 0)
				{
				}
				num = (short)977010688;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.Editable = value;
			}
		}

		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x0600A572 RID: 42354 RVA: 0x009A4884 File Offset: 0x009A2A84
		internal string DataWideGeneralDVRIPAddress_A41818_UILabel
		{
			get
			{
				short num = (short)651755520;
				short num2 = num;
				num = (short)1167920964;
				short num3 = num;
				num = (short)504827716;
				switch (num3 == num)
				{
				}
				num = (short)1408958465;
				if (num != 0)
				{
				}
				num = (short)1527250944;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.UIName;
			}
		}

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x0600A573 RID: 42355 RVA: 0x009A4938 File Offset: 0x009A2B38
		// (set) Token: 0x0600A574 RID: 42356 RVA: 0x009A49F0 File Offset: 0x009A2BF0
		internal bool DataWideGeneralDVRIPAddress_A41818_HiddenStatic
		{
			get
			{
				short num = (short)1952907264;
				short num2 = num;
				num = (short)1435699157;
				short num3 = num;
				num = (short)927533013;
				switch (num3 == num)
				{
				}
				num = (short)1375731713;
				if (num != 0)
				{
				}
				num = (short)596574208;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.HiddenStatic;
			}
			set
			{
				short num = (short)1672027247;
				short num2 = num;
				num = (short)1547639919;
				switch (num2 == num)
				{
				}
				num = (short)1603928065;
				if (num != 0)
				{
				}
				num = (short)1113522176;
				short num3 = num;
				num = (short)1633419264;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.HiddenStatic = value;
			}
		}

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x009A4AA4 File Offset: 0x009A2CA4
		// (set) Token: 0x0600A576 RID: 42358 RVA: 0x009A4B5C File Offset: 0x009A2D5C
		internal bool DataWideGeneralDVRIPAddress_A41818_HiddenDynamic
		{
			get
			{
				short num = (short)123413731;
				short num2 = num;
				num = (short)2053252323;
				switch (num2 == num)
				{
				}
				num = (short)690487296;
				if (num != 0)
				{
				}
				num = (short)1948188672;
				short num3 = num;
				num = (short)1033961473;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818.HiddenDynamic;
			}
			set
			{
				short num = (short)2091122689;
				if (num != 0)
				{
				}
				num = (short)318454284;
				short num2 = num;
				num = (short)1068055052;
				switch (num2 == num)
				{
				}
				num = (short)2082013184;
				short num3 = num;
				num = (short)917831680;
				if (num != 0)
				{
				}
				this.dataWideGeneralDVRIPAddress_A41818.HiddenDynamic = value;
			}
		}

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x009A4C10 File Offset: 0x009A2E10
		public bool DataWideGeneralDVRIPAddress_A41818_HasDiffs
		{
			get
			{
				short num = (short)1308411084;
				short num2 = num;
				num = (short)2105918668;
				switch (num2 == num)
				{
				}
				num = (short)1404960769;
				if (num != 0)
				{
				}
				num = (short)1261043712;
				short num3 = num;
				num = (short)1016987648;
				if (num != 0)
				{
				}
				return this.dataWideGeneralDVRIPAddress_A41818._HasDiffs;
			}
		}

		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x0600A578 RID: 42360 RVA: 0x009A4CC4 File Offset: 0x009A2EC4
		// (set) Token: 0x0600A579 RID: 42361 RVA: 0x009A4D7C File Offset: 0x009A2F7C
		public long DataWideGeneralMobileSubIPAddress_A41819Value
		{
			get
			{
				short num = (short)1366415280;
				short num2 = num;
				num = (short)614258608;
				switch (num2 == num)
				{
				}
				num = (short)649854977;
				if (num != 0)
				{
				}
				num = (short)1725497344;
				short num3 = num;
				num = (short)1898512384;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.Value;
			}
			set
			{
				short num = (short)1923130938;
				short num2 = num;
				num = (short)1848813114;
				switch (num2 == num)
				{
				}
				num = (short)1417281537;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				short num3 = num;
				num = (short)1098973184;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.Value = value;
			}
		}

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x009A4E34 File Offset: 0x009A3034
		// (set) Token: 0x0600A57B RID: 42363 RVA: 0x009A4EEC File Offset: 0x009A30EC
		public string DataWideGeneralMobileSubIPAddress_A41819_UIValue
		{
			get
			{
				short num = (short)842576455;
				short num2 = num;
				num = (short)1093186119;
				switch (num2 == num)
				{
				}
				num = (short)187760641;
				if (num != 0)
				{
				}
				num = (short)177012736;
				short num3 = num;
				num = (short)1126105088;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.UIValue;
			}
			set
			{
				short num = (short)912396143;
				short num2 = num;
				num = (short)720899951;
				switch (num2 == num)
				{
				}
				num = (short)610795520;
				if (num != 0)
				{
				}
				num = (short)1990656000;
				short num3 = num;
				num = (short)133562369;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.UIValue = value;
			}
		}

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x0600A57C RID: 42364 RVA: 0x009A4FA0 File Offset: 0x009A31A0
		public global::AcpBusinessLayer.AcpIPAddressField DataWideGeneralMobileSubIPAddress_A41819
		{
			get
			{
				short num = (short)1095165149;
				short num2 = num;
				num = (short)662496477;
				switch (num2 == num)
				{
				}
				num = (short)1075052545;
				if (num != 0)
				{
				}
				num = (short)1926823936;
				short num3 = num;
				num = (short)1164115968;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819;
			}
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x0600A57D RID: 42365 RVA: 0x009A5050 File Offset: 0x009A3250
		// (set) Token: 0x0600A57E RID: 42366 RVA: 0x009A5104 File Offset: 0x009A3304
		public bool DataWideGeneralMobileSubIPAddress_A41819_Applicable
		{
			get
			{
				short num = (short)869793746;
				short num2 = num;
				num = (short)212795346;
				switch (num2 == num)
				{
				}
				num = (short)1382744065;
				if (num != 0)
				{
				}
				num = (short)472514560;
				short num3 = num;
				num = (short)428408832;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.Applicable;
			}
			set
			{
				short num = (short)1404432217;
				short num2 = num;
				num = (short)122679129;
				switch (num2 == num)
				{
				}
				num = (short)1716191233;
				if (num != 0)
				{
				}
				num = (short)645660672;
				short num3 = num;
				num = (short)1554382848;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.Applicable = value;
			}
		}

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x0600A57F RID: 42367 RVA: 0x009A51B4 File Offset: 0x009A33B4
		// (set) Token: 0x0600A580 RID: 42368 RVA: 0x009A5268 File Offset: 0x009A3468
		public bool DataWideGeneralMobileSubIPAddress_A41819_Valid
		{
			get
			{
				short num = (short)503265075;
				short num2 = num;
				num = (short)1265710899;
				switch (num2 == num)
				{
				}
				num = (short)567410689;
				if (num != 0)
				{
				}
				num = (short)183042048;
				short num3 = num;
				num = (short)697892864;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.Valid;
			}
			set
			{
				short num = (short)1318518785;
				if (num != 0)
				{
				}
				num = (short)2116094907;
				short num2 = num;
				num = (short)1649085371;
				switch (num2 == num)
				{
				}
				num = (short)1151401984;
				short num3 = num;
				num = (short)725090304;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.Valid = value;
			}
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x009A531C File Offset: 0x009A351C
		// (set) Token: 0x0600A582 RID: 42370 RVA: 0x009A53D0 File Offset: 0x009A35D0
		public bool DataWideGeneralMobileSubIPAddress_A41819_Visible
		{
			get
			{
				short num = (short)1332877880;
				short num2 = num;
				num = (short)154868280;
				switch (num2 == num)
				{
				}
				num = (short)1869676545;
				if (num != 0)
				{
				}
				num = (short)206503936;
				short num3 = num;
				num = (short)1130954752;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.Visible;
			}
			set
			{
				short num = (short)1417125695;
				short num2 = num;
				num = (short)379297599;
				switch (num2 == num)
				{
				}
				num = (short)467206144;
				if (num != 0)
				{
				}
				num = (short)565051392;
				short num3 = num;
				num = (short)1143144449;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.Visible = value;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x0600A583 RID: 42371 RVA: 0x009A5484 File Offset: 0x009A3684
		// (set) Token: 0x0600A584 RID: 42372 RVA: 0x009A553C File Offset: 0x009A373C
		public bool DataWideGeneralMobileSubIPAddress_A41819_Editable
		{
			get
			{
				short num = (short)1038916892;
				short num2 = num;
				num = (short)1430363420;
				switch (num2 == num)
				{
				}
				num = (short)1231945729;
				if (num != 0)
				{
				}
				num = (short)1571880960;
				short num3 = num;
				num = (short)229310464;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.Editable;
			}
			set
			{
				short num = (short)253093637;
				short num2 = num;
				num = (short)275179269;
				switch (num2 == num)
				{
				}
				num = (short)152764416;
				if (num != 0)
				{
				}
				num = (short)1160577024;
				short num3 = num;
				num = (short)1833893889;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.Editable = value;
			}
		}

		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x0600A585 RID: 42373 RVA: 0x009A55F0 File Offset: 0x009A37F0
		internal string DataWideGeneralMobileSubIPAddress_A41819_UILabel
		{
			get
			{
				short num = (short)536041996;
				short num2 = num;
				num = (short)1151293964;
				switch (num2 == num)
				{
				}
				num = (short)550961153;
				if (num != 0)
				{
				}
				num = (short)1583742976;
				short num3 = num;
				num = (short)1040187392;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.UIName;
			}
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x0600A586 RID: 42374 RVA: 0x009A56A4 File Offset: 0x009A38A4
		// (set) Token: 0x0600A587 RID: 42375 RVA: 0x009A575C File Offset: 0x009A395C
		internal bool DataWideGeneralMobileSubIPAddress_A41819_HiddenStatic
		{
			get
			{
				short num = (short)679758843;
				short num2 = num;
				num = (short)2079935483;
				switch (num2 == num)
				{
				}
				num = (short)464781313;
				if (num != 0)
				{
				}
				num = (short)1257308160;
				short num3 = num;
				num = (short)223346688;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.HiddenStatic;
			}
			set
			{
				short num = (short)770147582;
				short num2 = num;
				num = (short)1300137214;
				switch (num2 == num)
				{
				}
				num = (short)227868672;
				if (num != 0)
				{
				}
				num = (short)1680801792;
				short num3 = num;
				num = (short)1972830209;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.HiddenStatic = value;
			}
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x0600A588 RID: 42376 RVA: 0x009A5814 File Offset: 0x009A3A14
		// (set) Token: 0x0600A589 RID: 42377 RVA: 0x009A58CC File Offset: 0x009A3ACC
		internal bool DataWideGeneralMobileSubIPAddress_A41819_HiddenDynamic
		{
			get
			{
				short num = (short)2035425172;
				short num2 = num;
				num = (short)1607016340;
				switch (num2 == num)
				{
				}
				num = (short)22544385;
				if (num != 0)
				{
				}
				num = (short)917372928;
				short num3 = num;
				num = (short)1827143680;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819.HiddenDynamic;
			}
			set
			{
				short num = (short)1840567781;
				short num2 = num;
				num = (short)583259621;
				switch (num2 == num)
				{
				}
				num = (short)1219887105;
				if (num != 0)
				{
				}
				num = (short)2087190528;
				short num3 = num;
				num = (short)1449590784;
				if (num != 0)
				{
				}
				this.dataWideGeneralMobileSubIPAddress_A41819.HiddenDynamic = value;
			}
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x009A5984 File Offset: 0x009A3B84
		public bool DataWideGeneralMobileSubIPAddress_A41819_HasDiffs
		{
			get
			{
				short num = (short)472911096;
				short num2 = num;
				num = (short)597888248;
				switch (num2 == num)
				{
				}
				num = (short)1496055808;
				if (num != 0)
				{
				}
				num = (short)607059968;
				short num3 = num;
				num = (short)1371275265;
				if (num != 0)
				{
				}
				return this.dataWideGeneralMobileSubIPAddress_A41819._HasDiffs;
			}
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x009A5A38 File Offset: 0x009A3C38
		// (set) Token: 0x0600A58C RID: 42380 RVA: 0x009A5AEC File Offset: 0x009A3CEC
		public long DataWideGeneralInternalRadioSubnet_A42073Value
		{
			get
			{
				short num = (short)1072783209;
				short num2 = num;
				num = (short)1837850473;
				switch (num2 == num)
				{
				}
				num = (short)724500480;
				if (num != 0)
				{
				}
				num = (short)687210496;
				short num3 = num;
				num = (short)248446977;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.Value;
			}
			set
			{
				short num = (short)666763265;
				if (num != 0)
				{
				}
				num = (short)1032915241;
				short num2 = num;
				num = (short)1596721449;
				switch (num2 == num)
				{
				}
				num = (short)1055195136;
				short num3 = num;
				num = (short)981925888;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.Value = value;
			}
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x009A5BA4 File Offset: 0x009A3DA4
		public global::AcpBusinessLayer.AcpFieldX<long, string> DataWideGeneralInternalRadioSubnet_A42073
		{
			get
			{
				short num = (short)1633643524;
				short num2 = num;
				num = (short)1508469764;
				switch (num2 == num)
				{
				}
				num = (short)1436483585;
				if (num != 0)
				{
				}
				num = (short)971243520;
				short num3 = num;
				num = (short)1756626944;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073;
			}
		}

		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x0600A58E RID: 42382 RVA: 0x009A5C58 File Offset: 0x009A3E58
		// (set) Token: 0x0600A58F RID: 42383 RVA: 0x009A5D0C File Offset: 0x009A3F0C
		public string DataWideGeneralInternalRadioSubnet_A42073_UIValue
		{
			get
			{
				short num = (short)664808741;
				short num2 = num;
				num = (short)1350577445;
				switch (num2 == num)
				{
				}
				num = (short)69074945;
				if (num != 0)
				{
				}
				num = (short)715128832;
				short num3 = num;
				num = (short)433520640;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.UIValue;
			}
			set
			{
				short num = (short)1711966182;
				short num2 = num;
				num = (short)1856473062;
				switch (num2 == num)
				{
				}
				num = (short)115015681;
				if (num != 0)
				{
				}
				num = (short)140705792;
				short num3 = num;
				num = (short)320339968;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.UIValue = value;
			}
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x0600A590 RID: 42384 RVA: 0x009A5DC0 File Offset: 0x009A3FC0
		// (set) Token: 0x0600A591 RID: 42385 RVA: 0x009A5E74 File Offset: 0x009A4074
		public bool DataWideGeneralInternalRadioSubnet_A42073_Applicable
		{
			get
			{
				short num = (short)932885459;
				short num2 = num;
				num = (short)1024242643;
				switch (num2 == num)
				{
				}
				num = (short)807403520;
				if (num != 0)
				{
				}
				num = (short)393871360;
				short num3 = num;
				num = (short)2114977793;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.Applicable;
			}
			set
			{
				short num = (short)1614643705;
				short num2 = num;
				num = (short)319062521;
				switch (num2 == num)
				{
				}
				num = (short)508035073;
				if (num != 0)
				{
				}
				num = (short)1920860160;
				short num3 = num;
				num = (short)2038759424;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.Applicable = value;
			}
		}

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x0600A592 RID: 42386 RVA: 0x009A5F30 File Offset: 0x009A4130
		// (set) Token: 0x0600A593 RID: 42387 RVA: 0x009A5FE4 File Offset: 0x009A41E4
		public bool DataWideGeneralInternalRadioSubnet_A42073_Valid
		{
			get
			{
				short num = (short)2136773892;
				short num2 = num;
				num = (short)1486263556;
				switch (num2 == num)
				{
				}
				num = (short)1744371713;
				if (num != 0)
				{
				}
				num = (short)507117568;
				short num3 = num;
				num = (short)624689152;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.Valid;
			}
			set
			{
				short num = (short)1070383424;
				short num2 = num;
				num = (short)1359266112;
				switch (num2 == num)
				{
				}
				num = (short)2007171072;
				if (num != 0)
				{
				}
				num = (short)960495616;
				short num3 = num;
				num = (short)225640449;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.Valid = value;
			}
		}

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x0600A594 RID: 42388 RVA: 0x009A6098 File Offset: 0x009A4298
		// (set) Token: 0x0600A595 RID: 42389 RVA: 0x009A614C File Offset: 0x009A434C
		public bool DataWideGeneralInternalRadioSubnet_A42073_Visible
		{
			get
			{
				short num = (short)854843438;
				short num2 = num;
				num = (short)525590574;
				switch (num2 == num)
				{
				}
				num = (short)1889927169;
				if (num != 0)
				{
				}
				num = (short)510787584;
				short num3 = num;
				num = (short)1262223360;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.Visible;
			}
			set
			{
				short num = (short)897993611;
				short num2 = num;
				num = (short)382487435;
				switch (num2 == num)
				{
				}
				num = (short)1694040065;
				if (num != 0)
				{
				}
				num = (short)635830272;
				short num3 = num;
				num = (short)533397504;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.Visible = value;
			}
		}

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x0600A596 RID: 42390 RVA: 0x009A6200 File Offset: 0x009A4400
		// (set) Token: 0x0600A597 RID: 42391 RVA: 0x009A62B4 File Offset: 0x009A44B4
		public bool DataWideGeneralInternalRadioSubnet_A42073_Editable
		{
			get
			{
				short num = (short)1840817845;
				short num2 = num;
				num = (short)698037;
				switch (num2 == num)
				{
				}
				num = (short)697565185;
				if (num != 0)
				{
				}
				num = (short)667615232;
				short num3 = num;
				num = (short)205651968;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.Editable;
			}
			set
			{
				short num = (short)888853242;
				short num2 = num;
				num = (short)761582330;
				switch (num2 == num)
				{
				}
				num = (short)295370753;
				if (num != 0)
				{
				}
				num = (short)1215299584;
				short num3 = num;
				num = (short)2036465664;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.Editable = value;
			}
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x0600A598 RID: 42392 RVA: 0x009A636C File Offset: 0x009A456C
		internal string DataWideGeneralInternalRadioSubnet_A42073_UILabel
		{
			get
			{
				short num = (short)1670710293;
				short num2 = num;
				num = (short)861406229;
				switch (num2 == num)
				{
				}
				num = (short)2063073281;
				if (num != 0)
				{
				}
				num = (short)1057161216;
				short num3 = num;
				num = (short)2018574336;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.UIName;
			}
		}

		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x009A6420 File Offset: 0x009A4620
		// (set) Token: 0x0600A59A RID: 42394 RVA: 0x009A64D4 File Offset: 0x009A46D4
		internal bool DataWideGeneralInternalRadioSubnet_A42073_HiddenStatic
		{
			get
			{
				short num = (short)1057619969;
				if (num != 0)
				{
				}
				num = (short)1997372140;
				short num2 = num;
				num = (short)1272347372;
				switch (num2 == num)
				{
				}
				num = (short)1929576448;
				short num3 = num;
				num = (short)2145714176;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.HiddenStatic;
			}
			set
			{
				short num = (short)341184167;
				short num2 = num;
				num = (short)435162791;
				switch (num2 == num)
				{
				}
				num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)1407320064;
				short num3 = num;
				num = (short)950992896;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.HiddenStatic = value;
			}
		}

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x0600A59B RID: 42395 RVA: 0x009A6588 File Offset: 0x009A4788
		// (set) Token: 0x0600A59C RID: 42396 RVA: 0x009A6638 File Offset: 0x009A4838
		internal bool DataWideGeneralInternalRadioSubnet_A42073_HiddenDynamic
		{
			get
			{
				short num = (short)1265057898;
				short num2 = num;
				num = (short)1766670442;
				switch (num2 == num)
				{
				}
				num = (short)267780097;
				if (num != 0)
				{
				}
				num = (short)693174272;
				short num3 = num;
				num = (short)1639448576;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073.HiddenDynamic;
			}
			set
			{
				short num = (short)1446038075;
				short num2 = num;
				num = (short)1743440443;
				switch (num2 == num)
				{
				}
				num = (short)1365639169;
				if (num != 0)
				{
				}
				num = (short)1450770432;
				short num3 = num;
				num = (short)259653632;
				if (num != 0)
				{
				}
				this.dataWideGeneralInternalRadioSubnet_A42073.HiddenDynamic = value;
			}
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x0600A59D RID: 42397 RVA: 0x009A66EC File Offset: 0x009A48EC
		public bool DataWideGeneralInternalRadioSubnet_A42073_HasDiffs
		{
			get
			{
				short num = (short)701712649;
				short num2 = num;
				num = (short)690571529;
				switch (num2 == num)
				{
				}
				num = (short)1690042369;
				if (num != 0)
				{
				}
				num = (short)753664000;
				short num3 = num;
				num = (short)1147273216;
				if (num != 0)
				{
				}
				return this.dataWideGeneralInternalRadioSubnet_A42073._HasDiffs;
			}
		}

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x0600A59E RID: 42398 RVA: 0x009A67A0 File Offset: 0x009A49A0
		// (set) Token: 0x0600A59F RID: 42399 RVA: 0x009A6854 File Offset: 0x009A4A54
		public int DataWideLTEAPCOAvalancheTime_A42204Value
		{
			get
			{
				short num = (short)305106580;
				short num2 = num;
				num = (short)824479380;
				switch (num2 == num)
				{
				}
				num = (short)1597964289;
				if (num != 0)
				{
				}
				num = (short)1869348864;
				short num3 = num;
				num = (short)231866368;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Value;
			}
			set
			{
				short num = (short)1958014207;
				short num2 = num;
				num = (short)1287515391;
				switch (num2 == num)
				{
				}
				num = (short)1660878849;
				if (num != 0)
				{
				}
				num = (short)1100087296;
				short num3 = num;
				num = (short)1777205248;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Value = value;
			}
		}

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x0600A5A0 RID: 42400 RVA: 0x009A690C File Offset: 0x009A4B0C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLTEAPCOAvalancheTime_A42204
		{
			get
			{
				short num = (short)220630171;
				short num2 = num;
				num = (short)1971031195;
				switch (num2 == num)
				{
				}
				num = (short)2038104065;
				if (num != 0)
				{
				}
				num = (short)1566048256;
				short num3 = num;
				num = (short)530776064;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204;
			}
		}

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x0600A5A1 RID: 42401 RVA: 0x009A69BC File Offset: 0x009A4BBC
		// (set) Token: 0x0600A5A2 RID: 42402 RVA: 0x009A6A70 File Offset: 0x009A4C70
		public string DataWideLTEAPCOAvalancheTime_A42204_UIValue
		{
			get
			{
				short num = (short)1700344741;
				short num2 = num;
				num = (short)827274149;
				switch (num2 == num)
				{
				}
				num = (short)1452605441;
				if (num != 0)
				{
				}
				num = (short)1974861824;
				short num3 = num;
				num = (short)751501312;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.UIValue;
			}
			set
			{
				short num = (short)790393875;
				short num2 = num;
				num = (short)655651859;
				switch (num2 == num)
				{
				}
				num = (short)1937702913;
				if (num != 0)
				{
				}
				num = (short)321388544;
				short num3 = num;
				num = (short)1721565184;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.UIValue = value;
			}
		}

		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x0600A5A3 RID: 42403 RVA: 0x009A6B28 File Offset: 0x009A4D28
		// (set) Token: 0x0600A5A4 RID: 42404 RVA: 0x009A6BDC File Offset: 0x009A4DDC
		internal int DataWideLTEAPCOAvalancheTime_A42204Min
		{
			get
			{
				short num = (short)2100050896;
				short num2 = num;
				num = (short)94649296;
				switch (num2 == num)
				{
				}
				num = (short)756350977;
				if (num != 0)
				{
				}
				num = (short)1531772928;
				short num3 = num;
				num = (short)651165696;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Min;
			}
			set
			{
				short num = (short)299023702;
				short num2 = num;
				num = (short)2117844310;
				switch (num2 == num)
				{
				}
				num = (short)1090715649;
				if (num != 0)
				{
				}
				num = (short)1333788672;
				short num3 = num;
				num = (short)651624448;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Min = value;
			}
		}

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x0600A5A5 RID: 42405 RVA: 0x009A6C90 File Offset: 0x009A4E90
		// (set) Token: 0x0600A5A6 RID: 42406 RVA: 0x009A6D40 File Offset: 0x009A4F40
		internal int DataWideLTEAPCOAvalancheTime_A42204Max
		{
			get
			{
				short num = (short)1626459835;
				short num2 = num;
				num = (short)1912393403;
				switch (num2 == num)
				{
				}
				num = (short)999948288;
				if (num != 0)
				{
				}
				num = (short)302120960;
				short num3 = num;
				num = (short)1220673537;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Max;
			}
			set
			{
				short num = (short)1023669668;
				short num2 = num;
				num = (short)1472001444;
				switch (num2 == num)
				{
				}
				num = (short)698613761;
				if (num != 0)
				{
				}
				num = (short)1887764480;
				short num3 = num;
				num = (short)2047082496;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Max = value;
			}
		}

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x0600A5A7 RID: 42407 RVA: 0x009A6DF4 File Offset: 0x009A4FF4
		// (set) Token: 0x0600A5A8 RID: 42408 RVA: 0x009A6EA8 File Offset: 0x009A50A8
		internal int DataWideLTEAPCOAvalancheTime_A42204Step
		{
			get
			{
				short num = (short)1449943773;
				short num2 = num;
				num = (short)707093213;
				switch (num2 == num)
				{
				}
				num = (short)432406529;
				if (num != 0)
				{
				}
				num = (short)499580928;
				short num3 = num;
				num = (short)1915617280;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.StepSize;
			}
			set
			{
				short num = (short)2145966188;
				short num2 = num;
				num = (short)1538054252;
				switch (num2 == num)
				{
				}
				num = (short)1507393536;
				if (num != 0)
				{
				}
				num = (short)244318208;
				short num3 = num;
				num = (short)1104543745;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.StepSize = value;
			}
		}

		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x009A6F60 File Offset: 0x009A5160
		// (set) Token: 0x0600A5AA RID: 42410 RVA: 0x009A7014 File Offset: 0x009A5214
		public bool DataWideLTEAPCOAvalancheTime_A42204_Applicable
		{
			get
			{
				short num = (short)2017430085;
				short num2 = num;
				num = (short)2079951429;
				switch (num2 == num)
				{
				}
				num = (short)1742274561;
				if (num != 0)
				{
				}
				num = (short)992346112;
				short num3 = num;
				num = (short)2107965440;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Applicable;
			}
			set
			{
				short num = (short)2067720257;
				short num2 = num;
				num = (short)607053889;
				switch (num2 == num)
				{
				}
				num = (short)508690432;
				if (num != 0)
				{
				}
				num = (short)347406336;
				short num3 = num;
				num = (short)1020788737;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Applicable = value;
			}
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x0600A5AB RID: 42411 RVA: 0x009A70CC File Offset: 0x009A52CC
		// (set) Token: 0x0600A5AC RID: 42412 RVA: 0x009A7180 File Offset: 0x009A5380
		public bool DataWideLTEAPCOAvalancheTime_A42204_Valid
		{
			get
			{
				short num = (short)1250444937;
				short num2 = num;
				num = (short)1519928969;
				switch (num2 == num)
				{
				}
				num = (short)142737409;
				if (num != 0)
				{
				}
				num = (short)275578880;
				short num3 = num;
				num = (short)1100349440;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Valid;
			}
			set
			{
				short num = (short)2058819562;
				short num2 = num;
				num = (short)1369446378;
				switch (num2 == num)
				{
				}
				num = (short)1961951232;
				if (num != 0)
				{
				}
				num = (short)1623523328;
				short num3 = num;
				num = (short)1870135297;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Valid = value;
			}
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x0600A5AD RID: 42413 RVA: 0x009A7234 File Offset: 0x009A5434
		// (set) Token: 0x0600A5AE RID: 42414 RVA: 0x009A72EC File Offset: 0x009A54EC
		public bool DataWideLTEAPCOAvalancheTime_A42204_Visible
		{
			get
			{
				short num = (short)699006977;
				if (num != 0)
				{
				}
				num = (short)1914296995;
				short num2 = num;
				num = (short)1493162659;
				switch (num2 == num)
				{
				}
				num = (short)302383104;
				short num3 = num;
				num = (short)1100873728;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Visible;
			}
			set
			{
				short num = (short)320060323;
				short num2 = num;
				num = (short)501726115;
				switch (num2 == num)
				{
				}
				num = (short)598409217;
				if (num != 0)
				{
				}
				num = (short)1287847936;
				short num3 = num;
				num = (short)1924530176;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Visible = value;
			}
		}

		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x009A73A4 File Offset: 0x009A55A4
		// (set) Token: 0x0600A5B0 RID: 42416 RVA: 0x009A745C File Offset: 0x009A565C
		public bool DataWideLTEAPCOAvalancheTime_A42204_Editable
		{
			get
			{
				short num = (short)1110666155;
				short num2 = num;
				num = (short)853502891;
				switch (num2 == num)
				{
				}
				num = (short)1133248513;
				if (num != 0)
				{
				}
				num = (short)450953216;
				short num3 = num;
				num = (short)230293504;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.Editable;
			}
			set
			{
				short num = (short)1067022612;
				short num2 = num;
				num = (short)1755937044;
				switch (num2 == num)
				{
				}
				num = (short)1069678592;
				short num3 = num;
				num = (short)1929183232;
				if (num != 0)
				{
				}
				num = (short)425263105;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.Editable = value;
			}
		}

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x0600A5B1 RID: 42417 RVA: 0x009A7514 File Offset: 0x009A5714
		internal string DataWideLTEAPCOAvalancheTime_A42204_UILabel
		{
			get
			{
				short num = (short)277872641;
				if (num != 0)
				{
				}
				num = (short)922430049;
				short num2 = num;
				num = (short)963258977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016739328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264910336;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.UIName;
			}
		}

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x0600A5B2 RID: 42418 RVA: 0x009A75C8 File Offset: 0x009A57C8
		// (set) Token: 0x0600A5B3 RID: 42419 RVA: 0x009A7680 File Offset: 0x009A5880
		internal bool DataWideLTEAPCOAvalancheTime_A42204_HiddenStatic
		{
			get
			{
				short num = (short)1501233153;
				if (num != 0)
				{
				}
				num = (short)1264737179;
				short num2 = num;
				num = (short)1631214491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964048384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692991488;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.HiddenStatic;
			}
			set
			{
				short num = (short)1199006436;
				short num2 = num;
				num = (short)56845028;
				switch (num2 == num)
				{
				}
				num = (short)577830912;
				short num3 = num;
				num = (short)1823932416;
				if (num != 0)
				{
				}
				num = (short)1958215681;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.HiddenStatic = value;
			}
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x0600A5B4 RID: 42420 RVA: 0x009A7738 File Offset: 0x009A5938
		// (set) Token: 0x0600A5B5 RID: 42421 RVA: 0x009A77EC File Offset: 0x009A59EC
		internal bool DataWideLTEAPCOAvalancheTime_A42204_HiddenDynamic
		{
			get
			{
				short num = (short)849281025;
				if (num != 0)
				{
				}
				num = (short)1712155342;
				short num2 = num;
				num = (short)649030350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1267531776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1356333056;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204.HiddenDynamic;
			}
			set
			{
				short num = (short)1451634201;
				short num2 = num;
				num = (short)1545481753;
				switch (num2 == num)
				{
				}
				num = (short)1138688000;
				short num3 = num;
				num = (short)1647509505;
				if (num != 0)
				{
				}
				num = (short)1472856064;
				if (num != 0)
				{
				}
				this.dataWideLTEAPCOAvalancheTime_A42204.HiddenDynamic = value;
			}
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x009A78A0 File Offset: 0x009A5AA0
		public bool DataWideLTEAPCOAvalancheTime_A42204_HasDiffs
		{
			get
			{
				short num = (short)347428613;
				short num2 = num;
				num = (short)1189893893;
				switch (num2 == num)
				{
				}
				num = (short)1266417664;
				short num3 = num;
				num = (short)1918042112;
				if (num != 0)
				{
				}
				num = (short)1216217089;
				if (num != 0)
				{
				}
				return this.dataWideLTEAPCOAvalancheTime_A42204._HasDiffs;
			}
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x0600A5B7 RID: 42423 RVA: 0x009A795C File Offset: 0x009A5B5C
		// (set) Token: 0x0600A5B8 RID: 42424 RVA: 0x009A7A10 File Offset: 0x009A5C10
		public bool DirectTMSContentDisplay_42323Value
		{
			get
			{
				short num = (short)1482539055;
				short num2 = num;
				num = (short)226148399;
				switch (num2 == num)
				{
				}
				num = (short)616693760;
				short num3 = num;
				num = (short)2084372480;
				if (num != 0)
				{
				}
				num = (short)842006529;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Value;
			}
			set
			{
				short num = (short)1299477379;
				short num2 = num;
				num = (short)1950184323;
				switch (num2 == num)
				{
				}
				num = (short)1792081920;
				short num3 = num;
				num = (short)516947968;
				if (num != 0)
				{
				}
				num = (short)140247041;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Value = value;
			}
		}

		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x009A7AC4 File Offset: 0x009A5CC4
		public global::AcpBusinessLayer.AcpField<bool> DirectTMSContentDisplay_42323
		{
			get
			{
				short num = (short)1920584772;
				short num2 = num;
				num = (short)1700645956;
				switch (num2 == num)
				{
				}
				num = (short)885850112;
				short num3 = num;
				num = (short)1992032257;
				if (num != 0)
				{
				}
				num = (short)1512767488;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323;
			}
		}

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x0600A5BA RID: 42426 RVA: 0x009A7B74 File Offset: 0x009A5D74
		// (set) Token: 0x0600A5BB RID: 42427 RVA: 0x009A7C28 File Offset: 0x009A5E28
		public bool DirectTMSContentDisplay_42323_UIValue
		{
			get
			{
				short num = (short)1016043782;
				short num2 = num;
				num = (short)385390854;
				switch (num2 == num)
				{
				}
				num = (short)734527488;
				short num3 = num;
				num = (short)1180565505;
				if (num != 0)
				{
				}
				num = (short)1347485696;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Value;
			}
			set
			{
				short num = (short)673672217;
				short num2 = num;
				num = (short)1853451289;
				switch (num2 == num)
				{
				}
				num = (short)1964376064;
				short num3 = num;
				num = (short)1714028544;
				if (num != 0)
				{
				}
				num = (short)2122252289;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Value = value;
			}
		}

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x0600A5BC RID: 42428 RVA: 0x009A7CE0 File Offset: 0x009A5EE0
		// (set) Token: 0x0600A5BD RID: 42429 RVA: 0x009A7D94 File Offset: 0x009A5F94
		public bool DirectTMSContentDisplay_42323_Applicable
		{
			get
			{
				short num = (short)1111509860;
				short num2 = num;
				num = (short)521882468;
				switch (num2 == num)
				{
				}
				num = (short)1306787840;
				short num3 = num;
				num = (short)874184704;
				if (num != 0)
				{
				}
				num = (short)1226637313;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Applicable;
			}
			set
			{
				short num = (short)339151761;
				short num2 = num;
				num = (short)1861159825;
				switch (num2 == num)
				{
				}
				num = (short)291438592;
				short num3 = num;
				num = (short)1618018304;
				if (num != 0)
				{
				}
				num = (short)900595713;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Applicable = value;
			}
		}

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x009A7E48 File Offset: 0x009A6048
		// (set) Token: 0x0600A5BF RID: 42431 RVA: 0x009A7F00 File Offset: 0x009A6100
		public bool DirectTMSContentDisplay_42323_Valid
		{
			get
			{
				short num = (short)5094083;
				short num2 = num;
				num = (short)1051835075;
				switch (num2 == num)
				{
				}
				num = (short)1443823616;
				short num3 = num;
				num = (short)1695744001;
				if (num != 0)
				{
				}
				num = (short)645136384;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Valid;
			}
			set
			{
				short num = (short)468440714;
				short num2 = num;
				num = (short)836163210;
				switch (num2 == num)
				{
				}
				num = (short)957415424;
				short num3 = num;
				num = (short)978059265;
				if (num != 0)
				{
				}
				num = (short)733151232;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Valid = value;
			}
		}

		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x009A7FBC File Offset: 0x009A61BC
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x009A8070 File Offset: 0x009A6270
		public bool DirectTMSContentDisplay_42323_Visible
		{
			get
			{
				short num = (short)8716289;
				if (num != 0)
				{
				}
				num = (short)311314256;
				short num2 = num;
				num = (short)1980516176;
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
				num = (short)1924333568;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Visible;
			}
			set
			{
				short num = (short)379060225;
				if (num != 0)
				{
				}
				num = (short)259137529;
				short num2 = num;
				num = (short)1054154745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747634688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1565392896;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Visible = value;
			}
		}

		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x0600A5C2 RID: 42434 RVA: 0x009A8128 File Offset: 0x009A6328
		// (set) Token: 0x0600A5C3 RID: 42435 RVA: 0x009A81DC File Offset: 0x009A63DC
		public bool DirectTMSContentDisplay_42323_Editable
		{
			get
			{
				short num = (short)1902367437;
				short num2 = num;
				num = (short)356045517;
				switch (num2 == num)
				{
				}
				num = (short)1825964032;
				short num3 = num;
				num = (short)621674497;
				if (num != 0)
				{
				}
				num = (short)1192230912;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.Editable;
			}
			set
			{
				short num = (short)1199560067;
				short num2 = num;
				num = (short)463459715;
				switch (num2 == num)
				{
				}
				num = (short)267386880;
				short num3 = num;
				num = (short)1367408640;
				if (num != 0)
				{
				}
				num = (short)1531838465;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.Editable = value;
			}
		}

		// Token: 0x17005325 RID: 21285
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x009A8294 File Offset: 0x009A6494
		internal string DirectTMSContentDisplay_42323_UILabel
		{
			get
			{
				short num = (short)1195177968;
				short num2 = num;
				num = (short)852228080;
				switch (num2 == num)
				{
				}
				num = (short)1599602688;
				short num3 = num;
				num = (short)1876033537;
				if (num != 0)
				{
				}
				num = (short)546635776;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.UIName;
			}
		}

		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x0600A5C5 RID: 42437 RVA: 0x009A8348 File Offset: 0x009A6548
		// (set) Token: 0x0600A5C6 RID: 42438 RVA: 0x009A83FC File Offset: 0x009A65FC
		internal bool DirectTMSContentDisplay_42323_HiddenStatic
		{
			get
			{
				short num = (short)1293742420;
				short num2 = num;
				num = (short)862450004;
				switch (num2 == num)
				{
				}
				num = (short)1831927808;
				short num3 = num;
				num = (short)1938423809;
				if (num != 0)
				{
				}
				num = (short)916455424;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.HiddenStatic;
			}
			set
			{
				short num = (short)998361744;
				short num2 = num;
				num = (short)1214958224;
				switch (num2 == num)
				{
				}
				num = (short)1442447360;
				short num3 = num;
				num = (short)1929576448;
				if (num != 0)
				{
				}
				num = (short)250085377;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.HiddenStatic = value;
			}
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x0600A5C7 RID: 42439 RVA: 0x009A84B4 File Offset: 0x009A66B4
		// (set) Token: 0x0600A5C8 RID: 42440 RVA: 0x009A8568 File Offset: 0x009A6768
		internal bool DirectTMSContentDisplay_42323_HiddenDynamic
		{
			get
			{
				short num = (short)1859314968;
				short num2 = num;
				num = (short)1630528792;
				switch (num2 == num)
				{
				}
				num = (short)307625984;
				short num3 = num;
				num = (short)2131296256;
				if (num != 0)
				{
				}
				num = (short)573308929;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323.HiddenDynamic;
			}
			set
			{
				short num = (short)306547797;
				short num2 = num;
				num = (short)1144032341;
				switch (num2 == num)
				{
				}
				num = (short)1810038784;
				short num3 = num;
				num = (short)1323630593;
				if (num != 0)
				{
				}
				num = (short)286785536;
				if (num != 0)
				{
				}
				this.directTMSContentDisplay_42323.HiddenDynamic = value;
			}
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x0600A5C9 RID: 42441 RVA: 0x009A8620 File Offset: 0x009A6820
		public bool DirectTMSContentDisplay_42323_HasDiffs
		{
			get
			{
				short num = (short)1785016870;
				short num2 = num;
				num = (short)741093926;
				switch (num2 == num)
				{
				}
				num = (short)1683357696;
				short num3 = num;
				num = (short)126353408;
				if (num != 0)
				{
				}
				num = (short)1915617281;
				if (num != 0)
				{
				}
				return this.directTMSContentDisplay_42323._HasDiffs;
			}
		}

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x0600A5CA RID: 42442 RVA: 0x009A86D4 File Offset: 0x009A68D4
		// (set) Token: 0x0600A5CB RID: 42443 RVA: 0x009A8788 File Offset: 0x009A6988
		public bool DataWideExternalTextMessagingBroadcast_42418Value
		{
			get
			{
				short num = (short)1890385921;
				if (num != 0)
				{
				}
				num = (short)1877534932;
				short num2 = num;
				num = (short)1826875604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667090944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)143392768;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Value;
			}
			set
			{
				short num = (short)95507944;
				short num2 = num;
				num = (short)1240159720;
				switch (num2 == num)
				{
				}
				num = (short)602865664;
				short num3 = num;
				num = (short)1247608833;
				if (num != 0)
				{
				}
				num = (short)42008576;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Value = value;
			}
		}

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x0600A5CC RID: 42444 RVA: 0x009A883C File Offset: 0x009A6A3C
		public global::AcpBusinessLayer.AcpField<bool> DataWideExternalTextMessagingBroadcast_42418
		{
			get
			{
				short num = (short)1472947018;
				short num2 = num;
				num = (short)1793745738;
				switch (num2 == num)
				{
				}
				num = (short)2052784128;
				short num3 = num;
				num = (short)1613168641;
				if (num != 0)
				{
				}
				num = (short)294584320;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418;
			}
		}

		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x009A88EC File Offset: 0x009A6AEC
		// (set) Token: 0x0600A5CE RID: 42446 RVA: 0x009A89A4 File Offset: 0x009A6BA4
		public bool DataWideExternalTextMessagingBroadcast_42418_UIValue
		{
			get
			{
				short num = (short)1224212481;
				if (num != 0)
				{
				}
				num = (short)1764646955;
				short num2 = num;
				num = (short)1933795371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853868544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1667563520;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Value;
			}
			set
			{
				short num = (short)1455078160;
				short num2 = num;
				num = (short)1534180112;
				switch (num2 == num)
				{
				}
				num = (short)903413760;
				short num3 = num;
				num = (short)870449152;
				if (num != 0)
				{
				}
				num = (short)1903558657;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Value = value;
			}
		}

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x009A8A58 File Offset: 0x009A6C58
		// (set) Token: 0x0600A5D0 RID: 42448 RVA: 0x009A8B10 File Offset: 0x009A6D10
		public bool DataWideExternalTextMessagingBroadcast_42418_Applicable
		{
			get
			{
				short num = (short)911419762;
				short num2 = num;
				num = (short)1158818162;
				switch (num2 == num)
				{
				}
				num = (short)1893335040;
				short num3 = num;
				num = (short)1413677057;
				if (num != 0)
				{
				}
				num = (short)1923219456;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Applicable;
			}
			set
			{
				short num = (short)1933229896;
				short num2 = num;
				num = (short)1733803848;
				switch (num2 == num)
				{
				}
				num = (short)1114243072;
				short num3 = num;
				num = (short)571277313;
				if (num != 0)
				{
				}
				num = (short)1118044160;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Applicable = value;
			}
		}

		// Token: 0x1700532D RID: 21293
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x009A8BC8 File Offset: 0x009A6DC8
		// (set) Token: 0x0600A5D2 RID: 42450 RVA: 0x009A8C7C File Offset: 0x009A6E7C
		public bool DataWideExternalTextMessagingBroadcast_42418_Valid
		{
			get
			{
				short num = (short)1400021755;
				short num2 = num;
				num = (short)1205183227;
				switch (num2 == num)
				{
				}
				num = (short)315097088;
				short num3 = num;
				num = (short)734265345;
				if (num != 0)
				{
				}
				num = (short)1376518144;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Valid;
			}
			set
			{
				short num = (short)1373685589;
				short num2 = num;
				num = (short)1440335701;
				switch (num2 == num)
				{
				}
				num = (short)335413248;
				short num3 = num;
				num = (short)780402689;
				if (num != 0)
				{
				}
				num = (short)1012662272;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Valid = value;
			}
		}

		// Token: 0x1700532E RID: 21294
		// (get) Token: 0x0600A5D3 RID: 42451 RVA: 0x009A8D30 File Offset: 0x009A6F30
		// (set) Token: 0x0600A5D4 RID: 42452 RVA: 0x009A8DE4 File Offset: 0x009A6FE4
		public bool DataWideExternalTextMessagingBroadcast_42418_Visible
		{
			get
			{
				short num = (short)2108202970;
				short num2 = num;
				num = (short)719364058;
				switch (num2 == num)
				{
				}
				num = (short)383844352;
				short num3 = num;
				num = (short)996802561;
				if (num != 0)
				{
				}
				num = (short)1877868544;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Visible;
			}
			set
			{
				short num = (short)1475407214;
				short num2 = num;
				num = (short)378269038;
				switch (num2 == num)
				{
				}
				num = (short)672595968;
				short num3 = num;
				num = (short)1645084673;
				if (num != 0)
				{
				}
				num = (short)489095168;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Visible = value;
			}
		}

		// Token: 0x1700532F RID: 21295
		// (get) Token: 0x0600A5D5 RID: 42453 RVA: 0x009A8E98 File Offset: 0x009A7098
		// (set) Token: 0x0600A5D6 RID: 42454 RVA: 0x009A8F50 File Offset: 0x009A7150
		public bool DataWideExternalTextMessagingBroadcast_42418_Editable
		{
			get
			{
				short num = (short)1164323760;
				short num2 = num;
				num = (short)1745103792;
				switch (num2 == num)
				{
				}
				num = (short)196411392;
				short num3 = num;
				num = (short)1331625985;
				if (num != 0)
				{
				}
				num = (short)830799872;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.Editable;
			}
			set
			{
				short num = (short)101483057;
				short num2 = num;
				num = (short)815956529;
				switch (num2 == num)
				{
				}
				num = (short)112197632;
				short num3 = num;
				num = (short)870842369;
				if (num != 0)
				{
				}
				num = (short)1410924544;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.Editable = value;
			}
		}

		// Token: 0x17005330 RID: 21296
		// (get) Token: 0x0600A5D7 RID: 42455 RVA: 0x009A9004 File Offset: 0x009A7204
		internal string DataWideExternalTextMessagingBroadcast_42418_UILabel
		{
			get
			{
				short num = (short)304832129;
				short num2 = num;
				num = (short)1818517121;
				switch (num2 == num)
				{
				}
				num = (short)1810366464;
				short num3 = num;
				num = (short)511836160;
				if (num != 0)
				{
				}
				num = (short)2075983873;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.UIName;
			}
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x009A90B8 File Offset: 0x009A72B8
		// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x009A9168 File Offset: 0x009A7368
		internal bool DataWideExternalTextMessagingBroadcast_42418_HiddenStatic
		{
			get
			{
				short num = (short)1072356511;
				short num2 = num;
				num = (short)295099551;
				switch (num2 == num)
				{
				}
				num = (short)706215936;
				short num3 = num;
				num = (short)2075197441;
				if (num != 0)
				{
				}
				num = (short)1384251392;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.HiddenStatic;
			}
			set
			{
				short num = (short)837858276;
				short num2 = num;
				num = (short)1775940580;
				switch (num2 == num)
				{
				}
				num = (short)145162240;
				short num3 = num;
				num = (short)2095120384;
				if (num != 0)
				{
				}
				num = (short)1030684673;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.HiddenStatic = value;
			}
		}

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x009A9220 File Offset: 0x009A7420
		// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x009A92D4 File Offset: 0x009A74D4
		internal bool DataWideExternalTextMessagingBroadcast_42418_HiddenDynamic
		{
			get
			{
				short num = (short)983484493;
				short num2 = num;
				num = (short)23054413;
				switch (num2 == num)
				{
				}
				num = (short)65601536;
				short num3 = num;
				num = (short)1316683777;
				if (num != 0)
				{
				}
				num = (short)384040960;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418.HiddenDynamic;
			}
			set
			{
				short num = (short)1295249682;
				short num2 = num;
				num = (short)983429394;
				switch (num2 == num)
				{
				}
				num = (short)388562944;
				short num3 = num;
				num = (short)1668284417;
				if (num != 0)
				{
				}
				num = (short)421920768;
				if (num != 0)
				{
				}
				this.dataWideExternalTextMessagingBroadcast_42418.HiddenDynamic = value;
			}
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x009A9388 File Offset: 0x009A7588
		public bool DataWideExternalTextMessagingBroadcast_42418_HasDiffs
		{
			get
			{
				short num = (short)63714740;
				short num2 = num;
				num = (short)1292776884;
				switch (num2 == num)
				{
				}
				num = (short)170328064;
				short num3 = num;
				num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)1174994944;
				if (num != 0)
				{
				}
				return this.dataWideExternalTextMessagingBroadcast_42418._HasDiffs;
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x0600A5DD RID: 42461 RVA: 0x009A9440 File Offset: 0x009A7640
		// (set) Token: 0x0600A5DE RID: 42462 RVA: 0x009A94F4 File Offset: 0x009A76F4
		public int DataWideGeneralBroadbandCheckbackTime_A42862Value
		{
			get
			{
				short num = (short)1355319690;
				short num2 = num;
				num = (short)1814923658;
				switch (num2 == num)
				{
				}
				num = (short)754778112;
				short num3 = num;
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)354615296;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Value;
			}
			set
			{
				short num = (short)778704760;
				short num2 = num;
				num = (short)849287032;
				switch (num2 == num)
				{
				}
				num = (short)548470784;
				short num3 = num;
				num = (short)1207173121;
				if (num != 0)
				{
				}
				num = (short)2103115776;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Value = value;
			}
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x0600A5DF RID: 42463 RVA: 0x009A95A8 File Offset: 0x009A77A8
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideGeneralBroadbandCheckbackTime_A42862
		{
			get
			{
				short num = (short)1264582656;
				short num2 = num;
				num = (short)663945217;
				if (num != 0)
				{
				}
				num = (short)1634979034;
				short num3 = num;
				num = (short)1013304538;
				switch (num3 == num)
				{
				}
				num = (short)1007747072;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862;
			}
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x009A9654 File Offset: 0x009A7854
		// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x009A9710 File Offset: 0x009A7910
		public string DataWideGeneralBroadbandCheckbackTime_A42862_UIValue
		{
			get
			{
				short num = (short)2008088576;
				short num2 = num;
				num = (short)1897463809;
				if (num != 0)
				{
				}
				num = (short)1388433282;
				short num3 = num;
				num = (short)624021378;
				switch (num3 == num)
				{
				}
				num = (short)129957888;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.UIValue;
			}
			set
			{
				short num = (short)2053439488;
				short num2 = num;
				num = (short)109253046;
				short num3 = num;
				num = (short)1782976950;
				switch (num3 == num)
				{
				}
				num = (short)1483669505;
				if (num != 0)
				{
				}
				num = (short)1324023808;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.UIValue = value;
			}
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x009A97C8 File Offset: 0x009A79C8
		// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x009A987C File Offset: 0x009A7A7C
		internal int DataWideGeneralBroadbandCheckbackTime_A42862Min
		{
			get
			{
				short num = (short)1068105728;
				short num2 = num;
				num = (short)683474745;
				short num3 = num;
				num = (short)991035193;
				switch (num3 == num)
				{
				}
				num = (short)541130753;
				if (num != 0)
				{
				}
				num = (short)994967552;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Min;
			}
			set
			{
				short num = (short)1307901952;
				short num2 = num;
				num = (short)382531569;
				short num3 = num;
				num = (short)1028650993;
				switch (num3 == num)
				{
				}
				num = (short)1080164352;
				if (num != 0)
				{
				}
				num = (short)2087190529;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Min = value;
			}
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x009A9930 File Offset: 0x009A7B30
		// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x009A99E4 File Offset: 0x009A7BE4
		internal int DataWideGeneralBroadbandCheckbackTime_A42862Max
		{
			get
			{
				short num = (short)1167392768;
				short num2 = num;
				num = (short)434702293;
				short num3 = num;
				num = (short)221186005;
				switch (num3 == num)
				{
				}
				num = (short)1336213505;
				if (num != 0)
				{
				}
				num = (short)1464467456;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Max;
			}
			set
			{
				short num = (short)1784086528;
				short num2 = num;
				num = (short)1358226975;
				short num3 = num;
				num = (short)1633740319;
				switch (num3 == num)
				{
				}
				num = (short)1928527873;
				if (num != 0)
				{
				}
				num = (short)1923022848;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Max = value;
			}
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x009A9A98 File Offset: 0x009A7C98
		// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x009A9B4C File Offset: 0x009A7D4C
		internal int DataWideGeneralBroadbandCheckbackTime_A42862Step
		{
			get
			{
				short num = (short)1172897792;
				short num2 = num;
				num = (short)865104826;
				short num3 = num;
				num = (short)596472762;
				switch (num3 == num)
				{
				}
				num = (short)1431109633;
				if (num != 0)
				{
				}
				num = (short)1649541120;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.StepSize;
			}
			set
			{
				short num = (short)1674117120;
				short num2 = num;
				num = (short)1781893055;
				short num3 = num;
				num = (short)1474660287;
				switch (num3 == num)
				{
				}
				num = (short)640811008;
				if (num != 0)
				{
				}
				num = (short)923140097;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.StepSize = value;
			}
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x009A9C04 File Offset: 0x009A7E04
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x009A9CB8 File Offset: 0x009A7EB8
		public bool DataWideGeneralBroadbandCheckbackTime_A42862_Applicable
		{
			get
			{
				short num = (short)2027945984;
				short num2 = num;
				num = (short)455106512;
				short num3 = num;
				num = (short)1295343568;
				switch (num3 == num)
				{
				}
				num = (short)1643380737;
				if (num != 0)
				{
				}
				num = (short)1411252224;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Applicable;
			}
			set
			{
				short num = (short)1369112576;
				short num2 = num;
				num = (short)1343518338;
				short num3 = num;
				num = (short)161052290;
				switch (num3 == num)
				{
				}
				num = (short)335937537;
				if (num != 0)
				{
				}
				num = (short)1608253440;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Applicable = value;
			}
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x009A9D70 File Offset: 0x009A7F70
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x009A9E24 File Offset: 0x009A8024
		public bool DataWideGeneralBroadbandCheckbackTime_A42862_Valid
		{
			get
			{
				short num = (short)1694826496;
				short num2 = num;
				num = (short)608097934;
				short num3 = num;
				num = (short)147838606;
				switch (num3 == num)
				{
				}
				num = (short)1854406657;
				if (num != 0)
				{
				}
				num = (short)1868103680;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Valid;
			}
			set
			{
				short num = (short)1685913600;
				short num2 = num;
				num = (short)1733703847;
				short num3 = num;
				num = (short)1149319335;
				switch (num3 == num)
				{
				}
				num = (short)1718812673;
				if (num != 0)
				{
				}
				num = (short)178716672;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Valid = value;
			}
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x009A9ED8 File Offset: 0x009A80D8
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x009A9F8C File Offset: 0x009A818C
		public bool DataWideGeneralBroadbandCheckbackTime_A42862_Visible
		{
			get
			{
				short num = (short)183697408;
				short num2 = num;
				num = (short)251282757;
				short num3 = num;
				num = (short)1084966213;
				switch (num3 == num)
				{
				}
				num = (short)679542785;
				if (num != 0)
				{
				}
				num = (short)1547173888;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Visible;
			}
			set
			{
				short num = (short)1190526976;
				short num2 = num;
				num = (short)1613627677;
				short num3 = num;
				num = (short)1702297885;
				switch (num3 == num)
				{
				}
				num = (short)464388097;
				if (num != 0)
				{
				}
				num = (short)640745472;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Visible = value;
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x009AA040 File Offset: 0x009A8240
		// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x009AA0F4 File Offset: 0x009A82F4
		public bool DataWideGeneralBroadbandCheckbackTime_A42862_Editable
		{
			get
			{
				short num = (short)639041536;
				short num2 = num;
				num = (short)1206738148;
				short num3 = num;
				num = (short)643194084;
				switch (num3 == num)
				{
				}
				num = (short)993722369;
				if (num != 0)
				{
				}
				num = (short)1675231232;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.Editable;
			}
			set
			{
				short num = (short)70451200;
				short num2 = num;
				num = (short)1775375192;
				short num3 = num;
				num = (short)591139672;
				switch (num3 == num)
				{
				}
				num = (short)992018432;
				if (num != 0)
				{
				}
				num = (short)1171324929;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.Editable = value;
			}
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x009AA1AC File Offset: 0x009A83AC
		internal string DataWideGeneralBroadbandCheckbackTime_A42862_UILabel
		{
			get
			{
				short num = (short)1864630272;
				short num2 = num;
				num = (short)592711987;
				short num3 = num;
				num = (short)1574375731;
				switch (num3 == num)
				{
				}
				num = (short)402194433;
				if (num != 0)
				{
				}
				num = (short)2003107840;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.UIName;
			}
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x0600A5F1 RID: 42481 RVA: 0x009AA260 File Offset: 0x009A8460
		// (set) Token: 0x0600A5F2 RID: 42482 RVA: 0x009AA31C File Offset: 0x009A851C
		internal bool DataWideGeneralBroadbandCheckbackTime_A42862_HiddenStatic
		{
			get
			{
				short num = (short)1424490496;
				short num2 = num;
				num = (short)1520267155;
				short num3 = num;
				num = (short)1540386707;
				switch (num3 == num)
				{
				}
				num = (short)889389056;
				if (num != 0)
				{
				}
				num = (short)1792475137;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.HiddenStatic;
			}
			set
			{
				short num = (short)1809973248;
				short num2 = num;
				num = (short)1772006608;
				short num3 = num;
				num = (short)1912974544;
				switch (num3 == num)
				{
				}
				num = (short)1142489089;
				if (num != 0)
				{
				}
				num = (short)1163984896;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.HiddenStatic = value;
			}
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x0600A5F3 RID: 42483 RVA: 0x009AA3D4 File Offset: 0x009A85D4
		// (set) Token: 0x0600A5F4 RID: 42484 RVA: 0x009AA48C File Offset: 0x009A868C
		internal bool DataWideGeneralBroadbandCheckbackTime_A42862_HiddenDynamic
		{
			get
			{
				short num = (short)1387003904;
				short num2 = num;
				num = (short)948217961;
				short num3 = num;
				num = (short)2035066985;
				switch (num3 == num)
				{
				}
				num = (short)481886209;
				if (num != 0)
				{
				}
				num = (short)1881538560;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862.HiddenDynamic;
			}
			set
			{
				short num = (short)1909784576;
				short num2 = num;
				num = (short)151274556;
				short num3 = num;
				num = (short)1861174332;
				switch (num3 == num)
				{
				}
				num = (short)1581383681;
				if (num != 0)
				{
				}
				num = (short)2139881472;
				if (num != 0)
				{
				}
				this.dataWideGeneralBroadbandCheckbackTime_A42862.HiddenDynamic = value;
			}
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x0600A5F5 RID: 42485 RVA: 0x009AA540 File Offset: 0x009A8740
		public bool DataWideGeneralBroadbandCheckbackTime_A42862_HasDiffs
		{
			get
			{
				short num = (short)1112408064;
				short num2 = num;
				num = (short)310123241;
				short num3 = num;
				num = (short)5446377;
				switch (num3 == num)
				{
				}
				num = (short)1679491072;
				if (num != 0)
				{
				}
				num = (short)1336868865;
				if (num != 0)
				{
				}
				return this.dataWideGeneralBroadbandCheckbackTime_A42862._HasDiffs;
			}
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x009AA5F8 File Offset: 0x009A87F8
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x009AA6B0 File Offset: 0x009A88B0
		public bool SensorMeasurementReporting_A43021Value
		{
			get
			{
				short num = (short)1382678528;
				short num2 = num;
				num = (short)1937238300;
				short num3 = num;
				num = (short)111077660;
				switch (num3 == num)
				{
				}
				num = (short)108658688;
				if (num != 0)
				{
				}
				num = (short)1305542657;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Value;
			}
			set
			{
				short num = (short)1283194880;
				short num2 = num;
				num = (short)1256659871;
				short num3 = num;
				num = (short)703798175;
				switch (num3 == num)
				{
				}
				num = (short)983891969;
				if (num != 0)
				{
				}
				num = (short)491192320;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Value = value;
			}
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x009AA764 File Offset: 0x009A8964
		public global::AcpBusinessLayer.AcpField<bool> SensorMeasurementReporting_A43021
		{
			get
			{
				short num = (short)1757151232;
				short num2 = num;
				num = (short)434871752;
				short num3 = num;
				num = (short)1015782856;
				switch (num3 == num)
				{
				}
				num = (short)1319829505;
				if (num != 0)
				{
				}
				num = (short)446889984;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021;
			}
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x009AA814 File Offset: 0x009A8A14
		// (set) Token: 0x0600A5FA RID: 42490 RVA: 0x009AA8CC File Offset: 0x009A8ACC
		public bool SensorMeasurementReporting_A43021_UIValue
		{
			get
			{
				short num = (short)386334720;
				short num2 = num;
				num = (short)638940236;
				short num3 = num;
				num = (short)573207628;
				switch (num3 == num)
				{
				}
				num = (short)1973944320;
				if (num != 0)
				{
				}
				num = (short)1659305985;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Value;
			}
			set
			{
				short num = (short)865796096;
				short num2 = num;
				num = (short)1435957476;
				short num3 = num;
				num = (short)1773992164;
				switch (num3 == num)
				{
				}
				num = (short)2126774273;
				if (num != 0)
				{
				}
				num = (short)202833920;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Value = value;
			}
		}

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x009AA980 File Offset: 0x009A8B80
		// (set) Token: 0x0600A5FC RID: 42492 RVA: 0x009AAA34 File Offset: 0x009A8C34
		public bool SensorMeasurementReporting_A43021_Applicable
		{
			get
			{
				short num = (short)1650458624;
				short num2 = num;
				num = (short)1310475276;
				short num3 = num;
				num = (short)1484866572;
				switch (num3 == num)
				{
				}
				num = (short)98828288;
				if (num != 0)
				{
				}
				num = (short)588251137;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Applicable;
			}
			set
			{
				short num = (short)1363607552;
				short num2 = num;
				num = (short)1266100487;
				short num3 = num;
				num = (short)1016015111;
				switch (num3 == num)
				{
				}
				num = (short)702480384;
				if (num != 0)
				{
				}
				num = (short)387776513;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Applicable = value;
			}
		}

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x009AAAE8 File Offset: 0x009A8CE8
		// (set) Token: 0x0600A5FE RID: 42494 RVA: 0x009AABA0 File Offset: 0x009A8DA0
		public bool SensorMeasurementReporting_A43021_Valid
		{
			get
			{
				short num = (short)437321728;
				short num2 = num;
				num = (short)1307892093;
				short num3 = num;
				num = (short)196925821;
				switch (num3 == num)
				{
				}
				num = (short)835452929;
				if (num != 0)
				{
				}
				num = (short)1979973632;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Valid;
			}
			set
			{
				short num = (short)397934592;
				short num2 = num;
				num = (short)219197283;
				short num3 = num;
				num = (short)1073196899;
				switch (num3 == num)
				{
				}
				num = (short)439156737;
				if (num != 0)
				{
				}
				num = (short)654376960;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Valid = value;
			}
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x0600A5FF RID: 42495 RVA: 0x009AAC54 File Offset: 0x009A8E54
		// (set) Token: 0x0600A600 RID: 42496 RVA: 0x009AAD0C File Offset: 0x009A8F0C
		public bool SensorMeasurementReporting_A43021_Visible
		{
			get
			{
				short num = (short)1534722048;
				short num2 = num;
				num = (short)1042940618;
				short num3 = num;
				num = (short)149619402;
				switch (num3 == num)
				{
				}
				num = (short)930414592;
				if (num != 0)
				{
				}
				num = (short)588840961;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Visible;
			}
			set
			{
				short num = (short)2147155968;
				short num2 = num;
				num = (short)1558977198;
				short num3 = num;
				num = (short)341252782;
				switch (num3 == num)
				{
				}
				num = (short)1327169537;
				if (num != 0)
				{
				}
				num = (short)2108948480;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Visible = value;
			}
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x009AADC4 File Offset: 0x009A8FC4
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x009AAE78 File Offset: 0x009A9078
		public bool SensorMeasurementReporting_A43021_Editable
		{
			get
			{
				short num = (short)832569344;
				short num2 = num;
				num = (short)266207233;
				if (num != 0)
				{
				}
				num = (short)1106123769;
				short num3 = num;
				num = (short)2073238521;
				switch (num3 == num)
				{
				}
				num = (short)150798336;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.Editable;
			}
			set
			{
				short num = (short)1865089024;
				short num2 = num;
				num = (short)2048689765;
				short num3 = num;
				num = (short)2004715109;
				switch (num3 == num)
				{
				}
				num = (short)472776705;
				if (num != 0)
				{
				}
				num = (short)1425473536;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.Editable = value;
			}
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x009AAF2C File Offset: 0x009A912C
		internal string SensorMeasurementReporting_A43021_UILabel
		{
			get
			{
				short num = (short)1907490816;
				short num2 = num;
				num = (short)215896468;
				short num3 = num;
				num = (short)621826452;
				switch (num3 == num)
				{
				}
				num = (short)150405120;
				if (num != 0)
				{
				}
				num = (short)447938561;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.UIName;
			}
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x009AAFE0 File Offset: 0x009A91E0
		// (set) Token: 0x0600A605 RID: 42501 RVA: 0x009AB098 File Offset: 0x009A9298
		internal bool SensorMeasurementReporting_A43021_HiddenStatic
		{
			get
			{
				short num = (short)1994063872;
				short num2 = num;
				num = (short)2001559794;
				short num3 = num;
				num = (short)2058903794;
				switch (num3 == num)
				{
				}
				num = (short)865468416;
				if (num != 0)
				{
				}
				num = (short)1389363201;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.HiddenStatic;
			}
			set
			{
				short num = (short)195035136;
				short num2 = num;
				num = (short)1046070047;
				short num3 = num;
				num = (short)289391391;
				switch (num3 == num)
				{
				}
				num = (short)1873281024;
				if (num != 0)
				{
				}
				num = (short)406978561;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.HiddenStatic = value;
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x0600A606 RID: 42502 RVA: 0x009AB150 File Offset: 0x009A9350
		// (set) Token: 0x0600A607 RID: 42503 RVA: 0x009AB204 File Offset: 0x009A9404
		internal bool SensorMeasurementReporting_A43021_HiddenDynamic
		{
			get
			{
				short num = (short)1739849728;
				short num2 = num;
				num = (short)1260921245;
				short num3 = num;
				num = (short)942350749;
				switch (num3 == num)
				{
				}
				num = (short)2137128960;
				if (num != 0)
				{
				}
				num = (short)743047169;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021.HiddenDynamic;
			}
			set
			{
				short num = (short)1732706304;
				short num2 = num;
				num = (short)1156110632;
				short num3 = num;
				num = (short)880859432;
				switch (num3 == num)
				{
				}
				num = (short)380043264;
				if (num != 0)
				{
				}
				num = (short)2130837505;
				if (num != 0)
				{
				}
				this.sensorMeasurementReporting_A43021.HiddenDynamic = value;
			}
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x0600A608 RID: 42504 RVA: 0x009AB2BC File Offset: 0x009A94BC
		public bool SensorMeasurementReporting_A43021_HasDiffs
		{
			get
			{
				short num = (short)1600978944;
				short num2 = num;
				num = (short)194064192;
				short num3 = num;
				num = (short)652029760;
				switch (num3 == num)
				{
				}
				num = (short)929431552;
				if (num != 0)
				{
				}
				num = (short)1566834689;
				if (num != 0)
				{
				}
				return this.sensorMeasurementReporting_A43021._HasDiffs;
			}
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x0600A609 RID: 42505 RVA: 0x009AB370 File Offset: 0x009A9570
		// (set) Token: 0x0600A60A RID: 42506 RVA: 0x009AB424 File Offset: 0x009A9624
		public bool AcknowledgedGunHolsterStateReportingEnable_43551Value
		{
			get
			{
				short num = (short)1154154496;
				short num2 = num;
				num = (short)45170581;
				short num3 = num;
				num = (short)142688149;
				switch (num3 == num)
				{
				}
				num = (short)263979009;
				if (num != 0)
				{
				}
				num = (short)563019776;
				if (num != 0)
				{
				}
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Value;
			}
			set
			{
				short num = (short)826933248;
				short num2 = num;
				num = (short)2063089673;
				short num3 = num;
				num = (short)798572553;
				switch (num3 == num)
				{
				}
				num = (short)1181614081;
				if (num != 0)
				{
				}
				num = (short)225902592;
				if (num != 0)
				{
				}
				this.acknowledgedGunHolsterStateReportingEnable_43551.Value = value;
			}
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x0600A60B RID: 42507 RVA: 0x009AB4D8 File Offset: 0x009A96D8
		public global::AcpBusinessLayer.AcpField<bool> AcknowledgedGunHolsterStateReportingEnable_43551
		{
			get
			{
				short num = (short)825491456;
				short num2 = num;
				num = (short)570783467;
				short num3 = num;
				num = (short)1546745579;
				switch (num3 == num)
				{
				}
				num = (short)1284702208;
				if (num != 0)
				{
				}
				num = (short)1725825025;
				if (num != 0)
				{
				}
				return this.acknowledgedGunHolsterStateReportingEnable_43551;
			}
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x0600A60C RID: 42508 RVA: 0x009AB588 File Offset: 0x009A9788
		// (set) Token: 0x0600A60D RID: 42509 RVA: 0x009AB63C File Offset: 0x009A983C
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_UIValue
		{
			get
			{
				short num = (short)943063040;
				short num2 = num;
				num = (short)693982497;
				short num3 = num;
				num = (short)1902925089;
				switch (num3 == num)
				{
				}
				num = (short)540934145;
				if (num != 0)
				{
				}
				num = (short)190709760;
				if (num != 0)
				{
				}
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Value;
			}
			set
			{
				short num = (short)397213696;
				short num2 = num;
				num = (short)1303136650;
				short num3 = num;
				num = (short)1254574474;
				switch (num3 == num)
				{
				}
				num = (short)555417601;
				if (num != 0)
				{
				}
				num = (short)33226752;
				if (num != 0)
				{
				}
				this.acknowledgedGunHolsterStateReportingEnable_43551.Value = value;
			}
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x0600A60E RID: 42510 RVA: 0x009AB6F4 File Offset: 0x009A98F4
		// (set) Token: 0x0600A60F RID: 42511 RVA: 0x009AB7AC File Offset: 0x009A99AC
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_Applicable
		{
			get
			{
				short num = (short)53418299;
				short num2 = num;
				num = (short)1253775675;
				switch (num2 == num)
				{
				}
				num = (short)802226177;
				if (num != 0)
				{
				}
				num = (short)1559232512;
				if (num != 0)
				{
				}
				num = (short)975372288;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Applicable;
			}
			set
			{
				short num = (short)784915330;
				short num2 = num;
				num = (short)832232322;
				switch (num2 == num)
				{
				}
				num = (short)492568577;
				if (num != 0)
				{
				}
				num = (short)1788346368;
				if (num != 0)
				{
				}
				num = (short)707657728;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.Applicable = value;
			}
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x0600A610 RID: 42512 RVA: 0x009AB860 File Offset: 0x009A9A60
		// (set) Token: 0x0600A611 RID: 42513 RVA: 0x009AB914 File Offset: 0x009A9B14
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_Valid
		{
			get
			{
				short num = (short)1903318783;
				short num2 = num;
				num = (short)1591957247;
				switch (num2 == num)
				{
				}
				num = (short)490733569;
				if (num != 0)
				{
				}
				num = (short)890896384;
				if (num != 0)
				{
				}
				num = (short)1234829312;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Valid;
			}
			set
			{
				short num = (short)1111536885;
				short num2 = num;
				num = (short)1545581813;
				switch (num2 == num)
				{
				}
				num = (short)311230465;
				if (num != 0)
				{
				}
				num = (short)504430592;
				if (num != 0)
				{
				}
				num = (short)1063124992;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.Valid = value;
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x0600A612 RID: 42514 RVA: 0x009AB9C8 File Offset: 0x009A9BC8
		// (set) Token: 0x0600A613 RID: 42515 RVA: 0x009ABA7C File Offset: 0x009A9C7C
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_Visible
		{
			get
			{
				short num = (short)2122768350;
				short num2 = num;
				num = (short)1191763934;
				switch (num2 == num)
				{
				}
				num = (short)1318191104;
				if (num != 0)
				{
				}
				num = (short)624099329;
				if (num != 0)
				{
				}
				num = (short)1627521024;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Visible;
			}
			set
			{
				short num = (short)776652321;
				short num2 = num;
				num = (short)1848296993;
				switch (num2 == num)
				{
				}
				num = (short)1096417281;
				if (num != 0)
				{
				}
				num = (short)525598720;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.Visible = value;
			}
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x0600A614 RID: 42516 RVA: 0x009ABB34 File Offset: 0x009A9D34
		// (set) Token: 0x0600A615 RID: 42517 RVA: 0x009ABBE8 File Offset: 0x009A9DE8
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_Editable
		{
			get
			{
				short num = (short)1871699129;
				short num2 = num;
				num = (short)887413945;
				switch (num2 == num)
				{
				}
				num = (short)1944584193;
				if (num != 0)
				{
				}
				num = (short)992804864;
				if (num != 0)
				{
				}
				num = (short)1109131264;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.Editable;
			}
			set
			{
				short num = (short)6029313;
				if (num != 0)
				{
				}
				num = (short)2055040783;
				short num2 = num;
				num = (short)1593274127;
				switch (num2 == num)
				{
				}
				num = (short)1246625792;
				if (num != 0)
				{
				}
				num = (short)756350976;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.Editable = value;
			}
		}

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x0600A616 RID: 42518 RVA: 0x009ABC9C File Offset: 0x009A9E9C
		internal string AcknowledgedGunHolsterStateReportingEnable_43551_UILabel
		{
			get
			{
				short num = (short)1181255838;
				short num2 = num;
				num = (short)1547929758;
				switch (num2 == num)
				{
				}
				num = (short)313655297;
				if (num != 0)
				{
				}
				num = (short)1048641536;
				if (num != 0)
				{
				}
				num = (short)2038562816;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.UIName;
			}
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x0600A617 RID: 42519 RVA: 0x009ABD50 File Offset: 0x009A9F50
		// (set) Token: 0x0600A618 RID: 42520 RVA: 0x009ABE04 File Offset: 0x009AA004
		internal bool AcknowledgedGunHolsterStateReportingEnable_43551_HiddenStatic
		{
			get
			{
				short num = (short)1080538265;
				short num2 = num;
				num = (short)234271897;
				switch (num2 == num)
				{
				}
				num = (short)474873857;
				if (num != 0)
				{
				}
				num = (short)1614479360;
				if (num != 0)
				{
				}
				num = (short)337117184;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.HiddenStatic;
			}
			set
			{
				short num = (short)742205593;
				short num2 = num;
				num = (short)131475609;
				switch (num2 == num)
				{
				}
				num = (short)1311309825;
				if (num != 0)
				{
				}
				num = (short)2103246848;
				if (num != 0)
				{
				}
				num = (short)725352448;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.HiddenStatic = value;
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x0600A619 RID: 42521 RVA: 0x009ABEBC File Offset: 0x009AA0BC
		// (set) Token: 0x0600A61A RID: 42522 RVA: 0x009ABF6C File Offset: 0x009AA16C
		internal bool AcknowledgedGunHolsterStateReportingEnable_43551_HiddenDynamic
		{
			get
			{
				short num = (short)1593369497;
				short num2 = num;
				num = (short)631366553;
				switch (num2 == num)
				{
				}
				num = (short)1989738497;
				if (num != 0)
				{
				}
				num = (short)1041432576;
				if (num != 0)
				{
				}
				num = (short)1686110208;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551.HiddenDynamic;
			}
			set
			{
				short num = (short)1278827048;
				short num2 = num;
				num = (short)2021677608;
				switch (num2 == num)
				{
				}
				num = (short)1797455873;
				if (num != 0)
				{
				}
				num = (short)1361575936;
				if (num != 0)
				{
				}
				num = (short)766771200;
				short num3 = num;
				this.acknowledgedGunHolsterStateReportingEnable_43551.HiddenDynamic = value;
			}
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x009AC020 File Offset: 0x009AA220
		public bool AcknowledgedGunHolsterStateReportingEnable_43551_HasDiffs
		{
			get
			{
				short num = (short)681808777;
				short num2 = num;
				num = (short)1236243337;
				switch (num2 == num)
				{
				}
				num = (short)1432682497;
				if (num != 0)
				{
				}
				num = (short)336527360;
				if (num != 0)
				{
				}
				num = (short)441843712;
				short num3 = num;
				return this.acknowledgedGunHolsterStateReportingEnable_43551._HasDiffs;
			}
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x0600A61C RID: 42524 RVA: 0x009AC0D4 File Offset: 0x009AA2D4
		// (set) Token: 0x0600A61D RID: 42525 RVA: 0x009AC18C File Offset: 0x009AA38C
		public bool AcknowledgedStunGunStateReportingEnable_43552Value
		{
			get
			{
				short num = (short)1017834811;
				short num2 = num;
				num = (short)125496635;
				switch (num2 == num)
				{
				}
				num = (short)182321153;
				if (num != 0)
				{
				}
				num = (short)1757216768;
				if (num != 0)
				{
				}
				num = (short)1746534400;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Value;
			}
			set
			{
				short num = (short)1339436974;
				short num2 = num;
				num = (short)2063806382;
				switch (num2 == num)
				{
				}
				num = (short)1443758081;
				if (num != 0)
				{
				}
				num = (short)1849884672;
				if (num != 0)
				{
				}
				num = (short)221118464;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Value = value;
			}
		}

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x0600A61E RID: 42526 RVA: 0x009AC244 File Offset: 0x009AA444
		public global::AcpBusinessLayer.AcpField<bool> AcknowledgedStunGunStateReportingEnable_43552
		{
			get
			{
				short num = (short)806379192;
				short num2 = num;
				num = (short)779771576;
				switch (num2 == num)
				{
				}
				num = (short)976814080;
				if (num != 0)
				{
				}
				num = (short)1891958785;
				if (num != 0)
				{
				}
				num = (short)764477440;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552;
			}
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x0600A61F RID: 42527 RVA: 0x009AC2F0 File Offset: 0x009AA4F0
		// (set) Token: 0x0600A620 RID: 42528 RVA: 0x009AC3A4 File Offset: 0x009AA5A4
		public bool AcknowledgedStunGunStateReportingEnable_43552_UIValue
		{
			get
			{
				short num = (short)283149907;
				short num2 = num;
				num = (short)1281197651;
				switch (num2 == num)
				{
				}
				num = (short)526057472;
				if (num != 0)
				{
				}
				num = (short)1825308673;
				if (num != 0)
				{
				}
				num = (short)1906114560;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Value;
			}
			set
			{
				short num = (short)1702807326;
				short num2 = num;
				num = (short)1851049758;
				switch (num2 == num)
				{
				}
				num = (short)1817772032;
				if (num != 0)
				{
				}
				num = (short)574423041;
				if (num != 0)
				{
				}
				num = (short)804323328;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Value = value;
			}
		}

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x0600A621 RID: 42529 RVA: 0x009AC45C File Offset: 0x009AA65C
		// (set) Token: 0x0600A622 RID: 42530 RVA: 0x009AC510 File Offset: 0x009AA710
		public bool AcknowledgedStunGunStateReportingEnable_43552_Applicable
		{
			get
			{
				short num = (short)1891423172;
				short num2 = num;
				num = (short)1081398212;
				switch (num2 == num)
				{
				}
				num = (short)686882816;
				if (num != 0)
				{
				}
				num = (short)905510913;
				if (num != 0)
				{
				}
				num = (short)2039611392;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Applicable;
			}
			set
			{
				short num = (short)1197670401;
				if (num != 0)
				{
				}
				num = (short)1864834552;
				short num2 = num;
				num = (short)83959288;
				switch (num2 == num)
				{
				}
				num = (short)205586432;
				if (num != 0)
				{
				}
				num = (short)1842741248;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Applicable = value;
			}
		}

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x009AC5C4 File Offset: 0x009AA7C4
		// (set) Token: 0x0600A624 RID: 42532 RVA: 0x009AC67C File Offset: 0x009AA87C
		public bool AcknowledgedStunGunStateReportingEnable_43552_Valid
		{
			get
			{
				short num = (short)1305094476;
				short num2 = num;
				num = (short)180103500;
				switch (num2 == num)
				{
				}
				num = (short)768409601;
				if (num != 0)
				{
				}
				num = (short)177733632;
				if (num != 0)
				{
				}
				num = (short)1545207808;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Valid;
			}
			set
			{
				short num = (short)525367991;
				short num2 = num;
				num = (short)1179941559;
				switch (num2 == num)
				{
				}
				num = (short)512557057;
				if (num != 0)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				num = (short)908984320;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Valid = value;
			}
		}

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x0600A625 RID: 42533 RVA: 0x009AC734 File Offset: 0x009AA934
		// (set) Token: 0x0600A626 RID: 42534 RVA: 0x009AC7E8 File Offset: 0x009AA9E8
		public bool AcknowledgedStunGunStateReportingEnable_43552_Visible
		{
			get
			{
				short num = (short)109382480;
				short num2 = num;
				num = (short)1704921936;
				switch (num2 == num)
				{
				}
				num = (short)1704722433;
				if (num != 0)
				{
				}
				num = (short)1445396480;
				if (num != 0)
				{
				}
				num = (short)949485568;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Visible;
			}
			set
			{
				short num = (short)1804795905;
				if (num != 0)
				{
				}
				num = (short)1979757157;
				short num2 = num;
				num = (short)1540534885;
				switch (num2 == num)
				{
				}
				num = (short)1898643456;
				if (num != 0)
				{
				}
				num = (short)1574895616;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Visible = value;
			}
		}

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x009AC89C File Offset: 0x009AAA9C
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x009AC950 File Offset: 0x009AAB50
		public bool AcknowledgedStunGunStateReportingEnable_43552_Editable
		{
			get
			{
				short num = (short)459951636;
				short num2 = num;
				num = (short)739855892;
				switch (num2 == num)
				{
				}
				num = (short)1156055041;
				if (num != 0)
				{
				}
				num = (short)2109734912;
				if (num != 0)
				{
				}
				num = (short)1870725120;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.Editable;
			}
			set
			{
				short num = (short)2075348470;
				short num2 = num;
				num = (short)1916816886;
				switch (num2 == num)
				{
				}
				num = (short)1365442561;
				if (num != 0)
				{
				}
				num = (short)984350720;
				if (num != 0)
				{
				}
				num = (short)227016704;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.Editable = value;
			}
		}

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x0600A629 RID: 42537 RVA: 0x009ACA04 File Offset: 0x009AAC04
		internal string AcknowledgedStunGunStateReportingEnable_43552_UILabel
		{
			get
			{
				short num = (short)277926824;
				short num2 = num;
				num = (short)1223742376;
				switch (num2 == num)
				{
				}
				num = (short)670302209;
				if (num != 0)
				{
				}
				num = (short)970391552;
				if (num != 0)
				{
				}
				num = (short)1194721280;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.UIName;
			}
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x0600A62A RID: 42538 RVA: 0x009ACABC File Offset: 0x009AACBC
		// (set) Token: 0x0600A62B RID: 42539 RVA: 0x009ACB70 File Offset: 0x009AAD70
		internal bool AcknowledgedStunGunStateReportingEnable_43552_HiddenStatic
		{
			get
			{
				short num = (short)164460840;
				short num2 = num;
				num = (short)2062514472;
				switch (num2 == num)
				{
				}
				num = (short)1462829057;
				if (num != 0)
				{
				}
				num = (short)709296128;
				if (num != 0)
				{
				}
				num = (short)1799094272;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.HiddenStatic;
			}
			set
			{
				short num = (short)822936742;
				short num2 = num;
				num = (short)246088870;
				switch (num2 == num)
				{
				}
				num = (short)1844838400;
				if (num != 0)
				{
				}
				num = (short)1021706241;
				if (num != 0)
				{
				}
				num = (short)1506803712;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.HiddenStatic = value;
			}
		}

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x0600A62C RID: 42540 RVA: 0x009ACC28 File Offset: 0x009AAE28
		// (set) Token: 0x0600A62D RID: 42541 RVA: 0x009ACCE0 File Offset: 0x009AAEE0
		internal bool AcknowledgedStunGunStateReportingEnable_43552_HiddenDynamic
		{
			get
			{
				short num = (short)1234033376;
				short num2 = num;
				num = (short)146463456;
				switch (num2 == num)
				{
				}
				num = (short)934019072;
				if (num != 0)
				{
				}
				num = (short)405602305;
				if (num != 0)
				{
				}
				num = (short)2069561344;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552.HiddenDynamic;
			}
			set
			{
				short num = (short)58290737;
				short num2 = num;
				num = (short)1140093489;
				switch (num2 == num)
				{
				}
				num = (short)565116928;
				if (num != 0)
				{
				}
				num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)1152188416;
				short num3 = num;
				this.acknowledgedStunGunStateReportingEnable_43552.HiddenDynamic = value;
			}
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x009ACD98 File Offset: 0x009AAF98
		public bool AcknowledgedStunGunStateReportingEnable_43552_HasDiffs
		{
			get
			{
				short num = (short)465829889;
				if (num != 0)
				{
				}
				num = (short)879609470;
				short num2 = num;
				num = (short)1030342270;
				switch (num2 == num)
				{
				}
				num = (short)1400373248;
				if (num != 0)
				{
				}
				num = (short)421920768;
				short num3 = num;
				return this.acknowledgedStunGunStateReportingEnable_43552._HasDiffs;
			}
		}

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x0600A62F RID: 42543 RVA: 0x009ACE4C File Offset: 0x009AB04C
		// (set) Token: 0x0600A630 RID: 42544 RVA: 0x009ACF00 File Offset: 0x009AB100
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582Value
		{
			get
			{
				short num = (short)408158209;
				if (num != 0)
				{
				}
				num = (short)1333023806;
				short num2 = num;
				num = (short)1445024830;
				switch (num2 == num)
				{
				}
				num = (short)2024472576;
				if (num != 0)
				{
				}
				num = (short)1976434688;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Value;
			}
			set
			{
				short num = (short)1619680016;
				short num2 = num;
				num = (short)73030416;
				switch (num2 == num)
				{
				}
				num = (short)929693697;
				if (num != 0)
				{
				}
				num = (short)1663696896;
				if (num != 0)
				{
				}
				num = (short)1842282496;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Value = value;
			}
		}

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x0600A631 RID: 42545 RVA: 0x009ACFB4 File Offset: 0x009AB1B4
		public global::AcpBusinessLayer.AcpField<bool> AcknowledgedWeaponFiredEventReportingEnable_43582
		{
			get
			{
				short num = (short)906559489;
				if (num != 0)
				{
				}
				num = (short)617618785;
				short num2 = num;
				num = (short)1285954913;
				switch (num2 == num)
				{
				}
				num = (short)522649600;
				if (num != 0)
				{
				}
				num = (short)1665138688;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582;
			}
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x0600A632 RID: 42546 RVA: 0x009AD064 File Offset: 0x009AB264
		// (set) Token: 0x0600A633 RID: 42547 RVA: 0x009AD118 File Offset: 0x009AB318
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_UIValue
		{
			get
			{
				short num = (short)1734995212;
				short num2 = num;
				num = (short)1365830924;
				switch (num2 == num)
				{
				}
				num = (short)1282539521;
				if (num != 0)
				{
				}
				num = (short)1176174592;
				if (num != 0)
				{
				}
				num = (short)1941569536;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Value;
			}
			set
			{
				short num = (short)1374123026;
				short num2 = num;
				num = (short)526349330;
				switch (num2 == num)
				{
				}
				num = (short)27459585;
				if (num != 0)
				{
				}
				num = (short)119013376;
				if (num != 0)
				{
				}
				num = (short)79429632;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Value = value;
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x009AD1D0 File Offset: 0x009AB3D0
		// (set) Token: 0x0600A635 RID: 42549 RVA: 0x009AD284 File Offset: 0x009AB484
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_Applicable
		{
			get
			{
				short num = (short)1335949727;
				short num2 = num;
				num = (short)250608031;
				switch (num2 == num)
				{
				}
				num = (short)986120193;
				if (num != 0)
				{
				}
				num = (short)1842413568;
				if (num != 0)
				{
				}
				num = (short)241303552;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Applicable;
			}
			set
			{
				short num = (short)775350594;
				short num2 = num;
				num = (short)1853483330;
				switch (num2 == num)
				{
				}
				num = (short)577175553;
				if (num != 0)
				{
				}
				num = (short)192937984;
				if (num != 0)
				{
				}
				num = (short)1705836544;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Applicable = value;
			}
		}

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x0600A636 RID: 42550 RVA: 0x009AD338 File Offset: 0x009AB538
		// (set) Token: 0x0600A637 RID: 42551 RVA: 0x009AD3EC File Offset: 0x009AB5EC
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_Valid
		{
			get
			{
				short num = (short)1704928784;
				short num2 = num;
				num = (short)1870931472;
				switch (num2 == num)
				{
				}
				num = (short)1016397824;
				if (num != 0)
				{
				}
				num = (short)130220033;
				if (num != 0)
				{
				}
				num = (short)1108213760;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Valid;
			}
			set
			{
				short num = (short)1879179265;
				if (num != 0)
				{
				}
				num = (short)1306373022;
				short num2 = num;
				num = (short)1089055646;
				switch (num2 == num)
				{
				}
				num = (short)587005952;
				if (num != 0)
				{
				}
				num = (short)1865154560;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Valid = value;
			}
		}

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x0600A638 RID: 42552 RVA: 0x009AD4A4 File Offset: 0x009AB6A4
		// (set) Token: 0x0600A639 RID: 42553 RVA: 0x009AD558 File Offset: 0x009AB758
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_Visible
		{
			get
			{
				short num = (short)2104660827;
				short num2 = num;
				num = (short)286626651;
				switch (num2 == num)
				{
				}
				num = (short)578748417;
				if (num != 0)
				{
				}
				num = (short)61145088;
				if (num != 0)
				{
				}
				num = (short)1204224000;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Visible;
			}
			set
			{
				short num = (short)976158721;
				if (num != 0)
				{
				}
				num = (short)422171084;
				short num2 = num;
				num = (short)257151436;
				switch (num2 == num)
				{
				}
				num = (short)1134428160;
				if (num != 0)
				{
				}
				num = (short)1093206016;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Visible = value;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x0600A63A RID: 42554 RVA: 0x009AD60C File Offset: 0x009AB80C
		// (set) Token: 0x0600A63B RID: 42555 RVA: 0x009AD6C0 File Offset: 0x009AB8C0
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_Editable
		{
			get
			{
				short num = (short)609429755;
				short num2 = num;
				num = (short)478095611;
				switch (num2 == num)
				{
				}
				num = (short)2082340865;
				if (num != 0)
				{
				}
				num = (short)1316552704;
				if (num != 0)
				{
				}
				num = (short)939655168;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.Editable;
			}
			set
			{
				short num = (short)1380023641;
				short num2 = num;
				num = (short)1208057177;
				switch (num2 == num)
				{
				}
				num = (short)1591345153;
				if (num != 0)
				{
				}
				num = (short)1264058368;
				if (num != 0)
				{
				}
				num = (short)1024786432;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.Editable = value;
			}
		}

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x009AD774 File Offset: 0x009AB974
		internal string AcknowledgedWeaponFiredEventReportingEnable_43582_UILabel
		{
			get
			{
				short num = (short)1425238262;
				short num2 = num;
				num = (short)1885432054;
				switch (num2 == num)
				{
				}
				num = (short)709820417;
				if (num != 0)
				{
				}
				num = (short)1231814656;
				if (num != 0)
				{
				}
				num = (short)1937309696;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.UIName;
			}
		}

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x009AD828 File Offset: 0x009ABA28
		// (set) Token: 0x0600A63E RID: 42558 RVA: 0x009AD8DC File Offset: 0x009ABADC
		internal bool AcknowledgedWeaponFiredEventReportingEnable_43582_HiddenStatic
		{
			get
			{
				short num = (short)1829765121;
				if (num != 0)
				{
				}
				num = (short)122457619;
				short num2 = num;
				num = (short)522423827;
				switch (num2 == num)
				{
				}
				num = (short)731054080;
				if (num != 0)
				{
				}
				num = (short)1646723072;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.HiddenStatic;
			}
			set
			{
				short num = (short)1915939820;
				short num2 = num;
				num = (short)1854401516;
				switch (num2 == num)
				{
				}
				num = (short)1258881025;
				if (num != 0)
				{
				}
				num = (short)174915584;
				if (num != 0)
				{
				}
				num = (short)1142489088;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.HiddenStatic = value;
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x009AD990 File Offset: 0x009ABB90
		// (set) Token: 0x0600A640 RID: 42560 RVA: 0x009ADA44 File Offset: 0x009ABC44
		internal bool AcknowledgedWeaponFiredEventReportingEnable_43582_HiddenDynamic
		{
			get
			{
				short num = (short)586022802;
				short num2 = num;
				num = (short)1339162514;
				switch (num2 == num)
				{
				}
				num = (short)517603329;
				if (num != 0)
				{
				}
				num = (short)1758986240;
				if (num != 0)
				{
				}
				num = (short)1797193728;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582.HiddenDynamic;
			}
			set
			{
				short num = (short)1572200669;
				short num2 = num;
				num = (short)1945362653;
				switch (num2 == num)
				{
				}
				num = (short)1743323136;
				if (num != 0)
				{
				}
				num = (short)2063532033;
				if (num != 0)
				{
				}
				num = (short)634257408;
				short num3 = num;
				this.acknowledgedWeaponFiredEventReportingEnable_43582.HiddenDynamic = value;
			}
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x0600A641 RID: 42561 RVA: 0x009ADAFC File Offset: 0x009ABCFC
		public bool AcknowledgedWeaponFiredEventReportingEnable_43582_HasDiffs
		{
			get
			{
				short num = (short)1511766454;
				short num2 = num;
				num = (short)288274870;
				switch (num2 == num)
				{
				}
				num = (short)1714094081;
				if (num != 0)
				{
				}
				num = (short)1451753472;
				if (num != 0)
				{
				}
				num = (short)1098973184;
				short num3 = num;
				return this.acknowledgedWeaponFiredEventReportingEnable_43582._HasDiffs;
			}
		}

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x0600A642 RID: 42562 RVA: 0x009ADBB0 File Offset: 0x009ABDB0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1175846913;
				if (num != 0)
				{
				}
				num = (short)1487777740;
				short num2 = num;
				num = (short)131641292;
				switch (num2 == num)
				{
				}
				num = (short)1757020160;
				if (num != 0)
				{
				}
				num = (short)1286209536;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x0600A643 RID: 42563 RVA: 0x009ADC6C File Offset: 0x009ABE6C
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1307017565;
				short num2 = num;
				num = (short)1923121501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683802624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625541120;
				if (num != 0)
				{
				}
				num = (short)1263665153;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x009ADD2C File Offset: 0x009ABF2C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)2119630848;
					short num3 = num2;
					num2 = (short)116326401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)988610563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1298006016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)427950084;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_100;
				}
				goto IL_24;
			}
			IL_100:
			return result;
			IL_24:
			result = null;
			num2 = (short)122760081;
			short num4 = num2;
			num2 = (short)829500305;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)1851588608;
				if (num2 != 0)
				{
				}
				num2 = (short)1165230081;
				if (num2 != 0)
				{
				}
				num2 = (short)1328349186;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04005108 RID: 20744
		private global::AcpBusinessLayer.AcpField<bool> dataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04005109 RID: 20745
		private global::AcpBusinessLayer.AcpField<bool> dataWideGeneralICMPEcho_A8219;

		// Token: 0x0400510A RID: 20746
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x0400510B RID: 20747
		private global::AcpBusinessLayer.AcpField<bool> dataWideGeneralSNMPTraps_A9166;

		// Token: 0x0400510C RID: 20748
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x0400510D RID: 20749
		private global::AcpBusinessLayer.AcpListField dataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x0400510E RID: 20750
		private global::AcpBusinessLayer.AcpListField dataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x0400510F RID: 20751
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04005110 RID: 20752
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04005111 RID: 20753
		private global::AcpBusinessLayer.AcpListField dataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04005112 RID: 20754
		private global::AcpBusinessLayer.AcpField<bool> dataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04005113 RID: 20755
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04005114 RID: 20756
		private global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04005115 RID: 20757
		private global::AcpBusinessLayer.AcpFieldX<long, string> dataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04005116 RID: 20758
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04005117 RID: 20759
		private global::AcpBusinessLayer.AcpField<bool> directTMSContentDisplay_42323;

		// Token: 0x04005118 RID: 20760
		private global::AcpBusinessLayer.AcpField<bool> dataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04005119 RID: 20761
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x0400511A RID: 20762
		private global::AcpBusinessLayer.AcpField<bool> sensorMeasurementReporting_A43021;

		// Token: 0x0400511B RID: 20763
		private global::AcpBusinessLayer.AcpField<bool> acknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x0400511C RID: 20764
		private global::AcpBusinessLayer.AcpField<bool> acknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x0400511D RID: 20765
		private global::AcpBusinessLayer.AcpField<bool> acknowledgedWeaponFiredEventReportingEnable_43582;
	}
}
