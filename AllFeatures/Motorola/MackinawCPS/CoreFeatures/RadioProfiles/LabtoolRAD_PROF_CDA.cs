using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile;
using Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000214 RID: 532
	[global::System.Serializable]
	public class LabtoolRAD_PROF_CDA : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005F02 RID: 24322 RVA: 0x00554228 File Offset: 0x00552428
		public LabtoolRAD_PROF_CDA(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x00554244 File Offset: 0x00552444
		protected LabtoolRAD_PROF_CDA(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0055425C File Offset: 0x0055245C
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1195114497;
			if (num != 0)
			{
			}
			num = (short)778987585;
			short num2 = num;
			num = (short)562456641;
			switch (num2 == num)
			{
			}
			num = (short)1205731328;
			short num3 = num;
			num = (short)48758784;
			if (num != 0)
			{
			}
			this.radProfLabtoolExternalMicSourceMode_A21548 = new global::AcpBusinessLayer.AcpListField(4, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕铗믙뻛ꫝ迟跡裣ꏥ郧黩觫鳭黯鏱飳믵釷駹꿻釽痿瀁會挅䔇攉栋欍伏匑☓✕ⴗ⸙␛", a_), global::CommonResources.AcgResources.ID_SOURCEMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfLabtoolExternalMicSourceMode_A21548LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolExternalMicSourceMode_A21548LegacyTitles);
			this.radProfLabtoolExternalMicSourceMode_A21548.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfLabtoolExternalMicSourceMode_A21548NewExpanderAndTitles;
			this.radProfLabtoolExternalMicSourceMode_A21548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfLabtoolExternalMicSourceMode_A21548.DataTransferOrder = 56;
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華럱賳苵鷷裹鋻鿽泿企洃攅䰇按縋欍猏昑紓怕焗渙攛匝伟䘡䄣礥椧ᠩᴫᬭЯ଱", a_), global::CommonResources.AcgResources.ID_DIRECTIVITYMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicDirectivityMode_A21549LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicDirectivityMode_A21549LegacyTitles);
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsExternalMicDirectivityMode_A21549NewExpanderAndTitles;
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549.DataTransferOrder = 55;
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華럱賳苵鷷裹鋻鿽泿企洃攅弇按戋樍帏紑紓攕紗䠙礛稝唟䄡倣伥䜧䐩愫䄭启圱欳眵਷ହऻଽ瀿", a_), global::CommonResources.AcgResources.ID_WINDNOISEREDUCTIONMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550LegacyTitles);
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550NewExpanderAndTitles;
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.DataTransferOrder = 54;
			this.radProfAudioSettingsInternalMicSourceMode_A22193 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.indexRadProfAudioSettingsInternalMicSourceMode_A22193LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.idRadProfAudioSettingsInternalMicSourceMode_A22193LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華믱髳苵鷷裹鋻鿽泿企洃攅嬇攉礋簍猏眑夓礕簗缙䌛弝ሟအᔣἥᬧ", a_), global::CommonResources.AcgResources.ID_SOURCEMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicSourceMode_A22193LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicSourceMode_A22193LegacyTitles);
			this.radProfAudioSettingsInternalMicSourceMode_A22193.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsInternalMicSourceMode_A22193NewExpanderAndTitles;
			this.radProfAudioSettingsInternalMicSourceMode_A22193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsInternalMicSourceMode_A22193.DataTransferOrder = 53;
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華믱髳苵鷷裹鋻鿽泿企洃攅䰇按縋欍猏昑紓怕焗渙攛匝伟䘡䄣礥椧ᠩḫἭयܱ", a_), global::CommonResources.AcgResources.ID_DIRECTIVITYMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicDirectivityMode_A22195LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicDirectivityMode_A22195LegacyTitles);
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsInternalMicDirectivityMode_A22195NewExpanderAndTitles;
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195.DataTransferOrder = 52;
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華믱髳苵鷷裹鋻鿽泿企洃攅䜇縉搋欍戏少笓缕欗缙儛焝䐟䜡笣朥ᨧᠩᴫᜭد", a_), global::CommonResources.AcgResources.ID_BACKGROUNDNOISEREDUCTIONMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196LegacyTitles);
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196NewExpanderAndTitles;
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.DataTransferOrder = 51;
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華믱髳苵鷷裹鋻鿽泿企洃攅弇按戋樍帏紑紓攕紗䠙礛稝唟䄡倣伥䜧䐩愫䄭启圱欳眵਷࠹഻ܽ眿", a_), global::CommonResources.AcgResources.ID_WINDNOISEREDUCTIONMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197LegacyTitles);
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197NewExpanderAndTitles;
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.DataTransferOrder = 50;
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕鯗꿙꿛ꫝ迟迡ꗣ鏥賧菩菫꟭黯蛱釳蓵雷鯹郻돽槿愁䨃椅愇礉椋對甏瘑愓甕気猙猛瀝瀟倡䬣䀥䄧䘩䤫洭弯弱䐳夵䬷匹䠻嬽ि㙁⅃⭅Ň้ፋཌྷ扏恑杓杕橗", a_), global::CommonResources.AcgResources.ID_NOISEREDUCTIONPROFILESELECTIONRADIO, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312LegacyTitles);
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312NewExpanderAndTitles;
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.DataTransferOrder = 46;
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕铗믙뻛ꫝ迟跡裣ꗥ鷧駩飫臭鷯돱至鋵釷闹맻蛽瓿企洃攅䘇攉攋納甏䀑焓爕洗礙栛眝伟䰡琣吥䜧䰩䔫䈭唯焱嬳嬵䠷唹伻圽㐿❁ൃ㉅ⵇ❉Ջ੍ཏፑ晓摕歗歙桛", a_), global::CommonResources.AcgResources.ID_NOISEREDUCTIONPROFILESELECTIONACCESSORY, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314LegacyTitles);
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314NewExpanderAndTitles;
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.DataTransferOrder = 48;
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗꿙룛럝迟뇡臣鋥鳧菩苫觭華럱賳苵鷷裹鋻鿽泿企洃攅䜇縉搋欍戏少笓缕欗缙儛焝䐟䜡笣朥ᨧᬩᤫᬭį", a_), global::CommonResources.AcgResources.ID_BACKGROUNDNOISEREDUCTIONMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551LegacyTitles);
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551NewExpanderAndTitles;
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.DataTransferOrder = 49;
			this.radProfLabtoolSecurenetBassControl_A19508 = new global::AcpBusinessLayer.AcpRangeField<int, int>(0, null, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕铗믙뻛ꫝ迟跡裣뗥跧觩駫鳭闯鳱釳苵뫷鯹迻跽䏿洁樃爅稇攉怋儍儏⌑ⴓ⌕⠗∙", a_), global::CommonResources.AcgResources.ID_SECURENETLOWFREQUENCYBANDRADIO, -12, 12, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolSecurenetBassControl_A19508LegacyTitles);
			this.radProfLabtoolSecurenetBassControl_A19508.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfLabtoolSecurenetBassControl_A19508NewExpanderAndTitles;
			this.radProfLabtoolSecurenetBassControl_A19508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfLabtoolSecurenetBassControl_A19508.DataTransferOrder = 72;
			this.radProfLabtoolSecurenetBassControl_A19508.ShowHexValue = false;
			this.radProfLabtoolDigitalBassControl_A19507 = new global::AcpBusinessLayer.AcpRangeField<int, int>(0, null, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕铗믙뻛ꫝ迟跡裣ꋥ臧跩藫髭釯黱뛳韵请觹뿻釽滿瘁瘃椅搇唉䴋㼍⤏✑␓ℕ", a_), global::CommonResources.AcgResources.ID_DIGITALLOWFREQUENCYBANDRADIO, -12, 12, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolDigitalBassControl_A19507LegacyTitles);
			this.radProfLabtoolDigitalBassControl_A19507.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfLabtoolDigitalBassControl_A19507NewExpanderAndTitles;
			this.radProfLabtoolDigitalBassControl_A19507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfLabtoolDigitalBassControl_A19507.DataTransferOrder = 71;
			this.radProfLabtoolDigitalBassControl_A19507.ShowHexValue = false;
			this.radProfLabtoolAnalogBassControl_A19506 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕铗믙뻛ꫝ迟跡裣꟥蛧诩胫臭韯냱闳藵请맹鏻都瓿瀁欃樅圇䬉㴋㜍┏∑∓", a_), global::CommonResources.AcgResources.ID_ANALOGLOWFREQUENCYBANDRADIO, -12, 12, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolAnalogBassControl_A19506LegacyTitles);
			this.radProfLabtoolAnalogBassControl_A19506.NewUiExpanderAndName = global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.NewExpanderAndTitles.RadProfLabtoolAnalogBassControl_A19506NewExpanderAndTitles;
			this.radProfLabtoolAnalogBassControl_A19506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radProfLabtoolAnalogBassControl_A19506.DataTransferOrder = 70;
			this.radProfLabtoolAnalogBassControl_A19506.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觉맋뷍꓏뷑맓诗뿙꣛ꫝ觟賡菣闥", a_);
			base.Id = 10190;
			base.UIName = global::CommonResources.AcgResources.ID_CUSTOMSETTINGS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x005547A8 File Offset: 0x005529A8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)488439808;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_D9;
					}
					continue;
				case 1:
					this.radProfAudioSettingsInternalMicSourceMode_A22193 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.indexRadProfAudioSettingsInternalMicSourceMode_A22193LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.idRadProfAudioSettingsInternalMicSourceMode_A22193LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆娈搊砌紎爐瘒堔砖紘縚䈜帞ጠᄢᐤḦᨨ", a_), global::CommonResources.AcgResources.ID_SOURCEMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicSourceMode_A22193LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicSourceMode_A22193LegacyTitles);
					this.radProfAudioSettingsInternalMicSourceMode_A22193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsInternalMicSourceMode_A22193.DataTransferOrder = 53;
					num = (short)400490508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆师戊挌欎弐簒簔搖簘䤚砜笞吠䀢儤並䘨䔪怬䀮唰嘲樴瘶ସ਺࠼ਾ煀", a_)))
					{
						num = (short)716242985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_622;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆䴈戊缌樎爐朒簔愖瀘漚搜刞丠䜢䀤砦栨ᤪἬḮ࠰ز", a_)))
					{
						num = (short)490143755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7AE;
				case 4:
					this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆䘈缊攌樎挐崒稔縖樘縚倜瀞䔠䘢稤昦ᬨᤪᰬᘮܰ", a_), global::CommonResources.AcgResources.ID_BACKGROUNDNOISEREDUCTIONMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicOtherNoiseMode_A22196LegacyTitles);
					this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.DataTransferOrder = 51;
					num = (short)1403125788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_A6F;
				case 6:
					goto IL_1BE;
				case 7:
					goto IL_271;
				case 8:
					num = (short)1074266113;
					if (num != 0)
					{
					}
					goto IL_6DA;
				case 9:
					this.radProfLabtoolDigitalBassControl_A19507 = new global::AcpBusinessLayer.AcpRangeField<int, int>(0, null, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꏦ胨質蓬鯮郰鿲럴零諸裺뻼郾漀眂眄栆攈吊䰌㸎⠐☒└‖", a_), global::CommonResources.AcgResources.ID_DIGITALLOWFREQUENCYBANDRADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolDigitalBassControl_A19507LegacyTitles);
					this.radProfLabtoolDigitalBassControl_A19507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfLabtoolDigitalBassControl_A19507.DataTransferOrder = 71;
					this.radProfLabtoolDigitalBassControl_A19507.ShowHexValue = false;
					num = (short)902037541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radProfAudioSettingsExternalMicDirectivityMode_A21549 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆䴈戊缌樎爐朒簔愖瀘漚搜刞丠䜢䀤砦栨ᤪᰬᨮ԰ਲ", a_), global::CommonResources.AcgResources.ID_DIRECTIVITYMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicDirectivityMode_A21549LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicDirectivityMode_A21549LegacyTitles);
					this.radProfAudioSettingsExternalMicDirectivityMode_A21549.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsExternalMicDirectivityMode_A21549.DataTransferOrder = 55;
					num = (short)1981546502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.radProfAudioSettingsInternalMicDirectivityMode_A22195 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆䴈戊缌樎爐朒簔愖瀘漚搜刞丠䜢䀤砦栨ᤪἬḮ࠰ز", a_), global::CommonResources.AcgResources.ID_DIRECTIVITYMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicDirectivityMode_A22195LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicDirectivityMode_A22195LegacyTitles);
					this.radProfAudioSettingsInternalMicDirectivityMode_A22195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsInternalMicDirectivityMode_A22195.DataTransferOrder = 52;
					num = (short)411238427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_914;
				case 13:
					num = (short)1425276954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆䘈缊攌樎挐崒稔縖樘縚倜瀞䔠䘢稤昦ᬨᨪᠬᨮ0", a_)))
					{
						num = (short)685244445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DA;
				case 15:
					this.radProfLabtoolExternalMicSourceMode_A21548 = new global::AcpBusinessLayer.AcpListField(4, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꋦ釨鿪裬鷮鿰鋲駴뫶郸飺껼郾琀焂昄戆䐈搊椌樎丐划✔☖Ⱈ⼚├", a_), global::CommonResources.AcgResources.ID_SOURCEMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfLabtoolExternalMicSourceMode_A21548LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolExternalMicSourceMode_A21548LegacyTitles);
					this.radProfLabtoolExternalMicSourceMode_A21548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfLabtoolExternalMicSourceMode_A21548.DataTransferOrder = 56;
					num = (short)829489159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					num = (short)182648832;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖高껚껜ꯞ軠転ꓤ鋦跨苪苬ꛮ鿰蟲郴藶韸髺釼닾栀怂䬄栆怈砊栌崎琐眒怔琖洘爚爜焞焠儢䨤䄦䀨䜪䠬氮帰帲䔴堶䨸刺䤼娾ࡀ㝂⁄⩆Hཊቌ๎捐慒晔晖歘", a_)))
					{
						num = (short)737411114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6F;
				}
				case 17:
					goto IL_46D;
				case 18:
					this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꓦ鳨飪駬胮鳰닲胴鏶郸铺룼蟾甀丂氄搆䜈搊搌簎琐䄒瀔猖氘砚検瘞丠䴢甤唦䘨䴪䐬䌮吰瀲娴娶䤸吺丼嘾㕀♂ౄ㍆ⱈ♊ь୎๐ቒ杔敖橘橚楜", a_), global::CommonResources.AcgResources.ID_NOISEREDUCTIONPROFILESELECTIONACCESSORY, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314LegacyTitles);
					this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.DataTransferOrder = 48;
					num = (short)1276313620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.radProfLabtoolAnalogBassControl_A19506 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꛦ蟨諪臬胮雰뇲铴蓶諸룺鋼釾甀焂樄欆嘈䨊㰌㘎␐⌒⌔", a_), global::CommonResources.AcgResources.ID_ANALOGLOWFREQUENCYBANDRADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolAnalogBassControl_A19506LegacyTitles);
					this.radProfLabtoolAnalogBassControl_A19506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfLabtoolAnalogBassControl_A19506.DataTransferOrder = 70;
					this.radProfLabtoolAnalogBassControl_A19506.ShowHexValue = false;
					num = (short)329515044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_2BE;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆䘈缊攌樎挐崒稔縖樘縚倜瀞䔠䘢稤昦ᬨᤪᰬᘮܰ", a_)))
					{
						num = (short)218824708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_372;
				case 22:
					num = (short)1162084382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_622;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꛦ蟨諪臬胮雰뇲铴蓶諸룺鋼釾甀焂樄欆嘈䨊㰌㘎␐⌒⌔", a_)))
					{
						num = (short)1748959251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ABC;
				case 25:
					goto IL_9FB;
				case 26:
					if (producerFields != null)
					{
						num = (short)1552482326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ABC;
				case 27:
					goto IL_7AE;
				case 28:
					goto IL_372;
				case 29:
					this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆䘈缊攌樎挐崒稔縖樘縚倜瀞䔠䘢稤昦ᬨᨪᠬᨮ0", a_), global::CommonResources.AcgResources.ID_BACKGROUNDNOISEREDUCTIONMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicOtherNoiseMode_A21551LegacyTitles);
					this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.DataTransferOrder = 49;
					goto IL_769;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꋦ釨鿪裬鷮鿰鋲駴뫶郸飺껼郾琀焂昄戆䐈搊椌樎丐划✔☖Ⱈ⼚├", a_)))
					{
						num = (short)1701642255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_271;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꓦ鳨飪駬胮鳰닲胴鏶郸铺룼蟾甀丂氄搆䜈搊搌簎琐䄒瀔猖氘砚検瘞丠䴢甤唦䘨䴪䐬䌮吰瀲娴娶䤸吺丼嘾㕀♂ౄ㍆ⱈ♊ь୎๐ቒ杔敖橘橚楜", a_)))
					{
						num = (short)610336786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BE;
				case 32:
				{
					num = (short)1681778849;
					short num4 = num;
					num = (short)1026091169;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_769;
					default:
						num = (short)1280573440;
						if (num != 0)
						{
						}
						this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆师戊挌欎弐簒簔搖簘䤚砜笞吠䀢儤並䘨䔪怬䀮唰嘲樴瘶ସऺ఼ؾ癀", a_), global::CommonResources.AcgResources.ID_WINDNOISEREDUCTIONMODERADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197LegacyTitles);
						this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.DataTransferOrder = 50;
						num = (short)1267925017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆师戊挌欎弐簒簔搖簘䤚砜笞吠䀢儤並䘨䔪怬䀮唰嘲樴瘶ସऺ఼ؾ癀", a_)))
					{
						num = (short)1944125472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9FB;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뫲鯴菶鳸觺鏼黾洀丂氄搆娈搊砌紎爐瘒堔砖紘縚䈜帞ጠᄢᐤḦᨨ", a_)))
					{
						num = (short)2139291649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_914;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤듦賨裪飬鷮铰鷲郴菶미髺軼賾䈀氂欄猆笈搊愌倎倐−Ⱄ∖⤘⌚", a_)))
					{
						num = (short)1393819687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46D;
				case 36:
					goto IL_524;
				case 37:
					goto IL_960;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆䴈戊缌樎爐朒簔愖瀘漚搜刞丠䜢䀤砦栨ᤪᰬᨮ԰ਲ", a_)))
					{
						num = (short)1331101706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 39:
					this.radProfLabtoolSecurenetBassControl_A19508 = new global::AcpBusinessLayer.AcpRangeField<int, int>(0, null, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤듦賨裪飬鷮铰鷲郴菶미髺軼賾䈀氂欄猆笈搊愌倎倐−Ⱄ∖⤘⌚", a_), global::CommonResources.AcgResources.ID_SECURENETLOWFREQUENCYBANDRADIO, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfLabtoolSecurenetBassControl_A19508LegacyTitles);
					this.radProfLabtoolSecurenetBassControl_A19508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfLabtoolSecurenetBassControl_A19508.DataTransferOrder = 72;
					this.radProfLabtoolSecurenetBassControl_A19508.ShowHexValue = false;
					num = (short)425000977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖闘뫚뿜ꯞ軠賢觤ꏦ胨質蓬鯮郰鿲럴零諸裺뻼郾漀眂眄栆攈吊䰌㸎⠐☒└‖", a_)))
					{
						num = (short)2083782665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_960;
				case 41:
					this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖飘껚맜뛞軠냢胤鏦鷨苪菬裮苰뛲跴菶鳸觺鏼黾洀丂氄搆师戊挌欎弐簒簔搖簘䤚砜笞吠䀢儤並䘨䔪怬䀮唰嘲樴瘶ସ਺࠼ਾ煀", a_), global::CommonResources.AcgResources.ID_WINDNOISEREDUCTIONMODEACCESSORY, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550LegacyTitles);
					this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.DataTransferOrder = 54;
					num = (short)1169948695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ臐ꇒ뫔뇖高껚껜ꯞ軠転ꓤ鋦跨苪苬ꛮ鿰蟲郴藶韸髺釼닾栀怂䬄栆怈砊栌崎琐眒怔琖洘爚爜焞焠儢䨤䄦䀨䜪䠬氮帰帲䔴堶䨸刺䤼娾ࡀ㝂⁄⩆Hཊቌ๎捐慒晔晖歘", a_), global::CommonResources.AcgResources.ID_NOISEREDUCTIONPROFILESELECTIONRADIO, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LegacyTitles.RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312LegacyTitles);
					this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.DataTransferOrder = 46;
					num = (short)1851850757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1178402829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1BE:
				num = (short)1536819202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_271:
				num = (short)131110;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BE:
				num = (short)1593507854;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_372:
				num = (short)83361825;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46D:
				num = (short)800129064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_622:
				num = (short)2062876706;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6DA:
				num = (short)1445396515;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_769:
				num = (short)1387528200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7AE:
				num = (short)1817509909;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_914:
				num = (short)500432899;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_960:
				num = (short)149815320;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9FB:
				num = (short)71303184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6F:
				num = (short)1927610399;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_524:
			IL_ABC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裊료볎ꗐ볒룔諘뻚꧜ꯞ裠跢苤铦", a_);
			base.Id = 10190;
			base.UIName = global::CommonResources.AcgResources.ID_CUSTOMSETTINGS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x005552A4 File Offset: 0x005534A4
		public override void PopulateReferences()
		{
			short num = (short)212357913;
			short num2 = num;
			num = (short)236540697;
			switch (num2 == num)
			{
			}
			num = (short)416546816;
			short num3 = num;
			num = (short)1187577857;
			if (num != 0)
			{
			}
			num = (short)839122944;
			if (num != 0)
			{
			}
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.SetRecset(this.a(2086));
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.SetRecset(this.a(2087));
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x0055537C File Offset: 0x0055357C
		public override void DropReferences()
		{
			short num = (short)1139299998;
			short num2 = num;
			num = (short)2015319710;
			switch (num2 == num)
			{
			}
			num = (short)1205796864;
			short num3 = num;
			num = (short)1043398657;
			if (num != 0)
			{
			}
			num = (short)40632320;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x00555428 File Offset: 0x00553628
		public override void SetConstraints()
		{
			short num = (short)721185399;
			short num2 = num;
			num = (short)1687251575;
			switch (num2 == num)
			{
			}
			num = (short)1937965056;
			short num3 = num;
			num = (short)705232896;
			if (num != 0)
			{
			}
			num = (short)1621032961;
			if (num != 0)
			{
			}
			this.radProfLabtoolExternalMicSourceMode_A21548.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionAccessoryApplicability);
			this.radProfLabtoolExternalMicSourceMode_A21548.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionAccessoryGroupFieldsEditability);
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionAccessoryApplicability);
			this.radProfAudioSettingsExternalMicDirectivityMode_A21549.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionAccessoryGroupFieldsEditability);
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionAccessoryApplicability);
			this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionAccessoryGroupFieldsEditability);
			this.radProfAudioSettingsInternalMicSourceMode_A22193.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionRadioApplicability);
			this.radProfAudioSettingsInternalMicSourceMode_A22193.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionRadioGroupFieldsEditability);
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionRadioApplicability);
			this.radProfAudioSettingsInternalMicDirectivityMode_A22195.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionRadioGroupFieldsEditability);
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionRadioApplicability);
			this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionRadioGroupFieldsEditability);
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionRadioApplicability);
			this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionRadioGroupFieldsEditability);
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionRadioApplicability);
			this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionRadioGroupFieldsEditability);
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionAccessoryApplicability);
			this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionAccessoryGroupFieldsEditability);
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conCustomNoiseReductionProfileSelectionAccessoryApplicability);
			this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conNoiseReductionAccessoryGroupFieldsEditability);
			this.radProfLabtoolSecurenetBassControl_A19508.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conIsAudioConfigurationLevelEnhanced);
			this.radProfLabtoolSecurenetBassControl_A19508.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conSpeakerRXSettingsAudioEqualizationGroupSettingRadioFieldsEditability);
			this.radProfLabtoolDigitalBassControl_A19507.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conIsAudioConfigurationLevelEnhanced);
			this.radProfLabtoolDigitalBassControl_A19507.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conSpeakerRXSettingsAudioEqualizationGroupSettingRadioFieldsEditability);
			this.radProfLabtoolAnalogBassControl_A19506.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conIsAudioConfigurationLevelEnhanced);
			this.radProfLabtoolAnalogBassControl_A19506.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conSpeakerRXSettingsAudioEqualizationGroupSettingRadioFieldsEditability);
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x0055572C File Offset: 0x0055392C
		public override void SetupDependencies()
		{
			short num = (short)561421738;
			short num2 = num;
			num = (short)1783864746;
			switch (num2 == num)
			{
			}
			num = (short)1239810048;
			short num3 = num;
			num = (short)736231424;
			if (num != 0)
			{
			}
			num = (short)1079181313;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfLabtoolExternalMicSourceMode_A21548);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsExternalMicDirectivityMode_A21549);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsInternalMicSourceMode_A22193);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsInternalMicDirectivityMode_A22195);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314);
			radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.AddDependentObject(this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551);
			this.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.AddDependentObject(this.radProfLabtoolSecurenetBassControl_A19508);
			this.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.AddDependentObject(this.radProfLabtoolDigitalBassControl_A19507);
			this.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.AddDependentObject(this.radProfLabtoolAnalogBassControl_A19506);
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x00555918 File Offset: 0x00553B18
		public global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile InternalMicNoiseReductionProfileForRadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312
		{
			get
			{
				short num = (short)737682297;
				short num2 = num;
				num = (short)1894196089;
				switch (num2 == num)
				{
				}
				num = (short)107544576;
				short num3 = num;
				num = (short)1481244673;
				if (num != 0)
				{
				}
				num = (short)648019968;
				if (num != 0)
				{
				}
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile;
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x005559D4 File Offset: 0x00553BD4
		public global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile ExternalMicNoiseReductionProfileForRadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314
		{
			get
			{
				short num = (short)998081564;
				short num2 = num;
				num = (short)1077249052;
				switch (num2 == num)
				{
				}
				num = (short)288882688;
				short num3 = num;
				num = (short)1538916352;
				if (num != 0)
				{
				}
				num = (short)704839681;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile;
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06005F0C RID: 24332 RVA: 0x00555A90 File Offset: 0x00553C90
		public bool HasDiffs
		{
			get
			{
				short num = (short)1693136211;
				short num2 = num;
				num = (short)2060596563;
				switch (num2 == num)
				{
				}
				num = (short)1597964288;
				short num3 = num;
				num = (short)1414922241;
				if (num != 0)
				{
				}
				num = (short)1210908672;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x00555B44 File Offset: 0x00553D44
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x00555BF8 File Offset: 0x00553DF8
		public int RadProfLabtoolExternalMicSourceMode_A21548Value
		{
			get
			{
				short num = (short)1479606273;
				if (num != 0)
				{
				}
				num = (short)1352285978;
				short num2 = num;
				num = (short)630865690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531510784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1508900864;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.Value;
			}
			set
			{
				short num = (short)520785241;
				short num2 = num;
				num = (short)2079952217;
				switch (num2 == num)
				{
				}
				num = (short)651952128;
				short num3 = num;
				num = (short)718209025;
				if (num != 0)
				{
				}
				num = (short)2140209152;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.Value = value;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x00555CAC File Offset: 0x00553EAC
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x00555D60 File Offset: 0x00553F60
		public string RadProfLabtoolExternalMicSourceMode_A21548_UIValue
		{
			get
			{
				short num = (short)1103411532;
				short num2 = num;
				num = (short)1101969740;
				switch (num2 == num)
				{
				}
				num = (short)1096810496;
				short num3 = num;
				num = (short)1623588864;
				if (num != 0)
				{
				}
				num = (short)613089281;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.UIValue;
			}
			set
			{
				short num = (short)2073436;
				short num2 = num;
				num = (short)1047634780;
				switch (num2 == num)
				{
				}
				num = (short)448593920;
				short num3 = num;
				num = (short)1817313280;
				if (num != 0)
				{
				}
				num = (short)1114701825;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.UIValue = value;
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x00555E18 File Offset: 0x00554018
		public global::AcpBusinessLayer.AcpListField RadProfLabtoolExternalMicSourceMode_A21548
		{
			get
			{
				short num = (short)637724934;
				short num2 = num;
				num = (short)1680468230;
				switch (num2 == num)
				{
				}
				num = (short)2028208128;
				short num3 = num;
				num = (short)923402241;
				if (num != 0)
				{
				}
				num = (short)1315373056;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548;
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06005F12 RID: 24338 RVA: 0x00555EC8 File Offset: 0x005540C8
		// (set) Token: 0x06005F13 RID: 24339 RVA: 0x00555F80 File Offset: 0x00554180
		public bool RadProfLabtoolExternalMicSourceMode_A21548_Applicable
		{
			get
			{
				short num = (short)946253713;
				short num2 = num;
				num = (short)384479121;
				switch (num2 == num)
				{
				}
				num = (short)1695940608;
				short num3 = num;
				num = (short)696713217;
				if (num != 0)
				{
				}
				num = (short)1819213824;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.Applicable;
			}
			set
			{
				short num = (short)757033326;
				short num2 = num;
				num = (short)2104715630;
				switch (num2 == num)
				{
				}
				num = (short)1760362496;
				short num3 = num;
				num = (short)1958150145;
				if (num != 0)
				{
				}
				num = (short)1153368064;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.Applicable = value;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x00556034 File Offset: 0x00554234
		// (set) Token: 0x06005F15 RID: 24341 RVA: 0x005560E8 File Offset: 0x005542E8
		public bool RadProfLabtoolExternalMicSourceMode_A21548_Valid
		{
			get
			{
				short num = (short)1773666305;
				if (num != 0)
				{
				}
				num = (short)2027048598;
				short num2 = num;
				num = (short)806833814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171769856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450166784;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.Valid;
			}
			set
			{
				short num = (short)1795143314;
				short num2 = num;
				num = (short)520074898;
				switch (num2 == num)
				{
				}
				num = (short)662503424;
				short num3 = num;
				num = (short)1713438720;
				if (num != 0)
				{
				}
				num = (short)949944321;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.Valid = value;
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x005561A0 File Offset: 0x005543A0
		// (set) Token: 0x06005F17 RID: 24343 RVA: 0x00556258 File Offset: 0x00554458
		public bool RadProfLabtoolExternalMicSourceMode_A21548_Visible
		{
			get
			{
				short num = (short)1318497847;
				short num2 = num;
				num = (short)971157047;
				switch (num2 == num)
				{
				}
				num = (short)1027604480;
				short num3 = num;
				num = (short)136839169;
				if (num != 0)
				{
				}
				num = (short)888471552;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.Visible;
			}
			set
			{
				short num = (short)127698315;
				short num2 = num;
				num = (short)1472300427;
				switch (num2 == num)
				{
				}
				num = (short)1618345984;
				short num3 = num;
				num = (short)1419706369;
				if (num != 0)
				{
				}
				num = (short)869335040;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.Visible = value;
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x00556310 File Offset: 0x00554510
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x005563C4 File Offset: 0x005545C4
		public bool RadProfLabtoolExternalMicSourceMode_A21548_Editable
		{
			get
			{
				short num = (short)1334475044;
				short num2 = num;
				num = (short)787708196;
				switch (num2 == num)
				{
				}
				num = (short)2079260672;
				short num3 = num;
				num = (short)652214272;
				if (num != 0)
				{
				}
				num = (short)1683488769;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.Editable;
			}
			set
			{
				short num = (short)1555991949;
				short num2 = num;
				num = (short)721325453;
				switch (num2 == num)
				{
				}
				num = (short)1821114368;
				short num3 = num;
				num = (short)124977152;
				if (num != 0)
				{
				}
				num = (short)1899757569;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.Editable = value;
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x0055647C File Offset: 0x0055467C
		internal string RadProfLabtoolExternalMicSourceMode_A21548_UILabel
		{
			get
			{
				short num = (short)1501085316;
				short num2 = num;
				num = (short)99532420;
				switch (num2 == num)
				{
				}
				num = (short)796262400;
				short num3 = num;
				num = (short)903086080;
				if (num != 0)
				{
				}
				num = (short)969342977;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.UIName;
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x00556530 File Offset: 0x00554730
		// (set) Token: 0x06005F1C RID: 24348 RVA: 0x005565E4 File Offset: 0x005547E4
		internal bool RadProfLabtoolExternalMicSourceMode_A21548_HiddenStatic
		{
			get
			{
				short num = (short)1679692370;
				short num2 = num;
				num = (short)99291730;
				switch (num2 == num)
				{
				}
				num = (short)506920960;
				short num3 = num;
				num = (short)273809409;
				if (num != 0)
				{
				}
				num = (short)2094989312;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.HiddenStatic;
			}
			set
			{
				short num = (short)2124480513;
				if (num != 0)
				{
				}
				num = (short)2135682919;
				short num2 = num;
				num = (short)1936322407;
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
				num = (short)254148608;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.HiddenStatic = value;
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x00556698 File Offset: 0x00554898
		// (set) Token: 0x06005F1E RID: 24350 RVA: 0x0055674C File Offset: 0x0055494C
		internal bool RadProfLabtoolExternalMicSourceMode_A21548_HiddenDynamic
		{
			get
			{
				short num = (short)1526656447;
				short num2 = num;
				num = (short)204008895;
				switch (num2 == num)
				{
				}
				num = (short)829816832;
				short num3 = num;
				num = (short)1592459265;
				if (num != 0)
				{
				}
				num = (short)2003173376;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548.HiddenDynamic;
			}
			set
			{
				short num = (short)1340838911;
				short num2 = num;
				num = (short)2114425855;
				switch (num2 == num)
				{
				}
				num = (short)1437597696;
				short num3 = num;
				num = (short)2029912065;
				if (num != 0)
				{
				}
				num = (short)660144128;
				if (num != 0)
				{
				}
				this.radProfLabtoolExternalMicSourceMode_A21548.HiddenDynamic = value;
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x00556804 File Offset: 0x00554A04
		public bool RadProfLabtoolExternalMicSourceMode_A21548_HasDiffs
		{
			get
			{
				short num = (short)763756545;
				if (num != 0)
				{
				}
				num = (short)734133859;
				short num2 = num;
				num = (short)417594979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320536576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1922039808;
				if (num != 0)
				{
				}
				return this.radProfLabtoolExternalMicSourceMode_A21548._HasDiffs;
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x005568B8 File Offset: 0x00554AB8
		// (set) Token: 0x06005F21 RID: 24353 RVA: 0x00556970 File Offset: 0x00554B70
		public int RadProfAudioSettingsExternalMicDirectivityMode_A21549Value
		{
			get
			{
				short num = (short)1802377983;
				short num2 = num;
				num = (short)1779112703;
				switch (num2 == num)
				{
				}
				num = (short)1214119936;
				short num3 = num;
				num = (short)1932918785;
				if (num != 0)
				{
				}
				num = (short)524746752;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Value;
			}
			set
			{
				short num = (short)844869371;
				short num2 = num;
				num = (short)1763946235;
				switch (num2 == num)
				{
				}
				num = (short)1474691072;
				short num3 = num;
				num = (short)584646657;
				if (num != 0)
				{
				}
				num = (short)1347289088;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Value = value;
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x00556A24 File Offset: 0x00554C24
		// (set) Token: 0x06005F23 RID: 24355 RVA: 0x00556AD8 File Offset: 0x00554CD8
		public string RadProfAudioSettingsExternalMicDirectivityMode_A21549_UIValue
		{
			get
			{
				short num = (short)500121778;
				short num2 = num;
				num = (short)1589854386;
				switch (num2 == num)
				{
				}
				num = (short)1502543872;
				short num3 = num;
				num = (short)797442049;
				if (num != 0)
				{
				}
				num = (short)1349255168;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.UIValue;
			}
			set
			{
				short num = (short)613429874;
				short num2 = num;
				num = (short)730083954;
				switch (num2 == num)
				{
				}
				num = (short)1025900544;
				short num3 = num;
				num = (short)1709441025;
				if (num != 0)
				{
				}
				num = (short)803733504;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.UIValue = value;
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x06005F24 RID: 24356 RVA: 0x00556B90 File Offset: 0x00554D90
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsExternalMicDirectivityMode_A21549
		{
			get
			{
				short num = (short)474639396;
				short num2 = num;
				num = (short)1894280228;
				switch (num2 == num)
				{
				}
				num = (short)904921088;
				short num3 = num;
				num = (short)904658945;
				if (num != 0)
				{
				}
				num = (short)492109824;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549;
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x00556C40 File Offset: 0x00554E40
		// (set) Token: 0x06005F26 RID: 24358 RVA: 0x00556CF4 File Offset: 0x00554EF4
		public bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_Applicable
		{
			get
			{
				short num = (short)1091074433;
				short num2 = num;
				num = (short)577730945;
				switch (num2 == num)
				{
				}
				num = (short)1039466496;
				short num3 = num;
				num = (short)1990393856;
				if (num != 0)
				{
				}
				num = (short)450691073;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Applicable;
			}
			set
			{
				short num = (short)629121051;
				short num2 = num;
				num = (short)289906715;
				switch (num2 == num)
				{
				}
				num = (short)1930297344;
				short num3 = num;
				num = (short)735969280;
				if (num != 0)
				{
				}
				num = (short)1692794881;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Applicable = value;
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x00556DAC File Offset: 0x00554FAC
		// (set) Token: 0x06005F28 RID: 24360 RVA: 0x00556E60 File Offset: 0x00555060
		public bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_Valid
		{
			get
			{
				short num = (short)1574338307;
				short num2 = num;
				num = (short)704413443;
				switch (num2 == num)
				{
				}
				num = (short)209387520;
				short num3 = num;
				num = (short)1277820929;
				if (num != 0)
				{
				}
				num = (short)1858863104;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Valid;
			}
			set
			{
				short num = (short)662068573;
				short num2 = num;
				num = (short)1690197341;
				switch (num2 == num)
				{
				}
				num = (short)1484324864;
				short num3 = num;
				num = (short)597032961;
				if (num != 0)
				{
				}
				num = (short)1529348096;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Valid = value;
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x00556F14 File Offset: 0x00555114
		// (set) Token: 0x06005F2A RID: 24362 RVA: 0x00556FC8 File Offset: 0x005551C8
		public bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_Visible
		{
			get
			{
				short num = (short)455312421;
				short num2 = num;
				num = (short)1351844901;
				switch (num2 == num)
				{
				}
				num = (short)1995309056;
				short num3 = num;
				num = (short)284360705;
				if (num != 0)
				{
				}
				num = (short)258277376;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Visible;
			}
			set
			{
				short num = (short)105946083;
				short num2 = num;
				num = (short)1977457635;
				switch (num2 == num)
				{
				}
				num = (short)922025984;
				short num3 = num;
				num = (short)602210304;
				if (num != 0)
				{
				}
				num = (short)41025537;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Visible = value;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x00557080 File Offset: 0x00555280
		// (set) Token: 0x06005F2C RID: 24364 RVA: 0x00557134 File Offset: 0x00555334
		public bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_Editable
		{
			get
			{
				short num = (short)1410859009;
				if (num != 0)
				{
				}
				num = (short)1247639109;
				short num2 = num;
				num = (short)1805153861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1120862208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1825570816;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Editable;
			}
			set
			{
				short num = (short)2005075112;
				short num2 = num;
				num = (short)688391336;
				switch (num2 == num)
				{
				}
				num = (short)1577058304;
				short num3 = num;
				num = (short)37027841;
				if (num != 0)
				{
				}
				num = (short)799866880;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.Editable = value;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x06005F2D RID: 24365 RVA: 0x005571E8 File Offset: 0x005553E8
		internal string RadProfAudioSettingsExternalMicDirectivityMode_A21549_UILabel
		{
			get
			{
				short num = (short)943165329;
				short num2 = num;
				num = (short)1689554833;
				switch (num2 == num)
				{
				}
				num = (short)929824768;
				short num3 = num;
				num = (short)1001521153;
				if (num != 0)
				{
				}
				num = (short)1379270656;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.UIName;
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x06005F2E RID: 24366 RVA: 0x0055729C File Offset: 0x0055549C
		// (set) Token: 0x06005F2F RID: 24367 RVA: 0x00557354 File Offset: 0x00555554
		internal bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_HiddenStatic
		{
			get
			{
				short num = (short)1859208946;
				short num2 = num;
				num = (short)597313266;
				switch (num2 == num)
				{
				}
				num = (short)2016804864;
				short num3 = num;
				num = (short)390004736;
				if (num != 0)
				{
				}
				num = (short)2127233025;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.HiddenStatic;
			}
			set
			{
				short num = (short)1534984193;
				if (num != 0)
				{
				}
				num = (short)761195273;
				short num2 = num;
				num = (short)220261129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)105840640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775749632;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.HiddenStatic = value;
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x0055740C File Offset: 0x0055560C
		// (set) Token: 0x06005F31 RID: 24369 RVA: 0x005574BC File Offset: 0x005556BC
		internal bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_HiddenDynamic
		{
			get
			{
				short num = (short)1985478657;
				if (num != 0)
				{
				}
				num = (short)956991208;
				short num2 = num;
				num = (short)590448360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)969801728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267517952;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549.HiddenDynamic;
			}
			set
			{
				short num = (short)804323329;
				if (num != 0)
				{
				}
				num = (short)1438040740;
				short num2 = num;
				num = (short)1162396324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1310130176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1527185408;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicDirectivityMode_A21549.HiddenDynamic = value;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x06005F32 RID: 24370 RVA: 0x00557570 File Offset: 0x00555770
		public bool RadProfAudioSettingsExternalMicDirectivityMode_A21549_HasDiffs
		{
			get
			{
				short num = (short)1905786881;
				if (num != 0)
				{
				}
				num = (short)1368029749;
				short num2 = num;
				num = (short)852523573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194379776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082458112;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicDirectivityMode_A21549._HasDiffs;
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x06005F33 RID: 24371 RVA: 0x00557628 File Offset: 0x00555828
		// (set) Token: 0x06005F34 RID: 24372 RVA: 0x005576DC File Offset: 0x005558DC
		public int RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550Value
		{
			get
			{
				short num = (short)1640573036;
				short num2 = num;
				num = (short)1651845228;
				switch (num2 == num)
				{
				}
				num = (short)582877184;
				short num3 = num;
				num = (short)968753153;
				if (num != 0)
				{
				}
				num = (short)981467136;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Value;
			}
			set
			{
				short num = (short)1950465710;
				short num2 = num;
				num = (short)1656274606;
				switch (num2 == num)
				{
				}
				num = (short)1582497792;
				short num3 = num;
				num = (short)946667521;
				if (num != 0)
				{
				}
				num = (short)240975872;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Value = value;
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x00557790 File Offset: 0x00555990
		// (set) Token: 0x06005F36 RID: 24374 RVA: 0x00557844 File Offset: 0x00555A44
		public string RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_UIValue
		{
			get
			{
				short num = (short)367525889;
				if (num != 0)
				{
				}
				num = (short)1614719474;
				short num2 = num;
				num = (short)770877938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2084044800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337458688;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.UIValue;
			}
			set
			{
				short num = (short)1172957467;
				short num2 = num;
				num = (short)15788315;
				switch (num2 == num)
				{
				}
				num = (short)521863168;
				short num3 = num;
				num = (short)1014890497;
				if (num != 0)
				{
				}
				num = (short)2133786624;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.UIValue = value;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x005578F8 File Offset: 0x00555AF8
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550
		{
			get
			{
				short num = (short)2124283905;
				if (num != 0)
				{
				}
				num = (short)716406001;
				short num2 = num;
				num = (short)2003401969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666121728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1531641856;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x005579A8 File Offset: 0x00555BA8
		// (set) Token: 0x06005F39 RID: 24377 RVA: 0x00557A5C File Offset: 0x00555C5C
		public bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_Applicable
		{
			get
			{
				short num = (short)2140327498;
				short num2 = num;
				num = (short)1435487818;
				switch (num2 == num)
				{
				}
				num = (short)590872576;
				short num3 = num;
				num = (short)1982136321;
				if (num != 0)
				{
				}
				num = (short)724828160;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Applicable;
			}
			set
			{
				short num = (short)264854032;
				short num2 = num;
				num = (short)611277328;
				switch (num2 == num)
				{
				}
				num = (short)1321992192;
				short num3 = num;
				num = (short)1949040641;
				if (num != 0)
				{
				}
				num = (short)718340096;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Applicable = value;
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x00557B10 File Offset: 0x00555D10
		// (set) Token: 0x06005F3B RID: 24379 RVA: 0x00557BC4 File Offset: 0x00555DC4
		public bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_Valid
		{
			get
			{
				short num = (short)683061675;
				short num2 = num;
				num = (short)1144893867;
				switch (num2 == num)
				{
				}
				num = (short)2040201216;
				short num3 = num;
				num = (short)1786839040;
				if (num != 0)
				{
				}
				num = (short)631635969;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Valid;
			}
			set
			{
				short num = (short)1392433843;
				short num2 = num;
				num = (short)321837747;
				switch (num2 == num)
				{
				}
				num = (short)1615265792;
				short num3 = num;
				num = (short)1847590913;
				if (num != 0)
				{
				}
				num = (short)1072234496;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Valid = value;
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x00557C78 File Offset: 0x00555E78
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x00557D30 File Offset: 0x00555F30
		public bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_Visible
		{
			get
			{
				short num = (short)1342843421;
				short num2 = num;
				num = (short)838216221;
				switch (num2 == num)
				{
				}
				num = (short)51576832;
				short num3 = num;
				num = (short)2042560512;
				if (num != 0)
				{
				}
				num = (short)436666369;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Visible;
			}
			set
			{
				short num = (short)985350342;
				short num2 = num;
				num = (short)1023230150;
				switch (num2 == num)
				{
				}
				num = (short)860749824;
				short num3 = num;
				num = (short)2123628545;
				if (num != 0)
				{
				}
				num = (short)1018494976;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Visible = value;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x00557DE4 File Offset: 0x00555FE4
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x00557E98 File Offset: 0x00556098
		public bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_Editable
		{
			get
			{
				short num = (short)1882220343;
				short num2 = num;
				num = (short)1727096631;
				switch (num2 == num)
				{
				}
				num = (short)1654718464;
				short num3 = num;
				num = (short)542441473;
				if (num != 0)
				{
				}
				num = (short)1998782464;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Editable;
			}
			set
			{
				short num = (short)258243768;
				short num2 = num;
				num = (short)2035186872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2082996224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647640577;
				if (num != 0)
				{
				}
				num = (short)1310785536;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.Editable = value;
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06005F40 RID: 24384 RVA: 0x00557F4C File Offset: 0x0055614C
		internal string RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_UILabel
		{
			get
			{
				short num = (short)27262977;
				if (num != 0)
				{
				}
				num = (short)1559756800;
				short num2 = num;
				num = (short)255461803;
				short num3 = num;
				num = (short)1198197163;
				switch (num3 == num)
				{
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.UIName;
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x00558004 File Offset: 0x00556204
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x005580B8 File Offset: 0x005562B8
		internal bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_HiddenStatic
		{
			get
			{
				short num = (short)383919381;
				short num2 = num;
				num = (short)1944200469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1537343488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554186241;
				if (num != 0)
				{
				}
				num = (short)1468923904;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.HiddenStatic;
			}
			set
			{
				short num = (short)163905537;
				if (num != 0)
				{
				}
				num = (short)365428736;
				short num2 = num;
				num = (short)2137024797;
				short num3 = num;
				num = (short)1253009693;
				switch (num3 == num)
				{
				}
				num = (short)728367104;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.HiddenStatic = value;
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x0055816C File Offset: 0x0055636C
		// (set) Token: 0x06005F44 RID: 24388 RVA: 0x00558224 File Offset: 0x00556424
		internal bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_HiddenDynamic
		{
			get
			{
				short num = (short)664110679;
				short num2 = num;
				num = (short)1747289687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1945436160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1810956288;
				if (num != 0)
				{
				}
				num = (short)246743041;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.HiddenDynamic;
			}
			set
			{
				short num = (short)1098120807;
				short num2 = num;
				num = (short)1615724135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795279360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263716865;
				if (num != 0)
				{
				}
				num = (short)165216256;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550.HiddenDynamic = value;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06005F45 RID: 24389 RVA: 0x005582D8 File Offset: 0x005564D8
		public bool RadProfAudioSettingsExternalMicWindNoiseReductionMode_A21550_HasDiffs
		{
			get
			{
				short num = (short)479877863;
				short num2 = num;
				num = (short)619666151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912850944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)181600256;
				if (num != 0)
				{
				}
				num = (short)2096103425;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550._HasDiffs;
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x06005F46 RID: 24390 RVA: 0x0055838C File Offset: 0x0055658C
		// (set) Token: 0x06005F47 RID: 24391 RVA: 0x00558440 File Offset: 0x00556640
		public int RadProfAudioSettingsInternalMicSourceMode_A22193Value
		{
			get
			{
				short num = (short)449269032;
				short num2 = num;
				num = (short)123817256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1257046016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1841954817;
				if (num != 0)
				{
				}
				num = (short)1544552448;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.Value;
			}
			set
			{
				short num = (short)32112641;
				if (num != 0)
				{
				}
				num = (short)1400111104;
				short num2 = num;
				num = (short)2091985371;
				short num3 = num;
				num = (short)1325017563;
				switch (num3 == num)
				{
				}
				num = (short)209715200;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.Value = value;
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x005584F4 File Offset: 0x005566F4
		// (set) Token: 0x06005F49 RID: 24393 RVA: 0x005585AC File Offset: 0x005567AC
		public string RadProfAudioSettingsInternalMicSourceMode_A22193_UIValue
		{
			get
			{
				short num = (short)1672759531;
				short num2 = num;
				num = (short)1370966251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710213632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547763713;
				if (num != 0)
				{
				}
				num = (short)1059192832;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.UIValue;
			}
			set
			{
				short num = (short)1888301197;
				short num2 = num;
				num = (short)803942541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319488000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636302848;
				if (num != 0)
				{
				}
				num = (short)1029373953;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.UIValue = value;
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x00558660 File Offset: 0x00556860
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsInternalMicSourceMode_A22193
		{
			get
			{
				short num = (short)1853950993;
				short num2 = num;
				num = (short)1199901713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360134144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975896577;
				if (num != 0)
				{
				}
				num = (short)536674304;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193;
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x0055870C File Offset: 0x0055690C
		// (set) Token: 0x06005F4C RID: 24396 RVA: 0x005587C0 File Offset: 0x005569C0
		public bool RadProfAudioSettingsInternalMicSourceMode_A22193_Applicable
		{
			get
			{
				short num = (short)1271122544;
				short num2 = num;
				num = (short)2023541360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868562432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477378048;
				if (num != 0)
				{
				}
				num = (short)675020801;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.Applicable;
			}
			set
			{
				short num = (short)1176502273;
				if (num != 0)
				{
				}
				num = (short)2055929856;
				short num2 = num;
				num = (short)1816009390;
				short num3 = num;
				num = (short)579410606;
				switch (num3 == num)
				{
				}
				num = (short)2012807168;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.Applicable = value;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06005F4D RID: 24397 RVA: 0x00558874 File Offset: 0x00556A74
		// (set) Token: 0x06005F4E RID: 24398 RVA: 0x00558928 File Offset: 0x00556B28
		public bool RadProfAudioSettingsInternalMicSourceMode_A22193_Valid
		{
			get
			{
				short num = (short)1906128881;
				short num2 = num;
				num = (short)165296113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1392181248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645005313;
				if (num != 0)
				{
				}
				num = (short)2079457280;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.Valid;
			}
			set
			{
				short num = (short)1522172130;
				short num2 = num;
				num = (short)1563721954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786183680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333854208;
				if (num != 0)
				{
				}
				num = (short)628097025;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.Valid = value;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06005F4F RID: 24399 RVA: 0x005589E0 File Offset: 0x00556BE0
		// (set) Token: 0x06005F50 RID: 24400 RVA: 0x00558A94 File Offset: 0x00556C94
		public bool RadProfAudioSettingsInternalMicSourceMode_A22193_Visible
		{
			get
			{
				short num = (short)1517873555;
				short num2 = num;
				num = (short)1355868563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255211008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811008001;
				if (num != 0)
				{
				}
				num = (short)515899392;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.Visible;
			}
			set
			{
				short num = (short)2071479963;
				short num2 = num;
				num = (short)499271323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90308608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				num = (short)557711361;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.Visible = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x00558B48 File Offset: 0x00556D48
		// (set) Token: 0x06005F52 RID: 24402 RVA: 0x00558BFC File Offset: 0x00556DFC
		public bool RadProfAudioSettingsInternalMicSourceMode_A22193_Editable
		{
			get
			{
				short num = (short)1060623226;
				short num2 = num;
				num = (short)1840567162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)551616512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107361792;
				if (num != 0)
				{
				}
				num = (short)146931713;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.Editable;
			}
			set
			{
				short num = (short)1976994666;
				short num2 = num;
				num = (short)556764010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1744568320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166461441;
				if (num != 0)
				{
				}
				num = (short)32636928;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.Editable = value;
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06005F53 RID: 24403 RVA: 0x00558CB0 File Offset: 0x00556EB0
		internal string RadProfAudioSettingsInternalMicSourceMode_A22193_UILabel
		{
			get
			{
				short num = (short)1594359809;
				if (num != 0)
				{
				}
				num = (short)956497920;
				short num2 = num;
				num = (short)828255426;
				short num3 = num;
				num = (short)521546946;
				switch (num3 == num)
				{
				}
				num = (short)414777344;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.UIName;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x00558D64 File Offset: 0x00556F64
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x00558E18 File Offset: 0x00557018
		internal bool RadProfAudioSettingsInternalMicSourceMode_A22193_HiddenStatic
		{
			get
			{
				short num = (short)868184969;
				short num2 = num;
				num = (short)511472521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)45744128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789970945;
				if (num != 0)
				{
				}
				num = (short)340000768;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.HiddenStatic;
			}
			set
			{
				short num = (short)1191575553;
				if (num != 0)
				{
				}
				num = (short)1453326336;
				short num2 = num;
				num = (short)1803512722;
				short num3 = num;
				num = (short)1444768658;
				switch (num3 == num)
				{
				}
				num = (short)1579417600;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.HiddenStatic = value;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x00558ED0 File Offset: 0x005570D0
		// (set) Token: 0x06005F57 RID: 24407 RVA: 0x00558F84 File Offset: 0x00557184
		internal bool RadProfAudioSettingsInternalMicSourceMode_A22193_HiddenDynamic
		{
			get
			{
				short num = (short)1426538420;
				short num2 = num;
				num = (short)1695301556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685323776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288227329;
				if (num != 0)
				{
				}
				num = (short)1474035712;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193.HiddenDynamic;
			}
			set
			{
				short num = (short)148074764;
				short num2 = num;
				num = (short)589656332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492713472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185466881;
				if (num != 0)
				{
				}
				num = (short)656211968;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicSourceMode_A22193.HiddenDynamic = value;
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0055903C File Offset: 0x0055723C
		public bool RadProfAudioSettingsInternalMicSourceMode_A22193_HasDiffs
		{
			get
			{
				short num = (short)895993312;
				short num2 = num;
				num = (short)265209312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83230720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931149312;
				if (num != 0)
				{
				}
				num = (short)2056192001;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicSourceMode_A22193._HasDiffs;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x06005F59 RID: 24409 RVA: 0x005590F0 File Offset: 0x005572F0
		// (set) Token: 0x06005F5A RID: 24410 RVA: 0x005591A4 File Offset: 0x005573A4
		public int RadProfAudioSettingsInternalMicDirectivityMode_A22195Value
		{
			get
			{
				short num = (short)620479425;
				short num2 = num;
				num = (short)325043137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694367744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405471233;
				if (num != 0)
				{
				}
				num = (short)681771008;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Value;
			}
			set
			{
				short num = (short)1296524327;
				short num2 = num;
				num = (short)155345959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685782528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)473628673;
				if (num != 0)
				{
				}
				num = (short)476184576;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Value = value;
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x06005F5B RID: 24411 RVA: 0x00559258 File Offset: 0x00557458
		// (set) Token: 0x06005F5C RID: 24412 RVA: 0x0055930C File Offset: 0x0055750C
		public string RadProfAudioSettingsInternalMicDirectivityMode_A22195_UIValue
		{
			get
			{
				short num = (short)679154195;
				short num2 = num;
				num = (short)2023821843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912668160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133510656;
				if (num != 0)
				{
				}
				num = (short)186974209;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.UIValue;
			}
			set
			{
				short num = (short)1322371029;
				short num2 = num;
				num = (short)800114645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201471488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634664448;
				if (num != 0)
				{
				}
				num = (short)1709506561;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.UIValue = value;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x005593C0 File Offset: 0x005575C0
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsInternalMicDirectivityMode_A22195
		{
			get
			{
				short num = (short)847693159;
				short num2 = num;
				num = (short)700761447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780926976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264713729;
				if (num != 0)
				{
				}
				num = (short)1445855232;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x00559470 File Offset: 0x00557670
		// (set) Token: 0x06005F5F RID: 24415 RVA: 0x00559520 File Offset: 0x00557720
		public bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_Applicable
		{
			get
			{
				short num = (short)565073126;
				short num2 = num;
				num = (short)2141869286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000472576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700134913;
				if (num != 0)
				{
				}
				num = (short)260308992;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Applicable;
			}
			set
			{
				short num = (short)482090135;
				short num2 = num;
				num = (short)1713708183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062680064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302252033;
				if (num != 0)
				{
				}
				num = (short)1493368832;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Applicable = value;
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x005595D4 File Offset: 0x005577D4
		// (set) Token: 0x06005F61 RID: 24417 RVA: 0x00559688 File Offset: 0x00557888
		public bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_Valid
		{
			get
			{
				short num = (short)665190401;
				if (num != 0)
				{
				}
				num = (short)1477181440;
				short num2 = num;
				num = (short)2111511790;
				short num3 = num;
				num = (short)458956014;
				switch (num3 == num)
				{
				}
				num = (short)1777860608;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Valid;
			}
			set
			{
				short num = (short)1741889323;
				short num2 = num;
				num = (short)2068389675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498139136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				num = (short)1791033344;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Valid = value;
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06005F62 RID: 24418 RVA: 0x00559740 File Offset: 0x00557940
		// (set) Token: 0x06005F63 RID: 24419 RVA: 0x005597F4 File Offset: 0x005579F4
		public bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_Visible
		{
			get
			{
				short num = (short)1320878081;
				if (num != 0)
				{
				}
				num = (short)983302144;
				short num2 = num;
				num = (short)89746586;
				short num3 = num;
				num = (short)2101701786;
				switch (num3 == num)
				{
				}
				num = (short)530972672;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Visible;
			}
			set
			{
				short num = (short)197386131;
				short num2 = num;
				num = (short)31252371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)154992640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463484416;
				if (num != 0)
				{
				}
				num = (short)493551617;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Visible = value;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x005598AC File Offset: 0x00557AAC
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x00559960 File Offset: 0x00557B60
		public bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_Editable
		{
			get
			{
				short num = (short)431105652;
				short num2 = num;
				num = (short)1491609204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337851904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340211201;
				if (num != 0)
				{
				}
				num = (short)1990983680;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Editable;
			}
			set
			{
				short num = (short)999538842;
				short num2 = num;
				num = (short)637911194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268187136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730202112;
				if (num != 0)
				{
				}
				num = (short)91422721;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.Editable = value;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x00559A14 File Offset: 0x00557C14
		internal string RadProfAudioSettingsInternalMicDirectivityMode_A22195_UILabel
		{
			get
			{
				short num = (short)1536945313;
				short num2 = num;
				num = (short)1820257441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809762816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)800063488;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.UIName;
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06005F67 RID: 24423 RVA: 0x00559AC8 File Offset: 0x00557CC8
		// (set) Token: 0x06005F68 RID: 24424 RVA: 0x00559B7C File Offset: 0x00557D7C
		internal bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_HiddenStatic
		{
			get
			{
				short num = (short)1718103041;
				short num2 = num;
				num = (short)714353665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444137472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312555009;
				if (num != 0)
				{
				}
				num = (short)1840054272;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.HiddenStatic;
			}
			set
			{
				short num = (short)847148411;
				short num2 = num;
				num = (short)966686075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)506986496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)435486720;
				if (num != 0)
				{
				}
				num = (short)1695612929;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.HiddenStatic = value;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06005F69 RID: 24425 RVA: 0x00559C30 File Offset: 0x00557E30
		// (set) Token: 0x06005F6A RID: 24426 RVA: 0x00559CE4 File Offset: 0x00557EE4
		internal bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_HiddenDynamic
		{
			get
			{
				short num = (short)390856705;
				if (num != 0)
				{
				}
				num = (short)1493368832;
				short num2 = num;
				num = (short)893866074;
				short num3 = num;
				num = (short)689852506;
				switch (num3 == num)
				{
				}
				num = (short)133758976;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195.HiddenDynamic;
			}
			set
			{
				short num = (short)174841729;
				short num2 = num;
				num = (short)1353703297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1315241984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27590657;
				if (num != 0)
				{
				}
				num = (short)1713373184;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicDirectivityMode_A22195.HiddenDynamic = value;
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x06005F6B RID: 24427 RVA: 0x00559D98 File Offset: 0x00557F98
		public bool RadProfAudioSettingsInternalMicDirectivityMode_A22195_HasDiffs
		{
			get
			{
				short num = (short)454987297;
				short num2 = num;
				num = (short)934645281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708247552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)415236096;
				if (num != 0)
				{
				}
				num = (short)731119617;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicDirectivityMode_A22195._HasDiffs;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x00559E4C File Offset: 0x0055804C
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x00559F00 File Offset: 0x00558100
		public int RadProfAudioSettingsInternalMicOtherNoiseMode_A22196Value
		{
			get
			{
				short num = (short)1431412193;
				short num2 = num;
				num = (short)1891147233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989279744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1597112321;
				if (num != 0)
				{
				}
				num = (short)156762112;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Value;
			}
			set
			{
				short num = (short)414129834;
				short num2 = num;
				num = (short)2141855402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3866624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907083777;
				if (num != 0)
				{
				}
				num = (short)1454440448;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Value = value;
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x00559FB8 File Offset: 0x005581B8
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x0055A068 File Offset: 0x00558268
		public string RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_UIValue
		{
			get
			{
				short num = (short)1923350529;
				if (num != 0)
				{
				}
				num = (short)1096704578;
				short num2 = num;
				num = (short)1157390914;
				switch (num2 == num)
				{
				}
				num = (short)667090944;
				if (num != 0)
				{
				}
				num = (short)396623872;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.UIValue;
			}
			set
			{
				short num = (short)40080984;
				short num2 = num;
				num = (short)407344728;
				switch (num2 == num)
				{
				}
				num = (short)114884609;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				if (num != 0)
				{
				}
				num = (short)324468736;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.UIValue = value;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x0055A11C File Offset: 0x0055831C
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsInternalMicOtherNoiseMode_A22196
		{
			get
			{
				short num = (short)1441585454;
				short num2 = num;
				num = (short)32364846;
				switch (num2 == num)
				{
				}
				num = (short)2119958529;
				if (num != 0)
				{
				}
				num = (short)1528233984;
				if (num != 0)
				{
				}
				num = (short)1618411520;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196;
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x06005F71 RID: 24433 RVA: 0x0055A1D0 File Offset: 0x005583D0
		// (set) Token: 0x06005F72 RID: 24434 RVA: 0x0055A288 File Offset: 0x00558488
		public bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_Applicable
		{
			get
			{
				short num = (short)846907416;
				short num2 = num;
				num = (short)1558956056;
				switch (num2 == num)
				{
				}
				num = (short)220594177;
				if (num != 0)
				{
				}
				num = (short)611844096;
				if (num != 0)
				{
				}
				num = (short)177537024;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Applicable;
			}
			set
			{
				short num = (short)2064421912;
				short num2 = num;
				num = (short)1189581848;
				switch (num2 == num)
				{
				}
				num = (short)1432158209;
				if (num != 0)
				{
				}
				num = (short)1939013632;
				if (num != 0)
				{
				}
				num = (short)2080899072;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Applicable = value;
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x06005F73 RID: 24435 RVA: 0x0055A33C File Offset: 0x0055853C
		// (set) Token: 0x06005F74 RID: 24436 RVA: 0x0055A3F0 File Offset: 0x005585F0
		public bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_Valid
		{
			get
			{
				short num = (short)894785186;
				short num2 = num;
				num = (short)387274402;
				switch (num2 == num)
				{
				}
				num = (short)1709965312;
				if (num != 0)
				{
				}
				num = (short)1876623361;
				if (num != 0)
				{
				}
				num = (short)101318656;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Valid;
			}
			set
			{
				short num = (short)1582497793;
				if (num != 0)
				{
				}
				num = (short)676902236;
				short num2 = num;
				num = (short)2001450332;
				switch (num2 == num)
				{
				}
				num = (short)207618048;
				if (num != 0)
				{
				}
				num = (short)957022208;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Valid = value;
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x06005F75 RID: 24437 RVA: 0x0055A4A8 File Offset: 0x005586A8
		// (set) Token: 0x06005F76 RID: 24438 RVA: 0x0055A55C File Offset: 0x0055875C
		public bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_Visible
		{
			get
			{
				short num = (short)1382300276;
				short num2 = num;
				num = (short)1981692532;
				switch (num2 == num)
				{
				}
				num = (short)1666449409;
				if (num != 0)
				{
				}
				num = (short)671875072;
				if (num != 0)
				{
				}
				num = (short)393543680;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Visible;
			}
			set
			{
				short num = (short)58853678;
				short num2 = num;
				num = (short)1686636846;
				switch (num2 == num)
				{
				}
				num = (short)2111635456;
				if (num != 0)
				{
				}
				num = (short)957153281;
				if (num != 0)
				{
				}
				num = (short)1727791104;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Visible = value;
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x06005F77 RID: 24439 RVA: 0x0055A610 File Offset: 0x00558810
		// (set) Token: 0x06005F78 RID: 24440 RVA: 0x0055A6C8 File Offset: 0x005588C8
		public bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_Editable
		{
			get
			{
				short num = (short)739614233;
				short num2 = num;
				num = (short)446340633;
				switch (num2 == num)
				{
				}
				num = (short)133234688;
				if (num != 0)
				{
				}
				num = (short)1201733633;
				if (num != 0)
				{
				}
				num = (short)1120010240;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Editable;
			}
			set
			{
				short num = (short)633660768;
				short num2 = num;
				num = (short)1759962464;
				switch (num2 == num)
				{
				}
				num = (short)1628700672;
				if (num != 0)
				{
				}
				num = (short)1114374145;
				if (num != 0)
				{
				}
				num = (short)635502592;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.Editable = value;
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x06005F79 RID: 24441 RVA: 0x0055A77C File Offset: 0x0055897C
		internal string RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_UILabel
		{
			get
			{
				short num = (short)109967376;
				short num2 = num;
				num = (short)140900368;
				switch (num2 == num)
				{
				}
				num = (short)996278273;
				if (num != 0)
				{
				}
				num = (short)529989632;
				if (num != 0)
				{
				}
				num = (short)822804480;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.UIName;
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x0055A830 File Offset: 0x00558A30
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x0055A8E4 File Offset: 0x00558AE4
		internal bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_HiddenStatic
		{
			get
			{
				short num = (short)1646248055;
				short num2 = num;
				num = (short)1218822263;
				switch (num2 == num)
				{
				}
				num = (short)521076736;
				if (num != 0)
				{
				}
				num = (short)651231233;
				if (num != 0)
				{
				}
				num = (short)612499456;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.HiddenStatic;
			}
			set
			{
				short num = (short)1750743718;
				short num2 = num;
				num = (short)285751974;
				switch (num2 == num)
				{
				}
				num = (short)1203634177;
				if (num != 0)
				{
				}
				num = (short)1885995008;
				if (num != 0)
				{
				}
				num = (short)1335623680;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.HiddenStatic = value;
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x0055A99C File Offset: 0x00558B9C
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x0055AA50 File Offset: 0x00558C50
		internal bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_HiddenDynamic
		{
			get
			{
				short num = (short)596899519;
				short num2 = num;
				num = (short)45807295;
				switch (num2 == num)
				{
				}
				num = (short)1816068097;
				if (num != 0)
				{
				}
				num = (short)240975872;
				if (num != 0)
				{
				}
				num = (short)1825898496;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.HiddenDynamic;
			}
			set
			{
				short num = (short)340605717;
				short num2 = num;
				num = (short)1360149269;
				switch (num2 == num)
				{
				}
				num = (short)1477836801;
				if (num != 0)
				{
				}
				num = (short)1179451392;
				if (num != 0)
				{
				}
				num = (short)510001152;
				short num3 = num;
				this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196.HiddenDynamic = value;
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x0055AB08 File Offset: 0x00558D08
		public bool RadProfAudioSettingsInternalMicOtherNoiseMode_A22196_HasDiffs
		{
			get
			{
				short num = (short)927031813;
				short num2 = num;
				num = (short)472408581;
				switch (num2 == num)
				{
				}
				num = (short)870907905;
				if (num != 0)
				{
				}
				num = (short)2068447232;
				if (num != 0)
				{
				}
				num = (short)1160249344;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicOtherNoiseMode_A22196._HasDiffs;
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x06005F7F RID: 24447 RVA: 0x0055ABBC File Offset: 0x00558DBC
		// (set) Token: 0x06005F80 RID: 24448 RVA: 0x0055AC74 File Offset: 0x00558E74
		public int RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197Value
		{
			get
			{
				short num = (short)805798787;
				short num2 = num;
				num = (short)1929675651;
				switch (num2 == num)
				{
				}
				num = (short)1578041345;
				if (num != 0)
				{
				}
				num = (short)1474428928;
				if (num != 0)
				{
				}
				num = (short)724566016;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Value;
			}
			set
			{
				short num = (short)144694183;
				short num2 = num;
				num = (short)628808615;
				switch (num2 == num)
				{
				}
				num = (short)2102591489;
				if (num != 0)
				{
				}
				num = (short)1934950400;
				if (num != 0)
				{
				}
				num = (short)446103552;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Value = value;
			}
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x06005F81 RID: 24449 RVA: 0x0055AD28 File Offset: 0x00558F28
		// (set) Token: 0x06005F82 RID: 24450 RVA: 0x0055ADDC File Offset: 0x00558FDC
		public string RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_UIValue
		{
			get
			{
				short num = (short)1511780218;
				short num2 = num;
				num = (short)483913594;
				switch (num2 == num)
				{
				}
				num = (short)1317470208;
				if (num != 0)
				{
				}
				num = (short)1189412865;
				if (num != 0)
				{
				}
				num = (short)1687814144;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.UIValue;
			}
			set
			{
				short num = (short)2004397442;
				short num2 = num;
				num = (short)347778434;
				switch (num2 == num)
				{
				}
				num = (short)1624047616;
				if (num != 0)
				{
				}
				num = (short)1605632001;
				if (num != 0)
				{
				}
				num = (short)2135097344;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.UIValue = value;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x06005F83 RID: 24451 RVA: 0x0055AE94 File Offset: 0x00559094
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197
		{
			get
			{
				short num = (short)215677827;
				short num2 = num;
				num = (short)1731918723;
				switch (num2 == num)
				{
				}
				num = (short)921370625;
				if (num != 0)
				{
				}
				num = (short)1482752000;
				if (num != 0)
				{
				}
				num = (short)1299382272;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x0055AF44 File Offset: 0x00559144
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x0055AFF8 File Offset: 0x005591F8
		public bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_Applicable
		{
			get
			{
				short num = (short)18664279;
				short num2 = num;
				num = (short)1429588823;
				switch (num2 == num)
				{
				}
				num = (short)1189806081;
				if (num != 0)
				{
				}
				num = (short)189595648;
				if (num != 0)
				{
				}
				num = (short)817364992;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Applicable;
			}
			set
			{
				short num = (short)1694040065;
				if (num != 0)
				{
				}
				num = (short)520200527;
				short num2 = num;
				num = (short)2127601999;
				switch (num2 == num)
				{
				}
				num = (short)1130102784;
				if (num != 0)
				{
				}
				num = (short)750190592;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Applicable = value;
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x0055B0B0 File Offset: 0x005592B0
		// (set) Token: 0x06005F87 RID: 24455 RVA: 0x0055B168 File Offset: 0x00559368
		public bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_Valid
		{
			get
			{
				short num = (short)657048351;
				short num2 = num;
				num = (short)1203487519;
				switch (num2 == num)
				{
				}
				num = (short)243662849;
				if (num != 0)
				{
				}
				num = (short)344457216;
				if (num != 0)
				{
				}
				num = (short)144965632;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Valid;
			}
			set
			{
				short num = (short)868713985;
				short num2 = num;
				num = (short)1386841601;
				switch (num2 == num)
				{
				}
				num = (short)215678976;
				if (num != 0)
				{
				}
				num = (short)72810497;
				if (num != 0)
				{
				}
				num = (short)687538176;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Valid = value;
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x0055B220 File Offset: 0x00559420
		// (set) Token: 0x06005F89 RID: 24457 RVA: 0x0055B2D4 File Offset: 0x005594D4
		public bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_Visible
		{
			get
			{
				short num = (short)2056709849;
				short num2 = num;
				num = (short)173336281;
				switch (num2 == num)
				{
				}
				num = (short)1819738113;
				if (num != 0)
				{
				}
				num = (short)48627712;
				if (num != 0)
				{
				}
				num = (short)1865285632;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Visible;
			}
			set
			{
				short num = (short)158138369;
				if (num != 0)
				{
				}
				num = (short)1787715432;
				short num2 = num;
				num = (short)349724520;
				switch (num2 == num)
				{
				}
				num = (short)1013186560;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Visible = value;
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x0055B388 File Offset: 0x00559588
		// (set) Token: 0x06005F8B RID: 24459 RVA: 0x0055B43C File Offset: 0x0055963C
		public bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_Editable
		{
			get
			{
				short num = (short)259372871;
				short num2 = num;
				num = (short)100382535;
				switch (num2 == num)
				{
				}
				num = (short)1528627201;
				if (num != 0)
				{
				}
				num = (short)1365573632;
				if (num != 0)
				{
				}
				num = (short)2029846528;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Editable;
			}
			set
			{
				short num = (short)534979375;
				short num2 = num;
				num = (short)1252598575;
				switch (num2 == num)
				{
				}
				num = (short)1606090753;
				if (num != 0)
				{
				}
				num = (short)1741553664;
				if (num != 0)
				{
				}
				num = (short)872677376;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.Editable = value;
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x0055B4F4 File Offset: 0x005596F4
		internal string RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_UILabel
		{
			get
			{
				short num = (short)413830160;
				short num2 = num;
				num = (short)718244880;
				switch (num2 == num)
				{
				}
				num = (short)1412497408;
				if (num != 0)
				{
				}
				num = (short)1094451201;
				if (num != 0)
				{
				}
				num = (short)293208064;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.UIName;
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x06005F8D RID: 24461 RVA: 0x0055B5A8 File Offset: 0x005597A8
		// (set) Token: 0x06005F8E RID: 24462 RVA: 0x0055B65C File Offset: 0x0055985C
		internal bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_HiddenStatic
		{
			get
			{
				short num = (short)2107617683;
				short num2 = num;
				num = (short)555331987;
				switch (num2 == num)
				{
				}
				num = (short)1093140480;
				if (num != 0)
				{
				}
				num = (short)927006721;
				if (num != 0)
				{
				}
				num = (short)891027456;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.HiddenStatic;
			}
			set
			{
				short num = (short)44749611;
				short num2 = num;
				num = (short)1176752939;
				switch (num2 == num)
				{
				}
				num = (short)432013312;
				if (num != 0)
				{
				}
				num = (short)264699905;
				if (num != 0)
				{
				}
				num = (short)801374208;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.HiddenStatic = value;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x06005F8F RID: 24463 RVA: 0x0055B714 File Offset: 0x00559914
		// (set) Token: 0x06005F90 RID: 24464 RVA: 0x0055B7C8 File Offset: 0x005599C8
		internal bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_HiddenDynamic
		{
			get
			{
				short num = (short)1580640053;
				short num2 = num;
				num = (short)1626318645;
				switch (num2 == num)
				{
				}
				num = (short)2102853633;
				if (num != 0)
				{
				}
				num = (short)876412928;
				if (num != 0)
				{
				}
				num = (short)858783744;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.HiddenDynamic;
			}
			set
			{
				short num = (short)569008511;
				short num2 = num;
				num = (short)1757372799;
				switch (num2 == num)
				{
				}
				num = (short)2038104065;
				if (num != 0)
				{
				}
				num = (short)1279918080;
				if (num != 0)
				{
				}
				num = (short)1089732608;
				short num3 = num;
				this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197.HiddenDynamic = value;
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x06005F91 RID: 24465 RVA: 0x0055B87C File Offset: 0x00559A7C
		public bool RadProfAudioSettingsInternalMicWindNoiseReductionMode_A22197_HasDiffs
		{
			get
			{
				short num = (short)1415105999;
				short num2 = num;
				num = (short)679726543;
				switch (num2 == num)
				{
				}
				num = (short)2088239104;
				if (num != 0)
				{
				}
				num = (short)1659895809;
				if (num != 0)
				{
				}
				num = (short)1171849216;
				short num3 = num;
				return this.radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197._HasDiffs;
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x0055B930 File Offset: 0x00559B30
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x0055B9E8 File Offset: 0x00559BE8
		public int RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312Value
		{
			get
			{
				short num = (short)1677801700;
				short num2 = num;
				num = (short)1242380516;
				switch (num2 == num)
				{
				}
				num = (short)1922826241;
				if (num != 0)
				{
				}
				num = (short)97648640;
				if (num != 0)
				{
				}
				num = (short)1975517184;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Value;
			}
			set
			{
				short num = (short)1442643900;
				short num2 = num;
				num = (short)1856307132;
				switch (num2 == num)
				{
				}
				num = (short)717225985;
				if (num != 0)
				{
				}
				num = (short)961150976;
				if (num != 0)
				{
				}
				num = (short)978583552;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Value = value;
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x0055BAA0 File Offset: 0x00559CA0
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x0055BB54 File Offset: 0x00559D54
		public string RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_UIValue
		{
			get
			{
				short num = (short)483864911;
				short num2 = num;
				num = (short)148713807;
				switch (num2 == num)
				{
				}
				num = (short)966197249;
				if (num != 0)
				{
				}
				num = (short)1272053760;
				if (num != 0)
				{
				}
				num = (short)1615134720;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.UIValue;
			}
			set
			{
				short num = (short)1381105219;
				short num2 = num;
				num = (short)221773379;
				switch (num2 == num)
				{
				}
				num = (short)1257504769;
				if (num != 0)
				{
				}
				num = (short)105316352;
				if (num != 0)
				{
				}
				num = (short)759562240;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.UIValue = value;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x0055BC08 File Offset: 0x00559E08
		public global::AcpBusinessLayer.AcpRecRefField RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312
		{
			get
			{
				short num = (short)853501754;
				short num2 = num;
				num = (short)1554474810;
				switch (num2 == num)
				{
				}
				num = (short)1542914049;
				if (num != 0)
				{
				}
				num = (short)2137849856;
				if (num != 0)
				{
				}
				num = (short)701497344;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x06005F97 RID: 24471 RVA: 0x0055BCB8 File Offset: 0x00559EB8
		// (set) Token: 0x06005F98 RID: 24472 RVA: 0x0055BD6C File Offset: 0x00559F6C
		public bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_Applicable
		{
			get
			{
				short num = (short)1878123130;
				short num2 = num;
				num = (short)1578427002;
				switch (num2 == num)
				{
				}
				num = (short)587988992;
				if (num != 0)
				{
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				num = (short)566886400;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Applicable;
			}
			set
			{
				short num = (short)867898876;
				short num2 = num;
				num = (short)1893012988;
				switch (num2 == num)
				{
				}
				num = (short)1856962560;
				if (num != 0)
				{
				}
				num = (short)117440513;
				if (num != 0)
				{
				}
				num = (short)1306394624;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Applicable = value;
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x0055BE24 File Offset: 0x0055A024
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x0055BED8 File Offset: 0x0055A0D8
		public bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_Valid
		{
			get
			{
				short num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)57790081;
				short num2 = num;
				num = (short)2016595585;
				switch (num2 == num)
				{
				}
				num = (short)1501822976;
				if (num != 0)
				{
				}
				num = (short)189792256;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Valid;
			}
			set
			{
				short num = (short)1812265522;
				short num2 = num;
				num = (short)793639474;
				switch (num2 == num)
				{
				}
				num = (short)911867904;
				if (num != 0)
				{
				}
				num = (short)962920449;
				if (num != 0)
				{
				}
				num = (short)1166213120;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Valid = value;
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x0055BF8C File Offset: 0x0055A18C
		// (set) Token: 0x06005F9C RID: 24476 RVA: 0x0055C044 File Offset: 0x0055A244
		public bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_Visible
		{
			get
			{
				short num = (short)335031907;
				short num2 = num;
				num = (short)352661091;
				switch (num2 == num)
				{
				}
				num = (short)2011496448;
				if (num != 0)
				{
				}
				num = (short)790953985;
				if (num != 0)
				{
				}
				num = (short)969736192;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Visible;
			}
			set
			{
				short num = (short)1810825217;
				if (num != 0)
				{
				}
				num = (short)1362362402;
				short num2 = num;
				num = (short)2121662498;
				switch (num2 == num)
				{
				}
				num = (short)458948608;
				if (num != 0)
				{
				}
				num = (short)524419072;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Visible = value;
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x0055C100 File Offset: 0x0055A300
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x0055C1B8 File Offset: 0x0055A3B8
		public bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_Editable
		{
			get
			{
				short num = (short)1796911611;
				short num2 = num;
				num = (short)1371517435;
				switch (num2 == num)
				{
				}
				num = (short)195362816;
				if (num != 0)
				{
				}
				num = (short)1509425153;
				if (num != 0)
				{
				}
				num = (short)1080360960;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Editable;
			}
			set
			{
				short num = (short)65287489;
				short num2 = num;
				num = (short)1790457153;
				switch (num2 == num)
				{
				}
				num = (short)761266176;
				if (num != 0)
				{
				}
				num = (short)1007353857;
				if (num != 0)
				{
				}
				num = (short)819068928;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.Editable = value;
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x0055C26C File Offset: 0x0055A46C
		internal string RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_UILabel
		{
			get
			{
				short num = (short)558185061;
				short num2 = num;
				num = (short)1373125221;
				switch (num2 == num)
				{
				}
				num = (short)1778122753;
				if (num != 0)
				{
				}
				num = (short)73924608;
				if (num != 0)
				{
				}
				num = (short)1098711040;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.UIName;
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x0055C320 File Offset: 0x0055A520
		// (set) Token: 0x06005FA1 RID: 24481 RVA: 0x0055C3D4 File Offset: 0x0055A5D4
		internal bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_HiddenStatic
		{
			get
			{
				short num = (short)1894968916;
				short num2 = num;
				num = (short)1761013332;
				switch (num2 == num)
				{
				}
				num = (short)76480512;
				if (num != 0)
				{
				}
				num = (short)1480720385;
				if (num != 0)
				{
				}
				num = (short)85852160;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.HiddenStatic;
			}
			set
			{
				short num = (short)649681918;
				short num2 = num;
				num = (short)1828543486;
				switch (num2 == num)
				{
				}
				num = (short)739377153;
				if (num != 0)
				{
				}
				num = (short)1027080192;
				if (num != 0)
				{
				}
				num = (short)711065600;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.HiddenStatic = value;
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x0055C488 File Offset: 0x0055A688
		// (set) Token: 0x06005FA3 RID: 24483 RVA: 0x0055C538 File Offset: 0x0055A738
		internal bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_HiddenDynamic
		{
			get
			{
				short num = (short)1280160377;
				short num2 = num;
				num = (short)231518841;
				switch (num2 == num)
				{
				}
				num = (short)1219100673;
				if (num != 0)
				{
				}
				num = (short)459341824;
				if (num != 0)
				{
				}
				num = (short)1014300672;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.HiddenDynamic;
			}
			set
			{
				short num = (short)779464294;
				short num2 = num;
				num = (short)1021554278;
				switch (num2 == num)
				{
				}
				num = (short)1383137280;
				if (num != 0)
				{
				}
				num = (short)961216513;
				if (num != 0)
				{
				}
				num = (short)549453824;
				short num3 = num;
				this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312.HiddenDynamic = value;
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x0055C5EC File Offset: 0x0055A7EC
		public bool RadProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312_HasDiffs
		{
			get
			{
				short num = (short)1366389032;
				short num2 = num;
				num = (short)2090168616;
				switch (num2 == num)
				{
				}
				num = (short)257163264;
				if (num != 0)
				{
				}
				num = (short)552992769;
				if (num != 0)
				{
				}
				num = (short)1818820608;
				short num3 = num;
				return this.radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312._HasDiffs;
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x0055C6A0 File Offset: 0x0055A8A0
		// (set) Token: 0x06005FA6 RID: 24486 RVA: 0x0055C758 File Offset: 0x0055A958
		public int RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314Value
		{
			get
			{
				short num = (short)1272905728;
				short num2 = num;
				num = (short)2113169086;
				short num3 = num;
				num = (short)853894846;
				switch (num3 == num)
				{
				}
				num = (short)1567031297;
				if (num != 0)
				{
				}
				num = (short)1455423488;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Value;
			}
			set
			{
				short num = (short)1097859072;
				short num2 = num;
				num = (short)466275073;
				short num3 = num;
				num = (short)188730113;
				switch (num3 == num)
				{
				}
				num = (short)495058944;
				if (num != 0)
				{
				}
				num = (short)1141702657;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Value = value;
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x0055C80C File Offset: 0x0055AA0C
		// (set) Token: 0x06005FA8 RID: 24488 RVA: 0x0055C8C4 File Offset: 0x0055AAC4
		public string RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_UIValue
		{
			get
			{
				short num = (short)503775232;
				short num2 = num;
				num = (short)126171102;
				short num3 = num;
				num = (short)832845790;
				switch (num3 == num)
				{
				}
				num = (short)917962753;
				if (num != 0)
				{
				}
				num = (short)1123090432;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.UIValue;
			}
			set
			{
				short num = (short)1902182400;
				short num2 = num;
				num = (short)735773945;
				short num3 = num;
				num = (short)563021049;
				switch (num3 == num)
				{
				}
				num = (short)1126301696;
				if (num != 0)
				{
				}
				num = (short)1466433537;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.UIValue = value;
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x0055C978 File Offset: 0x0055AB78
		public global::AcpBusinessLayer.AcpRecRefField RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314
		{
			get
			{
				short num = (short)1209073664;
				short num2 = num;
				num = (short)136056343;
				short num3 = num;
				num = (short)299240983;
				switch (num3 == num)
				{
				}
				num = (short)1329987585;
				if (num != 0)
				{
				}
				num = (short)463601664;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x0055CA28 File Offset: 0x0055AC28
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x0055CADC File Offset: 0x0055ACDC
		public bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_Applicable
		{
			get
			{
				short num = (short)1860173824;
				short num2 = num;
				num = (short)1331982281;
				short num3 = num;
				num = (short)1163292617;
				switch (num3 == num)
				{
				}
				num = (short)1366360065;
				if (num != 0)
				{
				}
				num = (short)1538850816;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Applicable;
			}
			set
			{
				short num = (short)352583680;
				short num2 = num;
				num = (short)817190387;
				short num3 = num;
				num = (short)978933235;
				switch (num3 == num)
				{
				}
				num = (short)721420288;
				if (num != 0)
				{
				}
				num = (short)638976001;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Applicable = value;
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x0055CB94 File Offset: 0x0055AD94
		// (set) Token: 0x06005FAD RID: 24493 RVA: 0x0055CC48 File Offset: 0x0055AE48
		public bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_Valid
		{
			get
			{
				short num = (short)65273856;
				short num2 = num;
				num = (short)1961394989;
				short num3 = num;
				num = (short)32932653;
				switch (num3 == num)
				{
				}
				num = (short)869269504;
				if (num != 0)
				{
				}
				num = (short)913178625;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Valid;
			}
			set
			{
				short num = (short)1990787072;
				short num2 = num;
				num = (short)2055726590;
				short num3 = num;
				num = (short)191423998;
				switch (num3 == num)
				{
				}
				num = (short)1986265089;
				if (num != 0)
				{
				}
				num = (short)1568866304;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Valid = value;
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x0055CCFC File Offset: 0x0055AEFC
		// (set) Token: 0x06005FAF RID: 24495 RVA: 0x0055CDB0 File Offset: 0x0055AFB0
		public bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_Visible
		{
			get
			{
				short num = (short)2108030976;
				short num2 = num;
				num = (short)1892286465;
				if (num != 0)
				{
				}
				num = (short)1729171976;
				short num3 = num;
				num = (short)599069192;
				switch (num3 == num)
				{
				}
				num = (short)1467285504;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Visible;
			}
			set
			{
				short num = (short)427687936;
				short num2 = num;
				num = (short)753939404;
				short num3 = num;
				num = (short)481506252;
				switch (num3 == num)
				{
				}
				num = (short)680853505;
				if (num != 0)
				{
				}
				num = (short)1471152128;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Visible = value;
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x0055CE68 File Offset: 0x0055B068
		// (set) Token: 0x06005FB1 RID: 24497 RVA: 0x0055CF1C File Offset: 0x0055B11C
		public bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_Editable
		{
			get
			{
				short num = (short)1882980352;
				short num2 = num;
				num = (short)243213540;
				short num3 = num;
				num = (short)2080056548;
				switch (num3 == num)
				{
				}
				num = (short)533856257;
				if (num != 0)
				{
				}
				num = (short)893255680;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Editable;
			}
			set
			{
				short num = (short)1072234496;
				short num2 = num;
				num = (short)528423234;
				short num3 = num;
				num = (short)389552450;
				switch (num3 == num)
				{
				}
				num = (short)1912864769;
				if (num != 0)
				{
				}
				num = (short)206176256;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.Editable = value;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x06005FB2 RID: 24498 RVA: 0x0055CFD0 File Offset: 0x0055B1D0
		internal string RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_UILabel
		{
			get
			{
				short num = (short)1004863488;
				short num2 = num;
				num = (short)499243302;
				short num3 = num;
				num = (short)1663490342;
				switch (num3 == num)
				{
				}
				num = (short)640614401;
				if (num != 0)
				{
				}
				num = (short)1617166336;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.UIName;
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x0055D084 File Offset: 0x0055B284
		// (set) Token: 0x06005FB4 RID: 24500 RVA: 0x0055D13C File Offset: 0x0055B33C
		internal bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_HiddenStatic
		{
			get
			{
				short num = (short)635437056;
				short num2 = num;
				num = (short)1282156784;
				short num3 = num;
				num = (short)17705200;
				switch (num3 == num)
				{
				}
				num = (short)116326400;
				if (num != 0)
				{
				}
				num = (short)1222901761;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.HiddenStatic;
			}
			set
			{
				short num = (short)440074240;
				short num2 = num;
				num = (short)327221249;
				if (num != 0)
				{
				}
				num = (short)244908592;
				short num3 = num;
				num = (short)197788208;
				switch (num3 == num)
				{
				}
				num = (short)450756608;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.HiddenStatic = value;
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x0055D1F4 File Offset: 0x0055B3F4
		// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x0055D2A8 File Offset: 0x0055B4A8
		internal bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_HiddenDynamic
		{
			get
			{
				short num = (short)1170145280;
				short num2 = num;
				num = (short)1724015176;
				short num3 = num;
				num = (short)678257224;
				switch (num3 == num)
				{
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				num = (short)1584070656;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.HiddenDynamic;
			}
			set
			{
				short num = (short)1867644928;
				short num2 = num;
				num = (short)1631736371;
				short num3 = num;
				num = (short)507728435;
				switch (num3 == num)
				{
				}
				num = (short)233373697;
				if (num != 0)
				{
				}
				num = (short)1839464448;
				if (num != 0)
				{
				}
				this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314.HiddenDynamic = value;
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x0055D358 File Offset: 0x0055B558
		public bool RadProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314_HasDiffs
		{
			get
			{
				short num = (short)668598272;
				short num2 = num;
				num = (short)634248548;
				short num3 = num;
				num = (short)151379300;
				switch (num3 == num)
				{
				}
				num = (short)654114817;
				if (num != 0)
				{
				}
				num = (short)708378624;
				if (num != 0)
				{
				}
				return this.radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314._HasDiffs;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x06005FB8 RID: 24504 RVA: 0x0055D410 File Offset: 0x0055B610
		// (set) Token: 0x06005FB9 RID: 24505 RVA: 0x0055D4C8 File Offset: 0x0055B6C8
		public int RadProfAudioSettingsExternalMicOtherNoiseMode_A21551Value
		{
			get
			{
				short num = (short)177012736;
				short num2 = num;
				num = (short)1842710591;
				short num3 = num;
				num = (short)1667860543;
				switch (num3 == num)
				{
				}
				num = (short)1679884289;
				if (num != 0)
				{
				}
				num = (short)1580531712;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Value;
			}
			set
			{
				short num = (short)1936785408;
				short num2 = num;
				num = (short)848022279;
				short num3 = num;
				num = (short)506055431;
				switch (num3 == num)
				{
				}
				num = (short)234815488;
				if (num != 0)
				{
				}
				num = (short)975634433;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Value = value;
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x06005FBA RID: 24506 RVA: 0x0055D57C File Offset: 0x0055B77C
		// (set) Token: 0x06005FBB RID: 24507 RVA: 0x0055D630 File Offset: 0x0055B830
		public string RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_UIValue
		{
			get
			{
				short num = (short)1707868160;
				short num2 = num;
				num = (short)1458890119;
				short num3 = num;
				num = (short)646702471;
				switch (num3 == num)
				{
				}
				num = (short)1730215936;
				if (num != 0)
				{
				}
				num = (short)258342913;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.UIValue;
			}
			set
			{
				short num = (short)248643584;
				short num2 = num;
				num = (short)1986723029;
				short num3 = num;
				num = (short)144899285;
				switch (num3 == num)
				{
				}
				num = (short)1510932481;
				if (num != 0)
				{
				}
				num = (short)1460011008;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.UIValue = value;
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x0055D6E4 File Offset: 0x0055B8E4
		public global::AcpBusinessLayer.AcpListField RadProfAudioSettingsExternalMicOtherNoiseMode_A21551
		{
			get
			{
				short num = (short)410517504;
				short num2 = num;
				num = (short)674080540;
				short num3 = num;
				num = (short)503424796;
				switch (num3 == num)
				{
				}
				num = (short)2019819521;
				if (num != 0)
				{
				}
				num = (short)793640960;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551;
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x06005FBD RID: 24509 RVA: 0x0055D794 File Offset: 0x0055B994
		// (set) Token: 0x06005FBE RID: 24510 RVA: 0x0055D848 File Offset: 0x0055BA48
		public bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_Applicable
		{
			get
			{
				short num = (short)2047410176;
				short num2 = num;
				num = (short)506893499;
				short num3 = num;
				num = (short)603165883;
				switch (num3 == num)
				{
				}
				num = (short)1341063169;
				if (num != 0)
				{
				}
				num = (short)1188364288;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Applicable;
			}
			set
			{
				short num = (short)913375232;
				short num2 = num;
				num = (short)1227720158;
				short num3 = num;
				num = (short)1073710558;
				switch (num3 == num)
				{
				}
				num = (short)2025455616;
				if (num != 0)
				{
				}
				num = (short)106102785;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Applicable = value;
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x0055D900 File Offset: 0x0055BB00
		// (set) Token: 0x06005FC0 RID: 24512 RVA: 0x0055D9B8 File Offset: 0x0055BBB8
		public bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_Valid
		{
			get
			{
				short num = (short)1628504064;
				short num2 = num;
				num = (short)1075393757;
				short num3 = num;
				num = (short)1407726813;
				switch (num3 == num)
				{
				}
				num = (short)640090113;
				if (num != 0)
				{
				}
				num = (short)777256960;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Valid;
			}
			set
			{
				short num = (short)1105461248;
				short num2 = num;
				num = (short)930556455;
				short num3 = num;
				num = (short)1433741863;
				switch (num3 == num)
				{
				}
				num = (short)1374289921;
				if (num != 0)
				{
				}
				num = (short)1536688128;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Valid = value;
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x0055DA6C File Offset: 0x0055BC6C
		// (set) Token: 0x06005FC2 RID: 24514 RVA: 0x0055DB20 File Offset: 0x0055BD20
		public bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_Visible
		{
			get
			{
				short num = (short)733609984;
				short num2 = num;
				num = (short)238124257;
				short num3 = num;
				num = (short)1745845473;
				switch (num3 == num)
				{
				}
				num = (short)916193280;
				if (num != 0)
				{
				}
				num = (short)513671169;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Visible;
			}
			set
			{
				short num = (short)19005440;
				short num2 = num;
				num = (short)433599707;
				short num3 = num;
				num = (short)1683764443;
				switch (num3 == num)
				{
				}
				num = (short)368443393;
				if (num != 0)
				{
				}
				num = (short)1908867072;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Visible = value;
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x0055DBD8 File Offset: 0x0055BDD8
		// (set) Token: 0x06005FC4 RID: 24516 RVA: 0x0055DC8C File Offset: 0x0055BE8C
		public bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_Editable
		{
			get
			{
				short num = (short)1360527360;
				short num2 = num;
				num = (short)1506684946;
				short num3 = num;
				num = (short)1187131410;
				switch (num3 == num)
				{
				}
				num = (short)242155521;
				if (num != 0)
				{
				}
				num = (short)1468071936;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Editable;
			}
			set
			{
				short num = (short)416219136;
				short num2 = num;
				num = (short)1421737754;
				short num3 = num;
				num = (short)1110310682;
				switch (num3 == num)
				{
				}
				num = (short)327286785;
				if (num != 0)
				{
				}
				num = (short)1510735872;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.Editable = value;
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x0055DD44 File Offset: 0x0055BF44
		internal string RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_UILabel
		{
			get
			{
				short num = (short)1031143424;
				short num2 = num;
				num = (short)1403987140;
				short num3 = num;
				num = (short)62137540;
				switch (num3 == num)
				{
				}
				num = (short)712048640;
				if (num != 0)
				{
				}
				num = (short)42074113;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.UIName;
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x0055DDF8 File Offset: 0x0055BFF8
		// (set) Token: 0x06005FC7 RID: 24519 RVA: 0x0055DEAC File Offset: 0x0055C0AC
		internal bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_HiddenStatic
		{
			get
			{
				short num = (short)1242431488;
				short num2 = num;
				num = (short)1047606796;
				short num3 = num;
				num = (short)1866806796;
				switch (num3 == num)
				{
				}
				num = (short)24903681;
				if (num != 0)
				{
				}
				num = (short)1772486656;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.HiddenStatic;
			}
			set
			{
				short num = (short)1979449344;
				short num2 = num;
				num = (short)1351416512;
				short num3 = num;
				num = (short)646970048;
				switch (num3 == num)
				{
				}
				num = (short)1477509121;
				if (num != 0)
				{
				}
				num = (short)811335680;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.HiddenStatic = value;
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x0055DF64 File Offset: 0x0055C164
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x0055E018 File Offset: 0x0055C218
		internal bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_HiddenDynamic
		{
			get
			{
				short num = (short)1888681984;
				short num2 = num;
				num = (short)815596237;
				short num3 = num;
				num = (short)97583821;
				switch (num3 == num)
				{
				}
				num = (short)593297408;
				if (num != 0)
				{
				}
				num = (short)1685716993;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.HiddenDynamic;
			}
			set
			{
				short num = (short)1400832000;
				short num2 = num;
				num = (short)1573191942;
				short num3 = num;
				num = (short)1971388678;
				switch (num3 == num)
				{
				}
				num = (short)377094144;
				if (num != 0)
				{
				}
				num = (short)1663500289;
				if (num != 0)
				{
				}
				this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551.HiddenDynamic = value;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x0055E0CC File Offset: 0x0055C2CC
		public bool RadProfAudioSettingsExternalMicOtherNoiseMode_A21551_HasDiffs
		{
			get
			{
				short num = (short)308346880;
				short num2 = num;
				num = (short)589036227;
				short num3 = num;
				num = (short)1012136643;
				switch (num3 == num)
				{
				}
				num = (short)1889271808;
				if (num != 0)
				{
				}
				num = (short)687341569;
				if (num != 0)
				{
				}
				return this.radProfAudioSettingsExternalMicOtherNoiseMode_A21551._HasDiffs;
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x06005FCB RID: 24523 RVA: 0x0055E180 File Offset: 0x0055C380
		// (set) Token: 0x06005FCC RID: 24524 RVA: 0x0055E234 File Offset: 0x0055C434
		public int RadProfLabtoolSecurenetBassControl_A19508Value
		{
			get
			{
				short num = (short)1923284992;
				short num2 = num;
				num = (short)1384194872;
				short num3 = num;
				num = (short)1139614520;
				switch (num3 == num)
				{
				}
				num = (short)1305608193;
				if (num != 0)
				{
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Value;
			}
			set
			{
				short num = (short)1837629440;
				short num2 = num;
				num = (short)1640205946;
				short num3 = num;
				num = (short)251825786;
				switch (num3 == num)
				{
				}
				num = (short)971243521;
				if (num != 0)
				{
				}
				num = (short)1210908672;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Value = value;
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x06005FCD RID: 24525 RVA: 0x0055E2E8 File Offset: 0x0055C4E8
		public global::AcpBusinessLayer.AcpRangeField<int, int> RadProfLabtoolSecurenetBassControl_A19508
		{
			get
			{
				short num = (short)1553530880;
				short num2 = num;
				num = (short)914297159;
				short num3 = num;
				num = (short)1066340679;
				switch (num3 == num)
				{
				}
				num = (short)1918304257;
				if (num != 0)
				{
				}
				num = (short)729874432;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508;
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x06005FCE RID: 24526 RVA: 0x0055E394 File Offset: 0x0055C594
		// (set) Token: 0x06005FCF RID: 24527 RVA: 0x0055E448 File Offset: 0x0055C648
		public int RadProfLabtoolSecurenetBassControl_A19508_UIValue
		{
			get
			{
				short num = (short)1377894400;
				short num2 = num;
				num = (short)2073190221;
				short num3 = num;
				num = (short)1390894925;
				switch (num3 == num)
				{
				}
				num = (short)764608512;
				if (num != 0)
				{
				}
				num = (short)1888747521;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.UIValue;
			}
			set
			{
				short num = (short)1289945088;
				short num2 = num;
				num = (short)1520840701;
				short num3 = num;
				num = (short)613822461;
				switch (num3 == num)
				{
				}
				num = (short)890765313;
				if (num != 0)
				{
				}
				num = (short)416808960;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.UIValue = value;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x06005FD0 RID: 24528 RVA: 0x0055E4FC File Offset: 0x0055C6FC
		// (set) Token: 0x06005FD1 RID: 24529 RVA: 0x0055E5B0 File Offset: 0x0055C7B0
		internal int RadProfLabtoolSecurenetBassControl_A19508Min
		{
			get
			{
				short num = (short)1870921728;
				short num2 = num;
				num = (short)2102639736;
				short num3 = num;
				num = (short)1117764728;
				switch (num3 == num)
				{
				}
				num = (short)1076101120;
				if (num != 0)
				{
				}
				num = (short)158859265;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Min;
			}
			set
			{
				short num = (short)1949696000;
				short num2 = num;
				num = (short)52151910;
				short num3 = num;
				num = (short)462014054;
				switch (num3 == num)
				{
				}
				num = (short)747634689;
				if (num != 0)
				{
				}
				num = (short)293142528;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Min = value;
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x0055E664 File Offset: 0x0055C864
		// (set) Token: 0x06005FD3 RID: 24531 RVA: 0x0055E718 File Offset: 0x0055C918
		internal int RadProfLabtoolSecurenetBassControl_A19508Max
		{
			get
			{
				short num = (short)893583360;
				short num2 = num;
				num = (short)1172507006;
				short num3 = num;
				num = (short)503908734;
				switch (num3 == num)
				{
				}
				num = (short)309264385;
				if (num != 0)
				{
				}
				num = (short)1378287616;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Max;
			}
			set
			{
				short num = (short)932970496;
				short num2 = num;
				num = (short)883549920;
				short num3 = num;
				num = (short)919529184;
				switch (num3 == num)
				{
				}
				num = (short)1046478849;
				if (num != 0)
				{
				}
				num = (short)1890058240;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Max = value;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x06005FD4 RID: 24532 RVA: 0x0055E7CC File Offset: 0x0055C9CC
		// (set) Token: 0x06005FD5 RID: 24533 RVA: 0x0055E880 File Offset: 0x0055CA80
		internal int RadProfLabtoolSecurenetBassControl_A19508Step
		{
			get
			{
				short num = (short)2016215040;
				short num2 = num;
				num = (short)458873044;
				short num3 = num;
				num = (short)2052839636;
				switch (num3 == num)
				{
				}
				num = (short)133693441;
				if (num != 0)
				{
				}
				num = (short)1524563968;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.StepSize;
			}
			set
			{
				short num = (short)836501504;
				short num2 = num;
				num = (short)1345781761;
				if (num != 0)
				{
				}
				num = (short)566168657;
				short num3 = num;
				num = (short)1313082449;
				switch (num3 == num)
				{
				}
				num = (short)1222836224;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.StepSize = value;
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x06005FD6 RID: 24534 RVA: 0x0055E938 File Offset: 0x0055CB38
		// (set) Token: 0x06005FD7 RID: 24535 RVA: 0x0055E9EC File Offset: 0x0055CBEC
		public bool RadProfLabtoolSecurenetBassControl_A19508_Applicable
		{
			get
			{
				short num = (short)963444736;
				short num2 = num;
				num = (short)88881205;
				short num3 = num;
				num = (short)2044016693;
				switch (num3 == num)
				{
				}
				num = (short)665452545;
				if (num != 0)
				{
				}
				num = (short)1158742016;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Applicable;
			}
			set
			{
				short num = (short)949944320;
				short num2 = num;
				num = (short)1131187211;
				short num3 = num;
				num = (short)1006210059;
				switch (num3 == num)
				{
				}
				num = (short)240189441;
				if (num != 0)
				{
				}
				num = (short)450887680;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Applicable = value;
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x0055EAA0 File Offset: 0x0055CCA0
		// (set) Token: 0x06005FD9 RID: 24537 RVA: 0x0055EB54 File Offset: 0x0055CD54
		public bool RadProfLabtoolSecurenetBassControl_A19508_Valid
		{
			get
			{
				short num = (short)1656291328;
				short num2 = num;
				num = (short)1054607818;
				short num3 = num;
				num = (short)1097468362;
				switch (num3 == num)
				{
				}
				num = (short)1559560193;
				if (num != 0)
				{
				}
				num = (short)1401946112;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Valid;
			}
			set
			{
				short num = (short)655491072;
				short num2 = num;
				num = (short)1716901141;
				short num3 = num;
				num = (short)179361045;
				switch (num3 == num)
				{
				}
				num = (short)288817153;
				if (num != 0)
				{
				}
				num = (short)771620864;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Valid = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x0055EC08 File Offset: 0x0055CE08
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x0055ECC0 File Offset: 0x0055CEC0
		public bool RadProfLabtoolSecurenetBassControl_A19508_Visible
		{
			get
			{
				short num = (short)1611988992;
				short num2 = num;
				num = (short)1867261479;
				short num3 = num;
				num = (short)1938630183;
				switch (num3 == num)
				{
				}
				num = (short)2053177344;
				if (num != 0)
				{
				}
				num = (short)1112211457;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Visible;
			}
			set
			{
				short num = (short)2002190336;
				short num2 = num;
				num = (short)559457824;
				short num3 = num;
				num = (short)1785112096;
				switch (num3 == num)
				{
				}
				num = (short)1959788544;
				if (num != 0)
				{
				}
				num = (short)1822162945;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Visible = value;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x06005FDC RID: 24540 RVA: 0x0055ED78 File Offset: 0x0055CF78
		// (set) Token: 0x06005FDD RID: 24541 RVA: 0x0055EE30 File Offset: 0x0055D030
		public bool RadProfLabtoolSecurenetBassControl_A19508_Editable
		{
			get
			{
				short num = (short)81985536;
				short num2 = num;
				num = (short)831947063;
				short num3 = num;
				num = (short)1591705911;
				switch (num3 == num)
				{
				}
				num = (short)1474363392;
				if (num != 0)
				{
				}
				num = (short)970063873;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.Editable;
			}
			set
			{
				short num = (short)1105579563;
				short num2 = num;
				num = (short)780717611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344929792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653669889;
				if (num != 0)
				{
				}
				num = (short)767754240;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.Editable = value;
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x06005FDE RID: 24542 RVA: 0x0055EEE8 File Offset: 0x0055D0E8
		internal string RadProfLabtoolSecurenetBassControl_A19508_UILabel
		{
			get
			{
				short num = (short)2052427969;
				short num2 = num;
				num = (short)597070017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854734336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351417857;
				if (num != 0)
				{
				}
				num = (short)1516109824;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.UIName;
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x0055EF9C File Offset: 0x0055D19C
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x0055F054 File Offset: 0x0055D254
		internal bool RadProfLabtoolSecurenetBassControl_A19508_HiddenStatic
		{
			get
			{
				short num = (short)593391677;
				short num2 = num;
				num = (short)1255960637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2035417088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319174145;
				if (num != 0)
				{
				}
				num = (short)126877696;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.HiddenStatic;
			}
			set
			{
				short num = (short)154241080;
				short num2 = num;
				num = (short)462915640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)169082880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742653953;
				if (num != 0)
				{
				}
				num = (short)1728839680;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.HiddenStatic = value;
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x0055F10C File Offset: 0x0055D30C
		// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x0055F1C0 File Offset: 0x0055D3C0
		internal bool RadProfLabtoolSecurenetBassControl_A19508_HiddenDynamic
		{
			get
			{
				short num = (short)1427978987;
				short num2 = num;
				num = (short)809581291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2072248320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955973632;
				if (num != 0)
				{
				}
				num = (short)403439617;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508.HiddenDynamic;
			}
			set
			{
				short num = (short)367209420;
				short num2 = num;
				num = (short)1324821452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064515072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1305804801;
				if (num != 0)
				{
				}
				num = (short)406388736;
				if (num != 0)
				{
				}
				this.radProfLabtoolSecurenetBassControl_A19508.HiddenDynamic = value;
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x0055F274 File Offset: 0x0055D474
		public bool RadProfLabtoolSecurenetBassControl_A19508_HasDiffs
		{
			get
			{
				short num = (short)1572079179;
				short num2 = num;
				num = (short)417662539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2101870592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567934976;
				if (num != 0)
				{
				}
				num = (short)141885441;
				if (num != 0)
				{
				}
				return this.radProfLabtoolSecurenetBassControl_A19508._HasDiffs;
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x0055F328 File Offset: 0x0055D528
		// (set) Token: 0x06005FE5 RID: 24549 RVA: 0x0055F3D8 File Offset: 0x0055D5D8
		public int RadProfLabtoolDigitalBassControl_A19507Value
		{
			get
			{
				short num = (short)2075308323;
				short num2 = num;
				num = (short)1216196899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081344000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458438145;
				if (num != 0)
				{
				}
				num = (short)918814720;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Value;
			}
			set
			{
				short num = (short)2044649974;
				short num2 = num;
				num = (short)332915190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719795712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1040646144;
				if (num != 0)
				{
				}
				num = (short)212992001;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Value = value;
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x06005FE6 RID: 24550 RVA: 0x0055F490 File Offset: 0x0055D690
		public global::AcpBusinessLayer.AcpRangeField<int, int> RadProfLabtoolDigitalBassControl_A19507
		{
			get
			{
				short num = (short)217855153;
				short num2 = num;
				num = (short)665793713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)805961728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913192448;
				if (num != 0)
				{
				}
				num = (short)98304001;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507;
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x0055F544 File Offset: 0x0055D744
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x0055F5F8 File Offset: 0x0055D7F8
		public int RadProfLabtoolDigitalBassControl_A19507_UIValue
		{
			get
			{
				short num = (short)842661919;
				short num2 = num;
				num = (short)2116157471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1628241920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1171521536;
				if (num != 0)
				{
				}
				num = (short)1592655873;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.UIValue;
			}
			set
			{
				short num = (short)1917838134;
				short num2 = num;
				num = (short)62317366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798490624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222298112;
				if (num != 0)
				{
				}
				num = (short)492371969;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.UIValue = value;
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x0055F6AC File Offset: 0x0055D8AC
		// (set) Token: 0x06005FEA RID: 24554 RVA: 0x0055F760 File Offset: 0x0055D960
		internal int RadProfLabtoolDigitalBassControl_A19507Min
		{
			get
			{
				short num = (short)1863245414;
				short num2 = num;
				num = (short)1289936486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220921856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2134310912;
				if (num != 0)
				{
				}
				num = (short)136314881;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Min;
			}
			set
			{
				short num = (short)839591458;
				short num2 = num;
				num = (short)911812130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)548864000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)870121472;
				if (num != 0)
				{
				}
				num = (short)1689452545;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Min = value;
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x0055F818 File Offset: 0x0055DA18
		// (set) Token: 0x06005FEC RID: 24556 RVA: 0x0055F8CC File Offset: 0x0055DACC
		internal int RadProfLabtoolDigitalBassControl_A19507Max
		{
			get
			{
				short num = (short)1061617962;
				short num2 = num;
				num = (short)1438253354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1723400192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951582721;
				if (num != 0)
				{
				}
				num = (short)1124794368;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Max;
			}
			set
			{
				short num = (short)1787979653;
				short num2 = num;
				num = (short)600532869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235288064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654128641;
				if (num != 0)
				{
				}
				num = (short)432603136;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Max = value;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x0055F984 File Offset: 0x0055DB84
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x0055FA38 File Offset: 0x0055DC38
		internal int RadProfLabtoolDigitalBassControl_A19507Step
		{
			get
			{
				short num = (short)1908223738;
				short num2 = num;
				num = (short)1445408506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1537212416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)569049088;
				if (num != 0)
				{
				}
				num = (short)57212929;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.StepSize;
			}
			set
			{
				short num = (short)1113149161;
				short num2 = num;
				num = (short)1546473193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305411584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1716060161;
				if (num != 0)
				{
				}
				num = (short)396230656;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.StepSize = value;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x0055FAEC File Offset: 0x0055DCEC
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x0055FBA0 File Offset: 0x0055DDA0
		public bool RadProfLabtoolDigitalBassControl_A19507_Applicable
		{
			get
			{
				short num = (short)397899512;
				short num2 = num;
				num = (short)1963947768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1552613376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494469121;
				if (num != 0)
				{
				}
				num = (short)873922560;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Applicable;
			}
			set
			{
				short num = (short)1924623290;
				short num2 = num;
				num = (short)647261114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98107392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1156907008;
				if (num != 0)
				{
				}
				num = (short)1503330305;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Applicable = value;
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x0055FC54 File Offset: 0x0055DE54
		// (set) Token: 0x06005FF2 RID: 24562 RVA: 0x0055FD0C File Offset: 0x0055DF0C
		public bool RadProfLabtoolDigitalBassControl_A19507_Valid
		{
			get
			{
				short num = (short)437433738;
				short num2 = num;
				num = (short)1719252362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615710720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908787713;
				if (num != 0)
				{
				}
				num = (short)838205440;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Valid;
			}
			set
			{
				short num = (short)1101742173;
				short num2 = num;
				num = (short)1006321757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099642368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752877569;
				if (num != 0)
				{
				}
				num = (short)1103167488;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Valid = value;
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x0055FDC0 File Offset: 0x0055DFC0
		// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x0055FE74 File Offset: 0x0055E074
		public bool RadProfLabtoolDigitalBassControl_A19507_Visible
		{
			get
			{
				short num = (short)1782177974;
				short num2 = num;
				num = (short)2053955766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1753415680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1655963649;
				if (num != 0)
				{
				}
				num = (short)1835663360;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Visible;
			}
			set
			{
				short num = (short)125274940;
				short num2 = num;
				num = (short)1272220476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992425472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826671105;
				if (num != 0)
				{
				}
				num = (short)977469440;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Visible = value;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x0055FF2C File Offset: 0x0055E12C
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x0055FFE0 File Offset: 0x0055E1E0
		public bool RadProfLabtoolDigitalBassControl_A19507_Editable
		{
			get
			{
				short num = (short)1368432381;
				short num2 = num;
				num = (short)296263421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1020985344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				num = (short)164036608;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.Editable;
			}
			set
			{
				short num = (short)1076321288;
				short num2 = num;
				num = (short)1198873608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)781385728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1731788800;
				if (num != 0)
				{
				}
				num = (short)84541441;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.Editable = value;
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x00560098 File Offset: 0x0055E298
		internal string RadProfLabtoolDigitalBassControl_A19507_UILabel
		{
			get
			{
				short num = (short)1688935894;
				short num2 = num;
				num = (short)751574486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928790016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443168257;
				if (num != 0)
				{
				}
				num = (short)1848639488;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.UIName;
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x0056014C File Offset: 0x0055E34C
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x00560204 File Offset: 0x0055E404
		internal bool RadProfLabtoolDigitalBassControl_A19507_HiddenStatic
		{
			get
			{
				short num = (short)1433552044;
				short num2 = num;
				num = (short)319767724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141819904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1229848577;
				if (num != 0)
				{
				}
				num = (short)115671040;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.HiddenStatic;
			}
			set
			{
				short num = (short)1558227151;
				short num2 = num;
				num = (short)1428334799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433258496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1226047489;
				if (num != 0)
				{
				}
				num = (short)850591744;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.HiddenStatic = value;
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x005602BC File Offset: 0x0055E4BC
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x00560370 File Offset: 0x0055E570
		internal bool RadProfLabtoolDigitalBassControl_A19507_HiddenDynamic
		{
			get
			{
				short num = (short)2129068033;
				if (num != 0)
				{
				}
				num = (short)1942749184;
				short num2 = num;
				num = (short)541992519;
				short num3 = num;
				num = (short)114435655;
				switch (num3 == num)
				{
				}
				num = (short)1465122816;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507.HiddenDynamic;
			}
			set
			{
				short num = (short)1442851333;
				short num2 = num;
				num = (short)1437870597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045102592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537212417;
				if (num != 0)
				{
				}
				num = (short)1354366976;
				if (num != 0)
				{
				}
				this.radProfLabtoolDigitalBassControl_A19507.HiddenDynamic = value;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x00560428 File Offset: 0x0055E628
		public bool RadProfLabtoolDigitalBassControl_A19507_HasDiffs
		{
			get
			{
				short num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)1336541184;
				short num2 = num;
				num = (short)294846109;
				short num3 = num;
				num = (short)1416494749;
				switch (num3 == num)
				{
				}
				num = (short)1538392064;
				if (num != 0)
				{
				}
				return this.radProfLabtoolDigitalBassControl_A19507._HasDiffs;
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x005604E0 File Offset: 0x0055E6E0
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x00560594 File Offset: 0x0055E794
		public int RadProfLabtoolAnalogBassControl_A19506Value
		{
			get
			{
				short num = (short)1936887787;
				short num2 = num;
				num = (short)1368625131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050752512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189281792;
				if (num != 0)
				{
				}
				num = (short)338034689;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Value;
			}
			set
			{
				short num = (short)1266973065;
				short num2 = num;
				num = (short)1853061513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)189464576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1677459456;
				if (num != 0)
				{
				}
				num = (short)873594881;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Value = value;
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x00560648 File Offset: 0x0055E848
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadProfLabtoolAnalogBassControl_A19506
		{
			get
			{
				short num = (short)1439446177;
				short num2 = num;
				num = (short)912077985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589706752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371144193;
				if (num != 0)
				{
				}
				num = (short)1529282560;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506;
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x005606F8 File Offset: 0x0055E8F8
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x005607AC File Offset: 0x0055E9AC
		public string RadProfLabtoolAnalogBassControl_A19506_UIValue
		{
			get
			{
				short num = (short)248082500;
				short num2 = num;
				num = (short)804876356;
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
				num = (short)567672833;
				if (num != 0)
				{
				}
				num = (short)190054400;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.UIValue;
			}
			set
			{
				short num = (short)1893501573;
				short num2 = num;
				num = (short)1972537989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248709120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202126849;
				if (num != 0)
				{
				}
				num = (short)1332150272;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.UIValue = value;
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x00560864 File Offset: 0x0055EA64
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x0056091C File Offset: 0x0055EB1C
		internal int RadProfLabtoolAnalogBassControl_A19506Min
		{
			get
			{
				short num = (short)1376583681;
				if (num != 0)
				{
				}
				num = (short)712769536;
				short num2 = num;
				num = (short)910138112;
				short num3 = num;
				num = (short)1502845696;
				switch (num3 == num)
				{
				}
				num = (short)1643315200;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Min;
			}
			set
			{
				short num = (short)2109690766;
				short num2 = num;
				num = (short)1993954190;
				switch (num2 == num)
				{
				}
				num = (short)1520238593;
				if (num != 0)
				{
				}
				num = (short)21823488;
				short num3 = num;
				num = (short)516423680;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Min = value;
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x005609D4 File Offset: 0x0055EBD4
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x00560A88 File Offset: 0x0055EC88
		internal int RadProfLabtoolAnalogBassControl_A19506Max
		{
			get
			{
				short num = (short)1805189121;
				if (num != 0)
				{
				}
				num = (short)1350034811;
				short num2 = num;
				num = (short)1304028539;
				switch (num2 == num)
				{
				}
				num = (short)1524170752;
				short num3 = num;
				num = (short)821559296;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Max;
			}
			set
			{
				short num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)401561857;
				short num2 = num;
				num = (short)507861249;
				switch (num2 == num)
				{
				}
				num = (short)528547840;
				short num3 = num;
				num = (short)123731968;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Max = value;
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x00560B40 File Offset: 0x0055ED40
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x00560BF4 File Offset: 0x0055EDF4
		internal int RadProfLabtoolAnalogBassControl_A19506Step
		{
			get
			{
				short num = (short)353140441;
				short num2 = num;
				num = (short)1330937561;
				switch (num2 == num)
				{
				}
				num = (short)414449664;
				if (num != 0)
				{
				}
				num = (short)771096576;
				short num3 = num;
				num = (short)1748107265;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.StepSize;
			}
			set
			{
				short num = (short)62577282;
				short num2 = num;
				num = (short)185326210;
				switch (num2 == num)
				{
				}
				num = (short)255197185;
				if (num != 0)
				{
				}
				num = (short)316276736;
				short num3 = num;
				num = (short)1326252032;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.StepSize = value;
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x00560CAC File Offset: 0x0055EEAC
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x00560D64 File Offset: 0x0055EF64
		public bool RadProfLabtoolAnalogBassControl_A19506_Applicable
		{
			get
			{
				short num = (short)1971950004;
				short num2 = num;
				num = (short)910266804;
				switch (num2 == num)
				{
				}
				num = (short)1871380481;
				if (num != 0)
				{
				}
				num = (short)1951858688;
				short num3 = num;
				num = (short)718340096;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Applicable;
			}
			set
			{
				short num = (short)1557268831;
				short num2 = num;
				num = (short)453249375;
				switch (num2 == num)
				{
				}
				num = (short)1111293953;
				if (num != 0)
				{
				}
				num = (short)1728118784;
				short num3 = num;
				num = (short)17629184;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Applicable = value;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x00560E1C File Offset: 0x0055F01C
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x00560ED0 File Offset: 0x0055F0D0
		public bool RadProfLabtoolAnalogBassControl_A19506_Valid
		{
			get
			{
				short num = (short)832766890;
				short num2 = num;
				num = (short)996737962;
				switch (num2 == num)
				{
				}
				num = (short)1393688577;
				if (num != 0)
				{
				}
				num = (short)1180368896;
				short num3 = num;
				num = (short)535298048;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Valid;
			}
			set
			{
				short num = (short)1272314477;
				short num2 = num;
				num = (short)1241578093;
				switch (num2 == num)
				{
				}
				num = (short)499580928;
				if (num != 0)
				{
				}
				num = (short)1413545984;
				short num3 = num;
				num = (short)954335233;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Valid = value;
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x00560F84 File Offset: 0x0055F184
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x00561038 File Offset: 0x0055F238
		public bool RadProfLabtoolAnalogBassControl_A19506_Visible
		{
			get
			{
				short num = (short)1733165057;
				if (num != 0)
				{
				}
				num = (short)330753582;
				short num2 = num;
				num = (short)1847780910;
				switch (num2 == num)
				{
				}
				num = (short)1197473792;
				short num3 = num;
				num = (short)2117337088;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Visible;
			}
			set
			{
				short num = (short)241631233;
				if (num != 0)
				{
				}
				num = (short)1554265866;
				short num2 = num;
				num = (short)774387466;
				switch (num2 == num)
				{
				}
				num = (short)2042298368;
				short num3 = num;
				num = (short)585302016;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Visible = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x005610EC File Offset: 0x0055F2EC
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x005611A0 File Offset: 0x0055F3A0
		public bool RadProfLabtoolAnalogBassControl_A19506_Editable
		{
			get
			{
				short num = (short)1294214278;
				short num2 = num;
				num = (short)1719739526;
				switch (num2 == num)
				{
				}
				num = (short)1004470273;
				if (num != 0)
				{
				}
				num = (short)1784807424;
				short num3 = num;
				num = (short)1650786304;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.Editable;
			}
			set
			{
				short num = (short)1372838608;
				short num2 = num;
				num = (short)1899616976;
				switch (num2 == num)
				{
				}
				num = (short)176095233;
				if (num != 0)
				{
				}
				num = (short)1995767808;
				short num3 = num;
				num = (short)1564147712;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.Editable = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x00561258 File Offset: 0x0055F458
		internal string RadProfLabtoolAnalogBassControl_A19506_UILabel
		{
			get
			{
				short num = (short)654935595;
				short num2 = num;
				num = (short)565872171;
				switch (num2 == num)
				{
				}
				num = (short)2134704129;
				if (num != 0)
				{
				}
				num = (short)1015611392;
				short num3 = num;
				num = (short)35323904;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.UIName;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x06006011 RID: 24593 RVA: 0x0056130C File Offset: 0x0055F50C
		// (set) Token: 0x06006012 RID: 24594 RVA: 0x005613C4 File Offset: 0x0055F5C4
		internal bool RadProfLabtoolAnalogBassControl_A19506_HiddenStatic
		{
			get
			{
				short num = (short)634302255;
				short num2 = num;
				num = (short)388214575;
				switch (num2 == num)
				{
				}
				num = (short)539361281;
				if (num != 0)
				{
				}
				num = (short)1487798272;
				short num3 = num;
				num = (short)1998716928;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.HiddenStatic;
			}
			set
			{
				short num = (short)680868454;
				short num2 = num;
				num = (short)784939622;
				switch (num2 == num)
				{
				}
				num = (short)2045902848;
				if (num != 0)
				{
				}
				num = (short)1964244992;
				short num3 = num;
				num = (short)2020605953;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.HiddenStatic = value;
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x0056147C File Offset: 0x0055F67C
		// (set) Token: 0x06006014 RID: 24596 RVA: 0x00561530 File Offset: 0x0055F730
		internal bool RadProfLabtoolAnalogBassControl_A19506_HiddenDynamic
		{
			get
			{
				short num = (short)628607916;
				short num2 = num;
				num = (short)666225580;
				switch (num2 == num)
				{
				}
				num = (short)1378222081;
				if (num != 0)
				{
				}
				num = (short)1003880448;
				short num3 = num;
				num = (short)1544355840;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506.HiddenDynamic;
			}
			set
			{
				short num = (short)1884261838;
				short num2 = num;
				num = (short)350850510;
				switch (num2 == num)
				{
				}
				num = (short)250281985;
				if (num != 0)
				{
				}
				num = (short)1573650432;
				short num3 = num;
				num = (short)1228800000;
				if (num != 0)
				{
				}
				this.radProfLabtoolAnalogBassControl_A19506.HiddenDynamic = value;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x005615E4 File Offset: 0x0055F7E4
		public bool RadProfLabtoolAnalogBassControl_A19506_HasDiffs
		{
			get
			{
				short num = (short)671133707;
				short num2 = num;
				num = (short)1432727563;
				switch (num2 == num)
				{
				}
				num = (short)1479016449;
				if (num != 0)
				{
				}
				num = (short)164429824;
				short num3 = num;
				num = (short)1919221760;
				if (num != 0)
				{
				}
				return this.radProfLabtoolAnalogBassControl_A19506._HasDiffs;
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x00561698 File Offset: 0x0055F898
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)968942849;
				short num2 = num;
				num = (short)1551033601;
				switch (num2 == num)
				{
				}
				num = (short)919732224;
				if (num != 0)
				{
				}
				num = (short)1351352320;
				short num3 = num;
				num = (short)1519583233;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x00561754 File Offset: 0x0055F954
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
					goto IL_117;
				case 1:
				{
					num2 = (short)2010310971;
					short num3 = num2;
					num2 = (short)273803579;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_117;
					default:
						num2 = (short)1840840704;
						if (num2 != 0)
						{
						}
						num2 = (short)724107264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1223294979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1714618369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_117:
				num2 = (short)1461321729;
				if (num2 != 0)
				{
				}
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)310509570;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1015545856;
			short num4 = num2;
			num2 = (short)852426756;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002347 RID: 9031
		private global::AcpBusinessLayer.AcpListField radProfLabtoolExternalMicSourceMode_A21548;

		// Token: 0x04002348 RID: 9032
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicDirectivityMode_A21549;

		// Token: 0x04002349 RID: 9033
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicWindNoiseReductionMode_A21550;

		// Token: 0x0400234A RID: 9034
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicSourceMode_A22193;

		// Token: 0x0400234B RID: 9035
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicDirectivityMode_A22195;

		// Token: 0x0400234C RID: 9036
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicOtherNoiseMode_A22196;

		// Token: 0x0400234D RID: 9037
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicWindNoiseReductionMode_A22197;

		// Token: 0x0400234E RID: 9038
		private global::AcpBusinessLayer.AcpRecRefField radProfCustomAudioInternalMicNoiseReductionProfileCompositeItemID_A22312;

		// Token: 0x0400234F RID: 9039
		private global::AcpBusinessLayer.AcpRecRefField radProfLabtoolCustomAudioExtMicNoiseReductionProfileCompositeItemID_A22314;

		// Token: 0x04002350 RID: 9040
		private global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicOtherNoiseMode_A21551;

		// Token: 0x04002351 RID: 9041
		private global::AcpBusinessLayer.AcpRangeField<int, int> radProfLabtoolSecurenetBassControl_A19508;

		// Token: 0x04002352 RID: 9042
		private global::AcpBusinessLayer.AcpRangeField<int, int> radProfLabtoolDigitalBassControl_A19507;

		// Token: 0x04002353 RID: 9043
		private global::AcpBusinessLayer.AcpRangeField<int, string> radProfLabtoolAnalogBassControl_A19506;
	}
}
