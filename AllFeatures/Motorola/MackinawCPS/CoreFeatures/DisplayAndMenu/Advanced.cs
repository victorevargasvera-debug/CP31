using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000270 RID: 624
	[global::System.Serializable]
	public class Advanced : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006F07 RID: 28423 RVA: 0x0062F5A8 File Offset: 0x0062D7A8
		public Advanced(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x0062F5C4 File Offset: 0x0062D7C4
		protected Advanced(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x0062F5DC File Offset: 0x0062D7DC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)875218875;
			short num2 = num;
			num = (short)1494206395;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1871446016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)910098433;
			if (num != 0)
			{
			}
			num = (short)1123680256;
			if (num != 0)
			{
			}
			this.advancedAutoLight = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ郐ꛒꇔ룖闘닚뫜럞闠", a_), global::CommonResources.AcgResources.ID_AUTOLIGHT);
			this.advancedAutoLight.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.advancedAutoLight.DataTransferOrder = 19;
			this.radWideAdvancedBacklightWhileinVA_A7536 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜鷞胠胢軤详胨質藬鯮꛰鯲鳴鯶鳸鋺鏼ꧾ䀀専䐄〆㰈㠊㬌", a_), global::CommonResources.AcgResources.ID_BACKLIGHTWHILEINVA);
			this.radWideAdvancedBacklightWhileinVA_A7536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideAdvancedBacklightWhileinVA_A7536.DataTransferOrder = 16;
			this.advancedDisplayLightTimeSec_A7875 = new global::AcpBusinessLayer.AcpCustomRangeField(15, this, global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ闐뫒ꛔꟖ뗘뫚ꓜ鏞裠蓢跤鏦뷨苪胬諮ꋰ雲雴ꣶ룸쳺염죾㐀", a_), global::CommonResources.AcgResources.ID_DISPLAYLIGHTTIMESEC, 0, 60, 5, global::CommonResources.AcgResources.ID_INFINITE, null);
			this.advancedDisplayLightTimeSec_A7875.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.advancedDisplayLightTimeSec_A7875.DataTransferOrder = 18;
			this.advancedDisplayLightTimeSec_A7875.ShowHexValue = false;
			this.advancedIndependentRotaryLight_A8254 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ飐뷒뇔닖꧘뻚돜믞蓠跢釤뗦蛨鿪賬鷮裰뿲鳴郶釸迺ꋼ뻾㤀㄂〄㌆", a_), global::CommonResources.AcgResources.ID_INDEPENDENTTOPLIGHT);
			this.advancedIndependentRotaryLight_A8254.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.advancedIndependentRotaryLight_A8254.DataTransferOrder = 24;
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎郐럒ꏔ뛖럘룚룜믞꟠蛢蓤鏦鳨駪裬ꛮ鿰鋲雴菶郸跺铼课砀圂氄樆氈搊砌笎䈐瘒瘔䠖堘⤚ⴜ⼞ဠሢ", a_), global::CommonResources.AcgResources.ID_FEATUREINACTIVITYTIMEOUTSEC, 3, 120, null, null, 0, 1);
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.DataTransferOrder = 17;
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.ShowHexValue = false;
			this.radErgoWideDispMenu_A21430 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ风룐럒냔鏖냘꣚규鋞蓠跢郤룦꣨\ud9ea\udcec\udbee싰쏲", a_), global::CommonResources.AcgResources.ID_FEATUREINACTIVITYALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoWideDispMenu_A21430LovStrs);
			this.radErgoWideDispMenu_A21430.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideDispMenu_A21430.DataTransferOrder = 34;
			this.dispMenuAdvancedLanguageSelection_A8386 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.indexDispMenuAdvancedLanguageSelection_A8386LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.IdDispMenuAdvancedLanguageSelection_A8386LovStrs), this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎郐럒ꏔ뛖럘룚룜믞균苢诤胦鳨諪諬諮ꋰ雲駴鋶髸迺铼郾漀専䐄㼆㨈㌊㬌", a_), global::CommonResources.AcgResources.ID_RADIODISPLAYLANGUAGE, true, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuAdvancedLanguageSelection_A8386LovStrs);
			this.dispMenuAdvancedLanguageSelection_A8386.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuAdvancedLanguageSelection_A8386.DataTransferOrder = 11;
			this.dispMenuAdvancedAlternatingDisplayTimems_A7436 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎郐럒ꏔ뛖럘룚룜믞ꃠ迢釤苦鯨藪賬鯮飰鷲鋴돶郸裺跼鏾怀稂億渆搈渊怌簎丐划∔⌖⨘ⴚ", a_), global::CommonResources.AcgResources.ID_ALTERNATINGDISPLAYTIMEMS, 10, 250, 10);
			this.dispMenuAdvancedAlternatingDisplayTimems_A7436.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuAdvancedAlternatingDisplayTimems_A7436.DataTransferOrder = 15;
			this.dispMenuAdvancedAlternatingDisplayTimems_A7436.ShowHexValue = false;
			this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎郐럒ꏔ뛖럘룚룜믞뗠蛢裤韦蛨駪賬鷮裰뻲郴蓶諸髺髼髾䔀樂瘄眆攈樊琌嬎砐縒瀔稖樘䐚尜☞ጠᬢሤ", a_), global::CommonResources.AcgResources.ID_TEMPORARYMESSAGEDISPLAYTIMEMS, 10, 250, 10);
			this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.DataTransferOrder = 28;
			this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.ShowHexValue = false;
			this.radioErgDispAdvanceChannelColorBacklight_43747 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎闐뫒ꛔꟖ飘뿚ꯜ뻞迠胢胤ꓦ臨諪菬臮铰鿲뛴飶闸铺迼뷾怀怂渄欆怈氊攌笎丐✒☔‖ⴘⰚ", a_), global::CommonResources.AcgResources.ID_DISPLAYADVANCEDCHANNELCOLORBACKLIGHT, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadioErgDispAdvanceChannelColorBacklight_43747LovStrs);
			this.radioErgDispAdvanceChannelColorBacklight_43747.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgDispAdvanceChannelColorBacklight_43747.DataTransferOrder = 54;
			this.radioErgDispAdvanceStatusAutoExit_42158 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ車뿌꣎闐뫒ꛔꟖ飘뿚ꯜ뻞迠胢胤듦鷨諪駬髮苰닲胴菶雸뻺藼雾甀専㄄㔆㠈㸊㔌", a_), global::CommonResources.AcgResources.ID_STATUSAUTOEXIT, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadioErgDispAdvanceStatusAutoExit_42158LovStrs);
			this.radioErgDispAdvanceStatusAutoExit_42158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgDispAdvanceStatusAutoExit_42158.DataTransferOrder = 35;
			this.displMenuAdvancedTopLightColorPerChannel_A43171 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆ꗈ蛊꣌ꇎꓐ鋒뇔ꇖ룘뗚뻜뫞藠럢諤韦ꗨ苪諬蟮藰냲髴鯶雸觺근髾猀䀂洄昆月攊栌挎丐划℔␖⠘ⰚⰜ", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHT);
			this.displMenuAdvancedTopLightColorPerChannel_A43171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.displMenuAdvancedTopLightColorPerChannel_A43171.DataTransferOrder = 36;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ", a_);
			base.Id = 10019;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x0062FA00 File Offset: 0x0062DC00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)9961499;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dispMenuAdvancedLanguageSelection_A8386 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.indexDispMenuAdvancedLanguageSelection_A8386LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.IdDispMenuAdvancedLanguageSelection_A8386LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟껡藣裥迧鿩跫觭闯ꇱ釳髵鷷駹裻韽濿氁嬃䜅〇㤉㐋㠍", a_), global::CommonResources.AcgResources.ID_RADIODISPLAYLANGUAGE, true, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuAdvancedLanguageSelection_A8386LovStrs);
					this.dispMenuAdvancedLanguageSelection_A8386.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuAdvancedLanguageSelection_A8386.DataTransferOrder = 11;
					num = (short)1337327621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ觋볍럏雑뷓ꗕ꣗鯙룛꣝臟賡蟣菥믧黩跫髭藯臱뗳菵賷闹맻蛽槿瘁嬃㈅㨇㬉㤋㘍", a_)))
					{
						num = (short)1957494816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A8;
				case 2:
					this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟뛡臣该飧藩黫迭苯诱맳鏵请觹鷻駽旿䘁洃甅砇昉洋眍䐏笑礓猕甗椙䌛弝᤟အᰣᄥ", a_), global::CommonResources.AcgResources.ID_TEMPORARYMESSAGEDISPLAYTIMEMS);
					this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.DataTransferOrder = 28;
					this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.ShowHexValue = false;
					num = (short)487850006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_5D4;
				case 4:
					this.advancedDisplayLightTimeSec_A7875 = new global::AcpBusinessLayer.AcpCustomRangeField(15, this, global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏雑뷓ꗕ꣗뛙뷛꟝곟诡菣軥鳧뻩藫菭闯ꇱ釳闵ꟷ믹쯻웽㟿㜁", a_), global::CommonResources.AcgResources.ID_DISPLAYLIGHTTIMESEC, global::CommonResources.AcgResources.ID_INFINITE, null);
					this.advancedDisplayLightTimeSec_A7875.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.advancedDisplayLightTimeSec_A7875.DataTransferOrder = 18;
					this.advancedDisplayLightTimeSec_A7875.ShowHexValue = false;
					num = (short)1035599893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_844;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟껡藣裥迧鿩跫觭闯ꇱ釳髵鷷駹裻韽濿氁嬃䜅〇㤉㐋㠍", a_)))
					{
						num = (short)1483866112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_844;
				case 7:
					goto IL_54B;
				case 8:
					this.advancedAutoLight = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏鏑ꇓꋕ럗雙뗛망裟雡", a_), global::CommonResources.AcgResources.ID_AUTOLIGHT);
					this.advancedAutoLight.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.advancedAutoLight.DataTransferOrder = 19;
					num = (short)881000483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟ꓡ臣蟥鳧鿩黫语맯鳱闳闵賷鏹諻韽瓿笁倃漅攇漉挋笍搏䄑焓甕䜗嬙⸛⸝ဟጡᔣ", a_)))
					{
						num = (short)674168848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F7;
				case 10:
					goto IL_324;
				case 11:
					this.advancedIndependentRotaryLight_A8254 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏鯑뫓닕뷗꫙맛냝蓟蟡諣鋥뫧藩飫迭苯诱룳鿵鿷鋹裻ꇽ䇿㨁㘃㌅㰇", a_), global::CommonResources.AcgResources.ID_INDEPENDENTTOPLIGHT);
					this.advancedIndependentRotaryLight_A8254.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.advancedIndependentRotaryLight_A8254.DataTransferOrder = 24;
					num = (short)509411335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_F4;
				case 13:
					this.radioErgDispAdvanceChannelColorBacklight_43747 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ觋볍럏雑뷓ꗕ꣗鯙룛꣝臟賡蟣菥ꯧ苩跫胭黯韱飳뗵韷雹鏻賽䋿持會洅搇按欋昍搏䴑–┕⼗⸙⬛", a_), global::CommonResources.AcgResources.ID_DISPLAYADVANCEDCHANNELCOLORBACKLIGHT, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadioErgDispAdvanceChannelColorBacklight_43747LovStrs);
					this.radioErgDispAdvanceChannelColorBacklight_43747.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgDispAdvanceChannelColorBacklight_43747.DataTransferOrder = 54;
					num = (short)423428106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_546;
				case 15:
					if (producerFields != null)
					{
						num = (short)577110044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E3;
				case 16:
					this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟ꓡ臣蟥鳧鿩黫语맯鳱闳闵賷鏹諻韽瓿笁倃漅攇漉挋笍搏䄑焓甕䜗嬙⸛⸝ဟጡᔣ", a_), global::CommonResources.AcgResources.ID_FEATUREINACTIVITYTIMEOUTSEC, null, null, 0, 1);
					this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.DataTransferOrder = 17;
					this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.ShowHexValue = false;
					num = (short)2127364122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)246743055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟뛡臣该飧藩黫迭苯诱맳鏵请觹鷻駽旿䘁洃甅砇昉洋眍䐏笑礓猕甗椙䌛弝᤟အᰣᄥ", a_)))
					{
						num = (short)1132920834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92B;
				case 19:
					goto IL_83F;
				case 20:
					this.dispMenuAdvancedAlternatingDisplayTimems_A7436 = new global::AcpBusinessLayer.AcpRangeField<int, string>(40, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.UnpackFactorAndpackFactorWith25(), this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟ꏡ裣鋥跧飩苫迭蓯鯱髳釵볷鏹迻軽泿持紃刅愇有椋挍挏䴑唓ℕⰗ⤙⨛", a_), global::CommonResources.AcgResources.ID_ALTERNATINGDISPLAYTIMEMS);
					this.dispMenuAdvancedAlternatingDisplayTimems_A7436.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dispMenuAdvancedAlternatingDisplayTimems_A7436.DataTransferOrder = 15;
					this.dispMenuAdvancedAlternatingDisplayTimems_A7436.ShowHexValue = false;
					num = (short)269549580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_892;
				case 22:
					goto IL_92B;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뛑ꋓ럕뛗맙맛뫝ꋟ菡蟣跥蓧菩诫蛭蓯ꗱ鳳鿵铷鿹闻都囿䌁嬃䜅㼇㼉㼋㠍", a_)))
					{
						num = (short)1107099687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D4;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏雑뷓ꗕ꣗뛙뷛꟝곟诡菣軥鳧뻩藫菭闯ꇱ釳闵ꟷ믹쯻웽㟿㜁", a_)))
					{
						num = (short)465764356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_892;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇蟉꧋ꃍꗏ鏑냓ꃕ맗듙뿛믝蓟ꏡ裣鋥跧飩苫迭蓯鯱髳釵볷鏹迻軽泿持紃刅愇有椋挍挏䴑唓ℕⰗ⤙⨛", a_)))
					{
						num = (short)1952251924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 26:
					goto IL_7F7;
				case 27:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 28:
					num = (short)142671901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏鏑ꇓꋕ럗雙뗛망裟雡", a_)))
					{
						num = (short)720240648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_621;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ觋볍럏雑뷓ꗕ꣗鯙룛꣝臟賡蟣菥ꯧ苩跫胭黯韱飳뗵韷雹鏻賽䋿持會洅搇按欋昍搏䴑–┕⼗⸙⬛", a_)))
					{
						num = (short)1089208333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_324;
				case 31:
					num = (short)2055208961;
					if (num != 0)
					{
					}
					goto IL_142;
				case 32:
				{
					this.radioErgDispAdvanceStatusAutoExit_42158 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ觋볍럏雑뷓ꗕ꣗鯙룛꣝臟賡蟣菥믧黩跫髭藯臱뗳菵賷闹맻蛽槿瘁嬃㈅㨇㬉㤋㘍", a_), global::CommonResources.AcgResources.ID_STATUSAUTOEXIT, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadioErgDispAdvanceStatusAutoExit_42158LovStrs);
					this.radioErgDispAdvanceStatusAutoExit_42158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgDispAdvanceStatusAutoExit_42158.DataTransferOrder = 35;
					num = (short)634781696;
					short num3 = num;
					num = (short)1466171428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕鳗동꿛껝귟蟡諣鏥럧ꯩ\udeeb\udfed쓯쇱쓳", a_)))
					{
						num = (short)1577844755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_142;
				case 34:
					this.displMenuAdvancedTopLightColorPerChannel_A43171 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇ꛉ臋ꯍ뻏ꟑ闓닕껗믙닛뷝藟蛡냣觥飧ꛩ藫觭飯蛱럳駵铷闹軻껽旿瀁䜃清椇搉戋欍簏䴑唓∕⬗⬙⬛⼝", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHT);
					this.displMenuAdvancedTopLightColorPerChannel_A43171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.displMenuAdvancedTopLightColorPerChannel_A43171.DataTransferOrder = 36;
					num = (short)1312423950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_621;
				case 36:
					goto IL_4A8;
				case 37:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛁귃뗅룇ꛉ臋ꯍ뻏ꟑ闓닕껗믙닛뷝藟蛡냣觥飧ꛩ藫觭飯蛱럳駵铷闹軻껽旿瀁䜃清椇搉戋欍簏䴑唓∕⬗⬙⬛⼝", a_)))
					{
						goto IL_9E3;
					}
					num = (short)785836501;
					short num4 = num;
					num = (short)470018517;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83F;
					default:
						num = (short)981532672;
						if (num != 0)
						{
						}
						num = (short)2086797346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏鯑뫓닕뷗꫙맛냝蓟蟡諣鋥뫧藩飫迭苯诱룳鿵鿷鋹裻ꇽ䇿㨁㘃㌅㰇", a_)))
					{
						num = (short)1201668107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54B;
				case 39:
					this.radWideAdvancedBacklightWhileinVA_A7536 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뛑ꋓ럕뛗맙맛뫝ꋟ菡蟣跥蓧菩诫蛭蓯ꗱ鳳鿵铷鿹闻都囿䌁嬃䜅㼇㼉㼋㠍", a_), global::CommonResources.AcgResources.ID_BACKLIGHTWHILEINVA);
					this.radWideAdvancedBacklightWhileinVA_A7536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideAdvancedBacklightWhileinVA_A7536.DataTransferOrder = 16;
					num = (short)1570635779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1261961233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F4:
				num = (short)294191122;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_142:
				num = (short)2064252934;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_324:
				num = (short)1692794917;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A8:
				num = (short)1538850846;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_54B:
				num = (short)793051145;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D4:
				num = (short)918487064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_621:
				num = (short)690552855;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F7:
				num = (short)1791819809;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_83F:
				this.radErgoWideDispMenu_A21430 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕鳗동꿛껝귟蟡諣鏥럧ꯩ\udeeb\udfed쓯쇱쓳", a_), global::CommonResources.AcgResources.ID_FEATUREINACTIVITYALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.RadErgoWideDispMenu_A21430LovStrs);
				this.radErgoWideDispMenu_A21430.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.radErgoWideDispMenu_A21430.DataTransferOrder = 34;
				num = (short)410320927;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_844:
				num = (short)1290403865;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_892:
				num = (short)943718438;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_92B:
				num = (short)1199833089;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_546:
			IL_9E3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏", a_);
			base.Id = 10019;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00630424 File Offset: 0x0062E624
		public override void PopulateReferences()
		{
			short num = (short)1804582648;
			short num2 = num;
			num = (short)1452392184;
			switch (num2 == num)
			{
			default:
			{
				num = (short)844300288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)930611201;
			if (num != 0)
			{
			}
			num = (short)805502976;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x006304CC File Offset: 0x0062E6CC
		public override void DropReferences()
		{
			short num = (short)2127831979;
			short num2 = num;
			num = (short)319169451;
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
			num = (short)18874369;
			if (num != 0)
			{
			}
			num = (short)1559232512;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x00630574 File Offset: 0x0062E774
		public override void SetConstraints()
		{
			short num = (short)114632480;
			short num2 = num;
			num = (short)544876320;
			switch (num2 == num)
			{
			default:
			{
				num = (short)845086720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)554827777;
			if (num != 0)
			{
			}
			num = (short)1807286272;
			if (num != 0)
			{
			}
			this.advancedAutoLight.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConDisplayMenuTimerIsnotInfinite);
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.conIsValueInRange3to120);
			this.radErgoWideDispMenu_A21430.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConFeatureInactivityAlertToneSelection);
			this.dispMenuAdvancedLanguageSelection_A8386.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.conSetOutputMesgForChinese);
			this.dispMenuAdvancedLanguageSelection_A8386.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConRadioDisplyLanguageLovVisibleForVertex);
			this.radioErgDispAdvanceStatusAutoExit_42158.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.conFeatureInactivityTimeoutIsInfinite);
			this.radioErgDispAdvanceChannelColorBacklight_43747.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConChannelColorBacklightIndexValid);
			this.radioErgDispAdvanceChannelColorBacklight_43747.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConChannelColorBacklightApplicable);
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x006306D8 File Offset: 0x0062E8D8
		public override void SetupDependencies()
		{
			short num = (short)1860304897;
			if (num != 0)
			{
			}
			num = (short)1349451776;
			short num2 = num;
			num = (short)1136251616;
			short num3 = num;
			num = (short)803918560;
			switch (num3 == num)
			{
			}
			num = (short)711720960;
			if (num != 0)
			{
			}
			this.advancedDisplayLightTimeSec_A7875.AddDependentObject(this.advancedAutoLight);
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.AddDependentObject(this.radErgoWideDispMenu_A21430);
			this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.AddDependentObject(this.radioErgDispAdvanceStatusAutoExit_42158);
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radioErgDispAdvanceChannelColorBacklight_43747);
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x006307E0 File Offset: 0x0062E9E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)629874660;
				short num2 = num;
				num = (short)105193444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367394816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140181504;
				if (num != 0)
				{
				}
				num = (short)1824718849;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x00630890 File Offset: 0x0062EA90
		// (set) Token: 0x06006F11 RID: 28433 RVA: 0x00630944 File Offset: 0x0062EB44
		public bool AdvancedAutoLightValue
		{
			get
			{
				short num = (short)712434782;
				short num2 = num;
				num = (short)1279517790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1189478400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534787584;
				if (num != 0)
				{
				}
				num = (short)2049572865;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Value;
			}
			set
			{
				short num = (short)1458611652;
				short num2 = num;
				num = (short)1205773764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)78774272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1369636865;
				if (num != 0)
				{
				}
				num = (short)722010112;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Value = value;
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x006309FC File Offset: 0x0062EBFC
		public global::AcpBusinessLayer.AcpField<bool> AdvancedAutoLight
		{
			get
			{
				short num = (short)1265760937;
				short num2 = num;
				num = (short)809695913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199163904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049376257;
				if (num != 0)
				{
				}
				num = (short)55443456;
				if (num != 0)
				{
				}
				return this.advancedAutoLight;
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x00630AAC File Offset: 0x0062ECAC
		// (set) Token: 0x06006F14 RID: 28436 RVA: 0x00630B60 File Offset: 0x0062ED60
		public bool AdvancedAutoLight_UIValue
		{
			get
			{
				short num = (short)1351484415;
				short num2 = num;
				num = (short)1566573567;
				switch (num2 == num)
				{
				}
				num = (short)380698624;
				if (num != 0)
				{
				}
				num = (short)625737728;
				short num3 = num;
				num = (short)1370750977;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Value;
			}
			set
			{
				short num = (short)220780959;
				short num2 = num;
				num = (short)961534367;
				switch (num2 == num)
				{
				}
				num = (short)574226433;
				if (num != 0)
				{
				}
				num = (short)1460273152;
				short num3 = num;
				num = (short)78184448;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Value = value;
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x00630C18 File Offset: 0x0062EE18
		// (set) Token: 0x06006F16 RID: 28438 RVA: 0x00630CD0 File Offset: 0x0062EED0
		public bool AdvancedAutoLight_Applicable
		{
			get
			{
				short num = (short)1018431987;
				short num2 = num;
				num = (short)1543768563;
				switch (num2 == num)
				{
				}
				num = (short)227540992;
				if (num != 0)
				{
				}
				num = (short)1120141312;
				short num3 = num;
				num = (short)90374145;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Applicable;
			}
			set
			{
				short num = (short)1251706842;
				short num2 = num;
				num = (short)938444762;
				switch (num2 == num)
				{
				}
				num = (short)680132609;
				if (num != 0)
				{
				}
				num = (short)683081728;
				short num3 = num;
				num = (short)1213726720;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Applicable = value;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x06006F17 RID: 28439 RVA: 0x00630D88 File Offset: 0x0062EF88
		// (set) Token: 0x06006F18 RID: 28440 RVA: 0x00630E40 File Offset: 0x0062F040
		public bool AdvancedAutoLight_Valid
		{
			get
			{
				short num = (short)1606258295;
				short num2 = num;
				num = (short)537562743;
				switch (num2 == num)
				{
				}
				num = (short)1604517888;
				if (num != 0)
				{
				}
				num = (short)2036269056;
				short num3 = num;
				num = (short)166854657;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Valid;
			}
			set
			{
				short num = (short)83848849;
				short num2 = num;
				num = (short)1722117777;
				switch (num2 == num)
				{
				}
				num = (short)947453952;
				if (num != 0)
				{
				}
				num = (short)1915748352;
				short num3 = num;
				num = (short)890372097;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Valid = value;
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x00630EFC File Offset: 0x0062F0FC
		// (set) Token: 0x06006F1A RID: 28442 RVA: 0x00630FB0 File Offset: 0x0062F1B0
		public bool AdvancedAutoLight_Visible
		{
			get
			{
				short num = (short)1110730025;
				short num2 = num;
				num = (short)322069801;
				switch (num2 == num)
				{
				}
				num = (short)2141716481;
				if (num != 0)
				{
				}
				num = (short)285999104;
				short num3 = num;
				num = (short)462553088;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Visible;
			}
			set
			{
				short num = (short)503819410;
				short num2 = num;
				num = (short)1289071762;
				switch (num2 == num)
				{
				}
				num = (short)2003828736;
				if (num != 0)
				{
				}
				num = (short)669122560;
				short num3 = num;
				num = (short)1358495745;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Visible = value;
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x00631068 File Offset: 0x0062F268
		// (set) Token: 0x06006F1C RID: 28444 RVA: 0x0063111C File Offset: 0x0062F31C
		public bool AdvancedAutoLight_Editable
		{
			get
			{
				short num = (short)1034747905;
				if (num != 0)
				{
				}
				num = (short)1054372996;
				short num2 = num;
				num = (short)265385092;
				switch (num2 == num)
				{
				}
				num = (short)1774845952;
				short num3 = num;
				num = (short)767950848;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.Editable;
			}
			set
			{
				short num = (short)383872612;
				short num2 = num;
				num = (short)231435876;
				switch (num2 == num)
				{
				}
				num = (short)976158720;
				if (num != 0)
				{
				}
				num = (short)1170997248;
				short num3 = num;
				num = (short)952434689;
				if (num != 0)
				{
				}
				this.advancedAutoLight.Editable = value;
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x06006F1D RID: 28445 RVA: 0x006311D0 File Offset: 0x0062F3D0
		internal string AdvancedAutoLight_UILabel
		{
			get
			{
				short num = (short)283499315;
				short num2 = num;
				num = (short)516741939;
				switch (num2 == num)
				{
				}
				num = (short)1817640961;
				if (num != 0)
				{
				}
				num = (short)736755712;
				short num3 = num;
				num = (short)92143616;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.UIName;
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x00631288 File Offset: 0x0062F488
		// (set) Token: 0x06006F1F RID: 28447 RVA: 0x00631338 File Offset: 0x0062F538
		internal bool AdvancedAutoLight_HiddenStatic
		{
			get
			{
				short num = (short)1464470616;
				short num2 = num;
				num = (short)1745030232;
				switch (num2 == num)
				{
				}
				num = (short)329777153;
				if (num != 0)
				{
				}
				num = (short)1673003008;
				short num3 = num;
				num = (short)799866880;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.HiddenStatic;
			}
			set
			{
				short num = (short)1906681410;
				short num2 = num;
				num = (short)1900127810;
				switch (num2 == num)
				{
				}
				num = (short)377421825;
				if (num != 0)
				{
				}
				num = (short)1667825664;
				short num3 = num;
				num = (short)288882688;
				if (num != 0)
				{
				}
				this.advancedAutoLight.HiddenStatic = value;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x006313EC File Offset: 0x0062F5EC
		// (set) Token: 0x06006F21 RID: 28449 RVA: 0x006314A4 File Offset: 0x0062F6A4
		internal bool AdvancedAutoLight_HiddenDynamic
		{
			get
			{
				short num = (short)1176880519;
				short num2 = num;
				num = (short)1436468615;
				switch (num2 == num)
				{
				}
				num = (short)267583488;
				if (num != 0)
				{
				}
				num = (short)1249968128;
				short num3 = num;
				num = (short)1276051457;
				if (num != 0)
				{
				}
				return this.advancedAutoLight.HiddenDynamic;
			}
			set
			{
				short num = (short)1372681540;
				short num2 = num;
				num = (short)470578500;
				switch (num2 == num)
				{
				}
				num = (short)1501167617;
				if (num != 0)
				{
				}
				num = (short)934739968;
				short num3 = num;
				num = (short)1462108160;
				if (num != 0)
				{
				}
				this.advancedAutoLight.HiddenDynamic = value;
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x0063155C File Offset: 0x0062F75C
		public bool AdvancedAutoLight_HasDiffs
		{
			get
			{
				short num = (short)1986997567;
				short num2 = num;
				num = (short)1662856511;
				switch (num2 == num)
				{
				}
				num = (short)795410433;
				if (num != 0)
				{
				}
				num = (short)1930100736;
				short num3 = num;
				num = (short)809435136;
				if (num != 0)
				{
				}
				return this.advancedAutoLight._HasDiffs;
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x06006F23 RID: 28451 RVA: 0x00631614 File Offset: 0x0062F814
		// (set) Token: 0x06006F24 RID: 28452 RVA: 0x006316C8 File Offset: 0x0062F8C8
		public bool RadWideAdvancedBacklightWhileinVA_A7536Value
		{
			get
			{
				short num = (short)1386246138;
				short num2 = num;
				num = (short)53440506;
				switch (num2 == num)
				{
				}
				num = (short)684195841;
				if (num != 0)
				{
				}
				num = (short)735117312;
				short num3 = num;
				num = (short)519372800;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Value;
			}
			set
			{
				short num = (short)1930433534;
				short num2 = num;
				num = (short)858395646;
				switch (num2 == num)
				{
				}
				num = (short)1286012928;
				if (num != 0)
				{
				}
				num = (short)1073872896;
				short num3 = num;
				num = (short)1769996289;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Value = value;
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x06006F25 RID: 28453 RVA: 0x0063177C File Offset: 0x0062F97C
		public global::AcpBusinessLayer.AcpField<bool> RadWideAdvancedBacklightWhileinVA_A7536
		{
			get
			{
				short num = (short)1185468251;
				short num2 = num;
				num = (short)1496239963;
				switch (num2 == num)
				{
				}
				num = (short)1067778049;
				if (num != 0)
				{
				}
				num = (short)310771712;
				short num3 = num;
				num = (short)803209216;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x00631828 File Offset: 0x0062FA28
		// (set) Token: 0x06006F27 RID: 28455 RVA: 0x006318DC File Offset: 0x0062FADC
		public bool RadWideAdvancedBacklightWhileinVA_A7536_UIValue
		{
			get
			{
				short num = (short)583002428;
				short num2 = num;
				num = (short)731834684;
				switch (num2 == num)
				{
				}
				num = (short)278593537;
				if (num != 0)
				{
				}
				num = (short)747765760;
				short num3 = num;
				num = (short)564002816;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Value;
			}
			set
			{
				short num = (short)1412221263;
				short num2 = num;
				num = (short)243583311;
				switch (num2 == num)
				{
				}
				num = (short)1989083137;
				if (num != 0)
				{
				}
				num = (short)2051866624;
				short num3 = num;
				num = (short)1520369664;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Value = value;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x06006F28 RID: 28456 RVA: 0x00631990 File Offset: 0x0062FB90
		// (set) Token: 0x06006F29 RID: 28457 RVA: 0x00631A44 File Offset: 0x0062FC44
		public bool RadWideAdvancedBacklightWhileinVA_A7536_Applicable
		{
			get
			{
				short num = (short)377851272;
				short num2 = num;
				num = (short)2066255240;
				switch (num2 == num)
				{
				}
				num = (short)1988100097;
				if (num != 0)
				{
				}
				num = (short)1261764608;
				short num3 = num;
				num = (short)999817216;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Applicable;
			}
			set
			{
				short num = (short)2143736437;
				short num2 = num;
				num = (short)857526901;
				switch (num2 == num)
				{
				}
				num = (short)2087845888;
				if (num != 0)
				{
				}
				num = (short)239730688;
				short num3 = num;
				num = (short)368967681;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Applicable = value;
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x00631AF8 File Offset: 0x0062FCF8
		// (set) Token: 0x06006F2B RID: 28459 RVA: 0x00631BB0 File Offset: 0x0062FDB0
		public bool RadWideAdvancedBacklightWhileinVA_A7536_Valid
		{
			get
			{
				short num = (short)736095637;
				short num2 = num;
				num = (short)1499262357;
				switch (num2 == num)
				{
				}
				num = (short)1794572289;
				if (num != 0)
				{
				}
				num = (short)1937571840;
				short num3 = num;
				num = (short)2140995584;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Valid;
			}
			set
			{
				short num = (short)1032765329;
				short num2 = num;
				num = (short)854769553;
				switch (num2 == num)
				{
				}
				num = (short)375783425;
				if (num != 0)
				{
				}
				num = (short)1628635136;
				short num3 = num;
				num = (short)1572864;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Valid = value;
			}
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x06006F2C RID: 28460 RVA: 0x00631C64 File Offset: 0x0062FE64
		// (set) Token: 0x06006F2D RID: 28461 RVA: 0x00631D1C File Offset: 0x0062FF1C
		public bool RadWideAdvancedBacklightWhileinVA_A7536_Visible
		{
			get
			{
				short num = (short)703232724;
				short num2 = num;
				num = (short)1737456340;
				switch (num2 == num)
				{
				}
				num = (short)783548417;
				if (num != 0)
				{
				}
				num = (short)516227072;
				short num3 = num;
				num = (short)1433141248;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Visible;
			}
			set
			{
				short num = (short)198780978;
				short num2 = num;
				num = (short)142223410;
				switch (num2 == num)
				{
				}
				num = (short)2094006273;
				if (num != 0)
				{
				}
				num = (short)1317404672;
				short num3 = num;
				num = (short)1131806720;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Visible = value;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x06006F2E RID: 28462 RVA: 0x00631DD4 File Offset: 0x0062FFD4
		// (set) Token: 0x06006F2F RID: 28463 RVA: 0x00631E88 File Offset: 0x00630088
		public bool RadWideAdvancedBacklightWhileinVA_A7536_Editable
		{
			get
			{
				short num = (short)952025116;
				short num2 = num;
				num = (short)2107293724;
				switch (num2 == num)
				{
				}
				num = (short)1884028928;
				if (num != 0)
				{
				}
				num = (short)2033254400;
				short num3 = num;
				num = (short)1767112705;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.Editable;
			}
			set
			{
				short num = (short)1083557437;
				short num2 = num;
				num = (short)762234429;
				switch (num2 == num)
				{
				}
				num = (short)1672282112;
				if (num != 0)
				{
				}
				num = (short)1979777024;
				short num3 = num;
				num = (short)1588592641;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.Editable = value;
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x06006F30 RID: 28464 RVA: 0x00631F40 File Offset: 0x00630140
		internal string RadWideAdvancedBacklightWhileinVA_A7536_UILabel
		{
			get
			{
				short num = (short)639020113;
				short num2 = num;
				num = (short)332442705;
				switch (num2 == num)
				{
				}
				num = (short)1386151937;
				if (num != 0)
				{
				}
				num = (short)2036465664;
				short num3 = num;
				num = (short)827850752;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.UIName;
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x00631FF8 File Offset: 0x006301F8
		// (set) Token: 0x06006F32 RID: 28466 RVA: 0x006320AC File Offset: 0x006302AC
		internal bool RadWideAdvancedBacklightWhileinVA_A7536_HiddenStatic
		{
			get
			{
				short num = (short)1680349587;
				short num2 = num;
				num = (short)861411731;
				switch (num2 == num)
				{
				}
				num = (short)619970561;
				if (num != 0)
				{
				}
				num = (short)1502281728;
				short num3 = num;
				num = (short)996999168;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.HiddenStatic;
			}
			set
			{
				short num = (short)625999465;
				short num2 = num;
				num = (short)1275723369;
				switch (num2 == num)
				{
				}
				num = (short)943652864;
				if (num != 0)
				{
				}
				num = (short)217120768;
				short num3 = num;
				num = (short)871170049;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.HiddenStatic = value;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x06006F33 RID: 28467 RVA: 0x0063215C File Offset: 0x0063035C
		// (set) Token: 0x06006F34 RID: 28468 RVA: 0x00632210 File Offset: 0x00630410
		internal bool RadWideAdvancedBacklightWhileinVA_A7536_HiddenDynamic
		{
			get
			{
				short num = (short)662719120;
				short num2 = num;
				num = (short)233261712;
				switch (num2 == num)
				{
				}
				num = (short)1865613313;
				if (num != 0)
				{
				}
				num = (short)1262551040;
				short num3 = num;
				num = (short)694484992;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536.HiddenDynamic;
			}
			set
			{
				short num = (short)1505735082;
				short num2 = num;
				num = (short)1254207914;
				switch (num2 == num)
				{
				}
				num = (short)1987117057;
				if (num != 0)
				{
				}
				num = (short)1325924352;
				short num3 = num;
				num = (short)1297940480;
				if (num != 0)
				{
				}
				this.radWideAdvancedBacklightWhileinVA_A7536.HiddenDynamic = value;
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x006322C8 File Offset: 0x006304C8
		public bool RadWideAdvancedBacklightWhileinVA_A7536_HasDiffs
		{
			get
			{
				short num = (short)621860972;
				short num2 = num;
				num = (short)1504106604;
				switch (num2 == num)
				{
				}
				num = (short)1959657472;
				if (num != 0)
				{
				}
				num = (short)1892089856;
				short num3 = num;
				num = (short)157810689;
				if (num != 0)
				{
				}
				return this.radWideAdvancedBacklightWhileinVA_A7536._HasDiffs;
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x00632380 File Offset: 0x00630580
		// (set) Token: 0x06006F37 RID: 28471 RVA: 0x00632434 File Offset: 0x00630634
		public int AdvancedDisplayLightTimeSec_A7875Value
		{
			get
			{
				short num = (short)1376452609;
				if (num != 0)
				{
				}
				num = (short)184750774;
				short num2 = num;
				num = (short)1845367478;
				switch (num2 == num)
				{
				}
				num = (short)1366097920;
				short num3 = num;
				num = (short)226557952;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Value;
			}
			set
			{
				short num = (short)2020972175;
				short num2 = num;
				num = (short)177575567;
				switch (num2 == num)
				{
				}
				num = (short)1286340609;
				if (num != 0)
				{
				}
				num = (short)1368588288;
				short num3 = num;
				num = (short)413663232;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Value = value;
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x06006F38 RID: 28472 RVA: 0x006324F0 File Offset: 0x006306F0
		public global::AcpBusinessLayer.AcpCustomRangeField AdvancedDisplayLightTimeSec_A7875
		{
			get
			{
				short num = (short)862584833;
				if (num != 0)
				{
				}
				num = (short)1647217208;
				short num2 = num;
				num = (short)146377272;
				switch (num2 == num)
				{
				}
				num = (short)452001792;
				short num3 = num;
				num = (short)224329728;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x06006F39 RID: 28473 RVA: 0x0063259C File Offset: 0x0063079C
		// (set) Token: 0x06006F3A RID: 28474 RVA: 0x00632650 File Offset: 0x00630850
		public string AdvancedDisplayLightTimeSec_A7875_UIValue
		{
			get
			{
				short num = (short)395240950;
				short num2 = num;
				num = (short)1780999670;
				switch (num2 == num)
				{
				}
				num = (short)642973696;
				if (num != 0)
				{
				}
				num = (short)817954816;
				short num3 = num;
				num = (short)2131099649;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.UIValue;
			}
			set
			{
				short num = (short)760414209;
				if (num != 0)
				{
				}
				num = (short)1557245666;
				short num2 = num;
				num = (short)851291874;
				switch (num2 == num)
				{
				}
				num = (short)1169883136;
				short num3 = num;
				num = (short)1728839680;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.UIValue = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x00632704 File Offset: 0x00630904
		// (set) Token: 0x06006F3C RID: 28476 RVA: 0x006327BC File Offset: 0x006309BC
		internal int AdvancedDisplayLightTimeSec_A7875Min
		{
			get
			{
				short num = (short)846734638;
				short num2 = num;
				num = (short)1760437550;
				switch (num2 == num)
				{
				}
				num = (short)453771264;
				if (num != 0)
				{
				}
				num = (short)421134336;
				short num3 = num;
				num = (short)507314177;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Min;
			}
			set
			{
				short num = (short)1479593960;
				short num2 = num;
				num = (short)1432997864;
				switch (num2 == num)
				{
				}
				num = (short)1626079232;
				if (num != 0)
				{
				}
				num = (short)375259136;
				short num3 = num;
				num = (short)39714817;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Min = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x00632870 File Offset: 0x00630A70
		// (set) Token: 0x06006F3E RID: 28478 RVA: 0x00632920 File Offset: 0x00630B20
		internal int AdvancedDisplayLightTimeSec_A7875Max
		{
			get
			{
				short num = (short)593509155;
				short num2 = num;
				num = (short)206388003;
				switch (num2 == num)
				{
				}
				num = (short)212008961;
				if (num != 0)
				{
				}
				num = (short)1035993088;
				short num3 = num;
				num = (short)1049231360;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Max;
			}
			set
			{
				short num = (short)385298872;
				short num2 = num;
				num = (short)635122104;
				switch (num2 == num)
				{
				}
				num = (short)1446445057;
				if (num != 0)
				{
				}
				num = (short)456720384;
				short num3 = num;
				num = (short)1553268736;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Max = value;
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x06006F3F RID: 28479 RVA: 0x006329D8 File Offset: 0x00630BD8
		// (set) Token: 0x06006F40 RID: 28480 RVA: 0x00632A8C File Offset: 0x00630C8C
		internal int AdvancedDisplayLightTimeSec_A7875Step
		{
			get
			{
				short num = (short)1798606031;
				short num2 = num;
				num = (short)991726799;
				switch (num2 == num)
				{
				}
				num = (short)1903230977;
				if (num != 0)
				{
				}
				num = (short)1841561600;
				short num3 = num;
				num = (short)18546688;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.StepSize;
			}
			set
			{
				short num = (short)922008419;
				short num2 = num;
				num = (short)1770699619;
				switch (num2 == num)
				{
				}
				num = (short)1827733504;
				if (num != 0)
				{
				}
				num = (short)838074368;
				short num3 = num;
				num = (short)756940801;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.StepSize = value;
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x00632B44 File Offset: 0x00630D44
		// (set) Token: 0x06006F42 RID: 28482 RVA: 0x00632BF8 File Offset: 0x00630DF8
		public bool AdvancedDisplayLightTimeSec_A7875_Applicable
		{
			get
			{
				short num = (short)1850819474;
				short num2 = num;
				num = (short)850871186;
				switch (num2 == num)
				{
				}
				num = (short)1449197569;
				if (num != 0)
				{
				}
				num = (short)582221824;
				short num3 = num;
				num = (short)1567621120;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Applicable;
			}
			set
			{
				short num = (short)1770453360;
				short num2 = num;
				num = (short)1237318000;
				switch (num2 == num)
				{
				}
				num = (short)1258618880;
				if (num != 0)
				{
				}
				num = (short)1937899520;
				short num3 = num;
				num = (short)1762983937;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Applicable = value;
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x00632CAC File Offset: 0x00630EAC
		// (set) Token: 0x06006F44 RID: 28484 RVA: 0x00632D60 File Offset: 0x00630F60
		public bool AdvancedDisplayLightTimeSec_A7875_Valid
		{
			get
			{
				short num = (short)1254162433;
				if (num != 0)
				{
				}
				num = (short)1304276583;
				short num2 = num;
				num = (short)1559932519;
				switch (num2 == num)
				{
				}
				num = (short)2106458112;
				short num3 = num;
				num = (short)343932928;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Valid;
			}
			set
			{
				short num = (short)212662752;
				short num2 = num;
				num = (short)311753184;
				switch (num2 == num)
				{
				}
				num = (short)730660865;
				if (num != 0)
				{
				}
				num = (short)1628569600;
				short num3 = num;
				num = (short)1776091136;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Valid = value;
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x06006F45 RID: 28485 RVA: 0x00632E1C File Offset: 0x0063101C
		// (set) Token: 0x06006F46 RID: 28486 RVA: 0x00632ED0 File Offset: 0x006310D0
		public bool AdvancedDisplayLightTimeSec_A7875_Visible
		{
			get
			{
				short num = (short)423912166;
				short num2 = num;
				num = (short)18178790;
				switch (num2 == num)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				num = (short)1230897152;
				short num3 = num;
				num = (short)2112421889;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Visible;
			}
			set
			{
				short num = (short)323029989;
				short num2 = num;
				num = (short)1063586789;
				switch (num2 == num)
				{
				}
				num = (short)806748160;
				if (num != 0)
				{
				}
				num = (short)428802048;
				short num3 = num;
				num = (short)317784065;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Visible = value;
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x00632F88 File Offset: 0x00631188
		// (set) Token: 0x06006F48 RID: 28488 RVA: 0x0063303C File Offset: 0x0063123C
		public bool AdvancedDisplayLightTimeSec_A7875_Editable
		{
			get
			{
				short num = (short)1342706947;
				short num2 = num;
				num = (short)452596995;
				switch (num2 == num)
				{
				}
				num = (short)1038942209;
				if (num != 0)
				{
				}
				num = (short)1314914304;
				short num3 = num;
				num = (short)595394560;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.Editable;
			}
			set
			{
				short num = (short)272022664;
				short num2 = num;
				num = (short)72596616;
				switch (num2 == num)
				{
				}
				num = (short)559874049;
				if (num != 0)
				{
				}
				num = (short)343015424;
				short num3 = num;
				num = (short)19529728;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.Editable = value;
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x006330F0 File Offset: 0x006312F0
		internal string AdvancedDisplayLightTimeSec_A7875_UILabel
		{
			get
			{
				short num = (short)799617370;
				short num2 = num;
				num = (short)1547645274;
				switch (num2 == num)
				{
				}
				num = (short)328990720;
				if (num != 0)
				{
				}
				num = (short)906952704;
				short num3 = num;
				num = (short)863633409;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.UIName;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x06006F4A RID: 28490 RVA: 0x006331A4 File Offset: 0x006313A4
		// (set) Token: 0x06006F4B RID: 28491 RVA: 0x00633258 File Offset: 0x00631458
		internal bool AdvancedDisplayLightTimeSec_A7875_HiddenStatic
		{
			get
			{
				short num = (short)594376310;
				short num2 = num;
				num = (short)85489270;
				switch (num2 == num)
				{
				}
				num = (short)1292107777;
				if (num != 0)
				{
				}
				num = (short)931004416;
				short num3 = num;
				num = (short)60358656;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.HiddenStatic;
			}
			set
			{
				short num = (short)544671529;
				short num2 = num;
				num = (short)549324585;
				switch (num2 == num)
				{
				}
				num = (short)1662844928;
				if (num != 0)
				{
				}
				num = (short)1825767424;
				short num3 = num;
				num = (short)269484033;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.HiddenStatic = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x06006F4C RID: 28492 RVA: 0x00633310 File Offset: 0x00631510
		// (set) Token: 0x06006F4D RID: 28493 RVA: 0x006333C4 File Offset: 0x006315C4
		internal bool AdvancedDisplayLightTimeSec_A7875_HiddenDynamic
		{
			get
			{
				short num = (short)1970084957;
				short num2 = num;
				num = (short)1902976093;
				switch (num2 == num)
				{
				}
				num = (short)2115764225;
				if (num != 0)
				{
				}
				num = (short)605814784;
				short num3 = num;
				num = (short)1842610176;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875.HiddenDynamic;
			}
			set
			{
				short num = (short)229623880;
				short num2 = num;
				num = (short)1886570568;
				switch (num2 == num)
				{
				}
				num = (short)976617472;
				if (num != 0)
				{
				}
				num = (short)1895890944;
				short num3 = num;
				num = (short)284164097;
				if (num != 0)
				{
				}
				this.advancedDisplayLightTimeSec_A7875.HiddenDynamic = value;
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x00633478 File Offset: 0x00631678
		public bool AdvancedDisplayLightTimeSec_A7875_HasDiffs
		{
			get
			{
				short num = (short)1224086435;
				short num2 = num;
				num = (short)1563431843;
				switch (num2 == num)
				{
				}
				num = (short)759496705;
				if (num != 0)
				{
				}
				num = (short)1382940672;
				short num3 = num;
				num = (short)1209925632;
				if (num != 0)
				{
				}
				return this.advancedDisplayLightTimeSec_A7875._HasDiffs;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x06006F4F RID: 28495 RVA: 0x00633528 File Offset: 0x00631728
		// (set) Token: 0x06006F50 RID: 28496 RVA: 0x006335E0 File Offset: 0x006317E0
		public bool AdvancedIndependentRotaryLight_A8254Value
		{
			get
			{
				short num = (short)1834418176;
				short num2 = num;
				num = (short)774063711;
				short num3 = num;
				num = (short)1236682335;
				switch (num3 == num)
				{
				}
				num = (short)1464467457;
				if (num != 0)
				{
				}
				num = (short)616628224;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Value;
			}
			set
			{
				short num = (short)369688576;
				short num2 = num;
				num = (short)1461232908;
				short num3 = num;
				num = (short)1895933196;
				switch (num3 == num)
				{
				}
				num = (short)1037369345;
				if (num != 0)
				{
				}
				num = (short)1884749824;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Value = value;
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x06006F51 RID: 28497 RVA: 0x00633698 File Offset: 0x00631898
		public global::AcpBusinessLayer.AcpField<bool> AdvancedIndependentRotaryLight_A8254
		{
			get
			{
				short num = (short)1430192128;
				short num2 = num;
				num = (short)294708820;
				short num3 = num;
				num = (short)1041884756;
				switch (num3 == num)
				{
				}
				num = (short)344064000;
				if (num != 0)
				{
				}
				num = (short)1589248001;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254;
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x06006F52 RID: 28498 RVA: 0x00633748 File Offset: 0x00631948
		// (set) Token: 0x06006F53 RID: 28499 RVA: 0x00633800 File Offset: 0x00631A00
		public bool AdvancedIndependentRotaryLight_A8254_UIValue
		{
			get
			{
				short num = (short)696057856;
				short num2 = num;
				num = (short)187746355;
				short num3 = num;
				num = (short)2137311283;
				switch (num3 == num)
				{
				}
				num = (short)1425211392;
				if (num != 0)
				{
				}
				num = (short)30605313;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Value;
			}
			set
			{
				short num = (short)681639936;
				short num2 = num;
				num = (short)2109625553;
				short num3 = num;
				num = (short)141579473;
				switch (num3 == num)
				{
				}
				num = (short)829227009;
				if (num != 0)
				{
				}
				num = (short)437911552;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Value = value;
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x006338B4 File Offset: 0x00631AB4
		// (set) Token: 0x06006F55 RID: 28501 RVA: 0x00633964 File Offset: 0x00631B64
		public bool AdvancedIndependentRotaryLight_A8254_Applicable
		{
			get
			{
				short num = (short)1621819392;
				short num2 = num;
				num = (short)1201134794;
				short num3 = num;
				num = (short)91086026;
				switch (num3 == num)
				{
				}
				num = (short)941359105;
				if (num != 0)
				{
				}
				num = (short)712310784;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Applicable;
			}
			set
			{
				short num = (short)2007302144;
				short num2 = num;
				num = (short)599785473;
				if (num != 0)
				{
				}
				num = (short)1138868679;
				short num3 = num;
				num = (short)1976287687;
				switch (num3 == num)
				{
				}
				num = (short)1644691456;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Applicable = value;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x06006F56 RID: 28502 RVA: 0x00633A18 File Offset: 0x00631C18
		// (set) Token: 0x06006F57 RID: 28503 RVA: 0x00633AD0 File Offset: 0x00631CD0
		public bool AdvancedIndependentRotaryLight_A8254_Valid
		{
			get
			{
				short num = (short)693436416;
				short num2 = num;
				num = (short)1719530648;
				short num3 = num;
				num = (short)199357592;
				switch (num3 == num)
				{
				}
				num = (short)660602880;
				if (num != 0)
				{
				}
				num = (short)895549441;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Valid;
			}
			set
			{
				short num = (short)271187968;
				short num2 = num;
				num = (short)55766299;
				short num3 = num;
				num = (short)1213590811;
				switch (num3 == num)
				{
				}
				num = (short)422838272;
				if (num != 0)
				{
				}
				num = (short)982253569;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Valid = value;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x06006F58 RID: 28504 RVA: 0x00633B84 File Offset: 0x00631D84
		// (set) Token: 0x06006F59 RID: 28505 RVA: 0x00633C38 File Offset: 0x00631E38
		public bool AdvancedIndependentRotaryLight_A8254_Visible
		{
			get
			{
				short num = (short)2006908928;
				short num2 = num;
				num = (short)959799949;
				short num3 = num;
				num = (short)78865037;
				switch (num3 == num)
				{
				}
				num = (short)1407713281;
				if (num != 0)
				{
				}
				num = (short)1509097472;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Visible;
			}
			set
			{
				short num = (short)1908604928;
				short num2 = num;
				num = (short)791320240;
				short num3 = num;
				num = (short)1230870192;
				switch (num3 == num)
				{
				}
				num = (short)1670316032;
				if (num != 0)
				{
				}
				num = (short)1251672065;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Visible = value;
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x06006F5A RID: 28506 RVA: 0x00633CF0 File Offset: 0x00631EF0
		// (set) Token: 0x06006F5B RID: 28507 RVA: 0x00633DA4 File Offset: 0x00631FA4
		public bool AdvancedIndependentRotaryLight_A8254_Editable
		{
			get
			{
				short num = (short)1949040640;
				short num2 = num;
				num = (short)871228865;
				short num3 = num;
				num = (short)200467905;
				switch (num3 == num)
				{
				}
				num = (short)1809842177;
				if (num != 0)
				{
				}
				num = (short)657719296;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.Editable;
			}
			set
			{
				short num = (short)1577844736;
				short num2 = num;
				num = (short)885730823;
				short num3 = num;
				num = (short)1389374983;
				switch (num3 == num)
				{
				}
				num = (short)68550657;
				if (num != 0)
				{
				}
				num = (short)1002438656;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.Editable = value;
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00633E58 File Offset: 0x00632058
		internal string AdvancedIndependentRotaryLight_A8254_UILabel
		{
			get
			{
				short num = (short)289931264;
				short num2 = num;
				num = (short)1204953208;
				short num3 = num;
				num = (short)433856632;
				switch (num3 == num)
				{
				}
				num = (short)864616449;
				if (num != 0)
				{
				}
				num = (short)1069154304;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.UIName;
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x06006F5D RID: 28509 RVA: 0x00633F10 File Offset: 0x00632110
		// (set) Token: 0x06006F5E RID: 28510 RVA: 0x00633FC8 File Offset: 0x006321C8
		internal bool AdvancedIndependentRotaryLight_A8254_HiddenStatic
		{
			get
			{
				short num = (short)1264123904;
				short num2 = num;
				num = (short)136299534;
				short num3 = num;
				num = (short)341165070;
				switch (num3 == num)
				{
				}
				num = (short)1906704385;
				if (num != 0)
				{
				}
				num = (short)627310592;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.HiddenStatic;
			}
			set
			{
				short num = (short)178782208;
				short num2 = num;
				num = (short)2135030118;
				short num3 = num;
				num = (short)803469670;
				switch (num3 == num)
				{
				}
				num = (short)23330816;
				if (num != 0)
				{
				}
				num = (short)903872513;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.HiddenStatic = value;
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x06006F5F RID: 28511 RVA: 0x00634080 File Offset: 0x00632280
		// (set) Token: 0x06006F60 RID: 28512 RVA: 0x00634134 File Offset: 0x00632334
		internal bool AdvancedIndependentRotaryLight_A8254_HiddenDynamic
		{
			get
			{
				short num = (short)92536832;
				short num2 = num;
				num = (short)1578631169;
				if (num != 0)
				{
				}
				num = (short)1299599973;
				short num3 = num;
				num = (short)738284133;
				switch (num3 == num)
				{
				}
				num = (short)1097728000;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254.HiddenDynamic;
			}
			set
			{
				short num = (short)26673152;
				short num2 = num;
				num = (short)948347068;
				short num3 = num;
				num = (short)1588371644;
				switch (num3 == num)
				{
				}
				num = (short)1296957441;
				if (num != 0)
				{
				}
				num = (short)457310208;
				if (num != 0)
				{
				}
				this.advancedIndependentRotaryLight_A8254.HiddenDynamic = value;
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x06006F61 RID: 28513 RVA: 0x006341E8 File Offset: 0x006323E8
		public bool AdvancedIndependentRotaryLight_A8254_HasDiffs
		{
			get
			{
				short num = (short)1418067968;
				short num2 = num;
				num = (short)133693441;
				if (num != 0)
				{
				}
				num = (short)833577158;
				short num3 = num;
				num = (short)843735238;
				switch (num3 == num)
				{
				}
				num = (short)1156382720;
				if (num != 0)
				{
				}
				return this.advancedIndependentRotaryLight_A8254._HasDiffs;
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x006342A0 File Offset: 0x006324A0
		// (set) Token: 0x06006F63 RID: 28515 RVA: 0x00634354 File Offset: 0x00632554
		public int DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Value
		{
			get
			{
				short num = (short)684523520;
				short num2 = num;
				num = (short)1547895854;
				short num3 = num;
				num = (short)1343685678;
				switch (num3 == num)
				{
				}
				num = (short)1537540097;
				if (num != 0)
				{
				}
				num = (short)870776832;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Value;
			}
			set
			{
				short num = (short)784728064;
				short num2 = num;
				num = (short)1706047297;
				short num3 = num;
				num = (short)151009089;
				switch (num3 == num)
				{
				}
				num = (short)775684097;
				if (num != 0)
				{
				}
				num = (short)299040768;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Value = value;
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x06006F64 RID: 28516 RVA: 0x00634408 File Offset: 0x00632608
		public global::AcpBusinessLayer.AcpSimpleRangeField DispMenuAdvancedFeatureInactivityTimeoutSec_A20011
		{
			get
			{
				short num = (short)693108736;
				short num2 = num;
				num = (short)1662725825;
				short num3 = num;
				num = (short)781463233;
				switch (num3 == num)
				{
				}
				num = (short)167182337;
				if (num != 0)
				{
				}
				num = (short)1316290560;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011;
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x06006F65 RID: 28517 RVA: 0x006344B8 File Offset: 0x006326B8
		// (set) Token: 0x06006F66 RID: 28518 RVA: 0x00634570 File Offset: 0x00632770
		public string DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_UIValue
		{
			get
			{
				short num = (short)313065472;
				short num2 = num;
				num = (short)1787105717;
				short num3 = num;
				num = (short)155849141;
				switch (num3 == num)
				{
				}
				num = (short)2067267584;
				if (num != 0)
				{
				}
				num = (short)300744705;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.UIValue;
			}
			set
			{
				short num = (short)953810944;
				short num2 = num;
				num = (short)207473757;
				short num3 = num;
				num = (short)1185598557;
				switch (num3 == num)
				{
				}
				num = (short)1606352897;
				if (num != 0)
				{
				}
				num = (short)1112211456;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.UIValue = value;
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x06006F67 RID: 28519 RVA: 0x00634624 File Offset: 0x00632824
		// (set) Token: 0x06006F68 RID: 28520 RVA: 0x006346D8 File Offset: 0x006328D8
		internal int DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Min
		{
			get
			{
				short num = (short)874577920;
				short num2 = num;
				num = (short)1951943019;
				short num3 = num;
				num = (short)1551649131;
				switch (num3 == num)
				{
				}
				num = (short)1960247297;
				if (num != 0)
				{
				}
				num = (short)347406336;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Min;
			}
			set
			{
				short num = (short)1814691840;
				short num2 = num;
				num = (short)872156589;
				short num3 = num;
				num = (short)214306221;
				switch (num3 == num)
				{
				}
				num = (short)1056047105;
				if (num != 0)
				{
				}
				num = (short)543162368;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Min = value;
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x06006F69 RID: 28521 RVA: 0x0063478C File Offset: 0x0063298C
		// (set) Token: 0x06006F6A RID: 28522 RVA: 0x00634844 File Offset: 0x00632A44
		internal int DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Max
		{
			get
			{
				short num = (short)1533214720;
				short num2 = num;
				num = (short)181004645;
				short num3 = num;
				num = (short)278522213;
				switch (num3 == num)
				{
				}
				num = (short)1233453057;
				if (num != 0)
				{
				}
				num = (short)895549440;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Max;
			}
			set
			{
				short num = (short)587071488;
				short num2 = num;
				num = (short)1996525064;
				short num3 = num;
				num = (short)153587208;
				switch (num3 == num)
				{
				}
				num = (short)1606942721;
				if (num != 0)
				{
				}
				num = (short)215089152;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Max = value;
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x06006F6B RID: 28523 RVA: 0x006348F8 File Offset: 0x00632AF8
		// (set) Token: 0x06006F6C RID: 28524 RVA: 0x006349AC File Offset: 0x00632BAC
		internal int DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Step
		{
			get
			{
				short num = (short)883294208;
				short num2 = num;
				num = (short)456622160;
				short num3 = num;
				num = (short)2018672720;
				switch (num3 == num)
				{
				}
				num = (short)1977548801;
				if (num != 0)
				{
				}
				num = (short)203489280;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.StepSize;
			}
			set
			{
				short num = (short)16121856;
				short num2 = num;
				num = (short)922837493;
				short num3 = num;
				num = (short)1735418357;
				switch (num3 == num)
				{
				}
				num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)1509097472;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.StepSize = value;
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x00634A60 File Offset: 0x00632C60
		// (set) Token: 0x06006F6E RID: 28526 RVA: 0x00634B14 File Offset: 0x00632D14
		public bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_Applicable
		{
			get
			{
				short num = (short)952631296;
				short num2 = num;
				num = (short)383191949;
				short num3 = num;
				num = (short)848825229;
				switch (num3 == num)
				{
				}
				num = (short)602800129;
				if (num != 0)
				{
				}
				num = (short)1708982272;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Applicable;
			}
			set
			{
				short num = (short)1251409920;
				short num2 = num;
				num = (short)1432879105;
				if (num != 0)
				{
				}
				num = (short)1949071921;
				short num3 = num;
				num = (short)442399281;
				switch (num3 == num)
				{
				}
				num = (short)1025179648;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Applicable = value;
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x06006F6F RID: 28527 RVA: 0x00634BC8 File Offset: 0x00632DC8
		// (set) Token: 0x06006F70 RID: 28528 RVA: 0x00634C80 File Offset: 0x00632E80
		public bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_Valid
		{
			get
			{
				short num = (short)289013760;
				short num2 = num;
				num = (short)800391169;
				if (num != 0)
				{
				}
				num = (short)688898544;
				short num3 = num;
				num = (short)1939390960;
				switch (num3 == num)
				{
				}
				num = (short)1918435328;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Valid;
			}
			set
			{
				short num = (short)224067584;
				short num2 = num;
				num = (short)839373395;
				short num3 = num;
				num = (short)381014611;
				switch (num3 == num)
				{
				}
				num = (short)305528833;
				if (num != 0)
				{
				}
				num = (short)1498480640;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Valid = value;
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x06006F71 RID: 28529 RVA: 0x00634D38 File Offset: 0x00632F38
		// (set) Token: 0x06006F72 RID: 28530 RVA: 0x00634DEC File Offset: 0x00632FEC
		public bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_Visible
		{
			get
			{
				short num = (short)806486016;
				short num2 = num;
				num = (short)1336174723;
				short num3 = num;
				num = (short)13658243;
				switch (num3 == num)
				{
				}
				num = (short)1825767425;
				if (num != 0)
				{
				}
				num = (short)456654848;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Visible;
			}
			set
			{
				short num = (short)1824522240;
				short num2 = num;
				num = (short)1907392545;
				short num3 = num;
				num = (short)1508474913;
				switch (num3 == num)
				{
				}
				num = (short)1832714241;
				if (num != 0)
				{
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Visible = value;
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x06006F73 RID: 28531 RVA: 0x00634EA0 File Offset: 0x006330A0
		// (set) Token: 0x06006F74 RID: 28532 RVA: 0x00634F54 File Offset: 0x00633154
		public bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_Editable
		{
			get
			{
				short num = (short)1690828800;
				short num2 = num;
				num = (short)1458432404;
				short num3 = num;
				num = (short)648014228;
				switch (num3 == num)
				{
				}
				num = (short)1370685440;
				if (num != 0)
				{
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Editable;
			}
			set
			{
				short num = (short)580648960;
				short num2 = num;
				num = (short)561672944;
				short num3 = num;
				num = (short)878932720;
				switch (num3 == num)
				{
				}
				num = (short)1814167553;
				if (num != 0)
				{
				}
				num = (short)129695744;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Editable = value;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x06006F75 RID: 28533 RVA: 0x00635008 File Offset: 0x00633208
		internal string DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_UILabel
		{
			get
			{
				short num = (short)525336576;
				short num2 = num;
				num = (short)1253432551;
				short num3 = num;
				num = (short)1473436903;
				switch (num3 == num)
				{
				}
				num = (short)274530304;
				if (num != 0)
				{
				}
				num = (short)1867513857;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.UIName;
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x006350C0 File Offset: 0x006332C0
		// (set) Token: 0x06006F77 RID: 28535 RVA: 0x00635174 File Offset: 0x00633374
		internal bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_HiddenStatic
		{
			get
			{
				short num = (short)764149760;
				short num2 = num;
				num = (short)1934733316;
				short num3 = num;
				num = (short)1073197060;
				switch (num3 == num)
				{
				}
				num = (short)647561217;
				if (num != 0)
				{
				}
				num = (short)786563072;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.HiddenStatic;
			}
			set
			{
				short num = (short)316801024;
				short num2 = num;
				num = (short)2093611419;
				short num3 = num;
				num = (short)1255995803;
				switch (num3 == num)
				{
				}
				num = (short)537133056;
				if (num != 0)
				{
				}
				num = (short)458948609;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.HiddenStatic = value;
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x0063522C File Offset: 0x0063342C
		// (set) Token: 0x06006F79 RID: 28537 RVA: 0x006352E4 File Offset: 0x006334E4
		internal bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_HiddenDynamic
		{
			get
			{
				short num = (short)1107820544;
				short num2 = num;
				num = (short)216944378;
				short num3 = num;
				num = (short)1494699770;
				switch (num3 == num)
				{
				}
				num = (short)1179189249;
				if (num != 0)
				{
				}
				num = (short)1352466432;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.HiddenDynamic;
			}
			set
			{
				short num = (short)2000814080;
				short num2 = num;
				num = (short)881790036;
				short num3 = num;
				num = (short)24710228;
				switch (num3 == num)
				{
				}
				num = (short)171507712;
				if (num != 0)
				{
				}
				num = (short)1962213377;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011.HiddenDynamic = value;
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x00635398 File Offset: 0x00633598
		public bool DispMenuAdvancedFeatureInactivityTimeoutSec_A20011_HasDiffs
		{
			get
			{
				short num = (short)364707840;
				short num2 = num;
				num = (short)1743604697;
				short num3 = num;
				num = (short)337005529;
				switch (num3 == num)
				{
				}
				num = (short)1147207680;
				if (num != 0)
				{
				}
				num = (short)710475777;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedFeatureInactivityTimeoutSec_A20011._HasDiffs;
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x06006F7B RID: 28539 RVA: 0x00635450 File Offset: 0x00633650
		// (set) Token: 0x06006F7C RID: 28540 RVA: 0x00635504 File Offset: 0x00633704
		public int RadErgoWideDispMenu_A21430Value
		{
			get
			{
				short num = (short)651034624;
				short num2 = num;
				num = (short)122250032;
				short num3 = num;
				num = (short)627335984;
				switch (num3 == num)
				{
				}
				num = (short)931594241;
				if (num != 0)
				{
				}
				num = (short)1128792064;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430.Value;
			}
			set
			{
				short num = (short)464650240;
				short num2 = num;
				num = (short)998341924;
				short num3 = num;
				num = (short)32275748;
				switch (num3 == num)
				{
				}
				num = (short)1767309313;
				if (num != 0)
				{
				}
				num = (short)332857344;
				if (num != 0)
				{
				}
				this.radErgoWideDispMenu_A21430.Value = value;
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x06006F7D RID: 28541 RVA: 0x006355B8 File Offset: 0x006337B8
		// (set) Token: 0x06006F7E RID: 28542 RVA: 0x00635670 File Offset: 0x00633870
		public string RadErgoWideDispMenu_A21430_UIValue
		{
			get
			{
				short num = (short)235864064;
				short num2 = num;
				num = (short)54320605;
				short num3 = num;
				num = (short)703520221;
				switch (num3 == num)
				{
				}
				num = (short)1881210880;
				if (num != 0)
				{
				}
				num = (short)1695744001;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430.UIValue;
			}
			set
			{
				short num = (short)1288110080;
				short num2 = num;
				num = (short)1882518666;
				short num3 = num;
				num = (short)2091316362;
				switch (num3 == num)
				{
				}
				num = (short)2035941376;
				if (num != 0)
				{
				}
				num = (short)128581633;
				if (num != 0)
				{
				}
				this.radErgoWideDispMenu_A21430.UIValue = value;
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x06006F7F RID: 28543 RVA: 0x00635728 File Offset: 0x00633928
		public global::AcpBusinessLayer.AcpListField RadErgoWideDispMenu_A21430
		{
			get
			{
				short num = (short)335020032;
				short num2 = num;
				num = (short)1191835769;
				short num3 = num;
				num = (short)733608057;
				switch (num3 == num)
				{
				}
				num = (short)85196801;
				if (num != 0)
				{
				}
				num = (short)1477115904;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430;
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x006357D8 File Offset: 0x006339D8
		// (set) Token: 0x06006F81 RID: 28545 RVA: 0x0063588C File Offset: 0x00633A8C
		public bool RadErgoWideDispMenu_A21430_Applicable
		{
			get
			{
				short num = (short)870842368;
				short num2 = num;
				num = (short)1162608641;
				if (num != 0)
				{
				}
				num = (short)492386291;
				short num3 = num;
				num = (short)1079195635;
				switch (num3 == num)
				{
				}
				num = (short)357367808;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430.Applicable;
			}
			set
			{
				short num = (short)255000576;
				short num2 = num;
				num = (short)718087185;
				short num3 = num;
				num = (short)596517905;
				switch (num3 == num)
				{
				}
				num = (short)1277493249;
				if (num != 0)
				{
				}
				num = (short)494796800;
				if (num != 0)
				{
				}
				this.radErgoWideDispMenu_A21430.Applicable = value;
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x00635940 File Offset: 0x00633B40
		// (set) Token: 0x06006F83 RID: 28547 RVA: 0x006359F4 File Offset: 0x00633BF4
		public bool RadErgoWideDispMenu_A21430_Valid
		{
			get
			{
				short num = (short)23461888;
				short num2 = num;
				num = (short)1841653357;
				short num3 = num;
				num = (short)1106011757;
				switch (num3 == num)
				{
				}
				num = (short)1105330177;
				if (num != 0)
				{
				}
				num = (short)1165426688;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430.Valid;
			}
			set
			{
				short num = (short)1448607744;
				short num2 = num;
				num = (short)1283767191;
				short num3 = num;
				num = (short)1031846807;
				switch (num3 == num)
				{
				}
				num = (short)1776156673;
				if (num != 0)
				{
				}
				num = (short)621477888;
				if (num != 0)
				{
				}
				this.radErgoWideDispMenu_A21430.Valid = value;
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x00635AAC File Offset: 0x00633CAC
		// (set) Token: 0x06006F85 RID: 28549 RVA: 0x00635B60 File Offset: 0x00633D60
		public bool RadErgoWideDispMenu_A21430_Visible
		{
			get
			{
				short num = (short)1952448512;
				short num2 = num;
				num = (short)616940569;
				short num3 = num;
				num = (short)28099609;
				switch (num3 == num)
				{
				}
				num = (short)2026831873;
				if (num != 0)
				{
				}
				num = (short)1404960768;
				if (num != 0)
				{
				}
				return this.radErgoWideDispMenu_A21430.Visible;
			}
			set
			{
				short num = (short)810221568;
				short num2 = num;
				num = (short)1076485217;
				short num3 = num;
				num = (short)1200610401;
				switch (num3 == num)
				{
				}
				num = (short)1981612033;
				if (num != 0)
				{
				}
				num = (short)558170112;
				if (num != 0)
				{
				}
				this.radErgoWideDispMenu_A21430.Visible = value;
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x00635C18 File Offset: 0x00633E18
		// (set) Token: 0x06006F87 RID: 28551 RVA: 0x00635CCC File Offset: 0x00633ECC
		public bool RadErgoWideDispMenu_A21430_Editable
		{
			get
			{
				short num = (short)1767839645;
				short num2 = num;
				num = (short)1085675421;
				switch (num2 == num)
				{
				}
				num = (short)1509621760;
				if (num != 0)
				{
				}
				num = (short)1978925057;
				if (num != 0)
				{
				}
				num = (short)113967104;
				short num3 = num;
				return this.radErgoWideDispMenu_A21430.Editable;
			}
			set
			{
				short num = (short)20681559;
				short num2 = num;
				num = (short)925471575;
				switch (num2 == num)
				{
				}
				num = (short)275775489;
				if (num != 0)
				{
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				num = (short)2026307584;
				short num3 = num;
				this.radErgoWideDispMenu_A21430.Editable = value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x00635D80 File Offset: 0x00633F80
		internal string RadErgoWideDispMenu_A21430_UILabel
		{
			get
			{
				short num = (short)1686903287;
				short num2 = num;
				num = (short)378083831;
				switch (num2 == num)
				{
				}
				num = (short)1174208512;
				if (num != 0)
				{
				}
				num = (short)1016987649;
				if (num != 0)
				{
				}
				num = (short)1372454912;
				short num3 = num;
				return this.radErgoWideDispMenu_A21430.UIName;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x06006F89 RID: 28553 RVA: 0x00635E38 File Offset: 0x00634038
		// (set) Token: 0x06006F8A RID: 28554 RVA: 0x00635EEC File Offset: 0x006340EC
		internal bool RadErgoWideDispMenu_A21430_HiddenStatic
		{
			get
			{
				short num = (short)656899784;
				short num2 = num;
				num = (short)2045607624;
				switch (num2 == num)
				{
				}
				num = (short)1245249537;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				if (num != 0)
				{
				}
				num = (short)387645440;
				short num3 = num;
				return this.radErgoWideDispMenu_A21430.HiddenStatic;
			}
			set
			{
				short num = (short)1670447105;
				if (num != 0)
				{
				}
				num = (short)1350649635;
				short num2 = num;
				num = (short)872171299;
				switch (num2 == num)
				{
				}
				num = (short)521273344;
				if (num != 0)
				{
				}
				num = (short)732102656;
				short num3 = num;
				this.radErgoWideDispMenu_A21430.HiddenStatic = value;
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x06006F8B RID: 28555 RVA: 0x00635FA0 File Offset: 0x006341A0
		// (set) Token: 0x06006F8C RID: 28556 RVA: 0x00636058 File Offset: 0x00634258
		internal bool RadErgoWideDispMenu_A21430_HiddenDynamic
		{
			get
			{
				short num = (short)654114817;
				if (num != 0)
				{
				}
				num = (short)333050724;
				short num2 = num;
				num = (short)1223816036;
				switch (num2 == num)
				{
				}
				num = (short)346816512;
				if (num != 0)
				{
				}
				num = (short)829227008;
				short num3 = num;
				return this.radErgoWideDispMenu_A21430.HiddenDynamic;
			}
			set
			{
				short num = (short)1272263614;
				short num2 = num;
				num = (short)541012926;
				switch (num2 == num)
				{
				}
				num = (short)1715994625;
				if (num != 0)
				{
				}
				num = (short)971767808;
				if (num != 0)
				{
				}
				num = (short)30539776;
				short num3 = num;
				this.radErgoWideDispMenu_A21430.HiddenDynamic = value;
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x06006F8D RID: 28557 RVA: 0x00636110 File Offset: 0x00634310
		public bool RadErgoWideDispMenu_A21430_HasDiffs
		{
			get
			{
				short num = (short)14775368;
				short num2 = num;
				num = (short)1710060616;
				switch (num2 == num)
				{
				}
				num = (short)390594561;
				if (num != 0)
				{
				}
				num = (short)916324352;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				short num3 = num;
				return this.radErgoWideDispMenu_A21430._HasDiffs;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x006361C4 File Offset: 0x006343C4
		// (set) Token: 0x06006F8F RID: 28559 RVA: 0x00636278 File Offset: 0x00634478
		public int DispMenuAdvancedLanguageSelection_A8386Value
		{
			get
			{
				short num = (short)73304869;
				short num2 = num;
				num = (short)1885768485;
				switch (num2 == num)
				{
				}
				num = (short)267059201;
				if (num != 0)
				{
				}
				num = (short)652017664;
				if (num != 0)
				{
				}
				num = (short)300285952;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.Value;
			}
			set
			{
				short num = (short)1046697728;
				short num2 = num;
				num = (short)402085632;
				switch (num2 == num)
				{
				}
				num = (short)1620049920;
				if (num != 0)
				{
				}
				num = (short)2144010241;
				if (num != 0)
				{
				}
				num = (short)1166802944;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.Value = value;
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x0063632C File Offset: 0x0063452C
		// (set) Token: 0x06006F91 RID: 28561 RVA: 0x006363E0 File Offset: 0x006345E0
		public string DispMenuAdvancedLanguageSelection_A8386_UIValue
		{
			get
			{
				short num = (short)316152958;
				short num2 = num;
				num = (short)278666366;
				switch (num2 == num)
				{
				}
				num = (short)77725696;
				if (num != 0)
				{
				}
				num = (short)1606483969;
				if (num != 0)
				{
				}
				num = (short)1621295104;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.UIValue;
			}
			set
			{
				short num = (short)1468006401;
				if (num != 0)
				{
				}
				num = (short)280437713;
				short num2 = num;
				num = (short)1174610897;
				switch (num2 == num)
				{
				}
				num = (short)113180672;
				if (num != 0)
				{
				}
				num = (short)630587392;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.UIValue = value;
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x06006F92 RID: 28562 RVA: 0x00636498 File Offset: 0x00634698
		public global::AcpBusinessLayer.AcpListField DispMenuAdvancedLanguageSelection_A8386
		{
			get
			{
				short num = (short)898128820;
				short num2 = num;
				num = (short)230644660;
				switch (num2 == num)
				{
				}
				num = (short)1068105728;
				if (num != 0)
				{
				}
				num = (short)717881345;
				if (num != 0)
				{
				}
				num = (short)1905459200;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386;
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x06006F93 RID: 28563 RVA: 0x00636548 File Offset: 0x00634748
		// (set) Token: 0x06006F94 RID: 28564 RVA: 0x006365FC File Offset: 0x006347FC
		public bool DispMenuAdvancedLanguageSelection_A8386_Applicable
		{
			get
			{
				short num = (short)1388492789;
				short num2 = num;
				num = (short)624080885;
				switch (num2 == num)
				{
				}
				num = (short)381157376;
				if (num != 0)
				{
				}
				num = (short)167968769;
				if (num != 0)
				{
				}
				num = (short)306970624;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.Applicable;
			}
			set
			{
				short num = (short)253903853;
				short num2 = num;
				num = (short)772621293;
				switch (num2 == num)
				{
				}
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)1372192768;
				if (num != 0)
				{
				}
				num = (short)1912471552;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.Applicable = value;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x06006F95 RID: 28565 RVA: 0x006366B0 File Offset: 0x006348B0
		// (set) Token: 0x06006F96 RID: 28566 RVA: 0x00636764 File Offset: 0x00634964
		public bool DispMenuAdvancedLanguageSelection_A8386_Valid
		{
			get
			{
				short num = (short)896733138;
				short num2 = num;
				num = (short)1851330514;
				switch (num2 == num)
				{
				}
				num = (short)1480327168;
				if (num != 0)
				{
				}
				num = (short)2096496641;
				if (num != 0)
				{
				}
				num = (short)1977942016;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.Valid;
			}
			set
			{
				short num = (short)2024922996;
				short num2 = num;
				num = (short)1145626484;
				switch (num2 == num)
				{
				}
				num = (short)1156644864;
				if (num != 0)
				{
				}
				num = (short)1517092865;
				if (num != 0)
				{
				}
				num = (short)1725104128;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.Valid = value;
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x06006F97 RID: 28567 RVA: 0x0063681C File Offset: 0x00634A1C
		// (set) Token: 0x06006F98 RID: 28568 RVA: 0x006368D4 File Offset: 0x00634AD4
		public bool DispMenuAdvancedLanguageSelection_A8386_Visible
		{
			get
			{
				short num = (short)1484047317;
				short num2 = num;
				num = (short)116048853;
				switch (num2 == num)
				{
				}
				num = (short)678494209;
				if (num != 0)
				{
				}
				num = (short)33751040;
				if (num != 0)
				{
				}
				num = (short)713293824;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.Visible;
			}
			set
			{
				short num = (short)564375745;
				short num2 = num;
				num = (short)1340321985;
				switch (num2 == num)
				{
				}
				num = (short)2113667073;
				if (num != 0)
				{
				}
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)1750859776;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.Visible = value;
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x0063698C File Offset: 0x00634B8C
		// (set) Token: 0x06006F9A RID: 28570 RVA: 0x00636A40 File Offset: 0x00634C40
		public bool DispMenuAdvancedLanguageSelection_A8386_Editable
		{
			get
			{
				short num = (short)1371671186;
				short num2 = num;
				num = (short)1583286930;
				switch (num2 == num)
				{
				}
				num = (short)514719745;
				if (num != 0)
				{
				}
				num = (short)1874001920;
				if (num != 0)
				{
				}
				num = (short)1487339520;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.Editable;
			}
			set
			{
				short num = (short)1535502407;
				short num2 = num;
				num = (short)1093593159;
				switch (num2 == num)
				{
				}
				num = (short)1232076800;
				if (num != 0)
				{
				}
				num = (short)523763713;
				if (num != 0)
				{
				}
				num = (short)2079719424;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.Editable = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x06006F9B RID: 28571 RVA: 0x00636AF4 File Offset: 0x00634CF4
		internal string DispMenuAdvancedLanguageSelection_A8386_UILabel
		{
			get
			{
				short num = (short)741745260;
				short num2 = num;
				num = (short)1541939820;
				switch (num2 == num)
				{
				}
				num = (short)1864630272;
				if (num != 0)
				{
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				num = (short)672792576;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.UIName;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x00636BAC File Offset: 0x00634DAC
		// (set) Token: 0x06006F9D RID: 28573 RVA: 0x00636C60 File Offset: 0x00634E60
		internal bool DispMenuAdvancedLanguageSelection_A8386_HiddenStatic
		{
			get
			{
				short num = (short)1336329691;
				short num2 = num;
				num = (short)1254475227;
				switch (num2 == num)
				{
				}
				num = (short)1785528320;
				if (num != 0)
				{
				}
				num = (short)1597702145;
				if (num != 0)
				{
				}
				num = (short)1931476992;
				short num3 = num;
				return this.dispMenuAdvancedLanguageSelection_A8386.HiddenStatic;
			}
			set
			{
				short num = (short)653289772;
				short num2 = num;
				num = (short)1560766764;
				switch (num2 == num)
				{
				}
				num = (short)1380319233;
				if (num != 0)
				{
				}
				num = (short)928186368;
				if (num != 0)
				{
				}
				num = (short)980156416;
				short num3 = num;
				this.dispMenuAdvancedLanguageSelection_A8386.HiddenStatic = value;
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x06006F9E RID: 28574 RVA: 0x00636D18 File Offset: 0x00634F18
		// (set) Token: 0x06006F9F RID: 28575 RVA: 0x00636DD0 File Offset: 0x00634FD0
		internal bool DispMenuAdvancedLanguageSelection_A8386_HiddenDynamic
		{
			get
			{
				short num = (short)1804979270;
				short num2 = num;
				num = (short)402246726;
				switch (num2 == num)
				{
				}
				num = (short)1114113;
				if (num != 0)
				{
				}
				num = (short)28639232;
				short num3 = num;
				num = (short)309526528;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedLanguageSelection_A8386.HiddenDynamic;
			}
			set
			{
				short num = (short)820260815;
				short num2 = num;
				num = (short)1856712655;
				switch (num2 == num)
				{
				}
				num = (short)1357250561;
				if (num != 0)
				{
				}
				num = (short)700645376;
				short num3 = num;
				num = (short)1790574592;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedLanguageSelection_A8386.HiddenDynamic = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x00636E88 File Offset: 0x00635088
		public bool DispMenuAdvancedLanguageSelection_A8386_HasDiffs
		{
			get
			{
				short num = (short)1139537114;
				short num2 = num;
				num = (short)1489433818;
				switch (num2 == num)
				{
				}
				num = (short)410648577;
				if (num != 0)
				{
				}
				num = (short)1856634880;
				short num3 = num;
				num = (short)210108416;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedLanguageSelection_A8386._HasDiffs;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x06006FA1 RID: 28577 RVA: 0x00636F40 File Offset: 0x00635140
		// (set) Token: 0x06006FA2 RID: 28578 RVA: 0x00636FF8 File Offset: 0x006351F8
		public int DispMenuAdvancedAlternatingDisplayTimems_A7436Value
		{
			get
			{
				short num = (short)837588367;
				short num2 = num;
				num = (short)2103154063;
				switch (num2 == num)
				{
				}
				num = (short)1930756097;
				if (num != 0)
				{
				}
				num = (short)234225664;
				short num3 = num;
				num = (short)398589952;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Value;
			}
			set
			{
				short num = (short)158287965;
				short num2 = num;
				num = (short)1720600669;
				switch (num2 == num)
				{
				}
				num = (short)602603521;
				if (num != 0)
				{
				}
				num = (short)1501560832;
				short num3 = num;
				num = (short)744030208;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Value = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x006370B0 File Offset: 0x006352B0
		public global::AcpBusinessLayer.AcpRangeField<int, string> DispMenuAdvancedAlternatingDisplayTimems_A7436
		{
			get
			{
				short num = (short)238747649;
				if (num != 0)
				{
				}
				num = (short)1742159332;
				short num2 = num;
				num = (short)1545813476;
				switch (num2 == num)
				{
				}
				num = (short)394133504;
				short num3 = num;
				num = (short)1946484736;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x00637160 File Offset: 0x00635360
		// (set) Token: 0x06006FA5 RID: 28581 RVA: 0x00637214 File Offset: 0x00635414
		public string DispMenuAdvancedAlternatingDisplayTimems_A7436_UIValue
		{
			get
			{
				short num = (short)1320330527;
				short num2 = num;
				num = (short)2062460191;
				switch (num2 == num)
				{
				}
				num = (short)1871642624;
				if (num != 0)
				{
				}
				num = (short)1248985088;
				short num3 = num;
				num = (short)367984641;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.UIValue;
			}
			set
			{
				short num = (short)438681242;
				short num2 = num;
				num = (short)1359527578;
				switch (num2 == num)
				{
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				num = (short)2055274496;
				short num3 = num;
				num = (short)162267136;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.UIValue = value;
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x006372CC File Offset: 0x006354CC
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x00637384 File Offset: 0x00635584
		internal int DispMenuAdvancedAlternatingDisplayTimems_A7436Min
		{
			get
			{
				short num = (short)669842902;
				short num2 = num;
				num = (short)1674116566;
				switch (num2 == num)
				{
				}
				num = (short)1627652097;
				if (num != 0)
				{
				}
				num = (short)1437466624;
				short num3 = num;
				num = (short)1182859264;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Min;
			}
			set
			{
				short num = (short)390657521;
				short num2 = num;
				num = (short)362149361;
				switch (num2 == num)
				{
				}
				num = (short)1565392897;
				if (num != 0)
				{
				}
				num = (short)1569521664;
				short num3 = num;
				num = (short)665059328;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Min = value;
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x00637438 File Offset: 0x00635638
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x006374EC File Offset: 0x006356EC
		internal int DispMenuAdvancedAlternatingDisplayTimems_A7436Max
		{
			get
			{
				short num = (short)1637109989;
				short num2 = num;
				num = (short)709054693;
				switch (num2 == num)
				{
				}
				num = (short)1653669889;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				short num3 = num;
				num = (short)246611968;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Max;
			}
			set
			{
				short num = (short)1869212873;
				short num2 = num;
				num = (short)760802505;
				switch (num2 == num)
				{
				}
				num = (short)1233453057;
				if (num != 0)
				{
				}
				num = (short)805568512;
				short num3 = num;
				num = (short)482344960;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Max = value;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x006375A4 File Offset: 0x006357A4
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x0063765C File Offset: 0x0063585C
		internal int DispMenuAdvancedAlternatingDisplayTimems_A7436Step
		{
			get
			{
				short num = (short)1254281116;
				short num2 = num;
				num = (short)224907164;
				switch (num2 == num)
				{
				}
				num = (short)1434058753;
				if (num != 0)
				{
				}
				num = (short)583598080;
				short num3 = num;
				num = (short)607059968;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.StepSize;
			}
			set
			{
				short num = (short)681112616;
				short num2 = num;
				num = (short)910292008;
				switch (num2 == num)
				{
				}
				num = (short)55508993;
				if (num != 0)
				{
				}
				num = (short)1250295808;
				short num3 = num;
				num = (short)626262016;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.StepSize = value;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00637714 File Offset: 0x00635914
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x006377C8 File Offset: 0x006359C8
		public bool DispMenuAdvancedAlternatingDisplayTimems_A7436_Applicable
		{
			get
			{
				short num = (short)2002425283;
				short num2 = num;
				num = (short)1950324163;
				switch (num2 == num)
				{
				}
				num = (short)1112473600;
				if (num != 0)
				{
				}
				num = (short)1020985344;
				short num3 = num;
				num = (short)720568321;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Applicable;
			}
			set
			{
				short num = (short)687127711;
				short num2 = num;
				num = (short)1100856479;
				switch (num2 == num)
				{
				}
				num = (short)783876097;
				if (num != 0)
				{
				}
				num = (short)1849163776;
				short num3 = num;
				num = (short)815857664;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Applicable = value;
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x0063787C File Offset: 0x00635A7C
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x00637930 File Offset: 0x00635B30
		public bool DispMenuAdvancedAlternatingDisplayTimems_A7436_Valid
		{
			get
			{
				short num = (short)1174062557;
				short num2 = num;
				num = (short)920045021;
				switch (num2 == num)
				{
				}
				num = (short)751894529;
				if (num != 0)
				{
				}
				num = (short)259260416;
				short num3 = num;
				num = (short)1998913536;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Valid;
			}
			set
			{
				short num = (short)1020975793;
				short num2 = num;
				num = (short)1186847409;
				switch (num2 == num)
				{
				}
				num = (short)1273430016;
				if (num != 0)
				{
				}
				num = (short)2088239104;
				short num3 = num;
				num = (short)1954480129;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Valid = value;
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x006379E4 File Offset: 0x00635BE4
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x00637A98 File Offset: 0x00635C98
		public bool DispMenuAdvancedAlternatingDisplayTimems_A7436_Visible
		{
			get
			{
				short num = (short)906002735;
				short num2 = num;
				num = (short)1625784623;
				switch (num2 == num)
				{
				}
				num = (short)1958543361;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				short num3 = num;
				num = (short)1655177216;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Visible;
			}
			set
			{
				short num = (short)1246426328;
				short num2 = num;
				num = (short)781710552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773324800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819607040;
				if (num != 0)
				{
				}
				num = (short)712507393;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Visible = value;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x00637B4C File Offset: 0x00635D4C
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x00637C00 File Offset: 0x00635E00
		public bool DispMenuAdvancedAlternatingDisplayTimems_A7436_Editable
		{
			get
			{
				short num = (short)961824434;
				short num2 = num;
				num = (short)640173746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)406454272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)423165952;
				if (num != 0)
				{
				}
				num = (short)1058865153;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Editable;
			}
			set
			{
				short num = (short)1696356691;
				short num2 = num;
				num = (short)1823889747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)742195200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1768030209;
				if (num != 0)
				{
				}
				num = (short)1936719872;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.Editable = value;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x00637CB4 File Offset: 0x00635EB4
		internal string DispMenuAdvancedAlternatingDisplayTimems_A7436_UILabel
		{
			get
			{
				short num = (short)216858625;
				if (num != 0)
				{
				}
				num = (short)1145503744;
				short num2 = num;
				num = (short)1311408681;
				short num3 = num;
				num = (short)1172472361;
				switch (num3 == num)
				{
				}
				num = (short)2007433216;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.UIName;
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x00637D68 File Offset: 0x00635F68
		// (set) Token: 0x06006FB6 RID: 28598 RVA: 0x00637E20 File Offset: 0x00636020
		internal bool DispMenuAdvancedAlternatingDisplayTimems_A7436_HiddenStatic
		{
			get
			{
				short num = (short)799816853;
				short num2 = num;
				num = (short)890584213;
				switch (num2 == num)
				{
				default:
				{
					num = (short)562364416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)383713281;
				if (num != 0)
				{
				}
				num = (short)1724579840;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.HiddenStatic;
			}
			set
			{
				short num = (short)76723340;
				short num2 = num;
				num = (short)473937036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)394657792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417857537;
				if (num != 0)
				{
				}
				num = (short)544276480;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.HiddenStatic = value;
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x00637ED4 File Offset: 0x006360D4
		// (set) Token: 0x06006FB8 RID: 28600 RVA: 0x00637F88 File Offset: 0x00636188
		internal bool DispMenuAdvancedAlternatingDisplayTimems_A7436_HiddenDynamic
		{
			get
			{
				short num = (short)1958029344;
				short num2 = num;
				num = (short)790833184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5701632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)176095233;
				if (num != 0)
				{
				}
				num = (short)625934336;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436.HiddenDynamic;
			}
			set
			{
				short num = (short)1671840924;
				short num2 = num;
				num = (short)306791580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)946864128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412104193;
				if (num != 0)
				{
				}
				num = (short)461963264;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedAlternatingDisplayTimems_A7436.HiddenDynamic = value;
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x06006FB9 RID: 28601 RVA: 0x0063803C File Offset: 0x0063623C
		public bool DispMenuAdvancedAlternatingDisplayTimems_A7436_HasDiffs
		{
			get
			{
				short num = (short)1781572248;
				short num2 = num;
				num = (short)1669178008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528037376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889585664;
				if (num != 0)
				{
				}
				num = (short)868679681;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedAlternatingDisplayTimems_A7436._HasDiffs;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x06006FBA RID: 28602 RVA: 0x006380F0 File Offset: 0x006362F0
		// (set) Token: 0x06006FBB RID: 28603 RVA: 0x006381A8 File Offset: 0x006363A8
		public int DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Value
		{
			get
			{
				short num = (short)1386744533;
				short num2 = num;
				num = (short)1408109269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433192960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419116544;
				if (num != 0)
				{
				}
				num = (short)609812481;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Value;
			}
			set
			{
				short num = (short)201111943;
				short num2 = num;
				num = (short)777435527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916731392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348075520;
				if (num != 0)
				{
				}
				num = (short)1876885505;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Value = value;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x06006FBC RID: 28604 RVA: 0x0063825C File Offset: 0x0063645C
		public global::AcpBusinessLayer.AcpRangeField<int, string> DispMenuAdvancedTemporaryMessageDisplayTimems_A9287
		{
			get
			{
				short num = (short)1861088281;
				short num2 = num;
				num = (short)910881817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414266880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)486146049;
				if (num != 0)
				{
				}
				num = (short)2080833536;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x06006FBD RID: 28605 RVA: 0x0063830C File Offset: 0x0063650C
		// (set) Token: 0x06006FBE RID: 28606 RVA: 0x006383C0 File Offset: 0x006365C0
		public string DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_UIValue
		{
			get
			{
				short num = (short)993391920;
				short num2 = num;
				num = (short)1454437680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)517210112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825622529;
				if (num != 0)
				{
				}
				num = (short)758251520;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.UIValue;
			}
			set
			{
				short num = (short)823184764;
				short num2 = num;
				num = (short)1985465724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852309504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000472576;
				if (num != 0)
				{
				}
				num = (short)131530753;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.UIValue = value;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x00638478 File Offset: 0x00636678
		// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x0063852C File Offset: 0x0063672C
		internal int DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Min
		{
			get
			{
				short num = (short)1815195851;
				short num2 = num;
				num = (short)360493259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100597760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277348353;
				if (num != 0)
				{
				}
				num = (short)1057095680;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Min;
			}
			set
			{
				short num = (short)1585558145;
				short num2 = num;
				num = (short)676573825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595787776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754660864;
				if (num != 0)
				{
				}
				num = (short)1417216001;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Min = value;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x006385DC File Offset: 0x006367DC
		// (set) Token: 0x06006FC2 RID: 28610 RVA: 0x00638690 File Offset: 0x00636890
		internal int DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Max
		{
			get
			{
				short num = (short)263919444;
				short num2 = num;
				num = (short)220600148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430899200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79757313;
				if (num != 0)
				{
				}
				num = (short)443482112;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Max;
			}
			set
			{
				short num = (short)707526281;
				short num2 = num;
				num = (short)1429733001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1772421120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1680736257;
				if (num != 0)
				{
				}
				num = (short)609812480;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Max = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x06006FC3 RID: 28611 RVA: 0x00638744 File Offset: 0x00636944
		// (set) Token: 0x06006FC4 RID: 28612 RVA: 0x006387F8 File Offset: 0x006369F8
		internal int DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Step
		{
			get
			{
				short num = (short)137625601;
				if (num != 0)
				{
				}
				num = (short)1819541504;
				short num2 = num;
				num = (short)1358405167;
				short num3 = num;
				num = (short)1660984879;
				switch (num3 == num)
				{
				}
				num = (short)1437270016;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.StepSize;
			}
			set
			{
				short num = (short)2091592682;
				short num2 = num;
				num = (short)545991658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873543168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775828992;
				if (num != 0)
				{
				}
				num = (short)400752641;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.StepSize = value;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x06006FC5 RID: 28613 RVA: 0x006388B0 File Offset: 0x00636AB0
		// (set) Token: 0x06006FC6 RID: 28614 RVA: 0x00638964 File Offset: 0x00636B64
		public bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_Applicable
		{
			get
			{
				short num = (short)988564801;
				short num2 = num;
				num = (short)1534283073;
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
				num = (short)1717174273;
				if (num != 0)
				{
				}
				num = (short)246611968;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Applicable;
			}
			set
			{
				short num = (short)1520107521;
				if (num != 0)
				{
				}
				num = (short)1227096064;
				short num2 = num;
				num = (short)1959703008;
				short num3 = num;
				num = (short)630174176;
				switch (num3 == num)
				{
				}
				num = (short)660996096;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Applicable = value;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x06006FC7 RID: 28615 RVA: 0x00638A1C File Offset: 0x00636C1C
		// (set) Token: 0x06006FC8 RID: 28616 RVA: 0x00638AD0 File Offset: 0x00636CD0
		public bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_Valid
		{
			get
			{
				short num = (short)517955043;
				short num2 = num;
				num = (short)661216739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947322880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)919470080;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Valid;
			}
			set
			{
				short num = (short)24913402;
				short num2 = num;
				num = (short)1260135930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101856768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346371585;
				if (num != 0)
				{
				}
				num = (short)1500708864;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Valid = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x06006FC9 RID: 28617 RVA: 0x00638B84 File Offset: 0x00636D84
		// (set) Token: 0x06006FCA RID: 28618 RVA: 0x00638C38 File Offset: 0x00636E38
		public bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_Visible
		{
			get
			{
				short num = (short)310076866;
				short num2 = num;
				num = (short)950887874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651493376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120876033;
				if (num != 0)
				{
				}
				num = (short)2096693248;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Visible;
			}
			set
			{
				short num = (short)288843536;
				short num2 = num;
				num = (short)188049168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)75366400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762525185;
				if (num != 0)
				{
				}
				num = (short)15794176;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Visible = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x06006FCB RID: 28619 RVA: 0x00638CEC File Offset: 0x00636EEC
		// (set) Token: 0x06006FCC RID: 28620 RVA: 0x00638DA0 File Offset: 0x00636FA0
		public bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_Editable
		{
			get
			{
				short num = (short)786650915;
				short num2 = num;
				num = (short)284451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1695285248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750597633;
				if (num != 0)
				{
				}
				num = (short)447741952;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Editable;
			}
			set
			{
				short num = (short)301744181;
				short num2 = num;
				num = (short)1365721141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224933376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127364097;
				if (num != 0)
				{
				}
				num = (short)917176320;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.Editable = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x06006FCD RID: 28621 RVA: 0x00638E54 File Offset: 0x00637054
		internal string DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_UILabel
		{
			get
			{
				short num = (short)1021045580;
				short num2 = num;
				num = (short)1143794508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761935360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392691713;
				if (num != 0)
				{
				}
				num = (short)1923088384;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.UIName;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x06006FCE RID: 28622 RVA: 0x00638F08 File Offset: 0x00637108
		// (set) Token: 0x06006FCF RID: 28623 RVA: 0x00638FBC File Offset: 0x006371BC
		internal bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_HiddenStatic
		{
			get
			{
				short num = (short)1015098897;
				short num2 = num;
				num = (short)1010118161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1468989440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1026686977;
				if (num != 0)
				{
				}
				num = (short)1133510656;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.HiddenStatic;
			}
			set
			{
				short num = (short)2012279841;
				short num2 = num;
				num = (short)177271841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470889984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224264192;
				if (num != 0)
				{
				}
				num = (short)433192961;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.HiddenStatic = value;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x00639074 File Offset: 0x00637274
		// (set) Token: 0x06006FD1 RID: 28625 RVA: 0x00639128 File Offset: 0x00637328
		internal bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_HiddenDynamic
		{
			get
			{
				short num = (short)238961845;
				short num2 = num;
				num = (short)1951024309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131675648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963393025;
				if (num != 0)
				{
				}
				num = (short)971046912;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.HiddenDynamic;
			}
			set
			{
				short num = (short)105188757;
				short num2 = num;
				num = (short)669912469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423245312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763508224;
				if (num != 0)
				{
				}
				num = (short)2019622913;
				if (num != 0)
				{
				}
				this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287.HiddenDynamic = value;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x06006FD2 RID: 28626 RVA: 0x006391DC File Offset: 0x006373DC
		public bool DispMenuAdvancedTemporaryMessageDisplayTimems_A9287_HasDiffs
		{
			get
			{
				short num = (short)933011773;
				short num2 = num;
				num = (short)330932541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051014656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855455233;
				if (num != 0)
				{
				}
				num = (short)1883701248;
				if (num != 0)
				{
				}
				return this.dispMenuAdvancedTemporaryMessageDisplayTimems_A9287._HasDiffs;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x00639290 File Offset: 0x00637490
		// (set) Token: 0x06006FD4 RID: 28628 RVA: 0x00639348 File Offset: 0x00637548
		public int RadioErgDispAdvanceChannelColorBacklight_43747Value
		{
			get
			{
				short num = (short)386781442;
				short num2 = num;
				num = (short)1396953346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933756928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094189056;
				if (num != 0)
				{
				}
				num = (short)1339424769;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.Value;
			}
			set
			{
				short num = (short)480846457;
				short num2 = num;
				num = (short)1581589113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)437321728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720896001;
				if (num != 0)
				{
				}
				num = (short)1683947520;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.Value = value;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x006393FC File Offset: 0x006375FC
		// (set) Token: 0x06006FD6 RID: 28630 RVA: 0x006394B4 File Offset: 0x006376B4
		public string RadioErgDispAdvanceChannelColorBacklight_43747_UIValue
		{
			get
			{
				short num = (short)718828274;
				short num2 = num;
				num = (short)1237283570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039087104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169489920;
				if (num != 0)
				{
				}
				num = (short)1970864129;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.UIValue;
			}
			set
			{
				short num = (short)1857596838;
				short num2 = num;
				num = (short)872525222;
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
				num = (short)342228993;
				if (num != 0)
				{
				}
				num = (short)342360064;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.UIValue = value;
			}
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x0063956C File Offset: 0x0063776C
		public global::AcpBusinessLayer.AcpListField RadioErgDispAdvanceChannelColorBacklight_43747
		{
			get
			{
				short num = (short)1149548613;
				short num2 = num;
				num = (short)265599045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1311703040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34340865;
				if (num != 0)
				{
				}
				num = (short)275972096;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x06006FD8 RID: 28632 RVA: 0x0063961C File Offset: 0x0063781C
		// (set) Token: 0x06006FD9 RID: 28633 RVA: 0x006396D4 File Offset: 0x006378D4
		public bool RadioErgDispAdvanceChannelColorBacklight_43747_Applicable
		{
			get
			{
				short num = (short)1606148354;
				short num2 = num;
				num = (short)252961026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756613120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1612251137;
				if (num != 0)
				{
				}
				num = (short)1261502464;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.Applicable;
			}
			set
			{
				short num = (short)903487548;
				short num2 = num;
				num = (short)1488265276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852571648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1091633153;
				if (num != 0)
				{
				}
				num = (short)768344064;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.Applicable = value;
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x00639788 File Offset: 0x00637988
		// (set) Token: 0x06006FDB RID: 28635 RVA: 0x0063983C File Offset: 0x00637A3C
		public bool RadioErgDispAdvanceChannelColorBacklight_43747_Valid
		{
			get
			{
				short num = (short)1120663879;
				short num2 = num;
				num = (short)1781856583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)54263808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1905852417;
				if (num != 0)
				{
				}
				num = (short)1853685760;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.Valid;
			}
			set
			{
				short num = (short)1757937665;
				if (num != 0)
				{
				}
				num = (short)1292566528;
				short num2 = num;
				num = (short)99287687;
				short num3 = num;
				num = (short)973210247;
				switch (num3 == num)
				{
				}
				num = (short)1167523840;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.Valid = value;
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x06006FDC RID: 28636 RVA: 0x006398F4 File Offset: 0x00637AF4
		// (set) Token: 0x06006FDD RID: 28637 RVA: 0x006399AC File Offset: 0x00637BAC
		public bool RadioErgDispAdvanceChannelColorBacklight_43747_Visible
		{
			get
			{
				short num = (short)1183691717;
				short num2 = num;
				num = (short)1963897797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480916992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)599719937;
				if (num != 0)
				{
				}
				num = (short)1181941760;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.Visible;
			}
			set
			{
				short num = (short)1774011471;
				short num2 = num;
				num = (short)181879887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050424832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1283260417;
				if (num != 0)
				{
				}
				num = (short)1602617344;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.Visible = value;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x00639A60 File Offset: 0x00637C60
		// (set) Token: 0x06006FDF RID: 28639 RVA: 0x00639B14 File Offset: 0x00637D14
		public bool RadioErgDispAdvanceChannelColorBacklight_43747_Editable
		{
			get
			{
				short num = (short)311755224;
				short num2 = num;
				num = (short)819266008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656750080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177274880;
				if (num != 0)
				{
				}
				num = (short)1707737089;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.Editable;
			}
			set
			{
				short num = (short)1787911092;
				short num2 = num;
				num = (short)1678662580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413283840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)371458049;
				if (num != 0)
				{
				}
				num = (short)404946944;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.Editable = value;
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x00639BC8 File Offset: 0x00637DC8
		internal string RadioErgDispAdvanceChannelColorBacklight_43747_UILabel
		{
			get
			{
				short num = (short)1508253517;
				short num2 = num;
				num = (short)1775574861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2006253568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)62128128;
				if (num != 0)
				{
				}
				num = (short)2136801281;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.UIName;
			}
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x00639C7C File Offset: 0x00637E7C
		// (set) Token: 0x06006FE2 RID: 28642 RVA: 0x00639D34 File Offset: 0x00637F34
		internal bool RadioErgDispAdvanceChannelColorBacklight_43747_HiddenStatic
		{
			get
			{
				short num = (short)243670737;
				short num2 = num;
				num = (short)925376209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790443520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)244514816;
				if (num != 0)
				{
				}
				num = (short)294387713;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.HiddenStatic;
			}
			set
			{
				short num = (short)2022392230;
				short num2 = num;
				num = (short)1555513766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051014656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622540289;
				if (num != 0)
				{
				}
				num = (short)574291968;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.HiddenStatic = value;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x06006FE3 RID: 28643 RVA: 0x00639DE8 File Offset: 0x00637FE8
		// (set) Token: 0x06006FE4 RID: 28644 RVA: 0x00639E9C File Offset: 0x0063809C
		internal bool RadioErgDispAdvanceChannelColorBacklight_43747_HiddenDynamic
		{
			get
			{
				short num = (short)1137344111;
				short num2 = num;
				num = (short)743603823;
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
				num = (short)957743105;
				if (num != 0)
				{
				}
				num = (short)785645568;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747.HiddenDynamic;
			}
			set
			{
				short num = (short)1741881344;
				short num2 = num;
				num = (short)1579335189;
				short num3 = num;
				num = (short)372948501;
				switch (num3 == num)
				{
				}
				num = (short)314441729;
				if (num != 0)
				{
				}
				num = (short)1389363200;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceChannelColorBacklight_43747.HiddenDynamic = value;
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x06006FE5 RID: 28645 RVA: 0x00639F54 File Offset: 0x00638154
		public bool RadioErgDispAdvanceChannelColorBacklight_43747_HasDiffs
		{
			get
			{
				short num = (short)2129920000;
				short num2 = num;
				num = (short)650848174;
				short num3 = num;
				num = (short)1307584430;
				switch (num3 == num)
				{
				}
				num = (short)803733505;
				if (num != 0)
				{
				}
				num = (short)440991744;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceChannelColorBacklight_43747._HasDiffs;
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x06006FE6 RID: 28646 RVA: 0x0063A00C File Offset: 0x0063820C
		// (set) Token: 0x06006FE7 RID: 28647 RVA: 0x0063A0C4 File Offset: 0x006382C4
		public int RadioErgDispAdvanceStatusAutoExit_42158Value
		{
			get
			{
				short num = (short)1931083776;
				short num2 = num;
				num = (short)20229830;
				short num3 = num;
				num = (short)1418178246;
				switch (num3 == num)
				{
				}
				num = (short)1164640257;
				if (num != 0)
				{
				}
				num = (short)1301413888;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.Value;
			}
			set
			{
				short num = (short)1114963968;
				short num2 = num;
				num = (short)1992307693;
				short num3 = num;
				num = (short)1000485869;
				switch (num3 == num)
				{
				}
				num = (short)305463296;
				if (num != 0)
				{
				}
				num = (short)375783425;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.Value = value;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x0063A178 File Offset: 0x00638378
		// (set) Token: 0x06006FE9 RID: 28649 RVA: 0x0063A22C File Offset: 0x0063842C
		public string RadioErgDispAdvanceStatusAutoExit_42158_UIValue
		{
			get
			{
				short num = (short)367984640;
				short num2 = num;
				num = (short)1260012279;
				short num3 = num;
				num = (short)2018329335;
				switch (num3 == num)
				{
				}
				num = (short)317063168;
				if (num != 0)
				{
				}
				num = (short)635764737;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.UIValue;
			}
			set
			{
				short num = (short)783548416;
				short num2 = num;
				num = (short)425650382;
				short num3 = num;
				num = (short)501737678;
				switch (num3 == num)
				{
				}
				num = (short)19398657;
				if (num != 0)
				{
				}
				num = (short)202637312;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.UIValue = value;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x06006FEA RID: 28650 RVA: 0x0063A2E4 File Offset: 0x006384E4
		public global::AcpBusinessLayer.AcpListField RadioErgDispAdvanceStatusAutoExit_42158
		{
			get
			{
				short num = (short)690487296;
				short num2 = num;
				num = (short)1014444888;
				short num3 = num;
				num = (short)785462104;
				switch (num3 == num)
				{
				}
				num = (short)1562509313;
				if (num != 0)
				{
				}
				num = (short)2113208320;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158;
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x06006FEB RID: 28651 RVA: 0x0063A398 File Offset: 0x00638598
		// (set) Token: 0x06006FEC RID: 28652 RVA: 0x0063A44C File Offset: 0x0063864C
		public bool RadioErgDispAdvanceStatusAutoExit_42158_Applicable
		{
			get
			{
				short num = (short)877133824;
				short num2 = num;
				num = (short)241048678;
				short num3 = num;
				num = (short)341646438;
				switch (num3 == num)
				{
				}
				num = (short)1563361281;
				if (num != 0)
				{
				}
				num = (short)1298268160;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.Applicable;
			}
			set
			{
				short num = (short)299433984;
				short num2 = num;
				num = (short)1455226881;
				if (num != 0)
				{
				}
				num = (short)1359598981;
				short num3 = num;
				num = (short)1257624965;
				switch (num3 == num)
				{
				}
				num = (short)1798635520;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.Applicable = value;
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x0063A504 File Offset: 0x00638704
		// (set) Token: 0x06006FEE RID: 28654 RVA: 0x0063A5B8 File Offset: 0x006387B8
		public bool RadioErgDispAdvanceStatusAutoExit_42158_Valid
		{
			get
			{
				short num = (short)843972608;
				short num2 = num;
				num = (short)1423924584;
				short num3 = num;
				num = (short)1118854504;
				switch (num3 == num)
				{
				}
				num = (short)2065104896;
				if (num != 0)
				{
				}
				num = (short)859504641;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.Valid;
			}
			set
			{
				short num = (short)486866944;
				short num2 = num;
				num = (short)1662380010;
				short num3 = num;
				num = (short)1786832874;
				switch (num3 == num)
				{
				}
				num = (short)579207169;
				if (num != 0)
				{
				}
				num = (short)892338176;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.Valid = value;
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x0063A66C File Offset: 0x0063886C
		// (set) Token: 0x06006FF0 RID: 28656 RVA: 0x0063A720 File Offset: 0x00638920
		public bool RadioErgDispAdvanceStatusAutoExit_42158_Visible
		{
			get
			{
				short num = (short)1404895232;
				short num2 = num;
				num = (short)1072388431;
				short num3 = num;
				num = (short)820795727;
				switch (num3 == num)
				{
				}
				num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)565051392;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.Visible;
			}
			set
			{
				short num = (short)1885405184;
				short num2 = num;
				num = (short)666566657;
				if (num != 0)
				{
				}
				num = (short)1547859078;
				short num3 = num;
				num = (short)1240691846;
				switch (num3 == num)
				{
				}
				num = (short)1541144576;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.Visible = value;
			}
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x06006FF1 RID: 28657 RVA: 0x0063A7D4 File Offset: 0x006389D4
		// (set) Token: 0x06006FF2 RID: 28658 RVA: 0x0063A888 File Offset: 0x00638A88
		public bool RadioErgDispAdvanceStatusAutoExit_42158_Editable
		{
			get
			{
				short num = (short)1915879424;
				short num2 = num;
				num = (short)2104950785;
				if (num != 0)
				{
				}
				num = (short)431363763;
				short num3 = num;
				num = (short)114955955;
				switch (num3 == num)
				{
				}
				num = (short)949420032;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.Editable;
			}
			set
			{
				short num = (short)2129133568;
				short num2 = num;
				num = (short)548697298;
				short num3 = num;
				num = (short)705066194;
				switch (num3 == num)
				{
				}
				num = (short)1110638593;
				if (num != 0)
				{
				}
				num = (short)1184694272;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.Editable = value;
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x0063A93C File Offset: 0x00638B3C
		internal string RadioErgDispAdvanceStatusAutoExit_42158_UILabel
		{
			get
			{
				short num = (short)935198720;
				short num2 = num;
				num = (short)1251600003;
				short num3 = num;
				num = (short)320333443;
				switch (num3 == num)
				{
				}
				num = (short)1422721025;
				if (num != 0)
				{
				}
				num = (short)1902247936;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.UIName;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x06006FF4 RID: 28660 RVA: 0x0063A9F0 File Offset: 0x00638BF0
		// (set) Token: 0x06006FF5 RID: 28661 RVA: 0x0063AAA4 File Offset: 0x00638CA4
		internal bool RadioErgDispAdvanceStatusAutoExit_42158_HiddenStatic
		{
			get
			{
				short num = (short)129302528;
				short num2 = num;
				num = (short)176509939;
				short num3 = num;
				num = (short)1384862707;
				switch (num3 == num)
				{
				}
				num = (short)1670971392;
				if (num != 0)
				{
				}
				num = (short)1940324353;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.HiddenStatic;
			}
			set
			{
				short num = (short)1685651456;
				short num2 = num;
				num = (short)1635908729;
				short num3 = num;
				num = (short)394591353;
				switch (num3 == num)
				{
				}
				num = (short)1635975168;
				if (num != 0)
				{
				}
				num = (short)1060896769;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.HiddenStatic = value;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x06006FF6 RID: 28662 RVA: 0x0063AB5C File Offset: 0x00638D5C
		// (set) Token: 0x06006FF7 RID: 28663 RVA: 0x0063AC10 File Offset: 0x00638E10
		internal bool RadioErgDispAdvanceStatusAutoExit_42158_HiddenDynamic
		{
			get
			{
				short num = (short)1964703744;
				short num2 = num;
				num = (short)229150289;
				short num3 = num;
				num = (short)1190956625;
				switch (num3 == num)
				{
				}
				num = (short)1280770049;
				if (num != 0)
				{
				}
				num = (short)2032140288;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158.HiddenDynamic;
			}
			set
			{
				short num = (short)1030946816;
				short num2 = num;
				num = (short)179240961;
				if (num != 0)
				{
				}
				num = (short)1531068302;
				short num3 = num;
				num = (short)2130788238;
				switch (num3 == num)
				{
				}
				num = (short)955514880;
				if (num != 0)
				{
				}
				this.radioErgDispAdvanceStatusAutoExit_42158.HiddenDynamic = value;
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x06006FF8 RID: 28664 RVA: 0x0063ACC4 File Offset: 0x00638EC4
		public bool RadioErgDispAdvanceStatusAutoExit_42158_HasDiffs
		{
			get
			{
				short num = (short)1163853824;
				short num2 = num;
				num = (short)6252973;
				short num3 = num;
				num = (short)1636067757;
				switch (num3 == num)
				{
				}
				num = (short)1333723136;
				if (num != 0)
				{
				}
				num = (short)1425932289;
				if (num != 0)
				{
				}
				return this.radioErgDispAdvanceStatusAutoExit_42158._HasDiffs;
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x0063AD78 File Offset: 0x00638F78
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x0063AE2C File Offset: 0x0063902C
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171Value
		{
			get
			{
				short num = (short)118030336;
				short num2 = num;
				num = (short)1428899396;
				short num3 = num;
				num = (short)2091796036;
				switch (num3 == num)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				num = (short)198049793;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Value;
			}
			set
			{
				short num = (short)604110848;
				short num2 = num;
				num = (short)1366211884;
				short num3 = num;
				num = (short)802274604;
				switch (num3 == num)
				{
				}
				num = (short)533266432;
				if (num != 0)
				{
				}
				num = (short)1945436161;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Value = value;
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x0063AEE4 File Offset: 0x006390E4
		public global::AcpBusinessLayer.AcpField<bool> DisplMenuAdvancedTopLightColorPerChannel_A43171
		{
			get
			{
				short num = (short)592314368;
				short num2 = num;
				num = (short)96013230;
				short num3 = num;
				num = (short)1765346222;
				switch (num3 == num)
				{
				}
				num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)2000420864;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x06006FFC RID: 28668 RVA: 0x0063AF94 File Offset: 0x00639194
		// (set) Token: 0x06006FFD RID: 28669 RVA: 0x0063B04C File Offset: 0x0063924C
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_UIValue
		{
			get
			{
				short num = (short)662765568;
				short num2 = num;
				num = (short)1070945273;
				short num3 = num;
				num = (short)28726265;
				switch (num3 == num)
				{
				}
				num = (short)2063728640;
				if (num != 0)
				{
				}
				num = (short)515964929;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Value;
			}
			set
			{
				short num = (short)1620312064;
				short num2 = num;
				num = (short)339521369;
				short num3 = num;
				num = (short)1857531737;
				switch (num3 == num)
				{
				}
				num = (short)741212160;
				if (num != 0)
				{
				}
				num = (short)172294145;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Value = value;
			}
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x06006FFE RID: 28670 RVA: 0x0063B104 File Offset: 0x00639304
		// (set) Token: 0x06006FFF RID: 28671 RVA: 0x0063B1BC File Offset: 0x006393BC
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_Applicable
		{
			get
			{
				short num = (short)1058734080;
				short num2 = num;
				num = (short)608348702;
				short num3 = num;
				num = (short)668117534;
				switch (num3 == num)
				{
				}
				num = (short)936706049;
				if (num != 0)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Applicable;
			}
			set
			{
				short num = (short)1388904448;
				short num2 = num;
				num = (short)1926488491;
				short num3 = num;
				num = (short)1878974891;
				switch (num3 == num)
				{
				}
				num = (short)644808704;
				if (num != 0)
				{
				}
				num = (short)1848442881;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Applicable = value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x0063B270 File Offset: 0x00639470
		// (set) Token: 0x06007001 RID: 28673 RVA: 0x0063B324 File Offset: 0x00639524
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_Valid
		{
			get
			{
				short num = (short)713359360;
				short num2 = num;
				num = (short)1594123242;
				short num3 = num;
				num = (short)778986474;
				switch (num3 == num)
				{
				}
				num = (short)429654017;
				if (num != 0)
				{
				}
				num = (short)1972568064;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Valid;
			}
			set
			{
				short num = (short)1616969728;
				short num2 = num;
				num = (short)600378203;
				short num3 = num;
				num = (short)1958677339;
				switch (num3 == num)
				{
				}
				num = (short)1684733952;
				if (num != 0)
				{
				}
				num = (short)2047934465;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Valid = value;
			}
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x06007002 RID: 28674 RVA: 0x0063B3D8 File Offset: 0x006395D8
		// (set) Token: 0x06007003 RID: 28675 RVA: 0x0063B48C File Offset: 0x0063968C
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_Visible
		{
			get
			{
				short num = (short)982319104;
				short num2 = num;
				num = (short)819607510;
				short num3 = num;
				num = (short)906639318;
				switch (num3 == num)
				{
				}
				num = (short)1415380992;
				if (num != 0)
				{
				}
				num = (short)2079457281;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Visible;
			}
			set
			{
				short num = (short)916586496;
				short num2 = num;
				num = (short)2069963107;
				short num3 = num;
				num = (short)700391779;
				switch (num3 == num)
				{
				}
				num = (short)2039414784;
				if (num != 0)
				{
				}
				num = (short)312213505;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Visible = value;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x06007004 RID: 28676 RVA: 0x0063B544 File Offset: 0x00639744
		// (set) Token: 0x06007005 RID: 28677 RVA: 0x0063B5F8 File Offset: 0x006397F8
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_Editable
		{
			get
			{
				short num = (short)106102784;
				short num2 = num;
				num = (short)113158566;
				short num3 = num;
				num = (short)1658366374;
				switch (num3 == num)
				{
				}
				num = (short)553123841;
				if (num != 0)
				{
				}
				num = (short)827719680;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.Editable;
			}
			set
			{
				short num = (short)1974861824;
				short num2 = num;
				num = (short)1305718689;
				short num3 = num;
				num = (short)1016573857;
				switch (num3 == num)
				{
				}
				num = (short)2108424193;
				if (num != 0)
				{
				}
				num = (short)738852864;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.Editable = value;
			}
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x0063B6AC File Offset: 0x006398AC
		internal string DisplMenuAdvancedTopLightColorPerChannel_A43171_UILabel
		{
			get
			{
				short num = (short)1354104832;
				short num2 = num;
				num = (short)88749579;
				short num3 = num;
				num = (short)582235659;
				switch (num3 == num)
				{
				}
				num = (short)504954881;
				if (num != 0)
				{
				}
				num = (short)1476919296;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.UIName;
			}
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x06007007 RID: 28679 RVA: 0x0063B760 File Offset: 0x00639960
		// (set) Token: 0x06007008 RID: 28680 RVA: 0x0063B814 File Offset: 0x00639A14
		internal bool DisplMenuAdvancedTopLightColorPerChannel_A43171_HiddenStatic
		{
			get
			{
				short num = (short)1523646464;
				short num2 = num;
				num = (short)1690107905;
				if (num != 0)
				{
				}
				num = (short)676666630;
				short num3 = num;
				num = (short)1382882566;
				switch (num3 == num)
				{
				}
				num = (short)649527296;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.HiddenStatic;
			}
			set
			{
				short num = (short)161504974;
				short num2 = num;
				num = (short)1872060110;
				switch (num2 == num)
				{
				}
				num = (short)1434386432;
				short num3 = num;
				num = (short)1265369088;
				if (num != 0)
				{
				}
				num = (short)72548353;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.HiddenStatic = value;
			}
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x06007009 RID: 28681 RVA: 0x0063B8CC File Offset: 0x00639ACC
		// (set) Token: 0x0600700A RID: 28682 RVA: 0x0063B980 File Offset: 0x00639B80
		internal bool DisplMenuAdvancedTopLightColorPerChannel_A43171_HiddenDynamic
		{
			get
			{
				short num = (short)1574333775;
				short num2 = num;
				num = (short)1426222415;
				switch (num2 == num)
				{
				}
				num = (short)619773952;
				short num3 = num;
				num = (short)202899457;
				if (num != 0)
				{
				}
				num = (short)1864237056;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171.HiddenDynamic;
			}
			set
			{
				short num = (short)70749706;
				short num2 = num;
				num = (short)1859620362;
				switch (num2 == num)
				{
				}
				num = (short)1015414784;
				short num3 = num;
				num = (short)1099235328;
				if (num != 0)
				{
				}
				num = (short)1473773569;
				if (num != 0)
				{
				}
				this.displMenuAdvancedTopLightColorPerChannel_A43171.HiddenDynamic = value;
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600700B RID: 28683 RVA: 0x0063BA34 File Offset: 0x00639C34
		public bool DisplMenuAdvancedTopLightColorPerChannel_A43171_HasDiffs
		{
			get
			{
				short num = (short)108199937;
				if (num != 0)
				{
				}
				num = (short)2084190634;
				short num2 = num;
				num = (short)1662138794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092892160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)347013120;
				if (num != 0)
				{
				}
				return this.displMenuAdvancedTopLightColorPerChannel_A43171._HasDiffs;
			}
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x0063BAE8 File Offset: 0x00639CE8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)973668352;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					return result;
				case 1:
				{
					num = (short)1717387162;
					short num4 = num;
					num = (short)2016362394;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num = (short)886177793;
						if (num != 0)
						{
						}
						num = (short)1403256832;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1840119812;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					num = (short)2023620609;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						goto IL_6F;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)626327552;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_6F:
				num = (short)1013186562;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4D:
			result = null;
			num = (short)326828035;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x04002B37 RID: 11063
		private global::AcpBusinessLayer.AcpField<bool> advancedAutoLight;

		// Token: 0x04002B38 RID: 11064
		private global::AcpBusinessLayer.AcpField<bool> radWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002B39 RID: 11065
		private global::AcpBusinessLayer.AcpCustomRangeField advancedDisplayLightTimeSec_A7875;

		// Token: 0x04002B3A RID: 11066
		private global::AcpBusinessLayer.AcpField<bool> advancedIndependentRotaryLight_A8254;

		// Token: 0x04002B3B RID: 11067
		private global::AcpBusinessLayer.AcpSimpleRangeField dispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002B3C RID: 11068
		private global::AcpBusinessLayer.AcpListField radErgoWideDispMenu_A21430;

		// Token: 0x04002B3D RID: 11069
		private global::AcpBusinessLayer.AcpListField dispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002B3E RID: 11070
		private global::AcpBusinessLayer.AcpRangeField<int, string> dispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002B3F RID: 11071
		private global::AcpBusinessLayer.AcpRangeField<int, string> dispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002B40 RID: 11072
		private global::AcpBusinessLayer.AcpListField radioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002B41 RID: 11073
		private global::AcpBusinessLayer.AcpListField radioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002B42 RID: 11074
		private global::AcpBusinessLayer.AcpField<bool> displMenuAdvancedTopLightColorPerChannel_A43171;
	}
}
