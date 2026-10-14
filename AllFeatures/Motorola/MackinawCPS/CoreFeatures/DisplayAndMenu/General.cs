using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028C RID: 652
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060070FC RID: 28924 RVA: 0x0064AADC File Offset: 0x00648CDC
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x0064AAF8 File Offset: 0x00648CF8
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x0064AB10 File Offset: 0x00648D10
		public override void Init()
		{
			int a_ = 2;
			short num = (short)2129002497;
			if (num != 0)
			{
			}
			num = (short)891921554;
			short num2 = num;
			num = (short)1907401874;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1987051520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1035206656;
			if (num != 0)
			{
			}
			this.dispMenuGeneralChannelTextSize_A7663 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞ꋠ询蓤触蟨軪臬믮铰诲致ꓶ郸臺飼ꃾ䀀㐂㌄ㄆ㨈", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONCHANNELTEXTSIZE, 1, 14, null, null, 0, 1);
			this.dispMenuGeneralChannelTextSize_A7663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralChannelTextSize_A7663.DataTransferOrder = 4;
			this.dispMenuGeneralChannelTextSize_A7663.ShowHexValue = false;
			this.dispMenuGeneralZoneTextSize_A8167 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞믠賢诤苦뷨軪闬鯮ꋰ髲迴鋶꛸뫺염컾㜀㐂", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONZONETEXTSIZE, 0, 14, null, null, 0, 1);
			this.dispMenuGeneralZoneTextSize_A8167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralZoneTextSize_A8167.DataTransferOrder = 6;
			this.dispMenuGeneralZoneTextSize_A8167.ShowHexValue = false;
			this.dispMenuGeneralImbalancedCoverageIndicator_A8240 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞꣠転蟤蛦藨諪菬賮铰韲뛴飶迸黺迼黾昀昂䰄椆洈戊渌渎攐簒朔䠖堘⌚⼜⬞ᄠ", a_), global::CommonResources.AcgResources.ID_IMBALANCEDCOVERAGEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralImbalancedCoverageIndicator_A8240LovStrs);
			this.dispMenuGeneralImbalancedCoverageIndicator_A8240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralImbalancedCoverageIndicator_A8240.DataTransferOrder = 23;
			this.dispMenuGeneralOutofRangeIndicator_A8678 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞껠離釤裦迨맪賬臮雰雲보駶鷸鋺黼黾甀氂眄堆䠈㌊㬌㠎⤐", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralOutofRangeIndicator_A8678LovStrs);
			this.dispMenuGeneralOutofRangeIndicator_A8678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralOutofRangeIndicator_A8678.DataTransferOrder = 25;
			this.dispMenuGeneralOutOfRangeHoldOffTimer = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞껠離釤꣦迨맪賬臮雰雲뷴飶闸鿺닼駾最圂氄樆氈礊", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEHOLDOFFTIMER, 0, 120, null, null, 0, 1);
			this.dispMenuGeneralOutOfRangeHoldOffTimer.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuGeneralOutOfRangeHoldOffTimer.DataTransferOrder = 26;
			this.dispMenuGeneralOutOfRangeEarlyDetection = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞껠離釤꣦迨맪賬臮雰雲냴零诸韺蓼믾搀眂怄搆紈戊戌愎", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEEARLYDETECTION);
			this.dispMenuGeneralOutOfRangeEarlyDetection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralOutOfRangeEarlyDetection.DataTransferOrder = 27;
			this.dispMenuGeneralSearchingSiteIndicator = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞닠蛢蓤闦諨菪蓬臮雰ꃲ鳴菶鳸닺鏼鯾栀怂搄猆昈礊", a_), global::CommonResources.AcgResources.ID_SEARCHINGSITEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralSearchingSiteIndicatorLovStrs);
			this.dispMenuGeneralSearchingSiteIndicator.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuGeneralSearchingSiteIndicator.DataTransferOrder = 28;
			this.dispMenuGeneralSlowScrollCount_A9160 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞닠迢諤郦뫨裪鿬胮鷰鿲뛴飶賸闺觼ꃾ䀀㨂㐄ㄆ㤈", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONSLOWSCROLLCOUNT, 0, 255, null, null, 0, 1);
			this.dispMenuGeneralSlowScrollCount_A9160.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuGeneralSlowScrollCount_A9160.DataTransferOrder = 3;
			this.dispMenuGeneralSlowScrollCount_A9160.ShowHexValue = false;
			this.flipDisplayState_A19471 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藂꧄껆마迊꓌볎ꇐ뿒듔껖諘꿚볜ꯞ蓠볢ꓤ훦탨\udfea\udaec\udeee", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPDISPLAYORIENTATION, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.FlipDisplayState_A19471LovStrs);
			this.flipDisplayState_A19471.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.flipDisplayState_A19471.DataTransferOrder = 125;
			this.dispMenuTopChannelTextSize_A19504 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ蟒뫔Ꟗ高돚볜뇞迠蛢觤돦賨鏪駬볮飰觲郴ꣶ룸쫺쓼쫾㄀㜂", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPCHANNELTEXTSIZE, 0, 8, null, null, 0, 1);
			this.dispMenuTopChannelTextSize_A19504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuTopChannelTextSize_A19504.DataTransferOrder = 29;
			this.dispMenuTopChannelTextSize_A19504.ShowHexValue = false;
			this.dispMenuGeneralTopZoneTextSize_A19769 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞뗠賢闤뷦蛨藪裬믮铰诲致ꓶ郸臺飼ꃾ䀀㈂㰄〆㼈㈊", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPZONETEXTSIZE, 0, 8, null, null, 0, 1);
			this.dispMenuGeneralTopZoneTextSize_A19769.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuGeneralTopZoneTextSize_A19769.DataTransferOrder = 30;
			this.dispMenuGeneralTopZoneTextSize_A19769.ShowHexValue = false;
			this.dRSMFlipDisplayState_A24778 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂韄铆蓈跊ꇌꛎꇐ韒볔ꓖ꧘럚볜ꛞ닠韢蓤鏦賨듪곬\uddee연쓲싴쿶", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONDRSMDISPLAYORIENTATION, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DRSMFlipDisplayState_A24778LovStrs);
			this.dRSMFlipDisplayState_A24778.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dRSMFlipDisplayState_A24778.DataTransferOrder = 126;
			this.radErgoWideStealthSaveDayNightMode_A36492 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ蛐뫒뇔닖諘꿚룜뻞跠韢跤듦裨鷪裬꯮郰諲믴黶黸鏺觼닾渀朂怄堆䠈㠊㬌㬎⠐ℒ", a_), global::CommonResources.AcgResources.ID_SAVEDAYNIGHTMODE);
			this.radErgoWideStealthSaveDayNightMode_A36492.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideStealthSaveDayNightMode_A36492.DataTransferOrder = 60;
			this.radErgoDisGeneralSysRegIndicator_A37603 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ闐뫒ꛔ郖볘뗚룜귞胠迢뛤黦髨맪裬裮룰鷲釴黶髸髺觼郾猀専䐄㐆㸈㴊㴌㰎", a_), global::CommonResources.AcgResources.ID_SYSTEMREGISTRATIONINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoDisGeneralSysRegIndicator_A37603LovStrs);
			this.radErgoDisGeneralSysRegIndicator_A37603.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoDisGeneralSysRegIndicator_A37603.DataTransferOrder = 128;
			this.dispMenuGeneralSiteTrunkingIndicator_A7426 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞닠諢釤苦뷨駪飬臮髰髲鯴郶냸闺駼雾戀戂焄栆笈吊䰌㠎┐ℒ⌔", a_), global::CommonResources.AcgResources.ID_SITETRUNKINGINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralSiteTrunkingIndicator_A7426LovStrs);
			this.dispMenuGeneralSiteTrunkingIndicator_A7426.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuGeneralSiteTrunkingIndicator_A7426.DataTransferOrder = 22;
			this.dispMenuGeneralFastScrollRatems_A8014 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞꟠苢雤鏦뫨裪鿬胮鷰鿲ꟴ零跸黺郼賾帀䈂㴄㜆㠈㼊", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONFASTSCROLLRATEMS, 10, 250, 10);
			this.dispMenuGeneralFastScrollRatems_A8014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuGeneralFastScrollRatems_A8014.DataTransferOrder = 1;
			this.dispMenuGeneralFastScrollRatems_A8014.ShowHexValue = false;
			this.dispMenuGeneralSlowScrollRatems_A9161 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ铒냔맖볘꧚볜돞닠迢諤郦뫨裪鿬胮鷰鿲ꟴ零跸黺郼賾帀䈂㰄㘆㼈㨊", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONSLOWSCROLLRATEMS, 10, 250, 10);
			this.dispMenuGeneralSlowScrollRatems_A9161.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuGeneralSlowScrollRatems_A9161.DataTransferOrder = 2;
			this.dispMenuGeneralSlowScrollRatems_A9161.ShowHexValue = false;
			this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐뗒닔鏖냘꣚규돞胠髢ꋤ苦蟨軪鿬軮鷰뿲髴银飸韺닼釾洀稂䰄椆洈戊渌渎攐簒朔䠖堘⼚ⴜ⸞ᜠጢ", a_), global::CommonResources.AcgResources.ID_DVRSLOCALONLYINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160LovStrs);
			this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.DataTransferOrder = 129;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓂ꃄ꧆곈맊곌ꏎ", a_);
			base.Id = 10020;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x0064B0BC File Offset: 0x006492BC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)2041380921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕鯗볙믛髝觟釡铣諥觧鏩꯫语黯韱蛳韵铷뛹鏻鷽懿渁䬃栅搇猉䔋怍琏笑眓眕気甙減䄝感ᘡᐣᜥḧᨩ", a_)))
					{
						num = (short)1652555802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E1C;
				case 1:
					goto IL_99C;
				case 2:
					goto IL_9E9;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧迩跫鳭鏯髱鷳飵鿷꧹闻諽旿䬁樃戅愇椉洋稍缏怑", a_)))
					{
						num = (short)1165164550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_768;
				case 4:
					goto IL_3B7;
				case 5:
					goto IL_B85;
				case 6:
					this.dispMenuGeneralSearchingSiteIndicator = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧迩跫鳭鏯髱鷳飵鿷꧹闻諽旿䬁樃戅愇椉洋稍缏怑", a_), global::CommonResources.AcgResources.ID_SEARCHINGSITEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralSearchingSiteIndicatorLovStrs);
					this.dispMenuGeneralSearchingSiteIndicator.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuGeneralSearchingSiteIndicator.DataTransferOrder = 28;
					num = (short)631701551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_401;
				case 8:
					this.dispMenuGeneralImbalancedCoverageIndicator_A8240 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥ꇧ蟩軫迭鳯鏱髳闵鷷黹뿻釽盿朁瘃朅漇漉䔋怍琏笑眓眕気甙減䄝感ᨡᘣሥᠧ", a_), global::CommonResources.AcgResources.ID_IMBALANCEDCOVERAGEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralImbalancedCoverageIndicator_A8240LovStrs);
					this.dispMenuGeneralImbalancedCoverageIndicator_A8240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralImbalancedCoverageIndicator_A8240.DataTransferOrder = 23;
					num = (short)1772224540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧蛩菫駭ꏯ釱蛳駵铷雹뿻釽痿氁瀃夅䤇㌉㴋㠍‏", a_)))
					{
						num = (short)1743519781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C78;
				case 10:
					this.radErgoWideStealthSaveDayNightMode_A36492 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝돟雡臣蟥蓧黩蓫뷭釯蓱釳답駷菹닻韽柿樁瀃䬅朇渉椋儍儏ℑ∓∕℗⠙", a_), global::CommonResources.AcgResources.ID_SAVEDAYNIGHTMODE);
					this.radErgoWideStealthSaveDayNightMode_A36492.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideStealthSaveDayNightMode_A36492.DataTransferOrder = 60;
					num = (short)221052945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_CC4;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧菩飫语ꓯ胱至飵鏷鏹鋻駽䧿氁怃漅欇欉砋愍戏䴑唓ℕⰗ⠙⨛", a_)))
					{
						num = (short)1716453390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6BD;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賉ꃋꟍꃏ雑뷓ꗕ꣗뛙뷛꟝돟雡藣鋥跧뗩귫\udfed짯웱쏳쟵", a_)))
					{
						num = (short)752091152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B7;
				case 14:
					this.dispMenuGeneralSiteTrunkingIndicator_A7426 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧菩飫语ꓯ胱至飵鏷鏹鋻駽䧿氁怃漅欇欉砋愍戏䴑唓ℕⰗ⠙⨛", a_), global::CommonResources.AcgResources.ID_SITETRUNKINGINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralSiteTrunkingIndicator_A7426LovStrs);
					this.dispMenuGeneralSiteTrunkingIndicator_A7426.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralSiteTrunkingIndicator_A7426.DataTransferOrder = 22;
					num = (short)1800208438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.radErgoDisGeneralSysRegIndicator_A37603 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕鳗동꿛駝藟賡臣铥觧蛩뿫韭華ꃱ釳釵뇷铹飻韽揿持瀃椅稇唉䴋㴍✏␑␓┕", a_), global::CommonResources.AcgResources.ID_SYSTEMREGISTRATIONINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoDisGeneralSysRegIndicator_A37603LovStrs);
					this.radErgoDisGeneralSysRegIndicator_A37603.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoDisGeneralSysRegIndicator_A37603.DataTransferOrder = 128;
					num = (short)805503021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.flipDisplayState_A19471 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("賉ꃋꟍꃏ雑뷓ꗕ꣗뛙뷛꟝돟雡藣鋥跧뗩귫\udfed짯웱쏳쟵", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPDISPLAYORIENTATION, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.FlipDisplayState_A19471LovStrs);
					this.flipDisplayState_A19471.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.flipDisplayState_A19471.DataTransferOrder = 125;
					num = (short)2086273028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_DD0;
				case 18:
					goto IL_864;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫臭雯ꃱ闳飵鿷鿹뗻都擿欁會朅簇攉縋儍儏⨑∓ℕ‗", a_)))
					{
						num = (short)2128674841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B1;
				case 20:
					this.dispMenuGeneralChannelTextSize_A7663 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥ꯧ苩跫胭黯韱飳ꋵ鷷苹裻귽槿码愃夅䤇㴉㨋㠍⌏", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONCHANNELTEXTSIZE, null, null, 0, 1);
					this.dispMenuGeneralChannelTextSize_A7663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralChannelTextSize_A7663.DataTransferOrder = 4;
					this.dispMenuGeneralChannelTextSize_A7663.ShowHexValue = false;
					num = (short)369885186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_611;
				case 22:
					goto IL_8B1;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹듻釽泿昁䬃怅渇帉攋挍甏怑", a_)))
					{
						num = (short)723255345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_864;
				case 24:
				{
					this.dispMenuGeneralTopZoneTextSize_A19769 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥볧藩鳫듭鿯鳱釳ꋵ鷷苹裻귽槿码愃夅䤇㬉㔋㤍☏⬑", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPZONETEXTSIZE, null, null, 0, 1);
					this.dispMenuGeneralTopZoneTextSize_A19769.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuGeneralTopZoneTextSize_A19769.DataTransferOrder = 30;
					this.dispMenuGeneralTopZoneTextSize_A19769.ShowHexValue = false;
					num = (short)640617934;
					short num3 = num;
					num = (short)59903438;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_401;
					default:
						num = (short)966328320;
						if (num != 0)
						{
						}
						num = (short)1529806849;
						if (num != 0)
						{
						}
						num = (short)1337458729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
					this.dispMenuGeneralOutofRangeIndicator_A8678 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫臭雯ꃱ闳飵鿷鿹뗻都擿欁會朅簇攉縋儍儏⨑∓ℕ‗", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuGeneralOutofRangeIndicator_A8678LovStrs);
					this.dispMenuGeneralOutofRangeIndicator_A8678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralOutofRangeIndicator_A8678.DataTransferOrder = 25;
					num = (short)987955222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕鯗볙믛髝觟釡铣諥觧鏩꯫语黯韱蛳韵铷뛹鏻鷽懿渁䬃栅搇猉䔋怍琏笑眓眕気甙減䄝感ᘡᐣᜥḧᨩ", a_), global::CommonResources.AcgResources.ID_DVRSLOCALONLYINDICATOR, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160LovStrs);
					this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.DataTransferOrder = 129;
					num = (short)161153072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.dispMenuGeneralOutOfRangeEarlyDetection = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹맻鿽狿渁紃䈅洇縉椋洍搏笑笓砕", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEEARLYDETECTION);
					this.dispMenuGeneralOutOfRangeEarlyDetection.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralOutOfRangeEarlyDetection.DataTransferOrder = 27;
					num = (short)1847066625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_1EF;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥ꯧ苩跫胭黯韱飳ꋵ鷷苹裻귽槿码愃夅䤇㴉㨋㠍⌏", a_)))
					{
						num = (short)1196228628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E9;
				case 30:
					num = (short)1948975143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉黋鷍鷏铑룓뿕꣗黙뗛귝郟軡藣鿥믧黩跫髭闯귱뗳쓵쳷췹쯻웽", a_)))
					{
						num = (short)1320419379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13E;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕鳗동꿛駝藟賡臣铥觧蛩뿫韭華ꃱ釳釵뇷铹飻韽揿持瀃椅稇唉䴋㴍✏␑␓┕", a_)))
					{
						num = (short)2017591311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8FD;
				case 33:
					num = (short)427229213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥껧诩鿫髭ꏯ釱蛳駵铷雹껻鿽瓿朁椃甅圇䬉㐋㸍ℏ☑", a_)))
					{
						num = (short)446103595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C2E;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥ꇧ蟩軫迭鳯鏱髳闵鷷黹뿻釽盿朁瘃朅漇漉䔋怍琏笑眓眕気甙減䄝感ᨡᘣሥᠧ", a_)))
					{
						num = (short)1842937864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				case 36:
					this.dispMenuGeneralSlowScrollRatems_A9161 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧蛩菫駭ꏯ釱蛳駵铷雹껻鿽瓿朁椃甅圇䬉㔋㼍☏⌑", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONSLOWSCROLLRATEMS);
					this.dispMenuGeneralSlowScrollRatems_A9161.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuGeneralSlowScrollRatems_A9161.DataTransferOrder = 2;
					this.dispMenuGeneralSlowScrollRatems_A9161.ShowHexValue = false;
					num = (short)1796472843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.dispMenuGeneralSlowScrollCount_A9160 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧蛩菫駭ꏯ釱蛳駵铷雹뿻釽痿氁瀃夅䤇㌉㴋㠍‏", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONSLOWSCROLLCOUNT, null, null, 0, 1);
					this.dispMenuGeneralSlowScrollCount_A9160.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuGeneralSlowScrollCount_A9160.DataTransferOrder = 3;
					this.dispMenuGeneralSlowScrollCount_A9160.ShowHexValue = false;
					num = (short)1232207927;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹맻鿽狿渁紃䈅洇縉椋洍搏笑笓砕", a_)))
					{
						num = (short)1165885467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99C;
				case 39:
					if (producerFields != null)
					{
						num = (short)1605959713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E1C;
				case 40:
					goto IL_13E;
				case 41:
					goto IL_816;
				case 42:
					goto IL_C2E;
				case 43:
					this.dispMenuGeneralFastScrollRatems_A8014 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥껧诩鿫髭ꏯ釱蛳駵铷雹껻鿽瓿朁椃甅圇䬉㐋㸍ℏ☑", a_), global::CommonResources.AcgResources.ID_SCROLLCONFIGURATIONFASTSCROLLRATEMS);
					this.dispMenuGeneralFastScrollRatems_A8014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuGeneralFastScrollRatems_A8014.DataTransferOrder = 1;
					this.dispMenuGeneralFastScrollRatems_A8014.ShowHexValue = false;
					num = (short)459669546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥믧蛩菫駭ꏯ釱蛳駵铷雹껻鿽瓿朁椃甅圇䬉㔋㼍☏⌑", a_)))
					{
						num = (short)574554148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC4;
				case 45:
					goto IL_8FD;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥닧藩苫语ꓯ韱賳苵꯷鏹蛻鯽忿䌁㰃㜅㸇㴉", a_)))
					{
						num = (short)923861042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_611;
				case 47:
					goto IL_768;
				case 48:
					goto IL_51E;
				case 49:
					this.dispMenuGeneralOutOfRangeHoldOffTimer = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥꟧鿩飫ꇭ雯ꃱ闳飵鿷鿹듻釽泿昁䬃怅渇帉攋挍甏怑", a_), global::CommonResources.AcgResources.ID_OUTOFRANGEHOLDOFFTIMER, 0, 120, null, null, 0, 1);
					this.dispMenuGeneralOutOfRangeHoldOffTimer.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuGeneralOutOfRangeHoldOffTimer.DataTransferOrder = 26;
					num = (short)619380754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
				{
					num = (short)1896415232;
					short num4 = num;
					this.dispMenuGeneralZoneTextSize_A8167 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥닧藩苫语ꓯ韱賳苵꯷鏹蛻鯽忿䌁㰃㜅㸇㴉", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONZONETEXTSIZE, null, null, 0, 1);
					this.dispMenuGeneralZoneTextSize_A8167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuGeneralZoneTextSize_A8167.DataTransferOrder = 6;
					this.dispMenuGeneralZoneTextSize_A8167.ShowHexValue = false;
					num = (short)791478293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 51:
					this.dRSMFlipDisplayState_A24778 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉黋鷍鷏铑룓뿕꣗黙뗛귝郟軡藣鿥믧黩跫髭闯귱뗳쓵쳷췹쯻웽", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONDRSMDISPLAYORIENTATION, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DRSMFlipDisplayState_A24778LovStrs);
					this.dRSMFlipDisplayState_A24778.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dRSMFlipDisplayState_A24778.DataTransferOrder = 126;
					num = (short)1715601448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝돟雡臣蟥蓧黩蓫뷭釯蓱釳답駷菹닻韽柿樁瀃䬅朇渉椋儍儏ℑ∓∕℗⠙", a_)))
					{
						num = (short)271974410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD0;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗鷙맛냝藟郡藣諥볧藩鳫듭鿯鳱釳ꋵ鷷苹裻귽槿码愃夅䤇㬉㔋㤍☏⬑", a_)))
					{
						num = (short)1826029592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_816;
				case 54:
					goto IL_6BD;
				case 55:
					goto IL_C78;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗軙돛껝ꏟ諡藣裥蛧迩胫뫭闯諱胳ꗵ釷胹駻ꇽ䇿㌁㴃㌅㠇㸉", a_)))
					{
						num = (short)1627258887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B85;
				case 57:
					switch (0)
					{
					case 0:
						goto IL_116;
					}
					continue;
				}
				IL_116:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1946353694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13E:
				num = (short)1162346548;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EF:
				num = (short)1339359251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B7:
				num = (short)2119368760;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_401:
				this.dispMenuTopChannelTextSize_A19504 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗軙돛껝ꏟ諡藣裥蛧迩胫뫭闯諱胳ꗵ釷胹駻ꇽ䇿㌁㴃㌅㠇㸉", a_), global::CommonResources.AcgResources.ID_TEXTCONFIGURATIONTOPCHANNELTEXTSIZE, null, null, 0, 1);
				this.dispMenuTopChannelTextSize_A19504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.dispMenuTopChannelTextSize_A19504.DataTransferOrder = 29;
				this.dispMenuTopChannelTextSize_A19504.ShowHexValue = false;
				num = (short)441122821;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_611:
				num = (short)680656931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6BD:
				num = (short)1594097698;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_768:
				num = (short)1078722569;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_816:
				num = (short)2054946847;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_864:
				num = (short)569311270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B1:
				num = (short)741081111;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8FD:
				num = (short)1854734348;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_99C:
				num = (short)1596325891;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9E9:
				num = (short)53018670;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B85:
				num = (short)1411645493;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C2E:
				num = (short)1801453612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C78:
				num = (short)97648653;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC4:
				num = (short)1947860992;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DD0:
				num = (short)612106272;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_51E:
			IL_E1C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跉꧋ꃍ뗏ꃑ뗓뫕", a_);
			base.Id = 10020;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x0064BF18 File Offset: 0x0064A118
		public override void PopulateReferences()
		{
			short num = (short)2033713152;
			short num2 = num;
			num = (short)1125313996;
			short num3 = num;
			num = (short)1287581132;
			switch (num3 == num)
			{
			}
			num = (short)843317249;
			if (num != 0)
			{
			}
			num = (short)319029248;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x0064BFC0 File Offset: 0x0064A1C0
		public override void DropReferences()
		{
			short num = (short)160497664;
			short num2 = num;
			num = (short)1965283361;
			short num3 = num;
			num = (short)229759009;
			switch (num3 == num)
			{
			}
			num = (short)1933770753;
			if (num != 0)
			{
			}
			num = (short)1429274624;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x0064C068 File Offset: 0x0064A268
		public override void SetConstraints()
		{
			short num = (short)1566834688;
			short num2 = num;
			num = (short)1831610894;
			short num3 = num;
			num = (short)1470507534;
			switch (num3 == num)
			{
			}
			num = (short)1591476224;
			if (num != 0)
			{
			}
			num = (short)895811585;
			if (num != 0)
			{
			}
			this.radErgoWideStealthSaveDayNightMode_A36492.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConSaveDayNightModeApp);
			this.dispMenuGeneralFastScrollRatems_A8014.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConSetUpperLimitAsSlowScrollRate);
			this.dispMenuGeneralSlowScrollRatems_A9161.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConSetUpperLimitAsSlowScrollRate);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x0064C158 File Offset: 0x0064A358
		public override void SetupDependencies()
		{
			short num = (short)787808256;
			short num2 = num;
			num = (short)1807518091;
			short num3 = num;
			num = (short)435325323;
			switch (num3 == num)
			{
			}
			num = (short)793247745;
			if (num != 0)
			{
			}
			num = (short)1371078656;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideStealthSaveDayNightMode_A36492);
			this.dispMenuGeneralSlowScrollRatems_A9161.AddDependentObject(this.dispMenuGeneralFastScrollRatems_A8014);
			this.dispMenuGeneralFastScrollRatems_A8014.AddDependentObject(this.dispMenuGeneralSlowScrollRatems_A9161);
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x06007104 RID: 28932 RVA: 0x0064C240 File Offset: 0x0064A440
		public bool HasDiffs
		{
			get
			{
				short num = (short)3080192;
				short num2 = num;
				num = (short)996325170;
				short num3 = num;
				num = (short)1258993458;
				switch (num3 == num)
				{
				}
				num = (short)267124736;
				if (num != 0)
				{
				}
				num = (short)1984823297;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x0064C2EC File Offset: 0x0064A4EC
		// (set) Token: 0x06007106 RID: 28934 RVA: 0x0064C3A0 File Offset: 0x0064A5A0
		public int DispMenuGeneralChannelTextSize_A7663Value
		{
			get
			{
				short num = (short)792526848;
				short num2 = num;
				num = (short)568886631;
				short num3 = num;
				num = (short)667977063;
				switch (num3 == num)
				{
				}
				num = (short)1268580353;
				if (num != 0)
				{
				}
				num = (short)2066415616;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Value;
			}
			set
			{
				short num = (short)1395392512;
				short num2 = num;
				num = (short)1771241473;
				if (num != 0)
				{
				}
				num = (short)59101497;
				short num3 = num;
				num = (short)78500153;
				switch (num3 == num)
				{
				}
				num = (short)522715136;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Value = value;
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x06007107 RID: 28935 RVA: 0x0064C454 File Offset: 0x0064A654
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuGeneralChannelTextSize_A7663
		{
			get
			{
				short num = (short)1720975360;
				short num2 = num;
				num = (short)941151939;
				short num3 = num;
				num = (short)162518723;
				switch (num3 == num)
				{
				}
				num = (short)1200488448;
				if (num != 0)
				{
				}
				num = (short)1414725633;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663;
			}
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x0064C504 File Offset: 0x0064A704
		// (set) Token: 0x06007109 RID: 28937 RVA: 0x0064C5B8 File Offset: 0x0064A7B8
		public string DispMenuGeneralChannelTextSize_A7663_UIValue
		{
			get
			{
				short num = (short)1480982528;
				short num2 = num;
				num = (short)1898119169;
				if (num != 0)
				{
				}
				num = (short)1688381920;
				short num3 = num;
				num = (short)161524192;
				switch (num3 == num)
				{
				}
				num = (short)2040987648;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.UIValue;
			}
			set
			{
				short num = (short)748224512;
				short num2 = num;
				num = (short)422117377;
				if (num != 0)
				{
				}
				num = (short)1816605275;
				short num3 = num;
				num = (short)1755001435;
				switch (num3 == num)
				{
				}
				num = (short)1998454784;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.UIValue = value;
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x0064C670 File Offset: 0x0064A870
		// (set) Token: 0x0600710B RID: 28939 RVA: 0x0064C724 File Offset: 0x0064A924
		internal int DispMenuGeneralChannelTextSize_A7663Min
		{
			get
			{
				short num = (short)1541275648;
				short num2 = num;
				num = (short)1755430145;
				short num3 = num;
				num = (short)1691139329;
				switch (num3 == num)
				{
				}
				num = (short)172359681;
				if (num != 0)
				{
				}
				num = (short)397148160;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Min;
			}
			set
			{
				short num = (short)332267520;
				short num2 = num;
				num = (short)451233167;
				short num3 = num;
				num = (short)1917207951;
				switch (num3 == num)
				{
				}
				num = (short)27000833;
				if (num != 0)
				{
				}
				num = (short)1669726208;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Min = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600710C RID: 28940 RVA: 0x0064C7D8 File Offset: 0x0064A9D8
		// (set) Token: 0x0600710D RID: 28941 RVA: 0x0064C890 File Offset: 0x0064AA90
		internal int DispMenuGeneralChannelTextSize_A7663Max
		{
			get
			{
				short num = (short)1078591488;
				short num2 = num;
				num = (short)779867843;
				short num3 = num;
				num = (short)1327486659;
				switch (num3 == num)
				{
				}
				num = (short)1870528513;
				if (num != 0)
				{
				}
				num = (short)1416298496;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Max;
			}
			set
			{
				short num = (short)2127626240;
				short num2 = num;
				num = (short)1100218369;
				if (num != 0)
				{
				}
				num = (short)438468323;
				short num3 = num;
				num = (short)338329315;
				switch (num3 == num)
				{
				}
				num = (short)1806630912;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Max = value;
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600710E RID: 28942 RVA: 0x0064C948 File Offset: 0x0064AB48
		// (set) Token: 0x0600710F RID: 28943 RVA: 0x0064C9FC File Offset: 0x0064ABFC
		internal int DispMenuGeneralChannelTextSize_A7663Step
		{
			get
			{
				short num = (short)1612382208;
				short num2 = num;
				num = (short)1513043652;
				short num3 = num;
				num = (short)1964127940;
				switch (num3 == num)
				{
				}
				num = (short)374013953;
				if (num != 0)
				{
				}
				num = (short)1435828224;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.StepSize;
			}
			set
			{
				short num = (short)41353216;
				short num2 = num;
				num = (short)657719297;
				if (num != 0)
				{
				}
				num = (short)1039629154;
				short num3 = num;
				num = (short)956529506;
				switch (num3 == num)
				{
				}
				num = (short)929628160;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.StepSize = value;
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x06007110 RID: 28944 RVA: 0x0064CAB0 File Offset: 0x0064ACB0
		// (set) Token: 0x06007111 RID: 28945 RVA: 0x0064CB68 File Offset: 0x0064AD68
		public bool DispMenuGeneralChannelTextSize_A7663_Applicable
		{
			get
			{
				short num = (short)1846214656;
				short num2 = num;
				num = (short)290755887;
				short num3 = num;
				num = (short)1547081007;
				switch (num3 == num)
				{
				}
				num = (short)2012086273;
				if (num != 0)
				{
				}
				num = (short)605093888;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Applicable;
			}
			set
			{
				short num = (short)1166606336;
				short num2 = num;
				num = (short)1731511186;
				short num3 = num;
				num = (short)540918674;
				switch (num3 == num)
				{
				}
				num = (short)1634271233;
				if (num != 0)
				{
				}
				num = (short)761004032;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Applicable = value;
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x06007112 RID: 28946 RVA: 0x0064CC1C File Offset: 0x0064AE1C
		// (set) Token: 0x06007113 RID: 28947 RVA: 0x0064CCD0 File Offset: 0x0064AED0
		public bool DispMenuGeneralChannelTextSize_A7663_Valid
		{
			get
			{
				short num = (short)1295450112;
				short num2 = num;
				num = (short)829736926;
				short num3 = num;
				num = (short)779601886;
				switch (num3 == num)
				{
				}
				num = (short)2096300032;
				if (num != 0)
				{
				}
				num = (short)1246887937;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Valid;
			}
			set
			{
				short num = (short)1146748928;
				short num2 = num;
				num = (short)959709185;
				if (num != 0)
				{
				}
				num = (short)419004079;
				short num3 = num;
				num = (short)126647983;
				switch (num3 == num)
				{
				}
				num = (short)1931149312;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Valid = value;
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x06007114 RID: 28948 RVA: 0x0064CD84 File Offset: 0x0064AF84
		// (set) Token: 0x06007115 RID: 28949 RVA: 0x0064CE38 File Offset: 0x0064B038
		public bool DispMenuGeneralChannelTextSize_A7663_Visible
		{
			get
			{
				short num = (short)1197604864;
				short num2 = num;
				num = (short)960021504;
				short num3 = num;
				num = (short)762561536;
				switch (num3 == num)
				{
				}
				num = (short)1867448320;
				if (num != 0)
				{
				}
				num = (short)2047016961;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Visible;
			}
			set
			{
				short num = (short)547946496;
				short num2 = num;
				num = (short)98061505;
				short num3 = num;
				num = (short)650267841;
				switch (num3 == num)
				{
				}
				num = (short)1932656640;
				if (num != 0)
				{
				}
				num = (short)1256062977;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Visible = value;
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x06007116 RID: 28950 RVA: 0x0064CEF0 File Offset: 0x0064B0F0
		// (set) Token: 0x06007117 RID: 28951 RVA: 0x0064CFA4 File Offset: 0x0064B1A4
		public bool DispMenuGeneralChannelTextSize_A7663_Editable
		{
			get
			{
				short num = (short)1877409792;
				short num2 = num;
				num = (short)967966721;
				if (num != 0)
				{
				}
				num = (short)837452952;
				short num3 = num;
				num = (short)878871704;
				switch (num3 == num)
				{
				}
				num = (short)1016791040;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.Editable;
			}
			set
			{
				short num = (short)1159659520;
				short num2 = num;
				num = (short)893660555;
				short num3 = num;
				num = (short)1545022859;
				switch (num3 == num)
				{
				}
				num = (short)1559953409;
				if (num != 0)
				{
				}
				num = (short)834928640;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.Editable = value;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x0064D058 File Offset: 0x0064B258
		internal string DispMenuGeneralChannelTextSize_A7663_UILabel
		{
			get
			{
				short num = (short)1331560448;
				short num2 = num;
				num = (short)1305380831;
				short num3 = num;
				num = (short)1590134751;
				switch (num3 == num)
				{
				}
				num = (short)1641611264;
				if (num != 0)
				{
				}
				num = (short)407699457;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.UIName;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x0064D10C File Offset: 0x0064B30C
		// (set) Token: 0x0600711A RID: 28954 RVA: 0x0064D1C0 File Offset: 0x0064B3C0
		internal bool DispMenuGeneralChannelTextSize_A7663_HiddenStatic
		{
			get
			{
				short num = (short)379453440;
				short num2 = num;
				num = (short)990614182;
				short num3 = num;
				num = (short)1028625062;
				switch (num3 == num)
				{
				}
				num = (short)291700736;
				if (num != 0)
				{
				}
				num = (short)1587412993;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.HiddenStatic;
			}
			set
			{
				short num = (short)1949630464;
				short num2 = num;
				num = (short)2032413989;
				short num3 = num;
				num = (short)1251814693;
				switch (num3 == num)
				{
				}
				num = (short)598671361;
				if (num != 0)
				{
				}
				num = (short)1856372736;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.HiddenStatic = value;
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600711B RID: 28955 RVA: 0x0064D274 File Offset: 0x0064B474
		// (set) Token: 0x0600711C RID: 28956 RVA: 0x0064D328 File Offset: 0x0064B528
		internal bool DispMenuGeneralChannelTextSize_A7663_HiddenDynamic
		{
			get
			{
				short num = (short)2027618304;
				short num2 = num;
				num = (short)298095187;
				short num3 = num;
				num = (short)1602130515;
				switch (num3 == num)
				{
				}
				num = (short)1286602752;
				if (num != 0)
				{
				}
				num = (short)561315841;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663.HiddenDynamic;
			}
			set
			{
				short num = (short)1324023808;
				short num2 = num;
				num = (short)1389326476;
				short num3 = num;
				num = (short)676360332;
				switch (num3 == num)
				{
				}
				num = (short)1508048896;
				if (num != 0)
				{
				}
				num = (short)69664769;
				if (num != 0)
				{
				}
				this.dispMenuGeneralChannelTextSize_A7663.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x0064D3E0 File Offset: 0x0064B5E0
		public bool DispMenuGeneralChannelTextSize_A7663_HasDiffs
		{
			get
			{
				short num = (short)1483145216;
				short num2 = num;
				num = (short)1785326075;
				short num3 = num;
				num = (short)42461691;
				switch (num3 == num)
				{
				}
				num = (short)1384316929;
				if (num != 0)
				{
				}
				num = (short)534315008;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralChannelTextSize_A7663._HasDiffs;
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600711E RID: 28958 RVA: 0x0064D498 File Offset: 0x0064B698
		// (set) Token: 0x0600711F RID: 28959 RVA: 0x0064D54C File Offset: 0x0064B74C
		public int DispMenuGeneralZoneTextSize_A8167Value
		{
			get
			{
				short num = (short)1153105920;
				short num2 = num;
				num = (short)744423425;
				if (num != 0)
				{
				}
				num = (short)639184298;
				short num3 = num;
				num = (short)1186672042;
				switch (num3 == num)
				{
				}
				num = (short)1468530688;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Value;
			}
			set
			{
				short num = (short)271843328;
				short num2 = num;
				num = (short)148179075;
				short num3 = num;
				num = (short)1639516291;
				switch (num3 == num)
				{
				}
				num = (short)104923137;
				if (num != 0)
				{
				}
				num = (short)749404160;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Value = value;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x06007120 RID: 28960 RVA: 0x0064D600 File Offset: 0x0064B800
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuGeneralZoneTextSize_A8167
		{
			get
			{
				short num = (short)831324160;
				short num2 = num;
				num = (short)1137704961;
				if (num != 0)
				{
				}
				num = (short)185460313;
				short num3 = num;
				num = (short)509601369;
				switch (num3 == num)
				{
				}
				num = (short)698679296;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167;
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x0064D6B0 File Offset: 0x0064B8B0
		// (set) Token: 0x06007122 RID: 28962 RVA: 0x0064D764 File Offset: 0x0064B964
		public string DispMenuGeneralZoneTextSize_A8167_UIValue
		{
			get
			{
				short num = (short)350027776;
				short num2 = num;
				num = (short)565641217;
				if (num != 0)
				{
				}
				num = (short)36627136;
				short num3 = num;
				num = (short)34202304;
				switch (num3 == num)
				{
				}
				num = (short)1118437376;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.UIValue;
			}
			set
			{
				short num = (short)1387266048;
				short num2 = num;
				num = (short)64815105;
				if (num != 0)
				{
				}
				num = (short)685169680;
				short num3 = num;
				num = (short)1788271632;
				switch (num3 == num)
				{
				}
				num = (short)1735524352;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.UIValue = value;
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x0064D818 File Offset: 0x0064BA18
		// (set) Token: 0x06007124 RID: 28964 RVA: 0x0064D8CC File Offset: 0x0064BACC
		internal int DispMenuGeneralZoneTextSize_A8167Min
		{
			get
			{
				short num = (short)1640890368;
				short num2 = num;
				num = (short)794787290;
				short num3 = num;
				num = (short)904166874;
				switch (num3 == num)
				{
				}
				num = (short)875233281;
				if (num != 0)
				{
				}
				num = (short)1027604480;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Min;
			}
			set
			{
				short num = (short)1545666560;
				short num2 = num;
				num = (short)1442429813;
				short num3 = num;
				num = (short)76921717;
				switch (num3 == num)
				{
				}
				num = (short)548995072;
				if (num != 0)
				{
				}
				num = (short)2041643009;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Min = value;
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x06007125 RID: 28965 RVA: 0x0064D980 File Offset: 0x0064BB80
		// (set) Token: 0x06007126 RID: 28966 RVA: 0x0064DA38 File Offset: 0x0064BC38
		internal int DispMenuGeneralZoneTextSize_A8167Max
		{
			get
			{
				short num = (short)1509556224;
				short num2 = num;
				num = (short)1624574877;
				short num3 = num;
				num = (short)900926365;
				switch (num3 == num)
				{
				}
				num = (short)982581248;
				if (num != 0)
				{
				}
				num = (short)710606849;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Max;
			}
			set
			{
				short num = (short)1576534016;
				short num2 = num;
				num = (short)361587240;
				short num3 = num;
				num = (short)1015767592;
				switch (num3 == num)
				{
				}
				num = (short)1176109056;
				if (num != 0)
				{
				}
				num = (short)2020343809;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Max = value;
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x0064DAEC File Offset: 0x0064BCEC
		// (set) Token: 0x06007128 RID: 28968 RVA: 0x0064DBA4 File Offset: 0x0064BDA4
		internal int DispMenuGeneralZoneTextSize_A8167Step
		{
			get
			{
				short num = (short)1492189184;
				short num2 = num;
				num = (short)1398079489;
				if (num != 0)
				{
				}
				num = (short)1504608337;
				short num3 = num;
				num = (short)1263173713;
				switch (num3 == num)
				{
				}
				num = (short)273088512;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.StepSize;
			}
			set
			{
				short num = (short)1010171904;
				short num2 = num;
				num = (short)1722613761;
				if (num != 0)
				{
				}
				num = (short)1307605373;
				short num3 = num;
				num = (short)279542141;
				switch (num3 == num)
				{
				}
				num = (short)1812529152;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.StepSize = value;
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x0064DC58 File Offset: 0x0064BE58
		// (set) Token: 0x0600712A RID: 28970 RVA: 0x0064DD0C File Offset: 0x0064BF0C
		public bool DispMenuGeneralZoneTextSize_A8167_Applicable
		{
			get
			{
				short num = (short)466092032;
				short num2 = num;
				num = (short)367654130;
				short num3 = num;
				num = (short)592704754;
				switch (num3 == num)
				{
				}
				num = (short)1369112576;
				if (num != 0)
				{
				}
				num = (short)648019969;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Applicable;
			}
			set
			{
				short num = (short)597753856;
				short num2 = num;
				num = (short)1442674462;
				short num3 = num;
				num = (short)416315166;
				switch (num3 == num)
				{
				}
				num = (short)882376704;
				if (num != 0)
				{
				}
				num = (short)943521793;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Applicable = value;
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x0064DDC0 File Offset: 0x0064BFC0
		// (set) Token: 0x0600712C RID: 28972 RVA: 0x0064DE74 File Offset: 0x0064C074
		public bool DispMenuGeneralZoneTextSize_A8167_Valid
		{
			get
			{
				short num = (short)384761856;
				short num2 = num;
				num = (short)183694957;
				short num3 = num;
				num = (short)2089088621;
				switch (num3 == num)
				{
				}
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)1106903040;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Valid;
			}
			set
			{
				short num = (short)617480192;
				short num2 = num;
				num = (short)1916911365;
				short num3 = num;
				num = (short)70041349;
				switch (num3 == num)
				{
				}
				num = (short)817496064;
				if (num != 0)
				{
				}
				num = (short)2098069505;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Valid = value;
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600712D RID: 28973 RVA: 0x0064DF2C File Offset: 0x0064C12C
		// (set) Token: 0x0600712E RID: 28974 RVA: 0x0064DFE4 File Offset: 0x0064C1E4
		public bool DispMenuGeneralZoneTextSize_A8167_Visible
		{
			get
			{
				short num = (short)1722155008;
				short num2 = num;
				num = (short)989645442;
				short num3 = num;
				num = (short)2004208258;
				switch (num3 == num)
				{
				}
				num = (short)1091829761;
				if (num != 0)
				{
				}
				num = (short)1212612608;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Visible;
			}
			set
			{
				short num = (short)1221984256;
				short num2 = num;
				num = (short)1230867994;
				short num3 = num;
				num = (short)1814728218;
				switch (num3 == num)
				{
				}
				num = (short)1434255361;
				if (num != 0)
				{
				}
				num = (short)1918435328;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Visible = value;
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600712F RID: 28975 RVA: 0x0064E09C File Offset: 0x0064C29C
		// (set) Token: 0x06007130 RID: 28976 RVA: 0x0064E150 File Offset: 0x0064C350
		public bool DispMenuGeneralZoneTextSize_A8167_Editable
		{
			get
			{
				short num = (short)62914560;
				short num2 = num;
				num = (short)1175565867;
				short num3 = num;
				num = (short)367441451;
				switch (num3 == num)
				{
				}
				num = (short)1871314945;
				if (num != 0)
				{
				}
				num = (short)24248320;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.Editable;
			}
			set
			{
				short num = (short)804519936;
				short num2 = num;
				num = (short)1215640993;
				short num3 = num;
				num = (short)1536177569;
				switch (num3 == num)
				{
				}
				num = (short)851771392;
				if (num != 0)
				{
				}
				num = (short)1997733889;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.Editable = value;
			}
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x06007131 RID: 28977 RVA: 0x0064E204 File Offset: 0x0064C404
		internal string DispMenuGeneralZoneTextSize_A8167_UILabel
		{
			get
			{
				short num = (short)1437663232;
				short num2 = num;
				num = (short)501584338;
				short num3 = num;
				num = (short)1537839570;
				switch (num3 == num)
				{
				}
				num = (short)713752576;
				if (num != 0)
				{
				}
				num = (short)541917185;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.UIName;
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x0064E2B8 File Offset: 0x0064C4B8
		// (set) Token: 0x06007133 RID: 28979 RVA: 0x0064E36C File Offset: 0x0064C56C
		internal bool DispMenuGeneralZoneTextSize_A8167_HiddenStatic
		{
			get
			{
				short num = (short)1964572672;
				short num2 = num;
				num = (short)950085839;
				short num3 = num;
				num = (short)622930127;
				switch (num3 == num)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				num = (short)188678145;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.HiddenStatic;
			}
			set
			{
				short num = (short)1696464896;
				short num2 = num;
				num = (short)970352876;
				short num3 = num;
				num = (short)973957356;
				switch (num3 == num)
				{
				}
				num = (short)1758855168;
				if (num != 0)
				{
				}
				num = (short)363266049;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.HiddenStatic = value;
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x0064E424 File Offset: 0x0064C624
		// (set) Token: 0x06007135 RID: 28981 RVA: 0x0064E4D8 File Offset: 0x0064C6D8
		internal bool DispMenuGeneralZoneTextSize_A8167_HiddenDynamic
		{
			get
			{
				short num = (short)1064697856;
				short num2 = num;
				num = (short)39393400;
				short num3 = num;
				num = (short)2144868472;
				switch (num3 == num)
				{
				}
				num = (short)395640833;
				if (num != 0)
				{
				}
				num = (short)1631977472;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167.HiddenDynamic;
			}
			set
			{
				short num = (short)921829376;
				short num2 = num;
				num = (short)1977624034;
				short num3 = num;
				num = (short)760620514;
				switch (num3 == num)
				{
				}
				num = (short)1173356544;
				if (num != 0)
				{
				}
				num = (short)670302209;
				if (num != 0)
				{
				}
				this.dispMenuGeneralZoneTextSize_A8167.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x0064E58C File Offset: 0x0064C78C
		public bool DispMenuGeneralZoneTextSize_A8167_HasDiffs
		{
			get
			{
				short num = (short)1793392640;
				short num2 = num;
				num = (short)1592150477;
				short num3 = num;
				num = (short)748440013;
				switch (num3 == num)
				{
				}
				num = (short)281149440;
				if (num != 0)
				{
				}
				num = (short)738721793;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralZoneTextSize_A8167._HasDiffs;
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x06007137 RID: 28983 RVA: 0x0064E640 File Offset: 0x0064C840
		// (set) Token: 0x06007138 RID: 28984 RVA: 0x0064E6F4 File Offset: 0x0064C8F4
		public int DispMenuGeneralImbalancedCoverageIndicator_A8240Value
		{
			get
			{
				short num = (short)1798111232;
				short num2 = num;
				num = (short)529703178;
				short num3 = num;
				num = (short)426352906;
				switch (num3 == num)
				{
				}
				num = (short)1229717505;
				if (num != 0)
				{
				}
				num = (short)1320353792;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Value;
			}
			set
			{
				short num = (short)986382336;
				short num2 = num;
				num = (short)1969160193;
				if (num != 0)
				{
				}
				num = (short)1242977161;
				short num3 = num;
				num = (short)1659786121;
				switch (num3 == num)
				{
				}
				num = (short)1729757184;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Value = value;
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x06007139 RID: 28985 RVA: 0x0064E7AC File Offset: 0x0064C9AC
		// (set) Token: 0x0600713A RID: 28986 RVA: 0x0064E860 File Offset: 0x0064CA60
		public string DispMenuGeneralImbalancedCoverageIndicator_A8240_UIValue
		{
			get
			{
				short num = (short)515964928;
				short num2 = num;
				num = (short)1598356610;
				short num3 = num;
				num = (short)1300298882;
				switch (num3 == num)
				{
				}
				num = (short)318308353;
				if (num != 0)
				{
				}
				num = (short)1595932672;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.UIValue;
			}
			set
			{
				short num = (short)1156972544;
				short num2 = num;
				num = (short)1080230316;
				short num3 = num;
				num = (short)342950316;
				switch (num3 == num)
				{
				}
				num = (short)72089600;
				if (num != 0)
				{
				}
				num = (short)1919418369;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.UIValue = value;
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600713B RID: 28987 RVA: 0x0064E914 File Offset: 0x0064CB14
		public global::AcpBusinessLayer.AcpListField DispMenuGeneralImbalancedCoverageIndicator_A8240
		{
			get
			{
				short num = (short)1836187648;
				short num2 = num;
				num = (short)1784554636;
				short num3 = num;
				num = (short)2084447372;
				switch (num3 == num)
				{
				}
				num = (short)750911488;
				if (num != 0)
				{
				}
				num = (short)916848641;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240;
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600713C RID: 28988 RVA: 0x0064E9C4 File Offset: 0x0064CBC4
		// (set) Token: 0x0600713D RID: 28989 RVA: 0x0064EA7C File Offset: 0x0064CC7C
		public bool DispMenuGeneralImbalancedCoverageIndicator_A8240_Applicable
		{
			get
			{
				short num = (short)1852440576;
				short num2 = num;
				num = (short)828069953;
				short num3 = num;
				num = (short)1697994817;
				switch (num3 == num)
				{
				}
				num = (short)639893504;
				if (num != 0)
				{
				}
				num = (short)1703149569;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Applicable;
			}
			set
			{
				short num = (short)761004032;
				short num2 = num;
				num = (short)588660454;
				short num3 = num;
				num = (short)1530937062;
				switch (num3 == num)
				{
				}
				num = (short)1517355009;
				if (num != 0)
				{
				}
				num = (short)818282496;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Applicable = value;
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x0064EB34 File Offset: 0x0064CD34
		// (set) Token: 0x0600713F RID: 28991 RVA: 0x0064EBEC File Offset: 0x0064CDEC
		public bool DispMenuGeneralImbalancedCoverageIndicator_A8240_Valid
		{
			get
			{
				short num = (short)139722752;
				short num2 = num;
				num = (short)1994915841;
				if (num != 0)
				{
				}
				num = (short)410084918;
				short num3 = num;
				num = (short)1169778230;
				switch (num3 == num)
				{
				}
				num = (short)1038811136;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Valid;
			}
			set
			{
				short num = (short)1259143168;
				short num2 = num;
				num = (short)461488100;
				short num3 = num;
				num = (short)1757593572;
				switch (num3 == num)
				{
				}
				num = (short)1434517505;
				if (num != 0)
				{
				}
				num = (short)1643184128;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Valid = value;
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x06007140 RID: 28992 RVA: 0x0064ECA4 File Offset: 0x0064CEA4
		// (set) Token: 0x06007141 RID: 28993 RVA: 0x0064ED58 File Offset: 0x0064CF58
		public bool DispMenuGeneralImbalancedCoverageIndicator_A8240_Visible
		{
			get
			{
				short num = (short)2036072448;
				short num2 = num;
				num = (short)2036204720;
				short num3 = num;
				num = (short)1497892016;
				switch (num3 == num)
				{
				}
				num = (short)678625280;
				if (num != 0)
				{
				}
				num = (short)1206976513;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Visible;
			}
			set
			{
				short num = (short)142016512;
				short num2 = num;
				num = (short)1815458941;
				short num3 = num;
				num = (short)1246278781;
				switch (num3 == num)
				{
				}
				num = (short)692256768;
				if (num != 0)
				{
				}
				num = (short)284033025;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Visible = value;
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x06007142 RID: 28994 RVA: 0x0064EE0C File Offset: 0x0064D00C
		// (set) Token: 0x06007143 RID: 28995 RVA: 0x0064EEC0 File Offset: 0x0064D0C0
		public bool DispMenuGeneralImbalancedCoverageIndicator_A8240_Editable
		{
			get
			{
				short num = (short)1358364672;
				short num2 = num;
				num = (short)1166761782;
				short num3 = num;
				num = (short)1091854134;
				switch (num3 == num)
				{
				}
				num = (short)521142273;
				if (num != 0)
				{
				}
				num = (short)1091436544;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Editable;
			}
			set
			{
				short num = (short)171704320;
				short num2 = num;
				num = (short)1902048258;
				short num3 = num;
				num = (short)223540226;
				switch (num3 == num)
				{
				}
				num = (short)1445199873;
				if (num != 0)
				{
				}
				num = (short)462422016;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.Editable = value;
			}
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x0064EF78 File Offset: 0x0064D178
		internal string DispMenuGeneralImbalancedCoverageIndicator_A8240_UILabel
		{
			get
			{
				short num = (short)1946222592;
				short num2 = num;
				num = (short)689176577;
				if (num != 0)
				{
				}
				num = (short)51159762;
				short num3 = num;
				num = (short)2018353874;
				switch (num3 == num)
				{
				}
				num = (short)2111897600;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.UIName;
			}
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x0064F030 File Offset: 0x0064D230
		// (set) Token: 0x06007146 RID: 28998 RVA: 0x0064F0E8 File Offset: 0x0064D2E8
		internal bool DispMenuGeneralImbalancedCoverageIndicator_A8240_HiddenStatic
		{
			get
			{
				short num = (short)1476198400;
				short num2 = num;
				num = (short)1135524074;
				short num3 = num;
				num = (short)1504033002;
				switch (num3 == num)
				{
				}
				num = (short)1330118656;
				if (num != 0)
				{
				}
				num = (short)470810625;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.HiddenStatic;
			}
			set
			{
				short num = (short)1674444800;
				short num2 = num;
				num = (short)1112457197;
				short num3 = num;
				num = (short)1815658477;
				switch (num3 == num)
				{
				}
				num = (short)1777336321;
				if (num != 0)
				{
				}
				num = (short)1363804160;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.HiddenStatic = value;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x06007147 RID: 28999 RVA: 0x0064F1A0 File Offset: 0x0064D3A0
		// (set) Token: 0x06007148 RID: 29000 RVA: 0x0064F250 File Offset: 0x0064D450
		internal bool DispMenuGeneralImbalancedCoverageIndicator_A8240_HiddenDynamic
		{
			get
			{
				short num = (short)1383858176;
				short num2 = num;
				num = (short)68585874;
				short num3 = num;
				num = (short)1032030610;
				switch (num3 == num)
				{
				}
				num = (short)791543809;
				if (num != 0)
				{
				}
				num = (short)438435840;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240.HiddenDynamic;
			}
			set
			{
				short num = (short)741343232;
				short num2 = num;
				num = (short)1173840234;
				short num3 = num;
				num = (short)1551130986;
				switch (num3 == num)
				{
				}
				num = (short)2018967553;
				if (num != 0)
				{
				}
				num = (short)1820000256;
				if (num != 0)
				{
				}
				this.dispMenuGeneralImbalancedCoverageIndicator_A8240.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x0064F308 File Offset: 0x0064D508
		public bool DispMenuGeneralImbalancedCoverageIndicator_A8240_HasDiffs
		{
			get
			{
				short num = (short)2056388608;
				short num2 = num;
				num = (short)929384333;
				short num3 = num;
				num = (short)1992247181;
				switch (num3 == num)
				{
				}
				num = (short)628621313;
				if (num != 0)
				{
				}
				num = (short)1312423936;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralImbalancedCoverageIndicator_A8240._HasDiffs;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x0064F3BC File Offset: 0x0064D5BC
		// (set) Token: 0x0600714B RID: 29003 RVA: 0x0064F470 File Offset: 0x0064D670
		public int DispMenuGeneralOutofRangeIndicator_A8678Value
		{
			get
			{
				short num = (short)1972961280;
				short num2 = num;
				num = (short)1217791281;
				short num3 = num;
				num = (short)1553138993;
				switch (num3 == num)
				{
				}
				num = (short)1096679424;
				if (num != 0)
				{
				}
				num = (short)1725038593;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.Value;
			}
			set
			{
				short num = (short)448659456;
				short num2 = num;
				num = (short)949485569;
				if (num != 0)
				{
				}
				num = (short)951373581;
				short num3 = num;
				num = (short)857526029;
				switch (num3 == num)
				{
				}
				num = (short)330039296;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.Value = value;
			}
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x0064F524 File Offset: 0x0064D724
		// (set) Token: 0x0600714D RID: 29005 RVA: 0x0064F5DC File Offset: 0x0064D7DC
		public string DispMenuGeneralOutofRangeIndicator_A8678_UIValue
		{
			get
			{
				short num = (short)1480654848;
				short num2 = num;
				num = (short)1213257122;
				short num3 = num;
				num = (short)1807472034;
				switch (num3 == num)
				{
				}
				num = (short)2029453312;
				if (num != 0)
				{
				}
				num = (short)254738433;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.UIValue;
			}
			set
			{
				short num = (short)401014784;
				short num2 = num;
				num = (short)1715899946;
				short num3 = num;
				num = (short)2000784938;
				switch (num3 == num)
				{
				}
				num = (short)488112128;
				if (num != 0)
				{
				}
				num = (short)1654784001;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.UIValue = value;
			}
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0600714E RID: 29006 RVA: 0x0064F694 File Offset: 0x0064D894
		public global::AcpBusinessLayer.AcpListField DispMenuGeneralOutofRangeIndicator_A8678
		{
			get
			{
				short num = (short)690552832;
				short num2 = num;
				num = (short)17198726;
				short num3 = num;
				num = (short)1908567686;
				switch (num3 == num)
				{
				}
				num = (short)1350696961;
				if (num != 0)
				{
				}
				num = (short)519438336;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678;
			}
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600714F RID: 29007 RVA: 0x0064F744 File Offset: 0x0064D944
		// (set) Token: 0x06007150 RID: 29008 RVA: 0x0064F7F4 File Offset: 0x0064D9F4
		public bool DispMenuGeneralOutofRangeIndicator_A8678_Applicable
		{
			get
			{
				short num = (short)2044198912;
				short num2 = num;
				num = (short)683785565;
				short num3 = num;
				num = (short)975289693;
				switch (num3 == num)
				{
				}
				num = (short)103219201;
				if (num != 0)
				{
				}
				num = (short)110100480;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.Applicable;
			}
			set
			{
				short num = (short)2005139456;
				short num2 = num;
				num = (short)2140800140;
				short num3 = num;
				num = (short)1039139980;
				switch (num3 == num)
				{
				}
				num = (short)285081601;
				if (num != 0)
				{
				}
				num = (short)588644352;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.Applicable = value;
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x0064F8A8 File Offset: 0x0064DAA8
		// (set) Token: 0x06007152 RID: 29010 RVA: 0x0064F95C File Offset: 0x0064DB5C
		public bool DispMenuGeneralOutofRangeIndicator_A8678_Valid
		{
			get
			{
				short num = (short)1730347008;
				short num2 = num;
				num = (short)586547201;
				if (num != 0)
				{
				}
				num = (short)1651603194;
				short num3 = num;
				num = (short)2000516858;
				switch (num3 == num)
				{
				}
				num = (short)967376896;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.Valid;
			}
			set
			{
				short num = (short)1236729856;
				short num2 = num;
				num = (short)2012306609;
				short num3 = num;
				num = (short)1830247601;
				switch (num3 == num)
				{
				}
				num = (short)450101248;
				if (num != 0)
				{
				}
				num = (short)235143169;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.Valid = value;
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x0064FA10 File Offset: 0x0064DC10
		// (set) Token: 0x06007154 RID: 29012 RVA: 0x0064FACC File Offset: 0x0064DCCC
		public bool DispMenuGeneralOutofRangeIndicator_A8678_Visible
		{
			get
			{
				short num = (short)1593180160;
				short num2 = num;
				num = (short)100335617;
				if (num != 0)
				{
				}
				num = (short)164814521;
				short num3 = num;
				num = (short)505077433;
				switch (num3 == num)
				{
				}
				num = (short)269680640;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.Visible;
			}
			set
			{
				short num = (short)1053491200;
				short num2 = num;
				num = (short)278905131;
				short num3 = num;
				num = (short)1706737963;
				switch (num3 == num)
				{
				}
				num = (short)1960640513;
				if (num != 0)
				{
				}
				num = (short)1858273280;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.Visible = value;
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x06007155 RID: 29013 RVA: 0x0064FB80 File Offset: 0x0064DD80
		// (set) Token: 0x06007156 RID: 29014 RVA: 0x0064FC34 File Offset: 0x0064DE34
		public bool DispMenuGeneralOutofRangeIndicator_A8678_Editable
		{
			get
			{
				short num = (short)1334181888;
				short num2 = num;
				num = (short)418563262;
				short num3 = num;
				num = (short)279037118;
				switch (num3 == num)
				{
				}
				num = (short)1234501633;
				if (num != 0)
				{
				}
				num = (short)1833893888;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.Editable;
			}
			set
			{
				short num = (short)1842348032;
				short num2 = num;
				num = (short)435617793;
				if (num != 0)
				{
				}
				num = (short)2119299083;
				short num3 = num;
				num = (short)463925259;
				switch (num3 == num)
				{
				}
				num = (short)243400704;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.Editable = value;
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x06007157 RID: 29015 RVA: 0x0064FCEC File Offset: 0x0064DEEC
		internal string DispMenuGeneralOutofRangeIndicator_A8678_UILabel
		{
			get
			{
				short num = (short)1591083008;
				short num2 = num;
				num = (short)1432731766;
				short num3 = num;
				num = (short)1701429366;
				switch (num3 == num)
				{
				}
				num = (short)484769793;
				if (num != 0)
				{
				}
				num = (short)1096220672;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.UIName;
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x06007158 RID: 29016 RVA: 0x0064FDA0 File Offset: 0x0064DFA0
		// (set) Token: 0x06007159 RID: 29017 RVA: 0x0064FE58 File Offset: 0x0064E058
		internal bool DispMenuGeneralOutofRangeIndicator_A8678_HiddenStatic
		{
			get
			{
				short num = (short)91881472;
				short num2 = num;
				num = (short)65575154;
				short num3 = num;
				num = (short)1281857778;
				switch (num3 == num)
				{
				}
				num = (short)527499265;
				if (num != 0)
				{
				}
				num = (short)832569344;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.HiddenStatic;
			}
			set
			{
				short num = (short)1708654592;
				short num2 = num;
				num = (short)1103313669;
				short num3 = num;
				num = (short)952384261;
				switch (num3 == num)
				{
				}
				num = (short)1595670529;
				if (num != 0)
				{
				}
				num = (short)1925775360;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.HiddenStatic = value;
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600715A RID: 29018 RVA: 0x0064FF0C File Offset: 0x0064E10C
		// (set) Token: 0x0600715B RID: 29019 RVA: 0x0064FFC4 File Offset: 0x0064E1C4
		internal bool DispMenuGeneralOutofRangeIndicator_A8678_HiddenDynamic
		{
			get
			{
				short num = (short)150470656;
				short num2 = num;
				num = (short)9644624;
				short num3 = num;
				num = (short)1125788240;
				switch (num3 == num)
				{
				}
				num = (short)815529985;
				if (num != 0)
				{
				}
				num = (short)1066532864;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678.HiddenDynamic;
			}
			set
			{
				short num = (short)414187520;
				short num2 = num;
				num = (short)1887092466;
				short num3 = num;
				num = (short)1808908018;
				switch (num3 == num)
				{
				}
				num = (short)1683881985;
				if (num != 0)
				{
				}
				num = (short)139984896;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutofRangeIndicator_A8678.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600715C RID: 29020 RVA: 0x00650078 File Offset: 0x0064E278
		public bool DispMenuGeneralOutofRangeIndicator_A8678_HasDiffs
		{
			get
			{
				short num = (short)58195968;
				short num2 = num;
				num = (short)1957104113;
				short num3 = num;
				num = (short)438897137;
				switch (num3 == num)
				{
				}
				num = (short)234684416;
				if (num != 0)
				{
				}
				num = (short)2123759617;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutofRangeIndicator_A8678._HasDiffs;
			}
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600715D RID: 29021 RVA: 0x0065012C File Offset: 0x0064E32C
		// (set) Token: 0x0600715E RID: 29022 RVA: 0x006501DC File Offset: 0x0064E3DC
		public int DispMenuGeneralOutOfRangeHoldOffTimerValue
		{
			get
			{
				short num = (short)1043005440;
				short num2 = num;
				num = (short)1646738844;
				short num3 = num;
				num = (short)991509916;
				switch (num3 == num)
				{
				}
				num = (short)175046656;
				if (num != 0)
				{
				}
				num = (short)165478401;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Value;
			}
			set
			{
				short num = (short)1296957440;
				short num2 = num;
				num = (short)1880238095;
				short num3 = num;
				num = (short)295905295;
				switch (num3 == num)
				{
				}
				num = (short)510132225;
				if (num != 0)
				{
				}
				num = (short)153616384;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Value = value;
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x00650290 File Offset: 0x0064E490
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuGeneralOutOfRangeHoldOffTimer
		{
			get
			{
				short num = (short)151191552;
				short num2 = num;
				num = (short)272448151;
				short num3 = num;
				num = (short)1082079895;
				switch (num3 == num)
				{
				}
				num = (short)1724645376;
				if (num != 0)
				{
				}
				num = (short)1224998913;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x06007160 RID: 29024 RVA: 0x00650340 File Offset: 0x0064E540
		// (set) Token: 0x06007161 RID: 29025 RVA: 0x006503F8 File Offset: 0x0064E5F8
		public string DispMenuGeneralOutOfRangeHoldOffTimer_UIValue
		{
			get
			{
				short num = (short)268042240;
				short num2 = num;
				num = (short)1838714556;
				short num3 = num;
				num = (short)1816301244;
				switch (num3 == num)
				{
				}
				num = (short)136118272;
				if (num != 0)
				{
				}
				num = (short)55050241;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.UIValue;
			}
			set
			{
				short num = (short)778371072;
				short num2 = num;
				num = (short)429897529;
				short num3 = num;
				num = (short)731887417;
				switch (num3 == num)
				{
				}
				num = (short)1000996865;
				if (num != 0)
				{
				}
				num = (short)310050816;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeHoldOffTimer.UIValue = value;
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x06007162 RID: 29026 RVA: 0x006504B0 File Offset: 0x0064E6B0
		// (set) Token: 0x06007163 RID: 29027 RVA: 0x00650564 File Offset: 0x0064E764
		internal int DispMenuGeneralOutOfRangeHoldOffTimerMin
		{
			get
			{
				short num = (short)2098987008;
				short num2 = num;
				num = (short)1274343868;
				short num3 = num;
				num = (short)483324348;
				switch (num3 == num)
				{
				}
				num = (short)631701505;
				if (num != 0)
				{
				}
				num = (short)1281163264;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Min;
			}
			set
			{
				short num = (short)685047808;
				short num2 = num;
				num = (short)1806502535;
				short num3 = num;
				num = (short)816974471;
				switch (num3 == num)
				{
				}
				num = (short)526254080;
				if (num != 0)
				{
				}
				num = (short)1900347393;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Min = value;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x06007164 RID: 29028 RVA: 0x00650618 File Offset: 0x0064E818
		// (set) Token: 0x06007165 RID: 29029 RVA: 0x006506CC File Offset: 0x0064E8CC
		internal int DispMenuGeneralOutOfRangeHoldOffTimerMax
		{
			get
			{
				short num = (short)1598029824;
				short num2 = num;
				num = (short)1450377217;
				if (num != 0)
				{
				}
				num = (short)856189772;
				short num3 = num;
				num = (short)820800332;
				switch (num3 == num)
				{
				}
				num = (short)274661376;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Max;
			}
			set
			{
				short num = (short)1432289280;
				short num2 = num;
				num = (short)171966465;
				if (num != 0)
				{
				}
				num = (short)386701847;
				short num3 = num;
				num = (short)1046780439;
				switch (num3 == num)
				{
				}
				num = (short)1337982976;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Max = value;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x00650780 File Offset: 0x0064E980
		// (set) Token: 0x06007167 RID: 29031 RVA: 0x00650834 File Offset: 0x0064EA34
		internal int DispMenuGeneralOutOfRangeHoldOffTimerStep
		{
			get
			{
				short num = (short)1539833856;
				short num2 = num;
				num = (short)1154749272;
				short num3 = num;
				num = (short)2042106712;
				switch (num3 == num)
				{
				}
				num = (short)1136328705;
				if (num != 0)
				{
				}
				num = (short)99024896;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.StepSize;
			}
			set
			{
				short num = (short)829751296;
				short num2 = num;
				num = (short)1869217793;
				if (num != 0)
				{
				}
				num = (short)1709800630;
				short num3 = num;
				num = (short)1235057846;
				switch (num3 == num)
				{
				}
				num = (short)1855979520;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeHoldOffTimer.StepSize = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x006508EC File Offset: 0x0064EAEC
		// (set) Token: 0x06007169 RID: 29033 RVA: 0x006509A0 File Offset: 0x0064EBA0
		public bool DispMenuGeneralOutOfRangeHoldOffTimer_Applicable
		{
			get
			{
				short num = (short)46060005;
				short num2 = num;
				num = (short)1797771749;
				switch (num2 == num)
				{
				}
				num = (short)31916033;
				if (num != 0)
				{
				}
				num = (short)2046033920;
				if (num != 0)
				{
				}
				num = (short)452263936;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Applicable;
			}
			set
			{
				short num = (short)209362749;
				short num2 = num;
				num = (short)2061737789;
				switch (num2 == num)
				{
				}
				num = (short)1404698625;
				if (num != 0)
				{
				}
				num = (short)1494614016;
				if (num != 0)
				{
				}
				num = (short)1437401088;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Applicable = value;
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x00650A58 File Offset: 0x0064EC58
		// (set) Token: 0x0600716B RID: 29035 RVA: 0x00650B0C File Offset: 0x0064ED0C
		public bool DispMenuGeneralOutOfRangeHoldOffTimer_Valid
		{
			get
			{
				short num = (short)730728321;
				short num2 = num;
				num = (short)1176045441;
				switch (num2 == num)
				{
				}
				num = (short)516620289;
				if (num != 0)
				{
				}
				num = (short)79429632;
				if (num != 0)
				{
				}
				num = (short)1214185472;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Valid;
			}
			set
			{
				short num = (short)1181602027;
				short num2 = num;
				num = (short)1896730859;
				switch (num2 == num)
				{
				}
				num = (short)2089746432;
				if (num != 0)
				{
				}
				num = (short)1982332929;
				if (num != 0)
				{
				}
				num = (short)1790705664;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Valid = value;
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x00650BC4 File Offset: 0x0064EDC4
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x00650C78 File Offset: 0x0064EE78
		public bool DispMenuGeneralOutOfRangeHoldOffTimer_Visible
		{
			get
			{
				short num = (short)1454121137;
				short num2 = num;
				num = (short)1939873969;
				switch (num2 == num)
				{
				}
				num = (short)1810497536;
				if (num != 0)
				{
				}
				num = (short)1969815553;
				if (num != 0)
				{
				}
				num = (short)108855296;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Visible;
			}
			set
			{
				short num = (short)693992127;
				short num2 = num;
				num = (short)327449279;
				switch (num2 == num)
				{
				}
				num = (short)1819607040;
				if (num != 0)
				{
				}
				num = (short)274923521;
				if (num != 0)
				{
				}
				num = (short)1322188800;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Visible = value;
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x00650D2C File Offset: 0x0064EF2C
		// (set) Token: 0x0600716F RID: 29039 RVA: 0x00650DE0 File Offset: 0x0064EFE0
		public bool DispMenuGeneralOutOfRangeHoldOffTimer_Editable
		{
			get
			{
				short num = (short)89049959;
				short num2 = num;
				num = (short)618515303;
				switch (num2 == num)
				{
				}
				num = (short)1950941185;
				if (num != 0)
				{
				}
				num = (short)1507983360;
				if (num != 0)
				{
				}
				num = (short)1377239040;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.Editable;
			}
			set
			{
				short num = (short)53069150;
				short num2 = num;
				num = (short)25937246;
				switch (num2 == num)
				{
				}
				num = (short)383975425;
				if (num != 0)
				{
				}
				num = (short)1160970240;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.Editable = value;
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x00650E98 File Offset: 0x0064F098
		internal string DispMenuGeneralOutOfRangeHoldOffTimer_UILabel
		{
			get
			{
				short num = (short)1406242299;
				short num2 = num;
				num = (short)921210363;
				switch (num2 == num)
				{
				}
				num = (short)1696464896;
				if (num != 0)
				{
				}
				num = (short)1370292225;
				if (num != 0)
				{
				}
				num = (short)1248264192;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.UIName;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x06007171 RID: 29041 RVA: 0x00650F4C File Offset: 0x0064F14C
		// (set) Token: 0x06007172 RID: 29042 RVA: 0x00651000 File Offset: 0x0064F200
		internal bool DispMenuGeneralOutOfRangeHoldOffTimer_HiddenStatic
		{
			get
			{
				short num = (short)1750811726;
				short num2 = num;
				num = (short)1414087758;
				switch (num2 == num)
				{
				}
				num = (short)1521942529;
				if (num != 0)
				{
				}
				num = (short)872218624;
				if (num != 0)
				{
				}
				num = (short)607453184;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.HiddenStatic;
			}
			set
			{
				short num = (short)1296965631;
				short num2 = num;
				num = (short)116531199;
				switch (num2 == num)
				{
				}
				num = (short)1177223169;
				if (num != 0)
				{
				}
				num = (short)1470365696;
				if (num != 0)
				{
				}
				num = (short)1039597568;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.HiddenStatic = value;
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x06007173 RID: 29043 RVA: 0x006510B4 File Offset: 0x0064F2B4
		// (set) Token: 0x06007174 RID: 29044 RVA: 0x0065116C File Offset: 0x0064F36C
		internal bool DispMenuGeneralOutOfRangeHoldOffTimer_HiddenDynamic
		{
			get
			{
				short num = (short)873193799;
				short num2 = num;
				num = (short)202957127;
				switch (num2 == num)
				{
				}
				num = (short)53739520;
				if (num != 0)
				{
				}
				num = (short)1548550145;
				if (num != 0)
				{
				}
				num = (short)88801280;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer.HiddenDynamic;
			}
			set
			{
				short num = (short)675275316;
				short num2 = num;
				num = (short)1942217268;
				switch (num2 == num)
				{
				}
				num = (short)379715585;
				if (num != 0)
				{
				}
				num = (short)549322752;
				if (num != 0)
				{
				}
				num = (short)966393856;
				short num3 = num;
				this.dispMenuGeneralOutOfRangeHoldOffTimer.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x06007175 RID: 29045 RVA: 0x00651220 File Offset: 0x0064F420
		public bool DispMenuGeneralOutOfRangeHoldOffTimer_HasDiffs
		{
			get
			{
				short num = (short)2080016252;
				short num2 = num;
				num = (short)1388021628;
				switch (num2 == num)
				{
				}
				num = (short)1593704448;
				if (num != 0)
				{
				}
				num = (short)1067974657;
				if (num != 0)
				{
				}
				num = (short)1479933952;
				short num3 = num;
				return this.dispMenuGeneralOutOfRangeHoldOffTimer._HasDiffs;
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x006512D8 File Offset: 0x0064F4D8
		// (set) Token: 0x06007177 RID: 29047 RVA: 0x0065138C File Offset: 0x0064F58C
		public int DispMenuGeneralSearchingSiteIndicatorValue
		{
			get
			{
				short num = (short)1195835393;
				if (num != 0)
				{
				}
				num = (short)1039531705;
				short num2 = num;
				num = (short)1435238073;
				switch (num2 == num)
				{
				}
				num = (short)1392443392;
				if (num != 0)
				{
				}
				num = (short)800129024;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.Value;
			}
			set
			{
				short num = (short)2965490;
				short num2 = num;
				num = (short)969818098;
				switch (num2 == num)
				{
				}
				num = (short)213450753;
				if (num != 0)
				{
				}
				num = (short)673382400;
				if (num != 0)
				{
				}
				num = (short)1773338624;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.Value = value;
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x00651440 File Offset: 0x0064F640
		// (set) Token: 0x06007179 RID: 29049 RVA: 0x006514F4 File Offset: 0x0064F6F4
		public string DispMenuGeneralSearchingSiteIndicator_UIValue
		{
			get
			{
				short num = (short)712426610;
				short num2 = num;
				num = (short)451200114;
				switch (num2 == num)
				{
				}
				num = (short)1969618944;
				if (num != 0)
				{
				}
				num = (short)891813889;
				if (num != 0)
				{
				}
				num = (short)746520576;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.UIValue;
			}
			set
			{
				short num = (short)750952127;
				short num2 = num;
				num = (short)1455791807;
				switch (num2 == num)
				{
				}
				num = (short)1903230977;
				if (num != 0)
				{
				}
				num = (short)1415643136;
				if (num != 0)
				{
				}
				num = (short)1741422592;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.UIValue = value;
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x006515A8 File Offset: 0x0064F7A8
		public global::AcpBusinessLayer.AcpListField DispMenuGeneralSearchingSiteIndicator
		{
			get
			{
				short num = (short)1624333072;
				short num2 = num;
				num = (short)1745509136;
				switch (num2 == num)
				{
				}
				num = (short)70189057;
				if (num != 0)
				{
				}
				num = (short)251133952;
				if (num != 0)
				{
				}
				num = (short)1309474816;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator;
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600717B RID: 29051 RVA: 0x00651658 File Offset: 0x0064F858
		// (set) Token: 0x0600717C RID: 29052 RVA: 0x00651710 File Offset: 0x0064F910
		public bool DispMenuGeneralSearchingSiteIndicator_Applicable
		{
			get
			{
				short num = (short)1996908492;
				short num2 = num;
				num = (short)848324556;
				switch (num2 == num)
				{
				}
				num = (short)1749876737;
				if (num != 0)
				{
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.Applicable;
			}
			set
			{
				short num = (short)93294234;
				short num2 = num;
				num = (short)335646362;
				switch (num2 == num)
				{
				}
				num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)1917124608;
				if (num != 0)
				{
				}
				num = (short)456589312;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.Applicable = value;
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x006517C4 File Offset: 0x0064F9C4
		// (set) Token: 0x0600717E RID: 29054 RVA: 0x00651878 File Offset: 0x0064FA78
		public bool DispMenuGeneralSearchingSiteIndicator_Valid
		{
			get
			{
				short num = (short)282591482;
				short num2 = num;
				num = (short)45154554;
				switch (num2 == num)
				{
				}
				num = (short)990183424;
				if (num != 0)
				{
				}
				num = (short)59375617;
				if (num != 0)
				{
				}
				num = (short)1835073536;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.Valid;
			}
			set
			{
				short num = (short)1512603552;
				short num2 = num;
				num = (short)1116831648;
				switch (num2 == num)
				{
				}
				num = (short)1696595969;
				if (num != 0)
				{
				}
				num = (short)2122121216;
				if (num != 0)
				{
				}
				num = (short)749600768;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.Valid = value;
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600717F RID: 29055 RVA: 0x0065192C File Offset: 0x0064FB2C
		// (set) Token: 0x06007180 RID: 29056 RVA: 0x006519E4 File Offset: 0x0064FBE4
		public bool DispMenuGeneralSearchingSiteIndicator_Visible
		{
			get
			{
				short num = (short)253109197;
				short num2 = num;
				num = (short)628106189;
				switch (num2 == num)
				{
				}
				num = (short)1869086721;
				if (num != 0)
				{
				}
				num = (short)516685824;
				if (num != 0)
				{
				}
				num = (short)881917952;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.Visible;
			}
			set
			{
				short num = (short)1611276157;
				short num2 = num;
				num = (short)853090173;
				switch (num2 == num)
				{
				}
				num = (short)519831553;
				if (num != 0)
				{
				}
				num = (short)1566310400;
				if (num != 0)
				{
				}
				num = (short)57868288;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.Visible = value;
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x00651A98 File Offset: 0x0064FC98
		// (set) Token: 0x06007182 RID: 29058 RVA: 0x00651B50 File Offset: 0x0064FD50
		public bool DispMenuGeneralSearchingSiteIndicator_Editable
		{
			get
			{
				short num = (short)1209977497;
				short num2 = num;
				num = (short)2067319449;
				switch (num2 == num)
				{
				}
				num = (short)738328577;
				if (num != 0)
				{
				}
				num = (short)1476132864;
				if (num != 0)
				{
				}
				num = (short)262930432;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.Editable;
			}
			set
			{
				short num = (short)2115911761;
				short num2 = num;
				num = (short)883441745;
				switch (num2 == num)
				{
				}
				num = (short)2079195137;
				if (num != 0)
				{
				}
				num = (short)1593901056;
				if (num != 0)
				{
				}
				num = (short)2014445568;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.Editable = value;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x06007183 RID: 29059 RVA: 0x00651C04 File Offset: 0x0064FE04
		internal string DispMenuGeneralSearchingSiteIndicator_UILabel
		{
			get
			{
				short num = (short)92282473;
				short num2 = num;
				num = (short)1246764649;
				switch (num2 == num)
				{
				}
				num = (short)2144010240;
				if (num != 0)
				{
				}
				num = (short)1451425793;
				if (num != 0)
				{
				}
				num = (short)1874591744;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.UIName;
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x00651CB8 File Offset: 0x0064FEB8
		// (set) Token: 0x06007185 RID: 29061 RVA: 0x00651D6C File Offset: 0x0064FF6C
		internal bool DispMenuGeneralSearchingSiteIndicator_HiddenStatic
		{
			get
			{
				short num = (short)1206688878;
				short num2 = num;
				num = (short)962501742;
				switch (num2 == num)
				{
				}
				num = (short)746258433;
				if (num != 0)
				{
				}
				num = (short)1022492672;
				if (num != 0)
				{
				}
				num = (short)1618673664;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.HiddenStatic;
			}
			set
			{
				short num = (short)1044276222;
				short num2 = num;
				num = (short)1418486782;
				switch (num2 == num)
				{
				}
				num = (short)1207894017;
				if (num != 0)
				{
				}
				num = (short)156041216;
				if (num != 0)
				{
				}
				num = (short)197984256;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.HiddenStatic = value;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x06007186 RID: 29062 RVA: 0x00651E20 File Offset: 0x00650020
		// (set) Token: 0x06007187 RID: 29063 RVA: 0x00651ED8 File Offset: 0x006500D8
		internal bool DispMenuGeneralSearchingSiteIndicator_HiddenDynamic
		{
			get
			{
				short num = (short)1157976593;
				short num2 = num;
				num = (short)1555845649;
				switch (num2 == num)
				{
				}
				num = (short)1884225537;
				if (num != 0)
				{
				}
				num = (short)733085696;
				if (num != 0)
				{
				}
				num = (short)627638272;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator.HiddenDynamic;
			}
			set
			{
				short num = (short)1961060981;
				short num2 = num;
				num = (short)2047568501;
				switch (num2 == num)
				{
				}
				num = (short)586088449;
				if (num != 0)
				{
				}
				num = (short)1640824832;
				if (num != 0)
				{
				}
				num = (short)2087321600;
				short num3 = num;
				this.dispMenuGeneralSearchingSiteIndicator.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x00651F90 File Offset: 0x00650190
		public bool DispMenuGeneralSearchingSiteIndicator_HasDiffs
		{
			get
			{
				short num = (short)1364812705;
				short num2 = num;
				num = (short)1853121441;
				switch (num2 == num)
				{
				}
				num = (short)1788805121;
				if (num != 0)
				{
				}
				num = (short)919601152;
				if (num != 0)
				{
				}
				num = (short)861274112;
				short num3 = num;
				return this.dispMenuGeneralSearchingSiteIndicator._HasDiffs;
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x00652048 File Offset: 0x00650248
		// (set) Token: 0x0600718A RID: 29066 RVA: 0x006520FC File Offset: 0x006502FC
		public int DispMenuGeneralSlowScrollCount_A9160Value
		{
			get
			{
				short num = (short)359391226;
				short num2 = num;
				num = (short)2026364922;
				switch (num2 == num)
				{
				}
				num = (short)1691942912;
				if (num != 0)
				{
				}
				num = (short)446627841;
				if (num != 0)
				{
				}
				num = (short)541065216;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Value;
			}
			set
			{
				short num = (short)2112425172;
				short num2 = num;
				num = (short)2017201364;
				switch (num2 == num)
				{
				}
				num = (short)960692225;
				if (num != 0)
				{
				}
				num = (short)1519321088;
				if (num != 0)
				{
				}
				num = (short)1206648832;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Value = value;
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x006521B4 File Offset: 0x006503B4
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuGeneralSlowScrollCount_A9160
		{
			get
			{
				short num = (short)2022178817;
				if (num != 0)
				{
				}
				num = (short)1075126766;
				short num2 = num;
				num = (short)1749426670;
				switch (num2 == num)
				{
				}
				num = (short)1508507648;
				if (num != 0)
				{
				}
				num = (short)224133120;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160;
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x0600718C RID: 29068 RVA: 0x00652264 File Offset: 0x00650464
		// (set) Token: 0x0600718D RID: 29069 RVA: 0x00652318 File Offset: 0x00650518
		public string DispMenuGeneralSlowScrollCount_A9160_UIValue
		{
			get
			{
				short num = (short)495172924;
				short num2 = num;
				num = (short)1643298108;
				switch (num2 == num)
				{
				}
				num = (short)1641742336;
				if (num != 0)
				{
				}
				num = (short)1176764417;
				if (num != 0)
				{
				}
				num = (short)677838848;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.UIValue;
			}
			set
			{
				short num = (short)1046748959;
				short num2 = num;
				num = (short)476978975;
				switch (num2 == num)
				{
				}
				num = (short)144244737;
				if (num != 0)
				{
				}
				num = (short)862257152;
				if (num != 0)
				{
				}
				num = (short)1344339968;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.UIValue = value;
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x006523D4 File Offset: 0x006505D4
		// (set) Token: 0x0600718F RID: 29071 RVA: 0x00652488 File Offset: 0x00650688
		internal int DispMenuGeneralSlowScrollCount_A9160Min
		{
			get
			{
				short num = (short)1350737861;
				short num2 = num;
				num = (short)1326424005;
				switch (num2 == num)
				{
				}
				num = (short)922353665;
				if (num != 0)
				{
				}
				num = (short)222625792;
				if (num != 0)
				{
				}
				num = (short)1317273600;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Min;
			}
			set
			{
				short num = (short)1635655219;
				short num2 = num;
				num = (short)1123753523;
				switch (num2 == num)
				{
				}
				num = (short)2103967745;
				if (num != 0)
				{
				}
				num = (short)1501954048;
				if (num != 0)
				{
				}
				num = (short)63111168;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Min = value;
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x0065253C File Offset: 0x0065073C
		// (set) Token: 0x06007191 RID: 29073 RVA: 0x006525F0 File Offset: 0x006507F0
		internal int DispMenuGeneralSlowScrollCount_A9160Max
		{
			get
			{
				short num = (short)825257886;
				short num2 = num;
				num = (short)1849716638;
				switch (num2 == num)
				{
				}
				num = (short)1564540929;
				if (num != 0)
				{
				}
				num = (short)1899954176;
				if (num != 0)
				{
				}
				num = (short)704839680;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Max;
			}
			set
			{
				short num = (short)928015602;
				short num2 = num;
				num = (short)1330668786;
				switch (num2 == num)
				{
				}
				num = (short)85917697;
				if (num != 0)
				{
				}
				num = (short)1773142016;
				if (num != 0)
				{
				}
				num = (short)1401159680;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Max = value;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x006526A4 File Offset: 0x006508A4
		// (set) Token: 0x06007193 RID: 29075 RVA: 0x00652758 File Offset: 0x00650958
		internal int DispMenuGeneralSlowScrollCount_A9160Step
		{
			get
			{
				short num = (short)1844457719;
				short num2 = num;
				num = (short)1011167479;
				switch (num2 == num)
				{
				}
				num = (short)342491137;
				if (num != 0)
				{
				}
				num = (short)1182203904;
				if (num != 0)
				{
				}
				num = (short)112132096;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.StepSize;
			}
			set
			{
				short num = (short)452511138;
				short num2 = num;
				num = (short)602981794;
				switch (num2 == num)
				{
				}
				num = (short)730333185;
				if (num != 0)
				{
				}
				num = (short)1498611712;
				if (num != 0)
				{
				}
				num = (short)1098252288;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.StepSize = value;
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x06007194 RID: 29076 RVA: 0x00652810 File Offset: 0x00650A10
		// (set) Token: 0x06007195 RID: 29077 RVA: 0x006528C0 File Offset: 0x00650AC0
		public bool DispMenuGeneralSlowScrollCount_A9160_Applicable
		{
			get
			{
				short num = (short)1721638300;
				short num2 = num;
				num = (short)1431838108;
				switch (num2 == num)
				{
				}
				num = (short)1279197185;
				if (num != 0)
				{
				}
				num = (short)1674903552;
				if (num != 0)
				{
				}
				num = (short)413990912;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Applicable;
			}
			set
			{
				short num = (short)285099720;
				short num2 = num;
				num = (short)119031496;
				switch (num2 == num)
				{
				}
				num = (short)1965424641;
				if (num != 0)
				{
				}
				num = (short)2142306304;
				if (num != 0)
				{
				}
				num = (short)1032454144;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Applicable = value;
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x06007196 RID: 29078 RVA: 0x00652978 File Offset: 0x00650B78
		// (set) Token: 0x06007197 RID: 29079 RVA: 0x00652A2C File Offset: 0x00650C2C
		public bool DispMenuGeneralSlowScrollCount_A9160_Valid
		{
			get
			{
				short num = (short)2024036450;
				short num2 = num;
				num = (short)319576162;
				switch (num2 == num)
				{
				}
				num = (short)278069249;
				if (num != 0)
				{
				}
				num = (short)2005139456;
				if (num != 0)
				{
				}
				num = (short)1711931392;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Valid;
			}
			set
			{
				short num = (short)1663436607;
				short num2 = num;
				num = (short)1868826431;
				switch (num2 == num)
				{
				}
				num = (short)692125696;
				if (num != 0)
				{
				}
				num = (short)1762459649;
				if (num != 0)
				{
				}
				num = (short)1830289408;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Valid = value;
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x06007198 RID: 29080 RVA: 0x00652AE0 File Offset: 0x00650CE0
		// (set) Token: 0x06007199 RID: 29081 RVA: 0x00652B98 File Offset: 0x00650D98
		public bool DispMenuGeneralSlowScrollCount_A9160_Visible
		{
			get
			{
				short num = (short)1301919872;
				short num2 = num;
				num = (short)1415559296;
				switch (num2 == num)
				{
				}
				num = (short)1554317313;
				if (num != 0)
				{
				}
				num = (short)486998016;
				if (num != 0)
				{
				}
				num = (short)1482817536;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Visible;
			}
			set
			{
				short num = (short)267039178;
				short num2 = num;
				num = (short)1775022538;
				switch (num2 == num)
				{
				}
				num = (short)797966336;
				if (num != 0)
				{
				}
				num = (short)1653473281;
				if (num != 0)
				{
				}
				num = (short)114622464;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Visible = value;
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x00652C4C File Offset: 0x00650E4C
		// (set) Token: 0x0600719B RID: 29083 RVA: 0x00652D00 File Offset: 0x00650F00
		public bool DispMenuGeneralSlowScrollCount_A9160_Editable
		{
			get
			{
				short num = (short)1350190613;
				short num2 = num;
				num = (short)876365333;
				switch (num2 == num)
				{
				}
				num = (short)1561460736;
				if (num != 0)
				{
				}
				num = (short)106233857;
				if (num != 0)
				{
				}
				num = (short)183042048;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.Editable;
			}
			set
			{
				short num = (short)1463995532;
				short num2 = num;
				num = (short)714001548;
				switch (num2 == num)
				{
				}
				num = (short)72613889;
				if (num != 0)
				{
				}
				num = (short)2139684864;
				if (num != 0)
				{
				}
				num = (short)1270284288;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.Editable = value;
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x00652DB8 File Offset: 0x00650FB8
		internal string DispMenuGeneralSlowScrollCount_A9160_UILabel
		{
			get
			{
				short num = (short)1749040902;
				short num2 = num;
				num = (short)513294086;
				switch (num2 == num)
				{
				}
				num = (short)1378811905;
				if (num != 0)
				{
				}
				num = (short)860291072;
				if (num != 0)
				{
				}
				num = (short)1831403520;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.UIName;
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00652E70 File Offset: 0x00651070
		// (set) Token: 0x0600719E RID: 29086 RVA: 0x00652F24 File Offset: 0x00651124
		internal bool DispMenuGeneralSlowScrollCount_A9160_HiddenStatic
		{
			get
			{
				short num = (short)133606284;
				short num2 = num;
				num = (short)980921228;
				switch (num2 == num)
				{
				}
				num = (short)1797718017;
				if (num != 0)
				{
				}
				num = (short)1557004288;
				if (num != 0)
				{
				}
				num = (short)447938560;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.HiddenStatic;
			}
			set
			{
				short num = (short)949480988;
				short num2 = num;
				num = (short)237366812;
				switch (num2 == num)
				{
				}
				num = (short)507183104;
				if (num != 0)
				{
				}
				num = (short)1390870529;
				if (num != 0)
				{
				}
				num = (short)1439301632;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.HiddenStatic = value;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x00652FD8 File Offset: 0x006511D8
		// (set) Token: 0x060071A0 RID: 29088 RVA: 0x0065308C File Offset: 0x0065128C
		internal bool DispMenuGeneralSlowScrollCount_A9160_HiddenDynamic
		{
			get
			{
				short num = (short)184537323;
				short num2 = num;
				num = (short)1571475691;
				switch (num2 == num)
				{
				}
				num = (short)1813643264;
				if (num != 0)
				{
				}
				num = (short)1439825921;
				if (num != 0)
				{
				}
				num = (short)808583168;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160.HiddenDynamic;
			}
			set
			{
				short num = (short)1077682076;
				short num2 = num;
				num = (short)381034396;
				switch (num2 == num)
				{
				}
				num = (short)1668808704;
				if (num != 0)
				{
				}
				num = (short)416743425;
				if (num != 0)
				{
				}
				num = (short)1102708736;
				short num3 = num;
				this.dispMenuGeneralSlowScrollCount_A9160.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x00653144 File Offset: 0x00651344
		public bool DispMenuGeneralSlowScrollCount_A9160_HasDiffs
		{
			get
			{
				short num = (short)545718273;
				if (num != 0)
				{
				}
				num = (short)269607860;
				short num2 = num;
				num = (short)2095375284;
				switch (num2 == num)
				{
				}
				num = (short)1100087296;
				if (num != 0)
				{
				}
				num = (short)1297547264;
				short num3 = num;
				return this.dispMenuGeneralSlowScrollCount_A9160._HasDiffs;
			}
		}

		// Token: 0x17003A9E RID: 15006
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x006531F8 File Offset: 0x006513F8
		// (set) Token: 0x060071A3 RID: 29091 RVA: 0x006532AC File Offset: 0x006514AC
		public int FlipDisplayState_A19471Value
		{
			get
			{
				short num = (short)600113152;
				short num2 = num;
				num = (short)528986478;
				short num3 = num;
				num = (short)1903014254;
				switch (num3 == num)
				{
				}
				num = (short)822280193;
				if (num != 0)
				{
				}
				num = (short)296747008;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.Value;
			}
			set
			{
				short num = (short)1527250944;
				short num2 = num;
				num = (short)1829000727;
				short num3 = num;
				num = (short)1301042711;
				switch (num3 == num)
				{
				}
				num = (short)2085158912;
				if (num != 0)
				{
				}
				num = (short)634191873;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.Value = value;
			}
		}

		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x00653364 File Offset: 0x00651564
		// (set) Token: 0x060071A5 RID: 29093 RVA: 0x00653418 File Offset: 0x00651618
		public string FlipDisplayState_A19471_UIValue
		{
			get
			{
				short num = (short)128778240;
				short num2 = num;
				num = (short)1814575725;
				short num3 = num;
				num = (short)1379023469;
				switch (num3 == num)
				{
				}
				num = (short)1459683329;
				if (num != 0)
				{
				}
				num = (short)542834688;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.UIValue;
			}
			set
			{
				short num = (short)1457258496;
				short num2 = num;
				num = (short)477670654;
				short num3 = num;
				num = (short)1584311550;
				switch (num3 == num)
				{
				}
				num = (short)1333133313;
				if (num != 0)
				{
				}
				num = (short)1057095680;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.UIValue = value;
			}
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x006534CC File Offset: 0x006516CC
		public global::AcpBusinessLayer.AcpListField FlipDisplayState_A19471
		{
			get
			{
				short num = (short)728236032;
				short num2 = num;
				num = (short)1256663280;
				short num3 = num;
				num = (short)1066346736;
				switch (num3 == num)
				{
				}
				num = (short)1253048321;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x00653580 File Offset: 0x00651780
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x00653634 File Offset: 0x00651834
		public bool FlipDisplayState_A19471_Applicable
		{
			get
			{
				short num = (short)638255104;
				short num2 = num;
				num = (short)274672125;
				short num3 = num;
				num = (short)859384317;
				switch (num3 == num)
				{
				}
				num = (short)1118175233;
				if (num != 0)
				{
				}
				num = (short)1852375040;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.Applicable;
			}
			set
			{
				short num = (short)1927610368;
				short num2 = num;
				num = (short)825029181;
				short num3 = num;
				num = (short)1753739837;
				switch (num3 == num)
				{
				}
				num = (short)571604993;
				if (num != 0)
				{
				}
				num = (short)1787691008;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.Applicable = value;
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x006536E8 File Offset: 0x006518E8
		// (set) Token: 0x060071AA RID: 29098 RVA: 0x0065379C File Offset: 0x0065199C
		public bool FlipDisplayState_A19471_Valid
		{
			get
			{
				short num = (short)1517813760;
				short num2 = num;
				num = (short)1840690570;
				short num3 = num;
				num = (short)2033956234;
				switch (num3 == num)
				{
				}
				num = (short)1942028289;
				if (num != 0)
				{
				}
				num = (short)1468727296;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.Valid;
			}
			set
			{
				short num = (short)2070085632;
				short num2 = num;
				num = (short)283606437;
				short num3 = num;
				num = (short)261651877;
				switch (num3 == num)
				{
				}
				num = (short)125894657;
				if (num != 0)
				{
				}
				num = (short)870645760;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.Valid = value;
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x00653850 File Offset: 0x00651A50
		// (set) Token: 0x060071AC RID: 29100 RVA: 0x00653908 File Offset: 0x00651B08
		public bool FlipDisplayState_A19471_Visible
		{
			get
			{
				short num = (short)838139904;
				short num2 = num;
				num = (short)768016954;
				short num3 = num;
				num = (short)2051605050;
				switch (num3 == num)
				{
				}
				num = (short)280887297;
				if (num != 0)
				{
				}
				num = (short)1118240768;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.Visible;
			}
			set
			{
				short num = (short)480706560;
				short num2 = num;
				num = (short)1715436200;
				short num3 = num;
				num = (short)1331591848;
				switch (num3 == num)
				{
				}
				num = (short)110755841;
				if (num != 0)
				{
				}
				num = (short)2086797312;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.Visible = value;
			}
		}

		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x006539BC File Offset: 0x00651BBC
		// (set) Token: 0x060071AE RID: 29102 RVA: 0x00653A70 File Offset: 0x00651C70
		public bool FlipDisplayState_A19471_Editable
		{
			get
			{
				short num = (short)1102446592;
				short num2 = num;
				num = (short)885185739;
				short num3 = num;
				num = (short)2002050251;
				switch (num3 == num)
				{
				}
				num = (short)34078720;
				if (num != 0)
				{
				}
				num = (short)792723457;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.Editable;
			}
			set
			{
				short num = (short)1322450944;
				short num2 = num;
				num = (short)615219893;
				short num3 = num;
				num = (short)1731625653;
				switch (num3 == num)
				{
				}
				num = (short)191627265;
				if (num != 0)
				{
				}
				num = (short)1441071104;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.Editable = value;
			}
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00653B24 File Offset: 0x00651D24
		internal string FlipDisplayState_A19471_UILabel
		{
			get
			{
				short num = (short)313982976;
				short num2 = num;
				num = (short)184722771;
				short num3 = num;
				num = (short)390899027;
				switch (num3 == num)
				{
				}
				num = (short)2092367873;
				if (num != 0)
				{
				}
				num = (short)907018240;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.UIName;
			}
		}

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x060071B0 RID: 29104 RVA: 0x00653BDC File Offset: 0x00651DDC
		// (set) Token: 0x060071B1 RID: 29105 RVA: 0x00653C90 File Offset: 0x00651E90
		internal bool FlipDisplayState_A19471_HiddenStatic
		{
			get
			{
				short num = (short)481624064;
				short num2 = num;
				num = (short)1882390265;
				short num3 = num;
				num = (short)1448345337;
				switch (num3 == num)
				{
				}
				num = (short)1734279169;
				if (num != 0)
				{
				}
				num = (short)731512832;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.HiddenStatic;
			}
			set
			{
				short num = (short)348454912;
				short num2 = num;
				num = (short)1984692225;
				if (num != 0)
				{
				}
				num = (short)724253917;
				short num3 = num;
				num = (short)31669469;
				switch (num3 == num)
				{
				}
				num = (short)1297350656;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.HiddenStatic = value;
			}
		}

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x060071B2 RID: 29106 RVA: 0x00653D48 File Offset: 0x00651F48
		// (set) Token: 0x060071B3 RID: 29107 RVA: 0x00653DFC File Offset: 0x00651FFC
		internal bool FlipDisplayState_A19471_HiddenDynamic
		{
			get
			{
				short num = (short)214040576;
				short num2 = num;
				num = (short)237697070;
				short num3 = num;
				num = (short)1610872878;
				switch (num3 == num)
				{
				}
				num = (short)1275658241;
				if (num != 0)
				{
				}
				num = (short)542638080;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471.HiddenDynamic;
			}
			set
			{
				short num = (short)1214316544;
				short num2 = num;
				num = (short)1087252903;
				short num3 = num;
				num = (short)197011879;
				switch (num3 == num)
				{
				}
				num = (short)568066048;
				if (num != 0)
				{
				}
				num = (short)1864630273;
				if (num != 0)
				{
				}
				this.flipDisplayState_A19471.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x060071B4 RID: 29108 RVA: 0x00653EB0 File Offset: 0x006520B0
		public bool FlipDisplayState_A19471_HasDiffs
		{
			get
			{
				short num = (short)1513291776;
				short num2 = num;
				num = (short)1671942147;
				short num3 = num;
				num = (short)689033219;
				switch (num3 == num)
				{
				}
				num = (short)947191809;
				if (num != 0)
				{
				}
				num = (short)1446182912;
				if (num != 0)
				{
				}
				return this.flipDisplayState_A19471._HasDiffs;
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x00653F64 File Offset: 0x00652164
		// (set) Token: 0x060071B6 RID: 29110 RVA: 0x00654018 File Offset: 0x00652218
		public int DispMenuTopChannelTextSize_A19504Value
		{
			get
			{
				short num = (short)1953234944;
				short num2 = num;
				num = (short)930789885;
				short num3 = num;
				num = (short)2034481661;
				switch (num3 == num)
				{
				}
				num = (short)1889927169;
				if (num != 0)
				{
				}
				num = (short)135397376;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Value;
			}
			set
			{
				short num = (short)1344602112;
				short num2 = num;
				num = (short)1125842945;
				if (num != 0)
				{
				}
				num = (short)1606026801;
				short num3 = num;
				num = (short)853411377;
				switch (num3 == num)
				{
				}
				num = (short)508887040;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Value = value;
			}
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x006540D0 File Offset: 0x006522D0
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuTopChannelTextSize_A19504
		{
			get
			{
				short num = (short)1231290368;
				short num2 = num;
				num = (short)498129077;
				short num3 = num;
				num = (short)1345444021;
				switch (num3 == num)
				{
				}
				num = (short)1898643457;
				if (num != 0)
				{
				}
				num = (short)1694629888;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504;
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x060071B8 RID: 29112 RVA: 0x00654180 File Offset: 0x00652380
		// (set) Token: 0x060071B9 RID: 29113 RVA: 0x00654234 File Offset: 0x00652434
		public string DispMenuTopChannelTextSize_A19504_UIValue
		{
			get
			{
				short num = (short)532480000;
				short num2 = num;
				num = (short)1063154230;
				short num3 = num;
				num = (short)93090358;
				switch (num3 == num)
				{
				}
				num = (short)840630272;
				if (num != 0)
				{
				}
				num = (short)464519169;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.UIValue;
			}
			set
			{
				short num = (short)1387528192;
				short num2 = num;
				num = (short)1511405842;
				short num3 = num;
				num = (short)432355602;
				switch (num3 == num)
				{
				}
				num = (short)2034761729;
				if (num != 0)
				{
				}
				num = (short)970522624;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.UIValue = value;
			}
		}

		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x060071BA RID: 29114 RVA: 0x006542E8 File Offset: 0x006524E8
		// (set) Token: 0x060071BB RID: 29115 RVA: 0x0065439C File Offset: 0x0065259C
		internal int DispMenuTopChannelTextSize_A19504Min
		{
			get
			{
				short num = (short)442564608;
				short num2 = num;
				num = (short)541091305;
				short num3 = num;
				num = (short)1629709801;
				switch (num3 == num)
				{
				}
				num = (short)993394689;
				if (num != 0)
				{
				}
				num = (short)152567808;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Min;
			}
			set
			{
				short num = (short)1442250752;
				short num2 = num;
				num = (short)875358883;
				short num3 = num;
				num = (short)1906305699;
				switch (num3 == num)
				{
				}
				num = (short)537460736;
				if (num != 0)
				{
				}
				num = (short)1611595777;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Min = value;
			}
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x060071BC RID: 29116 RVA: 0x00654454 File Offset: 0x00652654
		// (set) Token: 0x060071BD RID: 29117 RVA: 0x00654508 File Offset: 0x00652708
		internal int DispMenuTopChannelTextSize_A19504Max
		{
			get
			{
				short num = (short)552665088;
				short num2 = num;
				num = (short)822746601;
				short num3 = num;
				num = (short)497098217;
				switch (num3 == num)
				{
				}
				num = (short)736559104;
				if (num != 0)
				{
				}
				num = (short)2013855745;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Max;
			}
			set
			{
				short num = (short)1807089664;
				short num2 = num;
				num = (short)1135969668;
				short num3 = num;
				num = (short)843285892;
				switch (num3 == num)
				{
				}
				num = (short)491913217;
				if (num != 0)
				{
				}
				num = (short)1938161664;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Max = value;
			}
		}

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x060071BE RID: 29118 RVA: 0x006545BC File Offset: 0x006527BC
		// (set) Token: 0x060071BF RID: 29119 RVA: 0x00654674 File Offset: 0x00652874
		internal int DispMenuTopChannelTextSize_A19504Step
		{
			get
			{
				short num = (short)655687680;
				short num2 = num;
				num = (short)235875182;
				short num3 = num;
				num = (short)1220881262;
				switch (num3 == num)
				{
				}
				num = (short)246087680;
				if (num != 0)
				{
				}
				num = (short)2142371841;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.StepSize;
			}
			set
			{
				short num = (short)306184192;
				short num2 = num;
				num = (short)1807792149;
				short num3 = num;
				num = (short)396015637;
				switch (num3 == num)
				{
				}
				num = (short)2036924417;
				if (num != 0)
				{
				}
				num = (short)1934032896;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.StepSize = value;
			}
		}

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x060071C0 RID: 29120 RVA: 0x0065472C File Offset: 0x0065292C
		// (set) Token: 0x060071C1 RID: 29121 RVA: 0x006547E0 File Offset: 0x006529E0
		public bool DispMenuTopChannelTextSize_A19504_Applicable
		{
			get
			{
				short num = (short)254214144;
				short num2 = num;
				num = (short)2021588993;
				if (num != 0)
				{
				}
				num = (short)627175901;
				short num3 = num;
				num = (short)919794141;
				switch (num3 == num)
				{
				}
				num = (short)1284046848;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Applicable;
			}
			set
			{
				short num = (short)1441988608;
				short num2 = num;
				num = (short)1586576360;
				short num3 = num;
				num = (short)288504808;
				switch (num3 == num)
				{
				}
				num = (short)1350828033;
				if (num != 0)
				{
				}
				num = (short)1491140608;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Applicable = value;
			}
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x060071C2 RID: 29122 RVA: 0x00654898 File Offset: 0x00652A98
		// (set) Token: 0x060071C3 RID: 29123 RVA: 0x0065494C File Offset: 0x00652B4C
		public bool DispMenuTopChannelTextSize_A19504_Valid
		{
			get
			{
				short num = (short)741081088;
				short num2 = num;
				num = (short)1735524945;
				short num3 = num;
				num = (short)1552482897;
				switch (num3 == num)
				{
				}
				num = (short)972226561;
				if (num != 0)
				{
				}
				num = (short)2035417088;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Valid;
			}
			set
			{
				short num = (short)1467547648;
				short num2 = num;
				num = (short)1023007112;
				short num3 = num;
				num = (short)1470093704;
				switch (num3 == num)
				{
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				num = (short)524550145;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Valid = value;
			}
		}

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x060071C4 RID: 29124 RVA: 0x00654A00 File Offset: 0x00652C00
		// (set) Token: 0x060071C5 RID: 29125 RVA: 0x00654AB4 File Offset: 0x00652CB4
		public bool DispMenuTopChannelTextSize_A19504_Visible
		{
			get
			{
				short num = (short)1720909824;
				short num2 = num;
				num = (short)1850174897;
				short num3 = num;
				num = (short)471821745;
				switch (num3 == num)
				{
				}
				num = (short)1276706816;
				if (num != 0)
				{
				}
				num = (short)123469825;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Visible;
			}
			set
			{
				short num = (short)1896218624;
				short num2 = num;
				num = (short)125192621;
				short num3 = num;
				num = (short)888097197;
				switch (num3 == num)
				{
				}
				num = (short)1674510337;
				if (num != 0)
				{
				}
				num = (short)568066048;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Visible = value;
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x060071C6 RID: 29126 RVA: 0x00654B6C File Offset: 0x00652D6C
		// (set) Token: 0x060071C7 RID: 29127 RVA: 0x00654C20 File Offset: 0x00652E20
		public bool DispMenuTopChannelTextSize_A19504_Editable
		{
			get
			{
				short num = (short)1844707328;
				short num2 = num;
				num = (short)1197007813;
				short num3 = num;
				num = (short)328524741;
				switch (num3 == num)
				{
				}
				num = (short)425197568;
				if (num != 0)
				{
				}
				num = (short)1407188993;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.Editable;
			}
			set
			{
				short num = (short)1762263040;
				short num2 = num;
				num = (short)1894892191;
				short num3 = num;
				num = (short)1835844255;
				switch (num3 == num)
				{
				}
				num = (short)1564803073;
				if (num != 0)
				{
				}
				num = (short)443940864;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.Editable = value;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x060071C8 RID: 29128 RVA: 0x00654CD8 File Offset: 0x00652ED8
		internal string DispMenuTopChannelTextSize_A19504_UILabel
		{
			get
			{
				short num = (short)1742798848;
				short num2 = num;
				num = (short)1073232897;
				short num3 = num;
				num = (short)410991617;
				switch (num3 == num)
				{
				}
				num = (short)464977921;
				if (num != 0)
				{
				}
				num = (short)1556348928;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.UIName;
			}
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x00654D90 File Offset: 0x00652F90
		// (set) Token: 0x060071CA RID: 29130 RVA: 0x00654E44 File Offset: 0x00653044
		internal bool DispMenuTopChannelTextSize_A19504_HiddenStatic
		{
			get
			{
				short num = (short)2012741632;
				short num2 = num;
				num = (short)946145017;
				short num3 = num;
				num = (short)333907705;
				switch (num3 == num)
				{
				}
				num = (short)754057217;
				if (num != 0)
				{
				}
				num = (short)882049024;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.HiddenStatic;
			}
			set
			{
				short num = (short)1982136320;
				short num2 = num;
				num = (short)1136513893;
				short num3 = num;
				num = (short)957272933;
				switch (num3 == num)
				{
				}
				num = (short)1417150464;
				if (num != 0)
				{
				}
				num = (short)1514471425;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.HiddenStatic = value;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x00654EF8 File Offset: 0x006530F8
		// (set) Token: 0x060071CC RID: 29132 RVA: 0x00654FA8 File Offset: 0x006531A8
		internal bool DispMenuTopChannelTextSize_A19504_HiddenDynamic
		{
			get
			{
				short num = (short)1454833664;
				short num2 = num;
				num = (short)2055628817;
				short num3 = num;
				num = (short)1207199761;
				switch (num3 == num)
				{
				}
				num = (short)553582593;
				if (num != 0)
				{
				}
				num = (short)1288830976;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504.HiddenDynamic;
			}
			set
			{
				short num = (short)2099511296;
				short num2 = num;
				num = (short)1928251682;
				short num3 = num;
				num = (short)2141243682;
				switch (num3 == num)
				{
				}
				num = (short)1229062145;
				if (num != 0)
				{
				}
				num = (short)1682767872;
				if (num != 0)
				{
				}
				this.dispMenuTopChannelTextSize_A19504.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AB6 RID: 15030
		// (get) Token: 0x060071CD RID: 29133 RVA: 0x0065505C File Offset: 0x0065325C
		public bool DispMenuTopChannelTextSize_A19504_HasDiffs
		{
			get
			{
				short num = (short)179044352;
				short num2 = num;
				num = (short)1298792449;
				if (num != 0)
				{
				}
				num = (short)1137202728;
				short num3 = num;
				num = (short)1755862568;
				switch (num3 == num)
				{
				}
				num = (short)1382285312;
				if (num != 0)
				{
				}
				return this.dispMenuTopChannelTextSize_A19504._HasDiffs;
			}
		}

		// Token: 0x17003AB7 RID: 15031
		// (get) Token: 0x060071CE RID: 29134 RVA: 0x00655110 File Offset: 0x00653310
		// (set) Token: 0x060071CF RID: 29135 RVA: 0x006551C4 File Offset: 0x006533C4
		public int DispMenuGeneralTopZoneTextSize_A19769Value
		{
			get
			{
				short num = (short)471924736;
				short num2 = num;
				num = (short)680234134;
				short num3 = num;
				num = (short)596741270;
				switch (num3 == num)
				{
				}
				num = (short)1713635329;
				if (num != 0)
				{
				}
				num = (short)79691776;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Value;
			}
			set
			{
				short num = (short)425525248;
				short num2 = num;
				num = (short)1616436148;
				short num3 = num;
				num = (short)706927540;
				switch (num3 == num)
				{
				}
				num = (short)723910657;
				if (num != 0)
				{
				}
				num = (short)420020224;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Value = value;
			}
		}

		// Token: 0x17003AB8 RID: 15032
		// (get) Token: 0x060071D0 RID: 29136 RVA: 0x00655278 File Offset: 0x00653478
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuGeneralTopZoneTextSize_A19769
		{
			get
			{
				short num = (short)1358364672;
				short num2 = num;
				num = (short)1994653697;
				if (num != 0)
				{
				}
				num = (short)845033237;
				short num3 = num;
				num = (short)16789269;
				switch (num3 == num)
				{
				}
				num = (short)1882980352;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769;
			}
		}

		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x060071D1 RID: 29137 RVA: 0x00655328 File Offset: 0x00653528
		// (set) Token: 0x060071D2 RID: 29138 RVA: 0x006553DC File Offset: 0x006535DC
		public string DispMenuGeneralTopZoneTextSize_A19769_UIValue
		{
			get
			{
				short num = (short)2127143106;
				short num2 = num;
				num = (short)291479746;
				switch (num2 == num)
				{
				}
				num = (short)1879048192;
				short num3 = num;
				num = (short)1737818113;
				if (num != 0)
				{
				}
				num = (short)493486080;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.UIValue;
			}
			set
			{
				short num = (short)138530195;
				short num2 = num;
				num = (short)1949879699;
				switch (num2 == num)
				{
				}
				num = (short)158072832;
				short num3 = num;
				num = (short)599064577;
				if (num != 0)
				{
				}
				num = (short)485621760;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.UIValue = value;
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x00655494 File Offset: 0x00653694
		// (set) Token: 0x060071D4 RID: 29140 RVA: 0x00655548 File Offset: 0x00653748
		internal int DispMenuGeneralTopZoneTextSize_A19769Min
		{
			get
			{
				short num = (short)45744681;
				short num2 = num;
				num = (short)965673513;
				switch (num2 == num)
				{
				}
				num = (short)1208680448;
				short num3 = num;
				num = (short)739442689;
				if (num != 0)
				{
				}
				num = (short)1316880384;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Min;
			}
			set
			{
				short num = (short)471269377;
				if (num != 0)
				{
				}
				num = (short)1645785949;
				short num2 = num;
				num = (short)1948169053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1447034880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435435008;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Min = value;
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x006555FC File Offset: 0x006537FC
		// (set) Token: 0x060071D6 RID: 29142 RVA: 0x006556B0 File Offset: 0x006538B0
		internal int DispMenuGeneralTopZoneTextSize_A19769Max
		{
			get
			{
				short num = (short)489488385;
				if (num != 0)
				{
				}
				num = (short)1663222900;
				short num2 = num;
				num = (short)1189463156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1518665728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700528128;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Max;
			}
			set
			{
				short num = (short)1982791912;
				short num2 = num;
				num = (short)1096548584;
				switch (num2 == num)
				{
				}
				num = (short)1001979904;
				short num3 = num;
				num = (short)1923809281;
				if (num != 0)
				{
				}
				num = (short)1227096064;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Max = value;
			}
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x00655768 File Offset: 0x00653968
		// (set) Token: 0x060071D8 RID: 29144 RVA: 0x0065581C File Offset: 0x00653A1C
		internal int DispMenuGeneralTopZoneTextSize_A19769Step
		{
			get
			{
				short num = (short)1601004958;
				short num2 = num;
				num = (short)1688364446;
				switch (num2 == num)
				{
				}
				num = (short)227082240;
				short num3 = num;
				num = (short)2017067009;
				if (num != 0)
				{
				}
				num = (short)1661534208;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.StepSize;
			}
			set
			{
				short num = (short)1660747777;
				if (num != 0)
				{
				}
				num = (short)407559555;
				short num2 = num;
				num = (short)537189763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470038016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429719552;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.StepSize = value;
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x006558D0 File Offset: 0x00653AD0
		// (set) Token: 0x060071DA RID: 29146 RVA: 0x00655988 File Offset: 0x00653B88
		public bool DispMenuGeneralTopZoneTextSize_A19769_Applicable
		{
			get
			{
				short num = (short)1936906425;
				short num2 = num;
				num = (short)2036586681;
				switch (num2 == num)
				{
				}
				num = (short)40239104;
				short num3 = num;
				num = (short)1919942656;
				if (num != 0)
				{
				}
				num = (short)1919352833;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Applicable;
			}
			set
			{
				short num = (short)1347747841;
				if (num != 0)
				{
				}
				num = (short)625533920;
				short num2 = num;
				num = (short)1552409568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075904512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100597760;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Applicable = value;
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x00655A3C File Offset: 0x00653C3C
		// (set) Token: 0x060071DC RID: 29148 RVA: 0x00655AF0 File Offset: 0x00653CF0
		public bool DispMenuGeneralTopZoneTextSize_A19769_Valid
		{
			get
			{
				short num = (short)1902838106;
				short num2 = num;
				num = (short)1133642074;
				switch (num2 == num)
				{
				}
				num = (short)1938948096;
				short num3 = num;
				num = (short)454033409;
				if (num != 0)
				{
				}
				num = (short)1664155648;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Valid;
			}
			set
			{
				short num = (short)1930446613;
				short num2 = num;
				num = (short)239748885;
				switch (num2 == num)
				{
				}
				num = (short)142147584;
				short num3 = num;
				num = (short)179503105;
				if (num != 0)
				{
				}
				num = (short)370933760;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Valid = value;
			}
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x00655BA8 File Offset: 0x00653DA8
		// (set) Token: 0x060071DE RID: 29150 RVA: 0x00655C5C File Offset: 0x00653E5C
		public bool DispMenuGeneralTopZoneTextSize_A19769_Visible
		{
			get
			{
				short num = (short)745225804;
				short num2 = num;
				num = (short)1418935884;
				switch (num2 == num)
				{
				}
				num = (short)182976512;
				short num3 = num;
				num = (short)979042304;
				if (num != 0)
				{
				}
				num = (short)1174208513;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Visible;
			}
			set
			{
				short num = (short)1424428051;
				short num2 = num;
				num = (short)297602067;
				switch (num2 == num)
				{
				}
				num = (short)479068160;
				short num3 = num;
				num = (short)1850540033;
				if (num != 0)
				{
				}
				num = (short)30605312;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Visible = value;
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x00655D14 File Offset: 0x00653F14
		// (set) Token: 0x060071E0 RID: 29152 RVA: 0x00655DCC File Offset: 0x00653FCC
		public bool DispMenuGeneralTopZoneTextSize_A19769_Editable
		{
			get
			{
				short num = (short)114977976;
				short num2 = num;
				num = (short)761228472;
				switch (num2 == num)
				{
				}
				num = (short)1590689792;
				short num3 = num;
				num = (short)1186136064;
				if (num != 0)
				{
				}
				num = (short)192806913;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.Editable;
			}
			set
			{
				short num = (short)1149143580;
				short num2 = num;
				num = (short)1979746844;
				switch (num2 == num)
				{
				}
				num = (short)1262878720;
				short num3 = num;
				num = (short)1492516865;
				if (num != 0)
				{
				}
				num = (short)1332805632;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.Editable = value;
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x00655E84 File Offset: 0x00654084
		internal string DispMenuGeneralTopZoneTextSize_A19769_UILabel
		{
			get
			{
				short num = (short)1663681936;
				short num2 = num;
				num = (short)289064336;
				switch (num2 == num)
				{
				}
				num = (short)1155596288;
				short num3 = num;
				num = (short)1739063296;
				if (num != 0)
				{
				}
				num = (short)1515257857;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.UIName;
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x060071E2 RID: 29154 RVA: 0x00655F38 File Offset: 0x00654138
		// (set) Token: 0x060071E3 RID: 29155 RVA: 0x00655FEC File Offset: 0x006541EC
		internal bool DispMenuGeneralTopZoneTextSize_A19769_HiddenStatic
		{
			get
			{
				short num = (short)2100105308;
				short num2 = num;
				num = (short)795873372;
				switch (num2 == num)
				{
				}
				num = (short)1138884608;
				short num3 = num;
				num = (short)152895489;
				if (num != 0)
				{
				}
				num = (short)1973878784;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.HiddenStatic;
			}
			set
			{
				short num = (short)46087871;
				short num2 = num;
				num = (short)794246847;
				switch (num2 == num)
				{
				}
				num = (short)511967232;
				short num3 = num;
				num = (short)2086141952;
				if (num != 0)
				{
				}
				num = (short)1368588289;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.HiddenStatic = value;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x060071E4 RID: 29156 RVA: 0x006560A4 File Offset: 0x006542A4
		// (set) Token: 0x060071E5 RID: 29157 RVA: 0x00656158 File Offset: 0x00654358
		internal bool DispMenuGeneralTopZoneTextSize_A19769_HiddenDynamic
		{
			get
			{
				short num = (short)43440761;
				short num2 = num;
				num = (short)557636217;
				switch (num2 == num)
				{
				}
				num = (short)1328349184;
				short num3 = num;
				num = (short)1400504320;
				if (num != 0)
				{
				}
				num = (short)1479081985;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769.HiddenDynamic;
			}
			set
			{
				short num = (short)1881581868;
				short num2 = num;
				num = (short)1590602028;
				switch (num2 == num)
				{
				}
				num = (short)1370554368;
				short num3 = num;
				num = (short)482541568;
				if (num != 0)
				{
				}
				num = (short)1035665409;
				if (num != 0)
				{
				}
				this.dispMenuGeneralTopZoneTextSize_A19769.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x060071E6 RID: 29158 RVA: 0x0065620C File Offset: 0x0065440C
		public bool DispMenuGeneralTopZoneTextSize_A19769_HasDiffs
		{
			get
			{
				short num = (short)764360609;
				short num2 = num;
				num = (short)1085880225;
				switch (num2 == num)
				{
				}
				num = (short)1602355200;
				short num3 = num;
				num = (short)202964992;
				if (num != 0)
				{
				}
				num = (short)2143682561;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralTopZoneTextSize_A19769._HasDiffs;
			}
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x006562C4 File Offset: 0x006544C4
		// (set) Token: 0x060071E8 RID: 29160 RVA: 0x00656374 File Offset: 0x00654574
		public int DRSMFlipDisplayState_A24778Value
		{
			get
			{
				short num = (short)473019723;
				short num2 = num;
				num = (short)700757323;
				switch (num2 == num)
				{
				}
				num = (short)829030400;
				short num3 = num;
				num = (short)1660289024;
				if (num != 0)
				{
				}
				num = (short)1322254337;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.Value;
			}
			set
			{
				short num = (short)275929367;
				short num2 = num;
				num = (short)1184127255;
				switch (num2 == num)
				{
				}
				num = (short)2041118720;
				short num3 = num;
				num = (short)988479489;
				if (num != 0)
				{
				}
				num = (short)1835270144;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.Value = value;
			}
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x00656428 File Offset: 0x00654628
		// (set) Token: 0x060071EA RID: 29162 RVA: 0x006564DC File Offset: 0x006546DC
		public string DRSMFlipDisplayState_A24778_UIValue
		{
			get
			{
				short num = (short)1010513294;
				short num2 = num;
				num = (short)930690446;
				switch (num2 == num)
				{
				}
				num = (short)264241152;
				short num3 = num;
				num = (short)1535311873;
				if (num != 0)
				{
				}
				num = (short)1010171904;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.UIValue;
			}
			set
			{
				short num = (short)127270913;
				if (num != 0)
				{
				}
				num = (short)1439624613;
				short num2 = num;
				num = (short)231009701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309868032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)854851584;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.UIValue = value;
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x00656590 File Offset: 0x00654790
		public global::AcpBusinessLayer.AcpListField DRSMFlipDisplayState_A24778
		{
			get
			{
				short num = (short)209307913;
				short num2 = num;
				num = (short)1531234569;
				switch (num2 == num)
				{
				}
				num = (short)1108738048;
				short num3 = num;
				num = (short)1375272961;
				if (num != 0)
				{
				}
				num = (short)1111031808;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778;
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x060071EC RID: 29164 RVA: 0x00656640 File Offset: 0x00654840
		// (set) Token: 0x060071ED RID: 29165 RVA: 0x006566F4 File Offset: 0x006548F4
		public bool DRSMFlipDisplayState_A24778_Applicable
		{
			get
			{
				short num = (short)2130110104;
				short num2 = num;
				num = (short)801564312;
				switch (num2 == num)
				{
				}
				num = (short)64684032;
				short num3 = num;
				num = (short)1471414273;
				if (num != 0)
				{
				}
				num = (short)29556736;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.Applicable;
			}
			set
			{
				short num = (short)107781663;
				short num2 = num;
				num = (short)573939231;
				switch (num2 == num)
				{
				}
				num = (short)1388118016;
				short num3 = num;
				num = (short)77922304;
				if (num != 0)
				{
				}
				num = (short)498532353;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.Applicable = value;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x006567AC File Offset: 0x006549AC
		// (set) Token: 0x060071EF RID: 29167 RVA: 0x00656860 File Offset: 0x00654A60
		public bool DRSMFlipDisplayState_A24778_Valid
		{
			get
			{
				short num = (short)131010450;
				short num2 = num;
				num = (short)881397650;
				switch (num2 == num)
				{
				}
				num = (short)363724800;
				short num3 = num;
				num = (short)762773505;
				if (num != 0)
				{
				}
				num = (short)1250557952;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.Valid;
			}
			set
			{
				short num = (short)1970871310;
				short num2 = num;
				num = (short)1484200974;
				switch (num2 == num)
				{
				}
				num = (short)1445068800;
				short num3 = num;
				num = (short)400424960;
				if (num != 0)
				{
				}
				num = (short)1208811521;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.Valid = value;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x00656918 File Offset: 0x00654B18
		// (set) Token: 0x060071F1 RID: 29169 RVA: 0x006569CC File Offset: 0x00654BCC
		public bool DRSMFlipDisplayState_A24778_Visible
		{
			get
			{
				short num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)636333179;
				short num2 = num;
				num = (short)530951291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1829240832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)559153152;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.Visible;
			}
			set
			{
				short num = (short)1609337396;
				short num2 = num;
				num = (short)1324321332;
				switch (num2 == num)
				{
				}
				num = (short)1611595776;
				short num3 = num;
				num = (short)1517092865;
				if (num != 0)
				{
				}
				num = (short)1879769088;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.Visible = value;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x00656A80 File Offset: 0x00654C80
		// (set) Token: 0x060071F3 RID: 29171 RVA: 0x00656B38 File Offset: 0x00654D38
		public bool DRSMFlipDisplayState_A24778_Editable
		{
			get
			{
				short num = (short)1764342670;
				short num2 = num;
				num = (short)510114702;
				switch (num2 == num)
				{
				}
				num = (short)1152974848;
				short num3 = num;
				num = (short)222822400;
				if (num != 0)
				{
				}
				num = (short)431816705;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.Editable;
			}
			set
			{
				short num = (short)1774615847;
				short num2 = num;
				num = (short)1557626151;
				switch (num2 == num)
				{
				}
				num = (short)496762880;
				short num3 = num;
				num = (short)1476460545;
				if (num != 0)
				{
				}
				num = (short)745472000;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.Editable = value;
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x00656BEC File Offset: 0x00654DEC
		internal string DRSMFlipDisplayState_A24778_UILabel
		{
			get
			{
				short num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)1428338673;
				short num2 = num;
				num = (short)693221361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5963776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1843855360;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.UIName;
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x00656CA0 File Offset: 0x00654EA0
		// (set) Token: 0x060071F6 RID: 29174 RVA: 0x00656D54 File Offset: 0x00654F54
		internal bool DRSMFlipDisplayState_A24778_HiddenStatic
		{
			get
			{
				short num = (short)1226778948;
				short num2 = num;
				num = (short)2077894980;
				switch (num2 == num)
				{
				}
				num = (short)1326841856;
				short num3 = num;
				num = (short)1085341697;
				if (num != 0)
				{
				}
				num = (short)572850176;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.HiddenStatic;
			}
			set
			{
				short num = (short)1186071735;
				short num2 = num;
				num = (short)1902052535;
				switch (num2 == num)
				{
				}
				num = (short)1389101056;
				short num3 = num;
				num = (short)807206913;
				if (num != 0)
				{
				}
				num = (short)1383923712;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.HiddenStatic = value;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x00656E08 File Offset: 0x00655008
		// (set) Token: 0x060071F8 RID: 29176 RVA: 0x00656EC0 File Offset: 0x006550C0
		internal bool DRSMFlipDisplayState_A24778_HiddenDynamic
		{
			get
			{
				short num = (short)1410662401;
				if (num != 0)
				{
				}
				num = (short)1759915368;
				short num2 = num;
				num = (short)1112092008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560477696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)895680512;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778.HiddenDynamic;
			}
			set
			{
				short num = (short)299580160;
				short num2 = num;
				num = (short)317012736;
				switch (num2 == num)
				{
				}
				num = (short)1036976128;
				short num3 = num;
				num = (short)403177473;
				if (num != 0)
				{
				}
				num = (short)1496907776;
				if (num != 0)
				{
				}
				this.dRSMFlipDisplayState_A24778.HiddenDynamic = value;
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x060071F9 RID: 29177 RVA: 0x00656F74 File Offset: 0x00655174
		public bool DRSMFlipDisplayState_A24778_HasDiffs
		{
			get
			{
				short num = (short)2080873650;
				short num2 = num;
				num = (short)2117573810;
				switch (num2 == num)
				{
				}
				num = (short)259457024;
				short num3 = num;
				num = (short)753270785;
				if (num != 0)
				{
				}
				num = (short)573112320;
				if (num != 0)
				{
				}
				return this.dRSMFlipDisplayState_A24778._HasDiffs;
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x00657028 File Offset: 0x00655228
		// (set) Token: 0x060071FB RID: 29179 RVA: 0x006570DC File Offset: 0x006552DC
		public bool RadErgoWideStealthSaveDayNightMode_A36492Value
		{
			get
			{
				short num = (short)472513541;
				short num2 = num;
				num = (short)1973156869;
				switch (num2 == num)
				{
				}
				num = (short)1223163904;
				short num3 = num;
				num = (short)598016000;
				if (num != 0)
				{
				}
				num = (short)968032257;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Value;
			}
			set
			{
				short num = (short)575706360;
				short num2 = num;
				num = (short)1392088312;
				switch (num2 == num)
				{
				}
				num = (short)616366080;
				short num3 = num;
				num = (short)1577254912;
				if (num != 0)
				{
				}
				num = (short)1380515841;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Value = value;
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x00657190 File Offset: 0x00655390
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideStealthSaveDayNightMode_A36492
		{
			get
			{
				short num = (short)424437197;
				short num2 = num;
				num = (short)1836213709;
				switch (num2 == num)
				{
				}
				num = (short)1287127040;
				short num3 = num;
				num = (short)1020067841;
				if (num != 0)
				{
				}
				num = (short)2051276800;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492;
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x00657240 File Offset: 0x00655440
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x006572F8 File Offset: 0x006554F8
		public bool RadErgoWideStealthSaveDayNightMode_A36492_UIValue
		{
			get
			{
				short num = (short)638509674;
				short num2 = num;
				num = (short)1238491754;
				switch (num2 == num)
				{
				}
				num = (short)1200750592;
				short num3 = num;
				num = (short)1461387265;
				if (num != 0)
				{
				}
				num = (short)1860304896;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Value;
			}
			set
			{
				short num = (short)970357642;
				short num2 = num;
				num = (short)720862090;
				switch (num2 == num)
				{
				}
				num = (short)356384768;
				short num3 = num;
				num = (short)1369702401;
				if (num != 0)
				{
				}
				num = (short)1405878272;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Value = value;
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x006573B0 File Offset: 0x006555B0
		// (set) Token: 0x06007200 RID: 29184 RVA: 0x00657464 File Offset: 0x00655664
		public bool RadErgoWideStealthSaveDayNightMode_A36492_Applicable
		{
			get
			{
				short num = (short)1911881141;
				short num2 = num;
				num = (short)170720693;
				switch (num2 == num)
				{
				}
				num = (short)219676672;
				short num3 = num;
				num = (short)1566507008;
				if (num != 0)
				{
				}
				num = (short)578289665;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Applicable;
			}
			set
			{
				short num = (short)1496578790;
				short num2 = num;
				num = (short)1068497638;
				switch (num2 == num)
				{
				}
				num = (short)812711936;
				short num3 = num;
				num = (short)373358593;
				if (num != 0)
				{
				}
				num = (short)150274048;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Applicable = value;
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x0065751C File Offset: 0x0065571C
		// (set) Token: 0x06007202 RID: 29186 RVA: 0x006575D0 File Offset: 0x006557D0
		public bool RadErgoWideStealthSaveDayNightMode_A36492_Valid
		{
			get
			{
				short num = (short)1149134508;
				short num2 = num;
				num = (short)1016293036;
				switch (num2 == num)
				{
				}
				num = (short)1758920704;
				short num3 = num;
				num = (short)1690763264;
				if (num != 0)
				{
				}
				num = (short)1207762945;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Valid;
			}
			set
			{
				short num = (short)960093684;
				short num2 = num;
				num = (short)1000136180;
				switch (num2 == num)
				{
				}
				num = (short)2037645312;
				short num3 = num;
				num = (short)821559297;
				if (num != 0)
				{
				}
				num = (short)1434058752;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Valid = value;
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x00657688 File Offset: 0x00655888
		// (set) Token: 0x06007204 RID: 29188 RVA: 0x0065773C File Offset: 0x0065593C
		public bool RadErgoWideStealthSaveDayNightMode_A36492_Visible
		{
			get
			{
				short num = (short)1279984529;
				short num2 = num;
				num = (short)745669521;
				switch (num2 == num)
				{
				}
				num = (short)1133117440;
				short num3 = num;
				num = (short)896008193;
				if (num != 0)
				{
				}
				num = (short)900399104;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Visible;
			}
			set
			{
				short num = (short)1074021836;
				short num2 = num;
				num = (short)1131365836;
				switch (num2 == num)
				{
				}
				num = (short)1888681984;
				short num3 = num;
				num = (short)1314717697;
				if (num != 0)
				{
				}
				num = (short)1129316352;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Visible = value;
			}
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x006577F0 File Offset: 0x006559F0
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x006578A4 File Offset: 0x00655AA4
		public bool RadErgoWideStealthSaveDayNightMode_A36492_Editable
		{
			get
			{
				short num = (short)372198871;
				short num2 = num;
				num = (short)870272471;
				switch (num2 == num)
				{
				}
				num = (short)1291321344;
				short num3 = num;
				num = (short)837615617;
				if (num != 0)
				{
				}
				num = (short)889454592;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.Editable;
			}
			set
			{
				short num = (short)44433723;
				short num2 = num;
				num = (short)1952186683;
				switch (num2 == num)
				{
				}
				num = (short)2024800256;
				short num3 = num;
				num = (short)2003107841;
				if (num != 0)
				{
				}
				num = (short)510590976;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.Editable = value;
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x0065795C File Offset: 0x00655B5C
		internal string RadErgoWideStealthSaveDayNightMode_A36492_UILabel
		{
			get
			{
				short num = (short)1339524584;
				short num2 = num;
				num = (short)1993442792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188153856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)375783425;
				if (num != 0)
				{
				}
				num = (short)1680867328;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.UIName;
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x00657A10 File Offset: 0x00655C10
		// (set) Token: 0x06007209 RID: 29193 RVA: 0x00657AC4 File Offset: 0x00655CC4
		internal bool RadErgoWideStealthSaveDayNightMode_A36492_HiddenStatic
		{
			get
			{
				short num = (short)1901160736;
				short num2 = num;
				num = (short)482044192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150877696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618725377;
				if (num != 0)
				{
				}
				num = (short)1224540160;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.HiddenStatic;
			}
			set
			{
				short num = (short)1145641031;
				short num2 = num;
				num = (short)1082660935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673579008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492385793;
				if (num != 0)
				{
				}
				num = (short)1564672000;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.HiddenStatic = value;
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x00657B78 File Offset: 0x00655D78
		// (set) Token: 0x0600720B RID: 29195 RVA: 0x00657C28 File Offset: 0x00655E28
		internal bool RadErgoWideStealthSaveDayNightMode_A36492_HiddenDynamic
		{
			get
			{
				short num = (short)215285761;
				if (num != 0)
				{
				}
				num = (short)505806848;
				short num2 = num;
				num = (short)2038081809;
				short num3 = num;
				num = (short)1096001809;
				switch (num3 == num)
				{
				}
				num = (short)1173946368;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492.HiddenDynamic;
			}
			set
			{
				short num = (short)480280014;
				short num2 = num;
				num = (short)134577614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1674051584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)221315073;
				if (num != 0)
				{
				}
				num = (short)1975386112;
				if (num != 0)
				{
				}
				this.radErgoWideStealthSaveDayNightMode_A36492.HiddenDynamic = value;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x00657CDC File Offset: 0x00655EDC
		public bool RadErgoWideStealthSaveDayNightMode_A36492_HasDiffs
		{
			get
			{
				short num = (short)1824249550;
				short num2 = num;
				num = (short)240834254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1263337472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754384896;
				if (num != 0)
				{
				}
				num = (short)444661761;
				if (num != 0)
				{
				}
				return this.radErgoWideStealthSaveDayNightMode_A36492._HasDiffs;
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x00657D90 File Offset: 0x00655F90
		// (set) Token: 0x0600720E RID: 29198 RVA: 0x00657E44 File Offset: 0x00656044
		public int RadErgoDisGeneralSysRegIndicator_A37603Value
		{
			get
			{
				short num = (short)99104735;
				short num2 = num;
				num = (short)335427551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643839488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721813505;
				if (num != 0)
				{
				}
				num = (short)1449852928;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.Value;
			}
			set
			{
				short num = (short)1619885830;
				short num2 = num;
				num = (short)1434353414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773783552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)1675558912;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.Value = value;
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600720F RID: 29199 RVA: 0x00657EFC File Offset: 0x006560FC
		// (set) Token: 0x06007210 RID: 29200 RVA: 0x00657FB0 File Offset: 0x006561B0
		public string RadErgoDisGeneralSysRegIndicator_A37603_UIValue
		{
			get
			{
				short num = (short)2031617;
				if (num != 0)
				{
				}
				num = (short)1345781760;
				short num2 = num;
				num = (short)1094270819;
				short num3 = num;
				num = (short)1252802403;
				switch (num3 == num)
				{
				}
				num = (short)450560000;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.UIValue;
			}
			set
			{
				short num = (short)341690662;
				short num2 = num;
				num = (short)1723255078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735707136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1455816705;
				if (num != 0)
				{
				}
				num = (short)999489536;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.UIValue = value;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x06007211 RID: 29201 RVA: 0x00658064 File Offset: 0x00656264
		public global::AcpBusinessLayer.AcpListField RadErgoDisGeneralSysRegIndicator_A37603
		{
			get
			{
				short num = (short)1163184082;
				short num2 = num;
				num = (short)1185925074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1325531136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970784769;
				if (num != 0)
				{
				}
				num = (short)1631715328;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603;
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x06007212 RID: 29202 RVA: 0x00658118 File Offset: 0x00656318
		// (set) Token: 0x06007213 RID: 29203 RVA: 0x006581D0 File Offset: 0x006563D0
		public bool RadErgoDisGeneralSysRegIndicator_A37603_Applicable
		{
			get
			{
				short num = (short)1975866590;
				short num2 = num;
				num = (short)490231006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571225600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622867969;
				if (num != 0)
				{
				}
				num = (short)843251712;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.Applicable;
			}
			set
			{
				short num = (short)1827454176;
				short num2 = num;
				num = (short)1682226400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210501632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1061814272;
				if (num != 0)
				{
				}
				num = (short)160759809;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.Applicable = value;
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x06007214 RID: 29204 RVA: 0x00658288 File Offset: 0x00656488
		// (set) Token: 0x06007215 RID: 29205 RVA: 0x00658340 File Offset: 0x00656540
		public bool RadErgoDisGeneralSysRegIndicator_A37603_Valid
		{
			get
			{
				short num = (short)1040745149;
				short num2 = num;
				num = (short)16089789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)677707776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229900288;
				if (num != 0)
				{
				}
				num = (short)1534132225;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.Valid;
			}
			set
			{
				short num = (short)1182793729;
				if (num != 0)
				{
				}
				num = (short)86310912;
				short num2 = num;
				num = (short)374443755;
				short num3 = num;
				num = (short)1324519147;
				switch (num3 == num)
				{
				}
				num = (short)1957560320;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.Valid = value;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x06007216 RID: 29206 RVA: 0x006583F8 File Offset: 0x006565F8
		// (set) Token: 0x06007217 RID: 29207 RVA: 0x006584AC File Offset: 0x006566AC
		public bool RadErgoDisGeneralSysRegIndicator_A37603_Visible
		{
			get
			{
				short num = (short)1497085127;
				short num2 = num;
				num = (short)1416344775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449773568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)337182720;
				if (num != 0)
				{
				}
				num = (short)1857945601;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.Visible;
			}
			set
			{
				short num = (short)845570264;
				short num2 = num;
				num = (short)2048024792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)692125696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158662657;
				if (num != 0)
				{
				}
				num = (short)2068643840;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.Visible = value;
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x06007218 RID: 29208 RVA: 0x00658560 File Offset: 0x00656760
		// (set) Token: 0x06007219 RID: 29209 RVA: 0x00658614 File Offset: 0x00656814
		public bool RadErgoDisGeneralSysRegIndicator_A37603_Editable
		{
			get
			{
				short num = (short)403226841;
				short num2 = num;
				num = (short)681296089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377028608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502216193;
				if (num != 0)
				{
				}
				num = (short)1180958720;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.Editable;
			}
			set
			{
				short num = (short)503440115;
				short num2 = num;
				num = (short)84337395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557318144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1726414849;
				if (num != 0)
				{
				}
				num = (short)271712256;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.Editable = value;
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600721A RID: 29210 RVA: 0x006586CC File Offset: 0x006568CC
		internal string RadErgoDisGeneralSysRegIndicator_A37603_UILabel
		{
			get
			{
				short num = (short)575734718;
				short num2 = num;
				num = (short)1953432510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111935488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)821035008;
				if (num != 0)
				{
				}
				num = (short)1814953985;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.UIName;
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600721B RID: 29211 RVA: 0x00658780 File Offset: 0x00656980
		// (set) Token: 0x0600721C RID: 29212 RVA: 0x00658834 File Offset: 0x00656A34
		internal bool RadErgoDisGeneralSysRegIndicator_A37603_HiddenStatic
		{
			get
			{
				short num = (short)1840987591;
				short num2 = num;
				num = (short)1842298311;
				switch (num2 == num)
				{
				default:
				{
					num = (short)103940096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665859585;
				if (num != 0)
				{
				}
				num = (short)1981022208;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.HiddenStatic;
			}
			set
			{
				short num = (short)2098593793;
				if (num != 0)
				{
				}
				num = (short)911474688;
				short num2 = num;
				num = (short)865119527;
				short num3 = num;
				num = (short)2134879527;
				switch (num3 == num)
				{
				}
				num = (short)740360192;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.HiddenStatic = value;
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600721D RID: 29213 RVA: 0x006588E8 File Offset: 0x00656AE8
		// (set) Token: 0x0600721E RID: 29214 RVA: 0x006589A0 File Offset: 0x00656BA0
		internal bool RadErgoDisGeneralSysRegIndicator_A37603_HiddenDynamic
		{
			get
			{
				short num = (short)1321336833;
				if (num != 0)
				{
				}
				num = (short)850001920;
				short num2 = num;
				num = (short)356688553;
				short num3 = num;
				num = (short)1742316201;
				switch (num3 == num)
				{
				}
				num = (short)1474035712;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603.HiddenDynamic;
			}
			set
			{
				short num = (short)1361989502;
				short num2 = num;
				num = (short)103894910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492175360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604386817;
				if (num != 0)
				{
				}
				num = (short)1835008;
				if (num != 0)
				{
				}
				this.radErgoDisGeneralSysRegIndicator_A37603.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600721F RID: 29215 RVA: 0x00658A54 File Offset: 0x00656C54
		public bool RadErgoDisGeneralSysRegIndicator_A37603_HasDiffs
		{
			get
			{
				short num = (short)1597601453;
				short num2 = num;
				num = (short)747337389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341966848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942604288;
				if (num != 0)
				{
				}
				num = (short)1469775873;
				if (num != 0)
				{
				}
				return this.radErgoDisGeneralSysRegIndicator_A37603._HasDiffs;
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x06007220 RID: 29216 RVA: 0x00658B08 File Offset: 0x00656D08
		// (set) Token: 0x06007221 RID: 29217 RVA: 0x00658BC0 File Offset: 0x00656DC0
		public int DispMenuGeneralSiteTrunkingIndicator_A7426Value
		{
			get
			{
				short num = (short)1131723268;
				short num2 = num;
				num = (short)85899780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890109952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433272321;
				if (num != 0)
				{
				}
				num = (short)609419264;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.Value;
			}
			set
			{
				short num = (short)636153840;
				short num2 = num;
				num = (short)1506013168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1700593664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715587585;
				if (num != 0)
				{
				}
				num = (short)662175744;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.Value = value;
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x06007222 RID: 29218 RVA: 0x00658C74 File Offset: 0x00656E74
		// (set) Token: 0x06007223 RID: 29219 RVA: 0x00658D28 File Offset: 0x00656F28
		public string DispMenuGeneralSiteTrunkingIndicator_A7426_UIValue
		{
			get
			{
				short num = (short)1738853922;
				short num2 = num;
				num = (short)1489882658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1877409792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532873217;
				if (num != 0)
				{
				}
				num = (short)650379264;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.UIValue;
			}
			set
			{
				short num = (short)1217953772;
				short num2 = num;
				num = (short)1669103596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565051392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1556545537;
				if (num != 0)
				{
				}
				num = (short)1425997824;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.UIValue = value;
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x06007224 RID: 29220 RVA: 0x00658DE0 File Offset: 0x00656FE0
		public global::AcpBusinessLayer.AcpListField DispMenuGeneralSiteTrunkingIndicator_A7426
		{
			get
			{
				short num = (short)1909506090;
				short num2 = num;
				num = (short)866304042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1740701696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134100481;
				if (num != 0)
				{
				}
				num = (short)1040646144;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426;
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x06007225 RID: 29221 RVA: 0x00658E8C File Offset: 0x0065708C
		// (set) Token: 0x06007226 RID: 29222 RVA: 0x00658F40 File Offset: 0x00657140
		public bool DispMenuGeneralSiteTrunkingIndicator_A7426_Applicable
		{
			get
			{
				short num = (short)1569459201;
				short num2 = num;
				num = (short)1368067073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5373952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075918337;
				if (num != 0)
				{
				}
				num = (short)1151729664;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.Applicable;
			}
			set
			{
				short num = (short)402259969;
				if (num != 0)
				{
				}
				num = (short)93454336;
				short num2 = num;
				num = (short)2022102593;
				short num3 = num;
				num = (short)1288558145;
				switch (num3 == num)
				{
				}
				num = (short)289472512;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.Applicable = value;
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x06007227 RID: 29223 RVA: 0x00658FF4 File Offset: 0x006571F4
		// (set) Token: 0x06007228 RID: 29224 RVA: 0x006590A8 File Offset: 0x006572A8
		public bool DispMenuGeneralSiteTrunkingIndicator_A7426_Valid
		{
			get
			{
				short num = (short)2068274852;
				short num2 = num;
				num = (short)3628708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446562304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1410007041;
				if (num != 0)
				{
				}
				num = (short)606076928;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.Valid;
			}
			set
			{
				short num = (short)2113702137;
				short num2 = num;
				num = (short)1301055737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1280573440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800732672;
				if (num != 0)
				{
				}
				num = (short)1656291329;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.Valid = value;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x0065915C File Offset: 0x0065735C
		// (set) Token: 0x0600722A RID: 29226 RVA: 0x00659210 File Offset: 0x00657410
		public bool DispMenuGeneralSiteTrunkingIndicator_A7426_Visible
		{
			get
			{
				short num = (short)538850726;
				short num2 = num;
				num = (short)945108390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)392495104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781137409;
				if (num != 0)
				{
				}
				num = (short)597753856;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.Visible;
			}
			set
			{
				short num = (short)1496716295;
				short num2 = num;
				num = (short)370021383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414070272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319881216;
				if (num != 0)
				{
				}
				num = (short)26017793;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.Visible = value;
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x006592C8 File Offset: 0x006574C8
		// (set) Token: 0x0600722C RID: 29228 RVA: 0x00659380 File Offset: 0x00657580
		public bool DispMenuGeneralSiteTrunkingIndicator_A7426_Editable
		{
			get
			{
				short num = (short)146841514;
				short num2 = num;
				num = (short)1275174826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)512229376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258618881;
				if (num != 0)
				{
				}
				num = (short)708575232;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.Editable;
			}
			set
			{
				short num = (short)812154930;
				short num2 = num;
				num = (short)1148026930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240910336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206583297;
				if (num != 0)
				{
				}
				num = (short)494600192;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.Editable = value;
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x00659434 File Offset: 0x00657634
		internal string DispMenuGeneralSiteTrunkingIndicator_A7426_UILabel
		{
			get
			{
				short num = (short)2097841896;
				short num2 = num;
				num = (short)2112390888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430178304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190840832;
				if (num != 0)
				{
				}
				num = (short)947585025;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.UIName;
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600722E RID: 29230 RVA: 0x006594E8 File Offset: 0x006576E8
		// (set) Token: 0x0600722F RID: 29231 RVA: 0x0065959C File Offset: 0x0065779C
		internal bool DispMenuGeneralSiteTrunkingIndicator_A7426_HiddenStatic
		{
			get
			{
				short num = (short)151388161;
				if (num != 0)
				{
				}
				num = (short)43384832;
				short num2 = num;
				num = (short)2052544153;
				short num3 = num;
				num = (short)822564505;
				switch (num3 == num)
				{
				}
				num = (short)159842304;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.HiddenStatic;
			}
			set
			{
				short num = (short)665125665;
				short num2 = num;
				num = (short)1321534241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755957760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385548288;
				if (num != 0)
				{
				}
				num = (short)1955135489;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.HiddenStatic = value;
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x06007230 RID: 29232 RVA: 0x00659650 File Offset: 0x00657850
		// (set) Token: 0x06007231 RID: 29233 RVA: 0x00659704 File Offset: 0x00657904
		internal bool DispMenuGeneralSiteTrunkingIndicator_A7426_HiddenDynamic
		{
			get
			{
				short num = (short)13901228;
				short num2 = num;
				num = (short)1636769196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046558208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969867265;
				if (num != 0)
				{
				}
				num = (short)451805184;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426.HiddenDynamic;
			}
			set
			{
				short num = (short)950254753;
				short num2 = num;
				num = (short)1236122785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1572864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)363921408;
				if (num != 0)
				{
				}
				num = (short)360054785;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSiteTrunkingIndicator_A7426.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x06007232 RID: 29234 RVA: 0x006597B8 File Offset: 0x006579B8
		public bool DispMenuGeneralSiteTrunkingIndicator_A7426_HasDiffs
		{
			get
			{
				short num = (short)1468189649;
				short num2 = num;
				num = (short)1065798609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064384000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498204673;
				if (num != 0)
				{
				}
				num = (short)730202112;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSiteTrunkingIndicator_A7426._HasDiffs;
			}
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x06007233 RID: 29235 RVA: 0x00659870 File Offset: 0x00657A70
		// (set) Token: 0x06007234 RID: 29236 RVA: 0x00659924 File Offset: 0x00657B24
		public int DispMenuGeneralFastScrollRatems_A8014Value
		{
			get
			{
				short num = (short)1188863482;
				short num2 = num;
				num = (short)1547214330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)693108736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2001928193;
				if (num != 0)
				{
				}
				num = (short)1910046720;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Value;
			}
			set
			{
				short num = (short)1544850827;
				short num2 = num;
				num = (short)1770884491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603076096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)607911937;
				if (num != 0)
				{
				}
				num = (short)410648576;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Value = value;
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x006599D8 File Offset: 0x00657BD8
		public global::AcpBusinessLayer.AcpRangeField<int, string> DispMenuGeneralFastScrollRatems_A8014
		{
			get
			{
				short num = (short)59817641;
				short num2 = num;
				num = (short)207601321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720582144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090387969;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014;
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x06007236 RID: 29238 RVA: 0x00659A88 File Offset: 0x00657C88
		// (set) Token: 0x06007237 RID: 29239 RVA: 0x00659B40 File Offset: 0x00657D40
		public string DispMenuGeneralFastScrollRatems_A8014_UIValue
		{
			get
			{
				short num = (short)480279287;
				short num2 = num;
				num = (short)611154679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)357302272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527564800;
				if (num != 0)
				{
				}
				num = (short)1215168513;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.UIValue;
			}
			set
			{
				short num = (short)1597205498;
				short num2 = num;
				num = (short)450194426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2104688640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129368065;
				if (num != 0)
				{
				}
				num = (short)399769600;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.UIValue = value;
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x00659BF4 File Offset: 0x00657DF4
		// (set) Token: 0x06007239 RID: 29241 RVA: 0x00659CA8 File Offset: 0x00657EA8
		internal int DispMenuGeneralFastScrollRatems_A8014Min
		{
			get
			{
				short num = (short)1512026596;
				short num2 = num;
				num = (short)1249685988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192427520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514850816;
				if (num != 0)
				{
				}
				num = (short)1819541505;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Min;
			}
			set
			{
				short num = (short)1216086016;
				short num2 = num;
				num = (short)955284764;
				short num3 = num;
				num = (short)815693084;
				switch (num3 == num)
				{
				}
				num = (short)1823866881;
				if (num != 0)
				{
				}
				num = (short)1972764672;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Min = value;
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600723A RID: 29242 RVA: 0x00659D60 File Offset: 0x00657F60
		// (set) Token: 0x0600723B RID: 29243 RVA: 0x00659E18 File Offset: 0x00658018
		internal int DispMenuGeneralFastScrollRatems_A8014Max
		{
			get
			{
				short num = (short)157286400;
				short num2 = num;
				num = (short)1734475777;
				if (num != 0)
				{
				}
				num = (short)94716600;
				short num3 = num;
				num = (short)1594114744;
				switch (num3 == num)
				{
				}
				num = (short)639107072;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Max;
			}
			set
			{
				short num = (short)248381440;
				short num2 = num;
				num = (short)106586840;
				short num3 = num;
				num = (short)168846040;
				switch (num3 == num)
				{
				}
				num = (short)1135214593;
				if (num != 0)
				{
				}
				num = (short)727121920;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Max = value;
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600723C RID: 29244 RVA: 0x00659ED0 File Offset: 0x006580D0
		// (set) Token: 0x0600723D RID: 29245 RVA: 0x00659F8C File Offset: 0x0065818C
		internal int DispMenuGeneralFastScrollRatems_A8014Step
		{
			get
			{
				short num = (short)396492800;
				short num2 = num;
				num = (short)925387288;
				short num3 = num;
				num = (short)1658800664;
				switch (num3 == num)
				{
				}
				num = (short)1808203777;
				if (num != 0)
				{
				}
				num = (short)1110048768;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.StepSize;
			}
			set
			{
				short num = (short)380239872;
				short num2 = num;
				num = (short)1349108595;
				short num3 = num;
				num = (short)118604659;
				switch (num3 == num)
				{
				}
				num = (short)1040973825;
				if (num != 0)
				{
				}
				num = (short)1028784128;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.StepSize = value;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600723E RID: 29246 RVA: 0x0065A040 File Offset: 0x00658240
		// (set) Token: 0x0600723F RID: 29247 RVA: 0x0065A0F4 File Offset: 0x006582F4
		public bool DispMenuGeneralFastScrollRatems_A8014_Applicable
		{
			get
			{
				short num = (short)1929969664;
				short num2 = num;
				num = (short)942145537;
				if (num != 0)
				{
				}
				num = (short)1172756672;
				short num3 = num;
				num = (short)1278662848;
				switch (num3 == num)
				{
				}
				num = (short)920256512;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Applicable;
			}
			set
			{
				short num = (short)274661376;
				short num2 = num;
				num = (short)895796854;
				short num3 = num;
				num = (short)1960429174;
				switch (num3 == num)
				{
				}
				num = (short)1855913985;
				if (num != 0)
				{
				}
				num = (short)1401028608;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Applicable = value;
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x0065A1A8 File Offset: 0x006583A8
		// (set) Token: 0x06007241 RID: 29249 RVA: 0x0065A25C File Offset: 0x0065845C
		public bool DispMenuGeneralFastScrollRatems_A8014_Valid
		{
			get
			{
				short num = (short)1708720128;
				short num2 = num;
				num = (short)1916389576;
				short num3 = num;
				num = (short)588957896;
				switch (num3 == num)
				{
				}
				num = (short)1537146881;
				if (num != 0)
				{
				}
				num = (short)769196032;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Valid;
			}
			set
			{
				short num = (short)1594621952;
				short num2 = num;
				num = (short)2097361508;
				short num3 = num;
				num = (short)42152548;
				switch (num3 == num)
				{
				}
				num = (short)858652673;
				if (num != 0)
				{
				}
				num = (short)1535115264;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Valid = value;
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x0065A310 File Offset: 0x00658510
		// (set) Token: 0x06007243 RID: 29251 RVA: 0x0065A3C8 File Offset: 0x006585C8
		public bool DispMenuGeneralFastScrollRatems_A8014_Visible
		{
			get
			{
				short num = (short)1700462592;
				short num2 = num;
				num = (short)1797178314;
				short num3 = num;
				num = (short)1931002826;
				switch (num3 == num)
				{
				}
				num = (short)95420417;
				if (num != 0)
				{
				}
				num = (short)768081920;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Visible;
			}
			set
			{
				short num = (short)279707648;
				short num2 = num;
				num = (short)449111774;
				short num3 = num;
				num = (short)1865017054;
				switch (num3 == num)
				{
				}
				num = (short)643104768;
				if (num != 0)
				{
				}
				num = (short)546308097;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Visible = value;
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x06007244 RID: 29252 RVA: 0x0065A480 File Offset: 0x00658680
		// (set) Token: 0x06007245 RID: 29253 RVA: 0x0065A534 File Offset: 0x00658734
		public bool DispMenuGeneralFastScrollRatems_A8014_Editable
		{
			get
			{
				short num = (short)1368260608;
				short num2 = num;
				num = (short)1549429180;
				short num3 = num;
				num = (short)1520724412;
				switch (num3 == num)
				{
				}
				num = (short)488439809;
				if (num != 0)
				{
				}
				num = (short)1741881344;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.Editable;
			}
			set
			{
				short num = (short)1701249024;
				short num2 = num;
				num = (short)353697562;
				short num3 = num;
				num = (short)102367002;
				switch (num3 == num)
				{
				}
				num = (short)234946561;
				if (num != 0)
				{
				}
				num = (short)548864000;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.Editable = value;
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x06007246 RID: 29254 RVA: 0x0065A5E8 File Offset: 0x006587E8
		internal string DispMenuGeneralFastScrollRatems_A8014_UILabel
		{
			get
			{
				short num = (short)22282240;
				short num2 = num;
				num = (short)1433698105;
				short num3 = num;
				num = (short)1657765689;
				switch (num3 == num)
				{
				}
				num = (short)474218496;
				if (num != 0)
				{
				}
				num = (short)581959681;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.UIName;
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x06007247 RID: 29255 RVA: 0x0065A69C File Offset: 0x0065889C
		// (set) Token: 0x06007248 RID: 29256 RVA: 0x0065A754 File Offset: 0x00658954
		internal bool DispMenuGeneralFastScrollRatems_A8014_HiddenStatic
		{
			get
			{
				short num = (short)1952120832;
				short num2 = num;
				num = (short)1922433025;
				if (num != 0)
				{
				}
				num = (short)715373861;
				short num3 = num;
				num = (short)2013314341;
				switch (num3 == num)
				{
				}
				num = (short)1067646976;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.HiddenStatic;
			}
			set
			{
				short num = (short)1861746688;
				short num2 = num;
				num = (short)889450896;
				short num3 = num;
				num = (short)956952976;
				switch (num3 == num)
				{
				}
				num = (short)466223105;
				if (num != 0)
				{
				}
				num = (short)1227816960;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.HiddenStatic = value;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x0065A808 File Offset: 0x00658A08
		// (set) Token: 0x0600724A RID: 29258 RVA: 0x0065A8C0 File Offset: 0x00658AC0
		internal bool DispMenuGeneralFastScrollRatems_A8014_HiddenDynamic
		{
			get
			{
				short num = (short)1034289152;
				short num2 = num;
				num = (short)543946298;
				short num3 = num;
				num = (short)1603335738;
				switch (num3 == num)
				{
				}
				num = (short)1084751873;
				if (num != 0)
				{
				}
				num = (short)774176768;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014.HiddenDynamic;
			}
			set
			{
				short num = (short)1135149056;
				short num2 = num;
				num = (short)355729409;
				if (num != 0)
				{
				}
				num = (short)504837095;
				short num3 = num;
				num = (short)1194275815;
				switch (num3 == num)
				{
				}
				num = (short)1207762944;
				if (num != 0)
				{
				}
				this.dispMenuGeneralFastScrollRatems_A8014.HiddenDynamic = value;
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x0065A978 File Offset: 0x00658B78
		public bool DispMenuGeneralFastScrollRatems_A8014_HasDiffs
		{
			get
			{
				short num = (short)2019753984;
				short num2 = num;
				num = (short)339430679;
				short num3 = num;
				num = (short)1123765527;
				switch (num3 == num)
				{
				}
				num = (short)62652417;
				if (num != 0)
				{
				}
				num = (short)1351614464;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralFastScrollRatems_A8014._HasDiffs;
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x0065AA30 File Offset: 0x00658C30
		// (set) Token: 0x0600724D RID: 29261 RVA: 0x0065AAE4 File Offset: 0x00658CE4
		public int DispMenuGeneralSlowScrollRatems_A9161Value
		{
			get
			{
				short num = (short)1837629440;
				short num2 = num;
				num = (short)389642980;
				short num3 = num;
				num = (short)46365412;
				switch (num3 == num)
				{
				}
				num = (short)1417609217;
				if (num != 0)
				{
				}
				num = (short)1170800640;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Value;
			}
			set
			{
				short num = (short)520028160;
				short num2 = num;
				num = (short)313136413;
				short num3 = num;
				num = (short)1308169501;
				switch (num3 == num)
				{
				}
				num = (short)1077477377;
				if (num != 0)
				{
				}
				num = (short)358678528;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Value = value;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x0065AB9C File Offset: 0x00658D9C
		public global::AcpBusinessLayer.AcpRangeField<int, string> DispMenuGeneralSlowScrollRatems_A9161
		{
			get
			{
				short num = (short)725680128;
				short num2 = num;
				num = (short)1988493313;
				if (num != 0)
				{
				}
				num = (short)1313923238;
				short num3 = num;
				num = (short)1454497958;
				switch (num3 == num)
				{
				}
				num = (short)1418133504;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x0065AC4C File Offset: 0x00658E4C
		// (set) Token: 0x06007250 RID: 29264 RVA: 0x0065AD00 File Offset: 0x00658F00
		public string DispMenuGeneralSlowScrollRatems_A9161_UIValue
		{
			get
			{
				short num = (short)204406784;
				short num2 = num;
				num = (short)848378352;
				short num3 = num;
				num = (short)2085239280;
				switch (num3 == num)
				{
				}
				num = (short)1971322881;
				if (num != 0)
				{
				}
				num = (short)464715776;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.UIValue;
			}
			set
			{
				short num = (short)565444608;
				short num2 = num;
				num = (short)631439361;
				if (num != 0)
				{
				}
				num = (short)584813657;
				short num3 = num;
				num = (short)1624411225;
				switch (num3 == num)
				{
				}
				num = (short)1243545600;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.UIValue = value;
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x06007251 RID: 29265 RVA: 0x0065ADB4 File Offset: 0x00658FB4
		// (set) Token: 0x06007252 RID: 29266 RVA: 0x0065AE6C File Offset: 0x0065906C
		internal int DispMenuGeneralSlowScrollRatems_A9161Min
		{
			get
			{
				short num = (short)2086993920;
				short num2 = num;
				num = (short)1496252573;
				short num3 = num;
				num = (short)1112866973;
				switch (num3 == num)
				{
				}
				num = (short)933101568;
				if (num != 0)
				{
				}
				num = (short)784400385;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Min;
			}
			set
			{
				short num = (short)518782976;
				short num2 = num;
				num = (short)357048346;
				short num3 = num;
				num = (short)1118183450;
				switch (num3 == num)
				{
				}
				num = (short)896466944;
				if (num != 0)
				{
				}
				num = (short)1576796161;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Min = value;
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x0065AF24 File Offset: 0x00659124
		// (set) Token: 0x06007254 RID: 29268 RVA: 0x0065AFD8 File Offset: 0x006591D8
		internal int DispMenuGeneralSlowScrollRatems_A9161Max
		{
			get
			{
				short num = (short)1416167424;
				short num2 = num;
				num = (short)1370091653;
				short num3 = num;
				num = (short)1713631365;
				switch (num3 == num)
				{
				}
				num = (short)1958739969;
				if (num != 0)
				{
				}
				num = (short)1976696832;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Max;
			}
			set
			{
				short num = (short)1985675264;
				short num2 = num;
				num = (short)784062167;
				short num3 = num;
				num = (short)225367767;
				switch (num3 == num)
				{
				}
				num = (short)1721434112;
				if (num != 0)
				{
				}
				num = (short)248905729;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Max = value;
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x0065B08C File Offset: 0x0065928C
		// (set) Token: 0x06007256 RID: 29270 RVA: 0x0065B13C File Offset: 0x0065933C
		internal int DispMenuGeneralSlowScrollRatems_A9161Step
		{
			get
			{
				short num = (short)400293888;
				short num2 = num;
				num = (short)1742733313;
				if (num != 0)
				{
				}
				num = (short)1330295172;
				short num3 = num;
				num = (short)1136636292;
				switch (num3 == num)
				{
				}
				num = (short)1427963904;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.StepSize;
			}
			set
			{
				short num = (short)1605763072;
				short num2 = num;
				num = (short)369879329;
				short num3 = num;
				num = (short)957933857;
				switch (num3 == num)
				{
				}
				num = (short)1129316353;
				if (num != 0)
				{
				}
				num = (short)1732313088;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.StepSize = value;
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x0065B1F4 File Offset: 0x006593F4
		// (set) Token: 0x06007258 RID: 29272 RVA: 0x0065B2AC File Offset: 0x006594AC
		public bool DispMenuGeneralSlowScrollRatems_A9161_Applicable
		{
			get
			{
				short num = (short)420151296;
				short num2 = num;
				num = (short)1223228251;
				short num3 = num;
				num = (short)1622473563;
				switch (num3 == num)
				{
				}
				num = (short)1753219073;
				if (num != 0)
				{
				}
				num = (short)2040397824;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Applicable;
			}
			set
			{
				short num = (short)791871488;
				short num2 = num;
				num = (short)3241208;
				short num3 = num;
				num = (short)1509061880;
				switch (num3 == num)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)1208418304;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Applicable = value;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x0065B364 File Offset: 0x00659564
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x0065B414 File Offset: 0x00659614
		public bool DispMenuGeneralSlowScrollRatems_A9161_Valid
		{
			get
			{
				short num = (short)2009989120;
				short num2 = num;
				num = (short)1637351425;
				if (num != 0)
				{
				}
				num = (short)740975143;
				short num3 = num;
				num = (short)956588583;
				switch (num3 == num)
				{
				}
				num = (short)698023936;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Valid;
			}
			set
			{
				short num = (short)627965952;
				short num2 = num;
				num = (short)458411527;
				short num3 = num;
				num = (short)110349831;
				switch (num3 == num)
				{
				}
				num = (short)422379520;
				if (num != 0)
				{
				}
				num = (short)1958608897;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Valid = value;
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x0065B4C8 File Offset: 0x006596C8
		// (set) Token: 0x0600725C RID: 29276 RVA: 0x0065B57C File Offset: 0x0065977C
		public bool DispMenuGeneralSlowScrollRatems_A9161_Visible
		{
			get
			{
				short num = (short)1662582784;
				short num2 = num;
				num = (short)778650382;
				short num3 = num;
				num = (short)1273971470;
				switch (num3 == num)
				{
				}
				num = (short)1528102913;
				if (num != 0)
				{
				}
				num = (short)728629248;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Visible;
			}
			set
			{
				short num = (short)1907621888;
				short num2 = num;
				num = (short)403163464;
				short num3 = num;
				num = (short)946522440;
				switch (num3 == num)
				{
				}
				num = (short)1437138945;
				if (num != 0)
				{
				}
				num = (short)320405504;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Visible = value;
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600725D RID: 29277 RVA: 0x0065B634 File Offset: 0x00659834
		// (set) Token: 0x0600725E RID: 29278 RVA: 0x0065B6E8 File Offset: 0x006598E8
		public bool DispMenuGeneralSlowScrollRatems_A9161_Editable
		{
			get
			{
				short num = (short)1961558016;
				short num2 = num;
				num = (short)1711633257;
				short num3 = num;
				num = (short)902001513;
				switch (num3 == num)
				{
				}
				num = (short)216203265;
				if (num != 0)
				{
				}
				num = (short)1236402176;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.Editable;
			}
			set
			{
				short num = (short)2059010048;
				short num2 = num;
				num = (short)1791693963;
				short num3 = num;
				num = (short)2031555723;
				switch (num3 == num)
				{
				}
				num = (short)1138098176;
				if (num != 0)
				{
				}
				num = (short)956366849;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.Editable = value;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600725F RID: 29279 RVA: 0x0065B7A0 File Offset: 0x006599A0
		internal string DispMenuGeneralSlowScrollRatems_A9161_UILabel
		{
			get
			{
				short num = (short)413925376;
				short num2 = num;
				num = (short)1028834693;
				short num3 = num;
				num = (short)989971845;
				switch (num3 == num)
				{
				}
				num = (short)840040449;
				if (num != 0)
				{
				}
				num = (short)1020985344;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.UIName;
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x0065B854 File Offset: 0x00659A54
		// (set) Token: 0x06007261 RID: 29281 RVA: 0x0065B908 File Offset: 0x00659B08
		internal bool DispMenuGeneralSlowScrollRatems_A9161_HiddenStatic
		{
			get
			{
				short num = (short)770375680;
				short num2 = num;
				num = (short)1424579813;
				short num3 = num;
				num = (short)1589206245;
				switch (num3 == num)
				{
				}
				num = (short)1149173761;
				if (num != 0)
				{
				}
				num = (short)1614675968;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.HiddenStatic;
			}
			set
			{
				short num = (short)162660352;
				short num2 = num;
				num = (short)2096450960;
				short num3 = num;
				num = (short)703090064;
				switch (num3 == num)
				{
				}
				num = (short)35717121;
				if (num != 0)
				{
				}
				num = (short)531955712;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.HiddenStatic = value;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x0065B9C0 File Offset: 0x00659BC0
		// (set) Token: 0x06007263 RID: 29283 RVA: 0x0065BA78 File Offset: 0x00659C78
		internal bool DispMenuGeneralSlowScrollRatems_A9161_HiddenDynamic
		{
			get
			{
				short num = (short)1426980864;
				short num2 = num;
				num = (short)1963513569;
				short num3 = num;
				num = (short)1137563361;
				switch (num3 == num)
				{
				}
				num = (short)1109721088;
				if (num != 0)
				{
				}
				num = (short)82444289;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161.HiddenDynamic;
			}
			set
			{
				short num = (short)2011561984;
				short num2 = num;
				num = (short)877153741;
				short num3 = num;
				num = (short)1172000205;
				switch (num3 == num)
				{
				}
				num = (short)428277760;
				if (num != 0)
				{
				}
				num = (short)972029953;
				if (num != 0)
				{
				}
				this.dispMenuGeneralSlowScrollRatems_A9161.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x06007264 RID: 29284 RVA: 0x0065BB2C File Offset: 0x00659D2C
		public bool DispMenuGeneralSlowScrollRatems_A9161_HasDiffs
		{
			get
			{
				short num = (short)34996224;
				short num2 = num;
				num = (short)2020459294;
				short num3 = num;
				num = (short)1456718622;
				switch (num3 == num)
				{
				}
				num = (short)1257177088;
				if (num != 0)
				{
				}
				num = (short)575864833;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralSlowScrollRatems_A9161._HasDiffs;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x0065BBE0 File Offset: 0x00659DE0
		// (set) Token: 0x06007266 RID: 29286 RVA: 0x0065BC94 File Offset: 0x00659E94
		public int RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160Value
		{
			get
			{
				short num = (short)1322057728;
				short num2 = num;
				num = (short)902459323;
				short num3 = num;
				num = (short)88633275;
				switch (num3 == num)
				{
				}
				num = (short)995360769;
				if (num != 0)
				{
				}
				num = (short)2006515712;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Value;
			}
			set
			{
				short num = (short)555679744;
				short num2 = num;
				num = (short)1873189221;
				short num3 = num;
				num = (short)1556060517;
				switch (num3 == num)
				{
				}
				num = (short)1131413505;
				if (num != 0)
				{
				}
				num = (short)2131427328;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Value = value;
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x0065BD48 File Offset: 0x00659F48
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x0065BDFC File Offset: 0x00659FFC
		public string RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_UIValue
		{
			get
			{
				short num = (short)944635904;
				short num2 = num;
				num = (short)176299666;
				short num3 = num;
				num = (short)888479378;
				switch (num3 == num)
				{
				}
				num = (short)571998208;
				if (num != 0)
				{
				}
				num = (short)935985153;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.UIValue;
			}
			set
			{
				short num = (short)846331904;
				short num2 = num;
				num = (short)711146856;
				short num3 = num;
				num = (short)354696552;
				switch (num3 == num)
				{
				}
				num = (short)280559616;
				if (num != 0)
				{
				}
				num = (short)1739456513;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.UIValue = value;
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x0065BEB4 File Offset: 0x0065A0B4
		public global::AcpBusinessLayer.AcpListField RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160
		{
			get
			{
				short num = (short)302252032;
				short num2 = num;
				num = (short)995823276;
				short num3 = num;
				num = (short)1761611436;
				switch (num3 == num)
				{
				}
				num = (short)1060241409;
				if (num != 0)
				{
				}
				num = (short)1186529280;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600726A RID: 29290 RVA: 0x0065BF64 File Offset: 0x0065A164
		// (set) Token: 0x0600726B RID: 29291 RVA: 0x0065C018 File Offset: 0x0065A218
		public bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_Applicable
		{
			get
			{
				short num = (short)1423572992;
				short num2 = num;
				num = (short)1088793705;
				short num3 = num;
				num = (short)1396157545;
				switch (num3 == num)
				{
				}
				num = (short)621871104;
				if (num != 0)
				{
				}
				num = (short)607387649;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Applicable;
			}
			set
			{
				short num = (short)6160384;
				short num2 = num;
				num = (short)777819985;
				short num3 = num;
				num = (short)1668781905;
				switch (num3 == num)
				{
				}
				num = (short)1750990848;
				if (num != 0)
				{
				}
				num = (short)44367873;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Applicable = value;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600726C RID: 29292 RVA: 0x0065C0CC File Offset: 0x0065A2CC
		// (set) Token: 0x0600726D RID: 29293 RVA: 0x0065C180 File Offset: 0x0065A380
		public bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_Valid
		{
			get
			{
				short num = (short)337707008;
				short num2 = num;
				num = (short)1176013505;
				short num3 = num;
				num = (short)771787457;
				switch (num3 == num)
				{
				}
				num = (short)286916609;
				if (num != 0)
				{
				}
				num = (short)985268224;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Valid;
			}
			set
			{
				short num = (short)710606848;
				short num2 = num;
				num = (short)1488989664;
				short num3 = num;
				num = (short)1974349280;
				switch (num3 == num)
				{
				}
				num = (short)684130304;
				if (num != 0)
				{
				}
				num = (short)1282998273;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Valid = value;
			}
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x0065C238 File Offset: 0x0065A438
		// (set) Token: 0x0600726F RID: 29295 RVA: 0x0065C2EC File Offset: 0x0065A4EC
		public bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_Visible
		{
			get
			{
				short num = (short)224919552;
				short num2 = num;
				num = (short)1760555286;
				short num3 = num;
				num = (short)1942155542;
				switch (num3 == num)
				{
				}
				num = (short)14614529;
				if (num != 0)
				{
				}
				num = (short)1626537984;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Visible;
			}
			set
			{
				short num = (short)608239616;
				short num2 = num;
				num = (short)1455660231;
				short num3 = num;
				num = (short)1984863431;
				switch (num3 == num)
				{
				}
				num = (short)1034551297;
				if (num != 0)
				{
				}
				num = (short)1861550080;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Visible = value;
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x0065C3A0 File Offset: 0x0065A5A0
		// (set) Token: 0x06007271 RID: 29297 RVA: 0x0065C454 File Offset: 0x0065A654
		public bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_Editable
		{
			get
			{
				short num = (short)624951296;
				short num2 = num;
				num = (short)1184537718;
				short num3 = num;
				num = (short)1194171510;
				switch (num3 == num)
				{
				}
				num = (short)1361117185;
				if (num != 0)
				{
				}
				num = (short)735641600;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Editable;
			}
			set
			{
				short num = (short)1773010944;
				short num2 = num;
				num = (short)1052379336;
				short num3 = num;
				num = (short)1506543816;
				switch (num3 == num)
				{
				}
				num = (short)2020540417;
				if (num != 0)
				{
				}
				num = (short)283115520;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.Editable = value;
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x0065C50C File Offset: 0x0065A70C
		internal string RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_UILabel
		{
			get
			{
				short num = (short)924254208;
				short num2 = num;
				num = (short)1771296382;
				short num3 = num;
				num = (short)1541658238;
				switch (num3 == num)
				{
				}
				num = (short)450166785;
				if (num != 0)
				{
				}
				num = (short)1233059840;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.UIName;
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x0065C5C0 File Offset: 0x0065A7C0
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x0065C674 File Offset: 0x0065A874
		internal bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_HiddenStatic
		{
			get
			{
				short num = (short)332005376;
				short num2 = num;
				num = (short)1592215931;
				short num3 = num;
				num = (short)1336559995;
				switch (num3 == num)
				{
				}
				num = (short)2100625408;
				if (num != 0)
				{
				}
				num = (short)1451687937;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.HiddenStatic;
			}
			set
			{
				short num = (short)1116733440;
				short num2 = num;
				num = (short)80061273;
				short num3 = num;
				num = (short)870163289;
				switch (num3 == num)
				{
				}
				num = (short)127336449;
				if (num != 0)
				{
				}
				num = (short)1301086208;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.HiddenStatic = value;
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x06007275 RID: 29301 RVA: 0x0065C728 File Offset: 0x0065A928
		// (set) Token: 0x06007276 RID: 29302 RVA: 0x0065C7DC File Offset: 0x0065A9DC
		internal bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_HiddenDynamic
		{
			get
			{
				short num = (short)2134507520;
				short num2 = num;
				num = (short)913762363;
				short num3 = num;
				num = (short)1164240955;
				switch (num3 == num)
				{
				}
				num = (short)1288306688;
				if (num != 0)
				{
				}
				num = (short)910753793;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.HiddenDynamic;
			}
			set
			{
				short num = (short)1979449344;
				short num2 = num;
				num = (short)668200862;
				short num3 = num;
				num = (short)1773793182;
				switch (num3 == num)
				{
				}
				num = (short)122421249;
				if (num != 0)
				{
				}
				num = (short)1221525504;
				if (num != 0)
				{
				}
				this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x06007277 RID: 29303 RVA: 0x0065C890 File Offset: 0x0065AA90
		public bool RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160_HasDiffs
		{
			get
			{
				short num = (short)242483200;
				short num2 = num;
				num = (short)808523588;
				short num3 = num;
				num = (short)311629636;
				switch (num3 == num)
				{
				}
				num = (short)683278337;
				if (num != 0)
				{
				}
				num = (short)945881088;
				if (num != 0)
				{
				}
				return this.radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160._HasDiffs;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x06007278 RID: 29304 RVA: 0x0065C948 File Offset: 0x0065AB48
		// (set) Token: 0x06007279 RID: 29305 RVA: 0x0065CA00 File Offset: 0x0065AC00
		public bool DispMenuGeneralOutOfRangeEarlyDetectionValue
		{
			get
			{
				short num = (short)526647296;
				short num2 = num;
				num = (short)1023822147;
				short num3 = num;
				num = (short)1334659395;
				switch (num3 == num)
				{
				}
				num = (short)979697664;
				if (num != 0)
				{
				}
				num = (short)363790337;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Value;
			}
			set
			{
				short num = (short)1571487744;
				short num2 = num;
				num = (short)96323695;
				short num3 = num;
				num = (short)588040303;
				switch (num3 == num)
				{
				}
				num = (short)222429185;
				if (num != 0)
				{
				}
				num = (short)223739904;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Value = value;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x0065CAB8 File Offset: 0x0065ACB8
		public global::AcpBusinessLayer.AcpField<bool> DispMenuGeneralOutOfRangeEarlyDetection
		{
			get
			{
				short num = (short)693633024;
				short num2 = num;
				num = (short)719221221;
				short num3 = num;
				num = (short)1281257957;
				switch (num3 == num)
				{
				}
				num = (short)1114505217;
				if (num != 0)
				{
				}
				num = (short)1809448960;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection;
			}
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600727B RID: 29307 RVA: 0x0065CB68 File Offset: 0x0065AD68
		// (set) Token: 0x0600727C RID: 29308 RVA: 0x0065CC20 File Offset: 0x0065AE20
		public bool DispMenuGeneralOutOfRangeEarlyDetection_UIValue
		{
			get
			{
				short num = (short)158203904;
				short num2 = num;
				num = (short)857540500;
				short num3 = num;
				num = (short)1337329556;
				switch (num3 == num)
				{
				}
				num = (short)1647312897;
				if (num != 0)
				{
				}
				num = (short)1729560576;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Value;
			}
			set
			{
				short num = (short)725352448;
				short num2 = num;
				num = (short)111292691;
				short num3 = num;
				num = (short)303640851;
				switch (num3 == num)
				{
				}
				num = (short)1340538880;
				if (num != 0)
				{
				}
				num = (short)52887553;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Value = value;
			}
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x0065CCD8 File Offset: 0x0065AED8
		// (set) Token: 0x0600727E RID: 29310 RVA: 0x0065CD8C File Offset: 0x0065AF8C
		public bool DispMenuGeneralOutOfRangeEarlyDetection_Applicable
		{
			get
			{
				short num = (short)1898840064;
				short num2 = num;
				num = (short)239877163;
				short num3 = num;
				num = (short)1879653419;
				switch (num3 == num)
				{
				}
				num = (short)1753612289;
				if (num != 0)
				{
				}
				num = (short)890306560;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Applicable;
			}
			set
			{
				short num = (short)272302080;
				short num2 = num;
				num = (short)1018098652;
				short num3 = num;
				num = (short)1501492188;
				switch (num3 == num)
				{
				}
				num = (short)281280513;
				if (num != 0)
				{
				}
				num = (short)11534336;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Applicable = value;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x0065CE40 File Offset: 0x0065B040
		// (set) Token: 0x06007280 RID: 29312 RVA: 0x0065CEF8 File Offset: 0x0065B0F8
		public bool DispMenuGeneralOutOfRangeEarlyDetection_Valid
		{
			get
			{
				short num = (short)930217984;
				short num2 = num;
				num = (short)622034471;
				short num3 = num;
				num = (short)1042120231;
				switch (num3 == num)
				{
				}
				num = (short)1398341633;
				if (num != 0)
				{
				}
				num = (short)189530112;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Valid;
			}
			set
			{
				short num = (short)916324352;
				short num2 = num;
				num = (short)1303765422;
				short num3 = num;
				num = (short)980148654;
				switch (num3 == num)
				{
				}
				num = (short)1212088321;
				if (num != 0)
				{
				}
				num = (short)1459617792;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Valid = value;
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x0065CFB0 File Offset: 0x0065B1B0
		// (set) Token: 0x06007282 RID: 29314 RVA: 0x0065D064 File Offset: 0x0065B264
		public bool DispMenuGeneralOutOfRangeEarlyDetection_Visible
		{
			get
			{
				short num = (short)153026560;
				short num2 = num;
				num = (short)2125491810;
				short num3 = num;
				num = (short)502623842;
				switch (num3 == num)
				{
				}
				num = (short)1046740993;
				if (num != 0)
				{
				}
				num = (short)1646985216;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Visible;
			}
			set
			{
				short num = (short)532480000;
				short num2 = num;
				num = (short)869986353;
				short num3 = num;
				num = (short)1392111665;
				switch (num3 == num)
				{
				}
				num = (short)916783105;
				if (num != 0)
				{
				}
				num = (short)144834560;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Visible = value;
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x0065D118 File Offset: 0x0065B318
		// (set) Token: 0x06007284 RID: 29316 RVA: 0x0065D1C8 File Offset: 0x0065B3C8
		public bool DispMenuGeneralOutOfRangeEarlyDetection_Editable
		{
			get
			{
				short num = (short)1748107264;
				short num2 = num;
				num = (short)193998163;
				short num3 = num;
				num = (short)1409363283;
				switch (num3 == num)
				{
				}
				num = (short)1789853697;
				if (num != 0)
				{
				}
				num = (short)1487470592;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.Editable;
			}
			set
			{
				short num = (short)52101120;
				short num2 = num;
				num = (short)317079099;
				short num3 = num;
				num = (short)1813921339;
				switch (num3 == num)
				{
				}
				num = (short)1661861889;
				if (num != 0)
				{
				}
				num = (short)1234239488;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.Editable = value;
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x06007285 RID: 29317 RVA: 0x0065D27C File Offset: 0x0065B47C
		internal string DispMenuGeneralOutOfRangeEarlyDetection_UILabel
		{
			get
			{
				short num = (short)1387200512;
				short num2 = num;
				num = (short)1202782209;
				if (num != 0)
				{
				}
				num = (short)460690136;
				short num3 = num;
				num = (short)645894872;
				switch (num3 == num)
				{
				}
				num = (short)1980563456;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.UIName;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x0065D330 File Offset: 0x0065B530
		// (set) Token: 0x06007287 RID: 29319 RVA: 0x0065D3E4 File Offset: 0x0065B5E4
		internal bool DispMenuGeneralOutOfRangeEarlyDetection_HiddenStatic
		{
			get
			{
				short num = (short)1068695552;
				short num2 = num;
				num = (short)213022417;
				short num3 = num;
				num = (short)1358198481;
				switch (num3 == num)
				{
				}
				num = (short)720306176;
				if (num != 0)
				{
				}
				num = (short)1726480385;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.HiddenStatic;
			}
			set
			{
				short num = (short)1391722496;
				short num2 = num;
				num = (short)1064180894;
				short num3 = num;
				num = (short)728243358;
				switch (num3 == num)
				{
				}
				num = (short)1459486720;
				if (num != 0)
				{
				}
				num = (short)885915649;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.HiddenStatic = value;
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x0065D49C File Offset: 0x0065B69C
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x0065D554 File Offset: 0x0065B754
		internal bool DispMenuGeneralOutOfRangeEarlyDetection_HiddenDynamic
		{
			get
			{
				short num = (short)1596915712;
				short num2 = num;
				num = (short)1220110135;
				short num3 = num;
				num = (short)1065510711;
				switch (num3 == num)
				{
				}
				num = (short)1307967489;
				if (num != 0)
				{
				}
				num = (short)853999616;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection.HiddenDynamic;
			}
			set
			{
				short num = (short)296288256;
				short num2 = num;
				num = (short)228721032;
				short num3 = num;
				num = (short)34996616;
				switch (num3 == num)
				{
				}
				num = (short)708968448;
				if (num != 0)
				{
				}
				num = (short)471728129;
				if (num != 0)
				{
				}
				this.dispMenuGeneralOutOfRangeEarlyDetection.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x0065D60C File Offset: 0x0065B80C
		public bool DispMenuGeneralOutOfRangeEarlyDetection_HasDiffs
		{
			get
			{
				short num = (short)1005584384;
				short num2 = num;
				num = (short)1526051613;
				short num3 = num;
				num = (short)499299101;
				switch (num3 == num)
				{
				}
				num = (short)1785331713;
				if (num != 0)
				{
				}
				num = (short)2060976128;
				if (num != 0)
				{
				}
				return this.dispMenuGeneralOutOfRangeEarlyDetection._HasDiffs;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x0065D6C0 File Offset: 0x0065B8C0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)562757632;
				short num2 = num;
				num = (short)1505544234;
				short num3 = num;
				num = (short)351455274;
				switch (num3 == num)
				{
				}
				num = (short)2119106560;
				if (num != 0)
				{
				}
				num = (short)118161409;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x0065D780 File Offset: 0x0065B980
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num2 = (short)1742405636;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						num2 = (short)805438746;
						short num3 = num2;
						num2 = (short)897189146;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1803550720;
							if (num2 != 0)
							{
							}
							num2 = (short)1555890176;
							short num4 = num2;
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)602931202;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2042298369;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)954073091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				num2 = (short)14548993;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)447741952;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04002CE8 RID: 11496
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002CE9 RID: 11497
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002CEA RID: 11498
		private global::AcpBusinessLayer.AcpListField dispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002CEB RID: 11499
		private global::AcpBusinessLayer.AcpListField dispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002CEC RID: 11500
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002CED RID: 11501
		private global::AcpBusinessLayer.AcpListField dispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002CEE RID: 11502
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002CEF RID: 11503
		private global::AcpBusinessLayer.AcpListField flipDisplayState_A19471;

		// Token: 0x04002CF0 RID: 11504
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuTopChannelTextSize_A19504;

		// Token: 0x04002CF1 RID: 11505
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002CF2 RID: 11506
		private global::AcpBusinessLayer.AcpListField dRSMFlipDisplayState_A24778;

		// Token: 0x04002CF3 RID: 11507
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002CF4 RID: 11508
		private global::AcpBusinessLayer.AcpListField radErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002CF5 RID: 11509
		private global::AcpBusinessLayer.AcpListField dispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002CF6 RID: 11510
		private global::AcpBusinessLayer.AcpRangeField<int, string> dispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002CF7 RID: 11511
		private global::AcpBusinessLayer.AcpRangeField<int, string> dispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002CF8 RID: 11512
		private global::AcpBusinessLayer.AcpListField radErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002CF9 RID: 11513
		private global::AcpBusinessLayer.AcpField<bool> dispMenuGeneralOutOfRangeEarlyDetection;
	}
}
